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
    public partial class f390_gd_thu_nhap_khac : Form
    {
        public f390_gd_thu_nhap_khac()
        {
            InitializeComponent();
            format_controls();
        }

        #region Public Interface

        #endregion

        #region Members
        DataEntryFormMode m_e_form_mode = DataEntryFormMode.InsertDataState;
        decimal m_insert_is_click = 0;
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

        private void set_initial_form_load()
        {
            load_data_2_sle_chon_nv();
            load_data_2_sle_loai_thu_nhap();
            load_data_2_sle_cach_tinh_thue();
            m_txt_chon_thang.Text = DateTime.Now.Month.ToString();
            m_txt_chon_nam.Text = DateTime.Now.Year.ToString();
            m_txt_so_tien.Text = "0";
        }

        //load data 2 all control
        private DS_V_DM_NHAN_VIEN load_data_2_ds_v_dm_nv()
        {
            DS_V_DM_NHAN_VIEN v_ds = new DS_V_DM_NHAN_VIEN();
            US_V_DM_NHAN_VIEN v_us = new US_V_DM_NHAN_VIEN();

            v_ds.EnforceConstraints = false;
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

        private DS_CM_DM_TU_DIEN load_data_2_cm_dm_tu_dien(int m_id_lns_lcd_trong_loai_td)
        {
            DS_CM_DM_TU_DIEN v_ds = new DS_CM_DM_TU_DIEN();
            US_CM_DM_TU_DIEN v_us = new US_CM_DM_TU_DIEN();

            v_us.FillDatasetByIdLoaiTuDien(v_ds, m_id_lns_lcd_trong_loai_td);

            return v_ds;
        }

        private void load_data_2_sle_loai_thu_nhap()
        {
            m_sle_loai_thu_nhap.Properties.DataSource = load_data_2_cm_dm_tu_dien(CONST_ID_LOAI_TU_DIEN.LOAI_THU_NHAP_KHAC).CM_DM_TU_DIEN;
            m_sle_loai_thu_nhap.Properties.ValueMember = CM_DM_TU_DIEN.ID;
            m_sle_loai_thu_nhap.Properties.DisplayMember = CM_DM_TU_DIEN.TEN;

            m_sle_loai_thu_nhap.Properties.PopulateViewColumns();
            m_sle_loai_thu_nhap.Properties.View.Columns[CM_DM_TU_DIEN.ID].Visible = false;
            m_sle_loai_thu_nhap.Properties.View.Columns[CM_DM_TU_DIEN.ID_LOAI_TU_DIEN].Visible = false;
            m_sle_loai_thu_nhap.Properties.View.Columns[CM_DM_TU_DIEN.TEN_NGAN].Visible = false;

            m_sle_loai_thu_nhap.Properties.View.Columns[CM_DM_TU_DIEN.MA_TU_DIEN].Width = 75;
            m_sle_loai_thu_nhap.Properties.View.Columns[CM_DM_TU_DIEN.TEN].Width = 120;

            m_sle_loai_thu_nhap.Properties.View.Columns[CM_DM_TU_DIEN.MA_TU_DIEN].Caption = "Mã thu nhập khác";
            m_sle_loai_thu_nhap.Properties.View.Columns[CM_DM_TU_DIEN.TEN].Caption = "Loại thu nhập khác";
            m_sle_loai_thu_nhap.Properties.View.Columns[CM_DM_TU_DIEN.GHI_CHU].Caption = "Ghi chú";

            m_sle_loai_thu_nhap.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            m_sle_loai_thu_nhap.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
        }

        private void load_data_2_sle_cach_tinh_thue()
        {
            m_sle_cach_tinh_thue.Properties.DataSource = load_data_2_cm_dm_tu_dien(CONST_ID_LOAI_TU_DIEN.LOAI_CACH_TINH_THUE).CM_DM_TU_DIEN;
            m_sle_cach_tinh_thue.Properties.ValueMember = CM_DM_TU_DIEN.ID;
            m_sle_cach_tinh_thue.Properties.DisplayMember = CM_DM_TU_DIEN.TEN;

            m_sle_cach_tinh_thue.Properties.PopulateViewColumns();
            m_sle_cach_tinh_thue.Properties.View.Columns[CM_DM_TU_DIEN.ID].Visible = false;
            m_sle_cach_tinh_thue.Properties.View.Columns[CM_DM_TU_DIEN.ID_LOAI_TU_DIEN].Visible = false;
            m_sle_cach_tinh_thue.Properties.View.Columns[CM_DM_TU_DIEN.TEN_NGAN].Visible = false;

            m_sle_cach_tinh_thue.Properties.View.Columns[CM_DM_TU_DIEN.MA_TU_DIEN].Width = 75;
            m_sle_cach_tinh_thue.Properties.View.Columns[CM_DM_TU_DIEN.TEN].Width = 120;

            m_sle_cach_tinh_thue.Properties.View.Columns[CM_DM_TU_DIEN.MA_TU_DIEN].Caption = "Mã cách tính thuê";
            m_sle_cach_tinh_thue.Properties.View.Columns[CM_DM_TU_DIEN.TEN].Caption = "Cách tính thuế";
            m_sle_cach_tinh_thue.Properties.View.Columns[CM_DM_TU_DIEN.GHI_CHU].Caption = "Ghi chú";

            m_sle_cach_tinh_thue.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            m_sle_cach_tinh_thue.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
        }

        private void load_data_2_grid(decimal ip_dc_id_nv, decimal ip_dc_thang, decimal ip_dc_nam)
        {
            CHRMCommon.make_stt(m_grv_quan_ly_thu_nhap_khac);
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());

            v_us.FillDatasetWithQuery(v_ds, "SELECT * FROM V_GD_THU_NHAP_KHAC WHERE ID_NHAN_VIEN = " + ip_dc_id_nv + " AND THANG = " + ip_dc_thang + " AND NAM = " + ip_dc_nam);

            m_grc_quan_ly_thu_nhap_khac.DataSource = v_ds.Tables[0];
        }

        private void load_data_2_gridd(decimal ip_dc_thang, decimal ip_dc_nam)
        {
            CHRMCommon.make_stt(m_grv_quan_ly_thu_nhap_khac);
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());

            v_us.FillDatasetWithQuery(v_ds, "SELECT * FROM V_GD_THU_NHAP_KHAC WHERE THANG = " + ip_dc_thang + " AND NAM = " + ip_dc_nam);

            m_grc_quan_ly_thu_nhap_khac.DataSource = v_ds.Tables[0];
        }

        //cjeck validate data
        private bool check_data_load_data_2_grid_is_ok()
        {
            if (m_txt_chon_thang.Text == "")
            {
                CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_CHUA_CHON_THANG);
                return false;
            }
            else if (m_txt_chon_nam.Text == "")
            {
                CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_CHUA_CHON_NAM);
                return false;
            }
            else
            {
                if (check_validate_data_is_ok(m_txt_chon_thang.Text) && check_validate_data_is_ok(m_txt_chon_nam.Text))
                {
                    return true;
                }
                else
                {
                    CHRM_BaseMessages.MsgBox_Infor(CONST_ID_MSGBOX.ERROR_DU_LIEU_NHAP_CHUA_HOP_LE);
                    return false;
                }
            }
        }

        private bool check_validate_data_is_ok(string ip_str_thang_cham_cong)
        {
            for (int i = 0; i < ip_str_thang_cham_cong.Length; i++)
            {
                if (char.IsDigit(ip_str_thang_cham_cong[i]) == false)
                    return false;
            }
            return true;
        }

        private bool check_data_is_ok()
        {
            if (!check_data_load_data_2_grid_is_ok())
            {
                return false;
            }
            if (m_sle_chon_nhan_vien.EditValue == null || m_sle_chon_nhan_vien.EditValue == "")
            {
                CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_CHUA_CHON_NHAN_VIEN);
                return false;
            }
            if (m_sle_loai_thu_nhap.EditValue == null || m_sle_loai_thu_nhap.EditValue == "")
            {
                CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_CHUA_CHON_LOAI_THU_NHAP);
                return false;
            }
            if (m_txt_so_tien.Text.Trim() == "")
            {
                CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_CHUA_NHAP_SO_TIEN);
                return false;
            }
            if (m_txt_ly_do.Text.Trim() == "")
            {
                CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_CHUA_NHAP_LY_DO);
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
        private void form_2_us_obj(US_GD_THU_NHAP_KHAC ip_us)
        {
            ip_us.dcID_NHAN_VIEN = CIPConvert.ToDecimal(m_sle_chon_nhan_vien.EditValue);
            ip_us.dcSO_TIEN = CIPConvert.ToDecimal(m_txt_so_tien.Text.Trim());
            ip_us.dcTHANG = CIPConvert.ToDecimal(m_txt_chon_thang.Text.Trim());
            ip_us.dcNAM = CIPConvert.ToDecimal(m_txt_chon_nam.Text.Trim());
            ip_us.dcID_LOAI_THU_NHAP_KHAC = CIPConvert.ToDecimal(m_sle_loai_thu_nhap.EditValue);
            if (m_sle_cach_tinh_thue.EditValue != null && m_sle_cach_tinh_thue.EditValue != "")
            {
                ip_us.dcID_CACH_TINH_THUE = CIPConvert.ToDecimal(m_sle_cach_tinh_thue.EditValue);
            }
            ip_us.strLY_DO = m_txt_ly_do.Text.Trim();
        }

        private void us_obj_2_form(decimal ip_dc_id_gd_thu_nhap_khac)
        {
            US_GD_THU_NHAP_KHAC v_us = new US_GD_THU_NHAP_KHAC(ip_dc_id_gd_thu_nhap_khac);
            m_sle_chon_nhan_vien.EditValue = v_us.dcID_NHAN_VIEN;
            m_txt_chon_thang.Text = v_us.dcTHANG.ToString();
            m_txt_chon_nam.Text = v_us.dcNAM.ToString();
            m_sle_loai_thu_nhap.EditValue = v_us.dcID_LOAI_THU_NHAP_KHAC;
            m_sle_cach_tinh_thue.EditValue = v_us.dcID_CACH_TINH_THUE;
            m_txt_so_tien.Text = v_us.dcSO_TIEN.ToString();
            CHRMCommon.format_text_2_money(m_txt_so_tien);
            m_txt_ly_do.Text = v_us.strLY_DO;
        }

        private void save_data(ref decimal v_id_gd_thu_nhap_khac)
        {
            US_GD_THU_NHAP_KHAC v_us_gd_thu_nhap_khac = new US_GD_THU_NHAP_KHAC();
            form_2_us_obj(v_us_gd_thu_nhap_khac);
            try
            {
                switch (m_e_form_mode)
                {
                    case DataEntryFormMode.InsertDataState:
                        v_us_gd_thu_nhap_khac.BeginTransaction();
                        v_us_gd_thu_nhap_khac.Insert();
                        v_us_gd_thu_nhap_khac.CommitTransaction();
                        v_id_gd_thu_nhap_khac = v_us_gd_thu_nhap_khac.dcID;
                        CHRM_BaseMessages.MsgBox_Infor(CONST_ID_MSGBOX.INFOR_LUU_DU_LIEU_THANH_CONG);
                        break;
                    case DataEntryFormMode.UpdateDataState:
                        v_us_gd_thu_nhap_khac.BeginTransaction();
                        v_us_gd_thu_nhap_khac.dcID = CIPConvert.ToDecimal(m_grv_quan_ly_thu_nhap_khac.GetRowCellValue(m_grv_quan_ly_thu_nhap_khac.FocusedRowHandle, "ID").ToString());
                        v_us_gd_thu_nhap_khac.Update();
                        v_us_gd_thu_nhap_khac.CommitTransaction();
                        CHRM_BaseMessages.MsgBox_Infor(CONST_ID_MSGBOX.INFOR_DU_LIEU_DA_DUOC_CAP_NHAT);
                        break;
                    default:
                        break;
                }
            }
            catch (Exception v_e)
            {
                throw v_e;
            }

        }

        //refresh form
        private void refresh_form()
        {
            m_sle_chon_nhan_vien.EditValue = null;
            m_sle_cach_tinh_thue.EditValue = null;
            m_sle_loai_thu_nhap.EditValue = null;
            m_txt_ly_do.Text = "";
            m_txt_so_tien.Text = "";
            m_txt_chon_thang.Text = DateTime.Now.Month.ToString();
            m_txt_chon_nam.Text = DateTime.Now.Year.ToString();
        }

        private void focus_new_row_created(decimal v_id_gd_thu_nhap_khac)
        {
            int v_row_index = 0;
            decimal v_id_gd_moi_lap = 0;

            US_GD_THU_NHAP_KHAC v_us = new US_GD_THU_NHAP_KHAC();
            DS_GD_THU_NHAP_KHAC v_ds = new DS_GD_THU_NHAP_KHAC();

            v_id_gd_moi_lap = v_id_gd_thu_nhap_khac;

            v_us.FillDataset(v_ds);

            for (v_row_index = 0; v_row_index < v_ds.Tables[0].Rows.Count; v_row_index++)
            {
                var v_id_gd_qd = CIPConvert.ToDecimal(m_grv_quan_ly_thu_nhap_khac.GetDataRow(v_row_index)["ID"].ToString());

                if (v_id_gd_qd == v_id_gd_moi_lap)
                {
                    break;
                }
            }

            m_grv_quan_ly_thu_nhap_khac.FocusedRowHandle = v_row_index;
        }
        #endregion
        private void set_define_events()
        {
            this.Load += f390_gd_thu_nhap_khac_Load;
            m_cmd_search.Click += m_cmd_search_Click;
            m_cmd_them_thu_nhap.Click += m_cmd_them_thu_nhap_Click;
            m_cmd_insert.Click += m_cmd_insert_Click;
            m_cmd_update.Click += m_cmd_update_Click;
            m_cmd_delete.Click += m_cmd_delete_Click;
            m_txt_so_tien.Leave += m_txt_so_tien_Leave;
            m_grv_quan_ly_thu_nhap_khac.DoubleClick += m_grv_quan_ly_thu_nhap_khac_DoubleClick;
            m_sle_chon_nhan_vien.EditValueChanged += m_sle_chon_nhan_vien_EditValueChanged;
        }

        void f390_gd_thu_nhap_khac_Load(object sender, EventArgs e)
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

        void m_sle_chon_nhan_vien_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                m_sle_cach_tinh_thue.EditValue = null;
                m_sle_loai_thu_nhap.EditValue = null;
                m_txt_ly_do.Text = "";
                m_txt_so_tien.Text = "";
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_search_Click(object sender, EventArgs e)
        {
            try
            {
                if (check_data_load_data_2_grid_is_ok())
                {
                    if (m_sle_chon_nhan_vien.EditValue == null || m_sle_chon_nhan_vien.EditValue.ToString() == "")
                    {
                        load_data_2_gridd(CIPConvert.ToDecimal(m_txt_chon_thang.Text.Trim()), CIPConvert.ToDecimal(m_txt_chon_nam.Text.Trim()));
                    }
                    else
                    {
                        load_data_2_grid(CIPConvert.ToDecimal(m_sle_chon_nhan_vien.EditValue), CIPConvert.ToDecimal(m_txt_chon_thang.Text.Trim()), CIPConvert.ToDecimal(m_txt_chon_nam.Text.Trim()));
                    }
                }

            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_them_thu_nhap_Click(object sender, EventArgs e)
        {
            try
            {
                decimal v_id_gd_thu_nhap_khac = 0;
                if (check_data_is_ok())
                {
                    save_data(ref v_id_gd_thu_nhap_khac);
                    load_data_2_grid(CIPConvert.ToDecimal(m_sle_chon_nhan_vien.EditValue), CIPConvert.ToDecimal(m_txt_chon_thang.Text.Trim()), CIPConvert.ToDecimal(m_txt_chon_nam.Text.Trim()));
                    focus_new_row_created(v_id_gd_thu_nhap_khac);
                }
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
                m_insert_is_click = 1;
                refresh_form();
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
                m_e_form_mode = DataEntryFormMode.UpdateDataState;
                if (m_grv_quan_ly_thu_nhap_khac.RowCount != 0)
                {
                    decimal v_id_gd_thu_nhap_khac = CIPConvert.ToDecimal(m_grv_quan_ly_thu_nhap_khac.GetRowCellValue(m_grv_quan_ly_thu_nhap_khac.FocusedRowHandle, "ID").ToString());
                    us_obj_2_form(v_id_gd_thu_nhap_khac);  
                }               
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (m_grv_quan_ly_thu_nhap_khac.RowCount != 0)
                {
                    decimal v_id_gd_thu_nhap_khac = CIPConvert.ToDecimal(m_grv_quan_ly_thu_nhap_khac.GetRowCellValue(m_grv_quan_ly_thu_nhap_khac.FocusedRowHandle, "ID").ToString());
                    US_GD_THU_NHAP_KHAC v_us_gd_thu_nhap_khac = new US_GD_THU_NHAP_KHAC(v_id_gd_thu_nhap_khac);
                    v_us_gd_thu_nhap_khac.Delete();
                } 
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_txt_so_tien_Leave(object sender, EventArgs e)
        {
            try
            {
                CHRMCommon.format_text_2_money(m_txt_so_tien);
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_grv_quan_ly_thu_nhap_khac_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                m_e_form_mode = DataEntryFormMode.UpdateDataState;
                decimal v_id_gd_thu_nhap_khac = CIPConvert.ToDecimal(m_grv_quan_ly_thu_nhap_khac.GetRowCellValue(m_grv_quan_ly_thu_nhap_khac.FocusedRowHandle, "ID").ToString());
                us_obj_2_form(v_id_gd_thu_nhap_khac);
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

    }
}
