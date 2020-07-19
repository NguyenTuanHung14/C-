using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniStopApplication.BUS.StrategyPattern
{
   public interface IStrategy
    {
        void CheckOut(int discount, float finalPrice, int id_bill,int usingPoint = 0, int id_member = 0);
        void Statistical(GridControl gc, GridView gv);
    }
}
