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
using IP.Core.IPSystemAdmin;

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
        int m_so_nv_da_cham_cong = 0;

        private void load_data_2_grid(string ip_path)
        {
            m_grv.Columns.Clear();
            WinFormControls.load_xls_to_gridview(ip_path, m_grc);
            format_gridview();
        }

        private void format_gridview()
        {
            foreach (GridColumn item in m_grv.Columns)
            {
                DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition(DevExpress.XtraGrid.FormatConditionEnum.Expression);
                styleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Red;
                styleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.White;
                styleFormatCondition1.Appearance.Options.UseBackColor = true;
                styleFormatCondition1.Appearance.Options.UseForeColor = true;
                styleFormatCondition1.Column = item;
                styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
                styleFormatCondition1.Expression = "[" + item.Name + "] > 3";
                this.m_grv.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
                styleFormatCondition1});
            }
            m_grc.Refresh();
        }

        private void m_cmd_nhap_cham_cong_Click(object sender, EventArgs e)
        {
            try
            {
                if (m_txt_thang.Text == "" || m_txt_nam.Text=="")
                {
                    MessageBox.Show("Vui lòng nhập tháng và năm chấm công!");
                }
                else
                {
                    if (m_bgwk.IsBusy)
                    {
                        m_bgwk.CancelAsync();
                    }
                    else
                    {
                        LayDuLieuLoaiNgayCong();
                        LayDuLieuNhanVien();
                        if (checkBangChamCong())
                        {
                            if (check_db_da_cham_cong())
                            {
                                this.m_pn.Visible = true;
                                this.m_prb.Visible = true;
                                this.m_cmd_nhap_cham_cong.Text = "Đang lưu chấm công ...";
                                this.m_cmd_nhap_cham_cong.Enabled = false;
                                m_bgwk.RunWorkerAsync();
                            }
                            else
                            {
                                DialogResult v_dialog = MessageBox.Show("Hiện có " + m_so_nv_da_cham_cong + " nhân viên đã có dữ liệu chấm công. Bạn có muốn xóa dữ liệu cũ và nhập lại?", "Xác nhận", MessageBoxButtons.YesNo);
                                if (v_dialog == DialogResult.Yes)
                                {
                                    this.m_pn.Visible = true;
                                    this.m_prb.Visible = true;
                                    this.m_cmd_nhap_cham_cong.Text = "Đang lưu chấm công ...";
                                    this.m_cmd_nhap_cham_cong.Enabled = false;
                                    m_bgwk.RunWorkerAsync();
                                }
                            }
                        }

                    }
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
            xoa_du_lieu_cham_cong_cu(get_nhan_vien_by_ma_nv(ip_dataRow[0].ToString()));

            for (int i = 2; i < ip_dataRow.Table.Columns.Count - 1; i++)
            {
                try
                {
                    US_GD_CHAM_CONG v_us = new US_GD_CHAM_CONG();
                    v_us.dcID_NHAN_VIEN = get_nhan_vien_by_ma_nv(ip_dataRow[0].ToString());
                    v_us.datNGAY_CHAM_CONG = CIPConvert.ToDatetime(ip_dataRow.Table.Columns[i].ColumnName, "dd/MM/yyyy");
                    v_us.strDA_XOA = "N";
                    v_us.strNGUOI_LAP = CAppContext_201.getCurrentUserName();
                    v_us.datNGAY_LAP = DateTime.Now;
                    v_us.dcID_LOAI_NGAY_CONG = get_loai_ngay_cong(ip_dataRow[i].ToString());
                    v_us.Insert();
                }
                catch (Exception v_e)
                {
                    CSystemLog_301.ExceptionHandle(v_e);
                }
            }
            try
            {
                US_GD_HE_SO_CHAT_LUONG v_us_hsk = new US_GD_HE_SO_CHAT_LUONG();
                if (ip_dataRow[ip_dataRow.Table.Columns.Count - 1] != DBNull.Value)
                {
                    v_us_hsk.dcHE_SO_K = Convert.ToDecimal(ip_dataRow[ip_dataRow.Table.Columns.Count - 1]);
                }
                else
                {
                    v_us_hsk.dcHE_SO_K = 0;
                }

                v_us_hsk.dcID_NHAN_VIEN = get_nhan_vien_by_ma_nv(ip_dataRow[0].ToString());
                v_us_hsk.dcTHANG = CIPConvert.ToDecimal(m_txt_thang.Text);
                v_us_hsk.dcNAM = CIPConvert.ToDecimal(m_txt_nam.Text);
                v_us_hsk.datNGAY_LAP = DateTime.Now.Date;
                v_us_hsk.strDA_XOA = "N";
                v_us_hsk.strNGUOI_LAP = CAppContext_201.getCurrentUserName();
                v_us_hsk.Insert();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }            
        }

        private void xoa_du_lieu_cham_cong_cu(decimal ip_dc_id_nv)
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            v_us.xoa_du_lieu_cham_cong(ip_dc_id_nv, m_txt_thang.Text, m_txt_nam.Text);
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
            if (m_txt_thang.Text == "" || m_txt_nam.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tháng và năm chấm công!");
            }
            else
            {
                try
                {
                    //WinFormControls.openTemplate("ChamCong.xlsx");
                    tao_file_mau("ChamCong.xlsx");
                }
                catch (Exception v_e)
                {
                    CSystemLog_301.ExceptionHandle(v_e);
                }
            }           
        }

        private void tao_file_mau(string ip_str_file_name)
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.get_bang_cham_cong(v_ds, m_txt_thang.Text, m_txt_nam.Text);

            DateTime v_dat_bat_dau = new DateTime(int.Parse(m_txt_nam.Text), int.Parse(m_txt_thang.Text), 1);
            DateTime v_dat_ket_thuc = new DateTime(int.Parse(m_txt_nam.Text), int.Parse(m_txt_thang.Text), 1).AddMonths(1);

            for (DateTime i = v_dat_bat_dau; i < v_dat_ket_thuc; i = i.AddDays(1))
            {
                var v_c = new DataColumn();
                v_c.ColumnName = i.ToString("dd/MM/yyyy");
                v_ds.Tables[0].Columns.Add(v_c);
            }
            var v_c_hsk = new DataColumn();
            v_c_hsk.ColumnName = "HSK";
            v_ds.Tables[0].Columns.Add(v_c_hsk);
            m_grc.DataSource = v_ds.Tables[0];
            SaveXLSX(ip_str_file_name);
        }

        private void SaveXLSX(string ip_str_file_name)
        {
            string targetPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string newpath = targetPath + "\\" + "Chấm công tháng " + m_txt_thang.Text + "-" + m_txt_nam.Text + ".xls";
            m_grv.ExportToXls(newpath);
            DevExpress.XtraEditors.XtraMessageBox.Show("Đã lưu file mẫu tại " + newpath);
            var process = new System.Diagnostics.Process();
            process.StartInfo.FileName = newpath;
            process.StartInfo.Verb = "Open";
            process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
            process.Start();
        }

        private void m_bgwk_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            
            //if (checkBangChamCong())//checkBangChamCong())
            //{
            //    if (check_db_da_cham_cong())
            //    {
                    
                    for (int i = 0; i < m_grv.RowCount; i++)
                    {
                        nhapChamCong(m_grv.GetDataRow(i));
                        worker.ReportProgress((i + 1) * 100 / m_grv.RowCount);
                    }
                //}
                //else
                //{
                //    DialogResult v_dialog = MessageBox.Show("Hiện có " + m_so_nv_da_cham_cong + " nhân viên đã có dữ liệu chấm công. Bạn có muốn xóa dữ liệu cũ và nhập lại?", "Xác nhận", MessageBoxButtons.YesNo);
                //    if (v_dialog == DialogResult.Yes)
                //    {
                //        for (int i = 0; i < m_grv.RowCount; i++)
                //        {
                //            nhapChamCong(m_grv.GetDataRow(i));
                //            worker.ReportProgress((i + 1) * 100 / m_grv.RowCount);
                //        }
                //        CHRM_BaseMessages.MsgBox_Infor(CONST_ID_MSGBOX.INFOR_LUU_DU_LIEU_THANH_CONG);
                //    }

                //}
            //}
            //else
            //{
            //    CHRM_BaseMessages.MsgBox_Warning(CONST_ID_MSGBOX.WAR_KIEM_TRA_LAI_BANG_CHAM_CONG);
            //}
        }

        private bool check_db_da_cham_cong()
        {
            List<string> v_list_nv_da_cham_cong = new List<string>();
            DataSet v_ds = new DataSet();
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetChamCong(v_ds, m_txt_thang.Text, m_txt_nam.Text);
            for (int i = 0; i < m_grv.RowCount; i++)
            {
                var v_dr = m_grv.GetDataRow(i);
                DataRow[] v_dr_1_nv = v_ds.Tables[0].Select("MA_NV ='" + v_dr[0].ToString() + "'");
                if (v_dr_1_nv.Count()!=0)
                {
                    v_list_nv_da_cham_cong.Add(v_dr[0].ToString());
                }
            }
            if (v_list_nv_da_cham_cong.Count ==0)
            {
                return true;
            }
            else
            {
                m_so_nv_da_cham_cong = v_list_nv_da_cham_cong.Count;
                return false;
            }
            //if (v_ds.Tables[0].Rows.Count == 0)
            //{
            //    return 0;
            //}
            //else
            //{
            //    var distinctIds = v_ds.Tables[0].AsEnumerable()
            //        .Select(s => new
            //        {
            //            id = s.Field<string>("ID_NHAN_VIEN"),
            //        })
            //        .Distinct().ToList();
            //    return distinctIds.Count;
            //}
        }

        private bool checkBangChamCong()
        {
            //int v_int_dem_cham_cong_sai = 0;
            List<string> v_list_nv_ko_ton_tai = new List<string>();
            List<string> v_list_ngay_cong_ko_ton_tai = new List<string>();
            for (int i = 0; i < m_grv.RowCount; i++)
            {
                var v_dr = m_grv.GetDataRow(i);
                DataRow[] v_dr_1_nv = m_ds_nhan_vien.Tables[0].Select("MA_NV = '" + v_dr[0].ToString() + "'");
                if (v_dr_1_nv.Count() ==0)
                {
                    v_list_nv_ko_ton_tai.Add(v_dr[0].ToString());
                }
            }
            if (v_list_nv_ko_ton_tai.Count == 0)
            {
                for (int i = 0; i < m_grv.RowCount; i++)
                {
                    var v_dr = m_grv.GetDataRow(i);
                    for (int j = 2; j < m_grv.Columns.Count-1; j++)
                    {
                        //EnumerableRowCollection<DataRow> res = from row in m_ds_ngay_cong.Tables[0].AsEnumerable()
                        //                                       where row.Field<string>(DM_LOAI_NGAY_CONG.MA_NGAY_CONG).ToUpper() == v_dr[j].ToString().ToUpper()
                        //                                       select row;
                        DataRow[] v_dr_cham_cong = m_ds_ngay_cong.Tables[0].Select("MA_NGAY_CONG = '" + v_dr[j].ToString().ToUpper() + "'");
                        if (v_dr_cham_cong.Count() == 0)
                        {
                            v_list_ngay_cong_ko_ton_tai.Add(v_dr[j].ToString());
                            //m_grv.FocusedRowHandle = i;
                            //m_grv.FocusedColumn = m_grv.Columns[j];
                        }                        
                    }
                }
                if (v_list_ngay_cong_ko_ton_tai.Count ==0)
                {
                    if (m_grv.Columns[m_grv.Columns.Count -1].GetCaption().ToString().ToUpper() == "HSK")
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Bạn chưa nhập hệ số chất lượng. Vui lòng kiểm tra lại");
                        return false;
                    }
                }
                else
                {
                    string v_str_ma_ngay_cong = "";
                    foreach (var item in v_list_ngay_cong_ko_ton_tai)
                    {
                        if (!v_str_ma_ngay_cong.Contains(item))
                        {
                            v_str_ma_ngay_cong = v_str_ma_ngay_cong + item + " ";
                        }
                    }
                    MessageBox.Show("Không tồn tại mã ngày công '" + v_str_ma_ngay_cong +"'. Vui lòng kiểm tra lại");
                    return false;
                }
            }
            else
            {
                string v_str_ma_nv = "";
                foreach (var item in v_list_nv_ko_ton_tai)
                {
                    v_str_ma_nv = v_str_ma_nv + item+ " ";
                }
                MessageBox.Show("Nhân viên '" + v_str_ma_nv + "' không tồn tại. Vui lòng kiểm tra lại");
                return false;
            }
        }

        private void m_grv_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void m_bgwk_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.m_prb.EditValue = e.ProgressPercentage;
        }

        private void m_bgwk_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.m_prb.Visible = false;
            this.m_pn.Visible = false;
            this.m_cmd_nhap_cham_cong.Text = "Lưu chấm công";
            this.m_cmd_nhap_cham_cong.Enabled = true;

        }

        private void F696_Cham_cong_xls_Load(object sender, EventArgs e)
        {
            m_txt_thang.Text = DateTime.Now.Month.ToString();
            m_txt_nam.Text = DateTime.Now.Year.ToString();
            check_db_da_cham_cong();
            m_lbl_thong_bao.Text = "Đã chấm công cho " + m_so_nv_da_cham_cong +" nhân viên";
        }
    }
}
