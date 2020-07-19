using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using MiniStopApplication.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniStopApplication.BUS.StrategyPattern
{
    class MemberCheckOut : IStrategy
    {
        public void CheckOut(int discount, float finalPrice, int id_bill, int usingPoint = 0, int id_member = 0)
        {
          
            //1000 điểm giảm 10%
         
            CheckoutReport report = new CheckoutReport();
            report.DataSource = BillDetailBus.Instance.getListBillDetailByBill(id_bill);
            report.Parameters["Discount"].Value = discount;
            report.Parameters["CreateDate"].Value = DateTime.Now;
            report.Parameters["TotalPrice"].Value = finalPrice;
            ReportPrintTool tool = new ReportPrintTool(report);
            tool.ShowPreview();

            //Cập nhật lại điểm của Member
            MemberBus.Instance.UpdateMemberPoint(id_member, -usingPoint);
            if (finalPrice >= 100000) {
                MemberBus.Instance.UpdateMemberPoint(id_member, 200);
            }
        }

        public void Statistical(GridControl gc, GridView gv)
        {
            throw new NotImplementedException();
        }
    }
}
