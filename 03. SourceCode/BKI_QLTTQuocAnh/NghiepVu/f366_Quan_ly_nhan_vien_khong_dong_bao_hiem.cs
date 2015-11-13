using BKI_DichVuMatDat.DS;
using BKI_DichVuMatDat.DS.CDBNames;
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
    public partial class f366_quan_ly_nhan_vien_khong_dong_bao_hiem : Form
    {
        public f366_quan_ly_nhan_vien_khong_dong_bao_hiem()
        {
            InitializeComponent();
            format_controls();
        }

        #region Public interface

        #endregion

        #region Members
        DataEntryFormMode m_e_form_mode = DataEntryFormMode.InsertDataState;
        #endregion

        #region Private methods
        private void format_controls()
        {
            FormatControl.SetVisibleSimpleButton(this);
            this.m_grv_luong_cung_cua_nhan_vien.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(WinFormControls.m_grv_PopupMenuShowing);
            this.m_grv_luong_cung_cua_nhan_vien.OptionsPrint.AutoWidth = false;
            set_define_events();
            this.KeyPreview = true;
        }

        private void set_initial_form_load()
        {
            load_data_2_sle_chon_nv();
            m_txt_chon_thang.Text = DateTime.Now.Month.ToString();
            m_txt_chon_nam.Text = DateTime.Now.Year.ToString();
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

        private void load_data_2_sle_chon_nv()
        {
            m_sle_chon_nhan_vien.Properties.DataSource = load_data_2_ds_v_dm_nv().V_DM_NHAN_VIEN;
            m_sle_chon_nhan_vien.Properties.ValueMember = V_DM_NHAN_VIEN.ID;
            m_sle_chon_nhan_vien.Properties.DisplayMember = V_DM_NHAN_VIEN.HO_TEN;

            m_sle_chon_nhan_vien.Properties.PopulateViewColumns();
            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.ID].Visible = false;
            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.HO_DEM].Visible = false;
            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.TEN].Visible = false;
            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.DAN_TOC].Visible = false;
            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.CHUYEN_MON].Visible = false;
            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.DIA_CHI_TAM_TRU].Visible = false;
            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.DIA_CHI_THUONG_TRU].Visible = false;
            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.MA_SO_THUE_CA_NHAN].Visible = false;
            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.NAM_TOT_NGHIEP].Visible = false;
            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.NGAN_HANG].Visible = false;
            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.NGAY_CAP].Visible = false;
            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.NGAY_CAP_THE].Visible = false;
            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.NGAY_CHINH_THUC_TIEP_NHAN].Visible = false;
            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.NGAY_HET_HAN_THE].Visible = false;
            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.NGAY_TIEP_NHAN_VAO_TCT].Visible = false;
            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.NGAY_VAO_HANG_KHONG].Visible = false;
            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.NOI_CAP].Visible = false;
            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.NOI_SINH].Visible = false;
            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.QUE_QUAN].Visible = false;
            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.QUOC_TICH].Visible = false;
            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.SO_CMT].Visible = false;
            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.SO_TAI_KHOAN].Visible = false;
            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.TON_GIAO].Visible = false;
            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.TOT_NGHIEP_TAI].Visible = false;
            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.TRINH_DO_VAN_HOA].Visible = false;
            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.NGAY_SINH].Visible = false;
            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.HON_NHAN].Visible = false;

            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.MA_NV].Width = 75;
            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.HO_TEN].Width = 120;

            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.MA_NV].Caption = "Mã NV";
            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.HO_TEN].Caption = "Họ tên";
            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.GIOI_TINH].Caption = "Giới tính";
            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.SDT].Caption = "SĐT";
            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.EMAIL].Caption = "Email";
            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.DIA_CHI_LIEN_LAC].Caption = "Địa chị liên lạc";

            m_sle_chon_nhan_vien.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            m_sle_chon_nhan_vien.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
        }

        private void load_data_2_grid()
        {
            CHRMCommon.make_stt(m_grv_luong_cung_cua_nhan_vien);
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());

            v_us.FillDatasetWithQuery(v_ds, "SELECT * FROM V_GD_KHONG_DONG_BAO_HIEM WHERE THANG = " + CIPConvert.ToDecimal(m_txt_chon_thang.Text.Trim()) + " AND NAM = " + CIPConvert.ToDecimal(m_txt_chon_nam.Text.Trim()) + "");
            m_grc_luong_cung_cua_nhan_vien.DataSource = v_ds.Tables[0];
        }

        private void load_data_2_grid(decimal ip_dc_id_nv)
        {
            CHRMCommon.make_stt(m_grv_luong_cung_cua_nhan_vien);
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());

            v_us.FillDatasetWithQuery(v_ds, "SELECT * FROM V_GD_KHONG_DONG_BAO_HIEM WHERE ID_NHAN_VIEN = " + ip_dc_id_nv + " AND THANG = " + CIPConvert.ToDecimal(m_txt_chon_thang.Text.Trim()) + " AND NAM = " + CIPConvert.ToDecimal(m_txt_chon_nam.Text.Trim()) + "");
            m_grc_luong_cung_cua_nhan_vien.DataSource = v_ds.Tables[0];
        }

        //check data is ok
        private bool check_data_is_ok()
        {
            if (m_sle_chon_nhan_vien.EditValue == null || m_sle_chon_nhan_vien.EditValue == "")
            {
                CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_CHUA_CHON_NHAN_VIEN);
                return false;
            }

            if (m_txt_chon_thang.Text == "")
            {
                CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_CHUA_CHON_THANG);
                return false;
            }

            if (m_txt_chon_nam.Text == "")
            {
                CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_CHUA_CHON_NAM);
                return false;
            }
            if (CHRMCommon.thang_da_chot_bang_luong(CIPConvert.ToDecimal(m_txt_chon_thang.Text.Trim()), CIPConvert.ToDecimal(m_txt_chon_nam.Text.Trim())))
            {
                CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_THANG_DA_CHOT_BANG_LUONG);
                return false;
            }
            return true;
        }

        //save data
        private void form_2_us_luong_cung(US_GD_KHONG_DONG_BAO_HIEM ip_us)
        {
            if (m_e_form_mode == DataEntryFormMode.UpdateDataState)
            {
                ip_us.dcID = CIPConvert.ToDecimal(m_grv_luong_cung_cua_nhan_vien.GetRowCellValue(m_grv_luong_cung_cua_nhan_vien.FocusedRowHandle, "ID"));
                //nguoi sua
            }
            else
            {
                ip_us.datNGAY_LAP = DateTime.Now.Date;
                //nguoi lap
            }
            ip_us.dcTHANG = CIPConvert.ToDecimal(m_txt_chon_thang.Text.Trim());
            ip_us.dcNAM = CIPConvert.ToDecimal(m_txt_chon_nam.Text.Trim());
            ip_us.dcID_NHAN_VIEN = CIPConvert.ToDecimal(m_sle_chon_nhan_vien.EditValue);
            ip_us.strLY_DO = m_txt_ly_do.Text.Trim();
        }

        private void us_obj_2_form(US_GD_KHONG_DONG_BAO_HIEM ip_us)
        {
            m_sle_chon_nhan_vien.EditValue = ip_us.dcID_NHAN_VIEN;
            m_txt_chon_thang.Text = ip_us.dcTHANG.ToString();
            m_txt_chon_nam.Text = ip_us.dcNAM.ToString();
            m_txt_ly_do.Text = ip_us.strLY_DO;
        }

        private bool check_id_khong_dong_bao_hiem_is_exist(decimal ip_dc_id_nhan_vien)
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithTableName(v_ds, "GD_KHONG_DONG_BAO_HIEM");

            string v_str_filter = "ID_NHAN_VIEN = " + ip_dc_id_nhan_vien + " AND THANG = " + CIPConvert.ToDecimal(m_txt_chon_thang.Text.Trim()) + " AND NAM = " + CIPConvert.ToDecimal(m_txt_chon_nam.Text.Trim()) + "";
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

        private void save_data()
        {
            US_GD_KHONG_DONG_BAO_HIEM v_us_gd_khong_dong_bao_hiem = new US_GD_KHONG_DONG_BAO_HIEM();
            form_2_us_luong_cung(v_us_gd_khong_dong_bao_hiem);
            try
            {
                switch (m_e_form_mode)
                {
                    case DataEntryFormMode.InsertDataState:
                        v_us_gd_khong_dong_bao_hiem.BeginTransaction();
                        v_us_gd_khong_dong_bao_hiem.Insert();
                        v_us_gd_khong_dong_bao_hiem.CommitTransaction();
                        CHRM_BaseMessages.MsgBox_Infor(CONST_ID_MSGBOX.INFOR_LUU_DU_LIEU_THANH_CONG);
                        break;
                    case DataEntryFormMode.UpdateDataState:
                        v_us_gd_khong_dong_bao_hiem.BeginTransaction();
                        v_us_gd_khong_dong_bao_hiem.Update();
                        v_us_gd_khong_dong_bao_hiem.CommitTransaction();
                        CHRM_BaseMessages.MsgBox_Infor(CONST_ID_MSGBOX.INFOR_DU_LIEU_DA_DUOC_CAP_NHAT);
                        break;
                    default:
                        break;
                }
            }
            catch (Exception v_e)
            {
                //DevExpress.XtraEditors.XtraMessageBox.Show("Đã xẩy ra lỗi trong quá trình lưu dữ liệu", "THÔNG BÁO");
                throw v_e;
            }
        }

        private void load_data_2_form_4_udate()
        {
            decimal v_id_nv = CIPConvert.ToDecimal(m_grv_luong_cung_cua_nhan_vien.GetRowCellValue(m_grv_luong_cung_cua_nhan_vien.FocusedRowHandle, "ID_NHAN_VIEN"));
            if (check_id_khong_dong_bao_hiem_is_exist(v_id_nv))
            {
                decimal v_id_gd_khong_dong_bao_hiem = CIPConvert.ToDecimal(m_grv_luong_cung_cua_nhan_vien.GetRowCellValue(m_grv_luong_cung_cua_nhan_vien.FocusedRowHandle, "ID"));
                US_GD_KHONG_DONG_BAO_HIEM v_us = new US_GD_KHONG_DONG_BAO_HIEM(v_id_gd_khong_dong_bao_hiem);
                m_e_form_mode = DataEntryFormMode.UpdateDataState;
                us_obj_2_form(v_us);
            }
            else
            {
                CHRM_BaseMessages.MsgBox_Infor("Nhân viên này chưa có thông tin trong tháng " + m_txt_chon_thang.Text.Trim() + " năm " + m_txt_chon_nam.Text.Trim());
                m_sle_chon_nhan_vien.EditValue = v_id_nv;
                return;
            }
        }

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
        private void refresh_form()
        {
            m_sle_chon_nhan_vien.EditValue = null;
            m_txt_chon_nam.Text = "";
            m_txt_chon_thang.Text = "";
            m_txt_ly_do.Text = "";
        }

        #endregion
        private void set_define_events()
        {
            this.Load += f366_Quan_ly_nhan_vien_khong_dong_bao_hiem_Load;
            m_sle_chon_nhan_vien.EditValueChanged += m_sle_chon_nhan_vien_EditValueChanged;
            m_cmd_update.Click += m_cmd_update_Click;
            m_cmd_luu_thong_tin.Click += m_cmd_luu_thong_tin_Click;
            m_cmd_insert.Click += m_cmd_insert_Click;
            m_grv_luong_cung_cua_nhan_vien.DoubleClick += m_grv_luong_cung_cua_nhan_vien_DoubleClick;
        }

        private void f366_Quan_ly_nhan_vien_khong_dong_bao_hiem_Load(object sender, EventArgs e)
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
                load_data_2_form_4_udate();
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
                m_e_form_mode = DataEntryFormMode.InsertDataState;
                refresh_form();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_luu_thong_tin_Click(object sender, EventArgs e)
        {
            try
            {
                if (check_data_is_ok())
                {
                    if (CHRM_BaseMessages.MsgBox_Confirm(CONST_ID_MSGBOX.QUESTION_XAC_NHAN_LUU_DU_LIEU) == true)
                    {
                        save_data();
                    }
                    load_data_2_grid(CIPConvert.ToDecimal(m_sle_chon_nhan_vien.EditValue));
                    //focus_new_row_created();
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
                load_data_2_form_4_udate();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_sle_chon_nhan_vien_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (m_sle_chon_nhan_vien.EditValue == null || m_sle_chon_nhan_vien.EditValue == "")
                {
                    load_data_2_grid();
                }
                else
                {
                    load_data_2_grid(CIPConvert.ToDecimal(m_sle_chon_nhan_vien.EditValue));
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
    }
}
