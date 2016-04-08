namespace BKI_DichVuMatDat
{
    partial class Template
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
            this.m_cmd_insert = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton6 = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // m_cmd_insert
            // 
            this.m_cmd_insert.Location = new System.Drawing.Point(99, 35);
            this.m_cmd_insert.Name = "m_cmd_insert";
            this.m_cmd_insert.Size = new System.Drawing.Size(75, 27);
            this.m_cmd_insert.TabIndex = 0;
            this.m_cmd_insert.Text = "&Thêm";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(180, 35);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 27);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "&Sửa";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(261, 35);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 27);
            this.simpleButton2.TabIndex = 0;
            this.simpleButton2.Text = "&Xóa";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(99, 83);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(75, 27);
            this.simpleButton3.TabIndex = 0;
            this.simpleButton3.Text = "&Trích xuất";
            // 
            // simpleButton4
            // 
            this.simpleButton4.Location = new System.Drawing.Point(180, 83);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(75, 27);
            this.simpleButton4.TabIndex = 0;
            this.simpleButton4.Text = "&Import";
            // 
            // simpleButton5
            // 
            this.simpleButton5.Location = new System.Drawing.Point(270, 83);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(75, 27);
            this.simpleButton5.TabIndex = 0;
            this.simpleButton5.Text = "&Lọc";
            // 
            // simpleButton6
            // 
            this.simpleButton6.Location = new System.Drawing.Point(99, 130);
            this.simpleButton6.Name = "simpleButton6";
            this.simpleButton6.Size = new System.Drawing.Size(75, 27);
            this.simpleButton6.TabIndex = 0;
            this.simpleButton6.Text = "&Tải Template";
            // 
            // Template
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 397);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.simpleButton5);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.simpleButton6);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.m_cmd_insert);
            this.Name = "Template";
            this.Text = "Template";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton m_cmd_insert;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.SimpleButton simpleButton6;
    }
}