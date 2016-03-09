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
using BKI_DichVuMatDat.US;
using BKI_DichVuMatDat.DS;
using BKI_DichVuMatDat.DS.CDBNames;

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
            m_chart.SeriesDataMember = "GIOI_TINH";
            m_chart.SeriesTemplate.ArgumentDataMember = "QUOC_TICH";
            m_chart.SeriesTemplate.SummaryFunction = "COUNT()";

            

            var v_ssv = new PieSeriesView() ;
            
            m_chart.SeriesTemplate.View = v_ssv;
            foreach (Series item in m_chart.Series)
            {
                item.ShowInLegend = true;
                item.LegendText = item.Name;
                item.LegendTextPattern = "{S} - {A} : {VP:0.##%} ({V} Lao động)";
                item.Label.TextPattern = "{A}";
                SeriesTitle st = new SeriesTitle();
                st.Text = item.Name;
                st.Dock = ChartTitleDockStyle.Bottom;
                ((PieSeriesView)item.View).Titles.Add(st);
            }
        }


        private void load_data_to_grid()
        {

            //US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            //m_ds.Tables.Add(new DataTable());
            //throw new Exception("Sua lai khong dung FillDataSetWithTableName nua nhe");
            //v_us.FillDatasetWithTableName(m_ds, "V_DM_LAO_DONG_NUOC_NGOAI");
            US_V_DM_LAO_DONG_NUOC_NGOAI v_us = new US_V_DM_LAO_DONG_NUOC_NGOAI();
            DS_V_DM_LAO_DONG_NUOC_NGOAI v_ds = new DS_V_DM_LAO_DONG_NUOC_NGOAI();
            v_us.FillDataset(v_ds);
            m_grc.DataSource = v_ds.Tables[0];          
        }

      
    }
}
