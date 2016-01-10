using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using IP.Core.IPCommon;

namespace BKI_DichVuMatDat.BaoCao
{
    public partial class f490_rpt_ke_khai_thu_nhap_va_thue_thu_nhap_da_khau_tru : Form
    {
        public f490_rpt_ke_khai_thu_nhap_va_thue_thu_nhap_da_khau_tru()
        {
            InitializeComponent();
        }

        private void f490_rpt_ke_khai_thu_nhap_va_thue_thu_nhap_da_khau_tru_Load(object sender, EventArgs e)
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
            v_us.FillDatasetProcBangKeKhaiThuNhap(v_ds, m_txt_nam.Text);
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
                m_lbl_nam_2.Text = "";
            }

        }

        private void m_txt_nam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }



        private  void DoRowDoubleClick(GridView view, Point pt)
        {
            GridHitInfo info = view.CalcHitInfo(pt);
            if (info.InRow || info.InRowCell)
            {
                DataRow v_dr_grv = m_adv_tong_hop.GetDataRow(m_adv_tong_hop.FocusedRowHandle);
                decimal v_id_nhan_vien = CIPConvert.ToDecimal(v_dr_grv["ID_NHAN_VIEN"].ToString());
                f490_rpt_ke_khai_thu_nhap_detail v_f = new f490_rpt_ke_khai_thu_nhap_detail();
                v_f.DisplayForPresent(v_id_nhan_vien, m_txt_nam.Text);
            }


        }

        private void m_adv_tong_hop_DoubleClick(object sender, EventArgs e)
        {
            GridView view = (GridView)sender;
            Point pt = view.GridControl.PointToClient(Control.MousePosition);
            DoRowDoubleClick(view, pt);
        }

        private void m_cmd_tinh_Click(object sender, EventArgs e)
        {
            load_data_to_grid();
        }
    }
}
