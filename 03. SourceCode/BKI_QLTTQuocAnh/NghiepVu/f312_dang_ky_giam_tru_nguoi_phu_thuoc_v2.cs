using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BKI_DichVuMatDat.US;
using BKI_DichVuMatDat.DS;
using BKI_DichVuMatDat.DS.CDBNames;
using IP.Core.IPCommon;
using System.IO;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraPivotGrid;
using IP.Core.IPSystemAdmin;
using DevExpress.XtraSplashScreen;
using BKI_DichVuMatDat.XtraReport;
namespace BKI_DichVuMatDat.NghiepVu
{
    public partial class f312_dang_ky_giam_tru_nguoi_phu_thuoc_v2 : Form
    {
        #region Public Interface

        public f312_dang_ky_giam_tru_nguoi_phu_thuoc_v2()
        {
            InitializeComponent();
            format_controls();
        }

        #endregion

        #region Members

        List<decimal> m_lst_nv_insert_phu_thuoc = new List<decimal>();

        #endregion

        #region Private Methods

        private void format_controls()
        {
            //FormatControl.SetVisibleSimpleButton(this);
            set_define_events();
            this.KeyPreview = true;
        }

        private DateTime from_date()
        {
            return m_dat_tu_thang.DateTime.Date;
        }
        private DateTime to_date()
        {
            return m_dat_den_thang.DateTime.Date;
        }
        private bool check_input_date()
        {
            if(m_dat_tu_thang.EditValue == null && m_dat_den_thang.EditValue == null)
            {
                return false;
            }
            return true;
        }
        //private void load_data_to_m_sle_chon_nhan_vien()
        //{
        //    m_sle_chon_nhan_vien.Properties.DataSource = load_data_to_ds_v_dm_nv().Tables[0];
        //    m_sle_chon_nhan_vien.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
        //    m_sle_chon_nhan_vien.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
        //}

        //private DataSet load_data_to_ds_v_dm_nv()
        //{
        //    US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
        //    DataSet v_ds = new DataSet();
        //    v_ds.Tables.Add(new DataTable());
        //    throw new Exception("Sua lai khong dung FillDataSetWithTableName nua nhe");
        //    //v_us.FillDatasetWithTableName(v_ds, "V_DM_NHAN_VIEN");
        //    return v_ds;
        //}

        //private List<decimal> gd_phu_thuoc_thay_doi_yn(List<decimal> m_lst_nv_insert_phu_thuoc)
        //{
        //    List<decimal> v_lst_nv_thay_doi = new List<decimal>();
        //    for (int i = 0; i < m_lst_nv_insert_phu_thuoc.Count; i++)
        //    {
        //        DS_GD_PHU_THUOC v_ds = new DS_GD_PHU_THUOC();
        //        US_GD_PHU_THUOC v_us = new US_GD_PHU_THUOC();
        //        v_us.FillDataset(v_ds, "where da_xoa = 'N' and id_nhan_vien=" + m_lst_nv_insert_phu_thuoc[i]);
        //        int v_slg_phu_thuoc_details = get_so_luong_phu_thuoc_details(m_lst_nv_insert_phu_thuoc[i]);
        //        DataTable v_dt = v_ds.Tables[0];
        //        if (v_dt.Rows.Count == 0 || (CIPConvert.ToDecimal(v_dt.Rows[0][2].ToString()) < v_slg_phu_thuoc_details))
        //        {
        //            v_lst_nv_thay_doi.Add(m_lst_nv_insert_phu_thuoc[i]);
        //        }
        //    }
        //    return v_lst_nv_thay_doi;
        //}

        //private void update_gd_phu_thuoc(decimal ip_dc_id_nv)
        //{
        //    int v_slg_phu_thuoc_details = get_so_luong_phu_thuoc_details(ip_dc_id_nv);
        //    DS_GD_PHU_THUOC v_ds = new DS_GD_PHU_THUOC();
        //    US_GD_PHU_THUOC v_us = new US_GD_PHU_THUOC();
        //    v_us.FillDatasetPhuThuoc(v_ds, ip_dc_id_nv);
        //    if (v_ds.Tables[0].Rows.Count == 0)
        //    {
        //        v_us.dcID_NHAN_VIEN = ip_dc_id_nv;
        //        v_us.dcSO_LUONG = CIPConvert.ToDecimal(v_slg_phu_thuoc_details);
        //        v_us.strNGUOI_LAP = CAppContext_201.getCurrentUserName();
        //        v_us.strDA_XOA = "N";
        //        v_us.Insert();
        //    }
        //    else
        //    {
        //        US_GD_PHU_THUOC v_us_gd_phu_thuoc = new US_GD_PHU_THUOC(CIPConvert.ToDecimal(v_ds.Tables[0].Rows[0][0]));
        //        v_us_gd_phu_thuoc.dcSO_LUONG = CIPConvert.ToDecimal(v_slg_phu_thuoc_details);
        //        v_us_gd_phu_thuoc.Update();
        //    }
        //}

        //private int get_so_luong_phu_thuoc_details(decimal ip_dc_id_nv)
        //{
        //    DS_GD_PHU_THUOC_DETAILS v_ds = new DS_GD_PHU_THUOC_DETAILS();
        //    US_GD_PHU_THUOC_DETAILS v_us = new US_GD_PHU_THUOC_DETAILS();
        //    v_us.FillDatasetSoLuongPhuThuocDetails(v_ds, ip_dc_id_nv );
        //    return v_ds.Tables[0].Rows.Count;
        //}

        private void insert_gd_phu_thuoc_details()
        {
            for (int i = 0; i < m_grv1.RowCount; i++)
            {
                try
                {
                    US_GD_PHU_THUOC_DETAILS v_us = new US_GD_PHU_THUOC_DETAILS();
                    var v_dr = m_grv1.GetDataRow(i);
                    v_us.dcID_GD_PHU_THUOC = get_id_by_ma_nhan_vien(v_dr[0].ToString());
                    v_us.strHO_TEN_NGUOI_PHU_THUOC = v_dr[3].ToString();
                    v_us.datNGAY_SINH = return_datetime_data(v_dr[4].ToString());
                    v_us.strMA_SO_THUE = v_dr[5].ToString();
                    v_us.strQUOC_TICH = v_dr[6].ToString();
                    v_us.strSO_CMT_HO_CHIEU = v_dr[7].ToString();
                    v_us.strQUAN_HE_VOI_NGUOI_NOP_THUE = v_dr[8].ToString();
                    v_us.strTTGKS_SO = v_dr[9].ToString();
                    v_us.strTTGKS_QUYEN = v_dr[10].ToString();
                    v_us.strTTGKS_QUOC_GIA = v_dr[11].ToString();
                    v_us.strTTGKS_TINH_THANH = v_dr[12].ToString();
                    v_us.strTTGKS_QUAN_HUYEN = v_dr[13].ToString();
                    v_us.strTTGKS_PHUONG_XA = v_dr[14].ToString();
                    v_us.datTU_NGAY = return_datetime_data(v_dr[15].ToString());
                    v_us.strNGUOI_LAP = CAppContext_201.getCurrentUserName();
                    v_us.datNGAY_LAP = DateTime.Now;
                    v_us.strDA_XOA = "N";
                    v_us.Insert();
                }
                catch (Exception v_e)
                {
                    CSystemLog_301.ExceptionHandle(v_e);
                }
            }
        }

        private DateTime return_datetime_data(string ip_str)
        {
            if (ip_str.Trim() == "" )
            {
                return DateTime.Now; 
            }
            return DateTime.Parse(ip_str);
        }

        private decimal get_id_by_ma_nhan_vien(string ip_str_ma_nv)
        {
            DS_DM_NHAN_VIEN v_ds = new DS_DM_NHAN_VIEN();
            US_DM_NHAN_VIEN v_us = new US_DM_NHAN_VIEN();
            v_us.FillDataset(v_ds);
            decimal v_id_nv = v_us.getIDNhanVienByMaNV(ip_str_ma_nv);
            //decimal v_id_nv =  CIPConvert.ToDecimal( v_ds.Tables[0].Rows[0][0].ToString());
            if (!m_lst_nv_insert_phu_thuoc.Contains(v_id_nv))
            {
                m_lst_nv_insert_phu_thuoc.Add(v_id_nv); 
            }            
            return v_id_nv;
        }

        private void load_data_to_grid()
        {
            if(!check_input_date())
            {
                return;
            }
            US_GD_PHU_THUOC_DETAILS v_us_detail = new US_GD_PHU_THUOC_DETAILS();
            var v_dt_source = v_us_detail.LayDanhSachGiamTruPhuThuoc(from_date(), to_date());
            m_grc.DataSource = v_dt_source;
            m_grc.RefreshDataSource();
        }

        private void focus_new_row_created(decimal ip_dc_id_gd_phu_thuoc_details)
        {
            int v_row_index = 0;
            decimal v_id_qd_moi_lap = 0;

            US_DM_THUE v_us = new US_DM_THUE();
            DS_DM_THUE v_ds = new DS_DM_THUE();

            v_id_qd_moi_lap = ip_dc_id_gd_phu_thuoc_details;

            v_us.FillDataset(v_ds);

            for (v_row_index = 0; v_row_index < v_ds.Tables[0].Rows.Count; v_row_index++)
            {
                var v_id_gd_qd = CIPConvert.ToDecimal(m_grv1.GetDataRow(v_row_index)["ID"].ToString());

                if (v_id_gd_qd == v_id_qd_moi_lap)
                {
                    break;
                }
            }

            m_grv1.FocusedRowHandle = v_row_index;
        }

        private void set_initial_form_load()
        {
            //m_lbl_nam_tinh_thue.Text = DateTime.Now.Year.ToString();
            m_dat_tu_thang.EditValue = DateTime.Now.AddMonths(-DateTime.Now.Month+ 1).AddDays(-DateTime.Now.Day + 1).Date;
            m_dat_den_thang.EditValue = DateTime.Now.Date;
            load_data_to_grid();
        }

        private void update_gd_phu_thuoc()
        {

        }

        #endregion
       
        #region Event handle 
        
        private void set_define_events()
        {
            this.Load += f312_dang_ky_giam_tru_nguoi_phu_thuoc_v2_Load;
            m_cmd_update.Click += m_cmd_update_Click;
            m_cmd_delete.Click += m_cmd_delete_Click;
            m_cmd_import_excel.Click += m_cmd_import_excel_Click;
            m_grv1.DoubleClick += new EventHandler(m_grv1_DoubleClick);
            m_cmd_insert.Click += m_cmd_them_click;
            m_cmd_export.Click += m_cmd_export_Click;
            m_cmd_filter.Click += m_cmd_filter_Click;
        }

        void m_cmd_filter_Click(object sender, EventArgs e)
        {
            try
            {
                load_data_to_grid();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_export_Click(object sender, EventArgs e)
        {
            try
            {
                ReportHelper.ExportXLS(m_grc, "BẢNG KÊ THÔNG TIN NGƯỜI PHỤ THUỘC GIẢM TRỪ GIA CẢNH", "GTGC_Bang ke thong tin phu phuoc");
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
                f314_dang_ky_giam_tru_nguoi_phu_thuoc_xls v_f = new f314_dang_ky_giam_tru_nguoi_phu_thuoc_xls();
                v_f.ShowDialog();
                load_data_to_grid();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        
        private void m_cmd_them_click(object sender, EventArgs e)
        {
            try
            {
                f313_dang_ky_giam_tru_nguoi_phu_thuoc_v2_details v_f = new f313_dang_ky_giam_tru_nguoi_phu_thuoc_v2_details();
                v_f.display_4_insert();
                load_data_to_grid();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_grv1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                update_gd_phu_thuoc();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_delete_Click(object sender, EventArgs e)
        {
            try
            {
                string v_str_confirm = "Việc xóa sẽ làm thay đổi số lượng người phụ thuộc của nhân viên.\n Bạn có chắc chắn muốn xóa?";
                DialogResult v_dialog = XtraMessageBox.Show( v_str_confirm,"Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (v_dialog == DialogResult.Yes)
                {
                    var v_dr = m_grv1.GetDataRow(m_grv1.FocusedRowHandle);
                    US_GD_PHU_THUOC_DETAILS v_us = new US_GD_PHU_THUOC_DETAILS(CIPConvert.ToDecimal(v_dr[0].ToString()));
                    v_us.strDA_XOA = "Y";
                    v_us.Update();
                    //update_gd_phu_thuoc(CIPConvert.ToDecimal(v_dr[4].ToString()));
                    XtraMessageBox.Show("Xóa thành công!");
                    load_data_to_grid();
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void f312_dang_ky_giam_tru_nguoi_phu_thuoc_v2_Load(object sender, EventArgs e)
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

        private void m_cmd_update_Click(object sender, EventArgs e)
        {
            try
            {
                decimal v_id_gd_phu_thuoc_details = CIPConvert.ToDecimal(m_grv1.GetRowCellValue(m_grv1.FocusedRowHandle, "ID"));

                if (v_id_gd_phu_thuoc_details > 0)
                {
                    US_GD_PHU_THUOC_DETAILS v_us = new US_GD_PHU_THUOC_DETAILS(v_id_gd_phu_thuoc_details);
                    f313_dang_ky_giam_tru_nguoi_phu_thuoc_v2_details v_frm = new f313_dang_ky_giam_tru_nguoi_phu_thuoc_v2_details();
                    v_frm.display_4_update(v_us);
                    load_data_to_grid();
                    focus_new_row_created(v_id_gd_phu_thuoc_details);
                }
                else
                {
                    CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_CHUA_CHON_DONG_TREN_LUOI_DE_SUA);
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        #endregion
    }
}
