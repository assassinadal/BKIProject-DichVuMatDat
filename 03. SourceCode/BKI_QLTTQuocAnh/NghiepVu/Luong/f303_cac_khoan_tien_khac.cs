using BKI_DichVuMatDat.DS;
using BKI_DichVuMatDat.US;
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

namespace BKI_DichVuMatDat.NghiepVu.Luong
{
    public partial class f303_cac_khoan_tien_khac : Form
    {
        public f303_cac_khoan_tien_khac()
        {
            InitializeComponent();
            format_control();
        }

       

        private decimal lay_thang()
        {
            return m_dat_time.DateTime.Month;
        }
        private decimal lay_nam()
        {
            return m_dat_time.DateTime.Year;
        }
        private decimal lay_loai_tien_khac()
        {
            return Convert.ToDecimal(m_cmb_khoan_tien.SelectedValue);
        }
        private void load_data_to_combobox_khoan_tien()
        {
            US_CM_DM_TU_DIEN v_us = new US_CM_DM_TU_DIEN();
            DS_CM_DM_TU_DIEN v_ds = new DS_CM_DM_TU_DIEN();
            v_us.FillDatasetByIdLoaiTuDien(v_ds, 19);
            m_cmb_khoan_tien.DataSource = v_ds.Tables[0];
            m_cmb_khoan_tien.DisplayMember = "TEN";
            m_cmb_khoan_tien.ValueMember = "ID";
        }
        private void load_data_to_grid()
        {
            US_GD_CAC_KHOAN_TIEN_KHAC v_us = new US_GD_CAC_KHOAN_TIEN_KHAC();
            var v_dt_source = v_us.LayDuLieuTheoThang(lay_thang(), lay_nam(), lay_loai_tien_khac());
            m_lbl_thang.Text = lay_thang() + "/" + lay_nam() + "-" + m_cmb_khoan_tien.DisplayMember;
            m_grc_main.DataSource = v_dt_source;
            m_grc_main.RefreshDataSource();
        }

        private void format_control()
        {
            set_define_event();
        }

        private void set_define_event()
        {
            Load += f303_cac_khoan_tien_khac_Load;
            m_cmd_import.Click += m_cmd_import_Click;
            m_cmd_view.Click += m_cmd_view_Click;
        }

        void m_cmd_view_Click(object sender, EventArgs e)
        {
            try
            {
                load_data_to_grid();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_import_Click(object sender, EventArgs e)
        {
            try
            {
                f304_cac_khoan_khac v_frm = new f304_cac_khoan_khac();
                v_frm.Display(m_dat_time.DateTime.Date, lay_loai_tien_khac());
                load_data_to_grid();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void f303_cac_khoan_tien_khac_Load(object sender, EventArgs e)
        {
            try
            {
                m_dat_time.EditValue = DateTime.Now.Date;
                load_data_to_combobox_khoan_tien();
                load_data_to_grid();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
    }
}
