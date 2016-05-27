namespace BKI_DichVuMatDat.HeThong
{
    partial class frm_backup_restore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_backup_restore));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAY_BACKUP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGUOI_BACKUP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNOI_LUU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN_FILE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhI_CHU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.m_cmd_phuc_hoi = new DevExpress.XtraEditors.SimpleButton();
            this.img_DVMD = new DevExpress.Utils.ImageCollection(this.components);
            this.m_cmd_backup = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_DVMD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 74);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(740, 396);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colNGAY_BACKUP,
            this.colNGUOI_BACKUP,
            this.colNOI_LUU,
            this.colTEN_FILE,
            this.colGhI_CHU});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colID
            // 
            this.colID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colID.AppearanceHeader.Options.UseFont = true;
            this.colID.AppearanceHeader.Options.UseTextOptions = true;
            this.colID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colID.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colID.Caption = "colID";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            // 
            // colNGAY_BACKUP
            // 
            this.colNGAY_BACKUP.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colNGAY_BACKUP.AppearanceHeader.Options.UseFont = true;
            this.colNGAY_BACKUP.AppearanceHeader.Options.UseTextOptions = true;
            this.colNGAY_BACKUP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNGAY_BACKUP.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colNGAY_BACKUP.Caption = "Ngày sao lưu";
            this.colNGAY_BACKUP.FieldName = "NGAY_BACKUP";
            this.colNGAY_BACKUP.Name = "colNGAY_BACKUP";
            this.colNGAY_BACKUP.Visible = true;
            this.colNGAY_BACKUP.VisibleIndex = 0;
            this.colNGAY_BACKUP.Width = 153;
            // 
            // colNGUOI_BACKUP
            // 
            this.colNGUOI_BACKUP.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colNGUOI_BACKUP.AppearanceHeader.Options.UseFont = true;
            this.colNGUOI_BACKUP.AppearanceHeader.Options.UseTextOptions = true;
            this.colNGUOI_BACKUP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNGUOI_BACKUP.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colNGUOI_BACKUP.Caption = "Người sao lưu";
            this.colNGUOI_BACKUP.FieldName = "NGUOI_BACKUP";
            this.colNGUOI_BACKUP.Name = "colNGUOI_BACKUP";
            this.colNGUOI_BACKUP.Visible = true;
            this.colNGUOI_BACKUP.VisibleIndex = 1;
            this.colNGUOI_BACKUP.Width = 197;
            // 
            // colNOI_LUU
            // 
            this.colNOI_LUU.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colNOI_LUU.AppearanceHeader.Options.UseFont = true;
            this.colNOI_LUU.AppearanceHeader.Options.UseTextOptions = true;
            this.colNOI_LUU.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNOI_LUU.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colNOI_LUU.Caption = "Tên File";
            this.colNOI_LUU.FieldName = "NOI_LUU";
            this.colNOI_LUU.Name = "colNOI_LUU";
            this.colNOI_LUU.Visible = true;
            this.colNOI_LUU.VisibleIndex = 2;
            this.colNOI_LUU.Width = 372;
            // 
            // colTEN_FILE
            // 
            this.colTEN_FILE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colTEN_FILE.AppearanceHeader.Options.UseFont = true;
            this.colTEN_FILE.AppearanceHeader.Options.UseTextOptions = true;
            this.colTEN_FILE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTEN_FILE.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colTEN_FILE.Caption = "Tên File";
            this.colTEN_FILE.FieldName = "TEN_FILE";
            this.colTEN_FILE.Name = "colTEN_FILE";
            this.colTEN_FILE.Width = 316;
            // 
            // colGhI_CHU
            // 
            this.colGhI_CHU.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colGhI_CHU.AppearanceHeader.Options.UseFont = true;
            this.colGhI_CHU.AppearanceHeader.Options.UseTextOptions = true;
            this.colGhI_CHU.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGhI_CHU.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colGhI_CHU.Caption = "Ghi chú";
            this.colGhI_CHU.FieldName = "GhI_CHU";
            this.colGhI_CHU.Name = "colGhI_CHU";
            this.colGhI_CHU.Width = 230;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.m_cmd_phuc_hoi);
            this.panelControl1.Controls.Add(this.m_cmd_backup);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(740, 44);
            this.panelControl1.TabIndex = 0;
            // 
            // m_cmd_phuc_hoi
            // 
            this.m_cmd_phuc_hoi.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_cmd_phuc_hoi.Appearance.Options.UseFont = true;
            this.m_cmd_phuc_hoi.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_phuc_hoi.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_phuc_hoi.Image")));
            this.m_cmd_phuc_hoi.ImageList = this.img_DVMD;
            this.m_cmd_phuc_hoi.Location = new System.Drawing.Point(140, 2);
            this.m_cmd_phuc_hoi.Name = "m_cmd_phuc_hoi";
            this.m_cmd_phuc_hoi.Size = new System.Drawing.Size(138, 40);
            this.m_cmd_phuc_hoi.TabIndex = 1;
            this.m_cmd_phuc_hoi.Text = "Phục hồi dữ liệu";
            this.m_cmd_phuc_hoi.Click += new System.EventHandler(this.m_cmd_phuc_hoi_Click);
            // 
            // img_DVMD
            // 
            this.img_DVMD.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("img_DVMD.ImageStream")));
            this.img_DVMD.Images.SetKeyName(0, "Excel-icon.png");
            this.img_DVMD.Images.SetKeyName(1, "excel-xls-icon.png");
            this.img_DVMD.Images.SetKeyName(2, "exit-16.ico");
            this.img_DVMD.Images.SetKeyName(3, "image.png");
            this.img_DVMD.Images.SetKeyName(4, "Microsoft Excel.png");
            this.img_DVMD.Images.SetKeyName(5, "calculator.png");
            this.img_DVMD.Images.SetKeyName(6, "diskette.png");
            this.img_DVMD.Images.SetKeyName(7, "file_add.png");
            this.img_DVMD.Images.SetKeyName(8, "file_delete.png");
            this.img_DVMD.Images.SetKeyName(9, "file_edit.png");
            this.img_DVMD.Images.SetKeyName(10, "file_search.png");
            // 
            // m_cmd_backup
            // 
            this.m_cmd_backup.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_cmd_backup.Appearance.Options.UseFont = true;
            this.m_cmd_backup.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_backup.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_backup.Image")));
            this.m_cmd_backup.ImageList = this.img_DVMD;
            this.m_cmd_backup.Location = new System.Drawing.Point(2, 2);
            this.m_cmd_backup.Name = "m_cmd_backup";
            this.m_cmd_backup.Size = new System.Drawing.Size(138, 40);
            this.m_cmd_backup.TabIndex = 0;
            this.m_cmd_backup.Text = "Sao lưu dữ liệu";
            this.m_cmd_backup.Click += new System.EventHandler(this.m_cmd_backup_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 44);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(740, 30);
            this.panelControl2.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelControl1.Location = new System.Drawing.Point(2, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(138, 26);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Lịch sử sao lưu dữ liệu";
            // 
            // frm_backup_restore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 470);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "frm_backup_restore";
            this.Text = "Sao lưu dữ liệu";
            this.Load += new System.EventHandler(this.frm_backup_restore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_DVMD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton m_cmd_backup;
        private DevExpress.Utils.ImageCollection img_DVMD;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAY_BACKUP;
        private DevExpress.XtraGrid.Columns.GridColumn colNGUOI_BACKUP;
        private DevExpress.XtraGrid.Columns.GridColumn colNOI_LUU;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN_FILE;
        private DevExpress.XtraGrid.Columns.GridColumn colGhI_CHU;
        private DevExpress.XtraEditors.SimpleButton m_cmd_phuc_hoi;
    }
}