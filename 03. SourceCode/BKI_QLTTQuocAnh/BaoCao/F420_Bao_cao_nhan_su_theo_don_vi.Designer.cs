namespace BKI_DichVuMatDat.BaoCao
{
    partial class F420_Bao_cao_nhan_su_theo_don_vi
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
            DevExpress.XtraCharts.SimpleDiagram3D simpleDiagram3D2 = new DevExpress.XtraCharts.SimpleDiagram3D();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.Pie3DSeriesView pie3DSeriesView3 = new DevExpress.XtraCharts.Pie3DSeriesView();
            DevExpress.XtraCharts.Pie3DSeriesLabel pie3DSeriesLabel2 = new DevExpress.XtraCharts.Pie3DSeriesLabel();
            DevExpress.XtraCharts.Pie3DSeriesView pie3DSeriesView4 = new DevExpress.XtraCharts.Pie3DSeriesView();
            DevExpress.XtraCharts.SeriesTitle seriesTitle2 = new DevExpress.XtraCharts.SeriesTitle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.m_pv = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.m_ch = new DevExpress.XtraCharts.ChartControl();
            this.dv_dh = new DevExpress.XtraPivotGrid.PivotGridField();
            this.dv_phong = new DevExpress.XtraPivotGrid.PivotGridField();
            this.dv_to = new DevExpress.XtraPivotGrid.PivotGridField();
            this.c_data_sl_nv = new DevExpress.XtraPivotGrid.PivotGridField();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_pv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_ch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram3D2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesView4)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.m_pv, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.m_ch, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(905, 402);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // m_pv
            // 
            this.m_pv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_pv.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.dv_dh,
            this.dv_phong,
            this.dv_to,
            this.c_data_sl_nv});
            this.m_pv.Location = new System.Drawing.Point(3, 3);
            this.m_pv.Name = "m_pv";
            this.m_pv.Size = new System.Drawing.Size(446, 396);
            this.m_pv.TabIndex = 0;
            // 
            // m_ch
            // 
            this.m_ch.AutoBindingSettingsEnabled = false;
            this.m_ch.DataSource = this.m_pv;
            simpleDiagram3D2.Dimension = 1;
            simpleDiagram3D2.RotationMatrixSerializable = "1;0;0;0;0;0.5;-0.866025403784439;0;0;0.866025403784439;0.5;0;0;0;0;1";
            this.m_ch.Diagram = simpleDiagram3D2;
            this.m_ch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_ch.Legend.MaxHorizontalPercentage = 30D;
            this.m_ch.Location = new System.Drawing.Point(455, 3);
            this.m_ch.Name = "m_ch";
            this.m_ch.SeriesDataMember = "Series";
            series2.Name = "Series 1";
            pie3DSeriesView3.SizeAsPercentage = 100D;
            pie3DSeriesView3.SweepDirection = DevExpress.XtraCharts.PieSweepDirection.Counterclockwise;
            series2.View = pie3DSeriesView3;
            series2.Visible = false;
            this.m_ch.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series2};
            this.m_ch.SeriesTemplate.ArgumentDataMember = "Arguments";
            this.m_ch.SeriesTemplate.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative;
            pie3DSeriesLabel2.Position = DevExpress.XtraCharts.PieSeriesLabelPosition.TwoColumns;
            this.m_ch.SeriesTemplate.Label = pie3DSeriesLabel2;
            this.m_ch.SeriesTemplate.LegendTextPattern = "{A}";
            this.m_ch.SeriesTemplate.ValueDataMembersSerializable = "Values";
            pie3DSeriesView4.SizeAsPercentage = 100D;
            pie3DSeriesView4.SweepDirection = DevExpress.XtraCharts.PieSweepDirection.Counterclockwise;
            pie3DSeriesView4.Titles.AddRange(new DevExpress.XtraCharts.SeriesTitle[] {
            seriesTitle2});
            this.m_ch.SeriesTemplate.View = pie3DSeriesView4;
            this.m_ch.Size = new System.Drawing.Size(447, 396);
            this.m_ch.TabIndex = 1;
            // 
            // dv_dh
            // 
            this.dv_dh.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.dv_dh.AreaIndex = 0;
            this.dv_dh.Caption = "Điều hành";
            this.dv_dh.FieldName = "TEN_DON_VI_3";
            this.dv_dh.Name = "dv_dh";
            // 
            // dv_phong
            // 
            this.dv_phong.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.dv_phong.AreaIndex = 1;
            this.dv_phong.Caption = "Phòng";
            this.dv_phong.FieldName = "TEN_DON_VI_2";
            this.dv_phong.Name = "dv_phong";
            // 
            // dv_to
            // 
            this.dv_to.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.dv_to.AreaIndex = 2;
            this.dv_to.Caption = "Tổ";
            this.dv_to.FieldName = "TEN_DON_VI";
            this.dv_to.Name = "dv_to";
            // 
            // c_data_sl_nv
            // 
            this.c_data_sl_nv.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.c_data_sl_nv.AreaIndex = 0;
            this.c_data_sl_nv.Caption = "Số lượng nhân viên";
            this.c_data_sl_nv.FieldName = "ID";
            this.c_data_sl_nv.Name = "c_data_sl_nv";
            this.c_data_sl_nv.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Count;
            // 
            // F420_Bao_cao_nhan_su_theo_don_vi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 402);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "F420_Bao_cao_nhan_su_theo_don_vi";
            this.Text = "F420 Báo cáo nhân sự theo đơn vị";
            this.Load += new System.EventHandler(this.F420_Bao_cao_nhan_su_theo_don_vi_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_pv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram3D2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_ch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraPivotGrid.PivotGridControl m_pv;
        private DevExpress.XtraCharts.ChartControl m_ch;
        private DevExpress.XtraPivotGrid.PivotGridField dv_dh;
        private DevExpress.XtraPivotGrid.PivotGridField dv_phong;
        private DevExpress.XtraPivotGrid.PivotGridField dv_to;
        private DevExpress.XtraPivotGrid.PivotGridField c_data_sl_nv;
    }
}