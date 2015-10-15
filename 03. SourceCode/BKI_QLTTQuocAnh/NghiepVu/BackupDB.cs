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

namespace BKI_DichVuMatDat.NghiepVu
{
    public partial class BackupDB : Form
    {
        private string DB_NAME;
        private string DISK_LOCATION;
        private string CONNECTION_STRING;

        public BackupDB()
        {
            InitializeComponent();
            format_control();
            getDataFromAppConfig();
        }

        private void format_control()
        {
            set_define_events();
        }

        #region MyRegion
        SqlConnection conn;
        SqlCommand command;
        SqlDataReader reader;
        string sql = "";
        #endregion


        #region Private Methods
        private void getDataFromAppConfig()
        {
            var reader = new System.Configuration.AppSettingsReader();
            DB_NAME = reader.GetValue("INITIAL_DATABASE", typeof(string)).ToString();
            DISK_LOCATION = reader.GetValue("DISK_LOCATION", typeof(string)).ToString();
            CONNECTION_STRING = ConfigurationManager.ConnectionStrings["BKI_DichVuMatDat.Properties.Settings.BKI_DVMDConnectionString"].ConnectionString;
        }
        private void set_intial_form_load()
        {
            m_txt_location.Text = DISK_LOCATION;
            m_txt_location.ReadOnly = true;
            m_cmd_disconnect.Enabled = false;
            m_cbo_db.Enabled = false;
            m_cmd_backup.Enabled = false;
            m_cmd_restore.Enabled = false;
            connect_to_db();
            m_cbo_db.Text = DB_NAME;
        }
        private void connect_to_db()
        {
            //connectionString = "Data Source = " + m_txt_data_source.Text + "; User Id = " + m_txt_user_id.Text + "; Password=" + m_txt_pwd.Text + "";
            conn = new SqlConnection(CONNECTION_STRING);
            conn.Open();
            sql = "SELECT * FROM sys.databases d WHERE d.database_id>4";
            command = new SqlCommand(sql, conn);
            reader = command.ExecuteReader();
            m_cbo_db.Items.Clear();
            while (reader.Read())
            {
                m_cbo_db.Items.Add(reader[0].ToString());
            }

            conn.Close();
            conn.Dispose();

            m_txt_user_id.Enabled = false;
            m_txt_pwd.Enabled = false;
            m_cmd_connect.Enabled = false;
            m_cmd_disconnect.Enabled = true;
            m_cmd_backup.Enabled = true;
            m_cmd_restore.Enabled = true;
            m_cbo_db.Enabled = true;
            m_txt_ten_file.Text = DB_NAME + "_v" + DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day + " " + DateTime.Now.Hour + "h" + DateTime.Now.Minute + ".bak";
        }
        private void disconect_db()
        {
            m_txt_data_source.Enabled = true;
            m_txt_user_id.Enabled = true;
            m_txt_pwd.Enabled = true;
            m_cbo_db.Enabled = false;
            m_cmd_backup.Enabled = false;
            m_cmd_restore.Enabled = false;
        }
        private void restore_db()
        {
            if (!BaseMessages.MsgBox_Confirm("Bạn có chắc chắn muốn phục hồi dữ liệu tại thời điểm này. Khi phục hồi thì các dữ liệu sau ngày tạo file lưu trữ này sẽ biến mất!"))
            {
                return;
            }
            //if(m_cbo_db.Text.CompareTo("") == 0) {
            //    MessageBox.Show("Làm ơn chọn Database đi!");
            //    return;
            //}
            conn = new SqlConnection(CONNECTION_STRING);
            conn.Open();
            sql = "Alter Database " + DB_NAME + " Set SINGLE_USER WITH ROLLBACK IMMEDIATE;";
            sql += "Restore Database " + DB_NAME + " FROM Disk = '" + m_txt_backup_path.Text + "'" + " WITH REPLACE;";
            command = new SqlCommand(sql, conn);
            command.ExecuteNonQuery();
            conn.Close();
            conn.Dispose();
            MessageBox.Show("Restore Database thành công");
        }
        private void backup_db()
        {
            //if(m_cbo_db.Text.CompareTo("") == 0) {
            //    MessageBox.Show("Làm ơn chọn Database đi");
            //    return;
            //}
            conn = new SqlConnection(CONNECTION_STRING);
            conn.Open();
            sql = "BACKUP DATABASE " + DB_NAME + " TO DISK = '" + m_txt_location.Text + "\\" + m_txt_ten_file.Text + "'";
            command = new SqlCommand(sql, conn);
            command.ExecuteNonQuery();

            conn.Close();
            conn.Dispose();

            MessageBox.Show("Backup thành công!");
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
        #endregion
        //
        //Events
        private void set_define_events()
        {
            m_cmd_connect.Click += m_cmd_connect_Click;
            m_cmd_disconnect.Click += m_cmd_disconnect_Click;
            m_cmd_backup.Click += m_cmd_backup_Click;
            this.Load += BackupDB_Load;
            m_cmd_browse_backup.Click += m_cmd_browse_backup_Click;
            m_cmd_browse_restore.Click += m_cmd_browse_restore_Click;
            m_cmd_restore.Click += m_cmd_restore_Click;
        }

        void m_cmd_restore_Click(object sender, EventArgs e)
        {
            try
            {
                restore_db();
            }
            catch (Exception v_e)
            {

                MessageBox.Show(v_e.Message);
            }
        }

        void m_cmd_browse_restore_Click(object sender, EventArgs e)
        {
            try
            {
                choose_file_restore();
            }
            catch (Exception v_e)
            {

                MessageBox.Show(v_e.Message);
            }
        }

        void m_cmd_browse_backup_Click(object sender, EventArgs e)
        {
            try
            {
                choose_file_backup();
            }
            catch (Exception v_e)
            {

                MessageBox.Show(v_e.Message);
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

                MessageBox.Show(v_e.Message);
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

                MessageBox.Show(v_e.Message);
            }
        }

        void m_cmd_disconnect_Click(object sender, EventArgs e)
        {
            try
            {
                disconect_db();
            }
            catch (Exception v_e)
            {

                MessageBox.Show(v_e.Message);
            }
        }

        void m_cmd_connect_Click(object sender, EventArgs e)
        {
            try
            {
                connect_to_db();
            }
            catch (Exception v_e)
            {
                MessageBox.Show(v_e.Message);
            }
        }
    }
}
