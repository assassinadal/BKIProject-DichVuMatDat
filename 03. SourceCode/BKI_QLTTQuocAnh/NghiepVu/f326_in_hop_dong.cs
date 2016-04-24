using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IP.Core.IPCommon;
using BKI_DichVuMatDat.DS;
using BKI_DichVuMatDat.US;
using DevExpress.XtraEditors;
using IP.Core.IPWordReport;
using System.IO;

namespace BKI_DichVuMatDat.NghiepVu
{
    public partial class f326_in_hop_dong : Form
    {
        #region Public Interface
        public f326_in_hop_dong()
        {
            InitializeComponent();
            set_initial_form_load();
        }
        #endregion

        #region Members
        DataRow m_dt_row;
        string m_output_path;
        #endregion

        #region Private Method
        private void set_initial_form_load()
        {
            m_dat_tu_ngay.EditValue = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            m_dat_den_ngay.EditValue = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddMonths(1).AddDays(-1);
            set_define_events();
        }

        private void load_data_to_grid()
        {
            US_GD_HOP_DONG v_us = new US_GD_HOP_DONG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetHDTheoNgayKy(v_ds,m_dat_tu_ngay.DateTime, m_dat_den_ngay.DateTime);
            m_grc_chi_tiet_hop_dong.DataSource = v_ds.Tables[0];
        }

        private void get_thong_tin_tgd()
        {
            US_DM_NHAN_VIEN v_us = new US_DM_NHAN_VIEN();
            m_dt_row= v_us.GetThongTinTGD();
        }

        private void print_hop_dong(DataRow ip_datarow, string ip_path)
        {

            switch (ip_datarow["ID_LOAI_HOP_DONG"].ToString())
            {
                case "4": print_hop_dong_hoc_viec(ip_datarow, ip_path);
                      break;
                case "5": print_hop_dong_thu_viec(ip_datarow, ip_path);
                      break;
                default: print_hop_dong_co_thoi_han(ip_datarow, ip_path);
                      break;
            }
                      
        }

        private void print_hop_dong_hoc_viec(DataRow ip_datarow, string ip_str_path)
        {
            CWordReport v_cwr = new CWordReport("HD_HOC_VIEC.docx",ip_str_path);
            v_cwr.AddFindAndReplace("<ten_tgd>", m_dt_row["HO_TEN_TGD"].ToString());
            v_cwr.AddFindAndReplace("<quoc_tich_tgd>", m_dt_row["QUOC_TICH"].ToString());
            v_cwr.AddFindAndReplace("<ten_nv>", ip_datarow["HO_TEN"].ToString());
            v_cwr.AddFindAndReplace("<quoc_tich_nv>", ip_datarow["QUOC_TICH"].ToString());
            v_cwr.AddFindAndReplace("<ngay_sinh>", ip_datarow["NGAY_SINH_NV"].ToString());
            v_cwr.AddFindAndReplace("<que_quan>", ip_datarow["QUE_QUAN"].ToString());
            v_cwr.AddFindAndReplace("<chuyen_mon>", ip_datarow["CHUYEN_MON"].ToString());
            v_cwr.AddFindAndReplace("<dia_chi>", ip_datarow["DIA_CHI_THUONG_TRU"].ToString());
            v_cwr.AddFindAndReplace("<so_cmt>", ip_datarow["SO_CMT"].ToString());
            v_cwr.AddFindAndReplace("<ngay_cap>", ip_datarow["NGAY_CAP_CMT"].ToString());
            v_cwr.AddFindAndReplace("<noi_cap>", ip_datarow["NOI_CAP"].ToString());
            v_cwr.AddFindAndReplace("<ngay_bat_dau_hd>", ip_datarow["NGAY_BAT_DAU"].ToString());
            v_cwr.AddFindAndReplace("<mo_ta_cv>", "");
            v_cwr.AddFindAndReplace("<ngay_hien_tai>", DateTime.Now.Day.ToString());
            v_cwr.AddFindAndReplace("<thang_hien_tai>", DateTime.Now.Month.ToString());
            v_cwr.AddFindAndReplace("<nam_hien_tai>", DateTime.Now.Year.ToString());
            v_cwr.Export2Word();
        }

        private void print_hop_dong_thu_viec(DataRow ip_datarow, string ip_str_path)
        {
            CWordReport v_cwr = new CWordReport("HD_THU_VIEC.docx", ip_str_path);
            v_cwr.AddFindAndReplace("<ten_tgd>", m_dt_row["HO_TEN_TGD"].ToString());
            v_cwr.AddFindAndReplace("<quoc_tich_tgd>", m_dt_row["QUOC_TICH"].ToString());
            v_cwr.AddFindAndReplace("<ten_nv>", ip_datarow["HO_TEN"].ToString());
            v_cwr.AddFindAndReplace("<quoc_tich_nv>", ip_datarow["QUOC_TICH"].ToString());
            v_cwr.AddFindAndReplace("<ngay_sinh>", ip_datarow["NGAY_SINH_NV"].ToString());
            v_cwr.AddFindAndReplace("<que_quan>", ip_datarow["QUE_QUAN"].ToString());
            v_cwr.AddFindAndReplace("<chuyen_mon>", ip_datarow["CHUYEN_MON"].ToString());
            v_cwr.AddFindAndReplace("<dia_chi>", ip_datarow["DIA_CHI_THUONG_TRU"].ToString());
            v_cwr.AddFindAndReplace("<so_cmt>", ip_datarow["SO_CMT"].ToString());
            v_cwr.AddFindAndReplace("<ngay_cap>", ip_datarow["NGAY_CAP_CMT"].ToString());
            v_cwr.AddFindAndReplace("<noi_cap>", ip_datarow["NOI_CAP"].ToString());
            v_cwr.AddFindAndReplace("<ngay_bat_dau_hd>", ip_datarow["NGAY_BAT_DAU"].ToString());
            v_cwr.AddFindAndReplace("<ngay_ket_thuc_hd>", ip_datarow["NGAY_KET_THUC"].ToString());
            v_cwr.AddFindAndReplace("<chuc_vu>", ip_datarow["CHUC_VU"].ToString());
            v_cwr.AddFindAndReplace("<don_vi>", ip_datarow["TEN_DON_VI"].ToString());
            v_cwr.AddFindAndReplace("<mo_ta_cv>", "");
            v_cwr.AddFindAndReplace("<ma_lcd>", ip_datarow["MA_LCD"].ToString());
            v_cwr.AddFindAndReplace("<muc_lcd>", ip_datarow["MUC_LCD"].ToString());
            v_cwr.AddFindAndReplace("<so_tien_lcd>", ip_datarow["SO_TIEN_LCD_THUC_TE"].ToString());
            v_cwr.AddFindAndReplace("<ngay_hien_tai>", DateTime.Now.Day.ToString());
            v_cwr.AddFindAndReplace("<thang_hien_tai>", DateTime.Now.Month.ToString());
            v_cwr.AddFindAndReplace("<nam_hien_tai>", DateTime.Now.Year.ToString());
            v_cwr.Export2Word();
        }

        private void print_hop_dong_co_thoi_han(DataRow ip_datarow, string ip_str_path)
        {
            CWordReport v_cwr = new CWordReport("HD_XAC_DINH_THOI_HAN.docx", ip_str_path);
            v_cwr.AddFindAndReplace("<ten_tgd>", m_dt_row["HO_TEN_TGD"].ToString());
            v_cwr.AddFindAndReplace("<quoc_tich_tgd>", m_dt_row["QUOC_TICH"].ToString());
            v_cwr.AddFindAndReplace("<ten_nv>", ip_datarow["HO_TEN"].ToString());
            v_cwr.AddFindAndReplace("<quoc_tich_nv>", ip_datarow["QUOC_TICH"].ToString());
            v_cwr.AddFindAndReplace("<ngay_sinh>", ip_datarow["NGAY_SINH_NV"].ToString());
            v_cwr.AddFindAndReplace("<que_quan>", ip_datarow["QUE_QUAN"].ToString());
            v_cwr.AddFindAndReplace("<chuyen_mon>", ip_datarow["CHUYEN_MON"].ToString());
            v_cwr.AddFindAndReplace("<dia_chi>", ip_datarow["DIA_CHI_THUONG_TRU"].ToString());
            v_cwr.AddFindAndReplace("<so_cmt>", ip_datarow["SO_CMT"].ToString());
            v_cwr.AddFindAndReplace("<ngay_cap>", ip_datarow["NGAY_CAP_CMT"].ToString());
            v_cwr.AddFindAndReplace("<noi_cap>", ip_datarow["NOI_CAP"].ToString());
            v_cwr.AddFindAndReplace("<ngay_bat_dau_hd>", ip_datarow["NGAY_BAT_DAU"].ToString());
            v_cwr.AddFindAndReplace("<chuc_vu>", ip_datarow["CHUC_VU"].ToString());
            v_cwr.AddFindAndReplace("<don_vi>", ip_datarow["TEN_DON_VI"].ToString());
            v_cwr.AddFindAndReplace("<mo_ta_cv>", "");
            v_cwr.AddFindAndReplace("<ma_lcd>", ip_datarow["MA_LCD"].ToString());
            v_cwr.AddFindAndReplace("<muc_lcd>", ip_datarow["MUC_LCD"].ToString());
            v_cwr.AddFindAndReplace("<so_tien_lcd>", ip_datarow["SO_TIEN_LCD"].ToString());
            v_cwr.AddFindAndReplace("<ngay_hien_tai>", DateTime.Now.Day.ToString());
            v_cwr.AddFindAndReplace("<thang_hien_tai>", DateTime.Now.Month.ToString());
            v_cwr.AddFindAndReplace("<nam_hien_tai>", DateTime.Now.Year.ToString());
            v_cwr.Export2Word();
        }
        #endregion

        #region Event Handle
        private void set_define_events()
        {
            this.Load += f326_in_hop_dong_Load;
            m_cmd_search.Click += m_cmd_search_Click;
            m_cmd_print.Click += m_cmd_print_Click;
            m_bgw.DoWork += m_bgw_DoWork;
            m_bgw.ProgressChanged += m_bgw_ProgressChanged;
            m_bgw.RunWorkerCompleted += m_bgw_RunWorkerCompleted;
        }

        void m_bgw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                m_prg.EditValue = 0;
                m_pn.Visible = false;
                string v_str = "Đã lưu hợp đồng tại thư mục " + Path.GetDirectoryName(m_output_path);
                XtraMessageBox.Show(v_str, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);               
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_bgw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            try
            {
                m_prg.EditValue = e.ProgressPercentage;
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_bgw_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                BackgroundWorker worker = sender as BackgroundWorker;
                for (int i = 0; i < m_grv_chi_tiet_hop_dong.GetSelectedRows().Length; i++)
                {
                    var v_dr = m_grv_chi_tiet_hop_dong.GetDataRow(m_grv_chi_tiet_hop_dong.GetSelectedRows()[i]);
                    string v_output_path = m_output_path + " " + v_dr["MA_NV"];
                    print_hop_dong(v_dr,v_output_path);
                    worker.ReportProgress((i + 1) * 100 / m_grv_chi_tiet_hop_dong.GetSelectedRows().Length);
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }          
        }

        void m_cmd_print_Click(object sender, EventArgs e)
        {
            try
            {
                int[] v_selected_row = m_grv_chi_tiet_hop_dong.GetSelectedRows();
                if (v_selected_row.Length == 0)
                {
                    string v_str_error = "Bạn chưa chọn dòng dữ liệu nào để in";
                    XtraMessageBox.Show(v_str_error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    m_output_path = "";
                    SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                    saveFileDialog1.Filter = "docx files (*.docx)|*.docx|All files (*.*)|*.*";
                    saveFileDialog1.RestoreDirectory = true;
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        m_output_path = Path.Combine(Path.GetDirectoryName(saveFileDialog1.FileName), Path.GetFileNameWithoutExtension(saveFileDialog1.FileName));
                        m_pn.Visible = true;
                        if (m_bgw.IsBusy)
                            m_bgw.CancelAsync();
                        else m_bgw.RunWorkerAsync();
                    }       
                }
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
                load_data_to_grid();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void f326_in_hop_dong_Load(object sender, EventArgs e)
        {
            try
            {
                load_data_to_grid();
                get_thong_tin_tgd();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        #endregion

    }
}
