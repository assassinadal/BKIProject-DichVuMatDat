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
using IP.Core.IPUserService;
using BKI_DichVuMatDat.DS.CDBNames;
using BKI_DichVuMatDat.DS;

namespace BKI_DichVuMatDat.NghiepVu
{
    public partial class f355_thuong_an_toan_hang_khong : Form
    {
        enum IS_GIAM_TRU
        {
            DA_GIA_TRU,
            CHUA_GIAM_TRU
        }

        IS_GIAM_TRU m_is_giam_tru;

        US_V_GD_QUY_TIEN_THUONG m_us_v_gd_quy_tien_thuong;

        #region Public interface
        public f355_thuong_an_toan_hang_khong()
        {
            InitializeComponent();
            format_control();
        }
        public f355_thuong_an_toan_hang_khong(decimal ip_dc_id_quy_tien)
        {
            InitializeComponent();
            format_control();
            fill_data_2_control(ip_dc_id_quy_tien);
        }
        ~f355_thuong_an_toan_hang_khong()
        {
            Dispose(false);
        }
        #endregion

        #region Private method
        private void set_text_thong_tin_da_tinh_luong()
        {
            US_V_GD_QUY_TIEN_THUONG v_us_quy = new US_V_GD_QUY_TIEN_THUONG();
            DataRow v_dr;
            v_us_quy.lay_thong_tin_qua_trinh_tinh_luong(out v_dr, m_us_v_gd_quy_tien_thuong.dcID);
            m_lbl_thong_tin.Text = "Đã tính " + v_dr[V_GD_QUY_TIEN_THUONG.SL_NV_DA_TINH] + " / " + v_dr[V_GD_QUY_TIEN_THUONG.SL_NV_CAN_TINH] + " (nhân viên)";
        }
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
                US_DUNG_CHUNG v_us_dung_chung = new US_DUNG_CHUNG();
                DataSet v_ds = new DataSet();
                v_ds.Tables.Add();
                v_us_dung_chung.FillDatasetWithQuery(v_ds, "select * from V_GD_THU_NHAP_KHAC_2");
               
                //m_us_hs_bs_athk = new US_GD_HS_BO_SUNG_AN_TOAN_HANG_KHONG();
                //m_us_hs_bs_athk.load_du_lieu_bang_luong_theo_hs_athk(v_ds
                //                                                , m_dat_tu_ngay.DateTime
                //                                                , m_dat_den_ngay.DateTime
                //                                                , CIPConvert.ToDecimal(m_txt_so_tien.EditValue)
                //                                                , m_chk_giam_tru.Checked == true ? "Y" : "N"
                //                                                , m_dat_thang_thuong.DateTime.Month
                //                                                , m_dat_thang_thuong.DateTime.Year);

                m_grc_luong_thuong.DataSource = v_ds.Tables[0];
                m_grc_luong_thuong.RefreshDataSource();

                CHRMCommon.make_stt_indicator(m_grv_luong_thuong);
                set_text_thong_tin_da_tinh_luong();
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
        
        private void fill_data_2_control(decimal ip_dc_id_quy_tien)
        {
            m_us_v_gd_quy_tien_thuong = new US_V_GD_QUY_TIEN_THUONG(ip_dc_id_quy_tien);
            m_txt_ten_quy.Text = m_us_v_gd_quy_tien_thuong.strTEN_QUY;
            m_dat_thang_thuong.DateTime = new DateTime((int)CIPConvert.ToDecimal(m_us_v_gd_quy_tien_thuong.strNAM)
                                                            , (int)CIPConvert.ToDecimal(m_us_v_gd_quy_tien_thuong.strTHANG)
                                                            , 01);
            m_dat_tu_ngay.DateTime = m_us_v_gd_quy_tien_thuong.datTU_NGAY_XET_THUONG;
            m_dat_den_ngay.DateTime = m_us_v_gd_quy_tien_thuong.datDEN_NGAY_XET_THUONG;
            m_txt_so_tien.EditValue = m_us_v_gd_quy_tien_thuong.dcSO_TIEN;
        }


        private bool validate_control_empty(params Control[] controls)
        {
            var isValidated = false;

            foreach(var control in controls)
            {
                control.BackColor = Color.White;
                var typeOfControl = control.GetType().ToString();

                switch(typeOfControl)
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

                if(!isValidated)
                {
                    control.Focus();
                    control.BackColor = Color.Pink;
                    break;
                }
            }
            return isValidated;
        }
        private bool is_valid_data_before_tinh_luong()
        {
            if(validate_control_empty(m_dat_tu_ngay, m_dat_den_ngay, m_txt_so_tien, m_dat_thang_thuong))
            {
                return false;
            }
            return true;
        }
        private void data_row_2_us(DataRow ip_dr_du_lieu_1_nv, ref US_GD_THU_NHAP_KHAC ref_us)
        {
            ref_us.dcID_NHAN_VIEN = CIPConvert.ToDecimal(ip_dr_du_lieu_1_nv["ID_NHAN_VIEN"]);
            ref_us.dcSO_TIEN = CIPConvert.ToDecimal(ip_dr_du_lieu_1_nv["SO_TIEN_THUONG_NV"].ToString());
            ref_us.dcTHANG = m_dat_thang_thuong.DateTime.Month;
            ref_us.dcNAM = m_dat_thang_thuong.DateTime.Year;
            ref_us.dcID_CACH_TINH_THUE = CONST_ID_LOAI_CACH_TINH_THUE.THUE_THANG;
            ref_us.dcID_LOAI_THU_NHAP_KHAC = CONST_ID_LOAI_THU_NHAP_KHAC.LINH_CO_THUE;
            ref_us.dcID_QUY_TIEN_THUONG = m_us_v_gd_quy_tien_thuong.dcID;

            ref_us.dcSO_TIEN_GIAM_TRU = CIPConvert.ToDecimal(ip_dr_du_lieu_1_nv["SO_TIEN_GIAM_TRU"]);
            ref_us.dcSO_TIEN_NOP_THE = CIPConvert.ToDecimal(ip_dr_du_lieu_1_nv["SO_THUE_PHAI_NOP"]);
            ref_us.dcSO_TIEN_THUC_LINH = CIPConvert.ToDecimal(ip_dr_du_lieu_1_nv["THUC_LINH"]);
            ref_us.dcTONG_HS_ATHK = CIPConvert.ToDecimal(ip_dr_du_lieu_1_nv["TONG_HS_ATHK"]);
        }

        private void luu_thang_da_giam_tru()
        {
            US_GD_THANG_DA_GIAM_TRU v_us_thang_da_giam_tru = new US_GD_THANG_DA_GIAM_TRU();
            decimal op_dc_thang_da_giam_tru = 0;
            v_us_thang_da_giam_tru.kiem_tra_thang_da_giam_tru_chua(m_dat_thang_thuong.DateTime.Month
                                                                            , m_dat_thang_thuong.DateTime.Year
                                                                            , ref op_dc_thang_da_giam_tru);
            if(op_dc_thang_da_giam_tru == 1)
            {
                return;
            }
            v_us_thang_da_giam_tru.strTHANG = m_dat_thang_thuong.DateTime.Month.ToString();
            v_us_thang_da_giam_tru.strNAM = m_dat_thang_thuong.DateTime.Year.ToString();
            v_us_thang_da_giam_tru.strGIAM_TRU_YN = "Y";
            v_us_thang_da_giam_tru.strNGUOI_LAP = CAppContext_201.getCurrentUserName();
            v_us_thang_da_giam_tru.datNGAY_LAP = DateTime.Now.Date;
            v_us_thang_da_giam_tru.strDA_XOA = "N";
            v_us_thang_da_giam_tru.Insert();
        }
        
        private DS_DM_NHAN_VIEN lay_danh_sach_nhan_vien_chua_tinh_thuong()
        {
            US_GD_THU_NHAP_KHAC v_us_gd_thu_nhap_khac = new US_GD_THU_NHAP_KHAC();
            DS_DM_NHAN_VIEN op_ds;
            v_us_gd_thu_nhap_khac.Get_tat_ca_nhan_vien_can_tinh_thuong(out op_ds, m_us_v_gd_quy_tien_thuong.dcID);
            return op_ds;
        }
        private void save_data_tien_thuong_nhan_vien()
        {
            //B1: Lấy danh sách nhân viên chưa tính tiền thưởng
            var v_ds_nhan_vien_canh_tinh = lay_danh_sach_nhan_vien_chua_tinh_thuong();

            //B1.1: Luu thang da giam tru
            luu_thang_da_giam_tru();

            var rowLimit = v_ds_nhan_vien_canh_tinh.DM_NHAN_VIEN.Count;
            for(int rowToComput = 0; rowToComput < rowLimit; rowToComput++)
            {
                var v_id_nv = CIPConvert.ToDecimal(v_ds_nhan_vien_canh_tinh.DM_NHAN_VIEN.Rows[rowToComput][DM_NHAN_VIEN.ID].ToString());
                //B2: Tinh thu nhap khac cho nhan vien nay
                var v_dr_du_lieu_1_nv = lay_du_lieu_tien_thuong_1_nhan_vien(v_id_nv);

                //B3: Chuyen doi du lieu tu DataRow sang US de insert
                US_GD_THU_NHAP_KHAC v_us_gd_thu_nhap_khac = new US_GD_THU_NHAP_KHAC();
                data_row_2_us(v_dr_du_lieu_1_nv, ref v_us_gd_thu_nhap_khac);
                if(v_us_gd_thu_nhap_khac.dcSO_TIEN > 0)
                {
                    v_us_gd_thu_nhap_khac.Insert();
                }
                m_bgwk.ReportProgress((rowToComput + 1) * 100 / rowLimit);
            }
        }
        private DataRow lay_du_lieu_tien_thuong_1_nhan_vien(decimal ip_dc_id_nhan_vien)
        {
            US_GD_THU_NHAP_KHAC v_us_gd_thu_nhap_khac = new US_GD_THU_NHAP_KHAC();
            DataSet v_ds_du_lieu_thu_nhap_khac = new DataSet();
            v_ds_du_lieu_thu_nhap_khac.Tables.Add();
            v_us_gd_thu_nhap_khac.load_du_lieu_bang_luong_1nv_theo_hs_athk(v_ds_du_lieu_thu_nhap_khac
                                                                                , m_dat_tu_ngay.DateTime
                                                                                , m_dat_den_ngay.DateTime
                                                                                , (decimal)m_txt_so_tien.EditValue
                                                                                , m_chk_giam_tru.Checked == true ? "Y" : "N"
                                                                                , m_dat_thang_thuong.DateTime.Month
                                                                                , m_dat_thang_thuong.DateTime.Year
                                                                                , ip_dc_id_nhan_vien);
            return v_ds_du_lieu_thu_nhap_khac.Tables[0].Rows[0];
        }
        private void tinh_tien_thuong()
        {
            try
            {
                SplashScreenManager.ShowForm(typeof(F_wait_form));

                save_data_tien_thuong_nhan_vien();

                //B3: Thong bao Message Box
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


        private void handle_key_down(Keys ip_key, bool ip_is_ctrl_press)
        {
            if(ip_key == Keys.Escape)
            {
                Dispose();
            }
        }
        private void handle_form_load()
        {
            m_dat_tu_ngay.DateTime = DateTime.Now.AddMonths(-DateTime.Now.Month + 1).AddDays(-DateTime.Now.Day + 1);
            m_dat_thang_thuong.DateTime = DateTime.Now;
            m_prb.Visible = false;
            set_text_thong_tin_da_tinh_luong();
        }
        private void handle_thay_doi_thang_thuong()
        {
            US_GD_THANG_DA_GIAM_TRU v_us = new US_GD_THANG_DA_GIAM_TRU();
            decimal op_dc_giam_tru = 0;
            v_us.kiem_tra_thang_da_giam_tru_chua(m_dat_thang_thuong.DateTime.Month
                                                        , m_dat_thang_thuong.DateTime.Year
                                                        , ref op_dc_giam_tru);

            m_chk_giam_tru.Checked = op_dc_giam_tru == 0 ? false : true;
            m_is_giam_tru = op_dc_giam_tru == 0 ? IS_GIAM_TRU.CHUA_GIAM_TRU : IS_GIAM_TRU.DA_GIA_TRU;
        }
        private void start_tinh_tien_thuong_process()
        {
            if(is_valid_data_before_tinh_luong())
            {
                return;
            }
            if(m_bgwk.IsBusy)
            {
                m_bgwk.CancelAsync();
            }
            else
            {
                this.m_prb.Visible = true;
                m_bgwk.RunWorkerAsync();
            }
        }
        #endregion

        #region Event Handle
        private void set_define_event()
        {
            Load += f355_thuong_an_toan_hang_khong_Load;
            m_cmd_tinh_tien_thuong.Click += m_cmd_tinh_tien_thuong_Click;
            m_dat_thang_thuong.EditValueChanged += m_dat_thang_thuong_EditValueChanged;
            m_chk_giam_tru.CheckedChanged += m_chk_giam_tru_CheckedChanged;
            KeyDown += f355_thuong_an_toan_hang_khong_KeyDown;
        }


        private void m_bgwk_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                tinh_tien_thuong();
            }
            catch(Exception v_e)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Có tý tẹo vấn đề. Bạn chụp ảnh và gửi để chúng tôi hỗ trợ nhé!" + v_e.ToString());
            }
        }
        private void m_bgwk_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            try
            {
                this.m_prb.Text = (e.ProgressPercentage.ToString() + "%");
                this.m_prb.EditValue = e.ProgressPercentage;
            }
            catch(Exception)
            {
                throw;
            }

        }
        private void m_bgwk_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                this.m_prb.Visible = false;
                fill_data_to_grid();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }


        void f355_thuong_an_toan_hang_khong_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                handle_key_down(e.KeyCode, e.Control);
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }


        void m_cmd_tinh_tien_thuong_Click(object sender, EventArgs e)
        {
            try
            {
                start_tinh_tien_thuong_process();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_chk_giam_tru_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if(m_chk_giam_tru.CheckState == CheckState.Unchecked)
                {
                    m_chk_giam_tru.Enabled = true;
                }
                else if(m_chk_giam_tru.CheckState == CheckState.Checked)//
                {
                    if(m_is_giam_tru == IS_GIAM_TRU.DA_GIA_TRU)
                    {
                        m_chk_giam_tru.Enabled = false;
                    }
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
                handle_thay_doi_thang_thuong();

            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void f355_thuong_an_toan_hang_khong_Load(object sender, EventArgs e)
        {
            try
            {
                handle_form_load();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        #endregion
    }
}
