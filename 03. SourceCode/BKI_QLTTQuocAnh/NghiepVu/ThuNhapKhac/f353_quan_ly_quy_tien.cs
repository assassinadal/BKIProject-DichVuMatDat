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
        List<decimal> m_lst_id_gd_thu_nhap_khac = new List<decimal>();
        #endregion

        #region Private Method

        private void set_init_form_load()
        {
            set_define_events();
            m_txt_thang.Text = DateTime.Now.Month.ToString();
            m_txt_nam.Text = DateTime.Now.Year.ToString();
        }

        private void load_data_to_grid()
        {
            CHRMCommon.make_stt(m_grv);
            m_grc.DataSource = TnkQL.Instance.HienThiDanhSachQuy(m_txt_thang.Text, m_txt_nam.Text);
        }

        private bool check_quy_tien_dang_su_dung_yn(US_GD_QUY_THU_NHAP_KHAC v_us)
        {
            US_GD_THU_NHAP_KHAC v_us_gd_tnk = new US_GD_THU_NHAP_KHAC();
            DS_GD_THU_NHAP_KHAC v_ds_gd_tnk = new DS_GD_THU_NHAP_KHAC();
            v_us_gd_tnk.FillDataset(v_ds_gd_tnk, "where ID_QUY_THU_NHAP_KHAC = " + v_us.dcID);
            if (v_ds_gd_tnk.Tables[0].Rows.Count != 0)
            {
                for (int i = 0; i < v_ds_gd_tnk.Tables[0].Rows.Count; i++)
                {
                    m_lst_id_gd_thu_nhap_khac.Add(CIPConvert.ToDecimal(v_ds_gd_tnk.Tables[0].Rows[i][0].ToString()));
                }
                return true;
            }
            else return false;
        }

        private void xoa_quy_tien(US_GD_QUY_THU_NHAP_KHAC v_us)
        {
            v_us.strDA_XOA = "Y";
            v_us.Update();
            load_data_to_grid();
        }

        private void xoa_thu_nhap_khac()
        {
            foreach (var item in m_lst_id_gd_thu_nhap_khac)
            {
                US_GD_THU_NHAP_KHAC v_us = new US_GD_THU_NHAP_KHAC(item);
                v_us.Delete();
            }
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
            m_grc.Click += m_grc_Click;
        }

        void m_grc_Click(object sender, EventArgs e)
        {
            try
            {
                var v_dr = m_grv.GetDataRow(m_grv.FocusedRowHandle);
                US_GD_THU_NHAP_KHAC v_us = new US_GD_THU_NHAP_KHAC();
                DS_GD_THU_NHAP_KHAC v_ds = new DS_GD_THU_NHAP_KHAC();
                v_us.FillDatasetTheoQuyThangNam(v_ds, v_dr[0].ToString(), v_dr[2].ToString(), v_dr[3].ToString());
                //v_us.FillDataset(v_ds, "where ID_QUY_THU_NHAP_KHAC =" + v_dr[0].ToString() + "and thang=" + v_dr[2].ToString() + "and nam=" + v_dr[3].ToString());
                int v_slg_nv = v_ds.Tables[0].Rows.Count;
                decimal v_tong_so_tien = 0;
                for(int i = 0; i < v_ds.Tables[0].Rows.Count; i++)
                {
                    v_tong_so_tien += decimal.Parse(v_ds.Tables[0].Rows[i][7].ToString());
                }
                m_lbl_trang_thai_quy.Text = "Quỹ đã chi tiền cho " + v_slg_nv + " nhân viên. Tổng tiền: " + v_tong_so_tien;
            }
            catch(Exception v_e)
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
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_delete_Click(object sender, EventArgs e)
        {
            try
            {
                var v_dr = m_grv.GetDataRow(m_grv.FocusedRowHandle);
                US_GD_QUY_THU_NHAP_KHAC v_us = new US_GD_QUY_THU_NHAP_KHAC(CIPConvert.ToDecimal(v_dr[0].ToString()));
                if (check_quy_tien_dang_su_dung_yn(v_us))
                {
                    int v_slg_nvien = m_lst_id_gd_thu_nhap_khac.Count;
                    string v_str_confirm = "Quỹ tiền đang được sử dụng cho " + v_slg_nvien + " nhân viên.\nBạn có muốn xóa khoản thu nhập của " + v_slg_nvien + " nhân viên đang sử dụng quỹ tiền này?";
                    if (CHRM_BaseMessages.MsgBox_Confirm(v_str_confirm))
                    {
                        xoa_thu_nhap_khac();
                        xoa_quy_tien(v_us);
                    }
                }
                else
                {
                    string v_str_confirm = "Bạn có chắc chắn muốn xóa quỹ tiền này?";
                    if (CHRM_BaseMessages.MsgBox_Confirm(v_str_confirm))
                    {
                        xoa_quy_tien(v_us);
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
                f354_danh_sach_quy_thuong_de v_f = new f354_danh_sach_quy_thuong_de();
                var v_dr = m_grv.GetDataRow(m_grv.FocusedRowHandle);
                US_GD_QUY_THU_NHAP_KHAC v_us = new US_GD_QUY_THU_NHAP_KHAC(CIPConvert.ToDecimal(v_dr[0].ToString()));
                v_f.display_for_update(v_us);
                load_data_to_grid();
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
