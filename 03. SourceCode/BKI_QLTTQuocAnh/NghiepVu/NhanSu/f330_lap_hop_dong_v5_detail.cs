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
using BKI_DichVuMatDat.COMMON;

namespace BKI_DichVuMatDat.NghiepVu.NhanSu
{
    public partial class f330_lap_hop_dong_v5_detail : Form
    {
        #region Public Interface
        public f330_lap_hop_dong_v5_detail()
        {
            InitializeComponent();
            set_initial_form_load();
        }
        public decimal display_for_insert()
        {
            Text = "F330 - Thêm mới hợp đồng";
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            this.ShowDialog();
            return m_us_gd_hd.dcID;
        }
        public void display_for_update(DataRow v_dr)
        {
            Text = "F330 - Cập nhật hợp đồng";
            US_GD_HOP_DONG v_us = new US_GD_HOP_DONG(CIPConvert.ToDecimal(v_dr[GD_HOP_DONG.ID]));
            m_us_gd_hd = v_us;
            m_sle_chon_nhan_vien.Enabled = false;
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            us_to_form(v_dr);
            m_sle_chon_nhan_vien.Enabled = false;
            this.ShowDialog();
        }
        #endregion

        #region Members
        DataEntryFormMode m_e_form_mode;
        US_GD_HOP_DONG m_us_gd_hd = new US_GD_HOP_DONG();
        #endregion

        #region Private Method
        private void set_initial_form_load()
        {
            //m_dat_ngay_bat_dau.DateTime = DateTime.Now.Date;
            //m_dat_ngay_ky.DateTime = DateTime.Now.Date;
            load_data_to_sle_nhan_vien();
            load_data_to_sle_loai_hop_dong();
            load_data_to_sle_loai_lao_dong();
            load_data_to_sle_don_vi();
            m_sle_don_vi.EditValueChanged += m_sle_don_vi_EditValueChanged;
            load_data_to_sle_ma_lcd();
            load_data_to_sle_muc_lcd();
            load_data_to_mo_ta_cv();
            set_defines_event();
        }

        private void us_to_form(DataRow v_dr)
        {
            m_sle_chon_nhan_vien.EditValue = Convert.ToDecimal(v_dr[V_GD_HOP_DONG_V3.ID_NHAN_VIEN]);
            m_sle_loai_hop_dong.EditValue = Convert.ToDecimal(v_dr[V_GD_HOP_DONG_V3.ID_LOAI_HOP_DONG]);
            m_sle_loai_lao_dong.EditValue = Convert.ToDecimal(v_dr[V_GD_HOP_DONG_V3.ID_LOAI_LAO_DONG]);
            m_txt_ma_hd.Text = v_dr[V_GD_HOP_DONG_V3.MA_HOP_DONG].ToString();
            if(v_dr[V_GD_HOP_DONG_V3.NGAY_KY_HOP_DONG] != DBNull.Value)
            {
                m_dat_ngay_ky.EditValue = Convert.ToDateTime(v_dr[V_GD_HOP_DONG_V3.NGAY_KY_HOP_DONG]);
            }
            else
            {
                m_dat_ngay_ky.EditValue = null;
            }

            m_dat_ngay_bat_dau.DateTime = Convert.ToDateTime(v_dr[V_GD_HOP_DONG_V3.NGAY_BAT_DAU]);
            if(v_dr[V_GD_HOP_DONG_V3.NGAY_KET_THUC] != DBNull.Value)
            {
                m_dat_ngay_ket_thuc.DateTime = Convert.ToDateTime(v_dr[V_GD_HOP_DONG_V3.NGAY_KET_THUC]);
            }
            else
            {
                m_dat_ngay_ket_thuc.EditValue = null;
            }
            if(v_dr[V_GD_HOP_DONG_V3.ID_DON_VI] != DBNull.Value)
            {
                m_sle_don_vi.EditValue = Convert.ToDecimal(v_dr[V_GD_HOP_DONG_V3.ID_DON_VI]);
            }
            if(v_dr[V_GD_HOP_DONG_V3.ID_CHUC_VU] != DBNull.Value)
            {
                m_sle_chuc_vu.EditValue = Convert.ToDecimal(v_dr[V_GD_HOP_DONG_V3.ID_CHUC_VU]);
            }
            m_sle_mo_ta_cv.Properties.ForceInitialize();

            //m_sle_mo_ta_cv.Text = v_dr["GHI_CHU"].ToString();
            m_sle_mo_ta_cv.EditValue = m_sle_mo_ta_cv.Properties.GetKeyValueByDisplayText(v_dr["GHI_CHU"].ToString());
            if(v_dr[V_GD_HOP_DONG_V3.ID_LUONG_CHE_DO] != DBNull.Value)
            {
                m_sle_ma_lcd.EditValue = Convert.ToDecimal(v_dr[V_GD_HOP_DONG_V3.ID_MA_LCD]);
                m_sle_muc_lcd.EditValue = Convert.ToDecimal(v_dr[V_GD_HOP_DONG_V3.ID_MUC_LCD]);
            }
            m_txt_so_tien_lcd.EditValue = v_dr["SO_TIEN_LCD_THUC_TE"];
        }
        private void dr_hop_dong_cuoi_to_form(DataRow v_dr)
        {
            //m_sle_chon_nhan_vien.EditValue = Convert.ToDecimal(v_dr[V_GD_HOP_DONG_V3.ID_NHAN_VIEN]);
            m_sle_loai_hop_dong.EditValue = Convert.ToDecimal(v_dr[V_GD_HOP_DONG_V3.ID_LOAI_HOP_DONG]);
            m_sle_loai_lao_dong.EditValue = Convert.ToDecimal(v_dr[V_GD_HOP_DONG_V3.ID_LOAI_LAO_DONG]);
            //m_txt_ma_hd.Text = v_dr[V_GD_HOP_DONG_V3.MA_HOP_DONG].ToString();
            //if(v_dr[V_GD_HOP_DONG_V3.NGAY_KY_HOP_DONG] != DBNull.Value)
            //{
            //    m_dat_ngay_ky.EditValue = Convert.ToDateTime(v_dr[V_GD_HOP_DONG_V3.NGAY_KY_HOP_DONG]);
            //}
            //else
            //{
            //    m_dat_ngay_ky.EditValue = null;
            //}

            //m_dat_ngay_bat_dau.DateTime = Convert.ToDateTime(v_dr[V_GD_HOP_DONG_V3.NGAY_BAT_DAU]);
            //if(v_dr[V_GD_HOP_DONG_V3.NGAY_KET_THUC] != DBNull.Value)
            //{
            //    m_dat_ngay_ket_thuc.DateTime = Convert.ToDateTime(v_dr[V_GD_HOP_DONG_V3.NGAY_KET_THUC]);
            //}
            //else
            //{
            //    m_dat_ngay_ket_thuc.EditValue = null;
            //}
            if(v_dr[V_GD_HOP_DONG_V3.ID_DON_VI] != DBNull.Value)
            {
                m_sle_don_vi.EditValue = Convert.ToDecimal(v_dr[V_GD_HOP_DONG_V3.ID_DON_VI]);
            }
            if(v_dr[V_GD_HOP_DONG_V3.ID_CHUC_VU] != DBNull.Value)
            {
                m_sle_chuc_vu.EditValue = Convert.ToDecimal(v_dr[V_GD_HOP_DONG_V3.ID_CHUC_VU]);
            }

            m_sle_mo_ta_cv.Text = v_dr[V_GD_HOP_DONG_V3.GHI_CHU].ToString();
            if(v_dr[V_GD_HOP_DONG_V3.ID_LUONG_CHE_DO] != DBNull.Value)
            {
                m_sle_ma_lcd.EditValue = Convert.ToDecimal(v_dr[V_GD_HOP_DONG_V3.ID_MA_LCD]);
                m_sle_muc_lcd.EditValue = Convert.ToDecimal(v_dr[V_GD_HOP_DONG_V3.ID_MUC_LCD]);
            }
            m_txt_so_tien_lcd.EditValue = v_dr["SO_TIEN_LCD_THUC_TE"];
        }
        //Load data
        private void load_data_to_sle_nhan_vien()
        {
            US_DM_NHAN_VIEN v_us = new US_DM_NHAN_VIEN();
            DS_DM_NHAN_VIEN v_ds = new DS_DM_NHAN_VIEN();
            m_sle_chon_nhan_vien.Properties.DataSource = v_us.LayDanhSachNhanVien();
            m_sle_chon_nhan_vien.Properties.DisplayMember = V_DM_NHAN_VIEN.HO_TEN;
            m_sle_chon_nhan_vien.Properties.ValueMember = V_DM_NHAN_VIEN.ID;

            // m_sle_chon_nhan_vien.Properties.DataSource = v_ds.Tables[0];
            //m_sle_chon_nhan_vien.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            //m_sle_chon_nhan_vien.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
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
        private void load_data_to_sle_loai_lao_dong()
        {
            US_CM_DM_TU_DIEN v_us = new US_CM_DM_TU_DIEN();
            DS_CM_DM_TU_DIEN v_ds = new DS_CM_DM_TU_DIEN();
            v_us.FillDatasetByIdLoaiTuDien(v_ds, 6);
            m_sle_loai_lao_dong.Properties.DataSource = v_ds.Tables[0];
            m_sle_loai_lao_dong.Properties.DisplayMember = CM_DM_TU_DIEN.TEN;
            m_sle_loai_lao_dong.Properties.ValueMember = CM_DM_TU_DIEN.ID;
            //m_sle_loai_lao_dong.Properties.NullText = "---Chọn loại lao động---";
        }
        private void load_data_to_sle_don_vi()
        {
            US_DM_DON_VI v_us = new US_DM_DON_VI();
            DS_DM_DON_VI v_ds = new DS_DM_DON_VI();
            v_us.FillDataset(v_ds);
            m_sle_don_vi.Properties.DataSource = v_ds.Tables[0];
            m_sle_don_vi.Properties.DisplayMember = DM_DON_VI.TEN_DON_VI;
            m_sle_don_vi.Properties.ValueMember = DM_DON_VI.ID;
            //m_sle_don_vi.Properties.NullText = "---Chọn đơn vị---";
        }
        private void load_data_to_sle_chuc_vu()
        {
            US_DM_CHUC_VU v_us = new US_DM_CHUC_VU();
            DS_DM_CHUC_VU v_ds = new DS_DM_CHUC_VU();
            v_us.FillDataset(v_ds, " where id_don_vi = " + Convert.ToDecimal(m_sle_don_vi.EditValue));
            m_sle_chuc_vu.Properties.DataSource = v_ds.Tables[0];
            m_sle_chuc_vu.Properties.DisplayMember = DM_CHUC_VU.TEN_CHUC_VU;
            m_sle_chuc_vu.Properties.ValueMember = DM_CHUC_VU.ID;
            //m_sle_chuc_vu.Properties.NullText = "---Chọn chức vụ---";
            m_sle_chuc_vu.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            m_sle_chuc_vu.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
        }
        private void load_data_to_sle_ma_lcd()
        {
            US_CM_DM_TU_DIEN v_us = new US_CM_DM_TU_DIEN();
            DS_CM_DM_TU_DIEN v_ds = new DS_CM_DM_TU_DIEN();
            v_us.FillDatasetByIdLoaiTuDien(v_ds, 3);
            m_sle_ma_lcd.Properties.DataSource = v_ds.Tables[0];
            m_sle_ma_lcd.Properties.DisplayMember = CM_DM_TU_DIEN.TEN;
            m_sle_ma_lcd.Properties.ValueMember = CM_DM_TU_DIEN.ID;
            //m_sle_chuc_danh_lns.EditValue = null;
            //m_sle_ma_lcd.Properties.NullText = "--Chọn mã--";
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
            //m_sle_muc_lcd.Properties.NullText = "--Chọn mức--";
        }
        private void load_data_to_lbl_so_tien_lcd()
        {
            DataRow v_dr = get_luong_cd_theo_ma_muc();
            if(v_dr == null)
            {
                XtraMessageBox.Show("Mã mức chưa được định nghĩa số tiền", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            else m_txt_so_tien_lcd.EditValue = v_dr["SO_TIEN"];
        }
        private void load_data_to_mo_ta_cv()
        {
            US_CM_DM_TU_DIEN v_us = new US_CM_DM_TU_DIEN();
            DS_CM_DM_TU_DIEN v_ds = new DS_CM_DM_TU_DIEN();
            v_us.FillDatasetByIdLoaiTuDien(v_ds, CONST_ID_LOAI_TU_DIEN.MO_TA_CONG_VIEC);
            m_sle_mo_ta_cv.Properties.DataSource = v_ds.Tables[0];
            m_sle_mo_ta_cv.Properties.DisplayMember = CM_DM_TU_DIEN.TEN;
            m_sle_mo_ta_cv.Properties.ValueMember = CM_DM_TU_DIEN.ID;
        }
        private DataRow get_luong_cd_theo_ma_muc()
        {
            US_DM_LUONG_CHE_DO v_us = new US_DM_LUONG_CHE_DO();
            DS_DM_LUONG_CHE_DO v_ds = new DS_DM_LUONG_CHE_DO();
            if(m_sle_ma_lcd.EditValue == null || m_sle_muc_lcd.EditValue == null)
            {
                return null;
            }
            v_us.FillDatasetTheoIDMaMuc(v_ds, m_sle_ma_lcd.EditValue.ToString(), m_sle_muc_lcd.EditValue.ToString());
            if(v_ds.Tables[0].Rows.Count == 0)
                return null;
            else return v_ds.Tables[0].Rows[0];
        }

        //
        private DateTime? default_ngay_ket_thuc()
        {
            if(m_sle_loai_hop_dong.EditValue == null)
            {
                return null;
            }

            decimal v_dc_id_loai_hop_dong = Convert.ToDecimal(m_sle_loai_hop_dong.EditValue);
            DateTime? v_dat_ngay_ket_thuc = null;
            if(v_dc_id_loai_hop_dong == CONST_ID_LOAI_HOP_DONG.HOP_DONG_1N_2016)
            {
                v_dat_ngay_ket_thuc = m_dat_ngay_bat_dau.DateTime.Date.AddYears(1).Date;
            }
            if(v_dc_id_loai_hop_dong == CONST_ID_LOAI_HOP_DONG.HOP_DONG_3_NAM)
            {
                v_dat_ngay_ket_thuc = m_dat_ngay_bat_dau.DateTime.Date.AddYears(3).Date;
            }
            if(v_dc_id_loai_hop_dong == CONST_ID_LOAI_HOP_DONG.HOP_DONG_HOC_VIEC)
            {
                v_dat_ngay_ket_thuc = null;
            }
            if(v_dc_id_loai_hop_dong == CONST_ID_LOAI_HOP_DONG.HOP_DONG_KHONG_XAC_DINH)
            {
                v_dat_ngay_ket_thuc = null;
            }
            if(v_dc_id_loai_hop_dong == CONST_ID_LOAI_HOP_DONG.HOP_DONG_MOT_NAM)
            {
                v_dat_ngay_ket_thuc = m_dat_ngay_bat_dau.DateTime.Date.AddYears(1).Date;
            }
            if(v_dc_id_loai_hop_dong == CONST_ID_LOAI_HOP_DONG.HOP_DONG_THU_VIEC)
            {
                v_dat_ngay_ket_thuc = m_dat_ngay_bat_dau.DateTime.Date.AddMonths(1).Date;
            }

            return v_dat_ngay_ket_thuc;
        }


        //Check routines
        private bool check_hop_le()
        {
            if(!check_client() || !check_logic())
            {
                return false;
            }
            return true;
        }
        private bool check_client()
        {
            if(m_sle_chon_nhan_vien.EditValue == null)
            {
                string v_str_error = "Bạn chưa chọn nhân viên!";
                XtraMessageBox.Show(v_str_error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(m_sle_loai_hop_dong.EditValue == null)
            {
                string v_str_error = "Bạn chưa chọn loại hợp đồng!";
                XtraMessageBox.Show(v_str_error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            //if(m_txt_ma_hd.Text.Trim() == "")
            //{
            //    string v_str_error = "Bạn chưa nhập mã hợp đồng!";
            //    XtraMessageBox.Show(v_str_error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return false;
            //}
            if(m_sle_loai_lao_dong.EditValue == null)
            {
                string v_str_error = "Bạn chưa chọn loại lao động!";
                XtraMessageBox.Show(v_str_error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(m_dat_ngay_bat_dau.EditValue == null)
            {
                string v_str_error = "Bạn chưa nhập ngày bắt đầu!";
                XtraMessageBox.Show(v_str_error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(m_sle_don_vi.EditValue == null)
            {
                string v_str_error = "Bạn chưa chọn đơn vị!";
                XtraMessageBox.Show(v_str_error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(m_sle_chuc_vu.EditValue == null)
            {
                string v_str_error = "Bạn chưa chọn chức vụ!";
                XtraMessageBox.Show(v_str_error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            //if(m_txt_so_tien_lcd.EditValue == null)
            //{
            //    string v_str_error = "Bạn chưa nhập số tiền LCĐ!";
            //    XtraMessageBox.Show(v_str_error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return false;
            //}
            if(m_dat_ngay_ket_thuc.DateTime.Date != DateTime.MinValue.Date && m_dat_ngay_bat_dau.DateTime.Date >= m_dat_ngay_ket_thuc.DateTime.Date)
            {
                string v_str_error = "Ngày bắt đầu phải nhỏ hơn ngày kết thúc";
                XtraMessageBox.Show(v_str_error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        private bool check_logic()
        {
            if(check_ma_hd_da_ton_tai(m_txt_ma_hd.Text))
            {
                string v_str_error = "Mã hợp đồng đã tồn tại!";
                XtraMessageBox.Show(v_str_error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(m_e_form_mode == DataEntryFormMode.InsertDataState && !check_thoi_gian_hop_dong_Insert())
            {
                string v_str_error = "Đã có hợp đồng tồn tại trong khoảng thời gian này!";
                XtraMessageBox.Show(v_str_error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(m_e_form_mode == DataEntryFormMode.UpdateDataState && !check_thoi_gian_hop_dong_Update())
            {
                string v_str_error = "Đã có hợp đồng tồn tại trong khoảng thời gian này!";
                XtraMessageBox.Show(v_str_error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private bool check_thoi_gian_hop_dong_Insert()
        {
            //Hợp đồng hợp lệ khi trong một khoảng thời gian chỉ có một hợp đồng 
            US_GD_HOP_DONG v_us = new US_GD_HOP_DONG();
            DateTime v_dat_den_ngay = m_dat_ngay_ket_thuc.EditValue == null ? new DateTime(2100, 01, 01).Date : m_dat_ngay_ket_thuc.DateTime.Date;
            return v_us.KiemTraThoiGianHopDongHopLeForInsert(Convert.ToDecimal(m_sle_chon_nhan_vien.EditValue), m_dat_ngay_bat_dau.DateTime.Date, v_dat_den_ngay);
        }
        private bool check_thoi_gian_hop_dong_Update()
        {
            //Hợp đồng hợp lệ khi trong một khoảng thời gian chỉ có một hợp đồng 
            US_GD_HOP_DONG v_us = new US_GD_HOP_DONG();
            DateTime v_dat_den_ngay = m_dat_ngay_ket_thuc.EditValue == null ? new DateTime(2100, 01, 01).Date : m_dat_ngay_ket_thuc.DateTime.Date;
            return v_us.KiemTraThoiGianHopDongHopLeForUpdate(m_us_gd_hd.dcID, m_dat_ngay_bat_dau.DateTime.Date, v_dat_den_ngay);
        }
        private bool check_ma_hd_da_ton_tai(string ip_str_ma_hd)
        {
            if(m_us_gd_hd.strMA_HOP_DONG != ip_str_ma_hd)
            {
                US_GD_HOP_DONG v_us = new US_GD_HOP_DONG();
                DS_GD_HOP_DONG v_ds = new DS_GD_HOP_DONG();
                v_us.FillDataset(v_ds, "where MA_HOP_DONG = '" + ip_str_ma_hd + "'");
                if(v_ds.Tables[0].Rows.Count != 0)
                    return true;
            }
            return false;
        }

        private DataRow get_don_vi_hien_tai(decimal v_id_nhan_vien)
        {
            US_GD_CONG_TAC v_us = new US_GD_CONG_TAC();
            DS_GD_CONG_TAC v_ds = new DS_GD_CONG_TAC();
            v_us.FillDatasetDonViHienTai(v_ds, v_id_nhan_vien);
            if(v_ds.Tables[0].Rows.Count == 0)
                return null;
            else return v_ds.Tables[0].Rows[0];
        }

        private void form_to_us_hd()
        {
            m_us_gd_hd.dcID_NHAN_VIEN = Convert.ToDecimal(m_sle_chon_nhan_vien.EditValue);
            m_us_gd_hd.dcID_LOAI_HOP_DONG = Convert.ToDecimal(m_sle_loai_hop_dong.EditValue);
            m_us_gd_hd.dcID_LOAI_LAO_DONG = Convert.ToDecimal(m_sle_loai_lao_dong.EditValue);
            m_us_gd_hd.strMA_HOP_DONG = m_txt_ma_hd.Text;
            m_us_gd_hd.datNGAY_BAT_DAU = m_dat_ngay_bat_dau.DateTime.Date;
            if(m_dat_ngay_ky.EditValue == null)
            {
                m_us_gd_hd.SetNGAY_KY_HOP_DONGNull();
            }
            else
            {
                m_us_gd_hd.datNGAY_KY_HOP_DONG = m_dat_ngay_ky.DateTime.Date;
            }
            if(m_dat_ngay_ket_thuc.DateTime != DateTime.MinValue)
                m_us_gd_hd.datNGAY_KET_THUC = m_dat_ngay_ket_thuc.DateTime.Date;
            else
            {
                m_us_gd_hd.SetNGAY_KET_THUCNull();
            }
            if(get_luong_cd_theo_ma_muc() != null)
            {
                m_us_gd_hd.dcID_LUONG_CHE_DO = Convert.ToDecimal(get_luong_cd_theo_ma_muc()["ID"]);
                m_us_gd_hd.dcSO_TIEN_LCD = Convert.ToDecimal(m_txt_so_tien_lcd.EditValue);
            }
            else
            {
                m_us_gd_hd.SetID_LUONG_CHE_DONull();
                m_us_gd_hd.dcSO_TIEN_LCD = Convert.ToDecimal(m_txt_so_tien_lcd.EditValue);
            }
            m_us_gd_hd.dcID_DON_VI = Convert.ToDecimal(m_sle_don_vi.EditValue);
            m_us_gd_hd.dcID_CHUC_VU = Convert.ToDecimal(m_sle_chuc_vu.EditValue);
            m_us_gd_hd.strGHI_CHU = m_sle_mo_ta_cv.Text;
            if(m_e_form_mode == DataEntryFormMode.InsertDataState)
            {
                m_us_gd_hd.datNGAY_LAP = DateTime.Now.Date;
                m_us_gd_hd.strNGUOI_LAP = CAppContext_201.getCurrentUserName();
            }
            else if(m_e_form_mode == DataEntryFormMode.UpdateDataState)
            {
                m_us_gd_hd.datNGAY_SUA = DateTime.Now.Date;
                m_us_gd_hd.strNGUOI_SUA = CAppContext_201.getCurrentUserName();
            }
        }

        private void save_data()
        {
            if(check_hop_le())
            {
                form_to_us_hd();
                switch(m_e_form_mode)
                {
                    case DataEntryFormMode.InsertDataState:
                        m_us_gd_hd.BeginTransaction();
                        m_us_gd_hd.Insert();

                        //var v_dlg = XtraMessageBox.Show("Thêm hợp đồng mới thành công.\nBạn có muốn cập nhật công tác cho nhân viên này?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        //if(v_dlg == System.Windows.Forms.DialogResult.Yes)
                        //{
                        //    f309_quan_ly_cong_tac v_frm = new f309_quan_ly_cong_tac();
                        //    v_frm.display_after_insert_hop_dong(ExecuteFuntion.LayMaNhanVien(m_us_gd_hd.dcID_NHAN_VIEN));
                        //}
                        if(!ExecuteFuntion.KiemTraNhanVienCoCongTac(m_us_gd_hd.dcID_NHAN_VIEN))
                        {
                            XtraMessageBox.Show("Nhân viên chưa có công tác, hệ thống sẽ tự động cập nhật công tác theo hợp đồng!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            US_GD_CONG_TAC v_us = new US_GD_CONG_TAC();
                            v_us.dcID_DON_VI = m_us_gd_hd.dcID_DON_VI;
                            v_us.dcID_LOAI_CONG_TAC = CONST_ID_LOAI_CONG_TAC.CHINH_THUC;
                            v_us.dcID_NHAN_VIEN = m_us_gd_hd.dcID_NHAN_VIEN;
                            v_us.dcID_VI_TRI = m_us_gd_hd.dcID_CHUC_VU;
                            v_us.dcSO_HO_SO = ExecuteFuntion.GetSoHoSoNext(m_us_gd_hd.dcID_DON_VI, m_us_gd_hd.dcID_CHUC_VU, m_us_gd_hd.dcID_NHAN_VIEN);
                            v_us.strDA_XOA = "N";
                            v_us.strNGUOI_LAP = CAppContext_201.getCurrentUserName();
                            v_us.datNGAY_LAP = DateTime.Now.Date;
                            v_us.datNGAY_BAT_DAU = m_us_gd_hd.datNGAY_BAT_DAU;
                            v_us.UseTransOfUSObject(m_us_gd_hd);
                            v_us.Insert();
                        }
                        m_us_gd_hd.CommitTransaction();
                        XtraMessageBox.Show("Thêm hợp đồng mới thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case DataEntryFormMode.UpdateDataState:
                        m_us_gd_hd.Update();
                        //var v_dlg_update = XtraMessageBox.Show("Sửa hợp đồng thành công.\nBạn có muốn cập nhật công tác cho nhân viên này?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        //if(v_dlg_update == System.Windows.Forms.DialogResult.Yes)
                        //{
                        //    f309_quan_ly_cong_tac v_frm = new f309_quan_ly_cong_tac();
                        //    v_frm.display_after_insert_hop_dong(ExecuteFuntion.LayMaNhanVien(m_us_gd_hd.dcID_NHAN_VIEN));
                        //}
                        XtraMessageBox.Show("Sửa hợp đồng thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    default:
                        break;
                }
                Close();
            }
        }
        #endregion


        //Event Handler

        private void set_defines_event()
        {
            m_cmd_save.Click += m_cmd_save_Click;
            m_sle_ma_lcd.EditValueChanged += m_sle_ma_lcd_EditValueChanged;
            m_sle_muc_lcd.EditValueChanged += m_sle_muc_lcd_EditValueChanged;
            m_dat_ngay_bat_dau.EditValueChanged += m_dat_ngay_bat_dau_EditValueChanged;
            m_sle_chon_nhan_vien.CustomDisplayText += m_sle_chon_nhan_vien_CustomDisplayText;
            m_sle_loai_hop_dong.EditValueChanged += m_sle_loai_hop_dong_EditValueChanged;
            m_sle_chon_nhan_vien.EditValueChanged += m_sle_chon_nhan_vien_EditValueChanged;
        }

        void m_sle_chon_nhan_vien_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if(m_e_form_mode != DataEntryFormMode.InsertDataState)
                {
                    return;
                }
                if(m_sle_chon_nhan_vien.EditValue == null)
                {
                    return;
                }
                US_GD_HOP_DONG v_us_hd = new US_GD_HOP_DONG();
                DataRow v_dr_hd_cuoi = v_us_hd.LayHopDongCuoiCungNhanVien(Convert.ToDecimal(m_sle_chon_nhan_vien.EditValue));
                if(v_dr_hd_cuoi != null)
                {
                    var v_dlg_confirm = XtraMessageBox.Show("Nhân viên đã có hợp đồng rồi. Bạn có muốn sử dụng dữ liệu của hợp đồng gần đây nhất để thêm mới hợp đồng cho nhân viên này?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(v_dlg_confirm == System.Windows.Forms.DialogResult.Yes)
                    {
                        dr_hop_dong_cuoi_to_form(v_dr_hd_cuoi);
                        if(m_sle_mo_ta_cv.IsPopupOpen)
                        {
                            m_sle_mo_ta_cv.ClosePopup();
                        }

                        m_sle_chon_nhan_vien.Focus();
                    }
                }
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_sle_loai_hop_dong_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if(m_dat_ngay_bat_dau.EditValue != null)
                {
                    m_dat_ngay_ket_thuc.EditValue = default_ngay_ket_thuc();
                }
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_sle_chon_nhan_vien_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            try
            {
                var v_sle = sender as SearchLookUpEdit;
                if(v_sle.EditValue == null)
                {
                    return;
                }
                var x = (DataTable)v_sle.Properties.DataSource;
                var y = x.Rows[v_sle.Properties.GetIndexByKeyValue(v_sle.EditValue)][DM_NHAN_VIEN.MA_NV];
                e.DisplayText = y + " - " + e.DisplayText;
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_dat_ngay_bat_dau_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                m_dat_ngay_ket_thuc.EditValue = default_ngay_ket_thuc();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_sle_don_vi_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                load_data_to_sle_chuc_vu();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_sle_ma_lcd_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                m_txt_so_tien_lcd.EditValue = 0;
                if(m_sle_muc_lcd.EditValue != null && m_sle_ma_lcd.EditValue != null)
                {
                    //m_txt_so_tien_lcd.ResetText();
                    load_data_to_lbl_so_tien_lcd();
                }
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_sle_muc_lcd_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                m_txt_so_tien_lcd.EditValue = 0;
                if(m_sle_ma_lcd.EditValue != null && m_sle_muc_lcd.EditValue != null)
                {
                    //m_txt_so_tien_lcd.ResetText();
                    load_data_to_lbl_so_tien_lcd();
                }

            }
            catch(Exception v_e)
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
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
    }
}
