namespace BKI_DichVuMatDat.NghiepVu
{
    partial class f301_tinh_thu_nhap_khac
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
            if(disposing && (components != null))
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f301_tinh_thu_nhap_khac));
            this.m_lbl_download_template = new DevExpress.XtraEditors.LabelControl();
            this.m_grc_main = new DevExpress.XtraGrid.GridControl();
            this.m_grv_main = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MA_NV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HE_SO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.THANH_TIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.THUE_PHAI_NOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.THUC_LINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TEN_DON_VI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CHUC_VU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SO_TAI_KHOAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HO_TEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.m_lbl_ten_quy = new DevExpress.XtraEditors.LabelControl();
            this.m_cmd_xuat_excel = new DevExpress.XtraEditors.SimpleButton();
            this.imageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.m_cmd_import_excel = new DevExpress.XtraEditors.SimpleButton();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::BKI_DichVuMatDat.BaoCao.F_wait_form), true, true);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.m_cmd_save = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_tinh_tien_thuong = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.m_lbl_trang_thai_soan_thao = new DevExpress.XtraEditors.LabelControl();
            this.m_pn = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.m_prb = new DevExpress.XtraEditors.ProgressBarControl();
            this.m_bgw = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.m_pn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_prb.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // m_lbl_download_template
            // 
            this.m_lbl_download_template.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.m_lbl_download_template.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_download_template.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.m_lbl_download_template.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.m_lbl_download_template.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.m_lbl_download_template.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_lbl_download_template.LineVisible = true;
            this.m_lbl_download_template.Location = new System.Drawing.Point(2, 2);
            this.m_lbl_download_template.Name = "m_lbl_download_template";
            this.m_lbl_download_template.Size = new System.Drawing.Size(154, 33);
            this.m_lbl_download_template.TabIndex = 0;
            this.m_lbl_download_template.Text = "Bước 1: Tạo file Excel import mới!";
            // 
            // m_grc_main
            // 
            this.m_grc_main.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc_main.Location = new System.Drawing.Point(0, 129);
            this.m_grc_main.MainView = this.m_grv_main;
            this.m_grc_main.Name = "m_grc_main";
            this.m_grc_main.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            this.m_grc_main.Size = new System.Drawing.Size(1158, 425);
            this.m_grc_main.TabIndex = 2;
            this.m_grc_main.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv_main});
            // 
            // m_grv_main
            // 
            this.m_grv_main.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MA_NV,
            this.HE_SO,
            this.THANH_TIEN,
            this.THUE_PHAI_NOP,
            this.THUC_LINH,
            this.TEN_DON_VI,
            this.CHUC_VU,
            this.SO_TAI_KHOAN,
            this.HO_TEN,
            this.STT});
            this.m_grv_main.GridControl = this.m_grc_main;
            this.m_grv_main.Name = "m_grv_main";
            this.m_grv_main.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.m_grv_main.OptionsView.ShowFooter = true;
            this.m_grv_main.OptionsView.ShowGroupPanel = false;
            // 
            // MA_NV
            // 
            this.MA_NV.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.MA_NV.AppearanceHeader.Options.UseFont = true;
            this.MA_NV.AppearanceHeader.Options.UseTextOptions = true;
            this.MA_NV.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.MA_NV.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.MA_NV.Caption = "MA_NV";
            this.MA_NV.FieldName = "MA_NV";
            this.MA_NV.Name = "MA_NV";
            this.MA_NV.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.MA_NV.Visible = true;
            this.MA_NV.VisibleIndex = 1;
            this.MA_NV.Width = 114;
            // 
            // HE_SO
            // 
            this.HE_SO.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.HE_SO.AppearanceHeader.Options.UseFont = true;
            this.HE_SO.AppearanceHeader.Options.UseTextOptions = true;
            this.HE_SO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.HE_SO.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.HE_SO.Caption = "HE_SO";
            this.HE_SO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.HE_SO.FieldName = "HE_SO";
            this.HE_SO.Name = "HE_SO";
            this.HE_SO.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.HE_SO.Visible = true;
            this.HE_SO.VisibleIndex = 2;
            this.HE_SO.Width = 114;
            // 
            // THANH_TIEN
            // 
            this.THANH_TIEN.AppearanceHeader.Options.UseTextOptions = true;
            this.THANH_TIEN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.THANH_TIEN.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.THANH_TIEN.Caption = "THANH_TIEN";
            this.THANH_TIEN.ColumnEdit = this.repositoryItemTextEdit1;
            this.THANH_TIEN.DisplayFormat.FormatString = "n0";
            this.THANH_TIEN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.THANH_TIEN.FieldName = "THANH_TIEN";
            this.THANH_TIEN.Name = "THANH_TIEN";
            this.THANH_TIEN.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "THANH_TIEN", "{0:n0}")});
            this.THANH_TIEN.Visible = true;
            this.THANH_TIEN.VisibleIndex = 3;
            this.THANH_TIEN.Width = 114;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.DisplayFormat.FormatString = "n0";
            this.repositoryItemTextEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemTextEdit1.EditFormat.FormatString = "n0";
            this.repositoryItemTextEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // THUE_PHAI_NOP
            // 
            this.THUE_PHAI_NOP.AppearanceHeader.Options.UseTextOptions = true;
            this.THUE_PHAI_NOP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.THUE_PHAI_NOP.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.THUE_PHAI_NOP.Caption = "THUE_PHAI_NOP";
            this.THUE_PHAI_NOP.ColumnEdit = this.repositoryItemTextEdit1;
            this.THUE_PHAI_NOP.DisplayFormat.FormatString = "n0";
            this.THUE_PHAI_NOP.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.THUE_PHAI_NOP.FieldName = "THUE_PHAI_NOP";
            this.THUE_PHAI_NOP.Name = "THUE_PHAI_NOP";
            this.THUE_PHAI_NOP.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "THUE_PHAI_NOP", "{0:n0}")});
            this.THUE_PHAI_NOP.Visible = true;
            this.THUE_PHAI_NOP.VisibleIndex = 4;
            this.THUE_PHAI_NOP.Width = 114;
            // 
            // THUC_LINH
            // 
            this.THUC_LINH.AppearanceHeader.Options.UseTextOptions = true;
            this.THUC_LINH.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.THUC_LINH.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.THUC_LINH.Caption = "THUC_LINH";
            this.THUC_LINH.ColumnEdit = this.repositoryItemTextEdit1;
            this.THUC_LINH.DisplayFormat.FormatString = "n0";
            this.THUC_LINH.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.THUC_LINH.FieldName = "THUC_LINH";
            this.THUC_LINH.Name = "THUC_LINH";
            this.THUC_LINH.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "THUC_LINH", "{0:n0}")});
            this.THUC_LINH.Visible = true;
            this.THUC_LINH.VisibleIndex = 5;
            this.THUC_LINH.Width = 114;
            // 
            // TEN_DON_VI
            // 
            this.TEN_DON_VI.AppearanceHeader.Options.UseTextOptions = true;
            this.TEN_DON_VI.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TEN_DON_VI.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.TEN_DON_VI.Caption = "TEN_DON_VI";
            this.TEN_DON_VI.FieldName = "TEN_DON_VI";
            this.TEN_DON_VI.Name = "TEN_DON_VI";
            this.TEN_DON_VI.OptionsColumn.ReadOnly = true;
            this.TEN_DON_VI.Visible = true;
            this.TEN_DON_VI.VisibleIndex = 7;
            this.TEN_DON_VI.Width = 114;
            // 
            // CHUC_VU
            // 
            this.CHUC_VU.AppearanceHeader.Options.UseTextOptions = true;
            this.CHUC_VU.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CHUC_VU.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.CHUC_VU.Caption = "CHUC_VU";
            this.CHUC_VU.FieldName = "CHUC_VU";
            this.CHUC_VU.Name = "CHUC_VU";
            this.CHUC_VU.OptionsColumn.ReadOnly = true;
            this.CHUC_VU.Visible = true;
            this.CHUC_VU.VisibleIndex = 8;
            this.CHUC_VU.Width = 114;
            // 
            // SO_TAI_KHOAN
            // 
            this.SO_TAI_KHOAN.AppearanceHeader.Options.UseTextOptions = true;
            this.SO_TAI_KHOAN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SO_TAI_KHOAN.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.SO_TAI_KHOAN.Caption = "SO_TAI_KHOAN";
            this.SO_TAI_KHOAN.FieldName = "SO_TAI_KHOAN";
            this.SO_TAI_KHOAN.Name = "SO_TAI_KHOAN";
            this.SO_TAI_KHOAN.OptionsColumn.ReadOnly = true;
            this.SO_TAI_KHOAN.Visible = true;
            this.SO_TAI_KHOAN.VisibleIndex = 9;
            this.SO_TAI_KHOAN.Width = 131;
            // 
            // HO_TEN
            // 
            this.HO_TEN.Caption = "HO_TEN";
            this.HO_TEN.FieldName = "HO_TEN";
            this.HO_TEN.Name = "HO_TEN";
            this.HO_TEN.OptionsColumn.ReadOnly = true;
            this.HO_TEN.Visible = true;
            this.HO_TEN.VisibleIndex = 6;
            this.HO_TEN.Width = 114;
            // 
            // STT
            // 
            this.STT.Caption = "STT";
            this.STT.FieldName = "STT";
            this.STT.Name = "STT";
            this.STT.OptionsColumn.ReadOnly = true;
            this.STT.Visible = true;
            this.STT.VisibleIndex = 0;
            this.STT.Width = 35;
            // 
            // m_lbl_ten_quy
            // 
            this.m_lbl_ten_quy.Appearance.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.m_lbl_ten_quy.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_lbl_ten_quy.Location = new System.Drawing.Point(2, 2);
            this.m_lbl_ten_quy.Name = "m_lbl_ten_quy";
            this.m_lbl_ten_quy.Padding = new System.Windows.Forms.Padding(10);
            this.m_lbl_ten_quy.Size = new System.Drawing.Size(38, 43);
            this.m_lbl_ten_quy.TabIndex = 1;
            this.m_lbl_ten_quy.Text = "...";
            // 
            // m_cmd_xuat_excel
            // 
            this.m_cmd_xuat_excel.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_xuat_excel.ImageIndex = 1;
            this.m_cmd_xuat_excel.ImageList = this.imageCollection;
            this.m_cmd_xuat_excel.Location = new System.Drawing.Point(1004, 2);
            this.m_cmd_xuat_excel.Name = "m_cmd_xuat_excel";
            this.m_cmd_xuat_excel.Size = new System.Drawing.Size(148, 33);
            this.m_cmd_xuat_excel.TabIndex = 5;
            this.m_cmd_xuat_excel.Text = "Trích xuất dữ liệu";
            // 
            // imageCollection
            // 
            this.imageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection.ImageStream")));
            this.imageCollection.Images.SetKeyName(0, "dvmd_download.png");
            this.imageCollection.Images.SetKeyName(1, "dvmd_upload.png");
            this.imageCollection.Images.SetKeyName(2, "lock.png");
            this.imageCollection.Images.SetKeyName(3, "refresh.png");
            this.imageCollection.Images.SetKeyName(4, "dvmd_info.png");
            this.imageCollection.Images.SetKeyName(5, "play.png");
            this.imageCollection.Images.SetKeyName(6, "pause.png");
            this.imageCollection.Images.SetKeyName(7, "pencil.png");
            this.imageCollection.Images.SetKeyName(8, "trash.png");
            this.imageCollection.Images.SetKeyName(9, "grid.png");
            this.imageCollection.Images.SetKeyName(10, "list.png");
            this.imageCollection.Images.SetKeyName(11, "eye.png");
            this.imageCollection.Images.SetKeyName(12, "note.png");
            this.imageCollection.Images.SetKeyName(13, "magnifier.png");
            this.imageCollection.Images.SetKeyName(14, "close.png");
            this.imageCollection.Images.SetKeyName(15, "login.png");
            this.imageCollection.Images.SetKeyName(16, "logout.png");
            this.imageCollection.Images.SetKeyName(19, "1457269765_save.ico");
            // 
            // m_cmd_import_excel
            // 
            this.m_cmd_import_excel.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_import_excel.ImageIndex = 0;
            this.m_cmd_import_excel.ImageList = this.imageCollection;
            this.m_cmd_import_excel.Location = new System.Drawing.Point(156, 2);
            this.m_cmd_import_excel.Name = "m_cmd_import_excel";
            this.m_cmd_import_excel.Size = new System.Drawing.Size(205, 33);
            this.m_cmd_import_excel.TabIndex = 1;
            this.m_cmd_import_excel.Text = "Bước 2: Import dữ liệu Excel";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Controls.Add(this.m_lbl_ten_quy);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1158, 92);
            this.panelControl1.TabIndex = 0;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.m_cmd_xuat_excel);
            this.panelControl3.Controls.Add(this.m_cmd_save);
            this.panelControl3.Controls.Add(this.m_cmd_tinh_tien_thuong);
            this.panelControl3.Controls.Add(this.m_cmd_import_excel);
            this.panelControl3.Controls.Add(this.m_lbl_download_template);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl3.Location = new System.Drawing.Point(2, 53);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1154, 37);
            this.panelControl3.TabIndex = 0;
            // 
            // m_cmd_save
            // 
            this.m_cmd_save.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.m_cmd_save.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.m_cmd_save.Appearance.Options.UseFont = true;
            this.m_cmd_save.Appearance.Options.UseForeColor = true;
            this.m_cmd_save.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_save.ImageIndex = 19;
            this.m_cmd_save.ImageList = this.imageCollection;
            this.m_cmd_save.Location = new System.Drawing.Point(564, 2);
            this.m_cmd_save.Name = "m_cmd_save";
            this.m_cmd_save.Size = new System.Drawing.Size(222, 33);
            this.m_cmd_save.TabIndex = 3;
            this.m_cmd_save.Text = "Bước 4: Lưu vào phần mềm";
            // 
            // m_cmd_tinh_tien_thuong
            // 
            this.m_cmd_tinh_tien_thuong.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_tinh_tien_thuong.ImageIndex = 18;
            this.m_cmd_tinh_tien_thuong.ImageList = this.imageCollection;
            this.m_cmd_tinh_tien_thuong.Location = new System.Drawing.Point(361, 2);
            this.m_cmd_tinh_tien_thuong.Name = "m_cmd_tinh_tien_thuong";
            this.m_cmd_tinh_tien_thuong.Size = new System.Drawing.Size(203, 33);
            this.m_cmd_tinh_tien_thuong.TabIndex = 2;
            this.m_cmd_tinh_tien_thuong.Text = "Bước 3: Tính thành tiền";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.m_lbl_trang_thai_soan_thao);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 92);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1158, 37);
            this.panelControl2.TabIndex = 23;
            // 
            // m_lbl_trang_thai_soan_thao
            // 
            this.m_lbl_trang_thai_soan_thao.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.m_lbl_trang_thai_soan_thao.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.m_lbl_trang_thai_soan_thao.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_lbl_trang_thai_soan_thao.Location = new System.Drawing.Point(2, 2);
            this.m_lbl_trang_thai_soan_thao.Name = "m_lbl_trang_thai_soan_thao";
            this.m_lbl_trang_thai_soan_thao.Padding = new System.Windows.Forms.Padding(10);
            this.m_lbl_trang_thai_soan_thao.Size = new System.Drawing.Size(470, 33);
            this.m_lbl_trang_thai_soan_thao.TabIndex = 0;
            this.m_lbl_trang_thai_soan_thao.Text = "...";
            // 
            // m_pn
            // 
            this.m_pn.Controls.Add(this.label1);
            this.m_pn.Controls.Add(this.m_prb);
            this.m_pn.Location = new System.Drawing.Point(170, 216);
            this.m_pn.Name = "m_pn";
            this.m_pn.Padding = new System.Windows.Forms.Padding(10);
            this.m_pn.Size = new System.Drawing.Size(618, 68);
            this.m_pn.TabIndex = 24;
            this.m_pn.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Đang lưu dữ liệu. Vui lòng chờ trong giây lát...";
            // 
            // m_prb
            // 
            this.m_prb.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_prb.Location = new System.Drawing.Point(10, 10);
            this.m_prb.Name = "m_prb";
            this.m_prb.Properties.DisplayFormat.FormatString = "00";
            this.m_prb.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.m_prb.ShowProgressInTaskBar = true;
            this.m_prb.Size = new System.Drawing.Size(598, 30);
            this.m_prb.TabIndex = 2;
            this.m_prb.Visible = false;
            // 
            // m_bgw
            // 
            this.m_bgw.WorkerReportsProgress = true;
            this.m_bgw.WorkerSupportsCancellation = true;
            // 
            // f301_tinh_thu_nhap_khac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 554);
            this.Controls.Add(this.m_pn);
            this.Controls.Add(this.m_grc_main);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "f301_tinh_thu_nhap_khac";
            this.Text = "F301 - Tính tiền thu nhập khác nhân viên";
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.m_pn.ResumeLayout(false);
            this.m_pn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_prb.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl m_grc_main;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv_main;
        private DevExpress.XtraEditors.SimpleButton m_cmd_import_excel;
        private DevExpress.XtraEditors.LabelControl m_lbl_download_template;
        private DevExpress.XtraGrid.Columns.GridColumn MA_NV;
        private DevExpress.XtraGrid.Columns.GridColumn HE_SO;
        private DevExpress.XtraGrid.Columns.GridColumn THANH_TIEN;
        private DevExpress.XtraGrid.Columns.GridColumn THUE_PHAI_NOP;
        private DevExpress.XtraGrid.Columns.GridColumn THUC_LINH;
        private DevExpress.XtraGrid.Columns.GridColumn TEN_DON_VI;
        private DevExpress.XtraGrid.Columns.GridColumn CHUC_VU;
        private DevExpress.XtraGrid.Columns.GridColumn SO_TAI_KHOAN;
        private DevExpress.XtraGrid.Columns.GridColumn HO_TEN;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.SimpleButton m_cmd_xuat_excel;
        private DevExpress.XtraEditors.LabelControl m_lbl_ten_quy;
        private DevExpress.Utils.ImageCollection imageCollection;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.SimpleButton m_cmd_save;
        private DevExpress.XtraEditors.SimpleButton m_cmd_tinh_tien_thuong;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl m_lbl_trang_thai_soan_thao;
        private System.Windows.Forms.Panel m_pn;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.ProgressBarControl m_prb;
        private System.ComponentModel.BackgroundWorker m_bgw;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
    }
}