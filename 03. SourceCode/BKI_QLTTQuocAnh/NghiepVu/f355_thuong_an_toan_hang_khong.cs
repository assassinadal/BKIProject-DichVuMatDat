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
using IP.Core.IPSystemAdmin;
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
            try
            {
                SplashScreenManager.ShowForm(typeof(F_wait_form));
                DataSet v_ds = new DataSet();
                v_ds.Tables.Add();
                m_us_hs_bs_athk = new US_GD_HS_BO_SUNG_AN_TOAN_HANG_KHONG();
                m_us_hs_bs_athk.load_du_lieu_bang_luong_theo_hs_athk(v_ds
                                                                , m_dat_tu_ngay.DateTime
                                                                , m_dat_den_ngay.DateTime
                                                                , CIPConvert.ToDecimal(m_txt_so_tien.EditValue)
                                                                , m_chk_giam_tru.Checked == true ? "Y" : "N"
                                                                , m_dat_thang_thuong.DateTime.Month
                                                                , m_dat_thang_thuong.DateTime.Year);

                m_grc_luong_thuong.DataSource = v_ds.Tables[0];
                m_grc_luong_thuong.RefreshDataSource();
                SplashScreenManager.CloseForm();
            }
            catch(Exception)
            {
                SplashScreenManager.CloseForm();
                throw;
            }
            
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
        private void data_row_2_us(DataRow dr, ref US_GD_TIEN_THUONG_NHAN_VIEN ref_us)
        {
            ref_us.dcID_NHAN_VIEN = CIPConvert.ToDecimal(dr["ID_NHAN_VIEN"].ToString());
            ref_us.dcSO_TIEN = CIPConvert.ToDecimal(dr["SO_TIEN_THUONG_NV"].ToString());
            ref_us.dcTHANG = m_dat_thang_thuong.DateTime.Month;
            ref_us.dcNAM = m_dat_thang_thuong.DateTime.Year;
            ref_us.dcID_LOAI_TIEN_THUONG = CONST_ID_TIEN_THUONG.THUONG_ATHK;
            ref_us.strDA_XOA = "N";
        }
        private void luu_so_tien_vao_quy_tien(US_GD_THU_NHAP_KHAC ip_trans_of_us)
        {
            US_GD_QUY_TIEN_THUONG v_us_quy_tien_thuong = new US_GD_QUY_TIEN_THUONG();
            //xoa_quy_tien_hs_bs_trong_nam();
            try
            {
                v_us_quy_tien_thuong.dcSO_TIEN = CIPConvert.ToDecimal(m_txt_so_tien.EditValue);
                v_us_quy_tien_thuong.strTHANG = m_dat_thang_thuong.DateTime.Month.ToString();
                v_us_quy_tien_thuong.strNAM = m_dat_thang_thuong.DateTime.Year.ToString();
                v_us_quy_tien_thuong.strNGUOI_LAP = CAppContext_201.getCurrentUserName();
                v_us_quy_tien_thuong.dcID_LOAI_QUY_TIEN = CONST_ID_TIEN_THUONG.THUONG_ATHK;
                v_us_quy_tien_thuong.strDA_XOA = "N";
                v_us_quy_tien_thuong.UseTransOfUSObject(ip_trans_of_us);
                v_us_quy_tien_thuong.Insert();
            }
            catch(Exception v_e)
            {
                throw v_e;
            }
        }
        private void luu_thang_da_giam_tru(US_GD_THU_NHAP_KHAC ip_trans_of_us)
        {
            US_GD_THANG_DA_GIAM_TRU v_us_thang_da_giam_tru = new US_GD_THANG_DA_GIAM_TRU();
            try
            {
                v_us_thang_da_giam_tru.strTHANG = m_dat_thang_thuong.DateTime.Month.ToString();
                v_us_thang_da_giam_tru.strNAM = m_dat_thang_thuong.DateTime.Year.ToString();
                v_us_thang_da_giam_tru.strGIAM_TRU_YN = "Y";
                v_us_thang_da_giam_tru.strNGUOI_LAP = CAppContext_201.getCurrentUserName();
                v_us_thang_da_giam_tru.datNGAY_LAP = DateTime.Now.Date;
                v_us_thang_da_giam_tru.strDA_XOA = "N";
                v_us_thang_da_giam_tru.UseTransOfUSObject(ip_trans_of_us);
                v_us_thang_da_giam_tru.Insert();
            }
            catch(Exception v_e)
            {
                throw v_e;
            }
        }
        private void luu_so_tien_sau_thue_vao_gd_tien_thuong(DataSet ip_ds)
        {
            for(int i = 0; i < ip_ds.Tables[0].Rows.Count; i++)
            {
                US_GD_TIEN_THUONG_NHAN_VIEN v_us_tien_thuong_nv = new US_GD_TIEN_THUONG_NHAN_VIEN();
                v_us_tien_thuong_nv.dcID_NHAN_VIEN = CIPConvert.ToDecimal(ip_ds.Tables[0].Rows[i]["ID_NHAN_VIEN"]);
                v_us_tien_thuong_nv.dcSO_TIEN = CIPConvert.ToDecimal(ip_ds.Tables[0].Rows[i]["SO_TIEN_SAU_TINH_THUE"]);
                v_us_tien_thuong_nv.dcTHANG = CIPConvert.ToDecimal(DateTime.Now.Month.ToString());
                v_us_tien_thuong_nv.dcNAM = CIPConvert.ToDecimal(ip_ds.Tables[0].Rows[i]["NAM"]);
                v_us_tien_thuong_nv.dcID_LOAI_TIEN_THUONG = CONST_ID_TIEN_THUONG.THUONG_HS_BS;
                //nguoi lap
                v_us_tien_thuong_nv.datNGAY_LAP = DateTime.Now.Date;
                //nguoi sua 
                //ngay sua
                v_us_tien_thuong_nv.strDA_XOA = "N";
                v_us_tien_thuong_nv.Insert();
            }
        }
        private void save_data()
        {
            try
            {
                if(m_grv_luong_thuong.RowCount <= 0)
                {
                    return;
                }
                //B1: GetList Object to insert
                SplashScreenManager.ShowForm(typeof(F_wait_form));
                US_GD_THU_NHAP_KHAC v_us = new US_GD_THU_NHAP_KHAC();
                US_GD_TIEN_THUONG_NHAN_VIEN v_us_tien_thuong_nv = new US_GD_TIEN_THUONG_NHAN_VIEN();
                v_us.BeginTransaction();
                
                luu_so_tien_vao_quy_tien(v_us);
                if(m_chk_giam_tru.Checked == true)
                {
                    luu_thang_da_giam_tru(v_us);
                }
                for(int rowHandle = 0; rowHandle < m_grv_luong_thuong.RowCount; rowHandle++)
                {
                    var dr = m_grv_luong_thuong.GetDataRow(rowHandle);
                    data_row_2_us(dr, ref v_us);
                    data_row_2_us(dr, ref v_us_tien_thuong_nv);
                    if(v_us.dcSO_TIEN > 0)
                    {
                        v_us.Insert();
                        v_us_tien_thuong_nv.UseTransOfUSObject(v_us);
                        v_us_tien_thuong_nv.Insert();
                    }
                    v_us.ClearAllFields();
                }
                v_us.CommitTransaction();
                SplashScreenManager.CloseForm();
                DevExpress.XtraEditors.XtraMessageBox.Show("Lưu dữ liệu thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                SplashScreenManager.CloseForm();
            }
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
            m_dat_thang_thuong.EditValueChanged += m_dat_thang_thuong_EditValueChanged;
            m_chk_giam_tru.CheckedChanged += m_chk_giam_tru_CheckedChanged;
        }

        void m_chk_giam_tru_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if(m_chk_giam_tru.CheckState == CheckState.Unchecked)
                {
                    m_chk_giam_tru.Enabled = true;
                }
                else if(m_chk_giam_tru.CheckState == CheckState.Checked)
                {
                    m_chk_giam_tru.Enabled = false;
                }
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_dat_thang_thuong_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                US_GD_THANG_DA_GIAM_TRU v_us = new US_GD_THANG_DA_GIAM_TRU();
                decimal op_dc_giam_tru = 0;
                v_us.kiem_tra_thang_da_giam_tru_chua(m_dat_thang_thuong.DateTime.Month, m_dat_thang_thuong.DateTime.Year, ref op_dc_giam_tru);

                m_chk_giam_tru.Checked = op_dc_giam_tru == 0 ? false : true;
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
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
