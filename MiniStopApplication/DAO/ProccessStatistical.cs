using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniStopApplication.DAO
{
   public class ProccessStatistical
    {

        private static ProccessStatistical instance;
        public static ProccessStatistical Instance
        {
            get
            {
                if (instance == null)
                    instance = new ProccessStatistical();
                return ProccessStatistical.instance;
            }
        }

        public DataTable Statistical_ByProduct()
        {
            try
            {
                return DataProvider.Instance.ExecuteQuery("SP_Statistical_ByProduct");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable Statistical_ByProductType()
        {
            try
            {
                return DataProvider.Instance.ExecuteQuery("SP_Statistical_ByProductType");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable Statistical_ByDate()
        {
            try
            {
                return DataProvider.Instance.ExecuteQuery("SP_Statistical_ByDate");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable Statistical_ByMonth()
        {
            try
            {
                return DataProvider.Instance.ExecuteQuery("SP_Statistical_ByMonth");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
