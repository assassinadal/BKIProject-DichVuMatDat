namespace BKI_DichVuMatDat.NghiepVu
{
    partial class F501_THONG_TIN_BO_SUNG_NHAN_VIEN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F501_THONG_TIN_BO_SUNG_NHAN_VIEN));
            this.label1 = new System.Windows.Forms.Label();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.m_sle_ten_nv = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.m_sle_loai_lao_dong = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.m_txt_so_luong_phu_thuoc = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_cmd_save = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_exit = new DevExpress.XtraEditors.SimpleButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.m_dat_ngay_bat_dau = new System.Windows.Forms.DateTimePicker();
            this.m_dat_ngay_ket_thuc = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.m_dat_ngay_ap_dung = new System.Windows.Forms.DateTimePicker();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_sle_ten_nv.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_sle_loai_lao_dong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên nhân viên";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(955, 56);
            this.panelControl1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(5, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(337, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "THÔNG TIN BỔ SUNG NHÂN VIÊN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Loại lao động";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số lượng phụ thuộc";
            // 
            // m_sle_ten_nv
            // 
            this.m_sle_ten_nv.Location = new System.Drawing.Point(199, 83);
            this.m_sle_ten_nv.Name = "m_sle_ten_nv";
            this.m_sle_ten_nv.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.m_sle_ten_nv.Properties.DisplayMember = "TEN_NHAN_VIEN";
            this.m_sle_ten_nv.Properties.ValueMember = "ID";
            this.m_sle_ten_nv.Properties.View = this.searchLookUpEdit1View;
            this.m_sle_ten_nv.Size = new System.Drawing.Size(265, 20);
            this.m_sle_ten_nv.TabIndex = 3;
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
            // m_sle_loai_lao_dong
            // 
            this.m_sle_loai_lao_dong.EditValue = "";
            this.m_sle_loai_lao_dong.Location = new System.Drawing.Point(199, 130);
            this.m_sle_loai_lao_dong.Name = "m_sle_loai_lao_dong";
            this.m_sle_loai_lao_dong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.m_sle_loai_lao_dong.Properties.DisplayMember = "TEN";
            this.m_sle_loai_lao_dong.Properties.ValueMember = "ID";
            this.m_sle_loai_lao_dong.Properties.View = this.gridView1;
            this.m_sle_loai_lao_dong.Size = new System.Drawing.Size(265, 20);
            this.m_sle_loai_lao_dong.TabIndex = 3;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // m_txt_so_luong_phu_thuoc
            // 
            this.m_txt_so_luong_phu_thuoc.Location = new System.Drawing.Point(199, 174);
            this.m_txt_so_luong_phu_thuoc.Name = "m_txt_so_luong_phu_thuoc";
            this.m_txt_so_luong_phu_thuoc.Size = new System.Drawing.Size(143, 20);
            this.m_txt_so_luong_phu_thuoc.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_cmd_save);
            this.panel1.Controls.Add(this.m_cmd_exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 267);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(955, 42);
            this.panel1.TabIndex = 6;
            // 
            // m_cmd_save
            // 
            this.m_cmd_save.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_save.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_save.Image")));
            this.m_cmd_save.Location = new System.Drawing.Point(723, 0);
            this.m_cmd_save.Name = "m_cmd_save";
            this.m_cmd_save.Size = new System.Drawing.Size(116, 42);
            this.m_cmd_save.TabIndex = 24;
            this.m_cmd_save.Text = "&Lưu";
            this.m_cmd_save.Click += new System.EventHandler(this.m_cmd_save_Click);
            // 
            // m_cmd_exit
            // 
            this.m_cmd_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_exit.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_exit.Image")));
            this.m_cmd_exit.Location = new System.Drawing.Point(839, 0);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(116, 42);
            this.m_cmd_exit.TabIndex = 23;
            this.m_cmd_exit.Text = "&Thoát";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(720, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Ngày kết thúc";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(482, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Ngày bắt đầu";
            // 
            // m_dat_ngay_bat_dau
            // 
            this.m_dat_ngay_bat_dau.CustomFormat = "dd/MM/yyyy";
            this.m_dat_ngay_bat_dau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_dat_ngay_bat_dau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.m_dat_ngay_bat_dau.Location = new System.Drawing.Point(560, 131);
            this.m_dat_ngay_bat_dau.Name = "m_dat_ngay_bat_dau";
            this.m_dat_ngay_bat_dau.ShowCheckBox = true;
            this.m_dat_ngay_bat_dau.Size = new System.Drawing.Size(128, 22);
            this.m_dat_ngay_bat_dau.TabIndex = 8;
            // 
            // m_dat_ngay_ket_thuc
            // 
            this.m_dat_ngay_ket_thuc.CustomFormat = "dd/MM/yyyy";
            this.m_dat_ngay_ket_thuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_dat_ngay_ket_thuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.m_dat_ngay_ket_thuc.Location = new System.Drawing.Point(815, 131);
            this.m_dat_ngay_ket_thuc.Name = "m_dat_ngay_ket_thuc";
            this.m_dat_ngay_ket_thuc.ShowCheckBox = true;
            this.m_dat_ngay_ket_thuc.Size = new System.Drawing.Size(128, 22);
            this.m_dat_ngay_ket_thuc.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(482, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Ngày áp dụng";
            // 
            // m_dat_ngay_ap_dung
            // 
            this.m_dat_ngay_ap_dung.CustomFormat = "dd/MM/yyyy";
            this.m_dat_ngay_ap_dung.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_dat_ngay_ap_dung.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.m_dat_ngay_ap_dung.Location = new System.Drawing.Point(562, 174);
            this.m_dat_ngay_ap_dung.Name = "m_dat_ngay_ap_dung";
            this.m_dat_ngay_ap_dung.Size = new System.Drawing.Size(128, 22);
            this.m_dat_ngay_ap_dung.TabIndex = 8;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Loại lao động";
            this.gridColumn3.FieldName = "TEN";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã nhân viên";
            this.gridColumn1.FieldName = "MA_NV";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên nhân viên";
            this.gridColumn2.FieldName = "TEN_NHAN_VIEN";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // F501_THONG_TIN_BO_SUNG_NHAN_VIEN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 309);
            this.Controls.Add(this.m_dat_ngay_ket_thuc);
            this.Controls.Add(this.m_dat_ngay_ap_dung);
            this.Controls.Add(this.m_dat_ngay_bat_dau);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.m_txt_so_luong_phu_thuoc);
            this.Controls.Add(this.m_sle_loai_lao_dong);
            this.Controls.Add(this.m_sle_ten_nv);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "F501_THONG_TIN_BO_SUNG_NHAN_VIEN";
            this.Text = "F501_THONG_TIN_BO_SUNG_NHAN_VIEN";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_sle_ten_nv.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_sle_loai_lao_dong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SearchLookUpEdit m_sle_ten_nv;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.SearchLookUpEdit m_sle_loai_lao_dong;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.TextBox m_txt_so_luong_phu_thuoc;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton m_cmd_save;
        private DevExpress.XtraEditors.SimpleButton m_cmd_exit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker m_dat_ngay_bat_dau;
        private System.Windows.Forms.DateTimePicker m_dat_ngay_ket_thuc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker m_dat_ngay_ap_dung;
    }
}