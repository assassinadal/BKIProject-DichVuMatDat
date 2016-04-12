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
        public void display_for_them_cong_tac_moi(decimal ip_dc_phong_ban)
        {
            setup_form_for_them_moi_qua_trinh_cong_tac(ip_dc_phong_ban);
            ShowDialog();
        }

        #endregion

        #region Members
        DataEntryFormMode m_e_form_mode = DataEntryFormMode.InsertDataState;
        decimal m_id_gd_cong_tac_moi_tao = 0;
        decimal m_id_gd_ct = 0;
        bool m_loai_ctac_cthuc = false;
        #endregion

        #region Data structure

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
            //load_data_2_sle_chon_nv();
            load_data_2_sle_chon_quyet_dinh(load_danh_sach_quyet_dinh());
            load_data_2_sle_chon_don_vi(load_danh_sach_don_vi());
            load_data_2_sle_chon_vi_tri();
            load_data_2_sle_chon_loai_cong_tac();
        }


        //load data to all controls
        private void load_data_2_sle_nhan_vien(DataTable ip_source)
        {
            m_sle_chon_nhan_vien.Properties.DataSource = ip_source;

            m_sle_chon_nhan_vien.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            m_sle_chon_nhan_vien.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
        }
        private DataTable load_danh_sach_nhan_vien_chua_co_cong_tac()
        {
            US_GD_CONG_TAC v_us_ct = new US_GD_CONG_TAC();
            return v_us_ct.LayDanhSachNhanVienChuaCoCongTac();
        }
        private DataSet load_danh_sach_tat_ca_nhan_vien()
        {
            US_V_DM_NHAN_VIEN v_us = new US_V_DM_NHAN_VIEN();
            DS_V_DM_NHAN_VIEN v_ds = new DS_V_DM_NHAN_VIEN();
            v_us.FillDataset(v_ds);

            return v_ds;
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
            m_sle_chon_vi_tri.Properties.DataSource = load_data_2_cm_dm_tu_dien(CONST_ID_LOAI_TU_DIEN.LOAI_VI_TRI).Tables[0];

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

            if (m_sle_chon_quyet_dinh.EditValue != null)
            {
                ip_us.dcID_QUYET_DINH = CIPConvert.ToDecimal(m_sle_chon_quyet_dinh.EditValue);
            }

            if (m_sle_chon_nhan_vien.EditValue != null)
            {
                ip_us.dcID_NHAN_VIEN = CIPConvert.ToDecimal(m_sle_chon_nhan_vien.EditValue);
            }

            if (m_sle_chon_don_vi.EditValue != null)
            {
                ip_us.dcID_DON_VI = CIPConvert.ToDecimal(m_sle_chon_don_vi.EditValue);
            }

            if (m_sle_chon_vi_tri.EditValue != null)
            {
                ip_us.dcID_VI_TRI = CIPConvert.ToDecimal(m_sle_chon_vi_tri.EditValue);
            }

            if (m_sle_chon_loai_cong_tac.EditValue != null)
            {
                ip_us.dcID_LOAI_CONG_TAC = CIPConvert.ToDecimal(m_sle_chon_loai_cong_tac.EditValue);
            }

            if (m_dat_ngay_bat_dau.EditValue != null)
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

            if (m_e_form_mode == DataEntryFormMode.InsertDataState)
            {
                //Ngay lap
                ip_us.datNGAY_LAP = DateTime.Now.Date;
                ip_us.strNGUOI_LAP = CAppContext_201.getCurrentUserName();
            }
            else if (m_e_form_mode == DataEntryFormMode.UpdateDataState)
            {
                //Ngay sua
                ip_us.datNGAY_SUA = DateTime.Now.Date;
                ip_us.strNGUOI_SUA = CAppContext_201.getCurrentUserName();
            }
            ip_us.strDA_XOA = "N";
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
        private void save_data()
        {
            US_GD_CONG_TAC v_us_gd_ct = new US_GD_CONG_TAC();
            form_2_us_gd_cong_tac(ref v_us_gd_ct);
            try
            {
                switch (m_e_form_mode)
                {
                    case DataEntryFormMode.InsertDataState:
                        v_us_gd_ct.Insert();
                        break;
                    case DataEntryFormMode.UpdateDataState:
                        v_us_gd_ct.Update();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception v_e)
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

            if(isNull(m_sle_chon_vi_tri.EditValue == null))
            {
                CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_CHUA_CHON_VI_TRI);
                return false;
            }

            if(isNull(m_sle_chon_loai_cong_tac.EditValue == null))
            {
                CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_CHUA_CHON_LOAI_CONG_TAC);
                return false;
            }

            if(isNull(m_dat_ngay_bat_dau.EditValue))
            {
                CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_CHUA_CHON_NGAY_BAT_DAU);
            }
            return true;
        }
        private bool kiem_tra_nhan_vien_co_cong_tac_chinh_thuc_chua()
        {
            US_GD_CONG_TAC v_us = new US_GD_CONG_TAC();
            return v_us.KiemTraNhanVienCoCongTacChinhThucChua(Convert.ToDecimal(m_sle_chon_nhan_vien.EditValue));
        }
        private bool check_logic_data()
        {
            if(kiem_tra_nhan_vien_co_cong_tac_chinh_thuc_chua())
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
        private void setup_form_for_them_moi_qua_trinh_cong_tac(decimal ip_dc_id_phong_ban)
        {
            setup_header_text("THÊM MỚI CÔNG TÁC CHO NHÂN VIÊN");
            m_sle_chon_don_vi.EditValue = ip_dc_id_phong_ban;
            m_sle_chon_don_vi.ReadOnly = true;
            m_sle_chon_loai_cong_tac.EditValue = CONST_ID_LOAI_CONG_TAC.CHINH_THUC;
            m_sle_chon_loai_cong_tac.ReadOnly = true;
            load_data_2_sle_nhan_vien(load_danh_sach_nhan_vien_chua_co_cong_tac());
            m_e_form_mode = DataEntryFormMode.InsertDataState;
        }
        private void setup_form_for_chuyen_cong_tac(decimal ip_dc_id_nhan_vien, decimal ip_dc_id_phong_ban_cu)
        {

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

        void f351_quan_ly_cong_tac_de_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
                {
                    this.Close();
                }
                if (e.KeyCode == Keys.Enter)
                {
                    //save_data();
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void f351_quan_ly_cong_tac_de_Load(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception v_e)
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
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (check_data_is_ok())
                {
                    save_data();
                    CHRM_BaseMessages.MsgBox_Infor(CONST_ID_MSGBOX.INFOR_LUU_DU_LIEU_THANH_CONG);
                    Close();
                }
            }
            catch (Exception v_e)
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
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        #endregion

    }
}
