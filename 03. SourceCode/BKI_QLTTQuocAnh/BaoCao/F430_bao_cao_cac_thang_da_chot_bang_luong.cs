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



namespace BKI_DichVuMatDat.BaoCao
{
    public partial class F430_bao_cao_cac_thang_da_chot_bang_luong : Form
    {
        public F430_bao_cao_cac_thang_da_chot_bang_luong()
        {
            InitializeComponent();
            format_controls();
        }

        #region Public interface

        #endregion

        #region Members

        #endregion

        #region Private methods
        private void format_controls()
        {
            this.m_grv_bc_cac_thang_da_chot_bang_luong.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(WinFormControls.m_grv_PopupMenuShowing);
            this.m_grv_bc_cac_thang_da_chot_bang_luong.OptionsPrint.AutoWidth = false;
            set_define_events();
            this.KeyPreview = true;
        }

        private void set_intial_form_load()
        {
            load_data_2_grid();
        }

        private void load_data_2_grid()
        {
            CHRMCommon.make_stt(m_grv_bc_cac_thang_da_chot_bang_luong);
            //US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            //DataSet v_ds = new DataSet();
            //v_ds.Tables.Add(new DataTable());
            //throw new Exception("Sua lai khong dung FillDataSetWithTableName nua nhe");
            //v_us.FillDatasetWithTableName(v_ds, "GD_CHOT_BANG_LUONG");
            US_GD_CHOT_BANG_LUONG v_us = new US_GD_CHOT_BANG_LUONG();
            DS_GD_CHOT_BANG_LUONG v_ds = new DS_GD_CHOT_BANG_LUONG();
            v_us.FillDataset(v_ds);
            m_grc_bc_cac_thang_da_chot_bang_luong.DataSource = v_ds.Tables[0];
        }

        #endregion
        private void set_define_events()
        {
            this.Load += F430_bao_cao_cac_thang_da_chot_bang_luong_Load;
            m_cmd_delete.Click += m_cmd_delete_Click;
        }

        void m_cmd_delete_Click(object sender, EventArgs e)
        {
            try
            {
                decimal v_id_gd_chot_bang_luong = CIPConvert.ToDecimal(m_grv_bc_cac_thang_da_chot_bang_luong.GetRowCellValue(m_grv_bc_cac_thang_da_chot_bang_luong.FocusedRowHandle, "ID"));
                decimal v_thang_chot_bang_luong = CIPConvert.ToDecimal(m_grv_bc_cac_thang_da_chot_bang_luong.GetRowCellValue(m_grv_bc_cac_thang_da_chot_bang_luong.FocusedRowHandle, "THANG"));
                decimal v_nam_chot_bang_luong = CIPConvert.ToDecimal(m_grv_bc_cac_thang_da_chot_bang_luong.GetRowCellValue(m_grv_bc_cac_thang_da_chot_bang_luong.FocusedRowHandle, "NAM"));

                if (CHRM_BaseMessages.MsgBox_Confirm("Bạn có chắc chắn muốn bỏ chốt của bảng lương tháng " + v_thang_chot_bang_luong.ToString() + " năm " + v_nam_chot_bang_luong.ToString() + " không?") == true)
                {
                    US_GD_CHOT_BANG_LUONG v_us = new US_GD_CHOT_BANG_LUONG(v_id_gd_chot_bang_luong);
                    try
                    {
                        v_us.BeginTransaction();
                        v_us.Delete();
                        v_us.CommitTransaction();
                    }
                    catch (Exception v_e)
                    {
                        throw v_e;
                    }
                    CHRM_BaseMessages.MsgBox_Infor(CONST_ID_MSGBOX.INFOR_DU_LIEU_DA_DUOC_CAP_NHAT);
                    load_data_2_grid();
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void F430_bao_cao_cac_thang_da_chot_bang_luong_Load(object sender, EventArgs e)
        {
            try
            {
                set_intial_form_load();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

    }
}
