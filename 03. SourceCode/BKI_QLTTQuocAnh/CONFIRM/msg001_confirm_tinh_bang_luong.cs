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

namespace BKI_DichVuMatDat.CONFIRM
{
    public partial class msg001_confirm_tinh_bang_luong : Form
    {
        //Field
        public msg001_confirm_tinh_bang_luong()
        {
            InitializeComponent();
        }
        public ENUM_CONFIRM_TINH_BANG_LUONG display()
        {
            var v_dlg = this.ShowDialog();
            if(v_dlg != System.Windows.Forms.DialogResult.OK)
            {
                return ENUM_CONFIRM_TINH_BANG_LUONG.NONE;
            }

            if(Convert.ToDecimal(radioGroup.EditValue) == 1)
            {
                return ENUM_CONFIRM_TINH_BANG_LUONG.TINH_LAI_TOAN_BO;
            }
            else
            {
                return ENUM_CONFIRM_TINH_BANG_LUONG.TINH_NHAN_VIEN_CHUA_CO;
            }
        }

        private void m_cmd_confirm_Click(object sender, EventArgs e)
        {
            try
            {
                if(radioGroup.EditValue == null)
                {
                    XtraMessageBox.Show("Bạn chọn một Option tính lương trước!", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    return;
                }
                var v_dlg = XtraMessageBox.Show("Bạn có chắc chắn chọn Option tính lương này?", "XÁC NHẬN", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if(v_dlg == System.Windows.Forms.DialogResult.OK)
                {
                    DialogResult = System.Windows.Forms.DialogResult.OK;
                }
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        
    }
}
