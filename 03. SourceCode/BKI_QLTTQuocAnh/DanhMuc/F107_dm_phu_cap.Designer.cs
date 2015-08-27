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
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_doi_tuong_huong_phu_cap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_ten_phu_cap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_ti_le = new DevExpress.XtraGrid.Columns.GridColumn();
            this.m_lbl_header = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_dm_phu_cap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_dm_phu_cap)).BeginInit();
            this.SuspendLayout();
            // 
            // m_grc_dm_phu_cap
            // 
            this.m_grc_dm_phu_cap.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_dm_phu_cap.Location = new System.Drawing.Point(0, 47);
            this.m_grc_dm_phu_cap.MainView = this.m_grv_dm_phu_cap;
            this.m_grc_dm_phu_cap.Name = "m_grc_dm_phu_cap";
            this.m_grc_dm_phu_cap.Size = new System.Drawing.Size(695, 261);
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
            // m_lbl_header
            // 
            this.m_lbl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.m_lbl_header.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_header.Location = new System.Drawing.Point(0, 0);
            this.m_lbl_header.Name = "m_lbl_header";
            this.m_lbl_header.Size = new System.Drawing.Size(695, 44);
            this.m_lbl_header.TabIndex = 1;
            this.m_lbl_header.Text = "CHẾ ĐỘ PHỤ CẤP NHÂN VIÊN";
            this.m_lbl_header.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 306);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(695, 45);
            this.panel1.TabIndex = 2;
            // 
            // F107_dm_phu_cap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 351);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.m_lbl_header);
            this.Controls.Add(this.m_grc_dm_phu_cap);
            this.Name = "F107_dm_phu_cap";
            this.Text = "F107 - DANH MỤC PHỤ CẤP";
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
        private System.Windows.Forms.Label m_lbl_header;
        private System.Windows.Forms.Panel panel1;
    }
}