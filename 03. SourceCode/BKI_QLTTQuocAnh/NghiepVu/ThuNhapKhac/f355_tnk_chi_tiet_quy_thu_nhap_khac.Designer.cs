﻿namespace BKI_DichVuMatDat.NghiepVu.ThuNhapKhac
{
    partial class f355_tnk_chi_tiet_quy_thu_nhap_khac
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f355_tnk_chi_tiet_quy_thu_nhap_khac));
            this.imageCollection = new DevExpress.Utils.ImageCollection();
            this.m_grc_main = new DevExpress.XtraGrid.GridControl();
            this.m_grv_main = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_cmd_delete = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_update = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_insert = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.m_lbl_so_luong_nv_trong_quy = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.m_lbl_tong_tien = new DevExpress.XtraEditors.LabelControl();
            this.m_lbl_ten_quy = new DevExpress.XtraEditors.LabelControl();
            this.colSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMA_NV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO_TEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN_DON_VI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN_CHUC_VU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSO_TIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSO_TIEN_NOP_THUE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSO_TIEN_THUC_LINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHE_SO = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageCollection
            // 
            this.imageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection.ImageStream")));
            this.imageCollection.Images.SetKeyName(0, "dvmd_download.png");
            this.imageCollection.Images.SetKeyName(1, "dvmd_upload.png");
            this.imageCollection.Images.SetKeyName(2, "lock.png");
            this.imageCollection.Images.SetKeyName(3, "refresh.png");
            this.imageCollection.Images.SetKeyName(4, "dvmd_info.png");
            this.imageCollection.Images.SetKeyName(5, "play.png");
            this.imageCollection.Images.SetKeyName(6, "pause.png");
            this.imageCollection.Images.SetKeyName(7, "pencil.png");
            this.imageCollection.Images.SetKeyName(8, "trash.png");
            this.imageCollection.Images.SetKeyName(9, "grid.png");
            this.imageCollection.Images.SetKeyName(10, "list.png");
            this.imageCollection.Images.SetKeyName(11, "eye.png");
            this.imageCollection.Images.SetKeyName(12, "note.png");
            this.imageCollection.Images.SetKeyName(13, "magnifier.png");
            this.imageCollection.Images.SetKeyName(14, "close.png");
            // 
            // m_grc_main
            // 
            this.m_grc_main.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc_main.Location = new System.Drawing.Point(0, 105);
            this.m_grc_main.MainView = this.m_grv_main;
            this.m_grc_main.Name = "m_grc_main";
            this.m_grc_main.Size = new System.Drawing.Size(892, 479);
            this.m_grc_main.TabIndex = 4;
            this.m_grc_main.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv_main});
            // 
            // m_grv_main
            // 
            this.m_grv_main.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSTT,
            this.colMA_NV,
            this.colHO_TEN,
            this.colTEN_DON_VI,
            this.colTEN_CHUC_VU,
            this.colSO_TIEN,
            this.colSO_TIEN_NOP_THUE,
            this.colSO_TIEN_THUC_LINH,
            this.colHE_SO});
            this.m_grv_main.GridControl = this.m_grc_main;
            this.m_grv_main.GroupCount = 1;
            this.m_grv_main.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SO_TIEN", this.colSO_TIEN, "{0:n0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SO_TIEN_NOP_THUE", this.colSO_TIEN_NOP_THUE, "{0:n0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SO_TIEN_THUC_LINH", this.colSO_TIEN_THUC_LINH, "{0:n0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "HE_SO", this.colHE_SO, "")});
            this.m_grv_main.Name = "m_grv_main";
            this.m_grv_main.OptionsBehavior.AutoExpandAllGroups = true;
            this.m_grv_main.OptionsBehavior.Editable = false;
            this.m_grv_main.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDownFocused;
            this.m_grv_main.OptionsBehavior.ReadOnly = true;
            this.m_grv_main.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.m_grv_main.OptionsView.ShowFooter = true;
            this.m_grv_main.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTEN_DON_VI, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.m_lbl_ten_quy);
            this.panelControl1.Controls.Add(this.m_lbl_tong_tien);
            this.panelControl1.Controls.Add(this.m_lbl_so_luong_nv_trong_quy);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(892, 105);
            this.panelControl1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Quỹ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.simpleButton5);
            this.panel1.Controls.Add(this.m_cmd_insert);
            this.panel1.Controls.Add(this.m_cmd_update);
            this.panel1.Controls.Add(this.m_cmd_delete);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 584);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(892, 42);
            this.panel1.TabIndex = 6;
            // 
            // m_cmd_delete
            // 
            this.m_cmd_delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_delete.ImageIndex = 14;
            this.m_cmd_delete.ImageList = this.imageCollection;
            this.m_cmd_delete.Location = new System.Drawing.Point(788, 0);
            this.m_cmd_delete.Name = "m_cmd_delete";
            this.m_cmd_delete.Size = new System.Drawing.Size(104, 42);
            this.m_cmd_delete.TabIndex = 1;
            this.m_cmd_delete.Text = "Xóa";
            // 
            // m_cmd_update
            // 
            this.m_cmd_update.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_update.ImageIndex = 13;
            this.m_cmd_update.ImageList = this.imageCollection;
            this.m_cmd_update.Location = new System.Drawing.Point(684, 0);
            this.m_cmd_update.Name = "m_cmd_update";
            this.m_cmd_update.Size = new System.Drawing.Size(104, 42);
            this.m_cmd_update.TabIndex = 2;
            this.m_cmd_update.Text = "Sửa";
            // 
            // m_cmd_insert
            // 
            this.m_cmd_insert.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_insert.ImageIndex = 13;
            this.m_cmd_insert.ImageList = this.imageCollection;
            this.m_cmd_insert.Location = new System.Drawing.Point(580, 0);
            this.m_cmd_insert.Name = "m_cmd_insert";
            this.m_cmd_insert.Size = new System.Drawing.Size(104, 42);
            this.m_cmd_insert.TabIndex = 3;
            this.m_cmd_insert.Text = "Thêm";
            // 
            // simpleButton5
            // 
            this.simpleButton5.Dock = System.Windows.Forms.DockStyle.Left;
            this.simpleButton5.ImageIndex = 9;
            this.simpleButton5.ImageList = this.imageCollection;
            this.simpleButton5.Location = new System.Drawing.Point(0, 0);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(104, 42);
            this.simpleButton5.TabIndex = 4;
            this.simpleButton5.Text = "Import Excel";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(25, 49);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(146, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Số lượng nhân viên trong quỹ:";
            // 
            // m_lbl_so_luong_nv_trong_quy
            // 
            this.m_lbl_so_luong_nv_trong_quy.Location = new System.Drawing.Point(192, 49);
            this.m_lbl_so_luong_nv_trong_quy.Name = "m_lbl_so_luong_nv_trong_quy";
            this.m_lbl_so_luong_nv_trong_quy.Size = new System.Drawing.Size(12, 13);
            this.m_lbl_so_luong_nv_trong_quy.TabIndex = 5;
            this.m_lbl_so_luong_nv_trong_quy.Text = "...";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(25, 73);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(49, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Tổng tiền:";
            // 
            // m_lbl_tong_tien
            // 
            this.m_lbl_tong_tien.Location = new System.Drawing.Point(192, 73);
            this.m_lbl_tong_tien.Name = "m_lbl_tong_tien";
            this.m_lbl_tong_tien.Size = new System.Drawing.Size(12, 13);
            this.m_lbl_tong_tien.TabIndex = 6;
            this.m_lbl_tong_tien.Text = "...";
            // 
            // m_lbl_ten_quy
            // 
            this.m_lbl_ten_quy.Location = new System.Drawing.Point(192, 22);
            this.m_lbl_ten_quy.Name = "m_lbl_ten_quy";
            this.m_lbl_ten_quy.Size = new System.Drawing.Size(12, 13);
            this.m_lbl_ten_quy.TabIndex = 7;
            this.m_lbl_ten_quy.Text = "...";
            // 
            // colSTT
            // 
            this.colSTT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colSTT.AppearanceHeader.Options.UseFont = true;
            this.colSTT.AppearanceHeader.Options.UseTextOptions = true;
            this.colSTT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSTT.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colSTT.Caption = "STT";
            this.colSTT.FieldName = "STT";
            this.colSTT.Name = "colSTT";
            this.colSTT.Visible = true;
            this.colSTT.VisibleIndex = 0;
            this.colSTT.Width = 45;
            // 
            // colMA_NV
            // 
            this.colMA_NV.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colMA_NV.AppearanceHeader.Options.UseFont = true;
            this.colMA_NV.AppearanceHeader.Options.UseTextOptions = true;
            this.colMA_NV.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMA_NV.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colMA_NV.Caption = "Mã NV";
            this.colMA_NV.FieldName = "MA_NV";
            this.colMA_NV.Name = "colMA_NV";
            this.colMA_NV.Visible = true;
            this.colMA_NV.VisibleIndex = 1;
            this.colMA_NV.Width = 92;
            // 
            // colHO_TEN
            // 
            this.colHO_TEN.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colHO_TEN.AppearanceHeader.Options.UseFont = true;
            this.colHO_TEN.AppearanceHeader.Options.UseTextOptions = true;
            this.colHO_TEN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHO_TEN.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colHO_TEN.Caption = "Họ tên";
            this.colHO_TEN.FieldName = "HO_VA_TEN";
            this.colHO_TEN.Name = "colHO_TEN";
            this.colHO_TEN.Visible = true;
            this.colHO_TEN.VisibleIndex = 2;
            this.colHO_TEN.Width = 169;
            // 
            // colTEN_DON_VI
            // 
            this.colTEN_DON_VI.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colTEN_DON_VI.AppearanceHeader.Options.UseFont = true;
            this.colTEN_DON_VI.AppearanceHeader.Options.UseTextOptions = true;
            this.colTEN_DON_VI.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTEN_DON_VI.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colTEN_DON_VI.Caption = "Đơn vị";
            this.colTEN_DON_VI.FieldName = "TEN_DON_VI";
            this.colTEN_DON_VI.Name = "colTEN_DON_VI";
            this.colTEN_DON_VI.Visible = true;
            this.colTEN_DON_VI.VisibleIndex = 3;
            // 
            // colTEN_CHUC_VU
            // 
            this.colTEN_CHUC_VU.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colTEN_CHUC_VU.AppearanceHeader.Options.UseFont = true;
            this.colTEN_CHUC_VU.AppearanceHeader.Options.UseTextOptions = true;
            this.colTEN_CHUC_VU.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTEN_CHUC_VU.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colTEN_CHUC_VU.Caption = "Chức vụ";
            this.colTEN_CHUC_VU.FieldName = "CHUC_VU";
            this.colTEN_CHUC_VU.Name = "colTEN_CHUC_VU";
            this.colTEN_CHUC_VU.Visible = true;
            this.colTEN_CHUC_VU.VisibleIndex = 3;
            this.colTEN_CHUC_VU.Width = 144;
            // 
            // colSO_TIEN
            // 
            this.colSO_TIEN.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colSO_TIEN.AppearanceHeader.Options.UseFont = true;
            this.colSO_TIEN.AppearanceHeader.Options.UseTextOptions = true;
            this.colSO_TIEN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSO_TIEN.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colSO_TIEN.Caption = "Số tiền";
            this.colSO_TIEN.DisplayFormat.FormatString = "n0";
            this.colSO_TIEN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSO_TIEN.FieldName = "SO_TIEN";
            this.colSO_TIEN.Name = "colSO_TIEN";
            this.colSO_TIEN.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SO_TIEN", "{0:n0}")});
            this.colSO_TIEN.Visible = true;
            this.colSO_TIEN.VisibleIndex = 5;
            this.colSO_TIEN.Width = 101;
            // 
            // colSO_TIEN_NOP_THUE
            // 
            this.colSO_TIEN_NOP_THUE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colSO_TIEN_NOP_THUE.AppearanceHeader.Options.UseFont = true;
            this.colSO_TIEN_NOP_THUE.AppearanceHeader.Options.UseTextOptions = true;
            this.colSO_TIEN_NOP_THUE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSO_TIEN_NOP_THUE.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colSO_TIEN_NOP_THUE.Caption = "Số tiền nộp thuế";
            this.colSO_TIEN_NOP_THUE.DisplayFormat.FormatString = "n0";
            this.colSO_TIEN_NOP_THUE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSO_TIEN_NOP_THUE.FieldName = "SO_TIEN_NOP_THUE";
            this.colSO_TIEN_NOP_THUE.Name = "colSO_TIEN_NOP_THUE";
            this.colSO_TIEN_NOP_THUE.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SO_TIEN_NOP_THUE", "{0:n0}")});
            this.colSO_TIEN_NOP_THUE.Visible = true;
            this.colSO_TIEN_NOP_THUE.VisibleIndex = 6;
            this.colSO_TIEN_NOP_THUE.Width = 92;
            // 
            // colSO_TIEN_THUC_LINH
            // 
            this.colSO_TIEN_THUC_LINH.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colSO_TIEN_THUC_LINH.AppearanceHeader.Options.UseFont = true;
            this.colSO_TIEN_THUC_LINH.AppearanceHeader.Options.UseTextOptions = true;
            this.colSO_TIEN_THUC_LINH.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSO_TIEN_THUC_LINH.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colSO_TIEN_THUC_LINH.Caption = "Thực lĩnh";
            this.colSO_TIEN_THUC_LINH.DisplayFormat.FormatString = "n0";
            this.colSO_TIEN_THUC_LINH.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSO_TIEN_THUC_LINH.FieldName = "SO_TIEN_THUC_LINH";
            this.colSO_TIEN_THUC_LINH.Name = "colSO_TIEN_THUC_LINH";
            this.colSO_TIEN_THUC_LINH.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SO_TIEN_THUC_LINH", "{0:n0}")});
            this.colSO_TIEN_THUC_LINH.Visible = true;
            this.colSO_TIEN_THUC_LINH.VisibleIndex = 7;
            this.colSO_TIEN_THUC_LINH.Width = 108;
            // 
            // colHE_SO
            // 
            this.colHE_SO.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colHE_SO.AppearanceHeader.Options.UseFont = true;
            this.colHE_SO.AppearanceHeader.Options.UseTextOptions = true;
            this.colHE_SO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHE_SO.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colHE_SO.Caption = "Hệ số";
            this.colHE_SO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colHE_SO.FieldName = "HE_SO";
            this.colHE_SO.Name = "colHE_SO";
            this.colHE_SO.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "HE_SO", "{0:n0}")});
            this.colHE_SO.Visible = true;
            this.colHE_SO.VisibleIndex = 4;
            this.colHE_SO.Width = 123;
            // 
            // f355_tnk_chi_tiet_quy_thu_nhap_khac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 626);
            this.Controls.Add(this.m_grc_main);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelControl1);
            this.Name = "f355_tnk_chi_tiet_quy_thu_nhap_khac";
            this.Text = "F355 - Chi tiết quỹ thu nhập khác ngoài bảng lương";
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.ImageCollection imageCollection;
        private DevExpress.XtraGrid.GridControl m_grc_main;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv_main;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton m_cmd_insert;
        private DevExpress.XtraEditors.SimpleButton m_cmd_update;
        private DevExpress.XtraEditors.SimpleButton m_cmd_delete;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl m_lbl_so_luong_nv_trong_quy;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl m_lbl_tong_tien;
        private DevExpress.XtraEditors.LabelControl m_lbl_ten_quy;
        private DevExpress.XtraGrid.Columns.GridColumn colSTT;
        private DevExpress.XtraGrid.Columns.GridColumn colMA_NV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO_TEN;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN_DON_VI;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN_CHUC_VU;
        private DevExpress.XtraGrid.Columns.GridColumn colSO_TIEN;
        private DevExpress.XtraGrid.Columns.GridColumn colSO_TIEN_NOP_THUE;
        private DevExpress.XtraGrid.Columns.GridColumn colSO_TIEN_THUC_LINH;
        private DevExpress.XtraGrid.Columns.GridColumn colHE_SO;
    }
}