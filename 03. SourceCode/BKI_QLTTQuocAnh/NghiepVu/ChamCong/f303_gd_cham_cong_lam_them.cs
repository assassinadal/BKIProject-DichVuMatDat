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
using System.IO;
using DevExpress.XtraEditors;

namespace BKI_DichVuMatDat.NghiepVu
{
    public partial class f303_gd_cham_cong_lam_them : Form
    {

        #region Members
        US_GD_CHAM_CONG_LAM_THEM m_us = new US_GD_CHAM_CONG_LAM_THEM();
        #endregion

        #region Public Interface
        public f303_gd_cham_cong_lam_them()
        {
            InitializeComponent();
            set_initial_form_load();
        }
        #endregion

        #region Private method
        private void set_initial_form_load()
        {
            m_txt_thang.Text = DateTime.Now.Month.ToString();
            m_txt_nam.Text = DateTime.Now.Year.ToString();
            set_trang_thai_cham_cong();
            set_define_events();
        }

        private void set_trang_thai_cham_cong()
        {
            m_lbl_trang_thai_cham_cong.Text = "Đã chấm công cho " + get_so_luong_cham_cong() + " nhân viên.";
            //m_grc.DataSource = null;
        }

        private decimal get_so_luong_cham_cong()
        {
            US_GD_CHAM_CONG_LAM_THEM v_us = new US_GD_CHAM_CONG_LAM_THEM();
            DS_GD_CHAM_CONG_LAM_THEM v_ds = new DS_GD_CHAM_CONG_LAM_THEM();
            v_us.FillDatasetGetChamCongTheoThang(v_ds, m_txt_thang.Text, m_txt_nam.Text);
            return v_ds.Tables[0].Rows.Count;
        }

        private bool check_bang_luong_da_chot(string ip_thang, string ip_nam)
        {
            US_RPT_CHOT_BANG_LUONG v_us = new US_RPT_CHOT_BANG_LUONG();
            if (v_us.IsLockBangLuong(decimal.Parse(ip_thang), decimal.Parse(ip_nam)))
                return true;
            else return false;
        }

        private bool kiem_tra_du_lieu()
        {
            if (m_txt_thang.Text.Trim() == "" || m_txt_nam.Text.Trim() == "")
            {
                XtraMessageBox.Show("Vui lòng nhập tháng và năm chấm công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (check_ma_nhan_vien_ko_ton_tai())
                return false;
            else if (check_ma_nhan_vien_duplicate())
                return false;
            else if (check_so_ngay_lam_them_sai())             
                return false;
            return true;
        }

        private void save_data()
        {
            splashScreenManager1.ShowWaitForm();
            delete_du_lieu_cu();
            insert_gd_cham_cong_lam_them();
            splashScreenManager1.CloseWaitForm();
            XtraMessageBox.Show("Lưu thành công");
            m_cmd_luu_cham_cong_lam_them.Enabled = false;
            m_grc.DataSource = null;
        }

        private void delete_du_lieu_cu()
        {
            US_GD_CHAM_CONG_LAM_THEM v_us = new US_GD_CHAM_CONG_LAM_THEM();
            v_us.BeginTransaction();
            m_us = v_us;
            v_us.DeleteAllChamCongLamThemThang(Convert.ToDecimal(m_txt_thang.Text), Convert.ToDecimal(m_txt_nam.Text));
        }

        private void insert_gd_cham_cong_lam_them()
        {
            for (int i = 0; i < m_grv.RowCount; i++)
            {
                var v_dr = m_grv.GetDataRow(i);
                US_GD_CHAM_CONG_LAM_THEM v_us = new US_GD_CHAM_CONG_LAM_THEM();
                v_us.dcID_NHAN_VIEN = get_id_nv_by_ma_nv(v_dr[0].ToString());
                v_us.dcTHANG = decimal.Parse(m_txt_thang.Text);
                v_us.dcNAM = decimal.Parse(m_txt_nam.Text);
                v_us.dcSO_NGAY_LAM_THEM = decimal.Parse(v_dr[4].ToString());
                v_us.UseTransOfUSObject(m_us);
                m_us = v_us;
                v_us.Insert();
            }
            m_us.CommitTransaction();
        }

        private decimal get_id_nv_by_ma_nv(string ip_str_ma_nv)
        {
            US_DM_NHAN_VIEN v_us = new US_DM_NHAN_VIEN();
            return v_us.getIDNhanVienByMaNV(ip_str_ma_nv);
        }

        private bool check_so_ngay_lam_them_sai()
        {
            List<string> v_lst_nv_cham_cong_sai = new List<string>();
            for (int i = 0; i < m_grv.RowCount; i++)
            {
                var v_dr = m_grv.GetDataRow(i);
                decimal v_dc_so_ngay_lam_them;
                if (!decimal.TryParse(v_dr[4].ToString(), out v_dc_so_ngay_lam_them))
                    v_lst_nv_cham_cong_sai.Add(v_dr[0].ToString());
            }
            if (v_lst_nv_cham_cong_sai.Count == 0)
                return false;
            else
            {
                string v_str = "Vui lòng kiểm tra lại số ngày làm thêm của nhân viên '" + string.Join(",", v_lst_nv_cham_cong_sai) + "'";
                XtraMessageBox.Show(v_str, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
        }

        private bool check_ma_nhan_vien_ko_ton_tai()
        {
            List<string> v_lst_nv_ko_ton_tai = new List<string>();
            for (int i = 0; i < m_grv.RowCount; i++)
            {
                var v_dr = m_grv.GetDataRow(i);
                US_DM_NHAN_VIEN v_us = new US_DM_NHAN_VIEN();
                if (!v_us.IsExistNhanVienInDB(v_dr[0].ToString()))
                    v_lst_nv_ko_ton_tai.Add(v_dr[0].ToString());
            }
            if (v_lst_nv_ko_ton_tai.Count == 0)
                return false;
            else
            {
                string v_str = "Mã nhân viên '" + string.Join(",", v_lst_nv_ko_ton_tai) + "' không tồn tại. \nVui lòng kiểm tra lại!";
                XtraMessageBox.Show(v_str, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
        }

        private bool check_ma_nhan_vien_duplicate()
        {
            DataTable v_dt = new DataTable();
            v_dt.Columns.Add();
            for (int i = 0; i < m_grv.RowCount; i++)
            {
                var v_dr = m_grv.GetDataRow(i);
                v_dt.Rows.Add(v_dr[0]);
            }
            var duplicate = v_dt.AsEnumerable().GroupBy(r => r[0]).Where(gr => gr.Count() > 1).ToList();
            if (duplicate.Any())
            {
                string v_str = "Mã nhân viên '" + string.Join(",", duplicate.Select(dupl => dupl.Key)) + "' đang bị trùng. \nVui lòng kiểm tra lại!";
                XtraMessageBox.Show(v_str, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }
        #endregion

        #region Events Handle

        private void set_define_events()
        {
            m_cmd_tai_file_mau.Click += m_cmd_tai_file_mau_Click;
            m_cmd_chon_du_lieu.Click += m_cmd_chon_du_lieu_Click;
            m_cmd_luu_cham_cong_lam_them.Click += m_cmd_luu_cham_cong_lam_them_Click;
            m_txt_thang.EditValueChanged += m_txt_thang_EditValueChanged;
            m_txt_nam.EditValueChanged += m_txt_nam_EditValueChanged;
        }

        void m_txt_nam_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                set_trang_thai_cham_cong();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_txt_thang_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                set_trang_thai_cham_cong();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_luu_cham_cong_lam_them_Click(object sender, EventArgs e)
        {
            try
            {
                if (check_bang_luong_da_chot(m_txt_thang.Text, m_txt_nam.Text))
                    XtraMessageBox.Show("Tháng đã chốt bảng lương. \nVui lòng ko cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                else if (kiem_tra_du_lieu())
                {
                    string v_str = "Việc import sẽ xóa dữ liệu cũ đã có trong tháng này và thêm dữ liệu mới từ file excel vừa import.\nBạn có chắc chắn muốn thực hiện?";
                    DialogResult v_dialog = XtraMessageBox.Show(v_str, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (v_dialog == DialogResult.Yes)
                    {
                        save_data();
                        set_trang_thai_cham_cong();
                    }
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_chon_du_lieu_Click(object sender, EventArgs e)
        {
            try
            {
                string source_file = WinFormControls.openFileDialog();
                if (source_file != "")
                {
                    WinFormControls.load_xls_to_gridview(source_file, m_grc);
                    CHRMCommon.make_stt_indicator(m_grv);
                    m_cmd_luu_cham_cong_lam_them.Enabled = true;
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_tai_file_mau_Click(object sender, EventArgs e)
        {
            try
            {
                WinFormControls.openTemplate_v2("ChamCongLamThem.xls");
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        #endregion 

    }
}
