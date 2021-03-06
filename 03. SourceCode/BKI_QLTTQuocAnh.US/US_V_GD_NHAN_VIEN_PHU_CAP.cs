///************************************************
/// Generated by: HaiHD
/// Date: 03/03/2016 03:17:58
/// Goal: Create User Service Class for V_GD_NHAN_VIEN_PHU_CAP
///************************************************
/// <summary>
/// Create User Service Class for V_GD_NHAN_VIEN_PHU_CAP
/// </summary>

using System;
using BKI_DichVuMatDat.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BKI_DichVuMatDat.US{

public class US_V_GD_NHAN_VIEN_PHU_CAP : US_Object
{
	private const string c_TableName = "V_GD_NHAN_VIEN_PHU_CAP";
#region "Public Properties"
	public string strMA_QUYET_DINH 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "MA_QUYET_DINH", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["MA_QUYET_DINH"] = value;
		}
	}

	public bool IsMA_QUYET_DINHNull() 
	{
		return pm_objDR.IsNull("MA_QUYET_DINH");
	}

	public void SetMA_QUYET_DINHNull() {
		pm_objDR["MA_QUYET_DINH"] = System.Convert.DBNull;
	}

	public string strNOI_DUNG 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "NOI_DUNG", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["NOI_DUNG"] = value;
		}
	}

	public bool IsNOI_DUNGNull() 
	{
		return pm_objDR.IsNull("NOI_DUNG");
	}

	public void SetNOI_DUNGNull() {
		pm_objDR["NOI_DUNG"] = System.Convert.DBNull;
	}

	public DateTime datNGAY_KY
	{
		get   
		{
			return CNull.RowNVLDate(pm_objDR, "NGAY_KY", IPConstants.c_DefaultDate);
		}
		set   
		{
			pm_objDR["NGAY_KY"] = value;
		}
	}

	public bool IsNGAY_KYNull()
	{
		return pm_objDR.IsNull("NGAY_KY");
	}

	public void SetNGAY_KYNull()
	{
		pm_objDR["NGAY_KY"] = System.Convert.DBNull;
	}

	public DateTime datNGAY_HET_HIEU_LUC
	{
		get   
		{
			return CNull.RowNVLDate(pm_objDR, "NGAY_HET_HIEU_LUC", IPConstants.c_DefaultDate);
		}
		set   
		{
			pm_objDR["NGAY_HET_HIEU_LUC"] = value;
		}
	}

	public bool IsNGAY_HET_HIEU_LUCNull()
	{
		return pm_objDR.IsNull("NGAY_HET_HIEU_LUC");
	}

	public void SetNGAY_HET_HIEU_LUCNull()
	{
		pm_objDR["NGAY_HET_HIEU_LUC"] = System.Convert.DBNull;
	}

	public DateTime datNGAY_CO_HIEU_LUC
	{
		get   
		{
			return CNull.RowNVLDate(pm_objDR, "NGAY_CO_HIEU_LUC", IPConstants.c_DefaultDate);
		}
		set   
		{
			pm_objDR["NGAY_CO_HIEU_LUC"] = value;
		}
	}

	public bool IsNGAY_CO_HIEU_LUCNull()
	{
		return pm_objDR.IsNull("NGAY_CO_HIEU_LUC");
	}

	public void SetNGAY_CO_HIEU_LUCNull()
	{
		pm_objDR["NGAY_CO_HIEU_LUC"] = System.Convert.DBNull;
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

	public decimal dcID_PHU_CAP 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_PHU_CAP", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_PHU_CAP"] = value;
		}
	}

	public bool IsID_PHU_CAPNull()	{
		return pm_objDR.IsNull("ID_PHU_CAP");
	}

	public void SetID_PHU_CAPNull() {
		pm_objDR["ID_PHU_CAP"] = System.Convert.DBNull;
	}

	public decimal dcID_QUYET_DINH 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_QUYET_DINH", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_QUYET_DINH"] = value;
		}
	}

	public bool IsID_QUYET_DINHNull()	{
		return pm_objDR.IsNull("ID_QUYET_DINH");
	}

	public void SetID_QUYET_DINHNull() {
		pm_objDR["ID_QUYET_DINH"] = System.Convert.DBNull;
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

	public void SetDA_XOANull() {
		pm_objDR["DA_XOA"] = System.Convert.DBNull;
	}

	public string strCHUC_VU_TUONG_UNG 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "CHUC_VU_TUONG_UNG", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["CHUC_VU_TUONG_UNG"] = value;
		}
	}

	public bool IsCHUC_VU_TUONG_UNGNull() 
	{
		return pm_objDR.IsNull("CHUC_VU_TUONG_UNG");
	}

	public void SetCHUC_VU_TUONG_UNGNull() {
		pm_objDR["CHUC_VU_TUONG_UNG"] = System.Convert.DBNull;
	}

	public decimal dcHS_PHU_CAP 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "HS_PHU_CAP", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["HS_PHU_CAP"] = value;
		}
	}

	public bool IsHS_PHU_CAPNull()	{
		return pm_objDR.IsNull("HS_PHU_CAP");
	}

	public void SetHS_PHU_CAPNull() {
		pm_objDR["HS_PHU_CAP"] = System.Convert.DBNull;
	}

#endregion
#region "Init Functions"
	public US_V_GD_NHAN_VIEN_PHU_CAP() 
	{
		pm_objDS = new DS_V_GD_NHAN_VIEN_PHU_CAP();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_V_GD_NHAN_VIEN_PHU_CAP(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_V_GD_NHAN_VIEN_PHU_CAP(decimal i_dbID) 
	{
		pm_objDS = new DS_V_GD_NHAN_VIEN_PHU_CAP();
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
