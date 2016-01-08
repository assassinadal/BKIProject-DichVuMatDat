using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IP.Core.IPUserService;
using BKI_DichVuMatDat.DS;

namespace BKI_DichVuMatDat.US
{
    public class US_BAO_CAO_THAM_SO_BANG_LUONG: US_Object
    {
        public void GetThamSoBangLuongThang(DS_BAO_CAO_THAM_SO_BANG_LUONG ip_ds, decimal ip_dec_thang, decimal ip_dec_nam)
        {
            CStoredProc v_sp = new CStoredProc("PR_GET_THAM_SO_BANG_LUONG");
            v_sp.addDecimalInputParam("@THANG", ip_dec_thang);
            v_sp.addDecimalInputParam("@NAM", ip_dec_nam);
            v_sp.fillDataSetByCommand(this, ip_ds);
        }
    }
}
