namespace BKI_DichVuMatDat.DanhMuc
{
    partial class F101_dm_don_vi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F101_dm_don_vi));
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_cmd_xuat_excel = new DevExpress.XtraEditors.SimpleButton();
            this.img_DVMD = new DevExpress.Utils.ImageCollection(this.components);
            this.m_cmd_delete = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_update = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_insert = new DevExpress.XtraEditors.SimpleButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.m_tree_don_vi = new DevExpress.XtraTreeList.TreeList();
            this.colTEN_DON_VI = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colID = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colMA_DON_VI = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colSO_LUONG_NS_DANG_CONG_TAC = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_DVMD)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_tree_don_vi)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_cmd_xuat_excel);
            this.panel1.Controls.Add(this.m_cmd_delete);
            this.panel1.Controls.Add(this.m_cmd_update);
            this.panel1.Controls.Add(this.m_cmd_insert);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(510, 33);
            this.panel1.TabIndex = 2;
            // 
            // m_cmd_xuat_excel
            // 
            this.m_cmd_xuat_excel.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_xuat_excel.ImageIndex = 3;
            this.m_cmd_xuat_excel.ImageList = this.img_DVMD;
            this.m_cmd_xuat_excel.Location = new System.Drawing.Point(252, 0);
            this.m_cmd_xuat_excel.Name = "m_cmd_xuat_excel";
            this.m_cmd_xuat_excel.Size = new System.Drawing.Size(84, 33);
            this.m_cmd_xuat_excel.TabIndex = 29;
            this.m_cmd_xuat_excel.Text = "&Xuất Excel";
            // 
            // img_DVMD
            // 
            this.img_DVMD.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("img_DVMD.ImageStream")));
            this.img_DVMD.Images.SetKeyName(0, "Excel-icon.png");
            this.img_DVMD.Images.SetKeyName(1, "excel-xls-icon.png");
            this.img_DVMD.Images.SetKeyName(2, "exit-16.ico");
            this.img_DVMD.Images.SetKeyName(3, "image.png");
            this.img_DVMD.Images.SetKeyName(4, "Microsoft Excel.png");
            this.img_DVMD.Images.SetKeyName(5, "calculator.png");
            this.img_DVMD.Images.SetKeyName(6, "diskette.png");
            this.img_DVMD.Images.SetKeyName(7, "file_add.png");
            this.img_DVMD.Images.SetKeyName(8, "file_delete.png");
            this.img_DVMD.Images.SetKeyName(9, "file_edit.png");
            this.img_DVMD.Images.SetKeyName(10, "file_search.png");
            // 
            // m_cmd_delete
            // 
            this.m_cmd_delete.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_delete.ImageIndex = 8;
            this.m_cmd_delete.ImageList = this.img_DVMD;
            this.m_cmd_delete.Location = new System.Drawing.Point(168, 0);
            this.m_cmd_delete.Name = "m_cmd_delete";
            this.m_cmd_delete.Size = new System.Drawing.Size(84, 33);
            this.m_cmd_delete.TabIndex = 28;
            this.m_cmd_delete.Text = "&Xóa";
            // 
            // m_cmd_update
            // 
            this.m_cmd_update.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_update.ImageIndex = 9;
            this.m_cmd_update.ImageList = this.img_DVMD;
            this.m_cmd_update.Location = new System.Drawing.Point(84, 0);
            this.m_cmd_update.Name = "m_cmd_update";
            this.m_cmd_update.Size = new System.Drawing.Size(84, 33);
            this.m_cmd_update.TabIndex = 27;
            this.m_cmd_update.Text = "&Sửa";
            // 
            // m_cmd_insert
            // 
            this.m_cmd_insert.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_insert.ImageIndex = 7;
            this.m_cmd_insert.ImageList = this.img_DVMD;
            this.m_cmd_insert.Location = new System.Drawing.Point(0, 0);
            this.m_cmd_insert.Name = "m_cmd_insert";
            this.m_cmd_insert.Size = new System.Drawing.Size(84, 33);
            this.m_cmd_insert.TabIndex = 26;
            this.m_cmd_insert.Text = "&Thêm";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "");
            this.imageList1.Images.SetKeyName(3, "");
            this.imageList1.Images.SetKeyName(4, "");
            this.imageList1.Images.SetKeyName(5, "");
            this.imageList1.Images.SetKeyName(6, "");
            this.imageList1.Images.SetKeyName(7, "");
            this.imageList1.Images.SetKeyName(8, "");
            this.imageList1.Images.SetKeyName(9, "");
            this.imageList1.Images.SetKeyName(10, "");
            this.imageList1.Images.SetKeyName(11, "");
            this.imageList1.Images.SetKeyName(12, "");
            this.imageList1.Images.SetKeyName(13, "");
            this.imageList1.Images.SetKeyName(14, "");
            this.imageList1.Images.SetKeyName(15, "");
            this.imageList1.Images.SetKeyName(16, "");
            this.imageList1.Images.SetKeyName(17, "");
            this.imageList1.Images.SetKeyName(18, "");
            this.imageList1.Images.SetKeyName(19, "");
            this.imageList1.Images.SetKeyName(20, "");
            this.imageList1.Images.SetKeyName(21, "");
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.m_tree_don_vi);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(510, 339);
            this.panel2.TabIndex = 5;
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
            this.m_tree_don_vi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_tree_don_vi.Location = new System.Drawing.Point(0, 0);
            this.m_tree_don_vi.Name = "m_tree_don_vi";
            this.m_tree_don_vi.OptionsBehavior.AutoNodeHeight = false;
            this.m_tree_don_vi.OptionsBehavior.Editable = false;
            this.m_tree_don_vi.OptionsView.ShowIndicator = false;
            this.m_tree_don_vi.Size = new System.Drawing.Size(510, 339);
            this.m_tree_don_vi.TabIndex = 1;
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
            this.colMA_DON_VI.Visible = true;
            this.colMA_DON_VI.VisibleIndex = 1;
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
            this.colSO_LUONG_NS_DANG_CONG_TAC.Visible = true;
            this.colSO_LUONG_NS_DANG_CONG_TAC.VisibleIndex = 2;
            this.colSO_LUONG_NS_DANG_CONG_TAC.Width = 119;
            // 
            // F101_dm_don_vi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 372);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "F101_dm_don_vi";
            this.Text = "F101 - Danh mục đơn vị";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_DVMD)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_tree_don_vi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton m_cmd_insert;
        private DevExpress.XtraTreeList.TreeList m_tree_don_vi;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colTEN_DON_VI;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colID;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colMA_DON_VI;
        private DevExpress.XtraEditors.SimpleButton m_cmd_xuat_excel;
        private DevExpress.XtraEditors.SimpleButton m_cmd_delete;
        private DevExpress.XtraEditors.SimpleButton m_cmd_update;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colSO_LUONG_NS_DANG_CONG_TAC;
        private DevExpress.Utils.ImageCollection img_DVMD;
    }
}