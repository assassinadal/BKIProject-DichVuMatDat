namespace BKI_DichVuMatDat.DanhMuc
{
    partial class F101_dm_don_vi
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
            this.m_grc_dm_don_vi = new DevExpress.XtraGrid.GridControl();
            this.m_grv_dm_don_vi = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_ma_don_vi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_ten_don_vi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.C_ten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_ma_don_vi_cap_tren = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_ten_don_vi_cap_tren = new DevExpress.XtraGrid.Columns.GridColumn();
            this.m_lbl_header = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_dm_don_vi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_dm_don_vi)).BeginInit();
            this.SuspendLayout();
            // 
            // m_grc_dm_don_vi
            // 
            this.m_grc_dm_don_vi.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_dm_don_vi.Location = new System.Drawing.Point(0, 47);
            this.m_grc_dm_don_vi.MainView = this.m_grv_dm_don_vi;
            this.m_grc_dm_don_vi.Name = "m_grc_dm_don_vi";
            this.m_grc_dm_don_vi.Size = new System.Drawing.Size(879, 208);
            this.m_grc_dm_don_vi.TabIndex = 0;
            this.m_grc_dm_don_vi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv_dm_don_vi});
            // 
            // m_grv_dm_don_vi
            // 
            this.m_grv_dm_don_vi.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.STT,
            this.c_ma_don_vi,
            this.c_ten_don_vi,
            this.C_ten,
            this.c_ma_don_vi_cap_tren,
            this.c_ten_don_vi_cap_tren});
            this.m_grv_dm_don_vi.GridControl = this.m_grc_dm_don_vi;
            this.m_grv_dm_don_vi.Name = "m_grv_dm_don_vi";
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
            // c_ma_don_vi
            // 
            this.c_ma_don_vi.AppearanceCell.Options.UseTextOptions = true;
            this.c_ma_don_vi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.c_ma_don_vi.AppearanceHeader.Options.UseTextOptions = true;
            this.c_ma_don_vi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.c_ma_don_vi.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.c_ma_don_vi.Caption = "Mã đơn vị";
            this.c_ma_don_vi.FieldName = "MA_DON_VI";
            this.c_ma_don_vi.Name = "c_ma_don_vi";
            this.c_ma_don_vi.Visible = true;
            this.c_ma_don_vi.VisibleIndex = 1;
            this.c_ma_don_vi.Width = 83;
            // 
            // c_ten_don_vi
            // 
            this.c_ten_don_vi.AppearanceHeader.Options.UseTextOptions = true;
            this.c_ten_don_vi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.c_ten_don_vi.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.c_ten_don_vi.Caption = "Tên dơn vị";
            this.c_ten_don_vi.FieldName = "TEN_DON_VI";
            this.c_ten_don_vi.Name = "c_ten_don_vi";
            this.c_ten_don_vi.Visible = true;
            this.c_ten_don_vi.VisibleIndex = 2;
            this.c_ten_don_vi.Width = 87;
            // 
            // C_ten
            // 
            this.C_ten.AppearanceHeader.Options.UseTextOptions = true;
            this.C_ten.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.C_ten.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.C_ten.Caption = "Tên";
            this.C_ten.FieldName = "TEN";
            this.C_ten.Name = "C_ten";
            this.C_ten.Visible = true;
            this.C_ten.VisibleIndex = 3;
            this.C_ten.Width = 87;
            // 
            // c_ma_don_vi_cap_tren
            // 
            this.c_ma_don_vi_cap_tren.AppearanceHeader.Options.UseTextOptions = true;
            this.c_ma_don_vi_cap_tren.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.c_ma_don_vi_cap_tren.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.c_ma_don_vi_cap_tren.Caption = "Mã đơn vị cấp trên";
            this.c_ma_don_vi_cap_tren.FieldName = "MA_DON_VI_CAP_TREN";
            this.c_ma_don_vi_cap_tren.Name = "c_ma_don_vi_cap_tren";
            this.c_ma_don_vi_cap_tren.Visible = true;
            this.c_ma_don_vi_cap_tren.VisibleIndex = 4;
            this.c_ma_don_vi_cap_tren.Width = 87;
            // 
            // c_ten_don_vi_cap_tren
            // 
            this.c_ten_don_vi_cap_tren.AppearanceHeader.Options.UseTextOptions = true;
            this.c_ten_don_vi_cap_tren.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.c_ten_don_vi_cap_tren.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.c_ten_don_vi_cap_tren.Caption = "Tên đơn vị cấp trên";
            this.c_ten_don_vi_cap_tren.FieldName = "TEN_DON_VI_CAP_TREN";
            this.c_ten_don_vi_cap_tren.Name = "c_ten_don_vi_cap_tren";
            this.c_ten_don_vi_cap_tren.Visible = true;
            this.c_ten_don_vi_cap_tren.VisibleIndex = 5;
            this.c_ten_don_vi_cap_tren.Width = 97;
            // 
            // m_lbl_header
            // 
            this.m_lbl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.m_lbl_header.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_header.Location = new System.Drawing.Point(0, 0);
            this.m_lbl_header.Name = "m_lbl_header";
            this.m_lbl_header.Size = new System.Drawing.Size(879, 44);
            this.m_lbl_header.TabIndex = 1;
            this.m_lbl_header.Text = "LƯƠNG CHẾ ĐỘ NHÂN VIÊN";
            this.m_lbl_header.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 252);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(879, 39);
            this.panel1.TabIndex = 2;
            // 
            // F101_dm_don_vi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 291);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.m_lbl_header);
            this.Controls.Add(this.m_grc_dm_don_vi);
            this.Name = "F101_dm_don_vi";
            this.Text = "F101-DANH MỤC ĐƠN VỊ";
            this.Load += new System.EventHandler(this.F101_dm_don_vi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_dm_don_vi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_dm_don_vi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl m_grc_dm_don_vi;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv_dm_don_vi;
        private DevExpress.XtraGrid.Columns.GridColumn c_ma_don_vi;
        private DevExpress.XtraGrid.Columns.GridColumn c_ten_don_vi;
        private DevExpress.XtraGrid.Columns.GridColumn C_ten;
        private DevExpress.XtraGrid.Columns.GridColumn c_ma_don_vi_cap_tren;
        private DevExpress.XtraGrid.Columns.GridColumn c_ten_don_vi_cap_tren;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
        private System.Windows.Forms.Label m_lbl_header;
        private System.Windows.Forms.Panel panel1;
    }
}