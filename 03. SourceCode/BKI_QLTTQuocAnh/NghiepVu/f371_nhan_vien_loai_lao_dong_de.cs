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
        #endregion

        #region Members
        DataEntryFormMode m_e_form_mode = new DataEntryFormMode();
        decimal m_id_gd_loai_ld = 0;
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

        private void form_2_us_gd_loai_lao_dong(US_GD_LOAI_LAO_DONG ip_us)
        {
            ip_us.dcID_NHAN_VIEN = CIPConvert.ToDecimal(m_sle_chon_nhan_vien.EditValue);
            ip_us.dcID_LOAI_LAO_DONG = CIPConvert.ToDecimal(m_sle_chon_loai_lao_dong.EditValue);
            ip_us.datNGAY_BAT_DAU = m_dat_ngay_bat_dau.Value.Date;
            ip_us.datNGAY_KET_THUC = m_dat_ngay_ket_thuc.Value.Date;
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

        private void save_data()
        {
            US_GD_LOAI_LAO_DONG v_us_gd_loai_lao_dong = new US_GD_LOAI_LAO_DONG();
            form_2_us_gd_loai_lao_dong(v_us_gd_loai_lao_dong);
            try
            {
                if (m_e_form_mode == DataEntryFormMode.InsertDataState)
                {
                    load_data_2_m_variable();
                    if (m_id_gd_loai_ld != 0)
                    {
                        MessageBox.Show("Nhân viên nãy đã tồn tại loại lao động! Nếu bạn muốn SỬA thông tin cho nhân viên vui lòng chọn nút SỬA!", "THÔNG BÁO!");
                    }
                    else
                    {
                        v_us_gd_loai_lao_dong.BeginTransaction();
                        v_us_gd_loai_lao_dong.Insert();
                        v_us_gd_loai_lao_dong.CommitTransaction();
                    }
                }
                else //if (m_e_form_mode == DataEntryFormMode.UpdateDataState)
                {
                    v_us_gd_loai_lao_dong.BeginTransaction();
                    v_us_gd_loai_lao_dong.Update();
                    v_us_gd_loai_lao_dong.CommitTransaction();
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        #endregion

        private void set_define_event()
        {
            this.Load += f371_nhan_vien_loai_lao_dong_insert_Load;

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

        private void m_cmd_cancel_Click(object sender, EventArgs e)
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

        public void DisplayForInsert()
        {
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            this.ShowDialog();
        }

        public void DisplayForUpdate(US_GD_LOAI_LAO_DONG v_us)
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            us_2_form(v_us);
            this.ShowDialog();
        }

        private void us_2_form(US_GD_LOAI_LAO_DONG v_us)
        {
            m_sle_chon_nhan_vien.EditValue = v_us.dcID_NHAN_VIEN;
            m_sle_chon_loai_lao_dong.EditValue = v_us.dcID_LOAI_LAO_DONG;
            m_dat_ngay_bat_dau.Value = v_us.datNGAY_BAT_DAU;
            m_dat_ngay_ket_thuc.Value = v_us.datNGAY_KET_THUC;
        }

    }
}
