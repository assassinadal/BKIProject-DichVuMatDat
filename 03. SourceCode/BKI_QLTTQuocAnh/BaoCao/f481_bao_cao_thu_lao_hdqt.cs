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
    public partial class f481_bao_cao_thu_lao_hdqt : Form
    {
        public f481_bao_cao_thu_lao_hdqt()
        {
            InitializeComponent();
        }

        private void m_cmd_search_Click(object sender, EventArgs e)
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

        private void load_data_to_grid()
        {
            CHRMCommon.make_stt(m_grv_hs_bs_hs_athk);
            DataSet v_ds = new DataSet();
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            v_ds.Tables.Add(new DataTable());
            v_us.filldatasetBaoCaoThuLaoHDQT(v_ds, m_txt_chon_thang.Text, m_txt_chon_nam.Text);
            m_grc_bc_thu_lao.DataSource = v_ds.Tables[0];
        }
    }
}
