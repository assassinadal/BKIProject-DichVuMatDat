using BKI_DichVuMatDat.DS;
using BKI_DichVuMatDat.DS.CDBNames;
using BKI_DichVuMatDat.US;
using DevExpress.XtraEditors;
using IP.Core.IPCommon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BKI_DichVuMatDat.NghiepVu
{
    public partial class f357_bao_cao_trang_thai_lao_dong_nhan_vien_de : Form
    {
        #region Public interface
        public void display_4_insert(ref decimal v_id_gd_trang_thai_lao_dong_moi_tao)
        {
            this.Text = "F357 - THAY ĐỔI TRẠNG THÁI LAO ĐỘNG CỦA NHÂN VIÊN";
            m_lbl_header.Text = "Thay đổi trạng thái lao động của nhân viên";
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            this.CenterToScreen();
            this.ShowDialog();

            v_id_gd_trang_thai_lao_dong_moi_tao = m_id_gd_trang_thai_lao_dong_moi_tao;
        }
        #endregion

        #region Member
        DataEntryFormMode m_e_form_mode = DataEntryFormMode.InsertDataState;
        decimal m_id_gd_trang_thai_lao_dong_moi_tao = 0;
        #endregion

        #region Private methods
        public f357_bao_cao_trang_thai_lao_dong_nhan_vien_de()
        {
            InitializeComponent();
            format_controls();
        }

        private void format_controls()
        {
            FormatControl.SetVisibleSimpleButton(this);
            set_define_events();
            this.KeyPreview = true;
        }

        private void set_init_form_load()
        {
            load_data_2_sle_chon_nhan_vien();
            load_data_2_sle_chon_trang_thai_lao_dong();
            m_dat_ngay_ap_dung.EditValue = DateTime.Now.Date;
        }

        private DS_V_DM_NHAN_VIEN load_data_2_ds_v_dm_nv()
        {
            DS_V_DM_NHAN_VIEN v_ds = new DS_V_DM_NHAN_VIEN();
            US_V_DM_NHAN_VIEN v_us = new US_V_DM_NHAN_VIEN();

            v_us.FillDataset(v_ds);
            return v_ds;
        }

        private void load_data_2_sle_chon_nhan_vien()
        {
            m_sle_chon_nhan_vien.Properties.DataSource = load_data_2_ds_v_dm_nv().V_DM_NHAN_VIEN;
            m_sle_chon_nhan_vien.Properties.ValueMember = V_DM_NHAN_VIEN.ID;
            m_sle_chon_nhan_vien.Properties.DisplayMember = V_DM_NHAN_VIEN.HO_TEN;

            m_sle_chon_nhan_vien.Properties.PopulateViewColumns();
            m_sle_chon_nhan_vien.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            m_sle_chon_nhan_vien.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
        }

        private void load_data_2_sle_chon_trang_thai_lao_dong()
        {
            throw new NotImplementedException();
        }
        #endregion

        private void set_define_events()
        {
            this.Load += f357_bao_cao_trang_thai_lao_dong_nhan_vien_de_Load;
        }

        void f357_bao_cao_trang_thai_lao_dong_nhan_vien_de_Load(object sender, EventArgs e)
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

        
    }
}
