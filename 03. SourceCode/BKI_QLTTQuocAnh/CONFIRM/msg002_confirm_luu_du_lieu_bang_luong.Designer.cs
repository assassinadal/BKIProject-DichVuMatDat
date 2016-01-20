namespace BKI_DichVuMatDat.CONFIRM
{
    partial class msg002_confirm_luu_du_lieu_bang_luong
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
            this.label1 = new System.Windows.Forms.Label();
            this.m_rdb_luu_lai_toan_bo = new System.Windows.Forms.RadioButton();
            this.m_rdb_xu_ly_du_lieu = new System.Windows.Forms.RadioButton();
            this.m_chk_0_ghi_de = new DevExpress.XtraEditors.CheckEdit();
            this.m_lbl_option_detail1 = new DevExpress.XtraEditors.LabelControl();
            this.m_lbl_option_detail2 = new DevExpress.XtraEditors.LabelControl();
            this.m_chk_1_ghi_moi = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_chk_0_ghi_de.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_chk_1_ghi_moi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.m_cmd_confirm);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 208);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(400, 39);
            this.panelControl1.TabIndex = 2;
            // 
            // m_cmd_confirm
            // 
            this.m_cmd_confirm.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_confirm.Location = new System.Drawing.Point(297, 2);
            this.m_cmd_confirm.Name = "m_cmd_confirm";
            this.m_cmd_confirm.Size = new System.Drawing.Size(101, 35);
            this.m_cmd_confirm.TabIndex = 0;
            this.m_cmd_confirm.Text = "Xác nhận";
            this.m_cmd_confirm.Click += new System.EventHandler(this.m_cmd_confirm_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 62);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bảng lương trong phần mềm đã có dữ liệu. Bạn chọn cách lưu bảng lương " +
    "vào phần mềm nhé!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // m_rdb_luu_lai_toan_bo
            // 
            this.m_rdb_luu_lai_toan_bo.AutoSize = true;
            this.m_rdb_luu_lai_toan_bo.Location = new System.Drawing.Point(12, 65);
            this.m_rdb_luu_lai_toan_bo.Name = "m_rdb_luu_lai_toan_bo";
            this.m_rdb_luu_lai_toan_bo.Size = new System.Drawing.Size(268, 17);
            this.m_rdb_luu_lai_toan_bo.TabIndex = 6;
            this.m_rdb_luu_lai_toan_bo.TabStop = true;
            this.m_rdb_luu_lai_toan_bo.Text = "Lưu lại toàn bộ, xóa bảng lương cũ trong phần mềm";
            this.m_rdb_luu_lai_toan_bo.UseVisualStyleBackColor = true;
            this.m_rdb_luu_lai_toan_bo.CheckedChanged += new System.EventHandler(this.m_rdb_luu_lai_toan_bo_CheckedChanged);
            this.m_rdb_luu_lai_toan_bo.Click += new System.EventHandler(this.m_rdb_luu_lai_toan_bo_Click);
            // 
            // m_rdb_xu_ly_du_lieu
            // 
            this.m_rdb_xu_ly_du_lieu.AutoSize = true;
            this.m_rdb_xu_ly_du_lieu.Location = new System.Drawing.Point(12, 88);
            this.m_rdb_xu_ly_du_lieu.Name = "m_rdb_xu_ly_du_lieu";
            this.m_rdb_xu_ly_du_lieu.Size = new System.Drawing.Size(82, 17);
            this.m_rdb_xu_ly_du_lieu.TabIndex = 6;
            this.m_rdb_xu_ly_du_lieu.TabStop = true;
            this.m_rdb_xu_ly_du_lieu.Text = "Xử lý dữ liệu";
            this.m_rdb_xu_ly_du_lieu.UseVisualStyleBackColor = true;
            this.m_rdb_xu_ly_du_lieu.CheckedChanged += new System.EventHandler(this.m_rdb_xu_ly_du_lieu_CheckedChanged);
            this.m_rdb_xu_ly_du_lieu.Click += new System.EventHandler(this.m_rdb_xu_ly_du_lieu_Click);
            // 
            // m_chk_0_ghi_de
            // 
            this.m_chk_0_ghi_de.Location = new System.Drawing.Point(66, 174);
            this.m_chk_0_ghi_de.Name = "m_chk_0_ghi_de";
            this.m_chk_0_ghi_de.Properties.Caption = "Ghi đè lên lương cũ";
            this.m_chk_0_ghi_de.Size = new System.Drawing.Size(116, 19);
            this.m_chk_0_ghi_de.TabIndex = 7;
            this.m_chk_0_ghi_de.CheckedChanged += new System.EventHandler(this.m_chk_0_ghi_de_CheckedChanged);
            // 
            // m_lbl_option_detail1
            // 
            this.m_lbl_option_detail1.Location = new System.Drawing.Point(51, 111);
            this.m_lbl_option_detail1.Name = "m_lbl_option_detail1";
            this.m_lbl_option_detail1.Size = new System.Drawing.Size(175, 13);
            this.m_lbl_option_detail1.TabIndex = 8;
            this.m_lbl_option_detail1.Text = "Nhân viên chưa có trong bảng lương";
            // 
            // m_lbl_option_detail2
            // 
            this.m_lbl_option_detail2.Location = new System.Drawing.Point(51, 155);
            this.m_lbl_option_detail2.Name = "m_lbl_option_detail2";
            this.m_lbl_option_detail2.Size = new System.Drawing.Size(163, 13);
            this.m_lbl_option_detail2.TabIndex = 8;
            this.m_lbl_option_detail2.Text = "Nhân viên đã có trong bảng lương";
            // 
            // m_chk_1_ghi_moi
            // 
            this.m_chk_1_ghi_moi.Location = new System.Drawing.Point(66, 130);
            this.m_chk_1_ghi_moi.Name = "m_chk_1_ghi_moi";
            this.m_chk_1_ghi_moi.Properties.Caption = "Ghi mới lương";
            this.m_chk_1_ghi_moi.Size = new System.Drawing.Size(90, 19);
            this.m_chk_1_ghi_moi.TabIndex = 7;
            this.m_chk_1_ghi_moi.CheckedChanged += new System.EventHandler(this.m_chk_1_ghi_moi_CheckedChanged);
            // 
            // msg002_confirm_luu_du_lieu_bang_luong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 247);
            this.Controls.Add(this.m_lbl_option_detail2);
            this.Controls.Add(this.m_lbl_option_detail1);
            this.Controls.Add(this.m_chk_1_ghi_moi);
            this.Controls.Add(this.m_chk_0_ghi_de);
            this.Controls.Add(this.m_rdb_xu_ly_du_lieu);
            this.Controls.Add(this.m_rdb_luu_lai_toan_bo);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.label1);
            this.Name = "msg002_confirm_luu_du_lieu_bang_luong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Msg002 - Xác nhận lưu bảng lương";
            this.Load += new System.EventHandler(this.msg002_confirm_luu_du_lieu_bang_luong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_chk_0_ghi_de.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_chk_1_ghi_moi.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton m_cmd_confirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton m_rdb_luu_lai_toan_bo;
        private System.Windows.Forms.RadioButton m_rdb_xu_ly_du_lieu;
        private DevExpress.XtraEditors.CheckEdit m_chk_0_ghi_de;
        private DevExpress.XtraEditors.LabelControl m_lbl_option_detail1;
        private DevExpress.XtraEditors.LabelControl m_lbl_option_detail2;
        private DevExpress.XtraEditors.CheckEdit m_chk_1_ghi_moi;

    }
}