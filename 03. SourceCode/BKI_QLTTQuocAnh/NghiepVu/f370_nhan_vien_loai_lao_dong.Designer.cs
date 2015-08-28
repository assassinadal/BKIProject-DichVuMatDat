namespace BKI_DichVuMatDat.NghiepVu
{
    partial class f370_nhan_vien_loai_lao_dong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f370_nhan_vien_loai_lao_dong));
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_lbl_header = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.m_cmd_insert = new SIS.Controls.Button.SiSButton();
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.m_cmd_edit = new SIS.Controls.Button.SiSButton();
            this.m_cmd_delete = new SIS.Controls.Button.SiSButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.m_grc_v_gd_loai_lao_dong = new DevExpress.XtraGrid.GridControl();
            this.m_grv_v_gd_loai_lao_dong = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.c_stt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_ID_NHAN_VIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_ma_nv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_ho_dem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_ten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_ho_ten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_id_loai_lao_dong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_ten_loai_lao_dong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_ngay_bat_dau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_ngay_ket_thuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_v_gd_loai_lao_dong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_v_gd_loai_lao_dong)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_lbl_header);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 53);
            this.panel1.TabIndex = 0;
            // 
            // m_lbl_header
            // 
            this.m_lbl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.m_lbl_header.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_header.Location = new System.Drawing.Point(0, 0);
            this.m_lbl_header.Name = "m_lbl_header";
            this.m_lbl_header.Size = new System.Drawing.Size(782, 50);
            this.m_lbl_header.TabIndex = 1;
            this.m_lbl_header.Text = "NHÂN VIÊN - LOẠI LAO ĐỘNG";
            this.m_lbl_header.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.m_cmd_insert);
            this.panel2.Controls.Add(this.m_cmd_edit);
            this.panel2.Controls.Add(this.m_cmd_delete);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 341);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(782, 38);
            this.panel2.TabIndex = 1;
            // 
            // m_cmd_insert
            // 
            this.m_cmd_insert.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_insert.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_insert.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_insert.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_insert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_insert.ImageIndex = 2;
            this.m_cmd_insert.ImageList = this.ImageList;
            this.m_cmd_insert.Location = new System.Drawing.Point(518, 0);
            this.m_cmd_insert.Name = "m_cmd_insert";
            this.m_cmd_insert.Size = new System.Drawing.Size(88, 38);
            this.m_cmd_insert.TabIndex = 3;
            this.m_cmd_insert.Text = "&Thêm";
            this.m_cmd_insert.Click += new System.EventHandler(this.m_cmd_insert_Click);
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
            // m_cmd_edit
            // 
            this.m_cmd_edit.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_edit.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_edit.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_edit.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_edit.ImageIndex = 16;
            this.m_cmd_edit.ImageList = this.ImageList;
            this.m_cmd_edit.Location = new System.Drawing.Point(606, 0);
            this.m_cmd_edit.Name = "m_cmd_edit";
            this.m_cmd_edit.Size = new System.Drawing.Size(88, 38);
            this.m_cmd_edit.TabIndex = 2;
            this.m_cmd_edit.Text = "&Sửa";
            this.m_cmd_edit.Click += new System.EventHandler(this.m_cmd_edit_Click);
            // 
            // m_cmd_delete
            // 
            this.m_cmd_delete.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_delete.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_delete.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_delete.ImageIndex = 4;
            this.m_cmd_delete.ImageList = this.ImageList;
            this.m_cmd_delete.Location = new System.Drawing.Point(694, 0);
            this.m_cmd_delete.Name = "m_cmd_delete";
            this.m_cmd_delete.Size = new System.Drawing.Size(88, 38);
            this.m_cmd_delete.TabIndex = 1;
            this.m_cmd_delete.Text = "&Xóa";
            this.m_cmd_delete.Click += new System.EventHandler(this.m_cmd_delete_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.m_grc_v_gd_loai_lao_dong);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 53);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(782, 288);
            this.panel3.TabIndex = 4;
            // 
            // m_grc_v_gd_loai_lao_dong
            // 
            this.m_grc_v_gd_loai_lao_dong.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_v_gd_loai_lao_dong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc_v_gd_loai_lao_dong.Location = new System.Drawing.Point(0, 0);
            this.m_grc_v_gd_loai_lao_dong.MainView = this.m_grv_v_gd_loai_lao_dong;
            this.m_grc_v_gd_loai_lao_dong.Name = "m_grc_v_gd_loai_lao_dong";
            this.m_grc_v_gd_loai_lao_dong.Size = new System.Drawing.Size(782, 288);
            this.m_grc_v_gd_loai_lao_dong.TabIndex = 1;
            this.m_grc_v_gd_loai_lao_dong.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv_v_gd_loai_lao_dong});
            // 
            // m_grv_v_gd_loai_lao_dong
            // 
            this.m_grv_v_gd_loai_lao_dong.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.c_ID,
            this.c_stt,
            this.c_ID_NHAN_VIEN,
            this.c_ma_nv,
            this.c_ho_dem,
            this.c_ten,
            this.c_ho_ten,
            this.c_id_loai_lao_dong,
            this.c_ten_loai_lao_dong,
            this.c_ngay_bat_dau,
            this.c_ngay_ket_thuc});
            this.m_grv_v_gd_loai_lao_dong.GridControl = this.m_grc_v_gd_loai_lao_dong;
            this.m_grv_v_gd_loai_lao_dong.Name = "m_grv_v_gd_loai_lao_dong";
            this.m_grv_v_gd_loai_lao_dong.OptionsFind.AllowFindPanel = false;
            this.m_grv_v_gd_loai_lao_dong.OptionsFind.AlwaysVisible = true;
            this.m_grv_v_gd_loai_lao_dong.OptionsView.ShowFooter = true;
            // 
            // c_stt
            // 
            this.c_stt.Caption = "STT";
            this.c_stt.FieldName = "STT";
            this.c_stt.Name = "c_stt";
            this.c_stt.Visible = true;
            this.c_stt.VisibleIndex = 0;
            this.c_stt.Width = 38;
            // 
            // c_ID_NHAN_VIEN
            // 
            this.c_ID_NHAN_VIEN.Caption = "ID Nhân viên";
            this.c_ID_NHAN_VIEN.FieldName = "ID_NHAN_VIEN";
            this.c_ID_NHAN_VIEN.Name = "c_ID_NHAN_VIEN";
            this.c_ID_NHAN_VIEN.Width = 149;
            // 
            // c_ma_nv
            // 
            this.c_ma_nv.Caption = "Mã NV";
            this.c_ma_nv.FieldName = "MA_NV";
            this.c_ma_nv.Name = "c_ma_nv";
            this.c_ma_nv.Visible = true;
            this.c_ma_nv.VisibleIndex = 1;
            this.c_ma_nv.Width = 149;
            // 
            // c_ho_dem
            // 
            this.c_ho_dem.Caption = "Họ đệm";
            this.c_ho_dem.FieldName = "HO_DEM";
            this.c_ho_dem.Name = "c_ho_dem";
            this.c_ho_dem.Visible = true;
            this.c_ho_dem.VisibleIndex = 2;
            this.c_ho_dem.Width = 149;
            // 
            // c_ten
            // 
            this.c_ten.Caption = "Tên";
            this.c_ten.FieldName = "TEN";
            this.c_ten.Name = "c_ten";
            this.c_ten.Visible = true;
            this.c_ten.VisibleIndex = 3;
            this.c_ten.Width = 150;
            // 
            // c_ho_ten
            // 
            this.c_ho_ten.Caption = "Họ tên";
            this.c_ho_ten.FieldName = "HO_TEN";
            this.c_ho_ten.Name = "c_ho_ten";
            // 
            // c_id_loai_lao_dong
            // 
            this.c_id_loai_lao_dong.Caption = "ID Loại lao động";
            this.c_id_loai_lao_dong.FieldName = "ID_LOAI_LAO_DONG";
            this.c_id_loai_lao_dong.Name = "c_id_loai_lao_dong";
            // 
            // c_ten_loai_lao_dong
            // 
            this.c_ten_loai_lao_dong.Caption = "Tên loại lao động";
            this.c_ten_loai_lao_dong.FieldName = "TEN_LOAI_LAO_DONG";
            this.c_ten_loai_lao_dong.Name = "c_ten_loai_lao_dong";
            this.c_ten_loai_lao_dong.Visible = true;
            this.c_ten_loai_lao_dong.VisibleIndex = 4;
            // 
            // c_ngay_bat_dau
            // 
            this.c_ngay_bat_dau.Caption = "Ngày bắt đầu";
            this.c_ngay_bat_dau.FieldName = "NGAY_BAT_DAU";
            this.c_ngay_bat_dau.Name = "c_ngay_bat_dau";
            this.c_ngay_bat_dau.Visible = true;
            this.c_ngay_bat_dau.VisibleIndex = 5;
            // 
            // c_ngay_ket_thuc
            // 
            this.c_ngay_ket_thuc.Caption = "Ngày kết thúc";
            this.c_ngay_ket_thuc.FieldName = "NGAY_KET_THUC";
            this.c_ngay_ket_thuc.Name = "c_ngay_ket_thuc";
            this.c_ngay_ket_thuc.Visible = true;
            this.c_ngay_ket_thuc.VisibleIndex = 6;
            // 
            // c_ID
            // 
            this.c_ID.Caption = "ID";
            this.c_ID.FieldName = "ID";
            this.c_ID.Name = "c_ID";
            // 
            // f370_nhan_vien_loai_lao_dong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 379);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "f370_nhan_vien_loai_lao_dong";
            this.Text = "f370 - NHÂN VIÊN LOẠI LAO ĐỘNG";
            this.Load += new System.EventHandler(this.f370_nhan_vien_loai_lao_dong_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_v_gd_loai_lao_dong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_v_gd_loai_lao_dong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label m_lbl_header;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraGrid.GridControl m_grc_v_gd_loai_lao_dong;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv_v_gd_loai_lao_dong;
        private DevExpress.XtraGrid.Columns.GridColumn c_stt;
        private DevExpress.XtraGrid.Columns.GridColumn c_ID_NHAN_VIEN;
        private DevExpress.XtraGrid.Columns.GridColumn c_ma_nv;
        private DevExpress.XtraGrid.Columns.GridColumn c_ho_dem;
        private DevExpress.XtraGrid.Columns.GridColumn c_ten;
        private DevExpress.XtraGrid.Columns.GridColumn c_ho_ten;
        private DevExpress.XtraGrid.Columns.GridColumn c_id_loai_lao_dong;
        private DevExpress.XtraGrid.Columns.GridColumn c_ten_loai_lao_dong;
        private DevExpress.XtraGrid.Columns.GridColumn c_ngay_bat_dau;
        private DevExpress.XtraGrid.Columns.GridColumn c_ngay_ket_thuc;
        internal SIS.Controls.Button.SiSButton m_cmd_insert;
        internal SIS.Controls.Button.SiSButton m_cmd_edit;
        internal SIS.Controls.Button.SiSButton m_cmd_delete;
        internal System.Windows.Forms.ImageList ImageList;
        private DevExpress.XtraGrid.Columns.GridColumn c_ID;
    }
}