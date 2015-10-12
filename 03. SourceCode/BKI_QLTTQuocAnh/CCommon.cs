using System;
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
    class CCommon
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
            col.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            ip_grv.CustomUnboundColumnData += ip_grv_CustomUnboundColumnData;
        }

        static void ip_grv_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.IsGetData)
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

            if (v_dr.Count() == 0)
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

            if (v_dr.Count() == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
