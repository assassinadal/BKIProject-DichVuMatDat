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
            throw new NotImplementedException();
        }

        void m_cmd_update_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        void m_cmd_insert_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
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
