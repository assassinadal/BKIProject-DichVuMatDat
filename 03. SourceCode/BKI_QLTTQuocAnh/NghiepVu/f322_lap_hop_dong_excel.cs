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
using IP.Core.IPSystemAdmin;

namespace BKI_DichVuMatDat.NghiepVu
{
    public partial class f322_lap_hop_dong_excel : Form
    {
        public f322_lap_hop_dong_excel()
        {
            InitializeComponent();
            format_control();
        }

        internal void displayToInsertExcel(string m_txt_path)
        {
            WinFormControls.load_xls_to_gridview_v3(m_txt_path, m_grc_lap_hd, "CSDL");
            foreach (DevExpress.XtraGrid.Columns.GridColumn col in ((DevExpress.XtraGrid.Views.Base.ColumnView)m_grc_lap_hd.Views[0]).Columns)
            {
                col.MaxWidth = 100;
                col.MinWidth = 100;

            }
            this.ShowDialog();
        }

        #region members

        decimal m_dc_id_hop_dong_moi_tao = 0;
        string op_str_mess = "";

        #endregion

        #region private methods

        private void format_control()
        {
            set_define_events();
            CenterToScreen();
        }

        private void gan_du_lieu_cho_us_gd_lns(DataRow dataRow)
        {
            US_GD_HE_SO_LNS v_us = new US_GD_HE_SO_LNS();
            //v_us.dcID_HOP_DONG = m_dc_id_hop_dong_moi_tao;
            if (dataRow["NGAY_BAT_DAU"].ToString() != "")
                if ((dataRow["NGAY_BAT_DAU"].ToString() != ""))
                    v_us.datNGAY_BAT_DAU = DateTime.FromOADate(Convert.ToDouble(dataRow["NGAY_BAT_DAU"]));
            if (dataRow["NGAY_KET_THUC"].ToString() != "")
                if ((dataRow["NGAY_KET_THUC"].ToString() != ""))
                    v_us.datNGAY_KET_THUC = DateTime.FromOADate(Convert.ToDouble(dataRow["NGAY_KET_THUC"]));
            v_us.dcHE_SO = find_lns(CIPConvert.ToDecimal(dataRow["CHUC_DANH_LNS"].ToString()), CIPConvert.ToDecimal(dataRow["MUC_LUONG_NS"].ToString()));
            v_us.datNGAY_LAP = DateTime.Now.Date;
            v_us.strNGUOI_LAP = CAppContext_201.getCurrentUserName();
            v_us.Insert();
        }

        private decimal find_lns(decimal ip_dc_id_ma_lns, decimal ip_dc_id_muc_lns)
        {
            US_DM_HE_SO_LUONG_NS v_us = new US_DM_HE_SO_LUONG_NS();
            DS_DM_HE_SO_LUONG_NS v_ds = new DS_DM_HE_SO_LUONG_NS();
            v_us.FillDataset(v_ds);
            string v_str_filter = "ID_MA_LNS = " + ip_dc_id_ma_lns + " AND ID_MUC_LNS = " + ip_dc_id_muc_lns;
            DataRow[] v_dr = v_ds.DM_HE_SO_LUONG_NS.Select(v_str_filter);

            if (v_dr.Count() == 0)
            {
                return 0;
            }
            else
            {
                return CIPConvert.ToDecimal(v_dr.First()["HE_SO"].ToString());
            }
        }

        private void gan_du_lieu_cho_us_gd_lcd(DataRow dataRow)
        {
            //US_GD_LUONG_CHE_DO v_us = new US_GD_LUONG_CHE_DO();
            //v_us.dcID_HOP_DONG = m_dc_id_hop_dong_moi_tao;
            //if (dataRow["NGAY_BAT_DAU"].ToString() != "")
            //    if ((dataRow["NGAY_BAT_DAU"].ToString() != ""))
            //        v_us.datNGAY_BAT_DAU = DateTime.FromOADate(Convert.ToDouble(dataRow["NGAY_BAT_DAU"]));
            //if (dataRow["NGAY_KET_THUC"].ToString() != "")
            //    if ((dataRow["NGAY_KET_THUC"].ToString() != ""))
            //        v_us.datNGAY_KET_THUC = DateTime.FromOADate(Convert.ToDouble(dataRow["NGAY_KET_THUC"]));
            //v_us.dcSO_TIEN = find_lcd(CIPConvert.ToDecimal(dataRow["CHUC_DANH_LCD"].ToString()), CIPConvert.ToDecimal(dataRow["MUC_LCD"].ToString()));
            //v_us.datNGAY_LAP = DateTime.Now.Date;
            //v_us.strNGUOI_LAP = CAppContext_201.getCurrentUserName();
            //v_us.strDA_XOA = "N";
            //v_us.Insert();
        }

        private void gan_du_lieu_cho_us_gd_hop_dong(DataRow dataRow)
        {
            US_GD_HOP_DONG v_us = new US_GD_HOP_DONG();
            v_us.dcID_LOAI_HOP_DONG = CIPConvert.ToDecimal(dataRow["LOAI_HOP_DONG"].ToString());
            if (dataRow["NGAY_BAT_DAU"].ToString() != "")
                if ((dataRow["NGAY_BAT_DAU"].ToString() != ""))
                    v_us.datNGAY_BAT_DAU = DateTime.FromOADate(Convert.ToDouble(dataRow["NGAY_BAT_DAU"]));
            if (dataRow["NGAY_KET_THUC"].ToString() != "")
                if ((dataRow["NGAY_KET_THUC"].ToString() != ""))
                    v_us.datNGAY_KET_THUC = DateTime.FromOADate(Convert.ToDouble(dataRow["NGAY_KET_THUC"]));
            if (dataRow["NGAY_KI_HOP_DONG"].ToString() != "")
                if ((dataRow["NGAY_KI_HOP_DONG"].ToString() != ""))
                    v_us.datNGAY_KY_HOP_DONG = DateTime.FromOADate(Convert.ToDouble(dataRow["NGAY_KI_HOP_DONG"]));
            v_us.dcID_NHAN_VIEN = find_id_nhan_vien_by_ma_nv(dataRow["MA_NHAN_VIEN"].ToString().Trim());
            v_us.datNGAY_LAP = DateTime.Now.Date;
            v_us.strNGUOI_LAP = CAppContext_201.getCurrentUserName();
            v_us.Insert();
            m_dc_id_hop_dong_moi_tao = v_us.dcID;
        }

        private void gan_du_lieu_cho_us_gd_hd_detail(DataRow dataRow)
        {
            US_GD_HS_LNS_LCD v_us = new US_GD_HS_LNS_LCD();
            v_us.dcID_HOP_DONG = m_dc_id_hop_dong_moi_tao;
            v_us.dcID_HS_LNS = find_id_lns(CIPConvert.ToDecimal(dataRow["CHUC_DANH_LNS"].ToString()), CIPConvert.ToDecimal(dataRow["MUC_LUONG_NS"].ToString()));
            v_us.dcID_LCD = find_id_lcd(CIPConvert.ToDecimal(dataRow["CHUC_DANH_LCD"].ToString()), CIPConvert.ToDecimal(dataRow["MUC_LCD"].ToString()));
            v_us.strDA_XOA = "N";
            v_us.datNGAY_LAP = DateTime.Now.Date;
            v_us.strNGUOI_LAP = CAppContext_201.getCurrentUserName();
            v_us.Insert();
        }

        private decimal find_lcd(decimal ip_dc_chuc_danh, decimal ip_dc_muc)
        {
            US_DM_LUONG_CHE_DO v_us = new US_DM_LUONG_CHE_DO();
            DS_DM_LUONG_CHE_DO v_ds = new DS_DM_LUONG_CHE_DO();

            v_us.FillDataset(v_ds);

            string v_str_filter = "ID_MA_LCD = " + ip_dc_chuc_danh + " AND ID_MUC_LCD = " + ip_dc_muc;
            DataRow[] v_dr = v_ds.DM_LUONG_CHE_DO.Select(v_str_filter);

            if (v_dr.Count() == 0)
            {
                return 0;
            }
            else
            {
                return CIPConvert.ToDecimal(v_dr.First()["SO_TIEN"].ToString());
            }
        }

        private decimal find_id_lcd(decimal ip_dc_chuc_danh, decimal ip_dc_muc)
        {
            US_DM_LUONG_CHE_DO v_us = new US_DM_LUONG_CHE_DO();
            DS_DM_LUONG_CHE_DO v_ds = new DS_DM_LUONG_CHE_DO();

            v_us.FillDataset(v_ds);

            string v_str_filter = "ID_MA_LCD = " + ip_dc_chuc_danh + " AND ID_MUC_LCD = " + ip_dc_muc;
            DataRow[] v_dr = v_ds.DM_LUONG_CHE_DO.Select(v_str_filter);
            if (v_dr.Count() == 0)
            {
                return -1;
            }
            else
            {
                return CIPConvert.ToDecimal(v_dr.First()["ID"].ToString());
            }
        }

        private decimal find_id_lns(decimal ip_dc_chuc_danh, decimal ip_dc_muc)
        {
            US_DM_HE_SO_LUONG_NS v_us = new US_DM_HE_SO_LUONG_NS();
            DS_DM_HE_SO_LUONG_NS v_ds = new DS_DM_HE_SO_LUONG_NS();

            v_us.FillDataset(v_ds);

            string v_str_filter = "ID_MA_LNS = " + ip_dc_chuc_danh + " AND ID_MUC_LNS = " + ip_dc_muc;
            DataRow[] v_dr = v_ds.DM_HE_SO_LUONG_NS.Select(v_str_filter);
            if (v_dr.Count() == 0)
            {
                return -1;
            }
            else
            {
                return CIPConvert.ToDecimal(v_dr.First()["ID"].ToString());
            }
        }

        private decimal find_id_hop_by_ma_hop_dong(string ip_str_ma_nv)
        {
            US_GD_HOP_DONG v_us = new US_GD_HOP_DONG();
            DS_GD_HOP_DONG v_ds = new DS_GD_HOP_DONG();

            v_us.FillDataset(v_ds);

            string v_str_filter = "MA_HOP_DONG = '" + ip_str_ma_nv + "'";
            DataRow[] v_dr = v_ds.GD_HOP_DONG.Select(v_str_filter);

            if (v_dr.Count() == 0)
            {
                return -1;
            }
            else
            {
                return CIPConvert.ToDecimal(v_dr.First()["ID"].ToString());
            }
        }

        private decimal find_id_nhan_vien_by_ma_nv(string ip_str_ma_nv)
        {
            US_DM_NHAN_VIEN v_us = new US_DM_NHAN_VIEN();
            DS_DM_NHAN_VIEN v_ds = new DS_DM_NHAN_VIEN();

            v_us.FillDataset(v_ds);

            string v_str_filter = "MA_NV = '" + ip_str_ma_nv + "'";
            DataRow[] v_dr = v_ds.DM_NHAN_VIEN.Select(v_str_filter);

            if (v_dr.Count() == 0)
            {
                return -1;
            }
            else
            {
                return CIPConvert.ToDecimal(v_dr.First()["ID"].ToString());
            }
        }

        private bool check_ma_nhan_vien_is_ok(DataRow dataRow)
        {
            US_DM_NHAN_VIEN v_us = new US_DM_NHAN_VIEN();
            DS_DM_NHAN_VIEN v_ds_nhan_vien = new DS_DM_NHAN_VIEN();
            v_us.FillDataset(v_ds_nhan_vien, " where MA_NV= '" + dataRow["MA_NHAN_VIEN"].ToString() + "'");
            //v_usdc.FillDatasetWithQuery(v_ds_nhan_vien, "select * from DM_NHAN_VIEN where MA_NV=" + dataRow["MA_NV"].ToString());
            if (v_ds_nhan_vien.Tables[0].Rows.Count > 0)
                return true;
            else
            {
                return false;
            }
        }

        private bool checked_du_lieu_is_ok()
        {
            if (m_grv_lap_hd.DataRowCount > 0)
                return true;
            else
                return false;
        }

        private void insert_data(DataRow dataRow)
        {
            US_GD_HOP_DONG v_us = new US_GD_HOP_DONG();
            if(checked_du_lieu_is_ok(dataRow))
            {
                v_us.lap_hop_dong_moi_cho_nhan_vien(find_id_nhan_vien_by_ma_nv(dataRow["MA_NHAN_VIEN"].ToString().Trim())
                    , CIPConvert.ToDecimal(dataRow["LOAI_HOP_DONG"].ToString())
                    , dataRow["MA_HOP_DONG"].ToString()
                    , WinFormControls.FormatPostingDate(dataRow["NGAY_BAT_DAU"].ToString())
                    , WinFormControls.FormatPostingDate(dataRow["NGAY_KET_THUC"].ToString())
                    , WinFormControls.FormatPostingDate(dataRow["NGAY_KI_HOP_DONG"].ToString())
                    //, DateTime.FromOADate(Convert.ToDouble(dataRow["NGAY_BAT_DAU"]))
                    //, DateTime.FromOADate(Convert.ToDouble(dataRow["NGAY_KET_THUC"]))
                    //, DateTime.FromOADate(Convert.ToDouble(dataRow["NGAY_KI_HOP_DONG"]))
                    , DateTime.Now.Date
                    , CAppContext_201.getCurrentUserName()
                    , "N"
                    , CIPConvert.ToDecimal(dataRow["CHUC_DANH_LCD"].ToString())
                    , CIPConvert.ToDecimal(dataRow["MUC_LCD"].ToString())
                    , CIPConvert.ToDecimal(dataRow["CHUC_DANH_LNS"].ToString())
                    , CIPConvert.ToDecimal(dataRow["MUC_LUONG_NS"].ToString())
                    , ref op_str_mess
                    );
            }
            else
            {
                CHRM_BaseMessages.MsgBox_Error("Kiểm tra lại dữ liệu!");
            }
        }

        private bool checked_du_lieu_is_ok(DataRow dataRow)
        {
            return true;
        }

        #endregion

        //EVENTS

        private void set_define_events()
        {
            m_cmd_luu.Click += m_cmd_luu_Click;
        }

        private void m_cmd_luu_Click(object sender, EventArgs e)
        {
            try
            {
                if (checked_du_lieu_is_ok())
                {
                    for (int i = 0; i < m_grv_lap_hd.DataRowCount; i++)
                    {
                        if (check_ma_nhan_vien_is_ok(m_grv_lap_hd.GetDataRow(i)))
                        {
                            //gan_du_lieu_cho_us_gd_hop_dong(m_grv_lap_hd.GetDataRow(i));
                            //gan_du_lieu_cho_us_gd_hd_detail(m_grv_lap_hd.GetDataRow(i));
                            //gan_du_lieu_cho_us_gd_lns(m_grv_lap_hd.GetDataRow(i));
                            //gan_du_lieu_cho_us_gd_lcd(m_grv_lap_hd.GetDataRow(i));
                            insert_data(m_grv_lap_hd.GetDataRow(i));
                            if (op_str_mess != "-1")
                            {
                                CHRM_BaseMessages.MsgBox_Infor("Kiểm tra lại dữ liệu nhân viên " + op_str_mess + ".");
                                return;
                            }
                        }
                        else
                        {
                            if (m_grv_lap_hd.GetDataRow(i)["MA_NHAN_VIEN"].ToString() == "")
                            {
                                CHRM_BaseMessages.MsgBox_Infor(CONST_ID_MSGBOX.INFOR_LUU_DU_LIEU_THANH_CONG);
                                //F503_IMPORT_EXCEL.da_hoan_thanh = true;
                                this.Close();
                                return;
                            }
                            CHRM_BaseMessages.MsgBox_Error("Mã nhân viên " + m_grv_lap_hd.GetDataRow(i)["MA_NHAN_VIEN"].ToString() + "  chưa tồn tại. Vui lòng kiểm tra lại thông tin!");
                            return;
                        }
                    }
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

    }
}
