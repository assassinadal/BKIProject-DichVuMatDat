using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BKI_DichVuMatDat.XtraReport
{
    public static class ReportHelper
    {
        private static WinControlContainer CopyGridControl(GridControl grid)
        {
            WinControlContainer winContainer = new WinControlContainer();

            winContainer.Location = new Point(0, 0);
            winContainer.Size = new Size(200, 100);

            winContainer.WinControl = grid;
            return winContainer;
        }
        public static void ExportXLS(GridControl grid, string tenBaoCao, string FileName)
        {
            #region Thiết kế trước khi in
            if(grid != null)
            {
                GridView view = grid.MainView as GridView;

                if(view != null)
                {
                    //view.AppearancePrint.EvenRow.Font = new System.Drawing.Font("Times New Roman", 11F);
                    //view.AppearancePrint.EvenRow.Options.UseFont = true;
                    //view.AppearancePrint.FilterPanel.Font = new System.Drawing.Font("Times New Roman", 11F);
                    //view.AppearancePrint.FilterPanel.Options.UseFont = true;
                    //view.AppearancePrint.FooterPanel.BorderColor = System.Drawing.Color.Black;
                    //view.AppearancePrint.FooterPanel.Font = new System.Drawing.Font("Times New Roman", 11F);
                    //view.AppearancePrint.FooterPanel.Options.UseBorderColor = true;
                    //view.AppearancePrint.FooterPanel.Options.UseFont = true;
                    //view.AppearancePrint.GroupFooter.BorderColor = System.Drawing.Color.Black;
                    //view.AppearancePrint.GroupFooter.Font = new System.Drawing.Font("Times New Roman", 11F);
                    //view.AppearancePrint.GroupFooter.Options.UseBorderColor = true;
                    //view.AppearancePrint.GroupFooter.Options.UseFont = true;
                    //view.AppearancePrint.GroupRow.BorderColor = System.Drawing.Color.Black;
                    //view.AppearancePrint.GroupRow.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
                    //view.AppearancePrint.GroupRow.Options.UseBorderColor = true;
                    //view.AppearancePrint.GroupRow.Options.UseFont = true;
                    //view.AppearancePrint.HeaderPanel.BorderColor = System.Drawing.Color.Black;
                    //view.AppearancePrint.HeaderPanel.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
                    //view.AppearancePrint.HeaderPanel.Options.UseBorderColor = true;
                    //view.AppearancePrint.HeaderPanel.Options.UseFont = true;
                    //view.AppearancePrint.HeaderPanel.Options.UseTextOptions = true;
                    //view.AppearancePrint.HeaderPanel.Options.UseBackColor = true;
                    //view.AppearancePrint.HeaderPanel.BackColor = Color.FromArgb(192, 255, 255);
                    //view.AppearancePrint.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                    //view.AppearancePrint.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
                    //view.AppearancePrint.Lines.BackColor = System.Drawing.Color.Black;
                    //view.AppearancePrint.Lines.Font = new System.Drawing.Font("Times New Roman", 11F);
                    //view.AppearancePrint.Lines.Options.UseBackColor = true;
                    //view.AppearancePrint.Lines.Options.UseFont = true;
                    //view.AppearancePrint.OddRow.Font = new System.Drawing.Font("Times New Roman", 11F);
                    //view.AppearancePrint.OddRow.Options.UseFont = true;
                    //view.AppearancePrint.Preview.Font = new System.Drawing.Font("Times New Roman", 11F);
                    //view.AppearancePrint.Preview.Options.UseFont = true;
                    //view.AppearancePrint.Row.BorderColor = System.Drawing.Color.Black;
                    //view.AppearancePrint.Row.Font = new System.Drawing.Font("Times New Roman", 11F);
                    //view.AppearancePrint.Row.Options.UseBorderColor = true;
                    //view.AppearancePrint.Row.Options.UseFont = true;

                    //view.AppearancePrint.EvenRow.BackColor = Color.MintCream;
                    //view.OptionsPrint.EnableAppearanceEvenRow = true;
                }
            }
            #endregion

            var r = new rptCommon();
            r.m_lbl_ten_bao_cao.Text = tenBaoCao.ToUpper();

            //r.PaperKind = System.Drawing.Printing.PaperKind.A4;
            //r.Landscape = true;
            //r.TenCoSo = "Khách sạn Sao Mai"; // tu tu tính
            //r.DiaChi = "384 Nguyễn Văn Linh, Dư Hàng Kênh – Lê Chân – Hải Phòng"; // tu tu tinh


            r.Bands[BandKind.Detail].Controls.Add(CopyGridControl(grid));
            
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "xls files (*.xls)|*.xls|All files (*.*)|*.*";
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.FileName = FileName;
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                XlsExportOptions opt = new XlsExportOptions();
                opt.TextExportMode = TextExportMode.Value;
                r.ExportToXls(saveFileDialog1.FileName, opt);
                XtraMessageBox.Show("Xuất báo cáo thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
