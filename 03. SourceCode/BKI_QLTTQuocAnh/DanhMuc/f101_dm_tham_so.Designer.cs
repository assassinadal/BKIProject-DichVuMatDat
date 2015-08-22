namespace BKI_DichVuMatDat.DanhMuc
{
    partial class f101_dm_tham_so
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
            this.m_grc_tham_so = new DevExpress.XtraGrid.GridControl();
            this.m_grv_tham_so = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ma = new DevExpress.XtraGrid.Columns.GridColumn();
            this.So_Tien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_tham_so)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_tham_so)).BeginInit();
            this.SuspendLayout();
            // 
            // m_grc_tham_so
            // 
            this.m_grc_tham_so.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_tham_so.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc_tham_so.Location = new System.Drawing.Point(0, 0);
            this.m_grc_tham_so.MainView = this.m_grv_tham_so;
            this.m_grc_tham_so.Name = "m_grc_tham_so";
            this.m_grc_tham_so.Size = new System.Drawing.Size(531, 261);
            this.m_grc_tham_so.TabIndex = 0;
            this.m_grc_tham_so.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv_tham_so});
            // 
            // m_grv_tham_so
            // 
            this.m_grv_tham_so.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.Ma,
            this.So_Tien,
            this.gridColumn4});
            this.m_grv_tham_so.GridControl = this.m_grc_tham_so;
            this.m_grv_tham_so.Name = "m_grv_tham_so";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ID";
            this.gridColumn1.FieldName = "ID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 72;
            // 
            // Ma
            // 
            this.Ma.Caption = "Loại";
            this.Ma.FieldName = "LOAI";
            this.Ma.Name = "Ma";
            this.Ma.Visible = true;
            this.Ma.VisibleIndex = 1;
            this.Ma.Width = 219;
            // 
            // So_Tien
            // 
            this.So_Tien.Caption = "Số Tiền";
            this.So_Tien.FieldName = "SO_TIEN";
            this.So_Tien.Name = "So_Tien";
            this.So_Tien.Visible = true;
            this.So_Tien.VisibleIndex = 2;
            this.So_Tien.Width = 222;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Name = "gridColumn4";
            // 
            // f101_dm_tham_so
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 261);
            this.Controls.Add(this.m_grc_tham_so);
            this.Name = "f101_dm_tham_so";
            this.Text = "f101_dm_tham_so";
            this.Load += new System.EventHandler(this.f101_dm_tham_so_Load);
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_tham_so)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_tham_so)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl m_grc_tham_so;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv_tham_so;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn Ma;
        private DevExpress.XtraGrid.Columns.GridColumn So_Tien;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
    }
}