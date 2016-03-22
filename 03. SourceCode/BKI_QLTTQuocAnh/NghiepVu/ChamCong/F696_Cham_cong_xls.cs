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
        #region Public Interface
        public F696_Cham_cong_xls()
        {
            InitializeComponent();
            FormatControl.SetVisibleSimpleButton(this);
            this.m_grv.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(WinFormControls.m_grv_PopupMenuShowing);
            this.m_grv.OptionsPrint.AutoWidth = false;
            set_initial_form_load();
        }
        private void set_initial_form_load()
        {
            m_txt_thang.Text = DateTime.Now.Month.ToString();
            m_txt_nam.Text = DateTime.Now.Year.ToString();
            set_trang_thai_cham_cong();
            set_define_events();
        }
        #endregion

        #region Members
        US_GD_CHAM_CONG m_us_gd_cham_cong = new US_GD_CHAM_CONG();
        DataSet m_ds_ngay_cong = new DataSet();
        DataSet m_ds_nhan_vien = new DataSet();
        int m_so_nv_da_cham_cong = 0;
        #endregion

        #region Private Methods
        
        #region Tao file excel mau
        private void tao_file_mau(string ip_str_file_name)
        {
            m_grv.Columns.Clear();
            US_GD_CHAM_CONG v_us = new US_GD_CHAM_CONG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.get_bang_cham_cong(v_ds, m_txt_thang.Text, m_txt_nam.Text);

            DateTime v_dat_bat_dau = new DateTime(int.Parse(m_txt_nam.Text), int.Parse(m_txt_thang.Text), 1);
            DateTime v_dat_ket_thuc = new DateTime(int.Parse(m_txt_nam.Text), int.Parse(m_txt_thang.Text), 1).AddMonths(1);

            for (DateTime i = v_dat_bat_dau; i < v_dat_ket_thuc; i = i.AddDays(1))
            {
                var v_c = new DataColumn();
                v_c.ColumnName = i.ToString("dd/MM");
                v_ds.Tables[0].Columns.Add(v_c);
            }
            var v_c_hsk = new DataColumn();
            v_c_hsk.ColumnName = "HSK";
            v_ds.Tables[0].Columns.Add(v_c_hsk);
            m_grc.DataSource = v_ds.Tables[0];
            format_gridview();
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
        #endregion

        #region Load excel to grid
        private void load_data_2_grid(string ip_path)
        {
            m_grv.Columns.Clear();
            splashScreenManager1.ShowWaitForm();
            WinFormControls.load_xls_to_gridview(ip_path, m_grc);
            CHRMCommon.make_stt_indicator(m_grv);
            format_gridview();
            splashScreenManager1.CloseWaitForm();
        }

        private void format_gridview()
        {
            m_grv.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            m_grv.Columns[0].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            m_grv.Columns[1].Width = 120;
            for (int i = 2; i < m_grv.Columns.Count; i++)
            {
                m_grv.Columns[i].Width = 50;
                m_grv.Columns[i].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            }
            m_grc.Refresh();
        }
        #endregion

        #region Lay du lieu tu db
        private void LayDuLieuNhanVien()
        {
            US_DM_NHAN_VIEN v_us_nv = new US_DM_NHAN_VIEN();
            m_ds_nhan_vien.EnforceConstraints = false;
            m_ds_nhan_vien = new DS_DM_NHAN_VIEN();
            v_us_nv.FillDataset(m_ds_nhan_vien);
        }

        private void LayDuLieuLoaiNgayCong()
        {
            DS_DM_LOAI_NGAY_CONG v_ds = new DS_DM_LOAI_NGAY_CONG();
            US_DM_LOAI_NGAY_CONG v_us = new US_DM_LOAI_NGAY_CONG();
            v_us.FillDataset(v_ds);
            m_ds_ngay_cong = v_ds;
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
        #endregion

        #region Kiem tra du lieu tren grid
        private bool check_bang_luong_da_chot(string ip_thang, string ip_nam)
        {
            US_GD_CHOT_BANG_LUONG v_us = new US_GD_CHOT_BANG_LUONG();
            if (v_us.IsDaChotBangLuongThang(decimal.Parse(ip_thang), decimal.Parse(ip_nam)))
                return true;
            else return false;
        }

        private bool check_cham_cong_hop_le()
        {
            LayDuLieuLoaiNgayCong();
            LayDuLieuNhanVien();
            if (!checkBangChamCong())
                return false;
            int v_so_nv_da_cham_cong = check_db_da_cham_cong();
            if (v_so_nv_da_cham_cong !=0)
            {
                string v_str_confirm = "Hiện có " + v_so_nv_da_cham_cong + "/"+ m_grv.RowCount+ " nhân viên trong bảng chấm công đã có dữ liệu. \nBạn có muốn xóa dữ liệu cũ của những nhân viên này và nhập lại?";
                DialogResult v_dialog = XtraMessageBox.Show(v_str_confirm, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (v_dialog == DialogResult.No)
                    return false;                
            }
            return true;
        }

        private decimal get_so_luong_cham_cong()
        {
            DS_GD_CHAM_CONG v_ds = new DS_GD_CHAM_CONG();
            US_GD_CHAM_CONG v_us = new US_GD_CHAM_CONG();
            v_us.FillDatasetChamCong(v_ds, m_txt_thang.Text, m_txt_nam.Text);
            DataTable v_dt = v_ds.Tables[0].DefaultView.ToTable(true, "ID_NHAN_VIEN");
            return v_dt.Rows.Count;
        }

        private int check_db_da_cham_cong()
        {
            int v_so_nv_da_cham_cong = 0;
            DS_GD_CHAM_CONG v_ds = new DS_GD_CHAM_CONG();
            US_GD_CHAM_CONG v_us = new US_GD_CHAM_CONG();
            v_us.FillDatasetChamCong(v_ds, m_txt_thang.Text, m_txt_nam.Text);
            for (int i = 0; i < m_grv.RowCount; i++)
            {
                var v_dr = m_grv.GetDataRow(i);
                DataRow[] v_dr_1_nv = v_ds.Tables[0].Select("MA_NV ='" + v_dr[0].ToString() + "'");
                if (v_dr_1_nv.Count() != 0)
                    v_so_nv_da_cham_cong++;
            }
            return v_so_nv_da_cham_cong;
        }

        private bool checkBangChamCong()
        {
            if (m_grv.Columns[m_grv.Columns.Count - 1].GetCaption().ToString().ToUpper() != "HSK")
            {
                XtraMessageBox.Show("Bạn chưa nhập hệ số chất lượng. \nVui lòng kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (check_he_so_chat_luong_sai())
                return false;
            else if (check_ma_nv_duplicate())
                return false;
            else if (check_ma_nv_ko_ton_tai())
                return false;
            else if (check_ngay_cong_ko_ton_tai())
                return false;          
            return true;
            
        }

        private bool check_ma_nv_duplicate()
        {
            DataTable v_dt = new DataTable();
            v_dt.Columns.Add();
            for (int i = 0; i < m_grv.RowCount; i++)
            {
                var v_dr = m_grv.GetDataRow(i);
                v_dt.Rows.Add(v_dr[0]);
            }
            var duplicate = v_dt.AsEnumerable().GroupBy(r => r[0]).Where(gr => gr.Count() > 1);
            if (duplicate.Any())
            {
                string v_str = "Mã nhân viên '" + string.Join(",", duplicate.Select(dupl => dupl.Key)) + "' đang bị trùng. \nVui lòng kiểm tra lại!";
                XtraMessageBox.Show(v_str, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }

        private bool check_he_so_chat_luong_sai()
        {
            for (int i = 0; i < m_grv.RowCount; i++)
            {
                var v_dr = m_grv.GetDataRow(i);
                decimal v_dc_he_so_k;
                if (v_dr[v_dr.Table.Columns.Count - 1].ToString().Trim() != "" && !decimal.TryParse(v_dr[v_dr.Table.Columns.Count - 1].ToString().Trim(), out v_dc_he_so_k))
                {
                    string v_str = "Vui lòng kiểm tra lại hệ số chất lượng của nhân viên '" + v_dr[0].ToString() + "'";
                    XtraMessageBox.Show(v_str, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true;
                }
            }
            return false;
        }

        private bool check_ngay_cong_ko_ton_tai()
        {
            for (int i = 0; i < m_grv.RowCount; i++)
            {
                var v_dr = m_grv.GetDataRow(i);
                for (int j = 2; j < m_grv.Columns.Count - 1; j++)
                {  
                    if (v_dr[j].ToString().Trim() != "")
                    {
                        if (v_dr[j].ToString().Trim().Length >= 3)
                        {
                            DataRow[] v_dr_cham_cong = m_ds_ngay_cong.Tables[0].Select("MA_NGAY_CONG = '" + v_dr[j].ToString().Substring(2).ToUpper() + "'");
                            if (v_dr_cham_cong.Count() == 0)
                            {
                                string v_str_error = "Không tồn tại mã ngày công '" + v_dr[j].ToString() + "'\nVui lòng kiểm tra lại!";
                                XtraMessageBox.Show(v_str_error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return true;
                            }
                        }
                        else
                        {
                            string v_str_error_1 = "Không tồn tại mã ngày công '" + v_dr[j].ToString() + "'\nVui lòng kiểm tra lại!";
                            XtraMessageBox.Show(v_str_error_1, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return true;
                        }                        
                    } 
                }
            }
            return false;                        
        }

        //private void get_lst_ngay_cong_ko_ton_tai(string ip_str_ngay_cong)
        //{
        //    if (ip_str_ngay_cong.Trim() != "" && !m_list_ngay_cong_ko_ton_tai.Contains(ip_str_ngay_cong))
        //    {
        //        if (ip_str_ngay_cong.Trim().Length >=3)
        //        {
        //            DataRow[] v_dr_cham_cong = m_ds_ngay_cong.Tables[0].Select("MA_NGAY_CONG = '" + ip_str_ngay_cong.Substring(2).ToUpper() + "'");
        //            if (v_dr_cham_cong.Count() != 0)
        //                return;
        //        }
        //        m_list_ngay_cong_ko_ton_tai.Add(ip_str_ngay_cong);
        //    } 
        //}

        private bool check_ma_nv_ko_ton_tai()
        {
            for (int i = 0; i < m_grv.RowCount; i++)
            {
                var v_dr = m_grv.GetDataRow(i);
                DataRow[] v_dr_1_nv = m_ds_nhan_vien.Tables[0].Select("MA_NV = '" + v_dr[0].ToString() + "'");
                if (v_dr_1_nv.Count() == 0)
                {
                    string v_str_error = "Không tồn tại mã nhân viên '" + v_dr[0].ToString() + "'\nVui lòng kiểm tra lại!";
                    XtraMessageBox.Show(v_str_error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true;
                }
            }
            return false;
            
        }

        #endregion
        
        #region Luu du lieu vao db

        private void m_bgwk_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            m_us_gd_cham_cong.BeginTransaction();
            for (int i = 0; i < m_grv.RowCount; i++)
            {
                luuChamCong(m_grv.GetDataRow(i));
                worker.ReportProgress((i + 1) * 100 / m_grv.RowCount);
            }
            m_us_gd_cham_cong.CommitTransaction();
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
            //this.m_cmd_nhap_cham_cong.Enabled = false;
            XtraMessageBox.Show("Lưu thành công!");
            m_grc.DataSource = null; 
            set_trang_thai_cham_cong();          
        }

        private void luuChamCong(DataRow ip_dataRow)
        {
            xoa_du_lieu_cham_cong_cu(get_nhan_vien_by_ma_nv(ip_dataRow[0].ToString()));
            insert_gd_cham_cong(ip_dataRow);
            insert_gd_he_so_chat_luong(ip_dataRow);
        }

        private void xoa_du_lieu_cham_cong_cu(decimal ip_dc_id_nv)
        {
            US_GD_CHAM_CONG v_us = new US_GD_CHAM_CONG();
            v_us.UseTransOfUSObject(m_us_gd_cham_cong);
            v_us.xoa_du_lieu_cham_cong(ip_dc_id_nv, m_txt_thang.Text, m_txt_nam.Text);
        }

        private void insert_gd_cham_cong(DataRow ip_dataRow)
        {
            for (int i = 2; i < ip_dataRow.Table.Columns.Count - 1; i++)
            {
                try
                {
                    US_GD_CHAM_CONG v_us = new US_GD_CHAM_CONG();
                    v_us.dcID_NHAN_VIEN = get_nhan_vien_by_ma_nv(ip_dataRow[0].ToString());
                    int v_thang_cham_cong = int.Parse(ip_dataRow.Table.Columns[i].ColumnName.ToString().Substring(3, 2));
                    int v_ngay_cham_cong = int.Parse(ip_dataRow.Table.Columns[i].ColumnName.ToString().Substring(0, 2));
                    v_us.datNGAY_CHAM_CONG = new DateTime(int.Parse(m_txt_nam.Text), v_thang_cham_cong, v_ngay_cham_cong);
                    v_us.strDA_XOA = "N";
                    v_us.strNGUOI_LAP = CAppContext_201.getCurrentUserName();
                    v_us.datNGAY_LAP = DateTime.Now;
                    if (ip_dataRow[i].ToString().Trim() == "")
                        v_us.dcID_LOAI_NGAY_CONG = get_loai_ngay_cong(ip_dataRow[i].ToString());
                    else
                        v_us.dcID_LOAI_NGAY_CONG = get_loai_ngay_cong(ip_dataRow[i].ToString().Substring(2));                   
                    v_us.UseTransOfUSObject(m_us_gd_cham_cong);
                    v_us.Insert();
                }
                catch (Exception v_e)
                {
                    CSystemLog_301.ExceptionHandle(v_e);
                }
            }
        }

        private void insert_gd_he_so_chat_luong(DataRow ip_dataRow)
        {
            try
            {
                US_GD_HE_SO_CHAT_LUONG v_us_hsk = new US_GD_HE_SO_CHAT_LUONG();
                if (ip_dataRow[ip_dataRow.Table.Columns.Count - 1] != DBNull.Value)
                    v_us_hsk.dcHE_SO_K = Convert.ToDecimal(ip_dataRow[ip_dataRow.Table.Columns.Count - 1]);
                else
                    v_us_hsk.dcHE_SO_K = 0;
                v_us_hsk.dcID_NHAN_VIEN = get_nhan_vien_by_ma_nv(ip_dataRow[0].ToString());
                v_us_hsk.dcTHANG = CIPConvert.ToDecimal(m_txt_thang.Text);
                v_us_hsk.dcNAM = CIPConvert.ToDecimal(m_txt_nam.Text);
                v_us_hsk.datNGAY_LAP = DateTime.Now.Date;
                v_us_hsk.strDA_XOA = "N";
                v_us_hsk.strNGUOI_LAP = CAppContext_201.getCurrentUserName();
                v_us_hsk.UseTransOfUSObject(m_us_gd_cham_cong);
                v_us_hsk.Insert();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void set_trang_thai_cham_cong()
        {
            m_lbl_trang_thai_cham_cong.Text = "Đã chấm công cho " + get_so_luong_cham_cong() + " nhân viên";
        }
        #endregion

        #endregion

        #region Events Handle
        private void set_define_events()
        {
            m_cmd_mo_file_mau.Click +=m_cmd_mo_file_mau_Click;
            m_cmd_chon_du_lieu.Click +=m_cmd_chon_du_lieu_Click;
            m_cmd_nhap_cham_cong.Click +=m_cmd_nhap_cham_cong_Click;
            this.Load +=F696_Cham_cong_xls_Load;
            m_txt_thang.EditValueChanged += m_txt_thang_EditValueChanged;
            m_txt_nam.EditValueChanged += m_txt_nam_EditValueChanged;
            m_cmd_tong_hop_cham_cong.Click += m_cmd_tong_hop_cham_cong_Click;
        }

        void m_cmd_tong_hop_cham_cong_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(m_txt_thang.Text) <= 0 || int.Parse(m_txt_thang.Text) > 12 || int.Parse(m_txt_nam.Text) < 0)
                {
                    XtraMessageBox.Show("Vui lòng nhập tháng và năm chấm công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                BaoCao.f402_tong_hop_cham_cong v_f = new BaoCao.f402_tong_hop_cham_cong(m_txt_thang.Text, m_txt_nam.Text);
                v_f.Show();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_txt_nam_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                set_trang_thai_cham_cong();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_txt_thang_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                set_trang_thai_cham_cong();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void F696_Cham_cong_xls_Load(object sender, EventArgs e)
        {
            try
            {
                set_trang_thai_cham_cong();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
            
        }

        private void m_cmd_nhap_cham_cong_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(m_txt_thang.Text) <= 0 || int.Parse(m_txt_thang.Text) > 12 || int.Parse(m_txt_nam.Text) < 0)
                    XtraMessageBox.Show("Vui lòng nhập tháng và năm chấm công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (check_bang_luong_da_chot(m_txt_thang.Text, m_txt_nam.Text))
                    XtraMessageBox.Show("Tháng đã chốt bảng lương. \nVui lòng ko cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                else if (m_bgwk.IsBusy)
                    m_bgwk.CancelAsync();
                else if (check_cham_cong_hop_le())
                {
                    this.m_pn.Visible = true;
                    this.m_prb.Visible = true;
                    this.m_cmd_nhap_cham_cong.Text = "Đang lưu chấm công ...";
                    this.m_cmd_nhap_cham_cong.Enabled = false;
                    m_bgwk.RunWorkerAsync();
                }       
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_chon_du_lieu_Click(object sender, EventArgs e)
        {           
            try
            {
                string ip_path = WinFormControls.openFileDialog();
                if (ip_path != "")
                {
                    load_data_2_grid(ip_path);
                    m_cmd_nhap_cham_cong.Enabled = true;
                }
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
                if (int.Parse(m_txt_thang.Text)<=0 || int.Parse(m_txt_thang.Text)>12 || int.Parse(m_txt_nam.Text) <0)
                    XtraMessageBox.Show("Vui lòng nhập tháng và năm chấm công!","Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else tao_file_mau("ChamCong.xlsx");
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        #endregion

    }
}
