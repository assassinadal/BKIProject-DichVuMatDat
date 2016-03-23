namespace BKI_DichVuMatDat.BaoCao.ThuNhapKhac
{
    partial class f492_bao_cao_cac_he_so
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f492_bao_cao_cac_he_so));
            this.m_grc_main = new DevExpress.XtraGrid.GridControl();
            this.m_grv_main = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colHO_TEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN_DON_VI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN_CHUC_VU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMA_NV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHS_ATHK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHS_BSL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLE_TET_YN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.m_dat_tu_thang = new DevExpress.XtraEditors.DateEdit();
            this.m_dat_den_thang = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.imageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.m_cmd_view = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.m_cmd_trich_xuat_du_lieu = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_tu_thang.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_tu_thang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_den_thang.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_den_thang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_grc_main
            // 
            this.m_grc_main.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc_main.Location = new System.Drawing.Point(0, 56);
            this.m_grc_main.MainView = this.m_grv_main;
            this.m_grc_main.Name = "m_grc_main";
            this.m_grc_main.Size = new System.Drawing.Size(856, 470);
            this.m_grc_main.TabIndex = 0;
            this.m_grc_main.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv_main});
            // 
            // m_grv_main
            // 
            this.m_grv_main.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colHO_TEN,
            this.colTEN_DON_VI,
            this.colTEN_CHUC_VU,
            this.colMA_NV,
            this.colHS_ATHK,
            this.colHS_BSL,
            this.colLE_TET_YN});
            this.m_grv_main.GridControl = this.m_grc_main;
            this.m_grv_main.GroupCount = 1;
            this.m_grv_main.Name = "m_grv_main";
            this.m_grv_main.OptionsBehavior.AutoExpandAllGroups = true;
            this.m_grv_main.OptionsBehavior.ReadOnly = true;
            this.m_grv_main.OptionsView.ColumnAutoWidth = false;
            this.m_grv_main.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.m_grv_main.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTEN_DON_VI, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colHO_TEN
            // 
            this.colHO_TEN.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colHO_TEN.AppearanceHeader.Options.UseFont = true;
            this.colHO_TEN.AppearanceHeader.Options.UseTextOptions = true;
            this.colHO_TEN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHO_TEN.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colHO_TEN.Caption = "Họ tên";
            this.colHO_TEN.FieldName = "HO_TEN";
            this.colHO_TEN.FieldNameSortGroup = "HO_DEM";
            this.colHO_TEN.Name = "colHO_TEN";
            this.colHO_TEN.Visible = true;
            this.colHO_TEN.VisibleIndex = 1;
            this.colHO_TEN.Width = 203;
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
            this.colTEN_DON_VI.FieldNameSortGroup = "THU_TU_DON_VI";
            this.colTEN_DON_VI.Name = "colTEN_DON_VI";
            this.colTEN_DON_VI.Visible = true;
            this.colTEN_DON_VI.VisibleIndex = 1;
            // 
            // colTEN_CHUC_VU
            // 
            this.colTEN_CHUC_VU.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colTEN_CHUC_VU.AppearanceHeader.Options.UseFont = true;
            this.colTEN_CHUC_VU.AppearanceHeader.Options.UseTextOptions = true;
            this.colTEN_CHUC_VU.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTEN_CHUC_VU.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colTEN_CHUC_VU.Caption = "Chức vụ";
            this.colTEN_CHUC_VU.FieldName = "TEN_CHUC_VU";
            this.colTEN_CHUC_VU.FieldNameSortGroup = "THU_TU_CHUC_VU";
            this.colTEN_CHUC_VU.Name = "colTEN_CHUC_VU";
            this.colTEN_CHUC_VU.Visible = true;
            this.colTEN_CHUC_VU.VisibleIndex = 2;
            this.colTEN_CHUC_VU.Width = 316;
            // 
            // colMA_NV
            // 
            this.colMA_NV.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colMA_NV.AppearanceHeader.Options.UseFont = true;
            this.colMA_NV.AppearanceHeader.Options.UseTextOptions = true;
            this.colMA_NV.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMA_NV.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colMA_NV.Caption = "Mã NV";
            this.colMA_NV.FieldName = "MA_NV";
            this.colMA_NV.Name = "colMA_NV";
            this.colMA_NV.Visible = true;
            this.colMA_NV.VisibleIndex = 0;
            // 
            // colHS_ATHK
            // 
            this.colHS_ATHK.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colHS_ATHK.AppearanceHeader.Options.UseFont = true;
            this.colHS_ATHK.AppearanceHeader.Options.UseTextOptions = true;
            this.colHS_ATHK.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHS_ATHK.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colHS_ATHK.Caption = "HS ATHK";
            this.colHS_ATHK.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colHS_ATHK.FieldName = "HS_ATHK";
            this.colHS_ATHK.Name = "colHS_ATHK";
            this.colHS_ATHK.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colHS_ATHK.Visible = true;
            this.colHS_ATHK.VisibleIndex = 3;
            this.colHS_ATHK.Width = 82;
            // 
            // colHS_BSL
            // 
            this.colHS_BSL.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colHS_BSL.AppearanceHeader.Options.UseFont = true;
            this.colHS_BSL.AppearanceHeader.Options.UseTextOptions = true;
            this.colHS_BSL.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHS_BSL.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colHS_BSL.Caption = "HS BSL";
            this.colHS_BSL.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colHS_BSL.FieldName = "HS_BSL";
            this.colHS_BSL.Name = "colHS_BSL";
            this.colHS_BSL.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colHS_BSL.Visible = true;
            this.colHS_BSL.VisibleIndex = 4;
            this.colHS_BSL.Width = 81;
            // 
            // colLE_TET_YN
            // 
            this.colLE_TET_YN.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colLE_TET_YN.AppearanceHeader.Options.UseFont = true;
            this.colLE_TET_YN.AppearanceHeader.Options.UseTextOptions = true;
            this.colLE_TET_YN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLE_TET_YN.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colLE_TET_YN.Caption = "Lễ tết";
            this.colLE_TET_YN.FieldName = "LE_TET_YN";
            this.colLE_TET_YN.Name = "colLE_TET_YN";
            this.colLE_TET_YN.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.colLE_TET_YN.Visible = true;
            this.colLE_TET_YN.VisibleIndex = 5;
            this.colLE_TET_YN.Width = 82;
            // 
            // m_dat_tu_thang
            // 
            this.m_dat_tu_thang.EditValue = null;
            this.m_dat_tu_thang.Location = new System.Drawing.Point(56, 17);
            this.m_dat_tu_thang.Name = "m_dat_tu_thang";
            this.m_dat_tu_thang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.m_dat_tu_thang.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.m_dat_tu_thang.Properties.DisplayFormat.FormatString = "MM/yyyy";
            this.m_dat_tu_thang.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.m_dat_tu_thang.Properties.EditFormat.FormatString = "MM/yyyy";
            this.m_dat_tu_thang.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.m_dat_tu_thang.Properties.Mask.EditMask = "MM/yyyy";
            this.m_dat_tu_thang.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.m_dat_tu_thang.Size = new System.Drawing.Size(100, 20);
            this.m_dat_tu_thang.TabIndex = 1;
            // 
            // m_dat_den_thang
            // 
            this.m_dat_den_thang.EditValue = null;
            this.m_dat_den_thang.Location = new System.Drawing.Point(242, 17);
            this.m_dat_den_thang.Name = "m_dat_den_thang";
            this.m_dat_den_thang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.m_dat_den_thang.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.m_dat_den_thang.Properties.DisplayFormat.FormatString = "MM/yyyy";
            this.m_dat_den_thang.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.m_dat_den_thang.Properties.EditFormat.FormatString = "MM/yyyy";
            this.m_dat_den_thang.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.m_dat_den_thang.Properties.Mask.EditMask = "MM/yyyy";
            this.m_dat_den_thang.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.m_dat_den_thang.Size = new System.Drawing.Size(100, 20);
            this.m_dat_den_thang.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(185, 20);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(51, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Đến tháng";
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
            // 
            // m_cmd_view
            // 
            this.m_cmd_view.ImageIndex = 11;
            this.m_cmd_view.ImageList = this.imageCollection;
            this.m_cmd_view.Location = new System.Drawing.Point(348, 12);
            this.m_cmd_view.Name = "m_cmd_view";
            this.m_cmd_view.Size = new System.Drawing.Size(108, 30);
            this.m_cmd_view.TabIndex = 12;
            this.m_cmd_view.Text = "Xem dữ liệu";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(856, 56);
            this.panelControl1.TabIndex = 13;
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.m_cmd_trich_xuat_du_lieu);
            this.panelControl2.Controls.Add(this.m_dat_den_thang);
            this.panelControl2.Controls.Add(this.m_cmd_view);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Controls.Add(this.m_dat_tu_thang);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl2.Location = new System.Drawing.Point(2, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(603, 52);
            this.panelControl2.TabIndex = 13;
            // 
            // m_cmd_trich_xuat_du_lieu
            // 
            this.m_cmd_trich_xuat_du_lieu.ImageIndex = 1;
            this.m_cmd_trich_xuat_du_lieu.ImageList = this.imageCollection;
            this.m_cmd_trich_xuat_du_lieu.Location = new System.Drawing.Point(468, 12);
            this.m_cmd_trich_xuat_du_lieu.Name = "m_cmd_trich_xuat_du_lieu";
            this.m_cmd_trich_xuat_du_lieu.Size = new System.Drawing.Size(130, 30);
            this.m_cmd_trich_xuat_du_lieu.TabIndex = 12;
            this.m_cmd_trich_xuat_du_lieu.Text = "Trích xuất";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(6, 20);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(44, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Từ tháng";
            // 
            // f492_bao_cao_cac_he_so
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 526);
            this.Controls.Add(this.m_grc_main);
            this.Controls.Add(this.panelControl1);
            this.Name = "f492_bao_cao_cac_he_so";
            this.Text = "F492 - Báo cáo hệ số ATHK, BSL, Lễ tết";
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_tu_thang.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_tu_thang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_den_thang.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_den_thang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl m_grc_main;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv_main;
        private DevExpress.XtraEditors.DateEdit m_dat_tu_thang;
        private DevExpress.XtraEditors.DateEdit m_dat_den_thang;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.Utils.ImageCollection imageCollection;
        private DevExpress.XtraEditors.SimpleButton m_cmd_view;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colHO_TEN;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN_DON_VI;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN_CHUC_VU;
        private DevExpress.XtraGrid.Columns.GridColumn colMA_NV;
        private DevExpress.XtraGrid.Columns.GridColumn colHS_ATHK;
        private DevExpress.XtraGrid.Columns.GridColumn colHS_BSL;
        private DevExpress.XtraGrid.Columns.GridColumn colLE_TET_YN;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton m_cmd_trich_xuat_du_lieu;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}