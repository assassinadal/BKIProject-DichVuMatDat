using BKI_DichVuMatDat.DS;
using BKI_DichVuMatDat.DS.CDBNames;
using BKI_DichVuMatDat.US;
using DevExpress.XtraEditors;
using DevExpress.XtraTreeList.Nodes;
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

namespace BKI_DichVuMatDat.NghiepVu.NhanSu
{
    public partial class f309_quan_ly_cong_tac_v2 : Form
    {
        private decimal v_id_don_vi;
        private decimal v_id_nhan_vien;

        #region Public Interfaces
        public f309_quan_ly_cong_tac_v2()
        {
            InitializeComponent();
            format_controls();
            load_data_2_tree();
        }

        public f309_quan_ly_cong_tac_v2(decimal v_id_don_vi, decimal v_id_nhan_vien)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.v_id_don_vi = v_id_don_vi;
            this.v_id_nhan_vien = v_id_nhan_vien;
            format_controls();
            load_data_2_tree();
            m_tree_don_vi.FocusedNode = m_tree_don_vi.FindNodeByFieldValue("ID", v_id_don_vi);
            m_grv.ActiveFilterString=  "[MA_NV] = " + get_ma_nv_by_ID_nv(v_id_nhan_vien);
        }
        #endregion
        

        #region Private Methods
        private void format_controls()
        {
            set_define_events();
            
        }
        private void set_initial_form_load()
        {
            //load_data_2_tree();
        }
        private void load_data_2_tree()
        {
            US_V_DM_DON_VI_2 v_us_dv = new US_V_DM_DON_VI_2();
            DS_V_DM_DON_VI_2 v_ds_dv = new DS_V_DM_DON_VI_2();
            v_us_dv.FillDataset(v_ds_dv);

            m_tree_don_vi.ParentFieldName = DM_DON_VI.ID_DON_VI_CAP_TREN;
            m_tree_don_vi.DataSource = v_ds_dv.Tables[0];
            m_tree_don_vi.RefreshDataSource();

            m_tree_don_vi.ExpandAll();
        }
        private void load_data_danh_sach_nhan_vien_theo_don_vi(decimal ip_dc_id_don_vi)
        {
            //US_GD_CONG_TAC v_us_ct = new US_GD_CONG_TAC();
            //var v_ds_nhan_vien = v_us_ct.LayDanhSachNhanVienTheoPhongBan(ip_dc_id_don_vi);

            //m_grc.DataSource = v_ds_nhan_vien;
            US_V_GD_CONG_TAC_2 v_us = new US_V_GD_CONG_TAC_2();
            DS_V_GD_CONG_TAC_2 v_ds = new DS_V_GD_CONG_TAC_2();
            v_ds.EnforceConstraints = false;
            v_us.FillDataset(v_ds, " where id_don_vi = " + ip_dc_id_don_vi);

            m_grc.DataSource = v_ds.Tables[0];
        }

        //Get data
        private decimal get_id_phong_ban()
        {
            return Convert.ToDecimal(m_tree_don_vi.FocusedNode.GetValue("ID"));
        }
        private decimal get_id_nhan_vien()
        {
            return Convert.ToDecimal(m_grv.GetRowCellValue(m_grv.FocusedRowHandle, V_GD_CONG_TAC_2.ID_NHAN_VIEN));
        }

        private string get_ma_nv_by_ID_nv(decimal ip_id_nv)
        {
            US_DM_NHAN_VIEN v_us = new US_DM_NHAN_VIEN();
            DS_DM_NHAN_VIEN v_ds = new DS_DM_NHAN_VIEN();
            v_us.FillDataset(v_ds, "where ID=" + ip_id_nv);
            return v_ds.Tables[0].Rows[0][DM_NHAN_VIEN.MA_NV].ToString();
        }

        private void refresh_data()
        {
            TreeListNode v_node_focused = m_tree_don_vi.FocusedNode;
            m_tree_don_vi.ClearFocusedColumn();
            load_data_2_tree();
            m_tree_don_vi.FocusedNode = v_node_focused;
        }

        //Check
        private bool is_nhan_vien_seleted()
        {
            if(m_grv.FocusedRowHandle < 0)
            {
                XtraMessageBox.Show("Bạn chưa chọn nhân viên!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }


        //Action
        private void them_moi_cong_tac()
        {
            f310_cap_nhat_cong_tac_v2 v_frm = new f310_cap_nhat_cong_tac_v2();
            v_frm.display_for_them_cong_tac_moi(get_id_phong_ban());
            refresh_data();
        }
        private void cap_nhat_lam_thoi_cong_tac()
        {
            if(!is_nhan_vien_seleted())
            {
                return;
            }
            f310_cap_nhat_cong_tac_v2 v_frm = new f310_cap_nhat_cong_tac_v2();
            v_frm.display_for_cap_nhat_lam_thoi_cong_tac(get_id_nhan_vien(), get_id_phong_ban());

            refresh_data();
        }
        private void cap_nhat_kiem_nhiem_cong_tac()
        {
            if(!is_nhan_vien_seleted())
            {
                return;
            }
            f310_cap_nhat_cong_tac_v2 v_frm = new f310_cap_nhat_cong_tac_v2();
            v_frm.display_for_kiem_nhiem_cong_tac(get_id_nhan_vien(), get_id_phong_ban());

            refresh_data();
        }
        private void cap_nhat_chuyen_cong_tac()
        {
            if(!is_nhan_vien_seleted())
            {
                return;
            }
            f310_cap_nhat_cong_tac_v2 v_frm = new f310_cap_nhat_cong_tac_v2();
            v_frm.display_for_chuyen_cong_tac(get_id_nhan_vien(), get_id_phong_ban());

            refresh_data();
        }
        private void cap_nhat_cham_dut_cong_tac()
        {
            if(!is_nhan_vien_seleted())
            {
                return;
            }
            var v_dc_id_gd_cong_tac = Convert.ToDecimal(m_grv.GetRowCellValue(m_grv.FocusedRowHandle, V_GD_CONG_TAC_2.ID));
            f310_cap_nhat_cong_tac_v2 v_frm = new f310_cap_nhat_cong_tac_v2();
            //v_frm.display_for_cham_dut_cong_tac(v_dc_id_gd_cong_tac);
            v_frm.display_for_cham_dut_cong_tac(v_dc_id_gd_cong_tac, get_id_phong_ban());
            refresh_data();
        }
        private void sua_cong_tac()
        {
            if(!is_nhan_vien_seleted())
            {
                return;
            }
            var v_dc_id_gd_cong_tac = Convert.ToDecimal(m_grv.GetRowCellValue(m_grv.FocusedRowHandle, V_GD_CONG_TAC_2.ID));
            f310_cap_nhat_cong_tac v_frm = new f310_cap_nhat_cong_tac();
            v_frm.display_for_update(v_dc_id_gd_cong_tac);
            refresh_data();
        }
        private void xoa_cong_tac()
        {
            var v_dlg_confirm = XtraMessageBox.Show("Bạn có chắc chắn muốn xóa công tác (việc này chỉ nên thực hiện khi bạn cập nhật nhầm công tác cho nhân viên)!", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if(v_dlg_confirm == System.Windows.Forms.DialogResult.Yes)
            {
                var v_dc_id_gd_cong_tac = Convert.ToDecimal(m_grv.GetRowCellValue(m_grv.FocusedRowHandle, V_GD_CONG_TAC_2.ID));
                US_GD_CONG_TAC v_us = new US_GD_CONG_TAC();
                v_us.DeleteByID(v_dc_id_gd_cong_tac);
                XtraMessageBox.Show("Đã xóa công tác nhân viên thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refresh_data();
            }
        }
        #endregion

        #region Event Handle
        private void set_define_events()
        {
            Load += f311_danh_sach_nhan_vien_theo_don_vi_Load;
            m_tree_don_vi.AfterFocusNode += m_tree_don_vi_AfterFocusNode;
            m_cmd_them_moi_cong_tac.Click += m_cmd_them_moi_cong_tac_Click;
            m_cmd_refresh.Click += m_cmd_refresh_Click;
            m_cmd_kiem_nhiem_cong_tac.Click += m_cmd_kiem_nhiem_cong_tac_Click;
            m_cmd_lam_thoi_cong_tac.Click += m_cmd_lam_thoi_cong_tac_Click;
            m_cmd_cham_dut_cong_tac.Click += m_cmd_cham_dut_cong_tac_Click;
            m_cmd_chuyen_cong_tac.Click += m_cmd_chuyen_cong_tac_Click;

            m_cmd_sua_cong_tac.Click += m_cmd_sua_cong_tac_Click;
            m_cmd_xoa_cong_tac.Click += m_cmd_xoa_cong_tac_Click;
        }

        void m_cmd_xoa_cong_tac_Click(object sender, EventArgs e)
        {
            try
            {
                xoa_cong_tac();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_sua_cong_tac_Click(object sender, EventArgs e)
        {
            try
            {
                sua_cong_tac();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_chuyen_cong_tac_Click(object sender, EventArgs e)
        {
            try
            {
                cap_nhat_chuyen_cong_tac();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_cham_dut_cong_tac_Click(object sender, EventArgs e)
        {
            try
            {
                cap_nhat_cham_dut_cong_tac();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_lam_thoi_cong_tac_Click(object sender, EventArgs e)
        {
            try
            {
                cap_nhat_lam_thoi_cong_tac();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_kiem_nhiem_cong_tac_Click(object sender, EventArgs e)
        {
            try
            {
                cap_nhat_kiem_nhiem_cong_tac();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_refresh_Click(object sender, EventArgs e)
        {
            try
            {
                refresh_data();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_them_moi_cong_tac_Click(object sender, EventArgs e)
        {
            try
            {
                them_moi_cong_tac();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void f311_danh_sach_nhan_vien_theo_don_vi_Load(object sender, EventArgs e)
        {
            try
            {
                set_initial_form_load();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_tree_don_vi_AfterFocusNode(object sender, DevExpress.XtraTreeList.NodeEventArgs e)
        {
            try
            {
                var v_dc_id_don_vi = Convert.ToDecimal(e.Node.GetValue(V_DM_DON_VI_2.ID));
                load_data_danh_sach_nhan_vien_theo_don_vi(v_dc_id_don_vi);
                var v_str_ten_don_vi = e.Node.GetValue(V_DM_DON_VI_2.TEN_DON_VI).ToString();
                m_lbl_thong_tin_phong_ban.Text = v_str_ten_don_vi;
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        #endregion
    }
}
