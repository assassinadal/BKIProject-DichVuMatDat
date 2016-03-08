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
using IP.Core.IPCommon;
using BKI_DichVuMatDat.DS.CDBNames;
using DevExpress.XtraEditors;
using System.Globalization;

namespace BKI_DichVuMatDat.NghiepVu.ThuNhapKhac
{
    public partial class f305_tnk_ngoai_bang_luong_xls : Form
    {
       
        #region Public Interface
        public f305_tnk_ngoai_bang_luong_xls()
        {
            InitializeComponent();
            format_controls();
        }
    
        #endregion

        #region Members
        US_GD_THU_NHAP_KHAC m_us = new US_GD_THU_NHAP_KHAC();
        #endregion

        #region Data Structure
        #endregion

        #region Event Handle
        private void set_define_events()
        {
            m_cmd_tai_file_mau.Click += m_cmd_tai_file_mau_Click;
            m_cmd_import_excel.Click +=m_cmd_import_excel_Click;
            m_cmd_luu.Click +=m_cmd_luu_Click;
            this.Load += f305_tnk_ngoai_bang_luong_xls_Load;
            //m_sle_quy_tien.EditValueChanged += m_sle_quy_tien_EditValueChanged;
        }

        //void m_sle_quy_tien_EditValueChanged(object sender, EventArgs e)
        //{
        //    US_GD_THU_NHAP_KHAC v_us = new US_GD_THU_NHAP_KHAC();
        //    DS_GD_THU_NHAP_KHAC v_ds = new DS_GD_THU_NHAP_KHAC();
        //    v_us.FillDatasetTheoQuyThangNam(v_ds, m_sle_quy_tien.EditValue.ToString(), m_dat_thang.DateTime.Month.ToString(), m_dat_thang.DateTime.Year.ToString());
        //    //v_us.FillDataset(v_ds, "where ID_QUY_THU_NHAP_KHAC =" +m_sle_quy_tien.EditValue.ToString()+ "and thang=" + m_dat_thang.DateTime.Month + "and nam=" + m_dat_thang.DateTime.Year);
        //    int v_slg_nv = v_ds.Tables[0].Rows.Count;
        //    decimal v_tong_so_tien = 0;
        //    for (int i = 0; i < v_ds.Tables[0].Rows.Count; i++)
        //    {
        //        v_tong_so_tien += decimal.Parse(v_ds.Tables[0].Rows[i][7].ToString());
        //    }
        //    m_lbl_trang_thai.Text += "\n Quỹ đã chi tiền cho " + v_slg_nv + " nhân viên. Tổng tiền: " + v_tong_so_tien;
        //}

        void f305_tnk_ngoai_bang_luong_xls_Load(object sender, EventArgs e)
        {
            try
            {
                set_initial_form_load();
                load_data_to_sle_quy_tien();
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
                WinFormControls.openTemplate("ThuNhapKhac.xlsx");
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_luu_Click(object sender, EventArgs e)
        {
            try
            {
                if (m_sle_quy_tien.EditValue == null)
                    CHRM_BaseMessages.MsgBox_Error("Vui lòng chọn quỹ tiền cần chi!");
                else
                {
                    save_data();
                    XtraMessageBox.Show("Lưu thành công!");
                    m_grc.DataSource = null;
                    m_cmd_luu.Enabled = false;
                    m_lbl_trang_thai.Text = "";
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }


        void m_cmd_import_excel_Click(object sender, EventArgs e)
        {
            try
            {
                m_grc.DataSource = null;
                WinFormControls.load_xls_to_gridview(WinFormControls.openFileDialog(), m_grc);
                m_cmd_luu.Enabled = true;
                //m_lbl_trang_thai.Text += "\n File excel đã được import...";
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }


        #endregion

        #region Private Method
        private void format_controls()
        {
            set_define_events();
        }

        private void set_initial_form_load()
        {
            m_dat_thang.DateTime = DateTime.Now;
        }

        private void load_data_to_sle_quy_tien()
        {
            US_GD_QUY_THU_NHAP_KHAC v_us = new US_GD_QUY_THU_NHAP_KHAC();
            DS_GD_QUY_THU_NHAP_KHAC v_ds = new DS_GD_QUY_THU_NHAP_KHAC();
            v_us.FillDatasetQuyTNKbyIDLoaiQuy(v_ds, 756);
            m_sle_quy_tien.Properties.DataSource = v_ds.Tables[0];
        }

        private void save_data()
        {
            for (int i = 0; i < m_grv.RowCount; i++)
            {
                var v_dr = m_grv.GetDataRow(i);
                US_GD_THU_NHAP_KHAC v_us = new US_GD_THU_NHAP_KHAC();
                v_us.dcID_NHAN_VIEN = get_id_nhan_vien_by_ma_nv(v_dr[1].ToString());
                v_us.dcTHANG = m_dat_thang.DateTime.Month;
                v_us.dcNAM = m_dat_thang.DateTime.Year;
                v_us.dcHE_SO = 0;
                v_us.dcSO_TIEN = return_so_tien(v_dr[4].ToString());
                v_us.dcSO_TIEN_NOP_THUE = return_so_tien(v_dr[5].ToString());
                v_us.dcSO_TIEN_THUC_LINH = return_so_tien(v_dr[6].ToString());
                v_us.dcID_LOAI_THU_NHAP_KHAC = 756;
                v_us.dcID_QUY_THU_NHAP_KHAC = decimal.Parse(m_sle_quy_tien.EditValue.ToString());
                if (i == 0)
                    v_us.BeginTransaction();
                else
                {
                    v_us.UseTransOfUSObject(m_us);
                }
                m_us = v_us;
                v_us.Insert();
            }
            m_us.CommitTransaction();
        }

        private decimal return_so_tien(string ip_str_so_tien)
        {
            if (ip_str_so_tien == "")
                return 0;
            else
                return decimal.Parse(ip_str_so_tien);
        }

        private decimal get_id_nhan_vien_by_ma_nv(string ip_str_ma_nv)
        {
            US_DM_NHAN_VIEN v_us = new US_DM_NHAN_VIEN();
            DS_DM_NHAN_VIEN v_ds = new DS_DM_NHAN_VIEN();
            v_us.FillDataset(v_ds, "where ma_nv =" + ip_str_ma_nv);
            return decimal.Parse(v_ds.Tables[0].Rows[0][0].ToString());          
        }

        private void load_data_to_grid()
        {
            //CHRMCommon.make_stt(m_grv);
            //DataSet v_ds = new DataSet();
            //US_GD_THU_NHAP_KHAC v_us = new US_GD_THU_NHAP_KHAC();
            //v_ds.Tables.Add(new DataTable());
            //v_us.filldatasetTNKNgoaiBangLuong(v_ds, m_txt_thang.Text, m_txt_nam.Text);
            //m_grc.DataSource = v_ds.Tables[0];
        }

        #endregion
    }
}
