using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using BKI_DichVuMatDat.DS;
using BKI_DichVuMatDat.DS.CDBNames;
using BKI_DichVuMatDat.US;
using IP.Core.IPCommon;
using IP.Core.IPSystemAdmin;
//using BKI_HRM.US;
//using IP.Core.IPUserService;

namespace BKI_DichVuMatDat.HeThong
{
    public partial class f994_phan_quyen_detail : Form
    {
        public void display() {
            this.ShowDialog();
        }
        public void load_data_2_txt_form(US_HT_FORM ip_us){
            m_txt_form.Text = ip_us.strFORM_NAME;
        }

        public f994_phan_quyen_detail()
        {
            InitializeComponent();
            format_control();
        }

        private void format_control()
        {
            //CControlFormat.setFormStyle(this, new CAppContext_201());
        }

        private void m_cmd_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void m_cmd_save_Click(object sender, EventArgs e)
        {
            US_V_HT_CONTROL_IN_FORM v_us = new US_V_HT_CONTROL_IN_FORM();
            DS_V_HT_CONTROL_IN_FORM v_ds = new DS_V_HT_CONTROL_IN_FORM();
            v_us.FillDatasetByIdChucNangAndFormName(v_ds,CIPConvert.ToDecimal(m_cbo_chuc_nang.SelectedValue),m_txt_form.Text);

            US_HT_PHAN_QUYEN_DETAIL v_us_ht_pq_detail;
            for (int i = 0; i < v_ds.Tables[0].Rows.Count; i++)
            {
                v_us_ht_pq_detail = new US_HT_PHAN_QUYEN_DETAIL();
                DataRow v_dr = v_ds.Tables[0].Rows[i];
                v_us_ht_pq_detail.dcID_PHAN_QUYEN_HT = CIPConvert.ToDecimal(m_cbo_nhom_quyen.SelectedValue);
                v_us_ht_pq_detail.strCONTROL_NAME = v_dr[V_HT_CONTROL_IN_FORM.CONTROL_NAME].ToString();
                v_us_ht_pq_detail.strCONTROL_TYPE = v_dr[V_HT_CONTROL_IN_FORM.CONTROL_TYPE].ToString();
                v_us_ht_pq_detail.strENABLED_YN = "Y";
                v_us_ht_pq_detail.strFORM_NAME = v_dr[V_HT_CONTROL_IN_FORM.FORM_NAME].ToString();
                v_us_ht_pq_detail.strVISIBLE_YN = "Y";
                v_us_ht_pq_detail.Insert();
            }
            CHRM_BaseMessages.MsgBox_Infor(CONST_ID_MSGBOX.INFOR_DU_LIEU_DA_DUOC_CAP_NHAT);
         //   this.Close();
        }

        private void f994_phan_quyen_detail_Load(object sender, EventArgs e)
        {
            load_data_2_cbo_nhom_quyen();
            load_data_2_cbo_chuc_nang();
        }

        private void load_data_2_cbo_chuc_nang()
        {
            US_CM_DM_TU_DIEN v_us = new US_CM_DM_TU_DIEN();
            DS_CM_DM_TU_DIEN v_ds = new DS_CM_DM_TU_DIEN();
            v_us.FillDatasetByIdLoaiTuDien(v_ds, 14);
            m_cbo_chuc_nang.DataSource = v_ds.Tables[0];
            m_cbo_chuc_nang.ValueMember = CM_DM_TU_DIEN.ID;
            m_cbo_chuc_nang.DisplayMember = CM_DM_TU_DIEN.TEN_NGAN;
        }

        private void load_data_2_cbo_nhom_quyen()
        {
            US_HT_PHAN_QUYEN_HE_THONG v_us = new US_HT_PHAN_QUYEN_HE_THONG();
            DS_HT_PHAN_QUYEN_HE_THONG v_ds = new DS_HT_PHAN_QUYEN_HE_THONG();
            v_us.FillDataset(v_ds);
            m_cbo_nhom_quyen.DataSource = v_ds.Tables[0];
            m_cbo_nhom_quyen.ValueMember = HT_PHAN_QUYEN_HE_THONG.ID;
            m_cbo_nhom_quyen.DisplayMember = HT_PHAN_QUYEN_HE_THONG.MA_PHAN_QUYEN;
        }

        private void m_cmd_chon_form_Click(object sender, EventArgs e)
        {
            f990_ht_form v_frm = new f990_ht_form();
            v_frm.show_2_choose(this);
        }

        
    }
}
