using BKI_DichVuMatDat.DS;
using BKI_DichVuMatDat.DS.CDBNames;
using BKI_DichVuMatDat.US;
using DevExpress.XtraEditors;
using DevExpress.XtraTreeList.Nodes;
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
using BKI_DichVuMatDat.NghiepVu;

namespace BKI_DichVuMatDat.NghiepVu
{
    public partial class f300_chinh_lns_nhan_vien : Form
    {
        public f300_chinh_lns_nhan_vien()
        {
            InitializeComponent();
            format_controll();
        }

        #region private methods

        private void format_controll()
        {
            set_define_events();
            CenterToScreen();
        }

        private void set_init_form_load()
        {
            load_data_2_tree();
        }

        private void load_data_2_tree()
        {
            US_V_DM_DON_VI_2 v_us_dv = new US_V_DM_DON_VI_2();
            DS_V_DM_DON_VI_2 v_ds_dv = new DS_V_DM_DON_VI_2();
            v_us_dv.FillDataset(v_ds_dv);

            m_tree_don_vi.ParentFieldName = DM_DON_VI.ID_DON_VI_CAP_TREN;
            m_tree_don_vi.DataSource = v_ds_dv.Tables[0];
            m_tree_don_vi.RefreshDataSource();

            m_tree_don_vi.ExpandAll();
        }

        private void load_data_danh_sach_nhan_vien_theo_don_vi(decimal ip_dc_id_don_vi)
        {

        }

        #endregion

        //EVENTS

        private void set_define_events()
        {
            Load += F300_chinh_lns_nhan_vien_Load;
            m_tree_don_vi.AfterFocusNode += M_tree_don_vi_AfterFocusNode;
            m_grv.DoubleClick += M_grv_DoubleClick;
        }

        private void M_grv_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                f299_chinh_lns_nhan_vien_de v_frm = new f299_chinh_lns_nhan_vien_de();

            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void M_tree_don_vi_AfterFocusNode(object sender, DevExpress.XtraTreeList.NodeEventArgs e)
        {
            try
            {
                var v_dc_id_don_vi = Convert.ToDecimal(e.Node.GetValue(V_DM_DON_VI_2.ID));
                load_data_danh_sach_nhan_vien_theo_don_vi(v_dc_id_don_vi);
                var v_str_ten_don_vi = e.Node.GetValue(V_DM_DON_VI_2.TEN_DON_VI).ToString();
                //m_lbl_thong_tin_phong_ban.Text = v_str_ten_don_vi;
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void F300_chinh_lns_nhan_vien_Load(object sender, EventArgs e)
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
    }
}
