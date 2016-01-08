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
using BKI_DichVuMatDat.DS;

namespace BKI_DichVuMatDat.BaoCao
{
    public partial class F401_he_so_bao_cao_luong : Form
    {
        public F401_he_so_bao_cao_luong()
        {
            InitializeComponent();
            format_controls();
        }
        #region Members
        US_BAO_CAO_THAM_SO_BANG_LUONG m_us_tham_so_bang_luong;
        #endregion

        #region Private Methods
        private void format_controls()
        {
            FormatControl.SetVisibleSimpleButton(this);
            set_define_events();
            this.KeyPreview = true;
        }
        private void load_data_2_grid(decimal ip_dc_thang, decimal ip_dc_nam)
        {
            m_us_tham_so_bang_luong = new US_BAO_CAO_THAM_SO_BANG_LUONG();
            DS_BAO_CAO_THAM_SO_BANG_LUONG v_ds = new DS_BAO_CAO_THAM_SO_BANG_LUONG();
            m_us_tham_so_bang_luong.GetThamSoBangLuongThang(v_ds, ip_dc_thang, ip_dc_nam);
            m_gd_tham_so_bang_luong_thang.DataSource = v_ds.Tables[0];
            CHRMCommon.make_stt(m_band_tham_so_bang_luong_thang);
        }
        private void set_initial_form_load()
        {
            m_txt_thang.Text = DateTime.Now.Month.ToString();
            m_txt_nam.Text = DateTime.Now.Year.ToString();
        }
        private void set_define_events()
        {
            this.Load += F401_he_so_bao_cao_luong_Load;
            m_cmd_loc.Click += m_cmd_loc_Click;
        }

        #endregion

        #region Events
        void F401_he_so_bao_cao_luong_Load(object sender, EventArgs e)
        {
            try
            {
                set_initial_form_load();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_loc_Click(object sender, EventArgs e)
        {
            try
            {
                decimal v_dc_thang = CIPConvert.ToDecimal(m_txt_thang.Text.Trim());
                decimal v_dc_nam = CIPConvert.ToDecimal(m_txt_nam.Text.Trim());
                if (v_dc_thang <= 12 && v_dc_thang >= 0 && v_dc_nam >= 0)
                    load_data_2_grid(v_dc_thang, v_dc_nam);
                else
                    CHRM_BaseMessages.MsgBox_Warning("Kiểm tra lại tháng và năm");
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        #endregion Events

        private void m_gd_tham_so_bang_luong_thang_Click(object sender, EventArgs e)
        {

        }
    }
}
