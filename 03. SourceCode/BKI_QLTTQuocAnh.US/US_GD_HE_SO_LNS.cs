///************************************************
/// Generated by: huongtt
/// Date: 19/04/2016 11:10:00
/// Goal: Create User Service Class for GD_HE_SO_LNS
///************************************************
/// <summary>
/// Create User Service Class for GD_HE_SO_LNS
/// </summary>

using System;
using BKI_DichVuMatDat.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BKI_DichVuMatDat.US
{

    public class US_GD_HE_SO_LNS : US_Object
    {
        private const string c_TableName = "GD_HE_SO_LNS";
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

        public decimal dcID_HE_SO_LNS
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_HE_SO_LNS", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_HE_SO_LNS"] = value;
            }
        }

        public bool IsID_HE_SO_LNSNull()
        {
            return pm_objDR.IsNull("ID_HE_SO_LNS");
        }

        public void SetID_HE_SO_LNSNull()
        {
            pm_objDR["ID_HE_SO_LNS"] = System.Convert.DBNull;
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

        public bool IsHE_SONull()
        {
            return pm_objDR.IsNull("HE_SO");
        }

        public void SetHE_SONull()
        {
            pm_objDR["HE_SO"] = System.Convert.DBNull;
        }

        public string strLY_DO_CHINH_SUA
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "LY_DO_CHINH_SUA", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["LY_DO_CHINH_SUA"] = value;
            }
        }

        public bool IsLY_DO_CHINH_SUANull()
        {
            return pm_objDR.IsNull("LY_DO_CHINH_SUA");
        }

        public void SetLY_DO_CHINH_SUANull()
        {
            pm_objDR["LY_DO_CHINH_SUA"] = System.Convert.DBNull;
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

        public void SetGHI_CHUNull()
        {
            pm_objDR["GHI_CHU"] = System.Convert.DBNull;
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

        public void SetNGUOI_LAPNull()
        {
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

        public void SetNGUOI_SUANull()
        {
            pm_objDR["NGUOI_SUA"] = System.Convert.DBNull;
        }

        #endregion
        #region "Init Functions"
        public US_GD_HE_SO_LNS()
        {
            pm_objDS = new DS_GD_HE_SO_LNS();
            pm_strTableName = c_TableName;
            pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
        }

        public US_GD_HE_SO_LNS(DataRow i_objDR) : this()
        {
            this.DataRow2Me(i_objDR);
        }

        public US_GD_HE_SO_LNS(decimal i_dbID)
        {
            pm_objDS = new DS_GD_HE_SO_LNS();
            pm_strTableName = c_TableName;
            IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
            v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
            SqlCommand v_cmdSQL;
            v_cmdSQL = v_objMkCmd.getSelectCmd();
            this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
            pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
        }
        #endregion
        public bool KiemTraThoiGianHeSoLNSHopLeForInsert(decimal ip_dc_id_nhan_vien, DateTime ip_dat_tu_ngay, DateTime ip_dat_den_ngay)
        {
            CStoredProc v_cstore = new CStoredProc("pr_HD_du_lieu_hs_lns_hop_le_CheckInsert");
            v_cstore.addDecimalInputParam("@ip_dc_id_nhan_vien", ip_dc_id_nhan_vien);
            v_cstore.addDatetimeInputParam("@ip_dat_tu_ngay", ip_dat_tu_ngay);
            v_cstore.addDatetimeInputParam("@ip_dat_den_ngay", ip_dat_den_ngay);

            SqlParameter v_yn = v_cstore.addNVarcharOutputParam("@op_str_hop_le_yn", "");
            v_cstore.ExecuteCommand(this);

            return v_yn.Value.ToString() == "Y" ? true : false;
        }
        public void KetThucLuongNangSuatNhanVien(decimal ip_dc_id_nhan_vien, DateTime ip_dat_ngay_ket_thuc)
        {
            CStoredProc v_cs = new CStoredProc("pr_HD_cap_nhat_ngay_ket_thuc_luong_nang_suat");
            v_cs.addDecimalInputParam("@ip_dc_id_nhan_vien", ip_dc_id_nhan_vien);
            v_cs.addDatetimeInputParam("@ip_dat_ngay_ket_thuc", ip_dat_ngay_ket_thuc);
            v_cs.ExecuteCommand(this);
        }
        public DataTable LayDanhSachHopDongThayDoiHeSoLNS(DateTime ip_dat_tu_ngay, DateTime ip_dat_den_ngay)
        {
            CStoredProc v_cs = new CStoredProc("pr_HD_hop_dong_thay_doi_he_so_lns_GetAll");
            v_cs.addDatetimeInputParam("@ip_dat_tu_ngay", ip_dat_tu_ngay);
            v_cs.addDatetimeInputParam("@ip_dat_den_ngay", ip_dat_den_ngay);
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add();
            v_cs.fillDataSetByCommand(this, v_ds);

            return v_ds.Tables[0];
        }

        public DataTable GetLNSTheoHopDong(decimal ip_id_hop_dong)
        {
            CStoredProc v_cstore = new CStoredProc("pr_LNS_get_theo_hop_dong");
            v_cstore.addDecimalInputParam("@ip_id_hop_dong", ip_id_hop_dong);
            DS_GD_HE_SO_LNS v_ds = new DS_GD_HE_SO_LNS();
            v_cstore.fillDataSetByCommand(this, v_ds);
            return v_ds.Tables[0];
        }

        public DataSet LayDanhSachHetHanLNSTrongThang()
        {
            CStoredProc v_cstore = new CStoredProc("pr_LNS_het_han_trong_thang");
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_cstore.fillDataSetByCommand(this, v_ds);
            return v_ds;
        }

        public bool KiemTraThoiGianHeSoLNSForInsert(decimal ip_dc_id_nhan_vien, DateTime ip_dat_tu_ngay, DateTime ip_dat_den_ngay)
        {
            CStoredProc v_cstore = new CStoredProc("pr_LNS_kiem_tra_thoi_gian_he_so_lns_hop_le_for_insert");
            v_cstore.addDecimalInputParam("@ip_dc_id_nhan_vien", ip_dc_id_nhan_vien);
            v_cstore.addDatetimeInputParam("@ip_dat_tu_ngay", ip_dat_tu_ngay);
            v_cstore.addDatetimeInputParam("@ip_dat_den_ngay", ip_dat_den_ngay);

            SqlParameter v_yn = v_cstore.addNVarcharOutputParam("@op_str_hop_le_yn", "");
            v_cstore.ExecuteCommand(this);

            return v_yn.Value.ToString() == "Y" ? true : false;
        }
        public bool KiemTraThoiGianHeSoLNSForUpdate(decimal ip_dc_id_gd_he_so_lns, DateTime ip_dat_tu_ngay, DateTime ip_dat_den_ngay)
        {
            CStoredProc v_cstore = new CStoredProc("pr_LNS_kiem_tra_thoi_gian_he_so_lns_hop_le_for_update");
            v_cstore.addDecimalInputParam("@ip_dc_id_gd_he_so_lns", ip_dc_id_gd_he_so_lns);
            v_cstore.addDatetimeInputParam("@ip_dat_tu_ngay", ip_dat_tu_ngay);
            v_cstore.addDatetimeInputParam("@ip_dat_den_ngay", ip_dat_den_ngay);

            SqlParameter v_yn = v_cstore.addNVarcharOutputParam("@op_str_hop_le_yn", "");
            v_cstore.ExecuteCommand(this);

            return v_yn.Value.ToString() == "Y" ? true : false;
        }
        public DataTable LayDanhSachHeSoLNS(string ip_str_filter, decimal ip_dc_thang, decimal ip_dc_nam)
        {
            CStoredProc v_cstore = new CStoredProc("pr_LNS_danh_sach_he_so_lns_GetAll");
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_cstore.addNVarcharInputParam("@ip_str_option", ip_str_filter);
            v_cstore.addDecimalInputParam("@thang", ip_dc_thang);
            v_cstore.addDecimalInputParam("@nam", ip_dc_nam);
            v_cstore.fillDataSetByCommand(this, v_ds);
            return v_ds.Tables[0];
        }

        public DataTable LayDanhSachNhanVienChuaCoLNS()
        {
            CStoredProc v_cstore = new CStoredProc("pr_LNS_danh_sach_nhan_vien_khong_co_lns_GetAll");
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_cstore.fillDataSetByCommand(this, v_ds);
            return v_ds.Tables[0];
        }
    }
}
