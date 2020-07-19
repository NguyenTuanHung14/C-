using MiniStopApplication.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniStopApplication.DAO
{
  public  class ProccessBillDetail
    {
        private static ProccessBillDetail instance;
        public static ProccessBillDetail Instance
        {
            get
            {
                if (instance == null)
                    instance = new ProccessBillDetail();
                return ProccessBillDetail.instance;
            }
        }

        public bool InsertBillDetal(BillDetail billDetail) {
            string query = string.Format("SP_Insert_BillDetail @Price , @Amount , @Id_Bill , @Id_Product");
            int result;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(query,
                    new object[] { billDetail.Price, billDetail.Amount, billDetail.Id_bill, billDetail.Id_product});
            }
            catch (Exception ex)
            {
                throw ex;
            }   
            return result > 0;
        }
        public DataTable getListBillDetailByBill(int id)
        {
            string query = string.Format("SP_GetAllByID_BillDetail @id_bill");

            try
            {
                return DataProvider.Instance.ExecuteQuery(query, new object[] { id });
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

    }
}
