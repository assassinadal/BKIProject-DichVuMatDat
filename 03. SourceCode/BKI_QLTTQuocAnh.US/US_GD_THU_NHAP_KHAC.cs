///************************************************
/// Generated by: huongtt
/// Date: 03/03/2016 04:23:46
/// Goal: Create User Service Class for GD_THU_NHAP_KHAC
///************************************************
/// <summary>
/// Create User Service Class for GD_THU_NHAP_KHAC
/// </summary>

using System;
using BKI_DichVuMatDat.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BKI_DichVuMatDat.US
{

    public class US_GD_THU_NHAP_KHAC : US_Object
    {
        private const string c_TableName = "GD_THU_NHAP_KHAC";
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

        public bool IsSO_TIENNull()
        {
            return pm_objDR.IsNull("SO_TIEN");
        }

        public void SetSO_TIENNull()
        {
            pm_objDR["SO_TIEN"] = System.Convert.DBNull;
        }

        public decimal dcSO_TIEN_NOP_THUE
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "SO_TIEN_NOP_THUE", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["SO_TIEN_NOP_THUE"] = value;
            }
        }

        public bool IsSO_TIEN_NOP_THUENull()
        {
            return pm_objDR.IsNull("SO_TIEN_NOP_THUE");
        }

        public void SetSO_TIEN_NOP_THUENull()
        {
            pm_objDR["SO_TIEN_NOP_THUE"] = System.Convert.DBNull;
        }

        public decimal dcSO_TIEN_THUC_LINH
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "SO_TIEN_THUC_LINH", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["SO_TIEN_THUC_LINH"] = value;
            }
        }

        public bool IsSO_TIEN_THUC_LINHNull()
        {
            return pm_objDR.IsNull("SO_TIEN_THUC_LINH");
        }

        public void SetSO_TIEN_THUC_LINHNull()
        {
            pm_objDR["SO_TIEN_THUC_LINH"] = System.Convert.DBNull;
        }

        public decimal dcID_LOAI_THU_NHAP_KHAC
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_LOAI_THU_NHAP_KHAC", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_LOAI_THU_NHAP_KHAC"] = value;
            }
        }

        public bool IsID_LOAI_THU_NHAP_KHACNull()
        {
            return pm_objDR.IsNull("ID_LOAI_THU_NHAP_KHAC");
        }

        public void SetID_LOAI_THU_NHAP_KHACNull()
        {
            pm_objDR["ID_LOAI_THU_NHAP_KHAC"] = System.Convert.DBNull;
        }

        public decimal dcID_QUY_THU_NHAP_KHAC
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_QUY_THU_NHAP_KHAC", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_QUY_THU_NHAP_KHAC"] = value;
            }
        }

        public bool IsID_QUY_THU_NHAP_KHACNull()
        {
            return pm_objDR.IsNull("ID_QUY_THU_NHAP_KHAC");
        }

        public void SetID_QUY_THU_NHAP_KHACNull()
        {
            pm_objDR["ID_QUY_THU_NHAP_KHAC"] = System.Convert.DBNull;
        }

        public string strLY_DO
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "LY_DO", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["LY_DO"] = value;
            }
        }

        public bool IsLY_DONull()
        {
            return pm_objDR.IsNull("LY_DO");
        }

        public void SetLY_DONull()
        {
            pm_objDR["LY_DO"] = System.Convert.DBNull;
        }

        #endregion
        #region "Init Functions"
        public US_GD_THU_NHAP_KHAC()
        {
            pm_objDS = new DS_GD_THU_NHAP_KHAC();
            pm_strTableName = c_TableName;
            pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
        }

        public US_GD_THU_NHAP_KHAC(DataRow i_objDR)
            : this()
        {
            this.DataRow2Me(i_objDR);
        }

        public US_GD_THU_NHAP_KHAC(decimal i_dbID)
        {
            pm_objDS = new DS_GD_THU_NHAP_KHAC();
            pm_strTableName = c_TableName;
            IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
            v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
            SqlCommand v_cmdSQL;
            v_cmdSQL = v_objMkCmd.getSelectCmd();
            this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
            pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
        }
        #endregion

        public void LayDuLieuThuNhapKhac(DataSet ip_ds, decimal ip_dc_id_quy_tien_thuong)
        {
            CStoredProc v_sp = new CStoredProc("PR_SELECT_ALL_THU_NHAP_KHAC");
            v_sp.addDecimalInputParam("@ip_dc_quy_tien_thuong", ip_dc_id_quy_tien_thuong);

            v_sp.fillDataSetByCommand(this, ip_ds);
        }
        public void filldatasetBaoCaoThuNhapLDNgoaiBangLuong(DataSet v_ds, string ip_str_thang, string ip_str_nam, string ip_str_id)
        {
            CStoredProc v_cstore = new CStoredProc("pr_TNK_thu_nhap_nhom_khac_GetAll");
            v_cstore.addNVarcharInputParam("@thang", CIPConvert.ToDecimal(ip_str_thang));
            v_cstore.addNVarcharInputParam("@nam", CIPConvert.ToDecimal(ip_str_nam));
            v_cstore.addDecimalInputParam("@id_nhom_ld", CIPConvert.ToDecimal(ip_str_id));
            v_cstore.fillDataSetByCommand(this, v_ds);
        }


        public void XoaDuLieuChiaThuongNhanVien(decimal ip_dc_id_quy_tien_thuong)
        {
            CStoredProc v_sp = new CStoredProc("pr_xoa_du_lieu_chia_thuong_nhan_vien");
            v_sp.addDecimalInputParam("@ip_dc_id_quy_tien_thuong", ip_dc_id_quy_tien_thuong);

            v_sp.ExecuteCommand(this);
        }
        public bool QuyThuongDaChiaNhanVienChua(decimal ip_dc_id_quy_tien_thuong)
        {
            CStoredProc v_sp = new CStoredProc("pr_quy_thuong_da_chia_nhan_vien_chua");
            v_sp.addDecimalInputParam("@ip_dc_id_quy_thuong", ip_dc_id_quy_tien_thuong);

            SqlParameter v_para = v_sp.addNVarcharOutputParam("@op_str_yn", "");
            v_sp.ExecuteCommand(this);

            return v_para.Value.ToString() == "Y" ? true : false;//Y la da chia thuog cho nhan vien, N la chua chia thuong
        }
        public void Get_tat_ca_nhan_vien_can_tinh_thuong(out DS_DM_NHAN_VIEN op_ds, decimal ip_dc_id_quy_tien_thuong)
        {
            op_ds = new DS_DM_NHAN_VIEN();
            op_ds.EnforceConstraints = false;
            CStoredProc v_sp = new CStoredProc("pr_lay_danh_sach_nhan_vien_chua_tinh_thuong");
            v_sp.addDecimalInputParam("@ip_dc_id_quy_tien_thuong", ip_dc_id_quy_tien_thuong);

            v_sp.fillDataSetByCommand(this, op_ds);
        }

        public void load_du_lieu_bang_luong_1nv_theo_hs_athk(DataSet op_ds
                                                                , DateTime ip_dat_tu_ngay
                                                                , DateTime ip_dat_den_ngay
                                                                 , decimal ip_dc_tong_tien
                                                                , string ip_yn_giam_tru
                                                                , int ip_int_thang_thuong
                                                                , int ip_int_nam_thuong
                                                                , decimal ip_dc_id_nhan_vien
                                                                , decimal ip_dc_id_cach_tinh_thue)
        {
            CStoredProc v_cstore = new CStoredProc("pr_lay_du_lieu_bang_luong_1nv_by_hs_athk");

            v_cstore.addDatetimeInputParam("@ip_dat_tu_ngay", ip_dat_tu_ngay);
            v_cstore.addDatetimeInputParam("@ip_dat_den_ngay", ip_dat_den_ngay);
            v_cstore.addDecimalInputParam("@ip_dc_tong_so_tien", ip_dc_tong_tien);
            v_cstore.addNVarcharInputParam("@ip_yn_giam_tru", ip_yn_giam_tru);
            v_cstore.addDecimalInputParam("@ip_int_thang_tinh_thuong", ip_int_thang_thuong);
            v_cstore.addDecimalInputParam("@ip_int_nam_tinh_thuong", ip_int_nam_thuong);
            v_cstore.addDecimalInputParam("@ip_dc_id_nhan_vien", ip_dc_id_nhan_vien);
            v_cstore.addDecimalInputParam("@ip_dc_id_cach_tinh_thue", ip_dc_id_cach_tinh_thue);
            v_cstore.fillDataSetByCommand(this, op_ds);
        }
        public void load_du_lieu_bang_luong_1nv_theo_hs_bs(DataSet op_ds
                                                                , DateTime ip_dat_tu_ngay
                                                                , DateTime ip_dat_den_ngay
                                                                 , decimal ip_dc_tong_tien
                                                                , string ip_yn_giam_tru
                                                                , int ip_int_thang_thuong
                                                                , int ip_int_nam_thuong
                                                                , decimal ip_dc_id_nhan_vien
                                                                , decimal ip_dc_id_cach_tinh_thue)
        {
            CStoredProc v_cstore = new CStoredProc("pr_lay_du_lieu_bang_luong_1nv_by_hs_bs");

            v_cstore.addDatetimeInputParam("@ip_dat_tu_ngay", ip_dat_tu_ngay);
            v_cstore.addDatetimeInputParam("@ip_dat_den_ngay", ip_dat_den_ngay);
            v_cstore.addDecimalInputParam("@ip_dc_tong_so_tien", ip_dc_tong_tien);
            v_cstore.addNVarcharInputParam("@ip_yn_giam_tru", ip_yn_giam_tru);
            v_cstore.addDecimalInputParam("@ip_int_thang_tinh_thuong", ip_int_thang_thuong);
            v_cstore.addDecimalInputParam("@ip_int_nam_tinh_thuong", ip_int_nam_thuong);
            v_cstore.addDecimalInputParam("@ip_dc_id_nhan_vien", ip_dc_id_nhan_vien);
            v_cstore.addDecimalInputParam("@ip_dc_id_cach_tinh_thue", ip_dc_id_cach_tinh_thue);
            v_cstore.fillDataSetByCommand(this, op_ds);
        }
        public bool KiemTraXemDaInsertThuong2014Chua(decimal ip_id_quy_tien, decimal ip_dc_id_nhan_vien)
        {
            CStoredProc v_sp = new CStoredProc("pr_check_before_insert_thuong_2k14");
            v_sp.addDecimalInputParam("@ip_dc_id_quy_tien", ip_id_quy_tien);
            v_sp.addDecimalInputParam("@ip_dc_id_nhan_vien", ip_dc_id_nhan_vien);
            SqlParameter v_yn = v_sp.addNVarcharOutputParam("@op_yn_insert", "");
            v_sp.ExecuteCommand(this);

            return v_yn.Value.ToString() == "Y" ? false : true;//Y la chua co
        }

        public void filldatasetTNKNgoaiBangLuong(DataSet v_ds, string ip_thang, string ip_nam)
        {
            CStoredProc v_cstore = new CStoredProc("pr_get_tnk_ngoai_bang_luong");
            v_cstore.addDecimalInputParam("@thang", ip_thang);
            v_cstore.addDecimalInputParam("@nam", ip_nam);
            v_cstore.fillDataSetByCommand(this, v_ds);
        }

        public void FillDatasetTheoQuyThangNam(DS_GD_THU_NHAP_KHAC v_ds, string ip_id_quy_tnk, string ip_thang, string ip_nam)
        {
            CStoredProc v_cstore = new CStoredProc("pr_TNK_thu_nhap_getTheoDK");
            v_cstore.addDecimalInputParam("@thang", ip_thang);
            v_cstore.addDecimalInputParam("@nam", ip_nam);
            v_cstore.addDecimalInputParam("@id_quy_tnk", ip_id_quy_tnk);
            v_cstore.fillDataSetByCommand(this, v_ds);
        }

        public void LayDuLieuThuNhapKhacTheoIDQuy(DataSet ip_ds, decimal ip_dc_id_quy_tien_thuong)
        {
            CStoredProc v_sp = new CStoredProc("pr_TNK_thu_nhap_khac_getTheoIdQuy");
            v_sp.addDecimalInputParam("@ip_dc_id_quy", ip_dc_id_quy_tien_thuong);

            v_sp.fillDataSetByCommand(this, ip_ds);
        }

    }
}
