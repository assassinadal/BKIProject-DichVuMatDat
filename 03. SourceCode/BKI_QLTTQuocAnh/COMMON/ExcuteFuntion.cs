using IP.Core.IPUserService;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BKI_DichVuMatDat.COMMON
{
    public class ExecuteFuntion
    {
        public static string ExecuteFuntionSql(string ip_str_funtion_name, params object[] parameters)
        {
            string v_str_select = "select dbo." + ip_str_funtion_name;
            string v_str_param = "";
            foreach(object item in parameters)
            {
                v_str_param = v_str_param + "'" + item.ToString()+ "'" + ",";
            }
            string v_query = v_str_select + "(" + v_str_param;
            if(parameters.Length > 0)
            {
                v_query = v_query.Substring(0, v_query.LastIndexOf(","));
            }
            v_query = v_query + ")";
            CStoredProc v_sp = new CStoredProc("pr_execute_funtion_sql");
            v_sp.addNVarcharInputParam("@ip_str_query", v_query);

            DataSet v_ds = new DataSet();
            v_ds.Tables.Add();
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            v_sp.fillDataSetByCommand(v_us, v_ds);

            return v_ds.Tables[0].Rows[0][0].ToString();
        }
        public static decimal GetID_GD_HS_LNS_LCDByID_HOP_DONG(decimal ip_dc_id_hop_dong_hien_tai)
        {
            var v_str_result = ExecuteFuntionSql("fn_HD_id_gd_hs_lns_lcd_Get", ip_dc_id_hop_dong_hien_tai);
            return Convert.ToDecimal(v_str_result);
        }

        public static decimal GetSoHoSoNext(decimal ip_dc_id_don_vi, decimal ip_dc_id_chuc_vu, decimal ip_dc_id_nhan_vien)
        {
            var v_str_result = ExecuteFuntionSql("fn_NV_so_ho_so_Next", ip_dc_id_chuc_vu, ip_dc_id_don_vi, ip_dc_id_nhan_vien);
            return Convert.ToDecimal(v_str_result);
        }

        public static bool KiemTraNhanVienCoTrongBangLuongChua(string ip_str_ma_nhan_vien, decimal ip_dc_thang, decimal ip_dc_nam)
        {
            var v_str_result = ExecuteFuntionSql("fn_kiem_tra_nhan_vien_co_trong_bang_luong_chua", ip_str_ma_nhan_vien, ip_dc_thang, ip_dc_nam);
            if(v_str_result == "Y")
            {
                return true;
            }
            else if(v_str_result == "N")
            {
                return false;
            }
            else
            {
                throw new Exception();
            }
        }
        public static bool KiemTraNhanVienCoTrongCsdlChua(string ip_str_ma_nv)
        {
            var v_str_result = ExecuteFuntionSql("fn_kiem_tra_nhan_vien_co_trong_csdl_chua", ip_str_ma_nv);
            if(v_str_result == "Y")
            {
                return true;
            }
            else if(v_str_result == "N")
            {
                return false;
            }
            else
            {
                throw new Exception("Kiểm tra nhân viên có trong csdl chưa bị lỗi tầng CSDL");
            }
        }
        public static decimal LayNhanVienID(string ip_str_ma_nv)
        {
            var v_str_result = ExecuteFuntionSql("fn_get_id_nhan_vien", ip_str_ma_nv);
            var v_dc_result = Convert.ToDecimal(v_str_result);

            return v_dc_result;
        }
        public static string LayMaNhanVien(decimal ip_dc_id_nhan_vien)
        {
            var v_str_result = ExecuteFuntionSql("FN_GET_MA_NHAN_VIEN", ip_dc_id_nhan_vien);

            return v_str_result;
        }
        public static bool IsLockBangLuong(decimal ip_dc_thang, decimal ip_dc_nam)
        {
            var v_str_result = ExecuteFuntionSql("fn_TL_infor_lock_bang_luong_Get", ip_dc_thang, ip_dc_nam);
            var v_bol_result = v_str_result == "Y" ? true : false;

            return v_bol_result;
        }

        public static decimal LayMaNhanVienTiepTheo()
        {
            var v_str_result = ExecuteFuntionSql("FN_NS_GEN_MA_NV_NEXT");
            var v_dc_result = Convert.ToDecimal(v_str_result);

            return v_dc_result;
        }
        public static bool KiemTraNhanVienCoCongTac(decimal ip_dc_id_nhan_vien)
        {
            var v_str_result = ExecuteFuntionSql("fn_CT_kiem_tra_nhan_vien_co_cong_tac", ip_dc_id_nhan_vien);

            if(v_str_result == "Y")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool KiemTraPhuCapForUpdate(decimal ip_dc_id_gd_phu_cap, decimal ip_dc_id_nhan_vien, string DA_XOA)
        {
            var v_str_result = ExecuteFuntionSql("fn_PCTN_kiem_tra_phu_cap_for_update",ip_dc_id_gd_phu_cap, ip_dc_id_nhan_vien, DA_XOA);

            if(v_str_result == "Y")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool KiemTraPhuCapForInsert(decimal ip_dc_id_nhan_vien)
        {
            var v_str_result = ExecuteFuntionSql("fn_PCTN_kiem_tra_phu_cap_for_insert", ip_dc_id_nhan_vien);

            if(v_str_result == "Y")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
