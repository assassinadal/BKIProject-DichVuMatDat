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
using IP.Core.IPCommon;
using BKI_DichVuMatDat.DS.CDBNames;


namespace BKI_DichVuMatDat.NghiepVu
{
    public partial class f393_tinh_phep_tieu_chuan : Form
    {
        public f393_tinh_phep_tieu_chuan()
        {
            InitializeComponent();
        }

        public void load_data_to_grid()
        {
            DataSet v_ds = new DataSet();
            DataTable v_dt = new DataTable();
            US_GD_CHAM_CONG v_us = new US_GD_CHAM_CONG();
            v_ds.Tables.Add(v_dt);
            v_us.FillDatasetNgayPhepTieuChuan(v_ds, m_txt_nam_tinh_phep.Text, -1);
            m_grc_phep_tieu_chuan.DataSource = v_ds.Tables[0];
        }

        private void m_cmd_tinh_ngay_phep_Click(object sender, EventArgs e)
        {
            try
            {
                if (m_txt_nam_tinh_phep.Text != "" && check_validate_data_is_ok(m_txt_nam_tinh_phep.Text))
                {
                    load_data_to_grid();
                }
                else
                {
                    MessageBox.Show("Dữ liệu nhập vào chưa hợp lệ!");
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private bool check_validate_data_is_ok(string ip_str_nam_tinh_phep)
        {
            for (int i = 0; i < ip_str_nam_tinh_phep.Length; i++)
            {
                if (char.IsDigit(ip_str_nam_tinh_phep[i]) == false)
                    return false;
            }
            return true;
        }          
    }
}
