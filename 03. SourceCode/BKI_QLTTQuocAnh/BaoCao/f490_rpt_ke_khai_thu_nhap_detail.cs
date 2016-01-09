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
    public partial class f490_rpt_ke_khai_thu_nhap_detail : Form
    {
        public f490_rpt_ke_khai_thu_nhap_detail()
        {
            InitializeComponent();
        }

        internal void DisplayForPresent(decimal v_id_nhan_vien, string m_txt_nam)
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            DataTable v_dt = new DataTable();
            v_ds.Tables.Add(v_dt);
            v_us.FillDatasetKeKhaiThueDoubleClick(v_ds, v_id_nhan_vien, m_txt_nam);
            m_grc_tong_hop.DataSource = v_ds.Tables[0];
            m_adv_tong_hop.BestFitColumns();
            m_adv_tong_hop.ExpandAllGroups();
            m_lbl_nam_2.Text = m_txt_nam;
            m_lbl_nam_2.ForeColor = Color.Maroon;
            m_lbl_nam_2.Font = new Font("Tahoma", 18, FontStyle.Bold);
            this.ShowDialog();
        }
    }
}
