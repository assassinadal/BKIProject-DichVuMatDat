namespace BKI_DichVuMatDat.BaoCao
{
    partial class f481_bao_cao_thu_lao_hdqt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f481_bao_cao_thu_lao_hdqt));
            this.m_lbl_header = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_cmd_search = new DevExpress.XtraEditors.SimpleButton();
            this.m_txt_chon_nam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.m_txt_chon_thang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.m_grc_bc_thu_lao = new DevExpress.XtraGrid.GridControl();
            this.m_grv_hs_bs_hs_athk = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MA_NV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HO_TEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.THANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NAM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ID_NHAN_VIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SO_TIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SO_TIEN_GIAM_TRU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SO_TAI_KHOAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.THUC_LINH_CUOI_CUNG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CHUC_VU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_bc_thu_lao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_hs_bs_hs_athk)).BeginInit();
            this.SuspendLayout();
            // 
            // m_lbl_header
            // 
            this.m_lbl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.m_lbl_header.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_header.Location = new System.Drawing.Point(0, 0);
            this.m_lbl_header.Name = "m_lbl_header";
            this.m_lbl_header.Size = new System.Drawing.Size(953, 52);
            this.m_lbl_header.TabIndex = 11;
            this.m_lbl_header.Text = "BÁO CÁO THÙ LAO CỦA HỘI ĐỒNG QUẢN TRỊ";
            this.m_lbl_header.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_cmd_search);
            this.panel1.Controls.Add(this.m_txt_chon_nam);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.m_txt_chon_thang);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(953, 46);
            this.panel1.TabIndex = 12;
            // 
            // m_cmd_search
            // 
            this.m_cmd_search.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_search.Image")));
            this.m_cmd_search.Location = new System.Drawing.Point(483, 5);
            this.m_cmd_search.Name = "m_cmd_search";
            this.m_cmd_search.Size = new System.Drawing.Size(116, 35);
            this.m_cmd_search.TabIndex = 7;
            this.m_cmd_search.Text = "&Lọc";
            this.m_cmd_search.Click += new System.EventHandler(this.m_cmd_search_Click);
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
            // m_grc_bc_thu_lao
            // 
            this.m_grc_bc_thu_lao.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_bc_thu_lao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc_bc_thu_lao.Location = new System.Drawing.Point(0, 98);
            this.m_grc_bc_thu_lao.MainView = this.m_grv_hs_bs_hs_athk;
            this.m_grc_bc_thu_lao.Name = "m_grc_bc_thu_lao";
            this.m_grc_bc_thu_lao.Size = new System.Drawing.Size(953, 380);
            this.m_grc_bc_thu_lao.TabIndex = 16;
            this.m_grc_bc_thu_lao.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv_hs_bs_hs_athk});
            // 
            // m_grv_hs_bs_hs_athk
            // 
            this.m_grv_hs_bs_hs_athk.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.MA_NV,
            this.HO_TEN,
            this.THANG,
            this.NAM,
            this.ID_NHAN_VIEN,
            this.SO_TIEN,
            this.SO_TIEN_GIAM_TRU,
            this.SO_TAI_KHOAN,
            this.THUC_LINH_CUOI_CUNG,
            this.CHUC_VU,
            this.STT});
            this.m_grv_hs_bs_hs_athk.GridControl = this.m_grc_bc_thu_lao;
            this.m_grv_hs_bs_hs_athk.Name = "m_grv_hs_bs_hs_athk";
            this.m_grv_hs_bs_hs_athk.OptionsFind.AllowFindPanel = false;
            this.m_grv_hs_bs_hs_athk.OptionsFind.AlwaysVisible = true;
            this.m_grv_hs_bs_hs_athk.OptionsView.ShowFooter = true;
            // 
            // ID
            // 
            this.ID.AppearanceCell.Options.UseTextOptions = true;
            this.ID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            // 
            // MA_NV
            // 
            this.MA_NV.AppearanceHeader.Options.UseTextOptions = true;
            this.MA_NV.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.MA_NV.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.MA_NV.Caption = "Mã NV";
            this.MA_NV.FieldName = "MA_NV";
            this.MA_NV.Name = "MA_NV";
            this.MA_NV.OptionsColumn.AllowEdit = false;
            this.MA_NV.Width = 50;
            // 
            // HO_TEN
            // 
            this.HO_TEN.AppearanceCell.Options.UseTextOptions = true;
            this.HO_TEN.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.HO_TEN.AppearanceHeader.Options.UseTextOptions = true;
            this.HO_TEN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.HO_TEN.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.HO_TEN.Caption = "Họ tên";
            this.HO_TEN.FieldName = "HO_TEN";
            this.HO_TEN.Name = "HO_TEN";
            this.HO_TEN.OptionsColumn.AllowEdit = false;
            this.HO_TEN.Visible = true;
            this.HO_TEN.VisibleIndex = 1;
            this.HO_TEN.Width = 143;
            // 
            // THANG
            // 
            this.THANG.AppearanceCell.Options.UseTextOptions = true;
            this.THANG.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.THANG.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.THANG.AppearanceHeader.Options.UseTextOptions = true;
            this.THANG.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.THANG.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.THANG.Caption = "Tháng";
            this.THANG.FieldName = "THANG";
            this.THANG.Name = "THANG";
            this.THANG.OptionsColumn.AllowEdit = false;
            this.THANG.Visible = true;
            this.THANG.VisibleIndex = 2;
            this.THANG.Width = 70;
            // 
            // NAM
            // 
            this.NAM.AppearanceCell.Options.UseTextOptions = true;
            this.NAM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NAM.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.NAM.AppearanceHeader.Options.UseTextOptions = true;
            this.NAM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NAM.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.NAM.Caption = "Năm";
            this.NAM.FieldName = "NAM";
            this.NAM.Name = "NAM";
            this.NAM.OptionsColumn.AllowEdit = false;
            this.NAM.Visible = true;
            this.NAM.VisibleIndex = 3;
            this.NAM.Width = 70;
            // 
            // ID_NHAN_VIEN
            // 
            this.ID_NHAN_VIEN.Caption = "ID NHÂN VIÊN";
            this.ID_NHAN_VIEN.FieldName = "ID_NHAN_VIEN";
            this.ID_NHAN_VIEN.Name = "ID_NHAN_VIEN";
            // 
            // SO_TIEN
            // 
            this.SO_TIEN.AppearanceCell.Options.UseTextOptions = true;
            this.SO_TIEN.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SO_TIEN.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.SO_TIEN.AppearanceHeader.Options.UseTextOptions = true;
            this.SO_TIEN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SO_TIEN.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.SO_TIEN.Caption = "Số tiền";
            this.SO_TIEN.DisplayFormat.FormatString = "n0";
            this.SO_TIEN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.SO_TIEN.FieldName = "SO_TIEN";
            this.SO_TIEN.Name = "SO_TIEN";
            this.SO_TIEN.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SO_TIEN", "{0:n0}")});
            this.SO_TIEN.Visible = true;
            this.SO_TIEN.VisibleIndex = 5;
            this.SO_TIEN.Width = 108;
            // 
            // SO_TIEN_GIAM_TRU
            // 
            this.SO_TIEN_GIAM_TRU.AppearanceCell.Options.UseTextOptions = true;
            this.SO_TIEN_GIAM_TRU.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SO_TIEN_GIAM_TRU.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.SO_TIEN_GIAM_TRU.AppearanceHeader.Options.UseTextOptions = true;
            this.SO_TIEN_GIAM_TRU.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SO_TIEN_GIAM_TRU.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.SO_TIEN_GIAM_TRU.Caption = "Thuế TNCN 10%";
            this.SO_TIEN_GIAM_TRU.DisplayFormat.FormatString = "n0";
            this.SO_TIEN_GIAM_TRU.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.SO_TIEN_GIAM_TRU.FieldName = "SO_TIEN_GIAM_TRU";
            this.SO_TIEN_GIAM_TRU.Name = "SO_TIEN_GIAM_TRU";
            this.SO_TIEN_GIAM_TRU.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SO_TIEN_GIAM_TRU", "{0:n0}")});
            this.SO_TIEN_GIAM_TRU.Visible = true;
            this.SO_TIEN_GIAM_TRU.VisibleIndex = 6;
            this.SO_TIEN_GIAM_TRU.Width = 108;
            // 
            // SO_TAI_KHOAN
            // 
            this.SO_TAI_KHOAN.AppearanceCell.Options.UseTextOptions = true;
            this.SO_TAI_KHOAN.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.SO_TAI_KHOAN.AppearanceHeader.Options.UseTextOptions = true;
            this.SO_TAI_KHOAN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SO_TAI_KHOAN.Caption = "Tài khoản";
            this.SO_TAI_KHOAN.FieldName = "SO_TAI_KHOAN";
            this.SO_TAI_KHOAN.Name = "SO_TAI_KHOAN";
            this.SO_TAI_KHOAN.Visible = true;
            this.SO_TAI_KHOAN.VisibleIndex = 8;
            this.SO_TAI_KHOAN.Width = 122;
            // 
            // THUC_LINH_CUOI_CUNG
            // 
            this.THUC_LINH_CUOI_CUNG.AppearanceCell.Options.UseTextOptions = true;
            this.THUC_LINH_CUOI_CUNG.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.THUC_LINH_CUOI_CUNG.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.THUC_LINH_CUOI_CUNG.AppearanceHeader.Options.UseTextOptions = true;
            this.THUC_LINH_CUOI_CUNG.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.THUC_LINH_CUOI_CUNG.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.THUC_LINH_CUOI_CUNG.Caption = "Thực lĩnh cuối cùng";
            this.THUC_LINH_CUOI_CUNG.DisplayFormat.FormatString = "n0";
            this.THUC_LINH_CUOI_CUNG.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.THUC_LINH_CUOI_CUNG.FieldName = "THUC_LINH_CUOI_CUNG";
            this.THUC_LINH_CUOI_CUNG.Name = "THUC_LINH_CUOI_CUNG";
            this.THUC_LINH_CUOI_CUNG.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "THUC_LINH_CUOI_CUNG", "{0:n0}")});
            this.THUC_LINH_CUOI_CUNG.Visible = true;
            this.THUC_LINH_CUOI_CUNG.VisibleIndex = 7;
            this.THUC_LINH_CUOI_CUNG.Width = 114;
            // 
            // CHUC_VU
            // 
            this.CHUC_VU.AppearanceCell.Options.UseTextOptions = true;
            this.CHUC_VU.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CHUC_VU.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.CHUC_VU.AppearanceHeader.Options.UseTextOptions = true;
            this.CHUC_VU.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CHUC_VU.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.CHUC_VU.Caption = "Chức danh";
            this.CHUC_VU.FieldName = "CHUC_VU";
            this.CHUC_VU.Name = "CHUC_VU";
            this.CHUC_VU.Visible = true;
            this.CHUC_VU.VisibleIndex = 4;
            this.CHUC_VU.Width = 100;
            // 
            // STT
            // 
            this.STT.AppearanceCell.Options.UseTextOptions = true;
            this.STT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.STT.AppearanceHeader.Options.UseTextOptions = true;
            this.STT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.STT.Caption = "STT";
            this.STT.FieldName = "STT";
            this.STT.Name = "STT";
            this.STT.Visible = true;
            this.STT.VisibleIndex = 0;
            // 
            // f481_bao_cao_thu_lao_hdqt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 478);
            this.Controls.Add(this.m_grc_bc_thu_lao);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.m_lbl_header);
            this.Name = "f481_bao_cao_thu_lao_hdqt";
            this.Text = "F481 - Báo cáo thù lao của Hội đồng quản trị";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_bc_thu_lao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_hs_bs_hs_athk)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label m_lbl_header;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton m_cmd_search;
        private System.Windows.Forms.TextBox m_txt_chon_nam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox m_txt_chon_thang;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl m_grc_bc_thu_lao;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv_hs_bs_hs_athk;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn MA_NV;
        private DevExpress.XtraGrid.Columns.GridColumn HO_TEN;
        private DevExpress.XtraGrid.Columns.GridColumn THANG;
        private DevExpress.XtraGrid.Columns.GridColumn NAM;
        private DevExpress.XtraGrid.Columns.GridColumn ID_NHAN_VIEN;
        private DevExpress.XtraGrid.Columns.GridColumn SO_TIEN;
        private DevExpress.XtraGrid.Columns.GridColumn SO_TIEN_GIAM_TRU;
        private DevExpress.XtraGrid.Columns.GridColumn SO_TAI_KHOAN;
        private DevExpress.XtraGrid.Columns.GridColumn THUC_LINH_CUOI_CUNG;
        private DevExpress.XtraGrid.Columns.GridColumn CHUC_VU;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
    }
}