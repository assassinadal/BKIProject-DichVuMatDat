using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BKI_DichVuMatDat.COMMON
{
    public class FTP
    {
        static String sourcefilepath = "@absolutepath"; // e.g. “d:/test.docx”
        static String ftpurl = "@ftpurl"; // e.g. ftp://serverip/foldername/foldername
        static String ftpusername = "@ftpusername"; // e.g. username
        static String ftppassword = "@ftppassword"; // e.g. password
        private static void UploadFileToFTP(string source)
        {
            try
            {
                string filename = Path.GetFileName(source);
                string ftpfullpath = ftpurl;
                FtpWebRequest ftp = (FtpWebRequest)FtpWebRequest.Create(ftpfullpath);
                ftp.Credentials = new NetworkCredential(ftpusername, ftppassword);

                ftp.KeepAlive = true;
                ftp.UseBinary = true;
                ftp.Method = WebRequestMethods.Ftp.UploadFile;

                FileStream fs = File.OpenRead(source);
                byte[] buffer = new byte[fs.Length];
                fs.Read(buffer, 0, buffer.Length);
                fs.Close();

                Stream ftpstream = ftp.GetRequestStream();
                ftpstream.Write(buffer, 0, buffer.Length);
                ftpstream.Close();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
