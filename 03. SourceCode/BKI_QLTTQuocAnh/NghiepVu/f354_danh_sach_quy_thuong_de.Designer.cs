namespace BKI_DichVuMatDat.NghiepVu
{
    partial class f354_danh_sach_quy_thuong_de
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.m_txt_ten_quy = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.m_txt_so_tien = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.m_dat_thang_thuong = new DevExpress.XtraEditors.DateEdit();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.m_cmd_save = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_exit = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_txt_ten_quy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_txt_so_tien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_thang_thuong.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_thang_thuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.m_cmd_save);
            this.panelControl1.Controls.Add(this.m_cmd_exit);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 158);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(377, 42);
            this.panelControl1.TabIndex = 0;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.m_dat_thang_thuong);
            this.layoutControl1.Controls.Add(this.m_txt_so_tien);
            this.layoutControl1.Controls.Add(this.m_txt_ten_quy);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(377, 158);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem4});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(377, 158);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // m_txt_ten_quy
            // 
            this.m_txt_ten_quy.Location = new System.Drawing.Point(113, 12);
            this.m_txt_ten_quy.Name = "m_txt_ten_quy";
            this.m_txt_ten_quy.Size = new System.Drawing.Size(252, 20);
            this.m_txt_ten_quy.StyleController = this.layoutControl1;
            this.m_txt_ten_quy.TabIndex = 4;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.m_txt_ten_quy;
            this.layoutControlItem1.CustomizationFormText = "Tên quỹ (*)";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(357, 24);
            this.layoutControlItem1.Text = "Tên quỹ *";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(97, 13);
            // 
            // m_txt_so_tien
            // 
            this.m_txt_so_tien.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.m_txt_so_tien.Location = new System.Drawing.Point(113, 36);
            this.m_txt_so_tien.Name = "m_txt_so_tien";
            this.m_txt_so_tien.Properties.Mask.EditMask = "n0";
            this.m_txt_so_tien.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.m_txt_so_tien.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.m_txt_so_tien.Size = new System.Drawing.Size(252, 20);
            this.m_txt_so_tien.StyleController = this.layoutControl1;
            this.m_txt_so_tien.TabIndex = 5;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.m_txt_so_tien;
            this.layoutControlItem2.CustomizationFormText = "Số tiền (*)";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(357, 24);
            this.layoutControlItem2.Text = "Số tiền *";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(97, 13);
            // 
            // m_dat_thang_thuong
            // 
            this.m_dat_thang_thuong.EditValue = null;
            this.m_dat_thang_thuong.Location = new System.Drawing.Point(113, 60);
            this.m_dat_thang_thuong.Name = "m_dat_thang_thuong";
            this.m_dat_thang_thuong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.m_dat_thang_thuong.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.m_dat_thang_thuong.Properties.DisplayFormat.FormatString = "MM/yyyy";
            this.m_dat_thang_thuong.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.m_dat_thang_thuong.Properties.EditFormat.FormatString = "MM/yyyy";
            this.m_dat_thang_thuong.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.m_dat_thang_thuong.Properties.Mask.EditMask = "MM/yyyy";
            this.m_dat_thang_thuong.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.m_dat_thang_thuong.Size = new System.Drawing.Size(252, 20);
            this.m_dat_thang_thuong.StyleController = this.layoutControl1;
            this.m_dat_thang_thuong.TabIndex = 7;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.m_dat_thang_thuong;
            this.layoutControlItem4.CustomizationFormText = "Thưởng cho tháng";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(357, 90);
            this.layoutControlItem4.Text = "Thưởng cho tháng *";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(97, 13);
            // 
            // m_cmd_save
            // 
            this.m_cmd_save.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_save.Image = global::BKI_DichVuMatDat.Properties.Resources.Save;
            this.m_cmd_save.Location = new System.Drawing.Point(197, 2);
            this.m_cmd_save.Name = "m_cmd_save";
            this.m_cmd_save.Size = new System.Drawing.Size(89, 38);
            this.m_cmd_save.TabIndex = 0;
            this.m_cmd_save.Text = "Lưu";
            // 
            // m_cmd_exit
            // 
            this.m_cmd_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_exit.Image = global::BKI_DichVuMatDat.Properties.Resources.Exit;
            this.m_cmd_exit.Location = new System.Drawing.Point(286, 2);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(89, 38);
            this.m_cmd_exit.TabIndex = 0;
            this.m_cmd_exit.Text = "Thoát";
            // 
            // f354_danh_sach_quy_thuong_de
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 200);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "f354_danh_sach_quy_thuong_de";
            this.Text = "F354DE- Thêm mới quỹ tiền thưởng";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_txt_ten_quy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_txt_so_tien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_thang_thuong.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_thang_thuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.DateEdit m_dat_thang_thuong;
        private DevExpress.XtraEditors.TextEdit m_txt_so_tien;
        private DevExpress.XtraEditors.TextEdit m_txt_ten_quy;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.SimpleButton m_cmd_save;
        private DevExpress.XtraEditors.SimpleButton m_cmd_exit;
    }
}