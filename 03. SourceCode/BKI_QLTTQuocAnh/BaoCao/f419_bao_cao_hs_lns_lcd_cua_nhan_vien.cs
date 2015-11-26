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
using IP.Core.IPCommon;
using BKI_DichVuMatDat.DS.CDBNames;
using DevExpress.XtraEditors;
using System.Globalization;
using IP.Core.IPSystemAdmin;
using DevExpress.XtraSplashScreen;
using BKI_DichVuMatDat.BaoCao;

namespace BKI_DichVuMatDat.BaoCao
{
    public partial class f419_bao_cao_hs_lns_lcd_cua_nhan_vien : Form
    {
        public f419_bao_cao_hs_lns_lcd_cua_nhan_vien()
        {
            InitializeComponent();
            format_controls();
        }

        #region Public interface

        #endregion

        #region Members

        #endregion

        #region Private Method
        private void format_controls()
        {
            FormatControl.SetVisibleSimpleButton(this);
            this.m_grv_bao_cao_hs_lns_lcd_nhan_vien.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(WinFormControls.m_grv_PopupMenuShowing);
            this.m_grv_bao_cao_hs_lns_lcd_nhan_vien.OptionsPrint.AutoWidth = false;
            set_define_events();
            this.KeyPreview = true;
        }

        private void set_init_form_load()
        {
            m_txt_chon_thang.Text = DateTime.Now.Date.Month.ToString();
            m_txt_chon_nam.Text = DateTime.Now.Date.Year.ToString();
        }

        private void load_data_2_grid()
        {
            CHRMCommon.make_stt(m_grv_bao_cao_hs_lns_lcd_nhan_vien);
            US_V_F419_BAO_CAO_HS_LNS_LCD_NHAN_VIEN_THEO_THANG v_us_bc_hs_lns_lcd_nv_theo_thang = new US_V_F419_BAO_CAO_HS_LNS_LCD_NHAN_VIEN_THEO_THANG();
            DS_V_F419_BAO_CAO_HS_LNS_LCD_NHAN_VIEN_THEO_THANG v_ds_bc_hs_lns_lcd_nv_theo_thang = new DS_V_F419_BAO_CAO_HS_LNS_LCD_NHAN_VIEN_THEO_THANG();

            v_us_bc_hs_lns_lcd_nv_theo_thang.FillDataset_by_thang_nam(v_ds_bc_hs_lns_lcd_nv_theo_thang
                                                                            , CIPConvert.ToDecimal(m_txt_chon_thang.Text.Trim())
                                                                            , CIPConvert.ToDecimal(m_txt_chon_nam.Text.Trim()));

            m_grc_bao_cao_hs_lns_lcd_nhan_vien.DataSource = v_ds_bc_hs_lns_lcd_nv_theo_thang.Tables[0];
        }

        private bool check_data_is_ok()
        {
            if (m_txt_chon_thang.Text == "")
            {
                CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_CHUA_CHON_THANG);
                return false;
            }
            if (m_txt_chon_nam.Text == "")
            {
                CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_CHUA_CHON_NAM);
                return false;
            }
            return true;
        }

        #endregion

        #region Events Handle
        private void set_define_events()
        {
            this.Load += f419_bao_cao_hs_lns_lcd_cua_nhan_vien_Load;
            m_cmd_search.Click += m_cmd_search_Click;
            m_cmd_xuat_excel.Click += m_cmd_xuat_excel_Click;
        }

        void f419_bao_cao_hs_lns_lcd_cua_nhan_vien_Load(object sender, EventArgs e)
        {
            try
            {
                set_init_form_load();
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
                if (!check_data_is_ok())
                    return;
                load_data_2_grid();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_xuat_excel_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "xls files (*.xls)|*.xls|All files (*.*)|*.*";
                saveFileDialog1.RestoreDirectory = true;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    m_grv_bao_cao_hs_lns_lcd_nhan_vien.ExportToXls(saveFileDialog1.FileName);
                    CHRM_BaseMessages.MsgBox_Infor(CONST_ID_MSGBOX.INFOR_LUU_BAO_CAO_THANH_CONG);
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        #endregion
    }
}
