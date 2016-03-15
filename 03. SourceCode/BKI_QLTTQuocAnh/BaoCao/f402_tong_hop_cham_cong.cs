using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BKI_DichVuMatDat.US;
using BKI_DichVuMatDat.DS;
using BKI_DichVuMatDat.DS.CDBNames;
using IP.Core.IPCommon;
using System.IO;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraPivotGrid;


namespace BKI_DichVuMatDat.BaoCao
{
    public partial class f402_tong_hop_cham_cong : Form
    {
        decimal m_id_nhan_vien;
        public f402_tong_hop_cham_cong()
        {
            InitializeComponent();
        }
         private void m_cmd_loc_Click(object sender, EventArgs e)
        {
            if (check_validate_data_is_ok(m_txt_thang.Text) && check_validate_data_is_ok(m_txt_nam.Text))
            {           
                if (m_sle_chon_nhan_vien.EditValue.ToString() == "" || m_sle_chon_nhan_vien.EditValue == null)
                {
                    m_id_nhan_vien = -1;                   
                }
                else
                {
                    m_id_nhan_vien = CIPConvert.ToDecimal(m_sle_chon_nhan_vien.EditValue.ToString());
                }
                load_data_to_m_pv(m_id_nhan_vien);        
            }
            else
            {
                CHRM_BaseMessages.MsgBox_Infor(CONST_ID_MSGBOX.ERROR_DU_LIEU_NHAP_CHUA_HOP_LE);
            }    
        }


        private bool check_validate_data_is_ok(string ip_str_thang_cham_cong)
        {
            for (int i = 0; i < ip_str_thang_cham_cong.Length; i++)
            {
                if (char.IsDigit(ip_str_thang_cham_cong[i]) == false)
                    return false;
            }
            return true;
        }

        private void load_data_to_m_pv(decimal m_id_nhan_vien)
        {
            US_GD_CHAM_CONG v_us = new US_GD_CHAM_CONG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetChamCongTongHop(v_ds, m_txt_thang.Text, m_txt_nam.Text, m_id_nhan_vien);
            m_pv.DataSource = v_ds.Tables[0];
        }

        private DataTable load_data_to_ds_v_dm_nv()
        {
            US_V_DM_NHAN_VIEN v_us = new US_V_DM_NHAN_VIEN();
            DS_V_DM_NHAN_VIEN v_ds = new DS_V_DM_NHAN_VIEN();
            v_us.FillDataset(v_ds);
            return v_ds.Tables[0];
        }

        private void load_data_to_sle_chon_nhan_vien()
        {
            m_sle_chon_nhan_vien.Properties.DataSource = load_data_to_ds_v_dm_nv();
            m_sle_chon_nhan_vien.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            m_sle_chon_nhan_vien.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
        }


        private void f394_cham_cong_thang_Load(object sender, EventArgs e)
        {
            load_data_to_sle_chon_nhan_vien();
        }

        private void m_cmd_xuat_bao_cao_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "xls files (*.xls)|*.xls|All files (*.*)|*.*";
                saveFileDialog1.RestoreDirectory = true;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK )
                {
                    m_pv.ExportToXlsx(saveFileDialog1.FileName);
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        

        //private DataTable get_gd_cham_cong(string ip_str_ngay_cham_cong)
        //{
        //    US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
        //    DataSet v_ds = new DataSet();
        //    v_ds.Tables.Add(new DataTable());
        //    v_us.FillDatasetWithQuery(v_ds, "select * from V_GD_CHAM_CONG where NGAY_CHAM_CONG = '" + ip_str_ngay_cham_cong + "' ORDER BY MA_NV");
        //    return v_ds.Tables[0];
        //}
    }
}
