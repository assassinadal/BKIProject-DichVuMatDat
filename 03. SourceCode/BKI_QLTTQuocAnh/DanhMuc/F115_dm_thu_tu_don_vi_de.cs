using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using BKI_DichVuMatDat;
using BKI_DichVuMatDat.US;
using BKI_DichVuMatDat.DS;
using BKI_DichVuMatDat.DS.CDBNames;

using IP.Core.IPCommon;

namespace BKI_DichVuMatDat.DanhMuc
{
    public partial class F115_dm_thu_tu_don_vi_de : Form
    {
        public F115_dm_thu_tu_don_vi_de()
        {
            InitializeComponent();
            format_controls();
        }

        #region Public Interface

        public void DisplayForUpdate(US_CM_THU_TU_DON_VI v_us)
        {
            this.Text = "F115 - Sửa thứ tự đơn vị";
            m_lbl_header.Text = "SỬA THỨ TỰ ĐƠN VỊ";
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            m_txt_ten_don_vi.Enabled = false;
            m_us = v_us;
            us_to_form(m_us);
            this.CenterToScreen();
            this.ShowDialog();
        }

        #endregion

        #region Members

        DataEntryFormMode m_e_form_mode = new DataEntryFormMode();
        US_CM_THU_TU_DON_VI m_us = new US_CM_THU_TU_DON_VI();

        #endregion

        #region Private Methods

        private void set_init_form_load()
        {

        }

        private void us_to_form(US_CM_THU_TU_DON_VI v_us)
        {
            m_txt_ten_don_vi.Text = v_us.strTEN_DON_VI;
            m_txt_stt.Text = v_us.dcSTT.ToString();
        }

        private void form_to_us()
        {
            m_us.strTEN_DON_VI = m_txt_ten_don_vi.Text;
            m_us.dcSTT = CIPConvert.ToDecimal(m_txt_stt.Text);
        }

        private void format_controls()
        {
            FormatControl.SetVisibleSimpleButton(this);
            set_define_events();
            this.KeyPreview = true;
        }

        private bool check_data_is_ok()
        {
            if (m_txt_stt.Text.Trim() == "")
            {

                return false;
            }
            return true;
        }

        #endregion

        //
        //
        // EVENT HANLDERS
        //
        //

        private void set_define_events()
        {
            this.Load += new System.EventHandler(this.F115_dm_thu_tu_don_vi_de_Load);
            m_cmd_save.Click += m_cmd_save_Click;
            m_cmd_exit.Click += m_cmd_exit_Click;
            this.KeyDown += F115_dm_thu_tu_don_vi_de_KeyDown;
            m_txt_stt.KeyPress += M_txt_stt_KeyPress;
        }

        private void M_txt_stt_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void F115_dm_thu_tu_don_vi_de_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
                {
                    this.Close();
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void F115_dm_thu_tu_don_vi_de_Load(object sender, EventArgs e)
        {
            try
            {
                set_init_form_load();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (check_data_is_ok() == true)
                {
                    if (CHRM_BaseMessages.MsgBox_Confirm(CONST_ID_MSGBOX.QUESTION_XAC_NHAN_CAP_NHAT_DU_LIEU))
                    {
                        form_to_us();
                        m_us.Update();
                        CHRM_BaseMessages.MsgBox_Infor(CONST_ID_MSGBOX.INFOR_DU_LIEU_DA_DUOC_CAP_NHAT);
                        this.Close();
                    }
                    else
                    {
                        return;
                    }
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_exit_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
    }
}
