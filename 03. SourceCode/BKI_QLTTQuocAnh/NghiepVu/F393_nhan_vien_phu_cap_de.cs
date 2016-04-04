using BKI_DichVuMatDat.DS;
using BKI_DichVuMatDat.DS.CDBNames;
using BKI_DichVuMatDat.US;
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
using IP.Core.IPSystemAdmin;
using DevExpress.XtraEditors;

namespace BKI_DichVuMatDat.NghiepVu
{
    public partial class F393_nhan_vien_phu_cap_de : Form
    {
        #region Members
        US_GD_NHAN_VIEN_PHU_CAP m_us = new US_GD_NHAN_VIEN_PHU_CAP();
        DataEntryFormMode m_e_form_mode;
        #endregion

        #region Public Interface
        public F393_nhan_vien_phu_cap_de()
        {
            InitializeComponent();
            this.CenterToScreen();
        }
        #endregion

        #region Event Handle
        private void F393_nhan_vien_phu_cap_de_Load(object sender, EventArgs e)
        {
            try
            {
                load_data_2_sle_nhan_vien();
                load_data_2_sle_quyet_dinh();
                load_data_2_sle_phu_cap();
            }
            catch (Exception v_e)
            {
                IP.Core.IPCommon.CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_them_Click(object sender, EventArgs e)
        {
            try
            {
                if (check_data())
                {
                    form_to_us();
                    switch (m_e_form_mode)
                    {
                        case DataEntryFormMode.InsertDataState:
                            m_us.Insert();
                            break;
                        case DataEntryFormMode.UpdateDataState:
                            m_us.Update();
                            break;
                        default:
                            break;
                    }
                    XtraMessageBox.Show("Lưu thành công!");
                    this.Close();
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }

        }

        private void m_cmd_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult = System.Windows.Forms.DialogResult.Cancel;
                this.Close();
            }
            catch (Exception v_e)
            {
                IP.Core.IPCommon.CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        #endregion

        #region Private Method
        private void load_data_2_sle_phu_cap()
        {
            m_sle_phu_cap.Properties.DataSource = load_data_2_ds_dm_phu_cap().DM_PHU_CAP;
            m_sle_phu_cap.Properties.DisplayMember = DM_PHU_CAP.DOI_TUONG_HUONG_PHU_CAP;
            m_sle_phu_cap.Properties.ValueMember = DM_PHU_CAP.ID;

            m_sle_phu_cap.Properties.PopulateViewColumns();
            m_sle_phu_cap.Properties.View.Columns[DM_PHU_CAP.ID].Visible = false;
            m_sle_phu_cap.Properties.View.Columns[DM_PHU_CAP.ID_LOAI_PHU_CAP].Visible = false;

            m_sle_phu_cap.Properties.View.Columns[DM_PHU_CAP.DOI_TUONG_HUONG_PHU_CAP].Caption = "Đối tượng hưởng phụ cấp";
            m_sle_phu_cap.Properties.View.Columns[DM_PHU_CAP.TI_LE].Caption = "Tỉ lệ";
        }

        private void load_data_2_sle_quyet_dinh()
        {
            m_sle_quyet_dinh.Properties.DataSource = load_data_2_ds_v_gd_quyet_dinh().V_GD_QUYET_DINH;
            m_sle_quyet_dinh.Properties.DisplayMember = V_GD_QUYET_DINH.MA_QUYET_DINH;
            m_sle_quyet_dinh.Properties.ValueMember = V_GD_QUYET_DINH.ID;

            m_sle_quyet_dinh.Properties.PopulateViewColumns();
            m_sle_quyet_dinh.Properties.View.Columns[V_GD_QUYET_DINH.ID].Visible = false;
            m_sle_quyet_dinh.Properties.View.Columns[V_GD_QUYET_DINH.ID_LOAI_QD].Visible = false;
            m_sle_quyet_dinh.Properties.View.Columns[V_GD_QUYET_DINH.MA_TU_DIEN].Visible = false;
            m_sle_quyet_dinh.Properties.View.Columns[V_GD_QUYET_DINH.TEN_NGAN].Visible = false;

            m_sle_quyet_dinh.Properties.View.Columns[V_GD_QUYET_DINH.MA_QUYET_DINH].Caption = "Mã quyết định";
            m_sle_quyet_dinh.Properties.View.Columns[V_GD_QUYET_DINH.TEN].Caption = "Loại quyết định";
            m_sle_quyet_dinh.Properties.View.Columns[V_GD_QUYET_DINH.NGAY_CO_HIEU_LUC].Caption = "Ngày có hiệu lực";
            m_sle_quyet_dinh.Properties.View.Columns[V_GD_QUYET_DINH.NGAY_HET_HIEU_LUC].Caption = "Ngày hết hiệu lực";
            m_sle_quyet_dinh.Properties.View.Columns[V_GD_QUYET_DINH.NGUOI_KY].Caption = "Người ký";
            m_sle_quyet_dinh.Properties.View.Columns[V_GD_QUYET_DINH.NGAY_KY].Caption = "Ngày ký";
            m_sle_quyet_dinh.Properties.View.Columns[V_GD_QUYET_DINH.NOI_DUNG].Caption = "Nội dung";
            m_sle_quyet_dinh.Properties.View.Columns[V_GD_QUYET_DINH.LINK].Caption = "Link";

            m_sle_quyet_dinh.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
        }

        private void load_data_2_sle_nhan_vien()
        {
            m_sle_nhan_vien.Properties.DataSource = load_data_2_ds_v_dm_nv().V_DM_NHAN_VIEN;
            m_sle_nhan_vien.Properties.ValueMember = V_DM_NHAN_VIEN.ID;
            m_sle_nhan_vien.Properties.DisplayMember = V_DM_NHAN_VIEN.HO_TEN;

            m_sle_nhan_vien.Properties.PopulateViewColumns();

            m_sle_nhan_vien.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            m_sle_nhan_vien.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
        }

        private bool check_data()
        {
            if (m_sle_nhan_vien.EditValue == null)
            {
                CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_CHUA_CHON_NHAN_VIEN);
                return false;
            }
            if (m_sle_quyet_dinh.EditValue == null)
            {
                CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_CHUA_CHON_QUYET_DINH);
                return false;
            }
            if (m_sle_phu_cap.EditValue == null)
            {
                CHRM_BaseMessages.MsgBox_Error("Chưa chọn chức vụ hưởng phụ cấp");
                return false;
            }
            return true;
        }

        private DS_V_DM_NHAN_VIEN load_data_2_ds_v_dm_nv()
        {
            DS_V_DM_NHAN_VIEN v_ds = new DS_V_DM_NHAN_VIEN();
            US_V_DM_NHAN_VIEN v_us = new US_V_DM_NHAN_VIEN();

            v_us.FillDataset(v_ds);
            return v_ds;
        }

        private DS_V_GD_QUYET_DINH load_data_2_ds_v_gd_quyet_dinh()
        {
            US_V_GD_QUYET_DINH v_us = new US_V_GD_QUYET_DINH();
            DS_V_GD_QUYET_DINH v_ds = new DS_V_GD_QUYET_DINH();

            v_us.FillDataset(v_ds);
            return v_ds;
        }

        private DS_DM_PHU_CAP load_data_2_ds_dm_phu_cap()
        {
            US_DM_PHU_CAP v_us = new US_DM_PHU_CAP();
            DS_DM_PHU_CAP v_ds = new DS_DM_PHU_CAP();

            v_us.FillDataset(v_ds);
            return v_ds;
        }

        internal void display_for_update(US_GD_NHAN_VIEN_PHU_CAP v_us)
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            us_to_form(v_us);
            m_sle_nhan_vien.Enabled = false;
            this.ShowDialog();
        }

        internal void display_for_insert()
        {
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            this.ShowDialog();
        }

        private void us_to_form(US_GD_NHAN_VIEN_PHU_CAP v_us)
        {
            m_us = v_us;
            m_sle_nhan_vien.EditValue = v_us.dcID_NHAN_VIEN;
            m_sle_quyet_dinh.EditValue = v_us.dcID_QUYET_DINH;
            m_sle_phu_cap.EditValue = v_us.dcID_PHU_CAP;
        }

        private void form_to_us()
        {
            m_us.dcID_NHAN_VIEN = decimal.Parse(m_sle_nhan_vien.EditValue.ToString());
            m_us.dcID_QUYET_DINH = decimal.Parse(m_sle_quyet_dinh.EditValue.ToString());
            m_us.dcID_PHU_CAP = decimal.Parse(m_sle_phu_cap.EditValue.ToString());
            m_us.strDA_XOA = "N";
            if (m_e_form_mode == DataEntryFormMode.InsertDataState)
            {
                m_us.datNGAY_LAP = DateTime.Now;
                m_us.strNGUOI_LAP = CAppContext_201.getCurrentUserName();
            }
            else if (m_e_form_mode == DataEntryFormMode.UpdateDataState)
            {
                m_us.datNGAY_SUA = DateTime.Now;
                m_us.strNGUOI_SUA = CAppContext_201.getCurrentUserName();
            }
        }
        #endregion

        
    }
}
