namespace BKI_DichVuMatDat.DanhMuc
{
    partial class f160_them_nhan_vien_nhanh
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
            if(disposing && (components != null))
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.m_txt_ma_nv = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.m_txt_ho_dem = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.m_txt_ten_nv = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.m_cmd_save = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.m_ld_ttld = new DevExpress.XtraEditors.LookUpEdit();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_txt_ma_nv.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_txt_ho_dem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_txt_ten_nv.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_ld_ttld.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.m_ld_ttld);
            this.layoutControl1.Controls.Add(this.m_cmd_save);
            this.layoutControl1.Controls.Add(this.m_txt_ten_nv);
            this.layoutControl1.Controls.Add(this.m_txt_ho_dem);
            this.layoutControl1.Controls.Add(this.m_txt_ma_nv);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(692, 240, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(505, 167);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "Root";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.emptySpaceItem1,
            this.layoutControlItem5});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(505, 167);
            this.layoutControlGroup1.Text = "Root";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // m_txt_ma_nv
            // 
            this.m_txt_ma_nv.Location = new System.Drawing.Point(81, 12);
            this.m_txt_ma_nv.Name = "m_txt_ma_nv";
            this.m_txt_ma_nv.Size = new System.Drawing.Size(412, 20);
            this.m_txt_ma_nv.StyleController = this.layoutControl1;
            this.m_txt_ma_nv.TabIndex = 4;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.m_txt_ma_nv;
            this.layoutControlItem1.CustomizationFormText = "Mã NV *";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(485, 24);
            this.layoutControlItem1.Text = "Mã NV *";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(65, 13);
            // 
            // m_txt_ho_dem
            // 
            this.m_txt_ho_dem.Location = new System.Drawing.Point(81, 36);
            this.m_txt_ho_dem.Name = "m_txt_ho_dem";
            this.m_txt_ho_dem.Size = new System.Drawing.Size(412, 20);
            this.m_txt_ho_dem.StyleController = this.layoutControl1;
            this.m_txt_ho_dem.TabIndex = 5;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.m_txt_ho_dem;
            this.layoutControlItem2.CustomizationFormText = "Họ đệm NV *";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(485, 24);
            this.layoutControlItem2.Text = "Họ đệm NV *";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(65, 13);
            // 
            // m_txt_ten_nv
            // 
            this.m_txt_ten_nv.Location = new System.Drawing.Point(81, 60);
            this.m_txt_ten_nv.Name = "m_txt_ten_nv";
            this.m_txt_ten_nv.Size = new System.Drawing.Size(412, 20);
            this.m_txt_ten_nv.StyleController = this.layoutControl1;
            this.m_txt_ten_nv.TabIndex = 6;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.m_txt_ten_nv;
            this.layoutControlItem3.CustomizationFormText = "Tên NV *";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(485, 24);
            this.layoutControlItem3.Text = "Tên NV *";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(65, 13);
            // 
            // m_cmd_save
            // 
            this.m_cmd_save.Image = global::BKI_DichVuMatDat.Properties.Resources.Save;
            this.m_cmd_save.Location = new System.Drawing.Point(12, 108);
            this.m_cmd_save.Name = "m_cmd_save";
            this.m_cmd_save.Size = new System.Drawing.Size(116, 41);
            this.m_cmd_save.StyleController = this.layoutControl1;
            this.m_cmd_save.TabIndex = 7;
            this.m_cmd_save.Text = "Lưu";
            this.m_cmd_save.Click += new System.EventHandler(this.m_cmd_save_Click);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.m_cmd_save;
            this.layoutControlItem4.CustomizationFormText = "layoutControlItem4";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem4.MaxSize = new System.Drawing.Size(120, 45);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(120, 45);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(120, 51);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.Text = "layoutControlItem4";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextToControlDistance = 0;
            this.layoutControlItem4.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(120, 96);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(365, 51);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // m_ld_ttld
            // 
            this.m_ld_ttld.Location = new System.Drawing.Point(81, 84);
            this.m_ld_ttld.Name = "m_ld_ttld";
            this.m_ld_ttld.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.m_ld_ttld.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TEN_TRANG_THAI_LD", "Tên trạng thái LĐ")});
            this.m_ld_ttld.Properties.DisplayMember = "TEN_TRANG_THAI_LD";
            this.m_ld_ttld.Properties.NullText = "--Chọn trạng thái LĐ--";
            this.m_ld_ttld.Properties.ValueMember = "ID";
            this.m_ld_ttld.Size = new System.Drawing.Size(412, 20);
            this.m_ld_ttld.StyleController = this.layoutControl1;
            this.m_ld_ttld.TabIndex = 8;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.m_ld_ttld;
            this.layoutControlItem5.CustomizationFormText = "Trạng thái LĐ";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(485, 24);
            this.layoutControlItem5.Text = "Trạng thái LĐ";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(65, 13);
            // 
            // f160_them_nhan_vien_nhanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 167);
            this.Controls.Add(this.layoutControl1);
            this.Name = "f160_them_nhan_vien_nhanh";
            this.Text = "F160 - Thêm nhân viên không còn làm việc";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_txt_ma_nv.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_txt_ho_dem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_txt_ten_nv.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_ld_ttld.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit m_txt_ten_nv;
        private DevExpress.XtraEditors.TextEdit m_txt_ho_dem;
        private DevExpress.XtraEditors.TextEdit m_txt_ma_nv;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.SimpleButton m_cmd_save;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.LookUpEdit m_ld_ttld;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    }
}