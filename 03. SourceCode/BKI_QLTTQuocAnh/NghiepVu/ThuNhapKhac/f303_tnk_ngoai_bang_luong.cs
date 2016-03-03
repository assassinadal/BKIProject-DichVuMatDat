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

namespace BKI_DichVuMatDat.NghiepVu.ThuNhapKhac
{
    public partial class f303_tnk_ngoai_bang_luong : Form
    {
        #region Public Interface
        public f303_tnk_ngoai_bang_luong()
        {
            InitializeComponent();
            format_controls();
        }
    
        #endregion

        #region Members
        #endregion

        #region Data Structure
        #endregion

        #region Event Handle
        private void set_define_events()
        {
            m_cmd_search.Click +=m_cmd_search_Click;
            m_cmd_xuat_excel.Click +=m_cmd_xuat_excel_Click;
            m_cmd_insert.Click +=m_cmd_insert_Click;
            m_cmd_update.Click += m_cmd_update_Click;
            m_cmd_delete.Click += m_cmd_delete_Click;
        }

        void m_cmd_delete_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        void m_cmd_update_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void m_cmd_insert_Click(object sender, EventArgs e)
        {
            f304_tnk_ngoai_bang_luong_detail v_f = new f304_tnk_ngoai_bang_luong_detail();
            v_f.display_for_insert();
        }

        private void f481_bao_cao_thu_lao_hdqt_Load(object sender, EventArgs e)
        {
            try
            {
                load_data_to_sle_nhom_ld();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_search_Click(object sender, EventArgs e)
        {
            try
            {
                string s = m_sle_nhom_ld.EditValue.ToString();
                if (m_txt_chon_thang.Text.Trim() != "" && m_txt_chon_nam.Text.Trim() != "" && m_sle_nhom_ld.EditValue.ToString() != "")
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
        #endregion

        #region Private Method
        private void format_controls()
        {
            set_define_events();
        }

        private void load_data_to_grid()
        {
            CHRMCommon.make_stt(m_grv_hs_bs_hs_athk);
            DataSet v_ds = new DataSet();
            US_GD_THU_NHAP_KHAC v_us = new US_GD_THU_NHAP_KHAC();
            v_ds.Tables.Add(new DataTable());
            v_us.filldatasetBaoCaoThuNhapLDNgoaiBangLuong(v_ds, m_txt_chon_thang.Text, m_txt_chon_nam.Text, m_sle_nhom_ld.EditValue.ToString());
            m_grc_bc_thu_lao.DataSource = v_ds.Tables[0];
        }

        private void load_data_to_sle_nhom_ld()
        {
            US_CM_DM_TU_DIEN v_us = new US_CM_DM_TU_DIEN();
            DS_CM_DM_TU_DIEN v_ds = new DS_CM_DM_TU_DIEN();
            v_us.FillDatasetByIdLoaiTuDien(v_ds, 18);
            m_sle_nhom_ld.Properties.DataSource = v_ds.Tables[0];
        }
        #endregion

        
    }
}
