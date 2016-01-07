using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IP.Core.IPCommon;
using BKI_DichVuMatDat.US;
using BKI_DichVuMatDat.DS;
using DevExpress.XtraEditors;
using IP.Core.IPSystemAdmin;
using BKI_DichVuMatDat.DS.CDBNames;

namespace BKI_DichVuMatDat.NghiepVu
{
    public partial class f356_bao_cao_trang_thai_lao_dong_cua_nhan_vien : Form
    {       
        #region Public Interface

        #endregion

        #region Members
        decimal m_load_data_toan_bo_nv = -1;
        DS_V_F356_BAO_CAO_TRANG_THAI_LAO_DONG_CUA_NHAN_VIEN m_ds = new DS_V_F356_BAO_CAO_TRANG_THAI_LAO_DONG_CUA_NHAN_VIEN();
        US_V_F356_BAO_CAO_TRANG_THAI_LAO_DONG_CUA_NHAN_VIEN m_us = new US_V_F356_BAO_CAO_TRANG_THAI_LAO_DONG_CUA_NHAN_VIEN();

        #endregion

        #region Private Methods
        public f356_bao_cao_trang_thai_lao_dong_cua_nhan_vien()
        {
            InitializeComponent();
            format_controls();
        }

        private void format_controls()
        {
            FormatControl.SetVisibleSimpleButton(this);
            this.m_grv_bao_cao_trang_thai_lao_dong_nhan_vien.OptionsPrint.AutoWidth = false;
            set_define_events();
            this.KeyPreview = true;
        }

        private void set_init_form_load()
        {
            load_data_2_sle_chon_nhan_vien();
            load_data_2_grid();
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

        private void load_data_2_grid()
        {
            DS_V_F356_BAO_CAO_TRANG_THAI_LAO_DONG_CUA_NHAN_VIEN v_ds_v_f356 = new DS_V_F356_BAO_CAO_TRANG_THAI_LAO_DONG_CUA_NHAN_VIEN();
            US_V_F356_BAO_CAO_TRANG_THAI_LAO_DONG_CUA_NHAN_VIEN v_us_v_f356 = new US_V_F356_BAO_CAO_TRANG_THAI_LAO_DONG_CUA_NHAN_VIEN();
            if (m_sle_chon_nhan_vien.EditValue == null)
            {
                v_us_v_f356.FillDataset_toan_bo_nv(v_ds_v_f356, m_load_data_toan_bo_nv);
            }
            else
            {
                v_us_v_f356.FillDataset_by_id_nv(v_ds_v_f356, (decimal)m_sle_chon_nhan_vien.EditValue);
            }
        }

        #endregion

        private void set_define_events()
        {
            this.Load += f356_bao_cao_trang_thai_lao_dong_cua_nhan_vien_Load;
            this.FormClosed += f356_bao_cao_trang_thai_lao_dong_cua_nhan_vien_FormClosed;
            m_cmd_search.Click += m_cmd_search_Click;
        }

        void m_cmd_search_Click(object sender, EventArgs e)
        {
            try
            {
                load_data_2_grid();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void f356_bao_cao_trang_thai_lao_dong_cua_nhan_vien_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Dispose();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void f356_bao_cao_trang_thai_lao_dong_cua_nhan_vien_Load(object sender, EventArgs e)
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

    }
}
