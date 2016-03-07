using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IP.Core.IPCommon;
using BKI_DichVuMatDat.DS;
using BKI_DichVuMatDat.US;
using IP.Core.IPUserService;
using DevExpress.XtraEditors;

namespace BKI_DichVuMatDat.DanhMuc
{
    public partial class f151_Danh_sach_nhan_vien_master : Form
    {
        public f151_Danh_sach_nhan_vien_master()
        {
            InitializeComponent();
            format_controls();
        }

        #region Public Interface
        public void DisplayForPresent(ref int m_trang_thai_buoc_1)
        {
            m_cmd_sua.Enabled = false;
            m_cmd_tai_file_excel_mau.Enabled = false;
            m_cmd_chon_file.Enabled = false;
            this.ShowDialog();
            m_trang_thai_buoc_1 = m_trang_thai_buoc_1_sau_hien_thi;
        }
        #endregion

        #region Members

        string m_txt_path = "";
        int m_trang_thai_buoc_1_sau_hien_thi = -2;
        #endregion

        #region Private methods
        private void format_controls()
        {
            FormatControl.SetVisibleSimpleButton(this);
            set_define_events();
            this.KeyPreview = true;
        }

        private void set_init_form_load()
        {
            load_data_to_grid();
        }

        private string gen_ma_nhan_vien()
        {
            string v_str_op_ma_nhan_vien = "";
            US_V_GD_MA_TRA_CUU_NHAN_VIEN v_us = new US_V_GD_MA_TRA_CUU_NHAN_VIEN();
            v_us.gen_ma_nhan_vien(ref v_str_op_ma_nhan_vien);
            int v_int_ma_nhan_vien_tiep_theo = int.Parse(v_str_op_ma_nhan_vien) + 1;
            return v_int_ma_nhan_vien_tiep_theo.ToString();
        }

        private void load_data_to_grid()
        {
            US_V_DM_NHAN_VIEN_3 v_us = new US_V_DM_NHAN_VIEN_3();
            DS_V_DM_NHAN_VIEN_3 v_ds = new DS_V_DM_NHAN_VIEN_3();
            v_ds.Clear();
            v_us.FillDataset(v_ds);
            m_grc.DataSource = v_ds.Tables[0];
        }

        #endregion
        private void set_define_events()
        {
            this.Load += f150_Danh_sach_nhan_vien_master_Load;
            m_cmd_ma_nv_tiep_theo.Click += m_cmd_ma_nv_tiep_theo_Click;
            m_cmd_tai_file_excel_mau.Click += m_cmd_tai_file_excel_mau_Click;
            m_cmd_chon_file.Click += m_cmd_chon_file_Click;
            m_cmd_them.Click += m_cmd_them_Click;
            m_cmd_sua.Click += m_cmd_sua_Click;

        }

        private void f150_Danh_sach_nhan_vien_master_Load(object sender, EventArgs e)
        {
            try
            {
                set_init_form_load();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_ma_nv_tiep_theo_Click(object sender, EventArgs e)
        {
            try
            {
                CHRM_BaseMessages.MsgBox_Infor("Mã nhân viên tiếp theo là : " + gen_ma_nhan_vien());
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_tai_file_excel_mau_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = "DANH_SACH_NHAN_VIEN.xlsx";
                string sourcePath = (Directory.GetCurrentDirectory() + "\\Template");
                string targetPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
                string destFile = System.IO.Path.Combine(targetPath, fileName);
                if (!System.IO.Directory.Exists(targetPath))
                {
                    System.IO.Directory.CreateDirectory(targetPath);
                }
                System.IO.File.Copy(sourceFile, destFile, true);
                string newpath = targetPath + "\\DANH_SACH_NHAN_VIEN.xlsx";
                var excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = true;
                Microsoft.Office.Interop.Excel.Workbooks books = excel.Workbooks;
                Microsoft.Office.Interop.Excel.Workbook openexcel = books.Open(newpath);
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_chon_file_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();

                // Set filter options and filter index.
                openFileDialog1.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
                openFileDialog1.Multiselect = false;
                var userClickedOK = openFileDialog1.ShowDialog();

                if (userClickedOK == System.Windows.Forms.DialogResult.OK)
                {
                    m_txt_path = openFileDialog1.FileName;
                    F152_DANH_SACH_NHAN_VIEN_EXCEL v_f = new F152_DANH_SACH_NHAN_VIEN_EXCEL();
                    v_f.displayToInsertExcel(m_txt_path);
                    // WinFormControls.load_xls_to_gridview(m_txt_path, m_grc);
                }
                load_data_to_grid();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_them_Click(object sender, EventArgs e)
        {
            try
            {
                f150_danh_muc_nhan_su_v2 v_f = new f150_danh_muc_nhan_su_v2();
                string v_str_ma_nhan_vien = gen_ma_nhan_vien();
                v_f.DisplayForInsert();
                load_data_to_grid();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_sua_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow v_dr = m_grv.GetDataRow(m_grv.FocusedRowHandle);
                US_DM_NHAN_VIEN v_us = new US_DM_NHAN_VIEN(CIPConvert.ToDecimal(v_dr["ID"].ToString()));
                f150_danh_muc_nhan_su_v2 v_f = new f150_danh_muc_nhan_su_v2();
                v_f.DisplayForUpdate(v_us);
                load_data_to_grid();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }


    }
}
