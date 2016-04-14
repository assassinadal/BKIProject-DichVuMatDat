using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IP.Core.IPCommon;
namespace BKI_DichVuMatDat.NghiepVu.HopDong
{
    public partial class F390_quan_ly_thay_doi_lns_hop_dong : Form
    {
        public F390_quan_ly_thay_doi_lns_hop_dong()
        {
            InitializeComponent();
            format_controls();
            set_init_form();
        }
        #region Public Interfaces
        
        #endregion

        #region Private Methods
        //Extension
        private DateTime get_ngay_dau_thang(DateTime ip_dat)
        {
            return ip_dat.AddDays(-ip_dat.Day + 1).Date;
        }
        private DateTime get_ngay_cuoi_thang(DateTime ip_dat)
        {
            return ip_dat.AddDays(-ip_dat.Day + 1).AddMonths(1).AddDays(-1).Date;
        }
        //Khoi tao Form
        private void format_controls()
        {
            set_define_events();
        }
        private void set_init_form()
        {
            m_dat_tu_ngay.DateTime = get_ngay_dau_thang(DateTime.Now);
            m_dat_den_ngay.DateTime = get_ngay_cuoi_thang(DateTime.Now);
        }
        //Load form
        private void set_initial_form_load()
        {

        }

        //Load data
        private void load_data_to_grid()
        {

        }
        #endregion

        #region EventHandle
        private void set_define_events()
        {
            FormClosed += F390_quan_ly_thay_doi_lns_lcd_hop_dong_FormClosed;
            Load += F390_quan_ly_thay_doi_lns_lcd_hop_dong_Load;
            m_cmd_filter.Click += m_cmd_filter_Click;
        }

        void m_cmd_filter_Click(object sender, EventArgs e)
        {
            try
            {
                load_data_to_grid();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void F390_quan_ly_thay_doi_lns_lcd_hop_dong_Load(object sender, EventArgs e)
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

        void F390_quan_ly_thay_doi_lns_lcd_hop_dong_FormClosed(object sender, FormClosedEventArgs e)
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
