using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using IP.Core.IPCommon;
using BKI_DichVuMatDat.DS;
using BKI_DichVuMatDat.US;
using BKI_DichVuMatDat.NghiepVu;
using IP.Core.IPSystemAdmin;
using BKI_DichVuMatDat.BaoCao;
using BKI_DichVuMatDat.DanhMuc;
using BKI_DichVuMatDat.HeThong;
using BKI_DichVuMatDat.DS.CDBNames;
using System.Deployment;
using System.Deployment.Application;
using BKI_DichVuMatDat.NghiepVu.ThuNhapKhac;
//using BKI_DichVuMatDat.BaoCao.Luong;
using BKI_DichVuMatDat.BaoCao.ThuNhapKhac;
using BKI_DichVuMatDat.NghiepVu.Luong;
using BKI_DichVuMatDat.NghiepVu.NhanSu;
using BKI_DichVuMatDat.NghiepVu.HopDong;
using BKI_DichVuMatDat.BaoCao.Luong;
using BKI_DichVuMatDat.BaoCao.TongHop;
using DevExpress.XtraSplashScreen;
//using BKI_DichVuMatDat.BaoCao.Luong;

namespace BKI_DichVuMatDat
{
    public partial class f388_main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region Members
        bool m_trang_thai_filter = false;
        #endregion

        public f388_main()
        {
            InitializeComponent();
            format_control();
            MdiManager.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
            ribbon.SelectedPage = ribbonPage3;
        }

        public void update_canh_bao()
        {
            try
            {
                canh_bao_het_han_hop_dong();
                canh_bao_het_han_cong_tac();
                canh_bao_het_han_luong_nang_suat();
                canh_bao_ket_thuc_trang_thai_lao_dong();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void canh_bao_het_han_hop_dong()
        {
            DataTable v_dt = get_hop_dong_het_han();
            DataRow[] v_dr_hd_sap_het_han = v_dt.Select(string.Format(v_dt.Locale, "ngay_ket_thuc > '{0:o}'", DateTime.Now));
            int v_so_hd_sap_het_han = v_dr_hd_sap_het_han.Length;
            DataRow[] v_dr_hd_da_het_han = v_dt.Select(string.Format(v_dt.Locale, "ngay_ket_thuc <= '{0:o}'", DateTime.Now));
            int v_so_hd_da_het_han = v_dr_hd_da_het_han.Length;
            if(v_so_hd_sap_het_han > 0)
            {
                m_lbl_so_nv_sap_het_han_hd.Text = v_so_hd_sap_het_han.ToString();
                m_pn_sap_het_han_hd.Visible = true;
            }
            if(v_so_hd_da_het_han > 0)
            {
                m_lbl_so_nv_da_het_han_hd.Text = v_so_hd_da_het_han.ToString();
                m_pn_da_het_han_hd.Visible = true;
            }
        }

        private void canh_bao_het_han_cong_tac()
        {
            DataTable v_dt = get_cong_tac_het_han();
            DataRow[] v_dr_ct_sap_het_han = v_dt.Select(string.Format(v_dt.Locale, "ngay_ket_thuc > '{0:o}'", DateTime.Now));
            int v_so_ct_sap_ket_thuc = v_dr_ct_sap_het_han.Length;
            DataRow[] v_dr_ct_da_het_han = v_dt.Select(string.Format(v_dt.Locale, "ngay_ket_thuc <= '{0:o}'", DateTime.Now));
            int v_so_ct_da_ket_thuc = v_dr_ct_da_het_han.Length;
            if(v_so_ct_sap_ket_thuc > 0)
            {
                m_lbl_so_nv_sap_ket_thuc_ct.Text = v_so_ct_sap_ket_thuc.ToString();
                m_pn_sap_ket_thuc_ct.Visible = true;
            }
            if(v_so_ct_da_ket_thuc > 0)
            {
                m_lbl_so_nv_da_ket_thuc_ct.Text = v_so_ct_da_ket_thuc.ToString();
                m_pn_da_ket_thuc_ct.Visible = true;
            }
        }

        private void canh_bao_het_han_luong_nang_suat()
        {
            DataTable v_dt = get_lns_het_han();
            DataRow[] v_dr_lns_sap_het_han = v_dt.Select(string.Format(v_dt.Locale, "ngay_ket_thuc > '{0:o}'", DateTime.Now));
            int v_so_lns_sap_het_han = v_dr_lns_sap_het_han.Length;
            DataRow[] v_dr_lns_da_het_han = v_dt.Select(string.Format(v_dt.Locale, "ngay_ket_thuc <= '{0:o}'", DateTime.Now));
            int v_so_lns_da_het_han = v_dr_lns_da_het_han.Length;
            if(v_so_lns_sap_het_han > 0)
            {
                m_lbl_so_nv_sap_het_han_lns.Text = v_so_lns_sap_het_han.ToString();
                m_pn_sap_het_han_lns.Visible = true;
            }
            if(v_so_lns_da_het_han > 0)
            {
                m_lbl_so_nv_da_het_han_lns.Text = v_so_lns_da_het_han.ToString();
                m_pn_da_het_han_lns.Visible = true;
            }
        }

        private void canh_bao_ket_thuc_trang_thai_lao_dong()
        {
            DataTable v_dt = get_trang_thai_lao_dong_ket_thuc();
            DataRow[] v_dr_ttld_sap_ket_thuc = v_dt.Select(string.Format(v_dt.Locale, "ngay_ket_thuc > '{0:o}'", DateTime.Now));
            int v_so_nv_sap_ket_thuc_ttld = v_dr_ttld_sap_ket_thuc.Length;
            DataRow[] v_dr_ttld_da_ket_thuc = v_dt.Select(string.Format(v_dt.Locale, "ngay_ket_thuc <= '{0:o}'", DateTime.Now));
            int v_so_nv_da_nghi_viec = v_dr_ttld_da_ket_thuc.Length;
            if(v_so_nv_sap_ket_thuc_ttld > 0)
            {
                m_lbl_so_nv_sap_ket_thuc_ttld.Text = v_so_nv_sap_ket_thuc_ttld.ToString();
                m_pn_sap_ket_thuc_ttld.Visible = true;
            }
            if(v_so_nv_da_nghi_viec > 0)
            {
                m_lbl_so_nv_da_nghi_viec.Text = v_so_nv_da_nghi_viec.ToString();
                m_pn_da_nghi_viec.Visible = true;
            }
        }

        public void display(ref IP.Core.IPCommon.IPConstants.HowUserWantTo_Exit_MainForm v_exitmode)
        {
            try
            {
                update_canh_bao();
                this.ShowDialog();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }

        }

        public void display_dvmd()
        {
            try
            {
                this.ShowDialog();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }

        }

        #region Private Methods
        private void format_control()
        {
            // US_V_HT_NGUOI_SU_DUNG v_us = new US_V_HT_NGUOI_SU_DUNG();
            //if (US_V_HT_NGUOI_SU_DUNG.isInAdminGroup(CAppContext_201.getCurrentUserID()))
            //{
            //    ribbonPageGroup4.Visible = false;
            //    ribbonPageGroup5.Visible = false;
            //    m_cmd_lap_phai_thu_le.Visibility = BarItemVisibility.Never;
            //    m_cmd_lap_phai_thu_tu_dong.Visibility = BarItemVisibility.Never;
            //    m_cmd_lap_thuc_thu.Visibility = BarItemVisibility.Never;
            //    m_cmd_lap_giam_tru.Visibility = BarItemVisibility.Never;
            //    //m_cmd_phan_quyen_nhom.Visibility = BarItemVisibility.Never;
            //    //m_cmd_nhom_nguoi_su_dung.Visibility = BarItemVisibility.Never;
            //    //m_cmd_nguoi_sd.Visibility = BarItemVisibility.Never;
            //    ribbonPage2.Visible = false;
            //    m_cmd_ds_phieu.Visibility = BarItemVisibility.Always ;
            //}
            //else
            //{
            //    m_cmd_ban_giao_tien.Visibility = BarItemVisibility.Never;
            //m_cmd_phan_quyen_nhom.Visibility = BarItemVisibility.Never;
            //m_cmd_nhom_nguoi_su_dung.Visibility = BarItemVisibility.Never;
            //m_cmd_nguoi_sd.Visibility = BarItemVisibility.Never;
            //    ribbonPageGroup2.Visible = false;
            //}
            FormatControl.SetVisibleBarButtonItem(ribbon, this.Name);
            set_define_events();
        }

        private void set_initial_form_load()
        {
            //format_control();
            setBarStatus();
        }

        private bool IsExistFormName(Form ip_frm)
        {
            foreach(var child in MdiChildren)
            {
                if(child.Name == ip_frm.Name)
                {
                    child.Activate();
                    return true;
                }
            }
            return false;
        }

        private bool IsExistFormText(Form ip_frm)
        {
            foreach(var child in MdiChildren)
            {
                if(child.Text == ip_frm.Text)
                {
                    child.Activate();
                    return true;
                }
            }
            return false;
        }

        private void setBarStatus()
        {
            var server = System.Configuration.ConfigurationManager.AppSettings["SERVER"];
            var username = CAppContext_201.getCurrentUserName();
            var dbname = System.Configuration.ConfigurationManager.AppSettings["INITIAL_DATABASE"];

            Version myVersion;
            string myVersionText = "";
            if(ApplicationDeployment.IsNetworkDeployed)
            {
                myVersion = ApplicationDeployment.CurrentDeployment.CurrentVersion;
                myVersionText = string.Concat("v", myVersion);
            }
            if(CAppContext_201.getCurrentUserID() == 1)
            {
                barStaticItemServer.Caption = "Server: " + server + " | Username: " + username + " | DB: " + dbname + " | Version: " + myVersionText;
            }
            else
            {
                barStaticItemServer.Caption = "Username: " + username + " | Version: " + myVersionText;
            }
        }

        //lay thong tin canh bao

        private DataTable get_hop_dong_het_han()
        {
            US_GD_HOP_DONG v_us_gd_hop_dong = new US_GD_HOP_DONG();
            DataSet v_ds = v_us_gd_hop_dong.LayDanhSachHDHetHanTrongThang();
            return v_ds.Tables[0];
        }

        private DataTable get_cong_tac_het_han()
        {
            US_GD_CONG_TAC v_us_gd_cong_tac = new US_GD_CONG_TAC();
            DataSet v_ds = v_us_gd_cong_tac.LayDanhSachCTHetHanTrongThang();
            return v_ds.Tables[0];
        }

        private DataTable get_lns_het_han()
        {
            US_GD_HE_SO_LNS v_us_gd_he_so_lns = new US_GD_HE_SO_LNS();
            DataSet v_ds = v_us_gd_he_so_lns.LayDanhSachHetHanLNSTrongThang();
            return v_ds.Tables[0];
        }

        private DataTable get_trang_thai_lao_dong_ket_thuc()
        {
            US_GD_TRANG_THAI_LAO_DONG v_us = new US_GD_TRANG_THAI_LAO_DONG();
            DataSet v_ds = v_us.LayDanhSachKetThucTTLDTrongThang();
            return v_ds.Tables[0];
        }

        private DataSet get_nv_nghi_tam_thoi()
        {
            US_V_F356_BAO_CAO_TRANG_THAI_LAO_DONG_CUA_NHAN_VIEN v_us = new US_V_F356_BAO_CAO_TRANG_THAI_LAO_DONG_CUA_NHAN_VIEN();
            DataSet v_ds = v_us.LayDanhSachNhanVienTheoLoaiTrangThai(743);
            return v_ds;
        }

        private DataSet get_nv_het_han_hs_lns()
        {
            try
            {
                DateTime v_ngay_hien_tai = DateTime.Now.Date;
                //DateTime v_ngay_hien_tai = Convert.ToDateTime("2045 - 06 - 01 00:00:00.000");
                US_V_F419_BAO_CAO_HS_LNS_NHAN_VIEN_THEO_THANG v_us_f419_hs_lns = new US_V_F419_BAO_CAO_HS_LNS_NHAN_VIEN_THEO_THANG();
                DataSet v_ds = v_us_f419_hs_lns.LayDanhSachNhanVienHetHanHeSoLuongNangSuat(v_ngay_hien_tai);

                return v_ds;
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
                return null;
            }

        }

        private DataSet get_nv_het_han_lcd()
        {
            try
            {
                DateTime v_ngay_hien_tai = DateTime.Now.Date;
                //DateTime v_ngay_hien_tai = Convert.ToDateTime("2045 - 06 - 01 00:00:00.000");
                US_V_F419_BAO_CAO_LCD_NHAN_VIEN_THEO_THANG v_us_f419_lcd = new US_V_F419_BAO_CAO_LCD_NHAN_VIEN_THEO_THANG();
                DataSet v_ds = v_us_f419_lcd.LayDanhSachNhanVienHetHanLuongCheDo(v_ngay_hien_tai);
                return v_ds;
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
                return null;
            }

        }

        private DataSet get_nv_het_nghi_tam_thoi()
        {
            try
            {
                DateTime v_ngay_hien_tai = DateTime.Now.Date;
                //DateTime v_ngay_hien_tai = Convert.ToDateTime("2016 - 05 - 01 00:00:00.000");
                US_V_F356_BAO_CAO_TRANG_THAI_LAO_DONG_CUA_NHAN_VIEN v_us = new US_V_F356_BAO_CAO_TRANG_THAI_LAO_DONG_CUA_NHAN_VIEN();
                DataSet v_ds = v_us.LayDanhSachNhanVienDiLamTroLai(v_ngay_hien_tai);
                return v_ds;
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
                return null;
            }
        }

        //

        #endregion

        ///
        ///Events
        ///
        ///
        private void set_define_events()
        {
            this.Load += f388_main_Load;
            m_lbl_nv_da_het_han_hd.DoubleClick += m_lbl_nv_da_het_han_hd_DoubleClick;
            m_lbl_nv_sap_het_han_hd.DoubleClick += m_lbl_nv_sap_het_han_hd_DoubleClick;
            m_lbl_nv_da_ket_thuc_ct.DoubleClick += m_lbl_nv_da_ket_thuc_ct_DoubleClick;
            m_lbl_nv_sap_ket_thuc_ct.DoubleClick += m_lbl_nv_sap_ket_thuc_ct_DoubleClick;
            m_lbl_nv_da_het_han_lns.DoubleClick += m_lbl_nv_da_het_han_lns_DoubleClick;
            m_lbl_nv_sap_het_han_lns.DoubleClick += m_lbl_nv_sap_het_han_lns_DoubleClick;
            m_lbl_nv_da_nghi_viec.DoubleClick += m_lbl_nv_da_nghi_viec_DoubleClick;
            m_lbl_nv_can_chuyen_trang_thai.DoubleClick += m_lbl_nv_can_chuyen_trang_thai_DoubleClick;

            //Nghiệp vụ
            m_cmd_cham_cong_nv.ItemClick += m_cmd_cham_cong_nv_ItemClick;
            m_cmd_lap_hop_dong.ItemClick += m_cmd_lap_hop_dong_ItemClick;
            m_cmd_quan_ly_lns.ItemClick += m_cmd_len_luong_cho_nv_ItemClick;
            m_cmd_phep_tieu_chuan.ItemClick += m_cmd_dat_hs_lns_lcd_ItemClick;
            m_cmd_quan_ly_qd.ItemClick += m_cmd_quan_ly_qd_ItemClick;
            m_cmd_hs_chat_luong_xls.ItemClick += m_cmd_them_hs_chat_luong_ItemClick;
            m_cmd_hs_chat_luong_by_nv.ItemClick += m_cmd_hs_chat_luong_by_nv_ItemClick;
            m_cmd_quan_ly_thu_nhap_khac.ItemClick += m_cmd_quan_ly_thu_nhap_khac_ItemClick;
            m_cmd_quan_ly_thu_nhap_khac_xls.ItemClick += m_cmd_quan_ly_thu_nhap_khac_xls_ItemClick;
            m_cmd_quan_ly_luong_cung.ItemClick += m_cmd_quan_ly_luong_cung_ItemClick;
            m_cmd_quan_ly_khong_dong_bh.ItemClick += m_cmd_quan_ly_khong_dong_bh_ItemClick;
            m_cmd_thuong_thu_nhap_khac.ItemClick += m_cmd_luong_hs_athk_ItemClick;
            m_cmd_ql_thuong_le_tet.ItemClick += m_cmd_ql_thuong_hsbs_ItemClick;
            m_cmd_thuong_2014.ItemClick += m_cmd_thuong_2014_ItemClick;
            m_cmd_lap_hd_v2.ItemClick += m_cmd_lap_hd_v2_ItemClick;
            m_cmd_hd_thay_doi_lns.ItemClick += m_cmd_hd_thay_doi_lns_ItemClick;
            //Hệ thống
            m_cmd_thoat.ItemClick += m_cmd_thoat_ItemClick;
            m_cmd_phan_quyen_nhom.ItemClick += m_cmd_phan_quyen_nhom_ItemClick;
            m_cmd_nhom_nguoi_su_dung.ItemClick += m_cmd_nhom_nguoi_su_dung_ItemClick;
            m_cmd_doi_mat_khau.ItemClick += m_cmd_doi_mat_khau_ItemClick;
            m_cmd_nguoi_sd.ItemClick += m_cmd_nguoi_sd_ItemClick;
            m_cmd_backup_restore.ItemClick += m_cmd_backup_restore_ItemClick;
            //Danh muc 
            m_cmd_dm_loai_ngay_cong.ItemClick += m_cmd_dm_loai_ngay_cong_ItemClick;
            m_cmd_danh_muc_don_vi.ItemClick += m_cmd_danh_muc_don_vi_ItemClick;
            m_cmd_dm_tham_so.ItemClick += m_cmd_dm_tham_so_ItemClick;
            m_cmd_them_nhan_vien_nhanh.ItemClick += m_cmd_them_nhan_vien_nhanh_ItemClick;
            m_cmd_cm_dm_thu_tu_don_vi.ItemClick += m_cmd_cm_dm_thu_tu_don_vi_ItemClick;
            m_cmd_tu_dien.ItemClick += m_cmd_tu_dien_ItemClick;
            m_cmd_chuc_vu.ItemClick += m_cmd_chuc_vu_ItemClick;
            //Bao cao
            m_cmd_bang_luong_nv.ItemClick += m_cmd_bang_luong_nv_ItemClick;
            m_cmd_bc_hs_bs_hs_athk.ItemClick += m_cmd_bc_hs_bs_hs_athk_ItemClick;
            m_cmd_bc_cac_thang_da_chot_bang_luong.ItemClick += m_cmd_bc_cac_thang_da_chot_bang_luong_ItemClick;
            m_cmd_luong_theo_don_vi.ItemClick += m_cmd_luong_theo_don_vi_ItemClick;
            m_cmd_trang_thai_lao_dong.ItemClick += m_cmd_chuyen_trang_thai_LD_ItemClick;
            m_cmd_bao_cao_tong_hop.ItemClick += m_cmd_bao_cao_tong_hop_ItemClick;
            m_cmd_bc_bien_dong_hd.ItemClick += m_cmd_bc_tang_giam_ld_ItemClick;
            m_cmd_bao_cao_hs_lns_lcd_nhan_vien.ItemClick += m_cmd_bao_cao_hs_lns_lcd_nhan_vien_ItemClick;
            m_cmd_bao_cao_nhan_su_bo_nhiem.ItemClick += m_cmd_bao_cao_nhan_su_bo_nhiem_ItemClick;
            m_cmd_thong_ke_nhan_vien.ItemClick += m_cmd_thong_ke_nhan_vien_ItemClick;
            m_cmd_bc_qua_trinh_ct.ItemClick += m_cmd_bc_qua_trinh_ct_ItemClick;
            m_cmd_bc_hop_dong_het_han.ItemClick += m_cmd_bc_hop_dong_het_han_ItemClick;
            m_cmd_card_nhan_vien.ItemClick += m_cmd_card_nhan_vien_ItemClick;
            m_cmd_cham_cong_lam_them.ItemClick += m_cmd_cham_cong_lam_them_ItemClick;
            m_cmd_quy_trinh_tinh_luong.ItemClick += m_cmd_quy_trinh_tinh_luong_ItemClick;
            m_cmd_he_so_bang_luong_thang.ItemClick += m_cmd_tham_so_bang_luong_ItemClick;
            m_cmd_quan_ly_luong.ItemClick += m_cmd_bao_cao_tong_hop_v2_ItemClick;
            m_cmd_danh_sach_hop_dong.ItemClick += m_cmd_danh_sach_hop_dong_ItemClick;
            m_cmd_bao_cao_dieu_kien_tinh_luong.ItemClick += m_cmd_bao_cao_dieu_kien_tinh_luong_ItemClick;
            m_cmd_bc_athk_bsl_lt.ItemClick += m_cmd_bc_athk_bsl_lt_ItemClick;
            m_cmd_bc_hop_dong_het_han.ItemClick += m_cmd_bc_hop_dong_het_han_ItemClick;
            //Thu nhap khac
            m_cmd_quan_ly_quy_tnk.ItemClick += m_cmd_quan_ly_quy_tnk_ItemClick;
            m_cmd_ds_chot_bang_luong.ItemClick += m_cmd_ds_chot_bang_luong_ItemClick;
            m_cmd_bc_hs.ItemClick += m_cmd_bc_hs_ItemClick;
            m_cmd_qtt_2016.ItemClick += m_cmd_qtt_2016_ItemClick;
            m_cmd_bc_bien_dong_lns.ItemClick += m_cmd_tk_hop_dong_ItemClick;
        }

        void m_cmd_tk_hop_dong_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                frm418_bao_cao_bien_dong_hs_lns v_f = new frm418_bao_cao_bien_dong_hs_lns();
                if(IsExistFormName(v_f)) return;
                v_f.MdiParent = this;
                v_f.Show();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_chuc_vu_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                F110_dm_chuc_vu v_f = new F110_dm_chuc_vu();
                if(IsExistFormName(v_f)) return;
                v_f.MdiParent = this;
                v_f.Show();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_tu_dien_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f100_TuDien v_f = new f100_TuDien();
                if(IsExistFormName(v_f)) return;
                v_f.MdiParent = this;
                v_f.Show();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_lbl_nv_da_nghi_viec_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                m_trang_thai_filter = true;
                DateTime v_dt_ngay_dau_thang = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                f356_bao_cao_trang_thai_lao_dong_cua_nhan_vien v_f = new f356_bao_cao_trang_thai_lao_dong_cua_nhan_vien(v_dt_ngay_dau_thang, m_trang_thai_filter);
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_lbl_nv_can_chuyen_trang_thai_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                m_trang_thai_filter = false;
                DateTime v_dt_ngay_dau_thang = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                DateTime v_dt_ngay_cuoi_thang = v_dt_ngay_dau_thang.AddMonths(1).AddDays(-1);
                f356_bao_cao_trang_thai_lao_dong_cua_nhan_vien v_f = new f356_bao_cao_trang_thai_lao_dong_cua_nhan_vien(v_dt_ngay_cuoi_thang, m_trang_thai_filter);
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_lbl_nv_sap_het_han_lns_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                m_trang_thai_filter = false;
                DateTime v_dt_ngay_dau_thang = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                DateTime v_dt_ngay_cuoi_thang = v_dt_ngay_dau_thang.AddMonths(1).AddDays(-1);
                f300_chinh_lns_nhan_vien v_f = new f300_chinh_lns_nhan_vien(v_dt_ngay_cuoi_thang, m_trang_thai_filter);
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_lbl_nv_da_het_han_lns_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                m_trang_thai_filter = true;
                DateTime v_dt_ngay_dau_thang = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                f300_chinh_lns_nhan_vien v_f = new f300_chinh_lns_nhan_vien(v_dt_ngay_dau_thang, m_trang_thai_filter);
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_lbl_nv_sap_ket_thuc_ct_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                m_trang_thai_filter = false;
                DateTime v_dt_ngay_dau_thang = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                DateTime v_dt_ngay_cuoi_thang = v_dt_ngay_dau_thang.AddMonths(1).AddDays(-1);
                f309_quan_ly_cong_tac v_f = new f309_quan_ly_cong_tac(v_dt_ngay_cuoi_thang, m_trang_thai_filter);
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_lbl_nv_da_ket_thuc_ct_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                m_trang_thai_filter = true;
                DateTime v_dt_ngay_dau_thang = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                f309_quan_ly_cong_tac v_f = new f309_quan_ly_cong_tac(v_dt_ngay_dau_thang, m_trang_thai_filter);
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_lbl_nv_sap_het_han_hd_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                m_trang_thai_filter = false;
                DateTime v_dt_ngay_dau_thang = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                DateTime v_dt_ngay_cuoi_thang = v_dt_ngay_dau_thang.AddMonths(1).AddDays(-1);
                f329_lap_hop_dong_v5 v_f = new f329_lap_hop_dong_v5(v_dt_ngay_cuoi_thang, m_trang_thai_filter);
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_lbl_nv_da_het_han_hd_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                m_trang_thai_filter = true;
                DateTime v_dt_ngay_dau_thang = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                f329_lap_hop_dong_v5 v_f = new f329_lap_hop_dong_v5(v_dt_ngay_dau_thang, m_trang_thai_filter);
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }


        private void M_lbl_ket_thuc_nghi_tam_thoi_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                f356_bao_cao_trang_thai_lao_dong_cua_nhan_vien v_f = new f356_bao_cao_trang_thai_lao_dong_cua_nhan_vien();
                //DateTime v_ngay_hien_tai = Convert.ToDateTime("2045 - 06 - 01 00:00:00.000");

            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_lbl_canh_bao_het_han_hop_dong_DoubleClick(object sender, EventArgs e)
        {
            //DateTime v_ngay_hien_tai = Convert.ToDateTime("2045 - 06 - 01 00:00:00.000");
            //DateTime v_ngay_dau_tien_cua_thang_hien_tai = CHRMCommon.get_first_day_of_month(v_ngay_hien_tai);
            //DateTime v_ngay_cuoi_cung_cua_thang_hien_tai = CHRMCommon.get_last_day_of_month(v_ngay_hien_tai);
            DateTime v_ngay_hien_tai = DateTime.Now.Date;
            DateTime v_ngay_dau_tien_cua_thang_hien_tai = CHRMCommon.get_first_day_of_month(DateTime.Now.Date);
            DateTime v_ngay_cuoi_cung_cua_thang_hien_tai = CHRMCommon.get_last_day_of_month(DateTime.Now.Date);
            //DateTime v_2_thang_truoc = DateTime.Now.AddMonths(-2);
            //F110_dm_hop_dong_het_han v_f = new F110_dm_hop_dong_het_han();
            //v_f.display_canh_bao_het_han_hop_dong(
            //            v_ngay_dau_tien_cua_thang_hien_tai.Date
            //            , v_ngay_cuoi_cung_cua_thang_hien_tai.Date, this);
        }

        //private void m_lbl_canh_bao_het_han_luong_che_do_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        f419_bao_cao_hs_lns_lcd_v2 v_f = new f419_bao_cao_hs_lns_lcd_v2();
        //        DateTime v_ngay_hien_tai = DateTime.Now.Date;
        //        //DateTime v_ngay_hien_tai = Convert.ToDateTime("2045 - 06 - 01 00:00:00.000");
        //        v_f.display_nv_het_han_lcd(v_ngay_hien_tai, this);
        //    }
        //    catch(Exception v_e)
        //    {
        //        CSystemLog_301.ExceptionHandle(v_e);
        //    }

        //}

        //private void m_lbl_canh_bao_het_han_hs_lns_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        f419_bao_cao_hs_lns_lcd_v2 v_f = new f419_bao_cao_hs_lns_lcd_v2();
        //        DateTime v_ngay_hien_tai = DateTime.Now.Date;
        //        //DateTime v_ngay_hien_tai = Convert.ToDateTime("2045 - 06 - 01 00:00:00.000");
        //        v_f.display_nv_het_han_hs_lns(v_ngay_hien_tai, this);
        //    }
        //    catch(Exception v_e)
        //    {
        //        CSystemLog_301.ExceptionHandle(v_e);
        //    }
        //}

        private void M_lbl_nv_nghi_tam_thoi_DoubleClick(object sender, EventArgs e)
        {
            f356_bao_cao_trang_thai_lao_dong_cua_nhan_vien v_f = new f356_bao_cao_trang_thai_lao_dong_cua_nhan_vien();
            //DateTime v_ngay_hien_tai = Convert.ToDateTime("2045 - 06 - 01 00:00:00.000");

        }

        void m_cmd_hd_thay_doi_lns_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                //F390_quan_ly_thay_doi_lns_hop_dong v_f = new F390_quan_ly_thay_doi_lns_hop_dong();
                //if (IsExistFormName(v_f)) return;
                //v_f.MdiParent = this;
                //v_f.Show();     
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_lap_hd_v2_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f329_lap_hop_dong_v5 v_f = new f329_lap_hop_dong_v5();
                if(IsExistFormName(v_f)) return;
                v_f.MdiParent = this;
                v_f.Show();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_qtt_2016_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f492_quyet_toan_thue_TNCN v_f = new f492_quyet_toan_thue_TNCN();
                if(IsExistFormName(v_f)) return;
                v_f.MdiParent = this;
                v_f.Show();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_bc_hs_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f492_bao_cao_cac_he_so v_f = new f492_bao_cao_cac_he_so();
                if(IsExistFormName(v_f)) return;
                v_f.MdiParent = this;
                v_f.Show();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_ds_chot_bang_luong_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f495_thong_tin_chot_bang_luong_thang v_f = new f495_thong_tin_chot_bang_luong_thang();
                if(IsExistFormName(v_f)) return;
                v_f.MdiParent = this;
                v_f.Show();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_cham_cong_lam_them_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f303_gd_cham_cong_lam_them v_f = new f303_gd_cham_cong_lam_them();
                if(IsExistFormName(v_f)) return;
                v_f.MdiParent = this;
                v_f.Show();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_bc_athk_bsl_lt_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f403_bao_cao_hs_athk_bsl_le_tet v_frm = new f403_bao_cao_hs_athk_bsl_le_tet();
                if(IsExistFormName(v_frm)) return;
                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_quan_ly_quy_tnk_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f353_quan_ly_quy_tien v_frm = new f353_quan_ly_quy_tien();
                if(IsExistFormName(v_frm)) return;
                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_bao_cao_dieu_kien_tinh_luong_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                F401_he_so_bao_cao_luong v_frm = new F401_he_so_bao_cao_luong();
                if(IsExistFormName(v_frm)) return;
                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_danh_sach_hop_dong_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f325_lap_hop_dong_V2 v_frm = new f325_lap_hop_dong_V2();
                if(IsExistFormName(v_frm)) return;
                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_bao_cao_tong_hop_v2_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f412_rpt_tong_hop_tt_v2 v_frm = new f412_rpt_tong_hop_tt_v2();
                if(IsExistFormName(v_frm)) return;
                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_tham_so_bang_luong_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f405_bao_cao_thong_tin_tinh_luong v_frm = new f405_bao_cao_thong_tin_tinh_luong();
                if(IsExistFormName(v_frm)) return;
                v_frm.MdiParent = this;
                v_frm.Show();
                //f301_quy_trinh_tinh_luong_v2 v_frm = new f301_quy_trinh_tinh_luong_v2();
                //if(IsExistFormName(v_frm)) return;
                //v_frm.MdiParent = this;
                //v_frm.Show();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_quy_trinh_tinh_luong_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                //f301_quy_trinh_tinh_luong v_frm = new f301_quy_trinh_tinh_luong();
                //if(IsExistFormName(v_frm)) return;

                //v_frm.MdiParent = this;
                //v_frm.Show();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }


        void m_cmd_them_nhan_vien_nhanh_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                //f160_them_nhan_vien_nhanh v_frm = new f160_them_nhan_vien_nhanh();
                //if(IsExistFormName(v_frm)) return;

                //v_frm.MdiParent = this;
                //v_frm.Show();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_thuong_2014_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                //f316_tinh_thuong_2014 v_frm = new f316_tinh_thuong_2014();
                //if(IsExistFormName(v_frm)) return;

                //v_frm.MdiParent = this;
                //v_frm.Show();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_card_nhan_vien_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f315_card_nhan_vien v_frm = new f315_card_nhan_vien();
                if(IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_bc_hop_dong_het_han_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                DateTime v_ngay_dau_tien_cua_thang_hien_tai = CHRMCommon.get_first_day_of_month(DateTime.Now.Date);
                DateTime v_ngay_cuoi_cung_cua_thang_hien_tai = CHRMCommon.get_last_day_of_month(DateTime.Now.Date);
                //F110_dm_hop_dong_het_han v_frm = new F110_dm_hop_dong_het_han();
                //if (IsExistFormName(v_frm)) return;

                //v_frm.MdiParent = this;
                //v_frm.display(v_ngay_dau_tien_cua_thang_hien_tai.AddDays(-1), v_ngay_cuoi_cung_cua_thang_hien_tai.AddDays(1));
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_bc_qua_trinh_ct_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f471_bao_cao_qua_trinh_cong_tac v_frm = new f471_bao_cao_qua_trinh_cong_tac();
                if(IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_thong_ke_nhan_vien_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f470_bao_cao_thong_ke_lao_dong v_frm = new f470_bao_cao_thong_ke_lao_dong();
                if(IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_bao_cao_nhan_su_bo_nhiem_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f469_danh_sach_nhan_vien_bo_nhiem v_frm = new f469_danh_sach_nhan_vien_bo_nhiem();
                if(IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_bao_cao_hs_lns_lcd_nhan_vien_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                //f419_bao_cao_hs_lns_lcd_cua_nhan_vien v_frm = new f419_bao_cao_hs_lns_lcd_cua_nhan_vien();
                //f419_bao_cao_hs_lns_lcd_v2 v_frm = new f419_bao_cao_hs_lns_lcd_v2();
                //if(IsExistFormName(v_frm)) return;

                //v_frm.MdiParent = this;
                //v_frm.Show();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_bc_tang_giam_ld_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                frm417_bao_cao_tang_giam_lao_dong v_frm = new frm417_bao_cao_tang_giam_lao_dong();
                if(IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_bao_cao_tong_hop_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f413_rpt_tong_hop_thong_tin v_frm = new f413_rpt_tong_hop_thong_tin();
                if(IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch(Exception)
            {
                throw;
            }
        }

        void m_cmd_ql_thuong_hsbs_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                //f301_tinh_thu_nhap_khac_le_tet v_frm = new f301_tinh_thu_nhap_khac_le_tet();
                //if (IsExistFormName(v_frm)) return;

                //v_frm.MdiParent = this;
                //v_frm.Show();
            }
            catch(Exception)
            {
                throw;
            }
        }

        void m_cmd_chuyen_trang_thai_LD_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f356_bao_cao_trang_thai_lao_dong_cua_nhan_vien v_frm = new f356_bao_cao_trang_thai_lao_dong_cua_nhan_vien();
                if(IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch(Exception)
            {
                throw;
            }
        }

        void m_cmd_luong_hs_athk_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f301_tinh_thu_nhap_khac v_frm = new f301_tinh_thu_nhap_khac();
                if(IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch(Exception)
            {
                throw;
            }
        }

        void m_cmd_luong_theo_don_vi_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                //f440_rpt_luong v_frm = new f440_rpt_luong();
                //if(IsExistFormName(v_frm)) return;

                //v_frm.MdiParent = this;
                //v_frm.Show();
            }
            catch(Exception)
            {
                throw;
            }
        }

        void m_cmd_bc_cac_thang_da_chot_bang_luong_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                //F430_bao_cao_cac_thang_da_chot_bang_luong v_frm = new F430_bao_cao_cac_thang_da_chot_bang_luong();
                //if(IsExistFormName(v_frm)) return;

                //v_frm.MdiParent = this;
                //v_frm.Show();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_bc_hs_bs_hs_athk_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                //F415_bao_cao_hs_bs_hs_athk v_frm = new F415_bao_cao_hs_bs_hs_athk();
                //if(IsExistFormName(v_frm)) return;

                //v_frm.MdiParent = this;
                //v_frm.Show();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_backup_restore_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                frm_backup_restore v_frm = new frm_backup_restore();
                if(IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_nguoi_sd_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f999_ht_nguoi_su_dung v_frm = new f999_ht_nguoi_su_dung();
                if(IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_doi_mat_khau_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f308_DOI_MAT_KHAU_NGUOI_SD v_frm = new f308_DOI_MAT_KHAU_NGUOI_SD();
                v_frm.ShowDialog();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_nhom_nguoi_su_dung_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f306_HT_USER_GROUP v_frm = new f306_HT_USER_GROUP();
                if(IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_phan_quyen_nhom_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f995_ht_phan_quyen_cho_nhom v_frm = new f995_ht_phan_quyen_cho_nhom();
                v_frm.ShowDialog();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_thoat_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                Dispose();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void f388_main_Load(object sender, EventArgs e)
        {
            try
            {
                set_initial_form_load();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }


        void m_cmd_bang_luong_nv_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f410_rpt_bang_luong_nv v_frm = new f410_rpt_bang_luong_nv();
                if(IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_cham_cong_nv_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                //f310_cham_cong_theo_danh_sach_nhan_vien v_frm = new f310_cham_cong_theo_danh_sach_nhan_vien();
                //if(IsExistFormName(v_frm)) return;

                //v_frm.MdiParent = this;
                //v_frm.Show();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_lap_hop_dong_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f320_lap_hop_dong v_frm = new f320_lap_hop_dong();
                if(IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_len_luong_cho_nv_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f300_chinh_lns_nhan_vien v_frm = new f300_chinh_lns_nhan_vien();
                if(IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_dat_hs_lns_lcd_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f396_tinh_phep_tieu_chuan v_f = new f396_tinh_phep_tieu_chuan();
                if(IsExistFormName(v_f)) return;
                v_f.MdiParent = this;
                v_f.Show();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_quan_ly_qd_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f360_quan_ly_quyet_dinh v_frm = new f360_quan_ly_quyet_dinh();
                if(IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_them_hs_chat_luong_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                //f380_thay_doi_he_so_chat_luong_xls v_frm = new f380_thay_doi_he_so_chat_luong_xls();
                //if(IsExistFormName(v_frm)) return;

                //v_frm.MdiParent = this;
                //v_frm.Show();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_hs_chat_luong_by_nv_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f381_thay_doi_he_so_luong_nang_suat_by_nhan_vien v_frm = new f381_thay_doi_he_so_luong_nang_suat_by_nhan_vien();
                if(IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_quan_ly_thu_nhap_khac_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                //f390_gd_thu_nhap_khac v_frm = new f390_gd_thu_nhap_khac();
                //if(IsExistFormName(v_frm)) return;

                //v_frm.MdiParent = this;
                //v_frm.Show();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_quan_ly_thu_nhap_khac_xls_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                //f391_thu_nhap_khac_xls v_frm = new f391_thu_nhap_khac_xls();
                //if(IsExistFormName(v_frm)) return;

                //v_frm.MdiParent = this;
                //v_frm.Show();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_quan_ly_luong_cung_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                //f363_quan_ly_cac_nhan_vien_co_luong_cung v_frm = new f363_quan_ly_cac_nhan_vien_co_luong_cung();
                f365_quan_ly_nhan_vien_co_luong_cung_v2 v_frm = new f365_quan_ly_nhan_vien_co_luong_cung_v2();
                if(IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_quan_ly_khong_dong_bh_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                //f366_quan_ly_nhan_vien_khong_dong_bao_hiem v_frm = new f366_quan_ly_nhan_vien_khong_dong_bao_hiem();
                f367_quan_li_nv_ko_dong_bao_hiem_v2 v_frm = new f367_quan_li_nv_ko_dong_bao_hiem_v2();
                if(IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }


        private void m_cmd_dm_tham_so_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                DanhMuc.F108_dm_tham_so v_frm = new DanhMuc.F108_dm_tham_so();
                if(IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_dm_he_so_luong_ns_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                DanhMuc.F103_dm_he_so_luong_ns v_frm = new DanhMuc.F103_dm_he_so_luong_ns();
                if(IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_dm_luong_che_do_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                DanhMuc.F106_dm_luong_che_do v_frm = new DanhMuc.F106_dm_luong_che_do();
                if(IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_dm_phu_cap_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                DanhMuc.F107_dm_phu_cap v_frm = new DanhMuc.F107_dm_phu_cap();
                if(IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_dm_loai_hop_dong_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                DanhMuc.F104_dm_loai_hop_dong v_frm = new DanhMuc.F104_dm_loai_hop_dong();
                if(IsExistFormName(v_frm)) return;
                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_dm_loai_ngay_cong_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                F105_dm_loai_ngay_cong v_frm = new F105_dm_loai_ngay_cong();
                if(IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_dm_thue_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                DanhMuc.F109_dm_thue v_frm = new DanhMuc.F109_dm_thue();
                if(IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_quan_ly_vi_tri_cong_tac_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f309_quan_ly_cong_tac v_frm = new f309_quan_ly_cong_tac();
                if(IsExistFormName(v_frm)) return;
                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_nhan_vien_loai_lao_dong_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f370_nhan_vien_loai_lao_dong v_frm = new f370_nhan_vien_loai_lao_dong();
                if(IsExistFormName(v_frm)) return;
                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_danh_muc_don_vi_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                F101_dm_don_vi v_frm = new F101_dm_don_vi();
                if(IsExistFormName(v_frm)) return;
                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void c_cmd_danh_muc_bao_hiem_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                F102_dm_bao_hiem v_frm = new F102_dm_bao_hiem();
                if(IsExistFormName(v_frm)) return;
                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                F696_Cham_cong_xls v_frm = new F696_Cham_cong_xls();
                if(IsExistFormName(v_frm)) return;
                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_dm_nhan_vien_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                //F150_dm_nhan_vien v_frm = new F150_dm_nhan_vien();
                //if(IsExistFormName(v_frm)) return;
                //v_frm.MdiParent = this;
                //v_frm.Show();
                F153_dm_nguoi_bao_lanh v_f = new F153_dm_nguoi_bao_lanh();
                if(IsExistFormName(v_f)) return;
                v_f.MdiParent = this;
                v_f.Show();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_tk_ns_dv_ItemClick(object sender, ItemClickEventArgs e)
        {
            //F420_Bao_cao_nhan_su_theo_don_vi v_f = new F420_Bao_cao_nhan_su_theo_don_vi();
            //f410_bao_cao_so_luong_chat_luong_lao_dong v_frm = new f410_bao_cao_so_luong_chat_luong_lao_dong();
            //if (IsExistFormName(v_frm)) return;
            //v_frm.MdiParent = this;
            //v_frm.Show();
            f400_rptth_phan_loai_lao_dong v_frm = new f400_rptth_phan_loai_lao_dong();
            if(IsExistFormName(v_frm)) { return; }
            v_frm.MdiParent = this;
            v_frm.Show();
        }

        private void m_cmd_tk_ns_tong_hop_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void m_cmd_dang_ky_giam_tru_phu_thuoc_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                //F312_dang_ky_giam_tru_nguoi_phu_thuoc v_f = new F312_dang_ky_giam_tru_nguoi_phu_thuoc();
                //if(IsExistFormName(v_f)) return;
                //v_f.MdiParent = this;
                //v_f.Show();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_dang_ky_bao_hiem_y_te_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                //f392_ke_khai_bao_hiem_y_te v_f = new f392_ke_khai_bao_hiem_y_te();
                //if(IsExistFormName(v_f)) return;
                //v_f.MdiParent = this;
                //v_f.Show();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_tinh_phep_tieu_chuan_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f396_tinh_phep_tieu_chuan v_f = new f396_tinh_phep_tieu_chuan();
                if(IsExistFormName(v_f)) return;
                v_f.MdiParent = this;
                v_f.Show();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }



        private void m_cmd_tk_lao_dong_nuoc_ngoai_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                frm419_bao_cao_thay_doi_cong_tac v_f = new frm419_bao_cao_thay_doi_cong_tac();
                if(IsExistFormName(v_f)) return;
                v_f.MdiParent = this;
                v_f.Show();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_thong_tin_nhan_vien_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f450_thong_tin_nhan_vien v_f = new f450_thong_tin_nhan_vien();
                if(IsExistFormName(v_f)) return;
                v_f.MdiParent = this;
                v_f.Show();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_cham_cong_thang_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f394_cham_cong_thang v_f = new f394_cham_cong_thang();
                if(IsExistFormName(v_f)) return;
                v_f.MdiParent = this;
                v_f.Show();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                F394_gd_nhan_vien_phu_cap v_f = new F394_gd_nhan_vien_phu_cap();
                if(IsExistFormName(v_f)) return;
                v_f.MdiParent = this;
                v_f.Show();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_bc_thu_lao_hdqt_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f481_bao_cao_thu_lao_hdqt v_f = new f481_bao_cao_thu_lao_hdqt();
                if(IsExistFormName(v_f)) return;
                v_f.MdiParent = this;
                v_f.Show();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_bang_luong_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f409_rpt_bang_luong_nv_v2 v_f = new f409_rpt_bang_luong_nv_v2();
                if(IsExistFormName(v_f)) return;
                v_f.MdiParent = this;
                v_f.Show();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_quyet_toan_the_nam_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f490_rpt_ke_khai_thu_nhap_va_thue_thu_nhap_da_khau_tru v_f = new f490_rpt_ke_khai_thu_nhap_va_thue_thu_nhap_da_khau_tru();

                if(IsExistFormName(v_f)) return;
                v_f.MdiParent = this;
                v_f.Show();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_bao_cao_thu_nhap_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f491_rpt_bao_cao_tong_hop_thu_nhap_theo_nam v_f = new f491_rpt_bao_cao_tong_hop_thu_nhap_theo_nam();
                if(IsExistFormName(v_f)) return;
                v_f.MdiParent = this;
                v_f.Show();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_bc_nam_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f491_rpt_bao_cao_tong_hop_thu_nhap_theo_nam v_f = new f491_rpt_bao_cao_tong_hop_thu_nhap_theo_nam();
                if(IsExistFormName(v_f)) return;
                v_f.MdiParent = this;
                v_f.Show();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_cm_dm_thu_tu_don_vi_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                //F115_dm_thu_tu_don_vi_chuc_vu v_f = new F115_dm_thu_tu_don_vi_chuc_vu
                f311_danh_sach_nhan_vien_theo_don_vi v_f = new f311_danh_sach_nhan_vien_theo_don_vi();
                if(IsExistFormName(v_f)) return;
                v_f.MdiParent = this;
                v_f.Show();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_so_ngay_lam_them_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f303_gd_cham_cong_lam_them v_f = new f303_gd_cham_cong_lam_them();
                if(IsExistFormName(v_f)) return;
                v_f.MdiParent = this;
                v_f.Show();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_cac_khoan_khac_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f303_cac_khoan_tien_khac v_f = new f303_cac_khoan_tien_khac();
                if(IsExistFormName(v_f)) return;
                v_f.MdiParent = this;
                v_f.Show();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_ds_nhan_vien_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f151_Danh_sach_nhan_vien_master v_f = new f151_Danh_sach_nhan_vien_master();
                if(IsExistFormName(v_f)) return;
                v_f.MdiParent = this;
                v_f.Show();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_quy_trinh_nhap_nhan_su_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                //F500_QUY_TRINH_THEM_MOI_NHAN_SU v_f = new F500_QUY_TRINH_THEM_MOI_NHAN_SU();
                //if (IsExistFormName(v_f)) return;
                //v_f.MdiParent = this;
                //v_f.Show();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        //private void m_cmd_tong_hop_cham_cong_ItemClick(object sender, ItemClickEventArgs e)
        //{
        //    try
        //    {
        //        f402_tong_hop_cham_cong v_f = new f402_tong_hop_cham_cong();
        //        if (IsExistFormName(v_f)) return;
        //        v_f.MdiParent = this;
        //        v_f.Show();
        //    }
        //    catch (Exception v_e)
        //    {
        //        CSystemLog_301.ExceptionHandle(v_e);
        //    }
        //}

        private void m_cmd_quan_ly_giam_tru_phu_thuoc_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f312_dang_ky_giam_tru_nguoi_phu_thuoc_v2 v_f = new f312_dang_ky_giam_tru_nguoi_phu_thuoc_v2();
                if(IsExistFormName(v_f)) return;
                v_f.MdiParent = this;
                v_f.Show();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_import_tu_excel_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                //F503_IMPORT_EXCEL v_f = new F503_IMPORT_EXCEL();
                //if (IsExistFormName(v_f)) return;
                //v_f.MdiParent = this;
                //v_f.Show();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_tnk_ngoai_bang_luong_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                //f303_tnk_ngoai_bang_luong v_f = new f303_tnk_ngoai_bang_luong();
                //if (IsExistFormName(v_f)) return;
                //v_f.MdiParent = this;
                //v_f.Show();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }








        //void m_cmd_backup_restore_ItemClick(object sender, ItemClickEventArgs e)
        //{
        //    try
        //    {
        //        BackupDB v_frm = new BackupDB();
        //        if (IsExistFormName(v_frm)) return;

        //        v_frm.MdiParent = this;
        //        v_frm.Show();
        //    }
        //    catch (Exception v_e)
        //    {
        //        CSystemLog_301.ExceptionHandle(v_e);
        //    }
        //}

        //void m_cmd_nguoi_sd_ItemClick(object sender, ItemClickEventArgs e)
        //{
        //    try
        //    {
        //        f999_ht_nguoi_su_dung v_frm = new f999_ht_nguoi_su_dung();
        //        if (IsExistFormName(v_frm)) return;

        //        v_frm.MdiParent = this;
        //        v_frm.Show();
        //    }
        //    catch (Exception v_e)
        //    {
        //        CSystemLog_301.ExceptionHandle(v_e);
        //    }
        //}

        //void m_cmd_doi_mat_khau_ItemClick(object sender, ItemClickEventArgs e)
        //{
        //    try
        //    {
        //        f308_DOI_MAT_KHAU_NGUOI_SD v_frm = new f308_DOI_MAT_KHAU_NGUOI_SD();
        //        if (IsExistFormName(v_frm)) return;

        //        v_frm.MdiParent = this;
        //        v_frm.Show();
        //    }
        //    catch (Exception v_e)
        //    {
        //        CSystemLog_301.ExceptionHandle(v_e);
        //    }
        //}

        //void m_cmd_nhom_nguoi_su_dung_ItemClick(object sender, ItemClickEventArgs e)
        //{
        //    try
        //    {
        //        f306_HT_USER_GROUP v_frm = new f306_HT_USER_GROUP();
        //        if (IsExistFormName(v_frm)) return;

        //        v_frm.MdiParent = this;
        //        v_frm.Show();
        //    }
        //    catch (Exception v_e)
        //    {
        //        CSystemLog_301.ExceptionHandle(v_e);
        //    }
        //}

        //void m_cmd_phan_quyen_nhom_ItemClick(object sender, ItemClickEventArgs e)
        //{
        //    try
        //    {
        //        f995_ht_phan_quyen_cho_nhom v_frm = new f995_ht_phan_quyen_cho_nhom();
        //        if (IsExistFormName(v_frm)) return;

        //        v_frm.MdiParent = this;
        //        v_frm.Show();
        //    }
        //    catch (Exception v_e)
        //    {
        //        CSystemLog_301.ExceptionHandle(v_e);
        //    }
        //}

        //void m_cmd_thoat_ItemClick(object sender, ItemClickEventArgs e)
        //{
        //    try
        //    {
        //        this.Close();
        //    }
        //    catch (Exception v_e)
        //    {
        //        CSystemLog_301.ExceptionHandle(v_e);
        //    }
        //}


    }
}