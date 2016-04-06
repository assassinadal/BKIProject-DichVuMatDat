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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BKI_DichVuMatDat.NghiepVu.ThuNhapKhac
{
    public partial class f355_tnk_chi_tiet_quy_thu_nhap_khac_detail : Form
    {
        #region Field & Property
        DataEntryFormMode m_e_form_mode;
        US_GD_THU_NHAP_KHAC m_us_gd_tnk;
        #endregion

        #region Public Interface
        public f355_tnk_chi_tiet_quy_thu_nhap_khac_detail()
        {
            InitializeComponent();
            format_controls(); load_data_nhan_vien();
        }
        public void Display_for_insert(decimal ip_dc_id_quy_thu_nhap_khac)
        {


            US_GD_QUY_THU_NHAP_KHAC v_us_quy = new US_GD_QUY_THU_NHAP_KHAC(ip_dc_id_quy_thu_nhap_khac);

            m_us_gd_tnk = new US_GD_THU_NHAP_KHAC();
            m_us_gd_tnk.dcID_QUY_THU_NHAP_KHAC = v_us_quy.dcID;
            m_us_gd_tnk.dcID_LOAI_THU_NHAP_KHAC = v_us_quy.dcID_LOAI_QUY_THU_NHAP_KHAC;
            m_us_gd_tnk.dcNAM = Convert.ToDecimal(v_us_quy.strNAM);
            m_us_gd_tnk.dcTHANG = Convert.ToDecimal(v_us_quy.strTHANG);
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            ShowDialog();
        }
        public void Display_for_update(decimal ip_dc_id_thu_nhap_khac)
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            m_us_gd_tnk = new US_GD_THU_NHAP_KHAC(ip_dc_id_thu_nhap_khac);

            m_sle_chon_nhan_vien.EditValue = m_us_gd_tnk.dcID_NHAN_VIEN;
            m_sle_chon_nhan_vien.ReadOnly = true;

            m_txt_he_so.EditValue = m_us_gd_tnk.dcHE_SO;
            m_txt_so_tien.EditValue = m_us_gd_tnk.dcSO_TIEN;
            m_txt_so_tien_nop_thue.EditValue = m_us_gd_tnk.dcSO_TIEN_NOP_THUE;
            m_txt_so_tien_thuc_linh.EditValue = m_us_gd_tnk.dcSO_TIEN_THUC_LINH;

            ShowDialog();
        }
        #endregion

        #region Event Handle
        private void set_define_events()
        {
            Load += f355_tnk_chi_tiet_quy_thu_nhap_khac_detail_Load;
            m_cmd_save.Click += m_cmd_save_Click;
            m_cmd_exit.Click += m_cmd_exit_Click;
            m_sle_chon_nhan_vien.EditValueChanged += m_sle_chon_nhan_vien_EditValueChanged;
        }

        void m_sle_chon_nhan_vien_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                hien_thi_chi_tiet_nhan_vien();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void f355_tnk_chi_tiet_quy_thu_nhap_khac_detail_Load(object sender, EventArgs e)
        {
            try
            {
               
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_exit_Click(object sender, EventArgs e)
        {
            try
            {
                Dispose();
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
                save_data();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        #endregion

        #region Private Method
        private void format_controls()
        {
            set_define_events();
        }
        private void set_form_text()
        {
            switch(m_e_form_mode)
            {
                case DataEntryFormMode.InsertDataState:
                    Text = "F355 - Thêm mới thu nhập khác nhân viên";
                    break;
                case DataEntryFormMode.SelectDataState:
                    break;
                case DataEntryFormMode.UpdateDataState:
                    Text = "F355 - Sửa thu nhập khác nhân viên";
                    break;
                case DataEntryFormMode.ViewDataState:
                    break;
                default:
                    break;
            }
        }
        private void load_data_nhan_vien()
        {
            US_DM_NHAN_VIEN v_us_nv = new US_DM_NHAN_VIEN();
            DS_DM_NHAN_VIEN v_ds = new DS_DM_NHAN_VIEN();
            v_ds.Tables.Add();
            v_us_nv.LayDanhSachNhanVienKemChucVuDonVi(v_ds);

            m_sle_chon_nhan_vien.Properties.DataSource = v_ds.Tables[0];
        }
        private void hien_thi_chi_tiet_nhan_vien()
        {
            if(m_sle_chon_nhan_vien.EditValue == null)
            {
                return;
            }

            US_V_DM_NHAN_VIEN v_us = new US_V_DM_NHAN_VIEN(Convert.ToDecimal(m_sle_chon_nhan_vien.EditValue));
            m_lbl_ma_nv.Text = v_us.strMA_NV;
            m_lbl_ho_ten.Text = v_us.strHO_TEN;
            m_lbl_don_vi.Text = v_us.strTEN_DON_VI;
            m_lbl_chuc_vu.Text = v_us.strCHUC_VU;
        }
        private bool check_valid_data()
        {
            var v_bol_is_ok = CHRMCommon.validate_control_empty(m_sle_chon_nhan_vien, m_txt_he_so, m_txt_so_tien, m_txt_so_tien_nop_thue, m_txt_so_tien_thuc_linh);
            if(v_bol_is_ok)
            {
                return true;
            }
            XtraMessageBox.Show("Bạn hoàn thiện dữ liệu trước!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }
        private void form_2_us()
        {
            m_us_gd_tnk.dcHE_SO = Convert.ToDecimal(m_txt_he_so.EditValue);
            m_us_gd_tnk.dcID_NHAN_VIEN = Convert.ToDecimal(m_sle_chon_nhan_vien.EditValue);
            m_us_gd_tnk.dcSO_TIEN = Convert.ToDecimal(m_txt_so_tien.EditValue);
            m_us_gd_tnk.dcSO_TIEN_NOP_THUE = Convert.ToDecimal(m_txt_so_tien_nop_thue.EditValue);
            m_us_gd_tnk.dcSO_TIEN_THUC_LINH = Convert.ToDecimal(m_txt_so_tien_thuc_linh.EditValue);
        }
        private bool kiem_tra_xem_trong_quy_co_nhan_vien_chua()
        {
            US_GD_QUY_THU_NHAP_KHAC v_us = new US_GD_QUY_THU_NHAP_KHAC();

            return v_us.KiemTraQuyCoNhanVienChua(m_us_gd_tnk.dcID_QUY_THU_NHAP_KHAC, m_us_gd_tnk.dcID_NHAN_VIEN);
        }
        private void save_data()
        {
            if(!check_valid_data())
            {
                return;
            }

            form_2_us();

            switch(m_e_form_mode)
            {
                case DataEntryFormMode.InsertDataState:
                    if(kiem_tra_xem_trong_quy_co_nhan_vien_chua())
                    {
                        XtraMessageBox.Show("Nhân viên đã có tiền trong quỹ này rồi!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
                    m_us_gd_tnk.Insert();
                    break;
                case DataEntryFormMode.SelectDataState:

                    break;
                case DataEntryFormMode.UpdateDataState:
                    m_us_gd_tnk.Update();
                    break;
                case DataEntryFormMode.ViewDataState:
                    break;
                default:
                    break;
            }
            XtraMessageBox.Show("Cập nhật thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
        #endregion
    }
}
