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
    public partial class f351_quan_ly_cong_tac_de : Form
    {
        public f351_quan_ly_cong_tac_de()
        {
            InitializeComponent();
            format_controls();
        }

        #region Public Methods
        public void display_4_update(decimal v_id_nhan_vien)
        {
            Text = "F351 - Sửa thông tin công tác cho nhân viên";
            m_lbl_header.Text = "SỬA THÔNG TIN CÔNG TÁC CHO NHÂN VIÊN";
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            m_id_gd_ct = find_id_gd_ct(v_id_nhan_vien);
            US_GD_CONG_TAC v_us = new US_GD_CONG_TAC(m_id_gd_ct);
            us_2_form(v_us);
            m_sle_chon_nhan_vien.Enabled = false;
            this.ShowDialog();
        }

        public void display_4_insert(ref decimal v_id_gd_cong_tac_moi_tao)
        {
            this.Text = "F351 - Thêm thông tin công tác cho nhân viên";
            m_lbl_header.Text = "THÊM THÔNG TIN CÔNG TÁC CHO NHÂN VIÊN";
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            this.ShowDialog();
            v_id_gd_cong_tac_moi_tao = m_id_gd_cong_tac_moi_tao;
        }

        public void display_for_insert_ct(decimal ip_dc_phong_ban)
        {
            Text = "THÊM MỚI CÔNG TÁC CHO NHÂN VIÊN";
            m_sle_chon_don_vi.EditValue = ip_dc_phong_ban;
            m_sle_chon_don_vi.ReadOnly = true;
            m_sle_chon_loai_cong_tac.EditValue = CONST_ID_LOAI_CONG_TAC.CHINH_THUC;
            m_sle_chon_loai_cong_tac.ReadOnly = true;
            load_data_2_sle_nhan_vien(load_danh_sach_nhan_vien_chua_co_cong_tac());
            ShowDialog();
        }

        #endregion

        #region Members
        DataEntryFormMode m_e_form_mode = DataEntryFormMode.InsertDataState;
        decimal m_id_gd_cong_tac_moi_tao = 0;
        decimal m_id_gd_ct = 0;
        bool m_loai_ctac_cthuc = false;
        #endregion

        #region Data structure

        #endregion

        #region Private Methods
        private void format_controls()
        {
            //FormatControl.SetVisibleSimpleButton(this);
            set_define_events();
            this.KeyPreview = true;
            CenterToScreen();
            set_init_form_load();
        }

        private void set_init_form_load()
        {
            //load_data_2_sle_chon_nv();
            load_data_2_sle_chon_quyet_dinh();
            load_data_2_sle_chon_don_vi();
            //load_data_2_sle_chon_vi_tri();
            load_data_2_sle_chon_loai_cong_tac();
            m_sle_chon_don_vi.EditValueChanged += m_sle_chon_don_vi_EditValueChanged;
        }

       
        //load data to all controls
        private void load_data_2_sle_nhan_vien(DataTable ip_source)
        {
            m_sle_chon_nhan_vien.Properties.DataSource = ip_source;

            m_sle_chon_nhan_vien.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            m_sle_chon_nhan_vien.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
        }
        private DataTable load_danh_sach_nhan_vien_chua_co_cong_tac()
        {
            US_GD_CONG_TAC v_us_ct = new US_GD_CONG_TAC();
            return v_us_ct.LayDanhSachNhanVienChuaCoCongTac();
        }
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
            US_DM_CHUC_VU v_us = new US_DM_CHUC_VU();
            DS_DM_CHUC_VU v_ds = new DS_DM_CHUC_VU();
            v_us.FillDataset(v_ds, " where id_don_vi = " + Convert.ToDecimal(m_sle_chon_don_vi.EditValue));
            m_sle_chon_vi_tri.Properties.DataSource = v_ds.Tables[0];

            m_sle_chon_vi_tri.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            m_sle_chon_vi_tri.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
        }

        private void load_data_2_sle_chon_loai_cong_tac()
        {
            m_sle_chon_loai_cong_tac.Properties.DataSource = load_data_2_cm_dm_tu_dien(CONST_ID_LOAI_TU_DIEN.LOAI_CONG_TAC).Tables[0];

            m_sle_chon_loai_cong_tac.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            m_sle_chon_loai_cong_tac.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
        }
        
        //
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

        private void us_2_form(US_GD_CONG_TAC ip_us)
        {
            m_sle_chon_nhan_vien.EditValue = ip_us.dcID_NHAN_VIEN;
            m_sle_chon_quyet_dinh.EditValue = ip_us.dcID_QUYET_DINH;
            m_sle_chon_loai_cong_tac.EditValue = ip_us.dcID_LOAI_CONG_TAC;
            m_sle_chon_don_vi.EditValue = ip_us.dcID_DON_VI;
            m_sle_chon_vi_tri.EditValue = ip_us.dcID_VI_TRI;
            m_dat_ngay_bat_dau.Value = ip_us.datNGAY_BAT_DAU;
            m_dat_ngay_ket_thuc.Value = ip_us.datNGAY_KET_THUC;
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
                v_us_gd_ct.Rollback();
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void cho_gd_ct_da_xoa_Y()
        {
            US_GD_CONG_TAC v_us = new US_GD_CONG_TAC(m_id_gd_ct);
            v_us.datNGAY_KET_THUC = m_dat_ngay_bat_dau.Value.AddDays(-1);
            v_us.strDA_XOA = "Y";
            v_us.BeginTransaction();
            v_us.Update();
            v_us.CommitTransaction();
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

        #endregion

        #region Events Handle
        private void set_define_events()
        {
            this.Load += f351_quan_ly_cong_tac_de_Load;
            this.FormClosed += f351_quan_ly_cong_tac_de_FormClosed;
            this.KeyDown += f351_quan_ly_cong_tac_de_KeyDown;
            m_cmd_save.Click += m_cmd_save_Click;
            m_cmd_exit.Click += m_cmd_exit_Click;
        }
        void m_sle_chon_don_vi_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                load_data_2_sle_chon_vi_tri();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void f351_quan_ly_cong_tac_de_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
                {
                    this.Close();
                }
                if (e.KeyCode == Keys.Enter)
                {
                    save_data();
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void f351_quan_ly_cong_tac_de_Load(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void f351_quan_ly_cong_tac_de_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                this.Dispose();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (check_data_is_ok() == true)
                {
                    load_data_2_m_variable();
                    save_data();
                    CHRM_BaseMessages.MsgBox_Infor(CONST_ID_MSGBOX.INFOR_LUU_DU_LIEU_THANH_CONG);
                    //F500_QUY_TRINH_THEM_MOI_NHAN_SU.done();
                    this.Close();
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_exit_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        #endregion

       
    }
}
