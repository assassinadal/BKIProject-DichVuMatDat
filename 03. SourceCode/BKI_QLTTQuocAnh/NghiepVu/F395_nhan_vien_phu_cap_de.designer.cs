﻿namespace BKI_DichVuMatDat.NghiepVu
{
    partial class F395_nhan_vien_phu_cap_de
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F395_nhan_vien_phu_cap_de));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.m_sle_nhan_vien = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.m_sle_phu_cap = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_lbl_header = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.m_cmd_luu = new DevExpress.XtraEditors.SimpleButton();
            this.img_DVMD = new DevExpress.Utils.ImageCollection();
            this.sle_cnv_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sle_cnv_MA_NV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sle_cnv_HO_TEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sle_cnv_GIOI_TINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sle_cnv_SDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sle_cnv_DIA_CHI_THUONG_TRU = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_sle_nhan_vien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_sle_phu_cap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_DVMD)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.m_sle_nhan_vien);
            this.layoutControl1.Controls.Add(this.m_sle_phu_cap);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 39);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(681, 212, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(420, 95);
            this.layoutControl1.TabIndex = 3;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // m_sle_nhan_vien
            // 
            this.m_sle_nhan_vien.Location = new System.Drawing.Point(173, 12);
            this.m_sle_nhan_vien.Name = "m_sle_nhan_vien";
            this.m_sle_nhan_vien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.m_sle_nhan_vien.Properties.NullText = "--Chọn nhân viên--";
            this.m_sle_nhan_vien.Properties.View = this.searchLookUpEdit1View;
            this.m_sle_nhan_vien.Size = new System.Drawing.Size(235, 20);
            this.m_sle_nhan_vien.StyleController = this.layoutControl1;
            this.m_sle_nhan_vien.TabIndex = 4;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.sle_cnv_ID,
            this.sle_cnv_MA_NV,
            this.sle_cnv_HO_TEN,
            this.sle_cnv_GIOI_TINH,
            this.sle_cnv_SDT,
            this.sle_cnv_DIA_CHI_THUONG_TRU});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // m_sle_phu_cap
            // 
            this.m_sle_phu_cap.Location = new System.Drawing.Point(173, 36);
            this.m_sle_phu_cap.Name = "m_sle_phu_cap";
            this.m_sle_phu_cap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.m_sle_phu_cap.Properties.DisplayMember = "DOI_TUONG_HUONG_PHU_CAP";
            this.m_sle_phu_cap.Properties.NullText = "--Chọn phụ cấp trách nhiệm--";
            this.m_sle_phu_cap.Properties.ValueMember = "ID";
            this.m_sle_phu_cap.Properties.View = this.gridView2;
            this.m_sle_phu_cap.Size = new System.Drawing.Size(235, 20);
            this.m_sle_phu_cap.StyleController = this.layoutControl1;
            this.m_sle_phu_cap.TabIndex = 6;
            // 
            // gridView2
            // 
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.emptySpaceItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(420, 95);
            this.layoutControlGroup1.Text = "Root";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.m_sle_nhan_vien;
            this.layoutControlItem1.CustomizationFormText = "Chọn nhân viên (*)";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(400, 24);
            this.layoutControlItem1.Text = "Chọn nhân viên (*)";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(158, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.m_sle_phu_cap;
            this.layoutControlItem3.CustomizationFormText = "Chọn chức vụ hưởng phụ cấp (*)";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(400, 24);
            this.layoutControlItem3.Text = "Chọn chức vụ hưởng phụ cấp (*)";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(158, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 48);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(400, 27);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_lbl_header);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 39);
            this.panel1.TabIndex = 4;
            // 
            // m_lbl_header
            // 
            this.m_lbl_header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.m_lbl_header.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_header.Location = new System.Drawing.Point(0, 0);
            this.m_lbl_header.Name = "m_lbl_header";
            this.m_lbl_header.Size = new System.Drawing.Size(420, 39);
            this.m_lbl_header.TabIndex = 2;
            this.m_lbl_header.Text = "THÊM MỚI PHỤ CẤP TRÁCH NHIỆM";
            this.m_lbl_header.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.m_cmd_luu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 134);
            this.panel2.MaximumSize = new System.Drawing.Size(0, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(420, 36);
            this.panel2.TabIndex = 5;
            // 
            // m_cmd_luu
            // 
            this.m_cmd_luu.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_luu.ImageIndex = 6;
            this.m_cmd_luu.ImageList = this.img_DVMD;
            this.m_cmd_luu.Location = new System.Drawing.Point(345, 0);
            this.m_cmd_luu.Name = "m_cmd_luu";
            this.m_cmd_luu.Size = new System.Drawing.Size(75, 36);
            this.m_cmd_luu.TabIndex = 9;
            this.m_cmd_luu.Text = "&Lưu";
            this.m_cmd_luu.Click += new System.EventHandler(this.m_cmd_luu_Click);
            // 
            // img_DVMD
            // 
            this.img_DVMD.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("img_DVMD.ImageStream")));
            this.img_DVMD.Images.SetKeyName(0, "Excel-icon.png");
            this.img_DVMD.Images.SetKeyName(1, "excel-xls-icon.png");
            this.img_DVMD.Images.SetKeyName(2, "exit-16.ico");
            this.img_DVMD.Images.SetKeyName(3, "image.png");
            this.img_DVMD.Images.SetKeyName(4, "Microsoft Excel.png");
            this.img_DVMD.Images.SetKeyName(5, "calculator.png");
            this.img_DVMD.Images.SetKeyName(6, "diskette.png");
            this.img_DVMD.Images.SetKeyName(7, "file_add.png");
            this.img_DVMD.Images.SetKeyName(8, "file_delete.png");
            this.img_DVMD.Images.SetKeyName(9, "file_edit.png");
            this.img_DVMD.Images.SetKeyName(10, "file_search.png");
            // 
            // sle_cnv_ID
            // 
            this.sle_cnv_ID.Caption = "ID";
            this.sle_cnv_ID.FieldName = "ID";
            this.sle_cnv_ID.Name = "sle_cnv_ID";
            // 
            // sle_cnv_MA_NV
            // 
            this.sle_cnv_MA_NV.Caption = "Mã NV";
            this.sle_cnv_MA_NV.FieldName = "MA_NV";
            this.sle_cnv_MA_NV.Name = "sle_cnv_MA_NV";
            this.sle_cnv_MA_NV.Visible = true;
            this.sle_cnv_MA_NV.VisibleIndex = 0;
            // 
            // sle_cnv_HO_TEN
            // 
            this.sle_cnv_HO_TEN.Caption = "Họ tên";
            this.sle_cnv_HO_TEN.FieldName = "HO_TEN";
            this.sle_cnv_HO_TEN.Name = "sle_cnv_HO_TEN";
            this.sle_cnv_HO_TEN.Visible = true;
            this.sle_cnv_HO_TEN.VisibleIndex = 1;
            // 
            // sle_cnv_GIOI_TINH
            // 
            this.sle_cnv_GIOI_TINH.Caption = "Giới tính";
            this.sle_cnv_GIOI_TINH.FieldName = "GT";
            this.sle_cnv_GIOI_TINH.Name = "sle_cnv_GIOI_TINH";
            // 
            // sle_cnv_SDT
            // 
            this.sle_cnv_SDT.Caption = "SĐT";
            this.sle_cnv_SDT.FieldName = "SDT";
            this.sle_cnv_SDT.Name = "sle_cnv_SDT";
            this.sle_cnv_SDT.Visible = true;
            this.sle_cnv_SDT.VisibleIndex = 2;
            // 
            // sle_cnv_DIA_CHI_THUONG_TRU
            // 
            this.sle_cnv_DIA_CHI_THUONG_TRU.Caption = "Địa chỉ thường trú";
            this.sle_cnv_DIA_CHI_THUONG_TRU.FieldName = "DIA_CHI_THUONG_TRU";
            this.sle_cnv_DIA_CHI_THUONG_TRU.Name = "sle_cnv_DIA_CHI_THUONG_TRU";
            // 
            // F395_nhan_vien_phu_cap_de
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 170);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "F395_nhan_vien_phu_cap_de";
            this.Text = "F395 - Chi tiết nhân phụ cấp";
            this.Load += new System.EventHandler(this.F393_nhan_vien_phu_cap_de_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_sle_nhan_vien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_sle_phu_cap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_DVMD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SearchLookUpEdit m_sle_nhan_vien;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.SearchLookUpEdit m_sle_phu_cap;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.Label m_lbl_header;
        private DevExpress.XtraGrid.Columns.GridColumn sle_cnv_ID;
        private DevExpress.XtraGrid.Columns.GridColumn sle_cnv_MA_NV;
        private DevExpress.XtraGrid.Columns.GridColumn sle_cnv_HO_TEN;
        private DevExpress.XtraGrid.Columns.GridColumn sle_cnv_GIOI_TINH;
        private DevExpress.XtraGrid.Columns.GridColumn sle_cnv_SDT;
        private DevExpress.XtraGrid.Columns.GridColumn sle_cnv_DIA_CHI_THUONG_TRU;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.SimpleButton m_cmd_luu;
        private DevExpress.Utils.ImageCollection img_DVMD;
    }
}