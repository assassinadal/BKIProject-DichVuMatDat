namespace BKI_DichVuMatDat.BaoCao
{
    partial class f413_rpt_tong_hop_thong_tin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f413_rpt_tong_hop_thong_tin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_cmd_tinh = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.m_txt_nam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.m_txt_thang = new System.Windows.Forms.TextBox();
            this.m_cmd_luu_bang_luong = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.advBandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.STT = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.MA_NV = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.HO_VA_TEN = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.TEN_CHUC_VU = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.TEN_HOP_DONG = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.LUONG_CHE_DO_THEO_CHUC_VU = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.TAI_KHOAN = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.CHAM_CONG_X = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.CHAM_CONG_OM_CO = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.CHAM_CONG_TS = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.CHAM_CONG_TNLD = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.CHAM_CONG_PHEP_DIDUONG = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.CHAM_CONG_RO_KO_DC = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.CHAM_CONG_KHAC = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.HE_SO_K = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.m_bgwk = new System.ComponentModel.BackgroundWorker();
            this.m_prb = new DevExpress.XtraEditors.ProgressBarControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_prb.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_cmd_tinh);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.m_txt_nam);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.m_txt_thang);
            this.panel1.Controls.Add(this.m_cmd_luu_bang_luong);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(941, 47);
            this.panel1.TabIndex = 6;
            // 
            // m_cmd_tinh
            // 
            this.m_cmd_tinh.Location = new System.Drawing.Point(394, 13);
            this.m_cmd_tinh.Name = "m_cmd_tinh";
            this.m_cmd_tinh.Size = new System.Drawing.Size(75, 23);
            this.m_cmd_tinh.TabIndex = 9;
            this.m_cmd_tinh.Text = "Xem báo cáo";
            this.m_cmd_tinh.Click += new System.EventHandler(this.m_cmd_tinh_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nhập năm";
            // 
            // m_txt_nam
            // 
            this.m_txt_nam.Location = new System.Drawing.Point(273, 15);
            this.m_txt_nam.Name = "m_txt_nam";
            this.m_txt_nam.Size = new System.Drawing.Size(100, 20);
            this.m_txt_nam.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nhập tháng";
            // 
            // m_txt_thang
            // 
            this.m_txt_thang.Location = new System.Drawing.Point(91, 15);
            this.m_txt_thang.Name = "m_txt_thang";
            this.m_txt_thang.Size = new System.Drawing.Size(100, 20);
            this.m_txt_thang.TabIndex = 5;
            // 
            // m_cmd_luu_bang_luong
            // 
            this.m_cmd_luu_bang_luong.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_luu_bang_luong.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_luu_bang_luong.Image")));
            this.m_cmd_luu_bang_luong.Location = new System.Drawing.Point(782, 5);
            this.m_cmd_luu_bang_luong.Name = "m_cmd_luu_bang_luong";
            this.m_cmd_luu_bang_luong.Size = new System.Drawing.Size(154, 37);
            this.m_cmd_luu_bang_luong.TabIndex = 4;
            this.m_cmd_luu_bang_luong.Text = "Xuất bảng lương";
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 47);
            this.gridControl1.MainView = this.advBandedGridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(941, 438);
            this.gridControl1.TabIndex = 7;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.advBandedGridView1});
            // 
            // advBandedGridView1
            // 
            this.advBandedGridView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand2,
            this.gridBand3});
            this.advBandedGridView1.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.STT,
            this.MA_NV,
            this.HO_VA_TEN,
            this.TEN_CHUC_VU,
            this.TEN_HOP_DONG,
            this.LUONG_CHE_DO_THEO_CHUC_VU,
            this.TAI_KHOAN,
            this.CHAM_CONG_X,
            this.CHAM_CONG_OM_CO,
            this.CHAM_CONG_TS,
            this.CHAM_CONG_TNLD,
            this.CHAM_CONG_PHEP_DIDUONG,
            this.CHAM_CONG_RO_KO_DC,
            this.CHAM_CONG_KHAC,
            this.HE_SO_K});
            this.advBandedGridView1.GridControl = this.gridControl1;
            this.advBandedGridView1.Name = "advBandedGridView1";
            this.advBandedGridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridBand1
            // 
            this.gridBand1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand1.AppearanceHeader.Options.UseFont = true;
            this.gridBand1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand1.Caption = "Thông tin cơ bản";
            this.gridBand1.Columns.Add(this.STT);
            this.gridBand1.Columns.Add(this.MA_NV);
            this.gridBand1.Columns.Add(this.HO_VA_TEN);
            this.gridBand1.Columns.Add(this.TEN_CHUC_VU);
            this.gridBand1.Columns.Add(this.TEN_HOP_DONG);
            this.gridBand1.Columns.Add(this.LUONG_CHE_DO_THEO_CHUC_VU);
            this.gridBand1.Columns.Add(this.TAI_KHOAN);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 525;
            // 
            // STT
            // 
            this.STT.AppearanceHeader.Options.UseTextOptions = true;
            this.STT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.STT.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.STT.Caption = "STT";
            this.STT.FieldName = "STT";
            this.STT.Name = "STT";
            this.STT.Visible = true;
            this.STT.Width = 30;
            // 
            // MA_NV
            // 
            this.MA_NV.AppearanceHeader.Options.UseTextOptions = true;
            this.MA_NV.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.MA_NV.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.MA_NV.Caption = "Mã nhân viên";
            this.MA_NV.FieldName = "MA_NV";
            this.MA_NV.Name = "MA_NV";
            this.MA_NV.Visible = true;
            // 
            // HO_VA_TEN
            // 
            this.HO_VA_TEN.AppearanceHeader.Options.UseTextOptions = true;
            this.HO_VA_TEN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.HO_VA_TEN.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.HO_VA_TEN.Caption = "Họ và tên";
            this.HO_VA_TEN.FieldName = "HO_VA_TEN";
            this.HO_VA_TEN.Name = "HO_VA_TEN";
            this.HO_VA_TEN.Visible = true;
            this.HO_VA_TEN.Width = 99;
            // 
            // TEN_CHUC_VU
            // 
            this.TEN_CHUC_VU.AppearanceHeader.Options.UseTextOptions = true;
            this.TEN_CHUC_VU.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TEN_CHUC_VU.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.TEN_CHUC_VU.Caption = "Chức vụ";
            this.TEN_CHUC_VU.FieldName = "TEN_CHUC_VU";
            this.TEN_CHUC_VU.Name = "TEN_CHUC_VU";
            this.TEN_CHUC_VU.Visible = true;
            this.TEN_CHUC_VU.Width = 96;
            // 
            // TEN_HOP_DONG
            // 
            this.TEN_HOP_DONG.AppearanceHeader.Options.UseTextOptions = true;
            this.TEN_HOP_DONG.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TEN_HOP_DONG.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.TEN_HOP_DONG.Caption = "Hợp đồng";
            this.TEN_HOP_DONG.FieldName = "HOP_DONG";
            this.TEN_HOP_DONG.Name = "TEN_HOP_DONG";
            this.TEN_HOP_DONG.Visible = true;
            // 
            // LUONG_CHE_DO_THEO_CHUC_VU
            // 
            this.LUONG_CHE_DO_THEO_CHUC_VU.AppearanceHeader.Options.UseTextOptions = true;
            this.LUONG_CHE_DO_THEO_CHUC_VU.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.LUONG_CHE_DO_THEO_CHUC_VU.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.LUONG_CHE_DO_THEO_CHUC_VU.Caption = "Lương chế độ theo chức vụ";
            this.LUONG_CHE_DO_THEO_CHUC_VU.FieldName = "LUONG_CHE_DO_THEO_CHUC_VU";
            this.LUONG_CHE_DO_THEO_CHUC_VU.Name = "LUONG_CHE_DO_THEO_CHUC_VU";
            this.LUONG_CHE_DO_THEO_CHUC_VU.Visible = true;
            // 
            // TAI_KHOAN
            // 
            this.TAI_KHOAN.AppearanceHeader.Options.UseTextOptions = true;
            this.TAI_KHOAN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TAI_KHOAN.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.TAI_KHOAN.Caption = "Tài khoản";
            this.TAI_KHOAN.FieldName = "TAI_KHOAN";
            this.TAI_KHOAN.Name = "TAI_KHOAN";
            this.TAI_KHOAN.Visible = true;
            // 
            // gridBand2
            // 
            this.gridBand2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand2.AppearanceHeader.Options.UseFont = true;
            this.gridBand2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand2.Caption = "Tổng hợp chấm công";
            this.gridBand2.Columns.Add(this.CHAM_CONG_X);
            this.gridBand2.Columns.Add(this.CHAM_CONG_OM_CO);
            this.gridBand2.Columns.Add(this.CHAM_CONG_TS);
            this.gridBand2.Columns.Add(this.CHAM_CONG_TNLD);
            this.gridBand2.Columns.Add(this.CHAM_CONG_PHEP_DIDUONG);
            this.gridBand2.Columns.Add(this.CHAM_CONG_RO_KO_DC);
            this.gridBand2.Columns.Add(this.CHAM_CONG_KHAC);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 285;
            // 
            // CHAM_CONG_X
            // 
            this.CHAM_CONG_X.AppearanceHeader.Options.UseTextOptions = true;
            this.CHAM_CONG_X.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CHAM_CONG_X.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.CHAM_CONG_X.Caption = "X";
            this.CHAM_CONG_X.FieldName = "CHAM_CONG_X";
            this.CHAM_CONG_X.Name = "CHAM_CONG_X";
            this.CHAM_CONG_X.Visible = true;
            this.CHAM_CONG_X.Width = 45;
            // 
            // CHAM_CONG_OM_CO
            // 
            this.CHAM_CONG_OM_CO.AppearanceHeader.Options.UseTextOptions = true;
            this.CHAM_CONG_OM_CO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CHAM_CONG_OM_CO.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.CHAM_CONG_OM_CO.Caption = "Om, Co";
            this.CHAM_CONG_OM_CO.FieldName = "CHAM_CONG_OM_CO";
            this.CHAM_CONG_OM_CO.Name = "CHAM_CONG_OM_CO";
            this.CHAM_CONG_OM_CO.Visible = true;
            this.CHAM_CONG_OM_CO.Width = 39;
            // 
            // CHAM_CONG_TS
            // 
            this.CHAM_CONG_TS.AppearanceHeader.Options.UseTextOptions = true;
            this.CHAM_CONG_TS.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CHAM_CONG_TS.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.CHAM_CONG_TS.Caption = "TS";
            this.CHAM_CONG_TS.FieldName = "CHAM_CONG_TS";
            this.CHAM_CONG_TS.Name = "CHAM_CONG_TS";
            this.CHAM_CONG_TS.Visible = true;
            this.CHAM_CONG_TS.Width = 38;
            // 
            // CHAM_CONG_TNLD
            // 
            this.CHAM_CONG_TNLD.AppearanceHeader.Options.UseTextOptions = true;
            this.CHAM_CONG_TNLD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CHAM_CONG_TNLD.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.CHAM_CONG_TNLD.Caption = "TNLD";
            this.CHAM_CONG_TNLD.FieldName = "CHAM_CONG_TNLD";
            this.CHAM_CONG_TNLD.Name = "CHAM_CONG_TNLD";
            this.CHAM_CONG_TNLD.Visible = true;
            this.CHAM_CONG_TNLD.Width = 36;
            // 
            // CHAM_CONG_PHEP_DIDUONG
            // 
            this.CHAM_CONG_PHEP_DIDUONG.AppearanceHeader.Options.UseTextOptions = true;
            this.CHAM_CONG_PHEP_DIDUONG.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CHAM_CONG_PHEP_DIDUONG.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.CHAM_CONG_PHEP_DIDUONG.Caption = "Phép, đi đường";
            this.CHAM_CONG_PHEP_DIDUONG.FieldName = "CHAM_CONG_PHEP_DIDUONG";
            this.CHAM_CONG_PHEP_DIDUONG.Name = "CHAM_CONG_PHEP_DIDUONG";
            this.CHAM_CONG_PHEP_DIDUONG.Visible = true;
            this.CHAM_CONG_PHEP_DIDUONG.Width = 39;
            // 
            // CHAM_CONG_RO_KO_DC
            // 
            this.CHAM_CONG_RO_KO_DC.AppearanceHeader.Options.UseTextOptions = true;
            this.CHAM_CONG_RO_KO_DC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CHAM_CONG_RO_KO_DC.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.CHAM_CONG_RO_KO_DC.Caption = "RO, KO, DC";
            this.CHAM_CONG_RO_KO_DC.FieldName = "CHAM_CONG_RO_KO_DC";
            this.CHAM_CONG_RO_KO_DC.Name = "CHAM_CONG_RO_KO_DC";
            this.CHAM_CONG_RO_KO_DC.Visible = true;
            this.CHAM_CONG_RO_KO_DC.Width = 37;
            // 
            // CHAM_CONG_KHAC
            // 
            this.CHAM_CONG_KHAC.AppearanceHeader.Options.UseTextOptions = true;
            this.CHAM_CONG_KHAC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CHAM_CONG_KHAC.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.CHAM_CONG_KHAC.Caption = "Khác";
            this.CHAM_CONG_KHAC.FieldName = "CHAM_CONG_KHAC";
            this.CHAM_CONG_KHAC.Name = "CHAM_CONG_KHAC";
            this.CHAM_CONG_KHAC.Visible = true;
            this.CHAM_CONG_KHAC.Width = 51;
            // 
            // gridBand3
            // 
            this.gridBand3.Caption = "gridBand3";
            this.gridBand3.Columns.Add(this.HE_SO_K);
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.OptionsBand.ShowCaption = false;
            this.gridBand3.VisibleIndex = 2;
            this.gridBand3.Width = 75;
            // 
            // HE_SO_K
            // 
            this.HE_SO_K.AppearanceHeader.Options.UseTextOptions = true;
            this.HE_SO_K.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.HE_SO_K.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.HE_SO_K.Caption = "Hệ số K";
            this.HE_SO_K.FieldName = "HE_SO_K";
            this.HE_SO_K.Name = "HE_SO_K";
            this.HE_SO_K.Visible = true;
            // 
            // m_bgwk
            // 
            this.m_bgwk.WorkerReportsProgress = true;
            this.m_bgwk.WorkerSupportsCancellation = true;
            this.m_bgwk.DoWork += new System.ComponentModel.DoWorkEventHandler(this.m_bgwk_DoWork);
            this.m_bgwk.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.m_bgwk_ProgressChanged);
            this.m_bgwk.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.m_bgwk_RunWorkerCompleted);
            // 
            // m_prb
            // 
            this.m_prb.Location = new System.Drawing.Point(148, 185);
            this.m_prb.Name = "m_prb";
            this.m_prb.Properties.DisplayFormat.FormatString = "00";
            this.m_prb.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.m_prb.ShowProgressInTaskBar = true;
            this.m_prb.Size = new System.Drawing.Size(605, 34);
            this.m_prb.TabIndex = 8;
            this.m_prb.Visible = false;
            // 
            // f413_rpt_tong_hop_thong_tin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 485);
            this.Controls.Add(this.m_prb);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Name = "f413_rpt_tong_hop_thong_tin";
            this.Text = "F413 - Báo cáo tổng hợp thông tin ";
            this.Load += new System.EventHandler(this.f413_rpt_tong_hop_thong_tin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_prb.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox m_txt_nam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox m_txt_thang;
        private DevExpress.XtraEditors.SimpleButton m_cmd_luu_bang_luong;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView advBandedGridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn STT;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn MA_NV;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn HO_VA_TEN;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn TEN_CHUC_VU;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn TEN_HOP_DONG;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn LUONG_CHE_DO_THEO_CHUC_VU;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn TAI_KHOAN;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn CHAM_CONG_X;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn CHAM_CONG_OM_CO;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn CHAM_CONG_TS;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn CHAM_CONG_TNLD;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn CHAM_CONG_PHEP_DIDUONG;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn CHAM_CONG_RO_KO_DC;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn CHAM_CONG_KHAC;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn HE_SO_K;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private System.ComponentModel.BackgroundWorker m_bgwk;
        private DevExpress.XtraEditors.ProgressBarControl m_prb;
        private DevExpress.XtraEditors.SimpleButton m_cmd_tinh;
    }
}