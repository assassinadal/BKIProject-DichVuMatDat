using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BKI_DichVuMatDat.DS;
using BKI_DichVuMatDat.US;
using BKI_DichVuMatDat.DS.CDBNames;
using IP.Core.IPCommon;
using BKI_DichVuMatDat.COMMON;
using System.Configuration;
using System.Data.OleDb;
using IP.Core.IPSystemAdmin;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraPrinting;
using Microsoft.Office.Interop;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using BKI_DichVuMatDat.BaoCao;

namespace BKI_DichVuMatDat.NghiepVu.NhanSu
{
    public partial class f003_import_he_so_lns : Form
    {

        #region Public Interfaces

        public f003_import_he_so_lns()
        {
            InitializeComponent();
            format_control();
        }

        #endregion

        #region Data Structures
        class ExcelLNS
        {
            public const string STT = "STT";
            public const string MA_NHAN_VIEN = "MA_NHAN_VIEN";
            public const string NGAY_BAT_DAU = "NGAY_BAT_DAU";
            public const string NGAY_KET_THUC = "NGAY_KET_THUC";
            public const string MA_LNS = "MA_LNS";
            public const string MUC_LNS = "MUC_LNS";
        }

        enum thu_tu_cot
        {
            STT = 0,
            MA_NHAN_VIEN = 1,
            MA_LNS = 2,
            MUC_LNS = 3,
            NGAY_BAT_DAU = 4,
            NGAY_KET_THUC = 5,
        }
        #endregion

        #region Members
        DataTable m_dt_ma_lns;
        DataTable m_dt_muc_lns;
        #endregion

        #region Private methods

        private void format_control()
        {
            set_define_event();
            m_grv_cong_tac.BestFitColumns();
            m_grc_cong_tac.ToolTipController = m_tooltip_controller;
            this.WindowState = FormWindowState.Maximized;
        }

        private void format_data_table(DataTable ip_dt_src)
        {
            ip_dt_src.Columns[(int)thu_tu_cot.STT].ColumnName = ExcelLNS.STT;
            ip_dt_src.Columns[(int)thu_tu_cot.MA_NHAN_VIEN].ColumnName = ExcelLNS.MA_NHAN_VIEN;
            ip_dt_src.Columns[(int)thu_tu_cot.MA_LNS].ColumnName = ExcelLNS.MA_LNS;
            ip_dt_src.Columns[(int)thu_tu_cot.MUC_LNS].ColumnName = ExcelLNS.MUC_LNS;
            ip_dt_src.Columns[(int)thu_tu_cot.NGAY_BAT_DAU].ColumnName = ExcelLNS.NGAY_BAT_DAU;
            ip_dt_src.Columns[(int)thu_tu_cot.NGAY_KET_THUC].ColumnName = ExcelLNS.NGAY_KET_THUC;
        }

        #region Validate
        private bool is_not_null(params object[] ip_obj)
        {
            foreach(var item in ip_obj)
            {
                if(item == DBNull.Value || item == null || item.ToString() == "")
                {
                    return false;
                }
            }
            return true;
        }
        private bool ma_nhan_vien_khong_trung_lap(DataRow ip_dr)
        {
            DataTable v_dt_source = (DataTable)m_grc_cong_tac.DataSource;
            var v_str_ma_nhan_vien = ip_dr[ExcelLNS.MA_NHAN_VIEN].ToString();
            var v_count_nv = v_dt_source.AsEnumerable().Count(x => x.Field<string>(ExcelLNS.MA_NHAN_VIEN) == v_str_ma_nhan_vien);
            bool v_bool = v_count_nv == 1;
            if(!v_bool)
            {
                XtraMessageBox.Show("Mã nhân viên " + v_str_ma_nhan_vien + " bị trùng lặp trong File Excel!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return v_bool;
        }
        private bool ma_lns_dung_dinh_dang(DataRow ip_dr)
        {
            var v_str_ma_lns = ip_dr[ExcelLNS.MA_LNS].ToString();
            var v_bool_is_exist = m_dt_ma_lns.AsEnumerable().Any(x => x.Field<string>(CM_DM_TU_DIEN.MA_TU_DIEN) == v_str_ma_lns);
            if(!v_bool_is_exist)
            {
                XtraMessageBox.Show("Mã LNS của nhân viên " + ip_dr[ExcelLNS.MA_NHAN_VIEN].ToString() + " bị sai tên!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return v_bool_is_exist;
        }
        private bool muc_lns_dung_dinh_dang(DataRow ip_dr)
        {
            var v_str_muc_lns = ip_dr[ExcelLNS.MUC_LNS].ToString();
            var v_bool_is_exist = m_dt_muc_lns.AsEnumerable().Any(x => x.Field<string>(CM_DM_TU_DIEN.MA_TU_DIEN) == v_str_muc_lns);
            if(!v_bool_is_exist)
            {
                XtraMessageBox.Show("Mức LNS của nhân viên " + ip_dr[ExcelLNS.MA_NHAN_VIEN].ToString() + " bị sai tên!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return v_bool_is_exist;
        }
        private bool check_not_null(DataRow ip_dr)
        {
            var v_bool_is_null = is_not_null(ip_dr[ExcelLNS.MA_NHAN_VIEN]
                                            , ip_dr[ExcelLNS.MA_LNS]
                                            , ip_dr[ExcelLNS.MUC_LNS]
                                            , ip_dr[ExcelLNS.NGAY_BAT_DAU]
                                            );
            if(!v_bool_is_null)
            {
                if(!is_not_null(ip_dr[ExcelLNS.MA_NHAN_VIEN]))
                {
                    XtraMessageBox.Show("Có mã nhân viên bị trống!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    XtraMessageBox.Show("Dữ liệu của nhân viên " + ip_dr[ExcelLNS.MA_NHAN_VIEN].ToString() + " có ô bị trống!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            return v_bool_is_null;
        }
        private bool ngay_bat_dau_nho_hon_ngay_ket_thuc(DataRow ip_dr)
        {
            if(ip_dr[ExcelLNS.NGAY_KET_THUC] == DBNull.Value || ip_dr[ExcelLNS.NGAY_KET_THUC].ToString() == "")
            {
                return true;
            }
            DateTime v_dat_ngay_bat_dau = Convert.ToDateTime(ip_dr[ExcelLNS.NGAY_BAT_DAU]);
            DateTime v_dat_ngay_ket_thuc = Convert.ToDateTime(ip_dr[ExcelLNS.NGAY_KET_THUC]);
            if(v_dat_ngay_bat_dau.Date >= v_dat_ngay_ket_thuc.Date)
            {
                XtraMessageBox.Show("Dòng nhân viên " + ip_dr[ExcelLNS.MA_NHAN_VIEN].ToString() + " ngày bắt đầu phải nhỏ hơn ngày kết thúc!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private bool check_client_one_row(DataRow ip_dr)
        {
            if(!check_not_null(ip_dr))
            {
                return false;
            }
            if(!ma_nhan_vien_khong_trung_lap(ip_dr)
                    || !muc_lns_dung_dinh_dang(ip_dr)
                    || !ma_lns_dung_dinh_dang(ip_dr)
                    || !ngay_bat_dau_nho_hon_ngay_ket_thuc(ip_dr)
                )
            {
                return false;
            }
            return true;
        }

        private bool check_ma_nhan_vien_ton_tai(DataRow ip_dr)
        {
            US_DM_NHAN_VIEN v_us = new US_DM_NHAN_VIEN();
            var is_exist = v_us.IsExistNhanVienInDB(ip_dr[ExcelLNS.MA_NHAN_VIEN].ToString());
            if(!is_exist)
            {
                XtraMessageBox.Show("Mã nhân viên " + ip_dr[ExcelLNS.MA_NHAN_VIEN].ToString() + " chưa tồn tại trong hệ thống!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return is_exist;
        }
        private bool check_thoi_gian_he_so_lns_Insert(DataRow ip_dr)
        {
            //Hợp đồng hợp lệ khi trong một khoảng thời gian chỉ có một hợp đồng 
            US_GD_HE_SO_LNS v_us = new US_GD_HE_SO_LNS();
            var v_dc_id_nhan_vien = ExecuteFuntion.LayNhanVienID(ip_dr[ExcelLNS.MA_NHAN_VIEN].ToString());
            var v_dat_ngay_bat_dau = Convert.ToDateTime(ip_dr[ExcelLNS.NGAY_BAT_DAU]).Date;
            var v_dat_ngay_ket_thuc = ip_dr[ExcelLNS.NGAY_KET_THUC] == DBNull.Value ? new DateTime(2100, 01, 01).Date : Convert.ToDateTime(ip_dr[ExcelLNS.NGAY_KET_THUC]);
            var v_bool_hop_le = v_us.KiemTraThoiGianHeSoLNSHopLeForInsert(v_dc_id_nhan_vien, v_dat_ngay_bat_dau, v_dat_ngay_ket_thuc);
            if(!v_bool_hop_le)
            {
                XtraMessageBox.Show("Thời gian hiệu lực hệ số LNS của nhân viên " + ip_dr[ExcelLNS.MA_NHAN_VIEN].ToString() + " không hợp lệ " +
                                        "do đã có hiệu lực hệ số LNS khác tồn tại trong khoảng thời gian này!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return v_bool_hop_le;
        }
        private bool check_thoi_gian_voi_luong_cung_Insert(DataRow ip_dr)
        {
            US_GD_HE_SO_LNS v_us_check = new US_GD_HE_SO_LNS();
            decimal v_dc_id_nhan_vien = find_id_nv_by_ma_nv(ip_dr[ExcelLNS.MA_NHAN_VIEN].ToString());
            var v_dat_ngay_bat_dau = Convert.ToDateTime(ip_dr[ExcelLNS.NGAY_BAT_DAU]).Date;
            var v_dat_ngay_ket_thuc = ip_dr[ExcelLNS.NGAY_KET_THUC] == DBNull.Value ? new DateTime(2100, 01, 01).Date : Convert.ToDateTime(ip_dr[ExcelLNS.NGAY_KET_THUC]);
            if(!v_us_check.KiemTraThoiGianVoiLuongCungHopLeForInsert(v_dc_id_nhan_vien, v_dat_ngay_bat_dau, v_dat_ngay_ket_thuc))
            {
                string v_str_error = "Trong hệ thống, đã tồn tại bản ghi LƯƠNG CỨNG của nhân viên "+ip_dr[ExcelLNS.MA_NHAN_VIEN].ToString()+" có hiệu lực trong khoảng thời gian này rồi!!";
                XtraMessageBox.Show(v_str_error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private bool check_logic_one_row(DataRow ip_dr)
        {
            if(!check_ma_nhan_vien_ton_tai(ip_dr)
                || !check_thoi_gian_he_so_lns_Insert(ip_dr)
                || !check_thoi_gian_voi_luong_cung_Insert(ip_dr)
                )
            {
                return false;
            }
            return true;
        }

        private bool check_all_is_ok()
        {
            for(int v_i_cur_row = 0; v_i_cur_row < m_grv_cong_tac.RowCount; v_i_cur_row++)
            {
                var v_dr_cur_row = m_grv_cong_tac.GetDataRow(v_i_cur_row);
                if(!check_client_one_row(v_dr_cur_row) || !check_logic_one_row(v_dr_cur_row))
                {
                    return false;
                }
            }
            return true;
        }
        #endregion

        #region Transfer Data
        private void init_data()
        {
            m_dt_muc_lns = load_data_from_tu_dien(CONST_ID_LOAI_TU_DIEN.MUC_HS_LNS);
            m_dt_ma_lns = load_data_from_tu_dien(CONST_ID_LOAI_TU_DIEN.MA_HS_LNS);
        }
        private DataTable load_data_to_ma_nv()
        {
            US_DM_NHAN_VIEN v_us = new US_DM_NHAN_VIEN();
            DS_DM_NHAN_VIEN v_ds_nhan_vien = new DS_DM_NHAN_VIEN();
            v_us.FillDataset(v_ds_nhan_vien);
            return v_ds_nhan_vien.Tables[0];
        }
        private DataTable load_data_from_tu_dien(decimal id_loai_tu_dien)
        {
            US_CM_DM_TU_DIEN v_us = new US_CM_DM_TU_DIEN();
            DS_CM_DM_TU_DIEN v_ds = new DS_CM_DM_TU_DIEN();
            v_us.FillDataset(v_ds, "WHERE ID_LOAI_TU_DIEN = " + id_loai_tu_dien);
            return v_ds.Tables[0];
        }

        #endregion

        #region  ID Query
        private decimal find_id_nv_by_ma_nv(string v)
        {
            try
            {
                US_DM_NHAN_VIEN v_us = new US_DM_NHAN_VIEN();
                DS_DM_NHAN_VIEN v_ds = new DS_DM_NHAN_VIEN();
                v_us.FillDataset(v_ds, "WHERE MA_NV = " + v);
                string v_str_filter = "MA_NV = " + v;
                DataRow[] v_dr = v_ds.DM_NHAN_VIEN.Select(v_str_filter);

                if(v_dr.Count() == 0)
                {
                    return -1;
                }
                else
                {
                    return CIPConvert.ToDecimal(v_dr.First()["ID"].ToString());
                }
            }
            catch(Exception)
            {
                throw new Exception("Chưa có nhân viên. Vui lòng nhập nhân viên trước");
            }
        }
        private decimal find_id_tu_dien_by_ma_tu_dien(string ma_tu_dien)
        {
            try
            {
                US_CM_DM_TU_DIEN v_us = new US_CM_DM_TU_DIEN();
                DS_CM_DM_TU_DIEN v_ds = new DS_CM_DM_TU_DIEN();
                v_us.FillDataset(v_ds);
                decimal id = (from DataRow dr in v_ds.Tables[0].Rows
                              where (string)dr["MA_TU_DIEN"] == ma_tu_dien
                              select (decimal)dr["ID"]).FirstOrDefault();
                return id;
            }
            catch(Exception v_e)
            {
                throw v_e;
            }
        }
        private decimal find_so_tien_lcd(decimal id_lcd)
        {
            US_DM_LUONG_CHE_DO v_us = new US_DM_LUONG_CHE_DO(id_lcd);
            return v_us.dcSO_TIEN;
        }

        private decimal find_id_don_vi(string ma_dv)
        {
            decimal id = (from DataRow dr in m_dt_ma_lns.Rows
                          where (string)dr["MA_DON_VI"] == ma_dv
                          select (decimal)dr["ID"]).FirstOrDefault();
            return id;
        }
        private decimal find_id_chuc_vu(string ma_chuc_vu)
        {
            decimal id = (from DataRow dr in m_dt_muc_lns.Rows
                          where (string)dr["MA_CHUC_VU"] == ma_chuc_vu
                          select (decimal)dr["ID"]).FirstOrDefault();
            return id;
        }

        #endregion

        #region Action
        private DataTable load_data_from_file_to_data_table(string ip_str_path, string ip_name_sheet_import)
        {
            string conStr = "";
            string SheetName = ip_name_sheet_import + "$";
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
                //string SheetName = ExcelDataSet.Rows[0]["TABLE_NAME"].ToString(); // get sheetname
                ExcelCommand.CommandText = "SELECT * From [" + SheetName + "]";// WHERE [" + ExcelLNS.MA_NHAN_VIEN + "] IS NOT NULL";
                OleDbDataAdapter ExcelAdapter = new OleDbDataAdapter(ExcelCommand);
                ExcelAdapter.SelectCommand = ExcelCommand;
                ExcelAdapter.Fill(dt);
            }
            con.Close();
            DataTable v_dt_result = dt.Rows.Cast<DataRow>().Where(row => !row.ItemArray.All(field => field is System.DBNull || string.IsNullOrEmpty(field.ToString()) == true)).CopyToDataTable();
            return v_dt_result;
        }
        private void set_init_form_load()
        {
            //m_cmd_save.Enabled = false;
            //m_cmd_xuat_excel.Enabled = false;
            init_data();
        }
        private void load_data_from_file_to_grid(string path)
        {
            SplashScreenManager.ShowForm(typeof(F_wait_form));
            try
            {
                var v_data_table_grv = load_data_from_file_to_data_table(path, "NHAP_HE_SO_LNS");
                format_data_table(v_data_table_grv);
                m_grc_cong_tac.DataSource = v_data_table_grv;
                m_grv_cong_tac.BestFitColumns();
            }
            catch(Exception v_e)
            {
                throw;
            }
            finally
            {
                SplashScreenManager.CloseForm();
            }
        }
        private decimal find_he_so_lns_by_id(decimal dcID_HE_SO_LNS)
        {
            US_DM_HE_SO_LUONG_NS v_us = new US_DM_HE_SO_LUONG_NS(dcID_HE_SO_LNS);
            return v_us.dcHE_SO;
        }

        private decimal find_id_hs_lns_by_ma_muc(string ma_lns, string muc_lns)
        {
            try
            {
                decimal id_ma_lns = (from DataRow dr in m_dt_ma_lns.Rows
                                     where (string)dr[CM_DM_TU_DIEN.MA_TU_DIEN] == ma_lns
                                     select (decimal)dr[CM_DM_TU_DIEN.ID]).FirstOrDefault();
                decimal id_muc_lns = (from DataRow dr in m_dt_muc_lns.Rows
                                      where (string)dr[CM_DM_TU_DIEN.MA_TU_DIEN] == muc_lns
                                      select (decimal)dr[CM_DM_TU_DIEN.ID]).FirstOrDefault();
                US_DM_HE_SO_LUONG_NS v_us = new US_DM_HE_SO_LUONG_NS();
                DS_DM_HE_SO_LUONG_NS v_ds = new DS_DM_HE_SO_LUONG_NS();
                v_us.FillDataset(v_ds);
                decimal id_lns = (from DataRow dr in v_ds.Tables[0].Rows
                                  where (decimal)dr["ID_MA_LNS"] == id_ma_lns & (decimal)dr["ID_MUC_LNS"] == id_muc_lns
                                  select (decimal)dr["ID"]).FirstOrDefault();

                return id_lns;
            }
            catch(Exception v_e)
            {
                throw v_e;
            }
        }
        private void grid_to_us_gd_cong_tac(US_GD_HE_SO_LNS v_us_gd_ct, DataRow data)
        {
            v_us_gd_ct.dcID_NHAN_VIEN = find_id_nv_by_ma_nv(data[ExcelLNS.MA_NHAN_VIEN].ToString());
            v_us_gd_ct.dcID_HE_SO_LNS = find_id_hs_lns_by_ma_muc(data[ExcelLNS.MA_LNS].ToString(), data[ExcelLNS.MUC_LNS].ToString());
            v_us_gd_ct.dcHE_SO = find_he_so_lns_by_id(v_us_gd_ct.dcID_HE_SO_LNS);

            v_us_gd_ct.strNGUOI_LAP = CAppContext_201.getCurrentUserName();
            v_us_gd_ct.datNGAY_BAT_DAU = WinFormControls.FormatPostingDate(data[ExcelLNS.NGAY_BAT_DAU].ToString());
            if(String.IsNullOrEmpty(data[ExcelLNS.NGAY_KET_THUC].ToString()))
            {
                v_us_gd_ct.SetNGAY_KET_THUCNull();
            }
            else
            {
                v_us_gd_ct.datNGAY_KET_THUC = WinFormControls.FormatPostingDate(data[ExcelLNS.NGAY_KET_THUC].ToString());
            }
            v_us_gd_ct.datNGAY_LAP = DateTime.Now.Date;
        }

        private void save_data()
        {
            if(m_grv_cong_tac.RowCount < 1)
            {
                XtraMessageBox.Show("Chưa có dữ liệu để lưu!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(!check_all_is_ok())
            {
                return;
            }
            SplashScreenManager.ShowForm(this, typeof(SplashScreen1), true, true, false);
            US_GD_HE_SO_LNS v_us_gd_ct = new US_GD_HE_SO_LNS();
            try
            {

                v_us_gd_ct.BeginTransaction();
                for(int i = 0; i < m_grv_cong_tac.RowCount; i++)
                {
                    v_us_gd_ct.ClearAllFields();
                    var data = m_grv_cong_tac.GetDataRow(i);
                    grid_to_us_gd_cong_tac(v_us_gd_ct, data);
                    v_us_gd_ct.Insert();
                    SplashScreenManager.Default.SendCommand(SplashScreen1.SplashScreenCommand.SetProgress, (int)((decimal)i / (decimal)m_grv_cong_tac.RowCount * 100));
                }
                v_us_gd_ct.CommitTransaction();
                CHRM_BaseMessages.MsgBox_Infor("Đã lưu dữ liệu thành công");
            }
            catch(Exception)
            {
                if(v_us_gd_ct.is_having_transaction())
                {
                    v_us_gd_ct.Rollback();
                }
                throw;
            }
            finally
            {
                SplashScreenManager.CloseForm(false);
            }
        }
        private void xuat_excel()
        {
            XlsExportOptions opt = new XlsExportOptions();
            opt.SheetName = "NHAP_HE_SO_LNS";
            opt.TextExportMode = TextExportMode.Value;
            string path = WinFormControls.saveFileDialog("NHAP_HE_SO_LNS");
            if(!String.IsNullOrEmpty(path))
            {
                m_grv_cong_tac.ExportToXls(path, opt);
                var excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = true;
                Microsoft.Office.Interop.Excel.Workbooks books = excel.Workbooks;
                Microsoft.Office.Interop.Excel.Workbook openexcel = books.Open(path);
            }
        }
        #endregion

        #endregion

        #region Event Handlers
        private void set_define_event()
        {
            this.Load += F001_import_hop_dong_Load;
            m_cmd_chon_file.Click += M_cmd_chon_file_Click;
            m_cmd_tai_file_mau.Click += M_cmd_tai_file_mau_Click;
            m_cmd_save.Click += M_cmd_save_Click;
            m_cmd_xuat_excel.Click += M_cmd_xuat_excel_Click;
        }
        private void M_cmd_xuat_excel_Click(object sender, EventArgs e)
        {
            try
            {
                m_lbl_thong_bao.Text = "File sẽ mở lên ngay sau đây";
                m_lbl_thong_bao.ForeColor = Color.Green;
                xuat_excel();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void M_cmd_save_Click(object sender, EventArgs e)
        {
            try
            {
                if(CHRM_BaseMessages.MsgBox_Confirm("Bạn có chắc chắn muốn lưu dữ liệu trên?"))
                {
                    //m_lbl_thong_bao.Text = "Đang lưu dữ liệu...";
                    //m_lbl_thong_bao.ForeColor = Color.Green;
                    save_data();
                    //m_lbl_thong_bao.Text = "Đã lưu dữ liệu thành công!";
                    //m_lbl_thong_bao.ForeColor = Color.Green;
                }
            }
            catch(Exception v_e)
            {
                XtraMessageBox.Show("Có lỗi xảy ra, dữ liệu chưa được lưu. Bạn xem lại dữ liệu trên File Excel nhé", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void M_cmd_tai_file_mau_Click(object sender, EventArgs e)
        {
            try
            {
                m_lbl_thong_bao.Text = "File sẽ mở lên ngay sau đây";
                m_lbl_thong_bao.ForeColor = Color.Green;
                WinFormControls.openTemplate_v2(CONST_EXCEL_TEMPLATE.HE_SO_LNS_TEMPLATE);
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void M_cmd_chon_file_Click(object sender, EventArgs e)
        {
            try
            {
                m_lbl_thong_bao.Text = "Đang đọc dữ liệu từ file...";
                m_lbl_thong_bao.ForeColor = Color.Green;

                OpenFileDialog opf = new OpenFileDialog();
                opf.Filter = "Office Files|*.xlsx;*.xls;";
                opf.Multiselect = false;
                if(opf.ShowDialog() == DialogResult.OK)
                {
                    if(String.IsNullOrEmpty(opf.FileName))
                    {
                        return;
                    }
                    load_data_from_file_to_grid(opf.FileName);
                }
                else
                {
                    m_lbl_thong_bao.Text = "";
                    m_grc_cong_tac.Refresh();
                    return;
                }
            }
            catch(Exception v_e)
            {
                XtraMessageBox.Show("Không lấy dữ liệu được từ File Excel Import. Bạn kiểm tra lại File Excel Import nhé!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void F001_import_hop_dong_Load(object sender, EventArgs e)
        {
            try
            {
                set_init_form_load();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        #endregion
    }
}
