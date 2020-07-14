using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniStopApplication.DAO
{
    class ProccessWareHourse
    {
        private static ProccessWareHourse instance;
        public static ProccessWareHourse Instance
        {
            get
            {
                if (instance == null)
                    instance = new ProccessWareHourse();
                return ProccessWareHourse.instance;
            }
        }

        public DataTable GetAllWareHourseProduct()
        {
            try
            {
                return DataProvider.Instance.ExecuteQuery("SP_GetAll_WarehouseProduct");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
