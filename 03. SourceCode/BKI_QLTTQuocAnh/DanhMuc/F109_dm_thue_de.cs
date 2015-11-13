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
    public partial class F109_dm_thue_de : Form
    {
        public F109_dm_thue_de()
        {
            InitializeComponent();
            format_controls();
        }

        #region Public interface
        public void display_4_insert(ref decimal v_id_dm_thue_moi_tao)
        {
            this.Text = "F109 - Thêm mức thuế mới";
            m_lbl_header.Text = "THÊM MỨC THUẾ MỚI";
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            this.CenterToScreen();
            this.ShowDialog();
            v_id_dm_thue_moi_tao = m_id_dm_thue_moi_tao;
        }

        public void display_4_update(US_DM_THUE ip_us)
        {
            this.Text = "F109 - Sửa mức thuế";
            m_lbl_header.Text = "SỬA MỨC THUẾ";
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            m_id_dm_thue_4_update = ip_us.dcID;
            m_txt_chan_duoi.Text = ip_us.dcCHAN_DUOI.ToString();
            m_txt_chan_tren.Text = ip_us.dcCHAN_TREN.ToString();
            m_txt_ti_le.Text = (ip_us.dcTI_LE*100).ToString();
            m_txt_bu_tru.Text = ip_us.dcBU_TRU.ToString().Substring(ip_us.dcBU_TRU.ToString().LastIndexOf("-") + 1);

            CHRMCommon.format_text_2_money(m_txt_chan_duoi);
            CHRMCommon.format_text_2_money(m_txt_chan_tren);
            CHRMCommon.format_text_2_money(m_txt_bu_tru);

            this.CenterToScreen();
            this.ShowDialog();
        }



        #endregion

        #region Members
        DataEntryFormMode m_e_form_mode = DataEntryFormMode.InsertDataState;
        decimal m_id_dm_thue_4_update = 0;
        decimal m_id_dm_thue_moi_tao = 0;
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

        private bool check_validate_data()
        {
            if (m_txt_ti_le.Text.Trim() == "")
            {
                CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_CHUA_NHAP_TI_LE);
                return false;
            }
            if (m_txt_bu_tru.Text.Trim() == "")
            {
                CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_CHUA_NHAP_GIA_TRI_BU_TRU);
                return false;
            }
            if (m_txt_chan_duoi.Text != "" && m_txt_chan_tren.Text != "")
            {
                if (CIPConvert.ToDecimal(m_txt_chan_tren.Text.Trim()) <= CIPConvert.ToDecimal(m_txt_chan_duoi.Text.Trim()))
                {
                    CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_CHUA_NHAP_GIA_TRI_CHAN_DUOI_NHO_HON_CHAN_TREN);

                    return false;
                }
            }
            return true;
        }

        //save data
        private void form_2_us_obj(US_DM_THUE ip_us)
        {
            ip_us.dcCHAN_DUOI = CIPConvert.ToDecimal(m_txt_chan_duoi.Text.Trim());
            ip_us.dcCHAN_TREN = CIPConvert.ToDecimal(m_txt_chan_tren.Text.Trim());
            ip_us.dcTI_LE = CIPConvert.ToDecimal(m_txt_ti_le.Text.Trim()) / 100;
            ip_us.dcBU_TRU = 0 - CIPConvert.ToDecimal(m_txt_bu_tru.Text.Trim());
        }

        private void save_data()
        {
            US_DM_THUE v_us_dm_thue = new US_DM_THUE();
            form_2_us_obj(v_us_dm_thue);

            try
            {
                switch (m_e_form_mode)
                {
                    case DataEntryFormMode.InsertDataState:
                        v_us_dm_thue.BeginTransaction();
                        v_us_dm_thue.Insert();
                        v_us_dm_thue.CommitTransaction();
                        m_id_dm_thue_moi_tao = v_us_dm_thue.dcID;
                        if (CHRM_BaseMessages.MsgBox_Confirm(CONST_ID_MSGBOX.QUESTION_INSER_DM_THUE_THANH_CONG_TIEP_TUC_INSERT_YN) == true)
                        {
                            refresh_form();
                        }
                        else
                        {
                            this.Close();
                        }
                        break;
                    case DataEntryFormMode.UpdateDataState:
                        v_us_dm_thue.dcID = m_id_dm_thue_4_update;
                        v_us_dm_thue.BeginTransaction();
                        v_us_dm_thue.Update();
                        v_us_dm_thue.CommitTransaction();
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
            m_txt_chan_duoi.Text = "";
            m_txt_chan_tren.Text = "";
            m_txt_ti_le.Text = "";
            m_txt_bu_tru.Text = "";
        }
        #endregion
        private void set_define_events()
        {
            this.Load += F109_dm_thue_de_Load;
            m_cmd_save.Click += m_cmd_save_Click;
            m_cmd_exit.Click += m_cmd_exit_Click;
            this.KeyDown += F109_dm_thue_de_KeyDown;

            m_txt_chan_duoi.Leave += m_txt_chan_duoi_Leave;
            m_txt_chan_tren.Leave += m_txt_chan_tren_Leave;
            m_txt_bu_tru.Leave += m_txt_bu_tru_Leave;
        }

        void F109_dm_thue_de_Load(object sender, EventArgs e)
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

        void F109_dm_thue_de_KeyDown(object sender, KeyEventArgs e)
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

        void m_txt_chan_duoi_Leave(object sender, EventArgs e)
        {
            try
            {
                CHRMCommon.format_text_2_money(m_txt_chan_duoi);
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_txt_chan_tren_Leave(object sender, EventArgs e)
        {
            try
            {
                CHRMCommon.format_text_2_money(m_txt_chan_tren);
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_txt_bu_tru_Leave(object sender, EventArgs e)
        {
            try
            {
                CHRMCommon.format_text_2_money(m_txt_bu_tru);
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
    }
}
