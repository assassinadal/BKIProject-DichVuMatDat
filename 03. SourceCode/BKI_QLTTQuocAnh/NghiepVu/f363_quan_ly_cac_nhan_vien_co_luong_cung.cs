using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IP.Core.IPCommon;
using BKI_DichVuMatDat.DS;
using BKI_DichVuMatDat.US;
using BKI_DichVuMatDat.DS.CDBNames;
using DevExpress.XtraEditors;
using IP.Core.IPSystemAdmin;

namespace BKI_DichVuMatDat.NghiepVu
{
    public partial class f363_quan_ly_cac_nhan_vien_co_luong_cung : Form
    {
        public f363_quan_ly_cac_nhan_vien_co_luong_cung()
        {
            InitializeComponent();
            format_controls();
        }

        #region Public interface
        public void display()
        {
            this.ShowDialog();
        }
        #endregion

        #region Members
        DataEntryFormMode m_e_form_mode = DataEntryFormMode.InsertDataState;
        US_GD_LUONG_CUNG v_us = new US_GD_LUONG_CUNG();
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
            //m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.ID].Visible = false;
            //m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.HO_DEM].Visible = false;
            //m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.TEN].Visible = false;
            //m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.DAN_TOC].Visible = false;
            //m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.CHUYEN_MON].Visible = false;
            //m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.DIA_CHI_TAM_TRU].Visible = false;
            //m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.DIA_CHI_THUONG_TRU].Visible = false;
            //m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.MA_SO_THUE_CA_NHAN].Visible = false;
            //m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.NAM_TOT_NGHIEP].Visible = false;
            //m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.NGAN_HANG].Visible = false;
            //m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.NGAY_CAP].Visible = false;
            //m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.NGAY_CAP_THE].Visible = false;
            //m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.NGAY_CHINH_THUC_TIEP_NHAN].Visible = false;
            //m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.NGAY_HET_HAN_THE].Visible = false;
            //m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.NGAY_TIEP_NHAN_VAO_TCT].Visible = false;
            //m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.NGAY_VAO_HANG_KHONG].Visible = false;
            //m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.NOI_CAP].Visible = false;
            //m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.NOI_SINH].Visible = false;
            //m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.QUE_QUAN].Visible = false;
            //m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.QUOC_TICH].Visible = false;
            //m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.SO_CMT].Visible = false;
            //m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.SO_TAI_KHOAN].Visible = false;
            //m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.TON_GIAO].Visible = false;
            //m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.TOT_NGHIEP_TAI].Visible = false;
            //m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.TRINH_DO_VAN_HOA].Visible = false;
            //m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.NGAY_SINH].Visible = false;
            //m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.HON_NHAN].Visible = false;

            //m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.MA_NV].Width = 75;
            //m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.HO_TEN].Width = 120;

            //m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.MA_NV].Caption = "Mã NV";
            //m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.HO_TEN].Caption = "Họ tên";
            //m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.GIOI_TINH].Caption = "Giới tính";
            //m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.SDT].Caption = "SĐT";
            //m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.EMAIL].Caption = "Email";
            //m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.DIA_CHI_LIEN_LAC].Caption = "Địa chị liên lạc";

            m_sle_chon_nhan_vien.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            m_sle_chon_nhan_vien.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
        }

        private void load_data_2_grid()
        {
            CHRMCommon.make_stt(m_grv_luong_cung_cua_nhan_vien);
            //US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            //DataSet v_ds = new DataSet();
            //v_ds.Tables.Add(new DataTable());

            //v_us.FillDatasetWithQuery(v_ds, "SELECT * FROM V_GD_LUONG_CUNG WHERE DA_XOA = 'N' ORDER BY ID_NHAN_VIEN");
            //US_GD_LUONG_CUNG v_us = new US_GD_LUONG_CUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.LayDanhSach(v_ds);
            m_grc_luong_cung_cua_nhan_vien.DataSource = v_ds.Tables[0];
        }

        private void load_data_2_grid(decimal ip_dc_id_nv)
        {
            CHRMCommon.make_stt(m_grv_luong_cung_cua_nhan_vien);
            //US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            //DataSet v_ds = new DataSet();
            //v_ds.Tables.Add(new DataTable());

            //v_us.FillDatasetWithQuery(v_ds, "SELECT * FROM V_GD_LUONG_CUNG WHERE ID_NHAN_VIEN = " + ip_dc_id_nv + " AND DA_XOA = 'N'");

            US_GD_LUONG_CUNG v_us = new US_GD_LUONG_CUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());

            v_us.LayDanhSach(v_ds, ip_dc_id_nv);
            m_grc_luong_cung_cua_nhan_vien.DataSource = v_ds.Tables[0];
        }

        //private void load_luong_cung_nv_2_form(decimal ip_dc_id_nv)
        //{
        //    decimal v_id_gd_luong_cung = find_id_gd_luong_cung(ip_dc_id_nv);
        //    if (v_id_gd_luong_cung != -1)
        //    {
        //        US_GD_LUONG_CUNG v_us_lc = new US_GD_LUONG_CUNG(v_id_gd_luong_cung);
        //        m_txt_so_tien.Text = v_us_lc.dcSO_TIEN.ToString();
        //        CCommon.format_text_2_money(m_txt_so_tien);
        //        m_dat_ngay_bat_dau.Value = v_us_lc.datNGAY_BAT_DAU;
        //        m_dat_ngay_ket_thuc.Value = v_us_lc.datNGAY_KET_THUC;
        //        m_txt_ghi_chu.Text = v_us_lc.strGHI_CHU;
        //    }
        //    else
        //    {
        //        m_txt_so_tien.Text = "";
        //        m_dat_ngay_bat_dau.Value = DateTime.Now.Date;
        //        m_dat_ngay_ket_thuc.Value = DateTime.Now.Date;
        //        m_txt_ghi_chu.Text = "";
        //    }
        //}

        //check data is ok
        private bool check_data_is_ok()
        {
            if (m_sle_chon_nhan_vien.EditValue == null || m_sle_chon_nhan_vien.EditValue == "")
            {
                CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_CHUA_CHON_NHAN_VIEN);
                return false;
            }
            if (m_txt_so_tien.Text.Trim() == "")
            {
                CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_CHUA_NHAP_SO_TIEN);
                return false;
            }
            if (m_dat_ngay_ket_thuc.Value < m_dat_ngay_bat_dau.Value)
            {
                CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_NGAY_KET_THUC_NHO_HON_NGAY_BAT_DAU);
                return false;
            }

            if (CHRMCommon.thang_da_chot_bang_luong(m_dat_ngay_ket_thuc.Value))
            {
                CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_THANG_DA_CHOT_BANG_LUONG);
                return false;
            }
            return true;
        }

        //save data
        private void form_2_us_luong_cung(US_GD_LUONG_CUNG ip_us)
        {
            if (m_e_form_mode == DataEntryFormMode.UpdateDataState)
            {
                ip_us.dcID = CIPConvert.ToDecimal(m_grv_luong_cung_cua_nhan_vien.GetRowCellValue(m_grv_luong_cung_cua_nhan_vien.FocusedRowHandle, "ID"));
                ip_us.datNGAY_SUA = DateTime.Now.Date;
                //nguoi sua
                ip_us.strNGUOI_SUA = CAppContext_201.getCurrentUserName();
            }
            else
            {
                ip_us.datNGAY_LAP = DateTime.Now.Date;
                //nguoi lap
                ip_us.strDA_XOA = "N";
                ip_us.strNGUOI_LAP = CAppContext_201.getCurrentUserName();
            }
            ip_us.dcID_NHAN_VIEN = CIPConvert.ToDecimal(m_sle_chon_nhan_vien.EditValue);
            ip_us.dcSO_TIEN = CIPConvert.ToDecimal(m_txt_so_tien.Text.Trim());
            ip_us.datNGAY_BAT_DAU = m_dat_ngay_bat_dau.Value.Date;
            ip_us.datNGAY_KET_THUC = m_dat_ngay_ket_thuc.Value.Date;
            ip_us.strGHI_CHU = m_txt_ghi_chu.Text.Trim();
        }

        private void us_obj_2_form(US_GD_LUONG_CUNG ip_us)
        {
            m_sle_chon_nhan_vien.EditValue = ip_us.dcID_NHAN_VIEN;
            m_txt_so_tien.Text = ip_us.dcSO_TIEN.ToString();
            CHRMCommon.format_text_2_money(m_txt_so_tien);
            m_dat_ngay_bat_dau.Value = ip_us.datNGAY_BAT_DAU;
            m_dat_ngay_ket_thuc.Value = ip_us.datNGAY_KET_THUC;
            m_txt_ghi_chu.Text = ip_us.strGHI_CHU;
        }

        private void cho_gd_da_co_da_xoa_Y(decimal ip_dc_id_nhan_vien)
        {
            decimal v_id_gd_luong_cung = 0;
            v_id_gd_luong_cung = find_id_gd_luong_cung(ip_dc_id_nhan_vien);
            if (v_id_gd_luong_cung == -1)
            {
                return;
            }
            else
            {
                US_GD_LUONG_CUNG v_us = new US_GD_LUONG_CUNG(v_id_gd_luong_cung);
                try
                {
                    v_us.strDA_XOA = "Y";
                    v_us.BeginTransaction();
                    v_us.Update();
                    v_us.CommitTransaction();
                }
                catch (Exception v_e)
                {
                    throw v_e;
                }
            }

        }

        private decimal find_id_gd_luong_cung(decimal ip_dc_id_nhan_vien)
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            throw new Exception("Sua lai khong dung FillDataSetWithTableName nua nhe");
            // v_us.FillDatasetWithTableName(v_ds, "GD_LUONG_CUNG");

            string v_str_filter = "ID_NHAN_VIEN = " + ip_dc_id_nhan_vien + " AND DA_XOA = 'N'";
            DataRow[] v_dr = v_ds.Tables[0].Select(v_str_filter);

            if (v_dr.Count() == 0)
            {
                return -1;
            }
            else
            {
                return CIPConvert.ToDecimal(v_dr.First()["ID"].ToString());
            }
        }

        private void save_data()
        {

            try
            {
                switch (m_e_form_mode)
                {
                    case DataEntryFormMode.InsertDataState:
                        US_GD_LUONG_CUNG v_us_gd_luong_cung = new US_GD_LUONG_CUNG();
                        form_2_us_luong_cung(v_us_gd_luong_cung);
                        cho_gd_da_co_da_xoa_Y(CIPConvert.ToDecimal(m_sle_chon_nhan_vien.EditValue));
                        v_us_gd_luong_cung.BeginTransaction();
                        v_us_gd_luong_cung.Insert();
                        v_us_gd_luong_cung.CommitTransaction();
                        CHRM_BaseMessages.MsgBox_Infor(CONST_ID_MSGBOX.INFOR_LUU_DU_LIEU_THANH_CONG);
                        break;
                    case DataEntryFormMode.UpdateDataState:
                        decimal v_id_gd_lc = find_id_gd_luong_cung(CIPConvert.ToDecimal(m_sle_chon_nhan_vien.EditValue));
                        US_GD_LUONG_CUNG v_us = new US_GD_LUONG_CUNG(v_id_gd_lc);
                        form_2_us_luong_cung(v_us);
                        v_us.BeginTransaction();
                        v_us.Update();
                        v_us.CommitTransaction();
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
            decimal v_id_gd_luong_cung = find_id_gd_luong_cung(v_id_nv);
            if (v_id_gd_luong_cung != -1)
            {
                US_GD_LUONG_CUNG v_us = new US_GD_LUONG_CUNG(v_id_gd_luong_cung);
                m_e_form_mode = DataEntryFormMode.UpdateDataState;
                us_obj_2_form(v_us);
            }
            else
            {
                CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_NHAN_VIEN_CHUA_CO_GIA_TRI_LUONG_CUNG);
                m_sle_chon_nhan_vien.EditValue = v_id_nv;
                return;
            }
        }
        //focus new row after created
        private void focus_new_row_created()
        {
            int v_row_index = 0;
            decimal v_id_nv_f363 = 0;
            string v_da_xoa_f363 = "N";

            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());

            throw new Exception("Sua lai khong dung FillDataSetWithTableName nua nhe");
            //v_us.FillDatasetWithTableName(v_ds, "V_GD_LUONG_CUNG");

            v_id_nv_f363 = CIPConvert.ToDecimal(m_sle_chon_nhan_vien.EditValue);

            for (v_row_index = 0; v_row_index < v_ds.Tables[0].Rows.Count; v_row_index++)
            {
                decimal v_id_nv = CIPConvert.ToDecimal(m_grv_luong_cung_cua_nhan_vien.GetDataRow(v_row_index)["ID_NHAN_VIEN"].ToString());
                string v_da_xoa = m_grv_luong_cung_cua_nhan_vien.GetDataRow(v_row_index)["DA_XOA"].ToString();

                if (v_id_nv == v_id_nv_f363 && v_da_xoa == v_da_xoa_f363)
                {
                    break;
                }
            }

            m_grv_luong_cung_cua_nhan_vien.FocusedRowHandle = v_row_index;
        }

        //refesh form
        private void refresh_form()
        {
            m_sle_chon_nhan_vien.EditValue = null;
            m_txt_so_tien.Text = "";
            m_dat_ngay_bat_dau.Value = DateTime.Now.Date;
            m_dat_ngay_ket_thuc.Value = DateTime.Now.Date;
            m_txt_ghi_chu.Text = "";
        }

        #endregion
        private void set_define_events()
        {
            this.Load += f363_quan_ly_cac_nhan_vien_co_luong_cung_Load;
            m_sle_chon_nhan_vien.EditValueChanged += m_sle_chon_nhan_vien_EditValueChanged;
            m_cmd_update.Click += m_cmd_update_Click;
            m_cmd_luu_tien_luong.Click += m_cmd_luu_tien_luong_Click;
            m_cmd_insert.Click += m_cmd_insert_Click;
            m_txt_so_tien.Leave += m_txt_so_tien_Leave;
            m_cmd_delete.Click += m_cmd_delete_Click;
            m_cmd_xuat_excel.Click += m_cmd_xuat_excel_Click;
            //m_grv_luong_cung_cua_nhan_vien.DoubleClick += m_grv_luong_cung_cua_nhan_vien_DoubleClick;
        }

        void f363_quan_ly_cac_nhan_vien_co_luong_cung_Load(object sender, EventArgs e)
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

        void m_cmd_luu_tien_luong_Click(object sender, EventArgs e)
        {
            try
            {
                if (check_data_is_ok())
                {
                    if (CHRM_BaseMessages.MsgBox_Confirm("Bạn có chắc chắn muốn nhập mức lương " + String.Format("{0:#,##0}", m_txt_so_tien.Text).ToString() + " VNĐ cho nhân viên này?") == true)
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

        void m_cmd_update_Click(object sender, EventArgs e)
        {
            try
            {
                f364_quan_ly_cac_nhan_vien_co_luong_cung_de frm = new f364_quan_ly_cac_nhan_vien_co_luong_cung_de();
                frm.display_4_update(v_us);
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
                f364_quan_ly_cac_nhan_vien_co_luong_cung_de frm = new f364_quan_ly_cac_nhan_vien_co_luong_cung_de();
                frm.display_4_insert();
                //m_e_form_mode = DataEntryFormMode.InsertDataState;
                //refresh_form();
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

        void m_sle_chon_nhan_vien_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                m_txt_so_tien.Text = "";
                if (m_sle_chon_nhan_vien.EditValue == null || m_sle_chon_nhan_vien.EditValue == "")
                {
                    //load_data_2_grid();
                    return;
                }
                else
                {
                    load_data_2_grid(CIPConvert.ToDecimal(m_sle_chon_nhan_vien.EditValue));
                    //load_luong_cung_nv_2_form(CIPConvert.ToDecimal(m_sle_chon_nhan_vien.EditValue));
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
                //Lay ID cua dong du lieu muon xoa
                DataRow v_dr = m_grv_luong_cung_cua_nhan_vien.GetDataRow(m_grv_luong_cung_cua_nhan_vien.FocusedRowHandle);
                //Lay ID cua dong du lieu tren
                decimal v_id = CIPConvert.ToDecimal(v_dr[GD_LUONG_CUNG.ID]);           
                if (CHRM_BaseMessages.MsgBox_Confirm(CONST_ID_MSGBOX.QUESTION_XAC_NHAN_XOA_DU_LIEU) == true)
                {
                    US_GD_LUONG_CUNG v_us = new US_GD_LUONG_CUNG(v_id);
                    v_us.strDA_XOA = "Y";
                    v_us.BeginTransaction();
                    v_us.Update();
                    v_us.CommitTransaction();
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
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

    }
}
