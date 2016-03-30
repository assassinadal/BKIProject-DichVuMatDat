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
    public partial class f303_tnk_ngoai_bang_luong : Form
    {
        #region Public Interface
        public f303_tnk_ngoai_bang_luong()
        {
            InitializeComponent();
            format_controls();
        }

        #endregion

        #region Members
        decimal m_txt_nam;
        decimal m_txt_thang;
        #endregion

        #region Data Structure
        #endregion

        #region Event Handle
        private void set_define_events()
        {
            m_cmd_search.Click +=m_cmd_search_Click;
            m_cmd_xuat_excel.Click +=m_cmd_xuat_excel_Click;
            m_cmd_insert.Click +=m_cmd_insert_Click;
            m_cmd_update.Click += m_cmd_update_Click;
            m_cmd_delete.Click += m_cmd_delete_Click;
            m_cmd_import_excel.Click += m_cmd_import_excel_Click;
            this.Load += f303_tnk_ngoai_bang_luong_Load;
            m_dat_thang.DateTimeChanged += M_dat_thang_DateTimeChanged;
        }

        private void M_dat_thang_DateTimeChanged(object sender, EventArgs e)
        {
            try
            {
                m_txt_nam = m_dat_thang.DateTime.Year;
                m_txt_thang = m_dat_thang.DateTime.Month;
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_import_excel_Click(object sender, EventArgs e)
        {
            f305_tnk_ngoai_bang_luong_xls v_f = new f305_tnk_ngoai_bang_luong_xls();
            v_f.Show();
        }

        void f303_tnk_ngoai_bang_luong_Load(object sender, EventArgs e)
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

        void m_cmd_delete_Click(object sender, EventArgs e)
        {
            string v_str_confirm = "Bạn có chắc chắn muốn xóa khoản thu nhập này";
            if (CHRM_BaseMessages.MsgBox_Confirm (v_str_confirm))
            {
                var v_dr = m_grv.GetDataRow(m_grv.FocusedRowHandle);
                US_GD_THU_NHAP_KHAC v_us = new US_GD_THU_NHAP_KHAC(CIPConvert.ToDecimal(v_dr[2].ToString()));
                v_us.Delete();
                XtraMessageBox.Show("Xóa thành công!");
                load_data_to_grid();
            }
        }

        void m_cmd_update_Click(object sender, EventArgs e)
        {
            var v_dr = m_grv.GetDataRow(m_grv.FocusedRowHandle);
            US_GD_THU_NHAP_KHAC v_us = new US_GD_THU_NHAP_KHAC(CIPConvert.ToDecimal(v_dr[2].ToString()));
            f304_tnk_ngoai_bang_luong_detail v_f = new f304_tnk_ngoai_bang_luong_detail();
            v_f.display_for_update(v_us);
            load_data_to_grid();
        }

        private void m_cmd_insert_Click(object sender, EventArgs e)
        {
            f304_tnk_ngoai_bang_luong_detail v_f = new f304_tnk_ngoai_bang_luong_detail();
            v_f.display_for_insert();
            load_data_to_grid();
        }

        private void m_cmd_search_Click(object sender, EventArgs e)
        {
            try
            {
                //if (m_txt_thang.Text.Trim() != "" && m_txt_nam.Text.Trim() != "" )
                //{
                //    load_data_to_grid();
                //}
                //else
                //{
                //    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                //}
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }        

        private void m_cmd_xuat_excel_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "xls files (*.xls)|*.xls|All files (*.*)|*.*";
                saveFileDialog1.RestoreDirectory = true;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    m_grv.ExportToXls(saveFileDialog1.FileName);
                    CHRM_BaseMessages.MsgBox_Infor(CONST_ID_MSGBOX.INFOR_LUU_BAO_CAO_THANH_CONG);
                }
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
            set_initial_form_load();
            set_define_events();
        }

        private void set_initial_form_load()
        {
            //m_txt_thang.Text = DateTime.Now.Month.ToString();
            //m_txt_nam.Text = DateTime.Now.Year.ToString
            m_dat_thang.EditValue = DateTime.Now;
            m_txt_nam = m_dat_thang.DateTime.Year;
            m_txt_thang = m_dat_thang.DateTime.Month;
        }

        private void load_data_to_grid()
        {
            CHRMCommon.make_stt(m_grv);
            DataSet v_ds = new DataSet();
            US_GD_THU_NHAP_KHAC v_us = new US_GD_THU_NHAP_KHAC();
            v_ds.Tables.Add(new DataTable());
            v_us.filldatasetTNKNgoaiBangLuong(v_ds, m_txt_thang.ToString(), m_txt_nam.ToString());
            m_grc.DataSource = v_ds.Tables[0];
        }

        #endregion

        
    }
}
