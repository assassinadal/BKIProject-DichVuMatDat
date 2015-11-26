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
using BKI_DichVuMatDat.US;
using BKI_DichVuMatDat.DS;
using BKI_DichVuMatDat.DS.CDBNames;
using IP.Core.IPCommon;

using DevExpress.XtraEditors;
using System.Globalization;

namespace BKI_DichVuMatDat.BaoCao
{
    public partial class f450_thong_tin_nhan_vien : Form
    {
        public f450_thong_tin_nhan_vien()
        {
            InitializeComponent();
        }

        private DataSet load_data_to_ds_v_dm_nv()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithTableName(v_ds, "V_DM_NHAN_VIEN");
            return v_ds;
        }

        private void load_data_to_sle_chon_nhan_vien()
        {
            m_sle_chon_nhan_vien.Properties.DataSource = load_data_to_ds_v_dm_nv().Tables[0];
            m_sle_chon_nhan_vien.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            m_sle_chon_nhan_vien.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
        }

        private void m_sle_chon_nhan_vien_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (m_sle_chon_nhan_vien.EditValue == null || m_sle_chon_nhan_vien.EditValue.ToString() == "")
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

        private void load_data_to_all_controls(decimal ip_dc_id_nv)
        {
            US_DM_NHAN_VIEN v_us_nv = new US_DM_NHAN_VIEN(ip_dc_id_nv);
            load_data_to_grc_thong_tin_ca_nhan(v_us_nv);
            load_data_to_grc_thong_tin_lien_lac(v_us_nv);
            load_data_to_grc_thong_tin_trinh_do(v_us_nv);
            load_data_to_grc_thong_tin_cong_tac(v_us_nv);
            load_data_to_grc_thong_tin_hop_dong(v_us_nv);
        }

        private void load_data_to_grc_thong_tin_hop_dong(US_DM_NHAN_VIEN v_us_nv)
        {
            throw new NotImplementedException();
        }

        private void load_data_to_grc_thong_tin_cong_tac(US_DM_NHAN_VIEN v_us_nv)
        {
            throw new NotImplementedException();
        }

        private void load_data_to_grc_thong_tin_trinh_do(US_DM_NHAN_VIEN v_us_nv)
        {
            m_txt_chuyen_mon.Text = v_us_nv.strCHUYEN_MON;
            m_txt_trinh_do.Text = v_us_nv.strTRINH_DO_VAN_HOA;
            m_txt_noi_tot_nghiep.Text = v_us_nv.strTOT_NGHIEP_TAI;
            m_txt_nam_tot_nghiep.Text = v_us_nv.strNAM_TOT_NGHIEP;
            m_dat_ngay_chinh_thuc_tiep_nhan.Value = v_us_nv.datNGAY_CHINH_THUC_TIEP_NHAN;
            m_dat_ngay_tiep_nhan_vao_tct.Value = v_us_nv.datNGAY_TIEP_NHAN_VAO_TCT;
            m_dat_ngay_vao_hang_khong.Value = v_us_nv.datNGAY_VAO_HANG_KHONG;
        }

        private void load_data_to_grc_thong_tin_lien_lac(US_DM_NHAN_VIEN v_us_nv)
        {
            m_txt_so_dt.Text = v_us_nv.strSDT;
            m_txt_email.Text = v_us_nv.strEMAIL;
            m_txt_que_quan.Text = v_us_nv.strQUE_QUAN;
            m_txt_noi_sinh.Text = v_us_nv.strNOI_SINH;
            m_txt_dc_lien_lac.Text = v_us_nv.strDIA_CHI_LIEN_LAC;
            m_txt_dc_tam_tru.Text = v_us_nv.strDIA_CHI_TAM_TRU;
            m_txt_dc_thuong_tru.Text = v_us_nv.strDIA_CHI_THUONG_TRU;
        }

        private void load_data_to_grc_thong_tin_ca_nhan(US_DM_NHAN_VIEN v_us_nv)
        {
            m_txt_ma_nhan_vien.Text = v_us_nv.strMA_NV;
            m_dat_ngay_sinh.Value = v_us_nv.datNGAY_SINH;
            m_txt_dan_toc.Text = v_us_nv.strDAN_TOC;
            m_txt_quoc_tich.Text = v_us_nv.strQUOC_TICH;
            m_txt_ton_giao.Text = v_us_nv.strTON_GIAO;
            m_txt_so_cmt.Text = v_us_nv.strSO_CMT;
            m_txt_noi_cap_cmt.Text = v_us_nv.strNOI_CAP;
            m_dat_ngay_cap_cmt.Value = v_us_nv.datNGAY_CAP;
            m_txt_so_tk.Text = v_us_nv.strSO_TAI_KHOAN;
            m_txt_noi_cap_tk.Text = v_us_nv.strNGAN_HANG;
            m_txt_ms_thue.Text = v_us_nv.strMA_SO_THUE_CA_NHAN;
            load_data_to_rdb_gioi_tinh(v_us_nv.strGIOI_TINH);
            load_data_to_rdb_hon_nhan(v_us_nv.strHON_NHAN);
        }

        private void load_data_to_rdb_hon_nhan(string ip_str_hon_nhan)
        {
            //if (ip_str_hon_nhan == "")
            //{
                
            //}
        }

        private void load_data_to_rdb_gioi_tinh(string ip_str_gioi_tinh)
        {
            if (ip_str_gioi_tinh == "Nam")
            {
                m_rdb_gioi_tinh_nam.Checked = true;
                m_rdb_gioi_tinh_nu.Checked = false;
            }
            else if (ip_str_gioi_tinh == "Nữ")
            {
                m_rdb_gioi_tinh_nam.Checked = false;
                m_rdb_gioi_tinh_nu.Checked = true;
            }
            else
            {
                m_rdb_gioi_tinh_nam.Checked = false;
                m_rdb_gioi_tinh_nu.Checked = false;
            }
        }
    }
}
