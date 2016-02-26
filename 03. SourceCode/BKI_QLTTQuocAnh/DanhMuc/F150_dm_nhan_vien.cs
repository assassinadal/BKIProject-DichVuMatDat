using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using BKI_DichVuMatDat;
using BKI_DichVuMatDat.US;
using BKI_DichVuMatDat.DS;
using BKI_DichVuMatDat.DS.CDBNames;
using IP.Core.IPCommon;

using DevExpress.XtraEditors;
using System.Globalization;
using BKI_DichVuMatDat.COMMON;

namespace BKI_DichVuMatDat.DanhMuc
{
    public partial class F150_dm_nhan_vien : Form
    {
        public F150_dm_nhan_vien()
        {
            InitializeComponent();
            format_controls();
        }

        #region Pulic Interface

        #endregion

        #region Members
        decimal m_member_is_newbie = 0; //1 la nhan vien moi
        #endregion

        #region Private Methods

        private void format_controls()
        {
            FormatControl.SetVisibleSimpleButton(this);
            set_define_events();
            this.KeyPreview = true;
        }

        private void set_initial_form_load()
        {
            load_data_to_sle_chon_nhan_vien();
            tinh_tuoi_nhan_vien();
            set_gioi_tinh_default();
        }

        private DataSet load_data_2_ds_v_dm_nv()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();

            v_ds.Tables.Add(new DataTable());
            throw new Exception("Sua lai khong dung FillDataSetWithTableName nua nhe");
            //v_us.FillDatasetWithTableName(v_ds, "V_DM_NHAN_VIEN");
            return v_ds;
        }

        private void load_data_to_sle_chon_nhan_vien()
        {
            m_sle_chon_nhan_vien.Properties.DataSource = load_data_2_ds_v_dm_nv().Tables[0];

            m_sle_chon_nhan_vien.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            m_sle_chon_nhan_vien.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
        }

        //---------------------------------------------******----------------------------------------------------//
        /****Li lich nhan vien****/
        /*****/
        /****/
        /***/
        /**/

        private decimal find_id_gd_ct(decimal ip_dc_id_nv)
        {
            US_V_GD_CONG_TAC v_us = new US_V_GD_CONG_TAC();
            DS_V_GD_CONG_TAC v_ds = new DS_V_GD_CONG_TAC();
            v_ds.EnforceConstraints = false;
            v_us.FillDataset(v_ds);
            string v_str_filter = "ID_NHAN_VIEN = " + ip_dc_id_nv + " AND ID_LOAI_CONG_TAC = " + CONST_ID_LOAI_CONG_TAC.CHINH_THUC;

            DataRow[] v_dr = v_ds.V_GD_CONG_TAC.Select(v_str_filter);

            if (v_dr.Count() == 0)
            {
                return -1;
            }
            else
            {
                return CIPConvert.ToDecimal(v_dr.First()["ID"].ToString());
            }
        }

        private void load_data_2_grc_thong_tin_tra_cuu(US_DM_NHAN_VIEN v_us_nv)
        {
            m_txt_ma_nv.Text = v_us_nv.strMA_NV;

            decimal v_id_gd_ct = find_id_gd_ct(v_us_nv.dcID);

            if (v_id_gd_ct != -1)
            {
                US_V_GD_CONG_TAC v_us_ct = new US_V_GD_CONG_TAC(v_id_gd_ct);
                m_lbl_vi_tri.Text = v_us_ct.strTEN_VI_TRI;
                m_lbl_don_vi.Text = v_us_ct.strTEN_DON_VI;
            }
            else
            {
                m_lbl_vi_tri.Text = "Chưa có";
                m_lbl_don_vi.Text = "Chưa có";
            }
        }

        private void load_data_2_radio_button_gioi_tinh(US_DM_NHAN_VIEN v_us_nv)
        {
            if (v_us_nv.strGIOI_TINH == "NULL" || v_us_nv.strGIOI_TINH == "")
            {
                m_rdb_gioi_tinh_nam.Checked = false;
                m_rdb_gioi_tinh_nu.Checked = false;
            }
            else if (v_us_nv.strGIOI_TINH == "Y")
            {
                m_rdb_gioi_tinh_nam.Checked = true;
                m_rdb_gioi_tinh_nu.Checked = false;
            }
            else
            {
                m_rdb_gioi_tinh_nam.Checked = false;
                m_rdb_gioi_tinh_nu.Checked = true;
            }
        }

        private void tinh_tuoi_nhan_vien()
        {
            decimal v_so_tuoi = CIPConvert.ToDecimal(DateTime.Now.Year - m_dat_ngay_sinh.Value.Year);
            m_txt_tuoi.Text = v_so_tuoi.ToString();
        }

        private void load_data_2_grc_thong_tin_co_ban(US_DM_NHAN_VIEN v_us_nv)
        {
            m_txt_ho_dem.Text = v_us_nv.strHO_DEM;
            m_txt_ten.Text = v_us_nv.strTEN;
            m_dat_ngay_sinh.Value = v_us_nv.datNGAY_SINH;
            tinh_tuoi_nhan_vien();
            load_data_2_radio_button_gioi_tinh(v_us_nv);

            m_txt_hon_nhan.Text = v_us_nv.strHON_NHAN;
            m_txt_quoc_tich.Text = v_us_nv.strQUOC_TICH;
            m_txt_dan_toc.Text = v_us_nv.strDAN_TOC;
            m_txt_ton_giao.Text = v_us_nv.strTON_GIAO;
            m_txt_so_cmnd.Text = v_us_nv.strSO_CMT;
            //m_dat_ngay_cap.Value = v_us_nv.datNGAY_CAP;
            m_txt_so_tai_khoan.Text = v_us_nv.strSO_TAI_KHOAN;
            m_txt_ngan_hang.Text = v_us_nv.strNGAN_HANG;
            //m_dat_ngay_cap_the.Value = v_us_nv.datNGAY_CAP_THE;
            //m_dat_ngay_het_han_the.Value = v_us_nv.datNGAY_HET_HAN_THE;
            m_txt_ma_so_thue_ca_nhan.Text = v_us_nv.strMA_SO_THUE_CA_NHAN;
        }

        private void load_data_2_grc_thong_tin_lien_he(US_DM_NHAN_VIEN v_us_nv)
        {
            m_txt_noi_sinh.Text = v_us_nv.strNOI_SINH;
            m_txt_que_quan.Text = v_us_nv.strQUE_QUAN;
            m_txt_dc_thuong_tru.Text = v_us_nv.strDIA_CHI_THUONG_TRU;
            m_txt_dc_tam_tru.Text = v_us_nv.strDIA_CHI_TAM_TRU;
            m_txt_dc_lien_lac.Text = v_us_nv.strDIA_CHI_LIEN_LAC;
            m_txt_email.Text = v_us_nv.strEMAIL;
            m_txt_so_dien_thoai.Text = v_us_nv.strSDT;
        }

        private void load_data_2_grc_thong_tin_cong_tac(US_DM_NHAN_VIEN v_us_nv)
        {
            m_txt_chuyen_mon.Text = v_us_nv.strCHUYEN_MON;
            m_txt_trinh_do.Text = v_us_nv.strTRINH_DO_VAN_HOA;
            m_txt_nam_tot_nghiep.Text = v_us_nv.strNAM_TOT_NGHIEP;
            m_txt_tot_nghiep_tai.Text = v_us_nv.strTOT_NGHIEP_TAI;
            //m_dat_ngay_vao_hang_khong.Value = v_us_nv.datNGAY_VAO_HANG_KHONG;
            //m_dat_ngay_tiep_nhan_vao_tct.Value = v_us_nv.datNGAY_TIEP_NHAN_VAO_TCT;
            //m_dat_ngay_chinh_thuc_tiep_nhan.Value = v_us_nv.datNGAY_CHINH_THUC_TIEP_NHAN;
        }

        private void load_data_to_all_controls(decimal ip_dc_id_nv)
        {
            US_DM_NHAN_VIEN v_us_nv = new US_DM_NHAN_VIEN(ip_dc_id_nv);
            //m_sle_chon_nhan_vien.EditValue = v_us_nv.dcID;
            load_data_2_grc_thong_tin_tra_cuu(v_us_nv);
            load_data_2_grc_thong_tin_co_ban(v_us_nv);
            load_data_2_grc_thong_tin_lien_he(v_us_nv);
            load_data_2_grc_thong_tin_cong_tac(v_us_nv);
        }

        private void change_form_2_insert_newbie()
        {
            this.Refresh();
            set_gioi_tinh_default();
            change_visible_of_control(false);
            Refesh_controls_in_form();

        }

        private void set_gioi_tinh_default()
        {
            m_rdb_gioi_tinh_nam.Checked = true;
            m_rdb_gioi_tinh_nu.Checked = false;
        }

        private void change_visible_of_control(bool ip_bool)
        {
            m_lbl_ho_ten_nv.Visible = ip_bool;
            m_sle_chon_nhan_vien.Visible = ip_bool;
            label1.Visible = ip_bool;
            m_lbl_ngay_bat_dau.Visible = ip_bool;
            label2.Visible = ip_bool;
            m_lbl_don_vi.Visible = ip_bool;
            label3.Visible = ip_bool;
            m_lbl_vi_tri.Visible = ip_bool;
            label4.Visible = ip_bool;
            m_lbl_ngay_het_hd.Visible = ip_bool;
        }

        private void Refesh_controls_in_form()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else if (control is DateTimePicker)
                        (control as DateTimePicker).Value = DateTime.Now.Date;
                    else
                        func(control.Controls);
            };

            func(Controls);
        }

        private void grc_thong_tin_co_ban_2_us(US_DM_NHAN_VIEN v_us_nv)
        {
            v_us_nv.strMA_NV = m_txt_ma_nv.Text.Trim();
            v_us_nv.strHO_DEM = m_txt_ho_dem.Text.Trim();
            v_us_nv.strTEN = m_txt_ten.Text.Trim();
            v_us_nv.datNGAY_SINH = m_dat_ngay_sinh.Value.Date;
            if (m_rdb_gioi_tinh_nam.Checked == true)
            {
                v_us_nv.strGIOI_TINH = "Y";
            }
            if (m_rdb_gioi_tinh_nu.Checked == true)
            {
                v_us_nv.strGIOI_TINH = "N";
            }
            v_us_nv.strHON_NHAN = m_txt_hon_nhan.Text.Trim();
            v_us_nv.strQUOC_TICH = m_txt_quoc_tich.Text.Trim();
            v_us_nv.strDAN_TOC = m_txt_dan_toc.Text.Trim();
            v_us_nv.strTON_GIAO = m_txt_ton_giao.Text.Trim();
            v_us_nv.strSO_CMT = m_txt_so_cmnd.Text.Trim();
            v_us_nv.datNGAY_CAP = m_dat_ngay_cap.Value.Date;
            v_us_nv.strSO_TAI_KHOAN = m_txt_so_tai_khoan.Text.Trim();
            v_us_nv.strNGAN_HANG = m_txt_ngan_hang.Text.Trim();
            v_us_nv.datNGAY_CAP_THE = m_dat_ngay_cap_the.Value.Date;
            v_us_nv.datNGAY_HET_HAN_THE = m_dat_ngay_het_han_the.Value.Date;
            v_us_nv.strMA_SO_THUE_CA_NHAN = m_txt_ma_so_thue_ca_nhan.Text.Trim();
        }

        private void grc_thong_tin_lien_he_2_us(US_DM_NHAN_VIEN v_us_nv)
        {
            v_us_nv.strNOI_SINH = m_txt_noi_sinh.Text.Trim();
            v_us_nv.strQUE_QUAN = m_txt_que_quan.Text.Trim();
            v_us_nv.strDIA_CHI_THUONG_TRU = m_txt_dc_thuong_tru.Text.Trim();
            v_us_nv.strDIA_CHI_TAM_TRU = m_txt_dc_tam_tru.Text.Trim();
            v_us_nv.strDIA_CHI_LIEN_LAC = m_txt_dc_lien_lac.Text.Trim();
            v_us_nv.strEMAIL = m_txt_email.Text.Trim();
            v_us_nv.strSDT = m_txt_so_dien_thoai.Text.Trim();
        }

        private void grc_thong_tin_cong_tac_2_us(US_DM_NHAN_VIEN v_us_nv)
        {
            v_us_nv.strCHUYEN_MON = m_txt_chuyen_mon.Text.Trim();
            v_us_nv.strTRINH_DO_VAN_HOA = m_txt_trinh_do.Text.Trim();
            v_us_nv.strNAM_TOT_NGHIEP = m_txt_nam_tot_nghiep.Text.Trim();
            v_us_nv.strTOT_NGHIEP_TAI = m_txt_tot_nghiep_tai.Text.Trim();
            v_us_nv.datNGAY_VAO_HANG_KHONG = m_dat_ngay_vao_hang_khong.Value.Date;
            v_us_nv.datNGAY_TIEP_NHAN_VAO_TCT = m_dat_ngay_tiep_nhan_vao_tct.Value.Date;
            v_us_nv.datNGAY_CHINH_THUC_TIEP_NHAN = m_dat_ngay_chinh_thuc_tiep_nhan.Value.Date;
        }

        private void form_2_us_dm_nv(US_DM_NHAN_VIEN v_us_nv)
        {
            grc_thong_tin_co_ban_2_us(v_us_nv);
            grc_thong_tin_lien_he_2_us(v_us_nv);
            grc_thong_tin_cong_tac_2_us(v_us_nv);
        }

        private bool check_data_is_ok()
        {
            if (m_txt_ma_nv.Text == "")
            {
                CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_CHUA_NHAP_MA_NHAN_VIEN);
                return false;
            }
            if (m_txt_ho_dem.Text == "")
            {
                CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_CHUA_NHAP_HO_DEM_NHAN_VIEN);
                return false;
            }
            if (m_txt_ten.Text == "")
            {
                CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_CHUA_NHAP_TEN_NHAN_VIEN);
                return false;
            }
            return true;
        }

        #endregion
        private void set_define_events()
        {
            this.Load += F150_dm_nhan_vien_Load;
            //li lich nhan vien
            m_cmd_them_nhan_vien.Click += m_cmd_them_nhan_vien_Click;
            m_dat_ngay_sinh.ValueChanged += m_dat_ngay_sinh_ValueChanged;
            m_cmd_insert.Click += m_cmd_insert_Click;
            m_cmd_tra_cuu.Click += m_cmd_tra_cuu_Click;
        }

        void m_cmd_tra_cuu_Click(object sender, EventArgs e)
        {
            try
            {
                change_visible_of_control(true);
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
                if (check_data_is_ok() == false) return;

                if (CHRM_BaseMessages.MsgBox_Confirm(CONST_ID_MSGBOX.QUESTION_XAC_NHAN_LUU_DU_LIEU) == false) return;

                if (check_ma_nv_da_ton_tai(m_txt_ma_nv.Text) == true)
                {
                    US_DM_NHAN_VIEN v_us_nv_4_insert = new US_DM_NHAN_VIEN();
                    form_2_us_dm_nv(v_us_nv_4_insert);

                    //insert
                    try
                    {
                        v_us_nv_4_insert.BeginTransaction();
                        v_us_nv_4_insert.Insert();
                        v_us_nv_4_insert.CommitTransaction();
                        m_member_is_newbie = 0;
                    }
                    catch (Exception v_e)
                    {
                        v_us_nv_4_insert.Rollback();
                        throw v_e;
                    }
                    //cho cac control visible false -> true
                    change_visible_of_control(true);
                    //load_data_2_sle_chon_nv
                    load_data_to_all_controls(v_us_nv_4_insert.dcID);
                    load_data_2_ds_v_dm_nv();
                    m_sle_chon_nhan_vien.EditValue = v_us_nv_4_insert.dcID;

                    CHRM_BaseMessages.MsgBox_Infor(CONST_ID_MSGBOX.INFOR_LUU_DU_LIEU_THANH_CONG);
                }
                else
                {
                    if (m_member_is_newbie == 1)
                    {
                        US_DM_NHAN_VIEN v_us_nv_4_insert = new US_DM_NHAN_VIEN();
                        form_2_us_dm_nv(v_us_nv_4_insert);

                        //insert
                        try
                        {
                            v_us_nv_4_insert.BeginTransaction();
                            v_us_nv_4_insert.Insert();
                            v_us_nv_4_insert.CommitTransaction();
                            m_member_is_newbie = 0;
                        }
                        catch (Exception v_e)
                        {
                            v_us_nv_4_insert.Rollback();
                            throw v_e;
                        }
                        //cho cac control visible false -> true
                        change_visible_of_control(true);
                        //load_data_2_sle_chon_nv                          
                        load_data_to_all_controls(v_us_nv_4_insert.dcID);
                        load_data_2_ds_v_dm_nv();
                        m_sle_chon_nhan_vien.EditValue = v_us_nv_4_insert.dcID;

                        CHRM_BaseMessages.MsgBox_Infor(CONST_ID_MSGBOX.INFOR_LUU_DU_LIEU_THANH_CONG);
                    }
                    else
                    {
                        //update
                        US_DM_NHAN_VIEN v_us_nv_4_update = new US_DM_NHAN_VIEN(CIPConvert.ToDecimal(m_sle_chon_nhan_vien.EditValue));
                        form_2_us_dm_nv(v_us_nv_4_update);
                        v_us_nv_4_update.Update();
                        CHRM_BaseMessages.MsgBox_Infor(CONST_ID_MSGBOX.INFOR_DU_LIEU_DA_DUOC_CAP_NHAT);
                    }
                }
                change_visible_of_control(true);
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private bool check_ma_nv_da_ton_tai(string ip_ma_nv)
        {
            //DataSet v_ds = new DataSet();
            //DataTable v_dt = new DataTable();
            //US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            //v_ds.Tables.Add(v_dt);
            //v_us.FillDatasetWithQuery(v_ds, "SELECT * FROM DM_NHAN_VIEN WHERE MA_NV = '" + ip_ma_nv + "'");
            ExecuteFuntion.KiemTraNhanVienCoTrongCsdlChua(ip_ma_nv);
            if(ExecuteFuntion.KiemTraNhanVienCoTrongCsdlChua(ip_ma_nv))
            {
                return true;
            }
            else return false;
        }

        void m_dat_ngay_sinh_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                tinh_tuoi_nhan_vien();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_them_nhan_vien_Click(object sender, EventArgs e)
        {
            try
            {
                change_form_2_insert_newbie();
                m_member_is_newbie = 1;
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void F150_dm_nhan_vien_Load(object sender, EventArgs e)
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

        private void m_sle_chon_nhan_vien_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (m_sle_chon_nhan_vien.EditValue == null || m_sle_chon_nhan_vien.EditValue == "")
                {
                    return;
                }
                else
                {
                    load_data_to_all_controls(CIPConvert.ToDecimal(m_sle_chon_nhan_vien.EditValue));
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

    }
}
