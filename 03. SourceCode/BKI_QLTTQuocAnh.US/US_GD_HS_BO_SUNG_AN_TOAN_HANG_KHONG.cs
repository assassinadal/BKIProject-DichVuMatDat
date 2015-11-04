///************************************************
/// Generated by: THAIPH
/// Date: 14/10/2015 04:06:30
/// Goal: Create User Service Class for GD_HS_BO_SUNG_AN_TOAN_HANG_KHONG
///************************************************
/// <summary>
/// Create User Service Class for GD_HS_BO_SUNG_AN_TOAN_HANG_KHONG
/// </summary>

using System;
using BKI_DichVuMatDat.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BKI_DichVuMatDat.US
{

    public class US_GD_HS_BO_SUNG_AN_TOAN_HANG_KHONG : US_Object
    {
        private const string c_TableName = "GD_HS_BO_SUNG_AN_TOAN_HANG_KHONG";
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

        public string strTHANG
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "THANG", IPConstants.c_DefaultString);
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

        public string strNAM
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "NAM", IPConstants.c_DefaultString);
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

        public decimal dcHS_BO_SUNG
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "HS_BO_SUNG", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["HS_BO_SUNG"] = value;
            }
        }

        public bool IsHS_BO_SUNGNull()
        {
            return pm_objDR.IsNull("HS_BO_SUNG");
        }

        public void SetHS_BO_SUNGNull()
        {
            pm_objDR["HS_BO_SUNG"] = System.Convert.DBNull;
        }

        public decimal dcHS_ATHK
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "HS_ATHK", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["HS_ATHK"] = value;
            }
        }

        public bool IsHS_ATHKNull()
        {
            return pm_objDR.IsNull("HS_ATHK");
        }

        public void SetHS_ATHKNull()
        {
            pm_objDR["HS_ATHK"] = System.Convert.DBNull;
        }

        public string strNGUOI_CHOT
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "NGUOI_CHOT", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["NGUOI_CHOT"] = value;
            }
        }

        public bool IsNGUOI_CHOTNull()
        {
            return pm_objDR.IsNull("NGUOI_CHOT");
        }

        public void SetNGUOI_CHOTNull()
        {
            pm_objDR["NGUOI_CHOT"] = System.Convert.DBNull;
        }

        public DateTime datNGAY_CHOT
        {
            get
            {
                return CNull.RowNVLDate(pm_objDR, "NGAY_CHOT", IPConstants.c_DefaultDate);
            }
            set
            {
                pm_objDR["NGAY_CHOT"] = value;
            }
        }

        public bool IsNGAY_CHOTNull()
        {
            return pm_objDR.IsNull("NGAY_CHOT");
        }

        public void SetNGAY_CHOTNull()
        {
            pm_objDR["NGAY_CHOT"] = System.Convert.DBNull;
        }

        #endregion
        #region "Init Functions"
        public US_GD_HS_BO_SUNG_AN_TOAN_HANG_KHONG()
        {
            pm_objDS = new DS_GD_HS_BO_SUNG_AN_TOAN_HANG_KHONG();
            pm_strTableName = c_TableName;
            pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
        }

        public US_GD_HS_BO_SUNG_AN_TOAN_HANG_KHONG(DataRow i_objDR)
            : this()
        {
            this.DataRow2Me(i_objDR);
        }

        public US_GD_HS_BO_SUNG_AN_TOAN_HANG_KHONG(decimal i_dbID)
        {
            pm_objDS = new DS_GD_HS_BO_SUNG_AN_TOAN_HANG_KHONG();
            pm_strTableName = c_TableName;
            IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
            v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
            SqlCommand v_cmdSQL;
            v_cmdSQL = v_objMkCmd.getSelectCmd();
            this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
            pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
        }
        #endregion

        public void insert_data_by_proc(decimal ip_dc_thang, decimal ip_dc_nam)
        {
            //BeginTransaction();
            CStoredProc v_cstore = new CStoredProc("PR_GET_ALL_HS_BS_ATHK");

            v_cstore.addDecimalInputParam("@IP_THANG", ip_dc_thang);
            v_cstore.addDecimalInputParam("@IP_NAM", ip_dc_nam);
            v_cstore.ExecuteCommand(this);
            //CommitTransaction();
        }
        public void load_du_lieu_bang_luong_theo_hs_athk(DataSet op_ds
                                                                , DateTime ip_dat_tu_ngay
                                                                , DateTime ip_dat_den_ngay
                                                                 , decimal ip_dc_tong_tien
                                                                , string ip_yn_giam_tru
                                                                , int ip_int_thang_thuong
                                                                , int ip_int_nam_thuong)
        {
            CStoredProc v_cstore = new CStoredProc("pr_lay_du_lieu_bang_luong_by_hs_athk");

            v_cstore.addDatetimeInputParam("@ip_dat_tu_ngay", ip_dat_tu_ngay);
            v_cstore.addDatetimeInputParam("@ip_dat_den_ngay", ip_dat_den_ngay);
            v_cstore.addDecimalInputParam("@ip_dc_tong_so_tien", ip_dc_tong_tien);
            v_cstore.addNVarcharInputParam("@ip_yn_giam_tru", ip_yn_giam_tru);
            v_cstore.addDecimalInputParam("@ip_int_thang_tinh_thuong", ip_int_thang_thuong );
            v_cstore.addDecimalInputParam("@ip_int_nam_tinh_thuong", ip_int_nam_thuong);
            v_cstore.fillDataSetByCommand(this, op_ds);
        }

        public void load_du_lieu_bang_luong_theo_hs_bs(DataSet op_ds, decimal ip_dc_nam, decimal ip_dc_so_tien)
        {
            CStoredProc v_cstore = new CStoredProc("pr_lay_du_lieu_bang_luong_by_hs_bo_sung");

            v_cstore.addDecimalInputParam("@ip_dc_nam", ip_dc_nam);
            v_cstore.addDecimalInputParam("@ip_dc_so_tien", ip_dc_so_tien);

            v_cstore.fillDataSetByCommand(this, op_ds);
        }
    }
}
