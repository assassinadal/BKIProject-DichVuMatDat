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
using DevExpress.XtraEditors;
using BKI_DichVuMatDat.DS.CDBNames;
using BKI_DichVuMatDat.US;
using BKI_DichVuMatDat.NghiepVu.Luong;
namespace BKI_DichVuMatDat.NghiepVu.ThuNhapKhac
{
    public partial class f355_tnk_chi_tiet_quy_thu_nhap_khac : Form
    {
        #region Field & Property
        decimal m_dc_id_quy;
        #endregion

        #region Public Interface
        public f355_tnk_chi_tiet_quy_thu_nhap_khac(decimal ip_dc_id_quy_thu_nhap_khac)
        {
            InitializeComponent();
            
            m_dc_id_quy = ip_dc_id_quy_thu_nhap_khac;
            format_control();
        }
        #endregion

        #region Event Handle
        private void set_define_events()
        {
            Load += f355_tnk_chi_tiet_quy_thu_nhap_khac_Load;
            FormClosed += f355_tnk_chi_tiet_quy_thu_nhap_khac_FormClosed;
            m_cmd_insert.Click += m_cmd_insert_Click;
            m_cmd_update.Click += m_cmd_update_Click;
            m_cmd_delete.Click += m_cmd_delete_Click;
            m_cmd_xuat_excel.Click += m_cmd_xuat_excel_Click;
            m_cmd_exit.Click += m_cmd_exit_Click;
            m_cmd_import_excel.Click += m_cmd_import_excel_Click;
            m_grv_main.DoubleClick += m_grv_main_DoubleClick;
        }

        void m_grv_main_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                handle_btn_update_clicked();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_import_excel_Click(object sender, EventArgs e)
        {
            try
            {
                import_excel();               
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

        void m_cmd_xuat_excel_Click(object sender, EventArgs e)
        {
            try
            {
                CHRMCommon.ExportExcel(m_grv_main);
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_delete_Click(object sender, EventArgs e)
        {
            try
            {
                delete_tnk();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_update_Click(object sender, EventArgs e)
        {
            try
            {
                handle_btn_update_clicked();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_insert_Click(object sender, EventArgs e)
        {
            try
            {
                handle_btn_insert_clicked();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void f355_tnk_chi_tiet_quy_thu_nhap_khac_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                handle_form_closed();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void f355_tnk_chi_tiet_quy_thu_nhap_khac_Load(object sender, EventArgs e)
        {
            try
            {
                handle_form_loaded();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        #endregion

        #region Private Method



        //Set up Form
        private void format_control()
        {
            var v_dto_quy = TnkQL.Instance.LayThongTinQuy(m_dc_id_quy);
            var v_dto_luong = TinhLuongQL.Instance.LayThongTinBangLuong(v_dto_quy.THANG, v_dto_quy.NAM);
            if(v_dto_luong.CHOT_BANG_LUONG == true)
            {
                m_cmd_delete.Enabled = false;
                m_cmd_update.Enabled = false;
                m_cmd_insert.Enabled = false;
                m_cmd_import_excel.Enabled = false;
            }
            set_define_events();
        }
        //Get data in Form
        private void load_data_to_grid()
        {
            var v_dt_soure = TnkQL.Instance.LayChiTietQuy(m_dc_id_quy);
            m_grc_main.DataSource = null;
            m_grc_main.DataSource = v_dt_soure;
            CHRMCommon.make_stt_indicator(m_grv_main);
            hien_thi_thong_tin_quy();
        }
        //Method bool

        //Event handle
        private void import_excel()
        {
            f301_tinh_thu_nhap_khac v_frm = new f301_tinh_thu_nhap_khac(m_dc_id_quy);
            v_frm.ShowDialog();
            load_data_to_grid();
        }
        private void handle_form_loaded()
        {
            load_data_to_grid();
            
        }
        private void handle_form_closed()
        {
            Dispose();
        }
        private void handle_btn_insert_clicked()
        {
            f355_tnk_chi_tiet_quy_thu_nhap_khac_detail v_frm = new f355_tnk_chi_tiet_quy_thu_nhap_khac_detail();
            v_frm.Display_for_insert(m_dc_id_quy);
            load_data_to_grid();   
        }
        private void handle_btn_update_clicked()
        {
            if(m_grv_main.FocusedRowHandle < 0)
            {
                XtraMessageBox.Show("Bạn chưa chọn dòng dữ liệu nào để sửa!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var v_dc_id_gd_thu_nhap_khac = Convert.ToDecimal(m_grv_main.GetFocusedDataRow()[GD_THU_NHAP_KHAC.ID]);
            f355_tnk_chi_tiet_quy_thu_nhap_khac_detail v_frm = new f355_tnk_chi_tiet_quy_thu_nhap_khac_detail();
            v_frm.Display_for_update(v_dc_id_gd_thu_nhap_khac);
            load_data_to_grid();  
        }
        private void hien_thi_thong_tin_quy()
        {
            var v_dto = TnkQL.Instance.LayThongTinQuy(m_dc_id_quy);
            m_lbl_ten_quy.Text = v_dto.TEN_QUY;
            m_lbl_tong_tien.Text = string.Format("{0:#,##0}", v_dto.TONG_TIEN);
            m_lbl_so_luong_nv_trong_quy.Text = v_dto.SO_LUONG_NV_TRONG_QUY.ToString() + " NV";
            m_lbl_tong_tien_nop_thue.Text = string.Format("{0:#,##0}", v_dto.TONG_TIEN_NOP_THUE);
            m_lbl_tong_tien_thuc_linh.Text = string.Format("{0:#,##0}", v_dto.TONG_TIEN_THUC_LINH);
        }
        private void delete_tnk()
        {
            if(m_grv_main.FocusedRowHandle < 0)
            {
                XtraMessageBox.Show("Bạn chưa chọn dòng dữ liệu nào để xóa!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var dlg = XtraMessageBox.Show("Bạn có chắc chắn muốn xóa dữ liệu? Dữ liệu đã xóa không thể khôi phục được!", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dlg == System.Windows.Forms.DialogResult.Yes)
            {
                var v_dc_id_gd_thu_nhap_khac = Convert.ToDecimal(m_grv_main.GetFocusedDataRow()[GD_THU_NHAP_KHAC.ID]);
                US_GD_THU_NHAP_KHAC v_us_gd_tnk = new US_GD_THU_NHAP_KHAC();
                v_us_gd_tnk.DeleteByID(v_dc_id_gd_thu_nhap_khac);
                load_data_to_grid();
            }
            else
            {
                return;
            }
        }
        #endregion
    }
}
