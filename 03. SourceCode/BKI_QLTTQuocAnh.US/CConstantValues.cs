using System;
using System.Collections.Generic;
using System.Text;

namespace BKI_DichVuMatDat.US {
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

    public class CONST_TIEN_TO_SO_PHIEU {
        public const string PHAI_THU = "PT-";
        public const string THUC_THU = "TT-";
        public const string GIAM_TRU = "GT-";
    }
    
    public class CONST_ID_LOAI_DOI_TUONG {
        public const decimal ID_HOC_SINH = 18;
        public const decimal ID_GIAO_VIEN = 19;
    }

    public class CONST_ID_USER_GROUP {
        public const decimal ADMIN = 1;
    }

    public class CONST_ID_LOAI_PHIEU_THU {

        public const decimal PHIEU_PHAI_THU = 27;
        public const decimal PHIEU_THUC_THU = 26;
        public const decimal PHIEU_GIAM_TRU = 54;
    }

    public class CONST_ID_TRANG_THAI_BAN_GIAO {

        public const decimal DA_THU = 81;
        public const decimal DA_BAN_GIAO = 82;

    }

    public class CONST_ID_DM_LOAI_CHUNG_TU {
       
        public const decimal ID_TAT_CA = -1;
        public const decimal ID_NHAP_SO_DU = 60;
        public const decimal ID_BAO_HANH_SUA_CHUA = 37;

    }

    public class CONST_ID_TRANG_THAI_HANG_HOA {
        public const decimal ID_DA_NHAP = 691;
    }

    public class CONST_ID_DVT_THOI_GIAN {
        public const decimal ID_THANG = 694;
    }
    
    public class MA_LOAI_TU_DIEN {
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
        // Thông báo chung
        public const int INFOR_DU_LIEU_DA_DUOC_CAP_NHAT = 190;
        public const int INFOR_LUU_DU_LIEU_THANH_CONG = 50;
        public const int QUESTION_XAC_NHAN_LUU_DU_LIEU = 195;
        public const int QUESTION_XAC_NHAN_XOA_DU_LIEU = 8;

        //DM_DON_VI
        public const int UPDATE_DU_LIEU_DM_DON_VI = 191;
        public const int ERROR_CHUA_NHAP_TEN_DON_VI = 192;
        public const int ERROR_CHUA_CHON_LOAI_DON_VI = 193;
        public const int INSERT_DM_DON_VI_THANH_CONG_TIEP_TUC_INSERT_YN = 194;

        //Form RPT
        public const int ERROR_CHUA_CO_DU_LIEU_DE_THUC_HIEN_THAO_TAC = 400;
        public const int INFOR_LUU_BAO_CAO_THANH_CONG = 401;
        public const int ERROR_CHUA_CHON_NAM_DE_LOC_DU_LIEU = 402;
        public const int ERROR_CHUA_CHON_THANG_DE_LOC_DU_LIEU = 403;

        //Hệ thống
        public const int ERROR_NHAP_SAI_MAT_KHAU_CU = 221;
        public const int ERROR_NHAP_LAI_MAT_KHAU_MOI_BI_SAI = 222;
        public const int INFOR_DOI_MAT_KHAU_THANH_CONG = 223;
        public const int ERROR_DA_CAP_HET_QUYEN = 224;
        public const int ERROR_KHONG_CON_QUYEN_DE_CAP = 225;
        public const int ERROR_MAT_KHAU_NHAP_SAI = 226;
        public const int CONFIRM_RESTORE_DB = 227;
        public const int INFOR_RESTORE_DB_THANG_CONG = 228;
        public const int INFOR_BACKUP_DB_THANG_CONG = 229;

        //Giao dịch
        public const int ERROR_CHUA_CO_DU_LIEU_TREN_LUOI = 300;
        public const int ERROR_CHUA_NHAP_NAM_DE_TINH = 301;
        public const int ERROR_CHUA_NHAP_SO_TIEN_DE_TINH = 302;
    }

    public static class CONST_ID_TRANG_THAI_LAO_DONG
    {
        public const int NGHI_HUU = 689;
    }

}
