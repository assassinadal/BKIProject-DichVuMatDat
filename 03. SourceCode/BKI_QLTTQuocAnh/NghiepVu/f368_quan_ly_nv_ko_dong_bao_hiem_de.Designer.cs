namespace BKI_DichVuMatDat.NghiepVu
{
    partial class f368_quan_ly_nv_ko_dong_bao_hiem_de
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f368_quan_ly_nv_ko_dong_bao_hiem_de));
            this.m_lbl_header = new System.Windows.Forms.Label();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.m_dat_thang = new DevExpress.XtraEditors.DateEdit();
            this.m_txt_ly_do = new System.Windows.Forms.TextBox();
            this.m_sle_chon_nhan_vien = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.sle_cnv_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sle_cnv_MA_NV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sle_cnv_HO_TEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sle_cnv_GIOI_TINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sle_cnv_SDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sle_cnv_DIA_CHI_THUONG_TRU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.img_DVMD = new DevExpress.Utils.ImageCollection(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.m_cmd_save = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_exit = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_thang.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_thang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_sle_chon_nhan_vien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_DVMD)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_lbl_header
            // 
            this.m_lbl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.m_lbl_header.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_header.Location = new System.Drawing.Point(0, 0);
            this.m_lbl_header.Name = "m_lbl_header";
            this.m_lbl_header.Size = new System.Drawing.Size(414, 37);
            this.m_lbl_header.TabIndex = 3;
            this.m_lbl_header.Text = "THÊM NHÂN VIÊN KHÔNG ĐÓNG BẢO HIỂM";
            this.m_lbl_header.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.m_dat_thang);
            this.layoutControl1.Controls.Add(this.m_txt_ly_do);
            this.layoutControl1.Controls.Add(this.m_sle_chon_nhan_vien);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 37);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(679, 186, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(414, 147);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // m_dat_thang
            // 
            this.m_dat_thang.EditValue = null;
            this.m_dat_thang.Location = new System.Drawing.Point(90, 12);
            this.m_dat_thang.Name = "m_dat_thang";
            this.m_dat_thang.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_dat_thang.Properties.Appearance.Options.UseFont = true;
            this.m_dat_thang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.m_dat_thang.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.m_dat_thang.Properties.DisplayFormat.FormatString = "MM/yyyy";
            this.m_dat_thang.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.m_dat_thang.Properties.EditFormat.FormatString = "MM/yyyy";
            this.m_dat_thang.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.m_dat_thang.Properties.Mask.EditMask = "MM/yyyy";
            this.m_dat_thang.Size = new System.Drawing.Size(312, 24);
            this.m_dat_thang.StyleController = this.layoutControl1;
            this.m_dat_thang.TabIndex = 11;
            // 
            // m_txt_ly_do
            // 
            this.m_txt_ly_do.Location = new System.Drawing.Point(92, 64);
            this.m_txt_ly_do.Multiline = true;
            this.m_txt_ly_do.Name = "m_txt_ly_do";
            this.m_txt_ly_do.Size = new System.Drawing.Size(310, 71);
            this.m_txt_ly_do.TabIndex = 10;
            // 
            // m_sle_chon_nhan_vien
            // 
            this.m_sle_chon_nhan_vien.Location = new System.Drawing.Point(90, 40);
            this.m_sle_chon_nhan_vien.Name = "m_sle_chon_nhan_vien";
            this.m_sle_chon_nhan_vien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.m_sle_chon_nhan_vien.Properties.NullText = "-----Chọn nhân viên-----";
            this.m_sle_chon_nhan_vien.Properties.View = this.searchLookUpEdit1View;
            this.m_sle_chon_nhan_vien.Size = new System.Drawing.Size(312, 20);
            this.m_sle_chon_nhan_vien.StyleController = this.layoutControl1;
            this.m_sle_chon_nhan_vien.TabIndex = 5;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.sle_cnv_ID,
            this.sle_cnv_MA_NV,
            this.sle_cnv_HO_TEN,
            this.sle_cnv_GIOI_TINH,
            this.sle_cnv_SDT,
            this.sle_cnv_DIA_CHI_THUONG_TRU});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // sle_cnv_ID
            // 
            this.sle_cnv_ID.Caption = "ID";
            this.sle_cnv_ID.FieldName = "ID";
            this.sle_cnv_ID.Name = "sle_cnv_ID";
            // 
            // sle_cnv_MA_NV
            // 
            this.sle_cnv_MA_NV.Caption = "Mã NV";
            this.sle_cnv_MA_NV.FieldName = "MA_NV";
            this.sle_cnv_MA_NV.Name = "sle_cnv_MA_NV";
            this.sle_cnv_MA_NV.Visible = true;
            this.sle_cnv_MA_NV.VisibleIndex = 0;
            // 
            // sle_cnv_HO_TEN
            // 
            this.sle_cnv_HO_TEN.Caption = "Họ tên";
            this.sle_cnv_HO_TEN.FieldName = "HO_TEN";
            this.sle_cnv_HO_TEN.Name = "sle_cnv_HO_TEN";
            this.sle_cnv_HO_TEN.Visible = true;
            this.sle_cnv_HO_TEN.VisibleIndex = 1;
            // 
            // sle_cnv_GIOI_TINH
            // 
            this.sle_cnv_GIOI_TINH.Caption = "Giới tính";
            this.sle_cnv_GIOI_TINH.FieldName = "GIOI_TINH_TEXT";
            this.sle_cnv_GIOI_TINH.Name = "sle_cnv_GIOI_TINH";
            this.sle_cnv_GIOI_TINH.Visible = true;
            this.sle_cnv_GIOI_TINH.VisibleIndex = 2;
            // 
            // sle_cnv_SDT
            // 
            this.sle_cnv_SDT.Caption = "SĐT";
            this.sle_cnv_SDT.FieldName = "SDT";
            this.sle_cnv_SDT.Name = "sle_cnv_SDT";
            // 
            // sle_cnv_DIA_CHI_THUONG_TRU
            // 
            this.sle_cnv_DIA_CHI_THUONG_TRU.Caption = "Địa chỉ thường trú";
            this.sle_cnv_DIA_CHI_THUONG_TRU.FieldName = "DIA_CHI_THUONG_TRU";
            this.sle_cnv_DIA_CHI_THUONG_TRU.Name = "sle_cnv_DIA_CHI_THUONG_TRU";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "Root";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4,
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(414, 147);
            this.layoutControlGroup1.Text = "Root";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.m_txt_ly_do;
            this.layoutControlItem4.CustomizationFormText = "Lý do";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 52);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(394, 75);
            this.layoutControlItem4.Text = "Lý do";
            this.layoutControlItem4.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(75, 13);
            this.layoutControlItem4.TextToControlDistance = 5;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.m_sle_chon_nhan_vien;
            this.layoutControlItem1.CustomizationFormText = "Chọn nhân viên";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 28);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(394, 24);
            this.layoutControlItem1.Text = "Chọn nhân viên";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(75, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.m_dat_thang;
            this.layoutControlItem2.CustomizationFormText = "Tháng";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(394, 28);
            this.layoutControlItem2.Text = "Tháng";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(75, 13);
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
            // panel3
            // 
            this.panel3.Controls.Add(this.m_cmd_save);
            this.panel3.Controls.Add(this.m_cmd_exit);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 184);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(2);
            this.panel3.Size = new System.Drawing.Size(414, 36);
            this.panel3.TabIndex = 6;
            // 
            // m_cmd_save
            // 
            this.m_cmd_save.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_save.ImageIndex = 6;
            this.m_cmd_save.ImageList = this.img_DVMD;
            this.m_cmd_save.Location = new System.Drawing.Point(262, 2);
            this.m_cmd_save.Name = "m_cmd_save";
            this.m_cmd_save.Size = new System.Drawing.Size(75, 32);
            this.m_cmd_save.TabIndex = 22;
            this.m_cmd_save.Text = "&Lưu";
            // 
            // m_cmd_exit
            // 
            this.m_cmd_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_exit.ImageIndex = 2;
            this.m_cmd_exit.ImageList = this.img_DVMD;
            this.m_cmd_exit.Location = new System.Drawing.Point(337, 2);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(75, 32);
            this.m_cmd_exit.TabIndex = 20;
            this.m_cmd_exit.Text = "&Thoát";
            // 
            // f368_quan_ly_nv_ko_dong_bao_hiem_de
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 220);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.m_lbl_header);
            this.Controls.Add(this.panel3);
            this.Name = "f368_quan_ly_nv_ko_dong_bao_hiem_de";
            this.Text = "F368 - Quản lý nhân viên không đóng bảo hiểm";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_thang.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_thang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_sle_chon_nhan_vien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_DVMD)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label m_lbl_header;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.SearchLookUpEdit m_sle_chon_nhan_vien;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn sle_cnv_ID;
        private DevExpress.XtraGrid.Columns.GridColumn sle_cnv_MA_NV;
        private DevExpress.XtraGrid.Columns.GridColumn sle_cnv_HO_TEN;
        private DevExpress.XtraGrid.Columns.GridColumn sle_cnv_GIOI_TINH;
        private DevExpress.XtraGrid.Columns.GridColumn sle_cnv_SDT;
        private DevExpress.XtraGrid.Columns.GridColumn sle_cnv_DIA_CHI_THUONG_TRU;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.TextBox m_txt_ly_do;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.DateEdit m_dat_thang;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.Utils.ImageCollection img_DVMD;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.SimpleButton m_cmd_save;
        private DevExpress.XtraEditors.SimpleButton m_cmd_exit;
    }
}