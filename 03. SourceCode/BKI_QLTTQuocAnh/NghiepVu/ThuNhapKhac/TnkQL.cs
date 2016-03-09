using BKI_DichVuMatDat.DS.CDBNames;
using BKI_DichVuMatDat.DTO;
using BKI_DichVuMatDat.US;
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

        public DataTable LayChiTietQuy(decimal ip_dc_id_quy_thu_nhap_khac)
        {
            return create_data_chi_tiet_quy(ip_dc_id_quy_thu_nhap_khac);
        }
        public DTO_QUY_THU_NHAP_KHAC LayThongTinQuy(decimal ip_dc_id_quy_thu_nhap_khac)
        {
            return create_dto_quy_thu_nhap_khac(ip_dc_id_quy_thu_nhap_khac);
        }

        #region Private Method
        private DTO_QUY_THU_NHAP_KHAC create_dto_quy_thu_nhap_khac(decimal ip_dc_id_quy_thu_nhap_khac)
        {
            DTO_QUY_THU_NHAP_KHAC v_dto_quy = new DTO_QUY_THU_NHAP_KHAC();

            //Lay du lieu tu Db
            US_GD_QUY_THU_NHAP_KHAC v_us_quy = new US_GD_QUY_THU_NHAP_KHAC();
            DataRow v_dr_quy = v_us_quy.LayThongTinQuyThuNhapKhac(ip_dc_id_quy_thu_nhap_khac);

            //Chuyen doi du lieu sang dto
            v_dto_quy.CO_DU_LIEU = v_dr_quy[V_TNK_GD_QUY_THU_NHAP_KHAC.CO_DU_LIEU].ToString() == "Y" ? true : false;
            v_dto_quy.DA_XOA = v_dr_quy[V_TNK_GD_QUY_THU_NHAP_KHAC.DA_XOA].ToString();
            v_dto_quy.NGUOI_LAP = v_dr_quy[V_TNK_GD_QUY_THU_NHAP_KHAC.NGUOI_LAP].ToString();
            v_dto_quy.NGUOI_LAP_PHAN_MEM = v_dr_quy[V_TNK_GD_QUY_THU_NHAP_KHAC.NGUOI_LAP_PHAN_MEM].ToString();
            v_dto_quy.GHI_CHU = v_dr_quy[V_TNK_GD_QUY_THU_NHAP_KHAC.GHI_CHU].ToString();
            v_dto_quy.LY_DO_THUONG = v_dr_quy[V_TNK_GD_QUY_THU_NHAP_KHAC.LY_DO_THUONG].ToString();
            v_dto_quy.TEN_QUY = v_dr_quy[V_TNK_GD_QUY_THU_NHAP_KHAC.TEN_QUY].ToString();
        
            v_dto_quy.NGAY_LAP = v_dr_quy[V_TNK_GD_QUY_THU_NHAP_KHAC.NGAY_LAP] == DBNull.Value ? (DateTime?) null : Convert.ToDateTime(v_dr_quy[V_TNK_GD_QUY_THU_NHAP_KHAC.NGAY_LAP]);
            v_dto_quy.NGAY_LAP_PHAN_MEM = v_dr_quy[V_TNK_GD_QUY_THU_NHAP_KHAC.NGAY_LAP_PHAN_MEM] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(v_dr_quy[V_TNK_GD_QUY_THU_NHAP_KHAC.NGAY_LAP_PHAN_MEM]);
            v_dto_quy.TU_NGAY_XET_THUONG = v_dr_quy[V_TNK_GD_QUY_THU_NHAP_KHAC.TU_NGAY_XET_THUONG] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(v_dr_quy[V_TNK_GD_QUY_THU_NHAP_KHAC.TU_NGAY_XET_THUONG]);
            v_dto_quy.DEN_NGAY_XET_THUONG = v_dr_quy[V_TNK_GD_QUY_THU_NHAP_KHAC.DEN_NGAY_XET_THUONG] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(v_dr_quy[V_TNK_GD_QUY_THU_NHAP_KHAC.DEN_NGAY_XET_THUONG]);
            
            v_dto_quy.ID = Convert.ToDecimal(v_dr_quy[V_TNK_GD_QUY_THU_NHAP_KHAC.ID]);
            v_dto_quy.ID_LOAI_THU_NHAP_KHAC = Convert.ToDecimal(v_dr_quy[V_TNK_GD_QUY_THU_NHAP_KHAC.ID_LOAI_QUY_THU_NHAP_KHAC]);
            v_dto_quy.THANG = Convert.ToDecimal(v_dr_quy[V_TNK_GD_QUY_THU_NHAP_KHAC.THANG]);
            v_dto_quy.NAM = Convert.ToDecimal(v_dr_quy[V_TNK_GD_QUY_THU_NHAP_KHAC.NAM]);
            v_dto_quy.SO_LUONG_NV_TRONG_QUY = Convert.ToDecimal(v_dr_quy[V_TNK_GD_QUY_THU_NHAP_KHAC.SO_LUONG_NV_TRONG_QUY]);
            v_dto_quy.TONG_TIEN = Convert.ToDecimal(v_dr_quy[V_TNK_GD_QUY_THU_NHAP_KHAC.TONG_TIEN]);
            v_dto_quy.TONG_TIEN_NOP_THUE = Convert.ToDecimal(v_dr_quy[V_TNK_GD_QUY_THU_NHAP_KHAC.TONG_TIEN_NOP_THUE]);
            v_dto_quy.TONG_TIEN_THUC_LINH = Convert.ToDecimal(v_dr_quy[V_TNK_GD_QUY_THU_NHAP_KHAC.TONG_TIEN_THUC_LINH]);
            return v_dto_quy;
        }
        private DataTable create_data_chi_tiet_quy(decimal ip_dc_id_quy_thu_nhap_khac)
        {
            US_GD_QUY_THU_NHAP_KHAC v_us_quy = new US_GD_QUY_THU_NHAP_KHAC();
            return v_us_quy.LayChiTietQuy(ip_dc_id_quy_thu_nhap_khac);
        }
        #endregion
    }
}
