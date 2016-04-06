namespace BKI_DichVuMatDat.NghiepVu
{
    partial class f394_tinh_phep_tieu_chuan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f394_tinh_phep_tieu_chuan));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.m_pbl_nam_tinh_phep = new DevExpress.XtraEditors.PanelControl();
            this.m_dat_nam = new DevExpress.XtraEditors.DateEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.m_cmd_search = new DevExpress.XtraEditors.SimpleButton();
            this.m_grc_phep_tieu_chuan = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.m_pbl_nam_tinh_phep)).BeginInit();
            this.m_pbl_nam_tinh_phep.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_nam.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_nam.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_phep_tieu_chuan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // m_pbl_nam_tinh_phep
            // 
            this.m_pbl_nam_tinh_phep.Controls.Add(this.m_dat_nam);
            this.m_pbl_nam_tinh_phep.Controls.Add(this.label3);
            this.m_pbl_nam_tinh_phep.Controls.Add(this.m_cmd_search);
            this.m_pbl_nam_tinh_phep.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_pbl_nam_tinh_phep.Location = new System.Drawing.Point(0, 0);
            this.m_pbl_nam_tinh_phep.Name = "m_pbl_nam_tinh_phep";
            this.m_pbl_nam_tinh_phep.Size = new System.Drawing.Size(643, 75);
            this.m_pbl_nam_tinh_phep.TabIndex = 1;
            // 
            // m_dat_nam
            // 
            this.m_dat_nam.EditValue = null;
            this.m_dat_nam.Location = new System.Drawing.Point(117, 22);
            this.m_dat_nam.Name = "m_dat_nam";
            this.m_dat_nam.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.m_dat_nam.Properties.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.m_dat_nam.Properties.Appearance.Options.UseFont = true;
            this.m_dat_nam.Properties.Appearance.Options.UseForeColor = true;
            this.m_dat_nam.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.m_dat_nam.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.m_dat_nam.Properties.DisplayFormat.FormatString = "yyyy";
            this.m_dat_nam.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.m_dat_nam.Properties.EditFormat.FormatString = "yyyy";
            this.m_dat_nam.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.m_dat_nam.Properties.Mask.EditMask = "yyyy";
            this.m_dat_nam.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.m_dat_nam.Size = new System.Drawing.Size(141, 26);
            this.m_dat_nam.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Chọn năm (*)";
            // 
            // m_cmd_search
            // 
            this.m_cmd_search.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_search.Image")));
            this.m_cmd_search.Location = new System.Drawing.Point(281, 15);
            this.m_cmd_search.Name = "m_cmd_search";
            this.m_cmd_search.Size = new System.Drawing.Size(143, 40);
            this.m_cmd_search.TabIndex = 12;
            this.m_cmd_search.Text = "Lọc dữ liệu";
            // 
            // m_grc_phep_tieu_chuan
            // 
            this.m_grc_phep_tieu_chuan.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_phep_tieu_chuan.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Level1";
            this.m_grc_phep_tieu_chuan.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.m_grc_phep_tieu_chuan.Location = new System.Drawing.Point(0, 75);
            this.m_grc_phep_tieu_chuan.MainView = this.gridView1;
            this.m_grc_phep_tieu_chuan.Name = "m_grc_phep_tieu_chuan";
            this.m_grc_phep_tieu_chuan.Size = new System.Drawing.Size(643, 355);
            this.m_grc_phep_tieu_chuan.TabIndex = 4;
            this.m_grc_phep_tieu_chuan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8});
            this.gridView1.GridControl = this.m_grc_phep_tieu_chuan;
            this.gridView1.Name = "gridView1";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ID_NHAN_VIEN";
            this.gridColumn1.FieldName = "ID";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.Caption = "Mã nhân viên";
            this.gridColumn2.FieldName = "MA_NV";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 74;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Họ tên";
            this.gridColumn3.FieldName = "HO_TEN";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 92;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Chức vụ";
            this.gridColumn4.FieldName = "CHUC_VU";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 101;
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn5.Caption = "Số phép đã nghỉ";
            this.gridColumn5.FieldName = "SO_PHEP_DA_NGHI";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 6;
            this.gridColumn5.Width = 93;
            // 
            // gridColumn6
            // 
            this.gridColumn6.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn6.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn6.Caption = "Số phép tiêu chuẩn";
            this.gridColumn6.FieldName = "SO_PHEP_TIEU_CHUAN";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            this.gridColumn6.Width = 73;
            // 
            // gridColumn7
            // 
            this.gridColumn7.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn7.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn7.Caption = "Ngày tiếp nhận";
            this.gridColumn7.FieldName = "NGAY_CHINH_THUC_TIEP_NHAN";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 4;
            this.gridColumn7.Width = 92;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Đơn vị";
            this.gridColumn8.FieldName = "TEN_DON_VI";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 2;
            this.gridColumn8.Width = 100;
            // 
            // f394_tinh_phep_tieu_chuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 430);
            this.Controls.Add(this.m_grc_phep_tieu_chuan);
            this.Controls.Add(this.m_pbl_nam_tinh_phep);
            this.Name = "f394_tinh_phep_tieu_chuan";
            this.Text = "F394 - Tính ngày phép tiêu chuẩn";
            ((System.ComponentModel.ISupportInitialize)(this.m_pbl_nam_tinh_phep)).EndInit();
            this.m_pbl_nam_tinh_phep.ResumeLayout(false);
            this.m_pbl_nam_tinh_phep.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_nam.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_nam.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_phep_tieu_chuan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl m_pbl_nam_tinh_phep;
        private DevExpress.XtraGrid.GridControl m_grc_phep_tieu_chuan;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.SimpleButton m_cmd_search;
        private DevExpress.XtraEditors.DateEdit m_dat_nam;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
    }
}