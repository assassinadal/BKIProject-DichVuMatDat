﻿namespace BKI_DichVuMatDat.NghiepVu
{
    partial class f303_gd_cham_cong_lam_them
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f303_gd_cham_cong_lam_them));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.m_txt_nam = new System.Windows.Forms.TextBox();
            this.m_txt_thang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.m_txt_chon_file = new DevExpress.XtraEditors.SimpleButton();
            this.m_grc = new DevExpress.XtraGrid.GridControl();
            this.m_grv = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.m_txt_luu = new DevExpress.XtraEditors.SimpleButton();
            this.dS_GD_CHAM_CONG_LAM_THEM1 = new BKI_DichVuMatDat.DS.DS_GD_CHAM_CONG_LAM_THEM();
            this.label3 = new System.Windows.Forms.Label();
            this.m_txt_tai_file_excel_mau = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS_GD_CHAM_CONG_LAM_THEM1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.m_txt_nam);
            this.groupControl1.Controls.Add(this.m_txt_thang);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(730, 76);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Bước 1: Chọn thời gian";
            // 
            // m_txt_nam
            // 
            this.m_txt_nam.Location = new System.Drawing.Point(283, 37);
            this.m_txt_nam.Name = "m_txt_nam";
            this.m_txt_nam.Size = new System.Drawing.Size(100, 20);
            this.m_txt_nam.TabIndex = 1;
            this.m_txt_nam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.m_txt_nam_KeyPress);
            // 
            // m_txt_thang
            // 
            this.m_txt_thang.Location = new System.Drawing.Point(57, 37);
            this.m_txt_thang.Name = "m_txt_thang";
            this.m_txt_thang.Size = new System.Drawing.Size(100, 20);
            this.m_txt_thang.TabIndex = 1;
            this.m_txt_thang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.m_txt_thang_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Năm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tháng";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.m_txt_tai_file_excel_mau);
            this.groupControl2.Controls.Add(this.m_txt_chon_file);
            this.groupControl2.Controls.Add(this.label3);
            this.groupControl2.Controls.Add(this.label4);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(0, 76);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(730, 85);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Bước 2: Chọn file để tải lên";
            // 
            // m_txt_chon_file
            // 
            this.m_txt_chon_file.Image = ((System.Drawing.Image)(resources.GetObject("m_txt_chon_file.Image")));
            this.m_txt_chon_file.Location = new System.Drawing.Point(12, 37);
            this.m_txt_chon_file.Name = "m_txt_chon_file";
            this.m_txt_chon_file.Size = new System.Drawing.Size(142, 33);
            this.m_txt_chon_file.TabIndex = 0;
            this.m_txt_chon_file.Text = "Chọn file";
            this.m_txt_chon_file.Click += new System.EventHandler(this.m_txt_chon_file_Click);
            // 
            // m_grc
            // 
            this.m_grc.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc.Location = new System.Drawing.Point(0, 161);
            this.m_grc.MainView = this.m_grv;
            this.m_grc.Name = "m_grc";
            this.m_grc.Size = new System.Drawing.Size(730, 220);
            this.m_grc.TabIndex = 2;
            this.m_grc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv});
            // 
            // m_grv
            // 
            this.m_grv.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.m_grv.GridControl = this.m_grc;
            this.m_grv.Name = "m_grv";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã nhân viên";
            this.gridColumn1.FieldName = "MA_NV";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Họ và tên";
            this.gridColumn2.FieldName = "HO_VA_TEN";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Số ngày làm thêm";
            this.gridColumn3.FieldName = "SO_NGAY_LAM_THEM";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 381);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(730, 54);
            this.panelControl1.TabIndex = 3;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.m_txt_luu);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl2.Location = new System.Drawing.Point(570, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(158, 50);
            this.panelControl2.TabIndex = 1;
            // 
            // m_txt_luu
            // 
            this.m_txt_luu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_txt_luu.Image = ((System.Drawing.Image)(resources.GetObject("m_txt_luu.Image")));
            this.m_txt_luu.Location = new System.Drawing.Point(2, 2);
            this.m_txt_luu.Name = "m_txt_luu";
            this.m_txt_luu.Size = new System.Drawing.Size(154, 46);
            this.m_txt_luu.TabIndex = 0;
            this.m_txt_luu.Text = "Bước 3: Lưu";
            this.m_txt_luu.Click += new System.EventHandler(this.m_txt_luu_Click);
            // 
            // dS_GD_CHAM_CONG_LAM_THEM1
            // 
            this.dS_GD_CHAM_CONG_LAM_THEM1.DataSetName = "DS_GD_CHAM_CONG_LAM_THEM";
            this.dS_GD_CHAM_CONG_LAM_THEM1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "(    Bạn có thể tải file excel mẫu tại đây";
            // 
            // m_txt_tai_file_excel_mau
            // 
            this.m_txt_tai_file_excel_mau.Image = ((System.Drawing.Image)(resources.GetObject("m_txt_tai_file_excel_mau.Image")));
            this.m_txt_tai_file_excel_mau.Location = new System.Drawing.Point(468, 37);
            this.m_txt_tai_file_excel_mau.Name = "m_txt_tai_file_excel_mau";
            this.m_txt_tai_file_excel_mau.Size = new System.Drawing.Size(142, 33);
            this.m_txt_tai_file_excel_mau.TabIndex = 0;
            this.m_txt_tai_file_excel_mau.Text = "Tải file excel mẫu";
            this.m_txt_tai_file_excel_mau.Click += new System.EventHandler(this.m_txt_tai_file_excel_mau_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(630, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = ")";
            // 
            // f303_gd_cham_cong_lam_them
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 435);
            this.Controls.Add(this.m_grc);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "f303_gd_cham_cong_lam_them";
            this.Text = "Bảng chấm công làm thêm import từ Excel";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dS_GD_CHAM_CONG_LAM_THEM1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TextBox m_txt_nam;
        private System.Windows.Forms.TextBox m_txt_thang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton m_txt_chon_file;
        private DevExpress.XtraGrid.GridControl m_grc;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton m_txt_luu;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton m_txt_tai_file_excel_mau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DS.DS_GD_CHAM_CONG_LAM_THEM dS_GD_CHAM_CONG_LAM_THEM1;

    }
}