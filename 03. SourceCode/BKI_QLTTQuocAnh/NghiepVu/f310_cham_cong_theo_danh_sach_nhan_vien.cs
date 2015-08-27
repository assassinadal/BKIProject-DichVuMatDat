﻿using System;
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

        private DataView clone = null;

        public List<int> m_lst_index = new List<int>();

        #endregion

        #region Private methods
        private void format_controls()
        {
            set_define_events();
            this.KeyPreview = true;
        }

        private void set_initial_form_load()
        {
            //load_data_2_grid();
        }

        private void load_data_2_grid()
        {
            int v_row_count = 0;
            //DS_V_PRT_DANH_SACH_NHAN_VIEN_CON_HAN_HOP_DONG v_ds = new DS_V_PRT_DANH_SACH_NHAN_VIEN_CON_HAN_HOP_DONG();
            //US_V_PRT_DANH_SACH_NHAN_VIEN_CON_HAN_HOP_DONG v_us = new US_V_PRT_DANH_SACH_NHAN_VIEN_CON_HAN_HOP_DONG();

            //m_us.FillDatasetByNgayChamCong(m_ds, m_dat_ngay_cham_cong.Value.Date);
            CCommon.make_stt(m_grv_cham_cong);
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new System.Data.DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetGDChamCong(v_ds, m_dat_ngay_cham_cong.Value.Date);
            v_row_count = v_ds.Tables[0].Rows.Count;

            //for (int i = 0; i < v_row_count; i++)
            //{
            //    DataRow v_dr = v_ds.Tables[0].Rows[i];
            //    m_grv_cham_cong.AddNewRow();
            //    m_grv_cham_cong.SetRowCellValue(i, "MA_NV", v_dr["MA_NV"]);
            //    m_grv_cham_cong.SetRowCellValue(i, "HO_TEN", v_dr["HO_TEN"]);
            //    m_grv_cham_cong.SetRowCellValue(i, "ID_LOAI_NGAY_CONG", v_dr["ID_LOAI_NGAY_CONG"]);
            //}

            m_grc_cham_cong.DataSource = v_ds.Tables[0];

        }

        private DataSet load_data_2_ds_dm_loai_ngay_cong(DataSet v_ds_dm_loai_ngay_cong)
        {

            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds_ = new DataSet();
            v_ds_dm_loai_ngay_cong.Tables.Add(new DataTable());

            //  v_ds.EnforceConstraints = false;
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
            //Chinh hien thi nguoi dung
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

        #endregion

        private void set_define_events()
        {
            this.Load += f310_cham_cong_theo_danh_sach_nhan_vien_Load;
            m_cmd_search.Click += m_cmd_search_Click;
            m_cmd_insert.Click += m_cmd_insert_Click;
            //gridView1.ShowingEditor += gridView1_ShowingEditor;
            m_grv_cham_cong.CellValueChanged += m_grv_cham_cong_CellValueChanged;

        }

        private void f310_cham_cong_theo_danh_sach_nhan_vien_Load(object sender, EventArgs e)
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

        void m_cmd_search_Click(object sender, EventArgs e)
        {
            try
            {
                load_data_2_le_loai_ngay_cong();
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
            US_GD_CHAM_CONG v_us = new US_GD_CHAM_CONG();
            v_us.dcID_NHAN_VIEN = CIPConvert.ToDecimal(v_dr["ID"].ToString());
            v_us.dcID_LOAI_NGAY_CONG = CIPConvert.ToDecimal(v_dr["ID_NGAY_CONG"].ToString());
            v_us.datNGAY_CHAM_CONG = m_dat_ngay_cham_cong.Value;
            v_us.strDA_XOA = "N";
            v_us.datNGAY_LAP = m_dat_ngay_cham_cong.Value;
            v_us.datNGAY_SUA = m_dat_ngay_cham_cong.Value;
            v_us.strNGUOI_LAP = "admin";
            v_us.strNGUOI_SUA = "admin";
            v_us.Insert();

        }

        private void m_cmd_insert_Click(object sender, EventArgs e)
        {
            try
            {
                luu_du_lieu();
                //load_data_2_grid();
                MessageBox.Show("Đã lưu thành công!");
                load_data_2_grid();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
    }
}
