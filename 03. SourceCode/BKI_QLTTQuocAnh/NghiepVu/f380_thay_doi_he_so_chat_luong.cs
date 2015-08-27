using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BKI_DichVuMatDat;
using BKI_DichVuMatDat.DS;
using BKI_DichVuMatDat.US;
using IP.Core.IPCommon;
using BKI_DichVuMatDat.DS.CDBNames;
using DevExpress.XtraEditors;
using System.Globalization;


namespace BKI_DichVuMatDat.NghiepVu
{
    public partial class f380_thay_doi_he_so_chat_luong : Form
    {
        public f380_thay_doi_he_so_chat_luong()
        {
            InitializeComponent();
            format_controls();
        }

        #region Public Interface
        public void display()
        {
            this.ShowDialog();
        }
        #endregion

        #region Members
        string m_str_path = "";
        #endregion

        #region Private methods
        private void format_controls()
        {
            set_define_events();
            this.KeyPreview = true;
        }

        private void set_initial_form_load()
        {
            m_txt_chon_thang.Text = DateTime.Now.Month.ToString();
            m_txt_chon_nam.Text = DateTime.Now.Year.ToString();
        }

        private void load_data_2_grid(string ip_str_path)
        {
            WinFormControls.load_xls_to_gridview(ip_str_path, m_grc_them_hs);
        }

        private void get_id_nhan_vien_tu_data_row(US_DUNG_CHUNG v_us_dc, DataRow v_data_row, ref decimal v_id_nv)
        {
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us_dc.FillDatasetWithQuery(v_ds, "SELECT * FROM DM_NHAN_VIEN WHERE MA_NV ='" + v_data_row["MA_NHAN_VIEN"].ToString() + "'");
            v_id_nv = CIPConvert.ToDecimal(v_ds.Tables[0].Rows[0]["ID"].ToString());
        }

        private void kiem_tra_va_thuc_hien_nhap_hs(ref decimal v_count, ref int v_int_khong_nhap_duoc, decimal v_selectedRowCount)
        {
            for (int i = 0; i < v_selectedRowCount; i++)
            {
                decimal v_id_nv = 0;
                US_DUNG_CHUNG v_us_dc = new US_DUNG_CHUNG();
                US_GD_HE_SO_CHAT_LUONG v_us_gs_cl = new US_GD_HE_SO_CHAT_LUONG();

                var v_data_row = m_grv_them_hs.GetDataRow(m_grv_them_hs.GetSelectedRows()[v_int_khong_nhap_duoc]);

                try
                {
                    get_id_nhan_vien_tu_data_row(v_us_dc, v_data_row, ref v_id_nv);
                }
                catch (Exception)
                {
                    MessageBox.Show("Mã nhân viên " + v_data_row["MA_NHAN_VIEN"].ToString() + " không tồn tại trong hệ thống. Vui lòng kiểm tra lại thông tin!");
                    v_int_khong_nhap_duoc++;
                    continue;
                }
                v_us_gs_cl.dcID_NHAN_VIEN = v_id_nv;
                v_us_gs_cl.dcHE_SO_K = CIPConvert.ToDecimal(v_data_row["HE_SO"].ToString());
                v_us_gs_cl.dcTHANG = CIPConvert.ToDecimal(m_txt_chon_thang.Text.Trim());
                v_us_gs_cl.dcNAM = CIPConvert.ToDecimal(m_txt_chon_nam.Text.Trim());
                v_us_gs_cl.datNGAY_LAP = DateTime.Now.Date;
                v_us_gs_cl.strDA_XOA = "N";

                try
                {
                    v_us_gs_cl.BeginTransaction();
                    v_us_gs_cl.Insert();
                    v_us_gs_cl.CommitTransaction();
                    v_count++;
                }
                catch (Exception)
                {
                    MessageBox.Show("Lỗi!");
                    v_int_khong_nhap_duoc++;
                }
            }
            if (v_count == v_selectedRowCount)
            {
                MessageBox.Show("Cập nhật thành công cho " + v_count + " nhân viên");
            }
            else
            {
                MessageBox.Show("Cập nhật thành công cho " + v_count + " nhân viên. Vui lòng kiểm tra lại thông tin của " + (v_selectedRowCount - v_count).ToString() + " nhân viên được chọn còn lại trong bảng!");
            }
        }

        #endregion

        private void set_define_events()
        {
            this.Load += f380_thay_doi_he_so_chat_luong_Load;
            //cmd
            m_cmd_chon_file.Click += m_cmd_chon_file_Click;
            m_cmd_insert.Click += m_cmd_insert_Click;
        }

        void f380_thay_doi_he_so_chat_luong_Load(object sender, EventArgs e)
        {
            try
            {
                set_initial_form_load();
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
                string v_str_path = "";
                f381_thay_doi_he_so_chat_luong_de v_frm_de = new f381_thay_doi_he_so_chat_luong_de();
                v_frm_de.display(ref v_str_path);
                m_str_path = v_str_path;
                load_data_2_grid(m_str_path);
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_insert_Click(object sender, EventArgs e)
        {
            try
            {
                decimal v_count = 0;
                int v_int_khong_nhap_duoc = 0;
                decimal v_selectedRowCount = m_grv_them_hs.SelectedRowsCount;
                if (v_selectedRowCount > 0)
                {
                    kiem_tra_va_thuc_hien_nhap_hs(ref v_count, ref v_int_khong_nhap_duoc, v_selectedRowCount);
                }
                else
                {
                    MessageBox.Show("Bạn phải chọn nhân viên để nhập hệ số cho họ!");
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }

        }

    }
}
