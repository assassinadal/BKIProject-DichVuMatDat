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

namespace BKI_DichVuMatDat.NghiepVu
{
    public partial class f315_card_nhan_vien : Form
    {
        public f315_card_nhan_vien()
        {
            InitializeComponent();
        }

        private void f315_card_nhan_vien_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'dVMDDataSet1.V_DM_NHAN_VIEN' table. You can move, or remove it, as needed.
            DS_V_GD_MA_TRA_CUU_NHAN_VIEN v_ds = new DS_V_GD_MA_TRA_CUU_NHAN_VIEN();
            US_V_GD_MA_TRA_CUU_NHAN_VIEN v_us = new US_V_GD_MA_TRA_CUU_NHAN_VIEN();
            v_us.FillDataset(v_ds, "Order by MA_PHONG, MA_DOI, MA_CHUC_VU, SO_HO_SO");
            m_grc_main.DataSource = v_ds.Tables[0];
        }

        private void m_cmd_xuat_pdf_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "pdf files (*.pdf)|*.pdf|All files (*.*)|*.*";
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                layoutView1.ShowPrintPreview();
                //layoutView1.ExportToPdf(saveFileDialog1.FileName);
                //DevExpress.XtraEditors.XtraMessageBox.Show("Lưu báo cáo thành công");
            }
        }
    }
}
