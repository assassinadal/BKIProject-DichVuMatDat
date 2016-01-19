using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BKI_DichVuMatDat.US;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using IP.Core.IPCommon;

namespace BKI_DichVuMatDat.BaoCao
{
    public partial class f490_rpt_ke_khai_thu_nhap_va_thue_thu_nhap_da_khau_tru : Form
    {
        decimal v_dc_tong_thu_nhap = 0;
        decimal v_dc_tong_thu_nhap_trong_bang_luong = 0;
        decimal v_dc_tong_thu_nhap_ngoai_bang_luong = 0;
        decimal v_dc_tong_giam_tru = 0;
        decimal v_dc_tong_thu_nhap_chiu_thue = 0;
        decimal v_dc_tong_so_TTN_phai_nop = 0;
        decimal v_dc_TTN_da_nop = 0;
        decimal v_dc_TTN_con_phai_nop = 0;
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
                m_lbl_nam_2.Text = m_txt_nam.Text;
                m_lbl_nam_2.ForeColor = Color.Maroon;
                m_lbl_nam_2.Font = new Font("Tahoma", 18, FontStyle.Bold);
                format_grid();
                hien_thi_cac_o_text_box(v_ds);
            }
            else
            {
                MessageBox.Show("Không có dữ liệu cho năm " + m_txt_nam.Text + " . Vui lòng kiểm tra lại thông tin!");
                m_lbl_nam_2.Text = "";
            }

        }

        private void hien_thi_cac_o_text_box(DataSet v_ds)
        {
            for (int i = 0; i < v_ds.Tables[0].Rows.Count; i++)
            {
                v_dc_tong_so_TTN_phai_nop += decimal.Parse(v_ds.Tables[0].Rows[i]["TONG_SO_PHAI_NOP"].ToString());
                v_dc_TTN_con_phai_nop+= decimal.Parse(v_ds.Tables[0].Rows[i]["CON_PHAI_NOP"].ToString());
                if (v_ds.Tables[0].Rows[i]["DA_NOP"].ToString() != "")
                v_dc_TTN_da_nop+= decimal.Parse(v_ds.Tables[0].Rows[i]["DA_NOP"].ToString());
                v_dc_tong_giam_tru += decimal.Parse(v_ds.Tables[0].Rows[i]["TONG_GIAM_TRU"].ToString());
               
                if (v_ds.Tables[0].Rows[i]["TONG_THU_NHAP"].ToString() != "")
                    v_dc_tong_thu_nhap += decimal.Parse(v_ds.Tables[0].Rows[i]["TONG_THU_NHAP"].ToString());
                v_dc_tong_thu_nhap_chiu_thue += decimal.Parse(v_ds.Tables[0].Rows[i]["THU_NHAP_CHIU_THUE"].ToString());
                v_dc_tong_thu_nhap_ngoai_bang_luong += decimal.Parse(v_ds.Tables[0].Rows[i]["TONG_THU_NHAP_NGOAI_LUONG"].ToString());
                v_dc_tong_thu_nhap_trong_bang_luong += decimal.Parse(v_ds.Tables[0].Rows[i]["TONG_THU_NHAP_TRONG_LUONG"].ToString());
            }
            m_txt_tong_so_TTN_phai_nop.Text = string.Format("{0:#,##0}", double.Parse(v_dc_tong_so_TTN_phai_nop.ToString()));
            m_txt_tong_giam_tru.Text = string.Format("{0:#,##0}", double.Parse(v_dc_tong_giam_tru.ToString()));
            m_txt_TTN_con_phai_nop.Text= string.Format("{0:#,##0}", double.Parse(v_dc_TTN_con_phai_nop.ToString()));
            m_txt_TTN_da_nop.Text =string.Format("{0:#,##0}", double.Parse(v_dc_TTN_da_nop.ToString()));
            m_txt_tong_thu_nhap.Text = string.Format("{0:#,##0}", double.Parse(v_dc_tong_thu_nhap.ToString()));
            m_txt_tong_thu_nhap_ngoai_bang_luong.Text = string.Format("{0:#,##0}", double.Parse(v_dc_tong_thu_nhap_ngoai_bang_luong.ToString()));
            m_txt_tong_thu_nhap_trong_bang_luong.Text = string.Format("{0:#,##0}", double.Parse(v_dc_tong_thu_nhap_trong_bang_luong.ToString()));
            m_txt_tong_thu_nhap_chiu_thue.Text = string.Format("{0:#,##0}", double.Parse(v_dc_tong_thu_nhap_chiu_thue.ToString()));
        }

        private void format_grid()
        {

         m_adv_tong_hop.OptionsView.ColumnAutoWidth = true;

            foreach (DevExpress.XtraGrid.Columns.GridColumn col in ((DevExpress.XtraGrid.Views.Base.ColumnView)m_grc_tong_hop.Views[0]).Columns)
            {
                col.MaxWidth = 90;
                col.MinWidth = 90;

            }
            //    DON_VI.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            gridBand1.Width = 393;
            HO_TEN.Width = 100;
            m_adv_tong_hop.OptionsView.AllowHtmlDrawHeaders = true;
            m_adv_tong_hop.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            m_adv_tong_hop.ColumnPanelRowHeight = 40;
            m_adv_tong_hop.OptionsView.RowAutoHeight = true;
            m_adv_tong_hop.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            var list_label = GetAll(groupBox1, typeof(TextBox));
            foreach (var item in list_label)
            {
                item.Font = new Font("Tahoma", 10, FontStyle.Bold);
                item.ForeColor = Color.Maroon;
            }
            m_lbl_nam_2.Text = m_txt_nam.Text;
            m_lbl_nam_2.ForeColor = Color.Maroon;
            m_lbl_nam_2.Font = new Font("Tahoma", 18, FontStyle.Bold);
        }


        public IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type);
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

        private void m_cmd_luu_bang_luong_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "xls files (*.xls)|*.xls|All files (*.*)|*.*";
                saveFileDialog1.RestoreDirectory = true;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    m_grc_tong_hop.ExportToXls(saveFileDialog1.FileName);
                    CHRM_BaseMessages.MsgBox_Infor(CONST_ID_MSGBOX.INFOR_LUU_BAO_CAO_THANH_CONG);
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
    }
}
