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
using BKI_DichVuMatDat.DS.CDBNames;
using BKI_DichVuMatDat.US;
using DevExpress.XtraEditors;
using IP.Core.IPCommon;
using IP.Core.IPSystemAdmin;

namespace BKI_DichVuMatDat.NghiepVu
{
    public partial class f367_quan_li_nv_ko_dong_bao_hiem_v2 : Form
    {


        #region Public interface
        public f367_quan_li_nv_ko_dong_bao_hiem_v2()
        {
            InitializeComponent();
            format_controls();
        }
        #endregion

        #region Members
        DataEntryFormMode m_e_form_mode = DataEntryFormMode.InsertDataState;
        DateTime m_date_time_goi_y = DateTime.Now.Date;
        #endregion

        #region Private methods
        private void format_controls()
        {
            //FormatControl.SetVisibleSimpleButton(this);
            this.m_grv_luong_cung_cua_nhan_vien.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(WinFormControls.m_grv_PopupMenuShowing);
            this.m_grv_luong_cung_cua_nhan_vien.OptionsPrint.AutoWidth = false;
            set_define_events();
            this.KeyPreview = true;
        }

        private void set_initial_form_load()
        {
            //load_data_2_sle_chon_nv();
            m_dat_thang.EditValue = m_date_time_goi_y;
            load_data_2_grid();
        }

        //load data 2 all controls
        private DS_V_DM_NHAN_VIEN load_data_2_ds_v_dm_nv()
        {
            DS_V_DM_NHAN_VIEN v_ds = new DS_V_DM_NHAN_VIEN();
            US_V_DM_NHAN_VIEN v_us = new US_V_DM_NHAN_VIEN();

            v_us.FillDataset(v_ds);
            return v_ds;
        }

        //private void load_data_2_sle_chon_nv()
        //{
        //    m_sle_chon_nhan_vien.Properties.DataSource = load_data_2_ds_v_dm_nv().V_DM_NHAN_VIEN;
        //    m_sle_chon_nhan_vien.Properties.ValueMember = V_DM_NHAN_VIEN.ID;
        //    m_sle_chon_nhan_vien.Properties.DisplayMember = V_DM_NHAN_VIEN.HO_TEN;
        //    m_sle_chon_nhan_vien.Properties.PopulateViewColumns();
        //    m_sle_chon_nhan_vien.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
        //    m_sle_chon_nhan_vien.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
        //}

        private void load_data_2_grid()
        {
            CHRMCommon.make_stt(m_grv_luong_cung_cua_nhan_vien);
            US_V_GD_KHONG_DONG_BAO_HIEM v_us = new US_V_GD_KHONG_DONG_BAO_HIEM();
            DS_V_GD_KHONG_DONG_BAO_HIEM v_ds = new DS_V_GD_KHONG_DONG_BAO_HIEM();
            v_us.FillDataset(v_ds, "WHERE THANG = " + CIPConvert.ToDecimal(m_dat_thang.DateTime.Month.ToString()) + " AND NAM = " + CIPConvert.ToDecimal(m_dat_thang.DateTime.Year.ToString()));
            m_grc_luong_cung_cua_nhan_vien.DataSource = v_ds.Tables[0];
        }

        private void load_all_data_2_grid()
        {
            CHRMCommon.make_stt(m_grv_luong_cung_cua_nhan_vien);
            US_V_GD_KHONG_DONG_BAO_HIEM v_us = new US_V_GD_KHONG_DONG_BAO_HIEM();
            DS_V_GD_KHONG_DONG_BAO_HIEM v_ds = new DS_V_GD_KHONG_DONG_BAO_HIEM();
            v_us.FillDataset(v_ds);
            m_grc_luong_cung_cua_nhan_vien.DataSource = v_ds.Tables[0];
        }

        private void load_data_2_grid(decimal ip_dc_id_nv)
        {
            CHRMCommon.make_stt(m_grv_luong_cung_cua_nhan_vien);

            US_V_GD_KHONG_DONG_BAO_HIEM v_us = new US_V_GD_KHONG_DONG_BAO_HIEM();
            DS_V_GD_KHONG_DONG_BAO_HIEM v_ds = new DS_V_GD_KHONG_DONG_BAO_HIEM();

            v_us.FillDataset(v_ds, "WHERE ID_NHAN_VIEN = " + ip_dc_id_nv.ToString());
            m_grc_luong_cung_cua_nhan_vien.DataSource = v_ds.Tables[0];
        }

        private void form_2_us_luong_cung(US_GD_KHONG_DONG_BAO_HIEM ip_us)
        {
            decimal ip_thang = CIPConvert.ToDecimal(m_dat_thang.DateTime.Month.ToString());
            decimal ip_nam = CIPConvert.ToDecimal(m_dat_thang.DateTime.Year.ToString());
            decimal id_nv = CIPConvert.ToDecimal(m_grv_luong_cung_cua_nhan_vien.GetRowCellValue(m_grv_luong_cung_cua_nhan_vien.FocusedRowHandle, "ID_NHAN_VIEN"));
            ip_us.dcID = find_id_gd_khong_dong_bao_hiem(id_nv, ip_thang, ip_nam);
            ip_us.datNGAY_LAP = Convert.ToDateTime(m_grv_luong_cung_cua_nhan_vien.GetRowCellValue(m_grv_luong_cung_cua_nhan_vien.FocusedRowHandle, "NGAY_LAP")).Date;
            ip_us.strNGUOI_LAP = CAppContext_201.getCurrentUser();
            ip_us.dcTHANG = CIPConvert.ToDecimal(m_dat_thang.DateTime.Month.ToString());
            ip_us.dcNAM = CIPConvert.ToDecimal(m_dat_thang.DateTime.Year.ToString());
            ip_us.dcID_NHAN_VIEN = id_nv;
            ip_us.strLY_DO = m_grv_luong_cung_cua_nhan_vien.GetRowCellValue(m_grv_luong_cung_cua_nhan_vien.FocusedRowHandle, "LY_DO").ToString();
        }

        private decimal find_id_gd_khong_dong_bao_hiem(decimal id_nv, decimal ip_thang, decimal ip_nam)
        {
            try
            {
                US_GD_KHONG_DONG_BAO_HIEM v_us = new US_GD_KHONG_DONG_BAO_HIEM();
                DS_GD_KHONG_DONG_BAO_HIEM v_ds = new DS_GD_KHONG_DONG_BAO_HIEM();

                v_us.FillDataset(v_ds);

                string v_str_filter = "ID_NHAN_VIEN = '" + id_nv + "' AND THANG = '" + ip_thang + "' AND NAM = '" + ip_nam + "'";
                DataRow[] v_dr = v_ds.GD_KHONG_DONG_BAO_HIEM.Select(v_str_filter);

                if (v_dr.Count() == 0)
                {
                    return 0;
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

        private bool check_id_khong_dong_bao_hiem_is_exist(decimal ip_dc_id_nhan_vien)
        {
            US_GD_KHONG_DONG_BAO_HIEM v_us = new US_GD_KHONG_DONG_BAO_HIEM();
            DS_GD_KHONG_DONG_BAO_HIEM v_ds = new DS_GD_KHONG_DONG_BAO_HIEM();
            v_us.FillDataset(v_ds);

            string v_str_filter = "ID_NHAN_VIEN = " + ip_dc_id_nhan_vien + " AND THANG = " + CIPConvert.ToDecimal(m_dat_thang.DateTime.Month.ToString()) + " AND NAM = " + CIPConvert.ToDecimal(m_dat_thang.DateTime.Year.ToString()) + "";
            DataRow[] v_dr = v_ds.Tables[0].Select(v_str_filter);

            if (v_dr.Count() == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void set_define_events()
        {
            this.Load += f367_Quan_ly_nhan_vien_khong_dong_bao_hiem_Load;
            m_cmd_update.Click += m_grv_luong_cung_cua_nhan_vien_DoubleClick;
            m_cmd_xem_thong_tin.Click += m_cmd_xem_thong_tin_Click;
            m_cmd_insert.Click += m_cmd_insert_Click;
            m_grv_luong_cung_cua_nhan_vien.DoubleClick += m_grv_luong_cung_cua_nhan_vien_DoubleClick;
            m_cmd_xuat_excel.Click += m_cmd_xuat_excel_Click;
            m_cmd_delete.Click += m_cmd_delete_Click;
        }





        //private void load_data_2_form_4_udate()
        //{
        //    decimal v_id_nv = CIPConvert.ToDecimal(m_grv_luong_cung_cua_nhan_vien.GetRowCellValue(m_grv_luong_cung_cua_nhan_vien.FocusedRowHandle, "ID_NHAN_VIEN"));
        //    if (check_id_khong_dong_bao_hiem_is_exist(v_id_nv))
        //    {
        //        decimal v_id_gd_khong_dong_bao_hiem = CIPConvert.ToDecimal(m_grv_luong_cung_cua_nhan_vien.GetRowCellValue(m_grv_luong_cung_cua_nhan_vien.FocusedRowHandle, "ID"));
        //        US_GD_KHONG_DONG_BAO_HIEM v_us = new US_GD_KHONG_DONG_BAO_HIEM(v_id_gd_khong_dong_bao_hiem);
        //        m_e_form_mode = DataEntryFormMode.UpdateDataState;
        //        us_obj_2_form(v_us);
        //    }
        //    else
        //    {
        //        CHRM_BaseMessages.MsgBox_Infor("Nhân viên này chưa có thông tin trong tháng " + m_txt_chon_thang.Text.Trim() + " năm " + m_txt_chon_nam.Text.Trim());
        //        m_sle_chon_nhan_vien.EditValue = v_id_nv;
        //        return;
        //    }
        //}

        //focus new row after created
        //private void focus_new_row_created()
        //{
        //    int v_row_index = 0;
        //    decimal v_id_nv_f366 = 0;

        //    US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
        //    DataSet v_ds = new DataSet();
        //    v_ds.Tables.Add(new DataTable());

        //    v_us.FillDatasetWithTableName(v_ds, "V_GD_KHONG_DONG_BAO_HIEM");

        //    v_id_nv_f366 = CIPConvert.ToDecimal(m_sle_chon_nhan_vien.EditValue);

        //    for (v_row_index = 0; v_row_index < v_ds.Tables[0].Rows.Count; v_row_index++)
        //    {
        //        var v_id_nv = CIPConvert.ToDecimal(m_grv_luong_cung_cua_nhan_vien.GetDataRow(v_row_index)["ID_NHAN_VIEN"].ToString());

        //        if (v_id_nv == v_id_nv_f366)
        //        {
        //            break;
        //        }
        //    }

        //    m_grv_luong_cung_cua_nhan_vien.FocusedRowHandle = v_row_index;
        //}

        //refesh form
        //private void refresh_form()
        //{
        //    m_sle_chon_nhan_vien.EditValue = null;
        //    m_txt_chon_nam.Text = "";
        //    m_txt_chon_thang.Text = "";
        //    m_txt_ly_do.Text = "";
        //}

        #endregion


        void m_cmd_xuat_excel_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "xls files (*.xls)|*.xls|All files (*.*)|*.*";
                saveFileDialog1.RestoreDirectory = true;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    m_grv_luong_cung_cua_nhan_vien.ExportToXls(saveFileDialog1.FileName);
                    CHRM_BaseMessages.MsgBox_Infor(CONST_ID_MSGBOX.INFOR_LUU_BAO_CAO_THANH_CONG);
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void f367_Quan_ly_nhan_vien_khong_dong_bao_hiem_Load(object sender, EventArgs e)
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

        void m_cmd_update_Click(object sender, EventArgs e)
        {
            try
            {

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
                f368_quan_ly_nv_ko_dong_bao_hiem_de v_f = new f368_quan_ly_nv_ko_dong_bao_hiem_de();
                //v_f.display_4_insert(m_txt_chon_thang.Text, m_txt_chon_nam.Text);
                v_f.display_4_insert(m_dat_thang.EditValue);
                load_data_2_grid();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_xem_thong_tin_Click(object sender, EventArgs e)
        {
            try
            {
                if (m_dat_thang.EditValue == null)
                {
                    CHRM_BaseMessages.MsgBox_Error("Chưa chọn tháng và năm");
                }
                else
                {
                    load_data_2_grid();
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_grv_luong_cung_cua_nhan_vien_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                US_GD_KHONG_DONG_BAO_HIEM v_us = new US_GD_KHONG_DONG_BAO_HIEM();
                form_2_us_luong_cung(v_us);
                f368_quan_ly_nv_ko_dong_bao_hiem_de v_f = new f368_quan_ly_nv_ko_dong_bao_hiem_de();
                v_f.display_4_update(v_us);
                load_data_2_grid();
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
                if (CHRM_BaseMessages.MsgBox_Confirm(CONST_ID_MSGBOX.QUESTION_XAC_NHAN_XOA_DU_LIEU))
                {
                    US_GD_KHONG_DONG_BAO_HIEM v_us = new US_GD_KHONG_DONG_BAO_HIEM();
                    form_2_us_luong_cung(v_us);
                    v_us.Delete();
                    CHRM_BaseMessages.MsgBox_Infor("Đã xóa thành công");
                    load_data_2_grid();
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
    }
}

