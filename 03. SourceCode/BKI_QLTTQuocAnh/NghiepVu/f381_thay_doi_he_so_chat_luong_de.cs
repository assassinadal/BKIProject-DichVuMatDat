using IP.Core.IPCommon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BKI_DichVuMatDat.NghiepVu
{
    public partial class f381_thay_doi_he_so_chat_luong_de : Form
    {
        public f381_thay_doi_he_so_chat_luong_de()
        {
            InitializeComponent();
            format_controls();
        }

        #region Pulic Interface
        public void  display(ref string v_str_path)
        {
            this.CenterToScreen();
            this.ShowDialog();
            v_str_path = m_txt_path.Text;
        }
        #endregion

        #region Members
        
        #endregion

        #region Private methods
        private void format_controls()
        {
            set_define_events();
            this.KeyPreview = true;
        }

        #endregion
        private void set_define_events()
        {
            m_lbl_mau_import.Click += m_lbl_mau_import_Click;
            this.KeyDown += f381_thay_doi_he_so_chat_luong_de_KeyDown;
            m_cmd_chon_file.Click += m_cmd_chon_file_Click;
            m_cmd_OK.Click += m_cmd_OK_Click;
            m_cmd_cancel.Click += m_cmd_cancel_Click;
        }

        void m_cmd_cancel_Click(object sender, EventArgs e)
        {
            try
            {
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                this.Close();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_OK_Click(object sender, EventArgs e)
        {
            try
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_chon_file_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();

                // Set filter options and filter index.
                openFileDialog1.Filter = "xlsx Files|*.xlsx|xls Files|*.xls|All Files (*.*)|*.*";
                openFileDialog1.FilterIndex = 1;
                openFileDialog1.Multiselect = false;
                var userClickedOK = openFileDialog1.ShowDialog();
                if (userClickedOK == System.Windows.Forms.DialogResult.OK)
                {
                    m_txt_path.Text = openFileDialog1.FileName;
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_lbl_mau_import_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("https://docs.google.com/spreadsheets/d/1ySTxHqyExakclRuKwXL4Mp-SDmAayo_63_oOKXoTbNs/edit?usp=sharing");
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void f381_thay_doi_he_so_chat_luong_de_KeyDown(object sender, KeyEventArgs e)
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

    }
}
