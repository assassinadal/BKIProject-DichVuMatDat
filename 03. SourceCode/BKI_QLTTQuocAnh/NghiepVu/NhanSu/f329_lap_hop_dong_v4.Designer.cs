﻿namespace BKI_DichVuMatDat.NghiepVu.NhanSu
{
    partial class f329_lap_hop_dong_v4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f329_lap_hop_dong_v4));
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.m_grc = new DevExpress.XtraGrid.GridControl();
            this.m_grv = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMA_NV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO_TEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMA_HOP_DONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMA_LOAI_HOP_DONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAY_BAT_DAU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAY_KET_THUC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAY_KY_HOP_DONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMA_LCD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMUC_LCD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN_CHUC_VU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSO_TIEN_LCD_THUC_TE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN_DON_VI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSO_TIEN_MAC_DINH_LCD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAY_LAP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLOAI_LAO_DONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.m_cmd_refresh = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_print = new DevExpress.XtraEditors.SimpleButton();
            this.img_DVMD = new DevExpress.Utils.ImageCollection(this.components);
            this.m_cmd_xuat_excel = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_delete = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_update = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_insert = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_DVMD)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.m_grc);
            this.panelControl2.Controls.Add(this.panelControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1099, 559);
            this.panelControl2.TabIndex = 8;
            // 
            // m_grc
            // 
            this.m_grc.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc.Location = new System.Drawing.Point(2, 42);
            this.m_grc.MainView = this.m_grv;
            this.m_grc.Name = "m_grc";
            this.m_grc.Size = new System.Drawing.Size(1095, 515);
            this.m_grc.TabIndex = 7;
            this.m_grc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv});
            // 
            // m_grv
            // 
            this.m_grv.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMA_NV,
            this.colHO_TEN,
            this.colMA_HOP_DONG,
            this.colMA_LOAI_HOP_DONG,
            this.colNGAY_BAT_DAU,
            this.colNGAY_KET_THUC,
            this.colNGAY_KY_HOP_DONG,
            this.colMA_LCD,
            this.colMUC_LCD,
            this.colTEN_CHUC_VU,
            this.colSO_TIEN_LCD_THUC_TE,
            this.colTEN_DON_VI,
            this.colSO_TIEN_MAC_DINH_LCD,
            this.colNGAY_LAP,
            this.colLOAI_LAO_DONG});
            this.m_grv.GridControl = this.m_grc;
            this.m_grv.Name = "m_grv";
            this.m_grv.OptionsBehavior.ReadOnly = true;
            this.m_grv.OptionsFind.AllowFindPanel = false;
            this.m_grv.OptionsFind.AlwaysVisible = true;
            this.m_grv.OptionsView.ColumnAutoWidth = false;
            this.m_grv.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            // 
            // colMA_NV
            // 
            this.colMA_NV.AppearanceCell.Options.UseTextOptions = true;
            this.colMA_NV.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMA_NV.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colMA_NV.AppearanceHeader.Options.UseFont = true;
            this.colMA_NV.AppearanceHeader.Options.UseTextOptions = true;
            this.colMA_NV.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMA_NV.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colMA_NV.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colMA_NV.Caption = "Mã NV";
            this.colMA_NV.FieldName = "MA_NV";
            this.colMA_NV.Name = "colMA_NV";
            this.colMA_NV.OptionsColumn.AllowEdit = false;
            this.colMA_NV.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "MA_NV", "{0:n0}")});
            this.colMA_NV.Visible = true;
            this.colMA_NV.VisibleIndex = 2;
            // 
            // colHO_TEN
            // 
            this.colHO_TEN.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colHO_TEN.AppearanceHeader.Options.UseFont = true;
            this.colHO_TEN.AppearanceHeader.Options.UseTextOptions = true;
            this.colHO_TEN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHO_TEN.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colHO_TEN.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colHO_TEN.Caption = "Họ tên";
            this.colHO_TEN.FieldName = "HO_TEN";
            this.colHO_TEN.Name = "colHO_TEN";
            this.colHO_TEN.OptionsColumn.AllowEdit = false;
            this.colHO_TEN.Visible = true;
            this.colHO_TEN.VisibleIndex = 3;
            this.colHO_TEN.Width = 157;
            // 
            // colMA_HOP_DONG
            // 
            this.colMA_HOP_DONG.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colMA_HOP_DONG.AppearanceHeader.Options.UseFont = true;
            this.colMA_HOP_DONG.AppearanceHeader.Options.UseTextOptions = true;
            this.colMA_HOP_DONG.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMA_HOP_DONG.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colMA_HOP_DONG.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colMA_HOP_DONG.Caption = "Mã HĐ";
            this.colMA_HOP_DONG.FieldName = "MA_HOP_DONG";
            this.colMA_HOP_DONG.Name = "colMA_HOP_DONG";
            this.colMA_HOP_DONG.OptionsColumn.AllowEdit = false;
            this.colMA_HOP_DONG.Visible = true;
            this.colMA_HOP_DONG.VisibleIndex = 1;
            this.colMA_HOP_DONG.Width = 58;
            // 
            // colMA_LOAI_HOP_DONG
            // 
            this.colMA_LOAI_HOP_DONG.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colMA_LOAI_HOP_DONG.AppearanceHeader.Options.UseFont = true;
            this.colMA_LOAI_HOP_DONG.AppearanceHeader.Options.UseTextOptions = true;
            this.colMA_LOAI_HOP_DONG.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMA_LOAI_HOP_DONG.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colMA_LOAI_HOP_DONG.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colMA_LOAI_HOP_DONG.Caption = "Loại HĐ";
            this.colMA_LOAI_HOP_DONG.FieldName = "MA_LOAI_HOP_DONG";
            this.colMA_LOAI_HOP_DONG.Name = "colMA_LOAI_HOP_DONG";
            this.colMA_LOAI_HOP_DONG.OptionsColumn.AllowEdit = false;
            this.colMA_LOAI_HOP_DONG.Visible = true;
            this.colMA_LOAI_HOP_DONG.VisibleIndex = 0;
            this.colMA_LOAI_HOP_DONG.Width = 47;
            // 
            // colNGAY_BAT_DAU
            // 
            this.colNGAY_BAT_DAU.AppearanceCell.Options.UseTextOptions = true;
            this.colNGAY_BAT_DAU.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNGAY_BAT_DAU.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colNGAY_BAT_DAU.AppearanceHeader.Options.UseFont = true;
            this.colNGAY_BAT_DAU.AppearanceHeader.Options.UseTextOptions = true;
            this.colNGAY_BAT_DAU.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNGAY_BAT_DAU.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colNGAY_BAT_DAU.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colNGAY_BAT_DAU.Caption = "Ngày bắt đầu";
            this.colNGAY_BAT_DAU.FieldName = "NGAY_BAT_DAU";
            this.colNGAY_BAT_DAU.Name = "colNGAY_BAT_DAU";
            this.colNGAY_BAT_DAU.OptionsColumn.AllowEdit = false;
            this.colNGAY_BAT_DAU.Visible = true;
            this.colNGAY_BAT_DAU.VisibleIndex = 4;
            // 
            // colNGAY_KET_THUC
            // 
            this.colNGAY_KET_THUC.AppearanceCell.Options.UseTextOptions = true;
            this.colNGAY_KET_THUC.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNGAY_KET_THUC.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colNGAY_KET_THUC.AppearanceHeader.Options.UseFont = true;
            this.colNGAY_KET_THUC.AppearanceHeader.Options.UseTextOptions = true;
            this.colNGAY_KET_THUC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNGAY_KET_THUC.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colNGAY_KET_THUC.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colNGAY_KET_THUC.Caption = "Ngày kết thúc";
            this.colNGAY_KET_THUC.FieldName = "NGAY_KET_THUC";
            this.colNGAY_KET_THUC.Name = "colNGAY_KET_THUC";
            this.colNGAY_KET_THUC.OptionsColumn.AllowEdit = false;
            this.colNGAY_KET_THUC.Visible = true;
            this.colNGAY_KET_THUC.VisibleIndex = 5;
            this.colNGAY_KET_THUC.Width = 76;
            // 
            // colNGAY_KY_HOP_DONG
            // 
            this.colNGAY_KY_HOP_DONG.AppearanceCell.Options.UseTextOptions = true;
            this.colNGAY_KY_HOP_DONG.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNGAY_KY_HOP_DONG.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colNGAY_KY_HOP_DONG.AppearanceHeader.Options.UseFont = true;
            this.colNGAY_KY_HOP_DONG.AppearanceHeader.Options.UseTextOptions = true;
            this.colNGAY_KY_HOP_DONG.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNGAY_KY_HOP_DONG.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colNGAY_KY_HOP_DONG.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colNGAY_KY_HOP_DONG.Caption = "Ngày ký";
            this.colNGAY_KY_HOP_DONG.FieldName = "NGAY_KY_HOP_DONG";
            this.colNGAY_KY_HOP_DONG.Name = "colNGAY_KY_HOP_DONG";
            this.colNGAY_KY_HOP_DONG.OptionsColumn.AllowEdit = false;
            this.colNGAY_KY_HOP_DONG.Visible = true;
            this.colNGAY_KY_HOP_DONG.VisibleIndex = 6;
            // 
            // colMA_LCD
            // 
            this.colMA_LCD.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colMA_LCD.AppearanceHeader.Options.UseFont = true;
            this.colMA_LCD.AppearanceHeader.Options.UseTextOptions = true;
            this.colMA_LCD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMA_LCD.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colMA_LCD.Caption = "Mã LCD";
            this.colMA_LCD.FieldName = "MA_LCD";
            this.colMA_LCD.Name = "colMA_LCD";
            this.colMA_LCD.Visible = true;
            this.colMA_LCD.VisibleIndex = 7;
            this.colMA_LCD.Width = 46;
            // 
            // colMUC_LCD
            // 
            this.colMUC_LCD.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colMUC_LCD.AppearanceHeader.Options.UseFont = true;
            this.colMUC_LCD.AppearanceHeader.Options.UseTextOptions = true;
            this.colMUC_LCD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMUC_LCD.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colMUC_LCD.Caption = "Mức LCD";
            this.colMUC_LCD.FieldName = "MUC_LCD";
            this.colMUC_LCD.Name = "colMUC_LCD";
            this.colMUC_LCD.Visible = true;
            this.colMUC_LCD.VisibleIndex = 8;
            this.colMUC_LCD.Width = 52;
            // 
            // colTEN_CHUC_VU
            // 
            this.colTEN_CHUC_VU.AppearanceCell.Options.UseTextOptions = true;
            this.colTEN_CHUC_VU.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTEN_CHUC_VU.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colTEN_CHUC_VU.AppearanceHeader.Options.UseFont = true;
            this.colTEN_CHUC_VU.AppearanceHeader.Options.UseTextOptions = true;
            this.colTEN_CHUC_VU.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTEN_CHUC_VU.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTEN_CHUC_VU.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colTEN_CHUC_VU.Caption = "Chức vụ";
            this.colTEN_CHUC_VU.FieldName = "TEN_CHUC_VU";
            this.colTEN_CHUC_VU.Name = "colTEN_CHUC_VU";
            this.colTEN_CHUC_VU.OptionsColumn.AllowEdit = false;
            this.colTEN_CHUC_VU.Visible = true;
            this.colTEN_CHUC_VU.VisibleIndex = 11;
            this.colTEN_CHUC_VU.Width = 119;
            // 
            // colSO_TIEN_LCD_THUC_TE
            // 
            this.colSO_TIEN_LCD_THUC_TE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colSO_TIEN_LCD_THUC_TE.AppearanceHeader.ForeColor = System.Drawing.Color.Green;
            this.colSO_TIEN_LCD_THUC_TE.AppearanceHeader.Options.UseFont = true;
            this.colSO_TIEN_LCD_THUC_TE.AppearanceHeader.Options.UseForeColor = true;
            this.colSO_TIEN_LCD_THUC_TE.AppearanceHeader.Options.UseTextOptions = true;
            this.colSO_TIEN_LCD_THUC_TE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSO_TIEN_LCD_THUC_TE.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colSO_TIEN_LCD_THUC_TE.Caption = "LCĐ thực";
            this.colSO_TIEN_LCD_THUC_TE.DisplayFormat.FormatString = "n0";
            this.colSO_TIEN_LCD_THUC_TE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSO_TIEN_LCD_THUC_TE.FieldName = "SO_TIEN_LCD_THUC_TE";
            this.colSO_TIEN_LCD_THUC_TE.Name = "colSO_TIEN_LCD_THUC_TE";
            this.colSO_TIEN_LCD_THUC_TE.Visible = true;
            this.colSO_TIEN_LCD_THUC_TE.VisibleIndex = 10;
            this.colSO_TIEN_LCD_THUC_TE.Width = 85;
            // 
            // colTEN_DON_VI
            // 
            this.colTEN_DON_VI.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colTEN_DON_VI.AppearanceHeader.Options.UseFont = true;
            this.colTEN_DON_VI.AppearanceHeader.Options.UseTextOptions = true;
            this.colTEN_DON_VI.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTEN_DON_VI.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colTEN_DON_VI.Caption = "Đơn vị";
            this.colTEN_DON_VI.FieldName = "TEN_DON_VI";
            this.colTEN_DON_VI.Name = "colTEN_DON_VI";
            this.colTEN_DON_VI.Visible = true;
            this.colTEN_DON_VI.VisibleIndex = 12;
            // 
            // colSO_TIEN_MAC_DINH_LCD
            // 
            this.colSO_TIEN_MAC_DINH_LCD.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colSO_TIEN_MAC_DINH_LCD.AppearanceHeader.Options.UseFont = true;
            this.colSO_TIEN_MAC_DINH_LCD.AppearanceHeader.Options.UseTextOptions = true;
            this.colSO_TIEN_MAC_DINH_LCD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSO_TIEN_MAC_DINH_LCD.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colSO_TIEN_MAC_DINH_LCD.Caption = "LCĐ theo mã mức";
            this.colSO_TIEN_MAC_DINH_LCD.DisplayFormat.FormatString = "n0";
            this.colSO_TIEN_MAC_DINH_LCD.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSO_TIEN_MAC_DINH_LCD.FieldName = "SO_TIEN_MAC_DINH_LCD";
            this.colSO_TIEN_MAC_DINH_LCD.Name = "colSO_TIEN_MAC_DINH_LCD";
            this.colSO_TIEN_MAC_DINH_LCD.Visible = true;
            this.colSO_TIEN_MAC_DINH_LCD.VisibleIndex = 9;
            // 
            // colNGAY_LAP
            // 
            this.colNGAY_LAP.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colNGAY_LAP.AppearanceHeader.Options.UseFont = true;
            this.colNGAY_LAP.AppearanceHeader.Options.UseTextOptions = true;
            this.colNGAY_LAP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNGAY_LAP.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colNGAY_LAP.Caption = "Ngày lập vào phần mềm";
            this.colNGAY_LAP.FieldName = "NGAY_LAP";
            this.colNGAY_LAP.Name = "colNGAY_LAP";
            this.colNGAY_LAP.Visible = true;
            this.colNGAY_LAP.VisibleIndex = 14;
            // 
            // colLOAI_LAO_DONG
            // 
            this.colLOAI_LAO_DONG.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colLOAI_LAO_DONG.AppearanceHeader.Options.UseFont = true;
            this.colLOAI_LAO_DONG.AppearanceHeader.Options.UseTextOptions = true;
            this.colLOAI_LAO_DONG.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLOAI_LAO_DONG.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colLOAI_LAO_DONG.Caption = "Loại LĐ";
            this.colLOAI_LAO_DONG.FieldName = "LOAI_LAO_DONG";
            this.colLOAI_LAO_DONG.Name = "colLOAI_LAO_DONG";
            this.colLOAI_LAO_DONG.Visible = true;
            this.colLOAI_LAO_DONG.VisibleIndex = 13;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.m_cmd_refresh);
            this.panelControl1.Controls.Add(this.m_cmd_print);
            this.panelControl1.Controls.Add(this.m_cmd_xuat_excel);
            this.panelControl1.Controls.Add(this.m_cmd_delete);
            this.panelControl1.Controls.Add(this.m_cmd_update);
            this.panelControl1.Controls.Add(this.m_cmd_insert);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(2, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Padding = new System.Windows.Forms.Padding(2);
            this.panelControl1.Size = new System.Drawing.Size(1095, 40);
            this.panelControl1.TabIndex = 6;
            // 
            // m_cmd_refresh
            // 
            this.m_cmd_refresh.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.m_cmd_refresh.Appearance.Options.UseFont = true;
            this.m_cmd_refresh.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_refresh.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_refresh.Image")));
            this.m_cmd_refresh.Location = new System.Drawing.Point(981, 4);
            this.m_cmd_refresh.Name = "m_cmd_refresh";
            this.m_cmd_refresh.Size = new System.Drawing.Size(110, 32);
            this.m_cmd_refresh.TabIndex = 39;
            this.m_cmd_refresh.Text = "Làm mới";
            this.m_cmd_refresh.ToolTip = "Làm mới dữ liệu đơn vị và nhân viên thuộc đơn vị đó";
            // 
            // m_cmd_print
            // 
            this.m_cmd_print.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_print.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_print.Image")));
            this.m_cmd_print.ImageList = this.img_DVMD;
            this.m_cmd_print.Location = new System.Drawing.Point(368, 4);
            this.m_cmd_print.Name = "m_cmd_print";
            this.m_cmd_print.Size = new System.Drawing.Size(91, 32);
            this.m_cmd_print.TabIndex = 38;
            this.m_cmd_print.Text = "&In hợp đồng";
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
            // m_cmd_xuat_excel
            // 
            this.m_cmd_xuat_excel.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_xuat_excel.ImageIndex = 0;
            this.m_cmd_xuat_excel.ImageList = this.img_DVMD;
            this.m_cmd_xuat_excel.Location = new System.Drawing.Point(277, 4);
            this.m_cmd_xuat_excel.Name = "m_cmd_xuat_excel";
            this.m_cmd_xuat_excel.Size = new System.Drawing.Size(91, 32);
            this.m_cmd_xuat_excel.TabIndex = 37;
            this.m_cmd_xuat_excel.Text = "&Xuất Excel";
            this.m_cmd_xuat_excel.Visible = false;
            // 
            // m_cmd_delete
            // 
            this.m_cmd_delete.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_delete.ImageIndex = 8;
            this.m_cmd_delete.ImageList = this.img_DVMD;
            this.m_cmd_delete.Location = new System.Drawing.Point(186, 4);
            this.m_cmd_delete.Name = "m_cmd_delete";
            this.m_cmd_delete.Size = new System.Drawing.Size(91, 32);
            this.m_cmd_delete.TabIndex = 36;
            this.m_cmd_delete.Text = "&Xóa";
            // 
            // m_cmd_update
            // 
            this.m_cmd_update.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_update.ImageIndex = 9;
            this.m_cmd_update.ImageList = this.img_DVMD;
            this.m_cmd_update.Location = new System.Drawing.Point(95, 4);
            this.m_cmd_update.Name = "m_cmd_update";
            this.m_cmd_update.Size = new System.Drawing.Size(91, 32);
            this.m_cmd_update.TabIndex = 35;
            this.m_cmd_update.Text = "&Sửa";
            // 
            // m_cmd_insert
            // 
            this.m_cmd_insert.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_insert.ImageIndex = 7;
            this.m_cmd_insert.ImageList = this.img_DVMD;
            this.m_cmd_insert.Location = new System.Drawing.Point(4, 4);
            this.m_cmd_insert.Name = "m_cmd_insert";
            this.m_cmd_insert.Size = new System.Drawing.Size(91, 32);
            this.m_cmd_insert.TabIndex = 7;
            this.m_cmd_insert.Text = "&Thêm";
            // 
            // f329_lap_hop_dong_v4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1099, 559);
            this.Controls.Add(this.panelControl2);
            this.Name = "f329_lap_hop_dong_v4";
            this.Text = "F329 - Quản lý danh sách hợp đồng";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_grc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_DVMD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl m_grc;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv;
        private DevExpress.XtraGrid.Columns.GridColumn colMA_NV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO_TEN;
        private DevExpress.XtraGrid.Columns.GridColumn colMA_HOP_DONG;
        private DevExpress.XtraGrid.Columns.GridColumn colMA_LOAI_HOP_DONG;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAY_BAT_DAU;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAY_KET_THUC;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAY_KY_HOP_DONG;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN_CHUC_VU;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton m_cmd_insert;
        private DevExpress.XtraGrid.Columns.GridColumn colMA_LCD;
        private DevExpress.XtraGrid.Columns.GridColumn colMUC_LCD;
        private DevExpress.XtraGrid.Columns.GridColumn colSO_TIEN_LCD_THUC_TE;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN_DON_VI;
        private DevExpress.XtraGrid.Columns.GridColumn colSO_TIEN_MAC_DINH_LCD;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAY_LAP;
        private DevExpress.XtraGrid.Columns.GridColumn colLOAI_LAO_DONG;
        private DevExpress.Utils.ImageCollection img_DVMD;
        private DevExpress.XtraEditors.SimpleButton m_cmd_print;
        private DevExpress.XtraEditors.SimpleButton m_cmd_xuat_excel;
        private DevExpress.XtraEditors.SimpleButton m_cmd_delete;
        private DevExpress.XtraEditors.SimpleButton m_cmd_update;
        private DevExpress.XtraEditors.SimpleButton m_cmd_refresh;

    }
}