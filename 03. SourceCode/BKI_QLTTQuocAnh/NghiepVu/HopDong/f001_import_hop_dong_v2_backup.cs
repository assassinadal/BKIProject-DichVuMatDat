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

namespace BKI_DichVuMatDat.NghiepVu.HopDong
{
    public partial class f001_import_hop_dong_v2_backup : Form
    {

        #region Public Interfaces

        public f001_import_hop_dong_v2_backup()
        {
            InitializeComponent();
            format_control();
        }

        #endregion

        #region Data Structures
        class ExcelHopDong
        {
            public const string STT = "STT";
            public const string MA_NHAN_VIEN = "MA_NHAN_VIEN";
            public const string MA_HOP_DONG = "MA_HOP_DONG";
            public const string MA_LOAI_HOP_DONG = "MA_LOAI_HOP_DONG";
            public const string MA_CHUC_DANH_LCD = "MA_CHUC_DANH_LCD";
            public const string MA_MUC_LCD = "MA_MUC_LCD";
            public const string MA_CHUC_DANH_LNS = "MA_CHUC_DANH_LNS";
            public const string MA_MUC_LUONG_NS = "MA_MUC_LUONG_NS";
            public const string MA_DON_VI = "MA_DON_VI";
            public const string MA_CHUC_VU = "MA_CHUC_VU";
            public const string MA_LOAI_LAO_DONG = "MA_LOAI_LAO_DONG";
            public const string NGAY_BAT_DAU = "NGAY_BAT_DAU";
            public const string NGAY_KET_THUC = "NGAY_KET_THUC";
            public const string NGAY_KI_HOP_DONG = "NGAY_KI_HOP_DONG";
        }

        enum thu_tu_cot
        {
            STT = 0,
            MA_NHAN_VIEN = 1,
            MA_HOP_DONG = 2,
            MA_LOAI_HOP_DONG = 3,
            MA_LOAI_LAO_DONG = 4,
            MA_CHUC_DANH_LCD = 5,
            MA_MUC_LCD = 6,
            NGAY_BAT_DAU = 7,
            NGAY_KET_THUC = 8,
            NGAY_KI_HOP_DONG = 9,
            MA_CHUC_DANH_LNS = 10,
            MA_MUC_LUONG_NS = 11,
            MA_DON_VI = 12,
            MA_CHUC_VU = 13,


        }
        #endregion

        #region Members
        DataTable m_dt_loai_hop_dong;
        DataTable m_dt_loai_lao_dong;
        DataTable m_dt_ma_lcd;
        DataTable m_dt_muc_lcd;
        DataTable m_dt_ma_lns;
        DataTable m_dt_muc_lns;
        DataTable m_dt_don_vi;
        DataTable m_dt_chuc_vu;
        #endregion

        #region Private methods

        private void format_control()
        {
            set_define_event();
            m_grv_hop_dong.BestFitColumns();
            m_grc_hop_dong.ToolTipController = m_tooltip_controller;
            this.WindowState = FormWindowState.Maximized;
        }

        private void format_data_table(DataTable ip_dt_src)
        {
            ip_dt_src.Columns[(int)thu_tu_cot.STT].ColumnName = ExcelHopDong.STT;
            ip_dt_src.Columns[(int)thu_tu_cot.MA_NHAN_VIEN].ColumnName = ExcelHopDong.MA_NHAN_VIEN;
            ip_dt_src.Columns[(int)thu_tu_cot.MA_HOP_DONG].ColumnName = ExcelHopDong.MA_HOP_DONG;
            ip_dt_src.Columns[(int)thu_tu_cot.MA_LOAI_HOP_DONG].ColumnName = ExcelHopDong.MA_LOAI_HOP_DONG;
            ip_dt_src.Columns[(int)thu_tu_cot.MA_CHUC_DANH_LCD].ColumnName = ExcelHopDong.MA_CHUC_DANH_LCD;
            ip_dt_src.Columns[(int)thu_tu_cot.MA_MUC_LCD].ColumnName = ExcelHopDong.MA_MUC_LCD;
            ip_dt_src.Columns[(int)thu_tu_cot.MA_CHUC_DANH_LNS].ColumnName = ExcelHopDong.MA_CHUC_DANH_LNS;
            ip_dt_src.Columns[(int)thu_tu_cot.MA_MUC_LUONG_NS].ColumnName = ExcelHopDong.MA_MUC_LUONG_NS;
            ip_dt_src.Columns[(int)thu_tu_cot.MA_DON_VI].ColumnName = ExcelHopDong.MA_DON_VI;
            ip_dt_src.Columns[(int)thu_tu_cot.MA_CHUC_VU].ColumnName = ExcelHopDong.MA_CHUC_VU;
            ip_dt_src.Columns[(int)thu_tu_cot.MA_LOAI_LAO_DONG].ColumnName = ExcelHopDong.MA_LOAI_LAO_DONG;
            ip_dt_src.Columns[(int)thu_tu_cot.NGAY_BAT_DAU].ColumnName = ExcelHopDong.NGAY_BAT_DAU;
            ip_dt_src.Columns[(int)thu_tu_cot.NGAY_KET_THUC].ColumnName = ExcelHopDong.NGAY_KET_THUC;
            ip_dt_src.Columns[(int)thu_tu_cot.NGAY_KI_HOP_DONG].ColumnName = ExcelHopDong.NGAY_KI_HOP_DONG;
        }

        #region Validate
        private bool du_lieu_not_empty()
        {
            return true;
        }
        private bool ma_nhan_vien_khong_trung_lap()
        {
            return true;
        }
        private bool ma_hop_dong_khong_trung_lap()
        {
            return true;
        }
        private bool ma_lcd_dung_dinh_dang()
        {
            return true;
        }
        private bool check_client(int chi_so_hang, int chi_so_cot)
        {
            if(!du_lieu_not_empty() || !ma_nhan_vien_khong_trung_lap() || !ma_hop_dong_khong_trung_lap())
            {
                return false;
            }
            return true;
        }

        private bool check_ma_nhan_vien_ton_tai()
        {
            return true;
        }
        private bool check_nv_chua_co_hop_dong()
        {
            return true;
        }
        private bool check_logic()
        {
            if(!check_ma_nhan_vien_ton_tai() || !check_nv_chua_co_hop_dong())
            {
                return false;
            }
            return true;
        }


        #endregion

        #region Transfer Data
        private void init_data()
        {
            m_dt_chuc_vu = load_data_to_chuc_vu();
            m_dt_don_vi = load_data_to_don_vi();
            m_dt_loai_hop_dong = load_data_to_loai_hd();
            m_dt_loai_lao_dong = load_data_from_tu_dien(CONST_ID_LOAI_TU_DIEN.LOAI_LAO_DONG);
            m_dt_ma_lcd = load_data_from_tu_dien(CONST_ID_LOAI_TU_DIEN.MA_LCD);
            m_dt_ma_lns = load_data_from_tu_dien(CONST_ID_LOAI_TU_DIEN.MA_HS_LNS);
            m_dt_muc_lcd = load_data_from_tu_dien(CONST_ID_LOAI_TU_DIEN.MUC_LCD);
            m_dt_muc_lns = load_data_from_tu_dien(CONST_ID_LOAI_TU_DIEN.MUC_HS_LNS);

        }
        private DataTable load_data_to_loai_hd()
        {
            US_DM_LOAI_HOP_DONG v_us = new US_DM_LOAI_HOP_DONG();
            DS_DM_LOAI_HOP_DONG v_ds = new DS_DM_LOAI_HOP_DONG();
            v_us.FillDataset(v_ds);
            return v_ds.Tables[0];
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
        private DataTable load_data_to_ma_hd()
        {
            US_GD_HOP_DONG v_us = new US_GD_HOP_DONG();
            DS_GD_HOP_DONG v_ds_hd = new DS_GD_HOP_DONG();
            v_us.FillDataset(v_ds_hd);
            return v_ds_hd.Tables[0];
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
                                     where (string)dr["MA_TU_DIEN"] == ma_lns
                                     select (decimal)dr["ID"]).FirstOrDefault();
                decimal id_muc_lns = (from DataRow dr in m_dt_muc_lns.Rows
                                      where (string)dr["MA_TU_DIEN"] == muc_lns
                                      select (decimal)dr["ID"]).FirstOrDefault();
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
        private decimal find_so_tien_lcd(decimal id_lcd)
        {
            US_DM_LUONG_CHE_DO v_us = new US_DM_LUONG_CHE_DO(id_lcd);
            return v_us.dcSO_TIEN;
        }
        private decimal find_id_lcd_by_ma_lcd(string ma_lcd, string muc_lcd)
        {
            try
            {
                decimal id_ma_lcd = (from DataRow dr in m_dt_ma_lcd.Rows
                                     where (string)dr["MA_TU_DIEN"] == ma_lcd
                                     select (decimal)dr["ID"]).FirstOrDefault();
                decimal id_muc_lcd = (from DataRow dr in m_dt_muc_lcd.Rows
                                      where (string)dr["MA_TU_DIEN"] == muc_lcd
                                      select (decimal)dr["ID"]).FirstOrDefault();
                US_DM_LUONG_CHE_DO v_us = new US_DM_LUONG_CHE_DO();
                DS_DM_LUONG_CHE_DO v_ds = new DS_DM_LUONG_CHE_DO();
                v_us.FillDataset(v_ds);
                decimal id_lcd = (from DataRow dr in v_ds.Tables[0].Rows
                                  where (decimal)dr["ID_MA_LCD"] == id_ma_lcd & (decimal)dr["ID_MUC_LCD"] == id_muc_lcd
                                  select (decimal)dr["ID"]).FirstOrDefault();

                return id_lcd;
            }
            catch(Exception v_e)
            {
                throw v_e;
            }
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
        private decimal find_id_loai_hop_dong_by_ma(string ma_loai_hd)
        {
            decimal id = (from DataRow dr in m_dt_loai_hop_dong.Rows
                          where (string)dr["MA_LOAI_HOP_DONG"] == ma_loai_hd
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
                ExcelCommand.CommandText = "SELECT * From [" + SheetName + "] WHERE [STT] IS NOT NULL";
                OleDbDataAdapter ExcelAdapter = new OleDbDataAdapter(ExcelCommand);
                ExcelAdapter.SelectCommand = ExcelCommand;
                ExcelAdapter.Fill(dt);
            }
            con.Close();
            return dt;
        }
        private void set_init_form_load()
        {
            //m_cmd_save.Enabled = false;
            //m_cmd_xuat_excel.Enabled = false;
            init_data();
        }
        private void load_data_from_file_to_grid(string path)
        {
            var v_data_table_grv = load_data_from_file_to_data_table(path, "NHAP_HOP_DONG");
            format_data_table(v_data_table_grv);
            m_grc_hop_dong.DataSource = v_data_table_grv;
            m_grv_hop_dong.BestFitColumns();
        }
        private void grid_to_us_gd_lns(US_GD_HE_SO_LNS v_us_gd_hs_lns, DataRow data)
        {
            v_us_gd_hs_lns.dcID_NHAN_VIEN = find_id_nv_by_ma_nv(data["MA_NHAN_VIEN"].ToString());
            if(!String.IsNullOrEmpty(data["MA_CHUC_DANH_LNS"].ToString()) && !String.IsNullOrEmpty(data["MA_MUC_LUONG_NS"].ToString()))
            {
                v_us_gd_hs_lns.dcID_HE_SO_LNS = find_id_hs_lns_by_ma_muc(data["MA_CHUC_DANH_LNS"].ToString(), data["MA_MUC_LUONG_NS"].ToString());
                v_us_gd_hs_lns.dcHE_SO = find_he_so_lns_by_id(v_us_gd_hs_lns.dcID_HE_SO_LNS);
            }
            v_us_gd_hs_lns.strNGUOI_LAP = CAppContext_201.getCurrentUserName();

            if(String.IsNullOrEmpty(data["NGAY_BAT_DAU"].ToString()))
            {
                v_us_gd_hs_lns.SetNGAY_BAT_DAUNull();
            }
            else
            {
                v_us_gd_hs_lns.datNGAY_BAT_DAU = WinFormControls.FormatPostingDate(data["NGAY_BAT_DAU"].ToString());
            }
            if(String.IsNullOrEmpty(data["NGAY_KET_THUC"].ToString()))
            {
                v_us_gd_hs_lns.datNGAY_KET_THUC = v_us_gd_hs_lns.datNGAY_BAT_DAU.AddYears(45);
            }
            else
            {
                v_us_gd_hs_lns.datNGAY_KET_THUC = WinFormControls.FormatPostingDate(data["NGAY_KET_THUC"].ToString());
            }
            v_us_gd_hs_lns.datNGAY_LAP = DateTime.Now.Date;
        }
        private void grid_to_us_gd_cong_tac(US_GD_CONG_TAC v_us_gd_cong_tac, DataRow data)
        {
            v_us_gd_cong_tac.dcID_NHAN_VIEN = find_id_nv_by_ma_nv(data["MA_NHAN_VIEN"].ToString());
            v_us_gd_cong_tac.dcID_DON_VI = find_id_don_vi(data["MA_DON_VI"].ToString());
            v_us_gd_cong_tac.dcID_VI_TRI = find_id_chuc_vu(data["MA_CHUC_VU"].ToString());
            v_us_gd_cong_tac.dcID_LOAI_CONG_TAC = 157;
            v_us_gd_cong_tac.dcSO_HO_SO = ExecuteFuntion.GetSoHoSoNext(v_us_gd_cong_tac.dcID_DON_VI, v_us_gd_cong_tac.dcID_VI_TRI, v_us_gd_cong_tac.dcID_NHAN_VIEN);
            v_us_gd_cong_tac.strNGUOI_LAP = CAppContext_201.getCurrentUserName();
            v_us_gd_cong_tac.strDA_XOA = "N";
            v_us_gd_cong_tac.datNGAY_BAT_DAU = WinFormControls.FormatPostingDate(data["NGAY_BAT_DAU"].ToString());
            if(String.IsNullOrEmpty(data["NGAY_KET_THUC"].ToString()))
            {
                v_us_gd_cong_tac.datNGAY_KET_THUC = v_us_gd_cong_tac.datNGAY_BAT_DAU.AddYears(45);
            }
            else
            {
                v_us_gd_cong_tac.datNGAY_KET_THUC = WinFormControls.FormatPostingDate(data["NGAY_KET_THUC"].ToString());
            }
            v_us_gd_cong_tac.datNGAY_LAP = DateTime.Now.Date;
        }
        private void grid_to_us_gd_hop_dong(US_GD_HOP_DONG v_us_gd_hd, DataRow data)
        {
            v_us_gd_hd.dcID_NHAN_VIEN = find_id_nv_by_ma_nv(data["MA_NHAN_VIEN"].ToString());
            v_us_gd_hd.dcID_LOAI_HOP_DONG = find_id_loai_hop_dong_by_ma(data["MA_LOAI_HOP_DONG"].ToString());
            v_us_gd_hd.dcID_CHUC_VU = find_id_chuc_vu(data["MA_CHUC_VU"].ToString());
            v_us_gd_hd.dcID_DON_VI = find_id_don_vi(data["MA_DON_VI"].ToString());
            v_us_gd_hd.dcID_LUONG_CHE_DO = find_id_lcd_by_ma_lcd(data["MA_CHUC_DANH_LCD"].ToString(), data["MA_MUC_LCD"].ToString());
            v_us_gd_hd.dcID_LOAI_LAO_DONG = find_id_tu_dien_by_ma_tu_dien(data["MA_LOAI_LAO_DONG"].ToString());
            v_us_gd_hd.dcSO_TIEN_LCD = find_so_tien_lcd(find_id_lcd_by_ma_lcd(data["MA_CHUC_DANH_LCD"].ToString(), data["MA_MUC_LCD"].ToString()));
            v_us_gd_hd.strMA_HOP_DONG = data["MA_HOP_DONG"].ToString();
            v_us_gd_hd.strNGUOI_LAP = CAppContext_201.getCurrentUserName();
            v_us_gd_hd.datNGAY_BAT_DAU = WinFormControls.FormatPostingDate(data["NGAY_BAT_DAU"].ToString());
            if(String.IsNullOrEmpty(data["NGAY_KET_THUC"].ToString()))
            {
                v_us_gd_hd.SetNGAY_KET_THUCNull();
            }
            else
            {
                v_us_gd_hd.datNGAY_KET_THUC = WinFormControls.FormatPostingDate(data["NGAY_KET_THUC"].ToString());
            }
            if(String.IsNullOrEmpty(data["NGAY_KI_HOP_DONG"].ToString()))
            {
                v_us_gd_hd.SetNGAY_KY_HOP_DONGNull();
            }
            else
            {
                v_us_gd_hd.datNGAY_KY_HOP_DONG = WinFormControls.FormatPostingDate(data["NGAY_KI_HOP_DONG"].ToString());
            }
            
            v_us_gd_hd.datNGAY_LAP = DateTime.Now.Date;
        }
        
        private void save_data()
        {
            US_GD_HOP_DONG v_us_gd_hd = new US_GD_HOP_DONG();
            US_GD_CONG_TAC v_us_gd_cong_tac = new US_GD_CONG_TAC();
            US_GD_HE_SO_LNS v_us_gd_hs_lns = new US_GD_HE_SO_LNS();
            try
            {
                for(int i = 0; i < m_grv_hop_dong.RowCount; i++)
                {
                    var data = m_grv_hop_dong.GetDataRow(i);
                    //
                    grid_to_us_gd_hop_dong(v_us_gd_hd, data);
                    grid_to_us_gd_cong_tac(v_us_gd_cong_tac, data);
                    grid_to_us_gd_lns(v_us_gd_hs_lns, data);

                    v_us_gd_hd.BeginTransaction();
                    v_us_gd_cong_tac.UseTransOfUSObject(v_us_gd_hd);
                    v_us_gd_cong_tac.Insert();
                    v_us_gd_hs_lns.UseTransOfUSObject(v_us_gd_hd);
                    v_us_gd_hs_lns.Insert();
                    v_us_gd_hd.Insert();
                    
                    v_us_gd_hd.CommitTransaction();
                }
                CHRM_BaseMessages.MsgBox_Infor("Đã lưu dữu liệu thành công");
            }
            catch(Exception)
            {
                if(v_us_gd_hd.is_having_transaction())
                {
                    v_us_gd_hd.Rollback();
                }
                throw;
            }
        }
        private void xuat_excel()
        {
            XlsExportOptions opt = new XlsExportOptions();
            opt.SheetName = "NHAP_HOP_DONG";
            opt.TextExportMode = TextExportMode.Value;
            string path = WinFormControls.saveFileDialog("HOP_DONG");
            if(!String.IsNullOrEmpty(path))
            {
                m_grv_hop_dong.ExportToXls(path, opt);
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
                    m_lbl_thong_bao.Text = "Đang lưu dữ liệu...";
                    m_lbl_thong_bao.ForeColor = Color.Green;
                    save_data();
                    m_lbl_thong_bao.Text = "Đã lưu dữ liệu thành công!";
                    m_lbl_thong_bao.ForeColor = Color.Green;
                }
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void M_cmd_tai_file_mau_Click(object sender, EventArgs e)
        {
            try
            {
                m_lbl_thong_bao.Text = "File sẽ mở lên ngay sau đây";
                m_lbl_thong_bao.ForeColor = Color.Green;
                WinFormControls.openTemplate_v2(CONST_EXCEL_TEMPLATE.HOP_DONG_TEMPLATE);
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
                    m_grc_hop_dong.Refresh();
                    return;
                }
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
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
