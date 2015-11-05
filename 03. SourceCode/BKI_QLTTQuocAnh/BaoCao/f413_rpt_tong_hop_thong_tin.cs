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

    public partial class f413_rpt_tong_hop_thong_tin : Form
    {
        #region Public Interface
        public f413_rpt_tong_hop_thong_tin()
        {
            InitializeComponent();
        }
        #endregion

        #region Private Method
        private void load_data_2_grid()
        {

        }
        private DS_RPT_THONG_TIN_TONG_HOP lay_danh_sach_nhan_vien_can_tong_hop_thong_tin()
        {
            US_RPT_THONG_TIN_TONG_HOP v_us = new US_RPT_THONG_TIN_TONG_HOP();
            DS_RPT_THONG_TIN_TONG_HOP v_ds = new DS_RPT_THONG_TIN_TONG_HOP();
            v_us.Get_tat_ca_nhan_vien_can_tong_hop_thong_tin(v_ds, CIPConvert.ToDecimal(m_txt_thang.Text.Trim()), CIPConvert.ToDecimal(m_txt_nam.Text.Trim()));

            return v_ds;
        }
        private void tong_hop_bao_cao(DS_RPT_THONG_TIN_TONG_HOP ip_ds, BackgroundWorker ip_bgw)
        {
            var ip_dt = ip_ds.Tables[0];

            for(int i = 0; i < ip_dt.Rows.Count; i++)
            {
                DataRow v_dr = ip_dt.Rows[i];
                decimal v_id_nhan_vien = CIPConvert.ToDecimal(v_dr["ID_NHAN_VIEN"]);

                //B1: Tong hop thong tin 1 nhan vien
                DataRow v_dr_thong_tin_tong_hop = CCommon.get_thong_tin_tong_hop_1_nhan_vien(v_id_nhan_vien, int.Parse(m_txt_thang.Text.Trim()), int.Parse(m_txt_nam.Text.Trim()));
                //
                CCommon.insertThongTinTongHopNV2RPT(v_dr_thong_tin_tong_hop);
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
                var v_ds_nv_can_tong_hop = lay_danh_sach_nhan_vien_can_tong_hop_thong_tin();
                tong_hop_bao_cao(v_ds_nv_can_tong_hop, worker);
            }
            catch(Exception v_e)
            {
                MessageBox.Show("Có tý tẹo vấn đề. Bạn chụp ảnh và gửi để chúng tôi hỗ trợ nhé! " + v_e.ToString());
            }
        }

        private void m_bgwk_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.m_prb.Text = (e.ProgressPercentage.ToString() + "%");
            this.m_prb.EditValue = e.ProgressPercentage;
        }

        private void m_bgwk_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                this.m_prb.Visible = false;
                load_data_2_grid();
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
                m_bgwk.RunWorkerAsync();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        #endregion
        
    }
}
