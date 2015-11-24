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
            this.components = new System.ComponentModel.Container();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.m_cmd_filter = new DevExpress.XtraEditors.SimpleButton();
            this.m_grc_bao_cao = new DevExpress.XtraGrid.GridControl();
            this.prrpttanggiamlaodongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.m_grv_bao_cao = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN_DON_VI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMA_DON_VI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_LOAI_DON_VI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_DON_VI_CAP_TREN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_DV_0 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_DV_1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_DV_2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_DV_3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_DV_4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDAU_KY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHAT_SINH_TANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHAT_SINH_GIAM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCUOI_KY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.m_dat_den_ngay = new DevExpress.XtraEditors.DateEdit();
            this.m_dat_tu_ngay = new DevExpress.XtraEditors.DateEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_bao_cao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prrpttanggiamlaodongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_bao_cao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_den_ngay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_den_ngay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_tu_ngay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_tu_ngay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.m_cmd_filter);
            this.layoutControl1.Controls.Add(this.m_grc_bao_cao);
            this.layoutControl1.Controls.Add(this.m_dat_den_ngay);
            this.layoutControl1.Controls.Add(this.m_dat_tu_ngay);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1013, 272, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(887, 513);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // m_cmd_filter
            // 
            this.m_cmd_filter.Location = new System.Drawing.Point(12, 60);
            this.m_cmd_filter.Name = "m_cmd_filter";
            this.m_cmd_filter.Size = new System.Drawing.Size(87, 22);
            this.m_cmd_filter.StyleController = this.layoutControl1;
            this.m_cmd_filter.TabIndex = 7;
            this.m_cmd_filter.Text = "Hiển thị";
            this.m_cmd_filter.Click += new System.EventHandler(this.m_cmd_filter_Click);
            // 
            // m_grc_bao_cao
            // 
            this.m_grc_bao_cao.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_bao_cao.DataSource = this.prrpttanggiamlaodongBindingSource;
            this.m_grc_bao_cao.Location = new System.Drawing.Point(12, 86);
            this.m_grc_bao_cao.MainView = this.m_grv_bao_cao;
            this.m_grc_bao_cao.Name = "m_grc_bao_cao";
            this.m_grc_bao_cao.Size = new System.Drawing.Size(863, 415);
            this.m_grc_bao_cao.TabIndex = 3;
            this.m_grc_bao_cao.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv_bao_cao});
            // 
            // prrpttanggiamlaodongBindingSource
            // 
            this.prrpttanggiamlaodongBindingSource.DataMember = "pr_rpt_tang_giam_lao_dong";
            // 
            // m_grv_bao_cao
            // 
            this.m_grv_bao_cao.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colTEN_DON_VI,
            this.colMA_DON_VI,
            this.colID_LOAI_DON_VI,
            this.colID_DON_VI_CAP_TREN,
            this.colID_DV_0,
            this.colID_DV_1,
            this.colID_DV_2,
            this.colID_DV_3,
            this.colID_DV_4,
            this.colDAU_KY,
            this.colPHAT_SINH_TANG,
            this.colPHAT_SINH_GIAM,
            this.colCUOI_KY});
            this.m_grv_bao_cao.GridControl = this.m_grc_bao_cao;
            this.m_grv_bao_cao.Name = "m_grv_bao_cao";
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.ReadOnly = true;
            // 
            // colTEN_DON_VI
            // 
            this.colTEN_DON_VI.FieldName = "TEN_DON_VI";
            this.colTEN_DON_VI.Name = "colTEN_DON_VI";
            this.colTEN_DON_VI.Visible = true;
            this.colTEN_DON_VI.VisibleIndex = 0;
            // 
            // colMA_DON_VI
            // 
            this.colMA_DON_VI.FieldName = "MA_DON_VI";
            this.colMA_DON_VI.Name = "colMA_DON_VI";
            this.colMA_DON_VI.Visible = true;
            this.colMA_DON_VI.VisibleIndex = 1;
            // 
            // colID_LOAI_DON_VI
            // 
            this.colID_LOAI_DON_VI.FieldName = "ID_LOAI_DON_VI";
            this.colID_LOAI_DON_VI.Name = "colID_LOAI_DON_VI";
            // 
            // colID_DON_VI_CAP_TREN
            // 
            this.colID_DON_VI_CAP_TREN.FieldName = "ID_DON_VI_CAP_TREN";
            this.colID_DON_VI_CAP_TREN.Name = "colID_DON_VI_CAP_TREN";
            // 
            // colID_DV_0
            // 
            this.colID_DV_0.FieldName = "ID_DV_0";
            this.colID_DV_0.Name = "colID_DV_0";
            // 
            // colID_DV_1
            // 
            this.colID_DV_1.FieldName = "ID_DV_1";
            this.colID_DV_1.Name = "colID_DV_1";
            // 
            // colID_DV_2
            // 
            this.colID_DV_2.FieldName = "ID_DV_2";
            this.colID_DV_2.Name = "colID_DV_2";
            // 
            // colID_DV_3
            // 
            this.colID_DV_3.FieldName = "ID_DV_3";
            this.colID_DV_3.Name = "colID_DV_3";
            // 
            // colID_DV_4
            // 
            this.colID_DV_4.FieldName = "ID_DV_4";
            this.colID_DV_4.Name = "colID_DV_4";
            // 
            // colDAU_KY
            // 
            this.colDAU_KY.DisplayFormat.FormatString = "n0";
            this.colDAU_KY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDAU_KY.FieldName = "DAU_KY";
            this.colDAU_KY.Name = "colDAU_KY";
            this.colDAU_KY.OptionsColumn.ReadOnly = true;
            this.colDAU_KY.Visible = true;
            this.colDAU_KY.VisibleIndex = 2;
            // 
            // colPHAT_SINH_TANG
            // 
            this.colPHAT_SINH_TANG.DisplayFormat.FormatString = "n0";
            this.colPHAT_SINH_TANG.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPHAT_SINH_TANG.FieldName = "PHAT_SINH_TANG";
            this.colPHAT_SINH_TANG.Name = "colPHAT_SINH_TANG";
            this.colPHAT_SINH_TANG.OptionsColumn.ReadOnly = true;
            this.colPHAT_SINH_TANG.Visible = true;
            this.colPHAT_SINH_TANG.VisibleIndex = 3;
            // 
            // colPHAT_SINH_GIAM
            // 
            this.colPHAT_SINH_GIAM.DisplayFormat.FormatString = "n0";
            this.colPHAT_SINH_GIAM.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPHAT_SINH_GIAM.FieldName = "PHAT_SINH_GIAM";
            this.colPHAT_SINH_GIAM.Name = "colPHAT_SINH_GIAM";
            this.colPHAT_SINH_GIAM.OptionsColumn.ReadOnly = true;
            this.colPHAT_SINH_GIAM.Visible = true;
            this.colPHAT_SINH_GIAM.VisibleIndex = 4;
            // 
            // colCUOI_KY
            // 
            this.colCUOI_KY.DisplayFormat.FormatString = "n0";
            this.colCUOI_KY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCUOI_KY.FieldName = "CUOI_KY";
            this.colCUOI_KY.Name = "colCUOI_KY";
            this.colCUOI_KY.OptionsColumn.ReadOnly = true;
            this.colCUOI_KY.Visible = true;
            this.colCUOI_KY.VisibleIndex = 5;
            // 
            // m_dat_den_ngay
            // 
            this.m_dat_den_ngay.EditValue = null;
            this.m_dat_den_ngay.Location = new System.Drawing.Point(62, 36);
            this.m_dat_den_ngay.Name = "m_dat_den_ngay";
            this.m_dat_den_ngay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.m_dat_den_ngay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.m_dat_den_ngay.Size = new System.Drawing.Size(337, 20);
            this.m_dat_den_ngay.StyleController = this.layoutControl1;
            this.m_dat_den_ngay.TabIndex = 1;
            // 
            // m_dat_tu_ngay
            // 
            this.m_dat_tu_ngay.EditValue = null;
            this.m_dat_tu_ngay.Location = new System.Drawing.Point(62, 12);
            this.m_dat_tu_ngay.Name = "m_dat_tu_ngay";
            this.m_dat_tu_ngay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.m_dat_tu_ngay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.m_dat_tu_ngay.Size = new System.Drawing.Size(337, 20);
            this.m_dat_tu_ngay.StyleController = this.layoutControl1;
            this.m_dat_tu_ngay.TabIndex = 0;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.emptySpaceItem1,
            this.emptySpaceItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(887, 513);
            this.layoutControlGroup1.Text = "Root";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.m_dat_tu_ngay;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(391, 24);
            this.layoutControlItem1.Text = "Từ ngày";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(47, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.m_dat_den_ngay;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(391, 24);
            this.layoutControlItem2.Text = "Đến ngày";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(47, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.m_grc_bao_cao;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 74);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(867, 419);
            this.layoutControlItem3.Text = "layoutControlItem3";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextToControlDistance = 0;
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.m_cmd_filter;
            this.layoutControlItem4.CustomizationFormText = "layoutControlItem4";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(91, 26);
            this.layoutControlItem4.Text = "layoutControlItem4";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextToControlDistance = 0;
            this.layoutControlItem4.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(391, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(476, 74);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2";
            this.emptySpaceItem2.Location = new System.Drawing.Point(91, 48);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(300, 26);
            this.emptySpaceItem2.Text = "emptySpaceItem2";
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // frm417_bao_cao_tang_giam_lao_dong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 513);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frm417_bao_cao_tang_giam_lao_dong";
            this.Text = "F417 - Báo cáo tăng giảm lao động";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_bao_cao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prrpttanggiamlaodongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_bao_cao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_den_ngay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_den_ngay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_tu_ngay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_tu_ngay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl m_grc_bao_cao;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv_bao_cao;
        private DevExpress.XtraEditors.DateEdit m_dat_den_ngay;
        private DevExpress.XtraEditors.DateEdit m_dat_tu_ngay;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.SimpleButton m_cmd_filter;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private System.Windows.Forms.BindingSource prrpttanggiamlaodongBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN_DON_VI;
        private DevExpress.XtraGrid.Columns.GridColumn colMA_DON_VI;
        private DevExpress.XtraGrid.Columns.GridColumn colID_LOAI_DON_VI;
        private DevExpress.XtraGrid.Columns.GridColumn colID_DON_VI_CAP_TREN;
        private DevExpress.XtraGrid.Columns.GridColumn colID_DV_0;
        private DevExpress.XtraGrid.Columns.GridColumn colID_DV_1;
        private DevExpress.XtraGrid.Columns.GridColumn colID_DV_2;
        private DevExpress.XtraGrid.Columns.GridColumn colID_DV_3;
        private DevExpress.XtraGrid.Columns.GridColumn colID_DV_4;
        private DevExpress.XtraGrid.Columns.GridColumn colDAU_KY;
        private DevExpress.XtraGrid.Columns.GridColumn colPHAT_SINH_TANG;
        private DevExpress.XtraGrid.Columns.GridColumn colPHAT_SINH_GIAM;
        private DevExpress.XtraGrid.Columns.GridColumn colCUOI_KY;
    }
}