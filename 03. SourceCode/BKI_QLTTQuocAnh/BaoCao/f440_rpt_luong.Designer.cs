namespace BKI_DichVuMatDat.BaoCao
{
    partial class f440_rpt_luong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraCharts.SimpleDiagram simpleDiagram1 = new DevExpress.XtraCharts.SimpleDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PieSeriesView pieSeriesView1 = new DevExpress.XtraCharts.PieSeriesView();
            DevExpress.XtraCharts.PieSeriesLabel pieSeriesLabel1 = new DevExpress.XtraCharts.PieSeriesLabel();
            DevExpress.XtraCharts.PieSeriesView pieSeriesView2 = new DevExpress.XtraCharts.PieSeriesView();
            DevExpress.XtraCharts.SeriesTitle seriesTitle1 = new DevExpress.XtraCharts.SeriesTitle();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.pivotGridField1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField2 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField3 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField4 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleSeparator1 = new DevExpress.XtraLayout.SimpleSeparator();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.m_cmd_xuat_pdf = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.simpleSeparator2 = new DevExpress.XtraLayout.SimpleSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator2)).BeginInit();
            this.SuspendLayout();
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.pivotGridField1,
            this.pivotGridField2,
            this.pivotGridField3,
            this.pivotGridField4});
            this.pivotGridControl1.Location = new System.Drawing.Point(12, 12);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.OptionsView.ShowFilterHeaders = false;
            this.pivotGridControl1.Size = new System.Drawing.Size(793, 210);
            this.pivotGridControl1.TabIndex = 0;
            // 
            // pivotGridField1
            // 
            this.pivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pivotGridField1.AreaIndex = 0;
            this.pivotGridField1.Caption = "NĂM";
            this.pivotGridField1.FieldName = "NAM";
            this.pivotGridField1.Name = "pivotGridField1";
            // 
            // pivotGridField2
            // 
            this.pivotGridField2.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.pivotGridField2.AreaIndex = 0;
            this.pivotGridField2.Caption = "TÊN ĐƠN VỊ";
            this.pivotGridField2.FieldName = "TEN_DON_VI";
            this.pivotGridField2.Name = "pivotGridField2";
            this.pivotGridField2.Width = 173;
            // 
            // pivotGridField3
            // 
            this.pivotGridField3.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pivotGridField3.AreaIndex = 1;
            this.pivotGridField3.Caption = "THÁNG";
            this.pivotGridField3.FieldName = "THANG";
            this.pivotGridField3.Name = "pivotGridField3";
            // 
            // pivotGridField4
            // 
            this.pivotGridField4.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.pivotGridField4.AreaIndex = 0;
            this.pivotGridField4.Caption = "THỰC LĨNH CUỐI CÙNG";
            this.pivotGridField4.CellFormat.FormatString = "n0";
            this.pivotGridField4.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.pivotGridField4.FieldName = "THUC_LINH_CUOI_CUNG";
            this.pivotGridField4.Name = "pivotGridField4";
            // 
            // chartControl1
            // 
            this.chartControl1.AutoBindingSettingsEnabled = false;
            this.chartControl1.AutoLayoutSettingsEnabled = false;
            this.chartControl1.DataSource = this.pivotGridControl1;
            simpleDiagram1.EqualPieSize = false;
            this.chartControl1.Diagram = simpleDiagram1;
            this.chartControl1.Legend.MaxHorizontalPercentage = 30D;
            this.chartControl1.Location = new System.Drawing.Point(12, 252);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.SeriesDataMember = "Series";
            series1.Name = "Series 1";
            pieSeriesView1.RuntimeExploding = false;
            pieSeriesView1.SweepDirection = DevExpress.XtraCharts.PieSweepDirection.Counterclockwise;
            series1.View = pieSeriesView1;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControl1.SeriesTemplate.ArgumentDataMember = "Arguments";
            this.chartControl1.SeriesTemplate.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative;
            pieSeriesLabel1.Position = DevExpress.XtraCharts.PieSeriesLabelPosition.TwoColumns;
            this.chartControl1.SeriesTemplate.Label = pieSeriesLabel1;
            this.chartControl1.SeriesTemplate.LegendTextPattern = "{A}";
            this.chartControl1.SeriesTemplate.ValueDataMembersSerializable = "Values";
            pieSeriesView2.RuntimeExploding = false;
            pieSeriesView2.SweepDirection = DevExpress.XtraCharts.PieSweepDirection.Counterclockwise;
            pieSeriesView2.Titles.AddRange(new DevExpress.XtraCharts.SeriesTitle[] {
            seriesTitle1});
            this.chartControl1.SeriesTemplate.View = pieSeriesView2;
            this.chartControl1.Size = new System.Drawing.Size(795, 228);
            this.chartControl1.TabIndex = 1;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.m_cmd_xuat_pdf);
            this.layoutControl1.Controls.Add(this.chartControl1);
            this.layoutControl1.Controls.Add(this.pivotGridControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(160, 268, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(819, 492);
            this.layoutControl1.TabIndex = 2;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.simpleSeparator1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.emptySpaceItem1,
            this.simpleSeparator2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(819, 492);
            this.layoutControlGroup1.Text = "Root";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.pivotGridControl1;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(797, 214);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // simpleSeparator1
            // 
            this.simpleSeparator1.AllowHotTrack = false;
            this.simpleSeparator1.CustomizationFormText = "simpleSeparator1";
            this.simpleSeparator1.Location = new System.Drawing.Point(797, 0);
            this.simpleSeparator1.Name = "simpleSeparator1";
            this.simpleSeparator1.Size = new System.Drawing.Size(2, 214);
            this.simpleSeparator1.Text = "simpleSeparator1";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.chartControl1;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 240);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(799, 232);
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // m_cmd_xuat_pdf
            // 
            this.m_cmd_xuat_pdf.Location = new System.Drawing.Point(12, 226);
            this.m_cmd_xuat_pdf.Name = "m_cmd_xuat_pdf";
            this.m_cmd_xuat_pdf.Size = new System.Drawing.Size(78, 22);
            this.m_cmd_xuat_pdf.StyleController = this.layoutControl1;
            this.m_cmd_xuat_pdf.TabIndex = 4;
            this.m_cmd_xuat_pdf.Text = "Xuất PDF";
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.m_cmd_xuat_pdf;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 214);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(82, 26);
            this.layoutControlItem3.Text = "layoutControlItem3";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextToControlDistance = 0;
            this.layoutControlItem3.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(84, 214);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(715, 26);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // simpleSeparator2
            // 
            this.simpleSeparator2.AllowHotTrack = false;
            this.simpleSeparator2.CustomizationFormText = "simpleSeparator2";
            this.simpleSeparator2.Location = new System.Drawing.Point(82, 214);
            this.simpleSeparator2.Name = "simpleSeparator2";
            this.simpleSeparator2.Size = new System.Drawing.Size(2, 26);
            this.simpleSeparator2.Text = "simpleSeparator2";
            // 
            // f440_rpt_luong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 492);
            this.Controls.Add(this.layoutControl1);
            this.Name = "f440_rpt_luong";
            this.Text = "F440 - BÁO CÁO LƯƠNG THEO ĐƠN VỊ";
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField1;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField2;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField3;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField4;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator1;
        private DevExpress.XtraEditors.SimpleButton m_cmd_xuat_pdf;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator2;
    }
}