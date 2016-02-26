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

namespace BKI_DichVuMatDat.BaoCao
{
    public partial class f480_bao_cao_thuong_khac : Form
    {
        //Field
        //private decimal m_dc_id_quy_tien;


        public f480_bao_cao_thuong_khac()
        {
            InitializeComponent();
            format_control();
        }
        public void display(decimal ip_dc_id_quy_tien)
        {
            fill_data_quy_tien_thuong();

            US_GD_THU_NHAP_KHAC v_us = new US_GD_THU_NHAP_KHAC();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add();

            v_us.LayDuLieuThuNhapKhac(v_ds, ip_dc_id_quy_tien);
            m_grc_luong_thuong.DataSource = v_ds.Tables[0];
            CHRMCommon.make_stt_indicator(m_grv_luong_thuong);
            m_sle_quy_thuong.EditValue = ip_dc_id_quy_tien;
            ShowDialog();

            //US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            //DataSet v_ds = new DataSet();
            //v_ds.Tables.Add();

            //v_us.FillDatasetWithQuery(v_ds, "select * from V_GD_THU_NHAP_KHAC_2 where id_quy_tien_thuong = " + ip_dc_id_quy_tien);
            //m_grc_luong_thuong.DataSource = v_ds.Tables[0];
            //CHRMCommon.make_stt_indicator(m_grv_luong_thuong);
            //m_sle_quy_thuong.EditValue = ip_dc_id_quy_tien;
            //ShowDialog();
        }
        public void display_athk(decimal ip_dc_id_quy_tien)
        {
            fill_data_quy_tien_thuong();

            US_GD_THU_NHAP_KHAC v_us = new US_GD_THU_NHAP_KHAC();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add();

            v_us.LayDuLieuThuNhapKhac(v_ds, ip_dc_id_quy_tien);
            m_grc_luong_thuong.DataSource = v_ds.Tables[0];
            //US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            //DataSet v_ds = new DataSet();
            //v_ds.Tables.Add();

            //v_us.FillDatasetWithQuery(v_ds, "select * from V_GD_THU_NHAP_KHAC_2 where id_quy_tien_thuong = " + ip_dc_id_quy_tien);
            //m_grc_luong_thuong.DataSource = v_ds.Tables[0];
            CHRMCommon.make_stt_indicator(m_grv_luong_thuong);
            m_sle_quy_thuong.EditValue = ip_dc_id_quy_tien;

            m_grv_luong_thuong.Columns["TRUY_LINH"].Visible = false;
            m_grv_luong_thuong.Columns["TRUY_THU"].Visible = false;
            m_grv_luong_thuong.Columns["THUC_LINH_CUOI_CUNG"].Visible = false;
            ShowDialog();
        }
        public void display_le_tet(decimal ip_dc_id_quy_tien)
        {
            fill_data_quy_tien_thuong();

            US_GD_THU_NHAP_KHAC v_us = new US_GD_THU_NHAP_KHAC();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add();

            v_us.LayDuLieuThuNhapKhac(v_ds, ip_dc_id_quy_tien);
            m_grc_luong_thuong.DataSource = v_ds.Tables[0];
            //US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            //DataSet v_ds = new DataSet();
            //v_ds.Tables.Add();

            //v_us.FillDatasetWithQuery(v_ds, "select * from V_GD_THU_NHAP_KHAC_2 where id_quy_tien_thuong = " + ip_dc_id_quy_tien + " order by THU_TU_HIEN_THI, THU_TU_CHUC_VU, TEN, HO_DEM");
            //m_grc_luong_thuong.DataSource = v_ds.Tables[0];
            CHRMCommon.make_stt_indicator(m_grv_luong_thuong);
            m_sle_quy_thuong.EditValue = ip_dc_id_quy_tien;

            m_grv_luong_thuong.Columns["TRUY_LINH"].Visible = false;
            m_grv_luong_thuong.Columns["TRUY_THU"].Visible = false;
            m_grv_luong_thuong.Columns["THUC_LINH_CUOI_CUNG"].Visible = false;
            ShowDialog();
        }
        private void fill_data_quy_tien_thuong()
        {
            var dataset = LayDanhSachQuyTienThuong();
            m_sle_quy_thuong.Properties.DataSource = dataset.Tables[0];
        }
        private DS_V_GD_QUY_TIEN_THUONG LayDanhSachQuyTienThuong()
        {
            DS_V_GD_QUY_TIEN_THUONG v_ds_quy_tien_thuong = new DS_V_GD_QUY_TIEN_THUONG();
            US_V_GD_QUY_TIEN_THUONG v_us_quy_tien_thuong = new US_V_GD_QUY_TIEN_THUONG();
            v_us_quy_tien_thuong.FillDataSetAll(out v_ds_quy_tien_thuong);
            return v_ds_quy_tien_thuong;
        }

        private void format_control()
        {
            set_define_event();
        }
        private void set_define_event()
        {
            Load += f480_bao_cao_thuong_khac_Load;
        }

        void f480_bao_cao_thuong_khac_Load(object sender, EventArgs e)
        {
            try
            {

            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_xuat_excel_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "xls files (*.xls)|*.xls|All files (*.*)|*.*";
                saveFileDialog1.RestoreDirectory = true;
                if(saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    m_grv_luong_thuong.ExportToXls(saveFileDialog1.FileName);
                    DevExpress.XtraEditors.XtraMessageBox.Show("Lưu báo cáo thành công");
                }
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
    }
}
