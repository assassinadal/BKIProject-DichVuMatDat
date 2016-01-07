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

            m_grc_bao_cao_trang_thai_lao_dong_nhan_vien.DataSource = v_ds_v_f356.V_F356_BAO_CAO_TRANG_THAI_LAO_DONG_CUA_NHAN_VIEN;
            m_grc_bao_cao_trang_thai_lao_dong_nhan_vien.RefreshDataSource();
        }

        private void focus_new_row_created(decimal ip_dc_id_gd_trang_thai_lao_dong_moi_tao)
        {
            int v_row_index = 0;
            decimal v_id_gd_trang_thai_lao_dong_moi_tao = 0;

            US_V_F356_BAO_CAO_TRANG_THAI_LAO_DONG_CUA_NHAN_VIEN v_us = new US_V_F356_BAO_CAO_TRANG_THAI_LAO_DONG_CUA_NHAN_VIEN();
            DS_V_F356_BAO_CAO_TRANG_THAI_LAO_DONG_CUA_NHAN_VIEN v_ds = new DS_V_F356_BAO_CAO_TRANG_THAI_LAO_DONG_CUA_NHAN_VIEN();

            v_id_gd_trang_thai_lao_dong_moi_tao = ip_dc_id_gd_trang_thai_lao_dong_moi_tao;

            v_us.FillDataset(v_ds);

            for (v_row_index = 0; v_row_index < v_ds.Tables[0].Rows.Count; v_row_index++)
            {
                var v_id_gd_trang_thai_lao_dong = CIPConvert.ToDecimal(m_grv_bao_cao_trang_thai_lao_dong_nhan_vien.GetDataRow(v_row_index)["ID"].ToString());

                if (v_id_gd_trang_thai_lao_dong == v_id_gd_trang_thai_lao_dong_moi_tao)
                {
                    break;
                }
            }

            m_grv_bao_cao_trang_thai_lao_dong_nhan_vien.FocusedRowHandle = v_row_index;
        }

        #endregion

        private void set_define_events()
        {
            this.Load += f356_bao_cao_trang_thai_lao_dong_cua_nhan_vien_Load;
            this.FormClosed += f356_bao_cao_trang_thai_lao_dong_cua_nhan_vien_FormClosed;
            m_cmd_search.Click += m_cmd_search_Click;
            m_cmd_delete.Click += m_cmd_delete_Click;
            m_cmd_insert.Click += m_cmd_insert_Click;
        }

        void m_cmd_insert_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    decimal v_id_gd_trang_thai_lao_dong_moi_tao = 0;
                    f357_bao_cao_trang_thai_lao_dong_nhan_vien_de v_frm = new f357_bao_cao_trang_thai_lao_dong_nhan_vien_de();
                    v_frm.display_4_insert(ref v_id_gd_trang_thai_lao_dong_moi_tao);
                    load_data_2_grid();

                    focus_new_row_created(v_id_gd_trang_thai_lao_dong_moi_tao);
                }
                catch (Exception v_e)
                {
                    CSystemLog_301.ExceptionHandle(v_e);
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (CHRM_BaseMessages.MsgBox_Confirm(CONST_ID_MSGBOX.QUESTION_XAC_NHAN_XOA_DU_LIEU) == true)
                {
                    DataRow v_dr = m_grv_bao_cao_trang_thai_lao_dong_nhan_vien.GetDataRow(m_grv_bao_cao_trang_thai_lao_dong_nhan_vien.FocusedRowHandle);
                    decimal v_id_gd_trang_thai_lao_dong = CIPConvert.ToDecimal(v_dr["ID"]);

                    US_GD_TRANG_THAI_LAO_DONG v_us = new US_GD_TRANG_THAI_LAO_DONG(v_id_gd_trang_thai_lao_dong);
                    v_us.strDA_XOA = "Y";
                    v_us.datNGAY_SUA = DateTime.Now.Date;
                    v_us.strNGUOI_SUA = CAppContext_201.getCurrentUserName();
                    v_us.BeginTransaction();
                    v_us.Update();
                    v_us.CommitTransaction();
                    CHRM_BaseMessages.MsgBox_Infor(CONST_ID_MSGBOX.INFOR_DU_LIEU_DA_DUOC_CAP_NHAT);
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
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
