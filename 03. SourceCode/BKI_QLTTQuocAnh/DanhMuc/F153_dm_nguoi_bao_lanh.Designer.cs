namespace BKI_DichVuMatDat.DanhMuc
{
    partial class F153_dm_nguoi_bao_lanh
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.m_grc = new DevExpress.XtraGrid.GridControl();
            this.m_grv = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMA_NV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO_DEM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGUOI_BAO_LANH = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(703, 363);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(703, 363);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(683, 343);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // m_grc
            // 
            this.m_grc.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc.Location = new System.Drawing.Point(0, 0);
            this.m_grc.MainView = this.m_grv;
            this.m_grc.Name = "m_grc";
            this.m_grc.Size = new System.Drawing.Size(703, 363);
            this.m_grc.TabIndex = 1;
            this.m_grc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv});
            // 
            // m_grv
            // 
            this.m_grv.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colMA_NV,
            this.colHO_DEM,
            this.colTEN,
            this.colNGUOI_BAO_LANH});
            this.m_grv.GridControl = this.m_grc;
            this.m_grv.Name = "m_grv";
            this.m_grv.OptionsBehavior.ReadOnly = true;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colID.MaxWidth = 100;
            this.colID.MinWidth = 100;
            this.colID.Name = "colID";
            this.colID.Width = 72;
            // 
            // colMA_NV
            // 
            this.colMA_NV.Caption = "Mã nhân viên";
            this.colMA_NV.FieldName = "MA_NV";
            this.colMA_NV.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colMA_NV.MaxWidth = 100;
            this.colMA_NV.MinWidth = 100;
            this.colMA_NV.Name = "colMA_NV";
            this.colMA_NV.OptionsColumn.AllowEdit = false;
            this.colMA_NV.Visible = true;
            this.colMA_NV.VisibleIndex = 0;
            this.colMA_NV.Width = 100;
            // 
            // colHO_DEM
            // 
            this.colHO_DEM.Caption = "Họ đệm";
            this.colHO_DEM.FieldName = "HO_DEM";
            this.colHO_DEM.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colHO_DEM.MaxWidth = 100;
            this.colHO_DEM.MinWidth = 100;
            this.colHO_DEM.Name = "colHO_DEM";
            this.colHO_DEM.OptionsColumn.AllowEdit = false;
            this.colHO_DEM.Visible = true;
            this.colHO_DEM.VisibleIndex = 1;
            this.colHO_DEM.Width = 100;
            // 
            // colTEN
            // 
            this.colTEN.Caption = "Tên";
            this.colTEN.FieldName = "TEN";
            this.colTEN.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colTEN.MaxWidth = 100;
            this.colTEN.MinWidth = 100;
            this.colTEN.Name = "colTEN";
            this.colTEN.OptionsColumn.AllowEdit = false;
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            this.colTEN.Width = 100;
            // 
            // colNGUOI_BAO_LANH
            // 
            this.colNGUOI_BAO_LANH.Caption = "Người bảo lãnh";
            this.colNGUOI_BAO_LANH.FieldName = "NGUOI_BAO_LANH";
            this.colNGUOI_BAO_LANH.Name = "colNGUOI_BAO_LANH";
            this.colNGUOI_BAO_LANH.Visible = true;
            this.colNGUOI_BAO_LANH.VisibleIndex = 3;
            // 
            // F153_dm_nguoi_bao_lanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 363);
            this.Controls.Add(this.m_grc);
            this.Controls.Add(this.layoutControl1);
            this.Name = "F153_dm_nguoi_bao_lanh";
            this.Text = "F153- Nhân viên có người bảo lãnh";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraGrid.GridControl m_grc;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colMA_NV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO_DEM;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colNGUOI_BAO_LANH;
    }
}