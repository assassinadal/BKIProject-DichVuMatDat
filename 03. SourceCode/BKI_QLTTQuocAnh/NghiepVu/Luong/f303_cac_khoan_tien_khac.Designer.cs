namespace BKI_DichVuMatDat.NghiepVu.Luong
{
    partial class f303_cac_khoan_tien_khac
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.m_dat_time = new DevExpress.XtraEditors.DateEdit();
            this.m_cmb_khoan_tien = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_time.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_time.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(9, 20);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(30, 13);
            this.labelControl1.TabIndex = 27;
            this.labelControl1.Text = "Tháng";
            // 
            // m_dat_time
            // 
            this.m_dat_time.EditValue = null;
            this.m_dat_time.Location = new System.Drawing.Point(70, 12);
            this.m_dat_time.Name = "m_dat_time";
            this.m_dat_time.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.m_dat_time.Properties.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.m_dat_time.Properties.Appearance.Options.UseFont = true;
            this.m_dat_time.Properties.Appearance.Options.UseForeColor = true;
            this.m_dat_time.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.m_dat_time.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.m_dat_time.Properties.DisplayFormat.FormatString = "MM/yyyy";
            this.m_dat_time.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.m_dat_time.Properties.EditFormat.FormatString = "MM/yyyy";
            this.m_dat_time.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.m_dat_time.Properties.Mask.EditMask = "MM/yyyy";
            this.m_dat_time.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.m_dat_time.Size = new System.Drawing.Size(141, 26);
            this.m_dat_time.TabIndex = 26;
            // 
            // m_cmb_khoan_tien
            // 
            this.m_cmb_khoan_tien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_cmb_khoan_tien.FormattingEnabled = true;
            this.m_cmb_khoan_tien.Location = new System.Drawing.Point(70, 44);
            this.m_cmb_khoan_tien.Name = "m_cmb_khoan_tien";
            this.m_cmb_khoan_tien.Size = new System.Drawing.Size(310, 21);
            this.m_cmb_khoan_tien.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Khoản tiền";
            // 
            // f303_cac_khoan_tien_khac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 365);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.m_dat_time);
            this.Controls.Add(this.m_cmb_khoan_tien);
            this.Controls.Add(this.label5);
            this.Name = "f303_cac_khoan_tien_khac";
            this.Text = "F303 - Dữ liệu Các khoản tiền khác";
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_time.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_time.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit m_dat_time;
        private System.Windows.Forms.ComboBox m_cmb_khoan_tien;
        private System.Windows.Forms.Label label5;

    }
}