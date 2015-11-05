﻿using IP.Core.IPCommon;
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
using DevExpress;
using DevComponents;
using DevExpress.XtraEditors;

namespace BKI_DichVuMatDat.BaoCao
{
    public partial class f410_rpt_bang_luong_nv : Form
    {
        public f410_rpt_bang_luong_nv()
        {
            InitializeComponent();
            this.m_grv.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(WinFormControls.m_grv_PopupMenuShowing);
            this.m_grv.OptionsPrint.AutoWidth = false;
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
        decimal m_is_click_cmd_tinh_bang_luong = 0; //1. click
        #endregion

        #region Private Methods
        private void tinhBangLuong(BackgroundWorker ip_bgw)
        {
            try
            {
                US_RPT_LUONG v_us = new US_RPT_LUONG();
                DS_RPT_LUONG v_ds = new DS_RPT_LUONG();
                v_us.Get_tat_ca_nhan_vien_can_tinh_luong(v_ds, CIPConvert.ToDecimal(m_txt_thang.Text.Trim()), CIPConvert.ToDecimal(m_txt_nam.Text.Trim()));
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
                DataRow v_dr_luong = CCommon.get_luong_1_nhan_vien(v_id_nhan_vien, int.Parse(m_txt_thang.Text.Trim()), int.Parse(m_txt_nam.Text.Trim()));
                var v_dr_luong_nv = m_ds.Tables[0].NewRow();
                DataRow v_dr_luong_1_nv = CCommon.get_dr(v_dr_luong_nv, v_dr_luong, v_id_nhan_vien, i, int.Parse(m_txt_thang.Text.Trim()), int.Parse(m_txt_nam.Text.Trim()));
                m_ds.Tables[0].Rows.Add(v_dr_luong_1_nv);
                CCommon.insertLuongNV2RPT(v_dr_luong_1_nv);
                ip_bgw.ReportProgress((i + 1) * 100 / ip_dt.Rows.Count);
            }
        }

        //private void insertLuongNV2RPT(DataRow v_dr_luong_1_nv)
        //{
        //    US_RPT_LUONG v_us = new US_RPT_LUONG();
        //    DataRow2US(v_dr_luong_1_nv, v_us);
        //    v_us.Insert();
        //}

        //private void DataRow2US(DataRow v_dr_luong_1_nv, US_RPT_LUONG v_us)
        //{
        //    v_us.strMA_NV = v_dr_luong_1_nv[RPT_LUONG.MA_NV].ToString();
        //    v_us.dcAN_CA = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.AN_CA].ToString());
        //    v_us.dcBHTN = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.BHTN].ToString());
        //    v_us.dcBHXH = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.BHXH].ToString());
        //    v_us.dcBHYT = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.BHYT].ToString());
        //    v_us.dcDOAN_PHI_CD = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.DOAN_PHI_CD].ToString());
        //    v_us.dcID_NHAN_VIEN = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.ID_NHAN_VIEN].ToString());
        //    v_us.dcLAM_THEM = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.LAM_THEM].ToString());
        //    v_us.dcLAM_THEM_LE_TET = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.LAM_THEM_LE_TET].ToString());
        //    v_us.dcLUONG_CD = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.LUONG_CD].ToString());
        //    v_us.dcLUONG_KHAC_THUE_10 = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.LUONG_KHAC_THUE_10].ToString());
        //    v_us.dcLUONG_KHAC_THUE_5 = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.LUONG_KHAC_THUE_5].ToString());
        //    v_us.dcLUONG_KHAC_THUE_TINH_THEO_LUONG = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.LUONG_KHAC_THUE_TINH_THEO_LUONG].ToString());
        //    v_us.dcLUONG_NS = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.LUONG_NS].ToString());
        //    v_us.dcNAM = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.NAM].ToString());
        //    v_us.dcPHAI_NOP = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.PHAI_NOP].ToString());
        //    v_us.dcPHU_CAP_TN = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.PHU_CAP_TN].ToString());
        //    v_us.dcTHANG = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.THANG].ToString());
        //    v_us.dcTHU_NHAP = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.THU_NHAP].ToString());
        //    v_us.dcTHUC_LINH = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.THUC_LINH].ToString());
        //    v_us.dcTHUC_LINH_CUOI_CUNG = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.THUC_LINH_CUOI_CUNG].ToString());
        //    v_us.dcTHUE = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.THUE].ToString());
        //    v_us.dcTHUE_TU_LUONG_KHAC_10 = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.THUE_TU_LUONG_KHAC_10].ToString());
        //    v_us.dcTHUE_TU_LUONG_KHAC_5 = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.THUE_TU_LUONG_KHAC_5].ToString());
        //    v_us.dcTRUY_LINH = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.TRUY_LINH].ToString());
        //    v_us.dcTRUY_THU = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.TRUY_THU].ToString());
        //}

        //private DataRow get_dr(DataRow ip_dr_luong_nv, DataRow ip_dr_luong, decimal ip_id_nv, int ip_index, int ip_thang, int ip_nam)
        //{
        //    ip_dr_luong_nv[RPT_LUONG.ID] = ip_index;
        //    ip_dr_luong_nv[RPT_LUONG.ID_NHAN_VIEN] = ip_id_nv;
        //    ip_dr_luong_nv[RPT_LUONG.THANG] = ip_thang;
        //    ip_dr_luong_nv[RPT_LUONG.NAM] = ip_nam;
        //    ip_dr_luong_nv[RPT_LUONG.MA_NV] = ip_dr_luong[RPT_LUONG.MA_NV];
        //    ip_dr_luong_nv[RPT_LUONG.LUONG_NS] = ip_dr_luong[RPT_LUONG.LUONG_NS];
        //    ip_dr_luong_nv[RPT_LUONG.LUONG_CD] = ip_dr_luong[RPT_LUONG.LUONG_CD];
        //    ip_dr_luong_nv[RPT_LUONG.PHU_CAP_TN] = ip_dr_luong[RPT_LUONG.PHU_CAP_TN];
        //    ip_dr_luong_nv[RPT_LUONG.AN_CA] = ip_dr_luong[RPT_LUONG.AN_CA];
        //    ip_dr_luong_nv[RPT_LUONG.LAM_THEM] = ip_dr_luong[RPT_LUONG.LAM_THEM];
        //    ip_dr_luong_nv[RPT_LUONG.LAM_THEM_LE_TET] = ip_dr_luong[RPT_LUONG.LAM_THEM_LE_TET];
        //    ip_dr_luong_nv[RPT_LUONG.LUONG_KHAC_THUE_5] = ip_dr_luong[RPT_LUONG.LUONG_KHAC_THUE_5];
        //    ip_dr_luong_nv[RPT_LUONG.LUONG_KHAC_THUE_10] = ip_dr_luong[RPT_LUONG.LUONG_KHAC_THUE_10];
        //    ip_dr_luong_nv[RPT_LUONG.LUONG_KHAC_THUE_TINH_THEO_LUONG] = ip_dr_luong[RPT_LUONG.LUONG_KHAC_THUE_TINH_THEO_LUONG];
        //    ip_dr_luong_nv[RPT_LUONG.THU_NHAP] = ip_dr_luong[RPT_LUONG.THU_NHAP];
        //    ip_dr_luong_nv[RPT_LUONG.BHXH] = ip_dr_luong[RPT_LUONG.BHXH];
        //    ip_dr_luong_nv[RPT_LUONG.BHYT] = ip_dr_luong[RPT_LUONG.BHYT];
        //    ip_dr_luong_nv[RPT_LUONG.BHTN] = ip_dr_luong[RPT_LUONG.BHTN];
        //    ip_dr_luong_nv[RPT_LUONG.DOAN_PHI_CD] = ip_dr_luong[RPT_LUONG.DOAN_PHI_CD];
        //    ip_dr_luong_nv[RPT_LUONG.THUE] = ip_dr_luong[RPT_LUONG.THUE];
        //    ip_dr_luong_nv[RPT_LUONG.THUE_TU_LUONG_KHAC_5] = ip_dr_luong[RPT_LUONG.THUE_TU_LUONG_KHAC_5];
        //    ip_dr_luong_nv[RPT_LUONG.THUE_TU_LUONG_KHAC_10] = ip_dr_luong[RPT_LUONG.THUE_TU_LUONG_KHAC_10];
        //    ip_dr_luong_nv[RPT_LUONG.PHAI_NOP] = ip_dr_luong[RPT_LUONG.PHAI_NOP];
        //    ip_dr_luong_nv[RPT_LUONG.THUC_LINH] = ip_dr_luong[RPT_LUONG.THUC_LINH];
        //    ip_dr_luong_nv[RPT_LUONG.TRUY_LINH] = ip_dr_luong[RPT_LUONG.TRUY_LINH];
        //    ip_dr_luong_nv[RPT_LUONG.TRUY_THU] = ip_dr_luong[RPT_LUONG.TRUY_THU];
        //    ip_dr_luong_nv[RPT_LUONG.THUC_LINH_CUOI_CUNG] = ip_dr_luong[RPT_LUONG.THUC_LINH_CUOI_CUNG];
        //    return ip_dr_luong_nv;
        //}

        //private DataRow get_luong_1_nhan_vien(decimal ip_dc_id_nhan_vien, int ip_int_thang, int ip_int_nam)
        //{
        //    US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
        //    DataSet v_ds = new DataSet();
        //    v_ds.Tables.Add(new DataTable());
        //    v_us.FillBangLuong(v_ds, ip_dc_id_nhan_vien, ip_int_thang, ip_int_nam);
        //    DataRow v_dr = v_ds.Tables[0].Rows[0];
        //    return v_dr;
        //}

        private bool check_gd_chot_bang_luong_is_exist()
        {
            try
            {
                DS_GD_CHOT_BANG_LUONG v_ds = new DS_GD_CHOT_BANG_LUONG();
                US_GD_CHOT_BANG_LUONG v_us = new US_GD_CHOT_BANG_LUONG();
                v_us.FillDataset(v_ds);

                string v_str_filter = "THANG = " + CIPConvert.ToDecimal(m_txt_thang.Text.Trim()) + " AND NAM = " + CIPConvert.ToDecimal(m_txt_nam.Text.Trim());
                DataRow[] v_dr = v_ds.GD_CHOT_BANG_LUONG.Select(v_str_filter);

                if (v_dr.Count() == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception v_e)
            {
                throw v_e;
            }
        }

        private void insert_gd_bang_luong()
        {
            US_GD_CHOT_BANG_LUONG v_us = new US_GD_CHOT_BANG_LUONG();

            v_us.dcTHANG = CIPConvert.ToDecimal(m_txt_thang.Text.Trim());
            v_us.dcNAM = CIPConvert.ToDecimal(m_txt_nam.Text.Trim());
            //v_us.strNGUOI_CHOT = 
            v_us.datNGAY_CHOT = DateTime.Now.Date;

            try
            {
                v_us.BeginTransaction();
                v_us.Insert();
                v_us.CommitTransaction();
            }
            catch (Exception v_e)
            {
                throw v_e;
            }
        }

        private void insert_hs_hs_bs_hs_anhk(decimal ip_dc_thang, decimal ip_dc_nam)
        {
            US_GD_HS_BO_SUNG_AN_TOAN_HANG_KHONG v_us = new US_GD_HS_BO_SUNG_AN_TOAN_HANG_KHONG();

            try
            {
                v_us.insert_data_by_proc(ip_dc_thang, ip_dc_nam);
                DevExpress.XtraEditors.XtraMessageBox.Show("Thành công!!!", "THÔNG BÁO");
            }
            catch (Exception v_e)
            {
                throw v_e;
            }
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
                    m_ds.Clear();
                    m_bgwk.RunWorkerAsync();
                    m_is_click_cmd_tinh_bang_luong = 1;
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

                DevExpress.XtraEditors.XtraMessageBox.Show("Có tý tẹo vấn đề. Bạn chụp ảnh và gửi để chúng tôi hỗ trợ nhé!" + v_e.ToString());
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
            v_us.FillDatasetWithQuery(v_ds, "SELECT DISTINCT * FROM V_RPT_LUONG WHERE THANG = " + m_txt_thang.Text.Trim() + " AND NAM = " + m_txt_nam.Text.Trim());
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

        private void m_cmd_chot_bang_luong_Click(object sender, EventArgs e)
        {
            if (m_is_click_cmd_tinh_bang_luong == 0)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Chưa có dữ liệu để chốt!!!", "THÔNG BÁO");
                return;
            }

            if (DevExpress.XtraEditors.XtraMessageBox.Show("Bạn có chắc chắn muốn chốt bảng lương tháng " + m_txt_thang.Text.Trim() + " năm " + m_txt_nam.Text.Trim(), "XÁC NHẬN LẠI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (!check_gd_chot_bang_luong_is_exist())
                {
                    //insert vao gd_chot_bang_luong
                    insert_gd_bang_luong();
                    //them dl vao bang hs bo sung, hs an toan hk
                    insert_hs_hs_bs_hs_anhk(CIPConvert.ToDecimal(m_txt_thang.Text.Trim()), CIPConvert.ToDecimal(m_txt_nam.Text.Trim()));
                }
                else
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Bảng lương tháng " + m_txt_thang.Text.Trim() + " năm " + m_txt_nam.Text.Trim() + " đã được chốt", "THÔNG BÁO");
                    return;
                }
            }
        }

        private void m_cmd_luu_bang_luong_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "xls files (*.xls)|*.xls|All files (*.*)|*.*";
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                m_grv.ExportToXls(saveFileDialog1.FileName);
                DevExpress.XtraEditors.XtraMessageBox.Show("Lưu báo cáo thành công");
            }
        }
    }
}