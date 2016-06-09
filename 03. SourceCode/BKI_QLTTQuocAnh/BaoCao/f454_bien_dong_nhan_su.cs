using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BKI_DichVuMatDat.US;
using BKI_DichVuMatDat.DS;
using BKI_DichVuMatDat.COMMON;
using IP.Core.IPCommon;
using DevExpress.XtraEditors;
using BKI_DichVuMatDat.XtraReport;

namespace BKI_DichVuMatDat.BaoCao
{
    public partial class f454_bien_dong_nhan_su : Form
    {
        #region Public Interfaces
        public f454_bien_dong_nhan_su()
        {
            InitializeComponent();
            format_controls();
        }
        #endregion

        #region Members
        DateTime m_date = DateTime.Now;
        DataTable m_dt_hop_dong = new DataTable();
        ViewMode m_e_view_mode = ViewMode.DauKy;
        private const string EXPORT_FILE_NAME = "Bao cao bien dong nhan su thang ";
        private DataTable m_dt_dau_ki = new DataTable();
        private DataTable m_dt_ld_tang = new DataTable();
        private DataTable m_dt_chuyen_doi = new DataTable();
        private DataTable m_dt_ld_giam = new DataTable();
        private DataTable m_dt_cuoi_ky = new DataTable();
        private DataTable m_dt_hoc_viec = new DataTable();

        #endregion

        #region Data Structures
        enum ViewMode
        {
            DauKy,
            CuoiKy,
            Tang,
            Giam,
            ChuyenDoi,
            HocViec
        }
        #endregion

        #region Private Methods
        private void format_controls()
        {
            set_defined_events();
            m_lbl_so_ld_dau_ky.Tag = ViewMode.DauKy;
            m_lbl_so_ld_cuoi_ky.Tag = ViewMode.CuoiKy;
            m_lbl_so_ld_giam.Tag = ViewMode.Giam;
            m_lbl_so_ld_tang.Tag = ViewMode.Tang;
            m_lbl_chuyen_hop_dong.Tag = ViewMode.ChuyenDoi;
            m_lbl_hoc_viec.Tag = ViewMode.HocViec;
        }

        private void load_data_thong_ke()
        {
            m_lbl_so_ld_dau_ky.Text = m_dt_dau_ki.Rows.Count.ToString();
            m_lbl_so_ld_cuoi_ky.Text = m_dt_cuoi_ky.Rows.Count.ToString();
            m_lbl_so_ld_giam.Text = m_dt_ld_giam.Rows.Count.ToString();
            m_lbl_so_ld_tang.Text = m_dt_ld_tang.Rows.Count.ToString();
            m_lbl_chuyen_hop_dong.Text = m_dt_chuyen_doi.Rows.Count.ToString();
            m_lbl_hoc_viec.Text = m_dt_hoc_viec.Rows.Count.ToString();
        }

        private void set_init_form_load()
        {
            m_date = DateTime.Now;
            m_dat_chon_thang.EditValue = m_date;
            load_data_to_data_table();
            load_data_to_grid(m_e_view_mode);
            load_data_thong_ke();
        }

        private void load_data_to_grid(ViewMode v)
        {
            switch (v)
            {
                case ViewMode.DauKy:
                    m_lbl_grid.Text = "NHÂN SỰ ĐẦU KỲ";
                    m_grc.DataSource = m_dt_dau_ki;
                    break;
                case ViewMode.CuoiKy:
                    m_lbl_grid.Text = "NHÂN SỰ CUỐI KỲ";
                    m_grc.DataSource = m_dt_cuoi_ky;
                    break;
                case ViewMode.Tang:
                    m_lbl_grid.Text = "NHÂN SỰ TĂNG";
                    m_grc.DataSource = m_dt_ld_tang;
                    break;
                case ViewMode.Giam:
                    m_lbl_grid.Text = "NHÂN SỰ GIẢM";
                    m_grc.DataSource = m_dt_ld_giam;
                    break;
                case ViewMode.ChuyenDoi:
                    m_lbl_grid.Text = "NHÂN SỰ CHUYỂN ĐỔI HỢP ĐỒNG";
                    m_grc.DataSource = m_dt_chuyen_doi;
                    break;
                case ViewMode.HocViec:
                    m_lbl_grid.Text = "NHÂN SỰ HỌC VIỆC";
                    m_grc.DataSource = m_dt_hoc_viec;
                    break;
                default:
                    break;
            }
            m_grv.BestFitColumns();
            CHRMCommon.make_stt(m_grv);
        }

        #endregion

        #region Event Handlers
        private void set_defined_events()
        {
            this.Load += F454_bien_dong_nhan_su_Load;
            m_btn_xem.Click += M_btn_xem_Click;
            m_btn_xuat_excel.Click += M_btn_xuat_excel_Click;

            //
            m_lbl_so_ld_giam.Click += M_lbl_so_ld_Click;
            m_lbl_so_ld_tang.Click += M_lbl_so_ld_Click;
            m_lbl_so_ld_dau_ky.Click += M_lbl_so_ld_Click;
            m_lbl_so_ld_cuoi_ky.Click += M_lbl_so_ld_Click;
            m_lbl_chuyen_hop_dong.Click += M_lbl_so_ld_Click;
            m_lbl_hoc_viec.Click += M_lbl_so_ld_Click;
        }

        private void M_btn_xuat_excel_Click(object sender, EventArgs e)
        {
            try
            {
                ReportHelper.ExportXLS(m_grc, "BÁO CÁO BIẾN ĐỘNG NHÂN SỰ THÁNG " + m_date.Month + "/" + m_date.Year,
                                                EXPORT_FILE_NAME + m_date.Month + "/" + m_date.Year);
            }
            catch (Exception ex)
            {
                CSystemLog_301.ExceptionHandle(ex);
            }
        }

        private void M_lbl_so_ld_Click(object sender, EventArgs e)
        {
            try
            {
                var p = (ViewMode)Enum.Parse(typeof(ViewMode), (sender as LabelControl).Tag.ToString());
                m_e_view_mode = p;
                load_data_to_grid(p);
            }
            catch (Exception ex)
            {
                CSystemLog_301.ExceptionHandle(ex);
            }
        }

        private void M_btn_xem_Click(object sender, EventArgs e)
        {
            try
            {
                if (m_dat_chon_thang.EditValue == null)
                {
                    CHRM_BaseMessages.MsgBox_Error("Chọn tháng để xem");
                    return;
                }
                m_e_view_mode = ViewMode.DauKy;
                m_date = m_dat_chon_thang.DateTime;

                load_data_to_data_table();
                load_data_to_grid(m_e_view_mode);
                load_data_thong_ke();
            }
            catch (Exception ex)
            {
                CSystemLog_301.ExceptionHandle(ex);
            }
        }

        private void load_data_to_data_table()
        {
            US_GD_HOP_DONG v_us = new US_GD_HOP_DONG();
            m_dt_dau_ki = v_us.lay_danh_sach_nhan_su_dau_ky(m_date.Month, m_date.Year);
            m_dt_cuoi_ky = v_us.lay_danh_sach_nhan_su_cuoi_ky(m_date.Month, m_date.Year);
            m_dt_ld_giam = v_us.lay_danh_sach_nhan_su_giam_trong_ky(m_date.Month, m_date.Year);
            m_dt_ld_tang = v_us.lay_danh_sach_nhan_su_tang_trong_ky(m_date.Month, m_date.Year);
            m_dt_chuyen_doi = v_us.lay_danh_sach_nhan_su_chuyen_doi(m_date.Month, m_date.Year);
            m_dt_hoc_viec = v_us.lay_danh_sach_hoc_viec_trong_ky(m_date.Month, m_date.Year);
        }

        private void F454_bien_dong_nhan_su_Load(object sender, EventArgs e)
        {
            try
            {
                set_init_form_load();
            }
            catch (Exception ex)
            {
                CSystemLog_301.ExceptionHandle(ex);
            }
        }
        #endregion
    }
}
