using DevExpress.XtraEditors.Filtering.Templates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniStopApplication.DTO
{
   public class ReceiptNoteDetail
    {
        private int id_ReceiptNoteDetail;
        private float price;
        private int amount;
        private int id_goodReceiptNote;
        private int id_product;
        private DateTime mFG_date;
        private DateTime eXP_date;
        private int id_supplier;

        public ReceiptNoteDetail(float price, int amount, int id_goodReceiptNote, int id_product, DateTime mFG_date, DateTime eXP_date, int id_supplier)
        {
            this.price = price;
            this.amount = amount;
            this.id_goodReceiptNote = id_goodReceiptNote;
            this.id_product = id_product;
            this.mFG_date = mFG_date;
            this.eXP_date = eXP_date;
            this.Id_supplier = id_supplier;
        }

        public ReceiptNoteDetail(int id_ReceiptNoteDetail, float price, int amount, int id_goodReceiptNote, int id_product, DateTime mFG_date, DateTime eXP_date, int id_supplier)
        {
            this.id_ReceiptNoteDetail = id_ReceiptNoteDetail;
            this.price = price;
            this.amount = amount;
            this.id_goodReceiptNote = id_goodReceiptNote;
            this.id_product = id_product;
            this.mFG_date = mFG_date;
            this.eXP_date = eXP_date;
            this.Id_supplier = id_supplier;
        }

        public int Id_ReceiptNoteDetail { get => id_ReceiptNoteDetail; set => id_ReceiptNoteDetail = value; }
        public float Price { get => price; set => price = value; }
        public int Amount { get => amount; set => amount = value; }
        public int Id_goodReceiptNote { get => id_goodReceiptNote; set => id_goodReceiptNote = value; }
        public int Id_product { get => id_product; set => id_product = value; }
        public DateTime MFG_date { get => mFG_date; set => mFG_date = value; }
        public DateTime EXP_date { get => eXP_date; set => eXP_date = value; }
        public int Id_supplier { get => id_supplier; set => id_supplier = value; }
    }
}
