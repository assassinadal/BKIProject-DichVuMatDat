///************************************************
/// Generated by: HaiHD
/// Date: 07/01/2016 04:41:58
/// Goal: Create User Service Class for V_F356_BAO_CAO_TRANG_THAI_LAO_DONG_CUA_NHAN_VIEN
///************************************************
/// <summary>
/// Create User Service Class for V_F356_BAO_CAO_TRANG_THAI_LAO_DONG_CUA_NHAN_VIEN
/// </summary>

using System;
using BKI_DichVuMatDat.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BKI_DichVuMatDat.US{

public class US_V_F356_BAO_CAO_TRANG_THAI_LAO_DONG_CUA_NHAN_VIEN : US_Object
{
	private const string c_TableName = "V_F356_BAO_CAO_TRANG_THAI_LAO_DONG_CUA_NHAN_VIEN";
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

	public string strHO_DEM 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "HO_DEM", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["HO_DEM"] = value;
		}
	}

	public bool IsHO_DEMNull() 
	{
		return pm_objDR.IsNull("HO_DEM");
	}

	public void SetHO_DEMNull() {
		pm_objDR["HO_DEM"] = System.Convert.DBNull;
	}

	public string strTEN 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "TEN", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["TEN"] = value;
		}
	}

	public bool IsTENNull() 
	{
		return pm_objDR.IsNull("TEN");
	}

	public void SetTENNull() {
		pm_objDR["TEN"] = System.Convert.DBNull;
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

	public decimal dcID_TRANG_THAI_LAO_DONG 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_TRANG_THAI_LAO_DONG", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_TRANG_THAI_LAO_DONG"] = value;
		}
	}

	public bool IsID_TRANG_THAI_LAO_DONGNull()	{
		return pm_objDR.IsNull("ID_TRANG_THAI_LAO_DONG");
	}

	public void SetID_TRANG_THAI_LAO_DONGNull() {
		pm_objDR["ID_TRANG_THAI_LAO_DONG"] = System.Convert.DBNull;
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

	public string strGHI_CHU_TRANG_THAI_LAO_DONG 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "GHI_CHU_TRANG_THAI_LAO_DONG", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["GHI_CHU_TRANG_THAI_LAO_DONG"] = value;
		}
	}

	public bool IsGHI_CHU_TRANG_THAI_LAO_DONGNull() 
	{
		return pm_objDR.IsNull("GHI_CHU_TRANG_THAI_LAO_DONG");
	}

	public void SetGHI_CHU_TRANG_THAI_LAO_DONGNull() {
		pm_objDR["GHI_CHU_TRANG_THAI_LAO_DONG"] = System.Convert.DBNull;
	}

	public decimal dcID_LOAI_TRANG_THAI_LD 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_LOAI_TRANG_THAI_LD", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_LOAI_TRANG_THAI_LD"] = value;
		}
	}

	public bool IsID_LOAI_TRANG_THAI_LDNull()	{
		return pm_objDR.IsNull("ID_LOAI_TRANG_THAI_LD");
	}

	public void SetID_LOAI_TRANG_THAI_LDNull() {
		pm_objDR["ID_LOAI_TRANG_THAI_LD"] = System.Convert.DBNull;
	}

	public string strMA_LOAI_TRANG_THAI_LD 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "MA_LOAI_TRANG_THAI_LD", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["MA_LOAI_TRANG_THAI_LD"] = value;
		}
	}

	public bool IsMA_LOAI_TRANG_THAI_LDNull() 
	{
		return pm_objDR.IsNull("MA_LOAI_TRANG_THAI_LD");
	}

	public void SetMA_LOAI_TRANG_THAI_LDNull() {
		pm_objDR["MA_LOAI_TRANG_THAI_LD"] = System.Convert.DBNull;
	}

	public string strTEN_LOAI_TRANG_THAI_LD 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "TEN_LOAI_TRANG_THAI_LD", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["TEN_LOAI_TRANG_THAI_LD"] = value;
		}
	}

	public bool IsTEN_LOAI_TRANG_THAI_LDNull() 
	{
		return pm_objDR.IsNull("TEN_LOAI_TRANG_THAI_LD");
	}

	public void SetTEN_LOAI_TRANG_THAI_LDNull() {
		pm_objDR["TEN_LOAI_TRANG_THAI_LD"] = System.Convert.DBNull;
	}

	public DateTime datNGAY_AP_DUNG
	{
		get   
		{
			return CNull.RowNVLDate(pm_objDR, "NGAY_AP_DUNG", IPConstants.c_DefaultDate);
		}
		set   
		{
			pm_objDR["NGAY_AP_DUNG"] = value;
		}
	}

	public bool IsNGAY_AP_DUNGNull()
	{
		return pm_objDR.IsNull("NGAY_AP_DUNG");
	}

	public void SetNGAY_AP_DUNGNull()
	{
		pm_objDR["NGAY_AP_DUNG"] = System.Convert.DBNull;
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

#endregion
#region "Init Functions"
	public US_V_F356_BAO_CAO_TRANG_THAI_LAO_DONG_CUA_NHAN_VIEN() 
	{
		pm_objDS = new DS_V_F356_BAO_CAO_TRANG_THAI_LAO_DONG_CUA_NHAN_VIEN();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_V_F356_BAO_CAO_TRANG_THAI_LAO_DONG_CUA_NHAN_VIEN(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_V_F356_BAO_CAO_TRANG_THAI_LAO_DONG_CUA_NHAN_VIEN(decimal i_dbID) 
	{
		pm_objDS = new DS_V_F356_BAO_CAO_TRANG_THAI_LAO_DONG_CUA_NHAN_VIEN();
		pm_strTableName = c_TableName;
		IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
		v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
		SqlCommand v_cmdSQL;
		v_cmdSQL = v_objMkCmd.getSelectCmd();
		this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
		pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
	}
#endregion

    //public void FillDataset_toan_bo_nv(
    //                        DS_V_F356_BAO_CAO_TRANG_THAI_LAO_DONG_CUA_NHAN_VIEN op_ds
    //                        , decimal m_load_data_toan_bo_nv)
    //{
    //    CStoredProc v_sp = new CStoredProc("Pr_f365_bao_cao_trang_thai_lao_dong_hien_tai_by_id_nhan_vien");
    //    v_sp.addDecimalInputParam("@ip_dc_id_nhan_vien", m_load_data_toan_bo_nv);
    //    v_sp.fillDataSetByCommand(this, op_ds); 
    //}


    //public void FillDataset_toan_bo_nv_theo_trang_thai(
    //                        DS_V_F356_BAO_CAO_TRANG_THAI_LAO_DONG_CUA_NHAN_VIEN op_ds
    //                        , decimal m_load_data_toan_bo_nv
    //                        , decimal ip_dc_id_trang_thai_lao_dong)
    //{
    //    CStoredProc v_sp = new CStoredProc("Pr_f365_bao_cao_trang_thai_lao_dong_hien_tai_by_id_nhan_vien_and_id_trang_thai_lao_dong");
    //    v_sp.addDecimalInputParam("@ip_dc_id_nhan_vien", m_load_data_toan_bo_nv);
    //    v_sp.addDecimalInputParam("@ip_dc_id_trang_thai_lao_dong", ip_dc_id_trang_thai_lao_dong);
    //    v_sp.fillDataSetByCommand(this, op_ds); 
    //}

    public void FillDataset_by_id_nv(
                            DS_V_F356_BAO_CAO_TRANG_THAI_LAO_DONG_CUA_NHAN_VIEN op_ds
                            , decimal ip_dc_id_nhan_vien)
    {
        CStoredProc v_sp = new CStoredProc("Pr_f356_bao_cao_trang_thai_lao_dong_hien_tai_by_id_nhan_vien");
        v_sp.addDecimalInputParam("@ip_dc_id_nhan_vien", ip_dc_id_nhan_vien);
        v_sp.fillDataSetByCommand(this, op_ds); 
    }

    public void FillDataset_by_id_nv_and_id_trang_thai_ld(
                            DS_V_F356_BAO_CAO_TRANG_THAI_LAO_DONG_CUA_NHAN_VIEN op_ds
                            , decimal ip_dc_id_nhan_vien
                            , decimal ip_dc_id_trang_thai_lao_dong)
    {
        CStoredProc v_sp = new CStoredProc("Pr_f356_bao_cao_trang_thai_lao_dong_hien_tai_by_id_nhan_vien_and_id_trang_thai_lao_dong");
        v_sp.addDecimalInputParam("@ip_dc_id_nhan_vien", ip_dc_id_nhan_vien);
        v_sp.addDecimalInputParam("@ip_dc_id_trang_thai_lao_dong", ip_dc_id_trang_thai_lao_dong);
        v_sp.fillDataSetByCommand(this, op_ds); 
    }
}
}
