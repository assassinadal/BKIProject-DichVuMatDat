using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IP.Core.IPCommon;
using BKI_DichVuMatDat.DS;
using BKI_DichVuMatDat.US;
using System.IO;

namespace BKI_DichVuMatDat
{
    public partial class f304_cac_khoan_khac : Form
    {

        string m_txt_path = "";
        public f304_cac_khoan_khac()
        {
            InitializeComponent();

        }

    
       
        private void m_txt_thang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void m_txt_nam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void f304_cac_khoan_khac_Load(object sender, EventArgs e)
        {
            try
            {
                load_data_to_combobox_khoan_tien();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
           
        }

        private void load_data_to_combobox_khoan_tien()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetCBO(v_ds, "CM_DM_TU_DIEN", "ID", "TEN", "WHERE ID_LOAI_TU_DIEN=19");
            m_cmb_khoan_tien.DataSource = v_ds.Tables[0];
            m_cmb_khoan_tien.DisplayMember = "TEN";
            m_cmb_khoan_tien.ValueMember = "ID";
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
                    WinFormControls.load_xls_to_gridview(m_txt_path, m_grc);
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_txt_tai_file_excel_mau_Click(object sender, EventArgs e)
        {
            try
            {

                string fileName = "CacKhoanTienKhac.xlsx";
                string sourcePath = (Directory.GetCurrentDirectory() + "\\Template");
                string targetPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
                string destFile = System.IO.Path.Combine(targetPath, fileName);
                if (!System.IO.Directory.Exists(targetPath))
                {
                    System.IO.Directory.CreateDirectory(targetPath);
                }
                System.IO.File.Copy(sourceFile, destFile, true);
                string newpath = targetPath + "\\CacKhoanTienKhac.xlsx";
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

        private void m_txt_luu_Click(object sender, EventArgs e)
        {
            try
            {
                if(m_txt_thang.Text == "" || m_txt_nam.Text == "" || m_txt_path == "")
                {
                    MessageBox.Show("Bạn phải điền đầy đủ thông tin ở bước 1 và bước 2!");
                }
                else
                {
                    if(check_du_lieu())
                    {
                        delete_du_lieu_cu();
                        DataTable dataTable = (DataTable)m_grc.DataSource;
                        dataTable = dataTable.Rows.Cast<DataRow>().Where(row => !row.ItemArray.All(field => field is System.DBNull || string.Compare((field as string).Trim(), string.Empty) == 0)).CopyToDataTable();
                        for(int i = 0; i < dataTable.Rows.Count; i++)
                        {
                            DataRow v_dr = dataTable.Rows[i];
                            Gan_du_lieu_cho_us(v_dr);
                        }

                        MessageBox.Show("Đã hoàn tất!");
                    }
                }
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
            
        }

        private void delete_du_lieu_cu()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithQuery(v_ds, "delete from gd_cac_khoan_tien_khac where thang=" + m_txt_thang.Text + " and nam=" + m_txt_nam.Text);
        }

        private void Gan_du_lieu_cho_us(DataRow v_dr)
        {
            US_GD_CAC_KHOAN_TIEN_KHAC v_us_gdcktk = new US_GD_CAC_KHOAN_TIEN_KHAC();
            US_DUNG_CHUNG v_usdc = new US_DUNG_CHUNG();
            DataSet v_ds_nhan_vien = new DataSet();
            v_ds_nhan_vien.Tables.Add(new DataTable());
            v_usdc.FillDatasetWithQuery(v_ds_nhan_vien, "select * from DM_NHAN_VIEN where MA_NV=" + v_dr["MA_NV"].ToString());
            v_us_gdcktk.dcID_NHAN_VIEN = CIPConvert.ToDecimal(v_ds_nhan_vien.Tables[0].Rows[0]["ID"].ToString());
            v_us_gdcktk.dcNAM = CIPConvert.ToDecimal(m_txt_nam.Text);
            v_us_gdcktk.dcTHANG = CIPConvert.ToDecimal(m_txt_thang.Text);
            v_us_gdcktk.dcID_LOAI_KHOAN_TIEN_KHAC = CIPConvert.ToDecimal(m_cmb_khoan_tien.SelectedValue);
            v_us_gdcktk.dcSO_TIEN= CIPConvert.ToDecimal(v_dr["SO_TIEN"].ToString());
            v_us_gdcktk.Insert();
        }

        private bool check_du_lieu()
        {
            return true;
        }
    }
}
