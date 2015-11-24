using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IP.Core.IPCommon;
using DevExpress.XtraCharts;

namespace BKI_DichVuMatDat.BaoCao
{
    public partial class f435_bao_cao_lao_dong_nuoc_ngoai : Form
    {
        DataSet m_ds = new DataSet();
        public f435_bao_cao_lao_dong_nuoc_ngoai()
        {
            InitializeComponent();
        }

        private void f435_bao_cao_lao_dong_nuoc_ngoai_Load(object sender, EventArgs e)
        {           
            load_data_to_grid();
            load_data_to_chart();
        }

        private void load_data_to_chart()
        {
            m_chart.DataSource = m_ds.Tables[0];
            m_chart.SeriesDataMember = "QUOC_TICH";
            m_chart.SeriesTemplate.ArgumentDataMember = "QUOC_TICH";
            m_chart.SeriesTemplate.ValueDataMembers.AddRange(new string[] { "ID" });
            m_chart.SeriesTemplate.SummaryFunction = "COUNT()";
            //m_webchartcontrol.SeriesTemplate.View = new SideBySideBarSeriesView();
            var v_ssv = new PieSeriesView() ;
            //v_ssv.LineStyle.DashStyle = DashStyle.Solid;
            //v_ssv.MarkerVisibility = DevExpress.Utils.DefaultBoolean.False;
            m_chart.SeriesTemplate.View = v_ssv;
            
        }


        private void load_data_to_grid()
        {
           
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            m_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithTableName(m_ds, "V_DM_LAO_DONG_NUOC_NGOAI");
            m_grc.DataSource = m_ds.Tables[0];          
        }

      
    }
}
