using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BKI_DichVuMatDat.DS;
using BKI_DichVuMatDat.US;

namespace BKI_DichVuMatDat.NghiepVu.ThuNhapKhac
{
    public class TnkQL
    {
        #region Singleton
        private static TnkQL _instance;
        public static TnkQL Instance
        {
            get
            {
                if(_instance == null)
                    _instance = new TnkQL();
                return _instance;
            }
        }
        #endregion

        public DataTable HienThiDanhSachQuy()
        {
            US_GD_QUY_THU_NHAP_KHAC v_us = new US_GD_QUY_THU_NHAP_KHAC();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetQuyTNK(v_ds);
            return v_ds.Tables[0];
        }
        #region Private Method
        
        #endregion
    }
}
