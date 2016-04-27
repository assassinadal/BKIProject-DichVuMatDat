using BKI_DichVuMatDat.US;
using IP.Core.IPCommon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BKI_DichVuMatDat.DS;
using BKI_DichVuMatDat.NghiepVu;
using DevExpress.XtraEditors;
using BKI_DichVuMatDat.NghiepVu.NhanSu;

namespace BKI_DichVuMatDat.DanhMuc
{
    public partial class F110_dm_hop_dong_het_han : Form
    {
        #region Public Interface

        public F110_dm_hop_dong_het_han()
        {
            InitializeComponent();
            Load += F110_dm_hop_dong_het_han_Load;
            m_dat_tu_ngay.EditValue = DateTime.Now;
            m_cmd_filter.Click += m_cmd_filter_Click;
        }

        public void display_canh_bao_het_han_hop_dong(DataSet ip_ds_het_han_hop_dong_thang_nay, f388_main f)
        {
            //
            //
            m_cmd_filter.Enabled = false;
            m_dat_tu_ngay.Enabled = false;
            m_dat_den_ngay.Enabled = false;
            //
            m_dat_den_ngay.EditValue = CHRMCommon.get_last_day_of_month(DateTime.Now);
            m_dat_tu_ngay.EditValue = CHRMCommon.get_first_day_of_month(DateTime.Now);
            CHRMCommon.make_stt(m_grv_hop_dong_het_han);
            m_grc_hop_dong_het_han.DataSource = ip_ds_het_han_hop_dong_thang_nay.Tables[0];
            //
            m_btn_dieu_chinh_hop_dong.Visible = true;
            m_btn_dieu_chinh_hop_dong.Enabled = false;
            m_btn_dieu_chinh_hop_dong.Click += M_btn_dieu_chinh_hop_dong_Click;
            m_grv_hop_dong_het_han.Click += M_grv_hop_dong_het_han_Click;
            m_grv_hop_dong_het_han.SelectionChanged += M_grv_hop_dong_het_han_Click;
            // 
            this.CenterToScreen();
            this.ShowDialog();
            f.update_canh_bao();
        }

        public void display_canh_bao_het_han_hop_dong(DateTime date1, DateTime date2, f388_main f)
        {
            //Disable các nút 
            m_cmd_filter.Enabled = false;
            m_dat_tu_ngay.Enabled = false;
            m_dat_den_ngay.Enabled = false;
            //
            m_dat_den_ngay.DateTime = CHRMCommon.get_last_day_of_month(date1);
            m_dat_tu_ngay.DateTime = CHRMCommon.get_first_day_of_month(date2);
            CHRMCommon.make_stt(m_grv_hop_dong_het_han);
            //
            US_GD_HOP_DONG v_us = new US_GD_HOP_DONG();
            DataSet v_ds = v_us.LayDanhSachHopDongHetHan(date1, date2);
            m_grc_hop_dong_het_han.DataSource = v_ds.Tables[0];
            //
            m_btn_dieu_chinh_hop_dong.Visible = true;
            m_btn_dieu_chinh_hop_dong.Enabled = false;
            m_btn_dieu_chinh_hop_dong.Click += M_btn_dieu_chinh_hop_dong_Click;
            m_grv_hop_dong_het_han.Click += M_grv_hop_dong_het_han_Click;
            m_grv_hop_dong_het_han.SelectionChanged += M_grv_hop_dong_het_han_Click;
            //
            m_grv_hop_dong_het_han.OptionsBehavior.Editable = false;
            m_grv_hop_dong_het_han.OptionsSelection.EnableAppearanceFocusedCell = false;
            m_grv_hop_dong_het_han.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            // 
            this.CenterToScreen();
            this.ShowDialog();
            f.update_canh_bao();
        }

        internal void display_for_show(DataSet dataSet)
        {
            m_grc_hop_dong_het_han.DataSource = dataSet.Tables[0];
            this.ShowDialog();
        }

        public void display(DateTime ip_dat_tu_ngay, DateTime ip_dat_den_ngay)
        {
            m_dat_tu_ngay.EditValue = ip_dat_tu_ngay;
            m_dat_den_ngay.EditValue = ip_dat_den_ngay;
            load_data_2_grid();
            Show();
        }

        #endregion

        #region Members

        private decimal m_dc_id_nv_dang_dieu_chinh = 0;

        #endregion

        #region Private Methods

        private void load_data_2_grid()
        {
            if (m_dat_tu_ngay.DateTime == null | m_dat_den_ngay.DateTime == null)
            {
                CHRM_BaseMessages.MsgBox_Error("Vui lòng chọn lọc dữ liệu theo ngày");
                return;
            }
            DateTime nbd = m_dat_tu_ngay.DateTime.Date;
            DateTime nkt = m_dat_den_ngay.DateTime.Date;

            US_GD_HOP_DONG v_us = new US_GD_HOP_DONG();
            CHRMCommon.make_stt(m_grv_hop_dong_het_han);
            m_grc_hop_dong_het_han.DataSource = v_us.LayDanhSachHopDongHetHanV2(nbd, nkt).Tables[0];
            m_grv_hop_dong_het_han.BestFitColumns();
        }

        private decimal find_id_nv(string ip_str_ma_nv)
        {
            US_DM_NHAN_VIEN v_us = new US_DM_NHAN_VIEN();
            DS_DM_NHAN_VIEN v_ds = new DS_DM_NHAN_VIEN();

            v_us.FillDataset(v_ds);

            string v_str_filter = "MA_NV = " + ip_str_ma_nv;
            DataRow[] v_dr = v_ds.DM_NHAN_VIEN.Select(v_str_filter);

            if (v_dr.Count() == 0)
            {
                return -1;
            }
            else
            {
                return CIPConvert.ToDecimal(v_dr.First()["ID"].ToString());
            }
        }

        #endregion

        #region Event Handlers

        void m_cmd_filter_Click(object sender, EventArgs e)
        {
            try
            {
                load_data_2_grid();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_xuat_excel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "xls files (*.xls)|*.xls|All files (*.*)|*.*";
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                m_grv_hop_dong_het_han.ExportToXls(saveFileDialog1.FileName);
                DevExpress.XtraEditors.XtraMessageBox.Show("Lưu báo cáo thành công");
            }
        }

        private void M_grv_hop_dong_het_han_Click(object sender, EventArgs e)
        {
            try
            {
                if (m_grv_hop_dong_het_han.GetSelectedRows().ToList().Count == 0)
                {
                    m_btn_dieu_chinh_hop_dong.Enabled = false;
                    return;
                }
                string ma_nv = m_grv_hop_dong_het_han.GetDataRow(m_grv_hop_dong_het_han.GetSelectedRows()[0])["MA_NV"].ToString();
                if (ma_nv == "")
                {
                    m_btn_dieu_chinh_hop_dong.Enabled = false;
                    return;
                }
                m_btn_dieu_chinh_hop_dong.Enabled = true;
                m_dc_id_nv_dang_dieu_chinh = find_id_nv(ma_nv);
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void F110_dm_hop_dong_het_han_Load(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void M_btn_dieu_chinh_hop_dong_Click(object sender, EventArgs e)
        {
            try
            {
                string ten_nv = m_grv_hop_dong_het_han.GetDataRow(m_grv_hop_dong_het_han.GetSelectedRows()[0])["HO_TEN"].ToString();
                if (CHRM_BaseMessages.MsgBox_Confirm("Bạn có chắc muốn lập hợp đồng mới cho nhân viên " + ten_nv))
                {
                    f330_lap_hop_dong_v4_detail v_f = new f330_lap_hop_dong_v4_detail();
                    v_f.display_for_insert(m_dc_id_nv_dang_dieu_chinh);
                }             
                US_GD_HOP_DONG v_us = new US_GD_HOP_DONG();
                m_grc_hop_dong_het_han.DataSource = v_us.LayDanhSachHopDongHetHan(m_dat_tu_ngay.DateTime.Date, m_dat_den_ngay.DateTime.Date).Tables[0];
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        #endregion

       
    }
}
