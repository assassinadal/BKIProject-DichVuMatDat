namespace BKI_DichVuMatDat.NghiepVu
{
    partial class f367_quan_li_nv_ko_dong_bao_hiem_v2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f367_quan_li_nv_ko_dong_bao_hiem_v2));
            this.img_DVMD = new DevExpress.Utils.ImageCollection(this.components);
            this.m_grc_luong_cung_cua_nhan_vien = new DevExpress.XtraGrid.GridControl();
            this.m_grv_luong_cung_cua_nhan_vien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ID_NHAN_VIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MA_NV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HO_DEM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAY_LAP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGUOI_LAP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LY_DO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.m_cmd_xem_thong_tin = new DevExpress.XtraEditors.SimpleButton();
            this.m_dat_thang = new DevExpress.XtraEditors.DateEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.m_cmd_xuat_excel = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_delete = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_update = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_insert = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.img_DVMD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_luong_cung_cua_nhan_vien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_luong_cung_cua_nhan_vien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_thang.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_thang.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            // m_grc_luong_cung_cua_nhan_vien
            // 
            this.m_grc_luong_cung_cua_nhan_vien.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_luong_cung_cua_nhan_vien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc_luong_cung_cua_nhan_vien.Location = new System.Drawing.Point(0, 48);
            this.m_grc_luong_cung_cua_nhan_vien.MainView = this.m_grv_luong_cung_cua_nhan_vien;
            this.m_grc_luong_cung_cua_nhan_vien.Name = "m_grc_luong_cung_cua_nhan_vien";
            this.m_grc_luong_cung_cua_nhan_vien.Size = new System.Drawing.Size(1028, 455);
            this.m_grc_luong_cung_cua_nhan_vien.TabIndex = 0;
            this.m_grc_luong_cung_cua_nhan_vien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv_luong_cung_cua_nhan_vien});
            // 
            // m_grv_luong_cung_cua_nhan_vien
            // 
            this.m_grv_luong_cung_cua_nhan_vien.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.ID_NHAN_VIEN,
            this.STT,
            this.MA_NV,
            this.HO_DEM,
            this.TEN,
            this.NGAY_LAP,
            this.NGUOI_LAP,
            this.LY_DO});
            this.m_grv_luong_cung_cua_nhan_vien.GridControl = this.m_grc_luong_cung_cua_nhan_vien;
            this.m_grv_luong_cung_cua_nhan_vien.Name = "m_grv_luong_cung_cua_nhan_vien";
            this.m_grv_luong_cung_cua_nhan_vien.OptionsFind.AllowFindPanel = false;
            this.m_grv_luong_cung_cua_nhan_vien.OptionsFind.AlwaysVisible = true;
            this.m_grv_luong_cung_cua_nhan_vien.OptionsView.ShowFooter = true;
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            // 
            // ID_NHAN_VIEN
            // 
            this.ID_NHAN_VIEN.Caption = "ID_NHAN_VIEN";
            this.ID_NHAN_VIEN.FieldName = "ID_NHAN_VIEN";
            this.ID_NHAN_VIEN.Name = "ID_NHAN_VIEN";
            // 
            // STT
            // 
            this.STT.AppearanceCell.Options.UseTextOptions = true;
            this.STT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.STT.AppearanceHeader.Options.UseTextOptions = true;
            this.STT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.STT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.STT.Caption = "STT";
            this.STT.FieldName = "STT";
            this.STT.Name = "STT";
            this.STT.OptionsColumn.AllowEdit = false;
            this.STT.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "STT", "SL: {0}")});
            this.STT.Visible = true;
            this.STT.VisibleIndex = 0;
            this.STT.Width = 38;
            // 
            // MA_NV
            // 
            this.MA_NV.AppearanceCell.Options.UseTextOptions = true;
            this.MA_NV.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.MA_NV.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.MA_NV.AppearanceHeader.Options.UseTextOptions = true;
            this.MA_NV.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.MA_NV.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.MA_NV.Caption = "Mã NV";
            this.MA_NV.FieldName = "MA_NV";
            this.MA_NV.Name = "MA_NV";
            this.MA_NV.OptionsColumn.AllowEdit = false;
            this.MA_NV.Visible = true;
            this.MA_NV.VisibleIndex = 1;
            this.MA_NV.Width = 50;
            // 
            // HO_DEM
            // 
            this.HO_DEM.AppearanceHeader.Options.UseTextOptions = true;
            this.HO_DEM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.HO_DEM.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.HO_DEM.Caption = "Họ đệm";
            this.HO_DEM.FieldName = "HO_DEM";
            this.HO_DEM.Name = "HO_DEM";
            this.HO_DEM.OptionsColumn.AllowEdit = false;
            this.HO_DEM.Visible = true;
            this.HO_DEM.VisibleIndex = 2;
            // 
            // TEN
            // 
            this.TEN.AppearanceHeader.Options.UseTextOptions = true;
            this.TEN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TEN.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.TEN.Caption = "Tên";
            this.TEN.FieldName = "TEN";
            this.TEN.Name = "TEN";
            this.TEN.OptionsColumn.AllowEdit = false;
            this.TEN.Visible = true;
            this.TEN.VisibleIndex = 3;
            // 
            // NGAY_LAP
            // 
            this.NGAY_LAP.AppearanceCell.Options.UseTextOptions = true;
            this.NGAY_LAP.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NGAY_LAP.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.NGAY_LAP.AppearanceHeader.Options.UseTextOptions = true;
            this.NGAY_LAP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NGAY_LAP.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.NGAY_LAP.Caption = "Ngày lập";
            this.NGAY_LAP.FieldName = "NGAY_LAP";
            this.NGAY_LAP.Name = "NGAY_LAP";
            this.NGAY_LAP.OptionsColumn.AllowEdit = false;
            this.NGAY_LAP.Visible = true;
            this.NGAY_LAP.VisibleIndex = 4;
            // 
            // NGUOI_LAP
            // 
            this.NGUOI_LAP.AppearanceHeader.Options.UseTextOptions = true;
            this.NGUOI_LAP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NGUOI_LAP.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.NGUOI_LAP.Caption = "Người lập";
            this.NGUOI_LAP.FieldName = "NGUOI_LAP";
            this.NGUOI_LAP.Name = "NGUOI_LAP";
            this.NGUOI_LAP.OptionsColumn.AllowEdit = false;
            this.NGUOI_LAP.Visible = true;
            this.NGUOI_LAP.VisibleIndex = 5;
            // 
            // LY_DO
            // 
            this.LY_DO.AppearanceHeader.Options.UseTextOptions = true;
            this.LY_DO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.LY_DO.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.LY_DO.Caption = "Lý do";
            this.LY_DO.FieldName = "LY_DO";
            this.LY_DO.Name = "LY_DO";
            this.LY_DO.OptionsColumn.AllowEdit = false;
            this.LY_DO.Visible = true;
            this.LY_DO.VisibleIndex = 6;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.m_cmd_xem_thong_tin);
            this.panelControl1.Controls.Add(this.m_dat_thang);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1028, 48);
            this.panelControl1.TabIndex = 0;
            // 
            // m_cmd_xem_thong_tin
            // 
            this.m_cmd_xem_thong_tin.ImageIndex = 10;
            this.m_cmd_xem_thong_tin.ImageList = this.img_DVMD;
            this.m_cmd_xem_thong_tin.Location = new System.Drawing.Point(240, 10);
            this.m_cmd_xem_thong_tin.Name = "m_cmd_xem_thong_tin";
            this.m_cmd_xem_thong_tin.Size = new System.Drawing.Size(110, 32);
            this.m_cmd_xem_thong_tin.TabIndex = 2;
            this.m_cmd_xem_thong_tin.Text = "&Xem thông tin";
            // 
            // m_dat_thang
            // 
            this.m_dat_thang.EditValue = null;
            this.m_dat_thang.Location = new System.Drawing.Point(93, 13);
            this.m_dat_thang.Name = "m_dat_thang";
            this.m_dat_thang.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.m_dat_thang.Properties.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.m_dat_thang.Properties.Appearance.Options.UseFont = true;
            this.m_dat_thang.Properties.Appearance.Options.UseForeColor = true;
            this.m_dat_thang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.m_dat_thang.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.m_dat_thang.Properties.DisplayFormat.FormatString = "MM/yyyy";
            this.m_dat_thang.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.m_dat_thang.Properties.EditFormat.FormatString = "MM/yyyy";
            this.m_dat_thang.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.m_dat_thang.Properties.Mask.EditMask = "MM/yyyy";
            this.m_dat_thang.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.m_dat_thang.Size = new System.Drawing.Size(141, 26);
            this.m_dat_thang.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Chọn tháng (*)";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.m_cmd_xuat_excel);
            this.panel2.Controls.Add(this.m_cmd_delete);
            this.panel2.Controls.Add(this.m_cmd_update);
            this.panel2.Controls.Add(this.m_cmd_insert);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 48);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(2);
            this.panel2.Size = new System.Drawing.Size(1028, 36);
            this.panel2.TabIndex = 1;
            // 
            // m_cmd_xuat_excel
            // 
            this.m_cmd_xuat_excel.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_xuat_excel.ImageIndex = 0;
            this.m_cmd_xuat_excel.ImageList = this.img_DVMD;
            this.m_cmd_xuat_excel.Location = new System.Drawing.Point(227, 2);
            this.m_cmd_xuat_excel.Name = "m_cmd_xuat_excel";
            this.m_cmd_xuat_excel.Size = new System.Drawing.Size(100, 32);
            this.m_cmd_xuat_excel.TabIndex = 3;
            this.m_cmd_xuat_excel.Text = "&Xuất Excel";
            // 
            // m_cmd_delete
            // 
            this.m_cmd_delete.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_delete.ImageIndex = 8;
            this.m_cmd_delete.ImageList = this.img_DVMD;
            this.m_cmd_delete.Location = new System.Drawing.Point(152, 2);
            this.m_cmd_delete.Name = "m_cmd_delete";
            this.m_cmd_delete.Size = new System.Drawing.Size(75, 32);
            this.m_cmd_delete.TabIndex = 2;
            this.m_cmd_delete.Text = "&Xóa";
            // 
            // m_cmd_update
            // 
            this.m_cmd_update.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_update.ImageIndex = 9;
            this.m_cmd_update.ImageList = this.img_DVMD;
            this.m_cmd_update.Location = new System.Drawing.Point(77, 2);
            this.m_cmd_update.Name = "m_cmd_update";
            this.m_cmd_update.Size = new System.Drawing.Size(75, 32);
            this.m_cmd_update.TabIndex = 1;
            this.m_cmd_update.Text = "&Sửa";
            // 
            // m_cmd_insert
            // 
            this.m_cmd_insert.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_insert.ImageIndex = 7;
            this.m_cmd_insert.ImageList = this.img_DVMD;
            this.m_cmd_insert.Location = new System.Drawing.Point(2, 2);
            this.m_cmd_insert.Name = "m_cmd_insert";
            this.m_cmd_insert.Size = new System.Drawing.Size(75, 32);
            this.m_cmd_insert.TabIndex = 0;
            this.m_cmd_insert.Text = "&Thêm";
            // 
            // f367_quan_li_nv_ko_dong_bao_hiem_v2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 503);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.m_grc_luong_cung_cua_nhan_vien);
            this.Controls.Add(this.panelControl1);
            this.Name = "f367_quan_li_nv_ko_dong_bao_hiem_v2";
            this.Text = "F367 - Quản lý nhân viên không đóng bảo hiểm";
            ((System.ComponentModel.ISupportInitialize)(this.img_DVMD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_luong_cung_cua_nhan_vien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_luong_cung_cua_nhan_vien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_thang.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_thang.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl m_grc_luong_cung_cua_nhan_vien;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv_luong_cung_cua_nhan_vien;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn ID_NHAN_VIEN;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
        private DevExpress.XtraGrid.Columns.GridColumn MA_NV;
        private DevExpress.XtraGrid.Columns.GridColumn HO_DEM;
        private DevExpress.XtraGrid.Columns.GridColumn TEN;
        private DevExpress.XtraGrid.Columns.GridColumn NGAY_LAP;
        private DevExpress.XtraGrid.Columns.GridColumn NGUOI_LAP;
        private DevExpress.XtraGrid.Columns.GridColumn LY_DO;
        private DevExpress.Utils.ImageCollection img_DVMD;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton m_cmd_xem_thong_tin;
        private DevExpress.XtraEditors.DateEdit m_dat_thang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton m_cmd_xuat_excel;
        private DevExpress.XtraEditors.SimpleButton m_cmd_delete;
        private DevExpress.XtraEditors.SimpleButton m_cmd_update;
        private DevExpress.XtraEditors.SimpleButton m_cmd_insert;
    }
}