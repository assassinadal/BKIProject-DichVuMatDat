using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BKI_DichVuMatDat;
using BKI_DichVuMatDat.US;
using BKI_DichVuMatDat.DS;
using BKI_DichVuMatDat.DS.CDBNames;
using IP.Core.IPCommon;
using DevExpress.XtraEditors;

namespace BKI_DichVuMatDat.NghiepVu
{
    public partial class f394_cham_cong_thang_detail : Form
    {
        public f394_cham_cong_thang_detail()
        {
            InitializeComponent();
        }

        public void display_for_update(ref decimal ip_id_loai_ngay_cong)
        {
            get_loai_ngay_cong();
            m_sle_loai_ngay_cong.EditValue = ip_id_loai_ngay_cong;
            this.ShowDialog();
            if (DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                ip_id_loai_ngay_cong = CIPConvert.ToDecimal(m_sle_loai_ngay_cong.EditValue.ToString());
            }
        }

        private void get_loai_ngay_cong()
        {
            US_DM_LOAI_NGAY_CONG v_us = new US_DM_LOAI_NGAY_CONG();
            DS_DM_LOAI_NGAY_CONG v_ds = new DS_DM_LOAI_NGAY_CONG();
            v_us.FillDataset(v_ds);
            m_sle_loai_ngay_cong.Properties.DataSource = v_ds.Tables[0];
            m_sle_loai_ngay_cong.Properties.DisplayMember = "MA_NGAY_CONG";
            m_sle_loai_ngay_cong.Properties.ValueMember = "ID";
        }

        private void m_cmd_save_Click(object sender, EventArgs e)
        {
            try
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_exit_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
