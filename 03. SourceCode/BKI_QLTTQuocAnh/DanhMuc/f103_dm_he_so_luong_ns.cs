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
    public partial class F103_dm_he_so_luong_ns : Form
    {
        public F103_dm_he_so_luong_ns()
        {
            InitializeComponent();
        }

        private void F103_dm_he_so_luong_ns_load(object sender, EventArgs e)
        {
            load_data_2_grid();
        }

        private void load_data_2_grid() 
        {
            CCommon.make_stt(m_grv_dm_he_so_luong_ns);
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());

            v_us.FillDatasetWithTableName(v_ds, "V_DM_HE_SO_LUONG_NS");
            m_grc_dm_he_so_luong_ns.DataSource = v_ds.Tables[0];
        }

       

    }
}
