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
    public partial class F107_dm_phu_cap : Form
    {
        public F107_dm_phu_cap()
        {
            InitializeComponent();
        }

        private void F107_dm_phu_cap_Load(object sender, EventArgs e)
        {
            load_data_2_grid();
        }

        private void load_data_2_grid()
        {
            CCommon.make_stt(m_grv_dm_phu_cap);
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());

            v_us.FillDatasetWithTableName(v_ds, "V_DM_PHU_CAP");
            m_grc_dm_phu_cap.DataSource = v_ds.Tables[0];
        }

    }
}
