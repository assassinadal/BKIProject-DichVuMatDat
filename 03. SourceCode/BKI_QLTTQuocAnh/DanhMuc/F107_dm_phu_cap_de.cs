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
using DevExpress.XtraEditors.Controls;
using IP.Core.IPCommon;


namespace BKI_DichVuMatDat.DanhMuc
{
    public partial class F107_dm_phu_cap_de : Form
    {
        public F107_dm_phu_cap_de()
        {
            InitializeComponent();
            format_controls();
        }

        #region Public Interface
        public void display_4_insert(ref decimal v_id_dm_phu_cap_moi_tao)
        {
            this.Text = "F107 - Thêm loại phụ cấp mới";
            m_lbl_header.Text = "THÊM LOẠI PHỤ CẤP MỚI";
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            this.CenterToScreen();
            this.ShowDialog();
            v_id_dm_phu_cap_moi_tao = m_id_dm_phu_cap_moi_tao;
        }

        public void display_4_update(US_DM_PHU_CAP ip_us)
        {
            this.Text = "F107 - Sửa loại phụ cấp";
            m_lbl_header.Text = "SỬA LOẠI PHỤ CẤP";
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            m_id_dm_phu_cap_4_update = ip_us.dcID;
            m_search_lookup_edit_loai_phu_cap.EditValue = ip_us.dcID_LOAI_PHU_CAP;
            m_txt_doi_tuong_huong.Text = ip_us.strDOI_TUONG_HUONG_PHU_CAP;
            m_txt_ti_le.Text = ip_us.dcTI_LE.ToString();
            this.CenterToScreen();
            this.ShowDialog();
        }
        #endregion

        #region Members
        DataEntryFormMode m_e_form_mode = DataEntryFormMode.InsertDataState;
        decimal m_id_dm_phu_cap_4_update = 0;
        decimal m_id_dm_phu_cap_moi_tao = 0;
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

        }

        private void get_loai_phu_cap()
        {
            US_CM_DM_TU_DIEN v_us = new US_CM_DM_TU_DIEN();
            DS_CM_DM_TU_DIEN v_ds = new DS_CM_DM_TU_DIEN();
            v_us.FillDatasetByIdLoaiTuDien(v_ds, 5);
            m_search_lookup_edit_loai_phu_cap.Properties.DataSource = v_ds.Tables[0];
            m_search_lookup_edit_loai_phu_cap.Properties.BestFitMode = BestFitMode.BestFitResizePopup;
            //DataSet v_ds = new DataSet();
            //DataTable v_dt = new DataTable();
            //US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            //v_ds.Tables.Add(v_dt);
            //v_us.FillDatasetWithQuery(v_ds, "SELECT * FROM CM_DM_TU_DIEN WHERE ID_LOAI_TU_DIEN = 5");
            //m_search_lookup_edit_loai_phu_cap.Properties.DataSource = v_ds.Tables[0];
            //m_search_lookup_edit_loai_phu_cap.Properties.BestFitMode = BestFitMode.BestFitResizePopup;
        }

        private bool check_validate_data()
        {
            if (m_search_lookup_edit_loai_phu_cap.Text.Trim() == "")
            {
                CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_CHUA_NHAP_TEN_LOAI_PHU_CAP);
                return false;
            }
            if (m_txt_doi_tuong_huong.Text.Trim() == "")
            {
                CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_CHUA_NHAP_DOI_TUONG_DC_HUONG_PHU_CAP);
                return false;
            }
            if (m_txt_ti_le.Text.Trim() == "")
            {
                CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_CHUA_NHAP_TI_LE);
                return false;
            }
            return true;
        }

        //save data
        private void form_2_us_obj(US_DM_PHU_CAP ip_us)
        {
            ip_us.dcID_LOAI_PHU_CAP = CIPConvert.ToDecimal(m_search_lookup_edit_loai_phu_cap.EditValue.ToString()) ;
            ip_us.strDOI_TUONG_HUONG_PHU_CAP = m_txt_doi_tuong_huong.Text.Trim();
            ip_us.dcTI_LE = CIPConvert.ToDecimal(m_txt_ti_le.Text.Trim());
        }

        private void save_data()
        {
            US_DM_PHU_CAP v_us_dm_phu_cap = new US_DM_PHU_CAP();
            form_2_us_obj(v_us_dm_phu_cap);

            try
            {
                switch (m_e_form_mode)
                {
                    case DataEntryFormMode.InsertDataState:
                        v_us_dm_phu_cap.BeginTransaction();
                        v_us_dm_phu_cap.Insert();
                        v_us_dm_phu_cap.CommitTransaction();
                        m_id_dm_phu_cap_moi_tao = v_us_dm_phu_cap.dcID;
                        break;
                    case DataEntryFormMode.UpdateDataState:
                        v_us_dm_phu_cap.dcID = m_id_dm_phu_cap_4_update;
                        v_us_dm_phu_cap.BeginTransaction();
                        v_us_dm_phu_cap.Update();
                        v_us_dm_phu_cap.CommitTransaction();
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
            m_search_lookup_edit_loai_phu_cap.Text = "";
            m_txt_doi_tuong_huong.Text = "";
            m_txt_ti_le.BackColor = Color.White;
        }
        #endregion
        private void set_define_events()
        {
            this.Load += F107_dm_phu_cap_de_Load;
            m_cmd_save.Click += m_cmd_save_Click;
            m_cmd_exit.Click += m_cmd_exit_Click;
            this.KeyDown += F107_dm_phu_cap_de_KeyDown;
        }
        void F107_dm_phu_cap_de_Load(object sender, EventArgs e)
        {
            try
            {
                set_initial_form_load();
                get_loai_phu_cap();
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

        void F107_dm_phu_cap_de_KeyDown(object sender, KeyEventArgs e)
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
