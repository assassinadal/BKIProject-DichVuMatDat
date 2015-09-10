using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BKI_DichVuMatDat.BaoCao
{
    public partial class F420_Bao_cao_nhan_su_theo_don_vi : Form
    {
        public F420_Bao_cao_nhan_su_theo_don_vi()
        {
            InitializeComponent();
        }

        private void F420_Bao_cao_nhan_su_theo_don_vi_Load(object sender, EventArgs e)
        {
            load_data_2_pv();
        }

        private void load_data_2_pv()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithTableName(v_ds, "V_NHAN_VIEN_DON_VI");

            m_pv.DataSource = v_ds.Tables[0];
        }
    }
}
