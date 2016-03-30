namespace BKI_DichVuMatDat.BaoCao
{
    partial class f481_bao_cao_thu_lao_hdqt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f481_bao_cao_thu_lao_hdqt));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.m_sle_nhom_ld = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.m_cmd_search = new DevExpress.XtraEditors.SimpleButton();
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.m_cmd_insert = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_update = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_delete = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_xuat_excel = new DevExpress.XtraEditors.SimpleButton();
            this.m_grc_bc_thu_lao = new DevExpress.XtraGrid.GridControl();
            this.m_grv_hs_bs_hs_athk = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MA_NV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HO_TEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.THANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NAM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ID_NHAN_VIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SO_TIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSO_TIEN_NOP_THUE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SO_TAI_KHOAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSO_TIEN_THUC_LINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CHUC_VU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHE_SO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.m_dat_thang = new DevExpress.XtraEditors.DateEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_sle_nhom_ld.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.m_pnl_out_place_dm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_bc_thu_lao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_hs_bs_hs_athk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_thang.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_thang.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_dat_thang);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.m_sle_nhom_ld);
            this.panel1.Controls.Add(this.m_cmd_search);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(953, 61);
            this.panel1.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(383, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nhóm (*)";
            // 
            // m_sle_nhom_ld
            // 
            this.m_sle_nhom_ld.EditValue = "";
            this.m_sle_nhom_ld.Location = new System.Drawing.Point(437, 20);
            this.m_sle_nhom_ld.Name = "m_sle_nhom_ld";
            this.m_sle_nhom_ld.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.m_sle_nhom_ld.Properties.DisplayMember = "TEN";
            this.m_sle_nhom_ld.Properties.NullText = "";
            this.m_sle_nhom_ld.Properties.ValueMember = "ID";
            this.m_sle_nhom_ld.Properties.View = this.searchLookUpEdit1View;
            this.m_sle_nhom_ld.Size = new System.Drawing.Size(156, 20);
            this.m_sle_nhom_ld.TabIndex = 8;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "MÃ NHÓM";
            this.gridColumn1.FieldName = "MA_TU_DIEN";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "TÊN NHÓM";
            this.gridColumn2.FieldName = "TEN";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // m_cmd_search
            // 
            this.m_cmd_search.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_search.Image")));
            this.m_cmd_search.Location = new System.Drawing.Point(610, 12);
            this.m_cmd_search.Name = "m_cmd_search";
            this.m_cmd_search.Size = new System.Drawing.Size(116, 35);
            this.m_cmd_search.TabIndex = 7;
            this.m_cmd_search.Text = "&Lọc";
            this.m_cmd_search.Click += new System.EventHandler(this.m_cmd_search_Click);
            // 
            // m_pnl_out_place_dm
            // 
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_insert);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_update);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_delete);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_xuat_excel);
            this.m_pnl_out_place_dm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 435);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(953, 43);
            this.m_pnl_out_place_dm.TabIndex = 17;
            // 
            // m_cmd_insert
            // 
            this.m_cmd_insert.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_insert.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_insert.Image")));
            this.m_cmd_insert.Location = new System.Drawing.Point(485, 4);
            this.m_cmd_insert.Name = "m_cmd_insert";
            this.m_cmd_insert.Size = new System.Drawing.Size(116, 35);
            this.m_cmd_insert.TabIndex = 6;
            this.m_cmd_insert.Text = "&Thêm";
            this.m_cmd_insert.Visible = false;
            // 
            // m_cmd_update
            // 
            this.m_cmd_update.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_update.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_update.Image")));
            this.m_cmd_update.Location = new System.Drawing.Point(601, 4);
            this.m_cmd_update.Name = "m_cmd_update";
            this.m_cmd_update.Size = new System.Drawing.Size(116, 35);
            this.m_cmd_update.TabIndex = 5;
            this.m_cmd_update.Text = "&Sửa";
            // 
            // m_cmd_delete
            // 
            this.m_cmd_delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_delete.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_delete.Image")));
            this.m_cmd_delete.Location = new System.Drawing.Point(717, 4);
            this.m_cmd_delete.Name = "m_cmd_delete";
            this.m_cmd_delete.Size = new System.Drawing.Size(116, 35);
            this.m_cmd_delete.TabIndex = 4;
            this.m_cmd_delete.Text = "&Xóa";
            this.m_cmd_delete.Visible = false;
            // 
            // m_cmd_xuat_excel
            // 
            this.m_cmd_xuat_excel.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_xuat_excel.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_xuat_excel.Image")));
            this.m_cmd_xuat_excel.Location = new System.Drawing.Point(833, 4);
            this.m_cmd_xuat_excel.Name = "m_cmd_xuat_excel";
            this.m_cmd_xuat_excel.Size = new System.Drawing.Size(116, 35);
            this.m_cmd_xuat_excel.TabIndex = 3;
            this.m_cmd_xuat_excel.Text = "&Xuất Excel";
            this.m_cmd_xuat_excel.Click += new System.EventHandler(this.m_cmd_xuat_excel_Click);
            // 
            // m_grc_bc_thu_lao
            // 
            this.m_grc_bc_thu_lao.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_bc_thu_lao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc_bc_thu_lao.Location = new System.Drawing.Point(0, 61);
            this.m_grc_bc_thu_lao.MainView = this.m_grv_hs_bs_hs_athk;
            this.m_grc_bc_thu_lao.Name = "m_grc_bc_thu_lao";
            this.m_grc_bc_thu_lao.Size = new System.Drawing.Size(953, 374);
            this.m_grc_bc_thu_lao.TabIndex = 18;
            this.m_grc_bc_thu_lao.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv_hs_bs_hs_athk});
            // 
            // m_grv_hs_bs_hs_athk
            // 
            this.m_grv_hs_bs_hs_athk.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.MA_NV,
            this.HO_TEN,
            this.THANG,
            this.NAM,
            this.ID_NHAN_VIEN,
            this.SO_TIEN,
            this.colSO_TIEN_NOP_THUE,
            this.SO_TAI_KHOAN,
            this.colSO_TIEN_THUC_LINH,
            this.CHUC_VU,
            this.STT,
            this.gridColumn3,
            this.colHE_SO});
            this.m_grv_hs_bs_hs_athk.GridControl = this.m_grc_bc_thu_lao;
            this.m_grv_hs_bs_hs_athk.Name = "m_grv_hs_bs_hs_athk";
            this.m_grv_hs_bs_hs_athk.OptionsFind.AllowFindPanel = false;
            this.m_grv_hs_bs_hs_athk.OptionsFind.AlwaysVisible = true;
            this.m_grv_hs_bs_hs_athk.OptionsView.ShowFooter = true;
            // 
            // ID
            // 
            this.ID.AppearanceCell.Options.UseTextOptions = true;
            this.ID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            // 
            // MA_NV
            // 
            this.MA_NV.AppearanceHeader.Options.UseTextOptions = true;
            this.MA_NV.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.MA_NV.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.MA_NV.Caption = "Mã NV";
            this.MA_NV.FieldName = "MA_NV";
            this.MA_NV.Name = "MA_NV";
            this.MA_NV.OptionsColumn.AllowEdit = false;
            this.MA_NV.Visible = true;
            this.MA_NV.VisibleIndex = 1;
            this.MA_NV.Width = 102;
            // 
            // HO_TEN
            // 
            this.HO_TEN.AppearanceCell.Options.UseTextOptions = true;
            this.HO_TEN.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.HO_TEN.AppearanceHeader.Options.UseTextOptions = true;
            this.HO_TEN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.HO_TEN.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.HO_TEN.Caption = "Họ tên";
            this.HO_TEN.FieldName = "HO_TEN";
            this.HO_TEN.Name = "HO_TEN";
            this.HO_TEN.OptionsColumn.AllowEdit = false;
            this.HO_TEN.Visible = true;
            this.HO_TEN.VisibleIndex = 2;
            this.HO_TEN.Width = 154;
            // 
            // THANG
            // 
            this.THANG.AppearanceCell.Options.UseTextOptions = true;
            this.THANG.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.THANG.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.THANG.AppearanceHeader.Options.UseTextOptions = true;
            this.THANG.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.THANG.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.THANG.Caption = "Tháng";
            this.THANG.FieldName = "THANG";
            this.THANG.Name = "THANG";
            this.THANG.OptionsColumn.AllowEdit = false;
            this.THANG.Width = 70;
            // 
            // NAM
            // 
            this.NAM.AppearanceCell.Options.UseTextOptions = true;
            this.NAM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NAM.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.NAM.AppearanceHeader.Options.UseTextOptions = true;
            this.NAM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NAM.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.NAM.Caption = "Năm";
            this.NAM.FieldName = "NAM";
            this.NAM.Name = "NAM";
            this.NAM.OptionsColumn.AllowEdit = false;
            this.NAM.Width = 70;
            // 
            // ID_NHAN_VIEN
            // 
            this.ID_NHAN_VIEN.Caption = "ID NHÂN VIÊN";
            this.ID_NHAN_VIEN.FieldName = "ID_NHAN_VIEN";
            this.ID_NHAN_VIEN.Name = "ID_NHAN_VIEN";
            // 
            // SO_TIEN
            // 
            this.SO_TIEN.AppearanceHeader.Options.UseTextOptions = true;
            this.SO_TIEN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SO_TIEN.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.SO_TIEN.Caption = "Số tiền";
            this.SO_TIEN.DisplayFormat.FormatString = "n0";
            this.SO_TIEN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.SO_TIEN.FieldName = "SO_TIEN";
            this.SO_TIEN.Name = "SO_TIEN";
            this.SO_TIEN.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SO_TIEN", "{0:n0}")});
            this.SO_TIEN.Visible = true;
            this.SO_TIEN.VisibleIndex = 5;
            this.SO_TIEN.Width = 134;
            // 
            // colSO_TIEN_NOP_THUE
            // 
            this.colSO_TIEN_NOP_THUE.AppearanceHeader.Options.UseTextOptions = true;
            this.colSO_TIEN_NOP_THUE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSO_TIEN_NOP_THUE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSO_TIEN_NOP_THUE.Caption = "Số tiền nộp thuế";
            this.colSO_TIEN_NOP_THUE.DisplayFormat.FormatString = "n0";
            this.colSO_TIEN_NOP_THUE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSO_TIEN_NOP_THUE.FieldName = "SO_TIEN_NOP_THUE";
            this.colSO_TIEN_NOP_THUE.Name = "colSO_TIEN_NOP_THUE";
            this.colSO_TIEN_NOP_THUE.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SO_TIEN_NOP_THUE", "{0:n0}")});
            this.colSO_TIEN_NOP_THUE.Visible = true;
            this.colSO_TIEN_NOP_THUE.VisibleIndex = 6;
            this.colSO_TIEN_NOP_THUE.Width = 134;
            // 
            // SO_TAI_KHOAN
            // 
            this.SO_TAI_KHOAN.AppearanceCell.Options.UseTextOptions = true;
            this.SO_TAI_KHOAN.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.SO_TAI_KHOAN.AppearanceHeader.Options.UseTextOptions = true;
            this.SO_TAI_KHOAN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SO_TAI_KHOAN.Caption = "Tài khoản";
            this.SO_TAI_KHOAN.FieldName = "SO_TAI_KHOAN";
            this.SO_TAI_KHOAN.Name = "SO_TAI_KHOAN";
            this.SO_TAI_KHOAN.Visible = true;
            this.SO_TAI_KHOAN.VisibleIndex = 3;
            this.SO_TAI_KHOAN.Width = 145;
            // 
            // colSO_TIEN_THUC_LINH
            // 
            this.colSO_TIEN_THUC_LINH.AppearanceHeader.Options.UseTextOptions = true;
            this.colSO_TIEN_THUC_LINH.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSO_TIEN_THUC_LINH.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSO_TIEN_THUC_LINH.Caption = "Thực lĩnh";
            this.colSO_TIEN_THUC_LINH.DisplayFormat.FormatString = "n0";
            this.colSO_TIEN_THUC_LINH.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSO_TIEN_THUC_LINH.FieldName = "SO_TIEN_THUC_LINH";
            this.colSO_TIEN_THUC_LINH.Name = "colSO_TIEN_THUC_LINH";
            this.colSO_TIEN_THUC_LINH.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SO_TIEN_THUC_LINH", "{0:n0}")});
            this.colSO_TIEN_THUC_LINH.Visible = true;
            this.colSO_TIEN_THUC_LINH.VisibleIndex = 7;
            this.colSO_TIEN_THUC_LINH.Width = 158;
            // 
            // CHUC_VU
            // 
            this.CHUC_VU.AppearanceCell.Options.UseTextOptions = true;
            this.CHUC_VU.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.CHUC_VU.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.CHUC_VU.AppearanceHeader.Options.UseTextOptions = true;
            this.CHUC_VU.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CHUC_VU.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.CHUC_VU.Caption = "Ghi chú";
            this.CHUC_VU.FieldName = "CHUC_VU";
            this.CHUC_VU.Name = "CHUC_VU";
            this.CHUC_VU.Visible = true;
            this.CHUC_VU.VisibleIndex = 8;
            this.CHUC_VU.Width = 128;
            // 
            // STT
            // 
            this.STT.AppearanceCell.Options.UseTextOptions = true;
            this.STT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.STT.AppearanceHeader.Options.UseTextOptions = true;
            this.STT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.STT.Caption = "STT";
            this.STT.FieldName = "STT";
            this.STT.Name = "STT";
            this.STT.Visible = true;
            this.STT.VisibleIndex = 0;
            this.STT.Width = 59;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.Caption = "Loại thu nhập";
            this.gridColumn3.FieldName = "LOAI_THU_NHAP";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Width = 118;
            // 
            // colHE_SO
            // 
            this.colHE_SO.AppearanceHeader.Options.UseTextOptions = true;
            this.colHE_SO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHE_SO.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colHE_SO.Caption = "Hệ số";
            this.colHE_SO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colHE_SO.FieldName = "HE_SO";
            this.colHE_SO.Name = "colHE_SO";
            this.colHE_SO.Visible = true;
            this.colHE_SO.VisibleIndex = 4;
            this.colHE_SO.Width = 64;
            // 
            // m_dat_thang
            // 
            this.m_dat_thang.EditValue = null;
            this.m_dat_thang.Location = new System.Drawing.Point(223, 20);
            this.m_dat_thang.Name = "m_dat_thang";
            this.m_dat_thang.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_dat_thang.Properties.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.m_dat_thang.Properties.Appearance.Options.UseFont = true;
            this.m_dat_thang.Properties.Appearance.Options.UseForeColor = true;
            this.m_dat_thang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.m_dat_thang.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.m_dat_thang.Properties.DisplayFormat.FormatString = "MM/yyyy";
            this.m_dat_thang.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.m_dat_thang.Properties.EditFormat.FormatString = "MM/yyyy";
            this.m_dat_thang.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.m_dat_thang.Properties.Mask.EditMask = "MM/yyyy";
            this.m_dat_thang.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.m_dat_thang.Size = new System.Drawing.Size(141, 20);
            this.m_dat_thang.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Chọn tháng (*)";
            // 
            // f481_bao_cao_thu_lao_hdqt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 478);
            this.Controls.Add(this.m_grc_bc_thu_lao);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.Controls.Add(this.panel1);
            this.Name = "f481_bao_cao_thu_lao_hdqt";
            this.Text = "F481 - Báo cáo thu nhập các nhóm khác";
            this.Load += new System.EventHandler(this.f481_bao_cao_thu_lao_hdqt_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_sle_nhom_ld.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.m_pnl_out_place_dm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_bc_thu_lao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_hs_bs_hs_athk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_thang.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_thang.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton m_cmd_search;
        internal System.Windows.Forms.Panel m_pnl_out_place_dm;
        private DevExpress.XtraEditors.SimpleButton m_cmd_insert;
        private DevExpress.XtraEditors.SimpleButton m_cmd_update;
        private DevExpress.XtraEditors.SimpleButton m_cmd_delete;
        private DevExpress.XtraEditors.SimpleButton m_cmd_xuat_excel;
        private DevExpress.XtraGrid.GridControl m_grc_bc_thu_lao;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv_hs_bs_hs_athk;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn MA_NV;
        private DevExpress.XtraGrid.Columns.GridColumn HO_TEN;
        private DevExpress.XtraGrid.Columns.GridColumn THANG;
        private DevExpress.XtraGrid.Columns.GridColumn NAM;
        private DevExpress.XtraGrid.Columns.GridColumn ID_NHAN_VIEN;
        private DevExpress.XtraGrid.Columns.GridColumn SO_TIEN;
        private DevExpress.XtraGrid.Columns.GridColumn colSO_TIEN_NOP_THUE;
        private DevExpress.XtraGrid.Columns.GridColumn SO_TAI_KHOAN;
        private DevExpress.XtraGrid.Columns.GridColumn colSO_TIEN_THUC_LINH;
        private DevExpress.XtraGrid.Columns.GridColumn CHUC_VU;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
        private DevExpress.XtraEditors.SearchLookUpEdit m_sle_nhom_ld;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn colHE_SO;
        private DevExpress.XtraEditors.DateEdit m_dat_thang;
        private System.Windows.Forms.Label label1;
    }
}