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
using BKI_DichVuMatDat.US;
using BKI_DichVuMatDat.DS;
using DevExpress.XtraEditors;
using BKI_DichVuMatDat.DTO;
using BKI_DichVuMatDat.DS.CDBNames;
using DevExpress.Utils;

namespace BKI_DichVuMatDat.BaoCao
{
    public partial class f412_rpt_tong_hop_tt_v2 : Form
    {
        #region Public Interface
        public f412_rpt_tong_hop_tt_v2()
        {
            InitializeComponent();
        }
        #endregion

        #region Member
        int m_work_fail = 0;
        int m_tinh_lai = 0;
        #endregion


        #region Private Method
        private decimal lay_thang()
        {
            return Convert.ToDecimal(m_txt_thang.EditValue);
        }
        private decimal lay_nam()
        {
            return Convert.ToDecimal(m_txt_nam.EditValue);
        }
        private void load_data_2_grid()
        {
            CHRMCommon.make_stt(m_adv_tong_hop);
            //US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            //v_us.FillDatasetWithQuery(v_ds, "SELECT * FROM V_RPT_BAO_CAO_TONG_HOP_V2 WHERE THANG = " + lay_thang() + " AND NAM = " + lay_nam() + " order by THU_TU_HIEN_THI, THU_TU_CHUC_VU, THU_TU_HOP_DONG, TEN, HO_DEM");
            US_RPT_THONG_TIN_TONG_HOP_V2 v_us = new US_RPT_THONG_TIN_TONG_HOP_V2();
            v_us.HienThiBaoCao(v_ds, Convert.ToDecimal(m_txt_thang.Text), Convert.ToDecimal(m_txt_nam.Text));

            m_grc_tong_hop.DataSource = v_ds.Tables[0];
            m_grc_tong_hop.RefreshDataSource();
        }
        private DS_RPT_THONG_TIN_TONG_HOP_V2 lay_danh_sach_nhan_vien_can_tong_hop_thong_tin()
        {
            US_RPT_THONG_TIN_TONG_HOP_V2 v_us = new US_RPT_THONG_TIN_TONG_HOP_V2();
            DS_RPT_THONG_TIN_TONG_HOP_V2 v_ds = new DS_RPT_THONG_TIN_TONG_HOP_V2();
            v_us.LayDanhSachNhanVienChuaDuocTongHopThongTin(v_ds, lay_thang(), lay_nam());
            return v_ds;
        }
        private DS_RPT_THONG_TIN_TONG_HOP_V2 lay_tat_ca_nhan_vien_trong_bang_luong()
        {
            US_RPT_THONG_TIN_TONG_HOP_V2 v_us = new US_RPT_THONG_TIN_TONG_HOP_V2();
            DS_RPT_THONG_TIN_TONG_HOP_V2 v_ds = new DS_RPT_THONG_TIN_TONG_HOP_V2();
            v_us.LayDanhSachTatCaNhanVienTongHopThongTin(v_ds, lay_thang(), lay_nam());
            return v_ds;
        }

        private bool check_validate_data_is_ok(string ip_str_thang_cham_cong)
        {
            if(m_txt_thang.EditValue == null || m_txt_nam.EditValue == null)
            {
                CHRM_BaseMessages.MsgBox_Infor(CONST_ID_MSGBOX.ERROR_CHUA_NHAP_THANG_NAM);
                return false;
            }
            else
            {
                for(int i = 0; i < ip_str_thang_cham_cong.Length; i++)
                {
                    if(char.IsDigit(ip_str_thang_cham_cong[i]) == false)
                    {
                        CHRM_BaseMessages.MsgBox_Infor(CONST_ID_MSGBOX.ERROR_DU_LIEU_NHAP_CHUA_HOP_LE);
                        return false;
                    }
                }
                m_work_fail = 1;
                return true;

            }
        }
        public DataRow get_thong_tin_tong_hop_1_nhan_vien_v2(decimal ip_dc_id_nhan_vien, int ip_int_thang, int ip_int_nam)
        {
            US_RPT_THONG_TIN_TONG_HOP_V2 v_us = new US_RPT_THONG_TIN_TONG_HOP_V2();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.LayThongTinTongHopNhanVien(v_ds, ip_dc_id_nhan_vien, ip_int_thang, ip_int_nam);
            DataRow v_dr = v_ds.Tables[0].Rows[0];
            return v_dr;
        }
        public void DataRow2USThongTinTongHopV2(DataRow v_dr_luong_1_nv, US_RPT_THONG_TIN_TONG_HOP_V2 v_us)
        {
            //v_us.dcID = CIPConvert.ToDecimal(v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP_V2_V2.ID].ToString());
            v_us.dcTHANG = Convert.ToDecimal(v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP_V2.THANG]);
            v_us.dcNAM = Convert.ToDecimal(v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP_V2.NAM]);
            v_us.dcID_NHAN_VIEN = (decimal)v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP_V2.ID_NHAN_VIEN];
            v_us.strMA_NV = v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP_V2.MA_NV].ToString();
            v_us.strHO_DEM = v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP_V2.HO_DEM].ToString();
            v_us.strTEN = v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP_V2.TEN].ToString();
            v_us.strHO_VA_TEN = v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP_V2.HO_VA_TEN].ToString();
            v_us.strTEN_CHUC_VU = v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP_V2.TEN_CHUC_VU].ToString();
            v_us.strTEN_HOP_DONG = v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP_V2.TEN_HOP_DONG].ToString();
            v_us.dcLUONG_CHE_DO_THEO_CHUC_VU = (decimal)v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP_V2.LUONG_CHE_DO_THEO_CHUC_VU];
            v_us.dcHS_LUONG_NANG_SUAT_DUOC_HUONG = (decimal)v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP_V2.HS_LUONG_NANG_SUAT_DUOC_HUONG];
            v_us.strTAI_KHOAN = v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP_V2.TAI_KHOAN].ToString();
            v_us.dcCHAM_CONG_X = Convert.ToDecimal(v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP_V2.CHAM_CONG_X]);
            v_us.dcCHAM_CONG_OM_CO = Convert.ToDecimal(v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP_V2.CHAM_CONG_OM_CO]);
            v_us.dcCHAM_CONG_TS = Convert.ToDecimal(v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP_V2.CHAM_CONG_TS]);
            v_us.dcCHAM_CONG_TNLD = Convert.ToDecimal(v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP_V2.CHAM_CONG_TNLD]);
            v_us.dcCHAM_CONG_PHEP_DIDUONG = Convert.ToDecimal(v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP_V2.CHAM_CONG_PHEP_DIDUONG]);
            v_us.dcCHAM_CONG_RO_KO_DC = Convert.ToDecimal(v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP_V2.CHAM_CONG_RO_KO_DC]);
            v_us.dcCHAM_CONG_KHAC = Convert.ToDecimal(v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP_V2.CHAM_CONG_KHAC]);
            v_us.dcHE_SO_K = Convert.ToDecimal(v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP_V2.HE_SO_K]);
            v_us.strDON_VI = v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP_V2.DON_VI].ToString();
            v_us.dcSO_NGAY_LAM_THEM = Convert.ToDecimal(v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP_V2.SO_NGAY_LAM_THEM]);
            v_us.strLOAI_LAO_DONG = v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP_V2.LOAI_LAO_DONG].ToString();
            v_us.dcNGAY_CONG_QUY_DINH = Convert.ToDecimal(v_dr_luong_1_nv[RPT_THONG_TIN_TONG_HOP_V2.NGAY_CONG_QUY_DINH]);
        }
        public void insertThongTinTongHopNV2RPTV2(DataRow v_dr_luong_1_nv)
        {
            US_RPT_THONG_TIN_TONG_HOP_V2 v_us = new US_RPT_THONG_TIN_TONG_HOP_V2();
            DataRow2USThongTinTongHopV2(v_dr_luong_1_nv, v_us);
            v_us.Insert();
        }
        private void tong_hop_bao_cao(DS_RPT_THONG_TIN_TONG_HOP_V2 ip_ds, BackgroundWorker ip_bgw)
        {
            var ip_dt = ip_ds.Tables[0];

            for(int i = 0; i < ip_dt.Rows.Count; i++)
            {
                DataRow v_dr = ip_dt.Rows[i];
                decimal v_id_nhan_vien = CIPConvert.ToDecimal(v_dr["ID_NHAN_VIEN"]);

                //B1: Tong hop thong tin 1 nhan vien
                DataRow v_dr_thong_tin_tong_hop =get_thong_tin_tong_hop_1_nhan_vien_v2(v_id_nhan_vien, (int)lay_thang(), (int)lay_nam());
                //B2: Insert vao Rpt
                insertThongTinTongHopNV2RPTV2(v_dr_thong_tin_tong_hop);
                ip_bgw.ReportProgress((i + 1) * 100 / ip_dt.Rows.Count);
            }
        }

        #endregion

        #region Event Handle
        private void m_bgwk_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                BackgroundWorker worker = sender as BackgroundWorker;
                if(check_validate_data_is_ok(m_txt_thang.Text.Trim()) && check_validate_data_is_ok(m_txt_nam.Text.Trim()))
                {

                    DS_RPT_THONG_TIN_TONG_HOP_V2 v_ds_nv_can_tong_hop;
                    v_ds_nv_can_tong_hop = lay_danh_sach_nhan_vien_can_tong_hop_thong_tin();
                    tong_hop_bao_cao(v_ds_nv_can_tong_hop, worker);
                }
            }
            catch(Exception v_e)
            {
                CHRM_BaseMessages.MsgBox_Infor("Có tý tẹo vấn đề. Bạn chụp ảnh và gửi để chúng tôi hỗ trợ nhé! " + v_e.ToString());
            }
        }

        private void m_bgwk_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            try
            {
                this.m_prb.Text = (e.ProgressPercentage.ToString() + "%");
                this.m_prb.EditValue = e.ProgressPercentage;
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_bgwk_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                this.m_prb.Visible = false;
                this.m_panel.Visible = false;
                if(m_work_fail == 1)
                {
                    load_data_2_grid();
                }

            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void f413_rpt_tong_hop_thong_tin_Load(object sender, EventArgs e)
        {
            try
            {
                m_prb.Visible = false;
                this.m_panel.Visible = false;
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_tinh_Click(object sender, EventArgs e)
        {
            try
            {
                if(m_bgwk.IsBusy)
                {
                    m_bgwk.CancelAsync();
                    return;
                }
                this.m_prb.Visible = true;
                this.m_panel.Visible = true;
                m_bgwk.RunWorkerAsync();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void xoa_bang_tong_hop_thong_tin_thang()
        {
            US_RPT_THONG_TIN_TONG_HOP_V2 v_us = new US_RPT_THONG_TIN_TONG_HOP_V2();
            v_us.XoaToanBoDuLieuTongHop(lay_thang(), lay_nam());
        }
        #endregion

        private void m_cmd_luu_bang_luong_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "xls files (*.xls)|*.xls|All files (*.*)|*.*";
                saveFileDialog1.RestoreDirectory = true;
                if(saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    m_grc_tong_hop.ExportToXls(saveFileDialog1.FileName);
                    CHRM_BaseMessages.MsgBox_Infor(CONST_ID_MSGBOX.INFOR_LUU_BAO_CAO_THANH_CONG);
                }
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private US_RPT_LUONG_V2 transfer_dto_2_us_object(DTO_BANG_LUONG_V2 ip_dto_luong)
        {
            US_RPT_LUONG_V2 v_us_luong_v2 = new US_RPT_LUONG_V2();

            v_us_luong_v2.dcID_NHAN_VIEN = ip_dto_luong.ID_NHAN_VIEN;
            v_us_luong_v2.dcTHANG = ip_dto_luong.THANG;
            v_us_luong_v2.dcNAM = ip_dto_luong.NAM;

            v_us_luong_v2.strMA_NV = ip_dto_luong.MA_NV;

            v_us_luong_v2.dcLUONG_NS = ip_dto_luong.LUONG_NS;
            v_us_luong_v2.dcLUONG_CD = ip_dto_luong.LUONG_CD;
            v_us_luong_v2.dcPHU_CAP_TN = ip_dto_luong.PHU_CAP_TN;
            v_us_luong_v2.dcAN_CA = ip_dto_luong.AN_CA;
            v_us_luong_v2.dcLAM_THEM = ip_dto_luong.LAM_THEM;
            v_us_luong_v2.dcGIAM_TRU_LAM_THEM_200 = ip_dto_luong.LAM_THEM_200;
            v_us_luong_v2.dcGIAM_TRU_LAM_THEM_300 = ip_dto_luong.LAM_THEM_300;
            v_us_luong_v2.dcTHU_NHAP_KHAC_TRONG_LUONG = ip_dto_luong.THU_NHAP_KHAC_TRONG_LUONG;
            v_us_luong_v2.dcTONG_THU_NHAP_TRONG_LUONG = ip_dto_luong.TONG_THU_NHAP_TRONG_LUONG;

            v_us_luong_v2.dcTHUONG = ip_dto_luong.THUONG;
            v_us_luong_v2.dcTHUONG_ATHK = ip_dto_luong.THUONG_ATHK;
            v_us_luong_v2.dcBO_SUNG_LUONG = ip_dto_luong.BO_SUNG_LUONG;
            v_us_luong_v2.dcTHUONG_LE_TET = ip_dto_luong.THUONG_LE_TET;
            v_us_luong_v2.dcTHU_NHAP_KHAC_NGOAI_LUONG = ip_dto_luong.THU_NHAP_KHAC_NGOAI_LUONG;
            v_us_luong_v2.dcTONG_THU_NHAP_NGOAI_LUONG = ip_dto_luong.TONG_THU_NHAP_NGOAI_LUONG;
            v_us_luong_v2.dcTONG_THU_NHAP = ip_dto_luong.TONG_THU_NHAP;

            v_us_luong_v2.dcBHXH = ip_dto_luong.BHXH;
            v_us_luong_v2.dcBHYT = ip_dto_luong.BHYT;
            v_us_luong_v2.dcBHTN = ip_dto_luong.BHTN;
            v_us_luong_v2.dcGIAM_TRU_LAM_THEM_150 = ip_dto_luong.GIAM_TRU_LAM_THEM_150;
            v_us_luong_v2.dcGIAM_TRU_LAM_THEM_200 = ip_dto_luong.GIAM_TRU_LAM_THEM_200;
            v_us_luong_v2.dcGIAM_TRU_LAM_THEM_300 = ip_dto_luong.GIAM_TRU_LAM_THEM_300;
            v_us_luong_v2.dcGIAM_TRU_GIA_CANH = ip_dto_luong.GIAM_TRU_GIA_CANH;
            v_us_luong_v2.dcGIAM_TRU_PHU_THUOC = ip_dto_luong.GIAM_TRU_PHU_THUOC;
            v_us_luong_v2.dcGIAM_TRU_KHAC = ip_dto_luong.GIAM_TRU_KHAC;
            v_us_luong_v2.dcTONG_GIAM_TRU = ip_dto_luong.TONG_GIAM_TRU;

            v_us_luong_v2.dcTHU_NHAP_CHIU_THUE = ip_dto_luong.THU_NHAP_CHIU_THUE;

            v_us_luong_v2.dcDOAN_PHI_CD = ip_dto_luong.DOAN_PHI_CD;
            v_us_luong_v2.dcTHUE = ip_dto_luong.THUE;
            v_us_luong_v2.dcPHAI_NOP_KHAC = ip_dto_luong.PHAI_NOP_KHAC;
            v_us_luong_v2.dcTONG_PHAI_NOP = ip_dto_luong.TONG_PHAI_NOP;

            v_us_luong_v2.dcTHUC_LINH = ip_dto_luong.THUC_LINH;
            v_us_luong_v2.dcSO_TIEN_DA_NOP_THUE = ip_dto_luong.SO_TIEN_DA_NOP_THUE;
            return v_us_luong_v2;
        }
        private DTO_BANG_LUONG_V2 transfer_data_row_db_luong_2_object(DataRow ip_dr_luong)
        {
            DTO_BANG_LUONG_V2 v_dto_luong = new DTO_BANG_LUONG_V2();
            v_dto_luong.ID_NHAN_VIEN = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.ID_NHAN_VIEN]);
            v_dto_luong.THANG = lay_thang();
            v_dto_luong.NAM = lay_nam();

            v_dto_luong.MA_NV = ip_dr_luong[RPT_LUONG_V2.MA_NV].ToString();

            v_dto_luong.LUONG_NS = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.LUONG_NS]);
            v_dto_luong.LUONG_CD = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.LUONG_CD]);
            v_dto_luong.PHU_CAP_TN = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.PHU_CAP_TN]);
            v_dto_luong.AN_CA = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.AN_CA]);
            v_dto_luong.LAM_THEM = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.LAM_THEM]);
            v_dto_luong.LAM_THEM_200 = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.LAM_THEM_200]);
            v_dto_luong.LAM_THEM_300 = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.LAM_THEM_300]);
            v_dto_luong.THU_NHAP_KHAC_TRONG_LUONG = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.THU_NHAP_KHAC_TRONG_LUONG]);
            v_dto_luong.TONG_THU_NHAP_TRONG_LUONG = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.TONG_THU_NHAP_TRONG_LUONG]);

            v_dto_luong.THUONG = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.THUONG]);
            v_dto_luong.THUONG_ATHK = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.THUONG_ATHK]);
            v_dto_luong.BO_SUNG_LUONG = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.BO_SUNG_LUONG]);
            v_dto_luong.THUONG_LE_TET = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.THUONG_LE_TET]);
            v_dto_luong.THU_NHAP_KHAC_NGOAI_LUONG = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.THU_NHAP_KHAC_NGOAI_LUONG]);
            v_dto_luong.TONG_THU_NHAP_NGOAI_LUONG = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.TONG_THU_NHAP_NGOAI_LUONG]);
            v_dto_luong.TONG_THU_NHAP = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.TONG_THU_NHAP]);

            v_dto_luong.BHXH = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.BHXH]);
            v_dto_luong.BHYT = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.BHYT]);
            v_dto_luong.BHTN = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.BHTN]);
            v_dto_luong.GIAM_TRU_LAM_THEM_150 = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.GIAM_TRU_LAM_THEM_150]);
            v_dto_luong.GIAM_TRU_LAM_THEM_200 = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.GIAM_TRU_LAM_THEM_200]);
            v_dto_luong.GIAM_TRU_LAM_THEM_300 = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.GIAM_TRU_LAM_THEM_300]);
            v_dto_luong.GIAM_TRU_GIA_CANH = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.GIAM_TRU_GIA_CANH]);
            v_dto_luong.GIAM_TRU_PHU_THUOC = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.GIAM_TRU_PHU_THUOC]);
            v_dto_luong.GIAM_TRU_KHAC = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.GIAM_TRU_KHAC]);
            v_dto_luong.TONG_GIAM_TRU = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.TONG_GIAM_TRU]);

            v_dto_luong.THU_NHAP_CHIU_THUE = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.THU_NHAP_CHIU_THUE]);

            v_dto_luong.DOAN_PHI_CD = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.DOAN_PHI_CD]);
            v_dto_luong.THUE = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.THUE]);
            v_dto_luong.PHAI_NOP_KHAC = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.PHAI_NOP_KHAC]);
            v_dto_luong.TONG_PHAI_NOP = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.TONG_PHAI_NOP]);

            v_dto_luong.THUC_LINH = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.THUC_LINH]);
            v_dto_luong.SO_TIEN_DA_NOP_THUE = Convert.ToDecimal(ip_dr_luong[RPT_LUONG_V2.SO_TIEN_DA_NOP_THUE]);
            return v_dto_luong;
        }
        public DataRow get_luong_1_nhan_vien_v2(decimal ip_dc_id_nhan_vien, int ip_int_thang, int ip_int_nam)
        {
            US_RPT_LUONG_V2 v_us = new US_RPT_LUONG_V2();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.TaoBangLuongNhanVien(v_ds, ip_dc_id_nhan_vien, ip_int_thang, ip_int_nam);
            DataRow v_dr = v_ds.Tables[0].Rows[0];
            return v_dr;
        }
        public void insertThongTinTongHopNV2RPTV2(DataRow v_dr_luong_1_nv, US_RPT_LUONG_V2 ip_us_trans)
        {
            US_RPT_THONG_TIN_TONG_HOP_V2 v_us = new US_RPT_THONG_TIN_TONG_HOP_V2();
            DataRow2USThongTinTongHopV2(v_dr_luong_1_nv, v_us);
            v_us.UseTransOfUSObject(ip_us_trans);
            v_us.Insert();
        }
        private void m_cmd_tinh_lai_nhan_vien_Click(object sender, EventArgs e)
        {
            try
            {
                if(m_adv_tong_hop.FocusedRowHandle < 0)
                {
                    XtraMessageBox.Show("Chọn nhân viên trước để tính lại lương!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                decimal v_id_nhan_vien = Convert.ToDecimal(m_adv_tong_hop.GetRowCellValue(m_adv_tong_hop.FocusedRowHandle, "ID_NHAN_VIEN"));
                DataRow v_dr_luong_nv = get_luong_1_nhan_vien_v2(v_id_nhan_vien, (int)lay_thang(), (int)lay_nam());
                DTO_BANG_LUONG_V2 v_dto_luong = transfer_data_row_db_luong_2_object(v_dr_luong_nv);
                var v_us_rpt_luong_v2 = transfer_dto_2_us_object(v_dto_luong);

                v_us_rpt_luong_v2.BeginTransaction();
                v_us_rpt_luong_v2.XoaBangLuongNhanVien(v_id_nhan_vien, lay_thang(), lay_nam());
                v_us_rpt_luong_v2.Insert();

                //B2: Insert vao Rpt
                DataRow v_dr_thong_tin_tong_hop = get_thong_tin_tong_hop_1_nhan_vien_v2(v_id_nhan_vien, (int)lay_thang(), (int)lay_nam());
                insertThongTinTongHopNV2RPTV2(v_dr_thong_tin_tong_hop, v_us_rpt_luong_v2);
                v_us_rpt_luong_v2.CommitTransaction();

                load_data_2_grid();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }

        }

        private void m_adv_tong_hop_MouseWheel(object sender, MouseEventArgs e)
        {
            try
            {
                m_adv_tong_hop.TopRowIndex += e.Delta > 0 ? -3 : 3;
                ((DXMouseEventArgs)e).Handled = true;
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }

        }

        private void m_cmd_tinh_lai_cham_cong_Click(object sender, EventArgs e)
        {
            try
            {
                if(m_bgwk.IsBusy)
                {
                    m_bgwk.CancelAsync();
                    return;
                }
                this.m_prb.Visible = true;
                this.m_panel.Visible = true;
                var v_dlg_confirm = XtraMessageBox.Show("Bạn có chắc chắn muốn tính lại dữ liệu chấm công?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(v_dlg_confirm == System.Windows.Forms.DialogResult.No)
                {
                    XtraMessageBox.Show("Bạn đã hủy thao tác!","THÔNG BÁO",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                xoa_bang_tong_hop_thong_tin_thang();
                m_bgwk.RunWorkerAsync();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            load_data_2_grid();
        }
    }
}
