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

namespace BKI_DichVuMatDat.NghiepVu
{
    public partial class f394_cham_cong_thang : Form
    {
        decimal m_id_nhan_vien;
        public f394_cham_cong_thang()
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
                MessageBox.Show("Dữ liệu nhập chưa hợp lệ!");
            }    
        }

        private void load_data_to_m_pv(decimal m_id_nhan_vien)
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetChamCong(v_ds, m_txt_thang.Text, m_txt_nam.Text, m_id_nhan_vien);
            m_pv.DataSource = v_ds.Tables[0];
        }

        private DataSet load_data_to_ds_v_dm_nv()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithTableName(v_ds, "V_DM_NHAN_VIEN");
            return v_ds;
        }

        private void load_data_to_sle_chon_nhan_vien()
        {
            m_sle_chon_nhan_vien.Properties.DataSource = load_data_to_ds_v_dm_nv().Tables[0];
            m_sle_chon_nhan_vien.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            m_sle_chon_nhan_vien.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
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

        private void m_pv_CellDoubleClick(object sender, DevExpress.XtraPivotGrid.PivotCellEventArgs e)
        {
            try
            {
                f394_cham_cong_thang_detail v_f = new f394_cham_cong_thang_detail();
                PivotDrillDownDataSource v_ds = e.CreateDrillDownDataSource();
                PivotDrillDownDataRow v_dr = v_ds[0];
                var v_id_loai_ngay_cong = CIPConvert.ToDecimal(v_dr["ID_LOAI_NGAY_CONG"].ToString());
                v_f.display_for_update(ref v_id_loai_ngay_cong);
                US_GD_CHAM_CONG v_us = new US_GD_CHAM_CONG(CIPConvert.ToDecimal(v_dr["ID"].ToString()));
                v_us.dcID_LOAI_NGAY_CONG = v_id_loai_ngay_cong;
                v_us.Update();
                XtraMessageBox.Show("Sửa dữ liệu chấm công thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load_data_to_m_pv(Convert.ToDecimal(m_sle_chon_nhan_vien.EditValue));
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
            
        }

        private void f394_cham_cong_thang_Load(object sender, EventArgs e)
        {
            load_data_to_sle_chon_nhan_vien();
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
