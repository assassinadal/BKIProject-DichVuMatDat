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

namespace BKI_DichVuMatDat.NghiepVu.HopDong
{
    public partial class f001_import_hop_dong : Form
    {
        #region Public Interface
        public f001_import_hop_dong()
        {
            InitializeComponent();
            format_control();
        }

        #endregion

        #region Data Structure
        class ViTriTrenLuoi
        {
            public string cot_sai { get; set; }
            public int chi_so_hang { get; set; }
            public int chi_so_cot { get; set; }
            public ViTriTrenLuoi(int x, int y, string ten)
            {
                chi_so_cot = y;
                chi_so_hang = x;
                cot_sai = ten;
            }
        }
        #endregion

        #region Members
        private List<ViTriTrenLuoi> m_list_vi_tri_sai = new List<ViTriTrenLuoi>();
        private DataTable m_data_table_grv = new DataTable();
        // Bang ma
        private DataTable m_dt_ma_lcd = new DataTable();
        private DataTable m_dt_muc_lcd = new DataTable();
        private DataTable m_dt_ma_lns = new DataTable();
        private DataTable m_dt_muc_lns = new DataTable();
        private DataTable m_dt_loai_hd = new DataTable();
        private DataTable m_dt_loai_lao_dong = new DataTable();
        private DataTable m_dt_don_vi = new DataTable();
        private DataTable m_dt_chuc_vu = new DataTable();
        private List<DataTable> m_list_dt_table = new List<DataTable>();

        #endregion

        #region Private methods
        //Setup Form
        private void format_control()
        {
            set_define_event();
            m_grv_hop_dong.BestFitColumns();
        }

        //Validate
        private void check_client()
        {
            foreach (var item in m_data_table_grv.Rows)
            {
                var data_row = (item as DataRow);
                int chi_so_hang = m_data_table_grv.Rows.IndexOf(data_row);
                for (int cot = 0; cot < 14; cot++)
                {
                    if (cot == 12)
                    {
                        continue;
                    }
                    if (String.IsNullOrEmpty(data_row[cot].ToString()))
                    {
                        var ten_cot = m_data_table_grv.Columns[cot].ColumnName.ToString();
                        m_list_vi_tri_sai.Add(new ViTriTrenLuoi(chi_so_hang, cot, ten_cot));
                    }
                }
            }
        }

        private void check_logic()
        {
            foreach (var item in m_data_table_grv.Rows)
            {
                var data_row = (item as DataRow);
                int chi_so_hang = m_data_table_grv.Rows.IndexOf(data_row);

                // check ma_nv
                if (!check_ma_nv_ok(data_row[1].ToString()))
                {
                    m_list_vi_tri_sai.Add(new ViTriTrenLuoi(chi_so_hang, 1, "Chưa có mã nhân viên"));
                }

                // check ma_hd
                if (!check_ma_hd_ok(data_row[2].ToString()))
                {
                    m_list_vi_tri_sai.Add(new ViTriTrenLuoi(chi_so_hang, 1, "Đã có mã hợp đồng"));
                }

                //// check ma cac hs
                //for (int chi_so_cot = 4; chi_so_cot < 11; chi_so_cot++)
                //{
                //    var ten_cot = m_data_table_grv.Columns[chi_so_cot].ColumnName.ToString();
                //    if (!check_ma_ok(m_list_dt_table[chi_so_cot - 4], data_row[chi_so_cot].ToString()))
                //    {
                //        m_list_vi_tri_sai.Add(new ViTriTrenLuoi(chi_so_hang, chi_so_cot, ten_cot));
                //    }
                //}

                ////check ngay thang
                //if (!String.IsNullOrEmpty(data_row["NGAY_KET_THUC"].ToString()))
                //{
                //    if (WinFormControls.FormatPostingDate(data_row["NGAY_KET_THUC"].ToString()) <= WinFormControls.FormatPostingDate(data_row["NGAY_BAT_DAU"].ToString()))
                //    {
                //        m_list_vi_tri_sai.Add(new ViTriTrenLuoi(chi_so_hang, 12, "NGAY_BAT_DAU < NGAY_KET_THUC"));
                //    }
                //}
            }
        }

        private bool check_ma_ok(DataTable ip_dt, string ma)
        {
            decimal id = (from DataRow dr in ip_dt.Rows
                          where (string)dr[2] == ma
                          select (decimal)dr["ID"]).FirstOrDefault();
            if (id > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool check_ma_hd_ok(string ma_hop_dong)
        {
            US_GD_HOP_DONG v_us = new US_GD_HOP_DONG();
            DS_GD_HOP_DONG v_ds_hd = new DS_GD_HOP_DONG();
            v_us.FillDataset(v_ds_hd, " where MA_HOP_DONG = '" + ma_hop_dong + "'");
            if (v_ds_hd.Tables[0].Rows.Count > 0)
                return false;
            else
            {
                return true;
            }
        }

        private bool check_ma_nv_ok(string ma_nv)
        {
            US_DM_NHAN_VIEN v_us = new US_DM_NHAN_VIEN();
            DS_DM_NHAN_VIEN v_ds_nhan_vien = new DS_DM_NHAN_VIEN();
            v_us.FillDataset(v_ds_nhan_vien, " where MA_NV= '" + ma_nv + "'");
            if (v_ds_nhan_vien.Tables[0].Rows.Count > 0)
                return true;
            else
            {
                return false;
            }
        }

        private bool check_grid_data_ok()
        {
            check_client();
            check_logic();
            if (m_list_vi_tri_sai.Count == 0)
            {
                return true;
            }
            hien_thi_vi_tri_sai();
            return false;
        }

        private void hien_thi_vi_tri_sai()
        {
            string thong_bao = @"Vui lòng kiểm tra lại dữ liệu: ";
            foreach (var item in m_list_vi_tri_sai)
            {
                thong_bao += "Dòng " + item.chi_so_hang +1 + " Cột" + item.chi_so_cot + 1  + ": Lỗi  " + item.cot_sai + " ; ";
            }
            MessageBox.Show(thong_bao);
        }

        //Transfer du lieu
        private void load_data_to_member_table()
        {
            m_dt_chuc_vu = load_data_to_chuc_vu();
            m_dt_don_vi = load_data_to_don_vi();
            m_dt_loai_hd = load_data_to_loai_hd();
            m_dt_ma_lns = load_data_to_from_tu_dien(1);
            m_dt_muc_lns = load_data_to_from_tu_dien(2);
            m_dt_ma_lcd = load_data_to_from_tu_dien(3);
            m_dt_muc_lcd = load_data_to_from_tu_dien(4);
            m_dt_loai_lao_dong = load_data_to_from_tu_dien(6);
            //
            m_list_dt_table.Add(m_dt_loai_hd);
            m_list_dt_table.Add(m_dt_ma_lcd);
            m_list_dt_table.Add(m_dt_muc_lcd);
            m_list_dt_table.Add(m_dt_ma_lns);
            m_list_dt_table.Add(m_dt_muc_lns);
            m_list_dt_table.Add(m_dt_don_vi);
            m_list_dt_table.Add(m_dt_chuc_vu);
            m_list_dt_table.Add(m_dt_loai_lao_dong);
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

        private DataTable load_data_to_from_tu_dien(decimal id_loai_tu_dien)
        {
            US_CM_DM_TU_DIEN v_us = new US_CM_DM_TU_DIEN();
            DS_CM_DM_TU_DIEN v_ds = new DS_CM_DM_TU_DIEN();
            v_us.FillDataset(v_ds, "WHERE ID_LOAI_TU_DIEN = " + id_loai_tu_dien);
            return v_ds.Tables[0];
        }


        // find id
        private decimal find_id_nv_by_ma_nv(string v)
        {
            try
            {
                US_DM_NHAN_VIEN v_us = new US_DM_NHAN_VIEN();
                DS_DM_NHAN_VIEN v_ds = new DS_DM_NHAN_VIEN();
                v_us.FillDataset(v_ds, "WHERE MA_NV = " + v);
                string v_str_filter = "MA_NV = " + v;
                DataRow[] v_dr = v_ds.DM_NHAN_VIEN.Select(v_str_filter);

                if (v_dr.Count() == 0)
                {
                    return -1;
                }
                else
                {
                    return CIPConvert.ToDecimal(v_dr.First()["ID"].ToString());
                }
            }
            catch (Exception)
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
            catch (Exception v_e)
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
            catch (Exception v_e)
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
            catch (Exception v_e)
            {
                throw v_e;
            }

        }

        private decimal find_id_don_vi(string ma_dv)
        {
            //try
            //{
            //    US_DM_DON_VI v_us = new US_DM_DON_VI();
            //    DS_DM_DON_VI v_ds = new DS_DM_DON_VI();
            //    v_us.FillDataset(v_ds);
            //    string v_str_filter = "WHERE MA_DV = " + ma_dv;
            //    DataRow[] v_dr = v_ds.DM_DON_VI.Select(v_str_filter);

            //    if (v_dr.Count() == 0)
            //    {
            //        return -1;
            //    }
            //    else
            //    {
            //        return CIPConvert.ToDecimal(v_dr.First()["ID"].ToString());
            //    }
            //}
            //catch (Exception v_E)
            //{
            //    throw v_E;
            //}
            decimal id = (from DataRow dr in m_dt_don_vi.Rows
                          where (string)dr["MA_DON_VI"] == ma_dv
                          select (decimal)dr["ID"]).FirstOrDefault();
            return id;
        }

        private decimal find_id_chuc_vu(string ma_chuc_vu)
        {
            //try
            //{
            //    US_DM_CHUC_VU v_us = new US_DM_CHUC_VU();
            //    DS_DM_CHUC_VU v_ds = new DS_DM_CHUC_VU();
            //    v_us.FillDataset(v_ds);
            //    string v_str_filter = "WHERE MA_CHUC_VU like " + ma_chuc_vu;
            //    DataRow[] v_dr = v_ds.DM_CHUC_VU.Select(v_str_filter);

            //    if (v_dr.Count() == 0)
            //    {
            //        return -1;
            //    }
            //    else
            //    {
            //        return CIPConvert.ToDecimal(v_dr.First()["ID"].ToString());
            //    }
            //}
            //catch (Exception v_E)
            //{

            //    throw v_E;
            //}
            decimal id = (from DataRow dr in m_dt_chuc_vu.Rows
                          where (string)dr["MA_CHUC_VU"] == ma_chuc_vu
                          select (decimal)dr["ID"]).FirstOrDefault();
            return id;
        }

        private decimal find_id_loai_hop_dong_by_ma(string ma_loai_hd)
        {
            decimal id = (from DataRow dr in m_dt_loai_hd.Rows
                          where (string)dr["MA_LOAI_HOP_DONG"] == ma_loai_hd
                          select (decimal)dr["ID"]).FirstOrDefault();
            return id;
        }

        //Action
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
            if (ExcelDataSet != null && ExcelDataSet.Rows.Count > 0)
            {
                //string SheetName = ExcelDataSet.Rows[0]["TABLE_NAME"].ToString(); // get sheetname
                ExcelCommand.CommandText = "SELECT * From [" + SheetName + "]  WHERE [STT] IS NOT NULL";
                OleDbDataAdapter ExcelAdapter = new OleDbDataAdapter(ExcelCommand);
                ExcelAdapter.SelectCommand = ExcelCommand;
                ExcelAdapter.Fill(dt);
            }
            con.Close();
            return dt;
        }

        private void set_init_form_load()
        {
            m_lbl_thong_bao.Text = "Chưa có dữ liệu";
            m_lbl_thong_bao.ForeColor = Color.Red;
            load_data_to_member_table();
        }

        private void load_data_from_file_to_grid(string path)
        {
            m_data_table_grv = load_data_from_file_to_data_table(path, "NHAP_HOP_DONG");
            m_grc_hop_dong.DataSource = m_data_table_grv;
            m_grv_hop_dong.BestFitColumns();
        }

        private void dat_ngay_ket_thuc_hop_dong_cu()
        {

        }

        private void grid_to_us_gd_lns(US_GD_HE_SO_LNS v_us_gd_hs_lns, DataRow data)
        {
            v_us_gd_hs_lns.dcID_NHAN_VIEN = find_id_nv_by_ma_nv(data["MA_NHAN_VIEN"].ToString());
            v_us_gd_hs_lns.dcID_HE_SO_LNS = find_id_hs_lns_by_ma_muc(data["MA_CHUC_DANH_LNS"].ToString(), data["MA_MUC_LUONG_NS"].ToString());
            v_us_gd_hs_lns.dcHE_SO = find_he_so_lns_by_id(v_us_gd_hs_lns.dcID_HE_SO_LNS);
            v_us_gd_hs_lns.strNGUOI_LAP = CAppContext_201.getCurrentUserName();
            v_us_gd_hs_lns.datNGAY_BAT_DAU = WinFormControls.FormatPostingDate(data["NGAY_BAT_DAU"].ToString());
            if (String.IsNullOrEmpty(data["NGAY_KET_THUC"].ToString()))
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
            v_us_gd_cong_tac.dcSO_HO_SO = ExecuteFuntion.GetSoHoSoNext(v_us_gd_cong_tac.dcID_DON_VI, v_us_gd_cong_tac.dcID_VI_TRI);

            v_us_gd_cong_tac.strNGUOI_LAP = CAppContext_201.getCurrentUserName();
            v_us_gd_cong_tac.strDA_XOA = "N";

            v_us_gd_cong_tac.datNGAY_BAT_DAU = WinFormControls.FormatPostingDate(data["NGAY_BAT_DAU"].ToString());
            if (String.IsNullOrEmpty(data["NGAY_KET_THUC"].ToString()))
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
            if (String.IsNullOrEmpty(data["NGAY_KET_THUC"].ToString()))
            {
                v_us_gd_hd.datNGAY_KET_THUC = v_us_gd_hd.datNGAY_BAT_DAU.AddYears(45);
            }
            else
            {
                v_us_gd_hd.datNGAY_KET_THUC = WinFormControls.FormatPostingDate(data["NGAY_KET_THUC"].ToString());
            }
            if (!String.IsNullOrEmpty(data["NGAY_KET_THUC"].ToString()))
            {
                v_us_gd_hd.datNGAY_KY_HOP_DONG = v_us_gd_hd.datNGAY_BAT_DAU.AddYears(45);
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
                for (int i = 0; i < m_grv_hop_dong.RowCount; i++)
                {
                    var data = m_grv_hop_dong.GetDataRow(i);
                    //
                    grid_to_us_gd_hop_dong(v_us_gd_hd, data);
                    grid_to_us_gd_cong_tac(v_us_gd_cong_tac, data);
                    grid_to_us_gd_lns(v_us_gd_hs_lns, data);
                    v_us_gd_hd.BeginTransaction();
                    v_us_gd_cong_tac.UseTransOfUSObject(v_us_gd_hd);
                    v_us_gd_hs_lns.UseTransOfUSObject(v_us_gd_hd);
                    v_us_gd_hd.Insert();
                    v_us_gd_cong_tac.Insert();
                    v_us_gd_hs_lns.Insert();
                    v_us_gd_hd.CommitTransaction();
                }
            }
            catch (Exception)
            {
                if (v_us_gd_hd.is_having_transaction())
                {
                    v_us_gd_hd.Rollback();
                }
                throw;
            }
        }

        //Display
        private void xuat_excel()
        {
            CHRMCommon.ExportExcelWithFileName(m_grv_hop_dong, "Danh sach Hop DOng");
        }

        private void show_ket_qua()
        {
            throw new NotImplementedException();
        }

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
                xuat_excel();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void M_cmd_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (CHRM_BaseMessages.MsgBox_Confirm("Bạn có chắc chắn muốn lưu dữ liệu trên?"))
                {
                    m_lbl_thong_bao.Text = "Đang lưu dữ liệu...";
                    m_lbl_thong_bao.ForeColor = Color.Green;
                    save_data();
                    show_ket_qua();
                    m_lbl_thong_bao.Text = "Đã lưu dữ liệu thành công!";
                    m_lbl_thong_bao.ForeColor = Color.Green;
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void M_cmd_tai_file_mau_Click(object sender, EventArgs e)
        {
            try
            {
                WinFormControls.openTemplate(CONST_EXCEL_TEMPLATE.HOP_DONG_TEMPLATE);
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void M_cmd_chon_file_Click(object sender, EventArgs e)
        {
            try
            {
                m_lbl_thong_bao.Text = "Đang đọc dữ liệu từ file...";
                m_lbl_thong_bao.ForeColor = Color.GreenYellow;
                string path = WinFormControls.openFileDialog();
                if (String.IsNullOrEmpty(path))
                {
                    return;
                }
                load_data_from_file_to_grid(path);
                m_lbl_thong_bao.Text = "Đang kiểm tra dữ liệu...";
                m_lbl_thong_bao.ForeColor = Color.GreenYellow;
                m_list_vi_tri_sai = new List<ViTriTrenLuoi>();
                if (!check_grid_data_ok())
                {
                    m_lbl_thong_bao.Text = "Vui lòng chỉnh sửa và chọn lại file excel";
                    m_lbl_thong_bao.ForeColor = Color.Red;
                    return;
                }
                m_lbl_thong_bao.Text = "Dữ liệu đã sẵn sàng nhập";
                m_lbl_thong_bao.ForeColor = Color.Green;
            }
            catch (Exception v_e)
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
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }


        #endregion

    }
}
