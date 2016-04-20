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
    public partial class f299_chinh_lns_nhan_vien_de : Form
    {
        public f299_chinh_lns_nhan_vien_de()
        {
            InitializeComponent();
            format_controll();
        }

        private void format_controll()
        {
            set_define_events();
        }

        private void set_define_events()
        {
            Load += F299_chinh_lns_nhan_vien_de_Load;

        }

        private void F299_chinh_lns_nhan_vien_de_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
