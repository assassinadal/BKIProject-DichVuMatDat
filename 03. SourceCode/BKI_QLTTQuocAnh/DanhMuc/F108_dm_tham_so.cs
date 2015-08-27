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
    public partial class F108_dm_tham_so : Form
    {
        public F108_dm_tham_so()
        {
            InitializeComponent();
        }

        private void f101_dm_tham_so_Load(object sender, EventArgs e)
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithTableName(v_ds, "DM_THAM_SO");
            m_grc_tham_so.DataSource = v_ds.Tables[0];
        }

       
    }
}
