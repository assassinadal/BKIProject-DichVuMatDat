﻿using System;
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
    public partial class F105_dm_loai_ngay_cong_de : Form
    {
        public F105_dm_loai_ngay_cong_de()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += F105_dm_loai_ngay_cong_de_KeyDown;
        }

        void F105_dm_loai_ngay_cong_de_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
                {
                    this.Close();
                }
                if (e.KeyCode == Keys.Enter)
                {
                    
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        #region Public interface
        internal void DisplayForInsert()
        {
            this.Text = "F105 - Thêm loại ngày công";
            m_lbl_header.Text = "THÊM LOẠI NGÀY CÔNG";
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            this.CenterToScreen();
            this.ShowDialog();
        }

        internal void DisplayForUpdate(US.US_DM_LOAI_NGAY_CONG v_us)
        {
            this.Text = "F105 - Sửa loại ngày công";
            m_lbl_header.Text = "SỬA LOẠI NGÀY CÔNG";
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            m_us = v_us;
            us_to_form(m_us);
            this.CenterToScreen();
            this.ShowDialog();
        }
        #endregion
        
        #region Members
        DataEntryFormMode m_e_form_mode = new DataEntryFormMode();
        US_DM_LOAI_NGAY_CONG m_us = new US_DM_LOAI_NGAY_CONG();
        #endregion

        #region Private method
        private bool check_data_is_ok()
        {
            if (m_txt_ma_ngay_cong.Text == null || m_txt_ma_ngay_cong.Text == "")
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn phải nhập mã loại ngày công!", "THÔNG BÁO!");
                return false;
            }
            if (m_txt_ten_ngay_cong.Text == null || m_txt_ten_ngay_cong.Text == "")
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn phải nhập tên loại ngày công!", "THÔNG BÁO!");
                return false;
            }
            if (m_txt_ti_le_lns.Text == null || m_txt_ti_le_lns.Text == "")
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn phải nhập tỉ lệ lương năng suất!", "THÔNG BÁO!");
                return false;
            }
            if (m_txt_ti_le_lcd.Text == null || m_txt_ti_le_lcd.Text == "")
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn phải nhập tỉ lệ lương chế độ!", "THÔNG BÁO!");
                return false;
            }
            return true;
        }

        private void us_to_form(US_DM_LOAI_NGAY_CONG m_us)
        {
            m_txt_ma_ngay_cong.Text = m_us.strMA_NGAY_CONG;
            m_txt_ten_ngay_cong.Text = m_us.strTEN_NGAY_CONG;
            m_txt_ti_le_lns.Text = m_us.dcTI_LE_LNS.ToString();
            m_txt_ti_le_lcd.Text = m_us.dcTI_LE_LCD.ToString();
        }

        private void form_to_us(US_DM_LOAI_NGAY_CONG m_us)
        {
            m_us.strMA_NGAY_CONG = m_txt_ma_ngay_cong.Text;
            m_us.strTEN_NGAY_CONG = m_txt_ten_ngay_cong.Text;
            m_us.dcTI_LE_LNS = CIPConvert.ToDecimal(m_txt_ti_le_lns.Text);
            m_us.dcTI_LE_LCD = CIPConvert.ToDecimal(m_txt_ti_le_lcd.Text);
        }
        #endregion

        private void F105_dm_loai_ngay_cong_de_Load(object sender, EventArgs e)
        {
            FormatControl.SetVisibleSimpleButton(this);
        }

        private void m_cmd_save_Click(object sender, EventArgs e)
        {
            try
            {
                //Kiem tra dư lieu
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
                    this.Close();
                }               
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
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
