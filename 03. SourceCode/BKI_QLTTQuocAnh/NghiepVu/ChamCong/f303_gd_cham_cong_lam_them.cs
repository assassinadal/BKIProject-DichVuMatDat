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

namespace BKI_DichVuMatDat.NghiepVu
{
    public partial class f303_gd_cham_cong_lam_them : Form
    {
        string m_txt_path;
        int m_so_dong;
        public f303_gd_cham_cong_lam_them()
        {
            InitializeComponent();
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

        private void m_txt_luu_Click(object sender, EventArgs e)
        {
            if ((m_txt_thang.Text == "") ||( m_txt_nam.Text == "") || (m_txt_path == ""))
            {
                MessageBox.Show("Bạn phải hoàn tất bước 1 và bước 2 trước khi lưu dữ liệu!");
            }
            else
            {
                luu_du_lieu();
            }
        }

        private void luu_du_lieu()
        {
            m_so_dong = m_grv.RowCount;
            if (m_so_dong > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Khi thực hiện tác vụ này, phần mềm sẽ xóa dữ liệu cũ về số ngày làm thêm của tất cả nhân viên trong tháng " +m_txt_thang.Text+ ", năm "+ m_txt_nam.Text+", và nhập lại dữ liệu giống như file excel vừa tải lên. Bạn có chắc chắn muốn thực hiện tác vụ này?", "Cảnh báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    delete_du_lieu_cu();
                    luu_du_lieu_so_ngay_lam_them();

                    //load_data_2_grid();

                }
            }
        }

        private void delete_du_lieu_cu()
        {
            US_GD_CHAM_CONG_LAM_THEM v_us = new US_GD_CHAM_CONG_LAM_THEM();
            v_us.DeleteAllChamCongLamThemThang(Convert.ToDecimal(m_txt_thang.Text), Convert.ToDecimal(m_txt_nam.Text));

            //US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            //DataSet v_ds = new DataSet();
            //v_ds.Tables.Add(new DataTable());
            //v_us.FillDatasetWithQuery(v_ds, "delete from gd_cham_cong_lam_them where thang="+ m_txt_thang.Text+ " and nam="+ m_txt_nam.Text);
        }

        private void luu_du_lieu_so_ngay_lam_them()
        {
            for (int i = m_so_dong - 1; i >= 0; i--)
            {
                DataRow v_dr = m_grv.GetDataRow(i);
                if (check_ma_nhan_vien(v_dr))
                {
                    if (check_so_ngay_lam_them(v_dr))
                    {
                        insert_vao_csdl(v_dr);
                    }
                }
            }

            MessageBox.Show("Nhập thành công dữ liệu về số ngày làm thêm của "+ (m_so_dong- m_grv.DataRowCount) + " nhân viên. Kiểm tra lại dữ liệu của những nhân viên còn lại trên lưới( nếu có)! ");
        }

        private void insert_vao_csdl(DataRow v_dr)
        {
            //US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            //DataSet v_ds_nhan_vien = new DataSet();
            //v_ds_nhan_vien.Tables.Add(new DataTable());
            //v_us.FillDatasetWithQuery(v_ds_nhan_vien, "select * from DM_NHAN_VIEN where MA_NV=" + v_dr["MA_NV"].ToString());

            US_DM_NHAN_VIEN v_us = new US_DM_NHAN_VIEN();
            DataSet v_ds_nhan_vien = new DataSet();
            v_ds_nhan_vien.Tables.Add(new DataTable());
            v_us.LayThongTinNhanVien(v_ds_nhan_vien, v_dr["MA_NV"].ToString());

            US_GD_CHAM_CONG_LAM_THEM v_us_gd_cclt = new US_GD_CHAM_CONG_LAM_THEM();
            v_us_gd_cclt.dcID_NHAN_VIEN = CIPConvert.ToDecimal(v_ds_nhan_vien.Tables[0].Rows[0]["ID"].ToString());
            v_us_gd_cclt.dcNAM = CIPConvert.ToDecimal(m_txt_nam.Text);
            v_us_gd_cclt.dcTHANG = CIPConvert.ToDecimal(m_txt_thang.Text);
            v_us_gd_cclt.dcSO_NGAY_LAM_THEM=CIPConvert.ToDecimal(v_dr["SO_NGAY_LAM_THEM"].ToString());
            try
            {
                v_us_gd_cclt.Insert();
                v_dr.Delete();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
                //MessageBox.Show("Đã tồn tại 1 dòng dữ liệu về số ngày làm thêm của nhân viên " + v_dr["MA_NV"].ToString() + " trong tháng "+ m_txt_thang.Text+ ", năm "+ m_txt_nam.Text+ ". Vui lòng kiểm tra lại thông tin!" );
            }
        }

        private bool check_so_ngay_lam_them(DataRow v_dr)
        {
            decimal  v_dc_so_ngay_lam_them;
            if (!decimal.TryParse(v_dr["SO_NGAY_LAM_THEM"].ToString(),out v_dc_so_ngay_lam_them))
            {
                MessageBox.Show("Kiểm tra lại dữ liệu về Số ngày làm thêm của nhân viên có mã "+ v_dr["MA_NV"].ToString());
                return false;
            }
            return true;
        }

        private bool check_ma_nhan_vien(DataRow v_dr)
        {
            //US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            //DataSet v_ds_nhan_vien = new DataSet();
            //v_ds_nhan_vien.Tables.Add(new DataTable());
            //v_us.FillDatasetWithQuery(v_ds_nhan_vien,"select * from DM_NHAN_VIEN where MA_NV="+ v_dr["MA_NV"].ToString());

            US_DM_NHAN_VIEN v_us = new US_DM_NHAN_VIEN();
            v_us.IsExistNhanVienInDB(v_dr["MA_NV"].ToString());

            if(!v_us.IsExistNhanVienInDB(v_dr["MA_NV"].ToString()))
            {
                MessageBox.Show("Mã nhân viên "+ v_dr["MA_NV"].ToString()+ " không tồn tại. Vui lòng kiểm tra lại thông tin!");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void m_txt_tai_file_excel_mau_Click(object sender, EventArgs e)
        {
            try
            {

                string fileName = "ChamCongLamThem.xlsx";
                string sourcePath = (Directory.GetCurrentDirectory() + "\\Template");
                string targetPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
                string destFile = System.IO.Path.Combine(targetPath, fileName);
                if (!System.IO.Directory.Exists(targetPath))
                {
                    System.IO.Directory.CreateDirectory(targetPath);
                }
                System.IO.File.Copy(sourceFile, destFile, true);
                string newpath = targetPath + "\\ChamCongLamThem.xlsx";
                var excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = true;
                Microsoft.Office.Interop.Excel.Workbooks books = excel.Workbooks;
                Microsoft.Office.Interop.Excel.Workbook openexcel = books.Open(newpath);
            }
            catch (Exception v_e)
            {
                MessageBox.Show("File này đang được mở. Vui lòng đóng file lại để có thể thực hiện được tác vụ này!");
            }
        }

      
    }
}
