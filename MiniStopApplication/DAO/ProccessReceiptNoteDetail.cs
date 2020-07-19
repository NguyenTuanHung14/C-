using MiniStopApplication.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniStopApplication.DAO
{
    class ProccessReceiptNoteDetail
    {
        private static ProccessReceiptNoteDetail instance;
        public static ProccessReceiptNoteDetail Instance
        {
            get
            {
                if (instance == null)
                    instance = new ProccessReceiptNoteDetail();
                return ProccessReceiptNoteDetail.instance;
            }
        }
        public DataTable getListReceiptNodeDetail()
        {
            try
            {
                return DataProvider.Instance.ExecuteQuery("SP_GetAll_ReceiptNoteDetail");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable getListByIdReceiptNodeDetail(int id)
        {
            string query = string.Format("SP_GetAllByID_ReceiptNoteDetail @Id");

            try
            {
                return DataProvider.Instance.ExecuteQuery(query, new object[] { id });
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public bool InsertDeliveryNodeDetail(ReceiptNoteDetail receiptNoteDetail)
        {
            string query = string.Format("SP_Insert_ReceiptNoteDetail @Id_GoodsReceiptNote , @Id_product , @Price , @Amount , @MFG_date , @EXP_date , @Id_supplier");
            int result;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(query,
                    new object[] { receiptNoteDetail.Id_goodReceiptNote, receiptNoteDetail.Id_product, receiptNoteDetail.Price,
                    receiptNoteDetail.Amount,receiptNoteDetail.MFG_date,receiptNoteDetail.EXP_date,receiptNoteDetail.Id_supplier});
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }
    }
}
