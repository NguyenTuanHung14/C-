using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniStopApplication.DTO
{
   public class Categories
    {
        private int id_category;
        private string name_category;

        public Categories(string name_category)
        {
            this.name_category = name_category;
        }

        public Categories(int id_category, string name_category)
        {
            this.id_category = id_category;
            this.name_category = name_category;
        }

        public int Id_category { get => id_category; set => id_category = value; }
        public string Name_category { get => name_category; set => name_category = value; }
    }
}
