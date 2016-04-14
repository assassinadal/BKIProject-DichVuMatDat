using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IP.Core.IPCommon;
using BKI_DichVuMatDat.US;
namespace BKI_DichVuMatDat.NghiepVu.HopDong
{
    public partial class f391_cap_nhat_thay_doi_lns_lcd_DE : Form
    {
        #region Public Interface
        public f391_cap_nhat_thay_doi_lns_lcd_DE()
        {
            InitializeComponent();
            format_controls();
            init_form();
        }
        public void display_for_insert_lns()
        {
            ShowDialog();
        }
        public void display_for_insert_lcd()
        {
            ShowDialog();
        }
        public void display_for_up_date_lns() 
        {
            ShowDialog();
        }
        #endregion

        #region Private Method
        private void init_form()
        {
            load_data_to_sle_hop_dong(get_danh_sach_hop_dong_con_hieu_luc());
        }
        private void format_controls()
        {
            set_define_events();
        }
        //Get data
        private DataTable get_danh_sach_hop_dong_con_hieu_luc()
        {
            US_GD_HOP_DONG v_us_hd = new US_GD_HOP_DONG();
            return v_us_hd.LayDanhSachHopDongConHieuLuc();
        }

        //Load data
        private void load_data_to_sle_hop_dong(DataTable ip_dt_source)
        {
            m_sle_hop_dong.Properties.DataSource = ip_dt_source;
        }
        #endregion

        #region Event Handle
        private void set_define_events()
        {
            FormClosed += f391_cap_nhat_thay_doi_lns_lcd_DE_FormClosed;
            m_sle_hop_dong.EditValueChanged += m_sle_hop_dong_EditValueChanged;
        }

        void m_sle_hop_dong_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if(m_sle_hop_dong.EditValue != null)
                {
                    US_GD_HOP_DONG v_us_hd = new US_GD_HOP_DONG();
                    decimal op_he_so = 0;
                    string op_ma = "";
                    string op_muc = "";
                    v_us_hd.LayMaMucLNSCuaHopDong(Convert.ToDecimal(m_sle_hop_dong.EditValue), out op_he_so, out op_ma, out op_muc);
                    m_txt_ma.Text = op_ma;
                    m_txt_muc.Text = op_muc;
                    m_txt_gia_tri_ma_muc.EditValue = op_he_so;
                }
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void f391_cap_nhat_thay_doi_lns_lcd_DE_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Dispose();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        #endregion
    }
}
