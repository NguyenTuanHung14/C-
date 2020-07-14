using MiniStopApplication.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniStopApplication.BUS
{
   public class WareHourseBus
    {
        private static WareHourseBus instance;

        public static WareHourseBus Instance
        {
            get
            {
                if (instance == null)
                    instance = new WareHourseBus();
                return instance;
            }
        }
        public DataTable GetAllWareHourseProduct()
        {
            try
            {
                return ProccessWareHourse.Instance.GetAllWareHourseProduct();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
