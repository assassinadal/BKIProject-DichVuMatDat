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
    public partial class f688_truy_linh_truy_thu : Form
    {
        public f688_truy_linh_truy_thu()
        {
            InitializeComponent();
        }

        private void f688_truy_linh_truy_thu_Load(object sender, EventArgs e)
        {
            try
            {
                US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
                
            }
            catch(Exception)
            {
                
                throw;
            }
        }
    }
}
