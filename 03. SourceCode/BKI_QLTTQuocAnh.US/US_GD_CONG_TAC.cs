///************************************************
/// Generated by: HungVQ
/// Date: 26/08/2015 10:30:38
/// Goal: Create User Service Class for GD_CONG_TAC
///************************************************
/// <summary>
/// Create User Service Class for GD_CONG_TAC
/// </summary>

using System;
using BKI_DichVuMatDat.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BKI_DichVuMatDat.US
{

    public class US_GD_CONG_TAC : US_Object
    {
        private const string c_TableName = "GD_CONG_TAC";
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

        public bool IsID_QUYET_DINHNull()
        {
            return pm_objDR.IsNull("ID_QUYET_DINH");
        }

        public void SetID_QUYET_DINHNull()
        {
            pm_objDR["ID_QUYET_DINH"] = System.Convert.DBNull;
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

        public bool IsID_DON_VINull()
        {
            return pm_objDR.IsNull("ID_DON_VI");
        }

        public void SetID_DON_VINull()
        {
            pm_objDR["ID_DON_VI"] = System.Convert.DBNull;
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

        public decimal dcID_LOAI_CONG_TAC
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_LOAI_CONG_TAC", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_LOAI_CONG_TAC"] = value;
            }
        }

        public bool IsID_LOAI_CONG_TACNull()
        {
            return pm_objDR.IsNull("ID_LOAI_CONG_TAC");
        }

        public void SetID_LOAI_CONG_TACNull()
        {
            pm_objDR["ID_LOAI_CONG_TAC"] = System.Convert.DBNull;
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

        public bool IsID_VI_TRINull()
        {
            return pm_objDR.IsNull("ID_VI_TRI");
        }

        public void SetID_VI_TRINull()
        {
            pm_objDR["ID_VI_TRI"] = System.Convert.DBNull;
        }

        #endregion
        #region "Init Functions"
        public US_GD_CONG_TAC()
        {
            pm_objDS = new DS_GD_CONG_TAC();
            pm_strTableName = c_TableName;
            pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
        }

        public US_GD_CONG_TAC(DataRow i_objDR)
            : this()
        {
            this.DataRow2Me(i_objDR);
        }

        public US_GD_CONG_TAC(decimal i_dbID)
        {
            pm_objDS = new DS_GD_CONG_TAC();
            pm_strTableName = c_TableName;
            IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
            v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
            SqlCommand v_cmdSQL;
            v_cmdSQL = v_objMkCmd.getSelectCmd();
            this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
            pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
        }
        #endregion



        public void FillDatasetBaoCaoTangGiamLaoDong(DataSet op_ds, DateTime ip_dat_tu_ngay, DateTime ip_dat_den_ngay)
        {
            CStoredProc v_cstore = new CStoredProc("pr_rpt_tang_giam_lao_dong");
            v_cstore.addDatetimeInputParam("@ip_dat_tu_ngay", ip_dat_tu_ngay);
            v_cstore.addDatetimeInputParam("@ip_dat_den_ngay", ip_dat_den_ngay);
            v_cstore.fillDataSetByCommand(this, op_ds);
        }


        public void LayThongTinQuaTrinhCongTac(DataSet op_ds, decimal ip_dc_id_nhan_vien)
        {
            CStoredProc v_cstore = new CStoredProc("PR_SELECT_ALL_QUA_TRINH_CONG_TAC");
            v_cstore.addDecimalInputParam("@ip_dc_id_nhan_vien", ip_dc_id_nhan_vien);
            v_cstore.fillDataSetByCommand(this, op_ds);
        }
        public void LayThongTinQuaTrinhCongTac(DataSet op_ds, decimal ip_dc_id_nhan_vien, decimal ip_dc_id_loai_cong_tac)
        {
            CStoredProc v_cstore = new CStoredProc("PR_SELECT_QUA_TRINH_CONG_TAC_THEO_LOAI");
            v_cstore.addDecimalInputParam("@ip_dc_id_nhan_vien", ip_dc_id_nhan_vien);
            v_cstore.addDecimalInputParam("@ip_dc_id_loai_cong_tac", ip_dc_id_nhan_vien);
            v_cstore.fillDataSetByCommand(this, op_ds);
        }

        public void LayThongTinQuaTrinhCongTacTatCaNV(DataSet op_ds)
        {
            CStoredProc v_cstore = new CStoredProc("PR_SELECT_ALL_QUA_TRINH_CONG_TAC_TAT_CA_NV");

            v_cstore.fillDataSetByCommand(this, op_ds);
        }
    }
}
