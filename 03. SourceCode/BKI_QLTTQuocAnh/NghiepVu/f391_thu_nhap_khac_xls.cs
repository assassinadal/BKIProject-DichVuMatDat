using BKI_DichVuMatDat.DS;
using BKI_DichVuMatDat.US;
using DevExpress.XtraEditors;
using IP.Core.IPCommon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BKI_DichVuMatDat.NghiepVu
{
    public partial class f391_thu_nhap_khac_xls : Form
    {
        public f391_thu_nhap_khac_xls()
        {
            InitializeComponent();
            format_controls();
        }

        #region Public interface

        #endregion

        #region Members

        #endregion

        #region Private Methods
        private void format_controls()
        {
            FormatControl.SetVisibleSimpleButton(this);
            this.m_grv_quan_ly_thu_nhap_khac.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(WinFormControls.m_grv_PopupMenuShowing);
            this.m_grv_quan_ly_thu_nhap_khac.OptionsPrint.AutoWidth = false;
            set_define_events();
            this.KeyPreview = true;
        }

        private void set_intial_form_load()
        {
            m_txt_chon_thang.Text = DateTime.Now.Month.ToString();
            m_txt_chon_nam.Text = DateTime.Now.Year.ToString();
        }

        private void load_data_2_grid(string ip_str_path)
        {
            WinFormControls.load_xls_to_gridview(ip_str_path, m_grc_quan_ly_thu_nhap_khac);
        }

        private void get_id_nhan_vien_tu_data_row(US_DUNG_CHUNG v_us_dc, DataRow v_data_row, ref decimal v_id_nv)
        {
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us_dc.FillDatasetWithQuery(v_ds, "SELECT * FROM DM_NHAN_VIEN WHERE MA_NV ='" + v_data_row[1].ToString() + "'");
            v_id_nv = CIPConvert.ToDecimal(v_ds.Tables[0].Rows[0]["ID"].ToString());
        }

        private decimal find_id_loai_thu_nhap_khac(string ip_str_loai_thu_nhap)
        {
            try
            {
                US_CM_DM_TU_DIEN v_us = new US_CM_DM_TU_DIEN();
                DS_CM_DM_TU_DIEN v_ds = new DS_CM_DM_TU_DIEN();

                v_us.FillDataset(v_ds);

                string v_str_filter = "TEN = '" + ip_str_loai_thu_nhap + "'";
                DataRow[] v_dr = v_ds.CM_DM_TU_DIEN.Select(v_str_filter);

                if (v_dr.Count() == 0)
                {
                    return -1;
                }
                else
                {
                    return CIPConvert.ToDecimal(v_dr.First()["ID"].ToString());
                }

            }
            catch (Exception v_e)
            {
                throw v_e;
            }
        }

        private decimal find_id_cach_tinh_thue(string ip_str_cach_tinh_thue)
        {
            try
            {
                US_CM_DM_TU_DIEN v_us = new US_CM_DM_TU_DIEN();
                DS_CM_DM_TU_DIEN v_ds = new DS_CM_DM_TU_DIEN();

                v_us.FillDataset(v_ds);

                string v_str_filter = "TEN = '" + ip_str_cach_tinh_thue + "'";
                DataRow[] v_dr = v_ds.CM_DM_TU_DIEN.Select(v_str_filter);

                if (v_dr.Count() == 0)
                {
                    return -1;
                }
                else
                {
                    return CIPConvert.ToDecimal(v_dr.First()["ID"].ToString());
                }

            }
            catch (Exception v_e)
            {
                throw v_e;
            }
        }

        private void form_2_us_gd_thu_nhap_khac(US_GD_THU_NHAP_KHAC ip_us, decimal ip_dc_id_nv, DataRow v_data_row)
        {
            ip_us.dcID_NHAN_VIEN = ip_dc_id_nv;
            ip_us.dcSO_TIEN = CIPConvert.ToDecimal(v_data_row[4].ToString());
            ip_us.dcTHANG = CIPConvert.ToDecimal(m_txt_chon_thang.Text.Trim());
            ip_us.dcNAM = CIPConvert.ToDecimal(m_txt_chon_nam.Text.Trim());
            ip_us.dcID_LOAI_THU_NHAP_KHAC = find_id_loai_thu_nhap_khac(v_data_row[2].ToString());
            ip_us.dcID_CACH_TINH_THUE = find_id_cach_tinh_thue(v_data_row[3].ToString());
            ip_us.strLY_DO = v_data_row[5].ToString();
        }

        private void delete_gd_da_co_trong_thang_cua_nhan_vien(US_DUNG_CHUNG v_us_dc, DataRow v_data_row, decimal ip_dc_id_nv)
        {
            decimal v_id_gd_thu_nhap_khac = 0;
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us_dc.FillDatasetWithQuery(v_ds, "SELECT * FROM GD_THU_NHAP_KHAC WHERE ID_NHAN_VIEN =" + ip_dc_id_nv + " AND THANG = " + CIPConvert.ToDecimal(m_txt_chon_thang.Text.Trim()) + " AND NAM = " + CIPConvert.ToDecimal(m_txt_chon_nam.Text.Trim()));
            if (v_ds.Tables[0].Rows.Count > 0)
            {
                v_id_gd_thu_nhap_khac = CIPConvert.ToDecimal(v_ds.Tables[0].Rows[0]["ID"].ToString());
                US_GD_HE_SO_CHAT_LUONG v_us_gd_hs_cl = new US_GD_HE_SO_CHAT_LUONG(v_id_gd_thu_nhap_khac);
                v_us_gd_hs_cl.BeginTransaction();
                v_us_gd_hs_cl.Delete();
                v_us_gd_hs_cl.CommitTransaction();
            }
            else
            {
                return;
            }
        }

        private void kiem_tra_va_thuc_hien_nhap_du_lieu(ref decimal v_count, ref int v_int_khong_nhap_duoc, decimal v_selectedRowCount)
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
                    US_GD_THU_NHAP_KHAC v_us_gd_thu_nhap_khac = new US_GD_THU_NHAP_KHAC();

                    var v_data_row = m_grv_quan_ly_thu_nhap_khac.GetDataRow(m_grv_quan_ly_thu_nhap_khac.GetSelectedRows()[i]);

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

                    form_2_us_gd_thu_nhap_khac(v_us_gd_thu_nhap_khac, v_id_nv, v_data_row);

                    try
                    {
                        delete_gd_da_co_trong_thang_cua_nhan_vien(v_us_dc, v_data_row, v_id_nv);
                        v_us_gd_thu_nhap_khac.BeginTransaction();
                        v_us_gd_thu_nhap_khac.Insert();
                        v_us_gd_thu_nhap_khac.CommitTransaction();
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
            this.Load += f391_thu_nhap_khac_xls_Load;
            m_cmd_chon_file.Click += m_cmd_chon_file_Click;
            m_cmd_mo_file_mau.Click += m_cmd_mo_file_mau_Click;
            m_cmd_luu_thu_nhap_khac.Click += m_cmd_luu_thu_nhap_khac_Click;
        }

        private void f391_thu_nhap_khac_xls_Load(object sender, EventArgs e)
        {
            try
            {
                set_intial_form_load();
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
                WinFormControls.openTemplate("ThuNhapKhac.xlsx");
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
                load_data_2_grid(WinFormControls.openFileDialog());
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_luu_thu_nhap_khac_Click(object sender, EventArgs e)
        {
            try
            {
                decimal v_count = 0;
                int v_int_khong_nhap_duoc = 0;
                decimal v_selectedRowCount = m_grv_quan_ly_thu_nhap_khac.SelectedRowsCount;
                if (v_selectedRowCount > 0)
                {
                    kiem_tra_va_thuc_hien_nhap_du_lieu(ref v_count, ref v_int_khong_nhap_duoc, v_selectedRowCount);

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