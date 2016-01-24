using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

using IP.Core.IPCommon;
using IP.Core.IPException;
using IP.Core.IPData;
using IP.Core.IPUserService;

using BKI_DichVuMatDat.DS;
using BKI_DichVuMatDat.US;
using BKI_DichVuMatDat.DS.CDBNames;
using System.Configuration;
using System.Data.OleDb;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Utils.Menu;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;


namespace BKI_DichVuMatDat
{
    public class WinFormControls
    {
        public WinFormControls()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        public enum eTAT_CA
        {
            YES,
            NO
        }

        public enum eLOAI_TU_DIEN
        {
            TRANG_THAI_CHUC_VU,
            LOAI_HOP_DONG,
            LOAI_DON_VI,
            CAP_DON_VI,
            CO_CHE,
            LOAI_DU_AN,
            TRANG_THAI_DU_AN,
            LOAI_QUYET_DINH,
            TRANG_THAI_LAO_DONG,
            DM_CA_HOC
        }

        public static void load_data_to_cbo_tu_dien(
             eLOAI_TU_DIEN ip_e
            , eTAT_CA ip_e_tat_ca
            , ComboBox ip_obj_cbo_trang_thai)
        {

            IP.Core.IPUserService.US_CM_DM_TU_DIEN v_us_dm_tu_dien = new IP.Core.IPUserService.US_CM_DM_TU_DIEN();
            IP.Core.IPData.DS_CM_DM_TU_DIEN v_ds_dm_tu_dien = new IP.Core.IPData.DS_CM_DM_TU_DIEN();
            string v_str_loai_tu_dien = "";
            switch (ip_e)
            {
                case eLOAI_TU_DIEN.TRANG_THAI_CHUC_VU:
                    v_str_loai_tu_dien = MA_LOAI_TU_DIEN.TRANG_THAI_CHUC_VU;
                    break;
                case eLOAI_TU_DIEN.LOAI_HOP_DONG:
                    v_str_loai_tu_dien = MA_LOAI_TU_DIEN.LOAI_HOP_DONG;
                    break;
                case eLOAI_TU_DIEN.LOAI_DON_VI:
                    v_str_loai_tu_dien = MA_LOAI_TU_DIEN.LOAI_DON_VI;
                    break;
                case eLOAI_TU_DIEN.CAP_DON_VI:
                    v_str_loai_tu_dien = MA_LOAI_TU_DIEN.CAP_DON_VI;
                    break;
                case eLOAI_TU_DIEN.LOAI_QUYET_DINH:
                    v_str_loai_tu_dien = MA_LOAI_TU_DIEN.LOAI_QUYET_DINH;
                    break;
                case eLOAI_TU_DIEN.TRANG_THAI_LAO_DONG:
                    v_str_loai_tu_dien = MA_LOAI_TU_DIEN.TRANG_THAI_LAO_DONG;
                    break;
                case eLOAI_TU_DIEN.DM_CA_HOC:
                    v_str_loai_tu_dien = MA_LOAI_TU_DIEN.DM_CA_HOC;
                    break;
            }
            v_us_dm_tu_dien.fill_tu_dien_cung_loai_ds(
                v_str_loai_tu_dien
                , CM_DM_TU_DIEN.GHI_CHU
                , v_ds_dm_tu_dien);

            ip_obj_cbo_trang_thai.DataSource = v_ds_dm_tu_dien.CM_DM_TU_DIEN;
            ip_obj_cbo_trang_thai.DisplayMember = CM_DM_TU_DIEN.TEN;
            ip_obj_cbo_trang_thai.ValueMember = CM_DM_TU_DIEN.ID;

            if (ip_e_tat_ca == eTAT_CA.YES)
            {
                DataRow v_dr = v_ds_dm_tu_dien.CM_DM_TU_DIEN.NewRow();
                v_dr[CM_DM_TU_DIEN.ID] = -1;
                v_dr[CM_DM_TU_DIEN.TEN] = "------ Tất cả ------";
                v_dr[CM_DM_TU_DIEN.MA_TU_DIEN] = "";
                v_dr[CM_DM_TU_DIEN.TEN_NGAN] = "";
                v_dr[CM_DM_TU_DIEN.ID_LOAI_TU_DIEN] = 1;
                v_dr[CM_DM_TU_DIEN.GHI_CHU] = "";
                v_ds_dm_tu_dien.CM_DM_TU_DIEN.Rows.InsertAt(v_dr, 0);
                ip_obj_cbo_trang_thai.SelectedIndex = 0;
            }
        }

        public static void load_data_to_auto_complete_source(string ip_str_table_name, string ip_str_column_name, TextBox ip_txt)
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            DataTable v_dt = new DataTable();
            v_ds.Tables.Add(v_dt);
            v_us.FillDatasetWithProc(v_ds, ip_str_table_name, ip_str_column_name);
            for (int i = 0; i < v_ds.Tables[0].Rows.Count; i++)
            {
                DataRow v_dr = v_ds.Tables[0].Rows[i];
                ip_txt.AutoCompleteCustomSource.Add(v_dr[ip_str_column_name].ToString());
            }
        }

        public static void load_data_to_combobox(string ip_str_table_name, string ip_str_value_field, string ip_str_display_field, string ip_str_condition, eTAT_CA ip_e_tat_ca, ComboBox ip_cbo)
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            DataTable v_dt = new DataTable();
            v_ds.Tables.Add(v_dt);
            v_us.FillDatasetCBO(v_ds, ip_str_table_name, ip_str_value_field, ip_str_display_field, ip_str_condition);

            ip_cbo.DisplayMember = ip_str_display_field;
            ip_cbo.ValueMember = ip_str_value_field;
            ip_cbo.DataSource = v_ds.Tables[0];

            if (ip_e_tat_ca == eTAT_CA.YES)
            {
                DataRow v_dr = v_ds.Tables[0].NewRow();
                v_dr[0] = -1;
                v_dr[1] = "------ Tất cả ------";
                v_ds.Tables[0].Rows.InsertAt(v_dr, 0);
                ip_cbo.SelectedIndex = 0;
            }
            else
            {
                ip_cbo.SelectedIndex = 0;
            }
        }

        public static void load_data_to_combobox_with_query(ComboBox ip_cbo, string ip_str_value_field, string ip_str_display_field, eTAT_CA ip_e_tat_ca, string ip_query)
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            DataTable v_dt = new DataTable();
            v_ds.Tables.Add(v_dt);
            v_us.FillDatasetWithQuery(v_ds, ip_query);

            ip_cbo.DisplayMember = ip_str_display_field;
            ip_cbo.ValueMember = ip_str_value_field;
            ip_cbo.DataSource = v_ds.Tables[0];

            if (ip_e_tat_ca == eTAT_CA.YES)
            {
                DataRow v_dr = v_ds.Tables[0].NewRow();
                v_dr[0] = -1;
                v_dr[1] = "------ Tất cả ------";
                v_ds.Tables[0].Rows.InsertAt(v_dr, 0);
                ip_cbo.SelectedIndex = 0;
            }
            else
            {
                ip_cbo.SelectedIndex = 0;
            }
        }

        public static void load_xls_to_gridview(string ip_str_path, DevExpress.XtraGrid.GridControl ip_grc)
        {
            string conStr = "";
            conStr = ConfigurationManager.ConnectionStrings["Excel07ConString"].ConnectionString;
            conStr = String.Format(conStr, ip_str_path, "Yes");
            OleDbConnection con = new OleDbConnection(conStr);
            OleDbCommand ExcelCommand = new OleDbCommand();
            ExcelCommand.Connection = con;
            con.Open();
            DataTable ExcelDataSet = new DataTable();
            ExcelDataSet = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
            DataTable dt = new DataTable();
            if (ExcelDataSet != null && ExcelDataSet.Rows.Count > 0)
            {
                string SheetName = ExcelDataSet.Rows[0]["TABLE_NAME"].ToString(); // get sheetname
                ExcelCommand.CommandText = "SELECT * From [" + SheetName + "]";
                OleDbDataAdapter ExcelAdapter = new OleDbDataAdapter(ExcelCommand);
                ExcelAdapter.SelectCommand = ExcelCommand;
                ExcelAdapter.Fill(dt);
            }
            con.Close();
            format_data_header(dt);
            ip_grc.DataSource = dt;
        }
        public static void load_xls_to_data_table(string ip_str_path, ref DataTable ip_dt_src)
        {
            string conStr = "";
            conStr = ConfigurationManager.ConnectionStrings["Excel07ConString"].ConnectionString;
            conStr = String.Format(conStr, ip_str_path, "Yes");
            OleDbConnection con = new OleDbConnection(conStr);
            OleDbCommand ExcelCommand = new OleDbCommand();
            ExcelCommand.Connection = con;
            con.Open();
            DataTable ExcelDataSet = new DataTable();
            ExcelDataSet = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
            DataTable dt = new DataTable();
            if(ExcelDataSet != null && ExcelDataSet.Rows.Count > 0)
            {
                string SheetName = ExcelDataSet.Rows[0]["TABLE_NAME"].ToString(); // get sheetname
                ExcelCommand.CommandText = "SELECT * From [" + SheetName + "]";
                OleDbDataAdapter ExcelAdapter = new OleDbDataAdapter(ExcelCommand);
                ExcelAdapter.SelectCommand = ExcelCommand;
                ExcelAdapter.Fill(dt);
                ip_dt_src = dt;
            }
            con.Close();
        }
        private static void format_data_header(DataTable dt)
        {
            foreach (DataColumn item in dt.Columns)
            {
                if (item.ColumnName.StartsWith("4"))
                {
                    var v_name_value = int.Parse(item.ColumnName.Trim());
                    var v_str_name = (new DateTime(1899, 12, 31).AddDays(v_name_value)).ToString("dd/MM/yyyy");
                    item.ColumnName = v_str_name;
                }
            }
        }

        #region Report
        static GridView m_grv;
        public static void m_grv_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.MenuType == DevExpress.XtraGrid.Views.Grid.GridMenuType.Row)
            {
                int rowHandle = e.HitInfo.RowHandle;
                e.Menu.Items.Clear();
                e.Menu.Items.Add(WinFormControls.CreateRowSubMenu(view, rowHandle));
            }
        }

        public static DXMenuItem CreateRowSubMenu(GridView view, int rowHandle)
        {
            m_grv = view;
            DXSubMenuItem subMenu = new DXSubMenuItem("Báo cáo");
            DXMenuItem menuItemReportXLS = new DXMenuItem("&Báo cáo XLS", new EventHandler(ExportXLSClick));
            DXMenuItem menuItemReportPDF = new DXMenuItem("&Báo cáo PDF", new EventHandler(ExportPDFClick));
            DXMenuItem menuItemReportHTML = new DXMenuItem("&Báo cáo HTML", new EventHandler(ExportHTMLClick));
            DXMenuItem menuItemReportDOC = new DXMenuItem("&Báo cáo TXT", new EventHandler(ExportDOCClick));
            subMenu.Items.Add(menuItemReportXLS);
            subMenu.Items.Add(menuItemReportPDF);
            subMenu.Items.Add(menuItemReportHTML);
            subMenu.Items.Add(menuItemReportDOC);
            return subMenu;
        }

        private static void ExportPDFClick(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                m_grv.ExportToPdf(saveFileDialog1.FileName);
                DevExpress.XtraEditors.XtraMessageBox.Show("Lưu báo cáo thành công");
            }
        }

        private static void ExportHTMLClick(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "html files (*.html)|*.html|All files (*.*)|*.*";
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                m_grv.ExportToHtml(saveFileDialog1.FileName);
                DevExpress.XtraEditors.XtraMessageBox.Show("Lưu báo cáo thành công");
            }
        }

        private static void ExportDOCClick(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                m_grv.ExportToText(saveFileDialog1.FileName);
                DevExpress.XtraEditors.XtraMessageBox.Show("Lưu báo cáo thành công");
            }
        }

        private static void ExportXLSClick(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "xls files (*.xls)|*.xls|All files (*.*)|*.*";
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                m_grv.ExportToXls(saveFileDialog1.FileName);
                DevExpress.XtraEditors.XtraMessageBox.Show("Lưu báo cáo thành công");
            }
        }
        #endregion

        #region openFileDialog
        public static string openFileDialog() {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // Set filter options and filter index.
            openFileDialog1.Filter = "xls Files|*.xls|xlsx Files|*.xlsx|All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Multiselect = false;
            var userClickedOK = openFileDialog1.ShowDialog();
            if (userClickedOK == System.Windows.Forms.DialogResult.OK)
            {
                return openFileDialog1.FileName;
            }
            return "";
        } 
        #endregion

        #region copy & open Template
        public static void openTemplate(string ip_file_name) {
            string sourcePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Template\");
            string targetPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string sourceFile = System.IO.Path.Combine(sourcePath, ip_file_name);
            string destFile = System.IO.Path.Combine(targetPath, ip_file_name);
            if (!System.IO.Directory.Exists(targetPath))
            {
                System.IO.Directory.CreateDirectory(targetPath);
            }
            System.IO.File.Copy(sourceFile, destFile, true);
            string newpath = targetPath + "\\" + ip_file_name;
            var excel = new Excel.Application();
            excel.Visible = true;
            Excel.Workbooks books = excel.Workbooks;
            Excel.Workbook openexcel = books.Open(newpath);
        }
        #endregion

        #region Drag Control
        private static bool isDragging = false;
        static Point move;

        public static void allowDragControl(Control ip_c) {
            ip_c.MouseDown += new MouseEventHandler(c_MouseDown);
            ip_c.MouseMove += new MouseEventHandler(c_MouseMove);
            ip_c.MouseUp += new MouseEventHandler(c_MouseUp);
        }

        static void c_MouseDown(object sender, MouseEventArgs e)
        {
            Control c = sender as Control;
            isDragging = true;
            move = e.Location;
        }

        static void c_MouseMove(object sender, MouseEventArgs e)
        {

            if (isDragging == true)
            {
                Control c = sender as Control;
                c.Left += e.X - move.X;
                c.Top += e.Y - move.Y;
            }
        }

        static void c_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }
        #endregion
    }

    public class US_DUNG_CHUNG : US_Object
    {
        public void FillDatasetNhanVienCanInsertHeSo(DataSet op_ds, decimal ip_thang, decimal ip_nam)
        {
            CStoredProc v_cstore = new CStoredProc("pr_lay_danh_sach_nhan_vien_can_insert_he_so");
            v_cstore.addDecimalInputParam("@ip_thang", ip_thang);
            v_cstore.addDecimalInputParam("@ip_nam", ip_nam);
            v_cstore.fillDataSetByCommand(this, op_ds);
        }
        public void XoaDuLieuTrongThang_ATHK_BSL(decimal ip_thang, decimal ip_nam)
        {
            CStoredProc v_cstore = new CStoredProc("pr_xoa_du_lieu_athk_bsl_thang");
            v_cstore.addDecimalInputParam("@ip_thang", ip_thang);
            v_cstore.addDecimalInputParam("@ip_nam", ip_nam);
            v_cstore.ExecuteCommand(this);
        }
        public bool IsDaChotBangLuongThang(decimal ip_i_thang, decimal ip_i_nam)
        {
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            this.FillDatasetWithQuery(v_ds, "select * from gd_chot_bang_luong where thang = " + ip_i_thang.ToString() + "and nam =" + ip_i_nam.ToString());
            if(v_ds.Tables[0].Rows.Count == 0)
            {
                return false;
            }
            else return true;
        }
        public void FillDatasetWithProc(DataSet op_ds, string ip_str_table_name, string ip_str_column_name)
        {
            CStoredProc v_cstore = new CStoredProc("get_data_to_dataset_with_table_name_and_column_name");
            v_cstore.addNVarcharInputParam("@TABLE_NAME", ip_str_table_name);
            v_cstore.addNVarcharInputParam("@COLUMN_NAME", ip_str_column_name);
            v_cstore.fillDataSetByCommand(this, op_ds);
        }

        public void FillDatasetGDChiTietChucVu(DataSet op_ds, DateTime ip_dat)
        {
            CStoredProc v_cstore = new CStoredProc("rpt_tinh_hinh_dao_tao");
            v_cstore.addDatetimeInputParam("@ip_dat_ngay_bao_cao", ip_dat);
            v_cstore.fillDataSetByCommand(this, op_ds);
        }

        internal void FillDatasetCBO(DataSet op_ds, string ip_str_table_name, string ip_str_value_field, string ip_str_display_field, string ip_str_condition)
        {
            CStoredProc v_cstore = new CStoredProc("get_data_for_cbo");
            v_cstore.addNVarcharInputParam("@TABLE_NAME", ip_str_table_name);
            v_cstore.addNVarcharInputParam("@COLUMN_VALUE", ip_str_value_field);
            v_cstore.addNVarcharInputParam("@COLUMN_DISPLAY", ip_str_display_field);
            v_cstore.addNVarcharInputParam("@CONDITION", ip_str_condition);
            v_cstore.fillDataSetByCommand(this, op_ds);
        }

        internal void FillDatasetWithTableName(DataSet op_ds, string ip_str_table_name)
        {
            CStoredProc v_cstore = new CStoredProc("get_data_from_table");
            v_cstore.addNVarcharInputParam("@TABLE_NAME", ip_str_table_name);
            v_cstore.fillDataSetByCommand(this, op_ds);
        }

        internal void FillDatasetWithQuery(DataSet op_ds, string ip_query)
        {
            CStoredProc v_cstore = new CStoredProc("pr_fill_ds_with_query");
            v_cstore.addNVarcharInputParam("@SQL_QUERY", ip_query);
            v_cstore.fillDataSetByCommand(this, op_ds);
        }

        internal void FillDatasetChungChiHetHan(DataSet v_ds, DateTime dateTime)
        {
            CStoredProc v_cstore = new CStoredProc("get_chung_chi_het_han_theo_ngach");
            v_cstore.addDatetimeInputParam("@ngay", dateTime);
            v_cstore.fillDataSetByCommand(this, v_ds);
        }

        internal void FillDatasetSQLInjection(DataSet v_ds, string p)
        {
            CStoredProc v_cstore = new CStoredProc("sqlInjection");
            v_cstore.addNVarcharInputParam("@str_query", p);
            v_cstore.fillDataSetByCommand(this, v_ds);
        }

        public void FillBangLuong(DataSet ip_ds,decimal ip_dc_id_nhan_vien, decimal ip_dc_thang, decimal ip_dc_nam) {
            CStoredProc v_cstore = new CStoredProc("PR_RPT_BANG_LUONG");
            v_cstore.addDecimalInputParam("@ID_NHAN_VIEN", ip_dc_id_nhan_vien);
            v_cstore.addDecimalInputParam("@THANG", ip_dc_thang);
            v_cstore.addDecimalInputParam("@NAM", ip_dc_nam);
            v_cstore.fillDataSetByCommand(this, ip_ds);
        }
        public void FillBangLuongV2(DataSet ip_ds, decimal ip_dc_id_nhan_vien, decimal ip_dc_thang, decimal ip_dc_nam)
        {
            CStoredProc v_cstore = new CStoredProc("PR_RPT_BANG_LUONG_V2");
            v_cstore.addDecimalInputParam("@ID_NHAN_VIEN", ip_dc_id_nhan_vien);
            v_cstore.addDecimalInputParam("@THANG", ip_dc_thang);
            v_cstore.addDecimalInputParam("@NAM", ip_dc_nam);
            v_cstore.fillDataSetByCommand(this, ip_ds);
        }
        public void FillThongTinTongHopNhanVien(DataSet ip_ds, decimal ip_dc_id_nhan_vien, decimal ip_dc_thang, decimal ip_dc_nam)
        {
            CStoredProc v_cstore = new CStoredProc("pr_rpt_lay_thong_tin_tong_hop_1_nhan_vien");
            v_cstore.addDecimalInputParam("@ip_dc_id_nhan_vien", ip_dc_id_nhan_vien);
            v_cstore.addDecimalInputParam("@ip_int_thang", ip_dc_thang);
            v_cstore.addDecimalInputParam("@ip_int_nam", ip_dc_nam);
            v_cstore.fillDataSetByCommand(this, ip_ds);
        }
        public void FillThongTinTongHopNhanVienV2(DataSet ip_ds, decimal ip_dc_id_nhan_vien, decimal ip_dc_thang, decimal ip_dc_nam)
        {
            CStoredProc v_cstore = new CStoredProc("pr_rpt_lay_thong_tin_tong_hop_1_nhan_vien_v2");
            v_cstore.addDecimalInputParam("@ip_dc_id_nhan_vien", ip_dc_id_nhan_vien);
            v_cstore.addDecimalInputParam("@ip_int_thang", ip_dc_thang);
            v_cstore.addDecimalInputParam("@ip_int_nam", ip_dc_nam);
            v_cstore.fillDataSetByCommand(this, ip_ds);
        }
        internal void FillDatasetGDChamCong(DataSet v_ds, DateTime v_dat)
        {
            CStoredProc v_cstore = new CStoredProc("pr_gd_cham_cong");
            v_cstore.addDatetimeInputParam("@ngay_cham_cong", v_dat);
            v_cstore.fillDataSetByCommand(this, v_ds);
        }
        internal void FillDatasetNgayPhepTieuChuan(DataSet v_ds, string ip_nam_tinh_phep, decimal ip_id_nhan_vien)
        {
            CStoredProc v_cstore = new CStoredProc("PR_GET_PHEP_TIEU_CHUAN");
            v_cstore.addNVarcharInputParam("@nam_tinh_phep", ip_nam_tinh_phep);
            v_cstore.addDecimalInputParam("@dc_id_nhan_vien", ip_id_nhan_vien);
            v_cstore.fillDataSetByCommand(this, v_ds);
        }


        public void FillDatasetBaoCaoTangGiamLaoDong(DataSet op_ds, DateTime ip_dat_tu_ngay, DateTime ip_dat_den_ngay)
        {
            CStoredProc v_cstore = new CStoredProc("pr_rpt_tang_giam_lao_dong");
            v_cstore.addDatetimeInputParam("@ip_dat_tu_ngay", ip_dat_tu_ngay);
            v_cstore.addDatetimeInputParam("@ip_dat_den_ngay", ip_dat_den_ngay);
            v_cstore.fillDataSetByCommand(this, op_ds);
        }

        public void FillDatasetChamCong(DataSet op_ds, string thang, string nam, decimal id_nv)
        {
            CStoredProc v_cstore = new CStoredProc("pr_GET_GD_CHAM_CONG");
            v_cstore.addNVarcharInputParam("@thang", thang);
            v_cstore.addNVarcharInputParam("@nam", nam);
            v_cstore.addDecimalInputParam("@id_nhan_vien", id_nv);
            v_cstore.fillDataSetByCommand(this, op_ds);
        }

        internal void get_bang_cham_cong(DataSet v_ds, string ip_str_thang, string ip_str_nam)
        {
            CStoredProc v_cstore = new CStoredProc("pr_GET_DANH_SACH_NHAN_VIEN_CHAM_CONG");
            v_cstore.addDecimalInputParam("@THANG", CIPConvert.ToDecimal(ip_str_thang));
            v_cstore.addDecimalInputParam("@NAM", CIPConvert.ToDecimal(ip_str_nam));
            v_cstore.fillDataSetByCommand(this, v_ds);
        }

        internal void xoa_du_lieu_cham_cong(decimal ip_dc_id_nv, string ip_str_thang, string ip_str_nam)
        {
            CStoredProc v_cstore = new CStoredProc("pr_XOA_DU_LIEU_CHAM_CONG");
            v_cstore.addDecimalInputParam("@ID_NHAN_VIEN", ip_dc_id_nv);
            v_cstore.addDecimalInputParam("@THANG", CIPConvert.ToDecimal(ip_str_thang));
            v_cstore.addDecimalInputParam("@NAM", CIPConvert.ToDecimal(ip_str_nam));
            v_cstore.ExecuteCommand(this);
        }

        internal void filldatasetBaoCaoThuLaoHDQT(DataSet v_ds, string ip_str_thang, string ip_str_nam)
        {
            CStoredProc v_cstore = new CStoredProc("pr_lay_danh_sach_thu_lao_HDQT");
            v_cstore.addNVarcharInputParam("@thang", CIPConvert.ToDecimal(ip_str_thang));
            v_cstore.addNVarcharInputParam("@nam", CIPConvert.ToDecimal(ip_str_nam));
            v_cstore.fillDataSetByCommand(this, v_ds);
        }

        internal void FillDatasetProcBangKeKhaiThuNhap(DataSet v_ds, string ip_str_nam)
        {
            CStoredProc v_cstore = new CStoredProc("pr_bang_ke_khai_thu_nhap");  
            v_cstore.addDecimalInputParam("@nam", CIPConvert.ToDecimal(ip_str_nam));
            v_cstore.fillDataSetByCommand(this, v_ds);
        }

        internal void FillDatasetKeKhaiThueDoubleClick(DataSet v_ds, decimal v_id_nhan_vien, string m_txt_nam)
        {
            CStoredProc v_cstore = new CStoredProc("pr_bang_ke_khai_thu_nhap_detail");
            v_cstore.addDecimalInputParam("@nam", CIPConvert.ToDecimal(m_txt_nam));
            v_cstore.addDecimalInputParam("@id_nhan_vien", v_id_nhan_vien);
            v_cstore.fillDataSetByCommand(this, v_ds);
        }

        internal void FillDatasetProcBaoCaoThuNhapTheoNam(DataSet v_ds, string ip_str_nam)
        {
            CStoredProc v_cstore = new CStoredProc("pr_bao_cao_tong_hop_thu_nhap_theo_nam");
            v_cstore.addDecimalInputParam("@nam", CIPConvert.ToDecimal(ip_str_nam));
            v_cstore.fillDataSetByCommand(this, v_ds);
        }

        internal void FillDatasetBaoCaoThuNhapDoubleClick(DataSet v_ds, decimal v_id_nhan_vien, string m_txt_nam)
        {
            CStoredProc v_cstore = new CStoredProc("pr_bao_cao_tong_hop_thu_nhap_theo_nam_detail");
            v_cstore.addDecimalInputParam("@nam", CIPConvert.ToDecimal(m_txt_nam));
            v_cstore.addDecimalInputParam("@id_nhan_vien", v_id_nhan_vien);
            v_cstore.fillDataSetByCommand(this, v_ds);
        }


        internal void FillDatasetChamCong(DataSet v_ds, string ip_str_thang, string ip_str_nam)
        {
            CStoredProc v_cstore = new CStoredProc("pr_GET_DU_LIEU_CHAM_CONG");
            v_cstore.addDecimalInputParam("@nam", CIPConvert.ToDecimal(ip_str_thang));
            v_cstore.addDecimalInputParam("@nam", CIPConvert.ToDecimal(ip_str_nam));
            v_cstore.fillDataSetByCommand(this, v_ds);
        }
    }

    public class iParameter
    {
        public string ParameterName { get; set; }
        public string ParameterValue { get; set; }

        public iParameter(string ip_name, string ip_value)
        {
            ParameterName = ip_name;
            ParameterValue = ip_value;
        }
    }
    
}
