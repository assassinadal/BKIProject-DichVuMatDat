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
    public partial class f340_dat_hs_lns_lcd : Form
    {
        public f340_dat_hs_lns_lcd()
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
        DataEntryFormMode m_e_form_mode = DataEntryFormMode.InsertDataState;
        decimal m_id_gd_hd = 0;
        decimal m_id_gd_hs_lns_lcd_hien_tai = 0;
        decimal m_id_hs_lns_hien_tai = 0;
        decimal m_id_lcd_hien_tai = 0;
        #endregion

        #region Private methods
        private void format_controls()
        {
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

        private void load_data_2_grc_hs_lns(decimal ip_dc_id_nhan_vien)
        {
            CCommon.make_stt(grv_hs_lns);
            DS_V_F340_DAT_HS_LNS v_ds = new DS_V_F340_DAT_HS_LNS();
            US_V_F340_DAT_HS_LNS v_us = new US_V_F340_DAT_HS_LNS();

            v_us.FillDataset(v_ds, "WHERE ID = " + ip_dc_id_nhan_vien);

            grc_hs_lns.DataSource = v_ds.Tables[0];
        }

        private void load_data_2_grc_lcd(decimal ip_dc_id_nhan_vien)
        {
            CCommon.make_stt(grv_lcd);
            DS_V_F340_DAT_LCD v_ds = new DS_V_F340_DAT_LCD();
            US_V_F340_DAT_LCD v_us = new US_V_F340_DAT_LCD();

            v_us.FillDataset(v_ds, "WHERE ID = " + ip_dc_id_nhan_vien);

            grc_lcd.DataSource = v_ds.Tables[0];
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
        private bool check_data_is_ok()
        {
            if (m_sle_chon_nhan_vien.EditValue == null || m_sle_chon_nhan_vien.EditValue == "")
            {
                MessageBox.Show("Bạn phải chọn nhân viên", "THÔNG BÁO");
                return false;
            }

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
            //ly do chinh sua hs lns

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
            //ly do chinh sua so tien lcd

            if (m_dat_ngay_bat_dau_lns.Value.Date == m_dat_ngay_ket_thuc_lns.Value.Date)
            {
                MessageBox.Show("Ngày bắt đầu và ngày kết thúc đang trùng nhau", "THÔNG BÁO");
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

        private decimal find_id_lcd_hien_tai(decimal ip_dc_id_gd_hd)
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

        }

        private void form_2_us_hs_lns(US_GD_HE_SO_LNS ip_us)
        {
            ip_us.dcID_HOP_DONG = m_id_gd_hd;
            ip_us.dcHE_SO = CIPConvert.ToDecimal(m_txt_hs_lns.Text.Trim()); ;
            ip_us.dcID_LY_DO_CHINH_SUA = CIPConvert.ToDecimal(m_sle_chon_ly_do_chinh_sua_hs_lns.EditValue);
            ip_us.datNGAY_BAT_DAU = m_dat_ngay_bat_dau_lns.Value.Date;
            ip_us.datNGAY_KET_THUC = m_dat_ngay_ket_thuc_lns.Value.Date;
            ip_us.strGHI_CHU = m_txt_ghi_chu_hs_lns.Text;
            ip_us.strDA_XOA = "N";
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

        }

        private void form_2_us_lcd(US_GD_LUONG_CHE_DO ip_us)
        {
            ip_us.dcID_HOP_DONG = m_id_gd_hd;
            ip_us.dcSO_TIEN = CIPConvert.ToDecimal(m_txt_so_tien_lcd.Text.Trim()); ;
            ip_us.dcID_LY_DO_CHINH_SUA = CIPConvert.ToDecimal(m_sle_chon_ly_do_chinh_sua_hs_lns.EditValue);
            ip_us.datNGAY_BAT_DAU = m_dat_ngay_bat_dau_lns.Value.Date;
            ip_us.datNGAY_KET_THUC = m_dat_ngay_ket_thuc_lns.Value.Date;
            ip_us.strGHI_CHU = m_txt_ghi_chu_hs_lns.Text;
            ip_us.strDA_XOA = "N";
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
        }

        private void load_data_hs_lns_lcd_now_2_form(decimal m_id_gd_hs_lns_lcd_hien_tai, decimal m_id_hs_lns_hien_tai, decimal m_id_lcd_hien_tai)
        {
           
        }

        private void save_data()
        {
            US_GD_HE_SO_LNS v_us_hs_lns = new US_GD_HE_SO_LNS();
            US_GD_LUONG_CHE_DO v_us_lcd = new US_GD_LUONG_CHE_DO();

            form_2_us_hs_lns(v_us_hs_lns);
            form_2_us_lcd(v_us_lcd);

        }

        #endregion

        private void set_define_events()
        {
            this.Load += f340_dat_hs_lns_lcd_Load;
            //cmd
            m_cmd_dat_gia_tri.Click += m_cmd_dat_gia_tri_Click;
            //control
            m_sle_chon_nhan_vien.EditValueChanged += m_sle_chon_nhan_vien_EditValueChanged;
            m_sle_muc_lns.EditValueChanged += m_sle_muc_lns_EditValueChanged;
            m_sle_muc_lcd.EditValueChanged += m_sle_muc_lcd_EditValueChanged;
            //gridview, gridcontrol
        }

        void f340_dat_hs_lns_lcd_Load(object sender, EventArgs e)
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

        void m_cmd_dat_gia_tri_Click(object sender, EventArgs e)
        {
            try
            {
                if (!check_data_is_ok())
                {
                    return;
                }
                else
                {

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
                    load_data_2_grc_hs_lns(CIPConvert.ToDecimal(m_sle_chon_nhan_vien.EditValue));
                    load_data_2_grc_lcd(CIPConvert.ToDecimal(m_sle_chon_nhan_vien.EditValue));
                }
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
                    return;
                }
                load_data_2_m_variable();
                load_data_2_grc_hs_lns(CIPConvert.ToDecimal(m_sle_chon_nhan_vien.EditValue));
                load_data_2_grc_lcd(CIPConvert.ToDecimal(m_sle_chon_nhan_vien.EditValue));

                load_data_hs_lns_lcd_now_2_form(m_id_gd_hs_lns_lcd_hien_tai, m_id_hs_lns_hien_tai, m_id_lcd_hien_tai);
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

                if (m_sle_chuc_danh_lns.EditValue == null || m_sle_chuc_danh_lns.EditValue == "")
                {
                    MessageBox.Show("Bạn phải chọn chức danh để tính lương năng suất", "THÔNG BÁO");
                    return;
                }
                else
                {
                    m_txt_hs_lns.Text = find_hs_lns(CIPConvert.ToDecimal(m_sle_chuc_danh_lns.EditValue), CIPConvert.ToDecimal(m_sle_muc_lns.EditValue)).ToString();
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
                if (m_sle_chuc_danh_lcd.EditValue == null || m_sle_chuc_danh_lcd.EditValue == "")
                {
                    MessageBox.Show("Bạn phải chọn chức danh để tính lương chế độ", "THÔNG BÁO");
                    return;
                }
                else
                {
                    m_txt_so_tien_lcd.Text = find_so_tien_lcd(CIPConvert.ToDecimal(m_sle_chuc_danh_lcd.EditValue), CIPConvert.ToDecimal(m_sle_muc_lcd.EditValue)).ToString("C", CultureInfo.CreateSpecificCulture("vi-VN"));
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
    }
}
