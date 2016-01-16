using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BKI_DichVuMatDat.HeThong
{
    public partial class f301_quy_trinh_tinh_luong_v3 : Form
    {
        public f301_quy_trinh_tinh_luong_v3()
        {
            InitializeComponent();
            m_cmd_tong_tri_tra.Visible = false;            
            m_cmd_tong_thu.Click += m_cmd_tong_thu_Click;
        }

        void m_cmd_tong_thu_Click(object sender, EventArgs e)
        {
            m_cmd_tong_tri_tra.Visible = true;
        }
    }
}
