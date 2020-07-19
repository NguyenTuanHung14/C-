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
    class BillDetailBus
    {
        private static BillDetailBus instance;

        public static BillDetailBus Instance
        {
            get
            {
                if (instance == null)
                    instance = new BillDetailBus();
                return instance;
            }
        }
        public bool InsertBillDetal(BillDetail billDetail)
        {
            try
            {
                return ProccessBillDetail.Instance.InsertBillDetal(billDetail);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable getListBillDetailByBill(int id)
        {
        
            try
            {
                return ProccessBillDetail.Instance.getListBillDetailByBill(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

    }
}
