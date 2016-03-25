﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BKI_DichVuMatDat.DS;
using BKI_DichVuMatDat.DS.CDBNames;
using BKI_DichVuMatDat.US;
using DevExpress.XtraEditors;
using IP.Core.IPCommon;
using IP.Core.IPSystemAdmin;

namespace BKI_DichVuMatDat.NghiepVu
{
    public partial class f368_quan_ly_nv_ko_dong_bao_hiem_de : Form
    {
        #region Public Interfaces
        public f368_quan_ly_nv_ko_dong_bao_hiem_de()
        {
            InitializeComponent();
            format_controls();
        }
        public void display_4_insert(decimal id_nv)
        {
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            m_sle_chon_nhan_vien.EditValue = id_nv;
            this.ShowDialog();
        }
        public void display_4_insert()
        {
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            m_thang_goi_y = DateTime.Now.Month.ToString();
            m_nam_goi_y = DateTime.Now.Year.ToString();
            this.ShowDialog();
        }
        public void display_4_insert(string thang, string nam)
        {
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            m_thang_goi_y = m_txt_chon_thang.Text = thang;
            m_nam_goi_y = m_txt_chon_nam.Text = nam;
            this.ShowDialog();
        }
        public void display_4_update(US_GD_KHONG_DONG_BAO_HIEM ip_us_ko_bh)
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            v_us_dang_sua = ip_us_ko_bh;
            us_obj_2_form(ip_us_ko_bh);
            this.ShowDialog();
        }
        #endregion
        #region Members
        US_GD_KHONG_DONG_BAO_HIEM v_us_dang_sua = new US_GD_KHONG_DONG_BAO_HIEM();
        DataEntryFormMode m_e_form_mode;
        string m_thang_goi_y;
        string m_nam_goi_y;
        #endregion
        #region Data Structures
        #endregion
        #region Private Methods
        private void format_controls()
        {
            FormatControl.SetVisibleSimpleButton(this);
            set_define_events();
            this.CenterToScreen();
            this.KeyPreview = true;
        }

        private void set_define_events()
        {
            m_cmd_save.Click += m_cmd_save_Click;
            m_cmd_exit.Click += m_cmd_exit_Click;
            Load += f368_quan_ly_nv_ko_dong_bao_hiem_de_Load;
            m_sle_chon_nhan_vien.EditValueChanged += M_sle_chon_nhan_vien_EditValueChanged;
            m_txt_chon_thang.Leave += M_txt_chon_thang_Leave;
        }



        private DS_V_DM_NHAN_VIEN load_data_2_ds_v_dm_nv()
        {
            DS_V_DM_NHAN_VIEN v_ds = new DS_V_DM_NHAN_VIEN();
            US_V_DM_NHAN_VIEN v_us = new US_V_DM_NHAN_VIEN();
            v_us.FillDataset(v_ds);
            return v_ds;
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
        private void set_init_form_load()
        {
            switch (m_e_form_mode)
            {
                case DataEntryFormMode.UpdateDataState:
                    m_sle_chon_nhan_vien.Enabled = false;
                    break;
                case DataEntryFormMode.InsertDataState:
                    break;
                default:
                    break;
            }
            load_data_2_sle_chon_nv();
        }

        private void form_2_us_luong_cung(US_GD_KHONG_DONG_BAO_HIEM ip_us)
        {
            if (m_e_form_mode == DataEntryFormMode.UpdateDataState)
            {
                ip_us.dcID = v_us_dang_sua.dcID;
                //nguoi sua
                ip_us.strNGUOI_LAP = CAppContext_201.getCurrentUserName();
                ip_us.datNGAY_LAP = v_us_dang_sua.datNGAY_LAP;
            }
            else
            {
                ip_us.datNGAY_LAP = DateTime.Now.Date;
                //nguoi lap
                ip_us.strNGUOI_LAP = CAppContext_201.getCurrentUserName();
            }
            ip_us.dcTHANG = CIPConvert.ToDecimal(m_txt_chon_thang.Text.Trim());
            ip_us.dcNAM = CIPConvert.ToDecimal(m_txt_chon_nam.Text.Trim());
            ip_us.dcID_NHAN_VIEN = CIPConvert.ToDecimal(m_sle_chon_nhan_vien.EditValue);
            ip_us.strLY_DO = m_txt_ly_do.Text.Trim();
        }

        private void us_obj_2_form(US_GD_KHONG_DONG_BAO_HIEM ip_us)
        {
            m_sle_chon_nhan_vien.EditValue = ip_us.dcID_NHAN_VIEN;
            m_txt_chon_thang.Text = ip_us.dcTHANG.ToString();
            m_txt_chon_nam.Text = ip_us.dcNAM.ToString();
            m_txt_ly_do.Text = ip_us.strLY_DO;
        }

        private bool check_data_is_ok()
        {
            if (m_sle_chon_nhan_vien.EditValue == null || m_sle_chon_nhan_vien.EditValue == "")
            {
                CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_CHUA_CHON_NHAN_VIEN);
                return false;
            }

            if (m_txt_chon_thang.Text == "")
            {
                CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_CHUA_CHON_THANG);
                return false;
            }

            if (m_txt_chon_nam.Text == "")
            {
                CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_CHUA_CHON_NAM);
                return false;
            }
            if (CHRMCommon.thang_da_chot_bang_luong(CIPConvert.ToDecimal(m_txt_chon_thang.Text.Trim()), CIPConvert.ToDecimal(m_txt_chon_nam.Text.Trim())))
            {
                CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_THANG_DA_CHOT_BANG_LUONG);
                return false;
            }
            return true;
        }

        private void clear_data_in_form()
        {
            m_txt_chon_nam.Text = m_nam_goi_y;
            m_txt_chon_thang.Text = m_thang_goi_y;
            m_txt_ly_do.Text = "";
        }

        private void save_data()
        {
            US_GD_KHONG_DONG_BAO_HIEM v_us_gd_khong_dong_bao_hiem = new US_GD_KHONG_DONG_BAO_HIEM();
            form_2_us_luong_cung(v_us_gd_khong_dong_bao_hiem);
            try
            {
                switch (m_e_form_mode)
                {
                    case DataEntryFormMode.InsertDataState:
                        v_us_gd_khong_dong_bao_hiem.BeginTransaction();
                        v_us_gd_khong_dong_bao_hiem.Insert();
                        v_us_gd_khong_dong_bao_hiem.CommitTransaction();
                        CHRM_BaseMessages.MsgBox_Infor(CONST_ID_MSGBOX.INFOR_LUU_DU_LIEU_THANH_CONG);
                        break;
                    case DataEntryFormMode.UpdateDataState:
                        v_us_gd_khong_dong_bao_hiem.BeginTransaction();
                        v_us_gd_khong_dong_bao_hiem.Update();
                        v_us_gd_khong_dong_bao_hiem.CommitTransaction();
                        CHRM_BaseMessages.MsgBox_Infor(CONST_ID_MSGBOX.INFOR_DU_LIEU_DA_DUOC_CAP_NHAT);
                        break;
                    default:
                        break;
                }
            }
            catch (Exception v_e)
            {
                v_us_gd_khong_dong_bao_hiem.Rollback();
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private decimal find_id_gd_khong_dong_bao_hiem(decimal id_nv, string thang, string nam)
        {
            try
            {
                US_GD_KHONG_DONG_BAO_HIEM v_us = new US_GD_KHONG_DONG_BAO_HIEM();
                DS_GD_KHONG_DONG_BAO_HIEM v_ds = new DS_GD_KHONG_DONG_BAO_HIEM();

                v_us.FillDataset(v_ds);

                string v_str_filter = "ID_NHAN_VIEN =" + id_nv + " AND THANG = " + thang + "AND NAM = " + nam;
                DataRow[] v_dr = v_ds.GD_KHONG_DONG_BAO_HIEM.Select(v_str_filter);

                if (v_dr.Count() == 0)
                {
                    return -1;
                }
                else
                {
                    return CIPConvert.ToDecimal(v_dr.First()["ID"].ToString());
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
                return -1;
            }

        }
        #endregion
        //
        //EVENT HANDLERS
        //
        private void f368_quan_ly_nv_ko_dong_bao_hiem_de_Load(object sender, EventArgs e)
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
                if (check_data_is_ok())
                {
                    if (CHRM_BaseMessages.MsgBox_Confirm(CONST_ID_MSGBOX.QUESTION_XAC_NHAN_LUU_DU_LIEU))
                    {
                        save_data();
                        this.Close();
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

        private void M_sle_chon_nhan_vien_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (m_sle_chon_nhan_vien.EditValue == null | m_sle_chon_nhan_vien.EditValue == "")
                {
                    clear_data_in_form();
                }
                else
                {
                    decimal id_nv = CIPConvert.ToDecimal(m_sle_chon_nhan_vien.EditValue);
                    decimal id_gd_ko_dong_bh = find_id_gd_khong_dong_bao_hiem(id_nv, m_txt_chon_thang.Text, m_txt_chon_nam.Text);
                    if (id_gd_ko_dong_bh == -1)
                    {
                        return;
                    }
                    else
                    {
                        if (CHRM_BaseMessages.MsgBox_Confirm("Nhân viên đã có thông tin không đóng bảo hiểm tháng " + m_thang_goi_y + " năm " + m_nam_goi_y + ". Bạn có muốn sửa?") == true)
                        {
                            m_e_form_mode = DataEntryFormMode.UpdateDataState;
                            US_GD_KHONG_DONG_BAO_HIEM v_us = new US_GD_KHONG_DONG_BAO_HIEM(id_gd_ko_dong_bh);
                            m_txt_chon_thang.Text = v_us.dcTHANG.ToString();
                            m_txt_chon_nam.Text = v_us.dcNAM.ToString();
                            m_txt_ly_do.Text = v_us.strLY_DO;
                        }
                        else
                        {
                            clear_data_in_form();
                        }
                    }
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void M_txt_chon_thang_Leave(object sender, EventArgs e)
        {
            try
            {
                if (m_txt_chon_thang.Text == "" | Convert.ToInt16(m_txt_chon_thang.Text) < 1 | Convert.ToInt16(m_txt_chon_thang.Text) > 12)
                {
                    CHRM_BaseMessages.MsgBox_Warning("Tháng không hợp lệ!");
                    m_txt_chon_thang.Text = m_thang_goi_y;
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

    }
}