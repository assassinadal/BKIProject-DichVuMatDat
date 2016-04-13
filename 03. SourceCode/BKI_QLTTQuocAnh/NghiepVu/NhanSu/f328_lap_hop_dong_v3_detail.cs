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
using BKI_DichVuMatDat.US;
using BKI_DichVuMatDat.DS;
using DevExpress.XtraEditors;
using BKI_DichVuMatDat.DS.CDBNames;

namespace BKI_DichVuMatDat.NghiepVu.NhanSu
{
    public partial class f328_lap_hop_dong_v3_detail : Form
    {
        #region Public Interface
        public f328_lap_hop_dong_v3_detail()
        {
            InitializeComponent();
            set_defines_event();
        }
        #endregion       

        #region Members
        DataEntryFormMode m_e_form_mode;
        US_GD_HOP_DONG m_us = new US_GD_HOP_DONG();
        #endregion

        #region Private Method
        internal void display_for_insert()
        {
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            this.ShowDialog();
        }

        private void load_data_to_sle_nhan_vien()
        {
            US_V_DM_NHAN_VIEN v_us = new US_V_DM_NHAN_VIEN();
            DS_V_DM_NHAN_VIEN v_ds = new DS_V_DM_NHAN_VIEN();
            v_us.FillDataset(v_ds);
            m_sle_chon_nhan_vien.Properties.DataSource = v_ds.Tables[0];
            m_sle_chon_nhan_vien.Properties.DisplayMember = V_DM_NHAN_VIEN.HO_TEN;
            m_sle_chon_nhan_vien.Properties.ValueMember = V_DM_NHAN_VIEN.ID;
        }

        private void load_data_to_sle_loai_hop_dong()
        {
            US_DM_LOAI_HOP_DONG v_us = new US_DM_LOAI_HOP_DONG();
            DS_DM_LOAI_HOP_DONG v_ds = new DS_DM_LOAI_HOP_DONG();
            v_us.FillDataset(v_ds);
            m_sle_loai_hop_dong.Properties.DataSource = v_ds.Tables[0];
            m_sle_loai_hop_dong.Properties.DisplayMember = DM_LOAI_HOP_DONG.LOAI_HOP_DONG;
            m_sle_loai_hop_dong.Properties.ValueMember = DM_LOAI_HOP_DONG.ID;
        }

        private void load_data_to_sle_ma_lns()
        {
            US_CM_DM_TU_DIEN v_us = new US_CM_DM_TU_DIEN();
            DS_CM_DM_TU_DIEN v_ds = new DS_CM_DM_TU_DIEN();
            v_us.FillDatasetByIdLoaiTuDien(v_ds, 1);
            m_sle_chuc_danh_lns.Properties.DataSource = v_ds.Tables[0];
            m_sle_chuc_danh_lns.Properties.DisplayMember = CM_DM_TU_DIEN.TEN;
            m_sle_chuc_danh_lns.Properties.ValueMember = CM_DM_TU_DIEN.ID;
            m_sle_chuc_danh_lns.EditValue = null;
            m_sle_chuc_danh_lns.Properties.NullText = "---Chọn mã lương năng suất---";
        }

        private void load_data_to_sle_muc_lns()
        {
            US_CM_DM_TU_DIEN v_us = new US_CM_DM_TU_DIEN();
            DS_CM_DM_TU_DIEN v_ds = new DS_CM_DM_TU_DIEN();
            v_us.FillDatasetByIdLoaiTuDien(v_ds, 2);
            m_sle_muc_lns.Properties.DataSource = v_ds.Tables[0];
            m_sle_muc_lns.Properties.DisplayMember = CM_DM_TU_DIEN.TEN;
            m_sle_muc_lns.Properties.ValueMember = CM_DM_TU_DIEN.ID;
            m_sle_chuc_danh_lns.EditValue = null;
            m_sle_muc_lns.Properties.NullText = "---Chọn mức lương năng suất---";
        }

        private void load_data_to_sle_ma_lcd()
        {
            US_CM_DM_TU_DIEN v_us = new US_CM_DM_TU_DIEN();
            DS_CM_DM_TU_DIEN v_ds = new DS_CM_DM_TU_DIEN();
            v_us.FillDatasetByIdLoaiTuDien(v_ds, 3);
            m_sle_chuc_danh_lcd.Properties.DataSource = v_ds.Tables[0];
            m_sle_chuc_danh_lcd.Properties.DisplayMember = CM_DM_TU_DIEN.TEN;
            m_sle_chuc_danh_lcd.Properties.ValueMember = CM_DM_TU_DIEN.ID;
            m_sle_chuc_danh_lns.EditValue = null;
            m_sle_chuc_danh_lcd.Properties.NullText = "---Chọn mã lương chế độ---";
        }

        private void load_data_to_sle_muc_lcd()
        {
            US_CM_DM_TU_DIEN v_us = new US_CM_DM_TU_DIEN();
            DS_CM_DM_TU_DIEN v_ds = new DS_CM_DM_TU_DIEN();
            v_us.FillDatasetByIdLoaiTuDien(v_ds, 4);
            m_sle_muc_lcd.Properties.DataSource = v_ds.Tables[0];
            m_sle_muc_lcd.Properties.DisplayMember = CM_DM_TU_DIEN.TEN;
            m_sle_muc_lcd.Properties.ValueMember = CM_DM_TU_DIEN.ID;
            m_sle_chuc_danh_lns.EditValue = null;
            m_sle_muc_lcd.Properties.NullText = "---Chọn mức lương chế độ---";
        }

        private void load_data_to_lbl_he_so_lns()
        {
            US_DM_HE_SO_LUONG_NS v_us = new US_DM_HE_SO_LUONG_NS();
            DS_DM_HE_SO_LUONG_NS v_ds = new DS_DM_HE_SO_LUONG_NS();
            v_us.FillDatasetTheoIDMaMuc(v_ds, m_sle_chuc_danh_lns.EditValue.ToString(), m_sle_muc_lns.EditValue.ToString());

        }

        private bool check_du_lieu_hop_le()
        {
            if (check_thong_tin_co_ban())
                return true;
            else if (check_thong_tin_luong())
                return true;
            return false;
        }

        private bool check_thong_tin_co_ban()
        {
            if (m_sle_chon_nhan_vien.EditValue == null)
            {
                string v_str_error = "Bạn chưa chọn nhân viên!";
                XtraMessageBox.Show(v_str_error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (m_sle_loai_hop_dong.EditValue == null)
            {
                string v_str_error = "Bạn chưa chọn loại hợp đồng!";
                XtraMessageBox.Show(v_str_error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (m_txt_ma_hd.Text.Trim() == "")
            {
                string v_str_error = "Bạn chưa nhập mã hợp đồng!";
                XtraMessageBox.Show(v_str_error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if(m_dat_ngay_bat_dau.Value >= m_dat_ngay_ket_thuc.Value) 
            {
                string v_str_error = "Ngày bắt đầu đang lớn hơn ngày kết thúc";
                XtraMessageBox.Show(v_str_error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool check_thong_tin_luong()
        {
            if (m_sle_chuc_danh_lns.EditValue == null)
            {
                string v_str_error = "Bạn chưa chọn mã lương năng suất!";
                XtraMessageBox.Show(v_str_error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;               
            }
            else if(m_sle_muc_lns.EditValue == null)
            {
                string v_str_error = "Bạn chưa chọn mức lương năng suất!";
                XtraMessageBox.Show(v_str_error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (m_sle_chuc_danh_lcd.EditValue == null)
            {
                string v_str_error = "Bạn chưa chọn mã lương chế độ!";
                XtraMessageBox.Show(v_str_error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (m_sle_muc_lcd.EditValue == null)
            {
                string v_str_error = "Bạn chưa chọn mức lương chế độ!";
                XtraMessageBox.Show(v_str_error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        #endregion

        #region Event Handler

        private void set_defines_event()
        {
            this.Load += f328_lap_hop_dong_v3_detail_Load;
            m_cmd_save.Click += m_cmd_save_Click;
            m_sle_chuc_danh_lns.EditValueChanged += m_sle_chuc_danh_lns_EditValueChanged;
            m_sle_muc_lns.EditValueChanged += m_sle_muc_lns_EditValueChanged;
            m_sle_chuc_danh_lcd.EditValueChanged += m_sle_chuc_danh_lcd_EditValueChanged;
            m_sle_muc_lcd.EditValueChanged += m_sle_muc_lcd_EditValueChanged;
        }

        void m_sle_muc_lcd_EditValueChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        void m_sle_chuc_danh_lcd_EditValueChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        void m_sle_muc_lns_EditValueChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        void m_sle_chuc_danh_lns_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (m_sle_muc_lns.EditValue != null)
                    load_data_to_lbl_he_so_lns();               
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
                if (check_du_lieu_hop_le())
                {
                    
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void f328_lap_hop_dong_v3_detail_Load(object sender, EventArgs e)
        {
            try
            {
                load_data_to_sle_nhan_vien();
                load_data_to_sle_loai_hop_dong();
                load_data_to_sle_ma_lns();
                load_data_to_sle_muc_lns();
                load_data_to_sle_ma_lcd();
                load_data_to_sle_muc_lcd();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        #endregion


    }
}
