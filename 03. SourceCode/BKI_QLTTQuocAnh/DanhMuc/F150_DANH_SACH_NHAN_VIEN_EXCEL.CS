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

namespace BKI_DichVuMatDat
{
    public partial class F150_DANH_SACH_NHAN_VIEN_EXCEL : Form
    {
        public F150_DANH_SACH_NHAN_VIEN_EXCEL()
        {
            InitializeComponent();
        }

        #region Public interface
        internal void displayToInsertExcel(string m_txt_path)
        {
            WinFormControls.load_xls_to_gridview(m_txt_path, m_grc);
            foreach (DevExpress.XtraGrid.Columns.GridColumn col in ((DevExpress.XtraGrid.Views.Base.ColumnView)m_grc.Views[0]).Columns)
            {
                col.MaxWidth = 100;
                col.MinWidth = 100;

            }
            this.ShowDialog();
        }
        #endregion

        #region Members

        #endregion

        #region Private Methods
        private void m_cmd_luu_Click(object sender, EventArgs e)
        {
            try
            {
                if (checked_du_lieu_is_ok())
                {
                    for (int i = 0; i < m_grv.DataRowCount; i++)
                    {
                        if (check_ma_nhan_vien_is_ok(m_grv.GetDataRow(i)))
                        {
                            gan_du_lieu_cho_us_dm_nhan_vien(m_grv.GetDataRow(i));
                        }
                        else
                        {
                            CHRM_BaseMessages.MsgBox_Error("Mã nhân viên " + m_grv.GetDataRow(i)["MA_NV"].ToString() + "  đã tồn tại. Vui lòng kiểm tra lại thông tin!");
                        }

                    }

                    CHRM_BaseMessages.MsgBox_Infor(CONST_ID_MSGBOX.INFOR_LUU_DU_LIEU_THANH_CONG);
                    this.Close();
                }
                else
                {
                    CHRM_BaseMessages.MsgBox_Error("Kiểm tra lại dữ liệu!");
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
            

        }

        private void gan_du_lieu_cho_us_dm_nhan_vien(DataRow dataRow)
        {
            US_DM_NHAN_VIEN v_us = new US_DM_NHAN_VIEN();
            if (dataRow["NGAY_CAP"].ToString() != "")
                if ((dataRow["NGAY_CAP"].ToString().Substring(0, 10) != ""))
                    v_us.datNGAY_CAP = CIPConvert.ToDatetime(dataRow["NGAY_CAP"].ToString().Substring(0, 10));
            if (dataRow["NGAY_CAP_THE"].ToString() != "")
                if ((dataRow["NGAY_CAP_THE"].ToString().Substring(0, 10) != ""))
                    v_us.datNGAY_CAP_THE = CIPConvert.ToDatetime(dataRow["NGAY_CAP_THE"].ToString().Substring(0, 10));
            if (dataRow["NGAY_CHINH_THUC_TIEP_NHAN"].ToString() != "")
                if ((dataRow["NGAY_CHINH_THUC_TIEP_NHAN"].ToString().Substring(0, 10) != ""))
                    v_us.datNGAY_CHINH_THUC_TIEP_NHAN = CIPConvert.ToDatetime(dataRow["NGAY_CHINH_THUC_TIEP_NHAN"].ToString().Substring(0, 10));
            if (dataRow["NGAY_HET_HAN_THE"].ToString() != "")
                if ((dataRow["NGAY_HET_HAN_THE"].ToString().Substring(0, 10) != ""))
                    v_us.datNGAY_HET_HAN_THE = CIPConvert.ToDatetime(dataRow["NGAY_HET_HAN_THE"].ToString().Substring(0, 10));
            if (dataRow["NGAY_SINH"].ToString() != "")
                if ((dataRow["NGAY_SINH"].ToString().Substring(0, 10) != ""))
                    v_us.datNGAY_SINH = CIPConvert.ToDatetime(dataRow["NGAY_SINH"].ToString().Substring(0, 10));
            if (dataRow["NGAY_TIEP_NHAN_VAO_TCT"].ToString() != "")
                if ((dataRow["NGAY_TIEP_NHAN_VAO_TCT"].ToString().Substring(0, 10) != ""))
                    v_us.datNGAY_TIEP_NHAN_VAO_TCT = CIPConvert.ToDatetime(dataRow["NGAY_TIEP_NHAN_VAO_TCT"].ToString().Substring(0, 10));
            if (dataRow["NGAY_VAO_HANG_KHONG"].ToString() != "")
                if ((dataRow["NGAY_VAO_HANG_KHONG"].ToString().Substring(0, 10) != ""))
                    v_us.datNGAY_VAO_HANG_KHONG = CIPConvert.ToDatetime(dataRow["NGAY_VAO_HANG_KHONG"].ToString().Substring(0, 10));
            v_us.strCHUYEN_MON = dataRow["CHUYEN_MON"].ToString();
            v_us.strDAN_TOC = dataRow["DAN_TOC"].ToString();
            v_us.strDIA_CHI_LIEN_LAC = dataRow["DIA_CHI_LIEN_LAC"].ToString();
            v_us.strDIA_CHI_TAM_TRU = dataRow["DIA_CHI_TAM_TRU"].ToString();
            v_us.strDIA_CHI_THUONG_TRU = dataRow["DIA_CHI_THUONG_TRU"].ToString();
            v_us.strEMAIL = dataRow["EMAIL"].ToString();
            v_us.strGIOI_TINH = dataRow["GIOI_TINH"].ToString();
            v_us.strHO_DEM = dataRow["HO_DEM"].ToString();
            v_us.strHON_NHAN = dataRow["HON_NHAN"].ToString();
            v_us.strMA_NV = dataRow["MA_NV"].ToString();
            v_us.strMA_SO_THUE_CA_NHAN = dataRow["MA_SO_THUE_CA_NHAN"].ToString();
            v_us.strNAM_TOT_NGHIEP = dataRow["NAM_TOT_NGHIEP"].ToString();
            v_us.strNGAN_HANG = dataRow["NGAN_HANG"].ToString();
            v_us.strNOI_CAP = dataRow["NOI_CAP"].ToString();
            v_us.strNOI_SINH = dataRow["NOI_SINH"].ToString();
            v_us.strQUE_QUAN = dataRow["QUE_QUAN"].ToString();
            v_us.strQUOC_TICH = dataRow["QUOC_TICH"].ToString();
            v_us.strSDT = dataRow["SDT"].ToString();
            v_us.strSO_CMT = dataRow["SO_CMT"].ToString();
            v_us.strSO_TAI_KHOAN = dataRow["SO_TAI_KHOAN"].ToString();
            v_us.strTEN = dataRow["TEN"].ToString();
            v_us.strTON_GIAO = dataRow["TON_GIAO"].ToString();
            v_us.strTOT_NGHIEP_TAI = dataRow["TOT_NGHIEP_TAI"].ToString();
            v_us.strTRINH_DO_VAN_HOA = dataRow["TRINH_DO_VAN_HOA"].ToString();
            v_us.Insert();
        }

        private bool check_ma_nhan_vien_is_ok(DataRow dataRow)
        {
            //US_DUNG_CHUNG v_usdc = new US_DUNG_CHUNG();
            //DataSet v_ds_nhan_vien = new DataSet();
            //v_ds_nhan_vien.Tables.Add(new DataTable());

            US_DM_NHAN_VIEN v_us = new US_DM_NHAN_VIEN();
            DS_DM_NHAN_VIEN v_ds_nhan_vien = new DS_DM_NHAN_VIEN();
            v_us.FillDataset(v_ds_nhan_vien, " where MA_NV= '" + dataRow["MA_NV"].ToString() + "'");
            //v_usdc.FillDatasetWithQuery(v_ds_nhan_vien, "select * from DM_NHAN_VIEN where MA_NV=" + dataRow["MA_NV"].ToString());
            if(v_ds_nhan_vien.Tables[0].Rows.Count > 0)
                return false;
            else
            {
                return true;
            }
        }

        private bool checked_du_lieu_is_ok()
        {// chưa check, mới check số dòng >0
            if (m_grv.DataRowCount > 0)
                return true;
            else
                return false;
        }

        #endregion
    }
}
