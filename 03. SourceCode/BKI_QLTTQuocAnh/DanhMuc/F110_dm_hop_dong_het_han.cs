using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BKI_DichVuMatDat.DanhMuc
{
    public partial class F110_dm_hop_dong_het_han : Form
    {
        public F110_dm_hop_dong_het_han()
        {
            InitializeComponent();
        }

        internal void display_for_show(DataSet dataSet)
        {
            m_grc_hop_dong_het_han.DataSource = dataSet.Tables[0];
            this.ShowDialog();
        }
    }
}
