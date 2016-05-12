namespace BKI_DichVuMatDat.DanhMuc
{
    partial class F110_dm_chuc_vu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F110_dm_chuc_vu));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.m_grc = new DevExpress.XtraGrid.GridControl();
            this.m_grv = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.m_cmd_insert = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_update = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_delete = new DevExpress.XtraEditors.SimpleButton();
            this.colTEN_DON_VI = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colID = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colMA_DON_VI = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colSO_LUONG_NS_DANG_CONG_TAC = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.m_tree_don_vi = new DevExpress.XtraTreeList.TreeList();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_tree_don_vi)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.m_grc);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(255, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(554, 380);
            this.panelControl1.TabIndex = 3;
            // 
            // m_grc
            // 
            this.m_grc.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc.Location = new System.Drawing.Point(2, 2);
            this.m_grc.MainView = this.m_grv;
            this.m_grc.Name = "m_grc";
            this.m_grc.Size = new System.Drawing.Size(550, 336);
            this.m_grc.TabIndex = 1;
            this.m_grc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv});
            // 
            // m_grv
            // 
            this.m_grv.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.m_grv.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.m_grv.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.m_grv.GridControl = this.m_grc;
            this.m_grv.Name = "m_grv";
            this.m_grv.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn3, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã chức vụ";
            this.gridColumn1.FieldName = "MA_CHUC_VU";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên chức vụ";
            this.gridColumn2.FieldName = "TEN_CHUC_VU";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Số thứ tự";
            this.gridColumn3.FieldName = "SO_THU_TU";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.gridColumn3.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Ghi chú";
            this.gridColumn4.FieldName = "GHI_CHU";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.m_cmd_insert);
            this.panelControl2.Controls.Add(this.m_cmd_update);
            this.panelControl2.Controls.Add(this.m_cmd_delete);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(2, 338);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(550, 40);
            this.panelControl2.TabIndex = 0;
            // 
            // m_cmd_insert
            // 
            this.m_cmd_insert.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_insert.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_insert.Image")));
            this.m_cmd_insert.ImageIndex = 7;
            this.m_cmd_insert.Location = new System.Drawing.Point(218, 2);
            this.m_cmd_insert.Name = "m_cmd_insert";
            this.m_cmd_insert.Size = new System.Drawing.Size(110, 36);
            this.m_cmd_insert.TabIndex = 40;
            this.m_cmd_insert.Text = "&Thêm";
            // 
            // m_cmd_update
            // 
            this.m_cmd_update.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_update.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_update.Image")));
            this.m_cmd_update.ImageIndex = 9;
            this.m_cmd_update.Location = new System.Drawing.Point(328, 2);
            this.m_cmd_update.Name = "m_cmd_update";
            this.m_cmd_update.Size = new System.Drawing.Size(110, 36);
            this.m_cmd_update.TabIndex = 39;
            this.m_cmd_update.Text = "&Sửa";
            // 
            // m_cmd_delete
            // 
            this.m_cmd_delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_delete.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_delete.Image")));
            this.m_cmd_delete.ImageIndex = 7;
            this.m_cmd_delete.Location = new System.Drawing.Point(438, 2);
            this.m_cmd_delete.Name = "m_cmd_delete";
            this.m_cmd_delete.Size = new System.Drawing.Size(110, 36);
            this.m_cmd_delete.TabIndex = 38;
            this.m_cmd_delete.Text = "&Xóa";
            // 
            // colTEN_DON_VI
            // 
            this.colTEN_DON_VI.Caption = "Đơn vị";
            this.colTEN_DON_VI.FieldName = "TEN_DON_VI";
            this.colTEN_DON_VI.MinWidth = 51;
            this.colTEN_DON_VI.Name = "colTEN_DON_VI";
            this.colTEN_DON_VI.Visible = true;
            this.colTEN_DON_VI.VisibleIndex = 0;
            this.colTEN_DON_VI.Width = 298;
            // 
            // colID
            // 
            this.colID.Caption = "ID";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            // 
            // colMA_DON_VI
            // 
            this.colMA_DON_VI.AllNodesSummary = true;
            this.colMA_DON_VI.Caption = "Mã đơn vị";
            this.colMA_DON_VI.FieldName = "MA_DON_VI";
            this.colMA_DON_VI.Name = "colMA_DON_VI";
            this.colMA_DON_VI.OptionsColumn.ReadOnly = true;
            this.colMA_DON_VI.SummaryFooterStrFormat = "";
            this.colMA_DON_VI.Width = 91;
            // 
            // colSO_LUONG_NS_DANG_CONG_TAC
            // 
            this.colSO_LUONG_NS_DANG_CONG_TAC.Caption = "Thứ tự hiển thị";
            this.colSO_LUONG_NS_DANG_CONG_TAC.FieldName = "SO_LUONG_NS_DANG_CONG_TAC";
            this.colSO_LUONG_NS_DANG_CONG_TAC.Name = "colSO_LUONG_NS_DANG_CONG_TAC";
            this.colSO_LUONG_NS_DANG_CONG_TAC.OptionsColumn.ReadOnly = true;
            this.colSO_LUONG_NS_DANG_CONG_TAC.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            this.colSO_LUONG_NS_DANG_CONG_TAC.SortOrder = System.Windows.Forms.SortOrder.Ascending;
            this.colSO_LUONG_NS_DANG_CONG_TAC.Width = 119;
            // 
            // m_tree_don_vi
            // 
            this.m_tree_don_vi.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.m_tree_don_vi.Appearance.FocusedRow.ForeColor = System.Drawing.SystemColors.Highlight;
            this.m_tree_don_vi.Appearance.FocusedRow.Options.UseFont = true;
            this.m_tree_don_vi.Appearance.FocusedRow.Options.UseForeColor = true;
            this.m_tree_don_vi.Appearance.FocusedRow.Options.UseTextOptions = true;
            this.m_tree_don_vi.Appearance.FocusedRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.m_tree_don_vi.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colTEN_DON_VI,
            this.colID,
            this.colMA_DON_VI,
            this.colSO_LUONG_NS_DANG_CONG_TAC});
            this.m_tree_don_vi.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_tree_don_vi.Location = new System.Drawing.Point(0, 0);
            this.m_tree_don_vi.Name = "m_tree_don_vi";
            this.m_tree_don_vi.OptionsBehavior.AutoNodeHeight = false;
            this.m_tree_don_vi.OptionsBehavior.Editable = false;
            this.m_tree_don_vi.OptionsView.ShowIndicator = false;
            this.m_tree_don_vi.Size = new System.Drawing.Size(255, 380);
            this.m_tree_don_vi.TabIndex = 2;
            // 
            // F110_dm_chuc_vu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 380);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.m_tree_don_vi);
            this.Name = "F110_dm_chuc_vu";
            this.Text = "F110 - Danh mục chức vụ";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_grc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_tree_don_vi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl m_grc;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colTEN_DON_VI;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colID;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colMA_DON_VI;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colSO_LUONG_NS_DANG_CONG_TAC;
        private DevExpress.XtraTreeList.TreeList m_tree_don_vi;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.SimpleButton m_cmd_insert;
        private DevExpress.XtraEditors.SimpleButton m_cmd_update;
        private DevExpress.XtraEditors.SimpleButton m_cmd_delete;

    }
}