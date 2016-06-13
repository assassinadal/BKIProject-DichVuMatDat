using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BKI_DichVuMatDat.DS;
using BKI_DichVuMatDat.US;
using IP.Core.IPCommon;
using BKI_DichVuMatDat.NghiepVu;
using DevExpress.XtraSplashScreen;
using BKI_DichVuMatDat.BaoCao;
using DevExpress.XtraEditors;
using BKI_DichVuMatDat.COMMON;
using System.Data.OleDb;
using System.Configuration;
using DevExpress.XtraPrinting;

namespace BKI_DichVuMatDat
{
    public partial class F152_DANH_SACH_NHAN_VIEN_EXCEL : Form
    {
        public F152_DANH_SACH_NHAN_VIEN_EXCEL()
        {
            InitializeComponent();
            format_controll();
        }

        #region Data Structures
        class ExcelHopDong
        {
            public const string STT = "STT";
            public const string MA_NV = "MA_NV";
            public const string HO_DEM = "HO_DEM";
            public const string TEN = "TEN";
            public const string GIOI_TINH = "GIOI_TINH";
            public const string EMAIL = "EMAIL";
            public const string SDT = "SDT";
            public const string SO_TAI_KHOAN = "SO_TAI_KHOAN";
            public const string NGAN_HANG = "NGAN_HANG";
            public const string NGAY_CAP_THE = "NGAY_CAP_THE";
            public const string NGAY_HET_HAN_THE = "NGAY_HET_HAN_THE";
            public const string NGAY_SINH = "NGAY_SINH";
            public const string HON_NHAN = "HON_NHAN";
            public const string SO_CMT = "SO_CMT";
            public const string NGAY_CAP = "NGAY_CAP";
            public const string NOI_CAP = "NOI_CAP";
            public const string QUOC_TICH = "QUOC_TICH";
            public const string DAN_TOC = "DAN_TOC";
            public const string TON_GIAO = "TON_GIAO";
            public const string NOI_SINH = "NOI_SINH";
            public const string QUE_QUAN = "QUE_QUAN";
            public const string DIA_CHI_THUONG_TRU = "DIA_CHI_THUONG_TRU";
            public const string DIA_CHI_TAM_TRU = "DIA_CHI_TAM_TRU";
            public const string DIA_CHI_LIEN_LAC = "DIA_CHI_LIEN_LAC";
            public const string MA_SO_THUE_CA_NHAN = "MA_SO_THUE_CA_NHAN";
            public const string CHUYEN_MON = "CHUYEN_MON";
            public const string TRINH_DO_VAN_HOA = "TRINH_DO_VAN_HOA";
            public const string NAM_TOT_NGHIEP = "NAM_TOT_NGHIEP";
            public const string TOT_NGHIEP_TAI = "TOT_NGHIEP_TAI";
            public const string NGAY_VAO_HANG_KHONG = "NGAY_VAO_HANG_KHONG";
            public const string NGAY_TIEP_NHAN_VAO_TCT = "NGAY_TIEP_NHAN_VAO_TCT";
            public const string NGAY_CHINH_THUC_TIEP_NHAN = "NGAY_CHINH_THUC_TIEP_NHAN";
            public const string NGUOI_BAO_LANH = "NGUOI_BAO_LANH";
        }

        enum thu_tu_cot
        {
            STT = 0,
            MA_NV = 1,
            HO_DEM = 2,
            TEN = 3,
            GIOI_TINH = 4,
            EMAIL = 5,
            SDT = 6,
            SO_TAI_KHOAN = 7,
            NGAN_HANG = 8,
            NGAY_CAP_THE = 9,
            NGAY_HET_HAN_THE = 10,
            NGAY_SINH = 11,
            HON_NHAN = 12,
            SO_CMT = 13,
            NGAY_CAP = 14,
            NOI_CAP = 15,
            QUOC_TICH = 16,
            DAN_TOC = 17,
            TON_GIAO = 18,
            NOI_SINH = 19,
            QUE_QUAN = 20,
            DIA_CHI_THUONG_TRU = 21,
            DIA_CHI_TAM_TRU = 22,
            DIA_CHI_LIEN_LAC = 23,
            MA_SO_THUE_CA_NHAN = 24,
            CHUYEN_MON = 26,
            TRINH_DO_VAN_HOA = 25,
            NAM_TOT_NGHIEP = 27,
            TOT_NGHIEP_TAI = 28,
            NGAY_VAO_HANG_KHONG = 29,
            NGAY_TIEP_NHAN_VAO_TCT = 30,
            NGAY_CHINH_THUC_TIEP_NHAN = 31,
            NGUOI_BAO_LANH = 32
        }
        #endregion;

        #region Public interface
        void displayToInsertExcel(string m_txt_path)
        {
            WinFormControls.load_xls_to_gridview_v3(m_txt_path, m_grc, "NHAP_LIEU");
            foreach (DevExpress.XtraGrid.Columns.GridColumn col in ((DevExpress.XtraGrid.Views.Base.ColumnView)m_grc.Views[0]).Columns)
            {
                col.MaxWidth = 100;
                col.MinWidth = 100;
            }
            this.ShowDialog();
        }

        public void DisplayForInsert()
        {
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            Text = "F152 - Thêm mới danh sách nhân viên từ excel";
            this.CenterToScreen();
            this.ShowDialog();
        }

        public void DisplayForUpdate()
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            Text = "F152 - Sửa danh sách nhân viên từ excel";
            m_cmd_xuat_excel.Visible = false;
            m_cmd_tai_file_excel_mau.Visible = false;
            this.CenterToScreen();
            this.ShowDialog();
        }

        #endregion

        #region Members

        string m_txt_path = "";
        DataEntryFormMode m_e_form_mode = DataEntryFormMode.InsertDataState;

        #endregion

        #region Private Methods
        private void format_controll()
        {
            CenterToScreen();
            set_define_event();
        }

        private US_DM_NHAN_VIEN gan_du_lieu_cho_us_dm_nhan_vien(DataRow dataRow)
        {
            US_DM_NHAN_VIEN v_us = new US_DM_NHAN_VIEN();
            if(m_e_form_mode == DataEntryFormMode.UpdateDataState) v_us = new US_DM_NHAN_VIEN(ExecuteFuntion.LayNhanVienID(dataRow["MA_NV"].ToString()));
            
            if (dataRow["NGAY_CAP"] != DBNull.Value || !string.IsNullOrEmpty(dataRow["NGAY_CAP"].ToString()))
                v_us.datNGAY_CAP = WinFormControls.FormatPostingDate(dataRow["NGAY_CAP"].ToString());

            if (dataRow["NGAY_CAP_THE"] != DBNull.Value || !string.IsNullOrEmpty(dataRow["NGAY_CAP_THE"].ToString()))
                v_us.datNGAY_CAP_THE = WinFormControls.FormatPostingDate(dataRow["NGAY_CAP_THE"].ToString());

            if (dataRow["NGAY_CHINH_THUC_TIEP_NHAN"] != DBNull.Value || !string.IsNullOrEmpty(dataRow["NGAY_CHINH_THUC_TIEP_NHAN"].ToString()))
                v_us.datNGAY_CHINH_THUC_TIEP_NHAN = WinFormControls.FormatPostingDate(dataRow["NGAY_CHINH_THUC_TIEP_NHAN"].ToString());

            if (dataRow["NGAY_HET_HAN_THE"] != DBNull.Value || !string.IsNullOrEmpty(dataRow["NGAY_HET_HAN_THE"].ToString()))
                v_us.datNGAY_HET_HAN_THE = WinFormControls.FormatPostingDate(dataRow["NGAY_HET_HAN_THE"].ToString());

            if (dataRow["NGAY_SINH"] != DBNull.Value || !string.IsNullOrEmpty(dataRow["NGAY_SINH"].ToString()))
                v_us.datNGAY_SINH = WinFormControls.FormatPostingDate(dataRow["NGAY_SINH"].ToString());

            if (dataRow["NGAY_TIEP_NHAN_VAO_TCT"] != DBNull.Value || !string.IsNullOrEmpty(dataRow["NGAY_TIEP_NHAN_VAO_TCT"].ToString()))
                v_us.datNGAY_TIEP_NHAN_VAO_TCT = WinFormControls.FormatPostingDate(dataRow["NGAY_TIEP_NHAN_VAO_TCT"].ToString());

            if (dataRow["NGAY_VAO_HANG_KHONG"] != DBNull.Value || !string.IsNullOrEmpty(dataRow["NGAY_VAO_HANG_KHONG"].ToString()))
                v_us.datNGAY_VAO_HANG_KHONG = Convert.ToDateTime(dataRow["NGAY_VAO_HANG_KHONG"]);

            v_us.strCHUYEN_MON = dataRow["CHUYEN_MON"].ToString();
            v_us.strDAN_TOC = dataRow["DAN_TOC"].ToString();
            v_us.strDIA_CHI_LIEN_LAC = dataRow["DIA_CHI_LIEN_LAC"].ToString();
            v_us.strDIA_CHI_TAM_TRU = dataRow["DIA_CHI_TAM_TRU"].ToString();
            v_us.strDIA_CHI_THUONG_TRU = dataRow["DIA_CHI_THUONG_TRU"].ToString();
            v_us.strEMAIL = dataRow["EMAIL"].ToString();
            //v_us.strGIOI_TINH = dataRow["GIOI_TINH"].ToString();
            if (dataRow["GIOI_TINH"].ToString().Trim().ToUpper() == "NAM")
                v_us.strGIOI_TINH = "Y";
            else v_us.strGIOI_TINH = "N";
            v_us.strHO_DEM = dataRow["HO_DEM"].ToString();
            v_us.strHON_NHAN = dataRow["HON_NHAN"].ToString();
            v_us.strMA_NV = dataRow["MA_NV"].ToString();
            v_us.strMA_SO_THUE_CA_NHAN = dataRow["MA_SO_THUE_CA_NHAN"].ToString();
            v_us.strNAM_TOT_NGHIEP = dataRow["NAM_TOT_NGHIEP"].ToString();
            v_us.strNGAN_HANG = dataRow["NGAN_HANG"].ToString();
            v_us.strNOI_CAP = dataRow["NOI_CAP"].ToString();
            v_us.strNOI_SINH = dataRow["NOI_SINH"].ToString();
            v_us.strQUE_QUAN = dataRow["QUE_QUAN"].ToString();
            v_us.strQUOC_TICH = dataRow["QUOC_TICH"].ToString();
            v_us.strSDT = dataRow["SDT"].ToString();
            v_us.strSO_CMT = dataRow["SO_CMT"].ToString();
            v_us.strSO_TAI_KHOAN = dataRow["SO_TAI_KHOAN"].ToString();
            v_us.strTEN = dataRow["TEN"].ToString();
            v_us.strTON_GIAO = dataRow["TON_GIAO"].ToString();
            v_us.strTOT_NGHIEP_TAI = dataRow["TOT_NGHIEP_TAI"].ToString();
            v_us.strTRINH_DO_VAN_HOA = find_id_cm_dm_tu_dien_by_trinh_do_van_hoa(dataRow["TRINH_DO_VAN_HOA"].ToString().Trim());
            v_us.strNGUOI_BAO_LANH = dataRow["NGUOI_BAO_LANH"].ToString();
            
            return v_us;
        }

        private bool check_ma_nhan_vien_is_ok(DataRow dataRow)
        {
            //US_DUNG_CHUNG v_usdc = new US_DUNG_CHUNG();
            //DataSet v_ds_nhan_vien = new DataSet();
            //v_ds_nhan_vien.Tables.Add(new DataTable());
            if (dataRow["MA_NV"] == null || dataRow["MA_NV"].ToString() == "")
            {
                XtraMessageBox.Show("Có ô mã nhân viên bị trống!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            US_DM_NHAN_VIEN v_us = new US_DM_NHAN_VIEN();
            DS_DM_NHAN_VIEN v_ds_nhan_vien = new DS_DM_NHAN_VIEN();
            v_us.FillDataset(v_ds_nhan_vien, " where MA_NV= '" + dataRow["MA_NV"].ToString() + "'");
            //v_usdc.FillDatasetWithQuery(v_ds_nhan_vien, "select * from DM_NHAN_VIEN where MA_NV=" + dataRow["MA_NV"].ToString());
            if (v_ds_nhan_vien.Tables[0].Rows.Count > 0)
            {
                CHRM_BaseMessages.MsgBox_Error("Mã nhân viên " + dataRow["MA_NV"].ToString() + "  đã tồn tại. Vui lòng kiểm tra lại thông tin!");
                return false;
            }

            else
            {
                return true;
            }
        }
        private bool ma_nhan_vien_khong_trung_lap(DataRow ip_dr)
        {
            DataTable v_dt_source = (DataTable)m_grc.DataSource;
            var v_str_ma_nhan_vien = ip_dr["MA_NV"].ToString();
            var v_count_nv = v_dt_source.AsEnumerable().Count(x => x.Field<string>("MA_NV") == v_str_ma_nhan_vien);
            bool v_bool = v_count_nv == 1;
            if (!v_bool)
            {
                XtraMessageBox.Show("Mã nhân viên " + v_str_ma_nhan_vien + " bị trùng lặp trong File Excel!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return v_bool;
        }
        private bool checked_du_lieu_is_ok()
        {
            int i; int j = 0;
            for (i = 0; i < m_grv.DataRowCount; i++)
            {
                if (checked_data_row_is_not_null(m_grv.GetDataRow(i)))
                {
                    if (!check_ma_nhan_vien_is_ok(m_grv.GetDataRow(i)))
                    {

                        return false;
                    }
                    if (m_grv.GetDataRow(i)["HO_DEM"] == DBNull.Value || m_grv.GetDataRow(i)["HO_DEM"].ToString() == "")
                    {
                        CHRM_BaseMessages.MsgBox_Error("Mã nhân viên " + m_grv.GetDataRow(i)["MA_NV"].ToString() + "  có cột HO_DEM trống. Vui lòng kiểm tra lại thông tin!");
                        return false;
                    }
                    if (m_grv.GetDataRow(i)["TEN"] == DBNull.Value || m_grv.GetDataRow(i)["TEN"].ToString() == "")
                    {
                        CHRM_BaseMessages.MsgBox_Error("Mã nhân viên " + m_grv.GetDataRow(i)["MA_NV"].ToString() + "  có cột TEN trống. Vui lòng kiểm tra lại thông tin!");
                        return false;
                    }
                    if (!ma_nhan_vien_khong_trung_lap(m_grv.GetDataRow(i)))
                    {
                        return false;
                    }
                }
                else { j++; }
            }
            if (i == 0) { CHRM_BaseMessages.MsgBox_Error("Kiểm tra lại dữ liệu!"); return false; }
            if (j == m_grv.DataRowCount)
            {
                CHRM_BaseMessages.MsgBox_Error("Kiểm tra lại dữ liệu!"); return false;
            }
            return true;
        }

        private string find_id_cm_dm_tu_dien_by_trinh_do_van_hoa(string ip_str_trinh_do_van_hoa)
        {
            US_CM_DM_TU_DIEN v_us = new US_CM_DM_TU_DIEN();
            DS_CM_DM_TU_DIEN v_ds = new DS_CM_DM_TU_DIEN();

            v_us.FillDataset(v_ds);
            ip_str_trinh_do_van_hoa = ip_str_trinh_do_van_hoa.Trim().ToUpper();
            string v_str_filter = "MA_TU_DIEN = '" + ip_str_trinh_do_van_hoa + "'";
            DataRow[] v_dr = v_ds.CM_DM_TU_DIEN.Select(v_str_filter);

            if (v_dr.Count() == 0)
            {
                return null;
            }
            else
            {
                return v_dr.First()["ID"].ToString();
            }
        }

        private void set_init_form_load()
        {
            this.WindowState = FormWindowState.Maximized;
            m_lbl_check.Text = "Chưa lưu dữ liệu";
            foreach (DevExpress.XtraGrid.Columns.GridColumn col in ((DevExpress.XtraGrid.Views.Base.ColumnView)m_grc.Views[0]).Columns)
            {
                col.MaxWidth = 100;
                col.MinWidth = 100;
            }
        }

        private void load_data_2_grid(string m_txt_path)
        {
            if (m_txt_path != "")
            {
                m_grc.DataSource = null;
                WinFormControls.load_xls_to_gridview_v3(m_txt_path, m_grc, "NHAP_LIEU");
            }
        }

        private string chon_file()
        {
            return WinFormControls.openFileDialog();
        }

        private void save_data()
        {
            US_DM_NHAN_VIEN v_us_trans = new US_DM_NHAN_VIEN();
            int i = 0;
            try
            {
                
                SplashScreenManager.ShowForm(typeof(F_wait_form));
                
                v_us_trans.BeginTransaction();
                for (i = 0; i < m_grv.RowCount; i++)
                {
                    US_DM_NHAN_VIEN v_us = new US_DM_NHAN_VIEN();
                    switch (m_e_form_mode)
                    {
                        case DataEntryFormMode.UpdateDataState:
                            v_us = gan_du_lieu_cho_us_dm_nhan_vien(m_grv.GetDataRow(i));
                            v_us.UseTransOfUSObject(v_us_trans);
                            v_us.Update();
                            break;
                        case DataEntryFormMode.InsertDataState:
                            v_us = gan_du_lieu_cho_us_dm_nhan_vien(m_grv.GetDataRow(i));
                            v_us.Insert();
                            break;
                        default:
                            break;
                    }
                }
                v_us_trans.CommitTransaction();
                m_lbl_check.Text = "Đã lưu dữ liệu";
                m_lbl_check.ForeColor = Color.Green;
                CHRM_BaseMessages.MsgBox_Infor(CONST_ID_MSGBOX.INFOR_LUU_DU_LIEU_THANH_CONG);

            }
            catch (Exception v_e)
            {
                XtraMessageBox.Show(i.ToString());
                if (v_us_trans.is_having_transaction())
                {
                    v_us_trans.Rollback();
                }
                throw;
            }
            finally
            {
                SplashScreenManager.CloseForm();
            }

        }

        private bool checked_data_row_is_not_null(DataRow dataRow)
        {
            for (int i = 0; i < dataRow.ItemArray.Length; i++)
            {
                if (dataRow.ItemArray[i].ToString() == null || dataRow.ItemArray[i].ToString() == "")
                {
                }
                else { return true; }
            }
            return false;
        }

        #endregion

        //EVENTS
        private void set_define_event()
        {
            Load += F152_DANH_SACH_NHAN_VIEN_EXCEL_Load;
            m_cmd_luu.Click += m_cmd_luu_Click;
            m_cmd_chon_file.Click += M_cmd_chon_file_Click;
            m_cmd_xuat_excel.Click += M_cmd_xuat_excel_Click;
            m_cmd_tai_file_excel_mau.Click += M_cmd_tai_file_excel_mau_Click;
        }

        private void M_cmd_tai_file_excel_mau_Click(object sender, EventArgs e)
        {
            try
            {
                SplashScreenManager.ShowForm(typeof(F_wait_form));
                WinFormControls.openTemplate_v2(CONST_EXCEL_TEMPLATE.DANH_SACH_NHAN_VIEN_TEMPLATE);
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
            finally
            {
                SplashScreenManager.CloseForm();
            }
        }

        private void M_cmd_xuat_excel_Click(object sender, EventArgs e)
        {
            try
            {
                xuat_excel();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void M_cmd_chon_file_Click(object sender, EventArgs e)
        {
            try
            {
                SplashScreenManager.ShowForm(typeof(F_wait_form));
                //load_data_2_grid(chon_file());
                OpenFileDialog opf = new OpenFileDialog();
                opf.Filter = "Office Files|*.xlsx;*.xls;";
                opf.Multiselect = false;
                if (opf.ShowDialog() == DialogResult.OK)
                {
                    if (String.IsNullOrEmpty(opf.FileName))
                    {
                        return;
                    }
                    load_data_from_file_to_grid(opf.FileName);
                }
                else
                {
                    m_grc.Refresh();
                    return;
                }
            }
            catch (Exception v_e)
            {
                XtraMessageBox.Show("Không lấy dữ liệu được từ File Excel Import. Bạn kiểm tra lại File Excel Import nhé!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //CSystemLog_301.ExceptionHandle(v_e);
            }
            finally
            {
                SplashScreenManager.CloseForm();
            }
        }

        private void load_data_from_file_to_grid(string path)
        {
            var v_data_table_grv = load_data_from_file_to_data_table(path, "NHAP_LIEU");
            format_data_table(v_data_table_grv);
            m_grc.DataSource = v_data_table_grv;
            m_grv.BestFitColumns();
        }

        private void format_data_table(DataTable ip_dt_src)
        {
            ip_dt_src.Columns[(int)thu_tu_cot.STT].ColumnName = ExcelHopDong.STT;
            ip_dt_src.Columns[(int)thu_tu_cot.MA_NV].ColumnName = ExcelHopDong.MA_NV;
            ip_dt_src.Columns[(int)thu_tu_cot.HO_DEM].ColumnName = ExcelHopDong.HO_DEM;
            ip_dt_src.Columns[(int)thu_tu_cot.TEN].ColumnName = ExcelHopDong.TEN;
            ip_dt_src.Columns[(int)thu_tu_cot.GIOI_TINH].ColumnName = ExcelHopDong.GIOI_TINH;
            ip_dt_src.Columns[(int)thu_tu_cot.EMAIL].ColumnName = ExcelHopDong.EMAIL;
            ip_dt_src.Columns[(int)thu_tu_cot.SDT].ColumnName = ExcelHopDong.SDT;
            ip_dt_src.Columns[(int)thu_tu_cot.SO_TAI_KHOAN].ColumnName = ExcelHopDong.SO_TAI_KHOAN;
            ip_dt_src.Columns[(int)thu_tu_cot.NGAN_HANG].ColumnName = ExcelHopDong.NGAN_HANG;
            ip_dt_src.Columns[(int)thu_tu_cot.NGAY_CAP_THE].ColumnName = ExcelHopDong.NGAY_CAP_THE;
            ip_dt_src.Columns[(int)thu_tu_cot.NGAY_HET_HAN_THE].ColumnName = ExcelHopDong.NGAY_HET_HAN_THE;
            ip_dt_src.Columns[(int)thu_tu_cot.NGAY_SINH].ColumnName = ExcelHopDong.NGAY_SINH;
            ip_dt_src.Columns[(int)thu_tu_cot.HON_NHAN].ColumnName = ExcelHopDong.HON_NHAN;
            ip_dt_src.Columns[(int)thu_tu_cot.SO_CMT].ColumnName = ExcelHopDong.SO_CMT;
            ip_dt_src.Columns[(int)thu_tu_cot.NGAY_CAP].ColumnName = ExcelHopDong.NGAY_CAP;
            ip_dt_src.Columns[(int)thu_tu_cot.NOI_CAP].ColumnName = ExcelHopDong.NOI_CAP;
            ip_dt_src.Columns[(int)thu_tu_cot.QUOC_TICH].ColumnName = ExcelHopDong.QUOC_TICH;
            ip_dt_src.Columns[(int)thu_tu_cot.DAN_TOC].ColumnName = ExcelHopDong.DAN_TOC;
            ip_dt_src.Columns[(int)thu_tu_cot.TON_GIAO].ColumnName = ExcelHopDong.TON_GIAO;
            ip_dt_src.Columns[(int)thu_tu_cot.NOI_SINH].ColumnName = ExcelHopDong.NOI_SINH;
            ip_dt_src.Columns[(int)thu_tu_cot.QUE_QUAN].ColumnName = ExcelHopDong.QUE_QUAN;
            ip_dt_src.Columns[(int)thu_tu_cot.DIA_CHI_THUONG_TRU].ColumnName = ExcelHopDong.DIA_CHI_THUONG_TRU;
            ip_dt_src.Columns[(int)thu_tu_cot.DIA_CHI_TAM_TRU].ColumnName = ExcelHopDong.DIA_CHI_TAM_TRU;
            ip_dt_src.Columns[(int)thu_tu_cot.DIA_CHI_LIEN_LAC].ColumnName = ExcelHopDong.DIA_CHI_LIEN_LAC;
            ip_dt_src.Columns[(int)thu_tu_cot.MA_SO_THUE_CA_NHAN].ColumnName = ExcelHopDong.MA_SO_THUE_CA_NHAN;
            ip_dt_src.Columns[(int)thu_tu_cot.CHUYEN_MON].ColumnName = ExcelHopDong.CHUYEN_MON;
            ip_dt_src.Columns[(int)thu_tu_cot.TRINH_DO_VAN_HOA].ColumnName = ExcelHopDong.TRINH_DO_VAN_HOA;
            ip_dt_src.Columns[(int)thu_tu_cot.NAM_TOT_NGHIEP].ColumnName = ExcelHopDong.NAM_TOT_NGHIEP;
            ip_dt_src.Columns[(int)thu_tu_cot.TOT_NGHIEP_TAI].ColumnName = ExcelHopDong.TOT_NGHIEP_TAI;
            ip_dt_src.Columns[(int)thu_tu_cot.NGAY_VAO_HANG_KHONG].ColumnName = ExcelHopDong.NGAY_VAO_HANG_KHONG;
            ip_dt_src.Columns[(int)thu_tu_cot.NGAY_TIEP_NHAN_VAO_TCT].ColumnName = ExcelHopDong.NGAY_TIEP_NHAN_VAO_TCT;
            ip_dt_src.Columns[(int)thu_tu_cot.NGAY_CHINH_THUC_TIEP_NHAN].ColumnName = ExcelHopDong.NGAY_CHINH_THUC_TIEP_NHAN;
            ip_dt_src.Columns[(int)thu_tu_cot.NGUOI_BAO_LANH].ColumnName = ExcelHopDong.NGUOI_BAO_LANH;

        }

        private DataTable load_data_from_file_to_data_table(string ip_str_path, string ip_name_sheet_import)
        {
            string conStr = "";
            string SheetName = ip_name_sheet_import + "$";

            conStr = ConfigurationManager.ConnectionStrings["Excel07ConString"].ConnectionString;
            conStr = String.Format(conStr, ip_str_path, "Yes");
            OleDbConnection con = new OleDbConnection(conStr);
            OleDbCommand ExcelCommand = new OleDbCommand();
            ExcelCommand.Connection = con;
            con.Open();
            DataTable ExcelDataSet = new DataTable();
            ExcelDataSet = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
            DataTable dt = new DataTable();
            if (ExcelDataSet != null && ExcelDataSet.Rows.Count > 0)
            {
                //string SheetName = ExcelDataSet.Rows[0]["TABLE_NAME"].ToString(); // get sheetname
                ExcelCommand.CommandText = "SELECT * From [" + SheetName + "]";// WHERE [" + ExcelHopDong.MA_NHAN_VIEN + "] IS NOT NULL";
                OleDbDataAdapter ExcelAdapter = new OleDbDataAdapter(ExcelCommand);
                ExcelAdapter.SelectCommand = ExcelCommand;
                ExcelAdapter.Fill(dt);
            }
            con.Close();
            DataTable v_dt_result = dt.Rows.Cast<DataRow>().Where(row => !row.ItemArray.All(field => field is System.DBNull || string.IsNullOrEmpty(field.ToString()) == true)).CopyToDataTable();
            return v_dt_result;
        }

        private void F152_DANH_SACH_NHAN_VIEN_EXCEL_Load(object sender, EventArgs e)
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

        private void m_cmd_luu_Click(object sender, EventArgs e)
        {
            try
            {
                switch (m_e_form_mode)
                {
                    case DataEntryFormMode.UpdateDataState:
                        if (checked_du_lieu_update_is_ok())
                        {
                            save_data();
                        }
                        break;
                    case DataEntryFormMode.InsertDataState:
                        if (checked_du_lieu_is_ok())
                        {
                            save_data();
                        }
                        break;
                    default:
                        break;
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private bool checked_du_lieu_update_is_ok()
        {
            int i; int j = 0;
            for (i = 0; i < m_grv.DataRowCount; i++)
            {
                if (checked_data_row_is_not_null(m_grv.GetDataRow(i)))
                {
                    if (!check_ma_nhan_vien_update_is_ok(m_grv.GetDataRow(i)))
                    {
                        return false;
                    }
                    if (m_grv.GetDataRow(i)["HO_DEM"] == DBNull.Value || m_grv.GetDataRow(i)["HO_DEM"].ToString() == "")
                    {
                        CHRM_BaseMessages.MsgBox_Error("Mã nhân viên " + m_grv.GetDataRow(i)["MA_NV"].ToString() + "  có cột HO_DEM trống. Vui lòng kiểm tra lại thông tin!");
                        return false;
                    }
                    if (m_grv.GetDataRow(i)["TEN"] == DBNull.Value || m_grv.GetDataRow(i)["TEN"].ToString() == "")
                    {
                        CHRM_BaseMessages.MsgBox_Error("Mã nhân viên " + m_grv.GetDataRow(i)["MA_NV"].ToString() + "  có cột TEN trống. Vui lòng kiểm tra lại thông tin!");
                        return false;
                    }
                    if (!ma_nhan_vien_khong_trung_lap(m_grv.GetDataRow(i)))
                    {
                        return false;
                    }
                }
                else { j++; }
            }
            if (i == 0) { CHRM_BaseMessages.MsgBox_Error("Kiểm tra lại dữ liệu!"); return false; }
            if (j == m_grv.DataRowCount)
            {
                CHRM_BaseMessages.MsgBox_Error("Kiểm tra lại dữ liệu!"); return false;
            }
            return true;
        }

        private bool check_ma_nhan_vien_update_is_ok(DataRow dataRow)
        {
            if (dataRow["MA_NV"] == null || dataRow["MA_NV"].ToString() == "")
            {
                XtraMessageBox.Show("Có ô mã nhân viên bị trống!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            US_DM_NHAN_VIEN v_us = new US_DM_NHAN_VIEN();
            DS_DM_NHAN_VIEN v_ds_nhan_vien = new DS_DM_NHAN_VIEN();
            v_us.FillDataset(v_ds_nhan_vien, " where MA_NV= '" + dataRow["MA_NV"].ToString() + "'");
            if (!(v_ds_nhan_vien.Tables[0].Rows.Count > 0))
            {
                CHRM_BaseMessages.MsgBox_Error("Mã nhân viên " + dataRow["MA_NV"].ToString() + "  chưa tồn tại. Vui lòng kiểm tra lại thông tin!");
                return false;
            }

            else
            {
                return true;
            }
        }

        private void xuat_excel()
        {
            XlsExportOptions opt = new XlsExportOptions();
            opt.SheetName = "NHAP_LIEU";
            opt.TextExportMode = TextExportMode.Value;
            string path = WinFormControls.saveFileDialog("DANH_SACH_NHAN_VIEN");
            if (!String.IsNullOrEmpty(path))
            {
                m_grv.ExportToXls(path, opt);
                var excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = true;
                Microsoft.Office.Interop.Excel.Workbooks books = excel.Workbooks;
                Microsoft.Office.Interop.Excel.Workbook openexcel = books.Open(path);
            }
        }
    }
}
