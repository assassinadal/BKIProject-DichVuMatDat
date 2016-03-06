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

namespace BKI_DichVuMatDat.NghiepVu
{
    public partial class f301_tinh_thu_nhap_khac_le_tet : Form
    {
        public f301_tinh_thu_nhap_khac_le_tet()
        {
            InitializeComponent();
            format_control();
        }

        #region Private Method
        private void format_control()
        {
            set_define_event();
        }

        private void set_initial_form_load()
        {
            layoutControlItemGrid.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            layoutControlItemSave.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            fill_data_quy_tien_thuong();
        }

        private DS_V_GD_QUY_TIEN_THUONG LayDanhSachQuyTienThuong()
        {
            DS_V_GD_QUY_TIEN_THUONG v_ds_quy_tien_thuong = new DS_V_GD_QUY_TIEN_THUONG();
            US_V_GD_QUY_TIEN_THUONG v_us_quy_tien_thuong = new US_V_GD_QUY_TIEN_THUONG();
            v_us_quy_tien_thuong.LayDanhSachQuyThuongLeTet(out v_ds_quy_tien_thuong);
            return v_ds_quy_tien_thuong;
        }
        private void fill_data_quy_tien_thuong()
        {
            var v_dataset = LayDanhSachQuyTienThuong();
            m_sle_quy_tien_thuong.Properties.DataSource = v_dataset.Tables[0];
        }

        private DataSet lay_danh_sach_nhan_vien_tinh_thuong()
        {
            int index = m_sle_quy_tien_thuong.Properties.GetIndexByKeyValue(m_sle_quy_tien_thuong.EditValue);
            DataRow v_dr = (m_sle_quy_tien_thuong.Properties.DataSource as DataTable).Rows[index];

            US_RPT_LUONG_V2 v_us_rpt_luong = new US_RPT_LUONG_V2();
            DataSet v_ds_danh_sach_nhan_vien;
            v_us_rpt_luong.LayDanhSachMaNVDuocTinhLuong(
                                 out v_ds_danh_sach_nhan_vien
                                 , Convert.ToDecimal(v_dr["THANG"])
                                 , Convert.ToDecimal(v_dr["NAM"]));
            return v_ds_danh_sach_nhan_vien;
        }
        private void create_excel_file()
        {
            if(m_sle_quy_tien_thuong.EditValue == null)
            {
                XtraMessageBox.Show("Bạn chọn quỹ tiền trước nhé!");
                return;
            }

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


        private void hien_thi_form_them_quy_tien()
        {
            f354_danh_sach_quy_thuong_de v_frm = new f354_danh_sach_quy_thuong_de();
            throw(new Exception("Ko duoc dung quy tien cua em nua nhe"));
            //var v_us_quy_tien = v_frm.Display_for_le_tet();
            //if(v_us_quy_tien.dcID > 0)
            //{
            //    fill_data_quy_tien_thuong();
            //    m_sle_quy_tien_thuong.EditValue = v_us_quy_tien.dcID;
            //}
        }

        private void fill_data_2_grid(string ip_path_excel)
        {
            try
            {
                splashScreenManager1.ShowWaitForm();
                m_grc_main.DataSource = null;
                WinFormControls.load_xls_to_gridview(ip_path_excel, m_grc_main);
                layoutControlItemGrid.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                layoutControlItemSave.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
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
        private decimal lay_don_gia_thuong()
        {
            int index = m_sle_quy_tien_thuong.Properties.GetIndexByKeyValue(m_sle_quy_tien_thuong.EditValue);
            DataRow v_dr_selected = (m_sle_quy_tien_thuong.Properties.DataSource as DataTable).Rows[index];

            return Convert.ToDecimal(v_dr_selected[V_GD_QUY_TIEN_THUONG.DON_GIA]);
        }
        private decimal lay_phan_tram_thue()
        {
            int index = m_sle_quy_tien_thuong.Properties.GetIndexByKeyValue(m_sle_quy_tien_thuong.EditValue);
            DataRow v_dr_selected = (m_sle_quy_tien_thuong.Properties.DataSource as DataTable).Rows[index];

            var v_id_cach_tinh_thue = Convert.ToDecimal(v_dr_selected[V_GD_QUY_TIEN_THUONG.ID_CACH_TINH_THUE]);
            if(v_id_cach_tinh_thue == CONST_ID_LOAI_CACH_TINH_THUE.THUE_5PT)
            {
                return 5;
            }
            else if(v_id_cach_tinh_thue == CONST_ID_LOAI_CACH_TINH_THUE.THUE_10PT)
            {
                return 10;
            }
            else return 0;
        }
        private bool is_valid_data_to_save()
        {
            if(m_sle_quy_tien_thuong.EditValue == null)
            {
                XtraMessageBox.Show("Bạn chưa chọn quỹ thưởng!", "THIẾU DỮ LIỆU", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                m_sle_quy_tien_thuong.Focus();
                return false;
            }

            decimal v_tong_he_so = 0;
            for(int i = 0; i < m_grv_main.RowCount; i++)
            {
                if(m_grv_main.GetRowCellValue(i, "HE_SO") == DBNull.Value)
                {
                    XtraMessageBox.Show("Dòng thứ " + (i + 1) + " ô hệ số bị trống!", "THIẾU DỮ LIỆU", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                decimal v_he_so_dong = Convert.ToDecimal(m_grv_main.GetRowCellValue(i, "HE_SO"));
                v_tong_he_so += v_he_so_dong;
            }
            if(v_tong_he_so == 0)
            {
                XtraMessageBox.Show("Tổng hệ số bằng 0!", "LỖI DỮ LIỆU", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void cap_nhat_tinh_xong_quy_thuong(decimal ip_dc_id_quy_tien_thuong)
        {
            US_GD_QUY_TIEN_THUONG v_us_gd_quy_tien = new US_GD_QUY_TIEN_THUONG(ip_dc_id_quy_tien_thuong);
            v_us_gd_quy_tien.strTINH_XONG_YN = "Y";
            v_us_gd_quy_tien.Update();
        }

        private void data_row_2_us(DataRow ip_dr_du_lieu_1_nv, ref US_GD_THU_NHAP_KHAC ref_us)
        {
            int index = m_sle_quy_tien_thuong.Properties.GetIndexByKeyValue(m_sle_quy_tien_thuong.EditValue);
            DataRow v_dr = (m_sle_quy_tien_thuong.Properties.DataSource as DataTable).Rows[index];

            US_DM_NHAN_VIEN v_us_nhan_vien = new US_DM_NHAN_VIEN();
            ref_us.dcID_NHAN_VIEN = v_us_nhan_vien.getIDNhanVienByMaNV(ip_dr_du_lieu_1_nv["MA_NV"].ToString());


            ref_us.dcSO_TIEN = Convert.ToDecimal(ip_dr_du_lieu_1_nv["THANH_TIEN"]);
            ref_us.dcTHANG = Convert.ToDecimal(v_dr["THANG"]);
            ref_us.dcNAM = Convert.ToDecimal(v_dr["NAM"]);
           // ref_us.dcID_CACH_TINH_THUE = Convert.ToDecimal(v_dr["ID_CACH_TINH_THUE"]);
           // ref_us.dcID_LOAI_THU_NHAP_KHAC = Convert.ToDecimal(v_dr["ID_LOAI_QUY_TIEN"]);
            ref_us.dcID_QUY_THU_NHAP_KHAC = Convert.ToDecimal(m_sle_quy_tien_thuong.EditValue);

            ref_us.dcSO_TIEN_NOP_THUE = Convert.ToDecimal(ip_dr_du_lieu_1_nv["THUE_PHAI_NOP"]);
            ref_us.dcSO_TIEN_THUC_LINH = Convert.ToDecimal(ip_dr_du_lieu_1_nv["THUC_LINH"]);
            //ref_us.dcTRUY_LINH = 0;
            //ref_us.dcTRUY_THU = 0;
            //ref_us.dcTHUC_LINH_CUOI_CUNG = ref_us.dcSO_TIEN_THUC_LINH + ref_us.dcTRUY_LINH - ref_us.dcTRUY_THU;
        }
        private void save_data_new()
        {
            try
            {
                var rowCount = m_grv_main.RowCount;
                US_GD_THU_NHAP_KHAC v_us_gd_thu_nhap_khac = new US_GD_THU_NHAP_KHAC();
                v_us_gd_thu_nhap_khac.XoaDuLieuChiaThuongNhanVien(Convert.ToDecimal(m_sle_quy_tien_thuong.EditValue));
                splashScreenManager1.ShowWaitForm();

                for(int i = 0; i < rowCount; i++)
                {
                    var dr = m_grv_main.GetDataRow(i);
                    if(Convert.ToDecimal(dr["HE_SO"]) == 0)
                    {
                        continue;
                    }
                    data_row_2_us(dr, ref v_us_gd_thu_nhap_khac);
                    v_us_gd_thu_nhap_khac.Insert();
                }
                cap_nhat_tinh_xong_quy_thuong(Convert.ToDecimal(m_sle_quy_tien_thuong.EditValue));
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
        private void save_data_replace()
        {
            try
            {
                var rowCount = m_grv_main.RowCount;
                US_GD_THU_NHAP_KHAC v_us_gd_thu_nhap_khac = new US_GD_THU_NHAP_KHAC();
                splashScreenManager1.ShowWaitForm();

                for(int i = 0; i < rowCount; i++)
                {
                    var dr = m_grv_main.GetDataRow(i);
                    US_DM_NHAN_VIEN v_us_nhan_vien = new US_DM_NHAN_VIEN();
                    var v_id_nhan_vien = v_us_nhan_vien.getIDNhanVienByMaNV(dr["MA_NV"].ToString());
                    var is_exist = v_us_gd_thu_nhap_khac.KiemTraXemDaInsertThuong2014Chua(Convert.ToDecimal(m_sle_quy_tien_thuong.EditValue), v_id_nhan_vien);
                    if(is_exist)
                    {
                        continue;
                    }
                    if(Convert.ToDecimal(dr["HE_SO"]) == 0)
                    {
                        continue;
                    }
                    data_row_2_us(dr, ref v_us_gd_thu_nhap_khac);
                    v_us_gd_thu_nhap_khac.Insert();
                }
                cap_nhat_tinh_xong_quy_thuong(Convert.ToDecimal(m_sle_quy_tien_thuong.EditValue));
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
        private bool XetQuyThuongDaChiaNhanVienChua()
        {
            US_GD_THU_NHAP_KHAC v_us_thu_nhap_khac = new US_GD_THU_NHAP_KHAC();
            return v_us_thu_nhap_khac.QuyThuongDaChiaNhanVienChua(Convert.ToDecimal(m_sle_quy_tien_thuong.EditValue));
        }
        #endregion

        #region Event Handle
        private void handle_form_load()
        {
            set_initial_form_load();
        }
        private void handle_label_download_clicked()
        {
            create_excel_file();
        }
        private void handle_them_quy_tien()
        {
            hien_thi_form_them_quy_tien();
        }
        private void handle_form_showned()
        {

        }
        private void handle_import_excel()
        {
            fill_data_2_grid(WinFormControls.openFileDialog());
        }
        private void handle_save()
        {
            if(!is_valid_data_to_save())
            {
                return;
            }
            if(m_grv_main.RowCount <= 0)
            {
                return;
            }


            if(XetQuyThuongDaChiaNhanVienChua())
            {
                var dlg = XtraMessageBox.Show("Qũy thưởng đã chia cho nhân viên rồi. \n Ấn Yes để chia lại thưởng (xóa hết dữ liệu thưởng cũ, thêm dữ liệu thưởng mới), \n Ấn No để tiếp tục lưu dữ liệu thưởng (trong trường hợp quá trình lưu dữ liệu bị gián đoạn). \n Ấn Cancle để hủy hành động.", "XÁC NHẬN", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if(dlg == System.Windows.Forms.DialogResult.Yes)
                {
                    save_data_new();
                }
                else if(dlg == System.Windows.Forms.DialogResult.No)
                {
                    save_data_replace();
                }
                else
                {
                    return;
                }
            }
            else
            {
                save_data_new();
            }

            XtraMessageBox.Show("Lưu dữ liệu thưởng thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void handle_tinh_tien_thuong()
        {
            if(!is_valid_data_to_save())
            {
                return;
            }
            var dlg = XtraMessageBox.Show("Bạn có muốn tính lại dữ liệu thưởng? Việc tính này sẽ sửa lại dữ liệu đã tính (hoặc sửa) trước đó!", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dlg == System.Windows.Forms.DialogResult.No)
            {
                return;
            }
            var v_datasource = (DataTable)m_grc_main.DataSource;
            //var v_tong_he_so = tinh_tong_he_so();
            var v_don_gia_thuong = lay_don_gia_thuong();
            var v_phan_tram_thue = lay_phan_tram_thue();

            foreach(DataRow item in v_datasource.Rows)
            {
                var v_thanh_tien = Convert.ToDecimal(item["HE_SO"]) * v_don_gia_thuong;
                var v_thue_phai_nop = v_thanh_tien * v_phan_tram_thue / 100;
                var v_thuc_linh = v_thanh_tien - v_thue_phai_nop;

                item["THANH_TIEN"] = v_thanh_tien;
                item["THUE_PHAI_NOP"] = v_thue_phai_nop;
                item["THUC_LINH"] = v_thuc_linh;
            }
        }

        private void set_define_event()
        {
            Load += f301_tinh_thu_nhap_khac_Load;
            Shown += f301_tinh_thu_nhap_khac_Shown;
            m_lbl_download_template.Click += m_lbl_download_template_Click;
            m_cmd_them_quy_tien.Click += m_cmd_them_quy_tien_Click;
            m_sle_quy_tien_thuong.CustomDisplayText += m_sle_quy_tien_thuong_CustomDisplayText;
            m_cmd_import_excel.Click += m_cmd_import_excel_Click;
            m_cmd_save.Click += m_cmd_save_Click;
            m_cmd_tinh_tien_thuong.Click += m_cmd_tinh_tien_thuong_Click;
            m_grv_main.CellValueChanged += m_grv_main_CellValueChanged;
            m_grv_main.ValidatingEditor += m_grv_main_ValidatingEditor;
            m_grv_main.ShownEditor += m_grv_main_ShownEditor;
            m_cmd_xem_chi_tiet_quy.Click += m_cmd_xem_chi_tiet_quy_Click;
        }

        void m_cmd_xem_chi_tiet_quy_Click(object sender, EventArgs e)
        {
            try
            {
                if(m_sle_quy_tien_thuong.EditValue == null)
                {
                    return;
                }
                f480_bao_cao_thuong_khac v_frm = new f480_bao_cao_thuong_khac();
                v_frm.display_le_tet(Convert.ToDecimal(m_sle_quy_tien_thuong.EditValue));
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_grv_main_ShownEditor(object sender, EventArgs e)
        {
            try
            {

            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_grv_main_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                e.Appearance.BackColor = Color.Pink;
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

        void m_grv_main_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                //var dlg = XtraMessageBox.Show("Bạn có chắc chắn muốn thay đổi dữ liệu? Việc thay đổi dữ liệu sẽ thay đổi dữ liệu đã tính toán trước đó.", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //if(dlg == System.Windows.Forms.DialogResult.Yes)
                //{

                //}
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
                handle_tinh_tien_thuong();
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
                handle_save();
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
                handle_import_excel();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void f301_tinh_thu_nhap_khac_Shown(object sender, EventArgs e)
        {
            try
            {
                handle_form_showned();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_sle_quy_tien_thuong_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            try
            {
                SearchLookUpEdit v_sle = (sender as SearchLookUpEdit);

                if(v_sle.EditValue != null)
                {
                    int index = v_sle.Properties.GetIndexByKeyValue(v_sle.EditValue);
                    DataRow v_dr_selected = (v_sle.Properties.DataSource as DataTable).Rows[index];

                    e.DisplayText = v_dr_selected[V_GD_QUY_TIEN_THUONG.TEN_LOAI_QUY_TIEN] + " | " + e.DisplayText + " | " + String.Format("{0:#,##0}", v_dr_selected[V_GD_QUY_TIEN_THUONG.DON_GIA]) + " (VNĐ) | " + v_dr_selected[V_GD_QUY_TIEN_THUONG.TEN_CACH_TINH_THUE];
                }
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_them_quy_tien_Click(object sender, EventArgs e)
        {
            try
            {
                handle_them_quy_tien();
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
                handle_label_download_clicked();
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
                handle_form_load();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        #endregion
    }
}
