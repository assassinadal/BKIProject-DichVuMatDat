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
using BKI_DichVuMatDat.DS.CDBNames;

using System.Globalization;
using DevExpress.XtraEditors;
using IP.Core.IPCommon;
using IP.Core.IPSystemAdmin;

namespace BKI_DichVuMatDat.NghiepVu
{
    public partial class f361_quan_ly_quyet_dinh_de : Form
    {
        public f361_quan_ly_quyet_dinh_de()
        {
            InitializeComponent();
            format_controll();
        }

        #region members

        DataEntryFormMode m_e_form_mode = DataEntryFormMode.InsertDataState;

        #endregion

        #region private methods

        public void display_4_update(decimal ip_us)
        {
            us_2_form(ip_us);
            m_e_form_mode = DataEntryFormMode.UpdateDataState;

            Text = "F361 - Sửa quyết định";
            m_lbl_header.Text = "SỬA QUYẾT ĐỊNH";
            this.ShowDialog();
        }

        public void display_4_insert()
        {
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            Text = "F361 - Thêm mới quyết định";
            m_lbl_header.Text = "THÊM MỚI QUYẾT ĐỊNH";

            this.ShowDialog();
        }

        private void format_controll()
        {
            FormatControl.SetVisibleSimpleButton(this);
            set_define_events();
            this.CenterToScreen();
            this.KeyPreview = true;
        }

        private void set_init_form_load()
        {
            load_data_2_sle_chon_quyet_dinh();
        }

        private void load_data_2_sle_chon_quyet_dinh()
        {

            m_sle_loai_quyet_dinh.Properties.DataSource = load_data_2_cm_dm_tu_dien(CONST_ID_LOAI_TU_DIEN.LOAI_QUYET_DINH).CM_DM_TU_DIEN;
            m_sle_loai_quyet_dinh.Properties.ValueMember = CM_DM_TU_DIEN.ID;
            m_sle_loai_quyet_dinh.Properties.DisplayMember = CM_DM_TU_DIEN.TEN;

            m_sle_loai_quyet_dinh.Properties.PopulateViewColumns();
            m_sle_loai_quyet_dinh.Properties.View.Columns[CM_DM_TU_DIEN.ID].Visible = false;
            m_sle_loai_quyet_dinh.Properties.View.Columns[CM_DM_TU_DIEN.ID_LOAI_TU_DIEN].Visible = false;
            m_sle_loai_quyet_dinh.Properties.View.Columns[CM_DM_TU_DIEN.TEN_NGAN].Visible = false;

            m_sle_loai_quyet_dinh.Properties.View.Columns[CM_DM_TU_DIEN.MA_TU_DIEN].Width = 75;
            m_sle_loai_quyet_dinh.Properties.View.Columns[CM_DM_TU_DIEN.TEN].Width = 120;

            m_sle_loai_quyet_dinh.Properties.View.Columns[CM_DM_TU_DIEN.MA_TU_DIEN].Caption = "Mã loại quyết định";
            m_sle_loai_quyet_dinh.Properties.View.Columns[CM_DM_TU_DIEN.TEN].Caption = "Loại quyết định";
            m_sle_loai_quyet_dinh.Properties.View.Columns[CM_DM_TU_DIEN.GHI_CHU].Caption = "Ghi chú";

            m_sle_loai_quyet_dinh.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            m_sle_loai_quyet_dinh.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
        }

        private DS_CM_DM_TU_DIEN load_data_2_cm_dm_tu_dien(int m_id_lns_lcd_trong_loai_td)
        {
            DS_CM_DM_TU_DIEN v_ds = new DS_CM_DM_TU_DIEN();
            US_CM_DM_TU_DIEN v_us = new US_CM_DM_TU_DIEN();

            v_us.FillDatasetByIdLoaiTuDien(v_ds, m_id_lns_lcd_trong_loai_td);

            return v_ds;
        }

        private void save_data()
        {
            US_GD_QUYET_DINH v_us_gd_qd = new US_GD_QUYET_DINH();

            form_2_us_gd_qd(v_us_gd_qd);
            switch (m_e_form_mode)
            {
                case DataEntryFormMode.InsertDataState:
                    v_us_gd_qd.BeginTransaction();
                    v_us_gd_qd.Insert();
                    v_us_gd_qd.CommitTransaction();
                    break;
                case DataEntryFormMode.UpdateDataState:
                    v_us_gd_qd.BeginTransaction();
                    v_us_gd_qd.Update();
                    v_us_gd_qd.CommitTransaction();
                    break;
                default:
                    break;
            }
        }

        private void form_2_us_gd_qd(US_GD_QUYET_DINH ip_us)
        {
            ip_us.dcID_LOAI_QD = CIPConvert.ToDecimal(m_sle_loai_quyet_dinh.EditValue);
            ip_us.strMA_QUYET_DINH = m_txt_ma_qd.Text.Trim();
            ip_us.datNGAY_CO_HIEU_LUC = m_dat_ngay_co_hieu_luc.DateTime.Date;
            ip_us.datNGAY_HET_HIEU_LUC = m_dat_ngay_het_hieu_luc.DateTime.Date;
            ip_us.datNGAY_KY = m_dat_ngay_ky.DateTime.Date;
            ip_us.strNGUOI_KY = m_txt_nguoi_ky.Text;
            ip_us.strNOI_DUNG = m_txt_noi_dung.Text;
            ip_us.strLINK = m_txt_link.Text.Trim();
        }

        private void us_2_form(decimal ip_dc_id_gd_qd)
        {
            US_V_GD_QUYET_DINH v_us = new US_V_GD_QUYET_DINH(ip_dc_id_gd_qd);

            m_sle_loai_quyet_dinh.EditValue = v_us.dcID_LOAI_QD;
            m_txt_ma_qd.Text = v_us.strMA_QUYET_DINH;
            m_dat_ngay_co_hieu_luc.EditValue = v_us.datNGAY_CO_HIEU_LUC;
            m_dat_ngay_het_hieu_luc.EditValue = v_us.datNGAY_HET_HIEU_LUC;
            m_dat_ngay_ky.EditValue = v_us.datNGAY_KY;
            m_txt_nguoi_ky.Text = v_us.strNGUOI_KY;
            m_txt_noi_dung.Text = v_us.strNOI_DUNG;
            m_txt_link.Text = v_us.strLINK;
        }

        private bool check_data_is_ok()
        {
            if (m_sle_loai_quyet_dinh.EditValue == null || m_sle_loai_quyet_dinh.EditValue == "")
            {
                CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_CHUA_CHON_LOAI_QUYET_DINH);
                return false;
            }
            if (m_txt_ma_qd.Text.Trim() == "")
            {
                CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_CHUA_NHAP_MA_QUYET_DINH);
                return false;
            }
            if (m_e_form_mode == DataEntryFormMode.InsertDataState)
            {
                if (check_ma_qd())
                {
                    return false;
                }
            }
            return true;
        }

        private bool check_ma_qd()
        {
            DS_GD_QUYET_DINH v_ds = new DS_GD_QUYET_DINH();
            US_GD_QUYET_DINH v_us = new US_GD_QUYET_DINH();

            v_us.FillDataset(v_ds);

            string v_str_filter = "";
            v_str_filter = "MA_QUYET_DINH = '" + m_txt_ma_qd.Text + "'";

            DataRow[] v_dr = v_ds.GD_QUYET_DINH.Select(v_str_filter);

            if (v_dr.Count() != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        // EVENTS

        private void set_define_events()
        {
            this.Load += F361_quan_ly_quyet_dinh_de_Load;
            m_cmd_save.Click += M_cmd_save_Click;
        }

        private void M_cmd_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (!check_data_is_ok())
                {
                    return;
                }
                else
                {
                    save_data();
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void F361_quan_ly_quyet_dinh_de_Load(object sender, EventArgs e)
        {
            try
            {
                set_init_form_load();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }


    }
}
