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

        int m_trang_thai_buoc_1 = -1;
        // m_trang_thai_buoc_1 sau bước 1  sẽ trả về id_nhan_vien
        int m_trang_thai_buoc_2 = -1;
        int m_trang_thai_buoc_3_thanh_cong = -1;
        int m_trang_thai_buoc_4 = -1;

        #endregion

        #region private methods

        private void set_init_form_load()
        {

        }

        private void format_controls()
        {
            set_define_event();
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
                F501_THONG_TIN_BO_SUNG_NHAN_VIEN v_frm = new F501_THONG_TIN_BO_SUNG_NHAN_VIEN();
                v_frm.Show();
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
                f320_lap_hop_dong_V2 v_frm = new f320_lap_hop_dong_V2();
                v_frm.Show();
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
                v_frm.Show();
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
                v_frm.Show();
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
                WinFormControls.openTemplate(".xlxs");
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
                WinFormControls.openTemplate(".xlxs");
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
                WinFormControls.openTemplate(".xlxs");
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
                WinFormControls.openTemplate("DANH_SACH_NHAN_VIEN.xlsx");
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
