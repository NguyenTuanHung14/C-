using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniStopApplication.DTO
{
   public class Supplier
    {
        private int id;
        private string name;
        private string phone;
        private string address;
        private Array hinhAnh;

        public Supplier(string name, string phone, string address, Array hinhAnh)
        {
            this.Name = name;
            this.Phone = phone;
            this.Address = address;
            this.HinhAnh = hinhAnh;
        }

        public Supplier(int id, string name, string phone, string address, Array hinhAnh)
        {
            this.id = id;
            this.name = name;
            this.phone = phone;
            this.address = address;
            this.hinhAnh = hinhAnh;
        }

        public string Name { get => name; set => name = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Address { get => address; set => address = value; }
        public Array HinhAnh { get => hinhAnh; set => hinhAnh = value; }
        public int Id { get => id; set => id = value; }
    }
}
