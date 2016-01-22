using BKI_DichVuMatDat.US;
using DevExpress.XtraEditors;
using IP.Core.IPCommon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BKI_DichVuMatDat.CONFIRM
{
    public partial class msg002_confirm_luu_du_lieu_bang_luong : Form
    {
        private ENUM_CONFIRM_LUU_BANG_LUONG _confirm = ENUM_CONFIRM_LUU_BANG_LUONG.NONE;
        public msg002_confirm_luu_du_lieu_bang_luong()
        {
            InitializeComponent();
        }
        public ENUM_CONFIRM_LUU_BANG_LUONG Display()
        {
            ShowDialog();
            return _confirm;
        }


        private void hide_option1()
        {
            //m_rdb_luu_lai_toan_bo.Enabled = false;
        }
        private void show_option1()
        {
            m_rdb_luu_lai_toan_bo.Enabled = true;
        }

        private void hide_option2()
        {
            //m_rdb_xu_ly_du_lieu.Enabled = false;
            m_lbl_option_detail1.Enabled = false;
            m_lbl_option_detail2.Enabled = false;
            m_chk_0_ghi_de.Enabled = false;
            m_chk_1_ghi_moi.Enabled = false;
        }
        private void show_option2()
        {
            m_rdb_xu_ly_du_lieu.Enabled = true;
            m_lbl_option_detail1.Enabled = true;
            m_lbl_option_detail2.Enabled = true;
            m_chk_0_ghi_de.Enabled = true;
            m_chk_1_ghi_moi.Enabled = true;
        }

        private void m_rdb_luu_lai_toan_bo_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if(m_rdb_luu_lai_toan_bo.Checked == false)
                {
                    hide_option1();
                    return;
                }
                show_option1();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_rdb_xu_ly_du_lieu_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if(m_rdb_xu_ly_du_lieu.Checked == false)
                {
                    hide_option2();
                    return;
                }
                show_option2();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }

        }

        private void msg002_confirm_luu_du_lieu_bang_luong_Load(object sender, EventArgs e)
        {
            try
            {
                m_rdb_xu_ly_du_lieu.Checked = true;
                m_chk_1_ghi_moi.Checked = true;
                hide_option1();
                show_option2();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_chk_0_ghi_de_CheckedChanged(object sender, EventArgs e)
        {
            try
            {

            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_chk_1_ghi_moi_CheckedChanged(object sender, EventArgs e)
        {
            try
            {

            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_rdb_luu_lai_toan_bo_Click(object sender, EventArgs e)
        {
            try
            {
                m_rdb_luu_lai_toan_bo.Checked = true;
                show_option1();
                hide_option2();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_rdb_xu_ly_du_lieu_Click(object sender, EventArgs e)
        {
            try
            {
                m_rdb_xu_ly_du_lieu.Checked = true;
                show_option2();
                hide_option1();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_confirm_Click(object sender, EventArgs e)
        {
            try
            {
                if(m_rdb_luu_lai_toan_bo.Checked == true)
                {
                    _confirm = ENUM_CONFIRM_LUU_BANG_LUONG.TINH_LAI_TOAN_BO;
                    XtraMessageBox.Show("Bạn vừa chọn Option lưu lại toàn bộ bảng lương (Có nghĩa xóa bảng lương cũ, lưu bảng lương mới)","THÔNG BÁO");
                }
                else
                {
                    if(m_chk_0_ghi_de.Checked == false && m_chk_1_ghi_moi.Checked == false)
                    {
                        _confirm = ENUM_CONFIRM_LUU_BANG_LUONG.NONE;
                        XtraMessageBox.Show("Bạn vừa chọn Option: Không thao tác với dữ liệu (Có nghĩa không lưu dữ liệu vào phần mềm)", "THÔNG BÁO");
                    }
                    if(m_chk_0_ghi_de.Checked == false && m_chk_1_ghi_moi.Checked == true)
                    {
                        _confirm = ENUM_CONFIRM_LUU_BANG_LUONG.CHUA_CO_THI_GHI_MOI_DA_CO_THI_KHONG_LAM_GI;
                        XtraMessageBox.Show("Bạn vừa chọn Option: Nhân viên chưa có trong bảng lương phần mềm thì thêm mới, " +
                                                                            "nhân viên đã có trong bảng lương phần mềm thì bỏ qua không lưu!", "THÔNG BÁO");
                    }
                    if(m_chk_0_ghi_de.Checked == true && m_chk_1_ghi_moi.Checked == false)
                    {
                        _confirm = ENUM_CONFIRM_LUU_BANG_LUONG.CHUA_CO_THI_KHONG_LAM_GI_DA_CO_THI_GHI_DE;
                        XtraMessageBox.Show("Bạn vừa chọn Option: Nhân viên chưa có trong bảng lương phần mềm thì bỏ qua không lưu, " +
                                                                            "nhân viên đã có trong bảng lương phần mềm thì ghi đè!", "THÔNG BÁO");
                    }
                    if(m_chk_0_ghi_de.Checked == true && m_chk_1_ghi_moi.Checked == true)
                    {
                        _confirm = ENUM_CONFIRM_LUU_BANG_LUONG.CHUA_CO_THI_GHI_MOI_DA_CO_THI_GHI_DE;
                        XtraMessageBox.Show("Bạn vừa chọn Option: Nhân viên chưa có trong bảng lương phần mềm thì ghi mới, " +
                                                                            "nhân viên đã có trong bảng lương phần mềm thì ghi đè!", "THÔNG BÁO");
                    }
                }
                Close();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
    }
}
