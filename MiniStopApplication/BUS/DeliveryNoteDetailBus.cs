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
   public class DeliveryNoteDetailBus
    {
        private static DeliveryNoteDetailBus instance;

        public static DeliveryNoteDetailBus Instance
        {
            get
            {
                if (instance == null)
                    instance = new DeliveryNoteDetailBus();
                return instance;
            }
        }
        public bool InsertDeliveryNoteDetail(DeliveryNoteDetail deliveryNoteDetail) {
            try
            {
                return ProccessDeliveryNoteDetail.Instance.InsertDeliveryNodeDetail(deliveryNoteDetail);
            }
            catch (Exception ex) {
                throw ex;
            }
            
        }
        public DataTable getListDeliveryNodeDetail() {
            try
            {
                return ProccessDeliveryNoteDetail.Instance.getListDeliveryNodeDetail();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public DataTable getListByIdDeliveryNodeDetail(int id)
        {
            try
            {
                return ProccessDeliveryNoteDetail.Instance.getListByIdDeliveryNodeDetail(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
