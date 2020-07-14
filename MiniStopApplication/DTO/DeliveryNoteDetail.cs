using DevExpress.PivotGrid.OLAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniStopApplication.DTO
{
   public class DeliveryNoteDetail
    {
        private int id_deliveryNoteDetail;
        private int id_goodsDeliverNote;
        private int id_product;
        private int amount;

        public DeliveryNoteDetail(int id_goodsDeliverNote, int id_product, int amount)
        {
            this.id_goodsDeliverNote = id_goodsDeliverNote;
            this.id_product = id_product;
            this.amount = amount;
        }

        public DeliveryNoteDetail(int id_deliveryNoteDetail, int id_goodsDeliverNote, int id_product, int amount)
        {
            this.id_deliveryNoteDetail = id_deliveryNoteDetail;
            this.id_goodsDeliverNote = id_goodsDeliverNote;
            this.id_product = id_product;
            this.amount = amount;
        }

        public int Id_deliveryNoteDetail { get => id_deliveryNoteDetail; set => id_deliveryNoteDetail = value; }
        public int Amount { get => amount; set => amount = value; }
        public int Id_goodsDeliverNote { get => id_goodsDeliverNote; set => id_goodsDeliverNote = value; }
        public int Id_product { get => id_product; set => id_product = value; }
    }
}
