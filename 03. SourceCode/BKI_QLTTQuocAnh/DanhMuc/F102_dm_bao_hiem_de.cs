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

namespace BKI_DichVuMatDat.DanhMuc
{
    public partial class F102_dm_bao_hiem_de : Form
    {
        public F102_dm_bao_hiem_de()
        {
            InitializeComponent();
        }

        #region Public Interface

        #endregion

        #region Members
        DataEntryFormMode m_e_form_mode = new DataEntryFormMode();
        US_DM_BAO_HIEM m_us = new US_DM_BAO_HIEM();
        #endregion

        private void F102_dm_bao_hiem_de_Load(object sender, EventArgs e)
        {

        }

        internal void DisplayForInsert()
        {
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            this.ShowDialog();
        }

        internal void DisplayForUpdate(US_DM_BAO_HIEM v_us)
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            m_us = v_us;
            us_to_form(m_us);
            this.ShowDialog();
        }

        private void us_to_form(US_DM_BAO_HIEM v_us)
        {
            m_txt_ma_bao_hiem.Text = v_us.strMA_BH;
            m_txt_ten_bao_hiem.Text = v_us.strTEN_BH;
            m_txt_ti_le.Text = v_us.dcTI_LE.ToString();
        }

        private bool check_data_is_ok()
        {
            if (m_txt_ma_bao_hiem.Text == null || m_txt_ma_bao_hiem.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã bảo hiểm!", "THÔNG BÁO!");
                return false;
            }
            if (m_txt_ten_bao_hiem.Text == null || m_txt_ten_bao_hiem.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tên loại bảo hiểm!", "THÔNG BÁO!");
                return false;
            }
            if (m_txt_ti_le.Text == null || m_txt_ti_le.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tỉ lệ!", "THÔNG BÁO!");
                return false;
            }
            return true;
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
                    this.Close();
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void form_to_us()
        {
            m_us.strMA_BH = m_txt_ma_bao_hiem.Text;
            m_us.strTEN_BH = m_txt_ten_bao_hiem.Text;
            m_us.dcTI_LE = CIPConvert.ToDecimal(m_txt_ti_le.Text);
        }

        private void m_cmd_cancel_Click(object sender, EventArgs e)
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
