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
using BKI_DichVuMatDat.US;
using IP.Core.IPCommon;
using BKI_DichVuMatDat.DS.CDBNames;
using DevExpress.XtraEditors;
using System.Globalization;
using IP.Core.IPSystemAdmin;

namespace BKI_DichVuMatDat.NghiepVu
{
    public partial class F365_quan_ly_hs_bo_sung : Form
    {
        

        #region Public Interface
        public F365_quan_ly_hs_bo_sung()
        {
            InitializeComponent();
            format_controls();
        }
        ~F365_quan_ly_hs_bo_sung()
        {
            Dispose(false);
        }
        #endregion

        #region Members
        
        #endregion

        #region Private methods
        private void format_controls()
        {
            FormatControl.SetVisibleSimpleButton(this);
            this.m_grv_quan_ly_he_so_bo_sung.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(WinFormControls.m_grv_PopupMenuShowing);
            this.m_grv_quan_ly_he_so_bo_sung.OptionsPrint.AutoWidth = false;
            set_define_events();
            this.KeyPreview = true;
        }

        private void set_initial_form_load()
        {
            m_txt_chon_nam.Text = DateTime.Now.Year.ToString();
        }

        private void save_data()
        {

        }
        #endregion
        private void set_define_events()
        {
            this.Load += F365_quan_ly_hs_bo_sung_Load;
            m_cmd_luu_so_tien.Click += m_cmd_luu_so_tien_Click;
            m_cmd_tinh_tien.Click += m_cmd_tinh_tien_Click;
            FormClosed += F365_quan_ly_hs_bo_sung_FormClosed;
        }

        void F365_quan_ly_hs_bo_sung_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Dispose();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_tinh_tien_Click(object sender, EventArgs e)
        {
            try
            {
                //Fill Data To Grid Here
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_luu_so_tien_Click(object sender, EventArgs e)
        {
            try
            {
                if (m_grc_quan_ly_he_so_bo_sung.DataSource == null)
                {
                    XtraMessageBox.Show("Dữ liệu trống", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                save_data();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void F365_quan_ly_hs_bo_sung_Load(object sender, EventArgs e)
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
    }
}
