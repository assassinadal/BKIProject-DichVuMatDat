///************************************************
/// Generated by: sonpt
/// Date: 03/03/2016 06:04:26
/// Goal: Create User Service Class for V_DM_LOAI_HOP_DONG
///************************************************
/// <summary>
/// Create User Service Class for V_DM_LOAI_HOP_DONG
/// </summary>

using System;
using BKI_DichVuMatDat.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BKI_DichVuMatDat.US{

public class US_V_DM_LOAI_HOP_DONG : US_Object
{
	private const string c_TableName = "V_DM_LOAI_HOP_DONG";
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

	public void SetMA_LOAI_HOP_DONGNull() {
		pm_objDR["MA_LOAI_HOP_DONG"] = System.Convert.DBNull;
	}

	public decimal dcTI_LE 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "TI_LE", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["TI_LE"] = value;
		}
	}

	public bool IsTI_LENull()	{
		return pm_objDR.IsNull("TI_LE");
	}

	public void SetTI_LENull() {
		pm_objDR["TI_LE"] = System.Convert.DBNull;
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

	public bool IsSO_TIENNull()	{
		return pm_objDR.IsNull("SO_TIEN");
	}

	public void SetSO_TIENNull() {
		pm_objDR["SO_TIEN"] = System.Convert.DBNull;
	}

	public string strHS_LNS_YN 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "HS_LNS_YN", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["HS_LNS_YN"] = value;
		}
	}

	public bool IsHS_LNS_YNNull() 
	{
		return pm_objDR.IsNull("HS_LNS_YN");
	}

	public void SetHS_LNS_YNNull() {
		pm_objDR["HS_LNS_YN"] = System.Convert.DBNull;
	}

	public string strAN_CA_YN 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "AN_CA_YN", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["AN_CA_YN"] = value;
		}
	}

	public bool IsAN_CA_YNNull() 
	{
		return pm_objDR.IsNull("AN_CA_YN");
	}

	public void SetAN_CA_YNNull() {
		pm_objDR["AN_CA_YN"] = System.Convert.DBNull;
	}

	public string strLCD_YN 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "LCD_YN", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["LCD_YN"] = value;
		}
	}

	public bool IsLCD_YNNull() 
	{
		return pm_objDR.IsNull("LCD_YN");
	}

	public void SetLCD_YNNull() {
		pm_objDR["LCD_YN"] = System.Convert.DBNull;
	}

#endregion
#region "Init Functions"
	public US_V_DM_LOAI_HOP_DONG() 
	{
		pm_objDS = new DS_V_DM_LOAI_HOP_DONG();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_V_DM_LOAI_HOP_DONG(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_V_DM_LOAI_HOP_DONG(decimal i_dbID) 
	{
		pm_objDS = new DS_V_DM_LOAI_HOP_DONG();
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
