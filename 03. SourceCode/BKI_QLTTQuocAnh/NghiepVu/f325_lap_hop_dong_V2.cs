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
using BKI_DichVuMatDat.COMMON;
using DevExpress.XtraEditors;
using System.Globalization;
using IP.Core.IPSystemAdmin;

namespace BKI_DichVuMatDat.NghiepVu
{
    public partial class f325_lap_hop_dong_V2 : Form
    {
        public f325_lap_hop_dong_V2()
        {
            InitializeComponent();
            format_controls();
        }

        #region Public Interface

        #endregion

        #region Members
        decimal m_lay_du_lieu_toan_bo_nhan_vien = -1;
        decimal m_lay_du_lieu_toan_bo_loai_hop_dong = -1;
        #endregion

        #region Private Methods

        private void format_controls()
        {
            FormatControl.SetVisibleSimpleButton(this);
            this.m_grv_thong_tin_hop_dong.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(WinFormControls.m_grv_PopupMenuShowing);
            this.m_grv_thong_tin_hop_dong.OptionsPrint.AutoWidth = false;
            set_define_events();
            this.KeyPreview = true;
        }

        private void set_init_form_load()
        {
            load_data_2_sle_chon_nv();
            load_data_2_sle_loai_hd();
            m_dat_tu_ngay.EditValue = CHRMCommon.get_first_day_of_month(DateTime.Now.Date);
            m_dat_den_ngay.EditValue = CHRMCommon.get_last_day_of_month(DateTime.Now.Date);
            //load_data_2_grid();
        }

        private DS_V_DM_NHAN_VIEN load_data_2_ds_v_dm_nv()
        {
            DS_V_DM_NHAN_VIEN v_ds = new DS_V_DM_NHAN_VIEN();
            US_V_DM_NHAN_VIEN v_us = new US_V_DM_NHAN_VIEN();

            v_us.FillDataset(v_ds);
            return v_ds;
        }

        private void load_data_2_sle_chon_nv()
        {
            m_sle_chon_nhan_vien.Properties.DataSource = load_data_2_ds_v_dm_nv().V_DM_NHAN_VIEN;
            m_sle_chon_nhan_vien.Properties.ValueMember = V_DM_NHAN_VIEN.ID;
            m_sle_chon_nhan_vien.Properties.DisplayMember = V_DM_NHAN_VIEN.HO_TEN;

            m_sle_chon_nhan_vien.Properties.PopulateViewColumns();
            m_sle_chon_nhan_vien.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            m_sle_chon_nhan_vien.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
        }

        private DS_DM_LOAI_HOP_DONG load_data_2_ds_dm_loai_hd()
        {
            DS_DM_LOAI_HOP_DONG v_ds = new DS_DM_LOAI_HOP_DONG();
            US_DM_LOAI_HOP_DONG v_us = new US_DM_LOAI_HOP_DONG();

            v_us.FillDataset(v_ds);
            return v_ds;
        }

        private void load_data_2_sle_loai_hd()
        {
            m_sle_loai_hop_dong.Properties.DataSource = load_data_2_ds_dm_loai_hd().DM_LOAI_HOP_DONG;
            m_sle_loai_hop_dong.Properties.ValueMember = DM_LOAI_HOP_DONG.ID;
            m_sle_loai_hop_dong.Properties.DisplayMember = DM_LOAI_HOP_DONG.LOAI_HOP_DONG;

            m_sle_loai_hop_dong.Properties.PopulateViewColumns();
            m_sle_loai_hop_dong.Properties.View.Columns[DM_LOAI_HOP_DONG.ID].Visible = false;
            m_sle_loai_hop_dong.Properties.View.Columns[DM_LOAI_HOP_DONG.AN_CA_YN].Visible = false;
            m_sle_loai_hop_dong.Properties.View.Columns[DM_LOAI_HOP_DONG.HS_LNS_YN].Visible = false;
            m_sle_loai_hop_dong.Properties.View.Columns[DM_LOAI_HOP_DONG.LCD_YN].Visible = false;
            m_sle_loai_hop_dong.Properties.View.Columns[DM_LOAI_HOP_DONG.SO_TIEN].Visible = false;
            m_sle_loai_hop_dong.Properties.View.Columns[DM_LOAI_HOP_DONG.TI_LE].Visible = false;

            m_sle_loai_hop_dong.Properties.View.Columns[DM_LOAI_HOP_DONG.LOAI_HOP_DONG].Width = 120;
            m_sle_loai_hop_dong.Properties.View.Columns[DM_LOAI_HOP_DONG.MA_LOAI_HOP_DONG].Width = 90;

            m_sle_loai_hop_dong.Properties.View.Columns[DM_LOAI_HOP_DONG.MA_LOAI_HOP_DONG].Caption = "Mã loại";
            m_sle_loai_hop_dong.Properties.View.Columns[DM_LOAI_HOP_DONG.LOAI_HOP_DONG].Caption = "Tên loại";

            m_sle_loai_hop_dong.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            m_sle_loai_hop_dong.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
        }

        private bool check_validate_data()
        {
            return true;
        }

        private void load_data_2_grid()
        {
            CHRMCommon.make_stt(m_grv_thong_tin_hop_dong);
            US_V_F320_DANH_SACH_HOP_DONG_DA_KY_THEO_THOI_GIAN v_us = new US_V_F320_DANH_SACH_HOP_DONG_DA_KY_THEO_THOI_GIAN();
            DS_V_F320_DANH_SACH_HOP_DONG_DA_KY_THEO_THOI_GIAN v_ds = new DS_V_F320_DANH_SACH_HOP_DONG_DA_KY_THEO_THOI_GIAN();

            if (m_sle_chon_nhan_vien.EditValue == null)
            {
                if (m_sle_loai_hop_dong.EditValue == null)
                {
                    m_lay_du_lieu_toan_bo_nhan_vien = -1;
                    m_lay_du_lieu_toan_bo_loai_hop_dong = -1;
                    v_us.FillDataset_tu_ngay_den_ngay(
                                        v_ds
                                        , m_lay_du_lieu_toan_bo_nhan_vien
                                        , m_lay_du_lieu_toan_bo_loai_hop_dong
                                        , m_dat_tu_ngay.DateTime.Date
                                        , m_dat_den_ngay.DateTime.Date);
                }
                else
                {
                    m_lay_du_lieu_toan_bo_nhan_vien = -1;
                    v_us.FillDataset_tu_ngay_den_ngay(
                                        v_ds
                                        , m_lay_du_lieu_toan_bo_nhan_vien
                                        , (decimal)m_sle_loai_hop_dong.EditValue
                                        , m_dat_tu_ngay.DateTime.Date
                                        , m_dat_den_ngay.DateTime.Date);
                }
            }
            else
            {
                if (m_sle_loai_hop_dong.EditValue == null)
                {
                    m_lay_du_lieu_toan_bo_loai_hop_dong = -1;
                    v_us.FillDataset_tu_ngay_den_ngay(
                                        v_ds
                                        , (decimal)m_sle_chon_nhan_vien.EditValue
                                        , m_lay_du_lieu_toan_bo_loai_hop_dong
                                        , m_dat_tu_ngay.DateTime.Date
                                        , m_dat_den_ngay.DateTime.Date);
                }
                else
                {
                    m_lay_du_lieu_toan_bo_nhan_vien = -1;
                    v_us.FillDataset_tu_ngay_den_ngay(
                                        v_ds
                                        , (decimal)m_sle_chon_nhan_vien.EditValue
                                        , (decimal)m_sle_loai_hop_dong.EditValue
                                        , m_dat_tu_ngay.DateTime.Date
                                        , m_dat_den_ngay.DateTime.Date);
                }
            }
            m_grc_thong_tin_hop_dong.DataSource = v_ds.Tables[0];
        }

        private void import_excel()
        {

        }

        #endregion

        #region Events Handle
        private void set_define_events()
        {
            this.Load += f320_lap_hop_dong_V2_Load;
            this.FormClosed += f320_lap_hop_dong_V2_FormClosed;

            m_cmd_search.Click += m_cmd_search_Click;
            m_cmd_xem_thong_tin_tat_ca.Click += m_cmd_xem_thong_tin_tat_ca_Click;
            m_grv_thong_tin_hop_dong.DoubleClick += m_grv_thong_tin_hop_dong_DoubleClick;
            m_cmd_chon_file.Click += m_cmd_chon_file_Click;
        }

        private void m_cmd_chon_file_Click(object sender, EventArgs e)
        {
            try
            {
                import_excel();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_xem_thong_tin_tat_ca_Click(object sender, EventArgs e)
        {
            try
            {
                f321_chi_tiet_hop_dong_da_ky_theo_thoi_gian v_frm = new f321_chi_tiet_hop_dong_da_ky_theo_thoi_gian();
                v_frm.display_from_f320_v2(
                                    -1
                                    , m_dat_tu_ngay.DateTime.Date
                                    , m_dat_den_ngay.DateTime.Date);
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_grv_thong_tin_hop_dong_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                decimal v_id_nhan_vien = 0;
                v_id_nhan_vien = CIPConvert.ToDecimal(m_grv_thong_tin_hop_dong.GetRowCellValue(m_grv_thong_tin_hop_dong.FocusedRowHandle, "ID_NHAN_VIEN"));

                f321_chi_tiet_hop_dong_da_ky_theo_thoi_gian v_frm = new f321_chi_tiet_hop_dong_da_ky_theo_thoi_gian();
                v_frm.display_from_f320_v2(
                                    v_id_nhan_vien
                                    , m_dat_tu_ngay.DateTime.Date
                                    , m_dat_den_ngay.DateTime.Date);

            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_search_Click(object sender, EventArgs e)
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

        void f320_lap_hop_dong_V2_FormClosed(object sender, FormClosedEventArgs e)
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

        void f320_lap_hop_dong_V2_Load(object sender, EventArgs e)
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

        private void m_cmd_insert_Click(object sender, EventArgs e)
        {

        }

    }
}
