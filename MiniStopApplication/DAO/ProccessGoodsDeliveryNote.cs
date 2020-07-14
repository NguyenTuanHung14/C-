using MiniStopApplication.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniStopApplication.DAO
{
   public class ProccessGoodsDeliveryNote
    {
        private static ProccessGoodsDeliveryNote instance;

        public static ProccessGoodsDeliveryNote Instance {
            get
            {
                if (instance == null)
                    instance = new ProccessGoodsDeliveryNote();
                return ProccessGoodsDeliveryNote.instance;
            }
        }

        public int getGoodsDeliveryNoteByDate()
        {
            string query = string.Format("SP_Get_GoodsDeliveryNote");
     
            try
            {
               return (int)DataProvider.Instance.ExecuteScalar(query);
            
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int InsertGoodsDeliveryNote(int id_employee)
        {
            string query = string.Format("SP_Insert_GoodsDeliveryNote @Id_Employee");
            int result;
            try
            {
                return (int) DataProvider.Instance.ExecuteScalar(query,
                    new object[] { id_employee });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
