namespace BKI_DichVuMatDat.NghiepVu.HopDong
{
    partial class F390_quan_ly_thay_doi_lns_hop_dong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F390_quan_ly_thay_doi_lns_hop_dong));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.m_cmd_filter = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.m_dat_den_ngay = new DevExpress.XtraEditors.DateEdit();
            this.m_dat_tu_ngay = new DevExpress.XtraEditors.DateEdit();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.m_cmd_export_excel = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_delete = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_refresh = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_update = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_insert = new DevExpress.XtraEditors.SimpleButton();
            this.m_grc_lns = new DevExpress.XtraGrid.GridControl();
            this.m_grv_lns = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.m_grc_lcd = new DevExpress.XtraGrid.GridControl();
            this.m_grv_lcd = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_den_ngay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_den_ngay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_tu_ngay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_tu_ngay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_lns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_lns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_lcd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_lcd)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.m_cmd_filter);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.m_dat_den_ngay);
            this.panelControl1.Controls.Add(this.m_dat_tu_ngay);
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(889, 78);
            this.panelControl1.TabIndex = 0;
            // 
            // m_cmd_filter
            // 
            this.m_cmd_filter.Appearance.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Bold);
            this.m_cmd_filter.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.m_cmd_filter.Appearance.Options.UseFont = true;
            this.m_cmd_filter.Appearance.Options.UseForeColor = true;
            this.m_cmd_filter.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.m_cmd_filter.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_filter.Image")));
            this.m_cmd_filter.Location = new System.Drawing.Point(336, 8);
            this.m_cmd_filter.Name = "m_cmd_filter";
            this.m_cmd_filter.Size = new System.Drawing.Size(92, 26);
            this.m_cmd_filter.TabIndex = 7;
            this.m_cmd_filter.Text = "&Lọc";
            this.m_cmd_filter.ToolTip = "Xóa khỏi phần mềm công tác của nhân viên (Chỉ khuyên dùng khi nhập sai công tác, " +
    "cần xóa để nhập lại)";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(173, 13);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(47, 13);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Đến ngày";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 13);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(40, 13);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Từ ngày";
            // 
            // m_dat_den_ngay
            // 
            this.m_dat_den_ngay.EditValue = null;
            this.m_dat_den_ngay.Location = new System.Drawing.Point(230, 10);
            this.m_dat_den_ngay.Name = "m_dat_den_ngay";
            this.m_dat_den_ngay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.m_dat_den_ngay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.m_dat_den_ngay.Size = new System.Drawing.Size(100, 20);
            this.m_dat_den_ngay.TabIndex = 4;
            // 
            // m_dat_tu_ngay
            // 
            this.m_dat_tu_ngay.EditValue = null;
            this.m_dat_tu_ngay.Location = new System.Drawing.Point(59, 10);
            this.m_dat_tu_ngay.Name = "m_dat_tu_ngay";
            this.m_dat_tu_ngay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.m_dat_tu_ngay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.m_dat_tu_ngay.Size = new System.Drawing.Size(100, 20);
            this.m_dat_tu_ngay.TabIndex = 3;
            // 
            // panelControl3
            // 
            this.panelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl3.Controls.Add(this.m_cmd_export_excel);
            this.panelControl3.Controls.Add(this.m_cmd_delete);
            this.panelControl3.Controls.Add(this.m_cmd_refresh);
            this.panelControl3.Controls.Add(this.m_cmd_update);
            this.panelControl3.Controls.Add(this.m_cmd_insert);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl3.Location = new System.Drawing.Point(0, 45);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(889, 33);
            this.panelControl3.TabIndex = 2;
            // 
            // m_cmd_export_excel
            // 
            this.m_cmd_export_excel.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.m_cmd_export_excel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.m_cmd_export_excel.Appearance.Options.UseFont = true;
            this.m_cmd_export_excel.Appearance.Options.UseForeColor = true;
            this.m_cmd_export_excel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.m_cmd_export_excel.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_export_excel.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_export_excel.Image")));
            this.m_cmd_export_excel.Location = new System.Drawing.Point(669, 0);
            this.m_cmd_export_excel.Name = "m_cmd_export_excel";
            this.m_cmd_export_excel.Size = new System.Drawing.Size(110, 33);
            this.m_cmd_export_excel.TabIndex = 8;
            this.m_cmd_export_excel.Text = "Trích xuất";
            // 
            // m_cmd_delete
            // 
            this.m_cmd_delete.Appearance.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Bold);
            this.m_cmd_delete.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.m_cmd_delete.Appearance.Options.UseFont = true;
            this.m_cmd_delete.Appearance.Options.UseForeColor = true;
            this.m_cmd_delete.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.m_cmd_delete.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_delete.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_delete.Image")));
            this.m_cmd_delete.Location = new System.Drawing.Point(220, 0);
            this.m_cmd_delete.Name = "m_cmd_delete";
            this.m_cmd_delete.Size = new System.Drawing.Size(110, 33);
            this.m_cmd_delete.TabIndex = 5;
            this.m_cmd_delete.Text = "&Xóa";
            // 
            // m_cmd_refresh
            // 
            this.m_cmd_refresh.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.m_cmd_refresh.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.m_cmd_refresh.Appearance.Options.UseFont = true;
            this.m_cmd_refresh.Appearance.Options.UseForeColor = true;
            this.m_cmd_refresh.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.m_cmd_refresh.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_refresh.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_refresh.Image")));
            this.m_cmd_refresh.Location = new System.Drawing.Point(779, 0);
            this.m_cmd_refresh.Name = "m_cmd_refresh";
            this.m_cmd_refresh.Size = new System.Drawing.Size(110, 33);
            this.m_cmd_refresh.TabIndex = 7;
            this.m_cmd_refresh.Text = "Làm mới";
            this.m_cmd_refresh.ToolTip = "Làm mới dữ liệu đơn vị và nhân viên thuộc đơn vị đó";
            // 
            // m_cmd_update
            // 
            this.m_cmd_update.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.m_cmd_update.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.m_cmd_update.Appearance.ForeColor = System.Drawing.Color.White;
            this.m_cmd_update.Appearance.Options.UseBackColor = true;
            this.m_cmd_update.Appearance.Options.UseFont = true;
            this.m_cmd_update.Appearance.Options.UseForeColor = true;
            this.m_cmd_update.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.m_cmd_update.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_update.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_update.Image")));
            this.m_cmd_update.Location = new System.Drawing.Point(110, 0);
            this.m_cmd_update.Name = "m_cmd_update";
            this.m_cmd_update.Size = new System.Drawing.Size(110, 33);
            this.m_cmd_update.TabIndex = 3;
            this.m_cmd_update.Text = "&Sửa";
            // 
            // m_cmd_insert
            // 
            this.m_cmd_insert.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.m_cmd_insert.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.m_cmd_insert.Appearance.ForeColor = System.Drawing.Color.White;
            this.m_cmd_insert.Appearance.Options.UseBackColor = true;
            this.m_cmd_insert.Appearance.Options.UseFont = true;
            this.m_cmd_insert.Appearance.Options.UseForeColor = true;
            this.m_cmd_insert.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.m_cmd_insert.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_insert.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_insert.Image")));
            this.m_cmd_insert.Location = new System.Drawing.Point(0, 0);
            this.m_cmd_insert.Name = "m_cmd_insert";
            this.m_cmd_insert.Size = new System.Drawing.Size(110, 33);
            this.m_cmd_insert.TabIndex = 0;
            this.m_cmd_insert.Text = "&Thêm";
            // 
            // m_grc_lns
            // 
            this.m_grc_lns.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_lns.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_grc_lns.Location = new System.Drawing.Point(0, 78);
            this.m_grc_lns.MainView = this.m_grv_lns;
            this.m_grc_lns.Name = "m_grc_lns";
            this.m_grc_lns.Size = new System.Drawing.Size(417, 419);
            this.m_grc_lns.TabIndex = 1;
            this.m_grc_lns.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv_lns});
            // 
            // m_grv_lns
            // 
            this.m_grv_lns.GridControl = this.m_grc_lns;
            this.m_grv_lns.Name = "m_grv_lns";
            // 
            // m_grc_lcd
            // 
            this.m_grc_lcd.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_lcd.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_grc_lcd.Location = new System.Drawing.Point(439, 78);
            this.m_grc_lcd.MainView = this.m_grv_lcd;
            this.m_grc_lcd.Name = "m_grc_lcd";
            this.m_grc_lcd.Size = new System.Drawing.Size(450, 419);
            this.m_grc_lcd.TabIndex = 2;
            this.m_grc_lcd.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv_lcd});
            // 
            // m_grv_lcd
            // 
            this.m_grv_lcd.GridControl = this.m_grc_lcd;
            this.m_grv_lcd.Name = "m_grv_lcd";
            // 
            // F390_quan_ly_thay_doi_lns_hop_dong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 497);
            this.Controls.Add(this.m_grc_lcd);
            this.Controls.Add(this.m_grc_lns);
            this.Controls.Add(this.panelControl1);
            this.Name = "F390_quan_ly_thay_doi_lns_hop_dong";
            this.Text = "F390 - Quản lý danh sách hợp đồng có thay đổi hệ số LNS";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_den_ngay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_den_ngay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_tu_ngay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_tu_ngay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_lns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_lns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_lcd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_lcd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl m_grc_lns;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv_lns;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.SimpleButton m_cmd_delete;
        private DevExpress.XtraEditors.SimpleButton m_cmd_refresh;
        private DevExpress.XtraEditors.SimpleButton m_cmd_update;
        private DevExpress.XtraEditors.SimpleButton m_cmd_insert;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit m_dat_den_ngay;
        private DevExpress.XtraEditors.DateEdit m_dat_tu_ngay;
        private DevExpress.XtraEditors.SimpleButton m_cmd_export_excel;
        private DevExpress.XtraEditors.SimpleButton m_cmd_filter;
        private DevExpress.XtraGrid.GridControl m_grc_lcd;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv_lcd;
    }
}