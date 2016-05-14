namespace BKI_DichVuMatDat.BaoCao
{
    partial class frm419_bao_cao_thay_doi_cong_tac
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm419_bao_cao_thay_doi_cong_tac));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.m_cmd_export = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_search = new DevExpress.XtraEditors.SimpleButton();
            this.m_dat_den_ngay = new DevExpress.XtraEditors.DateEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.m_dat_tu_ngay = new DevExpress.XtraEditors.DateEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.m_grc = new DevExpress.XtraGrid.GridControl();
            this.m_grv = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID_NHAN_VIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO_TEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAY_BAT_DAU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAY_KET_THUC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAY_LAP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAY_SUA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLY_DO_CHINH_SUA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN_DON_VI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN_CHUC_VU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHE_SO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMUC_LNS = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_den_ngay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_den_ngay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_tu_ngay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_tu_ngay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.m_cmd_export);
            this.panelControl1.Controls.Add(this.m_cmd_search);
            this.panelControl1.Controls.Add(this.m_dat_den_ngay);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.m_dat_tu_ngay);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1024, 87);
            this.panelControl1.TabIndex = 0;
            // 
            // m_cmd_export
            // 
            this.m_cmd_export.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_export.Image")));
            this.m_cmd_export.Location = new System.Drawing.Point(441, 19);
            this.m_cmd_export.Name = "m_cmd_export";
            this.m_cmd_export.Size = new System.Drawing.Size(123, 40);
            this.m_cmd_export.TabIndex = 34;
            this.m_cmd_export.Text = "&Trích xuất";
            // 
            // m_cmd_search
            // 
            this.m_cmd_search.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_search.Image")));
            this.m_cmd_search.Location = new System.Drawing.Point(302, 19);
            this.m_cmd_search.Name = "m_cmd_search";
            this.m_cmd_search.Size = new System.Drawing.Size(123, 40);
            this.m_cmd_search.TabIndex = 33;
            this.m_cmd_search.Text = "Lọc dữ liệu";
            // 
            // m_dat_den_ngay
            // 
            this.m_dat_den_ngay.EditValue = null;
            this.m_dat_den_ngay.Location = new System.Drawing.Point(122, 51);
            this.m_dat_den_ngay.Name = "m_dat_den_ngay";
            this.m_dat_den_ngay.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_dat_den_ngay.Properties.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.m_dat_den_ngay.Properties.Appearance.Options.UseFont = true;
            this.m_dat_den_ngay.Properties.Appearance.Options.UseForeColor = true;
            this.m_dat_den_ngay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.m_dat_den_ngay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.m_dat_den_ngay.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.m_dat_den_ngay.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.m_dat_den_ngay.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.m_dat_den_ngay.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.m_dat_den_ngay.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.m_dat_den_ngay.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.m_dat_den_ngay.Size = new System.Drawing.Size(136, 22);
            this.m_dat_den_ngay.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 14);
            this.label1.TabIndex = 31;
            this.label1.Text = "Đến tháng";
            // 
            // m_dat_tu_ngay
            // 
            this.m_dat_tu_ngay.EditValue = null;
            this.m_dat_tu_ngay.Location = new System.Drawing.Point(122, 13);
            this.m_dat_tu_ngay.Name = "m_dat_tu_ngay";
            this.m_dat_tu_ngay.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_dat_tu_ngay.Properties.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.m_dat_tu_ngay.Properties.Appearance.Options.UseFont = true;
            this.m_dat_tu_ngay.Properties.Appearance.Options.UseForeColor = true;
            this.m_dat_tu_ngay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.m_dat_tu_ngay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.m_dat_tu_ngay.Properties.DisplayFormat.FormatString = "MM/yyyy";
            this.m_dat_tu_ngay.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.m_dat_tu_ngay.Properties.EditFormat.FormatString = "MM/yyyy";
            this.m_dat_tu_ngay.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.m_dat_tu_ngay.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.m_dat_tu_ngay.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.m_dat_tu_ngay.Size = new System.Drawing.Size(136, 22);
            this.m_dat_tu_ngay.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 14);
            this.label3.TabIndex = 29;
            this.label3.Text = "Từ tháng";
            // 
            // m_grc
            // 
            this.m_grc.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc.Location = new System.Drawing.Point(0, 87);
            this.m_grc.MainView = this.m_grv;
            this.m_grc.Name = "m_grc";
            this.m_grc.Size = new System.Drawing.Size(1024, 517);
            this.m_grc.TabIndex = 1;
            this.m_grc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv});
            // 
            // m_grv
            // 
            this.m_grv.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID_NHAN_VIEN,
            this.colHO_TEN,
            this.colNGAY_BAT_DAU,
            this.colNGAY_KET_THUC,
            this.colNGAY_LAP,
            this.colNGAY_SUA,
            this.colLY_DO_CHINH_SUA,
            this.STT,
            this.colTEN_DON_VI,
            this.colTEN_CHUC_VU});
            this.m_grv.GridControl = this.m_grc;
            this.m_grv.Name = "m_grv";
            this.m_grv.OptionsBehavior.ReadOnly = true;
            this.m_grv.OptionsView.ColumnAutoWidth = false;
            this.m_grv.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            // 
            // colID_NHAN_VIEN
            // 
            this.colID_NHAN_VIEN.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colID_NHAN_VIEN.AppearanceHeader.Options.UseFont = true;
            this.colID_NHAN_VIEN.AppearanceHeader.Options.UseTextOptions = true;
            this.colID_NHAN_VIEN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colID_NHAN_VIEN.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colID_NHAN_VIEN.Caption = "colID_NHAN_VIEN";
            this.colID_NHAN_VIEN.FieldName = "ID_NHAN_VIEN";
            this.colID_NHAN_VIEN.Name = "colID_NHAN_VIEN";
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
            this.colHO_TEN.Width = 113;
            // 
            // colNGAY_BAT_DAU
            // 
            this.colNGAY_BAT_DAU.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colNGAY_BAT_DAU.AppearanceHeader.Options.UseFont = true;
            this.colNGAY_BAT_DAU.AppearanceHeader.Options.UseTextOptions = true;
            this.colNGAY_BAT_DAU.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNGAY_BAT_DAU.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colNGAY_BAT_DAU.Caption = "Ngày bắt đầu";
            this.colNGAY_BAT_DAU.FieldName = "NGAY_BAT_DAU";
            this.colNGAY_BAT_DAU.Name = "colNGAY_BAT_DAU";
            this.colNGAY_BAT_DAU.Visible = true;
            this.colNGAY_BAT_DAU.VisibleIndex = 4;
            this.colNGAY_BAT_DAU.Width = 113;
            // 
            // colNGAY_KET_THUC
            // 
            this.colNGAY_KET_THUC.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colNGAY_KET_THUC.AppearanceHeader.Options.UseFont = true;
            this.colNGAY_KET_THUC.AppearanceHeader.Options.UseTextOptions = true;
            this.colNGAY_KET_THUC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNGAY_KET_THUC.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colNGAY_KET_THUC.Caption = "Ngày kết thúc";
            this.colNGAY_KET_THUC.FieldName = "NGAY_KET_THUC";
            this.colNGAY_KET_THUC.Name = "colNGAY_KET_THUC";
            this.colNGAY_KET_THUC.Visible = true;
            this.colNGAY_KET_THUC.VisibleIndex = 5;
            this.colNGAY_KET_THUC.Width = 103;
            // 
            // colNGAY_LAP
            // 
            this.colNGAY_LAP.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colNGAY_LAP.AppearanceHeader.Options.UseFont = true;
            this.colNGAY_LAP.AppearanceHeader.Options.UseTextOptions = true;
            this.colNGAY_LAP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNGAY_LAP.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colNGAY_LAP.Caption = "Ngày lập";
            this.colNGAY_LAP.FieldName = "NGAY_LAP";
            this.colNGAY_LAP.Name = "colNGAY_LAP";
            this.colNGAY_LAP.Visible = true;
            this.colNGAY_LAP.VisibleIndex = 6;
            this.colNGAY_LAP.Width = 108;
            // 
            // colNGAY_SUA
            // 
            this.colNGAY_SUA.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colNGAY_SUA.AppearanceHeader.Options.UseFont = true;
            this.colNGAY_SUA.AppearanceHeader.Options.UseTextOptions = true;
            this.colNGAY_SUA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNGAY_SUA.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colNGAY_SUA.Caption = "Ngày sửa ";
            this.colNGAY_SUA.FieldName = "NGAY_SUA";
            this.colNGAY_SUA.Name = "colNGAY_SUA";
            this.colNGAY_SUA.Visible = true;
            this.colNGAY_SUA.VisibleIndex = 7;
            this.colNGAY_SUA.Width = 103;
            // 
            // colLY_DO_CHINH_SUA
            // 
            this.colLY_DO_CHINH_SUA.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colLY_DO_CHINH_SUA.AppearanceHeader.Options.UseFont = true;
            this.colLY_DO_CHINH_SUA.AppearanceHeader.Options.UseTextOptions = true;
            this.colLY_DO_CHINH_SUA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLY_DO_CHINH_SUA.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colLY_DO_CHINH_SUA.Caption = "Lý do sửa";
            this.colLY_DO_CHINH_SUA.FieldName = "LY_DO_CHINH_SUA";
            this.colLY_DO_CHINH_SUA.Name = "colLY_DO_CHINH_SUA";
            this.colLY_DO_CHINH_SUA.Visible = true;
            this.colLY_DO_CHINH_SUA.VisibleIndex = 8;
            // 
            // STT
            // 
            this.STT.Caption = "STT";
            this.STT.FieldName = "STT";
            this.STT.Name = "STT";
            this.STT.Visible = true;
            this.STT.VisibleIndex = 0;
            this.STT.Width = 45;
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
            this.colTEN_DON_VI.VisibleIndex = 2;
            this.colTEN_DON_VI.Width = 168;
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
            this.colTEN_CHUC_VU.Name = "colTEN_CHUC_VU";
            this.colTEN_CHUC_VU.Visible = true;
            this.colTEN_CHUC_VU.VisibleIndex = 3;
            this.colTEN_CHUC_VU.Width = 196;
            // 
            // colHE_SO
            // 
            this.colHE_SO.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colHE_SO.AppearanceHeader.Options.UseFont = true;
            this.colHE_SO.AppearanceHeader.Options.UseTextOptions = true;
            this.colHE_SO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHE_SO.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colHE_SO.Caption = "Hệ số";
            this.colHE_SO.FieldName = "HE_SO";
            this.colHE_SO.Name = "colHE_SO";
            this.colHE_SO.Visible = true;
            this.colHE_SO.VisibleIndex = 2;
            // 
            // colMUC_LNS
            // 
            this.colMUC_LNS.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colMUC_LNS.AppearanceHeader.Options.UseFont = true;
            this.colMUC_LNS.AppearanceHeader.Options.UseTextOptions = true;
            this.colMUC_LNS.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMUC_LNS.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colMUC_LNS.Caption = "Mức LNS";
            this.colMUC_LNS.FieldName = "MUC_LNS";
            this.colMUC_LNS.Name = "colMUC_LNS";
            this.colMUC_LNS.Visible = true;
            this.colMUC_LNS.VisibleIndex = 2;
            this.colMUC_LNS.Width = 87;
            // 
            // frm419_bao_cao_thay_doi_cong_tac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 604);
            this.Controls.Add(this.m_grc);
            this.Controls.Add(this.panelControl1);
            this.Name = "frm419_bao_cao_thay_doi_cong_tac";
            this.Text = "F419 - Báo cáo thay đổi công tác";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_den_ngay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_den_ngay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_tu_ngay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_tu_ngay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.DateEdit m_dat_den_ngay;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.DateEdit m_dat_tu_ngay;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton m_cmd_search;
        private DevExpress.XtraEditors.SimpleButton m_cmd_export;
        private DevExpress.XtraGrid.GridControl m_grc;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv;
        private DevExpress.XtraGrid.Columns.GridColumn colID_NHAN_VIEN;
        private DevExpress.XtraGrid.Columns.GridColumn colHO_TEN;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAY_BAT_DAU;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAY_KET_THUC;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAY_LAP;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAY_SUA;
        private DevExpress.XtraGrid.Columns.GridColumn colLY_DO_CHINH_SUA;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
        private DevExpress.XtraGrid.Columns.GridColumn colHE_SO;
        private DevExpress.XtraGrid.Columns.GridColumn colMUC_LNS;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN_DON_VI;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN_CHUC_VU;


    }
}