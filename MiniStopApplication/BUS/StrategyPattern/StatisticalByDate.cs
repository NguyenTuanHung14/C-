using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using MiniStopApplication.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniStopApplication.BUS.StrategyPattern
{
    public class StatisticalByDate : IStrategy
    {
        public void CheckOut(int discount, float finalPrice, int id_bill, int usingPoint = 0, int id_member = 0)
        {
            throw new NotImplementedException();
        }

        public void Statistical(GridControl gc, GridView gv)
        {
            try
            {

                gc.DataSource = ProccessStatistical.Instance.Statistical_ByDate();
                gv.Columns[0].Caption = "Tên loại sản phẩm";
                gv.Columns[1].Caption = "Ngày bán";
                gv.Columns[2].Caption = "Số lượng bán ra";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
