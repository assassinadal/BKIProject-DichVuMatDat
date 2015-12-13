using BKI_DichVuMatDat.DS;
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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BKI_DichVuMatDat.DanhMuc
{
    public partial class f160_them_nhan_vien_nhanh : Form
    {
        public f160_them_nhan_vien_nhanh()
        {
            InitializeComponent();
            fill_data_trang_thai_ld();
        }
        private void fill_data_trang_thai_ld()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add();

            v_us.FillDatasetWithQuery(v_ds, "select * from DM_TRANG_THAI_LD");
            m_ld_ttld.Properties.DataSource = v_ds.Tables[0];
        }
        private bool validate_control_empty(params Control[] controls)
        {
            var isValidated = false;

            foreach(var control in controls)
            {
                control.BackColor = Color.White;
                var typeOfControl = control.GetType().ToString();

                switch(typeOfControl)
                {
                    case "DevExpress.XtraEditors.TextEdit":
                        {
                            var controlTextEdit = control as TextEdit;
                            isValidated = (controlTextEdit.Text.Trim() != "");
                            break;
                        }
                    case "DevExpress.XtraEditors.MemoEdit":
                        {
                            var controlMemoEdit = control as MemoEdit;
                            isValidated = (controlMemoEdit.Text.Trim() != "");
                            break;
                        }
                    case "DevExpress.XtraEditors.DateEdit":
                        {
                            var controlDateEdit = control as DateEdit;
                            isValidated = (controlDateEdit.EditValue != null);
                            break;
                        }
                    case "DevExpress.XtraEditors.ComboBoxEdit":
                        {
                            var controlComboBoxEdit = control as ComboBoxEdit;
                            isValidated = (controlComboBoxEdit.EditValue != null);
                            break;
                        }
                    case "DevExpress.XtraEditors.ButtonEdit":
                        {
                            var controlButtonEdit = control as ButtonEdit;
                            isValidated = (controlButtonEdit.EditValue != null);
                            break;
                        }
                    case "DevExpress.XtraEditors.CheckEdit":
                        {
                            var controlCheckEdit = control as CheckEdit;
                            isValidated = (controlCheckEdit.EditValue != null);
                            break;
                        }
                    case "DevExpress.XtraEditors.SpinEdit":
                        {
                            var controlSpinEdit = control as SpinEdit;
                            isValidated = (controlSpinEdit.EditValue != null);
                            break;
                        }
                    case "DevExpress.XtraEditors.LookUpEdit":
                        {
                            var controlLookUpEdit = control as LookUpEdit;
                            isValidated = (controlLookUpEdit.EditValue != null);
                            break;
                        }
                    case "DevExpress.XtraEditors.SearchLookUpEdit":
                        {
                            var controlSearchLookUpEdit = control as SearchLookUpEdit;
                            isValidated = (controlSearchLookUpEdit.EditValue != null && controlSearchLookUpEdit.EditValue.ToString().Trim() != string.Empty);
                            break;
                        }
                    case "DevExpress.XtraEditors.CheckedComboBoxEdit":
                        {
                            var controlCheckedComboBoxEdit = control as CheckedComboBoxEdit;
                            isValidated = (controlCheckedComboBoxEdit.EditValue != null && controlCheckedComboBoxEdit.EditValue.ToString().Trim() != string.Empty);
                            break;
                        }
                    default:
                        break;
                }

                if(!isValidated)
                {
                    control.Focus();
                    control.BackColor = Color.Pink;
                    break;
                }
            }
            return isValidated;
        }

        private void m_cmd_save_Click(object sender, EventArgs e)
        {
            try
            {
                US_DM_NHAN_VIEN v_us_dm_nhan_vien = new US_DM_NHAN_VIEN();
                US_GD_TRANG_THAI_LAO_DONG v_us_gd_ttld = new US_GD_TRANG_THAI_LAO_DONG();
                try
                {
                    if(!validate_control_empty(m_txt_ho_dem, m_txt_ma_nv, m_txt_ten_nv, m_ld_ttld))
                    {
                        MessageBox.Show("Nhập liệu thiếu");
                        return;
                    }
                    
                    v_us_dm_nhan_vien.BeginTransaction();
                    v_us_dm_nhan_vien.strMA_NV = m_txt_ma_nv.Text;
                    v_us_dm_nhan_vien.strHO_DEM = m_txt_ho_dem.Text;
                    v_us_dm_nhan_vien.strTEN = m_txt_ten_nv.Text;

                    v_us_dm_nhan_vien.Insert();
                    v_us_gd_ttld.datNGAY_LAP = DateTime.Now;
                    v_us_gd_ttld.dcID_NHAN_VIEN = v_us_dm_nhan_vien.dcID;
                    v_us_gd_ttld.dcID_TRANG_THAI_LAO_DONG = Convert.ToDecimal(m_ld_ttld.EditValue);
                    v_us_gd_ttld.strDA_XOA = "N";
                    v_us_gd_ttld.UseTransOfUSObject(v_us_dm_nhan_vien);
                    v_us_gd_ttld.Insert();
                    v_us_dm_nhan_vien.CommitTransaction();
                    MessageBox.Show("Thêm nhân viên thành công");
                }
                catch(Exception)
                {
                    if(v_us_dm_nhan_vien.is_having_transaction())
                    {
                        v_us_dm_nhan_vien.Rollback();
                    }
                    throw;
                }

            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }


    }
}
