using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BKI_DichVuMatDat.EF;
using IP.Core.IPCommon;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using DevExpress.XtraCharts;
using DevExpress.XtraCharts.Printing;
namespace BKI_DichVuMatDat.BaoCao
{
    public partial class f440_rpt_luong : Form
    {
        #region Public Interface
        public f440_rpt_luong()
        {
            InitializeComponent();
            format_control();
            setDefineEvent();
        }


        #endregion
        
        #region Member
        private BindingList<V_RPT_LUONG> getDataSource()
        {
            using (var context = new BKI_DVMDEntities())
            {
                return new BindingList<V_RPT_LUONG>(context.V_RPT_LUONG.ToList());
            }
        }
        private void fillDataPivotGrid(BindingList<V_RPT_LUONG> ipList)
        {
            pivotGridControl1.DataSource = ipList;
        }

        #endregion

        #region Private Method
        private void format_control()
        {

        }
        private void setInitFormLoad()
        {
            fillDataPivotGrid(getDataSource());
            pivotGridControl1.Cells.Selection = new Rectangle(0, 0, Width, pivotGridControl1.Cells.RowCount);
        }
        #endregion

        #region Event Handle
        private void setDefineEvent()
        {
            this.Load += f440_rpt_luong_Load;
            pivotGridControl1.CellDoubleClick += pivotGridControl1_CellDoubleClick;
            m_cmd_xuat_pdf.Click += m_cmd_xuat_pdf_Click;
        }

        void m_cmd_xuat_pdf_Click(object sender, EventArgs e)
        {
            try
            {
                // Check whether the ChartControl can be previewed.
                if (!chartControl1.IsPrintingAvailable)
                {
                    CHRM_BaseMessages.MsgBox_Error("The 'DevExpress.XtraPrinting' is not found");
                    return;
                }
                // Open the Preview window.
                PrintableComponentLink link = new PrintableComponentLink(new PrintingSystem());

                link.Component = chartControl1;
                chartControl1.OptionsPrint.SizeMode = PrintSizeMode.Stretch;
                //chartControl1.Legend.MaxVerticalPercentage = 100;
                link.Landscape = true;
                link.PaperKind = System.Drawing.Printing.PaperKind.A4;
                link.ShowPreview();
                // Specify the paper kind and page orientation.
                //chartControl1.Legend.MaxVerticalPercentage = 100;
                //chartControl1.Legend.Direction = DevExpress.XtraCharts.LegendDirection.TopToBottom;
                //chartControl1.ShowPrintPreview(DevExpress.XtraCharts.Printing.PrintSizeMode.Zoom);
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        void pivotGridControl1_CellDoubleClick(object sender, DevExpress.XtraPivotGrid.PivotCellEventArgs e)
        {
            try
            {
                f441_thuc_linh_de frm = new f441_thuc_linh_de();
                frm.fillDataSource(e.CreateDrillDownDataSource());
                frm.ShowDialog();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void f440_rpt_luong_Load(object sender, EventArgs e)
        {
            try
            {
                setInitFormLoad();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }



        #endregion
    }
}
