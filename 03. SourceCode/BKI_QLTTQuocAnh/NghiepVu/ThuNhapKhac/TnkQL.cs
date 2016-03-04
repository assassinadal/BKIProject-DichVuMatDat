using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public DataTable HienThiDanhSachQuy(DateTime ip_dat_ngay_lap_min, DateTime ip_dat_ngay_lap_max)
        {
            return new DataTable();
        }
        #region Private Method
        
        #endregion
    }
}
