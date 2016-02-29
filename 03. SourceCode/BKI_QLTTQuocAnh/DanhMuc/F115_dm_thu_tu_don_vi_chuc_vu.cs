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
using DevExpress.XtraGrid.Views.Grid;

namespace BKI_DichVuMatDat.DanhMuc
{
    public partial class F115_dm_thu_tu_don_vi_chuc_vu : Form
    {
        public F115_dm_thu_tu_don_vi_chuc_vu()
        {
            InitializeComponent();
            format_controls();
        }

        #region Public Interface

        #endregion

        #region Members

        #endregion

        #region Private Methods
        private void format_controls()
        {
            FormatControl.SetVisibleSimpleButton(this);
            set_define_events();
            this.KeyPreview = true;
        }

        private void set_initial_form_load()
        {
            load_data_2_grid();
        }

        private void load_data_2_grid()
        {
            make_stt(m_grv_dm_thu_tu_don_vi_chuc_vu);
            US_CM_THU_TU_DON_VI v_us = new US_CM_THU_TU_DON_VI();
            DS_CM_THU_TU_DON_VI v_ds = new DS_CM_THU_TU_DON_VI();
            v_us.FillDataset(v_ds);
            m_grc_dm_thu_tu_don_vi_chuc_vu.DataSource = v_ds.Tables[0];
        }

        private void make_stt(GridView ip_grv)
        {
            var col = ip_grv.Columns.Add();
            col.FieldName = "SoTT";
            col.Caption = "SoTT";
            col.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            ip_grv.CustomUnboundColumnData += ip_grv_CustomUnboundColumnData;
        }

        private void ip_grv_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.IsGetData)
                e.Value = e.ListSourceRowIndex + 1;
        }
        #endregion

        //
        //
        // EVENT HANLDERS
        //
        //

        private void set_define_events()
        {
            Load += F115_dm_thu_tu_don_vi_chuc_vu_Load;
            m_cmd_update.Click += m_cmd_update_Click;
        }

        private void F115_dm_thu_tu_don_vi_chuc_vu_Load(object sender, EventArgs e)
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

        private void m_cmd_update_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow v_dr = m_grv_dm_thu_tu_don_vi_chuc_vu.GetDataRow(m_grv_dm_thu_tu_don_vi_chuc_vu.FocusedRowHandle);

                decimal v_id_cm_dm_thu_tu_don_vi = 0;
                v_id_cm_dm_thu_tu_don_vi = CIPConvert.ToDecimal(v_dr[CM_THU_TU_DON_VI.ID].ToString());

                if (v_id_cm_dm_thu_tu_don_vi > 0)
                {
                    US_CM_THU_TU_DON_VI v_us = new US_CM_THU_TU_DON_VI(CIPConvert.ToDecimal(v_dr[CM_THU_TU_DON_VI.ID].ToString()));

                    F115_dm_thu_tu_don_vi_de v_frm = new F115_dm_thu_tu_don_vi_de();
                    v_frm.DisplayForUpdate(v_us);
                    load_data_2_grid();
                }
                else
                {
                    CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_CHUA_CHON_DONG_TREN_LUOI_DE_SUA);
                    return;
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
    }
}
