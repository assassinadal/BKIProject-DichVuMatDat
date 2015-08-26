﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BKI_DichVuMatDat.DanhMuc
{
    public partial class F106_dm_luong_che_do : Form
    {
        public F106_dm_luong_che_do()
        {
            InitializeComponent();
        }

        private void F106_dm_luong_che_do_load(object sender, EventArgs e)
        {
            load_data_2_grid();
        }

        private void load_data_2_grid()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());

            v_us.FillDatasetWithTableName(v_ds, "V_DM_LUONG_CHE_DO");
            m_grc_dm_luong_che_do.DataSource = v_ds.Tables[0];
        }

    }
}
