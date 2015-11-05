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

namespace BKI_DichVuMatDat
{
    public partial class f388_main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public f388_main()
        {
            InitializeComponent();
            format_control();
            MdiManager.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
            ribbon.SelectedPage = ribbonPage3;
        }

        public void display(ref IP.Core.IPCommon.IPConstants.HowUserWantTo_Exit_MainForm v_exitmode)
        {
            try
            {
                this.ShowDialog();
            }
            catch (Exception v_e)
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
            catch (Exception v_e)
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

        private bool IsExistFormName(Form ip_frm)
        {
            foreach (var child in MdiChildren)
            {
                if (child.Name == ip_frm.Name)
                {
                    child.Activate();
                    return true;
                }
            }
            return false;
        }

        private bool IsExistFormText(Form ip_frm)
        {
            foreach (var child in MdiChildren)
            {
                if (child.Text == ip_frm.Text)
                {
                    child.Activate();
                    return true;
                }
            }
            return false;
        }
        #endregion

        ///
        ///Events
        ///
        ///
        private void set_define_events()
        {
            this.Load += f388_main_Load;
            //Nghiệp vụ
            m_cmd_cham_cong_nv.ItemClick += m_cmd_cham_cong_nv_ItemClick;
            m_cmd_lap_hop_dong.ItemClick += m_cmd_lap_hop_dong_ItemClick;
            m_cmd_len_luong_cho_nv.ItemClick += m_cmd_len_luong_cho_nv_ItemClick;
            m_cmd_dat_hs_lns_lcd.ItemClick += m_cmd_dat_hs_lns_lcd_ItemClick;
            m_cmd_quan_ly_qd.ItemClick += m_cmd_quan_ly_qd_ItemClick;
            m_cmd_hs_chat_luong_xls.ItemClick += m_cmd_them_hs_chat_luong_ItemClick;
            m_cmd_hs_chat_luong_by_nv.ItemClick += m_cmd_hs_chat_luong_by_nv_ItemClick;
            m_cmd_quan_ly_thu_nhap_khac.ItemClick += m_cmd_quan_ly_thu_nhap_khac_ItemClick;
            m_cmd_quan_ly_thu_nhap_khac_xls.ItemClick += m_cmd_quan_ly_thu_nhap_khac_xls_ItemClick;
            m_cmd_quan_ly_luong_cung.ItemClick += m_cmd_quan_ly_luong_cung_ItemClick;
            m_cmd_quan_ly_khong_dong_bh.ItemClick += m_cmd_quan_ly_khong_dong_bh_ItemClick;
            m_cmd_luong_hs_athk.ItemClick += m_cmd_luong_hs_athk_ItemClick;
            m_cmd_ql_thuong_hsbs.ItemClick += m_cmd_ql_thuong_hsbs_ItemClick;
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
            //Bao cao
            m_cmd_bang_luong_nv.ItemClick += m_cmd_bang_luong_nv_ItemClick;
            m_cmd_bc_hs_bs_hs_athk.ItemClick += m_cmd_bc_hs_bs_hs_athk_ItemClick;
            m_cmd_bc_cac_thang_da_chot_bang_luong.ItemClick += m_cmd_bc_cac_thang_da_chot_bang_luong_ItemClick;
            m_cmd_luong_theo_don_vi.ItemClick += m_cmd_luong_theo_don_vi_ItemClick;
            m_cmd_chuyen_trang_thai_LD.ItemClick += m_cmd_chuyen_trang_thai_LD_ItemClick;
            m_cmd_bao_cao_tong_hop.ItemClick += m_cmd_bao_cao_tong_hop_ItemClick;
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
                F365_quan_ly_hs_bo_sung v_frm = new F365_quan_ly_hs_bo_sung();
                if (IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch (Exception)
            {
                throw;
            }
        }

        void m_cmd_chuyen_trang_thai_LD_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                frm356_chuyen_trang_thai_lao_dong v_frm = new frm356_chuyen_trang_thai_lao_dong();
                if (IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch (Exception)
            {
                throw;
            }
        }

        void m_cmd_luong_hs_athk_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f355_thuong_an_toan_hang_khong v_frm = new f355_thuong_an_toan_hang_khong();
                if (IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch (Exception)
            {
                throw;
            }
        }

        void m_cmd_luong_theo_don_vi_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f440_rpt_luong v_frm = new f440_rpt_luong();
                if (IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch (Exception)
            {
                throw;
            }
        }

        void m_cmd_bc_cac_thang_da_chot_bang_luong_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                F430_bao_cao_cac_thang_da_chot_bang_luong v_frm = new F430_bao_cao_cac_thang_da_chot_bang_luong();
                if (IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_bc_hs_bs_hs_athk_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                F415_bao_cao_hs_bs_hs_athk v_frm = new F415_bao_cao_hs_bs_hs_athk();
                if (IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_backup_restore_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                BackupDB v_frm = new BackupDB();
                if (IsExistFormName(v_frm)) return;

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
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void set_initial_form_load()
        {
            //format_control();
        }

        void m_cmd_bang_luong_nv_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f410_rpt_bang_luong_nv v_frm = new f410_rpt_bang_luong_nv();
                if (IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_cham_cong_nv_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f310_cham_cong_theo_danh_sach_nhan_vien v_frm = new f310_cham_cong_theo_danh_sach_nhan_vien();
                if (IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_lap_hop_dong_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f320_lap_hop_dong v_frm = new f320_lap_hop_dong();
                if (IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_len_luong_cho_nv_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f330_len_luong_cho_nv v_frm = new f330_len_luong_cho_nv();
                if (IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_dat_hs_lns_lcd_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f340_dat_hs_lns_lcd v_frm = new f340_dat_hs_lns_lcd();
                if (IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_quan_ly_qd_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f360_quan_ly_quyet_dinh v_frm = new f360_quan_ly_quyet_dinh();
                if (IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_them_hs_chat_luong_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f380_thay_doi_he_so_chat_luong_xls v_frm = new f380_thay_doi_he_so_chat_luong_xls();
                if (IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_hs_chat_luong_by_nv_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f381_thay_doi_he_so_luong_nang_suat_by_nhan_vien v_frm = new f381_thay_doi_he_so_luong_nang_suat_by_nhan_vien();
                if (IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_quan_ly_thu_nhap_khac_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f390_gd_thu_nhap_khac v_frm = new f390_gd_thu_nhap_khac();
                if (IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_quan_ly_thu_nhap_khac_xls_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f391_thu_nhap_khac_xls v_frm = new f391_thu_nhap_khac_xls();
                if (IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_quan_ly_luong_cung_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f363_quan_ly_cac_nhan_vien_co_luong_cung v_frm = new f363_quan_ly_cac_nhan_vien_co_luong_cung();
                if (IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_quan_ly_khong_dong_bh_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f366_quan_ly_nhan_vien_khong_dong_bao_hiem v_frm = new f366_quan_ly_nhan_vien_khong_dong_bao_hiem();
                if (IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }


        private void m_cmd_dm_tham_so_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                DanhMuc.F108_dm_tham_so v_frm = new DanhMuc.F108_dm_tham_so();
                if (IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_dm_he_so_luong_ns_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                DanhMuc.F103_dm_he_so_luong_ns v_frm = new DanhMuc.F103_dm_he_so_luong_ns();
                if (IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_dm_luong_che_do_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                DanhMuc.F106_dm_luong_che_do v_frm = new DanhMuc.F106_dm_luong_che_do();
                if (IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_dm_phu_cap_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                DanhMuc.F107_dm_phu_cap v_frm = new DanhMuc.F107_dm_phu_cap();
                if (IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_dm_loai_hop_dong_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                DanhMuc.F104_dm_loai_hop_dong v_frm = new DanhMuc.F104_dm_loai_hop_dong();
                if (IsExistFormName(v_frm)) return;
                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_dm_loai_ngay_cong_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                F105_dm_loai_ngay_cong v_frm = new F105_dm_loai_ngay_cong();
                if (IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_dm_thue_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                DanhMuc.F109_dm_thue v_frm = new DanhMuc.F109_dm_thue();
                if (IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_quan_ly_vi_tri_cong_tac_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f350_quan_ly_vi_tri_cong_tac v_frm = new f350_quan_ly_vi_tri_cong_tac();
                if (IsExistFormName(v_frm)) return;
                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_nhan_vien_loai_lao_dong_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f370_nhan_vien_loai_lao_dong v_frm = new f370_nhan_vien_loai_lao_dong();
                if (IsExistFormName(v_frm)) return;
                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_danh_muc_don_vi_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                F101_dm_don_vi v_frm = new F101_dm_don_vi();
                if (IsExistFormName(v_frm)) return;
                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void c_cmd_danh_muc_bao_hiem_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                F102_dm_bao_hiem v_frm = new F102_dm_bao_hiem();
                if (IsExistFormName(v_frm)) return;
                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                F696_Cham_cong_xls v_frm = new F696_Cham_cong_xls();
                if (IsExistFormName(v_frm)) return;
                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_dm_nhan_vien_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                F150_dm_nhan_vien v_frm = new F150_dm_nhan_vien();
                if (IsExistFormName(v_frm)) return;
                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_tk_ns_dv_ItemClick(object sender, ItemClickEventArgs e)
        {
            F420_Bao_cao_nhan_su_theo_don_vi v_f = new F420_Bao_cao_nhan_su_theo_don_vi();
            v_f.MdiParent = this;
            v_f.Show();
        }

        private void m_cmd_tk_ns_tong_hop_ItemClick(object sender, ItemClickEventArgs e)
        {
            F425_Bao_cao_nhan_su_tong_hop v_f = new F425_Bao_cao_nhan_su_tong_hop();
            v_f.MdiParent = this;
            v_f.Show();
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