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
    public partial class F103_dm_he_so_luong_ns : Form
    {
        public F103_dm_he_so_luong_ns()
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
            this.m_grv_dm_he_so_luong_ns.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(WinFormControls.m_grv_PopupMenuShowing);
            this.m_grv_dm_he_so_luong_ns.OptionsPrint.AutoWidth = false;
            //set_define_events();
            this.KeyPreview = true;
        }

        private void set_initial_form_load()
        {
            load_data_2_grid();
        }

        private void load_data_2_grid() 
        {
            CHRMCommon.make_stt(m_grv_dm_he_so_luong_ns);
            US_V_DM_HE_SO_LUONG_NS v_us = new US_V_DM_HE_SO_LUONG_NS();
            DS_V_DM_HE_SO_LUONG_NS v_ds = new DS_V_DM_HE_SO_LUONG_NS();
            v_us.FillDataset(v_ds);
            m_grc_dm_he_so_luong_ns.DataSource = v_ds.Tables[0];
        }

        private void focus_new_row_created(decimal ip_dc_id_dm_dv)
        {
            int v_row_index = 0;
            decimal v_id_qd_moi_lap = 0;
            US_DM_HE_SO_LUONG_NS v_us = new US_DM_HE_SO_LUONG_NS();
            DS_DM_HE_SO_LUONG_NS v_ds = new DS_DM_HE_SO_LUONG_NS();

            v_id_qd_moi_lap = ip_dc_id_dm_dv;
            v_us.FillDataset(v_ds);

            for (v_row_index = 0; v_row_index < v_ds.Tables[0].Rows.Count; v_row_index++)
            {
                var v_id_gd_qd = CIPConvert.ToDecimal(m_grv_dm_he_so_luong_ns.GetDataRow(v_row_index)["ID"].ToString());

                if (v_id_gd_qd == v_id_qd_moi_lap)
                {
                    break;
                }
            }
            m_grv_dm_he_so_luong_ns.FocusedRowHandle = v_row_index;
        }
        #endregion

        //private void set_define_events()
        //{
        //    this.Load += F103_dm_he_so_luong_ns_Load;
        //    m_cmd_insert.Click += m_cmd_insert_Click;
        //    m_cmd_update.Click += m_cmd_update_Click;
        //    m_cmd_delete.Click += m_cmd_delete_Click;
           
        //}

        void F103_dm_he_so_luong_ns_Load(object sender, EventArgs e)
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
                decimal v_id_dm_he_so_luong_ns_moi_tao = 0;
                F103_dm_he_so_luong_ns_de v_frm = new F103_dm_he_so_luong_ns_de();
                v_frm.display_4_insert(ref v_id_dm_he_so_luong_ns_moi_tao);
                load_data_2_grid();

                focus_new_row_created(v_id_dm_he_so_luong_ns_moi_tao);
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
                decimal v_id_dm_he_so_luong_ns = CIPConvert.ToDecimal(m_grv_dm_he_so_luong_ns.GetRowCellValue(m_grv_dm_he_so_luong_ns.FocusedRowHandle, "ID"));

                if (v_id_dm_he_so_luong_ns > 0)
                {
                    US_DM_HE_SO_LUONG_NS v_us = new US_DM_HE_SO_LUONG_NS(v_id_dm_he_so_luong_ns);
                    F103_dm_he_so_luong_ns_de v_frm = new F103_dm_he_so_luong_ns_de();
                    v_frm.display_4_update(v_us);
                    load_data_2_grid();

                    focus_new_row_created(v_id_dm_he_so_luong_ns);
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
                if (CHRM_BaseMessages.MsgBox_Confirm(CONST_ID_MSGBOX.QUESTION_XAC_NHAN_XOA_THONG_TIN_DA_CHON_TREN_LUOI) == true)
                {
                    DataRow v_dr = m_grv_dm_he_so_luong_ns.GetDataRow(m_grv_dm_he_so_luong_ns.FocusedRowHandle);
                    decimal v_id_lns = CIPConvert.ToDecimal(v_dr["ID"]);
                    if (check_lns_dang_su_dung(v_id_lns))
                    {
                        string v_str_error = " Không thể xóa loại lương năng suất đang được sử dụng!";
                        XtraMessageBox.Show(v_str_error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    US_DM_HE_SO_LUONG_NS v_us = new US_DM_HE_SO_LUONG_NS(v_id_lns);
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

        private bool check_lns_dang_su_dung(decimal ip_id_lns)
        {
            US_GD_HE_SO_LNS v_us = new US_GD_HE_SO_LNS();
            DS_GD_HE_SO_LNS v_ds = new DS_GD_HE_SO_LNS();
            v_us.FillDataset(v_ds, "where id_he_so_lns =" + ip_id_lns);
            if (v_ds.Tables[0].Rows.Count == 0)
                return false;
            return true;
        }
    }
         
}
