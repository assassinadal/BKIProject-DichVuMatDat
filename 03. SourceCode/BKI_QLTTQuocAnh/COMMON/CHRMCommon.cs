using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using BKI_DichVuMatDat.DS;
using BKI_DichVuMatDat.DS.CDBNames;
using BKI_DichVuMatDat.US;
using IP.Core.IPCommon;
using System.Windows.Forms;
using System.Drawing;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid;

namespace BKI_DichVuMatDat
{
    class CHRMCommon
    {
        public static int TinhTuoi(DateTime ip_dat_ngay_sinh)
        {
            int ageInYrs = DateTime.Now.Year - ip_dat_ngay_sinh.Year;
            if(DateTime.Now.Month < ip_dat_ngay_sinh.Month || (DateTime.Now.Month == ip_dat_ngay_sinh.Month && DateTime.Now.Day < ip_dat_ngay_sinh.Day))
                ageInYrs--;

            return ageInYrs;
        }
        public static void SelectRowInGrid(GridView pview, string pColumnName, decimal pValue)
        {

            int rowhandle = GetRowHandleByColumnValue(pview, pColumnName, pValue);

            if(rowhandle != GridControl.InvalidRowHandle)
            {
                pview.FocusedRowHandle = rowhandle;
                return;
            }

        }
        private static int GetRowHandleByColumnValue(GridView view, string ColumnFieldName, object value)
        {
            int result = GridControl.InvalidRowHandle;

            for(int i = 0; i < view.RowCount; i++)
            {
                if(view.GetRowCellValue(i, ColumnFieldName).Equals(value))

                    return i;
            }
            return result;
        }

        public static void ExportExcel(GridView ip_grv)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "xls files (*.xls)|*.xls|All files (*.*)|*.*";
            saveFileDialog1.RestoreDirectory = true;
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ip_grv.ExportToXls(saveFileDialog1.FileName);
                DevExpress.XtraEditors.XtraMessageBox.Show("Trích xuất dữ liệu thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public static void ExportExcelWithFileName(GridView ip_grv, string ip_str_file_name)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "xls files (*.xls)|*.xls|All files (*.*)|*.*";
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.FileName = ip_str_file_name;
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ip_grv.ExportToXls(saveFileDialog1.FileName);
                DevExpress.XtraEditors.XtraMessageBox.Show("Trích xuất dữ liệu thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public static void ExportExcel(BandedGridView ip_grv)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "xls files (*.xls)|*.xls|All files (*.*)|*.*";
            saveFileDialog1.RestoreDirectory = true;
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ip_grv.ExportToXls(saveFileDialog1.FileName);
                DevExpress.XtraEditors.XtraMessageBox.Show("Trích xuất dữ liệu thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public static void ExportExcelWithFileName(BandedGridView ip_grv, string ip_str_file_name)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "xls files (*.xls)|*.xls|All files (*.*)|*.*";
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.FileName = ip_str_file_name;
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ip_grv.ExportToXls(saveFileDialog1.FileName);
                DevExpress.XtraEditors.XtraMessageBox.Show("Trích xuất dữ liệu thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public static string gen_version()
        {
            return "_version" + DateTime.Now.Day + "." + DateTime.Now.Month + "." + DateTime.Now.Year + "." + DateTime.Now.Hour + "h." + DateTime.Now.Minute + "p";
        }
        /// <summary>
        /// Trả về danh sách các nhân viên được quyền chọn theo user người sử dụng
        /// </summary>
        /// <param name="ip_id_user"></param>
        /// 
        public static void make_stt_indicator(DevExpress.XtraGrid.Views.Grid.GridView ip_grv)
        {
            ip_grv.IndicatorWidth = 50;
            ip_grv.CustomDrawRowIndicator += ip_grv_CustomDrawRowIndicator;
        }
        public static bool validate_control_empty(params Control[] controls)
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
        public static void make_stt(DevExpress.XtraGrid.Views.Grid.GridView ip_grv)
        {
            var col = ip_grv.Columns.Add();
            col.FieldName = "STT";
            col.Caption = "STT";
            col.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            ip_grv.CustomUnboundColumnData += ip_grv_CustomUnboundColumnData;
        }


        public static DateTime get_first_day_of_month(DateTime ip_dat_current_date)
        {
            DateTime result = ip_dat_current_date;
            result = result.AddDays((-result.Day) + 1);
            return result;
        }

        public static DateTime get_first_day_of_month(int ip_int_month)
        {
            DateTime result = new DateTime(DateTime.Now.Year, ip_int_month, 1);
            result = result.AddDays((-result.Day) + 1);
            return result;
        }

        public static DateTime get_last_day_of_month(DateTime ip_dat_current_date)
        {
            DateTime result = ip_dat_current_date;
            result = result.AddMonths(1);
            result = result.AddDays(-(result.Day));
            return result;
        }

        public static DateTime get_last_day_of_month(int ip_int_month)
        {
            DateTime result = new DateTime(DateTime.Now.Year, ip_int_month, 1);
            result = result.AddMonths(1);
            result = result.AddDays(-(result.Day));
            return result;
        }

        public static string gen_ma_nhan_vien()
        {
            string v_str_op_ma_nhan_vien = "";
            US_V_GD_MA_TRA_CUU_NHAN_VIEN v_us = new US_V_GD_MA_TRA_CUU_NHAN_VIEN();
            v_us.gen_ma_nhan_vien(ref v_str_op_ma_nhan_vien);
            int v_int_ma_nhan_vien_tiep_theo = int.Parse(v_str_op_ma_nhan_vien) + 1;
            return v_int_ma_nhan_vien_tiep_theo.ToString();
        }

        static void ip_grv_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if(e.IsGetData)
                e.Value = e.ListSourceRowIndex + 1;
        }

        public static void format_text_2_money(TextBox ip_m_txt)
        {
            decimal v_so_tien = 0;
            v_so_tien = CIPConvert.ToDecimal(ip_m_txt.Text.Trim());
            ip_m_txt.Text = string.Format("{0:#,##0}", v_so_tien);
        }

        public static bool thang_da_chot_bang_luong(DateTime ip_dat)
        {
            DS_GD_CHOT_BANG_LUONG v_ds = new DS_GD_CHOT_BANG_LUONG();
            US_GD_CHOT_BANG_LUONG v_us = new US_GD_CHOT_BANG_LUONG();
            v_us.FillDataset(v_ds);

            string v_str_filter = "THANG = " + ip_dat.Month + " AND NAM = " + ip_dat.Year;

            DataRow[] v_dr = v_ds.GD_CHOT_BANG_LUONG.Select(v_str_filter);

            if(v_dr.Count() == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool thang_da_chot_bang_luong(decimal ip_dc_thang, decimal ip_dc_nam)
        {
            DS_GD_CHOT_BANG_LUONG v_ds = new DS_GD_CHOT_BANG_LUONG();
            US_GD_CHOT_BANG_LUONG v_us = new US_GD_CHOT_BANG_LUONG();
            v_us.FillDataset(v_ds);

            string v_str_filter = "THANG = " + ip_dc_thang + " AND NAM = " + ip_dc_nam;

            DataRow[] v_dr = v_ds.GD_CHOT_BANG_LUONG.Select(v_str_filter);

            if(v_dr.Count() == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        #region Tinh bang luong
        //public static DataRow get_luong_1_nhan_vien(decimal ip_dc_id_nhan_vien, int ip_int_thang, int ip_int_nam)
        //{
        //    US_RPT_LUONG v_us = new US_RPT_LUONG();
        //    DataSet v_ds = new DataSet();
        //    v_ds.Tables.Add(new DataTable());
        //    v_us.FillBangLuong(v_ds, ip_dc_id_nhan_vien, ip_int_thang, ip_int_nam);
        //    DataRow v_dr = v_ds.Tables[0].Rows[0];
        //    return v_dr;
        //}
        //public static DataRow get_luong_1_nhan_vien_v2(decimal ip_dc_id_nhan_vien, int ip_int_thang, int ip_int_nam)
        //{
        //    US_RPT_LUONG_V2 v_us = new US_RPT_LUONG_V2();
        //    DataSet v_ds = new DataSet();
        //    v_ds.Tables.Add(new DataTable());
        //    v_us.FillBangLuongV2(v_ds, ip_dc_id_nhan_vien, ip_int_thang, ip_int_nam);
        //    DataRow v_dr = v_ds.Tables[0].Rows[0];
        //    return v_dr;
        //}
        //public static DataRow get_thong_tin_tong_hop_1_nhan_vien(decimal ip_dc_id_nhan_vien, int ip_int_thang, int ip_int_nam)
        //{
        //    US_RPT_THONG_TIN_TONG_HOP v_us = new US_RPT_THONG_TIN_TONG_HOP();
        //    DataSet v_ds = new DataSet();
        //    v_ds.Tables.Add(new DataTable());
        //    v_us.FillThongTinTongHopNhanVien(v_ds, ip_dc_id_nhan_vien, ip_int_thang, ip_int_nam);
        //    DataRow v_dr = v_ds.Tables[0].Rows[0];
        //    return v_dr;
        //}
        //public static DataRow get_thong_tin_tong_hop_1_nhan_vien_v2(decimal ip_dc_id_nhan_vien, int ip_int_thang, int ip_int_nam)
        //{
        //    US_RPT_THONG_TIN_TONG_HOP_V2 v_us = new US_RPT_THONG_TIN_TONG_HOP_V2();
        //    DataSet v_ds = new DataSet();
        //    v_ds.Tables.Add(new DataTable());
        //    v_us.FillThongTinTongHopNhanVienV2(v_ds, ip_dc_id_nhan_vien, ip_int_thang, ip_int_nam);
        //    DataRow v_dr = v_ds.Tables[0].Rows[0];
        //    return v_dr;
        //}
        //public static DataRow get_dr(DataRow ip_dr_luong_nv, DataRow ip_dr_luong, decimal ip_id_nv, int ip_index, int ip_thang, int ip_nam)
        //{
        //    ip_dr_luong_nv[RPT_LUONG.ID] = ip_index;
        //    ip_dr_luong_nv[RPT_LUONG.ID_NHAN_VIEN] = ip_id_nv;
        //    ip_dr_luong_nv[RPT_LUONG.THANG] = ip_thang;
        //    ip_dr_luong_nv[RPT_LUONG.NAM] = ip_nam;
        //    ip_dr_luong_nv[RPT_LUONG.MA_NV] = ip_dr_luong[RPT_LUONG.MA_NV];
        //    ip_dr_luong_nv[RPT_LUONG.LUONG_NS] = ip_dr_luong[RPT_LUONG.LUONG_NS];
        //    ip_dr_luong_nv[RPT_LUONG.LUONG_CD] = ip_dr_luong[RPT_LUONG.LUONG_CD];
        //    ip_dr_luong_nv[RPT_LUONG.PHU_CAP_TN] = ip_dr_luong[RPT_LUONG.PHU_CAP_TN];
        //    ip_dr_luong_nv[RPT_LUONG.AN_CA] = ip_dr_luong[RPT_LUONG.AN_CA];
        //    ip_dr_luong_nv[RPT_LUONG.LAM_THEM] = ip_dr_luong[RPT_LUONG.LAM_THEM];
        //    ip_dr_luong_nv[RPT_LUONG.LAM_THEM_LE_TET] = ip_dr_luong[RPT_LUONG.LAM_THEM_LE_TET];
        //    ip_dr_luong_nv[RPT_LUONG.THU_NHAP] = ip_dr_luong[RPT_LUONG.THU_NHAP];
        //    ip_dr_luong_nv[RPT_LUONG.BHXH] = ip_dr_luong[RPT_LUONG.BHXH];
        //    ip_dr_luong_nv[RPT_LUONG.BHYT] = ip_dr_luong[RPT_LUONG.BHYT];
        //    ip_dr_luong_nv[RPT_LUONG.BHTN] = ip_dr_luong[RPT_LUONG.BHTN];
        //    ip_dr_luong_nv[RPT_LUONG.DOAN_PHI_CD] = ip_dr_luong[RPT_LUONG.DOAN_PHI_CD];
        //    ip_dr_luong_nv[RPT_LUONG.THUE] = ip_dr_luong[RPT_LUONG.THUE];
        //    ip_dr_luong_nv[RPT_LUONG.PHAI_NOP] = ip_dr_luong[RPT_LUONG.PHAI_NOP];
        //    ip_dr_luong_nv[RPT_LUONG.THUC_LINH] = ip_dr_luong[RPT_LUONG.THUC_LINH];
        //    ip_dr_luong_nv[RPT_LUONG.TRUY_LINH] = ip_dr_luong[RPT_LUONG.TRUY_LINH];
        //    ip_dr_luong_nv[RPT_LUONG.TRUY_THU] = ip_dr_luong[RPT_LUONG.TRUY_THU];
        //    ip_dr_luong_nv[RPT_LUONG.THUC_LINH_CUOI_CUNG] = ip_dr_luong[RPT_LUONG.THUC_LINH_CUOI_CUNG];
        //    ip_dr_luong_nv[RPT_LUONG.SO_NGAY_LAM_THEM] = ip_dr_luong[RPT_LUONG.SO_NGAY_LAM_THEM];
        //    return ip_dr_luong_nv;
        //}
        //public static void get_dr_v2(ref DataRow ip_dr_luong_nv, DataRow ip_dr_luong, decimal ip_id_nv, int ip_index, int ip_thang, int ip_nam)
        //{
        //    ip_dr_luong_nv[RPT_LUONG_V2.ID] = ip_index;
        //    ip_dr_luong_nv[RPT_LUONG_V2.ID_NHAN_VIEN] = ip_id_nv;
        //    ip_dr_luong_nv[RPT_LUONG_V2.THANG] = ip_thang;
        //    ip_dr_luong_nv[RPT_LUONG_V2.NAM] = ip_nam;
        //    ip_dr_luong_nv[RPT_LUONG_V2.MA_NV] = ip_dr_luong[RPT_LUONG_V2.MA_NV];

        //    ip_dr_luong_nv[RPT_LUONG_V2.LUONG_NS] = ip_dr_luong[RPT_LUONG_V2.LUONG_NS];
        //    ip_dr_luong_nv[RPT_LUONG_V2.LUONG_CD] = ip_dr_luong[RPT_LUONG_V2.LUONG_CD];
        //    ip_dr_luong_nv[RPT_LUONG_V2.PHU_CAP_TN] = ip_dr_luong[RPT_LUONG_V2.PHU_CAP_TN];
        //    ip_dr_luong_nv[RPT_LUONG_V2.AN_CA] = ip_dr_luong[RPT_LUONG_V2.AN_CA];
        //    ip_dr_luong_nv[RPT_LUONG_V2.LAM_THEM] = ip_dr_luong[RPT_LUONG_V2.LAM_THEM];
        //    ip_dr_luong_nv[RPT_LUONG_V2.LAM_THEM_200] = ip_dr_luong[RPT_LUONG_V2.LAM_THEM_200];
        //    ip_dr_luong_nv[RPT_LUONG_V2.LAM_THEM_300] = ip_dr_luong[RPT_LUONG_V2.LAM_THEM_300];
        //    ip_dr_luong_nv[RPT_LUONG_V2.THU_NHAP_KHAC_TRONG_LUONG] = ip_dr_luong[RPT_LUONG_V2.THU_NHAP_KHAC_TRONG_LUONG];
        //    ip_dr_luong_nv[RPT_LUONG_V2.TONG_THU_NHAP_TRONG_LUONG] = ip_dr_luong[RPT_LUONG_V2.TONG_THU_NHAP_TRONG_LUONG];

        //    ip_dr_luong_nv[RPT_LUONG_V2.THUONG] = ip_dr_luong[RPT_LUONG_V2.THUONG];
        //    ip_dr_luong_nv[RPT_LUONG_V2.THUONG_ATHK] = ip_dr_luong[RPT_LUONG_V2.THUONG_ATHK];
        //    ip_dr_luong_nv[RPT_LUONG_V2.BO_SUNG_LUONG] = ip_dr_luong[RPT_LUONG_V2.BO_SUNG_LUONG];
        //    ip_dr_luong_nv[RPT_LUONG_V2.THUONG_LE_TET] = ip_dr_luong[RPT_LUONG_V2.THUONG_LE_TET];
        //    ip_dr_luong_nv[RPT_LUONG_V2.THU_NHAP_KHAC_NGOAI_LUONG] = ip_dr_luong[RPT_LUONG_V2.THU_NHAP_KHAC_NGOAI_LUONG];
        //    ip_dr_luong_nv[RPT_LUONG_V2.TONG_THU_NHAP_NGOAI_LUONG] = ip_dr_luong[RPT_LUONG_V2.TONG_THU_NHAP_NGOAI_LUONG];
        //    ip_dr_luong_nv[RPT_LUONG_V2.TONG_THU_NHAP] = ip_dr_luong[RPT_LUONG_V2.TONG_THU_NHAP];

        //    ip_dr_luong_nv[RPT_LUONG_V2.BHXH] = ip_dr_luong[RPT_LUONG_V2.BHXH];
        //    ip_dr_luong_nv[RPT_LUONG_V2.BHYT] = ip_dr_luong[RPT_LUONG_V2.BHYT];
        //    ip_dr_luong_nv[RPT_LUONG_V2.BHTN] = ip_dr_luong[RPT_LUONG_V2.BHTN];
        //    ip_dr_luong_nv[RPT_LUONG_V2.GIAM_TRU_LAM_THEM_150] = ip_dr_luong[RPT_LUONG_V2.GIAM_TRU_LAM_THEM_150];
        //    ip_dr_luong_nv[RPT_LUONG_V2.GIAM_TRU_LAM_THEM_200] = ip_dr_luong[RPT_LUONG_V2.GIAM_TRU_LAM_THEM_200];
        //    ip_dr_luong_nv[RPT_LUONG_V2.GIAM_TRU_LAM_THEM_300] = ip_dr_luong[RPT_LUONG_V2.GIAM_TRU_LAM_THEM_300];
        //    ip_dr_luong_nv[RPT_LUONG_V2.GIAM_TRU_GIA_CANH] = ip_dr_luong[RPT_LUONG_V2.GIAM_TRU_GIA_CANH];
        //    ip_dr_luong_nv[RPT_LUONG_V2.GIAM_TRU_PHU_THUOC] = ip_dr_luong[RPT_LUONG_V2.GIAM_TRU_PHU_THUOC];
        //    ip_dr_luong_nv[RPT_LUONG_V2.GIAM_TRU_KHAC] = ip_dr_luong[RPT_LUONG_V2.GIAM_TRU_KHAC];
        //    ip_dr_luong_nv[RPT_LUONG_V2.TONG_GIAM_TRU] = ip_dr_luong[RPT_LUONG_V2.TONG_GIAM_TRU];

        //    ip_dr_luong_nv[RPT_LUONG_V2.THU_NHAP_CHIU_THUE] = ip_dr_luong[RPT_LUONG_V2.THU_NHAP_CHIU_THUE];

        //    ip_dr_luong_nv[RPT_LUONG_V2.DOAN_PHI_CD] = ip_dr_luong[RPT_LUONG_V2.DOAN_PHI_CD];
        //    ip_dr_luong_nv[RPT_LUONG_V2.THUE] = ip_dr_luong[RPT_LUONG_V2.THUE];
        //    ip_dr_luong_nv[RPT_LUONG_V2.PHAI_NOP_KHAC] = ip_dr_luong[RPT_LUONG_V2.PHAI_NOP_KHAC];
        //    ip_dr_luong_nv[RPT_LUONG_V2.TONG_PHAI_NOP] = ip_dr_luong[RPT_LUONG_V2.TONG_PHAI_NOP];

        //    ip_dr_luong_nv[RPT_LUONG_V2.THUC_LINH] = ip_dr_luong[RPT_LUONG_V2.THUC_LINH];
        //}

        //public static void DataRow2US(DataRow v_dr_luong_1_nv, US_RPT_LUONG v_us)
        //{
        //    v_us.strMA_NV = v_dr_luong_1_nv[RPT_LUONG.MA_NV].ToString();
        //    v_us.dcAN_CA = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.AN_CA].ToString());
        //    v_us.dcBHTN = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.BHTN].ToString());
        //    v_us.dcBHXH = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.BHXH].ToString());
        //    v_us.dcBHYT = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.BHYT].ToString());
        //    v_us.dcDOAN_PHI_CD = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.DOAN_PHI_CD].ToString());
        //    v_us.dcID_NHAN_VIEN = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.ID_NHAN_VIEN].ToString());
        //    v_us.dcLAM_THEM = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.LAM_THEM].ToString());
        //    v_us.dcLAM_THEM_LE_TET = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.LAM_THEM_LE_TET].ToString());
        //    v_us.dcLUONG_CD = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.LUONG_CD].ToString());
        //    v_us.dcLUONG_NS = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.LUONG_NS].ToString());
        //    v_us.dcNAM = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.NAM].ToString());
        //    v_us.dcPHAI_NOP = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.PHAI_NOP].ToString());
        //    v_us.dcPHU_CAP_TN = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.PHU_CAP_TN].ToString());
        //    v_us.dcTHANG = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.THANG].ToString());
        //    v_us.dcTHU_NHAP = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.THU_NHAP].ToString());
        //    v_us.dcTHUC_LINH = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.THUC_LINH].ToString());
        //    v_us.dcTHUC_LINH_CUOI_CUNG = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.THUC_LINH_CUOI_CUNG].ToString());
        //    v_us.dcTHUE = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.THUE].ToString());
        //    v_us.dcTRUY_LINH = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.TRUY_LINH].ToString());
        //    v_us.dcTRUY_THU = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.TRUY_THU].ToString());
        //    v_us.dcSO_NGAY_LAM_THEM = Convert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.SO_NGAY_LAM_THEM]);
        //}
        //public static void DataRow2US_V2(DataRow v_dr_luong_1_nv, US_RPT_LUONG_V2 v_us)
        //{
        //    v_us.dcID_NHAN_VIEN = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG_V2.ID_NHAN_VIEN].ToString());
        //    v_us.strMA_NV = v_dr_luong_1_nv[RPT_LUONG_V2.MA_NV].ToString();
        //    v_us.dcTHANG = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG_V2.THANG].ToString());
        //    v_us.dcNAM = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG_V2.NAM].ToString());

        //    v_us.dcLUONG_CD = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG_V2.LUONG_CD].ToString());
        //    v_us.dcLUONG_NS = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG_V2.LUONG_NS].ToString());
        //    v_us.dcPHU_CAP_TN = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG_V2.PHU_CAP_TN].ToString());
        //    v_us.dcAN_CA = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG_V2.AN_CA].ToString());
        //    v_us.dcLAM_THEM = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG_V2.LAM_THEM].ToString());
        //    v_us.dcLAM_THEM_200 = Convert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG_V2.LAM_THEM_200]);
        //    v_us.dcLAM_THEM_300 = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG_V2.LAM_THEM_300].ToString());
        //    v_us.dcTHU_NHAP_KHAC_TRONG_LUONG = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG_V2.THU_NHAP_KHAC_TRONG_LUONG].ToString());
        //    v_us.dcTONG_THU_NHAP_TRONG_LUONG = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG_V2.TONG_THU_NHAP_TRONG_LUONG].ToString());

        //    v_us.dcTHUONG = Convert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG_V2.THUONG]);
        //    v_us.dcTHUONG_ATHK = Convert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG_V2.THUONG_ATHK]);
        //    v_us.dcTHUONG_LE_TET = Convert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG_V2.THUONG_LE_TET]);
        //    v_us.dcBO_SUNG_LUONG = Convert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG_V2.BO_SUNG_LUONG]);
        //    v_us.dcTHU_NHAP_KHAC_NGOAI_LUONG = Convert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG_V2.THU_NHAP_KHAC_NGOAI_LUONG]);
        //    v_us.dcTONG_THU_NHAP_NGOAI_LUONG = Convert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG_V2.TONG_THU_NHAP_NGOAI_LUONG]);
        //    v_us.dcTONG_THU_NHAP = Convert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG_V2.TONG_THU_NHAP]);

        //    v_us.dcBHTN = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG_V2.BHTN].ToString());
        //    v_us.dcBHXH = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG_V2.BHXH].ToString());
        //    v_us.dcBHYT = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG_V2.BHYT].ToString());
        //    v_us.dcGIAM_TRU_GIA_CANH = Convert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG_V2.GIAM_TRU_GIA_CANH]);
        //    v_us.dcGIAM_TRU_PHU_THUOC = Convert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG_V2.GIAM_TRU_PHU_THUOC]);
        //    v_us.dcGIAM_TRU_LAM_THEM_150 = Convert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG_V2.GIAM_TRU_LAM_THEM_150]);
        //    v_us.dcGIAM_TRU_LAM_THEM_200 = Convert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG_V2.GIAM_TRU_LAM_THEM_200]);
        //    v_us.dcGIAM_TRU_LAM_THEM_300 = Convert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG_V2.GIAM_TRU_LAM_THEM_300]);
        //    v_us.dcGIAM_TRU_KHAC = Convert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG_V2.GIAM_TRU_KHAC]);
        //    v_us.dcTONG_GIAM_TRU = Convert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG_V2.TONG_GIAM_TRU]);

        //    v_us.dcTHU_NHAP_CHIU_THUE = Convert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG_V2.THU_NHAP_CHIU_THUE]);

        //    v_us.dcDOAN_PHI_CD = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG_V2.DOAN_PHI_CD].ToString());
        //    v_us.dcTHUE = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG_V2.THUE].ToString());
        //    v_us.dcPHAI_NOP_KHAC = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG_V2.PHAI_NOP_KHAC].ToString());
        //    v_us.dcTONG_PHAI_NOP = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG_V2.TONG_PHAI_NOP].ToString());

        //    v_us.dcTHUC_LINH = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG_V2.THUC_LINH].ToString());
        //}


        //public static void DataRow2USThongTinTongHop(DataRow v_dr_luong_1_nv, US_RPT_THONG_TIN_TONG_HOP v_us)
        //{
        //    //v_us.dcID = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP.ID].ToString());
        //    v_us.dcTHANG = Convert.ToDecimal(v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP.THANG]);
        //    v_us.dcNAM = Convert.ToDecimal(v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP.NAM]);
        //    v_us.dcID_NHAN_VIEN = (decimal)v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP.ID_NHAN_VIEN];
        //    v_us.strMA_NV = v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP.MA_NV].ToString();
        //    v_us.strHO_DEM = v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP.HO_DEM].ToString();
        //    v_us.strTEN = v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP.TEN].ToString();
        //    v_us.strHO_VA_TEN = v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP.HO_VA_TEN].ToString();
        //    v_us.strTEN_CHUC_VU = v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP.TEN_CHUC_VU].ToString();
        //    v_us.strTEN_HOP_DONG = v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP.TEN_HOP_DONG].ToString();
        //    v_us.dcLUONG_CHE_DO_THEO_CHUC_VU = (decimal)v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP.LUONG_CHE_DO_THEO_CHUC_VU];
        //    v_us.dcHS_LUONG_NANG_SUAT_DUOC_HUONG = (decimal)v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP.HS_LUONG_NANG_SUAT_DUOC_HUONG];
        //    v_us.strTAI_KHOAN = v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP.TAI_KHOAN].ToString();
        //    v_us.dcCHAM_CONG_X = Convert.ToDecimal(v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP.CHAM_CONG_X]);
        //    v_us.dcCHAM_CONG_OM_CO = Convert.ToDecimal(v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP.CHAM_CONG_OM_CO]);
        //    v_us.dcCHAM_CONG_TS = Convert.ToDecimal(v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP.CHAM_CONG_TS]);
        //    v_us.dcCHAM_CONG_TNLD = Convert.ToDecimal(v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP.CHAM_CONG_TNLD]);
        //    v_us.dcCHAM_CONG_PHEP_DIDUONG = Convert.ToDecimal(v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP.CHAM_CONG_PHEP_DIDUONG]);
        //    v_us.dcCHAM_CONG_RO_KO_DC = Convert.ToDecimal(v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP.CHAM_CONG_RO_KO_DC]);
        //    v_us.dcCHAM_CONG_KHAC = Convert.ToDecimal(v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP.CHAM_CONG_KHAC]);
        //    v_us.dcHE_SO_K = Convert.ToDecimal(v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP.HE_SO_K]);
        //    v_us.strDON_VI = v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP.DON_VI].ToString();
        //}

        //public static void insertLuongNV2RPT(DataRow v_dr_luong_1_nv)
        //{
        //    US_RPT_LUONG v_us = new US_RPT_LUONG();
        //    DataRow2US(v_dr_luong_1_nv, v_us);
        //    v_us.Insert();
        //}
        //public static void insertLuongNV2RPT_V2(DataRow v_dr_luong_1_nv)
        //{
        //    US_RPT_LUONG_V2 v_us = new US_RPT_LUONG_V2();
        //    DataRow2US_V2(v_dr_luong_1_nv, v_us);
        //    v_us.Insert();
        //}
        //public static void insertLuongNV2RPT_ThaoTacLai(DataRow v_dr_luong_1_nv)
        //{
        //    US_RPT_LUONG v_us_old = new US_RPT_LUONG();
        //    US_RPT_LUONG v_us_new = new US_RPT_LUONG();
        //    try
        //    {
        //        //Day du lieu bang luong moi vao us_new
        //        DataRow2US(v_dr_luong_1_nv, v_us_new);

        //        //Lay du lieu nhan vien & thang & nam
        //        decimal v_dc_id_nhan_vien = (decimal)v_dr_luong_1_nv[RPT_LUONG.ID_NHAN_VIEN];
        //        decimal v_dc_thang = Convert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.THANG]);
        //        decimal v_dc_nam = Convert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.NAM]);

        //        v_us_old.BeginTransaction();
        //        v_us_old.XoaBanGhiLuong(v_dc_id_nhan_vien, v_dc_thang, v_dc_nam);
        //        v_us_new.UseTransOfUSObject(v_us_old);
        //        v_us_new.Insert();
        //        v_us_old.CommitTransaction();
        //    }
        //    catch(Exception)
        //    {
        //        if(v_us_old.is_having_transaction())
        //        {
        //            v_us_old.Rollback();
        //        }
        //        throw;
        //    }

        //}
        //public static void insertThongTinTongHopNV2RPT(DataRow v_dr_luong_1_nv)
        //{
        //    US_RPT_THONG_TIN_TONG_HOP v_us = new US_RPT_THONG_TIN_TONG_HOP();
        //    DataRow2USThongTinTongHop(v_dr_luong_1_nv, v_us);
        //    v_us.Insert();
        //}

        //public static void DataRow2USThongTinTongHopV2(DataRow v_dr_luong_1_nv, US_RPT_THONG_TIN_TONG_HOP_V2 v_us)
        //{
        //    //v_us.dcID = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP_V2_V2.ID].ToString());
        //    v_us.dcTHANG = Convert.ToDecimal(v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP_V2.THANG]);
        //    v_us.dcNAM = Convert.ToDecimal(v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP_V2.NAM]);
        //    v_us.dcID_NHAN_VIEN = (decimal)v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP_V2.ID_NHAN_VIEN];
        //    v_us.strMA_NV = v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP_V2.MA_NV].ToString();
        //    v_us.strHO_DEM = v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP_V2.HO_DEM].ToString();
        //    v_us.strTEN = v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP_V2.TEN].ToString();
        //    v_us.strHO_VA_TEN = v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP_V2.HO_VA_TEN].ToString();
        //    v_us.strTEN_CHUC_VU = v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP_V2.TEN_CHUC_VU].ToString();
        //    v_us.strTEN_HOP_DONG = v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP_V2.TEN_HOP_DONG].ToString();
        //    v_us.dcLUONG_CHE_DO_THEO_CHUC_VU = (decimal)v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP_V2.LUONG_CHE_DO_THEO_CHUC_VU];
        //    v_us.dcHS_LUONG_NANG_SUAT_DUOC_HUONG = (decimal)v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP_V2.HS_LUONG_NANG_SUAT_DUOC_HUONG];
        //    v_us.strTAI_KHOAN = v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP_V2.TAI_KHOAN].ToString();
        //    v_us.dcCHAM_CONG_X = Convert.ToDecimal(v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP_V2.CHAM_CONG_X]);
        //    v_us.dcCHAM_CONG_OM_CO = Convert.ToDecimal(v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP_V2.CHAM_CONG_OM_CO]);
        //    v_us.dcCHAM_CONG_TS = Convert.ToDecimal(v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP_V2.CHAM_CONG_TS]);
        //    v_us.dcCHAM_CONG_TNLD = Convert.ToDecimal(v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP_V2.CHAM_CONG_TNLD]);
        //    v_us.dcCHAM_CONG_PHEP_DIDUONG = Convert.ToDecimal(v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP_V2.CHAM_CONG_PHEP_DIDUONG]);
        //    v_us.dcCHAM_CONG_RO_KO_DC = Convert.ToDecimal(v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP_V2.CHAM_CONG_RO_KO_DC]);
        //    v_us.dcCHAM_CONG_KHAC = Convert.ToDecimal(v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP_V2.CHAM_CONG_KHAC]);
        //    v_us.dcHE_SO_K = Convert.ToDecimal(v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP_V2.HE_SO_K]);
        //    v_us.strDON_VI = v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP_V2.DON_VI].ToString();
        //    v_us.dcSO_NGAY_LAM_THEM = Convert.ToDecimal(v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP_V2.SO_NGAY_LAM_THEM]);
        //    v_us.strLOAI_LAO_DONG = v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP_V2.LOAI_LAO_DONG].ToString();
        //    v_us.dcNGAY_CONG_QUY_DINH = Convert.ToDecimal(v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP_V2.NGAY_CONG_QUY_DINH]);
        //}
        //public static void insertThongTinTongHopNV2RPTV2(DataRow v_dr_luong_1_nv)
        //{
        //    US_RPT_THONG_TIN_TONG_HOP_V2 v_us = new US_RPT_THONG_TIN_TONG_HOP_V2();
        //    DataRow2USThongTinTongHopV2(v_dr_luong_1_nv, v_us);
        //    v_us.Insert();
        //}
        //public static void insertThongTinTongHopNV2RPTV2(DataRow v_dr_luong_1_nv, US_RPT_LUONG_V2 ip_us_trans)
        //{
        //    US_RPT_THONG_TIN_TONG_HOP_V2 v_us = new US_RPT_THONG_TIN_TONG_HOP_V2();
        //    DataRow2USThongTinTongHopV2(v_dr_luong_1_nv, v_us);
        //    v_us.UseTransOfUSObject(ip_us_trans);
        //    v_us.Insert();
        //}
        //public static void update_luong_1NV_2_rpt(int ip_id_rpt_luong, DataRow v_dr_luong_1_nv)
        //{
        //    US_RPT_LUONG v_us = new US_RPT_LUONG(ip_id_rpt_luong);
        //    DataRow2US(v_dr_luong_1_nv, v_us);
        //    v_us.Update();
        //}
        #endregion

        #region Private Methods
        private static void ip_grv_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if(e.Info.IsRowIndicator && e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }
        #endregion

    }
}

