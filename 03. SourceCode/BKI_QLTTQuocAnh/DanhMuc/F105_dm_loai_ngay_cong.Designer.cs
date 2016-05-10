namespace BKI_DichVuMatDat.DanhMuc
{
    partial class F105_dm_loai_ngay_cong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F105_dm_loai_ngay_cong));
            this.m_grc_dm_loai_ngay_cong = new DevExpress.XtraGrid.GridControl();
            this.m_grv_dm_loai_ngay_cong = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MA_NGAY_CONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TEN_NGAY_CONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TI_LE_LNS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TI_LE_LCD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_cmd_insert = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_xuat_excel = new DevExpress.XtraEditors.SimpleButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.img_DVMD = new DevExpress.Utils.ImageCollection(this.components);
            this.m_cmd_update = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_delete = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_dm_loai_ngay_cong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_dm_loai_ngay_cong)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_DVMD)).BeginInit();
            this.SuspendLayout();
            // 
            // m_grc_dm_loai_ngay_cong
            // 
            this.m_grc_dm_loai_ngay_cong.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_dm_loai_ngay_cong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc_dm_loai_ngay_cong.Location = new System.Drawing.Point(0, 33);
            this.m_grc_dm_loai_ngay_cong.MainView = this.m_grv_dm_loai_ngay_cong;
            this.m_grc_dm_loai_ngay_cong.Name = "m_grc_dm_loai_ngay_cong";
            this.m_grc_dm_loai_ngay_cong.Size = new System.Drawing.Size(961, 464);
            this.m_grc_dm_loai_ngay_cong.TabIndex = 3;
            this.m_grc_dm_loai_ngay_cong.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv_dm_loai_ngay_cong});
            // 
            // m_grv_dm_loai_ngay_cong
            // 
            this.m_grv_dm_loai_ngay_cong.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.STT,
            this.MA_NGAY_CONG,
            this.TEN_NGAY_CONG,
            this.TI_LE_LNS,
            this.TI_LE_LCD});
            this.m_grv_dm_loai_ngay_cong.GridControl = this.m_grc_dm_loai_ngay_cong;
            this.m_grv_dm_loai_ngay_cong.Name = "m_grv_dm_loai_ngay_cong";
            this.m_grv_dm_loai_ngay_cong.OptionsFind.AllowFindPanel = false;
            this.m_grv_dm_loai_ngay_cong.OptionsFind.AlwaysVisible = true;
            this.m_grv_dm_loai_ngay_cong.OptionsView.ShowFooter = true;
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
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
            this.STT.Visible = true;
            this.STT.VisibleIndex = 0;
            this.STT.Width = 38;
            // 
            // MA_NGAY_CONG
            // 
            this.MA_NGAY_CONG.AppearanceHeader.Options.UseTextOptions = true;
            this.MA_NGAY_CONG.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.MA_NGAY_CONG.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.MA_NGAY_CONG.Caption = "Mã ngày công";
            this.MA_NGAY_CONG.FieldName = "MA_NGAY_CONG";
            this.MA_NGAY_CONG.Name = "MA_NGAY_CONG";
            this.MA_NGAY_CONG.Visible = true;
            this.MA_NGAY_CONG.VisibleIndex = 1;
            this.MA_NGAY_CONG.Width = 91;
            // 
            // TEN_NGAY_CONG
            // 
            this.TEN_NGAY_CONG.AppearanceHeader.Options.UseTextOptions = true;
            this.TEN_NGAY_CONG.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TEN_NGAY_CONG.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.TEN_NGAY_CONG.Caption = "Tên ngày công";
            this.TEN_NGAY_CONG.FieldName = "TEN_NGAY_CONG";
            this.TEN_NGAY_CONG.Name = "TEN_NGAY_CONG";
            this.TEN_NGAY_CONG.Visible = true;
            this.TEN_NGAY_CONG.VisibleIndex = 2;
            this.TEN_NGAY_CONG.Width = 243;
            // 
            // TI_LE_LNS
            // 
            this.TI_LE_LNS.AppearanceCell.Options.UseTextOptions = true;
            this.TI_LE_LNS.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TI_LE_LNS.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.TI_LE_LNS.AppearanceHeader.Options.UseTextOptions = true;
            this.TI_LE_LNS.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TI_LE_LNS.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.TI_LE_LNS.Caption = "Tỉ lệ LNS";
            this.TI_LE_LNS.FieldName = "TI_LE_LNS";
            this.TI_LE_LNS.Name = "TI_LE_LNS";
            this.TI_LE_LNS.Visible = true;
            this.TI_LE_LNS.VisibleIndex = 3;
            this.TI_LE_LNS.Width = 246;
            // 
            // TI_LE_LCD
            // 
            this.TI_LE_LCD.AppearanceCell.Options.UseTextOptions = true;
            this.TI_LE_LCD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TI_LE_LCD.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.TI_LE_LCD.AppearanceHeader.Options.UseTextOptions = true;
            this.TI_LE_LCD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TI_LE_LCD.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.TI_LE_LCD.Caption = "Tỉ lệ LCĐ";
            this.TI_LE_LCD.FieldName = "TI_LE_LCD";
            this.TI_LE_LCD.Name = "TI_LE_LCD";
            this.TI_LE_LCD.Visible = true;
            this.TI_LE_LCD.VisibleIndex = 4;
            this.TI_LE_LCD.Width = 270;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_cmd_delete);
            this.panel1.Controls.Add(this.m_cmd_update);
            this.panel1.Controls.Add(this.m_cmd_insert);
            this.panel1.Controls.Add(this.m_cmd_xuat_excel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(961, 33);
            this.panel1.TabIndex = 5;
            // 
            // m_cmd_insert
            // 
            this.m_cmd_insert.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_insert.ImageIndex = 7;
            this.m_cmd_insert.ImageList = this.img_DVMD;
            this.m_cmd_insert.Location = new System.Drawing.Point(0, 0);
            this.m_cmd_insert.Name = "m_cmd_insert";
            this.m_cmd_insert.Size = new System.Drawing.Size(72, 33);
            this.m_cmd_insert.TabIndex = 30;
            this.m_cmd_insert.Text = "&Thêm";
            this.m_cmd_insert.Click += new System.EventHandler(this.m_cmd_insert_Click);
            // 
            // m_cmd_xuat_excel
            // 
            this.m_cmd_xuat_excel.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_xuat_excel.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_xuat_excel.Image")));
            this.m_cmd_xuat_excel.Location = new System.Drawing.Point(845, 0);
            this.m_cmd_xuat_excel.Name = "m_cmd_xuat_excel";
            this.m_cmd_xuat_excel.Size = new System.Drawing.Size(116, 33);
            this.m_cmd_xuat_excel.TabIndex = 27;
            this.m_cmd_xuat_excel.Text = "&Xuất Excel";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "");
            this.imageList1.Images.SetKeyName(3, "");
            this.imageList1.Images.SetKeyName(4, "");
            this.imageList1.Images.SetKeyName(5, "");
            this.imageList1.Images.SetKeyName(6, "");
            this.imageList1.Images.SetKeyName(7, "");
            this.imageList1.Images.SetKeyName(8, "");
            this.imageList1.Images.SetKeyName(9, "");
            this.imageList1.Images.SetKeyName(10, "");
            this.imageList1.Images.SetKeyName(11, "");
            this.imageList1.Images.SetKeyName(12, "");
            this.imageList1.Images.SetKeyName(13, "");
            this.imageList1.Images.SetKeyName(14, "");
            this.imageList1.Images.SetKeyName(15, "");
            this.imageList1.Images.SetKeyName(16, "");
            this.imageList1.Images.SetKeyName(17, "");
            this.imageList1.Images.SetKeyName(18, "");
            this.imageList1.Images.SetKeyName(19, "");
            this.imageList1.Images.SetKeyName(20, "");
            this.imageList1.Images.SetKeyName(21, "");
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
            // m_cmd_update
            // 
            this.m_cmd_update.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_update.ImageIndex = 9;
            this.m_cmd_update.ImageList = this.img_DVMD;
            this.m_cmd_update.Location = new System.Drawing.Point(72, 0);
            this.m_cmd_update.Name = "m_cmd_update";
            this.m_cmd_update.Size = new System.Drawing.Size(70, 33);
            this.m_cmd_update.TabIndex = 32;
            this.m_cmd_update.Text = "&Sửa";
            // 
            // m_cmd_delete
            // 
            this.m_cmd_delete.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_delete.ImageIndex = 8;
            this.m_cmd_delete.ImageList = this.img_DVMD;
            this.m_cmd_delete.Location = new System.Drawing.Point(142, 0);
            this.m_cmd_delete.Name = "m_cmd_delete";
            this.m_cmd_delete.Size = new System.Drawing.Size(71, 33);
            this.m_cmd_delete.TabIndex = 33;
            this.m_cmd_delete.Text = "&Xóa";
            // 
            // F105_dm_loai_ngay_cong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 497);
            this.Controls.Add(this.m_grc_dm_loai_ngay_cong);
            this.Controls.Add(this.panel1);
            this.Name = "F105_dm_loai_ngay_cong";
            this.Text = "F105 - Danh mục loại ngày công";
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_dm_loai_ngay_cong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_dm_loai_ngay_cong)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_DVMD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl m_grc_dm_loai_ngay_cong;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv_dm_loai_ngay_cong;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
        private DevExpress.XtraGrid.Columns.GridColumn MA_NGAY_CONG;
        private DevExpress.XtraGrid.Columns.GridColumn TEN_NGAY_CONG;
        private DevExpress.XtraGrid.Columns.GridColumn TI_LE_LNS;
        private DevExpress.XtraGrid.Columns.GridColumn TI_LE_LCD;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraEditors.SimpleButton m_cmd_insert;
        private DevExpress.XtraEditors.SimpleButton m_cmd_xuat_excel;
        private DevExpress.Utils.ImageCollection img_DVMD;
        private DevExpress.XtraEditors.SimpleButton m_cmd_delete;
        private DevExpress.XtraEditors.SimpleButton m_cmd_update;
    }
}