///************************************************
/// Generated by: sonpt
/// Date: 26/04/2016 03:41:55
/// Goal: Create User Service Class for DM_TRANG_THAI_LD
///************************************************
/// <summary>
/// Create User Service Class for DM_TRANG_THAI_LD
/// </summary>

using System;
using BKI_DichVuMatDat.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BKI_DichVuMatDat.US{

public class US_DM_TRANG_THAI_LD : US_Object
{
	private const string c_TableName = "DM_TRANG_THAI_LD";
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

	public string strMA_TRANG_THAI_LD 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "MA_TRANG_THAI_LD", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["MA_TRANG_THAI_LD"] = value;
		}
	}

	public bool IsMA_TRANG_THAI_LDNull() 
	{
		return pm_objDR.IsNull("MA_TRANG_THAI_LD");
	}

	public void SetMA_TRANG_THAI_LDNull() {
		pm_objDR["MA_TRANG_THAI_LD"] = System.Convert.DBNull;
	}

	public string strTEN_TRANG_THAI_LD 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "TEN_TRANG_THAI_LD", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["TEN_TRANG_THAI_LD"] = value;
		}
	}

	public bool IsTEN_TRANG_THAI_LDNull() 
	{
		return pm_objDR.IsNull("TEN_TRANG_THAI_LD");
	}

	public void SetTEN_TRANG_THAI_LDNull() {
		pm_objDR["TEN_TRANG_THAI_LD"] = System.Convert.DBNull;
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

#endregion
#region "Init Functions"
	public US_DM_TRANG_THAI_LD() 
	{
		pm_objDS = new DS_DM_TRANG_THAI_LD();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_DM_TRANG_THAI_LD(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_DM_TRANG_THAI_LD(decimal i_dbID) 
	{
		pm_objDS = new DS_DM_TRANG_THAI_LD();
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
