using BKI_DichVuMatDat.BaoCao;
using BKI_DichVuMatDat.DS;
using BKI_DichVuMatDat.DS.CDBNames;
using BKI_DichVuMatDat.US;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
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
using BKI_DichVuMatDat.NghiepVu.ThuNhapKhac;
using System.Linq;

namespace BKI_DichVuMatDat.NghiepVu
{
    public partial class f301_tinh_thu_nhap_khac : Form
    {
        //Field & Property
        US_GD_QUY_THU_NHAP_KHAC m_us_gd_quy;

        #region Public Interfaces
        public f301_tinh_thu_nhap_khac()
        {
            InitializeComponent();
            format_control();
        }
        public f301_tinh_thu_nhap_khac(decimal ip_dc_id_quy_tien)
        {
            m_us_gd_quy = new US_GD_QUY_THU_NHAP_KHAC(ip_dc_id_quy_tien);
            InitializeComponent();
            format_control();
        }
        #endregion
        
        #region Private Method
        //Setup form
        private void format_control()
        {
            set_define_event();
        }
        private void set_initial_form_load()
        {
        }
        private void set_grid_dang_soan_thao()
        {
            m_lbl_trang_thai_soan_thao.Text = "Đang soạn thảo dữ liệu...";
            m_lbl_trang_thai_soan_thao.Appearance.Font = this.m_lbl_download_template.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | FontStyle.Italic))));
            m_lbl_trang_thai_soan_thao.ForeColor = Color.Green;
        }
        private void set_grid_da_luu_du_lieu()
        {
            m_lbl_trang_thai_soan_thao.Text = "Dữ liệu đã được lưu!";
            this.m_lbl_download_template.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | FontStyle.Regular))));
            m_lbl_trang_thai_soan_thao.ForeColor = Color.Gray;
        }
        //Tao Template
        private DataSet lay_danh_sach_nhan_vien_tinh_thuong()
        {
            US_RPT_LUONG_V2 v_us_rpt_luong = new US_RPT_LUONG_V2();
            DataSet v_ds_danh_sach_nhan_vien= new DataSet();
            v_us_rpt_luong.LayDanhSachMaNVDuocTinhLuong(
                                 out v_ds_danh_sach_nhan_vien
                                 , Convert.ToDecimal(m_us_gd_quy.strTHANG)
                                 , Convert.ToDecimal(m_us_gd_quy.strNAM));
            return v_ds_danh_sach_nhan_vien;
        }
        private void create_excel_file()
        {
            DataSet v_ds = lay_danh_sach_nhan_vien_tinh_thuong();

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "xls files (*.xls)|*.xls|All files (*.*)|*.*";
            saveFileDialog1.RestoreDirectory = true;
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                CHRMCommon.make_stt(m_grv_main);
                m_grc_main.DataSource = v_ds.Tables[0];

                m_grv_main.ExportToXls(saveFileDialog1.FileName);
                DevExpress.XtraEditors.XtraMessageBox.Show("Tạo template thành công. File sẽ tự động mở sau đây!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                m_grc_main.DataSource = null;
                open_file_excel_created(saveFileDialog1.FileName);
            }
        }
        private void open_file_excel_created(string ip_str_file_name)
        {
            var process = new System.Diagnostics.Process();
            process.StartInfo.FileName = ip_str_file_name;
            process.StartInfo.Verb = "Open";
            process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
            process.Start();
        }

        //Import Excel
        private void fill_data_2_grid(string ip_path_excel)
        {
            try
            {
                splashScreenManager1.ShowWaitForm();
                if(ip_path_excel == "")
                {
                    return;
                }
                m_grc_main.DataSource = null;
                WinFormControls.load_xls_to_gridview_v2(ip_path_excel, m_grc_main);
                set_grid_dang_soan_thao();
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                splashScreenManager1.CloseWaitForm();
            }
        }

        //Tinh tien thuong
        private DataTable get_danh_sach_ma_nv()
        {
            DataSet v_ds_ma_nv = new DataSet();
            v_ds_ma_nv.Tables.Add();

            US_DM_NHAN_VIEN v_us_nv = new US_DM_NHAN_VIEN();
            v_us_nv.LayDanhSachMaNhanVienInDB(v_ds_ma_nv);
            return v_ds_ma_nv.Tables[0];
        }
        private bool is_valid_data_to_calculate()
        {
            var v_dt_ma_nv = get_danh_sach_ma_nv();
            decimal v_tong_he_so = 0;
            for(int v_i_row = 0; v_i_row < m_grv_main.RowCount; v_i_row++)
            {
                if(m_grv_main.GetRowCellValue(v_i_row, CONST_COLUMN_NAME_IMPORT_TNK.MA_NV) == DBNull.Value)
                {
                    XtraMessageBox.Show("Dòng thứ " + (v_i_row + 1) + " cột MA_NV bị trống!", "THIẾU DỮ LIỆU", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if(m_grv_main.GetRowCellValue(v_i_row, CONST_COLUMN_NAME_IMPORT_TNK.HE_SO) == DBNull.Value)
                {
                    XtraMessageBox.Show("Dòng thứ " + (v_i_row + 1) + " cột HE_SO bị trống!", "THIẾU DỮ LIỆU", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                var v_str_ma_nv = m_grv_main.GetRowCellValue(v_i_row, CONST_COLUMN_NAME_IMPORT_TNK.MA_NV).ToString();
                var v_bol_ma_nv_hop_le = v_dt_ma_nv.AsEnumerable().Where(x=>x.Field<string>(CONST_COLUMN_NAME_IMPORT_TNK.MA_NV) == v_str_ma_nv).Count() > 0 ? true : false;

                if(!v_bol_ma_nv_hop_le)
                {
                    XtraMessageBox.Show("Dòng thứ " + (v_i_row + 1) + " MA_NV: " + v_str_ma_nv + " bị trống!", "THIẾU DỮ LIỆU", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                decimal v_he_so_dong = Convert.ToDecimal(m_grv_main.GetRowCellValue(v_i_row, CONST_COLUMN_NAME_IMPORT_TNK.HE_SO));
                v_tong_he_so += v_he_so_dong;
            }
            if(v_tong_he_so == 0)
            {
                XtraMessageBox.Show("Tổng hệ số bằng 0!", "LỖI DỮ LIỆU", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
        private decimal tinh_tong_he_so()
        {
            decimal v_tong_he_so = 0;
            for(int i = 0; i < m_grv_main.RowCount; i++)
            {
                decimal v_he_so_dong = Convert.ToDecimal(m_grv_main.GetRowCellValue(i, "HE_SO"));
                v_tong_he_so += v_he_so_dong;
            }

            return v_tong_he_so;
        }
        private void tinh_tien_thuong()
        {
            if(!is_valid_data_to_calculate())
            {
                return;
            }
            var dlg = XtraMessageBox.Show("Bạn có muốn tính tiền thu nhập khác dựa vào dữ liệu bạn vừa import vào?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dlg == System.Windows.Forms.DialogResult.No)
            {
                return;
            }
            option_tinh_tnk op_option;
            decimal op_so_tien;
            decimal op_phan_tram_thue;
            f301_option_detail_calculate v_frm = new f301_option_detail_calculate();
            v_frm.Display(out op_option, out op_so_tien, out op_phan_tram_thue);

            if(op_option == option_tinh_tnk.CHUA_CHON)
            {
                return;
            }

            var v_datasource = (DataTable)m_grc_main.DataSource;
            var v_tong_he_so = tinh_tong_he_so();
            if(op_option == option_tinh_tnk.TONG_TIEN)
            {
                foreach(DataRow item in v_datasource.Rows)
                {
                    var v_thanh_tien = Math.Round(Convert.ToDecimal(item["HE_SO"]) / v_tong_he_so * op_so_tien, 0, MidpointRounding.AwayFromZero);
                    var v_thue_phai_nop = Math.Round(v_thanh_tien * op_phan_tram_thue / 1000, MidpointRounding.AwayFromZero);
                    var v_thuc_linh = v_thanh_tien - v_thue_phai_nop;

                    item["THANH_TIEN"] = v_thanh_tien;
                    item["THUE_PHAI_NOP"] = v_thue_phai_nop;
                    item["THUC_LINH"] = v_thuc_linh;
                }
            }
            if(op_option == option_tinh_tnk.DON_GIA)
            {
                foreach(DataRow item in v_datasource.Rows)
                {
                    var v_thanh_tien = Math.Round(Convert.ToDecimal(item["HE_SO"]) * op_so_tien, 0, MidpointRounding.AwayFromZero);
                    var v_thue_phai_nop = Math.Round(v_thanh_tien * op_phan_tram_thue / 100, 0, MidpointRounding.AwayFromZero);
                    var v_thuc_linh = v_thanh_tien - v_thue_phai_nop;

                    item["THANH_TIEN"] = v_thanh_tien;
                    item["THUE_PHAI_NOP"] = v_thue_phai_nop;
                    item["THUC_LINH"] = v_thuc_linh;
                }
            }
            m_grc_main.RefreshDataSource();
        }
        //save
        private void data_row_2_us(DataRow ip_dr_du_lieu_1_nv, ref US_GD_THU_NHAP_KHAC ref_us)
        {
            US_DM_NHAN_VIEN v_us_nhan_vien = new US_DM_NHAN_VIEN();
            ref_us.dcID_NHAN_VIEN = v_us_nhan_vien.getIDNhanVienByMaNV(ip_dr_du_lieu_1_nv["MA_NV"].ToString());

            ref_us.dcSO_TIEN = Convert.ToDecimal(ip_dr_du_lieu_1_nv["THANH_TIEN"]);
          //  ref_us.dcTHANG = Convert.ToDecimal(v_dr["THANG"]);
           // ref_us.dcNAM = Convert.ToDecimal(v_dr["NAM"]);
          //  ref_us.dcID_CACH_TINH_THUE = Convert.ToDecimal(v_dr["ID_CACH_TINH_THUE"]);
          //  ref_us.dcID_LOAI_THU_NHAP_KHAC = Convert.ToDecimal(v_dr["ID_LOAI_QUY_TIEN"]);
          //  ref_us.dcID_QUY_TIEN_THUONG = Convert.ToDecimal(m_sle_quy_tien_thuong.EditValue);

            ref_us.dcSO_TIEN_NOP_THUE = Convert.ToDecimal(ip_dr_du_lieu_1_nv["THUE_PHAI_NOP"]);
            ref_us.dcSO_TIEN_THUC_LINH = Convert.ToDecimal(ip_dr_du_lieu_1_nv["THUC_LINH"]);
            //ref_us.dcTRUY_LINH = 0;
            //ref_us.dcTRUY_THU = 0;
            //ref_us.dcTHUC_LINH_CUOI_CUNG = ref_us.dcSO_TIEN_THUC_LINH + ref_us.dcTRUY_LINH - ref_us.dcTRUY_THU;
        }

        
        private void save()
        {
            set_grid_da_luu_du_lieu();
            XtraMessageBox.Show("Lưu dữ liệu thưởng thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region Event Handle
        private void set_define_event()
        {
            Load += f301_tinh_thu_nhap_khac_Load;
            m_lbl_download_template.Click += m_lbl_download_template_Click;
            m_cmd_import_excel.Click += m_cmd_import_excel_Click;
            m_cmd_save.Click += m_cmd_save_Click;
            m_cmd_tinh_tien_thuong.Click += m_cmd_tinh_tien_thuong_Click;
            m_grv_main.ValidatingEditor += m_grv_main_ValidatingEditor;
            m_cmd_xuat_excel.Click += m_cmd_xuat_excel_Click;
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

        void m_grv_main_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            try
            {
                var oldValue = m_grv_main.GetRowCellDisplayText(m_grv_main.FocusedRowHandle, m_grv_main.FocusedColumn);
                if(XtraMessageBox.Show(String.Format("Bạn có chắc chắn muốn thay đổi dữ liệu từ \"{0}\" thành \"{1}\"? Việc này sẽ thay đổi giá trị đã tính toán trước đó.", oldValue, e.Value), "XÁC NHẬN LẠI SỰ THAY ĐỔI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    e.Valid = false;
                }
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_tinh_tien_thuong_Click(object sender, EventArgs e)
        {
            try
            {
                tinh_tien_thuong();
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
                save();
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
                fill_data_2_grid(WinFormControls.openFileDialog());
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_lbl_download_template_Click(object sender, EventArgs e)
        {
            try
            {
                create_excel_file();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void f301_tinh_thu_nhap_khac_Load(object sender, EventArgs e)
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
