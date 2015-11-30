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
using IP.Core.IPSystemAdmin;


namespace BKI_DichVuMatDat.NghiepVu
{
    public partial class f380_thay_doi_he_so_chat_luong_xls : Form
    {
        public f380_thay_doi_he_so_chat_luong_xls()
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
            FormatControl.SetVisibleSimpleButton(this);
            this.m_grv_them_hs.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(WinFormControls.m_grv_PopupMenuShowing);
            this.m_grv_them_hs.OptionsPrint.AutoWidth = false;
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
            v_us_dc.FillDatasetWithQuery(v_ds, "SELECT * FROM DM_NHAN_VIEN WHERE MA_NV ='" + v_data_row[1].ToString() + "'");
            v_id_nv = CIPConvert.ToDecimal(v_ds.Tables[0].Rows[0]["ID"].ToString());
        }

        private void delete_gd_da_co_trong_thang_cua_nhan_vien(US_DUNG_CHUNG v_us_dc, DataRow v_data_row, decimal ip_dc_id_nv)
        {
            decimal v_id_gd_hs_chat_luong = 0;
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us_dc.FillDatasetWithQuery(v_ds, "SELECT * FROM GD_HE_SO_CHAT_LUONG WHERE ID_NHAN_VIEN =" + ip_dc_id_nv + " AND THANG = " + CIPConvert.ToDecimal(m_txt_chon_thang.Text.Trim()) + " AND NAM = " + CIPConvert.ToDecimal(m_txt_chon_nam.Text.Trim()));
            if (v_ds.Tables[0].Rows.Count > 0)
            {
                v_id_gd_hs_chat_luong = CIPConvert.ToDecimal(v_ds.Tables[0].Rows[0]["ID"].ToString());
                US_GD_HE_SO_CHAT_LUONG v_us_gd_hs_cl = new US_GD_HE_SO_CHAT_LUONG(v_id_gd_hs_chat_luong);
                v_us_gd_hs_cl.BeginTransaction();
                v_us_gd_hs_cl.Delete();
                v_us_gd_hs_cl.CommitTransaction();
            }
            else
            {
                return;
            }
        }

        private void kiem_tra_va_thuc_hien_nhap_hs(ref decimal v_count, ref int v_int_khong_nhap_duoc, decimal v_selectedRowCount)
        {
            if (CHRMCommon.thang_da_chot_bang_luong(CIPConvert.ToDecimal(m_txt_chon_thang.Text.Trim()), CIPConvert.ToDecimal(m_txt_chon_nam.Text.Trim())))
            {
                CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_THANG_DA_CHOT_BANG_LUONG);
                return;
            }
            else
            {
                for (int i = 0; i < v_selectedRowCount; i++)
                {
                    decimal v_id_nv = 0;
                    US_DUNG_CHUNG v_us_dc = new US_DUNG_CHUNG();
                    US_GD_HE_SO_CHAT_LUONG v_us_hs_cl = new US_GD_HE_SO_CHAT_LUONG();

                    var v_data_row = m_grv_them_hs.GetDataRow(m_grv_them_hs.GetSelectedRows()[i]);

                    try
                    {
                        get_id_nhan_vien_tu_data_row(v_us_dc, v_data_row, ref v_id_nv);
                    }
                    catch (Exception)
                    {
                        CHRM_BaseMessages.MsgBox_Error("Mã nhân viên " + v_data_row[1].ToString() + " không tồn tại trong hệ thống. Vui lòng kiểm tra lại thông tin!");
                        v_int_khong_nhap_duoc++;
                        continue;
                    }

                    v_us_hs_cl.dcID_NHAN_VIEN = v_id_nv;
                    v_us_hs_cl.dcHE_SO_K = Convert.ToDecimal(v_data_row["HSK"]);
                    v_us_hs_cl.dcTHANG = CIPConvert.ToDecimal(m_txt_chon_thang.Text.Trim());
                    v_us_hs_cl.dcNAM = CIPConvert.ToDecimal(m_txt_chon_nam.Text.Trim());
                    v_us_hs_cl.datNGAY_LAP = DateTime.Now.Date;
                    v_us_hs_cl.strNGUOI_LAP = CAppContext_201.getCurrentUserName();
                    v_us_hs_cl.strDA_XOA = "N";

                    try
                    {
                        delete_gd_da_co_trong_thang_cua_nhan_vien(v_us_dc, v_data_row, v_id_nv);
                        v_us_hs_cl.BeginTransaction();
                        v_us_hs_cl.Insert();
                        v_us_hs_cl.CommitTransaction();
                        v_count++;
                    }
                    catch (Exception)
                    {
                        CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_DA_CO_LOI_XAY_RA);
                        v_int_khong_nhap_duoc++;
                    }
                }
            }
        }

        #endregion

        private void set_define_events()
        {
            this.Load += f380_thay_doi_he_so_chat_luong_Load;
            //cmd
            m_cmd_mo_file_mau.Click += m_cmd_mo_file_mau_Click;
            m_cmd_chon_file.Click += m_cmd_chon_file_Click;
            m_cmd_luu_hs_cl.Click += m_cmd_nhap_cham_cong_Click;
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

        void m_cmd_mo_file_mau_Click(object sender, EventArgs e)
        {
            try
            {
                //WinFormControls.openTemplate("HeSoChatLuong.xlsx");
                tao_file_mau();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void tao_file_mau()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.get_bang_cham_cong(v_ds, m_txt_chon_thang.Text, m_txt_chon_nam.Text);

            var v_c_hsk = new DataColumn();
            v_c_hsk.ColumnName = "HSK";
            v_ds.Tables[0].Columns.Add(v_c_hsk);
            m_grc_them_hs.DataSource = v_ds.Tables[0];
            SaveXLSX();
        }

        private void SaveXLSX()
        {
            string targetPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string newpath = targetPath + "\\" + "Hệ số chất lượng tháng " + m_txt_chon_thang.Text + "-" + m_txt_chon_nam.Text + ".xls";
            m_grv_them_hs.ExportToXls(newpath);
            DevExpress.XtraEditors.XtraMessageBox.Show("Đã lưu file mẫu tại " + newpath);
            var process = new System.Diagnostics.Process();
            process.StartInfo.FileName = newpath;
            process.StartInfo.Verb = "Open";
            process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
            process.Start();
        }

        void m_cmd_chon_file_Click(object sender, EventArgs e)
        {
            try
            {
                load_data_2_grid(WinFormControls.openFileDialog());
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_nhap_cham_cong_Click(object sender, EventArgs e)
        {
            try
            {
                decimal v_count = 0;
                int v_int_khong_nhap_duoc = 0;
                decimal v_selectedRowCount = m_grv_them_hs.SelectedRowsCount;
                if (v_selectedRowCount > 0)
                {
                    kiem_tra_va_thuc_hien_nhap_hs(ref v_count, ref v_int_khong_nhap_duoc, v_selectedRowCount);

                    if (v_count == v_selectedRowCount)
                    {
                        CHRM_BaseMessages.MsgBox_Infor("Cập nhật thành công cho " + v_count + " nhân viên");
                    }
                    else
                    {
                        CHRM_BaseMessages.MsgBox_Infor("Cập nhật thành công cho " + v_count + " nhân viên. Vui lòng kiểm tra lại thông tin của " + (v_selectedRowCount - v_count).ToString() + " nhân viên được chọn còn lại trong bảng!");
                    }
                }
                else
                {
                    CHRM_BaseMessages.MsgBox_Infor("Bạn phải chọn nhân viên để nhập thu nhập khác cho họ!");
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }

        }

    }
}
