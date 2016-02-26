///************************************************
/// Generated by: haihd
/// Date: 23-01-2016 03:19:28
/// Goal: Create User Service Class for RPT_THONG_TIN_TONG_HOP_V2
///************************************************
/// <summary>
/// Create User Service Class for RPT_THONG_TIN_TONG_HOP_V2
/// </summary>

using System;
using BKI_DichVuMatDat.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BKI_DichVuMatDat.US{

public class US_RPT_THONG_TIN_TONG_HOP_V2 : US_Object
{
	private const string c_TableName = "RPT_THONG_TIN_TONG_HOP_V2";
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

	public string strHO_VA_TEN 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "HO_VA_TEN", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["HO_VA_TEN"] = value;
		}
	}

	public bool IsHO_VA_TENNull() 
	{
		return pm_objDR.IsNull("HO_VA_TEN");
	}

	public void SetHO_VA_TENNull() {
		pm_objDR["HO_VA_TEN"] = System.Convert.DBNull;
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

	public string strTEN_HOP_DONG 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "TEN_HOP_DONG", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["TEN_HOP_DONG"] = value;
		}
	}

	public bool IsTEN_HOP_DONGNull() 
	{
		return pm_objDR.IsNull("TEN_HOP_DONG");
	}

	public void SetTEN_HOP_DONGNull() {
		pm_objDR["TEN_HOP_DONG"] = System.Convert.DBNull;
	}

	public decimal dcLUONG_CHE_DO_THEO_CHUC_VU 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "LUONG_CHE_DO_THEO_CHUC_VU", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["LUONG_CHE_DO_THEO_CHUC_VU"] = value;
		}
	}

	public bool IsLUONG_CHE_DO_THEO_CHUC_VUNull()	{
		return pm_objDR.IsNull("LUONG_CHE_DO_THEO_CHUC_VU");
	}

	public void SetLUONG_CHE_DO_THEO_CHUC_VUNull() {
		pm_objDR["LUONG_CHE_DO_THEO_CHUC_VU"] = System.Convert.DBNull;
	}

	public decimal dcHS_LUONG_NANG_SUAT_DUOC_HUONG 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "HS_LUONG_NANG_SUAT_DUOC_HUONG", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["HS_LUONG_NANG_SUAT_DUOC_HUONG"] = value;
		}
	}

	public bool IsHS_LUONG_NANG_SUAT_DUOC_HUONGNull()	{
		return pm_objDR.IsNull("HS_LUONG_NANG_SUAT_DUOC_HUONG");
	}

	public void SetHS_LUONG_NANG_SUAT_DUOC_HUONGNull() {
		pm_objDR["HS_LUONG_NANG_SUAT_DUOC_HUONG"] = System.Convert.DBNull;
	}

	public string strTAI_KHOAN 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "TAI_KHOAN", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["TAI_KHOAN"] = value;
		}
	}

	public bool IsTAI_KHOANNull() 
	{
		return pm_objDR.IsNull("TAI_KHOAN");
	}

	public void SetTAI_KHOANNull() {
		pm_objDR["TAI_KHOAN"] = System.Convert.DBNull;
	}

	public decimal dcCHAM_CONG_X 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "CHAM_CONG_X", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["CHAM_CONG_X"] = value;
		}
	}

	public bool IsCHAM_CONG_XNull()	{
		return pm_objDR.IsNull("CHAM_CONG_X");
	}

	public void SetCHAM_CONG_XNull() {
		pm_objDR["CHAM_CONG_X"] = System.Convert.DBNull;
	}

	public decimal dcCHAM_CONG_OM_CO 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "CHAM_CONG_OM_CO", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["CHAM_CONG_OM_CO"] = value;
		}
	}

	public bool IsCHAM_CONG_OM_CONull()	{
		return pm_objDR.IsNull("CHAM_CONG_OM_CO");
	}

	public void SetCHAM_CONG_OM_CONull() {
		pm_objDR["CHAM_CONG_OM_CO"] = System.Convert.DBNull;
	}

	public decimal dcCHAM_CONG_TS 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "CHAM_CONG_TS", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["CHAM_CONG_TS"] = value;
		}
	}

	public bool IsCHAM_CONG_TSNull()	{
		return pm_objDR.IsNull("CHAM_CONG_TS");
	}

	public void SetCHAM_CONG_TSNull() {
		pm_objDR["CHAM_CONG_TS"] = System.Convert.DBNull;
	}

	public decimal dcCHAM_CONG_TNLD 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "CHAM_CONG_TNLD", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["CHAM_CONG_TNLD"] = value;
		}
	}

	public bool IsCHAM_CONG_TNLDNull()	{
		return pm_objDR.IsNull("CHAM_CONG_TNLD");
	}

	public void SetCHAM_CONG_TNLDNull() {
		pm_objDR["CHAM_CONG_TNLD"] = System.Convert.DBNull;
	}

	public decimal dcCHAM_CONG_PHEP_DIDUONG 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "CHAM_CONG_PHEP_DIDUONG", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["CHAM_CONG_PHEP_DIDUONG"] = value;
		}
	}

	public bool IsCHAM_CONG_PHEP_DIDUONGNull()	{
		return pm_objDR.IsNull("CHAM_CONG_PHEP_DIDUONG");
	}

	public void SetCHAM_CONG_PHEP_DIDUONGNull() {
		pm_objDR["CHAM_CONG_PHEP_DIDUONG"] = System.Convert.DBNull;
	}

	public decimal dcCHAM_CONG_RO_KO_DC 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "CHAM_CONG_RO_KO_DC", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["CHAM_CONG_RO_KO_DC"] = value;
		}
	}

	public bool IsCHAM_CONG_RO_KO_DCNull()	{
		return pm_objDR.IsNull("CHAM_CONG_RO_KO_DC");
	}

	public void SetCHAM_CONG_RO_KO_DCNull() {
		pm_objDR["CHAM_CONG_RO_KO_DC"] = System.Convert.DBNull;
	}

	public decimal dcCHAM_CONG_KHAC 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "CHAM_CONG_KHAC", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["CHAM_CONG_KHAC"] = value;
		}
	}

	public bool IsCHAM_CONG_KHACNull()	{
		return pm_objDR.IsNull("CHAM_CONG_KHAC");
	}

	public void SetCHAM_CONG_KHACNull() {
		pm_objDR["CHAM_CONG_KHAC"] = System.Convert.DBNull;
	}

	public decimal dcHE_SO_K 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "HE_SO_K", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["HE_SO_K"] = value;
		}
	}

	public bool IsHE_SO_KNull()	{
		return pm_objDR.IsNull("HE_SO_K");
	}

	public void SetHE_SO_KNull() {
		pm_objDR["HE_SO_K"] = System.Convert.DBNull;
	}

	public string strDON_VI 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "DON_VI", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["DON_VI"] = value;
		}
	}

	public bool IsDON_VINull() 
	{
		return pm_objDR.IsNull("DON_VI");
	}

	public void SetDON_VINull() {
		pm_objDR["DON_VI"] = System.Convert.DBNull;
	}

	public decimal dcNGAY_CONG_QUY_DINH 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "NGAY_CONG_QUY_DINH", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["NGAY_CONG_QUY_DINH"] = value;
		}
	}

	public bool IsNGAY_CONG_QUY_DINHNull()	{
		return pm_objDR.IsNull("NGAY_CONG_QUY_DINH");
	}

	public void SetNGAY_CONG_QUY_DINHNull() {
		pm_objDR["NGAY_CONG_QUY_DINH"] = System.Convert.DBNull;
	}

	public string strLOAI_LAO_DONG 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "LOAI_LAO_DONG", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["LOAI_LAO_DONG"] = value;
		}
	}

	public bool IsLOAI_LAO_DONGNull() 
	{
		return pm_objDR.IsNull("LOAI_LAO_DONG");
	}

	public void SetLOAI_LAO_DONGNull() {
		pm_objDR["LOAI_LAO_DONG"] = System.Convert.DBNull;
	}

	public decimal dcSO_NGAY_LAM_THEM 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "SO_NGAY_LAM_THEM", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["SO_NGAY_LAM_THEM"] = value;
		}
	}

	public bool IsSO_NGAY_LAM_THEMNull()	{
		return pm_objDR.IsNull("SO_NGAY_LAM_THEM");
	}

	public void SetSO_NGAY_LAM_THEMNull() {
		pm_objDR["SO_NGAY_LAM_THEM"] = System.Convert.DBNull;
	}

#endregion
#region "Init Functions"
	public US_RPT_THONG_TIN_TONG_HOP_V2() 
	{
		pm_objDS = new DS_RPT_THONG_TIN_TONG_HOP_V2();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_RPT_THONG_TIN_TONG_HOP_V2(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_RPT_THONG_TIN_TONG_HOP_V2(decimal i_dbID) 
	{
		pm_objDS = new DS_RPT_THONG_TIN_TONG_HOP_V2();
		pm_strTableName = c_TableName;
		IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
		v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
		SqlCommand v_cmdSQL;
		v_cmdSQL = v_objMkCmd.getSelectCmd();
		this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
		pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
	}
#endregion
    public void FillThongTinTongHopNhanVienV2(DataSet ip_ds, decimal ip_dc_id_nhan_vien, decimal ip_dc_thang, decimal ip_dc_nam)
    {
        CStoredProc v_cstore = new CStoredProc("pr_rpt_lay_thong_tin_tong_hop_1_nhan_vien_v2");
        v_cstore.addDecimalInputParam("@ip_dc_id_nhan_vien", ip_dc_id_nhan_vien);
        v_cstore.addDecimalInputParam("@ip_int_thang", ip_dc_thang);
        v_cstore.addDecimalInputParam("@ip_int_nam", ip_dc_nam);
        v_cstore.fillDataSetByCommand(this, ip_ds);
    }


    public void HienThiBaoCao(DataSet ip_ds, decimal ip_dc_thang, decimal ip_dc_nam)
    {
        CStoredProc v_cstore = new CStoredProc("PR_RPT_BAO_CAO_TONG_HOP_SELECT");
        v_cstore.addDecimalInputParam("@ip_dc_thang", ip_dc_thang);
        v_cstore.addDecimalInputParam("@ip_dc_nam", ip_dc_nam);

        v_cstore.fillDataSetByCommand(this, ip_ds);
    }








    public void Get_nhan_vien_can_tong_hop_thong_tin(DS_RPT_THONG_TIN_TONG_HOP_V2 op_ds, decimal ip_thang, decimal ip_nam)
    {
        op_ds.EnforceConstraints = false;
        CStoredProc v_sp = new CStoredProc("pr_GET_DANH_SACH_NHAN_VIEN_CAN_TONG_HOP_THONG_TIN_V2");
        v_sp.addDecimalInputParam("@THANG", ip_thang);
        v_sp.addDecimalInputParam("@NAM", ip_nam);
        v_sp.fillDataSetByCommand(this, op_ds);
    }
    public void Get_tat_ca_nhan_vien_can_tong_hop_thong_tin_v2(DS_RPT_THONG_TIN_TONG_HOP_V2 op_ds, decimal ip_thang, decimal ip_nam)
    {
        op_ds.EnforceConstraints = false;
        CStoredProc v_sp = new CStoredProc("pr_GET_TAT_CA_NHAN_VIEN_CAN_TONG_HOP_THONG_TIN_V2");
        v_sp.addDecimalInputParam("@THANG", ip_thang);
        v_sp.addDecimalInputParam("@NAM", ip_nam);
        v_sp.fillDataSetByCommand(this, op_ds);
    }

    public void xoa_bang_tong_hop_thang(decimal ip_thang, decimal ip_nam)
    {
        CStoredProc v_sp = new CStoredProc("pr_xoa_bang_tong_hop_thang");
        v_sp.addDecimalInputParam("@THANG", ip_thang);
        v_sp.addDecimalInputParam("@NAM", ip_nam);
        v_sp.ExecuteCommand(this);
    }
}
}
