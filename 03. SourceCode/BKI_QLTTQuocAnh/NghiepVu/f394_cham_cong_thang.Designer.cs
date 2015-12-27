namespace BKI_DichVuMatDat.NghiepVu
{
    partial class f394_cham_cong_thang
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
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.m_sle_chon_nhan_vien = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.m_cmd_loc = new DevExpress.XtraEditors.SimpleButton();
            this.m_txt_nam = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.m_txt_thang = new DevExpress.XtraEditors.TextEdit();
            this.m_lbl_thang = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.m_pv = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.pivotGridField1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField2 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField3 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField4 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_sle_chon_nhan_vien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_txt_nam.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_txt_thang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_pv)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.m_sle_chon_nhan_vien);
            this.panelControl1.Controls.Add(this.m_cmd_loc);
            this.panelControl1.Controls.Add(this.m_txt_nam);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.m_txt_thang);
            this.panelControl1.Controls.Add(this.m_lbl_thang);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(794, 125);
            this.panelControl1.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 55);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(75, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Chọn nhân viên";
            // 
            // m_sle_chon_nhan_vien
            // 
            this.m_sle_chon_nhan_vien.EditValue = ((long)(-1));
            this.m_sle_chon_nhan_vien.Location = new System.Drawing.Point(114, 52);
            this.m_sle_chon_nhan_vien.Name = "m_sle_chon_nhan_vien";
            this.m_sle_chon_nhan_vien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.m_sle_chon_nhan_vien.Properties.DisplayMember = "HO_TEN";
            this.m_sle_chon_nhan_vien.Properties.NullText = "";
            this.m_sle_chon_nhan_vien.Properties.ValueMember = "ID";
            this.m_sle_chon_nhan_vien.Properties.View = this.searchLookUpEdit1View;
            this.m_sle_chon_nhan_vien.Size = new System.Drawing.Size(215, 20);
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
            // m_cmd_loc
            // 
            this.m_cmd_loc.Image = global::BKI_DichVuMatDat.Properties.Resources.find;
            this.m_cmd_loc.Location = new System.Drawing.Point(12, 81);
            this.m_cmd_loc.Name = "m_cmd_loc";
            this.m_cmd_loc.Size = new System.Drawing.Size(105, 38);
            this.m_cmd_loc.TabIndex = 6;
            this.m_cmd_loc.Text = "Lọc dữ liệu";
            this.m_cmd_loc.Click += new System.EventHandler(this.m_cmd_loc_Click);
            // 
            // m_txt_nam
            // 
            this.m_txt_nam.Location = new System.Drawing.Point(254, 19);
            this.m_txt_nam.Name = "m_txt_nam";
            this.m_txt_nam.Size = new System.Drawing.Size(75, 20);
            this.m_txt_nam.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(212, 22);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(30, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Năm *";
            // 
            // m_txt_thang
            // 
            this.m_txt_thang.Location = new System.Drawing.Point(115, 19);
            this.m_txt_thang.Name = "m_txt_thang";
            this.m_txt_thang.Size = new System.Drawing.Size(79, 20);
            this.m_txt_thang.TabIndex = 1;
            // 
            // m_lbl_thang
            // 
            this.m_lbl_thang.Location = new System.Drawing.Point(12, 22);
            this.m_lbl_thang.Name = "m_lbl_thang";
            this.m_lbl_thang.Size = new System.Drawing.Size(39, 13);
            this.m_lbl_thang.TabIndex = 0;
            this.m_lbl_thang.Text = "Tháng *";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.m_pv);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 125);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(794, 365);
            this.panelControl2.TabIndex = 1;
            // 
            // m_pv
            // 
            this.m_pv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_pv.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.pivotGridField1,
            this.pivotGridField2,
            this.pivotGridField3,
            this.pivotGridField4});
            pivotGridStyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Silver;
            pivotGridStyleFormatCondition1.Appearance.Options.UseBackColor = true;
            pivotGridStyleFormatCondition1.ApplyToCustomTotalCell = false;
            pivotGridStyleFormatCondition1.ApplyToGrandTotalCell = false;
            pivotGridStyleFormatCondition1.ApplyToTotalCell = false;
            pivotGridStyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            pivotGridStyleFormatCondition1.Enabled = false;
            pivotGridStyleFormatCondition1.Field = this.pivotGridField3;
            pivotGridStyleFormatCondition1.FieldName = "pivotGridField3";
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
            pivotGridStyleFormatCondition4.Field = this.pivotGridField3;
            pivotGridStyleFormatCondition4.FieldName = "pivotGridField3";
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
            this.m_pv.Location = new System.Drawing.Point(2, 2);
            this.m_pv.Name = "m_pv";
            this.m_pv.Size = new System.Drawing.Size(790, 361);
            this.m_pv.TabIndex = 0;
            this.m_pv.CellDoubleClick += new DevExpress.XtraPivotGrid.PivotCellEventHandler(this.m_pv_CellDoubleClick);
            // 
            // pivotGridField1
            // 
            this.pivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.pivotGridField1.AreaIndex = 0;
            this.pivotGridField1.Caption = "Mã nhân viên";
            this.pivotGridField1.FieldName = "MA_NV";
            this.pivotGridField1.Name = "pivotGridField1";
            this.pivotGridField1.Visible = false;
            // 
            // pivotGridField2
            // 
            this.pivotGridField2.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pivotGridField2.AreaIndex = 0;
            this.pivotGridField2.Caption = "Ngày chấm công";
            this.pivotGridField2.FieldName = "NGAY_CHAM_CONG";
            this.pivotGridField2.Name = "pivotGridField2";
            this.pivotGridField2.Width = 70;
            // 
            // pivotGridField3
            // 
            this.pivotGridField3.Appearance.Cell.Options.UseTextOptions = true;
            this.pivotGridField3.Appearance.Cell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.pivotGridField3.Appearance.Value.Options.UseTextOptions = true;
            this.pivotGridField3.Appearance.Value.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.pivotGridField3.Appearance.Value.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.pivotGridField3.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.pivotGridField3.AreaIndex = 0;
            this.pivotGridField3.Caption = "Mã ngày công";
            this.pivotGridField3.FieldName = "MA_NGAY_CONG";
            this.pivotGridField3.Name = "pivotGridField3";
            this.pivotGridField3.Options.ShowGrandTotal = false;
            this.pivotGridField3.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Max;
            // 
            // pivotGridField4
            // 
            this.pivotGridField4.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.pivotGridField4.AreaIndex = 0;
            this.pivotGridField4.Caption = "Nhân viên";
            this.pivotGridField4.FieldName = "HO_TEN";
            this.pivotGridField4.Name = "pivotGridField4";
            this.pivotGridField4.Width = 200;
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
            // f394_cham_cong_thang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 490);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "f394_cham_cong_thang";
            this.Text = "F394 - Chấm công theo tháng";
            this.Load += new System.EventHandler(this.f394_cham_cong_thang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_sle_chon_nhan_vien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_txt_nam.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_txt_thang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_pv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton m_cmd_loc;
        private DevExpress.XtraEditors.TextEdit m_txt_nam;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit m_txt_thang;
        private DevExpress.XtraEditors.LabelControl m_lbl_thang;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraPivotGrid.PivotGridControl m_pv;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField1;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField2;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField3;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SearchLookUpEdit m_sle_chon_nhan_vien;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
    }
}