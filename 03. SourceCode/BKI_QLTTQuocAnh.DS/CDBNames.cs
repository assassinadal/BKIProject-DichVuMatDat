﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BKI_DichVuMatDat.DS.CDBNames
{
    #region HE_THONG
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

    #endregion

    #region GIAO_DICH
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
        public const string DA_XOA = "DA_XOA";
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

    #endregion

    #region view
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




    #endregion

}
