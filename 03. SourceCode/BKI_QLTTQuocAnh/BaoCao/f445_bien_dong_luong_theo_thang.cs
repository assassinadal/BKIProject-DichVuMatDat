using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BKI_DichVuMatDat.BaoCao
{
    public partial class f445_bien_dong_luong_theo_thang : Form
    {
        public f445_bien_dong_luong_theo_thang()
        {
            InitializeComponent();
            set_define_events();
        }

        private void set_define_events()
        {
            m_cmd_xuat_pdf.Click += m_cmd_xuat_excel_Click;
        }

        void m_cmd_xuat_excel_Click(object sender, EventArgs e)
        {
            try
            {
                chartControl1.ShowPrintPreview();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
