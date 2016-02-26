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

namespace BKI_DichVuMatDat.BaoCao
{
    public partial class frm417_bao_cao_tang_giam_lao_dong : Form
    {
        public frm417_bao_cao_tang_giam_lao_dong()
        {
            InitializeComponent();
        }

        private void load_data_to_grid()
        {
            US_GD_CONG_TAC v_us_dung_chung = new US_GD_CONG_TAC();
            DataSet v_op_ds = new DataSet();
            v_op_ds.Tables.Add();

            v_us_dung_chung.FillDatasetBaoCaoTangGiamLaoDong(v_op_ds, m_dat_tu_ngay.DateTime, m_dat_den_ngay.DateTime);
            m_trl_bao_cao.KeyFieldName = "ID";
            m_trl_bao_cao.ParentFieldName = "ID_DON_VI_CAP_TREN";
            m_trl_bao_cao.DataSource = v_op_ds.Tables[0];
            m_trl_bao_cao.ExpandAll();
        }

        private void xuat_excel()
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "xls files (*.xls)|*.xls|All files (*.*)|*.*";
            saveFileDialog1.RestoreDirectory = true;

            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                m_trl_bao_cao.ExportToXls(saveFileDialog1.FileName);
                DevExpress.XtraEditors.XtraMessageBox.Show("Lưu báo cáo thành công");
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

        private void frm417_bao_cao_tang_giam_lao_dong_Load(object sender, EventArgs e)
        {
            try
            {
                m_dat_tu_ngay.DateTime = DateTime.Now.AddMonths(-1).AddDays(-DateTime.Now.Day + 1);
                m_dat_den_ngay.DateTime = DateTime.Now.AddDays(-DateTime.Now.Day);
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_xuat_excel_Click(object sender, EventArgs e)
        {
            try
            {
                xuat_excel();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
    }
}
