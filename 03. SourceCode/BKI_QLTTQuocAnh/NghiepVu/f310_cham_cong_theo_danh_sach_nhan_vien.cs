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

namespace BKI_DichVuMatDat.NghiepVu
{
    public partial class f310_cham_cong_theo_danh_sach_nhan_vien : Form
    {
        public f310_cham_cong_theo_danh_sach_nhan_vien()
        {
            InitializeComponent();
            format_controls();
        }
        #region Members
        DS_V_PRT_DANH_SACH_NHAN_VIEN_CON_HAN_HOP_DONG m_ds = new DS_V_PRT_DANH_SACH_NHAN_VIEN_CON_HAN_HOP_DONG();
        US_V_PRT_DANH_SACH_NHAN_VIEN_CON_HAN_HOP_DONG m_us = new US_V_PRT_DANH_SACH_NHAN_VIEN_CON_HAN_HOP_DONG();

        private DataView clone = null;
        #endregion

        #region Private methods
        private void format_controls()
        {
            set_define_events();
            this.KeyPreview = true;
        }

        private void load_data_2_grid()
        {
            CCommon.make_stt(gridView1);

            DS_V_PRT_DANH_SACH_NHAN_VIEN_CON_HAN_HOP_DONG v_ds = new DS_V_PRT_DANH_SACH_NHAN_VIEN_CON_HAN_HOP_DONG();
            US_V_PRT_DANH_SACH_NHAN_VIEN_CON_HAN_HOP_DONG v_us = new US_V_PRT_DANH_SACH_NHAN_VIEN_CON_HAN_HOP_DONG();

            m_us.FillDatasetByNgayChamCong(m_ds, m_dat_ngay_cham_cong.Value.Date);

            gridControl1.DataSource = m_ds.Tables[0];
        }

        private DS_DM_LOAI_NGAY_CONG load_data_2_ds_dm_loai_ngay_cong()
        {
            DS_DM_LOAI_NGAY_CONG v_ds = new DS_DM_LOAI_NGAY_CONG();
            US_DM_LOAI_NGAY_CONG v_us = new US_DM_LOAI_NGAY_CONG();

            v_ds.Clear();
            v_ds.EnforceConstraints = false;
            v_us.FillDataset(v_ds);

            return v_ds;
        }

        private void load_data_2_le_loai_ngay_cong()
        {
            //Chinh hien thi nguoi dung
            //m_le_loai_ngay_cong.DataSource = load_data_2_ds_dm_loai_ngay_cong().DM_LOAI_NGAY_CONG;
            //m_le_loai_ngay_cong.DisplayMember = DM_LOAI_NGAY_CONG.MA_NGAY_CONG;
            //m_le_loai_ngay_cong.ValueMember = DM_LOAI_NGAY_CONG.ID;

            //m_le_loai_ngay_cong.PopulateColumns();
            //m_le_loai_ngay_cong.Columns[DM_LOAI_NGAY_CONG.ID].Visible = false;
            //m_le_loai_ngay_cong.Columns[DM_LOAI_NGAY_CONG.TI_LE_LCD].Visible = false;
            //m_le_loai_ngay_cong.Columns[DM_LOAI_NGAY_CONG.TI_LE_LNS].Visible = false;

            //m_le_loai_ngay_cong.Columns[DM_LOAI_NGAY_CONG.MA_NGAY_CONG].Width = 300;
            //m_le_loai_ngay_cong.Columns[DM_LOAI_NGAY_CONG.TEN_NGAY_CONG].Width = 150;

            //m_le_loai_ngay_cong.Columns[DM_LOAI_NGAY_CONG.MA_NGAY_CONG].Caption = "Mã ngày công";
            //m_le_loai_ngay_cong.Columns[DM_LOAI_NGAY_CONG.TEN_NGAY_CONG].Caption = "Tên ngày công";

            //m_le_loai_ngay_cong.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            //m_le_loai_ngay_cong.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;

            m_gle_loai_ngay_cong.DataSource = load_data_2_ds_dm_loai_ngay_cong().DM_LOAI_NGAY_CONG;
            m_gle_loai_ngay_cong.DisplayMember = DM_LOAI_NGAY_CONG.MA_NGAY_CONG;
            m_gle_loai_ngay_cong.ValueMember = DM_LOAI_NGAY_CONG.ID;

            m_gle_loai_ngay_cong.PopulateViewColumns();
            m_gle_loai_ngay_cong.View.Columns[DM_LOAI_NGAY_CONG.ID].Visible = false;
            m_gle_loai_ngay_cong.View.Columns[DM_LOAI_NGAY_CONG.TI_LE_LCD].Visible = false;
            m_gle_loai_ngay_cong.View.Columns[DM_LOAI_NGAY_CONG.TI_LE_LNS].Visible = false;

            m_gle_loai_ngay_cong.View.Columns[DM_LOAI_NGAY_CONG.MA_NGAY_CONG].Width = 300;
            m_gle_loai_ngay_cong.View.Columns[DM_LOAI_NGAY_CONG.TEN_NGAY_CONG].Width = 150;

            m_gle_loai_ngay_cong.View.Columns[DM_LOAI_NGAY_CONG.MA_NGAY_CONG].Caption = "Mã ngày công";
            m_gle_loai_ngay_cong.View.Columns[DM_LOAI_NGAY_CONG.TEN_NGAY_CONG].Caption = "Tên ngày công";

            m_gle_loai_ngay_cong.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            m_gle_loai_ngay_cong.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
        }

        private void set_initial_form_load()
        {
            //load_data_2_grid();
        }

        #endregion
        private void set_define_events()
        {
            this.Load += f310_cham_cong_theo_danh_sach_nhan_vien_Load;
            m_cmd_search.Click += m_cmd_search_Click;
            m_gle_loai_ngay_cong.EditValueChanged += m_gle_loai_ngay_cong_EditValueChanged;
        }

        
        private void f310_cham_cong_theo_danh_sach_nhan_vien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bKI_DVMDDataSet.DM_LOAI_NGAY_CONG' table. You can move, or remove it, as needed.
            this.dM_LOAI_NGAY_CONGTableAdapter.Fill(this.bKI_DVMDDataSet.DM_LOAI_NGAY_CONG);
            try
            {
                set_initial_form_load();
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
                load_data_2_le_loai_ngay_cong();

            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_gle_loai_ngay_cong_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }



    }
}
