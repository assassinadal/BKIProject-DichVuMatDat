using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using BKI_DichVuMatDat;
using BKI_DichVuMatDat.US;
using BKI_DichVuMatDat.DS;
using BKI_DichVuMatDat.DS.CDBNames;

using IP.Core.IPCommon;
using DevExpress.XtraEditors;

namespace BKI_DichVuMatDat.DanhMuc
{
    public partial class F102_dm_bao_hiem_de : Form
    {
        public F102_dm_bao_hiem_de()
        {
            InitializeComponent();
            format_controls();
        }

        #region Public Interface
        public void DisplayForInsert()
        {
            this.Text = "F102 - Thêm bảo hiểm";
            m_lbl_header.Text = "THÊM BẢO HIỂM";
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            this.CenterToScreen();
            this.ShowDialog();
        }

        public void DisplayForUpdate(US_DM_BAO_HIEM v_us)
        {
            this.Text = "F102 - Sửa bảo hiểm";
            m_lbl_header.Text = "SỬA BẢO HIỂM";
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            m_us = v_us;
            us_to_form(m_us);
            this.CenterToScreen();
            this.ShowDialog();
        }
        #endregion

        #region Members
        DataEntryFormMode m_e_form_mode = new DataEntryFormMode();
        US_DM_BAO_HIEM m_us = new US_DM_BAO_HIEM();
        #endregion

        #region Private methods
        private void format_controls()
        {
            FormatControl.SetVisibleSimpleButton(this);
            set_define_events();
        }

        private void us_to_form(US_DM_BAO_HIEM v_us)
        {
            m_txt_ma_bao_hiem.Text = v_us.strMA_BH;
            m_txt_ten_bao_hiem.Text = v_us.strTEN_BH;
            m_txt_ti_le.Text = v_us.dcTI_LE.ToString();
        }

        private void form_to_us()
        {
            m_us.strMA_BH = m_txt_ma_bao_hiem.Text;
            m_us.strTEN_BH = m_txt_ten_bao_hiem.Text;
            m_us.dcTI_LE = CIPConvert.ToDecimal(m_txt_ti_le.Text);
        }

        private bool check_data_is_ok()
        {
            if (m_txt_ma_bao_hiem.Text == null || m_txt_ma_bao_hiem.Text == "")
            {
                CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_CHUA_NHAP_MA_BAO_HIEM);
                return false;
            }
            if (m_txt_ten_bao_hiem.Text == null || m_txt_ten_bao_hiem.Text == "")
            {
                CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_CHUA_NHAP_TEN_LOAI_BAO_HIEM);
                return false;
            }
            if (m_txt_ti_le.Text == null || m_txt_ti_le.Text == "")
            {
                CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_CHUA_NHAP_TI_LE);
                return false;
            }
            if (check_ma_bh_da_ton_tai())
            {
                string v_str_error = "Mã loại bảo hiểm đã tồn tại!";
                XtraMessageBox.Show(v_str_error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool check_ma_bh_da_ton_tai()
        {
            US_DM_BAO_HIEM v_us = new US_DM_BAO_HIEM();
            DS_DM_BAO_HIEM v_ds = new DS_DM_BAO_HIEM();
            v_us.FillDataset(v_ds, "where ma_bh = N'" + m_txt_ma_bao_hiem.Text + "'");
            if (m_us.strMA_BH != m_txt_ma_bao_hiem.Text && v_ds.Tables[0].Rows.Count != 0)
            {
                return true;
            }
            return false;
        }

        #endregion
        private void set_define_events()
        {
            this.Load += new System.EventHandler(this.F102_dm_bao_hiem_de_Load);
            m_cmd_save.Click += m_cmd_save_Click;
            m_cmd_exit.Click += m_cmd_exit_Click;
        }

        private void F102_dm_bao_hiem_de_Load(object sender, EventArgs e)
        {

        }

        private void m_cmd_save_Click(object sender, EventArgs e)
        {
            try
            {
                //Kiem tra du lieu
                if (check_data_is_ok() == true)
                {
                    //Dua du lieu vao US
                    form_to_us();
                    if (m_e_form_mode == DataEntryFormMode.InsertDataState)
                    {
                        m_us.Insert();
                    }
                    else
                    {
                        m_us.Update();
                    }
                    XtraMessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                    this.Close();
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_exit_Click(object sender, EventArgs e)
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
    }
}
