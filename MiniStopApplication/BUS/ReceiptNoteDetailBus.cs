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
  public  class ReceiptNoteDetailBus
    {
        private static ReceiptNoteDetailBus instance;

        public static ReceiptNoteDetailBus Instance
        {
            get
            {
                if (instance == null)
                    instance = new ReceiptNoteDetailBus();
                return instance;
            }
        }
        public bool InsertReceiptNoteDetail(ReceiptNoteDetail receiptNoteDetail)
        {
            try
            {
                return ProccessReceiptNoteDetail.Instance.InsertDeliveryNodeDetail(receiptNoteDetail);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public DataTable getListReceiptNodeDetail()
        {
            try
            {
                return ProccessReceiptNoteDetail.Instance.getListReceiptNodeDetail();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public DataTable getListByIdReceiptNodeDetail(int id)
        {
            try
            {
                return ProccessReceiptNoteDetail.Instance.getListByIdReceiptNodeDetail(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
