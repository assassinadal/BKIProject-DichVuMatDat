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
using DevExpress.XtraEditors;

namespace BKI_DichVuMatDat.NghiepVu.NhanSu
{
    public partial class f327_lap_hop_dong_v3 : Form
    {
        #region Public Interface
        public f327_lap_hop_dong_v3()
        {
            InitializeComponent();
            set_initial_form_load();
        }
        #endregion

        #region Members
        #endregion

        #region Private Method
        private void set_initial_form_load()
        {
            m_dat_den_ngay.EditValue = DateTime.Now;
            m_dat_tu_ngay.EditValue = DateTime.Now.AddMonths(-1).AddDays(1);
            set_define_events();
        }

        private void load_data_to_grid()
        {
            US_GD_HOP_DONG v_us = new US_GD_HOP_DONG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetHDTheoNgayKy(v_ds, m_dat_tu_ngay.DateTime, m_dat_den_ngay.DateTime);
            m_grc.DataSource = v_ds.Tables[0];
        }
        #endregion

        #region Event Handler
        private void set_define_events()
        {
            this.Load += f327_lap_hop_dong_v3_Load;
            m_cmd_search.Click += m_cmd_search_Click;
            m_cmd_insert.Click += m_cmd_insert_Click;
            m_cmd_update.Click += m_cmd_update_Click;
        }

        void m_cmd_update_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        void m_cmd_insert_Click(object sender, EventArgs e)
        {
            try
            {
                f328_lap_hop_dong_v3_detail v_f = new f328_lap_hop_dong_v3_detail();
                v_f.display_for_insert();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }           
        }

        void m_cmd_search_Click(object sender, EventArgs e)
        {
            try
            {
                load_data_to_grid();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void f327_lap_hop_dong_v3_Load(object sender, EventArgs e)
        {
            try
            {
                load_data_to_grid();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        #endregion
    }
}
