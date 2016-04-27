using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BKI_DichVuMatDat.DS;
using BKI_DichVuMatDat.US;
using IP.Core.IPCommon;

namespace BKI_DichVuMatDat.NghiepVu
{
    public partial class f372_nhan_vien_loai_lao_dong_excel : Form
    {
        public f372_nhan_vien_loai_lao_dong_excel()
        {
            InitializeComponent();
            format_controls();
        }

        #region Public Interface
        public void displayToInsertExcel(string m_txt_path)
        {
            WinFormControls.load_xls_to_gridview(m_txt_path, m_grc);
            foreach (DevExpress.XtraGrid.Columns.GridColumn col in ((DevExpress.XtraGrid.Views.Base.ColumnView)m_grc.Views[0]).Columns)
            {
                col.MaxWidth = 100;
                col.MinWidth = 100;
            }
            this.ShowDialog();
        }
        #endregion

        #region Members

        #endregion

        #region Private Methods
        private void format_controls()
        {
            FormatControl.SetVisibleSimpleButton(this);
            this.m_grv.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(WinFormControls.m_grv_PopupMenuShowing);
            this.m_grv.OptionsPrint.AutoWidth = false;
            set_define_event();
            this.KeyPreview = true;
        }

        private void set_init_form_load()
        {

        }

        private bool checked_du_lieu_is_ok()
        {
            // chưa check, mới check số dòng >0
            if (m_grv.DataRowCount > 0)
                return true;
            else
                return false;
        }

        private bool check_ma_nhan_vien_is_ok(DataRow dataRow)
        {
            decimal v_id_nhan_vien = find_id_nhan_vien_by_ma_nv(dataRow["MA_NV"].ToString().Trim());
            if (v_id_nhan_vien == -1) return false;
            US_GD_LOAI_LAO_DONG v_us_gd_loai_lao_dong = new US_GD_LOAI_LAO_DONG();
            DS_GD_LOAI_LAO_DONG v_ds_gd_loai_lao_dong = new DS_GD_LOAI_LAO_DONG();
            v_us_gd_loai_lao_dong.FillDataset(v_ds_gd_loai_lao_dong, "where id_nhan_vien = " + v_id_nhan_vien);

            if (v_ds_gd_loai_lao_dong.Tables[0].Rows.Count > 0)
                return false;
            else
            {
                return true;
            }
        }

        private void gan_du_lieu_cho_us_dm_nhan_vien(DataRow dataRow)
        {
            US_GD_LOAI_LAO_DONG v_us = new US_GD_LOAI_LAO_DONG();

            v_us.dcID_NHAN_VIEN = find_id_nhan_vien_by_ma_nv(dataRow["MA_NV"].ToString().Trim());
            if (dataRow["LOAI_LAO_DONG"].ToString() == "Trực tiếp")
            {
                v_us.dcID_LOAI_LAO_DONG = CONST_ID_LOAI_LAO_DONG.TRUC_TIEP;
            }
            else if (dataRow["LOAI_LAO_DONG"].ToString() == "Gián tiếp")
            {
                v_us.dcID_LOAI_LAO_DONG = CONST_ID_LOAI_LAO_DONG.GIAN_TIEP;
            }

            if (dataRow["NGAY_BAT_DAU"].ToString() != "")
                if ((dataRow["NGAY_BAT_DAU"].ToString().Substring(0, 10) != ""))
                    v_us.datNGAY_BAT_DAU = CIPConvert.ToDatetime(dataRow["NGAY_BAT_DAU"].ToString().Substring(0, 10));
            if (dataRow["NGAY_KET_THUC"].ToString() != "")
                if ((dataRow["NGAY_KET_THUC"].ToString().Substring(0, 10) != ""))
                    v_us.datNGAY_KET_THUC = CIPConvert.ToDatetime(dataRow["NGAY_KET_THUC"].ToString().Substring(0, 10));
            v_us.strDA_XOA = "N";
            v_us.Insert();
        }

        private decimal find_id_nhan_vien_by_ma_nv(string ip_str_ma_nv)
        {
            try
            {
                US_DM_NHAN_VIEN v_us = new US_DM_NHAN_VIEN();
                DS_DM_NHAN_VIEN v_ds = new DS_DM_NHAN_VIEN();

                v_us.FillDataset(v_ds);

                string v_str_filter = "MA_NV = '" + ip_str_ma_nv + "'";
                DataRow[] v_dr = v_ds.DM_NHAN_VIEN.Select(v_str_filter);

                if (v_dr.Count() == 0)
                {
                    return -1;
                }
                else
                {
                    return CIPConvert.ToDecimal(v_dr.First()["ID"].ToString());
                }
            }
            catch (Exception v_e)
            {
                throw v_e;
            }
        }

        #endregion

        #region Events Handle
        private void set_define_event()
        {
            this.Load += f372_nhan_vien_loai_lao_dong_excel_Load;
            m_cmd_luu.Click += m_cmd_luu_Click;
        }

        void m_cmd_luu_Click(object sender, EventArgs e)
        {
            try
            {
                if (checked_du_lieu_is_ok())
                {
                    for (int i = 0; i < m_grv.DataRowCount; i++)
                    {
                        if (m_grv.GetDataRow(i)[0].ToString() == "" | m_grv.GetDataRow(i)[1].ToString() == "") return;
                        if (check_ma_nhan_vien_is_ok(m_grv.GetDataRow(i)))
                        {
                            gan_du_lieu_cho_us_dm_nhan_vien(m_grv.GetDataRow(i));
                        }
                        else
                        {
                            CHRM_BaseMessages.MsgBox_Error("Mã nhân viên " + m_grv.GetDataRow(i)["MA_NV"].ToString() + "  đã có loại lao động rồi. Vui lòng kiểm tra lại thông tin!");
                            return;
                        }
                    }
                    //F503_IMPORT_EXCEL.da_hoan_thanh = true;
                    CHRM_BaseMessages.MsgBox_Infor(CONST_ID_MSGBOX.INFOR_LUU_DU_LIEU_THANH_CONG);
                    this.Close();
                }
                else
                {
                    CHRM_BaseMessages.MsgBox_Error("Kiểm tra lại dữ liệu!");
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }

        }

        void f372_nhan_vien_loai_lao_dong_excel_Load(object sender, EventArgs e)
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
