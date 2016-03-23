using BKI_DichVuMatDat.DS;
using BKI_DichVuMatDat.US;
using DevExpress.XtraEditors;
using IP.Core.IPCommon;
using IP.Core.IPSystemAdmin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BKI_DichVuMatDat.NghiepVu
{
    public partial class f354_danh_sach_quy_thuong_de : Form
    {
        //Field

        #region Members
        DataEntryFormMode m_e_form_mode;
        US_GD_QUY_THU_NHAP_KHAC m_us = new US_GD_QUY_THU_NHAP_KHAC();
        #endregion

        #region Public Interface
        public f354_danh_sach_quy_thuong_de()
        {
            InitializeComponent();
            format_control();
        }
        ~f354_danh_sach_quy_thuong_de()
        {
            Dispose(false);
        }
        //public bool is_inserted_quy_tien()
        //{
        //    if(DialogResult == System.Windows.Forms.DialogResult.OK)
        //    {
        //        return true;
        //    }
        //    return false;
        //}
       
        #endregion

        #region Private Methode
        private void format_control()
        {
            set_define_event();
            load_data_to_sle_loai_quy();
            load_data_to_sle_cach_tinh_thue();
        }
        private void load_data_to_sle_loai_quy()
        {
            US_CM_DM_TU_DIEN v_us = new US_CM_DM_TU_DIEN();
            DS_CM_DM_TU_DIEN v_ds = new DS_CM_DM_TU_DIEN();
            v_us.FillDatasetByIdLoaiTuDien(v_ds, 16);
            m_sle_loai_quy_thu_nhap.Properties.DataSource = v_ds.Tables[0];
        }

        private void load_data_to_sle_cach_tinh_thue()
        {
            US_CM_DM_TU_DIEN v_us = new US_CM_DM_TU_DIEN();
            DS_CM_DM_TU_DIEN v_ds = new DS_CM_DM_TU_DIEN();
            v_us.FillDatasetByIdLoaiTuDien(v_ds, 13);
            m_sle_cach_tinh_thue.Properties.DataSource = v_ds.Tables[0];
        }

        private void set_initial_form_load()
        {
            switch (m_e_form_mode)
            {
                case DataEntryFormMode.InsertDataState:
                    m_dat_ngay_lap_quy.DateTime = DateTime.Now;
                    m_dat_thang_ap_dung_quy.DateTime = DateTime.Now;
                    m_dat_tu_ngay.DateTime = new DateTime(DateTime.Now.Year,1,1);
                    m_dat_den_ngay.DateTime = DateTime.Now;
                    m_sle_cach_tinh_thue.EditValue = 759;
                    break;
                case DataEntryFormMode.UpdateDataState:                   
                    break;
                default:
                    break;
            }
        }


        internal void display_for_insert()
        {
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            set_initial_form_load();
            this.ShowDialog();
        }


        internal void display_for_update(US_GD_QUY_THU_NHAP_KHAC v_us)
        {
            if (check_quy_tien_dang_su_dung_yn(v_us.dcID) || check_quy_tien_da_chot_yn(v_us.strTHANG, v_us.strNAM))
            {
                m_dat_thang_ap_dung_quy.Enabled = false;
                m_sle_loai_quy_thu_nhap.Enabled = false;
            }
            m_us = v_us;
            us_to_form(v_us);
            this.ShowDialog();
        }

        private bool check_quy_tien_dang_su_dung_yn(decimal id_quy_tnk)
        {
            US_GD_THU_NHAP_KHAC v_us_gd_tnk = new US_GD_THU_NHAP_KHAC();
            DS_GD_THU_NHAP_KHAC v_ds_gd_tnk = new DS_GD_THU_NHAP_KHAC();
            v_us_gd_tnk.LayDuLieuThuNhapKhacTheoIDQuy(v_ds_gd_tnk, id_quy_tnk);
            if (v_ds_gd_tnk.Tables[0].Rows.Count != 0)
                return true;
            else return false;
        }

        private bool check_quy_tien_da_chot_yn(string ip_thang, string ip_nam)
        {
            US_RPT_CHOT_BANG_LUONG v_us = new US_RPT_CHOT_BANG_LUONG();
            if (v_us.IsLockBangLuong(decimal.Parse(ip_thang), decimal.Parse(ip_nam)))
                return true;
            else return false;
        }

        private void us_to_form(US_GD_QUY_THU_NHAP_KHAC v_us)
        {
            m_sle_loai_quy_thu_nhap.EditValue = v_us.dcID_LOAI_QUY_THU_NHAP_KHAC;
            m_sle_cach_tinh_thue.EditValue = v_us.dcID_CACH_QUYET_TOAN;
            m_txt_ten_quy.Text = v_us.strTEN_QUY;
            m_dat_thang_ap_dung_quy.DateTime = new DateTime(int.Parse(v_us.strNAM), int.Parse(v_us.strTHANG), 1);
            m_dat_ngay_lap_quy.DateTime = v_us.datNGAY_LAP;
            m_txt_nguoi_lap_quy.Text = v_us.strNGUOI_LAP;
            m_dat_tu_ngay.DateTime = v_us.datTU_NGAY_XET_THUONG;
            m_dat_den_ngay.DateTime = v_us.datDEN_NGAY_XET_THUONG;
            m_txt_ly_do_lap_quy.Text = v_us.strLY_DO_THUONG;
        }

        private void form_to_us()
        {
            m_us.strTEN_QUY = m_txt_ten_quy.Text;
            m_us.strTHANG = m_dat_thang_ap_dung_quy.DateTime.Month.ToString();
            m_us.strNAM = m_dat_thang_ap_dung_quy.DateTime.Year.ToString();
            m_us.strNGUOI_LAP = m_txt_nguoi_lap_quy.Text;
            m_us.datNGAY_LAP = m_dat_ngay_lap_quy.DateTime;
            m_us.strNGUOI_LAP_PHAN_MEM = CAppContext_201.getCurrentUserName();
            m_us.datNGAY_LAP_PHAN_MEM = DateTime.Now;
            m_us.datTU_NGAY_XET_THUONG = m_dat_tu_ngay.DateTime;
            m_us.datDEN_NGAY_XET_THUONG = m_dat_den_ngay.DateTime;
            m_us.strLY_DO_THUONG = m_txt_ly_do_lap_quy.Text;
            m_us.strDA_XOA = "N";
            m_us.dcID_LOAI_QUY_THU_NHAP_KHAC = decimal.Parse(m_sle_loai_quy_thu_nhap.EditValue.ToString());
            m_us.dcID_CACH_QUYET_TOAN = decimal.Parse(m_sle_cach_tinh_thue.EditValue.ToString());
        }

        private bool check_validate_data_is_ok()
        {
            if (m_sle_loai_quy_thu_nhap.EditValue == null)
            {
                CHRM_BaseMessages.MsgBox_Error("Vui lòng chọn loại quỹ thu nhập!");
                return false;
            }
            else if (m_sle_cach_tinh_thue.EditValue == null)
            {
                CHRM_BaseMessages.MsgBox_Error("Vui lòng chọn cách tính thuế!");
                return false;
            }
            else if (m_txt_ten_quy.Text.Trim() == "")
            {
                CHRM_BaseMessages.MsgBox_Error("Vui lòng nhập tên quỹ!");
                return false;
            }
            return true;          
        }
        #endregion

        #region Event handle
        private void set_define_event()
        {
            Load += f354_danh_sach_quy_thuong_de_Load;
            m_cmd_exit.Click += m_cmd_exit_Click;
            m_cmd_save.Click += m_cmd_save_Click;
            //KeyDown += f354_danh_sach_quy_thuong_de_KeyDown;
            //m_sle_loai_quy_thu_nhap.EditValueChanged += m_le_loai_quy_thuong_EditValueChanged;
        }

        void m_cmd_exit_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (check_validate_data_is_ok())
                {
                    form_to_us();
                    switch (m_e_form_mode)
                    {
                        case DataEntryFormMode.InsertDataState:
                            m_us.Insert();
                            break;
                        case DataEntryFormMode.UpdateDataState:
                            m_us.Update();
                            break;
                        default:
                            break;
                    }
                    XtraMessageBox.Show("Lưu thành công!");
                    this.Close();
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }           
        }

        void f354_danh_sach_quy_thuong_de_Load(object sender, EventArgs e)
        {
            try
            {
                set_initial_form_load();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }


        #endregion


    }
}
