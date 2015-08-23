namespace BKI_DichVuMatDat.DanhMuc
{
    partial class F105_dm_loai_ngay_cong
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
            this.m_grc_dm_loai_ngay_cong = new DevExpress.XtraGrid.GridControl();
            this.m_grv_dm_loai_ngay_cong = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.c_ma_ngay_cong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_ten_ngay_cong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_ti_le_LNS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_ti_le_lcd = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_dm_loai_ngay_cong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_dm_loai_ngay_cong)).BeginInit();
            this.SuspendLayout();
            // 
            // m_grc_dm_loai_ngay_cong
            // 
            this.m_grc_dm_loai_ngay_cong.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_dm_loai_ngay_cong.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_grc_dm_loai_ngay_cong.Location = new System.Drawing.Point(0, 0);
            this.m_grc_dm_loai_ngay_cong.MainView = this.m_grv_dm_loai_ngay_cong;
            this.m_grc_dm_loai_ngay_cong.Name = "m_grc_dm_loai_ngay_cong";
            this.m_grc_dm_loai_ngay_cong.Size = new System.Drawing.Size(634, 200);
            this.m_grc_dm_loai_ngay_cong.TabIndex = 0;
            this.m_grc_dm_loai_ngay_cong.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv_dm_loai_ngay_cong});
            // 
            // m_grv_dm_loai_ngay_cong
            // 
            this.m_grv_dm_loai_ngay_cong.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.c_ma_ngay_cong,
            this.c_ten_ngay_cong,
            this.c_ti_le_LNS,
            this.c_ti_le_lcd});
            this.m_grv_dm_loai_ngay_cong.GridControl = this.m_grc_dm_loai_ngay_cong;
            this.m_grv_dm_loai_ngay_cong.Name = "m_grv_dm_loai_ngay_cong";
            // 
            // c_ma_ngay_cong
            // 
            this.c_ma_ngay_cong.Caption = "Mã ngày công";
            this.c_ma_ngay_cong.FieldName = "MA_NGAY_CONG";
            this.c_ma_ngay_cong.Name = "c_ma_ngay_cong";
            this.c_ma_ngay_cong.Visible = true;
            this.c_ma_ngay_cong.VisibleIndex = 0;
            // 
            // c_ten_ngay_cong
            // 
            this.c_ten_ngay_cong.Caption = "Tên ngày công";
            this.c_ten_ngay_cong.FieldName = "TEN_NGAY_CONG";
            this.c_ten_ngay_cong.Name = "c_ten_ngay_cong";
            this.c_ten_ngay_cong.Visible = true;
            this.c_ten_ngay_cong.VisibleIndex = 1;
            // 
            // c_ti_le_LNS
            // 
            this.c_ti_le_LNS.Caption = "Tỉ lệ LNS";
            this.c_ti_le_LNS.FieldName = "TI_LE_LNS";
            this.c_ti_le_LNS.Name = "c_ti_le_LNS";
            this.c_ti_le_LNS.Visible = true;
            this.c_ti_le_LNS.VisibleIndex = 2;
            // 
            // c_ti_le_lcd
            // 
            this.c_ti_le_lcd.Caption = "TỈ lệ LCĐ";
            this.c_ti_le_lcd.FieldName = "TI_LE_LCD";
            this.c_ti_le_lcd.Name = "c_ti_le_lcd";
            this.c_ti_le_lcd.Visible = true;
            this.c_ti_le_lcd.VisibleIndex = 3;
            // 
            // F105_dm_loai_ngay_cong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 261);
            this.Controls.Add(this.m_grc_dm_loai_ngay_cong);
            this.Name = "F105_dm_loai_ngay_cong";
            this.Text = "F105_dm_loai_ngay_cong";
            this.Load += new System.EventHandler(this.F105_dm_loai_ngay_cong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_dm_loai_ngay_cong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_dm_loai_ngay_cong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl m_grc_dm_loai_ngay_cong;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv_dm_loai_ngay_cong;
        private DevExpress.XtraGrid.Columns.GridColumn c_ma_ngay_cong;
        private DevExpress.XtraGrid.Columns.GridColumn c_ten_ngay_cong;
        private DevExpress.XtraGrid.Columns.GridColumn c_ti_le_LNS;
        private DevExpress.XtraGrid.Columns.GridColumn c_ti_le_lcd;
    }
}