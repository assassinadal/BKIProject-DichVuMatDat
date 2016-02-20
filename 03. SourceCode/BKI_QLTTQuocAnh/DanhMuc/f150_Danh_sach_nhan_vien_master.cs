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

namespace BKI_DichVuMatDat.DanhMuc
{
    public partial class f150_Danh_sach_nhan_vien_master : Form
    {
        public f150_Danh_sach_nhan_vien_master()
        {
            InitializeComponent();
            format_controls();
        }

        private void format_controls()
        {
            FormatControl.SetVisibleSimpleButton(this);
            set_define_events();
            this.KeyPreview = true;
        }

        private void set_define_events()
        {
           this.Load+=f150_Danh_sach_nhan_vien_master_Load;
            
        }

       

        #region Public Interface
        
        #endregion

        #region Members

        string m_txt_path = "";
        int m_trang_thai_buoc_1_sau_hien_thi = -2;
        #endregion

        #region Private methods

        private void f150_Danh_sach_nhan_vien_master_Load(object sender, EventArgs e)
        {
            load_data_to_grid();
        }


        private void load_data_to_grid()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithTableName(v_ds, "V_DM_NHAN_VIEN");
            m_grc.DataSource = v_ds.Tables[0];

            foreach (DevExpress.XtraGrid.Columns.GridColumn col in ((DevExpress.XtraGrid.Views.Base.ColumnView)m_grc.Views[0]).Columns)
            {
                col.MaxWidth = 100;
                col.MinWidth = 100;

            }
        }


        #endregion

        private void m_txt_tai_file_excel_mau_Click(object sender, EventArgs e)
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

        private void m_txt_chon_file_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // Set filter options and filter index.
            openFileDialog1.Filter = "xlsx Files|*.xlsx|xls Files|*.xls|All Files (*.*)|*.*";
            openFileDialog1.Multiselect = false;
            var userClickedOK = openFileDialog1.ShowDialog();
            try
            {


                if (userClickedOK == System.Windows.Forms.DialogResult.OK)
                {
                    m_txt_path = openFileDialog1.FileName;
                    F150_DANH_SACH_NHAN_VIEN_EXCEL v_f = new F150_DANH_SACH_NHAN_VIEN_EXCEL();
                    v_f.displayToInsertExcel(m_txt_path);
                   // WinFormControls.load_xls_to_gridview(m_txt_path, m_grc);
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_them_Click(object sender, EventArgs e)
        {
            f150_danh_muc_nhan_su_v2 v_f = new f150_danh_muc_nhan_su_v2();
            v_f.DisplayForInsert(ref m_trang_thai_buoc_1_sau_hien_thi);
            if (m_trang_thai_buoc_1_sau_hien_thi > 0)
            {
                this.Close();
            }
            load_data_to_grid();
        }

        private void m_cmd_sua_Click(object sender, EventArgs e)
        {
            DataRow v_dr= m_grv.GetDataRow(m_grv.FocusedRowHandle);
            US_DM_NHAN_VIEN v_us= new US_DM_NHAN_VIEN(CIPConvert.ToDecimal(v_dr["ID"].ToString()));
            f150_danh_muc_nhan_su_v2 v_f = new f150_danh_muc_nhan_su_v2();
            v_f.DisplayForUpdate(v_us);
            load_data_to_grid();
        }



        internal void DisplayForPresent(ref int m_trang_thai_buoc_1)
        {
            m_cmd_sua.Enabled = false;
            m_cmd_tai_file_excel_mau.Enabled = false;
            m_cmd_chon_file.Enabled = false;
            this.ShowDialog();
            m_trang_thai_buoc_1 = m_trang_thai_buoc_1_sau_hien_thi;
        }
    }
}
