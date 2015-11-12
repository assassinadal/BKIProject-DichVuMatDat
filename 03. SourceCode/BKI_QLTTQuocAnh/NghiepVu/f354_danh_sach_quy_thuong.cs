using BKI_DichVuMatDat.DS;
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

namespace BKI_DichVuMatDat.NghiepVu
{
    public partial class f354_danh_sach_quy_thuong : Form
    {

        #region Field
        
        #endregion
        #region Public Interface
        public f354_danh_sach_quy_thuong()
        {
            InitializeComponent();
            format_controls();
        }
        ~f354_danh_sach_quy_thuong()
        {
            Dispose(false);
        }
        #endregion
        

        #region Private Method
        private void format_controls()
        {
            set_define_events();
        }
        private void set_initial_form_load()
        {
            set_tu_dau_nam_den_cuoi_nam();

        }
        private void set_tu_dau_nam_den_cuoi_nam(){
            m_dat_tu_ngay.DateTime = DateTime.Now.AddMonths(-DateTime.Now.Month + 1).AddDays(-DateTime.Now.Day + 1);
            m_dat_den_ngay.DateTime = m_dat_tu_ngay.DateTime.AddYears(1).AddDays(-1);
        }


        private DateTime from_date()
        {
            return m_dat_tu_ngay.DateTime.Date;
        }
        private DateTime to_date()
        {
            return m_dat_den_ngay.DateTime.Date;
        } 
        private void load_data_2_grid()
        {
            US_V_GD_QUY_TIEN_THUONG v_us_v_gd_quy_tien_thuong = new US_V_GD_QUY_TIEN_THUONG();
            DS_V_GD_QUY_TIEN_THUONG v_ds_v_gd_quy_tien_thuong;
            v_us_v_gd_quy_tien_thuong.FillDataSetByDateFilter(out v_ds_v_gd_quy_tien_thuong, from_date(), to_date());
            m_grc_ds_quy_tien.DataSource = v_ds_v_gd_quy_tien_thuong.V_GD_QUY_TIEN_THUONG;
            m_grc_ds_quy_tien.RefreshDataSource();
            CHRMCommon.make_stt(0, m_grv_ds_quy_tien);
        }
        #endregion

        #region Event Handle
        private void set_define_events()
        {
            Load += f354_danh_sach_quy_thuong_Load;
            FormClosed += f354_danh_sach_quy_thuong_FormClosed;
            m_cmd_filter.Click += m_cmd_filter_Click;
            m_repoBtn_tinh_tien_thuong.Click += m_repoBtn_tinh_tien_thuong_Click;
        }

        void m_repoBtn_tinh_tien_thuong_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void f354_danh_sach_quy_thuong_Load(object sender, EventArgs e)
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
        void m_cmd_filter_Click(object sender, EventArgs e)
        {
            try
            {
                load_data_2_grid();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        void f354_danh_sach_quy_thuong_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Dispose();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        #endregion

    }
}
