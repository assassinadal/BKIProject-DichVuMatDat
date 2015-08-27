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

namespace BKI_DichVuMatDat.NghiepVu
{
    public partial class f370_nhan_vien_loai_lao_dong : Form
    {
        public f370_nhan_vien_loai_lao_dong()
        {
            InitializeComponent();
            format_controls();
        }

        #region Public Interface
        private void display()
        {
            this.ShowDialog();
        }
        #endregion

        #region Members
        DataEntryFormMode m_e_form_mode = DataEntryFormMode.InsertDataState;

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

        private void load_data_2_grid(decimal ip_dc_id_nv)
        {
            CCommon.make_stt(m_grv_v_gd_loai_lao_dong);
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();

            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithQuery(v_ds, "Select * from V_GD_LOAI_LAO_DONG WHERE ID = " +ip_dc_id_nv);
            m_grc_v_gd_loai_lao_dong.DataSource = v_ds.Tables[0];
        }

        private void load_data_2_grid(decimal ip_dc_id_nv, decimal ip_dc_id_loai_ld)
        {
            CCommon.make_stt(m_grv_v_gd_loai_lao_dong);

            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();

            v_ds.Tables.Add(new DataTable());

            v_us.FillDatasetWithQuery(v_ds, "select * from V_GD_LOAI_LAO_DONG WHere ID = " + ip_dc_id_nv + " AND ID_LOAI_LAO_DONG = " + ip_dc_id_loai_ld);
            m_grc_v_gd_loai_lao_dong.DataSource = v_ds.Tables[0];
        }

        //Check data is ok
        private void check_data_is_ok()
        {
            if (m_sle_chon_nhan_vien.EditValue == null || m_sle_chon_nhan_vien.EditValue == "")
            {
                MessageBox.Show("Bạn phải chọn nhân viên", "THÔNG BÁO!");
                return;
            }
        }
        #endregion
        private void f370_nhan_vien_loai_lao_dong_Load(object sender, EventArgs e)
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

        private void set_define_event()
        {
            this.Load += f370_nhan_vien_loai_lao_dong_Load;

            m_sle_chon_loai_lao_dong.EditValueChanged += m_sle_chon_loai_lao_dong_EditValueChanged;
            m_sle_chon_nhan_vien.EditValueChanged += m_sle_chon_nhan_vien_EditValueChanged;
        }

        private void m_sle_chon_nhan_vien_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (m_sle_chon_nhan_vien.EditValue == null || m_sle_chon_nhan_vien.EditValue == "")
                {
                    return;
                }
                if (m_sle_chon_loai_lao_dong.EditValue == null || m_sle_chon_loai_lao_dong.EditValue == "")
                {
                    load_data_2_grid(CIPConvert.ToDecimal(m_sle_chon_nhan_vien.EditValue));
                }
                else
                {
                    load_data_2_grid(CIPConvert.ToDecimal(m_sle_chon_nhan_vien.EditValue), CIPConvert.ToDecimal(m_sle_chon_loai_lao_dong.EditValue));
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_sle_chon_loai_lao_dong_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (m_sle_chon_nhan_vien.EditValue == null || m_sle_chon_nhan_vien.EditValue == "")
                {
                    return;
                }
                if ((m_sle_chon_nhan_vien.EditValue != null || m_sle_chon_nhan_vien.EditValue != "") && (m_sle_chon_loai_lao_dong.EditValue == null || m_sle_chon_loai_lao_dong.EditValue == ""))
                {
                    load_data_2_grid(CIPConvert.ToDecimal(m_sle_chon_nhan_vien.EditValue));
                }
                if ((m_sle_chon_loai_lao_dong.EditValue != null && m_sle_chon_loai_lao_dong.EditValue != "") && (m_sle_chon_nhan_vien.EditValue != null && m_sle_chon_nhan_vien.EditValue != ""))
                {
                    load_data_2_grid(CIPConvert.ToDecimal(m_sle_chon_nhan_vien.EditValue), CIPConvert.ToDecimal(m_sle_chon_loai_lao_dong.EditValue));
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
    }
}
