///************************************************
/// Generated by: haihd
/// Date: 08-01-2016 11:53:08
/// Goal: Create User Service Class for RPT_LUONG_V2
///************************************************
/// <summary>
/// Create User Service Class for RPT_LUONG_V2
/// </summary>

using System;
using BKI_DichVuMatDat.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BKI_DichVuMatDat.US
{

    public class US_RPT_LUONG_V2 : US_Object
    {
        private const string c_TableName = "RPT_LUONG_V2";
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

        public decimal dcLAM_THEM_200
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "LAM_THEM_200", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["LAM_THEM_200"] = value;
            }
        }

        public bool IsLAM_THEM_200Null()
        {
            return pm_objDR.IsNull("LAM_THEM_200");
        }

        public void SetLAM_THEM_200Null()
        {
            pm_objDR["LAM_THEM_200"] = System.Convert.DBNull;
        }

        public decimal dcLAM_THEM_300
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "LAM_THEM_300", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["LAM_THEM_300"] = value;
            }
        }

        public bool IsLAM_THEM_300Null()
        {
            return pm_objDR.IsNull("LAM_THEM_300");
        }

        public void SetLAM_THEM_300Null()
        {
            pm_objDR["LAM_THEM_300"] = System.Convert.DBNull;
        }

        public decimal dcTHU_NHAP_KHAC_TRONG_LUONG
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "THU_NHAP_KHAC_TRONG_LUONG", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["THU_NHAP_KHAC_TRONG_LUONG"] = value;
            }
        }

        public bool IsTHU_NHAP_KHAC_TRONG_LUONGNull()
        {
            return pm_objDR.IsNull("THU_NHAP_KHAC_TRONG_LUONG");
        }

        public void SetTHU_NHAP_KHAC_TRONG_LUONGNull()
        {
            pm_objDR["THU_NHAP_KHAC_TRONG_LUONG"] = System.Convert.DBNull;
        }

        public decimal dcTONG_THU_NHAP_TRONG_LUONG
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "TONG_THU_NHAP_TRONG_LUONG", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["TONG_THU_NHAP_TRONG_LUONG"] = value;
            }
        }

        public bool IsTONG_THU_NHAP_TRONG_LUONGNull()
        {
            return pm_objDR.IsNull("TONG_THU_NHAP_TRONG_LUONG");
        }

        public void SetTONG_THU_NHAP_TRONG_LUONGNull()
        {
            pm_objDR["TONG_THU_NHAP_TRONG_LUONG"] = System.Convert.DBNull;
        }

        public decimal dcTHUONG
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "THUONG", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["THUONG"] = value;
            }
        }

        public bool IsTHUONGNull()
        {
            return pm_objDR.IsNull("THUONG");
        }

        public void SetTHUONGNull()
        {
            pm_objDR["THUONG"] = System.Convert.DBNull;
        }

        public decimal dcTHUONG_ATHK
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "THUONG_ATHK", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["THUONG_ATHK"] = value;
            }
        }

        public bool IsTHUONG_ATHKNull()
        {
            return pm_objDR.IsNull("THUONG_ATHK");
        }

        public void SetTHUONG_ATHKNull()
        {
            pm_objDR["THUONG_ATHK"] = System.Convert.DBNull;
        }

        public decimal dcTHUONG_LE_TET
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "THUONG_LE_TET", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["THUONG_LE_TET"] = value;
            }
        }

        public bool IsTHUONG_LE_TETNull()
        {
            return pm_objDR.IsNull("THUONG_LE_TET");
        }

        public void SetTHUONG_LE_TETNull()
        {
            pm_objDR["THUONG_LE_TET"] = System.Convert.DBNull;
        }

        public decimal dcBO_SUNG_LUONG
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "BO_SUNG_LUONG", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["BO_SUNG_LUONG"] = value;
            }
        }

        public bool IsBO_SUNG_LUONGNull()
        {
            return pm_objDR.IsNull("BO_SUNG_LUONG");
        }

        public void SetBO_SUNG_LUONGNull()
        {
            pm_objDR["BO_SUNG_LUONG"] = System.Convert.DBNull;
        }

        public decimal dcTHU_NHAP_KHAC_NGOAI_LUONG
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "THU_NHAP_KHAC_NGOAI_LUONG", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["THU_NHAP_KHAC_NGOAI_LUONG"] = value;
            }
        }

        public bool IsTHU_NHAP_KHAC_NGOAI_LUONGNull()
        {
            return pm_objDR.IsNull("THU_NHAP_KHAC_NGOAI_LUONG");
        }

        public void SetTHU_NHAP_KHAC_NGOAI_LUONGNull()
        {
            pm_objDR["THU_NHAP_KHAC_NGOAI_LUONG"] = System.Convert.DBNull;
        }

        public decimal dcTONG_THU_NHAP_NGOAI_LUONG
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "TONG_THU_NHAP_NGOAI_LUONG", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["TONG_THU_NHAP_NGOAI_LUONG"] = value;
            }
        }

        public bool IsTONG_THU_NHAP_NGOAI_LUONGNull()
        {
            return pm_objDR.IsNull("TONG_THU_NHAP_NGOAI_LUONG");
        }

        public void SetTONG_THU_NHAP_NGOAI_LUONGNull()
        {
            pm_objDR["TONG_THU_NHAP_NGOAI_LUONG"] = System.Convert.DBNull;
        }

        public decimal dcTONG_THU_NHAP
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "TONG_THU_NHAP", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["TONG_THU_NHAP"] = value;
            }
        }

        public bool IsTONG_THU_NHAPNull()
        {
            return pm_objDR.IsNull("TONG_THU_NHAP");
        }

        public void SetTONG_THU_NHAPNull()
        {
            pm_objDR["TONG_THU_NHAP"] = System.Convert.DBNull;
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

        public decimal dcGIAM_TRU_LAM_THEM_150
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "GIAM_TRU_LAM_THEM_150", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["GIAM_TRU_LAM_THEM_150"] = value;
            }
        }

        public bool IsGIAM_TRU_LAM_THEM_150Null()
        {
            return pm_objDR.IsNull("GIAM_TRU_LAM_THEM_150");
        }

        public void SetGIAM_TRU_LAM_THEM_150Null()
        {
            pm_objDR["GIAM_TRU_LAM_THEM_150"] = System.Convert.DBNull;
        }

        public decimal dcGIAM_TRU_LAM_THEM_200
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "GIAM_TRU_LAM_THEM_200", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["GIAM_TRU_LAM_THEM_200"] = value;
            }
        }

        public bool IsGIAM_TRU_LAM_THEM_200Null()
        {
            return pm_objDR.IsNull("GIAM_TRU_LAM_THEM_200");
        }

        public void SetGIAM_TRU_LAM_THEM_200Null()
        {
            pm_objDR["GIAM_TRU_LAM_THEM_200"] = System.Convert.DBNull;
        }

        public decimal dcGIAM_TRU_LAM_THEM_300
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "GIAM_TRU_LAM_THEM_300", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["GIAM_TRU_LAM_THEM_300"] = value;
            }
        }

        public bool IsGIAM_TRU_LAM_THEM_300Null()
        {
            return pm_objDR.IsNull("GIAM_TRU_LAM_THEM_300");
        }

        public void SetGIAM_TRU_LAM_THEM_300Null()
        {
            pm_objDR["GIAM_TRU_LAM_THEM_300"] = System.Convert.DBNull;
        }

        public decimal dcGIAM_TRU_GIA_CANH
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "GIAM_TRU_GIA_CANH", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["GIAM_TRU_GIA_CANH"] = value;
            }
        }

        public bool IsGIAM_TRU_GIA_CANHNull()
        {
            return pm_objDR.IsNull("GIAM_TRU_GIA_CANH");
        }

        public void SetGIAM_TRU_GIA_CANHNull()
        {
            pm_objDR["GIAM_TRU_GIA_CANH"] = System.Convert.DBNull;
        }

        public decimal dcGIAM_TRU_PHU_THUOC
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "GIAM_TRU_PHU_THUOC", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["GIAM_TRU_PHU_THUOC"] = value;
            }
        }

        public bool IsGIAM_TRU_PHU_THUOCNull()
        {
            return pm_objDR.IsNull("GIAM_TRU_PHU_THUOC");
        }

        public void SetGIAM_TRU_PHU_THUOCNull()
        {
            pm_objDR["GIAM_TRU_PHU_THUOC"] = System.Convert.DBNull;
        }

        public decimal dcGIAM_TRU_KHAC
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "GIAM_TRU_KHAC", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["GIAM_TRU_KHAC"] = value;
            }
        }

        public bool IsGIAM_TRU_KHACNull()
        {
            return pm_objDR.IsNull("GIAM_TRU_KHAC");
        }

        public void SetGIAM_TRU_KHACNull()
        {
            pm_objDR["GIAM_TRU_KHAC"] = System.Convert.DBNull;
        }

        public decimal dcTONG_GIAM_TRU
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "TONG_GIAM_TRU", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["TONG_GIAM_TRU"] = value;
            }
        }

        public bool IsTONG_GIAM_TRUNull()
        {
            return pm_objDR.IsNull("TONG_GIAM_TRU");
        }

        public void SetTONG_GIAM_TRUNull()
        {
            pm_objDR["TONG_GIAM_TRU"] = System.Convert.DBNull;
        }

        public decimal dcTHU_NHAP_CHIU_THUE
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "THU_NHAP_CHIU_THUE", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["THU_NHAP_CHIU_THUE"] = value;
            }
        }

        public bool IsTHU_NHAP_CHIU_THUENull()
        {
            return pm_objDR.IsNull("THU_NHAP_CHIU_THUE");
        }

        public void SetTHU_NHAP_CHIU_THUENull()
        {
            pm_objDR["THU_NHAP_CHIU_THUE"] = System.Convert.DBNull;
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

        public decimal dcPHAI_NOP_KHAC
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "PHAI_NOP_KHAC", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["PHAI_NOP_KHAC"] = value;
            }
        }

        public bool IsPHAI_NOP_KHACNull()
        {
            return pm_objDR.IsNull("PHAI_NOP_KHAC");
        }

        public void SetPHAI_NOP_KHACNull()
        {
            pm_objDR["PHAI_NOP_KHAC"] = System.Convert.DBNull;
        }

        public decimal dcTONG_PHAI_NOP
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "TONG_PHAI_NOP", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["TONG_PHAI_NOP"] = value;
            }
        }

        public bool IsTONG_PHAI_NOPNull()
        {
            return pm_objDR.IsNull("TONG_PHAI_NOP");
        }

        public void SetTONG_PHAI_NOPNull()
        {
            pm_objDR["TONG_PHAI_NOP"] = System.Convert.DBNull;
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

        public decimal dcSO_TIEN_DA_NOP_THUE
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "SO_TIEN_DA_NOP_THUE", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["SO_TIEN_DA_NOP_THUE"] = value;
            }
        }

        public bool IsSO_TIEN_DA_NOP_THUENull()
        {
            return pm_objDR.IsNull("SO_TIEN_DA_NOP_THUE");
        }

        public void SetSO_TIEN_DA_NOP_THUENull()
        {
            pm_objDR["SO_TIEN_DA_NOP_THUE"] = System.Convert.DBNull;
        }

        #endregion
        #region "Init Functions"
        public US_RPT_LUONG_V2()
        {
            pm_objDS = new DS_RPT_LUONG_V2();
            pm_strTableName = c_TableName;
            pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
        }

        public US_RPT_LUONG_V2(DataRow i_objDR)
            : this()
        {
            this.DataRow2Me(i_objDR);
        }

        public US_RPT_LUONG_V2(decimal i_dbID)
        {
            pm_objDS = new DS_RPT_LUONG_V2();
            pm_strTableName = c_TableName;
            IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
            v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
            SqlCommand v_cmdSQL;
            v_cmdSQL = v_objMkCmd.getSelectCmd();
            this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
            pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
        }
        #endregion

        #region Additional

        //Bang luong
        public void LayTrangThaiBangLuong(decimal ip_dc_thang
                                                   , decimal ip_dc_nam
                                                   , out decimal op_sl_nv_can_tinh_luong
                                                   , out decimal op_sl_nv_da_tinh_luong
                                                   , out bool op_bol_co_du_lieu_chua
                                                   , out bool op_bol_chot_bang_luong)
        {
            op_sl_nv_can_tinh_luong = 0;
            op_sl_nv_da_tinh_luong = 0;

            CStoredProc v_sp = new CStoredProc("pr_TL_trang_thai_bang_luong_Get");
            v_sp.addDecimalInputParam("@ip_i_thang", ip_dc_thang);
            v_sp.addDecimalInputParam("@ip_i_nam", ip_dc_nam);

            SqlParameter v_para_all = v_sp.addDecimalOutputParam("@op_i_tong_so_nhan_vien_can_tinh", 0);
            SqlParameter v_para_da_tinh = v_sp.addDecimalOutputParam("@op_i_so_luong_nhan_vien_da_tinh", 0);
            SqlParameter v_para_co_du_lieu_chua = v_sp.addNVarcharOutputParam("@op_str_co_du_lieu_chua", "");
            SqlParameter v_para_chot_bang_luong = v_sp.addNVarcharOutputParam("@op_str_chot_bang_luong", "");
            v_sp.ExecuteCommand(this);

            op_sl_nv_can_tinh_luong = CIPConvert.ToDecimal(v_para_all.Value);
            op_sl_nv_da_tinh_luong = CIPConvert.ToDecimal(v_para_da_tinh.Value);
            op_bol_co_du_lieu_chua = v_para_co_du_lieu_chua.Value.ToString() == "Y" ? true : false;
            op_bol_chot_bang_luong = v_para_chot_bang_luong.Value.ToString() == "Y" ? true : false;
        }
        public void TaoBangLuongNhanVien(DataSet ip_ds, decimal ip_dc_id_nhan_vien, decimal ip_dc_thang, decimal ip_dc_nam)
        {
            CStoredProc v_cstore = new CStoredProc("pr_TL_bang_luong_nhan_vien_Calculate");
            v_cstore.addDecimalInputParam("@ID_NHAN_VIEN", ip_dc_id_nhan_vien);
            v_cstore.addDecimalInputParam("@THANG", ip_dc_thang);
            v_cstore.addDecimalInputParam("@NAM", ip_dc_nam);
            v_cstore.fillDataSetByCommand(this, ip_ds);
        }

        public void XoaBangLuongNhanVien(decimal ip_dc_id_nhan_vien, decimal ip_thang, decimal ip_nam)//Chua xoa rpt_tong_hop
        {
            CStoredProc v_sp = new CStoredProc("pr_TL_bang_luong_Delete");
            v_sp.addDecimalInputParam("@ip_dc_id_nhan_vien", ip_dc_id_nhan_vien);
            v_sp.addDecimalInputParam("@ip_thang", ip_thang);
            v_sp.addDecimalInputParam("@ip_nam", ip_nam);
            v_sp.ExecuteCommand(this);
        }
        public void XoaToanBoBangLuong(decimal ip_thang, decimal ip_nam)
        {
            CStoredProc v_sp = new CStoredProc("pr_TL_bang_luong_DeleteAll");//Chua xoa rpt_tong_hop
            v_sp.addDecimalInputParam("@ip_thang", ip_thang);
            v_sp.addDecimalInputParam("@ip_nam", ip_nam);
            v_sp.ExecuteCommand(this);
        }

        public void LayToanBoNhanVienIDTinhLuong(out DataSet op_ds, decimal ip_thang, decimal ip_nam)
        {
            op_ds = new DataSet();
            op_ds.Tables.Add();
            op_ds.EnforceConstraints = false;
            CStoredProc v_sp = new CStoredProc("pr_TL_id_nhan_vien_tinh_luong_GetAll");
            v_sp.addDecimalInputParam("@THANG", ip_thang);
            v_sp.addDecimalInputParam("@NAM", ip_nam);
            v_sp.fillDataSetByCommand(this, op_ds);
        }
        public void LayDanhSachNhanVienIDChuaTinhLuong(out DataSet op_ds, decimal ip_thang, decimal ip_nam)
        {
            op_ds = new DataSet();
            op_ds.Tables.Add();
            op_ds.EnforceConstraints = false;
            CStoredProc v_sp = new CStoredProc("pr_TL_id_nhan_vien_chua_tinh_luong_Get");
            v_sp.addDecimalInputParam("@THANG", ip_thang);
            v_sp.addDecimalInputParam("@NAM", ip_nam);
            v_sp.fillDataSetByCommand(this, op_ds);
        }

        public void LayDanhSachMaNVDuocTinhLuong(out DataSet op_ds, decimal ip_thang, decimal ip_nam)
        {
            op_ds = new DataSet();
            op_ds.Tables.Add();
            op_ds.EnforceConstraints = false;
            CStoredProc v_sp = new CStoredProc("pr_TNK_ma_nv_tinh_luong_GetAll");
            v_sp.addDecimalInputParam("@THANG", ip_thang);
            v_sp.addDecimalInputParam("@NAM", ip_nam);
            v_sp.fillDataSetByCommand(this, op_ds);
        }
        

        //Quyet toan thue
        public void FillDatasetProcBangKeKhaiThuNhap(DataSet v_ds, DateTime ip_dat_tu_thang, DateTime ip_dat_den_thang)
        {
            CStoredProc v_cstore = new CStoredProc("pr_QTT_bang_ke_khai_thu_nhap_GetAll");
            v_cstore.addDatetimeInputParam("@ngay_bat_dau", ip_dat_tu_thang);
            v_cstore.addDatetimeInputParam("@ngay_ket_thuc", ip_dat_den_thang);
            v_cstore.fillDataSetByCommand(this, v_ds);
        }
        public void FillDatasetKeKhaiThueDoubleClick(DataSet v_ds, decimal v_id_nhan_vien, DateTime ip_dat_tu_thang, DateTime ip_dat_den_thang)
        {
            CStoredProc v_cstore = new CStoredProc("pr_QTT_bang_ke_khai_thu_nhap_detail_Get");
            v_cstore.addDatetimeInputParam("@ngay_bat_dau", ip_dat_tu_thang);
            v_cstore.addDatetimeInputParam("@ngay_ket_thuc", ip_dat_den_thang);
            v_cstore.addDecimalInputParam("@id_nhan_vien", v_id_nhan_vien);
            v_cstore.fillDataSetByCommand(this, v_ds);
        }
        public void FillDatasetProcBaoCaoThuNhapTheoNam(DataSet v_ds, string ip_str_nam)
        {
            CStoredProc v_cstore = new CStoredProc("pr_QTT_bao_cao_tong_hop_thu_nhap_theo_nam_GetAll");
            v_cstore.addDecimalInputParam("@nam", CIPConvert.ToDecimal(ip_str_nam));
            v_cstore.fillDataSetByCommand(this, v_ds);
        }
        public void FillDatasetBaoCaoThuNhapDoubleClick(DataSet v_ds, decimal v_id_nhan_vien, string m_txt_nam)
        {
            CStoredProc v_cstore = new CStoredProc("pr_QTT_bao_cao_tong_hop_thu_nhap_theo_nam_detail_Get");
            v_cstore.addDecimalInputParam("@nam", CIPConvert.ToDecimal(m_txt_nam));
            v_cstore.addDecimalInputParam("@id_nhan_vien", v_id_nhan_vien);
            v_cstore.fillDataSetByCommand(this, v_ds);
        }
        
        #endregion

       
    }
}
