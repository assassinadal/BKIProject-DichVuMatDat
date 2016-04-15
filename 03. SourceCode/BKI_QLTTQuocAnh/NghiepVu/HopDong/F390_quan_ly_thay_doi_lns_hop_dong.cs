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
using DevExpress.XtraEditors;
namespace BKI_DichVuMatDat.NghiepVu.HopDong
{
    public partial class F390_quan_ly_thay_doi_lns_hop_dong : Form
    {
        public F390_quan_ly_thay_doi_lns_hop_dong()
        {
            InitializeComponent();
            format_controls();
            set_init_form();
        }
        #region Public Interfaces
        
        #endregion

        #region Private Methods
        //Extension
        private DateTime get_ngay_dau_thang(DateTime ip_dat)
        {
            return ip_dat.AddDays(-ip_dat.Day + 1).Date;
        }
        private DateTime get_ngay_cuoi_thang(DateTime ip_dat)
        {
            return ip_dat.AddDays(-ip_dat.Day + 1).AddMonths(1).AddDays(-1).Date;
        }
        //Khoi tao Form
        private void format_controls()
        {
            set_define_events();
        }
        private void set_init_form()
        {
            m_dat_tu_ngay.DateTime = get_ngay_dau_thang(DateTime.Now);
            m_dat_den_ngay.DateTime = get_ngay_cuoi_thang(DateTime.Now);
        }
        //Load form
        private void set_initial_form_load()
        {
            load_data_to_grid();
        }

        //Load data
        private DateTime get_tu_ngay()
        {
            return m_dat_tu_ngay.DateTime.Date;
        }
        private DateTime get_den_ngay()
        {
            return m_dat_den_ngay.DateTime.Date;
        }
        private void load_data_to_grid_lns()
        {
            US_GD_HE_SO_LNS v_us_lns = new US_GD_HE_SO_LNS();
            var v_dt_lns_source = v_us_lns.LayDanhSachHopDongThayDoiHeSoLNS(get_tu_ngay(), get_den_ngay());
            m_grc_lns.DataSource = v_dt_lns_source;
        }
        private void load_data_to_grid_lcd()
        {
            US_GD_LUONG_CHE_DO v_us_lcd = new US_GD_LUONG_CHE_DO();
            var v_dt_lcd_source = v_us_lcd.LayDanhSachHopDongThayDoiLCD(get_tu_ngay(), get_den_ngay());
            m_grc_lcd.DataSource = v_dt_lcd_source;
        }
        private void load_data_to_grid()
        {
            load_data_to_grid_lns();
            load_data_to_grid_lcd();
        }

        //Check client
        private bool is_selected_row_lns()
        {
            if(m_grv_lns.FocusedRowHandle < 0)
            {
                XtraMessageBox.Show("Bạn chọn hợp dòng cần chỉnh sửa giá trị trước!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private bool is_selected_row_lcd()
        {
            if(m_grv_lcd.FocusedRowHandle < 0)
            {
                XtraMessageBox.Show("Bạn chọn hợp dòng cần chỉnh sửa giá trị trước!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        //Check logic
        #endregion

        #region EventHandle
        private void set_define_events()
        {
            FormClosed += F390_quan_ly_thay_doi_lns_lcd_hop_dong_FormClosed;
            Load += F390_quan_ly_thay_doi_lns_lcd_hop_dong_Load;
            m_cmd_filter.Click += m_cmd_filter_Click;
            m_cmd_insert_lns.Click += m_cmd_insert_lns_Click;
            m_cmd_update_lns.Click += m_cmd_update_lns_Click;
            m_cmd_delete_lns.Click += m_cmd_delete_lns_Click;
        }

        void m_cmd_delete_lns_Click(object sender, EventArgs e)
        {
            try
            {
                var v_dlg = XtraMessageBox.Show("Bạn có chắc chắc muốn xóa?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(v_dlg == System.Windows.Forms.DialogResult.OK)
                {
                    
                }
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_update_lns_Click(object sender, EventArgs e)
        {
            try
            {
                if(!is_selected_row_lns())
                {
                    return;
                }
                f391_cap_nhat_thay_doi_lns_lcd_DE v_frm = new f391_cap_nhat_thay_doi_lns_lcd_DE();
                var v_dc_id_gd_he_so_lns = Convert.ToDecimal(m_grv_lns.GetRowCellValue(m_grv_lns.FocusedRowHandle, "ID_GD_HE_SO_LNS"));
                v_frm.display_for_up_date_lns(v_dc_id_gd_he_so_lns);
                load_data_to_grid();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_insert_lns_Click(object sender, EventArgs e)
        {
            try
            {
                f391_cap_nhat_thay_doi_lns_lcd_DE v_frm = new f391_cap_nhat_thay_doi_lns_lcd_DE();
                v_frm.display_for_insert_lns();


                load_data_to_grid();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_filter_Click(object sender, EventArgs e)
        {
            try
            {
                load_data_to_grid();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void F390_quan_ly_thay_doi_lns_lcd_hop_dong_Load(object sender, EventArgs e)
        {
            try
            {
                set_initial_form_load();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void F390_quan_ly_thay_doi_lns_lcd_hop_dong_FormClosed(object sender, FormClosedEventArgs e)
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
