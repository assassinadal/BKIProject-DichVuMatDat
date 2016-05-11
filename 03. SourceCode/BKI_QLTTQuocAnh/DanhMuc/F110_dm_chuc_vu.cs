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
    public partial class F110_dm_chuc_vu : Form
    {
        #region Public Interface
        public F110_dm_chuc_vu()
        {
            InitializeComponent();
            set_initial_form_load();
        }
        #endregion

        #region Members
        #endregion

        #region Private method
        private void set_initial_form_load()
        {
            load_data_to_tree();
            set_define_events();
        }

        private void load_data_to_tree()
        {
            US_V_DM_DON_VI_2 v_us = new US_V_DM_DON_VI_2();
            DS_V_DM_DON_VI_2 v_ds = new DS_V_DM_DON_VI_2();
            v_us.FillDataset(v_ds);
            m_tree_don_vi.ParentFieldName = DM_DON_VI.ID_DON_VI_CAP_TREN;
            m_tree_don_vi.DataSource = v_ds.Tables[0];
            m_tree_don_vi.ExpandAll();
        }

        private void load_data_to_grid()
        {
            decimal v_id_don_vi= CIPConvert.ToDecimal(m_tree_don_vi.FocusedNode.GetValue("ID"));
            US_V_DM_CHUC_VU v_us = new US_V_DM_CHUC_VU();
            DS_V_DM_CHUC_VU v_ds = new DS_V_DM_CHUC_VU();
            v_us.FillDataset(v_ds, "where id_don_vi =" + v_id_don_vi);
            m_grc.DataSource = v_ds.Tables[0];
        }

        private bool check_validate_data(decimal ip_id_chuc_vu)
        {
            if (check_ct_dang_su_dung(ip_id_chuc_vu))
            {
                string v_str_error = "Hiện đang có hợp đồng làm việc tại vị trí này.\nKhông thể xóa!";
                XtraMessageBox.Show(v_str_error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (check_hd_dang_su_dung(ip_id_chuc_vu))
            {
                string v_str_error = "Hiện đang có công tác tại vị trí này. Không thể xóa!";
                XtraMessageBox.Show(v_str_error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool check_ct_dang_su_dung(decimal ip_id_chuc_vu)
        {
            US_GD_CONG_TAC v_us_ct = new US_GD_CONG_TAC();
            DS_GD_CONG_TAC v_ds_ct = new DS_GD_CONG_TAC();
            v_us_ct.FillDataset(v_ds_ct, "where id_vi_tri = " + ip_id_chuc_vu);
            if (v_ds_ct.Tables[0].Rows.Count == 0)
            {
                return false;
            }
            else return true;
        }

        private bool check_hd_dang_su_dung(decimal ip_id_chuc_vu)
        {
            US_GD_HOP_DONG v_us_hd = new US_GD_HOP_DONG();
            DS_GD_HOP_DONG v_ds_hd = new DS_GD_HOP_DONG();
            v_us_hd.FillDataset(v_ds_hd, "where id_chuc_vu =" + ip_id_chuc_vu);
            if (v_ds_hd.Tables[0].Rows.Count == 0)
            {
                return false;
            }
            else return true;
        }
        #endregion

        #region Event Handler
        private void set_define_events()
        {
            this.Load += F110_dm_chuc_vu_Load;
            m_tree_don_vi.Click += m_tree_don_vi_Click;
            m_cmd_insert.Click += m_cmd_insert_Click;
            m_cmd_update.Click += m_cmd_update_Click;
            m_cmd_delete.Click += m_cmd_delete_Click;
        }

        void m_cmd_delete_Click(object sender, EventArgs e)
        {
            try
            {
                decimal v_id_chuc_vu = CIPConvert.ToDecimal(m_grv.GetDataRow(m_grv.FocusedRowHandle)[DM_CHUC_VU.ID]);
                if (check_validate_data(v_id_chuc_vu))
                {
                    string v_str_confirm = "Bạn có chắn chắn muốn xóa chức vụ này?";
                    DialogResult v_dialog = XtraMessageBox.Show(v_str_confirm, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (v_dialog == DialogResult.Yes)
                    {
                        US_DM_CHUC_VU v_us = new US_DM_CHUC_VU(v_id_chuc_vu);
                        v_us.Delete();
                        XtraMessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        load_data_to_grid();
                    }                   
                }
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
                F110_dm_chuc_vu_de v_f = new F110_dm_chuc_vu_de();
                decimal v_id_chuc_vu = CIPConvert.ToDecimal(m_grv.GetDataRow(m_grv.FocusedRowHandle)[DM_CHUC_VU.ID]);
                US_DM_CHUC_VU v_us = new US_DM_CHUC_VU(v_id_chuc_vu);
                v_f.display_for_update(v_us);
                load_data_to_grid();
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
                F110_dm_chuc_vu_de v_f = new F110_dm_chuc_vu_de();
                v_f.display_for_insert();
                load_data_to_grid();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_tree_don_vi_Click(object sender, EventArgs e)
        {
            try
            {
                load_data_to_grid();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void F110_dm_chuc_vu_Load(object sender, EventArgs e)
        {
            try
            {
                load_data_to_grid();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        #endregion
    }
}
