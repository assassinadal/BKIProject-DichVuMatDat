///************************************************
/// Generated by: haihd
/// Date: 05/09/2015 11:07:22
/// Goal: Create User Service Class for GD_THU_NHAP_KHAC
///************************************************
/// <summary>
/// Create User Service Class for GD_THU_NHAP_KHAC
/// </summary>

using System;
using BKI_DichVuMatDat.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BKI_DichVuMatDat.US{

public class US_GD_THU_NHAP_KHAC : US_Object
{
	private const string c_TableName = "GD_THU_NHAP_KHAC";
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

	public bool IsID_NHAN_VIENNull()	{
		return pm_objDR.IsNull("ID_NHAN_VIEN");
	}

	public void SetID_NHAN_VIENNull() {
		pm_objDR["ID_NHAN_VIEN"] = System.Convert.DBNull;
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

	public bool IsTHANGNull()	{
		return pm_objDR.IsNull("THANG");
	}

	public void SetTHANGNull() {
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

	public bool IsNAMNull()	{
		return pm_objDR.IsNull("NAM");
	}

	public void SetNAMNull() {
		pm_objDR["NAM"] = System.Convert.DBNull;
	}

	public string strLY_DO 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "LY_DO", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["LY_DO"] = value;
		}
	}

	public bool IsLY_DONull() 
	{
		return pm_objDR.IsNull("LY_DO");
	}

	public void SetLY_DONull() {
		pm_objDR["LY_DO"] = System.Convert.DBNull;
	}

	public decimal dcID_CACH_TINH_THUE 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_CACH_TINH_THUE", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_CACH_TINH_THUE"] = value;
		}
	}

	public bool IsID_CACH_TINH_THUENull()	{
		return pm_objDR.IsNull("ID_CACH_TINH_THUE");
	}

	public void SetID_CACH_TINH_THUENull() {
		pm_objDR["ID_CACH_TINH_THUE"] = System.Convert.DBNull;
	}

	public decimal dcID_LOAI_THU_NHAP_KHAC 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_LOAI_THU_NHAP_KHAC", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_LOAI_THU_NHAP_KHAC"] = value;
		}
	}

	public bool IsID_LOAI_THU_NHAP_KHACNull()	{
		return pm_objDR.IsNull("ID_LOAI_THU_NHAP_KHAC");
	}

	public void SetID_LOAI_THU_NHAP_KHACNull() {
		pm_objDR["ID_LOAI_THU_NHAP_KHAC"] = System.Convert.DBNull;
	}

#endregion
#region "Init Functions"
	public US_GD_THU_NHAP_KHAC() 
	{
		pm_objDS = new DS_GD_THU_NHAP_KHAC();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_GD_THU_NHAP_KHAC(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_GD_THU_NHAP_KHAC(decimal i_dbID) 
	{
		pm_objDS = new DS_GD_THU_NHAP_KHAC();
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
