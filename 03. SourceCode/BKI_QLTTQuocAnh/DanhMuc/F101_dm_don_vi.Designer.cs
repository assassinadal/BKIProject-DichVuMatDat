namespace BKI_DichVuMatDat.DanhMuc
{
    partial class F101_dm_don_vi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F101_dm_don_vi));
            this.m_grc_dm_don_vi = new DevExpress.XtraGrid.GridControl();
            this.m_grv_dm_don_vi = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_ma_don_vi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_ten_don_vi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.C_ten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_ma_don_vi_cap_tren = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_ten_don_vi_cap_tren = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.m_lbl_header = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.c_cmd_dm_don_vi_xoa = new SIS.Controls.Button.SiSButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.c_cmd_dm_don_vi_sua = new SIS.Controls.Button.SiSButton();
            this.m_cmd_dm_don_vi_them = new SIS.Controls.Button.SiSButton();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_dm_don_vi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_dm_don_vi)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_grc_dm_don_vi
            // 
            this.m_grc_dm_don_vi.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_dm_don_vi.Location = new System.Drawing.Point(0, 47);
            this.m_grc_dm_don_vi.MainView = this.m_grv_dm_don_vi;
            this.m_grc_dm_don_vi.Name = "m_grc_dm_don_vi";
            this.m_grc_dm_don_vi.Size = new System.Drawing.Size(879, 208);
            this.m_grc_dm_don_vi.TabIndex = 0;
            this.m_grc_dm_don_vi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv_dm_don_vi});
            // 
            // m_grv_dm_don_vi
            // 
            this.m_grv_dm_don_vi.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.STT,
            this.c_ma_don_vi,
            this.c_ten_don_vi,
            this.C_ten,
            this.c_ma_don_vi_cap_tren,
            this.c_ten_don_vi_cap_tren,
            this.gridColumn1});
            this.m_grv_dm_don_vi.CustomizationFormBounds = new System.Drawing.Rectangle(723, 270, 210, 172);
            this.m_grv_dm_don_vi.GridControl = this.m_grc_dm_don_vi;
            this.m_grv_dm_don_vi.Name = "m_grv_dm_don_vi";
            this.m_grv_dm_don_vi.OptionsView.ShowGroupPanel = false;
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
            // c_ma_don_vi
            // 
            this.c_ma_don_vi.AppearanceCell.Options.UseTextOptions = true;
            this.c_ma_don_vi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.c_ma_don_vi.AppearanceHeader.Options.UseTextOptions = true;
            this.c_ma_don_vi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.c_ma_don_vi.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.c_ma_don_vi.Caption = "Mã đơn vị";
            this.c_ma_don_vi.FieldName = "MA_DON_VI";
            this.c_ma_don_vi.Name = "c_ma_don_vi";
            this.c_ma_don_vi.Visible = true;
            this.c_ma_don_vi.VisibleIndex = 1;
            this.c_ma_don_vi.Width = 83;
            // 
            // c_ten_don_vi
            // 
            this.c_ten_don_vi.AppearanceHeader.Options.UseTextOptions = true;
            this.c_ten_don_vi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.c_ten_don_vi.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.c_ten_don_vi.Caption = "Tên dơn vị";
            this.c_ten_don_vi.FieldName = "TEN_DON_VI";
            this.c_ten_don_vi.Name = "c_ten_don_vi";
            this.c_ten_don_vi.Visible = true;
            this.c_ten_don_vi.VisibleIndex = 2;
            this.c_ten_don_vi.Width = 87;
            // 
            // C_ten
            // 
            this.C_ten.AppearanceHeader.Options.UseTextOptions = true;
            this.C_ten.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.C_ten.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.C_ten.Caption = "Tên";
            this.C_ten.FieldName = "TEN";
            this.C_ten.Name = "C_ten";
            this.C_ten.Visible = true;
            this.C_ten.VisibleIndex = 3;
            this.C_ten.Width = 87;
            // 
            // c_ma_don_vi_cap_tren
            // 
            this.c_ma_don_vi_cap_tren.AppearanceHeader.Options.UseTextOptions = true;
            this.c_ma_don_vi_cap_tren.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.c_ma_don_vi_cap_tren.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.c_ma_don_vi_cap_tren.Caption = "Mã đơn vị cấp trên";
            this.c_ma_don_vi_cap_tren.FieldName = "MA_DON_VI_CAP_TREN";
            this.c_ma_don_vi_cap_tren.Name = "c_ma_don_vi_cap_tren";
            this.c_ma_don_vi_cap_tren.Visible = true;
            this.c_ma_don_vi_cap_tren.VisibleIndex = 4;
            this.c_ma_don_vi_cap_tren.Width = 87;
            // 
            // c_ten_don_vi_cap_tren
            // 
            this.c_ten_don_vi_cap_tren.AppearanceHeader.Options.UseTextOptions = true;
            this.c_ten_don_vi_cap_tren.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.c_ten_don_vi_cap_tren.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.c_ten_don_vi_cap_tren.Caption = "Tên đơn vị cấp trên";
            this.c_ten_don_vi_cap_tren.FieldName = "TEN_DON_VI_CAP_TREN";
            this.c_ten_don_vi_cap_tren.Name = "c_ten_don_vi_cap_tren";
            this.c_ten_don_vi_cap_tren.Visible = true;
            this.c_ten_don_vi_cap_tren.VisibleIndex = 5;
            this.c_ten_don_vi_cap_tren.Width = 97;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "ID";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // m_lbl_header
            // 
            this.m_lbl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.m_lbl_header.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_header.Location = new System.Drawing.Point(0, 0);
            this.m_lbl_header.Name = "m_lbl_header";
            this.m_lbl_header.Size = new System.Drawing.Size(879, 44);
            this.m_lbl_header.TabIndex = 1;
            this.m_lbl_header.Text = "DANH MỤC ĐƠN VỊ";
            this.m_lbl_header.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.c_cmd_dm_don_vi_xoa);
            this.panel1.Controls.Add(this.c_cmd_dm_don_vi_sua);
            this.panel1.Controls.Add(this.m_cmd_dm_don_vi_them);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 252);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(879, 39);
            this.panel1.TabIndex = 2;
            // 
            // c_cmd_dm_don_vi_xoa
            // 
            this.c_cmd_dm_don_vi_xoa.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.c_cmd_dm_don_vi_xoa.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.c_cmd_dm_don_vi_xoa.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.c_cmd_dm_don_vi_xoa.Dock = System.Windows.Forms.DockStyle.Left;
            this.c_cmd_dm_don_vi_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.c_cmd_dm_don_vi_xoa.ImageIndex = 4;
            this.c_cmd_dm_don_vi_xoa.ImageList = this.imageList1;
            this.c_cmd_dm_don_vi_xoa.Location = new System.Drawing.Point(246, 0);
            this.c_cmd_dm_don_vi_xoa.Name = "c_cmd_dm_don_vi_xoa";
            this.c_cmd_dm_don_vi_xoa.Size = new System.Drawing.Size(123, 39);
            this.c_cmd_dm_don_vi_xoa.TabIndex = 6;
            this.c_cmd_dm_don_vi_xoa.Text = "&Xóa";
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
            // c_cmd_dm_don_vi_sua
            // 
            this.c_cmd_dm_don_vi_sua.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.c_cmd_dm_don_vi_sua.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.c_cmd_dm_don_vi_sua.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.c_cmd_dm_don_vi_sua.Dock = System.Windows.Forms.DockStyle.Left;
            this.c_cmd_dm_don_vi_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.c_cmd_dm_don_vi_sua.ImageIndex = 16;
            this.c_cmd_dm_don_vi_sua.ImageList = this.imageList1;
            this.c_cmd_dm_don_vi_sua.Location = new System.Drawing.Point(123, 0);
            this.c_cmd_dm_don_vi_sua.Name = "c_cmd_dm_don_vi_sua";
            this.c_cmd_dm_don_vi_sua.Size = new System.Drawing.Size(123, 39);
            this.c_cmd_dm_don_vi_sua.TabIndex = 5;
            this.c_cmd_dm_don_vi_sua.Text = "&Sửa";
            // 
            // m_cmd_dm_don_vi_them
            // 
            this.m_cmd_dm_don_vi_them.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_dm_don_vi_them.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_dm_don_vi_them.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_dm_don_vi_them.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_dm_don_vi_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_dm_don_vi_them.ImageIndex = 3;
            this.m_cmd_dm_don_vi_them.ImageList = this.imageList1;
            this.m_cmd_dm_don_vi_them.Location = new System.Drawing.Point(0, 0);
            this.m_cmd_dm_don_vi_them.Name = "m_cmd_dm_don_vi_them";
            this.m_cmd_dm_don_vi_them.Size = new System.Drawing.Size(123, 39);
            this.m_cmd_dm_don_vi_them.TabIndex = 4;
            this.m_cmd_dm_don_vi_them.Text = "&Thêm";
            // 
            // F101_dm_don_vi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 291);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.m_lbl_header);
            this.Controls.Add(this.m_grc_dm_don_vi);
            this.Name = "F101_dm_don_vi";
            this.Text = "F101-DANH MỤC ĐƠN VỊ";
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_dm_don_vi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_dm_don_vi)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl m_grc_dm_don_vi;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv_dm_don_vi;
        private DevExpress.XtraGrid.Columns.GridColumn c_ma_don_vi;
        private DevExpress.XtraGrid.Columns.GridColumn c_ten_don_vi;
        private DevExpress.XtraGrid.Columns.GridColumn C_ten;
        private DevExpress.XtraGrid.Columns.GridColumn c_ma_don_vi_cap_tren;
        private DevExpress.XtraGrid.Columns.GridColumn c_ten_don_vi_cap_tren;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
        private System.Windows.Forms.Label m_lbl_header;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        internal SIS.Controls.Button.SiSButton c_cmd_dm_don_vi_xoa;
        internal System.Windows.Forms.ImageList imageList1;
        internal SIS.Controls.Button.SiSButton c_cmd_dm_don_vi_sua;
        internal SIS.Controls.Button.SiSButton m_cmd_dm_don_vi_them;
    }
}