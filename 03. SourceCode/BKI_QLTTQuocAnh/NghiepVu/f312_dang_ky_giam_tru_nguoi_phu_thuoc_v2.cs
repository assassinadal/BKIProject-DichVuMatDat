using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BKI_DichVuMatDat.US;
using BKI_DichVuMatDat.DS;
using BKI_DichVuMatDat.DS.CDBNames;
using IP.Core.IPCommon;
using System.IO;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraPivotGrid;
using IP.Core.IPSystemAdmin;
using DevExpress.XtraSplashScreen;

namespace BKI_DichVuMatDat.NghiepVu
{
    public partial class f312_dang_ky_giam_tru_nguoi_phu_thuoc_v2 : Form
    {
        List<decimal> m_lst_nv_insert_phu_thuoc = new List<decimal>();
        public f312_dang_ky_giam_tru_nguoi_phu_thuoc_v2()
        {
            InitializeComponent();
        }

        private void m_cmd_tai_file_mau_Click(object sender, EventArgs e)
        {
            try
            {
                WinFormControls.openTemplate("DangKyPhuThuoc.xlsx");
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void f312_dang_ky_giam_tru_nguoi_phu_thuoc_v2_Load(object sender, EventArgs e)
        {
            m_lbl_nam_tinh_thue.Text = DateTime.Now.Year.ToString();
            load_data_to_grid();
        }

        //private void load_data_to_m_sle_chon_nhan_vien()
        //{
        //    m_sle_chon_nhan_vien.Properties.DataSource = load_data_to_ds_v_dm_nv().Tables[0];
        //    m_sle_chon_nhan_vien.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
        //    m_sle_chon_nhan_vien.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
        //}

        private DataSet load_data_to_ds_v_dm_nv()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithTableName(v_ds, "V_DM_NHAN_VIEN");
            return v_ds;
        }

        private void m_cmd_import_excel_Click(object sender, EventArgs e)
        {
            m_grc.DataSource = null;
            try
            {
                WinFormControls.load_xls_to_gridview(WinFormControls.openFileDialog(), m_grc);
                m_cmd_save.Enabled = true;
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_save_Click(object sender, EventArgs e)
        {
            m_lst_nv_insert_phu_thuoc.Clear();            
            try
            {
                SplashScreenManager.ShowForm(typeof(BKI_DichVuMatDat.BaoCao.F_wait_form));
                insert_gd_phu_thuoc_details();
                for (int i = 0; i < m_lst_nv_insert_phu_thuoc.Count; i++)
                {
                    update_gd_phu_thuoc(m_lst_nv_insert_phu_thuoc[i]);
                }
                m_cmd_save.Enabled = false;
                XtraMessageBox.Show("Lưu thành công");
                //List<decimal> v_lst_nv_thay_doi = gd_phu_thuoc_thay_doi_yn(m_lst_nv_insert_phu_thuoc);
                //if (v_lst_nv_thay_doi.Count !=0)
                //{
                    //DialogResult v_dialog = XtraMessageBox.Show("Số lượng người phụ thuộc của một vài nhân viên đã thay đổi. Sau khi thêm danh sách phụ thuộc thành công, bạn có muốn cập nhật số lượng mới cùng lúc không? ", "Xác nhận", MessageBoxButtons.YesNo);
                    //if (v_dialog == DialogResult.Yes)
                    //{
                    //    for (int i = 0; i < v_lst_nv_thay_doi.Count; i++)
                    //    {
                    //        update_gd_phu_thuoc(v_lst_nv_thay_doi[i]);
                    //    }
                    //    XtraMessageBox.Show("Lưu thành công");
                    ////}                 
                    //m_cmd_save.Enabled = false;
                    
                //}                             
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }           
        }

        //private List<decimal> gd_phu_thuoc_thay_doi_yn(List<decimal> m_lst_nv_insert_phu_thuoc)
        //{
        //    List<decimal> v_lst_nv_thay_doi = new List<decimal>();
        //    for (int i = 0; i < m_lst_nv_insert_phu_thuoc.Count; i++)
        //    {
        //        DS_GD_PHU_THUOC v_ds = new DS_GD_PHU_THUOC();
        //        US_GD_PHU_THUOC v_us = new US_GD_PHU_THUOC();
        //        v_us.FillDataset(v_ds, "where da_xoa = 'N' and id_nhan_vien=" + m_lst_nv_insert_phu_thuoc[i]);
        //        int v_slg_phu_thuoc_details = get_so_luong_phu_thuoc_details(m_lst_nv_insert_phu_thuoc[i]);
        //        DataTable v_dt = v_ds.Tables[0];
        //        if (v_dt.Rows.Count == 0 || (CIPConvert.ToDecimal(v_dt.Rows[0][2].ToString()) < v_slg_phu_thuoc_details))
        //        {
        //            v_lst_nv_thay_doi.Add(m_lst_nv_insert_phu_thuoc[i]);
        //        }
        //    }
        //    return v_lst_nv_thay_doi;
        //}

        private void update_gd_phu_thuoc(decimal ip_dc_id_nv)
        {
            int v_slg_phu_thuoc_details = get_so_luong_phu_thuoc_details(ip_dc_id_nv);
            DS_GD_PHU_THUOC v_ds = new DS_GD_PHU_THUOC();
            US_GD_PHU_THUOC v_us = new US_GD_PHU_THUOC();
            v_us.FillDatasetPhuThuoc(v_ds, ip_dc_id_nv);
            if (v_ds.Tables[0].Rows.Count == 0)
            {
                v_us.dcID_NHAN_VIEN = ip_dc_id_nv;
                v_us.dcSO_LUONG = CIPConvert.ToDecimal(v_slg_phu_thuoc_details);
                v_us.strNGUOI_LAP = CAppContext_201.getCurrentUserName();
                v_us.strDA_XOA = "N";
                v_us.Insert();
            }
            else
            {
                US_GD_PHU_THUOC v_us_gd_phu_thuoc = new US_GD_PHU_THUOC(CIPConvert.ToDecimal(v_ds.Tables[0].Rows[0][0]));
                v_us_gd_phu_thuoc.dcSO_LUONG = CIPConvert.ToDecimal(v_slg_phu_thuoc_details);
                v_us_gd_phu_thuoc.Update();
            }
        }

        private int get_so_luong_phu_thuoc_details(decimal ip_dc_id_nv)
        {
            DS_GD_PHU_THUOC_DETAILS v_ds = new DS_GD_PHU_THUOC_DETAILS();
            US_GD_PHU_THUOC_DETAILS v_us = new US_GD_PHU_THUOC_DETAILS();
            v_us.FillDatasetSoLuongPhuThuocDetails(v_ds, ip_dc_id_nv );
            return v_ds.Tables[0].Rows.Count;
        }

        private void insert_gd_phu_thuoc_details()
        {
            for (int i = 0; i < m_grv1.RowCount; i++)
            {
                try
                {
                    US_GD_PHU_THUOC_DETAILS v_us = new US_GD_PHU_THUOC_DETAILS();
                    var v_dr = m_grv1.GetDataRow(i);
                    v_us.dcID_GD_PHU_THUOC = get_id_by_ma_nhan_vien(v_dr[0].ToString());
                    v_us.strHO_TEN_NGUOI_PHU_THUOC = v_dr[3].ToString();
                    v_us.datNGAY_SINH = DateTime.Parse(v_dr[4].ToString());
                    v_us.strMA_SO_THUE = v_dr[5].ToString();
                    v_us.strQUOC_TICH = v_dr[6].ToString();
                    v_us.strSO_CMT_HO_CHIEU = v_dr[7].ToString();
                    v_us.strQUAN_HE_VOI_NGUOI_NOP_THUE = v_dr[8].ToString();
                    v_us.strTTGKS_SO = v_dr[9].ToString();
                    v_us.strTTGKS_QUYEN = v_dr[10].ToString();
                    v_us.strTTGKS_QUOC_GIA = v_dr[11].ToString();
                    v_us.strTTGKS_TINH_THANH = v_dr[12].ToString();
                    v_us.strTTGKS_QUAN_HUYEN = v_dr[13].ToString();
                    v_us.strTTGKS_PHUONG_XA = v_dr[14].ToString();
                    v_us.datTU_NGAY = DateTime.Parse(v_dr[15].ToString());
                    v_us.strNGUOI_LAP = CAppContext_201.getCurrentUserName();
                    v_us.datNGAY_LAP = DateTime.Now;
                    v_us.strDA_XOA = "N";
                    v_us.Insert();
                }
                catch (Exception v_e)
                {
                    CSystemLog_301.ExceptionHandle(v_e);
                }
            }
        }
      

        private decimal get_id_by_ma_nhan_vien(string ip_str_ma_nv)
        {
            //US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            //DataSet v_ds = new DataSet();
            //v_ds.Tables.Add(new DataTable());
            //v_us.FillDatasetWithQuery(v_ds, "select * from dm_nhan_vien where ma_nv = '" + ip_str_ma_nv + "'");
            DS_DM_NHAN_VIEN v_ds = new DS_DM_NHAN_VIEN();
            US_DM_NHAN_VIEN v_us = new US_DM_NHAN_VIEN();
            v_us.FillDataset(v_ds);
            decimal v_id_nv = v_us.getIDNhanVienByMaNV(ip_str_ma_nv);
            //decimal v_id_nv =  CIPConvert.ToDecimal( v_ds.Tables[0].Rows[0][0].ToString());
            if (!m_lst_nv_insert_phu_thuoc.Contains(v_id_nv))
            {
                m_lst_nv_insert_phu_thuoc.Add(v_id_nv); 
            }            
            return v_id_nv;
        }


        private void load_data_to_grid()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithTableName(v_ds, "V_GD_PHU_THUOC_DETAILS_V2");
            m_grc.DataSource = v_ds.Tables[0];
        }

        private void m_cmd_delete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult v_dialog = MessageBox.Show("Việc xóa có thể sẽ làm thay đổi số lượng người phụ thuộc của nhân viên. Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo);
                if (v_dialog == DialogResult.Yes)
                {
                    var v_dr = m_grv1.GetDataRow(m_grv1.FocusedRowHandle);
                    US_GD_PHU_THUOC_DETAILS v_us = new US_GD_PHU_THUOC_DETAILS(CIPConvert.ToDecimal(v_dr[3].ToString()));
                    v_us.Delete();
                    update_gd_phu_thuoc(CIPConvert.ToDecimal(v_dr[4].ToString()));
                    XtraMessageBox.Show("Xóa thành công!");
                    load_data_to_grid();
                }              
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }           
        }
    }
}
