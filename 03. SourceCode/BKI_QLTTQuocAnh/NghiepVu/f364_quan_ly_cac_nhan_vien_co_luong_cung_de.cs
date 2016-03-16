using System;
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
using IP.Core.IPSystemAdmin;

namespace BKI_DichVuMatDat.NghiepVu
{
    public partial class f364_quan_ly_cac_nhan_vien_co_luong_cung_de : Form
    {
        #region Interface

        public f364_quan_ly_cac_nhan_vien_co_luong_cung_de()
        {
            InitializeComponent();
            format_controls();
        }

        public void display_4_update(US_GD_LUONG_CUNG ip_us)
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            this.m_lbl_header.Text = "SỬA THÔNG TIN LƯƠNG CỨNG";
            m_us_gd_luong_cung = ip_us;
            us_obj_2_form();
            this.ShowDialog();         
        }

        public void display_4_insert()
        {
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            this.m_lbl_header.Text = "THÊM THÔNG TIN LƯƠNG CỨNG";
            clear_data_in_form();
            this.ShowDialog();
          
        }
        public void display_4_insert(decimal ip_id_nv)
        {
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            this.m_lbl_header.Text = "THÊM THÔNG TIN LƯƠNG CỨNG";
            m_sle_chon_nhan_vien.EditValue = ip_id_nv;
            this.m_txt_so_tien.Text = "";
            this.m_txt_ghi_chu.Text = "";
            this.ShowDialog();

        }

        #endregion

        #region Members

        DataEntryFormMode m_e_form_mode = DataEntryFormMode.InsertDataState;
        US_GD_LUONG_CUNG m_us_gd_luong_cung = new US_GD_LUONG_CUNG();
        DialogResult m_dgl_result = DialogResult.Cancel;
        #endregion

        #region Private Methods

        private void us_obj_2_form()
        {
            m_dat_ngay_bat_dau.Value = m_us_gd_luong_cung.datNGAY_BAT_DAU;
            m_dat_ngay_ket_thuc.Value = m_us_gd_luong_cung.datNGAY_KET_THUC;
            m_sle_chon_nhan_vien.EditValue = m_us_gd_luong_cung.dcID_NHAN_VIEN;
            m_txt_so_tien.Text = m_us_gd_luong_cung.dcSO_TIEN.ToString();
            m_txt_ghi_chu.Text = m_us_gd_luong_cung.strGHI_CHU;
        }

        private void format_controls()
        {
            //FormatControl.SetVisibleSimpleButton(this);
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
                case DataEntryFormMode.InsertDataState:
                    m_sle_chon_nhan_vien.Enabled = true;
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
            form_2_us_obj(m_us_gd_luong_cung);
            switch (m_e_form_mode)
            {
                case DataEntryFormMode.UpdateDataState:
                    m_us_gd_luong_cung.Update();
                    m_dgl_result = DialogResult.OK;
                    CHRM_BaseMessages.MsgBox_Infor(CONST_ID_MSGBOX.INFOR_DU_LIEU_DA_DUOC_CAP_NHAT);
                    this.Close();
                    break;
                case DataEntryFormMode.InsertDataState:
                    if (check_validate_data() == false) return;
                    m_us_gd_luong_cung.Insert();
                    CHRM_BaseMessages.MsgBox_Infor(CONST_ID_MSGBOX.INFOR_LUU_DU_LIEU_THANH_CONG);
                    this.Close();
                    break;
                default:
                    break;
            }
        }

        private void clear_data_in_form()
        {
            m_sle_chon_nhan_vien.EditValue = null;
            m_txt_ghi_chu.Text = "";
            m_txt_so_tien.Text = "";
        }

        private void form_2_us_obj(US_GD_LUONG_CUNG ip_us)
        {
            if (m_e_form_mode == DataEntryFormMode.UpdateDataState)
            {
                ip_us.datNGAY_SUA = DateTime.Now.Date;
                //nguoi sua
                ip_us.strNGUOI_SUA = CAppContext_201.getCurrentUserName();
            }
            else
            {
                ip_us.datNGAY_LAP = DateTime.Now.Date;
                //nguoi lap
                ip_us.strDA_XOA = "N";
                ip_us.strNGUOI_LAP = CAppContext_201.getCurrentUserName();
            }
            ip_us.dcID_NHAN_VIEN = CIPConvert.ToDecimal(m_sle_chon_nhan_vien.EditValue);
            ip_us.dcSO_TIEN = CIPConvert.ToDecimal(m_txt_so_tien.Text.Trim());
            ip_us.datNGAY_BAT_DAU = m_dat_ngay_bat_dau.Value.Date;
            ip_us.datNGAY_KET_THUC = m_dat_ngay_ket_thuc.Value.Date;
            ip_us.strGHI_CHU = m_txt_ghi_chu.Text.Trim();
        }

        #endregion

        //
        //
        // EVENT HANDLERS
        //
        //

        private void set_define_events()
        {
            this.Load += f364_quan_ly_cac_nhan_vien_co_luong_cung_de_Load;
            this.KeyDown += f364_quan_ly_cac_nhan_vien_co_luong_cung_de_KeyDown;
            this.FormClosed += f364_quan_ly_cac_nhan_vien_co_luong_cung_de_FormClosed;
            this.m_txt_so_tien.Leave += m_txt_so_tien_Leave;
            this.m_sle_chon_nhan_vien.EditValueChanged += m_sle_chon_nhan_vien_EditValueChanged;
            this.m_cmd_save.Click += m_cmd_save_Click;
            this.m_cmd_exit.Click += m_cmd_exit_Click;
        }

        private void f364_quan_ly_cac_nhan_vien_co_luong_cung_de_Load(object sender, EventArgs e)
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

        void f364_quan_ly_cac_nhan_vien_co_luong_cung_de_FormClosed(object sender, FormClosedEventArgs e)
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

        void f364_quan_ly_cac_nhan_vien_co_luong_cung_de_KeyDown(object sender, KeyEventArgs e)
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
        void m_txt_so_tien_Leave(object sender, EventArgs e)
        {
            try
            {
                CHRMCommon.format_text_2_money(m_txt_so_tien);
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        void m_sle_chon_nhan_vien_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (m_sle_chon_nhan_vien.EditValue == null) return;
                decimal id_nv = CIPConvert.ToDecimal(m_sle_chon_nhan_vien.EditValue);
                decimal id_gd = find_id_gd_luong_cung(id_nv);
                if(id_gd!=-1 & m_e_form_mode == DataEntryFormMode.InsertDataState)
                {
                    if (CHRM_BaseMessages.MsgBox_Confirm("Hiện tại nhân viên này đã có lương cứng. Bạn có muốn cập nhật thông tin?") == true)
                    {
                        m_e_form_mode = DataEntryFormMode.UpdateDataState;
                        m_us_gd_luong_cung = new US_GD_LUONG_CUNG(id_gd);
                        us_obj_2_form();
                    }
                    else
                    {
                        if (m_e_form_mode == DataEntryFormMode.InsertDataState)
                        {
                            clear_data_in_form();
                        }
                        if (m_e_form_mode == DataEntryFormMode.UpdateDataState)
                        {
                            this.Close();
                        }
                    }
                }
                else
                {
                    
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private decimal find_id_gd_luong_cung(decimal ip_dc_id_nhan_vien)
        {
            US_GD_LUONG_CUNG v_us = new US_GD_LUONG_CUNG();
            DS_GD_LUONG_CUNG v_ds = new DS_GD_LUONG_CUNG();
            v_us.FillDataset(v_ds);
            string v_str_filter = "ID_NHAN_VIEN = " + ip_dc_id_nhan_vien + " AND DA_XOA = 'N'";
            DataRow[] v_dr = v_ds.Tables[0].Select(v_str_filter);
            if (v_dr.Count() == 0)
            {
                return -1;
            }
            else
            {
                return CIPConvert.ToDecimal(v_dr.First()["ID"].ToString());
            }
        }

    }
}
