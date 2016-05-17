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

namespace BKI_DichVuMatDat.DanhMuc
{
    public partial class F105_dm_loai_ngay_cong : Form
    {
        public F105_dm_loai_ngay_cong()
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
        #endregion

        #region private methods
        private void format_controls()
        {
            this.m_grv_dm_loai_ngay_cong.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(WinFormControls.m_grv_PopupMenuShowing);
            this.m_grv_dm_loai_ngay_cong.OptionsPrint.AutoWidth = false;
            set_define_events();
            this.KeyPreview = true;
        }

        private void set_initial_form_load()
        {
            //FormatControl.SetVisibleSimpleButton(this);
            load_data_2_grid();
        }

        private void load_data_2_grid()
        {
            CHRMCommon.make_stt(m_grv_dm_loai_ngay_cong);
            //US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            //DataSet v_ds = new DataSet();

            //v_ds.Tables.Add(new DataTable());
            //throw new Exception("Sua lai khong dung FillDataSetWithTableName nua nhe");
            ////v_us.FillDatasetWithTableName(v_ds, "V_DM_LOAI_NGAY_CONG");
            US_V_DM_LOAI_NGAY_CONG v_us = new US_V_DM_LOAI_NGAY_CONG();
            DS_V_DM_LOAI_NGAY_CONG v_ds = new DS_V_DM_LOAI_NGAY_CONG();
            v_us.FillDataset(v_ds);
            m_grc_dm_loai_ngay_cong.DataSource = v_ds.Tables[0];
        }

        #endregion

        private void set_define_events()
        {
            this.Load += F105_dm_loai_ngay_cong_Load;
            m_cmd_update.Click += m_cmd_update_Click;
            m_cmd_delete.Click += m_cmd_delete_Click;
        }

        void F105_dm_loai_ngay_cong_Load(object sender, EventArgs e)
        {
            try
            {
                set_initial_form_load();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_insert_Click(object sender, EventArgs e)
        {
            try
            {
                F105_dm_loai_ngay_cong_de v_frm = new F105_dm_loai_ngay_cong_de();
                v_frm.DisplayForInsert();
                load_data_2_grid();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_update_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow v_dr = m_grv_dm_loai_ngay_cong.GetDataRow(m_grv_dm_loai_ngay_cong.FocusedRowHandle);
                decimal v_id = CIPConvert.ToDecimal(v_dr[DM_LOAI_NGAY_CONG.ID]);

                US_DM_LOAI_NGAY_CONG v_us = new US_DM_LOAI_NGAY_CONG(v_id);
                F105_dm_loai_ngay_cong_de v_frm = new F105_dm_loai_ngay_cong_de();
                v_frm.DisplayForUpdate(v_us);
                load_data_2_grid();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if(m_grv_dm_loai_ngay_cong.FocusedRowHandle < 0)
                {
                    XtraMessageBox.Show("Bạn cần chọn loại ngày công để xóa trước!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var v_dlg = XtraMessageBox.Show("CÂN NHẮC: Bạn có chắc chắn muốn xóa dữ liệu?\nDữ liệu loại ngày công dùng để chấm công và tính lương có thể được dùng trong các tháng trước!", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                if(v_dlg == System.Windows.Forms.DialogResult.Yes)
                {
                    DataRow v_dr = m_grv_dm_loai_ngay_cong.GetDataRow(m_grv_dm_loai_ngay_cong.FocusedRowHandle);
                    decimal v_id = CIPConvert.ToDecimal(v_dr[DM_LOAI_NGAY_CONG.ID]);
                    US_DM_LOAI_NGAY_CONG v_us_to_delete = new US_DM_LOAI_NGAY_CONG();
                    v_us_to_delete.DeleteByID(v_id);
                    XtraMessageBox.Show("Xóa dữ liệu thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load_data_2_grid();
                }
            }
            catch(Exception v_e)
            {
                XtraMessageBox.Show("Dữ liệu đã được sử dụng để chấm công, không được xóa!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                //CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private bool check_loai_ngay_cong_dang_su_dung(decimal ip_id_loai_ngay_cong)
        {
            US_GD_CHAM_CONG v_us = new US_GD_CHAM_CONG();
            DS_GD_CHAM_CONG v_ds = new DS_GD_CHAM_CONG();
            v_us.FillDataset(v_ds, "where id_loai_ngay_cong =" + ip_id_loai_ngay_cong);
            if(v_ds.Tables[0].Rows.Count == 0)
                return false;
            return true;
        }
    }
}
