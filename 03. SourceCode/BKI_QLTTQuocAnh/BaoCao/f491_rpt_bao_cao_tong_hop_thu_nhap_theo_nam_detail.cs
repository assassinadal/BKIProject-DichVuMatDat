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
using IP.Core.IPCommon;

namespace BKI_DichVuMatDat.BaoCao
{
    public partial class f491_rpt_bao_cao_tong_hop_thu_nhap_theo_nam_detail : Form
    {
        public f491_rpt_bao_cao_tong_hop_thu_nhap_theo_nam_detail()
        {
            InitializeComponent();
        }

        internal void DisplayForPresent(decimal v_id_nhan_vien, string m_txt_nam)
        {
            US_RPT_LUONG_V2 v_us = new US_RPT_LUONG_V2();
            DataSet v_ds = new DataSet();
            DataTable v_dt = new DataTable();
            v_ds.Tables.Add(v_dt);
            v_us.FillDatasetBaoCaoThuNhapDoubleClick(v_ds, v_id_nhan_vien, m_txt_nam);
            m_grc_tong_hop.DataSource = v_ds.Tables[0];
            m_adv_tong_hop.BestFitColumns();
            m_adv_tong_hop.ExpandAllGroups();
            fill_du_lieu(v_ds);
            m_lbl_nam_2.Text = m_txt_nam;
            m_lbl_nam_2.ForeColor = Color.Maroon;
            m_lbl_nam_2.Font = new Font("Tahoma", 18, FontStyle.Bold);
            this.ShowDialog();
           
        }

        private void fill_du_lieu(DataSet v_ds)
        {
            m_lbl_ten.Text = v_ds.Tables[0].Rows[0]["HO_TEN"].ToString();
            m_lbl_ten.Font = new Font(m_lbl_ten.Font, FontStyle.Bold);
            m_lbl_ma_nhan_vien.Text = v_ds.Tables[0].Rows[0]["MA_NV"].ToString();
            m_lbl_ma_nhan_vien.Font = new Font(m_lbl_ma_nhan_vien.Font, FontStyle.Bold);
            m_lbl_don_vi.Text = v_ds.Tables[0].Rows[0]["TEN_DON_VI"].ToString();
            m_lbl_don_vi.Font = new Font(m_lbl_don_vi.Font, FontStyle.Bold);
            m_lbl_chuc_vu.Text = v_ds.Tables[0].Rows[0]["CHUC_VU"].ToString();
            m_lbl_chuc_vu.Font = new Font(m_lbl_chuc_vu.Font, FontStyle.Bold);
            m_adv_tong_hop.OptionsView.ColumnAutoWidth = true;
            foreach (DevExpress.XtraGrid.Columns.GridColumn col in ((DevExpress.XtraGrid.Views.Base.ColumnView)m_grc_tong_hop.Views[0]).Columns)
            {
                col.MaxWidth = 90;
                col.MinWidth = 90;
            }
            m_adv_tong_hop.ColumnPanelRowHeight = 40;
        }

        private void f491_rpt_bao_cao_tong_hop_thu_nhap_theo_nam_detail_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
         //   this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void m_cmd_luu_bang_luong_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "xls files (*.xls)|*.xls|All files (*.*)|*.*";
                saveFileDialog1.RestoreDirectory = true;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    m_grc_tong_hop.ExportToXls(saveFileDialog1.FileName);
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
