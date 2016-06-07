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

    public partial class f447_thong_ke_nhan_vien_ee : Form
    {
        #region Public Interfaces
        public f447_thong_ke_nhan_vien_ee()
        {
            InitializeComponent();
            format_controls();
        }
        #endregion
        #region Members
        public const string EXPORT_FILE_NAME = "Thong ke nhan vien dang lam viec tai ngay ";
        DateTime m_date = DateTime.Now.Date;
        DataSet m_data_set = new DataSet();
        #endregion
        #region Data Structures
        class StringConstTrinhDo
        {
            public const string THAC_SY = "THẠC SỸ";
            public const string DAI_HOC = "ĐẠI HỌC";
            public const string TRUNG_CAP = "TRUNG CẤP";
            public const string CAO_DANG = "CAO ĐẲNG";
            public const string SO_CAP = "SƠ CẤP";
            public const string NGHE = "NGHỀ";
            public const string PTTH = "PTTH";
            public const string TIEN_SY = "TIẾN SỸ";
            public const string GIAO_SU = "GIÁO SƯ";
            public const string PHO_GIAO_SU = "PHÓ GIÁO SƯ";
        }
        class StringConstLoaiCongTac
        {
            public const string CHINH_THUC = "Chính thức";
            public const string LAM_THOI = "Lâm thời";
            public const string KIEM_NHIEM = "Kiêm nhiệm";
        }
        enum TrinhDo
        {
            GS = 779,
            PGS = 780,
            TS = 781,
            THS = 782,
            DH = 783,
            CD = 784,
            TC = 785,
            SC = 786,
            NG = 791,
            PTTH = 792
        }
        enum LoaiCongTac
        {
            ChinhThuc,
            LamThoi,
            KiemNhiem
        }
        #endregion
        #region Private Methods
        private void format_controls()
        {
            set_defined_events();
            //
            m_lbl_so_nv_nam.Tag = "Y";
            m_lbl_so_nv_nu.Tag = "N";

            m_lbl_so_nv_sau_dai_hoc.Tag = TrinhDo.THS;
            m_lbl_so_nv_dai_hoc.Tag = TrinhDo.DH;
            m_lbl_so_nv_cao_dang.Tag = TrinhDo.CD;
            m_lbl_so_nv_trung_cap.Tag = TrinhDo.TC;
            m_lbl_so_nv_nghe.Tag = TrinhDo.NG;

            m_lbl_kiem_nhiem.Tag = LoaiCongTac.KiemNhiem;
            m_lbl_chinh_thuc.Tag = LoaiCongTac.ChinhThuc;
            m_lbl_lam_thoi.Tag = LoaiCongTac.LamThoi;
        }

        private void set_defined_events()
        {
            this.Load += F447_thong_ke_nhan_vien_ee_Load;
            m_btn_xem.Click += M_btn_xem_Click;
            m_btn_xuat_excel.Click += M_btn_xuat_excel_Click;
            //
            m_lbl_so_nv_nam.DoubleClick += M_lbl_so_nv_nam_DoubleClick;
            m_lbl_so_nv_nu.DoubleClick += M_lbl_so_nv_nu_DoubleClick;
            m_lbl_so_nv_sau_dai_hoc.DoubleClick += M_lbl_so_nv_sau_dai_hoc_DoubleClick;
            m_lbl_so_nv_dai_hoc.DoubleClick += M_lbl_so_nv_sau_dai_hoc_DoubleClick;
            m_lbl_so_nv_cao_dang.DoubleClick += M_lbl_so_nv_sau_dai_hoc_DoubleClick;
            m_lbl_so_nv_trung_cap.DoubleClick += M_lbl_so_nv_sau_dai_hoc_DoubleClick;
            m_lbl_so_nv_nghe.DoubleClick += M_lbl_so_nv_sau_dai_hoc_DoubleClick;
            m_lbl_lam_thoi.DoubleClick += M_lbl_lam_thoi_DoubleClick;
            m_lbl_chinh_thuc.DoubleClick += M_lbl_lam_thoi_DoubleClick;
            m_lbl_kiem_nhiem.DoubleClick += M_lbl_lam_thoi_DoubleClick;
            //
            m_lbl_so_nv_nu.Click += M_lbl_so_nv_nu_DoubleClick;
            m_lbl_so_nv_nam.Click += M_lbl_so_nv_nam_DoubleClick;
            m_lbl_so_nv_sau_dai_hoc.Click += M_lbl_so_nv_sau_dai_hoc_DoubleClick;
            m_lbl_so_nv_dai_hoc.Click += M_lbl_so_nv_sau_dai_hoc_DoubleClick;
            m_lbl_so_nv_cao_dang.Click += M_lbl_so_nv_sau_dai_hoc_DoubleClick;
            m_lbl_so_nv_trung_cap.Click += M_lbl_so_nv_sau_dai_hoc_DoubleClick;
            m_lbl_so_nv_nghe.Click += M_lbl_so_nv_sau_dai_hoc_DoubleClick;
            m_lbl_lam_thoi.Click += M_lbl_lam_thoi_DoubleClick;
            m_lbl_chinh_thuc.Click += M_lbl_lam_thoi_DoubleClick;
            m_lbl_kiem_nhiem.Click += M_lbl_lam_thoi_DoubleClick;
        }

        private void load_data_to_thong_ke()
        {
            thong_ke_gioi_tinh();
            thong_ke_trinh_do_van_hoa();
            thong_ke_loai_cong_tac();
        }

        private void thong_ke_loai_cong_tac()
        {
            var v_dt = m_data_set.Tables[0].AsEnumerable();
            m_lbl_chinh_thuc.Text = StringConstLoaiCongTac.CHINH_THUC + ": " + v_dt.Where(x => x.Field<string>("LOAI_CONG_TAC") == StringConstLoaiCongTac.CHINH_THUC).Count();
            m_lbl_kiem_nhiem.Text = StringConstLoaiCongTac.KIEM_NHIEM + ": " + v_dt.Where(x => x.Field<string>("LOAI_CONG_TAC") == StringConstLoaiCongTac.KIEM_NHIEM).Count();
            m_lbl_lam_thoi.Text = StringConstLoaiCongTac.LAM_THOI + ": " + v_dt.Where(x => x.Field<string>("LOAI_CONG_TAC") == StringConstLoaiCongTac.LAM_THOI).Count();
        }

        private void thong_ke_trinh_do_van_hoa()
        {
            var v_dt = m_data_set.Tables[0].AsEnumerable().Where(s => s.Field<decimal?>("ID_TRINH_DO") != null);
            m_lbl_so_nv_sau_dai_hoc.Text = "Sau đại học: " + v_dt.Where(x => x.Field<decimal>("ID_TRINH_DO") == (int)TrinhDo.PGS |
                                                                             x.Field<decimal>("ID_TRINH_DO") == (int)TrinhDo.GS |
                                                                             x.Field<decimal>("ID_TRINH_DO") == (int)TrinhDo.THS |
                                                                             x.Field<decimal>("ID_TRINH_DO") == (int)TrinhDo.TS).Count();
            m_lbl_so_nv_dai_hoc.Text = "Đại học: " + v_dt.Where(x => x.Field<decimal>("ID_TRINH_DO") == (int)TrinhDo.DH).Count();
            m_lbl_so_nv_cao_dang.Text = "Cao đẳng: " + v_dt.Where(x => x.Field<decimal>("ID_TRINH_DO") == (int)TrinhDo.CD).Count();
            m_lbl_so_nv_trung_cap.Text = "Trung cấp: " + v_dt.Where(x => x.Field<decimal>("ID_TRINH_DO") == (int)TrinhDo.TC).Count();
            m_lbl_so_nv_nghe.Text = "Nghề, sơ cấp, PTTH: " + v_dt.Where(x => x.Field<decimal>("ID_TRINH_DO") == (int)TrinhDo.PTTH |
                                                                             x.Field<decimal>("ID_TRINH_DO") == (int)TrinhDo.SC |
                                                                             x.Field<decimal>("ID_TRINH_DO") == (int)TrinhDo.NG).Count();
        }

        private void thong_ke_gioi_tinh()
        {
            var v_dt = m_data_set.Tables[0].AsEnumerable();
            m_lbl_so_nv_nam.Text = "Nam: " + v_dt.Where(x => x.Field<string>("GIOI_TINH") == "Y").Count();
            m_lbl_so_nv_nu.Text = "Nữ: " + v_dt.Where(x => x.Field<string>("GIOI_TINH") == "N").Count();
        }

        private void set_init_form_load()
        {
            m_dat_tai_ngay.EditValue = m_date;
            load_data_to_grid(m_date);
            load_data_to_thong_ke();
        }

        private void load_data_to_grid(DateTime ip_date_tai_ngay)
        {
            US_GD_HOP_DONG v_us = new US_GD_HOP_DONG();
            m_data_set = v_us.ThongKeNhanVienTaiNgay(m_date);
            m_grc.DataSource = m_data_set.Tables[0];
            m_grv.BestFitColumns();
        }

        #endregion
        #region Event Handlers

        private void M_lbl_lam_thoi_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var p = (LoaiCongTac)Enum.Parse(typeof(LoaiCongTac), (sender as LabelControl).Tag.ToString());
                switch (p)
                {
                    case LoaiCongTac.ChinhThuc:
                        m_grv.ActiveFilterString = "[LOAI_CONG_TAC] = '" + StringConstLoaiCongTac.CHINH_THUC + "'";
                        break;
                    case LoaiCongTac.LamThoi:
                        m_grv.ActiveFilterString = "[LOAI_CONG_TAC] = '" + StringConstLoaiCongTac.LAM_THOI + "'";
                        break;
                    case LoaiCongTac.KiemNhiem:
                        m_grv.ActiveFilterString = "[LOAI_CONG_TAC] = '" + StringConstLoaiCongTac.KIEM_NHIEM + "'";
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                CSystemLog_301.ExceptionHandle(ex);
            }
        }

        private void M_lbl_so_nv_nu_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                m_grv.ActiveFilterString = "[GIOI_TINH_TEXT] = '" + "Nữ" + "'";
            }
            catch (Exception ex)
            {
                CSystemLog_301.ExceptionHandle(ex);
            }
        }

        private void M_lbl_so_nv_sau_dai_hoc_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var p = (TrinhDo)Enum.Parse(typeof(TrinhDo), (sender as LabelControl).Tag.ToString());
                switch (p)
                {
                    case TrinhDo.GS:
                        break;
                    case TrinhDo.PGS:
                        break;
                    case TrinhDo.TS:
                        break;
                    case TrinhDo.THS:
                        m_grv.ActiveFilterString = "[TRINH_DO] = '" + StringConstTrinhDo.THAC_SY + "' or "
                                                 + "[TRINH_DO] = '" + StringConstTrinhDo.TIEN_SY + "' or "
                                                 + "[TRINH_DO] = '" + StringConstTrinhDo.GIAO_SU + "' or "
                                                 + "[TRINH_DO] = '" + StringConstTrinhDo.PHO_GIAO_SU + "'";
                        break;
                    case TrinhDo.DH:
                        m_grv.ActiveFilterString = "[TRINH_DO] = '" + StringConstTrinhDo.DAI_HOC + "'";
                        break;
                    case TrinhDo.CD:
                        m_grv.ActiveFilterString = "[TRINH_DO] = '" + StringConstTrinhDo.CAO_DANG + "'";
                        break;
                    case TrinhDo.TC:
                        m_grv.ActiveFilterString = "[TRINH_DO] = '" + StringConstTrinhDo.TRUNG_CAP + "'";
                        break;
                    case TrinhDo.SC:
                        break;
                    case TrinhDo.NG:
                        m_grv.ActiveFilterString = "[TRINH_DO] = '" + StringConstTrinhDo.SO_CAP + "' or "
                                               + "[TRINH_DO] = '" + StringConstTrinhDo.NGHE + "' or "
                                               + "[TRINH_DO] = '" + StringConstTrinhDo.PTTH + "'";
                        break;
                    case TrinhDo.PTTH:
                        break;
                    default:
                        break;
                }

            }
            catch (Exception ex)
            {
                CSystemLog_301.ExceptionHandle(ex);
            }
        }

        private void M_lbl_so_nv_nam_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                m_grv.ActiveFilterString = "GIOI_TINH_TEXT = '" + "Nam" + "'";
            }
            catch (Exception ex)
            {
                CSystemLog_301.ExceptionHandle(ex);
            }
        }

        private void M_btn_xuat_excel_Click(object sender, EventArgs e)
        {
            try
            {
                ReportHelper.ExportXLS(m_grc, "THỐNG KÊ NHÂN VIÊN ĐANG LÀM VIỆC TẠI NGÀY " + m_date.Date.ToShortDateString(),
                                                EXPORT_FILE_NAME + m_date.Date.ToShortDateString());
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
                if (m_dat_tai_ngay.EditValue == null)
                {
                    CHRM_BaseMessages.MsgBox_Error("Vui lòng chọn ngày để xem");
                    return;
                }
                m_date = (DateTime)m_dat_tai_ngay.EditValue;
                load_data_to_grid(m_date);
                load_data_to_thong_ke();
            }
            catch (Exception ex)
            {
                CSystemLog_301.ExceptionHandle(ex);
            }
        }

        private void F447_thong_ke_nhan_vien_ee_Load(object sender, EventArgs e)
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
