using IP.Core.IPCommon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BKI_DichVuMatDat.DanhMuc
{
    public partial class F109_dm_thue : Form
    {
        public F109_dm_thue()
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
        DataEntryFormMode m_e_form_mode = DataEntryFormMode.InsertDataState;
        #endregion

        #region Private Methods
        private void format_controls()
        {
            set_define_events();
            this.KeyPreview = true;
        }

        private void set_initial_form_load()
        {
            load_data_2_grid();
        }

        private void load_data_2_grid()
        {
            CCommon.make_stt(m_grv_dm_thue);
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());

            v_us.FillDatasetWithTableName(v_ds, "V_DM_THUE");
            m_grc_dm_thue.DataSource = v_ds.Tables[0];
        }
        #endregion
        private void set_define_events()
        {
            this.Load += F109_dm_thue_Load;
            m_cmd_insert.Click += m_cmd_insert_Click;
        }

        private void F109_dm_thue_Load(object sender, EventArgs e)
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

        void m_cmd_insert_Click(object sender, EventArgs e)
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
