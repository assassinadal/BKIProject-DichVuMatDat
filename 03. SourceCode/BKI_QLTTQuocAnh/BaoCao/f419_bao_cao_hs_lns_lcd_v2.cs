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
using BKI_DichVuMatDat.DS;
using BKI_DichVuMatDat.US;
using IP.Core.IPCommon;
using BKI_DichVuMatDat.DS.CDBNames;
using DevExpress.XtraEditors;
using System.Globalization;
using IP.Core.IPSystemAdmin;
using DevExpress.XtraSplashScreen;
using BKI_DichVuMatDat.BaoCao;
using BKI_DichVuMatDat.NghiepVu;

namespace BKI_DichVuMatDat.BaoCao
{
    public partial class f419_bao_cao_hs_lns_lcd_v2 : Form
    {
        //pr_lay_danh_sach_nv_het_han_hs_lns pr_lay_danh_sach_nv_het_han_lcd
        #region Public interface

        public f419_bao_cao_hs_lns_lcd_v2()
        {
            InitializeComponent();
            format_controls();
        }
        public void display_nv_het_han_hs_lns(DateTime v_ngay_hien_tai, f388_main f)
        {
            US_V_F419_BAO_CAO_HS_LNS_NHAN_VIEN_THEO_THANG v_us = new US_V_F419_BAO_CAO_HS_LNS_NHAN_VIEN_THEO_THANG();
            DataSet v_ds = v_us.LayDanhSachNhanVienHetHanHeSoLuongNangSuat(v_ngay_hien_tai);
            //
            m_e_mode = MyEnum.XEM_HET_HAN_HS_LNS;
            m_slpit_panel.PanelVisibility = SplitPanelVisibility.Panel1;
            m_slpit_panel.Dock = DockStyle.Fill;
            groupControl1.Visible = false;
            labelControl1.Text = "DANH SÁCH NHÂN VIÊN HẾT HẠN HỆ SỐ LƯƠNG NĂNG SUẤT";
            panelControl2.Visible = false;
            //
            CHRMCommon.make_stt(m_grv_bao_cao_hs_lns_nhan_vien);
            m_grc_bao_cao_hs_lns_nhan_vien.DataSource = v_ds.Tables[0];
            //
            m_dat_thang.EditValue = v_ngay_hien_tai;
            //
            this.CenterToScreen();
            this.ShowDialog();
            f.update_canh_bao();
        }

        public void display_nv_het_han_lcd(DateTime v_ngay_hien_tai, f388_main f)
        {
            US_V_F419_BAO_CAO_LCD_NHAN_VIEN_THEO_THANG v_us = new US_V_F419_BAO_CAO_LCD_NHAN_VIEN_THEO_THANG();
            DataSet v_ds = v_us.LayDanhSachNhanVienHetHanLuongCheDo(v_ngay_hien_tai);
            //
            m_e_mode = MyEnum.XEM_HET_HAN_LCD;
            m_slpit_panel.PanelVisibility = SplitPanelVisibility.Panel2;
            m_slpit_panel.Dock = DockStyle.Fill;
            groupControl1.Visible = false;
            labelControl1.Text = "DANH SÁCH NHÂN VIÊN HẾT HẠN LƯƠNG CHẾ ĐỘ";
            panelControl3.Visible = false;
            //
            CHRMCommon.make_stt(m_grv_bao_cao_lcd_nhan_vien);
            m_grc_bao_cao_lcd_nhan_vien.DataSource = v_ds.Tables[0];
            //
            m_dat_thang.EditValue = v_ngay_hien_tai;
            //
            this.CenterToScreen();
            this.ShowDialog();
            f.update_canh_bao();
        }
        #endregion

        #region Members
        enum MyEnum
        {
            XEM_LICH_SU,
            XEM_HET_HAN_HS_LNS,
            XEM_HET_HAN_LCD,
        }
        MyEnum m_e_mode = MyEnum.XEM_LICH_SU;
        decimal m_xem_het_lich_su_giao_dich = 0; //0 chua check, 1 check roi
        decimal thang;
        decimal nam;
        decimal m_dc_id_nv_dang_dieu_chinh;

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
            //m_txt_chon_thang.Text = DateTime.Now.Date.Month.ToString();
            //m_txt_chon_nam.Text = DateTime.Now.Date.Year.ToString();
            switch (m_e_mode)
            {
                case MyEnum.XEM_HET_HAN_HS_LNS:
                    {
                        m_slpit_panel.PanelVisibility = SplitPanelVisibility.Panel1;
                        m_btn_dieu_chinh_lns.Visible = true;
                        m_cmd_search.Enabled = false;
                        m_chk_hien_lich_su.Enabled = false;
                        m_dat_thang.Enabled = false;
                        m_sle_chon_nhan_vien.Enabled = false;
                        m_btn_dieu_chinh_lns.Enabled = false;
                        //
                        m_grv_bao_cao_hs_lns_nhan_vien.Click += M_grv_bao_cao_hs_lns_nhan_vien_Click;
                        m_grv_bao_cao_hs_lns_nhan_vien.SelectionChanged += M_grv_bao_cao_hs_lns_nhan_vien_Click;
                    }
                    break;
                case MyEnum.XEM_HET_HAN_LCD:
                    {
                        m_slpit_panel.PanelVisibility = SplitPanelVisibility.Panel2;
                        m_btn_dieu_chinh_lcd.Visible = true;
                        m_cmd_search.Enabled = false;
                        m_chk_hien_lich_su.Enabled = false;
                        m_dat_thang.Enabled = false;
                        m_sle_chon_nhan_vien.Enabled = false;
                        m_btn_dieu_chinh_lcd.Enabled = false;
                        //
                        m_grv_bao_cao_lcd_nhan_vien.Click += M_grv_bao_cao_lcd_nhan_vien_Click;
                        m_grv_bao_cao_lcd_nhan_vien.SelectionChanged += M_grv_bao_cao_lcd_nhan_vien_Click;
                    }
                    break;
                case MyEnum.XEM_LICH_SU:
                    m_dat_thang.EditValue = DateTime.Now;
                    break;
            }
            load_data_2_sle_chon_nv();
        }

        //
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

        private void load_data_canh_bao_het_han_lns_2_grid()
        {
            US_V_F419_BAO_CAO_HS_LNS_NHAN_VIEN_THEO_THANG v_us = new US_V_F419_BAO_CAO_HS_LNS_NHAN_VIEN_THEO_THANG();
            m_grc_bao_cao_hs_lns_nhan_vien.DataSource = v_us.LayDanhSachNhanVienHetHanHeSoLuongNangSuat(m_dat_thang.DateTime).Tables[0];
        }

        private void load_data_canh_bao_het_han_lcd_2_grid()
        {
            US_V_F419_BAO_CAO_LCD_NHAN_VIEN_THEO_THANG v_us = new US_V_F419_BAO_CAO_LCD_NHAN_VIEN_THEO_THANG();
            m_grc_bao_cao_lcd_nhan_vien.DataSource = v_us.LayDanhSachNhanVienHetHanLuongCheDo(m_dat_thang.DateTime).Tables[0];
        }
        //
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
                                                                            , thang
                                                                            , nam
                                                                            , ip_co_xem_lich_su_giao_dich);

            m_grc_bao_cao_hs_lns_nhan_vien.DataSource = v_ds_bc_hs_lns_nv_theo_thang.Tables[0];
        }

        private void load_data_2_grid_lcd(decimal ip_co_xem_lich_su_giao_dich)
        {
            CHRMCommon.make_stt(m_grv_bao_cao_lcd_nhan_vien);
            US_V_F419_BAO_CAO_LCD_NHAN_VIEN_THEO_THANG v_us_bc_lcd_nv_theo_thang = new US_V_F419_BAO_CAO_LCD_NHAN_VIEN_THEO_THANG();
            DS_V_F419_BAO_CAO_LCD_NHAN_VIEN_THEO_THANG v_ds_bc_lcd_nv_theo_thang = new DS_V_F419_BAO_CAO_LCD_NHAN_VIEN_THEO_THANG();

            v_us_bc_lcd_nv_theo_thang.FillDataset_by_thang_nam(v_ds_bc_lcd_nv_theo_thang
                                                                            , thang
                                                                            , nam
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
                                                                            , thang
                                                                            , nam
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
                                                                            , thang
                                                                            , nam
                                                                            , ip_dc_id_nhan_vien
                                                                            , ip_co_xem_lich_su_giao_dich);

            m_grc_bao_cao_lcd_nhan_vien.DataSource = v_ds_bc_lcd_nv_theo_thang.Tables[0];
        }

        private bool check_data_is_ok()
        {
            //if (m_txt_chon_thang.Text == "")
            //{
            //    CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_CHUA_CHON_THANG);
            //    return false;
            //}
            //else if (m_txt_chon_nam.Text == "")
            //{
            //    CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_CHUA_CHON_NAM);
            //    return false;
            //}
            //else
            //{
            //    if (check_validate_data_is_ok(m_txt_chon_thang.Text) && check_validate_data_is_ok(m_txt_chon_nam.Text))
            //    {
            return true;
            //    }
            //    else
            //    {
            //        CHRM_BaseMessages.MsgBox_Infor(CONST_ID_MSGBOX.ERROR_DU_LIEU_NHAP_CHUA_HOP_LE);
            //        return false;
            //    }
            //}
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
            //m_cmd_xuat_excel.Click += m_cmd_xuat_excel_Click;
            m_cmd_xuat_bc_hs_lns.Click += m_cmd_xuat_bc_hs_lns_Click;
            m_cmd_xuat_bc_lcd.Click += m_cmd_xuat_bc_lcd_Click;
            m_dat_thang.DateTimeChanged += M_dat_thang_DateTimeChanged;
            //
            m_btn_dieu_chinh_lcd.Click += M_btn_dieu_chinh_lcd_Click;
            m_btn_dieu_chinh_lns.Click += M_btn_dieu_chinh_lns_Click;
        }

        private void M_btn_dieu_chinh_lns_Click(object sender, EventArgs e)
        {
            try
            {
                f340_dat_hs_lns_lcd v_f = new f340_dat_hs_lns_lcd();
                v_f.display_4_dieu_chinh_lns(m_dc_id_nv_dang_dieu_chinh);
                load_data_canh_bao_het_han_lns_2_grid();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }


        private void M_btn_dieu_chinh_lcd_Click(object sender, EventArgs e)
        {
            try
            {
                f340_dat_hs_lns_lcd v_f = new f340_dat_hs_lns_lcd();
                v_f.display_4_dieu_chinh_lcd(m_dc_id_nv_dang_dieu_chinh);
                load_data_canh_bao_het_han_lcd_2_grid();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }


        private void M_dat_thang_DateTimeChanged(object sender, EventArgs e)
        {
            try
            {
                thang = m_dat_thang.DateTime.Month;
                nam = m_dat_thang.DateTime.Year;
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
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
                m_slpit_panel.PanelVisibility = SplitPanelVisibility.Both;
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

        private void M_grv_bao_cao_lcd_nhan_vien_Click(object sender, EventArgs e)
        {
            try
            {
                if (m_grv_bao_cao_lcd_nhan_vien.GetSelectedRows().ToList().Count == 0)
                {
                    m_btn_dieu_chinh_lcd.Enabled = false;
                    return;
                }
                string ma_nv = m_grv_bao_cao_lcd_nhan_vien.GetDataRow(m_grv_bao_cao_lcd_nhan_vien.GetSelectedRows()[0])["MA_NV"].ToString();
                if (ma_nv == "")
                {
                    m_btn_dieu_chinh_lcd.Enabled = false;
                    return;
                }
                m_btn_dieu_chinh_lcd.Enabled = true;
                m_dc_id_nv_dang_dieu_chinh = find_id_nv(ma_nv);
            }
            catch (Exception v_E)
            {
                CSystemLog_301.ExceptionHandle(v_E);
            }
        }

        private void M_grv_bao_cao_hs_lns_nhan_vien_Click(object sender, EventArgs e)
        {
            try
            {
                if (m_grv_bao_cao_hs_lns_nhan_vien.GetSelectedRows().ToList().Count == 0)
                {
                    m_btn_dieu_chinh_lns.Enabled = false;
                    return;
                }
                string ma_nv = m_grv_bao_cao_hs_lns_nhan_vien.GetDataRow(m_grv_bao_cao_hs_lns_nhan_vien.GetSelectedRows()[0])["MA_NV"].ToString();
                if (ma_nv == "")
                {
                    m_btn_dieu_chinh_lns.Enabled = false;
                    return;
                }
                m_btn_dieu_chinh_lns.Enabled = true;
                m_dc_id_nv_dang_dieu_chinh = find_id_nv(ma_nv);
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        #endregion
    }
}
