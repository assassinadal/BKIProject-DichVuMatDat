namespace BKI_DichVuMatDat.BaoCao
{
    partial class f402_tong_hop_cham_cong
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
            DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition pivotGridStyleFormatCondition1 = new DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition();
            DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition pivotGridStyleFormatCondition2 = new DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition();
            DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition pivotGridStyleFormatCondition3 = new DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition();
            DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition pivotGridStyleFormatCondition4 = new DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition();
            DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition pivotGridStyleFormatCondition5 = new DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.m_sle_chon_nhan_vien = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.m_pv = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.pivotGridField1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField2 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField3 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_sle_chon_nhan_vien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_pv)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.m_sle_chon_nhan_vien);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(758, 24);
            this.panelControl1.TabIndex = 1;
            // 
            // m_sle_chon_nhan_vien
            // 
            this.m_sle_chon_nhan_vien.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_sle_chon_nhan_vien.Location = new System.Drawing.Point(2, 2);
            this.m_sle_chon_nhan_vien.Name = "m_sle_chon_nhan_vien";
            this.m_sle_chon_nhan_vien.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_sle_chon_nhan_vien.Properties.Appearance.Options.UseFont = true;
            this.m_sle_chon_nhan_vien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.m_sle_chon_nhan_vien.Properties.DisplayMember = "HO_TEN";
            this.m_sle_chon_nhan_vien.Properties.NullText = "-----Tất cả nhân viên-----";
            this.m_sle_chon_nhan_vien.Properties.ValueMember = "ID";
            this.m_sle_chon_nhan_vien.Properties.View = this.searchLookUpEdit1View;
            this.m_sle_chon_nhan_vien.Size = new System.Drawing.Size(187, 20);
            this.m_sle_chon_nhan_vien.TabIndex = 5;
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
            // m_pv
            // 
            this.m_pv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_pv.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.pivotGridField1,
            this.pivotGridField2,
            this.pivotGridField3});
            pivotGridStyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Silver;
            pivotGridStyleFormatCondition1.Appearance.Options.UseBackColor = true;
            pivotGridStyleFormatCondition1.ApplyToCustomTotalCell = false;
            pivotGridStyleFormatCondition1.ApplyToGrandTotalCell = false;
            pivotGridStyleFormatCondition1.ApplyToTotalCell = false;
            pivotGridStyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            pivotGridStyleFormatCondition1.Enabled = false;
            pivotGridStyleFormatCondition1.FieldName = "";
            pivotGridStyleFormatCondition1.Name = "NGAY_NGHI";
            pivotGridStyleFormatCondition1.Value1 = "";
            pivotGridStyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            pivotGridStyleFormatCondition2.Appearance.Options.UseBackColor = true;
            pivotGridStyleFormatCondition2.ApplyToCustomTotalCell = false;
            pivotGridStyleFormatCondition2.ApplyToGrandTotalCell = false;
            pivotGridStyleFormatCondition2.ApplyToTotalCell = false;
            pivotGridStyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            pivotGridStyleFormatCondition2.Enabled = false;
            pivotGridStyleFormatCondition2.FieldName = "";
            pivotGridStyleFormatCondition2.Name = "TS";
            pivotGridStyleFormatCondition2.Value1 = "TS";
            pivotGridStyleFormatCondition3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            pivotGridStyleFormatCondition3.Appearance.Options.UseBackColor = true;
            pivotGridStyleFormatCondition3.ApplyToCustomTotalCell = false;
            pivotGridStyleFormatCondition3.ApplyToGrandTotalCell = false;
            pivotGridStyleFormatCondition3.ApplyToTotalCell = false;
            pivotGridStyleFormatCondition3.Enabled = false;
            pivotGridStyleFormatCondition3.FieldName = "";
            pivotGridStyleFormatCondition3.Name = "OM";
            pivotGridStyleFormatCondition3.Value1 = "OM";
            pivotGridStyleFormatCondition4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            pivotGridStyleFormatCondition4.Appearance.Options.UseBackColor = true;
            pivotGridStyleFormatCondition4.ApplyToCustomTotalCell = false;
            pivotGridStyleFormatCondition4.ApplyToGrandTotalCell = false;
            pivotGridStyleFormatCondition4.ApplyToTotalCell = false;
            pivotGridStyleFormatCondition4.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            pivotGridStyleFormatCondition4.Expression = "[MA_NGAY_CONG] != \'X\' And [MA_NGAY_CONG]  != \'\'";
            pivotGridStyleFormatCondition4.FieldName = "";
            pivotGridStyleFormatCondition4.Name = "Khac_X";
            pivotGridStyleFormatCondition5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            pivotGridStyleFormatCondition5.Appearance.Options.UseBackColor = true;
            pivotGridStyleFormatCondition5.ApplyToCustomTotalCell = false;
            pivotGridStyleFormatCondition5.ApplyToGrandTotalCell = false;
            pivotGridStyleFormatCondition5.ApplyToTotalCell = false;
            pivotGridStyleFormatCondition5.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            pivotGridStyleFormatCondition5.Enabled = false;
            pivotGridStyleFormatCondition5.Expression = "GetDayOfWeek( [NGAY_CHAM_CONG]) = 6 and GetDayOfWeek( [NGAY_CHAM_CONG]) = 0.";
            pivotGridStyleFormatCondition5.FieldName = "";
            pivotGridStyleFormatCondition5.Name = "zz";
            this.m_pv.FormatConditions.AddRange(new DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition[] {
            pivotGridStyleFormatCondition1,
            pivotGridStyleFormatCondition2,
            pivotGridStyleFormatCondition3,
            pivotGridStyleFormatCondition4,
            pivotGridStyleFormatCondition5});
            this.m_pv.Location = new System.Drawing.Point(0, 24);
            this.m_pv.Name = "m_pv";
            this.m_pv.Size = new System.Drawing.Size(758, 428);
            this.m_pv.TabIndex = 2;
            // 
            // pivotGridField1
            // 
            this.pivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.pivotGridField1.AreaIndex = 0;
            this.pivotGridField1.Caption = "Nhân viên";
            this.pivotGridField1.FieldName = "HO_TEN";
            this.pivotGridField1.Name = "pivotGridField1";
            this.pivotGridField1.Options.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.pivotGridField1.Options.ShowGrandTotal = false;
            this.pivotGridField1.SortMode = DevExpress.XtraPivotGrid.PivotSortMode.None;
            this.pivotGridField1.Width = 150;
            // 
            // pivotGridField2
            // 
            this.pivotGridField2.Appearance.Cell.Options.UseTextOptions = true;
            this.pivotGridField2.Appearance.Cell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.pivotGridField2.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pivotGridField2.AreaIndex = 0;
            this.pivotGridField2.Caption = "Mã ngày công";
            this.pivotGridField2.FieldName = "MA_NGAY_CONG";
            this.pivotGridField2.Name = "pivotGridField2";
            this.pivotGridField2.Options.ShowGrandTotal = false;
            this.pivotGridField2.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending;
            this.pivotGridField2.Width = 60;
            // 
            // pivotGridField3
            // 
            this.pivotGridField3.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.pivotGridField3.AreaIndex = 0;
            this.pivotGridField3.Caption = "Số ngày công";
            this.pivotGridField3.FieldName = "SO_NGAY_CONG";
            this.pivotGridField3.Name = "pivotGridField3";
            this.pivotGridField3.Options.ShowGrandTotal = false;
            this.pivotGridField3.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Max;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "MÃ_NV";
            this.gridColumn1.FieldName = "MA_NV";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "HỌ TÊN";
            this.gridColumn2.FieldName = "HO_TEN";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // f402_tong_hop_cham_cong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 452);
            this.Controls.Add(this.m_pv);
            this.Controls.Add(this.panelControl1);
            this.Name = "f402_tong_hop_cham_cong";
            this.Text = "F402 - Tổng hợp chấm công";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_sle_chon_nhan_vien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_pv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SearchLookUpEdit m_sle_chon_nhan_vien;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraPivotGrid.PivotGridControl m_pv;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField1;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField2;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField3;
    }
}