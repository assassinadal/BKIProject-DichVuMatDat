using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using BKI_DichVuMatDat;
using BKI_DichVuMatDat.US;
using BKI_DichVuMatDat.DS;
using BKI_DichVuMatDat.DS.CDBNames;
using IP.Core.IPCommon;
using System.Globalization;
using DevExpress.XtraEditors;
using IP.Core.IPSystemAdmin;

namespace BKI_DichVuMatDat.NghiepVu
{
    public partial class f350_quan_ly_vi_tri_cong_tac : Form
    {
        public f350_quan_ly_vi_tri_cong_tac()
        {
            InitializeComponent();
            format_controls();
        }

        #region Public Interface
        public void display()
        {
            this.ShowDialog();
        }

        public void DisplayForQuyTrinhNhapMoiNhanVien(int id_nhan_vien, ref int m_trang_thai_buoc_4)
        {
            m_sle_chon_nhan_vien.EditValue = id_nhan_vien;
            m_trang_thai_them = m_trang_thai_buoc_4;
            this.ShowDialog();
            m_trang_thai_buoc_4 = m_trang_thai_buoc_4_thanh_cong;
        }

        public void DisplayForQuyTrinhNhapMoiNhanVien(int id_nhan_vien)
        {
            m_sle_chon_nhan_vien.EditValue = id_nhan_vien;

            this.ShowDialog();

        }
        #endregion

        #region Members
        DataEntryFormMode m_e_form_mode = DataEntryFormMode.InsertDataState;

        decimal m_if_insert_click = 1;
        decimal m_id_gd_ct = 0;
        bool m_loai_ctac_cthuc = false;
        int m_trang_thai_them = 0;
        int m_trang_thai_buoc_4_thanh_cong = 0;
        #endregion

        #region Private Methods
        private void format_controls()
        {
            FormatControl.SetVisibleSimpleButton(this);
            this.m_grv_v_gd_cong_tac.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(WinFormControls.m_grv_PopupMenuShowing);
            this.m_grv_v_gd_cong_tac.OptionsPrint.AutoWidth = false;
            set_define_events();
            this.KeyPreview = true;
            CenterToScreen();
        }

        private void set_initial_form_load()
        {
            //load_data_2_sle_chon_nv();
            //load_data_2_sle_chon_quyet_dinh();
            //load_data_2_sle_chon_don_vi();
            //load_data_2_sle_chon_vi_tri();
            //load_data_2_sle_chon_loai_cong_tac();
            load_data_2_grid();
        }

        //load data to all controls

        private DataSet load_data_2_ds_v_dm_nv()
        {
            US_V_DM_NHAN_VIEN v_us = new US_V_DM_NHAN_VIEN();
            DS_V_DM_NHAN_VIEN v_ds = new DS_V_DM_NHAN_VIEN();

            v_us.FillDataset(v_ds);

            return v_ds;
        }

        private void load_data_2_sle_chon_nv()
        {
            m_sle_chon_nhan_vien.Properties.DataSource = load_data_2_ds_v_dm_nv().Tables[0];

            m_sle_chon_nhan_vien.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            m_sle_chon_nhan_vien.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
        }

        private DataSet load_data_2_ds_v_gd_quyet_dinh()
        {
            US_V_GD_QUYET_DINH v_us = new US_V_GD_QUYET_DINH();
            DS_V_GD_QUYET_DINH v_ds = new DS_V_GD_QUYET_DINH();
            v_us.FillDataset(v_ds);
            //v_us.FillDatasetWithTableName(v_ds, "V_GD_QUYET_DINH");
            return v_ds;
        }

        private void load_data_2_sle_chon_quyet_dinh()
        {
            m_sle_chon_quyet_dinh.Properties.DataSource = load_data_2_ds_v_gd_quyet_dinh().Tables[0];
            m_sle_chon_quyet_dinh.Properties.DisplayMember = V_GD_QUYET_DINH.TEN;
            m_sle_chon_quyet_dinh.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            m_sle_chon_quyet_dinh.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
        }

        private DataSet load_data_2_cm_dm_tu_dien(int m_id_vt)
        {
            DS_CM_DM_TU_DIEN v_ds = new DS_CM_DM_TU_DIEN();
            US_CM_DM_TU_DIEN v_us = new US_CM_DM_TU_DIEN();
            v_us.FillDatasetByIdLoaiTuDien(v_ds, m_id_vt);
            return v_ds;
        }

        private DataSet load_data_2_ds_v_dm_don_vi()
        {
            US_DM_DON_VI v_us = new US_DM_DON_VI();
            DS_DM_DON_VI v_ds = new DS_DM_DON_VI();
            v_us.FillDataset(v_ds);
            return v_ds;
        }

        private void load_data_2_sle_chon_don_vi()
        {
            DataSet v_ds = new DataSet();
            v_ds = load_data_2_ds_v_dm_don_vi();
            m_sle_chon_don_vi.Properties.DataSource = v_ds.Tables[0];

            m_sle_chon_don_vi.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            m_sle_chon_don_vi.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
        }

        private void load_data_2_sle_chon_vi_tri()
        {
            m_sle_chon_vi_tri.Properties.DataSource = load_data_2_cm_dm_tu_dien(CONST_ID_LOAI_TU_DIEN.LOAI_VI_TRI).Tables[0];

            m_sle_chon_vi_tri.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            m_sle_chon_vi_tri.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
        }

        private void load_data_2_sle_chon_loai_cong_tac()
        {
            m_sle_chon_loai_cong_tac.Properties.DataSource = load_data_2_cm_dm_tu_dien(CONST_ID_LOAI_TU_DIEN.LOAI_CONG_TAC).Tables[0];

            m_sle_chon_loai_cong_tac.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            m_sle_chon_loai_cong_tac.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
        }

        private void load_data_2_grid()
        {
            CHRMCommon.make_stt(m_grv_v_gd_cong_tac);

            US_GD_CONG_TAC v_us = new US_GD_CONG_TAC();
            DataSet v_ds = new DataSet();

            v_ds.Tables.Add(new DataTable());

            v_us.LayThongTinQuaTrinhCongTacTatCaNV(v_ds);

            m_grc_v_gd_cong_tac.DataSource = v_ds.Tables[0];
        }

        private void load_data_2_grid(decimal ip_dc_id_nv)
        {
            CHRMCommon.make_stt(m_grv_v_gd_cong_tac);

            //US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            //DataSet v_ds = new DataSet();

            //v_ds.Tables.Add(new DataTable());

            //v_us.FillDatasetWithQuery(v_ds, "select * from V_GD_CONG_TAC WHere ID_NHAN_VIEN = " + ip_dc_id_nv);
            US_GD_CONG_TAC v_us = new US_GD_CONG_TAC();
            DataSet v_ds = new DataSet();

            v_ds.Tables.Add(new DataTable());

            v_us.LayThongTinQuaTrinhCongTac(v_ds, ip_dc_id_nv);

            m_grc_v_gd_cong_tac.DataSource = v_ds.Tables[0];
        }

        private void load_data_2_grid(decimal ip_dc_id_nv, decimal ip_dc_id_loai_ct)
        {
            CHRMCommon.make_stt(m_grv_v_gd_cong_tac);

            //US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            //DataSet v_ds = new DataSet();

            //v_ds.Tables.Add(new DataTable());

            //v_us.FillDatasetWithQuery(v_ds, "select * from V_GD_CONG_TAC WHere ID_NHAN_VIEN = " + ip_dc_id_nv + " AND ID_LOAI_CONG_TAC = " + ip_dc_id_loai_ct);

            US_GD_CONG_TAC v_us = new US_GD_CONG_TAC();
            DataSet v_ds = new DataSet();

            v_ds.Tables.Add(new DataTable());

            v_us.LayThongTinQuaTrinhCongTac(v_ds, ip_dc_id_nv, ip_dc_id_loai_ct);
            m_grc_v_gd_cong_tac.DataSource = v_ds.Tables[0];
        }

        private void load_data_2_m_variable()
        {
            m_id_gd_ct = find_id_gd_ct(CIPConvert.ToDecimal(m_sle_chon_nhan_vien.EditValue));
            m_loai_ctac_cthuc = loai_ctac_cthuc_isExist(CIPConvert.ToDecimal(m_sle_chon_nhan_vien.EditValue), CONST_ID_LOAI_CONG_TAC.CHINH_THUC);
        }

        private bool loai_ctac_cthuc_isExist(decimal ip_dc_id_nv, decimal ip_dc_id_loai_ct)
        {
            US_GD_CONG_TAC v_us = new US_GD_CONG_TAC();
            DS_GD_CONG_TAC v_ds = new DS_GD_CONG_TAC();

            v_us.FillDataset(v_ds);

            string v_str_filter = "ID_NHAN_VIEN = " + ip_dc_id_nv + "AND DA_XOA = 'N' AND ID_LOAI_CONG_TAC = " + ip_dc_id_loai_ct;
            DataRow[] v_dr = v_ds.GD_CONG_TAC.Select(v_str_filter);

            if (v_dr.Count() == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private decimal find_id_gd_ct(decimal ip_dc_id_nv)
        {
            US_GD_CONG_TAC v_us = new US_GD_CONG_TAC();
            DS_GD_CONG_TAC v_ds = new DS_GD_CONG_TAC();

            v_us.FillDataset(v_ds);

            string v_str_filter = "ID_NHAN_VIEN = " + ip_dc_id_nv + "AND DA_XOA = 'N'";
            DataRow[] v_dr = v_ds.GD_CONG_TAC.Select(v_str_filter);

            if (v_dr.Count() == 0)
            {
                return -1;
            }
            else
            {
                return CIPConvert.ToDecimal(v_dr.First()["ID"].ToString());
            }
        }

        private decimal find_id_gd_ma_tra_cuu_nhan_vien(decimal ip_dc_id_nhan_vien)
        {
            US_GD_MA_TRA_CUU_NHAN_VIEN v_us = new US_GD_MA_TRA_CUU_NHAN_VIEN();
            DS_GD_MA_TRA_CUU_NHAN_VIEN v_ds = new DS_GD_MA_TRA_CUU_NHAN_VIEN();

            v_us.FillDataset(v_ds);

            string v_str_filter = "ID_NHAN_VIEN = " + ip_dc_id_nhan_vien + "AND DA_XOA = 'N'";
            DataRow[] v_dr = v_ds.GD_MA_TRA_CUU_NHAN_VIEN.Select(v_str_filter);

            if (v_dr.Count() == 0)
            {
                return -1;
            }
            else
            {
                return CIPConvert.ToDecimal(v_dr.First()["ID"].ToString());
            }
        }

        //Check validate data
        private bool check_data_is_ok()
        {
            if (m_sle_chon_nhan_vien.EditValue == null || m_sle_chon_nhan_vien.EditValue == "")
            {
                CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_CHUA_CHON_NHAN_VIEN);
                return false;
            }
            //GD quyet dinh dang chua co du lieu
            //if (m_sle_chon_quyet_dinh.EditValue == null || m_sle_chon_quyet_dinh.EditValue == "")
            //{
            //    CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_CHUA_CHON_QUYET_DINH);
            //    return false;
            //}
            if (m_sle_chon_don_vi.EditValue == null || m_sle_chon_don_vi.EditValue == "")
            {
                CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_CHUA_CHON_DON_VI);
                return false;
            }

            if (m_sle_chon_vi_tri.EditValue == null || m_sle_chon_vi_tri.EditValue == "")
            {
                CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_CHUA_CHON_VI_TRI);
                return false;
            }

            if (m_sle_chon_loai_cong_tac.EditValue == null || m_sle_chon_loai_cong_tac.EditValue == "")
            {
                CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_CHUA_CHON_LOAI_CONG_TAC);
                return false;
            }

            if (m_dat_ngay_bat_dau.Value.Date == null || m_dat_ngay_bat_dau.Value.Date.ToString() == "")
            {
                CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_CHUA_CHON_NGAY_BAT_DAU);
            }
            return true;
        }

        //Clear data in form
        private void clear_data_in_form()
        {
            m_sle_chon_nhan_vien.EditValue = null;
            m_sle_chon_quyet_dinh.EditValue = null;
            m_sle_chon_don_vi.EditValue = null;
            m_sle_chon_vi_tri.EditValue = null;
            m_sle_chon_loai_cong_tac.EditValue = null;

            DS_V_GD_CONG_TAC v_ds = new DS_V_GD_CONG_TAC();
            m_grc_v_gd_cong_tac.DataSource = v_ds.Tables[0];
        }

        private void form_2_us_gd_cong_tac(US_GD_CONG_TAC ip_us)
        {

            if (m_sle_chon_quyet_dinh.EditValue != null && m_sle_chon_quyet_dinh.EditValue != "")
            {
                ip_us.dcID_QUYET_DINH = CIPConvert.ToDecimal(m_sle_chon_quyet_dinh.EditValue);
            }

            if (m_sle_chon_nhan_vien.EditValue != null && m_sle_chon_nhan_vien.EditValue != "")
            {
                ip_us.dcID_NHAN_VIEN = CIPConvert.ToDecimal(m_sle_chon_nhan_vien.EditValue);
            }

            if (m_sle_chon_don_vi.EditValue != null && m_sle_chon_don_vi.EditValue != "")
            {
                ip_us.dcID_DON_VI = CIPConvert.ToDecimal(m_sle_chon_don_vi.EditValue);
            }

            if (m_sle_chon_vi_tri.EditValue != null && m_sle_chon_vi_tri.EditValue != "")
            {
                ip_us.dcID_VI_TRI = CIPConvert.ToDecimal(m_sle_chon_vi_tri.EditValue);
            }

            if (m_sle_chon_loai_cong_tac.EditValue != null && m_sle_chon_loai_cong_tac.EditValue != "")
            {
                ip_us.dcID_LOAI_CONG_TAC = CIPConvert.ToDecimal(m_sle_chon_loai_cong_tac.EditValue);
            }

            if (m_dat_ngay_bat_dau.Value.Date != null && m_dat_ngay_bat_dau.Value.Date.ToString() != "")
            {
                //Ngay bat dau
                ip_us.datNGAY_BAT_DAU = m_dat_ngay_bat_dau.Value.Date;
            }

            if (m_dat_ngay_ket_thuc.Value.Date != null && m_dat_ngay_ket_thuc.Value.Date.ToString() != "")
            {
                //Ngay ket thuc
                if (!m_dat_ngay_ket_thuc.Checked)
                {
                    ip_us.datNGAY_KET_THUC = m_dat_ngay_bat_dau.Value.AddYears(45);
                }
                else
                {
                    ip_us.datNGAY_KET_THUC = m_dat_ngay_ket_thuc.Value.Date;
                }
            }

            if (m_e_form_mode == DataEntryFormMode.InsertDataState)
            {
                //Ngay lap
                ip_us.datNGAY_LAP = DateTime.Now.Date;
                ip_us.strNGUOI_LAP = CAppContext_201.getCurrentUserName();
            }
            else if (m_e_form_mode == DataEntryFormMode.UpdateDataState)
            {
                //Ngay sua
                ip_us.datNGAY_SUA = DateTime.Now.Date;
                ip_us.strNGUOI_SUA = CAppContext_201.getCurrentUserName();
            }
            ip_us.strDA_XOA = "N";
        }

        private void save_data()
        {
            US_GD_CONG_TAC v_us_gd_ct = new US_GD_CONG_TAC();
            form_2_us_gd_cong_tac(v_us_gd_ct);
            try
            {
                switch (m_e_form_mode)
                {
                    case DataEntryFormMode.InsertDataState:
                        if (m_id_gd_ct != -1)
                        {
                            //Nhan vien da co GD cong tac
                            if (m_loai_ctac_cthuc == true && CIPConvert.ToDecimal(m_sle_chon_loai_cong_tac.EditValue) == CONST_ID_LOAI_CONG_TAC.CHINH_THUC)
                            {
                                cho_gd_ct_da_xoa_Y();
                            }
                        }

                        v_us_gd_ct.BeginTransaction();
                        v_us_gd_ct.Insert();
                        v_us_gd_ct.CommitTransaction();
                        break;
                    case DataEntryFormMode.UpdateDataState:
                        v_us_gd_ct.BeginTransaction();
                        v_us_gd_ct.Update();
                        v_us_gd_ct.CommitTransaction();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void cho_gd_ct_da_xoa_Y()
        {
            US_GD_CONG_TAC v_us = new US_GD_CONG_TAC(m_id_gd_ct);
            v_us.strDA_XOA = "Y";
            v_us.BeginTransaction();
            v_us.Update();
            v_us.CommitTransaction();
        }

        private void display_m_cmd_huy_kiem_nhiem_yn()
        {
            if (CIPConvert.ToDecimal(m_sle_chon_loai_cong_tac.EditValue.ToString()) == CONST_ID_LOAI_CONG_TAC.KIEM_NHIEM)
            {
                m_cmd_huy_kiem_nhiem.Visible = true;
            }
            else
            {
                m_cmd_huy_kiem_nhiem.Visible = false;
            }
        }

        public void import_excel()
        {
            string m_txt_path = WinFormControls.openFileDialog();
            if (m_txt_path != "")
            {
                f352_quan_ly_cong_tac_excel v_f = new f352_quan_ly_cong_tac_excel();
                v_f.displayToInsertExcel(m_txt_path);
            }
        }

        public void import_excel(ref bool trang_thai_hien_tai)
        {
            string m_txt_path = WinFormControls.openFileDialog();
            if (m_txt_path != "")
            {
                f352_quan_ly_cong_tac_excel v_f = new f352_quan_ly_cong_tac_excel();
                v_f.displayToInsertExcel(m_txt_path);
                trang_thai_hien_tai = true;
            }
        }

        #endregion

        private void set_define_events()
        {
            this.Load += f350_quan_ly_vi_tri_cong_tac_Load;

            m_sle_chon_nhan_vien.EditValueChanged += m_sle_chon_nhan_vien_EditValueChanged;
            m_sle_chon_loai_cong_tac.EditValueChanged += m_sle_chon_loai_cong_tac_EditValueChanged;
            m_cmd_insert.Click += m_cmd_insert_Click;
            m_cmd_huy_kiem_nhiem.Click += m_cmd_huy_kiem_nhiem_Click;
            m_cmd_chon_file.Click += m_cmd_chon_file_Click;
            m_cmd_update.Click += m_cmd_update_Click;
        }

        private void m_cmd_update_Click(object sender, EventArgs e)
        {
            try
            {
                decimal v_id_nv = 0;
                f351_quan_ly_cong_tac_de v_frm = new f351_quan_ly_cong_tac_de();
                v_frm.display_4_update(v_id_nv);
                load_data_2_grid();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_chon_file_Click(object sender, EventArgs e)
        {
            try
            {
                import_excel();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_sle_chon_loai_cong_tac_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (m_sle_chon_nhan_vien.EditValue == null || m_sle_chon_nhan_vien.EditValue == "")
                {
                    return;
                }
                if ((m_sle_chon_nhan_vien.EditValue != null || m_sle_chon_nhan_vien.EditValue != "") && (m_sle_chon_loai_cong_tac.EditValue == null || m_sle_chon_loai_cong_tac.EditValue == ""))
                {
                    load_data_2_grid(CIPConvert.ToDecimal(m_sle_chon_nhan_vien.EditValue));
                }
                if ((m_sle_chon_loai_cong_tac.EditValue != null && m_sle_chon_loai_cong_tac.EditValue != "") && (m_sle_chon_nhan_vien.EditValue != null && m_sle_chon_nhan_vien.EditValue != ""))
                {
                    load_data_2_grid(CIPConvert.ToDecimal(m_sle_chon_nhan_vien.EditValue), CIPConvert.ToDecimal(m_sle_chon_loai_cong_tac.EditValue));
                }
                if (m_sle_chon_loai_cong_tac.EditValue != null && m_sle_chon_loai_cong_tac.EditValue == "")
                {
                    display_m_cmd_huy_kiem_nhiem_yn();
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void f350_quan_ly_vi_tri_cong_tac_Load(object sender, EventArgs e)
        {
            try
            {
                set_initial_form_load();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_sle_chon_nhan_vien_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (m_sle_chon_nhan_vien.EditValue == null || m_sle_chon_nhan_vien.EditValue == "")
                {
                    clear_data_in_form();
                    return;
                }
                if (m_sle_chon_loai_cong_tac.EditValue == null || m_sle_chon_loai_cong_tac.EditValue == "")
                {
                    load_data_2_grid(CIPConvert.ToDecimal(m_sle_chon_nhan_vien.EditValue));
                }
                else
                {
                    load_data_2_grid(CIPConvert.ToDecimal(m_sle_chon_nhan_vien.EditValue), CIPConvert.ToDecimal(m_sle_chon_loai_cong_tac.EditValue));
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_insert_Click(object sender, EventArgs e)
        {
            try
            {
                decimal v_id_gd_cong_tac_moi_tao = 0;
                f351_quan_ly_cong_tac_de v_frm = new f351_quan_ly_cong_tac_de();
                v_frm.display_4_insert(ref v_id_gd_cong_tac_moi_tao);
                load_data_2_grid();

                //if (check_data_is_ok() == true)
                //{
                //    if (CHRM_BaseMessages.MsgBox_Confirm(CONST_ID_MSGBOX.QUESTION_XAC_NHAN_LUU_DU_LIEU))
                //    {
                //        load_data_2_m_variable();
                //        save_data();
                //        CHRM_BaseMessages.MsgBox_Infor(CONST_ID_MSGBOX.INFOR_LUU_DU_LIEU_THANH_CONG);
                //        m_trang_thai_buoc_4_thanh_cong = 1;
                //        F500_QUY_TRINH_THEM_MOI_NHAN_SU.done();
                //        if (m_trang_thai_them == -1)
                //        {
                //            this.Close();
                //        }
                //        load_data_2_grid(CIPConvert.ToDecimal(m_sle_chon_nhan_vien.EditValue));
                //    }
                //}
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_huy_kiem_nhiem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CHRM_BaseMessages.MsgBox_Confirm(CONST_ID_MSGBOX.QUESTION_XAC_NHAN_HUY_KIEM_NHIEM_CUA_NHAN_VIEN) == true)
                {
                    decimal v_id_gd_loai_ct = 0;

                    v_id_gd_loai_ct = CIPConvert.ToDecimal(m_grv_v_gd_cong_tac.GetRowCellValue(m_grv_v_gd_cong_tac.FocusedRowHandle, "ID"));

                    US_GD_CONG_TAC v_us = new US_GD_CONG_TAC(v_id_gd_loai_ct);
                    v_us.strDA_XOA = "Y";
                    v_us.BeginTransaction();
                    v_us.Update();
                    v_us.CommitTransaction();
                    load_data_2_grid(CIPConvert.ToDecimal(m_sle_chon_nhan_vien.EditValue), CIPConvert.ToDecimal(m_sle_chon_loai_cong_tac.EditValue));
                }

            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }


    }
}
