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
    public partial class F425_Bao_cao_nhan_su_tong_hop : Form
    {
        public F425_Bao_cao_nhan_su_tong_hop()
        {
            InitializeComponent();
        }

        private void F425_Bao_cao_nhan_su_tong_hop_Load(object sender, EventArgs e)
        {
            load_data_2_pv();
        }

        private void load_data_2_pv()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            throw new Exception("Sua lai khong dung FillDataSetWithTableName nua nhe");
            //v_us.FillDatasetWithTableName(v_ds, "V_DM_NHAN_VIEN_TONG_HOP");

            m_pv.DataSource = v_ds.Tables[0];
        }
    }
}
