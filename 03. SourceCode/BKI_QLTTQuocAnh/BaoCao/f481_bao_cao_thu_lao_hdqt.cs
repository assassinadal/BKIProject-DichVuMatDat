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

        private void m_cmd_search_Click(object sender, EventArgs e)
        {
            try
            {
                string s =m_sle_nhom_ld.EditValue.ToString();
                if (m_txt_chon_thang.Text.Trim() !="" && m_txt_chon_nam.Text.Trim() !="" && m_sle_nhom_ld.EditValue.ToString() !="")
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
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            v_ds.Tables.Add(new DataTable());
            v_us.filldatasetBaoCaoThuNhapLDNgoaiBangLuong(v_ds, m_txt_chon_thang.Text, m_txt_chon_nam.Text, m_sle_nhom_ld.EditValue.ToString());
            m_grc_bc_thu_lao.DataSource = v_ds.Tables[0];
        }

        private void f481_bao_cao_thu_lao_hdqt_Load(object sender, EventArgs e)
        {
            load_data_to_sle_nhom_ld();
        }

        private void load_data_to_sle_nhom_ld()
        {
            DataSet v_ds = new DataSet();
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithQuery(v_ds, "Select * from CM_DM_TU_DIEN where ID_LOAI_TU_DIEN= 18");
            m_sle_nhom_ld.Properties.DataSource = v_ds.Tables[0];
            //m_sle_nhom_ld.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            //m_sle_nhom_ld.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
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
                    CHRM_BaseMessages.MsgBox_Infor(CONST_ID_MSGBOX.INFOR_LUU_BAO_CAO_THANH_CONG);
                }
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
    }
}
