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
using IP.Core.IPCommon;
using BKI_DichVuMatDat.DS.CDBNames;
using DevExpress.XtraEditors;
using System.Globalization;
using IP.Core.IPSystemAdmin;

namespace BKI_DichVuMatDat.DanhMuc
{
    public partial class F101_dm_don_vi : Form
    {
        public F101_dm_don_vi()
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

        #region private methods
        private void format_controls()
        {
            //FormatControl.SetVisibleSimpleButton(this);
            set_define_events();
            this.KeyPreview = true;
        }

        private void set_initial_form_load()
        {
            load_data_2_tree();
        }

        private void load_data_2_tree()
        {
            US_V_DM_DON_VI_2 v_us_dv = new US_V_DM_DON_VI_2();
            DS_V_DM_DON_VI_2 v_ds_dv = new DS_V_DM_DON_VI_2();
            v_us_dv.FillDataset(v_ds_dv);

            m_tree_don_vi.ParentFieldName = DM_DON_VI.ID_DON_VI_CAP_TREN;
            m_tree_don_vi.DataSource = v_ds_dv.Tables[0];
            m_tree_don_vi.RefreshDataSource();

            m_tree_don_vi.ExpandAll();
        }
        private decimal get_id_phong_ban()
        {
            return Convert.ToDecimal(m_tree_don_vi.FocusedNode.GetValue("ID"));
        }
        #endregion

        private void set_define_events()
        {
            this.Load += F105_dm_don_vi_Load;
            m_cmd_insert.Click += m_cmd_insert_Click;
            m_cmd_update.Click += m_cmd_update_Click;
            m_cmd_delete.Click += m_cmd_delete_Click;
        }

        void F105_dm_don_vi_Load(object sender, EventArgs e)
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

        void m_cmd_insert_Click(object sender, EventArgs e)
        {
            try
            {
                F101_dm_don_vi_de v_f = new F101_dm_don_vi_de();
                v_f.display_4_insert();
                load_data_2_tree();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_update_Click(object sender, EventArgs e)
        {
            try
            {
                F101_dm_don_vi_de v_f = new F101_dm_don_vi_de();
                decimal v_id_don_vi = CIPConvert.ToDecimal(m_tree_don_vi.FocusedNode.GetValue("ID"));
                US_DM_DON_VI v_us = new US_DM_DON_VI(v_id_don_vi);
                v_f.display_4_update(v_us);
                load_data_2_tree();
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
                decimal v_id_don_vi = CIPConvert.ToDecimal(m_tree_don_vi.FocusedNode.GetValue("ID"));
                if (check_validate_data(v_id_don_vi))
                {
                    string v_str_confirm = "Bạn có chắc chắn muốn xóa đơn vị này?";
                    DialogResult v_dialog = XtraMessageBox.Show(v_str_confirm, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if ( v_dialog == DialogResult.Yes)
                    {
                        US_DM_DON_VI v_us = new US_DM_DON_VI(v_id_don_vi);
                        v_us.Delete();
                        XtraMessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        load_data_2_tree();
                    }               
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private bool check_validate_data(decimal ip_id_don_vi)
        {
            if (check_ct_dang_su_dung(ip_id_don_vi))
            {
                string v_str_error = "Hiện có nhân viên đang công tác tại đơn vị này. Không thể xóa!";
                XtraMessageBox.Show(v_str_error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (check_hd_dang_su_dung(ip_id_don_vi))
            {
                string v_str_error = "Hiện có nhân viên đang có hợp đồng tại đơn vị này. Không thể xóa!";
                XtraMessageBox.Show(v_str_error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (check_cv_dang_su_dung(ip_id_don_vi))
            {
                string v_str_error = "Hiện có chức vụ đang thuộc đơn vị này. Không thể xóa!";
                XtraMessageBox.Show(v_str_error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool check_ct_dang_su_dung(decimal ip_id_don_vi)
        {
            US_GD_CONG_TAC v_us_ct = new US_GD_CONG_TAC();
            DS_GD_CONG_TAC v_ds_ct = new DS_GD_CONG_TAC();
            v_us_ct.FillDataset(v_ds_ct, "where id_don_vi = " + ip_id_don_vi);
            if (v_ds_ct.Tables[0].Rows.Count == 0)
            {
                return false;
            }
            else return true;
        }

        private bool check_hd_dang_su_dung(decimal ip_id_don_vi)
        {
            US_GD_HOP_DONG v_us_hd = new US_GD_HOP_DONG();
            DS_GD_HOP_DONG v_ds_hd = new DS_GD_HOP_DONG();
            v_us_hd.FillDataset(v_ds_hd, "where id_don_vi =" + ip_id_don_vi);
            if (v_ds_hd.Tables[0].Rows.Count == 0)
            {
                return false;
            }
            else return true;
        }

        private bool check_cv_dang_su_dung(decimal ip_id_don_vi)
        {
            US_DM_CHUC_VU v_us = new US_DM_CHUC_VU();
            DS_DM_CHUC_VU v_ds = new DS_DM_CHUC_VU();
            v_us.FillDataset(v_ds, "where id_don_vi = " + ip_id_don_vi);
            if (v_ds.Tables[0].Rows.Count == 0)
            {
                return false;
            }
            else return true;
        }
    }
}
