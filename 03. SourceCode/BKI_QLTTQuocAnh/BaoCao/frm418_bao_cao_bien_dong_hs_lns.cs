using BKI_DichVuMatDat.US;
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
using BKI_DichVuMatDat.DS.CDBNames;
using DevExpress.XtraEditors;
using BKI_DichVuMatDat.NghiepVu.NhanSu;

namespace BKI_DichVuMatDat.BaoCao
{
    public partial class frm418_bao_cao_bien_dong_hs_lns : Form
    {
        #region Public Interface
        public frm418_bao_cao_bien_dong_hs_lns()
        {
            InitializeComponent();
            set_initial_form_load();
        }
        #endregion

        #region Private Method
        private void set_initial_form_load()
        {
            m_dat_tu_ngay.DateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            m_dat_den_ngay.DateTime = m_dat_tu_ngay.DateTime.AddMonths(1).AddDays(-1);
            set_define_events();
        }

        private void load_data_to_grid()
        {
            US_GD_HE_SO_LNS v_us = new US_GD_HE_SO_LNS();
            DataTable v_dt = v_us.FillDatasetBCBienDong(m_dat_tu_ngay.DateTime, m_dat_den_ngay.DateTime);
            m_grc.DataSource = v_dt;
            CHRMCommon.make_stt(m_grv);
        }

        #endregion

        #region Event Handler
        private void set_define_events()
        {
            this.Load += frm417_bao_cao_tang_giam_lao_dong_Load;
            m_cmd_search.Click += m_cmd_search_Click;
            m_cmd_export.Click += m_cmd_export_Click;
        }

        void m_cmd_export_Click(object sender, EventArgs e)
        {
            try
            {
                string op_file_name = "Báo cáo thay đổi LNS";
                string dest_file = WinFormControls.saveFileDialog(op_file_name);
                if(dest_file != "")
                {
                    m_grv.ExportToXlsx(dest_file);
                    XtraMessageBox.Show("Đã lưu báo cáo tại " + dest_file + "\nFile sẽ tự động mở ngay sau đây!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    var excel = new Microsoft.Office.Interop.Excel.Application();
                    excel.Visible = true;
                    Microsoft.Office.Interop.Excel.Workbooks books = excel.Workbooks;
                    Microsoft.Office.Interop.Excel.Workbook openexcel = books.Open(dest_file);
                    this.Close();
                }
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_search_Click(object sender, EventArgs e)
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

        void frm417_bao_cao_tang_giam_lao_dong_Load(object sender, EventArgs e)
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

        #endregion
    }
}
