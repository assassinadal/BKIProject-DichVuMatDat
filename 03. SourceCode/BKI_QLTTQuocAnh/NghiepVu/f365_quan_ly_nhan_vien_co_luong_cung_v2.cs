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
using BKI_DichVuMatDat.DS;
using BKI_DichVuMatDat.US;
using BKI_DichVuMatDat.DS.CDBNames;
using DevExpress.XtraEditors;
using IP.Core.IPSystemAdmin;
using System.Data.SqlClient;

namespace BKI_DichVuMatDat.NghiepVu
{
    public partial class f365_quan_ly_nhan_vien_co_luong_cung_v2 : Form
    {
        public f365_quan_ly_nhan_vien_co_luong_cung_v2()
        {
            InitializeComponent();
            format_controls();
        }

        #region Public interface
        public void display()
        {
            this.ShowDialog();
        }
        #endregion

        #region Members
        US_GD_LUONG_CUNG v_us = new US_GD_LUONG_CUNG();
        US_V_GD_LUONG_CUNG v_v_us_luong_cung = new US_V_GD_LUONG_CUNG();
        #endregion

        #region Private methods
        private void format_controls()
        {
            //FormatControl.SetVisibleSimpleButton(this);
            this.m_grv_luong_cung_cua_nhan_vien.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(WinFormControls.m_grv_PopupMenuShowing);
            this.m_grv_luong_cung_cua_nhan_vien.OptionsPrint.AutoWidth = false;
            set_define_events();
            this.KeyPreview = true;
        }

        private void set_initial_form_load()
        {
            load_data_2_grid();
        }

        //load data 2 all controls
        private DS_V_DM_NHAN_VIEN load_data_2_ds_v_dm_nv()
        {
            DS_V_DM_NHAN_VIEN v_ds = new DS_V_DM_NHAN_VIEN();
            US_V_DM_NHAN_VIEN v_us = new US_V_DM_NHAN_VIEN();
            v_us.FillDataset(v_ds);
            return v_ds;
        }

        private void load_data_2_grid()
        {
            CHRMCommon.make_stt(m_grv_luong_cung_cua_nhan_vien);
            //US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            //DataSet v_ds = new DataSet();
            //v_ds.Tables.Add(new DataTable());
            //v_us.FillDatasetWithQuery(v_ds, "SELECT * FROM V_GD_LUONG_CUNG WHERE DA_XOA = 'N' ORDER BY ID_NHAN_VIEN");
            //v_v_us_luong_cung = new US_V_GD_LUONG_CUNG();
            DS_V_GD_LUONG_CUNG v_ds = new DS_V_GD_LUONG_CUNG();
            //v_ds.Tables.Add(new DataTable());
            //SqlCommand cmd = new SqlCommand("SELECT * FROM V_GD_LUONG_CUNG WHERE DA_XOA = 'N' ORDER BY ID_NHAN_VIEN");
            v_v_us_luong_cung.FillDataset(v_ds, "WHERE DA_XOA = 'N' ORDER BY ID_NHAN_VIEN");
            m_grc_luong_cung_cua_nhan_vien.DataSource = v_ds.Tables[0];
        }


        //private void load_luong_cung_nv_2_form(decimal ip_dc_id_nv)
        //{
        //    decimal v_id_gd_luong_cung = find_id_gd_luong_cung(ip_dc_id_nv);
        //    if (v_id_gd_luong_cung != -1)
        //    {
        //        US_GD_LUONG_CUNG v_us_lc = new US_GD_LUONG_CUNG(v_id_gd_luong_cung);
        //        m_txt_so_tien.Text = v_us_lc.dcSO_TIEN.ToString();
        //        CCommon.format_text_2_money(m_txt_so_tien);
        //        m_dat_ngay_bat_dau.Value = v_us_lc.datNGAY_BAT_DAU;
        //        m_dat_ngay_ket_thuc.Value = v_us_lc.datNGAY_KET_THUC;
        //        m_txt_ghi_chu.Text = v_us_lc.strGHI_CHU;
        //    }
        //    else
        //    {
        //        m_txt_so_tien.Text = "";
        //        m_dat_ngay_bat_dau.Value = DateTime.Now.Date;
        //        m_dat_ngay_ket_thuc.Value = DateTime.Now.Date;
        //        m_txt_ghi_chu.Text = "";
        //    }
        //}




        //save data       
        private void cho_gd_da_co_da_xoa_Y(decimal ip_dc_id_nhan_vien)
        {
            decimal v_id_gd_luong_cung = 0;
            v_id_gd_luong_cung = find_id_gd_luong_cung(ip_dc_id_nhan_vien);
            if (v_id_gd_luong_cung == -1)
            {
                return;
            }
            else
            {
                US_GD_LUONG_CUNG v_us = new US_GD_LUONG_CUNG(v_id_gd_luong_cung);
                try
                {
                    v_us.strDA_XOA = "Y";
                    v_us.BeginTransaction();
                    v_us.Update();
                    v_us.CommitTransaction();
                }
                catch (Exception v_e)
                {
                    CSystemLog_301.ExceptionHandle(v_e);
                }
            }
        }

        private decimal find_id_gd_luong_cung(decimal ip_dc_id_nhan_vien)
        {
            //US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            //DataSet v_ds = new DataSet();
            //v_ds.Tables.Add(new DataTable());
            //throw new Exception("Sua lai khong dung FillDataSetWithTableName nua nhe");
            // v_us.FillDatasetWithTableName(v_ds, "GD_LUONG_CUNG");
            US_GD_LUONG_CUNG v_us = new US_GD_LUONG_CUNG();
            DS_GD_LUONG_CUNG v_ds = new DS_GD_LUONG_CUNG();
            v_us.FillDataset(v_ds);
            string v_str_filter = "ID_NHAN_VIEN = " + ip_dc_id_nhan_vien + " AND DA_XOA = 'N'";
            DataRow[] v_dr = v_ds.Tables[0].Select(v_str_filter);
            if (v_dr.Count() == 0)
            {
                return -1;
            }
            else
            {
                return CIPConvert.ToDecimal(v_dr.First()["ID"].ToString());
            }
        }

        //focus new row after created
        //private void focus_new_row_created()
        //{
        //    int v_row_index = 0;
        //    decimal v_id_nv_f363 = 0;
        //    string v_da_xoa_f363 = "N";

        //    US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
        //    DataSet v_ds = new DataSet();
        //    v_ds.Tables.Add(new DataTable());

        //    throw new Exception("Sua lai khong dung FillDataSetWithTableName nua nhe");
        //    //v_us.FillDatasetWithTableName(v_ds, "V_GD_LUONG_CUNG");

        //    v_id_nv_f363 = CIPConvert.ToDecimal(.EditValue);

        //    for (v_row_index = 0; v_row_index < v_ds.Tables[0].Rows.Count; v_row_index++)
        //    {
        //        decimal v_id_nv = CIPConvert.ToDecimal(m_grv_luong_cung_cua_nhan_vien.GetDataRow(v_row_index)["ID_NHAN_VIEN"].ToString());
        //        string v_da_xoa = m_grv_luong_cung_cua_nhan_vien.GetDataRow(v_row_index)["DA_XOA"].ToString();

        //        if (v_id_nv == v_id_nv_f363 && v_da_xoa == v_da_xoa_f363)
        //        {
        //            break;
        //        }
        //    }

        //    m_grv_luong_cung_cua_nhan_vien.FocusedRowHandle = v_row_index;
        //}



        #endregion
        private void set_define_events()
        {
            this.Load += f365_quan_ly_cac_nhan_vien_co_luong_cung_Load;
            m_cmd_update.Click += m_cmd_update_Click;
            m_cmd_insert.Click += m_cmd_insert_Click;
            m_cmd_delete.Click += m_cmd_delete_Click;
            m_cmd_xuat_excel.Click += m_cmd_xuat_excel_Click;
            m_grv_luong_cung_cua_nhan_vien.DoubleClick += m_grv_luong_cung_cua_nhan_vien_DoubleClick;
        }

        void f365_quan_ly_cac_nhan_vien_co_luong_cung_Load(object sender, EventArgs e)
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

        void m_cmd_update_Click(object sender, EventArgs e)
        {
            try
            {
                decimal v_id_nv = CIPConvert.ToDecimal(m_grv_luong_cung_cua_nhan_vien.GetRowCellValue(m_grv_luong_cung_cua_nhan_vien.FocusedRowHandle, "ID_NHAN_VIEN"));
                decimal v_id_gd_luong_cung = find_id_gd_luong_cung(v_id_nv);
                if (v_id_gd_luong_cung != -1)
                {
                    v_us = new US_GD_LUONG_CUNG(v_id_gd_luong_cung);
                    f364_quan_ly_cac_nhan_vien_co_luong_cung_de frm = new f364_quan_ly_cac_nhan_vien_co_luong_cung_de();
                    frm.display_4_update(v_us);
                    load_data_2_grid();
                }
                else
                {
                    //f364_quan_ly_cac_nhan_vien_co_luong_cung_de frm = new f364_quan_ly_cac_nhan_vien_co_luong_cung_de();
                    //frm.display_4_insert(v_id_nv);
                    //load_data_2_grid();
                    CHRM_BaseMessages.MsgBox_Error("Nhân viên không có lương cứng!");
                }
            }

            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_insert_Click(object sender, EventArgs e)
        {
            try
            {
                f364_quan_ly_cac_nhan_vien_co_luong_cung_de frm = new f364_quan_ly_cac_nhan_vien_co_luong_cung_de();
                frm.display_4_insert();
                //m_e_form_mode = DataEntryFormMode.InsertDataState;
                //refresh_form();
                load_data_2_grid();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_grv_luong_cung_cua_nhan_vien_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                decimal v_id_nv = CIPConvert.ToDecimal(m_grv_luong_cung_cua_nhan_vien.GetRowCellValue(m_grv_luong_cung_cua_nhan_vien.FocusedRowHandle, "ID_NHAN_VIEN"));
                if (v_id_nv > 0)
                {
                    decimal v_id_gd_luong_cung = find_id_gd_luong_cung(v_id_nv);
                    if (v_id_gd_luong_cung != -1)
                    {
                        v_us = new US_GD_LUONG_CUNG(v_id_gd_luong_cung);
                        f364_quan_ly_cac_nhan_vien_co_luong_cung_de frm = new f364_quan_ly_cac_nhan_vien_co_luong_cung_de();
                        frm.display_4_update(v_us);
                        load_data_2_grid();
                    }
                    else
                    {
                        f364_quan_ly_cac_nhan_vien_co_luong_cung_de frm = new f364_quan_ly_cac_nhan_vien_co_luong_cung_de();
                        frm.display_4_insert(v_id_nv);
                        load_data_2_grid();
                    }
                }
                else
                {
                    CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_CHUA_CHON_DONG_TREN_LUOI_DE_SUA);
                    return;
                }

            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (CHRM_BaseMessages.MsgBox_Confirm(CONST_ID_MSGBOX.QUESTION_XAC_NHAN_XOA_DU_LIEU) == true)
                {
                    //Lay ID cua dong du lieu muon xoa
                    DataRow v_dr = m_grv_luong_cung_cua_nhan_vien.GetDataRow(m_grv_luong_cung_cua_nhan_vien.FocusedRowHandle);
                    //Lay ID cua dong du lieu tren
                    decimal v_id = CIPConvert.ToDecimal(v_dr[GD_LUONG_CUNG.ID]);
                    //
                    US_GD_LUONG_CUNG v_us = new US_GD_LUONG_CUNG(v_id);
                    v_us.BeginTransaction();
                    v_us.Delete();
                    v_us.CommitTransaction();
                    CHRM_BaseMessages.MsgBox_Infor("Đã xóa dữ liệu thành công");
                    load_data_2_grid();
                }
                else
                {
                    return;
                }
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
                    m_grv_luong_cung_cua_nhan_vien.ExportToXls(saveFileDialog1.FileName);
                    CHRM_BaseMessages.MsgBox_Infor(CONST_ID_MSGBOX.INFOR_LUU_BAO_CAO_THANH_CONG);
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

    }
}

