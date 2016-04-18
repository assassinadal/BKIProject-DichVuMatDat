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

namespace BKI_DichVuMatDat.BaoCao
{
    public partial class F421_BAO_CAO_THONG_KE_TONG_HOP : Form
    {
        public F421_BAO_CAO_THONG_KE_TONG_HOP()
        {
            InitializeComponent();
            format_control();
        }

        private void format_control()
        {
            set_define_event();
        }

        private void set_define_event()
        {
            Load += F421_BAO_CAO_THONG_KE_TONG_HOP_Load;
        }

        private void F421_BAO_CAO_THONG_KE_TONG_HOP_Load(object sender, EventArgs e)
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
            load_data_2_grid();
        }

        private void load_data_2_grid()
        {
            US_GD_CONG_TAC v_us_dung_chung = new US_GD_CONG_TAC();
            DataSet v_op_ds = new DataSet();
            v_op_ds.Tables.Add();

            v_us_dung_chung.BAO_CAO(v_op_ds);
            m_trl_bao_cao.KeyFieldName = "ID";
            m_trl_bao_cao.ParentFieldName = "ID_DON_VI_CAP_TREN";
            m_trl_bao_cao.DataSource = v_op_ds.Tables[0];
            m_trl_bao_cao.ExpandAll();
        }
    }
}
