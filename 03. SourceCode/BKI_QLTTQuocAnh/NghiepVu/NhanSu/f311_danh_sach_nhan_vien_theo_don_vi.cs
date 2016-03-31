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
        }
        #endregion

        #region Event Handle
        private void set_define_events()
        {
            Load += f311_danh_sach_nhan_vien_theo_don_vi_Load;

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
    }
}
