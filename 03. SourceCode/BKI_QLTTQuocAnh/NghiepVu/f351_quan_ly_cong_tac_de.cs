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
using IP.Core.IPSystemAdmin;


namespace BKI_DichVuMatDat.NghiepVu
{
    public partial class f351_quan_ly_cong_tac_de : Form
    {
        public f351_quan_ly_cong_tac_de()
        {
            InitializeComponent();
            format_controls();
        }

        #region Public Methods

        #endregion

        #region Members

        #endregion

        #region Data structure

        #endregion

        #region Private Methods
        private void format_controls()
        {
            FormatControl.SetVisibleSimpleButton(this);
            set_define_events();
            this.KeyPreview = true;
        }

        private void set_init_form_load()
        {
            load_data_2_sle_chon_nv();
            load_data_2_sle_chon_quyet_dinh();
            load_data_2_sle_chon_don_vi();
            load_data_2_sle_chon_vi_tri();
            load_data_2_sle_chon_loai_cong_tac();
        }

        //load data to all controls

        private DataSet load_data_2_ds_v_dm_nv()
        {
            US_V_DM_NHAN_VIEN v_us = new US_V_DM_NHAN_VIEN();
            DS_V_DM_NHAN_VIEN v_ds = new DS_V_DM_NHAN_VIEN();

            v_us.FillDataset(v_ds);

            return v_ds;
        }

        private void load_data_2_sle_chon_nv()
        {
            m_sle_chon_nhan_vien.Properties.DataSource = load_data_2_ds_v_dm_nv().Tables[0];

            m_sle_chon_nhan_vien.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            m_sle_chon_nhan_vien.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
        }

        private DataSet load_data_2_ds_v_gd_quyet_dinh()
        {
            US_V_GD_QUYET_DINH v_us = new US_V_GD_QUYET_DINH();
            DS_V_GD_QUYET_DINH v_ds = new DS_V_GD_QUYET_DINH();
            v_us.FillDataset(v_ds);
            //v_us.FillDatasetWithTableName(v_ds, "V_GD_QUYET_DINH");
            return v_ds;
        }

        private void load_data_2_sle_chon_quyet_dinh()
        {
            m_sle_chon_quyet_dinh.Properties.DataSource = load_data_2_ds_v_gd_quyet_dinh().Tables[0];
            m_sle_chon_quyet_dinh.Properties.DisplayMember = V_GD_QUYET_DINH.TEN;
            m_sle_chon_quyet_dinh.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            m_sle_chon_quyet_dinh.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
        }

        private DataSet load_data_2_cm_dm_tu_dien(int m_id_vt)
        {
            DS_CM_DM_TU_DIEN v_ds = new DS_CM_DM_TU_DIEN();
            US_CM_DM_TU_DIEN v_us = new US_CM_DM_TU_DIEN();
            v_us.FillDatasetByIdLoaiTuDien(v_ds, m_id_vt);
            return v_ds;
        }

        private DataSet load_data_2_ds_v_dm_don_vi()
        {
            US_DM_DON_VI v_us = new US_DM_DON_VI();
            DS_DM_DON_VI v_ds = new DS_DM_DON_VI();
            v_us.FillDataset(v_ds);
            return v_ds;
        }

        private void load_data_2_sle_chon_don_vi()
        {
            DataSet v_ds = new DataSet();
            v_ds = load_data_2_ds_v_dm_don_vi();
            m_sle_chon_don_vi.Properties.DataSource = v_ds.Tables[0];

            m_sle_chon_don_vi.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            m_sle_chon_don_vi.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
        }

        private void load_data_2_sle_chon_vi_tri()
        {
            m_sle_chon_vi_tri.Properties.DataSource = load_data_2_cm_dm_tu_dien(CONST_ID_LOAI_TU_DIEN.LOAI_VI_TRI).Tables[0];

            m_sle_chon_vi_tri.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            m_sle_chon_vi_tri.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
        }

        private void load_data_2_sle_chon_loai_cong_tac()
        {
            m_sle_chon_loai_cong_tac.Properties.DataSource = load_data_2_cm_dm_tu_dien(CONST_ID_LOAI_TU_DIEN.LOAI_CONG_TAC).Tables[0];

            m_sle_chon_loai_cong_tac.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            m_sle_chon_loai_cong_tac.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
        }

        private void save_data()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Events Handle
        private void set_define_events()
        {
            this.Load += f351_quan_ly_cong_tac_de_Load;
            this.FormClosed += f351_quan_ly_cong_tac_de_FormClosed;
            this.KeyDown += f351_quan_ly_cong_tac_de_KeyDown;
            m_cmd_save.Click += m_cmd_save_Click;
            m_cmd_exit.Click += m_cmd_exit_Click;
        }

        void f351_quan_ly_cong_tac_de_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
                {
                    this.Close();
                }
                if (e.KeyCode == Keys.Enter)
                {
                    save_data();
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void f351_quan_ly_cong_tac_de_Load(object sender, EventArgs e)
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

        void f351_quan_ly_cong_tac_de_FormClosed(object sender, FormClosedEventArgs e)
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

        void m_cmd_save_Click(object sender, EventArgs e)
        {
            try
            {
                save_data();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_exit_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        #endregion
    }
}
