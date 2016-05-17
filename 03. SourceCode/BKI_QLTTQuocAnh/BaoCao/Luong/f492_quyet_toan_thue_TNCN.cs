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
using DevExpress.XtraSplashScreen;
using BKI_DichVuMatDat.BaoCao.Luong;

namespace BKI_DichVuMatDat.BaoCao
{
    public partial class f492_quyet_toan_thue_TNCN : Form
    {
        public f492_quyet_toan_thue_TNCN()
        {
            InitializeComponent();
        }

        private void f490_rpt_ke_khai_thu_nhap_va_thue_thu_nhap_da_khau_tru_Load(object sender, EventArgs e)
        {
            try
            {
                m_dat_tu_thang.DateTime = DateTime.Now.AddMonths(-DateTime.Now.Month + 1).AddDays(-DateTime.Now.Day + 1).Date;
                m_dat_den_thang.DateTime = DateTime.Now.Date;
                load_data_to_grid();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void load_data_to_grid()
        {
            US_RPT_LUONG_V2 v_us = new US_RPT_LUONG_V2();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetProcBangKeKhaiThuNhap2016(v_ds, m_dat_tu_thang.DateTime, m_dat_den_thang.DateTime);
            m_grc_tong_hop.DataSource = v_ds.Tables[0];
            if(v_ds.Tables[0].Rows.Count != 0)
            {
                m_lbl_nam_2.Text = m_dat_tu_thang.DateTime.Year.ToString();
                m_lbl_nam_2.ForeColor = Color.Maroon;
                m_lbl_nam_2.Font = new Font("Tahoma", 18, FontStyle.Bold);
                format_grid();
                hien_thi_cac_o_text_box(v_ds);
            }
            else
            {
                MessageBox.Show("Không có dữ liệu cho năm " + m_dat_tu_thang.DateTime.Year.ToString() + " . Vui lòng kiểm tra lại thông tin!");
                m_lbl_nam_2.Text = "";
            }
        }

        private void hien_thi_cac_o_text_box(DataSet v_ds)
        {
            //v_dc_tong_thu_nhap = 0;
            //v_dc_tong_thu_nhap_trong_bang_luong = 0;
            //v_dc_tong_thu_nhap_ngoai_bang_luong = 0;
            //v_dc_tong_giam_tru = 0;
            //v_dc_tong_thu_nhap_chiu_thue = 0;
            //v_dc_tong_so_TTN_phai_nop = 0;
            //v_dc_TTN_da_nop = 0;
            //v_dc_TTN_con_phai_nop = 0;
            //for(int i = 0; i < v_ds.Tables[0].Rows.Count; i++)
            //{
            //    v_dc_tong_so_TTN_phai_nop += decimal.Parse(v_ds.Tables[0].Rows[i]["TONG_SO_PHAI_NOP"].ToString());
            //    var x = v_ds.Tables[0].Rows.Count;
            //    v_dc_TTN_con_phai_nop += decimal.Parse(v_ds.Tables[0].Rows[i]["CON_PHAI_NOP"].ToString());
            //    if(v_ds.Tables[0].Rows[i]["DA_NOP"].ToString() != "")
            //        v_dc_TTN_da_nop += decimal.Parse(v_ds.Tables[0].Rows[i]["DA_NOP"].ToString());
            //    v_dc_tong_giam_tru += decimal.Parse(v_ds.Tables[0].Rows[i]["TONG_GIAM_TRU"].ToString());

            //    if(v_ds.Tables[0].Rows[i]["TONG_THU_NHAP"].ToString() != "")
            //        v_dc_tong_thu_nhap += decimal.Parse(v_ds.Tables[0].Rows[i]["TONG_THU_NHAP"].ToString());
            //    v_dc_tong_thu_nhap_chiu_thue += decimal.Parse(v_ds.Tables[0].Rows[i]["THU_NHAP_TINH_THUE"].ToString());
            //    v_dc_tong_thu_nhap_ngoai_bang_luong += decimal.Parse(v_ds.Tables[0].Rows[i]["TONG_THU_NHAP_NGOAI_LUONG"].ToString());
            //    v_dc_tong_thu_nhap_trong_bang_luong += decimal.Parse(v_ds.Tables[0].Rows[i]["TONG_THU_NHAP_TRONG_LUONG"].ToString());
            //}
            //m_txt_tong_so_TTN_phai_nop.Text = string.Format("{0:#,##0}", double.Parse(v_dc_tong_so_TTN_phai_nop.ToString()));
            //m_txt_tong_giam_tru.Text = string.Format("{0:#,##0}", double.Parse(v_dc_tong_giam_tru.ToString()));
            //m_txt_TTN_con_phai_nop.Text = string.Format("{0:#,##0}", double.Parse(v_dc_TTN_con_phai_nop.ToString()));
            //m_txt_TTN_da_nop.Text = string.Format("{0:#,##0}", double.Parse(v_dc_TTN_da_nop.ToString()));
            //m_txt_tong_thu_nhap.Text = string.Format("{0:#,##0}", double.Parse(v_dc_tong_thu_nhap.ToString()));
            //m_txt_tong_thu_nhap_ngoai_bang_luong.Text = string.Format("{0:#,##0}", double.Parse(v_dc_tong_thu_nhap_ngoai_bang_luong.ToString()));
            //m_txt_tong_thu_nhap_trong_bang_luong.Text = string.Format("{0:#,##0}", double.Parse(v_dc_tong_thu_nhap_trong_bang_luong.ToString()));
            //m_txt_tong_thu_nhap_chiu_thue.Text = string.Format("{0:#,##0}", double.Parse(v_dc_tong_thu_nhap_chiu_thue.ToString()));
        }

        private void format_grid()
        {
            m_lbl_nam_2.Text = m_dat_tu_thang.DateTime.Year.ToString();
            m_lbl_nam_2.ForeColor = Color.Maroon;
            m_lbl_nam_2.Font = new Font("Tahoma", 18, FontStyle.Bold);
        }



        private void DoRowDoubleClick(GridView view, Point pt)
        {

            try
            {
                GridHitInfo info = view.CalcHitInfo(pt);
                if(info.InRow || info.InRowCell)
                {
                   
                }
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_adv_tong_hop_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                //GridView view = (GridView)sender;
                //Point pt = view.GridControl.PointToClient(Control.MousePosition);
                //DoRowDoubleClick(view, pt);
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_tinh_Click(object sender, EventArgs e)
        {
            try
            {
                splashScreenManager1.ShowWaitForm();
                load_data_to_grid();
            }
            catch(Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
            finally
            {
                splashScreenManager1.CloseWaitForm();
            }
        }

        private void m_cmd_luu_bang_luong_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "xls files (*.xls)|*.xls|All files (*.*)|*.*";
                saveFileDialog1.RestoreDirectory = true;
                if(saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    m_grc_tong_hop.ExportToXls(saveFileDialog1.FileName);
                    CHRM_BaseMessages.MsgBox_Infor(CONST_ID_MSGBOX.INFOR_LUU_BAO_CAO_THANH_CONG);
                }
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_grc_tong_hop_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                DataRow v_dr_grv = m_adv_tong_hop.GetDataRow(m_adv_tong_hop.FocusedRowHandle);
                decimal v_id_nhan_vien = CIPConvert.ToDecimal(v_dr_grv["ID_NHAN_VIEN"].ToString());
                f489_rpt_qtt_ke_khai_detail v_frm = new f489_rpt_qtt_ke_khai_detail();
                v_frm.DisplayForQTT(m_dat_tu_thang.DateTime.Date, m_dat_den_thang.DateTime.Date, v_id_nhan_vien);
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
           
        }
    }
}
