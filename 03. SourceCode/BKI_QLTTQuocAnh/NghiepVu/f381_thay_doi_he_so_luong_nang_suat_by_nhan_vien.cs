﻿using System;
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

namespace BKI_DichVuMatDat.NghiepVu
{
    public partial class f381_thay_doi_he_so_luong_nang_suat_by_nhan_vien : Form
    {
        public f381_thay_doi_he_so_luong_nang_suat_by_nhan_vien()
        {
            InitializeComponent();
            format_controls();
        }

        #region public interface
        public void display()
        {
            this.ShowDialog();
        }
        #endregion

        #region Members

        #endregion

        #region Private methods
        private void format_controls()
        {
            set_define_events();
            this.KeyPreview = true;
        }

        private void set_initial_form_load()
        {
            load_data_2_sle_chon_nv();
            m_txt_chon_thang.Text = DateTime.Now.Month.ToString();
            m_txt_chon_nam.Text = DateTime.Now.Year.ToString();
        }

        private DS_V_DM_NHAN_VIEN load_data_2_ds_v_dm_nv()
        {
            DS_V_DM_NHAN_VIEN v_ds = new DS_V_DM_NHAN_VIEN();
            US_V_DM_NHAN_VIEN v_us = new US_V_DM_NHAN_VIEN();

            v_us.FillDataset(v_ds);
            return v_ds;
        }

        //load data 2 all control
        private void load_data_2_sle_chon_nv()
        {
            m_sle_chon_nhan_vien.Properties.DataSource = load_data_2_ds_v_dm_nv().V_DM_NHAN_VIEN;
            m_sle_chon_nhan_vien.Properties.ValueMember = V_DM_NHAN_VIEN.ID;
            m_sle_chon_nhan_vien.Properties.DisplayMember = V_DM_NHAN_VIEN.HO_TEN;

            m_sle_chon_nhan_vien.Properties.PopulateViewColumns();
            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.ID].Visible = false;
            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.HO_DEM].Visible = false;
            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.TEN].Visible = false;
            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.DAN_TOC].Visible = false;
            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.CHUYEN_MON].Visible = false;
            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.DIA_CHI_TAM_TRU].Visible = false;
            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.DIA_CHI_THUONG_TRU].Visible = false;
            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.MA_SO_THUE_CA_NHAN].Visible = false;
            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.NAM_TOT_NGHIEP].Visible = false;
            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.NGAN_HANG].Visible = false;
            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.NGAY_CAP].Visible = false;
            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.NGAY_CAP_THE].Visible = false;
            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.NGAY_CHINH_THUC_TIEP_NHAN].Visible = false;
            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.NGAY_HET_HAN_THE].Visible = false;
            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.NGAY_TIEP_NHAN_VAO_TCT].Visible = false;
            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.NGAY_VAO_HANG_KHONG].Visible = false;
            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.NOI_CAP].Visible = false;
            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.NOI_SINH].Visible = false;
            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.QUE_QUAN].Visible = false;
            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.QUOC_TICH].Visible = false;
            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.SO_CMT].Visible = false;
            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.SO_TAI_KHOAN].Visible = false;
            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.TON_GIAO].Visible = false;
            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.TOT_NGHIEP_TAI].Visible = false;
            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.TRINH_DO_VAN_HOA].Visible = false;
            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.NGAY_SINH].Visible = false;
            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.HON_NHAN].Visible = false;

            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.MA_NV].Width = 75;
            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.HO_TEN].Width = 120;

            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.MA_NV].Caption = "Mã NV";
            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.HO_TEN].Caption = "Họ tên";
            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.GIOI_TINH].Caption = "Giới tính";
            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.SDT].Caption = "SĐT";
            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.EMAIL].Caption = "Email";
            m_sle_chon_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.DIA_CHI_LIEN_LAC].Caption = "Địa chị liên lạc";

            m_sle_chon_nhan_vien.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            m_sle_chon_nhan_vien.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
        }

        private void load_data_2_grid(decimal ip_dc_id_nv, decimal ip_dc_thang, decimal ip_dc_nam)
        {
            CCommon.make_stt(m_grv_hs_chat_luong);
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());

            v_us.FillDatasetWithQuery(v_ds,"SELECT * FROM V_GD_HE_SO_CHAT_LUONG WHERE ID_NHAN_VIEN = " + ip_dc_id_nv + " AND THANG = " + ip_dc_thang + " AND NAM = " + ip_dc_nam);
            m_grc_hs_chat_luong.DataSource = v_ds.Tables[0];
        }

        private void load_data_2_grid(decimal ip_dc_thang, decimal ip_dc_nam)
        {
            CCommon.make_stt(m_grv_hs_chat_luong);
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());

            v_us.FillDatasetWithQuery(v_ds, "SELECT * FROM V_GD_HE_SO_CHAT_LUONG WHERE THANG = " + ip_dc_thang + " AND NAM = " + ip_dc_nam);
            m_grc_hs_chat_luong.DataSource = v_ds.Tables[0];
        }

        private decimal find_hs_chat_luong_by_nv_thang_nam(decimal ip_dc_id_nv, decimal ip_dc_thang, decimal ip_dc_nam)
        {
            US_GD_HE_SO_CHAT_LUONG v_us = new US_GD_HE_SO_CHAT_LUONG();
            DS_GD_HE_SO_CHAT_LUONG v_ds = new DS_GD_HE_SO_CHAT_LUONG();

            v_us.FillDataset(v_ds);

            string v_str_filter = "ID_NHAN_VIEN = " + ip_dc_id_nv + " AND THANG = " + ip_dc_thang + " AND NAM = " + ip_dc_nam;
            DataRow[] v_dr = v_ds.GD_HE_SO_CHAT_LUONG.Select(v_str_filter);

            if (v_dr.Count() == 0)
            {
                return 0;
            }
            else
            {
                return CIPConvert.ToDecimal(v_dr.First()["HE_SO_K"].ToString());
            }
        }

        private decimal find_id_gd_hs_chat_luong(decimal ip_dc_id_nv, decimal ip_dc_thang, decimal ip_dc_nam)
        {
            US_GD_HE_SO_CHAT_LUONG v_us = new US_GD_HE_SO_CHAT_LUONG();
            DS_GD_HE_SO_CHAT_LUONG v_ds = new DS_GD_HE_SO_CHAT_LUONG();

            v_us.FillDataset(v_ds);

            string v_str_filter = "ID_NHAN_VIEN = " + ip_dc_id_nv + " AND THANG = " + ip_dc_thang + " AND NAM = " + ip_dc_nam;
            DataRow[] v_dr = v_ds.GD_HE_SO_CHAT_LUONG.Select(v_str_filter);

            if (v_dr.Count() == 0)
            {
                return 0;
            }
            else
            {
                return CIPConvert.ToDecimal(v_dr.First()["ID"].ToString());
            }
        }

        private bool check_data_is_ok()
        {
            if (m_sle_chon_nhan_vien.EditValue == null || m_sle_chon_nhan_vien.EditValue == "")
            {
                XtraMessageBox.Show("Bạn chưa chọn nhân viên!");
                return false;
            }

            if (m_txt_chon_thang.Text == "")
            {
                XtraMessageBox.Show("Bạn chưa chọn tháng!");
                return false;
            }

            if (m_txt_chon_nam.Text == "")
            {
                XtraMessageBox.Show("Bạn chưa chọn năm!");
                return false;
            }
            return true;
        }

        private void form_2_us_gd_hs_cl(US_GD_HE_SO_CHAT_LUONG ip_us)
        {
            decimal v_id_gd_hs_cl = 0;
            v_id_gd_hs_cl = find_id_gd_hs_chat_luong(CIPConvert.ToDecimal(m_sle_chon_nhan_vien.EditValue), CIPConvert.ToDecimal(m_txt_chon_thang.Text.Trim()), CIPConvert.ToDecimal(m_txt_chon_nam.Text.Trim()));
            ip_us.dcID_NHAN_VIEN = CIPConvert.ToDecimal(m_sle_chon_nhan_vien.EditValue);
            ip_us.dcTHANG = CIPConvert.ToDecimal(m_txt_chon_thang.Text.Trim());
            ip_us.dcNAM = CIPConvert.ToDecimal(m_txt_chon_nam.Text.Trim());
            ip_us.dcHE_SO_K = CIPConvert.ToDecimal(m_txt_hs.Text.Trim());
            if (v_id_gd_hs_cl > 0)
            {
                ip_us.dcID = v_id_gd_hs_cl;
                ip_us.datNGAY_SUA = DateTime.Now.Date;
                //nguoi sua
            }
            else
            {
                ip_us.datNGAY_LAP = DateTime.Now.Date;
                //nguoi lap
                ip_us.strDA_XOA = "N";
            }

        }

        private void save_data()
        {
            US_GD_HE_SO_CHAT_LUONG v_us_gd_hs_cl = new US_GD_HE_SO_CHAT_LUONG();
            form_2_us_gd_hs_cl(v_us_gd_hs_cl);
            try
            {
                if (v_us_gd_hs_cl.dcID > 0)
                {
                    US_GD_HE_SO_CHAT_LUONG v_us = new US_GD_HE_SO_CHAT_LUONG(v_us_gd_hs_cl.dcID);
                    v_us.dcHE_SO_K = CIPConvert.ToDecimal(m_txt_hs.Text.Trim());
                    v_us.datNGAY_SUA = DateTime.Now.Date;
                    //nguoi sua
                    v_us.BeginTransaction();
                    v_us.Update();
                    v_us.CommitTransaction();
                }
                else
                {
                    v_us_gd_hs_cl.BeginTransaction();
                    v_us_gd_hs_cl.Update();
                    v_us_gd_hs_cl.CommitTransaction();
                }
            }
            catch (Exception v_e)
            {
                throw v_e;
            }
        }

        #endregion
        private void set_define_events()
        {
            this.Load += f381_thay_doi_he_so_luong_nang_suat_by_nhan_vien_Load;
            m_cmd_search.Click += m_cmd_search_Click;
            m_cmd_luu_hs.Click += m_cmd_luu_hs_Click;
            m_grv_hs_chat_luong.DoubleClick += m_grv_hs_chat_luong_DoubleClick;
        }

        void f381_thay_doi_he_so_luong_nang_suat_by_nhan_vien_Load(object sender, EventArgs e)
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

        void m_cmd_search_Click(object sender, EventArgs e)
        {
            try
            {
                if (m_sle_chon_nhan_vien.EditValue == null || m_sle_chon_nhan_vien.EditValue == "")
                {
                    load_data_2_grid(CIPConvert.ToDecimal(m_txt_chon_thang.Text.Trim()), CIPConvert.ToDecimal(m_txt_chon_nam.Text.Trim()));
                }
                else
                {
                    load_data_2_grid(CIPConvert.ToDecimal(m_sle_chon_nhan_vien.EditValue), CIPConvert.ToDecimal(m_txt_chon_thang.Text.Trim()), CIPConvert.ToDecimal(m_txt_chon_nam.Text.Trim()));
                    m_txt_hs.Text = find_hs_chat_luong_by_nv_thang_nam(CIPConvert.ToDecimal(m_sle_chon_nhan_vien.EditValue), CIPConvert.ToDecimal(m_txt_chon_thang.Text.Trim()), CIPConvert.ToDecimal(m_txt_chon_nam.Text.Trim())).ToString();
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_luu_hs_Click(object sender, EventArgs e)
        {
            try
            {
                if (check_data_is_ok())
                {
                    if (XtraMessageBox.Show("Bạn chắc chắn muốn lưu hệ số chất lượng cho nhân viên này?","XÁC NHẬN LẠI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        save_data();
                        load_data_2_grid(CIPConvert.ToDecimal(m_sle_chon_nhan_vien.EditValue), CIPConvert.ToDecimal(m_txt_chon_thang.Text.Trim()), CIPConvert.ToDecimal(m_txt_chon_nam.Text.Trim()));
                        m_txt_hs.Text = find_hs_chat_luong_by_nv_thang_nam(CIPConvert.ToDecimal(m_sle_chon_nhan_vien.EditValue), CIPConvert.ToDecimal(m_txt_chon_thang.Text.Trim()), CIPConvert.ToDecimal(m_txt_chon_nam.Text.Trim())).ToString();
                    }
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_grv_hs_chat_luong_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                m_sle_chon_nhan_vien.EditValue = CIPConvert.ToDecimal(m_grv_hs_chat_luong.GetRowCellValue(m_grv_hs_chat_luong.FocusedRowHandle,"ID_NHAN_VIEN"));
                m_txt_chon_thang.Text = m_grv_hs_chat_luong.GetRowCellValue(m_grv_hs_chat_luong.FocusedRowHandle, "THANG").ToString();
                m_txt_chon_nam.Text = m_grv_hs_chat_luong.GetRowCellValue(m_grv_hs_chat_luong.FocusedRowHandle, "NAM").ToString();
                m_txt_hs.Text = m_grv_hs_chat_luong.GetRowCellValue(m_grv_hs_chat_luong.FocusedRowHandle, "HE_SO_K").ToString();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

    }
}
