using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Xml;
using System.Windows.Forms;
using IP.Core.IPCommon.MessageForms;
using IP.Core.IPCommon;
using DevExpress.XtraEditors;
using System.Deployment.Application;


namespace BKI_DichVuMatDat
{
    public class CHRM_BaseMessages
    {
        #region "Nhiệm vụ của class"
        //*************************************************************
        // Dùng để hiện thị các thông báo của hệ thống
        //
        //*************************************************************
        #endregion

        #region "Vùng khai báo biến"
        public enum IsDataCouldBeDeleted
        {
            CouldBeDeleted = 232,
            ShouldNotBeDeleted = 1111
        }

        private static DatasetMsg m_DataSet = new DatasetMsg();
        private static Users_DataSet m_dsUser = new Users_DataSet();
        private const string c_strUserFileName = "XML_MESSAGE\\NumOfMessage.XML";
        private const string c_InfoMsgString = "THÔNG BÁO";
        private const string c_ErrorMsgString = "THÔNG BÁO LỖI";
        private const string c_ConfirmMsgString = "XÁC NHẬN LẠI";
        private const string c_WarningMsgString = "CẢNH BÁO";
        private static bool m_IntialedClass;
        //Các thông số liên quan đến chế độ chạy
        private const string c_RunApp = "RUN";

        private const string c_DeburgMode = "DEBUG";
        public enum MsgBtnType : int
        {
            MsgBtnOK = 0,
            MsgBtnYes_No = 1,
            MsgBtnYes_No_Cancel = 2
        }

        public enum MsgIconType : int
        {
            InfomationIcon = 0,
            ErrorIcon = 1,
            QuestionIcon = 2,
            WarningIcon = 3
        }

        #endregion

        #region "Các hàm khởi tạo huỷ dữ liệu"

        private static void InitClass(string i_UserFileName)
        {
            try
            {
                string v_UserFileName;
                if(ApplicationDeployment.IsNetworkDeployed)
                {
                    v_UserFileName = ApplicationDeployment.CurrentDeployment.DataDirectory + "\\" + i_UserFileName;
                }
                else
                {
                    v_UserFileName = AppDomain.CurrentDomain.SetupInformation.ApplicationBase + i_UserFileName;
                }
                //MessageBox.Show("b1:" + v_UserFileName);
                m_dsUser.ReadXml(v_UserFileName);
                //XtraMessageBox.Show("Số lượng " + m_dsUser.Users_DataSet.Count);
                m_IntialedClass = true;
            }
            catch(Exception v_Ex)
            {
                throw new Exception("Could not read file. Error message: " + v_Ex.Message);
            }
            finally
            {
            }
        }

        public static void Close()
        {
            m_DataSet = null;
        }

        private static void LoadMessagesData(decimal i_NumOFMsg)
        {
            string v_strWhere = null;

            string v_FileName = null;
            if(ApplicationDeployment.IsNetworkDeployed)
            {
                v_FileName = ApplicationDeployment.CurrentDeployment.DataDirectory + "\\XML_MESSAGE\\";
            }
            else
            {
                v_FileName = AppDomain.CurrentDomain.SetupInformation.ApplicationBase + @"XML_MESSAGE\";
            }
            //MessageBox.Show("v_FileName: " + v_FileName);
            v_strWhere = "(FromNum <= " + i_NumOFMsg + ") and (" + i_NumOFMsg + " < ToNum)";
            DataView v_dvUserData = new DataView(m_dsUser.Users_DataSet, v_strWhere, "", DataViewRowState.CurrentRows);
            //MessageBox.Show("Count: " + v_dvUserData.Count);
            if(v_dvUserData.Count > 0)
            {
                v_FileName += Convert.ToString(v_dvUserData[0]["FileName"]);
                m_DataSet.ReadXml(v_FileName);
                //MessageBox.Show("v_FileName: " + v_FileName);
            }
        }
        #endregion

        #region "Lấy dữ liệu thông báo"
        //Lay lai cac thong bao trong database theo cac chi so cua thong bao
        public static string GetMsg(decimal i_MsgNumber)
        {
            string v_strValue = null;
            string v_strWhere = "ID=" + i_MsgNumber;
            if(!m_IntialedClass)
            {
                InitClass(c_strUserFileName);
            }
            LoadMessagesData(i_MsgNumber);
            DataView v_dvMessage = new DataView(m_DataSet.Message, v_strWhere, "", DataViewRowState.CurrentRows);
            if(v_dvMessage.Count > 0)
            {
                v_strValue = Convert.ToString(v_dvMessage[0]["Message"]);
            }
            else
            {
                v_strValue = "Chương trình chưa tìm thấy nội dung thông báo! Bạn vui lòng liên hệ với đội IT để sửa nhé!";
            }
            return v_strValue;
        }
        #endregion

        #region Các hàm msgbox
        // MsgBox_OK
        private static void CHRM_MsgBox_OK(string i_strMsg, string i_titleMsg, Msgs.MsgIconType i_IconType)
        {
            switch(i_IconType)
            {
                case Msgs.MsgIconType.ErrorIcon:
                    XtraMessageBox.Show(i_strMsg, i_titleMsg, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case Msgs.MsgIconType.InfomationIcon:
                    XtraMessageBox.Show(i_strMsg, i_titleMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case Msgs.MsgIconType.QuestionIcon:
                    XtraMessageBox.Show(i_strMsg, i_titleMsg, MessageBoxButtons.OK, MessageBoxIcon.Question);
                    break;
                case Msgs.MsgIconType.WarningIcon:
                    XtraMessageBox.Show(i_strMsg, i_titleMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }

        }

        //MsgBox_Yes_No
        private static DialogResult CHRM_MsgBox_Yes_No(string i_strMsg, string i_titleMsg, Msgs.MsgIconType i_IconType)
        {
            DialogResult v_Result = default(DialogResult);
            switch(i_IconType)
            {
                case Msgs.MsgIconType.ErrorIcon:
                    v_Result = XtraMessageBox.Show(i_strMsg, i_titleMsg, MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    break;
                case Msgs.MsgIconType.InfomationIcon:
                    v_Result = XtraMessageBox.Show(i_strMsg, i_titleMsg, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    break;
                case Msgs.MsgIconType.QuestionIcon:
                    v_Result = XtraMessageBox.Show(i_strMsg, i_titleMsg, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    break;
                case Msgs.MsgIconType.WarningIcon:
                    v_Result = XtraMessageBox.Show(i_strMsg, i_titleMsg, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    break;
            }
            return v_Result;
        }

        //MsgBox_Yes_No_Cancel
        private static DialogResult CHRM_MsgBox_Yes_No_Cancel(string i_strMsg, string i_titleMsg, Msgs.MsgIconType i_IconType)
        {
            DialogResult v_Result = default(DialogResult);
            switch(i_IconType)
            {
                case Msgs.MsgIconType.ErrorIcon:
                    v_Result = XtraMessageBox.Show(i_strMsg, i_titleMsg, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);
                    break;
                case Msgs.MsgIconType.InfomationIcon:
                    v_Result = XtraMessageBox.Show(i_strMsg, i_titleMsg, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                    break;
                case Msgs.MsgIconType.QuestionIcon:
                    v_Result = XtraMessageBox.Show(i_strMsg, i_titleMsg, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    break;
                case Msgs.MsgIconType.WarningIcon:
                    v_Result = XtraMessageBox.Show(i_strMsg, i_titleMsg, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                    break;
            }
            return v_Result;
        }
        #endregion

        #region "Public Interface"

        //Hàm thông báo lỗi dùng chỉ số lỗi
        public static void MsgBox_Error(int MsgNumber)
        {
            string v_StrMsg = MsgNumber + " - " + GetMsg(MsgNumber);
            MsgBox_Error(v_StrMsg);
        }
        //Hàm thông báo lỗi với một chuỗi
        public static void MsgBox_Error(string i_strMsg)
        {
            CHRM_MsgBox_OK(i_strMsg, c_ErrorMsgString, Msgs.MsgIconType.ErrorIcon);
        }

        //Hàm thông báo Thông tin thông thường bằng chỉ số lỗi
        public static void MsgBox_Infor(int MsgNumber)
        {
            string v_StrMsg = MsgNumber + " - " + GetMsg(MsgNumber);
            MsgBox_Infor(v_StrMsg);
        }
        //Hàm thông báo Thông tin thông thường bằng chuỗi
        public static void MsgBox_Infor(string i_strMsg)
        {
            CHRM_MsgBox_OK(i_strMsg, c_InfoMsgString, Msgs.MsgIconType.InfomationIcon);
        }

        //Hàm xác nhận lại yêu cầu  dùng chỉ sỗ chuỗi thông báo
        public static bool MsgBox_Confirm(int MsgNumber)
        {
            string v_StrMsg = MsgNumber + " - " + GetMsg(MsgNumber);
            //v_StrMsg = MsgNumber + " - " + GetMsg(MsgNumber);
            return MsgBox_Confirm(v_StrMsg);
        }
        //Hàm xác nhận lại yêu cầu  dùng chuỗi
        public static bool MsgBox_Confirm(string i_strMsg)
        {
            bool v_Result = false;
            DialogResult v_confirm = default(DialogResult);
            v_confirm = CHRM_MsgBox_Yes_No(i_strMsg, c_ConfirmMsgString, Msgs.MsgIconType.QuestionIcon);
            switch(v_confirm)
            {
                case DialogResult.Yes:
                    v_Result = true;
                    break;
                case DialogResult.No:
                    v_Result = false;
                    break;
            }
            return v_Result;
        }

        //Hàm cảnh báo dùng chỉ số lỗi
        public static void MsgBox_Warning(int MsgNumber) //bool
        {
            string v_StrMsg = MsgNumber + " - " + GetMsg(MsgNumber);
            MsgBox_Warning(v_StrMsg);
        }
        //Hàm cảnh báo dùng chỉ số lỗi
        public static void MsgBox_Warning(string i_strMsg) //bool
        {
            CHRM_MsgBox_OK(i_strMsg, c_WarningMsgString, Msgs.MsgIconType.WarningIcon);
        }

        //Hàm confirm "Yes","No","Cancel"
        public static DialogResult MsgBox_YES_NO_CANCEL(int MsgNumber)
        {
            string v_StrMsg = MsgNumber + " - " + GetMsg(MsgNumber);
            DialogResult v_confirm = MsgBox_YES_NO_CANCEL(v_StrMsg);
            return v_confirm;
        }
        //Hàm confirm "Yes","No","Cancel"
        public static DialogResult MsgBox_YES_NO_CANCEL(string i_strMsg)
        {
            MsgBoxFormYes_No_Cancel v_FormMsg = new MsgBoxFormYes_No_Cancel();
            DialogResult v_confirm = CHRM_MsgBox_Yes_No_Cancel(i_strMsg, c_ConfirmMsgString, Msgs.MsgIconType.QuestionIcon);
            return v_confirm;
        }

        // Hàm hỏi có xoá dữ liệu không
        public static IsDataCouldBeDeleted askUser_DataCouldBeDeleted(int i_MsgNumber = 8)
        {
            if(MsgBox_Confirm(i_MsgNumber))
            {
                return IsDataCouldBeDeleted.CouldBeDeleted;
            }
            else
            {
                return IsDataCouldBeDeleted.ShouldNotBeDeleted;
            }
        }

        #endregion
    }
}
