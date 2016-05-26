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
    public partial class F394_gd_nhan_vien_phu_cap : Form
    {
        public F394_gd_nhan_vien_phu_cap()
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
            m_cmd_update.Click += m_cmd_update_Click;
        }

        private void m_cmd_update_Click(object sender, EventArgs e)
        {
            try
            {
                F395_nhan_vien_phu_cap_de v_f = new F395_nhan_vien_phu_cap_de();
                int v_index_dr = m_grv.FocusedRowHandle;
                if (v_index_dr >= 0 )
                {
                    var v_dr = m_grv.GetDataRow(v_index_dr);
                    US_GD_NHAN_VIEN_PHU_CAP v_us = new US_GD_NHAN_VIEN_PHU_CAP(CIPConvert.ToDecimal(v_dr["ID"]));
                    v_f.display_for_update(v_us);
                    load_data_2_grid();
                }
                else
                {
                    string v_str_error = "Bạn chưa chọn dòng dữ liệu để sửa!";
                    XtraMessageBox.Show(v_str_error, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        

        private void load_data_2_grid()
        {
            CHRMCommon.make_stt(m_grv);
            //DS_V_GD_NHAN_VIEN_PHU_CAP_V2 v_ds = new DS_V_GD_NHAN_VIEN_PHU_CAP_V2();
            //US_V_GD_NHAN_VIEN_PHU_CAP_V2 v_us = new US_V_GD_NHAN_VIEN_PHU_CAP_V2();
            US_GD_NHAN_VIEN_PHU_CAP v_us = new US_GD_NHAN_VIEN_PHU_CAP();

            m_grc.DataSource = v_us.LayDanhSach();
        }

     
        private void m_cmd_them_Click(object sender, EventArgs e)
        {
            try
            {
                F395_nhan_vien_phu_cap_de v_f = new F395_nhan_vien_phu_cap_de();
                v_f.display_for_insert();              
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
                F395_nhan_vien_phu_cap_de v_f = new F395_nhan_vien_phu_cap_de();
                int v_index_dr = m_grv.FocusedRowHandle;
                if (v_index_dr >= 0)
                {
                    string v_str_confirm = "Bạn có chắc chắn muốn xóa phụ cấp này";
                    DialogResult v_dialog = XtraMessageBox.Show(v_str_confirm, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (v_dialog == DialogResult.Yes)
                    {
                        US_GD_NHAN_VIEN_PHU_CAP v_us = new US_GD_NHAN_VIEN_PHU_CAP(CIPConvert.ToDecimal(m_grv.GetDataRow(v_index_dr)["ID"]));
                        //v_us.datNGAY_SUA = DateTime.Now;
                        //v_us.strNGUOI_SUA = IP.Core.IPSystemAdmin.CAppContext_201.getCurrentUserName();
                        //v_us.strDA_XOA = "Y";
                        v_us.Delete();
                        XtraMessageBox.Show("Đã xóa thành công phụ cấp!");
                        load_data_2_grid();
                    }                   
                }
                else
                {
                    string v_str_error = "Bạn chưa chọn dòng dữ liệu để xóa!";
                    XtraMessageBox.Show(v_str_error, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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
