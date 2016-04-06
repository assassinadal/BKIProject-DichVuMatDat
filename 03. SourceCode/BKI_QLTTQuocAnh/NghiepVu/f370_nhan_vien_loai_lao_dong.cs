using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using BKI_DichVuMatDat;
using BKI_DichVuMatDat.US;
using BKI_DichVuMatDat.DS;
using BKI_DichVuMatDat.DS.CDBNames;
using IP.Core.IPCommon;

using System.Globalization;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using BKI_DichVuMatDat.BaoCao;

namespace BKI_DichVuMatDat.NghiepVu
{
    public partial class f370_nhan_vien_loai_lao_dong : Form
    {
        public f370_nhan_vien_loai_lao_dong()
        {
            InitializeComponent();
            format_controls();
        }

        #region Public Interface
        private void display()
        {
            this.ShowDialog();
        }
        #endregion

        #region Members
        DataEntryFormMode m_e_form_mode = DataEntryFormMode.InsertDataState;
        decimal m_id_gd_loai_ld = 0;
        string m_txt_path = "";
        #endregion

        #region Private Methods

        private void format_controls()
        {
            FormatControl.SetVisibleSimpleButton(this);
            this.m_grv_v_gd_loai_lao_dong.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(WinFormControls.m_grv_PopupMenuShowing);
            this.m_grv_v_gd_loai_lao_dong.OptionsPrint.AutoWidth = false;
            set_define_event();
            this.KeyPreview = true;
        }

        private void set_initial_form_load()
        {
            load_data_2_grid();
        }

        private DataSet load_data_2_ds_v_dm_nv()
        {
            US_V_DM_NHAN_VIEN v_us = new US_V_DM_NHAN_VIEN();
            DS_V_DM_NHAN_VIEN v_ds = new DS_V_DM_NHAN_VIEN();
            
            v_us.FillDataset(v_ds);
            return v_ds;
        }

        private DataSet load_data_2_cm_dm_tu_dien(int ip_dc_id_vt)
        {
            US_CM_DM_TU_DIEN v_us = new US_CM_DM_TU_DIEN();
            DS_CM_DM_TU_DIEN v_ds = new DS_CM_DM_TU_DIEN();

            v_us.FillDatasetByIdLoaiTuDien(v_ds, ip_dc_id_vt);
            return v_ds;
        }

        //Load toan bo du lieu tu V_GD_LOAI_LAO_DONG len luoi 
        private void load_data_2_grid()
        {
            CHRMCommon.make_stt(m_grv_v_gd_loai_lao_dong);
            US_V_GD_LOAI_LAO_DONG v_us = new US_V_GD_LOAI_LAO_DONG();
            DS_V_GD_LOAI_LAO_DONG v_ds = new DS_V_GD_LOAI_LAO_DONG();
            v_us.FillDataset(v_ds);
            m_grc_v_gd_loai_lao_dong.DataSource = v_ds.Tables[0];
        }

        //Load du lieu len luoi theo id nhan vien
        //private void load_data_2_grid(decimal ip_dc_id_nv)
        //{
        //    CHRMCommon.make_stt(m_grv_v_gd_loai_lao_dong);
        //    US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
        //    DataSet v_ds = new DataSet();

        //    v_ds.Tables.Add(new DataTable());
        //    v_us.FillDatasetWithQuery(v_ds, "Select * from V_GD_LOAI_LAO_DONG WHERE ID = " + ip_dc_id_nv);
        //    m_grc_v_gd_loai_lao_dong.DataSource = v_ds.Tables[0];
        //}

        //Load du lieu len luoi theo id_loai_lao_dong
        //private void load_data_2_grid_with_id_loai_lao_dong(decimal ip_dc_id_loai_ld)
        //{
        //    CHRMCommon.make_stt(m_grv_v_gd_loai_lao_dong);
        //    US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
        //    DataSet v_ds = new DataSet();

        //    v_ds.Tables.Add(new DataTable());
        //    v_us.FillDatasetWithQuery(v_ds, "Select * from V_GD_LOAI_LAO_DONG WHERE ID_LOAI_LAO_DONG = " + ip_dc_id_loai_ld);
        //    m_grc_v_gd_loai_lao_dong.DataSource = v_ds.Tables[0];
        //}

        //Load du lieu len luoi theo id nhan vien va id loai lao dong
        //private void load_data_2_grid(decimal ip_dc_id_nv, decimal ip_dc_id_loai_ld)
        //{
        //    CHRMCommon.make_stt(m_grv_v_gd_loai_lao_dong);

        //    US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
        //    DataSet v_ds = new DataSet();

        //    v_ds.Tables.Add(new DataTable());

        //    v_us.FillDatasetWithQuery(v_ds, "select * from V_GD_LOAI_LAO_DONG WHere ID = " + ip_dc_id_nv + " AND ID_LOAI_LAO_DONG = " + ip_dc_id_loai_ld);
        //    m_grc_v_gd_loai_lao_dong.DataSource = v_ds.Tables[0];
        //}

        public void import_excel()
        {
            m_txt_path = WinFormControls.openFileDialog();
            if (m_txt_path != "")
            {
                f372_nhan_vien_loai_lao_dong_excel v_f = new f372_nhan_vien_loai_lao_dong_excel();
                v_f.displayToInsertExcel(m_txt_path);
            }
            load_data_2_grid();
        }

        #endregion

        private void f370_nhan_vien_loai_lao_dong_Load(object sender, EventArgs e)
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

        private void set_define_event()
        {
            this.Load += f370_nhan_vien_loai_lao_dong_Load;
            m_cmd_tai_file_excel_mau.Click += m_cmd_tai_file_excel_mau_Click;
            m_cmd_chon_file.Click += m_cmd_chon_file_Click;
        }

        void m_cmd_chon_file_Click(object sender, EventArgs e)
        {
            //OpenFileDialog openFileDialog1 = new OpenFileDialog();

            //// Set filter options and filter index.
            //openFileDialog1.Filter = "xlsx Files|*.xlsx|xls Files|*.xls|All Files (*.*)|*.*";
            //openFileDialog1.Multiselect = false;
            //var userClickedOK = openFileDialog1.ShowDialog();
            try
            {
                //if (userClickedOK == System.Windows.Forms.DialogResult.OK)
                //{
                //    m_txt_path = openFileDialog1.FileName;
                //    f372_nhan_vien_loai_lao_dong_excel v_f = new f372_nhan_vien_loai_lao_dong_excel();
                //    v_f.displayToInsertExcel(m_txt_path);
                //    // WinFormControls.load_xls_to_gridview(m_txt_path, m_grc);
                //}
                import_excel();
                //load_data_2_grid();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }



        void m_cmd_tai_file_excel_mau_Click(object sender, EventArgs e)
        {
            try
            {
                SplashScreenManager.ShowForm(typeof(F_wait_form));
                string fileName = "LOAI_LAO_DONG_CUA_NHAN_VIEN.xlsx";
                string sourcePath = (System.IO.Directory.GetCurrentDirectory() + "\\Template");
                string targetPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
                string destFile = System.IO.Path.Combine(targetPath, fileName);
                if (!System.IO.Directory.Exists(targetPath))
                {
                    System.IO.Directory.CreateDirectory(targetPath);
                }
                System.IO.File.Copy(sourceFile, destFile, true);
                string newpath = targetPath + "\\LOAI_LAO_DONG_CUA_NHAN_VIEN.xlsx";
                var excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = true;
                Microsoft.Office.Interop.Excel.Workbooks books = excel.Workbooks;
                Microsoft.Office.Interop.Excel.Workbook openexcel = books.Open(newpath);
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);

            }
            finally
            {
                SplashScreenManager.CloseForm();
            }
        }

        private void m_cmd_insert_Click(object sender, EventArgs e)
        {
            try
            {
                f371_nhan_vien_loai_lao_dong_de v_frm = new f371_nhan_vien_loai_lao_dong_de();
                v_frm.DisplayForInsert();
                load_data_2_grid();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_update_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow v_dr = m_grv_v_gd_loai_lao_dong.GetDataRow(m_grv_v_gd_loai_lao_dong.FocusedRowHandle);
                decimal v_id_gd_loai_lao_dong = CIPConvert.ToDecimal(v_dr[GD_LOAI_LAO_DONG.ID]);
                US_GD_LOAI_LAO_DONG v_us = new US_GD_LOAI_LAO_DONG(v_id_gd_loai_lao_dong);

                f371_nhan_vien_loai_lao_dong_de v_frm = new f371_nhan_vien_loai_lao_dong_de();
                v_frm.DisplayForUpdate(v_us);
                load_data_2_grid();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_delete_Click(object sender, EventArgs e)
        {
            try
            {
                //Lay ID cua dong du lieu muon xoa
                DataRow v_dr = m_grv_v_gd_loai_lao_dong.GetDataRow(m_grv_v_gd_loai_lao_dong.FocusedRowHandle);
                //Lay ID cua dong du lieu tren
                decimal v_id = CIPConvert.ToDecimal(v_dr[GD_LOAI_LAO_DONG.ID]);

                US_GD_LOAI_LAO_DONG v_us = new US_GD_LOAI_LAO_DONG(v_id);
                if (CHRM_BaseMessages.MsgBox_Confirm(CONST_ID_MSGBOX.QUESTION_XAC_NHAN_XOA_DU_LIEU) == true)
                {
                    v_us.Delete();
                    load_data_2_grid();
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
    }
}
