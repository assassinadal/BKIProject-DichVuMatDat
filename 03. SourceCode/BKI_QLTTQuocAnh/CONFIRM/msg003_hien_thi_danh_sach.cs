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
namespace BKI_DichVuMatDat.CONFIRM
{
    public partial class msg003_hien_thi_danh_sach : Form
    {
        public msg003_hien_thi_danh_sach()
        {
            InitializeComponent();
        }
        public void Display(string ipFormText, string ipContentCaption, string ipContent)
        {
            Text = ipFormText;
            m_lbl_content.Text = ipContentCaption;
            m_memo_content.Text = ipContent;
            ShowDialog();
        }

        private void m_cmd_exit_Click(object sender, EventArgs e)
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

    }

}
