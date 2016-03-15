///************************************************
/// Generated by: sonpt
/// Date: 03/03/2016 06:18:29
/// Goal: Create User Service Class for V_DM_LOAI_NGAY_CONG
///************************************************
/// <summary>
/// Create User Service Class for V_DM_LOAI_NGAY_CONG
/// </summary>

using System;
using BKI_DichVuMatDat.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BKI_DichVuMatDat.US{

public class US_V_DM_LOAI_NGAY_CONG : US_Object
{
	private const string c_TableName = "V_DM_LOAI_NGAY_CONG";
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

	public string strMA_NGAY_CONG 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "MA_NGAY_CONG", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["MA_NGAY_CONG"] = value;
		}
	}

	public bool IsMA_NGAY_CONGNull() 
	{
		return pm_objDR.IsNull("MA_NGAY_CONG");
	}

	public void SetMA_NGAY_CONGNull() {
		pm_objDR["MA_NGAY_CONG"] = System.Convert.DBNull;
	}

	public string strTEN_NGAY_CONG 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "TEN_NGAY_CONG", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["TEN_NGAY_CONG"] = value;
		}
	}

	public bool IsTEN_NGAY_CONGNull() 
	{
		return pm_objDR.IsNull("TEN_NGAY_CONG");
	}

	public void SetTEN_NGAY_CONGNull() {
		pm_objDR["TEN_NGAY_CONG"] = System.Convert.DBNull;
	}

	public decimal dcTI_LE_LNS 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "TI_LE_LNS", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["TI_LE_LNS"] = value;
		}
	}

	public bool IsTI_LE_LNSNull()	{
		return pm_objDR.IsNull("TI_LE_LNS");
	}

	public void SetTI_LE_LNSNull() {
		pm_objDR["TI_LE_LNS"] = System.Convert.DBNull;
	}

	public decimal dcTI_LE_LCD 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "TI_LE_LCD", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["TI_LE_LCD"] = value;
		}
	}

	public bool IsTI_LE_LCDNull()	{
		return pm_objDR.IsNull("TI_LE_LCD");
	}

	public void SetTI_LE_LCDNull() {
		pm_objDR["TI_LE_LCD"] = System.Convert.DBNull;
	}

#endregion
#region "Init Functions"
	public US_V_DM_LOAI_NGAY_CONG() 
	{
		pm_objDS = new DS_V_DM_LOAI_NGAY_CONG();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_V_DM_LOAI_NGAY_CONG(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_V_DM_LOAI_NGAY_CONG(decimal i_dbID) 
	{
		pm_objDS = new DS_V_DM_LOAI_NGAY_CONG();
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