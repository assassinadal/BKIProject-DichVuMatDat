using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IP.Core.IPCommon;
using BKI_DichVuMatDat.US;
using DevExpress.XtraSplashScreen;
using BKI_DichVuMatDat.BaoCao;
using DevExpress.XtraEditors.Popup;
using DevExpress.Utils.Win;
namespace BKI_DichVuMatDat.NghiepVu
{
    public partial class f355_thuong_an_toan_hang_khong : Form
    {
        #region Public interface
        public f355_thuong_an_toan_hang_khong()
        {
            InitializeComponent();
            format_control();
        }
        ~f355_thuong_an_toan_hang_khong()
        {
            Dispose(false);
        }
        #endregion

        #region Member
        US_GD_HS_BO_SUNG_AN_TOAN_HANG_KHONG m_us_hs_bs_athk;
        US_GD_THU_NHAP_KHAC m_us_thu_nhap_khac;
        #endregion

        #region Private method
        private void format_control()
        {
            //Format control here
            FormatControl.SetVisibleSimpleButton(this);
            set_define_event();
        }

        private void fill_data_to_grid()
        {
            SplashScreenManager.ShowForm(typeof(F_wait_form));
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add();
            m_us_hs_bs_athk = new US_GD_HS_BO_SUNG_AN_TOAN_HANG_KHONG();
            m_us_hs_bs_athk.load_du_lieu_bang_luong_theo_hs_athk(v_ds, m_dat_tu_ngay.DateTime, m_dat_den_ngay.DateTime, CIPConvert.ToDecimal(m_txt_so_tien.EditValue));

            m_grc_luong_thuong.DataSource = v_ds.Tables[0];
            m_grc_luong_thuong.RefreshDataSource();
            SplashScreenManager.CloseForm();
        }

        private void set_inital_form_load()
        {

        }

        //private void set_label_dem_so_thang_xet_thuong()
        //{
        //    if (!ValidateControlEmpty(m_dat_tu_ngay, m_dat_den_ngay))
        //    {
        //        return;
        //    }
        //    var v_count_so_thang_xet_thuong = (m_dat_den_ngay.DateTime.Year - m_dat_tu_ngay.DateTime.Year) * 12 
        //                                            + m_dat_den_ngay.DateTime.Month - m_dat_tu_ngay.DateTime.Month + 1;
        //    m_lbl_so_thang_xet_thuong.Text = "Đang xét " + v_count_so_thang_xet_thuong.ToString();
        //}
        private bool ValidateControlEmpty(params Control[] controls)
        {
            var isValidated = false;

            foreach (var control in controls)
            {
                control.BackColor = Color.White;
                var typeOfControl = control.GetType().ToString();

                switch (typeOfControl)
                {
                    case "DevExpress.XtraEditors.TextEdit":
                        {
                            var controlTextEdit = control as TextEdit;
                            isValidated = (controlTextEdit.Text.Trim() != "");
                            break;
                        }
                    case "DevExpress.XtraEditors.MemoEdit":
                        {
                            var controlMemoEdit = control as MemoEdit;
                            isValidated = (controlMemoEdit.Text.Trim() != "");
                            break;
                        }
                    case "DevExpress.XtraEditors.DateEdit":
                        {
                            var controlDateEdit = control as DateEdit;
                            isValidated = (controlDateEdit.EditValue != null);
                            break;
                        }
                    case "DevExpress.XtraEditors.ComboBoxEdit":
                        {
                            var controlComboBoxEdit = control as ComboBoxEdit;
                            isValidated = (controlComboBoxEdit.EditValue != null);
                            break;
                        }
                    case "DevExpress.XtraEditors.ButtonEdit":
                        {
                            var controlButtonEdit = control as ButtonEdit;
                            isValidated = (controlButtonEdit.EditValue != null);
                            break;
                        }
                    case "DevExpress.XtraEditors.CheckEdit":
                        {
                            var controlCheckEdit = control as CheckEdit;
                            isValidated = (controlCheckEdit.EditValue != null);
                            break;
                        }
                    case "DevExpress.XtraEditors.SpinEdit":
                        {
                            var controlSpinEdit = control as SpinEdit;
                            isValidated = (controlSpinEdit.EditValue != null);
                            break;
                        }
                    case "DevExpress.XtraEditors.LookUpEdit":
                        {
                            var controlLookUpEdit = control as LookUpEdit;
                            isValidated = (controlLookUpEdit.EditValue != null);
                            break;
                        }
                    case "DevExpress.XtraEditors.SearchLookUpEdit":
                        {
                            var controlSearchLookUpEdit = control as SearchLookUpEdit;
                            isValidated = (controlSearchLookUpEdit.EditValue != null && controlSearchLookUpEdit.EditValue.ToString().Trim() != string.Empty);
                            break;
                        }
                    case "DevExpress.XtraEditors.CheckedComboBoxEdit":
                        {
                            var controlCheckedComboBoxEdit = control as CheckedComboBoxEdit;
                            isValidated = (controlCheckedComboBoxEdit.EditValue != null && controlCheckedComboBoxEdit.EditValue.ToString().Trim() != string.Empty);
                            break;
                        }
                    default:
                        break;
                }

                if (!isValidated)
                {
                    control.Focus();
                    control.BackColor = Color.Pink;
                    break;
                }
            }
            return isValidated;
        }
        private bool is_valid_data()
        {
            if (ValidateControlEmpty(m_dat_tu_ngay, m_dat_den_ngay, m_txt_so_tien, m_txt_ly_do_thuong, m_dat_thang_thuong))
            {
                return false;
            }
            return true;
        }
        private void data_row_2_us(DataRow dr, ref US_GD_THU_NHAP_KHAC ref_us)
        {
            ref_us.dcID_NHAN_VIEN = CIPConvert.ToDecimal(dr["ID_NHAN_VIEN"].ToString());
            ref_us.dcSO_TIEN = CIPConvert.ToDecimal(dr["SO_TIEN_THUONG_NV"].ToString());
            ref_us.dcTHANG = m_dat_thang_thuong.DateTime.Month;
            ref_us.dcNAM = m_dat_thang_thuong.DateTime.Year;
            ref_us.strLY_DO = m_txt_ly_do_thuong.Text;
            ref_us.dcID_CACH_TINH_THUE = CONST_ID_CACH_TINH_THUE.THUE_THANG;
            ref_us.dcID_LOAI_THU_NHAP_KHAC = CONST_ID_LOAI_THU_NHAP_KHAC.LINH_CO_THUE;
        }
        private void save_data()
        {
            if (m_grv_luong_thuong.RowCount <= 0)
            {
                return;
            }
            //B1: GetList Object to insert
            SplashScreenManager.ShowForm(typeof(F_wait_form));
            US_GD_THU_NHAP_KHAC v_us = new US_GD_THU_NHAP_KHAC();
            v_us.BeginTransaction();
            for (int rowHandle = 0; rowHandle < m_grv_luong_thuong.RowCount; rowHandle++)
            {
                var dr = m_grv_luong_thuong.GetDataRow(rowHandle);
                data_row_2_us(dr, ref v_us);
                if (v_us.dcSO_TIEN > 0)
                {
                    v_us.Insert();
                }
                v_us.ClearAllFields();
            }
            v_us.CommitTransaction();
            SplashScreenManager.CloseForm();
            XtraMessageBox.Show("Lưu dữ liệu thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region Event Handle
        private void set_define_event()
        {
            FormClosed += f355_thuong_an_toan_hang_khong_FormClosed;
            Load += f355_thuong_an_toan_hang_khong_Load;
            m_cmd_tinh_tien_thuong.Click += m_cmd_tinh_tien_thuong_Click;
            m_cmd_save_data.Click += m_cmd_save_data_Click;
            m_dat_tu_ngay.EditValueChanged += m_dat_tu_ngay_EditValueChanged;
            m_dat_den_ngay.EditValueChanged += m_dat_den_ngay_EditValueChanged;
        }

        void m_dat_den_ngay_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                m_dat_tu_ngay.EditValue = m_dat_den_ngay.DateTime.AddYears(-1).AddDays(1);
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_dat_tu_ngay_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                m_dat_den_ngay.EditValue = m_dat_tu_ngay.DateTime.AddYears(1).AddDays(-1);
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_save_data_Click(object sender, EventArgs e)
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

        void m_cmd_tinh_tien_thuong_Click(object sender, EventArgs e)
        {
            try
            {
                if (is_valid_data())
                {
                    return;
                }
                fill_data_to_grid();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void f355_thuong_an_toan_hang_khong_Load(object sender, EventArgs e)
        {
            try
            {
                set_inital_form_load();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void f355_thuong_an_toan_hang_khong_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Dispose();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        #endregion
    }
}
