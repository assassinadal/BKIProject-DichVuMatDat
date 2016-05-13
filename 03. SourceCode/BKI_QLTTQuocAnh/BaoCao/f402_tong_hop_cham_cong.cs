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
using ExcelR = Microsoft.Office.Interop.Excel;


namespace BKI_DichVuMatDat.BaoCao
{
    public partial class f402_tong_hop_cham_cong : Form
    {
        #region Members
        string m_str_thang = "";
        string m_str_nam = "";
        #endregion

        #region Public Interface
        public f402_tong_hop_cham_cong(string ip_thang, string ip_nam)
        {
            InitializeComponent();
            set_initial_form_load(ip_thang, ip_nam);
        }

        public f402_tong_hop_cham_cong(string ip_thang, string ip_nam, decimal ip_id_nv)
        {
            InitializeComponent();
            set_initial_form_load(ip_thang, ip_nam);
            m_sle_chon_nhan_vien.EditValue = ip_id_nv;
           // m_sle_chon_nhan_vien.Visible = false;
        }

        #endregion

        #region Private Method
        private void set_initial_form_load(string ip_thang, string ip_nam)
        {
            m_str_thang = ip_thang;
            m_str_nam = ip_nam;
            set_define_events();
        }

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
            v_us.FillDatasetChamCongTongHop(v_ds, m_str_thang, m_str_nam, v_id_nhan_vien);
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

        #endregion

        #region Event Handle
        private void set_define_events()
        {
            this.Load += f402_tong_hop_cham_cong_Load;
            m_sle_chon_nhan_vien.EditValueChanged += m_sle_chon_nhan_vien_EditValueChanged;
            //m_cmd_xuat_bao_cao.Click +=m_cmd_xuat_bao_cao_Click;
            m_cmd_export_excel.Click += m_cmd_export_excel_Click;
        }

        void m_cmd_export_excel_Click(object sender, EventArgs e)
        {
            try
            {
                string op_file_name = "Tổng hợp chấm công tháng "+ m_str_thang + "-" + m_str_nam;
                string dest_file = WinFormControls.saveFileDialog(op_file_name);
                if (dest_file !="")
                {
                    m_pv.ExportToXls(dest_file);
                    XtraMessageBox.Show("Đã lưu báo cáo tại " + dest_file+"\nFile sẽ tự động mở ngay sau đây!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    var excel = new ExcelR.Application();
                    excel.Visible = true;
                    ExcelR.Workbooks books = excel.Workbooks;
                    ExcelR.Workbook openexcel = books.Open(dest_file);
                    this.Close();
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_sle_chon_nhan_vien_EditValueChanged(object sender, EventArgs e)
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

        void f402_tong_hop_cham_cong_Load(object sender, EventArgs e)
        {
            try
            {
                load_data_to_sle_chon_nhan_vien();
                load_data_to_m_pv();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        #endregion
    }
}
