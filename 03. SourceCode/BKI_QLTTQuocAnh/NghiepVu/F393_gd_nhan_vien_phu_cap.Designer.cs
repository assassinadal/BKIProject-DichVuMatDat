﻿namespace BKI_DichVuMatDat.NghiepVu
{
    partial class F393_gd_nhan_vien_phu_cap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F393_gd_nhan_vien_phu_cap));
            this.m_grc = new DevExpress.XtraGrid.GridControl();
            this.m_grv = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.m_cmd_them = new DevExpress.XtraEditors.SimpleButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.m_cmd_xoa = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.m_lbl_header = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_grc
            // 
            this.m_grc.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc.Location = new System.Drawing.Point(0, 0);
            this.m_grc.MainView = this.m_grv;
            this.m_grc.Name = "m_grc";
            this.m_grc.Size = new System.Drawing.Size(708, 308);
            this.m_grc.TabIndex = 0;
            this.m_grc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv});
            // 
            // m_grv
            // 
            this.m_grv.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridColumn1,
            this.gridColumn4,
            this.gridColumn3,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7});
            this.m_grv.GridControl = this.m_grc;
            this.m_grv.Name = "m_grv";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Mã nhân viên";
            this.gridColumn2.FieldName = "MA_NV";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Họ tên";
            this.gridColumn1.FieldName = "HO_TEN";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Chức vụ tương ứng";
            this.gridColumn4.FieldName = "CHUC_VU_TUONG_UNG";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Hệ số phụ cấp trách nhiệm";
            this.gridColumn3.FieldName = "HS_PHU_CAP";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Quyết định";
            this.gridColumn5.FieldName = "NOI_DUNG";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Ngày ký";
            this.gridColumn6.FieldName = "NGAY_KY";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Người ký";
            this.gridColumn7.FieldName = "NGUOI_KY";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 366);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(708, 52);
            this.panel1.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.m_cmd_them);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(368, 0);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(5);
            this.panel6.Size = new System.Drawing.Size(170, 52);
            this.panel6.TabIndex = 3;
            // 
            // m_cmd_them
            // 
            this.m_cmd_them.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_cmd_them.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_them.Image")));
            this.m_cmd_them.Location = new System.Drawing.Point(5, 5);
            this.m_cmd_them.Name = "m_cmd_them";
            this.m_cmd_them.Size = new System.Drawing.Size(160, 42);
            this.m_cmd_them.TabIndex = 0;
            this.m_cmd_them.Text = "Thêm";
            this.m_cmd_them.Click += new System.EventHandler(this.m_cmd_them_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.m_cmd_xoa);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(538, 0);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(5);
            this.panel4.Size = new System.Drawing.Size(170, 52);
            this.panel4.TabIndex = 1;
            // 
            // m_cmd_xoa
            // 
            this.m_cmd_xoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_cmd_xoa.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_xoa.Image")));
            this.m_cmd_xoa.Location = new System.Drawing.Point(5, 5);
            this.m_cmd_xoa.Name = "m_cmd_xoa";
            this.m_cmd_xoa.Size = new System.Drawing.Size(160, 42);
            this.m_cmd_xoa.TabIndex = 0;
            this.m_cmd_xoa.Text = "Xóa";
            this.m_cmd_xoa.Click += new System.EventHandler(this.m_cmd_xoa_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.m_grc);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(708, 308);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.m_lbl_header);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(708, 58);
            this.panel3.TabIndex = 3;
            // 
            // m_lbl_header
            // 
            this.m_lbl_header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.m_lbl_header.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_header.Location = new System.Drawing.Point(0, 0);
            this.m_lbl_header.Name = "m_lbl_header";
            this.m_lbl_header.Size = new System.Drawing.Size(708, 58);
            this.m_lbl_header.TabIndex = 2;
            this.m_lbl_header.Text = "QUẢN LÝ PHỤ CẤP TRÁCH NHIỆM";
            this.m_lbl_header.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // F393_gd_nhan_vien_phu_cap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 418);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "F393_gd_nhan_vien_phu_cap";
            this.Text = "F393  Phụ cấp trách nhiệm";
            this.Load += new System.EventHandler(this.F393_gd_nhan_vien_phu_cap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.m_grc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl m_grc;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private System.Windows.Forms.Panel panel6;
        private DevExpress.XtraEditors.SimpleButton m_cmd_them;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.SimpleButton m_cmd_xoa;
        private System.Windows.Forms.Label m_lbl_header;

    }
}