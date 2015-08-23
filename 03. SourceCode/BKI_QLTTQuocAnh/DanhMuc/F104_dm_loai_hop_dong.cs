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
    public partial class F104_dm_loai_hop_dong : Form
    {
        public F104_dm_loai_hop_dong()
        {
            InitializeComponent();
        }

        private void F104_dm_loai_hop_dong_Load(object sender, EventArgs e)
        {
            load_data_2_grid();
        }

        private void load_data_2_grid()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());

            v_us.FillDatasetWithTableName(v_ds, "V_DM_LOAI_HOP_DONG");
            m_grc_dm_loai_hop_dong.DataSource = v_ds.Tables[0];
        }
    }
}
