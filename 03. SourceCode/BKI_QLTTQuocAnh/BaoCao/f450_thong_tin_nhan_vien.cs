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
            //US_V_GD_CONG_TAC v_us_cong_tac = new US_V_GD_CONG_TAC(ip_dc_id_nv);
            load_data_to_grc_thong_tin_ca_nhan(v_us_nv);
            load_data_to_grc_thong_tin_lien_lac(v_us_nv);
            load_data_to_grc_thong_tin_trinh_do(v_us_nv);
            load_data_to_grc_thong_tin_cong_tac(ip_dc_id_nv);
            load_data_to_grc_thong_tin_hop_dong(ip_dc_id_nv);
        }

        private void load_data_to_grc_thong_tin_hop_dong(decimal ip_dc_id_nv)
        {
            DataSet v_ds = new DataSet();
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithQuery(v_ds, "Select * from V_GD_HOP_DONG where ID_NHAN_VIEN =" + ip_dc_id_nv);
            m_lbl_hop_dong.Text = "";
            for (int i = 0; i < v_ds.Tables[0].Rows.Count; i++)
            {
                DataRow v_dr = v_ds.Tables[0].Rows[i];
                m_lbl_hop_dong.Text = m_lbl_hop_dong.Text +
                "\nTừ ngày: " + v_dr["NGAY_BAT_DAU"].ToString().Substring(0,10) + ", đến ngày: " + v_dr["NGAY_KET_THUC"].ToString().Substring(0,10) +
                "\n - Hợp đồng: " + v_dr["MA_HOP_DONG"].ToString() + "\n - Loại hợp đồng: " + v_dr["LOAI_HOP_DONG"].ToString() +
                "\n - Hệ số lương NS: " + v_dr["HE_SO"].ToString() + "\n - Lương chế độ: " + v_dr["SO_TIEN"].ToString();
            }
        }

        private void load_data_to_grc_thong_tin_cong_tac(decimal ip_dc_id_nv)
        {
            DataSet v_ds = new DataSet();
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithQuery(v_ds, "Select * from V_GD_CONG_TAC where ID_NHAN_VIEN =" + ip_dc_id_nv);
            m_lbl_qua_trinh_cong_tac.Text = "";
            for (int i = 0; i < v_ds.Tables[0].Rows.Count; i++)
            {
                DataRow v_dr = v_ds.Tables[0].Rows[i]; 
                m_lbl_qua_trinh_cong_tac.Text = m_lbl_qua_trinh_cong_tac.Text +
                "\nTừ ngày: " + v_dr["NGAY_BAT_DAU"].ToString().Substring(0, 10) + ", đến ngày: " + v_dr["NGAY_KET_THUC"].ToString().Substring(0, 10) +
                "\n - Làm việc tại đơn vị: " + v_dr["TEN_DON_VI"].ToString() + "\n - Chức vụ: " + v_dr["TEN_VI_TRI"].ToString() +
                "\n - Loại công tác: " + v_dr["TEN_LOAI_CONG_TAC"].ToString();
            }          
        }

        private void load_data_to_grc_thong_tin_trinh_do(US_DM_NHAN_VIEN v_us_nv)
        {
            m_txt_chuyen_mon.Text = v_us_nv.strCHUYEN_MON;
            m_txt_trinh_do.Text = v_us_nv.strTRINH_DO_VAN_HOA;
            m_txt_noi_tot_nghiep.Text = v_us_nv.strTOT_NGHIEP_TAI;
            m_txt_nam_tot_nghiep.Text = v_us_nv.strNAM_TOT_NGHIEP;
            m_txt_ngay_chinh_thuc.Text = v_us_nv.datNGAY_CHINH_THUC_TIEP_NHAN.ToShortDateString();
            m_txt_ngay_tiep_nhan.Text = v_us_nv.datNGAY_TIEP_NHAN_VAO_TCT.ToShortDateString();
            m_txt_ngay_vao.Text = v_us_nv.datNGAY_VAO_HANG_KHONG.ToShortDateString();
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
            m_txt_ngay_sinh.Text = v_us_nv.datNGAY_SINH.ToShortDateString();
            m_txt_dan_toc.Text = v_us_nv.strDAN_TOC;
            m_txt_quoc_tich.Text = v_us_nv.strQUOC_TICH;
            m_txt_ton_giao.Text = v_us_nv.strTON_GIAO;
            m_txt_so_cmt.Text = v_us_nv.strSO_CMT;
            m_txt_noi_cap_cmt.Text = v_us_nv.strNOI_CAP;
            m_txt_ngay_cap_cmt.Text = v_us_nv.datNGAY_CAP.ToShortDateString();
            m_txt_so_tk.Text = v_us_nv.strSO_TAI_KHOAN;
            m_txt_noi_cap_tk.Text = v_us_nv.strNGAN_HANG;
            m_txt_ms_thue.Text = v_us_nv.strMA_SO_THUE_CA_NHAN;
            m_txt_gioi_tinh.Text = v_us_nv.strGIOI_TINH;
            m_txt_hon_nhan.Text = v_us_nv.strHON_NHAN;
        }        

        private void f450_thong_tin_nhan_vien_Load(object sender, EventArgs e)
        {
            load_data_to_sle_chon_nhan_vien();
        }
    }
}
