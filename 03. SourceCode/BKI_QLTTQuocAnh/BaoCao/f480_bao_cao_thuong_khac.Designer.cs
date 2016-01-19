namespace BKI_DichVuMatDat.BaoCao
{
    partial class f480_bao_cao_thuong_khac
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.m_cmd_xuat_excel = new DevExpress.XtraEditors.SimpleButton();
            this.m_grc_luong_thuong = new DevExpress.XtraGrid.GridControl();
            this.m_grv_luong_thuong = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MA_NV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HO_VA_TEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CHUC_VU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TONG_HS_ATHK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SO_TIEN_THUONG_NV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.ID_NHAN_VIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SO_TIEN_NOP_THE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SO_TIEN_THUC_LINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SO_TIEN_GIAM_TRU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TRUY_LINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TRUY_THU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.THUC_LINH_CUOI_CUNG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TEN_DON_VI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.m_sle_quy_thuong = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_luong_thuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_luong_thuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_sle_quy_thuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.m_cmd_xuat_excel);
            this.layoutControl1.Controls.Add(this.m_grc_luong_thuong);
            this.layoutControl1.Controls.Add(this.m_sle_quy_thuong);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(179, 180, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(976, 528);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // m_cmd_xuat_excel
            // 
            this.m_cmd_xuat_excel.Image = global::BKI_DichVuMatDat.Properties.Resources.table;
            this.m_cmd_xuat_excel.Location = new System.Drawing.Point(861, 486);
            this.m_cmd_xuat_excel.Name = "m_cmd_xuat_excel";
            this.m_cmd_xuat_excel.Size = new System.Drawing.Size(103, 30);
            this.m_cmd_xuat_excel.StyleController = this.layoutControl1;
            this.m_cmd_xuat_excel.TabIndex = 10;
            this.m_cmd_xuat_excel.Text = "Xuất Excel";
            this.m_cmd_xuat_excel.Click += new System.EventHandler(this.m_cmd_xuat_excel_Click);
            // 
            // m_grc_luong_thuong
            // 
            this.m_grc_luong_thuong.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_luong_thuong.Location = new System.Drawing.Point(12, 36);
            this.m_grc_luong_thuong.MainView = this.m_grv_luong_thuong;
            this.m_grc_luong_thuong.Name = "m_grc_luong_thuong";
            this.m_grc_luong_thuong.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            this.m_grc_luong_thuong.Size = new System.Drawing.Size(952, 446);
            this.m_grc_luong_thuong.TabIndex = 9;
            this.m_grc_luong_thuong.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv_luong_thuong});
            // 
            // m_grv_luong_thuong
            // 
            this.m_grv_luong_thuong.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MA_NV,
            this.HO_VA_TEN,
            this.CHUC_VU,
            this.TONG_HS_ATHK,
            this.SO_TIEN_THUONG_NV,
            this.ID_NHAN_VIEN,
            this.SO_TIEN_NOP_THE,
            this.SO_TIEN_THUC_LINH,
            this.SO_TIEN_GIAM_TRU,
            this.gridColumn4,
            this.TRUY_LINH,
            this.TRUY_THU,
            this.THUC_LINH_CUOI_CUNG,
            this.TEN_DON_VI});
            this.m_grv_luong_thuong.GridControl = this.m_grc_luong_thuong;
            this.m_grv_luong_thuong.GroupCount = 1;
            this.m_grv_luong_thuong.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SO_TIEN", this.SO_TIEN_THUONG_NV, "{0:n0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SO_TIEN_NOP_THE", this.SO_TIEN_NOP_THE, "{0:n0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SO_TIEN_THUC_LINH", this.SO_TIEN_THUC_LINH, "{0:n0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SO_TIEN_GIAM_TRU", this.SO_TIEN_GIAM_TRU, "{0:n0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "TRUY_LINH", this.TRUY_LINH, "{0:n0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "TRUY_THU", this.TRUY_THU, "{0:n0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "THUC_LINH_CUOI_CUNG", this.THUC_LINH_CUOI_CUNG, "{0:n0}")});
            this.m_grv_luong_thuong.Name = "m_grv_luong_thuong";
            this.m_grv_luong_thuong.OptionsBehavior.AutoExpandAllGroups = true;
            this.m_grv_luong_thuong.OptionsBehavior.Editable = false;
            this.m_grv_luong_thuong.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDown;
            this.m_grv_luong_thuong.OptionsBehavior.ReadOnly = true;
            this.m_grv_luong_thuong.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.m_grv_luong_thuong.OptionsView.ShowFooter = true;
            this.m_grv_luong_thuong.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.TEN_DON_VI, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // MA_NV
            // 
            this.MA_NV.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.MA_NV.AppearanceHeader.Options.UseFont = true;
            this.MA_NV.AppearanceHeader.Options.UseTextOptions = true;
            this.MA_NV.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.MA_NV.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.MA_NV.Caption = "Mã nhân viên";
            this.MA_NV.FieldName = "MA_NV";
            this.MA_NV.Name = "MA_NV";
            this.MA_NV.Visible = true;
            this.MA_NV.VisibleIndex = 0;
            this.MA_NV.Width = 63;
            // 
            // HO_VA_TEN
            // 
            this.HO_VA_TEN.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.HO_VA_TEN.AppearanceHeader.Options.UseFont = true;
            this.HO_VA_TEN.AppearanceHeader.Options.UseTextOptions = true;
            this.HO_VA_TEN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.HO_VA_TEN.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.HO_VA_TEN.Caption = "Họ tên";
            this.HO_VA_TEN.FieldName = "HO_VA_TEN";
            this.HO_VA_TEN.Name = "HO_VA_TEN";
            this.HO_VA_TEN.Visible = true;
            this.HO_VA_TEN.VisibleIndex = 1;
            this.HO_VA_TEN.Width = 118;
            // 
            // CHUC_VU
            // 
            this.CHUC_VU.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.CHUC_VU.AppearanceHeader.Options.UseFont = true;
            this.CHUC_VU.AppearanceHeader.Options.UseTextOptions = true;
            this.CHUC_VU.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CHUC_VU.Caption = "Chức vụ";
            this.CHUC_VU.FieldName = "CHUC_VU";
            this.CHUC_VU.FieldNameSortGroup = "THU_TU_CHUC_VU";
            this.CHUC_VU.Name = "CHUC_VU";
            this.CHUC_VU.Visible = true;
            this.CHUC_VU.VisibleIndex = 3;
            this.CHUC_VU.Width = 89;
            // 
            // TONG_HS_ATHK
            // 
            this.TONG_HS_ATHK.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.TONG_HS_ATHK.AppearanceHeader.Options.UseFont = true;
            this.TONG_HS_ATHK.AppearanceHeader.Options.UseTextOptions = true;
            this.TONG_HS_ATHK.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TONG_HS_ATHK.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.TONG_HS_ATHK.Caption = "Tổng Hệ số ATHK";
            this.TONG_HS_ATHK.FieldName = "TONG_HS_ATHK";
            this.TONG_HS_ATHK.Name = "TONG_HS_ATHK";
            this.TONG_HS_ATHK.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TONG_HS_ATHK", "Tổng = {0}")});
            this.TONG_HS_ATHK.Width = 56;
            // 
            // SO_TIEN_THUONG_NV
            // 
            this.SO_TIEN_THUONG_NV.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.SO_TIEN_THUONG_NV.AppearanceHeader.Options.UseFont = true;
            this.SO_TIEN_THUONG_NV.AppearanceHeader.Options.UseTextOptions = true;
            this.SO_TIEN_THUONG_NV.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SO_TIEN_THUONG_NV.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.SO_TIEN_THUONG_NV.Caption = "Số tiền thưởng (1)";
            this.SO_TIEN_THUONG_NV.ColumnEdit = this.repositoryItemTextEdit1;
            this.SO_TIEN_THUONG_NV.DisplayFormat.FormatString = "n0";
            this.SO_TIEN_THUONG_NV.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.SO_TIEN_THUONG_NV.FieldName = "SO_TIEN";
            this.SO_TIEN_THUONG_NV.Name = "SO_TIEN_THUONG_NV";
            this.SO_TIEN_THUONG_NV.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SO_TIEN", "Tổng = {0:n0}")});
            this.SO_TIEN_THUONG_NV.Visible = true;
            this.SO_TIEN_THUONG_NV.VisibleIndex = 4;
            this.SO_TIEN_THUONG_NV.Width = 153;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Mask.EditMask = "n0";
            this.repositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // ID_NHAN_VIEN
            // 
            this.ID_NHAN_VIEN.Caption = "ID_NHAN_VIEN";
            this.ID_NHAN_VIEN.FieldName = "ID_NHAN_VIEN";
            this.ID_NHAN_VIEN.Name = "ID_NHAN_VIEN";
            // 
            // SO_TIEN_NOP_THE
            // 
            this.SO_TIEN_NOP_THE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.SO_TIEN_NOP_THE.AppearanceHeader.Options.UseFont = true;
            this.SO_TIEN_NOP_THE.AppearanceHeader.Options.UseTextOptions = true;
            this.SO_TIEN_NOP_THE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SO_TIEN_NOP_THE.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.SO_TIEN_NOP_THE.Caption = "Số thuế phải nộp (2)";
            this.SO_TIEN_NOP_THE.DisplayFormat.FormatString = "n0";
            this.SO_TIEN_NOP_THE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.SO_TIEN_NOP_THE.FieldName = "SO_TIEN_NOP_THE";
            this.SO_TIEN_NOP_THE.Name = "SO_TIEN_NOP_THE";
            this.SO_TIEN_NOP_THE.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SO_TIEN_NOP_THE", "Tổng = {0:n0}")});
            this.SO_TIEN_NOP_THE.Visible = true;
            this.SO_TIEN_NOP_THE.VisibleIndex = 5;
            this.SO_TIEN_NOP_THE.Width = 98;
            // 
            // SO_TIEN_THUC_LINH
            // 
            this.SO_TIEN_THUC_LINH.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.SO_TIEN_THUC_LINH.AppearanceHeader.Options.UseFont = true;
            this.SO_TIEN_THUC_LINH.AppearanceHeader.Options.UseTextOptions = true;
            this.SO_TIEN_THUC_LINH.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SO_TIEN_THUC_LINH.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.SO_TIEN_THUC_LINH.Caption = "Thực lĩnh (3) = (1) - (2)";
            this.SO_TIEN_THUC_LINH.DisplayFormat.FormatString = "n0";
            this.SO_TIEN_THUC_LINH.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.SO_TIEN_THUC_LINH.FieldName = "SO_TIEN_THUC_LINH";
            this.SO_TIEN_THUC_LINH.Name = "SO_TIEN_THUC_LINH";
            this.SO_TIEN_THUC_LINH.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SO_TIEN_THUC_LINH", "Tổng = {0:n0}")});
            this.SO_TIEN_THUC_LINH.Visible = true;
            this.SO_TIEN_THUC_LINH.VisibleIndex = 6;
            this.SO_TIEN_THUC_LINH.Width = 96;
            // 
            // SO_TIEN_GIAM_TRU
            // 
            this.SO_TIEN_GIAM_TRU.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.SO_TIEN_GIAM_TRU.AppearanceHeader.Options.UseFont = true;
            this.SO_TIEN_GIAM_TRU.AppearanceHeader.Options.UseTextOptions = true;
            this.SO_TIEN_GIAM_TRU.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SO_TIEN_GIAM_TRU.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.SO_TIEN_GIAM_TRU.Caption = "Giảm trừ (2)";
            this.SO_TIEN_GIAM_TRU.DisplayFormat.FormatString = "n0";
            this.SO_TIEN_GIAM_TRU.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.SO_TIEN_GIAM_TRU.FieldName = "SO_TIEN_GIAM_TRU";
            this.SO_TIEN_GIAM_TRU.Name = "SO_TIEN_GIAM_TRU";
            this.SO_TIEN_GIAM_TRU.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SO_TIEN_GIAM_TRU", "Tổng = {0:n0}")});
            this.SO_TIEN_GIAM_TRU.Width = 99;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridColumn4.AppearanceHeader.Options.UseFont = true;
            this.gridColumn4.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn4.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridColumn4.Caption = "Số tài khoản";
            this.gridColumn4.FieldName = "SO_TAI_KHOAN";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            this.gridColumn4.Width = 77;
            // 
            // TRUY_LINH
            // 
            this.TRUY_LINH.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.TRUY_LINH.AppearanceHeader.Options.UseFont = true;
            this.TRUY_LINH.AppearanceHeader.Options.UseTextOptions = true;
            this.TRUY_LINH.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TRUY_LINH.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.TRUY_LINH.Caption = "Truy lĩnh (4)";
            this.TRUY_LINH.DisplayFormat.FormatString = "n0";
            this.TRUY_LINH.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TRUY_LINH.FieldName = "TRUY_LINH";
            this.TRUY_LINH.Name = "TRUY_LINH";
            this.TRUY_LINH.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TRUY_LINH", "{0:n0}")});
            this.TRUY_LINH.Visible = true;
            this.TRUY_LINH.VisibleIndex = 7;
            this.TRUY_LINH.Width = 77;
            // 
            // TRUY_THU
            // 
            this.TRUY_THU.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.TRUY_THU.AppearanceHeader.Options.UseFont = true;
            this.TRUY_THU.AppearanceHeader.Options.UseTextOptions = true;
            this.TRUY_THU.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TRUY_THU.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.TRUY_THU.Caption = "Truy thu (5)";
            this.TRUY_THU.DisplayFormat.FormatString = "n0";
            this.TRUY_THU.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TRUY_THU.FieldName = "TRUY_THU";
            this.TRUY_THU.Name = "TRUY_THU";
            this.TRUY_THU.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TRUY_THU", "{0:n0}")});
            this.TRUY_THU.Visible = true;
            this.TRUY_THU.VisibleIndex = 8;
            this.TRUY_THU.Width = 77;
            // 
            // THUC_LINH_CUOI_CUNG
            // 
            this.THUC_LINH_CUOI_CUNG.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.THUC_LINH_CUOI_CUNG.AppearanceHeader.Options.UseFont = true;
            this.THUC_LINH_CUOI_CUNG.AppearanceHeader.Options.UseTextOptions = true;
            this.THUC_LINH_CUOI_CUNG.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.THUC_LINH_CUOI_CUNG.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.THUC_LINH_CUOI_CUNG.Caption = "Thực lĩnh cuối cùng (6) = (3) + (4) - (5)";
            this.THUC_LINH_CUOI_CUNG.DisplayFormat.FormatString = "n0";
            this.THUC_LINH_CUOI_CUNG.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.THUC_LINH_CUOI_CUNG.FieldName = "THUC_LINH_CUOI_CUNG";
            this.THUC_LINH_CUOI_CUNG.Name = "THUC_LINH_CUOI_CUNG";
            this.THUC_LINH_CUOI_CUNG.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "THUC_LINH_CUOI_CUNG", "{0:n0}")});
            this.THUC_LINH_CUOI_CUNG.Visible = true;
            this.THUC_LINH_CUOI_CUNG.VisibleIndex = 9;
            this.THUC_LINH_CUOI_CUNG.Width = 86;
            // 
            // TEN_DON_VI
            // 
            this.TEN_DON_VI.Caption = "Đơn vị";
            this.TEN_DON_VI.FieldName = "TEN_DON_VI";
            this.TEN_DON_VI.FieldNameSortGroup = "THU_TU_HIEN_THI";
            this.TEN_DON_VI.Name = "TEN_DON_VI";
            this.TEN_DON_VI.Visible = true;
            this.TEN_DON_VI.VisibleIndex = 10;
            // 
            // m_sle_quy_thuong
            // 
            this.m_sle_quy_thuong.Location = new System.Drawing.Point(92, 12);
            this.m_sle_quy_thuong.Name = "m_sle_quy_thuong";
            this.m_sle_quy_thuong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.m_sle_quy_thuong.Properties.View = this.searchLookUpEdit1View;
            this.m_sle_quy_thuong.Size = new System.Drawing.Size(872, 20);
            this.m_sle_quy_thuong.StyleController = this.layoutControl1;
            this.m_sle_quy_thuong.TabIndex = 6;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.emptySpaceItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(976, 528);
            this.layoutControlGroup1.Text = "Root";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.m_sle_quy_thuong;
            this.layoutControlItem2.CustomizationFormText = "Tên quỹ thưởng";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(956, 24);
            this.layoutControlItem2.Text = "Tên quỹ thưởng";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(77, 13);
            this.layoutControlItem2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.m_grc_luong_thuong;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(956, 450);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.m_cmd_xuat_excel;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(849, 474);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(107, 34);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(107, 34);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(107, 34);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.Text = "layoutControlItem3";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextToControlDistance = 0;
            this.layoutControlItem3.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 474);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(849, 34);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // f480_bao_cao_thuong_khac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 528);
            this.Controls.Add(this.layoutControl1);
            this.Name = "f480_bao_cao_thuong_khac";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "F480 - Chi tiết thưởng khác";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_luong_thuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_luong_thuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_sle_quy_thuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.SearchLookUpEdit m_sle_quy_thuong;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraGrid.GridControl m_grc_luong_thuong;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv_luong_thuong;
        private DevExpress.XtraGrid.Columns.GridColumn MA_NV;
        private DevExpress.XtraGrid.Columns.GridColumn HO_VA_TEN;
        private DevExpress.XtraGrid.Columns.GridColumn CHUC_VU;
        private DevExpress.XtraGrid.Columns.GridColumn TONG_HS_ATHK;
        private DevExpress.XtraGrid.Columns.GridColumn SO_TIEN_THUONG_NV;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn ID_NHAN_VIEN;
        private DevExpress.XtraGrid.Columns.GridColumn SO_TIEN_NOP_THE;
        private DevExpress.XtraGrid.Columns.GridColumn SO_TIEN_THUC_LINH;
        private DevExpress.XtraGrid.Columns.GridColumn SO_TIEN_GIAM_TRU;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton m_cmd_xuat_excel;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn TRUY_LINH;
        private DevExpress.XtraGrid.Columns.GridColumn TRUY_THU;
        private DevExpress.XtraGrid.Columns.GridColumn THUC_LINH_CUOI_CUNG;
        private DevExpress.XtraGrid.Columns.GridColumn TEN_DON_VI;

    }
}