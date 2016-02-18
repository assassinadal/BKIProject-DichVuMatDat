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
            v_f.ShowDialog();
        }

        #endregion

      
        #region Members
        
        #endregion
    }
}
