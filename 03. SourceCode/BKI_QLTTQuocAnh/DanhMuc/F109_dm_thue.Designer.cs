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
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_dm_thue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_dm_thue)).BeginInit();
            this.SuspendLayout();
            // 
            // m_grc_dm_thue
            // 
            this.m_grc_dm_thue.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_dm_thue.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_grc_dm_thue.Location = new System.Drawing.Point(0, 0);
            this.m_grc_dm_thue.MainView = this.m_grv_dm_thue;
            this.m_grc_dm_thue.Name = "m_grc_dm_thue";
            this.m_grc_dm_thue.Size = new System.Drawing.Size(623, 200);
            this.m_grc_dm_thue.TabIndex = 0;
            this.m_grc_dm_thue.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv_dm_thue});
            // 
            // m_grv_dm_thue
            // 
            this.m_grv_dm_thue.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.c_chan_duoi,
            this.c_chan_tren,
            this.c_ti_le,
            this.c_bu_tru});
            this.m_grv_dm_thue.GridControl = this.m_grc_dm_thue;
            this.m_grv_dm_thue.Name = "m_grv_dm_thue";
            // 
            // c_chan_duoi
            // 
            this.c_chan_duoi.Caption = "Chặn dưới";
            this.c_chan_duoi.FieldName = "CHAN_DUOI";
            this.c_chan_duoi.Name = "c_chan_duoi";
            this.c_chan_duoi.Visible = true;
            this.c_chan_duoi.VisibleIndex = 0;
            // 
            // c_chan_tren
            // 
            this.c_chan_tren.Caption = "Chặn trên";
            this.c_chan_tren.FieldName = "CHAN_TREN";
            this.c_chan_tren.Name = "c_chan_tren";
            this.c_chan_tren.Visible = true;
            this.c_chan_tren.VisibleIndex = 1;
            // 
            // c_ti_le
            // 
            this.c_ti_le.Caption = "Tỉ lệ";
            this.c_ti_le.FieldName = "TI_LE";
            this.c_ti_le.Name = "c_ti_le";
            this.c_ti_le.Visible = true;
            this.c_ti_le.VisibleIndex = 2;
            // 
            // c_bu_tru
            // 
            this.c_bu_tru.Caption = "Bù trừ";
            this.c_bu_tru.FieldName = "BU_TRU";
            this.c_bu_tru.Name = "c_bu_tru";
            this.c_bu_tru.Visible = true;
            this.c_bu_tru.VisibleIndex = 3;
            // 
            // F109_dm_thue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 238);
            this.Controls.Add(this.m_grc_dm_thue);
            this.Name = "F109_dm_thue";
            this.Text = "F109_dm_thue";
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
    }
}