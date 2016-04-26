using BKI_DichVuMatDat.DS;
using BKI_DichVuMatDat.DS.CDBNames;
using BKI_DichVuMatDat.US;
using IP.Core.IPCommon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BKI_DichVuMatDat.NghiepVu.NhanSu
{
    public partial class f311_danh_sach_nhan_vien_theo_don_vi : Form
    {
        #region Public Interfaces
        public f311_danh_sach_nhan_vien_theo_don_vi()
        {
            InitializeComponent();
            format_controls();
        }
        #endregion
        

        #region Private Methods
        private void format_controls()
        {
            set_define_events();
        }
        private void set_initial_form_load()
        {
            load_data_2_tree();
        }
        private void load_data_2_tree()
        {
            US_DM_DON_VI v_us_dv = new US_DM_DON_VI();
            DS_DM_DON_VI v_ds_dv = new DS_DM_DON_VI();
            v_us_dv.FillDataset(v_ds_dv);

            m_tree_don_vi.ParentFieldName = DM_DON_VI.ID_DON_VI_CAP_TREN;
            m_tree_don_vi.DataSource = v_ds_dv.Tables[0];
            m_tree_don_vi.RefreshDataSource();

            m_tree_don_vi.ExpandAll();
        }
        private void load_data_danh_sach_nhan_vien_theo_don_vi(decimal ip_dc_id_don_vi)
        {
            US_V_GD_MA_TRA_CUU_NHAN_VIEN v_us = new US_V_GD_MA_TRA_CUU_NHAN_VIEN();
            DS_V_GD_MA_TRA_CUU_NHAN_VIEN v_ds = new DS_V_GD_MA_TRA_CUU_NHAN_VIEN();
            v_ds.EnforceConstraints = false;
            v_us.FillDataset(v_ds, " where ID_DON_VI = " + ip_dc_id_don_vi);

            m_grc.DataSource = v_ds.Tables[0];
        }

        //Get data
        private decimal get_id_phong_ban()
        {
            return Convert.ToDecimal(m_tree_don_vi.FocusedNode.GetValue("ID"));
        }
        private decimal get_id_nhan_vien()
        {
            return Convert.ToDecimal(m_grv.GetRowCellValue(m_grv.FocusedRowHandle, "ID"));
        }

        #endregion

        #region Event Handle
        private void set_define_events()
        {
            Load += f311_danh_sach_nhan_vien_theo_don_vi_Load;
            m_tree_don_vi.AfterFocusNode += m_tree_don_vi_AfterFocusNode;
            m_cmd_them_moi_cong_tac.Click += m_cmd_them_moi_cong_tac_Click;
        }

        void m_cmd_them_moi_cong_tac_Click(object sender, EventArgs e)
        {
            try
            {
                f310_cap_nhat_cong_tac v_frm = new f310_cap_nhat_cong_tac();
                v_frm.display_for_them_cong_tac_moi();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void f311_danh_sach_nhan_vien_theo_don_vi_Load(object sender, EventArgs e)
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
        private void m_tree_don_vi_AfterFocusNode(object sender, DevExpress.XtraTreeList.NodeEventArgs e)
        {
            try
            {
                var v_dc_id_don_vi = Convert.ToDecimal(e.Node.GetValue("ID"));
                load_data_danh_sach_nhan_vien_theo_don_vi(v_dc_id_don_vi);
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        #endregion

        
    }
}
