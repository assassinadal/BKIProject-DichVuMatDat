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
using BKI_DichVuMatDat.DS.CDBNames;
using DevExpress.XtraEditors;

namespace BKI_DichVuMatDat.NghiepVu.NhanSu
{
    public partial class f327_lap_hop_dong_v3 : Form
    {
        #region Public Interface
        public f327_lap_hop_dong_v3()
        {
            InitializeComponent();
            set_define_events();
        }

        
        #endregion

        #region Members
        #endregion

        #region Private Method
        private void load_data_to_tree()
        {
            US_V_DM_DON_VI_2 v_us_dv = new US_V_DM_DON_VI_2();
            DS_V_DM_DON_VI_2 v_ds_dv = new DS_V_DM_DON_VI_2();
            v_us_dv.FillDataset(v_ds_dv);
            m_tree_don_vi.ParentFieldName = DM_DON_VI.ID_DON_VI_CAP_TREN;
            m_tree_don_vi.DataSource = v_ds_dv.Tables[0];
            m_tree_don_vi.RefreshDataSource();
            m_tree_don_vi.ExpandAll();
        }

        private void load_data_to_grid()
        {
            decimal v_id_don_vi = Convert.ToDecimal((m_tree_don_vi.FocusedNode.GetValue("ID")));
            US_GD_HOP_DONG v_us = new US_GD_HOP_DONG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetHopDong(v_ds,v_id_don_vi);
            m_grc.DataSource = v_ds.Tables[0];
        }

        private void delete_gd_lcd(decimal v_id_hop_dong)
        {
            US_GD_LUONG_CHE_DO v_us = new US_GD_LUONG_CHE_DO();
            DS_GD_LUONG_CHE_DO v_ds = new DS_GD_LUONG_CHE_DO();
            v_us.FillDataset(v_ds, "where id_hop_dong = " + v_id_hop_dong);
            for (int i = 0; i < v_ds.Tables[0].Rows.Count; i++)
            {
                decimal v_id_gd_lcd = Convert.ToDecimal(v_ds.Tables[0].Rows[i]["ID"]);
                v_us = new US_GD_LUONG_CHE_DO(v_id_gd_lcd);
                v_us.Delete();
            }
        }

        private void delete_gd_he_so_lns(decimal v_id_hop_dong)
        {
            US_GD_HE_SO_LNS v_us = new US_GD_HE_SO_LNS();
            DS_GD_HE_SO_LNS v_ds = new DS_GD_HE_SO_LNS();
            v_us.FillDataset(v_ds, "where id_hop_dong = " + v_id_hop_dong);
            for (int i = 0; i < v_ds.Tables[0].Rows.Count; i++)
            {
                decimal v_id_gd_lns = Convert.ToDecimal(v_ds.Tables[0].Rows[i]["ID"]);
                v_us = new US_GD_HE_SO_LNS(v_id_gd_lns);
                v_us.Delete();
            }
        }
        #endregion

        #region Event Handler
        private void set_define_events()
        {
            this.Load += f327_lap_hop_dong_v3_Load;
            m_cmd_insert.Click += m_cmd_insert_Click;
            m_cmd_update.Click += m_cmd_update_Click;
            m_cmd_delete.Click += m_cmd_delete_Click;
            m_cmd_print.Click += m_cmd_print_Click;
            m_tree_don_vi.AfterFocusNode += m_tree_don_vi_AfterFocusNode;
        }

        void m_cmd_print_Click(object sender, EventArgs e)
        {
            try
            {
                f326_in_hop_dong v_f = new f326_in_hop_dong();
                v_f.ShowDialog();
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
                int v_focused_row = m_grv.FocusedRowHandle;
                if (v_focused_row !=0)
                {
                    string v_str_confirm = "Bạn có chắc chắn muốn xóa hợp đồng này?";
                    DialogResult v_dialog = XtraMessageBox.Show(v_str_confirm, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (v_dialog == DialogResult.Yes)
                    {
                        decimal v_id_hop_dong = Convert.ToDecimal(m_grv.GetRowCellValue(v_focused_row,"ID"));                        
                        delete_gd_he_so_lns(v_id_hop_dong);
                        delete_gd_lcd(v_id_hop_dong);
                        US_GD_HOP_DONG v_us = new US_GD_HOP_DONG(v_id_hop_dong);
                        v_us.Delete();
                        XtraMessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        load_data_to_grid();
                    }
                }
                else
                {
                    string v_str_error = "Bạn chưa chọn hợp đồng để xóa!";
                    XtraMessageBox.Show(v_str_error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_tree_don_vi_AfterFocusNode(object sender, DevExpress.XtraTreeList.NodeEventArgs e)
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

        void m_cmd_update_Click(object sender, EventArgs e)
        {
            try
            {
                int v_focused_row = m_grv.FocusedRowHandle;
                if (v_focused_row >= 0)
                {
                    var v_dr = m_grv.GetDataRow(m_grv.FocusedRowHandle);
                    f328_lap_hop_dong_v3_detail v_f = new f328_lap_hop_dong_v3_detail();
                    v_f.display_for_update(v_dr);
                    decimal v_id_don_vi = Convert.ToDecimal((m_tree_don_vi.FocusedNode.GetValue("ID")));
                    load_data_to_grid();
                }
                else
                {
                    string v_str_error = "Bạn chưa chọn dòng dữ liệu để sửa!";
                    XtraMessageBox.Show(v_str_error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                f328_lap_hop_dong_v3_detail v_f = new f328_lap_hop_dong_v3_detail();
                decimal v_id_don_vi = Convert.ToDecimal((m_tree_don_vi.FocusedNode.GetValue("ID")));
                v_f.display_for_insert(v_id_don_vi);
                load_data_to_grid();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }           
        }

        void f327_lap_hop_dong_v3_Load(object sender, EventArgs e)
        {
            try
            {
                load_data_to_tree();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        #endregion
    }
}
