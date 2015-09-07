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

using DevExpress.XtraEditors;
using System.Globalization;

namespace BKI_DichVuMatDat.DanhMuc
{
    public partial class F150_dm_nhan_vien : Form
    {
        public F150_dm_nhan_vien()
        {
            InitializeComponent();
            format_controls();
        }

        #region Pulic Interface

        #endregion

        #region Members

        #endregion

        #region Private Methods

        private void format_controls()
        {
            set_define_events();
            this.KeyPreview = true;
        }

        private void set_define_events()
        {
            this.Load += F150_dm_nhan_vien_Load;
        }

        private void set_initial_form_load()
        {
            load_data_to_sle_chon_nhan_vien();
        }

        private void load_data_to_sle_chon_nhan_vien()
        {
            m_sle_chon_nhan_vien.Properties.DataSource = load_data_2_ds_v_dm_nv().Tables[0];

            m_sle_chon_nhan_vien.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            m_sle_chon_nhan_vien.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
        }

        private DataSet load_data_2_ds_v_dm_nv()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();

            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithTableName(v_ds, "V_DM_NHAN_VIEN");
            return v_ds;
        }

        private void load_data_to_all_controls(decimal ip_dc_id_nv)
        {
            US_DM_NHAN_VIEN v_us_nv = new US_DM_NHAN_VIEN(ip_dc_id_nv);
            m_lbl_ma_nv.Text = v_us_nv.strMA_NV;

            decimal v_id_gd_ct = find_id_gd_ct(ip_dc_id_nv);
            
            if (v_id_gd_ct != -1)
            {
                US_V_GD_CONG_TAC v_us_ct = new US_V_GD_CONG_TAC(v_id_gd_ct);
                m_lbl_vi_tri.Text = v_us_ct.strTEN_VI_TRI;
                m_lbl_don_vi.Text = v_us_ct.strTEN_DON_VI;
            }
            else
            {
                m_lbl_vi_tri.Text = "Chưa có";
                m_lbl_don_vi.Text = "Chưa có";
            }

        }

        private decimal find_id_gd_ct(decimal ip_dc_id_nv)
        {
            US_V_GD_CONG_TAC v_us = new US_V_GD_CONG_TAC();
            DS_V_GD_CONG_TAC v_ds = new DS_V_GD_CONG_TAC();

            v_us.FillDataset(v_ds);
            string v_str_filter = "ID_NHAN_VIEN = " + ip_dc_id_nv + " AND ID_LOAI_CONG_TAC = " + CONST_ID_LOAI_CONG_TAC.CHINH_THUC;

            DataRow[] v_dr = v_ds.V_GD_CONG_TAC.Select(v_str_filter);

            if (v_dr.Count() == 0)
            {
                return -1;
            }
            else
            {
                return CIPConvert.ToDecimal(v_dr.First()["ID"].ToString());
            }
        }

        private void F150_dm_nhan_vien_Load(object sender, EventArgs e)
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
        #endregion

        private void m_sle_chon_nhan_vien_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (m_sle_chon_nhan_vien.EditValue == null || m_sle_chon_nhan_vien.EditValue == "")
                {
                    return;
                }
                else
                {
                    load_data_to_all_controls(CIPConvert.ToDecimal(m_sle_chon_nhan_vien.EditValue));
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
    }
}
