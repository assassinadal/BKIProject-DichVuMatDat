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
using BKI_DichVuMatDat.DS.CDBNames;

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
            m_dat_thang.DateTime = DateTime.Now.Date;
        }

        private DataSet lay_danh_sach_cac_dau_moi_truc_thuoc()
        {
            US_BT_DM_DON_VI_DE_LAM_BAO_CAO_DAC_TRUNG v_us = new US_BT_DM_DON_VI_DE_LAM_BAO_CAO_DAC_TRUNG();
            DS_BT_DM_DON_VI_DE_LAM_BAO_CAO_DAC_TRUNG v_ds = new DS_BT_DM_DON_VI_DE_LAM_BAO_CAO_DAC_TRUNG();

            v_us.FillDataset(v_ds);

            return v_ds;
        }

        private void xoa_du_lieu_bao_cao_da_co()
        {
            US_RPT_SO_LUONG_CHAT_LUONG_NHAN_VIEN v_us = new US_RPT_SO_LUONG_CHAT_LUONG_NHAN_VIEN();

            v_us.Delete_all_by_proc();
        }

        private void lay_du_lieu_bao_cao(decimal ip_dc_thang, decimal ip_dc_nam)
        {
            US_RPT_SO_LUONG_CHAT_LUONG_NHAN_VIEN v_us = new US_RPT_SO_LUONG_CHAT_LUONG_NHAN_VIEN();

            int v_int_so_luong_dau_moi_phu_thuoc = lay_danh_sach_cac_dau_moi_truc_thuoc().Tables[0].Rows.Count;
            try
            {
                for (int i = 0; i < v_int_so_luong_dau_moi_phu_thuoc; i++)
                {
                    DataRow v_dr_dau_moi_truc_thuoc = lay_danh_sach_cac_dau_moi_truc_thuoc().Tables[0].Rows[i];
                    decimal v_dc_id_bt_dm_don_vi = Convert.ToDecimal(v_dr_dau_moi_truc_thuoc[0]);


                    DataRow v_dr = lay_du_lieu_cua_tung_dau_moi_truc_thuoc(v_dc_id_bt_dm_don_vi, ip_dc_thang, ip_dc_nam);

                    transfer_data_row_2_us_oject(v_us, v_dr);
                    v_us.BeginTransaction();
                    v_us.Insert();
                    v_us.CommitTransaction();
                }
            }
            catch (Exception v_e)
            {
                v_us.Rollback();
                throw v_e;
            }

        }

        private void transfer_data_row_2_us_oject(US_RPT_SO_LUONG_CHAT_LUONG_NHAN_VIEN ip_us, DataRow ip_dr)
        {
            ip_us.dcID_DON_VI_CAP_TREN = CIPConvert.ToDecimal(ip_dr[RPT_SO_LUONG_CHAT_LUONG_NHAN_VIEN.ID_DON_VI_CAP_TREN].ToString());
            ip_us.strTEN_DON_VI = ip_dr[RPT_SO_LUONG_CHAT_LUONG_NHAN_VIEN.TEN_DON_VI].ToString();
            ip_us.dcTONG_SO = CIPConvert.ToDecimal(ip_dr[RPT_SO_LUONG_CHAT_LUONG_NHAN_VIEN.TONG_SO].ToString());
            ip_us.dcHD_KXD = CIPConvert.ToDecimal(ip_dr[RPT_SO_LUONG_CHAT_LUONG_NHAN_VIEN.HD_KXD].ToString());
            ip_us.dcHD_36_THANG = CIPConvert.ToDecimal(ip_dr[RPT_SO_LUONG_CHAT_LUONG_NHAN_VIEN.HD_36_THANG].ToString());
            ip_us.dcHD_12_THANG = CIPConvert.ToDecimal(ip_dr[RPT_SO_LUONG_CHAT_LUONG_NHAN_VIEN.HD_12_THANG].ToString());
            ip_us.dcHD_THU_VIEC = CIPConvert.ToDecimal(ip_dr[RPT_SO_LUONG_CHAT_LUONG_NHAN_VIEN.HD_THU_VIEC].ToString());
            ip_us.dcHD_HOC_NGHE = CIPConvert.ToDecimal(ip_dr[RPT_SO_LUONG_CHAT_LUONG_NHAN_VIEN.HD_HOC_NGHE].ToString());
            ip_us.dcTREN_DAI_HOC = CIPConvert.ToDecimal(ip_dr[RPT_SO_LUONG_CHAT_LUONG_NHAN_VIEN.TREN_DAI_HOC].ToString());
            ip_us.dcDAI_HOC = CIPConvert.ToDecimal(ip_dr[RPT_SO_LUONG_CHAT_LUONG_NHAN_VIEN.DAI_HOC].ToString());
            ip_us.dcCAO_DANG = CIPConvert.ToDecimal(ip_dr[RPT_SO_LUONG_CHAT_LUONG_NHAN_VIEN.CAO_DANG].ToString());
            ip_us.dcTRUNG_CAP = CIPConvert.ToDecimal(ip_dr[RPT_SO_LUONG_CHAT_LUONG_NHAN_VIEN.TRUNG_CAP].ToString());
            ip_us.dcSC_NGHE_PTTH = CIPConvert.ToDecimal(ip_dr[RPT_SO_LUONG_CHAT_LUONG_NHAN_VIEN.SC_NGHE_PTTH].ToString());
            ip_us.dcNAM = CIPConvert.ToDecimal(ip_dr[RPT_SO_LUONG_CHAT_LUONG_NHAN_VIEN.NAM].ToString());
            ip_us.dcNU = CIPConvert.ToDecimal(ip_dr[RPT_SO_LUONG_CHAT_LUONG_NHAN_VIEN.NU].ToString());
            ip_us.dcDUOI_26 = CIPConvert.ToDecimal(ip_dr[RPT_SO_LUONG_CHAT_LUONG_NHAN_VIEN.DUOI_26].ToString());
            ip_us.dcTU_26_DEN_30 = CIPConvert.ToDecimal(ip_dr[RPT_SO_LUONG_CHAT_LUONG_NHAN_VIEN.TU_26_DEN_30].ToString());
            ip_us.dcTU_31_DEN_35 = CIPConvert.ToDecimal(ip_dr[RPT_SO_LUONG_CHAT_LUONG_NHAN_VIEN.TU_31_DEN_35].ToString());
            ip_us.dcTU_36_DEN_40 = CIPConvert.ToDecimal(ip_dr[RPT_SO_LUONG_CHAT_LUONG_NHAN_VIEN.TU_36_DEN_40].ToString());
            ip_us.dcTU_41_DEN_45 = CIPConvert.ToDecimal(ip_dr[RPT_SO_LUONG_CHAT_LUONG_NHAN_VIEN.TU_41_DEN_45].ToString());
            ip_us.dcTU_46_DEN_50 = CIPConvert.ToDecimal(ip_dr[RPT_SO_LUONG_CHAT_LUONG_NHAN_VIEN.TU_46_DEN_50].ToString());
            ip_us.dcTU_51_DEN_55 = CIPConvert.ToDecimal(ip_dr[RPT_SO_LUONG_CHAT_LUONG_NHAN_VIEN.TU_51_DEN_55].ToString());
            ip_us.dcTREN_55 = CIPConvert.ToDecimal(ip_dr[RPT_SO_LUONG_CHAT_LUONG_NHAN_VIEN.TREN_55].ToString());
        }

        private DataRow lay_du_lieu_cua_tung_dau_moi_truc_thuoc(decimal v_dc_id_bt_dm_don_vi, decimal ip_dc_thang, decimal ip_dc_nam)
        {
            US_RPT_SO_LUONG_CHAT_LUONG_NHAN_VIEN v_us = new US_RPT_SO_LUONG_CHAT_LUONG_NHAN_VIEN();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.lay_du_lieu_tung_dau_moi_phu_thuoc(v_ds, v_dc_id_bt_dm_don_vi, ip_dc_thang, ip_dc_nam);
            DataRow v_dr = v_ds.Tables[0].Rows[0];
            return v_dr;
        }

        private void load_data_2_grid()
        {
            CHRMCommon.make_stt(m_bgv_bao_cao_so_luong_chat_luong_lao_dong);

            US_RPT_SO_LUONG_CHAT_LUONG_NHAN_VIEN v_us = new US_RPT_SO_LUONG_CHAT_LUONG_NHAN_VIEN();
            DS_RPT_SO_LUONG_CHAT_LUONG_NHAN_VIEN v_ds = new DS_RPT_SO_LUONG_CHAT_LUONG_NHAN_VIEN();

            v_us.FillDataset(v_ds);

            m_grc_bao_cao_so_luong_chat_luong_lao_dong.DataSource = v_ds.Tables[0];

            m_bgv_bao_cao_so_luong_chat_luong_lao_dong.RowStyle += m_bgv_bao_cao_so_luong_chat_luong_lao_dong_RowStyle;

        }

        #endregion

        #region Events Handle
        private void set_define_events()
        {
            this.Load += f410_bao_cao_so_luong_chat_luong_lao_dong_Load;
            this.FormClosed += f410_bao_cao_so_luong_chat_luong_lao_dong_FormClosed;
            m_cmd_xem_bao_cao.Click += m_cmd_xem_bao_cao_Click;
            m_cmd_xuat_excel.Click += m_cmd_xuat_excel_Click;
            m_bgv_bao_cao_so_luong_chat_luong_lao_dong.DoubleClick += m_bgv_bao_cao_so_luong_chat_luong_lao_dong_DoubleClick;
        }

        void m_bgv_bao_cao_so_luong_chat_luong_lao_dong_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                
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
                saveFileDialog1.FileName = "BAO CAO SO LUONG CHAT LUONG NHAN VIEN THANG " + m_dat_thang.DateTime.Month.ToString() + " NAM " + m_dat_thang.DateTime.Year.ToString(); ;
                saveFileDialog1.RestoreDirectory = true;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    m_bgv_bao_cao_so_luong_chat_luong_lao_dong.ExportToXls(saveFileDialog1.FileName);
                    CHRM_BaseMessages.MsgBox_Infor(CONST_ID_MSGBOX.INFOR_LUU_BAO_CAO_THANH_CONG);
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_xem_bao_cao_Click(object sender, EventArgs e)
        {
            try
            {
                xoa_du_lieu_bao_cao_da_co();
                lay_du_lieu_bao_cao(decimal.Parse(m_dat_thang.DateTime.Month.ToString()), decimal.Parse(m_dat_thang.DateTime.Year.ToString()));
                load_data_2_grid();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void f410_bao_cao_so_luong_chat_luong_lao_dong_FormClosed(object sender, FormClosedEventArgs e)
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


        void m_bgv_bao_cao_so_luong_chat_luong_lao_dong_RowStyle(object sender, RowStyleEventArgs e)
        {
            try
            {

                DataGridViewBand View = sender as DataGridViewBand;
                string v_cellValue;
                v_cellValue = m_bgv_bao_cao_so_luong_chat_luong_lao_dong.GetRowCellDisplayText(e.RowHandle, "ID").ToString();
                if (CIPConvert.ToDecimal(v_cellValue) == 1 || CIPConvert.ToDecimal(v_cellValue) == 2
                    || CIPConvert.ToDecimal(v_cellValue) == 5 || CIPConvert.ToDecimal(v_cellValue) == 8
                    || CIPConvert.ToDecimal(v_cellValue) == 11 || CIPConvert.ToDecimal(v_cellValue) == 15
                    || CIPConvert.ToDecimal(v_cellValue) == 20 || CIPConvert.ToDecimal(v_cellValue) == 32
                    || CIPConvert.ToDecimal(v_cellValue) == 54 || CIPConvert.ToDecimal(v_cellValue) == 55
                    || CIPConvert.ToDecimal(v_cellValue) == 56)
                {
                    if (e.RowHandle >= 0)
                    {
                        e.Appearance.BackColor = Color.Aqua;
                        e.Appearance.BackColor2 = Color.Transparent;
                        e.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
                    }
                }
                else if (CIPConvert.ToDecimal(v_cellValue) == 14 || CIPConvert.ToDecimal(v_cellValue) == 18
                   || CIPConvert.ToDecimal(v_cellValue) == 19 || CIPConvert.ToDecimal(v_cellValue) == 23
                   || CIPConvert.ToDecimal(v_cellValue) == 26 || CIPConvert.ToDecimal(v_cellValue) == 29
                   || CIPConvert.ToDecimal(v_cellValue) == 35 || CIPConvert.ToDecimal(v_cellValue) == 38
                   || CIPConvert.ToDecimal(v_cellValue) == 41 || CIPConvert.ToDecimal(v_cellValue) == 50)
                {
                    if (e.RowHandle >= 0)
                    {
                        e.Appearance.BackColor = Color.Violet;
                        e.Appearance.BackColor2 = Color.Transparent;
                        e.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
                        
                    }
                }
                else if (CIPConvert.ToDecimal(v_cellValue) == 44 || CIPConvert.ToDecimal(v_cellValue) == 47)
                {
                    if (e.RowHandle >= 0)
                    {
                        e.Appearance.BackColor2 = Color.Transparent;
                        e.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic);

                    }
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
