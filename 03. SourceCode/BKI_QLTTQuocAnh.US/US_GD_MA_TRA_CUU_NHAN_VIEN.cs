///************************************************
/// Generated by: HaiHD
/// Date: 29/02/2016 04:49:48
/// Goal: Create User Service Class for GD_MA_TRA_CUU_NHAN_VIEN
///************************************************
/// <summary>
/// Create User Service Class for GD_MA_TRA_CUU_NHAN_VIEN
/// </summary>

using System;
using BKI_DichVuMatDat.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BKI_DichVuMatDat.US
{

    public class US_GD_MA_TRA_CUU_NHAN_VIEN : US_Object
    {
        private const string c_TableName = "GD_MA_TRA_CUU_NHAN_VIEN";
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

        public string strMA_PHONG
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "MA_PHONG", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["MA_PHONG"] = value;
            }
        }

        public bool IsMA_PHONGNull()
        {
            return pm_objDR.IsNull("MA_PHONG");
        }

        public void SetMA_PHONGNull()
        {
            pm_objDR["MA_PHONG"] = System.Convert.DBNull;
        }

        public string strMA_DOI
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "MA_DOI", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["MA_DOI"] = value;
            }
        }

        public bool IsMA_DOINull()
        {
            return pm_objDR.IsNull("MA_DOI");
        }

        public void SetMA_DOINull()
        {
            pm_objDR["MA_DOI"] = System.Convert.DBNull;
        }

        public string strMA_CHUC_VU
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "MA_CHUC_VU", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["MA_CHUC_VU"] = value;
            }
        }

        public bool IsMA_CHUC_VUNull()
        {
            return pm_objDR.IsNull("MA_CHUC_VU");
        }

        public void SetMA_CHUC_VUNull()
        {
            pm_objDR["MA_CHUC_VU"] = System.Convert.DBNull;
        }

        public decimal dcTHU_TU_CHUC_VU
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "THU_TU_CHUC_VU", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["THU_TU_CHUC_VU"] = value;
            }
        }

        public bool IsTHU_TU_CHUC_VUNull()
        {
            return pm_objDR.IsNull("THU_TU_CHUC_VU");
        }

        public void SetTHU_TU_CHUC_VUNull()
        {
            pm_objDR["THU_TU_CHUC_VU"] = System.Convert.DBNull;
        }

        public string strSO_HO_SO
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "SO_HO_SO", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["SO_HO_SO"] = value;
            }
        }

        public bool IsSO_HO_SONull()
        {
            return pm_objDR.IsNull("SO_HO_SO");
        }

        public void SetSO_HO_SONull()
        {
            pm_objDR["SO_HO_SO"] = System.Convert.DBNull;
        }

        public string strNGUOI_LAP
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "NGUOI_LAP", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["NGUOI_LAP"] = value;
            }
        }

        public bool IsNGUOI_LAPNull()
        {
            return pm_objDR.IsNull("NGUOI_LAP");
        }

        public void SetNGUOI_LAPNull()
        {
            pm_objDR["NGUOI_LAP"] = System.Convert.DBNull;
        }

        public DateTime datNGAY_LAP
        {
            get
            {
                return CNull.RowNVLDate(pm_objDR, "NGAY_LAP", IPConstants.c_DefaultDate);
            }
            set
            {
                pm_objDR["NGAY_LAP"] = value;
            }
        }

        public bool IsNGAY_LAPNull()
        {
            return pm_objDR.IsNull("NGAY_LAP");
        }

        public void SetNGAY_LAPNull()
        {
            pm_objDR["NGAY_LAP"] = System.Convert.DBNull;
        }

        public string strNGUOI_SUA
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "NGUOI_SUA", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["NGUOI_SUA"] = value;
            }
        }

        public bool IsNGUOI_SUANull()
        {
            return pm_objDR.IsNull("NGUOI_SUA");
        }

        public void SetNGUOI_SUANull()
        {
            pm_objDR["NGUOI_SUA"] = System.Convert.DBNull;
        }

        public string strNGAY_SUA
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "NGAY_SUA", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["NGAY_SUA"] = value;
            }
        }

        public bool IsNGAY_SUANull()
        {
            return pm_objDR.IsNull("NGAY_SUA");
        }

        public void SetNGAY_SUANull()
        {
            pm_objDR["NGAY_SUA"] = System.Convert.DBNull;
        }

        public string strDA_XOA
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "DA_XOA", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["DA_XOA"] = value;
            }
        }

        public bool IsDA_XOANull()
        {
            return pm_objDR.IsNull("DA_XOA");
        }

        public void SetDA_XOANull()
        {
            pm_objDR["DA_XOA"] = System.Convert.DBNull;
        }

        #endregion
        #region "Init Functions"
        public US_GD_MA_TRA_CUU_NHAN_VIEN()
        {
            pm_objDS = new DS_GD_MA_TRA_CUU_NHAN_VIEN();
            pm_strTableName = c_TableName;
            pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
        }

        public US_GD_MA_TRA_CUU_NHAN_VIEN(DataRow i_objDR)
            : this()
        {
            this.DataRow2Me(i_objDR);
        }

        public US_GD_MA_TRA_CUU_NHAN_VIEN(decimal i_dbID)
        {
            pm_objDS = new DS_GD_MA_TRA_CUU_NHAN_VIEN();
            pm_strTableName = c_TableName;
            IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
            v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
            SqlCommand v_cmdSQL;
            v_cmdSQL = v_objMkCmd.getSelectCmd();
            this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
            pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
        }
        #endregion
    }
}
