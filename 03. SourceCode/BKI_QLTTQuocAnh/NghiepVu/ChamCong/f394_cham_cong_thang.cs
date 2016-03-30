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
        public f394_cham_cong_thang()
        {
            InitializeComponent();
            set_initial_form_load();
        }

        decimal m_txt_thang;
        decimal m_txt_nam;

        private void load_data_to_m_pv()
        {
            decimal v_id_nhan_vien;
            if (m_sle_chon_nhan_vien.EditValue == null)
                v_id_nhan_vien = -1;
            else
                v_id_nhan_vien = CIPConvert.ToDecimal(m_sle_chon_nhan_vien.EditValue.ToString());
            US_GD_CHAM_CONG v_us = new US_GD_CHAM_CONG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetChamCong(v_ds, m_txt_thang.ToString(), m_txt_nam.ToString(), v_id_nhan_vien);
            m_pv.DataSource = v_ds.Tables[0];
        }

        private DataSet load_data_to_ds_v_dm_nv()
        {
            US_V_DM_NHAN_VIEN v_us = new US_V_DM_NHAN_VIEN();
            DS_V_DM_NHAN_VIEN v_ds = new DS_V_DM_NHAN_VIEN();
            v_us.FillDataset(v_ds);
            return v_ds;
        }

        private void load_data_to_sle_chon_nhan_vien()
        {
            m_sle_chon_nhan_vien.Properties.DataSource = load_data_to_ds_v_dm_nv().Tables[0];
            m_sle_chon_nhan_vien.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            m_sle_chon_nhan_vien.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
        }

        private void set_initial_form_load()
        {
            //m_txt_thang.Text = DateTime.Now.Month.ToString();
            //m_txt_nam.Text = DateTime.Now.Year.ToString();
            m_dat_thang.EditValue = DateTime.Now;
            m_txt_nam = m_dat_thang.DateTime.Year;
            m_txt_thang = m_dat_thang.DateTime.Month;
            set_define_events();
        }

        private bool check_bang_luong_da_chot(string ip_thang, string ip_nam)
        {
            US_RPT_CHOT_BANG_LUONG v_us = new US_RPT_CHOT_BANG_LUONG();
            if (v_us.IsLockBangLuong(decimal.Parse(ip_thang), decimal.Parse(ip_nam)))
                return true;
            else return false;
        }

        private void set_define_events()
        {
            m_cmd_search.Click += m_cmd_search_Click;
            this.Load +=f394_cham_cong_thang_Load;
            m_pv.CellDoubleClick +=m_pv_CellDoubleClick;
            m_cmd_tong_hop_cham_cong.Click += m_cmd_tong_hop_cham_cong_Click;
            m_dat_thang.DateTimeChanged += M_dat_thang_DateTimeChanged;
        }

        private void M_dat_thang_DateTimeChanged(object sender, EventArgs e)
        {
            try
            {
                m_txt_nam = m_dat_thang.DateTime.Year;
                m_txt_thang = m_dat_thang.DateTime.Month;
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_tong_hop_cham_cong_Click(object sender, EventArgs e)
        {
            try
            {
                decimal v_id_nv;
                if (m_sle_chon_nhan_vien.EditValue == null)
                    v_id_nv = -1;
                else v_id_nv = decimal.Parse(m_sle_chon_nhan_vien.EditValue.ToString());
                BaoCao.f402_tong_hop_cham_cong v_f = new BaoCao.f402_tong_hop_cham_cong(m_txt_thang.ToString(), m_txt_nam.ToString(), v_id_nv);
                v_f.Show();
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
                load_data_to_m_pv();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_pv_CellDoubleClick(object sender, DevExpress.XtraPivotGrid.PivotCellEventArgs e)
        {
            try
            {
                if (check_bang_luong_da_chot(m_txt_thang.ToString(), m_txt_nam.ToString()))
                {
                    XtraMessageBox.Show("Tháng đã chốt bảng lương. Vui lòng không cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                f394_cham_cong_thang_detail v_f = new f394_cham_cong_thang_detail();
                PivotDrillDownDataSource v_ds = e.CreateDrillDownDataSource();
                PivotDrillDownDataRow v_dr = v_ds[0];
                var v_id_loai_ngay_cong = CIPConvert.ToDecimal(v_dr["ID_LOAI_NGAY_CONG"].ToString());
                //var v_id_nhan_vien = CIPConvert.ToDecimal(v_dr["ID_NHAN_VIEN"].ToString());
                v_f.display_for_update(ref v_id_loai_ngay_cong);
                US_GD_CHAM_CONG v_us = new US_GD_CHAM_CONG(CIPConvert.ToDecimal(v_dr["ID"].ToString()));
                if (v_us.dcID_LOAI_NGAY_CONG != v_id_loai_ngay_cong)
                {
                    v_us.dcID_LOAI_NGAY_CONG = v_id_loai_ngay_cong;
                    v_us.Update();
                    XtraMessageBox.Show("Sửa dữ liệu chấm công thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load_data_to_m_pv();
                }               
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
            
        }

        private void f394_cham_cong_thang_Load(object sender, EventArgs e)
        {
            try
            {
                load_data_to_m_pv();
                load_data_to_sle_chon_nhan_vien();
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
