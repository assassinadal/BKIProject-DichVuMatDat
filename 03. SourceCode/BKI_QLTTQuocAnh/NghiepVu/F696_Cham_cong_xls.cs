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

namespace BKI_DichVuMatDat.NghiepVu
{
    public partial class F696_Cham_cong_xls : Form
    {
        public F696_Cham_cong_xls()
        {
            InitializeComponent();
            FormatControl.SetVisibleSimpleButton(this);
            this.m_grv.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(WinFormControls.m_grv_PopupMenuShowing);
            this.m_grv.OptionsPrint.AutoWidth = false;
        }

        DataSet m_ds_ngay_cong = new DataSet();
        DataSet m_ds_nhan_vien = new DataSet();

        private void load_data_2_grid(string ip_path) {
            WinFormControls.load_xls_to_gridview(ip_path, m_grc);
        }

        private void m_cmd_nhap_cham_cong_Click(object sender, EventArgs e)
        {
            try
            {
                LayDuLieuLoaiNgayCong();
                LayDuLieuNhanVien();
                for (int i = 0; i < m_grv.RowCount; i++)
                {
                    nhapChamCong(m_grv.GetDataRow(i));
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
            
        }

        private void LayDuLieuNhanVien()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            m_ds_nhan_vien.Tables.Add(new DataTable());
            v_us.FillDatasetCBO(m_ds_nhan_vien, "DM_NHAN_VIEN", "ID", "MA_NV", "");
        }

        private void LayDuLieuLoaiNgayCong()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            m_ds_ngay_cong.Tables.Add(new DataTable());
            v_us.FillDatasetWithTableName(m_ds_ngay_cong, "DM_LOAI_NGAY_CONG");
        }

        private void nhapChamCong(DataRow ip_dataRow)
        {
            for (int i = 1; i < ip_dataRow.Table.Columns.Count; i++)
            {
                try
                {
                    US_GD_CHAM_CONG v_us = new US_GD_CHAM_CONG();
                    v_us.dcID_NHAN_VIEN = get_nhan_vien_by_ma_nv(ip_dataRow[0].ToString());
                    v_us.datNGAY_CHAM_CONG = CIPConvert.ToDatetime(ip_dataRow.Table.Columns[i].ColumnName, "dd/MM/yyyy");
                    v_us.strDA_XOA = "N";
                    v_us.dcID_LOAI_NGAY_CONG = get_loai_ngay_cong(ip_dataRow[i].ToString());
                    v_us.Insert();
                }
                catch (Exception)
                {
                    continue;
                }
                
            }
        }

        private decimal get_nhan_vien_by_ma_nv(string ip_ma_nhan_vien)
        {
            EnumerableRowCollection<DataRow> res = from row in m_ds_nhan_vien.Tables[0].AsEnumerable()
                                                   where row.Field<string>(DM_NHAN_VIEN.MA_NV) == ip_ma_nhan_vien
                                                   select row;

            return CIPConvert.ToDecimal(res.First()[DM_NHAN_VIEN.ID].ToString());
        }

        private decimal get_loai_ngay_cong(string ip_ma_ngay_cong)
        {
            EnumerableRowCollection<DataRow> res = from row in m_ds_ngay_cong.Tables[0].AsEnumerable()
                      where row.Field<string>(DM_LOAI_NGAY_CONG.MA_NGAY_CONG).ToUpper() == ip_ma_ngay_cong.ToUpper()
                      select row;
            
            return CIPConvert.ToDecimal(res.First()[DM_LOAI_NGAY_CONG.ID].ToString());
        }

        private void m_cmd_chon_du_lieu_Click(object sender, EventArgs e)
        {
            try
            {
                load_data_2_grid(WinFormControls.openFileDialog());
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_mo_file_mau_Click(object sender, EventArgs e)
        {
            try
            {
                WinFormControls.openTemplate("ChamCong.xlsx");
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
    }
}
