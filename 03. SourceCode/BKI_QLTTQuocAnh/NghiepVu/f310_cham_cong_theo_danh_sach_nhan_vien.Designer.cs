namespace BKI_DichVuMatDat.NghiepVu
{
    partial class f310_cham_cong_theo_danh_sach_nhan_vien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f310_cham_cong_theo_danh_sach_nhan_vien));
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_cmd_search = new SIS.Controls.Button.SiSButton();
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.m_dat_ngay_cham_cong = new System.Windows.Forms.DateTimePicker();
            this.m_lbl_header = new System.Windows.Forms.Label();
            this.m_lbl_ngay_cham_cong = new System.Windows.Forms.Label();
            this.m_grc_cham_cong = new DevExpress.XtraGrid.GridControl();
            this.m_grv_cham_cong = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MA_NV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HO_TEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MA_NGAY_CONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.m_le_loai_ngay_cong = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.m_sle_loai_ngay_cong = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dMLOAINGAYCONGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bKI_DVMDDataSet = new BKI_DichVuMatDat.BKI_DVMDDataSet();
            this.dM_LOAI_NGAY_CONGTableAdapter = new BKI_DichVuMatDat.BKI_DVMDDataSetTableAdapters.DM_LOAI_NGAY_CONGTableAdapter();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.m_cmd_insert = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_cham_cong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_cham_cong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_le_loai_ngay_cong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_sle_loai_ngay_cong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMLOAINGAYCONGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bKI_DVMDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_cmd_search);
            this.panel1.Controls.Add(this.m_dat_ngay_cham_cong);
            this.panel1.Controls.Add(this.m_lbl_header);
            this.panel1.Controls.Add(this.m_lbl_ngay_cham_cong);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1032, 81);
            this.panel1.TabIndex = 1;
            // 
            // m_cmd_search
            // 
            this.m_cmd_search.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_search.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_search.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_search.ImageIndex = 5;
            this.m_cmd_search.ImageList = this.ImageList;
            this.m_cmd_search.Location = new System.Drawing.Point(329, 47);
            this.m_cmd_search.Name = "m_cmd_search";
            this.m_cmd_search.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_search.TabIndex = 9;
            this.m_cmd_search.Text = "Lọc dữ liệu";
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
            // m_dat_ngay_cham_cong
            // 
            this.m_dat_ngay_cham_cong.CustomFormat = "dd/MM/yyyy";
            this.m_dat_ngay_cham_cong.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.m_dat_ngay_cham_cong.Location = new System.Drawing.Point(124, 52);
            this.m_dat_ngay_cham_cong.Name = "m_dat_ngay_cham_cong";
            this.m_dat_ngay_cham_cong.Size = new System.Drawing.Size(164, 20);
            this.m_dat_ngay_cham_cong.TabIndex = 8;
            // 
            // m_lbl_header
            // 
            this.m_lbl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.m_lbl_header.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_header.Location = new System.Drawing.Point(0, 0);
            this.m_lbl_header.Name = "m_lbl_header";
            this.m_lbl_header.Size = new System.Drawing.Size(1032, 44);
            this.m_lbl_header.TabIndex = 0;
            this.m_lbl_header.Text = "CHẤM CÔNG NHÂN VIÊN";
            this.m_lbl_header.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // m_lbl_ngay_cham_cong
            // 
            this.m_lbl_ngay_cham_cong.AutoSize = true;
            this.m_lbl_ngay_cham_cong.Location = new System.Drawing.Point(30, 55);
            this.m_lbl_ngay_cham_cong.Name = "m_lbl_ngay_cham_cong";
            this.m_lbl_ngay_cham_cong.Size = new System.Drawing.Size(88, 13);
            this.m_lbl_ngay_cham_cong.TabIndex = 5;
            this.m_lbl_ngay_cham_cong.Text = "Ngày chấm công";
            // 
            // m_grc_cham_cong
            // 
            this.m_grc_cham_cong.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_cham_cong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc_cham_cong.Location = new System.Drawing.Point(0, 0);
            this.m_grc_cham_cong.MainView = this.m_grv_cham_cong;
            this.m_grc_cham_cong.Name = "m_grc_cham_cong";
            this.m_grc_cham_cong.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.m_le_loai_ngay_cong,
            this.m_sle_loai_ngay_cong});
            this.m_grc_cham_cong.Size = new System.Drawing.Size(1032, 351);
            this.m_grc_cham_cong.TabIndex = 2;
            this.m_grc_cham_cong.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv_cham_cong});
            // 
            // m_grv_cham_cong
            // 
            this.m_grv_cham_cong.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.STT,
            this.MA_NV,
            this.HO_TEN,
            this.MA_NGAY_CONG});
            this.m_grv_cham_cong.GridControl = this.m_grc_cham_cong;
            this.m_grv_cham_cong.Name = "m_grv_cham_cong";
            this.m_grv_cham_cong.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.Inplace;
            this.m_grv_cham_cong.OptionsFind.AllowFindPanel = false;
            this.m_grv_cham_cong.OptionsFind.AlwaysVisible = true;
            this.m_grv_cham_cong.OptionsView.ShowFooter = true;
            this.m_grv_cham_cong.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.m_grv_cham_cong_PopupMenuShowing);
            this.m_grv_cham_cong.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.m_grv_cham_cong_CellValueChanging);
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            // 
            // STT
            // 
            this.STT.Caption = "STT";
            this.STT.FieldName = "STT";
            this.STT.Name = "STT";
            this.STT.Visible = true;
            this.STT.VisibleIndex = 0;
            this.STT.Width = 38;
            // 
            // MA_NV
            // 
            this.MA_NV.Caption = "Mã NV";
            this.MA_NV.FieldName = "MA_NV";
            this.MA_NV.Name = "MA_NV";
            this.MA_NV.Visible = true;
            this.MA_NV.VisibleIndex = 1;
            this.MA_NV.Width = 50;
            // 
            // HO_TEN
            // 
            this.HO_TEN.Caption = "Họ tên";
            this.HO_TEN.FieldName = "HO_TEN";
            this.HO_TEN.Name = "HO_TEN";
            this.HO_TEN.Visible = true;
            this.HO_TEN.VisibleIndex = 2;
            this.HO_TEN.Width = 200;
            // 
            // MA_NGAY_CONG
            // 
            this.MA_NGAY_CONG.Caption = "Chấm công";
            this.MA_NGAY_CONG.FieldName = "MA_NGAY_CONG";
            this.MA_NGAY_CONG.Name = "MA_NGAY_CONG";
            this.MA_NGAY_CONG.OptionsColumn.AllowEdit = false;
            this.MA_NGAY_CONG.Visible = true;
            this.MA_NGAY_CONG.VisibleIndex = 3;
            this.MA_NGAY_CONG.Width = 726;
            // 
            // m_le_loai_ngay_cong
            // 
            this.m_le_loai_ngay_cong.AutoHeight = false;
            this.m_le_loai_ngay_cong.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.m_le_loai_ngay_cong.Name = "m_le_loai_ngay_cong";
            this.m_le_loai_ngay_cong.NullText = "";
            // 
            // m_sle_loai_ngay_cong
            // 
            this.m_sle_loai_ngay_cong.AutoHeight = false;
            this.m_sle_loai_ngay_cong.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.m_sle_loai_ngay_cong.Name = "m_sle_loai_ngay_cong";
            this.m_sle_loai_ngay_cong.NullText = "";
            this.m_sle_loai_ngay_cong.View = this.repositoryItemSearchLookUpEdit1View;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // dMLOAINGAYCONGBindingSource
            // 
            this.dMLOAINGAYCONGBindingSource.DataMember = "DM_LOAI_NGAY_CONG";
            this.dMLOAINGAYCONGBindingSource.DataSource = this.bKI_DVMDDataSet;
            // 
            // bKI_DVMDDataSet
            // 
            this.bKI_DVMDDataSet.DataSetName = "BKI_DVMDDataSet";
            this.bKI_DVMDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dM_LOAI_NGAY_CONGTableAdapter
            // 
            this.dM_LOAI_NGAY_CONGTableAdapter.ClearBeforeFill = true;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.m_cmd_insert);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 432);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1032, 42);
            this.panelControl1.TabIndex = 3;
            // 
            // m_cmd_insert
            // 
            this.m_cmd_insert.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_insert.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_insert.Image")));
            this.m_cmd_insert.Location = new System.Drawing.Point(937, 2);
            this.m_cmd_insert.Name = "m_cmd_insert";
            this.m_cmd_insert.Size = new System.Drawing.Size(93, 38);
            this.m_cmd_insert.TabIndex = 0;
            this.m_cmd_insert.Text = "Lưu";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.m_grc_cham_cong);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1032, 351);
            this.panel2.TabIndex = 4;
            // 
            // f310_cham_cong_theo_danh_sach_nhan_vien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 474);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panel1);
            this.Name = "f310_cham_cong_theo_danh_sach_nhan_vien";
            this.Text = "F310 - Chấm công nhân viên";
            this.Load += new System.EventHandler(this.f310_cham_cong_theo_danh_sach_nhan_vien_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_cham_cong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_cham_cong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_le_loai_ngay_cong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_sle_loai_ngay_cong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMLOAINGAYCONGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bKI_DVMDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label m_lbl_header;
        private System.Windows.Forms.Label m_lbl_ngay_cham_cong;
        private System.Windows.Forms.DateTimePicker m_dat_ngay_cham_cong;
        private DevExpress.XtraGrid.GridControl m_grc_cham_cong;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv_cham_cong;
        internal SIS.Controls.Button.SiSButton m_cmd_search;
        internal System.Windows.Forms.ImageList ImageList;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn MA_NV;
        private DevExpress.XtraGrid.Columns.GridColumn HO_TEN;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
        private DevExpress.XtraGrid.Columns.GridColumn MA_NGAY_CONG;
        private BKI_DVMDDataSet bKI_DVMDDataSet;
        private System.Windows.Forms.BindingSource dMLOAINGAYCONGBindingSource;
        private BKI_DVMDDataSetTableAdapters.DM_LOAI_NGAY_CONGTableAdapter dM_LOAI_NGAY_CONGTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit m_le_loai_ngay_cong;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit m_sle_loai_ngay_cong;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton m_cmd_insert;
        private System.Windows.Forms.Panel panel2;
    }
}