using BKI_DichVuMatDat.DS.CDBNames;
using BKI_DichVuMatDat.US;
using DevExpress.XtraSplashScreen;
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

namespace BKI_DichVuMatDat.BaoCao.TongHop
{
    public partial class f400_rptth_phan_loai_lao_dong : Form
    {
        public f400_rptth_phan_loai_lao_dong()
        {
            InitializeComponent();
            format_controls();
        }
        #region Data Structures
        #endregion
        #region Members
        #endregion
        #region Private Methods
        private void format_controls()
        {
            set_define_events();
        }
        private DateTime lay_ngay()
        {
            return m_dat_tai_ngay.DateTime.Date;
        }
        private void load_data_to_grid()
        {
            //SplashScreenManager.ShowForm(typeof(F_wait_form));
            try
            {
                US_DM_NHAN_VIEN v_us = new US_DM_NHAN_VIEN();
                m_tree_don_vi.ParentFieldName = DM_DON_VI.ID_DON_VI_CAP_TREN;
                m_tree_don_vi.DataSource = v_us.BangPhanLoaiLaoDong(lay_ngay());
                m_tree_don_vi.ExpandAll();
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                //SplashScreenManager.CloseForm();
            }
        }
        private void hien_thi_detail(decimal ip_dc_id_don_vi, string ip_str_focused_column_name)
        {
            switch(ip_str_focused_column_name)
            {
                default:
                    break;
            }
        }
        #endregion

        #region Events
        private void set_define_events()
        {
            Load += f400_rptth_phan_loai_lao_dong_Load;
            m_cmd_fillter.Click += m_cmd_fillter_Click;
            m_tree_don_vi.DoubleClick += m_tree_don_vi_DoubleClick;
        }

        void m_tree_don_vi_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var v_dc_id_don_vi = Convert.ToDecimal(m_tree_don_vi.FocusedNode.GetValue("ID"));
                var v_str_focused_column_name = m_tree_don_vi.FocusedColumn.Name;
                hien_thi_detail(v_dc_id_don_vi, v_str_focused_column_name);
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_fillter_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(F_wait_form));
            try
            {
                load_data_to_grid();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
            finally
            {
                SplashScreenManager.CloseForm();
            }
        }

        void f400_rptth_phan_loai_lao_dong_Load(object sender, EventArgs e)
        {
            try
            {
                m_dat_tai_ngay.DateTime = DateTime.Now.Date;
                load_data_to_grid();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        #endregion


    }
}
