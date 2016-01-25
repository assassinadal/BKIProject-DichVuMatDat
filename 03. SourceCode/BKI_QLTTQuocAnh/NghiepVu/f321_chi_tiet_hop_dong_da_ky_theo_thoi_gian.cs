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
using BKI_DichVuMatDat.US;
using IP.Core.IPCommon;
using BKI_DichVuMatDat.DS.CDBNames;
using DevExpress.XtraEditors;
using System.Globalization;
using IP.Core.IPSystemAdmin;

namespace BKI_DichVuMatDat.NghiepVu
{
    public partial class f321_chi_tiet_hop_dong_da_ky_theo_thoi_gian : Form
    {
        public f321_chi_tiet_hop_dong_da_ky_theo_thoi_gian()
        {
            InitializeComponent();
            format_controls();
        }

        #region Public Interface
        public void display_from_f320_v2(
                            decimal ip_dc_id_nhan_vien
                            , DateTime ip_dat_tu_ngay
                            , DateTime ip_dat_den_ngay)
        {
            if (ip_dc_id_nhan_vien != -1)
            {
                m_sle_chon_nhan_vien.EditValue = ip_dc_id_nhan_vien;
            }
            else
            {
                m_sle_chon_nhan_vien.EditValue = null;
            }
            m_dat_tu_ngay.EditValue = ip_dat_tu_ngay;
            m_dat_den_ngay.EditValue = ip_dat_den_ngay;
            load_data_2_grid();
            this.CenterToScreen();
            this.ShowDialog();
        }

        #endregion

        #region Member 
        decimal m_xem_du_lieu_toan_bo_nv = 0;
        #endregion 

        #region Private Methods
        private void format_controls()
        {
            FormatControl.SetVisibleSimpleButton(this);
            this.m_grv_chi_tiet_hop_dong.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(WinFormControls.m_grv_PopupMenuShowing);
            this.m_grv_chi_tiet_hop_dong.OptionsPrint.AutoWidth = false;
            set_define_events();
            this.KeyPreview = true;
        }

        private void set_init_form_load()
        {
            load_data_2_sle_chon_nv();
        }

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
            m_sle_chon_nhan_vien.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            m_sle_chon_nhan_vien.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
        }

        private void load_data_2_grid()
        {
            CHRMCommon.make_stt(m_grv_chi_tiet_hop_dong);
            US_V_F320_THONG_TIN_CHI_TIET_DANH_SACH_HOP_DONG_DA_KY_THEO_THOI_GIAN v_us = new US_V_F320_THONG_TIN_CHI_TIET_DANH_SACH_HOP_DONG_DA_KY_THEO_THOI_GIAN();
            DS_V_F320_THONG_TIN_CHI_TIET_DANH_SACH_HOP_DONG_DA_KY_THEO_THOI_GIAN v_ds = new DS_V_F320_THONG_TIN_CHI_TIET_DANH_SACH_HOP_DONG_DA_KY_THEO_THOI_GIAN();


            if (m_sle_chon_nhan_vien.EditValue == null)
            {
                m_xem_du_lieu_toan_bo_nv = 1;
                v_us.FillDataset_by_id_nhan_vien_tu_ngay_den_ngay(
                                    v_ds
                                    , m_xem_du_lieu_toan_bo_nv
                                    , m_dat_tu_ngay.DateTime.Date
                                    , m_dat_den_ngay.DateTime.Date);
                m_grc_chi_tiet_hop_dong.DataSource = v_ds.Tables[0];
            }
            else
            {
                v_us.FillDataset_by_id_nhan_vien_tu_ngay_den_ngay(
                                    v_ds
                                    , (decimal)m_sle_chon_nhan_vien.EditValue
                                    , m_dat_tu_ngay.DateTime.Date
                                    , m_dat_den_ngay.DateTime.Date);
            }
            
            m_grc_chi_tiet_hop_dong.DataSource = v_ds.Tables[0];
        }
        #endregion

        #region Events Handle
        private void set_define_events()
        {
            this.Load += f321_chi_tiet_hop_dong_da_ky_theo_thoi_gian_Load;
            this.FormClosed += f321_chi_tiet_hop_dong_da_ky_theo_thoi_gian_FormClosed;

            m_cmd_search.Click += m_cmd_search_Click;
            m_cmd_xuat_excel.Click += m_cmd_xuat_excel_Click;
        }

        void m_cmd_xuat_excel_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "xls files (*.xls)|*.xls|All files (*.*)|*.*";
                saveFileDialog1.RestoreDirectory = true;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    m_grv_chi_tiet_hop_dong.ExportToXls(saveFileDialog1.FileName);
                    CHRM_BaseMessages.MsgBox_Infor(CONST_ID_MSGBOX.INFOR_LUU_BAO_CAO_THANH_CONG);
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_search_Click(object sender, EventArgs e)
        {
            try
            {
                load_data_2_grid();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void f321_chi_tiet_hop_dong_da_ky_theo_thoi_gian_FormClosed(object sender, FormClosedEventArgs e)
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

        void f321_chi_tiet_hop_dong_da_ky_theo_thoi_gian_Load(object sender, EventArgs e)
        {
            try
            {
                set_init_form_load();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        #endregion

    }
}
