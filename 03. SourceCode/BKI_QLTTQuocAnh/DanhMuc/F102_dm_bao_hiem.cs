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

namespace BKI_DichVuMatDat.DanhMuc
{
    public partial class F102_dm_bao_hiem : Form
    {
        public F102_dm_bao_hiem()
        {
            InitializeComponent();
        }

        #region Public Interface
        private void display()
        {
            this.ShowDialog();
        }
        #endregion

        #region Members
        DataEntryFormMode m_e_form_mode = DataEntryFormMode.InsertDataState;
        #endregion
        #region private methods
        private void format_controls()
        {
            set_define_events();
            this.KeyPreview = true;
        }
        private void set_initial_form_load()
        {
            load_data_2_grid();
        }
        private void F102_dm_bao_hiem_Load(object sender, EventArgs e)
        {
            load_data_2_grid();
        }
       
        private void load_data_2_grid()
        {
            CCommon.make_stt(m_grv_dm_bao_hiem);
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();

            v_ds.Tables.Add(new DataTable());
            v_us.fillDatasetWithTableName(v_ds, "DM_BAO_HIEM");
            m_grc_dm_bao_hiem.DataSource = v_ds.Tables[0];

        }
          #endregion
        private void set_define_events()
        {
            this.Load += F105_dm_bao_hiem_Load;
        }

        void F105_dm_bao_hiem_Load(object sender, EventArgs e)
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
