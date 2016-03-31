﻿using BKI_DichVuMatDat.DS;
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
        public f311_danh_sach_nhan_vien_theo_don_vi()
        {
            InitializeComponent();
            format_controls();
        }

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
            US_V_GD_CONG_TAC v_us = new US_V_GD_CONG_TAC();
            DS_V_GD_CONG_TAC v_ds = new DS_V_GD_CONG_TAC();
            v_ds.EnforceConstraints = false;
            v_us.FillDataset(v_ds, " where DA_XOA  = 'N' AND ID_LOAI_CONG_TAC IN (157,793) AND ID_DON_VI = " + ip_dc_id_don_vi);

            m_grc_nv.DataSource = v_ds.Tables[0];
        }
        #endregion

        #region Event Handle
        private void set_define_events()
        {
            Load += f311_danh_sach_nhan_vien_theo_don_vi_Load;
            m_tree_don_vi.CustomDrawNodeButton += m_tree_don_vi_CustomDrawNodeButton;
        }

        void m_tree_don_vi_CustomDrawNodeButton(object sender, DevExpress.XtraTreeList.CustomDrawNodeButtonEventArgs e)
        {
            try
            {
              
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void f311_danh_sach_nhan_vien_theo_don_vi_Load(object sender, EventArgs e)
        {
            try
            {
                set_initial_form_load();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        #endregion

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
    }
}