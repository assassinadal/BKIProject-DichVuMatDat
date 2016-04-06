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
    public partial class f360_quan_ly_quyet_dinh : Form
    {
        public f360_quan_ly_quyet_dinh()
        {
            InitializeComponent();
            format_control();
        }

        #region Public Interface
        private void display()
        {
            this.ShowDialog();
        }

        #endregion

        #region Members
        DataEntryFormMode m_e_form_mode = DataEntryFormMode.InsertDataState;
        #endregion

        #region Private methods
        private void format_control()
        {
            FormatControl.SetVisibleSimpleButton(this);
            this.m_grv_quyet_dinh.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(WinFormControls.m_grv_PopupMenuShowing);
            this.m_grv_quyet_dinh.OptionsPrint.AutoWidth = false;
            set_define_events();
            this.KeyPreview = true;
        }

        private void set_initial_form_load()
        {
            load_data_2_sle_chon_quyet_dinh();
            load_data_2_grid();
        }
        //load data control
        private DS_CM_DM_TU_DIEN load_data_2_cm_dm_tu_dien(int m_id_lns_lcd_trong_loai_td)
        {
            DS_CM_DM_TU_DIEN v_ds = new DS_CM_DM_TU_DIEN();
            US_CM_DM_TU_DIEN v_us = new US_CM_DM_TU_DIEN();

            v_us.FillDatasetByIdLoaiTuDien(v_ds, m_id_lns_lcd_trong_loai_td);

            return v_ds;
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

        private void load_data_2_grid()
        {
            CHRMCommon.make_stt(m_grv_quyet_dinh);
            US_V_GD_QUYET_DINH v_us = new US_V_GD_QUYET_DINH();
            DS_V_GD_QUYET_DINH v_ds = new DS_V_GD_QUYET_DINH();
            v_us.FillDataset(v_ds);

            m_grc_quyet_dinh.DataSource = v_ds.Tables[0];
        }

        //check validate data
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
                m_txt_ma_qd.BackColor = Color.Bisque;
                m_lbl_kiem_tra_ma_qd.Visible = true;
                m_lbl_kiem_tra_ma_qd.Text = "Đã có mã này rồi...";
                return true;
            }
            else
            {
                m_txt_ma_qd.BackColor = Color.White;
                m_lbl_kiem_tra_ma_qd.Visible = false;
                return false;
            }
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

        //Insert, update, delete
        private decimal find_id_qd_moi_lap(decimal ip_dc_id_loai_qd, string ip_str_ma_qd)
        {
            try
            {
                US_GD_QUYET_DINH v_us = new US_GD_QUYET_DINH();
                DS_GD_QUYET_DINH v_ds = new DS_GD_QUYET_DINH();

                v_us.FillDataset(v_ds);

                string v_str_filter = "ID_LOAI_QD = " + ip_dc_id_loai_qd + " AND MA_QUYET_DINH = '" + ip_str_ma_qd + "'";
                DataRow[] v_dr = v_ds.GD_QUYET_DINH.Select(v_str_filter);

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

        private void form_2_us_gd_qd(US_GD_QUYET_DINH ip_us)
        {
            ip_us.dcID_LOAI_QD = CIPConvert.ToDecimal(m_sle_loai_quyet_dinh.EditValue);
            ip_us.strMA_QUYET_DINH = m_txt_ma_qd.Text.Trim();
            ip_us.datNGAY_CO_HIEU_LUC = m_dat_ngay_co_hieu_luc.Value.Date;
            ip_us.datNGAY_HET_HIEU_LUC = m_dat_ngay_het_hieu_luc.Value.Date;
            ip_us.datNGAY_KY = m_dat_ngay_ky.Value.Date;
            ip_us.strNGUOI_KY = m_txt_nguoi_ky.Text;
            ip_us.strNOI_DUNG = m_txt_noi_dung.Text;
            ip_us.strLINK = m_txt_link.Text.Trim();
        }

        private void us_obj_2_form(decimal ip_dc_id_gd_qd)
        {
            US_V_GD_QUYET_DINH v_us = new US_V_GD_QUYET_DINH(ip_dc_id_gd_qd);

            m_sle_loai_quyet_dinh.EditValue = v_us.dcID_LOAI_QD;
            m_txt_ma_qd.Text = v_us.strMA_QUYET_DINH.ToString();
            m_dat_ngay_co_hieu_luc.Value = v_us.datNGAY_CO_HIEU_LUC;
            m_dat_ngay_het_hieu_luc.Value = v_us.datNGAY_HET_HIEU_LUC;
            m_dat_ngay_ky.Value = v_us.datNGAY_KY;
            m_txt_nguoi_ky.Text = v_us.strNGUOI_KY;
            m_txt_noi_dung.Text = v_us.strNOI_DUNG;
            m_txt_link.Text = v_us.strLINK;
        }

        private void save_data()
        {
            US_GD_QUYET_DINH v_us_gd_qd = new US_GD_QUYET_DINH();

            form_2_us_gd_qd(v_us_gd_qd);
            try
            {
                switch (m_e_form_mode)
                {
                    case DataEntryFormMode.InsertDataState:
                        v_us_gd_qd.BeginTransaction();
                        v_us_gd_qd.Insert();
                        v_us_gd_qd.CommitTransaction();
                        break;
                    case DataEntryFormMode.UpdateDataState:
                        v_us_gd_qd.dcID = CIPConvert.ToDecimal(m_grv_quyet_dinh.GetRowCellValue(m_grv_quyet_dinh.FocusedRowHandle, "ID"));
                        v_us_gd_qd.BeginTransaction();
                        v_us_gd_qd.Update();
                        v_us_gd_qd.CommitTransaction();
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
            decimal v_id_qd_moi_lap = 0;

            US_GD_QUYET_DINH v_us = new US_GD_QUYET_DINH();
            DS_GD_QUYET_DINH v_ds = new DS_GD_QUYET_DINH();

            v_id_qd_moi_lap = find_id_qd_moi_lap(CIPConvert.ToDecimal(m_sle_loai_quyet_dinh.EditValue), m_txt_ma_qd.Text.Trim());

            v_us.FillDataset(v_ds);

            for (v_row_index = 0; v_row_index < v_ds.Tables[0].Rows.Count; v_row_index++)
            {
                var v_id_gd_qd = CIPConvert.ToDecimal(m_grv_quyet_dinh.GetDataRow(v_row_index)["ID"].ToString());

                if (v_id_gd_qd == v_id_qd_moi_lap)
                {
                    break;
                }
            }

            m_grv_quyet_dinh.FocusedRowHandle = v_row_index;
        }

        //clear data in form
        private void clear_data_inform()
        {
            m_sle_loai_quyet_dinh.EditValue = null;
            m_txt_ma_qd.Text = "";
            m_lbl_kiem_tra_ma_qd.Visible = false;
            m_dat_ngay_co_hieu_luc.Value = DateTime.Now.Date;
            m_dat_ngay_het_hieu_luc.Value = DateTime.Now.Date;
            m_dat_ngay_ky.Value = DateTime.Now.Date;
            m_txt_nguoi_ky.Text = "";
            m_txt_noi_dung.Text = "";
            m_txt_link.Text = "";

            DS_V_GD_QUYET_DINH v_ds = new DS_V_GD_QUYET_DINH();
            m_grc_quyet_dinh.DataSource = v_ds.Tables[0];
        }

        #endregion
        private void set_define_events()
        {
            this.Load += f360_quan_ly_quyet_dinh_Load;
            //cmd
            m_cmd_lap_qd.Click += m_cmd_lap_qd_Click;
            m_cmd_insert.Click += m_cmd_insert_Click;
            m_cmd_update.Click += m_cmd_update_Click;
            //control
            //gridview, gridcontrol
        }

        void f360_quan_ly_quyet_dinh_Load(object sender, EventArgs e)
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

        void m_cmd_lap_qd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!check_data_is_ok())
                {
                    return;
                }
                else
                {
                    //load_data_2_m_variable();
                    switch (m_e_form_mode)
                    {
                        case DataEntryFormMode.InsertDataState:
                            if (CHRM_BaseMessages.MsgBox_Confirm(CONST_ID_MSGBOX.QUESTION_XAC_NHAN_LUU_DU_LIEU) == true)
                            {
                                save_data();
                            }
                            break;
                        case DataEntryFormMode.UpdateDataState:
                            if (CHRM_BaseMessages.MsgBox_Confirm(CONST_ID_MSGBOX.QUESTION_XAC_NHAN_LUU_DU_LIEU) == true)
                            {
                                save_data();
                            }
                            break;
                        default:
                            break;
                    }

                    load_data_2_grid();
                    focus_new_row_created();
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
                //clear_data_inform();
                //m_e_form_mode = DataEntryFormMode.InsertDataState;
                f361_quan_ly_quyet_dinh_de v_frm = new f361_quan_ly_quyet_dinh_de();
                v_frm.display_4_insert();
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
                decimal v_id_gd_qd = 0;
                v_id_gd_qd = CIPConvert.ToDecimal(m_grv_quyet_dinh.GetRowCellValue(m_grv_quyet_dinh.FocusedRowHandle, "ID"));

                us_obj_2_form(v_id_gd_qd);
                f361_quan_ly_quyet_dinh_de v_frm = new f361_quan_ly_quyet_dinh_de();
                v_frm.display_4_update(v_id_gd_qd);
                //m_e_form_mode = DataEntryFormMode.UpdateDataState;
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

    }
}
