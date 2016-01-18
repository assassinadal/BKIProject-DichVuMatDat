using BKI_DichVuMatDat.US;
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
        private ENUM_CONFIRM_TINH_BANG_LUONG m_confirm;
        public msg001_confirm_tinh_bang_luong()
        {
            InitializeComponent();
        }
        public ENUM_CONFIRM_TINH_BANG_LUONG display()
        {
            return ENUM_CONFIRM_TINH_BANG_LUONG.TINH_NHAN_VIEN_CHUA_CO;
        }
    }
}
