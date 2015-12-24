using BKI_DichVuMatDat.DS;
using BKI_DichVuMatDat.US;
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

namespace BKI_DichVuMatDat.NghiepVu
{
    public partial class f318_thuong_le_tet : Form
    {
        public f318_thuong_le_tet()
        {
            InitializeComponent();
        }
        private void fill_data_quy_tien_thuong()
        {
            var dataset = LayDanhSachQuyTienThuong();
            m_sle_quy_tien_thuong.Properties.DataSource = dataset.Tables[0];
        }
        private DS_V_GD_QUY_TIEN_THUONG LayDanhSachQuyTienThuong()
        {
            DS_V_GD_QUY_TIEN_THUONG v_ds_quy_tien_thuong = new DS_V_GD_QUY_TIEN_THUONG();
            US_V_GD_QUY_TIEN_THUONG v_us_quy_tien_thuong = new US_V_GD_QUY_TIEN_THUONG();
            v_us_quy_tien_thuong.LayDanhSachQuyThuongLeTet(out v_ds_quy_tien_thuong);
            return v_ds_quy_tien_thuong;
        }
        private void m_cmd_them_quy_tien_Click(object sender, EventArgs e)
        {
            try
            {
                f354_danh_sach_quy_thuong_de v_frm = new f354_danh_sach_quy_thuong_de();
                var v_us_quy_tien = v_frm.Display_for_le_tet();
                if(v_us_quy_tien.dcID > 0)
                {
                    fill_data_quy_tien_thuong();
                    m_sle_quy_tien_thuong.EditValue = v_us_quy_tien.dcID;
                    m_sle_quy_tien_thuong.Focus();
                }
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
    }
}
