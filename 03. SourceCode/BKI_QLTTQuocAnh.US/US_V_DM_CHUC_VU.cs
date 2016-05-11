///************************************************
/// Generated by: huongtt
/// Date: 11/05/2016 10:29:40
/// Goal: Create User Service Class for V_DM_CHUC_VU
///************************************************
/// <summary>
/// Create User Service Class for V_DM_CHUC_VU
/// </summary>

using System;
using BKI_DichVuMatDat.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BKI_DichVuMatDat.US{

public class US_V_DM_CHUC_VU : US_Object
{
	private const string c_TableName = "V_DM_CHUC_VU";
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

	public void SetMA_CHUC_VUNull() {
		pm_objDR["MA_CHUC_VU"] = System.Convert.DBNull;
	}

	public string strTEN_CHUC_VU 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "TEN_CHUC_VU", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["TEN_CHUC_VU"] = value;
		}
	}

	public bool IsTEN_CHUC_VUNull() 
	{
		return pm_objDR.IsNull("TEN_CHUC_VU");
	}

	public void SetTEN_CHUC_VUNull() {
		pm_objDR["TEN_CHUC_VU"] = System.Convert.DBNull;
	}

	public decimal dcSO_THU_TU 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "SO_THU_TU", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["SO_THU_TU"] = value;
		}
	}

	public bool IsSO_THU_TUNull()	{
		return pm_objDR.IsNull("SO_THU_TU");
	}

	public void SetSO_THU_TUNull() {
		pm_objDR["SO_THU_TU"] = System.Convert.DBNull;
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

	public bool IsID_DON_VINull()	{
		return pm_objDR.IsNull("ID_DON_VI");
	}

	public void SetID_DON_VINull() {
		pm_objDR["ID_DON_VI"] = System.Convert.DBNull;
	}

	public decimal dcID_LOAI_CHUC_VU 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_LOAI_CHUC_VU", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_LOAI_CHUC_VU"] = value;
		}
	}

	public bool IsID_LOAI_CHUC_VUNull()	{
		return pm_objDR.IsNull("ID_LOAI_CHUC_VU");
	}

	public void SetID_LOAI_CHUC_VUNull() {
		pm_objDR["ID_LOAI_CHUC_VU"] = System.Convert.DBNull;
	}

	public string strGHI_CHU 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "GHI_CHU", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["GHI_CHU"] = value;
		}
	}

	public bool IsGHI_CHUNull() 
	{
		return pm_objDR.IsNull("GHI_CHU");
	}

	public void SetGHI_CHUNull() {
		pm_objDR["GHI_CHU"] = System.Convert.DBNull;
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

	public decimal dcTHU_TU_DON_VI 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "THU_TU_DON_VI", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["THU_TU_DON_VI"] = value;
		}
	}

	public bool IsTHU_TU_DON_VINull()	{
		return pm_objDR.IsNull("THU_TU_DON_VI");
	}

	public void SetTHU_TU_DON_VINull() {
		pm_objDR["THU_TU_DON_VI"] = System.Convert.DBNull;
	}

	public decimal dcID_DON_VI_CAP_TREN 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_DON_VI_CAP_TREN", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_DON_VI_CAP_TREN"] = value;
		}
	}

	public bool IsID_DON_VI_CAP_TRENNull()	{
		return pm_objDR.IsNull("ID_DON_VI_CAP_TREN");
	}

	public void SetID_DON_VI_CAP_TRENNull() {
		pm_objDR["ID_DON_VI_CAP_TREN"] = System.Convert.DBNull;
	}

	public string strMA_DON_VI 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "MA_DON_VI", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["MA_DON_VI"] = value;
		}
	}

	public bool IsMA_DON_VINull() 
	{
		return pm_objDR.IsNull("MA_DON_VI");
	}

	public void SetMA_DON_VINull() {
		pm_objDR["MA_DON_VI"] = System.Convert.DBNull;
	}

#endregion
#region "Init Functions"
	public US_V_DM_CHUC_VU() 
	{
		pm_objDS = new DS_V_DM_CHUC_VU();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_V_DM_CHUC_VU(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_V_DM_CHUC_VU(decimal i_dbID) 
	{
		pm_objDS = new DS_V_DM_CHUC_VU();
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
