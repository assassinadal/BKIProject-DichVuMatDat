namespace BKI_DichVuMatDat.NghiepVu.NhanSu
{
    partial class f003_import_he_so_lns
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f003_import_he_so_lns));
            this.label1 = new System.Windows.Forms.Label();
            this.img_DVMD = new DevExpress.Utils.ImageCollection(this.components);
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.m_cmd_save = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_chon_file = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_tai_file_mau = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_xuat_excel = new DevExpress.XtraEditors.SimpleButton();
            this.m_pnl_danh_sach_hop_dong = new DevExpress.XtraEditors.PanelControl();
            this.m_grc_cong_tac = new DevExpress.XtraGrid.GridControl();
            this.m_grv_cong_tac = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MA_NV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAY_BAT_DAU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAY_KET_THUC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MA_LNS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MUC_LNS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.m_tooltip_controller = new DevExpress.Utils.ToolTipController(this.components);
            this.m_lbl_thong_bao = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.img_DVMD)).BeginInit();
            this.m_pnl_out_place_dm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_pnl_danh_sach_hop_dong)).BeginInit();
            this.m_pnl_danh_sach_hop_dong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_cong_tac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_cong_tac)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(927, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "IMPORT HỆ SỐ LNS TỪ EXCEL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // m_pnl_out_place_dm
            // 
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_save);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_chon_file);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_tai_file_mau);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_xuat_excel);
            this.m_pnl_out_place_dm.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 39);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(927, 43);
            this.m_pnl_out_place_dm.TabIndex = 1;
            // 
            // m_cmd_save
            // 
            this.m_cmd_save.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.m_cmd_save.Appearance.Options.UseFont = true;
            this.m_cmd_save.ImageIndex = 6;
            this.m_cmd_save.ImageList = this.img_DVMD;
            this.m_cmd_save.Location = new System.Drawing.Point(207, 4);
            this.m_cmd_save.Name = "m_cmd_save";
            this.m_cmd_save.Size = new System.Drawing.Size(92, 35);
            this.m_cmd_save.TabIndex = 2;
            this.m_cmd_save.Text = "&Lưu";
            // 
            // m_cmd_chon_file
            // 
            this.m_cmd_chon_file.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.m_cmd_chon_file.Appearance.Options.UseFont = true;
            this.m_cmd_chon_file.ImageIndex = 4;
            this.m_cmd_chon_file.ImageList = this.img_DVMD;
            this.m_cmd_chon_file.Location = new System.Drawing.Point(107, 4);
            this.m_cmd_chon_file.Name = "m_cmd_chon_file";
            this.m_cmd_chon_file.Size = new System.Drawing.Size(100, 35);
            this.m_cmd_chon_file.TabIndex = 1;
            this.m_cmd_chon_file.Text = "&Chọn file";
            // 
            // m_cmd_tai_file_mau
            // 
            this.m_cmd_tai_file_mau.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.m_cmd_tai_file_mau.Appearance.Options.UseFont = true;
            this.m_cmd_tai_file_mau.ImageIndex = 1;
            this.m_cmd_tai_file_mau.ImageList = this.img_DVMD;
            this.m_cmd_tai_file_mau.Location = new System.Drawing.Point(7, 4);
            this.m_cmd_tai_file_mau.Name = "m_cmd_tai_file_mau";
            this.m_cmd_tai_file_mau.Size = new System.Drawing.Size(100, 35);
            this.m_cmd_tai_file_mau.TabIndex = 0;
            this.m_cmd_tai_file_mau.Text = "&Tải file mẫu";
            // 
            // m_cmd_xuat_excel
            // 
            this.m_cmd_xuat_excel.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.m_cmd_xuat_excel.Appearance.Options.UseFont = true;
            this.m_cmd_xuat_excel.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_xuat_excel.ImageIndex = 0;
            this.m_cmd_xuat_excel.ImageList = this.img_DVMD;
            this.m_cmd_xuat_excel.Location = new System.Drawing.Point(816, 4);
            this.m_cmd_xuat_excel.Name = "m_cmd_xuat_excel";
            this.m_cmd_xuat_excel.Size = new System.Drawing.Size(107, 35);
            this.m_cmd_xuat_excel.TabIndex = 3;
            this.m_cmd_xuat_excel.Text = "&Trích xuất";
            // 
            // m_pnl_danh_sach_hop_dong
            // 
            this.m_pnl_danh_sach_hop_dong.Controls.Add(this.m_grc_cong_tac);
            this.m_pnl_danh_sach_hop_dong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_pnl_danh_sach_hop_dong.Location = new System.Drawing.Point(0, 108);
            this.m_pnl_danh_sach_hop_dong.Name = "m_pnl_danh_sach_hop_dong";
            this.m_pnl_danh_sach_hop_dong.Size = new System.Drawing.Size(927, 368);
            this.m_pnl_danh_sach_hop_dong.TabIndex = 4;
            // 
            // m_grc_cong_tac
            // 
            this.m_grc_cong_tac.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_cong_tac.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc_cong_tac.Location = new System.Drawing.Point(2, 2);
            this.m_grc_cong_tac.MainView = this.m_grv_cong_tac;
            this.m_grc_cong_tac.Name = "m_grc_cong_tac";
            this.m_grc_cong_tac.Size = new System.Drawing.Size(923, 364);
            this.m_grc_cong_tac.TabIndex = 0;
            this.m_grc_cong_tac.ToolTipController = this.m_tooltip_controller;
            this.m_grc_cong_tac.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv_cong_tac});
            // 
            // m_grv_cong_tac
            // 
            this.m_grv_cong_tac.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.m_grv_cong_tac.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.STT,
            this.MA_NV,
            this.NGAY_BAT_DAU,
            this.NGAY_KET_THUC,
            this.MA_LNS,
            this.MUC_LNS});
            this.m_grv_cong_tac.GridControl = this.m_grc_cong_tac;
            this.m_grv_cong_tac.Name = "m_grv_cong_tac";
            this.m_grv_cong_tac.OptionsPrint.AutoWidth = false;
            this.m_grv_cong_tac.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            // 
            // STT
            // 
            this.STT.AppearanceCell.Options.UseTextOptions = true;
            this.STT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.STT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.STT.AppearanceHeader.Options.UseFont = true;
            this.STT.AppearanceHeader.Options.UseTextOptions = true;
            this.STT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.STT.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.STT.Caption = "STT";
            this.STT.FieldName = "STT";
            this.STT.Name = "STT";
            this.STT.Visible = true;
            this.STT.VisibleIndex = 0;
            this.STT.Width = 58;
            // 
            // MA_NV
            // 
            this.MA_NV.AppearanceCell.Options.UseTextOptions = true;
            this.MA_NV.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.MA_NV.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.MA_NV.AppearanceHeader.Options.UseFont = true;
            this.MA_NV.AppearanceHeader.Options.UseTextOptions = true;
            this.MA_NV.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.MA_NV.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.MA_NV.Caption = "MA_NHAN_VIEN";
            this.MA_NV.FieldName = "MA_NHAN_VIEN";
            this.MA_NV.Name = "MA_NV";
            this.MA_NV.Visible = true;
            this.MA_NV.VisibleIndex = 1;
            this.MA_NV.Width = 138;
            // 
            // NGAY_BAT_DAU
            // 
            this.NGAY_BAT_DAU.AppearanceCell.Options.UseTextOptions = true;
            this.NGAY_BAT_DAU.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NGAY_BAT_DAU.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.NGAY_BAT_DAU.AppearanceHeader.Options.UseFont = true;
            this.NGAY_BAT_DAU.AppearanceHeader.Options.UseTextOptions = true;
            this.NGAY_BAT_DAU.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NGAY_BAT_DAU.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.NGAY_BAT_DAU.Caption = "NGAY_BAT_DAU";
            this.NGAY_BAT_DAU.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.NGAY_BAT_DAU.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.NGAY_BAT_DAU.FieldName = "NGAY_BAT_DAU";
            this.NGAY_BAT_DAU.Name = "NGAY_BAT_DAU";
            this.NGAY_BAT_DAU.Visible = true;
            this.NGAY_BAT_DAU.VisibleIndex = 4;
            this.NGAY_BAT_DAU.Width = 215;
            // 
            // NGAY_KET_THUC
            // 
            this.NGAY_KET_THUC.AppearanceCell.Options.UseTextOptions = true;
            this.NGAY_KET_THUC.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NGAY_KET_THUC.AppearanceHeader.Options.UseTextOptions = true;
            this.NGAY_KET_THUC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NGAY_KET_THUC.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.NGAY_KET_THUC.Caption = "NGAY_KET_THUC";
            this.NGAY_KET_THUC.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.NGAY_KET_THUC.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.NGAY_KET_THUC.FieldName = "NGAY_KET_THUC";
            this.NGAY_KET_THUC.Name = "NGAY_KET_THUC";
            this.NGAY_KET_THUC.Visible = true;
            this.NGAY_KET_THUC.VisibleIndex = 5;
            this.NGAY_KET_THUC.Width = 221;
            // 
            // MA_LNS
            // 
            this.MA_LNS.AppearanceCell.Options.UseTextOptions = true;
            this.MA_LNS.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.MA_LNS.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.MA_LNS.AppearanceHeader.Options.UseFont = true;
            this.MA_LNS.AppearanceHeader.Options.UseTextOptions = true;
            this.MA_LNS.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.MA_LNS.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.MA_LNS.Caption = "MA_LNS";
            this.MA_LNS.FieldName = "MA_LNS";
            this.MA_LNS.Name = "MA_LNS";
            this.MA_LNS.Visible = true;
            this.MA_LNS.VisibleIndex = 2;
            this.MA_LNS.Width = 215;
            // 
            // MUC_LNS
            // 
            this.MUC_LNS.AppearanceCell.Options.UseTextOptions = true;
            this.MUC_LNS.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.MUC_LNS.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.MUC_LNS.AppearanceHeader.Options.UseFont = true;
            this.MUC_LNS.AppearanceHeader.Options.UseTextOptions = true;
            this.MUC_LNS.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.MUC_LNS.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.MUC_LNS.Caption = "MUC_LNS";
            this.MUC_LNS.FieldName = "MUC_LNS";
            this.MUC_LNS.Name = "MUC_LNS";
            this.MUC_LNS.Visible = true;
            this.MUC_LNS.VisibleIndex = 3;
            this.MUC_LNS.Width = 215;
            // 
            // m_lbl_thong_bao
            // 
            this.m_lbl_thong_bao.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_thong_bao.Appearance.ForeColor = System.Drawing.Color.Red;
            this.m_lbl_thong_bao.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_lbl_thong_bao.Location = new System.Drawing.Point(0, 82);
            this.m_lbl_thong_bao.Name = "m_lbl_thong_bao";
            this.m_lbl_thong_bao.Padding = new System.Windows.Forms.Padding(5);
            this.m_lbl_thong_bao.Size = new System.Drawing.Size(97, 26);
            this.m_lbl_thong_bao.TabIndex = 3;
            this.m_lbl_thong_bao.Text = "Chưa load file";
            this.m_lbl_thong_bao.Visible = false;
            // 
            // f003_import_he_so_lns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 476);
            this.Controls.Add(this.m_pnl_danh_sach_hop_dong);
            this.Controls.Add(this.m_lbl_thong_bao);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.Controls.Add(this.label1);
            this.Name = "f003_import_he_so_lns";
            this.Text = "F003 - IMPORT HỆ SỐ LNS";
            ((System.ComponentModel.ISupportInitialize)(this.img_DVMD)).EndInit();
            this.m_pnl_out_place_dm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_pnl_danh_sach_hop_dong)).EndInit();
            this.m_pnl_danh_sach_hop_dong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_cong_tac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_cong_tac)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.Utils.ImageCollection img_DVMD;
        internal System.Windows.Forms.Panel m_pnl_out_place_dm;
        private DevExpress.XtraEditors.SimpleButton m_cmd_xuat_excel;
        private DevExpress.XtraEditors.SimpleButton m_cmd_save;
        private DevExpress.XtraEditors.SimpleButton m_cmd_chon_file;
        private DevExpress.XtraEditors.SimpleButton m_cmd_tai_file_mau;
        private DevExpress.XtraEditors.PanelControl m_pnl_danh_sach_hop_dong;
        private DevExpress.XtraGrid.GridControl m_grc_cong_tac;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv_cong_tac;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
        private DevExpress.XtraGrid.Columns.GridColumn MA_NV;
        private DevExpress.XtraGrid.Columns.GridColumn MA_LNS;
        private DevExpress.XtraGrid.Columns.GridColumn MUC_LNS;
        private DevExpress.XtraGrid.Columns.GridColumn NGAY_BAT_DAU;
        private DevExpress.XtraGrid.Columns.GridColumn NGAY_KET_THUC;
        private DevExpress.Utils.ToolTipController m_tooltip_controller;
        private DevExpress.XtraEditors.LabelControl m_lbl_thong_bao;
    }
}