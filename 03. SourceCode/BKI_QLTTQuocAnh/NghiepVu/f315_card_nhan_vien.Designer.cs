namespace BKI_DichVuMatDat.NghiepVu
{
    partial class f315_card_nhan_vien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f315_card_nhan_vien));
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_grc_main = new DevExpress.XtraGrid.GridControl();
            this.layoutView1 = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            this.colID = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.colMA_TRA_CUU = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.colHO_TEN = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.colNGAY_SINH = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.colSO_CMT = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.colMA_NV = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.m_cmd_filter = new DevExpress.XtraEditors.SimpleButton();
            this.m_sle_chon_vi_tri = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn31 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn32 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn33 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn34 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.m_sle_chon_don_vi = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MA_DON_VI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TEN_DON_VI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.m_cmd_xuat_pdf = new DevExpress.XtraEditors.SimpleButton();
            this.layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            this.layoutViewField_colNGAY_SINH = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewField_colSO_CMT = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewField_colMA_TRA_CUU = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewField_layoutViewColumn1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewField_colHO_TEN = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewField_colID = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_sle_chon_vi_tri.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_sle_chon_don_vi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colNGAY_SINH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colSO_CMT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colMA_TRA_CUU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colHO_TEN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colID)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 410);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1022, 42);
            this.panel1.TabIndex = 2;
            // 
            // m_grc_main
            // 
            this.m_grc_main.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc_main.Location = new System.Drawing.Point(0, 99);
            this.m_grc_main.MainView = this.layoutView1;
            this.m_grc_main.Name = "m_grc_main";
            this.m_grc_main.Size = new System.Drawing.Size(1022, 311);
            this.m_grc_main.TabIndex = 1;
            this.m_grc_main.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.layoutView1});
            // 
            // layoutView1
            // 
            this.layoutView1.CardHorzInterval = 3;
            this.layoutView1.CardMinSize = new System.Drawing.Size(407, 140);
            this.layoutView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.LayoutViewColumn[] {
            this.colID,
            this.colMA_TRA_CUU,
            this.colHO_TEN,
            this.colNGAY_SINH,
            this.colSO_CMT,
            this.colMA_NV});
            this.layoutView1.GridControl = this.m_grc_main;
            this.layoutView1.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_colID});
            this.layoutView1.Name = "layoutView1";
            this.layoutView1.OptionsBehavior.Editable = false;
            this.layoutView1.OptionsBehavior.ReadOnly = true;
            this.layoutView1.OptionsItemText.AlignMode = DevExpress.XtraGrid.Views.Layout.FieldTextAlignMode.CustomSize;
            this.layoutView1.OptionsItemText.TextToControlDistance = 6;
            this.layoutView1.OptionsPrint.PrintMode = DevExpress.XtraGrid.Views.Layout.LayoutViewPrintMode.MultiRow;
            this.layoutView1.OptionsView.ShowCardCaption = false;
            this.layoutView1.OptionsView.ViewMode = DevExpress.XtraGrid.Views.Layout.LayoutViewMode.MultiRow;
            this.layoutView1.TemplateCard = this.layoutViewCard1;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.LayoutViewField = this.layoutViewField_colID;
            this.colID.Name = "colID";
            // 
            // colMA_TRA_CUU
            // 
            this.colMA_TRA_CUU.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.colMA_TRA_CUU.AppearanceCell.Options.UseFont = true;
            this.colMA_TRA_CUU.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8F);
            this.colMA_TRA_CUU.AppearanceHeader.Options.UseFont = true;
            this.colMA_TRA_CUU.Caption = "Mã tra cứu";
            this.colMA_TRA_CUU.FieldName = "MA_TRA_CUU";
            this.colMA_TRA_CUU.LayoutViewField = this.layoutViewField_colMA_TRA_CUU;
            this.colMA_TRA_CUU.Name = "colMA_TRA_CUU";
            // 
            // colHO_TEN
            // 
            this.colHO_TEN.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.colHO_TEN.AppearanceCell.Options.UseFont = true;
            this.colHO_TEN.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8F);
            this.colHO_TEN.AppearanceHeader.Options.UseFont = true;
            this.colHO_TEN.Caption = "Họ tên";
            this.colHO_TEN.FieldName = "HO_TEN";
            this.colHO_TEN.LayoutViewField = this.layoutViewField_colHO_TEN;
            this.colHO_TEN.Name = "colHO_TEN";
            this.colHO_TEN.OptionsColumn.ReadOnly = true;
            // 
            // colNGAY_SINH
            // 
            this.colNGAY_SINH.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.colNGAY_SINH.AppearanceCell.Options.UseFont = true;
            this.colNGAY_SINH.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8F);
            this.colNGAY_SINH.AppearanceHeader.Options.UseFont = true;
            this.colNGAY_SINH.Caption = "Ngày sinh";
            this.colNGAY_SINH.FieldName = "NGAY_SINH";
            this.colNGAY_SINH.LayoutViewField = this.layoutViewField_colNGAY_SINH;
            this.colNGAY_SINH.Name = "colNGAY_SINH";
            // 
            // colSO_CMT
            // 
            this.colSO_CMT.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.colSO_CMT.AppearanceCell.Options.UseFont = true;
            this.colSO_CMT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8F);
            this.colSO_CMT.AppearanceHeader.Options.UseFont = true;
            this.colSO_CMT.Caption = "Số CMT";
            this.colSO_CMT.FieldName = "SO_CMT";
            this.colSO_CMT.LayoutViewField = this.layoutViewField_colSO_CMT;
            this.colSO_CMT.Name = "colSO_CMT";
            // 
            // colMA_NV
            // 
            this.colMA_NV.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.colMA_NV.AppearanceCell.Options.UseFont = true;
            this.colMA_NV.AppearanceCell.Options.UseTextOptions = true;
            this.colMA_NV.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMA_NV.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colMA_NV.FieldName = "MA_NV";
            this.colMA_NV.LayoutViewField = this.layoutViewField_layoutViewColumn1;
            this.colMA_NV.Name = "colMA_NV";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.m_cmd_filter);
            this.panelControl1.Controls.Add(this.m_sle_chon_vi_tri);
            this.panelControl1.Controls.Add(this.m_sle_chon_don_vi);
            this.panelControl1.Controls.Add(this.m_cmd_xuat_pdf);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1022, 99);
            this.panelControl1.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 35);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(40, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Chức vụ";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 11);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(31, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Đơn vị";
            // 
            // m_cmd_filter
            // 
            this.m_cmd_filter.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.m_cmd_filter.Appearance.Options.UseFont = true;
            this.m_cmd_filter.ImageIndex = 10;
            this.m_cmd_filter.Location = new System.Drawing.Point(70, 56);
            this.m_cmd_filter.Name = "m_cmd_filter";
            this.m_cmd_filter.Size = new System.Drawing.Size(70, 30);
            this.m_cmd_filter.TabIndex = 4;
            this.m_cmd_filter.Text = "&Lọc";
            this.m_cmd_filter.Click += new System.EventHandler(this.m_cmd_filter_Click);
            // 
            // m_sle_chon_vi_tri
            // 
            this.m_sle_chon_vi_tri.Location = new System.Drawing.Point(70, 32);
            this.m_sle_chon_vi_tri.Name = "m_sle_chon_vi_tri";
            this.m_sle_chon_vi_tri.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.m_sle_chon_vi_tri.Properties.DisplayMember = "TEN_CHUC_VU";
            this.m_sle_chon_vi_tri.Properties.NullText = "--Tất cả chức vụ--";
            this.m_sle_chon_vi_tri.Properties.ValueMember = "ID";
            this.m_sle_chon_vi_tri.Properties.View = this.gridView3;
            this.m_sle_chon_vi_tri.Size = new System.Drawing.Size(314, 20);
            this.m_sle_chon_vi_tri.TabIndex = 3;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn31,
            this.gridColumn32,
            this.gridColumn33,
            this.gridColumn34});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn31
            // 
            this.gridColumn31.Caption = "ID";
            this.gridColumn31.FieldName = "ID";
            this.gridColumn31.Name = "gridColumn31";
            // 
            // gridColumn32
            // 
            this.gridColumn32.Caption = "Mã vị trí";
            this.gridColumn32.FieldName = "MA_CHUC_VU";
            this.gridColumn32.Name = "gridColumn32";
            this.gridColumn32.Visible = true;
            this.gridColumn32.VisibleIndex = 0;
            // 
            // gridColumn33
            // 
            this.gridColumn33.Caption = "Tên vị trí";
            this.gridColumn33.FieldName = "TEN_CHUC_VU";
            this.gridColumn33.Name = "gridColumn33";
            this.gridColumn33.Visible = true;
            this.gridColumn33.VisibleIndex = 1;
            // 
            // gridColumn34
            // 
            this.gridColumn34.Caption = "Ghi chú";
            this.gridColumn34.FieldName = "GHI_CHU";
            this.gridColumn34.Name = "gridColumn34";
            // 
            // m_sle_chon_don_vi
            // 
            this.m_sle_chon_don_vi.Location = new System.Drawing.Point(70, 8);
            this.m_sle_chon_don_vi.Name = "m_sle_chon_don_vi";
            this.m_sle_chon_don_vi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.m_sle_chon_don_vi.Properties.DisplayMember = "TEN_DON_VI";
            this.m_sle_chon_don_vi.Properties.NullText = "--Tất cả đơn vị--";
            this.m_sle_chon_don_vi.Properties.ValueMember = "ID";
            this.m_sle_chon_don_vi.Properties.View = this.gridView2;
            this.m_sle_chon_don_vi.Size = new System.Drawing.Size(314, 20);
            this.m_sle_chon_don_vi.TabIndex = 1;
            this.m_sle_chon_don_vi.EditValueChanged += new System.EventHandler(this.m_sle_chon_don_vi_EditValueChanged);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.MA_DON_VI,
            this.TEN_DON_VI});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            // 
            // MA_DON_VI
            // 
            this.MA_DON_VI.Caption = "Mã đơn vị";
            this.MA_DON_VI.FieldName = "MA_DON_VI";
            this.MA_DON_VI.Name = "MA_DON_VI";
            this.MA_DON_VI.Visible = true;
            this.MA_DON_VI.VisibleIndex = 0;
            // 
            // TEN_DON_VI
            // 
            this.TEN_DON_VI.Caption = "Tên đơn vị";
            this.TEN_DON_VI.FieldName = "TEN_DON_VI";
            this.TEN_DON_VI.Name = "TEN_DON_VI";
            this.TEN_DON_VI.Visible = true;
            this.TEN_DON_VI.VisibleIndex = 1;
            // 
            // m_cmd_xuat_pdf
            // 
            this.m_cmd_xuat_pdf.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_xuat_pdf.Image")));
            this.m_cmd_xuat_pdf.Location = new System.Drawing.Point(146, 56);
            this.m_cmd_xuat_pdf.Name = "m_cmd_xuat_pdf";
            this.m_cmd_xuat_pdf.Size = new System.Drawing.Size(113, 31);
            this.m_cmd_xuat_pdf.TabIndex = 5;
            this.m_cmd_xuat_pdf.Text = "Xuất PDF";
            this.m_cmd_xuat_pdf.Click += new System.EventHandler(this.m_cmd_xuat_pdf_Click);
            // 
            // layoutViewCard1
            // 
            this.layoutViewCard1.CustomizationFormText = "TemplateCard";
            this.layoutViewCard1.ExpandButtonLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutViewCard1.GroupBordersVisible = false;
            this.layoutViewCard1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_colNGAY_SINH,
            this.layoutViewField_colSO_CMT,
            this.layoutViewField_colMA_TRA_CUU,
            this.layoutViewField_layoutViewColumn1,
            this.layoutViewField_colHO_TEN});
            this.layoutViewCard1.Name = "layoutViewCard1";
            this.layoutViewCard1.OptionsItemText.TextToControlDistance = 6;
            this.layoutViewCard1.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutViewCard1.Text = "TemplateCard";
            this.layoutViewCard1.TextLocation = DevExpress.Utils.Locations.Default;
            // 
            // layoutViewField_colNGAY_SINH
            // 
            this.layoutViewField_colNGAY_SINH.EditorPreferredWidth = 314;
            this.layoutViewField_colNGAY_SINH.Location = new System.Drawing.Point(0, 68);
            this.layoutViewField_colNGAY_SINH.Name = "layoutViewField_colNGAY_SINH";
            this.layoutViewField_colNGAY_SINH.Size = new System.Drawing.Size(403, 34);
            this.layoutViewField_colNGAY_SINH.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutViewField_colNGAY_SINH.TextLocation = DevExpress.Utils.Locations.Default;
            this.layoutViewField_colNGAY_SINH.TextSize = new System.Drawing.Size(80, 30);
            this.layoutViewField_colNGAY_SINH.TextToControlDistance = 5;
            // 
            // layoutViewField_colSO_CMT
            // 
            this.layoutViewField_colSO_CMT.EditorPreferredWidth = 314;
            this.layoutViewField_colSO_CMT.Location = new System.Drawing.Point(0, 102);
            this.layoutViewField_colSO_CMT.Name = "layoutViewField_colSO_CMT";
            this.layoutViewField_colSO_CMT.Size = new System.Drawing.Size(403, 34);
            this.layoutViewField_colSO_CMT.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.SupportHorzAlignment;
            this.layoutViewField_colSO_CMT.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutViewField_colSO_CMT.TextLocation = DevExpress.Utils.Locations.Default;
            this.layoutViewField_colSO_CMT.TextSize = new System.Drawing.Size(80, 30);
            this.layoutViewField_colSO_CMT.TextToControlDistance = 5;
            // 
            // layoutViewField_colMA_TRA_CUU
            // 
            this.layoutViewField_colMA_TRA_CUU.EditorPreferredWidth = 222;
            this.layoutViewField_colMA_TRA_CUU.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_colMA_TRA_CUU.Name = "layoutViewField_colMA_TRA_CUU";
            this.layoutViewField_colMA_TRA_CUU.Size = new System.Drawing.Size(311, 34);
            this.layoutViewField_colMA_TRA_CUU.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutViewField_colMA_TRA_CUU.TextLocation = DevExpress.Utils.Locations.Default;
            this.layoutViewField_colMA_TRA_CUU.TextSize = new System.Drawing.Size(80, 30);
            this.layoutViewField_colMA_TRA_CUU.TextToControlDistance = 5;
            // 
            // layoutViewField_layoutViewColumn1
            // 
            this.layoutViewField_layoutViewColumn1.EditorPreferredWidth = 88;
            this.layoutViewField_layoutViewColumn1.Location = new System.Drawing.Point(311, 0);
            this.layoutViewField_layoutViewColumn1.Name = "layoutViewField_layoutViewColumn1";
            this.layoutViewField_layoutViewColumn1.Size = new System.Drawing.Size(92, 34);
            this.layoutViewField_layoutViewColumn1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutViewField_layoutViewColumn1.TextLocation = DevExpress.Utils.Locations.Default;
            this.layoutViewField_layoutViewColumn1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutViewField_layoutViewColumn1.TextToControlDistance = 0;
            this.layoutViewField_layoutViewColumn1.TextVisible = false;
            // 
            // layoutViewField_colHO_TEN
            // 
            this.layoutViewField_colHO_TEN.EditorPreferredWidth = 314;
            this.layoutViewField_colHO_TEN.Location = new System.Drawing.Point(0, 34);
            this.layoutViewField_colHO_TEN.Name = "layoutViewField_colHO_TEN";
            this.layoutViewField_colHO_TEN.Size = new System.Drawing.Size(403, 34);
            this.layoutViewField_colHO_TEN.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutViewField_colHO_TEN.TextLocation = DevExpress.Utils.Locations.Default;
            this.layoutViewField_colHO_TEN.TextSize = new System.Drawing.Size(80, 30);
            this.layoutViewField_colHO_TEN.TextToControlDistance = 5;
            // 
            // layoutViewField_colID
            // 
            this.layoutViewField_colID.EditorPreferredWidth = 378;
            this.layoutViewField_colID.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_colID.Name = "layoutViewField_colID";
            this.layoutViewField_colID.Size = new System.Drawing.Size(403, 136);
            this.layoutViewField_colID.TextLocation = DevExpress.Utils.Locations.Default;
            this.layoutViewField_colID.TextSize = new System.Drawing.Size(56, 20);
            this.layoutViewField_colID.TextToControlDistance = 5;
            // 
            // f315_card_nhan_vien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 452);
            this.Controls.Add(this.m_grc_main);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelControl1);
            this.Name = "f315_card_nhan_vien";
            this.Text = "F315 - Card nhân viên";
            this.Load += new System.EventHandler(this.f315_card_nhan_vien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_sle_chon_vi_tri.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_sle_chon_don_vi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colNGAY_SINH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colSO_CMT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colMA_TRA_CUU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colHO_TEN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        //private DVMDDataSet1TableAdapters.V_DM_NHAN_VIENTableAdapter v_DM_NHAN_VIENTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl m_grc_main;
        private DevExpress.XtraGrid.Views.Layout.LayoutView layoutView1;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colID;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colMA_TRA_CUU;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colHO_TEN;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colNGAY_SINH;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colSO_CMT;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton m_cmd_xuat_pdf;
        private DevExpress.XtraEditors.SearchLookUpEdit m_sle_chon_vi_tri;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn31;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn32;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn33;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn34;
        private DevExpress.XtraEditors.SearchLookUpEdit m_sle_chon_don_vi;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn MA_DON_VI;
        private DevExpress.XtraGrid.Columns.GridColumn TEN_DON_VI;
        private DevExpress.XtraEditors.SimpleButton m_cmd_filter;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colMA_NV;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colID;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colMA_TRA_CUU;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colHO_TEN;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colNGAY_SINH;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colSO_CMT;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn1;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
    }
}