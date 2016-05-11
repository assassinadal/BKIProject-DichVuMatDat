namespace BKI_DichVuMatDat.BaoCao
{
    partial class f470_bao_cao_thong_ke_lao_dong
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
            if(disposing && (components != null))
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f470_bao_cao_thong_ke_lao_dong));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.m_cmd_xuat_excel = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_filter = new DevExpress.XtraEditors.SimpleButton();
            this.m_pvg_main = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.pivotGridField1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField2 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField3 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField5 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField6 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.m_dat_tai_ngay = new DevExpress.XtraEditors.DateEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_pvg_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_tai_ngay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_tai_ngay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.m_cmd_xuat_excel);
            this.layoutControl1.Controls.Add(this.m_cmd_filter);
            this.layoutControl1.Controls.Add(this.m_pvg_main);
            this.layoutControl1.Controls.Add(this.m_dat_tai_ngay);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(801, 268, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(659, 419);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // m_cmd_xuat_excel
            // 
            this.m_cmd_xuat_excel.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_xuat_excel.Image")));
            this.m_cmd_xuat_excel.Location = new System.Drawing.Point(544, 369);
            this.m_cmd_xuat_excel.Name = "m_cmd_xuat_excel";
            this.m_cmd_xuat_excel.Size = new System.Drawing.Size(103, 38);
            this.m_cmd_xuat_excel.StyleController = this.layoutControl1;
            this.m_cmd_xuat_excel.TabIndex = 5;
            this.m_cmd_xuat_excel.Text = "&Xuất Excel";
            this.m_cmd_xuat_excel.Visible = false;
            // 
            // m_cmd_filter
            // 
            this.m_cmd_filter.Image = global::BKI_DichVuMatDat.Properties.Resources.Search;
            this.m_cmd_filter.Location = new System.Drawing.Point(12, 36);
            this.m_cmd_filter.Name = "m_cmd_filter";
            this.m_cmd_filter.Size = new System.Drawing.Size(107, 38);
            this.m_cmd_filter.StyleController = this.layoutControl1;
            this.m_cmd_filter.TabIndex = 7;
            this.m_cmd_filter.Text = "Xem báo cáo";
            // 
            // m_pvg_main
            // 
            this.m_pvg_main.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.pivotGridField1,
            this.pivotGridField2,
            this.pivotGridField3,
            this.pivotGridField5,
            this.pivotGridField6});
            this.m_pvg_main.Location = new System.Drawing.Point(12, 78);
            this.m_pvg_main.Name = "m_pvg_main";
            this.m_pvg_main.Size = new System.Drawing.Size(635, 287);
            this.m_pvg_main.TabIndex = 6;
            // 
            // pivotGridField1
            // 
            this.pivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.pivotGridField1.AreaIndex = 0;
            this.pivotGridField1.Caption = "Tên đơn vị";
            this.pivotGridField1.FieldName = "TEN_DON_VI";
            this.pivotGridField1.Name = "pivotGridField1";
            // 
            // pivotGridField2
            // 
            this.pivotGridField2.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.pivotGridField2.AreaIndex = 0;
            this.pivotGridField2.FieldName = "ID";
            this.pivotGridField2.Name = "pivotGridField2";
            this.pivotGridField2.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Count;
            // 
            // pivotGridField3
            // 
            this.pivotGridField3.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pivotGridField3.AreaIndex = 1;
            this.pivotGridField3.Caption = "Giới tính";
            this.pivotGridField3.FieldName = "GT";
            this.pivotGridField3.Name = "pivotGridField3";
            // 
            // pivotGridField5
            // 
            this.pivotGridField5.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pivotGridField5.AreaIndex = 2;
            this.pivotGridField5.Caption = "Chuyên môn";
            this.pivotGridField5.FieldName = "CHUYEN_MON";
            this.pivotGridField5.Name = "pivotGridField5";
            // 
            // pivotGridField6
            // 
            this.pivotGridField6.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pivotGridField6.AreaIndex = 0;
            this.pivotGridField6.Caption = "Loại hợp đồng";
            this.pivotGridField6.FieldName = "TEN_LOAI_HOP_DONG";
            this.pivotGridField6.Name = "pivotGridField6";
            // 
            // m_dat_tai_ngay
            // 
            this.m_dat_tai_ngay.EditValue = null;
            this.m_dat_tai_ngay.Location = new System.Drawing.Point(117, 12);
            this.m_dat_tai_ngay.Name = "m_dat_tai_ngay";
            this.m_dat_tai_ngay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.m_dat_tai_ngay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.m_dat_tai_ngay.Size = new System.Drawing.Size(228, 20);
            this.m_dat_tai_ngay.StyleController = this.layoutControl1;
            this.m_dat_tai_ngay.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "Root";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.emptySpaceItem1,
            this.emptySpaceItem2,
            this.layoutControlItem2,
            this.emptySpaceItem3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(659, 419);
            this.layoutControlGroup1.Text = "Root";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.m_dat_tai_ngay;
            this.layoutControlItem1.CustomizationFormText = "Tại ngày";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(337, 24);
            this.layoutControlItem1.Text = "Tại ngày";
            this.layoutControlItem1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(100, 20);
            this.layoutControlItem1.TextToControlDistance = 5;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.m_pvg_main;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 66);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(639, 291);
            this.layoutControlItem3.Text = "layoutControlItem3";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextToControlDistance = 0;
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.m_cmd_filter;
            this.layoutControlItem4.CustomizationFormText = "layoutControlItem4";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem4.MaxSize = new System.Drawing.Size(111, 42);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(111, 42);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(111, 42);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.Text = "layoutControlItem4";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextToControlDistance = 0;
            this.layoutControlItem4.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(337, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(302, 66);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2";
            this.emptySpaceItem2.Location = new System.Drawing.Point(111, 24);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(226, 42);
            this.emptySpaceItem2.Text = "emptySpaceItem2";
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.m_cmd_xuat_excel;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(532, 357);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(107, 42);
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.CustomizationFormText = "emptySpaceItem3";
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 357);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(532, 42);
            this.emptySpaceItem3.Text = "emptySpaceItem3";
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // f470_bao_cao_thong_ke_lao_dong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 419);
            this.Controls.Add(this.layoutControl1);
            this.Name = "f470_bao_cao_thong_ke_lao_dong";
            this.Text = "F470 - Báo cáo thống kê lao động";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_pvg_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_tai_ngay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_tai_ngay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.SimpleButton m_cmd_filter;
        private DevExpress.XtraPivotGrid.PivotGridControl m_pvg_main;
        private DevExpress.XtraEditors.DateEdit m_dat_tai_ngay;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField1;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField2;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField3;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField5;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField6;
        private DevExpress.XtraEditors.SimpleButton m_cmd_xuat_excel;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
    }
}