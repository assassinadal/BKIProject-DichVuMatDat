namespace BKI_DichVuMatDat.DanhMuc
{
    partial class F107_dm_phu_cap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F107_dm_phu_cap));
            this.m_grc_dm_phu_cap = new DevExpress.XtraGrid.GridControl();
            this.m_grv_dm_phu_cap = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_doi_tuong_huong_phu_cap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_ten_phu_cap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_ti_le = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_cmd_insert = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.m_cmd_update = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_delete = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_xuat_excel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_dm_phu_cap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_dm_phu_cap)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_grc_dm_phu_cap
            // 
            this.m_grc_dm_phu_cap.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_dm_phu_cap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc_dm_phu_cap.Location = new System.Drawing.Point(0, 0);
            this.m_grc_dm_phu_cap.MainView = this.m_grv_dm_phu_cap;
            this.m_grc_dm_phu_cap.Name = "m_grc_dm_phu_cap";
            this.m_grc_dm_phu_cap.Size = new System.Drawing.Size(695, 312);
            this.m_grc_dm_phu_cap.TabIndex = 0;
            this.m_grc_dm_phu_cap.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv_dm_phu_cap});
            // 
            // m_grv_dm_phu_cap
            // 
            this.m_grv_dm_phu_cap.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.STT,
            this.c_doi_tuong_huong_phu_cap,
            this.c_ten_phu_cap,
            this.c_ti_le});
            this.m_grv_dm_phu_cap.GridControl = this.m_grc_dm_phu_cap;
            this.m_grv_dm_phu_cap.Name = "m_grv_dm_phu_cap";
            this.m_grv_dm_phu_cap.OptionsFind.AlwaysVisible = true;
            // 
            // ID
            // 
            this.ID.AppearanceHeader.Options.UseTextOptions = true;
            this.ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ID.Caption = "ID";
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
            // c_doi_tuong_huong_phu_cap
            // 
            this.c_doi_tuong_huong_phu_cap.AppearanceHeader.Options.UseTextOptions = true;
            this.c_doi_tuong_huong_phu_cap.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.c_doi_tuong_huong_phu_cap.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.c_doi_tuong_huong_phu_cap.Caption = "Đối tượng hưởng phụ cấp";
            this.c_doi_tuong_huong_phu_cap.FieldName = "DOI_TUONG_HUONG_PHU_CAP";
            this.c_doi_tuong_huong_phu_cap.Name = "c_doi_tuong_huong_phu_cap";
            this.c_doi_tuong_huong_phu_cap.Visible = true;
            this.c_doi_tuong_huong_phu_cap.VisibleIndex = 1;
            this.c_doi_tuong_huong_phu_cap.Width = 165;
            // 
            // c_ten_phu_cap
            // 
            this.c_ten_phu_cap.AppearanceCell.Options.UseTextOptions = true;
            this.c_ten_phu_cap.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.c_ten_phu_cap.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.c_ten_phu_cap.AppearanceHeader.Options.UseTextOptions = true;
            this.c_ten_phu_cap.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.c_ten_phu_cap.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.c_ten_phu_cap.Caption = "Loại phụ cấp";
            this.c_ten_phu_cap.FieldName = "TEN";
            this.c_ten_phu_cap.Name = "c_ten_phu_cap";
            this.c_ten_phu_cap.Visible = true;
            this.c_ten_phu_cap.VisibleIndex = 2;
            this.c_ten_phu_cap.Width = 165;
            // 
            // c_ti_le
            // 
            this.c_ti_le.AppearanceCell.Options.UseTextOptions = true;
            this.c_ti_le.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.c_ti_le.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.c_ti_le.AppearanceHeader.Options.UseTextOptions = true;
            this.c_ti_le.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.c_ti_le.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.c_ti_le.Caption = "Tỉ lệ";
            this.c_ti_le.FieldName = "TI_LE";
            this.c_ti_le.Name = "c_ti_le";
            this.c_ti_le.Visible = true;
            this.c_ti_le.VisibleIndex = 3;
            this.c_ti_le.Width = 170;
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
            this.panel1.Size = new System.Drawing.Size(695, 39);
            this.panel1.TabIndex = 2;
            // 
            // m_cmd_insert
            // 
            this.m_cmd_insert.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_insert.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_insert.Image")));
            this.m_cmd_insert.Location = new System.Drawing.Point(0, 0);
            this.m_cmd_insert.Name = "m_cmd_insert";
            this.m_cmd_insert.Size = new System.Drawing.Size(116, 39);
            this.m_cmd_insert.TabIndex = 38;
            this.m_cmd_insert.Text = "&Thêm";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.m_grc_dm_phu_cap);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(695, 312);
            this.panel2.TabIndex = 3;
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
            this.m_cmd_update.Size = new System.Drawing.Size(116, 39);
            this.m_cmd_update.TabIndex = 39;
            this.m_cmd_update.Text = "&Sửa";
            // 
            // m_cmd_delete
            // 
            this.m_cmd_delete.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_delete.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_delete.Image")));
            this.m_cmd_delete.Location = new System.Drawing.Point(232, 0);
            this.m_cmd_delete.Name = "m_cmd_delete";
            this.m_cmd_delete.Size = new System.Drawing.Size(116, 39);
            this.m_cmd_delete.TabIndex = 40;
            this.m_cmd_delete.Text = "&Xóa";
            // 
            // m_cmd_xuat_excel
            // 
            this.m_cmd_xuat_excel.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_xuat_excel.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_xuat_excel.Image")));
            this.m_cmd_xuat_excel.Location = new System.Drawing.Point(348, 0);
            this.m_cmd_xuat_excel.Name = "m_cmd_xuat_excel";
            this.m_cmd_xuat_excel.Size = new System.Drawing.Size(116, 39);
            this.m_cmd_xuat_excel.TabIndex = 41;
            this.m_cmd_xuat_excel.Text = "&Xuất Excel";
            this.m_cmd_xuat_excel.Visible = false;
            // 
            // F107_dm_phu_cap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 351);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "F107_dm_phu_cap";
            this.Text = "F107 - DANH MỤC PHỤ CẤP";
            this.Load += new System.EventHandler(this.F107_dm_phu_cap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_dm_phu_cap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_dm_phu_cap)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl m_grc_dm_phu_cap;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv_dm_phu_cap;
        private DevExpress.XtraGrid.Columns.GridColumn c_doi_tuong_huong_phu_cap;
        private DevExpress.XtraGrid.Columns.GridColumn c_ten_phu_cap;
        private DevExpress.XtraGrid.Columns.GridColumn c_ti_le;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton m_cmd_insert;
        internal System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraEditors.SimpleButton m_cmd_xuat_excel;
        private DevExpress.XtraEditors.SimpleButton m_cmd_delete;
        private DevExpress.XtraEditors.SimpleButton m_cmd_update;
    }
}