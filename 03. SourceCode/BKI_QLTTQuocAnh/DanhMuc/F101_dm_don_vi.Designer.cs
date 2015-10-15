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
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_ma_don_vi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_ten_don_vi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_ten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_ma_don_vi_cap_tren = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_ten_don_vi_cap_tren = new DevExpress.XtraGrid.Columns.GridColumn();
            this.m_lbl_header = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_cmd_insert = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_update = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_delete = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_xuat_excel = new DevExpress.XtraEditors.SimpleButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_dm_don_vi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_dm_don_vi)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_grc_dm_don_vi
            // 
            this.m_grc_dm_don_vi.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_dm_don_vi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc_dm_don_vi.Location = new System.Drawing.Point(0, 0);
            this.m_grc_dm_don_vi.MainView = this.m_grv_dm_don_vi;
            this.m_grc_dm_don_vi.Name = "m_grc_dm_don_vi";
            this.m_grc_dm_don_vi.Size = new System.Drawing.Size(915, 294);
            this.m_grc_dm_don_vi.TabIndex = 0;
            this.m_grc_dm_don_vi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv_dm_don_vi});
            // 
            // m_grv_dm_don_vi
            // 
            this.m_grv_dm_don_vi.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.STT,
            this.c_ma_don_vi,
            this.c_ten_don_vi,
            this.c_ten,
            this.c_ma_don_vi_cap_tren,
            this.c_ten_don_vi_cap_tren});
            this.m_grv_dm_don_vi.CustomizationFormBounds = new System.Drawing.Rectangle(723, 270, 210, 172);
            this.m_grv_dm_don_vi.GridControl = this.m_grc_dm_don_vi;
            this.m_grv_dm_don_vi.Name = "m_grv_dm_don_vi";
            this.m_grv_dm_don_vi.OptionsFind.AllowFindPanel = false;
            this.m_grv_dm_don_vi.OptionsFind.AlwaysVisible = true;
            this.m_grv_dm_don_vi.OptionsView.ShowFooter = true;
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
            this.STT.OptionsColumn.AllowEdit = false;
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
            this.c_ma_don_vi.OptionsColumn.AllowEdit = false;
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
            this.c_ten_don_vi.OptionsColumn.AllowEdit = false;
            this.c_ten_don_vi.Visible = true;
            this.c_ten_don_vi.VisibleIndex = 2;
            this.c_ten_don_vi.Width = 87;
            // 
            // c_ten
            // 
            this.c_ten.AppearanceHeader.Options.UseTextOptions = true;
            this.c_ten.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.c_ten.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.c_ten.Caption = "Loại đơn vị";
            this.c_ten.FieldName = "TEN";
            this.c_ten.Name = "c_ten";
            this.c_ten.OptionsColumn.AllowEdit = false;
            this.c_ten.Visible = true;
            this.c_ten.VisibleIndex = 3;
            this.c_ten.Width = 87;
            // 
            // c_ma_don_vi_cap_tren
            // 
            this.c_ma_don_vi_cap_tren.AppearanceHeader.Options.UseTextOptions = true;
            this.c_ma_don_vi_cap_tren.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.c_ma_don_vi_cap_tren.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.c_ma_don_vi_cap_tren.Caption = "Mã đơn vị cấp trên";
            this.c_ma_don_vi_cap_tren.FieldName = "MA_DON_VI_CAP_TREN";
            this.c_ma_don_vi_cap_tren.Name = "c_ma_don_vi_cap_tren";
            this.c_ma_don_vi_cap_tren.OptionsColumn.AllowEdit = false;
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
            this.c_ten_don_vi_cap_tren.OptionsColumn.AllowEdit = false;
            this.c_ten_don_vi_cap_tren.Visible = true;
            this.c_ten_don_vi_cap_tren.VisibleIndex = 5;
            this.c_ten_don_vi_cap_tren.Width = 97;
            // 
            // m_lbl_header
            // 
            this.m_lbl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.m_lbl_header.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_header.Location = new System.Drawing.Point(0, 0);
            this.m_lbl_header.Name = "m_lbl_header";
            this.m_lbl_header.Size = new System.Drawing.Size(915, 40);
            this.m_lbl_header.TabIndex = 1;
            this.m_lbl_header.Text = "DANH MỤC ĐƠN VỊ";
            this.m_lbl_header.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_cmd_insert);
            this.panel1.Controls.Add(this.m_cmd_update);
            this.panel1.Controls.Add(this.m_cmd_delete);
            this.panel1.Controls.Add(this.m_cmd_xuat_excel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 333);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(915, 39);
            this.panel1.TabIndex = 2;
            // 
            // m_cmd_insert
            // 
            this.m_cmd_insert.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_insert.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_insert.Image")));
            this.m_cmd_insert.Location = new System.Drawing.Point(451, 0);
            this.m_cmd_insert.Name = "m_cmd_insert";
            this.m_cmd_insert.Size = new System.Drawing.Size(116, 39);
            this.m_cmd_insert.TabIndex = 26;
            this.m_cmd_insert.Text = "&Thêm";
            // 
            // m_cmd_update
            // 
            this.m_cmd_update.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_update.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_update.Image")));
            this.m_cmd_update.Location = new System.Drawing.Point(567, 0);
            this.m_cmd_update.Name = "m_cmd_update";
            this.m_cmd_update.Size = new System.Drawing.Size(116, 39);
            this.m_cmd_update.TabIndex = 25;
            this.m_cmd_update.Text = "&Sửa";
            // 
            // m_cmd_delete
            // 
            this.m_cmd_delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_delete.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_delete.Image")));
            this.m_cmd_delete.Location = new System.Drawing.Point(683, 0);
            this.m_cmd_delete.Name = "m_cmd_delete";
            this.m_cmd_delete.Size = new System.Drawing.Size(116, 39);
            this.m_cmd_delete.TabIndex = 24;
            this.m_cmd_delete.Text = "&Xóa";
            // 
            // m_cmd_xuat_excel
            // 
            this.m_cmd_xuat_excel.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_xuat_excel.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_xuat_excel.Image")));
            this.m_cmd_xuat_excel.Location = new System.Drawing.Point(799, 0);
            this.m_cmd_xuat_excel.Name = "m_cmd_xuat_excel";
            this.m_cmd_xuat_excel.Size = new System.Drawing.Size(116, 39);
            this.m_cmd_xuat_excel.TabIndex = 23;
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
            // panel4
            // 
            this.panel4.Controls.Add(this.m_lbl_header);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(915, 39);
            this.panel4.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.m_grc_dm_don_vi);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(915, 294);
            this.panel2.TabIndex = 5;
            // 
            // F101_dm_don_vi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 372);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "F101_dm_don_vi";
            this.Text = "F101-DANH MỤC ĐƠN VỊ";
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_dm_don_vi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_dm_don_vi)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl m_grc_dm_don_vi;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv_dm_don_vi;
        private DevExpress.XtraGrid.Columns.GridColumn c_ma_don_vi;
        private DevExpress.XtraGrid.Columns.GridColumn c_ten_don_vi;
        private DevExpress.XtraGrid.Columns.GridColumn c_ten;
        private DevExpress.XtraGrid.Columns.GridColumn c_ma_don_vi_cap_tren;
        private DevExpress.XtraGrid.Columns.GridColumn c_ten_don_vi_cap_tren;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
        private System.Windows.Forms.Label m_lbl_header;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        internal System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton m_cmd_insert;
        private DevExpress.XtraEditors.SimpleButton m_cmd_update;
        private DevExpress.XtraEditors.SimpleButton m_cmd_delete;
        private DevExpress.XtraEditors.SimpleButton m_cmd_xuat_excel;
    }
}