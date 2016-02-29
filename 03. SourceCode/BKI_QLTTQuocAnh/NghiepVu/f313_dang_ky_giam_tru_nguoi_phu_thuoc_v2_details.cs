﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using BKI_DichVuMatDat;
using BKI_DichVuMatDat.DS;
using BKI_DichVuMatDat.US;
using BKI_DichVuMatDat.DS.CDBNames;

using System.Globalization;
using DevExpress.XtraEditors;
using IP.Core.IPCommon;

namespace BKI_DichVuMatDat.NghiepVu
{
    public partial class f313_dang_ky_giam_tru_nguoi_phu_thuoc_v2_details : Form
    {
        #region Interface

        public f313_dang_ky_giam_tru_nguoi_phu_thuoc_v2_details()
        {
            InitializeComponent();
            format_controls();
        }

        public void display_4_update(US_GD_PHU_THUOC_DETAILS ip_us)
        {
            m_us_phu_thuoc_details = ip_us;
            us_obj_2_form();
            this.ShowDialog();
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
        }

        #endregion

        #region Members

        DataEntryFormMode m_e_form_mode;
        US_GD_PHU_THUOC_DETAILS m_us_phu_thuoc_details = new US_GD_PHU_THUOC_DETAILS();
        DialogResult m_dgl_result = DialogResult.Cancel;

        #endregion

        #region Private Methods

        private void us_obj_2_form()
        {
            m_dat_ngay_bat_dau.Value = m_us_phu_thuoc_details.datTU_NGAY;
            m_dat_ngay_ket_thuc.Value = m_us_phu_thuoc_details.datDEN_NGAY;
            m_dat_ngay_sinh_npt.Value = m_us_phu_thuoc_details.datNGAY_SINH;
            m_txt_ho_ten_nguoi_phu_thuoc.Text = m_us_phu_thuoc_details.strHO_TEN_NGUOI_PHU_THUOC;
            m_txt_mst_nhan_vien.Text = m_us_phu_thuoc_details.strMA_SO_THUE;
            m_txt_quan_he.Text = m_us_phu_thuoc_details.strQUAN_HE_VOI_NGUOI_NOP_THUE;
            m_txt_quoc_tich_npt.Text = m_us_phu_thuoc_details.strQUOC_TICH;
            m_txt_so.Text = m_us_phu_thuoc_details.strTTGKS_SO;
            m_txt_quyen_so.Text = m_us_phu_thuoc_details.strTTGKS_QUYEN;
            m_txt_quoc_gia.Text = m_us_phu_thuoc_details.strTTGKS_QUOC_GIA;
            m_txt_thanh_pho.Text = m_us_phu_thuoc_details.strTTGKS_TINH_THANH;
            m_txt_quan.Text = m_us_phu_thuoc_details.strTTGKS_QUAN_HUYEN;
            m_txt_phuong.Text = m_us_phu_thuoc_details.strTTGKS_PHUONG_XA;
            m_txt_CMND_npt.Text = m_us_phu_thuoc_details.strSO_CMT_HO_CHIEU;
            m_sle_chon_nhan_vien.EditValue = m_us_phu_thuoc_details.dcID_GD_PHU_THUOC;
        }

        private void format_controls()
        {
            FormatControl.SetVisibleSimpleButton(this);
            set_define_events();
            this.CenterToScreen();
            this.KeyPreview = true;
        }

        private void set_init_form_load()
        {
            load_data_2_sle_chon_nv();
            switch (m_e_form_mode)
            {
                case DataEntryFormMode.UpdateDataState:
                    m_sle_chon_nhan_vien.Enabled = false;
                    us_obj_2_form();
                    break;
                default:
                    break;
            }
        }

        private void load_data_2_sle_chon_nv()
        {
            m_sle_chon_nhan_vien.Properties.DataSource = load_data_2_ds_v_dm_nv().V_DM_NHAN_VIEN;
            m_sle_chon_nhan_vien.Properties.ValueMember = V_DM_NHAN_VIEN.ID;
            m_sle_chon_nhan_vien.Properties.DisplayMember = V_DM_NHAN_VIEN.HO_TEN;

            m_sle_chon_nhan_vien.Properties.PopulateViewColumns();
            m_sle_chon_nhan_vien.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            m_sle_chon_nhan_vien.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
        }

        private DS_V_DM_NHAN_VIEN load_data_2_ds_v_dm_nv()
        {
            DS_V_DM_NHAN_VIEN v_ds = new DS_V_DM_NHAN_VIEN();
            US_V_DM_NHAN_VIEN v_us = new US_V_DM_NHAN_VIEN();

            v_us.FillDataset(v_ds);
            return v_ds;
        }

        private bool check_validate_data()
        {
            if (m_sle_chon_nhan_vien.EditValue == null)
            {
                CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_CHUA_CHON_NHAN_VIEN);
                return false;
            }
            return true;
        }

        private void save_data()
        {
            form_2_us_obj();
            switch (m_e_form_mode)
            {
                case DataEntryFormMode.UpdateDataState:
                    m_us_phu_thuoc_details.Update();
                    m_dgl_result = DialogResult.OK;
                    CHRM_BaseMessages.MsgBox_Infor(CONST_ID_MSGBOX.INFOR_DU_LIEU_DA_DUOC_CAP_NHAT);
                    this.Close();
                    break;
                case DataEntryFormMode.InsertDataState:
                    if (check_validate_data() == false) return;
                    m_us_phu_thuoc_details.Insert();
                    CHRM_BaseMessages.MsgBox_Infor(CONST_ID_MSGBOX.INFOR_LUU_DU_LIEU_THANH_CONG);
                    this.Close();
                    break;
                default:
                    break;
            }
        }

        private void form_2_us_obj()
        {
            m_us_phu_thuoc_details.datTU_NGAY = m_dat_ngay_bat_dau.Value;
            m_us_phu_thuoc_details.datDEN_NGAY = m_dat_ngay_ket_thuc.Value;
            m_us_phu_thuoc_details.datNGAY_SINH = m_dat_ngay_sinh_npt.Value;
            m_us_phu_thuoc_details.strHO_TEN_NGUOI_PHU_THUOC = m_txt_ho_ten_nguoi_phu_thuoc.Text;
            m_us_phu_thuoc_details.strMA_SO_THUE = m_txt_mst_nhan_vien.Text;
            m_us_phu_thuoc_details.strQUAN_HE_VOI_NGUOI_NOP_THUE = m_txt_quan_he.Text;
            m_us_phu_thuoc_details.strQUOC_TICH = m_txt_quoc_tich_npt.Text;
            m_us_phu_thuoc_details.strTTGKS_SO = m_txt_so.Text;
            m_us_phu_thuoc_details.strTTGKS_QUYEN = m_txt_quyen_so.Text;
            m_us_phu_thuoc_details.strTTGKS_QUOC_GIA = m_txt_quoc_gia.Text;
            m_us_phu_thuoc_details.strTTGKS_TINH_THANH = m_txt_thanh_pho.Text;
            m_us_phu_thuoc_details.strTTGKS_QUAN_HUYEN = m_txt_quan.Text;
            m_us_phu_thuoc_details.strTTGKS_PHUONG_XA = m_txt_phuong.Text;
            m_us_phu_thuoc_details.strSO_CMT_HO_CHIEU = m_txt_CMND_npt.Text;
            m_us_phu_thuoc_details.dcID_GD_PHU_THUOC = (decimal)m_sle_chon_nhan_vien.EditValue;
        }

        #endregion

        //
        //
        // EVENT HANDLERS
        //
        //

        private void set_define_events()
        {
            this.Load += f313_dang_ky_giam_tru_nguoi_phu_thuoc_v2_details_Load;
            m_cmd_save.Click += m_cmd_save_Click;
            m_cmd_exit.Click += m_cmd_exit_Click;
            this.KeyDown += f313_dang_ky_giam_tru_nguoi_phu_thuoc_v2_details_KeyDown;
            this.FormClosed += f313_dang_ky_giam_tru_nguoi_phu_thuoc_v2_details_FormClosed;
        }

        private void f313_dang_ky_giam_tru_nguoi_phu_thuoc_v2_details_Load(object sender, EventArgs e)
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

        void f313_dang_ky_giam_tru_nguoi_phu_thuoc_v2_details_FormClosed(object sender, FormClosedEventArgs e)
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

        void f313_dang_ky_giam_tru_nguoi_phu_thuoc_v2_details_KeyDown(object sender, KeyEventArgs e)
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
    }
}
