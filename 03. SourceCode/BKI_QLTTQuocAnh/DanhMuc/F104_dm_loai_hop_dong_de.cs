using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using IP.Core.IPCommon;
using BKI_DichVuMatDat.US;

namespace BKI_DichVuMatDat.DanhMuc
{
    public partial class F104_dm_loai_hop_dong_de : Form
    {
        public F104_dm_loai_hop_dong_de()
        {
            InitializeComponent();
        }

        #region Public Interface

        #endregion

        #region Members
        DataEntryFormMode m_e_form_mode = new DataEntryFormMode();
        US_DM_LOAI_HOP_DONG m_us = new US_DM_LOAI_HOP_DONG();
        #endregion
        internal void DisplayForInsert()
        {
            this.Text = "F104 - Thêm loại hợp đồng";
            m_lbl_header.Text = "THÊM LOẠI HỢP ĐỒNG";
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            this.CenterToScreen();
            this.ShowDialog();
        }

        internal void DisplayForUpdate(US_DM_LOAI_HOP_DONG v_us)
        {
            this.Text = "F104 - Sửa loại hợp đồng";
            m_lbl_header.Text = "SỬA LOẠI HỢP ĐỒNG";
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            m_us = v_us;
            us_to_form(m_us);
            this.CenterToScreen();
            this.ShowDialog();
        }

        private void us_to_form(US_DM_LOAI_HOP_DONG m_us)
        {
            m_txt_ma_loai_hop_dong.Text = m_us.strMA_LOAI_HOP_DONG;
            m_txt_ten_loai_hop_dong.Text = m_us.strLOAI_HOP_DONG;
            m_txt_ti_le.Text = m_us.dcTI_LE.ToString();
            m_txt_so_tien.Text = m_us.dcSO_TIEN.ToString();
            if (m_us.strAN_CA_YN == "Y")
            {
                m_rbtn_an_ca_yes.Checked = true;
            }
            else
            {
                m_rbtn_an_ca_no.Checked = true;
            }

            if (m_us.strHS_LNS_YN == "Y")
            {
                m_rbtn_hs_lns_yes.Checked = true;
            }
            else
            {
                m_rbtn_hs_lns_no.Checked = true;
            }

            if (m_us.strLCD_YN == "Y")
            {
                m_rbtn_lcd_yes.Checked = true;
            }
            else
            {
                m_rbtn_lcd_no.Checked = true; ;
            }
        }

        private void F104_dm_loai_hop_dong_de_Load(object sender, EventArgs e)
        {

        }

        private bool check_data_is_ok()
        {
            if (m_txt_ma_loai_hop_dong.Text == null || m_txt_ma_loai_hop_dong.Text == "")
            {
                MessageBox.Show("Bạn phải điền mã loại hợp đồng!", "THÔNG BÁO");
                return false;
            }
            if (m_txt_ten_loai_hop_dong.Text == null || m_txt_ten_loai_hop_dong.Text == "")
            {
                MessageBox.Show("Bạn phải điền tên loại hợp đồng!", "THÔNG BÁO");
                return false;
            }
            if (m_txt_ti_le.Text == null || m_txt_ti_le.Text == "")
            {
                MessageBox.Show("Bạn phải ghi tỉ lệ!", "THÔNG BÁO");
                return false;
            }
            if (m_txt_so_tien.Text == null || m_txt_so_tien.Text == "")
            {
                MessageBox.Show("Bạn phải ghi số tiền!", "THÔNG BÁO");
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
                    form_to_us(m_us);
                    if (m_e_form_mode == DataEntryFormMode.InsertDataState)
                    {
                        m_us.Insert();
                    }
                    else
                    {
                        m_us.Update();
                    }
                }
                this.Close();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void form_to_us(US_DM_LOAI_HOP_DONG m_us)
        {
            m_us.strMA_LOAI_HOP_DONG = m_txt_ma_loai_hop_dong.Text;
            m_us.strLOAI_HOP_DONG = m_txt_ten_loai_hop_dong.Text;
            m_us.dcTI_LE = CIPConvert.ToDecimal(m_txt_ti_le.Text);
            m_us.dcSO_TIEN = CIPConvert.ToDecimal(m_txt_so_tien.Text);

            if (m_rbtn_an_ca_yes.Checked == true)
            {
                m_us.strAN_CA_YN = "Y";
            }
            else
                m_us.strAN_CA_YN = "N";

            if (m_rbtn_hs_lns_yes.Checked == true)
            {
                m_us.strHS_LNS_YN = "Y";
            }
            else
            {
                m_us.strHS_LNS_YN = "N";
            }

            if (m_rbtn_lcd_yes.Checked == true)
            {
                m_us.strLCD_YN = "Y";
            }
            else
            {
                m_us.strLCD_YN = "N";
            }
        }
    }
}
