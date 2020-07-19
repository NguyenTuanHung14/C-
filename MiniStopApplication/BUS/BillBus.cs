using MiniStopApplication.DAO;
using MiniStopApplication.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniStopApplication.BUS
{
   public class BillBus
    {
        private static BillBus instance;

        public static BillBus Instance
        {
            get
            {
                if (instance == null)
                    instance = new BillBus();
                return instance;
            }
        }
        public bool UpdateBill(int id_bill)
        {
        
            try
            {
                return ProccessBill.Instance.UpdateBill(id_bill);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public bool InsertBill(int id_emp)
        {
            try
            {
                return ProccessBill.Instance.InsertBill(id_emp);
            }
            catch (Exception ex)
            {
                throw ex;
            }
      
        }

        public int getBill()
        {
            try
            {
                return ProccessBill.Instance.getBill();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public DataTable getAllBill()
        {
           
            try
            {
                return ProccessBill.Instance.getAllBill();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public DataTable getAllBillByDate(DateTime fromDate, DateTime toDate)
        {

            try
            {
                return ProccessBill.Instance.getAllBillByDate(fromDate, toDate);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
