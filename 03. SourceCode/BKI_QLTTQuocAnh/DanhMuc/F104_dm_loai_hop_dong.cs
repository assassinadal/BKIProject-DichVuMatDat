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

namespace BKI_DichVuMatDat.DanhMuc
{
    public partial class F104_dm_loai_hop_dong : Form
    {
        public F104_dm_loai_hop_dong()
        {
            InitializeComponent();
        }

        private void F104_dm_loai_hop_dong_Load(object sender, EventArgs e)
        {
            //FormatControl.SetVisibleSimpleButton(this);
            this.m_grv_dm_loai_hop_dong.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(WinFormControls.m_grv_PopupMenuShowing);
            this.m_grv_dm_loai_hop_dong.OptionsPrint.AutoWidth = false;
            load_data_2_grid();
        }

        private void load_data_2_grid()
        {
            CHRMCommon.make_stt(m_grv_dm_loai_hop_dong);
            //US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            //DataSet v_ds = new DataSet();
            //v_ds.Tables.Add(new DataTable());
            //throw new Exception("Sua lai khong dung FillDataSetWithTableName nua nhe");
            ////v_us.FillDatasetWithTableName(v_ds, "V_DM_LOAI_HOP_DONG");
            US_V_DM_LOAI_HOP_DONG v_us = new US_V_DM_LOAI_HOP_DONG();
            DS_V_DM_LOAI_HOP_DONG v_ds = new DS_V_DM_LOAI_HOP_DONG();
            v_us.FillDataset(v_ds);
            m_grc_dm_loai_hop_dong.DataSource = v_ds.Tables[0];
        }

        private void m_cmd_insert_Click(object sender, EventArgs e)
        {
            try
            {
                F104_dm_loai_hop_dong_de v_frm = new F104_dm_loai_hop_dong_de();
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
                DataRow v_dr = m_grv_dm_loai_hop_dong.GetDataRow(m_grv_dm_loai_hop_dong.FocusedRowHandle);
                decimal v_id = CIPConvert.ToDecimal(v_dr[DM_LOAI_HOP_DONG.ID]);

                US_DM_LOAI_HOP_DONG v_us = new US_DM_LOAI_HOP_DONG(v_id);
                F104_dm_loai_hop_dong_de v_frm = new F104_dm_loai_hop_dong_de();
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
                //Lay dong du lieu can xoa
                DataRow v_dr = m_grv_dm_loai_hop_dong.GetDataRow(m_grv_dm_loai_hop_dong.FocusedRowHandle);
                //Lay ID cua dong du lieu tren
                decimal v_id = CIPConvert.ToDecimal(v_dr[DM_LOAI_HOP_DONG.ID]);
                if (CHRM_BaseMessages.MsgBox_Confirm(CONST_ID_MSGBOX.QUESTION_XAC_NHAN_XOA_LOAI_HOP_DONG) == true)
                {
                    if (check_loai_hd_dang_su_dung(v_id))
                    {
                        string v_str_error = " Không thể xóa loại hợp đồng đang được sử dụng!";
                        XtraMessageBox.Show(v_str_error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    US_DM_LOAI_HOP_DONG v_us = new US_DM_LOAI_HOP_DONG(v_id);
                    v_us.Delete();
                    XtraMessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                    load_data_2_grid();
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private bool check_loai_hd_dang_su_dung(decimal ip_id_loai_hd)
        {
            US_GD_HOP_DONG v_us = new US_GD_HOP_DONG();
            DS_GD_HOP_DONG v_ds = new DS_GD_HOP_DONG();
            v_us.FillDataset(v_ds, "where id_loai_hop_dong =" + ip_id_loai_hd);
            if (v_ds.Tables[0].Rows.Count == 0)
                return false;
            return true;
        }

    }
}
