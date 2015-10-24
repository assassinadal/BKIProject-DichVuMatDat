///************************************************
/// Generated by: tuyennt
/// Date: 22-10-2015 09:41:53
/// Goal: Create User Service Class for GD_TRANG_THAI_LAO_DONG
///************************************************
/// <summary>
/// Create User Service Class for GD_TRANG_THAI_LAO_DONG
/// </summary>

using System;
using BKI_DichVuMatDat.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BKI_DichVuMatDat.US
{

    public class US_GD_TRANG_THAI_LAO_DONG : US_Object
    {
        private const string c_TableName = "GD_TRANG_THAI_LAO_DONG";
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

        public bool IsID_TRANG_THAI_LAO_DONGNull()
        {
            return pm_objDR.IsNull("ID_TRANG_THAI_LAO_DONG");
        }

        public void SetID_TRANG_THAI_LAO_DONGNull()
        {
            pm_objDR["ID_TRANG_THAI_LAO_DONG"] = System.Convert.DBNull;
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

        public void SetNGUOI_LAPNull()
        {
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

        public void SetNGUOI_SUANull()
        {
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

        public void SetGHI_CHUNull()
        {
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

        public void SetDA_XOANull()
        {
            pm_objDR["DA_XOA"] = System.Convert.DBNull;
        }

        #endregion
        #region "Init Functions"
        public US_GD_TRANG_THAI_LAO_DONG()
        {
            pm_objDS = new DS_GD_TRANG_THAI_LAO_DONG();
            pm_strTableName = c_TableName;
            pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
        }

        public US_GD_TRANG_THAI_LAO_DONG(DataRow i_objDR)
            : this()
        {
            this.DataRow2Me(i_objDR);
        }

        public US_GD_TRANG_THAI_LAO_DONG(decimal i_dbID)
        {
            pm_objDS = new DS_GD_TRANG_THAI_LAO_DONG();
            pm_strTableName = c_TableName;
            IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
            v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
            SqlCommand v_cmdSQL;
            v_cmdSQL = v_objMkCmd.getSelectCmd();
            this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
            pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
        }
        #endregion


        public decimal get_id_trang_thai_lao_dong(decimal ip_dc_id_nhan_vien)
        {
            CStoredProc v_sp = new CStoredProc("pr_get_id_trang_thai_lao_dong_hien_tai");
            v_sp.addDecimalInputParam("@ip_dc_id_nhan_vien", ip_dc_id_nhan_vien);

            SqlParameter v_para = v_sp.addDecimalOutputParam("@op_dc_id_trang_thai_hien_tai", 0);
            v_sp.ExecuteCommand(this);

            return CIPConvert.ToDecimal(v_para.Value.ToString());
        }

        public void fill_data_lich_su_lao_dong(DS_GD_TRANG_THAI_LAO_DONG op_ds, decimal ip_dc_id_nhan_vien)
        {
            CStoredProc v_sp = new CStoredProc("pr_lay_danh_sach_lich_su_lao_dong");
            v_sp.addDecimalInputParam("@ip_dc_id_nhan_vien", ip_dc_id_nhan_vien);
            v_sp.fillDataSetByCommand(this, op_ds);
        }

        public void thay_doi_trang_thai_lao_dong(decimal ip_dc_id_nhan_vien
                                                        , decimal ip_dc_id_trang_thai_chuyen
                                                        , DateTime ip_dat_ngay_lap
                                                        , string ip_str_nguoi_lap)
        {
            CStoredProc v_sp = new CStoredProc("pr_thay_doi_trang_thai_lao_dong");
            v_sp.addDecimalInputParam("@ip_dc_id_nhan_vien", ip_dc_id_nhan_vien);
            v_sp.addDecimalInputParam("@ip_dc_id_trang_thai_chuyen", ip_dc_id_trang_thai_chuyen);
            v_sp.addDatetimeInputParam("@ip_dat_ngay_lap", ip_dat_ngay_lap);
            v_sp.addNVarcharInputParam("@ip_str_nguoi_lap", ip_str_nguoi_lap);

            v_sp.ExecuteCommand(this);
        }
    }
}
