namespace BKI_DichVuMatDat.NghiepVu
{
    partial class f365_quan_ly_nhan_vien_co_luong_cung_v2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f365_quan_ly_nhan_vien_co_luong_cung_v2));
            this.panel3 = new System.Windows.Forms.Panel();
            this.m_cmd_xuat_excel = new DevExpress.XtraEditors.SimpleButton();
            this.img_DVMD = new DevExpress.Utils.ImageCollection(this.components);
            this.m_cmd_delete = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_update = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_insert = new DevExpress.XtraEditors.SimpleButton();
            this.m_grc_luong_cung_cua_nhan_vien = new DevExpress.XtraGrid.GridControl();
            this.m_grv_luong_cung_cua_nhan_vien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ID_NHAN_VIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MA_NV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HO_DEM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SO_TIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAY_BAT_DAU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAY_KET_THUC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAY_LAP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGUOI_LAP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAY_SUA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGUOI_SUA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GHI_CHU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_DVMD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_luong_cung_cua_nhan_vien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_luong_cung_cua_nhan_vien)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.m_cmd_xuat_excel);
            this.panel3.Controls.Add(this.m_cmd_delete);
            this.panel3.Controls.Add(this.m_cmd_update);
            this.panel3.Controls.Add(this.m_cmd_insert);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.MaximumSize = new System.Drawing.Size(0, 36);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(2);
            this.panel3.Size = new System.Drawing.Size(863, 36);
            this.panel3.TabIndex = 4;
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
            // m_grc_luong_cung_cua_nhan_vien
            // 
            this.m_grc_luong_cung_cua_nhan_vien.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_luong_cung_cua_nhan_vien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc_luong_cung_cua_nhan_vien.Location = new System.Drawing.Point(0, 36);
            this.m_grc_luong_cung_cua_nhan_vien.MainView = this.m_grv_luong_cung_cua_nhan_vien;
            this.m_grc_luong_cung_cua_nhan_vien.Name = "m_grc_luong_cung_cua_nhan_vien";
            this.m_grc_luong_cung_cua_nhan_vien.Size = new System.Drawing.Size(863, 420);
            this.m_grc_luong_cung_cua_nhan_vien.TabIndex = 5;
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
            this.SO_TIEN,
            this.NGAY_BAT_DAU,
            this.NGAY_KET_THUC,
            this.NGAY_LAP,
            this.NGUOI_LAP,
            this.NGAY_SUA,
            this.NGUOI_SUA,
            this.GHI_CHU});
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
            // SO_TIEN
            // 
            this.SO_TIEN.AppearanceCell.Options.UseTextOptions = true;
            this.SO_TIEN.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.SO_TIEN.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.SO_TIEN.AppearanceHeader.Options.UseTextOptions = true;
            this.SO_TIEN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SO_TIEN.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.SO_TIEN.Caption = "Số tiền";
            this.SO_TIEN.DisplayFormat.FormatString = "{0:#,##0}";
            this.SO_TIEN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.SO_TIEN.FieldName = "SO_TIEN";
            this.SO_TIEN.Name = "SO_TIEN";
            this.SO_TIEN.OptionsColumn.AllowEdit = false;
            this.SO_TIEN.Visible = true;
            this.SO_TIEN.VisibleIndex = 4;
            // 
            // NGAY_BAT_DAU
            // 
            this.NGAY_BAT_DAU.AppearanceCell.Options.UseTextOptions = true;
            this.NGAY_BAT_DAU.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NGAY_BAT_DAU.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.NGAY_BAT_DAU.AppearanceHeader.Options.UseTextOptions = true;
            this.NGAY_BAT_DAU.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NGAY_BAT_DAU.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.NGAY_BAT_DAU.Caption = "Ngày có hiệu lực";
            this.NGAY_BAT_DAU.FieldName = "NGAY_BAT_DAU";
            this.NGAY_BAT_DAU.Name = "NGAY_BAT_DAU";
            this.NGAY_BAT_DAU.OptionsColumn.AllowEdit = false;
            this.NGAY_BAT_DAU.Visible = true;
            this.NGAY_BAT_DAU.VisibleIndex = 5;
            // 
            // NGAY_KET_THUC
            // 
            this.NGAY_KET_THUC.AppearanceCell.Options.UseTextOptions = true;
            this.NGAY_KET_THUC.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NGAY_KET_THUC.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.NGAY_KET_THUC.AppearanceHeader.Options.UseTextOptions = true;
            this.NGAY_KET_THUC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NGAY_KET_THUC.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.NGAY_KET_THUC.Caption = "Ngày hết hiệu lực";
            this.NGAY_KET_THUC.FieldName = "NGAY_KET_THUC";
            this.NGAY_KET_THUC.Name = "NGAY_KET_THUC";
            this.NGAY_KET_THUC.OptionsColumn.AllowEdit = false;
            this.NGAY_KET_THUC.Visible = true;
            this.NGAY_KET_THUC.VisibleIndex = 6;
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
            this.NGAY_LAP.VisibleIndex = 7;
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
            this.NGUOI_LAP.VisibleIndex = 8;
            // 
            // NGAY_SUA
            // 
            this.NGAY_SUA.AppearanceCell.Options.UseTextOptions = true;
            this.NGAY_SUA.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NGAY_SUA.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.NGAY_SUA.AppearanceHeader.Options.UseTextOptions = true;
            this.NGAY_SUA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NGAY_SUA.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.NGAY_SUA.Caption = "Ngày sửa";
            this.NGAY_SUA.FieldName = "NGAY_SUA";
            this.NGAY_SUA.Name = "NGAY_SUA";
            this.NGAY_SUA.OptionsColumn.AllowEdit = false;
            this.NGAY_SUA.Visible = true;
            this.NGAY_SUA.VisibleIndex = 9;
            // 
            // NGUOI_SUA
            // 
            this.NGUOI_SUA.AppearanceHeader.Options.UseTextOptions = true;
            this.NGUOI_SUA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NGUOI_SUA.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.NGUOI_SUA.Caption = "Người sửa";
            this.NGUOI_SUA.FieldName = "NGUOI_SUA";
            this.NGUOI_SUA.Name = "NGUOI_SUA";
            this.NGUOI_SUA.OptionsColumn.AllowEdit = false;
            this.NGUOI_SUA.Visible = true;
            this.NGUOI_SUA.VisibleIndex = 10;
            // 
            // GHI_CHU
            // 
            this.GHI_CHU.AppearanceHeader.Options.UseTextOptions = true;
            this.GHI_CHU.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GHI_CHU.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.GHI_CHU.Caption = "Ghi chú";
            this.GHI_CHU.FieldName = "GHI_CHU";
            this.GHI_CHU.Name = "GHI_CHU";
            this.GHI_CHU.OptionsColumn.AllowEdit = false;
            this.GHI_CHU.Visible = true;
            this.GHI_CHU.VisibleIndex = 11;
            // 
            // f365_quan_ly_nhan_vien_co_luong_cung_v2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 456);
            this.Controls.Add(this.m_grc_luong_cung_cua_nhan_vien);
            this.Controls.Add(this.panel3);
            this.Name = "f365_quan_ly_nhan_vien_co_luong_cung_v2";
            this.Text = "F365 - Quản lý Lương cứng";
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_DVMD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_luong_cung_cua_nhan_vien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_luong_cung_cua_nhan_vien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.SimpleButton m_cmd_insert;
        private DevExpress.XtraEditors.SimpleButton m_cmd_update;
        private DevExpress.XtraEditors.SimpleButton m_cmd_delete;
        private DevExpress.XtraEditors.SimpleButton m_cmd_xuat_excel;
        private DevExpress.XtraGrid.GridControl m_grc_luong_cung_cua_nhan_vien;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv_luong_cung_cua_nhan_vien;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn ID_NHAN_VIEN;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
        private DevExpress.XtraGrid.Columns.GridColumn MA_NV;
        private DevExpress.XtraGrid.Columns.GridColumn HO_DEM;
        private DevExpress.XtraGrid.Columns.GridColumn TEN;
        private DevExpress.XtraGrid.Columns.GridColumn SO_TIEN;
        private DevExpress.XtraGrid.Columns.GridColumn NGAY_BAT_DAU;
        private DevExpress.XtraGrid.Columns.GridColumn NGAY_KET_THUC;
        private DevExpress.XtraGrid.Columns.GridColumn NGAY_LAP;
        private DevExpress.XtraGrid.Columns.GridColumn NGUOI_LAP;
        private DevExpress.XtraGrid.Columns.GridColumn NGAY_SUA;
        private DevExpress.XtraGrid.Columns.GridColumn NGUOI_SUA;
        private DevExpress.XtraGrid.Columns.GridColumn GHI_CHU;
        private DevExpress.Utils.ImageCollection img_DVMD;
    }
}