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
    public partial class f108_dm_tham_so_de : Form
    {
        public f108_dm_tham_so_de()
        {
            InitializeComponent();
            format_controls();
        }

        #region Public Interface
        public void display_4_insert(ref decimal v_id_dm_tham_so_moi_tao)
        {
            this.Text = "F108 - Thêm loại tham số mới";
            m_lbl_header.Text = "THÊM LOẠI THAM SỐ MỚI";
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            this.CenterToScreen();
            this.ShowDialog();
            v_id_dm_tham_so_moi_tao = m_id_dm_tham_so_moi_tao;
        }

        public void display_4_update(US_DM_THAM_SO ip_us)
        {
            this.Text = "F108 - Sửa loại tham số";
            m_lbl_header.Text = "SỬA LOẠI THAM SỐ";
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            m_id_dm_tham_so_4_update = ip_us.dcID;
            m_txt_ten_tham_so.Text = ip_us.strLOAI;
            m_txt_gia_tri_tham_so.Text = ip_us.dcSO_TIEN.ToString();
            CHRMCommon.format_text_2_money(m_txt_gia_tri_tham_so);
            this.CenterToScreen();
            this.ShowDialog();
        }
        #endregion

        #region Members
        DataEntryFormMode m_e_form_mode = DataEntryFormMode.InsertDataState;
        decimal m_id_dm_tham_so_4_update = 0;
        decimal m_id_dm_tham_so_moi_tao = 0;
        #endregion

        #region private methods
        private void format_controls()
        {
            //FormatControl.SetVisibleSimpleButton(this);
            set_define_events();
            this.KeyPreview = true;
        }

        private void set_initial_form_load()
        {
            
        }

        private bool check_validate_data()
        {
            if (m_txt_ten_tham_so.Text.Trim() == "")
            {
                CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_CHUA_NHAP_TEN_THAM_SO);
                return false;
            }
            if (m_txt_gia_tri_tham_so.Text.Trim() == "")
            {
                CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_CHUA_NHAP_GIA_TRI_THAM_SO);

                return false;
            }
            return true;
        }

        //save data
        private void form_2_us_obj(US_DM_THAM_SO ip_us)
        {
            ip_us.strLOAI = m_txt_ten_tham_so.Text.Trim();
            ip_us.dcSO_TIEN = CIPConvert.ToDecimal(m_txt_gia_tri_tham_so.Text.Trim());
        }

        private void save_data()
        {
            US_DM_THAM_SO v_us_dm_tham_so = new US_DM_THAM_SO();
            form_2_us_obj(v_us_dm_tham_so);

            try
            {
                switch (m_e_form_mode)
                {
                    case DataEntryFormMode.InsertDataState:
                        v_us_dm_tham_so.BeginTransaction();
                        v_us_dm_tham_so.Insert();
                        v_us_dm_tham_so.CommitTransaction();
                        m_id_dm_tham_so_moi_tao = v_us_dm_tham_so.dcID;
                        if (CHRM_BaseMessages.MsgBox_Confirm(CONST_ID_MSGBOX.QUESTION_INSER_DM_THAM_SO_THANH_CONG_TIEP_TUC_INSERT_YN) == true)
                        {
                            refresh_form();
                        }
                        else
                        {
                            this.Close();
                        }
                        break;
                    case DataEntryFormMode.UpdateDataState:
                        v_us_dm_tham_so.dcID = m_id_dm_tham_so_4_update;
                        v_us_dm_tham_so.BeginTransaction();
                        v_us_dm_tham_so.Update();
                        v_us_dm_tham_so.CommitTransaction();
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
            m_txt_ten_tham_so.Text = "";
            m_txt_gia_tri_tham_so.BackColor = Color.White;
        }
        #endregion
        private void set_define_events()
        {
            this.Load += f108_dm_tham_so_de_Load;
            m_cmd_save.Click += m_cmd_save_Click;
            m_cmd_exit.Click += m_cmd_exit_Click;
            this.KeyDown += f108_dm_tham_so_de_KeyDown;
        }

        void f108_dm_tham_so_de_Load(object sender, EventArgs e)
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

        void f108_dm_tham_so_de_KeyDown(object sender, KeyEventArgs e)
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
