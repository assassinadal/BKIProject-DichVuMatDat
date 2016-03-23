using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using BKI_DichVuMatDat;
using BKI_DichVuMatDat.DS;
using BKI_DichVuMatDat.US;
using BKI_DichVuMatDat.DS.CDBNames;
using IP.Core.IPCommon;

namespace BKI_DichVuMatDat.NghiepVu
{
    public partial class F501_THONG_TIN_BO_SUNG_NHAN_VIEN : Form
    {
        #region Members
        int m_dc_id_nhan_vien = 0;
        double m_so_tien = 0;
        int m_trang_thai_buoc_2_cua_form_500 = 0;
        DataEntryFormMode m_e_form_mode = DataEntryFormMode.InsertDataState;
        #endregion


        public F501_THONG_TIN_BO_SUNG_NHAN_VIEN()
        {
            InitializeComponent();
            format_controls();
        }

        private void set_init_form_load()
        {
            fill_datasource_danh_sach_nhan_vien();
            fill_datasource_loai_lao_dong();
        }

        private void format_controls()
        {
            FormatControl.SetVisibleSimpleButton(this);
            set_define_events();
            this.KeyPreview = true;
            CenterToScreen();
        }

        private void set_define_events()
        {
            this.Load += F501_THONG_TIN_BO_SUNG_NHAN_VIEN_Load;
        }

        private void F501_THONG_TIN_BO_SUNG_NHAN_VIEN_Load(object sender, EventArgs e)
        {
            try
            {
                set_init_form_load();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void fill_datasource_loai_lao_dong()
        {
            US_CM_DM_TU_DIEN v_us = new US_CM_DM_TU_DIEN();
            DS_CM_DM_TU_DIEN v_ds = new DS_CM_DM_TU_DIEN();
            v_us.FillDatasetByIdLoaiTuDien(v_ds, 6);

            //US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            //DataSet v_ds = new DataSet();
            //DataTable v_dt = new DataTable();
            //v_ds.Tables.Add(v_dt);
            //v_us.FillDatasetWithQuery(v_ds, "select ID,TEN FROM CM_DM_TU_DIEN WHERE ID_LOAI_TU_DIEN=6");
            m_sle_loai_lao_dong.Properties.DataSource = v_ds.Tables[0];
            m_sle_loai_lao_dong.Properties.BestFitMode = BestFitMode.BestFitResizePopup;
        }

        private void fill_datasource_danh_sach_nhan_vien()
        {
            //US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            //DataSet v_ds = new DataSet();
            //DataTable v_dt = new DataTable();
            //v_ds.Tables.Add(v_dt);
            //throw new Exception();
            //v_us.FillDatasetWithQuery(v_ds, "select ID, MA_NV, HO_DEM+ ' '+ TEN AS TEN_NHAN_VIEN FROM DM_NHAN_VIEN");
            m_sle_ten_nv.Properties.DataSource = load_data_2_ds_v_dm_nv().V_DM_NHAN_VIEN;
            m_sle_ten_nv.Properties.ValueMember = V_DM_NHAN_VIEN.ID;
            m_sle_ten_nv.Properties.DisplayMember = V_DM_NHAN_VIEN.HO_TEN;

            m_sle_ten_nv.Properties.PopulateViewColumns();

            m_sle_ten_nv.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            m_sle_ten_nv.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
        }

        private DS_V_DM_NHAN_VIEN load_data_2_ds_v_dm_nv()
        {
            DS_V_DM_NHAN_VIEN v_ds = new DS_V_DM_NHAN_VIEN();
            US_V_DM_NHAN_VIEN v_us = new US_V_DM_NHAN_VIEN();
            v_ds.EnforceConstraints = false;
            v_ds.Clear();
            v_us.FillDataset(v_ds);
            return v_ds;
        }

        public void ShowForPresent(int id_nhan_vien)
        {
            m_sle_ten_nv.EditValue = id_nhan_vien;
            m_dc_id_nhan_vien = id_nhan_vien;
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            this.ShowDialog();
        }

        public void DisplayForUpdate(int id_nhan_vien)
        {
            m_sle_ten_nv.EditValue = id_nhan_vien;
            m_sle_ten_nv.Enabled = false;
            m_dc_id_nhan_vien = id_nhan_vien;
            load_data(id_nhan_vien);
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            this.ShowDialog();
        }

        private void load_data(int id_nhan_vien)
        {
            load_data_luong_cung(id_nhan_vien);
            load_gd_phu_thuoc(id_nhan_vien);
            //load_khong_dong_bao_hiem(id_nhan_vien);
        }

        private void load_data_luong_cung(int id_nhan_vien)
        {
            US_GD_LUONG_CUNG v_us = new US_GD_LUONG_CUNG();
            m_dat_ngay_bat_dau_luong_cung.Value = v_us.datNGAY_BAT_DAU;
            m_dat_ngay_ket_thuc_luong_cung.Value = v_us.datNGAY_KET_THUC;
            m_txt_ghi_chu.Text = v_us.strGHI_CHU;
            m_txt_so_tien.Text = v_us.dcSO_TIEN.ToString();
        }

        private void load_gd_phu_thuoc(int id_nhan_vien)
        {
            US_GD_PHU_THUOC v_us = new US_GD_PHU_THUOC();
            m_txt_so_luong_phu_thuoc.Text = v_us.dcSO_LUONG.ToString();
            m_dat_ngay_ap_dung.Value = v_us.datNGAY_SUA;
        }

        private void load_khong_dong_bao_hiem(int id_nhan_vien)
        {
            US_GD_KHONG_DONG_BAO_HIEM v_us = new US_GD_KHONG_DONG_BAO_HIEM(id_nhan_vien);
            m_txt_nam.Text = v_us.dcNAM.ToString();
            m_txt_thang.Text = v_us.dcTHANG.ToString();
            m_txt_ly_do.Text = v_us.strLY_DO;
        }

        private void luu_du_lieu()
        {
            try
            {
                luu_gd_loai_lao_dong();
                if (m_chk_nguoi_phu_thuoc.Checked == true)
                {
                    luu_gd_phu_thuoc();
                }
                if (m_chk_luong_cung.Checked == true)
                {
                    luu_luong_cung();
                }

                if (m_chk_khong_dong_BH.Checked == true)
                {
                    luu_khong_dong_bao_hiem();
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Có lỗi!");
            }

        }

        private void luu_khong_dong_bao_hiem()
        {
            try
            {
                US_GD_KHONG_DONG_BAO_HIEM v_us = new US_GD_KHONG_DONG_BAO_HIEM();
                v_us.dcID_NHAN_VIEN = v_us.dcID_NHAN_VIEN = CIPConvert.ToDecimal(m_dc_id_nhan_vien.ToString());
                v_us.dcTHANG = CIPConvert.ToDecimal(m_txt_thang.Text);
                v_us.dcNAM = CIPConvert.ToDecimal(m_txt_nam.Text);
                v_us.strLY_DO = m_txt_ly_do.Text;
                switch (m_e_form_mode)
                {
                    case DataEntryFormMode.UpdateDataState:
                        break;
                    case DataEntryFormMode.InsertDataState:
                        v_us.Insert();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Sai bảo hiểm!");
            }

        }

        private void luu_luong_cung()
        {
            try
            {
                US_GD_LUONG_CUNG v_us = new US_GD_LUONG_CUNG();
                v_us.datNGAY_BAT_DAU = m_dat_ngay_bat_dau_luong_cung.Value;
                v_us.datNGAY_KET_THUC = m_dat_ngay_ket_thuc_luong_cung.Value;
                v_us.dcID_NHAN_VIEN = v_us.dcID_NHAN_VIEN = CIPConvert.ToDecimal(m_dc_id_nhan_vien.ToString());
                v_us.dcSO_TIEN = CIPConvert.ToDecimal(m_so_tien);
                v_us.strDA_XOA = "N";
                v_us.strGHI_CHU = m_txt_ghi_chu.Text;
                switch (m_e_form_mode)
                {
                    case DataEntryFormMode.UpdateDataState:
                        break;
                    case DataEntryFormMode.InsertDataState:
                        v_us.Insert();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Lỗi lương cứng");
            }

        }

        private void luu_gd_phu_thuoc()
        {
            try
            {
                US_GD_PHU_THUOC v_us = new US_GD_PHU_THUOC();
                v_us.dcID_NHAN_VIEN = CIPConvert.ToDecimal(m_dc_id_nhan_vien.ToString());
                v_us.dcSO_LUONG = CIPConvert.ToDecimal(m_txt_so_luong_phu_thuoc.Text);
                v_us.datNGAY_SUA = m_dat_ngay_ap_dung.Value;
                v_us.strNGUOI_LAP = "admin";
                v_us.strNGUOI_SUA = "admin";
                v_us.datNGAY_SUA = DateTime.Now.Date;
                v_us.strDA_XOA = "N";
                switch (m_e_form_mode)
                {
                    case DataEntryFormMode.UpdateDataState:
                        break;
                    case DataEntryFormMode.InsertDataState:
                        v_us.Insert();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Lỗi người phụ thuộc");
            }

        }


        private void luu_gd_loai_lao_dong()
        {
            try
            {
                US_GD_LOAI_LAO_DONG v_us = new US_GD_LOAI_LAO_DONG();
                v_us.dcID_NHAN_VIEN = CIPConvert.ToDecimal(m_dc_id_nhan_vien.ToString());
                v_us.dcID_LOAI_LAO_DONG = CIPConvert.ToDecimal(m_sle_loai_lao_dong.EditValue);
                if (m_dat_ngay_bat_dau.Checked == true)
                    v_us.datNGAY_BAT_DAU = m_dat_ngay_bat_dau.Value;
                if (m_dat_ngay_ket_thuc.Checked == true)
                    v_us.datNGAY_KET_THUC = m_dat_ngay_ket_thuc.Value;
                switch (m_e_form_mode)
                {
                    case DataEntryFormMode.UpdateDataState:
                        break;
                    case DataEntryFormMode.InsertDataState:
                        v_us.Insert();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Lỗi loại lao động!");
            }

        }

        private bool check_du_lieu_is_ok()
        {
            if (m_sle_loai_lao_dong.Text == "")
                return false;
            if (m_chk_nguoi_phu_thuoc.Checked == true && m_txt_so_luong_phu_thuoc.Text == "")
                return false;
            if (m_chk_luong_cung.Checked == true && m_txt_so_tien.Text == "")
                return false;
            if (m_chk_khong_dong_BH.Checked == true && (m_txt_thang.Text == "" || m_txt_nam.Text == ""))
                return false;
            else return true;
        }

        private void m_cmd_save_Click(object sender, EventArgs e)
        {
            if (check_du_lieu_is_ok())
            {
                luu_du_lieu();
                CHRM_BaseMessages.MsgBox_Infor(CONST_ID_MSGBOX.INFOR_LUU_DU_LIEU_THANH_CONG);
                m_trang_thai_buoc_2_cua_form_500 = 1;
                F500_QUY_TRINH_THEM_MOI_NHAN_SU.done();
                this.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
        }

        private void m_chk_nguoi_phu_thuoc_CheckedChanged(object sender, EventArgs e)
        {
            if (m_chk_nguoi_phu_thuoc.Checked == true)
            {
                m_txt_so_luong_phu_thuoc.Enabled = true;
                m_dat_ngay_ap_dung.Enabled = true;
            }
            else
            {
                m_txt_so_luong_phu_thuoc.Text = "";
                m_dat_ngay_ap_dung.Enabled = false;
                m_txt_so_luong_phu_thuoc.Enabled = false;
            }
        }

        private void m_chk_luong_cung_CheckedChanged(object sender, EventArgs e)
        {
            if (m_chk_luong_cung.Checked == true)
            {
                m_txt_so_tien.Enabled = true;
                m_dat_ngay_bat_dau_luong_cung.Enabled = true;
                m_dat_ngay_ket_thuc_luong_cung.Enabled = true;
                m_txt_ghi_chu.Enabled = true;
            }
            else
            {
                m_txt_so_tien.Text = "";
                m_txt_ghi_chu.Text = "";
                m_txt_so_tien.Enabled = false;
                m_txt_ghi_chu.Enabled = false;
                m_dat_ngay_bat_dau_luong_cung.Enabled = false;
                m_dat_ngay_ket_thuc_luong_cung.Enabled = false;
            }
        }

        private void m_chk_khong_dong_BH_CheckedChanged(object sender, EventArgs e)
        {
            if (m_chk_khong_dong_BH.Checked == true)
            {
                m_txt_nam.Enabled = true;
                m_txt_thang.Enabled = true;
                m_txt_ly_do.Enabled = true;
            }
            else
            {
                m_txt_nam.Text = "";
                m_txt_nam.Enabled = false;
                m_txt_thang.Text = "";
                m_txt_thang.Enabled = false;
                m_txt_ly_do.Text = "";
                m_txt_ly_do.Enabled = false;
            }
        }

        private void m_txt_so_tien_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void m_txt_so_luong_phu_thuoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void m_txt_thang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void m_txt_nam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void m_cmd_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void m_txt_so_tien_Leave(object sender, EventArgs e)
        {
            Double value;
            if (Double.TryParse(m_txt_so_tien.Text, out value))
            {
                m_so_tien = value;
                m_txt_so_tien.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2}", value);
            }
            else
                m_txt_so_tien.Text = String.Empty;
        }

        internal void ShowForPresent(int id_nhan_vien, ref int m_trang_thai_buoc_2)
        {
            m_sle_ten_nv.EditValue = id_nhan_vien;
            m_dc_id_nhan_vien = id_nhan_vien;
            this.ShowDialog();
            m_trang_thai_buoc_2 = m_trang_thai_buoc_2_cua_form_500;
        }
    }
}
