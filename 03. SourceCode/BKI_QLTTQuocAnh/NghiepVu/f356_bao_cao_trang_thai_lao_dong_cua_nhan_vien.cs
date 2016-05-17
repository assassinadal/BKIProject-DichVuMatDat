using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IP.Core.IPCommon;
using BKI_DichVuMatDat.US;
using BKI_DichVuMatDat.DS;
using DevExpress.XtraEditors;
using IP.Core.IPSystemAdmin;
using BKI_DichVuMatDat.DS.CDBNames;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;

namespace BKI_DichVuMatDat.NghiepVu
{
    public partial class f356_bao_cao_trang_thai_lao_dong_cua_nhan_vien : Form
    {
        #region Public Interface
        public f356_bao_cao_trang_thai_lao_dong_cua_nhan_vien()
        {
            InitializeComponent();
            format_controls();
        }

        public f356_bao_cao_trang_thai_lao_dong_cua_nhan_vien(DateTime ip_datetime, bool ip_trang_thai_filter)
        {
            InitializeComponent();
            format_controls();
            string v_str = ip_datetime.ToString("MM/dd/yyyy");
            string v_str_ngay_hien_tai = DateTime.Now.ToString("MM/dd/yyyy");
            if (ip_trang_thai_filter == true)
            {
                m_grv_bao_cao_trang_thai_lao_dong_nhan_vien.ActiveFilterString = "[NGAY_KET_THUC] >= #" + v_str + "# and [NGAY_KET_THUC] <= #" + v_str_ngay_hien_tai + "#";
            }
            else if (ip_trang_thai_filter == false)
            {
                m_grv_bao_cao_trang_thai_lao_dong_nhan_vien.ActiveFilterString = "[NGAY_KET_THUC] > #" + v_str_ngay_hien_tai + "# and [NGAY_KET_THUC] <= #" + v_str + "#";
            }
            this.CenterToParent();
            this.ShowDialog();
        }
            
        #endregion

        #region Members

        int so_lao_dong = 0;
        int summaryColumnID = -1;

        DS_V_F356_BAO_CAO_TRANG_THAI_LAO_DONG_CUA_NHAN_VIEN m_ds = new DS_V_F356_BAO_CAO_TRANG_THAI_LAO_DONG_CUA_NHAN_VIEN();
        US_V_F356_BAO_CAO_TRANG_THAI_LAO_DONG_CUA_NHAN_VIEN m_us = new US_V_F356_BAO_CAO_TRANG_THAI_LAO_DONG_CUA_NHAN_VIEN();

        private decimal m_dc_id_nv_dang_dieu_chinh;
        private decimal m_dc_id_loai_trang_thai;

        #endregion

        #region Private Methods

        //private void load_data_2_grid(DataSet ip_ds)
        //{
        //    m_grc_bao_cao_trang_thai_lao_dong_nhan_vien.DataSource = ip_ds.Tables[0];
        //    m_grv_bao_cao_trang_thai_lao_dong_nhan_vien.BestFitColumns();
        //    m_grc_bao_cao_trang_thai_lao_dong_nhan_vien.RefreshDataSource();
        //}

        private void format_controls()
        {
            //FormatControl.SetVisibleSimpleButton(this);
            this.m_grv_bao_cao_trang_thai_lao_dong_nhan_vien.OptionsPrint.AutoWidth = false;
            set_define_events();
            this.KeyPreview = true;
        }

        private void set_init_form_load()
        {
           load_data_2_grid();
        }

        //private void load_data_2_sle_trang_thai_ld()
        //{
        //    US_DM_TRANG_THAI_LD v_us = new US_DM_TRANG_THAI_LD();
        //    DS_DM_TRANG_THAI_LD v_ds = new DS_DM_TRANG_THAI_LD();
        //    v_us.FillDataset(v_ds);

        //    m_sle_chon_trang_thai_lao_dong.Properties.DataSource = v_ds.Tables[0];
        //    m_sle_chon_trang_thai_lao_dong.Properties.DisplayMember = "TEN_TRANG_THAI_LD";
        //    m_sle_chon_trang_thai_lao_dong.Properties.ValueMember = "ID";
        //}

        private void load_data_2_grid()
        {
            CHRMCommon.make_stt(m_grv_bao_cao_trang_thai_lao_dong_nhan_vien);
            US_GD_TRANG_THAI_LAO_DONG v_us = new US_GD_TRANG_THAI_LAO_DONG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetTTLD(v_ds);                     
            m_grc_bao_cao_trang_thai_lao_dong_nhan_vien.DataSource = v_ds.Tables[0];
            m_grv_bao_cao_trang_thai_lao_dong_nhan_vien.BestFitColumns();
            m_grv_bao_cao_trang_thai_lao_dong_nhan_vien.ExpandAllGroups();
        }

        //private void load_data_2_grid(decimal id_trang_loai_thai)
        //{
        //    CHRMCommon.make_stt(m_grv_bao_cao_trang_thai_lao_dong_nhan_vien);
        //    DataSet v_ds = new DataSet();
        //    US_V_F356_BAO_CAO_TRANG_THAI_LAO_DONG_CUA_NHAN_VIEN v_us_v_f356 = new US_V_F356_BAO_CAO_TRANG_THAI_LAO_DONG_CUA_NHAN_VIEN();
        //    v_ds = v_us_v_f356.LayDanhSachNhanVienTheoLoaiTrangThai(m_dc_id_loai_trang_thai);
        //    m_grc_bao_cao_trang_thai_lao_dong_nhan_vien.DataSource = v_ds.Tables[0];
        //    m_grv_bao_cao_trang_thai_lao_dong_nhan_vien.BestFitColumns();
        //    m_grv_bao_cao_trang_thai_lao_dong_nhan_vien.ExpandAllGroups();
        //}

        private void focus_new_row_created(decimal ip_dc_id_gd_trang_thai_lao_dong_moi_tao)
        {
            int v_row_index = 0;
            decimal v_id_gd_trang_thai_lao_dong_moi_tao = 0;

            US_V_F356_BAO_CAO_TRANG_THAI_LAO_DONG_CUA_NHAN_VIEN v_us = new US_V_F356_BAO_CAO_TRANG_THAI_LAO_DONG_CUA_NHAN_VIEN();
            DS_V_F356_BAO_CAO_TRANG_THAI_LAO_DONG_CUA_NHAN_VIEN v_ds = new DS_V_F356_BAO_CAO_TRANG_THAI_LAO_DONG_CUA_NHAN_VIEN();

            v_id_gd_trang_thai_lao_dong_moi_tao = ip_dc_id_gd_trang_thai_lao_dong_moi_tao;

            v_us.FillDataset(v_ds);

            for (v_row_index = 0; v_row_index < v_ds.Tables[0].Rows.Count; v_row_index++)
            {
                var v_id_gd_trang_thai_lao_dong = CIPConvert.ToDecimal(m_grv_bao_cao_trang_thai_lao_dong_nhan_vien.GetDataRow(v_row_index)["ID"].ToString());

                if (v_id_gd_trang_thai_lao_dong == v_id_gd_trang_thai_lao_dong_moi_tao)
                {
                    break;
                }
            }
            m_grv_bao_cao_trang_thai_lao_dong_nhan_vien.FocusedRowHandle = v_row_index;
        }

        //private decimal find_id_nv(string ma_nv)
        //{
        //    US_DM_NHAN_VIEN v_us = new US_DM_NHAN_VIEN();
        //    DS_DM_NHAN_VIEN v_ds = new DS_DM_NHAN_VIEN();

        //    v_us.FillDataset(v_ds);

        //    string v_str_filter = "MA_NV = " + ma_nv;
        //    DataRow[] v_dr = v_ds.DM_NHAN_VIEN.Select(v_str_filter);

        //    if (v_dr.Count() == 0)
        //    {
        //        return -1;
        //    }
        //    else
        //    {
        //        return CIPConvert.ToDecimal(v_dr.First()["ID"].ToString());
        //    }
        //}

        #endregion

        #region Event Handler

        private void set_define_events()
        {
            this.Load += f356_bao_cao_trang_thai_lao_dong_cua_nhan_vien_Load;
            this.FormClosed += f356_bao_cao_trang_thai_lao_dong_cua_nhan_vien_FormClosed;
            m_cmd_delete.Click += m_cmd_delete_Click;
            m_cmd_insert.Click += m_cmd_insert_Click;
            m_cmd_update.Click += m_cmd_update_Click;
            m_grv_bao_cao_trang_thai_lao_dong_nhan_vien.CustomSummaryCalculate += gridView1_CustomSummaryCalculate;
        }


        void m_cmd_xuat_excel_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "xls files (*.xls)|*.xls|All files (*.*)|*.*";
                saveFileDialog1.RestoreDirectory = true;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    m_grv_bao_cao_trang_thai_lao_dong_nhan_vien.ExportToXls(saveFileDialog1.FileName);
                    CHRM_BaseMessages.MsgBox_Infor(CONST_ID_MSGBOX.INFOR_LUU_BAO_CAO_THANH_CONG);
                }
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
                if (m_grv_bao_cao_trang_thai_lao_dong_nhan_vien.FocusedRowHandle < 0)
                {
                    return;
                }
                decimal v_id_gd_trang_thai_lao_dong = (decimal)m_grv_bao_cao_trang_thai_lao_dong_nhan_vien.
                                                      GetRowCellValue(m_grv_bao_cao_trang_thai_lao_dong_nhan_vien.FocusedRowHandle, "ID");
                if (v_id_gd_trang_thai_lao_dong > 0)
                {
                    US_GD_TRANG_THAI_LAO_DONG v_us = new US_GD_TRANG_THAI_LAO_DONG(v_id_gd_trang_thai_lao_dong);
                    f357_bao_cao_trang_thai_lao_dong_nhan_vien_de v_frm = new f357_bao_cao_trang_thai_lao_dong_nhan_vien_de();
                    v_frm.display_4_update(v_us);
                    m_sle_chon_trang_thai_lao_dong.EditValue = null;
                    load_data_2_grid();
                    focus_new_row_created(v_id_gd_trang_thai_lao_dong);
                }
                else
                {
                    CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_CHUA_CO_DU_LIEU_DE_THUC_HIEN_THAO_TAC);
                }
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
                f357_bao_cao_trang_thai_lao_dong_nhan_vien_de v_f = new f357_bao_cao_trang_thai_lao_dong_nhan_vien_de();
                v_f.display_4_insert();
                load_data_2_grid();
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
                if (m_grv_bao_cao_trang_thai_lao_dong_nhan_vien.FocusedRowHandle < 0)
                {
                    return;
                }
                if (CHRM_BaseMessages.MsgBox_Confirm(CONST_ID_MSGBOX.QUESTION_XAC_NHAN_XOA_DU_LIEU) == true)
                {
                    DataRow v_dr = m_grv_bao_cao_trang_thai_lao_dong_nhan_vien.GetDataRow(m_grv_bao_cao_trang_thai_lao_dong_nhan_vien.FocusedRowHandle);
                    decimal v_id_gd_trang_thai_lao_dong = CIPConvert.ToDecimal(v_dr["ID"]);

                    US_GD_TRANG_THAI_LAO_DONG v_us = new US_GD_TRANG_THAI_LAO_DONG(v_id_gd_trang_thai_lao_dong);
                    v_us.Delete();
                    CHRM_BaseMessages.MsgBox_Infor(CONST_ID_MSGBOX.INFOR_DU_LIEU_DA_DUOC_CAP_NHAT);
                    load_data_2_grid();
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void f356_bao_cao_trang_thai_lao_dong_cua_nhan_vien_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Dispose();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void f356_bao_cao_trang_thai_lao_dong_cua_nhan_vien_Load(object sender, EventArgs e)
        {
            try
            {
                set_init_form_load();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void gridView1_CustomSummaryCalculate(object sender, DevExpress.Data.CustomSummaryEventArgs e)
        {
            try
            {
                GridView view = sender as GridView;
                summaryColumnID = Convert.ToInt16((e.Item as GridGroupSummaryItem).Tag);

                if (e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Start)
                {
                    so_lao_dong = 0;
                }
                if (e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Calculate)
                {
                    switch (summaryColumnID)
                    {
                        case 1:
                            so_lao_dong++;
                            break;
                    }
                }
                if (e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Finalize)
                {
                    switch (summaryColumnID)
                    {
                        case 1:
                            e.TotalValue = so_lao_dong;
                            break;
                    }
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        #endregion

    }
}
