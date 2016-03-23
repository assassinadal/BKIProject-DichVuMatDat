using BKI_DichVuMatDat.US;
using DevExpress.XtraEditors;
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

namespace BKI_DichVuMatDat.BaoCao.Luong
{
    public partial class f495_thong_tin_chot_bang_luong_thang : Form
    {
        public f495_thong_tin_chot_bang_luong_thang()
        {
            InitializeComponent();
            m_dat_nam.EditValue = DateTime.Now;
        }
        private decimal lay_nam()
        {
            return Convert.ToDecimal(m_dat_nam.DateTime.Year);
        }
        private void load_data_2_grid()
        {
            US_RPT_CHOT_BANG_LUONG v_us_rpt = new US_RPT_CHOT_BANG_LUONG();
            var v_dt_source = v_us_rpt.LayDuLieuChotBangLuong(lay_nam());
            m_grc_main.DataSource = v_dt_source;
            m_grc_main.RefreshDataSource();
        }
        private void m_cmd_view_Click(object sender, EventArgs e)
        {
            try
            {
                load_data_2_grid();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_unlock_Click(object sender, EventArgs e)
        {
            try
            {
                if(m_grv_main.FocusedRowHandle < 0)
                {
                    XtraMessageBox.Show("Bạn chọn dòng dữ liệu trước!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DataRow v_dr = m_grv_main.GetFocusedDataRow();
                var v_dlg = XtraMessageBox.Show("Bạn có chắc chắn muốn bỏ chốt bảng lương?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                if(v_dlg == System.Windows.Forms.DialogResult.No)
                {
                    return;
                }
                US_RPT_CHOT_BANG_LUONG v_us_chot = new US_RPT_CHOT_BANG_LUONG();
                v_us_chot.DeleteByID(Convert.ToDecimal(v_dr["ID"]));
                XtraMessageBox.Show("Bỏ chốt thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load_data_2_grid();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void f495_thong_tin_chot_bang_luong_thang_Load(object sender, EventArgs e)
        {
            try
            {
                load_data_2_grid();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
    }
}
