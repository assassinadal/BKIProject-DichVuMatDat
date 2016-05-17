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
    public partial class F102_dm_bao_hiem : Form
    {
        public F102_dm_bao_hiem()
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
            //FormatControl.SetVisibleSimpleButton(this);
            this.m_grv_dm_bao_hiem.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(WinFormControls.m_grv_PopupMenuShowing);
            this.m_grv_dm_bao_hiem.OptionsPrint.AutoWidth = false;
            set_define_events();
            this.KeyPreview = true;
        }

        private void set_initial_form_load()
        {
            load_data_2_grid();
        }
       
        private void load_data_2_grid()
        {
            CHRMCommon.make_stt(m_grv_dm_bao_hiem);
            //US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            //DataSet v_ds = new DataSet();

            //v_ds.Tables.Add(new DataTable());
            //throw new Exception("Sua lai khong dung FillDataSetWithTableName nua nhe");
            ////v_us.FillDatasetWithTableName(v_ds, "DM_BAO_HIEM");
            US_DM_BAO_HIEM v_us = new US_DM_BAO_HIEM();
            DS_DM_BAO_HIEM v_ds = new DS_DM_BAO_HIEM();
            v_us.FillDataset(v_ds);
            m_grc_dm_bao_hiem.DataSource = v_ds.Tables[0];

        }
          #endregion
        private void set_define_events()
        {
            this.Load += F102_dm_bao_hiem_Load; 
            m_cmd_insert.Click += m_cmd_insert_Click;
            m_cmd_update.Click += m_cmd_update_Click;
            m_cmd_delete.Click += m_cmd_delete_Click;
        }

        void F102_dm_bao_hiem_Load(object sender, EventArgs e)
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

        private void m_cmd_delete_Click(object sender, EventArgs e)
        {
            try
            {
                //Lay ID cua dong du lieu muon xoa
                DataRow v_dr = m_grv_dm_bao_hiem.GetDataRow(m_grv_dm_bao_hiem.FocusedRowHandle);
                //Lay ID du lieu cua dong phia tren
                decimal v_id = CIPConvert.ToDecimal(v_dr[DM_BAO_HIEM.ID]);

                US_DM_BAO_HIEM v_us = new US_DM_BAO_HIEM(v_id);
                if (CHRM_BaseMessages.MsgBox_Confirm(CONST_ID_MSGBOX.QUESTION_XAC_NHAN_XOA_LOAI_BAO_HIEM) == true)
                {
                    v_us.Delete();
                    XtraMessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                    load_data_2_grid();
                }
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
                F102_dm_bao_hiem_de v_frm = new F102_dm_bao_hiem_de();
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
                DataRow v_dr = m_grv_dm_bao_hiem.GetDataRow(m_grv_dm_bao_hiem.FocusedRowHandle);
                US_DM_BAO_HIEM v_us = new US_DM_BAO_HIEM(CIPConvert.ToDecimal(v_dr[DM_BAO_HIEM.ID].ToString()));

                F102_dm_bao_hiem_de v_frm = new F102_dm_bao_hiem_de();
                v_frm.DisplayForUpdate(v_us);
                load_data_2_grid();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
    }

}
