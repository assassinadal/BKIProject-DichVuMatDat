namespace BKI_DichVuMatDat.BaoCao
{
    partial class f441_thuc_linh_de
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MA_NV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HO_DEM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.THANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NAM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.THUC_LINH_CUOI_CUNG = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(677, 433);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MA_NV,
            this.HO_DEM,
            this.TEN,
            this.THANG,
            this.NAM,
            this.THUC_LINH_CUOI_CUNG});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // MA_NV
            // 
            this.MA_NV.Caption = "Mã nhân viên";
            this.MA_NV.FieldName = "MA_NV";
            this.MA_NV.Name = "MA_NV";
            this.MA_NV.OptionsColumn.AllowEdit = false;
            this.MA_NV.OptionsColumn.ReadOnly = true;
            this.MA_NV.Visible = true;
            this.MA_NV.VisibleIndex = 0;
            // 
            // HO_DEM
            // 
            this.HO_DEM.Caption = "Họ đệm";
            this.HO_DEM.FieldName = "HO_DEM";
            this.HO_DEM.Name = "HO_DEM";
            this.HO_DEM.OptionsColumn.AllowEdit = false;
            this.HO_DEM.OptionsColumn.ReadOnly = true;
            this.HO_DEM.Visible = true;
            this.HO_DEM.VisibleIndex = 1;
            // 
            // TEN
            // 
            this.TEN.Caption = "TEN";
            this.TEN.FieldName = "TEN";
            this.TEN.Name = "TEN";
            this.TEN.OptionsColumn.AllowEdit = false;
            this.TEN.OptionsColumn.ReadOnly = true;
            this.TEN.Visible = true;
            this.TEN.VisibleIndex = 2;
            // 
            // THANG
            // 
            this.THANG.Caption = "Tháng";
            this.THANG.FieldName = "THANG";
            this.THANG.Name = "THANG";
            this.THANG.OptionsColumn.AllowEdit = false;
            this.THANG.OptionsColumn.ReadOnly = true;
            this.THANG.Visible = true;
            this.THANG.VisibleIndex = 3;
            // 
            // NAM
            // 
            this.NAM.Caption = "Năm";
            this.NAM.FieldName = "NAM";
            this.NAM.Name = "NAM";
            this.NAM.OptionsColumn.AllowEdit = false;
            this.NAM.OptionsColumn.ReadOnly = true;
            this.NAM.Visible = true;
            this.NAM.VisibleIndex = 4;
            // 
            // THUC_LINH_CUOI_CUNG
            // 
            this.THUC_LINH_CUOI_CUNG.Caption = "Thực lĩnh cuối cùng";
            this.THUC_LINH_CUOI_CUNG.FieldName = "THUC_LINH_CUOI_CUNG";
            this.THUC_LINH_CUOI_CUNG.Name = "THUC_LINH_CUOI_CUNG";
            this.THUC_LINH_CUOI_CUNG.OptionsColumn.AllowEdit = false;
            this.THUC_LINH_CUOI_CUNG.OptionsColumn.ReadOnly = true;
            this.THUC_LINH_CUOI_CUNG.Visible = true;
            this.THUC_LINH_CUOI_CUNG.VisibleIndex = 5;
            // 
            // f441_thuc_linh_de
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 433);
            this.Controls.Add(this.gridControl1);
            this.Name = "f441_thuc_linh_de";
            this.Text = "F441 - Thực lĩnh nhân viên";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MA_NV;
        private DevExpress.XtraGrid.Columns.GridColumn HO_DEM;
        private DevExpress.XtraGrid.Columns.GridColumn TEN;
        private DevExpress.XtraGrid.Columns.GridColumn THANG;
        private DevExpress.XtraGrid.Columns.GridColumn NAM;
        private DevExpress.XtraGrid.Columns.GridColumn THUC_LINH_CUOI_CUNG;
    }
}