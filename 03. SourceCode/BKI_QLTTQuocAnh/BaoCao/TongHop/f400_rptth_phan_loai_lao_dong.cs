using BKI_DichVuMatDat.DanhMuc;
using BKI_DichVuMatDat.DS.CDBNames;
using BKI_DichVuMatDat.NghiepVu.NhanSu;
using BKI_DichVuMatDat.US;
using DevExpress.XtraSplashScreen;
using IP.Core.IPCommon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BKI_DichVuMatDat.BaoCao.TongHop
{
    public partial class f400_rptth_phan_loai_lao_dong : Form
    {
        public f400_rptth_phan_loai_lao_dong()
        {
            InitializeComponent();
            format_controls();
        }
        #region Data Structures
        #endregion
        #region Members
        #endregion
        #region Private Methods
        private void format_controls()
        {
            set_define_events();
        }
        private DateTime lay_ngay()
        {
            return m_dat_tai_ngay.DateTime.Date;
        }
        private void load_data_to_grid()
        {
            //SplashScreenManager.ShowForm(typeof(F_wait_form));
            try
            {
                US_DM_NHAN_VIEN v_us = new US_DM_NHAN_VIEN();
                m_tree_don_vi.ParentFieldName = DM_DON_VI.ID_DON_VI_CAP_TREN;
                m_tree_don_vi.DataSource = v_us.BangPhanLoaiLaoDong(lay_ngay());
                m_tree_don_vi.ExpandAll();
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                //SplashScreenManager.CloseForm();
            }
        }
        private void hien_thi_detail(decimal ip_dc_id_don_vi, string ip_str_focused_column_name)
        {
            f329_lap_hop_dong_v5 v_frm_hd = new f329_lap_hop_dong_v5();
            f151_Danh_sach_nhan_vien_master v_frm_nv = new f151_Danh_sach_nhan_vien_master();
            string v_str_filter = "";
            switch(ip_str_focused_column_name)
            {
                case CONST_COL_PHAN_LOAI_LD_NAME.TONG_SO_HD:
                    v_str_filter = "[ID_DON_VI] = " + ip_dc_id_don_vi +
                                            " and NGAY_BAT_DAU <= #" + m_dat_tai_ngay.DateTime.ToString("MM/dd/yyyy") + "#" +
                                            " and (NGAY_KET_THUC IS NULL or NGAY_KET_THUC > #" + m_dat_tai_ngay.DateTime.ToString("MM/dd/yyyy") + "#" + ")";
                    v_frm_hd.display_for_phan_loai_lao_dong(v_str_filter);
                    break;
                case CONST_COL_PHAN_LOAI_LD_NAME.HDHV:
                    v_str_filter = "[ID_DON_VI] = " + ip_dc_id_don_vi +
                                            "and ID_LOAI_HOP_DONG = " + CONST_ID_LOAI_HOP_DONG.HOP_DONG_HOC_VIEC +
                                            " and NGAY_BAT_DAU <= #" + m_dat_tai_ngay.DateTime.ToString("MM/dd/yyyy") + "#" +
                                            " and (NGAY_KET_THUC IS NULL or NGAY_KET_THUC > #" + m_dat_tai_ngay.DateTime.ToString("MM/dd/yyyy") + "#" + ")";
                    v_frm_hd.display_for_phan_loai_lao_dong(v_str_filter);
                    break;
                case CONST_COL_PHAN_LOAI_LD_NAME.HDTV:
                    v_str_filter = "[ID_DON_VI] = " + ip_dc_id_don_vi +
                                            "and ID_LOAI_HOP_DONG = " + CONST_ID_LOAI_HOP_DONG.HOP_DONG_THU_VIEC +
                                            " and NGAY_BAT_DAU <= #" + m_dat_tai_ngay.DateTime.ToString("MM/dd/yyyy") + "#" +
                                            " and (NGAY_KET_THUC IS NULL or NGAY_KET_THUC > #" + m_dat_tai_ngay.DateTime.ToString("MM/dd/yyyy") + "#" + ")";
                    v_frm_hd.display_for_phan_loai_lao_dong(v_str_filter);
                    break;
                case CONST_COL_PHAN_LOAI_LD_NAME.HD1N:
                    v_str_filter = "[ID_DON_VI] = " + ip_dc_id_don_vi +
                                            "and ID_LOAI_HOP_DONG = " + CONST_ID_LOAI_HOP_DONG.HOP_DONG_MOT_NAM +
                                            " and NGAY_BAT_DAU <= #" + m_dat_tai_ngay.DateTime.ToString("MM/dd/yyyy") + "#" +
                                            " and (NGAY_KET_THUC IS NULL or NGAY_KET_THUC > #" + m_dat_tai_ngay.DateTime.ToString("MM/dd/yyyy") + "#" + ")";
                    v_frm_hd.display_for_phan_loai_lao_dong(v_str_filter);
                    break;
                case CONST_COL_PHAN_LOAI_LD_NAME.HD1N2016:
                    v_str_filter = "[ID_DON_VI] = " + ip_dc_id_don_vi +
                                            "and ID_LOAI_HOP_DONG = " + CONST_ID_LOAI_HOP_DONG.HOP_DONG_1N_2016 +
                                            " and NGAY_BAT_DAU <= #" + m_dat_tai_ngay.DateTime.ToString("MM/dd/yyyy") + "#" +
                                            " and (NGAY_KET_THUC IS NULL or NGAY_KET_THUC > #" + m_dat_tai_ngay.DateTime.ToString("MM/dd/yyyy") + "#" + ")";
                    v_frm_hd.display_for_phan_loai_lao_dong(v_str_filter);
                    break;
                case CONST_COL_PHAN_LOAI_LD_NAME.HD3N:
                    v_str_filter = "[ID_DON_VI] = " + ip_dc_id_don_vi +
                                             "and ID_LOAI_HOP_DONG = " + CONST_ID_LOAI_HOP_DONG.HOP_DONG_3_NAM +
                                             " and NGAY_BAT_DAU <= #" + m_dat_tai_ngay.DateTime.ToString("MM/dd/yyyy") + "#" +
                                             " and (NGAY_KET_THUC IS NULL or NGAY_KET_THUC > #" + m_dat_tai_ngay.DateTime.ToString("MM/dd/yyyy") + "#" + ")";
                    v_frm_hd.display_for_phan_loai_lao_dong(v_str_filter);
                    break;
                case CONST_COL_PHAN_LOAI_LD_NAME.HDKX:
                    v_str_filter = "[ID_DON_VI] = " + ip_dc_id_don_vi +
                                            "and ID_LOAI_HOP_DONG = " + CONST_ID_LOAI_HOP_DONG.HOP_DONG_KHONG_XAC_DINH +
                                            " and NGAY_BAT_DAU <= #" + m_dat_tai_ngay.DateTime.ToString("MM/dd/yyyy") + "#" +
                                            " and (NGAY_KET_THUC IS NULL or NGAY_KET_THUC > #" + m_dat_tai_ngay.DateTime.ToString("MM/dd/yyyy") + "#" + ")";
                    v_frm_hd.display_for_phan_loai_lao_dong(v_str_filter);
                    break;

                case CONST_COL_PHAN_LOAI_LD_NAME.SAU_DAI_HOC:
                    v_frm_nv.display_for_phan_loai_lao_dong(CONST_COL_PHAN_LOAI_LD_NAME.SAU_DAI_HOC, m_dat_tai_ngay.DateTime.Date, ip_dc_id_don_vi);
                    break;
                case CONST_COL_PHAN_LOAI_LD_NAME.DAI_HOC:
                    v_frm_nv.display_for_phan_loai_lao_dong(CONST_COL_PHAN_LOAI_LD_NAME.DAI_HOC, m_dat_tai_ngay.DateTime.Date, ip_dc_id_don_vi);
                    break;
                case CONST_COL_PHAN_LOAI_LD_NAME.CAO_DANG:
                    v_frm_nv.display_for_phan_loai_lao_dong(CONST_COL_PHAN_LOAI_LD_NAME.CAO_DANG, m_dat_tai_ngay.DateTime.Date, ip_dc_id_don_vi);
                    break;
                case CONST_COL_PHAN_LOAI_LD_NAME.TRUNG_CAP:
                    v_frm_nv.display_for_phan_loai_lao_dong(CONST_COL_PHAN_LOAI_LD_NAME.TRUNG_CAP, m_dat_tai_ngay.DateTime.Date, ip_dc_id_don_vi);
                    break;
                case CONST_COL_PHAN_LOAI_LD_NAME.KHAC:
                    v_frm_nv.display_for_phan_loai_lao_dong(CONST_COL_PHAN_LOAI_LD_NAME.KHAC, m_dat_tai_ngay.DateTime.Date, ip_dc_id_don_vi);
                    break;
                case CONST_COL_PHAN_LOAI_LD_NAME.NAM:
                    v_frm_nv.display_for_phan_loai_gioi_tinh("Y", m_dat_tai_ngay.DateTime.Date, ip_dc_id_don_vi);
                    break;
                case CONST_COL_PHAN_LOAI_LD_NAME.NU:
                    v_frm_nv.display_for_phan_loai_gioi_tinh("N", m_dat_tai_ngay.DateTime.Date, ip_dc_id_don_vi);
                    break;
                case CONST_COL_PHAN_LOAI_LD_NAME.T26:
                    v_frm_nv.display_for_phan_loai_do_tuoi(CONST_COL_PHAN_LOAI_LD_NAME.T26, m_dat_tai_ngay.DateTime.Date, ip_dc_id_don_vi);
                    break;
                case CONST_COL_PHAN_LOAI_LD_NAME.T26to30:
                    v_frm_nv.display_for_phan_loai_do_tuoi(CONST_COL_PHAN_LOAI_LD_NAME.T26to30, m_dat_tai_ngay.DateTime.Date, ip_dc_id_don_vi);
                    break;
                case CONST_COL_PHAN_LOAI_LD_NAME.T31to35:
                    v_frm_nv.display_for_phan_loai_do_tuoi(CONST_COL_PHAN_LOAI_LD_NAME.T31to35, m_dat_tai_ngay.DateTime.Date, ip_dc_id_don_vi);
                    break;
                case CONST_COL_PHAN_LOAI_LD_NAME.T36to40:
                    v_frm_nv.display_for_phan_loai_do_tuoi(CONST_COL_PHAN_LOAI_LD_NAME.T36to40, m_dat_tai_ngay.DateTime.Date, ip_dc_id_don_vi);
                    break;
                case CONST_COL_PHAN_LOAI_LD_NAME.T41to45:
                    v_frm_nv.display_for_phan_loai_do_tuoi(CONST_COL_PHAN_LOAI_LD_NAME.T41to45, m_dat_tai_ngay.DateTime.Date, ip_dc_id_don_vi);
                    break;
                case CONST_COL_PHAN_LOAI_LD_NAME.T46to50:
                    v_frm_nv.display_for_phan_loai_do_tuoi(CONST_COL_PHAN_LOAI_LD_NAME.T46to50, m_dat_tai_ngay.DateTime.Date, ip_dc_id_don_vi);
                    break;
                case CONST_COL_PHAN_LOAI_LD_NAME.T51to55:
                    v_frm_nv.display_for_phan_loai_do_tuoi(CONST_COL_PHAN_LOAI_LD_NAME.T51to55, m_dat_tai_ngay.DateTime.Date, ip_dc_id_don_vi);
                    break;
                case CONST_COL_PHAN_LOAI_LD_NAME.T55:
                    v_frm_nv.display_for_phan_loai_do_tuoi(CONST_COL_PHAN_LOAI_LD_NAME.T55, m_dat_tai_ngay.DateTime.Date, ip_dc_id_don_vi);
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region Events
        private void set_define_events()
        {
            Load += f400_rptth_phan_loai_lao_dong_Load;
            m_cmd_fillter.Click += m_cmd_fillter_Click;
            m_tree_don_vi.DoubleClick += m_tree_don_vi_DoubleClick;
            m_cmd_xuat_excel.Click += m_cmd_xuat_excel_Click;
        }

        void m_cmd_xuat_excel_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "xls files (*.xls)|*.xls|All files (*.*)|*.*";
                saveFileDialog1.RestoreDirectory = true;
                if(saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    m_tree_don_vi.ExportToXls(saveFileDialog1.FileName);
                    DevExpress.XtraEditors.XtraMessageBox.Show("Trích xuất dữ liệu thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_tree_don_vi_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var v_dc_id_don_vi = Convert.ToDecimal(m_tree_don_vi.FocusedNode.GetValue("ID"));
                var v_str_focused_column_name = m_tree_don_vi.FocusedColumn.Name;
                hien_thi_detail(v_dc_id_don_vi, v_str_focused_column_name);
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_fillter_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(F_wait_form));
            try
            {
                load_data_to_grid();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
            finally
            {
                SplashScreenManager.CloseForm();
            }
        }

        void f400_rptth_phan_loai_lao_dong_Load(object sender, EventArgs e)
        {
            try
            {
                m_dat_tai_ngay.DateTime = DateTime.Now.Date;
                load_data_to_grid();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        #endregion


    }
}
