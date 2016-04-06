using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BKI_DichVuMatDat;
using BKI_DichVuMatDat.DanhMuc;
using BKI_DichVuMatDat.US;
using BKI_DichVuMatDat.DS;
using BKI_DichVuMatDat.DS.CDBNames;
using IP.Core.IPCommon;

using DevExpress.XtraEditors;

namespace BKI_DichVuMatDat.NghiepVu
{
    public partial class F503_IMPORT_EXCEL : Form
    {
        public F503_IMPORT_EXCEL()
        {
            InitializeComponent();
            format_controls();
        }

        #region Members

        buoc_hien_tai m_e_buoc_hien_tai = buoc_hien_tai.buoc_1_nhap_ttnv;
        public static bool da_hoan_thanh = false;

        #endregion

        #region Datastructure

        enum buoc_hien_tai
        {
            buoc_1_nhap_ttnv = 1,
            buoc_2_nhap_tthd = 2,
            buoc_3_nhap_ttct = 3,
            buoc_4_nhap_ttbs = 4,
            done = 5,
        }

        #endregion

        #region private methods

        private void set_init_form_load()
        {
            switch (m_e_buoc_hien_tai)
            {
                case buoc_hien_tai.buoc_1_nhap_ttnv:
                    m_cmd_nhap_thong_tin_cong_tac.Enabled = false;
                    m_cmd_nhap_thong_tin_hop_dong.Enabled = false;
                    m_cmd_nhap_thong_tin_nhan_vien.Enabled = true;
                    m_cmd_nhap_thong_tin_tong_hop.Enabled = false;
                    m_cmd_file_excel_nttth.Enabled = false;
                    m_cmd_file_excel_nttnv.Enabled = true;
                    m_cmd_file_excel_nttct.Enabled = false;
                    m_cmd_file_excel_ntthd.Enabled = false;
                    break;
                case buoc_hien_tai.buoc_2_nhap_tthd:
                    m_cmd_nhap_thong_tin_cong_tac.Enabled = false;
                    m_cmd_nhap_thong_tin_hop_dong.Enabled = true;
                    m_cmd_nhap_thong_tin_nhan_vien.Enabled = false;
                    m_cmd_nhap_thong_tin_tong_hop.Enabled = false;
                    m_cmd_file_excel_nttth.Enabled = false;
                    m_cmd_file_excel_ntthd.Enabled = true;
                    m_cmd_file_excel_nttct.Enabled = false;
                    m_cmd_file_excel_nttnv.Enabled = false;
                    break;
                case buoc_hien_tai.buoc_3_nhap_ttct:
                    m_cmd_nhap_thong_tin_cong_tac.Enabled = true;
                    m_cmd_nhap_thong_tin_hop_dong.Enabled = false;
                    m_cmd_nhap_thong_tin_nhan_vien.Enabled = false;
                    m_cmd_nhap_thong_tin_tong_hop.Enabled = false;
                    m_cmd_file_excel_nttth.Enabled = false;
                    m_cmd_file_excel_nttct.Enabled = true;
                    m_cmd_file_excel_nttnv.Enabled = false;
                    m_cmd_file_excel_ntthd.Enabled = false;
                    break;
                case buoc_hien_tai.buoc_4_nhap_ttbs:
                    m_cmd_nhap_thong_tin_cong_tac.Enabled = false;
                    m_cmd_nhap_thong_tin_hop_dong.Enabled = false;
                    m_cmd_nhap_thong_tin_nhan_vien.Enabled = false;
                    m_cmd_nhap_thong_tin_tong_hop.Enabled = true;
                    m_cmd_file_excel_nttth.Enabled = true;
                    m_cmd_file_excel_nttct.Enabled = false;
                    m_cmd_file_excel_nttnv.Enabled = false;
                    m_cmd_file_excel_ntthd.Enabled = false;
                    break;
                case buoc_hien_tai.done:
                    if (CHRM_BaseMessages.MsgBox_Confirm("Bạn có muốn thêm nhân viên mới nữa không ?") == true)
                    {
                        m_e_buoc_hien_tai = buoc_hien_tai.buoc_1_nhap_ttnv;
                        set_init_form_load();
                    }
                    else
                    {
                        this.Close();
                    }
                    break;
                default:
                    break;
            }
        }

        private void format_controls()
        {
            set_define_event();
        }

        private bool chuyen_buoc_tiep_theo()
        {
            if (da_hoan_thanh)
            {
                m_e_buoc_hien_tai++;
                da_hoan_thanh = false;
                return true;
            }
            return false;
        }

        #endregion

        //
        //
        // EVENT HANDLERS
        //
        //

        private void set_define_event()
        {
            this.Load += F503_IMPORT_EXCEL_Load;
            m_cmd_file_excel_nttnv.Click += m_cmd_file_excel_nttnv_Click;
            m_cmd_file_excel_nttct.Click += m_cmd_file_excel_nttct_Click;
            m_cmd_file_excel_ntthd.Click += m_cmd_file_excel_ntthd_Click;
            m_cmd_file_excel_nttth.Click += m_cmd_file_excel_nttth_Click;
            m_cmd_nhap_thong_tin_nhan_vien.Click += m_cmd_nhap_thong_tin_nhan_vien_Click;
            m_cmd_nhap_thong_tin_cong_tac.Click += m_cmd_nhap_thong_tin_cong_tac_Click;
            m_cmd_nhap_thong_tin_hop_dong.Click += m_cmd_nhap_thong_tin_hop_dong_Click;
            m_cmd_nhap_thong_tin_tong_hop.Click += m_cmd_nhap_thong_tin_tong_hop_Click;
        }

        private void m_cmd_nhap_thong_tin_tong_hop_Click(object sender, EventArgs e)
        {
            try
            {
                f370_nhan_vien_loai_lao_dong v_frm = new f370_nhan_vien_loai_lao_dong();
                v_frm.import_excel();
                if (chuyen_buoc_tiep_theo())
                {
                    v_frm.ShowDialog();
                }
                //v_frm.Show();
                //m_e_buoc_hien_tai++;
                set_init_form_load();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_nhap_thong_tin_hop_dong_Click(object sender, EventArgs e)
        {
            try
            {
                f320_lap_hop_dong v_frm = new f320_lap_hop_dong();
                v_frm.import_excel();
                if (chuyen_buoc_tiep_theo())
                {
                    v_frm.ShowDialog();
                }
                //v_frm.Show();
                //m_e_buoc_hien_tai++;
                set_init_form_load();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_nhap_thong_tin_cong_tac_Click(object sender, EventArgs e)
        {
            try
            {
                f350_quan_ly_vi_tri_cong_tac v_frm = new f350_quan_ly_vi_tri_cong_tac();
                v_frm.import_excel();
                if (chuyen_buoc_tiep_theo())
                {
                    v_frm.ShowDialog();
                }
                //v_frm.Show();
                //m_e_buoc_hien_tai++;
                set_init_form_load();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_nhap_thong_tin_nhan_vien_Click(object sender, EventArgs e)
        {
            try
            {
                f151_Danh_sach_nhan_vien_master v_frm = new f151_Danh_sach_nhan_vien_master();
                v_frm.import_excel();
                if (chuyen_buoc_tiep_theo())
                {
                    v_frm.ShowDialog();
                }
                //v_frm.Show();
                //m_e_buoc_hien_tai++;
                set_init_form_load();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_file_excel_nttth_Click(object sender, EventArgs e)
        {
            try
            {
                WinFormControls.openTemplate("");
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_file_excel_ntthd_Click(object sender, EventArgs e)
        {
            try
            {
                WinFormControls.openTemplate(CONST_EXCEL_TEMPLATE.HOP_DONG_TEMPLATE);
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_file_excel_nttct_Click(object sender, EventArgs e)
        {
            try
            {
                WinFormControls.openTemplate(CONST_EXCEL_TEMPLATE.CONG_TAC_TEMPLATE);
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_file_excel_nttnv_Click(object sender, EventArgs e)
        {
            try
            {
                WinFormControls.openTemplate(CONST_EXCEL_TEMPLATE.DANH_SACH_NHAN_VIEN_TEMPLATE);
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void F503_IMPORT_EXCEL_Load(object sender, EventArgs e)
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
