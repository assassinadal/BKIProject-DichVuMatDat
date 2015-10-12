using IP.Core.IPCommon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BKI_DichVuMatDat;
using BKI_DichVuMatDat.DS;
using BKI_DichVuMatDat.DS.CDBNames;
using BKI_DichVuMatDat.US;
using DevExpress.Spreadsheet;
using DevExpress.XtraSplashScreen;


namespace BKI_DichVuMatDat.BaoCao
{
    public partial class f410_rpt_bang_luong_nv : Form
    {
        public f410_rpt_bang_luong_nv()
        {
            InitializeComponent();
        }

        #region Public Interface
        public void display()
        {
            this.m_grv.BestFitColumns(true);
            this.ShowDialog();
        }
        #endregion

        #region Data Structure
       
        #endregion

        #region Members
        DS_RPT_LUONG m_ds = new DS_RPT_LUONG();
        #endregion

        #region Private Methods
        private void tinhBangLuong(BackgroundWorker ip_bgw)
        {
            try
            {
                US_RPT_LUONG v_us = new US_RPT_LUONG();
                DS_RPT_LUONG v_ds = new DS_RPT_LUONG();
                v_us.Get_tat_ca_nhan_vien_can_tinh_luong(v_ds,CIPConvert.ToDecimal(m_txt_thang.Text.Trim()), CIPConvert.ToDecimal(m_txt_nam.Text.Trim()));
                get_bang_luong_tat_ca_nhan_vien(v_ds.Tables[0], ip_bgw);
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }            
        }

        private void get_bang_luong_tat_ca_nhan_vien(DataTable ip_dt, BackgroundWorker ip_bgw)
        {
            for (int i = 0; i < ip_dt.Rows.Count; i++)
            {
                DataRow v_dr = ip_dt.Rows[i];
                decimal v_id_nhan_vien = CIPConvert.ToDecimal(v_dr["ID_NHAN_VIEN"]);
                DataRow v_dr_luong = get_luong_1_nhan_vien(v_id_nhan_vien, int.Parse(m_txt_thang.Text.Trim()), int.Parse(m_txt_nam.Text.Trim()));
                var v_dr_luong_nv = m_ds.Tables[0].NewRow();
                DataRow v_dr_luong_1_nv = get_dr(v_dr_luong_nv, v_dr_luong, v_id_nhan_vien, i, int.Parse(m_txt_thang.Text.Trim()), int.Parse(m_txt_nam.Text.Trim()));
                m_ds.Tables[0].Rows.Add(v_dr_luong_1_nv);
                insertLuongNV2RPT(v_dr_luong_1_nv);
                ip_bgw.ReportProgress((i + 1) * 100 / ip_dt.Rows.Count);
            }
        }

        private void insertLuongNV2RPT(DataRow v_dr_luong_1_nv)
        {
            US_RPT_LUONG v_us = new US_RPT_LUONG();
            v_us.strMA_NV = v_dr_luong_1_nv[RPT_LUONG.MA_NV].ToString();
            v_us.dcAN_CA = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.AN_CA].ToString());
            v_us.dcBHTN = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.BHTN].ToString());
            v_us.dcBHXH = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.BHXH].ToString());
            v_us.dcBHYT = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.BHYT].ToString());
            v_us.dcDOAN_PHI_CD = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.DOAN_PHI_CD].ToString());
            v_us.dcID_NHAN_VIEN = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.ID_NHAN_VIEN].ToString());
            v_us.dcLAM_THEM = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.LAM_THEM].ToString());
            v_us.dcLAM_THEM_LE_TET = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.LAM_THEM_LE_TET].ToString());
            v_us.dcLUONG_CD = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.LUONG_CD].ToString());
            v_us.dcLUONG_KHAC_THUE_10 = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.LUONG_KHAC_THUE_10].ToString());
            v_us.dcLUONG_KHAC_THUE_5 = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.LUONG_KHAC_THUE_5].ToString());
            v_us.dcLUONG_KHAC_THUE_TINH_THEO_LUONG = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.LUONG_KHAC_THUE_TINH_THEO_LUONG].ToString());
            v_us.dcLUONG_NS = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.LUONG_NS].ToString());
            v_us.dcNAM = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.NAM].ToString());
            v_us.dcPHAI_NOP = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.PHAI_NOP].ToString());
            v_us.dcPHU_CAP_TN = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.PHU_CAP_TN].ToString());
            v_us.dcTHANG = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.THANG].ToString());
            v_us.dcTHU_NHAP = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.THU_NHAP].ToString());
            v_us.dcTHUC_LINH = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.THUC_LINH].ToString());
            v_us.dcTHUC_LINH_CUOI_CUNG = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.THUC_LINH_CUOI_CUNG].ToString());
            v_us.dcTHUE = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.THUE].ToString());
            v_us.dcTHUE_TU_LUONG_KHAC_10 = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.THUE_TU_LUONG_KHAC_10].ToString());
            v_us.dcTHUE_TU_LUONG_KHAC_5 = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.THUE_TU_LUONG_KHAC_5].ToString());
            v_us.dcTRUY_LINH = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.TRUY_LINH].ToString());
            v_us.dcTRUY_THU = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.TRUY_THU].ToString());
            v_us.Insert();
        }

        private DataRow get_dr(DataRow ip_dr_luong_nv,DataRow ip_dr_luong, decimal ip_id_nv, int ip_index, int ip_thang, int ip_nam)
        {
            ip_dr_luong_nv[RPT_LUONG.ID] = ip_index;
            ip_dr_luong_nv[RPT_LUONG.ID_NHAN_VIEN] = ip_id_nv;
            ip_dr_luong_nv[RPT_LUONG.THANG] = ip_thang;
            ip_dr_luong_nv[RPT_LUONG.NAM] = ip_nam;
            ip_dr_luong_nv[RPT_LUONG.MA_NV] = ip_dr_luong[RPT_LUONG.MA_NV];
            ip_dr_luong_nv[RPT_LUONG.LUONG_NS] = ip_dr_luong[RPT_LUONG.LUONG_NS];
            ip_dr_luong_nv[RPT_LUONG.LUONG_CD] = ip_dr_luong[RPT_LUONG.LUONG_CD];
            ip_dr_luong_nv[RPT_LUONG.PHU_CAP_TN] = ip_dr_luong[RPT_LUONG.PHU_CAP_TN];
            ip_dr_luong_nv[RPT_LUONG.AN_CA] = ip_dr_luong[RPT_LUONG.AN_CA];
            ip_dr_luong_nv[RPT_LUONG.LAM_THEM] = ip_dr_luong[RPT_LUONG.LAM_THEM];
            ip_dr_luong_nv[RPT_LUONG.LAM_THEM_LE_TET] = ip_dr_luong[RPT_LUONG.LAM_THEM_LE_TET];
            ip_dr_luong_nv[RPT_LUONG.LUONG_KHAC_THUE_5] = ip_dr_luong[RPT_LUONG.LUONG_KHAC_THUE_5];
            ip_dr_luong_nv[RPT_LUONG.LUONG_KHAC_THUE_10] = ip_dr_luong[RPT_LUONG.LUONG_KHAC_THUE_10];
            ip_dr_luong_nv[RPT_LUONG.LUONG_KHAC_THUE_TINH_THEO_LUONG] = ip_dr_luong[RPT_LUONG.LUONG_KHAC_THUE_TINH_THEO_LUONG];
            ip_dr_luong_nv[RPT_LUONG.THU_NHAP] = ip_dr_luong[RPT_LUONG.THU_NHAP];
            ip_dr_luong_nv[RPT_LUONG.BHXH] = ip_dr_luong[RPT_LUONG.BHXH];
            ip_dr_luong_nv[RPT_LUONG.BHYT] = ip_dr_luong[RPT_LUONG.BHYT];
            ip_dr_luong_nv[RPT_LUONG.BHTN] = ip_dr_luong[RPT_LUONG.BHTN];
            ip_dr_luong_nv[RPT_LUONG.DOAN_PHI_CD] = ip_dr_luong[RPT_LUONG.DOAN_PHI_CD];
            ip_dr_luong_nv[RPT_LUONG.THUE] = ip_dr_luong[RPT_LUONG.THUE];
            ip_dr_luong_nv[RPT_LUONG.THUE_TU_LUONG_KHAC_5] = ip_dr_luong[RPT_LUONG.THUE_TU_LUONG_KHAC_5];
            ip_dr_luong_nv[RPT_LUONG.THUE_TU_LUONG_KHAC_10] = ip_dr_luong[RPT_LUONG.THUE_TU_LUONG_KHAC_10];
            ip_dr_luong_nv[RPT_LUONG.PHAI_NOP] = ip_dr_luong[RPT_LUONG.PHAI_NOP];
            ip_dr_luong_nv[RPT_LUONG.THUC_LINH] = ip_dr_luong[RPT_LUONG.THUC_LINH];
            ip_dr_luong_nv[RPT_LUONG.TRUY_LINH] = ip_dr_luong[RPT_LUONG.TRUY_LINH];
            ip_dr_luong_nv[RPT_LUONG.TRUY_THU] = ip_dr_luong[RPT_LUONG.TRUY_THU];
            ip_dr_luong_nv[RPT_LUONG.THUC_LINH_CUOI_CUNG] = ip_dr_luong[RPT_LUONG.THUC_LINH_CUOI_CUNG];
            return ip_dr_luong_nv;
        }

        private DataRow get_luong_1_nhan_vien(decimal ip_dc_id_nhan_vien, int ip_int_thang, int ip_int_nam)
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillBangLuong(v_ds, ip_dc_id_nhan_vien, ip_int_thang, ip_int_nam);
            DataRow v_dr = v_ds.Tables[0].Rows[0];
            return v_dr;
        }
        #endregion

        private void m_cmd_bang_luong_Click(object sender, EventArgs e)
        {
            try
            {
                if (m_bgwk.IsBusy)
                {
                    m_bgwk.CancelAsync();
                }
                else
                {
                    //SplashScreenManager.ShowForm(typeof(F_wait_form));
                    this.m_prb.Visible = true;
                    m_bgwk.RunWorkerAsync();
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_bgwk_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                BackgroundWorker worker = sender as BackgroundWorker;
                tinhBangLuong(worker);
            }
            catch (Exception v_e)
            {

                MessageBox.Show("Có tý tẹo vấn đề. Bạn chụp ảnh và gửi để chúng tôi hỗ trợ nhé!" + v_e.ToString());
            }
        }

        private void m_bgwk_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.m_prb.Visible = false;
            load_data_2_grid();
        }

        private void load_data_2_grid()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithTableName(v_ds, "V_RPT_LUONG WHERE THANG = "+ m_txt_thang.Text.Trim() +" AND NAM = " + m_txt_nam.Text.Trim());
            m_grc.DataSource = v_ds.Tables[0];
        }

        private void f410_rpt_bang_luong_nv_Load(object sender, EventArgs e)
        {
            try
            {
                m_txt_nam.Text = DateTime.Now.Year.ToString();
                m_txt_thang.Text = DateTime.Now.Month.ToString();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);   
            }
        }

        private void m_bgwk_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.m_prb.Text = (e.ProgressPercentage.ToString() + "%");
            this.m_prb.EditValue = e.ProgressPercentage;
        }
    }
}