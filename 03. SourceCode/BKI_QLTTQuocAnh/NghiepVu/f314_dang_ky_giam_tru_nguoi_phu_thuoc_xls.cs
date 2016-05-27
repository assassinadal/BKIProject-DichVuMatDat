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
using IP.Core.IPSystemAdmin;
using DevExpress.XtraSplashScreen;
namespace BKI_DichVuMatDat.NghiepVu
{
    public partial class f314_dang_ky_giam_tru_nguoi_phu_thuoc_xls : Form
    {
        #region Public Interface
        public f314_dang_ky_giam_tru_nguoi_phu_thuoc_xls()
        {
            InitializeComponent();
            set_define_events();
        }
        #endregion

        #region Members

        List<decimal> m_lst_nv_insert_phu_thuoc = new List<decimal>();

        #endregion

        #region Private Methods

        private void format_controls()
        {
            FormatControl.SetVisibleSimpleButton(this);
            set_define_events();
            this.KeyPreview = true;
        }

        private void insert_gd_phu_thuoc_details(DataRow v_dr, US_GD_PHU_THUOC_DETAILS v_us)
        {
            //US_GD_PHU_THUOC_DETAILS v_us = new US_GD_PHU_THUOC_DETAILS();
            v_us.dcID_GD_PHU_THUOC = get_id_by_ma_nhan_vien(v_dr[0].ToString());
            v_us.strHO_TEN_NGUOI_PHU_THUOC = v_dr[3].ToString();
            if (v_dr[4].ToString().Trim() !="")
                v_us.datNGAY_SINH = convert_datetime(v_dr[4].ToString());
            v_us.strMA_SO_THUE = v_dr[5].ToString();
            v_us.strQUOC_TICH = v_dr[6].ToString();
            v_us.strSO_CMT_HO_CHIEU = v_dr[7].ToString();
            v_us.strQUAN_HE_VOI_NGUOI_NOP_THUE = v_dr[8].ToString();
            v_us.strTTGKS_SO = v_dr[9].ToString();
            v_us.strTTGKS_QUYEN = v_dr[10].ToString();
            v_us.strTTGKS_QUOC_GIA = v_dr[11].ToString();
            v_us.strTTGKS_TINH_THANH = v_dr[12].ToString();
            v_us.strTTGKS_QUAN_HUYEN = v_dr[13].ToString();
            v_us.strTTGKS_PHUONG_XA = v_dr[14].ToString();
            if (v_dr[15].ToString().Trim() != "")
                v_us.datTU_NGAY = convert_datetime(v_dr[15].ToString());
            if (v_dr[16].ToString().Trim() != "")
                v_us.datDEN_NGAY = convert_datetime(v_dr[16].ToString());
            v_us.strNGUOI_LAP = CAppContext_201.getCurrentUserName();
            v_us.datNGAY_LAP = DateTime.Now;
            v_us.strDA_XOA = "N";
            v_us.Insert();
            v_us.ClearAllFields();     
        }

        private DateTime convert_datetime(string ip_date)
        {
            int v_int_date;
            if (int.TryParse(ip_date, out v_int_date))
            {
                return DateTime.FromOADate(v_int_date);
            }
            return DateTime.Parse(ip_date);
        }

        private decimal get_id_by_ma_nhan_vien(string ip_str_ma_nv)
        {
            DS_DM_NHAN_VIEN v_ds = new DS_DM_NHAN_VIEN();
            US_DM_NHAN_VIEN v_us = new US_DM_NHAN_VIEN();
            v_us.FillDataset(v_ds);
            decimal v_id_nv = v_us.getIDNhanVienByMaNV(ip_str_ma_nv);
            if (!m_lst_nv_insert_phu_thuoc.Contains(v_id_nv))
            {
                m_lst_nv_insert_phu_thuoc.Add(v_id_nv);
            }
            return v_id_nv;
        }

        private void load_data_to_grid()
        {
            DS_V_GD_PHU_THUOC_DETAILS_V2 v_ds = new DS_V_GD_PHU_THUOC_DETAILS_V2();
            US_V_GD_PHU_THUOC_DETAILS_V2 v_us = new US_V_GD_PHU_THUOC_DETAILS_V2();
            v_us.FillDataset(v_ds);
            m_grc.DataSource = v_ds.Tables[0];
        }

        private void focus_new_row_created(decimal ip_dc_id_gd_phu_thuoc_details)
        {
            int v_row_index = 0;
            decimal v_id_qd_moi_lap = 0;

            US_DM_THUE v_us = new US_DM_THUE();
            DS_DM_THUE v_ds = new DS_DM_THUE();

            v_id_qd_moi_lap = ip_dc_id_gd_phu_thuoc_details;

            v_us.FillDataset(v_ds);

            for (v_row_index = 0; v_row_index < v_ds.Tables[0].Rows.Count; v_row_index++)
            {
                var v_id_gd_qd = CIPConvert.ToDecimal(m_grv1.GetDataRow(v_row_index)["ID"].ToString());

                if (v_id_gd_qd == v_id_qd_moi_lap)
                {
                    break;
                }
            }

            m_grv1.FocusedRowHandle = v_row_index;
        }

        private bool check_du_lieu_hop_le()
        {
            if(m_grv1.RowCount > 0)
            { }
            else
            {
                XtraMessageBox.Show("Chưa có dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            for (int i = 0; i < m_grv1.RowCount; i++)
            {
                var v_dr = m_grv1.GetDataRow(i);
                US_DM_NHAN_VIEN v_us = new US_DM_NHAN_VIEN();
                if (!v_us.IsExistNhanVienInDB(v_dr[0].ToString()))
                {
                    string v_str = "Mã nhân viên '" + v_dr[0].ToString() + "' không tồn tại. Vui lòng kiểm tra lại!";
                    XtraMessageBox.Show(v_str, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else if (!check_datetime_data(v_dr[4].ToString()))
                {
                    string v_str = "Vui lòng kiểm tra lại ngày sinh người phụ thuộc của nhân viên " + v_dr[0].ToString();
                    XtraMessageBox.Show(v_str, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else if (!check_datetime_data(v_dr[15].ToString()))
                {
                    string v_str = "Vui lòng kiểm tra lại tháng bắt đầu giảm trừ của nhân viên " + v_dr[0].ToString();
                    XtraMessageBox.Show(v_str, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else if (!check_datetime_data(v_dr[16].ToString()))
                {
                    string v_str = "Vui lòng kiểm tra lại tháng kết thúc giảm trừ của nhân viên " + v_dr[0].ToString();
                    XtraMessageBox.Show(v_str, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }

        private bool check_datetime_data(string ip_datetime)
        {
            DateTime v_dt_ngay;
            int v_int_ngay;
            if (ip_datetime.Trim() != "" && !int.TryParse(ip_datetime, out v_int_ngay) && !DateTime.TryParse(ip_datetime, out v_dt_ngay))
                return false;
            return true;
        }

        #endregion

        #region Event handle
        private void set_define_events()
        {
            m_cmd_import_excel.Click += m_cmd_import_excel_Click;
            m_cmd_save.Click += m_cmd_save_Click;
            m_cmd_tai_file_mau.Click += m_cmd_tai_file_mau_Click;
            m_bgw.DoWork += m_bgw_DoWork;
            m_bgw.ProgressChanged += m_bgw_ProgressChanged;
            m_bgw.RunWorkerCompleted += m_bgw_RunWorkerCompleted;
        }

        void m_bgw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                m_pn.Visible = false;
                m_prb.Visible = false;
                this.Close();
                XtraMessageBox.Show("Lưu thành công");
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_bgw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            try
            {
                m_prb.EditValue = e.ProgressPercentage;
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_bgw_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            US_GD_PHU_THUOC_DETAILS v_us_trans = new US_GD_PHU_THUOC_DETAILS();
            try
            {
                v_us_trans.BeginTransaction();
                for (int i = 0; i < m_grv1.RowCount; i++)
                {
                    var v_dr = m_grv1.GetDataRow(i);
                    insert_gd_phu_thuoc_details(v_dr, v_us_trans);
                    worker.ReportProgress((i + 1) * 100 / m_grv1.RowCount);
                }
                v_us_trans.CommitTransaction();
            }
            catch (Exception v_e)
            {
                if(v_us_trans.is_having_transaction())
                {
                    v_us_trans.Rollback();
                }
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_save_Click(object sender, EventArgs e)
        {
            m_lst_nv_insert_phu_thuoc.Clear();
            try
            {
                if (check_du_lieu_hop_le())
                {
                    m_pn.Visible = true;
                    m_prb.Visible = true;
                    m_cmd_save.Enabled = false;
                    m_bgw.RunWorkerAsync();
                }              
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_import_excel_Click(object sender, EventArgs e)
        {
            m_grc.DataSource = null;
            try
            {
                string v_file_name = WinFormControls.openFileDialog();
                if (v_file_name != "")
                {
                    WinFormControls.load_xls_to_gridview(v_file_name, m_grc);
                    m_cmd_save.Enabled = true;
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_tai_file_mau_Click(object sender, EventArgs e)
        {
            try
            {
                WinFormControls.openTemplate_v2("DangKyPhuThuoc.xls");
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        #endregion
    }
}
