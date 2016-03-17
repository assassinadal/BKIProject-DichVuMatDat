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

namespace BKI_DichVuMatDat.NghiepVu
{
    public partial class F500_QUY_TRINH_THEM_MOI_NHAN_SU : Form
    {
        public F500_QUY_TRINH_THEM_MOI_NHAN_SU()
        {
            InitializeComponent();
            format_controls();
        }

        #region Members

        int m_trang_thai_buoc_1 = -1;
        // m_trang_thai_buoc_1 sau bước 1  sẽ trả về id_nhan_vien
        int m_trang_thai_buoc_2 = -1;
        int m_trang_thai_buoc_3_thanh_cong = -1;
        int m_trang_thai_buoc_4 = -1;

        #endregion

        #region Datastructure
        enum Trang_thai_cac_button
        {
            CHUA_HOAN_THANH = -1,
            
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
            m_cmd_nhap_loai_lao_dong.Enabled = false;
            
        }


        #endregion

        private void set_define_events()
        {
            this.Load += F500_QUY_TRINH_THEM_MOI_NHAN_SU_Load;
            this.FormClosed += F500_QUY_TRINH_THEM_MOI_NHAN_SU_FormClosed;
            m_cmd_nhap_thong_tin_nhan_vien.Click += m_cmd_nhap_thong_tin_nhan_vien_Click;
            m_cmd_lap_hop_dong.Click += m_cmd_lap_hop_dong_Click;
            m_cmd_cong_tac.Click += m_cmd_cong_tac_Click;
            m_cmd_nhap_loai_lao_dong.Click += m_cmd_nhap_loai_lao_dong_Click;
            m_cmd_exit.Click += m_cmd_exit_Click;
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
                //Buoc 1: Hien thi form F150 danh muc nhan vien v2 de insert them nhan vien moi
                f150_danh_muc_nhan_su_v2 v_frm_f150_v2 = new f150_danh_muc_nhan_su_v2();
                v_frm_f150_v2.DisplayForInsert(ref m_trang_thai_buoc_1);

                //Buoc 2: Hien thi from F151 luoi danh sach nhan vien
                if (m_trang_thai_buoc_1 > 0)
                {
                    f151_Danh_sach_nhan_vien_master v_frm_f151 = new f151_Danh_sach_nhan_vien_master();
                    v_frm_f151.Display_With_ID_NV(decimal.Parse(m_trang_thai_buoc_1.ToString().Trim()));
                //Buoc 3: Cho hien cac button buoc 2, an button 3,4
                    m_cmd_lap_hop_dong.Enabled = true;
                    m_cmd_cong_tac.Enabled = false;
                    m_cmd_nhap_thong_tin_nhan_vien.Enabled = false;
                }
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
                f320_lap_hop_dong v_f = new f320_lap_hop_dong();
                v_f.DisplayForQuyTrinhNhapMoiNhanVien(m_trang_thai_buoc_1, ref m_trang_thai_buoc_3_thanh_cong);
                //m_tran_thai_buoc_1 la id_nhan_vien
                if (m_trang_thai_buoc_3_thanh_cong > 0)
                {
                    m_cmd_lap_hop_dong.Enabled = false;
                    m_cmd_cong_tac.Enabled = true;
                }
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
                f350_quan_ly_vi_tri_cong_tac v_f = new f350_quan_ly_vi_tri_cong_tac();
                v_f.DisplayForQuyTrinhNhapMoiNhanVien(m_trang_thai_buoc_1, ref m_trang_thai_buoc_4);
                //m_tran_thai_buoc_1 la id_nhan_vien
                if (m_trang_thai_buoc_3_thanh_cong > 0)
                {
                    m_cmd_cong_tac.Enabled = false;
                    m_cmd_nhap_loai_lao_dong.Enabled = true;
                    v_f.display();
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_nhap_loai_lao_dong_Click(object sender, EventArgs e)
        {
            try
            {
                F501_THONG_TIN_BO_SUNG_NHAN_VIEN v_f = new F501_THONG_TIN_BO_SUNG_NHAN_VIEN();
                v_f.ShowForPresent(m_trang_thai_buoc_1, ref m_trang_thai_buoc_2);
                if (CHRM_BaseMessages.MsgBox_Confirm("Bạn có muốn thêm nhân viên mới nữa không ?") == true)
                {
                    m_cmd_nhap_loai_lao_dong.Enabled = false;
                    m_cmd_lap_hop_dong.Enabled = false;
                    m_cmd_cong_tac.Enabled = false;
                    m_cmd_nhap_thong_tin_nhan_vien.Enabled = true;
                }
                else
                {
                    this.Close();
                }
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

    }
}
