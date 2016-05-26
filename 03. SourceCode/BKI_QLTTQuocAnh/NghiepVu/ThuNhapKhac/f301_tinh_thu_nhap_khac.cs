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
using BKI_DichVuMatDat.COMMON;

namespace BKI_DichVuMatDat.NghiepVu
{
    public partial class f301_tinh_thu_nhap_khac : Form
    {
        //Field & Property
        US_GD_QUY_THU_NHAP_KHAC m_us_gd_quy;
        US_GD_THU_NHAP_KHAC m_us_gd_tnk;
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
            m_lbl_ten_quy.Text = m_us_gd_quy.strTEN_QUY;
            m_lbl_download_template.Select();
        }
        private void set_grid_dang_soan_thao()
        {
            m_lbl_trang_thai_soan_thao.Text = "Đang soạn thảo dữ liệu...";
            m_lbl_trang_thai_soan_thao.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | FontStyle.Italic))));
            m_lbl_trang_thai_soan_thao.ForeColor = Color.Green;
        }
        private void set_grid_da_luu_du_lieu()
        {
            m_lbl_trang_thai_soan_thao.Text = "Dữ liệu đã được lưu!";
            this.m_lbl_trang_thai_soan_thao.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | FontStyle.Regular))));
            m_lbl_trang_thai_soan_thao.ForeColor = Color.Gray;
        }
        //Tao Template
        private DataSet lay_danh_sach_nhan_vien_tinh_thuong()
        {
            US_RPT_LUONG_V2 v_us_rpt_luong = new US_RPT_LUONG_V2();
            DataSet v_ds_danh_sach_nhan_vien = new DataSet();
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
            saveFileDialog1.FileName = "File_Import_Thu_Nhap_Khac_Ap_Dung_" + m_us_gd_quy.strNAM.Trim()+ "." + m_us_gd_quy.strTHANG.Trim();
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                CHRMCommon.make_stt(m_grv_main);
                m_grc_main.DataSource = v_ds.Tables[0];
                m_grv_main.OptionsView.ShowFooter = false;
                m_grv_main.ExportToXls(saveFileDialog1.FileName);
                m_grv_main.OptionsView.ShowFooter = true;
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
        private bool la_so_thap_phan(decimal ip_dc_number)
        {
            var chenh_lech = ip_dc_number - Math.Round(ip_dc_number, MidpointRounding.AwayFromZero);
            if( chenh_lech != 0)
            {
                return true;
            }
            return false;

        }
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
                for(int i = 0; i < m_grv_main.RowCount; i++)
                {
                    var v_dr = m_grv_main.GetDataRow(i);
                    var v_dc_thanh_tien = Convert.ToDecimal(v_dr[CONST_COLUMN_NAME_IMPORT_TNK.THANH_TIEN]);
                    var v_dc_thue = Convert.ToDecimal(v_dr[CONST_COLUMN_NAME_IMPORT_TNK.THUE_PHAI_NOP]);
                    var v_dc_thuc_linh = Convert.ToDecimal(v_dr[CONST_COLUMN_NAME_IMPORT_TNK.THUC_LINH]);

                    if(la_so_thap_phan(v_dc_thanh_tien) || la_so_thap_phan(v_dc_thuc_linh) || la_so_thap_phan(v_dc_thue))
                    {
                        splashScreenManager1.CloseWaitForm();
                        XtraMessageBox.Show("File Excel chưa được làm tròn số tiền (Vẫn còn số thập phân)! Dữ liệu import sẽ bị xóa.", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        m_grc_main.DataSource = null;
                        return;
                    }
                }
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                if(splashScreenManager1.IsSplashFormVisible)
                {
                    splashScreenManager1.CloseWaitForm();
                }
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
                var v_bol_ma_nv_hop_le = v_dt_ma_nv.AsEnumerable().Where(x => x.Field<string>(CONST_COLUMN_NAME_IMPORT_TNK.MA_NV) == v_str_ma_nv).Count() > 0 ? true : false;

                if(!v_bol_ma_nv_hop_le)
                {
                    XtraMessageBox.Show("Dòng thứ " + (v_i_row + 1) + " MA_NV= " + v_str_ma_nv + " chưa tồn tại trong cơ sở dữ liệu phần mềm!", "THIẾU DỮ LIỆU", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        private bool is_valid_data_to_save()
        {
            var v_dt_ma_nv = get_danh_sach_ma_nv();
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
                if(m_grv_main.GetRowCellValue(v_i_row, CONST_COLUMN_NAME_IMPORT_TNK.THANH_TIEN) == DBNull.Value)
                {
                    XtraMessageBox.Show("Dòng thứ " + (v_i_row + 1) + " cột THANH_TIEN bị trống!", "THIẾU DỮ LIỆU", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if(m_grv_main.GetRowCellValue(v_i_row, CONST_COLUMN_NAME_IMPORT_TNK.THUE_PHAI_NOP) == DBNull.Value)
                {
                    XtraMessageBox.Show("Dòng thứ " + (v_i_row + 1) + " cột THUE_PHAI_NOP bị trống!", "THIẾU DỮ LIỆU", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if(m_grv_main.GetRowCellValue(v_i_row, CONST_COLUMN_NAME_IMPORT_TNK.THUC_LINH) == DBNull.Value)
                {
                    XtraMessageBox.Show("Dòng thứ " + (v_i_row + 1) + " cột THUC_LINH bị trống!", "THIẾU DỮ LIỆU", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                var v_str_ma_nv = m_grv_main.GetRowCellValue(v_i_row, CONST_COLUMN_NAME_IMPORT_TNK.MA_NV).ToString();
                var v_bol_ma_nv_hop_le = v_dt_ma_nv.AsEnumerable().Where(x => x.Field<string>(CONST_COLUMN_NAME_IMPORT_TNK.MA_NV) == v_str_ma_nv).Count() > 0 ? true : false;

                if(!v_bol_ma_nv_hop_le)
                {
                    XtraMessageBox.Show("Dòng thứ " + (v_i_row + 1) + " MA_NV= " + v_str_ma_nv + " chưa tồn tại trong cơ sở dữ liệu phần mềm!", "THIẾU DỮ LIỆU", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
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
        private void tinh_theo_tong_tien(decimal ip_dc_tong_tien, decimal ip_dc_phan_tram_thue)
        {
            var v_datasource = (DataTable)m_grc_main.DataSource;
            var v_tong_he_so = tinh_tong_he_so();
            decimal v_tong_thanh_tien_without_last = 0;
            decimal v_tong_thue_phai_nop_without_last = 0;
            decimal v_max_tien = 0;
            int v_max_dong = 0;
            for(int i = 0; i < v_datasource.Rows.Count; i++)
            {
                var item = v_datasource.Rows[i];
                var v_thanh_tien = Math.Round(Convert.ToDecimal(item[CONST_COLUMN_NAME_IMPORT_TNK.HE_SO]) / v_tong_he_so * ip_dc_tong_tien, 0, MidpointRounding.AwayFromZero);
                var v_thue_phai_nop = Math.Round(v_thanh_tien * ip_dc_phan_tram_thue / 100, MidpointRounding.AwayFromZero);
                var v_thuc_linh = v_thanh_tien - v_thue_phai_nop;

                item[CONST_COLUMN_NAME_IMPORT_TNK.THANH_TIEN] = v_thanh_tien;
                item[CONST_COLUMN_NAME_IMPORT_TNK.THUE_PHAI_NOP] = v_thue_phai_nop;
                item[CONST_COLUMN_NAME_IMPORT_TNK.THUC_LINH] = v_thuc_linh;
                v_tong_thanh_tien_without_last = v_tong_thanh_tien_without_last + v_thanh_tien;
                v_tong_thue_phai_nop_without_last = v_tong_thue_phai_nop_without_last + v_thue_phai_nop;

                if(v_thanh_tien > v_max_tien)
                {
                    v_max_tien = v_thanh_tien;
                    v_max_dong = i;
                }
            }

            //Bu tru phan con thieu
            var item_max_tien = v_datasource.Rows[v_max_dong];

           // int v_index_last = v_datasource.Rows.Count - 1;
           // var item_last = v_datasource.Rows[v_index_last];
            var v_thanh_tien_modify = Convert.ToDecimal(item_max_tien[CONST_COLUMN_NAME_IMPORT_TNK.THANH_TIEN]) + ip_dc_tong_tien - v_tong_thanh_tien_without_last;//Math.Round(Convert.ToDecimal(item_last[CONST_COLUMN_NAME_IMPORT_TNK.HE_SO]) / v_tong_he_so * ip_dc_tong_tien, 0, MidpointRounding.AwayFromZero);
            var v_thue_phai_nop_modify = Convert.ToDecimal(item_max_tien[CONST_COLUMN_NAME_IMPORT_TNK.THUE_PHAI_NOP]) + Math.Round(ip_dc_tong_tien * ip_dc_phan_tram_thue / 100, MidpointRounding.AwayFromZero) - v_tong_thue_phai_nop_without_last;//Math.Round(v_thanh_tien_last * ip_dc_phan_tram_thue / 100, MidpointRounding.AwayFromZero);
            var v_thuc_linh_modify = v_thanh_tien_modify - v_thue_phai_nop_modify;

            item_max_tien[CONST_COLUMN_NAME_IMPORT_TNK.THANH_TIEN] = v_thanh_tien_modify;
            item_max_tien[CONST_COLUMN_NAME_IMPORT_TNK.THUE_PHAI_NOP] = v_thue_phai_nop_modify;
            item_max_tien[CONST_COLUMN_NAME_IMPORT_TNK.THUC_LINH] = v_thuc_linh_modify;

        }
        private void tinh_theo_don_gia(decimal ip_dc_don_gia, decimal ip_dc_phan_tram_thue)
        {
            var v_datasource = (DataTable)m_grc_main.DataSource;
            var v_tong_he_so = tinh_tong_he_so();

            foreach(DataRow item in v_datasource.Rows)
            {

                var v_thanh_tien = Math.Round(Convert.ToDecimal(item[CONST_COLUMN_NAME_IMPORT_TNK.HE_SO]) * ip_dc_don_gia, 0, MidpointRounding.AwayFromZero);
                var v_thue_phai_nop = Math.Round(v_thanh_tien * ip_dc_phan_tram_thue / 100, 0, MidpointRounding.AwayFromZero);
                var v_thuc_linh = v_thanh_tien - v_thue_phai_nop;

                item[CONST_COLUMN_NAME_IMPORT_TNK.THANH_TIEN] = v_thanh_tien;
                item[CONST_COLUMN_NAME_IMPORT_TNK.THUE_PHAI_NOP] = v_thue_phai_nop;
                item[CONST_COLUMN_NAME_IMPORT_TNK.THUC_LINH] = v_thuc_linh;
            }
        }
        private void tinh_tien_thu_nhap_khac()
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
            f302_option_detail_calculate v_frm = new f302_option_detail_calculate();
            v_frm.Display(out op_option, out op_so_tien, out op_phan_tram_thue);
            switch(op_option)
            {
                case option_tinh_tnk.CHUA_CHON:
                    return;
                case option_tinh_tnk.TONG_TIEN:
                    tinh_theo_tong_tien(op_so_tien, op_phan_tram_thue);
                    break;
                case option_tinh_tnk.DON_GIA:
                    tinh_theo_don_gia(op_so_tien, op_phan_tram_thue);
                    break;
                case option_tinh_tnk.KHONG_TINH:
                    return;
                default:
                    return;
            }
            m_grc_main.RefreshDataSource();
        }
        //save
        private void save()
        {
            if(!is_valid_data_to_save())
            {
                return;
            }
            var v_dto_thong_tin_quy = TnkQL.Instance.LayThongTinQuy(m_us_gd_quy.dcID);
            if(v_dto_thong_tin_quy.CO_DU_LIEU)
            {
               var v_dlg_yn = XtraMessageBox.Show("Quỹ thưởng đã có dữ liệu của "+ 
                                        + v_dto_thong_tin_quy.SO_LUONG_NV_TRONG_QUY
                                        + " nhân viên. \nViệc lưu dữ liệu này sẽ xóa dữ liệu thu nhập khác của "
                                        + v_dto_thong_tin_quy.SO_LUONG_NV_TRONG_QUY + " nhân viên trước đó đã nhập. \nBạn có chắc chắn muốn LƯU?"
                                        , "CẢNH BÁO"
                                        , MessageBoxButtons.YesNo
                                        , MessageBoxIcon.Stop);
               if(v_dlg_yn == System.Windows.Forms.DialogResult.No)
                {
                    XtraMessageBox.Show("Bạn đã hủy lưu dữ liệu!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            delete_du_lieu_cu(m_us_gd_quy.dcID);
            if (m_bgw.IsBusy)
                m_bgw.CancelAsync();
            else
            {
                this.m_pn.Visible = true;
                this.m_prb.Visible = true;
                m_bgw.RunWorkerAsync();
            }
        }

        private void delete_du_lieu_cu(decimal ip_dc_id_quy)
        {
            US_GD_THU_NHAP_KHAC v_us = new US_GD_THU_NHAP_KHAC();
            v_us.XoaTNKTheoIDQuy(ip_dc_id_quy);
            m_us_gd_tnk = v_us;
            v_us.BeginTransaction();
            //v_us.LayDuLieuThuNhapKhacTheoIDQuy(v_ds, ip_dc_id_quy);
            //for (int i = 0; i < v_ds.Tables[0].Rows.Count; i++)
            //{
            //    v_us = new US_GD_THU_NHAP_KHAC(decimal.Parse(v_ds.Tables[0].Rows[i][0].ToString()));
            //    v_us.Delete();
            //}
        }

        private void insert_gd_thu_nhap_khac(int v_i_row)
        {
            US_GD_THU_NHAP_KHAC v_us_tnk = new US_GD_THU_NHAP_KHAC();
            v_us_tnk.dcID_NHAN_VIEN = ExecuteFuntion.LayNhanVienID(m_grv_main.GetRowCellValue(v_i_row, CONST_COLUMN_NAME_IMPORT_TNK.MA_NV).ToString());
            v_us_tnk.dcTHANG = Convert.ToDecimal(m_us_gd_quy.strTHANG);
            v_us_tnk.dcNAM = Convert.ToDecimal(m_us_gd_quy.strNAM);
            v_us_tnk.dcHE_SO = Convert.ToDecimal(m_grv_main.GetRowCellValue(v_i_row, CONST_COLUMN_NAME_IMPORT_TNK.HE_SO));
            v_us_tnk.dcSO_TIEN = Convert.ToDecimal(m_grv_main.GetRowCellValue(v_i_row, CONST_COLUMN_NAME_IMPORT_TNK.THANH_TIEN)); ;
            v_us_tnk.dcSO_TIEN_NOP_THUE = Convert.ToDecimal(m_grv_main.GetRowCellValue(v_i_row, CONST_COLUMN_NAME_IMPORT_TNK.THUE_PHAI_NOP));
            v_us_tnk.dcSO_TIEN_THUC_LINH = Convert.ToDecimal(m_grv_main.GetRowCellValue(v_i_row, CONST_COLUMN_NAME_IMPORT_TNK.THUC_LINH)); ;
            v_us_tnk.dcID_LOAI_THU_NHAP_KHAC = m_us_gd_quy.dcID_LOAI_QUY_THU_NHAP_KHAC;
            v_us_tnk.dcID_QUY_THU_NHAP_KHAC = m_us_gd_quy.dcID;
            v_us_tnk.strLY_DO = m_us_gd_quy.strLY_DO_THUONG;
            v_us_tnk.UseTransOfUSObject(m_us_gd_tnk);
            v_us_tnk.Insert();
            m_us_gd_tnk = v_us_tnk;
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
            m_bgw.DoWork += m_bgw_DoWork;
            m_bgw.ProgressChanged += m_bgw_ProgressChanged;
            m_bgw.RunWorkerCompleted += m_bgw_RunWorkerCompleted;
        }

        void m_bgw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            m_us_gd_tnk.CommitTransaction();
            m_pn.Visible = false;
            m_prb.Visible = false;
            XtraMessageBox.Show("Lưu dữ liệu thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            set_grid_da_luu_du_lieu();
        }

        void m_bgw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.m_prb.EditValue = e.ProgressPercentage;
        }

        void m_bgw_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                BackgroundWorker worker = sender as BackgroundWorker;
                for (int v_i_row = 0; v_i_row < m_grv_main.RowCount; v_i_row++)
                {
                    insert_gd_thu_nhap_khac(v_i_row);
                    worker.ReportProgress((v_i_row+1)*100/m_grv_main.RowCount);
                }              
            }
            catch (Exception v_e)
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
                tinh_tien_thu_nhap_khac();
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
