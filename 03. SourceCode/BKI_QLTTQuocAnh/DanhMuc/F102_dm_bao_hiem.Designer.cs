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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.m_grc_dm_bao_hiem = new DevExpress.XtraGrid.GridControl();
            this.m_grv_dm_bao_hiem = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.m_lbl_header = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.c_ma_bao_hiem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_ten_bao_hiem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_ti_le = new DevExpress.XtraGrid.Columns.GridColumn();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_dm_bao_hiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_dm_bao_hiem)).BeginInit();
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
            this.c_ti_le});
            this.m_grv_dm_bao_hiem.GridControl = this.m_grc_dm_bao_hiem;
            this.m_grv_dm_bao_hiem.Name = "m_grv_dm_bao_hiem";
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
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 421);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 37);
            this.panel1.TabIndex = 3;
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
            // F102_DM_BAO_HIEM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 458);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.m_lbl_header);
            this.Controls.Add(this.m_grc_dm_bao_hiem);
            this.Name = "F102_DM_BAO_HIEM";
            this.Text = "F102_DANH MỤC BẢO HIỂM";
            this.Load += new System.EventHandler(this.F102_DM_BAO_HIEM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_dm_bao_hiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_dm_bao_hiem)).EndInit();
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
    }
}