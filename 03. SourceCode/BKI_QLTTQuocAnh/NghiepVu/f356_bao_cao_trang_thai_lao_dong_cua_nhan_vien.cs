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
        internal void display_nv_het_nghi_tam_thoi(DataSet ip_ds, f388_main f)
        {
            m_e_view_mode = ViewMode.XemCanhBaoHetNghi;
            m_ds_canh_bao_nv_nghi_tam_thoi = ip_ds;
            this.CenterToScreen();
            this.ShowDialog();
            f.update_canh_bao();
        }
        internal void display_nv_dang_nghi_tam_thoi(DataSet ip_ds, f388_main f)
        {
            m_e_view_mode = ViewMode.XemCanhBaoDangNghi;
            m_ds_canh_bao_nv_nghi_tam_thoi = ip_ds;
            this.CenterToScreen();
            this.ShowDialog();
            f.update_canh_bao();
        }
        internal void display(f388_main f)
        {
            m_form = f;
            this.Show();
        }
        #endregion

        #region Members
        decimal m_load_data_toan_bo_nv = -1;
        DS_V_F356_BAO_CAO_TRANG_THAI_LAO_DONG_CUA_NHAN_VIEN m_ds = new DS_V_F356_BAO_CAO_TRANG_THAI_LAO_DONG_CUA_NHAN_VIEN();
        US_V_F356_BAO_CAO_TRANG_THAI_LAO_DONG_CUA_NHAN_VIEN m_us = new US_V_F356_BAO_CAO_TRANG_THAI_LAO_DONG_CUA_NHAN_VIEN();
        enum ViewMode
        {
            Thuong,
            XemCanhBaoDangNghi,
            XemCanhBaoHetNghi
        }
        ViewMode m_e_view_mode = ViewMode.Thuong;
        DataSet m_ds_canh_bao_nv_nghi_tam_thoi = new DataSet();
        private decimal m_dc_id_nv_dang_dieu_chinh;
        private f388_main m_form;
        #endregion

        #region Private Methods

        private void load_data_2_grid(DataSet ip_ds)
        {
            m_grc_bao_cao_trang_thai_lao_dong_nhan_vien.DataSource = ip_ds.Tables[0];
            m_grv_bao_cao_trang_thai_lao_dong_nhan_vien.BestFitColumns();
            m_grc_bao_cao_trang_thai_lao_dong_nhan_vien.RefreshDataSource();
        }

        private void format_controls()
        {
            FormatControl.SetVisibleSimpleButton(this);
            this.m_grv_bao_cao_trang_thai_lao_dong_nhan_vien.OptionsPrint.AutoWidth = false;
            set_define_events();
            this.KeyPreview = true;
        }

        private void set_init_form_load()
        {
            switch (m_e_view_mode)
            {
                case ViewMode.Thuong:
                    load_data_2_sle_chon_nhan_vien();
                    load_data_2_sle_chon_trang_thai_lao_dong();
                    load_data_2_grid();
                    break;
                case ViewMode.XemCanhBaoDangNghi:
                    load_data_2_grid(m_ds_canh_bao_nv_nghi_tam_thoi);
                    m_pnl_filter.Visible = false;
                    m_lbl_header.Text = "Danh sách nhân viên đang nghỉ tạm thời";
                    m_cmd_xuat_excel.Visible = false;
                    m_cmd_insert.Enabled = false;
                    m_cmd_update.Enabled = false;
                    break;
                case ViewMode.XemCanhBaoHetNghi:
                    load_data_2_grid(m_ds_canh_bao_nv_nghi_tam_thoi);
                    m_pnl_filter.Visible = false;
                    m_lbl_header.Text = "Danh sách nhân viên đã hết phép nghỉ tạm thời";
                    m_cmd_xuat_excel.Visible = false;
                    m_cmd_insert.Enabled = false;
                    m_cmd_update.Enabled = false;
                    break;
                default:
                    break;
            }
        }

        private DS_V_DM_NHAN_VIEN load_data_2_ds_v_dm_nv()
        {
            DS_V_DM_NHAN_VIEN v_ds = new DS_V_DM_NHAN_VIEN();
            US_V_DM_NHAN_VIEN v_us = new US_V_DM_NHAN_VIEN();

            v_us.FillDataset(v_ds);
            return v_ds;
        }

        private void load_data_2_sle_chon_nhan_vien()
        {
            m_sle_chon_nhan_vien.Properties.DataSource = load_data_2_ds_v_dm_nv().V_DM_NHAN_VIEN;
            m_sle_chon_nhan_vien.Properties.ValueMember = V_DM_NHAN_VIEN.ID;
            m_sle_chon_nhan_vien.Properties.DisplayMember = V_DM_NHAN_VIEN.HO_TEN;

            m_sle_chon_nhan_vien.Properties.PopulateViewColumns();
            m_sle_chon_nhan_vien.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            m_sle_chon_nhan_vien.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
        }

        private DS_V_DM_TRANG_THAI_LAO_DONG load_data_2_ds_v_dm_trang_thai_ld()
        {
            DS_V_DM_TRANG_THAI_LAO_DONG v_ds = new DS_V_DM_TRANG_THAI_LAO_DONG();
            US_V_DM_TRANG_THAI_LAO_DONG v_us = new US_V_DM_TRANG_THAI_LAO_DONG();

            v_us.FillDataset(v_ds);
            return v_ds;
        }

        private void load_data_2_sle_chon_trang_thai_lao_dong()
        {
            m_sle_chon_trang_thai_lao_dong.Properties.DataSource = load_data_2_ds_v_dm_trang_thai_ld().V_DM_TRANG_THAI_LAO_DONG;
            m_sle_chon_trang_thai_lao_dong.Properties.ValueMember = V_DM_TRANG_THAI_LAO_DONG.ID;
            m_sle_chon_trang_thai_lao_dong.Properties.DisplayMember = V_DM_TRANG_THAI_LAO_DONG.TEN_TRANG_THAI_LD;

            m_sle_chon_trang_thai_lao_dong.Properties.PopulateViewColumns();
            m_sle_chon_trang_thai_lao_dong.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            m_sle_chon_trang_thai_lao_dong.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
        }

        private void load_data_2_grid()
        {
            CHRMCommon.make_stt(m_grv_bao_cao_trang_thai_lao_dong_nhan_vien);
            DS_V_F356_BAO_CAO_TRANG_THAI_LAO_DONG_CUA_NHAN_VIEN v_ds_v_f356 = new DS_V_F356_BAO_CAO_TRANG_THAI_LAO_DONG_CUA_NHAN_VIEN();
            US_V_F356_BAO_CAO_TRANG_THAI_LAO_DONG_CUA_NHAN_VIEN v_us_v_f356 = new US_V_F356_BAO_CAO_TRANG_THAI_LAO_DONG_CUA_NHAN_VIEN();
            if (m_sle_chon_nhan_vien.EditValue == null)
            {
                if (m_sle_chon_trang_thai_lao_dong.EditValue == null)
                {
                    v_us_v_f356.FillDataset_by_id_nv(v_ds_v_f356, m_load_data_toan_bo_nv);
                }
                else
                {
                    v_us_v_f356.FillDataset_by_id_nv_and_id_trang_thai_ld(v_ds_v_f356, m_load_data_toan_bo_nv, (decimal)m_sle_chon_trang_thai_lao_dong.EditValue);
                }
            }
            else
            {
                if (m_sle_chon_trang_thai_lao_dong.EditValue == null)
                {
                    v_us_v_f356.FillDataset_by_id_nv(v_ds_v_f356, (decimal)m_sle_chon_nhan_vien.EditValue);
                }
                else
                {
                    v_us_v_f356.FillDataset_by_id_nv_and_id_trang_thai_ld(v_ds_v_f356, (decimal)m_sle_chon_nhan_vien.EditValue, (decimal)m_sle_chon_trang_thai_lao_dong.EditValue);
                }

            }
            m_grc_bao_cao_trang_thai_lao_dong_nhan_vien.DataSource = v_ds_v_f356.V_F356_BAO_CAO_TRANG_THAI_LAO_DONG_CUA_NHAN_VIEN;
            m_grv_bao_cao_trang_thai_lao_dong_nhan_vien.BestFitColumns();
        }
        private void load_data_2_grid(decimal id_nv)
        {
            DS_V_F356_BAO_CAO_TRANG_THAI_LAO_DONG_CUA_NHAN_VIEN v_ds_v_f356 = new DS_V_F356_BAO_CAO_TRANG_THAI_LAO_DONG_CUA_NHAN_VIEN();
            US_V_F356_BAO_CAO_TRANG_THAI_LAO_DONG_CUA_NHAN_VIEN v_us_v_f356 = new US_V_F356_BAO_CAO_TRANG_THAI_LAO_DONG_CUA_NHAN_VIEN();
            v_us_v_f356.FillDataset(v_ds_v_f356, "WHERE ID_NHAN_VIEN = " + m_dc_id_nv_dang_dieu_chinh + " AND DA_XOA = 'N'");
            m_grc_bao_cao_trang_thai_lao_dong_nhan_vien.DataSource = v_ds_v_f356.V_F356_BAO_CAO_TRANG_THAI_LAO_DONG_CUA_NHAN_VIEN;
        }
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

        private decimal find_id_nv(string ma_nv)
        {
            US_DM_NHAN_VIEN v_us = new US_DM_NHAN_VIEN();
            DS_DM_NHAN_VIEN v_ds = new DS_DM_NHAN_VIEN();

            v_us.FillDataset(v_ds);

            string v_str_filter = "MA_NV = " + ma_nv;
            DataRow[] v_dr = v_ds.DM_NHAN_VIEN.Select(v_str_filter);

            if (v_dr.Count() == 0)
            {
                return -1;
            }
            else
            {
                return CIPConvert.ToDecimal(v_dr.First()["ID"].ToString());
            }
        }

        #endregion

        private void set_define_events()
        {
            this.Load += f356_bao_cao_trang_thai_lao_dong_cua_nhan_vien_Load;
            this.FormClosed += f356_bao_cao_trang_thai_lao_dong_cua_nhan_vien_FormClosed;
            m_cmd_search.Click += m_cmd_search_Click;
            m_cmd_delete.Click += m_cmd_delete_Click;
            m_cmd_insert.Click += m_cmd_insert_Click;
            m_cmd_update.Click += m_cmd_update_Click;
            m_cmd_xuat_excel.Click += m_cmd_xuat_excel_Click;
            m_grv_bao_cao_trang_thai_lao_dong_nhan_vien.SelectionChanged += M_grv_bao_cao_trang_thai_lao_dong_nhan_vien_Click;
            m_grv_bao_cao_trang_thai_lao_dong_nhan_vien.Click += M_grv_bao_cao_trang_thai_lao_dong_nhan_vien_Click;
            m_grv_bao_cao_trang_thai_lao_dong_nhan_vien.FocusedRowChanged += M_grv_bao_cao_trang_thai_lao_dong_nhan_vien_Click;
            m_sle_chon_nhan_vien.EditValueChanged += m_sle_chon_nhan_vien_EditValueChanged;
        }

        private void M_grv_bao_cao_trang_thai_lao_dong_nhan_vien_Click(object sender, EventArgs e)
        {
            try
            {
                if (m_grv_bao_cao_trang_thai_lao_dong_nhan_vien.GetSelectedRows().ToList().Count == 0)
                {
                    if (m_e_view_mode == ViewMode.Thuong)
                    {
                        return;
                    }
                    m_cmd_insert.Enabled = false;
                    m_cmd_update.Enabled = false;
                    return;
                }
                string ma_nv = m_grv_bao_cao_trang_thai_lao_dong_nhan_vien.GetDataRow(m_grv_bao_cao_trang_thai_lao_dong_nhan_vien.GetSelectedRows()[0])["MA_NV"].ToString();
                if (ma_nv == "")
                {
                    if (m_e_view_mode == ViewMode.Thuong)
                    {
                        return;
                    }
                    m_cmd_insert.Enabled = false;
                    m_cmd_update.Enabled = false;
                    return;
                }
                m_cmd_insert.Enabled = true;
                m_cmd_update.Enabled = true;
                m_dc_id_nv_dang_dieu_chinh = find_id_nv(ma_nv);
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
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

        void m_sle_chon_nhan_vien_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (m_sle_chon_nhan_vien.EditValue != null & m_sle_chon_nhan_vien.Text != "")
                {
                    m_dc_id_nv_dang_dieu_chinh = (decimal)m_sle_chon_nhan_vien.EditValue;
                }
                load_data_2_grid();
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
                decimal v_id_gd_trang_thai_lao_dong = (decimal)m_grv_bao_cao_trang_thai_lao_dong_nhan_vien.GetRowCellValue(m_grv_bao_cao_trang_thai_lao_dong_nhan_vien.FocusedRowHandle, "ID");
                if (v_id_gd_trang_thai_lao_dong > 0)
                {
                    US_GD_TRANG_THAI_LAO_DONG v_us = new US_GD_TRANG_THAI_LAO_DONG(v_id_gd_trang_thai_lao_dong);
                    f357_bao_cao_trang_thai_lao_dong_nhan_vien_de v_frm = new f357_bao_cao_trang_thai_lao_dong_nhan_vien_de();
                    v_frm.display_4_update(v_us);
                    load_data_2_grid(m_dc_id_nv_dang_dieu_chinh);
                    m_sle_chon_trang_thai_lao_dong.EditValue = null;
                    //focus_new_row_created(v_id_gd_trang_thai_lao_dong);
                    m_form.update_canh_bao();
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
                // them cho truong hop canh bao
                if (m_e_view_mode == ViewMode.XemCanhBaoDangNghi)
                {
                    US_V_F356_BAO_CAO_TRANG_THAI_LAO_DONG_CUA_NHAN_VIEN v_us = new US_V_F356_BAO_CAO_TRANG_THAI_LAO_DONG_CUA_NHAN_VIEN();
                    DataSet p = v_us.LayDanhSachNhanVienNghiTamThoi();
                    load_data_2_grid(p);
                    return;
                }
                if (m_e_view_mode == ViewMode.XemCanhBaoHetNghi)
                {
                    US_V_F356_BAO_CAO_TRANG_THAI_LAO_DONG_CUA_NHAN_VIEN v_us = new US_V_F356_BAO_CAO_TRANG_THAI_LAO_DONG_CUA_NHAN_VIEN();
                    DataSet p = v_us.LayDanhSachNhanVienDiLamTroLai(DateTime.Now);
                    load_data_2_grid(p);
                    return;
                }
                //
                decimal v_id_gd_trang_thai_lao_dong_moi_tao = 0;
                if (m_dc_id_nv_dang_dieu_chinh > 0)
                {
                    f357_bao_cao_trang_thai_lao_dong_nhan_vien_de v_f = new f357_bao_cao_trang_thai_lao_dong_nhan_vien_de();
                    v_f.display_4_thay_doi_trang_thai(ref v_id_gd_trang_thai_lao_dong_moi_tao, m_dc_id_nv_dang_dieu_chinh);
                    m_sle_chon_trang_thai_lao_dong.EditValue = null;
                    load_data_2_grid(m_dc_id_nv_dang_dieu_chinh);
                    if (v_id_gd_trang_thai_lao_dong_moi_tao != 0)
                    {
                        focus_new_row_created(v_id_gd_trang_thai_lao_dong_moi_tao);
                    }
                    return;
                }
                //f357_bao_cao_trang_thai_lao_dong_nhan_vien_de v_frm = new f357_bao_cao_trang_thai_lao_dong_nhan_vien_de();
                //v_frm.display_4_insert(ref v_id_gd_trang_thai_lao_dong_moi_tao);     
                //m_sle_chon_trang_thai_lao_dong.EditValue = null;
                //load_data_2_grid(m_dc_id_nv_dang_dieu_chinh);
                //if (v_id_gd_trang_thai_lao_dong_moi_tao != 0)
                //{
                //    focus_new_row_created(v_id_gd_trang_thai_lao_dong_moi_tao);
                //}
                m_form.update_canh_bao();
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
                    DataRow v_dr = m_grv_bao_cao_trang_thai_lao_dong_nhan_vien.GetDataRow(m_grv_bao_cao_trang_thai_lao_dong_nhan_vien.FocusedRowHandle);
                    decimal v_id_gd_trang_thai_lao_dong = CIPConvert.ToDecimal(v_dr["ID"]);

                    US_GD_TRANG_THAI_LAO_DONG v_us = new US_GD_TRANG_THAI_LAO_DONG(v_id_gd_trang_thai_lao_dong);
                    v_us.strDA_XOA = "Y";
                    v_us.datNGAY_SUA = DateTime.Now.Date;
                    v_us.strNGUOI_SUA = CAppContext_201.getCurrentUserName();
                    v_us.BeginTransaction();
                    v_us.Update();
                    v_us.CommitTransaction();
                    CHRM_BaseMessages.MsgBox_Infor(CONST_ID_MSGBOX.INFOR_DU_LIEU_DA_DUOC_CAP_NHAT);
                    m_sle_chon_nhan_vien.EditValue = null;
                    load_data_2_grid();
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
            m_form.update_canh_bao();
        }

        void m_cmd_search_Click(object sender, EventArgs e)
        {
            try
            {
                load_data_2_grid();
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

      
    }
}
