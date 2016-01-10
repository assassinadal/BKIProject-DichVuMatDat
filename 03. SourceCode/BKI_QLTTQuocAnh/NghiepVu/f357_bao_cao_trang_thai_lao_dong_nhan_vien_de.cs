using BKI_DichVuMatDat.DS;
using BKI_DichVuMatDat.DS.CDBNames;
using BKI_DichVuMatDat.US;
using DevExpress.XtraEditors;
using IP.Core.IPCommon;
using IP.Core.IPSystemAdmin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BKI_DichVuMatDat.NghiepVu
{
    public partial class f357_bao_cao_trang_thai_lao_dong_nhan_vien_de : Form
    {
        #region Public interface
        public void display_4_insert(ref decimal v_id_gd_trang_thai_lao_dong_moi_tao)
        {
            this.Text = "F357 - THAY ĐỔI TRẠNG THÁI LAO ĐỘNG CỦA NHÂN VIÊN";
            m_lbl_header.Text = "Thay đổi trạng thái lao động của nhân viên";
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            this.CenterToScreen();
            this.ShowDialog();

            v_id_gd_trang_thai_lao_dong_moi_tao = m_id_gd_trang_thai_lao_dong_moi_tao;
        }

        public void display_4_update(US_GD_TRANG_THAI_LAO_DONG ip_us)
        {
            this.Text = "F357 - CẬP NHẬT TRẠNG THÁI LAO ĐỘNG CỦA NHÂN VIÊN";
            m_lbl_header.Text = "Cập nhật trạng thái lao động của nhân viên";
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            m_sle_chon_nhan_vien.EditValue = ip_us.dcID_NHAN_VIEN;
            m_id_gd_trang_thai_lao_dong_4_update = ip_us.dcID;
            m_sle_chon_trang_thai_lao_dong.EditValue = ip_us.dcID_TRANG_THAI_LAO_DONG;
            if (ip_us.datNGAY_AP_DUNG == null)
            {
                m_dat_ngay_ap_dung.EditValue = DateTime.Now.Date;
            }
            else
            {
                m_dat_ngay_ap_dung.EditValue = ip_us.datNGAY_AP_DUNG;
            }
            m_txt_ghi_chu.Text = ip_us.strGHI_CHU;
            this.CenterToScreen();
            this.ShowDialog();
        }
        #endregion

        #region Member
        DataEntryFormMode m_e_form_mode = DataEntryFormMode.InsertDataState;
        decimal m_id_gd_trang_thai_lao_dong_moi_tao = 0;
        decimal m_id_gd_trang_thai_lao_dong_4_update = 0;
        #endregion

        #region Private methods
        public f357_bao_cao_trang_thai_lao_dong_nhan_vien_de()
        {
            InitializeComponent();
            format_controls();
        }

        private void format_controls()
        {
            FormatControl.SetVisibleSimpleButton(this);
            set_define_events();
            this.KeyPreview = true;
        }

        private void set_init_form_load()
        {
            load_data_2_sle_chon_nhan_vien();
            load_data_2_sle_chon_trang_thai_lao_dong();
            if (m_e_form_mode == DataEntryFormMode.InsertDataState)
            {
                m_dat_ngay_ap_dung.EditValue = DateTime.Now.Date;
            }
        }

        private DS_V_DM_NHAN_VIEN load_data_2_ds_v_dm_nv()
        {
            DS_V_DM_NHAN_VIEN v_ds = new DS_V_DM_NHAN_VIEN();
            US_V_DM_NHAN_VIEN v_us = new US_V_DM_NHAN_VIEN();

            v_us.FillDataset(v_ds);
            return v_ds;
        }

        private void load_data_2_sle_chon_nhan_vien()
        {
            m_sle_chon_nhan_vien.Properties.DataSource = load_data_2_ds_v_dm_nv().V_DM_NHAN_VIEN;
            m_sle_chon_nhan_vien.Properties.ValueMember = V_DM_NHAN_VIEN.ID;
            m_sle_chon_nhan_vien.Properties.DisplayMember = V_DM_NHAN_VIEN.HO_TEN;

            m_sle_chon_nhan_vien.Properties.PopulateViewColumns();
            m_sle_chon_nhan_vien.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            m_sle_chon_nhan_vien.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
        }

        private DS_V_DM_TRANG_THAI_LAO_DONG load_data_2_ds_v_dm_trang_thai_ld()
        {
            DS_V_DM_TRANG_THAI_LAO_DONG v_ds = new DS_V_DM_TRANG_THAI_LAO_DONG();
            US_V_DM_TRANG_THAI_LAO_DONG v_us = new US_V_DM_TRANG_THAI_LAO_DONG();

            v_us.FillDataset(v_ds);
            return v_ds;
        }

        private void load_data_2_sle_chon_trang_thai_lao_dong()
        {
            m_sle_chon_trang_thai_lao_dong.Properties.DataSource = load_data_2_ds_v_dm_trang_thai_ld().V_DM_TRANG_THAI_LAO_DONG;
            m_sle_chon_trang_thai_lao_dong.Properties.ValueMember = V_DM_TRANG_THAI_LAO_DONG.ID;
            m_sle_chon_trang_thai_lao_dong.Properties.DisplayMember = V_DM_TRANG_THAI_LAO_DONG.TEN_TRANG_THAI_LD;

            m_sle_chon_trang_thai_lao_dong.Properties.PopulateViewColumns();
            m_sle_chon_trang_thai_lao_dong.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            m_sle_chon_trang_thai_lao_dong.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
        }


        private void form_2_us_obj(US_GD_TRANG_THAI_LAO_DONG v_us_gd_trang_thai_lao_dong)
        {
            v_us_gd_trang_thai_lao_dong.dcID_NHAN_VIEN = (decimal)m_sle_chon_nhan_vien.EditValue;
            v_us_gd_trang_thai_lao_dong.dcID_TRANG_THAI_LAO_DONG = (decimal)m_sle_chon_trang_thai_lao_dong.EditValue;
            v_us_gd_trang_thai_lao_dong.datNGAY_AP_DUNG = m_dat_ngay_ap_dung.DateTime.Date;
            if (m_e_form_mode == DataEntryFormMode.InsertDataState)
            {
                v_us_gd_trang_thai_lao_dong.datNGAY_LAP = DateTime.Now.Date;
                v_us_gd_trang_thai_lao_dong.strNGUOI_LAP = CAppContext_201.getCurrentUserName();
            }
            else
            {
                v_us_gd_trang_thai_lao_dong.datNGAY_SUA = DateTime.Now.Date;
                v_us_gd_trang_thai_lao_dong.strNGUOI_SUA = CAppContext_201.getCurrentUserName();
            }
            v_us_gd_trang_thai_lao_dong.strGHI_CHU = m_txt_ghi_chu.Text;
            v_us_gd_trang_thai_lao_dong.strDA_XOA = "N";
        }

        private void save_data()
        {
            US_GD_TRANG_THAI_LAO_DONG v_us_gd_trang_thai_lao_dong = new US_GD_TRANG_THAI_LAO_DONG();
           

            try
            {
                switch (m_e_form_mode)
                {
                    case DataEntryFormMode.InsertDataState:
                        form_2_us_obj(v_us_gd_trang_thai_lao_dong);
                        v_us_gd_trang_thai_lao_dong.BeginTransaction();
                        v_us_gd_trang_thai_lao_dong.Insert();
                        v_us_gd_trang_thai_lao_dong.CommitTransaction();
                        m_id_gd_trang_thai_lao_dong_moi_tao = v_us_gd_trang_thai_lao_dong.dcID;
                        if (CHRM_BaseMessages.MsgBox_Confirm(CONST_ID_MSGBOX.QUESTION_XAC_NHAN_THEM_DU_LIEU_THANH_CONG_TIEP_TUC_INSERT_YN) == true)
                        {
                            refresh_form();
                        }
                        else
                        {
                            this.Close();
                        }
                        break;
                    case DataEntryFormMode.UpdateDataState:
                        v_us_gd_trang_thai_lao_dong.dcID = m_id_gd_trang_thai_lao_dong_4_update;
                        form_2_us_obj(v_us_gd_trang_thai_lao_dong);
                        v_us_gd_trang_thai_lao_dong.BeginTransaction();
                        v_us_gd_trang_thai_lao_dong.Update();
                        v_us_gd_trang_thai_lao_dong.CommitTransaction();
                        CHRM_BaseMessages.MsgBox_Infor(CONST_ID_MSGBOX.INFOR_DU_LIEU_DA_DUOC_CAP_NHAT);
                        this.Close();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception v_e)
            {
                throw v_e;
            }      
        }

        private void refresh_form()
        {
            m_sle_chon_nhan_vien.EditValue = null;
            m_sle_chon_trang_thai_lao_dong.EditValue = null;
            m_dat_ngay_ap_dung.EditValue = DateTime.Now.Date;
            m_txt_ghi_chu.Text = "";
        }

        private bool check_validate_data()
        {
            if (m_sle_chon_nhan_vien.EditValue == null)
            {
                CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_CHUA_CHON_NHAN_VIEN);
                return false;
            }

            if (m_sle_chon_trang_thai_lao_dong.EditValue == null)
            {
                CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_CHUA_CHON_TRANG_THAI_LAO_DONG);
                return false;
            }

            if (m_dat_ngay_ap_dung.EditValue == null)
            {
                CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_CHUA_CHON_NGAY_AP_DUNG);
                return false;
            }

            return true;
        }

        #endregion

        private void set_define_events()
        {
            this.Load += f357_bao_cao_trang_thai_lao_dong_nhan_vien_de_Load;
            m_cmd_save.Click += m_cmd_save_Click;
            m_cmd_exit.Click += m_cmd_exit_Click;
            this.KeyDown += f357_bao_cao_trang_thai_lao_dong_nhan_vien_de_KeyDown;
            this.FormClosed += f357_bao_cao_trang_thai_lao_dong_nhan_vien_de_FormClosed;
        }

        void f357_bao_cao_trang_thai_lao_dong_nhan_vien_de_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
                {
                    this.Close();
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_exit_Click(object sender, EventArgs e)
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

        private void m_cmd_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (check_validate_data())
                {
                    if (CHRM_BaseMessages.MsgBox_Confirm(CONST_ID_MSGBOX.QUESTION_XAC_NHAN_LUU_DU_LIEU) == true)
                    {
                        save_data();
                    }
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void f357_bao_cao_trang_thai_lao_dong_nhan_vien_de_Load(object sender, EventArgs e)
        {
            try
            {
                set_init_form_load();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void f357_bao_cao_trang_thai_lao_dong_nhan_vien_de_FormClosed(object sender, FormClosedEventArgs e)
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

    }
}
