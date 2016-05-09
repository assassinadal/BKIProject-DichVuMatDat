using BKI_DichVuMatDat.DS;
using BKI_DichVuMatDat.DS.CDBNames;
using BKI_DichVuMatDat.US;
using DevExpress.XtraEditors;
using DevExpress.XtraTreeList.Nodes;
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
using BKI_DichVuMatDat.NghiepVu.NhanSu;

namespace BKI_DichVuMatDat.NghiepVu
{
    public partial class f300_chinh_lns_nhan_vien : Form
    {
        #region Members
        private tab_mode m_e_tab_mode = tab_mode.co_lns;
        enum tab_mode
        {
            co_lns = 1,
            khong_lns = 0,
        }
        #endregion

        #region Public Interfaces
        public f300_chinh_lns_nhan_vien()
        {
            InitializeComponent();
            format_controll();
        }
        public f300_chinh_lns_nhan_vien(DateTime ip_datetime, bool ip_trang_thai_filter)
        {
            InitializeComponent();
            radioButton1.Checked = true;
            set_define_events();
            string v_str = ip_datetime.ToString("MM/dd/yyyy");
            string v_str_ngay_hien_tai = DateTime.Now.ToString("MM/dd/yyyy");
            if(ip_trang_thai_filter == true)
            {
                m_grv.ActiveFilterString = "[NGAY_KET_THUC] >= #" + v_str + "# and [NGAY_KET_THUC] <= #" + v_str_ngay_hien_tai + "#";
            }
            else if(ip_trang_thai_filter == false)
            {
                m_grv.ActiveFilterString = "[NGAY_KET_THUC] > #" + v_str_ngay_hien_tai + "# and [NGAY_KET_THUC] <= #" + v_str + "#";
            }
            this.CenterToParent();
            this.ShowDialog();
        }
        #endregion

        #region private methods
        //Init
        private void format_controll()
        {
            set_define_events();
            CenterToScreen();
        }
        private void set_init_form_load()
        {
            m_dat_tai_thang.EditValue = DateTime.Now.Date;
            load_data_2_grid_lns();
        }
        private string get_option_filter()
        {
            if(radioButton1.Checked == true)
            {
                return "TAT_CA";
            }
            return "MOI_NHAT";
        }
        private decimal get_thang()
        {
            return m_dat_tai_thang.DateTime.Month;
        }
        private decimal get_nam()
        {
            return m_dat_tai_thang.DateTime.Year;
        }
        //Load data
        private void load_data_2_grid_lns()
        {
            US_GD_HE_SO_LNS v_us = new US_GD_HE_SO_LNS();
            m_grc.DataSource = v_us.LayDanhSachHeSoLNS(get_option_filter(), get_thang(), get_nam());
        }
        private void load_data_2_grv_k_hs_lns()
        {
            US_GD_HE_SO_LNS v_us = new US_GD_HE_SO_LNS();
            m_grc_khs.DataSource = v_us.LayDanhSachNhanVienChuaCoLNS();
        }

        //Action
        private void insert_click()
        {
            f299_chinh_lns_nhan_vien_de v_frm = new f299_chinh_lns_nhan_vien_de();
            v_frm.display_4_insert();
            load_data_2_grid_lns();
        }
        private void update_click()
        {
            if(m_grv.FocusedRowHandle < 0)
            {
                XtraMessageBox.Show("Bạn cần chọn dòng dữ liệu để sửa!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataRow v_dr = m_grv.GetDataRow(m_grv.FocusedRowHandle);
            US_GD_HE_SO_LNS v_us = new US_GD_HE_SO_LNS(Convert.ToDecimal(v_dr["ID"].ToString()));
            f299_chinh_lns_nhan_vien_de v_frm = new f299_chinh_lns_nhan_vien_de();
            v_frm.display_4_update(v_us);
            load_data_2_grid_lns();
            focus_row(v_us.dcID_NHAN_VIEN);
        }
        private void focus_row(decimal ip_id_nhan_vien)
        {
            CHRMCommon.SelectRowInGrid(m_grv, "ID_NHAN_VIEN", ip_id_nhan_vien);
        }
        #endregion

        #region Event Handles
        private void set_define_events()
        {
            Load += F300_chinh_lns_nhan_vien_Load;
            m_cmd_insert.Click += M_cmd_insert_Click;
            m_cmd_update.Click += M_cmd_update_Click;
            m_cmd_delete.Click += M_cmd_delete_Click;
            xtraTabControl1.SelectedPageChanged += XtraTabControl1_SelectedPageChanged;
            m_cmd_chon_file.Click += m_cmd_chon_file_Click;
            m_cmd_refresh.Click += m_cmd_refresh_Click;
            m_cmd_filter.Click += m_cmd_filter_Click;
        }

        void m_cmd_filter_Click(object sender, EventArgs e)
        {
            try
            {
                load_data_2_grid_lns();
                load_data_2_grv_k_hs_lns();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_refresh_Click(object sender, EventArgs e)
        {
            try
            {
                load_data_2_grid_lns();
                load_data_2_grv_k_hs_lns();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_chon_file_Click(object sender, EventArgs e)
        {
            try
            {
                f003_import_he_so_lns v_frm = new f003_import_he_so_lns();
                v_frm.ShowDialog();
                load_data_2_grv_k_hs_lns();
                load_data_2_grid_lns();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void XtraTabControl1_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            switch(e.Page.Name)
            {
                case "m_tab_co_lns":
                    m_e_tab_mode = tab_mode.co_lns;
                     m_cmd_delete.Visible = true;
                    m_cmd_update.Visible = true;
                    load_data_2_grid_lns();
                    break;
                case "m_tab_k_lns":
                    m_e_tab_mode = tab_mode.khong_lns;
                    m_cmd_delete.Visible = false;
                    m_cmd_update.Visible = false;
                    load_data_2_grv_k_hs_lns();
                    break;
                default:
                    break;
            }
        }

        private void M_cmd_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if(m_grv.FocusedRowHandle < 0)
                {
                    XtraMessageBox.Show("Bạn cần chọn dòng dữ liệu để xóa!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DialogResult v_confirm = default(DialogResult);
                v_confirm = XtraMessageBox.Show("BẠN CÓ THỰC SỰ MUỐN XÓA LƯƠNG NĂNG SUẤT CỦA NHÂN VIÊN NÀY ?", "XÁC NHẬN LẠI", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if(v_confirm == DialogResult.Yes)
                {
                    DataRow v_dr = m_grv.GetDataRow(m_grv.FocusedRowHandle);
                    US_GD_HE_SO_LNS v_us = new US_GD_HE_SO_LNS(Convert.ToDecimal(v_dr["ID"].ToString()));
                    v_us.Delete();
                    load_data_2_grid_lns();
                    XtraMessageBox.Show("Đã xóa thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void M_cmd_update_Click(object sender, EventArgs e)
        {
            try
            {
                update_click();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void M_cmd_insert_Click(object sender, EventArgs e)
        {
            try
            {
                insert_click();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void M_grv_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                DataRow v_dr = m_grv.GetDataRow(m_grv.FocusedRowHandle);
                decimal ip_id_nhan_vien = Convert.ToDecimal(v_dr["ID_NHAN_VIEN"].ToString());
                f299_chinh_lns_nhan_vien_de v_f = new f299_chinh_lns_nhan_vien_de();
                //v_f.Display(ip_id_nhan_vien);
                //focus_row(CIPConvert.ToDecimal(v_dr["ID"].ToString()));
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void F300_chinh_lns_nhan_vien_Load(object sender, EventArgs e)
        {
            try
            {
                set_init_form_load();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        #endregion
    }
}
