namespace BKI_DichVuMatDat.DanhMuc
{
    partial class F110_dm_hop_dong_het_han
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
            this.m_grc_hop_dong_het_han = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_hop_dong_het_han)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // m_grc_hop_dong_het_han
            // 
            this.m_grc_hop_dong_het_han.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_hop_dong_het_han.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc_hop_dong_het_han.Location = new System.Drawing.Point(0, 0);
            this.m_grc_hop_dong_het_han.MainView = this.gridView1;
            this.m_grc_hop_dong_het_han.Name = "m_grc_hop_dong_het_han";
            this.m_grc_hop_dong_het_han.Size = new System.Drawing.Size(677, 329);
            this.m_grc_hop_dong_het_han.TabIndex = 0;
            this.m_grc_hop_dong_het_han.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn3,
            this.gridColumn2,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8});
            this.gridView1.GridControl = this.m_grc_hop_dong_het_han;
            this.gridView1.Name = "gridView1";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ID NHÂN VIÊN";
            this.gridColumn1.FieldName = "ID";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Mã nhân viên";
            this.gridColumn3.FieldName = "MA_NV";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            this.gridColumn3.Width = 78;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên nhân viên";
            this.gridColumn2.FieldName = "HO_TEN";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 89;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Mã hợp đồng";
            this.gridColumn4.FieldName = "MA_HOP_DONG";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            this.gridColumn4.Width = 89;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Ngày ký hợp đồng";
            this.gridColumn5.FieldName = "NGAY_KY_HOP_DONG";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 89;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Ngày bắt đầu";
            this.gridColumn6.FieldName = "NGAY_BAT_DAU";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            this.gridColumn6.Width = 89;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Ngày kết thúc";
            this.gridColumn7.FieldName = "NGAY_KET_THUC";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            this.gridColumn7.Width = 97;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Loại hợp đồng";
            this.gridColumn8.FieldName = "LOAI_HOP_DONG";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 3;
            this.gridColumn8.Width = 89;
            // 
            // F110_dm_hop_dong_het_han
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 329);
            this.Controls.Add(this.m_grc_hop_dong_het_han);
            this.Name = "F110_dm_hop_dong_het_han";
            this.Text = "F110 - Danh mục hợp đồng hết hạn";
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_hop_dong_het_han)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl m_grc_hop_dong_het_han;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
    }
}