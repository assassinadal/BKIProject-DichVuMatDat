using BKI_DichVuMatDat.US;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BKI_DichVuMatDat.DTO
{
    public class DTO_THONG_TIN_BANG_LUONG
    {
        public DTO_THONG_TIN_BANG_LUONG()
        {

        }
        public DTO_THONG_TIN_BANG_LUONG(decimal ip_i_thang, decimal ip_i_nam)
        {
            THANG = ip_i_thang;
            NAM = ip_i_nam;
            lay_thong_tin_bang_luong();
        }
        public decimal THANG { get; set; }
        public decimal NAM { get; set; }
        public bool CO_DU_LIEU_LUONG { get; set; }
        public decimal SO_LUONG_NHAN_VIEN_CAN_TINH { get; set; }
        public decimal SO_LUONG_NHAN_VIEN_DA_TINH { get; set; }
        public bool CHOT_BANG_LUONG { get; set; }
        private void lay_thong_tin_bang_luong()
        {
            decimal v_dc_so_luong_nhan_vien_can_tinh;
            decimal v_dc_so_luong_nhan_vien_da_tinh;
            bool v_bol_co_du_lieu_chua;
            bool v_bol_chot_bang_luong;
            US_RPT_LUONG_V2 v_us_luong_v2 = new US_RPT_LUONG_V2();
            v_us_luong_v2.LayTrangThaiBangLuong(THANG
                                                        , NAM
                                                        , out v_dc_so_luong_nhan_vien_can_tinh
                                                        , out v_dc_so_luong_nhan_vien_da_tinh
                                                        , out v_bol_co_du_lieu_chua
                                                        , out v_bol_chot_bang_luong);

            CO_DU_LIEU_LUONG = v_bol_co_du_lieu_chua;
            SO_LUONG_NHAN_VIEN_DA_TINH = v_dc_so_luong_nhan_vien_da_tinh;
            SO_LUONG_NHAN_VIEN_CAN_TINH = v_dc_so_luong_nhan_vien_can_tinh;
            CHOT_BANG_LUONG = v_bol_chot_bang_luong;
        }
    }
}
