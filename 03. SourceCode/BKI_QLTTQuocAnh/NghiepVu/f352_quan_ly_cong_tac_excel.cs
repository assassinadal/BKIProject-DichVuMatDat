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
using IP.Core.IPSystemAdmin;

namespace BKI_DichVuMatDat.NghiepVu
{
    public partial class f352_quan_ly_cong_tac_excel : Form
    {
        public f352_quan_ly_cong_tac_excel()
        {
            InitializeComponent();
            format_control();
        }

        internal void displayToInsertExcel(string m_txt_path)
        {
            WinFormControls.load_xls_to_gridview_v3(m_txt_path, m_grc_v_gd_cong_tac, "CSDL");
            foreach (DevExpress.XtraGrid.Columns.GridColumn col in ((DevExpress.XtraGrid.Views.Base.ColumnView)m_grc_v_gd_cong_tac.Views[0]).Columns)
            {
                col.MaxWidth = 100;
                col.MinWidth = 100;

            }
            this.ShowDialog();
        }

        #region members

        US_GD_CONG_TAC v_us_ct = new US_GD_CONG_TAC();
        //string op_str_mess = "";
        decimal m_id_gd_ct = 0;
        bool m_loai_ctac_cthuc = false;

        #endregion

        #region private methods

        private void format_control()
        {
            set_define_events();
            CenterToScreen();
        }

        private void insert_data(DataRow dataRow)
        {
            form_to_us(dataRow);
            if (m_id_gd_ct != -1)
            {
                //Nhan vien da co GD cong tac
                if (m_loai_ctac_cthuc == true && CIPConvert.ToDecimal(dataRow["ID_LOAI_CONG_TAC"].ToString()) == CONST_ID_LOAI_CONG_TAC.CHINH_THUC)
                {
                    chuyen_gd_ct_da_xoa_Y();
                }
            }
            v_us_ct.Insert();
        }

        private void load_data_2_m_variable(DataRow dataRow)
        {
            m_id_gd_ct = find_id_gd_ct(find_id_nhan_vien_by_ma_nv(dataRow["MA_NHAN_VIEN"].ToString().Trim()));
            m_loai_ctac_cthuc = loai_ctac_cthuc_isExist(find_id_nhan_vien_by_ma_nv(dataRow["MA_NHAN_VIEN"].ToString().Trim()), CONST_ID_LOAI_CONG_TAC.CHINH_THUC);
        }

        private bool loai_ctac_cthuc_isExist(decimal ip_dc_id_nv, decimal ip_dc_id_loai_ct)
        {
            US_GD_CONG_TAC v_us = new US_GD_CONG_TAC();
            DS_GD_CONG_TAC v_ds = new DS_GD_CONG_TAC();

            v_us.FillDataset(v_ds);

            string v_str_filter = "ID_NHAN_VIEN = " + ip_dc_id_nv + "AND DA_XOA = 'N' AND ID_LOAI_CONG_TAC = " + ip_dc_id_loai_ct;
            DataRow[] v_dr = v_ds.GD_CONG_TAC.Select(v_str_filter);

            if (v_dr.Count() == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private decimal find_id_gd_ct(decimal ip_dc_id_nv)
        {
            US_GD_CONG_TAC v_us = new US_GD_CONG_TAC();
            DS_GD_CONG_TAC v_ds = new DS_GD_CONG_TAC();

            v_us.FillDataset(v_ds);

            string v_str_filter = "ID_NHAN_VIEN = " + ip_dc_id_nv + "AND DA_XOA = 'N'";
            DataRow[] v_dr = v_ds.GD_CONG_TAC.Select(v_str_filter);

            if (v_dr.Count() == 0)
            {
                return -1;
            }
            else
            {
                return CIPConvert.ToDecimal(v_dr.First()["ID"].ToString());
            }
        }

        private void chuyen_gd_ct_da_xoa_Y()
        {
            US_GD_CONG_TAC v_us = new US_GD_CONG_TAC(m_id_gd_ct);
            v_us.strDA_XOA = "Y";
            v_us.BeginTransaction();
            v_us.Update();
            v_us.CommitTransaction();
        }

        private void form_to_us(DataRow dataRow)
        {
            v_us_ct.strDA_XOA = "N";
            v_us_ct.strNGUOI_LAP = CAppContext_201.getCurrentUserName();
            v_us_ct.datNGAY_LAP = DateTime.Now.Date;
            //v_us_ct.datNGAY_BAT_DAU = DateTime.FromOADate(Convert.ToDouble(dataRow["NGAY_BAT_DAU"]));
            //v_us_ct.datNGAY_KET_THUC = DateTime.FromOADate(Convert.ToDouble(dataRow["NGAY_KET_THUC"]));
            //v_us_ct.datNGAY_BAT_DAU = DateTime.Parse(dataRow["NGAY_BAT_DAU"].ToString());
            //v_us_ct.datNGAY_KET_THUC = DateTime.Parse(dataRow["NGAY_KET_THUC"].ToString());
            v_us_ct.datNGAY_BAT_DAU = Convert.ToDateTime(dataRow["NGAY_BAT_DAU"].ToString());
            v_us_ct.datNGAY_KET_THUC = Convert.ToDateTime(dataRow["NGAY_KET_THUC"].ToString());
            v_us_ct.dcID_DON_VI = CIPConvert.ToDecimal(dataRow["ID_DON_VI"].ToString());
            v_us_ct.dcID_NHAN_VIEN = find_id_nhan_vien_by_ma_nv(dataRow["MA_NHAN_VIEN"].ToString().Trim());
            if (dataRow["ID_QUYET_DINH"].ToString() != "")
            {
                v_us_ct.dcID_QUYET_DINH = CIPConvert.ToDecimal(dataRow["ID_QUYET_DINH"].ToString());
            }
            v_us_ct.dcID_LOAI_CONG_TAC = CIPConvert.ToDecimal(dataRow["ID_LOAI_CONG_TAC"].ToString());
            v_us_ct.dcID_VI_TRI = CIPConvert.ToDecimal(dataRow["ID_VI_TRI"].ToString());

        }

        private decimal find_id_nhan_vien_by_ma_nv(string ip_str_ma_nv)
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

        private bool check_ma_nhan_vien_is_ok(DataRow dataRow)
        {
            US_DM_NHAN_VIEN v_us = new US_DM_NHAN_VIEN();
            DS_DM_NHAN_VIEN v_ds_nhan_vien = new DS_DM_NHAN_VIEN();
            v_us.FillDataset(v_ds_nhan_vien, " where MA_NV= '" + dataRow["MA_NHAN_VIEN"].ToString() + "'");
            if (v_ds_nhan_vien.Tables[0].Rows.Count > 0)
                return true;
            else
            {
                return false;
            }
        }

        private bool checked_du_lieu_is_ok()
        {
            if (m_grv_v_gd_cong_tac.DataRowCount > 0)
                return true;
            else
                return false;
        }

        private bool insertdone(DataRow dataRow)
        {
            if (dataRow["ID_VI_TRI"].ToString().Trim() == ""
                && dataRow["NGAY_BAT_DAU"].ToString().Trim() == ""
                && dataRow["NGAY_KET_THUC"].ToString().Trim() == ""
                && dataRow["ID_LOAI_CONG_TAC"].ToString().Trim() == ""
                && dataRow["MA_NHAN_VIEN"].ToString().Trim() == ""
                && dataRow["ID_DON_VI"].ToString().Trim() == ""
                && dataRow["ID_QUYET_DINH"].ToString().Trim() == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion

        //
        //EVENTS
        //

        private void set_define_events()
        {
            m_cmd_luu.Click += m_cmd_luu_Click;
        }

        private void m_cmd_luu_Click(object sender, EventArgs e)
        {
            try
            {
                if (checked_du_lieu_is_ok())
                {
                    for (int i = 0; i < m_grv_v_gd_cong_tac.DataRowCount; i++)
                    {
                        if (check_ma_nhan_vien_is_ok(m_grv_v_gd_cong_tac.GetDataRow(i)))
                        {
                            load_data_2_m_variable(m_grv_v_gd_cong_tac.GetDataRow(i));
                            insert_data(m_grv_v_gd_cong_tac.GetDataRow(i));
                            //CHRM_BaseMessages.MsgBox_Error(op_str_mess);
                        }
                        else
                        {
                            if (insertdone(m_grv_v_gd_cong_tac.GetDataRow(i)))
                            {
                                CHRM_BaseMessages.MsgBox_Infor(CONST_ID_MSGBOX.INFOR_LUU_DU_LIEU_THANH_CONG);
                                //F503_IMPORT_EXCEL.da_hoan_thanh = true;
                                this.Close();
                                return;
                            }
                            CHRM_BaseMessages.MsgBox_Error("Mã nhân viên " + m_grv_v_gd_cong_tac.GetDataRow(i)["MA_NHAN_VIEN"].ToString() + "  chưa tồn tại. Vui lòng kiểm tra lại thông tin!");
                            return;
                        }
                    }
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
    }
}
