namespace BKI_DichVuMatDat.NghiepVu
{
    partial class F500_QUY_TRINH_THEM_MOI_NHAN_SU
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
            this.m_cmd_nhap_thong_tin_nhan_vien = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_lap_hop_dong = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_nhap_loai_lao_dong = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_nhap_quyet_dinh = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_cmd_nhap_thong_tin_nhan_vien
            // 
            this.m_cmd_nhap_thong_tin_nhan_vien.Location = new System.Drawing.Point(22, 74);
            this.m_cmd_nhap_thong_tin_nhan_vien.Name = "m_cmd_nhap_thong_tin_nhan_vien";
            this.m_cmd_nhap_thong_tin_nhan_vien.Size = new System.Drawing.Size(424, 23);
            this.m_cmd_nhap_thong_tin_nhan_vien.TabIndex = 0;
            this.m_cmd_nhap_thong_tin_nhan_vien.Text = "Bước 1: Nhập thông tin nhân viên";
            this.m_cmd_nhap_thong_tin_nhan_vien.Click += new System.EventHandler(this.m_cmd_nhap_thong_tin_nhan_vien_Click);
            // 
            // m_cmd_lap_hop_dong
            // 
            this.m_cmd_lap_hop_dong.Location = new System.Drawing.Point(22, 208);
            this.m_cmd_lap_hop_dong.Name = "m_cmd_lap_hop_dong";
            this.m_cmd_lap_hop_dong.Size = new System.Drawing.Size(424, 23);
            this.m_cmd_lap_hop_dong.TabIndex = 0;
            this.m_cmd_lap_hop_dong.Text = "Bước 3: Lập hợp đồng";
            // 
            // m_cmd_nhap_loai_lao_dong
            // 
            this.m_cmd_nhap_loai_lao_dong.Location = new System.Drawing.Point(22, 138);
            this.m_cmd_nhap_loai_lao_dong.Name = "m_cmd_nhap_loai_lao_dong";
            this.m_cmd_nhap_loai_lao_dong.Size = new System.Drawing.Size(424, 23);
            this.m_cmd_nhap_loai_lao_dong.TabIndex = 0;
            this.m_cmd_nhap_loai_lao_dong.Text = "Bước 2: Nhập loại lao động, số lượng phụ thuộc, không đóng bảo hiểm";
            this.m_cmd_nhap_loai_lao_dong.Click += new System.EventHandler(this.m_cmd_nhap_loai_lao_dong_Click);
            // 
            // m_cmd_nhap_quyet_dinh
            // 
            this.m_cmd_nhap_quyet_dinh.Location = new System.Drawing.Point(22, 290);
            this.m_cmd_nhap_quyet_dinh.Name = "m_cmd_nhap_quyet_dinh";
            this.m_cmd_nhap_quyet_dinh.Size = new System.Drawing.Size(424, 23);
            this.m_cmd_nhap_quyet_dinh.TabIndex = 0;
            this.m_cmd_nhap_quyet_dinh.Text = "Bước 4: Nhập quyết định, công tác";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(707, 56);
            this.panelControl1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(655, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "THỰC HIỆN THEO CÁC BƯỚC DƯỚI ĐÂY ĐỂ THÊM MỚI 1 NHÂN SỰ\r\n";
            // 
            // F500_QUY_TRINH_THEM_MOI_NHAN_SU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 382);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.m_cmd_nhap_loai_lao_dong);
            this.Controls.Add(this.m_cmd_nhap_quyet_dinh);
            this.Controls.Add(this.m_cmd_lap_hop_dong);
            this.Controls.Add(this.m_cmd_nhap_thong_tin_nhan_vien);
            this.Name = "F500_QUY_TRINH_THEM_MOI_NHAN_SU";
            this.Text = "F500_QUY_TRINH_THEM_MOI_NHAN_SU";
            this.Load += new System.EventHandler(this.F500_QUY_TRINH_THEM_MOI_NHAN_SU_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton m_cmd_nhap_thong_tin_nhan_vien;
        private DevExpress.XtraEditors.SimpleButton m_cmd_lap_hop_dong;
        private DevExpress.XtraEditors.SimpleButton m_cmd_nhap_loai_lao_dong;
        private DevExpress.XtraEditors.SimpleButton m_cmd_nhap_quyet_dinh;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label label1;
    }
}