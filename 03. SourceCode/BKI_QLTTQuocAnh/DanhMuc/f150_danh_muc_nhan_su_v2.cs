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
using BKI_DichVuMatDat.US;
using IP.Core.IPCommon;
using BKI_DichVuMatDat.DS.CDBNames;
using BKI_DichVuMatDat.NghiepVu;
using BKI_DichVuMatDat.COMMON;

namespace BKI_DichVuMatDat.DanhMuc
{
    public partial class f150_danh_muc_nhan_su_v2 : Form
    {
        public f150_danh_muc_nhan_su_v2()
        {
            InitializeComponent();
            format_controls();
        }

        #region Public Interface
        public void DisplayForInsert()
        {
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            Text = "F150 - Thêm mới nhân viên";
            m_txt_ma_nv.Text = ExecuteFuntion.LayMaNhanVienTiepTheo().ToString();
            this.CenterToScreen();
            this.ShowDialog();
        }

        public void DisplayForInsert(ref int m_trang_thai_buoc_1_sau_hien_thi)
        {
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            Text = "F150 - Thêm mới nhân viên";
            m_txt_ma_nv.Text = ExecuteFuntion.LayMaNhanVienTiepTheo().ToString();
            this.CenterToScreen();
            this.ShowDialog();
            m_trang_thai_buoc_1_sau_hien_thi = m_trang_thai_buoc_1_sau_hien_thi_f150_v2;
        }

        public void DisplayForUpdate(US_DM_NHAN_VIEN v_us)
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            Text = "F150 - Sửa thông tin nhân viên";
            layoutControlItem16.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            m_us = v_us;
            us_to_form(v_us);
            this.ShowDialog();
        }
        
        #endregion

        #region Members
        US_DM_NHAN_VIEN m_us = new US_DM_NHAN_VIEN();
        DataEntryFormMode m_e_form_mode = new DataEntryFormMode();
        int m_trang_thai_buoc_1_sau_hien_thi_f150_v2 = -3;
        public decimal id_nv_new = -1;
        #endregion

        #region Private Methods
        private void format_controls()
        {
            this.KeyPreview = true;
            set_define_events();
        }

        private void set_init_form_load()
        {
            //this.cM_DM_TU_DIENTableAdapter.Fill(this.dVMDDataSet3.CM_DM_TU_DIEN);
            m_txt_tuoi_nv.Enabled = false;
            tinh_tuoi_nhan_vien(m_dat_ngay_sinh.DateTime.Date);
            fill_combobox_gioi_tinh();
            fill_combobox_hon_nhan();
            load_data_2_sle_trinh_do();
        }

        private void fill_combobox_hon_nhan()
        {
            m_cbc_hon_nhan.Properties.Items.Add("Đã kết hôn");
            m_cbc_hon_nhan.Properties.Items.Add("Chưa kết hôn");
        }

        private DS_CM_DM_TU_DIEN load_data_2_cm_dm_tu_dien(int ip_id_loai_td)
        {
            DS_CM_DM_TU_DIEN v_ds = new DS_CM_DM_TU_DIEN();
            US_CM_DM_TU_DIEN v_us = new US_CM_DM_TU_DIEN();

            v_us.FillDatasetByIdLoaiTuDien(v_ds, ip_id_loai_td);

            return v_ds;
        }

        private void load_data_2_sle_trinh_do()
        {
            m_sle_trinh_do.Properties.DataSource = load_data_2_cm_dm_tu_dien(CONST_ID_LOAI_TU_DIEN.TRINH_DO_CHUYEN_MON).CM_DM_TU_DIEN;
            m_sle_trinh_do.Properties.ValueMember = CM_DM_TU_DIEN.ID;
            m_sle_trinh_do.Properties.DisplayMember = CM_DM_TU_DIEN.TEN;

            m_sle_trinh_do.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            m_sle_trinh_do.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
        }

        private void fill_combobox_gioi_tinh()
        {
            m_cbo_gioi_tinh.Properties.Items.Add("Nam");
            m_cbo_gioi_tinh.Properties.Items.Add("Nữ");
        }

        private void us_to_form(US_DM_NHAN_VIEN v_us)
        {
            m_txt_ma_nv.Text = m_us.strMA_NV;
            m_txt_ho_dem_nv.Text = m_us.strHO_DEM;
            m_txt_ten_nv.Text = m_us.strTEN;
            m_txt_email.Text = m_us.strEMAIL;
            m_txt_sdt.Text = m_us.strSDT;
            m_txt_so_tai_khoan.Text = m_us.strSO_TAI_KHOAN;
            m_txt_ngan_hang.Text = m_us.strNGAN_HANG;
            if (m_us.strGIOI_TINH == "Y")
                m_cbo_gioi_tinh.Text = "Nam";
            else
                m_cbo_gioi_tinh.Text = "Nữ";
            if (m_us.datNGAY_CAP_THE != new DateTime(1900, 01, 01))
                m_dat_ngay_cap_the.EditValue = m_us.datNGAY_CAP_THE;
            if (m_us.datNGAY_HET_HAN_THE != new DateTime(1900, 01, 01))
                m_dat_ngay_het_han_the.EditValue = m_us.datNGAY_HET_HAN_THE;
            if (m_us.datNGAY_SINH != new DateTime(1900, 01, 01))
                m_dat_ngay_sinh.EditValue = m_us.datNGAY_SINH;

            m_sle_trinh_do.Text = m_us.strTRINH_DO_VAN_HOA;
            m_txt_so_cmt.Text = m_us.strSO_CMT;
            if (m_us.datNGAY_CAP == DateTime.MinValue)
                m_dat_ngay_cap_cmt.EditValue = m_us.datNGAY_CAP;
            m_txt_noi_cap_cmt.Text = m_us.strNOI_CAP;
            m_txt_quoc_tich.Text = m_us.strQUOC_TICH;
            m_txt_dan_toc.Text = m_us.strDAN_TOC;
            m_txt_ton_giao.Text = m_us.strTON_GIAO;
            m_txt_noi_sinh.Text = m_us.strNOI_SINH;
            m_txt_que_quan.Text = m_us.strQUE_QUAN;
            m_txt_dia_chi_thuong_tru.Text = m_us.strDIA_CHI_THUONG_TRU;
            m_txt_dia_chi_tam_tru.Text = m_us.strDIA_CHI_TAM_TRU;
            m_txt_dia_chi_lien_lac.Text = m_us.strDIA_CHI_LIEN_LAC;
            m_txt_ma_so_thue_ca_nhan.Text = m_us.strMA_SO_THUE_CA_NHAN;
            m_txt_chuyen_mon.Text = m_us.strCHUYEN_MON;
            // m_txt_trinh_do_van_hoa.Text=             //  m_us.strTRINH_DO_VAN_HOA ;
            m_txt_nam_tot_nghiep.Text = m_us.strNAM_TOT_NGHIEP;
            m_cbc_hon_nhan.Text = m_us.strHON_NHAN;
            m_txt_noi_tot_nghiep.Text = m_us.strTOT_NGHIEP_TAI;
            if (m_us.datNGAY_VAO_HANG_KHONG.Date != new DateTime(1900, 01, 01))
                m_dat_ngay_vao_hang_khong.EditValue = m_us.datNGAY_VAO_HANG_KHONG;
            if (m_us.datNGAY_TIEP_NHAN_VAO_TCT != new DateTime(1900, 01, 01))
                m_dat_ngay_tiep_nhan_vao_tct.EditValue = m_us.datNGAY_TIEP_NHAN_VAO_TCT;
            if (m_us.datNGAY_CHINH_THUC_TIEP_NHAN != new DateTime(1900, 01, 01))
                m_dat_ngay_chinh_thuc_tiep_nhan.EditValue = m_us.datNGAY_CHINH_THUC_TIEP_NHAN;
        }

        private void form_to_us()
        {

            m_us.strMA_NV = m_txt_ma_nv.Text;
            m_us.strHO_DEM = m_txt_ho_dem_nv.Text;
            m_us.strTEN = m_txt_ten_nv.Text;
            if (m_cbo_gioi_tinh.Text.Trim().ToUpper() == "NAM")
                m_us.strGIOI_TINH = "Y";
            else m_us.strGIOI_TINH = "N";
            m_us.strEMAIL = m_txt_email.Text;
            m_us.strSDT = m_txt_sdt.Text;
            m_us.strSO_TAI_KHOAN = m_txt_so_tai_khoan.Text;
            m_us.strNGAN_HANG = m_txt_ngan_hang.Text;
            if (m_dat_ngay_cap_the.EditValue != null)
                m_us.datNGAY_CAP_THE = m_dat_ngay_cap_the.DateTime;
            if (m_dat_ngay_het_han_the.EditValue != null)
                m_us.datNGAY_HET_HAN_THE = m_dat_ngay_het_han_the.DateTime;
            if (m_dat_ngay_sinh.EditValue != null)
                m_us.datNGAY_SINH = m_dat_ngay_sinh.DateTime;
            m_us.strHON_NHAN = m_cbc_hon_nhan.Text;
            m_us.strSO_CMT = m_txt_so_cmt.Text;
            if (m_sle_trinh_do.EditValue != null)
                m_us.strTRINH_DO_VAN_HOA = m_sle_trinh_do.EditValue.ToString();
            if (m_dat_ngay_cap_cmt.EditValue != null)
                m_us.datNGAY_CAP = m_dat_ngay_cap_cmt.DateTime;
            m_us.strNOI_CAP = m_txt_noi_cap_cmt.Text;
            m_us.strQUOC_TICH = m_txt_quoc_tich.Text;
            m_us.strDAN_TOC = m_txt_dan_toc.Text;
            m_us.strTON_GIAO = m_txt_ton_giao.Text;
            m_us.strNOI_SINH = m_txt_noi_sinh.Text;
            m_us.strQUE_QUAN = m_txt_que_quan.Text;
            m_us.strDIA_CHI_THUONG_TRU = m_txt_dia_chi_thuong_tru.Text;
            m_us.strDIA_CHI_TAM_TRU = m_txt_dia_chi_tam_tru.Text;
            m_us.strDIA_CHI_LIEN_LAC = m_txt_dia_chi_lien_lac.Text;
            m_us.strMA_SO_THUE_CA_NHAN = m_txt_ma_so_thue_ca_nhan.Text;
            m_us.strCHUYEN_MON = m_txt_chuyen_mon.Text;
            //  m_us.strTRINH_DO_VAN_HOA = m_txt_trinh_do_van_hoa.Text;
            m_us.strNAM_TOT_NGHIEP = m_txt_nam_tot_nghiep.Text;
            m_us.strTOT_NGHIEP_TAI = m_txt_noi_tot_nghiep.Text;
            if (m_dat_ngay_vao_hang_khong.EditValue != null)
                m_us.datNGAY_VAO_HANG_KHONG = m_dat_ngay_vao_hang_khong.DateTime;
            if (m_dat_ngay_tiep_nhan_vao_tct.EditValue != null)
                m_us.datNGAY_TIEP_NHAN_VAO_TCT = m_dat_ngay_tiep_nhan_vao_tct.DateTime;
            if (m_dat_ngay_chinh_thuc_tiep_nhan.EditValue != null)
                m_us.datNGAY_CHINH_THUC_TIEP_NHAN = m_dat_ngay_chinh_thuc_tiep_nhan.DateTime;

        }

        private void tinh_tuoi_nhan_vien(DateTime ip_dat_ngay_sinh)
        {
            if (m_dat_ngay_sinh.Text != null && m_dat_ngay_sinh.Text != "")
            {
                decimal v_so_tuoi = 0;
                //m_us.tinh_tuoi_nhan_vien(ip_dat_ngay_sinh, ref v_so_tuoi);
                m_txt_tuoi_nv.EditValue = CHRMCommon.TinhTuoi(ip_dat_ngay_sinh.Date);
            }
            else
            {
                m_txt_tuoi_nv.Text = "";
            }
        }

        #endregion

        private void set_define_events()
        {
            this.Load += f150_danh_muc_nhan_su_v2_Load;
            m_cmd_save.Click += m_cmd_save_Click;
            m_cmd_exit.Click += m_cmd_exit_Click;
            //m_dat_ngay_sinh.EditValueChanged += m_dat_ngay_sinh_EditValueChanged;
            m_dat_ngay_sinh.Leave += m_dat_ngay_sinh_Leave;
        }

        void m_dat_ngay_sinh_Leave(object sender, EventArgs e)
        {
            try
            {
                tinh_tuoi_nhan_vien(m_dat_ngay_sinh.DateTime.Date);
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void f150_danh_muc_nhan_su_v2_Load(object sender, EventArgs e)
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

        void m_dat_ngay_sinh_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                tinh_tuoi_nhan_vien(m_dat_ngay_sinh.DateTime.Date);
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (m_txt_ma_nv.Text == "" || m_txt_ho_dem_nv.Text == "" || m_txt_ten_nv.Text == "")
                {
                    CHRM_BaseMessages.MsgBox_Error("Bạn chưa điền đầy đủ thông tin rồi!");
                }
                else
                {
                    if (m_e_form_mode == DataEntryFormMode.InsertDataState)
                    {
                        form_to_us();
                        try
                        {
                            m_us.Insert();
                            id_nv_new = m_us.dcID;
                            m_trang_thai_buoc_1_sau_hien_thi_f150_v2 = (int) m_us.dcID;
                            //F500_QUY_TRINH_THEM_MOI_NHAN_SU.done();
                            //get_id_nhan_vien_vua_insert(ref m_trang_thai_buoc_1_sau_hien_thi_f150_v2);

                            this.Close();
                            CHRM_BaseMessages.MsgBox_Infor(CONST_ID_MSGBOX.INFOR_DU_LIEU_DA_DUOC_CAP_NHAT);
                        }
                        catch (Exception)
                        {
                            CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_TRUNG_MA_NHAN_VIEN);
                        }
                    }
                    else if (m_e_form_mode == DataEntryFormMode.UpdateDataState)
                    {

                        form_to_us();
                        try
                        {
                            m_us.Update();
                            this.Close();
                            CHRM_BaseMessages.MsgBox_Infor(CONST_ID_MSGBOX.INFOR_DU_LIEU_DA_DUOC_CAP_NHAT);
                        }
                        catch (Exception)
                        {
                            CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_TRUNG_MA_NHAN_VIEN);
                        }
                    }
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
                CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_TRUNG_MA_NHAN_VIEN);
            }

        }

        private void m_cmd_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
