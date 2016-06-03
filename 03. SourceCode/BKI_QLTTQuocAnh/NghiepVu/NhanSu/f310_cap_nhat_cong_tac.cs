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
    public partial class f310_cap_nhat_cong_tac : Form
    {


        #region Public Methods
        public f310_cap_nhat_cong_tac()
        {
            InitializeComponent();
            format_controls();
        }
        public void display_for_them_cong_tac_moi()
        {
            m_us_cong_tac = new US_GD_CONG_TAC();
            setup_form_for_them_moi_qua_trinh_cong_tac();
            ShowDialog();
        }
        public void display_for_update(decimal ip_dc_id_gd_cong_tac)
        {
            m_us_cong_tac = new US_GD_CONG_TAC(ip_dc_id_gd_cong_tac);
            setup_form_for_update_cong_tac(ip_dc_id_gd_cong_tac);
            ShowDialog();
        }
        #endregion

        #region Members
        e_loai_cap_nhat m_e_loai_cap_nhat = e_loai_cap_nhat.NULL;
        US_GD_CONG_TAC m_us_cong_tac;
        #endregion

        #region Data structure
        enum e_loai_cap_nhat
        {
            THEM_MOI,//Nghiep vu them mot cong tac moi
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
            load_data_2_sle_chon_don_vi(load_danh_sach_don_vi());
            load_data_2_sle_nhan_vien();
            m_sle_chon_don_vi.EditValueChanged += m_sle_chon_don_vi_EditValueChanged;
            load_data_2_sle_chon_loai_cong_tac();
            m_sle_chon_vi_tri.EditValueChanged += m_sle_chon_vi_tri_EditValueChanged;
        }




        //load data to all controls
        private void load_data_2_sle_nhan_vien()
        {
            US_DM_NHAN_VIEN v_us = new US_DM_NHAN_VIEN();
            DS_DM_NHAN_VIEN v_ds = new DS_DM_NHAN_VIEN();
            m_sle_chon_nhan_vien.Properties.DataSource = v_us.LayDanhSachNhanVien();
            m_sle_chon_nhan_vien.Properties.DisplayMember = V_DM_NHAN_VIEN.HO_TEN;
            m_sle_chon_nhan_vien.Properties.ValueMember = V_DM_NHAN_VIEN.ID;

           // m_sle_chon_nhan_vien.Properties.DataSource = v_ds.Tables[0];
            m_sle_chon_nhan_vien.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            m_sle_chon_nhan_vien.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
        }

        private DataTable load_danh_sach_quyet_dinh()
        {
            US_V_GD_QUYET_DINH v_us = new US_V_GD_QUYET_DINH();
            DS_V_GD_QUYET_DINH v_ds = new DS_V_GD_QUYET_DINH();
            v_us.FillDataset(v_ds);
            return v_ds.Tables[0];
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
                ip_us.datNGAY_BAT_DAU = m_dat_ngay_bat_dau.DateTime.Date;
            }

            if(m_dat_ngay_ket_thuc.EditValue != null)
            {
                //Ngay ket thuc
                ip_us.datNGAY_KET_THUC = m_dat_ngay_ket_thuc.DateTime.Date;
            }
            else
            {
                ip_us.SetNGAY_KET_THUCNull();
            }

            if(m_e_loai_cap_nhat == e_loai_cap_nhat.THEM_MOI)
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
            if(m_e_loai_cap_nhat == e_loai_cap_nhat.THEM_MOI)
            {
                //ip_us.dcSO_HO_SO = ExecuteFuntion.GetSoHoSoNext(ip_us.dcID_DON_VI, ip_us.dcID_VI_TRI, ip_us.dcID_NHAN_VIEN);
                ip_us.dcSO_HO_SO = Convert.ToDecimal(m_txt_so_ho_so.EditValue);
            }
            else
            {
                ip_us.dcSO_HO_SO = Convert.ToDecimal(m_txt_so_ho_so.EditValue);
            }
        }
        private void us_2_form(US_GD_CONG_TAC ip_us)
        {
            m_sle_chon_nhan_vien.EditValue = ip_us.dcID_NHAN_VIEN;
            m_sle_chon_loai_cong_tac.EditValue = ip_us.dcID_LOAI_CONG_TAC;
            m_sle_chon_don_vi.EditValue = ip_us.dcID_DON_VI;
            m_sle_chon_vi_tri.EditValue = ip_us.dcID_VI_TRI;
            m_dat_ngay_bat_dau.EditValue = ip_us.datNGAY_BAT_DAU;
            m_dat_ngay_ket_thuc.EditValue = ip_us.datNGAY_KET_THUC;
            m_txt_so_ho_so.EditValue = ip_us.dcSO_HO_SO;
        }
        private void save_data()
        {
            //US_GD_CONG_TAC v_us_gd_ct = new US_GD_CONG_TAC();
            form_2_us_gd_cong_tac(ref m_us_cong_tac);
            try
            {
                switch(m_e_loai_cap_nhat)
                {
                    case e_loai_cap_nhat.THEM_MOI:
                        m_us_cong_tac.Insert();
                        CHRM_BaseMessages.MsgBox_Infor(CONST_ID_MSGBOX.INFOR_LUU_DU_LIEU_THANH_CONG);
                        Close();
                        break;
                    case e_loai_cap_nhat.UPDATE:
                        m_us_cong_tac.Update();
                        CHRM_BaseMessages.MsgBox_Infor(CONST_ID_MSGBOX.INFOR_LUU_DU_LIEU_THANH_CONG);
                        Close();
                        break;
                    default:
                        break;
                }
            }
            catch(Exception v_e)
            {
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
            if(m_dat_ngay_ket_thuc.EditValue != null && m_dat_ngay_bat_dau.DateTime >= m_dat_ngay_ket_thuc.DateTime)
            {
                XtraMessageBox.Show("Ngày bắt đầu phải nhỏ hơn ngày kết thúc!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            bool v_bool_check = false;
            US_GD_CONG_TAC v_us_ct = new US_GD_CONG_TAC();
            if(m_e_loai_cap_nhat == e_loai_cap_nhat.THEM_MOI)
            {
                v_bool_check = v_us_ct.KiemTraDuLieuCongTacHopLeForInsert(Convert.ToDecimal(m_sle_chon_nhan_vien.EditValue)
                                                    , Convert.ToDecimal(m_sle_chon_loai_cong_tac.EditValue)
                                                    , m_dat_ngay_bat_dau.DateTime.Date
                                                    , m_dat_ngay_ket_thuc.EditValue == null ? DateTime.Now.AddYears(100).Date : m_dat_ngay_ket_thuc.DateTime.Date);
            }
            if(m_e_loai_cap_nhat == e_loai_cap_nhat.UPDATE)
            {
                v_bool_check = v_us_ct.KiemTraDuLieuCongTacHopLeForUpdate(
                                                    m_us_cong_tac.dcID
                                                    , m_dat_ngay_bat_dau.DateTime.Date
                                                    , m_dat_ngay_ket_thuc.EditValue == null ? DateTime.Now.AddYears(100).Date : m_dat_ngay_ket_thuc.DateTime.Date
                                                    , Convert.ToDecimal(m_sle_chon_loai_cong_tac.EditValue));
            }
            if(v_bool_check == false)
            {
                XtraMessageBox.Show("Ngày tháng công tác không hợp lệ do nhân viên đã có công tác khác trong khoảng thời gian này!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return v_bool_check;
        }


        //
        private void setup_header_text(string ip_str_caption)
        {
            Text = ip_str_caption;
        }
        private void setup_read_only(params SearchLookUpEdit[] ref_controls)
        {
            m_sle_chon_don_vi.ReadOnly = false;
            m_sle_chon_loai_cong_tac.ReadOnly = false;
            m_sle_chon_nhan_vien.ReadOnly = false;
            m_sle_chon_vi_tri.ReadOnly = false;

            foreach(var item in ref_controls)
            {
                item.ReadOnly = true;
            }
        }
        private void setup_form_for_them_moi_qua_trinh_cong_tac()
        {
            setup_header_text("F310 - Thêm mới công tác");
            load_data_2_sle_nhan_vien();
            m_e_loai_cap_nhat = e_loai_cap_nhat.THEM_MOI;
        }
        private void setup_form_for_update_cong_tac(decimal ip_dc_id_gd_cong_tac)
        {
            US_GD_CONG_TAC v_us_ct = new US_GD_CONG_TAC(ip_dc_id_gd_cong_tac);
            m_e_loai_cap_nhat = e_loai_cap_nhat.UPDATE;

            setup_header_text("F310 - Sửa công tác");
            setup_read_only(m_sle_chon_nhan_vien);
            load_data_2_sle_nhan_vien();

            m_sle_chon_nhan_vien.EditValue = v_us_ct.dcID_NHAN_VIEN;
            m_sle_chon_don_vi.EditValue = v_us_ct.dcID_DON_VI;
            m_sle_chon_loai_cong_tac.EditValue = v_us_ct.dcID_LOAI_CONG_TAC;
            m_sle_chon_vi_tri.EditValue = v_us_ct.dcID_VI_TRI;
            m_dat_ngay_bat_dau.EditValue = v_us_ct.datNGAY_BAT_DAU;
            m_txt_so_ho_so.EditValue = v_us_ct.dcSO_HO_SO;
            if(!v_us_ct.IsNGAY_KET_THUCNull())
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
        void m_sle_chon_vi_tri_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if(m_e_loai_cap_nhat == e_loai_cap_nhat.THEM_MOI)
                {
                    m_txt_so_ho_so.EditValue = ExecuteFuntion.GetSoHoSoNext(Convert.ToDecimal(m_sle_chon_don_vi.EditValue), Convert.ToDecimal(m_sle_chon_vi_tri.EditValue), Convert.ToDecimal(m_sle_chon_nhan_vien.EditValue));
                }
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
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
