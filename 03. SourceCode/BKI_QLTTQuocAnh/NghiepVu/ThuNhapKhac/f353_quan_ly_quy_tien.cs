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
        }

        private void set_define_events()
        {
            this.Load += f353_quan_ly_quy_tien_Load;
            m_cmd_insert.Click += m_cmd_insert_Click;
            m_cmd_update.Click += m_cmd_update_Click;
            m_cmd_delete.Click += m_cmd_delete_Click;
        }

        private void load_data_to_grid()
        {
            //CHRMCommon.make_stt(m_grv);
            m_grc.DataSource = TnkQL.Instance.HienThiDanhSachQuy();
        }

        private bool check_quy_tien_dang_su_dung_yn(US_GD_QUY_THU_NHAP_KHAC v_us)
        {
            US_GD_THU_NHAP_KHAC v_us_gd_tnk = new US_GD_THU_NHAP_KHAC();
            DS_GD_THU_NHAP_KHAC v_ds_gd_tnk = new DS_GD_THU_NHAP_KHAC();
            v_us.FillDataset(v_ds_gd_tnk, "where ID_QUY_THU_NHAP_KHAC = " + v_us.dcID);
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
            DialogResult v_dialog = XtraMessageBox.Show("Bạn có chắc chắn muốn xóa quỹ tiền này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (v_dialog == DialogResult.Yes)
            {
                v_us.strDA_XOA = "Y";
                v_us.Update();
                load_data_to_grid();
            }
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
        void m_cmd_delete_Click(object sender, EventArgs e)
        {
            try
            {
                var v_dr = m_grv.GetDataRow(m_grv.FocusedRowHandle);
                US_GD_QUY_THU_NHAP_KHAC v_us = new US_GD_QUY_THU_NHAP_KHAC(CIPConvert.ToDecimal(v_dr[0].ToString()));
                if (check_quy_tien_dang_su_dung_yn(v_us))
                {
                    DialogResult v_dialog = XtraMessageBox.Show("Quỹ tiền đang được sử dụng. Bạn có muốn xóa cả khoản thu nhập đang sử dụng quỹ tiền này?", "Xác nhận", MessageBoxButtons.YesNo);
                    if (v_dialog == DialogResult.Yes)
                    {
                        xoa_thu_nhap_khac();
                        xoa_quy_tien(v_us);
                    }
                }
                else
                {
                    xoa_quy_tien(v_us);                   
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
        #endregion
    }
}
