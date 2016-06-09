using BKI_DichVuMatDat.DS;
using BKI_DichVuMatDat.US;
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
using BKI_DichVuMatDat.XtraReport;
using DevExpress.XtraPrinting;

namespace BKI_DichVuMatDat.DanhMuc
{
    public partial class F153_DANH_SACH_NHAN_VIEN_THEO_PHONG_BAN : Form
    {
        public F153_DANH_SACH_NHAN_VIEN_THEO_PHONG_BAN()
        {
            InitializeComponent();
            format_controll();
        }

        private void format_controll()
        {
            set_define_event();
            CenterToScreen();
            load_data_to_grid();
            load_danh_sach_don_vi();
        }

        private void load_danh_sach_don_vi()
        {
            US_DM_DON_VI v_us = new US_DM_DON_VI();
            DS_DM_DON_VI v_ds = new DS_DM_DON_VI();
            v_us.FillDataset(v_ds);
            m_sle_chon_don_vi.Properties.DataSource = v_ds.Tables[0];
        }

        private void load_data_to_grid()
        {
            US_DM_NHAN_VIEN v_us = new US_DM_NHAN_VIEN();
            m_grc.DataSource = v_us.LayDanhSachNVTheoPhongBan(get_id_don_vi(), get_id_chuc_vu());
            //m_grc.DataSource = v_us.LayDanhSachNVTheoPhongBan(get_id_don_vi(), get_id_chuc_vu());
            CHRMCommon.make_stt(m_grv);
        }

        private decimal get_id_don_vi()
        {
            if (m_sle_chon_don_vi.EditValue == null)
            {
                return 0;
            }
            return Convert.ToDecimal(m_sle_chon_don_vi.EditValue);
        }

        private decimal get_id_chuc_vu()
        {
            if (m_sle_chon_vi_tri.EditValue == null)
            {
                return 0;
            }
            return Convert.ToDecimal(m_sle_chon_vi_tri.EditValue);
        }

        private void set_define_event()
        {
            Load += F153_DANH_SACH_NHAN_VIEN_THEO_PHONG_BAN_Load;
            m_cmd_filter.Click += M_cmd_filter_Click;
            m_cmd_xuat_excel.Click += M_cmd_xuat_excel_Click;
            m_cmd_chon_file.Click += M_cmd_chon_file_Click;
            m_sle_chon_don_vi.EditValueChanged += M_sle_chon_don_vi_EditValueChanged;
        }

        private void M_sle_chon_don_vi_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (m_sle_chon_don_vi.EditValue == null)
                {
                    return;
                }
                load_data_2_sle_chon_vi_tri();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void load_data_2_sle_chon_vi_tri()
        {
            m_sle_chon_vi_tri.EditValue = null;
            US_DM_CHUC_VU v_us = new US_DM_CHUC_VU();
            DS_DM_CHUC_VU v_ds = new DS_DM_CHUC_VU();
            v_us.FillDataset(v_ds, " where id_don_vi = " + Convert.ToDecimal(m_sle_chon_don_vi.EditValue));
            m_sle_chon_vi_tri.Properties.DataSource = v_ds.Tables[0];
        }

        private void M_cmd_chon_file_Click(object sender, EventArgs e)
        {
            try
            {
                import_excel();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void import_excel()
        {
            F152_DANH_SACH_NHAN_VIEN_EXCEL v_f = new F152_DANH_SACH_NHAN_VIEN_EXCEL();
            v_f.DisplayForUpdate();
            load_data_to_grid();
        }

        private void M_cmd_xuat_excel_Click(object sender, EventArgs e)
        {
            try
            {
                xuat_excel();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void M_cmd_filter_Click(object sender, EventArgs e)
        {
            try
            {
                load_data_to_grid();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void F153_DANH_SACH_NHAN_VIEN_THEO_PHONG_BAN_Load(object sender, EventArgs e)
        {
            set_init_form_load();
        }

        private void set_init_form_load()
        {

        }

        private void xuat_excel()
        {
            gridControl1.DataSource = m_grc.DataSource;
            XlsExportOptions opt = new XlsExportOptions();
            opt.SheetName = "NHAP_LIEU";
            opt.TextExportMode = TextExportMode.Value;
            string path = WinFormControls.saveFileDialog("DANH_SACH_NHAN_VIEN");
            if (!String.IsNullOrEmpty(path))
            {
                gridView1.ExportToXls(path, opt);
                var excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = true;
                Microsoft.Office.Interop.Excel.Workbooks books = excel.Workbooks;
                Microsoft.Office.Interop.Excel.Workbook openexcel = books.Open(path);
            }

        }
    }
}
