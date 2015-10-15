namespace BKI_DichVuMatDat.NghiepVu
{
    partial class BackupDB
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.m_cmd_add_new_back_up = new System.Windows.Forms.Button();
            this.m_txt_ten_file = new System.Windows.Forms.TextBox();
            this.m_cmd_backup = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.m_txt_location = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.m_cmd_restore = new System.Windows.Forms.Button();
            this.m_txt_backup_path = new System.Windows.Forms.TextBox();
            this.Back = new System.Windows.Forms.Label();
            this.gridControlSave = new DevExpress.XtraGrid.GridControl();
            this.gridViewSave = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FILE_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DISK_LOCATION_FILE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAY_TAO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSave)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.m_cmd_add_new_back_up);
            this.groupBox4.Controls.Add(this.m_txt_ten_file);
            this.groupBox4.Controls.Add(this.m_cmd_backup);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.m_txt_location);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(816, 123);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Lưu trữ dữ liệu";
            // 
            // m_cmd_add_new_back_up
            // 
            this.m_cmd_add_new_back_up.Location = new System.Drawing.Point(461, 26);
            this.m_cmd_add_new_back_up.Name = "m_cmd_add_new_back_up";
            this.m_cmd_add_new_back_up.Size = new System.Drawing.Size(102, 23);
            this.m_cmd_add_new_back_up.TabIndex = 5;
            this.m_cmd_add_new_back_up.Text = "Tạo tên File mới";
            this.m_cmd_add_new_back_up.UseVisualStyleBackColor = true;
            // 
            // m_txt_ten_file
            // 
            this.m_txt_ten_file.Location = new System.Drawing.Point(140, 28);
            this.m_txt_ten_file.Name = "m_txt_ten_file";
            this.m_txt_ten_file.ReadOnly = true;
            this.m_txt_ten_file.Size = new System.Drawing.Size(315, 20);
            this.m_txt_ten_file.TabIndex = 4;
            // 
            // m_cmd_backup
            // 
            this.m_cmd_backup.Location = new System.Drawing.Point(140, 80);
            this.m_cmd_backup.Name = "m_cmd_backup";
            this.m_cmd_backup.Size = new System.Drawing.Size(75, 23);
            this.m_cmd_backup.TabIndex = 5;
            this.m_cmd_backup.Text = "Lưu trữ";
            this.m_cmd_backup.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên file";
            // 
            // m_txt_location
            // 
            this.m_txt_location.Location = new System.Drawing.Point(140, 54);
            this.m_txt_location.Name = "m_txt_location";
            this.m_txt_location.ReadOnly = true;
            this.m_txt_location.Size = new System.Drawing.Size(315, 20);
            this.m_txt_location.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Địa chỉ lưu file";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.m_cmd_restore);
            this.groupBox5.Controls.Add(this.m_txt_backup_path);
            this.groupBox5.Controls.Add(this.Back);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox5.Location = new System.Drawing.Point(0, 371);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(816, 74);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Hồi phục dữ liệu";
            // 
            // m_cmd_restore
            // 
            this.m_cmd_restore.Location = new System.Drawing.Point(461, 28);
            this.m_cmd_restore.Name = "m_cmd_restore";
            this.m_cmd_restore.Size = new System.Drawing.Size(75, 23);
            this.m_cmd_restore.TabIndex = 3;
            this.m_cmd_restore.Text = "Hồi phục";
            this.m_cmd_restore.UseVisualStyleBackColor = true;
            // 
            // m_txt_backup_path
            // 
            this.m_txt_backup_path.Location = new System.Drawing.Point(140, 30);
            this.m_txt_backup_path.Name = "m_txt_backup_path";
            this.m_txt_backup_path.ReadOnly = true;
            this.m_txt_backup_path.Size = new System.Drawing.Size(315, 20);
            this.m_txt_backup_path.TabIndex = 1;
            // 
            // Back
            // 
            this.Back.AutoSize = true;
            this.Back.Location = new System.Drawing.Point(22, 33);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(103, 13);
            this.Back.TabIndex = 0;
            this.Back.Text = "Địa chỉ File hồi phục";
            // 
            // gridControlSave
            // 
            this.gridControlSave.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControlSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlSave.Location = new System.Drawing.Point(0, 123);
            this.gridControlSave.MainView = this.gridViewSave;
            this.gridControlSave.Name = "gridControlSave";
            this.gridControlSave.Size = new System.Drawing.Size(816, 248);
            this.gridControlSave.TabIndex = 4;
            this.gridControlSave.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewSave});
            // 
            // gridViewSave
            // 
            this.gridViewSave.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.STT,
            this.FILE_NAME,
            this.DISK_LOCATION_FILE,
            this.NGAY_TAO});
            this.gridViewSave.GridControl = this.gridControlSave;
            this.gridViewSave.Name = "gridViewSave";
            this.gridViewSave.OptionsBehavior.Editable = false;
            this.gridViewSave.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDown;
            this.gridViewSave.OptionsBehavior.ReadOnly = true;
            this.gridViewSave.OptionsView.ShowGroupPanel = false;
            // 
            // STT
            // 
            this.STT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.STT.AppearanceHeader.Options.UseFont = true;
            this.STT.AppearanceHeader.Options.UseTextOptions = true;
            this.STT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.STT.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.STT.Caption = "STT";
            this.STT.FieldName = "STT";
            this.STT.Name = "STT";
            this.STT.Visible = true;
            this.STT.VisibleIndex = 0;
            this.STT.Width = 52;
            // 
            // FILE_NAME
            // 
            this.FILE_NAME.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.FILE_NAME.AppearanceHeader.Options.UseFont = true;
            this.FILE_NAME.AppearanceHeader.Options.UseTextOptions = true;
            this.FILE_NAME.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.FILE_NAME.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.FILE_NAME.Caption = "Tên File";
            this.FILE_NAME.FieldName = "FILE_NAME";
            this.FILE_NAME.Name = "FILE_NAME";
            this.FILE_NAME.Visible = true;
            this.FILE_NAME.VisibleIndex = 1;
            this.FILE_NAME.Width = 247;
            // 
            // DISK_LOCATION_FILE
            // 
            this.DISK_LOCATION_FILE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.DISK_LOCATION_FILE.AppearanceHeader.Options.UseFont = true;
            this.DISK_LOCATION_FILE.AppearanceHeader.Options.UseTextOptions = true;
            this.DISK_LOCATION_FILE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.DISK_LOCATION_FILE.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.DISK_LOCATION_FILE.Caption = "Địa chỉ";
            this.DISK_LOCATION_FILE.FieldName = "DISK_LOCATION";
            this.DISK_LOCATION_FILE.Name = "DISK_LOCATION_FILE";
            this.DISK_LOCATION_FILE.Visible = true;
            this.DISK_LOCATION_FILE.VisibleIndex = 2;
            this.DISK_LOCATION_FILE.Width = 247;
            // 
            // NGAY_TAO
            // 
            this.NGAY_TAO.AppearanceCell.Options.UseTextOptions = true;
            this.NGAY_TAO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NGAY_TAO.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.NGAY_TAO.AppearanceHeader.Options.UseFont = true;
            this.NGAY_TAO.AppearanceHeader.Options.UseTextOptions = true;
            this.NGAY_TAO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NGAY_TAO.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.NGAY_TAO.Caption = "Ngày tạo";
            this.NGAY_TAO.FieldName = "NGAY_TAO";
            this.NGAY_TAO.Name = "NGAY_TAO";
            this.NGAY_TAO.Visible = true;
            this.NGAY_TAO.VisibleIndex = 3;
            this.NGAY_TAO.Width = 206;
            // 
            // BackupDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 445);
            this.Controls.Add(this.gridControlSave);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Name = "BackupDB";
            this.Text = "Lưu trữ dữ liệu";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSave)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox m_txt_location;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button m_cmd_backup;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button m_cmd_restore;
        private System.Windows.Forms.TextBox m_txt_backup_path;
        private System.Windows.Forms.Label Back;
        private System.Windows.Forms.TextBox m_txt_ten_file;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraGrid.GridControl gridControlSave;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewSave;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
        private DevExpress.XtraGrid.Columns.GridColumn FILE_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn DISK_LOCATION_FILE;
        private DevExpress.XtraGrid.Columns.GridColumn NGAY_TAO;
        private System.Windows.Forms.Button m_cmd_add_new_back_up;
    }
}