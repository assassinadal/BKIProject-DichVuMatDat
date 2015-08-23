namespace BKI_DichVuMatDat.DanhMuc
{
    partial class F104_dm_loai_hop_dong
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
            this.tableAdapterManager1 = new IP.Core.IPData.DS_HT_PHAN_QUYEN_DETAILTableAdapters.TableAdapterManager();
            this.m_grc_dm_loai_hop_dong = new DevExpress.XtraGrid.GridControl();
            this.m_grv_dm_loai_hop_dong = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.c_loai_hop_dong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_ma_loai_hop_dong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_ti_le = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_so_tien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_hs_lns_yn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_an_ca_yn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_lcd_yn = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_dm_loai_hop_dong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_dm_loai_hop_dong)).BeginInit();
            this.SuspendLayout();
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.HT_PHAN_QUYEN_DETAILTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = IP.Core.IPData.DS_HT_PHAN_QUYEN_DETAILTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // m_grc_dm_loai_hop_dong
            // 
            this.m_grc_dm_loai_hop_dong.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_dm_loai_hop_dong.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_grc_dm_loai_hop_dong.Location = new System.Drawing.Point(0, 0);
            this.m_grc_dm_loai_hop_dong.MainView = this.m_grv_dm_loai_hop_dong;
            this.m_grc_dm_loai_hop_dong.Name = "m_grc_dm_loai_hop_dong";
            this.m_grc_dm_loai_hop_dong.Size = new System.Drawing.Size(618, 200);
            this.m_grc_dm_loai_hop_dong.TabIndex = 0;
            this.m_grc_dm_loai_hop_dong.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv_dm_loai_hop_dong});
            // 
            // m_grv_dm_loai_hop_dong
            // 
            this.m_grv_dm_loai_hop_dong.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.c_loai_hop_dong,
            this.c_ma_loai_hop_dong,
            this.c_ti_le,
            this.c_so_tien,
            this.c_hs_lns_yn,
            this.c_an_ca_yn,
            this.c_lcd_yn});
            this.m_grv_dm_loai_hop_dong.GridControl = this.m_grc_dm_loai_hop_dong;
            this.m_grv_dm_loai_hop_dong.Name = "m_grv_dm_loai_hop_dong";
            // 
            // c_loai_hop_dong
            // 
            this.c_loai_hop_dong.Caption = "Loại hợp đồng";
            this.c_loai_hop_dong.FieldName = "LOAI_HOP_DONG";
            this.c_loai_hop_dong.Name = "c_loai_hop_dong";
            this.c_loai_hop_dong.Visible = true;
            this.c_loai_hop_dong.VisibleIndex = 0;
            // 
            // c_ma_loai_hop_dong
            // 
            this.c_ma_loai_hop_dong.Caption = "Mã loại hơp đồng";
            this.c_ma_loai_hop_dong.FieldName = "MA_LOAI_HOP_DONG";
            this.c_ma_loai_hop_dong.Name = "c_ma_loai_hop_dong";
            this.c_ma_loai_hop_dong.Visible = true;
            this.c_ma_loai_hop_dong.VisibleIndex = 1;
            // 
            // c_ti_le
            // 
            this.c_ti_le.Caption = "Tỉ lệ";
            this.c_ti_le.FieldName = "TI_LE";
            this.c_ti_le.Name = "c_ti_le";
            this.c_ti_le.Visible = true;
            this.c_ti_le.VisibleIndex = 2;
            // 
            // c_so_tien
            // 
            this.c_so_tien.Caption = "Số tiền";
            this.c_so_tien.FieldName = "SO_TIEN";
            this.c_so_tien.Name = "c_so_tien";
            this.c_so_tien.Visible = true;
            this.c_so_tien.VisibleIndex = 3;
            // 
            // c_hs_lns_yn
            // 
            this.c_hs_lns_yn.Caption = "Hệ số  LNS (Y/N)";
            this.c_hs_lns_yn.FieldName = "HS_LNS_YN";
            this.c_hs_lns_yn.Name = "c_hs_lns_yn";
            this.c_hs_lns_yn.Visible = true;
            this.c_hs_lns_yn.VisibleIndex = 4;
            // 
            // c_an_ca_yn
            // 
            this.c_an_ca_yn.Caption = "Ăn ca (Y/N)";
            this.c_an_ca_yn.FieldName = "AN_CA_YN";
            this.c_an_ca_yn.Name = "c_an_ca_yn";
            this.c_an_ca_yn.Visible = true;
            this.c_an_ca_yn.VisibleIndex = 5;
            // 
            // c_lcd_yn
            // 
            this.c_lcd_yn.Caption = "Lương CĐ (Y/N)";
            this.c_lcd_yn.FieldName = "LCD_YN";
            this.c_lcd_yn.Name = "c_lcd_yn";
            this.c_lcd_yn.Visible = true;
            this.c_lcd_yn.VisibleIndex = 6;
            // 
            // F104_dm_loai_hop_dong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 261);
            this.Controls.Add(this.m_grc_dm_loai_hop_dong);
            this.Name = "F104_dm_loai_hop_dong";
            this.Text = "F104_dm_loai_hop_dong";
            this.Load += new System.EventHandler(this.F104_dm_loai_hop_dong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_dm_loai_hop_dong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_dm_loai_hop_dong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private IP.Core.IPData.DS_HT_PHAN_QUYEN_DETAILTableAdapters.TableAdapterManager tableAdapterManager1;
        private DevExpress.XtraGrid.GridControl m_grc_dm_loai_hop_dong;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv_dm_loai_hop_dong;
        private DevExpress.XtraGrid.Columns.GridColumn c_loai_hop_dong;
        private DevExpress.XtraGrid.Columns.GridColumn c_ma_loai_hop_dong;
        private DevExpress.XtraGrid.Columns.GridColumn c_ti_le;
        private DevExpress.XtraGrid.Columns.GridColumn c_so_tien;
        private DevExpress.XtraGrid.Columns.GridColumn c_hs_lns_yn;
        private DevExpress.XtraGrid.Columns.GridColumn c_an_ca_yn;
        private DevExpress.XtraGrid.Columns.GridColumn c_lcd_yn;

    }
}