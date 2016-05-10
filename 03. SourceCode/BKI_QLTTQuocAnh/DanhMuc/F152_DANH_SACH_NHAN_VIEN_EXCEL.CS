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

namespace BKI_DichVuMatDat
{
    public partial class F152_DANH_SACH_NHAN_VIEN_EXCEL : Form
    {
        public F152_DANH_SACH_NHAN_VIEN_EXCEL()
        {
            InitializeComponent();
            format_controll();
        }

        #region Public interface
        internal void displayToInsertExcel(string m_txt_path)
        {
            WinFormControls.load_xls_to_gridview_v3(m_txt_path, m_grc, "NHAP_LIEU");
            foreach (DevExpress.XtraGrid.Columns.GridColumn col in ((DevExpress.XtraGrid.Views.Base.ColumnView)m_grc.Views[0]).Columns)
            {
                col.MaxWidth = 100;
                col.MinWidth = 100;
            }
            this.ShowDialog();
        }
        #endregion

        #region Members

        string m_txt_path = "";

        #endregion

        #region Private Methods
        private void format_controll()
        {
            CenterToScreen();
            set_define_event();
        }

        private void gan_du_lieu_cho_us_dm_nhan_vien(DataRow dataRow)
        {
            US_DM_NHAN_VIEN v_us = new US_DM_NHAN_VIEN();
            if (dataRow["NGAY_CAP"].ToString() != "")
                if ((dataRow["NGAY_CAP"].ToString().Substring(0, 10) != ""))
                    v_us.datNGAY_CAP = CIPConvert.ToDatetime(dataRow["NGAY_CAP"].ToString().Substring(0, 10));
            if (dataRow["NGAY_CAP_THE"].ToString() != "")
                if ((dataRow["NGAY_CAP_THE"].ToString().Substring(0, 10) != ""))
                    v_us.datNGAY_CAP_THE = CIPConvert.ToDatetime(dataRow["NGAY_CAP_THE"].ToString().Substring(0, 10));
            if (dataRow["NGAY_CHINH_THUC_TIEP_NHAN"].ToString() != "")
                if ((dataRow["NGAY_CHINH_THUC_TIEP_NHAN"].ToString().Substring(0, 10) != ""))
                    v_us.datNGAY_CHINH_THUC_TIEP_NHAN = CIPConvert.ToDatetime(dataRow["NGAY_CHINH_THUC_TIEP_NHAN"].ToString().Substring(0, 10));
            if (dataRow["NGAY_HET_HAN_THE"].ToString() != "")
                if ((dataRow["NGAY_HET_HAN_THE"].ToString().Substring(0, 10) != ""))
                    v_us.datNGAY_HET_HAN_THE = CIPConvert.ToDatetime(dataRow["NGAY_HET_HAN_THE"].ToString().Substring(0, 10));
            if (dataRow["NGAY_SINH"].ToString() != "")
                if ((dataRow["NGAY_SINH"].ToString().Substring(0, 10) != ""))
                    v_us.datNGAY_SINH = CIPConvert.ToDatetime(dataRow["NGAY_SINH"].ToString().Substring(0, 10));
            if (dataRow["NGAY_TIEP_NHAN_VAO_TCT"].ToString() != "")
                if ((dataRow["NGAY_TIEP_NHAN_VAO_TCT"].ToString().Substring(0, 10) != ""))
                    v_us.datNGAY_TIEP_NHAN_VAO_TCT = CIPConvert.ToDatetime(dataRow["NGAY_TIEP_NHAN_VAO_TCT"].ToString().Substring(0, 10));
            if (dataRow["NGAY_VAO_HANG_KHONG"].ToString() != "")
                if ((dataRow["NGAY_VAO_HANG_KHONG"].ToString().Substring(0, 10) != ""))
                    v_us.datNGAY_VAO_HANG_KHONG = CIPConvert.ToDatetime(dataRow["NGAY_VAO_HANG_KHONG"].ToString().Substring(0, 10));
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
            v_us.Insert();
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
            if (v_ds_nhan_vien.Tables[0].Rows.Count > 0){
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
            if(!v_bool)
            {
                XtraMessageBox.Show("Mã nhân viên " + v_str_ma_nhan_vien + " bị trùng lặp trong File Excel!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return v_bool;
        }
        private bool checked_du_lieu_is_ok()
        {// chưa check, mới check số dòng >0
            //int i;
            //for (i = 0; i < m_grv.GetDataRow(i).ItemArray.Length; i++)
            //{
            //    if (m_grv.GetDataRow(i).ItemArray[i].ToString() != null || m_grv.GetDataRow(i).ItemArray[i].ToString() != "") break;
            //}
            //if (i == m_grv.GetDataRow(i).ItemArray.Length)
            //{

            //}
            //if (m_grv.DataRowCount > 0)
            //{
            //    for (i = 0; i < m_grv.DataRowCount; i++)
            //    {
            //        if (!check_ma_nhan_vien_is_ok(m_grv.GetDataRow(i)))
            //            return false;
            //    }
            //    return true;
            //}
            //else
            //    return false;
            int i; int j = 0;
            for (i = 0; i < m_grv.DataRowCount; i++)
            {
                if (checked_data_row_is_not_null(m_grv.GetDataRow(i)))
                {
                    if (!check_ma_nhan_vien_is_ok(m_grv.GetDataRow(i)))
                    {
                        
                        return false;
                    }
                    if(m_grv.GetDataRow(i)["HO_DEM"] == DBNull.Value || m_grv.GetDataRow(i)["HO_DEM"].ToString() == "")
                    {
                        CHRM_BaseMessages.MsgBox_Error("Mã nhân viên " + m_grv.GetDataRow(i)["MA_NV"].ToString() + "  có cột HO_DEM trống. Vui lòng kiểm tra lại thông tin!");
                        return false;
                    }
                    if(m_grv.GetDataRow(i)["TEN"] == DBNull.Value || m_grv.GetDataRow(i)["TEN"].ToString() == "")
                    {
                        CHRM_BaseMessages.MsgBox_Error("Mã nhân viên " + m_grv.GetDataRow(i)["MA_NV"].ToString() + "  có cột TEN trống. Vui lòng kiểm tra lại thông tin!");
                        return false;
                    }
                    if(!ma_nhan_vien_khong_trung_lap(m_grv.GetDataRow(i)))
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
            for (int i = 0; i < m_grv.DataRowCount; i++)
            {
                if (checked_data_row_is_not_null(m_grv.GetDataRow(i)))
                {
                    gan_du_lieu_cho_us_dm_nhan_vien(m_grv.GetDataRow(i));
                }
                else
                {
                    
                    //F503_IMPORT_EXCEL.da_hoan_thanh = true;
                    m_lbl_check.Text = "Đã lưu dữ liệu";
                    return;
                }
            }
            CHRM_BaseMessages.MsgBox_Infor(CONST_ID_MSGBOX.INFOR_LUU_DU_LIEU_THANH_CONG);
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
                CHRMCommon.ExportExcel(m_grv);
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
                load_data_2_grid(chon_file());
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
                if (checked_du_lieu_is_ok())
                {
                    save_data();
                    //for (int i = 0; i < m_grv.DataRowCount; i++)
                    //{
                    //    if (check_ma_nhan_vien_is_ok(m_grv.GetDataRow(i)))
                    //    {
                    //        gan_du_lieu_cho_us_dm_nhan_vien(m_grv.GetDataRow(i));
                    //    }
                    //    else
                    //    {
                    //        if (m_grv.GetDataRow(i)["MA_NV"].ToString() == "" || m_grv.GetDataRow(i)["MA_NV"] == null)
                    //        {
                    //            CHRM_BaseMessages.MsgBox_Infor(CONST_ID_MSGBOX.INFOR_LUU_DU_LIEU_THANH_CONG);
                    //            F503_IMPORT_EXCEL.da_hoan_thanh = true;
                    //            this.Close();
                    //            return;
                    //        }
                    //        CHRM_BaseMessages.MsgBox_Error("Mã nhân viên " + m_grv.GetDataRow(i)["MA_NV"].ToString() + "  đã tồn tại. Vui lòng kiểm tra lại thông tin!");
                    //        return;
                    //    }
                    //}
                }
                //else
                //{
                //    CHRM_BaseMessages.MsgBox_Error("Kiểm tra lại dữ liệu!");
                //}
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }


        }


    }
}
