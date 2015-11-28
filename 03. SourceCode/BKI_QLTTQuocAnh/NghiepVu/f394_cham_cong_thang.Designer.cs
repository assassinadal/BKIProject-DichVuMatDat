namespace BKI_DichVuMatDat.NghiepVu
{
    partial class f394_cham_cong_thang
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.m_cmd_loc = new DevExpress.XtraEditors.SimpleButton();
            this.m_txt_nam = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.m_txt_thang = new DevExpress.XtraEditors.TextEdit();
            this.m_lbl_thang = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.m_grc = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_txt_nam.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_txt_thang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.m_cmd_loc);
            this.panelControl1.Controls.Add(this.m_txt_nam);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.m_txt_thang);
            this.panelControl1.Controls.Add(this.m_lbl_thang);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(736, 83);
            this.panelControl1.TabIndex = 0;
            // 
            // m_cmd_loc
            // 
            this.m_cmd_loc.Image = global::BKI_DichVuMatDat.Properties.Resources.find;
            this.m_cmd_loc.Location = new System.Drawing.Point(418, 23);
            this.m_cmd_loc.Name = "m_cmd_loc";
            this.m_cmd_loc.Size = new System.Drawing.Size(75, 23);
            this.m_cmd_loc.TabIndex = 4;
            this.m_cmd_loc.Text = "Lọc";
            this.m_cmd_loc.Click += new System.EventHandler(this.m_cmd_loc_Click);
            // 
            // m_txt_nam
            // 
            this.m_txt_nam.Location = new System.Drawing.Point(276, 25);
            this.m_txt_nam.Name = "m_txt_nam";
            this.m_txt_nam.Size = new System.Drawing.Size(100, 20);
            this.m_txt_nam.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(239, 28);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(21, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Năm";
            // 
            // m_txt_thang
            // 
            this.m_txt_thang.Location = new System.Drawing.Point(86, 25);
            this.m_txt_thang.Name = "m_txt_thang";
            this.m_txt_thang.Size = new System.Drawing.Size(100, 20);
            this.m_txt_thang.TabIndex = 1;
            // 
            // m_lbl_thang
            // 
            this.m_lbl_thang.Location = new System.Drawing.Point(33, 28);
            this.m_lbl_thang.Name = "m_lbl_thang";
            this.m_lbl_thang.Size = new System.Drawing.Size(30, 13);
            this.m_lbl_thang.TabIndex = 0;
            this.m_lbl_thang.Text = "Tháng";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.m_grc);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 83);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(736, 295);
            this.panelControl2.TabIndex = 1;
            // 
            // m_grc
            // 
            this.m_grc.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc.Location = new System.Drawing.Point(2, 2);
            this.m_grc.MainView = this.gridView1;
            this.m_grc.Name = "m_grc";
            this.m_grc.Size = new System.Drawing.Size(732, 291);
            this.m_grc.TabIndex = 0;
            this.m_grc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.m_grc;
            this.gridView1.Name = "gridView1";
            // 
            // f394_cham_cong_thang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 378);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "f394_cham_cong_thang";
            this.Text = "F394 - Chấm công theo tháng";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_txt_nam.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_txt_thang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_grc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton m_cmd_loc;
        private DevExpress.XtraEditors.TextEdit m_txt_nam;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit m_txt_thang;
        private DevExpress.XtraEditors.LabelControl m_lbl_thang;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl m_grc;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}