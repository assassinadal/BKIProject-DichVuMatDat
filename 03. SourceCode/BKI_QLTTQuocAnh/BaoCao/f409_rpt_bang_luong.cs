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

namespace BKI_DichVuMatDat.BaoCao
{
    public partial class f409_rpt_bang_luong : Form
    {
        //Field & Property
        BindingList<DTO_BANG_LUONG_V2> m_lst_luong_v2 = new BindingList<DTO_BANG_LUONG_V2>();

        #region Public Interface
        public f409_rpt_bang_luong()
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
            //m_cmd_xem_bang_luong.Click += m_cmd_xem_bang_luong_Click;
            //m_cmd_luu_bang_luong.Click += m_cmd_luu_bang_luong_Click;
            //m_cmd_xem_thong_tin_tinh_luong.Click += m_cmd_xem_thong_tin_tinh_luong_Click;
            m_cmd_tinh_bang_luong.Click += m_cmd_tinh_bang_luong_Click;
            m_cmd_xem_thong_tin_tinh_luong.Click += m_cmd_xem_thong_tin_tinh_luong_Click;
            m_cmd_chot_bang_luong.Click += m_cmd_chot_bang_luong_Click;
            m_cmd_luu_du_lieu.Click += m_cmd_luu_du_lieu_Click;
        }

        //Tinh luong
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
            try
            {
                start_tinh_bang_luong_process();
                if(m_bgwk.CancellationPending)
                {
                    e.Cancel = true;
                }
            }
            catch(Exception v_e)
            {
                m_bgwk.CancelAsync();
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_bgwk_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                hide_progress_bar();
                if((e.Cancelled == true))
                {
                    m_prb.Text = "Thao tác bị hoãn!";
                    return;
                }

                else if(!(e.Error == null))
                {
                    m_prb.Text = ("Lỗi: " + e.Error.Message);
                    return;
                }
                else
                {
                    m_prb.Text = "Đã xong!";
                }
                load_data_2_grid();
                hien_thi_thong_tin_qtr_tinh_luong();
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
                this.m_prb.Text = (e.ProgressPercentage.ToString() + "%");
                this.m_prb.EditValue = e.ProgressPercentage;
            }
            catch(Exception)
            {
                throw;
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


        private void m_cmd_xem_thong_tin_tinh_luong_Click(object sender, EventArgs e)
        {
            try
            {
                hien_thi_thong_tin_qtr_tinh_luong();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }




        private void m_cmd_luu_bang_luong_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_tinh_lai_Click(object sender, EventArgs e)
        {
            try
            {
                tinh_lai_bang_luong();
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
                    US_RPT_LUONG_V2 v_us_update = new US_RPT_LUONG_V2(Convert.ToDecimal(v_dr_Focused[RPT_LUONG_V2.ID]));
                    update_us_luong_v2_by_datarow_in_grid(ref v_us_update, v_dr_Focused);
                }
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }


        private void f410_rpt_bang_luong_nv_Load(object sender, EventArgs e)
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
        private void m_lbl_thong_bao_Click(object sender, EventArgs e)
        {

        }

        private void m_lbl_so_luong_nv_tinh_luong_Click(object sender, EventArgs e)
        {

        }

        private void popupGalleryEdit1_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            try
            {
                PopupGalleryEdit v_p = sender as PopupGalleryEdit;
                switch(e.CloseMode)
                {
                    case PopupCloseMode.ButtonClick:
                        break;
                    case PopupCloseMode.Cancel:
                        break;
                    case PopupCloseMode.CloseUpKey:
                        break;
                    case PopupCloseMode.Immediate:
                        break;
                    case PopupCloseMode.Normal:
                        break;
                    default:
                        break;
                }
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        #endregion

        

        #region Data Structure
        enum E_THAO_TAC_CHON
        {
            IMPORT_EXCEL = 0,
            XUAT_EXCEL = 1,
            CHOT_BANG_LUONG = 2,
            XEM_BANG_LUONG = 3
        }
        #endregion

        #region Private Methods
        //Load data
        private void format_controls()
        {
            set_define_events();
        }
        private void set_initial_form_load()
        {
            this.m_prb.Visible = false;
            m_txt_nam.Text = DateTime.Now.Year.ToString();
            m_txt_thang.Text = DateTime.Now.Month.ToString();
            hien_thi_thong_tin_qtr_tinh_luong();
            //load_data_2_grid();
        }
        private void load_data_2_grid()
        {
            m_grc_main.DataSource = null;
            m_grc_main.DataSource = m_lst_luong_v2;
        }

        private void tinh_toan_qtr_tinh_luong(out decimal op_dc_sl_nv_can_tinh, out decimal op_dc_sl_nv_da_tinh)
        {
            US_RPT_LUONG_V2 v_us_rpt = new US_RPT_LUONG_V2();
            v_us_rpt.get_thong_tin_qua_trinh_tinh_luong(CIPConvert.ToDecimal(m_txt_thang.Text.Trim())
                                                                , CIPConvert.ToDecimal(m_txt_nam.Text.Trim())
                                                                , out op_dc_sl_nv_can_tinh
                                                                , out op_dc_sl_nv_da_tinh);
        }
        private void hien_thi_thong_tin_qtr_tinh_luong()
        {
            decimal sl_nv_can_tinh;
            decimal sl_nv_da_tinh;
            tinh_toan_qtr_tinh_luong(out sl_nv_can_tinh, out sl_nv_da_tinh);

            if(sl_nv_can_tinh <= sl_nv_da_tinh)
            {
                m_lbl_thong_bao.Text = "Đã tính xong lương cho";
                m_lbl_thong_bao.ForeColor = Color.Green;
                m_lbl_so_luong_nv_tinh_luong.ForeColor = Color.Green;
            }
            if(sl_nv_can_tinh > sl_nv_da_tinh)
            {
                m_lbl_thong_bao.Text = "Đã tính được lương cho";
                m_lbl_thong_bao.ForeColor = Color.Red;
                m_lbl_so_luong_nv_tinh_luong.ForeColor = Color.Red;
            }
            m_lbl_so_luong_nv_tinh_luong.Text = sl_nv_da_tinh.ToString() + "/" + sl_nv_can_tinh.ToString() + " (nhân viên)";
        }


        //Check data
        private bool is_da_chot_bang_luong()
        {
            US_DUNG_CHUNG v_us_dung_chung = new US_DUNG_CHUNG();
            return v_us_dung_chung.IsDaChotBangLuongThang(
                                    CIPConvert.ToDecimal(m_txt_thang.EditValue)
                                    , CIPConvert.ToDecimal(m_txt_nam.EditValue));
        }
        private bool check_gd_chot_bang_luong_is_exist()
        {
            try
            {
                DS_GD_CHOT_BANG_LUONG v_ds = new DS_GD_CHOT_BANG_LUONG();
                US_GD_CHOT_BANG_LUONG v_us = new US_GD_CHOT_BANG_LUONG();
                v_us.FillDataset(v_ds);

                string v_str_filter = "THANG = " + CIPConvert.ToDecimal(m_txt_thang.Text.Trim()) + " AND NAM = " + CIPConvert.ToDecimal(m_txt_nam.Text.Trim());
                DataRow[] v_dr = v_ds.GD_CHOT_BANG_LUONG.Select(v_str_filter);

                if(v_dr.Count() == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch(Exception v_e)
            {
                throw v_e;
            }
        }
        private bool is_da_tinh_het_luong_nhan_vien()
        {
            decimal sl_nv_can_tinh;
            decimal sl_nv_da_tinh;
            tinh_toan_qtr_tinh_luong(out sl_nv_can_tinh, out sl_nv_da_tinh);
            if(sl_nv_can_tinh <= sl_nv_da_tinh)
            {
                return true;
            }
            return false;
        }



        //Action
        private void xoa_bang_luong_thang()
        {
            //B1: Xoa het bang luong thang do
            US_RPT_LUONG_V2 v_us_RPT_LUONG_V2_V2 = new US_RPT_LUONG_V2();
            v_us_RPT_LUONG_V2_V2.XoaLuong(Convert.ToDecimal(m_txt_thang.EditValue), Convert.ToDecimal(m_txt_nam.EditValue));
        }
        private void insert_gd_chot_bang_luong(US_GD_CHOT_BANG_LUONG ip_us_gd_chot_bang_luong)
        {
            ip_us_gd_chot_bang_luong.dcTHANG = CIPConvert.ToDecimal(m_txt_thang.Text.Trim());
            ip_us_gd_chot_bang_luong.dcNAM = CIPConvert.ToDecimal(m_txt_nam.Text.Trim());
            ip_us_gd_chot_bang_luong.strNGUOI_CHOT = CAppContext_201.getCurrentUserName();
            ip_us_gd_chot_bang_luong.datNGAY_CHOT = DateTime.Now.Date;

            ip_us_gd_chot_bang_luong.Insert();
        }
        private void insert_hs_hs_bs_hs_anhk(decimal ip_dc_thang, decimal ip_dc_nam)
        {
            US_DUNG_CHUNG v_us_dung_chung = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us_dung_chung.FillDatasetNhanVienCanInsertHeSo(v_ds, ip_dc_thang, ip_dc_nam);
            //v_us_dung_chung.FillDatasetWithQuery(v_ds, "SELECT DISTINCT * FROM V_RPT_LUONG_V2 WHERE THANG = " + m_txt_thang.Text.Trim() + " AND NAM = " + m_txt_nam.Text.Trim());

            //m_grc.DataSource = v_ds.Tables[0];

            for(int i = 0; i < v_ds.Tables[0].Rows.Count; i++)
            {
                decimal v_id_nv = CIPConvert.ToDecimal(v_ds.Tables[0].Rows[i]["ID_NHAN_VIEN"].ToString());
                US_GD_HS_BO_SUNG_AN_TOAN_HANG_KHONG v_us = new US_GD_HS_BO_SUNG_AN_TOAN_HANG_KHONG();

                v_us.insert_data_by_proc(v_id_nv, ip_dc_thang, ip_dc_nam);
            }
            DevExpress.XtraEditors.XtraMessageBox.Show("Thành công!!!", "THÔNG BÁO");
            load_data_2_grid();
        }
        private void tinh_lai_bang_luong()
        {
            if(is_da_chot_bang_luong())
                return;
            var dlg = XtraMessageBox.Show("Bạn có chắc chắn muốn tính lại bảng lương?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dlg == System.Windows.Forms.DialogResult.Yes)
            {
                if(m_bgwk.IsBusy)
                {
                    m_bgwk.CancelAsync();
                }
                else
                {
                    xoa_bang_luong_thang();
                    start_tinh_bang_luong_process();
                }
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


        //procudure & funcion new
        //check_data
        private bool is_valide_data_input()
        {
            if(m_txt_thang.EditValue == null || m_txt_nam.EditValue == null)
            {
                XtraMessageBox.Show("Bạn nhập tháng & năm trước!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        //Load Data
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

        //Action giao dien
        private void hide_progress_bar()
        {
            m_prb.Visible = false;
        }
        private void show_progress_bar()
        {
            m_prb.Visible = true;
        }

        //Process tinh luong
        private void start_tinh_bang_luong_process()
        {
            if(!is_valide_data_input())
            {
                m_bgwk.CancelAsync();
                var x  = m_bgwk.CancellationPending;
                return;
            }
            if(is_da_chot_bang_luong())
            {
                XtraMessageBox.Show("Bảng lương đã được chốt rồi, không tính lại được!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                m_bgwk.CancelAsync();
                return;
            }
           // m_grc_main.DataSource = null;
            var v_dlg_confirm = confirm_cach_tinh_bang_luong_tu_nguoi_dung();
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
                DTO_BANG_LUONG_V2 v_dto_luong = transfer_data_row_luong_2_object(v_dr_luong_nv);
                m_lst_luong_v2.Add(v_dto_luong);
                m_bgwk.ReportProgress((i + 1) * 100 / ip_ds_danh_sach_nv.Tables[0].Rows.Count);
            }
        }
        private DTO_BANG_LUONG_V2 transfer_data_row_luong_2_object(DataRow ip_dr_luong)
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

            v_us_luong_v2.dcID_NHAN_VIEN = ip_dto_luong.ID_NHAN_VIEN;
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

        private void start_luu_bang_luong_process()
        {
            
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
        private void save_data(ENUM_CONFIRM_LUU_BANG_LUONG ip_confirm_save)
        {
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
                if (v_i_row == v_i_row_count) MessageBox.Show(v_i_row.ToString());
                v_dto_bang_luong_v2 = (DTO_BANG_LUONG_V2) m_grv_main.GetRow(v_i_row);
                v_us_rpt_luong_v2 = transfer_dto_2_us_object(v_dto_bang_luong_v2);

                var v_bol_nv_co_trong_bang_luong_chua = ExcuteFuntion.KiemTraNhanVienCoTrongBangLuongChua(v_us_rpt_luong_v2.dcID_NHAN_VIEN, lay_thang(), lay_nam());
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
                        break;
                }
            }
        }
        private void chot_bang_luong()
        {
            DialogResult v_dlg_confirm;
            string v_str_text_confirm;

            if(!is_da_tinh_het_luong_nhan_vien())
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
            if(check_gd_chot_bang_luong_is_exist())
            {
                XtraMessageBox.Show("Bảng lương tháng đã được chốt rồi!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            US_GD_CHOT_BANG_LUONG v_us_gd_chot_bang_luong = new US_GD_CHOT_BANG_LUONG();
            insert_gd_chot_bang_luong(v_us_gd_chot_bang_luong);
            insert_hs_hs_bs_hs_anhk(CIPConvert.ToDecimal(m_txt_thang.Text.Trim()), CIPConvert.ToDecimal(m_txt_nam.Text.Trim()));
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
