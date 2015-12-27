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
    public partial class f697_cham_cong_lam_them : Form
    {
        public f697_cham_cong_lam_them()
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
            m_cmd_chon_file_import.Click += m_cmd_chon_file_import_Click;
            m_cmd_xem_cham_cong_lam_them.Click += m_cmd_xem_cham_cong_lam_them_Click;
        }

        void m_cmd_xem_cham_cong_lam_them_Click(object sender, EventArgs e)
        {
            try
            {
                US_DUNG_CHUNG v_us_dung_chung = new US_DUNG_CHUNG();
                DataSet v_ds = new DataSet();
                v_ds.Tables.Add();

                v_us_dung_chung.FillDatasetWithQuery(v_ds, "SELECT * FROM V_GD_CHAM_CONG_THEO_THANG");

                m_grc.DataSource = v_ds.Tables[0];

            }
            catch(Exception)
            {
                MessageBox.Show("Có lỗi xảy ra!");
            }
        }

        void m_cmd_chon_file_import_Click(object sender, EventArgs e)
        {
            
        }
    }
}
