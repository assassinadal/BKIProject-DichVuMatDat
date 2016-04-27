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
using IP.Core.IPSystemAdmin;
using IP.Core.IPWordReport;

namespace BKI_DichVuMatDat.NghiepVu
{
    public partial class f320_lap_hop_dong : Form
    {
        public f320_lap_hop_dong()
        {
            InitializeComponent();
            format_controls();
        }

        #region Public Interface
        public void display()
        {
            this.ShowDialog();
        }

        public void display_4_dieu_chinh_canh_bao(decimal m_dc_id_nv_dang_dieu_chinh)
        {
            m_sle_chon_nhan_vien.EditValue = m_dc_id_nv_dang_dieu_chinh;
            m_sle_chon_nhan_vien.Enabled = false;
            m_cmd_loc_du_lieu.Enabled = false;
            m_bool_dieu_chinh_canh_bao = true;
            load_data_2_grid(CIPConvert.ToDecimal(m_sle_chon_nhan_vien.EditValue));
            this.ShowDialog();
        }

        public void DisplayForQuyTrinhNhapMoiNhanVien(int id_nhan_vien)
        {
            m_sle_chon_nhan_vien.EditValue = id_nhan_vien;
            this.ShowDialog();
        }

        public void DisplayForSuaHopDongNhanVien(int id_nhan_vien)
        {
            m_lbl_header.Text = "SỬA HỢP ĐỒNG";
            this.Text = "F320 - Sửa hợp đồng";
            m_cmd_lap_hop_dong.Enabled = false;
            m_cmd_tao_lai.Enabled = false;
            m_cmd_lap_hop_dong.Text = "Lưu";
            m_sle_chon_nhan_vien.EditValue = id_nhan_vien;
            m_sle_chon_nhan_vien.Enabled = false;
            this.ShowDialog();
        }

        public void DisplayForQuyTrinhNhapMoiNhanVien(int id_nhan_vien, ref int m_trang_thai_buoc_3)
        {
            m_sle_chon_nhan_vien.EditValue = id_nhan_vien;
            m_trang_thai_them = m_trang_thai_buoc_3;
            this.ShowDialog();
            m_trang_thai_buoc_3 = m_trang_thai_buoc_3_thanh_cong;
        }
        #endregion

        #region Members
        string m_txt_path = "";
        int m_id_lns_lcd_trong_loai_td = 0; //1: LNS va 2:LCD
        decimal m_loai_hop_dong = (decimal)MyEnum.KHAC_HOP_DONG_HOC_VIEC; //0: hoc viec va 1: Cac loai khac
        decimal m_cmd_tao_lai_is_click = (decimal)MyEnum.NUT_TAO_LAI_KHONG_DUOC_CLICK; //0: ko click, 1:click nut tao lai
        decimal m_insert_click = (decimal)MyEnum.NUT_THEM_KHONG_DUOC_CLICK; //0: ko click, 1:click nut tao lai
        decimal m_lan_load_form = (decimal)MyEnum.FORM_DUOC_LOAD_LAN_DAU;
        DataEntryFormMode m_e_form_mode = DataEntryFormMode.InsertDataState;
        decimal m_id_gd_hd = 0;
        decimal m_id_hs_lns = 0;
        decimal m_id_lcd = 0;
        int m_trang_thai_buoc_3_thanh_cong = 0;
        int m_trang_thai_them = 0;
        string op_str_mess = "";
        bool m_bool_dieu_chinh_canh_bao = false;
        #endregion

        #region Data structure
        enum MyEnum
        {
            HOP_DONG_HOC_VIEC = 0,
            KHAC_HOP_DONG_HOC_VIEC = 1,
            NUT_TAO_LAI_KHONG_DUOC_CLICK = 0,
            NUT_TAO_LAI_DUOC_CLICK = 1,
            NUT_THEM_KHONG_DUOC_CLICK = 0,
            NUT_THEM_DUOC_CLICK = 1,
            FORM_DUOC_LOAD_LAN_DAU = 0,
            FORM_DUOC_LOAD_LAN_THU_2_TRO_LEN = 1
        }
        #endregion

        #region Private methods
        private void format_controls()
        {
            FormatControl.SetVisibleSimpleButton(this);
            this.m_grv_lap_hd.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(WinFormControls.m_grv_PopupMenuShowing);
            this.m_grv_lap_hd.OptionsPrint.AutoWidth = false;
            set_define_events();
            this.KeyPreview = true;
            CenterToScreen();
        }

        private void set_initial_form_load()
        {
            load_data_2_sle_chon_nv();
            load_data_2_sle_loai_hd();
            load_data_2_sle_chuc_danh_lns();
            load_data_2_sle_muc_lns();
            load_data_2_sle_chuc_danh_lcd();
            load_data_2_sle_muc_lcd();
            if (m_sle_chon_nhan_vien.EditValue == null || m_sle_chon_nhan_vien.EditValue == "")
            {
                load_data_2_grid();
            }
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

        private DS_DM_LOAI_HOP_DONG load_data_2_ds_dm_loai_hd()
        {
            DS_DM_LOAI_HOP_DONG v_ds = new DS_DM_LOAI_HOP_DONG();
            US_DM_LOAI_HOP_DONG v_us = new US_DM_LOAI_HOP_DONG();

            v_us.FillDataset(v_ds);
            return v_ds;
        }

        private void load_data_2_sle_loai_hd()
        {
            m_sle_loai_hop_dong.Properties.DataSource = load_data_2_ds_dm_loai_hd().DM_LOAI_HOP_DONG;
            m_sle_loai_hop_dong.Properties.ValueMember = DM_LOAI_HOP_DONG.ID;
            m_sle_loai_hop_dong.Properties.DisplayMember = DM_LOAI_HOP_DONG.LOAI_HOP_DONG;

            m_sle_loai_hop_dong.Properties.PopulateViewColumns();
            m_sle_loai_hop_dong.Properties.View.Columns[DM_LOAI_HOP_DONG.ID].Visible = false;
            m_sle_loai_hop_dong.Properties.View.Columns[DM_LOAI_HOP_DONG.AN_CA_YN].Visible = false;
            m_sle_loai_hop_dong.Properties.View.Columns[DM_LOAI_HOP_DONG.HS_LNS_YN].Visible = false;
            m_sle_loai_hop_dong.Properties.View.Columns[DM_LOAI_HOP_DONG.LCD_YN].Visible = false;
            m_sle_loai_hop_dong.Properties.View.Columns[DM_LOAI_HOP_DONG.SO_TIEN].Visible = false;
            m_sle_loai_hop_dong.Properties.View.Columns[DM_LOAI_HOP_DONG.TI_LE].Visible = false;

            m_sle_loai_hop_dong.Properties.View.Columns[DM_LOAI_HOP_DONG.LOAI_HOP_DONG].Width = 120;
            m_sle_loai_hop_dong.Properties.View.Columns[DM_LOAI_HOP_DONG.MA_LOAI_HOP_DONG].Width = 90;

            m_sle_loai_hop_dong.Properties.View.Columns[DM_LOAI_HOP_DONG.MA_LOAI_HOP_DONG].Caption = "Mã loại";
            m_sle_loai_hop_dong.Properties.View.Columns[DM_LOAI_HOP_DONG.LOAI_HOP_DONG].Caption = "Tên loại";

            m_sle_loai_hop_dong.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            m_sle_loai_hop_dong.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
        }



        private DS_CM_DM_TU_DIEN load_data_2_cm_dm_tu_dien(int m_id_lns_lcd_trong_loai_td)
        {
            DS_CM_DM_TU_DIEN v_ds = new DS_CM_DM_TU_DIEN();
            US_CM_DM_TU_DIEN v_us = new US_CM_DM_TU_DIEN();

            v_us.FillDatasetByIdLoaiTuDien(v_ds, m_id_lns_lcd_trong_loai_td);

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

        private void load_data_2_grid()
        {
            CHRMCommon.make_stt(m_grv_lap_hd);

            DS_V_F320_LAP_HOP_DONG v_ds = new DS_V_F320_LAP_HOP_DONG();
            US_V_F320_LAP_HOP_DONG v_us = new US_V_F320_LAP_HOP_DONG();
            //string v_current_date = DateTime.Now.Date.ToShortDateString();

            //v_us.FillDataset(v_ds, "WHERE NGAY_BAT_DAU <= '" + v_current_date + "' AND (NGAY_KET_THUC >= '" + v_current_date + "' OR NGAY_KET_THUC IS NULL)");
            v_us.FillDataset_by_ngay_hien_tai(v_ds);

            m_grc_lap_hd.DataSource = v_ds.Tables[0];
        }

        private void load_data_2_grid(decimal ip_dc_id_nhan_vien)
        {
            CHRMCommon.make_stt(m_grv_lap_hd);

            DS_V_F320_LAP_HOP_DONG v_ds = new DS_V_F320_LAP_HOP_DONG();
            US_V_F320_LAP_HOP_DONG v_us = new US_V_F320_LAP_HOP_DONG();
            //string v_current_date = DateTime.Now.Date.ToShortDateString();

            //v_us.FillDataset(v_ds, "WHERE ID_NHAN_VIEN = " + ip_dc_id_nhan_vien + " AND NGAY_BAT_DAU <= '" + v_current_date + "' AND (NGAY_KET_THUC >= '" + v_current_date + "' OR NGAY_KET_THUC IS NULL)");
            v_us.FillDataset_by_ngay_hien_tai(v_ds, ip_dc_id_nhan_vien);
            m_grc_lap_hd.DataSource = v_ds.Tables[0];
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
        private bool check_ma_hd()
        {
            DS_GD_HOP_DONG v_ds = new DS_GD_HOP_DONG();
            US_GD_HOP_DONG v_us = new US_GD_HOP_DONG();

            v_us.FillDataset(v_ds);

            string v_str_filter = "";
            v_str_filter = "MA_HOP_DONG = '" + m_txt_ma_hd.Text + "'";

            DataRow[] v_dr = v_ds.GD_HOP_DONG.Select(v_str_filter);

            if (v_dr.Count() != 0)
            {
                m_txt_ma_hd.BackColor = Color.Bisque;
                //  m_lbl_kiem_tra_ma_hd.Visible = true;
                //  m_lbl_kiem_tra_ma_hd.Text = "Đã có mã này rồi...";
                MessageBox.Show("Đã có mã này rồi!");
                return true;
            }
            else
            {
                m_txt_ma_hd.BackColor = Color.White;
                // m_lbl_kiem_tra_ma_hd.Visible = false;
                return false;
            }
        }

        private bool check_data_is_ok()
        {
            if (m_sle_chon_nhan_vien.EditValue == null || m_sle_chon_nhan_vien.EditValue == "")
            {
                CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_CHUA_CHON_NHAN_VIEN);
                return false;
            }

            if (m_sle_loai_hop_dong.EditValue == null || m_sle_loai_hop_dong.EditValue == "")
            {
                CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_CHUA_CHON_LOAI_HOP_DONG);
                return false;
            }

            //if (m_txt_ma_hd.Text == null)
            //{
            //    CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_CHUA_NHAP_MA_HOP_DONG);
            //    return false;
            //}

            if (m_loai_hop_dong == 1)
            {
                if (m_sle_muc_lns.EditValue == null || m_sle_muc_lns.EditValue == "")
                {
                    CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_CHUA_CHON_MUC_LNS);
                    return false;
                }

                if (m_sle_muc_lcd.EditValue == null || m_sle_muc_lcd.EditValue == "")
                {
                    CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_CHUA_CHON_MUC_LCD);
                    return false;
                }

                if (m_sle_chuc_danh_lns.EditValue == null || m_sle_chuc_danh_lns.EditValue == "")
                {
                    CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_CHUA_CHON_MA_LNS);
                    return false;
                }

                if (m_sle_chuc_danh_lcd.EditValue == null || m_sle_chuc_danh_lcd.EditValue == "")
                {
                    CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_CHUA_CHON_MA_LCD);
                    return false;
                }
            }

            if (m_dat_ngay_bat_dau.Value.Date >= m_dat_ngay_ket_thuc.Value.Date)
            {
                CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_NGAY_KET_THUC_NHO_HON_NGAY_BAT_DAU);
                return false;
            }

            return true;
        }

        //Insert, update, delete

        private void form_2_us_gd_hop_dong(US_GD_HOP_DONG ip_us)
        {
            try
            {
                ip_us.dcID_NHAN_VIEN = CIPConvert.ToDecimal(m_sle_chon_nhan_vien.EditValue);
                ip_us.dcID_LOAI_HOP_DONG = CIPConvert.ToDecimal(m_sle_loai_hop_dong.EditValue);
                ip_us.strMA_HOP_DONG = m_txt_ma_hd.Text.Trim();
                ip_us.datNGAY_BAT_DAU = m_dat_ngay_bat_dau.Value.Date;
                if (m_dat_ngay_ket_thuc.Checked == true)
                {
                    ip_us.datNGAY_KET_THUC = m_dat_ngay_ket_thuc.Value.Date;
                }
                ip_us.datNGAY_KY_HOP_DONG = m_dat_ngay_ky.Value.Date;
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
            catch (Exception v_e)
            {
                throw v_e;
            }
        }

        private decimal find_id_gd_hd(decimal ip_dc_id_nv)
        {
            try
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
            catch (Exception v_e)
            {
                throw v_e;
            }
        }

        private decimal find_id_hs_lns(decimal ip_dc_id_ma_lns, decimal ip_dc_id_muc_lns)
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

        private decimal find_id_lcd(decimal ip_dc_id_ma_lcd, decimal ip_dc_id_muc_lcd)
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

        private decimal find_id_gd_lns_lcd(decimal ip_dc_id_gd_hd)
        {
            try
            {
                US_GD_HS_LNS_LCD v_us = new US_GD_HS_LNS_LCD();
                DS_GD_HS_LNS_LCD v_ds = new DS_GD_HS_LNS_LCD();

                v_us.FillDataset(v_ds);

                string v_str_filter = "ID_HOP_DONG = " + ip_dc_id_gd_hd + "AND DA_XOA = 'N'";
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
            catch (Exception v_e)
            {
                throw v_e;
            }
        }

        private decimal find_id_gd_hs_lns(decimal ip_dc_id_gd_hd)
        {
            try
            {
                US_GD_HE_SO_LNS v_us = new US_GD_HE_SO_LNS();
                DS_GD_HE_SO_LNS v_ds = new DS_GD_HE_SO_LNS();

                v_us.FillDataset(v_ds);

                string v_str_filter = "ID_HOP_DONG = " + ip_dc_id_gd_hd + "AND DA_XOA = 'N'";
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
            catch (Exception v_e)
            {
                throw v_e;
            }
        }

        private decimal find_id_gd_lcd(decimal ip_dc_id_gd_hd)
        {
            try
            {
                US_GD_LUONG_CHE_DO v_us = new US_GD_LUONG_CHE_DO();
                DS_GD_LUONG_CHE_DO v_ds = new DS_GD_LUONG_CHE_DO();

                v_us.FillDataset(v_ds);

                string v_str_filter = "ID_HOP_DONG = " + ip_dc_id_gd_hd + "AND DA_XOA = 'N'";
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
            catch (Exception v_e)
            {
                throw v_e;
            }
        }

        private decimal find_id_trang_thai_lao_dong_da_co(decimal ip_dc_id_nhan_vien)
        {
            try
            {
                US_GD_TRANG_THAI_LAO_DONG v_us = new US_GD_TRANG_THAI_LAO_DONG();
                DS_GD_TRANG_THAI_LAO_DONG v_ds = new DS_GD_TRANG_THAI_LAO_DONG();

                v_us.FillDataset(v_ds);

                string v_str_filter = "ID_NHAN_VIEN = " + ip_dc_id_nhan_vien + " AND DA_XOA = 'N'";
                DataRow[] v_dr = v_ds.GD_TRANG_THAI_LAO_DONG.Select(v_str_filter);

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

        private void load_data_2_m_variable()
        {
            m_id_gd_hd = find_id_gd_hd(CIPConvert.ToDecimal(m_sle_chon_nhan_vien.EditValue));
            m_id_hs_lns = find_id_hs_lns(CIPConvert.ToDecimal(m_sle_chuc_danh_lns.EditValue), CIPConvert.ToDecimal(m_sle_muc_lns.EditValue));
            m_id_lcd = find_id_lcd(CIPConvert.ToDecimal(m_sle_chuc_danh_lcd.EditValue), CIPConvert.ToDecimal(m_sle_muc_lcd.EditValue));
        }

        private void form_2_us_gd_hs_lns_lcd(US_GD_HS_LNS_LCD ip_us)
        {
            try
            {
                ip_us.dcID_HOP_DONG = find_id_gd_hd(CIPConvert.ToDecimal(m_sle_chon_nhan_vien.EditValue)); ;
                //ip_us.dcID_QUYET_DINH = 
                ip_us.dcID_HS_LNS = m_id_hs_lns;
                ip_us.dcID_LCD = m_id_lcd;
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
                ip_us.strDA_XOA = "N";
            }
            catch (Exception v_e)
            {
                throw v_e;
            }
        }

        private void form_2_us_gd_hs_lns(US_GD_HE_SO_LNS ip_us)
        {
            try
            {
                //ip_us.dcID_HOP_DONG = find_id_gd_hd(CIPConvert.ToDecimal(m_sle_chon_nhan_vien.EditValue));
                ip_us.dcHE_SO = CIPConvert.ToDecimal(find_hs_lns(CIPConvert.ToDecimal(m_sle_chuc_danh_lns.EditValue), CIPConvert.ToDecimal(m_sle_muc_lns.EditValue)));
                //ip_us.dcID_LY_DO_CHINH_SUA =
                ip_us.datNGAY_BAT_DAU = m_dat_ngay_bat_dau.Value.Date;
                if (m_dat_ngay_ket_thuc.Checked == true)
                {
                    ip_us.datNGAY_KET_THUC = m_dat_ngay_ket_thuc.Value.Date;
                }
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
            catch (Exception v_e)
            {
                throw v_e;
            }
        }

        private void form_2_us_gd_lcd(US_GD_LUONG_CHE_DO ip_us)
        {
            try
            {
                //ip_us.dcID_HOP_DONG = find_id_gd_hd(CIPConvert.ToDecimal(m_sle_chon_nhan_vien.EditValue));
                ip_us.dcSO_TIEN = CIPConvert.ToDecimal(find_so_tien_lcd(CIPConvert.ToDecimal(m_sle_chuc_danh_lcd.EditValue), CIPConvert.ToDecimal(m_sle_muc_lcd.EditValue)));
                //ip_us.dcID_LY_DO_CHINH_SUA =
                ip_us.datNGAY_BAT_DAU = m_dat_ngay_bat_dau.Value.Date;
                if (m_dat_ngay_ket_thuc.Checked == true)
                {
                    ip_us.datNGAY_KET_THUC = m_dat_ngay_ket_thuc.Value.Date;
                }
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
            catch (Exception v_e)
            {
                throw v_e;
            }
        }

        private void form_2_us_gd_trang_thai_lao_dong(US_GD_TRANG_THAI_LAO_DONG ip_us)
        {
            ip_us.dcID_NHAN_VIEN = decimal.Parse(m_sle_chon_nhan_vien.EditValue.ToString());
            ip_us.dcID_TRANG_THAI_LAO_DONG = CONST_ID_TRANG_THAI_LAO_DONG.DANG_LAM_VIEC;
            ip_us.datNGAY_AP_DUNG = m_dat_ngay_bat_dau.Value.Date;
            ip_us.datNGAY_LAP = DateTime.Now.Date;
            ip_us.strNGUOI_LAP = CAppContext_201.getCurrentUserName();
            ip_us.strDA_XOA = "N";
        }

        private void us_obj_2_form(decimal v_id_gd_hd, decimal v_id_gd_lns_lcd)
        {
            US_GD_HOP_DONG v_us_gd_hd = new US_GD_HOP_DONG(v_id_gd_hd);

            if (v_id_gd_lns_lcd != -1)
            {
                US_GD_HS_LNS_LCD v_us_gd_lns_lcd = new US_GD_HS_LNS_LCD(v_id_gd_lns_lcd);
                US_DM_HE_SO_LUONG_NS v_us_dm_hs_lns = new US_DM_HE_SO_LUONG_NS(v_us_gd_lns_lcd.dcID_HS_LNS);
                US_DM_LUONG_CHE_DO v_us_dm_lcd = new US_DM_LUONG_CHE_DO(v_us_gd_lns_lcd.dcID_LCD);
                m_sle_chon_nhan_vien.EditValue = v_us_gd_hd.dcID_NHAN_VIEN;
                m_txt_ma_hd.Text = v_us_gd_hd.strMA_HOP_DONG;
                m_sle_loai_hop_dong.EditValue = v_us_gd_hd.dcID_LOAI_HOP_DONG;
                m_dat_ngay_bat_dau.Value = v_us_gd_hd.datNGAY_BAT_DAU;
                m_dat_ngay_ket_thuc.Value = v_us_gd_hd.datNGAY_KET_THUC;
                m_dat_ngay_ky.Value = v_us_gd_hd.datNGAY_KY_HOP_DONG;

                if (v_us_gd_hd.dcID_LOAI_HOP_DONG == CONST_ID_LOAI_HOP_DONG.HOP_DONG_HOC_VIEC)
                {
                    m_gr_LNS.Enabled = false;
                    m_gr_LCD.Enabled = false;
                }
                else
                {
                    m_sle_chuc_danh_lns.EditValue = v_us_dm_hs_lns.dcID_MA_LNS;
                    m_sle_muc_lns.EditValue = v_us_dm_hs_lns.dcID_MUC_LNS;
                    m_sle_chuc_danh_lcd.EditValue = v_us_dm_lcd.dcID_MA_LCD;
                    m_sle_muc_lcd.EditValue = v_us_dm_lcd.dcID_MUC_LCD;
                }
            }
            else
            {
                m_sle_chon_nhan_vien.EditValue = v_us_gd_hd.dcID_NHAN_VIEN;
                m_txt_ma_hd.Text = v_us_gd_hd.strMA_HOP_DONG;
                m_sle_loai_hop_dong.EditValue = v_us_gd_hd.dcID_LOAI_HOP_DONG;
                m_dat_ngay_bat_dau.Value = v_us_gd_hd.datNGAY_BAT_DAU;
                m_dat_ngay_ket_thuc.Value = v_us_gd_hd.datNGAY_KET_THUC;
                m_dat_ngay_ky.Value = v_us_gd_hd.datNGAY_KY_HOP_DONG;
                if (v_us_gd_hd.dcID_LOAI_HOP_DONG == CONST_ID_LOAI_HOP_DONG.HOP_DONG_HOC_VIEC)
                {
                    m_gr_LNS.Enabled = false;
                    m_gr_LCD.Enabled = false;
                }
            }



            if (m_e_form_mode == DataEntryFormMode.UpdateDataState)
            {

            }
        }

        private void cho_hop_dong_da_co_ve_trang_thai_delete_Y()
        {
            US_GD_HOP_DONG v_us = new US_GD_HOP_DONG(m_id_gd_hd);
            v_us.datNGAY_SUA = DateTime.Now.Date;
            //nguoi sua
            v_us.BeginTransaction();
            v_us.Update();
            v_us.CommitTransaction();
        }

        private void cho_gd_hs_lns_lcd_da_xoa_Y()
        {
            decimal v_id_gd_hs_lns_lcd = 0;
            v_id_gd_hs_lns_lcd = find_id_gd_lns_lcd(m_id_gd_hd);
            if (v_id_gd_hs_lns_lcd == -1)
            {
                return;
            }
            US_GD_HS_LNS_LCD v_us = new US_GD_HS_LNS_LCD(v_id_gd_hs_lns_lcd);

            v_us.strDA_XOA = "Y";
            v_us.datNGAY_SUA = DateTime.Now.Date;
            //nguoi sua
            v_us.BeginTransaction();
            v_us.Update();
            v_us.CommitTransaction();
        }

        private void cho_gd_hs_lns_da_xoa_Y()
        {
            decimal v_id_gd_hs_lns = 0;
            v_id_gd_hs_lns = find_id_gd_hs_lns(m_id_gd_hd);

            US_GD_HE_SO_LNS v_us = new US_GD_HE_SO_LNS(v_id_gd_hs_lns);

            v_us.datNGAY_SUA = DateTime.Now.Date;
            //nguoi sua
            v_us.BeginTransaction();
            v_us.Update();
            v_us.CommitTransaction();
        }

        private void cho_gd_lcd_da_xoa_Y()
        {
            decimal v_id_gd_lcd = 0;
            v_id_gd_lcd = find_id_gd_lcd(m_id_gd_hd);

            US_GD_LUONG_CHE_DO v_us = new US_GD_LUONG_CHE_DO(v_id_gd_lcd);

            v_us.datNGAY_SUA = DateTime.Now.Date;
            //nguoi sua
            v_us.BeginTransaction();
            v_us.Update();
            v_us.CommitTransaction();
        }

        private void save_data()
        {
            US_GD_HS_LNS_LCD v_us_gd_hs_lns_lcd = new US_GD_HS_LNS_LCD();
            US_GD_HE_SO_LNS v_us_gd_hs_lns = new US_GD_HE_SO_LNS();
            US_GD_LUONG_CHE_DO v_us_gd_lcd = new US_GD_LUONG_CHE_DO();
            US_GD_TRANG_THAI_LAO_DONG v_us_gd_trang_thai_lao_dong = new US_GD_TRANG_THAI_LAO_DONG();
            US_GD_HOP_DONG v_us_gd_hd = new US_GD_HOP_DONG();
            form_2_us_gd_hop_dong(v_us_gd_hd);
            US_GD_HOP_DONG v_us = new US_GD_HOP_DONG();
            switch (m_e_form_mode)
            {
                case DataEntryFormMode.UpdateDataState:
                    v_us_gd_hd.BeginTransaction();
                    v_us_gd_hd.dcID = CIPConvert.ToDecimal(m_grv_lap_hd.GetRowCellValue(m_grv_lap_hd.FocusedRowHandle, "ID"));
                    v_us_gd_hd.Update();
                    v_us_gd_hd.CommitTransaction();

                    //
                    form_2_us_gd_hs_lns_lcd(v_us_gd_hs_lns_lcd);
                    v_us_gd_hs_lns_lcd.BeginTransaction();
                    v_us_gd_hs_lns_lcd.dcID = find_id_gd_lns_lcd(CIPConvert.ToDecimal(m_grv_lap_hd.GetRowCellValue(m_grv_lap_hd.FocusedRowHandle, "ID")));
                    v_us_gd_hs_lns_lcd.Update();
                    v_us_gd_hs_lns_lcd.CommitTransaction();
                    break;
                case DataEntryFormMode.InsertDataState:
                    v_us.lap_hop_dong_moi_cho_nhan_vien(CIPConvert.ToDecimal(m_sle_chon_nhan_vien.EditValue)
                                                        , CIPConvert.ToDecimal(m_sle_loai_hop_dong.EditValue)
                                                        , m_txt_ma_hd.Text.Trim()
                                                        , m_dat_ngay_bat_dau.Value.Date
                                                        , m_dat_ngay_ket_thuc.Value.Date
                                                        , m_dat_ngay_ky.Value.Date
                                                        , DateTime.Now.Date
                                                        , CAppContext_201.getCurrentUserName()
                                                        , "N"
                                                        , CIPConvert.ToDecimal(m_sle_chuc_danh_lcd.EditValue)
                                                        , CIPConvert.ToDecimal(m_sle_muc_lcd.EditValue)
                                                        , CIPConvert.ToDecimal(m_sle_chuc_danh_lns.EditValue)
                                                        , CIPConvert.ToDecimal(m_sle_muc_lns.EditValue)
                                                        , ref op_str_mess);
                    break;
                case DataEntryFormMode.ViewDataState:
                    break;
                case DataEntryFormMode.SelectDataState:
                    break;
                default:
                    break;
            }

            //US_GD_HS_LNS_LCD v_us_gd_hs_lns_lcd = new US_GD_HS_LNS_LCD();
            //US_GD_HE_SO_LNS v_us_gd_hs_lns = new US_GD_HE_SO_LNS();
            //US_GD_LUONG_CHE_DO v_us_gd_lcd = new US_GD_LUONG_CHE_DO();
            //US_GD_TRANG_THAI_LAO_DONG v_us_gd_trang_thai_lao_dong = new US_GD_TRANG_THAI_LAO_DONG();
            //US_GD_HOP_DONG v_us_gd_hd = new US_GD_HOP_DONG();
            //form_2_us_gd_hop_dong(v_us_gd_hd);
            //try
            //{
            //    switch (m_e_form_mode)
            //    {
            //        case DataEntryFormMode.InsertDataState:
            //            if (m_id_gd_hd != -1)
            //            {
            //                cho_hop_dong_da_co_ve_trang_thai_delete_Y();
            //                cho_gd_hs_lns_lcd_da_xoa_Y();
            //                cho_gd_hs_lns_da_xoa_Y();
            //                cho_gd_lcd_da_xoa_Y();
            //            }

            //            //lap hop dong moi
            //            v_us_gd_hd.BeginTransaction();
            //            v_us_gd_hd.Insert();
            //            v_us_gd_hd.CommitTransaction();

            //            //insert gd_hs_lns_lcd
            //            form_2_us_gd_hs_lns_lcd(v_us_gd_hs_lns_lcd);
            //            v_us_gd_hs_lns_lcd.BeginTransaction();
            //            v_us_gd_hs_lns_lcd.Insert();
            //            v_us_gd_hs_lns_lcd.CommitTransaction();

            //            //insert gd_hs_lns
            //            form_2_us_gd_hs_lns(v_us_gd_hs_lns);
            //            v_us_gd_hs_lns.BeginTransaction();
            //            v_us_gd_hs_lns.Insert();
            //            v_us_gd_hs_lns.CommitTransaction();

            //            //insert gd_lcd
            //            form_2_us_gd_lcd(v_us_gd_lcd);
            //            v_us_gd_lcd.BeginTransaction();
            //            v_us_gd_lcd.Insert();
            //            v_us_gd_lcd.CommitTransaction();

            //            //insert gd_trang_thai_ld
            //            decimal v_id_gd_trang_thai_lao_dong_da_co = 0;

            //            v_id_gd_trang_thai_lao_dong_da_co = find_id_trang_thai_lao_dong_da_co(decimal.Parse(m_sle_chon_nhan_vien.EditValue.ToString())); //sai o day

            //            if (v_id_gd_trang_thai_lao_dong_da_co == -1)
            //            {
            //                form_2_us_gd_trang_thai_lao_dong(v_us_gd_trang_thai_lao_dong);
            //                v_us_gd_trang_thai_lao_dong.BeginTransaction();
            //                v_us_gd_trang_thai_lao_dong.Insert();
            //                v_us_gd_trang_thai_lao_dong.CommitTransaction();
            //            }
            //            break;
            //        case DataEntryFormMode.UpdateDataState:
            //            v_us_gd_hd.BeginTransaction();
            //            v_us_gd_hd.dcID = CIPConvert.ToDecimal(m_grv_lap_hd.GetRowCellValue(m_grv_lap_hd.FocusedRowHandle, "ID"));
            //            v_us_gd_hd.Update();
            //            v_us_gd_hd.CommitTransaction();

            //            //
            //            form_2_us_gd_hs_lns_lcd(v_us_gd_hs_lns_lcd);
            //            v_us_gd_hs_lns_lcd.BeginTransaction();
            //            v_us_gd_hs_lns_lcd.dcID = find_id_gd_lns_lcd(CIPConvert.ToDecimal(m_grv_lap_hd.GetRowCellValue(m_grv_lap_hd.FocusedRowHandle, "ID")));
            //            v_us_gd_hs_lns_lcd.Update();
            //            v_us_gd_hs_lns_lcd.CommitTransaction();
            //            break;
            //        default:
            //            break;
            //    }
            //}
            //catch (Exception v_e)
            //{

            //    throw v_e;
            //}
        }

        private void focus_new_row_created()
        {
            int v_row_index = 0;
            decimal v_id_nv_f330 = 0;
            string v_da_xoa_f340 = "N";

            US_V_F320_LAP_HOP_DONG v_us = new US_V_F320_LAP_HOP_DONG();
            DS_V_F320_LAP_HOP_DONG v_ds = new DS_V_F320_LAP_HOP_DONG();

            v_id_nv_f330 = CIPConvert.ToDecimal(m_sle_chon_nhan_vien.EditValue);

            v_us.FillDataset(v_ds);

            for (v_row_index = 0; v_row_index < v_ds.Tables[0].Rows.Count; v_row_index++)
            {
                var v_id_nv = CIPConvert.ToDecimal(m_grv_lap_hd.GetDataRow(v_row_index)["ID_NHAN_VIEN"].ToString());
                var v_da_xoa = m_grv_lap_hd.GetDataRow(v_row_index)["DA_XOA"].ToString();

                if (v_id_nv == v_id_nv_f330 && v_da_xoa == v_da_xoa_f340)
                {
                    break;
                }
            }

            m_grv_lap_hd.FocusedRowHandle = v_row_index;
        }

        //clear data in form
        private void clear_data_in_form()
        {
            m_sle_chon_nhan_vien.EditValue = "";
            clear_data_without_sle_chon_nv_and_grid();
            load_data_2_grid();
            //DS_V_F320_LAP_HOP_DONG v_ds = new DS_V_F320_LAP_HOP_DONG();
            //m_grc_lap_hd.DataSource = v_ds.Tables[0];
        }

        private void clear_data_without_sle_chon_nv_and_grid()
        {
            m_txt_ma_hd.Text = "";
            // m_lbl_kiem_tra_ma_hd.Visible = false;
            m_sle_loai_hop_dong.EditValue = null;
            m_sle_chuc_danh_lns.EditValue = null;
            m_sle_muc_lns.EditValue = null;
            m_sle_chuc_danh_lcd.EditValue = null;
            m_sle_muc_lcd.EditValue = null;
            m_dat_ngay_bat_dau.Value = DateTime.Now.Date;
            m_dat_ngay_ket_thuc.Value = DateTime.Now.Date;
            m_dat_ngay_ky.Value = DateTime.Now.Date;
            m_lbl_hs_lns.Text = "...";
            m_lbl_so_tien_lcd.Text = "...";
        }

        public void import_excel()
        {
            m_txt_path = WinFormControls.openFileDialog();
            if (m_txt_path != "")
            {
                f322_lap_hop_dong_excel v_f = new f322_lap_hop_dong_excel();
                v_f.displayToInsertExcel(m_txt_path);
            }
            load_data_2_grid();
            //OpenFileDialog openFileDialog1 = new OpenFileDialog();

            //// Set filter options and filter index.
            //openFileDialog1.Filter = "xlsx Files|*.xlsx|xls Files|*.xls|All Files (*.*)|*.*";
            //openFileDialog1.Multiselect = false;
            //var userClickedOK = openFileDialog1.ShowDialog();
            //if (userClickedOK == System.Windows.Forms.DialogResult.OK)
            //{
            //    m_txt_path = openFileDialog1.FileName;
            //    f322_lap_hop_dong_excel v_f = new f322_lap_hop_dong_excel();
            //    v_f.displayToInsertExcel(m_txt_path);
            //    // WinFormControls.load_xls_to_gridview(m_txt_path, m_grc);
            //}
            //load_data_2_grid();
        }

        public void import_excel(ref bool trang_thai_buoc_hien_tai)
        {
            m_txt_path = WinFormControls.openFileDialog();
            if (m_txt_path != "")
            {
                f322_lap_hop_dong_excel v_f = new f322_lap_hop_dong_excel();
                v_f.displayToInsertExcel(m_txt_path);
                trang_thai_buoc_hien_tai = true;
            }
            load_data_2_grid();
        }

        private void datetimechange()
        {
            if (m_sle_loai_hop_dong.EditValue != null && m_sle_loai_hop_dong.EditValue != "")
            {
                if (decimal.Parse(m_sle_loai_hop_dong.EditValue.ToString()) == CONST_ID_LOAI_HOP_DONG.HOP_DONG_MOT_NAM)
                {
                    m_dat_ngay_ket_thuc.Value = m_dat_ngay_bat_dau.Value.AddYears(1).AddDays(-1);
                }
                else if (decimal.Parse(m_sle_loai_hop_dong.EditValue.ToString()) == CONST_ID_LOAI_HOP_DONG.HOP_DONG_3_NAM)
                {
                    m_dat_ngay_ket_thuc.Value = m_dat_ngay_bat_dau.Value.AddYears(3).AddDays(-1);
                }
                else if (decimal.Parse(m_sle_loai_hop_dong.EditValue.ToString()) == CONST_ID_LOAI_HOP_DONG.HOP_DONG_KHONG_XAC_DINH)
                {
                    m_dat_ngay_ket_thuc.Value = m_dat_ngay_bat_dau.Value.AddYears(45);
                }
                else
                {
                    return;
                }
            }
        }

        #endregion

        private void set_define_events()
        {
            this.Load += f320_lap_hop_dong_Load;
            //cmd
            m_cmd_lap_hop_dong.Click += m_cmd_lap_hop_dong_Click;
            m_cmd_insert.Click += m_cmd_insert_Click;
            m_cmd_update.Click += m_cmd_update_Click;
            m_cmd_chon_file.Click += m_cmd_chon_file_Click;
            m_cmd_tao_lai.Click += m_cmd_tao_lai_Click;
            //control
            m_sle_loai_hop_dong.EditValueChanged += m_sle_loai_hop_dong_EditValueChanged;
            m_sle_chon_nhan_vien.EditValueChanged += m_sle_chon_nhan_vien_EditValueChanged;
            m_sle_chuc_danh_lns.EditValueChanged += m_sle_chuc_danh_lns_EditValueChanged;
            m_sle_muc_lns.EditValueChanged += m_sle_muc_lns_EditValueChanged;
            m_sle_chuc_danh_lcd.EditValueChanged += m_sle_chuc_danh_lcd_EditValueChanged;
            m_sle_muc_lcd.EditValueChanged += m_sle_muc_lcd_EditValueChanged;
            m_dat_ngay_bat_dau.ValueChanged += m_dat_ngay_bat_dau_ValueChanged;
            //gridcontrol, gridview
            //m_grv_lap_hd.DoubleClick += m_grv_lap_hd_DoubleClick;
            m_cmd_print.Click += m_cmd_print_Click;
        }

        void m_cmd_print_Click(object sender, EventArgs e)
        {
            try
            {
                f326_in_hop_dong v_f = new f326_in_hop_dong();
                v_f.ShowDialog();
                //CWordReport v_cwr = new CWordReport("HD THU VIEC.docx");
                //v_cwr.AddFindAndReplace("<name>", "Huong");
                //v_cwr.Export2Word();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_chon_file_Click(object sender, EventArgs e)
        {
            try
            {
                import_excel();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_grv_lap_hd_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                decimal v_id_gd_hd = 0;
                decimal v_id_gd_lns_lcd = 0;

                v_id_gd_hd = CIPConvert.ToDecimal(m_grv_lap_hd.GetRowCellValue(m_grv_lap_hd.FocusedRowHandle, "ID"));
                v_id_gd_lns_lcd = find_id_gd_lns_lcd(v_id_gd_hd);

                us_obj_2_form(v_id_gd_hd, v_id_gd_lns_lcd);
                m_e_form_mode = DataEntryFormMode.UpdateDataState;
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
                decimal v_id_gd_hd = 0;
                decimal v_id_gd_lns_lcd = 0;

                v_id_gd_hd = CIPConvert.ToDecimal(m_grv_lap_hd.GetRowCellValue(m_grv_lap_hd.FocusedRowHandle, "ID"));
                v_id_gd_lns_lcd = find_id_gd_lns_lcd(v_id_gd_hd);

                us_obj_2_form(v_id_gd_hd, v_id_gd_lns_lcd);
                m_cmd_lap_hop_dong.Enabled = true;
                m_sle_chon_nhan_vien.Enabled = false;
                m_cmd_lap_hop_dong.Text = "Cập nhật hợp đồng";
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
                    clear_data_without_sle_chon_nv_and_grid();
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

        void m_cmd_insert_Click(object sender, EventArgs e)
        {
            try
            {
                m_insert_click = (decimal)MyEnum.NUT_THEM_DUOC_CLICK;
                m_e_form_mode = DataEntryFormMode.InsertDataState;
                clear_data_in_form();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_sle_loai_hop_dong_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (m_sle_loai_hop_dong.EditValue == null || m_sle_loai_hop_dong.EditValue == "")
                {
                    m_gr_LNS.Enabled = true;
                    m_gr_LCD.Enabled = true;

                    m_sle_chuc_danh_lcd.EditValue = null;
                    m_sle_muc_lcd.EditValue = null;
                    m_sle_chuc_danh_lns.EditValue = null;
                    m_sle_muc_lns.EditValue = null;
                    return;
                }

                datetimechange();

                if (CIPConvert.ToDecimal(m_sle_loai_hop_dong.EditValue) == CONST_ID_LOAI_HOP_DONG.HOP_DONG_HOC_VIEC)
                {
                    m_gr_LNS.Enabled = false;
                    m_sle_chuc_danh_lcd.EditValue = CONST_ID_LUONG_CUNG_HSLNS_LCD.MA_LUONG_CUNG_LCD;
                    m_sle_muc_lcd.EditValue = CONST_ID_LUONG_CUNG_HSLNS_LCD.MUC_LUONG_CUNG_LCD;

                    m_gr_LCD.Enabled = false;
                    m_sle_chuc_danh_lns.EditValue = CONST_ID_LUONG_CUNG_HSLNS_LCD.MA_LUONG_CUNG_HS_LNS;
                    m_sle_muc_lns.EditValue = CONST_ID_LUONG_CUNG_HSLNS_LCD.MUC_LUONG_CUNG_HS_LNS;
                    m_loai_hop_dong = (decimal)MyEnum.HOP_DONG_HOC_VIEC;
                }
                else
                {
                    m_gr_LNS.Enabled = true;
                    m_gr_LCD.Enabled = true;
                    m_loai_hop_dong = (decimal)MyEnum.KHAC_HOP_DONG_HOC_VIEC;
                }

            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_lap_hop_dong_Click(object sender, EventArgs e)
        {
            try
            {
                if (!check_data_is_ok())
                {
                    return;
                }
                else
                {
                    load_data_2_m_variable();
                    switch (m_e_form_mode)
                    {
                        case DataEntryFormMode.InsertDataState:
                            if (CHRM_BaseMessages.MsgBox_Confirm(CONST_ID_MSGBOX.QUESTION_XAC_NHAN_LUU_DU_LIEU) == true)
                            {
                                save_data();
                                if (op_str_mess != "-1")
                                {
                                    CHRM_BaseMessages.MsgBox_Infor("Kiểm tra lại dữ liệu nhân viên " + op_str_mess + ".");
                                    return;
                                }
                                else
                                {
                                    CHRM_BaseMessages.MsgBox_Infor(CONST_ID_MSGBOX.INFOR_DU_LIEU_DA_DUOC_CAP_NHAT);
                                }

                                m_trang_thai_buoc_3_thanh_cong = 1;
                                //F500_QUY_TRINH_THEM_MOI_NHAN_SU.done();
                                if (m_trang_thai_them == -1)
                                {
                                    this.Close();
                                }
                                if (m_bool_dieu_chinh_canh_bao)
                                {
                                    this.Close();
                                }
                            }
                            break;
                        case DataEntryFormMode.UpdateDataState:
                            if (CHRM_BaseMessages.MsgBox_Confirm(CONST_ID_MSGBOX.QUESTION_XAC_NHAN_CAP_NHAT_DU_LIEU) == true)
                            {
                                save_data();
                                CHRM_BaseMessages.MsgBox_Infor(CONST_ID_MSGBOX.INFOR_LUU_DU_LIEU_THANH_CONG);
                            }
                            break;
                        default:
                            break;
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

        void f320_lap_hop_dong_Load(object sender, EventArgs e)
        {
            try
            {
                set_initial_form_load();
                m_lan_load_form = (decimal)MyEnum.FORM_DUOC_LOAD_LAN_THU_2_TRO_LEN;
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
                if (m_loai_hop_dong == (decimal)MyEnum.KHAC_HOP_DONG_HOC_VIEC)
                {
                    //if (m_cmd_tao_lai_is_click == (decimal)MyEnum.NUT_TAO_LAI_KHONG_DUOC_CLICK)
                    //{
                    m_sle_muc_lns.EditValue = null;
                    m_lbl_hs_lns.Text = "...";
                    //}
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
                if (m_loai_hop_dong == (decimal)MyEnum.KHAC_HOP_DONG_HOC_VIEC)
                {
                    if (m_lan_load_form == (decimal)MyEnum.FORM_DUOC_LOAD_LAN_THU_2_TRO_LEN)
                    {
                        if (m_cmd_tao_lai_is_click == (decimal)MyEnum.NUT_TAO_LAI_KHONG_DUOC_CLICK)
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
                                    m_lbl_hs_lns.Text = find_hs_lns(CIPConvert.ToDecimal(m_sle_chuc_danh_lns.EditValue), CIPConvert.ToDecimal(m_sle_muc_lns.EditValue)).ToString();
                                }
                            }
                        }
                        else if (m_cmd_tao_lai_is_click == (decimal)MyEnum.NUT_TAO_LAI_DUOC_CLICK)
                        {
                            if (m_sle_muc_lns.EditValue == null || m_sle_muc_lns.EditValue == "")
                            {
                                return;
                            }
                            else
                            {
                                m_lbl_hs_lns.Text = find_hs_lns(CIPConvert.ToDecimal(m_sle_chuc_danh_lns.EditValue), CIPConvert.ToDecimal(m_sle_muc_lns.EditValue)).ToString();
                            }
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
                if (m_loai_hop_dong == (decimal)MyEnum.KHAC_HOP_DONG_HOC_VIEC)
                {
                    //if (m_cmd_tao_lai_is_click == (decimal)MyEnum.NUT_TAO_LAI_KHONG_DUOC_CLICK)
                    //{
                    m_sle_muc_lcd.EditValue = null;
                    m_lbl_so_tien_lcd.Text = "...";
                    //}
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
                if (m_loai_hop_dong == (decimal)MyEnum.KHAC_HOP_DONG_HOC_VIEC)
                {
                    if (m_lan_load_form == (decimal)MyEnum.FORM_DUOC_LOAD_LAN_THU_2_TRO_LEN)
                    {
                        if (m_cmd_tao_lai_is_click == (decimal)MyEnum.NUT_TAO_LAI_KHONG_DUOC_CLICK)
                        {
                            if (m_sle_chuc_danh_lcd.EditValue == null || m_sle_chuc_danh_lcd.EditValue.ToString() == "")
                            {
                                CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_CHUA_CHON_MA_LCD);
                                return;
                            }
                            else
                            {
                                if (m_sle_muc_lcd.EditValue == null || m_sle_muc_lcd.EditValue.ToString() == "")
                                {
                                    return;
                                }
                                else
                                {
                                    m_lbl_so_tien_lcd.Text = find_so_tien_lcd(CIPConvert.ToDecimal(m_sle_chuc_danh_lcd.EditValue), CIPConvert.ToDecimal(m_sle_muc_lcd.EditValue)).ToString("C", CultureInfo.CreateSpecificCulture("vi-VN"));
                                }
                            }
                        }
                        else if (m_cmd_tao_lai_is_click == (decimal)MyEnum.NUT_TAO_LAI_DUOC_CLICK)
                        {
                            if (m_sle_muc_lcd.EditValue == null || m_sle_muc_lcd.EditValue.ToString() == "")
                            {
                                return;
                            }
                            else
                            {
                                m_lbl_so_tien_lcd.Text = find_so_tien_lcd(CIPConvert.ToDecimal(m_sle_chuc_danh_lcd.EditValue), CIPConvert.ToDecimal(m_sle_muc_lcd.EditValue)).ToString("C", CultureInfo.CreateSpecificCulture("vi-VN"));
                            }
                        }
                    }

                }

            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_dat_ngay_bat_dau_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                datetimechange();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_tao_lai_Click(object sender, EventArgs e)
        {
            try
            {
                m_e_form_mode = DataEntryFormMode.InsertDataState;
                m_cmd_tao_lai_is_click = (decimal)MyEnum.NUT_TAO_LAI_DUOC_CLICK;
                m_sle_chon_nhan_vien.Enabled = true;
                m_cmd_lap_hop_dong.Text = "&Lập hợp đồng";
                clear_data_in_form();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
    }
}
