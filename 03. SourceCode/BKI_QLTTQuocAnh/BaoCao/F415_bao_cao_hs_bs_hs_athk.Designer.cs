namespace BKI_DichVuMatDat.BaoCao
{
    partial class F415_bao_cao_hs_bs_hs_athk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F415_bao_cao_hs_bs_hs_athk));
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_cmd_import = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_search = new DevExpress.XtraEditors.SimpleButton();
            this.m_txt_chon_nam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.m_txt_chon_thang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.m_lbl_header = new System.Windows.Forms.Label();
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.m_cmd_import_excel = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_tinh_lai = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_save = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_xuat_excel = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.m_grc_hs_bs_hs_athk = new DevExpress.XtraGrid.GridControl();
            this.m_grv_hs_bs_hs_athk = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ID_NHAN_VIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MA_NV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HO_TEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.THANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NAM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HS_BO_SUNG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HS_ATHK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            this.m_pnl_out_place_dm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_hs_bs_hs_athk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_hs_bs_hs_athk)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_cmd_import);
            this.panel1.Controls.Add(this.m_cmd_search);
            this.panel1.Controls.Add(this.m_txt_chon_nam);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.m_txt_chon_thang);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(985, 101);
            this.panel1.TabIndex = 11;
            // 
            // m_cmd_import
            // 
            this.m_cmd_import.Image = global::BKI_DichVuMatDat.Properties.Resources.table;
            this.m_cmd_import.Location = new System.Drawing.Point(4, 63);
            this.m_cmd_import.Name = "m_cmd_import";
            this.m_cmd_import.Size = new System.Drawing.Size(116, 35);
            this.m_cmd_import.TabIndex = 5;
            this.m_cmd_import.Text = "&Import Excel";
            this.m_cmd_import.Click += new System.EventHandler(this.m_cmd_import_Click);
            // 
            // m_cmd_search
            // 
            this.m_cmd_search.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_search.Image")));
            this.m_cmd_search.Location = new System.Drawing.Point(456, 3);
            this.m_cmd_search.Name = "m_cmd_search";
            this.m_cmd_search.Size = new System.Drawing.Size(116, 35);
            this.m_cmd_search.TabIndex = 7;
            this.m_cmd_search.Text = "&Lọc";
            // 
            // m_txt_chon_nam
            // 
            this.m_txt_chon_nam.Location = new System.Drawing.Point(322, 10);
            this.m_txt_chon_nam.Name = "m_txt_chon_nam";
            this.m_txt_chon_nam.Size = new System.Drawing.Size(111, 20);
            this.m_txt_chon_nam.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chọn năm (*)";
            // 
            // m_txt_chon_thang
            // 
            this.m_txt_chon_thang.Location = new System.Drawing.Point(93, 10);
            this.m_txt_chon_thang.Name = "m_txt_chon_thang";
            this.m_txt_chon_thang.Size = new System.Drawing.Size(111, 20);
            this.m_txt_chon_thang.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn tháng";
            // 
            // m_lbl_header
            // 
            this.m_lbl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.m_lbl_header.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_header.Location = new System.Drawing.Point(0, 0);
            this.m_lbl_header.Name = "m_lbl_header";
            this.m_lbl_header.Size = new System.Drawing.Size(985, 52);
            this.m_lbl_header.TabIndex = 10;
            this.m_lbl_header.Text = "BÁO CÁO HỆ SỐ BỔ SUNG & HỆ SỐ AN TOÀN HÀNG KHÔNG";
            this.m_lbl_header.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // m_pnl_out_place_dm
            // 
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_import_excel);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_tinh_lai);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_save);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_xuat_excel);
            this.m_pnl_out_place_dm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 497);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(985, 43);
            this.m_pnl_out_place_dm.TabIndex = 13;
            // 
            // m_cmd_import_excel
            // 
            this.m_cmd_import_excel.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_import_excel.Image = global::BKI_DichVuMatDat.Properties.Resources.table;
            this.m_cmd_import_excel.Location = new System.Drawing.Point(517, 4);
            this.m_cmd_import_excel.Name = "m_cmd_import_excel";
            this.m_cmd_import_excel.Size = new System.Drawing.Size(116, 35);
            this.m_cmd_import_excel.TabIndex = 8;
            this.m_cmd_import_excel.Text = "&Import Excel";
            this.m_cmd_import_excel.Click += new System.EventHandler(this.m_cmd_import_excel_Click);
            // 
            // m_cmd_tinh_lai
            // 
            this.m_cmd_tinh_lai.Dock = System.Windows.Forms.DockStyle.Right;            
            this.m_cmd_tinh_lai.Location = new System.Drawing.Point(633, 4);
            this.m_cmd_tinh_lai.Name = "m_cmd_tinh_lai";
            this.m_cmd_tinh_lai.Size = new System.Drawing.Size(116, 35);
            this.m_cmd_tinh_lai.TabIndex = 7;
            this.m_cmd_tinh_lai.Text = "&Tính lại hệ số";
            // 
            // m_cmd_save
            // 
            this.m_cmd_save.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_save.Image = global::BKI_DichVuMatDat.Properties.Resources.Save;
            this.m_cmd_save.Location = new System.Drawing.Point(749, 4);
            this.m_cmd_save.Name = "m_cmd_save";
            this.m_cmd_save.Size = new System.Drawing.Size(116, 35);
            this.m_cmd_save.TabIndex = 4;
            this.m_cmd_save.Text = "&Lưu lại";
            this.m_cmd_save.Visible = false;
            // 
            // m_cmd_xuat_excel
            // 
            this.m_cmd_xuat_excel.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_xuat_excel.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_xuat_excel.Image")));
            this.m_cmd_xuat_excel.Location = new System.Drawing.Point(865, 4);
            this.m_cmd_xuat_excel.Name = "m_cmd_xuat_excel";
            this.m_cmd_xuat_excel.Size = new System.Drawing.Size(116, 35);
            this.m_cmd_xuat_excel.TabIndex = 3;
            this.m_cmd_xuat_excel.Text = "&Xuất Excel";
            this.m_cmd_xuat_excel.Click += new System.EventHandler(this.m_cmd_xuat_excel_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 153);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(985, 344);
            this.panel2.TabIndex = 14;
            // 
            // m_grc_hs_bs_hs_athk
            // 
            this.m_grc_hs_bs_hs_athk.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_hs_bs_hs_athk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc_hs_bs_hs_athk.Location = new System.Drawing.Point(0, 153);
            this.m_grc_hs_bs_hs_athk.MainView = this.m_grv_hs_bs_hs_athk;
            this.m_grc_hs_bs_hs_athk.Name = "m_grc_hs_bs_hs_athk";
            this.m_grc_hs_bs_hs_athk.Size = new System.Drawing.Size(985, 344);
            this.m_grc_hs_bs_hs_athk.TabIndex = 15;
            this.m_grc_hs_bs_hs_athk.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv_hs_bs_hs_athk});
            this.m_grc_hs_bs_hs_athk.Visible = false;
            // 
            // m_grv_hs_bs_hs_athk
            // 
            this.m_grv_hs_bs_hs_athk.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.ID_NHAN_VIEN,
            this.STT,
            this.MA_NV,
            this.HO_TEN,
            this.THANG,
            this.NAM,
            this.HS_BO_SUNG,
            this.HS_ATHK});
            this.m_grv_hs_bs_hs_athk.GridControl = this.m_grc_hs_bs_hs_athk;
            this.m_grv_hs_bs_hs_athk.Name = "m_grv_hs_bs_hs_athk";
            this.m_grv_hs_bs_hs_athk.OptionsFind.AllowFindPanel = false;
            this.m_grv_hs_bs_hs_athk.OptionsFind.AlwaysVisible = true;
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            // 
            // ID_NHAN_VIEN
            // 
            this.ID_NHAN_VIEN.Caption = "ID_NHAN_VIEN";
            this.ID_NHAN_VIEN.FieldName = "ID_NHAN_VIEN";
            this.ID_NHAN_VIEN.Name = "ID_NHAN_VIEN";
            this.ID_NHAN_VIEN.OptionsColumn.AllowEdit = false;
            // 
            // STT
            // 
            this.STT.AppearanceCell.Options.UseTextOptions = true;
            this.STT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.STT.AppearanceHeader.Options.UseTextOptions = true;
            this.STT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.STT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.STT.Caption = "STT";
            this.STT.FieldName = "STT";
            this.STT.Name = "STT";
            this.STT.OptionsColumn.AllowEdit = false;
            this.STT.Visible = true;
            this.STT.VisibleIndex = 0;
            this.STT.Width = 38;
            // 
            // MA_NV
            // 
            this.MA_NV.AppearanceHeader.Options.UseTextOptions = true;
            this.MA_NV.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.MA_NV.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.MA_NV.Caption = "MA_NV";
            this.MA_NV.FieldName = "MA_NV";
            this.MA_NV.Name = "MA_NV";
            this.MA_NV.OptionsColumn.AllowEdit = false;
            this.MA_NV.Visible = true;
            this.MA_NV.VisibleIndex = 1;
            this.MA_NV.Width = 50;
            // 
            // HO_TEN
            // 
            this.HO_TEN.AppearanceHeader.Options.UseTextOptions = true;
            this.HO_TEN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.HO_TEN.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.HO_TEN.Caption = "HO_TEN";
            this.HO_TEN.FieldName = "HO_TEN";
            this.HO_TEN.Name = "HO_TEN";
            this.HO_TEN.OptionsColumn.AllowEdit = false;
            this.HO_TEN.Visible = true;
            this.HO_TEN.VisibleIndex = 4;
            this.HO_TEN.Width = 200;
            // 
            // THANG
            // 
            this.THANG.AppearanceHeader.Options.UseTextOptions = true;
            this.THANG.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.THANG.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.THANG.Caption = "THANG";
            this.THANG.FieldName = "THANG";
            this.THANG.Name = "THANG";
            this.THANG.OptionsColumn.AllowEdit = false;
            // 
            // NAM
            // 
            this.NAM.AppearanceHeader.Options.UseTextOptions = true;
            this.NAM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NAM.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.NAM.Caption = "NAM";
            this.NAM.FieldName = "NAM";
            this.NAM.Name = "NAM";
            this.NAM.OptionsColumn.AllowEdit = false;
            // 
            // HS_BO_SUNG
            // 
            this.HS_BO_SUNG.AppearanceHeader.Options.UseTextOptions = true;
            this.HS_BO_SUNG.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.HS_BO_SUNG.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.HS_BO_SUNG.Caption = "HS_BO_SUNG";
            this.HS_BO_SUNG.FieldName = "HS_BO_SUNG";
            this.HS_BO_SUNG.Name = "HS_BO_SUNG";
            this.HS_BO_SUNG.Visible = true;
            this.HS_BO_SUNG.VisibleIndex = 2;
            // 
            // HS_ATHK
            // 
            this.HS_ATHK.AppearanceHeader.Options.UseTextOptions = true;
            this.HS_ATHK.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.HS_ATHK.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.HS_ATHK.Caption = "HS_ATHK";
            this.HS_ATHK.FieldName = "HS_ATHK";
            this.HS_ATHK.Name = "HS_ATHK";
            this.HS_ATHK.Visible = true;
            this.HS_ATHK.VisibleIndex = 3;
            // 
            // F415_bao_cao_hs_bs_hs_athk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 540);
            this.Controls.Add(this.m_grc_hs_bs_hs_athk);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.m_lbl_header);
            this.Name = "F415_bao_cao_hs_bs_hs_athk";
            this.Text = "F415 - Báo cáo hệ số bổ sung, hệ số an toàn hàng không";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.m_pnl_out_place_dm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_hs_bs_hs_athk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_hs_bs_hs_athk)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox m_txt_chon_nam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox m_txt_chon_thang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label m_lbl_header;
        internal System.Windows.Forms.Panel m_pnl_out_place_dm;
        private DevExpress.XtraEditors.SimpleButton m_cmd_import;
        private DevExpress.XtraEditors.SimpleButton m_cmd_save;
        private DevExpress.XtraEditors.SimpleButton m_cmd_xuat_excel;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl m_grc_hs_bs_hs_athk;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv_hs_bs_hs_athk;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn ID_NHAN_VIEN;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
        private DevExpress.XtraGrid.Columns.GridColumn MA_NV;
        private DevExpress.XtraGrid.Columns.GridColumn HO_TEN;
        private DevExpress.XtraGrid.Columns.GridColumn THANG;
        private DevExpress.XtraGrid.Columns.GridColumn NAM;
        private DevExpress.XtraGrid.Columns.GridColumn HS_BO_SUNG;
        private DevExpress.XtraGrid.Columns.GridColumn HS_ATHK;
        private DevExpress.XtraEditors.SimpleButton m_cmd_search;
        private DevExpress.XtraEditors.SimpleButton m_cmd_tinh_lai;
        private DevExpress.XtraEditors.SimpleButton m_cmd_import_excel;
    }
}