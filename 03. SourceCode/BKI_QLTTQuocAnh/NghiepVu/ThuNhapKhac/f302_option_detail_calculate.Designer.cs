namespace BKI_DichVuMatDat.NghiepVu.ThuNhapKhac
{
    partial class f302_option_detail_calculate
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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.m_cmd_continue = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_exit = new DevExpress.XtraEditors.SimpleButton();
            this.m_txt_tong_tien = new DevExpress.XtraEditors.TextEdit();
            this.m_lbl_tong_tien = new DevExpress.XtraEditors.LabelControl();
            this.m_lbl_don_gia = new DevExpress.XtraEditors.LabelControl();
            this.m_txt_don_gia = new DevExpress.XtraEditors.TextEdit();
            this.m_txt_thue_tong_tien = new DevExpress.XtraEditors.TextEdit();
            this.m_lbl_thue_tong_tien = new DevExpress.XtraEditors.LabelControl();
            this.m_txt_thue_don_gia = new DevExpress.XtraEditors.TextEdit();
            this.m_lbl_thue_don_gia = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_txt_tong_tien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_txt_don_gia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_txt_thue_tong_tien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_txt_thue_don_gia.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(34, 14);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(275, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Lấy Tổng tiền quỹ/tổng hệ số * hệ số từng nhân viên";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(34, 106);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(191, 17);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Lấy hệ số từng nhân viên * đơn giá";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(34, 204);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(288, 17);
            this.radioButton3.TabIndex = 11;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Không tính bằng hệ số (Tự nhập tay/import bằng excel)";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.m_cmd_continue);
            this.panelControl1.Controls.Add(this.m_cmd_exit);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 242);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(420, 39);
            this.panelControl1.TabIndex = 10;
            // 
            // m_cmd_continue
            // 
            this.m_cmd_continue.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_continue.ImageIndex = 7;
            this.m_cmd_continue.Location = new System.Drawing.Point(212, 2);
            this.m_cmd_continue.Name = "m_cmd_continue";
            this.m_cmd_continue.Size = new System.Drawing.Size(103, 35);
            this.m_cmd_continue.TabIndex = 0;
            this.m_cmd_continue.Text = "Tiếp tục";
            this.m_cmd_continue.Click += new System.EventHandler(this.m_cmd_continue_Click);
            // 
            // m_cmd_exit
            // 
            this.m_cmd_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_exit.ImageIndex = 7;
            this.m_cmd_exit.Location = new System.Drawing.Point(315, 2);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(103, 35);
            this.m_cmd_exit.TabIndex = 1;
            this.m_cmd_exit.Text = "Thoát";
            this.m_cmd_exit.Click += new System.EventHandler(this.m_cmd_exit_Click);
            // 
            // m_txt_tong_tien
            // 
            this.m_txt_tong_tien.Location = new System.Drawing.Point(151, 32);
            this.m_txt_tong_tien.Name = "m_txt_tong_tien";
            this.m_txt_tong_tien.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.m_txt_tong_tien.Properties.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.m_txt_tong_tien.Properties.Appearance.Options.UseFont = true;
            this.m_txt_tong_tien.Properties.Appearance.Options.UseForeColor = true;
            this.m_txt_tong_tien.Properties.DisplayFormat.FormatString = "n0";
            this.m_txt_tong_tien.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.m_txt_tong_tien.Properties.EditFormat.FormatString = "n0";
            this.m_txt_tong_tien.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.m_txt_tong_tien.Properties.Mask.EditMask = "n0";
            this.m_txt_tong_tien.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.m_txt_tong_tien.Size = new System.Drawing.Size(219, 26);
            this.m_txt_tong_tien.TabIndex = 1;
            // 
            // m_lbl_tong_tien
            // 
            this.m_lbl_tong_tien.Location = new System.Drawing.Point(70, 40);
            this.m_lbl_tong_tien.Name = "m_lbl_tong_tien";
            this.m_lbl_tong_tien.Size = new System.Drawing.Size(45, 13);
            this.m_lbl_tong_tien.TabIndex = 4;
            this.m_lbl_tong_tien.Text = "Tổng tiền";
            // 
            // m_lbl_don_gia
            // 
            this.m_lbl_don_gia.Location = new System.Drawing.Point(70, 137);
            this.m_lbl_don_gia.Name = "m_lbl_don_gia";
            this.m_lbl_don_gia.Size = new System.Drawing.Size(37, 13);
            this.m_lbl_don_gia.TabIndex = 3;
            this.m_lbl_don_gia.Text = "Đơn giá";
            // 
            // m_txt_don_gia
            // 
            this.m_txt_don_gia.Location = new System.Drawing.Point(151, 129);
            this.m_txt_don_gia.Name = "m_txt_don_gia";
            this.m_txt_don_gia.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.m_txt_don_gia.Properties.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.m_txt_don_gia.Properties.Appearance.Options.UseFont = true;
            this.m_txt_don_gia.Properties.Appearance.Options.UseForeColor = true;
            this.m_txt_don_gia.Properties.DisplayFormat.FormatString = "n0";
            this.m_txt_don_gia.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.m_txt_don_gia.Properties.EditFormat.FormatString = "n0";
            this.m_txt_don_gia.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.m_txt_don_gia.Properties.Mask.EditMask = "n0";
            this.m_txt_don_gia.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.m_txt_don_gia.Size = new System.Drawing.Size(219, 26);
            this.m_txt_don_gia.TabIndex = 1;
            // 
            // m_txt_thue_tong_tien
            // 
            this.m_txt_thue_tong_tien.Location = new System.Drawing.Point(151, 69);
            this.m_txt_thue_tong_tien.Name = "m_txt_thue_tong_tien";
            this.m_txt_thue_tong_tien.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.m_txt_thue_tong_tien.Properties.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.m_txt_thue_tong_tien.Properties.Appearance.Options.UseFont = true;
            this.m_txt_thue_tong_tien.Properties.Appearance.Options.UseForeColor = true;
            this.m_txt_thue_tong_tien.Properties.DisplayFormat.FormatString = "n0";
            this.m_txt_thue_tong_tien.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.m_txt_thue_tong_tien.Properties.EditFormat.FormatString = "n0";
            this.m_txt_thue_tong_tien.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.m_txt_thue_tong_tien.Properties.Mask.EditMask = "n0";
            this.m_txt_thue_tong_tien.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.m_txt_thue_tong_tien.Size = new System.Drawing.Size(219, 26);
            this.m_txt_thue_tong_tien.TabIndex = 2;
            // 
            // m_lbl_thue_tong_tien
            // 
            this.m_lbl_thue_tong_tien.Location = new System.Drawing.Point(70, 77);
            this.m_lbl_thue_tong_tien.Name = "m_lbl_thue_tong_tien";
            this.m_lbl_thue_tong_tien.Size = new System.Drawing.Size(74, 13);
            this.m_lbl_thue_tong_tien.TabIndex = 3;
            this.m_lbl_thue_tong_tien.Text = "Phấn trăm thuế";
            // 
            // m_txt_thue_don_gia
            // 
            this.m_txt_thue_don_gia.Location = new System.Drawing.Point(151, 161);
            this.m_txt_thue_don_gia.Name = "m_txt_thue_don_gia";
            this.m_txt_thue_don_gia.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.m_txt_thue_don_gia.Properties.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.m_txt_thue_don_gia.Properties.Appearance.Options.UseFont = true;
            this.m_txt_thue_don_gia.Properties.Appearance.Options.UseForeColor = true;
            this.m_txt_thue_don_gia.Properties.DisplayFormat.FormatString = "n0";
            this.m_txt_thue_don_gia.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.m_txt_thue_don_gia.Properties.EditFormat.FormatString = "n0";
            this.m_txt_thue_don_gia.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.m_txt_thue_don_gia.Size = new System.Drawing.Size(219, 26);
            this.m_txt_thue_don_gia.TabIndex = 2;
            // 
            // m_lbl_thue_don_gia
            // 
            this.m_lbl_thue_don_gia.Location = new System.Drawing.Point(70, 169);
            this.m_lbl_thue_don_gia.Name = "m_lbl_thue_don_gia";
            this.m_lbl_thue_don_gia.Size = new System.Drawing.Size(74, 13);
            this.m_lbl_thue_don_gia.TabIndex = 3;
            this.m_lbl_thue_don_gia.Text = "Phấn trăm thuế";
            // 
            // f301_option_detail_calculate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 281);
            this.Controls.Add(this.m_lbl_don_gia);
            this.Controls.Add(this.m_lbl_thue_don_gia);
            this.Controls.Add(this.m_lbl_thue_tong_tien);
            this.Controls.Add(this.m_lbl_tong_tien);
            this.Controls.Add(this.m_txt_don_gia);
            this.Controls.Add(this.m_txt_thue_don_gia);
            this.Controls.Add(this.m_txt_thue_tong_tien);
            this.Controls.Add(this.m_txt_tong_tien);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Name = "f301_option_detail_calculate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F301 - Chọn cách tính thu nhập khác";
            this.Load += new System.EventHandler(this.f301_option_detail_calculate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_txt_tong_tien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_txt_don_gia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_txt_thue_tong_tien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_txt_thue_don_gia.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton m_cmd_continue;
        private DevExpress.XtraEditors.SimpleButton m_cmd_exit;
        private DevExpress.XtraEditors.TextEdit m_txt_tong_tien;
        private DevExpress.XtraEditors.LabelControl m_lbl_tong_tien;
        private DevExpress.XtraEditors.LabelControl m_lbl_don_gia;
        private DevExpress.XtraEditors.TextEdit m_txt_don_gia;
        private DevExpress.XtraEditors.TextEdit m_txt_thue_tong_tien;
        private DevExpress.XtraEditors.LabelControl m_lbl_thue_tong_tien;
        private DevExpress.XtraEditors.TextEdit m_txt_thue_don_gia;
        private DevExpress.XtraEditors.LabelControl m_lbl_thue_don_gia;
    }
}