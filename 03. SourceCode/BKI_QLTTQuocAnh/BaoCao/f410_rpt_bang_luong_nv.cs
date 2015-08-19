using IP.Core.IPCommon;
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
using DevExpress.Spreadsheet;
using DevExpress.XtraSplashScreen;


namespace BKI_DichVuMatDat.BaoCao
{
    public partial class f410_rpt_bang_luong_nv : Form
    {
        int m_index = 4;
        public f410_rpt_bang_luong_nv()
        {
            InitializeComponent();
            format_controls();
        }

        #region Public Interface
        public void display()
        {
            this.ShowDialog();
        }
        #endregion

        #region Data Structure
       
        #endregion

        #region Members
        
        #endregion

        #region Private Methods
        private void format_controls()
        {
            this.KeyPreview = true;
        }

        private void load_data_2_work_sheet()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithQuery(v_ds, "SELECT distinct ID_NHAN_VIEN FROM GD_HOP_DONG AS ghd WHERE  ghd.ID_LOAI_HOP_DONG <> 4 AND DA_XOA = 'N' AND  ghd.NGAY_KET_THUC >= dbo.FN_GET_NGAY_DAU_THANG(6,2015)");
            load_bang_luong_nhan_vien(v_ds.Tables[0]);
        }

        private void load_bang_luong_nhan_vien(DataTable ip_dt)
        {
            for (int i = 0; i < ip_dt.Rows.Count; i++)
            {
                DataRow v_dr = ip_dt.Rows[i];
                DataRow v_dr_luong = get_luong_nhan_vien(CIPConvert.ToDecimal(v_dr["ID_NHAN_VIEN"]), 6, 2015);
                DataRow2Grid(v_dr_luong);
            }
        }

        delegate void BindTextSpreadSheetControl(DataRow ip_dr);

        private void UpdateSpreadSheet(DataRow _ip_dr)
        {
            IWorkbook v_wb = m_sp.Document;
            Worksheet v_ws = v_wb.Worksheets[0];
            for (int i = 0; i < _ip_dr.ItemArray.Length; i++)
            {
                long v_number = 0;
                bool canConvert = long.TryParse(_ip_dr.ItemArray[i].ToString(), out v_number);
                if (canConvert)
                {
                    v_ws.Cells[m_index, i + 2].Value = v_number;
                    v_ws.Cells[m_index, i + 2].NumberFormat = "#,##0";
                }
                else
                {
                    v_ws.Cells[m_index, i + 2].Value = _ip_dr.ItemArray[i].ToString();
                }
            }
            v_ws.Cells[m_index, 1].Value = m_index - 3;
            m_index += 1;
        }

        private void DataRow2Grid(DataRow ip_dr_luong)
        {
            this.Invoke(new BindTextSpreadSheetControl(UpdateSpreadSheet), new object[] { ip_dr_luong});
        }

        private DataRow get_luong_nhan_vien(decimal ip_dc_id_nhan_vien, int ip_int_thang, int ip_int_nam)
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillBangLuong(v_ds, ip_dc_id_nhan_vien, ip_int_thang, ip_int_nam);
            DataRow v_dr = v_ds.Tables[0].Rows[0];
            return v_dr;
        }

        #endregion

        private void m_cmd_bang_luong_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (m_bgwk.IsBusy)
                {
                    m_bgwk.CancelAsync();
                }
                else
                {
                    SplashScreenManager.ShowForm(typeof(F_wait_form));
                    m_bgwk.RunWorkerAsync();
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_bgwk_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                load_data_2_work_sheet();
                //m_bgwk.ReportProgress(100);
            }
            catch (Exception v_e)
            {

                MessageBox.Show("Có tý tẹo vấn đề. Bạn chụp ảnh và gửi để chúng tôi hỗ trợ nhé!" + v_e.ToString());
            }
        }

        private void m_bgwk_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            SplashScreenManager.CloseForm();
        }

        private void f410_rpt_bang_luong_nv_Load(object sender, EventArgs e)
        {
            try
            {
                load_header_rpt();
                set_width();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);   
            }
        }

        private void set_width()
        {
            IWorkbook v_wb = m_sp.Document;
            Worksheet v_ws = v_wb.Worksheets[0];
            v_ws.Columns[1].WidthInCharacters = 5;
            v_ws.Columns[2].WidthInCharacters = 8;
            v_ws.Columns[3].WidthInCharacters = 25;
            v_ws.Columns[4].WidthInCharacters = 12;
            v_ws.Columns[5].WidthInCharacters = 12;
            v_ws.Columns[6].WidthInCharacters = 12;
            v_ws.Columns[7].WidthInCharacters = 12;
            v_ws.Columns[8].WidthInCharacters = 12;
            v_ws.Columns[9].WidthInCharacters = 12;
            v_ws.Columns[10].WidthInCharacters = 12;
            v_ws.Columns[11].WidthInCharacters = 12;
            v_ws.Columns[12].WidthInCharacters = 12;
            v_ws.Columns[13].WidthInCharacters = 12;
            v_ws.Columns[14].WidthInCharacters = 12;
            v_ws.Columns[15].WidthInCharacters = 12;
            v_ws.Columns[16].WidthInCharacters = 12;
            v_ws.Columns[17].WidthInCharacters = 12;
        }
        
        private void load_header_rpt()
        {
            set_header(3, 1, "STT", Color.Blue, Color.White);
            set_header(3, 2, "Mã nhân viên", Color.Blue, Color.White);
            set_header(3, 3, "Họ tên", Color.Blue, Color.White);
            set_header(3, 4, "Lương năng suất", Color.Blue, Color.White);
            set_header(3, 5, "Lương chế độ", Color.Blue, Color.White);
            set_header(3, 6, "Phụ cấp trách nhiệm", Color.Blue, Color.White);
            set_header(3, 7, "Ăn ca", Color.Blue, Color.White);
            set_header(3, 8, "Làm thêm ngày thường", Color.Blue, Color.White);
            set_header(3, 9, "Làm thêm lễ tết", Color.Blue, Color.White);
            set_header(3, 10, "Thu nhập", Color.Blue, Color.White);
            set_header(3, 11, "BHXH", Color.Blue, Color.White);
            set_header(3, 12, "BHYT", Color.Blue, Color.White);
            set_header(3, 13, "BHTN", Color.Blue, Color.White);
            set_header(3, 14, "Đoàn phí", Color.Blue, Color.White);
            set_header(3, 15, "Thuế", Color.Blue, Color.White);
            set_header(3, 16, "Phải nộp", Color.Blue, Color.White);
            set_header(3, 17, "Thực lĩnh", Color.Blue, Color.White);
        }

        private void set_header(int ip_row, int ip_col, string ip_display_text, Color ip_back_color, Color ip_fore_color)
        {
            IWorkbook v_wb = m_sp.Document;
            Worksheet v_ws = v_wb.Worksheets[0];
            v_ws.Cells[ip_row, ip_col].Value = ip_display_text;
            v_ws.Cells[ip_row, ip_col].Font.Color = ip_fore_color;
            v_ws.Cells[ip_row, ip_col].Font.Bold = true;
            v_ws.Cells[ip_row, ip_col].FillColor = ip_back_color;
            v_ws.Cells[ip_row, ip_col].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
            v_ws.Cells[ip_row, ip_col].Alignment.Vertical = SpreadsheetVerticalAlignment.Center;
        }
    }
}
