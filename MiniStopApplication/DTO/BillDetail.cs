using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniStopApplication.DTO
{
    public class BillDetail
    {
        private int id_billDetail;
        private float price;
        private int amount;
        private int id_bill;
        private int id_product;

        public BillDetail(float price, int amount, int id_bill, int id_product)
        {
            this.Price = price;
            this.Amount = amount;
            this.Id_bill = id_bill;
            this.Id_product = id_product;
        }

        public BillDetail(int id_billDetail, float price, int amount, int id_bill, int id_product)
        {
            this.Id_billDetail = id_billDetail;
            this.Price = price;
            this.Amount = amount;
            this.Id_bill = id_bill;
            this.Id_product = id_product;
        }

        public int Id_billDetail { get => id_billDetail; set => id_billDetail = value; }
        public float Price { get => price; set => price = value; }
        public int Amount { get => amount; set => amount = value; }
        public int Id_bill { get => id_bill; set => id_bill = value; }
        public int Id_product { get => id_product; set => id_product = value; }
    }
}
