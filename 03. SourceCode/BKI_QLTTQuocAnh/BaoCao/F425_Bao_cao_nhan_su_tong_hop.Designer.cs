namespace BKI_DichVuMatDat.BaoCao
{
    partial class F425_Bao_cao_nhan_su_tong_hop
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
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            this.m_pv = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.m_ch = new DevExpress.XtraCharts.ChartControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.r_loai_hop_dong = new DevExpress.XtraPivotGrid.PivotGridField();
            this.c_gioi_tinh = new DevExpress.XtraPivotGrid.PivotGridField();
            this.c_nam_sinh = new DevExpress.XtraPivotGrid.PivotGridField();
            this.c_trinh_do = new DevExpress.XtraPivotGrid.PivotGridField();
            this.d_so_luong = new DevExpress.XtraPivotGrid.PivotGridField();
            this.r_loai_lao_dong = new DevExpress.XtraPivotGrid.PivotGridField();
            ((System.ComponentModel.ISupportInitialize)(this.m_pv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_ch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_pv
            // 
            this.m_pv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_pv.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.r_loai_hop_dong,
            this.c_gioi_tinh,
            this.c_nam_sinh,
            this.c_trinh_do,
            this.d_so_luong,
            this.r_loai_lao_dong});
            this.m_pv.Location = new System.Drawing.Point(3, 3);
            this.m_pv.Name = "m_pv";
            this.m_pv.Size = new System.Drawing.Size(444, 391);
            this.m_pv.TabIndex = 0;
            // 
            // m_ch
            // 
            this.m_ch.DataSource = this.m_pv;
            xyDiagram1.AxisX.Title.Text = "Loại hợp đồng Loại lao động";
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.Title.Text = "Số lượng nhân viên";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.m_ch.Diagram = xyDiagram1;
            this.m_ch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_ch.Legend.MaxHorizontalPercentage = 30D;
            this.m_ch.Location = new System.Drawing.Point(453, 3);
            this.m_ch.Name = "m_ch";
            this.m_ch.SeriesDataMember = "Series";
            series1.Name = "Series 1";
            series2.Name = "Series 2";
            this.m_ch.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1,
        series2};
            this.m_ch.SeriesTemplate.ArgumentDataMember = "Arguments";
            this.m_ch.SeriesTemplate.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative;
            this.m_ch.SeriesTemplate.ValueDataMembersSerializable = "Values";
            this.m_ch.Size = new System.Drawing.Size(445, 391);
            this.m_ch.TabIndex = 1;
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(901, 397);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // r_loai_hop_dong
            // 
            this.r_loai_hop_dong.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.r_loai_hop_dong.AreaIndex = 0;
            this.r_loai_hop_dong.Caption = "Loại hợp đồng";
            this.r_loai_hop_dong.FieldName = "LOAI_HOP_DONG";
            this.r_loai_hop_dong.Name = "r_loai_hop_dong";
            // 
            // c_gioi_tinh
            // 
            this.c_gioi_tinh.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.c_gioi_tinh.AreaIndex = 0;
            this.c_gioi_tinh.Caption = "Giới tính";
            this.c_gioi_tinh.FieldName = "GIOI_TINH";
            this.c_gioi_tinh.Name = "c_gioi_tinh";
            // 
            // c_nam_sinh
            // 
            this.c_nam_sinh.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.c_nam_sinh.AreaIndex = 1;
            this.c_nam_sinh.Caption = "Năm sinh";
            this.c_nam_sinh.FieldName = "NGAY_SINH";
            this.c_nam_sinh.Name = "c_nam_sinh";
            // 
            // c_trinh_do
            // 
            this.c_trinh_do.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.c_trinh_do.AreaIndex = 2;
            this.c_trinh_do.Caption = "Trình độ";
            this.c_trinh_do.FieldName = "TRINH_DO_VAN_HOA";
            this.c_trinh_do.Name = "c_trinh_do";
            // 
            // d_so_luong
            // 
            this.d_so_luong.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.d_so_luong.AreaIndex = 0;
            this.d_so_luong.Caption = "Số lượng nhân viên";
            this.d_so_luong.FieldName = "ID";
            this.d_so_luong.Name = "d_so_luong";
            this.d_so_luong.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Count;
            // 
            // r_loai_lao_dong
            // 
            this.r_loai_lao_dong.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.r_loai_lao_dong.AreaIndex = 1;
            this.r_loai_lao_dong.Caption = "Loại lao động";
            this.r_loai_lao_dong.FieldName = "LOAI_LAO_DONG";
            this.r_loai_lao_dong.Name = "r_loai_lao_dong";
            // 
            // F425_Bao_cao_nhan_su_tong_hop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 397);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "F425_Bao_cao_nhan_su_tong_hop";
            this.Text = "F425_Bao_cao_nhan_su_tong_hop";
            this.Load += new System.EventHandler(this.F425_Bao_cao_nhan_su_tong_hop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.m_pv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_ch)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraPivotGrid.PivotGridControl m_pv;
        private DevExpress.XtraCharts.ChartControl m_ch;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraPivotGrid.PivotGridField r_loai_hop_dong;
        private DevExpress.XtraPivotGrid.PivotGridField c_gioi_tinh;
        private DevExpress.XtraPivotGrid.PivotGridField c_nam_sinh;
        private DevExpress.XtraPivotGrid.PivotGridField c_trinh_do;
        private DevExpress.XtraPivotGrid.PivotGridField d_so_luong;
        private DevExpress.XtraPivotGrid.PivotGridField r_loai_lao_dong;
    }
}