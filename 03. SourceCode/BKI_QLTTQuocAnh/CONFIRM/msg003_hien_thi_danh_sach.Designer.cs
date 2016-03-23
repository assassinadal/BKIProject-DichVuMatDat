namespace BKI_DichVuMatDat.CONFIRM
{
    partial class msg003_hien_thi_danh_sach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(msg003_hien_thi_danh_sach));
            this.m_memo_content = new DevExpress.XtraEditors.MemoEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.m_cmd_exit = new DevExpress.XtraEditors.SimpleButton();
            this.imageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.m_lbl_content = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.m_memo_content.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).BeginInit();
            this.SuspendLayout();
            // 
            // m_memo_content
            // 
            this.m_memo_content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_memo_content.Location = new System.Drawing.Point(0, 31);
            this.m_memo_content.Name = "m_memo_content";
            this.m_memo_content.Size = new System.Drawing.Size(413, 182);
            this.m_memo_content.TabIndex = 0;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.m_cmd_exit);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 213);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(413, 40);
            this.panelControl1.TabIndex = 1;
            // 
            // m_cmd_exit
            // 
            this.m_cmd_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_exit.ImageList = this.imageCollection;
            this.m_cmd_exit.Location = new System.Drawing.Point(317, 2);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(94, 36);
            this.m_cmd_exit.TabIndex = 11;
            this.m_cmd_exit.Text = "Thoát";
            this.m_cmd_exit.Click += new System.EventHandler(this.m_cmd_exit_Click);
            // 
            // imageCollection
            // 
            this.imageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection.ImageStream")));
            this.imageCollection.Images.SetKeyName(0, "dvmd_download.png");
            this.imageCollection.Images.SetKeyName(1, "dvmd_upload.png");
            this.imageCollection.Images.SetKeyName(2, "lock.png");
            this.imageCollection.Images.SetKeyName(3, "refresh.png");
            this.imageCollection.Images.SetKeyName(4, "dvmd_info.png");
            this.imageCollection.Images.SetKeyName(5, "play.png");
            this.imageCollection.Images.SetKeyName(6, "pause.png");
            this.imageCollection.Images.SetKeyName(7, "pencil.png");
            this.imageCollection.Images.SetKeyName(8, "trash.png");
            this.imageCollection.Images.SetKeyName(9, "grid.png");
            this.imageCollection.Images.SetKeyName(10, "list.png");
            this.imageCollection.Images.SetKeyName(11, "eye.png");
            this.imageCollection.Images.SetKeyName(12, "note.png");
            // 
            // m_lbl_content
            // 
            this.m_lbl_content.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.m_lbl_content.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_lbl_content.Location = new System.Drawing.Point(0, 0);
            this.m_lbl_content.Name = "m_lbl_content";
            this.m_lbl_content.Padding = new System.Windows.Forms.Padding(7, 5, 0, 10);
            this.m_lbl_content.Size = new System.Drawing.Size(92, 31);
            this.m_lbl_content.TabIndex = 2;
            this.m_lbl_content.Text = "labelControl1";
            // 
            // msg003_hien_thi_danh_sach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 253);
            this.Controls.Add(this.m_memo_content);
            this.Controls.Add(this.m_lbl_content);
            this.Controls.Add(this.panelControl1);
            this.Name = "msg003_hien_thi_danh_sach";
            this.Text = "THÔNG BÁO";
            ((System.ComponentModel.ISupportInitialize)(this.m_memo_content.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.MemoEdit m_memo_content;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.Utils.ImageCollection imageCollection;
        private DevExpress.XtraEditors.SimpleButton m_cmd_exit;
        private DevExpress.XtraEditors.LabelControl m_lbl_content;
    }
}