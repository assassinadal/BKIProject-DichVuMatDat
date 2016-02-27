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
using BKI_DichVuMatDat.DS.CDBNames;

namespace BKI_DichVuMatDat.BaoCao
{

    public partial class f413_rpt_tong_hop_thong_tin : Form
    {
        #region Public Interface
        public f413_rpt_tong_hop_thong_tin()
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

            //US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            //DataSet v_ds = new DataSet();
            //v_ds.Tables.Add(new DataTable());
            //string filter = "SELECT * FROM V_RPT_BAO_CAO_TONG_HOP WHERE THANG = " + m_txt_thang.Text.Trim() + " AND NAM = " + m_txt_nam.Text.Trim() + " order by THU_TU_HIEN_THI, THU_TU_CHUC_VU, TEN, HO_DEM";
            //v_us.FillDatasetWithQuery(v_ds, filter);


            US_RPT_THONG_TIN_TONG_HOP v_us = new US_RPT_THONG_TIN_TONG_HOP();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.HienThiBaoCao(v_ds, Convert.ToDecimal(m_txt_thang.Text), Convert.ToDecimal(m_txt_nam.Text));

            m_grc_tong_hop.DataSource = v_ds.Tables[0];
            m_grc_tong_hop.RefreshDataSource();

        }
        private DS_RPT_THONG_TIN_TONG_HOP lay_danh_sach_nhan_vien_can_tong_hop_thong_tin()
        {
                US_RPT_THONG_TIN_TONG_HOP v_us = new US_RPT_THONG_TIN_TONG_HOP();
                DS_RPT_THONG_TIN_TONG_HOP v_ds = new DS_RPT_THONG_TIN_TONG_HOP();
                v_us.Get_tat_ca_nhan_vien_can_tong_hop_thong_tin(v_ds, CIPConvert.ToDecimal(m_txt_thang.Text.Trim()), CIPConvert.ToDecimal(m_txt_nam.Text.Trim()));
                return v_ds; 
        }

        private bool check_validate_data_is_ok(string ip_str_thang_cham_cong)
        {
            if (m_txt_thang.Text.Trim() == "" || m_txt_nam.Text.Trim() =="")
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
        public void DataRow2USThongTinTongHop(DataRow v_dr_luong_1_nv, US_RPT_THONG_TIN_TONG_HOP v_us)
        {
            //v_us.dcID = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP.ID].ToString());
            v_us.dcTHANG = Convert.ToDecimal(v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP.THANG]);
            v_us.dcNAM = Convert.ToDecimal(v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP.NAM]);
            v_us.dcID_NHAN_VIEN = (decimal)v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP.ID_NHAN_VIEN];
            v_us.strMA_NV = v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP.MA_NV].ToString();
            v_us.strHO_DEM = v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP.HO_DEM].ToString();
            v_us.strTEN = v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP.TEN].ToString();
            v_us.strHO_VA_TEN = v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP.HO_VA_TEN].ToString();
            v_us.strTEN_CHUC_VU = v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP.TEN_CHUC_VU].ToString();
            v_us.strTEN_HOP_DONG = v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP.TEN_HOP_DONG].ToString();
            v_us.dcLUONG_CHE_DO_THEO_CHUC_VU = (decimal)v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP.LUONG_CHE_DO_THEO_CHUC_VU];
            v_us.dcHS_LUONG_NANG_SUAT_DUOC_HUONG = (decimal)v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP.HS_LUONG_NANG_SUAT_DUOC_HUONG];
            v_us.strTAI_KHOAN = v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP.TAI_KHOAN].ToString();
            v_us.dcCHAM_CONG_X = Convert.ToDecimal(v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP.CHAM_CONG_X]);
            v_us.dcCHAM_CONG_OM_CO = Convert.ToDecimal(v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP.CHAM_CONG_OM_CO]);
            v_us.dcCHAM_CONG_TS = Convert.ToDecimal(v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP.CHAM_CONG_TS]);
            v_us.dcCHAM_CONG_TNLD = Convert.ToDecimal(v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP.CHAM_CONG_TNLD]);
            v_us.dcCHAM_CONG_PHEP_DIDUONG = Convert.ToDecimal(v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP.CHAM_CONG_PHEP_DIDUONG]);
            v_us.dcCHAM_CONG_RO_KO_DC = Convert.ToDecimal(v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP.CHAM_CONG_RO_KO_DC]);
            v_us.dcCHAM_CONG_KHAC = Convert.ToDecimal(v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP.CHAM_CONG_KHAC]);
            v_us.dcHE_SO_K = Convert.ToDecimal(v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP.HE_SO_K]);
            v_us.strDON_VI = v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP.DON_VI].ToString();
        }
        public void insertThongTinTongHopNV2RPT(DataRow v_dr_luong_1_nv)
        {
            US_RPT_THONG_TIN_TONG_HOP v_us = new US_RPT_THONG_TIN_TONG_HOP();
            DataRow2USThongTinTongHop(v_dr_luong_1_nv, v_us);
            v_us.Insert();
        }
        public DataRow get_thong_tin_tong_hop_1_nhan_vien(decimal ip_dc_id_nhan_vien, int ip_int_thang, int ip_int_nam)
        {
            US_RPT_THONG_TIN_TONG_HOP v_us = new US_RPT_THONG_TIN_TONG_HOP();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillThongTinTongHopNhanVien(v_ds, ip_dc_id_nhan_vien, ip_int_thang, ip_int_nam);
            DataRow v_dr = v_ds.Tables[0].Rows[0];
            return v_dr;
        }
        private void tong_hop_bao_cao(DS_RPT_THONG_TIN_TONG_HOP ip_ds, BackgroundWorker ip_bgw)
        {
            var ip_dt = ip_ds.Tables[0];

            for(int i = 0; i < ip_dt.Rows.Count; i++)
            {
                DataRow v_dr = ip_dt.Rows[i];
                decimal v_id_nhan_vien = CIPConvert.ToDecimal(v_dr["ID_NHAN_VIEN"]);

                //B1: Tong hop thong tin 1 nhan vien
                DataRow v_dr_thong_tin_tong_hop = get_thong_tin_tong_hop_1_nhan_vien(v_id_nhan_vien, int.Parse(m_txt_thang.Text.Trim()), int.Parse(m_txt_nam.Text.Trim()));
                //B2: Insert vao Rpt
                insertThongTinTongHopNV2RPT(v_dr_thong_tin_tong_hop);
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
            catch(Exception v_e)
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
            catch(Exception v_e)
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
                if (m_work_fail == 1 )
                {
                    load_data_2_grid();
                }

            }
            catch(Exception v_e)
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
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_tinh_Click(object sender, EventArgs e)
        {
            try
            {
                if(m_bgwk.IsBusy)
                {
                    m_bgwk.CancelAsync();
                    return;
                }
                this.m_prb.Visible = true;
                this.m_panel.Visible = true;
                m_bgwk.RunWorkerAsync();
            }
            catch(Exception v_e)
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
                if(saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    m_grc_tong_hop.ExportToXls(saveFileDialog1.FileName);
                    CHRM_BaseMessages.MsgBox_Infor(CONST_ID_MSGBOX.INFOR_LUU_BAO_CAO_THANH_CONG);
                }
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

    }
}
