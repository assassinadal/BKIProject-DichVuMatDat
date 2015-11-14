using System;
using System.Collections.Generic;
using System.Text;

namespace BKI_DichVuMatDat.US
{
    public class CONST_ID_LOAI_CACH_TINH_THUE
    {
        public const decimal THUE_5PT = 167;
        public const decimal THUE_10PT = 168;
        public const decimal THUE_THANG = 169;
    }

    public class CONST_ID_LOAI_THU_NHAP_KHAC
    {
        public const decimal LINH_CO_THUE = 175;
    }

    public class CONST_ID_LOAI_HOP_DONG
    {
        public const decimal HOP_DONG_HOC_VIEC = 4;
        public const decimal HOP_DONG_THU_VIEC = 5;
        public const decimal HOP_DONG_MOT_NAM = 6;
        public const decimal HOP_DONG_3_NAM = 7;
        public const decimal HOP_DONG_KHONG_XAC_DINH = 8;
    }

    public class CONST_ID_LUONG_CUNG_HSLNS_LCD
    {
        public const decimal MA_LUONG_CUNG_LCD = 690;
        public const decimal MUC_LUONG_CUNG_LCD = 135;

        public const decimal MA_LUONG_CUNG_HS_LNS = 631;
        public const decimal MUC_LUONG_CUNG_HS_LNS = 113;
    }

    public class CONST_TIEN_TO_SO_PHIEU
    {
        public const string PHAI_THU = "PT-";
        public const string THUC_THU = "TT-";
        public const string GIAM_TRU = "GT-";
    }

    public class CONST_ID_LOAI_DOI_TUONG
    {
        public const decimal ID_HOC_SINH = 18;
        public const decimal ID_GIAO_VIEN = 19;
    }

    public class CONST_ID_USER_GROUP
    {
        public const decimal ADMIN = 1;
    }

    public class CONST_ID_LOAI_PHIEU_THU
    {

        public const decimal PHIEU_PHAI_THU = 27;
        public const decimal PHIEU_THUC_THU = 26;
        public const decimal PHIEU_GIAM_TRU = 54;
    }

    public class CONST_ID_TRANG_THAI_BAN_GIAO
    {

        public const decimal DA_THU = 81;
        public const decimal DA_BAN_GIAO = 82;

    }

    public class CONST_ID_DM_LOAI_CHUNG_TU
    {

        public const decimal ID_TAT_CA = -1;
        public const decimal ID_NHAP_SO_DU = 60;
        public const decimal ID_BAO_HANH_SUA_CHUA = 37;

    }

    public class CONST_ID_TRANG_THAI_HANG_HOA
    {
        public const decimal ID_DA_NHAP = 691;
    }

    public class CONST_ID_DVT_THOI_GIAN
    {
        public const decimal ID_THANG = 694;
    }

    public class MA_LOAI_TU_DIEN
    {
        public const string TRANG_THAI_CHUC_VU = "TRANG_THAI_CHUC_VU";
        public const string TRANG_THAI_LAO_DONG = "TRANG_THAI_LAO_DONG";
        public const string LOAI_HOP_DONG = "LOAI_HOP_DONG";
        public const string LOAI_DON_VI = "LOAI_DON_VI";
        public const string CAP_DON_VI = "CAP_DON_VI";
        public const string LOAI_QUYET_DINH = "LOAI_QUYET_DINH";
        public const string DM_CA_HOC = "DM_CA_HOC";
        public const string LOAI_CONG_TAC = "LOAI_CONG_TAC";
        public const string LOAI_VI_TRI = "LOAI_VI_TRI";
    }

    public static class CONST_ID_LOAI_TU_DIEN
    {
        public const int MA_HS_LNS = 1;
        public const int MUC_HS_LNS = 2;
        public const int MA_LCD = 3;
        public const int MUC_LCD = 4;
        public const int LOAI_PHU_CAP = 5;
        public const int LOAI_LAO_DONG = 6;
        public const int LOAI_DON_VI = 7;
        public const int LY_DO_CHINH_SUA_HS_LNS = 8;
        public const int LY_DO_CHINH_SUA_SO_TIEN_LCD = 9;
        public const int LOAI_CONG_TAC = 10;
        public const int LOAI_VI_TRI = 11;
        public const int LOAI_QUYET_DINH = 12;
        public const int LOAI_CACH_TINH_THUE = 13;
        public const int LOAI_THU_NHAP_KHAC = 14;

        public const decimal TRANG_THAI_LAO_DONG = 15;
        public const decimal LOAI_QUY_TIEN = 16;
    }

    //public class TU_DIEN {
    //    public const string Q1 = "1";
    //    public const string Q2 = "2";
    //    public const string Q3 = "3";
    //    public const string Q4 = "8";
    //    public const string KHOI = "641";
    //    public const string PHONG = "642";
    //    public const string QD_BO_NHIEM = "643";
    //    public const string QD_CHINH_THUC = "649";
    //    public const string QD_DIEU_CHUYEN = "646";
    //    public const string QD_KIEM_NHIEM = "645";
    //    public const string QD_MIEN_NHIEM = "644";
    //    public const string QD_NGHI_VIEC = "647";
    //    public const string QD_THU_VIEC = "648";
    //    public const string CHUC_VU_CU = "652";
    //    public const string CHUC_VU_HIEN_TAI = "650";
    //    public const string KIEM_NHIEM = "651";
    //    public const string CHINH_THUC = "654";
    //    public const string NGHI_KHAC = "658";
    //    public const string NGHI_KHONG_LUONG = "657";
    //    public const string NGHI_THAI_SAN = "656";
    //    public const string NGHI_VIEC = "655";
    //    public const string THU_VIEC = "653";
    //    public const string QUAN_LY_HOC_TAP = "669";
    //    public const string TONG_HOP = "667";
    //    public const string TU_VAN_TUYEN_SINH = "668";
    //    public const string VHOL = "670";
    //    public const string VHTT = "671";
    //}

    //public class CAP_DON_VI {
    //    public const decimal KHOI = 1;
    //    public const decimal TRUNG_TAM = 2;
    //    public const decimal PHONG_BAN = 3;
    //}

    public static class CONST_ID_LOAI_CONG_TAC
    {
        public const decimal CHINH_THUC = 157;
        public const decimal KIEM_NHIEM = 164;
    }

    public static class CONST_ID_LOAI_LAO_DONG
    {
        public const decimal TRUC_TIEP = 144;
        public const decimal GIAN_TIEP = 145;
    }

    public static class CONST_ID_TIEN_THUONG
    {
        public const decimal THUONG_HS_BS = 627;
        public const decimal THUONG_ATHK = 628;
    }

    public static class CONST_ID_MSGBOX
    {
        #region Thông báo chung
        public const int QUESTION_XAC_NHAN_LUU_DU_LIEU = 195;
        public const int QUESTION_XAC_NHAN_XOA_DU_LIEU = 8;
        public const int INFOR_LUU_DU_LIEU_THANH_CONG = 50;
        public const int INFOR_XOA_DU_LIEU_THANH_CONG = 202;
        public const int INFOR_DU_LIEU_DA_DUOC_CAP_NHAT = 190;
        public const int ERROR_CHUA_CHON_DONG_TREN_LUOI_DE_SUA = 191;
        public const int QUESTION_XAC_NHAN_XOA_THONG_TIN_DA_CHON_TREN_LUOI = 201;
        public const int ERROR_DA_CO_LOI_XAY_RA = 305;
        public const int ERROR_DU_LIEU_CHUA_HOAN_THIEN = 317;
        public const int QUESTION_XAC_NHAN_CAP_NHAT_DU_LIEU = 9;
        #endregion

        #region Danh mục
        //DM_DON_VI
        public const int ERROR_CHUA_NHAP_TEN_DON_VI = 192;
        public const int ERROR_CHUA_CHON_LOAI_DON_VI = 193;
        public const int QUESTION_INSERT_DM_DON_VI_THANH_CONG_TIEP_TUC_INSERT_YN = 194;
        public const int QUESTION_XAC_NHAN_XOA_DON_VI = 196;

        //DM_BAO_HIEM
        public const int QUESTION_XAC_NHAN_XOA_LOAI_BAO_HIEM = 197;
        public const int ERROR_CHUA_NHAP_MA_BAO_HIEM = 198;
        public const int ERROR_CHUA_NHAP_TEN_LOAI_BAO_HIEM = 199;
        public const int ERROR_CHUA_NHAP_TI_LE = 200;

        //DM_HS_LNS
        public const int QUESTION_XAC_NHAN_XOA_HE_SO = 202;
        public const int ERROR_CHUA_NHAP_MA_LNS = 204;
        public const int ERROR_CHUA_CHON_MUC_LNS = 205;
        public const int ERROR_CHUA_NHAP_HE_SO_LNS = 206;
        public const int ERROR_CHUA_NHAP_LOAI_LAO_DONG = 207;
        public const int QUESTION_INSER_DM_HS_LNS_THANH_CONG_TIEP_TUC_INSERT_YN = 208;

        //DM_LOAI_HOP_DONG
        public const int QUESTION_XAC_NHAN_XOA_LOAI_HOP_DONG = 209;
        public const int ERROR_CHUA_NHAP_MA_LOAI_HOP_DONG = 210;
        public const int ERROR_CHUA_NHAP_TEN_LOAI_HOP_DONG = 211;
        public const int ERROR_CHUA_NHAP_SO_TIEN = 212;

        //DM_LOAI_NGAY_CONG
        public const int QUESTION_XAC_NHAN_XOA_LOAI_NGAY_CONG = 213;
        public const int ERROR_CHUA_NHAP_MA_LOAI_NGAY_CONG = 214;
        public const int ERROR_CHUA_NHAP_TEN_LOAI_NGAY_CONG = 215;
        public const int ERROR_CHUA_NHAP_TI_LE_LNS = 216;
        public const int ERROR_CHUA_NHAP_TI_LE_LCD = 217;

        //DM_LUONG_CHE_DO
        public const int QUESTION_INSER_DM_LCD_THANH_CONG_TIEP_TUC_INSERT_YN = 218;
        public const int ERROR_CHUA_NHAP_MA_LCD = 219;
        public const int ERROR_CHUA_CHON_MUC_LCD = 220;

        //DM_PHU_CAP
        public const int QUESTION_INSER_DM_PHU_CAP_THANH_CONG_TIEP_TUC_INSERT_YN = 221;
        public const int ERROR_CHUA_NHAP_TEN_LOAI_PHU_CAP = 222;
        public const int ERROR_CHUA_NHAP_DOI_TUONG_DC_HUONG_PHU_CAP = 223;

        //DM_THAM_SO
        public const int QUESTION_INSER_DM_THAM_SO_THANH_CONG_TIEP_TUC_INSERT_YN = 224;
        public const int ERROR_CHUA_NHAP_TEN_THAM_SO = 225;
        public const int ERROR_CHUA_NHAP_GIA_TRI_THAM_SO = 226;

        //DM_THUE
        public const int QUESTION_INSER_DM_THUE_THANH_CONG_TIEP_TUC_INSERT_YN = 229;
        public const int ERROR_CHUA_NHAP_GIA_TRI_BU_TRU = 227;
        public const int ERROR_CHUA_NHAP_GIA_TRI_CHAN_DUOI_NHO_HON_CHAN_TREN = 228;

        //DM_NHAN_VI
        public const int ERROR_CHUA_NHAP_MA_NHAN_VIEN = 230;
        public const int ERROR_CHUA_NHAP_HO_DEM_NHAN_VIEN = 231;
        public const int ERROR_CHUA_NHAP_TEN_NHAN_VIEN = 232;
        #endregion

        #region Báo cáo
        //Form RPT
        public const int ERROR_CHUA_CO_DU_LIEU_DE_THUC_HIEN_THAO_TAC = 400;
        public const int INFOR_LUU_BAO_CAO_THANH_CONG = 401;
        public const int ERROR_CHUA_CHON_NAM = 402;
        public const int ERROR_CHUA_CHON_THANG = 403;
        #endregion

        #region Hệ thống
        //Hệ thống
        public const int ERROR_NHAP_SAI_MAT_KHAU_CU = 280;
        public const int ERROR_NHAP_LAI_MAT_KHAU_MOI_BI_SAI = 281;
        public const int INFOR_DOI_MAT_KHAU_THANH_CONG = 282;
        public const int ERROR_DA_CAP_HET_QUYEN = 283;
        public const int ERROR_KHONG_CON_QUYEN_DE_CAP = 284;
        public const int ERROR_MAT_KHAU_NHAP_SAI = 285;
        public const int CONFIRM_RESTORE_DB = 286;
        public const int INFOR_RESTORE_DB_THANG_CONG = 287;
        public const int INFOR_BACKUP_DB_THANG_CONG = 288;
        #endregion

        #region Giao dịch
        //Giao dịch
        public const int ERROR_CHUA_CO_DU_LIEU_TREN_LUOI = 300;
        public const int ERROR_CHUA_NHAP_NAM_DE_TINH = 301;
        public const int ERROR_CHUA_NHAP_SO_TIEN_DE_TINH = 302;

        //Chấm công
        public const int WAR_KIEM_TRA_LAI_BANG_CHAM_CONG = 303;
        public const int ERROR_THANG_DA_CHOT_BANG_LUONG = 304;
        public const int QUESTION_XAC_NHAN_LUU_BAN_CHAM_CONG = 323;

        //Thu nhập khác
        public const int ERROR_CHUA_CHON_LOAI_THU_NHAP = 306;
        public const int ERROR_CHUA_NHAP_LY_DO = 307;
        public const int ERROR_CHUA_CHON_NHAN_VIEN = 308;
        
        //Nhân viên loại lao động
        public const int ERROR_CHUA_CHON_LOAI_LAO_DONG = 309;
        public const int ERROR_CHUA_CHON_NGAY_BAT_DAU = 310;
        public const int ERROR_CHUA_CHON_NGAY_KET_THUC = 311;
        public const int ERROR_NHAN_VIEN_DA_CO_LOAI_LAO_DONG = 312;

        //Quản lý lương cứng
        public const int ERROR_NGAY_KET_THUC_NHO_HON_NGAY_BAT_DAU = 313;
        public const int ERROR_NHAN_VIEN_CHUA_CO_GIA_TRI_LUONG_CUNG = 314;

        //Quản lý quyết định
        public const int ERROR_CHUA_CHON_LOAI_QUYET_DINH = 315;
        public const int ERROR_CHUA_NHAP_MA_QUYET_DINH = 316;

        //Quản lý vị trí công tác
        public const int ERROR_CHUA_CHON_QUYET_DINH = 318;
        public const int ERROR_CHUA_CHON_DON_VI = 319;
        public const int ERROR_CHUA_CHON_VI_TRI = 320;
        public const int ERROR_CHUA_CHON_LOAI_CONG_TAC = 321;
        public const int QUESTION_XAC_NHAN_HUY_KIEM_NHIEM_CUA_NHAN_VIEN = 322;

        //Lập hợp đồng
        public const int ERROR_CHUA_CHON_LOAI_HOP_DONG= 324;
        public const int ERROR_CHUA_NHAP_MA_HOP_DONG = 325;
        public const int ERROR_CHUA_CHON_MA_LCD = 326;
        public const int ERROR_CHUA_CHON_MA_LNS = 327;

        //Lên lương cho nhân viên
        public const int QUESTION_XAC_NHAN_LEN_LUONG_CHO_NHAN_VIEN = 328;

        //Đặt lại hs lns lcd
        public const int ERROR_CHUA_CHON_LY_DO_THAY_DOI_LNS = 329;
        public const int ERROR_CHUA_CHON_CHUC_DANH_DE_TINH_LNS = 330;
        public const int ERROR_CHUA_CHON_CHUC_DANH_DE_TINH_LCD = 331;
        public const int ERROR_CHUA_CHON_LY_DO_THAY_DOI_LCD = 332;
        #endregion

    }

    public static class CONST_ID_TRANG_THAI_LAO_DONG
    {
        public const int DANG_LAM = 622;
        public const int NGHI_VIEC = 624;
        public const int NGHI_HUU = 689;

    }

}
