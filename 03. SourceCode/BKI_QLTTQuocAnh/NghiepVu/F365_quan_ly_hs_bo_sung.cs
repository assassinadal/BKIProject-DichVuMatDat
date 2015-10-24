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
        public F365_quan_ly_hs_bo_sung()
        {
            InitializeComponent();
            format_controls();
        }

        #region Public Interface

        #endregion

        #region Members

        #endregion

        #region Private methods
        private void format_controls()
        {
            this.m_grv_quan_ly_he_so_bo_sung.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(WinFormControls.m_grv_PopupMenuShowing);
            this.m_grv_quan_ly_he_so_bo_sung.OptionsPrint.AutoWidth = false;
            set_define_events();
            this.KeyPreview = true;
        }

        private void set_initial_form_load()
        {
            m_txt_chon_nam.Text = DateTime.Now.Year.ToString();
        }

        private bool check_data_is_ok()
        {
            if (m_txt_chon_nam.Text == "")
            {
                XtraMessageBox.Show("Bạn chưa nhập năm để tính tiền rồi!", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                return false;
            }
            if (m_txt_so_tien.Text == "")
            {
                XtraMessageBox.Show("Bạn chưa nhập số tiền để tính tiền rồi!", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        #endregion
        private void set_define_events()
        {
            this.Load += F365_quan_ly_hs_bo_sung_Load;
            m_cmd_luu_so_tien.Click += m_cmd_luu_so_tien_Click;
        }

        void m_cmd_luu_so_tien_Click(object sender, EventArgs e)
        {
            try
            {
                if (check_data_is_ok())
                {
                    US_GD_THU_NHAP_KHAC v_us = new US_GD_THU_NHAP_KHAC();
                    try
                    {
                        v_us.Insert_tien_hs_bo_sung_luong(CIPConvert.ToDecimal(m_txt_chon_nam.Text.Trim()), CIPConvert.ToDecimal(m_txt_so_tien.Text.Trim()));
                        XtraMessageBox.Show("Thành công!", "THÔNG BÁO");
                    }
                    catch (Exception v_e)
                    {
                        throw v_e;
                    }
                }
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
