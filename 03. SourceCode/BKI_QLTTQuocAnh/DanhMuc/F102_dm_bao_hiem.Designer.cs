namespace BKI_DichVuMatDat.DanhMuc
{
    partial class F102_dm_bao_hiem
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F102_dm_bao_hiem));
            this.m_grc_dm_bao_hiem = new DevExpress.XtraGrid.GridControl();
            this.m_grv_dm_bao_hiem = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_ma_bao_hiem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_ten_bao_hiem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_ti_le = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.m_lbl_header = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.c_cmd_dm_bao_hiem_xoa = new SIS.Controls.Button.SiSButton();
            this.c_cmd_dm_bao_hiem_sua = new SIS.Controls.Button.SiSButton();
            this.m_cmd_dm_bao_hiem_them = new SIS.Controls.Button.SiSButton();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_dm_bao_hiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_dm_bao_hiem)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_grc_dm_bao_hiem
            // 
            this.m_grc_dm_bao_hiem.Cursor = System.Windows.Forms.Cursors.Default;
            gridLevelNode1.RelationName = "Level1";
            this.m_grc_dm_bao_hiem.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.m_grc_dm_bao_hiem.Location = new System.Drawing.Point(0, 47);
            this.m_grc_dm_bao_hiem.MainView = this.m_grv_dm_bao_hiem;
            this.m_grc_dm_bao_hiem.Name = "m_grc_dm_bao_hiem";
            this.m_grc_dm_bao_hiem.Size = new System.Drawing.Size(794, 378);
            this.m_grc_dm_bao_hiem.TabIndex = 0;
            this.m_grc_dm_bao_hiem.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv_dm_bao_hiem});
            // 
            // m_grv_dm_bao_hiem
            // 
            this.m_grv_dm_bao_hiem.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.STT,
            this.c_ma_bao_hiem,
            this.c_ten_bao_hiem,
            this.c_ti_le,
            this.gridColumn1});
            this.m_grv_dm_bao_hiem.GridControl = this.m_grc_dm_bao_hiem;
            this.m_grv_dm_bao_hiem.Name = "m_grv_dm_bao_hiem";
            // 
            // STT
            // 
            this.STT.AppearanceCell.Options.UseTextOptions = true;
            this.STT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.STT.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.STT.AppearanceHeader.Options.UseTextOptions = true;
            this.STT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.STT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.STT.Caption = "STT";
            this.STT.FieldName = "STT";
            this.STT.Name = "STT";
            this.STT.Visible = true;
            this.STT.VisibleIndex = 0;
            this.STT.Width = 38;
            // 
            // c_ma_bao_hiem
            // 
            this.c_ma_bao_hiem.AppearanceHeader.Options.UseTextOptions = true;
            this.c_ma_bao_hiem.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.c_ma_bao_hiem.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.c_ma_bao_hiem.Caption = "Mã bảo hiểm";
            this.c_ma_bao_hiem.FieldName = "MA_BH";
            this.c_ma_bao_hiem.Name = "c_ma_bao_hiem";
            this.c_ma_bao_hiem.Visible = true;
            this.c_ma_bao_hiem.VisibleIndex = 1;
            this.c_ma_bao_hiem.Width = 246;
            // 
            // c_ten_bao_hiem
            // 
            this.c_ten_bao_hiem.AppearanceHeader.Options.UseTextOptions = true;
            this.c_ten_bao_hiem.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.c_ten_bao_hiem.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.c_ten_bao_hiem.Caption = "Tên bảo hiểm";
            this.c_ten_bao_hiem.FieldName = "TEN_BH";
            this.c_ten_bao_hiem.Name = "c_ten_bao_hiem";
            this.c_ten_bao_hiem.Visible = true;
            this.c_ten_bao_hiem.VisibleIndex = 2;
            this.c_ten_bao_hiem.Width = 246;
            // 
            // c_ti_le
            // 
            this.c_ti_le.AppearanceHeader.Options.UseTextOptions = true;
            this.c_ti_le.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.c_ti_le.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.c_ti_le.Caption = "Tỉ lệ";
            this.c_ti_le.FieldName = "TI_LE";
            this.c_ti_le.Name = "c_ti_le";
            this.c_ti_le.Visible = true;
            this.c_ti_le.VisibleIndex = 3;
            this.c_ti_le.Width = 246;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "ID";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // m_lbl_header
            // 
            this.m_lbl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.m_lbl_header.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_header.Location = new System.Drawing.Point(0, 0);
            this.m_lbl_header.Name = "m_lbl_header";
            this.m_lbl_header.Size = new System.Drawing.Size(794, 44);
            this.m_lbl_header.TabIndex = 2;
            this.m_lbl_header.Text = "DANH MỤC BẢO HIỂM";
            this.m_lbl_header.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.c_cmd_dm_bao_hiem_xoa);
            this.panel1.Controls.Add(this.c_cmd_dm_bao_hiem_sua);
            this.panel1.Controls.Add(this.m_cmd_dm_bao_hiem_them);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 421);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 37);
            this.panel1.TabIndex = 3;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "");
            this.imageList1.Images.SetKeyName(3, "");
            this.imageList1.Images.SetKeyName(4, "");
            this.imageList1.Images.SetKeyName(5, "");
            this.imageList1.Images.SetKeyName(6, "");
            this.imageList1.Images.SetKeyName(7, "");
            this.imageList1.Images.SetKeyName(8, "");
            this.imageList1.Images.SetKeyName(9, "");
            this.imageList1.Images.SetKeyName(10, "");
            this.imageList1.Images.SetKeyName(11, "");
            this.imageList1.Images.SetKeyName(12, "");
            this.imageList1.Images.SetKeyName(13, "");
            this.imageList1.Images.SetKeyName(14, "");
            this.imageList1.Images.SetKeyName(15, "");
            this.imageList1.Images.SetKeyName(16, "");
            this.imageList1.Images.SetKeyName(17, "");
            this.imageList1.Images.SetKeyName(18, "");
            this.imageList1.Images.SetKeyName(19, "");
            this.imageList1.Images.SetKeyName(20, "");
            this.imageList1.Images.SetKeyName(21, "");
            // 
            // c_cmd_dm_bao_hiem_xoa
            // 
            this.c_cmd_dm_bao_hiem_xoa.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.c_cmd_dm_bao_hiem_xoa.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.c_cmd_dm_bao_hiem_xoa.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.c_cmd_dm_bao_hiem_xoa.Dock = System.Windows.Forms.DockStyle.Left;
            this.c_cmd_dm_bao_hiem_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.c_cmd_dm_bao_hiem_xoa.ImageIndex = 4;
            this.c_cmd_dm_bao_hiem_xoa.ImageList = this.imageList1;
            this.c_cmd_dm_bao_hiem_xoa.Location = new System.Drawing.Point(172, 0);
            this.c_cmd_dm_bao_hiem_xoa.Name = "c_cmd_dm_bao_hiem_xoa";
            this.c_cmd_dm_bao_hiem_xoa.Size = new System.Drawing.Size(86, 37);
            this.c_cmd_dm_bao_hiem_xoa.TabIndex = 6;
            this.c_cmd_dm_bao_hiem_xoa.Text = "&Xóa";
            // 
            // c_cmd_dm_bao_hiem_sua
            // 
            this.c_cmd_dm_bao_hiem_sua.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.c_cmd_dm_bao_hiem_sua.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.c_cmd_dm_bao_hiem_sua.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.c_cmd_dm_bao_hiem_sua.Dock = System.Windows.Forms.DockStyle.Left;
            this.c_cmd_dm_bao_hiem_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.c_cmd_dm_bao_hiem_sua.ImageIndex = 16;
            this.c_cmd_dm_bao_hiem_sua.ImageList = this.imageList1;
            this.c_cmd_dm_bao_hiem_sua.Location = new System.Drawing.Point(86, 0);
            this.c_cmd_dm_bao_hiem_sua.Name = "c_cmd_dm_bao_hiem_sua";
            this.c_cmd_dm_bao_hiem_sua.Size = new System.Drawing.Size(86, 37);
            this.c_cmd_dm_bao_hiem_sua.TabIndex = 5;
            this.c_cmd_dm_bao_hiem_sua.Text = "&Sửa";
            // 
            // m_cmd_dm_bao_hiem_them
            // 
            this.m_cmd_dm_bao_hiem_them.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_dm_bao_hiem_them.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_dm_bao_hiem_them.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_dm_bao_hiem_them.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_dm_bao_hiem_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_dm_bao_hiem_them.ImageIndex = 3;
            this.m_cmd_dm_bao_hiem_them.ImageList = this.imageList1;
            this.m_cmd_dm_bao_hiem_them.Location = new System.Drawing.Point(0, 0);
            this.m_cmd_dm_bao_hiem_them.Name = "m_cmd_dm_bao_hiem_them";
            this.m_cmd_dm_bao_hiem_them.Size = new System.Drawing.Size(86, 37);
            this.m_cmd_dm_bao_hiem_them.TabIndex = 4;
            this.m_cmd_dm_bao_hiem_them.Text = "&Thêm";
            // 
            // F102_dm_bao_hiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 458);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.m_lbl_header);
            this.Controls.Add(this.m_grc_dm_bao_hiem);
            this.Name = "F102_dm_bao_hiem";
            this.Text = "F102_DANH MỤC BẢO HIỂM";
            this.Load += new System.EventHandler(this.F102_dm_bao_hiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_dm_bao_hiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_dm_bao_hiem)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        
        private DevExpress.XtraGrid.GridControl m_grc_dm_bao_hiem;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv_dm_bao_hiem;
        private System.Windows.Forms.Label m_lbl_header;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
        private DevExpress.XtraGrid.Columns.GridColumn c_ma_bao_hiem;
        private DevExpress.XtraGrid.Columns.GridColumn c_ten_bao_hiem;
        private DevExpress.XtraGrid.Columns.GridColumn c_ti_le;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        internal SIS.Controls.Button.SiSButton c_cmd_dm_bao_hiem_xoa;
        internal System.Windows.Forms.ImageList imageList1;
        internal SIS.Controls.Button.SiSButton c_cmd_dm_bao_hiem_sua;
        internal SIS.Controls.Button.SiSButton m_cmd_dm_bao_hiem_them;
    }
}