namespace BKI_DichVuMatDat.BaoCao
{
    partial class frm417_bao_cao_tang_giam_lao_dong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm417_bao_cao_tang_giam_lao_dong));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.m_cmd_export = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_search = new DevExpress.XtraEditors.SimpleButton();
            this.m_dat_den_ngay = new DevExpress.XtraEditors.DateEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.m_dat_tu_ngay = new DevExpress.XtraEditors.DateEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.m_tree_list = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn4 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn5 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn3 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_den_ngay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_den_ngay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_tu_ngay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_tu_ngay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_tree_list)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.m_cmd_export);
            this.panelControl1.Controls.Add(this.m_cmd_search);
            this.panelControl1.Controls.Add(this.m_dat_den_ngay);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.m_dat_tu_ngay);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(827, 87);
            this.panelControl1.TabIndex = 0;
            // 
            // m_cmd_export
            // 
            this.m_cmd_export.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_export.Image")));
            this.m_cmd_export.Location = new System.Drawing.Point(441, 19);
            this.m_cmd_export.Name = "m_cmd_export";
            this.m_cmd_export.Size = new System.Drawing.Size(123, 40);
            this.m_cmd_export.TabIndex = 34;
            this.m_cmd_export.Text = "&Trích xuất";
            // 
            // m_cmd_search
            // 
            this.m_cmd_search.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_search.Image")));
            this.m_cmd_search.Location = new System.Drawing.Point(302, 19);
            this.m_cmd_search.Name = "m_cmd_search";
            this.m_cmd_search.Size = new System.Drawing.Size(123, 40);
            this.m_cmd_search.TabIndex = 33;
            this.m_cmd_search.Text = "Lọc dữ liệu";
            // 
            // m_dat_den_ngay
            // 
            this.m_dat_den_ngay.EditValue = null;
            this.m_dat_den_ngay.Location = new System.Drawing.Point(122, 51);
            this.m_dat_den_ngay.Name = "m_dat_den_ngay";
            this.m_dat_den_ngay.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_dat_den_ngay.Properties.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.m_dat_den_ngay.Properties.Appearance.Options.UseFont = true;
            this.m_dat_den_ngay.Properties.Appearance.Options.UseForeColor = true;
            this.m_dat_den_ngay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.m_dat_den_ngay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.m_dat_den_ngay.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.m_dat_den_ngay.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.m_dat_den_ngay.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.m_dat_den_ngay.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.m_dat_den_ngay.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.m_dat_den_ngay.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.m_dat_den_ngay.Size = new System.Drawing.Size(136, 22);
            this.m_dat_den_ngay.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 14);
            this.label1.TabIndex = 31;
            this.label1.Text = "Đến tháng";
            // 
            // m_dat_tu_ngay
            // 
            this.m_dat_tu_ngay.EditValue = null;
            this.m_dat_tu_ngay.Location = new System.Drawing.Point(122, 13);
            this.m_dat_tu_ngay.Name = "m_dat_tu_ngay";
            this.m_dat_tu_ngay.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_dat_tu_ngay.Properties.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.m_dat_tu_ngay.Properties.Appearance.Options.UseFont = true;
            this.m_dat_tu_ngay.Properties.Appearance.Options.UseForeColor = true;
            this.m_dat_tu_ngay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.m_dat_tu_ngay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.m_dat_tu_ngay.Properties.DisplayFormat.FormatString = "MM/yyyy";
            this.m_dat_tu_ngay.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.m_dat_tu_ngay.Properties.EditFormat.FormatString = "MM/yyyy";
            this.m_dat_tu_ngay.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.m_dat_tu_ngay.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.m_dat_tu_ngay.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.m_dat_tu_ngay.Size = new System.Drawing.Size(136, 22);
            this.m_dat_tu_ngay.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 14);
            this.label3.TabIndex = 29;
            this.label3.Text = "Từ tháng";
            // 
            // m_tree_list
            // 
            this.m_tree_list.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1,
            this.treeListColumn2,
            this.treeListColumn4,
            this.treeListColumn5,
            this.treeListColumn3});
            this.m_tree_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_tree_list.Location = new System.Drawing.Point(0, 87);
            this.m_tree_list.Name = "m_tree_list";
            this.m_tree_list.OptionsBehavior.Editable = false;
            this.m_tree_list.Size = new System.Drawing.Size(827, 373);
            this.m_tree_list.TabIndex = 1;
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "Đơn vị";
            this.treeListColumn1.FieldName = "TEN_DON_VI";
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            this.treeListColumn1.Width = 276;
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.Caption = "Đầu kỳ";
            this.treeListColumn2.FieldName = "SO_LUONG";
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.Visible = true;
            this.treeListColumn2.VisibleIndex = 1;
            this.treeListColumn2.Width = 133;
            // 
            // treeListColumn4
            // 
            this.treeListColumn4.Caption = "Số lượng tăng";
            this.treeListColumn4.FieldName = "SO_LUONG_TANG";
            this.treeListColumn4.Name = "treeListColumn4";
            this.treeListColumn4.Visible = true;
            this.treeListColumn4.VisibleIndex = 2;
            this.treeListColumn4.Width = 133;
            // 
            // treeListColumn5
            // 
            this.treeListColumn5.Caption = "Số lượng giảm";
            this.treeListColumn5.FieldName = "SO_LUONG_GIAM";
            this.treeListColumn5.Name = "treeListColumn5";
            this.treeListColumn5.Visible = true;
            this.treeListColumn5.VisibleIndex = 3;
            this.treeListColumn5.Width = 133;
            // 
            // treeListColumn3
            // 
            this.treeListColumn3.Caption = "Cuối kỳ";
            this.treeListColumn3.FieldName = "SO_LUONG_CUOI_KY";
            this.treeListColumn3.Name = "treeListColumn3";
            this.treeListColumn3.Visible = true;
            this.treeListColumn3.VisibleIndex = 4;
            this.treeListColumn3.Width = 134;
            // 
            // frm417_bao_cao_tang_giam_lao_dong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 460);
            this.Controls.Add(this.m_tree_list);
            this.Controls.Add(this.panelControl1);
            this.Name = "frm417_bao_cao_tang_giam_lao_dong";
            this.Text = "F417 - Báo cáo biến động hợp đồng";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_den_ngay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_den_ngay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_tu_ngay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_tu_ngay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_tree_list)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.DateEdit m_dat_den_ngay;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.DateEdit m_dat_tu_ngay;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton m_cmd_search;
        private DevExpress.XtraTreeList.TreeList m_tree_list;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn3;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn4;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn5;
        private DevExpress.XtraEditors.SimpleButton m_cmd_export;


    }
}