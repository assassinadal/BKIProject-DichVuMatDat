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
    public partial class frm417_bao_cao_tang_giam_lao_dong : Form
    {
        public frm417_bao_cao_tang_giam_lao_dong()
        {
            InitializeComponent();
        }


        private void m_cmd_filter_Click(object sender, EventArgs e)
        {
            try
            {
                US_DUNG_CHUNG v_us_dung_chung = new US_DUNG_CHUNG();
                DataSet v_op_ds = new DataSet();
                v_op_ds.Tables.Add();

                v_us_dung_chung.FillDatasetBaoCaoTangGiamLaoDong(v_op_ds, m_dat_tu_ngay.DateTime, m_dat_den_ngay.DateTime);
                m_grc_bao_cao.DataSource = v_op_ds.Tables[0];
                m_grc_bao_cao.RefreshDataSource();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
    }
}
