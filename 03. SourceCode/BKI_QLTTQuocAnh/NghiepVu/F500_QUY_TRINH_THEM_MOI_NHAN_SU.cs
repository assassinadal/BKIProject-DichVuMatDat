using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        private void format_controls()
        {
            FormatControl.SetVisibleSimpleButton(this);
            set_define_events();
            this.KeyPreview = true;
        }

        private void set_define_events()
        {
            m_cmd_nhap_loai_lao_dong.Enabled = false;
        }


        #region Public Interface
        
        #endregion

        #region Private Methods


        private void F500_QUY_TRINH_THEM_MOI_NHAN_SU_Load(object sender, EventArgs e)
        {

        }

       
        private void m_cmd_nhap_thong_tin_nhan_vien_Click(object sender, EventArgs e)
        {
            f150_Danh_sach_nhan_vien_master v_f = new f150_Danh_sach_nhan_vien_master();
            v_f.DisplayForPresent(ref m_trang_thai_buoc_1);
            if (m_trang_thai_buoc_1 > 0)
            {
                m_cmd_nhap_loai_lao_dong.Enabled = true;
                m_cmd_nhap_thong_tin_nhan_vien.Enabled = false;
            }

        }

        #endregion

      
        #region Members

        int m_trang_thai_buoc_1 = -1;
        // m_trang_thai_buoc_1 sau bước 1  sẽ trả về id_nhan_vien
        int m_trang_thai_buoc_2 = -1;
        int m_trang_thai_buoc_3_thanh_cong = -1;
        
        #endregion

        private void m_cmd_nhap_loai_lao_dong_Click(object sender, EventArgs e)
        {
            F501_THONG_TIN_BO_SUNG_NHAN_VIEN v_f = new F501_THONG_TIN_BO_SUNG_NHAN_VIEN();
            v_f.ShowForPresent(m_trang_thai_buoc_1, ref m_trang_thai_buoc_2);
            if (m_trang_thai_buoc_2 > 0)
            {
                m_cmd_lap_hop_dong.Enabled = true;
                m_cmd_nhap_loai_lao_dong.Enabled = false;
            }
           
        }

        private void m_cmd_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void m_cmd_lap_hop_dong_Click(object sender, EventArgs e)
        {
            f320_lap_hop_dong v_f = new f320_lap_hop_dong();
            v_f.DisplayForQuyTrinhNhapMoiNhanVien(m_trang_thai_buoc_1, ref m_trang_thai_buoc_3_thanh_cong);
            //m_tran_thai_buoc_1 la id_nhan_vien
            if (m_trang_thai_buoc_3_thanh_cong > 0)
            {
                MessageBox.Show("Nhập hợp đồng thành công!");
                v_f.Close();
            }
        }
    }
}
