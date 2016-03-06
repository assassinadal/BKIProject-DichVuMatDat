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
            this.layoutControlMain = new DevExpress.XtraLayout.LayoutControl();
            this.m_lbl_ten_quy = new DevExpress.XtraEditors.LabelControl();
            this.m_cmd_xuat_excel = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_tinh_tien_thuong = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_save = new DevExpress.XtraEditors.SimpleButton();
            this.m_lbl_download_template = new DevExpress.XtraEditors.LabelControl();
            this.m_cmd_import_excel = new DevExpress.XtraEditors.SimpleButton();
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
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItemGrid = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItemDownload = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemSave = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.m_cmd_xuat_excel_layout = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::BKI_DichVuMatDat.BaoCao.F_wait_form), true, true);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlMain)).BeginInit();
            this.layoutControlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemDownload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_cmd_xuat_excel_layout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControlMain
            // 
            this.layoutControlMain.Controls.Add(this.m_lbl_ten_quy);
            this.layoutControlMain.Controls.Add(this.m_cmd_xuat_excel);
            this.layoutControlMain.Controls.Add(this.m_cmd_tinh_tien_thuong);
            this.layoutControlMain.Controls.Add(this.m_cmd_save);
            this.layoutControlMain.Controls.Add(this.m_lbl_download_template);
            this.layoutControlMain.Controls.Add(this.m_cmd_import_excel);
            this.layoutControlMain.Controls.Add(this.m_grc_main);
            this.layoutControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControlMain.Location = new System.Drawing.Point(0, 0);
            this.layoutControlMain.Name = "layoutControlMain";
            this.layoutControlMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(676, 297, 250, 337);
            this.layoutControlMain.Root = this.layoutControlGroup1;
            this.layoutControlMain.Size = new System.Drawing.Size(1158, 529);
            this.layoutControlMain.TabIndex = 0;
            this.layoutControlMain.Text = "layoutControl1";
            // 
            // m_lbl_ten_quy
            // 
            this.m_lbl_ten_quy.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.m_lbl_ten_quy.Location = new System.Drawing.Point(43, 20);
            this.m_lbl_ten_quy.Name = "m_lbl_ten_quy";
            this.m_lbl_ten_quy.Size = new System.Drawing.Size(85, 16);
            this.m_lbl_ten_quy.StyleController = this.layoutControlMain;
            this.m_lbl_ten_quy.TabIndex = 21;
            this.m_lbl_ten_quy.Text = "...";
            // 
            // m_cmd_xuat_excel
            // 
            this.m_cmd_xuat_excel.Image = global::BKI_DichVuMatDat.Properties.Resources.grid;
            this.m_cmd_xuat_excel.Location = new System.Drawing.Point(1004, 48);
            this.m_cmd_xuat_excel.Name = "m_cmd_xuat_excel";
            this.m_cmd_xuat_excel.Size = new System.Drawing.Size(142, 30);
            this.m_cmd_xuat_excel.StyleController = this.layoutControlMain;
            this.m_cmd_xuat_excel.TabIndex = 20;
            this.m_cmd_xuat_excel.Text = "Trích xuất dữ liệu";
            // 
            // m_cmd_tinh_tien_thuong
            // 
            this.m_cmd_tinh_tien_thuong.Image = global::BKI_DichVuMatDat.Properties.Resources.sum;
            this.m_cmd_tinh_tien_thuong.Location = new System.Drawing.Point(221, 48);
            this.m_cmd_tinh_tien_thuong.Name = "m_cmd_tinh_tien_thuong";
            this.m_cmd_tinh_tien_thuong.Size = new System.Drawing.Size(203, 30);
            this.m_cmd_tinh_tien_thuong.StyleController = this.layoutControlMain;
            this.m_cmd_tinh_tien_thuong.TabIndex = 16;
            this.m_cmd_tinh_tien_thuong.Text = "Bước 2: Tính tiền thưởng";
            // 
            // m_cmd_save
            // 
            this.m_cmd_save.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.m_cmd_save.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.m_cmd_save.Appearance.Options.UseFont = true;
            this.m_cmd_save.Appearance.Options.UseForeColor = true;
            this.m_cmd_save.Image = global::BKI_DichVuMatDat.Properties.Resources.Save;
            this.m_cmd_save.Location = new System.Drawing.Point(12, 479);
            this.m_cmd_save.Name = "m_cmd_save";
            this.m_cmd_save.Size = new System.Drawing.Size(222, 38);
            this.m_cmd_save.StyleController = this.layoutControlMain;
            this.m_cmd_save.TabIndex = 15;
            this.m_cmd_save.Text = "Bước 3: Lưu tiền thưởng đã tính";
            // 
            // m_lbl_download_template
            // 
            this.m_lbl_download_template.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_lbl_download_template.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.m_lbl_download_template.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_download_template.LineVisible = true;
            this.m_lbl_download_template.Location = new System.Drawing.Point(846, 56);
            this.m_lbl_download_template.Name = "m_lbl_download_template";
            this.m_lbl_download_template.Size = new System.Drawing.Size(154, 14);
            this.m_lbl_download_template.StyleController = this.layoutControlMain;
            this.m_lbl_download_template.TabIndex = 14;
            this.m_lbl_download_template.Text = "Tạo file Excel import mới!";
            // 
            // m_cmd_import_excel
            // 
            this.m_cmd_import_excel.Image = global::BKI_DichVuMatDat.Properties.Resources.upload;
            this.m_cmd_import_excel.Location = new System.Drawing.Point(12, 48);
            this.m_cmd_import_excel.Name = "m_cmd_import_excel";
            this.m_cmd_import_excel.Size = new System.Drawing.Size(205, 30);
            this.m_cmd_import_excel.StyleController = this.layoutControlMain;
            this.m_cmd_import_excel.TabIndex = 13;
            this.m_cmd_import_excel.Text = "Bước 1: Import Excel tiền thưởng";
            // 
            // m_grc_main
            // 
            this.m_grc_main.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_main.Location = new System.Drawing.Point(12, 82);
            this.m_grc_main.MainView = this.m_grv_main;
            this.m_grc_main.Name = "m_grc_main";
            this.m_grc_main.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            this.m_grc_main.Size = new System.Drawing.Size(1134, 393);
            this.m_grc_main.TabIndex = 11;
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
            this.HE_SO.FieldName = "HE_SO";
            this.HE_SO.Name = "HE_SO";
            this.HE_SO.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "HE_SO", "{0:n0}")});
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
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItemGrid,
            this.layoutControlItem5,
            this.emptySpaceItem1,
            this.layoutControlItemSave,
            this.layoutControlItem3,
            this.layoutControlItem1,
            this.m_cmd_xuat_excel_layout,
            this.layoutControlItemDownload});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1158, 529);
            this.layoutControlGroup1.Text = "Root";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItemGrid
            // 
            this.layoutControlItemGrid.Control = this.m_grc_main;
            this.layoutControlItemGrid.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItemGrid.Location = new System.Drawing.Point(0, 70);
            this.layoutControlItemGrid.Name = "layoutControlItemGrid";
            this.layoutControlItemGrid.Size = new System.Drawing.Size(1138, 397);
            this.layoutControlItemGrid.Text = "layoutControlItemGrid";
            this.layoutControlItemGrid.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItemGrid.TextToControlDistance = 0;
            this.layoutControlItemGrid.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.m_cmd_import_excel;
            this.layoutControlItem5.CustomizationFormText = "layoutControlItem5";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 36);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(209, 34);
            this.layoutControlItem5.Text = "layoutControlItem5";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextToControlDistance = 0;
            this.layoutControlItem5.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(416, 36);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(418, 34);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItemDownload
            // 
            this.layoutControlItemDownload.Control = this.m_lbl_download_template;
            this.layoutControlItemDownload.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.layoutControlItemDownload.CustomizationFormText = "Tải File Excel mẫu!";
            this.layoutControlItemDownload.Location = new System.Drawing.Point(834, 36);
            this.layoutControlItemDownload.Name = "layoutControlItemDownload";
            this.layoutControlItemDownload.Size = new System.Drawing.Size(158, 34);
            this.layoutControlItemDownload.Text = "Tải File Excel mẫu!";
            this.layoutControlItemDownload.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItemDownload.TextToControlDistance = 0;
            this.layoutControlItemDownload.TextVisible = false;
            this.layoutControlItemDownload.TrimClientAreaToControl = false;
            // 
            // layoutControlItemSave
            // 
            this.layoutControlItemSave.Control = this.m_cmd_save;
            this.layoutControlItemSave.CustomizationFormText = "layoutControlItemSave";
            this.layoutControlItemSave.Location = new System.Drawing.Point(0, 467);
            this.layoutControlItemSave.MaxSize = new System.Drawing.Size(226, 42);
            this.layoutControlItemSave.MinSize = new System.Drawing.Size(226, 42);
            this.layoutControlItemSave.Name = "layoutControlItemSave";
            this.layoutControlItemSave.Size = new System.Drawing.Size(1138, 42);
            this.layoutControlItemSave.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItemSave.Text = "layoutControlItemSave";
            this.layoutControlItemSave.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItemSave.TextToControlDistance = 0;
            this.layoutControlItemSave.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.m_cmd_tinh_tien_thuong;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(209, 36);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(207, 34);
            this.layoutControlItem3.Text = "layoutControlItem3";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextToControlDistance = 0;
            this.layoutControlItem3.TextVisible = false;
            // 
            // m_cmd_xuat_excel_layout
            // 
            this.m_cmd_xuat_excel_layout.Control = this.m_cmd_xuat_excel;
            this.m_cmd_xuat_excel_layout.CustomizationFormText = "Trích xuất dữ liệu";
            this.m_cmd_xuat_excel_layout.Location = new System.Drawing.Point(992, 36);
            this.m_cmd_xuat_excel_layout.Name = "m_cmd_xuat_excel_layout";
            this.m_cmd_xuat_excel_layout.Size = new System.Drawing.Size(146, 34);
            this.m_cmd_xuat_excel_layout.Text = "Trích xuất dữ liệu";
            this.m_cmd_xuat_excel_layout.TextSize = new System.Drawing.Size(0, 0);
            this.m_cmd_xuat_excel_layout.TextToControlDistance = 0;
            this.m_cmd_xuat_excel_layout.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.m_lbl_ten_quy;
            this.layoutControlItem1.CustomizationFormText = "Quỹ";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(128, 36);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(128, 36);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem1.Size = new System.Drawing.Size(1138, 36);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.Text = "Quỹ";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(20, 13);
            // 
            // f301_tinh_thu_nhap_khac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 529);
            this.Controls.Add(this.layoutControlMain);
            this.Name = "f301_tinh_thu_nhap_khac";
            this.Text = "F301 - Tính thưởng nhân viên";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlMain)).EndInit();
            this.layoutControlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemDownload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_cmd_xuat_excel_layout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControlMain;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl m_grc_main;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv_main;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemGrid;
        private DevExpress.XtraEditors.SimpleButton m_cmd_import_excel;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.LabelControl m_lbl_download_template;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemDownload;
        private DevExpress.XtraGrid.Columns.GridColumn MA_NV;
        private DevExpress.XtraGrid.Columns.GridColumn HE_SO;
        private DevExpress.XtraGrid.Columns.GridColumn THANH_TIEN;
        private DevExpress.XtraGrid.Columns.GridColumn THUE_PHAI_NOP;
        private DevExpress.XtraGrid.Columns.GridColumn THUC_LINH;
        private DevExpress.XtraGrid.Columns.GridColumn TEN_DON_VI;
        private DevExpress.XtraGrid.Columns.GridColumn CHUC_VU;
        private DevExpress.XtraGrid.Columns.GridColumn SO_TAI_KHOAN;
        private DevExpress.XtraGrid.Columns.GridColumn HO_TEN;
        private DevExpress.XtraEditors.SimpleButton m_cmd_save;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemSave;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
        private DevExpress.XtraEditors.SimpleButton m_cmd_tinh_tien_thuong;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.SimpleButton m_cmd_xuat_excel;
        private DevExpress.XtraLayout.LayoutControlItem m_cmd_xuat_excel_layout;
        private DevExpress.XtraEditors.LabelControl m_lbl_ten_quy;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
    }
}