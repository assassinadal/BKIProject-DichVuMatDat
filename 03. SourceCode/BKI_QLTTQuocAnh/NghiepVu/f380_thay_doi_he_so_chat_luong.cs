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


namespace BKI_DichVuMatDat.NghiepVu
{
    public partial class f380_thay_doi_he_so_chat_luong : Form
    {
        public f380_thay_doi_he_so_chat_luong()
        {
            InitializeComponent();
            format_controls();
        }

        #region Public Interface
        public void display()
        {
            this.ShowDialog();
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

        private void set_initial_form_load()
        {
            m_txt_chon_thang.Text = DateTime.Now.Month.ToString();
            m_txt_chon_nam.Text = DateTime.Now.Year.ToString();
        }
        #endregion

        private void set_define_events()
        {
            this.Load += f380_thay_doi_he_so_chat_luong_Load;
            //cmd
            m_cmd_chon_file.Click += m_cmd_chon_file_Click;
        }

        void f380_thay_doi_he_so_chat_luong_Load(object sender, EventArgs e)
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

        void m_cmd_chon_file_Click(object sender, EventArgs e)
        {
            try
            {
                string v_str_path = "";
                f381_thay_doi_he_so_chat_luong_de v_frm_de = new f381_thay_doi_he_so_chat_luong_de();
                v_frm_de.display(ref v_str_path);
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

    }
}
