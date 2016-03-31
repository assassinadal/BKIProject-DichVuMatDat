namespace BKI_DichVuMatDat.XtraReport
{
    partial class rptPhuThuoc
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.winControlContainer1 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.winControlContainer2 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.winControlContainer3 = new DevExpress.XtraReports.UI.WinControlContainer();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.HeightF = 100F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 100F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 100F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.winControlContainer3,
            this.winControlContainer2,
            this.winControlContainer1,
            this.xrLabel5,
            this.xrLabel4});
            this.ReportHeader.HeightF = 235.4167F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // ReportFooter
            // 
            this.ReportFooter.HeightF = 100F;
            this.ReportFooter.Name = "ReportFooter";
            // 
            // xrLabel4
            // 
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(22.91667F, 130.625F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(105.2083F, 22.99998F);
            this.xrLabel4.Text = "[01] Kỳ tính thuế: ";
            // 
            // xrLabel5
            // 
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(138.5417F, 130.625F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(42.70834F, 22.99998F);
            this.xrLabel5.Text = "...";
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl5.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl5.Location = new System.Drawing.Point(569, 75);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(135, 15);
            this.labelControl5.TabIndex = 20;
            this.labelControl5.Text = "[02] Tên người nộp thuế:";
            // 
            // winControlContainer1
            // 
            this.winControlContainer1.LocationFloat = new DevExpress.Utils.PointFloat(21.5F, 183.3333F);
            this.winControlContainer1.Name = "winControlContainer1";
            this.winControlContainer1.SizeF = new System.Drawing.SizeF(141F, 16F);
            this.winControlContainer1.WinControl = this.labelControl5;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl1.Location = new System.Drawing.Point(366, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(518, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "BẢNG KÊ THÔNG TIN NGƯỜI PHỤ THUỘC GIẢM TRỪ GIA CẢNH";
            // 
            // winControlContainer2
            // 
            this.winControlContainer2.LocationFloat = new DevExpress.Utils.PointFloat(52.08333F, 77.08334F);
            this.winControlContainer2.Name = "winControlContainer2";
            this.winControlContainer2.SizeF = new System.Drawing.SizeF(540F, 20F);
            this.winControlContainer2.WinControl = this.labelControl1;
            // 
            // labelControl17
            // 
            this.labelControl17.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl17.Location = new System.Drawing.Point(0, 0);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(225, 13);
            this.labelControl17.TabIndex = 35;
            this.labelControl17.Text = "CÔNG TY CỔ PHẦN PHỤC VỤ MẶT ĐẤT HÀ NỘI";
            // 
            // winControlContainer3
            // 
            this.winControlContainer3.LocationFloat = new DevExpress.Utils.PointFloat(250F, 139.625F);
            this.winControlContainer3.Name = "winControlContainer3";
            this.winControlContainer3.SizeF = new System.Drawing.SizeF(234F, 14F);
            this.winControlContainer3.WinControl = this.labelControl17;
            // 
            // rptPhuThuoc
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.ReportFooter});
            this.Version = "14.1";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.WinControlContainer winControlContainer1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraReports.UI.WinControlContainer winControlContainer2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraReports.UI.WinControlContainer winControlContainer3;
        private DevExpress.XtraEditors.LabelControl labelControl17;
    }
}
