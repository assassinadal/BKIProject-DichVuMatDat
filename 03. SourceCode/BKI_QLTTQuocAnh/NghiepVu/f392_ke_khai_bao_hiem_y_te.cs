using System;
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

using DevExpress.XtraEditors.Controls;
using System.Globalization;
namespace BKI_DichVuMatDat.NghiepVu
{
    public partial class f392_ke_khai_bao_hiem_y_te : Form
    {
        public f392_ke_khai_bao_hiem_y_te()
        {
            InitializeComponent();
        }

        private void m_sle_ten_nhan_vien_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (m_sle_ten_nhan_vien.EditValue.ToString() == "")
                {
                    return;
                }
                else
                {
                    load_data_to_group_control(CIPConvert.ToDecimal(m_sle_ten_nhan_vien.EditValue));
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void load_data_to_group_control(decimal ip_id_nhan_vien)
        {
            US_DM_NHAN_VIEN v_us = new US_DM_NHAN_VIEN(ip_id_nhan_vien);
            m_dat_ngay_sinh.Value = v_us.datNGAY_SINH;
            load_data_to_rdb_gioi_tinh(v_us);
            m_txt_dan_toc.Text = v_us.strDAN_TOC;
            m_txt_quoc_tich.Text = v_us.strQUOC_TICH;
            m_txt_so_chung_minh_thu.Text = v_us.strSO_CMT;
            m_dat_ngay_cap_cmt.Value = v_us.datNGAY_CAP;
            m_txt_noi_cap_cmt.Text = v_us.strNOI_CAP;
            m_txt_so_dien_thoai.Text = v_us.strSDT;
            m_txt_email.Text = v_us.strEMAIL;
            m_txt_dia_chi_dang_ky_ho_khau.Text = v_us.strDIA_CHI_THUONG_TRU;
            m_txt_dia_chi_lien_he.Text = v_us.strDIA_CHI_LIEN_LAC;

        }

        private void load_data_to_rdb_gioi_tinh(US_DM_NHAN_VIEN v_us_nv)
        {
            if (v_us_nv.strGIOI_TINH == "" || v_us_nv.strGIOI_TINH == "NULL")
            {
                m_rdb_gioi_tinh_nam.Checked = false;
                m_rdb_gioi_tinh_nu.Checked = false;
            }
            else if (v_us_nv.strGIOI_TINH == "Y")
            {
                m_rdb_gioi_tinh_nam.Checked = true;
                m_rdb_gioi_tinh_nu.Checked = false;
            }
            else 
            {
                m_rdb_gioi_tinh_nam.Checked = false;
                m_rdb_gioi_tinh_nu.Checked = true;
            }
        }

        private void f392_ke_khai_bao_hiem_y_te_Load(object sender, EventArgs e)
        {
            load_data_to_sle_ten_nhan_vien();
        }

        private void load_data_to_sle_ten_nhan_vien()
        {
            DataSet v_ds = new DataSet();
            DataTable v_dt = new DataTable();
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            v_ds.Tables.Add(v_dt);
            throw new Exception("Sua lai khong dung FillDataSetWithTableName nua nhe");
           // v_us.FillDatasetWithTableName(v_ds, "V_DM_NHAN_VIEN");
            m_sle_ten_nhan_vien.Properties.DataSource = v_ds.Tables[0];
            m_sle_ten_nhan_vien.Properties.BestFitMode = BestFitMode.BestFitResizePopup;
        }
    }
}
