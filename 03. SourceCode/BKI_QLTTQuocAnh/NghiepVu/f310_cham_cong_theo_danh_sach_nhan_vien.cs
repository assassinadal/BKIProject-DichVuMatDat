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
using System.Data;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.Utils.Menu;
using DevExpress.XtraTreeList.ViewInfo;
using DevExpress.XtraTreeList.Nodes;

namespace BKI_DichVuMatDat.NghiepVu
{
    public partial class f310_cham_cong_theo_danh_sach_nhan_vien : Form
    {
        public f310_cham_cong_theo_danh_sach_nhan_vien()
        {
            InitializeComponent();
            format_controls();
        }

        #region Members
        DS_V_PRT_DANH_SACH_NHAN_VIEN_CON_HAN_HOP_DONG m_ds = new DS_V_PRT_DANH_SACH_NHAN_VIEN_CON_HAN_HOP_DONG();
        US_V_PRT_DANH_SACH_NHAN_VIEN_CON_HAN_HOP_DONG m_us = new US_V_PRT_DANH_SACH_NHAN_VIEN_CON_HAN_HOP_DONG();

        public List<int> m_lst_index = new List<int>();
        DataSet m_ds_loai_ngay_cong = new DataSet();

        #endregion

        #region Private methods
        private void format_controls()
        {
            set_define_events();
            this.KeyPreview = true;
        }

        private void set_initial_form_load()
        {
            load_data_2_le_loai_ngay_cong();
        }

        private void load_data_2_grid()
        {
            int v_row_count = 0;
            CCommon.make_stt(m_grv_cham_cong);
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new System.Data.DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetGDChamCong(v_ds, m_dat_ngay_cham_cong.Value.Date);
            v_row_count = v_ds.Tables[0].Rows.Count;
            m_grc_cham_cong.DataSource = v_ds.Tables[0];

        }

        private DataSet load_data_2_ds_dm_loai_ngay_cong(DataSet v_ds_dm_loai_ngay_cong)
        {

            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds_ = new DataSet();
            v_ds_dm_loai_ngay_cong.Tables.Add(new DataTable());
            v_us.FillDatasetWithQuery(v_ds_dm_loai_ngay_cong, "select ID AS ID_LOAI_NGAY_CONG, MA_NGAY_CONG, TEN_NGAY_CONG FROM DM_LOAI_NGAY_CONG");

            return v_ds_dm_loai_ngay_cong;
        }

        private void load_data_2_le_loai_ngay_cong()
        {
            m_sle_loai_ngay_cong.View.Columns.AddField("ID_LOAI_NGAY_CONG").Visible = false;
            m_sle_loai_ngay_cong.View.Columns.AddField("MA_NGAY_CONG").Visible = true;
            m_sle_loai_ngay_cong.View.Columns.AddField("TEN_NGAY_CONG").Visible = true;
            m_sle_loai_ngay_cong.View.Columns[1].Caption = "MÃ NGÀY CÔNG";
            m_sle_loai_ngay_cong.View.Columns[2].Caption = "TÊN NGÀY CÔNG";
            DataSet v_ds_dm_loai_ngay_cong = new DataSet();

            m_sle_loai_ngay_cong.DataSource = load_data_2_ds_dm_loai_ngay_cong(v_ds_dm_loai_ngay_cong).Tables[0];
            m_sle_loai_ngay_cong.DisplayMember = "MA_NGAY_CONG";
            m_sle_loai_ngay_cong.ValueMember = "ID_LOAI_NGAY_COUNT";

            m_sle_loai_ngay_cong.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            m_sle_loai_ngay_cong.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
        }

        private void luu_du_lieu()
        {
            foreach (var item in m_lst_index)
            {
                DataRow v_dr = m_grv_cham_cong.GetDataRow(item);
                update_du_lieu(v_dr);
            }
        }

        private List<DataRow> get_selected_rows()
        {
            List<DataRow> v_lst_dr = new List<DataRow>();
            var v_lst = GetSelectedRows(m_grv_cham_cong);
            foreach (var v_i in v_lst)
            {
                v_lst_dr.Add(m_grv_cham_cong.GetDataRow(v_i));
            }
            return v_lst_dr;
        }

        private List<int> GetSelectedRows(GridView view)
        {
            List<int> v_lst = new List<int>();
            int[] rows = m_grv_cham_cong.GetSelectedRows();
            for (int i = 0; i < rows.Length; i++)
                if (!m_grv_cham_cong.IsGroupRow(rows[i]))
                {
                    v_lst.Add(rows[i]);
                }
            return v_lst;
        }

        private void LayDuLieuLoaiNgayCong()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            m_ds_loai_ngay_cong.Tables.Add(new DataTable());
            m_ds_loai_ngay_cong.Clear();
            v_us.FillDatasetCBO(m_ds_loai_ngay_cong, "DM_LOAI_NGAY_CONG", "ID", "MA_NGAY_CONG", "");
        }

        #endregion

        private void set_define_events()
        {
            this.Load += f310_cham_cong_theo_danh_sach_nhan_vien_Load;
            m_cmd_search.Click += m_cmd_search_Click;
            m_cmd_insert.Click += m_cmd_insert_Click;
            m_grv_cham_cong.CellValueChanged += m_grv_cham_cong_CellValueChanged;

        }

        private void f310_cham_cong_theo_danh_sach_nhan_vien_Load(object sender, EventArgs e)
        {
            try
            {
                set_initial_form_load();
                LayDuLieuLoaiNgayCong();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_search_Click(object sender, EventArgs e)
        {
            try
            {
                load_data_2_grid();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_grv_cham_cong_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (!m_lst_index.Exists(x => x == e.RowHandle))
            {
                m_lst_index.Add(e.RowHandle);
            }
        }

        private void update_du_lieu(DataRow v_dr) //Lưu dữ liệu từ gridview vào DB
        {
            try
            {
                US_GD_CHAM_CONG v_us = new US_GD_CHAM_CONG(CIPConvert.ToDecimal(v_dr["ID"].ToString()));
                v_us.Delete();
            }
            catch (Exception)
            {
                
            }
            if (v_dr["MA_NGAY_CONG"].ToString() == "")
            {
                return;
            }
            else
            {
                US_GD_CHAM_CONG v_us_gd_cc = new US_GD_CHAM_CONG();
                v_us_gd_cc.dcID_NHAN_VIEN = CIPConvert.ToDecimal(v_dr["ID_NHAN_VIEN"].ToString());
                v_us_gd_cc.dcID_LOAI_NGAY_CONG = get_id_loai_ngay_cong(v_dr["MA_NGAY_CONG"].ToString());
                v_us_gd_cc.datNGAY_CHAM_CONG = m_dat_ngay_cham_cong.Value.Date;
                v_us_gd_cc.strDA_XOA = "N";
                v_us_gd_cc.datNGAY_LAP = m_dat_ngay_cham_cong.Value;
                v_us_gd_cc.datNGAY_SUA = m_dat_ngay_cham_cong.Value;
                v_us_gd_cc.strNGUOI_LAP = "admin";
                v_us_gd_cc.strNGUOI_SUA = "admin";
                v_us_gd_cc.Insert();
            }
        }

        private decimal get_id_loai_ngay_cong(string ip_str_ma_ngay_cong)
        {
            EnumerableRowCollection<DataRow> res = from row in m_ds_loai_ngay_cong.Tables[0].AsEnumerable()
                                                   where row.Field<string>(DM_LOAI_NGAY_CONG.MA_NGAY_CONG).Trim() == ip_str_ma_ngay_cong.Trim()
                                                   select row;

            return CIPConvert.ToDecimal(res.First()[DM_LOAI_NGAY_CONG.ID].ToString());
        }

        private void m_cmd_insert_Click(object sender, EventArgs e)
        {
            try
            {
                luu_du_lieu();
                MessageBox.Show("Đã lưu thành công!");
                load_data_2_grid();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_grv_cham_cong_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            try
            {
                GridView view = sender as GridView;
                if (e.MenuType == DevExpress.XtraGrid.Views.Grid.GridMenuType.Row)
                {
                    int rowHandle = e.HitInfo.RowHandle;
                    e.Menu.Items.Clear();
                    foreach (DataRow item in m_ds_loai_ngay_cong.Tables[0].Rows)
                    {
                        e.Menu.Items.Add(CreateRowSubMenu(rowHandle, item["MA_NGAY_CONG"].ToString()));    
                    }
                    e.Menu.Items.Add(CreateRowSubMenu(rowHandle, ""));
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
            
        }

        private DXMenuItem CreateRowSubMenu(int rowHandle, string ip_str_ma_ngay_cong)
        {
            DXMenuItem menuItem = new DXMenuItem(ip_str_ma_ngay_cong, new EventHandler(ChonLoaiNgayCong));
            menuItem.Tag = rowHandle;
            return menuItem;
        }

        private void ChonLoaiNgayCong(object sender, EventArgs e)
        {
            DXMenuItem item = sender as DXMenuItem;
            int info = (int)item.Tag;
            m_grv_cham_cong.SetRowCellValue(int.Parse(info.ToString()), MA_NGAY_CONG, item.Caption);
        }

        private void m_grv_cham_cong_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (!m_lst_index.Exists(x => x == e.RowHandle))
            {
                m_lst_index.Add(e.RowHandle);
            }
        }
    }
}
