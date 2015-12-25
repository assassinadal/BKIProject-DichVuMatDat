using BKI_DichVuMatDat.DS;
using BKI_DichVuMatDat.DS.CDBNames;
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

namespace BKI_DichVuMatDat.NghiepVu
{
    public partial class F393_nhan_vien_phu_cap_de : Form
    {
        public F393_nhan_vien_phu_cap_de()
        {
            InitializeComponent();
        }

        private void F393_nhan_vien_phu_cap_de_Load(object sender, EventArgs e)
        {
            try
            {
                load_data_2_sle_nhan_vien();
                load_data_2_sle_quyet_dinh();
                load_data_2_sle_phu_cap();
            }
            catch (Exception v_e)
            {
                IP.Core.IPCommon.CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void load_data_2_sle_phu_cap()
        {
            m_sle_phu_cap.Properties.DataSource = load_data_2_ds_dm_phu_cap().DM_PHU_CAP;
            m_sle_phu_cap.Properties.DisplayMember = DM_PHU_CAP.DOI_TUONG_HUONG_PHU_CAP;
            m_sle_phu_cap.Properties.ValueMember = DM_PHU_CAP.ID;

            m_sle_phu_cap.Properties.PopulateViewColumns();
            m_sle_phu_cap.Properties.View.Columns[DM_PHU_CAP.ID].Visible = false;
            m_sle_phu_cap.Properties.View.Columns[DM_PHU_CAP.ID_LOAI_PHU_CAP].Visible = false;

            m_sle_phu_cap.Properties.View.Columns[DM_PHU_CAP.DOI_TUONG_HUONG_PHU_CAP].Caption = "Đối tượng hưởng phụ cấp";
            m_sle_phu_cap.Properties.View.Columns[DM_PHU_CAP.TI_LE].Caption = "Tỉ lệ";
        }

        private void load_data_2_sle_quyet_dinh()
        {
            m_sle_quyet_dinh.Properties.DataSource = load_data_2_ds_v_gd_quyet_dinh().V_GD_QUYET_DINH;
            m_sle_quyet_dinh.Properties.DisplayMember = V_GD_QUYET_DINH.MA_QUYET_DINH;
            m_sle_quyet_dinh.Properties.ValueMember = V_GD_QUYET_DINH.ID;

            m_sle_quyet_dinh.Properties.PopulateViewColumns();
            m_sle_quyet_dinh.Properties.View.Columns[V_GD_QUYET_DINH.ID].Visible = false;
            m_sle_quyet_dinh.Properties.View.Columns[V_GD_QUYET_DINH.ID_LOAI_QD].Visible = false;
            m_sle_quyet_dinh.Properties.View.Columns[V_GD_QUYET_DINH.MA_TU_DIEN].Visible = false;
            m_sle_quyet_dinh.Properties.View.Columns[V_GD_QUYET_DINH.TEN_NGAN].Visible = false;

            m_sle_quyet_dinh.Properties.View.Columns[V_GD_QUYET_DINH.MA_QUYET_DINH].Caption = "Mã quyết định";
            m_sle_quyet_dinh.Properties.View.Columns[V_GD_QUYET_DINH.TEN].Caption = "Loại quyết định";
            m_sle_quyet_dinh.Properties.View.Columns[V_GD_QUYET_DINH.NGAY_CO_HIEU_LUC].Caption = "Ngày có hiệu lực";
            m_sle_quyet_dinh.Properties.View.Columns[V_GD_QUYET_DINH.NGAY_HET_HIEU_LUC].Caption = "Ngày hết hiệu lực";
            m_sle_quyet_dinh.Properties.View.Columns[V_GD_QUYET_DINH.NGUOI_KY].Caption = "Người ký";
            m_sle_quyet_dinh.Properties.View.Columns[V_GD_QUYET_DINH.NGAY_KY].Caption = "Ngày ký";
            m_sle_quyet_dinh.Properties.View.Columns[V_GD_QUYET_DINH.NOI_DUNG].Caption = "Nội dung";
            m_sle_quyet_dinh.Properties.View.Columns[V_GD_QUYET_DINH.LINK].Caption = "Link";

            m_sle_quyet_dinh.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
        }

        private void load_data_2_sle_nhan_vien()
        {
            m_sle_nhan_vien.Properties.DataSource = load_data_2_ds_v_dm_nv().V_DM_NHAN_VIEN;
            m_sle_nhan_vien.Properties.ValueMember = V_DM_NHAN_VIEN.ID;
            m_sle_nhan_vien.Properties.DisplayMember = V_DM_NHAN_VIEN.HO_TEN;

            m_sle_nhan_vien.Properties.PopulateViewColumns();
            m_sle_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.ID].Visible = false;
            m_sle_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.HO_DEM].Visible = false;
            m_sle_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.TEN].Visible = false;
            m_sle_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.DAN_TOC].Visible = false;
            m_sle_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.CHUYEN_MON].Visible = false;
            m_sle_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.DIA_CHI_TAM_TRU].Visible = false;
            m_sle_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.DIA_CHI_THUONG_TRU].Visible = false;
            m_sle_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.MA_SO_THUE_CA_NHAN].Visible = false;
            m_sle_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.NAM_TOT_NGHIEP].Visible = false;
            m_sle_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.NGAN_HANG].Visible = false;
            m_sle_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.NGAY_CAP].Visible = false;
            m_sle_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.NGAY_CAP_THE].Visible = false;
            m_sle_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.NGAY_CHINH_THUC_TIEP_NHAN].Visible = false;
            m_sle_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.NGAY_HET_HAN_THE].Visible = false;
            m_sle_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.NGAY_TIEP_NHAN_VAO_TCT].Visible = false;
            m_sle_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.NGAY_VAO_HANG_KHONG].Visible = false;
            m_sle_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.NOI_CAP].Visible = false;
            m_sle_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.NOI_SINH].Visible = false;
            m_sle_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.QUE_QUAN].Visible = false;
            m_sle_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.QUOC_TICH].Visible = false;
            m_sle_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.SO_CMT].Visible = false;
            m_sle_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.SO_TAI_KHOAN].Visible = false;
            m_sle_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.TON_GIAO].Visible = false;
            m_sle_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.TOT_NGHIEP_TAI].Visible = false;
            m_sle_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.TRINH_DO_VAN_HOA].Visible = false;
            m_sle_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.NGAY_SINH].Visible = false;
            m_sle_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.HON_NHAN].Visible = false;

            m_sle_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.MA_NV].Width = 75;
            m_sle_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.HO_TEN].Width = 120;

            m_sle_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.MA_NV].Caption = "Mã NV";
            m_sle_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.HO_TEN].Caption = "Họ tên";
            m_sle_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.GIOI_TINH].Caption = "Giới tính";
            m_sle_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.SDT].Caption = "SĐT";
            m_sle_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.EMAIL].Caption = "Email";
            m_sle_nhan_vien.Properties.View.Columns[V_DM_NHAN_VIEN.DIA_CHI_LIEN_LAC].Caption = "Địa chị liên lạc";

            m_sle_nhan_vien.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            m_sle_nhan_vien.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
        }

        private DS_V_DM_NHAN_VIEN load_data_2_ds_v_dm_nv()
        {
            DS_V_DM_NHAN_VIEN v_ds = new DS_V_DM_NHAN_VIEN();
            US_V_DM_NHAN_VIEN v_us = new US_V_DM_NHAN_VIEN();

            v_us.FillDataset(v_ds);
            return v_ds;
        }

        private DS_V_GD_QUYET_DINH load_data_2_ds_v_gd_quyet_dinh()
        {
            US_V_GD_QUYET_DINH v_us = new US_V_GD_QUYET_DINH();
            DS_V_GD_QUYET_DINH v_ds = new DS_V_GD_QUYET_DINH();

            v_us.FillDataset(v_ds);
            return v_ds;
        }

        private DS_DM_PHU_CAP load_data_2_ds_dm_phu_cap()
        {
            US_DM_PHU_CAP v_us = new US_DM_PHU_CAP();
            DS_DM_PHU_CAP v_ds = new DS_DM_PHU_CAP();

            v_us.FillDataset(v_ds);
            return v_ds;
        }

        private void m_cmd_them_Click(object sender, EventArgs e)
        {
            try
            {
                US_GD_NHAN_VIEN_PHU_CAP v_us = new US_GD_NHAN_VIEN_PHU_CAP();
                v_us.dcID_NHAN_VIEN = IP.Core.IPCommon.CIPConvert.ToDecimal(m_sle_nhan_vien.EditValue.ToString());
                v_us.dcID_PHU_CAP = IP.Core.IPCommon.CIPConvert.ToDecimal(m_sle_phu_cap.EditValue);
                if (m_sle_quyet_dinh.EditValue != null)
                {
                    v_us.dcID_QUYET_DINH = IP.Core.IPCommon.CIPConvert.ToDecimal(m_sle_quyet_dinh.EditValue);
                }
                v_us.strDA_XOA = "N";
                
                v_us.Insert();
                IP.Core.IPCommon.BaseMessages.MsgBox_Infor(50);
                DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            catch (Exception v_e)
            {
                IP.Core.IPCommon.CSystemLog_301.ExceptionHandle(v_e);
            }
            
        }

        private void m_cmd_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult = System.Windows.Forms.DialogResult.Cancel;
                this.Close();
            }
            catch (Exception v_e)
            {
                IP.Core.IPCommon.CSystemLog_301.ExceptionHandle(v_e);
            }
        }
    }
}
