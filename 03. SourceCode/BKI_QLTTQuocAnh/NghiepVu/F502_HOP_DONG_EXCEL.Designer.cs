namespace BKI_DichVuMatDat.NghiepVu
{
    partial class F502_HOP_DONG_EXCEL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F502_HOP_DONG_EXCEL));
            this.dM_NHAN_VIENTableAdapter = new BKI_DichVuMatDat.DVMDDataSet2TableAdapters.DM_NHAN_VIENTableAdapter();
            this.dMNHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dVMDDataSet2 = new BKI_DichVuMatDat.DVMDDataSet2();
            this.dVMDDataSet1 = new BKI_DichVuMatDat.DVMDDataSet1();
            this.dVMDDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vDMNHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_DM_NHAN_VIENTableAdapter = new BKI_DichVuMatDat.DVMDDataSet1TableAdapters.V_DM_NHAN_VIENTableAdapter();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.m_cmd_luu = new DevExpress.XtraEditors.SimpleButton();
            this.m_grc = new DevExpress.XtraGrid.GridControl();
            this.m_grv = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMA_NV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dMNHANVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dVMDDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dVMDDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dVMDDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDMNHANVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv)).BeginInit();
            this.SuspendLayout();
            // 
            // dM_NHAN_VIENTableAdapter
            // 
            this.dM_NHAN_VIENTableAdapter.ClearBeforeFill = true;
            // 
            // dMNHANVIENBindingSource
            // 
            this.dMNHANVIENBindingSource.DataMember = "DM_NHAN_VIEN";
            this.dMNHANVIENBindingSource.DataSource = this.dVMDDataSet2;
            // 
            // dVMDDataSet2
            // 
            this.dVMDDataSet2.DataSetName = "DVMDDataSet2";
            this.dVMDDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dVMDDataSet1
            // 
            this.dVMDDataSet1.DataSetName = "DVMDDataSet1";
            this.dVMDDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dVMDDataSet1BindingSource
            // 
            this.dVMDDataSet1BindingSource.DataSource = this.dVMDDataSet1;
            this.dVMDDataSet1BindingSource.Position = 0;
            // 
            // vDMNHANVIENBindingSource
            // 
            this.vDMNHANVIENBindingSource.DataMember = "V_DM_NHAN_VIEN";
            this.vDMNHANVIENBindingSource.DataSource = this.dVMDDataSet1;
            // 
            // v_DM_NHAN_VIENTableAdapter
            // 
            this.v_DM_NHAN_VIENTableAdapter.ClearBeforeFill = true;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(965, 64);
            this.panelControl1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "HỢP ĐỒNG MỚI IMPORT TỪ EXCEL";
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.m_cmd_luu);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl3.Location = new System.Drawing.Point(0, 336);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(965, 44);
            this.panelControl3.TabIndex = 7;
            // 
            // m_cmd_luu
            // 
            this.m_cmd_luu.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_luu.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_luu.Image")));
            this.m_cmd_luu.Location = new System.Drawing.Point(849, 2);
            this.m_cmd_luu.Name = "m_cmd_luu";
            this.m_cmd_luu.Size = new System.Drawing.Size(114, 40);
            this.m_cmd_luu.TabIndex = 2;
            this.m_cmd_luu.Text = "Lưu";
            // 
            // m_grc
            // 
            this.m_grc.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc.DataSource = this.dMNHANVIENBindingSource;
            this.m_grc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc.Location = new System.Drawing.Point(0, 64);
            this.m_grc.MainView = this.m_grv;
            this.m_grc.Name = "m_grc";
            this.m_grc.Size = new System.Drawing.Size(965, 272);
            this.m_grc.TabIndex = 8;
            this.m_grc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv});
            // 
            // m_grv
            // 
            this.m_grv.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colMA_NV,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7});
            this.m_grv.GridControl = this.m_grc;
            this.m_grv.Name = "m_grv";
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colID.Name = "colID";
            this.colID.Width = 72;
            // 
            // colMA_NV
            // 
            this.colMA_NV.Caption = "Mã nhân viên";
            this.colMA_NV.FieldName = "MA_NV";
            this.colMA_NV.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colMA_NV.Name = "colMA_NV";
            this.colMA_NV.Visible = true;
            this.colMA_NV.VisibleIndex = 0;
            this.colMA_NV.Width = 82;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã hợp đồng";
            this.gridColumn1.FieldName = "MA_HOP_DONG";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Chức danh LCĐ";
            this.gridColumn2.FieldName = "CHUC_DANH_LCD";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Mức LCĐ";
            this.gridColumn3.FieldName = "MUC_LCD";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "MỨC LNS";
            this.gridColumn4.FieldName = "CHUC_DANH_LNS";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 4;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Ngày bắt đầu";
            this.gridColumn5.FieldName = "NGAY_BAT_DAU";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 5;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Ngày kết thúc";
            this.gridColumn6.FieldName = "NGAY_KET_THUC";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 6;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Ngày kí hợp đồng";
            this.gridColumn7.FieldName = "NGAY_KI_HOP_DONG";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 7;
            // 
            // F502_HOP_DONG_EXCEL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 380);
            this.Controls.Add(this.m_grc);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl1);
            this.Name = "F502_HOP_DONG_EXCEL";
            this.Text = "HỢP ĐỒNG EXCEL";
            ((System.ComponentModel.ISupportInitialize)(this.dMNHANVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dVMDDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dVMDDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dVMDDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDMNHANVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_grc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DVMDDataSet2TableAdapters.DM_NHAN_VIENTableAdapter dM_NHAN_VIENTableAdapter;
        private System.Windows.Forms.BindingSource dMNHANVIENBindingSource;
        private DVMDDataSet2 dVMDDataSet2;
        private DVMDDataSet1 dVMDDataSet1;
        private System.Windows.Forms.BindingSource dVMDDataSet1BindingSource;
        private System.Windows.Forms.BindingSource vDMNHANVIENBindingSource;
        private DVMDDataSet1TableAdapters.V_DM_NHAN_VIENTableAdapter v_DM_NHAN_VIENTableAdapter;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.SimpleButton m_cmd_luu;
        private DevExpress.XtraGrid.GridControl m_grc;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colMA_NV;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
    }
}