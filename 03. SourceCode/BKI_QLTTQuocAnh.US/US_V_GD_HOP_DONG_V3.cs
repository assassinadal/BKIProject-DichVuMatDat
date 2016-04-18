///************************************************
/// Generated by: huongtt
/// Date: 14/04/2016 01:44:53
/// Goal: Create User Service Class for V_GD_HOP_DONG_V3
///************************************************
/// <summary>
/// Create User Service Class for V_GD_HOP_DONG_V3
/// </summary>

using System;
using BKI_DichVuMatDat.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BKI_DichVuMatDat.US{

public class US_V_GD_HOP_DONG_V3 : US_Object
{
	private const string c_TableName = "V_GD_HOP_DONG_V3";
#region "Public Properties"
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

	public decimal dcID_LOAI_HOP_DONG 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_LOAI_HOP_DONG", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_LOAI_HOP_DONG"] = value;
		}
	}

	public bool IsID_LOAI_HOP_DONGNull()	{
		return pm_objDR.IsNull("ID_LOAI_HOP_DONG");
	}

	public void SetID_LOAI_HOP_DONGNull() {
		pm_objDR["ID_LOAI_HOP_DONG"] = System.Convert.DBNull;
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

	public DateTime datNGAY_BAT_DAU
	{
		get   
		{
			return CNull.RowNVLDate(pm_objDR, "NGAY_BAT_DAU", IPConstants.c_DefaultDate);
		}
		set   
		{
			pm_objDR["NGAY_BAT_DAU"] = value;
		}
	}

	public bool IsNGAY_BAT_DAUNull()
	{
		return pm_objDR.IsNull("NGAY_BAT_DAU");
	}

	public void SetNGAY_BAT_DAUNull()
	{
		pm_objDR["NGAY_BAT_DAU"] = System.Convert.DBNull;
	}

	public DateTime datNGAY_KET_THUC
	{
		get   
		{
			return CNull.RowNVLDate(pm_objDR, "NGAY_KET_THUC", IPConstants.c_DefaultDate);
		}
		set   
		{
			pm_objDR["NGAY_KET_THUC"] = value;
		}
	}

	public bool IsNGAY_KET_THUCNull()
	{
		return pm_objDR.IsNull("NGAY_KET_THUC");
	}

	public void SetNGAY_KET_THUCNull()
	{
		pm_objDR["NGAY_KET_THUC"] = System.Convert.DBNull;
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

	public DateTime datNGAY_SUA
	{
		get   
		{
			return CNull.RowNVLDate(pm_objDR, "NGAY_SUA", IPConstants.c_DefaultDate);
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

	public void SetNGUOI_LAPNull() {
		pm_objDR["NGUOI_LAP"] = System.Convert.DBNull;
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

	public void SetNGUOI_SUANull() {
		pm_objDR["NGUOI_SUA"] = System.Convert.DBNull;
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

	public decimal dcID_MA_LNS 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_MA_LNS", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_MA_LNS"] = value;
		}
	}

	public bool IsID_MA_LNSNull()	{
		return pm_objDR.IsNull("ID_MA_LNS");
	}

	public void SetID_MA_LNSNull() {
		pm_objDR["ID_MA_LNS"] = System.Convert.DBNull;
	}

	public decimal dcID_MUC_LNS 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_MUC_LNS", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_MUC_LNS"] = value;
		}
	}

	public bool IsID_MUC_LNSNull()	{
		return pm_objDR.IsNull("ID_MUC_LNS");
	}

	public void SetID_MUC_LNSNull() {
		pm_objDR["ID_MUC_LNS"] = System.Convert.DBNull;
	}

	public decimal dcID_MA_LCD 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_MA_LCD", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_MA_LCD"] = value;
		}
	}

	public bool IsID_MA_LCDNull()	{
		return pm_objDR.IsNull("ID_MA_LCD");
	}

	public void SetID_MA_LCDNull() {
		pm_objDR["ID_MA_LCD"] = System.Convert.DBNull;
	}

	public decimal dcID_MUC_LCD 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_MUC_LCD", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_MUC_LCD"] = value;
		}
	}

	public bool IsID_MUC_LCDNull()	{
		return pm_objDR.IsNull("ID_MUC_LCD");
	}

	public void SetID_MUC_LCDNull() {
		pm_objDR["ID_MUC_LCD"] = System.Convert.DBNull;
	}

	public decimal dcHE_SO 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "HE_SO", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["HE_SO"] = value;
		}
	}

	public bool IsHE_SONull()	{
		return pm_objDR.IsNull("HE_SO");
	}

	public void SetHE_SONull() {
		pm_objDR["HE_SO"] = System.Convert.DBNull;
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

	public string strMA_LNS 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "MA_LNS", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["MA_LNS"] = value;
		}
	}

	public bool IsMA_LNSNull() 
	{
		return pm_objDR.IsNull("MA_LNS");
	}

	public void SetMA_LNSNull() {
		pm_objDR["MA_LNS"] = System.Convert.DBNull;
	}

	public string strMUC_LNS 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "MUC_LNS", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["MUC_LNS"] = value;
		}
	}

	public bool IsMUC_LNSNull() 
	{
		return pm_objDR.IsNull("MUC_LNS");
	}

	public void SetMUC_LNSNull() {
		pm_objDR["MUC_LNS"] = System.Convert.DBNull;
	}

	public string strMA_LCD 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "MA_LCD", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["MA_LCD"] = value;
		}
	}

	public bool IsMA_LCDNull() 
	{
		return pm_objDR.IsNull("MA_LCD");
	}

	public void SetMA_LCDNull() {
		pm_objDR["MA_LCD"] = System.Convert.DBNull;
	}

	public string strMUC_LCD 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "MUC_LCD", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["MUC_LCD"] = value;
		}
	}

	public bool IsMUC_LCDNull() 
	{
		return pm_objDR.IsNull("MUC_LCD");
	}

	public void SetMUC_LCDNull() {
		pm_objDR["MUC_LCD"] = System.Convert.DBNull;
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

#endregion
#region "Init Functions"
	public US_V_GD_HOP_DONG_V3() 
	{
		pm_objDS = new DS_V_GD_HOP_DONG_V3();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_V_GD_HOP_DONG_V3(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_V_GD_HOP_DONG_V3(decimal i_dbID) 
	{
		pm_objDS = new DS_V_GD_HOP_DONG_V3();
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