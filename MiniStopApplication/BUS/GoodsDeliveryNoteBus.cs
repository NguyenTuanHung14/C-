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
   public class GoodsDeliveryNoteBus
    {
        private static GoodsDeliveryNoteBus instance;

        public static GoodsDeliveryNoteBus Instance
        {
            get
            {
                if (instance == null)
                    instance = new GoodsDeliveryNoteBus();
                return instance;
            }
        }
        public int InsertDeliveryNote(int id_employee)
        {
            try
            {
                return ProccessGoodsDeliveryNote.Instance.InsertGoodsDeliveryNote(id_employee);
            }
            catch (Exception ex)
            {
                throw ex; 
            }

        }
        public int getGoodsDeliveryNoteByDate()
        {
            try
            {
                return (int)ProccessGoodsDeliveryNote.Instance.getGoodsDeliveryNoteByDate();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
