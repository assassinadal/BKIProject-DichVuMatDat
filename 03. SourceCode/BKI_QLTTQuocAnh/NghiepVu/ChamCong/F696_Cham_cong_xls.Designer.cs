namespace BKI_DichVuMatDat.NghiepVu
{
    partial class F696_Cham_cong_xls
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F696_Cham_cong_xls));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.m_cmd_nhap_cham_cong = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.m_pn = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.m_prb = new DevExpress.XtraEditors.ProgressBarControl();
            this.m_grc = new DevExpress.XtraGrid.GridControl();
            this.m_grv = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.m_bgwk = new System.ComponentModel.BackgroundWorker();
            this.panel7 = new System.Windows.Forms.Panel();
            this.m_cmd_chon_du_lieu = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_mo_file_mau = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.m_txt_nam = new DevExpress.XtraEditors.TextEdit();
            this.m_txt_thang = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.m_lbl_thong_bao = new DevExpress.XtraEditors.LabelControl();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.m_pn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_prb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_txt_nam.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_txt_thang.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 384);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(878, 52);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.m_cmd_nhap_cham_cong);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(678, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(5);
            this.panel3.Size = new System.Drawing.Size(200, 52);
            this.panel3.TabIndex = 0;
            // 
            // m_cmd_nhap_cham_cong
            // 
            this.m_cmd_nhap_cham_cong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_cmd_nhap_cham_cong.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_nhap_cham_cong.Image")));
            this.m_cmd_nhap_cham_cong.Location = new System.Drawing.Point(5, 5);
            this.m_cmd_nhap_cham_cong.Name = "m_cmd_nhap_cham_cong";
            this.m_cmd_nhap_cham_cong.Size = new System.Drawing.Size(190, 42);
            this.m_cmd_nhap_cham_cong.TabIndex = 0;
            this.m_cmd_nhap_cham_cong.Text = "Lưu chấm công";
            this.m_cmd_nhap_cham_cong.Click += new System.EventHandler(this.m_cmd_nhap_cham_cong_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.m_pn);
            this.panel2.Controls.Add(this.m_grc);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(878, 291);
            this.panel2.TabIndex = 1;
            // 
            // m_pn
            // 
            this.m_pn.Controls.Add(this.label1);
            this.m_pn.Controls.Add(this.m_prb);
            this.m_pn.Location = new System.Drawing.Point(73, 85);
            this.m_pn.Name = "m_pn";
            this.m_pn.Padding = new System.Windows.Forms.Padding(10);
            this.m_pn.Size = new System.Drawing.Size(618, 68);
            this.m_pn.TabIndex = 3;
            this.m_pn.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Đang lưu dữ liệu. Vui lòng chờ trong giây lát...";
            // 
            // m_prb
            // 
            this.m_prb.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_prb.Location = new System.Drawing.Point(10, 10);
            this.m_prb.Name = "m_prb";
            this.m_prb.Properties.DisplayFormat.FormatString = "00";
            this.m_prb.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.m_prb.ShowProgressInTaskBar = true;
            this.m_prb.Size = new System.Drawing.Size(598, 30);
            this.m_prb.TabIndex = 2;
            this.m_prb.Visible = false;
            // 
            // m_grc
            // 
            this.m_grc.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc.Location = new System.Drawing.Point(0, 0);
            this.m_grc.MainView = this.m_grv;
            this.m_grc.Name = "m_grc";
            this.m_grc.Size = new System.Drawing.Size(878, 291);
            this.m_grc.TabIndex = 0;
            this.m_grc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv});
            // 
            // m_grv
            // 
            this.m_grv.GridControl = this.m_grc;
            this.m_grv.Name = "m_grv";
            this.m_grv.OptionsBehavior.Editable = false;
            this.m_grv.OptionsFind.AllowFindPanel = false;
            this.m_grv.OptionsFind.AlwaysVisible = true;
            this.m_grv.OptionsView.ColumnAutoWidth = false;
            this.m_grv.OptionsView.ShowFooter = true;
            // 
            // m_bgwk
            // 
            this.m_bgwk.WorkerReportsProgress = true;
            this.m_bgwk.WorkerSupportsCancellation = true;
            this.m_bgwk.DoWork += new System.ComponentModel.DoWorkEventHandler(this.m_bgwk_DoWork);
            this.m_bgwk.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.m_bgwk_ProgressChanged);
            this.m_bgwk.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.m_bgwk_RunWorkerCompleted);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.m_cmd_chon_du_lieu);
            this.panel7.Controls.Add(this.m_cmd_mo_file_mau);
            this.panel7.Controls.Add(this.panelControl1);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(878, 93);
            this.panel7.TabIndex = 3;
            // 
            // m_cmd_chon_du_lieu
            // 
            this.m_cmd_chon_du_lieu.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_chon_du_lieu.Image")));
            this.m_cmd_chon_du_lieu.Location = new System.Drawing.Point(510, 21);
            this.m_cmd_chon_du_lieu.Name = "m_cmd_chon_du_lieu";
            this.m_cmd_chon_du_lieu.Size = new System.Drawing.Size(190, 36);
            this.m_cmd_chon_du_lieu.TabIndex = 3;
            this.m_cmd_chon_du_lieu.Text = "Chọn dữ liệu chấm công";
            this.m_cmd_chon_du_lieu.Click += new System.EventHandler(this.m_cmd_chon_du_lieu_Click);
            // 
            // m_cmd_mo_file_mau
            // 
            this.m_cmd_mo_file_mau.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_mo_file_mau.Image")));
            this.m_cmd_mo_file_mau.Location = new System.Drawing.Point(297, 21);
            this.m_cmd_mo_file_mau.Name = "m_cmd_mo_file_mau";
            this.m_cmd_mo_file_mau.Size = new System.Drawing.Size(190, 36);
            this.m_cmd_mo_file_mau.TabIndex = 2;
            this.m_cmd_mo_file_mau.Text = "Mở file mẫu";
            this.m_cmd_mo_file_mau.Click += new System.EventHandler(this.m_cmd_mo_file_mau_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.m_txt_nam);
            this.panelControl1.Controls.Add(this.m_txt_thang);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.m_lbl_thong_bao);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(280, 93);
            this.panelControl1.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(28, 85);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(0, 13);
            this.labelControl2.TabIndex = 19;
            // 
            // m_txt_nam
            // 
            this.m_txt_nam.Location = new System.Drawing.Point(127, 24);
            this.m_txt_nam.Name = "m_txt_nam";
            this.m_txt_nam.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.m_txt_nam.Properties.Appearance.Options.UseFont = true;
            this.m_txt_nam.Properties.Appearance.Options.UseTextOptions = true;
            this.m_txt_nam.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.m_txt_nam.Properties.AutoHeight = false;
            this.m_txt_nam.Properties.Mask.EditMask = "d";
            this.m_txt_nam.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.m_txt_nam.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.m_txt_nam.Properties.NullText = "Nhập năm";
            this.m_txt_nam.Properties.NullValuePrompt = "Nhập năm";
            this.m_txt_nam.Size = new System.Drawing.Size(100, 29);
            this.m_txt_nam.TabIndex = 1;
            // 
            // m_txt_thang
            // 
            this.m_txt_thang.Location = new System.Drawing.Point(26, 24);
            this.m_txt_thang.Name = "m_txt_thang";
            this.m_txt_thang.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.m_txt_thang.Properties.Appearance.Options.UseFont = true;
            this.m_txt_thang.Properties.Appearance.Options.UseTextOptions = true;
            this.m_txt_thang.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.m_txt_thang.Properties.AutoHeight = false;
            this.m_txt_thang.Properties.Mask.EditMask = "d";
            this.m_txt_thang.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.m_txt_thang.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.m_txt_thang.Properties.NullText = "Nhập tháng";
            this.m_txt_thang.Properties.NullValuePrompt = "Nhập tháng";
            this.m_txt_thang.Size = new System.Drawing.Size(84, 29);
            this.m_txt_thang.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 16F);
            this.labelControl1.Location = new System.Drawing.Point(114, 25);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(8, 25);
            this.labelControl1.TabIndex = 18;
            this.labelControl1.Text = "/";
            // 
            // m_lbl_thong_bao
            // 
            this.m_lbl_thong_bao.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_thong_bao.Location = new System.Drawing.Point(27, 64);
            this.m_lbl_thong_bao.Name = "m_lbl_thong_bao";
            this.m_lbl_thong_bao.Size = new System.Drawing.Size(0, 13);
            this.m_lbl_thong_bao.TabIndex = 3;
            // 
            // F696_Cham_cong_xls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 436);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel7);
            this.Name = "F696_Cham_cong_xls";
            this.Text = "F696 Chấm công từ excel";
            this.Load += new System.EventHandler(this.F696_Cham_cong_xls_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.m_pn.ResumeLayout(false);
            this.m_pn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_prb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv)).EndInit();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_txt_nam.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_txt_thang.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl m_grc;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.SimpleButton m_cmd_nhap_cham_cong;
        private System.ComponentModel.BackgroundWorker m_bgwk;
        private System.Windows.Forms.Panel m_pn;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.ProgressBarControl m_prb;
        private System.Windows.Forms.Panel panel7;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit m_txt_nam;
        private DevExpress.XtraEditors.TextEdit m_txt_thang;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl m_lbl_thong_bao;
        private DevExpress.XtraEditors.SimpleButton m_cmd_chon_du_lieu;
        private DevExpress.XtraEditors.SimpleButton m_cmd_mo_file_mau;
    }
}