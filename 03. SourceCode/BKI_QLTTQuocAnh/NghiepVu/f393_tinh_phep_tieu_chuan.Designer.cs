namespace BKI_DichVuMatDat.NghiepVu
{
    partial class f393_tinh_phep_tieu_chuan
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.m_pbl_nam_tinh_phep = new DevExpress.XtraEditors.PanelControl();
            this.m_cmd_tinh_ngay_phep = new DevExpress.XtraEditors.SimpleButton();
            this.m_txt_nam_tinh_phep = new DevExpress.XtraEditors.TextEdit();
            this.m_lbl_nam_tinh_phep = new DevExpress.XtraEditors.LabelControl();
            this.m_grc_phep_tieu_chuan = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.m_pbl_nam_tinh_phep)).BeginInit();
            this.m_pbl_nam_tinh_phep.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_txt_nam_tinh_phep.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_phep_tieu_chuan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // m_pbl_nam_tinh_phep
            // 
            this.m_pbl_nam_tinh_phep.Controls.Add(this.m_cmd_tinh_ngay_phep);
            this.m_pbl_nam_tinh_phep.Controls.Add(this.m_txt_nam_tinh_phep);
            this.m_pbl_nam_tinh_phep.Controls.Add(this.m_lbl_nam_tinh_phep);
            this.m_pbl_nam_tinh_phep.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_pbl_nam_tinh_phep.Location = new System.Drawing.Point(0, 0);
            this.m_pbl_nam_tinh_phep.Name = "m_pbl_nam_tinh_phep";
            this.m_pbl_nam_tinh_phep.Size = new System.Drawing.Size(643, 81);
            this.m_pbl_nam_tinh_phep.TabIndex = 1;
            // 
            // m_cmd_tinh_ngay_phep
            // 
            this.m_cmd_tinh_ngay_phep.Location = new System.Drawing.Point(243, 24);
            this.m_cmd_tinh_ngay_phep.Name = "m_cmd_tinh_ngay_phep";
            this.m_cmd_tinh_ngay_phep.Size = new System.Drawing.Size(72, 23);
            this.m_cmd_tinh_ngay_phep.TabIndex = 2;
            this.m_cmd_tinh_ngay_phep.Text = "Hiển thị";
            this.m_cmd_tinh_ngay_phep.Click += new System.EventHandler(this.m_cmd_tinh_ngay_phep_Click);
            // 
            // m_txt_nam_tinh_phep
            // 
            this.m_txt_nam_tinh_phep.Location = new System.Drawing.Point(105, 27);
            this.m_txt_nam_tinh_phep.Name = "m_txt_nam_tinh_phep";
            this.m_txt_nam_tinh_phep.Size = new System.Drawing.Size(100, 20);
            this.m_txt_nam_tinh_phep.TabIndex = 1;

            // 
            // m_lbl_nam_tinh_phep
            // 
            this.m_lbl_nam_tinh_phep.Appearance.Font = new System.Drawing.Font("Tahoma", 9.25F);
            this.m_lbl_nam_tinh_phep.Location = new System.Drawing.Point(24, 29);
            this.m_lbl_nam_tinh_phep.Name = "m_lbl_nam_tinh_phep";
            this.m_lbl_nam_tinh_phep.Size = new System.Drawing.Size(58, 16);
            this.m_lbl_nam_tinh_phep.TabIndex = 0;
            this.m_lbl_nam_tinh_phep.Text = "Nhập năm";
            // 
            // m_grc_phep_tieu_chuan
            // 
            this.m_grc_phep_tieu_chuan.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_phep_tieu_chuan.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Level1";
            this.m_grc_phep_tieu_chuan.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.m_grc_phep_tieu_chuan.Location = new System.Drawing.Point(0, 81);
            this.m_grc_phep_tieu_chuan.MainView = this.gridView1;
            this.m_grc_phep_tieu_chuan.Name = "m_grc_phep_tieu_chuan";
            this.m_grc_phep_tieu_chuan.Size = new System.Drawing.Size(643, 349);
            this.m_grc_phep_tieu_chuan.TabIndex = 4;
            this.m_grc_phep_tieu_chuan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
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
            this.gridColumn2.Caption = "MÃ NHÂN VIÊN";
            this.gridColumn2.FieldName = "MA_NV";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 92;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "TÊN NHÂN VIÊN";
            this.gridColumn3.FieldName = "HO_TEN";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 151;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "CHỨC VỤ";
            this.gridColumn4.FieldName = "CHUC_VU";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            this.gridColumn4.Width = 132;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "SỐ NGÀY PHÉP ĐÃ NGHỈ";
            this.gridColumn5.FieldName = "SO_NGAY_PHEP_DA_NGHI";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 136;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "SỐ NGÀY PHÉP";
            this.gridColumn6.FieldName = "SO_NGAY_PHEP";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 3;
            this.gridColumn6.Width = 114;
            // 
            // f393_tinh_phep_tieu_chuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 430);
            this.Controls.Add(this.m_grc_phep_tieu_chuan);
            this.Controls.Add(this.m_pbl_nam_tinh_phep);
            this.Name = "f393_tinh_phep_tieu_chuan";
            this.Text = "F393 - TÍNH NGÀY PHÉP TIÊU CHUẨN";
            ((System.ComponentModel.ISupportInitialize)(this.m_pbl_nam_tinh_phep)).EndInit();
            this.m_pbl_nam_tinh_phep.ResumeLayout(false);
            this.m_pbl_nam_tinh_phep.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_txt_nam_tinh_phep.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_phep_tieu_chuan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl m_pbl_nam_tinh_phep;
        private DevExpress.XtraEditors.TextEdit m_txt_nam_tinh_phep;
        private DevExpress.XtraEditors.LabelControl m_lbl_nam_tinh_phep;
        private DevExpress.XtraEditors.SimpleButton m_cmd_tinh_ngay_phep;
        private DevExpress.XtraGrid.GridControl m_grc_phep_tieu_chuan;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
    }
}