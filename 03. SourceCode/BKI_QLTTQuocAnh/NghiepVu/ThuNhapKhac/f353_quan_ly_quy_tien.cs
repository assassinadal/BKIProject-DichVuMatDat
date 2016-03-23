using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using BKI_DichVuMatDat;
using BKI_DichVuMatDat.DS;
using BKI_DichVuMatDat.US;
using BKI_DichVuMatDat.DS.CDBNames;

using System.Globalization;
using DevExpress.XtraEditors;
using IP.Core.IPCommon;
using IP.Core.IPSystemAdmin;
namespace BKI_DichVuMatDat.NghiepVu.ThuNhapKhac
{
    public partial class f353_quan_ly_quy_tien : Form
    {
        #region Public Interface
        public f353_quan_ly_quy_tien()
        {
            InitializeComponent();
            set_init_form_load();
        }
        #endregion

        #region Members
        DataEntryFormMode m_e_form_mode;
        US_GD_THU_NHAP_KHAC m_us_gd_tnk = new US_GD_THU_NHAP_KHAC();
        DataTable m_dt_thu_nhap_khac = new DataTable();
        #endregion

        #region Private Method

        private void set_init_form_load()
        {
            m_dat_tu_thang.DateTime = DateTime.Now.AddMonths(1-DateTime.Now.Month);
            m_dat_den_thang.DateTime = DateTime.Now;
            set_define_events();            
        }

        private void load_data_to_grid()
        {
            CHRMCommon.make_stt_indicator(m_grv);
            US_GD_QUY_THU_NHAP_KHAC v_us = new US_GD_QUY_THU_NHAP_KHAC();
            DS_GD_QUY_THU_NHAP_KHAC v_ds = new DS_GD_QUY_THU_NHAP_KHAC();
            v_us.FillDatasetQuyTNK(v_ds, m_dat_tu_thang.DateTime, m_dat_den_thang.DateTime);
            m_grc.DataSource = v_ds.Tables[0];
        }

        private bool check_quy_tien_dang_su_dung_yn(US_GD_QUY_THU_NHAP_KHAC v_us)
        {
            m_dt_thu_nhap_khac.Clear();
            US_GD_THU_NHAP_KHAC v_us_gd_tnk = new US_GD_THU_NHAP_KHAC();
            DS_GD_THU_NHAP_KHAC v_ds_gd_tnk = new DS_GD_THU_NHAP_KHAC();
            v_us_gd_tnk.LayDuLieuThuNhapKhacTheoIDQuy(v_ds_gd_tnk, v_us.dcID);
            if (v_ds_gd_tnk.Tables[0].Rows.Count != 0)
            {
                m_dt_thu_nhap_khac = v_ds_gd_tnk.Tables[0];
                return true;
            }
            else return false;
        }

        private void delete_gd_quy_tien(US_GD_QUY_THU_NHAP_KHAC v_us)
        {
            v_us.strDA_XOA = "Y";
            v_us.Update();
        }

        private void delete_gd_thu_nhap_khac(US_GD_QUY_THU_NHAP_KHAC v_us_gd_quy_tnk)
        {
            US_GD_THU_NHAP_KHAC v_us = new US_GD_THU_NHAP_KHAC();
            DS_GD_THU_NHAP_KHAC v_ds = new DS_GD_THU_NHAP_KHAC();
            v_us.XoaTNKTheoIDQuy(v_us_gd_quy_tnk.dcID);
            //for (int i = 0; i < m_dt_thu_nhap_khac.Rows.Count; i++)
            //{
            //    US_GD_THU_NHAP_KHAC v_us = new US_GD_THU_NHAP_KHAC(decimal.Parse(m_dt_thu_nhap_khac.Rows[i][0].ToString()));
            //    v_us.Delete();
            //}
        }

        private bool check_quy_tien_da_chot_yn(string ip_thang, string ip_nam)
        {
            US_RPT_CHOT_BANG_LUONG v_us = new US_RPT_CHOT_BANG_LUONG();
            if (v_us.IsLockBangLuong(decimal.Parse(ip_thang), decimal.Parse(ip_nam)))
                return true;
            else return false;
        }

        private void xoa_quy_tien(US_GD_QUY_THU_NHAP_KHAC v_us)
        {
            if (check_quy_tien_dang_su_dung_yn(v_us))
            {
                int v_slg_nvien = m_dt_thu_nhap_khac.Rows.Count;
                string v_str_confirms = "Quỹ tiền đang được sử dụng cho " + v_slg_nvien + " nhân viên.\nBạn có muốn xóa cả khoản thu nhập của " + v_slg_nvien + " nhân viên đang sử dụng quỹ tiền này?";
                DialogResult v_dialog = XtraMessageBox.Show(v_str_confirms, "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (v_dialog == DialogResult.No)
                    return;
            }
            delete_gd_thu_nhap_khac(v_us);
            delete_gd_quy_tien(v_us);
            XtraMessageBox.Show("Đã xóa thành công!");
        }

        #endregion

        #region Event Handle
        private void set_define_events()
        {
            m_cmd_insert.Click += m_cmd_insert_Click;
            m_cmd_update.Click += m_cmd_update_Click;
            m_cmd_delete.Click += m_cmd_delete_Click;
            m_cmd_search.Click += m_cmd_search_Click;
            m_grc.DoubleClick += m_grc_DoubleClick;
            this.Load += f353_quan_ly_quy_tien_Load;
            //m_grc.Click += m_grc_Click;
        }

        void f353_quan_ly_quy_tien_Load(object sender, EventArgs e)
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

        //void m_grc_Click(object sender, EventArgs e)
        //{
        //    var v_dr = m_grv.GetDataRow(m_grv.FocusedRowHandle);
        //    US_GD_THU_NHAP_KHAC v_us = new US_GD_THU_NHAP_KHAC();
        //    DS_GD_THU_NHAP_KHAC v_ds = new DS_GD_THU_NHAP_KHAC();
        //    v_us.FillDatasetTheoQuyThangNam(v_ds, v_dr[0].ToString(), v_dr[2].ToString(), v_dr[3].ToString());
        //    //v_us.FillDataset(v_ds, "where ID_QUY_THU_NHAP_KHAC =" + v_dr[0].ToString() + "and thang=" + v_dr[2].ToString() + "and nam=" + v_dr[3].ToString());
        //    int v_slg_nv = v_ds.Tables[0].Rows.Count;
        //    decimal v_tong_so_tien=0;
        //    for (int i = 0; i < v_ds.Tables[0].Rows.Count; i++)
        //    {
        //        v_tong_so_tien += decimal.Parse(v_ds.Tables[0].Rows[i][7].ToString());
        //    }
        //    m_lbl_trang_thai_quy.Text = "Quỹ đã chi tiền cho " + v_slg_nv + " nhân viên. Tổng tiền: " + v_tong_so_tien;
        //}

        void m_cmd_search_Click(object sender, EventArgs e)
        {
            try
            {
                load_data_to_grid();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e) ;
            }
        }

        void m_grc_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var v_dr = m_grv.GetDataRow(m_grv.FocusedRowHandle);
                decimal v_id_quy_tnk = CIPConvert.ToDecimal(v_dr[0].ToString());
                f355_tnk_chi_tiet_quy_thu_nhap_khac v_f = new f355_tnk_chi_tiet_quy_thu_nhap_khac(v_id_quy_tnk);
                v_f.ShowDialog();
                load_data_to_grid();
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
                var v_dr = m_grv.GetDataRow(m_grv.FocusedRowHandle);
                if (m_grv.FocusedRowHandle < 0)
                    XtraMessageBox.Show("Bạn chưa chọn dòng dữ liệu để sửa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (check_quy_tien_da_chot_yn(v_dr[2].ToString(), v_dr[3].ToString()))
                    XtraMessageBox.Show("Bạn không thể xóa quỹ tiền đã chốt!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                else
                {
                    US_GD_QUY_THU_NHAP_KHAC v_us = new US_GD_QUY_THU_NHAP_KHAC(CIPConvert.ToDecimal(v_dr[0].ToString()));
                    string v_str_confirm = "Bạn có chắc chắn muốn xóa quỹ tiền này?";
                    DialogResult v_dialog = XtraMessageBox.Show(v_str_confirm,"Xác nhận",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                    if (v_dialog == DialogResult.Yes)
                    {
                        xoa_quy_tien(v_us);
                        load_data_to_grid();
                    }
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
                var v_dr = m_grv.GetDataRow(m_grv.FocusedRowHandle);
                US_GD_QUY_THU_NHAP_KHAC v_us = new US_GD_QUY_THU_NHAP_KHAC(CIPConvert.ToDecimal(v_dr[0].ToString()));
                if (m_grv.FocusedRowHandle < 0)
                    XtraMessageBox.Show("Bạn chưa chọn dòng dữ liệu để sửa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);               
                //else if (check_quy_tien_da_chot_yn(v_dr[2].ToString(), v_dr[3].ToString()))
                //    XtraMessageBox.Show("Quỹ tiền hiện đã chốt. Vui lòng không cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                //else if (check_quy_tien_dang_su_dung_yn(v_us))
                //    XtraMessageBox.Show("Quỹ đã chi tiền cho nhân viên, vui lòng không cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                else
                {
                    f354_danh_sach_quy_thuong_de v_f = new f354_danh_sach_quy_thuong_de();                  
                    v_f.display_for_update(v_us);
                    load_data_to_grid();
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
                f354_danh_sach_quy_thuong_de v_f = new f354_danh_sach_quy_thuong_de();
                v_f.display_for_insert();
                load_data_to_grid();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
      
        #endregion
    }
}
