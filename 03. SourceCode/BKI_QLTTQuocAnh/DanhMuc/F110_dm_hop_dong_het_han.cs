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

namespace BKI_DichVuMatDat.DanhMuc
{
    public partial class F110_dm_hop_dong_het_han : Form
    {
        public F110_dm_hop_dong_het_han()
        {
            InitializeComponent();
            Load += F110_dm_hop_dong_het_han_Load;
            m_dat_lay_tu_ngay.DateTime = DateTime.Now;
            m_cmd_filter.Click += m_cmd_filter_Click;
        }

        void F110_dm_hop_dong_het_han_Load(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void load_data_2_grid()
        {
            CHRMCommon.make_stt(m_grv_hop_dong_het_han);
            US_GD_HOP_DONG v_us_gd_hop_dong = new US_GD_HOP_DONG();
            DataSet v_ds = v_us_gd_hop_dong.LayDanhSachHopDongHetHan(m_dat_lay_tu_ngay.DateTime);
            m_grc_hop_dong_het_han.DataSource = v_ds.Tables[0];
        }

        void m_cmd_filter_Click(object sender, EventArgs e)
        {
            try
            {
                load_data_2_grid();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        public void display(DateTime ip_dat_tu_ngay)
        {
            m_dat_lay_tu_ngay.DateTime = ip_dat_tu_ngay;
            load_data_2_grid();
            Show();
        }

        internal void display_for_show(DataSet dataSet)
        {
            m_grc_hop_dong_het_han.DataSource = dataSet.Tables[0];
            this.ShowDialog();
        }
    }
}
