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
using System.Globalization;
using IP.Core.IPSystemAdmin;
using DevExpress.XtraSplashScreen;
using BKI_DichVuMatDat.BaoCao;


namespace BKI_DichVuMatDat.BaoCao
{
    public partial class f405_bao_cao_thong_tin_tinh_luong : Form
    {
        public f405_bao_cao_thong_tin_tinh_luong()
        {
            InitializeComponent();
            format_controls();
        }

        #region Public Interface
        
        #endregion

        #region Members

        #endregion

        #region Data Structure

        #endregion

        #region Private Methods
        private void format_controls()
        {
            FormatControl.SetVisibleSimpleButton(this);
            this.m_grv_f405.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(WinFormControls.m_grv_PopupMenuShowing);
            this.m_grv_f405.OptionsPrint.AutoWidth = false;
            set_define_events();
            this.KeyPreview = true;
        }

        private void set_init_form_load()
        {
            m_dat_tai_ngay.EditValue = DateTime.Now.Date;
        }

        private void load_data_2_grid()
        {
            CHRMCommon.make_stt(m_grv_f405);
            US_V_F405_BAO_CAO_THONG_TIN_TINH_LUONG v_us = new US_V_F405_BAO_CAO_THONG_TIN_TINH_LUONG();
            DS_V_F405_BAO_CAO_THONG_TIN_TINH_LUONG v_ds = new DS_V_F405_BAO_CAO_THONG_TIN_TINH_LUONG();

            v_us.FillDataset_by_Proc(v_ds, m_dat_tai_ngay.DateTime.Date);

            m_grc_f405.DataSource = v_ds.Tables[0];

            foreach (DevExpress.XtraGrid.Columns.GridColumn col in ((DevExpress.XtraGrid.Views.Base.ColumnView)m_grc_f405.Views[0]).Columns)
            {
                col.MaxWidth = 150;
                col.MinWidth = 100;

            }
        }

        #endregion

        #region Events Handle
        private void set_define_events()
        {
            this.Load += f405_bao_cao_thong_tin_tinh_luong_Load;
            this.FormClosed += f405_bao_cao_thong_tin_tinh_luong_FormClosed;
            m_cmd_loc_du_lieu.Click += m_cmd_loc_du_lieu_Click;
            m_cmd_xuat_excel.Click += m_cmd_xuat_excel_Click;
        }

        void f405_bao_cao_thong_tin_tinh_luong_Load(object sender, EventArgs e)
        {
            try
            {
                set_init_form_load();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);   
            }
        }

        void f405_bao_cao_thong_tin_tinh_luong_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                this.Dispose();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_loc_du_lieu_Click(object sender, EventArgs e)
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

        void m_cmd_xuat_excel_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "xls files (*.xls)|*.xls|All files (*.*)|*.*";
                saveFileDialog1.RestoreDirectory = true;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    m_grv_f405.ExportToXls(saveFileDialog1.FileName);
                    CHRM_BaseMessages.MsgBox_Infor(CONST_ID_MSGBOX.INFOR_LUU_BAO_CAO_THANH_CONG);
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        #endregion
    }
}
