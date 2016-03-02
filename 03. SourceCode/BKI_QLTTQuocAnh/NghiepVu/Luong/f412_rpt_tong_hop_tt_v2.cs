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
        int m_work_fail = 0;
        int m_tinh_lai = 0;
        #endregion


        #region Private Method
        private decimal lay_thang()
        {
            return Convert.ToDecimal(m_txt_thang.EditValue);
        }
        private decimal lay_nam()
        {
            return Convert.ToDecimal(m_txt_nam.EditValue);
        }
        private void load_data_2_grid()
        {
            CHRMCommon.make_stt(m_adv_tong_hop);
            //US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            //v_us.FillDatasetWithQuery(v_ds, "SELECT * FROM V_RPT_BAO_CAO_TONG_HOP_V2 WHERE THANG = " + lay_thang() + " AND NAM = " + lay_nam() + " order by THU_TU_HIEN_THI, THU_TU_CHUC_VU, THU_TU_HOP_DONG, TEN, HO_DEM");
            US_RPT_THONG_TIN_TONG_HOP_V2 v_us = new US_RPT_THONG_TIN_TONG_HOP_V2();
            v_us.HienThiBaoCao(v_ds, Convert.ToDecimal(m_txt_thang.Text), Convert.ToDecimal(m_txt_nam.Text));

            m_grc_tong_hop.DataSource = v_ds.Tables[0];
            m_grc_tong_hop.RefreshDataSource();
        }
        private void hien_thi_thong_tin_bang_luong()
        {
            if(m_txt_thang.EditValue == null || m_txt_nam.EditValue == null)
            {
                return;
            }
            var v_dto_thong_tin_bang_luong = TinhLuongQL.Instance.LayThongTinBangLuong(lay_thang(), lay_nam());

            if(v_dto_thong_tin_bang_luong.SO_LUONG_NHAN_VIEN_CAN_TINH == v_dto_thong_tin_bang_luong.SO_LUONG_NHAN_VIEN_DA_TINH)
            {
                m_lbl_thong_bao.Text = "Đã tính xong lương cho";
                m_lbl_thong_bao.ForeColor = Color.Green;
                m_lbl_so_luong_nv_tinh_luong.ForeColor = Color.Green;
            }
            if(v_dto_thong_tin_bang_luong.SO_LUONG_NHAN_VIEN_CAN_TINH > v_dto_thong_tin_bang_luong.SO_LUONG_NHAN_VIEN_DA_TINH)
            {
                m_lbl_thong_bao.Text = "Đã tính được lương cho";
                m_lbl_thong_bao.ForeColor = Color.Red;
                m_lbl_so_luong_nv_tinh_luong.ForeColor = Color.Red;
            }
            m_lbl_so_luong_nv_tinh_luong.Text = v_dto_thong_tin_bang_luong.SO_LUONG_NHAN_VIEN_DA_TINH.ToString() + "/"
                                                    + v_dto_thong_tin_bang_luong.SO_LUONG_NHAN_VIEN_CAN_TINH.ToString() + " (nhân viên)";
            if(v_dto_thong_tin_bang_luong.CHOT_BANG_LUONG)
            {
                m_lbl_trang_thai_bang_luong.ForeColor = Color.Gray;
                m_lbl_trang_thai_bang_luong.Text = "|Đã chốt, không chỉnh sửa";
            }
            else
            {
                m_lbl_trang_thai_bang_luong.ForeColor = Color.Green;
                m_lbl_trang_thai_bang_luong.Text = "|Chưa chốt, có thể chỉnh sửa";
            }
        }
        #endregion

        #region Event Handle

        private void f413_rpt_tong_hop_thong_tin_Load(object sender, EventArgs e)
        {
            try
            {
                m_prb.Visible = false;
                this.m_panel.Visible = false;
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        #endregion

        private void m_cmd_luu_bang_luong_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "xls files (*.xls)|*.xls|All files (*.*)|*.*";
                saveFileDialog1.RestoreDirectory = true;
                if(saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    m_grc_tong_hop.ExportToXls(saveFileDialog1.FileName);
                    CHRM_BaseMessages.MsgBox_Infor(CONST_ID_MSGBOX.INFOR_LUU_BAO_CAO_THANH_CONG);
                }
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
                    var v_dlg_tiep_tuc = XtraMessageBox.Show("Bảng lương đã được chốt, bạn có chắc chắn muốn tính lại lương cho nhân viên. Nếu tính lại sẽ dẫn dến sai sót với bảng lương đã chốt trước đó!", "CẢNH BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                    if(v_dlg_tiep_tuc == System.Windows.Forms.DialogResult.No)
                    {
                        XtraMessageBox.Show("Bạn đã hủy thao tác!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        XtraMessageBox.Show("Bạn đã chọn tính lại lương nhân viên khi bảng lương đã được chốt!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                decimal v_id_nhan_vien = Convert.ToDecimal(m_adv_tong_hop.GetRowCellValue(m_adv_tong_hop.FocusedRowHandle, "ID_NHAN_VIEN"));
                TinhLuongQL.Instance.ReplaceBanGhiLuongNhanVien(v_id_nhan_vien, lay_thang(), lay_nam());
                load_data_2_grid();
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

        private void simpleButton1_Click(object sender, EventArgs e)
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

        private void m_txt_thang_Leave(object sender, EventArgs e)
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

        private void m_txt_nam_Leave(object sender, EventArgs e)
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
    }
}
