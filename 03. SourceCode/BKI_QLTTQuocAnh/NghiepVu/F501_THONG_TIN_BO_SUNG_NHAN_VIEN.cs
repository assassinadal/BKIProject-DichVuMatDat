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
using BKI_DichVuMatDat.DS;
using BKI_DichVuMatDat.US;
using IP.Core.IPCommon;

namespace BKI_DichVuMatDat.NghiepVu
{
    public partial class F501_THONG_TIN_BO_SUNG_NHAN_VIEN : Form
    {
        int m_dc_id_nhan_vien=0;
         
        public F501_THONG_TIN_BO_SUNG_NHAN_VIEN()
        {
            InitializeComponent();
            format_controls();
        }

        private void format_controls()
        {
            FormatControl.SetVisibleSimpleButton(this);
            set_define_events();
            this.KeyPreview = true;
        }

        private void set_define_events()
        {
            fill_datasource_danh_sach_nhan_vien();
            fill_datasource_loai_lao_dong();
        }

        private void fill_datasource_loai_lao_dong()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            DataTable v_dt = new DataTable();
            v_ds.Tables.Add(v_dt);
            v_us.FillDatasetWithQuery(v_ds, "select ID,TEN FROM CM_DM_TU_DIEN WHERE ID_LOAI_TU_DIEN=6");
            m_sle_loai_lao_dong.Properties.DataSource = v_ds.Tables[0];
            m_sle_loai_lao_dong.Properties.BestFitMode = BestFitMode.BestFitResizePopup;
        }

        private void fill_datasource_danh_sach_nhan_vien()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            DataTable v_dt = new DataTable();
            v_ds.Tables.Add(v_dt);
            v_us.FillDatasetWithQuery(v_ds, "select ID, MA_NV, HO_DEM+ ' '+ TEN AS TEN_NHAN_VIEN FROM DM_NHAN_VIEN");       
             m_sle_ten_nv.Properties.DataSource = v_ds.Tables[0];
             m_sle_ten_nv.Properties.BestFitMode = BestFitMode.BestFitResizePopup;
        }

        internal void ShowForPresent(int id_nhan_vien)
        {
            m_sle_ten_nv.EditValue = id_nhan_vien;
            m_dc_id_nhan_vien = id_nhan_vien;
            this.ShowDialog();
        }

        private void m_cmd_save_Click(object sender, EventArgs e)
        {
            if (check_du_lieu_is_ok())
            {
                luu_du_lieu();
                MessageBox.Show("Lưu dữ liệu thành công!");
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
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
                v_us.dcNAM = CIPConvert.ToDecimal(m_txt_thang.Text);
                v_us.strLY_DO = m_txt_ly_do.Text;
                v_us.Insert();
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
                v_us.dcSO_TIEN = CIPConvert.ToDecimal(m_txt_so_tien.Text);
                v_us.strDA_XOA = "N";
                v_us.strGHI_CHU = m_txt_ghi_chu.Text;
                v_us.Insert();
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
                v_us.Insert();
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
                v_us.Insert();
            }
            catch (Exception)
            {

                MessageBox.Show("Lỗi loại lao động!");
            }
           
        }

        private bool check_du_lieu_is_ok()
        {
            if (m_sle_loai_lao_dong.Text == "" )
                return false;
            if (m_chk_nguoi_phu_thuoc.Checked == true && m_txt_so_luong_phu_thuoc.Text == "")
                return false;
            if (m_chk_luong_cung.Checked == true && m_txt_so_tien.Text == "")
                return false;
            if (m_chk_khong_dong_BH.Checked == true && (m_txt_thang.Text == "" || m_txt_nam.Text == ""))
                return false;
            else return true;
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
            if( m_chk_luong_cung.Checked==true)
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

       

    
    }
}
