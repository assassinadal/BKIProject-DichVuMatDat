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
        //Field
        US_GD_QUY_TIEN_THUONG m_us_op_quy_tien_thuong = new US_GD_QUY_TIEN_THUONG();


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
        public void Display_for_athk()
        {
            fill_data_loai_quy_thuong();
            m_le_loai_quy_thuong.EditValue = CONST_ID_TIEN_THUONG.THUONG_ATHK;
            m_txt_ten_quy.Focus();
            m_le_loai_quy_thuong.ReadOnly = true;
            ShowDialog();
        }
        public US_GD_QUY_TIEN_THUONG Display_for_thuong_2014()
        {
            fill_data_loai_quy_thuong();
            fill_data_cach_tinh_thue();
            m_le_loai_quy_thuong.EditValue = CONST_ID_TIEN_THUONG.THUONG_2014;
            m_txt_ten_quy.Focus();
            m_le_loai_quy_thuong.ReadOnly = true;
            ShowDialog();
            return m_us_op_quy_tien_thuong;
        }
        #endregion

        #region Private Methode
        private void set_tu_dau_nam_den_cuoi_nam()
        {
            m_dat_tu_ngay.DateTime = DateTime.Now.AddMonths(-DateTime.Now.Month + 1).AddDays(-DateTime.Now.Day + 1);
            m_dat_den_ngay.DateTime = m_dat_tu_ngay.DateTime.AddYears(1).AddDays(-1);
        }
        private void format_control()
        {
            set_define_event();
        }
        private void fill_data_loai_quy_thuong()
        {
            US_CM_DM_TU_DIEN v_us_td = new US_CM_DM_TU_DIEN();
            DS_CM_DM_TU_DIEN v_ds_td = new DS_CM_DM_TU_DIEN();
            v_us_td.FillDatasetByIdLoaiTuDien(v_ds_td, (int)CONST_ID_LOAI_TU_DIEN.LOAI_QUY_TIEN);

            m_le_loai_quy_thuong.Properties.DataSource = v_ds_td.CM_DM_TU_DIEN;
        }

        private void fill_data_cach_tinh_thue()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add();
            v_us.FillDatasetWithQuery(v_ds, "select * from CM_DM_TU_DIEN where ID_LOAI_TU_DIEN = 13");

            m_le_cach_tinh_thue.Properties.DataSource = v_ds.Tables[0];
        }


        private void set_initial_form_load()
        {
            m_dat_thang_thuong.DateTime = DateTime.Now;
            set_tu_dau_nam_den_cuoi_nam();

        }
        private bool is_valid_data()
        {
            if(!CHRMCommon.validate_control_empty(m_le_loai_quy_thuong, m_txt_ten_quy, m_le_cach_tinh_thue, m_dat_thang_thuong, m_dat_tu_ngay, m_dat_den_ngay))
            {
                CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_DU_LIEU_CHUA_HOAN_THIEN);
                return false;
            }
            if(((decimal)m_txt_so_tien.EditValue == 0))
            {
                CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_CHUA_NHAP_SO_TIEN);
                return false;
            }
            return true;
        }
        private void insert_tien_thuong()
        {
            US_GD_QUY_TIEN_THUONG v_us_gd_quy_tien_thuong = new US_GD_QUY_TIEN_THUONG();
            v_us_gd_quy_tien_thuong.strTHANG = m_dat_thang_thuong.DateTime.Month.ToString();
            v_us_gd_quy_tien_thuong.strNAM = m_dat_thang_thuong.DateTime.Year.ToString();
            v_us_gd_quy_tien_thuong.dcSO_TIEN = (decimal)m_txt_so_tien.EditValue;
            v_us_gd_quy_tien_thuong.dcID_LOAI_QUY_TIEN = (decimal)m_le_loai_quy_thuong.EditValue;
            v_us_gd_quy_tien_thuong.strNGUOI_LAP = CAppContext_201.getCurrentUserName();
            v_us_gd_quy_tien_thuong.datNGAY_LAP = DateTime.Now;
            v_us_gd_quy_tien_thuong.strDA_XOA = "N";
            v_us_gd_quy_tien_thuong.strTEN_QUY = m_txt_ten_quy.Text;
            v_us_gd_quy_tien_thuong.strTINH_XONG_YN = "N";
            v_us_gd_quy_tien_thuong.strLY_DO_THUONG = m_txt_ly_do_thuong.Text;
            v_us_gd_quy_tien_thuong.datTU_NGAY_XET_THUONG = m_dat_tu_ngay.DateTime;
            v_us_gd_quy_tien_thuong.datDEN_NGAY_XET_THUONG = m_dat_den_ngay.DateTime;
            v_us_gd_quy_tien_thuong.dcID_CACH_TINH_THUE = (decimal)m_le_cach_tinh_thue.EditValue;
            v_us_gd_quy_tien_thuong.Insert();
            m_us_op_quy_tien_thuong = v_us_gd_quy_tien_thuong;
            DialogResult = System.Windows.Forms.DialogResult.OK;
            CHRM_BaseMessages.MsgBox_Infor(CONST_ID_MSGBOX.INFOR_LUU_DU_LIEU_THANH_CONG);
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
