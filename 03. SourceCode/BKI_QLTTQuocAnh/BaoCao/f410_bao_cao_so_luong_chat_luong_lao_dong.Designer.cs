namespace BKI_DichVuMatDat.BaoCao
{
    partial class f410_bao_cao_so_luong_chat_luong_lao_dong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f410_bao_cao_so_luong_chat_luong_lao_dong));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.m_pgc_f410 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.pGFDON_VI = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pGFVI_TRI = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pGFMA_NV = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pGFHO_DEM = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pGFTEN = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pGFMA_LOAI_HOP_DONG = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pGFTRINH_DO_VAN_HOA = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pGFGIOI_TINH = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pGFTUOI_NHAN_VIEN = new DevExpress.XtraPivotGrid.PivotGridField();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.m_cmd_xuat_excel = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.pGFID_NHAN_VIEN = new DevExpress.XtraPivotGrid.PivotGridField();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_pgc_f410)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.m_pgc_f410);
            this.layoutControl1.Controls.Add(this.labelControl1);
            this.layoutControl1.Controls.Add(this.m_cmd_xuat_excel);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(336, 244, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1030, 442);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // m_pgc_f410
            // 
            this.m_pgc_f410.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.pGFDON_VI,
            this.pGFVI_TRI,
            this.pGFMA_NV,
            this.pGFHO_DEM,
            this.pGFTEN,
            this.pGFMA_LOAI_HOP_DONG,
            this.pGFTRINH_DO_VAN_HOA,
            this.pGFGIOI_TINH,
            this.pGFTUOI_NHAN_VIEN,
            this.pGFID_NHAN_VIEN});
            this.m_pgc_f410.Location = new System.Drawing.Point(12, 40);
            this.m_pgc_f410.Name = "m_pgc_f410";
            this.m_pgc_f410.Size = new System.Drawing.Size(1006, 348);
            this.m_pgc_f410.TabIndex = 9;
            // 
            // pGFDON_VI
            // 
            this.pGFDON_VI.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.pGFDON_VI.AreaIndex = 0;
            this.pGFDON_VI.Caption = "Tên đơn vị";
            this.pGFDON_VI.FieldName = "TEN_DON_VI";
            this.pGFDON_VI.Name = "pGFDON_VI";
            // 
            // pGFVI_TRI
            // 
            this.pGFVI_TRI.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.pGFVI_TRI.AreaIndex = 1;
            this.pGFVI_TRI.Caption = "Tên vị trí";
            this.pGFVI_TRI.FieldName = "TEN_VI_TRI";
            this.pGFVI_TRI.Name = "pGFVI_TRI";
            // 
            // pGFMA_NV
            // 
            this.pGFMA_NV.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.pGFMA_NV.AreaIndex = 0;
            this.pGFMA_NV.Caption = "Mã nhân viên";
            this.pGFMA_NV.FieldName = "MA_NV";
            this.pGFMA_NV.Name = "pGFMA_NV";
            this.pGFMA_NV.Visible = false;
            // 
            // pGFHO_DEM
            // 
            this.pGFHO_DEM.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.pGFHO_DEM.AreaIndex = 0;
            this.pGFHO_DEM.Caption = "Họ đệm";
            this.pGFHO_DEM.FieldName = "HO_DEM";
            this.pGFHO_DEM.Name = "pGFHO_DEM";
            this.pGFHO_DEM.Visible = false;
            // 
            // pGFTEN
            // 
            this.pGFTEN.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.pGFTEN.AreaIndex = 0;
            this.pGFTEN.Caption = "Tên";
            this.pGFTEN.FieldName = "TEN";
            this.pGFTEN.Name = "pGFTEN";
            this.pGFTEN.Visible = false;
            // 
            // pGFMA_LOAI_HOP_DONG
            // 
            this.pGFMA_LOAI_HOP_DONG.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pGFMA_LOAI_HOP_DONG.AreaIndex = 0;
            this.pGFMA_LOAI_HOP_DONG.Caption = "Loại hợp đồng";
            this.pGFMA_LOAI_HOP_DONG.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.pGFMA_LOAI_HOP_DONG.FieldName = "MA_LOAI_HOP_DONG";
            this.pGFMA_LOAI_HOP_DONG.Name = "pGFMA_LOAI_HOP_DONG";
            // 
            // pGFTRINH_DO_VAN_HOA
            // 
            this.pGFTRINH_DO_VAN_HOA.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pGFTRINH_DO_VAN_HOA.AreaIndex = 2;
            this.pGFTRINH_DO_VAN_HOA.Caption = "Chất lượng lao động";
            this.pGFTRINH_DO_VAN_HOA.FieldName = "TRINH_DO_VAN_HOA";
            this.pGFTRINH_DO_VAN_HOA.Name = "pGFTRINH_DO_VAN_HOA";
            // 
            // pGFGIOI_TINH
            // 
            this.pGFGIOI_TINH.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pGFGIOI_TINH.AreaIndex = 1;
            this.pGFGIOI_TINH.Caption = "Giới tính";
            this.pGFGIOI_TINH.FieldName = "GIOI_TINH";
            this.pGFGIOI_TINH.Name = "pGFGIOI_TINH";
            // 
            // pGFTUOI_NHAN_VIEN
            // 
            this.pGFTUOI_NHAN_VIEN.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pGFTUOI_NHAN_VIEN.AreaIndex = 3;
            this.pGFTUOI_NHAN_VIEN.Caption = "Độ tuổi";
            this.pGFTUOI_NHAN_VIEN.FieldName = "TUOI_NHAN_VIEN";
            this.pGFTUOI_NHAN_VIEN.Name = "pGFTUOI_NHAN_VIEN";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(463, 24);
            this.labelControl1.StyleController = this.layoutControl1;
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "BÁO CÁO SỐ LƯỢNG, CHẤT LƯỢNG LAO ĐỘNG";
            // 
            // m_cmd_xuat_excel
            // 
            this.m_cmd_xuat_excel.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_xuat_excel.Image")));
            this.m_cmd_xuat_excel.Location = new System.Drawing.Point(915, 392);
            this.m_cmd_xuat_excel.Name = "m_cmd_xuat_excel";
            this.m_cmd_xuat_excel.Size = new System.Drawing.Size(103, 38);
            this.m_cmd_xuat_excel.StyleController = this.layoutControl1;
            this.m_cmd_xuat_excel.TabIndex = 6;
            this.m_cmd_xuat_excel.Text = "&Xuất Excel";
            this.m_cmd_xuat_excel.Visible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem2,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem4});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1030, 442);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2";
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 380);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(903, 42);
            this.emptySpaceItem2.Text = "emptySpaceItem2";
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.m_cmd_xuat_excel;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(903, 380);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(107, 42);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.labelControl1;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(1010, 28);
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.m_pgc_f410;
            this.layoutControlItem4.CustomizationFormText = "layoutControlItem4";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 28);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(1010, 352);
            this.layoutControlItem4.Text = "layoutControlItem4";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // pGFID_NHAN_VIEN
            // 
            this.pGFID_NHAN_VIEN.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.pGFID_NHAN_VIEN.AreaIndex = 0;
            this.pGFID_NHAN_VIEN.Caption = "ID NV";
            this.pGFID_NHAN_VIEN.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.pGFID_NHAN_VIEN.FieldName = "ID_NHAN_VIEN";
            this.pGFID_NHAN_VIEN.Name = "pGFID_NHAN_VIEN";
            // 
            // f410_bao_cao_so_luong_chat_luong_lao_dong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 442);
            this.Controls.Add(this.layoutControl1);
            this.Name = "f410_bao_cao_so_luong_chat_luong_lao_dong";
            this.Text = "F410 - Báo cáo số lượng, chất lượng lao động";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_pgc_f410)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton m_cmd_xuat_excel;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraPivotGrid.PivotGridControl m_pgc_f410;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraPivotGrid.PivotGridField pGFDON_VI;
        private DevExpress.XtraPivotGrid.PivotGridField pGFVI_TRI;
        private DevExpress.XtraPivotGrid.PivotGridField pGFMA_NV;
        private DevExpress.XtraPivotGrid.PivotGridField pGFHO_DEM;
        private DevExpress.XtraPivotGrid.PivotGridField pGFTEN;
        private DevExpress.XtraPivotGrid.PivotGridField pGFMA_LOAI_HOP_DONG;
        private DevExpress.XtraPivotGrid.PivotGridField pGFTRINH_DO_VAN_HOA;
        private DevExpress.XtraPivotGrid.PivotGridField pGFGIOI_TINH;
        private DevExpress.XtraPivotGrid.PivotGridField pGFTUOI_NHAN_VIEN;
        private DevExpress.XtraPivotGrid.PivotGridField pGFID_NHAN_VIEN;
    }
}