using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BKI_DichVuMatDat.US;
using BKI_DichVuMatDat.DS;
using BKI_DichVuMatDat.DS.CDBNames;
using IP.Core.IPCommon;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Columns;
using System.Linq;

namespace BKI_DichVuMatDat.NghiepVu
{
    public partial class f394_cham_cong_thang : Form
    {
        public f394_cham_cong_thang()
        {
            InitializeComponent();
        }
        string m_str_ma_nv;
        string m_str_ngay;
        private void m_cmd_loc_Click(object sender, EventArgs e)
        {
            //US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            //DataSet v_ds = new DataSet();
            //v_ds.Tables.Add(new DataTable());
            //v_us.get_bang_cham_cong(v_ds, m_txt_thang.Text, m_txt_nam.Text);

            //DateTime v_dat_bat_dau = new DateTime(int.Parse(m_txt_nam.Text), int.Parse(m_txt_thang.Text), 1);
            //DateTime v_dat_ket_thuc = new DateTime(int.Parse(m_txt_nam.Text), int.Parse(m_txt_thang.Text), 1).AddMonths(1);

            //for (DateTime i = v_dat_bat_dau; i < v_dat_ket_thuc; i = i.AddDays(1))
            //{
            //    var v_c = new DataColumn();
            //    v_c.ColumnName = i.ToString("dd/MM/yyyy");
            //    v_ds.Tables[0].Columns.Add(v_c);
            //    DataTable v_dt = get_gd_cham_cong();
            //    DataTable v_dt_soure = v_ds.Tables[0];
            //    for (int j = 0; j < v_ds.Tables[0].Rows.Count; j++)
            //    {
            //        DataTable v_dr_theo_ngay = v_dt.Select("NGAY_CHAM_CONG = " + i.Date).CopyToDataTable();

            //        foreach (DataRow item in v_dt_soure.Rows)
            //        {
            //            var v_id_nv = Convert.ToDecimal(item["ID_NHAN_VIEN"]);

            //        }
            //    }               
            //}
             

            ////
            //B1 : Lay du lieu GD_CHAM_CONG 
            DataTable v_dt_gd_cham_cong = get_gd_cham_cong();
            //B2: Tao Datasoure
            DataTable v_dt_data_source = create_data_source();



            DateTime v_dat_bat_dau = new DateTime(int.Parse(m_txt_nam.Text), int.Parse(m_txt_thang.Text), 1);
            DateTime v_dat_ket_thuc = new DateTime(int.Parse(m_txt_nam.Text), int.Parse(m_txt_thang.Text), 1).AddMonths(1);
            for (DateTime i = v_dat_bat_dau; i < v_dat_ket_thuc; i = i.AddDays(1))
            {
                var v_c = new DataColumn();
                v_c.ColumnName = i.ToString("dd/MM/yyyy");
                v_dt_data_source.Columns.Add(v_c);


                DataTable v_dt_1_ngay = v_dt_gd_cham_cong.Select("NGAY_CHAM_CONG = " + v_dat_bat_dau.Date).CopyToDataTable();
                //for(int i = 0; i < v_dt_data_source.Rows.Count; i++){
                //    var id_nhan_vien = item["ID_NHAN_VIEN"];
                //    var id_loai_ngay_cong = v_dt_1_ngay.Select("ID_NHAN_VIEN = " + id_nhan_vien)[0]["ID_LOAI_NGAY_CONG"];

                //    v_dt_data_source.Rows
                //}
                
            }

            //B2.2: insert_dac cot theo ngay trong thang

            //B3: Insert du lieu cham cong theo tung ngay

        }

        private DataTable get_gd_cham_cong()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithTableName(v_ds, "V_GD_CHAM_CONG");
            return v_ds.Tables[0].Copy();
        }
        private DataTable create_data_source()
        {
            US_DUNG_CHUNG v_us_source = new US_DUNG_CHUNG();
            DataSet v_ds_source = new DataSet();
            v_ds_source.Tables.Add(new DataTable());
            v_us_source.get_bang_cham_cong(v_ds_source, m_txt_thang.Text, m_txt_nam.Text);


            //DateTime v_dat_bat_dau = new DateTime(int.Parse(m_txt_nam.Text), int.Parse(m_txt_thang.Text), 1);
            //DateTime v_dat_ket_thuc = new DateTime(int.Parse(m_txt_nam.Text), int.Parse(m_txt_thang.Text), 1).AddMonths(1);
            //for (DateTime i = v_dat_bat_dau; i < v_dat_ket_thuc; i = i.AddDays(1))
            //{
            //    var v_c = new DataColumn();
            //    v_c.ColumnName = i.ToString("dd/MM/yyyy");
            //    v_ds_source.Tables[0].Columns.Add(v_c);
            //}

            return v_ds_source.Tables[0].Copy();
        }
    }
}
