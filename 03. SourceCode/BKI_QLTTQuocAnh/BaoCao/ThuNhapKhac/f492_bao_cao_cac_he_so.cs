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
using BKI_DichVuMatDat.US;
namespace BKI_DichVuMatDat.BaoCao.ThuNhapKhac
{
    public partial class f492_bao_cao_cac_he_so : Form
    {
        public f492_bao_cao_cac_he_so()
        {
            InitializeComponent();
            format_control();
        }
        #region Private Method
        private void format_control()
        {
            set_define_event();
        }
        private void set_from_date(DateTime ip_dat_value)
        {
            m_dat_tu_thang.EditValue = ip_dat_value;
        }
        private void set_to_date(DateTime ip_dat_value)
        {
            m_dat_den_thang.EditValue = ip_dat_value;
        }
        private DateTime get_ngay_dau_nam()
        {
            return DateTime.Now.AddDays(-DateTime.Now.Day + 1).AddMonths(-DateTime.Now.Month + 1).Date;
        }
        private DateTime get_from_date()
        {
            return m_dat_tu_thang.DateTime.AddDays(-m_dat_tu_thang.DateTime.Day + 1).Date;
        }
        private DateTime get_to_date()
        {
            return m_dat_den_thang.DateTime.AddMonths(1).AddDays(-m_dat_den_thang.DateTime.Day);
        }

        private void set_initial_form_load()
        {
            set_from_date(get_ngay_dau_nam());
            set_to_date(DateTime.Now.Date);
            load_data_to_grid();
        }
        private void load_data_to_grid()
        {
            US_RPT_THONG_TIN_TONG_HOP_V2 v_us_rpt = new US_RPT_THONG_TIN_TONG_HOP_V2();
            var v_dt_source = v_us_rpt.LayDuLieuHeSo(get_from_date(), get_to_date());
            m_grc_main.DataSource = v_dt_source;
            m_grc_main.RefreshDataSource();
        }
        #endregion

        #region Event Handle
        private void set_define_event()
        {
            Load += f492_bao_cao_cac_he_so_Load;
            m_cmd_view.Click += m_cmd_view_Click;
            m_cmd_trich_xuat_du_lieu.Click += m_cmd_trich_xuat_du_lieu_Click;
        }

        void m_cmd_trich_xuat_du_lieu_Click(object sender, EventArgs e)
        {
            try
            {
                CHRMCommon.ExportExcel(m_grv_main);
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_view_Click(object sender, EventArgs e)
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

        void f492_bao_cao_cac_he_so_Load(object sender, EventArgs e)
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
