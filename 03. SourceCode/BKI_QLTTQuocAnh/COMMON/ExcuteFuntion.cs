using IP.Core.IPUserService;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BKI_DichVuMatDat.COMMON
{
    public class ExcuteFuntion
    {
        public static string ExecuteFuntionSql(string ip_str_funtion_name, params object[] parameters)
        {
            string v_str_select = "select dbo." + ip_str_funtion_name;
            string v_str_param = "";
            foreach(object item in parameters)
            {
                v_str_param = v_str_param + item.ToString() + ",";
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
        public static bool KiemTraNhanVienCoTrongBangLuongChua(decimal ip_dc_id_nhan_vien, decimal ip_dc_thang, decimal ip_dc_nam)
        {
            var v_str_result = ExecuteFuntionSql("fn_kiem_tra_nhan_vien_co_trong_bang_luong_chua", ip_dc_id_nhan_vien, ip_dc_thang, ip_dc_nam);
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
    }
}
