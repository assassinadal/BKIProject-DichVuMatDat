namespace BKI_DichVuMatDat.DanhMuc
{
    partial class F109_dm_thue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F109_dm_thue));
            this.m_grc_dm_thue = new DevExpress.XtraGrid.GridControl();
            this.m_grv_dm_thue = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_chan_duoi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_chan_tren = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_ti_le = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_bu_tru = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_cmd_insert = new DevExpress.XtraEditors.SimpleButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.m_cmd_update = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_delete = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_xuat_excel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_dm_thue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_dm_thue)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_grc_dm_thue
            // 
            this.m_grc_dm_thue.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_dm_thue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc_dm_thue.Location = new System.Drawing.Point(0, 0);
            this.m_grc_dm_thue.MainView = this.m_grv_dm_thue;
            this.m_grc_dm_thue.Name = "m_grc_dm_thue";
            this.m_grc_dm_thue.Size = new System.Drawing.Size(748, 311);
            this.m_grc_dm_thue.TabIndex = 0;
            this.m_grc_dm_thue.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv_dm_thue});
            // 
            // m_grv_dm_thue
            // 
            this.m_grv_dm_thue.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.STT,
            this.c_chan_duoi,
            this.c_chan_tren,
            this.c_ti_le,
            this.c_bu_tru});
            this.m_grv_dm_thue.GridControl = this.m_grc_dm_thue;
            this.m_grv_dm_thue.Name = "m_grv_dm_thue";
            this.m_grv_dm_thue.OptionsFind.AllowFindPanel = false;
            this.m_grv_dm_thue.OptionsFind.AlwaysVisible = true;
            this.m_grv_dm_thue.OptionsView.ShowFooter = true;
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
            // c_chan_duoi
            // 
            this.c_chan_duoi.AppearanceCell.Options.UseTextOptions = true;
            this.c_chan_duoi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.c_chan_duoi.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.c_chan_duoi.AppearanceHeader.Options.UseTextOptions = true;
            this.c_chan_duoi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.c_chan_duoi.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.c_chan_duoi.Caption = "Chặn dưới (VNĐ)";
            this.c_chan_duoi.DisplayFormat.FormatString = "{0:#,##0}";
            this.c_chan_duoi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.c_chan_duoi.FieldName = "CHAN_DUOI";
            this.c_chan_duoi.Name = "c_chan_duoi";
            this.c_chan_duoi.OptionsColumn.AllowEdit = false;
            this.c_chan_duoi.Visible = true;
            this.c_chan_duoi.VisibleIndex = 1;
            this.c_chan_duoi.Width = 145;
            // 
            // c_chan_tren
            // 
            this.c_chan_tren.AppearanceCell.Options.UseTextOptions = true;
            this.c_chan_tren.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.c_chan_tren.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.c_chan_tren.AppearanceHeader.Options.UseTextOptions = true;
            this.c_chan_tren.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.c_chan_tren.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.c_chan_tren.Caption = "Chặn trên (VNĐ)";
            this.c_chan_tren.DisplayFormat.FormatString = "{0:#,##0}";
            this.c_chan_tren.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.c_chan_tren.FieldName = "CHAN_TREN";
            this.c_chan_tren.Name = "c_chan_tren";
            this.c_chan_tren.OptionsColumn.AllowEdit = false;
            this.c_chan_tren.Visible = true;
            this.c_chan_tren.VisibleIndex = 2;
            this.c_chan_tren.Width = 145;
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
            this.c_ti_le.OptionsColumn.AllowEdit = false;
            this.c_ti_le.Visible = true;
            this.c_ti_le.VisibleIndex = 3;
            this.c_ti_le.Width = 145;
            // 
            // c_bu_tru
            // 
            this.c_bu_tru.AppearanceCell.Options.UseTextOptions = true;
            this.c_bu_tru.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.c_bu_tru.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.c_bu_tru.AppearanceHeader.Options.UseTextOptions = true;
            this.c_bu_tru.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.c_bu_tru.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.c_bu_tru.Caption = "Bù trừ (VNĐ)";
            this.c_bu_tru.DisplayFormat.FormatString = "{0:#,##0}";
            this.c_bu_tru.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.c_bu_tru.FieldName = "BU_TRU";
            this.c_bu_tru.Name = "c_bu_tru";
            this.c_bu_tru.OptionsColumn.AllowEdit = false;
            this.c_bu_tru.Visible = true;
            this.c_bu_tru.VisibleIndex = 4;
            this.c_bu_tru.Width = 253;
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
            this.panel1.Size = new System.Drawing.Size(748, 39);
            this.panel1.TabIndex = 4;
            this.panel1.Visible = false;
            // 
            // m_cmd_insert
            // 
            this.m_cmd_insert.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_insert.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_insert.Image")));
            this.m_cmd_insert.Location = new System.Drawing.Point(0, 0);
            this.m_cmd_insert.Name = "m_cmd_insert";
            this.m_cmd_insert.Size = new System.Drawing.Size(116, 39);
            this.m_cmd_insert.TabIndex = 34;
            this.m_cmd_insert.Text = "&Thêm";
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
            this.panel2.Controls.Add(this.m_grc_dm_thue);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(748, 311);
            this.panel2.TabIndex = 5;
            // 
            // m_cmd_update
            // 
            this.m_cmd_update.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_update.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_update.Image")));
            this.m_cmd_update.Location = new System.Drawing.Point(116, 0);
            this.m_cmd_update.Name = "m_cmd_update";
            this.m_cmd_update.Size = new System.Drawing.Size(116, 39);
            this.m_cmd_update.TabIndex = 35;
            this.m_cmd_update.Text = "&Sửa";
            // 
            // m_cmd_delete
            // 
            this.m_cmd_delete.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_delete.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_delete.Image")));
            this.m_cmd_delete.Location = new System.Drawing.Point(232, 0);
            this.m_cmd_delete.Name = "m_cmd_delete";
            this.m_cmd_delete.Size = new System.Drawing.Size(116, 39);
            this.m_cmd_delete.TabIndex = 36;
            this.m_cmd_delete.Text = "&Xóa";
            // 
            // m_cmd_xuat_excel
            // 
            this.m_cmd_xuat_excel.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_xuat_excel.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_xuat_excel.Image")));
            this.m_cmd_xuat_excel.Location = new System.Drawing.Point(348, 0);
            this.m_cmd_xuat_excel.Name = "m_cmd_xuat_excel";
            this.m_cmd_xuat_excel.Size = new System.Drawing.Size(116, 39);
            this.m_cmd_xuat_excel.TabIndex = 37;
            this.m_cmd_xuat_excel.Text = "&Xuất Excel";
            this.m_cmd_xuat_excel.Visible = false;
            // 
            // F109_dm_thue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 350);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "F109_dm_thue";
            this.Text = "F109 - BIỂU TÍNH THUẾ";
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_dm_thue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_dm_thue)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl m_grc_dm_thue;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv_dm_thue;
        private DevExpress.XtraGrid.Columns.GridColumn c_chan_duoi;
        private DevExpress.XtraGrid.Columns.GridColumn c_chan_tren;
        private DevExpress.XtraGrid.Columns.GridColumn c_ti_le;
        private DevExpress.XtraGrid.Columns.GridColumn c_bu_tru;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        internal System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraEditors.SimpleButton m_cmd_insert;
        private DevExpress.XtraEditors.SimpleButton m_cmd_delete;
        private DevExpress.XtraEditors.SimpleButton m_cmd_update;
        private DevExpress.XtraEditors.SimpleButton m_cmd_xuat_excel;
    }
}