using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BKI_DichVuMatDat.BaoCao
{
    public partial class f435_bao_cao_lao_dong_nuoc_ngoai : Form
    {
        public f435_bao_cao_lao_dong_nuoc_ngoai()
        {
            InitializeComponent();
        }

        private void f435_bao_cao_lao_dong_nuoc_ngoai_Load(object sender, EventArgs e)
        {
            load_data_to_grid();
        }

        private void load_data_to_grid()
        {
            DataSet v_ds = new DataSet();
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithTableName(v_ds, "V_DM_LAO_DONG_NUOC_NGOAI");
            m_grc.DataSource = v_ds.Tables[0];
        }
    }
}
