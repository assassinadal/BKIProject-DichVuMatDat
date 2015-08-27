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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F104_dm_loai_hop_dong));
            this.tableAdapterManager1 = new IP.Core.IPData.DS_HT_PHAN_QUYEN_DETAILTableAdapters.TableAdapterManager();
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_cmd_add = new SIS.Controls.Button.SiSButton();
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.m_cmd_edit = new SIS.Controls.Button.SiSButton();
            this.m_cmd_delete = new SIS.Controls.Button.SiSButton();
            this.m_grc_dm_loai_hop_dong = new DevExpress.XtraGrid.GridControl();
            this.m_grv_dm_loai_hop_dong = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.c_stt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_loai_hop_dong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_ma_loai_hop_dong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_ti_le = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_so_tien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_hs_lns_yn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_an_ca_yn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_lcd_yn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.m_lbl_header = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_dm_loai_hop_dong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_dm_loai_hop_dong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.HT_PHAN_QUYEN_DETAILTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = IP.Core.IPData.DS_HT_PHAN_QUYEN_DETAILTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_cmd_add);
            this.panel1.Controls.Add(this.m_cmd_edit);
            this.panel1.Controls.Add(this.m_cmd_delete);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 312);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(618, 37);
            this.panel1.TabIndex = 1;
            // 
            // m_cmd_add
            // 
            this.m_cmd_add.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_add.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_add.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_add.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_add.ImageIndex = 2;
            this.m_cmd_add.ImageList = this.ImageList;
            this.m_cmd_add.Location = new System.Drawing.Point(354, 0);
            this.m_cmd_add.Name = "m_cmd_add";
            this.m_cmd_add.Size = new System.Drawing.Size(88, 37);
            this.m_cmd_add.TabIndex = 3;
            this.m_cmd_add.Text = "&Thêm";
            // 
            // ImageList
            // 
            this.ImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList.ImageStream")));
            this.ImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList.Images.SetKeyName(0, "");
            this.ImageList.Images.SetKeyName(1, "");
            this.ImageList.Images.SetKeyName(2, "");
            this.ImageList.Images.SetKeyName(3, "");
            this.ImageList.Images.SetKeyName(4, "");
            this.ImageList.Images.SetKeyName(5, "");
            this.ImageList.Images.SetKeyName(6, "");
            this.ImageList.Images.SetKeyName(7, "");
            this.ImageList.Images.SetKeyName(8, "");
            this.ImageList.Images.SetKeyName(9, "");
            this.ImageList.Images.SetKeyName(10, "");
            this.ImageList.Images.SetKeyName(11, "");
            this.ImageList.Images.SetKeyName(12, "");
            this.ImageList.Images.SetKeyName(13, "");
            this.ImageList.Images.SetKeyName(14, "");
            this.ImageList.Images.SetKeyName(15, "");
            this.ImageList.Images.SetKeyName(16, "");
            this.ImageList.Images.SetKeyName(17, "");
            this.ImageList.Images.SetKeyName(18, "");
            this.ImageList.Images.SetKeyName(19, "");
            this.ImageList.Images.SetKeyName(20, "");
            this.ImageList.Images.SetKeyName(21, "");
            // 
            // m_cmd_edit
            // 
            this.m_cmd_edit.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_edit.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_edit.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_edit.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_edit.ImageIndex = 16;
            this.m_cmd_edit.ImageList = this.ImageList;
            this.m_cmd_edit.Location = new System.Drawing.Point(442, 0);
            this.m_cmd_edit.Name = "m_cmd_edit";
            this.m_cmd_edit.Size = new System.Drawing.Size(88, 37);
            this.m_cmd_edit.TabIndex = 2;
            this.m_cmd_edit.Text = "&Sửa";
            // 
            // m_cmd_delete
            // 
            this.m_cmd_delete.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_delete.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_delete.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_delete.ImageIndex = 4;
            this.m_cmd_delete.ImageList = this.ImageList;
            this.m_cmd_delete.Location = new System.Drawing.Point(530, 0);
            this.m_cmd_delete.Name = "m_cmd_delete";
            this.m_cmd_delete.Size = new System.Drawing.Size(88, 37);
            this.m_cmd_delete.TabIndex = 1;
            this.m_cmd_delete.Text = "&Xóa";
            // 
            // m_grc_dm_loai_hop_dong
            // 
            this.m_grc_dm_loai_hop_dong.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_dm_loai_hop_dong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc_dm_loai_hop_dong.Location = new System.Drawing.Point(0, 0);
            this.m_grc_dm_loai_hop_dong.MainView = this.m_grv_dm_loai_hop_dong;
            this.m_grc_dm_loai_hop_dong.Name = "m_grc_dm_loai_hop_dong";
            this.m_grc_dm_loai_hop_dong.Size = new System.Drawing.Size(618, 265);
            this.m_grc_dm_loai_hop_dong.TabIndex = 0;
            this.m_grc_dm_loai_hop_dong.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv_dm_loai_hop_dong,
            this.gridView1});
            // 
            // m_grv_dm_loai_hop_dong
            // 
            this.m_grv_dm_loai_hop_dong.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.c_stt,
            this.c_loai_hop_dong,
            this.c_ma_loai_hop_dong,
            this.c_ti_le,
            this.c_so_tien,
            this.c_hs_lns_yn,
            this.c_an_ca_yn,
            this.c_lcd_yn});
            this.m_grv_dm_loai_hop_dong.GridControl = this.m_grc_dm_loai_hop_dong;
            this.m_grv_dm_loai_hop_dong.Name = "m_grv_dm_loai_hop_dong";
            this.m_grv_dm_loai_hop_dong.OptionsFind.AllowFindPanel = false;
            this.m_grv_dm_loai_hop_dong.OptionsFind.AlwaysVisible = true;
            this.m_grv_dm_loai_hop_dong.OptionsView.ShowFooter = true;
            // 
            // c_stt
            // 
            this.c_stt.AppearanceCell.Options.UseTextOptions = true;
            this.c_stt.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.c_stt.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.c_stt.AppearanceHeader.Options.UseTextOptions = true;
            this.c_stt.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.c_stt.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.c_stt.Caption = "STT";
            this.c_stt.FieldName = "STT";
            this.c_stt.Name = "c_stt";
            this.c_stt.Visible = true;
            this.c_stt.VisibleIndex = 0;
            this.c_stt.Width = 38;
            // 
            // c_loai_hop_dong
            // 
            this.c_loai_hop_dong.AppearanceHeader.Options.UseTextOptions = true;
            this.c_loai_hop_dong.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.c_loai_hop_dong.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.c_loai_hop_dong.Caption = "Loại hợp đồng";
            this.c_loai_hop_dong.FieldName = "LOAI_HOP_DONG";
            this.c_loai_hop_dong.Name = "c_loai_hop_dong";
            this.c_loai_hop_dong.Visible = true;
            this.c_loai_hop_dong.VisibleIndex = 1;
            this.c_loai_hop_dong.Width = 80;
            // 
            // c_ma_loai_hop_dong
            // 
            this.c_ma_loai_hop_dong.AppearanceHeader.Options.UseTextOptions = true;
            this.c_ma_loai_hop_dong.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.c_ma_loai_hop_dong.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.c_ma_loai_hop_dong.Caption = "Mã loại hơp đồng";
            this.c_ma_loai_hop_dong.FieldName = "MA_LOAI_HOP_DONG";
            this.c_ma_loai_hop_dong.Name = "c_ma_loai_hop_dong";
            this.c_ma_loai_hop_dong.Visible = true;
            this.c_ma_loai_hop_dong.VisibleIndex = 2;
            this.c_ma_loai_hop_dong.Width = 80;
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
            this.c_ti_le.Width = 80;
            // 
            // c_so_tien
            // 
            this.c_so_tien.AppearanceHeader.Options.UseTextOptions = true;
            this.c_so_tien.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.c_so_tien.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.c_so_tien.Caption = "Số tiền";
            this.c_so_tien.FieldName = "SO_TIEN";
            this.c_so_tien.Name = "c_so_tien";
            this.c_so_tien.Visible = true;
            this.c_so_tien.VisibleIndex = 4;
            this.c_so_tien.Width = 80;
            // 
            // c_hs_lns_yn
            // 
            this.c_hs_lns_yn.AppearanceHeader.Options.UseTextOptions = true;
            this.c_hs_lns_yn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.c_hs_lns_yn.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.c_hs_lns_yn.Caption = "Hệ số  LNS (Y/N)";
            this.c_hs_lns_yn.FieldName = "HS_LNS_YN";
            this.c_hs_lns_yn.Name = "c_hs_lns_yn";
            this.c_hs_lns_yn.Visible = true;
            this.c_hs_lns_yn.VisibleIndex = 5;
            this.c_hs_lns_yn.Width = 80;
            // 
            // c_an_ca_yn
            // 
            this.c_an_ca_yn.AppearanceHeader.Options.UseTextOptions = true;
            this.c_an_ca_yn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.c_an_ca_yn.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.c_an_ca_yn.Caption = "Ăn ca (Y/N)";
            this.c_an_ca_yn.FieldName = "AN_CA_YN";
            this.c_an_ca_yn.Name = "c_an_ca_yn";
            this.c_an_ca_yn.Visible = true;
            this.c_an_ca_yn.VisibleIndex = 6;
            this.c_an_ca_yn.Width = 80;
            // 
            // c_lcd_yn
            // 
            this.c_lcd_yn.AppearanceHeader.Options.UseTextOptions = true;
            this.c_lcd_yn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.c_lcd_yn.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.c_lcd_yn.Caption = "Lương CĐ (Y/N)";
            this.c_lcd_yn.FieldName = "LCD_YN";
            this.c_lcd_yn.Name = "c_lcd_yn";
            this.c_lcd_yn.Visible = true;
            this.c_lcd_yn.VisibleIndex = 7;
            this.c_lcd_yn.Width = 82;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.m_grc_dm_loai_hop_dong;
            this.gridView1.Name = "gridView1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.m_lbl_header);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(618, 47);
            this.panel2.TabIndex = 2;
            // 
            // m_lbl_header
            // 
            this.m_lbl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.m_lbl_header.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_header.Location = new System.Drawing.Point(0, 0);
            this.m_lbl_header.Name = "m_lbl_header";
            this.m_lbl_header.Size = new System.Drawing.Size(618, 44);
            this.m_lbl_header.TabIndex = 1;
            this.m_lbl_header.Text = "QUẢN LÝ VỊ TRÍ CÔNG TÁC";
            this.m_lbl_header.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.m_grc_dm_loai_hop_dong);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 47);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(618, 265);
            this.panel3.TabIndex = 3;
            // 
            // F104_dm_loai_hop_dong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 349);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "F104_dm_loai_hop_dong";
            this.Text = "F104_dm_loai_hop_dong";
            this.Load += new System.EventHandler(this.F104_dm_loai_hop_dong_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_dm_loai_hop_dong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_dm_loai_hop_dong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private IP.Core.IPData.DS_HT_PHAN_QUYEN_DETAILTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl m_grc_dm_loai_hop_dong;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv_dm_loai_hop_dong;
        private DevExpress.XtraGrid.Columns.GridColumn c_loai_hop_dong;
        private DevExpress.XtraGrid.Columns.GridColumn c_ma_loai_hop_dong;
        private DevExpress.XtraGrid.Columns.GridColumn c_ti_le;
        private DevExpress.XtraGrid.Columns.GridColumn c_so_tien;
        private DevExpress.XtraGrid.Columns.GridColumn c_hs_lns_yn;
        private DevExpress.XtraGrid.Columns.GridColumn c_an_ca_yn;
        private DevExpress.XtraGrid.Columns.GridColumn c_lcd_yn;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraGrid.Columns.GridColumn c_stt;
        private System.Windows.Forms.Label m_lbl_header;
        internal System.Windows.Forms.ImageList ImageList;
        internal SIS.Controls.Button.SiSButton m_cmd_add;
        internal SIS.Controls.Button.SiSButton m_cmd_edit;
        internal SIS.Controls.Button.SiSButton m_cmd_delete;

    }
}