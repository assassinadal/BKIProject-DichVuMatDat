using IP.Core.IPCommon;
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


namespace BKI_DichVuMatDat.BaoCao
{
    public partial class f410_rpt_bang_luong_nv : Form
    {
        public f410_rpt_bang_luong_nv()
        {
            InitializeComponent();
            format_controls();
        }

        #region Public Interface
        public void display()
        {
            this.ShowDialog();
        }
        #endregion

        #region Data Structure
       
        #endregion

        #region Members
        
        #endregion

        #region Private Methods
        private void format_controls()
        {

            set_define_events();
            this.KeyPreview = true;
        }

        private void set_initial_form_load()
        {
            load_data_2_work_sheet();
        }

        private void load_data_2_work_sheet()
        {
            DataSet v_ds = new DataSet();

            
        }

        //private void load_data_2_clb_loai_phieu()
        //{
        //    DS_DM_LOAI_HOP_DONG v_ds = new DS_DM_LOAI_HOP_DONG();
        //    US_DM_LOAI_HOP_DONG v_us = new US_DM_LOAI_HOP_DONG();

        //    v_us.FillDataset(v_ds);

        //    DataRow v_dr = null;
        //    int iRowCnt = 0;

        //    m_clb_loai_hop_dong.Items.Clear();

        //    foreach (DataRow v_dr_1 in v_ds.Tables[0].Rows)
        //    {
        //        v_dr = v_dr_1;
        //        m_clb_loai_hop_dong.Items.Add(v_ds.Tables[0].Rows[iRowCnt][1]);
        //        iRowCnt = iRowCnt + 1;
        //    }
        //}

        #endregion

        private void set_define_events()
        {
            this.Load += f410_rpt_bang_luong_nv_Load;
        }

        void f410_rpt_bang_luong_nv_Load(object sender, EventArgs e)
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

        private void m_cmd_search_Click(object sender, EventArgs e)
        {

        }
    }
}
