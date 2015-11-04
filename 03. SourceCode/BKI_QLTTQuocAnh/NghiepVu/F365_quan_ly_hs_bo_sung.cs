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

namespace BKI_DichVuMatDat.NghiepVu
{
    public partial class F365_quan_ly_hs_bo_sung : Form
    {


        #region Public Interface
        public F365_quan_ly_hs_bo_sung()
        {
            InitializeComponent();
            format_controls();
        }
        ~F365_quan_ly_hs_bo_sung()
        {
            Dispose(false);
        }
        #endregion

        #region Members
        US_GD_HS_BO_SUNG_AN_TOAN_HANG_KHONG m_us_hs_bs_athk = new US_GD_HS_BO_SUNG_AN_TOAN_HANG_KHONG();
        #endregion

        #region Private methods
        private void format_controls()
        {
            FormatControl.SetVisibleSimpleButton(this);
            this.m_grv_quan_ly_he_so_bo_sung.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(WinFormControls.m_grv_PopupMenuShowing);
            this.m_grv_quan_ly_he_so_bo_sung.OptionsPrint.AutoWidth = false;
            set_define_events();
            this.KeyPreview = true;
        }

        private void set_initial_form_load()
        {
            m_txt_chon_nam.EditValue = DateTime.Now.Year.ToString();
        }

        //GD_QUY_TIEN_THUONG
        private void xoa_quy_tien_hs_bs_trong_nam()
        {
            decimal v_is_gd_quy_tien_thuong = 0;
            v_is_gd_quy_tien_thuong = find_id_gd_quy_tien_thuong(CIPConvert.ToDecimal(m_txt_chon_nam.Text.Trim()), CONST_ID_TIEN_THUONG.THUONG_HS_BS);
            US_GD_QUY_TIEN_THUONG v_us = new US_GD_QUY_TIEN_THUONG(v_is_gd_quy_tien_thuong);

            try
            {
                v_us.strDA_XOA = "Y";
                v_us.Update();
            }
            catch (Exception v_e)
            {
                throw v_e;
            }
        }

        private decimal find_id_gd_quy_tien_thuong(decimal ip_dc_nam, decimal ip_dc_loai_quy_tien)
        {
            try
            {
                US_GD_QUY_TIEN_THUONG v_us = new US_GD_QUY_TIEN_THUONG();
                DS_GD_QUY_TIEN_THUONG v_ds = new DS_GD_QUY_TIEN_THUONG();

                v_us.FillDataset(v_ds);

                string v_str_filter = "NAM = " + ip_dc_nam + " AND ID_MUC_LNS = " + ip_dc_loai_quy_tien;
                DataRow[] v_dr = v_ds.GD_QUY_TIEN_THUONG.Select(v_str_filter);

                if (v_dr.Count() == 0)
                {
                    return 0;
                }
                else
                {
                    return CIPConvert.ToDecimal(v_dr.First()["ID"].ToString());
                }
            }
            catch (Exception v_e)
            {
                throw v_e;
            }
        }

        private void luu_so_tien_vao_quy_tien()
        {
            US_GD_QUY_TIEN_THUONG v_us_quy_tien_thuong = new US_GD_QUY_TIEN_THUONG();
            //xoa_quy_tien_hs_bs_trong_nam();
            try
            {
                v_us_quy_tien_thuong.dcSO_TIEN = CIPConvert.ToDecimal(m_txt_so_tien.EditValue);
                //v_us_quy_tien_thuong.strTHANG = 
                v_us_quy_tien_thuong.strNAM = m_txt_chon_nam.Text.ToString();
                //v_us_quy_tien_thuong.strNGUOI_LAP=
                v_us_quy_tien_thuong.dcID_LOAI_QUY_TIEN = CONST_ID_TIEN_THUONG.THUONG_HS_BS;
                v_us_quy_tien_thuong.strDA_XOA = "N";
                v_us_quy_tien_thuong.Insert();
            }
            catch (Exception v_e)
            {
                throw v_e;
            }
        }

        //GD_THANG_DA_GIAM_TRU
        private void luu_thang_da_giam_tru()
        {
            US_GD_THANG_DA_GIAM_TRU v_us_thang_da_giam_tru = new US_GD_THANG_DA_GIAM_TRU();
            try
            {
                v_us_thang_da_giam_tru.strTHANG = DateTime.Now.Month.ToString();
                v_us_thang_da_giam_tru.strNAM = m_txt_chon_nam.Text.ToString();
                v_us_thang_da_giam_tru.strGIAM_TRU_YN = "Y";
                //v_us_thang_da_giam_tru.strNGUOI_LAP=
                v_us_thang_da_giam_tru.datNGAY_LAP = DateTime.Now.Date;
                v_us_thang_da_giam_tru.strDA_XOA = "N";
                v_us_thang_da_giam_tru.Insert();
            }
            catch (Exception v_e)
            {
                throw v_e;
            }
        }

        //GD_THU_NHAP_KHAC
        private void luu_so_tien_vao_gd_thu_nhap_khac(DataSet ip_ds)
        {
            for (int i = 0; i < ip_ds.Tables[0].Rows.Count; i++)
            {
                US_GD_THU_NHAP_KHAC v_us_thu_khac = new US_GD_THU_NHAP_KHAC();
                v_us_thu_khac.dcID_NHAN_VIEN = CIPConvert.ToDecimal(ip_ds.Tables[0].Rows[i]["ID_NHAN_VIEN"]);
                v_us_thu_khac.dcSO_TIEN = CIPConvert.ToDecimal(ip_ds.Tables[0].Rows[i]["SO_TIEN"]);
                v_us_thu_khac.dcTHANG = CIPConvert.ToDecimal(DateTime.Now.Month.ToString());
                v_us_thu_khac.dcNAM = CIPConvert.ToDecimal(ip_ds.Tables[0].Rows[i]["NAM"]);
                v_us_thu_khac.strLY_DO = ip_ds.Tables[0].Rows[i]["LY_DO"].ToString();
                v_us_thu_khac.dcID_LOAI_THU_NHAP_KHAC = CIPConvert.ToDecimal(ip_ds.Tables[0].Rows[i]["ID_LOAI_THU_NHAP_KHAC"]);
                v_us_thu_khac.Insert();
            }
            
        }

        //GD_TIEN_THUONG

        private void luu_so_tien_sau_thue_vao_gd_tien_thuong(DataSet ip_ds)
        {
            for (int i = 0; i < ip_ds.Tables[0].Rows.Count; i++)
            {
                US_GD_TIEN_THUONG_NHAN_VIEN v_us_tien_thuong_nv = new US_GD_TIEN_THUONG_NHAN_VIEN();
                v_us_tien_thuong_nv.dcID_NHAN_VIEN = CIPConvert.ToDecimal(ip_ds.Tables[0].Rows[i]["ID_NHAN_VIEN"]);
                v_us_tien_thuong_nv.dcSO_TIEN = CIPConvert.ToDecimal(ip_ds.Tables[0].Rows[i]["SO_TIEN_SAU_TINH_THUE"]);
                v_us_tien_thuong_nv.dcTHANG = CIPConvert.ToDecimal(DateTime.Now.Month.ToString());
                v_us_tien_thuong_nv.dcNAM = CIPConvert.ToDecimal(ip_ds.Tables[0].Rows[i]["NAM"]);
                v_us_tien_thuong_nv.dcID_LOAI_TIEN_THUONG = CONST_ID_TIEN_THUONG.THUONG_HS_BS;
                //nguoi lap
                v_us_tien_thuong_nv.datNGAY_LAP = DateTime.Now.Date;
                //nguoi sua 
                //ngay sua
                v_us_tien_thuong_nv.strDA_XOA = "N";
                v_us_tien_thuong_nv.Insert();
            }
        }

        //
        private void save_data()
        {
            try
            {
                //1. luu so tien vao GD_QUY_TIEN
                luu_so_tien_vao_quy_tien();

                //2. insert thang da giam tru vao GD_THANG_DA_GIAM_TRU
                if (m_chk_giam_tru.Checked == true)
                {
                    luu_thang_da_giam_tru();
                }
                //3. Luu so tien vao cac gd
                try
                {
                    DataSet v_ds = new DataSet();
                    load_data_2_dataset_bang_tien_thuong_hs_bs(v_ds);
                    //3.1 insert so tien vao GD_THU_KHAC
                    luu_so_tien_vao_gd_thu_nhap_khac(v_ds);
                    //3.2 insert so tien sau thue vao GD_TIEN_THUONG
                    luu_so_tien_sau_thue_vao_gd_tien_thuong(v_ds);

                }
                catch (Exception v_e)
                {
                    throw v_e;
                }
            }
            catch (Exception v_e_save_data)
            {
                throw v_e_save_data;
            }
        }


        private bool kiem_tra_thang_da_giam_tru_chua(decimal ip_dc_nam)
        {
            DS_GD_THANG_DA_GIAM_TRU v_ds = new DS_GD_THANG_DA_GIAM_TRU();
            US_GD_THANG_DA_GIAM_TRU v_us = new US_GD_THANG_DA_GIAM_TRU();

            decimal op_dc_thang_da_giam_tru = 0; //1. da giam tru, 0. chua giam tru
            v_us.kiem_tra_thang_da_giam_tru_chua(CIPConvert.ToDecimal(DateTime.Now.Month), ip_dc_nam, ref op_dc_thang_da_giam_tru);

            if (op_dc_thang_da_giam_tru == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool check_data_is_ok()
        {
            if (m_txt_chon_nam.EditValue == null || m_txt_chon_nam.EditValue == "")
            {
                XtraMessageBox.Show("Bạn chưa nhập năm để tính rồi!", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                return false;
            }
            if (m_txt_so_tien.EditValue == null || m_txt_chon_nam.EditValue == "" || CIPConvert.ToDecimal(m_txt_so_tien.EditValue) == 0)
            {
                XtraMessageBox.Show("Bạn chưa nhập năm để tính rồi!", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void load_data_2_dataset_bang_tien_thuong_hs_bs(DataSet ip_ds)
        {
            decimal ip_check_giam_tru = 0; //0. chua check, 1. neu da check
            if (m_chk_giam_tru.Checked == true)
            {
                ip_check_giam_tru = 1;
            }
            else
            {
                ip_check_giam_tru = 0;
            }
            
            ip_ds.Tables.Add();
            m_us_hs_bs_athk = new US_GD_HS_BO_SUNG_AN_TOAN_HANG_KHONG();
            m_us_hs_bs_athk.load_du_lieu_bang_luong_theo_hs_bs(ip_ds, CIPConvert.ToDecimal(m_txt_chon_nam.EditValue), CIPConvert.ToDecimal(m_txt_so_tien.EditValue), ip_check_giam_tru);
        }

        #endregion
        private void set_define_events()
        {
            this.Load += F365_quan_ly_hs_bo_sung_Load;
            m_cmd_luu_so_tien.Click += m_cmd_luu_so_tien_Click;
            m_cmd_tinh_tien.Click += m_cmd_tinh_tien_Click;
            FormClosed += F365_quan_ly_hs_bo_sung_FormClosed;
            m_txt_chon_nam.EditValueChanged += m_txt_chon_nam_EditValueChanged;
        }

        void m_txt_chon_nam_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (!kiem_tra_thang_da_giam_tru_chua(CIPConvert.ToDecimal(m_txt_chon_nam.EditValue)))
                {
                    m_chk_giam_tru.Enabled = true;
                }
                else
                {
                    m_chk_giam_tru.Checked = true;
                    m_chk_giam_tru.Text = "Đã giảm trừ";
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void F365_quan_ly_hs_bo_sung_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Dispose();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_tinh_tien_Click(object sender, EventArgs e)
        {
            try
            {
                if (check_data_is_ok())
                {
                    CCommon.make_stt(m_grv_quan_ly_he_so_bo_sung);
                    SplashScreenManager.ShowForm(typeof(F_wait_form));
                    DataSet v_ds = new DataSet();
                    load_data_2_dataset_bang_tien_thuong_hs_bs(v_ds);

                    m_grc_quan_ly_he_so_bo_sung.DataSource = v_ds.Tables[0];
                    m_grc_quan_ly_he_so_bo_sung.RefreshDataSource();
                    //if (m_chk_giam_tru.Checked == false)
                    //{
                    //    m_grv_quan_ly_he_so_bo_sung.Columns["SO_TIEN_SAU_TINH_THUE"].Visible = false;
                    //}
                    //else
                    //{
                    //    m_grv_quan_ly_he_so_bo_sung.Columns["SO_TIEN_SAU_TINH_THUE"].Visible = true;
                    //}
                    SplashScreenManager.CloseForm();
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e); 
                SplashScreenManager.CloseForm();
            }
        }

        void m_cmd_luu_so_tien_Click(object sender, EventArgs e)
        {
            try
            {
                if (m_grc_quan_ly_he_so_bo_sung.DataSource == null)
                {
                    XtraMessageBox.Show("Dữ liệu trống", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (XtraMessageBox.Show("Bạn có chắc chắn muốn lưu thông tin này?", "XÁC NHẬN LẠI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    save_data();
                    XtraMessageBox.Show("Thành công!", "THÔNG BÁO");
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void F365_quan_ly_hs_bo_sung_Load(object sender, EventArgs e)
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
    }
}
