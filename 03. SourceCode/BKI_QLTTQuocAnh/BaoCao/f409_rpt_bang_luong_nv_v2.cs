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
            m_cmd_chot_bang_luong.Click += m_cmd_chot_bang_luong_Click;
            m_cmd_import_excel.Click += m_cmd_import_excel_Click;
            m_cmd_export_excel.Click += m_cmd_export_excel_Click;
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
                if(kiem_tra_bang_luong_da_chot_chua())
                {
                    XtraMessageBox.Show("Bảng lương đã được chốt rồi, không tính lại được!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    worker.CancelAsync();
                    e.Cancel = true;
                    return;
                }
                
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
        private void m_cmd_chot_bang_luong_Click(object sender, EventArgs e)
        {
            try
            {
                chot_bang_luong();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
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
        private void m_cmd_tinh_lai_cho_nhan_vien_Click(object sender, EventArgs e)
        {
            try
            {
                //if(m_grv_main.FocusedRowHandle < 0)
                //{
                //    XtraMessageBox.Show("Chọn nhân viên trước để tính lại lương!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    return;
                //}
                //decimal v_id_nhan_vien = Convert.ToDecimal(m_grv_main.GetRowCellValue(m_grv_main.FocusedRowHandle, "ID_NHAN_VIEN"));

                //DataRow v_dr_luong = CHRMCommon.get_luong_1_nhan_vien_v2(v_id_nhan_vien, int.Parse(m_txt_thang.Text.Trim()), int.Parse(m_txt_nam.Text.Trim()));

                //var v_dr_luong_nv = m_ds_RPT_LUONG_V2.Tables[0].NewRow();
                //DataRow v_dr_luong_1_nv = CHRMCommon.get_dr_v2(v_dr_luong_nv, v_dr_luong, v_id_nhan_vien, 0, int.Parse(m_txt_thang.Text.Trim()), int.Parse(m_txt_nam.Text.Trim()));

                ////Xoa ban ghi truoc khi insert lai
                //US_RPT_LUONG_V2 v_us_2_del = new US_RPT_LUONG_V2();
                //v_us_2_del.XoaBanGhiLuong(v_id_nhan_vien, Convert.ToDecimal(m_txt_thang.EditValue), Convert.ToDecimal(m_txt_nam.EditValue));
                //CHRMCommon.insertLuongNV2RPT_V2(v_dr_luong_1_nv);
                //load_data_2_grid();
                //XtraMessageBox.Show("Cập nhật thành công");
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
            LUONG_NS = 1,
            LUONG_CHE_DO = 2,
            AN_CA = 3,
            PHU_CAP_TN = 4,
            LAM_THEM_150 = 5,
            THU_NHAP_KHAC_TRONG_LUONG = 6,
            TONG_THU_NHAP_TRONG_LUONG = 7,
            THUONG = 8,
            THUONG_ATHK = 9,
            THUONG_LE_TET = 10,
            BO_SUNG_LUONG = 11,
            THU_NHAP_KHAC_NGOAI_LUONG = 12,
            TONG_THU_NHAP_NGOAI_LUONG = 13,
            TONG_THU_NHAP = 14,
            GIAM_TRU_AN_CA = 15,
            GIAM_TRU_BHXH = 16,
            GIAM_TRU_BHYT = 17,
            GIAM_TRU_BHTN = 18,
            GIAM_TRU_LAM_THEM = 19,
            GIAM_TRU_GIA_CANH = 20,
            GIAM_TRU_PHU_THUOC = 21,
            GIAM_TRU_KHAC = 22,
            TONG_GIAM_TRU = 23,
            THU_NHAP_TINH_THUE = 24,
            PHAI_THU_BHXH = 25,
            PHAI_THU_BHYT = 26,
            PHAI_THU_BHTN = 27,
            DOAN_PHI = 28,
            THUE_TNCN = 29,
            PHAI_THU_KHAC = 30,
            TONG_PHAI_NOP = 31, 
            THUC_LINH = 32
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
            m_txt_nam.EditValue = DateTime.Now.Year;
            m_txt_thang.EditValue = DateTime.Now.Month;
            m_txt_thang.Focus();
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
        private DTO_THONG_TIN_BANG_LUONG lay_thong_tin_bang_luong()
        {
            DTO_THONG_TIN_BANG_LUONG v_dto_thong_tin_bang_luong = new DTO_THONG_TIN_BANG_LUONG(lay_thang(), lay_nam());
            return v_dto_thong_tin_bang_luong;
        }

        //Display data
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
            var v_dto_thong_tin_bang_luong = lay_thong_tin_bang_luong();

            if(v_dto_thong_tin_bang_luong.SO_LUONG_NHAN_VIEN_CAN_TINH == v_dto_thong_tin_bang_luong.SO_LUONG_NHAN_VIEN_DA_TINH)
            {
                m_lbl_thong_bao.Text = "Đã tính xong lương cho";
                m_lbl_thong_bao.ForeColor = Color.Green;
                m_lbl_so_luong_nv_tinh_luong.ForeColor = Color.Green;
            }
            if(v_dto_thong_tin_bang_luong.SO_LUONG_NHAN_VIEN_CAN_TINH > v_dto_thong_tin_bang_luong.SO_LUONG_NHAN_VIEN_DA_TINH)
            {
                m_lbl_thong_bao.Text = "Đã tính được lương cho";
                m_lbl_thong_bao.ForeColor = Color.Red;
                m_lbl_so_luong_nv_tinh_luong.ForeColor = Color.Red;
            }
            m_lbl_so_luong_nv_tinh_luong.Text = v_dto_thong_tin_bang_luong.SO_LUONG_NHAN_VIEN_DA_TINH.ToString() + "/"
                                                    + v_dto_thong_tin_bang_luong.SO_LUONG_NHAN_VIEN_CAN_TINH.ToString() + " (nhân viên)";
        }

        //Check data
        private bool kiem_tra_bang_luong_da_chot_chua()
        {
            US_DUNG_CHUNG v_us_dung_chung = new US_DUNG_CHUNG();
            return v_us_dung_chung.IsDaChotBangLuongThang(
                                    CIPConvert.ToDecimal(m_txt_thang.EditValue)
                                    , CIPConvert.ToDecimal(m_txt_nam.EditValue));
        }
        private bool kiem_tra_da_tinh_het_luong_nhan_vien_chua()
        {
            var v_dto_thong_tin_bang_luong = lay_thong_tin_bang_luong();
            decimal v_dc_sl_nv_can_tinh = v_dto_thong_tin_bang_luong.SO_LUONG_NHAN_VIEN_CAN_TINH;
            decimal v_dc_sl_nv_da_tinh = v_dto_thong_tin_bang_luong.SO_LUONG_NHAN_VIEN_DA_TINH;
            if(v_dc_sl_nv_can_tinh <= v_dc_sl_nv_da_tinh)
            {
                return true;
            }
            return false;
        }
        private bool kiem_tra_tinh_hop_le_du_lieu_tren_giao_dien()
        {
            if(m_txt_thang.EditValue == null || m_txt_nam.EditValue == null)
            {
                XtraMessageBox.Show("Bạn nhập tháng & năm trước!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        //Action
        private void xoa_bang_luong_thang()
        {
            //B1: Xoa het bang luong thang do
            US_RPT_LUONG_V2 v_us_RPT_LUONG_V2_V2 = new US_RPT_LUONG_V2();
            v_us_RPT_LUONG_V2_V2.XoaLuong(Convert.ToDecimal(m_txt_thang.EditValue), Convert.ToDecimal(m_txt_nam.EditValue));
        }
        private void chot_bang_luong_thang()
        {
            US_GD_CHOT_BANG_LUONG v_us_gd_chot_bang_luong = new US_GD_CHOT_BANG_LUONG();
            v_us_gd_chot_bang_luong.dcTHANG = lay_thang();
            v_us_gd_chot_bang_luong.dcNAM = lay_nam();
            v_us_gd_chot_bang_luong.strNGUOI_CHOT = CAppContext_201.getCurrentUserName();
            v_us_gd_chot_bang_luong.datNGAY_CHOT = DateTime.Now.Date;
            v_us_gd_chot_bang_luong.Insert();
        }
        private void chot_he_so_bsl_athk_thang()
        {
            US_DUNG_CHUNG v_us_dung_chung = new US_DUNG_CHUNG();
            DataSet v_ds_danh_sach_nv_can_insert = new DataSet();
            v_ds_danh_sach_nv_can_insert.Tables.Add(new DataTable());
            v_us_dung_chung.FillDatasetNhanVienCanInsertHeSo(v_ds_danh_sach_nv_can_insert, lay_thang(), lay_nam());

            decimal v_dc_so_luong_nhan_vien = v_ds_danh_sach_nv_can_insert.Tables[0].Rows.Count;
            for(int i = 0; i < v_dc_so_luong_nhan_vien; i++)
            {
                decimal v_id_nv = CIPConvert.ToDecimal(v_ds_danh_sach_nv_can_insert.Tables[0].Rows[i]["ID_NHAN_VIEN"].ToString());
                US_GD_HS_BO_SUNG_AN_TOAN_HANG_KHONG v_us = new US_GD_HS_BO_SUNG_AN_TOAN_HANG_KHONG();
                v_us.insert_data_by_proc(v_id_nv, lay_thang(), lay_nam());
            }
        }
        private void update_us_luong_v2_by_datarow_in_grid(ref US_RPT_LUONG_V2 ip_us_luong_v2, DataRow ip_dr_grid)
        {
            //Information (khong can thiet)
            //ip_us_luong_v2.strMA_NV=;
            //ip_us_luong_v2.dcTHANG=;
            //ip_us_luong_v2.dcNAM=;
            //ip_us_luong_v2.dcID=;
            //ip_us_luong_v2.dcID_NHAN_VIEN=;


            //Tong thu nhap trong luong
            ip_us_luong_v2.dcLUONG_CD = Convert.ToDecimal(ip_dr_grid[RPT_LUONG_V2.LUONG_CD]);
            ip_us_luong_v2.dcLUONG_NS = Convert.ToDecimal(ip_dr_grid[RPT_LUONG_V2.LUONG_NS]);
            ip_us_luong_v2.dcPHU_CAP_TN = Convert.ToDecimal(ip_dr_grid[RPT_LUONG_V2.PHU_CAP_TN]);
            ip_us_luong_v2.dcAN_CA = Convert.ToDecimal(ip_dr_grid[RPT_LUONG_V2.AN_CA]);
            ip_us_luong_v2.dcLAM_THEM = Convert.ToDecimal(ip_dr_grid[RPT_LUONG_V2.LAM_THEM]);
            ip_us_luong_v2.dcLAM_THEM_200 = Convert.ToDecimal(ip_dr_grid[RPT_LUONG_V2.LAM_THEM_200]);
            ip_us_luong_v2.dcLAM_THEM_300 = Convert.ToDecimal(ip_dr_grid[RPT_LUONG_V2.LAM_THEM_300]);
            ip_us_luong_v2.dcTHU_NHAP_KHAC_TRONG_LUONG = Convert.ToDecimal(ip_dr_grid[RPT_LUONG_V2.THU_NHAP_KHAC_TRONG_LUONG]);
            ip_us_luong_v2.dcTONG_THU_NHAP_TRONG_LUONG = ip_us_luong_v2.dcLUONG_CD + ip_us_luong_v2.dcLUONG_NS
                                                                    + ip_us_luong_v2.dcPHU_CAP_TN + ip_us_luong_v2.dcAN_CA +
                                                                        +ip_us_luong_v2.dcLAM_THEM + ip_us_luong_v2.dcLAM_THEM_200
                                                                        + ip_us_luong_v2.dcLAM_THEM_300 + ip_us_luong_v2.dcTHU_NHAP_KHAC_TRONG_LUONG;

            //Tong thu nhap ngoai luong chua tinh thue
            ip_us_luong_v2.dcTHUONG = Convert.ToDecimal(ip_dr_grid[RPT_LUONG_V2.THUONG]);
            ip_us_luong_v2.dcTHUONG_ATHK = Convert.ToDecimal(ip_dr_grid[RPT_LUONG_V2.THUONG_ATHK]);
            ip_us_luong_v2.dcTHUONG_LE_TET = Convert.ToDecimal(ip_dr_grid[RPT_LUONG_V2.THUONG_LE_TET]);
            ip_us_luong_v2.dcBO_SUNG_LUONG = Convert.ToDecimal(ip_dr_grid[RPT_LUONG_V2.BO_SUNG_LUONG]);
            ip_us_luong_v2.dcTHU_NHAP_KHAC_NGOAI_LUONG = Convert.ToDecimal(ip_dr_grid[RPT_LUONG_V2.TONG_THU_NHAP_NGOAI_LUONG]);
            ip_us_luong_v2.dcTONG_THU_NHAP_NGOAI_LUONG = ip_us_luong_v2.dcTHUONG + ip_us_luong_v2.dcTHUONG_ATHK +
                                                        +ip_us_luong_v2.dcTHUONG_LE_TET + ip_us_luong_v2.dcBO_SUNG_LUONG +
                                                        +ip_us_luong_v2.dcTHU_NHAP_KHAC_NGOAI_LUONG;

            //Tong thu nhap chua tinh thue
            ip_us_luong_v2.dcTONG_THU_NHAP = ip_us_luong_v2.dcTONG_THU_NHAP_TRONG_LUONG + ip_us_luong_v2.dcTONG_THU_NHAP_NGOAI_LUONG;

            //Tong giam tru thue
            ip_us_luong_v2.dcBHTN = Convert.ToDecimal(ip_dr_grid[RPT_LUONG_V2.BHTN]);
            ip_us_luong_v2.dcBHXH = Convert.ToDecimal(ip_dr_grid[RPT_LUONG_V2.BHXH]);
            ip_us_luong_v2.dcBHYT = Convert.ToDecimal(ip_dr_grid[RPT_LUONG_V2.BHYT]);
            ip_us_luong_v2.dcGIAM_TRU_GIA_CANH = Convert.ToDecimal(ip_dr_grid[RPT_LUONG_V2.GIAM_TRU_GIA_CANH]);
            ip_us_luong_v2.dcGIAM_TRU_PHU_THUOC = Convert.ToDecimal(ip_dr_grid[RPT_LUONG_V2.GIAM_TRU_PHU_THUOC]);
            ip_us_luong_v2.dcGIAM_TRU_LAM_THEM_150 = Convert.ToDecimal(ip_dr_grid[RPT_LUONG_V2.GIAM_TRU_LAM_THEM_150]);
            ip_us_luong_v2.dcGIAM_TRU_LAM_THEM_200 = Convert.ToDecimal(ip_dr_grid[RPT_LUONG_V2.GIAM_TRU_LAM_THEM_200]);
            ip_us_luong_v2.dcGIAM_TRU_LAM_THEM_300 = Convert.ToDecimal(ip_dr_grid[RPT_LUONG_V2.GIAM_TRU_LAM_THEM_300]);
            ip_us_luong_v2.dcGIAM_TRU_KHAC = Convert.ToDecimal(ip_dr_grid[RPT_LUONG_V2.GIAM_TRU_KHAC]);
            ip_us_luong_v2.dcTONG_GIAM_TRU = ip_us_luong_v2.dcBHTN + ip_us_luong_v2.dcBHXH + ip_us_luong_v2.dcBHYT +
                                                +ip_us_luong_v2.dcGIAM_TRU_GIA_CANH + ip_us_luong_v2.dcGIAM_TRU_PHU_THUOC +
                                                +ip_us_luong_v2.dcGIAM_TRU_LAM_THEM_150 + ip_us_luong_v2.dcGIAM_TRU_LAM_THEM_200 + ip_us_luong_v2.dcGIAM_TRU_LAM_THEM_300 +
                                                +ip_us_luong_v2.dcGIAM_TRU_KHAC
                                                + ip_us_luong_v2.dcAN_CA;
            //Thu nhap chiu thue
            ip_us_luong_v2.dcTHU_NHAP_CHIU_THUE = ip_us_luong_v2.dcTONG_THU_NHAP - ip_us_luong_v2.dcTONG_GIAM_TRU;
            //Tong phai thu
            ip_us_luong_v2.dcDOAN_PHI_CD = Convert.ToDecimal(ip_dr_grid[RPT_LUONG_V2.DOAN_PHI_CD]);
            ip_us_luong_v2.dcPHAI_NOP_KHAC = Convert.ToDecimal(ip_dr_grid[RPT_LUONG_V2.PHAI_NOP_KHAC]); ;
            ip_us_luong_v2.dcTHUE = Convert.ToDecimal(ip_dr_grid[RPT_LUONG_V2.THUE]);

            ip_us_luong_v2.dcTONG_PHAI_NOP = ip_us_luong_v2.dcDOAN_PHI_CD + ip_us_luong_v2.dcPHAI_NOP_KHAC + ip_us_luong_v2.dcTHUE
                                                + ip_us_luong_v2.dcBHXH + ip_us_luong_v2.dcBHYT + ip_us_luong_v2.dcBHTN;

            //Thuc linh
            ip_us_luong_v2.dcTHUC_LINH = ip_us_luong_v2.dcTONG_THU_NHAP_TRONG_LUONG - ip_us_luong_v2.dcTONG_PHAI_NOP;
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
            var v_ds_danh_sach_nhan_vien = lay_danh_sach_nhan_vien_can_tinh_luong(v_dlg_confirm);
            tinh_bang_luong_tu_dong(v_ds_danh_sach_nhan_vien);
        }
        private ENUM_CONFIRM_TINH_BANG_LUONG confirm_cach_tinh_bang_luong_tu_nguoi_dung()
        {
            msg001_confirm_tinh_bang_luong v_msg_confirm = new msg001_confirm_tinh_bang_luong();
            ENUM_CONFIRM_TINH_BANG_LUONG v_dlg_confirm;
            var v_dto_thong_tin_bang_luong = lay_thong_tin_bang_luong();

            if(v_dto_thong_tin_bang_luong.CHOT_BANG_LUONG)
            {
                XtraMessageBox.Show("Bạn không thể tính toán lương nhân viên khi bảng lương đã được chốt!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                v_dlg_confirm = ENUM_CONFIRM_TINH_BANG_LUONG.NONE;
            }
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
        private DataSet lay_danh_sach_nhan_vien_can_tinh_luong(ENUM_CONFIRM_TINH_BANG_LUONG ip_confirm_cach_tinh)
        {
            US_RPT_LUONG_V2 v_us_rpt_luong = new US_RPT_LUONG_V2();
            DataSet v_ds_danh_sach_nhan_vien;
            if(ip_confirm_cach_tinh == ENUM_CONFIRM_TINH_BANG_LUONG.TINH_NHAN_VIEN_CHUA_CO)
            {
                v_us_rpt_luong.lay_danh_sach_nhan_vien_can_tinh_luong_con_lai_trong_thang(
                                 out v_ds_danh_sach_nhan_vien
                                 , CIPConvert.ToDecimal(m_txt_thang.EditValue)
                                 , CIPConvert.ToDecimal(m_txt_nam.EditValue));
            }
            else if(ip_confirm_cach_tinh == ENUM_CONFIRM_TINH_BANG_LUONG.TINH_LAI_TOAN_BO)
            {
                v_us_rpt_luong.lay_danh_sach_nhan_vien_can_tinh_luong_trong_thang(
                                 out v_ds_danh_sach_nhan_vien
                                 , CIPConvert.ToDecimal(m_txt_thang.EditValue)
                                 , CIPConvert.ToDecimal(m_txt_nam.EditValue));
            }
            else
            {
                v_ds_danh_sach_nhan_vien = new DS_RPT_LUONG_V2();
            }
            return v_ds_danh_sach_nhan_vien;
        }
        private void tinh_bang_luong_tu_dong(DataSet ip_ds_danh_sach_nv)
        {

            int v_i_so_luong_nv = ip_ds_danh_sach_nv.Tables[0].Rows.Count;
            for(int i = 0; i < v_i_so_luong_nv; i++)
            {
                DataRow v_dr_nv = ip_ds_danh_sach_nv.Tables[0].Rows[i];
                decimal v_dc_id_nhan_vien = Convert.ToDecimal(v_dr_nv[0]);

                DataRow v_dr_luong_nv = CHRMCommon.get_luong_1_nhan_vien_v2(v_dc_id_nhan_vien, (int)lay_thang(), (int)lay_nam());
                DTO_BANG_LUONG_V2 v_dto_luong = transfer_data_row_db_luong_2_object(v_dr_luong_nv);
                m_lst_luong_v2.Add(v_dto_luong);
                m_bgwk.ReportProgress((i + 1) * 100 / ip_ds_danh_sach_nv.Tables[0].Rows.Count);
            }
        }
        private DTO_BANG_LUONG_V2 transfer_data_row_db_luong_2_object(DataRow ip_dr_luong)
        {
            DTO_BANG_LUONG_V2 v_dto_luong = new DTO_BANG_LUONG_V2();
            v_dto_luong.ID_NHAN_VIEN = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.ID_NHAN_VIEN]);
            v_dto_luong.THANG = lay_thang();
            v_dto_luong.NAM = lay_nam();

            v_dto_luong.MA_NV = ip_dr_luong[RPT_LUONG_V2.MA_NV].ToString();

            v_dto_luong.LUONG_NS = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.LUONG_NS]);
            v_dto_luong.LUONG_CD = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.LUONG_CD]);
            v_dto_luong.PHU_CAP_TN = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.PHU_CAP_TN]);
            v_dto_luong.AN_CA = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.AN_CA]);
            v_dto_luong.LAM_THEM = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.LAM_THEM]);
            v_dto_luong.LAM_THEM_200 = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.LAM_THEM_200]);
            v_dto_luong.LAM_THEM_300 = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.LAM_THEM_300]);
            v_dto_luong.THU_NHAP_KHAC_TRONG_LUONG = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.THU_NHAP_KHAC_TRONG_LUONG]);
            v_dto_luong.TONG_THU_NHAP_TRONG_LUONG = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.TONG_THU_NHAP_TRONG_LUONG]);

            v_dto_luong.THUONG = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.THUONG]);
            v_dto_luong.THUONG_ATHK = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.THUONG_ATHK]);
            v_dto_luong.BO_SUNG_LUONG = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.BO_SUNG_LUONG]);
            v_dto_luong.THUONG_LE_TET = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.THUONG_LE_TET]);
            v_dto_luong.THU_NHAP_KHAC_NGOAI_LUONG = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.THU_NHAP_KHAC_NGOAI_LUONG]);
            v_dto_luong.TONG_THU_NHAP_NGOAI_LUONG = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.TONG_THU_NHAP_NGOAI_LUONG]);
            v_dto_luong.TONG_THU_NHAP = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.TONG_THU_NHAP]);

            v_dto_luong.BHXH = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.BHXH]);
            v_dto_luong.BHYT = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.BHYT]);
            v_dto_luong.BHTN = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.BHTN]);
            v_dto_luong.GIAM_TRU_LAM_THEM_150 = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.GIAM_TRU_LAM_THEM_150]);
            v_dto_luong.GIAM_TRU_LAM_THEM_200 = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.GIAM_TRU_LAM_THEM_200]);
            v_dto_luong.GIAM_TRU_LAM_THEM_300 = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.GIAM_TRU_LAM_THEM_300]);
            v_dto_luong.GIAM_TRU_GIA_CANH = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.GIAM_TRU_GIA_CANH]);
            v_dto_luong.GIAM_TRU_PHU_THUOC = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.GIAM_TRU_PHU_THUOC]);
            v_dto_luong.GIAM_TRU_KHAC = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.GIAM_TRU_KHAC]);
            v_dto_luong.TONG_GIAM_TRU = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.TONG_GIAM_TRU]);

            v_dto_luong.THU_NHAP_CHIU_THUE = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.THU_NHAP_CHIU_THUE]);

            v_dto_luong.DOAN_PHI_CD = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.DOAN_PHI_CD]);
            v_dto_luong.THUE = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.THUE]);
            v_dto_luong.PHAI_NOP_KHAC = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.PHAI_NOP_KHAC]);
            v_dto_luong.TONG_PHAI_NOP = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.TONG_PHAI_NOP]);

            v_dto_luong.THUC_LINH = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.THUC_LINH]);

            return v_dto_luong;
        }
        private US_RPT_LUONG_V2 transfer_dto_2_us_object(DTO_BANG_LUONG_V2 ip_dto_luong)
        {
            US_RPT_LUONG_V2 v_us_luong_v2 = new US_RPT_LUONG_V2();

            v_us_luong_v2.dcID_NHAN_VIEN = ExecuteFuntion.LayNhanVienID(ip_dto_luong.MA_NV); 
            v_us_luong_v2.dcTHANG = ip_dto_luong.THANG;
            v_us_luong_v2.dcNAM = ip_dto_luong.NAM;

            v_us_luong_v2.strMA_NV = ip_dto_luong.MA_NV;

            v_us_luong_v2.dcLUONG_NS = ip_dto_luong.LUONG_NS;
            v_us_luong_v2.dcLUONG_CD = ip_dto_luong.LUONG_CD;
            v_us_luong_v2.dcPHU_CAP_TN = ip_dto_luong.PHU_CAP_TN;
            v_us_luong_v2.dcAN_CA = ip_dto_luong.AN_CA;
            v_us_luong_v2.dcLAM_THEM = ip_dto_luong.LAM_THEM;
            v_us_luong_v2.dcGIAM_TRU_LAM_THEM_200 = ip_dto_luong.LAM_THEM_200;
            v_us_luong_v2.dcGIAM_TRU_LAM_THEM_300 = ip_dto_luong.LAM_THEM_300;
            v_us_luong_v2.dcTHU_NHAP_KHAC_TRONG_LUONG = ip_dto_luong.THU_NHAP_KHAC_TRONG_LUONG;
            v_us_luong_v2.dcTONG_THU_NHAP_TRONG_LUONG = ip_dto_luong.TONG_THU_NHAP_TRONG_LUONG;

            v_us_luong_v2.dcTHUONG = ip_dto_luong.THUONG;
            v_us_luong_v2.dcTHUONG_ATHK = ip_dto_luong.THUONG_ATHK;
            v_us_luong_v2.dcBO_SUNG_LUONG = ip_dto_luong.BO_SUNG_LUONG;
            v_us_luong_v2.dcTHUONG_LE_TET = ip_dto_luong.THUONG_LE_TET;
            v_us_luong_v2.dcTHU_NHAP_KHAC_NGOAI_LUONG = ip_dto_luong.THU_NHAP_KHAC_NGOAI_LUONG;
            v_us_luong_v2.dcTONG_THU_NHAP_NGOAI_LUONG = ip_dto_luong.TONG_THU_NHAP_NGOAI_LUONG;
            v_us_luong_v2.dcTONG_THU_NHAP = ip_dto_luong.TONG_THU_NHAP;

            v_us_luong_v2.dcBHXH = ip_dto_luong.BHXH;
            v_us_luong_v2.dcBHYT = ip_dto_luong.BHYT;
            v_us_luong_v2.dcBHTN = ip_dto_luong.BHTN;
            v_us_luong_v2.dcGIAM_TRU_LAM_THEM_150 = ip_dto_luong.GIAM_TRU_LAM_THEM_150;
            v_us_luong_v2.dcGIAM_TRU_LAM_THEM_200 = ip_dto_luong.GIAM_TRU_LAM_THEM_200;
            v_us_luong_v2.dcGIAM_TRU_LAM_THEM_300 = ip_dto_luong.GIAM_TRU_LAM_THEM_300;
            v_us_luong_v2.dcGIAM_TRU_GIA_CANH = ip_dto_luong.GIAM_TRU_GIA_CANH;
            v_us_luong_v2.dcGIAM_TRU_PHU_THUOC = ip_dto_luong.GIAM_TRU_PHU_THUOC;
            v_us_luong_v2.dcGIAM_TRU_KHAC = ip_dto_luong.GIAM_TRU_KHAC;
            v_us_luong_v2.dcTONG_GIAM_TRU = ip_dto_luong.TONG_GIAM_TRU;

            v_us_luong_v2.dcTHU_NHAP_CHIU_THUE = ip_dto_luong.THU_NHAP_CHIU_THUE;

            v_us_luong_v2.dcDOAN_PHI_CD = ip_dto_luong.DOAN_PHI_CD;
            v_us_luong_v2.dcTHUE = ip_dto_luong.THUE;
            v_us_luong_v2.dcPHAI_NOP_KHAC = ip_dto_luong.PHAI_NOP_KHAC;
            v_us_luong_v2.dcTONG_PHAI_NOP = ip_dto_luong.TONG_PHAI_NOP;

            v_us_luong_v2.dcTHUC_LINH = ip_dto_luong.THUC_LINH;

            return v_us_luong_v2;
        }
        private void chot_bang_luong()
        {
            DialogResult v_dlg_confirm;
            string v_str_text_confirm;

            if(!kiem_tra_da_tinh_het_luong_nhan_vien_chua())
            {

                v_str_text_confirm = "Chưa tính toán xong dữ liệu nhân viên. Bạn có chắc chắn muốn chốt bảng lương tháng ?" + lay_thang() + " năm " + lay_nam();
            }
            else
            {
                v_str_text_confirm = "Bạn có chắc chắn muốn chốt bảng lương tháng ?" + lay_thang() + " năm " + lay_nam();
            }
            v_dlg_confirm = XtraMessageBox.Show(v_str_text_confirm
                                                            , "XÁC NHẬN"
                                                            , MessageBoxButtons.YesNo
                                                            , MessageBoxIcon.Question);
            if(v_dlg_confirm == System.Windows.Forms.DialogResult.No)
            {
                XtraMessageBox.Show("Bạn đã hủy thao tác!", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                return;
            }
            if(kiem_tra_bang_luong_da_chot_chua())
            {
                XtraMessageBox.Show("Bảng lương tháng đã được chốt rồi!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            chot_bang_luong_thang();
            chot_he_so_bsl_athk_thang();
        }

        //Process luu bang luong
        private void start_luu_bang_luong_process()
        {
            if(m_bgwk.IsBusy)
            {
                XtraMessageBox.Show("Chức năng đang thực hiện tính toán dữ liệu lương rồi, bạn đợi chút", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var v_dto_thong_tin_bang_luong = lay_thong_tin_bang_luong();
            msg002_confirm_luu_du_lieu_bang_luong v_msg_confirm;
            ENUM_CONFIRM_LUU_BANG_LUONG v_dlg_confirm_save;

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
                splashScreenManager.ShowWaitForm();
                save_data(v_dlg_confirm_save);
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                splashScreenManager.CloseWaitForm();
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
                var v_str_ma_nv = m_grv_main.GetRowCellValue(v_i_row,RPT_LUONG.MA_NV).ToString();
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
            if(!kiem_tra_du_lieu_nhan_vien_truoc_khi_luu())
            {
                var v_dc_so_nv_khong_co_trong_csdl = m_lst_nhan_vien_khong_ton_tai.Count;
                XtraMessageBox.Show("Có " + v_dc_so_nv_khong_co_trong_csdl + " mã nhân viên không có trong phần mềm. Bạn lưu danh sách vào nhé!");
                xuat_excel_nhan_vien_chua_co_trong_csdl();
                return;
            }
            US_RPT_LUONG_V2 v_us_rpt_luong_v2 = new US_RPT_LUONG_V2();
            DTO_BANG_LUONG_V2 v_dto_bang_luong_v2 = new DTO_BANG_LUONG_V2();

            var v_i_row_count = m_grv_main.RowCount;
            if(ip_confirm_save == ENUM_CONFIRM_LUU_BANG_LUONG.NONE)
            {
                XtraMessageBox.Show("Bảng lương chưa được lưu!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(ip_confirm_save == ENUM_CONFIRM_LUU_BANG_LUONG.TINH_LAI_TOAN_BO)
            {
                xoa_bang_luong_thang();
            }

            for(int v_i_row = 0; v_i_row < v_i_row_count; v_i_row++)
            {
                if(v_i_row == v_i_row_count) MessageBox.Show(v_i_row.ToString());
                v_dto_bang_luong_v2 = (DTO_BANG_LUONG_V2)m_grv_main.GetRow(v_i_row);
                v_us_rpt_luong_v2 = transfer_dto_2_us_object(v_dto_bang_luong_v2);

                var v_bol_nv_co_trong_bang_luong_chua = ExecuteFuntion.KiemTraNhanVienCoTrongBangLuongChua(v_us_rpt_luong_v2.dcID_NHAN_VIEN, lay_thang(), lay_nam());
                switch(ip_confirm_save)
                {
                    case ENUM_CONFIRM_LUU_BANG_LUONG.TINH_LAI_TOAN_BO:
                        v_us_rpt_luong_v2.Insert();
                        break;
                    case ENUM_CONFIRM_LUU_BANG_LUONG.CHUA_CO_THI_GHI_MOI_DA_CO_THI_KHONG_LAM_GI:
                        if(!v_bol_nv_co_trong_bang_luong_chua)
                        {
                            v_us_rpt_luong_v2.Insert();
                        }
                        break;
                    case ENUM_CONFIRM_LUU_BANG_LUONG.CHUA_CO_THI_GHI_MOI_DA_CO_THI_GHI_DE:
                        if(!v_bol_nv_co_trong_bang_luong_chua)
                        {
                            v_us_rpt_luong_v2.Insert();
                        }
                        else
                        {
                            v_us_rpt_luong_v2.XoaBanGhiLuong(v_us_rpt_luong_v2.dcID_NHAN_VIEN, lay_thang(), lay_nam());
                            v_us_rpt_luong_v2.Insert();
                        }
                        break;
                    case ENUM_CONFIRM_LUU_BANG_LUONG.CHUA_CO_THI_KHONG_LAM_GI_DA_CO_THI_GHI_DE:
                        if(v_bol_nv_co_trong_bang_luong_chua)
                        {
                            v_us_rpt_luong_v2.XoaBanGhiLuong(v_us_rpt_luong_v2.dcID_NHAN_VIEN, lay_thang(), lay_nam());
                            v_us_rpt_luong_v2.Insert();
                        }
                        break;
                    default:
                        throw new Exception("Chưa gán giá trị cho ENUM_CONFIRM_LUU_BANG_LUONG!");
                }
                
            }
            XtraMessageBox.Show("Lưu dữ liệu thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            ip_dt_src.Columns[(int)e_col_thu_tu_bang_luong.GIAM_TRU_BHXH].ColumnName = RPT_LUONG_V2.BHXH;
            ip_dt_src.Columns[(int)e_col_thu_tu_bang_luong.GIAM_TRU_BHYT].ColumnName = RPT_LUONG_V2.BHYT;
            ip_dt_src.Columns[(int)e_col_thu_tu_bang_luong.GIAM_TRU_BHTN].ColumnName = RPT_LUONG_V2.BHTN;
            ip_dt_src.Columns[(int)e_col_thu_tu_bang_luong.GIAM_TRU_LAM_THEM].ColumnName = RPT_LUONG_V2.GIAM_TRU_LAM_THEM_150;
            ip_dt_src.Columns[(int)e_col_thu_tu_bang_luong.GIAM_TRU_GIA_CANH].ColumnName = RPT_LUONG_V2.GIAM_TRU_GIA_CANH;
            ip_dt_src.Columns[(int)e_col_thu_tu_bang_luong.GIAM_TRU_PHU_THUOC].ColumnName = RPT_LUONG_V2.GIAM_TRU_PHU_THUOC;
            ip_dt_src.Columns[(int)e_col_thu_tu_bang_luong.GIAM_TRU_KHAC].ColumnName = RPT_LUONG_V2.GIAM_TRU_KHAC;
            ip_dt_src.Columns[(int)e_col_thu_tu_bang_luong.TONG_GIAM_TRU].ColumnName = RPT_LUONG_V2.TONG_GIAM_TRU;
            ip_dt_src.Columns[(int)e_col_thu_tu_bang_luong.THU_NHAP_TINH_THUE].ColumnName = RPT_LUONG_V2.THU_NHAP_CHIU_THUE;
            //ip_dt_src.Columns[(int)e_col_thu_tu_bang_luong.PHAI_THU_BHYT].ColumnName = RPT_LUONG_V2.BHYT;
            //ip_dt_src.Columns[(int)e_col_thu_tu_bang_luong.PHAI_THU_BHXH].ColumnName = RPT_LUONG_V2.BHXH;
            //ip_dt_src.Columns[(int)e_col_thu_tu_bang_luong.PHAI_THU_BHTN].ColumnName = RPT_LUONG_V2.BHTN;
            ip_dt_src.Columns[(int)e_col_thu_tu_bang_luong.DOAN_PHI].ColumnName = RPT_LUONG_V2.DOAN_PHI_CD;
            ip_dt_src.Columns[(int)e_col_thu_tu_bang_luong.THUE_TNCN].ColumnName = RPT_LUONG_V2.THUE;
            ip_dt_src.Columns[(int)e_col_thu_tu_bang_luong.PHAI_THU_KHAC].ColumnName = RPT_LUONG_V2.PHAI_NOP_KHAC;
            ip_dt_src.Columns[(int)e_col_thu_tu_bang_luong.TONG_PHAI_NOP].ColumnName = RPT_LUONG_V2.TONG_PHAI_NOP;
            ip_dt_src.Columns[(int)e_col_thu_tu_bang_luong.THUC_LINH].ColumnName = RPT_LUONG_V2.THUC_LINH;
        }
        private void load_data_excel_to_grid(string ip_path_excel)
        {
            try
            {
                var v_dlg_confirm = XtraMessageBox.Show("Bạn có chắc chắn muốn import dữ liệu từ file Excel lương?"
                                                            , "XÁC NHẬN"
                                                            , MessageBoxButtons.YesNo
                                                            , MessageBoxIcon.Question);
                if(v_dlg_confirm == System.Windows.Forms.DialogResult.No)
                {
                    XtraMessageBox.Show("Bạn đã hủy thao tác", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private DTO_BANG_LUONG_V2 transfer_data_row_excel_luong_2_object(DataRow ip_dr_luong)
        {
            DTO_BANG_LUONG_V2 v_dto_luong = new DTO_BANG_LUONG_V2();
            v_dto_luong.THANG = lay_thang();
            v_dto_luong.NAM = lay_nam();

            v_dto_luong.MA_NV = ip_dr_luong[RPT_LUONG_V2.MA_NV].ToString();

            v_dto_luong.LUONG_NS = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.LUONG_NS]);
            v_dto_luong.LUONG_CD = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.LUONG_CD]);
            v_dto_luong.PHU_CAP_TN = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.PHU_CAP_TN]);
            v_dto_luong.AN_CA = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.AN_CA]);
            v_dto_luong.LAM_THEM = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.LAM_THEM]);
            v_dto_luong.THU_NHAP_KHAC_TRONG_LUONG = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.THU_NHAP_KHAC_TRONG_LUONG]);
            v_dto_luong.TONG_THU_NHAP_TRONG_LUONG = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.TONG_THU_NHAP_TRONG_LUONG]);

            v_dto_luong.THUONG = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.THUONG]);
            v_dto_luong.THUONG_ATHK = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.THUONG_ATHK]);
            v_dto_luong.BO_SUNG_LUONG = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.BO_SUNG_LUONG]);
            v_dto_luong.THUONG_LE_TET = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.THUONG_LE_TET]);
            v_dto_luong.THU_NHAP_KHAC_NGOAI_LUONG = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.THU_NHAP_KHAC_NGOAI_LUONG]);
            v_dto_luong.TONG_THU_NHAP_NGOAI_LUONG = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.TONG_THU_NHAP_NGOAI_LUONG]);
            v_dto_luong.TONG_THU_NHAP = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.TONG_THU_NHAP]);

            v_dto_luong.BHXH = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.BHXH]);
            v_dto_luong.BHYT = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.BHYT]);
            v_dto_luong.BHTN = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.BHTN]);
            v_dto_luong.GIAM_TRU_LAM_THEM_150 = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.GIAM_TRU_LAM_THEM_150]);
            v_dto_luong.GIAM_TRU_GIA_CANH = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.GIAM_TRU_GIA_CANH]);
            v_dto_luong.GIAM_TRU_PHU_THUOC = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.GIAM_TRU_PHU_THUOC]);
            v_dto_luong.GIAM_TRU_KHAC = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.GIAM_TRU_KHAC]);
            v_dto_luong.TONG_GIAM_TRU = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.TONG_GIAM_TRU]);

            v_dto_luong.THU_NHAP_CHIU_THUE = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.THU_NHAP_CHIU_THUE]);

            v_dto_luong.DOAN_PHI_CD = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.DOAN_PHI_CD]);
            v_dto_luong.THUE = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.THUE]);
            v_dto_luong.PHAI_NOP_KHAC = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.PHAI_NOP_KHAC]);
            v_dto_luong.TONG_PHAI_NOP = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.TONG_PHAI_NOP]);

            v_dto_luong.THUC_LINH = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.THUC_LINH]);

            return v_dto_luong;
        }
        private void load_data_2_list_bang_luong(DataTable ip_dt_src)
        {
            var v_dc_row_count = ip_dt_src.Rows.Count;
            for(int i = 0; i < v_dc_row_count; i++)
            {
                var v_dr_grid = ip_dt_src.Rows[i];
                DTO_BANG_LUONG_V2 v_dto_luong = transfer_data_row_excel_luong_2_object(v_dr_grid);
                m_lst_luong_v2.Add(v_dto_luong);
            }
        }
        private void xuat_excel_bang_luong()
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "xls files (*.xls)|*.xls|All files (*.*)|*.*";
            saveFileDialog1.RestoreDirectory = true;
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                m_grv_main.ExportToXls(saveFileDialog1.FileName);
                DevExpress.XtraEditors.XtraMessageBox.Show("Lưu báo cáo thành công");
            }
        }
        #endregion
    }
}
