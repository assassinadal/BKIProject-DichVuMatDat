namespace BKI_DichVuMatDat.NghiepVu.NhanSu
{
    partial class f327_lap_hop_dong_v3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f327_lap_hop_dong_v3));
            this.m_tree_don_vi = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.m_grc = new DevExpress.XtraGrid.GridControl();
            this.m_grv = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MA_NV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HO_TEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MA_HOP_DONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LOAI_HOP_DONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAY_BAT_DAU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAY_KET_THUC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAY_KY_HOP_DONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAY_LAP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.m_cmd_print = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_insert = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_update = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_delete = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_xuat_excel = new DevExpress.XtraEditors.SimpleButton();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.m_tree_don_vi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_tree_don_vi
            // 
            this.m_tree_don_vi.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_tree_don_vi.Appearance.HeaderPanel.Options.UseFont = true;
            this.m_tree_don_vi.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1,
            this.treeListColumn2});
            this.m_tree_don_vi.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_tree_don_vi.Location = new System.Drawing.Point(0, 0);
            this.m_tree_don_vi.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.m_tree_don_vi.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.m_tree_don_vi.LookAndFeel.UseWindowsXPTheme = true;
            this.m_tree_don_vi.Name = "m_tree_don_vi";
            this.m_tree_don_vi.OptionsBehavior.Editable = false;
            this.m_tree_don_vi.Size = new System.Drawing.Size(240, 431);
            this.m_tree_don_vi.TabIndex = 7;
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "Đơn vị";
            this.treeListColumn1.FieldName = "TEN_DON_VI";
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            this.treeListColumn1.Width = 198;
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.Caption = "SL";
            this.treeListColumn2.FieldName = "SO_LUONG_NS_DANG_CONG_TAC";
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.Visible = true;
            this.treeListColumn2.VisibleIndex = 1;
            this.treeListColumn2.Width = 24;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.m_grc);
            this.panelControl2.Controls.Add(this.panelControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(240, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(614, 431);
            this.panelControl2.TabIndex = 8;
            // 
            // m_grc
            // 
            this.m_grc.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc.Location = new System.Drawing.Point(2, 2);
            this.m_grc.MainView = this.m_grv;
            this.m_grc.Name = "m_grc";
            this.m_grc.Size = new System.Drawing.Size(610, 379);
            this.m_grc.TabIndex = 7;
            this.m_grc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv});
            // 
            // m_grv
            // 
            this.m_grv.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MA_NV,
            this.HO_TEN,
            this.MA_HOP_DONG,
            this.LOAI_HOP_DONG,
            this.NGAY_BAT_DAU,
            this.NGAY_KET_THUC,
            this.NGAY_KY_HOP_DONG,
            this.gridColumn2,
            this.gridColumn1,
            this.NGAY_LAP,
            this.gridColumn3});
            this.m_grv.GridControl = this.m_grc;
            this.m_grv.Name = "m_grv";
            this.m_grv.OptionsFind.AllowFindPanel = false;
            this.m_grv.OptionsFind.AlwaysVisible = true;
            // 
            // MA_NV
            // 
            this.MA_NV.AppearanceCell.Options.UseTextOptions = true;
            this.MA_NV.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.MA_NV.AppearanceHeader.Options.UseTextOptions = true;
            this.MA_NV.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.MA_NV.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.MA_NV.Caption = "Mã NV";
            this.MA_NV.FieldName = "MA_NV";
            this.MA_NV.Name = "MA_NV";
            this.MA_NV.OptionsColumn.AllowEdit = false;
            this.MA_NV.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "MA_NV", "{0:n0}")});
            this.MA_NV.Visible = true;
            this.MA_NV.VisibleIndex = 0;
            this.MA_NV.Width = 48;
            // 
            // HO_TEN
            // 
            this.HO_TEN.AppearanceHeader.Options.UseTextOptions = true;
            this.HO_TEN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.HO_TEN.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.HO_TEN.Caption = "Họ tên";
            this.HO_TEN.FieldName = "HO_TEN";
            this.HO_TEN.Name = "HO_TEN";
            this.HO_TEN.OptionsColumn.AllowEdit = false;
            this.HO_TEN.Visible = true;
            this.HO_TEN.VisibleIndex = 1;
            this.HO_TEN.Width = 118;
            // 
            // MA_HOP_DONG
            // 
            this.MA_HOP_DONG.AppearanceHeader.Options.UseTextOptions = true;
            this.MA_HOP_DONG.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.MA_HOP_DONG.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.MA_HOP_DONG.Caption = "Mã HĐ";
            this.MA_HOP_DONG.FieldName = "MA_HOP_DONG";
            this.MA_HOP_DONG.Name = "MA_HOP_DONG";
            this.MA_HOP_DONG.OptionsColumn.AllowEdit = false;
            this.MA_HOP_DONG.Visible = true;
            this.MA_HOP_DONG.VisibleIndex = 2;
            this.MA_HOP_DONG.Width = 44;
            // 
            // LOAI_HOP_DONG
            // 
            this.LOAI_HOP_DONG.AppearanceHeader.Options.UseTextOptions = true;
            this.LOAI_HOP_DONG.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.LOAI_HOP_DONG.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.LOAI_HOP_DONG.Caption = "Loại HĐ";
            this.LOAI_HOP_DONG.FieldName = "LOAI_HOP_DONG";
            this.LOAI_HOP_DONG.Name = "LOAI_HOP_DONG";
            this.LOAI_HOP_DONG.OptionsColumn.AllowEdit = false;
            this.LOAI_HOP_DONG.Visible = true;
            this.LOAI_HOP_DONG.VisibleIndex = 3;
            this.LOAI_HOP_DONG.Width = 93;
            // 
            // NGAY_BAT_DAU
            // 
            this.NGAY_BAT_DAU.AppearanceCell.Options.UseTextOptions = true;
            this.NGAY_BAT_DAU.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NGAY_BAT_DAU.AppearanceHeader.Options.UseTextOptions = true;
            this.NGAY_BAT_DAU.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NGAY_BAT_DAU.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.NGAY_BAT_DAU.Caption = "Ngày bắt đầu";
            this.NGAY_BAT_DAU.FieldName = "NGAY_BAT_DAU";
            this.NGAY_BAT_DAU.Name = "NGAY_BAT_DAU";
            this.NGAY_BAT_DAU.OptionsColumn.AllowEdit = false;
            this.NGAY_BAT_DAU.Visible = true;
            this.NGAY_BAT_DAU.VisibleIndex = 4;
            this.NGAY_BAT_DAU.Width = 42;
            // 
            // NGAY_KET_THUC
            // 
            this.NGAY_KET_THUC.AppearanceCell.Options.UseTextOptions = true;
            this.NGAY_KET_THUC.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NGAY_KET_THUC.AppearanceHeader.Options.UseTextOptions = true;
            this.NGAY_KET_THUC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NGAY_KET_THUC.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.NGAY_KET_THUC.Caption = "Ngày kết thúc";
            this.NGAY_KET_THUC.FieldName = "NGAY_KET_THUC";
            this.NGAY_KET_THUC.Name = "NGAY_KET_THUC";
            this.NGAY_KET_THUC.OptionsColumn.AllowEdit = false;
            this.NGAY_KET_THUC.Visible = true;
            this.NGAY_KET_THUC.VisibleIndex = 5;
            this.NGAY_KET_THUC.Width = 42;
            // 
            // NGAY_KY_HOP_DONG
            // 
            this.NGAY_KY_HOP_DONG.AppearanceCell.Options.UseTextOptions = true;
            this.NGAY_KY_HOP_DONG.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NGAY_KY_HOP_DONG.AppearanceHeader.Options.UseTextOptions = true;
            this.NGAY_KY_HOP_DONG.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NGAY_KY_HOP_DONG.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.NGAY_KY_HOP_DONG.Caption = "Ngày ký";
            this.NGAY_KY_HOP_DONG.FieldName = "NGAY_KY_HOP_DONG";
            this.NGAY_KY_HOP_DONG.Name = "NGAY_KY_HOP_DONG";
            this.NGAY_KY_HOP_DONG.OptionsColumn.AllowEdit = false;
            this.NGAY_KY_HOP_DONG.Visible = true;
            this.NGAY_KY_HOP_DONG.VisibleIndex = 6;
            this.NGAY_KY_HOP_DONG.Width = 42;
            // 
            // NGAY_LAP
            // 
            this.NGAY_LAP.AppearanceCell.Options.UseTextOptions = true;
            this.NGAY_LAP.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NGAY_LAP.AppearanceHeader.Options.UseTextOptions = true;
            this.NGAY_LAP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NGAY_LAP.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.NGAY_LAP.Caption = "Chức vụ";
            this.NGAY_LAP.FieldName = "CHUC_VU";
            this.NGAY_LAP.Name = "NGAY_LAP";
            this.NGAY_LAP.OptionsColumn.AllowEdit = false;
            this.NGAY_LAP.Visible = true;
            this.NGAY_LAP.VisibleIndex = 7;
            this.NGAY_LAP.Width = 39;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.m_cmd_print);
            this.panelControl1.Controls.Add(this.m_cmd_insert);
            this.panelControl1.Controls.Add(this.m_cmd_update);
            this.panelControl1.Controls.Add(this.m_cmd_delete);
            this.panelControl1.Controls.Add(this.m_cmd_xuat_excel);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(2, 381);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(610, 48);
            this.panelControl1.TabIndex = 6;
            // 
            // m_cmd_print
            // 
            this.m_cmd_print.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_print.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_print.Image")));
            this.m_cmd_print.Location = new System.Drawing.Point(28, 2);
            this.m_cmd_print.Name = "m_cmd_print";
            this.m_cmd_print.Size = new System.Drawing.Size(116, 44);
            this.m_cmd_print.TabIndex = 34;
            this.m_cmd_print.Text = "&In hợp đồng";
            // 
            // m_cmd_insert
            // 
            this.m_cmd_insert.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_insert.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_insert.Image")));
            this.m_cmd_insert.Location = new System.Drawing.Point(144, 2);
            this.m_cmd_insert.Name = "m_cmd_insert";
            this.m_cmd_insert.Size = new System.Drawing.Size(116, 44);
            this.m_cmd_insert.TabIndex = 7;
            this.m_cmd_insert.Text = "&Thêm";
            // 
            // m_cmd_update
            // 
            this.m_cmd_update.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_update.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_update.Image")));
            this.m_cmd_update.Location = new System.Drawing.Point(260, 2);
            this.m_cmd_update.Name = "m_cmd_update";
            this.m_cmd_update.Size = new System.Drawing.Size(116, 44);
            this.m_cmd_update.TabIndex = 6;
            this.m_cmd_update.Text = "&Sửa";
            // 
            // m_cmd_delete
            // 
            this.m_cmd_delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_delete.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_delete.Image")));
            this.m_cmd_delete.Location = new System.Drawing.Point(376, 2);
            this.m_cmd_delete.Name = "m_cmd_delete";
            this.m_cmd_delete.Size = new System.Drawing.Size(116, 44);
            this.m_cmd_delete.TabIndex = 5;
            this.m_cmd_delete.Text = "&Xóa";
            // 
            // m_cmd_xuat_excel
            // 
            this.m_cmd_xuat_excel.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_xuat_excel.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_xuat_excel.Image")));
            this.m_cmd_xuat_excel.Location = new System.Drawing.Point(492, 2);
            this.m_cmd_xuat_excel.Name = "m_cmd_xuat_excel";
            this.m_cmd_xuat_excel.Size = new System.Drawing.Size(116, 44);
            this.m_cmd_xuat_excel.TabIndex = 4;
            this.m_cmd_xuat_excel.Text = "&Xuất Excel";
            this.m_cmd_xuat_excel.Visible = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mức LCD";
            this.gridColumn1.FieldName = "MUC_LCD";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 8;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Mã LCD";
            this.gridColumn2.FieldName = "MA_LCD";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 7;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Số tiền";
            this.gridColumn3.FieldName = "SO_TIEN_LCD";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 10;
            // 
            // f327_lap_hop_dong_v3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 431);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.m_tree_don_vi);
            this.Name = "f327_lap_hop_dong_v3";
            this.Text = "F319 - Lập hợp đồng";
            ((System.ComponentModel.ISupportInitialize)(this.m_tree_don_vi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_grc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList m_tree_don_vi;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl m_grc;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv;
        private DevExpress.XtraGrid.Columns.GridColumn MA_NV;
        private DevExpress.XtraGrid.Columns.GridColumn HO_TEN;
        private DevExpress.XtraGrid.Columns.GridColumn MA_HOP_DONG;
        private DevExpress.XtraGrid.Columns.GridColumn LOAI_HOP_DONG;
        private DevExpress.XtraGrid.Columns.GridColumn NGAY_BAT_DAU;
        private DevExpress.XtraGrid.Columns.GridColumn NGAY_KET_THUC;
        private DevExpress.XtraGrid.Columns.GridColumn NGAY_KY_HOP_DONG;
        private DevExpress.XtraGrid.Columns.GridColumn NGAY_LAP;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton m_cmd_print;
        private DevExpress.XtraEditors.SimpleButton m_cmd_insert;
        private DevExpress.XtraEditors.SimpleButton m_cmd_update;
        private DevExpress.XtraEditors.SimpleButton m_cmd_delete;
        private DevExpress.XtraEditors.SimpleButton m_cmd_xuat_excel;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;

    }
}