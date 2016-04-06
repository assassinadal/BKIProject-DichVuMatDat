using BKI_DichVuMatDat.DanhMuc;
using BKI_DichVuMatDat.NghiepVu;
using IP.Core.IPCommon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BKI_DichVuMatDat.HeThong
{
    public partial class f301_quy_trinh_tinh_luong_v2 : Form
    {
        #region Publish methods
        public f301_quy_trinh_tinh_luong_v2()
        {
            InitializeComponent();
            format_controls();
        }
        #endregion Publish methods

        #region DataStructs
        enum button_enum
        {
            tong_thu = 1,
            tri_tra = 2,
            thuc_linh = 3,
            tro_giup = 4,
        }
        #endregion DataStructs

        #region Members

        #endregion Members

        #region Private methods
        private void format_controls()
        {
            set_define_events();
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.ShowInTaskbar = true;
            this.HelpButton = false;
            m_panel_hide.Height = 23;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            m_tab.SelectedTab = m_tabPage_thuc_linh;
            set_active_button(button_enum.thuc_linh);
        }

        private void set_active_button(button_enum i_e_button)
        {

            m_cmd_quy_trinh.BackColor = Color.DodgerBlue;
            m_cmd_thuc_linh.BackColor = Color.DodgerBlue;
            m_cmd_tong_thu.BackColor = Color.DodgerBlue;
            m_cmd_tong_tri_tra.BackColor = Color.DodgerBlue;
            switch (i_e_button)
            {
                case button_enum.thuc_linh:
                    m_cmd_thuc_linh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
                    break;
                case button_enum.tong_thu:
                    m_cmd_tong_thu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
                    break;
                case button_enum.tri_tra:
                    m_cmd_tong_tri_tra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
                    break;
                case button_enum.tro_giup:
                    m_cmd_quy_trinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
                    break;
            }

        }

        private void set_define_events()
        {
            m_cmd_tong_thu.Click += m_cmd_tong_thu_Click;
            m_cmd_quy_trinh.Click += m_cmd_quy_trinh_Click;
            m_cmd_thuc_linh.Click += m_cmd_thuc_linh_Click;
            m_cmd_tong_tri_tra.Click += m_cmd_tong_tri_tra_Click;

            m_cmd_quan_ly_nhan_vien.Click += m_cmd_quan_ly_nhan_vien_Click;
            m_cmd_quan_ly_nhan_vien.MouseHover += m_cmd_quan_ly_nhan_vien_MouseHover;

            m_cmd_chuyen_trang_thai_lao_dong.Click += m_cmd_chuyen_trang_thai_lao_dong_Click;
            m_cmd_danh_muc_don_vi_cong_tac.Click += m_cmd_danh_muc_don_vi_cong_tac_Click;
            m_cmd_dm_trang_thai_lao_dong.Click += m_cmd_dm_trang_thai_lao_dong_Click;
            m_cmd_quan_ly_don_vi_cong_tac.Click += m_cmd_quan_ly_don_vi_cong_tac_Click;

            m_cmd_quan_ly_quyet_dinh.Click += m_cmd_quan_ly_quyet_dinh_Click;
            m_cmd_lap_hop_dong.Click += m_cmd_lap_hop_dong_Click;
            m_cmd_loai_hop_dong.Click += m_cmd_loai_hop_dong_Click;

            m_cmd_dat_he_so_LNS_LCD.Click += m_cmd_dat_he_so_LNS_LCD_Click;
            m_cmd_quan_ly_luong_cung.Click += m_cmd_quan_ly_luong_cung_Click;
            m_cmd_tinh_thuong.Click += m_cmd_tinh_thuong_Click;

            m_cmd_thuong_le_tet.Click += m_cmd_thuong_le_tet_Click;
            m_cmd_quan_ly_thuong_khac.Click += m_cmd_quan_ly_thuong_khac_Click;
            m_cmd_phu_cap_trach_nhiem.Click += m_cmd_phu_cap_trach_nhiem_Click;
            m_cmd_quan_ly_thu_nhap_khac.Click += m_cmd_quan_ly_thu_nhap_khac_Click;
            m_cmd_he_so_chat_luong.Click += m_cmd_he_so_chat_luong_Click;
            m_cmd_cham_cong_lam_them.Click += m_cmd_cham_cong_lam_them_Click;
            m_cmd_cham_cong_theo_thang.Click += m_cmd_cham_cong_theo_thang_Click;
            m_cmd_cham_cong_bang_excel.Click += m_cmd_cham_cong_bang_excel_Click;
            m_cmd_theo_doi_cham_cong.Click += m_cmd_theo_doi_cham_cong_Click;
            m_cmd_dang_ky_bao_hiem.Click += m_cmd_dang_ky_bao_hiem_Click;
            m_cmd_nhan_vien_khong_dong_bh.Click += m_cmd_nhan_vien_khong_dong_bh_Click;
            m_cmd_dang_ky_giam_tru_nguoi_phu_thuoc.Click += m_cmd_dang_ky_giam_tru_nguoi_phu_thuoc_Click;
            m_cmd_bieu_do_thue_luy_tien.Click += m_cmd_bieu_do_thue_luy_tien_Click;
        }

        void m_cmd_quan_ly_nhan_vien_MouseHover(object sender, EventArgs e)
        {
            try
            {
                m_toptip.Show("Thêm nhân viên mới trong tháng", m_cmd_quan_ly_nhan_vien);
                m_toptip.BackColor = Color.Transparent;
                m_toptip.ForeColor = Color.DarkBlue;
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_bieu_do_thue_luy_tien_Click(object sender, EventArgs e)
        {            
            try
            {
                DanhMuc.F109_dm_thue v_frm = new DanhMuc.F109_dm_thue();
                v_frm.ShowDialog();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_dang_ky_giam_tru_nguoi_phu_thuoc_Click(object sender, EventArgs e)
        {            
            try
            {
                //F312_dang_ky_giam_tru_nguoi_phu_thuoc v_frm = new F312_dang_ky_giam_tru_nguoi_phu_thuoc();
                //v_frm.ShowDialog();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_nhan_vien_khong_dong_bh_Click(object sender, EventArgs e)
        {            
            try
            {
                f366_quan_ly_nhan_vien_khong_dong_bao_hiem v_frm = new f366_quan_ly_nhan_vien_khong_dong_bao_hiem();
                v_frm.ShowDialog();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_dang_ky_bao_hiem_Click(object sender, EventArgs e)
        {
            try
            {
                f392_ke_khai_bao_hiem_y_te v_frm = new f392_ke_khai_bao_hiem_y_te();
                v_frm.ShowDialog();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_theo_doi_cham_cong_Click(object sender, EventArgs e)
        {            
            try
            {
                //f310_cham_cong_theo_danh_sach_nhan_vien v_frm = new f310_cham_cong_theo_danh_sach_nhan_vien();
                //v_frm.ShowDialog();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_cham_cong_bang_excel_Click(object sender, EventArgs e)
        {
            try
            {
                f394_cham_cong_thang v_frm = new f394_cham_cong_thang();
                v_frm.ShowDialog();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_cham_cong_theo_thang_Click(object sender, EventArgs e)
        {
            try
            {
                f394_cham_cong_thang v_frm = new f394_cham_cong_thang();
                v_frm.ShowDialog();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_cham_cong_lam_them_Click(object sender, EventArgs e)
        {
            try
            {
                //f697_cham_cong_lam_them v_frm = new f697_cham_cong_lam_them();
                //v_frm.ShowDialog();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_he_so_chat_luong_Click(object sender, EventArgs e)
        {
            try
            {
                f381_thay_doi_he_so_luong_nang_suat_by_nhan_vien v_frm = new f381_thay_doi_he_so_luong_nang_suat_by_nhan_vien();
                v_frm.ShowDialog();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_quan_ly_thu_nhap_khac_Click(object sender, EventArgs e)
        {
            try
            {
                //f390_gd_thu_nhap_khac v_frm = new f390_gd_thu_nhap_khac();
                //v_frm.ShowDialog();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_phu_cap_trach_nhiem_Click(object sender, EventArgs e)
        {            
            try
            {
                F394_gd_nhan_vien_phu_cap v_frm = new F394_gd_nhan_vien_phu_cap();
                v_frm.ShowDialog();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_quan_ly_thuong_khac_Click(object sender, EventArgs e)
        {
            try
            {
                f301_tinh_thu_nhap_khac v_frm = new f301_tinh_thu_nhap_khac();
                v_frm.ShowDialog();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_thuong_le_tet_Click(object sender, EventArgs e)
        {
            try
            {
                //f301_tinh_thu_nhap_khac_le_tet v_frm = new f301_tinh_thu_nhap_khac_le_tet();
                //v_frm.ShowDialog();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_tinh_thuong_Click(object sender, EventArgs e)
        {
            try
            {
                //f316_tinh_thuong_2014 v_frm = new f316_tinh_thuong_2014();
                //v_frm.ShowDialog();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_quan_ly_luong_cung_Click(object sender, EventArgs e)
        {            
            try
            {
                f363_quan_ly_cac_nhan_vien_co_luong_cung v_frm = new f363_quan_ly_cac_nhan_vien_co_luong_cung();
                v_frm.ShowDialog();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_dat_he_so_LNS_LCD_Click(object sender, EventArgs e)
        {
            try
            {
                f340_dat_hs_lns_lcd v_frm = new f340_dat_hs_lns_lcd();
                v_frm.ShowDialog();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_loai_hop_dong_Click(object sender, EventArgs e)
        {
            try
            {
                DanhMuc.F104_dm_loai_hop_dong v_frm = new DanhMuc.F104_dm_loai_hop_dong();
                v_frm.ShowDialog();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_lap_hop_dong_Click(object sender, EventArgs e)
        {
            try
            {
                f320_lap_hop_dong v_frm = new f320_lap_hop_dong();
                v_frm.ShowDialog();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_quan_ly_quyet_dinh_Click(object sender, EventArgs e)
        {
            try
            {
                f360_quan_ly_quyet_dinh v_frm = new f360_quan_ly_quyet_dinh();
                v_frm.ShowDialog();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_quan_ly_don_vi_cong_tac_Click(object sender, EventArgs e)
        {
            try
            {
                F101_dm_don_vi v_frm = new F101_dm_don_vi();
                v_frm.ShowDialog();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_dm_trang_thai_lao_dong_Click(object sender, EventArgs e)
        {            
            try
            {
                f356_bao_cao_trang_thai_lao_dong_cua_nhan_vien v_frm = new f356_bao_cao_trang_thai_lao_dong_cua_nhan_vien();
                v_frm.ShowDialog();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_danh_muc_don_vi_cong_tac_Click(object sender, EventArgs e)
        {
            try
            {
                f350_quan_ly_vi_tri_cong_tac v_frm = new f350_quan_ly_vi_tri_cong_tac();
                v_frm.ShowDialog();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_chuyen_trang_thai_lao_dong_Click(object sender, EventArgs e)
        {
            try
            {
                f356_bao_cao_trang_thai_lao_dong_cua_nhan_vien v_frm = new f356_bao_cao_trang_thai_lao_dong_cua_nhan_vien();
                v_frm.ShowDialog();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_quan_ly_nhan_vien_Click(object sender, EventArgs e)
        {
            try
            {
                //f160_them_nhan_vien_nhanh v_frm = new f160_them_nhan_vien_nhanh();
                //v_frm.ShowDialog();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        #endregion Private methods

        #region Events
        void m_cmd_tong_tri_tra_Click(object sender, EventArgs e)
        {
            try
            {
                m_tab.SelectedTab = m_tabPage_khoan_tri_tra;
                set_active_button(button_enum.tri_tra);
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_thuc_linh_Click(object sender, EventArgs e)
        {
            try
            {
                m_tab.SelectedTab = m_tabPage_thuc_linh;
                set_active_button(button_enum.thuc_linh);
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_quy_trinh_Click(object sender, EventArgs e)
        {
            try
            {
                set_active_button(button_enum.tro_giup);
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_tong_thu_Click(object sender, EventArgs e)
        {
            try
            {
                m_tab.SelectedTab = m_tabPage_tong_thu_nhap;
                set_active_button(button_enum.tong_thu);
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        #endregion Events
    }
}
