using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BKI_DichVuMatDat.DS;
using BKI_DichVuMatDat.US;
using IP.Core.IPCommon;
using BKI_DichVuMatDat.DS.CDBNames;
using DevExpress.XtraEditors.Controls;
namespace BKI_DichVuMatDat.NghiepVu
{
    public partial class F312_dang_ky_giam_tru_nguoi_phu_thuoc : Form
    {
        
        
        public F312_dang_ky_giam_tru_nguoi_phu_thuoc()
        {
            InitializeComponent();
        }

        private void F312_dang_ky_giam_tru_nguoi_phu_thuoc_Load(object sender, EventArgs e)
        {
            try
            {
                get_nhan_vien();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void get_nhan_vien()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            DataTable v_dt = new DataTable();
            v_ds.Tables.Add(v_dt);
            v_us.FillDatasetWithQuery(v_ds, "select ID, DIA_CHI_THUONG_TRU, MA_NV, HO_DEM +' ' +TEN as HO_TEN from DM_NHAN_VIEN");
            m_slue_nhan_vien.Properties.DataSource = v_ds.Tables[0];
            m_slue_nhan_vien.Properties.BestFitMode = BestFitMode.BestFitResizePopup;
        }

        private void m_slue_nhan_vien_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (m_slue_nhan_vien.EditValue == null )
                {
                    return;
                }
                
                load_data_2_nhan_vien_info(CIPConvert.ToDecimal(m_slue_nhan_vien.EditValue));
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void load_data_2_nhan_vien_info(decimal ip_id_nhan_vien)
        {
            US_DM_NHAN_VIEN v_us = new US_DM_NHAN_VIEN(ip_id_nhan_vien);
            
            m_dtp_ns_nv.Value = v_us.datNGAY_SINH;
            m_txt_cmt.Text = v_us.strSO_CMT;
            m_txt_mst.Text = v_us.strMA_SO_THUE_CA_NHAN;
            m_txt_dia_chi.Text = v_us.strDIA_CHI_THUONG_TRU;

            //v_us_dm_nhan_vien.datNGAY_SINH = m_dtp_ns_nv.Value;
            //v_us_dm_nhan_vien.strSO_CMT = m_txt_cmt.Text;
            //v_us_dm_nhan_vien.strMA_SO_THUE_CA_NHAN = m_txt_mst.Text;
            //v_us_dm_nhan_vien.strDIA_CHI_THUONG_TRU = m_txt_dia_chi.Text;
        }

    }
}
