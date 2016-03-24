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
            this.m_cmd_xuat_pdf = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_grc_main = new DevExpress.XtraGrid.GridControl();
            this.layoutView1 = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            this.colID = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colID = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colMA_TRA_CUU = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colMA_TRA_CUU = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colHO_TEN = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colHO_TEN = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colNGAY_SINH = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colNGAY_SINH = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colSO_CMT = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colSO_CMT = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colMA_TRA_CUU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colHO_TEN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colNGAY_SINH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colSO_CMT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).BeginInit();
            this.SuspendLayout();
            // 
            // m_cmd_xuat_pdf
            // 
            this.m_cmd_xuat_pdf.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_xuat_pdf.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_xuat_pdf.Image")));
            this.m_cmd_xuat_pdf.Location = new System.Drawing.Point(909, 0);
            this.m_cmd_xuat_pdf.Name = "m_cmd_xuat_pdf";
            this.m_cmd_xuat_pdf.Size = new System.Drawing.Size(113, 42);
            this.m_cmd_xuat_pdf.TabIndex = 1;
            this.m_cmd_xuat_pdf.Text = "Xuất PDF";
            this.m_cmd_xuat_pdf.Click += new System.EventHandler(this.m_cmd_xuat_pdf_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_cmd_xuat_pdf);
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
            this.m_grc_main.Location = new System.Drawing.Point(0, 0);
            this.m_grc_main.MainView = this.layoutView1;
            this.m_grc_main.Name = "m_grc_main";
            this.m_grc_main.Size = new System.Drawing.Size(1022, 410);
            this.m_grc_main.TabIndex = 3;
            this.m_grc_main.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.layoutView1});
            // 
            // layoutView1
            // 
            this.layoutView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.layoutView1.CardHorzInterval = 3;
            this.layoutView1.CardMinSize = new System.Drawing.Size(296, 100);
            this.layoutView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.LayoutViewColumn[] {
            this.colID,
            this.colMA_TRA_CUU,
            this.colHO_TEN,
            this.colNGAY_SINH,
            this.colSO_CMT});
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
            // layoutViewField_colID
            // 
            this.layoutViewField_colID.EditorPreferredWidth = 378;
            this.layoutViewField_colID.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_colID.Name = "layoutViewField_colID";
            this.layoutViewField_colID.Size = new System.Drawing.Size(347, 96);
            this.layoutViewField_colID.TextLocation = DevExpress.Utils.Locations.Default;
            this.layoutViewField_colID.TextSize = new System.Drawing.Size(56, 20);
            // 
            // colMA_TRA_CUU
            // 
            this.colMA_TRA_CUU.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.colMA_TRA_CUU.AppearanceCell.Options.UseFont = true;
            this.colMA_TRA_CUU.Caption = "Mã tra cứu";
            this.colMA_TRA_CUU.FieldName = "MA_TRA_CUU";
            this.colMA_TRA_CUU.LayoutViewField = this.layoutViewField_colMA_TRA_CUU;
            this.colMA_TRA_CUU.Name = "colMA_TRA_CUU";
            // 
            // layoutViewField_colMA_TRA_CUU
            // 
            this.layoutViewField_colMA_TRA_CUU.EditorPreferredWidth = 227;
            this.layoutViewField_colMA_TRA_CUU.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_colMA_TRA_CUU.Name = "layoutViewField_colMA_TRA_CUU";
            this.layoutViewField_colMA_TRA_CUU.Size = new System.Drawing.Size(292, 24);
            this.layoutViewField_colMA_TRA_CUU.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutViewField_colMA_TRA_CUU.TextLocation = DevExpress.Utils.Locations.Default;
            this.layoutViewField_colMA_TRA_CUU.TextSize = new System.Drawing.Size(56, 20);
            this.layoutViewField_colMA_TRA_CUU.TextToControlDistance = 5;
            // 
            // colHO_TEN
            // 
            this.colHO_TEN.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.colHO_TEN.AppearanceCell.Options.UseFont = true;
            this.colHO_TEN.Caption = "Họ tên";
            this.colHO_TEN.FieldName = "HO_TEN";
            this.colHO_TEN.LayoutViewField = this.layoutViewField_colHO_TEN;
            this.colHO_TEN.Name = "colHO_TEN";
            this.colHO_TEN.OptionsColumn.ReadOnly = true;
            // 
            // layoutViewField_colHO_TEN
            // 
            this.layoutViewField_colHO_TEN.EditorPreferredWidth = 227;
            this.layoutViewField_colHO_TEN.Location = new System.Drawing.Point(0, 24);
            this.layoutViewField_colHO_TEN.Name = "layoutViewField_colHO_TEN";
            this.layoutViewField_colHO_TEN.Size = new System.Drawing.Size(292, 24);
            this.layoutViewField_colHO_TEN.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutViewField_colHO_TEN.TextLocation = DevExpress.Utils.Locations.Default;
            this.layoutViewField_colHO_TEN.TextSize = new System.Drawing.Size(56, 20);
            this.layoutViewField_colHO_TEN.TextToControlDistance = 5;
            // 
            // colNGAY_SINH
            // 
            this.colNGAY_SINH.Caption = "Ngày sinh";
            this.colNGAY_SINH.FieldName = "NGAY_SINH";
            this.colNGAY_SINH.LayoutViewField = this.layoutViewField_colNGAY_SINH;
            this.colNGAY_SINH.Name = "colNGAY_SINH";
            // 
            // layoutViewField_colNGAY_SINH
            // 
            this.layoutViewField_colNGAY_SINH.EditorPreferredWidth = 227;
            this.layoutViewField_colNGAY_SINH.Location = new System.Drawing.Point(0, 48);
            this.layoutViewField_colNGAY_SINH.Name = "layoutViewField_colNGAY_SINH";
            this.layoutViewField_colNGAY_SINH.Size = new System.Drawing.Size(292, 24);
            this.layoutViewField_colNGAY_SINH.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutViewField_colNGAY_SINH.TextLocation = DevExpress.Utils.Locations.Default;
            this.layoutViewField_colNGAY_SINH.TextSize = new System.Drawing.Size(56, 20);
            this.layoutViewField_colNGAY_SINH.TextToControlDistance = 5;
            // 
            // colSO_CMT
            // 
            this.colSO_CMT.Caption = "Số CMT";
            this.colSO_CMT.FieldName = "SO_CMT";
            this.colSO_CMT.LayoutViewField = this.layoutViewField_colSO_CMT;
            this.colSO_CMT.Name = "colSO_CMT";
            // 
            // layoutViewField_colSO_CMT
            // 
            this.layoutViewField_colSO_CMT.EditorPreferredWidth = 227;
            this.layoutViewField_colSO_CMT.Location = new System.Drawing.Point(0, 72);
            this.layoutViewField_colSO_CMT.Name = "layoutViewField_colSO_CMT";
            this.layoutViewField_colSO_CMT.Size = new System.Drawing.Size(292, 24);
            this.layoutViewField_colSO_CMT.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.SupportHorzAlignment;
            this.layoutViewField_colSO_CMT.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutViewField_colSO_CMT.TextLocation = DevExpress.Utils.Locations.Default;
            this.layoutViewField_colSO_CMT.TextSize = new System.Drawing.Size(56, 20);
            this.layoutViewField_colSO_CMT.TextToControlDistance = 5;
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
            this.layoutViewCard1.Name = "layoutViewTemplateCard";
            this.layoutViewCard1.OptionsItemText.TextToControlDistance = 6;
            this.layoutViewCard1.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutViewCard1.Text = "TemplateCard";
            this.layoutViewCard1.TextLocation = DevExpress.Utils.Locations.Default;
            // 
            // f315_card_nhan_vien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 452);
            this.Controls.Add(this.m_grc_main);
            this.Controls.Add(this.panel1);
            this.Name = "f315_card_nhan_vien";
            this.Text = "F315 - Card nhân viên";
            this.Load += new System.EventHandler(this.f315_card_nhan_vien_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colMA_TRA_CUU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colHO_TEN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colNGAY_SINH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colSO_CMT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        //private DVMDDataSet1TableAdapters.V_DM_NHAN_VIENTableAdapter v_DM_NHAN_VIENTableAdapter;
        private DevExpress.XtraEditors.SimpleButton m_cmd_xuat_pdf;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl m_grc_main;
        private DevExpress.XtraGrid.Views.Layout.LayoutView layoutView1;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colID;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colMA_TRA_CUU;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colHO_TEN;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colNGAY_SINH;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colSO_CMT;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colID;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colMA_TRA_CUU;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colHO_TEN;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colNGAY_SINH;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colSO_CMT;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
    }
}