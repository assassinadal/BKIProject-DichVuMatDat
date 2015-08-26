namespace BKI_DichVuMatDat.DanhMuc
{
    partial class F106_dm_luong_che_do
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
            this.m_grc_dm_luong_che_do = new DevExpress.XtraGrid.GridControl();
            this.m_grv_luong_che_do = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.c_ma_lcd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_muc_lcd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_so_tien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_dm_luong_che_do)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_luong_che_do)).BeginInit();
            this.SuspendLayout();
            // 
            // m_grc_dm_luong_che_do
            // 
            this.m_grc_dm_luong_che_do.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_dm_luong_che_do.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc_dm_luong_che_do.Location = new System.Drawing.Point(0, 0);
            this.m_grc_dm_luong_che_do.MainView = this.m_grv_luong_che_do;
            this.m_grc_dm_luong_che_do.Name = "m_grc_dm_luong_che_do";
            this.m_grc_dm_luong_che_do.Size = new System.Drawing.Size(730, 261);
            this.m_grc_dm_luong_che_do.TabIndex = 0;
            this.m_grc_dm_luong_che_do.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv_luong_che_do});
            // 
            // m_grv_luong_che_do
            // 
            this.m_grv_luong_che_do.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.STT,
            this.c_ma_lcd,
            this.c_muc_lcd,
            this.c_so_tien});
            this.m_grv_luong_che_do.GridControl = this.m_grc_dm_luong_che_do;
            this.m_grv_luong_che_do.Name = "m_grv_luong_che_do";
            // 
            // c_ma_lcd
            // 
            this.c_ma_lcd.AppearanceHeader.Options.UseTextOptions = true;
            this.c_ma_lcd.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.c_ma_lcd.Caption = "Mã Lương CĐ";
            this.c_ma_lcd.FieldName = "MA_LCD";
            this.c_ma_lcd.Name = "c_ma_lcd";
            this.c_ma_lcd.Visible = true;
            this.c_ma_lcd.VisibleIndex = 1;
            this.c_ma_lcd.Width = 224;
            // 
            // c_muc_lcd
            // 
            this.c_muc_lcd.AppearanceHeader.Options.UseTextOptions = true;
            this.c_muc_lcd.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.c_muc_lcd.Caption = "Mức Lương CĐ";
            this.c_muc_lcd.Name = "c_muc_lcd";
            this.c_muc_lcd.Visible = true;
            this.c_muc_lcd.VisibleIndex = 2;
            this.c_muc_lcd.Width = 224;
            // 
            // c_so_tien
            // 
            this.c_so_tien.AppearanceHeader.Options.UseTextOptions = true;
            this.c_so_tien.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.c_so_tien.Caption = "Số tiền";
            this.c_so_tien.FieldName = "SO_TIEN";
            this.c_so_tien.Name = "c_so_tien";
            this.c_so_tien.Visible = true;
            this.c_so_tien.VisibleIndex = 3;
            this.c_so_tien.Width = 226;
            // 
            // STT
            // 
            this.STT.AppearanceHeader.Options.UseTextOptions = true;
            this.STT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.STT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.STT.Caption = "STT";
            this.STT.Name = "STT";
            this.STT.Visible = true;
            this.STT.VisibleIndex = 0;
            this.STT.Width = 38;
            // 
            // F106_dm_luong_che_do
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 261);
            this.Controls.Add(this.m_grc_dm_luong_che_do);
            this.Name = "F106_dm_luong_che_do";
            this.Text = "F106_dm_luong_che_do";
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_dm_luong_che_do)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_luong_che_do)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl m_grc_dm_luong_che_do;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv_luong_che_do;
        private DevExpress.XtraGrid.Columns.GridColumn c_ma_lcd;
        private DevExpress.XtraGrid.Columns.GridColumn c_muc_lcd;
        private DevExpress.XtraGrid.Columns.GridColumn c_so_tien;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
    }
}