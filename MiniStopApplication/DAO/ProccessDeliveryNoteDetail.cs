using MiniStopApplication.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniStopApplication.DAO
{
   public class ProccessDeliveryNoteDetail
    {
        private static ProccessDeliveryNoteDetail instance;
        public static ProccessDeliveryNoteDetail Instance
        {
            get
            {
                if (instance == null)
                    instance = new ProccessDeliveryNoteDetail();
                return ProccessDeliveryNoteDetail.instance;
            }
        }
        public DataTable getListDeliveryNodeDetail()
        {
            try
            {
                return DataProvider.Instance.ExecuteQuery("SP_GetAll_DeliveryNoteDetail");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable getListByIdDeliveryNodeDetail(int id)
        {
            string query = string.Format("SP_GetAllByID_DeliveryNoteDetail @Id");
       
            try
            {
               return DataProvider.Instance.ExecuteQuery(query, new object[] { id});
            }
            catch (Exception ex)
            {
                throw ex;
            }
   
        }
        public bool InsertDeliveryNodeDetail(DeliveryNoteDetail deliveryNoteDetail)
        {
            string query = string.Format("SP_Insert_DeliveryNoteDetail @Id_GoodsDeliveryNote , @Id_product , @Amount");
            int result;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(query,
                    new object[] { deliveryNoteDetail.Id_goodsDeliverNote, deliveryNoteDetail.Id_product,deliveryNoteDetail.Amount});
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }
    }
}
