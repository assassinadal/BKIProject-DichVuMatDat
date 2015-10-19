using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BKI_DichVuMatDat.EF;
using IP.Core.IPCommon;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
namespace BKI_DichVuMatDat.BaoCao
{
    public partial class f440_rpt_luong : Form
    {
        #region Public Interface
        public f440_rpt_luong()
        {
            InitializeComponent();
            format_control();
            setDefineEvent();
        }


        #endregion


        #region Member
        private BindingList<V_RPT_LUONG> getDataSource()
        {
            using (var context = new BKI_DVMDEntities())
            {
                return new BindingList<V_RPT_LUONG>(context.V_RPT_LUONG.ToList());
            }
        }
        private void fillDataPivotGrid(BindingList<V_RPT_LUONG> ipList)
        {
            pivotGridControl1.DataSource = ipList;
        }

        #endregion

        #region Private Method
        private void format_control()
        {

        }
        private void setInitFormLoad()
        {
            fillDataPivotGrid(getDataSource());
            pivotGridControl1.Cells.Selection = new  Rectangle(0, 0, Width, pivotGridControl1.Cells.RowCount);
        }
        #endregion

        #region Event Handle
        private void setDefineEvent()
        {
            this.Load += f440_rpt_luong_Load;
            pivotGridControl1.CellDoubleClick += pivotGridControl1_CellDoubleClick;
        }
        void pivotGridControl1_CellDoubleClick(object sender, DevExpress.XtraPivotGrid.PivotCellEventArgs e)
        {
            try
            {
                f441_thuc_linh_de frm = new f441_thuc_linh_de();
                frm.fillDataSource(e.CreateDrillDownDataSource());
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void f440_rpt_luong_Load(object sender, EventArgs e)
        {
            try
            {
                setInitFormLoad();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }



        #endregion
    }
}
