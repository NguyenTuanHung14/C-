using DevExpress.XtraEditors.Filtering.Templates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniStopApplication.DTO
{
    public class Product
    {
        private int id_product;
        private string name_product;
        private float price;
        private int amount;
        private DateTime mFG_date;
        private DateTime eXP_date;
        private float discount;
        private int id_ProductType;

        public Product(string name_product, float price, int amount, DateTime mFG_date, DateTime eXP_date, float discount, int id_productType)
        {
            this.name_product = name_product;
            this.price = price;
            this.amount = amount;
            this.mFG_date = mFG_date;
            this.eXP_date = eXP_date;
            this.discount = discount;
            this.id_ProductType = id_productType;
        }

        public int Id_product { get => id_product; set => id_product = value; }
        public string Name_product { get => name_product; set => name_product = value; }
        public float Price { get => price; set => price = value; }
        public int Amount { get => amount; set => amount = value; }
        public DateTime MFG_date { get => mFG_date; set => mFG_date = value; }
        public DateTime EXP_date { get => eXP_date; set => eXP_date = value; }
        public float Discount { get => discount; set => discount = value; }
        public int Id_ProductType { get => id_ProductType; set => id_ProductType = value; }
    }
}
