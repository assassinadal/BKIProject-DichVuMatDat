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
using BKI_DichVuMatDat.US;
using BKI_DichVuMatDat.DS;
using BKI_DichVuMatDat.DS.CDBNames;
using DevExpress.XtraEditors;

namespace BKI_DichVuMatDat.NghiepVu
{
    public partial class F393_gd_nhan_vien_phu_cap : Form
    {
        public F393_gd_nhan_vien_phu_cap()
        {
            InitializeComponent();
        }

        private void F393_gd_nhan_vien_phu_cap_Load(object sender, EventArgs e)
        {
            try
            {
                load_data_2_grid();
                set_define_events();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
           
        }

        private void set_define_events()
        {
            m_cmd_them.Click += m_cmd_them_Click;
            m_cmd_xoa.Click += m_cmd_xoa_Click;
        }

        private void load_data_2_grid()
        {
            US_V_GD_NHAN_VIEN_PHU_CAP v_us = new US_V_GD_NHAN_VIEN_PHU_CAP();
            DS_V_GD_NHAN_VIEN_PHU_CAP v_ds = new DS_V_GD_NHAN_VIEN_PHU_CAP();

            v_us.FillDataset(v_ds, " WHERE DA_XOA = 'N'");
            //v_us.FillDatasetWithTableName(v_ds, "V_GD_NHAN_VIEN_PHU_CAP where DA_XOA = 'N'");
            m_grc.DataSource = v_ds.Tables[0];
        }

     
        private void m_cmd_them_Click(object sender, EventArgs e)
        {
            try
            {
                F393_nhan_vien_phu_cap_de v_f = new F393_nhan_vien_phu_cap_de();
                v_f.ShowDialog();               
                load_data_2_grid();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (BaseMessages.MsgBox_Confirm("Bạn có chắc chắn muốn xóa phụ cấp trách nhiệm này?") == false) return;
                US_GD_NHAN_VIEN_PHU_CAP v_us = new US_GD_NHAN_VIEN_PHU_CAP(CIPConvert.ToDecimal(m_grv.GetDataRow(m_grv.FocusedRowHandle)["ID"].ToString()));
                v_us.datNGAY_SUA = CHRMCommon.get_first_day_of_month(DateTime.Now.Date);
                v_us.strDA_XOA = "Y";
                v_us.Update();
                XtraMessageBox.Show("Đã xóa thành công phụ cấp!");
                load_data_2_grid();
            }
            catch (Exception v_e)
            {
                IP.Core.IPCommon.CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_xuat_excel_Click(object sender, EventArgs e)
        {
            try
            {
                CHRMCommon.ExportExcel(m_grv);
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
    }
}
