﻿namespace BKI_DichVuMatDat.NghiepVu
{
    partial class f381_thay_doi_he_so_luong_nang_suat_by_nhan_vien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f381_thay_doi_he_so_luong_nang_suat_by_nhan_vien));
            this.m_cmd_insert = new DevExpress.XtraEditors.SimpleButton();
            this.NAM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.THANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.m_cmd_update = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_delete = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_xuat_excel = new DevExpress.XtraEditors.SimpleButton();
            this.HE_SO_K = new DevExpress.XtraGrid.Columns.GridColumn();
            this.m_cmd_search = new DevExpress.XtraEditors.SimpleButton();
            this.MA_NV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.m_grv_hs_chat_luong = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.HO_TEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.m_grc_hs_chat_luong = new DevExpress.XtraGrid.GridControl();
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.m_gr_thong_tin_co_ban = new DevExpress.XtraEditors.GroupControl();
            this.m_sle_chon_nhan_vien = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.m_lbl_header = new System.Windows.Forms.Label();
            this.m_txt_chon_nam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.m_txt_chon_thang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.m_txt_hs = new System.Windows.Forms.TextBox();
            this.m_lbl_hs = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.m_cmd_luu_hs = new DevExpress.XtraEditors.SimpleButton();
            this.m_pnl_out_place_dm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_hs_chat_luong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_hs_chat_luong)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_gr_thong_tin_co_ban)).BeginInit();
            this.m_gr_thong_tin_co_ban.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_sle_chon_nhan_vien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_cmd_insert
            // 
            this.m_cmd_insert.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_insert.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_insert.Image")));
            this.m_cmd_insert.Location = new System.Drawing.Point(629, 4);
            this.m_cmd_insert.Name = "m_cmd_insert";
            this.m_cmd_insert.Size = new System.Drawing.Size(116, 38);
            this.m_cmd_insert.TabIndex = 18;
            this.m_cmd_insert.Text = "&Thêm";
            this.m_cmd_insert.Visible = false;
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
            this.NAM.VisibleIndex = 5;
            // 
            // THANG
            // 
            this.THANG.AppearanceHeader.Options.UseTextOptions = true;
            this.THANG.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.THANG.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.THANG.Caption = "Tháng";
            this.THANG.FieldName = "THANG";
            this.THANG.Name = "THANG";
            this.THANG.OptionsColumn.AllowEdit = false;
            this.THANG.Visible = true;
            this.THANG.VisibleIndex = 4;
            // 
            // m_pnl_out_place_dm
            // 
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_insert);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_update);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_delete);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_xuat_excel);
            this.m_pnl_out_place_dm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 537);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(1097, 46);
            this.m_pnl_out_place_dm.TabIndex = 9;
            // 
            // m_cmd_update
            // 
            this.m_cmd_update.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_update.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_update.Image")));
            this.m_cmd_update.Location = new System.Drawing.Point(745, 4);
            this.m_cmd_update.Name = "m_cmd_update";
            this.m_cmd_update.Size = new System.Drawing.Size(116, 38);
            this.m_cmd_update.TabIndex = 17;
            this.m_cmd_update.Text = "&Sửa";
            this.m_cmd_update.Visible = false;
            // 
            // m_cmd_delete
            // 
            this.m_cmd_delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_delete.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_delete.Image")));
            this.m_cmd_delete.Location = new System.Drawing.Point(861, 4);
            this.m_cmd_delete.Name = "m_cmd_delete";
            this.m_cmd_delete.Size = new System.Drawing.Size(116, 38);
            this.m_cmd_delete.TabIndex = 16;
            this.m_cmd_delete.Text = "&Xóa";
            this.m_cmd_delete.Visible = false;
            // 
            // m_cmd_xuat_excel
            // 
            this.m_cmd_xuat_excel.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_xuat_excel.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_xuat_excel.Image")));
            this.m_cmd_xuat_excel.Location = new System.Drawing.Point(977, 4);
            this.m_cmd_xuat_excel.Name = "m_cmd_xuat_excel";
            this.m_cmd_xuat_excel.Size = new System.Drawing.Size(116, 38);
            this.m_cmd_xuat_excel.TabIndex = 15;
            this.m_cmd_xuat_excel.Text = "&Xuất Excel";
            this.m_cmd_xuat_excel.Visible = false;
            // 
            // HE_SO_K
            // 
            this.HE_SO_K.AppearanceHeader.Options.UseTextOptions = true;
            this.HE_SO_K.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.HE_SO_K.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.HE_SO_K.Caption = "Hệ số K";
            this.HE_SO_K.FieldName = "HE_SO_K";
            this.HE_SO_K.Name = "HE_SO_K";
            this.HE_SO_K.OptionsColumn.AllowEdit = false;
            this.HE_SO_K.Visible = true;
            this.HE_SO_K.VisibleIndex = 3;
            // 
            // m_cmd_search
            // 
            this.m_cmd_search.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_search.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_search.Image")));
            this.m_cmd_search.Location = new System.Drawing.Point(0, 0);
            this.m_cmd_search.Name = "m_cmd_search";
            this.m_cmd_search.Size = new System.Drawing.Size(128, 44);
            this.m_cmd_search.TabIndex = 13;
            this.m_cmd_search.Text = "&Lọc dữ liệu";
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
            this.MA_NV.Width = 50;
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
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            // 
            // m_grv_hs_chat_luong
            // 
            this.m_grv_hs_chat_luong.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.STT,
            this.MA_NV,
            this.HO_TEN,
            this.HE_SO_K,
            this.THANG,
            this.NAM});
            this.m_grv_hs_chat_luong.GridControl = this.m_grc_hs_chat_luong;
            this.m_grv_hs_chat_luong.Name = "m_grv_hs_chat_luong";
            this.m_grv_hs_chat_luong.OptionsFind.AllowFindPanel = false;
            this.m_grv_hs_chat_luong.OptionsFind.AlwaysVisible = true;
            this.m_grv_hs_chat_luong.OptionsView.ShowFooter = true;
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
            this.HO_TEN.VisibleIndex = 2;
            // 
            // m_grc_hs_chat_luong
            // 
            this.m_grc_hs_chat_luong.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_hs_chat_luong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc_hs_chat_luong.Location = new System.Drawing.Point(0, 0);
            this.m_grc_hs_chat_luong.MainView = this.m_grv_hs_chat_luong;
            this.m_grc_hs_chat_luong.Name = "m_grc_hs_chat_luong";
            this.m_grc_hs_chat_luong.Size = new System.Drawing.Size(1097, 321);
            this.m_grc_hs_chat_luong.TabIndex = 8;
            this.m_grc_hs_chat_luong.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv_hs_chat_luong});
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
            // panel3
            // 
            this.panel3.Controls.Add(this.m_cmd_luu_hs);
            this.panel3.Controls.Add(this.m_cmd_search);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 172);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1097, 44);
            this.panel3.TabIndex = 10;
            // 
            // m_gr_thong_tin_co_ban
            // 
            this.m_gr_thong_tin_co_ban.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_gr_thong_tin_co_ban.Appearance.Options.UseFont = true;
            this.m_gr_thong_tin_co_ban.Controls.Add(this.m_txt_hs);
            this.m_gr_thong_tin_co_ban.Controls.Add(this.m_lbl_hs);
            this.m_gr_thong_tin_co_ban.Controls.Add(this.m_txt_chon_nam);
            this.m_gr_thong_tin_co_ban.Controls.Add(this.label2);
            this.m_gr_thong_tin_co_ban.Controls.Add(this.m_txt_chon_thang);
            this.m_gr_thong_tin_co_ban.Controls.Add(this.label3);
            this.m_gr_thong_tin_co_ban.Controls.Add(this.m_sle_chon_nhan_vien);
            this.m_gr_thong_tin_co_ban.Controls.Add(this.label1);
            this.m_gr_thong_tin_co_ban.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_gr_thong_tin_co_ban.Location = new System.Drawing.Point(0, 0);
            this.m_gr_thong_tin_co_ban.Name = "m_gr_thong_tin_co_ban";
            this.m_gr_thong_tin_co_ban.Size = new System.Drawing.Size(1097, 120);
            this.m_gr_thong_tin_co_ban.TabIndex = 0;
            this.m_gr_thong_tin_co_ban.Text = "THÔNG TIN CƠ BẢN";
            // 
            // m_sle_chon_nhan_vien
            // 
            this.m_sle_chon_nhan_vien.EditValue = "";
            this.m_sle_chon_nhan_vien.Location = new System.Drawing.Point(129, 33);
            this.m_sle_chon_nhan_vien.Name = "m_sle_chon_nhan_vien";
            this.m_sle_chon_nhan_vien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.m_sle_chon_nhan_vien.Properties.NullText = "";
            this.m_sle_chon_nhan_vien.Properties.View = this.searchLookUpEdit1View;
            this.m_sle_chon_nhan_vien.Size = new System.Drawing.Size(307, 20);
            this.m_sle_chon_nhan_vien.TabIndex = 3;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chọn nhân viên (*)";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.m_gr_thong_tin_co_ban);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1097, 120);
            this.panel2.TabIndex = 7;
            // 
            // m_lbl_header
            // 
            this.m_lbl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.m_lbl_header.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_header.Location = new System.Drawing.Point(0, 0);
            this.m_lbl_header.Name = "m_lbl_header";
            this.m_lbl_header.Size = new System.Drawing.Size(1097, 52);
            this.m_lbl_header.TabIndex = 6;
            this.m_lbl_header.Text = "THAY ĐỔI HỆ SỐ LƯƠNG NĂNG SUẤT";
            this.m_lbl_header.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // m_txt_chon_nam
            // 
            this.m_txt_chon_nam.Location = new System.Drawing.Point(325, 59);
            this.m_txt_chon_nam.Name = "m_txt_chon_nam";
            this.m_txt_chon_nam.Size = new System.Drawing.Size(111, 20);
            this.m_txt_chon_nam.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Chọn năm (*)";
            // 
            // m_txt_chon_thang
            // 
            this.m_txt_chon_thang.Location = new System.Drawing.Point(96, 59);
            this.m_txt_chon_thang.Name = "m_txt_chon_thang";
            this.m_txt_chon_thang.Size = new System.Drawing.Size(111, 20);
            this.m_txt_chon_thang.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Chọn tháng (*)";
            // 
            // m_txt_hs
            // 
            this.m_txt_hs.Location = new System.Drawing.Point(96, 85);
            this.m_txt_hs.Name = "m_txt_hs";
            this.m_txt_hs.Size = new System.Drawing.Size(111, 20);
            this.m_txt_hs.TabIndex = 9;
            this.m_txt_hs.Text = "0";
            // 
            // m_lbl_hs
            // 
            this.m_lbl_hs.AutoSize = true;
            this.m_lbl_hs.Location = new System.Drawing.Point(11, 89);
            this.m_lbl_hs.Name = "m_lbl_hs";
            this.m_lbl_hs.Size = new System.Drawing.Size(48, 13);
            this.m_lbl_hs.TabIndex = 8;
            this.m_lbl_hs.Text = "Hệ số (*)";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.m_grc_hs_chat_luong);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 216);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1097, 321);
            this.panel4.TabIndex = 12;
            // 
            // m_cmd_luu_hs
            // 
            this.m_cmd_luu_hs.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_luu_hs.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_luu_hs.Image")));
            this.m_cmd_luu_hs.Location = new System.Drawing.Point(128, 0);
            this.m_cmd_luu_hs.Name = "m_cmd_luu_hs";
            this.m_cmd_luu_hs.Size = new System.Drawing.Size(128, 44);
            this.m_cmd_luu_hs.TabIndex = 14;
            this.m_cmd_luu_hs.Text = "&Lưu hệ số";
            // 
            // f381_thay_doi_he_so_luong_nang_suat_by_nhan_vien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 583);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.m_lbl_header);
            this.Name = "f381_thay_doi_he_so_luong_nang_suat_by_nhan_vien";
            this.Text = "F381 - Thay đổi hệ số lương năng suất";
            this.m_pnl_out_place_dm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_hs_chat_luong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_hs_chat_luong)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_gr_thong_tin_co_ban)).EndInit();
            this.m_gr_thong_tin_co_ban.ResumeLayout(false);
            this.m_gr_thong_tin_co_ban.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_sle_chon_nhan_vien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton m_cmd_insert;
        private DevExpress.XtraGrid.Columns.GridColumn NAM;
        private DevExpress.XtraGrid.Columns.GridColumn THANG;
        internal System.Windows.Forms.Panel m_pnl_out_place_dm;
        private DevExpress.XtraEditors.SimpleButton m_cmd_update;
        private DevExpress.XtraEditors.SimpleButton m_cmd_delete;
        private DevExpress.XtraEditors.SimpleButton m_cmd_xuat_excel;
        private DevExpress.XtraGrid.Columns.GridColumn HE_SO_K;
        private DevExpress.XtraEditors.SimpleButton m_cmd_search;
        private DevExpress.XtraGrid.Columns.GridColumn MA_NV;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv_hs_chat_luong;
        private DevExpress.XtraGrid.Columns.GridColumn HO_TEN;
        private DevExpress.XtraGrid.GridControl m_grc_hs_chat_luong;
        internal System.Windows.Forms.ImageList ImageList;
        internal System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.GroupControl m_gr_thong_tin_co_ban;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label m_lbl_header;
        private DevExpress.XtraEditors.SearchLookUpEdit m_sle_chon_nhan_vien;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox m_txt_hs;
        private System.Windows.Forms.Label m_lbl_hs;
        private System.Windows.Forms.TextBox m_txt_chon_nam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox m_txt_chon_thang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.SimpleButton m_cmd_luu_hs;
    }
}