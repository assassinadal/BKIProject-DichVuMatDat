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
    public partial class F102_dm_bao_hiem : Form
    {
        public F102_dm_bao_hiem()
        {
            InitializeComponent();
        }

        private void F102_DM_BAO_HIEM_Load(object sender, EventArgs e)
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
    }
}
