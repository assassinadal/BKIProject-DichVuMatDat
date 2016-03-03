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
            this.m_grc_main = new DevExpress.XtraGrid.GridControl();
            this.layoutView1 = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            this.colID = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.colMA_TRA_CUU = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.colHO_TEN = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.colNGAY_SINH = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.colSO_CMT = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.m_cmd_xuat_pdf = new DevExpress.XtraEditors.SimpleButton();
            this.layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            this.layoutViewField_colMA_TRA_CUU = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewField_colHO_TEN = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewField_colNGAY_SINH = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewField_colSO_CMT = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.Item1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colMA_TRA_CUU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colHO_TEN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colNGAY_SINH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colSO_CMT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Item1)).BeginInit();
            this.SuspendLayout();
            // 
            // m_grc_main
            // 
            this.m_grc_main.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc_main.Location = new System.Drawing.Point(0, 0);
            this.m_grc_main.MainView = this.layoutView1;
            this.m_grc_main.Name = "m_grc_main";
            this.m_grc_main.Size = new System.Drawing.Size(733, 452);
            this.m_grc_main.TabIndex = 0;
            this.m_grc_main.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.layoutView1});
            // 
            // layoutView1
            // 
            this.layoutView1.CardMinSize = new System.Drawing.Size(419, 102);
            this.layoutView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.LayoutViewColumn[] {
            this.colID,
            this.colMA_TRA_CUU,
            this.colHO_TEN,
            this.colNGAY_SINH,
            this.colSO_CMT});
            this.layoutView1.GridControl = this.m_grc_main;
            this.layoutView1.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.Item1});
            this.layoutView1.Name = "layoutView1";
            this.layoutView1.OptionsBehavior.Editable = false;
            this.layoutView1.OptionsBehavior.ReadOnly = true;
            this.layoutView1.OptionsItemText.AlignMode = DevExpress.XtraGrid.Views.Layout.FieldTextAlignMode.CustomSize;
            this.layoutView1.OptionsPrint.PrintMode = DevExpress.XtraGrid.Views.Layout.LayoutViewPrintMode.MultiRow;
            this.layoutView1.OptionsView.ShowCardCaption = false;
            this.layoutView1.OptionsView.ViewMode = DevExpress.XtraGrid.Views.Layout.LayoutViewMode.Carousel;
            this.layoutView1.TemplateCard = this.layoutViewCard1;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.LayoutViewField = this.Item1;
            this.colID.Name = "colID";
            // 
            // colMA_TRA_CUU
            // 
            this.colMA_TRA_CUU.Caption = "Mã tra cứu";
            this.colMA_TRA_CUU.FieldName = "MA_TRA_CUU";
            this.colMA_TRA_CUU.LayoutViewField = this.layoutViewField_colMA_TRA_CUU;
            this.colMA_TRA_CUU.Name = "colMA_TRA_CUU";
            // 
            // colHO_TEN
            // 
            this.colHO_TEN.Caption = "Họ tên";
            this.colHO_TEN.FieldName = "HO_TEN";
            this.colHO_TEN.LayoutViewField = this.layoutViewField_colHO_TEN;
            this.colHO_TEN.Name = "colHO_TEN";
            this.colHO_TEN.OptionsColumn.ReadOnly = true;
            // 
            // colNGAY_SINH
            // 
            this.colNGAY_SINH.Caption = "Ngày sinh";
            this.colNGAY_SINH.FieldName = "NGAY_SINH";
            this.colNGAY_SINH.LayoutViewField = this.layoutViewField_colNGAY_SINH;
            this.colNGAY_SINH.Name = "colNGAY_SINH";
            // 
            // colSO_CMT
            // 
            this.colSO_CMT.Caption = "Số CMT";
            this.colSO_CMT.FieldName = "SO_CMT";
            this.colSO_CMT.LayoutViewField = this.layoutViewField_colSO_CMT;
            this.colSO_CMT.Name = "colSO_CMT";
            // 
            // m_cmd_xuat_pdf
            // 
            this.m_cmd_xuat_pdf.Location = new System.Drawing.Point(103, 4);
            this.m_cmd_xuat_pdf.Name = "m_cmd_xuat_pdf";
            this.m_cmd_xuat_pdf.Size = new System.Drawing.Size(75, 23);
            this.m_cmd_xuat_pdf.TabIndex = 1;
            this.m_cmd_xuat_pdf.Text = "Xuất PDF";
            this.m_cmd_xuat_pdf.Click += new System.EventHandler(this.m_cmd_xuat_pdf_Click);
            // 
            // layoutViewCard1
            // 
            this.layoutViewCard1.CustomizationFormText = "TemplateCard";
            this.layoutViewCard1.ExpandButtonLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutViewCard1.GroupBordersVisible = false;
            this.layoutViewCard1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_colMA_TRA_CUU,
            this.layoutViewField_colHO_TEN,
            this.layoutViewField_colNGAY_SINH,
            this.layoutViewField_colSO_CMT});
            this.layoutViewCard1.Name = "layoutViewCard1";
            this.layoutViewCard1.OptionsItemText.TextToControlDistance = 5;
            this.layoutViewCard1.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutViewCard1.Text = "TemplateCard";
            this.layoutViewCard1.TextLocation = DevExpress.Utils.Locations.Default;
            // 
            // layoutViewField_colMA_TRA_CUU
            // 
            this.layoutViewField_colMA_TRA_CUU.EditorPreferredWidth = 350;
            this.layoutViewField_colMA_TRA_CUU.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_colMA_TRA_CUU.Name = "layoutViewField_colMA_TRA_CUU";
            this.layoutViewField_colMA_TRA_CUU.Size = new System.Drawing.Size(415, 24);
            this.layoutViewField_colMA_TRA_CUU.TextSize = new System.Drawing.Size(56, 13);
            // 
            // layoutViewField_colHO_TEN
            // 
            this.layoutViewField_colHO_TEN.EditorPreferredWidth = 350;
            this.layoutViewField_colHO_TEN.Location = new System.Drawing.Point(0, 24);
            this.layoutViewField_colHO_TEN.Name = "layoutViewField_colHO_TEN";
            this.layoutViewField_colHO_TEN.Size = new System.Drawing.Size(415, 24);
            this.layoutViewField_colHO_TEN.TextSize = new System.Drawing.Size(56, 13);
            // 
            // layoutViewField_colNGAY_SINH
            // 
            this.layoutViewField_colNGAY_SINH.EditorPreferredWidth = 350;
            this.layoutViewField_colNGAY_SINH.Location = new System.Drawing.Point(0, 48);
            this.layoutViewField_colNGAY_SINH.Name = "layoutViewField_colNGAY_SINH";
            this.layoutViewField_colNGAY_SINH.Size = new System.Drawing.Size(415, 24);
            this.layoutViewField_colNGAY_SINH.TextSize = new System.Drawing.Size(56, 13);
            // 
            // layoutViewField_colSO_CMT
            // 
            this.layoutViewField_colSO_CMT.EditorPreferredWidth = 350;
            this.layoutViewField_colSO_CMT.Location = new System.Drawing.Point(0, 72);
            this.layoutViewField_colSO_CMT.Name = "layoutViewField_colSO_CMT";
            this.layoutViewField_colSO_CMT.Size = new System.Drawing.Size(415, 26);
            this.layoutViewField_colSO_CMT.TextSize = new System.Drawing.Size(56, 13);
            // 
            // Item1
            // 
            this.Item1.EditorPreferredWidth = 178;
            this.Item1.Location = new System.Drawing.Point(0, 0);
            this.Item1.Name = "Item1";
            this.Item1.Size = new System.Drawing.Size(414, 157);
            this.Item1.TextSize = new System.Drawing.Size(56, 13);
            // 
            // f315_card_nhan_vien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 452);
            this.Controls.Add(this.m_cmd_xuat_pdf);
            this.Controls.Add(this.m_grc_main);
            this.Name = "f315_card_nhan_vien";
            this.Text = "F315 - Card nhân viên";
            this.Load += new System.EventHandler(this.f315_card_nhan_vien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colMA_TRA_CUU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colHO_TEN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colNGAY_SINH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colSO_CMT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Item1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl m_grc_main;
        //private DVMDDataSet1TableAdapters.V_DM_NHAN_VIENTableAdapter v_DM_NHAN_VIENTableAdapter;
        private DevExpress.XtraEditors.SimpleButton m_cmd_xuat_pdf;
        private DevExpress.XtraGrid.Views.Layout.LayoutView layoutView1;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colID;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colMA_TRA_CUU;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colNGAY_SINH;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colSO_CMT;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colHO_TEN;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField Item1;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colMA_TRA_CUU;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colHO_TEN;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colNGAY_SINH;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colSO_CMT;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
    }
}