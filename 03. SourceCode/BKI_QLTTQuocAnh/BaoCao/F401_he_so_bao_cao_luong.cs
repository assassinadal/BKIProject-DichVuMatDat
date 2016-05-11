using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BKI_DichVuMatDat.US;
using IP.Core.IPCommon;
using BKI_DichVuMatDat.DS;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using BKI_DichVuMatDat.DS.CDBNames;
using DevExpress.XtraSplashScreen;

namespace BKI_DichVuMatDat.BaoCao
{
    public partial class F401_he_so_bao_cao_luong : Form
    {
        public F401_he_so_bao_cao_luong()
        {
            InitializeComponent();
            format_controls();
            m_dat_thang.DateTime = DateTime.Now.Date;
        }
        public void hien_thi_ra_soat_tinh_luong(decimal ip_dc_thang, decimal ip_dc_nam)
        {
            load_data_2_grid(ip_dc_thang, ip_dc_nam);
            m_band_tham_so_bang_luong_thang.ActiveFilterString = "[DU_DIEU_KIEN] = '0'";
            m_dat_thang.DateTime = new DateTime((int)ip_dc_nam, (int)ip_dc_thang, 1).Date;
            ShowDialog();
        }
        #region Members
        US_BAO_CAO_THAM_SO_BANG_LUONG m_us_tham_so_bang_luong;
        int soLuongThieuDVCT;
        int soluongChuaChamCong;
        #endregion

        #region Private Methods
        private void format_controls()
        {
            //FormatControl.SetVisibleSimpleButton(this);
            set_define_events();
            this.KeyPreview = true;
        }
        private decimal lay_thang()
        {
            return Convert.ToDecimal(m_dat_thang.DateTime.Month);
        }
        private decimal lay_nam()
        {
            return Convert.ToDecimal(m_dat_thang.DateTime.Year);
        }
        private void load_data_2_grid(decimal ip_dc_thang, decimal ip_dc_nam)
        {
            try
            {
                SplashScreenManager.ShowForm(typeof(F_wait_form));
                m_us_tham_so_bang_luong = new US_BAO_CAO_THAM_SO_BANG_LUONG();
                DS_BAO_CAO_THAM_SO_BANG_LUONG v_ds = new DS_BAO_CAO_THAM_SO_BANG_LUONG();
                m_us_tham_so_bang_luong.GetThamSoBangLuongThang(v_ds, ip_dc_thang, ip_dc_nam);
                m_gd_tham_so_bang_luong_thang.DataSource = v_ds.Tables[0];
                CHRMCommon.make_stt(m_band_tham_so_bang_luong_thang);
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
               SplashScreenManager.CloseForm();
            }
        }
        private void set_initial_form_load()
        {
            //m_txt_thang.Text = DateTime.Now.Month.ToString();
            //m_txt_nam.Text = DateTime.Now.Year.ToString();
        }
        private void set_define_events()
        {
            this.Load += F401_he_so_bao_cao_luong_Load;
            m_cmd_loc.Click += m_cmd_loc_Click;
            m_band_tham_so_bang_luong_thang.CustomSummaryCalculate += m_band_tham_so_bang_luong_thang_CustomSummaryCalculate;
        }
        
        #endregion

        #region Events
        void F401_he_so_bao_cao_luong_Load(object sender, EventArgs e)
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

        void m_cmd_loc_Click(object sender, EventArgs e)
        {
            try
            {
                decimal v_dc_thang = lay_thang();
                decimal v_dc_nam = lay_nam();
                if (v_dc_thang <= 12 && v_dc_thang >= 0 && v_dc_nam >= 0)
                    load_data_2_grid(v_dc_thang, v_dc_nam);
                else
                    CHRM_BaseMessages.MsgBox_Warning("Kiểm tra lại tháng và năm");
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_gd_tham_so_bang_luong_thang_Click(object sender, EventArgs e)
        {

        }
        void m_band_tham_so_bang_luong_thang_CustomSummaryCalculate(object sender, DevExpress.Data.CustomSummaryEventArgs e)
        {
            GridView view = sender as GridView;

            // Get the value summary tag
            int summaryTag = Convert.ToInt32((e.Item as GridSummaryItem).Tag);

            // Initialization
            if(e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Start)
            {
                soLuongThieuDVCT = 0;
                soluongChuaChamCong = 0;
            }

            // Caculation 
            if (e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Calculate)
            {
                switch (summaryTag) { 
                    case 1: // Không có đơn vị công tác
                        string cellValue = Convert.ToString(view.GetRowCellValue(e.RowHandle, THAM_SO_TINH_BANG_LUONG.CO_DON_VI_CONG_TAC));
                        if (cellValue == "KHÔNG") 
                            soLuongThieuDVCT++;
                        break;
                    case 7: // Chưa chấm công
                        string cellValueCol_ChamCong = Convert.ToString(view.GetRowCellValue(e.RowHandle, THAM_SO_TINH_BANG_LUONG.DA_CHAM_CONG));
                        if (cellValueCol_ChamCong == "N")
                            soluongChuaChamCong++;
                        break;
                }
            }
            // Finalization
            if (e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Finalize)
            {
                switch (summaryTag)
                {
                    case 1:
                        e.TotalValue = soLuongThieuDVCT;
                        break;
                    case 7:
                        e.TotalValue = soluongChuaChamCong;
                        break;
                }
            }
        }
        #endregion Events        
    }
}
