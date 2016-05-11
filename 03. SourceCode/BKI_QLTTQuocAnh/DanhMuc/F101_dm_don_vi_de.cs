using BKI_DichVuMatDat.DS;
using BKI_DichVuMatDat.DS.CDBNames;
using BKI_DichVuMatDat.US;
using DevExpress.XtraEditors;
using IP.Core.IPCommon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BKI_DichVuMatDat.DanhMuc
{
    public partial class F101_dm_don_vi_de : Form
    {
        US_DM_DON_VI m_us_dm_dv = new US_DM_DON_VI();
        public F101_dm_don_vi_de()
        {
            InitializeComponent();
            format_controls();
        }

        #region Public interface
        public void display_4_insert()
        {
            this.Text = "F101 - Thêm đơn vị";
            m_lbl_header.Text = "THÊM ĐƠN VỊ";
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            this.CenterToScreen();
            this.ShowDialog();            
        }

        public void display_4_update(US_DM_DON_VI ip_us)
        {
            this.Text = "F101 - Sửa đơn vị";
            m_lbl_header.Text = "SỬA ĐƠN VỊ";
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            m_txt_ma_dv.Text = ip_us.strMA_DON_VI;
            m_txt_ten_dv.Text = ip_us.strTEN_DON_VI;
            //m_sle_loai_dv.EditValue = ip_us.dcID_LOAI_DON_VI;
            m_txt_thu_tu.Text = ip_us.dcSO_THU_TU.ToString();
            m_sle_chon_dv_cap_tren.EditValue = ip_us.dcID_DON_VI_CAP_TREN;
            m_us_dm_dv = ip_us;
            this.CenterToScreen();
            this.ShowDialog();
        }
        #endregion

        #region Members
        DataEntryFormMode m_e_form_mode = DataEntryFormMode.InsertDataState;
        decimal m_id_dm_dv_4_update = 0;
        decimal m_id_dm_don_vi_moi_tao = 0;
        #endregion

        #region Private Methods
        private void format_controls()
        {
            //FormatControl.SetVisibleSimpleButton(this);
            set_define_events();
            this.KeyPreview = true;
        }

        private void set_initial_form_load()
        {
            load_data_2_sle_loai_don_vi();
            load_data_2_sle_don_vi_cap_tren();
        }

        private DS_CM_DM_TU_DIEN load_data_2_cm_dm_tu_dien(int m_id_lns_lcd_trong_loai_td)
        {
            DS_CM_DM_TU_DIEN v_ds = new DS_CM_DM_TU_DIEN();
            US_CM_DM_TU_DIEN v_us = new US_CM_DM_TU_DIEN();

            v_us.FillDatasetByIdLoaiTuDien(v_ds, m_id_lns_lcd_trong_loai_td);

            return v_ds;
        }

        private void load_data_2_sle_loai_don_vi()
        {
            //m_sle_loai_dv.Properties.DataSource = load_data_2_cm_dm_tu_dien(CONST_ID_LOAI_TU_DIEN.LOAI_DON_VI).CM_DM_TU_DIEN;
            //m_sle_loai_dv.Properties.ValueMember = CM_DM_TU_DIEN.ID;
            //m_sle_loai_dv.Properties.DisplayMember = CM_DM_TU_DIEN.TEN;

            //m_sle_loai_dv.Properties.PopulateViewColumns();
            //m_sle_loai_dv.Properties.View.Columns[CM_DM_TU_DIEN.ID].Visible = false;
            //m_sle_loai_dv.Properties.View.Columns[CM_DM_TU_DIEN.ID_LOAI_TU_DIEN].Visible = false;
            //m_sle_loai_dv.Properties.View.Columns[CM_DM_TU_DIEN.TEN_NGAN].Visible = false;

            //m_sle_loai_dv.Properties.View.Columns[CM_DM_TU_DIEN.MA_TU_DIEN].Width = 75;
            //m_sle_loai_dv.Properties.View.Columns[CM_DM_TU_DIEN.TEN].Width = 120;

            //m_sle_loai_dv.Properties.View.Columns[CM_DM_TU_DIEN.MA_TU_DIEN].Caption = "Mã loại đơn vị";
            //m_sle_loai_dv.Properties.View.Columns[CM_DM_TU_DIEN.TEN].Caption = "Loại đơn vị";
            //m_sle_loai_dv.Properties.View.Columns[CM_DM_TU_DIEN.GHI_CHU].Caption = "Ghi chú";

            //m_sle_loai_dv.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            //m_sle_loai_dv.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
        }

        private DS_DM_DON_VI load_data_2_dm_loai_don_vi()
        {
            DS_DM_DON_VI v_ds = new DS_DM_DON_VI();
            US_DM_DON_VI v_us = new US_DM_DON_VI();

            v_us.FillDataset(v_ds);

            return v_ds;
        }

        private void load_data_2_sle_don_vi_cap_tren()
        {
            m_sle_chon_dv_cap_tren.Properties.DataSource = load_data_2_dm_loai_don_vi().DM_DON_VI;
            m_sle_chon_dv_cap_tren.Properties.ValueMember = DM_DON_VI.ID;
            m_sle_chon_dv_cap_tren.Properties.DisplayMember = DM_DON_VI.TEN_DON_VI;
            m_sle_chon_dv_cap_tren.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            m_sle_chon_dv_cap_tren.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
        }

        //check validate data
        private bool check_ma_don_vi_is_exist()
        {
            US_DM_DON_VI v_us = new US_DM_DON_VI();
            DS_DM_DON_VI v_ds = new DS_DM_DON_VI();
            v_us.FillDataset(v_ds, "where ma_don_vi = N'" + m_txt_ma_dv.Text + "'");
            if (m_txt_ma_dv.Text != m_us_dm_dv.strMA_DON_VI && v_ds.Tables[0].Rows.Count !=0)
            {
                return true;
            }
            return false;
        }

        private bool check_validate_data()
        {
            if (m_txt_ma_dv.Text == "")
            {
                string v_str_error = "Bạn chưa nhập mã đơn vị!";
                XtraMessageBox.Show(v_str_error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (m_txt_ten_dv.Text == "")
            {
                CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_CHUA_NHAP_TEN_DON_VI);
                return false;
            }
            else if (m_txt_thu_tu.Text == "")
            {
                string v_str_error = "Bạn chưa nhập thứ tự!";
                XtraMessageBox.Show(v_str_error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (check_ma_don_vi_is_exist())
            {
                string v_str_error = "Mã đơn vị đã tồn tại!";
                XtraMessageBox.Show(v_str_error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        //save data
        private void form_2_us_obj()
        {
            m_us_dm_dv.strMA_DON_VI = m_txt_ma_dv.Text.Trim();
            if (m_sle_chon_dv_cap_tren.EditValue == null )
            {
                m_us_dm_dv.SetID_DON_VI_CAP_TRENNull();
            }
            else
            {
                m_us_dm_dv.dcID_DON_VI_CAP_TREN = CIPConvert.ToDecimal(m_sle_chon_dv_cap_tren.EditValue);
            }
            m_us_dm_dv.strTEN_DON_VI = m_txt_ten_dv.Text.Trim();
            m_us_dm_dv.dcSO_THU_TU = CIPConvert.ToDecimal(m_txt_thu_tu.Text);
        }

        private void save_data()
        {
            form_2_us_obj();
            try
            {
                switch (m_e_form_mode)
                {
                    case DataEntryFormMode.InsertDataState:
                        m_us_dm_dv.Insert();
                        break;
                    case DataEntryFormMode.UpdateDataState:
                        m_us_dm_dv.Update();
                        break;
                    default:
                        break;
                }
                CHRM_BaseMessages.MsgBox_Infor(CONST_ID_MSGBOX.INFOR_DU_LIEU_DA_DUOC_CAP_NHAT);
                this.Close();
            }
            catch (Exception v_e)
            {
                throw v_e;
            }
        }

        private void refresh_form()
        {
            m_txt_ma_dv.Text = "";
            m_txt_ma_dv.BackColor = Color.White;
            //m_lbl_kiem_tra_ma_dv.Visible = false;
            m_txt_ten_dv.Text = "";
            //m_sle_loai_dv.EditValue = null;
            m_sle_chon_dv_cap_tren.EditValue = null;
        }

        #endregion
        private void set_define_events()
        {
            this.Load += F101_dm_don_vi_de_Load;
            m_cmd_save.Click += m_cmd_save_Click;
            this.KeyDown += F101_dm_don_vi_de_KeyDown;
        }

        void F101_dm_don_vi_de_Load(object sender, EventArgs e)
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

        void m_cmd_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (check_validate_data())
                {
                    if (CHRM_BaseMessages.MsgBox_Confirm(CONST_ID_MSGBOX.QUESTION_XAC_NHAN_LUU_DU_LIEU) == true)
                    {
                        save_data();
                    }
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void F101_dm_don_vi_de_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
                {
                    this.Close();
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_gr_thong_tin_co_ban_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
