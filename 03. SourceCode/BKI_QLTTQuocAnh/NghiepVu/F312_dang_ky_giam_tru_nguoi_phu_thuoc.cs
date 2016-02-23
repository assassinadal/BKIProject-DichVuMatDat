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
                load_data_2_grid(m_slue_nhan_vien.EditValue.ToString());
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

        private void m_cmd_insert_Click(object sender, EventArgs e)
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            DataTable v_dt = new DataTable();
            v_ds.Tables.Add(v_dt);
            v_us.FillDatasetWithQuery(v_ds, "select * from gd_phu_thuoc where ID_NHAN_VIEN = " + m_slue_nhan_vien.EditValue.ToString() + " and DA_XOA = 'N'");

            US_GD_PHU_THUOC v_us_pt;
            if (v_ds.Tables[0].Rows.Count > 0)
            {
                v_us_pt = new US_GD_PHU_THUOC(CIPConvert.ToDecimal(v_ds.Tables[0].Rows[0]["ID"].ToString()));
                v_us_pt.dcSO_LUONG = v_us_pt.dcSO_LUONG + 1;
                v_us_pt.Update();
            }
            else
            {
                v_us_pt = new US_GD_PHU_THUOC();
                v_us_pt.dcID_NHAN_VIEN = CIPConvert.ToDecimal(m_slue_nhan_vien.EditValue.ToString());
                v_us_pt.dcSO_LUONG = 1;
                v_us_pt.strDA_XOA = "N";
                v_us_pt.Insert();
            }


            //US_GD_PHU_THUOC_DETAILS v_us_2 = new US_GD_PHU_THUOC_DETAILS();
            //v_us_2.strDIA_CHI_NGUOI_PHU_THUOC = m_txt_dia_chi_thuong_tru.Text;
            //v_us_2.strGIAY_TO_DI_KEM = m_txt_giay_to.Text;
            //v_us_2.strMA_SO_THUE_NGUOI_PHU_THUOC = m_txt_mst_ng_pt.Text;
            //v_us_2.strQUAN_HE_VOI_NGUOI_NOP_THUE = m_txt_quan_he.Text;
            //v_us_2.strSO_CMT_NGUOI_PHU_THUOC = m_txt_cmt_nguoi_pt.Text;
            //v_us_2.strTEN_NGUOI_PHU_THUOC = m_txt_ho_ten.Text;
            //v_us_2.datNGAY_SINH_NGUOI_PHU_THUOC = dateTimePicker2.Value;
            //v_us_2.dcID_GD_PHU_THUOC = v_us_pt.dcID;
            //v_us_2.strDA_XOA = "N";
            //v_us_2.Insert();
            //BaseMessages.MsgBox_Infor("90 - Thêm người phụ thuộc thành công");
            //load_data_2_grid(m_slue_nhan_vien.EditValue.ToString());
        }

        private void load_data_2_grid(string id_nhan_vien) {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            DataTable v_dt = new DataTable();
            v_ds.Tables.Add(v_dt);
            v_us.FillDatasetWithQuery(v_ds, "select * from v_gd_phu_thuoc_details where DA_XOA = 'N' and id_nhan_vien =" + id_nhan_vien);
            m_grc.DataSource = v_ds.Tables[0];
        }

        private void m_cmd_delete_Click(object sender, EventArgs e)
        {
            try
            {
                var v_confirm = BaseMessages.MsgBox_Confirm("Bạn có chắc chắn muốn xóa người phụ thuộc này?");
                if(v_confirm)
                {
                    var v_dr = m_grv.GetDataRow(m_grv.FocusedRowHandle);
                    US_GD_PHU_THUOC_DETAILS v_us = new US_GD_PHU_THUOC_DETAILS(CIPConvert.ToDecimal(v_dr["ID"].ToString()));
                    v_us.strDA_XOA = "Y";
                    v_us.Update();

                    US_GD_PHU_THUOC v_us_gd_phu_thuoc = new US_GD_PHU_THUOC(Convert.ToDecimal(v_dr["ID_GD_PHU_THUOC"]));
                    v_us_gd_phu_thuoc.dcSO_LUONG--;
                    v_us_gd_phu_thuoc.Update();

                    load_data_2_grid(m_slue_nhan_vien.EditValue.ToString());
                    BaseMessages.MsgBox_Infor("91 - Xóa người phụ thuộc thành công");
                }
            }
            catch(Exception)
            {
                
                throw;
            }
            
            
        }
    }
}
