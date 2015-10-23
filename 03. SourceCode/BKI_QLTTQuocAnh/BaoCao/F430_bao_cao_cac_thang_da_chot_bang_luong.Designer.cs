namespace BKI_DichVuMatDat.BaoCao
{
    partial class F430_bao_cao_cac_thang_da_chot_bang_luong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F430_bao_cao_cac_thang_da_chot_bang_luong));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.m_grc_bc_cac_thang_da_chot_bang_luong = new DevExpress.XtraGrid.GridControl();
            this.m_grv_bc_cac_thang_da_chot_bang_luong = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.THANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NAM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGUOI_CHOT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAY_CHOT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_cmd_insert = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_update = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_delete = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_xuat_excel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_bc_cac_thang_da_chot_bang_luong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_bc_cac_thang_da_chot_bang_luong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.m_grc_bc_cac_thang_da_chot_bang_luong);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1087, 488);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // m_grc_bc_cac_thang_da_chot_bang_luong
            // 
            this.m_grc_bc_cac_thang_da_chot_bang_luong.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_bc_cac_thang_da_chot_bang_luong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_grc_bc_cac_thang_da_chot_bang_luong.Location = new System.Drawing.Point(12, 39);
            this.m_grc_bc_cac_thang_da_chot_bang_luong.MainView = this.m_grv_bc_cac_thang_da_chot_bang_luong;
            this.m_grc_bc_cac_thang_da_chot_bang_luong.Name = "m_grc_bc_cac_thang_da_chot_bang_luong";
            this.m_grc_bc_cac_thang_da_chot_bang_luong.Size = new System.Drawing.Size(1063, 437);
            this.m_grc_bc_cac_thang_da_chot_bang_luong.TabIndex = 4;
            this.m_grc_bc_cac_thang_da_chot_bang_luong.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv_bc_cac_thang_da_chot_bang_luong});
            // 
            // m_grv_bc_cac_thang_da_chot_bang_luong
            // 
            this.m_grv_bc_cac_thang_da_chot_bang_luong.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.STT,
            this.THANG,
            this.NAM,
            this.NGUOI_CHOT,
            this.NGAY_CHOT});
            this.m_grv_bc_cac_thang_da_chot_bang_luong.CustomizationFormBounds = new System.Drawing.Rectangle(723, 270, 210, 172);
            this.m_grv_bc_cac_thang_da_chot_bang_luong.GridControl = this.m_grc_bc_cac_thang_da_chot_bang_luong;
            this.m_grv_bc_cac_thang_da_chot_bang_luong.Name = "m_grv_bc_cac_thang_da_chot_bang_luong";
            this.m_grv_bc_cac_thang_da_chot_bang_luong.OptionsFind.AllowFindPanel = false;
            this.m_grv_bc_cac_thang_da_chot_bang_luong.OptionsFind.AlwaysVisible = true;
            this.m_grv_bc_cac_thang_da_chot_bang_luong.OptionsView.ShowFooter = true;
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
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
            this.STT.OptionsColumn.AllowEdit = false;
            this.STT.Visible = true;
            this.STT.VisibleIndex = 0;
            this.STT.Width = 38;
            // 
            // THANG
            // 
            this.THANG.AppearanceCell.Options.UseTextOptions = true;
            this.THANG.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.THANG.AppearanceHeader.Options.UseTextOptions = true;
            this.THANG.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.THANG.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.THANG.Caption = "Tháng";
            this.THANG.FieldName = "THANG";
            this.THANG.Name = "THANG";
            this.THANG.OptionsColumn.AllowEdit = false;
            this.THANG.Visible = true;
            this.THANG.VisibleIndex = 1;
            this.THANG.Width = 83;
            // 
            // NAM
            // 
            this.NAM.AppearanceHeader.Options.UseTextOptions = true;
            this.NAM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NAM.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.NAM.Caption = "Năm";
            this.NAM.FieldName = "NAM";
            this.NAM.Name = "NAM";
            this.NAM.OptionsColumn.AllowEdit = false;
            this.NAM.Visible = true;
            this.NAM.VisibleIndex = 2;
            this.NAM.Width = 87;
            // 
            // NGUOI_CHOT
            // 
            this.NGUOI_CHOT.AppearanceHeader.Options.UseTextOptions = true;
            this.NGUOI_CHOT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NGUOI_CHOT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.NGUOI_CHOT.Caption = "Người chốt";
            this.NGUOI_CHOT.FieldName = "NGUOI_CHOT";
            this.NGUOI_CHOT.Name = "NGUOI_CHOT";
            this.NGUOI_CHOT.OptionsColumn.AllowEdit = false;
            this.NGUOI_CHOT.Visible = true;
            this.NGUOI_CHOT.VisibleIndex = 3;
            this.NGUOI_CHOT.Width = 87;
            // 
            // NGAY_CHOT
            // 
            this.NGAY_CHOT.AppearanceHeader.Options.UseTextOptions = true;
            this.NGAY_CHOT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NGAY_CHOT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.NGAY_CHOT.Caption = "Ngày chốt";
            this.NGAY_CHOT.FieldName = "NGAY_CHOT";
            this.NGAY_CHOT.Name = "NGAY_CHOT";
            this.NGAY_CHOT.OptionsColumn.AllowEdit = false;
            this.NGAY_CHOT.Visible = true;
            this.NGAY_CHOT.VisibleIndex = 4;
            this.NGAY_CHOT.Width = 87;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1087, 488);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem1.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem1.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem1.Control = this.m_grc_bc_cac_thang_da_chot_bang_luong;
            this.layoutControlItem1.CustomizationFormText = "CÁC THÁNG ĐÃ CHỐT BẢNG LƯƠNG";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1067, 468);
            this.layoutControlItem1.Text = "CÁC THÁNG ĐÃ CHỐT BẢNG LƯƠNG";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(358, 24);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_cmd_insert);
            this.panel1.Controls.Add(this.m_cmd_update);
            this.panel1.Controls.Add(this.m_cmd_delete);
            this.panel1.Controls.Add(this.m_cmd_xuat_excel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 488);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1087, 39);
            this.panel1.TabIndex = 3;
            // 
            // m_cmd_insert
            // 
            this.m_cmd_insert.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_insert.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_insert.Image")));
            this.m_cmd_insert.Location = new System.Drawing.Point(623, 0);
            this.m_cmd_insert.Name = "m_cmd_insert";
            this.m_cmd_insert.Size = new System.Drawing.Size(116, 39);
            this.m_cmd_insert.TabIndex = 26;
            this.m_cmd_insert.Text = "&Thêm";
            this.m_cmd_insert.Visible = false;
            // 
            // m_cmd_update
            // 
            this.m_cmd_update.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_update.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_update.Image")));
            this.m_cmd_update.Location = new System.Drawing.Point(739, 0);
            this.m_cmd_update.Name = "m_cmd_update";
            this.m_cmd_update.Size = new System.Drawing.Size(116, 39);
            this.m_cmd_update.TabIndex = 25;
            this.m_cmd_update.Text = "&Sửa";
            this.m_cmd_update.Visible = false;
            // 
            // m_cmd_delete
            // 
            this.m_cmd_delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_delete.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_delete.Image")));
            this.m_cmd_delete.Location = new System.Drawing.Point(855, 0);
            this.m_cmd_delete.Name = "m_cmd_delete";
            this.m_cmd_delete.Size = new System.Drawing.Size(116, 39);
            this.m_cmd_delete.TabIndex = 24;
            this.m_cmd_delete.Text = "&Xóa";
            // 
            // m_cmd_xuat_excel
            // 
            this.m_cmd_xuat_excel.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_xuat_excel.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_xuat_excel.Image")));
            this.m_cmd_xuat_excel.Location = new System.Drawing.Point(971, 0);
            this.m_cmd_xuat_excel.Name = "m_cmd_xuat_excel";
            this.m_cmd_xuat_excel.Size = new System.Drawing.Size(116, 39);
            this.m_cmd_xuat_excel.TabIndex = 23;
            this.m_cmd_xuat_excel.Text = "&Xuất Excel";
            this.m_cmd_xuat_excel.Visible = false;
            // 
            // F430_bao_cao_cac_thang_da_chot_bang_luong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 527);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.panel1);
            this.Name = "F430_bao_cao_cac_thang_da_chot_bang_luong";
            this.Text = "F430 - Các tháng đã chốt bảng lương";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_bc_cac_thang_da_chot_bang_luong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_bc_cac_thang_da_chot_bang_luong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton m_cmd_insert;
        private DevExpress.XtraEditors.SimpleButton m_cmd_update;
        private DevExpress.XtraEditors.SimpleButton m_cmd_delete;
        private DevExpress.XtraEditors.SimpleButton m_cmd_xuat_excel;
        private DevExpress.XtraGrid.GridControl m_grc_bc_cac_thang_da_chot_bang_luong;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv_bc_cac_thang_da_chot_bang_luong;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
        private DevExpress.XtraGrid.Columns.GridColumn THANG;
        private DevExpress.XtraGrid.Columns.GridColumn NAM;
        private DevExpress.XtraGrid.Columns.GridColumn NGUOI_CHOT;
        private DevExpress.XtraGrid.Columns.GridColumn NGAY_CHOT;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;

    }
}