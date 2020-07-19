using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniStopApplication.BUS.StrategyPattern
{
    class CheckOutContext
    {
        private IStrategy _strategy;

        public CheckOutContext() { 
        
        }

        public CheckOutContext(IStrategy strategy)
        {
            this._strategy = strategy;
        }

    
        public void SetStrategy(IStrategy strategy)
        {
            this._strategy = strategy;
        }

        public void CheckOut(int discount, float finalPrice, int id_bill, int usingPoint = 0, int id_member = 0) {
            this._strategy.CheckOut(discount, finalPrice, id_bill, usingPoint, id_member);
        }
    }
}
