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
namespace BKI_DichVuMatDat.NghiepVu
{
    public partial class frm356_chuyen_trang_thai_lao_dong : Form
    {
        #region Field
        DS_V_DM_NHAN_VIEN m_ds_nhan_vien;
        #endregion

        #region Public Interface
        public frm356_chuyen_trang_thai_lao_dong()
        {
            InitializeComponent();
            format_control();
            fill_data_2_sle_nhan_vien();
            fill_data_2_le_trang_thai_lao_dong();
        }
        ~frm356_chuyen_trang_thai_lao_dong()
        {
            Dispose(false);
        }

        
        #endregion

        #region Private Method
        private void fill_data_2_sle_nhan_vien()
        {
            US_V_DM_NHAN_VIEN v_us_nhan_vien = new US_V_DM_NHAN_VIEN();
            m_ds_nhan_vien = new DS_V_DM_NHAN_VIEN();
            m_ds_nhan_vien.EnforceConstraints = false;

            v_us_nhan_vien.FillDataset(m_ds_nhan_vien);

            m_sle_chon_nhan_vien.Properties.DataSource = m_ds_nhan_vien.Tables[0];
        }
        private void fill_data_2_le_trang_thai_lao_dong()
        {
            US_CM_DM_TU_DIEN v_us = new US_CM_DM_TU_DIEN();
            DS_CM_DM_TU_DIEN v_ds = new DS_CM_DM_TU_DIEN();
            v_us.FillDataset(v_ds, "where ID_LOAI_TU_DIEN = " + CONST_ID_LOAI_TU_DIEN.TRANG_THAI_LAO_DONG);
            m_le_trang_thai_hien_tai.Properties.DataSource = v_ds.Tables[0];
        }
        private void fill_data_2_grid()
        {
            US_GD_TRANG_THAI_LAO_DONG v_us = new US_GD_TRANG_THAI_LAO_DONG();
            DS_GD_TRANG_THAI_LAO_DONG v_ds = new DS_GD_TRANG_THAI_LAO_DONG();

           // v_us.fill_data_lich_su_lao_dong(v_ds, (decimal)m_sle_chon_nhan_vien.EditValue);
            m_grc_lich_su_lao_dong.DataSource = v_ds.Tables[0];
            m_grc_lich_su_lao_dong.RefreshDataSource();
        }
        private void format_control()
        {
            set_define_event();
        }
        private void set_inital_form_load()
        {
            m_sle_chon_nhan_vien.CustomDisplayText += m_sle_chon_nhan_vien_CustomDisplayText;
            m_sle_chon_nhan_vien.EditValueChanged += m_sle_chon_nhan_vien_EditValueChanged;

            m_cmd_save.Enabled = false;
            panelControlSave.Enabled = false;
        }


        private void select_trang_thai_by_nhan_vien(decimal ip_id_nhan_vien)
        {
            US_GD_TRANG_THAI_LAO_DONG v_us = new US_GD_TRANG_THAI_LAO_DONG();
           // var id_trang_thai_ld = v_us.get_id_trang_thai_lao_dong(ip_id_nhan_vien);
            //m_le_trang_thai_hien_tai.EditValue = id_trang_thai_ld;
        }
        private void save_data()
        {
            US_GD_TRANG_THAI_LAO_DONG v_us = new US_GD_TRANG_THAI_LAO_DONG();
            //v_us.thay_doi_trang_thai_lao_dong((decimal)m_sle_chon_nhan_vien.EditValue, (decimal)m_le_trang_thai_hien_tai.EditValue, DateTime.Now, CAppContext_201.getCurrentUserName());
            CHRM_BaseMessages.MsgBox_Infor(CONST_ID_MSGBOX.INFOR_LUU_DU_LIEU_THANH_CONG);
            fill_data_2_grid();
            labelControlNhacNho.Text = "";
        }
        #endregion

        #region Event Handle
        private void set_define_event()
        {
            FormClosed += frm356_chuyen_trang_thai_lao_dong_FormClosed;
            Load += frm356_chuyen_trang_thai_lao_dong_Load;
            m_cmd_exit.Click += m_cmd_exit_Click;
            m_cmd_save.Click += m_cmd_save_Click;
        }
        void m_le_trang_thai_hien_tai_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (m_sle_chon_nhan_vien.EditValue == null)
                {
                    return;
                }
                US_GD_TRANG_THAI_LAO_DONG v_us = new US_GD_TRANG_THAI_LAO_DONG();
                //var id_trang_thai_ld = v_us.get_id_trang_thai_lao_dong((decimal)m_sle_chon_nhan_vien.EditValue);
                var id_trang_thai_ld = 0;
                if (id_trang_thai_ld != (decimal)m_le_trang_thai_hien_tai.EditValue)
                {
                    m_cmd_save.Enabled = true;
                    panelControlSave.Enabled = true;
                    labelControlNhacNho.Text = "Bạn vừa thay đổi trạng thái LĐ. Nhấn Lưu để cập nhật!";
                }
                else
                {
                    m_cmd_save.Enabled = false;
                    panelControlSave.Enabled = false;
                    labelControlNhacNho.Text = "...";
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        void m_cmd_save_Click(object sender, EventArgs e)
        {
            try
            {
                US_GD_TRANG_THAI_LAO_DONG v_us = new US_GD_TRANG_THAI_LAO_DONG();

                if (m_cmd_save.Enabled == false)
                {
                    return;
                }
                save_data();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_exit_Click(object sender, EventArgs e)
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
        void m_sle_chon_nhan_vien_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                panelControlSave.Enabled = false;
                labelControlNhacNho.Text = "...";
                select_trang_thai_by_nhan_vien((decimal)m_sle_chon_nhan_vien.EditValue);
                m_le_trang_thai_hien_tai.EditValueChanged += m_le_trang_thai_hien_tai_EditValueChanged;
                fill_data_2_grid();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        void m_sle_chon_nhan_vien_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {

            try
            {
                SearchLookUpEdit edit = sender as SearchLookUpEdit;
                if (e.Value != null)
                {
                    var str_text = m_ds_nhan_vien.Tables[0].Select("ID = " + e.Value)[0]["MA_NV"].ToString() + " - " + e.DisplayText;
                    e.DisplayText = str_text;
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void frm356_chuyen_trang_thai_lao_dong_Load(object sender, EventArgs e)
        {
            try
            {
                set_inital_form_load();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void frm356_chuyen_trang_thai_lao_dong_FormClosed(object sender, FormClosedEventArgs e)
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
        #endregion
    }
}
