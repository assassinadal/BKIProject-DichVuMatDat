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
    public partial class f371_nhan_vien_loai_lao_dong_de : Form
    {
        public f371_nhan_vien_loai_lao_dong_de()
        {
            InitializeComponent();
            format_controls();
        }

        #region Public Interface
        public void display()
        {
            this.ShowDialog();
        }

        public void DisplayForInsert()
        {
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            this.Text = "F371 - Thêm nhân viên loại lao động";
            m_lbl_header.Text = "THÊM NHÂN VIÊN LOẠI LAO ĐỘNG";
            this.CenterToScreen();
            this.ShowDialog();
        }

        public void DisplayForUpdate(US_GD_LOAI_LAO_DONG v_us)
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            this.Text = "F371 - Sửa nhân viên loại lao động";
            m_lbl_header.Text = "SỬA NHÂN VIÊN LOẠI LAO ĐỘNG";
            m_us = v_us;
            us_2_form(m_us);
            this.CenterToScreen();
            this.ShowDialog();
        }
        #endregion

        #region Members
        DataEntryFormMode m_e_form_mode = new DataEntryFormMode();
        decimal m_id_gd_loai_ld = 0;
        US_GD_LOAI_LAO_DONG m_us = new US_GD_LOAI_LAO_DONG();
        #endregion

        #region Private Methods

        private void format_controls()
        {
            FormatControl.SetVisibleSimpleButton(this);
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

        private void form_2_us_gd_loai_lao_dong(US_GD_LOAI_LAO_DONG m_us)
        {
            m_us.dcID_NHAN_VIEN = CIPConvert.ToDecimal(m_sle_chon_nhan_vien.EditValue);
            m_us.dcID_LOAI_LAO_DONG = CIPConvert.ToDecimal(m_sle_chon_loai_lao_dong.EditValue);
            m_us.datNGAY_BAT_DAU = m_dat_ngay_bat_dau.Value.Date;
            m_us.datNGAY_KET_THUC = m_dat_ngay_ket_thuc.Value.Date;
        }

        //Check data is ok?
        private bool check_data_is_ok()
        {
            if (m_sle_chon_nhan_vien.EditValue == null || m_sle_chon_nhan_vien.EditValue == "")
            {
                MessageBox.Show("Bạn phải chọn nhân viên", "THÔNG BÁO!");
                return false;
            }
            if (m_sle_chon_loai_lao_dong.EditValue == null || m_sle_chon_loai_lao_dong.EditValue == "")
            {
                MessageBox.Show("Bạn phải chọn loại lao động", "THÔNG BÁO!");
                return false;
            }

            if (m_dat_ngay_bat_dau.Value.Date == null || m_dat_ngay_bat_dau.Value.Date.ToString() == "")
            {
                MessageBox.Show("Bạn phải chọn ngày bắt đầu", "THÔNG BÁO!");
                return false;
            }
            if (m_dat_ngay_ket_thuc.Value.Date == null || m_dat_ngay_ket_thuc.Value.Date.ToString() == "")
            {
                MessageBox.Show("Bạn phải chọn ngày kết thúc", "THÔNG BÁO!");
                return false;
            }
            return true;
        }

        private void load_data_2_m_variable()
        {
            m_id_gd_loai_ld = find_id_gd_nv_loai_ld(CIPConvert.ToDecimal(m_sle_chon_nhan_vien.EditValue));
        }

        //Tim id_nhan_vien da co trong bang GD_LOAI_LAO_DONG
        //Neu nhan vien da co loai lao dong thi khong the them duoc ma chi co the sua

        private decimal find_id_gd_nv_loai_ld(decimal ip_dc_id_nv)
        {
            US_GD_LOAI_LAO_DONG v_us = new US_GD_LOAI_LAO_DONG();
            DS_GD_LOAI_LAO_DONG v_ds = new DS_GD_LOAI_LAO_DONG();

            v_us.FillDataset(v_ds);
            string v_str_filter = "ID_NHAN_VIEN = " + ip_dc_id_nv;
            DataRow[] v_dr = v_ds.GD_LOAI_LAO_DONG.Select(v_str_filter);

            if (v_dr.Count() == 0)
            {
                return 0; // m_id_gd_loai_ld = 0 tuc la trong bang GD_LOAI_LAO_DONG chua co nhan vien nay
            }
            else return 1; // m_id_gd_loai_ld = 1 tuc la trong bang GD_LOAI_LAO_DONG da co nhan vien nay
        }

        #endregion

        private void set_define_event()
        {
            this.Load += f371_nhan_vien_loai_lao_dong_insert_Load;
            m_cmd_save.Click += m_cmd_save_Click;
            m_cmd_exit.Click += m_cmd_exit_Click;
        }

        private void f371_nhan_vien_loai_lao_dong_insert_Load(object sender, EventArgs e)
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

        private void us_2_form(US_GD_LOAI_LAO_DONG m_us)
        {
            m_sle_chon_nhan_vien.EditValue = m_us.dcID_NHAN_VIEN;
            m_sle_chon_loai_lao_dong.EditValue = m_us.dcID_LOAI_LAO_DONG;
            m_dat_ngay_bat_dau.Value = m_us.datNGAY_BAT_DAU;
            m_dat_ngay_ket_thuc.Value = m_us.datNGAY_KET_THUC;
        }

        private void m_cmd_save_Click(object sender, EventArgs e)
        {
            try
            {
                //Kiem tra du lieu
                if (check_data_is_ok() == true)
                {
                    //Dua du lieu vao US
                    form_2_us_gd_loai_lao_dong(m_us);
                    if (m_e_form_mode == DataEntryFormMode.InsertDataState)
                    {
                        load_data_2_m_variable();
                        if (m_id_gd_loai_ld != 0)
                        {
                            MessageBox.Show("Nhân viên nãy đã tồn tại loại lao động! Nếu bạn muốn SỬA thông tin cho nhân viên vui lòng chọn nút SỬA!", "THÔNG BÁO!");
                        }
                        else
                        {
                            m_us.Insert();
                        }
                    }
                    else
                    {
                        m_us.Update();
                    }
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

    }
}
