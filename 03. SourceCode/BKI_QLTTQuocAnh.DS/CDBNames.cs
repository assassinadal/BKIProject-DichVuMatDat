using System;
using System.Collections.Generic;
using System.Text;

namespace BKI_DichVuMatDat.DS.CDBNames
{
    #region HE_THONG
    public class HT_BACKUP_HISTORY
    {
        public const string ID = "ID";
        public const string NGUOI_BACKUP = "NGUOI_BACKUP";
        public const string NGAY_BACKUP = "NGAY_BACKUP";
        public const string NOI_LUU = "NOI_LUU";
        public const string TEN_FILE = "TEN_FILE";
        public const string GhI_CHU = "GhI_CHU";
    }
    public class HT_FORM
    {
        public const string ID = "ID";
        public const string FORM_NAME = "FORM_NAME";
        public const string DISPLAY_NAME = "DISPLAY_NAME";
    }

    public class V_HT_CONTROL_IN_FORM
    {
        public const string ID = "ID";
        public const string FORM_NAME = "FORM_NAME";
        public const string DISPLAY_NAME = "DISPLAY_NAME";
        public const string CONTROL_NAME = "CONTROL_NAME";
        public const string CONTROL_TYPE = "CONTROL_TYPE";
        public const string MA_TU_DIEN = "MA_TU_DIEN";
        public const string ID_TU_DIEN = "ID_TU_DIEN";
    }

    public enum e_loai_tu_dien
    {
        PHAN_QUYEN = 1
       ,
        DIA_DIEM_QUAN_LY = 2
            ,
        DON_VI_QUAN_LY_CHINH = 3
            ,
        LEVEL_GIANG_VIEN = 4
            ,
        LOAI_HOP_DONG = 5
            ,
        NGANH_DAO_TAO = 6
            ,
        DON_VI_TINH = 7
            ,
        TRANG_THAI_HOP_DONG_KHUNG = 8
            ,
        TRANG_THAI_GIANG_VIEN = 9
            ,
        MA_TAN_SUAT = 10
            ,
        HOC_HAM = 11
            ,
        HOC_VI = 12
            ,
        HINH_THUC_CONG_TAC = 13
            ,
        TRANG_THAI_DOT_THANH_TOAN = 14
            ,
        TRANG_THAI_THANH_TOAN = 15
            ,
        TRANG_THAI_TT_HOP_DONG = 17
            ,
        VAI_TRO_GV = 18
            ,
        LOAI_SU_KIEN = 19
            ,
        TRANG_THAI_SU_KIEN = 20
            ,
        TRANG_THAI_CONG_VIEC_GV = 21
            ,
        TRANG_THAI_HO_SO_GV = 23
            ,
        TRANG_THAI_SU_KIEN_GV = 24
            ,
        LOAI_HO_SO_GV_CM = 25
            ,
        LOAI_HO_SO_GV_HD = 26
            ,
        DV_TO_CHUC_SK = 27
    }

    public class LOAI_TU_DIEN
    {
        public const string PHAN_QUYEN = "PHAN_QUYEN";
        public const string DIA_DIEM_QUAN_LY = "DIA_DIEM_QUAN_LY";
        public const string DON_VI_QUAN_LY_CHINH = "DON_VI_QUAN_LY_CHINH";
        public const string LEVEL_GIANG_VIEN = "LEVEL_GIANG_VIEN";
        public const string LOAI_HOP_DONG = "LOAI_HOP_DONG";
        public const string TRANG_THAI_HOP_DONG_KHUNG = "TRANG_THAI_HOP_DONG_KHUNG";
        public const string TRANG_THAI_GIANG_VIEN = "TRANG_THAI_GIANG_VIEN";
        public const string HINH_THUC_CONG_TAC = "HINH_THUC_CONG_TAC";
        public const string TRANG_THAI_DOT_THANH_TOAN = "TRANG_THAI_DOT_THANH_TOAN";
        public const string TRANG_THAI_THANH_TOAN = "TRANG_THAI_THANH_TOAN";
        public const string TRANG_THAI_SU_KIEN = "TRANG_THAI_SU_KIEN";
        public const string TRANG_THAI_CONG_VIEC_GV = "TRANG_THAI_CONG_VIEC_GV";
        public const string TRANG_THAI_SU_KIEN_GV = "TRANG_THAI_SU_KIEN_GV";

    }

    public enum e_user_group
    {
        TESTER = 1
        ,
        PM_TD = 2
            ,
        TRUONG_NHOM_PO = 3
            ,
        PO = 4
            ,
        ADMIN = 5
            ,
        GIANG_VIEN = 6
    }

    public class HT_PHAN_QUYEN_HE_THONG
    {
        public const string ID = "ID";
        public const string MA_PHAN_QUYEN = "MA_PHAN_QUYEN";
        public const string GHI_CHU = "GHI_CHU";
        public const string LOAI_PHAN_QUYEN = "LOAI_PHAN_QUYEN";
    }

    public class HT_PHAN_QUYEN_CHO_NHOM
    {
        public const string ID = "ID";
        public const string ID_USER_GROUP = "ID_USER_GROUP";
        public const string ID_PHAN_QUYEN_HE_THONG = "ID_PHAN_QUYEN_HE_THONG";
    }

    public class HT_NHOM_NGUOI_SU_DUNG
    {
        public const string ID = "ID";
        public const string MA_NHOM = "MA_NHOM";
        public const string GHI_CHU = "GHI_CHU";
        public const string TRANG_THAI_NHOM = "TRANG_THAI_NHOM";
        public const string ID_INPUTED_BY = "ID_INPUTED_BY";
        public const string INPUTED_DATE = "INPUTED_DATE";
        public const string ID_LAST_UPDATED_BY = "ID_LAST_UPDATED_BY";
        public const string LAS_UPDATED_DATE = "LAS_UPDATED_DATE";
    }

    public class CM_DM_TU_DIEN
    {
        public const string ID = "ID";
        public const string MA_TU_DIEN = "MA_TU_DIEN";
        public const string TEN_NGAN = "TEN_NGAN";
        public const string TEN = "TEN";
        public const string ID_LOAI_TU_DIEN = "ID_LOAI_TU_DIEN";
        public const string GHI_CHU = "GHI_CHU";
    }

    public class CM_DM_LOAI_TD
    {
        public const string ID = "ID";
        public const string MA_LOAI = "MA_LOAI";
        public const string TEN_LOAI = "TEN_LOAI";
    }

    public class HT_NGUOI_SU_DUNG
    {
        public const string ID = "ID";
        public const string TEN_TRUY_CAP = "TEN_TRUY_CAP";
        public const string TEN = "TEN";
        public const string MAT_KHAU = "MAT_KHAU";
        public const string NGAY_TAO = "NGAY_TAO";
        public const string NGUOI_TAO = "NGUOI_TAO";
        public const string TRANG_THAI = "TRANG_THAI";
        public const string BUILT_IN_YN = "BUILT_IN_YN";
        public const string ID_USER_GROUP = "ID_USER_GROUP";
        public const string ID_TRAINING_PROJECT = "ID_TRAINING_PROJECT";
    }

    public class HT_CHUC_NANG
    {
        public const string ID = "ID";
        public const string TEN_CHUC_NANG = "TEN_CHUC_NANG";
        public const string URL_FORM = "URL_FORM";
        public const string TRANG_THAI_YN = "TRANG_THAI_YN";
        public const string VI_TRI = "VI_TRI";
        public const string CHUC_NANG_PARENT_ID = "CHUC_NANG_PARENT_ID";
        public const string HIEN_THI_YN = "HIEN_THI_YN";
    }

    public class HT_QUYEN_GROUP
    {
        public const string ID = "ID";
        public const string ID_USER_GROUP = "ID_USER_GROUP";
        public const string ID_QUYEN = "ID_QUYEN";
    }

    public class HT_USER_GROUP
    {
        public const string ID = "ID";
        public const string USER_GROUP_NAME = "USER_GROUP_NAME";
        public const string DESCRIPTION = "DESCRIPTION";
    }

    public class CM_COMPANY_INFO
    {
        public const string ID = "ID";
        public const string COMPANY_NAME = "COMPANY_NAME";
        public const string COMPANY_ADDRESS = "COMPANY_ADDRESS";
    }

    #endregion

    #region DANH_MUC
    public class DM_CHUC_VU
    {
        public const string ID = "ID";
        public const string MA_CHUC_VU = "MA_CHUC_VU";
        public const string TEN_CHUC_VU = "TEN_CHUC_VU";
        public const string SO_THU_TU = "SO_THU_TU";
        public const string ID_DON_VI = "ID_DON_VI";
        public const string ID_LOAI_CHUC_VU = "ID_LOAI_CHUC_VU";
        public const string GHI_CHU = "GHI_CHU";    
    }


    public class CM_THU_TU_DON_VI
    {
        public const string ID = "ID";
        public const string TEN_DON_VI = "TEN_DON_VI";
        public const string STT = "STT";
    }

    public class DM_COMPANY_INFO
    {
        public const string ID = "ID";
        public const string SHORT_NAME = "SHORT_NAME";
        public const string FULL_NAME = "FULL_NAME";
        public const string ADDRESS = "ADDRESS";
        public const string MOBLIE = "MOBLIE";
        public const string EMAIL = "EMAIL";
        public const string TAX_CODE = "TAX_CODE";
    }

    public class DM_TRANG_THAI_LD
    {
        public const string ID = "ID";
        public const string MA_TRANG_THAI_LD = "MA_TRANG_THAI_LD";
        public const string TEN_TRANG_THAI_LD = "TEN_TRANG_THAI_LD";
        public const string GHI_CHU = "GHI_CHU";
    }


    public class DM_LOAI_HOP_DONG
    {
        public const string ID = "ID";
        public const string LOAI_HOP_DONG = "LOAI_HOP_DONG";
        public const string MA_LOAI_HOP_DONG = "MA_LOAI_HOP_DONG";
        public const string TI_LE = "TI_LE";
        public const string SO_TIEN = "SO_TIEN";
        public const string AN_CA_YN = "AN_CA_YN";
        public const string HS_LNS_YN = "HS_LNS_YN";
        public const string LCD_YN = "LCD_YN";
    }

    public class DM_LOAI_NGAY_CONG
    {
        public const string ID = "ID";
        public const string MA_NGAY_CONG = "MA_NGAY_CONG";
        public const string TEN_NGAY_CONG = "TEN_NGAY_CONG";
        public const string TI_LE_LNS = "TI_LE_LNS";
        public const string TI_LE_LCD = "TI_LE_LCD";
    }

    public class DM_HE_SO_LUONG_NS
    {
        public const string ID = "ID";
        public const string ID_MA_LNS = "ID_MA_LNS";
        public const string ID_MUC_LNS = "ID_MUC_LNS";
        public const string HE_SO = "HE_SO";
        public const string ID_LOAI_LAO_DONG = "ID_LOAI_LAO_DONG";
    }

    public class DM_LUONG_CHE_DO
    {
        public const string ID = "ID";
        public const string ID_MA_LCD = "ID_MA_LCD";
        public const string ID_MUC_LCD = "ID_MUC_LCD";
        public const string SO_TIEN = "SO_TIEN";
    }
    public class DM_BAO_HIEM
    {
        public const string ID = "ID";
        public const string TEN_BH = "TEN_BH";
        public const string MA_BH = "MA_BH";
        public const string TI_LE = "TI_LE";
    }
    public class DM_DON_VI
    {
        public const string ID = "ID";
        public const string TEN_DON_VI = "TEN_DON_VI";
        public const string MA_DON_VI = "MA_DON_VI";
        public const string ID_LOAI_DON_VI = "ID_LOAI_DON_VI";
        public const string ID_DON_VI_CAP_TREN = "ID_DON_VI_CAP_TREN";
        public const string ID_DV_0 = "ID_DV_0";
        public const string ID_DV_1 = "ID_DV_1";
        public const string ID_DV_2 = "ID_DV_2";
        public const string ID_DV_3 = "ID_DV_3";
        public const string ID_DV_4 = "ID_DV_4";
        public const string SO_THU_TU = "SO_THU_TU";
        public const string TANG = "TANG";
    }

    public class DM_NHAN_VIEN
    {
        public const string ID = "ID";
        public const string MA_NV = "MA_NV";
        public const string HO_DEM = "HO_DEM";
        public const string TEN = "TEN";
        public const string GIOI_TINH = "GIOI_TINH";
        public const string EMAIL = "EMAIL";
        public const string SDT = "SDT";
        public const string SO_TAI_KHOAN = "SO_TAI_KHOAN";
        public const string NGAN_HANG = "NGAN_HANG";
        public const string NGAY_CAP_THE = "NGAY_CAP_THE";
        public const string NGAY_HET_HAN_THE = "NGAY_HET_HAN_THE";
        public const string NGAY_SINH = "NGAY_SINH";
        public const string HON_NHAN = "HON_NHAN";
        public const string SO_CMT = "SO_CMT";
        public const string NGAY_CAP = "NGAY_CAP";
        public const string NOI_CAP = "NOI_CAP";
        public const string QUOC_TICH = "QUOC_TICH";
        public const string DAN_TOC = "DAN_TOC";
        public const string TON_GIAO = "TON_GIAO";
        public const string NOI_SINH = "NOI_SINH";
        public const string QUE_QUAN = "QUE_QUAN";
        public const string DIA_CHI_THUONG_TRU = "DIA_CHI_THUONG_TRU";
        public const string DIA_CHI_TAM_TRU = "DIA_CHI_TAM_TRU";
        public const string DIA_CHI_LIEN_LAC = "DIA_CHI_LIEN_LAC";
        public const string MA_SO_THUE_CA_NHAN = "MA_SO_THUE_CA_NHAN";
        public const string CHUYEN_MON = "CHUYEN_MON";
        public const string TRINH_DO_VAN_HOA = "TRINH_DO_VAN_HOA";
        public const string NAM_TOT_NGHIEP = "NAM_TOT_NGHIEP";
        public const string TOT_NGHIEP_TAI = "TOT_NGHIEP_TAI";
        public const string NGAY_VAO_HANG_KHONG = "NGAY_VAO_HANG_KHONG";
        public const string NGAY_TIEP_NHAN_VAO_TCT = "NGAY_TIEP_NHAN_VAO_TCT";
        public const string NGAY_CHINH_THUC_TIEP_NHAN = "NGAY_CHINH_THUC_TIEP_NHAN";
        public const string NGUOI_BAO_LANH = "NGUOI_BAO_LANH";
    }

    public class DM_PHU_CAP
    {
        public const string ID = "ID";
        public const string ID_LOAI_PHU_CAP = "ID_LOAI_PHU_CAP";
        public const string DOI_TUONG_HUONG_PHU_CAP = "DOI_TUONG_HUONG_PHU_CAP";
        public const string TI_LE = "TI_LE";
    }
    public class DM_THAM_SO
    {
        public const string ID = "ID";
        public const string LOAI = "LOAI";
        public const string SO_TIEN = "SO_TIEN";
    }
    public class DM_THUE
    {
        public const string ID = "ID";
        public const string CHAN_DUOI = "CHAN_DUOI";
        public const string CHAN_TREN = "CHAN_TREN";
        public const string TI_LE = "TI_LE";
        public const string BU_TRU = "BU_TRU";
    }

    #endregion

    #region GIAO_DICH
    public class GD_MA_TRA_CUU_NHAN_VIEN
    {
        public const string ID = "ID";
        public const string ID_NHAN_VIEN = "ID_NHAN_VIEN";
        public const string MA_PHONG = "MA_PHONG";
        public const string MA_DOI = "MA_DOI";
        public const string MA_CHUC_VU = "MA_CHUC_VU";
        public const string THU_TU_CHUC_VU = "THU_TU_CHUC_VU";
        public const string SO_HO_SO = "SO_HO_SO";
        public const string NGUOI_LAP = "NGUOI_LAP";
        public const string NGAY_LAP = "NGAY_LAP";
        public const string NGUOI_SUA = "NGUOI_SUA";
        public const string NGAY_SUA = "NGAY_SUA";
        public const string DA_XOA = "DA_XOA";
    }


    public class V_GD_QUY_TIEN_THUONG
    {
        public const string ID = "ID";
        public const string THANG = "THANG";
        public const string NAM = "NAM";
        public const string SO_TIEN = "SO_TIEN";
        public const string ID_LOAI_QUY_TIEN = "ID_LOAI_QUY_TIEN";
        public const string NGUOI_LAP = "NGUOI_LAP";
        public const string NGAY_LAP = "NGAY_LAP";
        public const string DA_XOA = "DA_XOA";
        public const string TEN_QUY = "TEN_QUY";
        public const string TINH_XONG_YN = "TINH_XONG_YN";
        public const string ID_CACH_TINH_THUE = "ID_CACH_TINH_THUE";
        public const string GIAM_TRU_YN = "GIAM_TRU_YN";
        public const string TEN_CACH_TINH_THUE = "TEN_CACH_TINH_THUE";
        public const string TEN_LOAI_QUY_TIEN = "TEN_LOAI_QUY_TIEN";
        public const string TINH_XONG_TEXT = "TINH_XONG_TEXT";
        public const string LY_DO_THUONG = "LY_DO_THUONG";
        public const string TU_NGAY_XET_THUONG = "TU_NGAY_XET_THUONG";
        public const string DEN_NGAY_XET_THUONG = "DEN_NGAY_XET_THUONG";
        public const string SL_NV_CAN_TINH = "SL_NV_CAN_TINH";
        public const string SL_NV_DA_TINH = "SL_NV_DA_TINH";
        public const string PHAN_TRAM_DA_TINH = "PHAN_TRAM_DA_TINH";
        public const string DON_GIA = "DON_GIA";
    }



    public class GD_THU_NHAP_KHAC
    {
        public const string ID = "ID";
        public const string ID_NHAN_VIEN = "ID_NHAN_VIEN";
        public const string THANG = "THANG";
        public const string NAM = "NAM";
        public const string HE_SO = "HE_SO";
        public const string SO_TIEN = "SO_TIEN";
        public const string SO_TIEN_NOP_THUE = "SO_TIEN_NOP_THUE";
        public const string SO_TIEN_THUC_LINH = "SO_TIEN_THUC_LINH";
        public const string ID_LOAI_THU_NHAP_KHAC = "ID_LOAI_THU_NHAP_KHAC";
        public const string ID_QUY_THU_NHAP_KHAC = "ID_QUY_THU_NHAP_KHAC";
        public const string LY_DO = "LY_DO";
    }





    public class V_GD_THU_NHAP_KHAC_2
    {
        public const string ID = "ID";
        public const string ID_NHAN_VIEN = "ID_NHAN_VIEN";
        public const string SO_TIEN = "SO_TIEN";
        public const string THANG = "THANG";
        public const string NAM = "NAM";
        public const string LY_DO = "LY_DO";
        public const string ID_CACH_TINH_THUE = "ID_CACH_TINH_THUE";
        public const string ID_LOAI_THU_NHAP_KHAC = "ID_LOAI_THU_NHAP_KHAC";
        public const string ID_QUY_TIEN_THUONG = "ID_QUY_TIEN_THUONG";
        public const string SO_TIEN_GIAM_TRU = "SO_TIEN_GIAM_TRU";
        public const string SO_TIEN_NOP_THE = "SO_TIEN_NOP_THE";
        public const string SO_TIEN_THUC_LINH = "SO_TIEN_THUC_LINH";
        public const string TONG_HS_ATHK = "TONG_HS_ATHK";
        public const string TRUY_LINH = "TRUY_LINH";
        public const string TRUY_THU = "TRUY_THU";
        public const string THUC_LINH_CUOI_CUNG = "THUC_LINH_CUOI_CUNG";
        public const string MA_NV = "MA_NV";
        public const string HO_VA_TEN = "HO_VA_TEN";
        public const string TEN_DON_VI = "TEN_DON_VI";
        public const string CHUC_VU = "CHUC_VU";
        public const string SO_TAI_KHOAN = "SO_TAI_KHOAN";
    }


    public class GD_TRANG_THAI_LAO_DONG
    {
        public const string ID = "ID";
        public const string ID_NHAN_VIEN = "ID_NHAN_VIEN";
        public const string ID_TRANG_THAI_LAO_DONG = "ID_TRANG_THAI_LAO_DONG";
        public const string NGAY_AP_DUNG = "NGAY_AP_DUNG";
        public const string NGAY_KET_THUC = "NGAY_KET_THUC";
        public const string NGAY_LAP = "NGAY_LAP";
        public const string NGUOI_LAP = "NGUOI_LAP";
        public const string NGAY_SUA = "NGAY_SUA";
        public const string NGUOI_SUA = "NGUOI_SUA";
        public const string GHI_CHU = "GHI_CHU";
        public const string DA_XOA = "DA_XOA";
    }

    public class GD_QUY_TIEN_THUONG
    {
        public const string ID = "ID";
        public const string THANG = "THANG";
        public const string NAM = "NAM";
        public const string SO_TIEN = "SO_TIEN";
        public const string ID_LOAI_QUY_TIEN = "ID_LOAI_QUY_TIEN";
        public const string NGUOI_LAP = "NGUOI_LAP";
        public const string NGAY_LAP = "NGAY_LAP";
        public const string DA_XOA = "DA_XOA";
        public const string TEN_QUY = "TEN_QUY";
        public const string TINH_XONG_YN = "TINH_XONG_YN";
        public const string TU_NGAY_XET_THUONG = "TU_NGAY_XET_THUONG";
        public const string DEN_NGAY_XET_THUONG = "DEN_NGAY_XET_THUONG";
        public const string LY_DO_THUONG = "LY_DO_THUONG";
        public const string ID_CACH_TINH_THUE = "ID_CACH_TINH_THUE";
        public const string GIAM_TRU_YN = "GIAM_TRU_YN";
        public const string DON_GIA = "DON_GIA";
    }



    public class GD_CHAM_CONG
    {
        public const string ID = "ID";
        public const string ID_NHAN_VIEN = "ID_NHAN_VIEN";
        public const string NGAY_CHAM_CONG = "NGAY_CHAM_CONG";
        public const string ID_LOAI_NGAY_CONG = "ID_LOAI_NGAY_CONG";
        public const string NGUOI_LAP = "NGUOI_LAP";
        public const string NGUOI_SUA = "NGUOI_SUA";
        public const string NGAY_LAP = "NGAY_LAP";
        public const string NGAY_SUA = "NGAY_SUA";
        public const string DA_XOA = "DA_XOA";
    }

    public class GD_HOP_DONG
    {
        public const string ID = "ID";
        public const string ID_NHAN_VIEN = "ID_NHAN_VIEN";
        public const string ID_LOAI_HOP_DONG = "ID_LOAI_HOP_DONG";
        public const string MA_HOP_DONG = "MA_HOP_DONG";
        public const string NGAY_BAT_DAU = "NGAY_BAT_DAU";
        public const string NGAY_KET_THUC = "NGAY_KET_THUC";
        public const string NGAY_KY_HOP_DONG = "NGAY_KY_HOP_DONG";
        public const string NGAY_LAP = "NGAY_LAP";
        public const string NGAY_SUA = "NGAY_SUA";
        public const string NGUOI_LAP = "NGUOI_LAP";
        public const string NGUOI_SUA = "NGUOI_SUA";
        public const string GHI_CHU = "GHI_CHU";
        public const string ID_LUONG_CHE_DO = "ID_LUONG_CHE_DO";
        public const string ID_LOAI_LAO_DONG = "ID_LOAI_LAO_DONG";
        public const string ID_DON_VI = "ID_DON_VI";
        public const string ID_CHUC_VU = "ID_CHUC_VU";
        public const string SO_TIEN_LCD = "SO_TIEN_LCD";
    }


    public class GD_HS_LNS_LCD
    {
        public const string ID = "ID";
        public const string ID_QUYET_DINH = "ID_QUYET_DINH";
        public const string ID_HOP_DONG = "ID_HOP_DONG";
        public const string ID_HS_LNS = "ID_HS_LNS";
        public const string ID_LCD = "ID_LCD";
        public const string NGAY_LAP = "NGAY_LAP";
        public const string NGAY_SUA = "NGAY_SUA";
        public const string NGUOI_LAP = "NGUOI_LAP";
        public const string NGUOI_SUA = "NGUOI_SUA";
        public const string DA_XOA = "DA_XOA";
    }
    public class GD_CONG_TAC
    {
        public const string ID = "ID";
        public const string ID_NHAN_VIEN = "ID_NHAN_VIEN";
        public const string ID_QUYET_DINH = "ID_QUYET_DINH";
        public const string ID_DON_VI = "ID_DON_VI";
        public const string NGAY_BAT_DAU = "NGAY_BAT_DAU";
        public const string NGAY_KET_THUC = "NGAY_KET_THUC";
        public const string NGAY_LAP = "NGAY_LAP";
        public const string NGAY_SUA = "NGAY_SUA";
        public const string NGUOI_LAP = "NGUOI_LAP";
        public const string NGUOI_SUA = "NGUOI_SUA";
        public const string DA_XOA = "DA_XOA";
        public const string ID_LOAI_CONG_TAC = "ID_LOAI_CONG_TAC";
        public const string ID_VI_TRI = "ID_VI_TRI";
        public const string SO_HO_SO = "SO_HO_SO";
    }


    public class GD_HE_SO_CHAT_LUONG
    {
        public const string ID = "ID";
        public const string ID_NHAN_VIEN = "ID_NHAN_VIEN";
        public const string HE_SO_K = "HE_SO_K";
        public const string THANG = "THANG";
        public const string NAM = "NAM";
        public const string NGUOI_LAP = "NGUOI_LAP";
        public const string NGUOI_SUA = "NGUOI_SUA";
        public const string NGAY_LAP = "NGAY_LAP";
        public const string NGAY_SUA = "NGAY_SUA";
        public const string DA_XOA = "DA_XOA";
    }
    public class GD_HE_SO_LNS
    {
        public const string ID = "ID";
        public const string ID_NHAN_VIEN = "ID_NHAN_VIEN";
        public const string ID_HE_SO_LNS = "ID_HE_SO_LNS";
        public const string HE_SO = "HE_SO";
        public const string LY_DO_CHINH_SUA = "LY_DO_CHINH_SUA";
        public const string GHI_CHU = "GHI_CHU";
        public const string NGAY_BAT_DAU = "NGAY_BAT_DAU";
        public const string NGAY_KET_THUC = "NGAY_KET_THUC";
        public const string NGAY_LAP = "NGAY_LAP";
        public const string NGAY_SUA = "NGAY_SUA";
        public const string NGUOI_LAP = "NGUOI_LAP";
        public const string NGUOI_SUA = "NGUOI_SUA";
    }

    public class GD_LUONG_CHE_DO
    {
        public const string ID = "ID";
        public const string ID_HOP_DONG = "ID_HOP_DONG";
        public const string SO_TIEN = "SO_TIEN";
        public const string ID_LY_DO_CHINH_SUA = "ID_LY_DO_CHINH_SUA";
        public const string GHI_CHU = "GHI_CHU";
        public const string NGAY_BAT_DAU = "NGAY_BAT_DAU";
        public const string NGAY_KET_THUC = "NGAY_KET_THUC";
        public const string NGAY_LAP = "NGAY_LAP";
        public const string NGAY_SUA = "NGAY_SUA";
        public const string NGUOI_LAP = "NGUOI_LAP";
        public const string NGUOI_SUA = "NGUOI_SUA";
        public const string DA_XOA = "DA_XOA";
    }
    public class GD_NHAN_VIEN_PHU_CAP
    {
        public const string ID = "ID";
        public const string ID_NHAN_VIEN = "ID_NHAN_VIEN";
        public const string ID_PHU_CAP = "ID_PHU_CAP";
        public const string ID_QUYET_DINH = "ID_QUYET_DINH";
        public const string NGUOI_LAP = "NGUOI_LAP";
        public const string NGUOI_SUA = "NGUOI_SUA";
        public const string NGAY_LAP = "NGAY_LAP";
        public const string NGAY_SUA = "NGAY_SUA";
        public const string DA_XOA = "DA_XOA";
    }
    public class GD_PHU_THUOC
    {
        public const string ID = "ID";
        public const string ID_NHAN_VIEN = "ID_NHAN_VIEN";
        public const string SO_LUONG = "SO_LUONG";
        public const string NGAY_SUA = "NGAY_SUA";
        public const string NGUOI_LAP = "NGUOI_LAP";
        public const string NGUOI_SUA = "NGUOI_SUA";
        public const string DA_XOA = "DA_XOA";
    }

    public class GD_QUYET_DINH
    {
        public const string ID = "ID";
        public const string MA_QUYET_DINH = "MA_QUYET_DINH";
        public const string ID_LOAI_QD = "ID_LOAI_QD";
        public const string NGAY_CO_HIEU_LUC = "NGAY_CO_HIEU_LUC";
        public const string NGUOI_KY = "NGUOI_KY";
        public const string NGAY_KY = "NGAY_KY";
        public const string NGAY_HET_HIEU_LUC = "NGAY_HET_HIEU_LUC";
        public const string NOI_DUNG = "NOI_DUNG";
        public const string LINK = "LINK";
    }

    public class GD_LOAI_LAO_DONG
    {
        public const string ID = "ID";
        public const string ID_NHAN_VIEN = "ID_NHAN_VIEN";
        public const string ID_LOAI_LAO_DONG = "ID_LOAI_LAO_DONG";
        public const string NGAY_BAT_DAU = "NGAY_BAT_DAU";
        public const string NGAY_KET_THUC = "NGAY_KET_THUC";
        public const string DA_XOA = "DA_XOA";
    }

    #endregion

    #region VIEW
    public class V_GD_KHONG_HE_SO_LNS
    {
        public const string MA_NV = "MA_NV";
        public const string HO_TEN = "HO_TEN";
        public const string ID = "ID";
        public const string ID_NHAN_VIEN = "ID_NHAN_VIEN";
        public const string ID_LOAI_HOP_DONG = "ID_LOAI_HOP_DONG";
        public const string MA_HOP_DONG = "MA_HOP_DONG";
        public const string NGAY_BAT_DAU = "NGAY_BAT_DAU";
        public const string NGAY_KET_THUC = "NGAY_KET_THUC";
        public const string NGAY_KY_HOP_DONG = "NGAY_KY_HOP_DONG";
        public const string NGAY_LAP = "NGAY_LAP";
        public const string NGAY_SUA = "NGAY_SUA";
        public const string NGUOI_LAP = "NGUOI_LAP";
        public const string NGUOI_SUA = "NGUOI_SUA";
        public const string GHI_CHU = "GHI_CHU";
        public const string ID_LUONG_CHE_DO = "ID_LUONG_CHE_DO";
        public const string ID_LOAI_LAO_DONG = "ID_LOAI_LAO_DONG";
        public const string ID_DON_VI = "ID_DON_VI";
        public const string ID_CHUC_VU = "ID_CHUC_VU";
        public const string SO_TIEN_LCD = "SO_TIEN_LCD";
        public const string MA_LOAI_HOP_DONG = "MA_LOAI_HOP_DONG";
        public const string LOAI_HOP_DONG = "LOAI_HOP_DONG";
        public const string LOAI_LAO_DONG = "LOAI_LAO_DONG";
        public const string TEN_DON_VI = "TEN_DON_VI";
        public const string TEN_CHUC_VU = "TEN_CHUC_VU";
        public const string ID_LCD = "ID_LCD";
        public const string ID_MA_LCD = "ID_MA_LCD";
        public const string ID_MUC_LCD = "ID_MUC_LCD";
        public const string MA_LCD = "MA_LCD";
        public const string TEN_MA_LCD = "TEN_MA_LCD";
        public const string MUC_LCD = "MUC_LCD";
        public const string TEN_MUC_LCD = "TEN_MUC_LCD";
        public const string SO_TIEN = "SO_TIEN";
    }

    public class V_GD_HE_SO_LNS
    {
        public const string ID_DON_VI = "ID_DON_VI";
        public const string ID_NHAN_VIEN = "ID_NHAN_VIEN";
        public const string MA_NV = "MA_NV";
        public const string HO_TEN = "HO_TEN";
        public const string CHUC_DANH = "CHUC_DANH";
        public const string ID = "ID";
        public const string HE_SO = "HE_SO";
        public const string NGAY_BAT_DAU = "NGAY_BAT_DAU";
        public const string NGAY_KET_THUC = "NGAY_KET_THUC";
        public const string LY_DO_CHINH_SUA = "LY_DO_CHINH_SUA";
        public const string MA_CHUC_DANH_LNS = "MA_CHUC_DANH_LNS";
        public const string CHUC_DANH_LNS = "CHUC_DANH_LNS";
        public const string MUC_LNS = "MUC_LNS";
    }


    public class V_F460_DANH_SACH_NHAN_VIEN_DANG_HOAT_DONG_O_CONG_TY
    {
        public const string ID = "ID";
        public const string ID_NHAN_VIEN = "ID_NHAN_VIEN";
        public const string MA_TRA_CUU = "MA_TRA_CUU";
        public const string MA_NV = "MA_NV";
        public const string HO_TEN = "HO_TEN";
        public const string ID_VI_TRI = "ID_VI_TRI";
        public const string THU_TU_CHUC_VU = "THU_TU_CHUC_VU";
        public const string ID_DON_VI = "ID_DON_VI";
        public const string TEN_DON_VI = "TEN_DON_VI";
        public const string THU_TU_DON_VI = "THU_TU_DON_VI";
        public const string TRINH_DO_VAN_HOA = "TRINH_DO_VAN_HOA";
        public const string CHUYEN_MON = "CHUYEN_MON";
        public const string DIA_CHI_THUONG_TRU = "DIA_CHI_THUONG_TRU";
        public const string SO_CMT = "SO_CMT";
        public const string NGAY_CAP = "NGAY_CAP";
        public const string NOI_CAP = "NOI_CAP";
        public const string TUOI = "TUOI";
        public const string LOAI_HOP_DONG = "LOAI_HOP_DONG";
        public const string MA_LOAI_HOP_DONG = "MA_LOAI_HOP_DONG";
        public const string NGAY_BAT_DAU_HOP_DONG = "NGAY_BAT_DAU_HOP_DONG";
        public const string ID_LCD = "ID_LCD";
        public const string MA_LCD = "MA_LCD";
        public const string MUC_LCD = "MUC_LCD";
        public const string SO_TIEN = "SO_TIEN";
        public const string NGAY_BAT_DAU_LCD = "NGAY_BAT_DAU_LCD";
        public const string ID_HS_LNS = "ID_HS_LNS";
        public const string TEN_LNS = "TEN_LNS";
        public const string MUC_LNS = "MUC_LNS";
        public const string HE_SO = "HE_SO";
        public const string NGAY_BAT_DAU_LNS = "NGAY_BAT_DAU_LNS";
    }




    public class V_DM_NHAN_VIEN_4
    {
        public const string ID = "ID";
        public const string MA_NV = "MA_NV";
        public const string HO_DEM = "HO_DEM";
        public const string TEN = "TEN";
        public const string GIOI_TINH = "GIOI_TINH";
        public const string EMAIL = "EMAIL";
        public const string SDT = "SDT";
        public const string SO_TAI_KHOAN = "SO_TAI_KHOAN";
        public const string NGAN_HANG = "NGAN_HANG";
        public const string NGAY_CAP_THE = "NGAY_CAP_THE";
        public const string NGAY_HET_HAN_THE = "NGAY_HET_HAN_THE";
        public const string NGAY_SINH = "NGAY_SINH";
        public const string HON_NHAN = "HON_NHAN";
        public const string SO_CMT = "SO_CMT";
        public const string NGAY_CAP = "NGAY_CAP";
        public const string NOI_CAP = "NOI_CAP";
        public const string QUOC_TICH = "QUOC_TICH";
        public const string DAN_TOC = "DAN_TOC";
        public const string TON_GIAO = "TON_GIAO";
        public const string NOI_SINH = "NOI_SINH";
        public const string QUE_QUAN = "QUE_QUAN";
        public const string DIA_CHI_THUONG_TRU = "DIA_CHI_THUONG_TRU";
        public const string DIA_CHI_TAM_TRU = "DIA_CHI_TAM_TRU";
        public const string DIA_CHI_LIEN_LAC = "DIA_CHI_LIEN_LAC";
        public const string MA_SO_THUE_CA_NHAN = "MA_SO_THUE_CA_NHAN";
        public const string CHUYEN_MON = "CHUYEN_MON";
        public const string TRINH_DO_VAN_HOA = "TRINH_DO_VAN_HOA";
        public const string NAM_TOT_NGHIEP = "NAM_TOT_NGHIEP";
        public const string TOT_NGHIEP_TAI = "TOT_NGHIEP_TAI";
        public const string NGAY_VAO_HANG_KHONG = "NGAY_VAO_HANG_KHONG";
        public const string NGAY_TIEP_NHAN_VAO_TCT = "NGAY_TIEP_NHAN_VAO_TCT";
        public const string NGAY_CHINH_THUC_TIEP_NHAN = "NGAY_CHINH_THUC_TIEP_NHAN";
        public const string NGUOI_BAO_LANH = "NGUOI_BAO_LANH";
    }

    public class V_F405_BAO_CAO_THONG_TIN_TINH_LUONG
    {
        public const string ID_NHAN_VIEN = "ID_NHAN_VIEN";
        public const string MA_NV = "MA_NV";
        public const string HO_DEM = "HO_DEM";
        public const string TEN = "TEN";
        public const string HO_TEN = "HO_TEN";
        public const string ID_DON_VI = "ID_DON_VI";
        public const string MA_DON_VI = "MA_DON_VI";
        public const string TEN_DON_VI = "TEN_DON_VI";
        public const string THU_TU_DON_VI = "THU_TU_DON_VI";
        public const string ID_VI_TRI = "ID_VI_TRI";
        public const string MA_VI_TRI = "MA_VI_TRI";
        public const string TEN_VI_TRI = "TEN_VI_TRI";
        public const string THU_TU_CHUC_VU = "THU_TU_CHUC_VU";
        public const string ID_LOAI_LAO_DONG = "ID_LOAI_LAO_DONG";
        public const string TEN_LOAI_LAO_DONG = "TEN_LOAI_LAO_DONG";
        public const string ID_LOAI_HOP_DONG = "ID_LOAI_HOP_DONG";
        public const string LOAI_HOP_DONG = "LOAI_HOP_DONG";
        public const string MA_LOAI_HOP_DONG = "MA_LOAI_HOP_DONG";
        public const string TI_LE_HOP_DONG = "TI_LE_HOP_DONG";
        public const string HE_SO_LNS = "HE_SO_LNS";
        public const string SO_TIEN_LCD = "SO_TIEN_LCD";
        public const string TI_LE_PHU_CAP = "TI_LE_PHU_CAP";
        public const string SO_NGUOI_PHU_THUOC = "SO_NGUOI_PHU_THUOC";
        public const string SO_TIEN_LUONG_CUNG = "SO_TIEN_LUONG_CUNG";
        public const string NHAN_VIEN_KHONG_DONG_BAO_HIEM = "NHAN_VIEN_KHONG_DONG_BAO_HIEM";
    }

    public class V_F410_BAO_CAO_SO_LUONG_CHAT_LUONG_NHAN_VIEN
    {
        public const string ID_DON_VI = "ID_DON_VI";
        public const string ID_DON_VI_CAP_TREN = "ID_DON_VI_CAP_TREN";
        public const string MA_DON_VI = "MA_DON_VI";
        public const string TEN_DON_VI = "TEN_DON_VI";
        public const string THU_TU_DON_VI = "THU_TU_DON_VI";
        public const string ID = "ID";
        public const string ID_NHAN_VIEN = "ID_NHAN_VIEN";
        public const string MA_NV = "MA_NV";
        public const string HO_DEM = "HO_DEM";
        public const string TEN = "TEN";
        public const string HO_TEN = "HO_TEN";
        public const string GIOI_TINH = "GIOI_TINH";
        public const string NGAY_SINH = "NGAY_SINH";
        public const string TUOI_NHAN_VIEN = "TUOI_NHAN_VIEN";
        public const string TRINH_DO_VAN_HOA = "TRINH_DO_VAN_HOA";
        public const string ID_VI_TRI = "ID_VI_TRI";
        public const string MA_VI_TRI = "MA_VI_TRI";
        public const string TEN_VI_TRI = "TEN_VI_TRI";
        public const string THU_TU_CHUC_VU = "THU_TU_CHUC_VU";
        public const string ID_LOAI_CONG_TAC = "ID_LOAI_CONG_TAC";
        public const string MA_LOAI_CONG_TAC = "MA_LOAI_CONG_TAC";
        public const string TEN_LOAI_CONG_TAC = "TEN_LOAI_CONG_TAC";
        public const string NGAY_BAT_DAU = "NGAY_BAT_DAU";
        public const string ID_LOAI_HOP_DONG = "ID_LOAI_HOP_DONG";
        public const string MA_LOAI_HOP_DONG = "MA_LOAI_HOP_DONG";
    }


    public class V_DM_NHAN_VIEN_3
    {
        public const string ID = "ID";
        public const string MA_NV = "MA_NV";
        public const string HO_DEM = "HO_DEM";
        public const string TEN = "TEN";
        public const string GIOI_TINH = "GIOI_TINH";
        public const string EMAIL = "EMAIL";
        public const string SDT = "SDT";
        public const string SO_TAI_KHOAN = "SO_TAI_KHOAN";
        public const string NGAN_HANG = "NGAN_HANG";
        public const string NGAY_CAP_THE = "NGAY_CAP_THE";
        public const string NGAY_HET_HAN_THE = "NGAY_HET_HAN_THE";
        public const string NGAY_SINH = "NGAY_SINH";
        public const string HON_NHAN = "HON_NHAN";
        public const string SO_CMT = "SO_CMT";
        public const string NGAY_CAP = "NGAY_CAP";
        public const string NOI_CAP = "NOI_CAP";
        public const string QUOC_TICH = "QUOC_TICH";
        public const string DAN_TOC = "DAN_TOC";
        public const string TON_GIAO = "TON_GIAO";
        public const string NOI_SINH = "NOI_SINH";
        public const string QUE_QUAN = "QUE_QUAN";
        public const string DIA_CHI_THUONG_TRU = "DIA_CHI_THUONG_TRU";
        public const string DIA_CHI_TAM_TRU = "DIA_CHI_TAM_TRU";
        public const string DIA_CHI_LIEN_LAC = "DIA_CHI_LIEN_LAC";
        public const string MA_SO_THUE_CA_NHAN = "MA_SO_THUE_CA_NHAN";
        public const string CHUYEN_MON = "CHUYEN_MON";
        public const string TRINH_DO_VAN_HOA = "TRINH_DO_VAN_HOA";
        public const string NAM_TOT_NGHIEP = "NAM_TOT_NGHIEP";
        public const string TOT_NGHIEP_TAI = "TOT_NGHIEP_TAI";
        public const string NGAY_VAO_HANG_KHONG = "NGAY_VAO_HANG_KHONG";
        public const string NGAY_TIEP_NHAN_VAO_TCT = "NGAY_TIEP_NHAN_VAO_TCT";
        public const string NGAY_CHINH_THUC_TIEP_NHAN = "NGAY_CHINH_THUC_TIEP_NHAN";
        public const string NGUOI_BAO_LANH = "NGUOI_BAO_LANH";
        public const string HO_TEN = "HO_TEN";
        public const string TEN_DON_VI = "TEN_DON_VI";
        public const string CHUC_VU = "CHUC_VU";
        public const string GT = "GT";
        public const string ID_GD_MA_TRA_CUU_NHAN_VIEN = "ID_GD_MA_TRA_CUU_NHAN_VIEN";
        public const string ID_NHAN_VIEN = "ID_NHAN_VIEN";
        public const string MA_PHONG = "MA_PHONG";
        public const string MA_DOI = "MA_DOI";
        public const string MA_CHUC_VU = "MA_CHUC_VU";
        public const string THU_TU_CHUC_VU = "THU_TU_CHUC_VU";
        public const string SO_HO_SO = "SO_HO_SO";
        public const string MA_TRA_CUU = "MA_TRA_CUU";
        public const string NGUOI_LAP = "NGUOI_LAP";
        public const string NGAY_LAP = "NGAY_LAP";
        public const string NGUOI_SUA = "NGUOI_SUA";
        public const string NGAY_SUA = "NGAY_SUA";
        public const string DA_XOA = "DA_XOA";
    }

    public class V_GD_NHAN_VIEN_PHU_CAP
    {
        public const string MA_QUYET_DINH = "MA_QUYET_DINH";
        public const string NOI_DUNG = "NOI_DUNG";
        public const string NGAY_KY = "NGAY_KY";
        public const string NGAY_HET_HIEU_LUC = "NGAY_HET_HIEU_LUC";
        public const string NGAY_CO_HIEU_LUC = "NGAY_CO_HIEU_LUC";
        public const string MA_NV = "MA_NV";
        public const string HO_TEN = "HO_TEN";
        public const string ID = "ID";
        public const string ID_NHAN_VIEN = "ID_NHAN_VIEN";
        public const string ID_PHU_CAP = "ID_PHU_CAP";
        public const string ID_QUYET_DINH = "ID_QUYET_DINH";
        public const string DA_XOA = "DA_XOA";
        public const string CHUC_VU_TUONG_UNG = "CHUC_VU_TUONG_UNG";
        public const string HS_PHU_CAP = "HS_PHU_CAP";
    }

    public class V_GD_MA_TRA_CUU_NHAN_VIEN
    {
        public const string ID = "ID";
        public const string MA_NV = "MA_NV";
        public const string HO_DEM = "HO_DEM";
        public const string TEN = "TEN";
        public const string GIOI_TINH = "GIOI_TINH";
        public const string EMAIL = "EMAIL";
        public const string SDT = "SDT";
        public const string SO_TAI_KHOAN = "SO_TAI_KHOAN";
        public const string NGAN_HANG = "NGAN_HANG";
        public const string NGAY_CAP_THE = "NGAY_CAP_THE";
        public const string NGAY_HET_HAN_THE = "NGAY_HET_HAN_THE";
        public const string NGAY_SINH = "NGAY_SINH";
        public const string HON_NHAN = "HON_NHAN";
        public const string SO_CMT = "SO_CMT";
        public const string NGAY_CAP = "NGAY_CAP";
        public const string NOI_CAP = "NOI_CAP";
        public const string QUOC_TICH = "QUOC_TICH";
        public const string DAN_TOC = "DAN_TOC";
        public const string TON_GIAO = "TON_GIAO";
        public const string NOI_SINH = "NOI_SINH";
        public const string QUE_QUAN = "QUE_QUAN";
        public const string DIA_CHI_THUONG_TRU = "DIA_CHI_THUONG_TRU";
        public const string DIA_CHI_TAM_TRU = "DIA_CHI_TAM_TRU";
        public const string DIA_CHI_LIEN_LAC = "DIA_CHI_LIEN_LAC";
        public const string MA_SO_THUE_CA_NHAN = "MA_SO_THUE_CA_NHAN";
        public const string CHUYEN_MON = "CHUYEN_MON";
        public const string TRINH_DO_VAN_HOA = "TRINH_DO_VAN_HOA";
        public const string NAM_TOT_NGHIEP = "NAM_TOT_NGHIEP";
        public const string TOT_NGHIEP_TAI = "TOT_NGHIEP_TAI";
        public const string NGAY_VAO_HANG_KHONG = "NGAY_VAO_HANG_KHONG";
        public const string NGAY_TIEP_NHAN_VAO_TCT = "NGAY_TIEP_NHAN_VAO_TCT";
        public const string NGAY_CHINH_THUC_TIEP_NHAN = "NGAY_CHINH_THUC_TIEP_NHAN";
        public const string NGUOI_BAO_LANH = "NGUOI_BAO_LANH";
        public const string HO_TEN = "HO_TEN";
        public const string ID_DON_VI = "ID_DON_VI";
        public const string TEN_DON_VI = "TEN_DON_VI";
        public const string CHUC_VU = "CHUC_VU";
        public const string GT = "GT";
        public const string ID_GD_MA_TRA_CUU_NHAN_VIEN = "ID_GD_MA_TRA_CUU_NHAN_VIEN";
        public const string MA_PHONG = "MA_PHONG";
        public const string MA_DOI = "MA_DOI";
        public const string MA_CHUC_VU = "MA_CHUC_VU";
        public const string THU_TU_CHUC_VU = "THU_TU_CHUC_VU";
        public const string SO_HO_SO = "SO_HO_SO";
        public const string MA_TRA_CUU = "MA_TRA_CUU";
        public const string NGUOI_LAP = "NGUOI_LAP";
        public const string NGAY_LAP = "NGAY_LAP";
        public const string NGUOI_SUA = "NGUOI_SUA";
        public const string NGAY_SUA = "NGAY_SUA";
        public const string DA_XOA = "DA_XOA";
    }


    public class V_DM_TRANG_THAI_LAO_DONG
    {
        public const string ID = "ID";
        public const string MA_TRANG_THAI_LD = "MA_TRANG_THAI_LD";
        public const string TEN_TRANG_THAI_LD = "TEN_TRANG_THAI_LD";
        public const string GHI_CHU = "GHI_CHU";
        public const string ID_LOAI_TRANG_THAI_LD = "ID_LOAI_TRANG_THAI_LD";
        public const string MA_TU_DIEN = "MA_TU_DIEN";
        public const string ID_LOAI_TU_DIEN = "ID_LOAI_TU_DIEN";
        public const string TEN_NGAN = "TEN_NGAN";
        public const string TEN = "TEN";
    }

    public class V_PRT_DANH_SACH_NHAN_VIEN_CON_HAN_HOP_DONG
    {
        public const string ID = "ID";
        public const string MA_NV = "MA_NV";
        public const string HO_TEN = "HO_TEN";
        public const string ID_HOP_DONG = "ID_HOP_DONG";
        public const string ID_LOAI_HOP_DONG = "ID_LOAI_HOP_DONG";
        public const string ID_LUONG_CHE_DO = "ID_LUONG_CHE_DO";
        public const string ID_HE_SO_LNS = "ID_HE_SO_LNS";
        public const string NGAY_BAT_DAU = "NGAY_BAT_DAU";
        public const string NGAY_KET_THUC = "NGAY_KET_THUC";
        public const string NGAY_LAP = "NGAY_LAP";
        public const string NGAY_SUA = "NGAY_SUA";
        public const string NGUOI_LAP = "NGUOI_LAP";
        public const string NGUOI_SUA = "NGUOI_SUA";
        public const string DA_XOA = "DA_XOA";
    }

    public class V_DM_NHAN_VIEN
    {
        public const string ID = "ID";
        public const string MA_NV = "MA_NV";
        public const string HO_DEM = "HO_DEM";
        public const string TEN = "TEN";
        public const string GIOI_TINH = "GIOI_TINH";
        public const string EMAIL = "EMAIL";
        public const string SDT = "SDT";
        public const string SO_TAI_KHOAN = "SO_TAI_KHOAN";
        public const string NGAN_HANG = "NGAN_HANG";
        public const string NGAY_CAP_THE = "NGAY_CAP_THE";
        public const string NGAY_HET_HAN_THE = "NGAY_HET_HAN_THE";
        public const string NGAY_SINH = "NGAY_SINH";
        public const string HON_NHAN = "HON_NHAN";
        public const string SO_CMT = "SO_CMT";
        public const string NGAY_CAP = "NGAY_CAP";
        public const string NOI_CAP = "NOI_CAP";
        public const string QUOC_TICH = "QUOC_TICH";
        public const string DAN_TOC = "DAN_TOC";
        public const string TON_GIAO = "TON_GIAO";
        public const string NOI_SINH = "NOI_SINH";
        public const string QUE_QUAN = "QUE_QUAN";
        public const string DIA_CHI_THUONG_TRU = "DIA_CHI_THUONG_TRU";
        public const string DIA_CHI_TAM_TRU = "DIA_CHI_TAM_TRU";
        public const string DIA_CHI_LIEN_LAC = "DIA_CHI_LIEN_LAC";
        public const string MA_SO_THUE_CA_NHAN = "MA_SO_THUE_CA_NHAN";
        public const string CHUYEN_MON = "CHUYEN_MON";
        public const string TRINH_DO_VAN_HOA = "TRINH_DO_VAN_HOA";
        public const string NAM_TOT_NGHIEP = "NAM_TOT_NGHIEP";
        public const string TOT_NGHIEP_TAI = "TOT_NGHIEP_TAI";
        public const string NGAY_VAO_HANG_KHONG = "NGAY_VAO_HANG_KHONG";
        public const string NGAY_TIEP_NHAN_VAO_TCT = "NGAY_TIEP_NHAN_VAO_TCT";
        public const string NGAY_CHINH_THUC_TIEP_NHAN = "NGAY_CHINH_THUC_TIEP_NHAN";
        public const string NGUOI_BAO_LANH = "NGUOI_BAO_LANH";
        public const string HO_TEN = "HO_TEN";
        public const string ID_DON_VI = "ID_DON_VI";
        public const string TEN_DON_VI = "TEN_DON_VI";
        public const string CHUC_VU = "CHUC_VU";
        public const string GT = "GT";
    }





    public class V_F320_LAP_HOP_DONG
    {
        public const string ID = "ID";
        public const string ID_NHAN_VIEN = "ID_NHAN_VIEN";
        public const string MA_NV = "MA_NV";
        public const string HO_TEN = "HO_TEN";
        public const string ID_LOAI_HOP_DONG = "ID_LOAI_HOP_DONG";
        public const string LOAI_HOP_DONG = "LOAI_HOP_DONG";
        public const string MA_LOAI_HOP_DONG = "MA_LOAI_HOP_DONG";
        public const string MA_HOP_DONG = "MA_HOP_DONG";
        public const string NGAY_BAT_DAU = "NGAY_BAT_DAU";
        public const string NGAY_KET_THUC = "NGAY_KET_THUC";
        public const string NGAY_KY_HOP_DONG = "NGAY_KY_HOP_DONG";
        public const string NGAY_LAP = "NGAY_LAP";
        public const string NGAY_SUA = "NGAY_SUA";
        public const string NGUOI_LAP = "NGUOI_LAP";
        public const string NGUOI_SUA = "NGUOI_SUA";
        public const string DA_XOA = "DA_XOA";
    }

    public class V_F330_LEN_LUONG_CHO_NV
    {
        public const string ID = "ID";
        public const string MA_NV = "MA_NV";
        public const string HO_DEM = "HO_DEM";
        public const string TEN = "TEN";
        public const string HO_TEN = "HO_TEN";
        public const string ID_HOP_DONG = "ID_HOP_DONG";
        public const string ID_LOAI_HOP_DONG = "ID_LOAI_HOP_DONG";
        public const string LOAI_HOP_DONG = "LOAI_HOP_DONG";
        public const string MA_HOP_DONG = "MA_HOP_DONG";
        public const string NGAY_BAT_DAU = "NGAY_BAT_DAU";
        public const string NGAY_KET_THUC = "NGAY_KET_THUC";
        public const string NGAY_KY_HOP_DONG = "NGAY_KY_HOP_DONG";
        public const string NGAY_LAP = "NGAY_LAP";
        public const string NGAY_SUA = "NGAY_SUA";
        public const string NGUOI_LAP = "NGUOI_LAP";
        public const string NGUOI_SUA = "NGUOI_SUA";
        public const string DA_XOA = "DA_XOA";
        public const string ID_GD_HS_LNS_LCD = "ID_GD_HS_LNS_LCD";
        public const string ID_QUYET_DINH = "ID_QUYET_DINH";
        public const string MA_QUYET_DINH = "MA_QUYET_DINH";
        public const string ID_LOAI_QD = "ID_LOAI_QD";
        public const string MA_LOAI_QD = "MA_LOAI_QD";
        public const string TEN_LOAI_QD = "TEN_LOAI_QD";
        public const string ID_HS_LNS = "ID_HS_LNS";
        public const string ID_MA_LNS = "ID_MA_LNS";
        public const string MA_LNS = "MA_LNS";
        public const string TEN_MA_LNS = "TEN_MA_LNS";
        public const string ID_MUC_LNS = "ID_MUC_LNS";
        public const string MUC_LNS = "MUC_LNS";
        public const string TEN_MUC_LNS = "TEN_MUC_LNS";
        public const string HE_SO_LNS = "HE_SO_LNS";
        public const string ID_LOAI_LAO_DONG = "ID_LOAI_LAO_DONG";
        public const string ID_LCD = "ID_LCD";
        public const string ID_MA_LCD = "ID_MA_LCD";
        public const string MA_LCD = "MA_LCD";
        public const string TEN_MA_LCD = "TEN_MA_LCD";
        public const string ID_MUC_LCD = "ID_MUC_LCD";
        public const string MUC_LCD = "MUC_LCD";
        public const string TEN_MUC_LCD = "TEN_MUC_LCD";
        public const string SO_TIEN_LCD = "SO_TIEN_LCD";
        public const string NGAY_LAP_GD_HS_LNS_LCD = "NGAY_LAP_GD_HS_LNS_LCD";
        public const string NGAY_SUA_GD_HS_LNS_LCD = "NGAY_SUA_GD_HS_LNS_LCD";
        public const string NGUOI_LAP_GD_HS_LNS_LCD = "NGUOI_LAP_GD_HS_LNS_LCD";
        public const string NGUOI_SUA_GD_HS_LNS_LCD = "NGUOI_SUA_GD_HS_LNS_LCD";
        public const string MA_LOAI_HOP_DONG = "MA_LOAI_HOP_DONG";
        public const string MA_TU_DIEN = "MA_TU_DIEN";
    }


    public class V_GD_QUYET_DINH
    {
        public const string ID = "ID";
        public const string MA_QUYET_DINH = "MA_QUYET_DINH";
        public const string ID_LOAI_QD = "ID_LOAI_QD";
        public const string MA_TU_DIEN = "MA_TU_DIEN";
        public const string TEN_NGAN = "TEN_NGAN";
        public const string TEN = "TEN";
        public const string NGAY_CO_HIEU_LUC = "NGAY_CO_HIEU_LUC";
        public const string NGAY_KY = "NGAY_KY";
        public const string NGUOI_KY = "NGUOI_KY";
        public const string NGAY_HET_HIEU_LUC = "NGAY_HET_HIEU_LUC";
        public const string NOI_DUNG = "NOI_DUNG";
        public const string LINK = "LINK";
    }

    public class V_F340_DAT_HS_LNS
    {
        public const string ID = "ID";
        public const string MA_NV = "MA_NV";
        public const string HO_DEM = "HO_DEM";
        public const string TEN = "TEN";
        public const string HO_TEN = "HO_TEN";
        public const string ID_HOP_DONG = "ID_HOP_DONG";
        public const string MA_HOP_DONG = "MA_HOP_DONG";
        public const string ID_LOAI_HOP_DONG = "ID_LOAI_HOP_DONG";
        public const string MA_LOAI_HOP_DONG = "MA_LOAI_HOP_DONG";
        public const string LOAI_HOP_DONG = "LOAI_HOP_DONG";
        public const string ID_GD_HS_LNS = "ID_GD_HS_LNS";
        public const string HE_SO_LNS = "HE_SO_LNS";
        public const string ID_LY_DO_CHINH_SUA_LNS = "ID_LY_DO_CHINH_SUA_LNS";
        public const string MA_LY_DO_CHINH_SUA_LNS = "MA_LY_DO_CHINH_SUA_LNS";
        public const string TEN_LY_DO_CHINH_SUA_LNS = "TEN_LY_DO_CHINH_SUA_LNS";
        public const string GHI_CHU_LNS = "GHI_CHU_LNS";
        public const string NGAY_BAT_DAU_LNS = "NGAY_BAT_DAU_LNS";
        public const string NGAY_KET_THU_LNS = "NGAY_KET_THU_LNS";
        public const string NGAY_LAP_LNS = "NGAY_LAP_LNS";
        public const string NGAY_SUA_LNS = "NGAY_SUA_LNS";
        public const string NGUOI_LAP_LNS = "NGUOI_LAP_LNS";
        public const string NGUOI_SUA_LNS = "NGUOI_SUA_LNS";
        public const string DA_XOA_LNS = "DA_XOA_LNS";
    }

    public class V_F340_DAT_LCD
    {
        public const string ID = "ID";
        public const string MA_NV = "MA_NV";
        public const string HO_DEM = "HO_DEM";
        public const string TEN = "TEN";
        public const string HO_TEN = "HO_TEN";
        public const string ID_HOP_DONG = "ID_HOP_DONG";
        public const string MA_HOP_DONG = "MA_HOP_DONG";
        public const string ID_LOAI_HOP_DONG = "ID_LOAI_HOP_DONG";
        public const string MA_LOAI_HOP_DONG = "MA_LOAI_HOP_DONG";
        public const string LOAI_HOP_DONG = "LOAI_HOP_DONG";
        public const string ID_LCD = "ID_LCD";
        public const string SO_TIEN_LCD = "SO_TIEN_LCD";
        public const string ID_LY_DO_CHINH_SUA_LCD = "ID_LY_DO_CHINH_SUA_LCD";
        public const string MA_LY_DO_CHINH_SUA_LCD = "MA_LY_DO_CHINH_SUA_LCD";
        public const string TEN_LY_DO_CHINH_SUA_LCD = "TEN_LY_DO_CHINH_SUA_LCD";
        public const string GHI_CHU_LCD = "GHI_CHU_LCD";
        public const string NGAY_BAT_DAU_LCD = "NGAY_BAT_DAU_LCD";
        public const string NGAY_KET_THUC_LCD = "NGAY_KET_THUC_LCD";
        public const string NGAY_LAP_LCD = "NGAY_LAP_LCD";
        public const string NGAY_SUA_LCD = "NGAY_SUA_LCD";
        public const string NGUOI_LAP_LCD = "NGUOI_LAP_LCD";
        public const string NGUOI_SUA_LCD = "NGUOI_SUA_LCD";
        public const string DA_XOA_LCD = "DA_XOA_LCD";
    }

    public class RPT_LUONG
    {
        public const string ID = "ID";
        public const string ID_NHAN_VIEN = "ID_NHAN_VIEN";
        public const string THANG = "THANG";
        public const string NAM = "NAM";
        public const string MA_NV = "MA_NV";
        public const string LUONG_NS = "LUONG_NS";
        public const string LUONG_CD = "LUONG_CD";
        public const string PHU_CAP_TN = "PHU_CAP_TN";
        public const string AN_CA = "AN_CA";
        public const string LAM_THEM = "LAM_THEM";
        public const string LAM_THEM_LE_TET = "LAM_THEM_LE_TET";
        public const string LUONG_KHAC_THUE_5 = "LUONG_KHAC_THUE_5";
        public const string LUONG_KHAC_THUE_10 = "LUONG_KHAC_THUE_10";
        public const string LUONG_KHAC_THUE_TINH_THEO_LUONG = "LUONG_KHAC_THUE_TINH_THEO_LUONG";
        public const string THU_NHAP = "THU_NHAP";
        public const string BHXH = "BHXH";
        public const string BHYT = "BHYT";
        public const string BHTN = "BHTN";
        public const string DOAN_PHI_CD = "DOAN_PHI_CD";
        public const string THUE = "THUE";
        public const string THUE_TU_LUONG_KHAC_5 = "THUE_TU_LUONG_KHAC_5";
        public const string THUE_TU_LUONG_KHAC_10 = "THUE_TU_LUONG_KHAC_10";
        public const string PHAI_NOP = "PHAI_NOP";
        public const string THUC_LINH = "THUC_LINH";
        public const string TRUY_LINH = "TRUY_LINH";
        public const string TRUY_THU = "TRUY_THU";
        public const string THUC_LINH_CUOI_CUNG = "THUC_LINH_CUOI_CUNG";
        public const string SO_NGAY_LAM_THEM = "SO_NGAY_LAM_THEM";
    }




    public class V_F419_BAO_CAO_HS_LNS_LCD_NHAN_VIEN_THEO_THANG
    {
        public const string ID_NHAN_VIEN = "ID_NHAN_VIEN";
        public const string MA_NV = "MA_NV";
        public const string HO_DEM = "HO_DEM";
        public const string TEN = "TEN";
        public const string HO_TEN = "HO_TEN";
        public const string ID_HOP_DONG = "ID_HOP_DONG";
        public const string NGAY_BAT_DAU_HOP_DONG = "NGAY_BAT_DAU_HOP_DONG";
        public const string NGAY_KET_THUC_HOP_DONG = "NGAY_KET_THUC_HOP_DONG";
        public const string DA_XOA_HOP_DONG_YN = "DA_XOA_HOP_DONG_YN";
        public const string ID_GD_HS_LNS = "ID_GD_HS_LNS";
        public const string HE_SO_LNS = "HE_SO_LNS";
        public const string NGAY_BAT_DAU_HS_LNS = "NGAY_BAT_DAU_HS_LNS";
        public const string NGAY_KET_THUC_HS_LNS = "NGAY_KET_THUC_HS_LNS";
        public const string DA_XOA_HS_LNS_YN = "DA_XOA_HS_LNS_YN";
        public const string ID_GD_LCD = "ID_GD_LCD";
        public const string LUONG_CHE_DO = "LUONG_CHE_DO";
        public const string NGAY_BAT_DAU_LCD = "NGAY_BAT_DAU_LCD";
        public const string NGAY_KET_THUC_LCD = "NGAY_KET_THUC_LCD";
        public const string DA_XOA_LCD = "DA_XOA_LCD";
    }

    public class V_F395_QUAN_LY_PHU_CAP_NHAN_VIEN
    {
        public const string ID = "ID";
        public const string ID_NHAN_VIEN = "ID_NHAN_VIEN";
        public const string MA_NV = "MA_NV";
        public const string HO_DEM = "HO_DEM";
        public const string TEN = "TEN";
        public const string HO_TEN = "HO_TEN";
        public const string ID_PHU_CAP = "ID_PHU_CAP";
        public const string ID_LOAI_PHU_CAP = "ID_LOAI_PHU_CAP";
        public const string MA_TU_DIEN = "MA_TU_DIEN";
        public const string TEN_NGAN = "TEN_NGAN";
        public const string TEN_LOAI_PHU_CAP = "TEN_LOAI_PHU_CAP";
        public const string DOI_TUONG_HUONG_PHU_CAP = "DOI_TUONG_HUONG_PHU_CAP";
        public const string TI_LE = "TI_LE";
        public const string ID_QUYET_DINH = "ID_QUYET_DINH";
        public const string MA_QUYET_DINH = "MA_QUYET_DINH";
        public const string TEN_NGAN_QUYET_DINH = "TEN_NGAN_QUYET_DINH";
        public const string TEN_QUYET_DINH = "TEN_QUYET_DINH";
        public const string NGUOI_LAP = "NGUOI_LAP";
        public const string NGUOI_SUA = "NGUOI_SUA";
        public const string NGAY_LAP = "NGAY_LAP";
        public const string NGAY_SUA = "NGAY_SUA";
        public const string DA_XOA = "DA_XOA";
    }

    public class V_DM_PHU_CAP_HDH
    {
        public const string ID = "ID";
        public const string ID_LOAI_PHU_CAP = "ID_LOAI_PHU_CAP";
        public const string MA_LOAI_PHU_CAP = "MA_LOAI_PHU_CAP";
        public const string TEN_NGAN_LOAI_PHU_CAP = "TEN_NGAN_LOAI_PHU_CAP";
        public const string TEN_LOAI_PHU_CAP = "TEN_LOAI_PHU_CAP";
        public const string DOI_TUONG_HUONG_PHU_CAP = "DOI_TUONG_HUONG_PHU_CAP";
        public const string TI_LE = "TI_LE";
    }

    public class V_F419_BAO_CAO_HS_LNS_NHAN_VIEN_THEO_THANG
    {
        public const string ID_NHAN_VIEN = "ID_NHAN_VIEN";
        public const string MA_NV = "MA_NV";
        public const string HO_DEM = "HO_DEM";
        public const string TEN = "TEN";
        public const string HO_TEN = "HO_TEN";
        public const string ID_HOP_DONG = "ID_HOP_DONG";
        public const string NGAY_BAT_DAU_HOP_DONG = "NGAY_BAT_DAU_HOP_DONG";
        public const string NGAY_KET_THUC_HOP_DONG = "NGAY_KET_THUC_HOP_DONG";
        public const string DA_XOA_HOP_DONG_YN = "DA_XOA_HOP_DONG_YN";
        public const string ID_GD_HS_LNS = "ID_GD_HS_LNS";
        public const string HE_SO_LNS = "HE_SO_LNS";
        public const string NGAY_BAT_DAU_HS_LNS = "NGAY_BAT_DAU_HS_LNS";
        public const string NGAY_KET_THUC_HS_LNS = "NGAY_KET_THUC_HS_LNS";
        public const string DA_XOA_HS_LNS_YN = "DA_XOA_HS_LNS_YN";
        public const string ID_LY_DO_CHINH_SUA_HS_LNS = "ID_LY_DO_CHINH_SUA_HS_LNS";
        public const string LY_DO_CHINH_SUA_HS_LNS = "LY_DO_CHINH_SUA_HS_LNS";
        public const string GHI_CHU_HS_LNS = "GHI_CHU_HS_LNS";
    }


    public class V_F419_BAO_CAO_LCD_NHAN_VIEN_THEO_THANG
    {
        public const string ID_NHAN_VIEN = "ID_NHAN_VIEN";
        public const string MA_NV = "MA_NV";
        public const string HO_DEM = "HO_DEM";
        public const string TEN = "TEN";
        public const string HO_TEN = "HO_TEN";
        public const string ID_HOP_DONG = "ID_HOP_DONG";
        public const string NGAY_BAT_DAU_HOP_DONG = "NGAY_BAT_DAU_HOP_DONG";
        public const string NGAY_KET_THUC_HOP_DONG = "NGAY_KET_THUC_HOP_DONG";
        public const string DA_XOA_HOP_DONG_YN = "DA_XOA_HOP_DONG_YN";
        public const string ID_GD_LCD = "ID_GD_LCD";
        public const string LUONG_CHE_DO = "LUONG_CHE_DO";
        public const string NGAY_BAT_DAU_LCD = "NGAY_BAT_DAU_LCD";
        public const string NGAY_KET_THUC_LCD = "NGAY_KET_THUC_LCD";
        public const string DA_XOA_LCD = "DA_XOA_LCD";
        public const string ID_LY_DO_CHINH_SUA_LCD = "ID_LY_DO_CHINH_SUA_LCD";
        public const string LY_DO_CHINH_SUA_LCD = "LY_DO_CHINH_SUA_LCD";
        public const string GHI_CHU_LCD = "GHI_CHU_LCD";
    }

    public class V_F356_BAO_CAO_TRANG_THAI_LAO_DONG_CUA_NHAN_VIEN
    {
        public const string ID = "ID";
        public const string ID_NV = "ID_NV";
        public const string MA_NV = "MA_NV";
        public const string HO_TEN = "HO_TEN";
        public const string ID_TRANG_THAI_LAO_DONG = "ID_TRANG_THAI_LAO_DONG";
        public const string TEN_TRANG_THAI_LD = "TEN_TRANG_THAI_LD";
        public const string NGAY_AP_DUNG = "NGAY_AP_DUNG";
        public const string NGAY_KET_THUC = "NGAY_KET_THUC";
        public const string GHI_CHU = "GHI_CHU";
        public const string NGAY_LAP = "NGAY_LAP";
        public const string NGUOI_LAP = "NGUOI_LAP";
        public const string NGAY_SUA = "NGAY_SUA";
        public const string NGUOI_SUA = "NGUOI_SUA";
        public const string DA_XOA = "DA_XOA";
    }



    #endregion
    public class V_GD_CONG_TAC_2
    {
        public const string ID = "ID";
        public const string ID_NHAN_VIEN = "ID_NHAN_VIEN";
        public const string ID_QUYET_DINH = "ID_QUYET_DINH";
        public const string ID_DON_VI = "ID_DON_VI";
        public const string NGAY_BAT_DAU = "NGAY_BAT_DAU";
        public const string NGAY_KET_THUC = "NGAY_KET_THUC";
        public const string NGAY_LAP = "NGAY_LAP";
        public const string NGAY_SUA = "NGAY_SUA";
        public const string NGUOI_LAP = "NGUOI_LAP";
        public const string NGUOI_SUA = "NGUOI_SUA";
        public const string DA_XOA = "DA_XOA";
        public const string ID_LOAI_CONG_TAC = "ID_LOAI_CONG_TAC";
        public const string ID_VI_TRI = "ID_VI_TRI";
        public const string TEN_DON_VI = "TEN_DON_VI";
        public const string MA_DON_VI = "MA_DON_VI";
        public const string LOAI_CONG_TAC = "LOAI_CONG_TAC";
        public const string CHUC_DANH = "CHUC_DANH";
        public const string MA_NV = "MA_NV";
        public const string HO_DEM = "HO_DEM";
        public const string TEN = "TEN";
        public const string HO_TEN = "HO_TEN";
        public const string GIOI_TINH = "GIOI_TINH";
        public const string EMAIL = "EMAIL";
        public const string SDT = "SDT";
        public const string SO_TAI_KHOAN = "SO_TAI_KHOAN";
        public const string NGAN_HANG = "NGAN_HANG";
        public const string NGAY_CAP_THE = "NGAY_CAP_THE";
        public const string NGAY_HET_HAN_THE = "NGAY_HET_HAN_THE";
        public const string NGAY_SINH = "NGAY_SINH";
        public const string HON_NHAN = "HON_NHAN";
        public const string SO_CMT = "SO_CMT";
        public const string NGAY_CAP = "NGAY_CAP";
        public const string NOI_CAP = "NOI_CAP";
        public const string QUOC_TICH = "QUOC_TICH";
        public const string DAN_TOC = "DAN_TOC";
        public const string TON_GIAO = "TON_GIAO";
        public const string NOI_SINH = "NOI_SINH";
        public const string QUE_QUAN = "QUE_QUAN";
        public const string DIA_CHI_THUONG_TRU = "DIA_CHI_THUONG_TRU";
        public const string DIA_CHI_TAM_TRU = "DIA_CHI_TAM_TRU";
        public const string DIA_CHI_LIEN_LAC = "DIA_CHI_LIEN_LAC";
        public const string MA_SO_THUE_CA_NHAN = "MA_SO_THUE_CA_NHAN";
        public const string CHUYEN_MON = "CHUYEN_MON";
        public const string TRINH_DO_VAN_HOA = "TRINH_DO_VAN_HOA";
        public const string NAM_TOT_NGHIEP = "NAM_TOT_NGHIEP";
        public const string TOT_NGHIEP_TAI = "TOT_NGHIEP_TAI";
        public const string NGAY_VAO_HANG_KHONG = "NGAY_VAO_HANG_KHONG";
        public const string NGAY_TIEP_NHAN_VAO_TCT = "NGAY_TIEP_NHAN_VAO_TCT";
        public const string NGAY_CHINH_THUC_TIEP_NHAN = "NGAY_CHINH_THUC_TIEP_NHAN";
        public const string NGUOI_BAO_LANH = "NGUOI_BAO_LANH";
        public const string MA_TRA_CUU = "MA_TRA_CUU";
        public const string THU_TU_CHUC_VU = "THU_TU_CHUC_VU";
    }




    public class V_DM_DON_VI_2
    {
        public const string ID = "ID";
        public const string TEN_DON_VI = "TEN_DON_VI";
        public const string MA_DON_VI = "MA_DON_VI";
        public const string ID_LOAI_DON_VI = "ID_LOAI_DON_VI";
        public const string ID_DON_VI_CAP_TREN = "ID_DON_VI_CAP_TREN";
        public const string ID_DV_0 = "ID_DV_0";
        public const string ID_DV_1 = "ID_DV_1";
        public const string ID_DV_2 = "ID_DV_2";
        public const string ID_DV_3 = "ID_DV_3";
        public const string ID_DV_4 = "ID_DV_4";
        public const string TANG = "TANG";
        public const string SO_LUONG_NS_DANG_CONG_TAC = "SO_LUONG_NS_DANG_CONG_TAC";
    }

    public class BT_DM_DON_VI_DE_LAM_BAO_CAO_DAC_TRUNG
    {
        public const string ID = "ID";
        public const string ID_DON_VI = "ID_DON_VI";
        public const string TEN_DON_VI = "TEN_DON_VI";
        public const string ID_BT_DON_VI_CAP_TREN = "ID_BT_DON_VI_CAP_TREN";
        public const string LEVEL_DON_VI = "LEVEL_DON_VI";
    }

    public class V_TNK_GD_QUY_THU_NHAP_KHAC
    {
        public const string ID = "ID";
        public const string TEN_QUY = "TEN_QUY";
        public const string THANG = "THANG";
        public const string NAM = "NAM";
        public const string NGUOI_LAP = "NGUOI_LAP";
        public const string NGAY_LAP = "NGAY_LAP";
        public const string NGAY_LAP_PHAN_MEM = "NGAY_LAP_PHAN_MEM";
        public const string NGUOI_LAP_PHAN_MEM = "NGUOI_LAP_PHAN_MEM";
        public const string TU_NGAY_XET_THUONG = "TU_NGAY_XET_THUONG";
        public const string DEN_NGAY_XET_THUONG = "DEN_NGAY_XET_THUONG";
        public const string LY_DO_THUONG = "LY_DO_THUONG";
        public const string GHI_CHU = "GHI_CHU";
        public const string DA_XOA = "DA_XOA";
        public const string ID_LOAI_QUY_THU_NHAP_KHAC = "ID_LOAI_QUY_THU_NHAP_KHAC";
        public const string TEN_LOAI_THU_NHAP_KHAC = "TEN_LOAI_THU_NHAP_KHAC";
        public const string SO_LUONG_NV_TRONG_QUY = "SO_LUONG_NV_TRONG_QUY";
        public const string CO_DU_LIEU = "CO_DU_LIEU";
        public const string TONG_TIEN = "TONG_TIEN";
        public const string TONG_TIEN_NOP_THUE = "TONG_TIEN_NOP_THUE";
        public const string TONG_TIEN_THUC_LINH = "TONG_TIEN_THUC_LINH";
    }

    public class GD_QUY_THU_NHAP_KHAC
    {
        public const string ID = "ID";
        public const string TEN_QUY = "TEN_QUY";
        public const string THANG = "THANG";
        public const string NAM = "NAM";
        public const string NGUOI_LAP = "NGUOI_LAP";
        public const string NGAY_LAP = "NGAY_LAP";
        public const string NGAY_LAP_PHAN_MEM = "NGAY_LAP_PHAN_MEM";
        public const string NGUOI_LAP_PHAN_MEM = "NGUOI_LAP_PHAN_MEM";
        public const string TU_NGAY_XET_THUONG = "TU_NGAY_XET_THUONG";
        public const string DEN_NGAY_XET_THUONG = "DEN_NGAY_XET_THUONG";
        public const string LY_DO_THUONG = "LY_DO_THUONG";
        public const string GHI_CHU = "GHI_CHU";
        public const string DA_XOA = "DA_XOA";
        public const string ID_LOAI_QUY_THU_NHAP_KHAC = "ID_LOAI_QUY_THU_NHAP_KHAC";
    }


    public class GD_CHAM_CONG_LAM_THEM
    {
        public const string ID = "ID";
        public const string ID_NHAN_VIEN = "ID_NHAN_VIEN";
        public const string THANG = "THANG";
        public const string NAM = "NAM";
        public const string SO_NGAY_LAM_THEM = "SO_NGAY_LAM_THEM";
    }
    public class RPT_THONG_TIN_TONG_HOP_V2
    {
        public const string ID = "ID";
        public const string THANG = "THANG";
        public const string NAM = "NAM";
        public const string ID_NHAN_VIEN = "ID_NHAN_VIEN";
        public const string MA_NV = "MA_NV";
        public const string HO_DEM = "HO_DEM";
        public const string TEN = "TEN";
        public const string HO_VA_TEN = "HO_VA_TEN";
        public const string TEN_CHUC_VU = "TEN_CHUC_VU";
        public const string TEN_HOP_DONG = "TEN_HOP_DONG";
        public const string LUONG_CHE_DO_THEO_CHUC_VU = "LUONG_CHE_DO_THEO_CHUC_VU";
        public const string HS_LUONG_NANG_SUAT_DUOC_HUONG = "HS_LUONG_NANG_SUAT_DUOC_HUONG";
        public const string TAI_KHOAN = "TAI_KHOAN";
        public const string CHAM_CONG_X = "CHAM_CONG_X";
        public const string CHAM_CONG_OM_CO = "CHAM_CONG_OM_CO";
        public const string CHAM_CONG_TS = "CHAM_CONG_TS";
        public const string CHAM_CONG_TNLD = "CHAM_CONG_TNLD";
        public const string CHAM_CONG_PHEP_DIDUONG = "CHAM_CONG_PHEP_DIDUONG";
        public const string CHAM_CONG_RO_KO_DC = "CHAM_CONG_RO_KO_DC";
        public const string CHAM_CONG_KHAC = "CHAM_CONG_KHAC";
        public const string HE_SO_K = "HE_SO_K";
        public const string DON_VI = "DON_VI";
        public const string NGAY_CONG_QUY_DINH = "NGAY_CONG_QUY_DINH";
        public const string LOAI_LAO_DONG = "LOAI_LAO_DONG";
        public const string SO_NGAY_LAM_THEM = "SO_NGAY_LAM_THEM";
        public const string HS_ATHK = "HS_ATHK";
        public const string HS_BSL = "HS_BSL";
        public const string LE_TET_YN = "LE_TET_YN";
        public const string TI_LE_HOP_DONG = "TI_LE_HOP_DONG";
    }

    public class RPT_THONG_TIN_TONG_HOP
    {
        public const string ID = "ID";
        public const string THANG = "THANG";
        public const string NAM = "NAM";
        public const string ID_NHAN_VIEN = "ID_NHAN_VIEN";
        public const string MA_NV = "MA_NV";
        public const string HO_DEM = "HO_DEM";
        public const string TEN = "TEN";
        public const string HO_VA_TEN = "HO_VA_TEN";
        public const string TEN_CHUC_VU = "TEN_CHUC_VU";
        public const string TEN_HOP_DONG = "TEN_HOP_DONG";
        public const string LUONG_CHE_DO_THEO_CHUC_VU = "LUONG_CHE_DO_THEO_CHUC_VU";
        public const string HS_LUONG_NANG_SUAT_DUOC_HUONG = "HS_LUONG_NANG_SUAT_DUOC_HUONG";
        public const string TAI_KHOAN = "TAI_KHOAN";
        public const string CHAM_CONG_X = "CHAM_CONG_X";
        public const string CHAM_CONG_OM_CO = "CHAM_CONG_OM_CO";
        public const string CHAM_CONG_TS = "CHAM_CONG_TS";
        public const string CHAM_CONG_TNLD = "CHAM_CONG_TNLD";
        public const string CHAM_CONG_PHEP_DIDUONG = "CHAM_CONG_PHEP_DIDUONG";
        public const string CHAM_CONG_RO_KO_DC = "CHAM_CONG_RO_KO_DC";
        public const string CHAM_CONG_KHAC = "CHAM_CONG_KHAC";
        public const string HE_SO_K = "HE_SO_K";
        public const string DON_VI = "DON_VI";
    }

    public class THAM_SO_TINH_BANG_LUONG
    {
        public const string CO_DON_VI_CONG_TAC = "CO_DON_VI_CONG_TAC";
        public const string DA_CHAM_CONG = "DA_CHAM_CONG";
    }

    public class RPT_LUONG_V2
    {
        //Tu viet, ko gen tu gen_columns_name
        public const string HO_TEN = "HO_TEN";
        public const string TEN_DON_VI = "TEN_DON_VI";
        public const string THU_TU_DON_VI = "THU_TU_DON_VI";
        public const string TEN_CHUC_VU = "TEN_CHUC_VU";
        public const string THU_TU_CHUC_VU = "THU_TU_CHUC_VU";
        public const string ID = "ID";
        public const string ID_NHAN_VIEN = "ID_NHAN_VIEN";
        public const string THANG = "THANG";
        public const string NAM = "NAM";
        public const string MA_NV = "MA_NV";
        public const string LUONG_NS = "LUONG_NS";
        public const string LUONG_CD = "LUONG_CD";
        public const string PHU_CAP_TN = "PHU_CAP_TN";
        public const string AN_CA = "AN_CA";
        public const string LAM_THEM = "LAM_THEM";
        public const string LAM_THEM_200 = "LAM_THEM_200";
        public const string LAM_THEM_300 = "LAM_THEM_300";
        public const string THU_NHAP_KHAC_TRONG_LUONG = "THU_NHAP_KHAC_TRONG_LUONG";
        public const string TONG_THU_NHAP_TRONG_LUONG = "TONG_THU_NHAP_TRONG_LUONG";
        public const string THUONG = "THUONG";
        public const string THUONG_ATHK = "THUONG_ATHK";
        public const string THUONG_LE_TET = "THUONG_LE_TET";
        public const string BO_SUNG_LUONG = "BO_SUNG_LUONG";
        public const string THU_NHAP_KHAC_NGOAI_LUONG = "THU_NHAP_KHAC_NGOAI_LUONG";
        public const string TONG_THU_NHAP_NGOAI_LUONG = "TONG_THU_NHAP_NGOAI_LUONG";
        public const string TONG_THU_NHAP = "TONG_THU_NHAP";
        public const string BHXH = "BHXH";
        public const string BHYT = "BHYT";
        public const string BHTN = "BHTN";
        public const string GIAM_TRU_LAM_THEM_150 = "GIAM_TRU_LAM_THEM_150";
        public const string GIAM_TRU_LAM_THEM_200 = "GIAM_TRU_LAM_THEM_200";
        public const string GIAM_TRU_LAM_THEM_300 = "GIAM_TRU_LAM_THEM_300";
        public const string GIAM_TRU_GIA_CANH = "GIAM_TRU_GIA_CANH";
        public const string GIAM_TRU_PHU_THUOC = "GIAM_TRU_PHU_THUOC";
        public const string GIAM_TRU_KHAC = "GIAM_TRU_KHAC";
        public const string TONG_GIAM_TRU = "TONG_GIAM_TRU";
        public const string THU_NHAP_CHIU_THUE = "THU_NHAP_CHIU_THUE";
        public const string DOAN_PHI_CD = "DOAN_PHI_CD";
        public const string THUE = "THUE";
        public const string PHAI_NOP_KHAC = "PHAI_NOP_KHAC";
        public const string TONG_PHAI_NOP = "TONG_PHAI_NOP";
        public const string THUC_LINH = "THUC_LINH";
        public const string SO_TIEN_DA_NOP_THUE = "SO_TIEN_DA_NOP_THUE";
        public const string TONG_GIAM_TRU_THUE = "TONG_GIAM_TRU_THUE";
        public const string TONG_THU_NHAP_CHIU_THUE = "TONG_THU_NHAP_CHIU_THUE";
    }


    public class V_RPT_LUONG_V2
    {
        public const string ID = "ID";
        public const string ID_NHAN_VIEN = "ID_NHAN_VIEN";
        public const string THANG = "THANG";
        public const string NAM = "NAM";
        public const string MA_NV = "MA_NV";
        public const string LUONG_NS = "LUONG_NS";
        public const string LUONG_CD = "LUONG_CD";
        public const string PHU_CAP_TN = "PHU_CAP_TN";
        public const string AN_CA = "AN_CA";
        public const string LAM_THEM = "LAM_THEM";
        public const string LAM_THEM_200 = "LAM_THEM_200";
        public const string LAM_THEM_300 = "LAM_THEM_300";
        public const string THU_NHAP_KHAC_TRONG_LUONG = "THU_NHAP_KHAC_TRONG_LUONG";
        public const string TONG_THU_NHAP_TRONG_LUONG = "TONG_THU_NHAP_TRONG_LUONG";
        public const string THUONG = "THUONG";
        public const string THUONG_ATHK = "THUONG_ATHK";
        public const string THUONG_LE_TET = "THUONG_LE_TET";
        public const string BO_SUNG_LUONG = "BO_SUNG_LUONG";
        public const string THU_NHAP_KHAC_NGOAI_LUONG = "THU_NHAP_KHAC_NGOAI_LUONG";
        public const string TONG_THU_NHAP_NGOAI_LUONG = "TONG_THU_NHAP_NGOAI_LUONG";
        public const string TONG_THU_NHAP = "TONG_THU_NHAP";
        public const string BHXH = "BHXH";
        public const string BHYT = "BHYT";
        public const string BHTN = "BHTN";
        public const string GIAM_TRU_LAM_THEM_150 = "GIAM_TRU_LAM_THEM_150";
        public const string GIAM_TRU_LAM_THEM_200 = "GIAM_TRU_LAM_THEM_200";
        public const string GIAM_TRU_LAM_THEM_300 = "GIAM_TRU_LAM_THEM_300";
        public const string GIAM_TRU_GIA_CANH = "GIAM_TRU_GIA_CANH";
        public const string GIAM_TRU_PHU_THUOC = "GIAM_TRU_PHU_THUOC";
        public const string GIAM_TRU_KHAC = "GIAM_TRU_KHAC";
        public const string TONG_GIAM_TRU = "TONG_GIAM_TRU";
        public const string THU_NHAP_CHIU_THUE = "THU_NHAP_CHIU_THUE";
        public const string DOAN_PHI_CD = "DOAN_PHI_CD";
        public const string THUE = "THUE";
        public const string PHAI_NOP_KHAC = "PHAI_NOP_KHAC";
        public const string TONG_PHAI_NOP = "TONG_PHAI_NOP";
        public const string THUC_LINH = "THUC_LINH";
        public const string TEN_DON_VI = "TEN_DON_VI";
        public const string HO_TEN = "HO_TEN";
        public const string SO_TAI_KHOAN = "SO_TAI_KHOAN";
        public const string HO_DEM = "HO_DEM";
        public const string TEN = "TEN";
        public const string THU_TU_DON_VI = "THU_TU_DON_VI";
    }

    public class V_F320_DANH_SACH_HOP_DONG_DA_KY_THEO_THOI_GIAN
    {
        public const string ID = "ID";
        public const string ID_NHAN_VIEN = "ID_NHAN_VIEN";
        public const string MA_NV = "MA_NV";
        public const string HO_DEM = "HO_DEM";
        public const string TEN = "TEN";
        public const string HO_TEN = "HO_TEN";
        public const string ID_TRANG_THAI_LAO_DONG = "ID_TRANG_THAI_LAO_DONG";
        public const string ID_LOAI_HOP_DONG = "ID_LOAI_HOP_DONG";
        public const string MA_HOP_DONG = "MA_HOP_DONG";
        public const string NGAY_BAT_DAU = "NGAY_BAT_DAU";
        public const string NGAY_KET_THUC = "NGAY_KET_THUC";
        public const string NGAY_KY_HOP_DONG = "NGAY_KY_HOP_DONG";
        public const string NGAY_LAP = "NGAY_LAP";
        public const string NGAY_SUA = "NGAY_SUA";
        public const string NGUOI_LAP = "NGUOI_LAP";
        public const string NGUOI_SUA = "NGUOI_SUA";
        public const string DA_XOA = "DA_XOA";
    }

    public class V_F320_THONG_TIN_CHI_TIET_DANH_SACH_HOP_DONG_DA_KY_THEO_THOI_GIAN
    {
        public const string ID_NHAN_VIEN = "ID_NHAN_VIEN";
        public const string MA_NV = "MA_NV";
        public const string HO_DEM = "HO_DEM";
        public const string TEN = "TEN";
        public const string HO_TEN = "HO_TEN";
        public const string ID_HOP_DONG = "ID_HOP_DONG";
        public const string ID_TRANG_THAI_LAO_DONG = "ID_TRANG_THAI_LAO_DONG";
        public const string ID_LOAI_HOP_DONG = "ID_LOAI_HOP_DONG";
        public const string MA_HOP_DONG = "MA_HOP_DONG";
        public const string NGAY_BAT_DAU_HOP_DONG = "NGAY_BAT_DAU_HOP_DONG";
        public const string NGAY_KET_THUC_HOP_DONG = "NGAY_KET_THUC_HOP_DONG";
        public const string NGAY_KY_HOP_DONG = "NGAY_KY_HOP_DONG";
        public const string DA_XOA_HOP_DONG_YN = "DA_XOA_HOP_DONG_YN";
        public const string ID_GD_HS_LNS = "ID_GD_HS_LNS";
        public const string HE_SO_LNS = "HE_SO_LNS";
        public const string NGAY_BAT_DAU_HS_LNS = "NGAY_BAT_DAU_HS_LNS";
        public const string NGAY_KET_THUC_HS_LNS = "NGAY_KET_THUC_HS_LNS";
        public const string DA_XOA_HS_LNS_YN = "DA_XOA_HS_LNS_YN";
        public const string ID_LY_DO_CHINH_SUA_HS_LNS = "ID_LY_DO_CHINH_SUA_HS_LNS";
        public const string LY_DO_CHINH_SUA_HS_LNS = "LY_DO_CHINH_SUA_HS_LNS";
        public const string GHI_CHU_HS_LNS = "GHI_CHU_HS_LNS";
        public const string ID_GD_LCD = "ID_GD_LCD";
        public const string LUONG_CHE_DO = "LUONG_CHE_DO";
        public const string NGAY_BAT_DAU_LCD = "NGAY_BAT_DAU_LCD";
        public const string NGAY_KET_THUC_LCD = "NGAY_KET_THUC_LCD";
        public const string DA_XOA_LCD = "DA_XOA_LCD";
        public const string ID_LY_DO_CHINH_SUA_LCD = "ID_LY_DO_CHINH_SUA_LCD";
        public const string LY_DO_CHINH_SUA_LCD = "LY_DO_CHINH_SUA_LCD";
        public const string GHI_CHU_LCD = "GHI_CHU_LCD";
    }

    public class GD_LUONG_CUNG
    {
        public const string ID = "ID";
        public const string ID_NHAN_VIEN = "ID_NHAN_VIEN";
        public const string NGAY_BAT_DAU = "NGAY_BAT_DAU";
        public const string NGAY_KET_THUC = "NGAY_KET_THUC";
        public const string SO_TIEN = "SO_TIEN";
        public const string NGAY_LAP = "NGAY_LAP";
        public const string NGAY_SUA = "NGAY_SUA";
        public const string NGUOI_LAP = "NGUOI_LAP";
        public const string NGUOI_SUA = "NGUOI_SUA";
        public const string GHI_CHU = "GHI_CHU";
        public const string DA_XOA = "DA_XOA";
    }
    public class V_GD_LUONG_CUNG
    {
        public const string ID_NHAN_VIEN = "ID_NHAN_VIEN";
        public const string MA_NV = "MA_NV";
        public const string HO_DEM = "HO_DEM";
        public const string TEN = "TEN";
        public const string HO_TEN = "HO_TEN";
        public const string ID = "ID";
        public const string NGAY_BAT_DAU = "NGAY_BAT_DAU";
        public const string NGAY_KET_THUC = "NGAY_KET_THUC";
        public const string SO_TIEN = "SO_TIEN";
        public const string NGAY_LAP = "NGAY_LAP";
        public const string NGAY_SUA = "NGAY_SUA";
        public const string NGUOI_LAP = "NGUOI_LAP";
        public const string NGUOI_SUA = "NGUOI_SUA";
        public const string GHI_CHU = "GHI_CHU";
        public const string DA_XOA = "DA_XOA";
    }
    public class V_DM_DON_VI
    {
        public const string ID_DV_0 = "ID_DV_0";
        public const string ID_DV_1 = "ID_DV_1";
        public const string ID_DV_2 = "ID_DV_2";
        public const string ID_DV_3 = "ID_DV_3";
        public const string ID_DV_4 = "ID_DV_4";
        public const string TEN_DON_VI = "TEN_DON_VI";
        public const string Expr1 = "Expr1";
        public const string Expr2 = "Expr2";
        public const string Expr3 = "Expr3";
        public const string Expr4 = "Expr4";
    }

    public class V_DM_HE_SO_LUONG_NS
    {
        public const string ID = "ID";
        public const string ID_MA_LNS = "ID_MA_LNS";
        public const string TEN_NGAN_LNS = "TEN_NGAN_LNS";
        public const string TEN_LNS = "TEN_LNS";
        public const string ID_MUC_LNS = "ID_MUC_LNS";
        public const string MUC_LNS_NGAN = "MUC_LNS_NGAN";
        public const string MUC_LNS = "MUC_LNS";
        public const string HE_SO = "HE_SO";
        public const string ID_LOAI_LAO_DONG = "ID_LOAI_LAO_DONG";
        public const string LOAI_LAO_DONG = "LOAI_LAO_DONG";
        public const string TEN = "TEN";
    }
    public class V_DM_LOAI_HOP_DONG
    {
        public const string ID = "ID";
        public const string LOAI_HOP_DONG = "LOAI_HOP_DONG";
        public const string MA_LOAI_HOP_DONG = "MA_LOAI_HOP_DONG";
        public const string TI_LE = "TI_LE";
        public const string SO_TIEN = "SO_TIEN";
        public const string HS_LNS_YN = "HS_LNS_YN";
        public const string AN_CA_YN = "AN_CA_YN";
        public const string LCD_YN = "LCD_YN";
    }
    public class V_DM_LOAI_NGAY_CONG
    {
        public const string ID = "ID";
        public const string MA_NGAY_CONG = "MA_NGAY_CONG";
        public const string TEN_NGAY_CONG = "TEN_NGAY_CONG";
        public const string TI_LE_LNS = "TI_LE_LNS";
        public const string TI_LE_LCD = "TI_LE_LCD";
    }

    public class V_DM_LUONG_CHE_DO
    {
        public const string ID = "ID";
        public const string ID_MA_LCD = "ID_MA_LCD";
        public const string ID_MUC_LCD = "ID_MUC_LCD";
        public const string MA_LCD = "MA_LCD";
        public const string MUC_LCD = "MUC_LCD";
        public const string SO_TIEN = "SO_TIEN";
    }

    public class V_DM_PHU_CAP
    {
        public const string DOI_TUONG_HUONG_PHU_CAP = "DOI_TUONG_HUONG_PHU_CAP";
        public const string TEN = "TEN";
        public const string TI_LE = "TI_LE";
        public const string ID = "ID";
        public const string ID_LOAI_PHU_CAP = "ID_LOAI_PHU_CAP";
    }

    public class V_DM_LAO_DONG_NUOC_NGOAI
    {
        public const string ID = "ID";
        public const string MA_NV = "MA_NV";
        public const string HO_TEN = "HO_TEN";
        public const string GIOI_TINH = "GIOI_TINH";
        public const string QUOC_TICH = "QUOC_TICH";
        public const string MA_HOP_DONG = "MA_HOP_DONG";
        public const string LOAI_HOP_DONG = "LOAI_HOP_DONG";
        public const string TEN_DON_VI = "TEN_DON_VI";
        public const string CHUC_VU = "CHUC_VU";
        public const string NGAY_KY_HOP_DONG = "NGAY_KY_HOP_DONG";
    }

    public class V_GD_KHONG_DONG_BAO_HIEM
    {
        public const string ID = "ID";
        public const string ID_NHAN_VIEN = "ID_NHAN_VIEN";
        public const string MA_NV = "MA_NV";
        public const string HO_DEM = "HO_DEM";
        public const string TEN = "TEN";
        public const string HO_TEN = "HO_TEN";
        public const string THANG = "THANG";
        public const string NAM = "NAM";
        public const string NGAY_LAP = "NGAY_LAP";
        public const string NGUOI_LAP = "NGUOI_LAP";
        public const string LY_DO = "LY_DO";
    }

    public class RPT_SO_LUONG_CHAT_LUONG_NHAN_VIEN
    {
        public const string ID = "ID";
        public const string ID_DON_VI_CAP_TREN = "ID_DON_VI_CAP_TREN";
        public const string TEN_DON_VI = "TEN_DON_VI";
        public const string TONG_SO = "TONG_SO";
        public const string HD_KXD = "HD_KXD";
        public const string HD_36_THANG = "HD_36_THANG";
        public const string HD_12_THANG = "HD_12_THANG";
        public const string HD_THU_VIEC = "HD_THU_VIEC";
        public const string HD_HOC_NGHE = "HD_HOC_NGHE";
        public const string TREN_DAI_HOC = "TREN_DAI_HOC";
        public const string DAI_HOC = "DAI_HOC";
        public const string CAO_DANG = "CAO_DANG";
        public const string TRUNG_CAP = "TRUNG_CAP";
        public const string SC_NGHE_PTTH = "SC_NGHE_PTTH";
        public const string NAM = "NAM";
        public const string NU = "NU";
        public const string DUOI_26 = "DUOI_26";
        public const string TU_26_DEN_30 = "TU_26_DEN_30";
        public const string TU_31_DEN_35 = "TU_31_DEN_35";
        public const string TU_36_DEN_40 = "TU_36_DEN_40";
        public const string TU_41_DEN_45 = "TU_41_DEN_45";
        public const string TU_46_DEN_50 = "TU_46_DEN_50";
        public const string TU_51_DEN_55 = "TU_51_DEN_55";
        public const string TREN_55 = "TREN_55";
    }
    public class V_F468_BAO_CAO_TRANG_THAI_LAO_DONG_THEO_THANG
    {
        public const string ID = "ID";
        public const string ID_NHAN_VIEN = "ID_NHAN_VIEN";
        public const string MA_NV = "MA_NV";
        public const string HO_TEN = "HO_TEN";
        public const string ID_LOAI_TRANG_THAI_LD = "ID_LOAI_TRANG_THAI_LD";
        public const string TEN_LOAI_TRANG_THAI_LD = "TEN_LOAI_TRANG_THAI_LD";
        public const string ID_TRANG_THAI_LAO_DONG = "ID_TRANG_THAI_LAO_DONG";
        public const string TEN_TRANG_THAI_LD = "TEN_TRANG_THAI_LD";
        public const string NGAY_AP_DUNG = "NGAY_AP_DUNG";
        public const string NGAY_LAP = "NGAY_LAP";
        public const string GHI_CHU_TRANG_THAI_LAO_DONG = "GHI_CHU_TRANG_THAI_LAO_DONG";
        public const string ID_GD_CT = "ID_GD_CT";
        public const string ID_DON_VI = "ID_DON_VI";
        public const string TEN_DON_VI = "TEN_DON_VI";
        public const string ID_VI_TRI = "ID_VI_TRI";
        public const string TEN_VI_TRI = "TEN_VI_TRI";
        public const string TEN_LOAI_CONG_TAC = "TEN_LOAI_CONG_TAC";
    }

    public class V_GD_HOP_DONG_V3
    {
        public const string MA_NV = "MA_NV";
        public const string HO_TEN = "HO_TEN";
        public const string LOAI_HOP_DONG = "LOAI_HOP_DONG";
        public const string ID = "ID";
        public const string ID_NHAN_VIEN = "ID_NHAN_VIEN";
        public const string ID_LOAI_HOP_DONG = "ID_LOAI_HOP_DONG";
        public const string MA_HOP_DONG = "MA_HOP_DONG";
        public const string NGAY_BAT_DAU = "NGAY_BAT_DAU";
        public const string NGAY_KET_THUC = "NGAY_KET_THUC";
        public const string NGAY_KY_HOP_DONG = "NGAY_KY_HOP_DONG";
        public const string NGAY_LAP = "NGAY_LAP";
        public const string NGAY_SUA = "NGAY_SUA";
        public const string NGUOI_LAP = "NGUOI_LAP";
        public const string NGUOI_SUA = "NGUOI_SUA";
        public const string GHI_CHU = "GHI_CHU";
        public const string ID_LUONG_CHE_DO = "ID_LUONG_CHE_DO";
        public const string ID_LOAI_LAO_DONG = "ID_LOAI_LAO_DONG";
        public const string ID_DON_VI = "ID_DON_VI";
        public const string ID_CHUC_VU = "ID_CHUC_VU";
        public const string SO_TIEN_LCD = "SO_TIEN_LCD";
        public const string MA_LCD = "MA_LCD";
        public const string TEN_MA_LCD = "TEN_MA_LCD";
        public const string MUC_LCD = "MUC_LCD";
        public const string TEN_MUC_LCD = "TEN_MUC_LCD";
        public const string ID_MA_LCD = "ID_MA_LCD";
        public const string ID_MUC_LCD = "ID_MUC_LCD";
        public const string ID_DON_VI_HIEN_TAI = "ID_DON_VI_HIEN_TAI";
        public const string TEN_DON_VI = "TEN_DON_VI";
        public const string LOAI_LAO_DONG = "LOAI_LAO_DONG";
        public const string CHUC_VU = "CHUC_VU";
        public const string MA_LOAI_HOP_DONG = "MA_LOAI_HOP_DONG";
    }



}
