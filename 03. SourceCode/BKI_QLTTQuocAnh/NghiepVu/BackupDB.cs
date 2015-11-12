using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IP.Core.IPCommon;
using System.Data.SqlClient;
using System.Configuration;
using BKI_DichVuMatDat.EF;
using BKI_DichVuMatDat.US;

namespace BKI_DichVuMatDat.NghiepVu
{
    public partial class BackupDB : Form
    {
        private BKI_DVMDEntities context;
        SqlConnection conn;
        SqlCommand command;
        SqlDataReader reader;
        string sql = "";

        private string DB_NAME;
        private string DISK_LOCATION;
        private string CONNECTION_STRING;


        public BackupDB()
        {
            InitializeComponent();
            format_control();
            get_data_from_app_config();
        }
        private void format_control()
        {
            set_define_events();
        }

        #region Private Methods
        private void get_data_from_app_config()
        {
            var reader = new System.Configuration.AppSettingsReader();
            DB_NAME = reader.GetValue("INITIAL_DATABASE", typeof(string)).ToString();
            DISK_LOCATION = reader.GetValue("DISK_LOCATION", typeof(string)).ToString();
            CONNECTION_STRING = ConfigurationManager.ConnectionStrings["BKI_DichVuMatDat.Properties.Settings.BKI_DVMDConnectionString"].ConnectionString;
        }
        private void set_intial_form_load()
        {
            m_cmd_add_new_back_up.Visible = false;
            m_cmd_backup.Visible = true;
            m_txt_ten_file.Text = gen_name_back_up_db();
            m_txt_location.Text = gen_name_disk_location_back_up();
            fill_data_2_grid();
        }

        private void choose_file_restore()
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Backup Files(*.bak)|*.bak|All Files(*.*)|*.*";
            dlg.FilterIndex = 0;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                m_txt_backup_path.Text = dlg.FileName;
            }
        }
        private void choose_file_backup()
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                m_txt_location.Text = dlg.SelectedPath;
            }
            m_txt_ten_file.Text = DB_NAME + "_v" + "_v" + DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day + " " + DateTime.Now.Hour + "h" + DateTime.Now.Minute + ".bak";
        }

        private void restore_db()
        {
            try
            {
                if (!CHRM_BaseMessages.MsgBox_Confirm(CONST_ID_MSGBOX.INFOR_BACKUP_DB_THANG_CONG) == true)
                {
                    return;
                }
                conn = new SqlConnection(CONNECTION_STRING);
                conn.Open();
                
                sql = "Alter Database " + DB_NAME + " Set SINGLE_USER WITH ROLLBACK IMMEDIATE;";
                sql += "Use master Restore Database " + DB_NAME + " FROM Disk = '" + m_txt_backup_path.Text + "'" + " WITH REPLACE, RECOVERY;";
                command = new SqlCommand(sql, conn);
                command.ExecuteNonQuery();

                string Alter2 = @"ALTER DATABASE [" + DB_NAME + "] SET Multi_User";
                SqlCommand Alter2Cmd = new SqlCommand(Alter2, conn);
                Alter2Cmd.ExecuteNonQuery();

                
                CHRM_BaseMessages.MsgBox_Infor(CONST_ID_MSGBOX.INFOR_RESTORE_DB_THANG_CONG);
            }
            catch (Exception)
            {
                string Alter2 = @"ALTER DATABASE [" + DB_NAME + "] SET Multi_User";
                SqlCommand Alter2Cmd = new SqlCommand(Alter2, conn);
                Alter2Cmd.ExecuteNonQuery();
                throw;
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }
        private string gen_name_back_up_db()
        {
            return DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day + "  " + DateTime.Now.Hour + "h" + DateTime.Now.Minute + "p";
        }
        private string gen_name_disk_location_back_up()
        {
            return DISK_LOCATION + "\\" + m_txt_ten_file.Text + ".bak";
        }
        private void backup_db()
        {
            conn = new SqlConnection(CONNECTION_STRING);
            conn.Open();
            sql = "BACKUP DATABASE " + DB_NAME + " TO DISK = '" + m_txt_location.Text + "'";
            command = new SqlCommand(sql, conn);
            command.ExecuteNonQuery();

            conn.Close();
            conn.Dispose();
            using (context = new BKI_DVMDEntities())
            {
                BACKUP_INFO info = new BACKUP_INFO();
                info.DISK_LOCATION = m_txt_location.Text;
                info.FILE_NAME = m_txt_ten_file.Text;
                info.NGAY_TAO = DateTime.Now;
                context.BACKUP_INFO.Add(info);
                context.SaveChanges();
            }
            m_cmd_add_new_back_up.Visible = true;
            m_cmd_backup.Visible = false;
            fill_data_2_grid();
            CHRM_BaseMessages.MsgBox_Infor(CONST_ID_MSGBOX.INFOR_BACKUP_DB_THANG_CONG);
        }

        private void fill_data_2_grid()
        {
            using (var context = new BKI_DVMDEntities())
            {
                var dataSource = context.BACKUP_INFO.ToList();
                gridControlSave.DataSource = dataSource;
                gridControlSave.RefreshDataSource();
                gridViewSave.FocusedRowChanged += gridViewSave_FocusedRowChanged;
            }
        }
        #endregion

        #region Events
        private void set_define_events()
        {
            m_cmd_backup.Click += m_cmd_backup_Click;
            m_cmd_restore.Click += m_cmd_restore_Click;
            this.Load += BackupDB_Load;
            m_cmd_add_new_back_up.Click += m_cmd_add_new_back_up_Click;
            
        }

        void gridViewSave_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                var info = (BACKUP_INFO)gridViewSave.GetRow(gridViewSave.FocusedRowHandle);
                m_txt_backup_path.Text = info.DISK_LOCATION;
            }
            catch (Exception v_e)
            {
                CHRM_BaseMessages.MsgBox_Infor(v_e.Message);
            }
        }

        void m_cmd_add_new_back_up_Click(object sender, EventArgs e)
        {
            try
            {
                m_cmd_add_new_back_up.Visible = false;
                m_cmd_backup.Visible = true;
                m_txt_ten_file.Text = gen_name_back_up_db();
                m_txt_location.Text = gen_name_disk_location_back_up();
            }
            catch (Exception v_e)
            {
                CHRM_BaseMessages.MsgBox_Infor(v_e.Message);
            }
        }

        void m_cmd_restore_Click(object sender, EventArgs e)
        {
            try
            {
                restore_db();
            }
            catch (Exception v_e)
            {
                CHRM_BaseMessages.MsgBox_Infor(v_e.Message);
            }
        }

        void m_cmd_backup_Click(object sender, EventArgs e)
        {
            try
            {
                backup_db();
            }
            catch (Exception v_e)
            {
                CHRM_BaseMessages.MsgBox_Infor(v_e.Message);
            }
        }

        void BackupDB_Load(object sender, EventArgs e)
        {
            try
            {
                set_intial_form_load();
            }
            catch (Exception v_e)
            {
                CHRM_BaseMessages.MsgBox_Infor(v_e.Message);
            }
        }
        #endregion


    }
}
