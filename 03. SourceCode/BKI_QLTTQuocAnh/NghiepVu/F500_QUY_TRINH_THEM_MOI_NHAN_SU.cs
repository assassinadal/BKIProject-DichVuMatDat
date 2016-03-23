using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IP.Core.IPCommon;
using BKI_DichVuMatDat.DS;
using BKI_DichVuMatDat.US;
using IP.Core.IPUserService;
using DevExpress.XtraEditors;
using BKI_DichVuMatDat.DanhMuc;
using BKI_DichVuMatDat;
using BKI_DichVuMatDat.DS.CDBNames;

namespace BKI_DichVuMatDat.NghiepVu
{
    public partial class F500_QUY_TRINH_THEM_MOI_NHAN_SU : Form
    {
        public F500_QUY_TRINH_THEM_MOI_NHAN_SU()
        {
            InitializeComponent();
            format_controls();
        }

        public static void done()
        {
            da_hoan_thanh = true;
        }

        #region Members
        int ip_id_nhan_vien = 0;
        int ip_id_nv_update = 0;
        int m_trang_thai_buoc_1 = -1;
        // m_trang_thai_buoc_1 sau bước 1  sẽ trả về id_nhan_vien
        int m_trang_thai_buoc_2 = -1;
        int m_trang_thai_buoc_3_thanh_cong = -1;
        int m_trang_thai_buoc_4 = -1;
        buoc_hien_tai m_e_buoc_hien_tai = buoc_hien_tai.buoc_1_nhap_ttnv;
        static bool da_hoan_thanh = false;
        #endregion

        #region Datastructure
        enum Trang_thai_cac_button
        {
            CHUA_HOAN_THANH = -1,
        }
        enum buoc_hien_tai
        {
            buoc_1_nhap_ttnv = 1,
            buoc_2_nhap_tthd = 2,
            buoc_3_nhap_ttct = 3,
            buoc_4_nhap_ttbs = 4,
            buoc_5 = 5,
        }
        #endregion

        #region Public Interface

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
            m_sle_chon_nhan_vien.Visible = false;
            load_data_2_sle_chon_nv();
            if (m_sle_chon_nhan_vien.EditValue != null
                && m_sle_chon_nhan_vien.EditValue != "")
            {
                m_cmd_sua_ttnv.Enabled = true;
                m_cmd_sua_tthd.Enabled = true;
                m_cmd_sua_ttct.Enabled = true;
                m_cmd_sua_ttbs.Enabled = true;
            }
            else
            {
                m_cmd_sua_ttnv.Enabled = false;
                m_cmd_sua_tthd.Enabled = false;
                m_cmd_sua_ttct.Enabled = false;
                m_cmd_sua_ttbs.Enabled = false;
            }
            switch (m_e_buoc_hien_tai)
            {
                case buoc_hien_tai.buoc_1_nhap_ttnv:
                    m_cmd_cong_tac.Enabled = false;
                    m_cmd_lap_hop_dong.Enabled = false;
                    m_cmd_nhap_thong_tin_nhan_vien.Enabled = true;
                    m_cmd_nhap_thong_tin_bo_sung.Enabled = false;
                    break;
                case buoc_hien_tai.buoc_2_nhap_tthd:
                    m_cmd_cong_tac.Enabled = false;
                    m_cmd_lap_hop_dong.Enabled = true;
                    m_cmd_nhap_thong_tin_nhan_vien.Enabled = false;
                    m_cmd_nhap_thong_tin_bo_sung.Enabled = false;
                    break;
                case buoc_hien_tai.buoc_3_nhap_ttct:
                    m_cmd_cong_tac.Enabled = true;
                    m_cmd_lap_hop_dong.Enabled = false;
                    m_cmd_nhap_thong_tin_nhan_vien.Enabled = false;
                    m_cmd_nhap_thong_tin_bo_sung.Enabled = false;
                    break;
                case buoc_hien_tai.buoc_4_nhap_ttbs:
                    m_cmd_cong_tac.Enabled = false;
                    m_cmd_lap_hop_dong.Enabled = false;
                    m_cmd_nhap_thong_tin_nhan_vien.Enabled = false;
                    m_cmd_nhap_thong_tin_bo_sung.Enabled = true;
                    break;
                case buoc_hien_tai.buoc_5:
                    if (CHRM_BaseMessages.MsgBox_Confirm("Bạn có muốn thêm nhân viên mới nữa không ?") == true)
                    {
                        m_e_buoc_hien_tai = buoc_hien_tai.buoc_1_nhap_ttnv;
                        set_init_form_load();
                    }
                    else
                    {
                        this.Close();
                    }
                    break;
                default:
                    break;
            }
        }

        private bool chuyen_buoc_tiep_theo()
        {
            if (da_hoan_thanh)
            {
                m_e_buoc_hien_tai++;
                da_hoan_thanh = false;
                return true;
            }
            return false;
        }

        private void load_data_2_sle_chon_nv()
        {
            m_sle_chon_nhan_vien.Properties.DataSource = load_data_2_ds_v_dm_nv().V_DM_NHAN_VIEN;
            m_sle_chon_nhan_vien.Properties.ValueMember = V_DM_NHAN_VIEN.ID;
            m_sle_chon_nhan_vien.Properties.DisplayMember = V_DM_NHAN_VIEN.HO_TEN;

            m_sle_chon_nhan_vien.Properties.PopulateViewColumns();

            m_sle_chon_nhan_vien.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            m_sle_chon_nhan_vien.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
        }

        private DS_V_DM_NHAN_VIEN load_data_2_ds_v_dm_nv()
        {
            DS_V_DM_NHAN_VIEN v_ds = new DS_V_DM_NHAN_VIEN();
            US_V_DM_NHAN_VIEN v_us = new US_V_DM_NHAN_VIEN();
            v_ds.EnforceConstraints = false;
            v_ds.Clear();
            v_us.FillDataset(v_ds);
            return v_ds;
        }

        private string find_ma_nv_by_id()
        {
            US_DM_NHAN_VIEN v_us = new US_DM_NHAN_VIEN();
            DS_DM_NHAN_VIEN v_ds = new DS_DM_NHAN_VIEN();

            v_us.FillDataset(v_ds);

            string v_str_filter = "ID = " + ip_id_nv_update;
            DataRow[] v_dr = v_ds.DM_NHAN_VIEN.Select(v_str_filter);

            if (v_dr.Count() == 0)
            {
                return "";
            }
            else
            {
                return v_dr.First()["MA_NV"].ToString();
            }
        }
        #endregion

        private void set_define_events()
        {
            this.Load += F500_QUY_TRINH_THEM_MOI_NHAN_SU_Load;
            this.FormClosed += F500_QUY_TRINH_THEM_MOI_NHAN_SU_FormClosed;
            m_cmd_nhap_thong_tin_nhan_vien.Click += m_cmd_nhap_thong_tin_nhan_vien_Click;
            m_cmd_lap_hop_dong.Click += m_cmd_lap_hop_dong_Click;
            m_cmd_cong_tac.Click += m_cmd_cong_tac_Click;
            m_cmd_nhap_thong_tin_bo_sung.Click += m_cmd_nhap_thong_tin_bo_sung_Click;
            m_cmd_exit.Click += m_cmd_exit_Click;
            m_cmd_sua_ttnv.Click += m_cmd_sua_ttnv_Click;
            m_cmd_sua_tthd.Click += m_cmd_sua_tthd_Click;
            m_cmd_sua_ttct.Click += m_cmd_sua_ttct_Click;
            m_cmd_sua_ttbs.Click += m_cmd_sua_ttbs_Click;
            m_cmd_chon_nhan_vien.Click += m_cmd_chon_nhan_vien_Click;
        }

        private void m_cmd_chon_nhan_vien_Click(object sender, EventArgs e)
        {
            m_sle_chon_nhan_vien.ShowPopup();
        }

        private void m_cmd_sua_ttbs_Click(object sender, EventArgs e)
        {
            F501_THONG_TIN_BO_SUNG_NHAN_VIEN v_frm = new F501_THONG_TIN_BO_SUNG_NHAN_VIEN();
            v_frm.DisplayForUpdate(ip_id_nv_update);
        }

        private void m_cmd_sua_ttct_Click(object sender, EventArgs e)
        {
            f350_quan_ly_vi_tri_cong_tac v_frm = new f350_quan_ly_vi_tri_cong_tac();
            v_frm.DisplayForQuyTrinhNhapMoiNhanVien(ip_id_nv_update);
        }

        private void m_cmd_sua_tthd_Click(object sender, EventArgs e)
        {
            f320_lap_hop_dong v_frm = new f320_lap_hop_dong();
            v_frm.DisplayForSuaHopDongNhanVien(ip_id_nv_update);
        }

        private void m_cmd_sua_ttnv_Click(object sender, EventArgs e)
        {
            US_DM_NHAN_VIEN v_us = new US_DM_NHAN_VIEN(ip_id_nv_update);
            f150_danh_muc_nhan_su_v2 v_f = new f150_danh_muc_nhan_su_v2();
            v_f.DisplayForUpdate(v_us);
            f151_Danh_sach_nhan_vien_master v_frm = new f151_Danh_sach_nhan_vien_master();
            v_frm.Display_With_ID_NV(ip_id_nv_update);
        }

        private void F500_QUY_TRINH_THEM_MOI_NHAN_SU_Load(object sender, EventArgs e)
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

        void F500_QUY_TRINH_THEM_MOI_NHAN_SU_FormClosed(object sender, FormClosedEventArgs e)
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

        private void m_cmd_nhap_thong_tin_nhan_vien_Click(object sender, EventArgs e)
        {
            try
            {
                ////Buoc 1: Hien thi form F150 danh muc nhan vien v2 de insert them nhan vien moi
                //f150_danh_muc_nhan_su_v2 v_frm_f150_v2 = new f150_danh_muc_nhan_su_v2();
                //v_frm_f150_v2.DisplayForInsert(ref m_trang_thai_buoc_1);

                ////Buoc 2: Hien thi from F151 luoi danh sach nhan vien
                //if (m_trang_thai_buoc_1 > 0)
                //{
                //    f151_Danh_sach_nhan_vien_master v_frm_f151 = new f151_Danh_sach_nhan_vien_master();
                //    v_frm_f151.Display_With_ID_NV(decimal.Parse(m_trang_thai_buoc_1.ToString().Trim()));
                //    //Buoc 3: Cho hien cac button buoc 2, an button 3,4
                //    m_cmd_lap_hop_dong.Enabled = true;
                //    m_cmd_cong_tac.Enabled = false;
                //    m_cmd_nhap_thong_tin_nhan_vien.Enabled = false;
                //}
                f151_Danh_sach_nhan_vien_master v_frm = new f151_Danh_sach_nhan_vien_master();
                f150_danh_muc_nhan_su_v2 v_frm_f150_v2 = new f150_danh_muc_nhan_su_v2();
                v_frm_f150_v2.DisplayForInsert(ref ip_id_nhan_vien);
                if (chuyen_buoc_tiep_theo())
                {
                    v_frm.Display_With_ID_NV(ip_id_nhan_vien);
                }
                set_init_form_load();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_lap_hop_dong_Click(object sender, EventArgs e)
        {
            try
            {
                //f320_lap_hop_dong v_f = new f320_lap_hop_dong();
                //v_f.DisplayForQuyTrinhNhapMoiNhanVien(m_trang_thai_buoc_1, ref m_trang_thai_buoc_3_thanh_cong);
                ////m_tran_thai_buoc_1 la id_nhan_vien
                //if (m_trang_thai_buoc_3_thanh_cong > 0)
                //{
                //    m_cmd_lap_hop_dong.Enabled = false;
                //    m_cmd_cong_tac.Enabled = true;
                //}
                f320_lap_hop_dong v_frm = new f320_lap_hop_dong();
                v_frm.DisplayForQuyTrinhNhapMoiNhanVien(ip_id_nhan_vien);
                if (chuyen_buoc_tiep_theo())
                {

                }
                //v_frm.Show();
                //m_e_buoc_hien_tai++;
                set_init_form_load();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }

        }

        private void m_cmd_cong_tac_Click(object sender, EventArgs e)
        {
            try
            {
                //f350_quan_ly_vi_tri_cong_tac v_f = new f350_quan_ly_vi_tri_cong_tac();
                //v_f.DisplayForQuyTrinhNhapMoiNhanVien(m_trang_thai_buoc_1, ref m_trang_thai_buoc_4);
                ////m_tran_thai_buoc_1 la id_nhan_vien
                //if (m_trang_thai_buoc_3_thanh_cong > 0)
                //{
                //    m_cmd_cong_tac.Enabled = false;
                //    m_cmd_nhap_thong_tin_bo_sung.Enabled = true;
                //    v_f.display();
                //}
                f350_quan_ly_vi_tri_cong_tac v_frm = new f350_quan_ly_vi_tri_cong_tac();
                v_frm.DisplayForQuyTrinhNhapMoiNhanVien(ip_id_nhan_vien);
                if (chuyen_buoc_tiep_theo())
                {

                }
                //v_frm.Show();
                //m_e_buoc_hien_tai++;
                set_init_form_load();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_nhap_thong_tin_bo_sung_Click(object sender, EventArgs e)
        {
            try
            {
                //F501_THONG_TIN_BO_SUNG_NHAN_VIEN v_f = new F501_THONG_TIN_BO_SUNG_NHAN_VIEN();
                //v_f.ShowForPresent(m_trang_thai_buoc_1, ref m_trang_thai_buoc_2);
                //if (CHRM_BaseMessages.MsgBox_Confirm("Bạn có muốn thêm nhân viên mới nữa không ?") == true)
                //{
                //    m_cmd_nhap_thong_tin_bo_sung.Enabled = false;
                //    m_cmd_lap_hop_dong.Enabled = false;
                //    m_cmd_cong_tac.Enabled = false;
                //    m_cmd_nhap_thong_tin_nhan_vien.Enabled = true;
                //}
                //else
                //{
                //    this.Close();
                //}
                F501_THONG_TIN_BO_SUNG_NHAN_VIEN v_frm = new F501_THONG_TIN_BO_SUNG_NHAN_VIEN();
                v_frm.ShowForPresent(ip_id_nhan_vien);
                if (chuyen_buoc_tiep_theo())
                {

                }
                set_init_form_load();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_exit_Click(object sender, EventArgs e)
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

        private void m_sle_chon_nhan_vien_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (m_sle_chon_nhan_vien.EditValue != null
                    && m_sle_chon_nhan_vien.EditValue != "")
                {
                    ip_id_nv_update = int.Parse(m_sle_chon_nhan_vien.EditValue.ToString());
                    m_cmd_chon_nhan_vien.Text = find_ma_nv_by_id();
                    m_cmd_chon_nhan_vien.Text += " : ";
                    m_cmd_chon_nhan_vien.Text += m_sle_chon_nhan_vien.Text.ToString();
                }
                else
                {
                    m_cmd_chon_nhan_vien.Text = "Chọn nhân viên";
                }
                set_init_form_load();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
    }
}
