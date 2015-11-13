using BKI_DichVuMatDat.US;
using DevExpress.XtraEditors;
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
        #endregion

        #region Private Methode
        private void format_control()
        {
            set_define_event();
        }
        private void set_initial_form_load()
        {
            m_dat_thang_thuong.DateTime = DateTime.Now;
        }
        private bool is_valid_data()
        {
            if(CHRMCommon.validate_control_empty(m_txt_ten_quy, m_txt_so_tien))
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
        }
        private void start_save_process()
        {
            if(!is_valid_data())
            {
                return;
            }
            insert_tien_thuong();
        }
        #endregion

        #region Event handle
        private void set_define_event()
        {
            Load += f354_danh_sach_quy_thuong_de_Load;
            m_cmd_exit.Click += m_cmd_exit_Click;
            m_cmd_save.Click += m_cmd_save_Click;
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
                Dispose();
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
