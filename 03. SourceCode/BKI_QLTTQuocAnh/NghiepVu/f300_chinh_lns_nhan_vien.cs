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

        public f300_chinh_lns_nhan_vien(DateTime ip_datetime, bool ip_trang_thai_filter)
        {
            InitializeComponent();
            set_define_events();
            string v_str = ip_datetime.ToString("MM/dd/yyyy");
            string v_str_ngay_hien_tai = DateTime.Now.ToString("MM/dd/yyyy");
            if (ip_trang_thai_filter == true)
            {
                m_grv.ActiveFilterString = "[NGAY_KET_THUC] >= #" + v_str + "# and [NGAY_KET_THUC] <= #" + v_str_ngay_hien_tai + "#";
            }
            else if (ip_trang_thai_filter == false)
            {
                m_grv.ActiveFilterString = "[NGAY_KET_THUC] > #" + v_str_ngay_hien_tai + "# and [NGAY_KET_THUC] <= #" + v_str + "#";
            }
            this.CenterToParent();
            this.ShowDialog();
        }

        private decimal m_dc_id_don_vi;

        private tab_mode m_e_tab_mode = tab_mode.co_lns;

        enum tab_mode
        {
            co_lns = 1,
            khong_lns = 0,
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
            load_data_danh_sach_nhan_vien_theo_don_vi(0);
            m_lbl_ten_dv.AppearanceItemCaption.ForeColor = Color.Green;
        }

        private void load_data_2_tree()
        {
            US_V_DM_DON_VI_2 v_us_dv = new US_V_DM_DON_VI_2();
            DS_V_DM_DON_VI_2 v_ds_dv = new DS_V_DM_DON_VI_2();
            v_us_dv.FillDataset(v_ds_dv);

            //m_tree_don_vi.ParentFieldName = DM_DON_VI.ID_DON_VI_CAP_TREN;
            //m_tree_don_vi.DataSource = v_ds_dv.Tables[0];
            //m_tree_don_vi.RefreshDataSource();

            //m_tree_don_vi.ExpandAll();
        }

        private void load_data_danh_sach_nhan_vien_theo_don_vi(decimal ip_dc_id_don_vi)
        {
            US_V_GD_HE_SO_LNS v_us = new US_V_GD_HE_SO_LNS();
            DS_V_GD_HE_SO_LNS v_ds = new DS_V_GD_HE_SO_LNS();
            v_ds.EnforceConstraints = false;
            //v_us.FillDataset(v_ds, " where ID_DON_VI = " + ip_dc_id_don_vi);
            v_us.FillDataset(v_ds);

            m_grc.DataSource = v_ds.Tables[0];
        }

        private void load_data_2_grv_k_hs_lns()
        {
            US_V_GD_KHONG_HE_SO_LNS v_us = new US_V_GD_KHONG_HE_SO_LNS();
            DS_V_GD_KHONG_HE_SO_LNS v_ds = new DS_V_GD_KHONG_HE_SO_LNS();
            v_ds.EnforceConstraints = false;
            v_us.FillDataset(v_ds);

            m_grc_khs.DataSource = v_ds.Tables[0];
        }

        private void insert_click()
        {
            DataRow v_dr; 
            f299_chinh_lns_nhan_vien_de v_frm = new f299_chinh_lns_nhan_vien_de();
            switch (m_e_tab_mode)
            {
                case tab_mode.co_lns:
                    v_dr = m_grv.GetDataRow(m_grv.FocusedRowHandle);
                    US_GD_HE_SO_LNS v_us = new US_GD_HE_SO_LNS(Convert.ToDecimal(v_dr["ID"].ToString()));
                    v_frm.display_4_insert(v_us);
                    load_data_danh_sach_nhan_vien_theo_don_vi(m_dc_id_don_vi);
                    focus_row(v_us.dcID_NHAN_VIEN);
                    break;
                case tab_mode.khong_lns:
                    v_dr = m_grv_khs.GetDataRow(m_grv_khs.FocusedRowHandle);
                    v_frm.display_4_insert_new(Convert.ToDecimal(v_dr["ID_NHAN_VIEN"].ToString()));
                    load_data_2_grv_k_hs_lns();
                    break;
                default:
                    break;
            }
        }

        private void update_click()
        {
            DataRow v_dr = m_grv.GetDataRow(m_grv.FocusedRowHandle);
            US_GD_HE_SO_LNS v_us = new US_GD_HE_SO_LNS(Convert.ToDecimal(v_dr["ID"].ToString()));
            f299_chinh_lns_nhan_vien_de v_frm = new f299_chinh_lns_nhan_vien_de();
            v_frm.display_4_update(v_us);
            load_data_danh_sach_nhan_vien_theo_don_vi(m_dc_id_don_vi);
            focus_row(v_us.dcID_NHAN_VIEN);
        }

        private void focus_row(decimal ip_id_nhan_vien)
        {
            CHRMCommon.SelectRowInGrid(m_grv, "ID", ip_id_nhan_vien);
        }

        #endregion

        //EVENTS

        private void set_define_events()
        {
            Load += F300_chinh_lns_nhan_vien_Load;
            //m_tree_don_vi.AfterFocusNode += M_tree_don_vi_AfterFocusNode;
            //m_grv.DoubleClick += M_grv_DoubleClick;
            m_cmd_insert.Click += M_cmd_insert_Click;
            m_cmd_update.Click += M_cmd_update_Click;
            m_cmd_delete.Click += M_cmd_delete_Click;
            xtraTabControl1.SelectedPageChanged += XtraTabControl1_SelectedPageChanged;
        }

        private void XtraTabControl1_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            switch (e.Page.Text)
            {
                case "NHÂN VIÊN CÓ LƯƠNG NĂNG SUẤT":
                    m_e_tab_mode = tab_mode.co_lns;
                    m_cmd_delete.Visible = true;
                    m_cmd_update.Visible = true;
                    load_data_danh_sach_nhan_vien_theo_don_vi(0);
                    break;
                case "NHÂN VIÊN KHÔNG LƯƠNG NĂNG SUẤT":
                    m_e_tab_mode = tab_mode.khong_lns;
                    m_cmd_delete.Visible = false;
                    m_cmd_update.Visible = false;
                    load_data_2_grv_k_hs_lns();

                    break;
                default:
                    break;
            }
        }

        private void M_cmd_delete_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow v_dr = m_grv.GetDataRow(m_grv.FocusedRowHandle);
                US_GD_HE_SO_LNS v_us = new US_GD_HE_SO_LNS(Convert.ToDecimal(v_dr["ID"].ToString()));
                v_us.Delete();
                load_data_danh_sach_nhan_vien_theo_don_vi(m_dc_id_don_vi);
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void M_cmd_update_Click(object sender, EventArgs e)
        {
            try
            {
                update_click();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void M_cmd_insert_Click(object sender, EventArgs e)
        {
            try
            {
                insert_click();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void M_grv_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                DataRow v_dr = m_grv.GetDataRow(m_grv.FocusedRowHandle);
                decimal ip_id_nhan_vien = Convert.ToDecimal(v_dr["ID_NHAN_VIEN"].ToString());
                f299_chinh_lns_nhan_vien_de v_f = new f299_chinh_lns_nhan_vien_de();
                //v_f.Display(ip_id_nhan_vien);
                //focus_row(CIPConvert.ToDecimal(v_dr["ID"].ToString()));
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
                m_dc_id_don_vi = Convert.ToDecimal(e.Node.GetValue(V_DM_DON_VI_2.ID));
                load_data_danh_sach_nhan_vien_theo_don_vi(m_dc_id_don_vi);
                var v_str_ten_don_vi = e.Node.GetValue(V_DM_DON_VI_2.TEN_DON_VI).ToString();
                m_lbl_ten_dv.Text = v_str_ten_don_vi;
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
