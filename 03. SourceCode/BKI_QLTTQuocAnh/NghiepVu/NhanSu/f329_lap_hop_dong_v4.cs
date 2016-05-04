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
using BKI_DichVuMatDat.US;
using BKI_DichVuMatDat.DS;
using BKI_DichVuMatDat.DS.CDBNames;
using DevExpress.XtraEditors;
using BKI_DichVuMatDat.NghiepVu.HopDong;
using System.IO;
using IP.Core.IPWordReport;

namespace BKI_DichVuMatDat.NghiepVu.NhanSu
{
    public partial class f329_lap_hop_dong_v4 : Form
    {
        #region Public Interface
        public f329_lap_hop_dong_v4()
        {
            InitializeComponent();
            set_define_events();
        }

        public f329_lap_hop_dong_v4(DateTime ip_datetime, bool ip_trang_thai_filter)
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
        private void load_data_to_grid()
        {
            US_GD_HOP_DONG v_us = new US_GD_HOP_DONG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            //m_grc.DataSource = v_us.LayDanhSachHopDong(get_option_filter(), );              
        }

        private void delete_gd_lcd(decimal v_id_hop_dong)
        {
            //US_GD_LUONG_CHE_DO v_us = new US_GD_LUONG_CHE_DO();
            //DS_GD_LUONG_CHE_DO v_ds = new DS_GD_LUONG_CHE_DO();
            //v_us.FillDataset(v_ds, "where id_hop_dong = " + v_id_hop_dong);
            //for (int i = 0; i < v_ds.Tables[0].Rows.Count; i++)
            //{
            //    decimal v_id_gd_lcd = Convert.ToDecimal(v_ds.Tables[0].Rows[i]["ID"]);
            //    v_us = new US_GD_LUONG_CHE_DO(v_id_gd_lcd);
            //    v_us.Delete();
            //}
        }

        private void delete_gd_he_so_lns(decimal v_id_hop_dong)
        {
            //US_GD_HE_SO_LNS v_us = new US_GD_HE_SO_LNS();
            //DS_GD_HE_SO_LNS v_ds = new DS_GD_HE_SO_LNS();
            //v_us.FillDataset(v_ds, "where id_hop_dong = " + v_id_hop_dong);
            //for (int i = 0; i < v_ds.Tables[0].Rows.Count; i++)
            //{
            //    decimal v_id_gd_lns = Convert.ToDecimal(v_ds.Tables[0].Rows[i]["ID"]);
            //    v_us = new US_GD_HE_SO_LNS(v_id_gd_lns);
            //    v_us.Delete();
            //}
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
            v_cwr.AddFindAndReplace("<ten_tgd>", m_dt_row["HO_TEN_TGD"].ToString());
            v_cwr.AddFindAndReplace("<quoc_tich_tgd>", m_dt_row["QUOC_TICH"].ToString());
            v_cwr.AddFindAndReplace("<ten_nv>", ip_datarow["HO_TEN_NV"].ToString());
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
            v_cwr.AddFindAndReplace("<ten_nv>", ip_datarow["HO_TEN_NV"].ToString());
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
            v_cwr.AddFindAndReplace("<chuc_vu>", ip_datarow["TEN_CHUC_VU"].ToString());
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
                    XtraMessageBox.Show("In thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        #endregion

        //EVENTS

        private void set_define_events()
        {
            this.Load += f327_lap_hop_dong_v3_Load;
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
                f001_import_hop_dong v_f = new f001_import_hop_dong();
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
                        //delete_gd_he_so_lns(v_id_hop_dong);
                        //delete_gd_lcd(v_id_hop_dong);
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
                    XtraMessageBox.Show("Bạn chỉ được chọn 1 dòng để xóa!", "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                int v_focused_row = m_grv.FocusedRowHandle;
                if (v_focused_row >= 0)
                {
                    var v_dr = m_grv.GetDataRow(m_grv.FocusedRowHandle);
                    f330_lap_hop_dong_v4_detail v_f = new f330_lap_hop_dong_v4_detail();
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
                f330_lap_hop_dong_v4_detail v_f = new f330_lap_hop_dong_v4_detail();
                v_f.display_for_insert();
                load_data_to_grid();

            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void f327_lap_hop_dong_v3_Load(object sender, EventArgs e)
        {
            try
            {
                US_DM_NHAN_VIEN v_us = new US_DM_NHAN_VIEN();
                m_dt_row = v_us.GetThongTinTGD();
                load_data_to_grid();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
    }
}
