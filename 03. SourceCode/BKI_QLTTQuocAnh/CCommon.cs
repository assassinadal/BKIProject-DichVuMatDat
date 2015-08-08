using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using BKI_DichVuMatDat.DS;
using BKI_DichVuMatDat.DS.CDBNames;
using BKI_DichVuMatDat.US;

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
    }
}
