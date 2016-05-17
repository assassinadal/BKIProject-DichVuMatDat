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
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;
using IP.Core.IPSystemAdmin;
using DevExpress.XtraSplashScreen;
using BKI_DichVuMatDat.BaoCao;
namespace BKI_DichVuMatDat.HeThong
{
    public partial class frm_backup_restore : Form
    {
        private string serverName;
        private string userName;
        private string password;
        private string dbName;
        public frm_backup_restore()
        {
            InitializeComponent();
        }
        private Server GetServer()
        {
            ServerConnection conn = new ServerConnection(serverName, userName, password);
            Server myServer = new Server(conn);
            return myServer;
        }
        private void BackupDataBase(string databaseName)
        {
            SplashScreenManager.ShowForm(typeof(F_wait_form));
            var destinationPath = "HRM_PVMD_v" + DateTime.Now.Year + "." + DateTime.Now.Month + "." + DateTime.Now.Day + "." + DateTime.Now.Hour + "h." + DateTime.Now.Minute + "p.bak";
            Server myServer = GetServer();
            Backup backup = new Backup();
            backup.Action = BackupActionType.Database;
            backup.Database = databaseName;
            // destinationPath = System.IO.Path.Combine(destinationPath, databaseName);
            backup.Devices.Add(new BackupDeviceItem(destinationPath, DeviceType.File));
            backup.Initialize = true;
            backup.Checksum = true;
            backup.ContinueAfterError = true;
            backup.Incremental = false;
            backup.LogTruncation = BackupTruncateLogType.Truncate;
            // Perform backup.
            US_HT_BACKUP_HISTORY v_us = new US_HT_BACKUP_HISTORY();
            try
            {
                v_us.strNGUOI_BACKUP = CAppContext_201.getCurrentUserName();
                v_us.datNGAY_BACKUP = DateTime.Now.Date;
                v_us.strNOI_LUU = destinationPath;
                v_us.Insert();
                backup.SqlBackup(myServer);
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                SplashScreenManager.CloseForm();
            }
            XtraMessageBox.Show("Sao lưu File : " + destinationPath + " thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void RestoreDataBase(string BackupFilePath,
            string destinationDatabaseName)
        {
            SplashScreenManager.ShowForm(typeof(F_wait_form));
            try
            {
                Server myServer = GetServer();
                //Restore myRestore = new Restore();
                //myRestore.Database = destinationDatabaseName;
                //Database currentDb = myServer.Databases[destinationDatabaseName];
                //if(currentDb != null)
                //    myServer.KillAllProcesses(destinationDatabaseName);
                //myRestore.Devices.AddDevice(BackupFilePath, DeviceType.File);
                //string DataFileLocation = DatabaseFolder + "\\" + destinationDatabaseName + ".mdf";
                //string LogFileLocation = DatabaseFolder + "\\" + destinationDatabaseName + "_log.ldf";
                //myRestore.RelocateFiles.Add(new RelocateFile(DatabaseFileName, DataFileLocation));
                //myRestore.RelocateFiles.Add(new RelocateFile(DatabaseLogFileName, LogFileLocation));
                //myRestore.ReplaceDatabase = true;
                //myRestore.PercentCompleteNotification = 10;
                //myRestore.SqlRestore(myServer);
                //currentDb = myServer.Databases[destinationDatabaseName];
                //currentDb.SetOnline();

                Restore rstDatabase = new Restore();
                rstDatabase.Action = RestoreActionType.Database;
                rstDatabase.Database = destinationDatabaseName;
                myServer.KillAllProcesses(destinationDatabaseName);
                BackupDeviceItem bkpDevice = new BackupDeviceItem(BackupFilePath, DeviceType.File);
                rstDatabase.Devices.Add(bkpDevice);
                rstDatabase.ReplaceDatabase = true;
                rstDatabase.SqlRestore(myServer);

            }
            catch(Exception)
            {
                throw;
            }

            finally
            {
                SplashScreenManager.CloseForm();
            }
        }

        //private void CreateLogin (string sqlLoginName, string sqlLoginPassword, string databaseName)
        //{
        //    Server myServer = GetServer();
        //    Login newLogin = myServer.Logins[sqlLoginName];
        //    if(newLogin != null)
        //        newLogin.Drop();
        //    newLogin = new Login(myServer, sqlLoginName);
        //    newLogin.PasswordPolicyEnforced = false;
        //    newLogin.LoginType = LoginType.SqlLogin;
        //    newLogin.Create(sqlLoginPassword);
        //    //Create DatabaseUser
        //    DatabaseMapping mapping =
        //        new DatabaseMapping(newLogin.Name, MainDbName, newLogin.Name);
        //    Database currentDb = myServer.Databases[databaseName];
        //    User dbUser = new User(currentDb, newLogin.Name);
        //    dbUser.Login = sqlLogin;
        //    dbUser.Create();
        //    dbUser.AddToRole("db_owner");
        //}
        private void load_data_to_grid()
        {
            US_HT_BACKUP_HISTORY v_us = new US_HT_BACKUP_HISTORY();
            DS_HT_BACKUP_HISTORY v_ds = new DS_HT_BACKUP_HISTORY();
            v_us.FillDataset(v_ds);
            gridControl1.DataSource = v_ds.Tables[0];
        }
        private void m_cmd_backup_Click(object sender, EventArgs e)
        {
            try
            {
                var v_dgl_confirm = XtraMessageBox.Show("Bạn có chắc chắn muốn sao lưu dữ liệu hiện tại?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(v_dgl_confirm == System.Windows.Forms.DialogResult.Yes)
                {
                    //SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                    //saveFileDialog1.Filter = "bak files *.bak|*.bak";
                    ///saveFileDialog1.RestoreDirectory = true;
                    ///
                    //saveFileDialog1.FileName = "HRM_PVMD_v" + DateTime.Now.Year + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day + "_" + DateTime.Now.Hour + "h_" + DateTime.Now.Minute+"p";

                    BackupDataBase(dbName);

                    load_data_to_grid();
                }
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void frm_backup_restore_Load(object sender, EventArgs e)
        {
            try
            {
                serverName = System.Configuration.ConfigurationManager.AppSettings["SERVER"];
                dbName = System.Configuration.ConfigurationManager.AppSettings["INITIAL_DATABASE"];
                userName = System.Configuration.ConfigurationManager.AppSettings["INITIAL_USER"];
                password = System.Configuration.ConfigurationManager.AppSettings["PASS_WORD"];

                load_data_to_grid();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_phuc_hoi_Click(object sender, EventArgs e)
        {
            try
            {
                var v_dgl_confirm = XtraMessageBox.Show("Bạn có chắc chắn muốn phục hồi dữ liệu đã sao lưu trước đó?\nViệc phục hồi sẽ đưu dữ liệu về phiên bản bạn chọn!", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                if(v_dgl_confirm == System.Windows.Forms.DialogResult.Yes)
                {
                    var dbPathToRestore = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NOI_LUU").ToString();
                    RestoreDataBase(dbPathToRestore, dbName);
                    XtraMessageBox.Show("Phục hồi dữ liệu " + dbPathToRestore + " thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load_data_to_grid();
                }
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
    }
}
