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

namespace BKI_DichVuMatDat.DanhMuc
{
    public partial class F101_dm_don_vi : Form
    {
        public F101_dm_don_vi()
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
        #endregion

        #region private methods
        private void format_controls()
        {
            FormatControl.SetVisibleSimpleButton(this);
            this.m_grv_dm_don_vi.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(WinFormControls.m_grv_PopupMenuShowing);
            this.m_grv_dm_don_vi.OptionsPrint.AutoWidth = false;
            set_define_events();
            this.KeyPreview = true;
        }

        private void set_initial_form_load()
        {
            load_data_2_grid();
        }

        private void load_data_2_grid()
        {
            CHRMCommon.make_stt(m_grv_dm_don_vi);
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();

            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithTableName(v_ds, "V_DM_DON_VI");
            m_grc_dm_don_vi.DataSource = v_ds.Tables[0];
        }

        private void focus_new_row_created(decimal ip_dc_id_dm_dv)
        {
            int v_row_index = 0;
            decimal v_id_qd_moi_lap = 0;

            US_DM_DON_VI v_us = new US_DM_DON_VI();
            DS_DM_DON_VI v_ds = new DS_DM_DON_VI();

            v_id_qd_moi_lap = ip_dc_id_dm_dv;

            v_us.FillDataset(v_ds);

            for (v_row_index = 0; v_row_index < v_ds.Tables[0].Rows.Count; v_row_index++)
            {
                var v_id_gd_qd = CIPConvert.ToDecimal(m_grv_dm_don_vi.GetDataRow(v_row_index)["ID"].ToString());

                if (v_id_gd_qd == v_id_qd_moi_lap)
                {
                    break;
                }
            }

            m_grv_dm_don_vi.FocusedRowHandle = v_row_index;
        }
        #endregion

        private void set_define_events()
        {
            this.Load += F105_dm_don_vi_Load;
            m_cmd_insert.Click += m_cmd_insert_Click;
            m_cmd_update.Click += m_cmd_update_Click;
            m_cmd_delete.Click += m_cmd_delete_Click;

        }

        void F105_dm_don_vi_Load(object sender, EventArgs e)
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

        void m_cmd_insert_Click(object sender, EventArgs e)
        {
            try
            {
                decimal v_id_dm_don_vi_moi_tao = 0;
                F101_dm_don_vi_de v_frm = new F101_dm_don_vi_de();
                v_frm.display_4_insert(ref v_id_dm_don_vi_moi_tao);
                load_data_2_grid();

                focus_new_row_created(v_id_dm_don_vi_moi_tao);
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_update_Click(object sender, EventArgs e)
        {
            try
            {
                decimal v_id_dm_dv = CIPConvert.ToDecimal(m_grv_dm_don_vi.GetRowCellValue(m_grv_dm_don_vi.FocusedRowHandle, "ID"));
                if (v_id_dm_dv > 0)
                {
                    US_DM_DON_VI v_us = new US_DM_DON_VI(v_id_dm_dv);
                    F101_dm_don_vi_de v_frm = new F101_dm_don_vi_de();
                    v_frm.display_4_update(v_us);
                    load_data_2_grid();

                    focus_new_row_created(v_id_dm_dv);
                }
                else
                {
                    CHRM_BaseMessages.MsgBox_Infor(CONST_ID_MSGBOX.UPDATE_DU_LIEU_DM_DON_VI);
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (CHRM_BaseMessages.MsgBox_Confirm(CONST_ID_MSGBOX.QUESTION_XAC_NHAN_XOA_DU_LIEU) == true)
                {
                    DataRow v_dr = m_grv_dm_don_vi.GetDataRow(m_grv_dm_don_vi.FocusedRowHandle);
                    decimal v_id_don_vi = CIPConvert.ToDecimal(v_dr["ID"]);

                    US_DM_DON_VI v_us = new US_DM_DON_VI(v_id_don_vi);
                    v_us.BeginTransaction();
                    v_us.Delete();
                    v_us.CommitTransaction();
                    load_data_2_grid();
                    CHRM_BaseMessages.MsgBox_Infor(CONST_ID_MSGBOX.INFOR_DU_LIEU_DA_DUOC_CAP_NHAT);
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

    }
}
