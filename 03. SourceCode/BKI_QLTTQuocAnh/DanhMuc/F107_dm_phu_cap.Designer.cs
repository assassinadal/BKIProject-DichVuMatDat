namespace BKI_DichVuMatDat.DanhMuc
{
    partial class F107_dm_phu_cap
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
            this.m_grc_dm_phu_cap = new DevExpress.XtraGrid.GridControl();
            this.m_grv_dm_phu_cap = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.c_doi_tuong_huong_phu_cap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_ten_phu_cap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_ti_le = new DevExpress.XtraGrid.Columns.GridColumn();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_dm_phu_cap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_dm_phu_cap)).BeginInit();
            this.SuspendLayout();
            // 
            // m_grc_dm_phu_cap
            // 
            this.m_grc_dm_phu_cap.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_dm_phu_cap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc_dm_phu_cap.Location = new System.Drawing.Point(0, 0);
            this.m_grc_dm_phu_cap.MainView = this.m_grv_dm_phu_cap;
            this.m_grc_dm_phu_cap.Name = "m_grc_dm_phu_cap";
            this.m_grc_dm_phu_cap.Size = new System.Drawing.Size(556, 261);
            this.m_grc_dm_phu_cap.TabIndex = 0;
            this.m_grc_dm_phu_cap.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv_dm_phu_cap});
            // 
            // m_grv_dm_phu_cap
            // 
            this.m_grv_dm_phu_cap.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.STT,
            this.c_doi_tuong_huong_phu_cap,
            this.c_ten_phu_cap,
            this.c_ti_le});
            this.m_grv_dm_phu_cap.GridControl = this.m_grc_dm_phu_cap;
            this.m_grv_dm_phu_cap.Name = "m_grv_dm_phu_cap";
            // 
            // c_doi_tuong_huong_phu_cap
            // 
            this.c_doi_tuong_huong_phu_cap.AppearanceHeader.Options.UseTextOptions = true;
            this.c_doi_tuong_huong_phu_cap.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.c_doi_tuong_huong_phu_cap.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.c_doi_tuong_huong_phu_cap.Caption = "Đối tượng hưởng phụ cấp";
            this.c_doi_tuong_huong_phu_cap.FieldName = "DOI_TUONG_HUONG_PHU_CAP";
            this.c_doi_tuong_huong_phu_cap.Name = "c_doi_tuong_huong_phu_cap";
            this.c_doi_tuong_huong_phu_cap.Visible = true;
            this.c_doi_tuong_huong_phu_cap.VisibleIndex = 1;
            this.c_doi_tuong_huong_phu_cap.Width = 165;
            // 
            // c_ten_phu_cap
            // 
            this.c_ten_phu_cap.AppearanceHeader.Options.UseTextOptions = true;
            this.c_ten_phu_cap.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.c_ten_phu_cap.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.c_ten_phu_cap.Caption = "Loại phụ cấp";
            this.c_ten_phu_cap.FieldName = "TEN";
            this.c_ten_phu_cap.Name = "c_ten_phu_cap";
            this.c_ten_phu_cap.Visible = true;
            this.c_ten_phu_cap.VisibleIndex = 2;
            this.c_ten_phu_cap.Width = 165;
            // 
            // c_ti_le
            // 
            this.c_ti_le.AppearanceHeader.Options.UseTextOptions = true;
            this.c_ti_le.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.c_ti_le.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.c_ti_le.Caption = "Tỉ lệ";
            this.c_ti_le.FieldName = "TI_LE";
            this.c_ti_le.Name = "c_ti_le";
            this.c_ti_le.Visible = true;
            this.c_ti_le.VisibleIndex = 3;
            this.c_ti_le.Width = 170;
            // 
            // STT
            // 
            this.STT.AppearanceCell.Options.UseTextOptions = true;
            this.STT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.STT.AppearanceHeader.Options.UseTextOptions = true;
            this.STT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.STT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.STT.Caption = "STT";
            this.STT.FieldName = "STT";
            this.STT.Name = "STT";
            this.STT.Visible = true;
            this.STT.VisibleIndex = 0;
            this.STT.Width = 38;
            // 
            // m_cmd_dm_phu_cap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 261);
            this.Controls.Add(this.m_grc_dm_phu_cap);
            this.Name = "m_cmd_dm_phu_cap";
            this.Text = "F107_dm_phu_cap";
            this.Load += new System.EventHandler(this.F107_dm_phu_cap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_dm_phu_cap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_dm_phu_cap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl m_grc_dm_phu_cap;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv_dm_phu_cap;
        private DevExpress.XtraGrid.Columns.GridColumn c_doi_tuong_huong_phu_cap;
        private DevExpress.XtraGrid.Columns.GridColumn c_ten_phu_cap;
        private DevExpress.XtraGrid.Columns.GridColumn c_ti_le;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
    }
}