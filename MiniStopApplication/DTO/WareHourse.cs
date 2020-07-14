using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniStopApplication.DTO
{
   public class WareHourse
    {
        private int id_product;
        private int inventory_number;

        public WareHourse(int id_product, int inventory_number)
        {
            this.id_product = id_product;
            this.inventory_number = inventory_number;
        }

        public int Id_product { get => id_product; set => id_product = value; }
        public int Inventory_number { get => inventory_number; set => inventory_number = value; }
    }
}
