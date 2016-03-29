using IP.Core.IPCommon;
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
using BKI_DichVuMatDat.DS.CDBNames;
using BKI_DichVuMatDat.US;
using DevExpress.Spreadsheet;
using DevExpress.XtraSplashScreen;
using DevExpress;
using DevComponents;
using DevExpress.XtraEditors;
using IP.Core.IPSystemAdmin;
using BKI_DichVuMatDat.DTO;
using BKI_DichVuMatDat.CONFIRM;
using BKI_DichVuMatDat.COMMON;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Utils;
using BKI_DichVuMatDat.NghiepVu.Luong;

namespace BKI_DichVuMatDat.BaoCao
{
    public partial class f409_rpt_bang_luong_nv_v2 : Form
    {
        //Field & Property
        BindingList<DTO_BANG_LUONG_V2> m_lst_luong_v2 = new BindingList<DTO_BANG_LUONG_V2>();
        BindingList<string> m_lst_nhan_vien_khong_ton_tai = new BindingList<string>();

        #region Public Interface
        ~f409_rpt_bang_luong_nv_v2()
        {
            Dispose(true);
        }
        public f409_rpt_bang_luong_nv_v2()
        {
            InitializeComponent();
            format_controls();
        }
        public void Display()
        {
            this.m_grv_main.BestFitColumns(true);
            this.ShowDialog();
        }
        public void Display(decimal ip_dc_thang, decimal ip_dc_nam)
        {
            this.m_grv_main.BestFitColumns(true);
            m_txt_thang.EditValue = ip_dc_thang;
            m_txt_nam.EditValue = ip_dc_nam;
            m_txt_thang.Enabled = false;
            m_txt_nam.Enabled = false;
            this.ShowDialog();
        }
        #endregion

        #region Event Handle
        private void set_define_events()
        {
            FormClosed += f409_rpt_bang_luong_FormClosed;
            Load += f409_rpt_bang_luong_Load;
            m_cmd_tinh_bang_luong.Click += m_cmd_tinh_bang_luong_Click;
            m_cmd_luu_du_lieu.Click += m_cmd_luu_du_lieu_Click;
            m_txt_thang.Leave += m_txt_thang_Leave;
            m_txt_nam.Leave += m_txt_nam_Leave;
            m_cmd_import_excel.Click += m_cmd_import_excel_Click;
            m_cmd_export_excel.Click += m_cmd_export_excel_Click;
            m_grv_main.MouseWheel += m_grv_main_MouseWheel;
            m_cmd_kiem_tra_du_lieu.Click += m_cmd_kiem_tra_du_lieu_Click;
        }

        void m_cmd_kiem_tra_du_lieu_Click(object sender, EventArgs e)
        {
            try
            {
                if(TinhLuongQL.Instance.LayThongTinBangLuong(lay_thang(), lay_nam()).CHOT_BANG_LUONG)
                {
                    XtraMessageBox.Show("Bảng lương đã được chốt, bạn không được thực hiện thao tác này. (Nếu muốn thực hiện, cần bỏ chốt bảng lương)!", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                ra_soat_thong_tin_du_lieu_tinh_luong();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_grv_main_MouseWheel(object sender, MouseEventArgs e)
        {
            try
            {
                m_grv_main.TopRowIndex += e.Delta > 0 ? -3 : 3;
                ((DXMouseEventArgs)e).Handled = true;
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_export_excel_Click(object sender, EventArgs e)
        {
            try
            {
                xuat_excel_bang_luong();
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
                if(TinhLuongQL.Instance.LayThongTinBangLuong(lay_thang(), lay_nam()).CHOT_BANG_LUONG)
                {
                    XtraMessageBox.Show("Bảng lương đã được chốt, bạn không được thực hiện thao tác này. (Nếu muốn thực hiện, cần bỏ chốt bảng lương)!", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                load_data_excel_to_grid(WinFormControls.openFileDialog());
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void f409_rpt_bang_luong_FormClosed(object sender, FormClosedEventArgs e)
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

        void f409_rpt_bang_luong_Load(object sender, EventArgs e)
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

        //Nghiep vu tinh luong
        void m_cmd_luu_du_lieu_Click(object sender, EventArgs e)
        {
            try
            {
                if(TinhLuongQL.Instance.LayThongTinBangLuong(lay_thang(), lay_nam()).CHOT_BANG_LUONG)
                {
                    XtraMessageBox.Show("Bảng lương đã được chốt, bạn không được thực hiện thao tác này. (Nếu muốn thực hiện, cần bỏ chốt bảng lương)!", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                start_luu_bang_luong_process();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_cmd_tinh_bang_luong_Click(object sender, EventArgs e)
        {
            try
            {
                if(TinhLuongQL.Instance.LayThongTinBangLuong(lay_thang(), lay_nam()).CHOT_BANG_LUONG)
                {
                    XtraMessageBox.Show("Bảng lương đã được chốt, bạn không được thực hiện thao tác này. (Nếu muốn thực hiện, cần bỏ chốt bảng lương)!", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                if(m_bgwk.IsBusy)
                {
                    XtraMessageBox.Show("Chức năng đang thực hiện tính toán dữ liệu lương rồi, bạn đợi chút", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if(m_grc_main.DataSource != null && m_grv_main.RowCount != 0)
                {
                    var v_dlg_confirm = XtraMessageBox.Show("Lưới đang có dữ liệu. Việc tính này sẽ xóa dữ liệu đã tính trên lưới. Bạn có muốn tiếp tục?"
                                                                , "XÁC NHẬN"
                                                                , MessageBoxButtons.YesNo
                                                                , MessageBoxIcon.Question);
                    if(v_dlg_confirm == System.Windows.Forms.DialogResult.No)
                    {
                        XtraMessageBox.Show("Bạn đã hủy thao tác", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                clear_grid();
                hide_grid();
                show_progress_bar();
                m_bgwk.RunWorkerAsync();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_bgwk_DoWork(object sender, DoWorkEventArgs e)
        {
            var worker = sender as BackgroundWorker;
            try
            {

                if(!kiem_tra_tinh_hop_le_du_lieu_tren_giao_dien())
                {
                    worker.CancelAsync();
                    e.Cancel = true;
                    return;
                }
                //if(kiem_tra_bang_luong_da_chot_chua())
                //{
                //    XtraMessageBox.Show("Bảng lương đã được chốt rồi, không tính lại được!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    worker.CancelAsync();
                //    e.Cancel = true;
                //    return;
                //}

                start_tinh_bang_luong_process();
                if(worker.CancellationPending)
                {
                    e.Cancel = true;
                    worker.CancelAsync();
                }
            }
            catch(Exception v_e)
            {
                worker.CancelAsync();
                e.Cancel = true;
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_bgwk_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                var worker = sender as BackgroundWorker;
                if((e.Cancelled == true))
                {
                    m_prb.Text = "Thao tác bị hoãn!";
                    hide_progress_bar();
                    hide_grid();
                    clear_grid();
                    return;
                }

                else if(!(e.Error == null))
                {
                    m_prb.Text = ("Lỗi: " + e.Error.Message);
                    hide_progress_bar();
                    hide_grid();
                    clear_grid();
                    return;
                }
                else
                {
                    m_prb.Text = "Đã xong!";
                }
                hide_progress_bar();
                load_data_2_grid();
                hien_thi_thong_tin_bang_luong();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_bgwk_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            try
            {
                //this.m_prb.Text = (e.ProgressPercentage.ToString() + "%");
                this.m_prb.EditValue = e.ProgressPercentage;
            }
            catch(Exception)
            {
            }

        }


        //Other
        void m_txt_nam_Leave(object sender, EventArgs e)
        {
            try
            {
                hien_thi_thong_tin_bang_luong();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        void m_txt_thang_Leave(object sender, EventArgs e)
        {
            try
            {
                hien_thi_thong_tin_bang_luong();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_xem_bang_luong_Click(object sender, EventArgs e)
        {
            try
            {
                load_data_2_grid();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_grv_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            try
            {
                var v_dr_Focused = m_grv_main.GetDataRow(m_grv_main.FocusedRowHandle);
                var v_obj_oldValue = m_grv_main.GetRowCellDisplayText(m_grv_main.FocusedRowHandle, m_grv_main.FocusedColumn);
                if(XtraMessageBox.Show(String.Format("Bạn có chắc chắn muốn thay đổi dữ liệu từ \"{0}\" thành \"{1}\"? " +
                                                        "Việc này sẽ thay đổi giá trị đã tính toán trước đó.", v_obj_oldValue, e.Value)
                                                        , "XÁC NHẬN LẠI SỰ THAY ĐỔI"
                                                        , MessageBoxButtons.YesNo
                                                        , MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    e.Valid = false;
                }
                else
                {
                    e.Valid = true;
                }
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        #endregion

        #region Data Structure
        enum e_col_thu_tu_bang_luong
        {
            MA_NV = 0,

            HO_TEN = 1,
            DON_VI = 2,
            CHUC_VU = 3,

            LUONG_NS = 4,
            LUONG_CHE_DO = 5,
            AN_CA = 6,
            PHU_CAP_TN = 7,
            LAM_THEM_150 = 8,
            THU_NHAP_KHAC_TRONG_LUONG = 9,
            TONG_THU_NHAP_TRONG_LUONG = 10,
            THUONG = 11,
            THUONG_ATHK = 12,
            THUONG_LE_TET = 13,
            BO_SUNG_LUONG = 14,
            THU_NHAP_KHAC_NGOAI_LUONG = 15,
            TONG_THU_NHAP_NGOAI_LUONG = 16,
            TONG_THU_NHAP = 17,
            TONG_THU_NHAP_CHIU_THUE = 18,
            //GIAM_TRU_AN_CA = 19,
            GIAM_TRU_BHXH = 19,
            GIAM_TRU_BHYT = 20,
            GIAM_TRU_BHTN = 21,
            GIAM_TRU_LAM_THEM = 22,
            GIAM_TRU_GIA_CANH = 23,
            GIAM_TRU_PHU_THUOC = 24,
            GIAM_TRU_KHAC = 25,
            TONG_GIAM_TRU_THUE = 26,
            THU_NHAP_TINH_THUE = 27,
            PHAI_THU_BHXH = 28,
            PHAI_THU_BHYT = 29,
            PHAI_THU_BHTN = 30,
            DOAN_PHI = 31,
            THUE_TNCN = 32,
            PHAI_THU_KHAC = 33,
            DA_NOP_THUE_TNCN = 34,
            TONG_PHAI_NOP = 35,
            THUC_LINH = 36
        }
        #endregion

        #region Private Methods
        //Setup Form
        private void format_controls()
        {
            set_define_events();
        }
        private void set_initial_form_load()
        {
            hide_progress_bar();
            //m_txt_nam.EditValue = DateTime.Now.Year;
            //m_txt_thang.EditValue = DateTime.Now.Month;
            //m_txt_thang.Focus();
            hien_thi_thong_tin_bang_luong();
            hide_grid();
        }

        //Action giao dien
        private void hide_progress_bar()
        {
            m_prb.Visible = false;
        }
        private void show_progress_bar()
        {
            m_prb.Visible = true;
            m_prb.BringToFront();
        }
        private void show_grid()
        {
            m_grc_main.Visible = true;
        }
        private void hide_grid()
        {
            m_grc_main.Visible = false;
        }
        private void clear_grid()
        {
            m_lst_luong_v2 = new BindingList<DTO_BANG_LUONG_V2>();
            m_lst_nhan_vien_khong_ton_tai = new BindingList<string>();
            m_grc_main.DataSource = null;
            m_grc_main.RefreshDataSource();
        }

        //Load data
        private decimal lay_thang()
        {
            return Convert.ToDecimal(m_txt_thang.EditValue);
        }
        private decimal lay_nam()
        {
            return Convert.ToDecimal(m_txt_nam.EditValue);
        }

        private void load_data_2_grid()
        {
            m_grc_main.DataSource = null;
            m_grc_main.DataSource = m_lst_luong_v2;
            show_grid();
        }
        private void hien_thi_thong_tin_bang_luong()
        {
            if(m_txt_thang.EditValue == null || m_txt_nam.EditValue == null)
            {
                return;
            }
            var v_dto_thong_tin_bang_luong = TinhLuongQL.Instance.LayThongTinBangLuong(lay_thang(), lay_nam());

            if(v_dto_thong_tin_bang_luong.SO_LUONG_NHAN_VIEN_CAN_TINH == v_dto_thong_tin_bang_luong.SO_LUONG_NHAN_VIEN_DA_TINH)
            {
                m_lbl_thong_bao.Text = "Bảng lương trong Phần mềm đã có lương của ";
                m_lbl_thong_bao.ForeColor = Color.Green;
                m_lbl_so_luong_nv_tinh_luong.ForeColor = Color.Green;
            }
            if(v_dto_thong_tin_bang_luong.SO_LUONG_NHAN_VIEN_CAN_TINH > v_dto_thong_tin_bang_luong.SO_LUONG_NHAN_VIEN_DA_TINH)
            {
                m_lbl_thong_bao.Text = "Bảng lương trong Phần mềm đã có lương của ";
                m_lbl_thong_bao.ForeColor = Color.Red;
                m_lbl_so_luong_nv_tinh_luong.ForeColor = Color.Red;
            }

            if(v_dto_thong_tin_bang_luong.CHOT_BANG_LUONG)
            {
                m_lbl_trang_thai_bang_luong.ForeColor = Color.Gray;
                m_lbl_trang_thai_bang_luong.Text = "|Đã chốt, không chỉnh sửa";
                m_lbl_so_luong_nv_tinh_luong.Text = v_dto_thong_tin_bang_luong.SO_LUONG_NHAN_VIEN_DA_TINH.ToString();
                m_lbl_so_luong_nv_tinh_luong.ForeColor = Color.Gray;
            }

            else
            {
                m_lbl_so_luong_nv_tinh_luong.ForeColor = Color.Gray;
                m_lbl_so_luong_nv_tinh_luong.Text = v_dto_thong_tin_bang_luong.SO_LUONG_NHAN_VIEN_DA_TINH.ToString() + "/"
                                                    + v_dto_thong_tin_bang_luong.SO_LUONG_NHAN_VIEN_CAN_TINH.ToString() + " (nhân viên)";
                m_lbl_trang_thai_bang_luong.ForeColor = Color.Green;
                m_lbl_trang_thai_bang_luong.Text = "|Chưa chốt, có thể chỉnh sửa";
            }
        }

        //Check data

        private bool kiem_tra_tinh_hop_le_du_lieu_tren_giao_dien()
        {
            if(m_txt_thang.EditValue == null || m_txt_nam.EditValue == null)
            {
                XtraMessageBox.Show("Bạn nhập tháng & năm trước!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void ra_soat_thong_tin_du_lieu_tinh_luong()
        {
            F401_he_so_bao_cao_luong v_frm = new F401_he_so_bao_cao_luong();
            v_frm.hien_thi_ra_soat_tinh_luong(lay_thang(), lay_nam());
        }

        //Action
        private void xoa_bang_luong_thang()
        {
            TinhLuongQL.Instance.XoaToanBoBangLuong(lay_thang(), lay_nam());
        }


        //Process tinh bang luong
        private void start_tinh_bang_luong_process()
        {

            var v_dlg_confirm = confirm_cach_tinh_bang_luong_tu_nguoi_dung();
            if(v_dlg_confirm == ENUM_CONFIRM_TINH_BANG_LUONG.NONE)
            {
                m_bgwk.CancelAsync();
                return;
            }
            var v_ds_danh_sach_nhan_vien = TinhLuongQL.Instance.LayDanhSachNhanVienCanTinhLuong(v_dlg_confirm, lay_thang(), lay_nam());
            tinh_bang_luong_tu_dong(v_ds_danh_sach_nhan_vien);
        }
        private ENUM_CONFIRM_TINH_BANG_LUONG confirm_cach_tinh_bang_luong_tu_nguoi_dung()
        {
            msg001_confirm_tinh_bang_luong v_msg_confirm = new msg001_confirm_tinh_bang_luong();
            ENUM_CONFIRM_TINH_BANG_LUONG v_dlg_confirm;
            var v_dto_thong_tin_bang_luong = TinhLuongQL.Instance.LayThongTinBangLuong(lay_thang(), lay_nam());

            //if(v_dto_thong_tin_bang_luong.CHOT_BANG_LUONG)
            //{
            //    XtraMessageBox.Show("Bạn không thể tính toán lương nhân viên khi bảng lương đã được chốt!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    v_dlg_confirm = ENUM_CONFIRM_TINH_BANG_LUONG.NONE;
            //}
            if(v_dto_thong_tin_bang_luong.CO_DU_LIEU_LUONG)
            {
                v_dlg_confirm = v_msg_confirm.display();
            }
            else
            {
                v_dlg_confirm = ENUM_CONFIRM_TINH_BANG_LUONG.TINH_LAI_TOAN_BO;
            }

            return v_dlg_confirm;
        }


        private void tinh_bang_luong_tu_dong(DataSet ip_ds_danh_sach_nv)
        {

            int v_i_so_luong_nv = ip_ds_danh_sach_nv.Tables[0].Rows.Count;
            for(int i = 0; i < v_i_so_luong_nv; i++)
            {
                DataRow v_dr_nv = ip_ds_danh_sach_nv.Tables[0].Rows[i];
                decimal v_dc_id_nhan_vien = Convert.ToDecimal(v_dr_nv[0]);

                //DataRow v_dr_luong_nv = get_luong_1_nhan_vien_v2(v_dc_id_nhan_vien, (int)lay_thang(), (int)lay_nam());
                DTO_BANG_LUONG_V2 v_dto_luong = TinhLuongQL.Instance.TinhToanBangLuongNhanVien(v_dc_id_nhan_vien, lay_thang(), lay_nam());
                m_lst_luong_v2.Add(v_dto_luong);
                m_bgwk.ReportProgress((i + 1) * 100 / ip_ds_danh_sach_nv.Tables[0].Rows.Count);
            }
        }



        //Process luu bang luong
        private void start_luu_bang_luong_process()
        {
            if(m_bgwk.IsBusy)
            {
                XtraMessageBox.Show("Chức năng đang thực hiện tính toán dữ liệu lương rồi, bạn đợi chút", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var v_dto_thong_tin_bang_luong = TinhLuongQL.Instance.LayThongTinBangLuong(lay_thang(), lay_nam());
            msg002_confirm_luu_du_lieu_bang_luong v_msg_confirm;
            ENUM_CONFIRM_LUU_BANG_LUONG v_dlg_confirm_save;

            if(v_dto_thong_tin_bang_luong.CHOT_BANG_LUONG)
            {
                var v_yn_tiep_tuc = XtraMessageBox.Show("Bảng lương đã được chốt! Bạn có muốn chỉnh sửa dữ liệu lương không? (Việc này có thể dẫn đến việc sai lệch với dữ liệu lương đã chốt)", "CẢNH BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                if(v_yn_tiep_tuc == System.Windows.Forms.DialogResult.No)
                {
                    XtraMessageBox.Show("Bạn đã hủy thao tác!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    XtraMessageBox.Show("Bạn đã chọn việc sửa lại bảng lương sau khi đã chốt!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if(v_dto_thong_tin_bang_luong.CO_DU_LIEU_LUONG)
            {
                v_msg_confirm = new msg002_confirm_luu_du_lieu_bang_luong();
                v_dlg_confirm_save = v_msg_confirm.Display();
            }
            else
            {
                v_dlg_confirm_save = ENUM_CONFIRM_LUU_BANG_LUONG.TINH_LAI_TOAN_BO;
            }

            try
            {

                //progressBarControl1.Visible = true;
                //progressBarControl1.Show();
                save_data(v_dlg_confirm_save);
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                //progressBarControl1.Visible = false;
                //progressBarControl1.Hide();

            }

        }
        private void xuat_excel_nhan_vien_chua_co_trong_csdl()
        {
            DataTable v_dt_src = new DataTable();
            v_dt_src.Columns.Add("MA_NV");
            v_dt_src.Columns["MA_NV"].DataType = typeof(string);
            foreach(var item in m_lst_nhan_vien_khong_ton_tai)
            {
                v_dt_src.Rows.Add(item);
            }
            gridControl1.DataSource = v_dt_src;

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "xlsx files (*.xlsx)|*.xls|All files (*.*)|*.*";
            saveFileDialog1.RestoreDirectory = true;
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                gridView1.ExportToXls(saveFileDialog1.FileName);
                DevExpress.XtraEditors.XtraMessageBox.Show("Trích xuất thành công. File sẽ tự động mở sau đây!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private bool kiem_tra_du_lieu_nhan_vien_truoc_khi_luu()
        {
            var flag = true;
            m_lst_nhan_vien_khong_ton_tai = new BindingList<string>();

            var v_i_row_count = m_grv_main.RowCount;
            for(int v_i_row = 0; v_i_row < v_i_row_count; v_i_row++)
            {
                var v_str_ma_nv = m_grv_main.GetRowCellValue(v_i_row, RPT_LUONG.MA_NV).ToString();
                if(!ExecuteFuntion.KiemTraNhanVienCoTrongCsdlChua(v_str_ma_nv))
                {
                    flag = false;
                    m_lst_nhan_vien_khong_ton_tai.Add(v_str_ma_nv);
                }
            }
            return flag;
        }


        private void save_data(ENUM_CONFIRM_LUU_BANG_LUONG ip_confirm_save)
        {
            SplashScreenManager.ShowForm(this, typeof(SplashScreen1), true, true, false);
            string v_str_msg = "";
            try
            {
                if(ip_confirm_save == ENUM_CONFIRM_LUU_BANG_LUONG.NONE)
                {
                    XtraMessageBox.Show("Bạn đã hủy thao tác!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if(!kiem_tra_du_lieu_nhan_vien_truoc_khi_luu())
                {
                    var v_dc_so_nv_khong_co_trong_csdl = m_lst_nhan_vien_khong_ton_tai.Count;
                    XtraMessageBox.Show("Có " + v_dc_so_nv_khong_co_trong_csdl + " mã nhân viên không có trong phần mềm. Bạn lưu danh sách vào nhé!");
                    xuat_excel_nhan_vien_chua_co_trong_csdl();
                    return;
                }
                //US_RPT_LUONG_V2 v_us_rpt_luong_v2 = new US_RPT_LUONG_V2();
                DTO_BANG_LUONG_V2 v_dto_bang_luong_v2 = new DTO_BANG_LUONG_V2();

                var v_i_row_count = m_grv_main.RowCount;
                if(ip_confirm_save == ENUM_CONFIRM_LUU_BANG_LUONG.NONE)
                {
                    XtraMessageBox.Show("Bảng lương chưa được lưu!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if(ip_confirm_save == ENUM_CONFIRM_LUU_BANG_LUONG.TINH_LAI_TOAN_BO)
                {
                    TinhLuongQL.Instance.XoaToanBoBangLuong(lay_thang(), lay_nam());
                }

                int v_i_so_luong_ghi_moi = 0;
                int v_i_so_luong_ghi_de = 0;
                for(int v_i_row = 0; v_i_row < v_i_row_count; v_i_row++)
                {
                    v_dto_bang_luong_v2 = (DTO_BANG_LUONG_V2)m_grv_main.GetRow(v_i_row);
                    //v_us_rpt_luong_v2 = transfer_dto_2_us_object(v_dto_bang_luong_v2);

                    var v_bol_nv_co_trong_bang_luong_chua = TinhLuongQL.Instance.KiemTraNhanVienCoTrongBangLuongChua(v_dto_bang_luong_v2);
                    switch(ip_confirm_save)
                    {
                        case ENUM_CONFIRM_LUU_BANG_LUONG.TINH_LAI_TOAN_BO:
                            TinhLuongQL.Instance.InsertBanGhiLuongNhanVien(v_dto_bang_luong_v2);
                            v_i_so_luong_ghi_moi = v_i_so_luong_ghi_moi + 1;
                            break;
                        case ENUM_CONFIRM_LUU_BANG_LUONG.CHUA_CO_THI_GHI_MOI_DA_CO_THI_KHONG_LAM_GI:
                            if(!v_bol_nv_co_trong_bang_luong_chua)
                            {
                                TinhLuongQL.Instance.InsertBanGhiLuongNhanVien(v_dto_bang_luong_v2);
                                v_i_so_luong_ghi_moi = v_i_so_luong_ghi_moi + 1;
                            }
                            break;
                        case ENUM_CONFIRM_LUU_BANG_LUONG.CHUA_CO_THI_GHI_MOI_DA_CO_THI_GHI_DE:
                            if(!v_bol_nv_co_trong_bang_luong_chua)
                            {
                                TinhLuongQL.Instance.InsertBanGhiLuongNhanVien(v_dto_bang_luong_v2);
                                v_i_so_luong_ghi_moi = v_i_so_luong_ghi_moi + 1;
                            }
                            else
                            {
                                TinhLuongQL.Instance.ReplaceBanGhiLuongNhanVien(v_dto_bang_luong_v2);
                                v_i_so_luong_ghi_de = v_i_so_luong_ghi_de + 1;
                            }
                            break;
                        case ENUM_CONFIRM_LUU_BANG_LUONG.CHUA_CO_THI_KHONG_LAM_GI_DA_CO_THI_GHI_DE:
                            if(v_bol_nv_co_trong_bang_luong_chua)
                            {
                                TinhLuongQL.Instance.ReplaceBanGhiLuongNhanVien(v_dto_bang_luong_v2);
                                v_i_so_luong_ghi_de = v_i_so_luong_ghi_de + 1;
                            }
                            break;
                        default:
                            throw new Exception("Chưa gán giá trị cho ENUM_CONFIRM_LUU_BANG_LUONG!");

                    }
                    //m_prb.EditValue = (int)((decimal)v_i_row / (decimal)v_i_row_count * 100);
                    SplashScreenManager.Default.SendCommand(SplashScreen1.SplashScreenCommand.SetProgress, (int)((decimal)v_i_row / (decimal)v_i_row_count * 100));
                    //progressBarControl1.EditValue = (int)((decimal)v_i_row / (decimal)v_i_row_count * 100);
                }
                v_str_msg = "Lưu dữ liệu lương thành công. Có " + v_i_so_luong_ghi_moi + " bản ghi lương nhân viên mới, có " + v_i_so_luong_ghi_de + " bản ghi lương nhân viên ghi đè!";
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                SplashScreenManager.CloseForm(false);
            }

            XtraMessageBox.Show(v_str_msg, "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            hien_thi_thong_tin_bang_luong();
        }

        //Process khac
        private void format_table_source_after_import(DataTable ip_dt_src)
        {
            ip_dt_src.Rows.RemoveAt(0);
            ip_dt_src.Rows.RemoveAt(0);
            if(ip_dt_src.Rows[ip_dt_src.Rows.Count - 1][(int)e_col_thu_tu_bang_luong.LUONG_NS] == DBNull.Value)
            {
                ip_dt_src.Rows.RemoveAt(ip_dt_src.Rows.Count - 1);
            }
            ip_dt_src.Columns[(int)e_col_thu_tu_bang_luong.MA_NV].ColumnName = RPT_LUONG_V2.MA_NV;
            ip_dt_src.Columns[(int)e_col_thu_tu_bang_luong.HO_TEN].ColumnName = RPT_LUONG_V2.HO_TEN;
            ip_dt_src.Columns[(int)e_col_thu_tu_bang_luong.DON_VI].ColumnName = RPT_LUONG_V2.TEN_DON_VI;
            ip_dt_src.Columns[(int)e_col_thu_tu_bang_luong.CHUC_VU].ColumnName = RPT_LUONG_V2.TEN_CHUC_VU;

            ip_dt_src.Columns[(int)e_col_thu_tu_bang_luong.LUONG_NS].ColumnName = RPT_LUONG_V2.LUONG_NS;
            ip_dt_src.Columns[(int)e_col_thu_tu_bang_luong.LUONG_CHE_DO].ColumnName = RPT_LUONG_V2.LUONG_CD;
            ip_dt_src.Columns[(int)e_col_thu_tu_bang_luong.AN_CA].ColumnName = RPT_LUONG_V2.AN_CA;
            ip_dt_src.Columns[(int)e_col_thu_tu_bang_luong.PHU_CAP_TN].ColumnName = RPT_LUONG_V2.PHU_CAP_TN;
            ip_dt_src.Columns[(int)e_col_thu_tu_bang_luong.LAM_THEM_150].ColumnName = RPT_LUONG_V2.LAM_THEM;
            ip_dt_src.Columns[(int)e_col_thu_tu_bang_luong.THU_NHAP_KHAC_TRONG_LUONG].ColumnName = RPT_LUONG_V2.THU_NHAP_KHAC_TRONG_LUONG;
            ip_dt_src.Columns[(int)e_col_thu_tu_bang_luong.TONG_THU_NHAP_TRONG_LUONG].ColumnName = RPT_LUONG_V2.TONG_THU_NHAP_TRONG_LUONG;
            ip_dt_src.Columns[(int)e_col_thu_tu_bang_luong.THUONG].ColumnName = RPT_LUONG_V2.THUONG;
            ip_dt_src.Columns[(int)e_col_thu_tu_bang_luong.THUONG_ATHK].ColumnName = RPT_LUONG_V2.THUONG_ATHK;
            ip_dt_src.Columns[(int)e_col_thu_tu_bang_luong.THUONG_LE_TET].ColumnName = RPT_LUONG_V2.THUONG_LE_TET;
            ip_dt_src.Columns[(int)e_col_thu_tu_bang_luong.BO_SUNG_LUONG].ColumnName = RPT_LUONG_V2.BO_SUNG_LUONG;
            ip_dt_src.Columns[(int)e_col_thu_tu_bang_luong.THU_NHAP_KHAC_NGOAI_LUONG].ColumnName = RPT_LUONG_V2.THU_NHAP_KHAC_NGOAI_LUONG;
            ip_dt_src.Columns[(int)e_col_thu_tu_bang_luong.TONG_THU_NHAP_NGOAI_LUONG].ColumnName = RPT_LUONG_V2.TONG_THU_NHAP_NGOAI_LUONG;
            ip_dt_src.Columns[(int)e_col_thu_tu_bang_luong.TONG_THU_NHAP].ColumnName = RPT_LUONG_V2.TONG_THU_NHAP;
            ip_dt_src.Columns[(int)e_col_thu_tu_bang_luong.TONG_THU_NHAP_CHIU_THUE].ColumnName = RPT_LUONG_V2.TONG_THU_NHAP_CHIU_THUE;
            ip_dt_src.Columns[(int)e_col_thu_tu_bang_luong.GIAM_TRU_BHXH].ColumnName = RPT_LUONG_V2.BHXH;
            ip_dt_src.Columns[(int)e_col_thu_tu_bang_luong.GIAM_TRU_BHYT].ColumnName = RPT_LUONG_V2.BHYT;
            ip_dt_src.Columns[(int)e_col_thu_tu_bang_luong.GIAM_TRU_BHTN].ColumnName = RPT_LUONG_V2.BHTN;
            ip_dt_src.Columns[(int)e_col_thu_tu_bang_luong.GIAM_TRU_LAM_THEM].ColumnName = RPT_LUONG_V2.GIAM_TRU_LAM_THEM_150;
            ip_dt_src.Columns[(int)e_col_thu_tu_bang_luong.GIAM_TRU_GIA_CANH].ColumnName = RPT_LUONG_V2.GIAM_TRU_GIA_CANH;
            ip_dt_src.Columns[(int)e_col_thu_tu_bang_luong.GIAM_TRU_PHU_THUOC].ColumnName = RPT_LUONG_V2.GIAM_TRU_PHU_THUOC;
            ip_dt_src.Columns[(int)e_col_thu_tu_bang_luong.GIAM_TRU_KHAC].ColumnName = RPT_LUONG_V2.GIAM_TRU_KHAC;
            ip_dt_src.Columns[(int)e_col_thu_tu_bang_luong.TONG_GIAM_TRU_THUE].ColumnName = RPT_LUONG_V2.TONG_GIAM_TRU_THUE;
            ip_dt_src.Columns[(int)e_col_thu_tu_bang_luong.THU_NHAP_TINH_THUE].ColumnName = RPT_LUONG_V2.THU_NHAP_CHIU_THUE;
            //ip_dt_src.Columns[(int)e_col_thu_tu_bang_luong.PHAI_THU_BHYT].ColumnName = RPT_LUONG_V2.BHYT;
            //ip_dt_src.Columns[(int)e_col_thu_tu_bang_luong.PHAI_THU_BHXH].ColumnName = RPT_LUONG_V2.BHXH;
            //ip_dt_src.Columns[(int)e_col_thu_tu_bang_luong.PHAI_THU_BHTN].ColumnName = RPT_LUONG_V2.BHTN;
            ip_dt_src.Columns[(int)e_col_thu_tu_bang_luong.DOAN_PHI].ColumnName = RPT_LUONG_V2.DOAN_PHI_CD;
            ip_dt_src.Columns[(int)e_col_thu_tu_bang_luong.THUE_TNCN].ColumnName = RPT_LUONG_V2.THUE;
            ip_dt_src.Columns[(int)e_col_thu_tu_bang_luong.PHAI_THU_KHAC].ColumnName = RPT_LUONG_V2.PHAI_NOP_KHAC;
            ip_dt_src.Columns[(int)e_col_thu_tu_bang_luong.DA_NOP_THUE_TNCN].ColumnName = RPT_LUONG_V2.SO_TIEN_DA_NOP_THUE;
            ip_dt_src.Columns[(int)e_col_thu_tu_bang_luong.TONG_PHAI_NOP].ColumnName = RPT_LUONG_V2.TONG_PHAI_NOP;
            ip_dt_src.Columns[(int)e_col_thu_tu_bang_luong.THUC_LINH].ColumnName = RPT_LUONG_V2.THUC_LINH;
        }
        private void load_data_excel_to_grid(string ip_path_excel)
        {
            if(ip_path_excel == "")
            {
                return;
            }
            try
            {
                var v_dlg_confirm = XtraMessageBox.Show("Bạn có chắc chắn muốn import dữ liệu từ file Excel lương?"
                                                            , "XÁC NHẬN"
                                                            , MessageBoxButtons.YesNo
                                                            , MessageBoxIcon.Question);
                if(v_dlg_confirm == System.Windows.Forms.DialogResult.No)
                {
                    XtraMessageBox.Show("Bạn đã hủy thao tác!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                SplashScreenManager.ShowForm(typeof(F_wait_form));
                m_grc_main.DataSource = null;
                m_lst_luong_v2 = new BindingList<DTO_BANG_LUONG_V2>();
                DataTable v_dt_src = new DataTable();
                WinFormControls.load_xls_to_data_table(ip_path_excel, ref v_dt_src);
                format_table_source_after_import(v_dt_src);
                load_data_2_list_bang_luong(v_dt_src);
                m_grc_main.Visible = true;
                m_grc_main.DataSource = m_lst_luong_v2;
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                SplashScreenManager.CloseForm();
            }
        }

        private void load_data_2_list_bang_luong(DataTable ip_dt_src)
        {
            var v_dc_row_count = ip_dt_src.Rows.Count;
            for(int i = 0; i < v_dc_row_count; i++)
            {
                var v_dr_grid = ip_dt_src.Rows[i];
                try
                {
                    DTO_BANG_LUONG_V2 v_dto_luong = TinhLuongQL.Instance.transfer_data_row_excel_luong_2_object(v_dr_grid, lay_thang(), lay_nam());
                    m_lst_luong_v2.Add(v_dto_luong);
                }
                catch(Exception)
                {
                    if(v_dr_grid[RPT_LUONG_V2.MA_NV] != DBNull.Value)
                    {
                        var v_str_msg = "Dữ liệu lương của nhân viên " + v_dr_grid[RPT_LUONG_V2.MA_NV].ToString() + " bị sai hoặc bị rỗng. Bạn xem lại nhé!";
                        throw new Exception(v_str_msg);
                    }
                    else
                    {
                        throw new Exception("Có mã nhân viên hoặc dữ liệu nào đó bị rỗng, bạn xem lại nhé!");
                    }
                }
            }
        }
        private void xuat_excel_bang_luong()
        {
            string v_str_file_name = "SOAN_THAO_BL" + lay_thang() + lay_nam() + "_Bang luong dang soan thao thang " + lay_thang() + "-" + lay_nam() + CHRMCommon.gen_version();
            CHRMCommon.ExportExcelWithFileName(m_grv_main, v_str_file_name);
        }
        #endregion

    }
}
