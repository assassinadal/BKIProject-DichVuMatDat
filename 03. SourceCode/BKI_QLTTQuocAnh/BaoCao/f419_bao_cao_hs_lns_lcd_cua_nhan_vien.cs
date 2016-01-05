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
        enum MyEnum
        {
            XEM_LICH_SU,


        }
        decimal m_xem_het_lich_su_giao_dich = 0; //0 chua check, 1 check roi
        #endregion

        #region Private Method
        private void format_controls()
        {
            FormatControl.SetVisibleSimpleButton(this);
            this.m_grv_bao_cao_hs_lns_nhan_vien.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(WinFormControls.m_grv_PopupMenuShowing);
            this.m_grv_bao_cao_hs_lns_nhan_vien.OptionsPrint.AutoWidth = false;
            set_define_events();
            this.KeyPreview = true;
        }

        private void set_init_form_load()
        {
            m_txt_chon_thang.Text = DateTime.Now.Date.Month.ToString();
            m_txt_chon_nam.Text = DateTime.Now.Date.Year.ToString();
            load_data_2_sle_chon_nv();
        }

        private DS_V_DM_NHAN_VIEN load_data_2_ds_v_dm_nv()
        {
            DS_V_DM_NHAN_VIEN v_ds = new DS_V_DM_NHAN_VIEN();
            US_V_DM_NHAN_VIEN v_us = new US_V_DM_NHAN_VIEN();

            v_us.FillDataset(v_ds);
            return v_ds;
        }

        private void load_data_2_sle_chon_nv()
        {
            m_sle_chon_nhan_vien.Properties.DataSource = load_data_2_ds_v_dm_nv().V_DM_NHAN_VIEN;
            m_sle_chon_nhan_vien.Properties.ValueMember = V_DM_NHAN_VIEN.ID;
            m_sle_chon_nhan_vien.Properties.DisplayMember = V_DM_NHAN_VIEN.HO_TEN;

            m_sle_chon_nhan_vien.Properties.PopulateViewColumns();

            m_sle_chon_nhan_vien.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            m_sle_chon_nhan_vien.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
        }

        private void load_data_2_grid()
        {
            if (m_chk_hien_lich_su.Checked == true)
            {
                m_xem_het_lich_su_giao_dich = 1;
                load_data_2_grid_hs_lns(m_xem_het_lich_su_giao_dich);
                load_data_2_grid_lcd(m_xem_het_lich_su_giao_dich);
            }
            else
            {
                m_xem_het_lich_su_giao_dich = 0;
                load_data_2_grid_hs_lns(m_xem_het_lich_su_giao_dich);
                load_data_2_grid_lcd(m_xem_het_lich_su_giao_dich);
            }
        }

        private void load_data_2_grid_hs_lns(decimal ip_co_xem_lich_su_giao_dich)
        {
            CHRMCommon.make_stt(m_grv_bao_cao_hs_lns_nhan_vien);
            US_V_F419_BAO_CAO_HS_LNS_NHAN_VIEN_THEO_THANG v_us_bc_hs_lns_nv_theo_thang = new US_V_F419_BAO_CAO_HS_LNS_NHAN_VIEN_THEO_THANG();
            DS_V_F419_BAO_CAO_HS_LNS_NHAN_VIEN_THEO_THANG v_ds_bc_hs_lns_nv_theo_thang = new DS_V_F419_BAO_CAO_HS_LNS_NHAN_VIEN_THEO_THANG();

            v_us_bc_hs_lns_nv_theo_thang.FillDataset_by_thang_nam(v_ds_bc_hs_lns_nv_theo_thang
                                                                            , CIPConvert.ToDecimal(m_txt_chon_thang.Text.Trim())
                                                                            , CIPConvert.ToDecimal(m_txt_chon_nam.Text.Trim())
                                                                            , ip_co_xem_lich_su_giao_dich);

            m_grc_bao_cao_hs_lns_nhan_vien.DataSource = v_ds_bc_hs_lns_nv_theo_thang.Tables[0];
        }

        private void load_data_2_grid_lcd(decimal ip_co_xem_lich_su_giao_dich)
        {
            CHRMCommon.make_stt(m_grv_bao_cao_lcd_nhan_vien);
            US_V_F419_BAO_CAO_LCD_NHAN_VIEN_THEO_THANG v_us_bc_lcd_nv_theo_thang = new US_V_F419_BAO_CAO_LCD_NHAN_VIEN_THEO_THANG();
            DS_V_F419_BAO_CAO_LCD_NHAN_VIEN_THEO_THANG v_ds_bc_lcd_nv_theo_thang = new DS_V_F419_BAO_CAO_LCD_NHAN_VIEN_THEO_THANG();

            v_us_bc_lcd_nv_theo_thang.FillDataset_by_thang_nam(v_ds_bc_lcd_nv_theo_thang
                                                                            , CIPConvert.ToDecimal(m_txt_chon_thang.Text.Trim())
                                                                            , CIPConvert.ToDecimal(m_txt_chon_nam.Text.Trim())
                                                                            , ip_co_xem_lich_su_giao_dich);

            m_grc_bao_cao_lcd_nhan_vien.DataSource = v_ds_bc_lcd_nv_theo_thang.Tables[0];
        }


        //
        private void load_data_2_grid(decimal ip_dc_id_nhan_vien)
        {
            if (m_chk_hien_lich_su.Checked == true)
            {
                m_xem_het_lich_su_giao_dich = 1;
                load_data_2_grid_hs_lns(ip_dc_id_nhan_vien, m_xem_het_lich_su_giao_dich);
                load_data_2_grid_lcd(ip_dc_id_nhan_vien, m_xem_het_lich_su_giao_dich);
            }
            else
            {
                m_xem_het_lich_su_giao_dich = 0;
                load_data_2_grid_hs_lns(ip_dc_id_nhan_vien, m_xem_het_lich_su_giao_dich);
                load_data_2_grid_lcd(ip_dc_id_nhan_vien, m_xem_het_lich_su_giao_dich);
            }
        }

        private void load_data_2_grid_hs_lns(decimal ip_dc_id_nhan_vien, decimal ip_co_xem_lich_su_giao_dich)
        {
            CHRMCommon.make_stt(m_grv_bao_cao_hs_lns_nhan_vien);
            US_V_F419_BAO_CAO_HS_LNS_NHAN_VIEN_THEO_THANG v_us_bc_hs_lns_nv_theo_thang = new US_V_F419_BAO_CAO_HS_LNS_NHAN_VIEN_THEO_THANG();
            DS_V_F419_BAO_CAO_HS_LNS_NHAN_VIEN_THEO_THANG v_ds_bc_hs_lns_nv_theo_thang = new DS_V_F419_BAO_CAO_HS_LNS_NHAN_VIEN_THEO_THANG();

            v_us_bc_hs_lns_nv_theo_thang.FillDataset_by_thang_nam_id_nhan_vien(v_ds_bc_hs_lns_nv_theo_thang
                                                                            , CIPConvert.ToDecimal(m_txt_chon_thang.Text.Trim())
                                                                            , CIPConvert.ToDecimal(m_txt_chon_nam.Text.Trim())
                                                                            , ip_dc_id_nhan_vien
                                                                            , ip_co_xem_lich_su_giao_dich);

            m_grc_bao_cao_hs_lns_nhan_vien.DataSource = v_ds_bc_hs_lns_nv_theo_thang.Tables[0];
        }

        private void load_data_2_grid_lcd(decimal ip_dc_id_nhan_vien, decimal ip_co_xem_lich_su_giao_dich)
        {
            CHRMCommon.make_stt(m_grv_bao_cao_lcd_nhan_vien);
            US_V_F419_BAO_CAO_LCD_NHAN_VIEN_THEO_THANG v_us_bc_lcd_nv_theo_thang = new US_V_F419_BAO_CAO_LCD_NHAN_VIEN_THEO_THANG();
            DS_V_F419_BAO_CAO_LCD_NHAN_VIEN_THEO_THANG v_ds_bc_lcd_nv_theo_thang = new DS_V_F419_BAO_CAO_LCD_NHAN_VIEN_THEO_THANG();

            v_us_bc_lcd_nv_theo_thang.FillDataset_by_thang_nam_id_nhan_vien(v_ds_bc_lcd_nv_theo_thang
                                                                            , CIPConvert.ToDecimal(m_txt_chon_thang.Text.Trim())
                                                                            , CIPConvert.ToDecimal(m_txt_chon_nam.Text.Trim())
                                                                            , ip_dc_id_nhan_vien
                                                                            , ip_co_xem_lich_su_giao_dich);

            m_grc_bao_cao_lcd_nhan_vien.DataSource = v_ds_bc_lcd_nv_theo_thang.Tables[0];
        }

        private bool check_data_is_ok()
        {
            if (m_txt_chon_thang.Text == "")
            {
                CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_CHUA_CHON_THANG);
                return false;
            }
            else if (m_txt_chon_nam.Text == "")
            {
                CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_CHUA_CHON_NAM);
                return false;
            }
            else
            {
                if (check_validate_data_is_ok(m_txt_chon_thang.Text) && check_validate_data_is_ok(m_txt_chon_nam.Text))
                {
                    return true;
                }
                else
                {
                    CHRM_BaseMessages.MsgBox_Infor(CONST_ID_MSGBOX.ERROR_DU_LIEU_NHAP_CHUA_HOP_LE);
                    return false;
                }
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

        #endregion

        #region Events Handle
        private void set_define_events()
        {
            this.Load += f419_bao_cao_hs_lns_lcd_cua_nhan_vien_Load;
            m_cmd_search.Click += m_cmd_search_Click;
            m_cmd_xuat_excel.Click += m_cmd_xuat_excel_Click;
            m_cmd_xuat_bc_hs_lns.Click += m_cmd_xuat_bc_hs_lns_Click;
            m_cmd_xuat_bc_lcd.Click += m_cmd_xuat_bc_lcd_Click;
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
                if (m_sle_chon_nhan_vien.EditValue == null)
                {
                    load_data_2_grid();
                }
                else
                {
                    load_data_2_grid(Convert.ToDecimal(m_sle_chon_nhan_vien.EditValue));
                }

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
                    m_grv_bao_cao_hs_lns_nhan_vien.ExportToXls(saveFileDialog1.FileName);
                    CHRM_BaseMessages.MsgBox_Infor(CONST_ID_MSGBOX.INFOR_LUU_BAO_CAO_THANH_CONG);
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_xuat_bc_hs_lns_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "xls files (*.xls)|*.xls|All files (*.*)|*.*";
                saveFileDialog1.RestoreDirectory = true;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    m_grv_bao_cao_hs_lns_nhan_vien.ExportToXls(saveFileDialog1.FileName);
                    CHRM_BaseMessages.MsgBox_Infor(CONST_ID_MSGBOX.INFOR_LUU_BAO_CAO_THANH_CONG);
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_xuat_bc_lcd_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "xls files (*.xls)|*.xls|All files (*.*)|*.*";
                saveFileDialog1.RestoreDirectory = true;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    m_grv_bao_cao_lcd_nhan_vien.ExportToXls(saveFileDialog1.FileName);
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
