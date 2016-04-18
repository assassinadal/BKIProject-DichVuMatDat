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

namespace BKI_DichVuMatDat.NghiepVu
{
    public partial class f330_len_luong_cho_nv : Form
    {
        public f330_len_luong_cho_nv()
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
        decimal m_insert_click = 0; //0 neu ko an nut them, 1 neu an
        decimal m_id_gd_hd = 0;
        decimal m_id_hs_lns = 0;
        decimal m_id_lcd = 0;
        decimal m_id_gd_hs_lns = 0;
        decimal m_id_gd_lcd = 0;
        #endregion

        #region Private Methods
        private void format_controls()
        {
            FormatControl.SetVisibleSimpleButton(this);
            this.m_grv_tang_giam_luong_cho_nv.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(WinFormControls.m_grv_PopupMenuShowing);
            this.m_grv_tang_giam_luong_cho_nv.OptionsPrint.AutoWidth = false;
            set_define_events();
            this.KeyPreview = true;
        }

        private void set_initial_form_load()
        {
            load_data_2_sle_chon_nv();
            load_data_2_sle_chon_qd();
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
            v_ds.EnforceConstraints = false;
            v_ds.Clear();
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

        private DS_V_GD_QUYET_DINH load_data_2_ds_v_gd_quyet_dinh()
        {
            US_V_GD_QUYET_DINH v_us = new US_V_GD_QUYET_DINH();
            DS_V_GD_QUYET_DINH v_ds = new DS_V_GD_QUYET_DINH();

            v_us.FillDataset(v_ds);
            return v_ds;
        }

        private void load_data_2_sle_chon_qd()
        {
            m_sle_chon_quyet_dinh.Properties.DataSource = load_data_2_ds_v_gd_quyet_dinh().V_GD_QUYET_DINH;
            m_sle_chon_quyet_dinh.Properties.DisplayMember = V_GD_QUYET_DINH.MA_QUYET_DINH;
            m_sle_chon_quyet_dinh.Properties.ValueMember = V_GD_QUYET_DINH.ID;

            m_sle_chon_quyet_dinh.Properties.PopulateViewColumns();
            m_sle_chon_quyet_dinh.Properties.View.Columns[V_GD_QUYET_DINH.ID].Visible = false;
            m_sle_chon_quyet_dinh.Properties.View.Columns[V_GD_QUYET_DINH.ID_LOAI_QD].Visible = false;
            m_sle_chon_quyet_dinh.Properties.View.Columns[V_GD_QUYET_DINH.MA_TU_DIEN].Visible = false;
            m_sle_chon_quyet_dinh.Properties.View.Columns[V_GD_QUYET_DINH.TEN_NGAN].Visible = false;

            m_sle_chon_quyet_dinh.Properties.View.Columns[V_GD_QUYET_DINH.MA_QUYET_DINH].Caption = "Mã quyết định";
            m_sle_chon_quyet_dinh.Properties.View.Columns[V_GD_QUYET_DINH.TEN].Caption = "Loại quyết định";
            m_sle_chon_quyet_dinh.Properties.View.Columns[V_GD_QUYET_DINH.NGAY_CO_HIEU_LUC].Caption = "Ngày có hiệu lực";
            m_sle_chon_quyet_dinh.Properties.View.Columns[V_GD_QUYET_DINH.NGAY_HET_HIEU_LUC].Caption = "Ngày hết hiệu lực";
            m_sle_chon_quyet_dinh.Properties.View.Columns[V_GD_QUYET_DINH.NGUOI_KY].Caption = "Người ký";
            m_sle_chon_quyet_dinh.Properties.View.Columns[V_GD_QUYET_DINH.NGAY_KY].Caption = "Ngày ký";
            m_sle_chon_quyet_dinh.Properties.View.Columns[V_GD_QUYET_DINH.NOI_DUNG].Caption = "Nội dung";
            m_sle_chon_quyet_dinh.Properties.View.Columns[V_GD_QUYET_DINH.LINK].Caption = "Link";

            m_sle_chon_quyet_dinh.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            //m_sle_chon_quyet_dinh.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
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
            CHRMCommon.make_stt(m_grv_tang_giam_luong_cho_nv);
            US_V_F330_LEN_LUONG_CHO_NV v_us = new US_V_F330_LEN_LUONG_CHO_NV();
            DS_V_F330_LEN_LUONG_CHO_NV v_ds = new DS_V_F330_LEN_LUONG_CHO_NV();

            v_us.FillDataset(v_ds);

            m_grc_tang_giam_luong_cho_nv.DataSource = v_ds.Tables[0];
            m_grv_tang_giam_luong_cho_nv.BestFitColumns();
        }

        private void load_data_2_grid(decimal ip_dc_id_nv)
        {
            CHRMCommon.make_stt(m_grv_tang_giam_luong_cho_nv);
            US_V_F330_LEN_LUONG_CHO_NV v_us = new US_V_F330_LEN_LUONG_CHO_NV();
            DS_V_F330_LEN_LUONG_CHO_NV v_ds = new DS_V_F330_LEN_LUONG_CHO_NV();

            v_us.FillDataset(v_ds, "WHERE ID = " + ip_dc_id_nv);

            m_grc_tang_giam_luong_cho_nv.DataSource = v_ds.Tables[0];
            m_grv_tang_giam_luong_cho_nv.BestFitColumns();
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
                CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_CHUA_CHON_NHAN_VIEN);
                return false;
            }

            /*if (m_sle_chon_quyet_dinh.EditValue == null || m_sle_chon_quyet_dinh.EditValue.ToString() == "")
            {
                MessageBox.Show("Bạn phải chọn quyết định", "THÔNG BÁO");
                return false;
            }

            if (m_sle_chon_quyet_dinh.EditValue == null || m_sle_chon_quyet_dinh.EditValue.ToString() == "")
            {
                MessageBox.Show("Bạn phải chọn quyết định", "THÔNG BÁO");
                return false;
            }*/
            //if (m_sle_chon_quyet_dinh.EditValue == null || m_sle_chon_quyet_dinh.EditValue == "")
            //{
            //    DevExpress.XtraEditors.XtraMessageBox.Show("Bạn phải chọn quyết định", "THÔNG BÁO");
            //    return false;
            //}

            //if (m_sle_chon_quyet_dinh.EditValue == null || m_sle_chon_quyet_dinh.EditValue == "")
            //{
            //    DevExpress.XtraEditors.XtraMessageBox.Show("Bạn phải chọn quyết định", "THÔNG BÁO");
            //    return false;
            //}

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
            catch (Exception v_e)
            {
                throw v_e;
            }
        }

        private void load_data_2_m_variable()
        {
            m_id_gd_hd = find_id_hd(CIPConvert.ToDecimal(m_sle_chon_nhan_vien.EditValue));
            m_id_hs_lns = find_id_hs_lns(CIPConvert.ToDecimal(m_sle_chuc_danh_lns.EditValue), CIPConvert.ToDecimal(m_sle_muc_lns.EditValue));
            m_id_lcd = find_id_lcd(CIPConvert.ToDecimal(m_sle_chuc_danh_lcd.EditValue), CIPConvert.ToDecimal(m_sle_muc_lcd.EditValue));
            m_id_gd_hs_lns = find_id_gd_hs_lns(m_id_gd_hd);
            m_id_gd_lcd = find_id_gd_lcd(m_id_gd_hd);
        }

        private void form_2_us_gd_hs_lns_lcd(US_GD_HS_LNS_LCD ip_us)
        {

            if (m_sle_chon_quyet_dinh.EditValue != null && m_sle_chon_quyet_dinh.EditValue != "")
            {
                ip_us.dcID_QUYET_DINH = CIPConvert.ToDecimal(m_sle_chon_quyet_dinh.EditValue);
            }

            ip_us.dcID_HOP_DONG = m_id_gd_hd;
            ip_us.dcID_HS_LNS = m_id_hs_lns;
            ip_us.dcID_LCD = m_id_lcd;
            if (m_e_form_mode == DataEntryFormMode.InsertDataState)
            {
                ip_us.datNGAY_LAP = DateTime.Now.Date;
                //nguoi lap
                ip_us.strNGUOI_LAP = CAppContext_201.getCurrentUserName();
            }
            else if (m_e_form_mode == DataEntryFormMode.UpdateDataState)
            {
                ip_us.datNGAY_SUA = DateTime.Now.Date;
                //nguoi sua
                ip_us.strNGUOI_SUA = CAppContext_201.getCurrentUserName();
            }
            ip_us.strDA_XOA = "N";
        }

        private void form_2_us_gd_hs_lns(US_GD_HE_SO_LNS ip_us)
        {
            //US_V_GD_QUYET_DINH v_us = new US_V_GD_QUYET_DINH(CIPConvert.ToDecimal(m_sle_chon_quyet_dinh.EditValue));
            //ip_us.dcID_HOP_DONG = m_id_gd_hd;
            ip_us.dcHE_SO = CIPConvert.ToDecimal(find_hs_lns(CIPConvert.ToDecimal(m_sle_chuc_danh_lns.EditValue), CIPConvert.ToDecimal(m_sle_muc_lns.EditValue)));
            //ip_us.dcID_LY_DO_CHINH_SUA =
            //so sanh gia tri ngay bat dau, ngay ket thuc vs ngay co hieu luc, ngay het hieu luc cua quyet dinh
            if (!m_dat_ngay_ket_thuc_lns.Checked)
            {
                ip_us.datNGAY_KET_THUC = m_dat_ngay_bat_dau_lns.Value.AddYears(45);
            }
            else
            {
                ip_us.datNGAY_KET_THUC = m_dat_ngay_ket_thuc_lns.Value;             
            }
            ip_us.datNGAY_BAT_DAU = m_dat_ngay_bat_dau_lns.Value;
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
            //US_V_GD_QUYET_DINH v_us = new US_V_GD_QUYET_DINH(CIPConvert.ToDecimal(m_sle_chon_quyet_dinh.EditValue));
            //ip_us.dcID_HOP_DONG = m_id_gd_hd;
            ip_us.dcSO_TIEN = CIPConvert.ToDecimal(find_so_tien_lcd(CIPConvert.ToDecimal(m_sle_chuc_danh_lcd.EditValue), CIPConvert.ToDecimal(m_sle_muc_lcd.EditValue)));
            //ip_us.dcID_LY_DO_CHINH_SUA =
            //so sanh gia tri ngay bat dau, ngay ket thuc vs ngay co hieu luc, ngay het hieu luc cua quyet dinh
            ip_us.datNGAY_BAT_DAU = m_dat_ngay_bat_dau_lcd.Value;
            if (!m_dat_ngay_ket_thuc_lcd.Checked)
            {
                ip_us.datNGAY_KET_THUC = m_dat_ngay_bat_dau_lns.Value.AddYears(45);
            }
            else
            {
                ip_us.datNGAY_KET_THUC = m_dat_ngay_ket_thuc_lcd.Value;
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

        private void cho_gd_hs_lns_lcd_da_co_da_xoa_Y()
        {
            decimal v_id_gd_hs_lns_lcd = 0;
            v_id_gd_hs_lns_lcd = find_id_gd_lns_lcd(CIPConvert.ToDecimal(m_id_gd_hd));

            US_GD_HS_LNS_LCD v_us = new US_GD_HS_LNS_LCD(v_id_gd_hs_lns_lcd);
            v_us.dcID = v_id_gd_hs_lns_lcd;
            v_us.strDA_XOA = "Y";
            try
            {
                v_us.BeginTransaction();
                v_us.Update();
                v_us.CommitTransaction();
            }
            catch (Exception v_e)
            {
                throw v_e;
            }
        }

        private void cho_gd_hs_lns_da_co_da_xoa_Y()
        {
            US_GD_HE_SO_LNS v_us = new US_GD_HE_SO_LNS(m_id_gd_hs_lns);

            v_us.datNGAY_KET_THUC = m_dat_ngay_bat_dau_lns.Value.AddDays(-1);
            try
            {
                v_us.BeginTransaction();
                v_us.Update();
                v_us.CommitTransaction();
            }
            catch (Exception v_e)
            {
                throw v_e;
            }
        }

        private void cho_gd_lcd_da_co_da_xoa_Y()
        {
            US_GD_LUONG_CHE_DO v_us = new US_GD_LUONG_CHE_DO(m_id_gd_lcd);
            v_us.datNGAY_KET_THUC = m_dat_ngay_bat_dau_lcd.Value.AddDays(-1);
            try
            {
                v_us.BeginTransaction();
                v_us.Update();
                v_us.CommitTransaction();
            }
            catch (Exception v_e)
            {
                throw v_e;
            }
        }

        private void save_data()
        {
            US_GD_HS_LNS_LCD v_us_gd_hs_lns_lcd = new US_GD_HS_LNS_LCD();
            US_GD_HE_SO_LNS v_us_gd_hs_lns = new US_GD_HE_SO_LNS();
            US_GD_LUONG_CHE_DO v_us_gd_lcd = new US_GD_LUONG_CHE_DO();

            form_2_us_gd_hs_lns_lcd(v_us_gd_hs_lns_lcd);
            form_2_us_gd_hs_lns(v_us_gd_hs_lns);
            form_2_us_gd_lcd(v_us_gd_lcd);
            try
            {
                switch (m_e_form_mode)
                {
                    case DataEntryFormMode.InsertDataState:
                        //Cho gd_hs_lns_lcd da xoa = Y
                        cho_gd_hs_lns_lcd_da_co_da_xoa_Y();

                        //insert gd_hs_lns_lcd
                        v_us_gd_hs_lns_lcd.BeginTransaction();
                        v_us_gd_hs_lns_lcd.Insert();
                        v_us_gd_hs_lns_lcd.CommitTransaction();

                        //insert gd_hs_lns
                        cho_gd_hs_lns_da_co_da_xoa_Y();
                        v_us_gd_hs_lns.BeginTransaction();
                        v_us_gd_hs_lns.Insert();
                        v_us_gd_hs_lns.CommitTransaction();

                        //insert gd_lcd
                        cho_gd_lcd_da_co_da_xoa_Y();
                        v_us_gd_lcd.BeginTransaction();
                        v_us_gd_lcd.Insert();
                        v_us_gd_lcd.CommitTransaction();
                        break;
                    case DataEntryFormMode.UpdateDataState:
                        break;
                    default:
                        break;
                }
            }
            catch (Exception v_e)
            {
                v_us_gd_hs_lns.Rollback();
                v_us_gd_lcd.Rollback();
                v_us_gd_hs_lns_lcd.Rollback();
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void focus_new_row_created()
        {
            int v_row_index = 0;
            decimal v_id_hs_lns_hien_tai_f330 = 0;
            decimal v_id_lcd_hien_tai_f330 = 0;

            US_V_F330_LEN_LUONG_CHO_NV v_us = new US_V_F330_LEN_LUONG_CHO_NV();
            DS_V_F330_LEN_LUONG_CHO_NV v_ds = new DS_V_F330_LEN_LUONG_CHO_NV();

            v_id_hs_lns_hien_tai_f330 = find_id_hs_lns(CIPConvert.ToDecimal(m_sle_chuc_danh_lns.EditValue), CIPConvert.ToDecimal(m_sle_muc_lns.EditValue));
            v_id_lcd_hien_tai_f330 = find_id_lcd(CIPConvert.ToDecimal(m_sle_chuc_danh_lcd.EditValue), CIPConvert.ToDecimal(m_sle_muc_lcd.EditValue));

            v_us.FillDataset(v_ds);

            for (v_row_index = 0; v_row_index < v_ds.Tables[0].Rows.Count; v_row_index++)
            {
                var v_gd_hs_lns_grv = CIPConvert.ToDecimal(m_grv_tang_giam_luong_cho_nv.GetDataRow(v_row_index)["ID_HS_LNS"].ToString());
                var v_gd_lcd_grv = CIPConvert.ToDecimal(m_grv_tang_giam_luong_cho_nv.GetDataRow(v_row_index)["ID_LCD"].ToString());
                var v_gd_hd_grv = CIPConvert.ToDecimal(m_grv_tang_giam_luong_cho_nv.GetDataRow(v_row_index)["ID_HOP_DONG"].ToString());

                if (v_gd_hs_lns_grv == v_id_hs_lns_hien_tai_f330 && v_gd_lcd_grv == v_id_lcd_hien_tai_f330 && v_gd_hd_grv == m_id_gd_hd)
                {
                    break;
                }
            }

            m_grv_tang_giam_luong_cho_nv.FocusedRowHandle = v_row_index;
        }

        //clear data in form
        private void clear_data_in_form()
        {
            m_sle_chon_nhan_vien.EditValue = null;
            m_sle_chon_quyet_dinh.EditValue = null;
            m_lbl_hs_lns.Text = "...";
            m_lbl_so_tien_lcd.Text = "...";
            m_sle_chuc_danh_lns.EditValue = null;
            m_sle_muc_lns.EditValue = null;
            m_sle_chuc_danh_lcd.EditValue = null;
            m_sle_muc_lcd.EditValue = null;
            m_lbl_hs_lns.Text = "...";
            m_lbl_so_tien_lcd.Text = "...";

            DS_V_F330_LEN_LUONG_CHO_NV v_ds = new DS_V_F330_LEN_LUONG_CHO_NV();
            m_grc_tang_giam_luong_cho_nv.DataSource = v_ds.Tables[0];
        }
        #endregion
        private void set_define_events()
        {
            this.Load += f330_len_luong_cho_nv_Load;
            //cmd
            m_cmd_len_luong_cho_nv.Click += m_cmd_len_luong_cho_nv_Click;
            m_cmd_insert.Click += m_cmd_insert_Click;
            //control
            m_sle_chon_nhan_vien.EditValueChanged += m_sle_chon_nhan_vien_EditValueChanged;
            m_sle_chuc_danh_lns.EditValueChanged += m_sle_chuc_danh_lns_EditValueChanged;
            m_sle_muc_lns.EditValueChanged += m_sle_muc_lns_EditValueChanged;
            m_sle_chuc_danh_lcd.EditValueChanged += m_sle_chuc_danh_lcd_EditValueChanged;
            m_sle_muc_lcd.EditValueChanged += m_sle_muc_lcd_EditValueChanged;
            //gridcontrol, gridview
        }

        void f330_len_luong_cho_nv_Load(object sender, EventArgs e)
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

        void m_cmd_len_luong_cho_nv_Click(object sender, EventArgs e)
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
                            if (CHRM_BaseMessages.MsgBox_Confirm(CONST_ID_MSGBOX.QUESTION_XAC_NHAN_LEN_LUONG_CHO_NHAN_VIEN) == true)
                            {
                                save_data();
                            }
                            break;
                        case DataEntryFormMode.UpdateDataState:
                            break;
                        default:
                            break;
                    }

                    load_data_2_grid(CIPConvert.ToDecimal(m_sle_chon_nhan_vien.EditValue));
                    focus_new_row_created();

                    //gridView6.OptionsNavigation.AutoFocusNewRow = true; focus hàng cuối cùng -- chú ý làm lại
                }
                //clear_data_in_form();
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
                if (m_insert_click == 0)
                {
                    m_sle_muc_lns.EditValue = null;
                    m_lbl_hs_lns.Text = "...";
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
                            m_lbl_hs_lns.Text = find_hs_lns(CIPConvert.ToDecimal(m_sle_chuc_danh_lns.EditValue), CIPConvert.ToDecimal(m_sle_muc_lns.EditValue)).ToString();
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
                if (m_insert_click == 0)
                {
                    m_sle_muc_lcd.EditValue = null;
                    m_lbl_so_tien_lcd.Text = "...";
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
                            m_lbl_so_tien_lcd.Text = find_so_tien_lcd(CIPConvert.ToDecimal(m_sle_chuc_danh_lcd.EditValue), CIPConvert.ToDecimal(m_sle_muc_lcd.EditValue)).ToString("C", CultureInfo.CreateSpecificCulture("vi-VN"));
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
