namespace BKI_DichVuMatDat.NghiepVu
{
    partial class f352_quan_ly_cong_tac_excel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f352_quan_ly_cong_tac_excel));
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.m_cmd_luu = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.m_grc_v_gd_cong_tac = new DevExpress.XtraGrid.GridControl();
            this.m_grv_v_gd_cong_tac = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MA_NHAN_VIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ID_QUYET_DINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ID_DON_VI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ID_VI_TRI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ID_LOAI_CONG_TAC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAY_BAT_DAU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAY_KET_THUC = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_v_gd_cong_tac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_v_gd_cong_tac)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.m_cmd_luu);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl3.Location = new System.Drawing.Point(0, 399);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(820, 44);
            this.panelControl3.TabIndex = 8;
            // 
            // m_cmd_luu
            // 
            this.m_cmd_luu.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_luu.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_luu.Image")));
            this.m_cmd_luu.Location = new System.Drawing.Point(704, 2);
            this.m_cmd_luu.Name = "m_cmd_luu";
            this.m_cmd_luu.Size = new System.Drawing.Size(114, 40);
            this.m_cmd_luu.TabIndex = 2;
            this.m_cmd_luu.Text = "Lưu";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(820, 64);
            this.panelControl1.TabIndex = 9;
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
            // m_grc_v_gd_cong_tac
            // 
            this.m_grc_v_gd_cong_tac.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_v_gd_cong_tac.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc_v_gd_cong_tac.Location = new System.Drawing.Point(0, 64);
            this.m_grc_v_gd_cong_tac.MainView = this.m_grv_v_gd_cong_tac;
            this.m_grc_v_gd_cong_tac.Name = "m_grc_v_gd_cong_tac";
            this.m_grc_v_gd_cong_tac.Size = new System.Drawing.Size(820, 335);
            this.m_grc_v_gd_cong_tac.TabIndex = 10;
            this.m_grc_v_gd_cong_tac.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv_v_gd_cong_tac});
            // 
            // m_grv_v_gd_cong_tac
            // 
            this.m_grv_v_gd_cong_tac.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MA_NHAN_VIEN,
            this.ID_QUYET_DINH,
            this.ID_DON_VI,
            this.ID_VI_TRI,
            this.ID_LOAI_CONG_TAC,
            this.NGAY_BAT_DAU,
            this.NGAY_KET_THUC});
            this.m_grv_v_gd_cong_tac.CustomizationFormBounds = new System.Drawing.Rectangle(494, 344, 210, 172);
            this.m_grv_v_gd_cong_tac.GridControl = this.m_grc_v_gd_cong_tac;
            this.m_grv_v_gd_cong_tac.Name = "m_grv_v_gd_cong_tac";
            this.m_grv_v_gd_cong_tac.OptionsFind.AllowFindPanel = false;
            this.m_grv_v_gd_cong_tac.OptionsFind.AlwaysVisible = true;
            this.m_grv_v_gd_cong_tac.OptionsView.ShowFooter = true;
            // 
            // MA_NHAN_VIEN
            // 
            this.MA_NHAN_VIEN.AppearanceHeader.Options.UseTextOptions = true;
            this.MA_NHAN_VIEN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.MA_NHAN_VIEN.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.MA_NHAN_VIEN.Caption = "Mã NV";
            this.MA_NHAN_VIEN.FieldName = "MA_NHAN_VIEN";
            this.MA_NHAN_VIEN.Name = "MA_NHAN_VIEN";
            this.MA_NHAN_VIEN.OptionsColumn.AllowEdit = false;
            this.MA_NHAN_VIEN.Visible = true;
            this.MA_NHAN_VIEN.VisibleIndex = 0;
            // 
            // ID_QUYET_DINH
            // 
            this.ID_QUYET_DINH.AppearanceHeader.Options.UseTextOptions = true;
            this.ID_QUYET_DINH.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ID_QUYET_DINH.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ID_QUYET_DINH.Caption = "Mã quyết định";
            this.ID_QUYET_DINH.FieldName = "ID_QUYET_DINH";
            this.ID_QUYET_DINH.Name = "ID_QUYET_DINH";
            this.ID_QUYET_DINH.OptionsColumn.AllowEdit = false;
            this.ID_QUYET_DINH.Visible = true;
            this.ID_QUYET_DINH.VisibleIndex = 1;
            // 
            // ID_DON_VI
            // 
            this.ID_DON_VI.AppearanceHeader.Options.UseTextOptions = true;
            this.ID_DON_VI.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ID_DON_VI.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ID_DON_VI.Caption = "Mã đơn vị";
            this.ID_DON_VI.FieldName = "ID_DON_VI";
            this.ID_DON_VI.Name = "ID_DON_VI";
            this.ID_DON_VI.OptionsColumn.AllowEdit = false;
            this.ID_DON_VI.Visible = true;
            this.ID_DON_VI.VisibleIndex = 2;
            // 
            // ID_VI_TRI
            // 
            this.ID_VI_TRI.AppearanceHeader.Options.UseTextOptions = true;
            this.ID_VI_TRI.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ID_VI_TRI.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ID_VI_TRI.Caption = "Mã vị trí";
            this.ID_VI_TRI.FieldName = "ID_VI_TRI";
            this.ID_VI_TRI.Name = "ID_VI_TRI";
            this.ID_VI_TRI.OptionsColumn.AllowEdit = false;
            this.ID_VI_TRI.Visible = true;
            this.ID_VI_TRI.VisibleIndex = 3;
            // 
            // ID_LOAI_CONG_TAC
            // 
            this.ID_LOAI_CONG_TAC.AppearanceHeader.Options.UseTextOptions = true;
            this.ID_LOAI_CONG_TAC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ID_LOAI_CONG_TAC.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ID_LOAI_CONG_TAC.Caption = "Mã loại công tác";
            this.ID_LOAI_CONG_TAC.FieldName = "ID_LOAI_CONG_TAC";
            this.ID_LOAI_CONG_TAC.Name = "ID_LOAI_CONG_TAC";
            this.ID_LOAI_CONG_TAC.OptionsColumn.AllowEdit = false;
            this.ID_LOAI_CONG_TAC.Visible = true;
            this.ID_LOAI_CONG_TAC.VisibleIndex = 4;
            // 
            // NGAY_BAT_DAU
            // 
            this.NGAY_BAT_DAU.AppearanceCell.Options.UseTextOptions = true;
            this.NGAY_BAT_DAU.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NGAY_BAT_DAU.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.NGAY_BAT_DAU.AppearanceHeader.Options.UseTextOptions = true;
            this.NGAY_BAT_DAU.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NGAY_BAT_DAU.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.NGAY_BAT_DAU.Caption = "Ngày bắt đầu";
            this.NGAY_BAT_DAU.DisplayFormat.FormatString = "g";
            this.NGAY_BAT_DAU.FieldName = "NGAY_BAT_DAU";
            this.NGAY_BAT_DAU.Name = "NGAY_BAT_DAU";
            this.NGAY_BAT_DAU.OptionsColumn.AllowEdit = false;
            this.NGAY_BAT_DAU.Visible = true;
            this.NGAY_BAT_DAU.VisibleIndex = 5;
            // 
            // NGAY_KET_THUC
            // 
            this.NGAY_KET_THUC.AppearanceCell.Options.UseTextOptions = true;
            this.NGAY_KET_THUC.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NGAY_KET_THUC.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.NGAY_KET_THUC.AppearanceHeader.Options.UseTextOptions = true;
            this.NGAY_KET_THUC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NGAY_KET_THUC.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.NGAY_KET_THUC.Caption = "Ngày kết thúc";
            this.NGAY_KET_THUC.DisplayFormat.FormatString = "g";
            this.NGAY_KET_THUC.FieldName = "NGAY_KET_THUC";
            this.NGAY_KET_THUC.Name = "NGAY_KET_THUC";
            this.NGAY_KET_THUC.OptionsColumn.AllowEdit = false;
            this.NGAY_KET_THUC.Visible = true;
            this.NGAY_KET_THUC.VisibleIndex = 6;
            // 
            // f352_quan_ly_cong_tac_excel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 443);
            this.Controls.Add(this.m_grc_v_gd_cong_tac);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl3);
            this.Name = "f352_quan_ly_cong_tac_excel";
            this.Text = "f352_quan_ly_cong_tac_excel";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_v_gd_cong_tac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_v_gd_cong_tac)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.SimpleButton m_cmd_luu;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl m_grc_v_gd_cong_tac;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv_v_gd_cong_tac;
        private DevExpress.XtraGrid.Columns.GridColumn MA_NHAN_VIEN;
        private DevExpress.XtraGrid.Columns.GridColumn ID_QUYET_DINH;
        private DevExpress.XtraGrid.Columns.GridColumn ID_DON_VI;
        private DevExpress.XtraGrid.Columns.GridColumn ID_VI_TRI;
        private DevExpress.XtraGrid.Columns.GridColumn ID_LOAI_CONG_TAC;
        private DevExpress.XtraGrid.Columns.GridColumn NGAY_BAT_DAU;
        private DevExpress.XtraGrid.Columns.GridColumn NGAY_KET_THUC;
    }
}