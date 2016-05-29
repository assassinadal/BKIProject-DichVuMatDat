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
namespace BKI_DichVuMatDat.NghiepVu
{
    public partial class f315_card_nhan_vien : Form
    {
        public f315_card_nhan_vien()
        {
            InitializeComponent();
            load_danh_sach_don_vi();

        }
        private decimal get_id_don_vi()
        {
            if(m_sle_chon_don_vi.EditValue == null)
            {
                return 0;
            }
            return Convert.ToDecimal(m_sle_chon_don_vi.EditValue);
        }
        private decimal get_id_chuc_vu()
        {
            if(m_sle_chon_vi_tri.EditValue == null)
            {
                return 0;
            }
            return Convert.ToDecimal(m_sle_chon_vi_tri.EditValue);
        }
        private void load_data_to_grid()
        {
            US_DM_NHAN_VIEN v_us = new US_DM_NHAN_VIEN();
            m_grc_main.DataSource = v_us.LayDanhSachMaTraCuu(get_id_don_vi(), get_id_chuc_vu());
        }
        private void f315_card_nhan_vien_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'dVMDDataSet1.V_DM_NHAN_VIEN' table. You can move, or remove it, as needed.
            //DS_V_GD_MA_TRA_CUU_NHAN_VIEN v_ds = new DS_V_GD_MA_TRA_CUU_NHAN_VIEN();
            //US_V_GD_MA_TRA_CUU_NHAN_VIEN v_us = new US_V_GD_MA_TRA_CUU_NHAN_VIEN();
            //v_us.FillDataset(v_ds, "Order by MA_PHONG, MA_DOI, MA_CHUC_VU, SO_HO_SO");
            load_data_to_grid();
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

        private void m_cmd_filter_Click(object sender, EventArgs e)
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


        private void load_data_2_sle_chon_vi_tri()
        {
            m_sle_chon_vi_tri.EditValue = null;
            US_DM_CHUC_VU v_us = new US_DM_CHUC_VU();
            DS_DM_CHUC_VU v_ds = new DS_DM_CHUC_VU();
            v_us.FillDataset(v_ds, " where id_don_vi = " + Convert.ToDecimal(m_sle_chon_don_vi.EditValue));
            m_sle_chon_vi_tri.Properties.DataSource = v_ds.Tables[0];
        }
        private void load_danh_sach_don_vi()
        {
            US_DM_DON_VI v_us = new US_DM_DON_VI();
            DS_DM_DON_VI v_ds = new DS_DM_DON_VI();
            v_us.FillDataset(v_ds);
            m_sle_chon_don_vi.Properties.DataSource = v_ds.Tables[0];
        }
       
        private void m_sle_chon_don_vi_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if(m_sle_chon_don_vi.EditValue == null)
                {
                    return;
                }
                load_data_2_sle_chon_vi_tri();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
    }
}
