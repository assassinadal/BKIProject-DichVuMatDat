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
    public partial class F107_dm_phu_cap : Form
    {
        public F107_dm_phu_cap()
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

        #region Private Methods
        private void format_controls()
        {
            //FormatControl.SetVisibleSimpleButton(this);
            this.m_grv_dm_phu_cap.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(WinFormControls.m_grv_PopupMenuShowing);
            this.m_grv_dm_phu_cap.OptionsPrint.AutoWidth = false;
            set_define_events();
            this.KeyPreview = true;
        }

        private void set_initial_form_load()
        {
            CHRMCommon.make_stt(m_grv_dm_phu_cap);
            load_data_2_grid();
        }
        private void focus_new_row_created(decimal ip_dc_id_dm_dv)
        {
            int v_row_index = 0;
            decimal v_id_qd_moi_lap = 0;
            US_DM_PHU_CAP v_us = new US_DM_PHU_CAP();
            DS_DM_PHU_CAP v_ds = new DS_DM_PHU_CAP();

            v_id_qd_moi_lap = ip_dc_id_dm_dv;
            v_us.FillDataset(v_ds);

            for (v_row_index = 0; v_row_index < v_ds.Tables[0].Rows.Count; v_row_index++)
            {
                var v_id_gd_qd = CIPConvert.ToDecimal(m_grv_dm_phu_cap.GetDataRow(v_row_index)["ID"].ToString());

                if (v_id_gd_qd == v_id_qd_moi_lap)
                {
                    break;
                }
            }
            m_grv_dm_phu_cap.FocusedRowHandle = v_row_index;
        }
        
        private void load_data_2_grid()
        {
            //CHRMCommon.make_stt(m_grv_dm_phu_cap);
            //US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            //DataSet v_ds = new DataSet();
            //v_ds.Tables.Add(new DataTable());
            //throw new Exception("Sua lai khong dung FillDataSetWithTableName nua nhe");
            //v_us.FillDatasetWithTableName(v_ds, "V_DM_PHU_CAP
            US_V_DM_PHU_CAP v_us = new US_V_DM_PHU_CAP();
            DS_V_DM_PHU_CAP v_ds = new DS_V_DM_PHU_CAP();
            v_us.FillDataset(v_ds);
            m_grc_dm_phu_cap.DataSource = v_ds.Tables[0];
        }
        #endregion

        private void set_define_events()
        {
            this.Load += F107_dm_phu_cap_Load;
            m_cmd_insert.Click += m_cmd_insert_Click;
            m_cmd_update.Click += m_cmd_update_Click;
            m_cmd_delete.Click += m_cmd_delete_Click;
        }

        void F107_dm_phu_cap_Load(object sender, EventArgs e)
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
                decimal v_id_dm_phu_cap_moi_tao = 0;
                F107_dm_phu_cap_de v_frm = new F107_dm_phu_cap_de();
                v_frm.display_4_insert(ref v_id_dm_phu_cap_moi_tao);
                load_data_2_grid();

                focus_new_row_created(v_id_dm_phu_cap_moi_tao);
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
                decimal v_id_dm_phu_cap = CIPConvert.ToDecimal(m_grv_dm_phu_cap.GetRowCellValue(m_grv_dm_phu_cap.FocusedRowHandle, "ID"));

                if (v_id_dm_phu_cap > 0)
                {
                    US_DM_PHU_CAP v_us = new US_DM_PHU_CAP(v_id_dm_phu_cap);
                    F107_dm_phu_cap_de v_frm = new F107_dm_phu_cap_de();
                    v_frm.display_4_update(v_us);
                    load_data_2_grid();

                    focus_new_row_created(v_id_dm_phu_cap);
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
                if (CHRM_BaseMessages.MsgBox_Confirm(CONST_ID_MSGBOX.QUESTION_XAC_NHAN_XOA_DU_LIEU) == true)
                {
                    DataRow v_dr = m_grv_dm_phu_cap.GetDataRow(m_grv_dm_phu_cap.FocusedRowHandle);
                    decimal v_id_phu_cap = CIPConvert.ToDecimal(v_dr["ID"]);
                    if (check_loai_pc_dang_su_dung(v_id_phu_cap))
                    {
                        string v_str_error = " Không thể xóa loại phụ cấp đang được sử dụng!";
                        XtraMessageBox.Show(v_str_error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    US_DM_PHU_CAP v_us = new US_DM_PHU_CAP(v_id_phu_cap);
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

        private bool check_loai_pc_dang_su_dung(decimal ip_id_loai_pc)
        {
            US_GD_NHAN_VIEN_PHU_CAP v_us = new US_GD_NHAN_VIEN_PHU_CAP();
            DS_GD_NHAN_VIEN_PHU_CAP v_ds = new DS_GD_NHAN_VIEN_PHU_CAP();
            v_us.FillDataset(v_ds, "where id_phu_cap =" + ip_id_loai_pc);
            if (v_ds.Tables[0].Rows.Count == 0)
                return false;
            return true;
        }
    }
}
