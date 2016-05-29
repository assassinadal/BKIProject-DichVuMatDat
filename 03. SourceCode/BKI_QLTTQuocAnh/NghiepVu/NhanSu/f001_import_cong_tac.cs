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
    public partial class f001_import_cong_tac : Form
    {

        #region Public Interfaces

        public f001_import_cong_tac()
        {
            InitializeComponent();
            format_control();
        }

        #endregion

        #region Data Structures
        class ExcelCongTac
        {
            public const string STT = "STT";
            public const string MA_NHAN_VIEN = "MA_NHAN_VIEN";
            public const string LOAI_CONG_TAC = "LOAI_CONG_TAC";
            public const string NGAY_BAT_DAU = "NGAY_BAT_DAU";
            public const string NGAY_KET_THUC = "NGAY_KET_THUC";
            public const string MA_DON_VI = "MA_DON_VI";
            public const string MA_CHUC_VU = "MA_CHUC_VU";
        }

        enum thu_tu_cot
        {
            STT = 0,
            MA_NHAN_VIEN = 1,
            LOAI_CONG_TAC = 2,
            NGAY_BAT_DAU = 3,
            NGAY_KET_THUC = 4,
            MA_DON_VI = 5,
            MA_CHUC_VU = 6,
        }
        #endregion

        #region Members
        DataTable m_dt_loai_cong_tac;
        DataTable m_dt_don_vi;
        DataTable m_dt_chuc_vu;
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
            ip_dt_src.Columns[(int)thu_tu_cot.STT].ColumnName = ExcelCongTac.STT;
            ip_dt_src.Columns[(int)thu_tu_cot.MA_NHAN_VIEN].ColumnName = ExcelCongTac.MA_NHAN_VIEN;
            ip_dt_src.Columns[(int)thu_tu_cot.LOAI_CONG_TAC].ColumnName = ExcelCongTac.LOAI_CONG_TAC;
            ip_dt_src.Columns[(int)thu_tu_cot.MA_DON_VI].ColumnName = ExcelCongTac.MA_DON_VI;
            ip_dt_src.Columns[(int)thu_tu_cot.MA_CHUC_VU].ColumnName = ExcelCongTac.MA_CHUC_VU;
            ip_dt_src.Columns[(int)thu_tu_cot.NGAY_BAT_DAU].ColumnName = ExcelCongTac.NGAY_BAT_DAU;
            ip_dt_src.Columns[(int)thu_tu_cot.NGAY_KET_THUC].ColumnName = ExcelCongTac.NGAY_KET_THUC;
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
            var v_str_ma_nhan_vien = ip_dr[ExcelCongTac.MA_NHAN_VIEN].ToString();
            var v_count_nv = v_dt_source.AsEnumerable().Count(x => x.Field<string>(ExcelCongTac.MA_NHAN_VIEN) == v_str_ma_nhan_vien);
            bool v_bool = v_count_nv == 1;
            if(!v_bool)
            {
                XtraMessageBox.Show("Mã nhân viên " + v_str_ma_nhan_vien + " bị trùng lặp trong File Excel!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return v_bool;
        }
        private bool ma_chuc_vu_dung_dinh_dang(DataRow ip_dr)
        {
            var v_str_ma_chuc_vu = ip_dr[ExcelCongTac.MA_CHUC_VU].ToString();
            var v_bool_is_exist = m_dt_chuc_vu.AsEnumerable().Any(x => x.Field<string>(DM_CHUC_VU.MA_CHUC_VU) == v_str_ma_chuc_vu);
            if(!v_bool_is_exist)
            {
                XtraMessageBox.Show("Mã chức vụ của nhân viên " + ip_dr[ExcelCongTac.MA_NHAN_VIEN].ToString() + " bị sai tên!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return v_bool_is_exist;
        }
        private bool ma_don_vi_dung_dinh_dang(DataRow ip_dr)
        {
            var v_str_ma_don_vi = ip_dr[ExcelCongTac.MA_DON_VI].ToString();
            var v_bool_is_exist = m_dt_don_vi.AsEnumerable().Any(x => x.Field<string>(DM_DON_VI.MA_DON_VI) == v_str_ma_don_vi);
            if(!v_bool_is_exist)
            {
                XtraMessageBox.Show("Mã đơn vị của nhân viên " + ip_dr[ExcelCongTac.MA_NHAN_VIEN].ToString() + " bị sai tên!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return v_bool_is_exist;
        }
        private bool ma_loai_cong_tac_dung_dinh_dang(DataRow ip_dr)
        {
            var v_str_ma_loai_lao_dong = ip_dr[ExcelCongTac.LOAI_CONG_TAC].ToString();
            var v_bool_is_exist = m_dt_loai_cong_tac.AsEnumerable().Any(x => x.Field<string>(CM_DM_TU_DIEN.MA_TU_DIEN) == v_str_ma_loai_lao_dong);
            if(!v_bool_is_exist)
            {
                XtraMessageBox.Show("Mã loại công tác của nhân viên " + ip_dr[ExcelCongTac.MA_NHAN_VIEN].ToString() + " bị sai tên!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return v_bool_is_exist;
        }
        private bool check_not_null(DataRow ip_dr)
        {
            var v_bool_is_null = is_not_null(ip_dr[ExcelCongTac.MA_NHAN_VIEN]
                                            , ip_dr[ExcelCongTac.LOAI_CONG_TAC]
                                            , ip_dr[ExcelCongTac.NGAY_BAT_DAU]
                                            , ip_dr[ExcelCongTac.MA_DON_VI]
                                            , ip_dr[ExcelCongTac.MA_CHUC_VU]
                                            );
            if(!v_bool_is_null)
            {
                if(!is_not_null(ip_dr[ExcelCongTac.MA_NHAN_VIEN]))
                {
                    XtraMessageBox.Show("Có mã nhân viên bị trống!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    XtraMessageBox.Show("Dữ liệu của nhân viên " + ip_dr[ExcelCongTac.MA_NHAN_VIEN].ToString() + " có ô bị trống!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
            return v_bool_is_null;
        }
        private bool ngay_bat_dau_nho_hon_ngay_ket_thuc(DataRow ip_dr)
        {
            if(ip_dr[ExcelCongTac.NGAY_KET_THUC] == DBNull.Value || ip_dr[ExcelCongTac.NGAY_KET_THUC].ToString() == "")
            {
                return true;
            }
            DateTime v_dat_ngay_bat_dau = Convert.ToDateTime(ip_dr[ExcelCongTac.NGAY_BAT_DAU]);
            DateTime v_dat_ngay_ket_thuc = Convert.ToDateTime(ip_dr[ExcelCongTac.NGAY_KET_THUC]);
            if(v_dat_ngay_bat_dau.Date >= v_dat_ngay_ket_thuc.Date)
            {
                XtraMessageBox.Show("Dòng nhân viên " + ip_dr[ExcelCongTac.MA_NHAN_VIEN].ToString() + " ngày bắt đầu phải nhỏ hơn ngày kết thúc!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private bool check_chuc_vu_thuoc_don_vi(DataRow ip_dr)
        {
            var v_str_ma_chuc_vu = ip_dr[ExcelCongTac.MA_CHUC_VU].ToString();
            var v_dc_id_don_vi = find_id_don_vi(ip_dr[ExcelCongTac.MA_DON_VI].ToString());
            DataRow v_dt_row_chuc_vu = m_dt_chuc_vu.AsEnumerable().Where(x => x.Field<string>(DM_CHUC_VU.MA_CHUC_VU) == v_str_ma_chuc_vu).FirstOrDefault();
            if(Convert.ToDecimal(v_dt_row_chuc_vu[DM_CHUC_VU.ID_DON_VI]) != v_dc_id_don_vi)
            {
                XtraMessageBox.Show("Dòng nhân viên " + ip_dr[ExcelCongTac.MA_NHAN_VIEN].ToString() + " có chức vụ không thuộc đơn vị. Bạn kiểm tra lại nhé!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if(!ma_loai_cong_tac_dung_dinh_dang(ip_dr)
                    || !ma_nhan_vien_khong_trung_lap(ip_dr)
                    || !ma_don_vi_dung_dinh_dang(ip_dr)
                    || !ma_chuc_vu_dung_dinh_dang(ip_dr)
                    || !ngay_bat_dau_nho_hon_ngay_ket_thuc(ip_dr)
                    || !check_chuc_vu_thuoc_don_vi(ip_dr)
                )
            {
                return false;
            }
            return true;
        }

        private bool check_ma_nhan_vien_ton_tai(DataRow ip_dr)
        {
            US_DM_NHAN_VIEN v_us = new US_DM_NHAN_VIEN();
            var is_exist = v_us.IsExistNhanVienInDB(ip_dr[ExcelCongTac.MA_NHAN_VIEN].ToString());
            if(!is_exist)
            {
                XtraMessageBox.Show("Mã nhân viên " + ip_dr[ExcelCongTac.MA_NHAN_VIEN].ToString() + " chưa tồn tại trong hệ thống!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return is_exist;
        }
        private bool check_thoi_gian_cong_tac_Insert(DataRow ip_dr)
        {
            //Hợp đồng hợp lệ khi trong một khoảng thời gian chỉ có một hợp đồng 
            US_GD_CONG_TAC v_us = new US_GD_CONG_TAC();
            var v_dc_id_nhan_vien = ExecuteFuntion.LayNhanVienID(ip_dr[ExcelCongTac.MA_NHAN_VIEN].ToString());
            var v_dc_id_loai_cong_tac = find_id_tu_dien_by_ma_tu_dien(ip_dr[ExcelCongTac.LOAI_CONG_TAC].ToString());
            var v_dat_ngay_bat_dau = Convert.ToDateTime(ip_dr[ExcelCongTac.NGAY_BAT_DAU]).Date;
            var v_dat_ngay_ket_thuc = ip_dr[ExcelCongTac.NGAY_KET_THUC] == DBNull.Value ? new DateTime(2100, 01, 01).Date : Convert.ToDateTime(ip_dr[ExcelCongTac.NGAY_KET_THUC]);
            var v_bool_hop_le = v_us.KiemTraDuLieuCongTacHopLeForInsert(v_dc_id_nhan_vien,v_dc_id_loai_cong_tac, v_dat_ngay_bat_dau, v_dat_ngay_ket_thuc);
            if(!v_bool_hop_le)
            {
                XtraMessageBox.Show("Thời gian công tác của nhân viên " + ip_dr[ExcelCongTac.MA_NHAN_VIEN].ToString() + " không hợp lệ " +
                                        "do đã có công tác tồn tại trong khoảng thời gian này rồi", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return v_bool_hop_le;
        }
        private bool check_logic_one_row(DataRow ip_dr)
        {
            if(!check_ma_nhan_vien_ton_tai(ip_dr)
                || !check_thoi_gian_cong_tac_Insert(ip_dr)
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
            m_dt_chuc_vu = load_data_to_chuc_vu();
            m_dt_don_vi = load_data_to_don_vi();
            m_dt_loai_cong_tac = load_data_from_tu_dien(CONST_ID_LOAI_TU_DIEN.LOAI_CONG_TAC);
        }
        private DataTable load_data_to_chuc_vu()
        {
            US_DM_CHUC_VU v_us = new US_DM_CHUC_VU();
            DS_DM_CHUC_VU v_ds = new DS_DM_CHUC_VU();
            v_us.FillDataset(v_ds);
            return v_ds.Tables[0];
        }
        private DataTable load_data_to_don_vi()
        {
            US_DM_DON_VI v_us = new US_DM_DON_VI();
            DS_DM_DON_VI v_ds = new DS_DM_DON_VI();
            v_us.FillDataset(v_ds);
            return v_ds.Tables[0];
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
            decimal id = (from DataRow dr in m_dt_don_vi.Rows
                          where (string)dr["MA_DON_VI"] == ma_dv
                          select (decimal)dr["ID"]).FirstOrDefault();
            return id;
        }
        private decimal find_id_chuc_vu(string ma_chuc_vu)
        {
            decimal id = (from DataRow dr in m_dt_chuc_vu.Rows
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
                ExcelCommand.CommandText = "SELECT * From [" + SheetName + "]"; //WHERE [" + ExcelCongTac.MA_NHAN_VIEN + "] IS NOT NULL";
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
                var v_data_table_grv = load_data_from_file_to_data_table(path, "NHAP_CONG_TAC");
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
        private void grid_to_us_gd_cong_tac(US_GD_CONG_TAC v_us_gd_ct, DataRow data)
        {
            v_us_gd_ct.dcID_NHAN_VIEN = find_id_nv_by_ma_nv(data[ExcelCongTac.MA_NHAN_VIEN].ToString());
            v_us_gd_ct.dcID_LOAI_CONG_TAC = find_id_tu_dien_by_ma_tu_dien(data[ExcelCongTac.LOAI_CONG_TAC].ToString());
            v_us_gd_ct.dcID_VI_TRI = find_id_chuc_vu(data[ExcelCongTac.MA_CHUC_VU].ToString());
            v_us_gd_ct.dcID_DON_VI = find_id_don_vi(data[ExcelCongTac.MA_DON_VI].ToString());

            v_us_gd_ct.strNGUOI_LAP = CAppContext_201.getCurrentUserName();
            v_us_gd_ct.datNGAY_BAT_DAU = WinFormControls.FormatPostingDate(data[ExcelCongTac.NGAY_BAT_DAU].ToString());
            if(String.IsNullOrEmpty(data[ExcelCongTac.NGAY_KET_THUC].ToString()))
            {
                v_us_gd_ct.SetNGAY_KET_THUCNull();
            }
            else
            {
                v_us_gd_ct.datNGAY_KET_THUC = WinFormControls.FormatPostingDate(data[ExcelCongTac.NGAY_KET_THUC].ToString());
            }
            v_us_gd_ct.datNGAY_LAP = DateTime.Now.Date;
            v_us_gd_ct.strDA_XOA = "N";
            v_us_gd_ct.dcSO_HO_SO = ExecuteFuntion.GetSoHoSoNext(v_us_gd_ct.dcID_DON_VI, v_us_gd_ct.dcID_VI_TRI, v_us_gd_ct.dcID_NHAN_VIEN);
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
            US_GD_CONG_TAC v_us_gd_ct = new US_GD_CONG_TAC();
            int v_i_row = 0;
            try
            {

                for(v_i_row = 0; v_i_row < m_grv_cong_tac.RowCount; v_i_row++)
                {
                    v_us_gd_ct.BeginTransaction();
                    v_us_gd_ct.ClearAllFields();
                    var data = m_grv_cong_tac.GetDataRow(v_i_row);
                    grid_to_us_gd_cong_tac(v_us_gd_ct, data);
                    v_us_gd_ct.Insert();
                    v_us_gd_ct.CommitTransaction();
                    SplashScreenManager.Default.SendCommand(SplashScreen1.SplashScreenCommand.SetProgress, (int)((decimal)v_i_row / (decimal)m_grv_cong_tac.RowCount * 100));
                }
                
                //Sau do phai cap nhat lai so ho so, chua biet lam
                
                CHRM_BaseMessages.MsgBox_Infor("Đã lưu dữ liệu thành công");
            }
            catch(Exception)
            {
                if(v_us_gd_ct.is_having_transaction())
                {
                    v_us_gd_ct.Rollback();
                }
                if(v_i_row >= 1)
                {
                    throw new Exception("Có lỗi xảy ra. Dữ liệu lưu chưa thành công!\nĐã lưu thành công đến dòng thứ " + v_i_row + " với mã nhân viên " + m_grv_cong_tac.GetRowCellValue(v_i_row - 1, ExcelCongTac.MA_NHAN_VIEN).ToString());
                }
                else
                {
                    throw new Exception("Có lỗi xảy ra. Dữ liệu lưu chưa được lưu!");
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
            opt.SheetName = "NHAP_CONG_TAC";
            opt.TextExportMode = TextExportMode.Value;
            string path = WinFormControls.saveFileDialog("CONG_TAC");
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
                XtraMessageBox.Show(v_e.Message, "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void M_cmd_tai_file_mau_Click(object sender, EventArgs e)
        {
            try
            {
                m_lbl_thong_bao.Text = "File sẽ mở lên ngay sau đây";
                m_lbl_thong_bao.ForeColor = Color.Green;
                WinFormControls.openTemplate_v2(CONST_EXCEL_TEMPLATE.CONG_TAC_TEMPLATE);
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
