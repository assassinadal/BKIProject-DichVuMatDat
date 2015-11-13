///************************************************
/// Generated by: haihd
/// Date: 11-11-2015 08:39:11
/// Goal: Create User Service Class for V_GD_QUY_TIEN_THUONG
///************************************************
/// <summary>
/// Create User Service Class for V_GD_QUY_TIEN_THUONG
/// </summary>

using System;
using BKI_DichVuMatDat.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BKI_DichVuMatDat.US{

public class US_V_GD_QUY_TIEN_THUONG : US_Object
{
	private const string c_TableName = "V_GD_QUY_TIEN_THUONG";
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

    public string strTHANG
    {
        get
        {
            return CNull.RowNVLString(pm_objDR, "THANG", IPConstants.c_DefaultString);
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

    public string strNAM
    {
        get
        {
            return CNull.RowNVLString(pm_objDR, "NAM", IPConstants.c_DefaultString);
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

    public decimal dcID_LOAI_QUY_TIEN
    {
        get
        {
            return CNull.RowNVLDecimal(pm_objDR, "ID_LOAI_QUY_TIEN", IPConstants.c_DefaultDecimal);
        }
        set
        {
            pm_objDR["ID_LOAI_QUY_TIEN"] = value;
        }
    }

    public bool IsID_LOAI_QUY_TIENNull()
    {
        return pm_objDR.IsNull("ID_LOAI_QUY_TIEN");
    }

    public void SetID_LOAI_QUY_TIENNull()
    {
        pm_objDR["ID_LOAI_QUY_TIEN"] = System.Convert.DBNull;
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

    public string strTEN_QUY
    {
        get
        {
            return CNull.RowNVLString(pm_objDR, "TEN_QUY", IPConstants.c_DefaultString);
        }
        set
        {
            pm_objDR["TEN_QUY"] = value;
        }
    }

    public bool IsTEN_QUYNull()
    {
        return pm_objDR.IsNull("TEN_QUY");
    }

    public void SetTEN_QUYNull()
    {
        pm_objDR["TEN_QUY"] = System.Convert.DBNull;
    }

    public string strTINH_XONG_YN
    {
        get
        {
            return CNull.RowNVLString(pm_objDR, "TINH_XONG_YN", IPConstants.c_DefaultString);
        }
        set
        {
            pm_objDR["TINH_XONG_YN"] = value;
        }
    }

    public bool IsTINH_XONG_YNNull()
    {
        return pm_objDR.IsNull("TINH_XONG_YN");
    }

    public void SetTINH_XONG_YNNull()
    {
        pm_objDR["TINH_XONG_YN"] = System.Convert.DBNull;
    }

    public string strTEN_LOAI_QUY_TIEN
    {
        get
        {
            return CNull.RowNVLString(pm_objDR, "TEN_LOAI_QUY_TIEN", IPConstants.c_DefaultString);
        }
        set
        {
            pm_objDR["TEN_LOAI_QUY_TIEN"] = value;
        }
    }

    public bool IsTEN_LOAI_QUY_TIENNull()
    {
        return pm_objDR.IsNull("TEN_LOAI_QUY_TIEN");
    }

    public void SetTEN_LOAI_QUY_TIENNull()
    {
        pm_objDR["TEN_LOAI_QUY_TIEN"] = System.Convert.DBNull;
    }

    public string strTINH_XONG_TEXT
    {
        get
        {
            return CNull.RowNVLString(pm_objDR, "TINH_XONG_TEXT", IPConstants.c_DefaultString);
        }
        set
        {
            pm_objDR["TINH_XONG_TEXT"] = value;
        }
    }

    public bool IsTINH_XONG_TEXTNull()
    {
        return pm_objDR.IsNull("TINH_XONG_TEXT");
    }

    public void SetTINH_XONG_TEXTNull()
    {
        pm_objDR["TINH_XONG_TEXT"] = System.Convert.DBNull;
    }

    public string strLY_DO_THUONG
    {
        get
        {
            return CNull.RowNVLString(pm_objDR, "LY_DO_THUONG", IPConstants.c_DefaultString);
        }
        set
        {
            pm_objDR["LY_DO_THUONG"] = value;
        }
    }

    public bool IsLY_DO_THUONGNull()
    {
        return pm_objDR.IsNull("LY_DO_THUONG");
    }

    public void SetLY_DO_THUONGNull()
    {
        pm_objDR["LY_DO_THUONG"] = System.Convert.DBNull;
    }

    public DateTime datTU_NGAY_XET_THUONG
    {
        get
        {
            return CNull.RowNVLDate(pm_objDR, "TU_NGAY_XET_THUONG", IPConstants.c_DefaultDate);
        }
        set
        {
            pm_objDR["TU_NGAY_XET_THUONG"] = value;
        }
    }

    public bool IsTU_NGAY_XET_THUONGNull()
    {
        return pm_objDR.IsNull("TU_NGAY_XET_THUONG");
    }

    public void SetTU_NGAY_XET_THUONGNull()
    {
        pm_objDR["TU_NGAY_XET_THUONG"] = System.Convert.DBNull;
    }

    public DateTime datDEN_NGAY_XET_THUONG
    {
        get
        {
            return CNull.RowNVLDate(pm_objDR, "DEN_NGAY_XET_THUONG", IPConstants.c_DefaultDate);
        }
        set
        {
            pm_objDR["DEN_NGAY_XET_THUONG"] = value;
        }
    }

    public bool IsDEN_NGAY_XET_THUONGNull()
    {
        return pm_objDR.IsNull("DEN_NGAY_XET_THUONG");
    }

    public void SetDEN_NGAY_XET_THUONGNull()
    {
        pm_objDR["DEN_NGAY_XET_THUONG"] = System.Convert.DBNull;
    }

    public decimal dcSL_NV_CAN_TINH
    {
        get
        {
            return CNull.RowNVLDecimal(pm_objDR, "SL_NV_CAN_TINH", IPConstants.c_DefaultDecimal);
        }
        set
        {
            pm_objDR["SL_NV_CAN_TINH"] = value;
        }
    }

    public bool IsSL_NV_CAN_TINHNull()
    {
        return pm_objDR.IsNull("SL_NV_CAN_TINH");
    }

    public void SetSL_NV_CAN_TINHNull()
    {
        pm_objDR["SL_NV_CAN_TINH"] = System.Convert.DBNull;
    }

    public decimal dcSL_NV_DA_TINH
    {
        get
        {
            return CNull.RowNVLDecimal(pm_objDR, "SL_NV_DA_TINH", IPConstants.c_DefaultDecimal);
        }
        set
        {
            pm_objDR["SL_NV_DA_TINH"] = value;
        }
    }

    public bool IsSL_NV_DA_TINHNull()
    {
        return pm_objDR.IsNull("SL_NV_DA_TINH");
    }

    public void SetSL_NV_DA_TINHNull()
    {
        pm_objDR["SL_NV_DA_TINH"] = System.Convert.DBNull;
    }

    public decimal dcPHAN_TRAM_DA_TINH
    {
        get
        {
            return CNull.RowNVLDecimal(pm_objDR, "PHAN_TRAM_DA_TINH", IPConstants.c_DefaultDecimal);
        }
        set
        {
            pm_objDR["PHAN_TRAM_DA_TINH"] = value;
        }
    }

    public bool IsPHAN_TRAM_DA_TINHNull()
    {
        return pm_objDR.IsNull("PHAN_TRAM_DA_TINH");
    }

    public void SetPHAN_TRAM_DA_TINHNull()
    {
        pm_objDR["PHAN_TRAM_DA_TINH"] = System.Convert.DBNull;
    }

    #endregion
    #region "Init Functions"
	    public US_V_GD_QUY_TIEN_THUONG() 
	    {
		    pm_objDS = new DS_V_GD_QUY_TIEN_THUONG();
		    pm_strTableName = c_TableName;
		    pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	    }

	    public US_V_GD_QUY_TIEN_THUONG(DataRow i_objDR): this()
	    {
		    this.DataRow2Me(i_objDR);
	    }

	    public US_V_GD_QUY_TIEN_THUONG(decimal i_dbID) 
	    {
		    pm_objDS = new DS_V_GD_QUY_TIEN_THUONG();
		    pm_strTableName = c_TableName;
		    IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
		    v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
		    SqlCommand v_cmdSQL;
		    v_cmdSQL = v_objMkCmd.getSelectCmd();
		    this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
		    pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
	    }
    #endregion

        public void FillDataSetByDateFilter(out DS_V_GD_QUY_TIEN_THUONG op_ds, DateTime ip_dat_from_date, DateTime ip_dat_to_date)
        {
            op_ds = new DS_V_GD_QUY_TIEN_THUONG();
            op_ds.EnforceConstraints = false;
            CStoredProc v_sp = new CStoredProc("pr_get_data_quy_tien_thuong_by_date_filter");
            v_sp.addDatetimeInputParam("@ip_dat_from_date", ip_dat_from_date);
            v_sp.addDatetimeInputParam("@ip_dat_to_date", ip_dat_to_date);
            v_sp.fillDataSetByCommand(this, op_ds);
        }

        public void lay_thong_tin_qua_trinh_tinh_luong(out DataRow op_dr, decimal ip_dc_id_quy_tien_thuong)
        {
            DS_V_GD_QUY_TIEN_THUONG op_ds = new DS_V_GD_QUY_TIEN_THUONG();
            op_ds.EnforceConstraints = false;
            CStoredProc v_sp = new CStoredProc("pr_lay_thong_tin_qua_trinh_tinh_tien_thuong");
            v_sp.addDecimalInputParam("@ip_dc_id_quy_tien_thuong", ip_dc_id_quy_tien_thuong);
            v_sp.fillDataSetByCommand(this, op_ds);

            op_dr = op_ds.V_GD_QUY_TIEN_THUONG[0];
        }
	}
}
