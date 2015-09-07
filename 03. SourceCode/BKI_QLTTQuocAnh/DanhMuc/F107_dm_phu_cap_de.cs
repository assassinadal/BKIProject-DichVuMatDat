using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BKI_DichVuMatDat.DS;
using BKI_DichVuMatDat.DS.CDBNames;
using BKI_DichVuMatDat.US;
using DevExpress.XtraEditors;
using IP.Core.IPCommon;


namespace BKI_DichVuMatDat.DanhMuc
{
    public partial class F107_dm_phu_cap_de : Form
    {
        public F107_dm_phu_cap_de()
        {
            InitializeComponent();
            format_controls();
        }

        #region Public Interface
        public void display_4_insert(ref decimal v_id_dm_phu_cap_moi_tao)
        {
            this.Text = "F107 - Thêm loại phụ cấp mới";
            m_lbl_header.Text = "THÊM LOẠI PHỤ CẤP MỚI";
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            this.CenterToScreen();
            this.ShowDialog();
            v_id_dm_phu_cap_moi_tao = m_id_dm_phu_cap_moi_tao;
        }

        public void display_4_update(US_DM_PHU_CAP ip_us)
        {
            this.Text = "F107 - Sửa loại phụ cấp";
            m_lbl_header.Text = "SỬA LOẠI PHỤ CẤP";
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            m_id_dm_phu_cap_4_update = ip_us.dcID;
            //m_txt_loai_phu_cap.Text = ip_us.strTEN;
            m_txt_doi_tuong_huong.Text = ip_us.strDOI_TUONG_HUONG_PHU_CAP;
            m_txt_ti_le.Text = ip_us.dcTI_LE.ToString();
            this.CenterToScreen();
            this.ShowDialog();
        }
        #endregion

        #region Members
        DataEntryFormMode m_e_form_mode = DataEntryFormMode.InsertDataState;
        decimal m_id_dm_phu_cap_4_update = 0;
        decimal m_id_dm_phu_cap_moi_tao = 0;
        #endregion

        #region Private methods
        private void format_controls()
        {
            set_define_events();
            this.KeyPreview = true;
        }

        private void set_initial_form_load()
        {

        }

        private bool check_validate_data()
        {
            if (m_txt_loai_phu_cap.Text.Trim() == "")
            {
                XtraMessageBox.Show("Bạn chưa nhập tên loại phụ cấp!");
                return false;
            }
            if (m_txt_doi_tuong_huong.Text.Trim() == "")
            {
                XtraMessageBox.Show("Bạn chưa nhập đối tượng hưởng!");
                return false;
            }
            if (m_txt_ti_le.Text.Trim() == "")
            {
                XtraMessageBox.Show("Bạn chưa nhập tỉ lệ!");
                return false;
            }
            return true;
        }

        //save data
        private void form_2_us_obj(US_DM_PHU_CAP ip_us)
        {
            //ip_us.strTEN = m_txt_loai_phu_cap.Text.Trim();
            ip_us.strDOI_TUONG_HUONG_PHU_CAP = m_txt_doi_tuong_huong.Text.Trim();
            ip_us.dcTI_LE = CIPConvert.ToDecimal(m_txt_ti_le.Text.Trim());
        }

        private void save_data()
        {
            US_DM_PHU_CAP v_us_dm_phu_cap = new US_DM_PHU_CAP();
            form_2_us_obj(v_us_dm_phu_cap);

            try
            {
                switch (m_e_form_mode)
                {
                    case DataEntryFormMode.InsertDataState:
                        v_us_dm_phu_cap.BeginTransaction();
                        v_us_dm_phu_cap.Insert();
                        v_us_dm_phu_cap.CommitTransaction();
                        m_id_dm_phu_cap_moi_tao = v_us_dm_phu_cap.dcID;
                        if (XtraMessageBox.Show("Bạn đã thêm loại phụ cấp thành công! Bạn có muốn thêm tham số khác không?", "THÀNH CÔNG", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            refresh_form();
                        }
                        else
                        {
                            this.Close();
                        }
                        break;
                    case DataEntryFormMode.UpdateDataState:
                        v_us_dm_phu_cap.dcID = m_id_dm_phu_cap_4_update;
                        v_us_dm_phu_cap.BeginTransaction();
                        v_us_dm_phu_cap.Update();
                        v_us_dm_phu_cap.CommitTransaction();
                        XtraMessageBox.Show("Bạn đã cập nhật đơn vị thành công!", "THÀNH CÔNG");
                        this.Close();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception v_e)
            {
                throw v_e;
            }
        }

        private void refresh_form()
        {
            m_txt_loai_phu_cap.Text = "";
            m_txt_doi_tuong_huong.Text = "";
            m_txt_ti_le.BackColor = Color.White;
        }
        #endregion
        private void set_define_events()
        {
            this.Load += F107_dm_phu_cap_de_Load;
            m_cmd_save.Click += m_cmd_save_Click;
            m_cmd_exit.Click += m_cmd_exit_Click;
            this.KeyDown += F107_dm_phu_cap_de_KeyDown;
        }
        void F107_dm_phu_cap_de_Load(object sender, EventArgs e)
        {
            try
            {
                set_initial_form_load();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (check_validate_data())
                {
                    if (XtraMessageBox.Show("Bạn có chắc chắn muốn lưu loại phụ cấp này?", "XÁC NHẬN LẠI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        save_data();
                    }
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_exit_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void F107_dm_phu_cap_de_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
                {
                    this.Close();
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

    }
}
