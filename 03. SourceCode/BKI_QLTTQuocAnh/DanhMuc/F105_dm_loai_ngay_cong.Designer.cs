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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F105_dm_loai_ngay_cong));
            this.m_lbl_header = new System.Windows.Forms.Label();
            this.m_grc_dm_loai_ngay_cong = new DevExpress.XtraGrid.GridControl();
            this.m_grv_dm_loai_ngay_cong = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MA_NGAY_CONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TEN_NGAY_CONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TI_LE_LNS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TI_LE_LCD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_cmd_delete = new SIS.Controls.Button.SiSButton();
            this.imageList1 = new System.Windows.Forms.ImageList();
            this.m_cmd_update = new SIS.Controls.Button.SiSButton();
            this.m_cmd_insert = new SIS.Controls.Button.SiSButton();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_dm_loai_ngay_cong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_dm_loai_ngay_cong)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_lbl_header
            // 
            this.m_lbl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.m_lbl_header.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_header.Location = new System.Drawing.Point(0, 0);
            this.m_lbl_header.Name = "m_lbl_header";
            this.m_lbl_header.Size = new System.Drawing.Size(961, 41);
            this.m_lbl_header.TabIndex = 4;
            this.m_lbl_header.Text = "LƯƠNG CHẾ ĐỘ NHÂN VIÊN";
            this.m_lbl_header.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // m_grc_dm_loai_ngay_cong
            // 
            this.m_grc_dm_loai_ngay_cong.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_dm_loai_ngay_cong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc_dm_loai_ngay_cong.Location = new System.Drawing.Point(0, 49);
            this.m_grc_dm_loai_ngay_cong.MainView = this.m_grv_dm_loai_ngay_cong;
            this.m_grc_dm_loai_ngay_cong.Name = "m_grc_dm_loai_ngay_cong";
            this.m_grc_dm_loai_ngay_cong.Size = new System.Drawing.Size(961, 409);
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
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 458);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(961, 39);
            this.panel1.TabIndex = 5;
            // 
            // m_cmd_delete
            // 
            this.m_cmd_delete.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_delete.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_delete.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_delete.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_delete.ImageIndex = 4;
            this.m_cmd_delete.ImageList = this.imageList1;
            this.m_cmd_delete.Location = new System.Drawing.Point(172, 0);
            this.m_cmd_delete.Name = "m_cmd_delete";
            this.m_cmd_delete.Size = new System.Drawing.Size(86, 39);
            this.m_cmd_delete.TabIndex = 3;
            this.m_cmd_delete.Text = "&Xóa";
            this.m_cmd_delete.Click += new System.EventHandler(this.m_cmd_delete_Click);
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
            this.m_cmd_update.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_update.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_update.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_update.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_update.ImageIndex = 16;
            this.m_cmd_update.ImageList = this.imageList1;
            this.m_cmd_update.Location = new System.Drawing.Point(86, 0);
            this.m_cmd_update.Name = "m_cmd_update";
            this.m_cmd_update.Size = new System.Drawing.Size(86, 39);
            this.m_cmd_update.TabIndex = 2;
            this.m_cmd_update.Text = "&Sửa";
            this.m_cmd_update.Click += new System.EventHandler(this.m_cmd_update_Click);
            // 
            // m_cmd_insert
            // 
            this.m_cmd_insert.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_insert.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_insert.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_insert.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_insert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_insert.ImageIndex = 3;
            this.m_cmd_insert.ImageList = this.imageList1;
            this.m_cmd_insert.Location = new System.Drawing.Point(0, 0);
            this.m_cmd_insert.Name = "m_cmd_insert";
            this.m_cmd_insert.Size = new System.Drawing.Size(86, 39);
            this.m_cmd_insert.TabIndex = 1;
            this.m_cmd_insert.Text = "&Thêm";
            this.m_cmd_insert.Click += new System.EventHandler(this.m_cmd_insert_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.m_lbl_header);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(961, 49);
            this.panel2.TabIndex = 6;
            // 
            // F105_dm_loai_ngay_cong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 497);
            this.Controls.Add(this.m_grc_dm_loai_ngay_cong);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "F105_dm_loai_ngay_cong";
            this.Text = "F105 - DANH MỤC LOẠI NGÀY CÔNG";
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_dm_loai_ngay_cong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_dm_loai_ngay_cong)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label m_lbl_header;
        private DevExpress.XtraGrid.GridControl m_grc_dm_loai_ngay_cong;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv_dm_loai_ngay_cong;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
        private DevExpress.XtraGrid.Columns.GridColumn MA_NGAY_CONG;
        private DevExpress.XtraGrid.Columns.GridColumn TEN_NGAY_CONG;
        private DevExpress.XtraGrid.Columns.GridColumn TI_LE_LNS;
        private DevExpress.XtraGrid.Columns.GridColumn TI_LE_LCD;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        internal SIS.Controls.Button.SiSButton m_cmd_insert;
        internal System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        internal SIS.Controls.Button.SiSButton m_cmd_delete;
        internal SIS.Controls.Button.SiSButton m_cmd_update;
    }
}