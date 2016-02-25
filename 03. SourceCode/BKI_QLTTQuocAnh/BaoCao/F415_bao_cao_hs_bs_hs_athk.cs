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

namespace BKI_DichVuMatDat.BaoCao
{
    public partial class F415_bao_cao_hs_bs_hs_athk : Form
    {
        public F415_bao_cao_hs_bs_hs_athk()
        {
            InitializeComponent();
            format_controls();
        }

        #region public interface

        #endregion

        #region Members

        #endregion

        #region Private methods
        private void format_controls()
        {
            this.m_grv_hs_bs_hs_athk.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(WinFormControls.m_grv_PopupMenuShowing);
            this.m_grv_hs_bs_hs_athk.OptionsPrint.AutoWidth = false;
            set_define_events();
            this.KeyPreview = true;
        }

        private void set_intial_form_load()
        {
            m_txt_chon_nam.Text = "";
            m_txt_chon_nam.Text = DateTime.Now.Year.ToString();

        }

        private void load_data_2_grid()
        {
            CHRMCommon.make_stt(m_grv_hs_bs_hs_athk);

            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithQuery(v_ds, "SELECT * FROM V_GD_GS_BS_HS_ATHK WHERE NAM = " + CIPConvert.ToDecimal(m_txt_chon_nam.Text.Trim()));

            m_grc_hs_bs_hs_athk.DataSource = v_ds.Tables[0];
        }

        private void load_data_2_grid(decimal ip_dc_thang)
        {
            CHRMCommon.make_stt(m_grv_hs_bs_hs_athk);

            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithQuery(v_ds, "SELECT * FROM V_GD_GS_BS_HS_ATHK WHERE THANG = " + CIPConvert.ToDecimal(m_txt_chon_thang.Text.Trim()) + " AND NAM = " + CIPConvert.ToDecimal(m_txt_chon_nam.Text.Trim()));

            m_grc_hs_bs_hs_athk.DataSource = v_ds.Tables[0];
        }

        private void xoa_he_so_thang(decimal ip_thang, decimal ip_nam)
        {
            US_GD_HS_BO_SUNG_AN_TOAN_HANG_KHONG v_us_hs = new US_GD_HS_BO_SUNG_AN_TOAN_HANG_KHONG();
            v_us_hs.xoa_du_lieu_athk_bsl_thang(ip_thang, ip_nam);
        }

        private void tinh_lai_he_so_thang(decimal ip_dc_thang, decimal ip_dc_nam)
        {
            US_DM_NHAN_VIEN v_us_dung_chung = new US_DM_NHAN_VIEN();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());


            var dlg = XtraMessageBox.Show("Bạn có chắc chắn muốn tính lại hệ số ATHK & HSBS, " + 
                                                   "việc tính lại sẽ xóa dữ liệu cũ và thêm dữ liệu mới sau khi tính toán xong!" + 
                                                    "\nẤn YES để tính lại" +
                                                    "\nẤn NO để tiếp tục tính (trong trường hợp quá trình tính lại bị gián đoạn)" +
                                                    "\nẤn CANCEL để hủy hành động", "XÁC NHẬN", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if(dlg == System.Windows.Forms.DialogResult.Cancel)
            {
                return;
            }
            else if(dlg == System.Windows.Forms.DialogResult.No)
            {
                v_us_dung_chung.FillDatasetNhanVienCanInsertHeSo(v_ds, ip_dc_thang, ip_dc_nam);
            }
            else
            {
                xoa_he_so_thang(ip_dc_thang, ip_dc_nam);
                v_us_dung_chung.FillDatasetNhanVienCanInsertHeSo(v_ds, ip_dc_thang, ip_dc_nam);
            }
            
            for(int i = 0; i < v_ds.Tables[0].Rows.Count; i++)
            {
                decimal v_id_nv = CIPConvert.ToDecimal(v_ds.Tables[0].Rows[i]["ID_NHAN_VIEN"].ToString());
                US_GD_HS_BO_SUNG_AN_TOAN_HANG_KHONG v_us = new US_GD_HS_BO_SUNG_AN_TOAN_HANG_KHONG();

                v_us.insert_data_by_proc(v_id_nv, ip_dc_thang, ip_dc_nam);
            }
            DevExpress.XtraEditors.XtraMessageBox.Show("Thành công!!!", "THÔNG BÁO");
            load_data_2_grid(ip_dc_thang);
        }

        private void fill_data_2_grid(string ip_path_excel)
        {
            try
            {
                m_grc_hs_bs_hs_athk.DataSource = null;
                WinFormControls.load_xls_to_gridview(ip_path_excel, m_grc_hs_bs_hs_athk);
            }
            catch(Exception)
            {
                throw;
            }
        }
        #endregion
        private void set_define_events()
        {
            this.Load += F415_bao_cao_hs_bs_hs_athk_Load;
            m_cmd_search.Click += m_cmd_search_Click;
        }

        void m_cmd_search_Click(object sender, EventArgs e)
        {
            try
            {
                if (m_txt_chon_thang.Text == "")
                {
                    load_data_2_grid();
                }
                else
                {
                    load_data_2_grid(CIPConvert.ToDecimal(m_txt_chon_nam.Text));
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }            
        }

        private bool check_validate_data_is_ok(string ip_str_ngay_cham_cong)
        {
            for (int i = 0; i < ip_str_ngay_cham_cong.Length; i++)
            {
                if (char.IsDigit(ip_str_ngay_cham_cong[i]) == false)
                    return false;
            }
            return true;
        }

        void F415_bao_cao_hs_bs_hs_athk_Load(object sender, EventArgs e)
        {
            try
            {
                set_intial_form_load();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_tinh_lai_Click(object sender, EventArgs e)
        {
            try
            {
                tinh_lai_he_so_thang(Convert.ToDecimal(m_txt_chon_thang.Text), Convert.ToDecimal(m_txt_chon_nam.Text));
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_import_Click(object sender, EventArgs e)
        {
            try
            {
                //tinh_lai_he_so_thang(Convert.ToDecimal(m_txt_chon_thang.Text), Convert.ToDecimal(m_txt_chon_nam.Text));
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_xuat_excel_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "xls files (*.xls)|*.xls|All files (*.*)|*.*";
                saveFileDialog1.RestoreDirectory = true;
                if(saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    m_grv_hs_bs_hs_athk.ExportToXls(saveFileDialog1.FileName);
                    DevExpress.XtraEditors.XtraMessageBox.Show("Lưu báo cáo thành công");
                }
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_import_excel_Click(object sender, EventArgs e)
        {
            try
            {
                fill_data_2_grid(WinFormControls.openFileDialog());
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
    }
}
