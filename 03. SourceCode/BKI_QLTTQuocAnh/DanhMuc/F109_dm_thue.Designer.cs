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
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_chan_duoi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_chan_tren = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_ti_le = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_bu_tru = new DevExpress.XtraGrid.Columns.GridColumn();
            this.m_lbl_header = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.c_cmd_dm_don_vi_xoa = new SIS.Controls.Button.SiSButton();
            this.imageList3 = new System.Windows.Forms.ImageList(this.components);
            this.c_cmd_dm_don_vi_sua = new SIS.Controls.Button.SiSButton();
            this.m_cmd_dm_don_vi_them = new SIS.Controls.Button.SiSButton();
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
            this.m_grc_dm_thue.Size = new System.Drawing.Size(748, 261);
            this.m_grc_dm_thue.TabIndex = 0;
            this.m_grc_dm_thue.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv_dm_thue});
            // 
            // m_grv_dm_thue
            // 
            this.m_grv_dm_thue.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
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
            // c_chan_duoi
            // 
            this.c_chan_duoi.AppearanceHeader.Options.UseTextOptions = true;
            this.c_chan_duoi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.c_chan_duoi.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.c_chan_duoi.Caption = "Chặn dưới";
            this.c_chan_duoi.FieldName = "CHAN_DUOI";
            this.c_chan_duoi.Name = "c_chan_duoi";
            this.c_chan_duoi.Visible = true;
            this.c_chan_duoi.VisibleIndex = 1;
            this.c_chan_duoi.Width = 145;
            // 
            // c_chan_tren
            // 
            this.c_chan_tren.AppearanceHeader.Options.UseTextOptions = true;
            this.c_chan_tren.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.c_chan_tren.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.c_chan_tren.Caption = "Chặn trên";
            this.c_chan_tren.FieldName = "CHAN_TREN";
            this.c_chan_tren.Name = "c_chan_tren";
            this.c_chan_tren.Visible = true;
            this.c_chan_tren.VisibleIndex = 2;
            this.c_chan_tren.Width = 145;
            // 
            // c_ti_le
            // 
            this.c_ti_le.AppearanceHeader.Options.UseTextOptions = true;
            this.c_ti_le.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.c_ti_le.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.c_ti_le.Caption = "Tỉ lệ";
            this.c_ti_le.FieldName = "TI_LE";
            this.c_ti_le.Name = "c_ti_le";
            this.c_ti_le.Visible = true;
            this.c_ti_le.VisibleIndex = 3;
            this.c_ti_le.Width = 145;
            // 
            // c_bu_tru
            // 
            this.c_bu_tru.AppearanceHeader.Options.UseTextOptions = true;
            this.c_bu_tru.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.c_bu_tru.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.c_bu_tru.Caption = "Bù trừ";
            this.c_bu_tru.FieldName = "BU_TRU";
            this.c_bu_tru.Name = "c_bu_tru";
            this.c_bu_tru.Visible = true;
            this.c_bu_tru.VisibleIndex = 4;
            this.c_bu_tru.Width = 253;
            // 
            // m_lbl_header
            // 
            this.m_lbl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.m_lbl_header.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_header.Location = new System.Drawing.Point(0, 0);
            this.m_lbl_header.Name = "m_lbl_header";
            this.m_lbl_header.Size = new System.Drawing.Size(748, 44);
            this.m_lbl_header.TabIndex = 1;
            this.m_lbl_header.Text = "DANH MỤC THUẾ";
            this.m_lbl_header.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "");
            this.imageList2.Images.SetKeyName(1, "");
            this.imageList2.Images.SetKeyName(2, "");
            this.imageList2.Images.SetKeyName(3, "");
            this.imageList2.Images.SetKeyName(4, "");
            this.imageList2.Images.SetKeyName(5, "");
            this.imageList2.Images.SetKeyName(6, "");
            this.imageList2.Images.SetKeyName(7, "");
            this.imageList2.Images.SetKeyName(8, "");
            this.imageList2.Images.SetKeyName(9, "");
            this.imageList2.Images.SetKeyName(10, "");
            this.imageList2.Images.SetKeyName(11, "");
            this.imageList2.Images.SetKeyName(12, "");
            this.imageList2.Images.SetKeyName(13, "");
            this.imageList2.Images.SetKeyName(14, "");
            this.imageList2.Images.SetKeyName(15, "");
            this.imageList2.Images.SetKeyName(16, "");
            this.imageList2.Images.SetKeyName(17, "");
            this.imageList2.Images.SetKeyName(18, "");
            this.imageList2.Images.SetKeyName(19, "");
            this.imageList2.Images.SetKeyName(20, "");
            this.imageList2.Images.SetKeyName(21, "");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.c_cmd_dm_don_vi_xoa);
            this.panel1.Controls.Add(this.c_cmd_dm_don_vi_sua);
            this.panel1.Controls.Add(this.m_cmd_dm_don_vi_them);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 305);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(748, 45);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.m_grc_dm_thue);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(748, 261);
            this.panel2.TabIndex = 5;
            // 
            // c_cmd_dm_don_vi_xoa
            // 
            this.c_cmd_dm_don_vi_xoa.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.c_cmd_dm_don_vi_xoa.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.c_cmd_dm_don_vi_xoa.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.c_cmd_dm_don_vi_xoa.Dock = System.Windows.Forms.DockStyle.Left;
            this.c_cmd_dm_don_vi_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.c_cmd_dm_don_vi_xoa.ImageIndex = 4;
            this.c_cmd_dm_don_vi_xoa.ImageList = this.imageList3;
            this.c_cmd_dm_don_vi_xoa.Location = new System.Drawing.Point(246, 0);
            this.c_cmd_dm_don_vi_xoa.Name = "c_cmd_dm_don_vi_xoa";
            this.c_cmd_dm_don_vi_xoa.Size = new System.Drawing.Size(123, 45);
            this.c_cmd_dm_don_vi_xoa.TabIndex = 9;
            this.c_cmd_dm_don_vi_xoa.Text = "&Xóa";
            // 
            // imageList3
            // 
            this.imageList3.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList3.ImageStream")));
            this.imageList3.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList3.Images.SetKeyName(0, "");
            this.imageList3.Images.SetKeyName(1, "");
            this.imageList3.Images.SetKeyName(2, "");
            this.imageList3.Images.SetKeyName(3, "");
            this.imageList3.Images.SetKeyName(4, "");
            this.imageList3.Images.SetKeyName(5, "");
            this.imageList3.Images.SetKeyName(6, "");
            this.imageList3.Images.SetKeyName(7, "");
            this.imageList3.Images.SetKeyName(8, "");
            this.imageList3.Images.SetKeyName(9, "");
            this.imageList3.Images.SetKeyName(10, "");
            this.imageList3.Images.SetKeyName(11, "");
            this.imageList3.Images.SetKeyName(12, "");
            this.imageList3.Images.SetKeyName(13, "");
            this.imageList3.Images.SetKeyName(14, "");
            this.imageList3.Images.SetKeyName(15, "");
            this.imageList3.Images.SetKeyName(16, "");
            this.imageList3.Images.SetKeyName(17, "");
            this.imageList3.Images.SetKeyName(18, "");
            this.imageList3.Images.SetKeyName(19, "");
            this.imageList3.Images.SetKeyName(20, "");
            this.imageList3.Images.SetKeyName(21, "");
            // 
            // c_cmd_dm_don_vi_sua
            // 
            this.c_cmd_dm_don_vi_sua.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.c_cmd_dm_don_vi_sua.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.c_cmd_dm_don_vi_sua.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.c_cmd_dm_don_vi_sua.Dock = System.Windows.Forms.DockStyle.Left;
            this.c_cmd_dm_don_vi_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.c_cmd_dm_don_vi_sua.ImageIndex = 16;
            this.c_cmd_dm_don_vi_sua.ImageList = this.imageList3;
            this.c_cmd_dm_don_vi_sua.Location = new System.Drawing.Point(123, 0);
            this.c_cmd_dm_don_vi_sua.Name = "c_cmd_dm_don_vi_sua";
            this.c_cmd_dm_don_vi_sua.Size = new System.Drawing.Size(123, 45);
            this.c_cmd_dm_don_vi_sua.TabIndex = 8;
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
            this.m_cmd_dm_don_vi_them.ImageList = this.imageList3;
            this.m_cmd_dm_don_vi_them.Location = new System.Drawing.Point(0, 0);
            this.m_cmd_dm_don_vi_them.Name = "m_cmd_dm_don_vi_them";
            this.m_cmd_dm_don_vi_them.Size = new System.Drawing.Size(123, 45);
            this.m_cmd_dm_don_vi_them.TabIndex = 7;
            this.m_cmd_dm_don_vi_them.Text = "&Thêm";
            // 
            // F109_dm_thue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 350);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.m_lbl_header);
            this.Name = "F109_dm_thue";
            this.Text = "F109 - DANH MỤC THUẾ";
            this.Load += new System.EventHandler(this.F109_dm_thue_Load);
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
        private System.Windows.Forms.Label m_lbl_header;
        internal System.Windows.Forms.ImageList imageList1;
        internal System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        internal SIS.Controls.Button.SiSButton c_cmd_dm_don_vi_xoa;
        internal System.Windows.Forms.ImageList imageList3;
        internal SIS.Controls.Button.SiSButton c_cmd_dm_don_vi_sua;
        internal SIS.Controls.Button.SiSButton m_cmd_dm_don_vi_them;
    }
}