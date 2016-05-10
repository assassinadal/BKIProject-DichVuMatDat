namespace BKI_DichVuMatDat.DanhMuc
{
    partial class F106_dm_luong_che_do_de
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F106_dm_luong_che_do_de));
            this.m_lbl_header = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_cmd_save = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_exit = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.m_gr_thong_tin_co_ban = new DevExpress.XtraEditors.GroupControl();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.m_sle_muc_lcd = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label2 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList();
            this.m_sle_ma_lcd = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.m_txt_so_tien = new DevExpress.XtraEditors.TextEdit();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_gr_thong_tin_co_ban)).BeginInit();
            this.m_gr_thong_tin_co_ban.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_sle_muc_lcd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_sle_ma_lcd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_txt_so_tien.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // m_lbl_header
            // 
            this.m_lbl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.m_lbl_header.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_header.Location = new System.Drawing.Point(0, 0);
            this.m_lbl_header.Name = "m_lbl_header";
            this.m_lbl_header.Size = new System.Drawing.Size(419, 44);
            this.m_lbl_header.TabIndex = 1;
            this.m_lbl_header.Text = "THÊM LƯƠNG CHẾ ĐỘ";
            this.m_lbl_header.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_cmd_save);
            this.panel1.Controls.Add(this.m_cmd_exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 171);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(419, 42);
            this.panel1.TabIndex = 2;
            // 
            // m_cmd_save
            // 
            this.m_cmd_save.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_save.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_save.Image")));
            this.m_cmd_save.Location = new System.Drawing.Point(187, 0);
            this.m_cmd_save.Name = "m_cmd_save";
            this.m_cmd_save.Size = new System.Drawing.Size(116, 42);
            this.m_cmd_save.TabIndex = 26;
            this.m_cmd_save.Text = "&Lưu";
            // 
            // m_cmd_exit
            // 
            this.m_cmd_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_exit.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_exit.Image")));
            this.m_cmd_exit.Location = new System.Drawing.Point(303, 0);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(116, 42);
            this.m_cmd_exit.TabIndex = 25;
            this.m_cmd_exit.Text = "&Thoát";
            this.m_cmd_exit.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.m_gr_thong_tin_co_ban);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(419, 127);
            this.panel2.TabIndex = 3;
            // 
            // m_gr_thong_tin_co_ban
            // 
            this.m_gr_thong_tin_co_ban.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_gr_thong_tin_co_ban.Appearance.Options.UseFont = true;
            this.m_gr_thong_tin_co_ban.Controls.Add(this.m_txt_so_tien);
            this.m_gr_thong_tin_co_ban.Controls.Add(this.m_sle_ma_lcd);
            this.m_gr_thong_tin_co_ban.Controls.Add(this.label7);
            this.m_gr_thong_tin_co_ban.Controls.Add(this.label1);
            this.m_gr_thong_tin_co_ban.Controls.Add(this.m_sle_muc_lcd);
            this.m_gr_thong_tin_co_ban.Controls.Add(this.label2);
            this.m_gr_thong_tin_co_ban.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_gr_thong_tin_co_ban.Location = new System.Drawing.Point(0, 0);
            this.m_gr_thong_tin_co_ban.Name = "m_gr_thong_tin_co_ban";
            this.m_gr_thong_tin_co_ban.Size = new System.Drawing.Size(419, 127);
            this.m_gr_thong_tin_co_ban.TabIndex = 1;
            this.m_gr_thong_tin_co_ban.Text = "ĐIỀN THÔNG TIN";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Mã lương chế độ(*)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Số tiền";
            // 
            // m_sle_muc_lcd
            // 
            this.m_sle_muc_lcd.Location = new System.Drawing.Point(127, 58);
            this.m_sle_muc_lcd.Name = "m_sle_muc_lcd";
            this.m_sle_muc_lcd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.m_sle_muc_lcd.Properties.NullText = "-----Chọn mức lương chế độ-----";
            this.m_sle_muc_lcd.Properties.View = this.gridView1;
            this.m_sle_muc_lcd.Size = new System.Drawing.Size(256, 20);
            this.m_sle_muc_lcd.TabIndex = 6;
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mức lương chế độ(*)";
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
            // m_sle_ma_lcd
            // 
            this.m_sle_ma_lcd.Location = new System.Drawing.Point(127, 28);
            this.m_sle_ma_lcd.Name = "m_sle_ma_lcd";
            this.m_sle_ma_lcd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.m_sle_ma_lcd.Properties.NullText = "-----Chọn mã lương chế độ-----";
            this.m_sle_ma_lcd.Properties.View = this.gridView2;
            this.m_sle_ma_lcd.Size = new System.Drawing.Size(256, 20);
            this.m_sle_ma_lcd.TabIndex = 9;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // m_txt_so_tien
            // 
            this.m_txt_so_tien.Location = new System.Drawing.Point(127, 87);
            this.m_txt_so_tien.Name = "m_txt_so_tien";
            this.m_txt_so_tien.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.m_txt_so_tien.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.m_txt_so_tien.Size = new System.Drawing.Size(256, 20);
            this.m_txt_so_tien.TabIndex = 10;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã lương chế độ";
            this.gridColumn1.FieldName = "MA_TU_DIEN";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên gọi";
            this.gridColumn2.FieldName = "TEN";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Ghi chú";
            this.gridColumn3.FieldName = "GHI_CHU";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // F106_dm_luong_che_do_de
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 213);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.m_lbl_header);
            this.Name = "F106_dm_luong_che_do_de";
            this.Text = "F106 - DANH MỤC LƯƠNG CHẾ ĐỘ DETAIL";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_gr_thong_tin_co_ban)).EndInit();
            this.m_gr_thong_tin_co_ban.ResumeLayout(false);
            this.m_gr_thong_tin_co_ban.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_sle_muc_lcd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_sle_ma_lcd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_txt_so_tien.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label m_lbl_header;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.GroupControl m_gr_thong_tin_co_ban;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SearchLookUpEdit m_sle_muc_lcd;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton m_cmd_save;
        private DevExpress.XtraEditors.SimpleButton m_cmd_exit;
        internal System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraEditors.SearchLookUpEdit m_sle_ma_lcd;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.TextEdit m_txt_so_tien;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
    }
}