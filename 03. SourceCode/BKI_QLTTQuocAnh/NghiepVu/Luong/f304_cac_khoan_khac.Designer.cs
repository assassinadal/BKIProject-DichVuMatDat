namespace BKI_DichVuMatDat
{
    partial class f304_cac_khoan_khac
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f304_cac_khoan_khac));
            this.dS_GD_CHAM_CONG_LAM_THEM1 = new BKI_DichVuMatDat.DS.DS_GD_CHAM_CONG_LAM_THEM();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.m_txt_luu = new DevExpress.XtraEditors.SimpleButton();
            this.imageCollection = new DevExpress.Utils.ImageCollection();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.colSO_TIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMA_NV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.m_txt_tai_file_excel_mau = new DevExpress.XtraEditors.SimpleButton();
            this.m_txt_chon_file = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.m_grv_main = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.m_grc_main = new DevExpress.XtraGrid.GridControl();
            this.label4 = new System.Windows.Forms.Label();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.m_dat_time = new DevExpress.XtraEditors.DateEdit();
            this.m_cmb_khoan_tien = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.dS_GD_CHAM_CONG_LAM_THEM1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_time.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_time.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dS_GD_CHAM_CONG_LAM_THEM1
            // 
            this.dS_GD_CHAM_CONG_LAM_THEM1.DataSetName = "DS_GD_CHAM_CONG_LAM_THEM";
            this.dS_GD_CHAM_CONG_LAM_THEM1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.m_txt_luu);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl2.Location = new System.Drawing.Point(745, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(158, 38);
            this.panelControl2.TabIndex = 1;
            // 
            // m_txt_luu
            // 
            this.m_txt_luu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_txt_luu.ImageIndex = 12;
            this.m_txt_luu.ImageList = this.imageCollection;
            this.m_txt_luu.Location = new System.Drawing.Point(2, 2);
            this.m_txt_luu.Name = "m_txt_luu";
            this.m_txt_luu.Size = new System.Drawing.Size(154, 34);
            this.m_txt_luu.TabIndex = 0;
            this.m_txt_luu.Text = "Lưu dữ liệu";
            this.m_txt_luu.Click += new System.EventHandler(this.m_txt_luu_Click);
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
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 420);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(905, 42);
            this.panelControl1.TabIndex = 7;
            // 
            // colSO_TIEN
            // 
            this.colSO_TIEN.Caption = "SO_TIEN";
            this.colSO_TIEN.DisplayFormat.FormatString = "n0";
            this.colSO_TIEN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSO_TIEN.FieldName = "SO_TIEN";
            this.colSO_TIEN.Name = "colSO_TIEN";
            this.colSO_TIEN.Visible = true;
            this.colSO_TIEN.VisibleIndex = 1;
            this.colSO_TIEN.Width = 768;
            // 
            // colMA_NV
            // 
            this.colMA_NV.Caption = "MA_NV";
            this.colMA_NV.FieldName = "MA_NV";
            this.colMA_NV.Name = "colMA_NV";
            this.colMA_NV.Visible = true;
            this.colMA_NV.VisibleIndex = 0;
            this.colMA_NV.Width = 119;
            // 
            // m_txt_tai_file_excel_mau
            // 
            this.m_txt_tai_file_excel_mau.ImageIndex = 1;
            this.m_txt_tai_file_excel_mau.ImageList = this.imageCollection;
            this.m_txt_tai_file_excel_mau.Location = new System.Drawing.Point(369, 6);
            this.m_txt_tai_file_excel_mau.Name = "m_txt_tai_file_excel_mau";
            this.m_txt_tai_file_excel_mau.Size = new System.Drawing.Size(142, 33);
            this.m_txt_tai_file_excel_mau.TabIndex = 0;
            this.m_txt_tai_file_excel_mau.Text = "Tải file excel mẫu";
            this.m_txt_tai_file_excel_mau.Click += new System.EventHandler(this.m_txt_tai_file_excel_mau_Click);
            // 
            // m_txt_chon_file
            // 
            this.m_txt_chon_file.ImageIndex = 0;
            this.m_txt_chon_file.ImageList = this.imageCollection;
            this.m_txt_chon_file.Location = new System.Drawing.Point(1, 6);
            this.m_txt_chon_file.Name = "m_txt_chon_file";
            this.m_txt_chon_file.Size = new System.Drawing.Size(142, 33);
            this.m_txt_chon_file.TabIndex = 0;
            this.m_txt_chon_file.Text = "Chọn file";
            this.m_txt_chon_file.Click += new System.EventHandler(this.m_txt_chon_file_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "(Bạn có thể tải file excel mẫu tại đây";
            // 
            // m_grv_main
            // 
            this.m_grv_main.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMA_NV,
            this.colSO_TIEN});
            this.m_grv_main.GridControl = this.m_grc_main;
            this.m_grv_main.Name = "m_grv_main";
            // 
            // m_grc_main
            // 
            this.m_grc_main.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc_main.Location = new System.Drawing.Point(0, 117);
            this.m_grc_main.MainView = this.m_grv_main;
            this.m_grc_main.Name = "m_grc_main";
            this.m_grc_main.Size = new System.Drawing.Size(905, 303);
            this.m_grc_main.TabIndex = 6;
            this.m_grc_main.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv_main});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(517, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = ")";
            // 
            // groupControl2
            // 
            this.groupControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.groupControl2.Controls.Add(this.m_txt_tai_file_excel_mau);
            this.groupControl2.Controls.Add(this.m_txt_chon_file);
            this.groupControl2.Controls.Add(this.label3);
            this.groupControl2.Controls.Add(this.label4);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(0, 71);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(905, 46);
            this.groupControl2.TabIndex = 5;
            this.groupControl2.Text = "Chọn file để tải lên";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(11, 20);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(30, 13);
            this.labelControl1.TabIndex = 27;
            this.labelControl1.Text = "Tháng";
            // 
            // m_dat_time
            // 
            this.m_dat_time.EditValue = null;
            this.m_dat_time.Location = new System.Drawing.Point(72, 12);
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
            this.m_dat_time.Properties.ReadOnly = true;
            this.m_dat_time.Size = new System.Drawing.Size(141, 26);
            this.m_dat_time.TabIndex = 26;
            // 
            // m_cmb_khoan_tien
            // 
            this.m_cmb_khoan_tien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_cmb_khoan_tien.Enabled = false;
            this.m_cmb_khoan_tien.FormattingEnabled = true;
            this.m_cmb_khoan_tien.Location = new System.Drawing.Point(72, 44);
            this.m_cmb_khoan_tien.Name = "m_cmb_khoan_tien";
            this.m_cmb_khoan_tien.Size = new System.Drawing.Size(310, 21);
            this.m_cmb_khoan_tien.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Khoản tiền";
            // 
            // groupControl1
            // 
            this.groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.m_dat_time);
            this.groupControl1.Controls.Add(this.m_cmb_khoan_tien);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(905, 71);
            this.groupControl1.TabIndex = 4;
            // 
            // f304_cac_khoan_khac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 462);
            this.Controls.Add(this.m_grc_main);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "f304_cac_khoan_khac";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F304 - Import Excel dữ liệu các khoản tiền khác";
            this.Load += new System.EventHandler(this.f304_cac_khoan_khac_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS_GD_CHAM_CONG_LAM_THEM1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_time.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_time.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DS.DS_GD_CHAM_CONG_LAM_THEM dS_GD_CHAM_CONG_LAM_THEM1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton m_txt_luu;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colSO_TIEN;
        private DevExpress.XtraGrid.Columns.GridColumn colMA_NV;
        private DevExpress.XtraEditors.SimpleButton m_txt_tai_file_excel_mau;
        private DevExpress.XtraEditors.SimpleButton m_txt_chon_file;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv_main;
        private DevExpress.XtraGrid.GridControl m_grc_main;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.ComboBox m_cmb_khoan_tien;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.DateEdit m_dat_time;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.Utils.ImageCollection imageCollection;
        private DevExpress.XtraEditors.GroupControl groupControl1;
    }
}