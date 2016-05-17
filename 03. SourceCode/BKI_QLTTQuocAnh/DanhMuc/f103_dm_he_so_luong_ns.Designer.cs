namespace BKI_DichVuMatDat.DanhMuc
{
    partial class F103_dm_he_so_luong_ns
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F103_dm_he_so_luong_ns));
            this.m_grc_dm_he_so_luong_ns = new DevExpress.XtraGrid.GridControl();
            this.m_grv_dm_he_so_luong_ns = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_ma_luong_ns = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_muc_luong_ns = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_he_so = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_loai_lao_dong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_cmd_insert = new DevExpress.XtraEditors.SimpleButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.m_cmd_update = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_delete = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_xuat_excel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_dm_he_so_luong_ns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_dm_he_so_luong_ns)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_grc_dm_he_so_luong_ns
            // 
            this.m_grc_dm_he_so_luong_ns.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_dm_he_so_luong_ns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc_dm_he_so_luong_ns.Location = new System.Drawing.Point(0, 0);
            this.m_grc_dm_he_so_luong_ns.MainView = this.m_grv_dm_he_so_luong_ns;
            this.m_grc_dm_he_so_luong_ns.Name = "m_grc_dm_he_so_luong_ns";
            this.m_grc_dm_he_so_luong_ns.Size = new System.Drawing.Size(765, 312);
            this.m_grc_dm_he_so_luong_ns.TabIndex = 0;
            this.m_grc_dm_he_so_luong_ns.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv_dm_he_so_luong_ns});
            // 
            // m_grv_dm_he_so_luong_ns
            // 
            this.m_grv_dm_he_so_luong_ns.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.STT,
            this.c_ma_luong_ns,
            this.c_muc_luong_ns,
            this.c_he_so,
            this.c_loai_lao_dong});
            this.m_grv_dm_he_so_luong_ns.GridControl = this.m_grc_dm_he_so_luong_ns;
            this.m_grv_dm_he_so_luong_ns.Name = "m_grv_dm_he_so_luong_ns";
            this.m_grv_dm_he_so_luong_ns.OptionsFind.AllowFindPanel = false;
            this.m_grv_dm_he_so_luong_ns.OptionsFind.AlwaysVisible = true;
            this.m_grv_dm_he_so_luong_ns.OptionsView.ShowFooter = true;
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
            // c_ma_luong_ns
            // 
            this.c_ma_luong_ns.AppearanceCell.Options.UseTextOptions = true;
            this.c_ma_luong_ns.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.c_ma_luong_ns.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.c_ma_luong_ns.AppearanceHeader.Options.UseTextOptions = true;
            this.c_ma_luong_ns.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.c_ma_luong_ns.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.c_ma_luong_ns.Caption = "Mã Lương NS";
            this.c_ma_luong_ns.FieldName = "TEN_NGAN_LNS";
            this.c_ma_luong_ns.Name = "c_ma_luong_ns";
            this.c_ma_luong_ns.Visible = true;
            this.c_ma_luong_ns.VisibleIndex = 1;
            this.c_ma_luong_ns.Width = 120;
            // 
            // c_muc_luong_ns
            // 
            this.c_muc_luong_ns.AppearanceCell.Options.UseTextOptions = true;
            this.c_muc_luong_ns.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.c_muc_luong_ns.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.c_muc_luong_ns.AppearanceHeader.Options.UseTextOptions = true;
            this.c_muc_luong_ns.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.c_muc_luong_ns.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.c_muc_luong_ns.Caption = "Mức Lương NS";
            this.c_muc_luong_ns.FieldName = "MUC_LNS";
            this.c_muc_luong_ns.Name = "c_muc_luong_ns";
            this.c_muc_luong_ns.Visible = true;
            this.c_muc_luong_ns.VisibleIndex = 2;
            this.c_muc_luong_ns.Width = 120;
            // 
            // c_he_so
            // 
            this.c_he_so.AppearanceCell.Options.UseTextOptions = true;
            this.c_he_so.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.c_he_so.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.c_he_so.AppearanceHeader.Options.UseTextOptions = true;
            this.c_he_so.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.c_he_so.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.c_he_so.Caption = "Hệ số";
            this.c_he_so.FieldName = "HE_SO";
            this.c_he_so.Name = "c_he_so";
            this.c_he_so.Visible = true;
            this.c_he_so.VisibleIndex = 3;
            this.c_he_so.Width = 150;
            // 
            // c_loai_lao_dong
            // 
            this.c_loai_lao_dong.AppearanceHeader.Options.UseTextOptions = true;
            this.c_loai_lao_dong.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.c_loai_lao_dong.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.c_loai_lao_dong.Caption = "Loại Lao Động";
            this.c_loai_lao_dong.FieldName = "TEN";
            this.c_loai_lao_dong.Name = "c_loai_lao_dong";
            this.c_loai_lao_dong.Width = 319;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_cmd_xuat_excel);
            this.panel1.Controls.Add(this.m_cmd_delete);
            this.panel1.Controls.Add(this.m_cmd_update);
            this.panel1.Controls.Add(this.m_cmd_insert);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(765, 41);
            this.panel1.TabIndex = 2;
            // 
            // m_cmd_insert
            // 
            this.m_cmd_insert.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_insert.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_insert.Image")));
            this.m_cmd_insert.Location = new System.Drawing.Point(0, 0);
            this.m_cmd_insert.Name = "m_cmd_insert";
            this.m_cmd_insert.Size = new System.Drawing.Size(116, 41);
            this.m_cmd_insert.TabIndex = 34;
            this.m_cmd_insert.Text = "&Thêm";
            this.m_cmd_insert.Click += new System.EventHandler(this.m_cmd_insert_Click);
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
            // panel2
            // 
            this.panel2.Controls.Add(this.m_grc_dm_he_so_luong_ns);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(765, 312);
            this.panel2.TabIndex = 3;
            // 
            // m_cmd_update
            // 
            this.m_cmd_update.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_update.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_update.Image")));
            this.m_cmd_update.Location = new System.Drawing.Point(116, 0);
            this.m_cmd_update.Name = "m_cmd_update";
            this.m_cmd_update.Size = new System.Drawing.Size(116, 41);
            this.m_cmd_update.TabIndex = 35;
            this.m_cmd_update.Text = "&Sửa";
            // 
            // m_cmd_delete
            // 
            this.m_cmd_delete.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_delete.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_delete.Image")));
            this.m_cmd_delete.Location = new System.Drawing.Point(232, 0);
            this.m_cmd_delete.Name = "m_cmd_delete";
            this.m_cmd_delete.Size = new System.Drawing.Size(116, 41);
            this.m_cmd_delete.TabIndex = 36;
            this.m_cmd_delete.Text = "&Xóa";
            // 
            // m_cmd_xuat_excel
            // 
            this.m_cmd_xuat_excel.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_xuat_excel.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_xuat_excel.Image")));
            this.m_cmd_xuat_excel.Location = new System.Drawing.Point(348, 0);
            this.m_cmd_xuat_excel.Name = "m_cmd_xuat_excel";
            this.m_cmd_xuat_excel.Size = new System.Drawing.Size(116, 41);
            this.m_cmd_xuat_excel.TabIndex = 37;
            this.m_cmd_xuat_excel.Text = "&Xuất Excel";
            this.m_cmd_xuat_excel.Visible = false;
            // 
            // F103_dm_he_so_luong_ns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 353);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "F103_dm_he_so_luong_ns";
            this.Text = "F103 - DANH MỤC HỆ SỐ LƯƠNG NĂNG SUẤT";
            this.Load += new System.EventHandler(this.F103_dm_he_so_luong_ns_Load);
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_dm_he_so_luong_ns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_dm_he_so_luong_ns)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

      
        #endregion

        private DevExpress.XtraGrid.GridControl m_grc_dm_he_so_luong_ns;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv_dm_he_so_luong_ns;
        private DevExpress.XtraGrid.Columns.GridColumn c_ma_luong_ns;
        private DevExpress.XtraGrid.Columns.GridColumn c_muc_luong_ns;
        private DevExpress.XtraGrid.Columns.GridColumn c_he_so;
        private DevExpress.XtraGrid.Columns.GridColumn c_loai_lao_dong;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton m_cmd_insert;
        internal System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraEditors.SimpleButton m_cmd_xuat_excel;
        private DevExpress.XtraEditors.SimpleButton m_cmd_delete;
        private DevExpress.XtraEditors.SimpleButton m_cmd_update;
    }
}