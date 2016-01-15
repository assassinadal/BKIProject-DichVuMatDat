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

            m_cmd_quy_trinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(12)))), ((int)(((byte)(21)))));
            m_cmd_thuc_linh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(12)))), ((int)(((byte)(21)))));
            m_cmd_tong_thu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(12)))), ((int)(((byte)(21)))));
            m_cmd_tong_tri_tra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(12)))), ((int)(((byte)(21)))));
            switch (i_e_button)
            {
                case button_enum.thuc_linh:
                    m_cmd_thuc_linh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                    break;
                case button_enum.tong_thu:
                    m_cmd_tong_thu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                    break;
                case button_enum.tri_tra:
                    m_cmd_tong_tri_tra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                    break;
                case button_enum.tro_giup:
                    m_cmd_quy_trinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(46)))));
                    break;
            }

        }

        private void set_define_events()
        {
            m_cmd_tong_thu.Click += m_cmd_tong_thu_Click;
            m_cmd_quy_trinh.Click += m_cmd_quy_trinh_Click;
            m_cmd_thuc_linh.Click += m_cmd_thuc_linh_Click;
            m_cmd_tong_tri_tra.Click += m_cmd_tong_tri_tra_Click;
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
