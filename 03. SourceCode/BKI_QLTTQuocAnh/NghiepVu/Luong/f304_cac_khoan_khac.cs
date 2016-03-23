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
using BKI_DichVuMatDat.COMMON;
using BKI_DichVuMatDat.CONFIRM;
using DevExpress.XtraEditors;
using BKI_DichVuMatDat.NghiepVu.Luong;
namespace BKI_DichVuMatDat
{
    public partial class f304_cac_khoan_khac : Form
    {
        public f304_cac_khoan_khac()
        {
            InitializeComponent();
            //m_dat_time.EditValue = DateTime.Now.Date;
            load_data_to_combobox_khoan_tien();
        }
        public void Display(DateTime ip_dat_thang, decimal ip_dc_id_loai_khoan_tien)
        {
            m_dat_time.EditValue = ip_dat_thang.Date;
            m_cmb_khoan_tien.SelectedValue = ip_dc_id_loai_khoan_tien;
            ShowDialog();
        }
        #region Member
        BindingList<string> m_lst_nhan_vien_khong_ton_tai;
        #endregion

        #region Private Method
        private decimal lay_thang()
        {
            return m_dat_time.DateTime.Month;
        }
        private decimal lay_nam()
        {
            return m_dat_time.DateTime.Year;
        }
        private bool kiem_tra_du_lieu_ma_nhan_vien_truoc_khi_luu()
        {
            var flag = true;
            m_lst_nhan_vien_khong_ton_tai = new BindingList<string>();

            var v_i_row_count = m_grv_main.RowCount;
            for(int v_i_row = 0; v_i_row < v_i_row_count; v_i_row++)
            {
                var v_str_ma_nv = m_grv_main.GetRowCellValue(v_i_row, "MA_NV").ToString();
                if(!ExecuteFuntion.KiemTraNhanVienCoTrongCsdlChua(v_str_ma_nv))
                {
                    flag = false;
                    m_lst_nhan_vien_khong_ton_tai.Add(v_str_ma_nv);
                }
            }
            return flag;
        }
        private bool check_du_lieu()
        {
            var v_i_row_count = m_grv_main.RowCount;
            for(int v_i_row = 0; v_i_row < v_i_row_count; v_i_row++)
            {
                var v_dr = m_grv_main.GetDataRow(v_i_row);
                if(v_dr["MA_NV"] == DBNull.Value)
                {
                    XtraMessageBox.Show("Dữ liệu tại dòng thứ " + v_i_row + 2 + " cột MA_NV bị trống!", "LỖI DỮ LIỆU", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if(v_dr["SO_TIEN"] == DBNull.Value)
                {
                    XtraMessageBox.Show("Dữ liệu tại dòng thứ " + v_i_row + 2 + " cột SO_TIEN bị trống!", "LỖI DỮ LIỆU", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            if(!kiem_tra_du_lieu_ma_nhan_vien_truoc_khi_luu())
            {
                msg003_hien_thi_danh_sach v_msg = new msg003_hien_thi_danh_sach();
                v_msg.Display("THÔNG BÁO", "Các mã nhân viên sau chưa có trong dữ liệu phần mềm", convert_list_to_string(m_lst_nhan_vien_khong_ton_tai));
                return false;
            }
            return true;
        }
        private string convert_list_to_string(BindingList<string> ip_lst_str)
        {
            if(ip_lst_str.Count == 0)
            {
                return "";
            }
            string v_str_op = "";
            foreach(var item in ip_lst_str)
            {
                v_str_op = v_str_op + item + ", ";
            }
            v_str_op = v_str_op.Substring(0, v_str_op.Length - 2);
            return v_str_op;
        }
        
        #endregion


        #region DataStructure
        enum e_col_number
        {
            MA_NV = 0,
            SO_TIEN = 1
        }
        #endregion

        private void f304_cac_khoan_khac_Load(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }

        }

        private void load_data_to_combobox_khoan_tien()
        {
            US_CM_DM_TU_DIEN v_us = new US_CM_DM_TU_DIEN();
            DS_CM_DM_TU_DIEN v_ds = new DS_CM_DM_TU_DIEN();
            v_us.FillDatasetByIdLoaiTuDien(v_ds, 19);
            m_cmb_khoan_tien.DataSource = v_ds.Tables[0];
            m_cmb_khoan_tien.DisplayMember = "TEN";
            m_cmb_khoan_tien.ValueMember = "ID";
        }

        private void m_txt_chon_file_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // Set filter options and filter index.
            openFileDialog1.Filter = "xls Files|*.xls|xlsx Files|*.xls|All Files (*.*)|*.*";
            openFileDialog1.Multiselect = false;
            var userClickedOK = openFileDialog1.ShowDialog();
            try
            {


                if(userClickedOK == System.Windows.Forms.DialogResult.OK)
                {
                    DataTable v_dt_source = new DataTable();
                    WinFormControls.load_xls_to_data_table(openFileDialog1.FileName, ref v_dt_source);
                    m_grc_main.DataSource = v_dt_source;
                }
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_txt_tai_file_excel_mau_Click(object sender, EventArgs e)
        {
            try
            {
                WinFormControls.openTemplate("Template_Import_cac_khoan_tien_khac.xls");
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_txt_luu_Click(object sender, EventArgs e)
        {
            try
            {
                if(TinhLuongQL.Instance.LayThongTinBangLuong(lay_thang(), lay_nam()).CHOT_BANG_LUONG)
                {
                    XtraMessageBox.Show("Bảng lương đã được chốt, bạn không thể thay đổi dữ liệu. Cần bỏ chốt bảng lương trước!", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                if(check_du_lieu())
                {
                    US_GD_CAC_KHOAN_TIEN_KHAC v_us = new US_GD_CAC_KHOAN_TIEN_KHAC();
                    if(v_us.KiemTraCoDuLieu(lay_thang(), lay_nam(), Convert.ToDecimal(m_cmb_khoan_tien.SelectedValue)))
                    {
                        var v_dlg_confirm = XtraMessageBox.Show("Tháng này đã có dữ liệu, bạn có muốn xóa dữ liệu này đi và cập nhật dữ liệu mới?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if(v_dlg_confirm == System.Windows.Forms.DialogResult.No)
                        {
                            return;
                        }
                    }
                    delete_du_lieu_cu();
                    DataTable dataTable = (DataTable)m_grc_main.DataSource;
                    //dataTable = dataTable.Rows.Cast<DataRow>().Where(row => !row.ItemArray.All(field => field is System.DBNull || string.Compare((field as string).Trim(), string.Empty) == 0)).CopyToDataTable();
                    for(int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        DataRow v_dr = dataTable.Rows[i];
                        Gan_du_lieu_cho_us(v_dr);
                    }

                    XtraMessageBox.Show("Đã hoàn tất việc lưu dữ liệu!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }

        }

        private void delete_du_lieu_cu()
        {
            US_GD_CAC_KHOAN_TIEN_KHAC v_us = new US_GD_CAC_KHOAN_TIEN_KHAC();
            v_us.DeleteDuLieuCu(lay_thang(), lay_nam(), Convert.ToDecimal(m_cmb_khoan_tien.SelectedValue));
        }

        private void Gan_du_lieu_cho_us(DataRow v_dr)
        {
            US_GD_CAC_KHOAN_TIEN_KHAC v_us_gdcktk = new US_GD_CAC_KHOAN_TIEN_KHAC();

            v_us_gdcktk.dcID_NHAN_VIEN = ExecuteFuntion.LayNhanVienID(v_dr["MA_NV"].ToString());
            v_us_gdcktk.dcNAM = lay_nam();
            v_us_gdcktk.dcTHANG = lay_thang();
            v_us_gdcktk.dcID_LOAI_KHOAN_TIEN_KHAC = Convert.ToDecimal(m_cmb_khoan_tien.SelectedValue);
            v_us_gdcktk.dcSO_TIEN = Convert.ToDecimal(v_dr["SO_TIEN"]);
            v_us_gdcktk.Insert();
        }
    }
}
