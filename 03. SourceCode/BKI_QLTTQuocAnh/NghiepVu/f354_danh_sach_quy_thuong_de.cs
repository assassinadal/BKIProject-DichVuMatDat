using BKI_DichVuMatDat.DS;
using BKI_DichVuMatDat.US;
using DevExpress.XtraEditors;
using IP.Core.IPCommon;
using IP.Core.IPSystemAdmin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BKI_DichVuMatDat.NghiepVu
{
    public partial class f354_danh_sach_quy_thuong_de : Form
    {
        #region Public Interface
        public f354_danh_sach_quy_thuong_de()
        {
            InitializeComponent();
            format_control();
        }
        ~f354_danh_sach_quy_thuong_de()
        {
            Dispose(false);
        }
        public bool is_inserted_quy_tien()
        {
            if(DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                return true;
            }
            return false;
        }
        #endregion

        #region Private Methode
        private void format_control()
        {
            set_define_event();
        }
        private void fill_data_loai_quy_thuong()
        {
            US_CM_DM_TU_DIEN v_us_td = new US_CM_DM_TU_DIEN();
            DS_CM_DM_TU_DIEN v_ds_td = new DS_CM_DM_TU_DIEN();
            v_us_td.FillDatasetByIdLoaiTuDien(v_ds_td, (int) CONST_ID_LOAI_TU_DIEN.LOAI_QUY_TIEN);

            m_le_loai_quy_thuong.Properties.DataSource = v_ds_td.CM_DM_TU_DIEN;
        }
        
        private void set_initial_form_load()
        {
            m_dat_thang_thuong.DateTime = DateTime.Now;
            fill_data_loai_quy_thuong();
            //DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
        private bool is_valid_data()
        {
            if(!CHRMCommon.validate_control_empty(m_le_loai_quy_thuong,m_txt_ten_quy))
            {
                XtraMessageBox.Show("Hoàn thiện dữ liệu trước!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if(((decimal) m_txt_so_tien.EditValue == 0))
            {
                 XtraMessageBox.Show("Điền số tiền trước!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void insert_tien_thuong()
        {
            US_GD_QUY_TIEN_THUONG v_us_gd_quy_tien_thuong = new US_GD_QUY_TIEN_THUONG();
            v_us_gd_quy_tien_thuong.strTHANG = m_dat_thang_thuong.DateTime.Month.ToString();
            v_us_gd_quy_tien_thuong.strNAM = m_dat_thang_thuong.DateTime.Year.ToString();
            v_us_gd_quy_tien_thuong.dcSO_TIEN = (decimal) m_txt_so_tien.EditValue;
            v_us_gd_quy_tien_thuong.dcID_LOAI_QUY_TIEN = CONST_ID_TIEN_THUONG.THUONG_ATHK;
            v_us_gd_quy_tien_thuong.dcID_LOAI_QUY_TIEN = (decimal)m_le_loai_quy_thuong.EditValue;
            v_us_gd_quy_tien_thuong.strNGUOI_LAP = CAppContext_201.getCurrentUserName();
            v_us_gd_quy_tien_thuong.datNGAY_LAP = DateTime.Now;
            v_us_gd_quy_tien_thuong.strDA_XOA = "N";
            v_us_gd_quy_tien_thuong.strTEN_QUY = m_txt_ten_quy.Text;
            v_us_gd_quy_tien_thuong.strTINH_XONG_YN = "N";

            v_us_gd_quy_tien_thuong.Insert();
            DialogResult = System.Windows.Forms.DialogResult.OK;
            XtraMessageBox.Show("Thêm quỹ tiền thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void start_save_process()
        {
            if(!is_valid_data())
            {
                return;
            }
            insert_tien_thuong();
            Close();
        }
        private void start_key_down_process(Keys ip_key, bool ip_bool_ctrl_key_down)
        {
            if(ip_key == Keys.Escape)
            {
                Dispose();
            }
            if(ip_bool_ctrl_key_down && ip_key == Keys.Enter)
            {
                start_save_process();
            }
        }
        #endregion

        #region Event handle
        private void set_define_event()
        {
            Load += f354_danh_sach_quy_thuong_de_Load;
            m_cmd_exit.Click += m_cmd_exit_Click;
            m_cmd_save.Click += m_cmd_save_Click;
            KeyDown += f354_danh_sach_quy_thuong_de_KeyDown;
        }

        void f354_danh_sach_quy_thuong_de_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                start_key_down_process(e.KeyCode, e.Control);
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        

        void m_cmd_save_Click(object sender, EventArgs e)
        {
            try
            {
                start_save_process();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_exit_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void f354_danh_sach_quy_thuong_de_Load(object sender, EventArgs e)
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

        
        #endregion
    }
}
