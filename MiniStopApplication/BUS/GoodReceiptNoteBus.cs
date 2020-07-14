using MiniStopApplication.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniStopApplication.BUS
{
   public class GoodReceiptNoteBus
    {
        private static GoodReceiptNoteBus instance;

        public static GoodReceiptNoteBus Instance
        {
            get
            {
                if (instance == null)
                    instance = new GoodReceiptNoteBus();
                return instance;
            }
        }
        public int InsertReceiptNote(int id_employee)
        {
            try
            {
                return ProcessGoodReceiptNote.Instance.InsertGoodsReceiptNote(id_employee);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public int getGoodsReceiptNoteByDate()
        {
            try
            {
                return (int)ProcessGoodReceiptNote.Instance.getGoodsReceiptNoteByDate();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
