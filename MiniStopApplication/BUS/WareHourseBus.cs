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
        public DataTable GetAllExpire_WarehouseProduct()
        {
            try
            {
                return ProccessWareHourse.Instance.GetAllExpire_WarehouseProduct();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetAllByName_WarehouseProduct(string name)
        {
            try
            {
                return ProccessWareHourse.Instance.GetAllByName_WarehouseProduct(name);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
