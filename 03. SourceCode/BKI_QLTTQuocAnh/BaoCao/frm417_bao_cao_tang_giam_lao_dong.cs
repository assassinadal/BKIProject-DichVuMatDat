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
    public partial class frm417_bao_cao_tang_giam_lao_dong : Form
    {
        #region Public Interface
        public frm417_bao_cao_tang_giam_lao_dong()
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
            US_GD_HOP_DONG v_us = new US_GD_HOP_DONG();
            DataTable v_dt= v_us.FillDatasetBCTangGiamLD( m_dat_tu_ngay.DateTime, m_dat_den_ngay.DateTime).Tables[0];
            m_tree_list.ParentFieldName = DM_DON_VI.ID_DON_VI_CAP_TREN;
            m_tree_list.DataSource = v_dt;
            m_tree_list.ExpandAll();
        }

        #endregion

        #region Event Handler
        private void set_define_events()
        {
            this.Load += frm417_bao_cao_tang_giam_lao_dong_Load;
            m_cmd_search.Click += m_cmd_search_Click;
            m_cmd_export.Click += m_cmd_export_Click;
            m_tree_list.DoubleClick += m_tree_list_DoubleClick;
        }

        void m_tree_list_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                string v_str_ten_dv = m_tree_list.FocusedNode.GetValue("TEN_DON_VI").ToString();
                int v_index_column = m_tree_list.Columns.IndexOf(m_tree_list.FocusedColumn);
                f329_lap_hop_dong_v5 v_f = new f329_lap_hop_dong_v5(v_str_ten_dv, m_dat_tu_ngay.DateTime, m_dat_den_ngay.DateTime, v_index_column);
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_export_Click(object sender, EventArgs e)
        {
            try
            {
                string op_file_name = "Báo cáo tăng giảm lao động";
                string dest_file = WinFormControls.saveFileDialog(op_file_name);
                if (dest_file !="")
                {
                    m_tree_list.ExportToXlsx(dest_file);
                    XtraMessageBox.Show("Đã lưu báo cáo tại " + dest_file+"\nFile sẽ tự động mở ngay sau đây!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    var excel = new Microsoft.Office.Interop.Excel.Application();
                    excel.Visible = true;
                    Microsoft.Office.Interop.Excel.Workbooks books = excel.Workbooks;
                    Microsoft.Office.Interop.Excel.Workbook openexcel = books.Open(dest_file);
                    this.Close();
                }
            }
            catch (Exception v_e)
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
            catch (Exception v_e)
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
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        
        #endregion 
    }
}
