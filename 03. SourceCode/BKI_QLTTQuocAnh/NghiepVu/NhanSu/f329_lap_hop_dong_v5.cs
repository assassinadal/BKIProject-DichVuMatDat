﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IP.Core.IPCommon;
using BKI_DichVuMatDat.US;
using BKI_DichVuMatDat.DS;
using BKI_DichVuMatDat.DS.CDBNames;
using DevExpress.XtraEditors;
using BKI_DichVuMatDat.NghiepVu.HopDong;
using System.IO;
using IP.Core.IPWordReport;

namespace BKI_DichVuMatDat.NghiepVu.NhanSu
{
    public partial class f329_lap_hop_dong_v5 : Form
    {
        #region Public Interface
        public f329_lap_hop_dong_v5()
        {
            InitializeComponent();
            set_define_events();
        }

        public f329_lap_hop_dong_v5(DateTime ip_datetime, bool ip_trang_thai_filter)
        {
            InitializeComponent();
            set_define_events();
            string v_str = ip_datetime.ToString("MM/dd/yyyy");
            string v_str_ngay_hien_tai = DateTime.Now.ToString("MM/dd/yyyy");
            if (ip_trang_thai_filter == true)
            {
                m_grv.ActiveFilterString = "[NGAY_KET_THUC] >= #" + v_str + "# and [NGAY_KET_THUC] <= #" + v_str_ngay_hien_tai + "#";
            }
            else if (ip_trang_thai_filter == false)
            {
                m_grv.ActiveFilterString = "[NGAY_KET_THUC] > #" + v_str_ngay_hien_tai + "# and [NGAY_KET_THUC] <= #" + v_str + "#";
            }
            this.CenterToParent();
            this.ShowDialog();
        }
        #endregion

        #region Members
        string m_output_path;
        DataRow m_dt_row;
        DS_CM_DM_TU_DIEN m_ds_cau_hinh_in = new DS_CM_DM_TU_DIEN();
        #endregion

        #region Private Method
        private string get_option_filter()
        {
            if(radioButton1.Checked == true)
            {
                return "TAT_CA";
            }
            return "MOI_NHAT";
        }
        private decimal get_thang()
        {
            return m_dat_tai_thang.DateTime.Month;
        }
        private decimal get_nam()
        {
            return m_dat_tai_thang.DateTime.Year;
        }
        private void load_data_cau_hinh_in()
        {
            US_CM_DM_TU_DIEN v_us = new US_CM_DM_TU_DIEN();
            v_us.FillDatasetByIdLoaiTuDien(m_ds_cau_hinh_in, CONST_ID_LOAI_TU_DIEN.CAU_HINH_IN_HD);
        }
        private string get_ten_cau_hinh(decimal ip_dc_const_id_cau_hinh)
        {
            return m_ds_cau_hinh_in.CM_DM_TU_DIEN.Where(x => x.ID == ip_dc_const_id_cau_hinh).First().TEN;
        }
        private void load_data_to_grid()
        {
            US_GD_HOP_DONG v_us = new US_GD_HOP_DONG();
            m_grc.DataSource = v_us.LayDanhSachHopDong(get_option_filter(), get_thang(), get_nam());              
        }
        private void set_initial_form_load()
        {
            load_data_cau_hinh_in();
            m_dat_tai_thang.DateTime = DateTime.Now.Date;
            US_DM_NHAN_VIEN v_us = new US_DM_NHAN_VIEN();
            
            load_data_to_grid();
        }
        private string cat_ngay_thang(Object ip_obj_dat)
        {
            if(ip_obj_dat == DBNull.Value)
            {
                return "";
            }
            DateTime v_dat = (DateTime)ip_obj_dat;
            return v_dat.Date.ToShortDateString();
        }
        private string format_so_tien(Object ip_obj_so_tien)
        {
            if(ip_obj_so_tien == DBNull.Value)
            {
                return "";
            }
            decimal v_dc_so_tien = (decimal)ip_obj_so_tien;
            return string.Format("{0:#,##0}", (double) v_dc_so_tien);
        }
        private void print_hop_dong(DataRow ip_datarow, string ip_path)
        {

            switch(ip_datarow["ID_LOAI_HOP_DONG"].ToString())
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
            CWordReport v_cwr = new CWordReport("HD_HOC_VIEC.docx", ip_str_path);
            v_cwr.AddFindAndReplace("<ten_phap_nhan>", get_ten_cau_hinh(CONST_ID_CAU_HINH_IN.TEN_PHAP_NHAN));
            v_cwr.AddFindAndReplace("<chuc_vu_dai_dien_A>", get_ten_cau_hinh(CONST_ID_CAU_HINH_IN.CHUC_VU_BEN_A));
            v_cwr.AddFindAndReplace("<dia_chi_A>", get_ten_cau_hinh(CONST_ID_CAU_HINH_IN.DIA_CHI_A));
            
            v_cwr.AddFindAndReplace("<dien_thoai_A>", get_ten_cau_hinh(CONST_ID_CAU_HINH_IN.DIEN_THOAI_A));
            v_cwr.AddFindAndReplace("<ten_tgd>", get_ten_cau_hinh(CONST_ID_CAU_HINH_IN.DAI_DIEN_BEN_A));
            v_cwr.AddFindAndReplace("<quoc_tich_tgd>", get_ten_cau_hinh(CONST_ID_CAU_HINH_IN.QUOC_TICH_DAI_DIEN_BEN_A));

            v_cwr.AddFindAndReplace("<ten_nv>", ip_datarow["HO_TEN"].ToString());
            v_cwr.AddFindAndReplace("<quoc_tich_nv>", ip_datarow["QUOC_TICH"].ToString());
            v_cwr.AddFindAndReplace("<ngay_sinh>", cat_ngay_thang(ip_datarow["NGAY_SINH_NV"]));
            v_cwr.AddFindAndReplace("<que_quan>", ip_datarow["QUE_QUAN"].ToString());
            v_cwr.AddFindAndReplace("<chuyen_mon>", ip_datarow["CHUYEN_MON"].ToString());
            v_cwr.AddFindAndReplace("<dia_chi>", ip_datarow["DIA_CHI_THUONG_TRU"].ToString());
            v_cwr.AddFindAndReplace("<so_cmt>", ip_datarow["SO_CMT"].ToString());
            v_cwr.AddFindAndReplace("<ngay_cap>", cat_ngay_thang(ip_datarow["NGAY_CAP_CMT"]));
            v_cwr.AddFindAndReplace("<noi_cap>", ip_datarow["NOI_CAP"].ToString());
            v_cwr.AddFindAndReplace("<ngay_bat_dau_hd>", cat_ngay_thang(ip_datarow["NGAY_BAT_DAU"]));
            v_cwr.AddFindAndReplace("<mo_ta_cv>", ip_datarow["GHI_CHU"].ToString());
            v_cwr.AddFindAndReplace("<ngay_hien_tai>", DateTime.Now.Day.ToString());
            v_cwr.AddFindAndReplace("<thang_hien_tai>", DateTime.Now.Month.ToString());
            v_cwr.AddFindAndReplace("<nam_hien_tai>", DateTime.Now.Year.ToString());

            

            v_cwr.Export2Word();
        }
        private void print_hop_dong_thu_viec(DataRow ip_datarow, string ip_str_path)
        {
            CWordReport v_cwr = new CWordReport("HD_THU_VIEC.docx", ip_str_path);
            v_cwr.AddFindAndReplace("<ten_phap_nhan>", get_ten_cau_hinh(CONST_ID_CAU_HINH_IN.TEN_PHAP_NHAN));
            v_cwr.AddFindAndReplace("<chuc_vu_dai_dien_A>", get_ten_cau_hinh(CONST_ID_CAU_HINH_IN.CHUC_VU_BEN_A));
            v_cwr.AddFindAndReplace("<dia_chi_A>", get_ten_cau_hinh(CONST_ID_CAU_HINH_IN.DIA_CHI_A));
            v_cwr.AddFindAndReplace("<dien_thoai_A>", get_ten_cau_hinh(CONST_ID_CAU_HINH_IN.DIEN_THOAI_A));
            v_cwr.AddFindAndReplace("<ten_tgd>", get_ten_cau_hinh(CONST_ID_CAU_HINH_IN.DAI_DIEN_BEN_A));
            v_cwr.AddFindAndReplace("<quoc_tich_tgd>", get_ten_cau_hinh(CONST_ID_CAU_HINH_IN.QUOC_TICH_DAI_DIEN_BEN_A));

            v_cwr.AddFindAndReplace("<ten_nv>", ip_datarow["HO_TEN"].ToString());
            v_cwr.AddFindAndReplace("<quoc_tich_nv>", ip_datarow["QUOC_TICH"].ToString());
            v_cwr.AddFindAndReplace("<ngay_sinh>", cat_ngay_thang(ip_datarow["NGAY_SINH_NV"]));
            v_cwr.AddFindAndReplace("<que_quan>", ip_datarow["QUE_QUAN"].ToString());
            v_cwr.AddFindAndReplace("<chuyen_mon>", ip_datarow["CHUYEN_MON"].ToString());
            v_cwr.AddFindAndReplace("<dia_chi>", ip_datarow["DIA_CHI_THUONG_TRU"].ToString());
            v_cwr.AddFindAndReplace("<so_cmt>", ip_datarow["SO_CMT"].ToString());
            v_cwr.AddFindAndReplace("<ngay_cap>", cat_ngay_thang(ip_datarow["NGAY_CAP_CMT"]));
            v_cwr.AddFindAndReplace("<noi_cap>", ip_datarow["NOI_CAP"].ToString());
            v_cwr.AddFindAndReplace("<ngay_bat_dau_hd>", cat_ngay_thang(ip_datarow["NGAY_BAT_DAU"]));
            v_cwr.AddFindAndReplace("<ngay_ket_thuc_hd>", cat_ngay_thang(ip_datarow["NGAY_KET_THUC"]));
            v_cwr.AddFindAndReplace("<chuc_vu>", ip_datarow["TEN_CHUC_VU"].ToString());
            v_cwr.AddFindAndReplace("<don_vi>", ip_datarow["TEN_DON_VI"].ToString());
            v_cwr.AddFindAndReplace("<mo_ta_cv>", ip_datarow["GHI_CHU"].ToString());
            v_cwr.AddFindAndReplace("<ma_lcd>", ip_datarow["MA_LCD"].ToString());
            v_cwr.AddFindAndReplace("<muc_lcd>", ip_datarow["MUC_LCD"].ToString());
            v_cwr.AddFindAndReplace("<so_tien_lcd>", format_so_tien(ip_datarow["SO_TIEN_LCD_THUC_TE"]));
            v_cwr.AddFindAndReplace("<ngay_hien_tai>", DateTime.Now.Day.ToString());
            v_cwr.AddFindAndReplace("<thang_hien_tai>", DateTime.Now.Month.ToString());
            v_cwr.AddFindAndReplace("<nam_hien_tai>", DateTime.Now.Year.ToString());

            decimal v_dc_id_loai_lao_dong = Convert.ToDecimal(ip_datarow["ID_LOAI_LAO_DONG"]);
            if(v_dc_id_loai_lao_dong == CONST_ID_LOAI_LAO_DONG.TRUC_TIEP)
            {
                v_cwr.AddFindAndReplace("<thoi_gian_lam_viec>", get_ten_cau_hinh(CONST_ID_CAU_HINH_IN.THOI_GIO_TRUC_TIEP));
            }
            else
            {
                v_cwr.AddFindAndReplace("<thoi_gian_lam_viec>", get_ten_cau_hinh(CONST_ID_CAU_HINH_IN.THOI_GIO_GIAN_TIEP));
            }
            v_cwr.Export2Word();
        }
        private void print_hop_dong_co_thoi_han(DataRow ip_datarow, string ip_str_path)
        {
            CWordReport v_cwr = new CWordReport("HD_XAC_DINH_THOI_HAN.docx", ip_str_path);
            v_cwr.AddFindAndReplace("<ten_phap_nhan>", get_ten_cau_hinh(CONST_ID_CAU_HINH_IN.TEN_PHAP_NHAN));
            //v_cwr.AddFindAndReplace("<ten_thong_tu_ban_hanh>", get_ten_cau_hinh(CONST_ID_CAU_HINH_IN.THONG_TU_BAN_HANH));
            v_cwr.AddFindAndReplace("<chuc_vu_dai_dien_A>", get_ten_cau_hinh(CONST_ID_CAU_HINH_IN.CHUC_VU_BEN_A));
            v_cwr.AddFindAndReplace("<dia_chi_A>", get_ten_cau_hinh(CONST_ID_CAU_HINH_IN.DIA_CHI_A));
            v_cwr.AddFindAndReplace("<dien_thoai_A>", get_ten_cau_hinh(CONST_ID_CAU_HINH_IN.DIEN_THOAI_A));
            v_cwr.AddFindAndReplace("<ten_tgd>", get_ten_cau_hinh(CONST_ID_CAU_HINH_IN.DAI_DIEN_BEN_A));
            v_cwr.AddFindAndReplace("<quoc_tich_tgd>", get_ten_cau_hinh(CONST_ID_CAU_HINH_IN.QUOC_TICH_DAI_DIEN_BEN_A));

            v_cwr.AddFindAndReplace("<loai_hop_dong>", ip_datarow["LOAI_HOP_DONG"].ToString());
            v_cwr.AddFindAndReplace("<ten_nv>", ip_datarow["HO_TEN"].ToString());
            v_cwr.AddFindAndReplace("<quoc_tich_nv>", ip_datarow["QUOC_TICH"].ToString());
            v_cwr.AddFindAndReplace("<ngay_sinh>", cat_ngay_thang(ip_datarow["NGAY_SINH_NV"]));
            v_cwr.AddFindAndReplace("<que_quan>", ip_datarow["QUE_QUAN"].ToString());
            v_cwr.AddFindAndReplace("<chuyen_mon>", ip_datarow["CHUYEN_MON"].ToString());
            v_cwr.AddFindAndReplace("<dia_chi>", ip_datarow["DIA_CHI_THUONG_TRU"].ToString());
            v_cwr.AddFindAndReplace("<so_cmt>", ip_datarow["SO_CMT"].ToString());
            v_cwr.AddFindAndReplace("<ngay_cap>", cat_ngay_thang(ip_datarow["NGAY_CAP_CMT"]));
            v_cwr.AddFindAndReplace("<noi_cap>", ip_datarow["NOI_CAP"].ToString());
            v_cwr.AddFindAndReplace("<ngay_bat_dau_hd>", cat_ngay_thang(ip_datarow["NGAY_BAT_DAU"]));
            v_cwr.AddFindAndReplace("<chuc_vu>", ip_datarow["TEN_CHUC_VU"].ToString());
            v_cwr.AddFindAndReplace("<don_vi>", ip_datarow["TEN_DON_VI"].ToString());
            v_cwr.AddFindAndReplace("<mo_ta_cv>", ip_datarow["GHI_CHU"].ToString());
            v_cwr.AddFindAndReplace("<ma_lcd>", ip_datarow["MA_LCD"].ToString());
            v_cwr.AddFindAndReplace("<muc_lcd>", ip_datarow["MUC_LCD"].ToString());
            v_cwr.AddFindAndReplace("<so_tien_lcd>", format_so_tien(ip_datarow["SO_TIEN_LCD_THUC_TE"]));
            v_cwr.AddFindAndReplace("<ngay_hien_tai>", DateTime.Now.Day.ToString());
            v_cwr.AddFindAndReplace("<thang_hien_tai>", DateTime.Now.Month.ToString());
            v_cwr.AddFindAndReplace("<nam_hien_tai>", DateTime.Now.Year.ToString());

            decimal v_dc_id_loai_lao_dong = Convert.ToDecimal(ip_datarow["ID_LOAI_LAO_DONG"]);
            if(v_dc_id_loai_lao_dong == CONST_ID_LOAI_LAO_DONG.TRUC_TIEP)
            {
                v_cwr.AddFindAndReplace("<thoi_gian_lam_viec>", get_ten_cau_hinh(CONST_ID_CAU_HINH_IN.THOI_GIO_TRUC_TIEP));
            }
            else
            {
                v_cwr.AddFindAndReplace("<thoi_gian_lam_viec>", get_ten_cau_hinh(CONST_ID_CAU_HINH_IN.THOI_GIO_GIAN_TIEP));
            }

            v_cwr.Export2Word();
        }
        private void in_hop_dong_process()
        {
            int[] v_selected_row = m_grv.GetSelectedRows();
            if(v_selected_row.Length == 0)
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
                saveFileDialog1.FileName = "HD";

                if(saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    m_output_path = Path.Combine(Path.GetDirectoryName(saveFileDialog1.FileName), Path.GetFileNameWithoutExtension(saveFileDialog1.FileName));
                    for(int i = 0; i < m_grv.GetSelectedRows().Length; i++)
                    {
                        var v_dr = m_grv.GetDataRow(m_grv.GetSelectedRows()[i]);
                        string v_output_path = m_output_path + " " + v_dr["MA_NV"];
                        print_hop_dong(v_dr, v_output_path);
                    }
                    XtraMessageBox.Show("In thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        #endregion

        //EVENTS

        private void set_define_events()
        {
            this.Load += f327_lap_hop_dong_v5_Load;
            m_cmd_insert.Click += m_cmd_insert_Click;
            m_cmd_update.Click += m_cmd_update_Click;
            m_cmd_delete.Click += m_cmd_delete_Click;
            m_cmd_print.Click += m_cmd_print_Click;
            m_cmd_refresh.Click += m_cmd_refresh_Click;
            m_cmd_chon_file.Click += M_cmd_chon_file_Click;
            m_cmd_filter.Click += m_cmd_filter_Click;
        }

        void m_cmd_filter_Click(object sender, EventArgs e)
        {
            try
            {
                load_data_to_grid();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void M_cmd_chon_file_Click(object sender, EventArgs e)
        {
            try
            {
                f002_import_hop_dong_v2 v_f = new f002_import_hop_dong_v2();
                v_f.ShowDialog();
                load_data_to_grid();
                m_grv.ActiveFilterString = "NGAY_LAP = " + DateTime.Now.Date;
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_refresh_Click(object sender, EventArgs e)
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

        void m_cmd_print_Click(object sender, EventArgs e)
        {
            try
            {
                in_hop_dong_process();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_delete_Click(object sender, EventArgs e)
        {
            try
            {
                int[] v_selected_row = m_grv.GetSelectedRows();
                if(v_selected_row.Length > 1)
                {
                    XtraMessageBox.Show("Bạn chỉ được chọn 1 dòng để xóa!", "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                int v_focused_row = m_grv.FocusedRowHandle;
                if (v_focused_row >= 0)
                {
                    string v_str_confirm = "Bạn có chắc chắn muốn xóa hợp đồng này?\nViệc xóa hợp đồng chỉ nên thực hiện khi bạn cập nhật sai.\nViệc xóa hợp đồng có thể ảnh hưởng tới các dữ liệu tiền lương đã tính trước đó!";
                    DialogResult v_dialog = XtraMessageBox.Show(v_str_confirm, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                    if (v_dialog == DialogResult.Yes)
                    {
                        decimal v_id_hop_dong = Convert.ToDecimal(m_grv.GetRowCellValue(v_focused_row, "ID"));
                        US_GD_HOP_DONG v_us = new US_GD_HOP_DONG(v_id_hop_dong);
                        v_us.Delete();
                        XtraMessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        load_data_to_grid();
                    }
                }
                else
                {
                    string v_str_error = "Bạn chưa chọn hợp đồng để xóa!";
                    XtraMessageBox.Show(v_str_error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_update_Click(object sender, EventArgs e)
        {
            try
            {
                int[] v_selected_row = m_grv.GetSelectedRows();
                if(v_selected_row.Length > 1)
                {
                    XtraMessageBox.Show("Bạn chỉ được chọn 1 dòng để sửa!", "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                int v_focused_row = m_grv.FocusedRowHandle;
                if (v_focused_row >= 0)
                {
                    var v_dr = m_grv.GetDataRow(m_grv.FocusedRowHandle);
                    f330_lap_hop_dong_v5_detail v_f = new f330_lap_hop_dong_v5_detail();
                    v_f.display_for_update(v_dr);
                    load_data_to_grid();
                }
                else
                {
                    string v_str_error = "Bạn chưa chọn dòng dữ liệu để sửa!";
                    XtraMessageBox.Show(v_str_error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
                f330_lap_hop_dong_v5_detail v_f = new f330_lap_hop_dong_v5_detail();
                v_f.display_for_insert();
                load_data_to_grid();

            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void f327_lap_hop_dong_v5_Load(object sender, EventArgs e)
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
