using BKI_DichVuMatDat.DS;
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

namespace BKI_DichVuMatDat.BaoCao
{
    public partial class f469_danh_sach_nhan_vien_bo_nhiem : Form
    {
        #region Public Interface
        public f469_danh_sach_nhan_vien_bo_nhiem()
        {
            InitializeComponent();
            format_control();
        }
        #endregion
        #region Private Method
        private void format_control()
        {
            set_define_event();
        }
        private void load_data_2_grid()
        {
            US_V_GD_CONG_TAC v_us_cong_tac = new US_V_GD_CONG_TAC();
            var v_ds_cong_tac = v_us_cong_tac.LayDanhSachNhanVienKiemNhiem(m_dat_tu_ngay.DateTime, m_dat_den_ngay.DateTime);
            m_grc_main.DataSource = v_ds_cong_tac.Tables[0];
        }
        private bool is_valid_date_input()
        {
            if(m_dat_tu_ngay.DateTime > m_dat_den_ngay.DateTime)
            {
                XtraMessageBox.Show("Ngày bắt đầu lớn hơn ngày kết thúc", "LỖI NHẬP LIỆU", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void handle_btn_filter_click()
        {
            if(!is_valid_date_input())
            {
                return;
            }
            load_data_2_grid();
        }
        private void handle_form_load()
        {
            m_dat_tu_ngay.DateTime = DateTime.Now.AddDays(-DateTime.Now.Day + 1);
            m_dat_den_ngay.DateTime = DateTime.Now.AddMonths(1).AddDays(-DateTime.Now.Day);
        }
        #endregion

        #region Event Hadle
        private void set_define_event()
        {
            Load += f469_danh_sach_nhan_vien_bo_nhiem_Load;
            m_cmd_filter.Click += m_cmd_filter_Click;
            m_cmd_xuat_excel.Click += m_cmd_xuat_excel_Click;
        }

        void m_cmd_xuat_excel_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "xls files (*.xls)|*.xls|All files (*.*)|*.*";
                saveFileDialog1.RestoreDirectory = true;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    m_grv_main.ExportToXls(saveFileDialog1.FileName);
                    CHRM_BaseMessages.MsgBox_Infor(CONST_ID_MSGBOX.INFOR_LUU_BAO_CAO_THANH_CONG);
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_filter_Click(object sender, EventArgs e)
        {
            try
            {
                handle_btn_filter_click();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void f469_danh_sach_nhan_vien_bo_nhiem_Load(object sender, EventArgs e)
        {
            try
            {
                handle_form_load();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        #endregion
    }
}
