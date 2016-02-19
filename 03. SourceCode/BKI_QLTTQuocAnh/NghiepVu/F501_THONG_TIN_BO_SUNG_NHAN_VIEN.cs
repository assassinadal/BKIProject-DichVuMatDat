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

                luu_gd_phu_thuoc();
            }
            catch (Exception)
            {

                MessageBox.Show("Có lỗi!");
            }
          
        }

        private void luu_gd_phu_thuoc()
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

     
        private void luu_gd_loai_lao_dong()
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

        private bool check_du_lieu_is_ok()
        {
            if (m_sle_loai_lao_dong.Text == "" || m_txt_so_luong_phu_thuoc.Text == "")
                return false;
            else return true;
        }
    }
}
