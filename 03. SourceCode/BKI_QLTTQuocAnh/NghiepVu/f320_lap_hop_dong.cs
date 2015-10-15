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
    public partial class f320_lap_hop_dong : Form
    {
        public f320_lap_hop_dong()
        {
            InitializeComponent();
            format_controls();
        }

        #region Public Interface
        private void display()
        {
            this.ShowDialog();
        }
        #endregion

        #region Members
        int m_id_lns_lcd_trong_loai_td = 0; //1: LNS va 2:LCD
        decimal m_loai_hop_dong = 1; //0: hoc viec va 1: Cac loai khac
        decimal m_insert_click = 0; //0: ko an, 1:an
        DataEntryFormMode m_e_form_mode = DataEntryFormMode.InsertDataState;
        decimal m_id_gd_hd = 0;
        decimal m_id_hs_lns = 0;
        decimal m_id_lcd = 0;
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
            load_data_2_sle_loai_hd();
            load_data_2_sle_chuc_danh_lns();
            load_data_2_sle_muc_lns();
            load_data_2_sle_chuc_danh_lcd();
            load_data_2_sle_muc_lcd();
            load_data_2_grid();
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
            CCommon.make_stt(m_grv_lap_hd);

            DS_V_F320_LAP_HOP_DONG v_ds = new DS_V_F320_LAP_HOP_DONG();
            US_V_F320_LAP_HOP_DONG v_us = new US_V_F320_LAP_HOP_DONG();
            //string v_current_date = DateTime.Now.Date.ToShortDateString();

            //v_us.FillDataset(v_ds, "WHERE NGAY_BAT_DAU <= '" + v_current_date + "' AND (NGAY_KET_THUC >= '" + v_current_date + "' OR NGAY_KET_THUC IS NULL)");
            v_us.FillDataset_by_ngay_hien_tai(v_ds, DateTime.Now.Date);

            m_grc_lap_hd.DataSource = v_ds.Tables[0];
        }

        private void load_data_2_grid(decimal ip_dc_id_nhan_vien)
        {
            CCommon.make_stt(m_grv_lap_hd);

            DS_V_F320_LAP_HOP_DONG v_ds = new DS_V_F320_LAP_HOP_DONG();
            US_V_F320_LAP_HOP_DONG v_us = new US_V_F320_LAP_HOP_DONG();
            //string v_current_date = DateTime.Now.Date.ToShortDateString();

            //v_us.FillDataset(v_ds, "WHERE ID_NHAN_VIEN = " + ip_dc_id_nhan_vien + " AND NGAY_BAT_DAU <= '" + v_current_date + "' AND (NGAY_KET_THUC >= '" + v_current_date + "' OR NGAY_KET_THUC IS NULL)");
            v_us.FillDataset_by_ngay_hien_tai(v_ds, ip_dc_id_nhan_vien, DateTime.Now.Date);
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
                m_lbl_kiem_tra_ma_hd.Visible = true;
                m_lbl_kiem_tra_ma_hd.Text = "Đã có mã này rồi...";
                return true;
            }
            else
            {
                m_txt_ma_hd.BackColor = Color.White;
                m_lbl_kiem_tra_ma_hd.Visible = false;
                return false;
            }
        }

        private bool check_data_is_ok()
        {
            if (m_sle_chon_nhan_vien.EditValue == null || m_sle_chon_nhan_vien.EditValue == "")
            {
                MessageBox.Show("Bạn phải chọn nhân viên", "THÔNG BÁO");
                return false;
            }

            if (m_sle_loai_hop_dong.EditValue == null || m_sle_loai_hop_dong.EditValue == "")
            {
                MessageBox.Show("Bạn phải chọn loại hợp đồng", "THÔNG BÁO");
                return false;
            }

            if (m_txt_ma_hd.Text == null)
            {
                MessageBox.Show("Bạn phải điền mã hợp đồng", "THÔNG BÁO");
                return false;
            }

            if (m_loai_hop_dong == 1)
            {
                if (m_sle_muc_lns.EditValue == null || m_sle_muc_lns.EditValue == "")
                {
                    MessageBox.Show("Bạn phải chọn mức lương năng suất", "THÔNG BÁO");
                    return false;
                }

                if (m_sle_muc_lcd.EditValue == null || m_sle_muc_lcd.EditValue == "")
                {
                    MessageBox.Show("Bạn phải chọn mức lương chế độ", "THÔNG BÁO");
                    return false;
                }

                if (m_sle_chuc_danh_lns.EditValue == null || m_sle_chuc_danh_lns.EditValue == "")
                {
                    MessageBox.Show("Bạn phải chọn chức danh để tính lương năng suất", "THÔNG BÁO");
                    return false;
                }

                if (m_sle_chuc_danh_lcd.EditValue == null || m_sle_chuc_danh_lcd.EditValue == "")
                {
                    MessageBox.Show("Bạn phải chọn chức danh để tính lương chế độ", "THÔNG BÁO");
                    return false;
                }
            }

            if (m_dat_ngay_bat_dau.Value.Date == m_dat_ngay_ket_thuc.Value.Date)
            {
                MessageBox.Show("Ngày bắt đầu và ngày kết thúc đang trùng nhau", "THÔNG BÁO");
                return false;
            }

            if (m_e_form_mode == DataEntryFormMode.InsertDataState)
            {
                if (check_ma_hd())
                {
                    return false;
                }
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
                ip_us.datNGAY_KET_THUC = m_dat_ngay_ket_thuc.Value.Date;
                ip_us.datNGAY_KY_HOP_DONG = m_dat_ngay_ky.Value.Date;
                if (m_e_form_mode == DataEntryFormMode.InsertDataState)
                {
                    ip_us.datNGAY_LAP = DateTime.Now.Date;
                    //Nguoi lap
                }
                if (m_e_form_mode == DataEntryFormMode.UpdateDataState)
                {
                    ip_us.datNGAY_SUA = DateTime.Now.Date;
                    //nguoi sua
                }
                ip_us.strDA_XOA = "N";

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
                }
                if (m_e_form_mode == DataEntryFormMode.UpdateDataState)
                {
                    ip_us.datNGAY_SUA = DateTime.Now.Date;
                    //nguoi sua
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
                ip_us.dcID_HOP_DONG = find_id_gd_hd(CIPConvert.ToDecimal(m_sle_chon_nhan_vien.EditValue));
                ip_us.dcHE_SO = CIPConvert.ToDecimal(find_hs_lns(CIPConvert.ToDecimal(m_sle_chuc_danh_lns.EditValue), CIPConvert.ToDecimal(m_sle_muc_lns.EditValue)));
                //ip_us.dcID_LY_DO_CHINH_SUA =
                ip_us.datNGAY_BAT_DAU = m_dat_ngay_bat_dau.Value.Date;
                ip_us.datNGAY_KET_THUC = m_dat_ngay_ket_thuc.Value.Date;

                if (m_e_form_mode == DataEntryFormMode.InsertDataState)
                {
                    ip_us.datNGAY_LAP = DateTime.Now.Date;
                    //Nguoi lap
                }
                if (m_e_form_mode == DataEntryFormMode.UpdateDataState)
                {
                    ip_us.datNGAY_SUA = DateTime.Now.Date;
                    //nguoi sua
                }
                ip_us.strDA_XOA = "N";
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
                ip_us.dcID_HOP_DONG = find_id_gd_hd(CIPConvert.ToDecimal(m_sle_chon_nhan_vien.EditValue));
                ip_us.dcSO_TIEN = CIPConvert.ToDecimal(find_so_tien_lcd(CIPConvert.ToDecimal(m_sle_chuc_danh_lcd.EditValue), CIPConvert.ToDecimal(m_sle_muc_lcd.EditValue)));
                //ip_us.dcID_LY_DO_CHINH_SUA =
                ip_us.datNGAY_BAT_DAU = m_dat_ngay_bat_dau.Value.Date;
                ip_us.datNGAY_KET_THUC = m_dat_ngay_ket_thuc.Value.Date;

                if (m_e_form_mode == DataEntryFormMode.InsertDataState)
                {
                    ip_us.datNGAY_LAP = DateTime.Now.Date;
                    //Nguoi lap
                }
                if (m_e_form_mode == DataEntryFormMode.UpdateDataState)
                {
                    ip_us.datNGAY_SUA = DateTime.Now.Date;
                    //nguoi sua
                }
                ip_us.strDA_XOA = "N";
            }
            catch (Exception v_e)
            {
                throw v_e;
            }
        }

        private void us_obj_2_form(decimal v_id_gd_hd, decimal v_id_gd_lns_lcd)
        {
            US_GD_HOP_DONG v_us_gd_hd = new US_GD_HOP_DONG(v_id_gd_hd);
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

            if (m_e_form_mode == DataEntryFormMode.UpdateDataState)
            {

            }
        }

        private void cho_hop_dong_da_co_ve_trang_thai_delete_Y()
        {
            US_GD_HOP_DONG v_us = new US_GD_HOP_DONG(m_id_gd_hd);

            v_us.strDA_XOA = "Y";
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

            v_us.strDA_XOA = "Y";
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

            v_us.strDA_XOA = "Y";
            v_us.datNGAY_SUA = DateTime.Now.Date;
            //nguoi sua
            v_us.BeginTransaction();
            v_us.Update();
            v_us.CommitTransaction();
        }

        private void save_data()
        {

            US_GD_HOP_DONG v_us_gd_hd = new US_GD_HOP_DONG();
            US_GD_HS_LNS_LCD v_us_gd_hs_lns_lcd = new US_GD_HS_LNS_LCD();
            US_GD_HE_SO_LNS v_us_gd_hs_lns = new US_GD_HE_SO_LNS();
            US_GD_LUONG_CHE_DO v_us_gd_lcd = new US_GD_LUONG_CHE_DO();

            form_2_us_gd_hop_dong(v_us_gd_hd);
            try
            {
                switch (m_e_form_mode)
                {
                    case DataEntryFormMode.InsertDataState:
                        if (m_id_gd_hd != -1)
                        {
                            cho_hop_dong_da_co_ve_trang_thai_delete_Y();
                            cho_gd_hs_lns_lcd_da_xoa_Y();
                            cho_gd_hs_lns_da_xoa_Y();
                            cho_gd_lcd_da_xoa_Y();
                        }

                        //lap hop dong moi
                        v_us_gd_hd.BeginTransaction();
                        v_us_gd_hd.Insert();
                        v_us_gd_hd.CommitTransaction();

                        //insert gd_hs_lns_lcd
                        form_2_us_gd_hs_lns_lcd(v_us_gd_hs_lns_lcd);
                        v_us_gd_hs_lns_lcd.BeginTransaction();
                        v_us_gd_hs_lns_lcd.Insert();
                        v_us_gd_hs_lns_lcd.CommitTransaction();

                        //insert gd_hs_lns
                        form_2_us_gd_hs_lns(v_us_gd_hs_lns);
                        v_us_gd_hs_lns.BeginTransaction();
                        v_us_gd_hs_lns.Insert();
                        v_us_gd_hs_lns.CommitTransaction();

                        //insert gd_lcd
                        form_2_us_gd_lcd(v_us_gd_lcd);
                        v_us_gd_lcd.BeginTransaction();
                        v_us_gd_lcd.Insert();
                        v_us_gd_lcd.CommitTransaction();
                        break;
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
                    default:
                        break;
                }
            }
            catch (Exception v_e)
            {

                throw v_e;
            }
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
            m_sle_chon_nhan_vien.EditValue = null;
            m_txt_ma_hd.Text = "";
            m_lbl_kiem_tra_ma_hd.Visible = false;
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

            DS_V_F320_LAP_HOP_DONG v_ds = new DS_V_F320_LAP_HOP_DONG();
            m_grc_lap_hd.DataSource = v_ds.Tables[0];
        }

        #endregion

        private void set_define_events()
        {
            this.Load += f320_lap_hop_dong_Load;
            //cmd
            m_cmd_lap_hop_dong.Click += m_cmd_lap_hop_dong_Click;
            m_cmd_insert.Click += m_cmd_insert_Click;
            m_cmd_update.Click += m_cmd_update_Click;
            //control
            m_sle_loai_hop_dong.EditValueChanged += m_sle_loai_hop_dong_EditValueChanged;
            m_sle_chon_nhan_vien.EditValueChanged += m_sle_chon_nhan_vien_EditValueChanged;
            m_sle_chuc_danh_lns.EditValueChanged += m_sle_chuc_danh_lns_EditValueChanged;
            m_sle_muc_lns.EditValueChanged += m_sle_muc_lns_EditValueChanged;
            m_sle_chuc_danh_lcd.EditValueChanged += m_sle_chuc_danh_lcd_EditValueChanged;
            m_sle_muc_lcd.EditValueChanged += m_sle_muc_lcd_EditValueChanged;
            //gridcontrol, gridview
            m_grv_lap_hd.DoubleClick += m_grv_lap_hd_DoubleClick;
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

        void m_sle_loai_hop_dong_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (m_sle_loai_hop_dong.EditValue == null || m_sle_loai_hop_dong.EditValue == "")
                {
                    m_gr_LNS.Enabled = true;
                    m_gr_LCD.Enabled = true;
                    return;
                }

                if (CIPConvert.ToDecimal(m_sle_loai_hop_dong.EditValue) == CONST_ID_LOAI_HOP_DONG.HOP_DONG_HOC_VIEC)
                {
                    m_gr_LNS.Enabled = false;
                    m_gr_LCD.Enabled = false;
                    m_loai_hop_dong = 0;
                }
                else
                {
                    m_gr_LNS.Enabled = true;
                    m_gr_LCD.Enabled = true;
                    m_loai_hop_dong = 1;
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
                            if (XtraMessageBox.Show("Bạn có chắc chắn muốn lập hợp đồng này?", "XÁC NHẬN LẠI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                save_data();
                            }
                            break;
                        case DataEntryFormMode.UpdateDataState:
                            if (XtraMessageBox.Show("Bạn có chắc chắn muốn cập nhật hợp đồng này?", "XÁC NHẬN LẠI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                save_data();
                            }
                            break;
                        default:
                            break;
                    }

                    load_data_2_grid(CIPConvert.ToDecimal(m_sle_chon_nhan_vien.EditValue));
                    focus_new_row_created();
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
                if (m_loai_hop_dong == 1)
                {
                    if (m_insert_click == 0)
                    {
                        m_sle_muc_lns.EditValue = null;
                        m_lbl_hs_lns.Text = "...";
                    }
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
                if (m_loai_hop_dong == 1)
                {
                    if (m_insert_click == 0)
                    {
                        if (m_sle_chuc_danh_lns.EditValue == null || m_sle_chuc_danh_lns.EditValue == "")
                        {
                            MessageBox.Show("Bạn phải chọn chức danh để tính lương năng suất", "THÔNG BÁO");
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
                if (m_loai_hop_dong == 1)
                {
                    if (m_insert_click == 0)
                    {
                        m_sle_muc_lcd.EditValue = null;
                        m_lbl_so_tien_lcd.Text = "...";
                    }
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
                if (m_loai_hop_dong == 1)
                {
                    if (m_insert_click == 0)
                    {
                        if (m_sle_chuc_danh_lcd.EditValue == null || m_sle_chuc_danh_lcd.EditValue == "")
                        {
                            MessageBox.Show("Bạn phải chọn chức danh để tính lương chế độ", "THÔNG BÁO");
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
    }
}
