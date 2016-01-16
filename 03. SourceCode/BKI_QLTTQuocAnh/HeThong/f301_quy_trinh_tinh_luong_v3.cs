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
    public partial class f301_quy_trinh_tinh_luong_v3 : Form
    {        
        #region Publish methods
        public f301_quy_trinh_tinh_luong_v3()
        {
            InitializeComponent();
            format_controls();
        }
        #endregion Publish methods

        #region DataStructs
        enum button_enum
        {
            tong_thu_nhap = 1,
            thu_nhap_trong_bang_luong = 2,
            thu_nhap_ngoai_bang_luong = 3,
            cac_khoan_giam_tru_thue = 4,
            tong_cac_khoan_phai_thu = 5,
            thu_linh = 6            
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
            m_tab.SelectedTab = m_tabPage_tong_thu_nhap;
            set_active_button(button_enum.tong_thu_nhap);
        }

        private void set_active_button(button_enum i_e_button)
        {            
            m_cmd_tong_thu_nhap.BackColor = Color.SteelBlue;
            m_cmd_tong_thu_nhap.ForeColor = Color.White;
            m_cmd_thu_nhap_tu_luong.BackColor = Color.Green;
                m_cmd_thu_nhap_tu_luong.ForeColor = Color.White;
                m_cmd_thu_nhap_ngoai_bang_luong.BackColor = Color.Green;
                m_cmd_thu_nhap_ngoai_bang_luong.ForeColor = Color.White;

            m_cmd_giam_tru_thue.BackColor = Color.SteelBlue;
            m_cmd_giam_tru_thue.ForeColor = Color.White;

            m_cmd_tong_khoan_phai_thu.BackColor = Color.SteelBlue;
            m_cmd_tong_khoan_phai_thu.ForeColor = Color.White;

            m_cmd_thuc_linh.BackColor = Color.SteelBlue;
            m_cmd_thuc_linh.ForeColor = Color.White;

            switch (i_e_button)
            {
                case button_enum.tong_thu_nhap:
                    m_cmd_tong_thu_nhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
                    break;
                case button_enum.cac_khoan_giam_tru_thue:
                    m_cmd_giam_tru_thue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
                    break;
                case button_enum.tong_cac_khoan_phai_thu:
                    m_cmd_tong_khoan_phai_thu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
                    break;
                case button_enum.thu_linh:
                    m_cmd_thuc_linh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
                    break;
            }
        }
        private void set_define_events()
        {                        
            // Tong thu nhap
            m_cmd_tong_thu_nhap.Click += m_cmd_tong_thu_nhap_Click;
            m_cmd_thu_nhap_trong_bang_luong_detail.Click += m_cmd_thu_nhap_trong_bang_luong_detail_Click;
            m_cmd_thu_nhap_ngoai_bang_luong_detail.Click += m_cmd_thu_nhap_ngoai_bang_luong_detail_Click;
            m_cmd_thu_nhap_tu_luong.Click += m_cmd_thu_nhap_tu_luong_Click;
            m_cmd_thu_nhap_tu_luong_detail.Click += m_cmd_thu_nhap_tu_luong_detail_Click;
            m_cmd_thuong.Click += m_cmd_thuong_Click;
            // Cac khoan giam tru thue
            m_cmd_giam_tru_thue.Click += m_cmd_giam_tru_thue_Click;
                // giam tru bao hiem
            m_cmd_giam_tru_bao_hiem.Click += m_cmd_giam_tru_bao_hiem_Click;
            // Cac khoan phai thu
            m_cmd_tong_khoan_phai_thu.Click += m_cmd_tong_khoan_phai_thu_Click;
            // Thuc linh
            m_cmd_thuc_linh.Click += m_cmd_thuc_linh_Click;
        }

        void m_cmd_giam_tru_bao_hiem_Click(object sender, EventArgs e)
        {
            try
            {                
                m_cmd_danh_sach_khong_dong_bao_hiem.Visible = (m_cmd_danh_sach_khong_dong_bao_hiem.Visible) ? false : true;
                m_cmd_dang_ky_bao_hiem.Visible = (m_cmd_dang_ky_bao_hiem.Visible) ? false : true;
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_thu_nhap_tu_luong_detail_Click(object sender, EventArgs e)
        {
            try
            {
                m_cmd_cham_cong_theo_thang.Visible = (m_cmd_cham_cong_theo_thang.Visible) ? false : true;
                m_cmd_cham_cong_bang_excel.Visible = (m_cmd_cham_cong_bang_excel.Visible) ? false : true;
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_thuong_Click(object sender, EventArgs e)
        {
            try
            {                
                m_cmd_tinh_thuong_khac.Visible = (m_cmd_tinh_thuong_khac.Visible) ? false : true;
                m_cmd_tinh_thuong_tet.Visible = (m_cmd_tinh_thuong_tet.Visible) ? false : true;
                m_cmd_tinh_thuong.Visible = (m_cmd_tinh_thuong.Visible) ? false : true;                
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_thu_nhap_tu_luong_Click(object sender, EventArgs e)
        {
            
        }

        void m_cmd_thu_nhap_ngoai_bang_luong_detail_Click(object sender, EventArgs e)
        {
            try
            {
                set_active_button(button_enum.thu_nhap_ngoai_bang_luong);
                m_cmd_thu_nhap_tu_luong.Visible = true;
                m_cmd_thu_nhap_ngoai_bang_luong.Visible = true;
                m_cmd_thu_nhap_tu_luong_detail.Visible = false;
                m_cmd_cham_cong_theo_thang.Visible = false;
                m_cmd_cham_cong_bang_excel.Visible = false;
                m_cmd_cham_cong_lam_them.Visible = false;
                m_cmd_phu_cap_trach_nhiem.Visible = false;
                m_cmd_thu_nhap_khac_trong_bang_luong.Visible = false;
                m_cmd_tien_ho_tro.Visible = false;
                m_cmd_truy_linh.Visible = (m_cmd_truy_linh.Visible) ? false : true;
                m_cmd_thuong.Visible = (m_cmd_thuong.Visible) ? false : true;
                m_cmd_tinh_thuong.Visible = false;
                m_cmd_tinh_thuong_tet.Visible = false;
                m_cmd_tinh_thuong_khac.Visible = false;                
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_thu_nhap_trong_bang_luong_detail_Click(object sender, EventArgs e)
        {
            try
            {
                set_active_button(button_enum.thu_nhap_trong_bang_luong);
                m_cmd_thu_nhap_tu_luong.Visible = true;
                m_cmd_thu_nhap_ngoai_bang_luong.Visible = true;                
                m_cmd_tien_ho_tro.Visible = (m_cmd_tien_ho_tro.Visible) ? false : true;
                m_cmd_thu_nhap_khac_trong_bang_luong.Visible = (m_cmd_thu_nhap_khac_trong_bang_luong.Visible) ? false : true;
                m_cmd_phu_cap_trach_nhiem.Visible = (m_cmd_phu_cap_trach_nhiem.Visible) ? false : true;
                m_cmd_cham_cong_lam_them.Visible = (m_cmd_cham_cong_lam_them.Visible) ? false : true;
                m_cmd_thu_nhap_tu_luong_detail.Visible = (m_cmd_thu_nhap_tu_luong_detail.Visible) ? false : true;
                m_cmd_cham_cong_theo_thang.Visible = false;
                m_cmd_cham_cong_bang_excel.Visible = false;
                m_cmd_thuong.Visible = false;
                m_cmd_tinh_thuong.Visible = false;
                m_cmd_tinh_thuong_tet.Visible = false;
                m_cmd_tinh_thuong_khac.Visible = false;
                m_cmd_truy_linh.Visible = false;
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
                set_active_button(button_enum.thu_linh);
                //m_tab.SelectedTab = m_tabPage_thuc_linh;
                m_cmd_thu_nhap_tu_luong.Visible = false;
                m_cmd_thu_nhap_ngoai_bang_luong.Visible = false;
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_tong_khoan_phai_thu_Click(object sender, EventArgs e)
        {
            try
            {
                set_active_button(button_enum.tong_cac_khoan_phai_thu);
                //m_tab.SelectedTab = m_tabPage_tong_khoan_phai_thu;
                m_cmd_thu_nhap_tu_luong.Visible = false;
                m_cmd_thu_nhap_ngoai_bang_luong.Visible = false;
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_giam_tru_thue_Click(object sender, EventArgs e)
        {
            try
            {
                set_active_button(button_enum.cac_khoan_giam_tru_thue);
                m_tab.SelectedTab = m_tagPage_cac_khoan_giam_tru_thue;
                m_cmd_thu_nhap_tu_luong.Visible = false;
                m_cmd_thu_nhap_ngoai_bang_luong.Visible = false;
                
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_tong_thu_nhap_Click(object sender, EventArgs e)
        {
            try
            {                
                set_active_button(button_enum.tong_thu_nhap);
                m_tab.SelectedTab = m_tabPage_tong_thu_nhap;
                m_cmd_thu_nhap_ngoai_bang_luong.Visible = (m_cmd_thu_nhap_ngoai_bang_luong.Visible) ? false : true;
                m_cmd_thu_nhap_tu_luong.Visible = (m_cmd_thu_nhap_tu_luong.Visible) ? false : true;                
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        #endregion Private methods
    }
}
