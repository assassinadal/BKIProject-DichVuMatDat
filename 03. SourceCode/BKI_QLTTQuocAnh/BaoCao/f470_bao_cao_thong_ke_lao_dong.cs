using BKI_DichVuMatDat.US;
using DevExpress.XtraEditors;
using DevExpress.XtraPivotGrid;
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

namespace BKI_DichVuMatDat.BaoCao
{
    public partial class f470_bao_cao_thong_ke_lao_dong : Form
    {
        #region Public Interface
        public f470_bao_cao_thong_ke_lao_dong()
        {
            InitializeComponent();
            format_control();
        }
        #endregion

        #region Private Method
        private void format_control()
        {
            set_define_event();
        }
        private void handle_form_load()
        {
            m_dat_tai_ngay.DateTime = DateTime.Now.Date;
        }
        private bool is_valide_input_data()
        {
            return true;
        }
        private void load_data_2_grid()
        {
            US_DM_NHAN_VIEN v_us_nv = new US_DM_NHAN_VIEN();
            DataSet v_ds_source = v_us_nv.BangThongKeNhanVien(m_dat_tai_ngay.DateTime);
            m_pvg_main.DataSource = v_ds_source.Tables[0];
        }
        private void handle_btn_filter_click()
        {
            if(!is_valide_input_data())
            {
                return;
            }
            load_data_2_grid();
        }
        #endregion

        #region Event
        private void set_define_event()
        {
            Load += f470_bao_cao_thong_ke_lao_dong_Load;
            m_cmd_filter.Click += m_cmd_filter_Click;
        }

        void m_cmd_filter_Click(object sender, EventArgs e)
        {
            try
            {
                handle_btn_filter_click();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void f470_bao_cao_thong_ke_lao_dong_Load(object sender, EventArgs e)
        {
            try
            {
                handle_form_load();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        #endregion
    }
}
