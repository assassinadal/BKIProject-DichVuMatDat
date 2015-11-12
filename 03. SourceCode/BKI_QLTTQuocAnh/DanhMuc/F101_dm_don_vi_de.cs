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

namespace BKI_DichVuMatDat.DanhMuc
{
    public partial class F101_dm_don_vi_de : Form
    {
        public F101_dm_don_vi_de()
        {
            InitializeComponent();
            format_controls();
        }

        #region Public interface
        public void display_4_insert(ref decimal v_id_dm_don_vi_moi_tao)
        {
            this.Text = "F101 - Thêm đơn vị";
            m_lbl_header.Text = "THÊM ĐƠN VỊ";
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            this.CenterToScreen();
            this.ShowDialog();
            v_id_dm_don_vi_moi_tao = m_id_dm_don_vi_moi_tao;
        }

        public void display_4_update(US_DM_DON_VI ip_us)
        {
            this.Text = "F101 - Sửa đơn vị";
            m_lbl_header.Text = "SỬA ĐƠN VỊ";
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            m_id_dm_dv_4_update = ip_us.dcID;
            m_txt_ma_dv.Text = ip_us.strMA_DON_VI;
            m_txt_ten_dv.Text = ip_us.strTEN_DON_VI;
            m_sle_loai_dv.EditValue = ip_us.dcID_LOAI_DON_VI;
            m_sle_chon_dv_cap_tren.EditValue = ip_us.dcID_DON_VI_CAP_TREN;
            this.CenterToScreen();
            this.ShowDialog();
        }
        #endregion

        #region Members
        DataEntryFormMode m_e_form_mode = DataEntryFormMode.InsertDataState;
        decimal m_id_dm_dv_4_update = 0;
        decimal m_id_dm_don_vi_moi_tao = 0;
        #endregion

        #region Private Methods
        private void format_controls()
        {
            FormatControl.SetVisibleSimpleButton(this);
            set_define_events();
            this.KeyPreview = true;
        }

        private void set_initial_form_load()
        {
            load_data_2_sle_loai_don_vi();
            load_data_2_sle_don_vi_cap_tren();
        }

        private DS_CM_DM_TU_DIEN load_data_2_cm_dm_tu_dien(int m_id_lns_lcd_trong_loai_td)
        {
            DS_CM_DM_TU_DIEN v_ds = new DS_CM_DM_TU_DIEN();
            US_CM_DM_TU_DIEN v_us = new US_CM_DM_TU_DIEN();

            v_us.FillDatasetByIdLoaiTuDien(v_ds, m_id_lns_lcd_trong_loai_td);

            return v_ds;
        }

        private void load_data_2_sle_loai_don_vi()
        {
            m_sle_loai_dv.Properties.DataSource = load_data_2_cm_dm_tu_dien(CONST_ID_LOAI_TU_DIEN.LOAI_DON_VI).CM_DM_TU_DIEN;
            m_sle_loai_dv.Properties.ValueMember = CM_DM_TU_DIEN.ID;
            m_sle_loai_dv.Properties.DisplayMember = CM_DM_TU_DIEN.TEN;

            m_sle_loai_dv.Properties.PopulateViewColumns();
            m_sle_loai_dv.Properties.View.Columns[CM_DM_TU_DIEN.ID].Visible = false;
            m_sle_loai_dv.Properties.View.Columns[CM_DM_TU_DIEN.ID_LOAI_TU_DIEN].Visible = false;
            m_sle_loai_dv.Properties.View.Columns[CM_DM_TU_DIEN.TEN_NGAN].Visible = false;

            m_sle_loai_dv.Properties.View.Columns[CM_DM_TU_DIEN.MA_TU_DIEN].Width = 75;
            m_sle_loai_dv.Properties.View.Columns[CM_DM_TU_DIEN.TEN].Width = 120;

            m_sle_loai_dv.Properties.View.Columns[CM_DM_TU_DIEN.MA_TU_DIEN].Caption = "Mã loại đơn vị";
            m_sle_loai_dv.Properties.View.Columns[CM_DM_TU_DIEN.TEN].Caption = "Loại đơn vị";
            m_sle_loai_dv.Properties.View.Columns[CM_DM_TU_DIEN.GHI_CHU].Caption = "Ghi chú";

            m_sle_loai_dv.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            m_sle_loai_dv.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
        }

        private DS_DM_DON_VI load_data_2_dm_loai_don_vi()
        {
            DS_DM_DON_VI v_ds = new DS_DM_DON_VI();
            US_DM_DON_VI v_us = new US_DM_DON_VI();

            v_us.FillDataset(v_ds);

            return v_ds;
        }

        private void load_data_2_sle_don_vi_cap_tren()
        {
            m_sle_chon_dv_cap_tren.Properties.DataSource = load_data_2_dm_loai_don_vi().DM_DON_VI;
            m_sle_chon_dv_cap_tren.Properties.ValueMember = DM_DON_VI.ID;
            m_sle_chon_dv_cap_tren.Properties.DisplayMember = DM_DON_VI.TEN_DON_VI;

            m_sle_chon_dv_cap_tren.Properties.PopulateViewColumns();
            m_sle_chon_dv_cap_tren.Properties.View.Columns[DM_DON_VI.ID].Visible = false;
            m_sle_chon_dv_cap_tren.Properties.View.Columns[DM_DON_VI.ID_LOAI_DON_VI].Visible = false;
            m_sle_chon_dv_cap_tren.Properties.View.Columns[DM_DON_VI.ID_DON_VI_CAP_TREN].Visible = false;

            m_sle_chon_dv_cap_tren.Properties.View.Columns[DM_DON_VI.MA_DON_VI].Width = 75;
            m_sle_chon_dv_cap_tren.Properties.View.Columns[DM_DON_VI.TEN_DON_VI].Width = 120;

            m_sle_chon_dv_cap_tren.Properties.View.Columns[DM_DON_VI.MA_DON_VI].Caption = "Mã đơn vị";
            m_sle_chon_dv_cap_tren.Properties.View.Columns[DM_DON_VI.TEN_DON_VI].Caption = "Tên đơn vị";

            m_sle_chon_dv_cap_tren.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            m_sle_chon_dv_cap_tren.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
        }

        //check validate data
        private bool check_ma_don_vi_is_exist()
        {
            DataSet v_ds = load_data_2_dm_loai_don_vi();
            string v_str_filter = "";
            v_str_filter = "MA_DON_VI = '" + m_txt_ma_dv.Text.Trim() + "'";

            DataRow[] v_dr = v_ds.Tables[0].Select(v_str_filter);

            if (v_dr.Count() != 0)
            {
                m_txt_ma_dv.BackColor = Color.Bisque;
                m_lbl_kiem_tra_ma_dv.Visible = true;
                m_lbl_kiem_tra_ma_dv.Text = "Đã có mã này rồi...";
                return true;
            }
            else
            {
                m_lbl_kiem_tra_ma_dv.BackColor = Color.White;
                m_lbl_kiem_tra_ma_dv.Visible = false;
                return false;
            }
        }

        private bool check_validate_data()
        {
            if (m_e_form_mode == DataEntryFormMode.InsertDataState)
            {
                if (check_ma_don_vi_is_exist())
                {
                    return false;
                }
            }

            if (m_txt_ten_dv.Text == "")
            {
                CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_CHUA_NHAP_TEN_DON_VI);
                return false;
            }

            if (m_sle_loai_dv.EditValue == null || m_sle_loai_dv.EditValue == "")
            {
                CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_CHUA_CHON_LOAI_DON_VI);
                return false;
            }
            return true;
        }

        //save data
        private void form_2_us_obj(US_DM_DON_VI ip_us)
        {
            if (m_txt_ma_dv.Text.Trim() != "")
            {
                ip_us.strMA_DON_VI = m_txt_ma_dv.Text.Trim();
            }
            if (m_sle_chon_dv_cap_tren.EditValue != null && m_sle_chon_dv_cap_tren.EditValue != "")
            {
                ip_us.dcID_DON_VI_CAP_TREN = CIPConvert.ToDecimal(m_sle_chon_dv_cap_tren.EditValue);
            }
            ip_us.strTEN_DON_VI = m_txt_ten_dv.Text.Trim();
            ip_us.dcID_LOAI_DON_VI = CIPConvert.ToDecimal(m_sle_loai_dv.EditValue);
        }

        private void save_data()
        {
            US_DM_DON_VI v_us_dm_dv = new US_DM_DON_VI();
            form_2_us_obj(v_us_dm_dv);

            try
            {
                switch (m_e_form_mode)
                {
                    case DataEntryFormMode.InsertDataState:
                        v_us_dm_dv.BeginTransaction();
                        v_us_dm_dv.Insert();
                        v_us_dm_dv.CommitTransaction();
                        m_id_dm_don_vi_moi_tao = v_us_dm_dv.dcID;
                        if (CHRM_BaseMessages.MsgBox_Confirm(CONST_ID_MSGBOX.INSERT_DM_DON_VI_THANH_CONG_TIEP_TUC_INSERT_YN) == true)
                        {
                            refresh_form();
                        }
                        else
                        {
                            this.Close();
                        }
                        break;
                    case DataEntryFormMode.UpdateDataState:
                        v_us_dm_dv.dcID = m_id_dm_dv_4_update;
                        v_us_dm_dv.BeginTransaction();
                        v_us_dm_dv.Update();
                        v_us_dm_dv.CommitTransaction();
                        CHRM_BaseMessages.MsgBox_Infor(CONST_ID_MSGBOX.INFOR_DU_LIEU_DA_DUOC_CAP_NHAT);
                        this.Close();
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

        private void refresh_form()
        {
            m_txt_ma_dv.Text = "";
            m_txt_ma_dv.BackColor = Color.White;
            m_lbl_kiem_tra_ma_dv.Visible = false;
            m_txt_ten_dv.Text = "";
            m_sle_loai_dv.EditValue = null;
            m_sle_chon_dv_cap_tren.EditValue = null;
        }

        #endregion
        private void set_define_events()
        {
            this.Load += F101_dm_don_vi_de_Load;
            m_cmd_save.Click += m_cmd_save_Click;
            m_cmd_exit.Click += m_cmd_exit_Click;
            this.KeyDown += F101_dm_don_vi_de_KeyDown;
        }

        void F101_dm_don_vi_de_Load(object sender, EventArgs e)
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

        void m_cmd_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (check_validate_data())
                {
                    if (CHRM_BaseMessages.MsgBox_Confirm(CONST_ID_MSGBOX.QUESTION_XAC_NHAN_LUU_DU_LIEU) == true)
                    {
                        save_data();
                    }
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_exit_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void F101_dm_don_vi_de_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
                {
                    this.Close();
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
    }
}
