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
            FormatControl.SetVisibleSimpleButton(this);
            this.m_grv_v_gd_loai_lao_dong.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(WinFormControls.m_grv_PopupMenuShowing);
            this.m_grv_v_gd_loai_lao_dong.OptionsPrint.AutoWidth = false;
            set_define_event();
            this.KeyPreview = true;
        }

        private void set_initial_form_load()
        {
            load_data_2_grid();
        }

        private DataSet load_data_2_ds_v_dm_nv()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();

            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithTableName(v_ds, "V_DM_NHAN_VIEN");
            return v_ds;
        }

        private DataSet load_data_2_cm_dm_tu_dien(int ip_dc_id_vt)
        {
            US_CM_DM_TU_DIEN v_us = new US_CM_DM_TU_DIEN();
            DS_CM_DM_TU_DIEN v_ds = new DS_CM_DM_TU_DIEN();

            v_us.FillDatasetByIdLoaiTuDien(v_ds, ip_dc_id_vt);
            return v_ds;
        }

        //Load toan bo du lieu tu V_GD_LOAI_LAO_DONG len luoi 
        private void load_data_2_grid()
        {
            CHRMCommon.make_stt(m_grv_v_gd_loai_lao_dong);
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();

            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithTableName(v_ds, "V_GD_LOAI_LAO_DONG");
            m_grc_v_gd_loai_lao_dong.DataSource = v_ds.Tables[0];
        }

        //Load du lieu len luoi theo id nhan vien
        private void load_data_2_grid(decimal ip_dc_id_nv)
        {
            CHRMCommon.make_stt(m_grv_v_gd_loai_lao_dong);
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();

            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithQuery(v_ds, "Select * from V_GD_LOAI_LAO_DONG WHERE ID = " + ip_dc_id_nv);
            m_grc_v_gd_loai_lao_dong.DataSource = v_ds.Tables[0];
        }

        //Load du lieu len luoi theo id_loai_lao_dong
        private void load_data_2_grid_with_id_loai_lao_dong(decimal ip_dc_id_loai_ld)
        {
            CHRMCommon.make_stt(m_grv_v_gd_loai_lao_dong);
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();

            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithQuery(v_ds, "Select * from V_GD_LOAI_LAO_DONG WHERE ID_LOAI_LAO_DONG = " + ip_dc_id_loai_ld);
            m_grc_v_gd_loai_lao_dong.DataSource = v_ds.Tables[0];
        }

        //Load du lieu len luoi theo id nhan vien va id loai lao dong
        private void load_data_2_grid(decimal ip_dc_id_nv, decimal ip_dc_id_loai_ld)
        {
            CHRMCommon.make_stt(m_grv_v_gd_loai_lao_dong);

            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();

            v_ds.Tables.Add(new DataTable());

            v_us.FillDatasetWithQuery(v_ds, "select * from V_GD_LOAI_LAO_DONG WHere ID = " + ip_dc_id_nv + " AND ID_LOAI_LAO_DONG = " + ip_dc_id_loai_ld);
            m_grc_v_gd_loai_lao_dong.DataSource = v_ds.Tables[0];
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
                f371_nhan_vien_loai_lao_dong_de v_frm = new f371_nhan_vien_loai_lao_dong_de();
                v_frm.DisplayForInsert();
                load_data_2_grid();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_update_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow v_dr = m_grv_v_gd_loai_lao_dong.GetDataRow(m_grv_v_gd_loai_lao_dong.FocusedRowHandle);
                decimal v_id = CIPConvert.ToDecimal(v_dr[GD_LOAI_LAO_DONG.ID]);

                US_GD_LOAI_LAO_DONG v_us = new US_GD_LOAI_LAO_DONG(v_id);
                f371_nhan_vien_loai_lao_dong_de v_frm = new f371_nhan_vien_loai_lao_dong_de();
                v_frm.DisplayForUpdate(v_us);
                load_data_2_grid();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_delete_Click(object sender, EventArgs e)
        {
            try
            {
                //Lay ID cua dong du lieu muon xoa
                DataRow v_dr = m_grv_v_gd_loai_lao_dong.GetDataRow(m_grv_v_gd_loai_lao_dong.FocusedRowHandle);
                //Lay ID cua dong du lieu tren
                decimal v_id = CIPConvert.ToDecimal(v_dr[GD_LOAI_LAO_DONG.ID]);

                US_GD_LOAI_LAO_DONG v_us = new US_GD_LOAI_LAO_DONG(v_id);
                if (CHRM_BaseMessages.MsgBox_Confirm(CONST_ID_MSGBOX.QUESTION_XAC_NHAN_XOA_DU_LIEU) == true)
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
