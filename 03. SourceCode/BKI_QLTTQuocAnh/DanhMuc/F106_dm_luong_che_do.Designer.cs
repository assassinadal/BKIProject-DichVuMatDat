namespace BKI_DichVuMatDat.DanhMuc
{
    partial class F106_dm_luong_che_do
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F106_dm_luong_che_do));
            this.m_grc_dm_luong_che_do = new DevExpress.XtraGrid.GridControl();
            this.m_grv_dm_luong_che_do = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_ma_lcd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_muc_lcd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_so_tien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.m_cmd_insert = new DevExpress.XtraEditors.SimpleButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.m_cmd_update = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_delete = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_xuat_excel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_dm_luong_che_do)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_dm_luong_che_do)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_grc_dm_luong_che_do
            // 
            this.m_grc_dm_luong_che_do.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_dm_luong_che_do.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc_dm_luong_che_do.Location = new System.Drawing.Point(0, 0);
            this.m_grc_dm_luong_che_do.MainView = this.m_grv_dm_luong_che_do;
            this.m_grc_dm_luong_che_do.Name = "m_grc_dm_luong_che_do";
            this.m_grc_dm_luong_che_do.Size = new System.Drawing.Size(730, 359);
            this.m_grc_dm_luong_che_do.TabIndex = 0;
            this.m_grc_dm_luong_che_do.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv_dm_luong_che_do});
            // 
            // m_grv_dm_luong_che_do
            // 
            this.m_grv_dm_luong_che_do.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.STT,
            this.c_ma_lcd,
            this.c_muc_lcd,
            this.c_so_tien});
            this.m_grv_dm_luong_che_do.GridControl = this.m_grc_dm_luong_che_do;
            this.m_grv_dm_luong_che_do.Name = "m_grv_dm_luong_che_do";
            this.m_grv_dm_luong_che_do.OptionsFind.AlwaysVisible = true;
            // 
            // ID
            // 
            this.ID.AppearanceHeader.Options.UseTextOptions = true;
            this.ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
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
            // c_ma_lcd
            // 
            this.c_ma_lcd.AppearanceCell.Options.UseTextOptions = true;
            this.c_ma_lcd.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.c_ma_lcd.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.c_ma_lcd.AppearanceHeader.Options.UseTextOptions = true;
            this.c_ma_lcd.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.c_ma_lcd.Caption = "Mã Lương CĐ";
            this.c_ma_lcd.FieldName = "MA_LCD";
            this.c_ma_lcd.Name = "c_ma_lcd";
            this.c_ma_lcd.Visible = true;
            this.c_ma_lcd.VisibleIndex = 1;
            this.c_ma_lcd.Width = 224;
            // 
            // c_muc_lcd
            // 
            this.c_muc_lcd.AppearanceCell.Options.UseTextOptions = true;
            this.c_muc_lcd.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.c_muc_lcd.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.c_muc_lcd.AppearanceHeader.Options.UseTextOptions = true;
            this.c_muc_lcd.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.c_muc_lcd.Caption = "Mức Lương CĐ";
            this.c_muc_lcd.FieldName = "MUC_LCD";
            this.c_muc_lcd.Name = "c_muc_lcd";
            this.c_muc_lcd.Visible = true;
            this.c_muc_lcd.VisibleIndex = 2;
            this.c_muc_lcd.Width = 224;
            // 
            // c_so_tien
            // 
            this.c_so_tien.AppearanceCell.Options.UseTextOptions = true;
            this.c_so_tien.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.c_so_tien.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.c_so_tien.AppearanceHeader.Options.UseTextOptions = true;
            this.c_so_tien.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.c_so_tien.Caption = "Số tiền";
            this.c_so_tien.DisplayFormat.FormatString = "{0:#,##0}";
            this.c_so_tien.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.c_so_tien.FieldName = "SO_TIEN";
            this.c_so_tien.Name = "c_so_tien";
            this.c_so_tien.Visible = true;
            this.c_so_tien.VisibleIndex = 3;
            this.c_so_tien.Width = 226;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.m_cmd_xuat_excel);
            this.panel2.Controls.Add(this.m_cmd_delete);
            this.panel2.Controls.Add(this.m_cmd_update);
            this.panel2.Controls.Add(this.m_cmd_insert);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(730, 41);
            this.panel2.TabIndex = 3;
            // 
            // m_cmd_insert
            // 
            this.m_cmd_insert.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_insert.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_insert.Image")));
            this.m_cmd_insert.Location = new System.Drawing.Point(0, 0);
            this.m_cmd_insert.Name = "m_cmd_insert";
            this.m_cmd_insert.Size = new System.Drawing.Size(116, 41);
            this.m_cmd_insert.TabIndex = 38;
            this.m_cmd_insert.Text = "&Thêm";
            this.m_cmd_insert.Click += new System.EventHandler(this.m_cmd_insert_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.m_grc_dm_luong_che_do);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(730, 359);
            this.panel3.TabIndex = 4;
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
            // m_cmd_update
            // 
            this.m_cmd_update.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_update.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_update.Image")));
            this.m_cmd_update.Location = new System.Drawing.Point(116, 0);
            this.m_cmd_update.Name = "m_cmd_update";
            this.m_cmd_update.Size = new System.Drawing.Size(116, 41);
            this.m_cmd_update.TabIndex = 39;
            this.m_cmd_update.Text = "&Sửa";
            // 
            // m_cmd_delete
            // 
            this.m_cmd_delete.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_delete.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_delete.Image")));
            this.m_cmd_delete.Location = new System.Drawing.Point(232, 0);
            this.m_cmd_delete.Name = "m_cmd_delete";
            this.m_cmd_delete.Size = new System.Drawing.Size(116, 41);
            this.m_cmd_delete.TabIndex = 40;
            this.m_cmd_delete.Text = "&Xóa";
            // 
            // m_cmd_xuat_excel
            // 
            this.m_cmd_xuat_excel.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_xuat_excel.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_xuat_excel.Image")));
            this.m_cmd_xuat_excel.Location = new System.Drawing.Point(348, 0);
            this.m_cmd_xuat_excel.Name = "m_cmd_xuat_excel";
            this.m_cmd_xuat_excel.Size = new System.Drawing.Size(116, 41);
            this.m_cmd_xuat_excel.TabIndex = 41;
            this.m_cmd_xuat_excel.Text = "&Xuất Excel";
            this.m_cmd_xuat_excel.Visible = false;
            // 
            // F106_dm_luong_che_do
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 400);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "F106_dm_luong_che_do";
            this.Text = "F106 - DANH MỤC LƯƠNG CHẾ ĐỘ";
            this.Load += new System.EventHandler(this.F106_dm_luong_che_do_Load);
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_dm_luong_che_do)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_dm_luong_che_do)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl m_grc_dm_luong_che_do;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv_dm_luong_che_do;
        private DevExpress.XtraGrid.Columns.GridColumn c_ma_lcd;
        private DevExpress.XtraGrid.Columns.GridColumn c_muc_lcd;
        private DevExpress.XtraGrid.Columns.GridColumn c_so_tien;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraEditors.SimpleButton m_cmd_insert;
        internal System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraEditors.SimpleButton m_cmd_xuat_excel;
        private DevExpress.XtraEditors.SimpleButton m_cmd_delete;
        private DevExpress.XtraEditors.SimpleButton m_cmd_update;
    }
}