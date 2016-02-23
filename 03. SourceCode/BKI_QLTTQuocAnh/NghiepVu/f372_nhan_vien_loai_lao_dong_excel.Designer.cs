namespace BKI_DichVuMatDat.NghiepVu
{
    partial class f372_nhan_vien_loai_lao_dong_excel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f372_nhan_vien_loai_lao_dong_excel));
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.m_cmd_luu = new DevExpress.XtraEditors.SimpleButton();
            this.dM_NHAN_VIENTableAdapter = new BKI_DichVuMatDat.DVMDDataSet2TableAdapters.DM_NHAN_VIENTableAdapter();
            this.dMNHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dVMDDataSet2 = new BKI_DichVuMatDat.DVMDDataSet2();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.dVMDDataSet1 = new BKI_DichVuMatDat.DVMDDataSet1();
            this.dVMDDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vDMNHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_DM_NHAN_VIENTableAdapter = new BKI_DichVuMatDat.DVMDDataSet1TableAdapters.V_DM_NHAN_VIENTableAdapter();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.m_grc = new DevExpress.XtraGrid.GridControl();
            this.m_grv = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMA_NV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAY_BAT_DAU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAY_KET_THUC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLOAI_LAO_DONG = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dMNHANVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dVMDDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dVMDDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dVMDDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDMNHANVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.m_cmd_luu);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl3.Location = new System.Drawing.Point(0, 346);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1111, 44);
            this.panelControl3.TabIndex = 9;
            // 
            // m_cmd_luu
            // 
            this.m_cmd_luu.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_luu.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_luu.Image")));
            this.m_cmd_luu.Location = new System.Drawing.Point(995, 2);
            this.m_cmd_luu.Name = "m_cmd_luu";
            this.m_cmd_luu.Size = new System.Drawing.Size(114, 40);
            this.m_cmd_luu.TabIndex = 2;
            this.m_cmd_luu.Text = "Lưu";
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
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1111, 64);
            this.panelControl1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "DANH SÁCH IMPORT TỪ EXCEL";
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
            // gridView1
            // 
            this.gridView1.Name = "gridView1";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.m_grc);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 64);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1111, 282);
            this.panelControl2.TabIndex = 10;
            // 
            // m_grc
            // 
            this.m_grc.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc.Location = new System.Drawing.Point(2, 2);
            this.m_grc.MainView = this.m_grv;
            this.m_grc.Name = "m_grc";
            this.m_grc.Size = new System.Drawing.Size(1107, 278);
            this.m_grc.TabIndex = 1;
            this.m_grc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv});
            // 
            // m_grv
            // 
            this.m_grv.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colMA_NV,
            this.colLOAI_LAO_DONG,
            this.colNGAY_BAT_DAU,
            this.colNGAY_KET_THUC});
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
            // colNGAY_BAT_DAU
            // 
            this.colNGAY_BAT_DAU.Caption = "Ngày bắt đầu";
            this.colNGAY_BAT_DAU.FieldName = "NGAY_BAT_DAU";
            this.colNGAY_BAT_DAU.Name = "colNGAY_BAT_DAU";
            this.colNGAY_BAT_DAU.Visible = true;
            this.colNGAY_BAT_DAU.VisibleIndex = 1;
            this.colNGAY_BAT_DAU.Width = 27;
            // 
            // colNGAY_KET_THUC
            // 
            this.colNGAY_KET_THUC.Caption = "Ngày kết thúc";
            this.colNGAY_KET_THUC.FieldName = "NGAY_KET_THUC";
            this.colNGAY_KET_THUC.Name = "colNGAY_KET_THUC";
            this.colNGAY_KET_THUC.Visible = true;
            this.colNGAY_KET_THUC.VisibleIndex = 2;
            this.colNGAY_KET_THUC.Width = 27;
            // 
            // colLOAI_LAO_DONG
            // 
            this.colLOAI_LAO_DONG.Caption = "Loại lao động";
            this.colLOAI_LAO_DONG.FieldName = "LOAI_LAO_DONG";
            this.colLOAI_LAO_DONG.Name = "colLOAI_LAO_DONG";
            this.colLOAI_LAO_DONG.Visible = true;
            this.colLOAI_LAO_DONG.VisibleIndex = 3;
            this.colLOAI_LAO_DONG.Width = 27;
            // 
            // f372_nhan_vien_loai_lao_dong_excel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 390);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl1);
            this.Name = "f372_nhan_vien_loai_lao_dong_excel";
            this.Text = "F372 - Nhân viên loại lao động excel";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dMNHANVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dVMDDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dVMDDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dVMDDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDMNHANVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_grc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.SimpleButton m_cmd_luu;
        private DVMDDataSet2TableAdapters.DM_NHAN_VIENTableAdapter dM_NHAN_VIENTableAdapter;
        private System.Windows.Forms.BindingSource dMNHANVIENBindingSource;
        private DVMDDataSet2 dVMDDataSet2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label label1;
        private DVMDDataSet1 dVMDDataSet1;
        private System.Windows.Forms.BindingSource dVMDDataSet1BindingSource;
        private System.Windows.Forms.BindingSource vDMNHANVIENBindingSource;
        private DVMDDataSet1TableAdapters.V_DM_NHAN_VIENTableAdapter v_DM_NHAN_VIENTableAdapter;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl m_grc;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colMA_NV;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAY_BAT_DAU;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAY_KET_THUC;
        private DevExpress.XtraGrid.Columns.GridColumn colLOAI_LAO_DONG;
    }
}