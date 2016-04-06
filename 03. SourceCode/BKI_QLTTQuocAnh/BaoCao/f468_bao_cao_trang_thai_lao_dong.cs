﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IP.Core.IPCommon;
using BKI_DichVuMatDat.US;
using BKI_DichVuMatDat.DS;
using DevExpress.XtraEditors;
using IP.Core.IPSystemAdmin;
using BKI_DichVuMatDat.DS.CDBNames;

namespace BKI_DichVuMatDat
{
    public partial class f468_bao_cao_trang_thai_lao_dong : Form
    {
        public f468_bao_cao_trang_thai_lao_dong()
        {
            InitializeComponent();
            format_controls();
        }
        #region Public Interface

        #endregion

        #region Members
        DateTime m_dat_ngay_goi_y = DateTime.Now.Date;
        DS_V_F468_BAO_CAO_TRANG_THAI_LAO_DONG_THEO_THANG m_vs = new DS_V_F468_BAO_CAO_TRANG_THAI_LAO_DONG_THEO_THANG();
        US_V_F468_BAO_CAO_TRANG_THAI_LAO_DONG_THEO_THANG m_us = new US_V_F468_BAO_CAO_TRANG_THAI_LAO_DONG_THEO_THANG();
        string m_str_trang_thai = "";
        string m_str_thang_nam = "";
        #endregion

        #region Private Methods

        private void format_controls()
        {
            FormatControl.SetVisibleSimpleButton(this);
            this.m_grv_trang_thai_lao_dong.OptionsPrint.AutoWidth = false;
            set_define_events();
            this.KeyPreview = true;
        }

        private void set_init_form_load()
        {
            load_data_2_sle_chon_trang_thai_lao_dong();
            m_dat_thang.EditValue = m_dat_ngay_goi_y;
        }


        private DS_V_DM_TRANG_THAI_LAO_DONG load_data_2_ds_v_dm_trang_thai_ld()
        {
            DS_V_DM_TRANG_THAI_LAO_DONG v_ds = new DS_V_DM_TRANG_THAI_LAO_DONG();
            US_V_DM_TRANG_THAI_LAO_DONG v_us = new US_V_DM_TRANG_THAI_LAO_DONG();

            v_us.FillDataset(v_ds);
            return v_ds;
        }

        private void load_data_2_sle_chon_trang_thai_lao_dong()
        {
            m_sle_chon_trang_thai_lao_dong.Properties.DataSource = load_data_2_ds_v_dm_trang_thai_ld().V_DM_TRANG_THAI_LAO_DONG;
            m_sle_chon_trang_thai_lao_dong.Properties.ValueMember = V_DM_TRANG_THAI_LAO_DONG.ID;
            m_sle_chon_trang_thai_lao_dong.Properties.DisplayMember = V_DM_TRANG_THAI_LAO_DONG.TEN_TRANG_THAI_LD;

            m_sle_chon_trang_thai_lao_dong.Properties.PopulateViewColumns();
            m_sle_chon_trang_thai_lao_dong.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            m_sle_chon_trang_thai_lao_dong.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
        }

        private void load_data_2_sle_chon_trang_thai_lao_dong(decimal id_loai_trang_thai)
        {
            m_sle_chon_trang_thai_lao_dong.Properties.DataSource = load_data_2_ds_v_dm_trang_thai_ld().V_DM_TRANG_THAI_LAO_DONG.Where(s => s.ID_LOAI_TRANG_THAI_LD == id_loai_trang_thai).ToList();
            m_sle_chon_trang_thai_lao_dong.Properties.ValueMember = V_DM_TRANG_THAI_LAO_DONG.ID;
            m_sle_chon_trang_thai_lao_dong.Properties.DisplayMember = V_DM_TRANG_THAI_LAO_DONG.TEN_TRANG_THAI_LD;

            m_sle_chon_trang_thai_lao_dong.Properties.PopulateViewColumns();
            m_sle_chon_trang_thai_lao_dong.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            m_sle_chon_trang_thai_lao_dong.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
        }

        private void load_data_2_grid_theo_trang_thai(decimal id_trang_thai, DateTime dau_thang, DateTime cuoi_thang)
        {
            CHRMCommon.make_stt(m_grv_trang_thai_lao_dong);
            DS_V_F468_BAO_CAO_TRANG_THAI_LAO_DONG_THEO_THANG v_ds_468 = new DS_V_F468_BAO_CAO_TRANG_THAI_LAO_DONG_THEO_THANG();
            US_V_F468_BAO_CAO_TRANG_THAI_LAO_DONG_THEO_THANG v_us_468 = new US_V_F468_BAO_CAO_TRANG_THAI_LAO_DONG_THEO_THANG();
            v_us_468.FillDataset_by_thang_nam_and_id_trang_thai_ld(v_ds_468, dau_thang, cuoi_thang, id_trang_thai);
            m_grc_trang_thai_lao_dong.DataSource = v_ds_468.Tables[0];
        }

        private void focus_new_row_created(decimal ip_dc_id_gd_trang_thai_lao_dong_moi_tao)
        {
            int v_row_index = 0;
            decimal v_id_gd_trang_thai_lao_dong_moi_tao = 0;

            US_V_F356_BAO_CAO_TRANG_THAI_LAO_DONG_CUA_NHAN_VIEN v_us = new US_V_F356_BAO_CAO_TRANG_THAI_LAO_DONG_CUA_NHAN_VIEN();
            DS_V_F356_BAO_CAO_TRANG_THAI_LAO_DONG_CUA_NHAN_VIEN v_ds = new DS_V_F356_BAO_CAO_TRANG_THAI_LAO_DONG_CUA_NHAN_VIEN();

            v_id_gd_trang_thai_lao_dong_moi_tao = ip_dc_id_gd_trang_thai_lao_dong_moi_tao;

            v_us.FillDataset(v_ds);

            for (v_row_index = 0; v_row_index < v_ds.Tables[0].Rows.Count; v_row_index++)
            {
                var v_id_gd_trang_thai_lao_dong = CIPConvert.ToDecimal(m_grv_trang_thai_lao_dong.GetDataRow(v_row_index)["ID"].ToString());

                if (v_id_gd_trang_thai_lao_dong == v_id_gd_trang_thai_lao_dong_moi_tao)
                {
                    break;
                }
            }

            m_grv_trang_thai_lao_dong.FocusedRowHandle = v_row_index;
        }

        #endregion

        private void set_define_events()
        {
            this.Load += f468_bao_cao_trang_thai_lao_dong_cua_nhan_vien_Load;
            this.FormClosed += f356_bao_cao_trang_thai_lao_dong_cua_nhan_vien_FormClosed;
            m_cmd_search.Click += m_cmd_search_Click;
            m_cmd_xuat_excel.Click += m_cmd_xuat_excel_Click;
        }

        void m_cmd_xuat_excel_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "xls files (*.xls)|*.xls|All files (*.*)|*.*";
                saveFileDialog1.FileName = "Danh sách nhân viên chuyển trạng thái sang " + m_str_trang_thai + " trong tháng " + m_str_thang_nam;
                saveFileDialog1.RestoreDirectory = true;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    m_grv_trang_thai_lao_dong.ExportToXls(saveFileDialog1.FileName);
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
                if (m_dat_thang.DateTime == null)
                {
                    CHRM_BaseMessages.MsgBox_Error("Bạn vui lòng chọn tháng");
                    return;
                }
                DateTime v_dau_thang = CHRMCommon.get_first_day_of_month(m_dat_thang.DateTime);
                DateTime v_cuoi_thang = CHRMCommon.get_last_day_of_month(m_dat_thang.DateTime);
                if (m_sle_chon_trang_thai_lao_dong.EditValue == null)
                {
                    CHRM_BaseMessages.MsgBox_Error("Bạn vui lòng chọn trạng thái");
                    return;
                }
                decimal id_tt_lao_dong = CIPConvert.ToDecimal(m_sle_chon_trang_thai_lao_dong.EditValue.ToString());
                load_data_2_grid_theo_trang_thai(id_tt_lao_dong, v_dau_thang, v_cuoi_thang);
                m_str_trang_thai = m_sle_chon_trang_thai_lao_dong.Text;
                m_str_thang_nam = m_dat_thang.DateTime.Month.ToString() + "/" + m_dat_thang.DateTime.Year.ToString();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void f356_bao_cao_trang_thai_lao_dong_cua_nhan_vien_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Dispose();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void f468_bao_cao_trang_thai_lao_dong_cua_nhan_vien_Load(object sender, EventArgs e)
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
