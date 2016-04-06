using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using IP.Core.IPCommon;
using BKI_DichVuMatDat.US;
namespace BKI_DichVuMatDat.NghiepVu.ThuNhapKhac
{
    public partial class f302_option_detail_calculate : Form
    {
        private option_tinh_tnk _option = option_tinh_tnk.CHUA_CHON;
        private decimal _so_tien = 0;
        private decimal _phan_tram_thue = 0;
        private bool is_nguoi_dung_an_tiep_tuc = false;
        public f302_option_detail_calculate()
        {
            InitializeComponent();

        }
        public void Display(out option_tinh_tnk op_option, out decimal op_so_tien, out decimal op_phan_tram_thue)
        {
            ShowDialog();
            op_option = _option;
            op_so_tien = _so_tien;
            op_phan_tram_thue = _phan_tram_thue;
        }
        private void lay_option()
        {
            if(radioButton1.Checked == true)
            {
                _option = option_tinh_tnk.TONG_TIEN;
                return;
            }
            if(radioButton2.Checked == true)
            {
                _option = option_tinh_tnk.DON_GIA;
                return;
            }
            if(radioButton3.Checked == true)
            {
                _option = option_tinh_tnk.KHONG_TINH;
                return;
            }
            _option = option_tinh_tnk.CHUA_CHON;
        }
        private void m_cmd_continue_Click(object sender, EventArgs e)
        {
            try
            {
                lay_option();
                switch(_option)
                {
                    case option_tinh_tnk.CHUA_CHON:
                        XtraMessageBox.Show("Bạn chưa chọn cách tính thu nhập khác!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    case option_tinh_tnk.TONG_TIEN:
                        if(m_txt_tong_tien.EditValue == null)
                        {
                            XtraMessageBox.Show("Bạn chưa nhập tổng tiền!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        if(m_txt_thue_tong_tien.EditValue == null)
                        {
                            XtraMessageBox.Show("Bạn chưa nhập thuế!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        is_nguoi_dung_an_tiep_tuc = true;
                        _so_tien = Convert.ToDecimal(m_txt_tong_tien.EditValue);
                        _phan_tram_thue = Convert.ToDecimal(m_txt_thue_tong_tien.EditValue);
                        break;
                    case option_tinh_tnk.DON_GIA:
                        if(m_txt_don_gia.EditValue == null)
                        {
                            XtraMessageBox.Show("Bạn chưa nhập đơn giá!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        if(m_txt_thue_don_gia.EditValue == null)
                        {
                            XtraMessageBox.Show("Bạn chưa nhập thuế!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        is_nguoi_dung_an_tiep_tuc = true;
                        _so_tien = Convert.ToDecimal(m_txt_don_gia.EditValue);
                        _phan_tram_thue = Convert.ToDecimal(m_txt_thue_don_gia.EditValue);
                        break;
                    case option_tinh_tnk.KHONG_TINH:
                        break;
                    default:
                        break;
                }
                Close();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if(radioButton1.Checked == true)
                {
                    m_lbl_tong_tien.Enabled = true;
                    m_txt_tong_tien.Enabled = true;
                    m_txt_thue_tong_tien.Enabled = true;
                }
                else
                {
                    m_lbl_tong_tien.Enabled = false;
                    m_txt_tong_tien.Enabled = false;
                    m_txt_thue_tong_tien.Enabled = false;
                }
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if(radioButton2.Checked == true)
                {
                    m_lbl_don_gia.Enabled = true;
                    m_txt_don_gia.Enabled = true;
                    m_txt_thue_don_gia.Enabled = true;
                }
                else
                {
                    m_lbl_don_gia.Enabled = false;
                    m_txt_don_gia.Enabled = false;
                    m_txt_thue_don_gia.Enabled = false;
                }
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void f301_option_detail_calculate_Load(object sender, EventArgs e)
        {
            try
            {
                radioButton1.Checked = true;
                m_lbl_don_gia.Enabled = false;
                m_txt_don_gia.Enabled = false;
                m_txt_thue_don_gia.Enabled = false;
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_exit_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }


    }
}
