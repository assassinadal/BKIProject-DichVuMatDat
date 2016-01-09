using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using IP.Core.IPCommon;

namespace BKI_DichVuMatDat.BaoCao
{
    public partial class f491_rpt_bao_cao_tong_hop_thu_nhap_theo_nam : Form
    {
        public f491_rpt_bao_cao_tong_hop_thu_nhap_theo_nam()
        {
            InitializeComponent();
        }

        private void f491_rpt_bao_cao_tong_hop_thu_nhap_theo_nam_Load(object sender, EventArgs e)
        {
            load_data_to_grid();
        }

        private void load_data_to_grid()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            if (m_txt_nam.Text == "")
            {
                m_txt_nam.Text = "2015";
            }
            v_us.FillDatasetProcBaoCaoThuNhapTheoNam(v_ds, m_txt_nam.Text);
            m_grc_tong_hop.DataSource = v_ds.Tables[0];
            if (v_ds.Tables[0].Rows.Count != 0)
            {
                m_adv_tong_hop.BestFitColumns();
                m_lbl_nam_2.Text = m_txt_nam.Text;
                m_lbl_nam_2.ForeColor = Color.Maroon;
                m_lbl_nam_2.Font = new Font("Tahoma", 18, FontStyle.Bold);
            }
            else
            {
                MessageBox.Show("Không có dữ liệu cho năm " + m_txt_nam.Text + " . Vui lòng kiểm tra lại thông tin!");
            }

        }

        private void m_txt_nam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void m_adv_tong_hop_DoubleClick(object sender, EventArgs e)
        {
            GridView view = (GridView)sender;
            Point pt = view.GridControl.PointToClient(Control.MousePosition);
            DoRowDoubleClick(view, pt);
        }

        private void DoRowDoubleClick(GridView view, Point pt)
        {
            DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo info = view.CalcHitInfo(pt);
            if (info.InRow || info.InRowCell)
            {
                DataRow v_dr_grv = m_adv_tong_hop.GetDataRow(m_adv_tong_hop.FocusedRowHandle);
                decimal v_id_nhan_vien = CIPConvert.ToDecimal(v_dr_grv["ID_NHAN_VIEN"].ToString());
                f491_rpt_bao_cao_tong_hop_thu_nhap_theo_nam_detail v_f = new f491_rpt_bao_cao_tong_hop_thu_nhap_theo_nam_detail();
                v_f.DisplayForPresent(v_id_nhan_vien, m_txt_nam.Text);
            }


        }

       

      
    }
}
