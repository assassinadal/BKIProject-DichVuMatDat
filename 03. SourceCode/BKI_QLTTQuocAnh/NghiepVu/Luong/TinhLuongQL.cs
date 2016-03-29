using BKI_DichVuMatDat.COMMON;
using BKI_DichVuMatDat.DS;
using BKI_DichVuMatDat.DS.CDBNames;
using BKI_DichVuMatDat.DTO;
using BKI_DichVuMatDat.US;
using DevExpress.XtraEditors;
using IP.Core.IPCommon;
using IP.Core.IPSystemAdmin;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BKI_DichVuMatDat.NghiepVu.Luong
{
    public class TinhLuongQL
    {
        #region Singleton
        private static TinhLuongQL _instance;
        public static TinhLuongQL Instance
        {
            get
            {
                if(_instance == null)
                    _instance = new TinhLuongQL();
                return _instance;
            }
        }
        #endregion
       
        public DTO_THONG_TIN_BANG_LUONG LayThongTinBangLuong(decimal ip_dc_thang, decimal ip_dc_nam)
        {
            return new DTO_THONG_TIN_BANG_LUONG(ip_dc_thang, ip_dc_nam);
        }
        public DataSet LayDanhSachNhanVienCanTinhLuong(ENUM_CONFIRM_TINH_BANG_LUONG ip_confirm_cach_tinh, decimal ip_dc_thang, decimal ip_dc_nam)
        {
            US_RPT_LUONG_V2 v_us_rpt_luong = new US_RPT_LUONG_V2();
            DataSet v_ds_danh_sach_nhan_vien;
            if(ip_confirm_cach_tinh == ENUM_CONFIRM_TINH_BANG_LUONG.TINH_NHAN_VIEN_CHUA_CO)
            {
                v_us_rpt_luong.LayDanhSachNhanVienIDChuaTinhLuong(
                                 out v_ds_danh_sach_nhan_vien
                                 , ip_dc_thang
                                 , ip_dc_nam);
            }
            else if(ip_confirm_cach_tinh == ENUM_CONFIRM_TINH_BANG_LUONG.TINH_LAI_TOAN_BO)
            {
                v_us_rpt_luong.LayToanBoNhanVienIDTinhLuong(
                                 out v_ds_danh_sach_nhan_vien
                                 , ip_dc_thang
                                 , ip_dc_nam);
            }
            else
            {
                v_ds_danh_sach_nhan_vien = new DS_RPT_LUONG_V2();
            }
            return v_ds_danh_sach_nhan_vien;
        }
        public DTO_BANG_LUONG_V2 TinhToanBangLuongNhanVien(decimal ip_dc_id_nhan_vien, decimal ip_dc_thang, decimal ip_dc_nam)
        {
            DataRow v_dr_luong_nv = get_luong_1_nhan_vien_v2(ip_dc_id_nhan_vien, ip_dc_thang, ip_dc_nam);
            return transfer_data_row_db_luong_2_object(v_dr_luong_nv, ip_dc_thang, ip_dc_nam);
        }
        public void InsertBanGhiLuongNhanVien(DTO_BANG_LUONG_V2 ip_dto_bang_luong)
        {
            ip_dto_bang_luong.ID_NHAN_VIEN = ExecuteFuntion.LayNhanVienID(ip_dto_bang_luong.MA_NV);
            US_RPT_LUONG_V2 v_us_rpt_luong_v2 = transfer_dto_2_us_object(ip_dto_bang_luong);

            DataRow v_dr_thong_tin_tong_hop_nv = get_thong_tin_tong_hop_1_nhan_vien_v2(ip_dto_bang_luong.MA_NV, ip_dto_bang_luong.THANG, ip_dto_bang_luong.NAM);
            US_RPT_THONG_TIN_TONG_HOP_V2 v_us_rpt_tong_hop_v2 = DataRow2USThongTinTongHopV2(v_dr_thong_tin_tong_hop_nv);

            v_us_rpt_luong_v2.BeginTransaction();
            v_us_rpt_luong_v2.Insert();
            v_us_rpt_tong_hop_v2.UseTransOfUSObject(v_us_rpt_luong_v2);
            v_us_rpt_tong_hop_v2.XoaDuLieuTongHopNhanVien(ip_dto_bang_luong.ID_NHAN_VIEN, ip_dto_bang_luong.THANG, ip_dto_bang_luong.NAM);
            v_us_rpt_tong_hop_v2.Insert();
            v_us_rpt_luong_v2.CommitTransaction();
        }
        public void ReplaceBanGhiLuongNhanVien(DTO_BANG_LUONG_V2 ip_dto_bang_luong)
        {
            US_RPT_LUONG_V2 v_us_rpt_luong_v2 = transfer_dto_2_us_object(ip_dto_bang_luong);

            ip_dto_bang_luong.ID_NHAN_VIEN = ExecuteFuntion.LayNhanVienID(ip_dto_bang_luong.MA_NV);

            DataRow v_dr_thong_tin_tong_hop_nv = get_thong_tin_tong_hop_1_nhan_vien_v2(ip_dto_bang_luong.MA_NV, ip_dto_bang_luong.THANG, ip_dto_bang_luong.NAM);
            US_RPT_THONG_TIN_TONG_HOP_V2 v_us_rpt_tong_hop_v2 = DataRow2USThongTinTongHopV2(v_dr_thong_tin_tong_hop_nv);

            v_us_rpt_luong_v2.BeginTransaction();
            v_us_rpt_luong_v2.XoaBangLuongNhanVien(ip_dto_bang_luong.ID_NHAN_VIEN, ip_dto_bang_luong.THANG, ip_dto_bang_luong.NAM);
            v_us_rpt_luong_v2.Insert();
            v_us_rpt_tong_hop_v2.UseTransOfUSObject(v_us_rpt_luong_v2);
            v_us_rpt_tong_hop_v2.XoaDuLieuTongHopNhanVien(ip_dto_bang_luong.ID_NHAN_VIEN, ip_dto_bang_luong.THANG, ip_dto_bang_luong.NAM);
            v_us_rpt_tong_hop_v2.Insert();
            v_us_rpt_luong_v2.CommitTransaction();
        }
        public void ReplaceBanGhiLuongNhanVien(decimal ip_dc_id_nhan_vien, decimal ip_dc_thang, decimal ip_dc_nam)
        {
            var v_dr_luong_nv = get_luong_1_nhan_vien_v2(ip_dc_id_nhan_vien, ip_dc_thang, ip_dc_nam);
            var v_dto_luong_nv = transfer_data_row_db_luong_2_object(v_dr_luong_nv, ip_dc_thang, ip_dc_nam);
            US_RPT_LUONG_V2 v_us_rpt_luong_v2 = transfer_dto_2_us_object(v_dto_luong_nv);

            DataRow v_dr_thong_tin_tong_hop_nv = get_thong_tin_tong_hop_1_nhan_vien_v2(ExecuteFuntion.LayMaNhanVien(ip_dc_id_nhan_vien), ip_dc_thang, ip_dc_nam);
            US_RPT_THONG_TIN_TONG_HOP_V2 v_us_rpt_tong_hop_v2 = DataRow2USThongTinTongHopV2(v_dr_thong_tin_tong_hop_nv);

            v_us_rpt_luong_v2.BeginTransaction();
            v_us_rpt_luong_v2.XoaBangLuongNhanVien(ip_dc_id_nhan_vien, ip_dc_thang, ip_dc_nam);
            v_us_rpt_luong_v2.Insert();
            v_us_rpt_tong_hop_v2.UseTransOfUSObject(v_us_rpt_luong_v2);
            v_us_rpt_tong_hop_v2.XoaDuLieuTongHopNhanVien(ip_dc_id_nhan_vien, ip_dc_thang, ip_dc_nam);
            v_us_rpt_tong_hop_v2.Insert();
            v_us_rpt_luong_v2.CommitTransaction();
        }

        public void XoaBanGhiLuongNhanVien(decimal ip_dc_id_nhan_vien, decimal ip_dc_thang, decimal ip_dc_nam)
        {
            US_RPT_LUONG_V2 v_us_rpt_luong_v2 = new US_RPT_LUONG_V2();
            US_RPT_THONG_TIN_TONG_HOP_V2 v_us_rpt_tong_hop_v2 = new US_RPT_THONG_TIN_TONG_HOP_V2();
            v_us_rpt_luong_v2.BeginTransaction();
            v_us_rpt_luong_v2.XoaBangLuongNhanVien(ip_dc_id_nhan_vien, ip_dc_thang, ip_dc_nam);
            v_us_rpt_tong_hop_v2.UseTransOfUSObject(v_us_rpt_luong_v2);
            v_us_rpt_tong_hop_v2.XoaDuLieuTongHopNhanVien(ip_dc_id_nhan_vien, ip_dc_thang, ip_dc_nam);
            v_us_rpt_luong_v2.CommitTransaction();
        }


        public bool KiemTraNhanVienCoTrongBangLuongChua(DTO_BANG_LUONG_V2 ip_dto_bang_luong)
        {
            return ExecuteFuntion.KiemTraNhanVienCoTrongBangLuongChua(ip_dto_bang_luong.MA_NV, ip_dto_bang_luong.THANG, ip_dto_bang_luong.NAM);
        }
        
        public void ChotBangLuongThang(decimal ip_dc_thang, decimal ip_dc_nam)
        {
            //var v_dlg = XtraMessageBox.Show("Bạn có muốn chốt các dữ liệu lương tháng này?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if(v_dlg == DialogResult.No)
            //{
            //    //XtraMessageBox.Show("Bạn đã hủy thao tác!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;
            //}
            US_RPT_CHOT_BANG_LUONG v_us_rpt_chot_bang_luong = new US_RPT_CHOT_BANG_LUONG();
            if(v_us_rpt_chot_bang_luong.IsLockBangLuong(ip_dc_thang, ip_dc_nam))
            {
                XtraMessageBox.Show("Bảng lương đã được chốt!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            v_us_rpt_chot_bang_luong.LockBangLuongThang(ip_dc_thang, ip_dc_nam, CAppContext_201.getCurrentUserName());
            XtraMessageBox.Show("Đã chốt bảng lương tháng thành công! ", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void XoaToanBoBangLuong(decimal ip_dc_thang, decimal ip_dc_nam)
        {
            US_RPT_LUONG_V2 v_us_luong = new US_RPT_LUONG_V2();
            US_RPT_THONG_TIN_TONG_HOP_V2 v_us_rpt_tong_hop = new US_RPT_THONG_TIN_TONG_HOP_V2();
            v_us_luong.BeginTransaction();
            v_us_luong.XoaToanBoBangLuong(ip_dc_thang, ip_dc_nam);
            v_us_rpt_tong_hop.UseTransOfUSObject(v_us_luong);
            v_us_rpt_tong_hop.XoaToanBoDuLieuTongHop(ip_dc_thang, ip_dc_nam);
            v_us_luong.CommitTransaction();
        }
        private bool isNull(Object ip_obj)
        {
            if(ip_obj == DBNull.Value)
            {
                return true;
            }
            return false;
        }
        public DTO_BANG_LUONG_V2 transfer_data_row_excel_luong_2_object(DataRow ip_dr_luong, decimal ip_dc_thang, decimal ip_dc_nam)
        {
            DTO_BANG_LUONG_V2 v_dto_luong = new DTO_BANG_LUONG_V2();
            v_dto_luong.THANG = ip_dc_thang;
            v_dto_luong.NAM = ip_dc_nam;
            v_dto_luong.MA_NV = ip_dr_luong[RPT_LUONG_V2.MA_NV].ToString();
            v_dto_luong.HO_TEN = ip_dr_luong[RPT_LUONG_V2.HO_TEN].ToString();

            v_dto_luong.TEN_DON_VI = ip_dr_luong[RPT_LUONG_V2.TEN_DON_VI].ToString();
            //v_dto_luong.THU_TU_DON_VI = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.THU_TU_DON_VI]);

            v_dto_luong.TEN_CHUC_VU = ip_dr_luong[RPT_LUONG_V2.TEN_CHUC_VU].ToString();
            //v_dto_luong.THU_TU_CHUC_VU = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.THU_TU_CHUC_VU]);

            v_dto_luong.LUONG_NS = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.LUONG_NS]);
            v_dto_luong.LUONG_CD = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.LUONG_CD]);
            v_dto_luong.PHU_CAP_TN = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.PHU_CAP_TN]);
            v_dto_luong.AN_CA = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.AN_CA]);
            v_dto_luong.LAM_THEM = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.LAM_THEM]);
            v_dto_luong.THU_NHAP_KHAC_TRONG_LUONG = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.THU_NHAP_KHAC_TRONG_LUONG]);
            v_dto_luong.TONG_THU_NHAP_TRONG_LUONG = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.TONG_THU_NHAP_TRONG_LUONG]);

            v_dto_luong.THUONG = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.THUONG]);
            v_dto_luong.THUONG_ATHK = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.THUONG_ATHK]);
            v_dto_luong.BO_SUNG_LUONG = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.BO_SUNG_LUONG]);
            v_dto_luong.THUONG_LE_TET = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.THUONG_LE_TET]);
            v_dto_luong.THU_NHAP_KHAC_NGOAI_LUONG = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.THU_NHAP_KHAC_NGOAI_LUONG]);
            v_dto_luong.TONG_THU_NHAP_NGOAI_LUONG = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.TONG_THU_NHAP_NGOAI_LUONG]);
            v_dto_luong.TONG_THU_NHAP = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.TONG_THU_NHAP]);
            v_dto_luong.TONG_THU_NHAP_CHIU_THUE = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.TONG_THU_NHAP_CHIU_THUE]);

            v_dto_luong.BHXH = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.BHXH]);
            v_dto_luong.BHYT = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.BHYT]);
            v_dto_luong.BHTN = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.BHTN]);
            v_dto_luong.GIAM_TRU_LAM_THEM_150 = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.GIAM_TRU_LAM_THEM_150]);
            v_dto_luong.GIAM_TRU_GIA_CANH = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.GIAM_TRU_GIA_CANH]);
            v_dto_luong.GIAM_TRU_PHU_THUOC = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.GIAM_TRU_PHU_THUOC]);
            v_dto_luong.GIAM_TRU_KHAC = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.GIAM_TRU_KHAC]);
            v_dto_luong.TONG_GIAM_TRU_THUE = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.TONG_GIAM_TRU_THUE]);
            v_dto_luong.TONG_GIAM_TRU = v_dto_luong.TONG_GIAM_TRU_THUE + v_dto_luong.AN_CA;

            v_dto_luong.THU_NHAP_TINH_THUE = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.THU_NHAP_CHIU_THUE]);

            v_dto_luong.DOAN_PHI_CD = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.DOAN_PHI_CD]);
            v_dto_luong.THUE = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.THUE]);
            v_dto_luong.PHAI_NOP_KHAC = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.PHAI_NOP_KHAC]);
            v_dto_luong.SO_TIEN_DA_NOP_THUE = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.SO_TIEN_DA_NOP_THUE]);
            v_dto_luong.TONG_PHAI_NOP = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.TONG_PHAI_NOP]);

            v_dto_luong.THUC_LINH = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.THUC_LINH]);

            return v_dto_luong;
        }

        #region Private Method
        private bool kiem_tra_nhan_vien_co_trong_danh_sach_tinh_luong_thang(decimal ip_dc_id_nhan_vien, decimal ip_dc_thang, decimal ip_dc_nam)
        {
            US_RPT_LUONG_V2 v_us = new US_RPT_LUONG_V2();
            return v_us.kiem_tra_nhan_vien_co_duoc_tinh_luong_thang(ip_dc_id_nhan_vien, ip_dc_thang, ip_dc_nam);
        }
        private DataRow get_luong_1_nhan_vien_v2(decimal ip_dc_id_nhan_vien, decimal ip_dc_thang, decimal ip_dc_nam)
        {
            US_RPT_LUONG_V2 v_us = new US_RPT_LUONG_V2();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.TaoBangLuongNhanVien(v_ds, ip_dc_id_nhan_vien, ip_dc_thang, ip_dc_nam);
            DataRow v_dr = v_ds.Tables[0].Rows[0];
            return v_dr;
        }
        private DTO_BANG_LUONG_V2 transfer_data_row_db_luong_2_object(DataRow ip_dr_luong, decimal ip_dc_thang, decimal ip_dc_nam)
        {
            DTO_BANG_LUONG_V2 v_dto_luong = new DTO_BANG_LUONG_V2();
            v_dto_luong.ID_NHAN_VIEN = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.ID_NHAN_VIEN]);
            v_dto_luong.THANG = ip_dc_thang;
            v_dto_luong.NAM = ip_dc_nam;

            v_dto_luong.MA_NV = ip_dr_luong[RPT_LUONG_V2.MA_NV].ToString();
            v_dto_luong.HO_TEN = ip_dr_luong[RPT_LUONG_V2.HO_TEN].ToString();
            v_dto_luong.TEN_CHUC_VU = ip_dr_luong[RPT_LUONG_V2.TEN_CHUC_VU].ToString();
            v_dto_luong.THU_TU_CHUC_VU = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.THU_TU_CHUC_VU]);
            v_dto_luong.TEN_DON_VI = ip_dr_luong[RPT_LUONG_V2.TEN_DON_VI].ToString();
            v_dto_luong.THU_TU_DON_VI = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.THU_TU_DON_VI]);

            v_dto_luong.LUONG_NS = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.LUONG_NS]);
            v_dto_luong.LUONG_CD = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.LUONG_CD]);
            v_dto_luong.PHU_CAP_TN = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.PHU_CAP_TN]);
            v_dto_luong.AN_CA = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.AN_CA]);
            v_dto_luong.LAM_THEM = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.LAM_THEM]);
            v_dto_luong.LAM_THEM_200 = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.LAM_THEM_200]);
            v_dto_luong.LAM_THEM_300 = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.LAM_THEM_300]);
            v_dto_luong.THU_NHAP_KHAC_TRONG_LUONG = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.THU_NHAP_KHAC_TRONG_LUONG]);
            v_dto_luong.TONG_THU_NHAP_TRONG_LUONG = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.TONG_THU_NHAP_TRONG_LUONG]);

            v_dto_luong.THUONG = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.THUONG]);
            v_dto_luong.THUONG_ATHK = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.THUONG_ATHK]);
            v_dto_luong.BO_SUNG_LUONG = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.BO_SUNG_LUONG]);
            v_dto_luong.THUONG_LE_TET = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.THUONG_LE_TET]);
            v_dto_luong.THU_NHAP_KHAC_NGOAI_LUONG = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.THU_NHAP_KHAC_NGOAI_LUONG]);
            v_dto_luong.TONG_THU_NHAP_NGOAI_LUONG = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.TONG_THU_NHAP_NGOAI_LUONG]);
            v_dto_luong.TONG_THU_NHAP = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.TONG_THU_NHAP]);

            v_dto_luong.TONG_THU_NHAP_CHIU_THUE = v_dto_luong.TONG_THU_NHAP - v_dto_luong.AN_CA;

            v_dto_luong.BHXH = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.BHXH]);
            v_dto_luong.BHYT = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.BHYT]);
            v_dto_luong.BHTN = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.BHTN]);
            v_dto_luong.GIAM_TRU_LAM_THEM_150 = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.GIAM_TRU_LAM_THEM_150]);
            v_dto_luong.GIAM_TRU_LAM_THEM_200 = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.GIAM_TRU_LAM_THEM_200]);
            v_dto_luong.GIAM_TRU_LAM_THEM_300 = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.GIAM_TRU_LAM_THEM_300]);
            v_dto_luong.GIAM_TRU_GIA_CANH = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.GIAM_TRU_GIA_CANH]);
            v_dto_luong.GIAM_TRU_PHU_THUOC = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.GIAM_TRU_PHU_THUOC]);
            v_dto_luong.GIAM_TRU_KHAC = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.GIAM_TRU_KHAC]);
            v_dto_luong.TONG_GIAM_TRU = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.TONG_GIAM_TRU]);
            v_dto_luong.TONG_GIAM_TRU_THUE = v_dto_luong.TONG_GIAM_TRU - v_dto_luong.AN_CA;
            v_dto_luong.THU_NHAP_TINH_THUE = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.THU_NHAP_CHIU_THUE]);

            v_dto_luong.DOAN_PHI_CD = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.DOAN_PHI_CD]);
            v_dto_luong.THUE = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.THUE]);
            v_dto_luong.PHAI_NOP_KHAC = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.PHAI_NOP_KHAC]);
            v_dto_luong.TONG_PHAI_NOP = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.TONG_PHAI_NOP]);

            v_dto_luong.THUC_LINH = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.THUC_LINH]);
            v_dto_luong.SO_TIEN_DA_NOP_THUE = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.SO_TIEN_DA_NOP_THUE]);

            return v_dto_luong;
        }
        private US_RPT_LUONG_V2 transfer_dto_2_us_object(DTO_BANG_LUONG_V2 ip_dto_luong)
        {
            US_RPT_LUONG_V2 v_us_luong_v2 = new US_RPT_LUONG_V2();

            v_us_luong_v2.dcID_NHAN_VIEN = ExecuteFuntion.LayNhanVienID(ip_dto_luong.MA_NV);
            v_us_luong_v2.dcTHANG = ip_dto_luong.THANG;
            v_us_luong_v2.dcNAM = ip_dto_luong.NAM;

            v_us_luong_v2.strMA_NV = ip_dto_luong.MA_NV;

            v_us_luong_v2.dcLUONG_NS = ip_dto_luong.LUONG_NS;
            v_us_luong_v2.dcLUONG_CD = ip_dto_luong.LUONG_CD;
            v_us_luong_v2.dcPHU_CAP_TN = ip_dto_luong.PHU_CAP_TN;
            v_us_luong_v2.dcAN_CA = ip_dto_luong.AN_CA;
            v_us_luong_v2.dcLAM_THEM = ip_dto_luong.LAM_THEM;
            v_us_luong_v2.dcGIAM_TRU_LAM_THEM_200 = ip_dto_luong.LAM_THEM_200;
            v_us_luong_v2.dcGIAM_TRU_LAM_THEM_300 = ip_dto_luong.LAM_THEM_300;
            v_us_luong_v2.dcTHU_NHAP_KHAC_TRONG_LUONG = ip_dto_luong.THU_NHAP_KHAC_TRONG_LUONG;
            v_us_luong_v2.dcTONG_THU_NHAP_TRONG_LUONG = ip_dto_luong.TONG_THU_NHAP_TRONG_LUONG;

            v_us_luong_v2.dcTHUONG = ip_dto_luong.THUONG;
            v_us_luong_v2.dcTHUONG_ATHK = ip_dto_luong.THUONG_ATHK;
            v_us_luong_v2.dcBO_SUNG_LUONG = ip_dto_luong.BO_SUNG_LUONG;
            v_us_luong_v2.dcTHUONG_LE_TET = ip_dto_luong.THUONG_LE_TET;
            v_us_luong_v2.dcTHU_NHAP_KHAC_NGOAI_LUONG = ip_dto_luong.THU_NHAP_KHAC_NGOAI_LUONG;
            v_us_luong_v2.dcTONG_THU_NHAP_NGOAI_LUONG = ip_dto_luong.TONG_THU_NHAP_NGOAI_LUONG;
            v_us_luong_v2.dcTONG_THU_NHAP = ip_dto_luong.TONG_THU_NHAP;

            v_us_luong_v2.dcBHXH = ip_dto_luong.BHXH;
            v_us_luong_v2.dcBHYT = ip_dto_luong.BHYT;
            v_us_luong_v2.dcBHTN = ip_dto_luong.BHTN;
            v_us_luong_v2.dcGIAM_TRU_LAM_THEM_150 = ip_dto_luong.GIAM_TRU_LAM_THEM_150;
            v_us_luong_v2.dcGIAM_TRU_LAM_THEM_200 = ip_dto_luong.GIAM_TRU_LAM_THEM_200;
            v_us_luong_v2.dcGIAM_TRU_LAM_THEM_300 = ip_dto_luong.GIAM_TRU_LAM_THEM_300;
            v_us_luong_v2.dcGIAM_TRU_GIA_CANH = ip_dto_luong.GIAM_TRU_GIA_CANH;
            v_us_luong_v2.dcGIAM_TRU_PHU_THUOC = ip_dto_luong.GIAM_TRU_PHU_THUOC;
            v_us_luong_v2.dcGIAM_TRU_KHAC = ip_dto_luong.GIAM_TRU_KHAC;
            v_us_luong_v2.dcTONG_GIAM_TRU = ip_dto_luong.TONG_GIAM_TRU;

            v_us_luong_v2.dcTHU_NHAP_CHIU_THUE = ip_dto_luong.THU_NHAP_TINH_THUE;

            v_us_luong_v2.dcDOAN_PHI_CD = ip_dto_luong.DOAN_PHI_CD;
            v_us_luong_v2.dcTHUE = ip_dto_luong.THUE;
            v_us_luong_v2.dcPHAI_NOP_KHAC = ip_dto_luong.PHAI_NOP_KHAC;
            v_us_luong_v2.dcTONG_PHAI_NOP = ip_dto_luong.TONG_PHAI_NOP;

            v_us_luong_v2.dcTHUC_LINH = ip_dto_luong.THUC_LINH;
            v_us_luong_v2.dcSO_TIEN_DA_NOP_THUE = ip_dto_luong.SO_TIEN_DA_NOP_THUE;

            return v_us_luong_v2;
        }
       


        private DataRow get_thong_tin_tong_hop_1_nhan_vien_v2(string ip_str_ma_nhan_vien, decimal ip_int_thang, decimal ip_int_nam)
        {
            US_RPT_THONG_TIN_TONG_HOP_V2 v_us = new US_RPT_THONG_TIN_TONG_HOP_V2();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.LayThongTinTongHopNhanVien(v_ds, ip_str_ma_nhan_vien, ip_int_thang, ip_int_nam);
            DataRow v_dr = v_ds.Tables[0].Rows[0];
            return v_dr;
        }
        private US_RPT_THONG_TIN_TONG_HOP_V2 DataRow2USThongTinTongHopV2(DataRow v_dr_luong_1_nv)
        {
            US_RPT_THONG_TIN_TONG_HOP_V2 v_us = new US_RPT_THONG_TIN_TONG_HOP_V2();
            //v_us.dcID = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP_V2_V2.ID].ToString());
            v_us.dcTHANG = Convert.ToDecimal(v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP_V2.THANG]);
            v_us.dcNAM = Convert.ToDecimal(v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP_V2.NAM]);
            v_us.dcID_NHAN_VIEN = (decimal)v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP_V2.ID_NHAN_VIEN];
            v_us.strMA_NV = v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP_V2.MA_NV].ToString();
            v_us.strHO_DEM = v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP_V2.HO_DEM].ToString();
            v_us.strTEN = v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP_V2.TEN].ToString();
            v_us.strHO_VA_TEN = v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP_V2.HO_VA_TEN].ToString();
            v_us.strTEN_CHUC_VU = v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP_V2.TEN_CHUC_VU].ToString();
            v_us.strTEN_HOP_DONG = v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP_V2.TEN_HOP_DONG].ToString();
            v_us.dcLUONG_CHE_DO_THEO_CHUC_VU = (decimal)v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP_V2.LUONG_CHE_DO_THEO_CHUC_VU];
            v_us.dcHS_LUONG_NANG_SUAT_DUOC_HUONG = (decimal)v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP_V2.HS_LUONG_NANG_SUAT_DUOC_HUONG];
            v_us.strTAI_KHOAN = v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP_V2.TAI_KHOAN].ToString();
            v_us.dcCHAM_CONG_X = Convert.ToDecimal(v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP_V2.CHAM_CONG_X]);
            v_us.dcCHAM_CONG_OM_CO = Convert.ToDecimal(v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP_V2.CHAM_CONG_OM_CO]);
            v_us.dcCHAM_CONG_TS = Convert.ToDecimal(v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP_V2.CHAM_CONG_TS]);
            v_us.dcCHAM_CONG_TNLD = Convert.ToDecimal(v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP_V2.CHAM_CONG_TNLD]);
            v_us.dcCHAM_CONG_PHEP_DIDUONG = Convert.ToDecimal(v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP_V2.CHAM_CONG_PHEP_DIDUONG]);
            v_us.dcCHAM_CONG_RO_KO_DC = Convert.ToDecimal(v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP_V2.CHAM_CONG_RO_KO_DC]);
            v_us.dcCHAM_CONG_KHAC = Convert.ToDecimal(v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP_V2.CHAM_CONG_KHAC]);
            v_us.dcHE_SO_K = Convert.ToDecimal(v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP_V2.HE_SO_K]);
            v_us.strDON_VI = v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP_V2.DON_VI].ToString();
            v_us.dcSO_NGAY_LAM_THEM = Convert.ToDecimal(v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP_V2.SO_NGAY_LAM_THEM]);
            v_us.strLOAI_LAO_DONG = v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP_V2.LOAI_LAO_DONG].ToString();
            v_us.dcNGAY_CONG_QUY_DINH = Convert.ToDecimal(v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP_V2.NGAY_CONG_QUY_DINH]);

            v_us.dcHS_ATHK = Math.Round(Convert.ToDecimal(v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP_V2.HS_ATHK]),3, MidpointRounding.AwayFromZero);
            v_us.dcHS_BSL = Math.Round(Convert.ToDecimal(v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP_V2.HS_BSL]), 3, MidpointRounding.AwayFromZero);
            v_us.dcLE_TET_YN = Convert.ToDecimal(v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP_V2.LE_TET_YN]);
            if(v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP_V2.TI_LE_HOP_DONG] != DBNull.Value)
            {
                v_us.dcTI_LE_HOP_DONG = Math.Round(Convert.ToDecimal(v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP_V2.TI_LE_HOP_DONG]), 3, MidpointRounding.AwayFromZero);
            }
            else
            {
                v_us.SetTI_LE_HOP_DONGNull();
            }
            return v_us;
        }


        private void chot_he_so_bsl_athk_thang(decimal ip_dc_thang, decimal ip_dc_nam)
        {
            //US_DM_NHAN_VIEN v_us_dung_chung = new US_DM_NHAN_VIEN();
            //DataSet v_ds_danh_sach_nv_can_insert = new DataSet();
            //v_ds_danh_sach_nv_can_insert.Tables.Add(new DataTable());
            //v_us_dung_chung.FillDatasetNhanVienCanInsertHeSo(v_ds_danh_sach_nv_can_insert, ip_dc_thang, ip_dc_nam);

            //decimal v_dc_so_luong_nhan_vien = v_ds_danh_sach_nv_can_insert.Tables[0].Rows.Count;
            //for(int i = 0; i < v_dc_so_luong_nhan_vien; i++)
            //{
            //    decimal v_id_nv = CIPConvert.ToDecimal(v_ds_danh_sach_nv_can_insert.Tables[0].Rows[i]["ID_NHAN_VIEN"].ToString());
            //    US_GD_HS_BO_SUNG_AN_TOAN_HANG_KHONG v_us = new US_GD_HS_BO_SUNG_AN_TOAN_HANG_KHONG();
            //    v_us.insert_data_by_proc(v_id_nv, ip_dc_thang, ip_dc_nam);
            //}
        }
        #endregion
        
    }
}
