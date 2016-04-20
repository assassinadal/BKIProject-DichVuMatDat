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
using DevExpress.XtraEditors;
using BKI_DichVuMatDat.DTO;
using BKI_DichVuMatDat.DS.CDBNames;
using DevExpress.Utils;
using BKI_DichVuMatDat.NghiepVu.Luong;
using DevExpress.XtraGrid;
using BKI_DichVuMatDat.XtraReport;
namespace BKI_DichVuMatDat.BaoCao
{
    public partial class f412_rpt_tong_hop_tt_v2 : Form
    {
        #region Public Interface
        public f412_rpt_tong_hop_tt_v2()
        {
            InitializeComponent();
        }
        #endregion

        #region Member
        #endregion

        #region Private Method
        private decimal lay_thang()
        {
            return Convert.ToDecimal(m_dat_thang.DateTime.Month);
        }
        private decimal lay_nam()
        {
            return Convert.ToDecimal(m_dat_thang.DateTime.Year);
        }
        private void load_data_2_grid()
        {
            CHRMCommon.make_stt(m_adv_tong_hop);

            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());

            US_RPT_THONG_TIN_TONG_HOP_V2 v_us = new US_RPT_THONG_TIN_TONG_HOP_V2();
            v_us.HienThiBaoCao(v_ds, lay_thang(), lay_nam());
            m_grc_tong_hop.DataSource = v_ds.Tables[0];
            m_grc_tong_hop.RefreshDataSource();
            m_lbl_thang.Text = "Dữ liệu tháng " + lay_thang().ToString() + "/" + lay_nam().ToString();
        }
        private void resetText()
        {
            m_lbl_so_luong_nv_tinh_luong.ResetText();
            m_lbl_trang_thai_bang_luong.ResetText();
        }
        private bool isValidInputDate()
        {
            //if(m_txt_thang.EditValue == null || m_txt_nam.EditValue == null)
            //{
            //    return false;
            //}
            //if(Convert.ToDecimal(m_txt_thang.EditValue) <= 0 || Convert.ToDecimal(m_txt_thang.EditValue) > 12)
            //{
            //    return false;
            //}
            //if(Convert.ToDecimal(m_txt_nam.EditValue) <= 2014 || Convert.ToDecimal(m_txt_nam.EditValue) > 9999)
            //{
            //    return false;
            //}
            if(m_dat_thang.EditValue == null)
            {
                return false;
            }
            return true;
        }
        private void hien_thi_thong_tin_bang_luong()
        {
            if(!isValidInputDate())
            {
                resetText();
                return;
            }
            var v_dto_thong_tin_bang_luong = TinhLuongQL.Instance.LayThongTinBangLuong(lay_thang(), lay_nam());

            if(v_dto_thong_tin_bang_luong.CHOT_BANG_LUONG)
            {
                m_lbl_trang_thai_bang_luong.ForeColor = Color.Gray;
                m_lbl_trang_thai_bang_luong.Text = "|Đã chốt, không chỉnh sửa";
                m_lbl_so_luong_nv_tinh_luong.ForeColor = Color.Gray;
                m_lbl_so_luong_nv_tinh_luong.Text = v_dto_thong_tin_bang_luong.SO_LUONG_NHAN_VIEN_DA_TINH.ToString() + " NV ";

                m_cmd_soan_thao_bang_luong.Enabled = false;
                m_cmd_tinh_lai_nhan_vien.Enabled = false;
                m_cmd_delete_luong.Enabled = false;
                m_cmd_chot_bang_luong.Enabled = false;
            }
            else
            {
                m_lbl_trang_thai_bang_luong.ForeColor = Color.Green;
                m_lbl_trang_thai_bang_luong.Text = "|Chưa chốt, có thể chỉnh sửa";
                if(v_dto_thong_tin_bang_luong.SO_LUONG_NHAN_VIEN_CAN_TINH == v_dto_thong_tin_bang_luong.SO_LUONG_NHAN_VIEN_DA_TINH)
                {
                    m_lbl_so_luong_nv_tinh_luong.ForeColor = Color.Green;
                }
                if(v_dto_thong_tin_bang_luong.SO_LUONG_NHAN_VIEN_CAN_TINH > v_dto_thong_tin_bang_luong.SO_LUONG_NHAN_VIEN_DA_TINH)
                {
                    m_lbl_so_luong_nv_tinh_luong.ForeColor = Color.Red;
                }
                m_lbl_so_luong_nv_tinh_luong.Text = v_dto_thong_tin_bang_luong.SO_LUONG_NHAN_VIEN_DA_TINH.ToString() + "/"
                                                    + v_dto_thong_tin_bang_luong.SO_LUONG_NHAN_VIEN_CAN_TINH.ToString() + " NV ";

                m_cmd_soan_thao_bang_luong.Enabled = true;
                m_cmd_tinh_lai_nhan_vien.Enabled = true;
                m_cmd_delete_luong.Enabled = true;
                m_cmd_chot_bang_luong.Enabled = true;
            }
        }
        private bool kiem_tra_da_tinh_het_luong_nhan_vien_chua()
        {
            var v_dto_thong_tin_bang_luong = TinhLuongQL.Instance.LayThongTinBangLuong(lay_thang(), lay_nam());
            decimal v_dc_sl_nv_can_tinh = v_dto_thong_tin_bang_luong.SO_LUONG_NHAN_VIEN_CAN_TINH;
            decimal v_dc_sl_nv_da_tinh = v_dto_thong_tin_bang_luong.SO_LUONG_NHAN_VIEN_DA_TINH;
            if(v_dc_sl_nv_can_tinh <= v_dc_sl_nv_da_tinh)
            {
                return true;
            }
            return false;
        }
        private void chot_bang_luong()
        {
            DialogResult v_dlg_confirm;
            string v_str_text_confirm;

            if(!kiem_tra_da_tinh_het_luong_nhan_vien_chua())
            {
                v_str_text_confirm = "Chưa tính toán xong dữ liệu nhân viên. Bạn có chắc chắn muốn chốt bảng lương tháng " + lay_thang() + " năm " + lay_nam() + "?";
            }
            else
            {
                v_str_text_confirm = "Bạn có chắc chắn muốn chốt bảng lương tháng " + lay_thang() + " năm " + lay_nam() + "?";
            }
            v_dlg_confirm = XtraMessageBox.Show(v_str_text_confirm
                                                            , "XÁC NHẬN"
                                                            , MessageBoxButtons.YesNo
                                                            , MessageBoxIcon.Question);
            if(v_dlg_confirm == System.Windows.Forms.DialogResult.No)
            {
                XtraMessageBox.Show("Bạn đã hủy thao tác!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            TinhLuongQL.Instance.ChotBangLuongThang(lay_thang(), lay_nam());
        }
        private string gen_ten_bang_luong()
        {
            var v_str_op = "BL" + lay_thang() + lay_nam() + "_Bang luong thang " + lay_thang() + "-" + lay_nam() 
                            + "_version" + DateTime.Now.Day + "." + DateTime.Now.Month + "." + DateTime.Now.Year + "." + DateTime.Now.Hour + "h." + DateTime.Now.Minute + "p";
            return v_str_op;
        }
        #endregion

        #region Event Handle
        private void f413_rpt_tong_hop_thong_tin_Load(object sender, EventArgs e)
        {
            try
            {
                m_prb.Visible = false;
                this.m_panel.Visible = false;
                //m_txt_thang.EditValue = DateTime.Now.Month;
                //m_txt_nam.EditValue = DateTime.Now.Year;
                m_dat_thang.DateTime = DateTime.Now.Date;
                m_cmd_view.Focus();
                hien_thi_thong_tin_bang_luong();
                load_data_2_grid();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_luu_bang_luong_Click(object sender, EventArgs e)
        {
            try
            {
                //SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                //saveFileDialog1.Filter = "xls files (*.xls)|*.xls|All files (*.*)|*.*";
                //saveFileDialog1.RestoreDirectory = true;
                //saveFileDialog1.FileName = gen_ten_bang_luong();
                //if(saveFileDialog1.ShowDialog() == DialogResult.OK)
                //{
                //    m_grc_tong_hop.ExportToXls(saveFileDialog1.FileName);
                //    CHRM_BaseMessages.MsgBox_Infor(CONST_ID_MSGBOX.INFOR_LUU_BAO_CAO_THANH_CONG);
                //}
                ReportHelper.ExportXLS(m_grc_tong_hop, "BÁO CÁO TỔNG HỢP LƯƠNG", gen_ten_bang_luong());
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_tinh_lai_nhan_vien_Click(object sender, EventArgs e)
        {
            try
            {
                if(m_adv_tong_hop.FocusedRowHandle < 0)
                {
                    XtraMessageBox.Show("Chọn nhân viên trước để tính lại lương!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if(TinhLuongQL.Instance.LayThongTinBangLuong(lay_thang(), lay_nam()).CHOT_BANG_LUONG)
                {
                    //var v_dlg_tiep_tuc = XtraMessageBox.Show("Bảng lương đã được chốt, bạn có chắc chắn muốn tính lại lương cho nhân viên. Nếu tính lại sẽ dẫn dến sai sót với bảng lương đã chốt trước đó!", "CẢNH BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                    //if(v_dlg_tiep_tuc == System.Windows.Forms.DialogResult.No)
                    //{
                    //    XtraMessageBox.Show("Bạn đã hủy thao tác!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //    return;
                    //}
                    //else
                    //{
                    //    XtraMessageBox.Show("Bạn đã chọn tính lại lương nhân viên khi bảng lương đã được chốt!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //}
                    XtraMessageBox.Show("Bảng lương đã được chốt, bạn không được lại lương cho nhân viên. (Nếu muốn tính lại, cần bỏ chốt bảng lương)!", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                decimal v_id_nhan_vien = Convert.ToDecimal(m_adv_tong_hop.GetRowCellValue(m_adv_tong_hop.FocusedRowHandle, "ID_NHAN_VIEN"));
                TinhLuongQL.Instance.ReplaceBanGhiLuongNhanVien(v_id_nhan_vien, lay_thang(), lay_nam());
                load_data_2_grid();

                CHRMCommon.SelectRowInGrid(m_adv_tong_hop, RPT_THONG_TIN_TONG_HOP_V2.ID_NHAN_VIEN, v_id_nhan_vien);
                hien_thi_thong_tin_bang_luong();
                XtraMessageBox.Show("Tính lại lương nhân viên thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }

        }

        private void m_adv_tong_hop_MouseWheel(object sender, MouseEventArgs e)
        {
            try
            {
                m_adv_tong_hop.TopRowIndex += e.Delta > 0 ? -3 : 3;
                ((DXMouseEventArgs)e).Handled = true;
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }

        }

        //private void m_txt_thang_Leave(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        hien_thi_thong_tin_bang_luong();
        //    }
        //    catch(Exception v_e)
        //    {
        //        CSystemLog_301.ExceptionHandle(v_e);
        //    }
        //}

        //private void m_txt_nam_Leave(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        hien_thi_thong_tin_bang_luong();
        //    }
        //    catch(Exception v_e)
        //    {
        //        CSystemLog_301.ExceptionHandle(v_e);
        //    }
        //}

        private void m_cmd_soan_thao_bang_luong_Click(object sender, EventArgs e)
        {
            try
            {
                if(!isValidInputDate())
                {
                    XtraMessageBox.Show("Ngày tháng nhập vào chưa hợp lệ", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if(TinhLuongQL.Instance.LayThongTinBangLuong(lay_thang(), lay_nam()).CHOT_BANG_LUONG)
                {
                    XtraMessageBox.Show("Bảng lương đã được chốt, bạn không được soạn thảo bảng lương. (Nếu muốn soạn thảo lại, cần bỏ chốt bảng lương)!", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                f409_rpt_bang_luong_nv_v2 v_frm = new f409_rpt_bang_luong_nv_v2();
                v_frm.Display(lay_thang(), lay_nam());
                hien_thi_thong_tin_bang_luong();
                load_data_2_grid();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_view_Click(object sender, EventArgs e)
        {
            try
            {
                load_data_2_grid();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_chot_bang_luong_Click(object sender, EventArgs e)
        {
            try
            {
                chot_bang_luong();
                hien_thi_thong_tin_bang_luong();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_dat_thang_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                hien_thi_thong_tin_bang_luong();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        #endregion

        private void m_cmd_delete_luong_Click(object sender, EventArgs e)
        {
            try
            {
                if(TinhLuongQL.Instance.LayThongTinBangLuong(lay_thang(), lay_nam()).CHOT_BANG_LUONG)
                {
                    XtraMessageBox.Show("Bảng lương đã được chốt, bạn không được xóa lương nhân viên. (Nếu muốn xóa lương, cần bỏ chốt bảng lương)!", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                var v_dlg = XtraMessageBox.Show("Bạn có chắc chắn muốn xóa lương của nhân viên này!", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(v_dlg == System.Windows.Forms.DialogResult.Yes)
                {
                    decimal v_id_nhan_vien = Convert.ToDecimal(m_adv_tong_hop.GetRowCellValue(m_adv_tong_hop.FocusedRowHandle, "ID_NHAN_VIEN"));
                    TinhLuongQL.Instance.XoaBanGhiLuongNhanVien(v_id_nhan_vien, lay_thang(), lay_nam());
                    load_data_2_grid();

                    hien_thi_thong_tin_bang_luong();
                    XtraMessageBox.Show("Xóa lương nhân viên thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        
    }
}
