using MiniStopApplication.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniStopApplication.DAO
{
    public class ProccessBill
    {
        private static ProccessBill instance;
        public static ProccessBill Instance
        {
            get
            {
                if (instance == null)
                    instance = new ProccessBill();
                return ProccessBill.instance;
            }
        }
        public bool InsertBill(int id_emp)
        {
            string query = string.Format("SP_Insert_Bill @Id_Employee");
            int result;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(query,
                    new object[] { id_emp });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }

        public bool UpdateBill(int id_bill)
        {
            string query = string.Format("SP_Update_Bill @id_bill");
            int result;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(query,
                    new object[] { id_bill });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }
        public int getBill()
        {
            string query = string.Format("SP_Get_Bill");
            try
            {
                return (int) DataProvider.Instance.ExecuteScalar(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable getAllBill()
        {
            string query = string.Format("SP_GetAll_Bill");

            try
            {
                return DataProvider.Instance.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public DataTable getAllBillByDate(DateTime fromDate, DateTime toDate)
        {
            string query = string.Format("SP_GetAllByDate_Bill @fromDate , @toDate");

            try
            {
                return DataProvider.Instance.ExecuteQuery(query, new object[] { fromDate, toDate });
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


    }
}
