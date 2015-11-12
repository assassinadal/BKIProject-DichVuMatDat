﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using BKI_DichVuMatDat.DS;
using BKI_DichVuMatDat.DS.CDBNames;
using BKI_DichVuMatDat.US;
using IP.Core.IPCommon;
using System.Windows.Forms;

namespace BKI_DichVuMatDat
{
    class CHRMCommon
    {
        /// <summary>
        /// Trả về danh sách các nhân viên được quyền chọn theo user người sử dụng
        /// </summary>
        /// <param name="ip_id_user"></param>
        /// 
        public static void make_stt(DevExpress.XtraGrid.Views.Grid.GridView ip_grv)
        {
            var col = ip_grv.Columns.Add();
            col.FieldName = "STT";
            col.Caption = "STT";
            col.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            ip_grv.CustomUnboundColumnData += ip_grv_CustomUnboundColumnData;
        }
        public static void make_stt(int ip_col_index, DevExpress.XtraGrid.Views.Grid.GridView ip_grv)
        {
            var col = ip_grv.Columns[ip_col_index];
            col.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            ip_grv.CustomUnboundColumnData += ip_grv_CustomUnboundColumnData;
        }
        static void ip_grv_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if(e.IsGetData)
                e.Value = e.ListSourceRowIndex + 1;
        }

        public static void format_text_2_money(TextBox ip_m_txt)
        {
            decimal v_so_tien = 0;
            v_so_tien = CIPConvert.ToDecimal(ip_m_txt.Text.Trim());
            ip_m_txt.Text = string.Format("{0:#,##0}", v_so_tien);
        }

        public static bool thang_da_chot_bang_luong(DateTime ip_dat)
        {
            DS_GD_CHOT_BANG_LUONG v_ds = new DS_GD_CHOT_BANG_LUONG();
            US_GD_CHOT_BANG_LUONG v_us = new US_GD_CHOT_BANG_LUONG();
            v_us.FillDataset(v_ds);

            string v_str_filter = "THANG = " + ip_dat.Month + " AND NAM = " + ip_dat.Year;

            DataRow[] v_dr = v_ds.GD_CHOT_BANG_LUONG.Select(v_str_filter);

            if(v_dr.Count() == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool thang_da_chot_bang_luong(decimal ip_dc_thang, decimal ip_dc_nam)
        {
            DS_GD_CHOT_BANG_LUONG v_ds = new DS_GD_CHOT_BANG_LUONG();
            US_GD_CHOT_BANG_LUONG v_us = new US_GD_CHOT_BANG_LUONG();
            v_us.FillDataset(v_ds);

            string v_str_filter = "THANG = " + ip_dc_thang + " AND NAM = " + ip_dc_nam;

            DataRow[] v_dr = v_ds.GD_CHOT_BANG_LUONG.Select(v_str_filter);

            if(v_dr.Count() == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        #region Tinh bang luong
        public static DataRow get_luong_1_nhan_vien(decimal ip_dc_id_nhan_vien, int ip_int_thang, int ip_int_nam)
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillBangLuong(v_ds, ip_dc_id_nhan_vien, ip_int_thang, ip_int_nam);
            DataRow v_dr = v_ds.Tables[0].Rows[0];
            return v_dr;
        }
        public static DataRow get_thong_tin_tong_hop_1_nhan_vien(decimal ip_dc_id_nhan_vien, int ip_int_thang, int ip_int_nam)
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillThongTinTongHopNhanVien(v_ds, ip_dc_id_nhan_vien, ip_int_thang, ip_int_nam);
            DataRow v_dr = v_ds.Tables[0].Rows[0];
            return v_dr;
        }
        public static DataRow get_dr(DataRow ip_dr_luong_nv, DataRow ip_dr_luong, decimal ip_id_nv, int ip_index, int ip_thang, int ip_nam)
        {
            ip_dr_luong_nv[RPT_LUONG.ID] = ip_index;
            ip_dr_luong_nv[RPT_LUONG.ID_NHAN_VIEN] = ip_id_nv;
            ip_dr_luong_nv[RPT_LUONG.THANG] = ip_thang;
            ip_dr_luong_nv[RPT_LUONG.NAM] = ip_nam;
            ip_dr_luong_nv[RPT_LUONG.MA_NV] = ip_dr_luong[RPT_LUONG.MA_NV];
            ip_dr_luong_nv[RPT_LUONG.LUONG_NS] = ip_dr_luong[RPT_LUONG.LUONG_NS];
            ip_dr_luong_nv[RPT_LUONG.LUONG_CD] = ip_dr_luong[RPT_LUONG.LUONG_CD];
            ip_dr_luong_nv[RPT_LUONG.PHU_CAP_TN] = ip_dr_luong[RPT_LUONG.PHU_CAP_TN];
            ip_dr_luong_nv[RPT_LUONG.AN_CA] = ip_dr_luong[RPT_LUONG.AN_CA];
            ip_dr_luong_nv[RPT_LUONG.LAM_THEM] = ip_dr_luong[RPT_LUONG.LAM_THEM];
            ip_dr_luong_nv[RPT_LUONG.LAM_THEM_LE_TET] = ip_dr_luong[RPT_LUONG.LAM_THEM_LE_TET];
            ip_dr_luong_nv[RPT_LUONG.LUONG_KHAC_THUE_5] = ip_dr_luong[RPT_LUONG.LUONG_KHAC_THUE_5];
            ip_dr_luong_nv[RPT_LUONG.LUONG_KHAC_THUE_10] = ip_dr_luong[RPT_LUONG.LUONG_KHAC_THUE_10];
            ip_dr_luong_nv[RPT_LUONG.LUONG_KHAC_THUE_TINH_THEO_LUONG] = ip_dr_luong[RPT_LUONG.LUONG_KHAC_THUE_TINH_THEO_LUONG];
            ip_dr_luong_nv[RPT_LUONG.THU_NHAP] = ip_dr_luong[RPT_LUONG.THU_NHAP];
            ip_dr_luong_nv[RPT_LUONG.BHXH] = ip_dr_luong[RPT_LUONG.BHXH];
            ip_dr_luong_nv[RPT_LUONG.BHYT] = ip_dr_luong[RPT_LUONG.BHYT];
            ip_dr_luong_nv[RPT_LUONG.BHTN] = ip_dr_luong[RPT_LUONG.BHTN];
            ip_dr_luong_nv[RPT_LUONG.DOAN_PHI_CD] = ip_dr_luong[RPT_LUONG.DOAN_PHI_CD];
            ip_dr_luong_nv[RPT_LUONG.THUE] = ip_dr_luong[RPT_LUONG.THUE];
            ip_dr_luong_nv[RPT_LUONG.THUE_TU_LUONG_KHAC_5] = ip_dr_luong[RPT_LUONG.THUE_TU_LUONG_KHAC_5];
            ip_dr_luong_nv[RPT_LUONG.THUE_TU_LUONG_KHAC_10] = ip_dr_luong[RPT_LUONG.THUE_TU_LUONG_KHAC_10];
            ip_dr_luong_nv[RPT_LUONG.PHAI_NOP] = ip_dr_luong[RPT_LUONG.PHAI_NOP];
            ip_dr_luong_nv[RPT_LUONG.THUC_LINH] = ip_dr_luong[RPT_LUONG.THUC_LINH];
            ip_dr_luong_nv[RPT_LUONG.TRUY_LINH] = ip_dr_luong[RPT_LUONG.TRUY_LINH];
            ip_dr_luong_nv[RPT_LUONG.TRUY_THU] = ip_dr_luong[RPT_LUONG.TRUY_THU];
            ip_dr_luong_nv[RPT_LUONG.THUC_LINH_CUOI_CUNG] = ip_dr_luong[RPT_LUONG.THUC_LINH_CUOI_CUNG];
            return ip_dr_luong_nv;
        }

        public static void DataRow2US(DataRow v_dr_luong_1_nv, US_RPT_LUONG v_us)
        {
            v_us.strMA_NV = v_dr_luong_1_nv[RPT_LUONG.MA_NV].ToString();
            v_us.dcAN_CA = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.AN_CA].ToString());
            v_us.dcBHTN = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.BHTN].ToString());
            v_us.dcBHXH = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.BHXH].ToString());
            v_us.dcBHYT = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.BHYT].ToString());
            v_us.dcDOAN_PHI_CD = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.DOAN_PHI_CD].ToString());
            v_us.dcID_NHAN_VIEN = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.ID_NHAN_VIEN].ToString());
            v_us.dcLAM_THEM = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.LAM_THEM].ToString());
            v_us.dcLAM_THEM_LE_TET = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.LAM_THEM_LE_TET].ToString());
            v_us.dcLUONG_CD = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.LUONG_CD].ToString());
            v_us.dcLUONG_KHAC_THUE_10 = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.LUONG_KHAC_THUE_10].ToString());
            v_us.dcLUONG_KHAC_THUE_5 = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.LUONG_KHAC_THUE_5].ToString());
            v_us.dcLUONG_KHAC_THUE_TINH_THEO_LUONG = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.LUONG_KHAC_THUE_TINH_THEO_LUONG].ToString());
            v_us.dcLUONG_NS = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.LUONG_NS].ToString());
            v_us.dcNAM = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.NAM].ToString());
            v_us.dcPHAI_NOP = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.PHAI_NOP].ToString());
            v_us.dcPHU_CAP_TN = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.PHU_CAP_TN].ToString());
            v_us.dcTHANG = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.THANG].ToString());
            v_us.dcTHU_NHAP = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.THU_NHAP].ToString());
            v_us.dcTHUC_LINH = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.THUC_LINH].ToString());
            v_us.dcTHUC_LINH_CUOI_CUNG = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.THUC_LINH_CUOI_CUNG].ToString());
            v_us.dcTHUE = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.THUE].ToString());
            v_us.dcTHUE_TU_LUONG_KHAC_10 = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.THUE_TU_LUONG_KHAC_10].ToString());
            v_us.dcTHUE_TU_LUONG_KHAC_5 = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.THUE_TU_LUONG_KHAC_5].ToString());
            v_us.dcTRUY_LINH = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.TRUY_LINH].ToString());
            v_us.dcTRUY_THU = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.TRUY_THU].ToString());
        }
        public static void DataRow2USThongTinTongHop(DataRow v_dr_luong_1_nv, US_RPT_THONG_TIN_TONG_HOP v_us)
        {
            //v_us.dcID = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP.ID].ToString());
            v_us.dcTHANG = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP.THANG].ToString());
            v_us.dcNAM = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP.NAM].ToString());
            v_us.dcID_NHAN_VIEN = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP.ID_NHAN_VIEN].ToString());
            v_us.strMA_NV = v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP.MA_NV].ToString();
            v_us.strHO_DEM = v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP.HO_DEM].ToString();
            v_us.strTEN = v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP.TEN].ToString();
            v_us.strHO_VA_TEN =  v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP.HO_VA_TEN].ToString();
            v_us.strTEN_CHUC_VU = v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP.TEN_CHUC_VU].ToString();
            v_us.strTEN_HOP_DONG = v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP.TEN_HOP_DONG].ToString();
            v_us.dcLUONG_CHE_DO_THEO_CHUC_VU = (decimal)v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP.LUONG_CHE_DO_THEO_CHUC_VU];
            v_us.dcHS_LUONG_NANG_SUAT_DUOC_HUONG = (decimal)v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP.HS_LUONG_NANG_SUAT_DUOC_HUONG];
            v_us.strTAI_KHOAN = v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP.TAI_KHOAN].ToString();
            v_us.dcCHAM_CONG_X = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP.CHAM_CONG_X].ToString());
            v_us.dcCHAM_CONG_OM_CO = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP.CHAM_CONG_OM_CO].ToString());
            v_us.dcCHAM_CONG_TS = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP.CHAM_CONG_TS].ToString());
            v_us.dcCHAM_CONG_TNLD = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP.CHAM_CONG_TNLD].ToString());
            v_us.dcCHAM_CONG_PHEP_DIDUONG = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP.CHAM_CONG_PHEP_DIDUONG].ToString());
            v_us.dcCHAM_CONG_RO_KO_DC = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP.CHAM_CONG_RO_KO_DC].ToString());
            v_us.dcCHAM_CONG_KHAC = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP.CHAM_CONG_KHAC].ToString());
        }
        public static void insertLuongNV2RPT(DataRow v_dr_luong_1_nv)
        {
            US_RPT_LUONG v_us = new US_RPT_LUONG();
            DataRow2US(v_dr_luong_1_nv, v_us);
            v_us.Insert();
        }
        public static void insertThongTinTongHopNV2RPT(DataRow v_dr_luong_1_nv)
        {
            US_RPT_THONG_TIN_TONG_HOP v_us = new US_RPT_THONG_TIN_TONG_HOP();
            DataRow2USThongTinTongHop(v_dr_luong_1_nv, v_us);
            v_us.Insert();
        }
        public static void update_luong_1NV_2_rpt(int ip_id_rpt_luong, DataRow v_dr_luong_1_nv)
        {
            US_RPT_LUONG v_us = new US_RPT_LUONG(ip_id_rpt_luong);
            DataRow2US(v_dr_luong_1_nv, v_us);
            v_us.Update();
        }
        #endregion
    }
}
