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
using IP.Core.IPSystemAdmin;
using BKI_DichVuMatDat.COMMON;
using BKI_DichVuMatDat.DS;
using DevExpress.XtraEditors;
namespace BKI_DichVuMatDat.NghiepVu.HopDong
{
    public partial class f391_cap_nhat_thay_doi_lns_lcd_DE : Form
    {
        #region Public Interface
        public f391_cap_nhat_thay_doi_lns_lcd_DE()
        {
            InitializeComponent();
            format_controls();
            init_form();
        }
        public void display_for_insert_lns()
        {
            setup_for_insert_lns();
            m_e_loai_form = e_loai_form.INSERT_LNS;
            ShowDialog();
        }
        public void display_for_insert_lcd()
        {
            setup_for_insert_lcd();
            ShowDialog();
        }
        public void display_for_up_date_lns(decimal ip_dc_id_gd_he_so_lns)
        {
            setup_for_update_lns(ip_dc_id_gd_he_so_lns);
            ShowDialog();
        }
        public void display_for_up_date_lcd()
        {
            setup_for_update_lcd();
            ShowDialog();
        }
        #endregion

        #region Members
        e_loai_form m_e_loai_form = e_loai_form.NULL;
        US_GD_HE_SO_LNS m_us_save = new US_GD_HE_SO_LNS();
        #endregion

        #region Data Structrure
        enum e_loai_form
        {
            INSERT_LNS,
            INSERT_LCD,
            UPDATE_LNS,
            UPDATE_LCD,
            NULL
        }
        #endregion

        #region Private Method
        private void init_form()
        {
            load_data_to_sle_hop_dong(get_danh_sach_hop_dong_con_hieu_luc());
            load_data_to_le_ly_do_chinh_sua();
        }
        private void format_controls()
        {
            set_define_events();
        }
        //Get data
        private DataTable get_danh_sach_hop_dong_con_hieu_luc()
        {
            US_GD_HOP_DONG v_us_hd = new US_GD_HOP_DONG();
            return v_us_hd.LayDanhSachHopDongConHieuLuc();
        }

        //Load data
        private void load_data_to_sle_hop_dong(DataTable ip_dt_source)
        {
            m_sle_hop_dong.Properties.DataSource = ip_dt_source;
        }
        private void load_data_to_le_ly_do_chinh_sua()
        {
            US_CM_DM_TU_DIEN v_us = new US_CM_DM_TU_DIEN();
            DS_CM_DM_TU_DIEN v_ds = new DS_CM_DM_TU_DIEN();
            v_us.FillDatasetByIdLoaiTuDien(v_ds, CONST_ID_LOAI_TU_DIEN.LY_DO_CHINH_SUA_HS_LNS);

            m_le_ly_do_chinh_sua.Properties.DataSource = v_ds.Tables[0];
        }
        //Check
        private bool is_valid_client()
        {
            if(true)
            {

            }
            return true;
        }
        private bool is_valid_logic()
        {
            return true;
        }

        //Save
        private void save_insert_lns()
        {
            try
            {
                m_us_save = new US_GD_HE_SO_LNS();
               // m_us_save.dcID_LY_DO_CHINH_SUA = Convert.ToDecimal(m_le_ly_do_chinh_sua.EditValue);
                m_us_save.datNGAY_BAT_DAU = m_dat_tu_ngay.DateTime.Date;
                m_us_save.datNGAY_KET_THUC = m_dat_den_ngay.DateTime.Date;
                m_us_save.datNGAY_LAP = DateTime.Now.Date;
                //m_us_save.dcID_HS_LNS_LCD = ExecuteFuntion.GetID_GD_HS_LNS_LCDByID_HOP_DONG(Convert.ToDecimal(m_sle_hop_dong.EditValue));
                m_us_save.dcHE_SO = Convert.ToDecimal(m_txt_gia_tri_thay_doi.EditValue);
                //m_us_save.strDA_XOA = "N";
                m_us_save.strGHI_CHU = m_txt_ghi_chu.Text;
                m_us_save.strNGUOI_LAP = CAppContext_201.getCurrentUserName();

                m_us_save.BeginTransaction();
                //m_us_save.SetHetHieuLucTruocKhiThemMoi(m_us_save.dcID_HS_LNS_LCD, m_dat_tu_ngay.DateTime.AddDays(-1).Date);
                m_us_save.Insert();
                m_us_save.CommitTransaction();
                XtraMessageBox.Show("Thêm mới dữ liệu thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch(Exception)
            {
                if(m_us_save.is_having_transaction())
                {
                    m_us_save.Rollback();
                }
                throw;
            }
            
        }
        private void save_insert_lcd()
        {
            XtraMessageBox.Show("Thêm mới dữ liệu thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
        private void save_update_lns()
        {
            //m_us_save.dcID_LY_DO_CHINH_SUA = Convert.ToDecimal(m_le_ly_do_chinh_sua.EditValue);
            m_us_save.datNGAY_BAT_DAU = m_dat_tu_ngay.DateTime.Date;
            m_us_save.datNGAY_KET_THUC = m_dat_den_ngay.DateTime.Date;
            m_us_save.datNGAY_SUA = DateTime.Now.Date;
            //m_us_save.dcID_HS_LNS_LCD = ExecuteFuntion.GetID_GD_HS_LNS_LCDByID_HOP_DONG(Convert.ToDecimal(m_sle_hop_dong.EditValue));
            m_us_save.dcHE_SO = Convert.ToDecimal(m_txt_gia_tri_thay_doi.EditValue);
            //m_us_save.strDA_XOA = "N";
            m_us_save.strGHI_CHU = m_txt_ghi_chu.Text;
            m_us_save.strNGUOI_SUA = CAppContext_201.getCurrentUserName();

            m_us_save.Update();
            XtraMessageBox.Show("Cập nhật dữ liệu thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
        private void save_update_lcd()
        {

        }
        private void save_data()
        {
            if(!is_valid_client())
            {
                return;
            }
            if(!is_valid_logic())
            {
                return;
            }
            switch(m_e_loai_form)
            {
                case e_loai_form.INSERT_LNS:
                    save_insert_lns();
                    break;
                case e_loai_form.INSERT_LCD:
                    save_insert_lcd();
                    break;
                case e_loai_form.UPDATE_LNS:
                    save_update_lns();
                    break;
                case e_loai_form.UPDATE_LCD:
                    break;
                case e_loai_form.NULL:
                    break;
                default:
                    break;
            }
        }

        //Setup
        private void setup_for_insert_lns()
        {
            Text = "F391 - Thêm mới chỉnh sửa hệ số LNS";
            layoutControlItemMA.Text = "Mã LNS";
            layoutControlItemMUC.Text = "Mức LNS";
            layoutControlItemHESO_TIEN.Text = "Hệ số";
        }
        private void setup_for_insert_lcd()
        {
            Text = "F391 - Thêm mới chỉnh sửa LCĐ";

        }
        private void setup_for_update_lns(decimal ip_dc_id_gd_he_so_lns)
        {
            m_e_loai_form = e_loai_form.UPDATE_LNS;
            US_GD_HE_SO_LNS v_us_hs_lns = new US_GD_HE_SO_LNS(ip_dc_id_gd_he_so_lns);
            US_GD_HS_LNS_LCD v_us_hs_lns_lcd = new US_GD_HS_LNS_LCD();//new US_GD_HS_LNS_LCD(v_us_hs_lns.dcID_HS_LNS_LCD);

            m_us_save.dcID = ip_dc_id_gd_he_so_lns;

            m_sle_hop_dong.EditValue = v_us_hs_lns_lcd.dcID_HOP_DONG;
            m_txt_gia_tri_thay_doi.EditValue = v_us_hs_lns.dcHE_SO;
            m_dat_tu_ngay.DateTime = v_us_hs_lns.datNGAY_BAT_DAU;
            m_dat_den_ngay.DateTime = v_us_hs_lns.datNGAY_KET_THUC;
            //m_le_ly_do_chinh_sua.EditValue = v_us_hs_lns.dcID_LY_DO_CHINH_SUA;
            m_txt_ghi_chu.Text = v_us_hs_lns.strGHI_CHU;
            Text = "F391 - Cập nhật chỉnh sửa hệ số LNS";

            US_GD_HOP_DONG v_us_hd = new US_GD_HOP_DONG();
            decimal op_he_so = 0;
            string op_ma = "";
            string op_muc = "";
            v_us_hd.LayMaMucLNSCuaHopDong(Convert.ToDecimal(m_sle_hop_dong.EditValue), out op_he_so, out op_ma, out op_muc);
            m_txt_ma.Text = op_ma;
            m_txt_muc.Text = op_muc;
            m_txt_gia_tri_ma_muc.EditValue = op_he_so;

            m_sle_hop_dong.ReadOnly = true;
        }
        private void setup_for_update_lcd()
        {
            Text = "F391 - Cập nhật chỉnh sửa LCĐ";

        }

        //Fill Data TO Control
        private void fill_data_to_control_insert_lns()
        {
            US_GD_HOP_DONG v_us_hd = new US_GD_HOP_DONG();
            decimal op_he_so = 0;
            string op_ma = "";
            string op_muc = "";
            v_us_hd.LayMaMucLNSCuaHopDong(Convert.ToDecimal(m_sle_hop_dong.EditValue), out op_he_so, out op_ma, out op_muc);
            m_txt_ma.Text = op_ma;
            m_txt_muc.Text = op_muc;
            m_txt_gia_tri_ma_muc.EditValue = op_he_so;
        }
        #endregion

        #region Event Handle
        private void set_define_events()
        {
            FormClosed += f391_cap_nhat_thay_doi_lns_lcd_DE_FormClosed;
            m_sle_hop_dong.EditValueChanged += m_sle_hop_dong_EditValueChanged;
            m_cmd_exit.Click += m_cmd_exit_Click;
            m_cmd_save.Click += m_cmd_save_Click;
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

        void m_cmd_exit_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_sle_hop_dong_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if(m_sle_hop_dong.EditValue == null)
                {
                    return;
                }
                switch(m_e_loai_form)
                {
                    case e_loai_form.INSERT_LNS:
                        fill_data_to_control_insert_lns();
                        break;
                    case e_loai_form.INSERT_LCD:
                        break;
                    case e_loai_form.UPDATE_LNS:
                       
                        break;
                    case e_loai_form.UPDATE_LCD:
                        break;
                    case e_loai_form.NULL:
                        break;
                    default:
                        break;
                }
                
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void f391_cap_nhat_thay_doi_lns_lcd_DE_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Dispose();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        #endregion
    }
}
