using BKI_DichVuMatDat.US;
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
    public partial class f489_rpt_qtt_ke_khai_detail : Form
    {
        public f489_rpt_qtt_ke_khai_detail()
        {
            InitializeComponent();
        }
        public void DisplayForQTT(DateTime ip_dat_tu_ngay, DateTime ip_dat_den_ngay, decimal ip_dc_id_nhan_vien)
        {
            US_RPT_THONG_TIN_TONG_HOP_V2 v_us = new US_RPT_THONG_TIN_TONG_HOP_V2();
            m_grc_tong_hop.DataSource = v_us.HienThiBangLuongCacThang(ip_dat_tu_ngay, ip_dat_den_ngay, ip_dc_id_nhan_vien);
            ShowDialog();
        }
    }
}
