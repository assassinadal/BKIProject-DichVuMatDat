namespace BKI_DichVuMatDat.CONFIRM
{
    partial class msg001_confirm_tinh_bang_luong
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.m_cmd_confirm = new DevExpress.XtraEditors.SimpleButton();
            this.radioGroup = new DevExpress.XtraEditors.RadioGroup();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.m_cmd_confirm);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 160);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(393, 39);
            this.panelControl1.TabIndex = 1;
            // 
            // m_cmd_confirm
            // 
            this.m_cmd_confirm.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_confirm.Location = new System.Drawing.Point(290, 2);
            this.m_cmd_confirm.Name = "m_cmd_confirm";
            this.m_cmd_confirm.Size = new System.Drawing.Size(101, 35);
            this.m_cmd_confirm.TabIndex = 0;
            this.m_cmd_confirm.Text = "Xác nhận";
            this.m_cmd_confirm.Click += new System.EventHandler(this.m_cmd_confirm_Click);
            // 
            // radioGroup
            // 
            this.radioGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioGroup.Location = new System.Drawing.Point(0, 0);
            this.radioGroup.Name = "radioGroup";
            this.radioGroup.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.radioGroup.Properties.Appearance.Options.UseBackColor = true;
            this.radioGroup.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.radioGroup.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(1)), "Tính dữ liệu lương tất cả nhân viên"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(2)), "Tính dữ liệu lương các nhân viên chưa có trong bảng lương phần mềm")});
            this.radioGroup.Size = new System.Drawing.Size(393, 160);
            this.radioGroup.TabIndex = 3;
            // 
            // msg001_confirm_tinh_bang_luong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 199);
            this.Controls.Add(this.radioGroup);
            this.Controls.Add(this.panelControl1);
            this.Name = "msg001_confirm_tinh_bang_luong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Msg001 - Xác nhận cách tính bảng lương";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton m_cmd_confirm;
        private DevExpress.XtraEditors.RadioGroup radioGroup;
    }
}