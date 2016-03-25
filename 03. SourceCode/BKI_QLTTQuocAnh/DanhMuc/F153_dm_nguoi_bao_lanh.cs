using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IP.Core.IPCommon;
using BKI_DichVuMatDat.DS;
using BKI_DichVuMatDat.US;
using IP.Core.IPUserService;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using BKI_DichVuMatDat.BaoCao;

namespace BKI_DichVuMatDat.DanhMuc
{
    public partial class F153_dm_nguoi_bao_lanh : Form
    {
        public F153_dm_nguoi_bao_lanh()
        {
            InitializeComponent();
            format_controls();
        }

        private void set_init_form_load()
        {
            load_data_to_grid();
        }

        private void format_controls()
        {
            FormatControl.SetVisibleSimpleButton(this);
            set_define_events();
            this.KeyPreview = true;
            CenterToScreen();
        }



        private void load_data_to_grid()
        {
            US_V_DM_NHAN_VIEN_4 v_us = new US_V_DM_NHAN_VIEN_4();
            DS_V_DM_NHAN_VIEN_4 v_ds = new DS_V_DM_NHAN_VIEN_4();
            v_ds.Clear();
            v_us.FillDataset(v_ds);
            m_grc.DataSource = v_ds.Tables[0];
        }

        private void set_define_events()
        {
            this.Load += F153_dm_nguoi_bao_lanh_Load;
        }

        private void F153_dm_nguoi_bao_lanh_Load(object sender, EventArgs e)
        {
            try
            {
                set_init_form_load();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }


    }
}
