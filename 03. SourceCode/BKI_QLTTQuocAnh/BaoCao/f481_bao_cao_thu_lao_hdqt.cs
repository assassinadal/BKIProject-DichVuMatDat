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
    public partial class f481_bao_cao_thu_lao_hdqt : Form
    {
        public f481_bao_cao_thu_lao_hdqt()
        {
            InitializeComponent();
        }

        decimal m_txt_chon_thang;
        decimal m_txt_chon_nam;

        private void m_cmd_search_Click(object sender, EventArgs e)
        {
            try
            {
                string s = m_sle_nhom_ld.EditValue.ToString();
                if (/*m_txt_chon_thang.Text.Trim() != "" && m_txt_chon_nam.Text.Trim() != "" && */m_sle_nhom_ld.EditValue.ToString() != "")
                {
                    load_data_to_grid();
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void load_data_to_grid()
        {
            CHRMCommon.make_stt(m_grv_hs_bs_hs_athk);
            DataSet v_ds = new DataSet();
            US_GD_THU_NHAP_KHAC v_us = new US_GD_THU_NHAP_KHAC();
            v_ds.Tables.Add(new DataTable());
            v_us.filldatasetBaoCaoThuNhapLDNgoaiBangLuong(v_ds, m_txt_chon_thang.ToString(), m_txt_chon_nam.ToString(), m_sle_nhom_ld.EditValue.ToString());
            m_grc_bc_thu_lao.DataSource = v_ds.Tables[0];
            this.Load += F481_bao_cao_thu_lao_hdqt_Load;
            m_dat_thang.DateTimeChanged += M_dat_thang_DateTimeChanged;
        }

        private void M_dat_thang_DateTimeChanged(object sender, EventArgs e)
        {
            try
            {
                m_txt_chon_nam = m_dat_thang.DateTime.Year;
                m_txt_chon_thang = m_dat_thang.DateTime.Month;
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void F481_bao_cao_thu_lao_hdqt_Load(object sender, EventArgs e)
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

        private void set_init_form_load()
        {
            m_dat_thang.EditValue = DateTime.Now;
        }

        private void f481_bao_cao_thu_lao_hdqt_Load(object sender, EventArgs e)
        {
            load_data_to_sle_nhom_ld();
        }

        private void load_data_to_sle_nhom_ld()
        {
            US_CM_DM_TU_DIEN v_us = new US_CM_DM_TU_DIEN();
            DS_CM_DM_TU_DIEN v_ds = new DS_CM_DM_TU_DIEN();
            v_us.FillDatasetByIdLoaiTuDien(v_ds, 18);
            m_sle_nhom_ld.Properties.DataSource = v_ds.Tables[0];
        }

        private void m_cmd_xuat_excel_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "xls files (*.xls)|*.xls|All files (*.*)|*.*";
                saveFileDialog1.RestoreDirectory = true;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    m_grv_hs_bs_hs_athk.ExportToXls(saveFileDialog1.FileName);
                    CHRM_BaseMessages.MsgBox_Infor(CONST_ID_MSGBOX.INFOR_LUU_BAO_CAO_THANH_CONG);
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
    }
}
