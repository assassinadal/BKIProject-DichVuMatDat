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
    public partial class f370_nhan_vien_loai_lao_dong : Form
    {
        public f370_nhan_vien_loai_lao_dong()
        {
            InitializeComponent();
            format_controls();
        }

        #region Public Interface
        private void display()
        {
            this.ShowDialog();
        }
        #endregion

        #region Members
        DataEntryFormMode m_e_form_mode = DataEntryFormMode.InsertDataState;
        decimal m_id_gd_loai_ld = 0;
        #endregion

        #region Private Methods

        private void format_controls()
        {
            set_define_event();
            this.KeyPreview = true;
        }

        private void set_initial_form_load()
        {
            load_data_2_grid();
            load_data_2_sle_chon_nv();
            load_data_2_sle_chon_loai_lao_dong();
        }

        private DataSet load_data_2_ds_v_dm_nv()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();

            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithTableName(v_ds, "V_DM_NHAN_VIEN");
            return v_ds;
        }

        private void load_data_2_sle_chon_nv()
        {
            m_sle_chon_nhan_vien.Properties.DataSource = load_data_2_ds_v_dm_nv().Tables[0];

            m_sle_chon_nhan_vien.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            m_sle_chon_nhan_vien.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
        }

        private DataSet load_data_2_cm_dm_tu_dien(int ip_dc_id_vt)
        {
            US_CM_DM_TU_DIEN v_us = new US_CM_DM_TU_DIEN();
            DS_CM_DM_TU_DIEN v_ds = new DS_CM_DM_TU_DIEN();

            v_us.FillDatasetByIdLoaiTuDien(v_ds, ip_dc_id_vt);
            return v_ds;
        }

        private void load_data_2_sle_chon_loai_lao_dong()
        {
            m_sle_chon_loai_lao_dong.Properties.DataSource = load_data_2_cm_dm_tu_dien(CONST_ID_LOAI_TU_DIEN.LOAI_LAO_DONG).Tables[0];

            m_sle_chon_nhan_vien.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            m_sle_chon_nhan_vien.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
        }

        //Load toan bo du lieu tu V_GD_LOAI_LAO_DONG len luoi 
        private void load_data_2_grid()
        {
            CCommon.make_stt(m_grv_v_gd_loai_lao_dong);
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();

            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithTableName(v_ds, "V_GD_LOAI_LAO_DONG");
            m_grc_v_gd_loai_lao_dong.DataSource = v_ds.Tables[0];
        }

        //Load du lieu len luoi theo id nhan vien
        private void load_data_2_grid(decimal ip_dc_id_nv)
        {
            CCommon.make_stt(m_grv_v_gd_loai_lao_dong);
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();

            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithQuery(v_ds, "Select * from V_GD_LOAI_LAO_DONG WHERE ID = " + ip_dc_id_nv);
            m_grc_v_gd_loai_lao_dong.DataSource = v_ds.Tables[0];
        }

        //Load du lieu len luoi theo id_loai_lao_dong
        private void load_data_2_grid_with_id_loai_lao_dong(decimal ip_dc_id_loai_ld)
        {
            CCommon.make_stt(m_grv_v_gd_loai_lao_dong);
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();

            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithQuery(v_ds, "Select * from V_GD_LOAI_LAO_DONG WHERE ID_LOAI_LAO_DONG = " + ip_dc_id_loai_ld);
            m_grc_v_gd_loai_lao_dong.DataSource = v_ds.Tables[0];
        }

        //Load du lieu len luoi theo id nhan vien va id loai lao dong
        private void load_data_2_grid(decimal ip_dc_id_nv, decimal ip_dc_id_loai_ld)
        {
            CCommon.make_stt(m_grv_v_gd_loai_lao_dong);

            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();

            v_ds.Tables.Add(new DataTable());

            v_us.FillDatasetWithQuery(v_ds, "select * from V_GD_LOAI_LAO_DONG WHere ID = " + ip_dc_id_nv + " AND ID_LOAI_LAO_DONG = " + ip_dc_id_loai_ld);
            m_grc_v_gd_loai_lao_dong.DataSource = v_ds.Tables[0];
        }

        //Clear data in form
        private void clear_data_in_form()
        {
            m_sle_chon_nhan_vien.EditValue = null;
            m_sle_chon_loai_lao_dong.EditValue = null;
        }

        #endregion

        private void f370_nhan_vien_loai_lao_dong_Load(object sender, EventArgs e)
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

        private void set_define_event()
        {
            this.Load += f370_nhan_vien_loai_lao_dong_Load;
        }

        

        

        private void m_cmd_insert_Click(object sender, EventArgs e)
        {
            try
            {
                f371_nhan_vien_loai_lao_dong_insert v_frm = new f371_nhan_vien_loai_lao_dong_insert();
                //v_frm.MdiChildren = this;
                v_frm.ShowDialog();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_edit_Click(object sender, EventArgs e)
        {

        }

        private void m_cmd_delete_Click(object sender, EventArgs e)
        {
            try
            {
                //Lay ID cua dong du lieu muon xoa
                DataRow v_dr = m_grv_v_gd_loai_lao_dong.GetDataRow(m_grv_v_gd_loai_lao_dong.FocusedRowHandle);
                //decimal v_id = CIPConvert.ToDecimal(v_dr[GD_LOAI_LAO_DONG.ID_NHAN_VIEN]);
                //decimal v_id_nv = CIPConvert.ToDecimal(m_grv_v_gd_loai_lao_dong.GetRowCellValue(m_grv_v_gd_loai_lao_dong.FocusedRowHandle, "ID"));
                decimal v_id = 0;
                US_GD_LOAI_LAO_DONG v_us = new US_GD_LOAI_LAO_DONG(v_id);
                if (XtraMessageBox.Show("Bạn có chắc chắn muốn XÓA nhân viên - loại lao động này?", "XÁC NHẬN LẠI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    v_us.Delete();
                    load_data_2_grid();
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
    }
}
