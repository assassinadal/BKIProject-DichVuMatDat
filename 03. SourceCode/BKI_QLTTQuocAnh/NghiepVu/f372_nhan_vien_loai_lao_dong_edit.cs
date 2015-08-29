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

namespace BKI_DichVuMatDat.NghiepVu
{
    public partial class f372_nhan_vien_loai_lao_dong_edit : Form
    {
        public f372_nhan_vien_loai_lao_dong_edit()
        {
            InitializeComponent();
            format_controls();
        }

        #region Public Interface
        public void display()
        {
            this.ShowDialog();
        }
        #endregion

        #region Members
        DataEntryFormMode m_e_form_mode = DataEntryFormMode.UpdateDataState;
        #endregion

        #region Private Methods
        private void format_controls()
        {
            set_define_event();
            this.KeyPreview = true;
        }

        private void set_initial_form_load()
        {
            load_data_2_sle_chon_nv();
            load_data_2_sle_chon_loai_lao_dong();
        }

        private DataSet load_data_2_ds_v_dm_nv()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();

            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithTableName(v_ds, "V_DM_NHAN_VIEN");
            return v_ds;
        }

        private void load_data_2_sle_chon_nv()
        {
            m_sle_chon_nhan_vien.Properties.DataSource = load_data_2_ds_v_dm_nv().Tables[0];

            m_sle_chon_nhan_vien.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            m_sle_chon_nhan_vien.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
        }

        private DataSet load_data_2_cm_dm_tu_dien(int ip_dc_id_vt)
        {
            US_CM_DM_TU_DIEN v_us = new US_CM_DM_TU_DIEN();
            DS_CM_DM_TU_DIEN v_ds = new DS_CM_DM_TU_DIEN();

            v_us.FillDatasetByIdLoaiTuDien(v_ds, ip_dc_id_vt);
            return v_ds;
        }

        private void load_data_2_sle_chon_loai_lao_dong()
        {
            m_sle_chon_loai_lao_dong.Properties.DataSource = load_data_2_cm_dm_tu_dien(CONST_ID_LOAI_TU_DIEN.LOAI_LAO_DONG).Tables[0];

            m_sle_chon_nhan_vien.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            m_sle_chon_nhan_vien.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
        }

        //Load toan bo du lieu tu V_GD_LOAI_LAO_DONG len luoi 

        private void form_2_us_gd_loai_lao_dong(US_GD_LOAI_LAO_DONG ip_us)
        {
            if (m_sle_chon_nhan_vien.EditValue != null && m_sle_chon_nhan_vien.EditValue != "")
            {
                ip_us.dcID_NHAN_VIEN = CIPConvert.ToDecimal(m_sle_chon_nhan_vien.EditValue);
            }
            if (m_sle_chon_loai_lao_dong.EditValue != null && m_sle_chon_loai_lao_dong.EditValue != "")
            {
                ip_us.dcID_LOAI_LAO_DONG = CIPConvert.ToDecimal(m_sle_chon_loai_lao_dong.EditValue);
            }
            if (m_dat_ngay_bat_dau.Value.Date != null || m_dat_ngay_bat_dau.Value.Date.ToString() != "")
            {
                ip_us.datNGAY_BAT_DAU = m_dat_ngay_bat_dau.Value.Date;
            }
            if (m_dat_ngay_ket_thuc.Value.Date != null || m_dat_ngay_ket_thuc.Value.Date.ToString() != "")
            {
                ip_us.datNGAY_KET_THUC = m_dat_ngay_ket_thuc.Value.Date;
            }
        }

        //Check data is ok?
        private bool check_data_is_ok()
        {
            if (m_sle_chon_nhan_vien.EditValue == null || m_sle_chon_nhan_vien.EditValue == "")
            {
                MessageBox.Show("Nhân viên không được trống!", "THÔNG BÁO!");
                return false;
            }
            if (m_sle_chon_loai_lao_dong.EditValue == null || m_sle_chon_loai_lao_dong.EditValue == "")
            {
                MessageBox.Show("Loại lao động không được trống!", "THÔNG BÁO!");
                return false;
            }
            if (m_dat_ngay_bat_dau.Value.Date == null || m_dat_ngay_bat_dau.Value.Date.ToString() == "")
            {
                MessageBox.Show("Ngày bắt đầu không được trống!", "THÔNG BÁO!");
                return false;
            }
            return true;
        }

        //Lay du lieu cua dong muon sua
        private void get_data_row_nv_loai_lao_dong()
        {
            //Lay ID cua dong du lieu can sua tu V_GD_LOAI_LAO_DONG

        }

        private void save_data()
        {
            decimal ip_id_dc_nv = CIPConvert.ToDecimal(m_sle_chon_nhan_vien.EditValue);
            US_GD_LOAI_LAO_DONG v_us_gd_loai_lao_dong = new US_GD_LOAI_LAO_DONG(ip_id_dc_nv);

            v_us_gd_loai_lao_dong.dcID_LOAI_LAO_DONG = CIPConvert.ToDecimal(m_sle_chon_loai_lao_dong.EditValue);
            v_us_gd_loai_lao_dong.datNGAY_BAT_DAU = m_dat_ngay_bat_dau.Value.Date;
            v_us_gd_loai_lao_dong.datNGAY_KET_THUC = m_dat_ngay_ket_thuc.Value.Date;
            v_us_gd_loai_lao_dong.BeginTransaction();
            v_us_gd_loai_lao_dong.Update();
            v_us_gd_loai_lao_dong.CommitTransaction();

        }
        #endregion

        private void set_define_event()
        {
            this.Load += f372_nhan_vien_loai_lao_dong_edit_Load;
        }

        private void f372_nhan_vien_loai_lao_dong_edit_Load(object sender, EventArgs e)
        {
            try
            {
                set_initial_form_load();
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
                if (check_data_is_ok() == true)
                {
                    save_data();
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
