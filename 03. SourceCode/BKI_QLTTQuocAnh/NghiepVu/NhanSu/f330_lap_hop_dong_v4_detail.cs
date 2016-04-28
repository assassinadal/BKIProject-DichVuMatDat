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
    public partial class f330_lap_hop_dong_v4_detail : Form
    {
        #region Public Interface
        public f330_lap_hop_dong_v4_detail()
        {
            InitializeComponent();
            set_initial_form_load();
        }
        public void display_for_insert()
        {
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            this.ShowDialog();
        }
        public void display_for_update(DataRow v_dr)
        {
            US_GD_HOP_DONG v_us = new US_GD_HOP_DONG(CIPConvert.ToDecimal(v_dr[GD_HOP_DONG.ID]));
            m_us_gd_hd = v_us;
            layoutControlGroup5.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            m_sle_ma_lns.Enabled = false;
            m_sle_muc_lns.Enabled = false;
            m_txt_he_so_lns.Enabled = false;
            m_sle_chon_nhan_vien.Enabled = false;
            m_sle_loai_hop_dong.Enabled = false;
            m_txt_ma_hd.Enabled = false;
            m_sle_loai_lao_dong.Enabled = false;
            m_sle_don_vi.Enabled = false;
            m_sle_chuc_vu.Enabled = false;
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            us_to_form(v_dr);
            m_sle_chon_nhan_vien.Enabled = false;
            this.ShowDialog();
        }
        internal void display_for_insert(decimal id_nv)
        {
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            m_sle_chon_nhan_vien.EditValue = id_nv;
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
            m_dat_ngay_bat_dau.DateTime = DateTime.Now.Date;
            m_dat_ngay_ky.DateTime = DateTime.Now.Date;
            load_data_to_sle_nhan_vien();
            load_data_to_sle_loai_hop_dong();
            load_data_to_sle_loai_lao_dong();
            load_data_to_sle_don_vi();
            m_sle_don_vi.EditValueChanged += m_sle_don_vi_EditValueChanged;
            load_data_to_sle_ma_lcd();
            load_data_to_sle_muc_lcd();
            load_data_to_sle_ma_lns();
            load_data_to_sle_muc_lns();
            set_defines_event();
        }

        private void load_data_to_sle_muc_lns()
        {
            US_CM_DM_TU_DIEN v_us = new US_CM_DM_TU_DIEN();
            DS_CM_DM_TU_DIEN v_ds = new DS_CM_DM_TU_DIEN();
            v_us.FillDatasetByIdLoaiTuDien(v_ds, 2);
            m_sle_muc_lns.Properties.DataSource = v_ds.Tables[0];
            m_sle_muc_lns.Properties.DisplayMember = CM_DM_TU_DIEN.TEN;
            m_sle_muc_lns.Properties.ValueMember = CM_DM_TU_DIEN.ID;
        }

        private void load_data_to_sle_ma_lns()
        {
            US_CM_DM_TU_DIEN v_us = new US_CM_DM_TU_DIEN();
            DS_CM_DM_TU_DIEN v_ds = new DS_CM_DM_TU_DIEN();
            v_us.FillDatasetByIdLoaiTuDien(v_ds, 1);
            m_sle_ma_lns.Properties.DataSource = v_ds.Tables[0];
            m_sle_ma_lns.Properties.DisplayMember = CM_DM_TU_DIEN.TEN;
            m_sle_ma_lns.Properties.ValueMember = CM_DM_TU_DIEN.ID;
        }

        private void us_to_form(DataRow v_dr)
        {
            m_sle_chon_nhan_vien.EditValue = Convert.ToDecimal(v_dr[V_GD_HOP_DONG_V3.ID_NHAN_VIEN]);
            m_sle_loai_hop_dong.EditValue = Convert.ToDecimal(v_dr[V_GD_HOP_DONG_V3.ID_LOAI_HOP_DONG]);
            m_sle_loai_lao_dong.EditValue = Convert.ToDecimal(v_dr[V_GD_HOP_DONG_V3.ID_LOAI_LAO_DONG]);
            m_txt_ma_hd.Text = v_dr[V_GD_HOP_DONG_V3.MA_HOP_DONG].ToString();
            m_dat_ngay_ky.DateTime = Convert.ToDateTime(v_dr[V_GD_HOP_DONG_V3.NGAY_KY_HOP_DONG]);
            m_dat_ngay_bat_dau.DateTime = Convert.ToDateTime(v_dr[V_GD_HOP_DONG_V3.NGAY_BAT_DAU]);
            if (v_dr[V_GD_HOP_DONG_V3.NGAY_KET_THUC].ToString() != "")
                m_dat_ngay_ket_thuc.DateTime = Convert.ToDateTime(v_dr[V_GD_HOP_DONG_V3.NGAY_KET_THUC]);
            m_sle_don_vi.EditValue = Convert.ToDecimal(v_dr[V_GD_HOP_DONG_V3.ID_DON_VI]);
            m_sle_chuc_vu.EditValue = Convert.ToDecimal(v_dr[V_GD_HOP_DONG_V3.ID_CHUC_VU]);
            m_txt_mo_ta_cv.Text = v_dr[V_GD_HOP_DONG_V3.GHI_CHU].ToString();
            if (v_dr[V_GD_HOP_DONG_V3.ID_LUONG_CHE_DO].ToString() != "")
            {
                m_sle_ma_lcd.EditValue = Convert.ToDecimal(v_dr[V_GD_HOP_DONG_V3.ID_MA_LCD]);
                m_sle_muc_lcd.EditValue = Convert.ToDecimal(v_dr[V_GD_HOP_DONG_V3.ID_MUC_LCD]);
            }
            m_txt_so_tien_lcd.EditValue = v_dr["SO_TIEN_LCD_THUC_TE"];
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
            if (v_dr == null)
                return;
            else m_txt_so_tien_lcd.EditValue = v_dr["SO_TIEN"];
        }

        private string load_data_to_lbl_he_so_lns()
        {
            if (m_sle_ma_lns.EditValue != null
                && m_sle_muc_lns.EditValue != null)
             {
                US_DM_HE_SO_LUONG_NS v_us = new US_DM_HE_SO_LUONG_NS();
                DS_DM_HE_SO_LUONG_NS v_ds = new DS_DM_HE_SO_LUONG_NS();

                v_us.FillDataset(v_ds);

                string v_str_filter = "ID_MA_LNS = " + m_sle_ma_lns.EditValue + " AND ID_MUC_LNS = " + m_sle_muc_lns.EditValue;
                DataRow[] v_dr = v_ds.DM_HE_SO_LUONG_NS.Select(v_str_filter);

                if (v_dr.Count() == 0)
                {
                    return "";
                }
                else
                {
                    return v_dr.First()["HE_SO"].ToString().ToString();
                }
            }
            else
            {
                return "";
            }
        }

        private DataRow get_luong_cd_theo_ma_muc()
        {
            if (m_sle_ma_lcd.EditValue == null || m_sle_muc_lcd.EditValue == null)
                return null;
            else
            {
                US_DM_LUONG_CHE_DO v_us = new US_DM_LUONG_CHE_DO();
                DS_DM_LUONG_CHE_DO v_ds = new DS_DM_LUONG_CHE_DO();
                v_us.FillDatasetTheoIDMaMuc(v_ds, m_sle_ma_lcd.EditValue.ToString(), m_sle_muc_lcd.EditValue.ToString());
                if (v_ds.Tables[0].Rows.Count == 0)
                    return null;
                else return v_ds.Tables[0].Rows[0];
            }
        }

        private bool check_du_lieu_hop_le()
        {
            if (!check_thong_tin_co_ban())
                return false;
            else if (!check_thong_tin_cong_tac())
                return false;
            else if (!check_thong_tin_luong())
                return false;
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
            else if (m_sle_loai_lao_dong.EditValue == null)
            {
                string v_str_error = "Bạn chưa chọn loại lao động!";
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
            else if (m_dat_ngay_ket_thuc.DateTime.Date != DateTime.MinValue.Date && m_dat_ngay_bat_dau.DateTime.Date > m_dat_ngay_ket_thuc.DateTime.Date)
            {
                string v_str_error = "Ngày bắt đầu đang lớn hơn ngày kết thúc";
                XtraMessageBox.Show(v_str_error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool check_thong_tin_cong_tac()
        {
            if (m_sle_don_vi.EditValue == null)
            {
                string v_str_error = "Bạn chưa chọn đơn vị!";
                XtraMessageBox.Show(v_str_error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (m_sle_chuc_vu.EditValue == null)
            {
                string v_str_error = "Bạn chưa chọn chức vụ!";
                XtraMessageBox.Show(v_str_error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool check_thong_tin_luong()
        {
            if (m_sle_ma_lcd.EditValue != null && m_sle_muc_lcd.EditValue != null && get_luong_cd_theo_ma_muc() == null)
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
            v_us.datNGAY_KET_THUC = m_dat_ngay_bat_dau.DateTime.Date;
            v_us.Update();
        }

        private decimal get_id_hop_dong_hien_tai(string ip_id_nv)
        {
            US_GD_HOP_DONG v_us = new US_GD_HOP_DONG();
            return v_us.GetHopDongHienTaiCuaNV(ip_id_nv);
        }

        private void sua_hop_dong()
        {
            decimal v_id_nhan_vien = CIPConvert.ToDecimal(m_sle_chon_nhan_vien.EditValue);
            var v_dr = get_don_vi_hien_tai(v_id_nhan_vien);
            //if ((m_us_gd_hd.dcID_DON_VI != CIPConvert.ToDecimal(m_sle_don_vi.EditValue) || m_us_gd_hd.dcID_CHUC_VU != CIPConvert.ToDecimal(m_sle_chuc_vu.EditValue)) && v_dr != null)
            //{
            //    string v_str_confirm = "Nhân viên hiện đã có công tác.\nBạn có muốn cập nhật công tác cho nhân viên này?";
            //    DialogResult v_dialog = XtraMessageBox.Show(v_str_confirm, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //    if (v_dialog == DialogResult.Yes)
            //    {
            //        f309_quan_ly_cong_tac v_f = new f309_quan_ly_cong_tac(CIPConvert.ToDecimal(v_dr[GD_CONG_TAC.ID_DON_VI]), v_id_nhan_vien);
            //        v_f.ShowDialog();
            //    }
            //}
            cap_nhat_gd_hop_dong();
            XtraMessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private DataRow get_don_vi_hien_tai(decimal v_id_nhan_vien)
        {
            US_GD_CONG_TAC v_us = new US_GD_CONG_TAC();
            DS_GD_CONG_TAC v_ds = new DS_GD_CONG_TAC();
            v_us.FillDatasetDonViHienTai(v_ds, v_id_nhan_vien);
            if (v_ds.Tables[0].Rows.Count == 0)
                return null;
            else return v_ds.Tables[0].Rows[0];
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
                string v_str_confirm = "Nhân viên hiện đã có hợp đồng đang còn thời gian hiệu lực.\nBạn có muốn chấm dứt hợp đồng hiện tại của nhân viên để thêm mới hợp đồng khác?!";
                DialogResult v_dialog = XtraMessageBox.Show(v_str_confirm, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (v_dialog == System.Windows.Forms.DialogResult.Yes)
                {
                    ket_thuc_hop_dong_cu(v_id_hop_dong);
                }
                else
                {
                    XtraMessageBox.Show("Bạn đã hủy thêm mới hợp đồng!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
            try
            {
                cap_nhat_gd_hop_dong();
                cap_nhat_gd_cong_tac();
                cap_nhat_gd_he_so_lns();
                m_us_gd_hd.CommitTransaction();
            }
            catch (Exception)
            {
                if (m_us_gd_hd.is_having_transaction())
                {
                    m_us_gd_hd.Rollback();
                }
                throw;
            }
            
            XtraMessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void cap_nhat_gd_he_so_lns()
        {
            if(m_txt_he_so_lns.EditValue == null)
            {
                return;
            }
            US_GD_HE_SO_LNS v_us = new US_GD_HE_SO_LNS();
            v_us.dcID_NHAN_VIEN = CIPConvert.ToDecimal(m_sle_chon_nhan_vien.EditValue);
            v_us.datNGAY_BAT_DAU = m_dat_ngay_bat_dau.DateTime.Date;
            if (m_dat_ngay_ket_thuc.EditValue != null)
                v_us.datNGAY_KET_THUC = m_dat_ngay_ket_thuc.DateTime.Date;
            v_us.datNGAY_LAP = DateTime.Now.Date;
            v_us.strNGUOI_LAP = CAppContext_201.getCurrentUserName();
            v_us.dcHE_SO = Convert.ToDecimal(m_txt_he_so_lns.Text);
            v_us.dcID_HE_SO_LNS = find_id_hs_lns();
            v_us.UseTransOfUSObject(m_us_gd_hd);
            v_us.KetThucLuongNangSuatNhanVien(v_us.dcID_NHAN_VIEN, m_dat_ngay_bat_dau.DateTime.Date);
            v_us.Insert();
            //v_us.CommitTransaction();
        }

        private decimal find_id_hs_lns()
        {
            US_DM_HE_SO_LUONG_NS v_us = new US_DM_HE_SO_LUONG_NS();
            DS_DM_HE_SO_LUONG_NS v_ds = new DS_DM_HE_SO_LUONG_NS();

            v_us.FillDataset(v_ds);

            string v_str_filter = "ID_MA_LNS = " + m_sle_ma_lns.EditValue + " AND ID_MUC_LNS = " + m_sle_muc_lns.EditValue;
            DataRow[] v_dr = v_ds.DM_HE_SO_LUONG_NS.Select(v_str_filter);

            if (v_dr.Count() == 0)
            {
                return -1;
            }
            else
            {
                return CIPConvert.ToDecimal(v_dr.First()["ID"].ToString());
            }
        }

        private void cap_nhat_gd_hop_dong()
        {
            form_to_us_hd();
            switch (m_e_form_mode)
            {
                case DataEntryFormMode.InsertDataState:
                    m_us_gd_hd.BeginTransaction();
                    m_us_gd_hd.Insert();
                    break;
                case DataEntryFormMode.UpdateDataState:
                    m_us_gd_hd.Update();
                    break;
                default:
                    break;
            }
        }

        private void cap_nhat_gd_cong_tac()
        {
            US_GD_CONG_TAC v_us = new US_GD_CONG_TAC();
            v_us.dcID_NHAN_VIEN = CIPConvert.ToDecimal(m_sle_chon_nhan_vien.EditValue);
            v_us.dcID_DON_VI = CIPConvert.ToDecimal(m_sle_don_vi.EditValue);
            v_us.datNGAY_BAT_DAU = m_dat_ngay_bat_dau.DateTime.Date;
            if (m_dat_ngay_ket_thuc.DateTime.Date != DateTime.MinValue.Date)
                v_us.datNGAY_KET_THUC = m_dat_ngay_ket_thuc.DateTime.Date;
            v_us.datNGAY_LAP = DateTime.Now.Date;
            v_us.strNGUOI_LAP = CAppContext_201.getCurrentUserName();
            v_us.strDA_XOA = "N";
            v_us.dcID_LOAI_CONG_TAC = 157;
            v_us.dcID_VI_TRI = CIPConvert.ToDecimal(m_sle_chuc_vu.EditValue);
            v_us.dcSO_HO_SO = ExecuteFuntion.GetSoHoSoNext(v_us.dcID_DON_VI, v_us.dcID_VI_TRI, v_us.dcID_NHAN_VIEN);

            v_us.UseTransOfUSObject(m_us_gd_hd);
            v_us.CapNhatHetHieuLucCongTac(v_us.dcID_NHAN_VIEN, m_dat_ngay_bat_dau.DateTime.Date);
            v_us.Insert();
            
            //v_us.CommitTransaction();
        }

        private void form_to_us_hd()
        {
            m_us_gd_hd.dcID_NHAN_VIEN = CIPConvert.ToDecimal(m_sle_chon_nhan_vien.EditValue);
            m_us_gd_hd.dcID_LOAI_HOP_DONG = CIPConvert.ToDecimal(m_sle_loai_hop_dong.EditValue);
            m_us_gd_hd.dcID_LOAI_LAO_DONG = CIPConvert.ToDecimal(m_sle_loai_lao_dong.EditValue);
            m_us_gd_hd.strMA_HOP_DONG = m_txt_ma_hd.Text;
            m_us_gd_hd.datNGAY_BAT_DAU = m_dat_ngay_bat_dau.DateTime;
            m_us_gd_hd.datNGAY_KY_HOP_DONG = m_dat_ngay_ky.DateTime;
            if (m_dat_ngay_ket_thuc.DateTime != DateTime.MinValue)
                m_us_gd_hd.datNGAY_KET_THUC = m_dat_ngay_ket_thuc.DateTime;
            if (get_luong_cd_theo_ma_muc() != null)
            {
                m_us_gd_hd.dcID_LUONG_CHE_DO = CIPConvert.ToDecimal(get_luong_cd_theo_ma_muc()["ID"]);
                m_us_gd_hd.dcSO_TIEN_LCD = CIPConvert.ToDecimal(m_txt_so_tien_lcd.Text);
            }
            m_us_gd_hd.dcID_DON_VI = CIPConvert.ToDecimal(m_sle_don_vi.EditValue);
            m_us_gd_hd.dcID_CHUC_VU = CIPConvert.ToDecimal(m_sle_chuc_vu.EditValue);
            m_us_gd_hd.strGHI_CHU = m_txt_mo_ta_cv.Text;
            if (m_e_form_mode == DataEntryFormMode.InsertDataState)
            {
                m_us_gd_hd.datNGAY_LAP = DateTime.Now.Date;
                m_us_gd_hd.strNGUOI_LAP = CAppContext_201.getCurrentUserName();
            }
            else if (m_e_form_mode == DataEntryFormMode.UpdateDataState)
            {
                m_us_gd_hd.datNGAY_SUA = DateTime.Now.Date;
                m_us_gd_hd.strNGUOI_SUA = CAppContext_201.getCurrentUserName();
            }
        }
        #endregion

        //Event Handler

        private void set_defines_event()
        {
            m_cmd_save.Click += m_cmd_save_Click;
            m_sle_ma_lcd.EditValueChanged += m_sle_ma_lcd_EditValueChanged;
            m_sle_muc_lcd.EditValueChanged += m_sle_muc_lcd_EditValueChanged;
            m_sle_chuc_vu.EditValueChanged += m_sle_chuc_vu_EditValueChanged;
            m_sle_ma_lns.EditValueChanged += M_sle_ma_lns_EditValueChanged;
            m_sle_muc_lns.EditValueChanged += M_sle_muc_lns_EditValueChanged;
        }

        private void M_sle_muc_lns_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (m_sle_ma_lns.EditValue != null)
                {
                    m_txt_he_so_lns.ResetText();
                    m_txt_he_so_lns.Text = load_data_to_lbl_he_so_lns();
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void M_sle_ma_lns_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (m_sle_muc_lns.EditValue != null)
                {
                    m_txt_he_so_lns.ResetText();
                    m_txt_he_so_lns.Text = load_data_to_lbl_he_so_lns();
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_sle_chuc_vu_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (m_sle_chuc_vu.EditValue == null)
                {
                    return;
                }
                m_txt_so_ho_so.EditValue = ExecuteFuntion.GetSoHoSoNext(Convert.ToDecimal(m_sle_don_vi.EditValue), Convert.ToDecimal(m_sle_chuc_vu.EditValue), Convert.ToDecimal(m_sle_chon_nhan_vien.EditValue));
            }
            catch (Exception v_e)
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
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_sle_ma_lcd_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (m_sle_muc_lcd.EditValue != null)
                {
                    m_txt_so_tien_lcd.ResetText();
                    load_data_to_lbl_so_tien_lcd();
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_sle_muc_lcd_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (m_sle_ma_lcd.EditValue != null)
                {
                    m_txt_so_tien_lcd.ResetText();
                    load_data_to_lbl_so_tien_lcd();
                }

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
                    string v_str_confirm = "Bạn có chắc chắn muốn lưu thông tin hợp đồng như trên?";
                    DialogResult v_dialog = XtraMessageBox.Show(v_str_confirm, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (v_dialog == DialogResult.Yes)
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
                    Close();
                }

            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
    }
}
