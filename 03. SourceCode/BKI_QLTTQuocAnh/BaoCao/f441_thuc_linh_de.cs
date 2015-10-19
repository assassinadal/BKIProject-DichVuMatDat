using BKI_DichVuMatDat.EF;
using DevExpress.XtraPivotGrid;
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
    public partial class f441_thuc_linh_de : Form
    {
        public f441_thuc_linh_de()
        {
            InitializeComponent();
        }
        public void fillDataSource(PivotDrillDownDataSource ipSource)
        {
            gridControl1.DataSource = ipSource;
            gridControl1.RefreshDataSource();
        }
    }
}
