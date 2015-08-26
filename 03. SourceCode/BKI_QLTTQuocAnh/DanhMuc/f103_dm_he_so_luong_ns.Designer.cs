namespace BKI_DichVuMatDat.DanhMuc
{
    partial class F103_dm_he_so_luong_ns
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
            this.m_grc_dm_he_so_luong_ns = new DevExpress.XtraGrid.GridControl();
            this.m_grv_dm_he_so_luong_ns = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_ma_luong_ns = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_ten_luong_ns = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_muc_luong_ns = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_loai_lao_dong = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_dm_he_so_luong_ns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_dm_he_so_luong_ns)).BeginInit();
            this.SuspendLayout();
            // 
            // m_grc_dm_he_so_luong_ns
            // 
            this.m_grc_dm_he_so_luong_ns.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_dm_he_so_luong_ns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc_dm_he_so_luong_ns.Location = new System.Drawing.Point(0, 0);
            this.m_grc_dm_he_so_luong_ns.MainView = this.m_grv_dm_he_so_luong_ns;
            this.m_grc_dm_he_so_luong_ns.Name = "m_grc_dm_he_so_luong_ns";
            this.m_grc_dm_he_so_luong_ns.Size = new System.Drawing.Size(765, 292);
            this.m_grc_dm_he_so_luong_ns.TabIndex = 0;
            this.m_grc_dm_he_so_luong_ns.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv_dm_he_so_luong_ns});
            // 
            // m_grv_dm_he_so_luong_ns
            // 
            this.m_grv_dm_he_so_luong_ns.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.STT,
            this.c_ma_luong_ns,
            this.c_ten_luong_ns,
            this.c_muc_luong_ns,
            this.c_loai_lao_dong});
            this.m_grv_dm_he_so_luong_ns.GridControl = this.m_grc_dm_he_so_luong_ns;
            this.m_grv_dm_he_so_luong_ns.Name = "m_grv_dm_he_so_luong_ns";
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
            // c_ma_luong_ns
            // 
            this.c_ma_luong_ns.AppearanceHeader.Options.UseTextOptions = true;
            this.c_ma_luong_ns.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.c_ma_luong_ns.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.c_ma_luong_ns.Caption = "Mã Lương NS";
            this.c_ma_luong_ns.FieldName = "ID_MA_LNS";
            this.c_ma_luong_ns.Name = "c_ma_luong_ns";
            this.c_ma_luong_ns.Visible = true;
            this.c_ma_luong_ns.VisibleIndex = 1;
            this.c_ma_luong_ns.Width = 176;
            // 
            // c_ten_luong_ns
            // 
            this.c_ten_luong_ns.AppearanceHeader.Options.UseTextOptions = true;
            this.c_ten_luong_ns.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.c_ten_luong_ns.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.c_ten_luong_ns.Caption = "Tên Lương NS";
            this.c_ten_luong_ns.FieldName = "TEN";
            this.c_ten_luong_ns.Name = "c_ten_luong_ns";
            this.c_ten_luong_ns.Visible = true;
            this.c_ten_luong_ns.VisibleIndex = 2;
            this.c_ten_luong_ns.Width = 176;
            // 
            // c_muc_luong_ns
            // 
            this.c_muc_luong_ns.AppearanceHeader.Options.UseTextOptions = true;
            this.c_muc_luong_ns.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.c_muc_luong_ns.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.c_muc_luong_ns.Caption = "Mức Lương NS";
            this.c_muc_luong_ns.FieldName = "MUC_LNS";
            this.c_muc_luong_ns.Name = "c_muc_luong_ns";
            this.c_muc_luong_ns.Visible = true;
            this.c_muc_luong_ns.VisibleIndex = 3;
            this.c_muc_luong_ns.Width = 176;
            // 
            // c_loai_lao_dong
            // 
            this.c_loai_lao_dong.AppearanceHeader.Options.UseTextOptions = true;
            this.c_loai_lao_dong.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.c_loai_lao_dong.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.c_loai_lao_dong.Caption = "Loại Lao Động";
            this.c_loai_lao_dong.FieldName = "LOAI_LAO_DONG";
            this.c_loai_lao_dong.Name = "c_loai_lao_dong";
            this.c_loai_lao_dong.Visible = true;
            this.c_loai_lao_dong.VisibleIndex = 4;
            this.c_loai_lao_dong.Width = 181;
            // 
            // F103_dm_he_so_luong_ns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 292);
            this.Controls.Add(this.m_grc_dm_he_so_luong_ns);
            this.Name = "F103_dm_he_so_luong_ns";
            this.Text = "F103_dm_he_so_luong_ns";
            this.Load += new System.EventHandler(this.F103_dm_he_so_luong_ns_load);
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_dm_he_so_luong_ns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_dm_he_so_luong_ns)).EndInit();
            this.ResumeLayout(false);

        }

      
        #endregion

        private DevExpress.XtraGrid.GridControl m_grc_dm_he_so_luong_ns;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv_dm_he_so_luong_ns;
        private DevExpress.XtraGrid.Columns.GridColumn c_ma_luong_ns;
        private DevExpress.XtraGrid.Columns.GridColumn c_ten_luong_ns;
        private DevExpress.XtraGrid.Columns.GridColumn c_muc_luong_ns;
        private DevExpress.XtraGrid.Columns.GridColumn c_loai_lao_dong;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
    }
}