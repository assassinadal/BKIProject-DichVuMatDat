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

namespace BKI_DichVuMatDat.DanhMuc
{
    public partial class F108_dm_tham_so : Form
    {
        public F108_dm_tham_so()
        {
            InitializeComponent();
            format_controls();
        }

        #region Public interface
        public void display()
        {
            this.ShowDialog();
        }
        #endregion

        #region Members
        
        #endregion

        #region Private methods
        private void format_controls()
        {
            //FormatControl.SetVisibleSimpleButton(this);
            this.m_grv_tham_so.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(WinFormControls.m_grv_PopupMenuShowing);
            this.m_grv_tham_so.OptionsPrint.AutoWidth = false;
            set_define_events();
            this.KeyPreview = true;
        }

        private void set_initial_form_load()
        {
            load_data_2_grid();
        }

        private void load_data_2_grid()
        {
            CHRMCommon.make_stt(m_grv_tham_so);
            //US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            //DataSet v_ds = new DataSet();
            //v_ds.Tables.Add(new DataTable());
            //throw new Exception("Sua lai khong dung FillDataSetWithTableName nua nhe");
            //v_us.FillDatasetWithTableName(v_ds, "DM_THAM_SO
            US_DM_THAM_SO v_us = new US_DM_THAM_SO();
            DS_DM_THAM_SO v_ds = new DS_DM_THAM_SO();
            v_us.FillDataset(v_ds);
            m_grc_tham_so.DataSource = v_ds.Tables[0];
        }

        private void focus_new_row_created(decimal ip_dc_id_dm_dv)
        {
            int v_row_index = 0;
            decimal v_id_qd_moi_lap = 0;

            US_DM_THAM_SO v_us = new US_DM_THAM_SO();
            DS_DM_THAM_SO v_ds = new DS_DM_THAM_SO();

            v_id_qd_moi_lap = ip_dc_id_dm_dv;

            v_us.FillDataset(v_ds);

            for (v_row_index = 0; v_row_index < v_ds.Tables[0].Rows.Count; v_row_index++)
            {
                var v_id_gd_qd = CIPConvert.ToDecimal(m_grv_tham_so.GetDataRow(v_row_index)["ID"].ToString());

                if (v_id_gd_qd == v_id_qd_moi_lap)
                {
                    break;
                }
            }

            m_grv_tham_so.FocusedRowHandle = v_row_index;
        }
        #endregion
        private void set_define_events()
        {
            this.Load += F108_dm_tham_so_Load;
            m_cmd_insert.Click += m_cmd_insert_Click;
            m_cmd_update.Click += m_cmd_update_Click;
            m_cmd_delete.Click += m_cmd_delete_Click;
        }

        void F108_dm_tham_so_Load(object sender, EventArgs e)
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
                decimal v_id_dm_tham_so_moi_tao = 0;
                f108_dm_tham_so_de v_frm = new f108_dm_tham_so_de();
                v_frm.display_4_insert(ref v_id_dm_tham_so_moi_tao);
                load_data_2_grid();

                focus_new_row_created(v_id_dm_tham_so_moi_tao);
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
                decimal v_id_dm_tham_so = CIPConvert.ToDecimal(m_grv_tham_so.GetRowCellValue(m_grv_tham_so.FocusedRowHandle, "ID"));

                if (v_id_dm_tham_so > 0)
                {
                    US_DM_THAM_SO v_us = new US_DM_THAM_SO(v_id_dm_tham_so);
                    f108_dm_tham_so_de v_frm = new f108_dm_tham_so_de();
                    v_frm.display_4_update(v_us);
                    load_data_2_grid();

                    focus_new_row_created(v_id_dm_tham_so);
                }
                else
                {
                    CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_CHUA_CHON_DONG_TREN_LUOI_DE_SUA);
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
                if (CHRM_BaseMessages.MsgBox_Confirm(CONST_ID_MSGBOX.QUESTION_XAC_NHAN_XOA_DU_LIEU) ==  true)
                {
                    DataRow v_dr = m_grv_tham_so.GetDataRow(m_grv_tham_so.FocusedRowHandle);
                    decimal v_id_don_vi = CIPConvert.ToDecimal(v_dr["ID"]);

                    US_DM_DON_VI v_us = new US_DM_DON_VI(v_id_don_vi);
                    v_us.BeginTransaction();
                    v_us.Delete();
                    v_us.CommitTransaction();
                    load_data_2_grid();
                    CHRM_BaseMessages.MsgBox_Infor(CONST_ID_MSGBOX.INFOR_XOA_DU_LIEU_THANH_CONG);
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
       
    }
}
