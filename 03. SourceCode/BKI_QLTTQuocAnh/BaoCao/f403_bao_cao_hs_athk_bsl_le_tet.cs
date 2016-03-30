using BKI_DichVuMatDat.US;
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
using DevExpress.XtraSplashScreen;
namespace BKI_DichVuMatDat.BaoCao
{
    public partial class f403_bao_cao_hs_athk_bsl_le_tet : Form
    {
        public f403_bao_cao_hs_athk_bsl_le_tet()
        {
            InitializeComponent();
            format_controll();
        }

        private void format_controll()
        {
            set_init_form_load();
            CenterToScreen();
        }

        private decimal lay_thang()
        {
            return Convert.ToDecimal(m_dat_thang.DateTime.Month);
        }
        private decimal lay_nam()
        {
            return Convert.ToDecimal(m_dat_thang.DateTime.Year);
        }

        private void set_define_events()
        {
            this.Load += F403_bao_cao_hs_athk_bsl_le_tet_Load;
        }

        private void F403_bao_cao_hs_athk_bsl_le_tet_Load(object sender, EventArgs e)
        {
            try
            {
                set_init_form_load();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void set_init_form_load()
        {
            m_dat_thang.EditValue = DateTime.Now;
        }

        private void load_data_to_grid()
        {
            try
            {
                SplashScreenManager.ShowForm(typeof(F_wait_form));
                US_GD_HS_BO_SUNG_AN_TOAN_HANG_KHONG v_us = new US_GD_HS_BO_SUNG_AN_TOAN_HANG_KHONG();
                DataSet v_ds = new DataSet();
                v_ds.Tables.Add();

                v_us.load_du_lieu_hs_athk_bsl_le_tet(v_ds, lay_thang(), lay_nam());
                m_grc.DataSource = null;
                m_grc.DataSource = v_ds.Tables[0];
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
            finally
            {
                SplashScreenManager.CloseForm();
            }

        }

        private void m_cmd_view_Click(object sender, EventArgs e)
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

        private void m_cmd_export_excel_Click(object sender, EventArgs e)
        {
            try
            {
                CHRMCommon.ExportExcel(m_grv);
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
    }
}
