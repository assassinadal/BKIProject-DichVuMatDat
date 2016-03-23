namespace BKI_DichVuMatDat.NghiepVu.Luong
{
    partial class f303_cac_khoan_tien_khac
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f303_cac_khoan_tien_khac));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.m_dat_time = new DevExpress.XtraEditors.DateEdit();
            this.m_cmb_khoan_tien = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.imageCollection = new DevExpress.Utils.ImageCollection();
            this.m_cmd_view = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.m_grc_main = new DevExpress.XtraGrid.GridControl();
            this.m_grv_main = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMA_NV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSO_TIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.m_lbl_thang = new DevExpress.XtraEditors.LabelControl();
            this.colHO_TEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN_DON_VI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN_CHUC_VU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.m_cmd_import = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_time.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_time.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_main)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(8, 13);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(30, 13);
            this.labelControl1.TabIndex = 27;
            this.labelControl1.Text = "Tháng";
            // 
            // m_dat_time
            // 
            this.m_dat_time.EditValue = null;
            this.m_dat_time.Location = new System.Drawing.Point(69, 5);
            this.m_dat_time.Name = "m_dat_time";
            this.m_dat_time.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.m_dat_time.Properties.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.m_dat_time.Properties.Appearance.Options.UseFont = true;
            this.m_dat_time.Properties.Appearance.Options.UseForeColor = true;
            this.m_dat_time.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.m_dat_time.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.m_dat_time.Properties.DisplayFormat.FormatString = "MM/yyyy";
            this.m_dat_time.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.m_dat_time.Properties.EditFormat.FormatString = "MM/yyyy";
            this.m_dat_time.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.m_dat_time.Properties.Mask.EditMask = "MM/yyyy";
            this.m_dat_time.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.m_dat_time.Size = new System.Drawing.Size(141, 26);
            this.m_dat_time.TabIndex = 26;
            // 
            // m_cmb_khoan_tien
            // 
            this.m_cmb_khoan_tien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_cmb_khoan_tien.FormattingEnabled = true;
            this.m_cmb_khoan_tien.Location = new System.Drawing.Point(69, 37);
            this.m_cmb_khoan_tien.Name = "m_cmb_khoan_tien";
            this.m_cmb_khoan_tien.Size = new System.Drawing.Size(310, 21);
            this.m_cmb_khoan_tien.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Khoản tiền";
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
            this.m_cmd_view.Location = new System.Drawing.Point(69, 64);
            this.m_cmd_view.Name = "m_cmd_view";
            this.m_cmd_view.Size = new System.Drawing.Size(117, 32);
            this.m_cmd_view.TabIndex = 28;
            this.m_cmd_view.Text = "Xem dữ liệu";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.m_lbl_thang);
            this.panelControl1.Controls.Add(this.m_dat_time);
            this.panelControl1.Controls.Add(this.m_cmd_import);
            this.panelControl1.Controls.Add(this.m_cmd_view);
            this.panelControl1.Controls.Add(this.label5);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.m_cmb_khoan_tien);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(730, 121);
            this.panelControl1.TabIndex = 29;
            // 
            // m_grc_main
            // 
            this.m_grc_main.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc_main.Location = new System.Drawing.Point(0, 121);
            this.m_grc_main.MainView = this.m_grv_main;
            this.m_grc_main.Name = "m_grc_main";
            this.m_grc_main.Size = new System.Drawing.Size(730, 316);
            this.m_grc_main.TabIndex = 30;
            this.m_grc_main.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv_main});
            // 
            // m_grv_main
            // 
            this.m_grv_main.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMA_NV,
            this.colSO_TIEN,
            this.colHO_TEN,
            this.colTEN_DON_VI,
            this.colTEN_CHUC_VU});
            this.m_grv_main.GridControl = this.m_grc_main;
            this.m_grv_main.GroupCount = 1;
            this.m_grv_main.Name = "m_grv_main";
            this.m_grv_main.OptionsBehavior.AutoExpandAllGroups = true;
            this.m_grv_main.OptionsBehavior.ReadOnly = true;
            this.m_grv_main.OptionsView.ShowFooter = true;
            this.m_grv_main.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTEN_DON_VI, DevExpress.Data.ColumnSortOrder.Ascending)});
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
            this.colMA_NV.Width = 81;
            // 
            // colSO_TIEN
            // 
            this.colSO_TIEN.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colSO_TIEN.AppearanceHeader.Options.UseFont = true;
            this.colSO_TIEN.AppearanceHeader.Options.UseTextOptions = true;
            this.colSO_TIEN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSO_TIEN.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colSO_TIEN.Caption = "Số tiền";
            this.colSO_TIEN.DisplayFormat.FormatString = "n0";
            this.colSO_TIEN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSO_TIEN.FieldName = "SO_TIEN";
            this.colSO_TIEN.Name = "colSO_TIEN";
            this.colSO_TIEN.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SO_TIEN", "{0:n0}")});
            this.colSO_TIEN.Visible = true;
            this.colSO_TIEN.VisibleIndex = 3;
            this.colSO_TIEN.Width = 194;
            // 
            // m_lbl_thang
            // 
            this.m_lbl_thang.Location = new System.Drawing.Point(12, 103);
            this.m_lbl_thang.Name = "m_lbl_thang";
            this.m_lbl_thang.Size = new System.Drawing.Size(0, 13);
            this.m_lbl_thang.TabIndex = 29;
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
            this.colHO_TEN.Name = "colHO_TEN";
            this.colHO_TEN.Visible = true;
            this.colHO_TEN.VisibleIndex = 1;
            this.colHO_TEN.Width = 171;
            // 
            // colTEN_DON_VI
            // 
            this.colTEN_DON_VI.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colTEN_DON_VI.AppearanceHeader.Options.UseFont = true;
            this.colTEN_DON_VI.AppearanceHeader.Options.UseTextOptions = true;
            this.colTEN_DON_VI.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTEN_DON_VI.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colTEN_DON_VI.Caption = "Tên đơn vị";
            this.colTEN_DON_VI.FieldName = "TEN_DON_VI";
            this.colTEN_DON_VI.FieldNameSortGroup = "THU_TU_DON_VI";
            this.colTEN_DON_VI.Name = "colTEN_DON_VI";
            this.colTEN_DON_VI.Visible = true;
            this.colTEN_DON_VI.VisibleIndex = 3;
            // 
            // colTEN_CHUC_VU
            // 
            this.colTEN_CHUC_VU.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colTEN_CHUC_VU.AppearanceHeader.Options.UseFont = true;
            this.colTEN_CHUC_VU.AppearanceHeader.Options.UseTextOptions = true;
            this.colTEN_CHUC_VU.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTEN_CHUC_VU.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colTEN_CHUC_VU.Caption = "Tên chức vụ";
            this.colTEN_CHUC_VU.FieldName = "TEN_CHUC_VU";
            this.colTEN_CHUC_VU.FieldNameSortGroup = "THU_THU_CHUC_VU";
            this.colTEN_CHUC_VU.Name = "colTEN_CHUC_VU";
            this.colTEN_CHUC_VU.Visible = true;
            this.colTEN_CHUC_VU.VisibleIndex = 2;
            this.colTEN_CHUC_VU.Width = 266;
            // 
            // m_cmd_import
            // 
            this.m_cmd_import.ImageIndex = 0;
            this.m_cmd_import.ImageList = this.imageCollection;
            this.m_cmd_import.Location = new System.Drawing.Point(192, 64);
            this.m_cmd_import.Name = "m_cmd_import";
            this.m_cmd_import.Size = new System.Drawing.Size(131, 32);
            this.m_cmd_import.TabIndex = 28;
            this.m_cmd_import.Text = "Import Excel dữ liệu";
            // 
            // f303_cac_khoan_tien_khac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 437);
            this.Controls.Add(this.m_grc_main);
            this.Controls.Add(this.panelControl1);
            this.Name = "f303_cac_khoan_tien_khac";
            this.Text = "F303 - Dữ liệu Các khoản tiền khác";
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_time.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_time.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_main)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit m_dat_time;
        private System.Windows.Forms.ComboBox m_cmb_khoan_tien;
        private System.Windows.Forms.Label label5;
        private DevExpress.Utils.ImageCollection imageCollection;
        private DevExpress.XtraEditors.SimpleButton m_cmd_view;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl m_grc_main;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv_main;
        private DevExpress.XtraGrid.Columns.GridColumn colMA_NV;
        private DevExpress.XtraGrid.Columns.GridColumn colSO_TIEN;
        private DevExpress.XtraEditors.LabelControl m_lbl_thang;
        private DevExpress.XtraGrid.Columns.GridColumn colHO_TEN;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN_DON_VI;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN_CHUC_VU;
        private DevExpress.XtraEditors.SimpleButton m_cmd_import;

    }
}