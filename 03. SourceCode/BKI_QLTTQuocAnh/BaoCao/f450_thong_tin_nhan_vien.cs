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

using System.Drawing.Printing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Drawing.Imaging; 

namespace BKI_DichVuMatDat.BaoCao
{
    public partial class f450_thong_tin_nhan_vien : Form
    {
        //int i = 0;
        //private Bitmap bitmap;
        //PrintDocument printdoc1 = new PrintDocument();
        //PrintPreviewDialog previewdlg = new PrintPreviewDialog();
        //PanelControl pannel = null;
       
        public f450_thong_tin_nhan_vien()
        {
            InitializeComponent();
        }

        private DataSet load_data_to_ds_v_dm_nv()
        {
            //US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            //DataSet v_ds = new DataSet();
            //v_ds.Tables.Add(new DataTable());
            //throw new Exception("Sua lai khong dung FillDataSetWithTableName nua nhe");
            //v_us.FillDatasetWithTableName(v_ds, "V_DM_NHAN_VIEN");
            US_V_DM_NHAN_VIEN v_us = new US_V_DM_NHAN_VIEN();
            DS_V_DM_NHAN_VIEN v_ds = new DS_V_DM_NHAN_VIEN();
            v_us.FillDataset(v_ds);
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
                if (m_sle_chon_nhan_vien.EditValue.ToString() != "" || m_sle_chon_nhan_vien.EditValue != null)
                {
                    load_data_to_all_controls(CIPConvert.ToDecimal(m_sle_chon_nhan_vien.EditValue.ToString()));
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }            
        }

        private void load_data_to_all_controls(decimal ip_dc_id_nv)
        {
            US_V_DM_NHAN_VIEN v_us_nv = new US_V_DM_NHAN_VIEN(ip_dc_id_nv);
            load_data_to_pnl_thong_tin_co_ban(v_us_nv);
            load_data_to_pnl_thong_tin_giao_dich(v_us_nv);
            load_data_to_grc_hoc_van(v_us_nv);
            load_data_to_grc_thong_tin_lien_lac(v_us_nv);
            load_data_to_grc_hop_dong(ip_dc_id_nv);
            load_data_to_grc_cong_tac(ip_dc_id_nv);
        }

        private void load_data_to_grc_cong_tac(decimal ip_dc_id_nv)
        {
            m_grc_cong_tac.Controls.Clear();
            DataTable v_dt_v_gd_ct = load_data_to_v_gd_cong_tac(ip_dc_id_nv);
            load_data_to_lbl_don_vi(v_dt_v_gd_ct);
            load_data_to_lbl_thoi_han(v_dt_v_gd_ct);
            load_data_to_lbl_chuc_vu(v_dt_v_gd_ct);
            load_data_to_lbl_loai_ct(v_dt_v_gd_ct);        
        }

        private void load_data_to_lbl_loai_ct(DataTable v_dt_v_gd_ct)
        {
            List<Label> customLabels = new List<Label>();
            for (int i = 0; i < v_dt_v_gd_ct.Rows.Count; i++)
            {
                Label label = new Label();
                label.Parent = m_grc_cong_tac;
                label.Location = new System.Drawing.Point(30, 89 + customLabels.Count * 40);
                label.Text = "Loại công tác: " + v_dt_v_gd_ct.Rows[i]["TEN_LOAI_CONG_TAC"].ToString();
                label.Size = new System.Drawing.Size(200, 13);             
                customLabels.Add(label);
                m_grc_cong_tac.Controls.Add(label);
            }
        }

        private void load_data_to_lbl_chuc_vu(DataTable v_dt_v_gd_ct)
        {
            List<Label> customLabels = new List<Label>();
            for (int i = 0; i < v_dt_v_gd_ct.Rows.Count; i++)
            {
                Label label = new Label();
                label.Parent = m_grc_cong_tac;
                label.Location = new System.Drawing.Point(30, 70 + customLabels.Count * 60);
                label.Text = "Chức vụ: " + v_dt_v_gd_ct.Rows[i]["TEN_VI_TRI"].ToString();
                label.Size = new System.Drawing.Size(250, 13);
                customLabels.Add(label);
                m_grc_cong_tac.Controls.Add(label);
            }
        }

        private void load_data_to_lbl_thoi_han(DataTable v_dt_v_gd_ct)
        {
            List<Label> customLabels = new List<Label>();
            for (int i = 0; i < v_dt_v_gd_ct.Rows.Count; i++)
            {
                Label label = new Label();
                label.Parent = m_grc_cong_tac;
                label.Location = new System.Drawing.Point(280, 51 + customLabels.Count * 60);
                label.Text = v_dt_v_gd_ct.Rows[i]["NGAY_BAT_DAU"].ToString().Substring(0, 10) + " - " + v_dt_v_gd_ct.Rows[i]["NGAY_KET_THUC"].ToString().Substring(0, 10);
                label.Size = new System.Drawing.Size(150, 13);
                customLabels.Add(label);
                m_grc_cong_tac.Controls.Add(label);
            }
        }

        private void load_data_to_lbl_don_vi(DataTable v_dt_v_gd_ct)
        {
            List<Label> customLabels = new List<Label>();
            for (int i = 0; i < v_dt_v_gd_ct.Rows.Count; i++)
            {
                Label label = new Label();
                label.Parent = m_grc_cong_tac;
                label.Location = new System.Drawing.Point(21, 51 + customLabels.Count * 60);
                label.Text = v_dt_v_gd_ct.Rows[i]["TEN_DON_VI"].ToString();
                label.Size = new System.Drawing.Size(200, 13);
                customLabels.Add(label);
                m_grc_cong_tac.Controls.Add(label);
            }
        }

        private DataTable load_data_to_v_gd_cong_tac(decimal ip_dc_id_nv)
        {
            US_GD_CONG_TAC v_us = new US_GD_CONG_TAC();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.LayThongTinQuaTrinhCongTac(v_ds, ip_dc_id_nv);

            return v_ds.Tables[0];


            //DataSet v_ds = new DataSet();
            //US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            //v_ds.Tables.Add(new DataTable());
            //v_us.FillDatasetWithQuery(v_ds, "select * from v_gd_cong_tac where id_nhan_vien=" + ip_dc_id_nv);
            //return v_ds.Tables[0];
        }

        private DataTable load_data_to_v_gd_hop_dong(decimal ip_dc_id_nv)
        {
            US_GD_HOP_DONG v_us = new US_GD_HOP_DONG();
            return v_us.FillDataSetThongTinHopDong(ip_dc_id_nv).Tables[0];
            //DataSet v_ds = new DataSet();
            //US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            //v_ds.Tables.Add(new DataTable());
            //v_us.FillDatasetWithQuery(v_ds, "select * from v_gd_hop_dong where id_nhan_vien=" + ip_dc_id_nv);
            //return v_ds.Tables[0];
        }

        private void load_data_to_grc_hop_dong(decimal ip_dc_id_nv)
        {
            m_grc_hop_dong.Controls.Clear();
            DataTable v_dt_v_gd_hd = load_data_to_v_gd_hop_dong(ip_dc_id_nv);
            load_data_to_lbl_loai_hd(v_dt_v_gd_hd);
            load_data_to_lbl_thoi_han_hd(v_dt_v_gd_hd);
            //load_data_to_lbl_luong_ns(v_dt_v_gd_hd);
            //load_data_to_lbl_luong_che_do(v_dt_v_gd_hd);                
        }

        private void load_data_to_lbl_thoi_han_hd(DataTable v_dt_v_gd_hd)
        {
            List<Label> customLabels = new List<Label>();
            for (int i = 0; i < v_dt_v_gd_hd.Rows.Count; i++)
            {
                Label label = new Label();
                label.Parent = m_grc_hop_dong;
                label.Location = new System.Drawing.Point(280, 54 + customLabels.Count * 40);
                label.Text = v_dt_v_gd_hd.Rows[i]["NGAY_BAT_DAU"].ToString().Substring(0, 10) + " - " + v_dt_v_gd_hd.Rows[i]["NGAY_KET_THUC"].ToString().Substring(0, 10);
                label.Size = new System.Drawing.Size(150, 13);
                customLabels.Add(label);
                m_grc_hop_dong.Controls.Add(label);
            }
        }

        private void load_data_to_lbl_loai_hd(DataTable v_dt_v_gd_hd)
        {
            List<Label> customLabels = new List<Label>();
            for (int i = 0; i < v_dt_v_gd_hd.Rows.Count; i++)
            {
                Label label = new Label();
                label.Parent = m_grc_hop_dong;
                label.Location = new System.Drawing.Point(21, 54 + customLabels.Count * 40);
                label.Text = v_dt_v_gd_hd.Rows[i]["LOAI_HOP_DONG"].ToString();
                label.Size = new System.Drawing.Size(200, 13);
                customLabels.Add(label);
                m_grc_hop_dong.Controls.Add(label);
            }
        }
        private void load_data_to_grc_thong_tin_lien_lac(US_V_DM_NHAN_VIEN v_us_nv)
        {
            m_lbl_email.Text = v_us_nv.strEMAIL;
            m_lbl_sdt.Text = v_us_nv.strSDT;
            m_lbl_dc_lien_lac.Text = v_us_nv.strDIA_CHI_LIEN_LAC;
            m_lbl_dc_tam_tru.Text = v_us_nv.strDIA_CHI_TAM_TRU;
            m_lbl_dc_thuong_tru.Text = v_us_nv.strDIA_CHI_THUONG_TRU;
        }

        private void load_data_to_grc_hoc_van(US_V_DM_NHAN_VIEN v_us_nv)
        {
            m_lbl_chuyen_mon.Text = v_us_nv.strCHUYEN_MON;
            m_lbl_trinh_do.Text = v_us_nv.strTRINH_DO_VAN_HOA;
            m_lbl_nam_tot_nghiep.Text = v_us_nv.strNAM_TOT_NGHIEP;
            m_lbl_noi_tot_nghiep.Text = v_us_nv.strTOT_NGHIEP_TAI;
        }

        private void load_data_to_pnl_thong_tin_giao_dich(US_V_DM_NHAN_VIEN v_us_nv)
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

        private void load_data_to_pnl_thong_tin_co_ban(US_V_DM_NHAN_VIEN v_us_nv)
        {
            m_lbl_chuc_vu.Text = v_us_nv.strCHUC_VU;
            m_lbl_don_vi.Text = v_us_nv.strTEN_DON_VI;
            m_lbl_gioi_tinh.Text = v_us_nv.strGT;
            m_lbl_ma_nv.Text = v_us_nv.strMA_NV;
            m_lbl_ngay_sinh.Text = v_us_nv.datNGAY_SINH.ToShortDateString();
            m_lbl_noi_sinh.Text = v_us_nv.strNOI_SINH;
            m_lbl_que_quan.Text = v_us_nv.strQUE_QUAN;
            m_lbl_ton_giao.Text = v_us_nv.strTON_GIAO;
            m_lbl_quoc_tich.Text = v_us_nv.strQUOC_TICH;
            m_lbl_dan_toc.Text = v_us_nv.strDAN_TOC;
            m_lbl_hon_nhan.Text = v_us_nv.strHON_NHAN;           
            m_lbl_ngay_vao_hang_khong.Text = v_us_nv.datNGAY_VAO_HANG_KHONG.ToShortDateString();
            m_lbl_ngay_tiep_nhan_vao_tct.Text = v_us_nv.datNGAY_TIEP_NHAN_VAO_TCT.ToShortDateString();
            m_lbl_ngay_chinh_thuc_tiep_nhan.Text = v_us_nv.datNGAY_CHINH_THUC_TIEP_NHAN.ToShortDateString();
        }

        private void f450_thong_tin_nhan_vien_Load(object sender, EventArgs e)
        {
            load_data_to_sle_chon_nhan_vien();
        }



        private void f450_thong_tin_nhan_vien_MouseClick(object sender, MouseEventArgs e)
        {
            //Print(this.m_pnl_thong_tin_nhan_vien);
            SaveBitmap();
        }

        //private void Print(PanelControl panelControl)
        //{
        //    GetPrintArea(panelControl);
        //    printPreviewDialog1.Document = printDocument1;
        //    printPreviewDialog1.PrintPreviewControl.Zoom = 1.2;
        //    ((Form)printPreviewDialog1).WindowState = FormWindowState.Maximized;
        //    printPreviewDialog1.ShowDialog();
        //}

        //private void GetPrintArea(PanelControl panelControl)
        //{
        //    bitmap = new Bitmap(panelControl.Width, panelControl.Height);
        //    panelControl.DrawToBitmap(bitmap, new Rectangle(0, 0, panelControl.Width, panelControl.Height));
        //}
        //private void PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        //{
        //    Rectangle pagearea = e.PageBounds;
        //    e.Graphics.DrawImage(bitmap, (pagearea.Width / 2) - (this.m_pnl_thong_tin_nhan_vien.Width / 2), this.m_pnl_thong_tin_nhan_vien.Location.Y) ;
        //}

        public void DrawControl(Control control, Bitmap bitmap)
        {
            control.DrawToBitmap(bitmap, control.Bounds);
            //foreach (Control childControl in control.Controls)
            //{
            //    DrawControl(childControl, bitmap);
            //}
        }

        public void SaveBitmap()
        {
            Bitmap bmp = new Bitmap(this.m_pnl_thong_tin_nhan_vien.Width, this.m_pnl_thong_tin_nhan_vien.Height);

            this.m_pnl_thong_tin_nhan_vien.DrawToBitmap(bmp, new Rectangle(0, 0, this.m_pnl_thong_tin_nhan_vien.Width, this.m_pnl_thong_tin_nhan_vien.Height));
            foreach (Control control in m_pnl_thong_tin_nhan_vien.Controls)
            {
                DrawControl(control, bmp);
            }           
            bmp.Save( "C:\\"+ new Guid().ToString() +"panel.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            
        }

    }
}
