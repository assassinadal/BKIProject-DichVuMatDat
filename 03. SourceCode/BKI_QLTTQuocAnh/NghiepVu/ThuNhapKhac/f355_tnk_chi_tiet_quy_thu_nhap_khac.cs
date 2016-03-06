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
using DevExpress.XtraEditors;
namespace BKI_DichVuMatDat.NghiepVu.ThuNhapKhac
{
    public partial class f355_tnk_chi_tiet_quy_thu_nhap_khac : Form
    {
        #region Field & Property
        decimal m_dc_id_quy;
        #endregion

        #region Public Interface
        public f355_tnk_chi_tiet_quy_thu_nhap_khac(decimal ip_dc_id_quy_thu_nhap_khac)
        {
            InitializeComponent();
            format_control();
            m_dc_id_quy = ip_dc_id_quy_thu_nhap_khac;
        }
        #endregion

        #region Event Handle
        private void set_define_events()
        {
            Load += f355_tnk_chi_tiet_quy_thu_nhap_khac_Load;
            FormClosed += f355_tnk_chi_tiet_quy_thu_nhap_khac_FormClosed;
        }

        void f355_tnk_chi_tiet_quy_thu_nhap_khac_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                handle_form_closed();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void f355_tnk_chi_tiet_quy_thu_nhap_khac_Load(object sender, EventArgs e)
        {
            try
            {
                handle_form_loaded();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        #endregion

        #region Private Method



        //Set up Form
        private void format_control()
        {
            set_define_events();
        }
        //Get data in Form
        private void load_data_to_grid()
        {
            var v_dt_soure = TnkQL.Instance.LayChiTietQuy(m_dc_id_quy);
            m_grc_main.DataSource = null;
            m_grc_main.DataSource = v_dt_soure;
        }
        //Method bool

        //Event handle
        private void handle_form_loaded()
        {
            load_data_to_grid();
            var v_dto = TnkQL.Instance.LayThongTinQuy(m_dc_id_quy);
            m_lbl_ten_quy.Text = v_dto.TEN_QUY;
            m_lbl_tong_tien.Text = string.Format("{0:#,###}",v_dto.TONG_TIEN);
            m_lbl_so_luong_nv_trong_quy.Text = v_dto.SO_LUONG_NV_TRONG_QUY.ToString();
        }
        private void handle_form_closed()
        {
            Dispose();
        }
        
        #endregion
    }
}
