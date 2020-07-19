using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniStopApplication.BUS.StrategyPattern
{
    class StatisticalContext
    {
        private IStrategy _strategy;

        public StatisticalContext()
        {

        }

        public StatisticalContext(IStrategy strategy)
        {
            this._strategy = strategy;
        }


        public void SetStrategy(IStrategy strategy)
        {
            this._strategy = strategy;
        }

        public void Statistical(GridControl gc, GridView gv)
        {
            this._strategy.Statistical(gc, gv);
        }
    }
}
