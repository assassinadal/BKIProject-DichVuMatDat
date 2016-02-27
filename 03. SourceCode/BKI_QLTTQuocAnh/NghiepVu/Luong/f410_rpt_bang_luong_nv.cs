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

namespace BKI_DichVuMatDat.BaoCao
{
    public partial class f410_rpt_bang_luong_nv : Form
    {
        public f410_rpt_bang_luong_nv()
        {
            InitializeComponent();
            this.m_grv.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(WinFormControls.m_grv_PopupMenuShowing);
            this.m_grv.OptionsPrint.AutoWidth = false;
        }

        #region Public Interface
        public void display()
        {
            this.m_grv.BestFitColumns(true);
            this.ShowDialog();
        }
        #endregion

        #region Data Structure
        enum e_bang_luong_status
        {
            DA_TINH,
            CHUA_TINH
        }
        #endregion

        #region Members
        DS_RPT_LUONG m_ds_rpt_luong = new DS_RPT_LUONG();
        e_bang_luong_status m_e_bang_luong_status = e_bang_luong_status.CHUA_TINH;
        #endregion

        #region Private Methods
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
            load_data_2_grid();
        }


        private void load_data_2_grid()
        {
            US_RPT_LUONG v_us = new US_RPT_LUONG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.HienThiBangLuong(v_ds, Convert.ToDecimal(m_txt_thang.Text), Convert.ToDecimal(m_txt_nam.Text));
            m_grc.DataSource = v_ds.Tables[0];
        }
        private void tinh_bang_luong(BackgroundWorker ip_bgw)
        {
            if(is_da_chot_bang_luong())
                return;

            US_RPT_LUONG v_us_rpt_luong = new US_RPT_LUONG();
            DS_RPT_LUONG v_ds_rpt_luong;
            //1. Lấy tất cả nhân viên cần tính lương
            v_us_rpt_luong.Get_tat_ca_nhan_vien_can_tinh_luong(
                                out v_ds_rpt_luong
                                , CIPConvert.ToDecimal(m_txt_thang.EditValue)
                                , CIPConvert.ToDecimal(m_txt_nam.EditValue));
            //2. Tính lương cho tất cả nhân viên
            tinh_bang_luong_tat_ca_nhan_vien(v_ds_rpt_luong.RPT_LUONG, ip_bgw);
        }

        private bool is_da_chot_bang_luong()
        {
            US_GD_CHOT_BANG_LUONG v_us_dung_chung = new US_GD_CHOT_BANG_LUONG();
            return v_us_dung_chung.IsDaChotBangLuongThang(
                                    CIPConvert.ToDecimal(m_txt_thang.EditValue)
                                    , CIPConvert.ToDecimal(m_txt_nam.EditValue));
        }
        public static DataRow get_luong_1_nhan_vien(decimal ip_dc_id_nhan_vien, int ip_int_thang, int ip_int_nam)
        {
            US_RPT_LUONG v_us = new US_RPT_LUONG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillBangLuong(v_ds, ip_dc_id_nhan_vien, ip_int_thang, ip_int_nam);
            DataRow v_dr = v_ds.Tables[0].Rows[0];
            return v_dr;
        }
        public DataRow get_dr(DataRow ip_dr_luong_nv, DataRow ip_dr_luong, decimal ip_id_nv, int ip_index, int ip_thang, int ip_nam)
        {
            ip_dr_luong_nv[RPT_LUONG.ID] = ip_index;
            ip_dr_luong_nv[RPT_LUONG.ID_NHAN_VIEN] = ip_id_nv;
            ip_dr_luong_nv[RPT_LUONG.THANG] = ip_thang;
            ip_dr_luong_nv[RPT_LUONG.NAM] = ip_nam;
            ip_dr_luong_nv[RPT_LUONG.MA_NV] = ip_dr_luong[RPT_LUONG.MA_NV];
            ip_dr_luong_nv[RPT_LUONG.LUONG_NS] = ip_dr_luong[RPT_LUONG.LUONG_NS];
            ip_dr_luong_nv[RPT_LUONG.LUONG_CD] = ip_dr_luong[RPT_LUONG.LUONG_CD];
            ip_dr_luong_nv[RPT_LUONG.PHU_CAP_TN] = ip_dr_luong[RPT_LUONG.PHU_CAP_TN];
            ip_dr_luong_nv[RPT_LUONG.AN_CA] = ip_dr_luong[RPT_LUONG.AN_CA];
            ip_dr_luong_nv[RPT_LUONG.LAM_THEM] = ip_dr_luong[RPT_LUONG.LAM_THEM];
            ip_dr_luong_nv[RPT_LUONG.LAM_THEM_LE_TET] = ip_dr_luong[RPT_LUONG.LAM_THEM_LE_TET];
            ip_dr_luong_nv[RPT_LUONG.THU_NHAP] = ip_dr_luong[RPT_LUONG.THU_NHAP];
            ip_dr_luong_nv[RPT_LUONG.BHXH] = ip_dr_luong[RPT_LUONG.BHXH];
            ip_dr_luong_nv[RPT_LUONG.BHYT] = ip_dr_luong[RPT_LUONG.BHYT];
            ip_dr_luong_nv[RPT_LUONG.BHTN] = ip_dr_luong[RPT_LUONG.BHTN];
            ip_dr_luong_nv[RPT_LUONG.DOAN_PHI_CD] = ip_dr_luong[RPT_LUONG.DOAN_PHI_CD];
            ip_dr_luong_nv[RPT_LUONG.THUE] = ip_dr_luong[RPT_LUONG.THUE];
            ip_dr_luong_nv[RPT_LUONG.PHAI_NOP] = ip_dr_luong[RPT_LUONG.PHAI_NOP];
            ip_dr_luong_nv[RPT_LUONG.THUC_LINH] = ip_dr_luong[RPT_LUONG.THUC_LINH];
            ip_dr_luong_nv[RPT_LUONG.TRUY_LINH] = ip_dr_luong[RPT_LUONG.TRUY_LINH];
            ip_dr_luong_nv[RPT_LUONG.TRUY_THU] = ip_dr_luong[RPT_LUONG.TRUY_THU];
            ip_dr_luong_nv[RPT_LUONG.THUC_LINH_CUOI_CUNG] = ip_dr_luong[RPT_LUONG.THUC_LINH_CUOI_CUNG];
            ip_dr_luong_nv[RPT_LUONG.SO_NGAY_LAM_THEM] = ip_dr_luong[RPT_LUONG.SO_NGAY_LAM_THEM];
            return ip_dr_luong_nv;
        }
        public void insertLuongNV2RPT(DataRow v_dr_luong_1_nv)
        {
            US_RPT_LUONG v_us = new US_RPT_LUONG();
            DataRow2US(v_dr_luong_1_nv, v_us);
            v_us.Insert();
        }
        private void tinh_bang_luong_tat_ca_nhan_vien(DataTable ip_dt, BackgroundWorker ip_bgw)
        {
            for(int i = 0; i < ip_dt.Rows.Count; i++)
            {
                DataRow v_dr = ip_dt.Rows[i];
                decimal v_id_nhan_vien = CIPConvert.ToDecimal(v_dr[RPT_LUONG.ID_NHAN_VIEN]);
                DataRow v_dr_luong = get_luong_1_nhan_vien(v_id_nhan_vien, int.Parse(m_txt_thang.Text.Trim()), int.Parse(m_txt_nam.Text.Trim()));
                var v_dr_luong_nv = m_ds_rpt_luong.Tables[0].NewRow();
                DataRow v_dr_luong_1_nv = get_dr(v_dr_luong_nv, v_dr_luong, v_id_nhan_vien, i, int.Parse(m_txt_thang.Text.Trim()), int.Parse(m_txt_nam.Text.Trim()));
                m_ds_rpt_luong.Tables[0].Rows.Add(v_dr_luong_1_nv);
                insertLuongNV2RPT(v_dr_luong_1_nv);
                ip_bgw.ReportProgress((i + 1) * 100 / ip_dt.Rows.Count);
            }
        }
        private void xoa_bang_luong_thang()
        {
            //B1: Xoa het bang luong thang do
            US_RPT_LUONG v_us_rpt_luong = new US_RPT_LUONG();
            v_us_rpt_luong.XoaLuong(Convert.ToDecimal(m_txt_thang.EditValue), Convert.ToDecimal(m_txt_nam.EditValue));
        }
        //private void insertLuongNV2RPT(DataRow v_dr_luong_1_nv)
        //{
        //    US_RPT_LUONG v_us = new US_RPT_LUONG();
        //    DataRow2US(v_dr_luong_1_nv, v_us);
        //    v_us.Insert();
        //}

        //private void DataRow2US(DataRow v_dr_luong_1_nv, US_RPT_LUONG v_us)
        //{
        //    v_us.strMA_NV = v_dr_luong_1_nv[RPT_LUONG.MA_NV].ToString();
        //    v_us.dcAN_CA = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.AN_CA].ToString());
        //    v_us.dcBHTN = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.BHTN].ToString());
        //    v_us.dcBHXH = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.BHXH].ToString());
        //    v_us.dcBHYT = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.BHYT].ToString());
        //    v_us.dcDOAN_PHI_CD = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.DOAN_PHI_CD].ToString());
        //    v_us.dcID_NHAN_VIEN = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.ID_NHAN_VIEN].ToString());
        //    v_us.dcLAM_THEM = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.LAM_THEM].ToString());
        //    v_us.dcLAM_THEM_LE_TET = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.LAM_THEM_LE_TET].ToString());
        //    v_us.dcLUONG_CD = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.LUONG_CD].ToString());
        //    v_us.dcLUONG_KHAC_THUE_10 = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.LUONG_KHAC_THUE_10].ToString());
        //    v_us.dcLUONG_KHAC_THUE_5 = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.LUONG_KHAC_THUE_5].ToString());
        //    v_us.dcLUONG_KHAC_THUE_TINH_THEO_LUONG = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.LUONG_KHAC_THUE_TINH_THEO_LUONG].ToString());
        //    v_us.dcLUONG_NS = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.LUONG_NS].ToString());
        //    v_us.dcNAM = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.NAM].ToString());
        //    v_us.dcPHAI_NOP = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.PHAI_NOP].ToString());
        //    v_us.dcPHU_CAP_TN = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.PHU_CAP_TN].ToString());
        //    v_us.dcTHANG = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.THANG].ToString());
        //    v_us.dcTHU_NHAP = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.THU_NHAP].ToString());
        //    v_us.dcTHUC_LINH = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.THUC_LINH].ToString());
        //    v_us.dcTHUC_LINH_CUOI_CUNG = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.THUC_LINH_CUOI_CUNG].ToString());
        //    v_us.dcTHUE = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.THUE].ToString());
        //    v_us.dcTHUE_TU_LUONG_KHAC_10 = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.THUE_TU_LUONG_KHAC_10].ToString());
        //    v_us.dcTHUE_TU_LUONG_KHAC_5 = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.THUE_TU_LUONG_KHAC_5].ToString());
        //    v_us.dcTRUY_LINH = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.TRUY_LINH].ToString());
        //    v_us.dcTRUY_THU = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.TRUY_THU].ToString());
        //}

        //private DataRow get_dr(DataRow ip_dr_luong_nv, DataRow ip_dr_luong, decimal ip_id_nv, int ip_index, int ip_thang, int ip_nam)
        //{
        //    ip_dr_luong_nv[RPT_LUONG.ID] = ip_index;
        //    ip_dr_luong_nv[RPT_LUONG.ID_NHAN_VIEN] = ip_id_nv;
        //    ip_dr_luong_nv[RPT_LUONG.THANG] = ip_thang;
        //    ip_dr_luong_nv[RPT_LUONG.NAM] = ip_nam;
        //    ip_dr_luong_nv[RPT_LUONG.MA_NV] = ip_dr_luong[RPT_LUONG.MA_NV];
        //    ip_dr_luong_nv[RPT_LUONG.LUONG_NS] = ip_dr_luong[RPT_LUONG.LUONG_NS];
        //    ip_dr_luong_nv[RPT_LUONG.LUONG_CD] = ip_dr_luong[RPT_LUONG.LUONG_CD];
        //    ip_dr_luong_nv[RPT_LUONG.PHU_CAP_TN] = ip_dr_luong[RPT_LUONG.PHU_CAP_TN];
        //    ip_dr_luong_nv[RPT_LUONG.AN_CA] = ip_dr_luong[RPT_LUONG.AN_CA];
        //    ip_dr_luong_nv[RPT_LUONG.LAM_THEM] = ip_dr_luong[RPT_LUONG.LAM_THEM];
        //    ip_dr_luong_nv[RPT_LUONG.LAM_THEM_LE_TET] = ip_dr_luong[RPT_LUONG.LAM_THEM_LE_TET];
        //    ip_dr_luong_nv[RPT_LUONG.LUONG_KHAC_THUE_5] = ip_dr_luong[RPT_LUONG.LUONG_KHAC_THUE_5];
        //    ip_dr_luong_nv[RPT_LUONG.LUONG_KHAC_THUE_10] = ip_dr_luong[RPT_LUONG.LUONG_KHAC_THUE_10];
        //    ip_dr_luong_nv[RPT_LUONG.LUONG_KHAC_THUE_TINH_THEO_LUONG] = ip_dr_luong[RPT_LUONG.LUONG_KHAC_THUE_TINH_THEO_LUONG];
        //    ip_dr_luong_nv[RPT_LUONG.THU_NHAP] = ip_dr_luong[RPT_LUONG.THU_NHAP];
        //    ip_dr_luong_nv[RPT_LUONG.BHXH] = ip_dr_luong[RPT_LUONG.BHXH];
        //    ip_dr_luong_nv[RPT_LUONG.BHYT] = ip_dr_luong[RPT_LUONG.BHYT];
        //    ip_dr_luong_nv[RPT_LUONG.BHTN] = ip_dr_luong[RPT_LUONG.BHTN];
        //    ip_dr_luong_nv[RPT_LUONG.DOAN_PHI_CD] = ip_dr_luong[RPT_LUONG.DOAN_PHI_CD];
        //    ip_dr_luong_nv[RPT_LUONG.THUE] = ip_dr_luong[RPT_LUONG.THUE];
        //    ip_dr_luong_nv[RPT_LUONG.THUE_TU_LUONG_KHAC_5] = ip_dr_luong[RPT_LUONG.THUE_TU_LUONG_KHAC_5];
        //    ip_dr_luong_nv[RPT_LUONG.THUE_TU_LUONG_KHAC_10] = ip_dr_luong[RPT_LUONG.THUE_TU_LUONG_KHAC_10];
        //    ip_dr_luong_nv[RPT_LUONG.PHAI_NOP] = ip_dr_luong[RPT_LUONG.PHAI_NOP];
        //    ip_dr_luong_nv[RPT_LUONG.THUC_LINH] = ip_dr_luong[RPT_LUONG.THUC_LINH];
        //    ip_dr_luong_nv[RPT_LUONG.TRUY_LINH] = ip_dr_luong[RPT_LUONG.TRUY_LINH];
        //    ip_dr_luong_nv[RPT_LUONG.TRUY_THU] = ip_dr_luong[RPT_LUONG.TRUY_THU];
        //    ip_dr_luong_nv[RPT_LUONG.THUC_LINH_CUOI_CUNG] = ip_dr_luong[RPT_LUONG.THUC_LINH_CUOI_CUNG];
        //    return ip_dr_luong_nv;
        //}

        //private DataRow get_luong_1_nhan_vien(decimal ip_dc_id_nhan_vien, int ip_int_thang, int ip_int_nam)
        //{
        //    US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
        //    DataSet v_ds = new DataSet();
        //    v_ds.Tables.Add(new DataTable());
        //    v_us.FillBangLuong(v_ds, ip_dc_id_nhan_vien, ip_int_thang, ip_int_nam);
        //    DataRow v_dr = v_ds.Tables[0].Rows[0];
        //    return v_dr;
        //}

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

        private void insert_gd_bang_luong(US_GD_CHOT_BANG_LUONG ip_us_gd_chot_bang_luong)
        {
            ip_us_gd_chot_bang_luong.dcTHANG = CIPConvert.ToDecimal(m_txt_thang.Text.Trim());
            ip_us_gd_chot_bang_luong.dcNAM = CIPConvert.ToDecimal(m_txt_nam.Text.Trim());
            ip_us_gd_chot_bang_luong.strNGUOI_CHOT = CAppContext_201.getCurrentUserName();
            ip_us_gd_chot_bang_luong.datNGAY_CHOT = DateTime.Now.Date;

            ip_us_gd_chot_bang_luong.Insert();
        }

        private void insert_hs_hs_bs_hs_anhk(decimal ip_dc_thang, decimal ip_dc_nam)
        {
            US_DM_NHAN_VIEN v_us_dung_chung = new US_DM_NHAN_VIEN();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us_dung_chung.FillDatasetNhanVienCanInsertHeSo(v_ds, ip_dc_thang, ip_dc_nam);
            //v_us_dung_chung.FillDatasetWithQuery(v_ds, "SELECT DISTINCT * FROM V_RPT_LUONG WHERE THANG = " + m_txt_thang.Text.Trim() + " AND NAM = " + m_txt_nam.Text.Trim());

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

        private bool is_valide_data_input()
        {
            if((decimal)m_txt_thang.EditValue == 0 || (decimal)m_txt_nam.EditValue == 0)
            {
                XtraMessageBox.Show("Hoàn thiện dữ liệu trước", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void start_tinh_luong_process()
        {

            if(m_bgwk.IsBusy)
            {
                m_bgwk.CancelAsync();
            }
            else
            {
                this.m_prb.Visible = true;
                m_ds_rpt_luong.RPT_LUONG.Clear();
                m_bgwk.RunWorkerAsync();
                m_e_bang_luong_status = e_bang_luong_status.DA_TINH;
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
        private void chot_bang_luong()
        {
            if(!is_da_tinh_het_luong_nhan_vien())
            {
                CHRM_BaseMessages.MsgBox_Infor("Chưa tính toán xong dữ liệu nhân viên");
                return;
            }
            if(m_e_bang_luong_status == e_bang_luong_status.CHUA_TINH)
            {
                CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_CHUA_CO_DU_LIEU_DE_THUC_HIEN_THAO_TAC);
                return;
            }

            if(CHRM_BaseMessages.MsgBox_Confirm(
                                        "Bạn có chắc chắn muốn chốt bảng lương tháng "
                                        + m_txt_thang.Text.Trim()
                                        + " năm "
                                        + m_txt_nam.Text.Trim()) == false)
                return;
            if(!check_gd_chot_bang_luong_is_exist())
            {
                US_GD_CHOT_BANG_LUONG v_us_gd_chot_bang_luong = new US_GD_CHOT_BANG_LUONG();
                insert_gd_bang_luong(v_us_gd_chot_bang_luong);
                //them dl vao bang hs bo sung, hs an toan hk
                //insert_hs_hs_bs_hs_anhk(CIPConvert.ToDecimal(m_txt_thang.Text.Trim()), CIPConvert.ToDecimal(m_txt_nam.Text.Trim()));
            }
            insert_hs_hs_bs_hs_anhk(CIPConvert.ToDecimal(m_txt_thang.Text.Trim()), CIPConvert.ToDecimal(m_txt_nam.Text.Trim()));
            //else
            //{
            //    DevExpress.XtraEditors.XtraMessageBox.Show("Bảng lương tháng " + m_txt_thang.Text.Trim() + " năm " + m_txt_nam.Text.Trim() + " đã được chốt rồi", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
        }
        private void tinh_toan_qtr_tinh_luong(out decimal op_dc_sl_nv_can_tinh, out decimal op_dc_sl_nv_da_tinh)
        {
            US_RPT_LUONG v_us_rpt = new US_RPT_LUONG();
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
                CHRM_BaseMessages.MsgBox_Infor("Chưa tính lương xong, Ấn tính bảng lương để tính tiếp nhé!");
                m_lbl_thong_bao.ForeColor = Color.Red;
                m_lbl_so_luong_nv_tinh_luong.ForeColor = Color.Red;
            }
            m_lbl_so_luong_nv_tinh_luong.Text = sl_nv_da_tinh.ToString() + "/" + sl_nv_can_tinh.ToString() + " (nhân viên)";
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
                    start_tinh_luong_process();
                }
            }
        }
        #endregion

        #region Event Handle
        private void set_define_events()
        {

        }

        private void m_cmd_bang_luong_Click(object sender, EventArgs e)
        {
            try
            {
                start_tinh_luong_process();
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
                BackgroundWorker v_obj_worker = sender as BackgroundWorker;
                tinh_bang_luong(v_obj_worker);
            }
            catch(Exception v_e)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Có tý tẹo vấn đề. Bạn chụp ảnh và gửi để chúng tôi hỗ trợ nhé!" + v_e.ToString());
            }
        }

        private void m_bgwk_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                this.m_prb.Visible = false;
                load_data_2_grid();
                hien_thi_thong_tin_qtr_tinh_luong();
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
                CHRM_BaseMessages.MsgBox_Infor("Có lỗi hoặc mất mạng. Ấn chốt bảng lương để tính tiếp nhé");
            }

        }

        private void m_cmd_luu_bang_luong_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "xls files (*.xls)|*.xls|All files (*.*)|*.*";
                saveFileDialog1.RestoreDirectory = true;
                if(saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    m_grv.ExportToXls(saveFileDialog1.FileName);
                    DevExpress.XtraEditors.XtraMessageBox.Show("Lưu báo cáo thành công");
                }
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        #endregion

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
        //public DataRow get_luong_1_nhan_vien(decimal ip_dc_id_nhan_vien, int ip_int_thang, int ip_int_nam)
        //{
        //    US_RPT_LUONG v_us = new US_RPT_LUONG();
        //    DataSet v_ds = new DataSet();
        //    v_ds.Tables.Add(new DataTable());
        //    v_us.FillBangLuong(v_ds, ip_dc_id_nhan_vien, ip_int_thang, ip_int_nam);
        //    DataRow v_dr = v_ds.Tables[0].Rows[0];
        //    return v_dr;
        //}
        public void DataRow2US(DataRow v_dr_luong_1_nv, US_RPT_LUONG v_us)
        {
            v_us.strMA_NV = v_dr_luong_1_nv[RPT_LUONG.MA_NV].ToString();
            v_us.dcAN_CA = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.AN_CA].ToString());
            v_us.dcBHTN = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.BHTN].ToString());
            v_us.dcBHXH = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.BHXH].ToString());
            v_us.dcBHYT = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.BHYT].ToString());
            v_us.dcDOAN_PHI_CD = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.DOAN_PHI_CD].ToString());
            v_us.dcID_NHAN_VIEN = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.ID_NHAN_VIEN].ToString());
            v_us.dcLAM_THEM = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.LAM_THEM].ToString());
            v_us.dcLAM_THEM_LE_TET = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.LAM_THEM_LE_TET].ToString());
            v_us.dcLUONG_CD = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.LUONG_CD].ToString());
            v_us.dcLUONG_NS = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.LUONG_NS].ToString());
            v_us.dcNAM = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.NAM].ToString());
            v_us.dcPHAI_NOP = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.PHAI_NOP].ToString());
            v_us.dcPHU_CAP_TN = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.PHU_CAP_TN].ToString());
            v_us.dcTHANG = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.THANG].ToString());
            v_us.dcTHU_NHAP = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.THU_NHAP].ToString());
            v_us.dcTHUC_LINH = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.THUC_LINH].ToString());
            v_us.dcTHUC_LINH_CUOI_CUNG = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.THUC_LINH_CUOI_CUNG].ToString());
            v_us.dcTHUE = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.THUE].ToString());
            v_us.dcTRUY_LINH = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.TRUY_LINH].ToString());
            v_us.dcTRUY_THU = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.TRUY_THU].ToString());
            v_us.dcSO_NGAY_LAM_THEM = Convert.ToDecimal(v_dr_luong_1_nv[RPT_LUONG.SO_NGAY_LAM_THEM]);
        }
        //public void insertLuongNV2RPT(DataRow v_dr_luong_1_nv)
        //{
        //    US_RPT_LUONG v_us = new US_RPT_LUONG();
        //    DataRow2US(v_dr_luong_1_nv, v_us);
        //    v_us.Insert();
        //}
        private void m_cmd_tinh_lai_cho_nhan_vien_Click(object sender, EventArgs e)
        {
            try
            {
                if(m_grv.FocusedRowHandle < 0)
                {
                    XtraMessageBox.Show("Chọn nhân viên trước để tính lại lương!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                decimal v_id_nhan_vien = Convert.ToDecimal(m_grv.GetRowCellValue(m_grv.FocusedRowHandle, "ID_NHAN_VIEN"));

                DataRow v_dr_luong = get_luong_1_nhan_vien(v_id_nhan_vien, int.Parse(m_txt_thang.Text.Trim()), int.Parse(m_txt_nam.Text.Trim()));

                var v_dr_luong_nv = m_ds_rpt_luong.Tables[0].NewRow();
                DataRow v_dr_luong_1_nv = get_dr(v_dr_luong_nv, v_dr_luong, v_id_nhan_vien, 0, int.Parse(m_txt_thang.Text.Trim()), int.Parse(m_txt_nam.Text.Trim()));
                
                //Xoa ban ghi truoc khi insert lai
                US_RPT_LUONG v_us_2_del = new US_RPT_LUONG();
                v_us_2_del.XoaBanGhiLuong(v_id_nhan_vien, Convert.ToDecimal(m_txt_thang.EditValue), Convert.ToDecimal(m_txt_nam.EditValue));
                insertLuongNV2RPT(v_dr_luong_1_nv);
                load_data_2_grid();
                XtraMessageBox.Show("Cập nhật thành công");
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
    }
}