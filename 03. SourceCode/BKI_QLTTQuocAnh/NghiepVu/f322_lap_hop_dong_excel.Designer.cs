namespace BKI_DichVuMatDat.NghiepVu
{
    partial class f322_lap_hop_dong_excel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f322_lap_hop_dong_excel));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.m_cmd_luu = new DevExpress.XtraEditors.SimpleButton();
            this.m_grc_lap_hd = new DevExpress.XtraGrid.GridControl();
            this.m_grv_lap_hd = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MA_NHAN_VIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MA_HOP_DONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LOAI_HOP_DONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CHUC_DANH_LCD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MUC_LCD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CHUC_DANH_LNS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MUC_LUONG_NS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAY_BAT_DAU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAY_KET_THUC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAY_KI_HOP_DONG = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_lap_hd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_lap_hd)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(959, 64);
            this.panelControl1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "DANH SÁCH IMPORT TỪ EXCEL";
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.m_cmd_luu);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl3.Location = new System.Drawing.Point(0, 464);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(959, 44);
            this.panelControl3.TabIndex = 7;
            // 
            // m_cmd_luu
            // 
            this.m_cmd_luu.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_luu.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_luu.Image")));
            this.m_cmd_luu.Location = new System.Drawing.Point(843, 2);
            this.m_cmd_luu.Name = "m_cmd_luu";
            this.m_cmd_luu.Size = new System.Drawing.Size(114, 40);
            this.m_cmd_luu.TabIndex = 2;
            this.m_cmd_luu.Text = "Lưu";
            // 
            // m_grc_lap_hd
            // 
            this.m_grc_lap_hd.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_lap_hd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc_lap_hd.Location = new System.Drawing.Point(0, 64);
            this.m_grc_lap_hd.MainView = this.m_grv_lap_hd;
            this.m_grc_lap_hd.Name = "m_grc_lap_hd";
            this.m_grc_lap_hd.Size = new System.Drawing.Size(959, 400);
            this.m_grc_lap_hd.TabIndex = 8;
            this.m_grc_lap_hd.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv_lap_hd});
            // 
            // m_grv_lap_hd
            // 
            this.m_grv_lap_hd.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.MA_NHAN_VIEN,
            this.MA_HOP_DONG,
            this.LOAI_HOP_DONG,
            this.CHUC_DANH_LCD,
            this.MUC_LCD,
            this.CHUC_DANH_LNS,
            this.MUC_LUONG_NS,
            this.NGAY_BAT_DAU,
            this.NGAY_KET_THUC,
            this.NGAY_KI_HOP_DONG});
            this.m_grv_lap_hd.GridControl = this.m_grc_lap_hd;
            this.m_grv_lap_hd.Name = "m_grv_lap_hd";
            this.m_grv_lap_hd.OptionsFind.AllowFindPanel = false;
            this.m_grv_lap_hd.OptionsFind.AlwaysVisible = true;
            // 
            // colID
            // 
            this.colID.Caption = "ID";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            // 
            // MA_NHAN_VIEN
            // 
            this.MA_NHAN_VIEN.AppearanceHeader.Options.UseTextOptions = true;
            this.MA_NHAN_VIEN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.MA_NHAN_VIEN.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.MA_NHAN_VIEN.Caption = "Mã nhân viên";
            this.MA_NHAN_VIEN.FieldName = "MA_NHAN_VIEN";
            this.MA_NHAN_VIEN.Name = "MA_NHAN_VIEN";
            this.MA_NHAN_VIEN.OptionsColumn.AllowEdit = false;
            this.MA_NHAN_VIEN.Visible = true;
            this.MA_NHAN_VIEN.VisibleIndex = 0;
            this.MA_NHAN_VIEN.Width = 50;
            // 
            // MA_HOP_DONG
            // 
            this.MA_HOP_DONG.AppearanceHeader.Options.UseTextOptions = true;
            this.MA_HOP_DONG.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.MA_HOP_DONG.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.MA_HOP_DONG.Caption = "Mã hợp đồng";
            this.MA_HOP_DONG.FieldName = "MA_HOP_DONG";
            this.MA_HOP_DONG.Name = "MA_HOP_DONG";
            this.MA_HOP_DONG.OptionsColumn.AllowEdit = false;
            this.MA_HOP_DONG.Visible = true;
            this.MA_HOP_DONG.VisibleIndex = 1;
            // 
            // LOAI_HOP_DONG
            // 
            this.LOAI_HOP_DONG.AppearanceHeader.Options.UseTextOptions = true;
            this.LOAI_HOP_DONG.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.LOAI_HOP_DONG.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.LOAI_HOP_DONG.Caption = "Loại hợp đồng";
            this.LOAI_HOP_DONG.FieldName = "LOAI_HOP_DONG";
            this.LOAI_HOP_DONG.Name = "LOAI_HOP_DONG";
            this.LOAI_HOP_DONG.OptionsColumn.AllowEdit = false;
            this.LOAI_HOP_DONG.Visible = true;
            this.LOAI_HOP_DONG.VisibleIndex = 2;
            // 
            // CHUC_DANH_LCD
            // 
            this.CHUC_DANH_LCD.AppearanceHeader.Options.UseTextOptions = true;
            this.CHUC_DANH_LCD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CHUC_DANH_LCD.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.CHUC_DANH_LCD.Caption = "Chức danh LCD";
            this.CHUC_DANH_LCD.FieldName = "CHUC_DANH_LCD";
            this.CHUC_DANH_LCD.Name = "CHUC_DANH_LCD";
            this.CHUC_DANH_LCD.OptionsColumn.AllowEdit = false;
            this.CHUC_DANH_LCD.Visible = true;
            this.CHUC_DANH_LCD.VisibleIndex = 3;
            // 
            // MUC_LCD
            // 
            this.MUC_LCD.AppearanceHeader.Options.UseTextOptions = true;
            this.MUC_LCD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.MUC_LCD.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.MUC_LCD.Caption = "Mức LCD";
            this.MUC_LCD.FieldName = "MUC_LCD";
            this.MUC_LCD.Name = "MUC_LCD";
            this.MUC_LCD.OptionsColumn.AllowEdit = false;
            this.MUC_LCD.Visible = true;
            this.MUC_LCD.VisibleIndex = 4;
            // 
            // CHUC_DANH_LNS
            // 
            this.CHUC_DANH_LNS.AppearanceHeader.Options.UseTextOptions = true;
            this.CHUC_DANH_LNS.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CHUC_DANH_LNS.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.CHUC_DANH_LNS.Caption = "Chức danh LNS";
            this.CHUC_DANH_LNS.FieldName = "CHUC_DANH_LNS";
            this.CHUC_DANH_LNS.Name = "CHUC_DANH_LNS";
            this.CHUC_DANH_LNS.OptionsColumn.AllowEdit = false;
            this.CHUC_DANH_LNS.Visible = true;
            this.CHUC_DANH_LNS.VisibleIndex = 5;
            // 
            // MUC_LUONG_NS
            // 
            this.MUC_LUONG_NS.AppearanceHeader.Options.UseTextOptions = true;
            this.MUC_LUONG_NS.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.MUC_LUONG_NS.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.MUC_LUONG_NS.Caption = "Mức LNS";
            this.MUC_LUONG_NS.FieldName = "MUC_LUONG_NS";
            this.MUC_LUONG_NS.Name = "MUC_LUONG_NS";
            this.MUC_LUONG_NS.OptionsColumn.AllowEdit = false;
            this.MUC_LUONG_NS.Visible = true;
            this.MUC_LUONG_NS.VisibleIndex = 6;
            // 
            // NGAY_BAT_DAU
            // 
            this.NGAY_BAT_DAU.AppearanceHeader.Options.UseTextOptions = true;
            this.NGAY_BAT_DAU.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NGAY_BAT_DAU.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.NGAY_BAT_DAU.Caption = "Ngày bắt đầu";
            this.NGAY_BAT_DAU.DisplayFormat.FormatString = "g";
            this.NGAY_BAT_DAU.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.NGAY_BAT_DAU.FieldName = "NGAY_BAT_DAU";
            this.NGAY_BAT_DAU.Name = "NGAY_BAT_DAU";
            this.NGAY_BAT_DAU.OptionsColumn.AllowEdit = false;
            this.NGAY_BAT_DAU.Visible = true;
            this.NGAY_BAT_DAU.VisibleIndex = 7;
            // 
            // NGAY_KET_THUC
            // 
            this.NGAY_KET_THUC.AppearanceHeader.Options.UseTextOptions = true;
            this.NGAY_KET_THUC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NGAY_KET_THUC.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.NGAY_KET_THUC.Caption = "Ngày kết thúc";
            this.NGAY_KET_THUC.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.NGAY_KET_THUC.FieldName = "NGAY_KET_THUC";
            this.NGAY_KET_THUC.Name = "NGAY_KET_THUC";
            this.NGAY_KET_THUC.OptionsColumn.AllowEdit = false;
            this.NGAY_KET_THUC.Visible = true;
            this.NGAY_KET_THUC.VisibleIndex = 8;
            // 
            // NGAY_KI_HOP_DONG
            // 
            this.NGAY_KI_HOP_DONG.AppearanceHeader.Options.UseTextOptions = true;
            this.NGAY_KI_HOP_DONG.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NGAY_KI_HOP_DONG.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.NGAY_KI_HOP_DONG.Caption = "Ngày kí hợp đồng";
            this.NGAY_KI_HOP_DONG.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.NGAY_KI_HOP_DONG.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.NGAY_KI_HOP_DONG.FieldName = "NGAY_KI_HOP_DONG";
            this.NGAY_KI_HOP_DONG.Name = "NGAY_KI_HOP_DONG";
            this.NGAY_KI_HOP_DONG.OptionsColumn.AllowEdit = false;
            this.NGAY_KI_HOP_DONG.Visible = true;
            this.NGAY_KI_HOP_DONG.VisibleIndex = 9;
            // 
            // f322_lap_hop_dong_excel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 508);
            this.Controls.Add(this.m_grc_lap_hd);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl1);
            this.Name = "f322_lap_hop_dong_excel";
            this.Text = "F322 - Lập hợp đồng excel";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_lap_hd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_lap_hd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.SimpleButton m_cmd_luu;
        private DevExpress.XtraGrid.GridControl m_grc_lap_hd;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv_lap_hd;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn MA_NHAN_VIEN;
        private DevExpress.XtraGrid.Columns.GridColumn MA_HOP_DONG;
        private DevExpress.XtraGrid.Columns.GridColumn LOAI_HOP_DONG;
        private DevExpress.XtraGrid.Columns.GridColumn NGAY_BAT_DAU;
        private DevExpress.XtraGrid.Columns.GridColumn CHUC_DANH_LCD;
        private DevExpress.XtraGrid.Columns.GridColumn MUC_LCD;
        private DevExpress.XtraGrid.Columns.GridColumn CHUC_DANH_LNS;
        private DevExpress.XtraGrid.Columns.GridColumn MUC_LUONG_NS;
        private DevExpress.XtraGrid.Columns.GridColumn NGAY_KET_THUC;
        private DevExpress.XtraGrid.Columns.GridColumn NGAY_KI_HOP_DONG;
    }
}