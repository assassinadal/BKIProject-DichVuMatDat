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
using BKI_DichVuMatDat.DS.CDBNames;

using System.Globalization;
using DevExpress.XtraEditors;
using IP.Core.IPCommon;
using IP.Core.IPSystemAdmin;

namespace BKI_DichVuMatDat.NghiepVu.ThuNhapKhac
{
    public partial class f304_tnk_ngoai_bang_luong_detail : Form
    {
        #region Public Interface
        public f304_tnk_ngoai_bang_luong_detail()
        {
            InitializeComponent();
        }
        #endregion

        #region Members
        DataEntryFormMode m_e_form_mode;
        US_GD_THU_NHAP_KHAC m_us_gd_tnk = new US_GD_THU_NHAP_KHAC();
        #endregion

        #region Private Method
        internal void display_for_insert()
        {
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            set_init_form_load();
            this.ShowDialog();
        }

        internal void display_for_update(US_GD_THU_NHAP_KHAC v_us)
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            set_init_form_load();
            m_us_gd_tnk = v_us;
            us_2_form(v_us);
            this.ShowDialog();
        }

        private void set_init_form_load()
        {
            set_define_events();
            load_data_to_sle_chon_nv();
            load_data_to_sle_quy_tien();
            if (m_e_form_mode == DataEntryFormMode.UpdateDataState)
            {
                m_sle_chon_nhan_vien.Enabled = false;
                //m_txt_thang.Enabled = false;
                //m_txt_nam.Enabled = false;
            }
            else if (m_e_form_mode == DataEntryFormMode.InsertDataState)
            {
                m_txt_so_tien.Text = "0";
                m_txt_so_tien_thue.Text = "0";
                m_txt_thuc_linh.Text = "0";
            }
        }

        private void us_2_form(US_GD_THU_NHAP_KHAC v_us)
        {
            m_sle_chon_nhan_vien.EditValue = v_us.dcID_NHAN_VIEN;
            m_sle_quy_tien.EditValue = v_us.dcID_QUY_THU_NHAP_KHAC;
            m_txt_so_tien.Text = v_us.dcSO_TIEN.ToString();
            m_txt_ly_do.Text = v_us.strLY_DO;
            //m_txt_thang.Text = v_us.dcTHANG.ToString();
            //m_txt_nam.Text = v_us.dcNAM.ToString();
           // m_sle_loai_thue.EditValue = v_us.dcID_CACH_TINH_THUE;
            m_txt_so_tien_thue.Text = v_us.dcSO_TIEN_NOP_THUE.ToString();
            m_txt_thuc_linh.Text = v_us.dcSO_TIEN_THUC_LINH.ToString();
        }

        private void set_define_events()
        {
            m_cmd_save.Click += m_cmd_save_Click;
            this.FormClosed += f304_tnk_ngoai_bang_luong_detail_FormClosed;
            this.Load += f304_tnk_ngoai_bang_luong_detail_Load;
        }

        private void load_data_to_sle_quy_tien()
        {
            DS_GD_QUY_THU_NHAP_KHAC v_ds = new DS_GD_QUY_THU_NHAP_KHAC();
            US_GD_QUY_THU_NHAP_KHAC v_us = new US_GD_QUY_THU_NHAP_KHAC();
            v_us.FillDatasetQuyTNKbyIDLoaiQuy(v_ds, 756);
            m_sle_quy_tien.Properties.DataSource = v_ds.Tables[0];
        }

        private void load_data_to_sle_chon_nv()
        {
            
            DS_V_DM_NHAN_VIEN v_ds = new DS_V_DM_NHAN_VIEN();
            US_V_DM_NHAN_VIEN v_us = new US_V_DM_NHAN_VIEN();           
            v_us.FillDataset(v_ds);
            m_sle_chon_nhan_vien.Properties.DataSource = v_ds.Tables[0];
        }

        private void save_data()
        {
            if (check_validate_data_is_ok())
            {
                form_2_us();
                switch (m_e_form_mode)
                {
                    case DataEntryFormMode.InsertDataState:
                        m_us_gd_tnk.Insert();
                        break;
                    case DataEntryFormMode.UpdateDataState:
                        m_us_gd_tnk.Update();
                        break;
                }
                this.Close();
                XtraMessageBox.Show("Lưu thành công!");
            }
            else return;
        }

        private bool check_validate_data_is_ok()
        {
            if (m_sle_chon_nhan_vien.EditValue == null)
            {
                CHRM_BaseMessages.MsgBox_Error("Vui lòng chọn nhân viên!");
                return false;
            }
            else if (m_sle_quy_tien.EditValue == null)
            {
                CHRM_BaseMessages.MsgBox_Error("Vui lòng chọn quỹ tiền!");
                return false;
            }
            //else if (m_txt_thang.Text.Trim() == "" )
            //{
            //    CHRM_BaseMessages.MsgBox_Error("Vui lòng nhập tháng còn thiếu!");
            //    return false;
            //}
            //else if (m_txt_nam.Text.Trim() == "")
            //{
            //    CHRM_BaseMessages.MsgBox_Error("Vui lòng nhập năm còn thiếu!");
            //    return false;
            //}
            else if (m_txt_so_tien.Text.Trim() =="" || m_txt_thuc_linh.Text.Trim() == "")
            {
                CHRM_BaseMessages.MsgBox_Error("Vui lòng nhập số tiền còn thiếu!");
                return false;
            }
            return true;
        }

        private void form_2_us()
        {
            m_us_gd_tnk.dcID_NHAN_VIEN = CIPConvert.ToDecimal(m_sle_chon_nhan_vien.EditValue.ToString());
            m_us_gd_tnk.dcSO_TIEN = CIPConvert.ToDecimal(m_txt_so_tien.Text);
            decimal v_id_quy = CIPConvert.ToDecimal(m_sle_quy_tien.EditValue.ToString());
            m_us_gd_tnk.dcID_QUY_THU_NHAP_KHAC = v_id_quy;
            m_us_gd_tnk.dcTHANG = get_thang_theo_quy(v_id_quy);
            m_us_gd_tnk.dcNAM = get_nam_theo_quy(v_id_quy);
            m_us_gd_tnk.strLY_DO = m_txt_ly_do.Text;          
           // m_us_gd_tnk.dcID_CACH_TINH_THUE = CIPConvert.ToDecimal(m_sle_loai_thue.EditValue.ToString());
            m_us_gd_tnk.dcID_LOAI_THU_NHAP_KHAC = 756;
          //  m_us_gd_tnk.dcSO_TIEN_GIAM_TRU = 0;
            m_us_gd_tnk.dcSO_TIEN_NOP_THUE = CIPConvert.ToDecimal(m_txt_so_tien_thue.Text);
            m_us_gd_tnk.dcSO_TIEN_THUC_LINH = CIPConvert.ToDecimal(m_txt_thuc_linh.Text);
           // m_us_gd_tnk.dcTHUC_LINH_CUOI_CUNG = CIPConvert.ToDecimal(m_txt_thuc_linh.Text);
        }

        private decimal get_thang_theo_quy(decimal v_id_quy)
        {
            US_GD_QUY_THU_NHAP_KHAC v_us = new US_GD_QUY_THU_NHAP_KHAC();
            DS_GD_QUY_THU_NHAP_KHAC v_ds = new DS_GD_QUY_THU_NHAP_KHAC();
            v_us.FillDataset(v_ds, "where id=" + v_id_quy);
            return decimal.Parse(v_ds.Tables[0].Rows[0][2].ToString());
        }

        private decimal get_nam_theo_quy(decimal v_id_quy)
        {
            US_GD_QUY_THU_NHAP_KHAC v_us = new US_GD_QUY_THU_NHAP_KHAC();
            DS_GD_QUY_THU_NHAP_KHAC v_ds = new DS_GD_QUY_THU_NHAP_KHAC();
            v_us.FillDataset(v_ds, "where id=" + v_id_quy);
            return decimal.Parse(v_ds.Tables[0].Rows[0][3].ToString());
        }

        #endregion

        #region Event Handle
        void f304_tnk_ngoai_bang_luong_detail_Load(object sender, EventArgs e)
        {
            try
            {
                load_data_to_sle_chon_nv();
                load_data_to_sle_quy_tien();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void f304_tnk_ngoai_bang_luong_detail_FormClosed(object sender, FormClosedEventArgs e)
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

        void m_cmd_save_Click(object sender, EventArgs e)
        {
            try
            {
                save_data();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        
        #endregion

    }
}
