using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BKI_DichVuMatDat.DS;
using BKI_DichVuMatDat.DS.CDBNames;
using BKI_DichVuMatDat.US;
using DevExpress.XtraEditors;
using IP.Core.IPCommon;

namespace BKI_DichVuMatDat.DanhMuc
{
    public partial class F103_dm_he_so_luong_ns_de : Form
    {
        US_DM_HE_SO_LUONG_NS m_us = new US_DM_HE_SO_LUONG_NS();
        public F103_dm_he_so_luong_ns_de()
        {
            InitializeComponent();
            format_controls();
        }

        #region Public Interface
        public void display_4_insert(ref decimal v_id_dm_he_so_luong_ns_moi_tao)
        {
            this.Text = "F103 - Thêm hệ số lương năng suất mới";
            m_lbl_header.Text = "THÊM HỆ SỐ LƯƠNG NĂNG SUẤT MỚI";
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            this.CenterToScreen();
            this.ShowDialog();
            v_id_dm_he_so_luong_ns_moi_tao = m_id_dm_he_so_luong_ns_moi_tao;
        }

        public void display_4_update(US_DM_HE_SO_LUONG_NS ip_us)
        {
            this.Text = "F103 - Sửa hệ số lương năng suất";
            m_lbl_header.Text = "SỬA HỆ SỐ LƯƠNG NĂNG SUẤT";
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            m_id_dm_he_so_luong_ns_4_update = ip_us.dcID;
            m_sle_ma_lns.EditValue = ip_us.dcID_MA_LNS.ToString();
            m_sle_muc_lns.EditValue = ip_us.dcID_MUC_LNS.ToString();
            m_txt_he_so_luong_ns.Text = ip_us.dcHE_SO.ToString();
            //m_txt_loai_lao_dong.Text = ip_us.dcID_LOAI_LAO_DONG.ToString();
            m_us = ip_us;
            this.CenterToScreen();
            this.ShowDialog();
        }
        #endregion

        #region Members
        DataEntryFormMode m_e_form_mode = DataEntryFormMode.InsertDataState;
        decimal m_id_dm_he_so_luong_ns_4_update = 0;
        decimal m_id_dm_he_so_luong_ns_moi_tao = 0;
        #endregion

        #region private methods
        private void format_controls()
        {
            FormatControl.SetVisibleSimpleButton(this);
            set_define_events();
            this.KeyPreview = true;
        }

        private void set_initial_form_load()
        {
            load_data_2_sle_ma_lns();
            load_data_2_sle_muc_lns();
        }

        private DS_CM_DM_TU_DIEN load_data_2_cm_dm_tu_dien(int m_id_muc_hs_lns_trong_loai_td)
        {
            DS_CM_DM_TU_DIEN v_ds = new DS_CM_DM_TU_DIEN();
            US_CM_DM_TU_DIEN v_us = new US_CM_DM_TU_DIEN();

            v_us.FillDatasetByIdLoaiTuDien(v_ds, m_id_muc_hs_lns_trong_loai_td);

            return v_ds;
        }

        private void load_data_2_sle_ma_lns()
        {
            m_sle_ma_lns.Properties.DataSource = load_data_2_cm_dm_tu_dien(CONST_ID_LOAI_TU_DIEN.MA_HS_LNS).CM_DM_TU_DIEN;
            m_sle_ma_lns.Properties.ValueMember = CM_DM_TU_DIEN.ID;
            m_sle_ma_lns.Properties.DisplayMember = CM_DM_TU_DIEN.TEN;
            m_sle_ma_lns.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            m_sle_ma_lns.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
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

            m_sle_muc_lns.Properties.View.Columns[CM_DM_TU_DIEN.MA_TU_DIEN].Caption = "Mã mức lương năng suất";
            m_sle_muc_lns.Properties.View.Columns[CM_DM_TU_DIEN.TEN].Caption = "Mức lương năng suất";
            m_sle_muc_lns.Properties.View.Columns[CM_DM_TU_DIEN.GHI_CHU].Caption = "Ghi chú";

            m_sle_muc_lns.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            m_sle_muc_lns.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
        }

        private DS_DM_HE_SO_LUONG_NS load_data_2_dm_loai_don_vi()
        {
            DS_DM_HE_SO_LUONG_NS v_ds = new DS_DM_HE_SO_LUONG_NS();
            DS_DM_HE_SO_LUONG_NS v_us = new DS_DM_HE_SO_LUONG_NS();

            v_us.FillDataset(v_ds);

            return v_ds;
        }

        
        private bool check_validate_data()
        {
            if (m_sle_ma_lns.EditValue == null)
            {
                CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_CHUA_NHAP_MA_LNS);
                return false;
            }
            if (m_sle_muc_lns.EditValue == null)
            {
                CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_CHUA_CHON_MUC_LNS);
                return false;
            }
            if (m_txt_he_so_luong_ns.Text.Trim() == "")
            {
                CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_CHUA_NHAP_HE_SO_LNS);
                return false;
            }
            if (check_ma_muc_da_ton_tai())
            {
                string v_str_error = "Loại lương năng suất đã tồn tại!";
                XtraMessageBox.Show(v_str_error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool check_ma_muc_da_ton_tai()
        {
            US_DM_HE_SO_LUONG_NS v_us = new US_DM_HE_SO_LUONG_NS();
            DS_DM_HE_SO_LUONG_NS v_ds = new DS_DM_HE_SO_LUONG_NS();
            decimal v_id_ma = CIPConvert.ToDecimal(m_sle_ma_lns.EditValue);
            decimal v_id_muc = CIPConvert.ToDecimal(m_sle_muc_lns.EditValue);
            v_us.FillDataset(v_ds, "where id_ma_lns = " + v_id_ma + "and id_muc_lns =" + v_id_muc);
            if ((m_us.dcID_MA_LNS != v_id_ma || m_us.dcID_MUC_LNS != v_id_muc) && v_ds.Tables[0].Rows.Count != 0)
            {
                return true;
            }
            return false;
        }

        //save data
        private void form_2_us_obj(US_DM_HE_SO_LUONG_NS ip_us)
        {
            ip_us.dcID_MA_LNS = CIPConvert.ToDecimal(m_sle_ma_lns.EditValue);
            ip_us.dcID_MUC_LNS = CIPConvert.ToDecimal(m_sle_muc_lns.EditValue);
            ip_us.dcHE_SO = CIPConvert.ToDecimal(m_txt_he_so_luong_ns.Text.Trim());
            //ip_us.dcID_LOAI_LAO_DONG = CIPConvert.ToDecimal(m_txt_loai_lao_dong.Text.Trim());
        }

        private void save_data()
        {
            US_DM_HE_SO_LUONG_NS v_us_dm_he_so_luong_ns = new US_DM_HE_SO_LUONG_NS();
            form_2_us_obj(v_us_dm_he_so_luong_ns);

            try
            {
                switch (m_e_form_mode)
                {
                    case DataEntryFormMode.InsertDataState:
                        v_us_dm_he_so_luong_ns.BeginTransaction();
                        v_us_dm_he_so_luong_ns.Insert();
                        v_us_dm_he_so_luong_ns.CommitTransaction();
                        m_id_dm_he_so_luong_ns_moi_tao = v_us_dm_he_so_luong_ns.dcID;
                        break;
                    case DataEntryFormMode.UpdateDataState:
                        v_us_dm_he_so_luong_ns.dcID = m_id_dm_he_so_luong_ns_4_update;
                        v_us_dm_he_so_luong_ns.BeginTransaction();
                        v_us_dm_he_so_luong_ns.Update();
                        v_us_dm_he_so_luong_ns.CommitTransaction();
                        break;
                    default:
                        break;
                }
                CHRM_BaseMessages.MsgBox_Infor(CONST_ID_MSGBOX.INFOR_DU_LIEU_DA_DUOC_CAP_NHAT);
                this.Close();
            }
            catch (Exception v_e)
            {
                throw v_e;
            }
        }

        private void refresh_form()
        {
            m_sle_ma_lns.EditValue = null;
            m_sle_muc_lns.EditValue = null;
            m_txt_he_so_luong_ns.BackColor = Color.White;
            //m_txt_loai_lao_dong.Text = "";
        }
        #endregion
        private void set_define_events()
        {
            this.Load += F103_dm_he_so_luong_ns_de_Load;
            m_cmd_save.Click += m_cmd_save_Click;
            m_cmd_exit.Click += m_cmd_exit_Click;
            this.KeyDown += F103_dm_he_so_luong_ns_de_KeyDown;
        }

        void F103_dm_he_so_luong_ns_de_Load(object sender, EventArgs e)
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

        void F103_dm_he_so_luong_ns_de_KeyDown(object sender, KeyEventArgs e)
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