namespace BKI_DichVuMatDat.NghiepVu.NhanSu
{
    partial class f311_danh_sach_nhan_vien_theo_don_vi
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
            this.m_tree_don_vi = new DevExpress.XtraTreeList.TreeList();
            this.m_grc_nv = new DevExpress.XtraGrid.GridControl();
            this.m_grv_nv = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_tree_don_vi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_nv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_nv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.m_grc_nv);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Controls.Add(this.m_tree_don_vi);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(424, 480);
            this.panelControl1.TabIndex = 0;
            // 
            // m_tree_don_vi
            // 
            this.m_tree_don_vi.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_tree_don_vi.Location = new System.Drawing.Point(2, 2);
            this.m_tree_don_vi.Name = "m_tree_don_vi";
            this.m_tree_don_vi.Size = new System.Drawing.Size(420, 200);
            this.m_tree_don_vi.TabIndex = 0;
            // 
            // m_grc_nv
            // 
            this.m_grc_nv.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_nv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc_nv.Location = new System.Drawing.Point(2, 215);
            this.m_grc_nv.MainView = this.m_grv_nv;
            this.m_grc_nv.Name = "m_grc_nv";
            this.m_grc_nv.Size = new System.Drawing.Size(420, 263);
            this.m_grc_nv.TabIndex = 1;
            this.m_grc_nv.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv_nv});
            // 
            // m_grv_nv
            // 
            this.m_grv_nv.GridControl = this.m_grc_nv;
            this.m_grv_nv.Name = "m_grv_nv";
            // 
            // panelControl2
            // 
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(2, 202);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(420, 13);
            this.panelControl2.TabIndex = 2;
            // 
            // f311_danh_sach_nhan_vien_theo_don_vi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 480);
            this.Controls.Add(this.panelControl1);
            this.Name = "f311_danh_sach_nhan_vien_theo_don_vi";
            this.Text = "F311 - Danh sách nhân viên theo đơn vị";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_tree_don_vi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_nv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_nv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraTreeList.TreeList m_tree_don_vi;
        private DevExpress.XtraGrid.GridControl m_grc_nv;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv_nv;
        private DevExpress.XtraEditors.PanelControl panelControl2;
    }
}