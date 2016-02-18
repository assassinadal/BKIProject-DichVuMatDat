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

namespace BKI_DichVuMatDat.DanhMuc
{
    public partial class f150_danh_muc_nhan_su_v2 : Form
    {
        public f150_danh_muc_nhan_su_v2()
        {
            InitializeComponent();
            fill_combobox_gioi_tinh();
        }

      

        #region Members
        US_DM_NHAN_VIEN m_us = new US_DM_NHAN_VIEN();
        DataEntryFormMode m_e_form_mode = new DataEntryFormMode();
        #endregion

        #region Private Methods

        private void fill_combobox_gioi_tinh()
        {
            m_cbo_gioi_tinh.Items.Add("Nam");
            m_cbo_gioi_tinh.Items.Add("Nữ");
        }

        internal void DisplayForInsert()
        {
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            this.ShowDialog();
        }

        internal void DisplayForUpdate(US_DM_NHAN_VIEN v_us)
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            m_us = v_us;
            us_to_form(v_us);
            this.ShowDialog();
        }

        private void us_to_form(US_DM_NHAN_VIEN v_us)
        {
             m_txt_ma_nv.Text=  m_us.strMA_NV ;
             m_txt_ho_dem_nv.Text=  m_us.strHO_DEM ;
             m_txt_ten_nv.Text= m_us.strTEN ;                      
             m_txt_email.Text=  m_us.strEMAIL ;
             m_txt_sdt.Text=  m_us.strSDT ;
             m_txt_so_tai_khoan.Text=  m_us.strSO_TAI_KHOAN ;
             m_txt_ngan_hang.Text= m_us.strNGAN_HANG ;
            if (m_us.strGIOI_TINH=="Y")
            m_cbo_gioi_tinh.Text="Nam";
                else
            m_cbo_gioi_tinh.Text="Nữ";
             if (m_us.datNGAY_CAP_THE != new DateTime(1900, 01, 01))
             m_dat_ngay_cap_the.EditValue=  m_us.datNGAY_CAP_THE ;
            if (m_us.datNGAY_HET_HAN_THE != new DateTime(1900, 01, 01))
             m_dat_ngay_het_han_the.EditValue=  m_us.datNGAY_HET_HAN_THE ;
            if (m_us.datNGAY_SINH != new DateTime(1900, 01, 01))
             m_dat_ngay_sinh.EditValue= m_us.datNGAY_SINH ;
            m_txt_trinh_do_van_hoa.Text = m_us.strTRINH_DO_VAN_HOA;        
             m_txt_so_cmt.Text=  m_us.strSO_CMT ;
            if( m_us.datNGAY_CAP==DateTime.MinValue)
             m_dat_ngay_cap_cmt.EditValue= m_us.datNGAY_CAP ;
             m_txt_noi_cap_cmt.Text= m_us.strNOI_CAP ;
             m_txt_quoc_tich.Text=  m_us.strQUOC_TICH ;
             m_txt_dan_toc.Text= m_us.strDAN_TOC ;
             m_txt_ton_giao.Text= m_us.strTON_GIAO ;
             m_txt_noi_sinh.Text= m_us.strNOI_SINH ;
             m_txt_que_quan.Text= m_us.strQUE_QUAN ;
             m_txt_dia_chi_thuong_tru.Text= m_us.strDIA_CHI_THUONG_TRU ;
             m_txt_dia_chi_tam_tru.Text= m_us.strDIA_CHI_TAM_TRU ;
             m_txt_dia_chi_lien_lac.Text=  m_us.strDIA_CHI_LIEN_LAC ;
             m_txt_ma_so_thue_ca_nhan.Text=  m_us.strMA_SO_THUE_CA_NHAN ;
             m_txt_chuyen_mon.Text= m_us.strCHUYEN_MON ;
            // m_txt_trinh_do_van_hoa.Text=             //  m_us.strTRINH_DO_VAN_HOA ;
             m_txt_nam_tot_nghiep.Text= m_us.strNAM_TOT_NGHIEP ;
             m_txt_hon_nhan.Text = m_us.strHON_NHAN;
             m_txt_noi_tot_nghiep.Text= m_us.strTOT_NGHIEP_TAI ;
             if (m_us.datNGAY_VAO_HANG_KHONG.Date != new DateTime(1900, 01, 01))
             m_dat_ngay_vao_hang_khong.EditValue=   m_us.datNGAY_VAO_HANG_KHONG ;
             if (m_us.datNGAY_TIEP_NHAN_VAO_TCT != new DateTime(1900, 01, 01))
             m_dat_ngay_tiep_nhan_vao_tct.EditValue= m_us.datNGAY_TIEP_NHAN_VAO_TCT ;
             if (m_us.datNGAY_CHINH_THUC_TIEP_NHAN != new DateTime(1900, 01, 01))
             m_dat_ngay_chinh_thuc_tiep_nhan.EditValue=   m_us.datNGAY_CHINH_THUC_TIEP_NHAN ;


        }

        #endregion


        private void form_to_us()
        {
          
            m_us.strMA_NV = m_txt_ma_nv.Text;
            m_us.strHO_DEM = m_txt_ho_dem_nv.Text;
            m_us.strTEN = m_txt_ten_nv.Text;
            if (m_cbo_gioi_tinh.Text == "Nam") m_us.strGIOI_TINH = "Y";
            else m_us.strGIOI_TINH = "N";
            m_us.strEMAIL = m_txt_email.Text;
            m_us.strSDT = m_txt_sdt.Text;
            m_us.strSO_TAI_KHOAN = m_txt_so_tai_khoan.Text;
            m_us.strNGAN_HANG = m_txt_ngan_hang.Text;
            if( m_dat_ngay_cap_the.EditValue!=null)
            m_us.datNGAY_CAP_THE = CIPConvert.ToDatetime(m_dat_ngay_cap_the.EditValue);
            if (m_dat_ngay_het_han_the.EditValue != null)
            m_us.datNGAY_HET_HAN_THE = CIPConvert.ToDatetime(m_dat_ngay_het_han_the.EditValue);
            if (m_dat_ngay_sinh.EditValue != null)
            m_us.datNGAY_SINH = m_dat_ngay_sinh.DateTime;
            m_us.strHON_NHAN = m_txt_hon_nhan.Text;
            m_us.strSO_CMT = m_txt_so_cmt.Text;
           m_us.strTRINH_DO_VAN_HOA= m_txt_trinh_do_van_hoa.Text ;      
            if (m_dat_ngay_cap_cmt.EditValue != null)
            m_us.datNGAY_CAP = CIPConvert.ToDatetime(m_dat_ngay_cap_cmt.EditValue);
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

        private void m_cmd_save_Click(object sender, EventArgs e)
        {
           
                if (m_txt_ma_nv.Text == "" || m_txt_ho_dem_nv.Text == "" || m_txt_ten_nv.Text == "")
                {
                    MessageBox.Show("Bạn phải điền đầy đủ thông tin!");
                }
                else
                {
                     try
                  {
                    if (m_e_form_mode == DataEntryFormMode.InsertDataState)
                    {
                        form_to_us();
                        try
                        {
                            m_us.Insert();
                            this.Close();
                            MessageBox.Show("Lưu thông tin nhân viên thành công!");
                        }
                        catch (Exception)
                        {

                            MessageBox.Show("Trùng mã nhân viên. Xin vui lòng nhập lại thông tin!");
                        }
                       
                        
                        
                    }
                    else if (m_e_form_mode == DataEntryFormMode.UpdateDataState)
                    {

                        form_to_us();
                        try
                        {
                            m_us.Update();
                            this.Close();
                            MessageBox.Show("Lưu thông tin nhân viên thành công!");
                        }
                        catch (Exception)
                        {

                            MessageBox.Show("Trùng mã nhân viên. Xin vui lòng nhập lại thông tin!");
                        }
                       
                       
                        

                    }
                }

                    catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
                MessageBox.Show("Trùng mã nhân viên. Xin vui lòng nhập lại thông tin!");
            } 
            }
        
            
        }

        private void m_cmd_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


      

       
    }
}
