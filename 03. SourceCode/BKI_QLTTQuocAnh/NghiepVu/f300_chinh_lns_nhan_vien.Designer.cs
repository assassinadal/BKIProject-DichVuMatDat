﻿namespace BKI_DichVuMatDat.NghiepVu
{
    partial class f300_chinh_lns_nhan_vien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f300_chinh_lns_nhan_vien));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.m_tab_co_lns = new DevExpress.XtraTab.XtraTabPage();
            this.m_grc = new DevExpress.XtraGrid.GridControl();
            this.m_grv = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MA_NV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HO_TEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HE_SO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MA_CHUC_DANH_LNS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MUC_LNS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAY_BAT_DAU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAY_KET_THUC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.m_tab_k_lns = new DevExpress.XtraTab.XtraTabPage();
            this.m_grc_khs = new DevExpress.XtraGrid.GridControl();
            this.m_grv_khs = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMA_NV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO_TEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN_DON_VI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN_CHUC_VU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLOAI_LAO_DONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.m_cmd_delete = new DevExpress.XtraEditors.SimpleButton();
            this.img_DVMD = new DevExpress.Utils.ImageCollection(this.components);
            this.m_cmd_update = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_insert = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.m_lbl_ten_dv = new DevExpress.XtraLayout.SimpleLabelItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.m_tab_co_lns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv)).BeginInit();
            this.m_tab_k_lns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_khs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_khs)).BeginInit();
            this.m_pnl_out_place_dm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_DVMD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_lbl_ten_dv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.xtraTabControl1);
            this.layoutControl1.Controls.Add(this.m_pnl_out_place_dm);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(435, 233, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(931, 458);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(12, 80);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.m_tab_co_lns;
            this.xtraTabControl1.Size = new System.Drawing.Size(907, 366);
            this.xtraTabControl1.TabIndex = 6;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.m_tab_co_lns,
            this.m_tab_k_lns});
            // 
            // m_tab_co_lns
            // 
            this.m_tab_co_lns.Controls.Add(this.m_grc);
            this.m_tab_co_lns.Name = "m_tab_co_lns";
            this.m_tab_co_lns.Size = new System.Drawing.Size(901, 338);
            this.m_tab_co_lns.Text = "NHÂN VIÊN CÓ LƯƠNG NĂNG SUẤT";
            // 
            // m_grc
            // 
            this.m_grc.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc.Location = new System.Drawing.Point(0, 0);
            this.m_grc.MainView = this.m_grv;
            this.m_grc.Name = "m_grc";
            this.m_grc.Size = new System.Drawing.Size(901, 338);
            this.m_grc.TabIndex = 6;
            this.m_grc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv});
            // 
            // m_grv
            // 
            this.m_grv.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.MA_NV,
            this.HO_TEN,
            this.HE_SO,
            this.MA_CHUC_DANH_LNS,
            this.MUC_LNS,
            this.NGAY_BAT_DAU,
            this.NGAY_KET_THUC});
            this.m_grv.GridControl = this.m_grc;
            this.m_grv.Name = "m_grv";
            this.m_grv.OptionsView.ShowAutoFilterRow = true;
            this.m_grv.OptionsView.ShowFooter = true;
            // 
            // ID
            // 
            this.ID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.AppearanceHeader.Options.UseFont = true;
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            // 
            // MA_NV
            // 
            this.MA_NV.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MA_NV.AppearanceHeader.Options.UseFont = true;
            this.MA_NV.Caption = "Mã nhân viên";
            this.MA_NV.FieldName = "MA_NV";
            this.MA_NV.Name = "MA_NV";
            this.MA_NV.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "MA_NV", "Đã có LNS: {0:n0}")});
            this.MA_NV.Visible = true;
            this.MA_NV.VisibleIndex = 0;
            this.MA_NV.Width = 102;
            // 
            // HO_TEN
            // 
            this.HO_TEN.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HO_TEN.AppearanceHeader.Options.UseFont = true;
            this.HO_TEN.Caption = "Họ tên";
            this.HO_TEN.FieldName = "HO_TEN";
            this.HO_TEN.Name = "HO_TEN";
            this.HO_TEN.Visible = true;
            this.HO_TEN.VisibleIndex = 1;
            this.HO_TEN.Width = 163;
            // 
            // HE_SO
            // 
            this.HE_SO.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HE_SO.AppearanceHeader.Options.UseFont = true;
            this.HE_SO.Caption = "Hệ số";
            this.HE_SO.FieldName = "HE_SO";
            this.HE_SO.Name = "HE_SO";
            this.HE_SO.Visible = true;
            this.HE_SO.VisibleIndex = 2;
            this.HE_SO.Width = 43;
            // 
            // MA_CHUC_DANH_LNS
            // 
            this.MA_CHUC_DANH_LNS.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MA_CHUC_DANH_LNS.AppearanceHeader.Options.UseFont = true;
            this.MA_CHUC_DANH_LNS.Caption = "Mã chức danh";
            this.MA_CHUC_DANH_LNS.FieldName = "MA_CHUC_DANH_LNS";
            this.MA_CHUC_DANH_LNS.Name = "MA_CHUC_DANH_LNS";
            this.MA_CHUC_DANH_LNS.Visible = true;
            this.MA_CHUC_DANH_LNS.VisibleIndex = 3;
            this.MA_CHUC_DANH_LNS.Width = 98;
            // 
            // MUC_LNS
            // 
            this.MUC_LNS.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MUC_LNS.AppearanceHeader.Options.UseFont = true;
            this.MUC_LNS.Caption = "Mức";
            this.MUC_LNS.FieldName = "MUC_LNS";
            this.MUC_LNS.Name = "MUC_LNS";
            this.MUC_LNS.Visible = true;
            this.MUC_LNS.VisibleIndex = 4;
            this.MUC_LNS.Width = 40;
            // 
            // NGAY_BAT_DAU
            // 
            this.NGAY_BAT_DAU.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NGAY_BAT_DAU.AppearanceHeader.Options.UseFont = true;
            this.NGAY_BAT_DAU.Caption = "Ngày bắt đầu";
            this.NGAY_BAT_DAU.FieldName = "NGAY_BAT_DAU";
            this.NGAY_BAT_DAU.Name = "NGAY_BAT_DAU";
            this.NGAY_BAT_DAU.Visible = true;
            this.NGAY_BAT_DAU.VisibleIndex = 5;
            this.NGAY_BAT_DAU.Width = 129;
            // 
            // NGAY_KET_THUC
            // 
            this.NGAY_KET_THUC.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NGAY_KET_THUC.AppearanceHeader.Options.UseFont = true;
            this.NGAY_KET_THUC.Caption = "Ngày kết thúc";
            this.NGAY_KET_THUC.FieldName = "NGAY_KET_THUC";
            this.NGAY_KET_THUC.Name = "NGAY_KET_THUC";
            this.NGAY_KET_THUC.Visible = true;
            this.NGAY_KET_THUC.VisibleIndex = 6;
            this.NGAY_KET_THUC.Width = 143;
            // 
            // m_tab_k_lns
            // 
            this.m_tab_k_lns.Controls.Add(this.m_grc_khs);
            this.m_tab_k_lns.Name = "m_tab_k_lns";
            this.m_tab_k_lns.Size = new System.Drawing.Size(901, 338);
            this.m_tab_k_lns.Text = "NHÂN VIÊN KHÔNG CÓ LƯƠNG NĂNG SUẤT";
            // 
            // m_grc_khs
            // 
            this.m_grc_khs.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_khs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc_khs.Location = new System.Drawing.Point(0, 0);
            this.m_grc_khs.MainView = this.m_grv_khs;
            this.m_grc_khs.Name = "m_grc_khs";
            this.m_grc_khs.Size = new System.Drawing.Size(901, 338);
            this.m_grc_khs.TabIndex = 3;
            this.m_grc_khs.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv_khs});
            // 
            // m_grv_khs
            // 
            this.m_grv_khs.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.colMA_NV,
            this.colHO_TEN,
            this.colTEN_DON_VI,
            this.colTEN_CHUC_VU,
            this.colLOAI_LAO_DONG});
            this.m_grv_khs.GridControl = this.m_grc_khs;
            this.m_grv_khs.Name = "m_grv_khs";
            this.m_grv_khs.OptionsBehavior.ReadOnly = true;
            this.m_grv_khs.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.m_grv_khs.OptionsView.EnableAppearanceEvenRow = true;
            this.m_grv_khs.OptionsView.ShowAutoFilterRow = true;
            this.m_grv_khs.OptionsView.ShowFooter = true;
            this.m_grv_khs.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn1.AppearanceHeader.Options.UseFont = true;
            this.gridColumn1.Caption = "gridColumn1";
            this.gridColumn1.FieldName = "ID_NHAN_VIEN";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // colMA_NV
            // 
            this.colMA_NV.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMA_NV.AppearanceHeader.Options.UseFont = true;
            this.colMA_NV.Caption = "Mã nhân viên";
            this.colMA_NV.FieldName = "MA_NV";
            this.colMA_NV.Name = "colMA_NV";
            this.colMA_NV.Visible = true;
            this.colMA_NV.VisibleIndex = 0;
            this.colMA_NV.Width = 96;
            // 
            // colHO_TEN
            // 
            this.colHO_TEN.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colHO_TEN.AppearanceHeader.Options.UseFont = true;
            this.colHO_TEN.Caption = "Họ tên";
            this.colHO_TEN.FieldName = "HO_TEN";
            this.colHO_TEN.Name = "colHO_TEN";
            this.colHO_TEN.Visible = true;
            this.colHO_TEN.VisibleIndex = 1;
            this.colHO_TEN.Width = 260;
            // 
            // colTEN_DON_VI
            // 
            this.colTEN_DON_VI.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTEN_DON_VI.AppearanceHeader.Options.UseFont = true;
            this.colTEN_DON_VI.Caption = "Tên đơn vị";
            this.colTEN_DON_VI.FieldName = "TEN_DON_VI";
            this.colTEN_DON_VI.Name = "colTEN_DON_VI";
            this.colTEN_DON_VI.Visible = true;
            this.colTEN_DON_VI.VisibleIndex = 2;
            this.colTEN_DON_VI.Width = 184;
            // 
            // colTEN_CHUC_VU
            // 
            this.colTEN_CHUC_VU.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTEN_CHUC_VU.AppearanceHeader.Options.UseFont = true;
            this.colTEN_CHUC_VU.Caption = "Tên chức vụ";
            this.colTEN_CHUC_VU.FieldName = "TEN_CHUC_VU";
            this.colTEN_CHUC_VU.Name = "colTEN_CHUC_VU";
            this.colTEN_CHUC_VU.Visible = true;
            this.colTEN_CHUC_VU.VisibleIndex = 3;
            this.colTEN_CHUC_VU.Width = 229;
            // 
            // colLOAI_LAO_DONG
            // 
            this.colLOAI_LAO_DONG.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colLOAI_LAO_DONG.AppearanceHeader.Options.UseFont = true;
            this.colLOAI_LAO_DONG.Caption = "Loại lao động";
            this.colLOAI_LAO_DONG.FieldName = "LOAI_LAO_DONG";
            this.colLOAI_LAO_DONG.Name = "colLOAI_LAO_DONG";
            this.colLOAI_LAO_DONG.Visible = true;
            this.colLOAI_LAO_DONG.VisibleIndex = 4;
            this.colLOAI_LAO_DONG.Width = 135;
            // 
            // m_pnl_out_place_dm
            // 
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_delete);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_update);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_insert);
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(12, 40);
            this.m_pnl_out_place_dm.MaximumSize = new System.Drawing.Size(0, 36);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(907, 36);
            this.m_pnl_out_place_dm.TabIndex = 3;
            // 
            // m_cmd_delete
            // 
            this.m_cmd_delete.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_cmd_delete.Appearance.Options.UseFont = true;
            this.m_cmd_delete.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_delete.ImageIndex = 8;
            this.m_cmd_delete.ImageList = this.img_DVMD;
            this.m_cmd_delete.Location = new System.Drawing.Point(154, 4);
            this.m_cmd_delete.Name = "m_cmd_delete";
            this.m_cmd_delete.Size = new System.Drawing.Size(75, 28);
            this.m_cmd_delete.TabIndex = 0;
            this.m_cmd_delete.Text = "&Xóa";
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
            // m_cmd_update
            // 
            this.m_cmd_update.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_cmd_update.Appearance.Options.UseFont = true;
            this.m_cmd_update.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_update.ImageIndex = 9;
            this.m_cmd_update.ImageList = this.img_DVMD;
            this.m_cmd_update.Location = new System.Drawing.Point(79, 4);
            this.m_cmd_update.Name = "m_cmd_update";
            this.m_cmd_update.Size = new System.Drawing.Size(75, 28);
            this.m_cmd_update.TabIndex = 1;
            this.m_cmd_update.Text = "&Sửa";
            // 
            // m_cmd_insert
            // 
            this.m_cmd_insert.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_cmd_insert.Appearance.Options.UseFont = true;
            this.m_cmd_insert.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_insert.ImageIndex = 7;
            this.m_cmd_insert.ImageList = this.img_DVMD;
            this.m_cmd_insert.Location = new System.Drawing.Point(4, 4);
            this.m_cmd_insert.Name = "m_cmd_insert";
            this.m_cmd_insert.Size = new System.Drawing.Size(75, 28);
            this.m_cmd_insert.TabIndex = 2;
            this.m_cmd_insert.Text = "&Thêm";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.m_lbl_ten_dv,
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(931, 458);
            this.layoutControlGroup1.Text = "Root";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.m_pnl_out_place_dm;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 28);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(911, 40);
            this.layoutControlItem3.Text = "layoutControlItem3";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextToControlDistance = 0;
            this.layoutControlItem3.TextVisible = false;
            // 
            // m_lbl_ten_dv
            // 
            this.m_lbl_ten_dv.AllowHotTrack = false;
            this.m_lbl_ten_dv.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_ten_dv.AppearanceItemCaption.Options.UseFont = true;
            this.m_lbl_ten_dv.CustomizationFormText = "TEN_DON_VI";
            this.m_lbl_ten_dv.Location = new System.Drawing.Point(0, 0);
            this.m_lbl_ten_dv.Name = "m_lbl_ten_dv";
            this.m_lbl_ten_dv.Size = new System.Drawing.Size(911, 28);
            this.m_lbl_ten_dv.Text = "TEN_DON_VI";
            this.m_lbl_ten_dv.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.m_lbl_ten_dv.TextSize = new System.Drawing.Size(134, 24);
            this.m_lbl_ten_dv.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.xtraTabControl1;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 68);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(911, 370);
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // f300_chinh_lns_nhan_vien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 458);
            this.Controls.Add(this.layoutControl1);
            this.Name = "f300_chinh_lns_nhan_vien";
            this.Text = "F300 - Điều chỉnh lương năng suất nhân viên";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.m_tab_co_lns.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_grc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv)).EndInit();
            this.m_tab_k_lns.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_khs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_khs)).EndInit();
            this.m_pnl_out_place_dm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_DVMD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_lbl_ten_dv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.Utils.ImageCollection img_DVMD;
        private DevExpress.XtraLayout.SimpleLabelItem m_lbl_ten_dv;
        internal System.Windows.Forms.Panel m_pnl_out_place_dm;
        private DevExpress.XtraEditors.SimpleButton m_cmd_delete;
        private DevExpress.XtraEditors.SimpleButton m_cmd_update;
        private DevExpress.XtraEditors.SimpleButton m_cmd_insert;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage m_tab_co_lns;
        private DevExpress.XtraGrid.GridControl m_grc;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn MA_NV;
        private DevExpress.XtraGrid.Columns.GridColumn HO_TEN;
        private DevExpress.XtraGrid.Columns.GridColumn HE_SO;
        private DevExpress.XtraGrid.Columns.GridColumn MA_CHUC_DANH_LNS;
        private DevExpress.XtraGrid.Columns.GridColumn MUC_LNS;
        private DevExpress.XtraGrid.Columns.GridColumn NGAY_BAT_DAU;
        private DevExpress.XtraGrid.Columns.GridColumn NGAY_KET_THUC;
        private DevExpress.XtraTab.XtraTabPage m_tab_k_lns;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraGrid.GridControl m_grc_khs;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv_khs;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colMA_NV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO_TEN;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN_DON_VI;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN_CHUC_VU;
        private DevExpress.XtraGrid.Columns.GridColumn colLOAI_LAO_DONG;
    }
}