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
    public partial class f001_import_hop_dong : Form
    {

        #region Public Interfaces

        public f001_import_hop_dong()
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

        class ViTriTrenLuoi
        {
            public string loi_sai { get; set; }
            public int chi_so_hang { get; set; }
            public int chi_so_cot { get; set; }
            public ViTriTrenLuoi(int x, int y, string ten)
            {
                chi_so_cot = y;
                chi_so_hang = x;
                loi_sai = ten;
            }
        }

        enum thu_tu_cot
        {
            STT = 0,
            MA_NHAN_VIEN = 1,
            MA_HOP_DONG = 2,
            MA_LOAI_HOP_DONG = 3,
            MA_CHUC_DANH_LCD = 4,
            MA_MUC_LCD = 5,
            MA_CHUC_DANH_LNS = 6,
            MA_MUC_LUONG_NS = 7,
            MA_DON_VI = 8,
            MA_CHUC_VU = 9,
            MA_LOAI_LAO_DONG = 10,
            NGAY_BAT_DAU = 11,
            NGAY_KET_THUC = 12,
            NGAY_KI_HOP_DONG = 13
        }
        #endregion

        #region Members
        private bool co_ma_nhan_vien_trung = false;
        private bool co_ma_hop_dong_trung = false;
        private string m_file_path;
        private List<ViTriTrenLuoi> m_list_vi_tri_sai = new List<ViTriTrenLuoi>();
        private DataTable m_data_table_grv = new DataTable();

        #region DataTable

        private DataTable m_dt_ma_nv = new DataTable();
        private DataTable m_dt_ma_hop_dong = new DataTable();
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
        private bool check_client(int chi_so_hang, int chi_so_cot)
        {
            //neu loai hop dong la thu viec hoac vo thoi han thi dc null
            //if (chi_so_cot == 12)
            //{
            //    var loai_hop_dong = m_grv_hop_dong.GetDataRow(chi_so_hang)[3];
            //    if (loai_hop_dong != null)
            //    {
            //        if (!String.IsNullOrEmpty(loai_hop_dong.ToString()))
            //        {
            //            string ma = loai_hop_dong.ToString();
            //            if (check_ma_ok(m_list_dt_table[2], ma))
            //            {
            //                if (ma != "HDTV" | ma != "HDKX")
            //                {
            //                    if (String.IsNullOrEmpty(m_grv_hop_dong.GetDataRow(chi_so_hang)[12].ToString()))
            //                    {
            //                        m_list_vi_tri_sai.Add(new ViTriTrenLuoi(chi_so_hang, chi_so_cot, " Chưa điền thông tin "));
            //                        return false;
            //                    }
            //                }
            //            }
            //        }
            //    }
            //    return true;
            //}
            //if(chi_so_cot == 6 | chi_so_cot == 7)
            //{
            //    var ma_lns = m_grv_hop_dong.GetDataRow(chi_so_hang)[6].ToString();
            //    var muc_lns = m_grv_hop_dong.GetDataRow(chi_so_hang)[7].ToString();
            //    if(String.IsNullOrEmpty(ma_lns) & String.IsNullOrEmpty(muc_lns))
            //    {
            //        return true;
            //    }
            //}
            if (String.IsNullOrEmpty(m_grv_hop_dong.GetDataRow(chi_so_hang)[chi_so_cot].ToString()))
            {
                m_list_vi_tri_sai.Add(new ViTriTrenLuoi(chi_so_hang, chi_so_cot, " Chưa điền thông tin "));
                return false;
            }
            return true;
        }
        private void check_logic(int chi_so_hang, int chi_so_cot)
        {
            // check ma cac ma 
            if(chi_so_cot > 0 & chi_so_cot < 11)
            {
                var ten_cot = m_data_table_grv.Columns[chi_so_cot].ColumnName.ToString();
                //check ma_nv
                if(chi_so_cot == 1)
                {
                    if(!check_ma_ok(m_list_dt_table[chi_so_cot - 1], m_grv_hop_dong.GetDataRow(chi_so_hang)[chi_so_cot].ToString()))
                    {
                        m_list_vi_tri_sai.Add(new ViTriTrenLuoi(chi_so_hang, chi_so_cot, "Mã nhân viên không tồn tại "));
                    }
                    else
                    {
                        if(check_nv_da_co_hop_dong(m_grv_hop_dong.GetDataRow(chi_so_hang)[chi_so_cot].ToString()))
                        {
                            m_list_vi_tri_sai.Add(new ViTriTrenLuoi(chi_so_hang, chi_so_cot, " Nhân viên đã có hợp đồng"));
                        }
                    }
                    return;
                }
                //check ma hop dong
                if(chi_so_cot == 2)
                {
                    if(!check_ma_hop_dong(m_list_dt_table[chi_so_cot - 1], m_grv_hop_dong.GetDataRow(chi_so_hang)[chi_so_cot].ToString()))
                    {
                        m_list_vi_tri_sai.Add(new ViTriTrenLuoi(chi_so_hang, chi_so_cot, " Mã hợp đồng đã tồn tại"));
                    }
                    return;
                }

                //check cac ma
                if(chi_so_cot == 6 | chi_so_cot == 7)
                {
                    if(String.IsNullOrEmpty(m_grv_hop_dong.GetDataRow(chi_so_hang)[chi_so_cot].ToString()))
                    {
                        return;
                    }
                    if(!check_ma_ok(m_list_dt_table[chi_so_cot - 1], m_grv_hop_dong.GetDataRow(chi_so_hang)[chi_so_cot].ToString()))
                    {
                        m_list_vi_tri_sai.Add(new ViTriTrenLuoi(chi_so_hang, chi_so_cot, " Mã không hợp lệ"));
                        return;
                    }
                }

                if(!check_ma_ok(m_list_dt_table[chi_so_cot - 1], m_grv_hop_dong.GetDataRow(chi_so_hang)[chi_so_cot].ToString()))
                {
                    m_list_vi_tri_sai.Add(new ViTriTrenLuoi(chi_so_hang, chi_so_cot, " Mã không hợp lệ"));
                }
            }

            //check ngay thang
            if(chi_so_cot == 12)
            {
                var loai_hop_dong = m_grv_hop_dong.GetDataRow(chi_so_hang)[3];
                if(loai_hop_dong != null)
                {
                    if(!String.IsNullOrEmpty(loai_hop_dong.ToString()))
                    {
                        string ma = loai_hop_dong.ToString();
                        if(check_ma_ok(m_list_dt_table[2], ma))
                        {
                            if(!String.IsNullOrEmpty(m_grv_hop_dong.GetDataRow(chi_so_hang)[chi_so_cot - 1].ToString()))
                            {
                                var nbd = WinFormControls.FormatPostingDate(m_grv_hop_dong.GetDataRow(chi_so_hang)[chi_so_cot - 1].ToString());
                                var nkt = WinFormControls.FormatPostingDate(m_grv_hop_dong.GetDataRow(chi_so_hang)[chi_so_cot].ToString());
                                if(ma == "HD3N" & ngay_ket_thuc_ko_hop_le(nbd, nkt, 3))
                                {
                                    m_list_vi_tri_sai.Add(new ViTriTrenLuoi(chi_so_hang, chi_so_cot, " Ngày bắt đầu và ngày kết thúc không phù hợp với loại hợp đồng"));
                                }
                                if(ma == "HD1N" & ngay_ket_thuc_ko_hop_le(nbd, nkt, 1))
                                {
                                    m_list_vi_tri_sai.Add(new ViTriTrenLuoi(chi_so_hang, chi_so_cot, " Ngày bắt đầu và ngày kết thúc không phù hợp với loại hợp đồng"));
                                }
                            }
                        }
                    }
                }
            }
        }
        private bool check_ma_ko_trung_lap(int column_id)
        {
            var list_ma = new List<string>();
            foreach (DataRow dt in m_data_table_grv.Rows)
            {
                if (dt[column_id] == null)
                {
                    continue;
                }
                list_ma.Add(dt[column_id].ToString());
            }
            var list_ma_hd = list_ma.Distinct().ToList();
            if (list_ma_hd.Count == m_data_table_grv.Rows.Count)
            {
                return true;
            }
            return false;
        }
        private bool ngay_ket_thuc_ko_hop_le(DateTime nbd, DateTime nkt, int v)
        {
            if (nbd.Day == nkt.Day & nbd.Month == nkt.Month & nkt.Year - nbd.Year == v)
            {
                return false;
            }
            return true;
        }
        private bool check_nv_da_co_hop_dong(string ma_nv)
        {
            //decimal id_nv = find_id_nv_by_ma_nv(ma_nv);
            //decimal id = (from DataRow dr in m_dt_ma_hop_dong.Rows
            //              where (decimal)dr["ID_NHAN_VIEN"] == id_nv
            //              select (decimal)dr["ID"]).FirstOrDefault();
            //if (id > 0)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
            return false;
        }
        private bool check_ma_hop_dong(DataTable ip_dt, string ma)
        {
            var list_ma = (from DataRow dr in ip_dt.Rows
                           where dr["MA_HOP_DONG"] != null
                           select dr["MA_HOP_DONG"]).ToList();
            foreach (var item in list_ma)
            {
                if (String.IsNullOrEmpty(item.ToString()))
                {
                    continue;
                }
                if (item.ToString() == ma)
                {
                    return false;
                }
            }
            return true;
        }
        private bool check_ma_ok(DataTable ip_dt, string ma)
        {
             var list_ma = (from DataRow dr in ip_dt.Rows
                           where dr[1] != null
                           select dr[1]).ToList();
            foreach (var item in list_ma)
            {
                if (String.IsNullOrEmpty(item.ToString()))
                {
                    continue;
                }
                if (item.ToString() == ma)
                {
                    return true;
                }
            }
            return false;           
        }
        private bool check_grid_data_ok()
        {
            if (!check_ma_ko_trung_lap(1))
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Một số mã nhân viên bị trùng nhau. Vui lòng kiểm tra lại");
                co_ma_nhan_vien_trung = true;
            }
            if (!check_ma_ko_trung_lap(2))
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Một số mã hợp đồng bị trùng nhau. Vui lòng kiểm tra lại");
                co_ma_hop_dong_trung = true;
            }
            for (int chi_so_hang = 0; chi_so_hang < m_grv_hop_dong.RowCount; chi_so_hang++)
            {
                for (int chi_so_cot = 1; chi_so_cot < 14; chi_so_cot++)
                {
                    if(chi_so_cot == 4 || chi_so_cot == 5 || chi_so_cot == 6 || chi_so_cot == 7 || chi_so_cot == 12 || chi_so_cot == 13)
                    {
                        continue;
                    }
                    else
                    {
                        check_client(chi_so_hang, chi_so_cot);
                    }
                    //if (check_client(chi_so_hang, chi_so_cot))
                    //{
                    //    check_logic(chi_so_hang, chi_so_cot);
                    //}
                }
            }
            if (m_list_vi_tri_sai.Count == 0 & !co_ma_nhan_vien_trung & !co_ma_hop_dong_trung)
            {
                return true;
            }
            hien_thi_vi_tri_sai();
            return false;
        }

        private void hien_thi_vi_tri_sai()
        {
            //if (co_ma_nhan_vien_trung)
            //{
            //    m_grv_hop_dong.RefreshRowCell(0, m_grv_hop_dong.Columns[1]);
            //}
            //if (co_ma_hop_dong_trung)
            //{
            //    m_grv_hop_dong.RefreshRowCell(0, m_grv_hop_dong.Columns[2]);
            //}
            //if (m_list_vi_tri_sai.Count == 0)
            //{
            //    return;
            //}
            //foreach (var item in m_list_vi_tri_sai)
            //{
            //    m_grv_hop_dong.RefreshRowCell(item.chi_so_hang, m_grv_hop_dong.Columns[item.chi_so_cot]);
            //}
            m_grc_hop_dong.Refresh();
        }

        #endregion

        #region Transfer Data

        private void load_data_to_member_table()
        {
            m_dt_ma_hop_dong = load_data_to_ma_hd();
            m_dt_ma_nv = load_data_to_ma_nv();
            m_dt_chuc_vu = load_data_to_chuc_vu();
            m_dt_don_vi = load_data_to_don_vi();
            m_dt_loai_hd = load_data_to_loai_hd();
            m_dt_ma_lns = load_data_from_tu_dien(1);
            m_dt_muc_lns = load_data_from_tu_dien(2);
            m_dt_ma_lcd = load_data_from_tu_dien(3);
            m_dt_muc_lcd = load_data_from_tu_dien(4);
            m_dt_loai_lao_dong = load_data_from_tu_dien(6);
            //
            m_dt_loai_hd.Columns["MA_LOAI_HOP_DONG"].SetOrdinal(1);
            m_dt_ma_hop_dong.Columns["MA_HOP_DONG"].SetOrdinal(1);
            m_dt_don_vi.Columns["MA_DON_VI"].SetOrdinal(1);
            //
            m_list_dt_table.Add(m_dt_ma_nv);
            m_list_dt_table.Add(m_dt_ma_hop_dong);
            m_list_dt_table.Add(m_dt_loai_hd);
            m_list_dt_table.Add(m_dt_ma_lcd);
            m_list_dt_table.Add(m_dt_muc_lcd);
            m_list_dt_table.Add(m_dt_ma_lns);
            m_list_dt_table.Add(m_dt_muc_lns);
            m_list_dt_table.Add(m_dt_don_vi);
            m_list_dt_table.Add(m_dt_chuc_vu);
            m_list_dt_table.Add(m_dt_loai_lao_dong);
            //
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
            decimal id = (from DataRow dr in m_dt_loai_hd.Rows
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
            if (ExcelDataSet != null && ExcelDataSet.Rows.Count > 0)
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
            m_cmd_save.Enabled = false;
            m_cmd_xuat_excel.Enabled = false;
            load_data_to_member_table();
        }

        private void load_data_from_file_to_grid(string path)
        {
            m_data_table_grv = load_data_from_file_to_data_table(path, "NHAP_HOP_DONG");
            format_data_table(m_data_table_grv);
            m_grc_hop_dong.DataSource = m_data_table_grv;
            m_grv_hop_dong.BestFitColumns();
        }
        private void grid_to_us_gd_lns(US_GD_HE_SO_LNS v_us_gd_hs_lns, DataRow data)
        {
            v_us_gd_hs_lns.dcID_NHAN_VIEN = find_id_nv_by_ma_nv(data["MA_NHAN_VIEN"].ToString());
            if (!String.IsNullOrEmpty(data["MA_CHUC_DANH_LNS"].ToString()) & !String.IsNullOrEmpty(data["MA_MUC_LUONG_NS"].ToString()))
            {
                v_us_gd_hs_lns.dcID_HE_SO_LNS = find_id_hs_lns_by_ma_muc(data["MA_CHUC_DANH_LNS"].ToString(), data["MA_MUC_LUONG_NS"].ToString());
                v_us_gd_hs_lns.dcHE_SO = find_he_so_lns_by_id(v_us_gd_hs_lns.dcID_HE_SO_LNS);
            }
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
            v_us_gd_cong_tac.dcSO_HO_SO = ExecuteFuntion.GetSoHoSoNext(v_us_gd_cong_tac.dcID_DON_VI, v_us_gd_cong_tac.dcID_VI_TRI, v_us_gd_cong_tac.dcID_NHAN_VIEN);
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
            v_us_gd_hd.datNGAY_KY_HOP_DONG = WinFormControls.FormatPostingDate(data["NGAY_KI_HOP_DONG"].ToString());
            v_us_gd_hd.datNGAY_LAP = DateTime.Now.Date;
        }

        private decimal get_id_hop_dong_hien_tai(string ip_id_nv)
        {
            US_GD_HOP_DONG v_us = new US_GD_HOP_DONG();
            return v_us.GetHopDongHienTaiCuaNV(ip_id_nv);
        }

        private void ket_thuc_hop_dong_cu(decimal ip_id_hop_dong, DateTime ip_dat_ngay_ket_thuc)
        {
            US_GD_HOP_DONG v_us = new US_GD_HOP_DONG(ip_id_hop_dong);
            v_us.datNGAY_KET_THUC = ip_dat_ngay_ket_thuc;
            v_us.Update();
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

                    //decimal v_id_hop_dong = get_id_hop_dong_hien_tai(v_us_gd_hd.dcID_NHAN_VIEN.ToString());

                    //
                    v_us_gd_hd.BeginTransaction();
                    //if (v_id_hop_dong != 0)
                    //{
                    //    ket_thuc_hop_dong_cu(v_id_hop_dong, v_us_gd_hd.datNGAY_BAT_DAU);
                    //}
                    v_us_gd_cong_tac.UseTransOfUSObject(v_us_gd_hd);
                    //v_us_gd_cong_tac.CapNhatHetHieuLucCongTac(v_us_gd_hd.dcID_NHAN_VIEN, v_us_gd_hd.datNGAY_BAT_DAU);
                    v_us_gd_hs_lns.UseTransOfUSObject(v_us_gd_hd);
                    //v_us_gd_hs_lns.KetThucLuongNangSuatNhanVien(v_us_gd_hd.dcID_NHAN_VIEN, v_us_gd_hd.datNGAY_BAT_DAU);
                    v_us_gd_hs_lns.Insert();
                    v_us_gd_hd.Insert();
                    v_us_gd_cong_tac.Insert();
                    v_us_gd_hd.CommitTransaction();
                }
                CHRM_BaseMessages.MsgBox_Infor("Đã lưu dữu liệu thành công");
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

        #endregion

        #region Display

        private void xuat_excel()
        {
            XlsxExportOptions opt = new XlsxExportOptions();
            opt.SheetName = "NHAP_HOP_DONG";
            opt.TextExportMode = TextExportMode.Value;
            string path = WinFormControls.saveFileDialog("HOP_DONG");
            if (!String.IsNullOrEmpty(path))
            {
                m_grv_hop_dong.ExportToXlsx(path, opt);
                var excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = true;
                Microsoft.Office.Interop.Excel.Workbooks books = excel.Workbooks;
                Microsoft.Office.Interop.Excel.Workbook openexcel = books.Open(path);
            }
        }

        private void show_ket_qua()
        {
            f325_lap_hop_dong_V2 v_f = new f325_lap_hop_dong_V2();
            //v_f.display_ket_qua_import_excel();
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
            m_grv_hop_dong.RowCellStyle += M_grv_hop_dong_RowCellStyle;
            m_grc_hop_dong.DataSourceChanged += M_grc_hop_dong_DataSourceChanged;
            m_tooltip_controller.GetActiveObjectInfo += M_tooltip_controller_GetActiveObjectInfo;
        }

        private void M_tooltip_controller_GetActiveObjectInfo(object sender, ToolTipControllerGetActiveObjectInfoEventArgs e)
        {
            try
            {
                if (m_list_vi_tri_sai.Count == 0)
                {
                    return;
                }
                ToolTipControlInfo info = null;
                //Get the view at the current mouse position
                GridView view = m_grc_hop_dong.GetViewAt(e.ControlMousePosition) as GridView;
                if (view == null) return;
                //Get the view's element information that resides at the current position
                GridHitInfo hi = view.CalcHitInfo(e.ControlMousePosition);
                //Display a hint for row indicator cells
                if (hi.HitTest == GridHitTest.RowCell)
                {
                    //An object that uniquely identifies a row indicator cell
                    foreach (var item in m_list_vi_tri_sai)
                    {
                        if (hi.RowHandle == item.chi_so_hang & hi.Column.VisibleIndex == item.chi_so_cot)
                        {
                            object o = hi.HitTest.ToString() + hi.RowHandle.ToString() + hi.Column.VisibleIndex.ToString();
                            info = new ToolTipControlInfo(o, item.loi_sai);
                        }
                    }
                }
                if (hi.HitTest == GridHitTest.Column)
                {
                    if (co_ma_nhan_vien_trung & hi.Column.VisibleIndex == 1)
                    {
                        object o = hi.HitTest.ToString() + hi.RowHandle.ToString() + hi.Column.VisibleIndex.ToString();
                        info = new ToolTipControlInfo(o, "Mã nhân viên bị trùng");
                    }
                    if (co_ma_hop_dong_trung & hi.Column.VisibleIndex == 2)
                    {
                        object o = hi.HitTest.ToString() + hi.RowHandle.ToString() + hi.Column.VisibleIndex.ToString();
                        info = new ToolTipControlInfo(o, "Mã hợp đồng bị trùng");
                    }
                }
                //Supply tooltip information if applicable, otherwise preserve default tooltip (if any)
                if (info != null)
                    e.Info = info;
            }
            catch (Exception ve)
            {
                set_init_form_load();
                CSystemLog_301.ExceptionHandle(ve);
            }
        }

        private void M_grc_hop_dong_DataSourceChanged(object sender, EventArgs e)
        {
            try
            {
                if (m_grc_hop_dong.DataSource == null)
                {
                    m_lbl_thong_bao.Text = "Chưa có dữ liệu";
                    m_lbl_thong_bao.ForeColor = Color.Red;
                    m_cmd_save.Enabled = false;
                    return;
                }
                m_cmd_xuat_excel.Enabled = true;
                m_lbl_thong_bao.Text = "Đang kiểm tra dữ liệu...";
                m_lbl_thong_bao.ForeColor = Color.Green;
                if (!check_grid_data_ok())
                {
                    m_lbl_thong_bao.Text = "Chọn trích xuất để sửa thông tin sau đó chọn lại file";
                    m_lbl_thong_bao.ForeColor = Color.Red;
                    return;
                }
                m_lbl_thong_bao.Text = "Dữ liệu đã sẵn sàng nhập";
                m_lbl_thong_bao.ForeColor = Color.Green;
                m_cmd_save.Enabled = true;
            }
            catch (Exception v_e)
            {
                set_init_form_load();
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void M_grv_hop_dong_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            try
            {
                if (m_list_vi_tri_sai.Count == 0)
                {
                    e.Appearance.BackColor = Color.White;
                }
                foreach (var item in m_list_vi_tri_sai)
                {
                    if (item.chi_so_hang == e.RowHandle & item.chi_so_cot == e.Column.VisibleIndex)
                    {
                        e.Appearance.BackColor = Color.Red;
                    }
                }
                if (co_ma_hop_dong_trung & e.Column.VisibleIndex == 2)
                {
                    e.Column.AppearanceHeader.BackColor = Color.Red;
                }
                if (co_ma_nhan_vien_trung & e.Column.VisibleIndex == 1)
                {
                    e.Column.AppearanceHeader.BackColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                set_init_form_load();
                CSystemLog_301.ExceptionHandle(ex);
            }
        }

        private void M_cmd_xuat_excel_Click(object sender, EventArgs e)
        {
            try
            {
                m_lbl_thong_bao.Text = "File sẽ mở lên ngay sau đây";
                m_lbl_thong_bao.ForeColor = Color.Green;
                xuat_excel();
            }
            catch (Exception v_e)
            {
                set_init_form_load();
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
                    //show_ket_qua();
                    m_lbl_thong_bao.Text = "Đã lưu dữ liệu thành công!";
                    m_lbl_thong_bao.ForeColor = Color.Green;
                    set_init_form_load();
                }
            }
            catch (Exception v_e)
            {
                set_init_form_load();
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
            catch (Exception v_e)
            {
                set_init_form_load();
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void M_cmd_chon_file_Click(object sender, EventArgs e)
        {
            try
            {
                m_list_vi_tri_sai = new List<ViTriTrenLuoi>();
                co_ma_nhan_vien_trung = co_ma_hop_dong_trung = false;
                m_lbl_thong_bao.Text = "Đang đọc dữ liệu từ file...";
                m_lbl_thong_bao.ForeColor = Color.Green;

                OpenFileDialog opf = new OpenFileDialog();
                opf.Filter = "Office Files|*.xlsx;*.xls;";
                opf.Multiselect = false;
                if (opf.ShowDialog() == DialogResult.OK)
                {
                    m_file_path = opf.FileName;
                    if (String.IsNullOrEmpty(m_file_path))
                    {
                        return;
                    }
                    load_data_from_file_to_grid(m_file_path);
                }
                else
                {
                    m_lbl_thong_bao.Text = "";
                    m_grc_hop_dong.Refresh();
                    return;
                }
            }
            catch (Exception v_e)
            {
                set_init_form_load();
                //CSystemLog_301.ExceptionHandle(v_e);
                DevExpress.XtraEditors.XtraMessageBox.Show("Vui lòng chọn đúng file exel mẫu để lập hợp đồng!");
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
                set_init_form_load();
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        #endregion
    }
}
