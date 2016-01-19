
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using IP.Core.IPData;
using IP.Core.IPSystemAdmin;
using IP.Core.IPUserService;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BKI_DichVuMatDat
{
    public class FormatControl
    {
        private static DS_HT_PHAN_QUYEN_DETAIL getDataPhanQuyen()
        {
            DS_HT_PHAN_QUYEN_DETAIL v_ds = new DS_HT_PHAN_QUYEN_DETAIL();
            US_HT_PHAN_QUYEN_DETAIL v_us = new US_HT_PHAN_QUYEN_DETAIL();
            v_us.FillDatasetByUserLogin(v_ds, CAppContext_201.getCurrentUserName());

            return v_ds;
        }
        private static void GetAllControl(Control c, List<Control> outList)
        {
            foreach (Control control in c.Controls)
            {
                if (control.GetType() == typeof(SimpleButton))
                {
                    outList.Add(control);
                }
                else
                {
                    GetAllControl(control, outList);
                }
            }
        }
        private static bool CanUseThisControl(DS_HT_PHAN_QUYEN_DETAIL iDS, string iFormName, string iControlName)
        {
            string filterExpression = "FORM_NAME = '" + iFormName + "' AND CONTROL_NAME = '" + iControlName + "'" + " AND VISIBLE_YN = 'Y'";
            if (iDS.HT_PHAN_QUYEN_DETAIL.Select(filterExpression).Length > 0)
            {
                return true;
            }

            return false;
        }
        public static void SetVisibleSimpleButton(Form iForm)
        {
            List<Control> outList = new List<Control>();
            GetAllControl(iForm, outList);
            DS_HT_PHAN_QUYEN_DETAIL v_ds = getDataPhanQuyen();

            foreach (var control in outList)
            {
                if (!CanUseThisControl(v_ds, iForm.Name, control.Name))
                {
                    control.Visible = false;
                }
            }
        }

        private static void GetAllBarButtonItem(RibbonControl ribbonControl, List<BarButtonItem> outList)
        {
            for (int x = 0; x < ribbonControl.Manager.Items.Count; x++)
            {
                if (ribbonControl.Manager.Items[x].GetType() == typeof(BarButtonItem))
                {
                    BarButtonItem btn = ribbonControl.Manager.Items[x] as BarButtonItem;
                    outList.Add(btn);
                }
            }
        }
        public static void SetVisibleBarButtonItem(RibbonControl iRibbonForm, string iFormName)
        {
            var ds = getDataPhanQuyen();

            List<BarButtonItem> listBarButtonItem = new List<BarButtonItem>();
            GetAllBarButtonItem(iRibbonForm, listBarButtonItem);

            foreach (var barBtn in listBarButtonItem)
            {
                if (!CanUseThisControl(ds, iFormName, barBtn.Name))
                {
                    barBtn.Visibility = BarItemVisibility.Never;
                }
            }
        }
    }
}
