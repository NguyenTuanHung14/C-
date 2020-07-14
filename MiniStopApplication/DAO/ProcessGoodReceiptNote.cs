using MiniStopApplication.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniStopApplication.DAO
{
    class ProcessGoodReceiptNote
    {
        private static ProcessGoodReceiptNote instance;

        public static ProcessGoodReceiptNote Instance
        {
            get
            {
                if (instance == null)
                    instance = new ProcessGoodReceiptNote();
                return ProcessGoodReceiptNote.instance;
            }
        }

        public int getGoodsReceiptNoteByDate()
        {
            string query = string.Format("SP_Get_GoodsReceiptNote");

            try
            {
                return (int)DataProvider.Instance.ExecuteScalar(query);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int InsertGoodsReceiptNote(int id_employee)
        {
            string query = string.Format("SP_Insert_GoodsReceiptNote  @Id_Employee");
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
