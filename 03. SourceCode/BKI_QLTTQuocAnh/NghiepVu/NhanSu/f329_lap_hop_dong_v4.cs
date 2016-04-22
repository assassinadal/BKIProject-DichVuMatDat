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
    public partial class f329_lap_hop_dong_v4 : Form
    {
        #region Public Interface
        public f329_lap_hop_dong_v4()
        {
            InitializeComponent();
            set_define_events();
        }
        #endregion

        #region Members
        #endregion

        #region Private Method
        private void load_data_to_grid()
        {
            US_GD_HOP_DONG v_us = new US_GD_HOP_DONG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            m_grc.DataSource = v_us.LayDanhSachHopDong();
        }

        private void delete_gd_lcd(decimal v_id_hop_dong)
        {
            //US_GD_LUONG_CHE_DO v_us = new US_GD_LUONG_CHE_DO();
            //DS_GD_LUONG_CHE_DO v_ds = new DS_GD_LUONG_CHE_DO();
            //v_us.FillDataset(v_ds, "where id_hop_dong = " + v_id_hop_dong);
            //for (int i = 0; i < v_ds.Tables[0].Rows.Count; i++)
            //{
            //    decimal v_id_gd_lcd = Convert.ToDecimal(v_ds.Tables[0].Rows[i]["ID"]);
            //    v_us = new US_GD_LUONG_CHE_DO(v_id_gd_lcd);
            //    v_us.Delete();
            //}
        }

        private void delete_gd_he_so_lns(decimal v_id_hop_dong)
        {
            //US_GD_HE_SO_LNS v_us = new US_GD_HE_SO_LNS();
            //DS_GD_HE_SO_LNS v_ds = new DS_GD_HE_SO_LNS();
            //v_us.FillDataset(v_ds, "where id_hop_dong = " + v_id_hop_dong);
            //for (int i = 0; i < v_ds.Tables[0].Rows.Count; i++)
            //{
            //    decimal v_id_gd_lns = Convert.ToDecimal(v_ds.Tables[0].Rows[i]["ID"]);
            //    v_us = new US_GD_HE_SO_LNS(v_id_gd_lns);
            //    v_us.Delete();
            //}
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
                if (v_focused_row >= 0)
                {
                    string v_str_confirm = "Bạn có chắc chắn muốn xóa hợp đồng này?\nViệc xóa hợp đồng chỉ nên thực hiện khi bạn cập nhật sai.\nViệc xóa hợp đồng có thể ảnh hưởng tới các dữ liệu tiền lương đã tính trước đó!";
                    DialogResult v_dialog = XtraMessageBox.Show(v_str_confirm, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                    if (v_dialog == DialogResult.Yes)
                    {
                        decimal v_id_hop_dong = Convert.ToDecimal(m_grv.GetRowCellValue(v_focused_row,"ID"));                        
                        //delete_gd_he_so_lns(v_id_hop_dong);
                        //delete_gd_lcd(v_id_hop_dong);
                        US_GD_HOP_DONG v_us = new US_GD_HOP_DONG(v_id_hop_dong);
                        v_us.Delete();
                        XtraMessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                f330_lap_hop_dong_v4_detail v_f = new f330_lap_hop_dong_v4_detail();
                v_f.display_for_insert();
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
