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

namespace BKI_DichVuMatDat.NghiepVu.HopDong
{
    public partial class f002_import_hop_dong_v2 : Form
    {

        #region Public Interfaces

        public f002_import_hop_dong_v2()
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
            public const string MA_LOAI_HOP_DONG = "MA_LOAI_HOP_DONG";
            public const string MA_CHUC_DANH_LCD = "MA_CHUC_DANH_LCD";
            public const string MA_MUC_LCD = "MA_MUC_LCD";
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
            MA_LOAI_HOP_DONG = 1,
            MA_NHAN_VIEN = 2,
            MA_CHUC_DANH_LCD = 3,
            MA_MUC_LCD = 4,
            NGAY_BAT_DAU = 5,
            NGAY_KET_THUC = 6,
            NGAY_KI_HOP_DONG = 7,
            MA_LOAI_LAO_DONG = 8,
            MA_DON_VI = 9,
            MA_CHUC_VU = 10
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
            ip_dt_src.Columns[(int)thu_tu_cot.MA_LOAI_HOP_DONG].ColumnName = ExcelHopDong.MA_LOAI_HOP_DONG;
            ip_dt_src.Columns[(int)thu_tu_cot.MA_CHUC_DANH_LCD].ColumnName = ExcelHopDong.MA_CHUC_DANH_LCD;
            ip_dt_src.Columns[(int)thu_tu_cot.MA_MUC_LCD].ColumnName = ExcelHopDong.MA_MUC_LCD;
            ip_dt_src.Columns[(int)thu_tu_cot.MA_DON_VI].ColumnName = ExcelHopDong.MA_DON_VI;
            ip_dt_src.Columns[(int)thu_tu_cot.MA_CHUC_VU].ColumnName = ExcelHopDong.MA_CHUC_VU;
            ip_dt_src.Columns[(int)thu_tu_cot.MA_LOAI_LAO_DONG].ColumnName = ExcelHopDong.MA_LOAI_LAO_DONG;
            ip_dt_src.Columns[(int)thu_tu_cot.NGAY_BAT_DAU].ColumnName = ExcelHopDong.NGAY_BAT_DAU;
            ip_dt_src.Columns[(int)thu_tu_cot.NGAY_KET_THUC].ColumnName = ExcelHopDong.NGAY_KET_THUC;
            ip_dt_src.Columns[(int)thu_tu_cot.NGAY_KI_HOP_DONG].ColumnName = ExcelHopDong.NGAY_KI_HOP_DONG;
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
            DataTable v_dt_source = (DataTable)m_grc_hop_dong.DataSource;
            var v_str_ma_nhan_vien = ip_dr[ExcelHopDong.MA_NHAN_VIEN].ToString();
            var v_count_nv = v_dt_source.AsEnumerable().Count(x => x.Field<string>(ExcelHopDong.MA_NHAN_VIEN) == v_str_ma_nhan_vien);
            bool v_bool = v_count_nv == 1;
            if(!v_bool)
            {
                XtraMessageBox.Show("Mã nhân viên "+v_str_ma_nhan_vien +" bị trùng lặp trong File Excel!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return v_bool;
        }
        //private bool ma_hop_dong_khong_trung_lap(DataRow ip_dr)
        //{
        //    DataTable v_dt_source = (DataTable)m_grc_hop_dong.DataSource;
        //    var v_str_ma_hop_dong = ip_dr[ExcelHopDong.MA_HOP_DONG].ToString();
        //    var v_count_nv = v_dt_source.AsEnumerable().Count(x => x.Field<string>(ExcelHopDong.MA_HOP_DONG) == v_str_ma_hop_dong);
        //    bool v_bool = v_count_nv == 1;
        //    if(!v_bool)
        //    {
        //        XtraMessageBox.Show("Mã hợp đồng " + v_str_ma_hop_dong + " bị trùng lặp trong File Excel!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }
        //    return v_bool;
        //}
        private bool ma_chuc_dung_dinh_dang(DataRow ip_dr)
        {
            var v_str_ma_chuc_vu = ip_dr[ExcelHopDong.MA_CHUC_VU].ToString();
            var v_bool_is_exist = m_dt_chuc_vu.AsEnumerable().Any(x => x.Field<string>(DM_CHUC_VU.MA_CHUC_VU) == v_str_ma_chuc_vu);
            if(!v_bool_is_exist)
            {
                XtraMessageBox.Show("Mã chức vụ của nhân viên " + ip_dr[ExcelHopDong.MA_NHAN_VIEN].ToString() + " bị sai tên!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return v_bool_is_exist;
        }
        private bool ma_don_vi_dung_dinh_dang(DataRow ip_dr)
        {
            var v_str_ma_don_vi = ip_dr[ExcelHopDong.MA_DON_VI].ToString();
            var v_bool_is_exist = m_dt_don_vi.AsEnumerable().Any(x => x.Field<string>(DM_DON_VI.MA_DON_VI) == v_str_ma_don_vi);
            if(!v_bool_is_exist)
            {
                XtraMessageBox.Show("Mã đơn vị của nhân viên " + ip_dr[ExcelHopDong.MA_NHAN_VIEN].ToString() + " bị sai tên!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return v_bool_is_exist;
        }
        private bool ma_loai_hop_dong_dung_dinh_dang(DataRow ip_dr)
        {
            var v_str_ma_loai_hop_dong = ip_dr[ExcelHopDong.MA_LOAI_HOP_DONG].ToString();
            var v_bool_is_exist = m_dt_loai_hop_dong.AsEnumerable().Any(x => x.Field<string>(DM_LOAI_HOP_DONG.MA_LOAI_HOP_DONG) == v_str_ma_loai_hop_dong);
            if(!v_bool_is_exist)
            {
                XtraMessageBox.Show("Mã loại hợp đồng của nhân viên " + ip_dr[ExcelHopDong.MA_NHAN_VIEN].ToString() + " bị sai tên!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return v_bool_is_exist;
        }
        private bool ma_loai_lao_dong_dung_dinh_dang(DataRow ip_dr)
        {
            var v_str_ma_loai_lao_dong = ip_dr[ExcelHopDong.MA_LOAI_LAO_DONG].ToString();
            var v_bool_is_exist = m_dt_loai_lao_dong.AsEnumerable().Any(x => x.Field<string>(CM_DM_TU_DIEN.MA_TU_DIEN) == v_str_ma_loai_lao_dong);
            if(!v_bool_is_exist)
            {
                XtraMessageBox.Show("Mã loại lao động của nhân viên " + ip_dr[ExcelHopDong.MA_NHAN_VIEN].ToString() + " bị sai tên!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return v_bool_is_exist;
        }
        private bool ma_lcd_dung_dinh_dang(DataRow ip_dr)
        {
            if(!is_not_null(ip_dr[ExcelHopDong.MA_CHUC_DANH_LCD]))
            {
                return true;
            }
            var v_str_ma_lcd = ip_dr[ExcelHopDong.MA_CHUC_DANH_LCD].ToString();
            var v_bool_is_exist = m_dt_ma_lcd.AsEnumerable().Any(x => x.Field<string>(CM_DM_TU_DIEN.MA_TU_DIEN) == v_str_ma_lcd);
            if(!v_bool_is_exist)
            {
                XtraMessageBox.Show("Mã LCD của nhân viên " + ip_dr[ExcelHopDong.MA_NHAN_VIEN].ToString() + " bị sai tên!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return v_bool_is_exist;
        }
        private bool muc_lcd_dung_dinh_dang(DataRow ip_dr)
        {
            if(!is_not_null(ip_dr[ExcelHopDong.MA_MUC_LCD]))
            {
                return true;
            }
            var v_str_muc_lcd = ip_dr[ExcelHopDong.MA_MUC_LCD].ToString();
            var v_bool_is_exist = m_dt_muc_lcd.AsEnumerable().Any(x => x.Field<string>(CM_DM_TU_DIEN.MA_TU_DIEN) == v_str_muc_lcd);
            if(!v_bool_is_exist)
            {
                XtraMessageBox.Show("Mức LCD của nhân viên " + ip_dr[ExcelHopDong.MA_NHAN_VIEN].ToString() + " bị sai tên!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return v_bool_is_exist;
        }
        private bool check_not_null(DataRow ip_dr)
        {
            var v_bool_is_null = is_not_null(ip_dr[ExcelHopDong.MA_NHAN_VIEN]
                                           // , ip_dr[ExcelHopDong.MA_HOP_DONG]
                                            , ip_dr[ExcelHopDong.MA_LOAI_HOP_DONG]
                                            , ip_dr[ExcelHopDong.MA_LOAI_LAO_DONG]
                                            , ip_dr[ExcelHopDong.NGAY_BAT_DAU]
                                            , ip_dr[ExcelHopDong.MA_DON_VI]
                                            , ip_dr[ExcelHopDong.MA_CHUC_VU]
                                            );
            if(!v_bool_is_null)
            {
                if(!is_not_null(ip_dr[ExcelHopDong.MA_NHAN_VIEN]))
                {
                    XtraMessageBox.Show("Có mã nhân viên bị trống!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    XtraMessageBox.Show("Dữ liệu của nhân viên " + ip_dr[ExcelHopDong.MA_NHAN_VIEN].ToString() + " có ô bị trống!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            return v_bool_is_null;
        }
        private bool ngay_bat_dau_nho_hon_ngay_ket_thuc(DataRow ip_dr)
        {
            if(ip_dr[ExcelHopDong.NGAY_KET_THUC] == DBNull.Value || ip_dr[ExcelHopDong.NGAY_KET_THUC].ToString() == "")
            {
                return true;
            }
            DateTime v_dat_ngay_bat_dau = Convert.ToDateTime(ip_dr[ExcelHopDong.NGAY_BAT_DAU]);
            DateTime v_dat_ngay_ket_thuc = Convert.ToDateTime(ip_dr[ExcelHopDong.NGAY_KET_THUC]);
            if(v_dat_ngay_bat_dau.Date >= v_dat_ngay_ket_thuc.Date)
            {
                XtraMessageBox.Show("Dòng nhân viên "+ ip_dr[ExcelHopDong.MA_NHAN_VIEN].ToString() +" ngày bắt đầu phải nhỏ hơn ngày kết thúc!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private bool check_chuc_vu_thuoc_don_vi(DataRow ip_dr)
        {
            var v_str_ma_chuc_vu = ip_dr[ExcelHopDong.MA_CHUC_VU].ToString();
            var v_dc_id_don_vi = find_id_don_vi(ip_dr[ExcelHopDong.MA_DON_VI].ToString());
            DataRow v_dt_row_chuc_vu = m_dt_chuc_vu.AsEnumerable().Where(x => x.Field<string>(DM_CHUC_VU.MA_CHUC_VU) == v_str_ma_chuc_vu).FirstOrDefault();
            if(Convert.ToDecimal(v_dt_row_chuc_vu[DM_CHUC_VU.ID_DON_VI]) != v_dc_id_don_vi)
            {
                XtraMessageBox.Show("Dòng nhân viên " + ip_dr[ExcelHopDong.MA_NHAN_VIEN].ToString() + " có chức vụ không thuộc đơn vị. Bạn kiểm tra lại nhé!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if(!muc_lcd_dung_dinh_dang(ip_dr)
                    || !ma_lcd_dung_dinh_dang(ip_dr)
                    || !ma_loai_lao_dong_dung_dinh_dang(ip_dr)
                    || !ma_loai_hop_dong_dung_dinh_dang(ip_dr)
                    //|| !ma_hop_dong_khong_trung_lap(ip_dr)
                    || !ma_nhan_vien_khong_trung_lap(ip_dr)
                    || !ma_don_vi_dung_dinh_dang(ip_dr)
                    || !ma_chuc_dung_dinh_dang(ip_dr)
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
            var is_exist = v_us.IsExistNhanVienInDB(ip_dr[ExcelHopDong.MA_NHAN_VIEN].ToString());
            if(!is_exist)
            {
                XtraMessageBox.Show("Mã nhân viên " + ip_dr[ExcelHopDong.MA_NHAN_VIEN].ToString() + " chưa tồn tại trong hệ thống!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return is_exist;
        }
        //private bool check_ma_hd_chua_ton_tai(DataRow ip_dr)
        //{
        //    US_GD_HOP_DONG v_us = new US_GD_HOP_DONG();
        //    DS_GD_HOP_DONG v_ds = new DS_GD_HOP_DONG();
        //    v_us.FillDataset(v_ds, "where MA_HOP_DONG = '" + ip_dr[ExcelHopDong.MA_HOP_DONG].ToString() + "'");
        //    if(v_ds.Tables[0].Rows.Count != 0)
        //    {
        //        XtraMessageBox.Show("Mã hợp đồng của nhân viên " + ip_dr[ExcelHopDong.MA_NHAN_VIEN].ToString() + " đã có trong hệ thống!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return false;
        //    }
        //    return true;
        //}
        private bool check_thoi_gian_hop_dong_Insert(DataRow ip_dr)
        {
            //Hợp đồng hợp lệ khi trong một khoảng thời gian chỉ có một hợp đồng 
            US_GD_HOP_DONG v_us = new US_GD_HOP_DONG();
            var v_dc_id_nhan_vien = ExecuteFuntion.LayNhanVienID(ip_dr[ExcelHopDong.MA_NHAN_VIEN].ToString());
            var v_dat_ngay_bat_dau = Convert.ToDateTime(ip_dr[ExcelHopDong.NGAY_BAT_DAU]).Date;
            var v_dat_ngay_ket_thuc = ip_dr[ExcelHopDong.NGAY_KET_THUC] == DBNull.Value ? new DateTime(2100, 01, 01).Date : Convert.ToDateTime(ip_dr[ExcelHopDong.NGAY_KET_THUC]);
            var v_bool_hop_le = v_us.KiemTraThoiGianHopDongHopLeForInsert(v_dc_id_nhan_vien, v_dat_ngay_bat_dau, v_dat_ngay_ket_thuc);
            if(!v_bool_hop_le)
            {
                XtraMessageBox.Show("Thời gian hợp đồng của nhân viên " + ip_dr[ExcelHopDong.MA_NHAN_VIEN].ToString() + " không hợp lệ " +
                                        "do đã có hợp đồng trong khoảng thời gian này rồi", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return v_bool_hop_le;
        }
        private bool check_logic_one_row(DataRow ip_dr)
        {
            if(!check_ma_nhan_vien_ton_tai(ip_dr)
                //|| !check_ma_hd_chua_ton_tai(ip_dr)
                || !check_thoi_gian_hop_dong_Insert(ip_dr)
                )
            {
                return false;
            }
            return true;
        }

        private bool check_all_is_ok()
        {
            for(int v_i_cur_row = 0; v_i_cur_row < m_grv_hop_dong.RowCount; v_i_cur_row++)
            {
                var v_dr_cur_row = m_grv_hop_dong.GetDataRow(v_i_cur_row);
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
            m_dt_loai_hop_dong = load_data_to_loai_hd();
            m_dt_loai_lao_dong = load_data_from_tu_dien(CONST_ID_LOAI_TU_DIEN.LOAI_LAO_DONG);
            m_dt_ma_lcd = load_data_from_tu_dien(CONST_ID_LOAI_TU_DIEN.MA_LCD);
            m_dt_muc_lcd = load_data_from_tu_dien(CONST_ID_LOAI_TU_DIEN.MUC_LCD);
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
                ExcelCommand.CommandText = "SELECT * From [" + SheetName + "]";// WHERE [" + ExcelHopDong.MA_NHAN_VIEN + "] IS NOT NULL";
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
                var v_data_table_grv = load_data_from_file_to_data_table(path, "NHAP_HOP_DONG");
                format_data_table(v_data_table_grv);
                m_grc_hop_dong.DataSource = v_data_table_grv;
                m_grv_hop_dong.BestFitColumns();
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
        private void grid_to_us_gd_hop_dong(US_GD_HOP_DONG v_us_gd_hd, DataRow data)
        {
            v_us_gd_hd.dcID_NHAN_VIEN = find_id_nv_by_ma_nv(data[ExcelHopDong.MA_NHAN_VIEN].ToString());
            v_us_gd_hd.dcID_LOAI_HOP_DONG = find_id_loai_hop_dong_by_ma(data[ExcelHopDong.MA_LOAI_HOP_DONG].ToString());
            v_us_gd_hd.dcID_CHUC_VU = find_id_chuc_vu(data[ExcelHopDong.MA_CHUC_VU].ToString());
            v_us_gd_hd.dcID_DON_VI = find_id_don_vi(data[ExcelHopDong.MA_DON_VI].ToString());
            if(!is_not_null(data[ExcelHopDong.MA_CHUC_DANH_LCD]) || !is_not_null(data[ExcelHopDong.MA_MUC_LCD]))
            {
                v_us_gd_hd.SetID_LUONG_CHE_DONull();
                v_us_gd_hd.dcSO_TIEN_LCD = 0;
            }
            else
            {
                v_us_gd_hd.dcID_LUONG_CHE_DO = find_id_lcd_by_ma_lcd(data[ExcelHopDong.MA_CHUC_DANH_LCD].ToString(), data[ExcelHopDong.MA_MUC_LCD].ToString());
                v_us_gd_hd.dcSO_TIEN_LCD = find_so_tien_lcd(find_id_lcd_by_ma_lcd(data[ExcelHopDong.MA_CHUC_DANH_LCD].ToString(), data[ExcelHopDong.MA_MUC_LCD].ToString()));
            }
            
            v_us_gd_hd.dcID_LOAI_LAO_DONG = find_id_tu_dien_by_ma_tu_dien(data[ExcelHopDong.MA_LOAI_LAO_DONG].ToString());
            
            //v_us_gd_hd.strMA_HOP_DONG = data[ExcelHopDong.MA_HOP_DONG].ToString();
            v_us_gd_hd.strNGUOI_LAP = CAppContext_201.getCurrentUserName();
            v_us_gd_hd.datNGAY_BAT_DAU = WinFormControls.FormatPostingDate(data[ExcelHopDong.NGAY_BAT_DAU].ToString());
            if(String.IsNullOrEmpty(data[ExcelHopDong.NGAY_KET_THUC].ToString()))
            {
                v_us_gd_hd.SetNGAY_KET_THUCNull();
            }
            else
            {
                v_us_gd_hd.datNGAY_KET_THUC = WinFormControls.FormatPostingDate(data[ExcelHopDong.NGAY_KET_THUC].ToString());
            }
            if(String.IsNullOrEmpty(data[ExcelHopDong.NGAY_KI_HOP_DONG].ToString()))
            {
                v_us_gd_hd.SetNGAY_KY_HOP_DONGNull();
            }
            else
            {
                v_us_gd_hd.datNGAY_KY_HOP_DONG = WinFormControls.FormatPostingDate(data[ExcelHopDong.NGAY_KI_HOP_DONG].ToString());
            }

            v_us_gd_hd.datNGAY_LAP = DateTime.Now.Date;
        }

        private void save_data()
        {
            if(m_grv_hop_dong.RowCount < 1)
            {
                XtraMessageBox.Show("Chưa có dữ liệu để lưu!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(!check_all_is_ok())
            {
                return;
            }
            SplashScreenManager.ShowForm(this, typeof(SplashScreen1), true, true, false);
            US_GD_HOP_DONG v_us_gd_hd = new US_GD_HOP_DONG();
            int v_i_row = 0;
            try
            {
                for(v_i_row = 0; v_i_row < m_grv_hop_dong.RowCount; v_i_row++)
                {
                    v_us_gd_hd.ClearAllFields();
                    var data = m_grv_hop_dong.GetDataRow(v_i_row);
                    grid_to_us_gd_hop_dong(v_us_gd_hd, data);
                    v_us_gd_hd.BeginTransaction();
                    v_us_gd_hd.Insert();
                    if(!ExecuteFuntion.KiemTraNhanVienCoCongTac(v_us_gd_hd.dcID_NHAN_VIEN))
                    {
                        US_GD_CONG_TAC v_us = new US_GD_CONG_TAC();
                        v_us.dcID_DON_VI = v_us_gd_hd.dcID_DON_VI;
                        v_us.dcID_LOAI_CONG_TAC = CONST_ID_LOAI_CONG_TAC.CHINH_THUC;
                        v_us.dcID_NHAN_VIEN = v_us_gd_hd.dcID_NHAN_VIEN;
                        v_us.dcID_VI_TRI = v_us_gd_hd.dcID_CHUC_VU;
                        v_us.dcSO_HO_SO = ExecuteFuntion.GetSoHoSoNext(v_us_gd_hd.dcID_DON_VI, v_us_gd_hd.dcID_CHUC_VU, v_us_gd_hd.dcID_NHAN_VIEN);
                        v_us.strDA_XOA = "N";
                        v_us.strNGUOI_LAP = CAppContext_201.getCurrentUserName();
                        v_us.datNGAY_LAP = DateTime.Now.Date;
                        v_us.datNGAY_BAT_DAU = v_us_gd_hd.datNGAY_BAT_DAU;
                        v_us.UseTransOfUSObject(v_us_gd_hd);
                        v_us.Insert();
                    }
                    v_us_gd_hd.CommitTransaction();
                    SplashScreenManager.Default.SendCommand(SplashScreen1.SplashScreenCommand.SetProgress, (int)((decimal)v_i_row / (decimal)m_grv_hop_dong.RowCount * 100));
                }
                
                CHRM_BaseMessages.MsgBox_Infor("Đã lưu dữ liệu thành công");
            }
            catch(Exception)
            {
                if(v_us_gd_hd.is_having_transaction())
                {
                    v_us_gd_hd.Rollback();
                }
                if(v_i_row >= 1)
                {
                    throw new Exception("Có lỗi xảy ra. Dữ liệu lưu chưa thành công!\nĐã lưu thành công đến dòng thứ " + v_i_row + " với mã nhân viên " + m_grv_hop_dong.GetRowCellValue(v_i_row - 1, ExcelHopDong.MA_NHAN_VIEN).ToString());
                }
                else
                {
                    throw new Exception("Có lỗi xảy ra. Dữ liệu lưu chưa được lưu!");
                }
            }
            finally
            {
                SplashScreenManager.CloseForm(false);
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
