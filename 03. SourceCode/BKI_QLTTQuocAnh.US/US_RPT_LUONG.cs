///************************************************
/// Generated by: huongtt
/// Date: 07/01/2016 05:37:19
/// Goal: Create User Service Class for RPT_LUONG
///************************************************
/// <summary>
/// Create User Service Class for RPT_LUONG
/// </summary>

using System;
using BKI_DichVuMatDat.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BKI_DichVuMatDat.US{

public class US_RPT_LUONG : US_Object
{
	private const string c_TableName = "RPT_LUONG";
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

    public bool IsIDNull()
    {
        return pm_objDR.IsNull("ID");
    }

    public void SetIDNull()
    {
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

    public bool IsID_NHAN_VIENNull()
    {
        return pm_objDR.IsNull("ID_NHAN_VIEN");
    }

    public void SetID_NHAN_VIENNull()
    {
        pm_objDR["ID_NHAN_VIEN"] = System.Convert.DBNull;
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

    public bool IsTHANGNull()
    {
        return pm_objDR.IsNull("THANG");
    }

    public void SetTHANGNull()
    {
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

    public bool IsNAMNull()
    {
        return pm_objDR.IsNull("NAM");
    }

    public void SetNAMNull()
    {
        pm_objDR["NAM"] = System.Convert.DBNull;
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

    public void SetMA_NVNull()
    {
        pm_objDR["MA_NV"] = System.Convert.DBNull;
    }

    public decimal dcLUONG_NS
    {
        get
        {
            return CNull.RowNVLDecimal(pm_objDR, "LUONG_NS", IPConstants.c_DefaultDecimal);
        }
        set
        {
            pm_objDR["LUONG_NS"] = value;
        }
    }

    public bool IsLUONG_NSNull()
    {
        return pm_objDR.IsNull("LUONG_NS");
    }

    public void SetLUONG_NSNull()
    {
        pm_objDR["LUONG_NS"] = System.Convert.DBNull;
    }

    public decimal dcLUONG_CD
    {
        get
        {
            return CNull.RowNVLDecimal(pm_objDR, "LUONG_CD", IPConstants.c_DefaultDecimal);
        }
        set
        {
            pm_objDR["LUONG_CD"] = value;
        }
    }

    public bool IsLUONG_CDNull()
    {
        return pm_objDR.IsNull("LUONG_CD");
    }

    public void SetLUONG_CDNull()
    {
        pm_objDR["LUONG_CD"] = System.Convert.DBNull;
    }

    public decimal dcPHU_CAP_TN
    {
        get
        {
            return CNull.RowNVLDecimal(pm_objDR, "PHU_CAP_TN", IPConstants.c_DefaultDecimal);
        }
        set
        {
            pm_objDR["PHU_CAP_TN"] = value;
        }
    }

    public bool IsPHU_CAP_TNNull()
    {
        return pm_objDR.IsNull("PHU_CAP_TN");
    }

    public void SetPHU_CAP_TNNull()
    {
        pm_objDR["PHU_CAP_TN"] = System.Convert.DBNull;
    }

    public decimal dcAN_CA
    {
        get
        {
            return CNull.RowNVLDecimal(pm_objDR, "AN_CA", IPConstants.c_DefaultDecimal);
        }
        set
        {
            pm_objDR["AN_CA"] = value;
        }
    }

    public bool IsAN_CANull()
    {
        return pm_objDR.IsNull("AN_CA");
    }

    public void SetAN_CANull()
    {
        pm_objDR["AN_CA"] = System.Convert.DBNull;
    }

    public decimal dcLAM_THEM
    {
        get
        {
            return CNull.RowNVLDecimal(pm_objDR, "LAM_THEM", IPConstants.c_DefaultDecimal);
        }
        set
        {
            pm_objDR["LAM_THEM"] = value;
        }
    }

    public bool IsLAM_THEMNull()
    {
        return pm_objDR.IsNull("LAM_THEM");
    }

    public void SetLAM_THEMNull()
    {
        pm_objDR["LAM_THEM"] = System.Convert.DBNull;
    }

    public decimal dcLAM_THEM_LE_TET
    {
        get
        {
            return CNull.RowNVLDecimal(pm_objDR, "LAM_THEM_LE_TET", IPConstants.c_DefaultDecimal);
        }
        set
        {
            pm_objDR["LAM_THEM_LE_TET"] = value;
        }
    }

    public bool IsLAM_THEM_LE_TETNull()
    {
        return pm_objDR.IsNull("LAM_THEM_LE_TET");
    }

    public void SetLAM_THEM_LE_TETNull()
    {
        pm_objDR["LAM_THEM_LE_TET"] = System.Convert.DBNull;
    }

    public decimal dcLUONG_KHAC_THUE_5
    {
        get
        {
            return CNull.RowNVLDecimal(pm_objDR, "LUONG_KHAC_THUE_5", IPConstants.c_DefaultDecimal);
        }
        set
        {
            pm_objDR["LUONG_KHAC_THUE_5"] = value;
        }
    }

    public bool IsLUONG_KHAC_THUE_5Null()
    {
        return pm_objDR.IsNull("LUONG_KHAC_THUE_5");
    }

    public void SetLUONG_KHAC_THUE_5Null()
    {
        pm_objDR["LUONG_KHAC_THUE_5"] = System.Convert.DBNull;
    }

    public decimal dcLUONG_KHAC_THUE_10
    {
        get
        {
            return CNull.RowNVLDecimal(pm_objDR, "LUONG_KHAC_THUE_10", IPConstants.c_DefaultDecimal);
        }
        set
        {
            pm_objDR["LUONG_KHAC_THUE_10"] = value;
        }
    }

    public bool IsLUONG_KHAC_THUE_10Null()
    {
        return pm_objDR.IsNull("LUONG_KHAC_THUE_10");
    }

    public void SetLUONG_KHAC_THUE_10Null()
    {
        pm_objDR["LUONG_KHAC_THUE_10"] = System.Convert.DBNull;
    }

    public decimal dcLUONG_KHAC_THUE_TINH_THEO_LUONG
    {
        get
        {
            return CNull.RowNVLDecimal(pm_objDR, "LUONG_KHAC_THUE_TINH_THEO_LUONG", IPConstants.c_DefaultDecimal);
        }
        set
        {
            pm_objDR["LUONG_KHAC_THUE_TINH_THEO_LUONG"] = value;
        }
    }

    public bool IsLUONG_KHAC_THUE_TINH_THEO_LUONGNull()
    {
        return pm_objDR.IsNull("LUONG_KHAC_THUE_TINH_THEO_LUONG");
    }

    public void SetLUONG_KHAC_THUE_TINH_THEO_LUONGNull()
    {
        pm_objDR["LUONG_KHAC_THUE_TINH_THEO_LUONG"] = System.Convert.DBNull;
    }

    public decimal dcTHU_NHAP
    {
        get
        {
            return CNull.RowNVLDecimal(pm_objDR, "THU_NHAP", IPConstants.c_DefaultDecimal);
        }
        set
        {
            pm_objDR["THU_NHAP"] = value;
        }
    }

    public bool IsTHU_NHAPNull()
    {
        return pm_objDR.IsNull("THU_NHAP");
    }

    public void SetTHU_NHAPNull()
    {
        pm_objDR["THU_NHAP"] = System.Convert.DBNull;
    }

    public decimal dcBHXH
    {
        get
        {
            return CNull.RowNVLDecimal(pm_objDR, "BHXH", IPConstants.c_DefaultDecimal);
        }
        set
        {
            pm_objDR["BHXH"] = value;
        }
    }

    public bool IsBHXHNull()
    {
        return pm_objDR.IsNull("BHXH");
    }

    public void SetBHXHNull()
    {
        pm_objDR["BHXH"] = System.Convert.DBNull;
    }

    public decimal dcBHYT
    {
        get
        {
            return CNull.RowNVLDecimal(pm_objDR, "BHYT", IPConstants.c_DefaultDecimal);
        }
        set
        {
            pm_objDR["BHYT"] = value;
        }
    }

    public bool IsBHYTNull()
    {
        return pm_objDR.IsNull("BHYT");
    }

    public void SetBHYTNull()
    {
        pm_objDR["BHYT"] = System.Convert.DBNull;
    }

    public decimal dcBHTN
    {
        get
        {
            return CNull.RowNVLDecimal(pm_objDR, "BHTN", IPConstants.c_DefaultDecimal);
        }
        set
        {
            pm_objDR["BHTN"] = value;
        }
    }

    public bool IsBHTNNull()
    {
        return pm_objDR.IsNull("BHTN");
    }

    public void SetBHTNNull()
    {
        pm_objDR["BHTN"] = System.Convert.DBNull;
    }

    public decimal dcDOAN_PHI_CD
    {
        get
        {
            return CNull.RowNVLDecimal(pm_objDR, "DOAN_PHI_CD", IPConstants.c_DefaultDecimal);
        }
        set
        {
            pm_objDR["DOAN_PHI_CD"] = value;
        }
    }

    public bool IsDOAN_PHI_CDNull()
    {
        return pm_objDR.IsNull("DOAN_PHI_CD");
    }

    public void SetDOAN_PHI_CDNull()
    {
        pm_objDR["DOAN_PHI_CD"] = System.Convert.DBNull;
    }

    public decimal dcTHUE
    {
        get
        {
            return CNull.RowNVLDecimal(pm_objDR, "THUE", IPConstants.c_DefaultDecimal);
        }
        set
        {
            pm_objDR["THUE"] = value;
        }
    }

    public bool IsTHUENull()
    {
        return pm_objDR.IsNull("THUE");
    }

    public void SetTHUENull()
    {
        pm_objDR["THUE"] = System.Convert.DBNull;
    }

    public decimal dcTHUE_TU_LUONG_KHAC_5
    {
        get
        {
            return CNull.RowNVLDecimal(pm_objDR, "THUE_TU_LUONG_KHAC_5", IPConstants.c_DefaultDecimal);
        }
        set
        {
            pm_objDR["THUE_TU_LUONG_KHAC_5"] = value;
        }
    }

    public bool IsTHUE_TU_LUONG_KHAC_5Null()
    {
        return pm_objDR.IsNull("THUE_TU_LUONG_KHAC_5");
    }

    public void SetTHUE_TU_LUONG_KHAC_5Null()
    {
        pm_objDR["THUE_TU_LUONG_KHAC_5"] = System.Convert.DBNull;
    }

    public decimal dcTHUE_TU_LUONG_KHAC_10
    {
        get
        {
            return CNull.RowNVLDecimal(pm_objDR, "THUE_TU_LUONG_KHAC_10", IPConstants.c_DefaultDecimal);
        }
        set
        {
            pm_objDR["THUE_TU_LUONG_KHAC_10"] = value;
        }
    }

    public bool IsTHUE_TU_LUONG_KHAC_10Null()
    {
        return pm_objDR.IsNull("THUE_TU_LUONG_KHAC_10");
    }

    public void SetTHUE_TU_LUONG_KHAC_10Null()
    {
        pm_objDR["THUE_TU_LUONG_KHAC_10"] = System.Convert.DBNull;
    }

    public decimal dcPHAI_NOP
    {
        get
        {
            return CNull.RowNVLDecimal(pm_objDR, "PHAI_NOP", IPConstants.c_DefaultDecimal);
        }
        set
        {
            pm_objDR["PHAI_NOP"] = value;
        }
    }

    public bool IsPHAI_NOPNull()
    {
        return pm_objDR.IsNull("PHAI_NOP");
    }

    public void SetPHAI_NOPNull()
    {
        pm_objDR["PHAI_NOP"] = System.Convert.DBNull;
    }

    public decimal dcTHUC_LINH
    {
        get
        {
            return CNull.RowNVLDecimal(pm_objDR, "THUC_LINH", IPConstants.c_DefaultDecimal);
        }
        set
        {
            pm_objDR["THUC_LINH"] = value;
        }
    }

    public bool IsTHUC_LINHNull()
    {
        return pm_objDR.IsNull("THUC_LINH");
    }

    public void SetTHUC_LINHNull()
    {
        pm_objDR["THUC_LINH"] = System.Convert.DBNull;
    }

    public decimal dcTRUY_LINH
    {
        get
        {
            return CNull.RowNVLDecimal(pm_objDR, "TRUY_LINH", IPConstants.c_DefaultDecimal);
        }
        set
        {
            pm_objDR["TRUY_LINH"] = value;
        }
    }

    public bool IsTRUY_LINHNull()
    {
        return pm_objDR.IsNull("TRUY_LINH");
    }

    public void SetTRUY_LINHNull()
    {
        pm_objDR["TRUY_LINH"] = System.Convert.DBNull;
    }

    public decimal dcTRUY_THU
    {
        get
        {
            return CNull.RowNVLDecimal(pm_objDR, "TRUY_THU", IPConstants.c_DefaultDecimal);
        }
        set
        {
            pm_objDR["TRUY_THU"] = value;
        }
    }

    public bool IsTRUY_THUNull()
    {
        return pm_objDR.IsNull("TRUY_THU");
    }

    public void SetTRUY_THUNull()
    {
        pm_objDR["TRUY_THU"] = System.Convert.DBNull;
    }

    public decimal dcTHUC_LINH_CUOI_CUNG
    {
        get
        {
            return CNull.RowNVLDecimal(pm_objDR, "THUC_LINH_CUOI_CUNG", IPConstants.c_DefaultDecimal);
        }
        set
        {
            pm_objDR["THUC_LINH_CUOI_CUNG"] = value;
        }
    }

    public bool IsTHUC_LINH_CUOI_CUNGNull()
    {
        return pm_objDR.IsNull("THUC_LINH_CUOI_CUNG");
    }

    public void SetTHUC_LINH_CUOI_CUNGNull()
    {
        pm_objDR["THUC_LINH_CUOI_CUNG"] = System.Convert.DBNull;
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

    public bool IsSO_NGAY_LAM_THEMNull()
    {
        return pm_objDR.IsNull("SO_NGAY_LAM_THEM");
    }

    public void SetSO_NGAY_LAM_THEMNull()
    {
        pm_objDR["SO_NGAY_LAM_THEM"] = System.Convert.DBNull;
    }

    #endregion
#region "Init Functions"
	public US_RPT_LUONG() 
	{
		pm_objDS = new DS_RPT_LUONG();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_RPT_LUONG(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_RPT_LUONG(decimal i_dbID) 
	{
		pm_objDS = new DS_RPT_LUONG();
		pm_strTableName = c_TableName;
		IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
		v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
		SqlCommand v_cmdSQL;
		v_cmdSQL = v_objMkCmd.getSelectCmd();
		this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
		pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
	}
#endregion

    public void FillBangLuong(DataSet ip_ds, decimal ip_dc_id_nhan_vien, decimal ip_dc_thang, decimal ip_dc_nam)
    {
        CStoredProc v_cstore = new CStoredProc("pr_old_rpt_bang_luong");
        v_cstore.addDecimalInputParam("@ID_NHAN_VIEN", ip_dc_id_nhan_vien);
        v_cstore.addDecimalInputParam("@THANG", ip_dc_thang);
        v_cstore.addDecimalInputParam("@NAM", ip_dc_nam);
        v_cstore.fillDataSetByCommand(this, ip_ds);
    }


    public void HienThiBangLuong(DataSet ip_ds, decimal ip_dc_thang, decimal ip_dc_nam)
    {
        CStoredProc v_cstore = new CStoredProc("pr_old_rpt_bang_luong_SelectAll");
        v_cstore.addDecimalInputParam("@ip_dc_thang", ip_dc_thang);
        v_cstore.addDecimalInputParam("@ip_dc_nam", ip_dc_nam);
        v_cstore.fillDataSetByCommand(this, ip_ds);
    }







    public void XoaLuong(decimal ip_thang, decimal ip_nam)
    {
        CStoredProc v_sp = new CStoredProc("pr_xoa_bang_luong_theo_thang");
        v_sp.addDecimalInputParam("@ip_thang", ip_thang);
        v_sp.addDecimalInputParam("@ip_nam", ip_nam);
        v_sp.ExecuteCommand(this);
    }
    public void XoaBanGhiLuong(decimal ip_dc_id_nhan_vien, decimal ip_thang, decimal ip_nam)
    {
        CStoredProc v_sp = new CStoredProc("pr_xoa_ban_ghi_luong");
        v_sp.addDecimalInputParam("@ip_dc_id_nhan_vien", ip_dc_id_nhan_vien);
        v_sp.addDecimalInputParam("@ip_thang", ip_thang);
        v_sp.addDecimalInputParam("@ip_nam", ip_nam);
        v_sp.ExecuteCommand(this);
    }
    public void Get_tat_ca_nhan_vien_can_tinh_luong(out DS_RPT_LUONG op_ds, decimal ip_thang, decimal ip_nam)
    {
        op_ds = new DS_RPT_LUONG();
        op_ds.EnforceConstraints = false;
        CStoredProc v_sp = new CStoredProc("pr_GET_DANH_SACH_NHAN_VIEN_TINH_LUONG");
        v_sp.addDecimalInputParam("@THANG", ip_thang);
        v_sp.addDecimalInputParam("@NAM", ip_nam);
        v_sp.fillDataSetByCommand(this, op_ds);
    }
    public void Get_tat_ca_nhan_vien_can_tinh_luong_thao_tac_lai(out DS_RPT_LUONG op_ds, decimal ip_thang, decimal ip_nam)
    {
        op_ds = new DS_RPT_LUONG();
        op_ds.EnforceConstraints = false;
        CStoredProc v_sp = new CStoredProc("pr_GET_DANH_SACH_NHAN_VIEN_TINH_LUONG_THAO_TAC_LAI");
        v_sp.addDecimalInputParam("@THANG", ip_thang);
        v_sp.addDecimalInputParam("@NAM", ip_nam);
        v_sp.fillDataSetByCommand(this, op_ds);
    }
    public void get_thong_tin_qua_trinh_tinh_luong(decimal ip_thang, decimal ip_nam, out decimal op_sl_nv_can_tinh_luong, out decimal op_sl_nv_da_tinh_luong)
    {
        op_sl_nv_can_tinh_luong = 0;
        op_sl_nv_da_tinh_luong = 0;

        CStoredProc v_sp = new CStoredProc("pr_get_thong_tin_qua_trinh_tinh_luong");
        v_sp.addDecimalInputParam("@ip_dat_thang", ip_thang);
        v_sp.addDecimalInputParam("@ip_dat_nam", ip_nam);

        SqlParameter v_para_all = v_sp.addDecimalOutputParam("@op_dc_so_luong_nv_tinh_luong", 0);
        SqlParameter v_para_da_tinh = v_sp.addDecimalOutputParam("@op_dc_so_luong_da_tinh_luong", 0);


        v_sp.ExecuteCommand(this);

        op_sl_nv_can_tinh_luong = CIPConvert.ToDecimal(v_para_all.Value);
        op_sl_nv_da_tinh_luong = CIPConvert.ToDecimal(v_para_da_tinh.Value);
    }
	}
}
