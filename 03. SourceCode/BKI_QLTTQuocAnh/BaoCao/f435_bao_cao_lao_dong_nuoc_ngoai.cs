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
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrintingLinks;

namespace BKI_DichVuMatDat.BaoCao
{
    public partial class f435_bao_cao_lao_dong_nuoc_ngoai : Form
    {
        #region Public Interfaces
        public f435_bao_cao_lao_dong_nuoc_ngoai()
        {
            InitializeComponent();
        }
        #endregion

        #region Members
        int so_lao_dong = 0;
        int summaryColumnID = -1;
        DS_V_DM_LAO_DONG_NUOC_NGOAI m_ds = new DS_V_DM_LAO_DONG_NUOC_NGOAI();
        CompositeLink compositeLink = new DevExpress.XtraPrintingLinks.CompositeLink();
        #endregion

        #region Data Structures
        #endregion

        #region Private Methods
        private void load_data_to_chart()
        {
            m_chart.DataSource = m_ds.Tables[0];
            m_chart.SeriesDataMember = "GIOI_TINH";
            m_chart.SeriesTemplate.ArgumentDataMember = "QUOC_TICH";
            m_chart.SeriesTemplate.SummaryFunction = "COUNT()";

            var v_ssv = new PieSeriesView();
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
            US_V_DM_LAO_DONG_NUOC_NGOAI v_us = new US_V_DM_LAO_DONG_NUOC_NGOAI();
            v_us.FillDataset(m_ds);
            m_grc.DataSource = m_ds.Tables[0];       
        }

        private void set_init_form_load()
        {
            load_data_to_grid();
            load_data_to_chart();
            set_define_event();
            gridView1.BestFitColumns();
        }
        #endregion

        private void set_define_event()
        {
            m_cmd_xuat_bao_cao.Click += m_cmd_xuat_bao_cao_Click;
            compositeLink.CreateDetailHeaderArea += them_tieu_de;
        }
        //
        //EVENT HANDLERS
        //
        private void f435_bao_cao_lao_dong_nuoc_ngoai_Load(object sender, EventArgs e)
        {
            try
            {
                set_init_form_load();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
          
        }

        private void m_cmd_xuat_bao_cao_Click(object sender, EventArgs e)
        {
            try
            {
                PrintingSystem ps = new PrintingSystem();
                compositeLink.PrintingSystem = ps;
                //
                PrintableComponentLink link1 = new PrintableComponentLink();
                PrintableComponentLink link2 = new PrintableComponentLink();
                link2.Component = m_grc;
                link1.Component = m_chart;
                //
                compositeLink.Links.Add(link1);
                compositeLink.Links.Add(link2);
                compositeLink.PaperKind = System.Drawing.Printing.PaperKind.A3Rotated;
                compositeLink.BreakSpace = 40;
                //
                compositeLink.Landscape = false;

                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "xls files (*.xls)|*.xls|All files (*.*)|*.*";
                saveFileDialog1.RestoreDirectory = true;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    compositeLink.ExportToXls(saveFileDialog1.FileName);
                    DevExpress.XtraEditors.XtraMessageBox.Show("Lưu báo cáo thành công!");
                }
                compositeLink.ShowPreview();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void them_tieu_de(object sender, CreateAreaEventArgs e)
        {
            try
            {
                string reportHeader = "THỐNG KÊ LAO ĐỘNG NƯỚC NGOÀI " + DateTime.Now.Date.ToShortDateString();
                e.Graph.StringFormat = new BrickStringFormat(StringAlignment.Center);
                e.Graph.Font = new Font("Tahoma", 20, FontStyle.Bold);
                RectangleF rec = new RectangleF(0, 0, e.Graph.ClientPageSize.Width, 50);
                e.Graph.DrawString(reportHeader, Color.Maroon, rec, BorderSide.None);
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
           
        }

        private void gridView1_CustomSummaryCalculate(object sender, DevExpress.Data.CustomSummaryEventArgs e)
        {
            try
            {
                GridView view = sender as GridView;
                summaryColumnID = Convert.ToInt16((e.Item as GridGroupSummaryItem).Tag);

                if (e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Start)
                {
                    so_lao_dong = 0;
                }
                if (e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Calculate)
                {
                    switch (summaryColumnID)
                    {
                        case 1:
                            so_lao_dong++;
                            break;
                    }
                }
                if (e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Finalize)
                {
                    switch (summaryColumnID)
                    {
                        case 1:
                            e.TotalValue = so_lao_dong;
                            break;
                    }
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
           
        }

    }
}


