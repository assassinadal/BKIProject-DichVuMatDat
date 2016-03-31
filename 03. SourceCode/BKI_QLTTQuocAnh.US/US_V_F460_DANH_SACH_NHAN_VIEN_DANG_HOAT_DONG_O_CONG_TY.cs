///************************************************
/// Generated by: haihd
/// Date: 30-03-2016 05:18:51
/// Goal: Create User Service Class for V_F460_DANH_SACH_NHAN_VIEN_DANG_HOAT_DONG_O_CONG_TY
///************************************************
/// <summary>
/// Create User Service Class for V_F460_DANH_SACH_NHAN_VIEN_DANG_HOAT_DONG_O_CONG_TY
/// </summary>

using System;
using BKI_DichVuMatDat.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BKI_DichVuMatDat.US{

public class US_V_F460_DANH_SACH_NHAN_VIEN_DANG_HOAT_DONG_O_CONG_TY : US_Object
{
	private const string c_TableName = "V_F460_DANH_SACH_NHAN_VIEN_DANG_HOAT_DONG_O_CONG_TY";
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

	public string strTRINH_DO_VAN_HOA 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "TRINH_DO_VAN_HOA", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["TRINH_DO_VAN_HOA"] = value;
		}
	}

	public bool IsTRINH_DO_VAN_HOANull() 
	{
		return pm_objDR.IsNull("TRINH_DO_VAN_HOA");
	}

	public void SetTRINH_DO_VAN_HOANull() {
		pm_objDR["TRINH_DO_VAN_HOA"] = System.Convert.DBNull;
	}

	public decimal dcTUOI 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "TUOI", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["TUOI"] = value;
		}
	}

	public bool IsTUOINull()	{
		return pm_objDR.IsNull("TUOI");
	}

	public void SetTUOINull() {
		pm_objDR["TUOI"] = System.Convert.DBNull;
	}

	public decimal dcLOAI_HOP_DONG 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "LOAI_HOP_DONG", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["LOAI_HOP_DONG"] = value;
		}
	}

	public bool IsLOAI_HOP_DONGNull()	{
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

	public decimal dcID_VI_TRI 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_VI_TRI", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_VI_TRI"] = value;
		}
	}

	public bool IsID_VI_TRINull()	{
		return pm_objDR.IsNull("ID_VI_TRI");
	}

	public void SetID_VI_TRINull() {
		pm_objDR["ID_VI_TRI"] = System.Convert.DBNull;
	}

	public string strTEN_VI_TRI 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "TEN_VI_TRI", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["TEN_VI_TRI"] = value;
		}
	}

	public bool IsTEN_VI_TRINull() 
	{
		return pm_objDR.IsNull("TEN_VI_TRI");
	}

	public void SetTEN_VI_TRINull() {
		pm_objDR["TEN_VI_TRI"] = System.Convert.DBNull;
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

#endregion
#region "Init Functions"
	public US_V_F460_DANH_SACH_NHAN_VIEN_DANG_HOAT_DONG_O_CONG_TY() 
	{
		pm_objDS = new DS_V_F460_DANH_SACH_NHAN_VIEN_DANG_HOAT_DONG_O_CONG_TY();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_V_F460_DANH_SACH_NHAN_VIEN_DANG_HOAT_DONG_O_CONG_TY(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_V_F460_DANH_SACH_NHAN_VIEN_DANG_HOAT_DONG_O_CONG_TY(decimal i_dbID) 
	{
		pm_objDS = new DS_V_F460_DANH_SACH_NHAN_VIEN_DANG_HOAT_DONG_O_CONG_TY();
		pm_strTableName = c_TableName;
		IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
		v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
		SqlCommand v_cmdSQL;
		v_cmdSQL = v_objMkCmd.getSelectCmd();
		this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
		pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
	}
        #endregion
        public void load_du_lieu_nhan_vien_hoat_dong(DataSet op_ds, DateTime ip_dat)
        {
            CStoredProc v_cstore = new CStoredProc("PR_XUAT_DANH_SACH_NHAN_VIEN_HOAT_DONG");

            v_cstore.addDatetimeInputParam("@IP_DAT", ip_dat);

            v_cstore.fillDataSetByCommand(this, op_ds);
        }
    }
}