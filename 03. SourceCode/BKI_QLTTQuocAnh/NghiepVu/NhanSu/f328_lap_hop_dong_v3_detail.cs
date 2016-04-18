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
using IP.Core.IPSystemAdmin;

namespace BKI_DichVuMatDat.NghiepVu.NhanSu
{
    public partial class f328_lap_hop_dong_v3_detail : Form
    {
        #region Public Interface
        public f328_lap_hop_dong_v3_detail()
        {
            InitializeComponent();
            set_initial_form_load();
        }
        #endregion       

        #region Members
        DataEntryFormMode m_e_form_mode;
        US_GD_HOP_DONG m_us_gd_hd = new US_GD_HOP_DONG();
        US_GD_HS_LNS_LCD m_us_gd_lns_lcd = new US_GD_HS_LNS_LCD();
        #endregion

        #region Private Method
        private void set_initial_form_load()
        {
            m_dat_ngay_bat_dau.DateTime = DateTime.Now;
            m_dat_ngay_ket_thuc.DateTime = DateTime.Now;
            m_dat_ngay_ky.DateTime = DateTime.Now;
            load_data_to_sle_nhan_vien();
            load_data_to_sle_loai_hop_dong();
            load_data_to_sle_ma_lns();
            load_data_to_sle_muc_lns();
            load_data_to_sle_ma_lcd();
            load_data_to_sle_muc_lcd();
            set_defines_event();
        }

        internal void display_for_insert()
        {
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            this.ShowDialog();
        }

        internal void display_for_update(DataRow v_dr)
        {
            US_GD_HOP_DONG v_us = new US_GD_HOP_DONG(Convert.ToDecimal(v_dr["ID"]));
            m_us_gd_hd = v_us;
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            us_to_form(v_dr);
            m_sle_chon_nhan_vien.Enabled = false;
            this.ShowDialog();
        }

        private void us_to_form(DataRow v_dr)
        {
            m_sle_chon_nhan_vien.EditValue = Convert.ToDecimal(v_dr[V_GD_HOP_DONG_V3.ID_NHAN_VIEN]);
            m_sle_loai_hop_dong.EditValue = Convert.ToDecimal(v_dr[V_GD_HOP_DONG_V3.ID_LOAI_HOP_DONG]);
            m_txt_ma_hd.Text = v_dr[V_GD_HOP_DONG_V3.MA_HOP_DONG].ToString();
            m_dat_ngay_ky.DateTime = Convert.ToDateTime(v_dr[V_GD_HOP_DONG_V3.NGAY_KY_HOP_DONG]);
            m_dat_ngay_bat_dau.DateTime = Convert.ToDateTime(v_dr[V_GD_HOP_DONG_V3.NGAY_BAT_DAU]);
            m_dat_ngay_ket_thuc.DateTime = Convert.ToDateTime(v_dr[V_GD_HOP_DONG_V3.NGAY_KET_THUC]);
            m_txt_ghi_chu.Text = v_dr[V_GD_HOP_DONG_V3.GHI_CHU].ToString();
            if (v_dr[V_GD_HOP_DONG_V3.ID_HE_SO_LNS].ToString() == "")
            {
                m_sle_chuc_danh_lns.EditValue = null;
                m_sle_muc_lns.EditValue = null;
            }
            else
            {
                m_sle_chuc_danh_lns.EditValue = Convert.ToDecimal(v_dr[V_GD_HOP_DONG_V3.ID_MA_LNS]);
                m_sle_muc_lns.EditValue = Convert.ToDecimal(v_dr[V_GD_HOP_DONG_V3.ID_MUC_LNS]);
            }
            if (v_dr[V_GD_HOP_DONG_V3.ID_LCD].ToString() == "")
            {
                 m_sle_chuc_danh_lcd.EditValue = null;
                 m_sle_muc_lcd.EditValue = null;
            }
            else
            {
                m_sle_chuc_danh_lcd.EditValue = Convert.ToDecimal(v_dr[V_GD_HOP_DONG_V3.ID_MA_LCD]);
                m_sle_muc_lcd.EditValue = Convert.ToDecimal(v_dr[V_GD_HOP_DONG_V3.ID_MUC_LCD]);
            }
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
            //m_sle_chuc_danh_lns.EditValue = null;
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
            //m_sle_chuc_danh_lns.EditValue = null;
            m_sle_muc_lcd.Properties.NullText = "---Chọn mức lương chế độ---";
        }

        private void load_data_to_lbl_he_so_lns()
        {
            DataRow v_dr = get_luong_ns_theo_ma_muc();
            if (v_dr == null)
                m_lbl_hs_lns.Text = ".....";
            else m_lbl_hs_lns.Text = v_dr["HE_SO"].ToString();
        }

        private void load_data_to_lbl_so_tien_lcd()
        {
            DataRow v_dr = get_luong_cd_theo_ma_muc();
            if (v_dr == null)
                m_lbl_so_tien_lcd.Text = ".....";
            else m_lbl_so_tien_lcd.Text = v_dr["SO_TIEN"].ToString();
        }

        private DataRow get_luong_ns_theo_ma_muc()
        {
            if (m_sle_chuc_danh_lns.EditValue == null || m_sle_muc_lns.EditValue == null)
                return null;
            else
            {
                US_DM_HE_SO_LUONG_NS v_us = new US_DM_HE_SO_LUONG_NS();
                DS_DM_HE_SO_LUONG_NS v_ds = new DS_DM_HE_SO_LUONG_NS();
                v_us.FillDatasetTheoIDMaMuc(v_ds, m_sle_chuc_danh_lns.EditValue.ToString(), m_sle_muc_lns.EditValue.ToString());
                if (v_ds.Tables[0].Rows.Count == 0)
                    return null;
                else return v_ds.Tables[0].Rows[0];
            }           
        }

        private DataRow get_luong_cd_theo_ma_muc()
        {
            if (m_sle_chuc_danh_lcd.EditValue == null || m_sle_muc_lcd.EditValue == null)
                return null;
            else
            {
                US_DM_LUONG_CHE_DO v_us = new US_DM_LUONG_CHE_DO();
                DS_DM_LUONG_CHE_DO v_ds = new DS_DM_LUONG_CHE_DO();
                v_us.FillDatasetTheoIDMaMuc(v_ds, m_sle_chuc_danh_lcd.EditValue.ToString(), m_sle_muc_lcd.EditValue.ToString());
                if (v_ds.Tables[0].Rows.Count == 0)
                    return null;
                else return v_ds.Tables[0].Rows[0];
            }           
        }

        private bool check_du_lieu_hop_le()
        {
            //if (!check_thong_tin_co_ban())
            //    return false;
            //else if (!check_thong_tin_luong())
            //    return false;
            //return true;
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
            else if (check_ma_hd_da_ton_tai(m_txt_ma_hd.Text))
            {
                string v_str_error = "Mã hợp đồng đã tồn tại!";
                XtraMessageBox.Show(v_str_error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (m_dat_ngay_bat_dau.DateTime >= m_dat_ngay_ket_thuc.DateTime)
            {
                string v_str_error = "Ngày bắt đầu đang lớn hơn ngày kết thúc";
                XtraMessageBox.Show(v_str_error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
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
            else if (check_ma_hd_da_ton_tai(m_txt_ma_hd.Text))
            {
                string v_str_error = "Mã hợp đồng đã tồn tại!";
                XtraMessageBox.Show(v_str_error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (m_dat_ngay_bat_dau.DateTime >= m_dat_ngay_ket_thuc.DateTime) 
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
            else if (get_luong_ns_theo_ma_muc() == null)
            {
                string v_str_error = "Mã chức danh chưa được định nghĩa hệ số.\nVui lòng kiểm tra lại!";
                XtraMessageBox.Show(v_str_error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (get_luong_cd_theo_ma_muc() == null)
            {
                string v_str_error = "Mã chức danh chưa được định nghĩa hệ số.\nVui lòng kiểm tra lại!";
                XtraMessageBox.Show(v_str_error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool check_ma_hd_da_ton_tai(string ip_str_ma_hd)
        {
            if (m_us_gd_hd.strMA_HOP_DONG != ip_str_ma_hd)
            {
                US_GD_HOP_DONG v_us = new US_GD_HOP_DONG();
                DS_GD_HOP_DONG v_ds = new DS_GD_HOP_DONG();
                v_us.FillDataset(v_ds, "where MA_HOP_DONG = '" + ip_str_ma_hd + "'");
                if (v_ds.Tables[0].Rows.Count != 0)
                    return true;
            }
            return false;
        }

        private void ket_thuc_hop_dong_cu(decimal ip_id_hop_dong)
        {
            US_GD_HOP_DONG v_us = new US_GD_HOP_DONG(ip_id_hop_dong);
            v_us.datNGAY_KET_THUC = m_dat_ngay_bat_dau.DateTime;
            v_us.Update();
            ket_thuc_he_so_lns(ip_id_hop_dong);
            ket_thuc_lcd(ip_id_hop_dong);
        }

        private void ket_thuc_he_so_lns(decimal ip_id_hop_dong)
        {
            US_GD_HE_SO_LNS v_us = new US_GD_HE_SO_LNS();
            DataTable v_dt = v_us.GetLNSTheoHopDong(ip_id_hop_dong);
            if (v_dt.Rows.Count !=0)
	        {
                v_us = new US_GD_HE_SO_LNS(CIPConvert.ToDecimal(v_dt.Rows[0]["ID"]));
                if (m_e_form_mode== DataEntryFormMode.InsertDataState)
                {
                    v_us.datNGAY_KET_THUC = m_dat_ngay_bat_dau.DateTime;
                }
                else if (m_e_form_mode== DataEntryFormMode.UpdateDataState)
                {
                    v_us.datNGAY_KET_THUC = m_dat_ngay_ket_thuc.DateTime;
                }
                v_us.Update();
	        }           
        }

        private void ket_thuc_lcd(decimal ip_id_hop_dong)
        {
            US_GD_LUONG_CHE_DO v_us = new US_GD_LUONG_CHE_DO();
            DataTable v_dt = v_us.GetLCDTheoHopDong(ip_id_hop_dong);
            if (v_dt.Rows.Count != 0)
            {
                v_us = new US_GD_LUONG_CHE_DO(CIPConvert.ToDecimal(v_dt.Rows[0]["ID"]));
                if (m_e_form_mode == DataEntryFormMode.InsertDataState)
                {
                    v_us.datNGAY_KET_THUC = m_dat_ngay_bat_dau.DateTime;
                }
                else if (m_e_form_mode == DataEntryFormMode.UpdateDataState)
                {
                    v_us.datNGAY_KET_THUC = m_dat_ngay_ket_thuc.DateTime;
                }
                v_us.Update();
            }  
        }  

        private decimal get_id_hop_dong_hien_tai(string ip_id_nv)
        {
            US_GD_HOP_DONG v_us = new US_GD_HOP_DONG();
            return v_us.GetHopDongHienTaiCuaNV(ip_id_nv);
        }

        private void sua_hop_dong()
        {
            
                if (check_gd_he_so_lns())
                    ket_thuc_he_so_lns(m_us_gd_hd.dcID);
                if (check_gd_lcd())
                    ket_thuc_lcd(m_us_gd_hd.dcID);
                cap_nhat_gd_hop_dong();
                XtraMessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();           
        }

        private bool check_gd_he_so_lns()
        {
            US_GD_HE_SO_LNS v_us = new US_GD_HE_SO_LNS();
            DataTable v_dt = v_us.GetLNSTheoHopDong(m_us_gd_hd.dcID);
            if (v_dt.Rows.Count != 0)
            {
                DateTime v_ngay_ket_thuc_lns = Convert.ToDateTime(v_dt.Rows[0]["NGAY_KET_THUC"]);
                if (m_dat_ngay_ket_thuc.DateTime < v_ngay_ket_thuc_lns)
                    return true;
            }
            return false;
        }

        private bool check_gd_lcd()
        {
            US_GD_LUONG_CHE_DO v_us = new US_GD_LUONG_CHE_DO();
            DataTable v_dt = v_us.GetLCDTheoHopDong(m_us_gd_hd.dcID);
            if (v_dt.Rows.Count != 0)
            {
                DateTime v_ngay_ket_thuc_lns = Convert.ToDateTime(v_dt.Rows[0]["NGAY_KET_THUC"]);
                if (m_dat_ngay_ket_thuc.DateTime < v_ngay_ket_thuc_lns)
                    return true;
            }
            return false;
        }

        private void them_hop_dong()
        {
            decimal v_id_hop_dong = get_id_hop_dong_hien_tai(m_sle_chon_nhan_vien.EditValue.ToString());
            if (v_id_hop_dong != 0)
            {
                string v_str_confirm = "Nhân viên hiện đã có hợp đồng.\nBạn có chắc chắn muốn kết thúc hợp đồng cũ và thêm mới hợp đồng vừa nhập?";
                DialogResult v_dialog = XtraMessageBox.Show(v_str_confirm, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (v_dialog == DialogResult.No)
                    return;
                ket_thuc_hop_dong_cu(v_id_hop_dong);
            }
            cap_nhat_gd_hop_dong();
            XtraMessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void cap_nhat_gd_hop_dong()
        {
            form_to_us_hd();
            switch (m_e_form_mode)
            {
                case DataEntryFormMode.InsertDataState:
                    m_us_gd_hd.Insert();
                    break;
                case DataEntryFormMode.UpdateDataState:
                    m_us_gd_hd.Update();
                    break;
                default:
                    break;
            }
        }

        private void form_to_us_hd()
        {
            m_us_gd_hd.dcID_NHAN_VIEN = decimal.Parse(m_sle_chon_nhan_vien.EditValue.ToString());
            m_us_gd_hd.dcID_LOAI_HOP_DONG = decimal.Parse(m_sle_loai_hop_dong.EditValue.ToString());
            m_us_gd_hd.strMA_HOP_DONG = m_txt_ma_hd.Text;
            m_us_gd_hd.datNGAY_BAT_DAU = m_dat_ngay_bat_dau.DateTime;
            m_us_gd_hd.datNGAY_KET_THUC = m_dat_ngay_ket_thuc.DateTime;
            m_us_gd_hd.datNGAY_KY_HOP_DONG = m_dat_ngay_ky.DateTime;
            m_us_gd_hd.strGHI_CHU = m_txt_ghi_chu.Text;
            var v_dr = get_luong_ns_theo_ma_muc();
            if (v_dr == null)
                m_us_gd_hd.SetID_HE_SO_LNSNull();
            else m_us_gd_hd.dcID_HE_SO_LNS = Convert.ToDecimal(v_dr["ID"]);
            v_dr = get_luong_cd_theo_ma_muc();
            if (v_dr == null)
                m_us_gd_hd.SetID_LCDNull();
            else m_us_gd_hd.dcID_LCD = Convert.ToDecimal(v_dr["ID"]);
            if (m_e_form_mode== DataEntryFormMode.InsertDataState)
            {
                m_us_gd_hd.datNGAY_LAP = DateTime.Now;
                m_us_gd_hd.strNGUOI_LAP = CAppContext_201.getCurrentUserName();
            }
            else if (m_e_form_mode== DataEntryFormMode.UpdateDataState)
            {
                m_us_gd_hd.datNGAY_SUA = DateTime.Now;
                m_us_gd_hd.strNGUOI_SUA = CAppContext_201.getCurrentUserName();
            }
        }
        #endregion

        #region Event Handler

        private void set_defines_event()
        {           
            m_cmd_save.Click += m_cmd_save_Click;
            m_sle_chuc_danh_lns.EditValueChanged += m_sle_chuc_danh_lns_EditValueChanged;
            m_sle_muc_lns.EditValueChanged += m_sle_muc_lns_EditValueChanged;
            m_sle_chuc_danh_lcd.EditValueChanged += m_sle_chuc_danh_lcd_EditValueChanged;
            m_sle_muc_lcd.EditValueChanged += m_sle_muc_lcd_EditValueChanged;
        }

        void m_sle_muc_lcd_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (m_sle_chuc_danh_lcd.EditValue != null)
                    load_data_to_lbl_so_tien_lcd();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_sle_chuc_danh_lcd_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (m_sle_muc_lcd.EditValue != null)
                    load_data_to_lbl_so_tien_lcd();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_sle_muc_lns_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (m_sle_chuc_danh_lns.EditValue != null)
                    load_data_to_lbl_he_so_lns();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
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
                string v_str_confirm = "Bạn có chắc chắn muốn lưu thông tin hợp đồng như trên?";
                DialogResult v_dialog = XtraMessageBox.Show(v_str_confirm, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (v_dialog == DialogResult.Yes)
                {
                    if (check_du_lieu_hop_le())
                    {
                        switch (m_e_form_mode)
                        {
                            case DataEntryFormMode.InsertDataState:
                                them_hop_dong();
                                break;
                            case DataEntryFormMode.UpdateDataState:
                                sua_hop_dong();
                                break;
                            default:
                                break;
                        }
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
