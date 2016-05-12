using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IP.Core.IPException;
using BKI_DichVuMatDat.US;
using BKI_DichVuMatDat.DS;
using DevExpress.XtraEditors;
using IP.Core.IPCommon;
using BKI_DichVuMatDat.DS.CDBNames;

namespace BKI_DichVuMatDat.DanhMuc
{
    public partial class F110_dm_chuc_vu_de : Form
    {
        #region Members
        US_DM_CHUC_VU m_us = new US_DM_CHUC_VU();
        DataEntryFormMode m_e_form_mode;
        #endregion

        #region Public Interface
        public F110_dm_chuc_vu_de()
        {
            InitializeComponent();
            set_initial_form_load();
        }

        internal void display_for_insert()
        {
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            this.CenterToParent();
            this.ShowDialog();
        }

        internal void display_for_update(US_DM_CHUC_VU ip_us)
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            m_us = ip_us;
            us_to_form(ip_us);
            m_sle_don_vi.Enabled = false;
            this.CenterToParent();
            this.ShowDialog();
        }
        #endregion

        #region Private Method
        private void set_initial_form_load()
        {
            load_data_to_sle_don_vi();
            set_define_events();
        }

        private void load_data_to_sle_don_vi()
        {
            US_V_DM_DON_VI_2 v_us = new US_V_DM_DON_VI_2();
            DS_V_DM_DON_VI_2 v_ds = new DS_V_DM_DON_VI_2();
            v_us.FillDataset(v_ds);
            m_sle_don_vi.Properties.ValueMember = DM_DON_VI.ID;
            m_sle_don_vi.Properties.DisplayMember = DM_DON_VI.TEN_DON_VI;
            m_sle_don_vi.Properties.DataSource = v_ds.Tables[0];
        }

        private void us_to_form(US_DM_CHUC_VU ip_us)
        {
            m_sle_don_vi.EditValue = ip_us.dcID_DON_VI;
            m_txt_ma_chuc_vu.Text = ip_us.strMA_CHUC_VU;
            m_txt_ten_chuc_vu.Text = ip_us.strTEN_CHUC_VU;
            m_txt_thu_tu.Text = ip_us.dcSO_THU_TU.ToString();
            m_txt_ghi_chu.Text = ip_us.strGHI_CHU;
        }

        private bool check_validate_data()
        {
            if (m_sle_don_vi.EditValue == null)
            {
                string v_str_error = "Bạn chưa chọn đơn vị!";
                XtraMessageBox.Show(v_str_error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (m_txt_ma_chuc_vu.Text.Trim() == "")
            {
                string v_str_error = "Bạn chưa nhập mã chức vụ!";
                XtraMessageBox.Show(v_str_error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (m_txt_ten_chuc_vu.Text.Trim() == "")
            {
                string v_str_error = "Bạn chưa nhập tên chức vụ!";
                XtraMessageBox.Show(v_str_error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (m_txt_thu_tu.Text.Trim() == "")
            {
                string v_str_error = "Bạn chưa nhập thứ tự chức vụ!";
                XtraMessageBox.Show(v_str_error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (check_ma_cv_da_ton_tai())
            {
                string v_str_error = "Mã chức vụ đã tồn tại!";
                XtraMessageBox.Show(v_str_error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool check_ma_cv_da_ton_tai()
        {
            US_DM_CHUC_VU v_us = new US_DM_CHUC_VU();
            DS_DM_CHUC_VU v_ds = new DS_DM_CHUC_VU();
            v_us.FillDataset(v_ds, "where ma_chuc_vu = N'" + m_txt_ma_chuc_vu.Text +"'");
            if (m_us.strMA_CHUC_VU != m_txt_ma_chuc_vu.Text && v_ds.Tables[0].Rows.Count !=0)
            {
                return true;
            }
            return false;
        }

        private void save_data()
        {
            us_to_form();
            switch (m_e_form_mode)
            {
                case DataEntryFormMode.InsertDataState:
                    m_us.Insert();
                    break;
                case DataEntryFormMode.UpdateDataState:
                    m_us.Update();
                    break;
                default:
                    break;
            }
            XtraMessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void us_to_form()
        {
            m_us.strMA_CHUC_VU = m_txt_ma_chuc_vu.Text;
            m_us.strTEN_CHUC_VU = m_txt_ten_chuc_vu.Text;
            m_us.dcSO_THU_TU = CIPConvert.ToDecimal(m_txt_thu_tu.Text);        
            m_us.dcID_DON_VI = CIPConvert.ToDecimal(m_sle_don_vi.EditValue);
            m_us.strGHI_CHU = m_txt_ghi_chu.Text;
        }
        #endregion

        #region Event Handler
        private void set_define_events()
        {
            m_cmd_save.Click += m_cmd_save_Click;
        }

        void m_cmd_save_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (check_validate_data())
                {
                    save_data();
                }
            }
            catch (System.Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        #endregion

    }
}
