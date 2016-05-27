namespace BKI_DichVuMatDat.NghiepVu
{
    partial class F394_gd_nhan_vien_phu_cap
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
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F394_gd_nhan_vien_phu_cap));
            this.colDA_XOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.m_grc = new DevExpress.XtraGrid.GridControl();
            this.m_grv = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_cmd_xuat_excel = new DevExpress.XtraEditors.SimpleButton();
            this.img_DVMD = new DevExpress.Utils.ImageCollection(this.components);
            this.m_cmd_xoa = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_update = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_them = new DevExpress.XtraEditors.SimpleButton();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_DVMD)).BeginInit();
            this.SuspendLayout();
            // 
            // colDA_XOA
            // 
            this.colDA_XOA.Caption = "Hiệu lực";
            this.colDA_XOA.FieldName = "HIEU_LUC";
            this.colDA_XOA.Name = "colDA_XOA";
            this.colDA_XOA.Visible = true;
            this.colDA_XOA.VisibleIndex = 10;
            this.colDA_XOA.Width = 78;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.m_grc);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(873, 418);
            this.panel2.TabIndex = 2;
            // 
            // m_grc
            // 
            this.m_grc.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc.Location = new System.Drawing.Point(0, 32);
            this.m_grc.MainView = this.m_grv;
            this.m_grc.Name = "m_grc";
            this.m_grc.Size = new System.Drawing.Size(873, 386);
            this.m_grc.TabIndex = 3;
            this.m_grc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv});
            // 
            // m_grv
            // 
            this.m_grv.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.m_grv.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.m_grv.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.STT,
            this.gridColumn2,
            this.gridColumn1,
            this.gridColumn4,
            this.gridColumn3,
            this.gridColumn5,
            this.gridColumn7,
            this.gridColumn6,
            this.gridColumn8,
            this.gridColumn9,
            this.colDA_XOA,
            this.colID});
            styleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Pink;
            styleFormatCondition1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic);
            styleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Firebrick;
            styleFormatCondition1.Appearance.Options.UseBackColor = true;
            styleFormatCondition1.Appearance.Options.UseFont = true;
            styleFormatCondition1.Appearance.Options.UseForeColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.colDA_XOA;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition1.Name = "hieuLuc";
            styleFormatCondition1.Value1 = "N";
            this.m_grv.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.m_grv.GridControl = this.m_grc;
            this.m_grv.Name = "m_grv";
            this.m_grv.OptionsBehavior.ReadOnly = true;
            this.m_grv.OptionsFind.AlwaysVisible = true;
            this.m_grv.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.m_grv.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.m_grv.OptionsView.ShowFooter = true;
            // 
            // STT
            // 
            this.STT.AppearanceCell.Options.UseTextOptions = true;
            this.STT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.STT.AppearanceHeader.Options.UseTextOptions = true;
            this.STT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.STT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.STT.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.STT.Caption = "STT";
            this.STT.FieldName = "STT";
            this.STT.Name = "STT";
            this.STT.Visible = true;
            this.STT.VisibleIndex = 0;
            this.STT.Width = 43;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn2.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridColumn2.Caption = "Mã nhân viên";
            this.gridColumn2.FieldName = "MA_NV";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "MA_NV", "SL :{0}")});
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 89;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridColumn1.Caption = "Họ tên";
            this.gridColumn1.FieldName = "HO_TEN";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            this.gridColumn1.Width = 89;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn4.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn4.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridColumn4.Caption = "Chức vụ tương ứng";
            this.gridColumn4.FieldName = "DOI_TUONG_HUONG_PHU_CAP";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 4;
            this.gridColumn4.Width = 89;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn3.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridColumn3.Caption = "Hệ số phụ cấp ";
            this.gridColumn3.FieldName = "TI_LE";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            this.gridColumn3.Width = 109;
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn5.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn5.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridColumn5.Caption = "Đơn vị";
            this.gridColumn5.FieldName = "TEN_DON_VI";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 5;
            this.gridColumn5.Width = 119;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Người lập";
            this.gridColumn7.FieldName = "NGUOI_LAP_PHU_CAP";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 9;
            this.gridColumn7.Width = 74;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Ngày lập";
            this.gridColumn6.FieldName = "NGAY_LAP_PHU_CAP";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 8;
            this.gridColumn6.Width = 65;
            // 
            // gridColumn8
            // 
            this.gridColumn8.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn8.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn8.Caption = "Tháng áp dụng";
            this.gridColumn8.FieldName = "THANG_AP_DUNG";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 6;
            this.gridColumn8.Width = 52;
            // 
            // gridColumn9
            // 
            this.gridColumn9.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn9.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn9.Caption = "Năm áp dụng";
            this.gridColumn9.FieldName = "NAM_AP_DUNG";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 7;
            this.gridColumn9.Width = 48;
            // 
            // colID
            // 
            this.colID.Caption = "ID";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_cmd_xuat_excel);
            this.panel1.Controls.Add(this.m_cmd_xoa);
            this.panel1.Controls.Add(this.m_cmd_update);
            this.panel1.Controls.Add(this.m_cmd_them);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(873, 32);
            this.panel1.TabIndex = 1;
            // 
            // m_cmd_xuat_excel
            // 
            this.m_cmd_xuat_excel.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_xuat_excel.ImageIndex = 0;
            this.m_cmd_xuat_excel.ImageList = this.img_DVMD;
            this.m_cmd_xuat_excel.Location = new System.Drawing.Point(225, 0);
            this.m_cmd_xuat_excel.Name = "m_cmd_xuat_excel";
            this.m_cmd_xuat_excel.Size = new System.Drawing.Size(100, 32);
            this.m_cmd_xuat_excel.TabIndex = 8;
            this.m_cmd_xuat_excel.Text = "&Xuất Excel";
            this.m_cmd_xuat_excel.Visible = false;
            this.m_cmd_xuat_excel.Click += new System.EventHandler(this.m_cmd_xuat_excel_Click);
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
            // m_cmd_xoa
            // 
            this.m_cmd_xoa.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_xoa.ImageIndex = 8;
            this.m_cmd_xoa.ImageList = this.img_DVMD;
            this.m_cmd_xoa.Location = new System.Drawing.Point(150, 0);
            this.m_cmd_xoa.Name = "m_cmd_xoa";
            this.m_cmd_xoa.Size = new System.Drawing.Size(75, 32);
            this.m_cmd_xoa.TabIndex = 9;
            this.m_cmd_xoa.Text = "&Xóa";
            // 
            // m_cmd_update
            // 
            this.m_cmd_update.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_update.ImageIndex = 9;
            this.m_cmd_update.ImageList = this.img_DVMD;
            this.m_cmd_update.Location = new System.Drawing.Point(75, 0);
            this.m_cmd_update.Name = "m_cmd_update";
            this.m_cmd_update.Size = new System.Drawing.Size(75, 32);
            this.m_cmd_update.TabIndex = 11;
            this.m_cmd_update.Text = "&Sửa";
            // 
            // m_cmd_them
            // 
            this.m_cmd_them.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_them.ImageIndex = 7;
            this.m_cmd_them.ImageList = this.img_DVMD;
            this.m_cmd_them.Location = new System.Drawing.Point(0, 0);
            this.m_cmd_them.Name = "m_cmd_them";
            this.m_cmd_them.Size = new System.Drawing.Size(75, 32);
            this.m_cmd_them.TabIndex = 10;
            this.m_cmd_them.Text = "&Thêm";
            // 
            // F394_gd_nhan_vien_phu_cap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 418);
            this.Controls.Add(this.panel2);
            this.Name = "F394_gd_nhan_vien_phu_cap";
            this.Text = "F394 -  Quản lý Phụ cấp trách nhiệm";
            this.Load += new System.EventHandler(this.F393_gd_nhan_vien_phu_cap_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_grc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_DVMD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton m_cmd_them;
        private DevExpress.XtraEditors.SimpleButton m_cmd_xoa;
        private DevExpress.XtraEditors.SimpleButton m_cmd_xuat_excel;
        private DevExpress.XtraEditors.SimpleButton m_cmd_update;
        private DevExpress.Utils.ImageCollection img_DVMD;
        private DevExpress.XtraGrid.GridControl m_grc;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn colDA_XOA;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
    }
}