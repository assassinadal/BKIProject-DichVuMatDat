using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BKI_DichVuMatDat;
using BKI_DichVuMatDat.DS;
using BKI_DichVuMatDat.US;
using IP.Core.IPCommon;
using BKI_DichVuMatDat.DS.CDBNames;
using DevExpress.XtraEditors;
using System.Globalization;

namespace BKI_DichVuMatDat.BaoCao
{
    public partial class F415_bao_cao_hs_bs_hs_athk : Form
    {
        public F415_bao_cao_hs_bs_hs_athk()
        {
            InitializeComponent();
            format_controls();
        }

        #region public interface

        #endregion

        #region Members

        #endregion

        #region Private methods
        private void format_controls()
        {
            this.m_grv_hs_bs_hs_athk.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(WinFormControls.m_grv_PopupMenuShowing);
            this.m_grv_hs_bs_hs_athk.OptionsPrint.AutoWidth = false;
            set_define_events();
            this.KeyPreview = true;
        }

        private void set_intial_form_load()
        {
            m_txt_chon_nam.Text = "";
            m_txt_chon_nam.Text = DateTime.Now.Year.ToString();

        }

        private void load_data_2_grid()
        {
            CHRMCommon.make_stt(m_grv_hs_bs_hs_athk);

            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithQuery(v_ds, "SELECT * FROM V_GD_GS_BS_HS_ATHK WHERE NAM = " + CIPConvert.ToDecimal(m_txt_chon_nam.Text.Trim()));

            m_grc_hs_bs_hs_athk.DataSource = v_ds.Tables[0];
        }

        private void load_data_2_grid(decimal ip_dc_thang)
        {
            CHRMCommon.make_stt(m_grv_hs_bs_hs_athk);

            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithQuery(v_ds, "SELECT * FROM V_GD_GS_BS_HS_ATHK WHERE THANG = " + CIPConvert.ToDecimal(m_txt_chon_thang.Text.Trim()) + " AND NAM = " + CIPConvert.ToDecimal(m_txt_chon_nam.Text.Trim()));

            m_grc_hs_bs_hs_athk.DataSource = v_ds.Tables[0];
        }

        #endregion
        private void set_define_events()
        {
            this.Load += F415_bao_cao_hs_bs_hs_athk_Load;
            m_cmd_search.Click += m_cmd_search_Click;
        }

        void m_cmd_search_Click(object sender, EventArgs e)
        {
            try
            {
                if (m_txt_chon_nam.Text == "")
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Bạn phải điền năm để lọc dữ liệu", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (m_txt_chon_thang.Text == "")
                    {
                        load_data_2_grid();
                    }
                    else
                    {
                        load_data_2_grid(CIPConvert.ToDecimal(m_txt_chon_thang.Text.Trim()));
                    }
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void F415_bao_cao_hs_bs_hs_athk_Load(object sender, EventArgs e)
        {
            try
            {
                set_intial_form_load();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

    }
}
