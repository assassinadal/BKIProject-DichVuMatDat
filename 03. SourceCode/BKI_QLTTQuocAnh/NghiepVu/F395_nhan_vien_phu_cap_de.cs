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

namespace BKI_DichVuMatDat.NghiepVu
{
    public partial class F395_nhan_vien_phu_cap_de : Form
    {
        DataEntryFormMode m_e_form_mode;
        US_GD_NHAN_VIEN_PHU_CAP m_us = new US_GD_NHAN_VIEN_PHU_CAP();
        public F395_nhan_vien_phu_cap_de()
        {
            InitializeComponent();
            this.CenterToScreen();
        }
        private void F393_nhan_vien_phu_cap_de_Load(object sender, EventArgs e)
        {
            try
            {
                load_data_2_sle_nhan_vien();
                load_data_2_sle_phu_cap();
            }
            catch (Exception v_e)
            {
                IP.Core.IPCommon.CSystemLog_301.ExceptionHandle(v_e);
            }
        }
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
            if ( m_sle_nhan_vien.EditValue == null)
            {
                CHRM_BaseMessages.MsgBox_Error(CONST_ID_MSGBOX.ERROR_CHUA_CHON_NHAN_VIEN);
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

        internal void display_for_insert()
        {
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            this.ShowDialog();
        }

        private void m_cmd_luu_Click(object sender, EventArgs e)
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
                    }
                    DevExpress.XtraEditors.XtraMessageBox.Show("Lưu thành công!");
                    this.Close();
                }                
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void form_to_us()
        {
            m_us.dcID_NHAN_VIEN = Convert.ToDecimal(m_sle_nhan_vien.EditValue);
            m_us.dcID_PHU_CAP = Convert.ToDecimal(m_sle_phu_cap.EditValue);
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

        private void us_to_form()
        {
            m_sle_nhan_vien.EditValue = m_us.dcID_NHAN_VIEN;
            m_sle_phu_cap.EditValue = m_us.dcID_PHU_CAP;
        }

        internal void display_for_update(US_GD_NHAN_VIEN_PHU_CAP v_us)
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            m_us = v_us;
            us_to_form();
            m_sle_nhan_vien.Enabled = false;
            this.ShowDialog();
        }
    }
}