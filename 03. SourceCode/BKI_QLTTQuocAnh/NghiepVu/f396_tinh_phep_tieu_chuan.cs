using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BKI_DichVuMatDat;
using BKI_DichVuMatDat.DS;
using BKI_DichVuMatDat.US;
using IP.Core.IPCommon;
using BKI_DichVuMatDat.DS.CDBNames;


namespace BKI_DichVuMatDat.NghiepVu
{
    public partial class f396_tinh_phep_tieu_chuan : Form
    {
        #region Public Interface
        public f396_tinh_phep_tieu_chuan()
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
            m_dat_nam.EditValue = DateTime.Now;
            set_define_events();
        }

        public void load_data_to_grid()
        {
            DataSet v_ds = new DataSet();
            US_GD_CHAM_CONG v_us = new US_GD_CHAM_CONG();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetNgayPhepTieuChuan(v_ds, m_dat_nam.DateTime.Date, -1);
            m_grc_phep_tieu_chuan.DataSource = v_ds.Tables[0];
        }
        #endregion

        #region Event Handle
        private void set_define_events()
        {
            m_cmd_search.Click += m_cmd_search_Click;
            this.Load += f394_tinh_phep_tieu_chuan_Load;
        }

        void f394_tinh_phep_tieu_chuan_Load(object sender, EventArgs e)
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
        #endregion

        private void m_cmd_xuat_excel_Click(object sender, EventArgs e)
        {
            try
            {
                CHRMCommon.ExportExcel(gridView1);
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        

        //private void m_cmd_tinh_ngay_phep_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        string v_nam_tinh_phep = m_dat_nam.DateTime.Year.ToString();
        //        if (v_nam_tinh_phep != "" && check_validate_data_is_ok(v_nam_tinh_phep))
        //        {
        //            load_data_to_grid();
        //        }
        //        else
        //        {
        //            MessageBox.Show("Dữ liệu nhập vào chưa hợp lệ!");
        //        }
        //    }
        //    catch (Exception v_e)
        //    {
        //        CSystemLog_301.ExceptionHandle(v_e);
        //    }
        //}

        //private bool check_validate_data_is_ok(string ip_str_nam_tinh_phep)
        //{
        //    for (int i = 0; i < ip_str_nam_tinh_phep.Length; i++)
        //    {
        //        if (char.IsDigit(ip_str_nam_tinh_phep[i]) == false)
        //            return false;
        //    }
        //    return true;
        //}          
    }
}
