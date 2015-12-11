﻿using BKI_DichVuMatDat.DS;
using BKI_DichVuMatDat.US;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
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

namespace BKI_DichVuMatDat.NghiepVu
{
    public partial class f316_tinh_thuong_2014 : Form
    {
        private bool m_b_imported = false;

        #region Public Interface
        public f316_tinh_thuong_2014()
        {
            InitializeComponent();
            format_control();
        }
        #endregion

        #region Private Method
        private bool validate_control_empty(params Control[] controls)
        {
            var isValidated = false;

            foreach(var control in controls)
            {
                control.BackColor = Color.White;
                var typeOfControl = control.GetType().ToString();

                switch(typeOfControl)
                {
                    case "DevExpress.XtraEditors.TextEdit":
                        {
                            var controlTextEdit = control as TextEdit;
                            isValidated = (controlTextEdit.Text.Trim() != "");
                            break;
                        }
                    case "DevExpress.XtraEditors.MemoEdit":
                        {
                            var controlMemoEdit = control as MemoEdit;
                            isValidated = (controlMemoEdit.Text.Trim() != "");
                            break;
                        }
                    case "DevExpress.XtraEditors.DateEdit":
                        {
                            var controlDateEdit = control as DateEdit;
                            isValidated = (controlDateEdit.EditValue != null);
                            break;
                        }
                    case "DevExpress.XtraEditors.ComboBoxEdit":
                        {
                            var controlComboBoxEdit = control as ComboBoxEdit;
                            isValidated = (controlComboBoxEdit.EditValue != null);
                            break;
                        }
                    case "DevExpress.XtraEditors.ButtonEdit":
                        {
                            var controlButtonEdit = control as ButtonEdit;
                            isValidated = (controlButtonEdit.EditValue != null);
                            break;
                        }
                    case "DevExpress.XtraEditors.CheckEdit":
                        {
                            var controlCheckEdit = control as CheckEdit;
                            isValidated = (controlCheckEdit.EditValue != null);
                            break;
                        }
                    case "DevExpress.XtraEditors.SpinEdit":
                        {
                            var controlSpinEdit = control as SpinEdit;
                            isValidated = (controlSpinEdit.EditValue != null);
                            break;
                        }
                    case "DevExpress.XtraEditors.LookUpEdit":
                        {
                            var controlLookUpEdit = control as LookUpEdit;
                            isValidated = (controlLookUpEdit.EditValue != null);
                            break;
                        }
                    case "DevExpress.XtraEditors.SearchLookUpEdit":
                        {
                            var controlSearchLookUpEdit = control as SearchLookUpEdit;
                            isValidated = (controlSearchLookUpEdit.EditValue != null && controlSearchLookUpEdit.EditValue.ToString().Trim() != string.Empty);
                            break;
                        }
                    case "DevExpress.XtraEditors.CheckedComboBoxEdit":
                        {
                            var controlCheckedComboBoxEdit = control as CheckedComboBoxEdit;
                            isValidated = (controlCheckedComboBoxEdit.EditValue != null && controlCheckedComboBoxEdit.EditValue.ToString().Trim() != string.Empty);
                            break;
                        }
                    default:
                        break;
                }

                if(!isValidated)
                {
                    control.Focus();
                    control.BackColor = Color.Pink;
                    break;
                }
            }
            return isValidated;
        }
        private void format_control()
        {
            set_define_event();
        }

        private DS_V_GD_QUY_TIEN_THUONG LayDanhSachQuyTienThuong()
        {
            DS_V_GD_QUY_TIEN_THUONG v_ds_quy_tien_thuong = new DS_V_GD_QUY_TIEN_THUONG();
            US_V_GD_QUY_TIEN_THUONG v_us_quy_tien_thuong = new US_V_GD_QUY_TIEN_THUONG();
            v_us_quy_tien_thuong.FillDataSetAll(out v_ds_quy_tien_thuong);
            return v_ds_quy_tien_thuong;
        }
        private void fill_data_quy_tien_thuong()
        {
            var dataset = LayDanhSachQuyTienThuong();
            m_sle_quy_tien_thuong.Properties.DataSource = dataset.Tables[0];
        }
        private void hien_thi_form_them_quy_tien()
        {
            f354_danh_sach_quy_thuong_de v_frm = new f354_danh_sach_quy_thuong_de();
            var v_us_quy_tien = v_frm.Display_for_thuong_2014();
            if(v_us_quy_tien.dcID > 0)
            {
                m_sle_quy_tien_thuong.EditValue = v_us_quy_tien.dcID;
            }
        }

        private void handle_form_load()
        {
            fill_data_quy_tien_thuong();
            m_sle_quy_tien_thuong.EditValueChanged += m_sle_quy_tien_thuong_EditValueChanged;
        }
        private void xuat_excel()
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "xls files (*.xls)|*.xls|All files (*.*)|*.*";
            saveFileDialog1.RestoreDirectory = true;
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                m_grv_main.ExportToXls(saveFileDialog1.FileName);
                DevExpress.XtraEditors.XtraMessageBox.Show("Lưu file Excel thành công");
            }
        }
        private void fill_data_2_grid()
        {
            US_DUNG_CHUNG v_us_dung_chung = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add();
            v_us_dung_chung.FillDatasetWithTableName(v_ds, "V_DM_NHAN_VIEN");
            v_ds.Tables[0].Columns.Add("PHAN_TRAM_THUE");
            foreach(DataRow v_dr in v_ds.Tables[0].Rows)
            {
                v_dr["PHAN_TRAM_THUE"] = m_txt_thue.EditValue;
            }
            m_grc_main.DataSource = v_ds.Tables[0];
        }
        private void fill_data_2_grid_from_excel(string ip_str_path)
        {
            //m_grv_main.Columns.Clear();
            WinFormControls.load_xls_to_gridview(ip_str_path, m_grc_main);
            var v_dr = (DataRow)m_sle_quy_tien_thuong.Properties.View.GetFocusedDataRow();
            var v_tong_tien = (decimal)v_dr["SO_TIEN"];
            var datasource = (DataTable)m_grc_main.DataSource;
            //Lay tong he so
            decimal tong_he_so = 0;
            foreach(DataRow item in datasource.Rows)
            {
                if(item["HS_THUONG"] != DBNull.Value)
                {
                    tong_he_so = tong_he_so + Convert.ToDecimal(item["HS_THUONG"]);
                }

            }
            if(tong_he_so == 0)
            {
                MessageBox.Show("Lỗi do tổng hệ số thưởng = 0");
                return;
            }
            //
            foreach(DataRow item in datasource.Rows)
            {
                if(item["HS_THUONG"] != DBNull.Value)
                {
                    var thanh_tien = v_tong_tien / tong_he_so * Convert.ToDecimal(item["HS_THUONG"]);
                    item["THANH_TIEN"] = thanh_tien;
                    item["THUE"] = thanh_tien * Convert.ToDecimal(item["PHAN_TRAM_THUE"]) / 100;
                    item["THUC_LINH"] = Convert.ToDecimal(item["THANH_TIEN"]) - Convert.ToDecimal(item["THUE"]);
                }
            }
            m_b_imported = true;
        }
        private bool is_valid_data()
        {
            if(m_sle_quy_tien_thuong.Text == m_sle_quy_tien_thuong.Properties.NullText)
            {
                return false;

            }
            return true;
        }
        private void data_row_2_us(DataRow ip_dr_du_lieu_1_nv, ref US_GD_THU_NHAP_KHAC ref_us)
        {
            var v_dr = (DataRow)m_sle_quy_tien_thuong.Properties.View.GetFocusedDataRow();

            ref_us.dcID_NHAN_VIEN = Convert.ToDecimal(ip_dr_du_lieu_1_nv["ID"]);
            ref_us.dcSO_TIEN = Convert.ToDecimal(ip_dr_du_lieu_1_nv["THANH_TIEN"]);
            ref_us.dcTHANG = Convert.ToDecimal(v_dr["THANG"]);
            ref_us.dcNAM = Convert.ToDecimal(v_dr["NAM"]);
            ref_us.dcID_CACH_TINH_THUE = CONST_ID_LOAI_CACH_TINH_THUE.THUE_THANG;
            ref_us.dcID_LOAI_THU_NHAP_KHAC = CONST_ID_LOAI_THU_NHAP_KHAC.LINH_CO_THUE;
            ref_us.dcID_QUY_TIEN_THUONG = Convert.ToDecimal(m_sle_quy_tien_thuong.EditValue);

            // ref_us.dcSO_TIEN_GIAM_TRU = Convert.ToDecimal(ip_dr_du_lieu_1_nv[""]);
            ref_us.dcSO_TIEN_NOP_THE = Convert.ToDecimal(ip_dr_du_lieu_1_nv["THUE"]);
            ref_us.dcSO_TIEN_THUC_LINH = Convert.ToDecimal(ip_dr_du_lieu_1_nv["THUC_LINH"]);
            // ref_us.dcTONG_HS_ATHK = Convert.ToDecimal(ip_dr_du_lieu_1_nv["TONG_HS_ATHK"]);
        }
        private void save_data()
        {
            try
            {
                var rowCount = m_grv_main.RowCount;
                US_GD_THU_NHAP_KHAC v_us_gd_thu_nhap_khac = new US_GD_THU_NHAP_KHAC();
                splashScreenManager1.ShowWaitForm();

                for(int i = 0; i < rowCount - 1; i++)
                {
                    var dr = m_grv_main.GetDataRow(i);
                    var is_exist = v_us_gd_thu_nhap_khac.KiemTraXemDaInsertThuong2014Chua(Convert.ToDecimal(m_sle_quy_tien_thuong.EditValue), Convert.ToDecimal(dr["ID"]));
                    if(is_exist)
                    {
                        continue;
                    }
                    if(dr["HS_THUONG"].ToString() == "")
                    {
                        continue;
                    }
                    data_row_2_us(dr, ref v_us_gd_thu_nhap_khac);
                    v_us_gd_thu_nhap_khac.Insert();
                }
                //
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                splashScreenManager1.CloseWaitForm();
            }

        }
        #endregion

        #region Event Handle
        private void set_define_event()
        {
            Load += f316_tinh_thuong_2014_Load;
            m_cmd_them_quy_tien.Click += m_cmd_them_quy_tien_Click;
            m_cmd_xuat_excel_nhan_vien.Click += m_cmd_xuat_excel_nhan_vien_Click;
            m_cmd_import_excel.Click += m_cmd_import_excel_Click;
            m_cmd_save.Click += m_cmd_save_Click;
        }

        void m_cmd_save_Click(object sender, EventArgs e)
        {
            try
            {
                if(!is_valid_data())
                {
                    return;
                }
                if(m_grv_main.RowCount <= 0)
                {
                    return;
                }
                if(m_b_imported == false)
                {
                    MessageBox.Show("Có lỗi xảy ra, không thể lưu dữ liệu");
                    return;
                }
                save_data();
                MessageBox.Show("Lưu dữ liệu thưởng thành công");
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_sle_quy_tien_thuong_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                var v_dr = (DataRow)m_sle_quy_tien_thuong.Properties.View.GetFocusedDataRow();
                if(v_dr != null)
                {
                    m_txt_tong_tien.EditValue = v_dr["SO_TIEN"];
                }
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_import_excel_Click(object sender, EventArgs e)
        {
            try
            {
                if(!is_valid_data())
                {
                    return;
                }
                fill_data_2_grid_from_excel(WinFormControls.openFileDialog());

            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_xuat_excel_nhan_vien_Click(object sender, EventArgs e)
        {
            try
            {
                if(!is_valid_data())
                {
                    return;
                }
                fill_data_2_grid();
                xuat_excel();

            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_them_quy_tien_Click(object sender, EventArgs e)
        {
            try
            {
                hien_thi_form_them_quy_tien();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void f316_tinh_thuong_2014_Load(object sender, EventArgs e)
        {
            try
            {
                handle_form_load();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        #endregion
    }
}
