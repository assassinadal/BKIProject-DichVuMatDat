///************************************************
/// Generated by: sonpt
/// Date: 10/03/2016 03:21:33
/// Goal: Create User Service Class for V_DM_LAO_DONG_NUOC_NGOAI
///************************************************
/// <summary>
/// Create User Service Class for V_DM_LAO_DONG_NUOC_NGOAI
/// </summary>

using System;
using BKI_DichVuMatDat.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BKI_DichVuMatDat.US{

public class US_V_DM_LAO_DONG_NUOC_NGOAI : US_Object
{
	private const string c_TableName = "V_DM_LAO_DONG_NUOC_NGOAI";
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

	public bool IsIDNull()	{
		return pm_objDR.IsNull("ID");
	}

	public void SetIDNull() {
		pm_objDR["ID"] = System.Convert.DBNull;
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

	public void SetMA_NVNull() {
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

	public void SetHO_TENNull() {
		pm_objDR["HO_TEN"] = System.Convert.DBNull;
	}

	public string strGIOI_TINH 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "GIOI_TINH", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["GIOI_TINH"] = value;
		}
	}

	public bool IsGIOI_TINHNull() 
	{
		return pm_objDR.IsNull("GIOI_TINH");
	}

	public void SetGIOI_TINHNull() {
		pm_objDR["GIOI_TINH"] = System.Convert.DBNull;
	}

	public string strQUOC_TICH 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "QUOC_TICH", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["QUOC_TICH"] = value;
		}
	}

	public bool IsQUOC_TICHNull() 
	{
		return pm_objDR.IsNull("QUOC_TICH");
	}

	public void SetQUOC_TICHNull() {
		pm_objDR["QUOC_TICH"] = System.Convert.DBNull;
	}

	public string strMA_HOP_DONG 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "MA_HOP_DONG", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["MA_HOP_DONG"] = value;
		}
	}

	public bool IsMA_HOP_DONGNull() 
	{
		return pm_objDR.IsNull("MA_HOP_DONG");
	}

	public void SetMA_HOP_DONGNull() {
		pm_objDR["MA_HOP_DONG"] = System.Convert.DBNull;
	}

	public string strLOAI_HOP_DONG 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "LOAI_HOP_DONG", IPConstants.c_DefaultString);
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

	public void SetLOAI_HOP_DONGNull() {
		pm_objDR["LOAI_HOP_DONG"] = System.Convert.DBNull;
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

	public void SetTEN_DON_VINull() {
		pm_objDR["TEN_DON_VI"] = System.Convert.DBNull;
	}

	public string strCHUC_VU 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "CHUC_VU", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["CHUC_VU"] = value;
		}
	}

	public bool IsCHUC_VUNull() 
	{
		return pm_objDR.IsNull("CHUC_VU");
	}

	public void SetCHUC_VUNull() {
		pm_objDR["CHUC_VU"] = System.Convert.DBNull;
	}

	public DateTime datNGAY_KY_HOP_DONG
	{
		get   
		{
			return CNull.RowNVLDate(pm_objDR, "NGAY_KY_HOP_DONG", IPConstants.c_DefaultDate);
		}
		set   
		{
			pm_objDR["NGAY_KY_HOP_DONG"] = value;
		}
	}

	public bool IsNGAY_KY_HOP_DONGNull()
	{
		return pm_objDR.IsNull("NGAY_KY_HOP_DONG");
	}

	public void SetNGAY_KY_HOP_DONGNull()
	{
		pm_objDR["NGAY_KY_HOP_DONG"] = System.Convert.DBNull;
	}

#endregion
#region "Init Functions"
	public US_V_DM_LAO_DONG_NUOC_NGOAI() 
	{
		pm_objDS = new DS_V_DM_LAO_DONG_NUOC_NGOAI();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_V_DM_LAO_DONG_NUOC_NGOAI(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_V_DM_LAO_DONG_NUOC_NGOAI(decimal i_dbID) 
	{
		pm_objDS = new DS_V_DM_LAO_DONG_NUOC_NGOAI();
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
