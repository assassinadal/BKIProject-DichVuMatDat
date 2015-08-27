namespace BKI_DichVuMatDat.DanhMuc
{
    partial class F109_dm_thue
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
            this.m_grc_dm_thue = new DevExpress.XtraGrid.GridControl();
            this.m_grv_dm_thue = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.c_chan_duoi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_chan_tren = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_ti_le = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_bu_tru = new DevExpress.XtraGrid.Columns.GridColumn();
            this.m_lbl_header = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_dm_thue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_dm_thue)).BeginInit();
            this.SuspendLayout();
            // 
            // m_grc_dm_thue
            // 
            this.m_grc_dm_thue.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_dm_thue.Location = new System.Drawing.Point(4, 47);
            this.m_grc_dm_thue.MainView = this.m_grv_dm_thue;
            this.m_grc_dm_thue.Name = "m_grc_dm_thue";
            this.m_grc_dm_thue.Size = new System.Drawing.Size(744, 257);
            this.m_grc_dm_thue.TabIndex = 0;
            this.m_grc_dm_thue.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv_dm_thue});
            // 
            // m_grv_dm_thue
            // 
            this.m_grv_dm_thue.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.STT,
            this.c_chan_duoi,
            this.c_chan_tren,
            this.c_ti_le,
            this.c_bu_tru});
            this.m_grv_dm_thue.GridControl = this.m_grc_dm_thue;
            this.m_grv_dm_thue.Name = "m_grv_dm_thue";
            // 
            // c_chan_duoi
            // 
            this.c_chan_duoi.AppearanceHeader.Options.UseTextOptions = true;
            this.c_chan_duoi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.c_chan_duoi.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.c_chan_duoi.Caption = "Chặn dưới";
            this.c_chan_duoi.FieldName = "CHAN_DUOI";
            this.c_chan_duoi.Name = "c_chan_duoi";
            this.c_chan_duoi.Visible = true;
            this.c_chan_duoi.VisibleIndex = 1;
            this.c_chan_duoi.Width = 145;
            // 
            // c_chan_tren
            // 
            this.c_chan_tren.AppearanceHeader.Options.UseTextOptions = true;
            this.c_chan_tren.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.c_chan_tren.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.c_chan_tren.Caption = "Chặn trên";
            this.c_chan_tren.FieldName = "CHAN_TREN";
            this.c_chan_tren.Name = "c_chan_tren";
            this.c_chan_tren.Visible = true;
            this.c_chan_tren.VisibleIndex = 2;
            this.c_chan_tren.Width = 145;
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
            this.c_ti_le.Width = 145;
            // 
            // c_bu_tru
            // 
            this.c_bu_tru.AppearanceHeader.Options.UseTextOptions = true;
            this.c_bu_tru.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.c_bu_tru.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.c_bu_tru.Caption = "Bù trừ";
            this.c_bu_tru.FieldName = "BU_TRU";
            this.c_bu_tru.Name = "c_bu_tru";
            this.c_bu_tru.Visible = true;
            this.c_bu_tru.VisibleIndex = 4;
            this.c_bu_tru.Width = 253;
            // 
            // m_lbl_header
            // 
            this.m_lbl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.m_lbl_header.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_header.Location = new System.Drawing.Point(0, 0);
            this.m_lbl_header.Name = "m_lbl_header";
            this.m_lbl_header.Size = new System.Drawing.Size(748, 44);
            this.m_lbl_header.TabIndex = 1;
            this.m_lbl_header.Text = "DANH MỤC THUẾ";
            this.m_lbl_header.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 302);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(748, 48);
            this.panel1.TabIndex = 2;
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
            // F109_dm_thue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 350);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.m_lbl_header);
            this.Controls.Add(this.m_grc_dm_thue);
            this.Name = "F109_dm_thue";
            this.Text = "F109 - DANH MỤC THUẾ";
            this.Load += new System.EventHandler(this.F109_dm_thue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_dm_thue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_dm_thue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl m_grc_dm_thue;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv_dm_thue;
        private DevExpress.XtraGrid.Columns.GridColumn c_chan_duoi;
        private DevExpress.XtraGrid.Columns.GridColumn c_chan_tren;
        private DevExpress.XtraGrid.Columns.GridColumn c_ti_le;
        private DevExpress.XtraGrid.Columns.GridColumn c_bu_tru;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
        private System.Windows.Forms.Label m_lbl_header;
        private System.Windows.Forms.Panel panel1;
    }
}