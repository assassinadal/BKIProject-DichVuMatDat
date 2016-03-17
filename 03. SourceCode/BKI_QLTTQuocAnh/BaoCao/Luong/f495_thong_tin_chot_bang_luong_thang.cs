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

namespace BKI_DichVuMatDat.BaoCao.Luong
{
    public partial class f495_thong_tin_chot_bang_luong_thang : Form
    {
        public f495_thong_tin_chot_bang_luong_thang()
        {
            InitializeComponent();
            m_dat_nam.EditValue = DateTime.Now;
        }
        private decimal lay_nam()
        {
            return Convert.ToDecimal(m_dat_nam.DateTime.Year);
        }

        private void m_cmd_view_Click(object sender, EventArgs e)
        {
            try
            {
                US_RPT_CHOT_BANG_LUONG v_us_rpt = new US_RPT_CHOT_BANG_LUONG();
                var v_dt_source = v_us_rpt.LayDuLieuChotBangLuong(lay_nam());
                m_grc_main.DataSource = v_dt_source;
                m_grc_main.RefreshDataSource();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
    }
}
