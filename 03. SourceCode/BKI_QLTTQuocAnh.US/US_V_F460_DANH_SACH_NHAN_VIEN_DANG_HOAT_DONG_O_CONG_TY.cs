///************************************************
/// Generated by: haihd
/// Date: 30-03-2016 05:18:51
/// Goal: Create User Service Class for V_F460_DANH_SACH_NHAN_VIEN_DANG_HOAT_DONG_O_CONG_TY
///************************************************
/// <summary>
/// Create User Service Class for V_F460_DANH_SACH_NHAN_VIEN_DANG_HOAT_DONG_O_CONG_TY
/// </summary>

using System;
using BKI_DichVuMatDat.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BKI_DichVuMatDat.US
{

    public class US_V_F460_DANH_SACH_NHAN_VIEN_DANG_HOAT_DONG_O_CONG_TY : US_Object
    {
        private const string c_TableName = "V_F460_DANH_SACH_NHAN_VIEN_DANG_HOAT_DONG_O_CONG_TY";
        #region "Public Properties"
        public decimal dcID
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID"] = value;
            }
        }

        public bool IsIDNull()
        {
            return pm_objDR.IsNull("ID");
        }

        public void SetIDNull()
        {
            pm_objDR["ID"] = System.Convert.DBNull;
        }

        public decimal dcID_NHAN_VIEN
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_NHAN_VIEN", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_NHAN_VIEN"] = value;
            }
        }

        public bool IsID_NHAN_VIENNull()
        {
            return pm_objDR.IsNull("ID_NHAN_VIEN");
        }

        public void SetID_NHAN_VIENNull()
        {
            pm_objDR["ID_NHAN_VIEN"] = System.Convert.DBNull;
        }

        public string strMA_TRA_CUU
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "MA_TRA_CUU", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["MA_TRA_CUU"] = value;
            }
        }

        public bool IsMA_TRA_CUUNull()
        {
            return pm_objDR.IsNull("MA_TRA_CUU");
        }

        public void SetMA_TRA_CUUNull()
        {
            pm_objDR["MA_TRA_CUU"] = System.Convert.DBNull;
        }

        public string strMA_NV
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "MA_NV", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["MA_NV"] = value;
            }
        }

        public bool IsMA_NVNull()
        {
            return pm_objDR.IsNull("MA_NV");
        }

        public void SetMA_NVNull()
        {
            pm_objDR["MA_NV"] = System.Convert.DBNull;
        }

        public string strHO_TEN
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "HO_TEN", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["HO_TEN"] = value;
            }
        }

        public bool IsHO_TENNull()
        {
            return pm_objDR.IsNull("HO_TEN");
        }

        public void SetHO_TENNull()
        {
            pm_objDR["HO_TEN"] = System.Convert.DBNull;
        }

        public decimal dcID_VI_TRI
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_VI_TRI", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_VI_TRI"] = value;
            }
        }

        public bool IsID_VI_TRINull()
        {
            return pm_objDR.IsNull("ID_VI_TRI");
        }

        public void SetID_VI_TRINull()
        {
            pm_objDR["ID_VI_TRI"] = System.Convert.DBNull;
        }

        public string strTEN_VI_TRI
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "TEN_VI_TRI", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["TEN_VI_TRI"] = value;
            }
        }

        public bool IsTEN_VI_TRINull()
        {
            return pm_objDR.IsNull("TEN_VI_TRI");
        }

        public void SetTEN_VI_TRINull()
        {
            pm_objDR["TEN_VI_TRI"] = System.Convert.DBNull;
        }

        public decimal dcID_DON_VI
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_DON_VI", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_DON_VI"] = value;
            }
        }

        public bool IsID_DON_VINull()
        {
            return pm_objDR.IsNull("ID_DON_VI");
        }

        public void SetID_DON_VINull()
        {
            pm_objDR["ID_DON_VI"] = System.Convert.DBNull;
        }

        public string strTEN_DON_VI
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "TEN_DON_VI", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["TEN_DON_VI"] = value;
            }
        }

        public bool IsTEN_DON_VINull()
        {
            return pm_objDR.IsNull("TEN_DON_VI");
        }

        public void SetTEN_DON_VINull()
        {
            pm_objDR["TEN_DON_VI"] = System.Convert.DBNull;
        }

        public string strTRINH_DO_VAN_HOA
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "TRINH_DO_VAN_HOA", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["TRINH_DO_VAN_HOA"] = value;
            }
        }

        public bool IsTRINH_DO_VAN_HOANull()
        {
            return pm_objDR.IsNull("TRINH_DO_VAN_HOA");
        }

        public void SetTRINH_DO_VAN_HOANull()
        {
            pm_objDR["TRINH_DO_VAN_HOA"] = System.Convert.DBNull;
        }

        public string strCHUYEN_MON
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "CHUYEN_MON", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["CHUYEN_MON"] = value;
            }
        }

        public bool IsCHUYEN_MONNull()
        {
            return pm_objDR.IsNull("CHUYEN_MON");
        }

        public void SetCHUYEN_MONNull()
        {
            pm_objDR["CHUYEN_MON"] = System.Convert.DBNull;
        }

        public string strDIA_CHI_THUONG_TRU
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "DIA_CHI_THUONG_TRU", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["DIA_CHI_THUONG_TRU"] = value;
            }
        }

        public bool IsDIA_CHI_THUONG_TRUNull()
        {
            return pm_objDR.IsNull("DIA_CHI_THUONG_TRU");
        }

        public void SetDIA_CHI_THUONG_TRUNull()
        {
            pm_objDR["DIA_CHI_THUONG_TRU"] = System.Convert.DBNull;
        }

        public string strSO_CMT
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "SO_CMT", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["SO_CMT"] = value;
            }
        }

        public bool IsSO_CMTNull()
        {
            return pm_objDR.IsNull("SO_CMT");
        }

        public void SetSO_CMTNull()
        {
            pm_objDR["SO_CMT"] = System.Convert.DBNull;
        }

        public DateTime datNGAY_CAP
        {
            get
            {
                return CNull.RowNVLDate(pm_objDR, "NGAY_CAP", IPConstants.c_DefaultDate);
            }
            set
            {
                pm_objDR["NGAY_CAP"] = value;
            }
        }

        public bool IsNGAY_CAPNull()
        {
            return pm_objDR.IsNull("NGAY_CAP");
        }

        public void SetNGAY_CAPNull()
        {
            pm_objDR["NGAY_CAP"] = System.Convert.DBNull;
        }

        public string strNOI_CAP
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "NOI_CAP", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["NOI_CAP"] = value;
            }
        }

        public bool IsNOI_CAPNull()
        {
            return pm_objDR.IsNull("NOI_CAP");
        }

        public void SetNOI_CAPNull()
        {
            pm_objDR["NOI_CAP"] = System.Convert.DBNull;
        }

        public decimal dcTUOI
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "TUOI", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["TUOI"] = value;
            }
        }

        public bool IsTUOINull()
        {
            return pm_objDR.IsNull("TUOI");
        }

        public void SetTUOINull()
        {
            pm_objDR["TUOI"] = System.Convert.DBNull;
        }

        public decimal dcLOAI_HOP_DONG
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "LOAI_HOP_DONG", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["LOAI_HOP_DONG"] = value;
            }
        }

        public bool IsLOAI_HOP_DONGNull()
        {
            return pm_objDR.IsNull("LOAI_HOP_DONG");
        }

        public void SetLOAI_HOP_DONGNull()
        {
            pm_objDR["LOAI_HOP_DONG"] = System.Convert.DBNull;
        }

        public string strMA_LOAI_HOP_DONG
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "MA_LOAI_HOP_DONG", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["MA_LOAI_HOP_DONG"] = value;
            }
        }

        public bool IsMA_LOAI_HOP_DONGNull()
        {
            return pm_objDR.IsNull("MA_LOAI_HOP_DONG");
        }

        public void SetMA_LOAI_HOP_DONGNull()
        {
            pm_objDR["MA_LOAI_HOP_DONG"] = System.Convert.DBNull;
        }

        public DateTime datNGAY_BAT_DAU_HOP_DONG
        {
            get
            {
                return CNull.RowNVLDate(pm_objDR, "NGAY_BAT_DAU_HOP_DONG", IPConstants.c_DefaultDate);
            }
            set
            {
                pm_objDR["NGAY_BAT_DAU_HOP_DONG"] = value;
            }
        }

        public bool IsNGAY_BAT_DAU_HOP_DONGNull()
        {
            return pm_objDR.IsNull("NGAY_BAT_DAU_HOP_DONG");
        }

        public void SetNGAY_BAT_DAU_HOP_DONGNull()
        {
            pm_objDR["NGAY_BAT_DAU_HOP_DONG"] = System.Convert.DBNull;
        }

        public decimal dcID_LCD
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_LCD", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_LCD"] = value;
            }
        }

        public bool IsID_LCDNull()
        {
            return pm_objDR.IsNull("ID_LCD");
        }

        public void SetID_LCDNull()
        {
            pm_objDR["ID_LCD"] = System.Convert.DBNull;
        }

        public string strMA_LCD
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "MA_LCD", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["MA_LCD"] = value;
            }
        }

        public bool IsMA_LCDNull()
        {
            return pm_objDR.IsNull("MA_LCD");
        }

        public void SetMA_LCDNull()
        {
            pm_objDR["MA_LCD"] = System.Convert.DBNull;
        }

        public string strMUC_LCD
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "MUC_LCD", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["MUC_LCD"] = value;
            }
        }

        public bool IsMUC_LCDNull()
        {
            return pm_objDR.IsNull("MUC_LCD");
        }

        public void SetMUC_LCDNull()
        {
            pm_objDR["MUC_LCD"] = System.Convert.DBNull;
        }

        public decimal dcSO_TIEN
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "SO_TIEN", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["SO_TIEN"] = value;
            }
        }

        public bool IsSO_TIENNull()
        {
            return pm_objDR.IsNull("SO_TIEN");
        }

        public void SetSO_TIENNull()
        {
            pm_objDR["SO_TIEN"] = System.Convert.DBNull;
        }

        public DateTime datNGAY_BAT_DAU_LCD
        {
            get
            {
                return CNull.RowNVLDate(pm_objDR, "NGAY_BAT_DAU_LCD", IPConstants.c_DefaultDate);
            }
            set
            {
                pm_objDR["NGAY_BAT_DAU_LCD"] = value;
            }
        }

        public bool IsNGAY_BAT_DAU_LCDNull()
        {
            return pm_objDR.IsNull("NGAY_BAT_DAU_LCD");
        }

        public void SetNGAY_BAT_DAU_LCDNull()
        {
            pm_objDR["NGAY_BAT_DAU_LCD"] = System.Convert.DBNull;
        }

        public decimal dcID_HS_LNS
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_HS_LNS", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_HS_LNS"] = value;
            }
        }

        public bool IsID_HS_LNSNull()
        {
            return pm_objDR.IsNull("ID_HS_LNS");
        }

        public void SetID_HS_LNSNull()
        {
            pm_objDR["ID_HS_LNS"] = System.Convert.DBNull;
        }

        public string strTEN_LNS
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "TEN_LNS", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["TEN_LNS"] = value;
            }
        }

        public bool IsTEN_LNSNull()
        {
            return pm_objDR.IsNull("TEN_LNS");
        }

        public void SetTEN_LNSNull()
        {
            pm_objDR["TEN_LNS"] = System.Convert.DBNull;
        }

        public string strMUC_LNS
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "MUC_LNS", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["MUC_LNS"] = value;
            }
        }

        public bool IsMUC_LNSNull()
        {
            return pm_objDR.IsNull("MUC_LNS");
        }

        public void SetMUC_LNSNull()
        {
            pm_objDR["MUC_LNS"] = System.Convert.DBNull;
        }

        public decimal dcHE_SO
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "HE_SO", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["HE_SO"] = value;
            }
        }

        public bool IsHE_SONull()
        {
            return pm_objDR.IsNull("HE_SO");
        }

        public void SetHE_SONull()
        {
            pm_objDR["HE_SO"] = System.Convert.DBNull;
        }

        public DateTime datNGAY_BAT_DAU_LNS
        {
            get
            {
                return CNull.RowNVLDate(pm_objDR, "NGAY_BAT_DAU_LNS", IPConstants.c_DefaultDate);
            }
            set
            {
                pm_objDR["NGAY_BAT_DAU_LNS"] = value;
            }
        }

        public bool IsNGAY_BAT_DAU_LNSNull()
        {
            return pm_objDR.IsNull("NGAY_BAT_DAU_LNS");
        }

        public void SetNGAY_BAT_DAU_LNSNull()
        {
            pm_objDR["NGAY_BAT_DAU_LNS"] = System.Convert.DBNull;
        }

        #endregion
        #region "Init Functions"
        public US_V_F460_DANH_SACH_NHAN_VIEN_DANG_HOAT_DONG_O_CONG_TY()
        {
            pm_objDS = new DS_V_F460_DANH_SACH_NHAN_VIEN_DANG_HOAT_DONG_O_CONG_TY();
            pm_strTableName = c_TableName;
            pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
        }

        public US_V_F460_DANH_SACH_NHAN_VIEN_DANG_HOAT_DONG_O_CONG_TY(DataRow i_objDR)
            : this()
        {
            this.DataRow2Me(i_objDR);
        }

        public US_V_F460_DANH_SACH_NHAN_VIEN_DANG_HOAT_DONG_O_CONG_TY(decimal i_dbID)
        {
            pm_objDS = new DS_V_F460_DANH_SACH_NHAN_VIEN_DANG_HOAT_DONG_O_CONG_TY();
            pm_strTableName = c_TableName;
            IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
            v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
            SqlCommand v_cmdSQL;
            v_cmdSQL = v_objMkCmd.getSelectCmd();
            this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
            pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
        }
        #endregion
        public void load_du_lieu_nhan_vien_hoat_dong(DataSet op_ds, DateTime ip_dat)
        {
            CStoredProc v_cstore = new CStoredProc("PR_XUAT_DANH_SACH_NHAN_VIEN_HOAT_DONG");

            v_cstore.addDatetimeInputParam("@IP_DAT", ip_dat);

            v_cstore.fillDataSetByCommand(this, op_ds);
        }
    }
}
