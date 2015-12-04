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
    public partial class f471_bao_cao_qua_trinh_cong_tac : Form
    {
        #region Public Interface
        public f471_bao_cao_qua_trinh_cong_tac()
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
            US_DM_NHAN_VIEN v_us_nv = new US_DM_NHAN_VIEN();
            DS_V_GD_CONG_TAC v_ds_source= v_us_nv.XemQuaTrinhCongTac(m_txt_ma_nv.Text);
            m_grc_main.DataSource = v_ds_source.Tables[0];
        }
        private bool is_exist_nv_in_db()
        {
            US_DM_NHAN_VIEN v_us_dm_nv = new US_DM_NHAN_VIEN();
            return v_us_dm_nv.IsExistNhanVienInDB(m_txt_ma_nv.Text);
        }
        private bool is_valid_data_input()
        {
            if(string.IsNullOrEmpty(m_txt_ma_nv.Text) == true)
            {
                XtraMessageBox.Show("Nhập mã nhân viên trước!");
                return false;
            }
            if(!is_exist_nv_in_db())
            {
                XtraMessageBox.Show("Không tồn tại mã nhân viên này trong cơ sở dữ liệu!");
                return false;
            }
            return true;
        }
        private void handle_filter_btn_click()
        {
            if(!is_valid_data_input())
            {
                return;
            }
            load_data_2_grid();
        }
        private void handle_xuat_excel()
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "xls files (*.xls)|*.xls|All files (*.*)|*.*";
            saveFileDialog1.RestoreDirectory = true;
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                m_grv_main.ExportToXls(saveFileDialog1.FileName);
                DevExpress.XtraEditors.XtraMessageBox.Show("Lưu báo cáo thành công");
            }
        }
        #endregion

        #region Event Handle
        private void set_define_event()
        {
            Load += f471_bao_cao_qua_trinh_cong_tac_Load;
            m_cmd_filter.Click += m_cmd_filter_Click;
            m_cmd_xuat_excel.Click += m_cmd_xuat_excel_Click;
        }

        void m_cmd_xuat_excel_Click(object sender, EventArgs e)
        {
            try
            {
                handle_xuat_excel();
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
                handle_filter_btn_click();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void f471_bao_cao_qua_trinh_cong_tac_Load(object sender, EventArgs e)
        {
            try
            {

            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        #endregion
    }
}
