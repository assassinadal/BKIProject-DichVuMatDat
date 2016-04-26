using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using BKI_DichVuMatDat;
using BKI_DichVuMatDat.US;
using BKI_DichVuMatDat.DS;
using BKI_DichVuMatDat.DS.CDBNames;
using IP.Core.IPCommon;
using System.Globalization;
using DevExpress.XtraEditors;
using IP.Core.IPSystemAdmin;
using BKI_DichVuMatDat.COMMON;


namespace BKI_DichVuMatDat.NghiepVu
{
    public partial class f310_cap_nhat_cong_tac_v2 : Form
    {
        #region Public Methods
        public f310_cap_nhat_cong_tac_v2()
        {
            InitializeComponent();
            format_controls();
        }
        public void display_for_them_cong_tac_moi(decimal ip_dc_phong_ban)
        {
            setup_form_for_them_moi_qua_trinh_cong_tac(ip_dc_phong_ban);
            ShowDialog();
        }
        public void display_for_cap_nhat_lam_thoi_cong_tac(decimal ip_dc_id_nhan_vien, decimal ip_dc_id_phong_ban_chinh_thuc)
        {
            setup_form_for_cap_nhat_lam_thoi_cong_tac(ip_dc_id_nhan_vien, ip_dc_id_phong_ban_chinh_thuc);
            ShowDialog();
        }
        public void display_for_kiem_nhiem_cong_tac(decimal ip_dc_id_nhan_vien, decimal ip_dc_id_phong_ban_hien_tai)
        {
            setup_form_for_kiem_nhiem_cong_tac(ip_dc_id_nhan_vien, ip_dc_id_phong_ban_hien_tai);
            ShowDialog();
        }
        public void display_for_chuyen_cong_tac(decimal ip_dc_id_nhan_vien, decimal ip_dc_id_phong_ban_cu)
        {
            setup_form_for_chuyen_cong_tac(ip_dc_id_nhan_vien, ip_dc_id_phong_ban_cu);
            ShowDialog();
        }
        public void display_for_cham_dut_cong_tac(decimal ip_dc_id_gd_cong_tac)
        {     
            setup_form_for_cham_dut_cong_tac(ip_dc_id_gd_cong_tac);
            ShowDialog();
        }
        public void display_for_cham_dut_cong_tac(decimal ip_dc_id_gd_cong_tac,decimal ip_dc_id_phong_ban)
        {
            setup_form_for_cham_dut_cong_tac(ip_dc_id_gd_cong_tac,ip_dc_id_phong_ban);
            ShowDialog();
        }
        public void display_for_update(decimal ip_dc_id_gd_cong_tac)
        {
            setup_form_for_update_cong_tac(ip_dc_id_gd_cong_tac);
            ShowDialog();
        }
        #endregion

        #region Members
        e_loai_cap_nhat m_e_loai_cap_nhat = e_loai_cap_nhat.NULL;
        #endregion

        #region Data structure
        enum e_loai_cap_nhat
        {
            THEM_MOI_CONG_TAC,//Nghiep vu them mot cong tac moi
            LAM_THOI_CONG_TAC,//Nghiep vu lam thoi cong tac
            CHUYEN_CONG_TAC, // Nghiep vu chuyen cong tac
            CHAM_DUT_CONG_TAC,//Nghiep vu cham dut cong tac
            KIEM_NHIEM_CONG_TAC,//Nghiep vu kiem nhiem cong tac
            UPDATE, //Update khi co sai sot
            DELETE, // Delete khi co sai sot
            NULL //Chua assign loai cho cong tac
        }
        #endregion

        #region Private Methods
        //Init Form
        private void format_controls()
        {
            //FormatControl.SetVisibleSimpleButton(this);
            set_define_events();
            this.KeyPreview = true;
            CenterToScreen();
            set_init_form();
        }
        private void set_init_form()
        {
            load_data_2_sle_chon_quyet_dinh(load_danh_sach_quyet_dinh());
            load_data_2_sle_chon_don_vi(load_danh_sach_don_vi());
            //load_data_2_sle_chon_vi_tri();
            m_sle_chon_don_vi.EditValueChanged += m_sle_chon_don_vi_EditValueChanged;
            load_data_2_sle_chon_loai_cong_tac();
        }


        //load data to all controls
        private void load_data_2_sle_nhan_vien(DataTable ip_source)
        {
            m_sle_chon_nhan_vien.Properties.DataSource = null;
            m_sle_chon_nhan_vien.Properties.DataSource = ip_source;

            m_sle_chon_nhan_vien.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            m_sle_chon_nhan_vien.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
        }
        private DataTable load_danh_sach_nhan_vien_chua_co_cong_tac()
        {
            US_GD_CONG_TAC v_us_ct = new US_GD_CONG_TAC();
            return v_us_ct.LayDanhSachNhanVienChuaCoCongTac();
        }
        private DataTable load_danh_sach_nhan_vien_theo_phong_ban(decimal ip_dc_id_phong_ban)
        {
            US_GD_CONG_TAC v_us_ct = new US_GD_CONG_TAC();
            return v_us_ct.LayDanhSachNhanVienTheoPhongBan(Convert.ToDecimal(m_sle_chon_don_vi.EditValue));
        }

        private DataTable load_danh_sach_quyet_dinh()
        {
            US_V_GD_QUYET_DINH v_us = new US_V_GD_QUYET_DINH();
            DS_V_GD_QUYET_DINH v_ds = new DS_V_GD_QUYET_DINH();
            v_us.FillDataset(v_ds);
            return v_ds.Tables[0];
        }
        private void load_data_2_sle_chon_quyet_dinh(DataTable ip_dt_source)
        {
            m_sle_chon_quyet_dinh.Properties.DataSource = ip_dt_source;
            m_sle_chon_quyet_dinh.Properties.DisplayMember = V_GD_QUYET_DINH.TEN;
            m_sle_chon_quyet_dinh.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            m_sle_chon_quyet_dinh.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
        }

        private DataSet load_data_2_cm_dm_tu_dien(int m_id_vt)
        {
            DS_CM_DM_TU_DIEN v_ds = new DS_CM_DM_TU_DIEN();
            US_CM_DM_TU_DIEN v_us = new US_CM_DM_TU_DIEN();
            v_us.FillDatasetByIdLoaiTuDien(v_ds, m_id_vt);
            return v_ds;
        }
        private void load_data_2_sle_chon_vi_tri()
        {
            US_DM_CHUC_VU v_us = new US_DM_CHUC_VU();
            DS_DM_CHUC_VU v_ds = new DS_DM_CHUC_VU();
            v_us.FillDataset(v_ds, " where id_don_vi = " + Convert.ToDecimal(m_sle_chon_don_vi.EditValue));
            m_sle_chon_vi_tri.Properties.DataSource = v_ds.Tables[0];

            m_sle_chon_vi_tri.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            m_sle_chon_vi_tri.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
        }
        private void load_data_2_sle_chon_loai_cong_tac()
        {
            m_sle_chon_loai_cong_tac.Properties.DataSource = load_data_2_cm_dm_tu_dien(CONST_ID_LOAI_TU_DIEN.LOAI_CONG_TAC).Tables[0];

            m_sle_chon_loai_cong_tac.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            m_sle_chon_loai_cong_tac.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
        }

        private DataTable load_danh_sach_don_vi()
        {
            US_DM_DON_VI v_us = new US_DM_DON_VI();
            DS_DM_DON_VI v_ds = new DS_DM_DON_VI();
            v_us.FillDataset(v_ds);
            return v_ds.Tables[0];
        }

        private void load_data_2_sle_chon_don_vi(DataTable ip_dt_source)
        {
            m_sle_chon_don_vi.Properties.DataSource = ip_dt_source;

            m_sle_chon_don_vi.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            m_sle_chon_don_vi.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
        }



        //
        private void form_2_us_gd_cong_tac(ref US_GD_CONG_TAC ip_us)
        {

            if(m_sle_chon_quyet_dinh.EditValue != null)
            {
                ip_us.dcID_QUYET_DINH = CIPConvert.ToDecimal(m_sle_chon_quyet_dinh.EditValue);
            }

            if(m_sle_chon_nhan_vien.EditValue != null)
            {
                ip_us.dcID_NHAN_VIEN = CIPConvert.ToDecimal(m_sle_chon_nhan_vien.EditValue);
            }

            if(m_sle_chon_don_vi.EditValue != null)
            {
                ip_us.dcID_DON_VI = CIPConvert.ToDecimal(m_sle_chon_don_vi.EditValue);
            }

            if(m_sle_chon_vi_tri.EditValue != null)
            {
                ip_us.dcID_VI_TRI = CIPConvert.ToDecimal(m_sle_chon_vi_tri.EditValue);
            }

            if(m_sle_chon_loai_cong_tac.EditValue != null)
            {
                ip_us.dcID_LOAI_CONG_TAC = CIPConvert.ToDecimal(m_sle_chon_loai_cong_tac.EditValue);
            }

            if(m_dat_ngay_bat_dau.EditValue != null)
            {
                //Ngay bat dau
                ip_us.datNGAY_BAT_DAU = m_dat_ngay_bat_dau.DateTime;
            }

            if(m_dat_ngay_ket_thuc.EditValue != null)
            {
                //Ngay ket thuc
                ip_us.datNGAY_KET_THUC = m_dat_ngay_ket_thuc.DateTime;
            }
            else
            {
                ip_us.SetNGAY_KET_THUCNull();
            }

            if(m_e_loai_cap_nhat == e_loai_cap_nhat.THEM_MOI_CONG_TAC)
            {
                //Ngay lap
                ip_us.datNGAY_LAP = DateTime.Now.Date;
                ip_us.strNGUOI_LAP = CAppContext_201.getCurrentUserName();
            }
            else if(m_e_loai_cap_nhat == e_loai_cap_nhat.UPDATE)
            {
                //Ngay sua
                ip_us.datNGAY_SUA = DateTime.Now.Date;
                ip_us.strNGUOI_SUA = CAppContext_201.getCurrentUserName();
            }
            ip_us.strDA_XOA = "N";
            //ip_us.dcSO_HO_SO = ExecuteFuntion.GetSoHoSoNext(ip_us.dcID_DON_VI, ip_us.dcID_VI_TRI);
        }
        private void us_2_form(US_GD_CONG_TAC ip_us)
        {
            m_sle_chon_nhan_vien.EditValue = ip_us.dcID_NHAN_VIEN;
            m_sle_chon_quyet_dinh.EditValue = ip_us.dcID_QUYET_DINH;
            m_sle_chon_loai_cong_tac.EditValue = ip_us.dcID_LOAI_CONG_TAC;
            m_sle_chon_don_vi.EditValue = ip_us.dcID_DON_VI;
            m_sle_chon_vi_tri.EditValue = ip_us.dcID_VI_TRI;
            m_dat_ngay_bat_dau.EditValue = ip_us.datNGAY_BAT_DAU;
            m_dat_ngay_ket_thuc.EditValue = ip_us.datNGAY_KET_THUC;
        }
        private void save_for_lam_thoi_cong_tac(US_GD_CONG_TAC ip_us_ct_lam_thoi)
        {
            try
            {
                ip_us_ct_lam_thoi.BeginTransaction();
                ip_us_ct_lam_thoi.CapNhatHetHieuLucCongTacChinhThucHoacLamThoi(ip_us_ct_lam_thoi.dcID_NHAN_VIEN, ip_us_ct_lam_thoi.datNGAY_BAT_DAU.AddDays(-1));
                ip_us_ct_lam_thoi.Insert();
                ip_us_ct_lam_thoi.CommitTransaction();
                CHRM_BaseMessages.MsgBox_Infor(CONST_ID_MSGBOX.INFOR_LUU_DU_LIEU_THANH_CONG);
                Close();
            }
            catch(Exception)
            {
                if(ip_us_ct_lam_thoi.is_having_transaction())
                {
                    ip_us_ct_lam_thoi.Rollback();
                }
                throw;
            }
        }
        private void save_for_kiem_nhiem_cong_tac(US_GD_CONG_TAC ip_us_ct_lam_thoi)
        {
            try
            {
                ip_us_ct_lam_thoi.BeginTransaction();
                ip_us_ct_lam_thoi.Insert();
                ip_us_ct_lam_thoi.CommitTransaction();
                CHRM_BaseMessages.MsgBox_Infor(CONST_ID_MSGBOX.INFOR_LUU_DU_LIEU_THANH_CONG);
                Close();
            }
            catch(Exception)
            {
                if(ip_us_ct_lam_thoi.is_having_transaction())
                {
                    ip_us_ct_lam_thoi.Rollback();
                }
                throw;
            }
        }
        private void save_for_chuyen_cong_tac(US_GD_CONG_TAC ip_us_ct_hien_tai)
        {
            try
            {
                if(ip_us_ct_hien_tai.KiemTraNhanVienCoCongTacChua(ip_us_ct_hien_tai.dcID_NHAN_VIEN, ip_us_ct_hien_tai.dcID_DON_VI))
                {
                    XtraMessageBox.Show("Nhân viên đang làm việc ở đơn vị này rồi!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                ip_us_ct_hien_tai.BeginTransaction();
                ip_us_ct_hien_tai.CapNhatHetHieuLucCongTacChinhThucHoacLamThoi(ip_us_ct_hien_tai.dcID_NHAN_VIEN, ip_us_ct_hien_tai.datNGAY_BAT_DAU.AddDays(-1));
                ip_us_ct_hien_tai.Insert();
                ip_us_ct_hien_tai.CommitTransaction();
                CHRM_BaseMessages.MsgBox_Infor(CONST_ID_MSGBOX.INFOR_LUU_DU_LIEU_THANH_CONG);
                Close();
            }
            catch(Exception)
            {
                if(ip_us_ct_hien_tai.is_having_transaction())
                {
                    ip_us_ct_hien_tai.Rollback();
                }
                throw;
            }
        }
        private void save_for_cham_dut_cong_tac(US_GD_CONG_TAC ip_us_ct_hien_tai)
        {
            ip_us_ct_hien_tai.CapNhatHetHieuLucCongTac(ip_us_ct_hien_tai.dcID_NHAN_VIEN, ip_us_ct_hien_tai.datNGAY_KET_THUC);
            CHRM_BaseMessages.MsgBox_Infor(CONST_ID_MSGBOX.INFOR_LUU_DU_LIEU_THANH_CONG);
            Close();
        }
        private void save_data()
        {
            US_GD_CONG_TAC v_us_gd_ct = new US_GD_CONG_TAC();
            form_2_us_gd_cong_tac(ref v_us_gd_ct);
            try
            {
                switch(m_e_loai_cap_nhat)
                {
                    case e_loai_cap_nhat.THEM_MOI_CONG_TAC:
                        v_us_gd_ct.Insert();
                        CHRM_BaseMessages.MsgBox_Infor(CONST_ID_MSGBOX.INFOR_LUU_DU_LIEU_THANH_CONG);
                        break;
                    case e_loai_cap_nhat.LAM_THOI_CONG_TAC:
                        save_for_lam_thoi_cong_tac(v_us_gd_ct);
                        break;
                    case e_loai_cap_nhat.KIEM_NHIEM_CONG_TAC:
                        save_for_kiem_nhiem_cong_tac(v_us_gd_ct);
                        break;
                    case e_loai_cap_nhat.CHUYEN_CONG_TAC:
                        save_for_chuyen_cong_tac(v_us_gd_ct);
                        break;
                    case e_loai_cap_nhat.CHAM_DUT_CONG_TAC:
                        save_for_cham_dut_cong_tac(v_us_gd_ct);
                        break;
                    case e_loai_cap_nhat.UPDATE:
                        v_us_gd_ct.Update();
                        break;
                    default:
                        break;
                }
            }
            catch(Exception v_e)
            {
                v_us_gd_ct.Rollback();
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        //Check validate data
        private bool isNull(object ip_obj)
        {
            if(ip_obj == null)
            {
                return true;
            }
            return false;
        }
        private bool check_data_is_ok()
        {
            if(!check_client_data())
            {
                return false;
            }
            if(!check_logic_data())
            {

                return false;
            }
            return true;
        }
        private bool check_client_data()
        {
            if(isNull(m_sle_chon_nhan_vien.EditValue))
            {
                CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_CHUA_CHON_NHAN_VIEN);
                return false;
            }
            if(isNull(m_sle_chon_don_vi.EditValue))
            {
                CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_CHUA_CHON_DON_VI);
                return false;
            }

            if(isNull(m_sle_chon_vi_tri.EditValue))
            {
                CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_CHUA_CHON_VI_TRI);
                return false;
            }

            if(isNull(m_sle_chon_loai_cong_tac.EditValue))
            {
                CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_CHUA_CHON_LOAI_CONG_TAC);
                return false;
            }

            if(isNull(m_dat_ngay_bat_dau.EditValue))
            {
                CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_CHUA_CHON_NGAY_BAT_DAU);
                return false;
            }
            if(m_e_loai_cap_nhat == e_loai_cap_nhat.CHAM_DUT_CONG_TAC && isNull(m_dat_ngay_ket_thuc.EditValue))
            {
                XtraMessageBox.Show("Bạn chưa điền ngày kết thúc!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private bool kiem_tra_nhan_vien_co_cong_tac_chinh_thuc_chua()
        {
            US_GD_CONG_TAC v_us = new US_GD_CONG_TAC();
            var v_dc_id_nhan_vien = Convert.ToDecimal(m_sle_chon_nhan_vien.EditValue);

            return v_us.KiemTraNhanVienCoCongTacChinhThucChua(Convert.ToDecimal(m_sle_chon_nhan_vien.EditValue));
        }
        private bool check_logic_data()
        {
            if((m_e_loai_cap_nhat == e_loai_cap_nhat.THEM_MOI_CONG_TAC) && kiem_tra_nhan_vien_co_cong_tac_chinh_thuc_chua() == true)
            {
                XtraMessageBox.Show("Nhân viên đã có công tác chính thức rồi!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }


        //
        private void setup_header_text(string ip_str_caption)
        {
            m_lbl_header.Text = ip_str_caption;
        }
        private void setup_read_only(params SearchLookUpEdit[] ref_controls)
        {
            m_sle_chon_don_vi.ReadOnly = false;
            m_sle_chon_loai_cong_tac.ReadOnly = false;
            m_sle_chon_nhan_vien.ReadOnly = false;
            m_sle_chon_quyet_dinh.ReadOnly = false;
            m_sle_chon_vi_tri.ReadOnly = false;

            foreach(var item in ref_controls)
            {
                item.ReadOnly = true;
            }
        }
        private void setup_form_for_them_moi_qua_trinh_cong_tac(decimal ip_dc_id_phong_ban)
        {
            setup_header_text("THÊM MỚI CÔNG TÁC CHO NHÂN VIÊN");
            setup_read_only(m_sle_chon_don_vi, m_sle_chon_loai_cong_tac);
            m_sle_chon_don_vi.EditValue = ip_dc_id_phong_ban;
            m_sle_chon_loai_cong_tac.EditValue = CONST_ID_LOAI_CONG_TAC.CHINH_THUC;
            load_data_2_sle_nhan_vien(load_danh_sach_nhan_vien_chua_co_cong_tac());
            m_e_loai_cap_nhat = e_loai_cap_nhat.THEM_MOI_CONG_TAC;
        }
        private void setup_form_for_kiem_nhiem_cong_tac(decimal ip_dc_id_nhan_vien, decimal ip_dc_id_phong_ban_hien_tai)
        {
            m_e_loai_cap_nhat = e_loai_cap_nhat.KIEM_NHIEM_CONG_TAC;
            load_data_2_sle_nhan_vien(load_danh_sach_nhan_vien_theo_phong_ban(ip_dc_id_phong_ban_hien_tai));
            setup_header_text("THÊM MỚI KIÊM NHIỆM CÔNG TÁC CHO NHÂN VIÊN");
            setup_read_only(m_sle_chon_loai_cong_tac, m_sle_chon_nhan_vien);

            m_sle_chon_nhan_vien.EditValue = ip_dc_id_nhan_vien;
            m_sle_chon_loai_cong_tac.EditValue = CONST_ID_LOAI_CONG_TAC.KIEM_NHIEM;
        }
        private void setup_form_for_chuyen_cong_tac(decimal ip_dc_id_nhan_vien, decimal ip_dc_id_phong_ban_cu)
        {
            m_e_loai_cap_nhat = e_loai_cap_nhat.CHUYEN_CONG_TAC;
            load_data_2_sle_nhan_vien(load_danh_sach_nhan_vien_theo_phong_ban(ip_dc_id_phong_ban_cu));
            setup_header_text("CHUYỂN CÔNG TÁC CHO NHÂN VIÊN");
            setup_read_only(m_sle_chon_loai_cong_tac, m_sle_chon_nhan_vien);

            m_sle_chon_nhan_vien.EditValue = ip_dc_id_nhan_vien;
            m_sle_chon_loai_cong_tac.EditValue = CONST_ID_LOAI_CONG_TAC.CHINH_THUC;
        }
        private void setup_form_for_cap_nhat_lam_thoi_cong_tac(decimal ip_dc_id_nhan_vien, decimal ip_dc_id_phong_ban_chinh_thuc)
        {
            m_e_loai_cap_nhat = e_loai_cap_nhat.LAM_THOI_CONG_TAC;
            load_data_2_sle_nhan_vien(load_danh_sach_nhan_vien_theo_phong_ban(ip_dc_id_phong_ban_chinh_thuc));
            setup_header_text("CẬP NHẬT LÂM THỜI CÔNG TÁC");
            setup_read_only(m_sle_chon_loai_cong_tac, m_sle_chon_nhan_vien);
            m_sle_chon_nhan_vien.EditValue = ip_dc_id_nhan_vien;
            m_sle_chon_loai_cong_tac.EditValue = CONST_ID_LOAI_CONG_TAC.LAM_THOI;
        }
        private void setup_form_for_update_cong_tac(decimal ip_dc_id_gd_cong_tac)
        {
            US_GD_CONG_TAC v_us_ct = new US_GD_CONG_TAC(ip_dc_id_gd_cong_tac);
            m_e_loai_cap_nhat = e_loai_cap_nhat.UPDATE;

            setup_header_text("SỬA CÔNG TÁC");
            setup_read_only(m_sle_chon_don_vi);
            load_data_2_sle_nhan_vien(load_danh_sach_nhan_vien_theo_phong_ban(v_us_ct.dcID_DON_VI));

            m_sle_chon_nhan_vien.EditValue = v_us_ct.dcID_NHAN_VIEN;
            m_sle_chon_don_vi.EditValue = v_us_ct.dcID_DON_VI;
            m_sle_chon_loai_cong_tac.EditValue = v_us_ct.dcID_LOAI_CONG_TAC;
            m_sle_chon_quyet_dinh.EditValue = v_us_ct.dcID_QUYET_DINH;
            m_sle_chon_vi_tri.EditValue = v_us_ct.dcID_VI_TRI;
            m_dat_ngay_bat_dau.EditValue = v_us_ct.datNGAY_BAT_DAU;
            if(!v_us_ct.IsNGAY_KET_THUCNull())
            {
                m_dat_ngay_ket_thuc.EditValue = v_us_ct.datNGAY_KET_THUC;
            }
        }
        private void setup_form_for_cham_dut_cong_tac(decimal ip_dc_id_gd_cong_tac)
        {
            US_GD_CONG_TAC v_us_ct = new US_GD_CONG_TAC(ip_dc_id_gd_cong_tac);
            m_e_loai_cap_nhat = e_loai_cap_nhat.CHAM_DUT_CONG_TAC;
            setup_header_text("CHẤM DỨT CÔNG TÁC NHÂN VIÊN");
            setup_read_only(m_sle_chon_don_vi, m_sle_chon_vi_tri, m_sle_chon_nhan_vien, m_sle_chon_loai_cong_tac, m_sle_chon_quyet_dinh);
            m_dat_ngay_bat_dau.ReadOnly = true;
            m_sle_chon_nhan_vien.EditValue = v_us_ct.dcID_NHAN_VIEN;
            m_sle_chon_don_vi.EditValue = v_us_ct.dcID_DON_VI;
            m_sle_chon_loai_cong_tac.EditValue = v_us_ct.dcID_LOAI_CONG_TAC;
            m_sle_chon_quyet_dinh.EditValue = v_us_ct.dcID_QUYET_DINH;
            m_sle_chon_vi_tri.EditValue = v_us_ct.dcID_VI_TRI;
            m_dat_ngay_bat_dau.EditValue = v_us_ct.datNGAY_BAT_DAU;
            if(!v_us_ct.IsNGAY_KET_THUCNull())
            {
                m_dat_ngay_ket_thuc.EditValue = v_us_ct.datNGAY_KET_THUC;
            }
        }
        private void setup_form_for_cham_dut_cong_tac(decimal ip_dc_id_gd_cong_tac, decimal ip_dc_id_phong_ban)
        {
            load_data_2_sle_nhan_vien(load_danh_sach_nhan_vien_theo_phong_ban(ip_dc_id_phong_ban));
            US_GD_CONG_TAC v_us_ct = new US_GD_CONG_TAC(ip_dc_id_gd_cong_tac);
            m_e_loai_cap_nhat = e_loai_cap_nhat.CHAM_DUT_CONG_TAC;
            setup_header_text("CHẤM DỨT CÔNG TÁC NHÂN VIÊN");
            setup_read_only(m_sle_chon_don_vi, m_sle_chon_vi_tri, m_sle_chon_nhan_vien, m_sle_chon_loai_cong_tac, m_sle_chon_quyet_dinh);
            m_dat_ngay_bat_dau.ReadOnly = true;
            m_sle_chon_nhan_vien.EditValue = v_us_ct.dcID_NHAN_VIEN;
            m_sle_chon_don_vi.EditValue = v_us_ct.dcID_DON_VI;
            m_sle_chon_loai_cong_tac.EditValue = v_us_ct.dcID_LOAI_CONG_TAC;
            m_sle_chon_quyet_dinh.EditValue = v_us_ct.dcID_QUYET_DINH;
            m_sle_chon_vi_tri.EditValue = v_us_ct.dcID_VI_TRI;
            m_dat_ngay_bat_dau.EditValue = v_us_ct.datNGAY_BAT_DAU;
            if (!v_us_ct.IsNGAY_KET_THUCNull())
            {
                m_dat_ngay_ket_thuc.EditValue = v_us_ct.datNGAY_KET_THUC;
            }
        }
        #endregion

        #region Events Handle
        private void set_define_events()
        {
            this.Load += f351_quan_ly_cong_tac_de_Load;
            this.FormClosed += f351_quan_ly_cong_tac_de_FormClosed;
            this.KeyDown += f351_quan_ly_cong_tac_de_KeyDown;
            m_cmd_save.Click += m_cmd_save_Click;
            m_cmd_exit.Click += m_cmd_exit_Click;
        }
        void m_sle_chon_don_vi_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                load_data_2_sle_chon_vi_tri();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        void f351_quan_ly_cong_tac_de_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if(e.KeyCode == Keys.Escape)
                {
                    this.Close();
                }
                if(e.KeyCode == Keys.Enter)
                {
                    //save_data();
                }
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void f351_quan_ly_cong_tac_de_Load(object sender, EventArgs e)
        {
            try
            {

            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void f351_quan_ly_cong_tac_de_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                this.Dispose();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_save_Click(object sender, EventArgs e)
        {
            try
            {
                if(check_data_is_ok())
                {
                    save_data();
                }
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_exit_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        #endregion

    }
}
