using System;
using DevExpress.Xpo;

namespace MiniStopApplication.DTO
{

    public class ProductType
    {
        private int id_productType;
        private string name;
            
        public ProductType(string name)
        {
            this.name = name;
        }

        
        public int Id_productType { get => id_productType; set => id_productType = value; }
        public string Name { get => name; set => name = value; }
    }

}