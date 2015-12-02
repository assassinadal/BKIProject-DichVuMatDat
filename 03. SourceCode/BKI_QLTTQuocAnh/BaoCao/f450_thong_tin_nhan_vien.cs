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
            
            if (m_sle_chon_nhan_vien.EditValue.ToString() != "" || m_sle_chon_nhan_vien.EditValue != null)
            {
                load_data_to_all_controls(CIPConvert.ToDecimal(m_sle_chon_nhan_vien.EditValue.ToString()));
            }
        }

        private void load_data_to_all_controls(decimal ip_dc_id_nv)
        {
            US_DM_NHAN_VIEN v_us_nv = new US_DM_NHAN_VIEN(ip_dc_id_nv);
            load_data_to_pnl_thong_tin_co_ban(v_us_nv);
            load_data_to_pnl_thong_tin_giao_dich(v_us_nv);
            load_data_to_grc_hoc_van(v_us_nv);
            load_data_to_grc_thong_tin_lien_lac(v_us_nv);
            load_data_to_grc_hop_dong(v_us_nv);
        }

        private void load_data_to_grc_hop_dong(US_DM_NHAN_VIEN v_us_nv)
        {
            List<Label> customLabels = new List<Label>();
            for (int i = 0; i < 3; i++)
            {
                Label label = new Label();
                label.Location = new System.Drawing.Point(317, 119 + customLabels.Count * 26);
                label.Parent = m_grc_hop_dong;
                label.Name = "label" ;
                label.Text = v_us_nv.strCHUYEN_MON;
                label.Size = new System.Drawing.Size(77, 21);
                customLabels.Add(label);
                m_grc_hop_dong.Controls.Add(label);
            }
         
        }

        private void load_data_to_grc_thong_tin_lien_lac(US_DM_NHAN_VIEN v_us_nv)
        {
            m_lbl_email.Text = v_us_nv.strEMAIL;
            m_lbl_sdt.Text = v_us_nv.strSDT;
            m_lbl_dc_lien_lac.Text = v_us_nv.strDIA_CHI_LIEN_LAC;
            m_lbl_dc_tam_tru.Text = v_us_nv.strDIA_CHI_TAM_TRU;
            m_lbl_dc_thuong_tru.Text = v_us_nv.strDIA_CHI_THUONG_TRU;
        }

        private void load_data_to_grc_hoc_van(US_DM_NHAN_VIEN v_us_nv)
        {
            m_lbl_chuyen_mon.Text = v_us_nv.strCHUYEN_MON;
            m_lbl_trinh_do.Text = v_us_nv.strTRINH_DO_VAN_HOA;
            m_lbl_nam_tot_nghiep.Text = v_us_nv.strNAM_TOT_NGHIEP;
            m_lbl_noi_tot_nghiep.Text = v_us_nv.strTOT_NGHIEP_TAI;
        }

        private void load_data_to_pnl_thong_tin_giao_dich(US_DM_NHAN_VIEN v_us_nv)
        {
            m_lbl_so_cmt.Text = v_us_nv.strSO_CMT;
            m_lbl_noi_cap_cmt.Text = v_us_nv.strNOI_CAP;
            m_lbl_ngay_cap_cmt.Text = v_us_nv.datNGAY_CAP.ToShortDateString();
            m_lbl_so_tk.Text = v_us_nv.strSO_TAI_KHOAN;
            m_lbl_ngan_hang.Text = v_us_nv.strNGAN_HANG;
            m_lbl_ngay_cap_the.Text = v_us_nv.datNGAY_CAP_THE.ToShortDateString();
            m_lbl_ngay_het_han_the.Text = v_us_nv.datNGAY_HET_HAN_THE.ToShortDateString();
            m_lbl_ma_so_thue.Text = v_us_nv.strMA_SO_THUE_CA_NHAN;
        }

        private void load_data_to_pnl_thong_tin_co_ban(US_DM_NHAN_VIEN v_us_nv)
        {
            m_lbl_gioi_tinh.Text = v_us_nv.strGIOI_TINH;
            m_lbl_ma_nv.Text = v_us_nv.strMA_NV;
            m_lbl_ngay_sinh.Text = v_us_nv.datNGAY_SINH.ToShortDateString();
            m_lbl_noi_sinh.Text = v_us_nv.strNOI_SINH;
            m_lbl_que_quan.Text = v_us_nv.strQUE_QUAN;
            m_lbl_ton_giao.Text = v_us_nv.strTON_GIAO;
            m_lbl_quoc_tich.Text = v_us_nv.strQUOC_TICH;
            m_lbl_ton_giao.Text = v_us_nv.strTON_GIAO;
            m_lbl_hon_nhan.Text = v_us_nv.strHON_NHAN;           
            m_lbl_ngay_vao_hang_khong.Text = v_us_nv.datNGAY_VAO_HANG_KHONG.ToShortDateString();
            m_lbl_ngay_tiep_nhan_vao_tct.Text = v_us_nv.datNGAY_TIEP_NHAN_VAO_TCT.ToShortDateString();
            m_lbl_ngay_chinh_thuc_tiep_nhan.Text = v_us_nv.datNGAY_CHINH_THUC_TIEP_NHAN.ToShortDateString();
        }

        private void f450_thong_tin_nhan_vien_Load(object sender, EventArgs e)
        {
            load_data_to_sle_chon_nhan_vien();
        }



   
    }
}
