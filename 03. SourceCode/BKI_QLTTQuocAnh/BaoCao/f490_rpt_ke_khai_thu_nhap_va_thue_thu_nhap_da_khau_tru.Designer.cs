namespace BKI_DichVuMatDat.BaoCao
{
    partial class f490_rpt_ke_khai_thu_nhap_va_thue_thu_nhap_da_khau_tru
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
            this.m_panel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.m_prb = new DevExpress.XtraEditors.ProgressBarControl();
            this.PHU_THUOC = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.CA_NHAN = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.BHXH = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.TONG_THU_NHAP_TINH_THUE = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.THUE = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.TONG_THU_NHAP_CHIU_THUE = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.DA_NOP = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.LUONG = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.THUONG = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.THUONG_ATHK = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.TIEN_LE_TET = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.THU_NHAP_KHAC = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.TONG_SO_PHAI_NOP = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.THU_NHAP_BINH_QUAN_THUE = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.BO_SUNG_DT_LUONG = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.m_bgwk = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.m_cmd_tinh = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.m_txt_nam = new System.Windows.Forms.TextBox();
            this.m_grc_tong_hop = new DevExpress.XtraGrid.GridControl();
            this.m_adv_tong_hop = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.STT = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.MA_NV = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.HO_TEN = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.TEN_CHUC_VU = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.DON_VI = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand4 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.SO_THANG_LAM_VIEC_TINH_THUE = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand7 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand8 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand5 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand6 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.CON_PHAI_NOP = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TEN_HOP_DONG = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.m_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_prb.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_tong_hop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_adv_tong_hop)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_panel
            // 
            this.m_panel.Controls.Add(this.label3);
            this.m_panel.Controls.Add(this.m_prb);
            this.m_panel.Location = new System.Drawing.Point(343, 126);
            this.m_panel.Name = "m_panel";
            this.m_panel.Padding = new System.Windows.Forms.Padding(10);
            this.m_panel.Size = new System.Drawing.Size(526, 80);
            this.m_panel.TabIndex = 12;
            this.m_panel.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Đang tải dữ liệu. Vui lòng chờ trong giây lát ...";
            // 
            // m_prb
            // 
            this.m_prb.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_prb.Location = new System.Drawing.Point(10, 10);
            this.m_prb.Name = "m_prb";
            this.m_prb.Properties.DisplayFormat.FormatString = "n0";
            this.m_prb.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.m_prb.Properties.ShowTitle = true;
            this.m_prb.ShowProgressInTaskBar = true;
            this.m_prb.Size = new System.Drawing.Size(506, 30);
            this.m_prb.TabIndex = 8;
            this.m_prb.Visible = false;
            // 
            // PHU_THUOC
            // 
            this.PHU_THUOC.AppearanceHeader.ForeColor = System.Drawing.Color.Maroon;
            this.PHU_THUOC.AppearanceHeader.Options.UseForeColor = true;
            this.PHU_THUOC.AppearanceHeader.Options.UseTextOptions = true;
            this.PHU_THUOC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.PHU_THUOC.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.PHU_THUOC.Caption = "Phụ thuộc";
            this.PHU_THUOC.DisplayFormat.FormatString = "n0";
            this.PHU_THUOC.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.PHU_THUOC.FieldName = "PHU_THUOC";
            this.PHU_THUOC.Name = "PHU_THUOC";
            this.PHU_THUOC.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PHU_THUOC", "{0:n0}")});
            this.PHU_THUOC.Visible = true;
            // 
            // CA_NHAN
            // 
            this.CA_NHAN.AppearanceHeader.ForeColor = System.Drawing.Color.Maroon;
            this.CA_NHAN.AppearanceHeader.Options.UseForeColor = true;
            this.CA_NHAN.AppearanceHeader.Options.UseTextOptions = true;
            this.CA_NHAN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CA_NHAN.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.CA_NHAN.Caption = "Cá nhân";
            this.CA_NHAN.DisplayFormat.FormatString = "n0";
            this.CA_NHAN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.CA_NHAN.FieldName = "CA_NHAN";
            this.CA_NHAN.Name = "CA_NHAN";
            this.CA_NHAN.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "CA_NHAN", "{0:n0}")});
            this.CA_NHAN.Visible = true;
            // 
            // BHXH
            // 
            this.BHXH.AppearanceHeader.ForeColor = System.Drawing.Color.Maroon;
            this.BHXH.AppearanceHeader.Options.UseForeColor = true;
            this.BHXH.AppearanceHeader.Options.UseTextOptions = true;
            this.BHXH.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.BHXH.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.BHXH.Caption = "BHXH";
            this.BHXH.DisplayFormat.FormatString = "n0";
            this.BHXH.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.BHXH.FieldName = "BHXH";
            this.BHXH.Name = "BHXH";
            this.BHXH.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "BHXH", "{0:n0}")});
            this.BHXH.Visible = true;
            // 
            // TONG_THU_NHAP_TINH_THUE
            // 
            this.TONG_THU_NHAP_TINH_THUE.AppearanceHeader.ForeColor = System.Drawing.Color.Maroon;
            this.TONG_THU_NHAP_TINH_THUE.AppearanceHeader.Options.UseForeColor = true;
            this.TONG_THU_NHAP_TINH_THUE.AppearanceHeader.Options.UseTextOptions = true;
            this.TONG_THU_NHAP_TINH_THUE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TONG_THU_NHAP_TINH_THUE.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.TONG_THU_NHAP_TINH_THUE.Caption = "Tổng thu nhập tính thuế";
            this.TONG_THU_NHAP_TINH_THUE.DisplayFormat.FormatString = "n0";
            this.TONG_THU_NHAP_TINH_THUE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TONG_THU_NHAP_TINH_THUE.FieldName = "TONG_THU_NHAP_TINH_THUE";
            this.TONG_THU_NHAP_TINH_THUE.Name = "TONG_THU_NHAP_TINH_THUE";
            this.TONG_THU_NHAP_TINH_THUE.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TONG_THU_NHAP_TINH_THUE", "{0:n0}")});
            this.TONG_THU_NHAP_TINH_THUE.Visible = true;
            // 
            // THUE
            // 
            this.THUE.AppearanceHeader.ForeColor = System.Drawing.Color.Maroon;
            this.THUE.AppearanceHeader.Options.UseForeColor = true;
            this.THUE.AppearanceHeader.Options.UseTextOptions = true;
            this.THUE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.THUE.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.THUE.Caption = "Thuế";
            this.THUE.DisplayFormat.FormatString = "n0";
            this.THUE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.THUE.FieldName = "THUE";
            this.THUE.Name = "THUE";
            this.THUE.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "THUE", "{0:n0}")});
            this.THUE.Visible = true;
            // 
            // TONG_THU_NHAP_CHIU_THUE
            // 
            this.TONG_THU_NHAP_CHIU_THUE.AppearanceHeader.ForeColor = System.Drawing.Color.Maroon;
            this.TONG_THU_NHAP_CHIU_THUE.AppearanceHeader.Options.UseForeColor = true;
            this.TONG_THU_NHAP_CHIU_THUE.AppearanceHeader.Options.UseTextOptions = true;
            this.TONG_THU_NHAP_CHIU_THUE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TONG_THU_NHAP_CHIU_THUE.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.TONG_THU_NHAP_CHIU_THUE.Caption = "Tổng thu nhập chịu thuế";
            this.TONG_THU_NHAP_CHIU_THUE.DisplayFormat.FormatString = "n0";
            this.TONG_THU_NHAP_CHIU_THUE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TONG_THU_NHAP_CHIU_THUE.FieldName = "TONG_THU_NHAP_CHIU_THUE";
            this.TONG_THU_NHAP_CHIU_THUE.Name = "TONG_THU_NHAP_CHIU_THUE";
            this.TONG_THU_NHAP_CHIU_THUE.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TONG_THU_NHAP_CHIU_THUE", "{0:n0}")});
            this.TONG_THU_NHAP_CHIU_THUE.Visible = true;
            this.TONG_THU_NHAP_CHIU_THUE.Width = 49;
            // 
            // DA_NOP
            // 
            this.DA_NOP.AppearanceHeader.ForeColor = System.Drawing.Color.Maroon;
            this.DA_NOP.AppearanceHeader.Options.UseForeColor = true;
            this.DA_NOP.AppearanceHeader.Options.UseTextOptions = true;
            this.DA_NOP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.DA_NOP.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.DA_NOP.Caption = "Đã nộp";
            this.DA_NOP.DisplayFormat.FormatString = "n0";
            this.DA_NOP.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.DA_NOP.FieldName = "DA_NOP";
            this.DA_NOP.Name = "DA_NOP";
            this.DA_NOP.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "DA_NOP", "{0:n0}")});
            this.DA_NOP.Visible = true;
            // 
            // LUONG
            // 
            this.LUONG.AppearanceHeader.ForeColor = System.Drawing.Color.Maroon;
            this.LUONG.AppearanceHeader.Options.UseForeColor = true;
            this.LUONG.AppearanceHeader.Options.UseTextOptions = true;
            this.LUONG.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.LUONG.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.LUONG.Caption = "Lương ";
            this.LUONG.DisplayFormat.FormatString = "n0";
            this.LUONG.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.LUONG.FieldName = "LUONG";
            this.LUONG.Name = "LUONG";
            this.LUONG.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "LUONG", "{0:n0}")});
            this.LUONG.Visible = true;
            this.LUONG.Width = 68;
            // 
            // THUONG
            // 
            this.THUONG.AppearanceHeader.ForeColor = System.Drawing.Color.Maroon;
            this.THUONG.AppearanceHeader.Options.UseForeColor = true;
            this.THUONG.AppearanceHeader.Options.UseTextOptions = true;
            this.THUONG.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.THUONG.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.THUONG.Caption = "Thưởng";
            this.THUONG.DisplayFormat.FormatString = "n0";
            this.THUONG.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.THUONG.FieldName = "THUONG";
            this.THUONG.Name = "THUONG";
            this.THUONG.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "THUONG", "{0:n0}")});
            this.THUONG.Visible = true;
            this.THUONG.Width = 68;
            // 
            // THUONG_ATHK
            // 
            this.THUONG_ATHK.AppearanceHeader.ForeColor = System.Drawing.Color.Maroon;
            this.THUONG_ATHK.AppearanceHeader.Options.UseForeColor = true;
            this.THUONG_ATHK.AppearanceHeader.Options.UseTextOptions = true;
            this.THUONG_ATHK.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.THUONG_ATHK.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.THUONG_ATHK.Caption = "Thưởng ATHK";
            this.THUONG_ATHK.DisplayFormat.FormatString = "n0";
            this.THUONG_ATHK.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.THUONG_ATHK.FieldName = "THUONG_ATHK";
            this.THUONG_ATHK.Name = "THUONG_ATHK";
            this.THUONG_ATHK.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "THUONG_ATHK", "{0:n0}")});
            this.THUONG_ATHK.Visible = true;
            this.THUONG_ATHK.Width = 68;
            // 
            // TIEN_LE_TET
            // 
            this.TIEN_LE_TET.AppearanceHeader.ForeColor = System.Drawing.Color.Maroon;
            this.TIEN_LE_TET.AppearanceHeader.Options.UseForeColor = true;
            this.TIEN_LE_TET.AppearanceHeader.Options.UseTextOptions = true;
            this.TIEN_LE_TET.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TIEN_LE_TET.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.TIEN_LE_TET.Caption = "Tiền lễ, tết";
            this.TIEN_LE_TET.DisplayFormat.FormatString = "n0";
            this.TIEN_LE_TET.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TIEN_LE_TET.FieldName = "TIEN_LE_TET";
            this.TIEN_LE_TET.Name = "TIEN_LE_TET";
            this.TIEN_LE_TET.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TIEN_LE_TET", "{0:n0}")});
            this.TIEN_LE_TET.Visible = true;
            this.TIEN_LE_TET.Width = 68;
            // 
            // THU_NHAP_KHAC
            // 
            this.THU_NHAP_KHAC.AppearanceHeader.ForeColor = System.Drawing.Color.Maroon;
            this.THU_NHAP_KHAC.AppearanceHeader.Options.UseForeColor = true;
            this.THU_NHAP_KHAC.AppearanceHeader.Options.UseTextOptions = true;
            this.THU_NHAP_KHAC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.THU_NHAP_KHAC.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.THU_NHAP_KHAC.Caption = "Thu nhập khác";
            this.THU_NHAP_KHAC.DisplayFormat.FormatString = "n0";
            this.THU_NHAP_KHAC.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.THU_NHAP_KHAC.FieldName = "THU_NHAP_KHAC";
            this.THU_NHAP_KHAC.Name = "THU_NHAP_KHAC";
            this.THU_NHAP_KHAC.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "THU_NHAP_KHAC", "{0:n0}")});
            this.THU_NHAP_KHAC.Visible = true;
            this.THU_NHAP_KHAC.Width = 68;
            // 
            // TONG_SO_PHAI_NOP
            // 
            this.TONG_SO_PHAI_NOP.AppearanceHeader.ForeColor = System.Drawing.Color.Maroon;
            this.TONG_SO_PHAI_NOP.AppearanceHeader.Options.UseForeColor = true;
            this.TONG_SO_PHAI_NOP.AppearanceHeader.Options.UseTextOptions = true;
            this.TONG_SO_PHAI_NOP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TONG_SO_PHAI_NOP.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.TONG_SO_PHAI_NOP.Caption = "Tổng số phải nộp";
            this.TONG_SO_PHAI_NOP.DisplayFormat.FormatString = "n0";
            this.TONG_SO_PHAI_NOP.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TONG_SO_PHAI_NOP.FieldName = "TONG_SO_PHAI_NOP";
            this.TONG_SO_PHAI_NOP.Name = "TONG_SO_PHAI_NOP";
            this.TONG_SO_PHAI_NOP.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TONG_SO_PHAI_NOP", "{0:n0}")});
            this.TONG_SO_PHAI_NOP.Visible = true;
            // 
            // THU_NHAP_BINH_QUAN_THUE
            // 
            this.THU_NHAP_BINH_QUAN_THUE.AppearanceHeader.ForeColor = System.Drawing.Color.Maroon;
            this.THU_NHAP_BINH_QUAN_THUE.AppearanceHeader.Options.UseForeColor = true;
            this.THU_NHAP_BINH_QUAN_THUE.AppearanceHeader.Options.UseTextOptions = true;
            this.THU_NHAP_BINH_QUAN_THUE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.THU_NHAP_BINH_QUAN_THUE.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.THU_NHAP_BINH_QUAN_THUE.Caption = "Thu nhập tính thuế bình quân/ tháng";
            this.THU_NHAP_BINH_QUAN_THUE.DisplayFormat.FormatString = "n0";
            this.THU_NHAP_BINH_QUAN_THUE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.THU_NHAP_BINH_QUAN_THUE.FieldName = "THU_NHAP_TINH_THUE_BINH_QUAN";
            this.THU_NHAP_BINH_QUAN_THUE.Name = "THU_NHAP_BINH_QUAN_THUE";
            this.THU_NHAP_BINH_QUAN_THUE.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "THU_NHAP_TINH_THUE_BINH_QUAN", "{0:n0}")});
            this.THU_NHAP_BINH_QUAN_THUE.Visible = true;
            this.THU_NHAP_BINH_QUAN_THUE.Width = 110;
            // 
            // BO_SUNG_DT_LUONG
            // 
            this.BO_SUNG_DT_LUONG.AppearanceHeader.ForeColor = System.Drawing.Color.Maroon;
            this.BO_SUNG_DT_LUONG.AppearanceHeader.Options.UseForeColor = true;
            this.BO_SUNG_DT_LUONG.AppearanceHeader.Options.UseTextOptions = true;
            this.BO_SUNG_DT_LUONG.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.BO_SUNG_DT_LUONG.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.BO_SUNG_DT_LUONG.Caption = "Bổ sung, dt lương";
            this.BO_SUNG_DT_LUONG.DisplayFormat.FormatString = "n0";
            this.BO_SUNG_DT_LUONG.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.BO_SUNG_DT_LUONG.FieldName = "BO_SUNG_DT_LUONG";
            this.BO_SUNG_DT_LUONG.Name = "BO_SUNG_DT_LUONG";
            this.BO_SUNG_DT_LUONG.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "BO_SUNG_DT_LUONG", "{0:n0}")});
            this.BO_SUNG_DT_LUONG.Visible = true;
            this.BO_SUNG_DT_LUONG.Width = 68;
            // 
            // m_bgwk
            // 
            this.m_bgwk.WorkerReportsProgress = true;
            this.m_bgwk.WorkerSupportsCancellation = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.m_cmd_tinh);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.m_txt_nam);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(1318, 90);
            this.panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(601, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "BẢNG KÊ KHAI THU NHẬP VÀ THUẾ THU NHẬP ĐÃ KHẤU TRỪ";
            // 
            // m_cmd_tinh
            // 
            this.m_cmd_tinh.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.m_cmd_tinh.Location = new System.Drawing.Point(261, 48);
            this.m_cmd_tinh.Name = "m_cmd_tinh";
            this.m_cmd_tinh.Size = new System.Drawing.Size(75, 23);
            this.m_cmd_tinh.TabIndex = 9;
            this.m_cmd_tinh.Text = "Xem báo cáo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nhập năm";
            // 
            // m_txt_nam
            // 
            this.m_txt_nam.Location = new System.Drawing.Point(125, 50);
            this.m_txt_nam.Name = "m_txt_nam";
            this.m_txt_nam.Size = new System.Drawing.Size(100, 20);
            this.m_txt_nam.TabIndex = 7;
            this.m_txt_nam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.m_txt_nam_KeyPress);
            // 
            // m_grc_tong_hop
            // 
            this.m_grc_tong_hop.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_tong_hop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc_tong_hop.Location = new System.Drawing.Point(0, 0);
            this.m_grc_tong_hop.MainView = this.m_adv_tong_hop;
            this.m_grc_tong_hop.Name = "m_grc_tong_hop";
            this.m_grc_tong_hop.Size = new System.Drawing.Size(1318, 376);
            this.m_grc_tong_hop.TabIndex = 11;
            this.m_grc_tong_hop.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_adv_tong_hop});
            // 
            // m_adv_tong_hop
            // 
            this.m_adv_tong_hop.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand4,
            this.gridBand2,
            this.gridBand3,
            this.gridBand7,
            this.gridBand8,
            this.gridBand5,
            this.gridBand6});
            this.m_adv_tong_hop.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.STT,
            this.MA_NV,
            this.HO_TEN,
            this.TEN_CHUC_VU,
            this.SO_THANG_LAM_VIEC_TINH_THUE,
            this.LUONG,
            this.THUONG,
            this.THUONG_ATHK,
            this.TIEN_LE_TET,
            this.THU_NHAP_KHAC,
            this.TONG_SO_PHAI_NOP,
            this.THU_NHAP_BINH_QUAN_THUE,
            this.BO_SUNG_DT_LUONG,
            this.PHU_THUOC,
            this.CA_NHAN,
            this.BHXH,
            this.TONG_THU_NHAP_TINH_THUE,
            this.THUE,
            this.TONG_THU_NHAP_CHIU_THUE,
            this.DA_NOP,
            this.DON_VI,
            this.CON_PHAI_NOP});
            this.m_adv_tong_hop.GridControl = this.m_grc_tong_hop;
            this.m_adv_tong_hop.GroupCount = 1;
            this.m_adv_tong_hop.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "THUONG", this.THUONG, "{0:n0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "LUONG", this.LUONG, "{0:n0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "THUONG_ATHK", this.THUONG_ATHK, "{0:n0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "BO_SUNG_DT_LUONG", this.BO_SUNG_DT_LUONG, "{0:n0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TIEN_LE_TET", this.TIEN_LE_TET, "{0:n0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "THU_NHAP_KHAC", this.THU_NHAP_KHAC, "{0:n0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TONG_THU_NHAP_CHIU_THUE", this.TONG_THU_NHAP_CHIU_THUE, "{0:n0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "CA_NHAN", this.CA_NHAN, "{0:n0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PHU_THUOC", this.PHU_THUOC, "{0:n0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "BHXH", this.BHXH, "{0:n0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TONG_THU_NHAP_CHIU_THUE", this.TONG_THU_NHAP_CHIU_THUE, "{0:n0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SO_THANG_LAM_VIEC_TINH_THUE", this.SO_THANG_LAM_VIEC_TINH_THUE, "{0:n0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TONG_THU_NHAP_TINH_THUE", this.TONG_THU_NHAP_TINH_THUE, "{0:n0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TONG_SO_PHAI_NOP", this.TONG_SO_PHAI_NOP, "{0:n0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "DA_NOP", this.DA_NOP, "{0:n0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "CON_PHAI_NOP", this.CON_PHAI_NOP, "{0:n0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "THU_NHAP_TINH_THUE_BINH_QUAN", this.THU_NHAP_BINH_QUAN_THUE, "{0:n0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "THUONG", null, "{0:n0}")});
            this.m_adv_tong_hop.Name = "m_adv_tong_hop";
            this.m_adv_tong_hop.OptionsBehavior.Editable = false;
            this.m_adv_tong_hop.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDown;
            this.m_adv_tong_hop.OptionsBehavior.ReadOnly = true;
            this.m_adv_tong_hop.OptionsView.ShowFooter = true;
            this.m_adv_tong_hop.OptionsView.ShowGroupPanel = false;
            this.m_adv_tong_hop.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.DON_VI, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.m_adv_tong_hop.DoubleClick += new System.EventHandler(this.m_adv_tong_hop_DoubleClick);
            // 
            // gridBand1
            // 
            this.gridBand1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand1.AppearanceHeader.ForeColor = System.Drawing.Color.Maroon;
            this.gridBand1.AppearanceHeader.Options.UseFont = true;
            this.gridBand1.AppearanceHeader.Options.UseForeColor = true;
            this.gridBand1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand1.Caption = "Thông tin cơ bản";
            this.gridBand1.Columns.Add(this.STT);
            this.gridBand1.Columns.Add(this.MA_NV);
            this.gridBand1.Columns.Add(this.HO_TEN);
            this.gridBand1.Columns.Add(this.TEN_CHUC_VU);
            this.gridBand1.Columns.Add(this.DON_VI);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 345;
            // 
            // STT
            // 
            this.STT.AppearanceHeader.ForeColor = System.Drawing.Color.Maroon;
            this.STT.AppearanceHeader.Options.UseForeColor = true;
            this.STT.AppearanceHeader.Options.UseTextOptions = true;
            this.STT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.STT.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.STT.Caption = "STT";
            this.STT.FieldName = "STT";
            this.STT.Name = "STT";
            this.STT.RowIndex = 1;
            this.STT.Width = 30;
            // 
            // MA_NV
            // 
            this.MA_NV.AppearanceHeader.ForeColor = System.Drawing.Color.Maroon;
            this.MA_NV.AppearanceHeader.Options.UseForeColor = true;
            this.MA_NV.AppearanceHeader.Options.UseTextOptions = true;
            this.MA_NV.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.MA_NV.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.MA_NV.Caption = "Mã nhân viên";
            this.MA_NV.FieldName = "MA_NV";
            this.MA_NV.Name = "MA_NV";
            this.MA_NV.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "MA_NV", "SLNV : {0:n0}")});
            this.MA_NV.Visible = true;
            // 
            // HO_TEN
            // 
            this.HO_TEN.AppearanceHeader.ForeColor = System.Drawing.Color.Maroon;
            this.HO_TEN.AppearanceHeader.Options.UseForeColor = true;
            this.HO_TEN.AppearanceHeader.Options.UseTextOptions = true;
            this.HO_TEN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.HO_TEN.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.HO_TEN.Caption = "Họ và tên";
            this.HO_TEN.FieldName = "HO_TEN";
            this.HO_TEN.Name = "HO_TEN";
            this.HO_TEN.Visible = true;
            this.HO_TEN.Width = 99;
            // 
            // TEN_CHUC_VU
            // 
            this.TEN_CHUC_VU.AppearanceHeader.ForeColor = System.Drawing.Color.Maroon;
            this.TEN_CHUC_VU.AppearanceHeader.Options.UseForeColor = true;
            this.TEN_CHUC_VU.AppearanceHeader.Options.UseTextOptions = true;
            this.TEN_CHUC_VU.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TEN_CHUC_VU.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.TEN_CHUC_VU.Caption = "Chức vụ";
            this.TEN_CHUC_VU.FieldName = "CHUC_VU";
            this.TEN_CHUC_VU.Name = "TEN_CHUC_VU";
            this.TEN_CHUC_VU.Visible = true;
            this.TEN_CHUC_VU.Width = 96;
            // 
            // DON_VI
            // 
            this.DON_VI.AppearanceHeader.ForeColor = System.Drawing.Color.Maroon;
            this.DON_VI.AppearanceHeader.Options.UseForeColor = true;
            this.DON_VI.AppearanceHeader.Options.UseTextOptions = true;
            this.DON_VI.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.DON_VI.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.DON_VI.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.DON_VI.Caption = "Đơn vị";
            this.DON_VI.FieldName = "TEN_DON_VI";
            this.DON_VI.Name = "DON_VI";
            this.DON_VI.Visible = true;
            // 
            // gridBand4
            // 
            this.gridBand4.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand4.AppearanceHeader.ForeColor = System.Drawing.Color.Maroon;
            this.gridBand4.AppearanceHeader.Options.UseFont = true;
            this.gridBand4.AppearanceHeader.Options.UseForeColor = true;
            this.gridBand4.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand4.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridBand4.Caption = "Thu nhập chịu thuế";
            this.gridBand4.Columns.Add(this.LUONG);
            this.gridBand4.Columns.Add(this.THUONG);
            this.gridBand4.Columns.Add(this.THUONG_ATHK);
            this.gridBand4.Columns.Add(this.BO_SUNG_DT_LUONG);
            this.gridBand4.Columns.Add(this.TIEN_LE_TET);
            this.gridBand4.Columns.Add(this.THU_NHAP_KHAC);
            this.gridBand4.Name = "gridBand4";
            this.gridBand4.VisibleIndex = 1;
            this.gridBand4.Width = 408;
            // 
            // gridBand2
            // 
            this.gridBand2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand2.AppearanceHeader.ForeColor = System.Drawing.Color.Maroon;
            this.gridBand2.AppearanceHeader.Options.UseFont = true;
            this.gridBand2.AppearanceHeader.Options.UseForeColor = true;
            this.gridBand2.Caption = "Tổng thu nhập chịu thuế";
            this.gridBand2.Columns.Add(this.TONG_THU_NHAP_CHIU_THUE);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 2;
            this.gridBand2.Width = 49;
            // 
            // gridBand3
            // 
            this.gridBand3.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand3.AppearanceHeader.ForeColor = System.Drawing.Color.Maroon;
            this.gridBand3.AppearanceHeader.Options.UseFont = true;
            this.gridBand3.AppearanceHeader.Options.UseForeColor = true;
            this.gridBand3.Caption = "Số tháng làm việc tính thuế";
            this.gridBand3.Columns.Add(this.SO_THANG_LAM_VIEC_TINH_THUE);
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.VisibleIndex = 3;
            this.gridBand3.Width = 20;
            // 
            // SO_THANG_LAM_VIEC_TINH_THUE
            // 
            this.SO_THANG_LAM_VIEC_TINH_THUE.AppearanceHeader.ForeColor = System.Drawing.Color.Maroon;
            this.SO_THANG_LAM_VIEC_TINH_THUE.AppearanceHeader.Options.UseForeColor = true;
            this.SO_THANG_LAM_VIEC_TINH_THUE.AppearanceHeader.Options.UseTextOptions = true;
            this.SO_THANG_LAM_VIEC_TINH_THUE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SO_THANG_LAM_VIEC_TINH_THUE.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.SO_THANG_LAM_VIEC_TINH_THUE.Caption = "Số tháng làm việc tính thuế";
            this.SO_THANG_LAM_VIEC_TINH_THUE.FieldName = "SO_THANG_LAM_VIEC_TINH_THUE";
            this.SO_THANG_LAM_VIEC_TINH_THUE.Name = "SO_THANG_LAM_VIEC_TINH_THUE";
            this.SO_THANG_LAM_VIEC_TINH_THUE.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SO_THANG_LAM_VIEC_TINH_THUE", "{0:n0}")});
            this.SO_THANG_LAM_VIEC_TINH_THUE.Visible = true;
            this.SO_THANG_LAM_VIEC_TINH_THUE.Width = 20;
            // 
            // gridBand7
            // 
            this.gridBand7.AppearanceHeader.BackColor = System.Drawing.Color.Maroon;
            this.gridBand7.AppearanceHeader.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gridBand7.AppearanceHeader.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gridBand7.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand7.AppearanceHeader.ForeColor = System.Drawing.Color.Maroon;
            this.gridBand7.AppearanceHeader.Options.UseBackColor = true;
            this.gridBand7.AppearanceHeader.Options.UseBorderColor = true;
            this.gridBand7.AppearanceHeader.Options.UseFont = true;
            this.gridBand7.AppearanceHeader.Options.UseForeColor = true;
            this.gridBand7.Caption = "Mức giảm trừ";
            this.gridBand7.Columns.Add(this.CA_NHAN);
            this.gridBand7.Columns.Add(this.PHU_THUOC);
            this.gridBand7.Columns.Add(this.BHXH);
            this.gridBand7.Name = "gridBand7";
            this.gridBand7.VisibleIndex = 4;
            this.gridBand7.Width = 225;
            // 
            // gridBand8
            // 
            this.gridBand8.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand8.AppearanceHeader.ForeColor = System.Drawing.Color.Maroon;
            this.gridBand8.AppearanceHeader.Options.UseFont = true;
            this.gridBand8.AppearanceHeader.Options.UseForeColor = true;
            this.gridBand8.Caption = "Tổng thu nhập tính thuế";
            this.gridBand8.Columns.Add(this.TONG_THU_NHAP_TINH_THUE);
            this.gridBand8.Name = "gridBand8";
            this.gridBand8.VisibleIndex = 5;
            this.gridBand8.Width = 75;
            // 
            // gridBand5
            // 
            this.gridBand5.Columns.Add(this.THU_NHAP_BINH_QUAN_THUE);
            this.gridBand5.Name = "gridBand5";
            this.gridBand5.VisibleIndex = 6;
            this.gridBand5.Width = 110;
            // 
            // gridBand6
            // 
            this.gridBand6.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand6.AppearanceHeader.ForeColor = System.Drawing.Color.Maroon;
            this.gridBand6.AppearanceHeader.Options.UseFont = true;
            this.gridBand6.AppearanceHeader.Options.UseForeColor = true;
            this.gridBand6.Caption = "Thuế thu nhập";
            this.gridBand6.Columns.Add(this.TONG_SO_PHAI_NOP);
            this.gridBand6.Columns.Add(this.DA_NOP);
            this.gridBand6.Columns.Add(this.CON_PHAI_NOP);
            this.gridBand6.Name = "gridBand6";
            this.gridBand6.VisibleIndex = 7;
            this.gridBand6.Width = 225;
            // 
            // CON_PHAI_NOP
            // 
            this.CON_PHAI_NOP.AppearanceHeader.ForeColor = System.Drawing.Color.Maroon;
            this.CON_PHAI_NOP.AppearanceHeader.Options.UseForeColor = true;
            this.CON_PHAI_NOP.AppearanceHeader.Options.UseTextOptions = true;
            this.CON_PHAI_NOP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CON_PHAI_NOP.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.CON_PHAI_NOP.Caption = "Còn phải nộp";
            this.CON_PHAI_NOP.DisplayFormat.FormatString = "n0";
            this.CON_PHAI_NOP.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.CON_PHAI_NOP.FieldName = "CON_PHAI_NOP";
            this.CON_PHAI_NOP.Name = "CON_PHAI_NOP";
            this.CON_PHAI_NOP.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "CON_PHAI_NOP", "{0:n0}")});
            this.CON_PHAI_NOP.Visible = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.m_panel);
            this.panel2.Controls.Add(this.m_grc_tong_hop);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1318, 376);
            this.panel2.TabIndex = 13;
            // 
            // TEN_HOP_DONG
            // 
            this.TEN_HOP_DONG.AppearanceHeader.ForeColor = System.Drawing.Color.Maroon;
            this.TEN_HOP_DONG.AppearanceHeader.Options.UseForeColor = true;
            this.TEN_HOP_DONG.AppearanceHeader.Options.UseTextOptions = true;
            this.TEN_HOP_DONG.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TEN_HOP_DONG.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.TEN_HOP_DONG.Caption = "Hợp đồng";
            this.TEN_HOP_DONG.FieldName = "TEN_HOP_DONG";
            this.TEN_HOP_DONG.Name = "TEN_HOP_DONG";
            this.TEN_HOP_DONG.Visible = true;
            // 
            // f490_rpt_ke_khai_thu_nhap_va_thue_thu_nhap_da_khau_tru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 466);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "f490_rpt_ke_khai_thu_nhap_va_thue_thu_nhap_da_khau_tru";
            this.Text = "f420_rpt_ke_khai_thu_nhap_va_thue_thu_nhap_da_khau_tru";
            this.Load += new System.EventHandler(this.f490_rpt_ke_khai_thu_nhap_va_thue_thu_nhap_da_khau_tru_Load);
            this.m_panel.ResumeLayout(false);
            this.m_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_prb.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_tong_hop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_adv_tong_hop)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel m_panel;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.ProgressBarControl m_prb;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn LUONG;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn THUONG;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn THUONG_ATHK;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn TIEN_LE_TET;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn THU_NHAP_KHAC;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn TONG_SO_PHAI_NOP;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn THU_NHAP_BINH_QUAN_THUE;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn BO_SUNG_DT_LUONG;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn PHU_THUOC;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn CA_NHAN;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn BHXH;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn TONG_THU_NHAP_TINH_THUE;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn THUE;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn TONG_THU_NHAP_CHIU_THUE;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn DA_NOP;
        private System.ComponentModel.BackgroundWorker m_bgwk;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton m_cmd_tinh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox m_txt_nam;
        private DevExpress.XtraGrid.GridControl m_grc_tong_hop;
        private DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView m_adv_tong_hop;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn STT;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn MA_NV;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn HO_TEN;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn DON_VI;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn TEN_CHUC_VU;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn SO_THANG_LAM_VIEC_TINH_THUE;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn CON_PHAI_NOP;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn TEN_HOP_DONG;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand4;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand7;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand8;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand5;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand6;
    }
}