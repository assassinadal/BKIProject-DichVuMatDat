using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BKI_DichVuMatDat;
using BKI_DichVuMatDat.DS;
using BKI_DichVuMatDat.US;
using IP.Core.IPCommon;
using BKI_DichVuMatDat.DS.CDBNames;
using DevExpress.XtraEditors;
using System.Globalization;
using IP.Core.IPSystemAdmin;

namespace BKI_DichVuMatDat.NghiepVu
{
    public partial class f342_dat_he_so_lns_lcd_de : Form
    {
        #region Public Interface
        public f342_dat_he_so_lns_lcd_de()
        {
            InitializeComponent();
            format_controls();
        }
        private void display()
        {
            this.ShowDialog();
        }
        public void display_4_insert()
        {
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            this.Text = "F342 - Đặt hệ số lương năng suất, lương chế độ cho nhân viên";
            m_lbl_header.Text = "ĐẶT HỆ SỐ LƯƠNG NĂNG SUẤT, LƯƠNG CHẾ ĐÔ";
            clear_data_in_form();
            this.CenterToScreen();
            this.ShowDialog();
        }
        public void display_4_insert(decimal id_nv)
        {
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            this.Text = "F342 - Đặt hệ số lương năng suất, lương chế độ cho nhân viên";
            m_lbl_header.Text = "ĐẶT HỆ SỐ LƯƠNG NĂNG SUẤT, LƯƠNG CHẾ ĐÔ";
            m_sle_chon_nhan_vien.EditValue = id_nv;
            this.CenterToScreen();
            this.ShowDialog();
        }
        public void display_4_update(decimal mid_nv)
        {
            this.Text = "F342 - Sửa hệ số lương năng suất, lương chế độ";
            m_lbl_header.Text = "SỬA HỆ SỐ LƯƠNG NĂNG SUẤT";
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            m_sle_chon_nhan_vien.EditValue = mid_nv;
            this.CenterToScreen();
            this.ShowDialog();
        }
        #endregion

        #region Members
        DataEntryFormMode m_e_form_mode = new DataEntryFormMode();
        public decimal id_nv_hien_tai = 0;
        decimal m_insert_click = 0;
        decimal m_id_gd_hd = 0;
        decimal m_id_loai_hop_dong = 0;
        decimal m_id_gd_hs_lns_lcd_hien_tai = 0;

        decimal m_id_ma_hs_lns_hien_tai = 0;
        decimal m_id_muc_hs_lns_hien_tai = 0;
        decimal m_id_ma_lcd_hien_tai = 0;
        decimal m_id_muc_lcd_hien_tai = 0;

        decimal m_id_gd_hs_lns_hien_tai = 0;
        decimal m_id_gd_lcd_hien_tai = 0;

        US_GD_HE_SO_LNS v_us_hs_lns = new US_GD_HE_SO_LNS();
        US_GD_LUONG_CHE_DO v_us_lcd = new US_GD_LUONG_CHE_DO();

        #endregion

        #region Private methods

        private void format_controls()
        {
            FormatControl.SetVisibleSimpleButton(this);
            set_define_events();
            this.KeyPreview = true;
        }

        private void set_initial_form_load()
        {
            load_data_2_sle_chon_nv();
            load_data_2_sle_chuc_danh_lns();
            load_data_2_sle_muc_lns();
            load_data_2_sle_chon_ly_do_chinh_sua_hs_lns();
            load_data_2_sle_chuc_danh_lcd();
            load_data_2_sle_muc_lcd();
            load_data_2_sle_chon_ly_do_chinh_sua_so_tien_lcd();
        }

        //load data 2 all control
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
            m_sle_chon_nhan_vien.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            m_sle_chon_nhan_vien.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
        }

        private DS_CM_DM_TU_DIEN load_data_2_cm_dm_tu_dien(int m_id_loai_td)
        {
            DS_CM_DM_TU_DIEN v_ds = new DS_CM_DM_TU_DIEN();
            US_CM_DM_TU_DIEN v_us = new US_CM_DM_TU_DIEN();
            v_us.FillDatasetByIdLoaiTuDien(v_ds, m_id_loai_td);
            return v_ds;
        }

        private void load_data_2_sle_chuc_danh_lns()
        {
            m_sle_chuc_danh_lns.Properties.DataSource = load_data_2_cm_dm_tu_dien(CONST_ID_LOAI_TU_DIEN.MA_HS_LNS).CM_DM_TU_DIEN;
            m_sle_chuc_danh_lns.Properties.ValueMember = CM_DM_TU_DIEN.ID;
            m_sle_chuc_danh_lns.Properties.DisplayMember = CM_DM_TU_DIEN.TEN;

            m_sle_chuc_danh_lns.Properties.PopulateViewColumns();
            m_sle_chuc_danh_lns.Properties.View.Columns[CM_DM_TU_DIEN.ID].Visible = false;
            m_sle_chuc_danh_lns.Properties.View.Columns[CM_DM_TU_DIEN.ID_LOAI_TU_DIEN].Visible = false;
            m_sle_chuc_danh_lns.Properties.View.Columns[CM_DM_TU_DIEN.TEN_NGAN].Visible = false;

            m_sle_chuc_danh_lns.Properties.View.Columns[CM_DM_TU_DIEN.MA_TU_DIEN].Width = 75;
            m_sle_chuc_danh_lns.Properties.View.Columns[CM_DM_TU_DIEN.TEN].Width = 120;

            m_sle_chuc_danh_lns.Properties.View.Columns[CM_DM_TU_DIEN.MA_TU_DIEN].Caption = "Mã chức danh";
            m_sle_chuc_danh_lns.Properties.View.Columns[CM_DM_TU_DIEN.TEN].Caption = "Chức danh";
            m_sle_chuc_danh_lns.Properties.View.Columns[CM_DM_TU_DIEN.GHI_CHU].Caption = "Ghi chú";

            m_sle_chuc_danh_lns.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            m_sle_chuc_danh_lns.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
        }

        private void load_data_2_sle_muc_lns()
        {
            m_sle_muc_lns.Properties.DataSource = load_data_2_cm_dm_tu_dien(CONST_ID_LOAI_TU_DIEN.MUC_HS_LNS).CM_DM_TU_DIEN;
            m_sle_muc_lns.Properties.ValueMember = CM_DM_TU_DIEN.ID;
            m_sle_muc_lns.Properties.DisplayMember = CM_DM_TU_DIEN.TEN;

            m_sle_muc_lns.Properties.PopulateViewColumns();
            m_sle_muc_lns.Properties.View.Columns[CM_DM_TU_DIEN.ID].Visible = false;
            m_sle_muc_lns.Properties.View.Columns[CM_DM_TU_DIEN.ID_LOAI_TU_DIEN].Visible = false;
            m_sle_muc_lns.Properties.View.Columns[CM_DM_TU_DIEN.TEN_NGAN].Visible = false;

            m_sle_muc_lns.Properties.View.Columns[CM_DM_TU_DIEN.MA_TU_DIEN].Width = 75;
            m_sle_muc_lns.Properties.View.Columns[CM_DM_TU_DIEN.TEN].Width = 120;

            m_sle_muc_lns.Properties.View.Columns[CM_DM_TU_DIEN.MA_TU_DIEN].Caption = "Mã mức";
            m_sle_muc_lns.Properties.View.Columns[CM_DM_TU_DIEN.TEN].Caption = "Tên mức";
            m_sle_muc_lns.Properties.View.Columns[CM_DM_TU_DIEN.GHI_CHU].Caption = "Ghi chú";

            m_sle_muc_lns.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            m_sle_muc_lns.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
        }

        private void load_data_2_sle_chon_ly_do_chinh_sua_hs_lns()
        {
            m_sle_chon_ly_do_chinh_sua_hs_lns.Properties.DataSource = load_data_2_cm_dm_tu_dien(CONST_ID_LOAI_TU_DIEN.LY_DO_CHINH_SUA_HS_LNS).CM_DM_TU_DIEN;
            m_sle_chon_ly_do_chinh_sua_hs_lns.Properties.ValueMember = CM_DM_TU_DIEN.ID;
            m_sle_chon_ly_do_chinh_sua_hs_lns.Properties.DisplayMember = CM_DM_TU_DIEN.TEN;

            m_sle_chon_ly_do_chinh_sua_hs_lns.Properties.PopulateViewColumns();
            m_sle_chon_ly_do_chinh_sua_hs_lns.Properties.View.Columns[CM_DM_TU_DIEN.ID].Visible = false;
            m_sle_chon_ly_do_chinh_sua_hs_lns.Properties.View.Columns[CM_DM_TU_DIEN.ID_LOAI_TU_DIEN].Visible = false;
            m_sle_chon_ly_do_chinh_sua_hs_lns.Properties.View.Columns[CM_DM_TU_DIEN.TEN_NGAN].Visible = false;

            m_sle_chon_ly_do_chinh_sua_hs_lns.Properties.View.Columns[CM_DM_TU_DIEN.MA_TU_DIEN].Width = 75;
            m_sle_chon_ly_do_chinh_sua_hs_lns.Properties.View.Columns[CM_DM_TU_DIEN.TEN].Width = 120;

            m_sle_chon_ly_do_chinh_sua_hs_lns.Properties.View.Columns[CM_DM_TU_DIEN.MA_TU_DIEN].Caption = "Mã lý do";
            m_sle_chon_ly_do_chinh_sua_hs_lns.Properties.View.Columns[CM_DM_TU_DIEN.TEN].Caption = "Lý do";
            m_sle_chon_ly_do_chinh_sua_hs_lns.Properties.View.Columns[CM_DM_TU_DIEN.GHI_CHU].Caption = "Ghi chú";

            m_sle_chon_ly_do_chinh_sua_hs_lns.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            m_sle_chon_ly_do_chinh_sua_hs_lns.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
        }

        private void load_data_2_sle_chuc_danh_lcd()
        {
            m_sle_chuc_danh_lcd.Properties.DataSource = load_data_2_cm_dm_tu_dien(CONST_ID_LOAI_TU_DIEN.MA_LCD).CM_DM_TU_DIEN;
            m_sle_chuc_danh_lcd.Properties.ValueMember = CM_DM_TU_DIEN.ID;
            m_sle_chuc_danh_lcd.Properties.DisplayMember = CM_DM_TU_DIEN.TEN;

            m_sle_chuc_danh_lcd.Properties.PopulateViewColumns();
            m_sle_chuc_danh_lcd.Properties.View.Columns[CM_DM_TU_DIEN.ID].Visible = false;
            m_sle_chuc_danh_lcd.Properties.View.Columns[CM_DM_TU_DIEN.ID_LOAI_TU_DIEN].Visible = false;
            m_sle_chuc_danh_lcd.Properties.View.Columns[CM_DM_TU_DIEN.TEN_NGAN].Visible = false;

            m_sle_chuc_danh_lcd.Properties.View.Columns[CM_DM_TU_DIEN.MA_TU_DIEN].Width = 75;
            m_sle_chuc_danh_lcd.Properties.View.Columns[CM_DM_TU_DIEN.TEN].Width = 120;

            m_sle_chuc_danh_lcd.Properties.View.Columns[CM_DM_TU_DIEN.MA_TU_DIEN].Caption = "Mã chức danh";
            m_sle_chuc_danh_lcd.Properties.View.Columns[CM_DM_TU_DIEN.TEN].Caption = "Chức danh";
            m_sle_chuc_danh_lcd.Properties.View.Columns[CM_DM_TU_DIEN.GHI_CHU].Caption = "Ghi chú";

            m_sle_chuc_danh_lcd.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            m_sle_chuc_danh_lcd.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
        }

        private void load_data_2_sle_muc_lcd()
        {
            m_sle_muc_lcd.Properties.DataSource = load_data_2_cm_dm_tu_dien(CONST_ID_LOAI_TU_DIEN.MUC_LCD).CM_DM_TU_DIEN;
            m_sle_muc_lcd.Properties.ValueMember = CM_DM_TU_DIEN.ID;
            m_sle_muc_lcd.Properties.DisplayMember = CM_DM_TU_DIEN.TEN;

            m_sle_muc_lcd.Properties.PopulateViewColumns();
            m_sle_muc_lcd.Properties.View.Columns[CM_DM_TU_DIEN.ID].Visible = false;
            m_sle_muc_lcd.Properties.View.Columns[CM_DM_TU_DIEN.ID_LOAI_TU_DIEN].Visible = false;
            m_sle_muc_lcd.Properties.View.Columns[CM_DM_TU_DIEN.TEN_NGAN].Visible = false;

            m_sle_muc_lcd.Properties.View.Columns[CM_DM_TU_DIEN.MA_TU_DIEN].Width = 75;
            m_sle_muc_lcd.Properties.View.Columns[CM_DM_TU_DIEN.TEN].Width = 120;

            m_sle_muc_lcd.Properties.View.Columns[CM_DM_TU_DIEN.MA_TU_DIEN].Caption = "Mã mức";
            m_sle_muc_lcd.Properties.View.Columns[CM_DM_TU_DIEN.TEN].Caption = "Tên mức";
            m_sle_muc_lcd.Properties.View.Columns[CM_DM_TU_DIEN.GHI_CHU].Caption = "Ghi chú";

            m_sle_muc_lcd.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            m_sle_muc_lcd.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
        }

        private void load_data_2_sle_chon_ly_do_chinh_sua_so_tien_lcd()
        {
            m_sle_chon_ly_do_chinh_sua_so_tien_lcd.Properties.DataSource = load_data_2_cm_dm_tu_dien(CONST_ID_LOAI_TU_DIEN.LY_DO_CHINH_SUA_SO_TIEN_LCD).CM_DM_TU_DIEN;
            m_sle_chon_ly_do_chinh_sua_so_tien_lcd.Properties.ValueMember = CM_DM_TU_DIEN.ID;
            m_sle_chon_ly_do_chinh_sua_so_tien_lcd.Properties.DisplayMember = CM_DM_TU_DIEN.TEN;

            m_sle_chon_ly_do_chinh_sua_so_tien_lcd.Properties.PopulateViewColumns();
            m_sle_chon_ly_do_chinh_sua_so_tien_lcd.Properties.View.Columns[CM_DM_TU_DIEN.ID].Visible = false;
            m_sle_chon_ly_do_chinh_sua_so_tien_lcd.Properties.View.Columns[CM_DM_TU_DIEN.ID_LOAI_TU_DIEN].Visible = false;
            m_sle_chon_ly_do_chinh_sua_so_tien_lcd.Properties.View.Columns[CM_DM_TU_DIEN.TEN_NGAN].Visible = false;

            m_sle_chon_ly_do_chinh_sua_so_tien_lcd.Properties.View.Columns[CM_DM_TU_DIEN.MA_TU_DIEN].Width = 75;
            m_sle_chon_ly_do_chinh_sua_so_tien_lcd.Properties.View.Columns[CM_DM_TU_DIEN.TEN].Width = 120;

            m_sle_chon_ly_do_chinh_sua_so_tien_lcd.Properties.View.Columns[CM_DM_TU_DIEN.MA_TU_DIEN].Caption = "Mã lý do";
            m_sle_chon_ly_do_chinh_sua_so_tien_lcd.Properties.View.Columns[CM_DM_TU_DIEN.TEN].Caption = "Lý do";
            m_sle_chon_ly_do_chinh_sua_so_tien_lcd.Properties.View.Columns[CM_DM_TU_DIEN.GHI_CHU].Caption = "Ghi chú";

            m_sle_chon_ly_do_chinh_sua_so_tien_lcd.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            m_sle_chon_ly_do_chinh_sua_so_tien_lcd.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
        }

        private decimal find_hs_lns(decimal ip_dc_id_ma_lns, decimal ip_dc_id_muc_lns)
        {
            try
            {
                US_DM_HE_SO_LUONG_NS v_us = new US_DM_HE_SO_LUONG_NS();
                DS_DM_HE_SO_LUONG_NS v_ds = new DS_DM_HE_SO_LUONG_NS();
                v_us.FillDataset(v_ds);
                string v_str_filter = "ID_MA_LNS = " + ip_dc_id_ma_lns + " AND ID_MUC_LNS = " + ip_dc_id_muc_lns;
                DataRow[] v_dr = v_ds.DM_HE_SO_LUONG_NS.Select(v_str_filter);

                if (v_dr.Count() == 0)
                {
                    return 0;
                }
                else
                {
                    return CIPConvert.ToDecimal(v_dr.First()["HE_SO"].ToString());
                }
            }
            catch (Exception v_e)
            {
                throw v_e;
            }
        }

        private decimal find_so_tien_lcd(decimal ip_dc_id_ma_lcd, decimal ip_dc_id_muc_lcd)
        {
            try
            {
                US_DM_LUONG_CHE_DO v_us = new US_DM_LUONG_CHE_DO();
                DS_DM_LUONG_CHE_DO v_ds = new DS_DM_LUONG_CHE_DO();

                v_us.FillDataset(v_ds);

                string v_str_filter = "ID_MA_LCD = " + ip_dc_id_ma_lcd + " AND ID_MUC_LCD = " + ip_dc_id_muc_lcd;
                DataRow[] v_dr = v_ds.DM_LUONG_CHE_DO.Select(v_str_filter);

                if (v_dr.Count() == 0)
                {
                    return 0;
                }
                else
                {
                    return CIPConvert.ToDecimal(v_dr.First()["SO_TIEN"].ToString());
                }
            }
            catch (Exception v_e)
            {
                throw v_e;
            }
        }

        //check validate data

        private bool check_data_hs_lns_is_ok()
        {
            if (m_sle_muc_lns.EditValue == null || m_sle_muc_lns.EditValue == "")
            {
                CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_CHUA_CHON_MUC_LNS);
                return false;
            }

            if (m_sle_chon_ly_do_chinh_sua_hs_lns.EditValue.ToString() == "0")
            {
                CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_CHUA_CHON_LY_DO_THAY_DOI_LNS);
                return false;
            }

            if (m_sle_chuc_danh_lns.EditValue == null || m_sle_chuc_danh_lns.EditValue == "")
            {
                CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_CHUA_CHON_CHUC_DANH_DE_TINH_LNS);
                return false;
            }

            if (m_dat_ngay_bat_dau_lns.Value.Date == m_dat_ngay_ket_thuc_lns.Value.Date)
            {
                CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_NGAY_KET_THUC_NHO_HON_NGAY_BAT_DAU);
                return false;
            }

            if (CHRMCommon.thang_da_chot_bang_luong(m_dat_ngay_ket_thuc_lns.Value))
            {
                CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_THANG_DA_CHOT_BANG_LUONG);
                return false;
            }

            return true;
        }

        private bool check_data_lcd_is_ok()
        {
            if (m_sle_muc_lcd.EditValue == null || m_sle_muc_lcd.EditValue == "")
            {
                CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_CHUA_CHON_MUC_LCD);
                return false;
            }

            if (m_sle_chuc_danh_lcd.EditValue == null || m_sle_chuc_danh_lcd.EditValue == "")
            {
                CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_CHUA_CHON_CHUC_DANH_DE_TINH_LCD);
                return false;
            }
            //ly do chinh sua so tien lcd
            if (m_sle_chon_ly_do_chinh_sua_so_tien_lcd.EditValue.ToString() == "0")
            {
                CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_CHUA_CHON_LY_DO_THAY_DOI_LCD);
                return false;
            }

            if (CHRMCommon.thang_da_chot_bang_luong(m_dat_ngay_ket_thuc_lcd.Value))
            {
                CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_THANG_DA_CHOT_BANG_LUONG);
                return false;
            }
            return true;
        }

        //Insert, update, delete
        private decimal find_id_hd(decimal ip_dc_id_nv)
        {
            US_GD_HOP_DONG v_us = new US_GD_HOP_DONG();
            DS_GD_HOP_DONG v_ds = new DS_GD_HOP_DONG();

            v_us.FillDataset(v_ds);

            string v_str_filter = "ID_NHAN_VIEN = " + ip_dc_id_nv + " AND DA_XOA = 'N'";
            DataRow[] v_dr = v_ds.GD_HOP_DONG.Select(v_str_filter);

            if (v_dr.Count() == 0)
            {
                return -1;
            }
            else
            {
                return CIPConvert.ToDecimal(v_dr.First()["ID"].ToString());
            }
        }

        private decimal find_id_loai_hop_dong_cua_nhan_vien(decimal ip_dc_id_gd_hd)
        {
            US_GD_HOP_DONG v_us = new US_GD_HOP_DONG();
            DS_GD_HOP_DONG v_ds = new DS_GD_HOP_DONG();

            v_us.FillDataset(v_ds);

            string v_str_filter = "ID = " + ip_dc_id_gd_hd + " AND DA_XOA = 'N'";
            DataRow[] v_dr = v_ds.GD_HOP_DONG.Select(v_str_filter);

            if (v_dr.Count() == 0)
            {
                return -1;
            }
            else
            {
                return CIPConvert.ToDecimal(v_dr.First()["ID_LOAI_HOP_DONG"].ToString());
            }
        }

        private decimal find_id_gd_hs_lns_lcd_hien_tai(decimal ip_dc_id_gd_hd)
        {
            US_GD_HS_LNS_LCD v_us = new US_GD_HS_LNS_LCD();
            DS_GD_HS_LNS_LCD v_ds = new DS_GD_HS_LNS_LCD();

            v_us.FillDataset(v_ds);

            string v_str_filter = "ID_HOP_DONG = " + ip_dc_id_gd_hd + " AND DA_XOA = 'N'";
            DataRow[] v_dr = v_ds.GD_HS_LNS_LCD.Select(v_str_filter);

            if (v_dr.Count() == 0)
            {
                return -1;
            }
            else
            {
                return CIPConvert.ToDecimal(v_dr.First()["ID"].ToString());
            }
        }

        private decimal find_id_ma_hs_lns_hien_tai(decimal m_id_gd_hs_lns_lcd_hien_tai)
        {
            US_GD_HS_LNS_LCD v_us_gd_hs_lns_lcd = new US_GD_HS_LNS_LCD(m_id_gd_hs_lns_lcd_hien_tai);
            US_DM_HE_SO_LUONG_NS v_us_dm_hs_lns = new US_DM_HE_SO_LUONG_NS(v_us_gd_hs_lns_lcd.dcID_HS_LNS);
            return CIPConvert.ToDecimal(v_us_dm_hs_lns.dcID_MA_LNS);
        }

        private decimal find_id_muc_hs_lns_hien_tai(decimal m_id_gd_hs_lns_lcd_hien_tai)
        {
            US_GD_HS_LNS_LCD v_us_gd_hs_lns_lcd = new US_GD_HS_LNS_LCD(m_id_gd_hs_lns_lcd_hien_tai);
            US_DM_HE_SO_LUONG_NS v_us_dm_hs_lns = new US_DM_HE_SO_LUONG_NS(v_us_gd_hs_lns_lcd.dcID_HS_LNS);

            return CIPConvert.ToDecimal(v_us_dm_hs_lns.dcID_MUC_LNS);

        }

        private decimal find_id_ma_lcd_hien_tai(decimal m_id_gd_hs_lns_lcd_hien_tai)
        {
            US_GD_HS_LNS_LCD v_us_gd_hs_lns_lcd = new US_GD_HS_LNS_LCD(m_id_gd_hs_lns_lcd_hien_tai);
            US_DM_LUONG_CHE_DO v_us_dm_lcd = new US_DM_LUONG_CHE_DO(v_us_gd_hs_lns_lcd.dcID_LCD);

            return CIPConvert.ToDecimal(v_us_dm_lcd.dcID_MA_LCD);
        }

        private decimal find_id_muc_lcd_hien_tai(decimal m_id_gd_hs_lns_lcd_hien_tai)
        {
            US_GD_HS_LNS_LCD v_us_gd_hs_lns_lcd = new US_GD_HS_LNS_LCD(m_id_gd_hs_lns_lcd_hien_tai);
            US_DM_LUONG_CHE_DO v_us_dm_lcd = new US_DM_LUONG_CHE_DO(v_us_gd_hs_lns_lcd.dcID_LCD);

            return CIPConvert.ToDecimal(v_us_dm_lcd.dcID_MUC_LCD);
        }

        private decimal find_id_gd_hs_lns_hien_tai(decimal ip_dc_id_gd_hd)
        {
            US_GD_HE_SO_LNS v_us = new US_GD_HE_SO_LNS();
            DS_GD_HE_SO_LNS v_ds = new DS_GD_HE_SO_LNS();

            v_us.FillDataset(v_ds);

            string v_str_filter = "ID_HOP_DONG = " + ip_dc_id_gd_hd + " AND DA_XOA = 'N'";
            DataRow[] v_dr = v_ds.GD_HE_SO_LNS.Select(v_str_filter);

            if (v_dr.Count() == 0)
            {
                return -1;
            }
            else
            {
                return CIPConvert.ToDecimal(v_dr.First()["ID"].ToString());
            }
        }

        private decimal find_id_gd_lcd_hien_tai(decimal ip_dc_id_gd_hd)
        {
            US_GD_LUONG_CHE_DO v_us = new US_GD_LUONG_CHE_DO();
            DS_GD_LUONG_CHE_DO v_ds = new DS_GD_LUONG_CHE_DO();

            v_us.FillDataset(v_ds);

            string v_str_filter = "ID_HOP_DONG = " + ip_dc_id_gd_hd + " AND DA_XOA = 'N'";
            DataRow[] v_dr = v_ds.GD_LUONG_CHE_DO.Select(v_str_filter);

            if (v_dr.Count() == 0)
            {
                return -1;
            }
            else
            {
                return CIPConvert.ToDecimal(v_dr.First()["ID"].ToString());
            }
        }

        private decimal find_id_ma_lns(decimal ip_dc_id_hs_lns)
        {
            US_DM_HE_SO_LUONG_NS v_us = new US_DM_HE_SO_LUONG_NS();
            DS_DM_HE_SO_LUONG_NS v_ds = new DS_DM_HE_SO_LUONG_NS();

            v_us.FillDataset(v_ds);

            string v_str_filter = "ID = " + ip_dc_id_hs_lns;
            DataRow[] v_dr = v_ds.DM_HE_SO_LUONG_NS.Select(v_str_filter);

            if (v_dr.Count() == 0)
            {
                return -1;
            }
            else
            {
                return CIPConvert.ToDecimal(v_dr.First()["ID_MA_LNS"].ToString());
            }
        }

        private decimal find_id_muc_lns(decimal ip_dc_id_hs_lns)
        {
            US_DM_HE_SO_LUONG_NS v_us = new US_DM_HE_SO_LUONG_NS();
            DS_DM_HE_SO_LUONG_NS v_ds = new DS_DM_HE_SO_LUONG_NS();

            v_us.FillDataset(v_ds);

            string v_str_filter = "ID = " + ip_dc_id_hs_lns;
            DataRow[] v_dr = v_ds.DM_HE_SO_LUONG_NS.Select(v_str_filter);

            if (v_dr.Count() == 0)
            {
                return -1;
            }
            else
            {
                return CIPConvert.ToDecimal(v_dr.First()["ID_MUC_LNS"].ToString());
            }
        }

        private decimal find_id_ma_lcd(decimal ip_dc_id_lcd)
        {
            US_DM_LUONG_CHE_DO v_us = new US_DM_LUONG_CHE_DO();
            DS_DM_LUONG_CHE_DO v_ds = new DS_DM_LUONG_CHE_DO();

            v_us.FillDataset(v_ds);

            string v_str_filter = "ID = " + ip_dc_id_lcd;
            DataRow[] v_dr = v_ds.DM_LUONG_CHE_DO.Select(v_str_filter);

            if (v_dr.Count() == 0)
            {
                return -1;
            }
            else
            {
                return CIPConvert.ToDecimal(v_dr.First()["ID_MA_LCD"].ToString());
            }
        }

        private decimal find_id_muc_lcd(decimal ip_dc_id_lcd)
        {
            US_DM_LUONG_CHE_DO v_us = new US_DM_LUONG_CHE_DO();
            DS_DM_LUONG_CHE_DO v_ds = new DS_DM_LUONG_CHE_DO();

            v_us.FillDataset(v_ds);

            string v_str_filter = "ID = " + ip_dc_id_lcd;
            DataRow[] v_dr = v_ds.DM_LUONG_CHE_DO.Select(v_str_filter);

            if (v_dr.Count() == 0)
            {
                return -1;
            }
            else
            {
                return CIPConvert.ToDecimal(v_dr.First()["ID_MUC_LCD"].ToString());
            }
        }

        private void load_data_2_m_variable()
        {
            m_id_gd_hd = find_id_hd(CIPConvert.ToDecimal(m_sle_chon_nhan_vien.EditValue));
            if (m_id_gd_hd != 0)
            {
                m_id_gd_hs_lns_lcd_hien_tai = find_id_gd_hs_lns_lcd_hien_tai(m_id_gd_hd);
                m_id_loai_hop_dong = find_id_loai_hop_dong_cua_nhan_vien(m_id_gd_hd);
                if (m_id_loai_hop_dong != CONST_ID_LOAI_HOP_DONG.HOP_DONG_HOC_VIEC)
                {
                    m_id_ma_hs_lns_hien_tai = find_id_ma_hs_lns_hien_tai(m_id_gd_hs_lns_lcd_hien_tai);
                    m_id_muc_hs_lns_hien_tai = find_id_muc_hs_lns_hien_tai(m_id_gd_hs_lns_lcd_hien_tai);
                    m_id_ma_lcd_hien_tai = find_id_ma_lcd_hien_tai(m_id_gd_hs_lns_lcd_hien_tai);
                    m_id_muc_lcd_hien_tai = find_id_muc_lcd_hien_tai(m_id_gd_hs_lns_lcd_hien_tai);

                    m_id_gd_hs_lns_hien_tai = find_id_gd_hs_lns_hien_tai(m_id_gd_hd);
                    m_id_gd_lcd_hien_tai = find_id_gd_lcd_hien_tai(m_id_gd_hd);
                }
                else
                {
                    CHRM_BaseMessages.MsgBox_Infor(CONST_ID_MSGBOX.INFOR_HOP_DONG_HIEN_TAI_LA_HOC_VIEC);
                }
            }
            else
            {
                CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_NHAN_VIEN_CHUA_CO_HOP_DONG);
            }
        }

        private void form_2_us_gd_hs_lns(US_GD_HE_SO_LNS ip_us)
        {
            //ip_us.dcID_HOP_DONG = m_id_gd_hd;
            ip_us.dcHE_SO = CIPConvert.ToDecimal(m_txt_hs_lns.Text.Trim()); ;
            //ip_us.dcID_LY_DO_CHINH_SUA = CIPConvert.ToDecimal(m_sle_chon_ly_do_chinh_sua_hs_lns.EditValue);
            ip_us.datNGAY_BAT_DAU = m_dat_ngay_bat_dau_lns.Value.Date;
            if (m_dat_ngay_ket_thuc_lns.Checked == false)
            {
                ip_us.datNGAY_KET_THUC = DateTime.Now.AddYears(45);
            }
            else
            {
                ip_us.datNGAY_KET_THUC = m_dat_ngay_ket_thuc_lns.Value.Date;
            }
            ip_us.strGHI_CHU = m_txt_ghi_chu_hs_lns.Text;
            if (m_e_form_mode == DataEntryFormMode.InsertDataState)
            {
                ip_us.datNGAY_LAP = DateTime.Now.Date;
                //Nguoi lap
                ip_us.strNGUOI_LAP = CAppContext_201.getCurrentUserName();
            }
            if (m_e_form_mode == DataEntryFormMode.UpdateDataState)
            {
                ip_us.datNGAY_SUA = DateTime.Now.Date;
                //nguoi sua
                ip_us.strNGUOI_SUA = CAppContext_201.getCurrentUserName();
            }

        }

        private void form_2_us_gd_lcd(US_GD_LUONG_CHE_DO ip_us)
        {
            //ip_us.dcID_HOP_DONG = m_id_gd_hd;
            ip_us.dcSO_TIEN = CIPConvert.ToDecimal(m_txt_so_tien_lcd.Text.Trim()); ;
            ip_us.dcID_LY_DO_CHINH_SUA = CIPConvert.ToDecimal(m_sle_chon_ly_do_chinh_sua_so_tien_lcd.EditValue);
            ip_us.datNGAY_BAT_DAU = m_dat_ngay_bat_dau_lcd.Value.Date;
            if (!m_dat_ngay_ket_thuc_lcd.Checked)
            {
                ip_us.datNGAY_KET_THUC = DateTime.Now.AddYears(45);
            }
            else
            {
                ip_us.datNGAY_KET_THUC = m_dat_ngay_ket_thuc_lcd.Value.Date;
            }           
            ip_us.strGHI_CHU = m_txt_ghi_chu_lcd.Text;
            if (m_e_form_mode == DataEntryFormMode.InsertDataState)
            {
                ip_us.datNGAY_LAP = DateTime.Now.Date;
                //Nguoi lap
                ip_us.strNGUOI_LAP = CAppContext_201.getCurrentUserName();
            }
            if (m_e_form_mode == DataEntryFormMode.UpdateDataState)
            {
                ip_us.datNGAY_SUA = DateTime.Now.Date;
                //nguoi sua
                ip_us.strNGUOI_SUA = CAppContext_201.getCurrentUserName();
            }
        }

        private void load_data_hs_lns_lcd_now_2_form()
        {
            //thong tin lns
            m_sle_chuc_danh_lns.EditValue = m_id_ma_hs_lns_hien_tai;
            m_sle_muc_lns.EditValue = m_id_muc_hs_lns_hien_tai;
            if (m_id_gd_hs_lns_hien_tai != -1)
            {
                US_GD_HE_SO_LNS v_us_gd_hs_lns = new US_GD_HE_SO_LNS(m_id_gd_hs_lns_hien_tai);
                m_txt_hs_lns.Text = v_us_gd_hs_lns.dcHE_SO.ToString();
                //m_sle_chon_ly_do_chinh_sua_hs_lns.EditValue = v_us_gd_hs_lns.dcID_LY_DO_CHINH_SUA;
                m_txt_ghi_chu_hs_lns.Text = v_us_gd_hs_lns.strGHI_CHU.ToString();
                m_dat_ngay_bat_dau_lns.Value = v_us_gd_hs_lns.datNGAY_BAT_DAU;
                m_dat_ngay_ket_thuc_lns.Value = v_us_gd_hs_lns.datNGAY_KET_THUC;
            }
            else
            {
                clear_data_hs_lns();
            }
            //Thong tin lcd
            m_sle_chuc_danh_lcd.EditValue = m_id_ma_lcd_hien_tai;
            m_sle_muc_lcd.EditValue = m_id_muc_lcd_hien_tai;
            if (m_id_gd_lcd_hien_tai != -1)
            {
                US_GD_LUONG_CHE_DO v_us_gd_lcd = new US_GD_LUONG_CHE_DO(m_id_gd_lcd_hien_tai);
                m_txt_so_tien_lcd.Text = string.Format("{0:#,##0}", v_us_gd_lcd.dcSO_TIEN);
                m_sle_chon_ly_do_chinh_sua_so_tien_lcd.EditValue = v_us_gd_lcd.dcID_LY_DO_CHINH_SUA;
                m_txt_ghi_chu_lcd.Text = v_us_gd_lcd.strGHI_CHU.ToString();
                m_dat_ngay_bat_dau_lcd.Value = v_us_gd_lcd.datNGAY_BAT_DAU;
                m_dat_ngay_ket_thuc_lcd.Value = v_us_gd_lcd.datNGAY_KET_THUC;
            }
            else
            {
                clear_data_lcd();
            }

        }

        private void cho_us_gd_hs_lns_da_xoa_Y()
        {
            US_GD_HE_SO_LNS v_us = new US_GD_HE_SO_LNS(m_id_gd_hs_lns_hien_tai);
            DateTime v_dat_ngay_ket_thuc_hs_lns_hien_tai = m_dat_ngay_bat_dau_lns.Value.AddDays(-1);

            v_us.dcID = m_id_gd_hs_lns_hien_tai;
            v_us.datNGAY_KET_THUC = v_dat_ngay_ket_thuc_hs_lns_hien_tai.Date;
            v_us.datNGAY_SUA = DateTime.Now.Date;
            v_us.Update();
        }

        private void cho_us_gd_lcd_da_xoa_Y()
        {
            US_GD_LUONG_CHE_DO v_us = new US_GD_LUONG_CHE_DO(m_id_gd_lcd_hien_tai);
            DateTime v_dat_ngay_ket_thuc_lcd_hien_tai = m_dat_ngay_bat_dau_lcd.Value.AddDays(-1);

            v_us.dcID = m_id_gd_lcd_hien_tai;
            v_us.datNGAY_KET_THUC = v_dat_ngay_ket_thuc_lcd_hien_tai.Date;
            v_us.datNGAY_SUA = DateTime.Now.Date;
            v_us.Update();

        }

        private void save_data_hs_lns()
        {
            try
            {
                form_2_us_gd_hs_lns(v_us_hs_lns);
                switch (m_e_form_mode)
                {
                    case DataEntryFormMode.InsertDataState:
                        //delete us_gd_hs_lns
                        v_us_hs_lns.BeginTransaction();
                        cho_us_gd_hs_lns_da_xoa_Y();
                        //insert us_gd_hs_lns
                        v_us_hs_lns.Insert();
                        v_us_hs_lns.CommitTransaction();
                        id_nv_hien_tai = CIPConvert.ToDecimal(m_sle_chon_nhan_vien.EditValue);
                        break;
                    case DataEntryFormMode.UpdateDataState:
                        break;
                    default:
                        break;
                }
            }
            catch (Exception v_e)
            {
                v_us_hs_lns.Rollback();
                CSystemLog_301.ExceptionHandle(v_e);
            }

        }

        private void save_data_lcd()
        {
            try
            {
                form_2_us_gd_lcd(v_us_lcd);

                switch (m_e_form_mode)
                {
                    case DataEntryFormMode.InsertDataState:
                        //delete us_gd_lcd
                        v_us_lcd.BeginTransaction();
                        cho_us_gd_lcd_da_xoa_Y();
                        //insert us_gd_lcd                   
                        v_us_lcd.Insert();
                        v_us_lcd.CommitTransaction();
                        id_nv_hien_tai = CIPConvert.ToDecimal(m_sle_chon_nhan_vien.EditValue);
                        break;
                    case DataEntryFormMode.UpdateDataState:
                        break;
                    default:
                        break;
                }
            }
            catch (Exception v_e)
            {
                v_us_lcd.Rollback();
                CSystemLog_301.ExceptionHandle(v_e);
            }

        }


        //Design
        private void format_txt_so_tien()
        {
            decimal v_so_tien = 0;
            v_so_tien = CIPConvert.ToDecimal(m_txt_so_tien_lcd.Text.Trim());
            m_txt_so_tien_lcd.Text = string.Format("{0:#,##0}", v_so_tien);
        }

        //Clear data in form
        private void clear_data_in_form()
        {
            m_sle_chon_nhan_vien.EditValue = null;
            //lns
            m_sle_chuc_danh_lns.EditValue = null;
            m_sle_muc_lns.EditValue = null;
            m_sle_chon_ly_do_chinh_sua_hs_lns.EditValue = null;
            m_txt_ghi_chu_hs_lns.Text = "";
            m_dat_ngay_bat_dau_lns.Value = DateTime.Now.Date;
            m_dat_ngay_ket_thuc_lns.Value = DateTime.Now.Date;
            m_txt_hs_lns.Text = "";
            DS_V_F340_DAT_HS_LNS v_ds_gd_lns = new DS_V_F340_DAT_HS_LNS();
            //lcd
            m_sle_chuc_danh_lcd.EditValue = null;
            m_sle_muc_lcd.EditValue = null;
            m_sle_chon_ly_do_chinh_sua_so_tien_lcd.EditValue = null;
            m_txt_ghi_chu_lcd.Text = "";
            m_dat_ngay_bat_dau_lcd.Value = DateTime.Now.Date;
            m_dat_ngay_ket_thuc_lcd.Value = DateTime.Now.Date;
            m_txt_so_tien_lcd.Text = "";
            DS_V_F340_DAT_LCD v_ds_gd_lcd = new DS_V_F340_DAT_LCD();
        }

        private void clear_data_lcd()
        {
            m_txt_so_tien_lcd.Text = "";
            m_txt_ghi_chu_lcd.Text = "";
            m_sle_chon_ly_do_chinh_sua_so_tien_lcd.EditValue = null;
            m_sle_chuc_danh_lcd.EditValue = null;
            m_sle_muc_lcd.EditValue = null;
        }

        private void clear_data_hs_lns()
        {
            m_txt_hs_lns.Text = "";
            m_txt_ghi_chu_hs_lns.Text = "";
            m_sle_chon_ly_do_chinh_sua_hs_lns.EditValue = null;
            m_sle_chuc_danh_lns.EditValue = null;
            m_sle_muc_lns.EditValue = null;
        }

        #endregion

        private void set_define_events()
        {
            this.Load += f342_dat_hs_lns_lcd_Load;
            //cmd
            m_cmd_dat_gia_tri_hs_lns.Click += m_cmd_dat_gia_tri_hs_lns_Click;
            m_cmd_dat_gia_tri_lcd.Click += m_cmd_dat_gia_tri_lcd_Click;
            //control
            m_sle_chon_nhan_vien.EditValueChanged += m_sle_chon_nhan_vien_EditValueChanged;
            m_sle_chuc_danh_lns.EditValueChanged += m_sle_chuc_danh_lns_EditValueChanged;
            m_sle_muc_lns.EditValueChanged += m_sle_muc_lns_EditValueChanged;
            m_sle_chuc_danh_lcd.EditValueChanged += m_sle_chuc_danh_lcd_EditValueChanged;
            m_sle_muc_lcd.EditValueChanged += m_sle_muc_lcd_EditValueChanged;
            m_txt_so_tien_lcd.Leave += m_txt_so_tien_lcd_Leave;
            //gridview, gridcontrol
        }

        void m_cmd_save_Click(object sender, EventArgs e)
        {

        }

        void f342_dat_hs_lns_lcd_Load(object sender, EventArgs e)
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

        void m_cmd_dat_gia_tri_hs_lns_Click(object sender, EventArgs e)
        {
            try
            {
                if (!check_data_hs_lns_is_ok())
                {
                    return;
                }
                else
                {
                    switch (m_e_form_mode)
                    {
                        case DataEntryFormMode.InsertDataState:
                            if (DevExpress.XtraEditors.XtraMessageBox.Show("Bạn có chắc chắn muốn điều chỉnh hệ số LNS như trên?", "XÁC NHẬN LẠI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                save_data_hs_lns();
                                CHRM_BaseMessages.MsgBox_Infor("Lưu thành công");
                            }
                            break;
                        case DataEntryFormMode.UpdateDataState:
                            if (DevExpress.XtraEditors.XtraMessageBox.Show("Bạn có chắc chắn muốn cập nhật hệ số LNS như trên?", "XÁC NHẬN LẠI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                save_data_hs_lns();
                                CHRM_BaseMessages.MsgBox_Infor("Lưu thành công");
                            }
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_dat_gia_tri_lcd_Click(object sender, EventArgs e)
        {
            try
            {

                if (!check_data_lcd_is_ok())
                {
                    return;
                }
                else
                {
                    switch (m_e_form_mode)
                    {
                        case DataEntryFormMode.InsertDataState:
                            if (DevExpress.XtraEditors.XtraMessageBox.Show("Bạn có chắc chắn muốn điều chỉnh LCĐ như trên?", "XÁC NHẬN LẠI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                save_data_lcd();
                                CHRM_BaseMessages.MsgBox_Infor("Lưu thành công");
                            }
                            break;
                        case DataEntryFormMode.UpdateDataState:
                            if (DevExpress.XtraEditors.XtraMessageBox.Show("Bạn có chắc chắn muốn cập nhật LCĐ như trên?", "XÁC NHẬN LẠI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                save_data_lcd();
                                CHRM_BaseMessages.MsgBox_Infor("Lưu thành công");
                            }
                            break;
                        default:
                            break;
                    }
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
                m_insert_click = 1;
                clear_data_in_form();
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
                    m_insert_click = -1;
                    clear_data_in_form();
                    m_insert_click = 0;
                }
                else
                {
                    m_id_gd_hd = find_id_hd(CIPConvert.ToDecimal(m_sle_chon_nhan_vien.EditValue));
                    if (m_id_gd_hd != -1)
                    {
                        m_id_loai_hop_dong = find_id_loai_hop_dong_cua_nhan_vien(m_id_gd_hd);
                        if (m_id_loai_hop_dong != CONST_ID_LOAI_HOP_DONG.HOP_DONG_HOC_VIEC)
                        {
                            load_data_2_m_variable();
                            load_data_hs_lns_lcd_now_2_form();
                        }
                        else
                        {
                            CHRM_BaseMessages.MsgBox_Infor("Nhân viên có hợp đồng học việc. Ko có lương chế độ, lương năng suất");
                            m_insert_click = -1;
                            clear_data_in_form();
                            m_insert_click = 0;
                        }
                    }
                    else
                    {
                        CHRM_BaseMessages.MsgBox_Infor("Nhân viên chưa có hợp đồng hoặc đã xóa hợp đồng!");
                        m_insert_click = -1;
                        clear_data_in_form();
                        m_insert_click = 0;
                    }
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_sle_chuc_danh_lns_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (m_e_form_mode == DataEntryFormMode.InsertDataState) return;
                if (m_insert_click == 0)
                {
                    m_sle_muc_lns.EditValue = null;
                    m_txt_hs_lns.Text = "";
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_sle_muc_lns_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (m_e_form_mode == DataEntryFormMode.InsertDataState) return;
                if (m_insert_click == 0)
                {
                    if (m_sle_chuc_danh_lns.EditValue == null || m_sle_chuc_danh_lns.EditValue == "")
                    {
                        CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_CHUA_CHON_MA_LNS);
                        return;
                    }
                    else
                    {
                        if (m_sle_muc_lns.EditValue == null || m_sle_muc_lns.EditValue == "")
                        {
                            return;
                        }
                        else
                        {
                            m_txt_hs_lns.Text = find_hs_lns(CIPConvert.ToDecimal(m_sle_chuc_danh_lns.EditValue), CIPConvert.ToDecimal(m_sle_muc_lns.EditValue)).ToString();
                        }
                    }
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_sle_chuc_danh_lcd_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (m_e_form_mode == DataEntryFormMode.InsertDataState) return;
                if (m_insert_click == 0)
                {
                    m_sle_muc_lcd.EditValue = null;
                    m_txt_so_tien_lcd.Text = "";
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_sle_muc_lcd_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (m_e_form_mode == DataEntryFormMode.InsertDataState) return;
                if (m_insert_click == 0)
                {
                    if (m_sle_chuc_danh_lcd.EditValue == null || m_sle_chuc_danh_lcd.EditValue == "")
                    {
                        CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_CHUA_CHON_MA_LCD);
                        return;
                    }
                    else
                    {
                        if (m_sle_muc_lcd.EditValue == null || m_sle_muc_lcd.EditValue == "")
                        {
                            return;
                        }
                        else
                        {
                            m_txt_so_tien_lcd.Text = string.Format("{0:#,##0}", find_so_tien_lcd(CIPConvert.ToDecimal(m_sle_chuc_danh_lcd.EditValue), CIPConvert.ToDecimal(m_sle_muc_lcd.EditValue)));
                        }
                    }
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_txt_so_tien_lcd_Leave(object sender, EventArgs e)
        {
            try
            {
                format_txt_so_tien();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

    }
}
