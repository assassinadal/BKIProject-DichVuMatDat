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
    public partial class F106_dm_luong_che_do : Form
    {
        public F106_dm_luong_che_do()
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
            this.m_grv_dm_luong_che_do.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(WinFormControls.m_grv_PopupMenuShowing);
            this.m_grv_dm_luong_che_do.OptionsPrint.AutoWidth = false;
            //set_define_events();
            this.KeyPreview = true;
        }

        private void set_initial_form_load()
        {
            //FormatControl.SetVisibleSimpleButton(this);
            load_data_2_grid();
        }

        private void load_data_2_grid()
        {
            CHRMCommon.make_stt(m_grv_dm_luong_che_do);
            // US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            // DataSet v_ds = new DataSet();
            // v_ds.Tables.Add(new DataTable());
            // throw new Exception("Sua lai khong dung FillDataSetWithTableName nua nhe");
            //// v_us.FillDatasetWithTableName(v_ds, "V_DM_LUONG_CHE_DO");
            US_V_DM_LUONG_CHE_DO v_us = new US_V_DM_LUONG_CHE_DO();
            DS_V_DM_LUONG_CHE_DO v_ds = new DS_V_DM_LUONG_CHE_DO();
            v_us.FillDataset(v_ds);
            m_grc_dm_luong_che_do.DataSource = v_ds.Tables[0];
        }

        private void focus_new_row_created(decimal ip_dc_id_dm_dv)
        {
            int v_row_index = 0;
            decimal v_id_qd_moi_lap = 0;
            US_DM_LUONG_CHE_DO v_us = new US_DM_LUONG_CHE_DO();
            DS_DM_LUONG_CHE_DO v_ds = new DS_DM_LUONG_CHE_DO();

            v_id_qd_moi_lap = ip_dc_id_dm_dv;
            v_us.FillDataset(v_ds);

            for (v_row_index = 0; v_row_index < v_ds.Tables[0].Rows.Count; v_row_index++)
            {
                var v_id_gd_qd = CIPConvert.ToDecimal(m_grv_dm_luong_che_do.GetDataRow(v_row_index)["ID"].ToString());

                if (v_id_gd_qd == v_id_qd_moi_lap)
                {
                    break;
                }
            }
            m_grv_dm_luong_che_do.FocusedRowHandle = v_row_index;
        }
        #endregion

        //private void set_define_events()
        //{
        //    this.Load += F106_dm_luong_che_do_Load;
        //    m_cmd_insert.Click += m_cmd_insert_Click;
        //    m_cmd_update.Click += m_cmd_update_Click;
        //    m_cmd_delete.Click += m_cmd_delete_Click;
        //}

        void F106_dm_luong_che_do_Load(object sender, EventArgs e)
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
                decimal v_id_dm_luong_che_do_moi_tao = 0;
                F106_dm_luong_che_do_de v_frm = new F106_dm_luong_che_do_de();
                v_frm.display_4_insert(ref v_id_dm_luong_che_do_moi_tao);
                load_data_2_grid();

                focus_new_row_created(v_id_dm_luong_che_do_moi_tao);
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
                decimal v_id_dm_luong_che_do = CIPConvert.ToDecimal(m_grv_dm_luong_che_do.GetRowCellValue(m_grv_dm_luong_che_do.FocusedRowHandle, "ID"));

                if (v_id_dm_luong_che_do > 0)
                {
                    US_DM_LUONG_CHE_DO v_us = new US_DM_LUONG_CHE_DO(v_id_dm_luong_che_do);
                    F106_dm_luong_che_do_de v_frm = new F106_dm_luong_che_do_de();
                    v_frm.display_4_update(v_us);
                    load_data_2_grid();

                    focus_new_row_created(v_id_dm_luong_che_do);
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
                if (CHRM_BaseMessages.MsgBox_Confirm(CONST_ID_MSGBOX.QUESTION_XAC_NHAN_XOA_THONG_TIN_DA_CHON_TREN_LUOI) ==  true)
                {
                    DataRow v_dr = m_grv_dm_luong_che_do.GetDataRow(m_grv_dm_luong_che_do.FocusedRowHandle);
                    decimal v_id_lcd = CIPConvert.ToDecimal(v_dr["ID"]);
                    if (check_lcd_dang_su_dung(v_id_lcd))
                    {
                        string v_str_error = "Không thể xóa loại lương chế độ đang được sử dụng!";
                        XtraMessageBox.Show(v_str_error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    US_DM_LUONG_CHE_DO v_us = new US_DM_LUONG_CHE_DO(v_id_lcd);
                    v_us.BeginTransaction();
                    v_us.Delete();
                    v_us.CommitTransaction();
                    XtraMessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                    load_data_2_grid();
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private bool check_lcd_dang_su_dung(decimal ip_id_lcd)
        {
            US_GD_HOP_DONG v_us = new US_GD_HOP_DONG();
            DS_GD_HOP_DONG v_ds = new DS_GD_HOP_DONG();
            v_us.FillDataset(v_ds, "where id_luong_che_do =" + ip_id_lcd);
            if (v_ds.Tables[0].Rows.Count == 0)
                return false;
            return true;
        }

    }
}
