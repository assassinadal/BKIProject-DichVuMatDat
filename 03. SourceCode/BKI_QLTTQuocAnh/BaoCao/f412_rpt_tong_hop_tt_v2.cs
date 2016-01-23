using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IP.Core.IPCommon;
using BKI_DichVuMatDat.US;
using BKI_DichVuMatDat.DS;

namespace BKI_DichVuMatDat.BaoCao
{
    public partial class f412_rpt_tong_hop_tt_v2 : Form
    {
        #region Public Interface
        public f412_rpt_tong_hop_tt_v2()
        {
            InitializeComponent();
        }
        #endregion

        #region Member
        int m_work_fail = 0;
        #endregion


        #region Private Method
        private void load_data_2_grid()
        {
            CHRMCommon.make_stt(m_adv_tong_hop);
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithQuery(v_ds, "SELECT * FROM V_RPT_BAO_CAO_TONG_HOP_V2 WHERE THANG = " + m_txt_thang.Text.Trim() + " AND NAM = " + m_txt_nam.Text.Trim() + " order by THU_TU_HIEN_THI, THU_TU_CHUC_VU, TEN, HO_DEM");
            m_grc_tong_hop.DataSource = v_ds.Tables[0];
            m_grc_tong_hop.RefreshDataSource();

        }
        private DS_RPT_THONG_TIN_TONG_HOP_V2 lay_danh_sach_nhan_vien_can_tong_hop_thong_tin()
        {
            US_RPT_THONG_TIN_TONG_HOP_V2 v_us = new US_RPT_THONG_TIN_TONG_HOP_V2();
            DS_RPT_THONG_TIN_TONG_HOP_V2 v_ds = new DS_RPT_THONG_TIN_TONG_HOP_V2();
            v_us.Get_tat_ca_nhan_vien_can_tong_hop_thong_tin(v_ds, CIPConvert.ToDecimal(m_txt_thang.Text.Trim()), CIPConvert.ToDecimal(m_txt_nam.Text.Trim()));
            return v_ds;
        }

        private bool check_validate_data_is_ok(string ip_str_thang_cham_cong)
        {
            if (m_txt_thang.Text.Trim() == "" || m_txt_nam.Text.Trim() == "")
            {
                CHRM_BaseMessages.MsgBox_Infor(CONST_ID_MSGBOX.ERROR_CHUA_NHAP_THANG_NAM);
                return false;
            }
            else
            {
                for (int i = 0; i < ip_str_thang_cham_cong.Length; i++)
                {
                    if (char.IsDigit(ip_str_thang_cham_cong[i]) == false)
                    {
                        CHRM_BaseMessages.MsgBox_Infor(CONST_ID_MSGBOX.ERROR_DU_LIEU_NHAP_CHUA_HOP_LE);
                        return false;
                    }
                }
                m_work_fail = 1;
                return true;

            }
        }

        private void tong_hop_bao_cao(DS_RPT_THONG_TIN_TONG_HOP_V2 ip_ds, BackgroundWorker ip_bgw)
        {
            var ip_dt = ip_ds.Tables[0];

            for (int i = 0; i < ip_dt.Rows.Count; i++)
            {
                DataRow v_dr = ip_dt.Rows[i];
                decimal v_id_nhan_vien = CIPConvert.ToDecimal(v_dr["ID_NHAN_VIEN"]);

                //B1: Tong hop thong tin 1 nhan vien
                DataRow v_dr_thong_tin_tong_hop = CHRMCommon.get_thong_tin_tong_hop_1_nhan_vien_v2(v_id_nhan_vien, int.Parse(m_txt_thang.Text.Trim()), int.Parse(m_txt_nam.Text.Trim()));
                //B2: Insert vao Rpt
                CHRMCommon.insertThongTinTongHopNV2RPTV2(v_dr_thong_tin_tong_hop);
                ip_bgw.ReportProgress((i + 1) * 100 / ip_dt.Rows.Count);
            }
        }

        #endregion

        #region Event Handle
        private void m_bgwk_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                BackgroundWorker worker = sender as BackgroundWorker;
                if (check_validate_data_is_ok(m_txt_thang.Text.Trim()) && check_validate_data_is_ok(m_txt_nam.Text.Trim()))
                {
                    var v_ds_nv_can_tong_hop = lay_danh_sach_nhan_vien_can_tong_hop_thong_tin();
                    tong_hop_bao_cao(v_ds_nv_can_tong_hop, worker);
                }
            }
            catch (Exception v_e)
            {
                CHRM_BaseMessages.MsgBox_Infor("Có tý tẹo vấn đề. Bạn chụp ảnh và gửi để chúng tôi hỗ trợ nhé! " + v_e.ToString());
            }
        }

        private void m_bgwk_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            try
            {
                this.m_prb.Text = (e.ProgressPercentage.ToString() + "%");
                this.m_prb.EditValue = e.ProgressPercentage;
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_bgwk_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                this.m_prb.Visible = false;
                this.m_panel.Visible = false;
                if (m_work_fail == 1)
                {
                    load_data_2_grid();
                }

            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void f413_rpt_tong_hop_thong_tin_Load(object sender, EventArgs e)
        {
            try
            {
                m_prb.Visible = false;
                this.m_panel.Visible = false;
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_tinh_Click(object sender, EventArgs e)
        {
            try
            {
                if (m_bgwk.IsBusy)
                {
                    m_bgwk.CancelAsync();
                    return;
                }
                this.m_prb.Visible = true;
                this.m_panel.Visible = true;
                m_bgwk.RunWorkerAsync();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        #endregion

        private void m_cmd_luu_bang_luong_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "xls files (*.xls)|*.xls|All files (*.*)|*.*";
                saveFileDialog1.RestoreDirectory = true;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    m_grc_tong_hop.ExportToXls(saveFileDialog1.FileName);
                    CHRM_BaseMessages.MsgBox_Infor(CONST_ID_MSGBOX.INFOR_LUU_BAO_CAO_THANH_CONG);
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
    }
}
