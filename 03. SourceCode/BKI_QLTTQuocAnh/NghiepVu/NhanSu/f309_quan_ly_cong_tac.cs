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

namespace BKI_DichVuMatDat.NghiepVu.NhanSu
{
    public partial class f309_quan_ly_cong_tac : Form
    {
        #region Public Interfaces
        public f309_quan_ly_cong_tac()
        {
            InitializeComponent();
            format_controls();
        }

        public f309_quan_ly_cong_tac(DateTime ip_datetime, bool ip_trang_thai_filter)
        {
            InitializeComponent();
            radioButton1.Checked = true;
            set_define_events();
            string v_str = ip_datetime.ToString("MM/dd/yyyy");
            string v_str_ngay_hien_tai = DateTime.Now.ToString("MM/dd/yyyy");
            if (ip_trang_thai_filter == true)
            {
                m_grv.ActiveFilterString = "[NGAY_KET_THUC] >= #" + v_str + "# and [NGAY_KET_THUC] <= #" + v_str_ngay_hien_tai + "#";
            }
            else if (ip_trang_thai_filter == false)
            {
                m_grv.ActiveFilterString = "[NGAY_KET_THUC] > #" + v_str_ngay_hien_tai + "# and [NGAY_KET_THUC] <= #" + v_str + "#";
            }
            this.CenterToParent();
            this.ShowDialog();
        }
        public void display_after_insert_hop_dong(string ip_ma_nv)
        {
            m_grv.ActiveFilterString = string.Concat("MA_NV == '", ip_ma_nv, "'") ;
            ShowDialog();
        }
        #endregion
        

        #region Private Methods
        private void format_controls()
        {
            set_define_events();
            
        }
        private void set_initial_form_load()
        {
            m_dat_tai_thang.EditValue = DateTime.Now.Date;
            load_data_to_grid();
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
        private void load_data_to_grid()
        {
            US_GD_CONG_TAC v_us = new US_GD_CONG_TAC();
            DS_GD_CONG_TAC v_ds = new DS_GD_CONG_TAC();
            v_ds.EnforceConstraints = false;
            m_grc.DataSource = v_us.LayDuLieuCongTac(get_option_filter(), get_thang(), get_nam());
        }

        //Get data
        private decimal get_id_nhan_vien()
        {
            return Convert.ToDecimal(m_grv.GetRowCellValue(m_grv.FocusedRowHandle, V_GD_CONG_TAC_2.ID_NHAN_VIEN));
        }

        private string get_ma_nv_by_ID_nv(decimal ip_id_nv)
        {
            US_DM_NHAN_VIEN v_us = new US_DM_NHAN_VIEN();
            DS_DM_NHAN_VIEN v_ds = new DS_DM_NHAN_VIEN();
            v_us.FillDataset(v_ds, "where ID=" + ip_id_nv);
            return v_ds.Tables[0].Rows[0][DM_NHAN_VIEN.MA_NV].ToString();
        }

        private void refresh_data()
        {
            load_data_to_grid();
        }

        //Check
        private bool is_nhan_vien_seleted()
        {
            if(m_grv.FocusedRowHandle < 0)
            {
                XtraMessageBox.Show("Bạn chưa chọn nhân viên!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }


        //Action
        private void them_moi_cong_tac()
        {
            f310_cap_nhat_cong_tac v_frm = new f310_cap_nhat_cong_tac();
            v_frm.display_for_them_cong_tac_moi();
            refresh_data();
        }
        private void sua_cong_tac()
        {
            if(!is_nhan_vien_seleted())
            {
                return;
            }
            var v_dc_id_gd_cong_tac = Convert.ToDecimal(m_grv.GetRowCellValue(m_grv.FocusedRowHandle, V_GD_CONG_TAC_2.ID));
            f310_cap_nhat_cong_tac v_frm = new f310_cap_nhat_cong_tac();
            v_frm.display_for_update(v_dc_id_gd_cong_tac);
            refresh_data();
        }
        private void xoa_cong_tac()
        {
            if(!is_nhan_vien_seleted())
            {
                return;
            }
            var v_dlg_confirm = XtraMessageBox.Show("Bạn có chắc chắn muốn xóa công tác (việc này chỉ nên thực hiện khi bạn cập nhật nhầm công tác cho nhân viên)!", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if(v_dlg_confirm == System.Windows.Forms.DialogResult.Yes)
            {
                var v_dc_id_gd_cong_tac = Convert.ToDecimal(m_grv.GetRowCellValue(m_grv.FocusedRowHandle, GD_CONG_TAC.ID));
                US_GD_CONG_TAC v_us = new US_GD_CONG_TAC();
                v_us.DeleteByID(v_dc_id_gd_cong_tac);
                XtraMessageBox.Show("Đã xóa công tác nhân viên thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refresh_data();
            }
        }
        #endregion

        #region Event Handle
        private void set_define_events()
        {
            Load += f311_danh_sach_nhan_vien_theo_don_vi_Load;
            m_cmd_them_moi_cong_tac.Click += m_cmd_them_moi_cong_tac_Click;
            m_cmd_refresh.Click += m_cmd_refresh_Click;
            m_cmd_sua_cong_tac.Click += m_cmd_sua_cong_tac_Click;
            m_cmd_xoa_cong_tac.Click += m_cmd_xoa_cong_tac_Click;
            m_cmd_filter.Click += m_cmd_filter_Click;
            m_grv.DoubleClick += m_grv_DoubleClick;
            m_cmd_chon_file.Click += m_cmd_chon_file_Click;
            m_cmd_xuat_excel.Click += m_cmd_xuat_excel_Click;
            KeyDown += f309_quan_ly_cong_tac_KeyDown;
        }

        void f309_quan_ly_cong_tac_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                switch(e.KeyCode)
                {
                    case Keys.F1:
                        them_moi_cong_tac();
                        break;
                    case Keys.F2:
                        sua_cong_tac();
                        break;
                    case Keys.F3:
                        xoa_cong_tac();
                        break;
                    case Keys.F5:
                        refresh_data();
                        break;
                    default:
                        break;
                }
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_xuat_excel_Click(object sender, EventArgs e)
        {
            try
            {
                CHRMCommon.ExportExcel(m_grv);
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
                f001_import_cong_tac v_frm = new f001_import_cong_tac();
                v_frm.ShowDialog();
                load_data_to_grid();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_grv_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                sua_cong_tac();
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

        void m_cmd_xoa_cong_tac_Click(object sender, EventArgs e)
        {
            try
            {
                xoa_cong_tac();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_sua_cong_tac_Click(object sender, EventArgs e)
        {
            try
            {
                sua_cong_tac();
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
                refresh_data();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_them_moi_cong_tac_Click(object sender, EventArgs e)
        {
            try
            {
                them_moi_cong_tac();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void f311_danh_sach_nhan_vien_theo_don_vi_Load(object sender, EventArgs e)
        {
            try
            {
                set_initial_form_load();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
       
        #endregion

    }
}
