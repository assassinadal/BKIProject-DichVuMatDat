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
using DevExpress.XtraCharts;
using BKI_DichVuMatDat.US;
using BKI_DichVuMatDat.DS;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrintingLinks;

namespace BKI_DichVuMatDat.BaoCao
{
    public partial class f410_bao_cao_so_luong_chat_luong_lao_dong : Form
    {
        public f410_bao_cao_so_luong_chat_luong_lao_dong()
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
            //this.m_grv_f410.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(WinFormControls.m_grv_PopupMenuShowing);
            //this.m_grv_f410.OptionsPrint.AutoWidth = false;
            set_define_events();
            this.KeyPreview = true;
        }

        private void set_init_form_load()
        {
            load_data_2_grid();
        }

        private void load_data_2_grid()
        {
            US_V_F410_BAO_CAO_SO_LUONG_CHAT_LUONG_NHAN_VIEN v_us = new US_V_F410_BAO_CAO_SO_LUONG_CHAT_LUONG_NHAN_VIEN();
            DS_V_F410_BAO_CAO_SO_LUONG_CHAT_LUONG_NHAN_VIEN v_ds = new DS_V_F410_BAO_CAO_SO_LUONG_CHAT_LUONG_NHAN_VIEN();

            v_us.FillDataset(v_ds);

            m_pgc_f410.DataSource = v_ds.Tables[0];
        }

        #endregion

        #region Events Handle
        private void set_define_events()
        {
            this.Load += f410_bao_cao_so_luong_chat_luong_lao_dong_Load;
        }

        void f410_bao_cao_so_luong_chat_luong_lao_dong_Load(object sender, EventArgs e)
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

        #endregion
        
    }
}
