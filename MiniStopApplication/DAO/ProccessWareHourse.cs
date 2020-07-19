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
        public DataTable GetAllByName_WarehouseProduct(string name)
        {
            try
            {
                return DataProvider.Instance.ExecuteQuery("SP_GetAllByName_WarehouseProduct @Name", new object[] { name} );
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
                return DataProvider.Instance.ExecuteQuery("SP_GetAllExpire_WarehouseProduct");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
