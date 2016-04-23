﻿using BKI_DichVuMatDat.DS;
using BKI_DichVuMatDat.DS.CDBNames;
using BKI_DichVuMatDat.US;
using DevExpress.XtraEditors;
using DevExpress.XtraTreeList.Nodes;
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
using BKI_DichVuMatDat.NghiepVu;
using IP.Core.IPSystemAdmin;
using DevExpress.XtraLayout.Utils;

namespace BKI_DichVuMatDat.NghiepVu
{
    public partial class f299_chinh_lns_nhan_vien_de : Form
    {
        private DataEntryFormMode m_e_form_mode;
        US_GD_HE_SO_LNS m_us = new US_GD_HE_SO_LNS();

        public f299_chinh_lns_nhan_vien_de()
        {
            InitializeComponent();
            format_controll();
        }

        public void display_4_insert(US_GD_HE_SO_LNS ip_us)
        {
            m_us = ip_us;
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            us_2_form();
            m_dat_ngay_bat_dau_cu.Enabled = false;
            m_group.Text = "Đặt mức lương năng suất mới";
            ShowDialog();
        }

        public void display_4_update(US_GD_HE_SO_LNS ip_us)
        {
            m_us = ip_us;
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            us_2_form();
            m_group_old.Visibility = LayoutVisibility.Never;
            m_group.Text = "Sửa mức lương năng suất hiện tại";
            ShowDialog();
        }

        private void us_2_form()
        {
            m_txt_ly_do.Text = m_us.strLY_DO_CHINH_SUA;

            US_DM_HE_SO_LUONG_NS v_us = new US_DM_HE_SO_LUONG_NS(m_us.dcID_HE_SO_LNS);

            m_sle_chuc_danh_lns.EditValue = v_us.dcID_MA_LNS;
            m_sle_muc_lns.EditValue = v_us.dcID_MUC_LNS;

            switch (m_e_form_mode)
            {
                case DataEntryFormMode.UpdateDataState:
                    m_dat_ngay_bat_dau.EditValue = m_us.datNGAY_BAT_DAU;
                    m_dat_ngay_ket_thuc.EditValue = m_us.datNGAY_KET_THUC;
                    break;
                case DataEntryFormMode.InsertDataState:
                    
                    if (m_us.IsNGAY_KET_THUCNull())
                    {
                        m_dat_ngay_ket_thuc_cu.EditValue = null;
                    }
                    else
                    {
                        m_dat_ngay_ket_thuc_cu.EditValue = m_us.datNGAY_KET_THUC;
                    }
                    
                    m_dat_ngay_bat_dau_cu.EditValue = m_us.datNGAY_BAT_DAU;
                    m_dat_ngay_bat_dau.EditValue = DateTime.Now.Date;
                    break;
                case DataEntryFormMode.ViewDataState:
                    break;
                case DataEntryFormMode.SelectDataState:
                    break;
                default:
                    break;
            }

            m_txt_hs_lns.Text = m_us.dcHE_SO.ToString();
        }

        private void format_controll()
        {
            CenterToScreen();
            set_define_events();
        }

        private void set_init_form_load()
        {
            load_data_to_sle_chuc_danh_lns();
            load_data_to_sle_muc_lns();
            load_data_to_grid();
            load_data_to_txt_nv();
        }

        private void load_data_to_txt_nv()
        {
            US_V_DM_NHAN_VIEN v_us = new US_V_DM_NHAN_VIEN(m_us.dcID_NHAN_VIEN);
            m_lbl_header.Text = v_us.strMA_NV.ToString() + "    :   " + v_us.strHO_TEN.ToString();
        }

        private void load_data_to_grid()
        {
            US_V_GD_HE_SO_LNS v_us = new US_V_GD_HE_SO_LNS();
            DS_V_GD_HE_SO_LNS v_ds = new DS_V_GD_HE_SO_LNS();
            v_ds.EnforceConstraints = false;
            v_us.FillDataset(v_ds, " where ID_NHAN_VIEN = " + m_us.dcID_NHAN_VIEN);

            m_grc.DataSource = v_ds.Tables[0];
        }

        private void load_data_to_sle_chuc_danh_lns()
        {
            m_sle_chuc_danh_lns.Properties.DataSource = load_data_2_cm_dm_tu_dien(CONST_ID_LOAI_TU_DIEN.MA_HS_LNS).CM_DM_TU_DIEN;
            m_sle_chuc_danh_lns.Properties.ValueMember = CM_DM_TU_DIEN.ID;
            m_sle_chuc_danh_lns.Properties.DisplayMember = CM_DM_TU_DIEN.TEN;

            m_sle_chuc_danh_lns.Properties.PopulateViewColumns();
            m_sle_chuc_danh_lns.Properties.View.Columns[CM_DM_TU_DIEN.ID].Visible = false;
            m_sle_chuc_danh_lns.Properties.View.Columns[CM_DM_TU_DIEN.ID_LOAI_TU_DIEN].Visible = false;
            m_sle_chuc_danh_lns.Properties.View.Columns[CM_DM_TU_DIEN.TEN_NGAN].Visible = false;

            m_sle_chuc_danh_lns.Properties.View.Columns[CM_DM_TU_DIEN.MA_TU_DIEN].Width = 75;
            m_sle_chuc_danh_lns.Properties.View.Columns[CM_DM_TU_DIEN.TEN].Width = 120;

            m_sle_chuc_danh_lns.Properties.View.Columns[CM_DM_TU_DIEN.MA_TU_DIEN].Caption = "Mã chức danh";
            m_sle_chuc_danh_lns.Properties.View.Columns[CM_DM_TU_DIEN.TEN].Caption = "Chức danh";
            m_sle_chuc_danh_lns.Properties.View.Columns[CM_DM_TU_DIEN.GHI_CHU].Caption = "Ghi chú";

            m_sle_chuc_danh_lns.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            m_sle_chuc_danh_lns.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
        }

        private DS_CM_DM_TU_DIEN load_data_2_cm_dm_tu_dien(int m_id_lns_lcd_trong_loai_td)
        {
            DS_CM_DM_TU_DIEN v_ds = new DS_CM_DM_TU_DIEN();
            US_CM_DM_TU_DIEN v_us = new US_CM_DM_TU_DIEN();

            v_us.FillDatasetByIdLoaiTuDien(v_ds, m_id_lns_lcd_trong_loai_td);

            return v_ds;
        }

        private void load_data_to_sle_muc_lns()
        {
            m_sle_muc_lns.Properties.DataSource = load_data_2_cm_dm_tu_dien(CONST_ID_LOAI_TU_DIEN.MUC_HS_LNS).CM_DM_TU_DIEN;
            m_sle_muc_lns.Properties.ValueMember = CM_DM_TU_DIEN.ID;
            m_sle_muc_lns.Properties.DisplayMember = CM_DM_TU_DIEN.TEN;

            m_sle_muc_lns.Properties.PopulateViewColumns();
            m_sle_muc_lns.Properties.View.Columns[CM_DM_TU_DIEN.ID].Visible = false;
            m_sle_muc_lns.Properties.View.Columns[CM_DM_TU_DIEN.ID_LOAI_TU_DIEN].Visible = false;
            m_sle_muc_lns.Properties.View.Columns[CM_DM_TU_DIEN.TEN_NGAN].Visible = false;

            m_sle_muc_lns.Properties.View.Columns[CM_DM_TU_DIEN.MA_TU_DIEN].Width = 75;
            m_sle_muc_lns.Properties.View.Columns[CM_DM_TU_DIEN.TEN].Width = 120;

            m_sle_muc_lns.Properties.View.Columns[CM_DM_TU_DIEN.MA_TU_DIEN].Caption = "Mã mức";
            m_sle_muc_lns.Properties.View.Columns[CM_DM_TU_DIEN.TEN].Caption = "Tên mức";
            m_sle_muc_lns.Properties.View.Columns[CM_DM_TU_DIEN.GHI_CHU].Caption = "Ghi chú";

            m_sle_muc_lns.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            m_sle_muc_lns.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
        }

        private bool check_data_is_ok()
        {
            if (m_sle_chuc_danh_lns.EditValue == null)
            {
                string v_str_error = "Vui lòng chọn chức danh lương năng suất!";
                XtraMessageBox.Show(v_str_error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (m_sle_muc_lns.EditValue == null)
            {
                string v_str_error = "Vui lòng chọn mức lương năng suất!";
                XtraMessageBox.Show(v_str_error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (m_dat_ngay_bat_dau.EditValue == null)
            {
                string v_str_error = "Vui lòng nhập ngày bắt đầu lương năng suất!";
                XtraMessageBox.Show(v_str_error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else return datetime_changed();
        }

        private void save_data()
        {
            switch (m_e_form_mode)
            {
                case DataEntryFormMode.UpdateDataState:
                    update_data();
                    CHRM_BaseMessages.MsgBox_Infor(CONST_ID_MSGBOX.INFOR_DU_LIEU_DA_DUOC_CAP_NHAT);
                    Close();
                    break;
                case DataEntryFormMode.InsertDataState:
                    insert_data();
                    CHRM_BaseMessages.MsgBox_Infor(CONST_ID_MSGBOX.INFOR_DU_LIEU_DA_DUOC_CAP_NHAT);
                    Close();
                    break;
                case DataEntryFormMode.ViewDataState:
                    break;
                case DataEntryFormMode.SelectDataState:
                    break;
                default:
                    break;
            }
        }

        private void update_data()
        {
            form_2_us();
            m_us.Update();
        }

        private decimal find_id_hs_lns()
        {
            US_DM_HE_SO_LUONG_NS v_us = new US_DM_HE_SO_LUONG_NS();
            DS_DM_HE_SO_LUONG_NS v_ds = new DS_DM_HE_SO_LUONG_NS();

            v_us.FillDataset(v_ds);

            string v_str_filter = "ID_MA_LNS = " + m_sle_chuc_danh_lns.EditValue + " AND ID_MUC_LNS = " + m_sle_muc_lns.EditValue;
            DataRow[] v_dr = v_ds.DM_HE_SO_LUONG_NS.Select(v_str_filter);

            if (v_dr.Count() == 0)
            {
                return -1;
            }
            else
            {
                return CIPConvert.ToDecimal(v_dr.First()["ID"].ToString());
            }
        }

        private void insert_data()
        {
            m_us.datNGAY_KET_THUC = m_dat_ngay_ket_thuc_cu.DateTime.Date;
            m_us.Update();
            form_2_us();
            m_us.Insert();
        }

        private void form_2_us()
        {
            m_us.datNGAY_BAT_DAU = m_dat_ngay_bat_dau.DateTime.Date;
            if (m_dat_ngay_ket_thuc.EditValue != null)
            {
                m_us.datNGAY_KET_THUC = m_dat_ngay_ket_thuc.DateTime.Date;
            }
            else
            {
                m_us.SetNGAY_KET_THUCNull();
            }

            m_us.dcHE_SO = Convert.ToDecimal(m_txt_hs_lns.Text);
            m_us.dcID_HE_SO_LNS = find_id_hs_lns();

            m_us.strLY_DO_CHINH_SUA = m_txt_ly_do.Text;

            switch (m_e_form_mode)
            {
                case DataEntryFormMode.UpdateDataState:
                    m_us.datNGAY_SUA = DateTime.Now.Date;
                    m_us.strNGUOI_SUA = CAppContext_201.getCurrentUserName();
                    break;
                case DataEntryFormMode.InsertDataState:
                    m_us.datNGAY_LAP = DateTime.Now.Date;
                    m_us.strNGUOI_LAP = CAppContext_201.getCurrentUserName();
                    break;
                case DataEntryFormMode.ViewDataState:
                    break;
                case DataEntryFormMode.SelectDataState:
                    break;
                default:
                    break;
            }
        }

        private string find_hs_lns()
        {
            if (m_sle_chuc_danh_lns.EditValue != null
                && m_sle_muc_lns.EditValue != null)
            {
                US_DM_HE_SO_LUONG_NS v_us = new US_DM_HE_SO_LUONG_NS();
                DS_DM_HE_SO_LUONG_NS v_ds = new DS_DM_HE_SO_LUONG_NS();

                v_us.FillDataset(v_ds);

                string v_str_filter = "ID_MA_LNS = " + m_sle_chuc_danh_lns.EditValue + " AND ID_MUC_LNS = " + m_sle_muc_lns.EditValue;
                DataRow[] v_dr = v_ds.DM_HE_SO_LUONG_NS.Select(v_str_filter);

                if (v_dr.Count() == 0)
                {
                    return "";
                }
                else
                {
                    return v_dr.First()["HE_SO"].ToString().ToString();
                }
            }
            else
            {
                return "";
            }
        }

        private bool datetime_changed()
        {
            if (m_dat_ngay_ket_thuc.EditValue != null)
            {
                if (!(m_dat_ngay_bat_dau.DateTime.Date < m_dat_ngay_ket_thuc.DateTime.Date))
                {
                    string v_str_error = "Ngày kết thúc phải lớn hơn ngày bắt đầu. \nVui lòng kiểm tra lại!!";
                    XtraMessageBox.Show(v_str_error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            if (m_dat_ngay_bat_dau_cu.EditValue == null
                && m_dat_ngay_ket_thuc_cu.EditValue == null)
            {
                if (m_dat_ngay_ket_thuc.EditValue == null)
                {
                    return true;
                }
            }
            if (!(m_dat_ngay_bat_dau_cu.DateTime.Date < m_dat_ngay_ket_thuc_cu.DateTime.Date))
            {
                string v_str_error = "Ngày kết thúc LNS cũ phải lớn hơn ngày bắt đầu LNS cũ. \nVui lòng kiểm tra lại!!";
                XtraMessageBox.Show(v_str_error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (m_dat_ngay_ket_thuc_cu.DateTime.Date > m_dat_ngay_bat_dau.DateTime.Date)
            {
                string v_str_error = "Ngày kết thúc lương năng suất cũ đang lớn hơn ngày bắt đầu lương năng suất mới. \nVui lòng kiểm tra lại!!";
                XtraMessageBox.Show(v_str_error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        //EVENTS

        private void set_define_events()
        {
            Load += F299_chinh_lns_nhan_vien_de_Load;
            m_cmd_luu.Click += M_cmd_luu_Click;
            m_sle_chuc_danh_lns.EditValueChanged += M_sle_chuc_danh_lns_EditValueChanged;
            m_sle_muc_lns.EditValueChanged += M_sle_muc_lns_EditValueChanged;
            //m_dat_ngay_bat_dau.EditValueChanged += M_dat_ngay_bat_dau_EditValueChanged;
            //m_dat_ngay_ket_thuc.EditValueChanged += M_dat_ngay_ket_thuc_EditValueChanged;
            //m_dat_ngay_ket_thuc_cu.EditValueChanged += M_dat_ngay_ket_thuc_cu_EditValueChanged;
        }

        private void M_dat_ngay_ket_thuc_cu_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                datetime_changed();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void M_dat_ngay_ket_thuc_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                datetime_changed();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void M_dat_ngay_bat_dau_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                datetime_changed();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void M_sle_muc_lns_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                m_txt_hs_lns.Text = find_hs_lns();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void M_sle_chuc_danh_lns_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                m_txt_hs_lns.Text = find_hs_lns();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void M_cmd_luu_Click(object sender, EventArgs e)
        {
            try
            {
                if (check_data_is_ok())
                {
                    save_data();
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void F299_chinh_lns_nhan_vien_de_Load(object sender, EventArgs e)
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
    }
}
