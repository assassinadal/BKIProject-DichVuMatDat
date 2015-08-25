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

namespace BKI_DichVuMatDat.NghiepVu
{
    public partial class f350_quan_ly_vi_tri_cong_tac : Form
    {
        public f350_quan_ly_vi_tri_cong_tac()
        {
            InitializeComponent();
        }

        #region Public Interface
        private void display()
        {
            this.ShowDialog();
        }
        #endregion

        #region Members
        DataEntryFormMode m_e_form_mode = DataEntryFormMode.InsertDataState;

        decimal m_if_insert_click = 1;
        #endregion

        #region Private Methods
        private void format_controls()
        {
            set_define_events();
            this.KeyPreview = true;
        }

        private void set_define_events()
        {
            this.Load += f350_quan_ly_vi_tri_cong_tac_Load;
            
            m_sle_chon_nhan_vien.EditValueChanged += m_sle_chon_nhan_vien_EditValueChanged;
            m_sle_chon_quyet_dinh.EditValueChanged += m_sle_chon_quyet_dinh_EditValueChanged;
            m_sle_chon_vi_tri.EditValueChanged += m_sle_chon_vi_tri_EditValueChanged;
            m_sle_chon_don_vi.EditValueChanged += m_sle_chon_don_vi_EditValueChanged;
            m_sle_chon_loai_cong_tac.EditValueChanged += m_sle_chon_loai_cong_tac_EditValueChanged;
            m_cmd_insert.Click += m_cmd_insert_Click;
        }

        private void set_initial_form_load()
        {
            load_data_2_sle_chon_nv();
            load_data_2_sle_chon_quyet_dinh();
            load_data_2_sle_chon_don_vi();
            load_data_2_sle_chon_vi_tri();
            load_data_2_sle_chon_loai_cong_tac();
        }

        //load data to all controls

        private DS_V_DM_NHAN_VIEN load_data_2_ds_v_dm_nv()
        {
            DS_V_DM_NHAN_VIEN v_ds = new DS_V_DM_NHAN_VIEN();
            US_V_DM_NHAN_VIEN v_us = new US_V_DM_NHAN_VIEN();
            v_us.FillDataset(v_ds);
            return v_ds;
        }

        private void load_data_2_sle_chon_nv()
        {
            m_sle_chon_nhan_vien.Properties.DataSource = load_data_2_ds_v_dm_nv().V_DM_NHAN_VIEN;
            m_sle_chon_nhan_vien.Properties.ValueMember = V_DM_NHAN_VIEN.ID;
            m_sle_chon_nhan_vien.Properties.DisplayMember = V_DM_NHAN_VIEN.HO_TEN;

            m_sle_chon_nhan_vien.Properties.PopulateViewColumns();
            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.ID].Visible = false;
            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.HO_DEM].Visible = false;
            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.TEN].Visible = false;
            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.DAN_TOC].Visible = false;
            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.CHUYEN_MON].Visible = false;
            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.DIA_CHI_TAM_TRU].Visible = false;
            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.DIA_CHI_THUONG_TRU].Visible = false;
            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.MA_SO_THUE_CA_NHAN].Visible = false;
            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.NAM_TOT_NGHIEP].Visible = false;
            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.NGAN_HANG].Visible = false;
            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.NGAY_CAP].Visible = false;
            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.NGAY_CAP_THE].Visible = false;
            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.NGAY_CHINH_THUC_TIEP_NHAN].Visible = false;
            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.NGAY_HET_HAN_THE].Visible = false;
            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.NGAY_TIEP_NHAN_VAO_TCT].Visible = false;
            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.NGAY_VAO_HANG_KHONG].Visible = false;
            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.NOI_CAP].Visible = false;
            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.NOI_SINH].Visible = false;
            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.QUE_QUAN].Visible = false;
            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.QUOC_TICH].Visible = false;
            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.SO_CMT].Visible = false;
            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.SO_TAI_KHOAN].Visible = false;
            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.TON_GIAO].Visible = false;
            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.TOT_NGHIEP_TAI].Visible = false;
            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.TRINH_DO_VAN_HOA].Visible = false;
            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.NGAY_SINH].Visible = false;
            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.HON_NHAN].Visible = false;

            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.MA_NV].Width = 75;
            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.HO_TEN].Width = 120;

            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.MA_NV].Caption = "Mã NV";
            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.HO_TEN].Caption = "Họ tên";
            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.GIOI_TINH].Caption = "Giới tính";
            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.SDT].Caption = "SĐT";
            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.EMAIL].Caption = "Email";
            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.DIA_CHI_LIEN_LAC].Caption = "Địa chị liên lạc";

            m_sle_chon_nhan_vien.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            m_sle_chon_nhan_vien.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
        }

        private DS_V_GD_QUYET_DINH load_data_2_ds_v_gd_quyet_dinh()
        {
            DS_V_GD_QUYET_DINH v_ds = new DS_V_GD_QUYET_DINH();
            US_V_GD_QUYET_DINH v_us = new US_V_GD_QUYET_DINH();

            v_us.FillDataset(v_ds);
            return v_ds;
        }

        private void load_data_2_sle_chon_quyet_dinh()
        {
            m_sle_chon_quyet_dinh.Properties.DataSource = load_data_2_ds_v_gd_quyet_dinh().V_GD_QUYET_DINH;
            m_sle_chon_quyet_dinh.Properties.DisplayMember = V_GD_QUYET_DINH.MA_QUYET_DINH;
            m_sle_chon_quyet_dinh.Properties.ValueMember = V_GD_QUYET_DINH.ID;

            m_sle_chon_quyet_dinh.Properties.PopulateViewColumns();
            m_sle_chon_quyet_dinh.Properties.View.Columns[V_GD_QUYET_DINH.ID].Visible = false;
            m_sle_chon_quyet_dinh.Properties.View.Columns[V_GD_QUYET_DINH.ID_LOAI_QD].Visible = false;
            m_sle_chon_quyet_dinh.Properties.View.Columns[V_GD_QUYET_DINH.MA_TU_DIEN].Visible = false;
            m_sle_chon_quyet_dinh.Properties.View.Columns[V_GD_QUYET_DINH.TEN_NGAN].Visible = false;

            m_sle_chon_quyet_dinh.Properties.View.Columns[V_GD_QUYET_DINH.MA_QUYET_DINH].Caption = "Mã quyết định";
            m_sle_chon_quyet_dinh.Properties.View.Columns[V_GD_QUYET_DINH.TEN].Caption = "Loại quyết định";
            m_sle_chon_quyet_dinh.Properties.View.Columns[V_GD_QUYET_DINH.NGAY_CO_HIEU_LUC].Caption = "Ngày có hiệu lực";
            m_sle_chon_quyet_dinh.Properties.View.Columns[V_GD_QUYET_DINH.NGAY_HET_HIEU_LUC].Caption = "Ngày hết hiệu lực";
            m_sle_chon_quyet_dinh.Properties.View.Columns[V_GD_QUYET_DINH.NGAY_KY].Caption = "Ngày ký";
            m_sle_chon_quyet_dinh.Properties.View.Columns[V_GD_QUYET_DINH.NOI_DUNG].Caption = "Nội dung";
            m_sle_chon_quyet_dinh.Properties.View.Columns[V_GD_QUYET_DINH.LINK].Caption = "Link";

            m_sle_chon_quyet_dinh.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
        }

        private DS_CM_DM_TU_DIEN load_data_2_cm_dm_tu_dien(int m_id_vt)
        {
            DS_CM_DM_TU_DIEN v_ds = new DS_CM_DM_TU_DIEN();
            US_CM_DM_TU_DIEN v_us = new US_CM_DM_TU_DIEN();

            v_us.FillDatasetByIdLoaiTuDien(v_ds, m_id_vt);

            return v_ds;
        }

        private void load_data_2_sle_chon_don_vi()
        {
            m_sle_chon_don_vi.Properties.DataSource = load_data_2_cm_dm_tu_dien(CONST_ID_LOAI_TU_DIEN.LOAI_DON_VI).CM_DM_TU_DIEN;
            m_sle_chon_don_vi.Properties.ValueMember = CM_DM_TU_DIEN.ID;
            m_sle_chon_don_vi.Properties.DisplayMember = CM_DM_TU_DIEN.TEN;

            m_sle_chon_don_vi.Properties.PopulateViewColumns();
            m_sle_chon_don_vi.Properties.View.Columns[CM_DM_TU_DIEN.ID].Visible = false;
            m_sle_chon_don_vi.Properties.View.Columns[CM_DM_TU_DIEN.ID_LOAI_TU_DIEN].Visible = false;
            m_sle_chon_don_vi.Properties.View.Columns[CM_DM_TU_DIEN.TEN_NGAN].Visible = false;

            m_sle_chon_don_vi.Properties.View.Columns[CM_DM_TU_DIEN.MA_TU_DIEN].Width = 75;
            m_sle_chon_don_vi.Properties.View.Columns[CM_DM_TU_DIEN.TEN].Width = 120;

            m_sle_chon_don_vi.Properties.View.Columns[CM_DM_TU_DIEN.MA_TU_DIEN].Caption = "Mã đơn vị";
            m_sle_chon_don_vi.Properties.View.Columns[CM_DM_TU_DIEN.TEN].Caption = "Đơn vị";
            m_sle_chon_don_vi.Properties.View.Columns[CM_DM_TU_DIEN.GHI_CHU].Caption = "Ghi chú";

            m_sle_chon_don_vi.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            m_sle_chon_don_vi.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
        }

        private void load_data_2_sle_chon_vi_tri()
        {
            m_sle_chon_vi_tri.Properties.DataSource = load_data_2_cm_dm_tu_dien(CONST_ID_LOAI_TU_DIEN.LOAI_VI_TRI).CM_DM_TU_DIEN;
            m_sle_chon_vi_tri.Properties.ValueMember = CM_DM_TU_DIEN.ID;
            m_sle_chon_vi_tri.Properties.DisplayMember = CM_DM_TU_DIEN.TEN;

            m_sle_chon_vi_tri.Properties.PopulateViewColumns();
            m_sle_chon_vi_tri.Properties.View.Columns[CM_DM_TU_DIEN.ID].Visible = false;
            m_sle_chon_vi_tri.Properties.View.Columns[CM_DM_TU_DIEN.ID_LOAI_TU_DIEN].Visible = false;
            m_sle_chon_vi_tri.Properties.View.Columns[CM_DM_TU_DIEN.TEN_NGAN].Visible = false;

            m_sle_chon_vi_tri.Properties.View.Columns[CM_DM_TU_DIEN.MA_TU_DIEN].Width = 75;
            m_sle_chon_vi_tri.Properties.View.Columns[CM_DM_TU_DIEN.TEN].Width = 120;

            m_sle_chon_vi_tri.Properties.View.Columns[CM_DM_TU_DIEN.MA_TU_DIEN].Caption = "Mã vị trí";
            m_sle_chon_vi_tri.Properties.View.Columns[CM_DM_TU_DIEN.TEN].Caption = "Vị trí";
            m_sle_chon_vi_tri.Properties.View.Columns[CM_DM_TU_DIEN.GHI_CHU].Caption = "Ghi chú";

            m_sle_chon_vi_tri.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            m_sle_chon_vi_tri.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
        }

        private void load_data_2_sle_chon_loai_cong_tac()
        {
            m_sle_chon_loai_cong_tac.Properties.DataSource = load_data_2_cm_dm_tu_dien(CONST_ID_LOAI_TU_DIEN.LOAI_CONG_TAC).CM_DM_TU_DIEN;
            m_sle_chon_loai_cong_tac.Properties.ValueMember = CM_DM_TU_DIEN.ID;
            m_sle_chon_loai_cong_tac.Properties.DisplayMember = CM_DM_TU_DIEN.TEN;

            m_sle_chon_loai_cong_tac.Properties.PopulateViewColumns();
            m_sle_chon_loai_cong_tac.Properties.View.Columns[CM_DM_TU_DIEN.ID].Visible = false;
            m_sle_chon_loai_cong_tac.Properties.View.Columns[CM_DM_TU_DIEN.ID_LOAI_TU_DIEN].Visible = false;
            m_sle_chon_loai_cong_tac.Properties.View.Columns[CM_DM_TU_DIEN.TEN_NGAN].Visible = false;

            m_sle_chon_loai_cong_tac.Properties.View.Columns[CM_DM_TU_DIEN.MA_TU_DIEN].Width = 75;
            m_sle_chon_loai_cong_tac.Properties.View.Columns[CM_DM_TU_DIEN.TEN].Width = 120;

            m_sle_chon_loai_cong_tac.Properties.View.Columns[CM_DM_TU_DIEN.MA_TU_DIEN].Caption = "Mã loại công tác";
            m_sle_chon_loai_cong_tac.Properties.View.Columns[CM_DM_TU_DIEN.TEN].Caption = "Loại công tác";
            m_sle_chon_loai_cong_tac.Properties.View.Columns[CM_DM_TU_DIEN.GHI_CHU].Caption = "Ghi chú";

            m_sle_chon_loai_cong_tac.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            m_sle_chon_loai_cong_tac.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
        }

        private void load_data_2_grid(decimal ip_dc_id_nv)
        {
            CCommon.make_stt(m_grv_v_gd_cong_tac);
            DS_V_GD_CONG_TAC v_ds = new DS_V_GD_CONG_TAC();
            US_V_GD_CONG_TAC v_us = new US_V_GD_CONG_TAC();

            v_us.FillDataset(v_ds, "WHERE ID = " + ip_dc_id_nv);
            m_grc_v_gd_cong_tac.DataSource = v_ds.Tables[0];
        }

        //Check validate data
        private bool check_data_is_ok()
        {
            if (m_sle_chon_nhan_vien.EditValue == null || m_sle_chon_nhan_vien.EditValue == "")
            {
                MessageBox.Show("Bạn phải chọn nhân viên", "THÔNG BÁO!");
                return false;
            }
            //GD quyet dinh dang chua co du lieu
            //if (m_sle_chon_quyet_dinh.EditValue == null || m_sle_chon_quyet_dinh.EditValue == "")
            //{
            //    MessageBox.Show("Bạn phải chọn quyết định", "THÔNG BÁO!");
            //    return false;
            //}
            if (m_sle_chon_don_vi.EditValue == null || m_sle_chon_don_vi.EditValue == "")
            {
                MessageBox.Show("Bạn phải chọn đơn vị", "THÔNG BÁO!");
                return false;
            }

            if (m_sle_chon_vi_tri.EditValue == null || m_sle_chon_vi_tri.EditValue == "")
            {
                MessageBox.Show("Bạn phải chọn vị trí", "THÔNG BÁO!");
                return false;
            }

            if (m_sle_chon_loai_cong_tac.EditValue == null || m_sle_chon_loai_cong_tac.EditValue == "")
            {
                MessageBox.Show("Bạn phải chọn loại công tác", "THÔNG BÁO!");
                return false;
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
            m_sle_chon_loai_cong_tac = null;

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

            if (m_e_form_mode == DataEntryFormMode.InsertDataState)
            {
                //Ngay lap
                ip_us.datNGAY_LAP = DateTime.Now.Date;
            }
            else if (m_e_form_mode == DataEntryFormMode.UpdateDataState)
            {
                //Ngay sua
                ip_us.datNGAY_SUA = DateTime.Now.Date;
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
        #endregion
        
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
                    return;
                }
                    load_data_2_grid(CIPConvert.ToDecimal(m_sle_chon_nhan_vien.EditValue));
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_sle_chon_quyet_dinh_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (m_sle_chon_quyet_dinh.EditValue == null || m_sle_chon_quyet_dinh.EditValue == "")
                {
                    return;
                }
                load_data_2_grid(CIPConvert.ToDecimal(m_sle_chon_quyet_dinh.EditValue));
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_sle_chon_don_vi_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (m_sle_chon_don_vi.EditValue == null || m_sle_chon_don_vi.EditValue == "")
                {
                    return;
                }
                load_data_2_grid(CIPConvert.ToDecimal(m_sle_chon_don_vi.EditValue));
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_sle_chon_vi_tri_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (m_sle_chon_vi_tri.EditValue == null || m_sle_chon_vi_tri.EditValue == "")
                {
                    return;
                }
                load_data_2_grid(CIPConvert.ToDecimal(m_sle_chon_vi_tri.EditValue));
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_sle_chon_loai_cong_tac_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (m_sle_chon_loai_cong_tac.EditValue == null || m_sle_chon_loai_cong_tac.EditValue == "")
                {
                    return;
                }
                load_data_2_grid(CIPConvert.ToDecimal(m_sle_chon_loai_cong_tac.EditValue));
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
                m_if_insert_click = 1;
                clear_data_in_form();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
    }
}
