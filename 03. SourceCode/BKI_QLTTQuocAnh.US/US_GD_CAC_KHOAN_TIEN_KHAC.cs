///************************************************
/// Generated by: haihd
/// Date: 24/01/2016 04:40:12
/// Goal: Create User Service Class for GD_CAC_KHOAN_TIEN_KHAC
///************************************************
/// <summary>
/// Create User Service Class for GD_CAC_KHOAN_TIEN_KHAC
/// </summary>

using System;
using BKI_DichVuMatDat.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BKI_DichVuMatDat.US
{

    public class US_GD_CAC_KHOAN_TIEN_KHAC : US_Object
    {
        private const string c_TableName = "GD_CAC_KHOAN_TIEN_KHAC";
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

        public decimal dcTHANG
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "THANG", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["THANG"] = value;
            }
        }

        public bool IsTHANGNull()
        {
            return pm_objDR.IsNull("THANG");
        }

        public void SetTHANGNull()
        {
            pm_objDR["THANG"] = System.Convert.DBNull;
        }

        public decimal dcNAM
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "NAM", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["NAM"] = value;
            }
        }

        public bool IsNAMNull()
        {
            return pm_objDR.IsNull("NAM");
        }

        public void SetNAMNull()
        {
            pm_objDR["NAM"] = System.Convert.DBNull;
        }

        public decimal dcID_LOAI_KHOAN_TIEN_KHAC
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_LOAI_KHOAN_TIEN_KHAC", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_LOAI_KHOAN_TIEN_KHAC"] = value;
            }
        }

        public bool IsID_LOAI_KHOAN_TIEN_KHACNull()
        {
            return pm_objDR.IsNull("ID_LOAI_KHOAN_TIEN_KHAC");
        }

        public void SetID_LOAI_KHOAN_TIEN_KHACNull()
        {
            pm_objDR["ID_LOAI_KHOAN_TIEN_KHAC"] = System.Convert.DBNull;
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

        public string strGHI_CHU_1
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "GHI_CHU_1", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["GHI_CHU_1"] = value;
            }
        }

        public bool IsGHI_CHU_1Null()
        {
            return pm_objDR.IsNull("GHI_CHU_1");
        }

        public void SetGHI_CHU_1Null()
        {
            pm_objDR["GHI_CHU_1"] = System.Convert.DBNull;
        }

        public string strGHI_CHU_2
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "GHI_CHU_2", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["GHI_CHU_2"] = value;
            }
        }

        public bool IsGHI_CHU_2Null()
        {
            return pm_objDR.IsNull("GHI_CHU_2");
        }

        public void SetGHI_CHU_2Null()
        {
            pm_objDR["GHI_CHU_2"] = System.Convert.DBNull;
        }

        public string strGHI_CHU_3
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "GHI_CHU_3", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["GHI_CHU_3"] = value;
            }
        }

        public bool IsGHI_CHU_3Null()
        {
            return pm_objDR.IsNull("GHI_CHU_3");
        }

        public void SetGHI_CHU_3Null()
        {
            pm_objDR["GHI_CHU_3"] = System.Convert.DBNull;
        }

        #endregion
        #region "Init Functions"
        public US_GD_CAC_KHOAN_TIEN_KHAC()
        {
            pm_objDS = new DS_GD_CAC_KHOAN_TIEN_KHAC();
            pm_strTableName = c_TableName;
            pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
        }

        public US_GD_CAC_KHOAN_TIEN_KHAC(DataRow i_objDR)
            : this()
        {
            this.DataRow2Me(i_objDR);
        }

        public US_GD_CAC_KHOAN_TIEN_KHAC(decimal i_dbID)
        {
            pm_objDS = new DS_GD_CAC_KHOAN_TIEN_KHAC();
            pm_strTableName = c_TableName;
            IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
            v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
            SqlCommand v_cmdSQL;
            v_cmdSQL = v_objMkCmd.getSelectCmd();
            this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
            pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
        }
        #endregion

        public void DeleteDuLieuCu(decimal ip_dc_thang, decimal ip_dc_nam, decimal ip_dc_id_loai_tien_khac)
        {
            CStoredProc v_cstore = new CStoredProc("PR_GD_CAC_KHOAN_TIEN_KHAC_DELETE_ALL");
            v_cstore.addDecimalInputParam("@ip_dc_thang", ip_dc_thang);
            v_cstore.addDecimalInputParam("@ip_dc_nam", ip_dc_nam);
            v_cstore.addDecimalInputParam("@ip_dc_id_loai_tien_khac", ip_dc_id_loai_tien_khac);
            v_cstore.ExecuteCommand(this);
        }
        public DataTable LayDuLieuTheoThang(decimal ip_dc_thang, decimal ip_dc_nam, decimal ip_dc_id_loai_tien_khac)
        {
            CStoredProc v_cstore = new CStoredProc("PR_TL_du_lieu_tien_khac_GetAll");
            v_cstore.addDecimalInputParam("@ip_dc_thang", ip_dc_thang);
            v_cstore.addDecimalInputParam("@ip_dc_nam", ip_dc_nam);
            v_cstore.addDecimalInputParam("@ip_dc_id_loai_tien_khac", ip_dc_id_loai_tien_khac);
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add();
            v_cstore.fillDataSetByCommand(this, v_ds);
            return v_ds.Tables[0];
        }
        public bool KiemTraCoDuLieu(decimal ip_dc_thang, decimal ip_dc_nam, decimal ip_dc_id_loai_tien_khac)
        {
            CStoredProc v_cstore = new CStoredProc("pr_TL_infor_du_lieu_khoan_tien_khac_Get");
            v_cstore.addDecimalInputParam("@ip_dc_thang", ip_dc_thang);
            v_cstore.addDecimalInputParam("@ip_dc_nam", ip_dc_nam);
            v_cstore.addDecimalInputParam("@ip_dc_id_loai_tien_khac", ip_dc_id_loai_tien_khac);

            SqlParameter v_para = v_cstore.addNVarcharOutputParam("@op_ton_tai_yn", "");
            v_cstore.ExecuteCommand(this);
            return v_para.Value.ToString() == "Y" ? true : false;
        }
    }
}
