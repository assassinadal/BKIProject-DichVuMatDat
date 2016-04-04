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


namespace BKI_DichVuMatDat.NghiepVu
{
    public partial class f341_dat_he_so_lns_lcd_v2 : Form
    {
        #region Public Interface
        public f341_dat_he_so_lns_lcd_v2()
        {
            InitializeComponent();
            format_controls();
        }

        public void display()
        {
            this.ShowDialog();
        }

        #endregion

        #region Members
        DataEntryFormMode m_e_form_mode = DataEntryFormMode.InsertDataState;
        decimal m_insert_click = 0;
        decimal m_id_gd_hd = 0;
        decimal m_id_loai_hop_dong = 0;
        decimal m_id_gd_hs_lns_lcd_hien_tai = 0;

        decimal m_id_ma_hs_lns_hien_tai = 0;
        decimal m_id_muc_hs_lns_hien_tai = 0;
        decimal m_id_ma_lcd_hien_tai = 0;
        decimal m_id_muc_lcd_hien_tai = 0;

        decimal m_id_gd_hs_lns_hien_tai = 0;
        decimal m_id_gd_lcd_hien_tai = 0;
        #endregion

        #region Private methods
        private void format_controls()
        {
            FormatControl.SetVisibleSimpleButton(this);
            this.m_grv_hs_lns.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(WinFormControls.m_grv_PopupMenuShowing);
            this.m_grv_hs_lns.OptionsPrint.AutoWidth = false;
            set_define_events();
            this.KeyPreview = true;
        }

        private void set_initial_form_load()
        {
            load_data_2_sle_chon_nv();
            load_all_data_2_grid_hs_lns();
            load_all_data_2_grid_lcd();
        }

        private void load_all_data_2_grid_lcd()
        {
            CHRMCommon.make_stt(m_grv_lcd);
            DS_V_F340_DAT_LCD v_ds = new DS_V_F340_DAT_LCD();
            US_V_F340_DAT_LCD v_us = new US_V_F340_DAT_LCD();
            v_us.FillDataset(v_ds,"ORDER BY NGAY_BAT_DAU_LCD DESC, HO_TEN ASC");
            m_grc_f340_lcd.DataSource = v_ds.Tables[0];
            m_grv_lcd.BestFitColumns();
        }

        private void load_all_data_2_grid_hs_lns()
        {
            CHRMCommon.make_stt(m_grv_hs_lns);
            DS_V_F340_DAT_HS_LNS v_ds = new DS_V_F340_DAT_HS_LNS();
            US_V_F340_DAT_HS_LNS v_us = new US_V_F340_DAT_HS_LNS();
            v_us.FillDataset(v_ds, "ORDER BY NGAY_BAT_DAU_LNS DESC, HO_TEN ASC");
            m_grc_f340_hs_lns.DataSource = v_ds.Tables[0];
            m_grv_hs_lns.BestFitColumns();
        }

        //load data 2 all control
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

        private DS_CM_DM_TU_DIEN load_data_2_cm_dm_tu_dien(int m_id_loai_td)
        {
            DS_CM_DM_TU_DIEN v_ds = new DS_CM_DM_TU_DIEN();
            US_CM_DM_TU_DIEN v_us = new US_CM_DM_TU_DIEN();

            v_us.FillDatasetByIdLoaiTuDien(v_ds, m_id_loai_td);

            return v_ds;
        }

        private void load_data_2_grc_hs_lns(decimal ip_dc_id_nhan_vien)
        {
            CHRMCommon.make_stt(m_grv_hs_lns);
            DS_V_F340_DAT_HS_LNS v_ds = new DS_V_F340_DAT_HS_LNS();
            US_V_F340_DAT_HS_LNS v_us = new US_V_F340_DAT_HS_LNS();
            v_us.FillDataset(v_ds, "WHERE ID = " + ip_dc_id_nhan_vien);
            m_grc_f340_hs_lns.DataSource = v_ds.Tables[0];
        }

        private void load_data_2_grc_lcd(decimal ip_dc_id_nhan_vien)
        {
            CHRMCommon.make_stt(m_grv_lcd);
            DS_V_F340_DAT_LCD v_ds = new DS_V_F340_DAT_LCD();
            US_V_F340_DAT_LCD v_us = new US_V_F340_DAT_LCD();
            v_us.FillDataset(v_ds, "WHERE ID = " + ip_dc_id_nhan_vien);
            m_grc_f340_lcd.DataSource = v_ds.Tables[0];
        }

        private decimal find_hs_lns(decimal ip_dc_id_ma_lns, decimal ip_dc_id_muc_lns)
        {
            try
            {
                US_DM_HE_SO_LUONG_NS v_us = new US_DM_HE_SO_LUONG_NS();
                DS_DM_HE_SO_LUONG_NS v_ds = new DS_DM_HE_SO_LUONG_NS();

                v_us.FillDataset(v_ds);

                string v_str_filter = "ID_MA_LNS = " + ip_dc_id_ma_lns + " AND ID_MUC_LNS = " + ip_dc_id_muc_lns;
                DataRow[] v_dr = v_ds.DM_HE_SO_LUONG_NS.Select(v_str_filter);

                if (v_dr.Count() == 0)
                {
                    return 0;
                }
                else
                {
                    return CIPConvert.ToDecimal(v_dr.First()["HE_SO"].ToString());
                }
            }
            catch (Exception v_e)
            {
                throw v_e;
            }
        }

        private decimal find_so_tien_lcd(decimal ip_dc_id_ma_lcd, decimal ip_dc_id_muc_lcd)
        {
            try
            {
                US_DM_LUONG_CHE_DO v_us = new US_DM_LUONG_CHE_DO();
                DS_DM_LUONG_CHE_DO v_ds = new DS_DM_LUONG_CHE_DO();

                v_us.FillDataset(v_ds);

                string v_str_filter = "ID_MA_LCD = " + ip_dc_id_ma_lcd + " AND ID_MUC_LCD = " + ip_dc_id_muc_lcd;
                DataRow[] v_dr = v_ds.DM_LUONG_CHE_DO.Select(v_str_filter);

                if (v_dr.Count() == 0)
                {
                    return 0;
                }
                else
                {
                    return CIPConvert.ToDecimal(v_dr.First()["SO_TIEN"].ToString());
                }
            }
            catch (Exception v_e)
            {
                throw v_e;
            }
        }

        //check validate data    

        //Insert, update, delete
        private decimal find_id_hd(decimal ip_dc_id_nv)
        {
            US_GD_HOP_DONG v_us = new US_GD_HOP_DONG();
            DS_GD_HOP_DONG v_ds = new DS_GD_HOP_DONG();

            v_us.FillDataset(v_ds);

            string v_str_filter = "ID_NHAN_VIEN = " + ip_dc_id_nv + " AND DA_XOA = 'N'";
            DataRow[] v_dr = v_ds.GD_HOP_DONG.Select(v_str_filter);

            if (v_dr.Count() == 0)
            {
                return -1;
            }
            else
            {
                return CIPConvert.ToDecimal(v_dr.First()["ID"].ToString());
            }
        }

        private decimal find_id_loai_hop_dong_cua_nhan_vien(decimal ip_dc_id_gd_hd)
        {
            US_GD_HOP_DONG v_us = new US_GD_HOP_DONG();
            DS_GD_HOP_DONG v_ds = new DS_GD_HOP_DONG();

            v_us.FillDataset(v_ds);

            string v_str_filter = "ID = " + ip_dc_id_gd_hd + " AND DA_XOA = 'N'";
            DataRow[] v_dr = v_ds.GD_HOP_DONG.Select(v_str_filter);

            if (v_dr.Count() == 0)
            {
                return -1;
            }
            else
            {
                return CIPConvert.ToDecimal(v_dr.First()["ID_LOAI_HOP_DONG"].ToString());
            }
        }

        private decimal find_id_gd_hs_lns_lcd_hien_tai(decimal ip_dc_id_gd_hd)
        {
            US_GD_HS_LNS_LCD v_us = new US_GD_HS_LNS_LCD();
            DS_GD_HS_LNS_LCD v_ds = new DS_GD_HS_LNS_LCD();

            v_us.FillDataset(v_ds);

            string v_str_filter = "ID_HOP_DONG = " + ip_dc_id_gd_hd + " AND DA_XOA = 'N'";
            DataRow[] v_dr = v_ds.GD_HS_LNS_LCD.Select(v_str_filter);

            if (v_dr.Count() == 0)
            {
                return -1;
            }
            else
            {
                return CIPConvert.ToDecimal(v_dr.First()["ID"].ToString());
            }
        }

        private decimal find_id_ma_hs_lns_hien_tai(decimal m_id_gd_hs_lns_lcd_hien_tai)
        {
            US_GD_HS_LNS_LCD v_us_gd_hs_lns_lcd = new US_GD_HS_LNS_LCD(m_id_gd_hs_lns_lcd_hien_tai);
            US_DM_HE_SO_LUONG_NS v_us_dm_hs_lns = new US_DM_HE_SO_LUONG_NS(v_us_gd_hs_lns_lcd.dcID_HS_LNS);

            return CIPConvert.ToDecimal(v_us_dm_hs_lns.dcID_MA_LNS);
        }

        private decimal find_id_muc_hs_lns_hien_tai(decimal m_id_gd_hs_lns_lcd_hien_tai)
        {
            US_GD_HS_LNS_LCD v_us_gd_hs_lns_lcd = new US_GD_HS_LNS_LCD(m_id_gd_hs_lns_lcd_hien_tai);
            US_DM_HE_SO_LUONG_NS v_us_dm_hs_lns = new US_DM_HE_SO_LUONG_NS(v_us_gd_hs_lns_lcd.dcID_HS_LNS);

            return CIPConvert.ToDecimal(v_us_dm_hs_lns.dcID_MUC_LNS);

        }

        private decimal find_id_ma_lcd_hien_tai(decimal m_id_gd_hs_lns_lcd_hien_tai)
        {
            US_GD_HS_LNS_LCD v_us_gd_hs_lns_lcd = new US_GD_HS_LNS_LCD(m_id_gd_hs_lns_lcd_hien_tai);
            US_DM_LUONG_CHE_DO v_us_dm_lcd = new US_DM_LUONG_CHE_DO(v_us_gd_hs_lns_lcd.dcID_LCD);

            return CIPConvert.ToDecimal(v_us_dm_lcd.dcID_MA_LCD);
        }

        private decimal find_id_muc_lcd_hien_tai(decimal m_id_gd_hs_lns_lcd_hien_tai)
        {
            US_GD_HS_LNS_LCD v_us_gd_hs_lns_lcd = new US_GD_HS_LNS_LCD(m_id_gd_hs_lns_lcd_hien_tai);
            US_DM_LUONG_CHE_DO v_us_dm_lcd = new US_DM_LUONG_CHE_DO(v_us_gd_hs_lns_lcd.dcID_LCD);

            return CIPConvert.ToDecimal(v_us_dm_lcd.dcID_MUC_LCD);
        }

        private decimal find_id_gd_hs_lns_hien_tai(decimal ip_dc_id_gd_hd)
        {
            US_GD_HE_SO_LNS v_us = new US_GD_HE_SO_LNS();
            DS_GD_HE_SO_LNS v_ds = new DS_GD_HE_SO_LNS();

            v_us.FillDataset(v_ds);

            string v_str_filter = "ID_HOP_DONG = " + ip_dc_id_gd_hd + " AND DA_XOA = 'N'";
            DataRow[] v_dr = v_ds.GD_HE_SO_LNS.Select(v_str_filter);

            if (v_dr.Count() == 0)
            {
                return -1;
            }
            else
            {
                return CIPConvert.ToDecimal(v_dr.First()["ID"].ToString());
            }
        }

        private decimal find_id_gd_lcd_hien_tai(decimal ip_dc_id_gd_hd)
        {
            US_GD_LUONG_CHE_DO v_us = new US_GD_LUONG_CHE_DO();
            DS_GD_LUONG_CHE_DO v_ds = new DS_GD_LUONG_CHE_DO();

            v_us.FillDataset(v_ds);

            string v_str_filter = "ID_HOP_DONG = " + ip_dc_id_gd_hd + " AND DA_XOA = 'N'";
            DataRow[] v_dr = v_ds.GD_LUONG_CHE_DO.Select(v_str_filter);

            if (v_dr.Count() == 0)
            {
                return -1;
            }
            else
            {
                return CIPConvert.ToDecimal(v_dr.First()["ID"].ToString());
            }
        }

        private decimal find_id_ma_lns(decimal ip_dc_id_hs_lns)
        {
            US_DM_HE_SO_LUONG_NS v_us = new US_DM_HE_SO_LUONG_NS();
            DS_DM_HE_SO_LUONG_NS v_ds = new DS_DM_HE_SO_LUONG_NS();

            v_us.FillDataset(v_ds);

            string v_str_filter = "ID = " + ip_dc_id_hs_lns;
            DataRow[] v_dr = v_ds.DM_HE_SO_LUONG_NS.Select(v_str_filter);

            if (v_dr.Count() == 0)
            {
                return -1;
            }
            else
            {
                return CIPConvert.ToDecimal(v_dr.First()["ID_MA_LNS"].ToString());
            }
        }

        private decimal find_id_muc_lns(decimal ip_dc_id_hs_lns)
        {
            US_DM_HE_SO_LUONG_NS v_us = new US_DM_HE_SO_LUONG_NS();
            DS_DM_HE_SO_LUONG_NS v_ds = new DS_DM_HE_SO_LUONG_NS();

            v_us.FillDataset(v_ds);

            string v_str_filter = "ID = " + ip_dc_id_hs_lns;
            DataRow[] v_dr = v_ds.DM_HE_SO_LUONG_NS.Select(v_str_filter);

            if (v_dr.Count() == 0)
            {
                return -1;
            }
            else
            {
                return CIPConvert.ToDecimal(v_dr.First()["ID_MUC_LNS"].ToString());
            }
        }

        private decimal find_id_ma_lcd(decimal ip_dc_id_lcd)
        {
            US_DM_LUONG_CHE_DO v_us = new US_DM_LUONG_CHE_DO();
            DS_DM_LUONG_CHE_DO v_ds = new DS_DM_LUONG_CHE_DO();

            v_us.FillDataset(v_ds);

            string v_str_filter = "ID = " + ip_dc_id_lcd;
            DataRow[] v_dr = v_ds.DM_LUONG_CHE_DO.Select(v_str_filter);

            if (v_dr.Count() == 0)
            {
                return -1;
            }
            else
            {
                return CIPConvert.ToDecimal(v_dr.First()["ID_MA_LCD"].ToString());
            }
        }

        private decimal find_id_muc_lcd(decimal ip_dc_id_lcd)
        {
            US_DM_LUONG_CHE_DO v_us = new US_DM_LUONG_CHE_DO();
            DS_DM_LUONG_CHE_DO v_ds = new DS_DM_LUONG_CHE_DO();

            v_us.FillDataset(v_ds);

            string v_str_filter = "ID = " + ip_dc_id_lcd;
            DataRow[] v_dr = v_ds.DM_LUONG_CHE_DO.Select(v_str_filter);

            if (v_dr.Count() == 0)
            {
                return -1;
            }
            else
            {
                return CIPConvert.ToDecimal(v_dr.First()["ID_MUC_LCD"].ToString());
            }
        }

        private void load_data_2_m_variable()
        {
            m_id_gd_hd = find_id_hd(CIPConvert.ToDecimal(m_sle_chon_nhan_vien.EditValue));
            if (m_id_gd_hd != 0)
            {
                m_id_gd_hs_lns_lcd_hien_tai = find_id_gd_hs_lns_lcd_hien_tai(m_id_gd_hd);
                m_id_loai_hop_dong = find_id_loai_hop_dong_cua_nhan_vien(m_id_gd_hd);
                if (m_id_loai_hop_dong != CONST_ID_LOAI_HOP_DONG.HOP_DONG_HOC_VIEC)
                {
                    m_id_ma_hs_lns_hien_tai = find_id_ma_hs_lns_hien_tai(m_id_gd_hs_lns_lcd_hien_tai);
                    m_id_muc_hs_lns_hien_tai = find_id_muc_hs_lns_hien_tai(m_id_gd_hs_lns_lcd_hien_tai);
                    m_id_ma_lcd_hien_tai = find_id_ma_lcd_hien_tai(m_id_gd_hs_lns_lcd_hien_tai); ;
                    m_id_muc_lcd_hien_tai = find_id_muc_lcd_hien_tai(m_id_gd_hs_lns_lcd_hien_tai);

                    m_id_gd_hs_lns_hien_tai = find_id_gd_hs_lns_hien_tai(m_id_gd_hd);
                    m_id_gd_lcd_hien_tai = find_id_gd_lcd_hien_tai(m_id_gd_hd);
                }
                else
                {
                    CHRM_BaseMessages.MsgBox_Infor(CONST_ID_MSGBOX.INFOR_HOP_DONG_HIEN_TAI_LA_HOC_VIEC);
                }
            }
            else
            {
                CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_NHAN_VIEN_CHUA_CO_HOP_DONG);
            }
        }

        private void focus_new_row_created(DevExpress.XtraGrid.Views.Grid.GridView ip_grv)
        {
            int v_row_index = 0;
            decimal v_id_gd_hd_f340 = 0;
            string v_da_xoa_f340 = "N";
            v_id_gd_hd_f340 = find_id_hd(CIPConvert.ToDecimal(m_sle_chon_nhan_vien.EditValue));

            if (ip_grv == m_grv_hs_lns)
            {
                US_V_F340_DAT_HS_LNS v_us = new US_V_F340_DAT_HS_LNS();
                DS_V_F340_DAT_HS_LNS v_ds = new DS_V_F340_DAT_HS_LNS();

                v_us.FillDataset(v_ds);

                for (v_row_index = 0; v_row_index < v_ds.Tables[0].Rows.Count; v_row_index++)
                {
                    var v_id_gd_hd = CIPConvert.ToDecimal(ip_grv.GetDataRow(v_row_index)["ID_HOP_DONG"].ToString());
                    var v_da_xoa = ip_grv.GetDataRow(v_row_index)["DA_XOA_LNS"].ToString();

                    if (v_id_gd_hd == v_id_gd_hd_f340 && v_da_xoa == v_da_xoa_f340)
                    {
                        break;
                    }
                }
                ip_grv.FocusedRowHandle = v_row_index;
            }
            else if (ip_grv == m_grv_lcd)
            {
                US_V_F340_DAT_LCD v_us = new US_V_F340_DAT_LCD();
                DS_V_F340_DAT_LCD v_ds = new DS_V_F340_DAT_LCD();

                v_us.FillDataset(v_ds);

                for (v_row_index = 0; v_row_index < v_ds.Tables[0].Rows.Count; v_row_index++)
                {
                    var v_id_gd_hd = CIPConvert.ToDecimal(ip_grv.GetDataRow(v_row_index)["ID_HOP_DONG"].ToString());
                    var v_da_xoa = ip_grv.GetDataRow(v_row_index)["DA_XOA_LCD"].ToString();

                    if (v_id_gd_hd == v_id_gd_hd_f340 && v_da_xoa == v_da_xoa_f340)
                    {
                        break;
                    }
                }
                ip_grv.FocusedRowHandle = v_row_index;
            }
        }

        //Design

        //Clear data in form

        #endregion

        private void set_define_events()
        {
            this.Load += f340_dat_hs_lns_lcd_Load;
            //cmd
            m_cmd_insert.Click += m_cmd_insert_Click;
            m_cmd_update.Click += m_cmd_update_Click;
            m_cmd_delete.Click += m_cmd_delete_Click;
            //control
            m_sle_chon_nhan_vien.EditValueChanged += m_sle_chon_nhan_vien_EditValueChanged;

            //gridview, gridcontrol
        }

        private void m_cmd_delete_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_update_Click(object sender, EventArgs e)
        {
            try
            {
                decimal id_nv = CIPConvert.ToDecimal(m_sle_chon_nhan_vien.EditValue);
                if (id_nv > 0)
                {
                    f342_dat_he_so_lns_lcd_de frm = new f342_dat_he_so_lns_lcd_de();
                    frm.display_4_update(id_nv);
                    load_data_2_grc_hs_lns(CIPConvert.ToDecimal(m_sle_chon_nhan_vien.EditValue));
                    load_data_2_grc_lcd(CIPConvert.ToDecimal(m_sle_chon_nhan_vien.EditValue));
                }
                else
                {
                    CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_CHUA_CHON_NHAN_VIEN);
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void f340_dat_hs_lns_lcd_Load(object sender, EventArgs e)
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

        void m_cmd_insert_Click(object sender, EventArgs e)
        {
            try
            {             
                    f342_dat_he_so_lns_lcd_de frm = new f342_dat_he_so_lns_lcd_de();
                    frm.display_4_insert();
                    if (frm.id_nv_hien_tai != 0)
                    {
                        m_sle_chon_nhan_vien.EditValue = frm.id_nv_hien_tai;
                        load_data_2_grc_hs_lns(frm.id_nv_hien_tai);
                        load_data_2_grc_lcd(frm.id_nv_hien_tai);
                    }
                    else
                    {
                        load_all_data_2_grid_hs_lns();
                        load_all_data_2_grid_lcd();
                        m_sle_chon_nhan_vien.EditValue = null;
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
                if (m_sle_chon_nhan_vien.EditValue == null || m_sle_chon_nhan_vien.EditValue == "")
                {
                    m_insert_click = -1;
                    load_all_data_2_grid_hs_lns();
                    load_all_data_2_grid_lcd();
                    m_insert_click = 0;
                }
                else
                {
                    m_id_gd_hd = find_id_hd(CIPConvert.ToDecimal(m_sle_chon_nhan_vien.EditValue));
                    if (m_id_gd_hd != -1)
                    {
                        m_id_loai_hop_dong = find_id_loai_hop_dong_cua_nhan_vien(m_id_gd_hd);
                        if (m_id_loai_hop_dong != CONST_ID_LOAI_HOP_DONG.HOP_DONG_HOC_VIEC)
                        {
                            load_data_2_m_variable();
                            load_data_2_grc_hs_lns(CIPConvert.ToDecimal(m_sle_chon_nhan_vien.EditValue));
                            load_data_2_grc_lcd(CIPConvert.ToDecimal(m_sle_chon_nhan_vien.EditValue));
                        }
                        else
                        {
                            CHRM_BaseMessages.MsgBox_Infor("Nhân viên có hợp đồng học việc. Ko có lương chế độ, lương năng suất");
                            m_insert_click = -1;
                            load_all_data_2_grid_hs_lns();
                            load_all_data_2_grid_lcd();
                            m_insert_click = 0;
                        }
                    }
                    else
                    {
                        CHRM_BaseMessages.MsgBox_Infor("Nhân viên chưa có hợp đồng hoặc đã xóa hợp đồng!");
                        load_data_2_grc_hs_lns(CIPConvert.ToDecimal(m_sle_chon_nhan_vien.EditValue));
                        load_data_2_grc_lcd(CIPConvert.ToDecimal(m_sle_chon_nhan_vien.EditValue));
                        m_insert_click = -1;
                        load_all_data_2_grid_hs_lns();
                        load_all_data_2_grid_lcd();
                        m_insert_click = 0;
                    }
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

    }
}

