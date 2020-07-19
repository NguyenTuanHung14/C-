using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniStopApplication.DTO
{
   public class Bill
    {
        private int id_bill;
        private DateTime date_create;
        private DateTime time;
        private float total;
        private int id_employee;

        public Bill(DateTime date_create, DateTime time, float total, int id_employee)
        {
            this.Date_create = date_create;
            this.Time = time;
            this.Total = total;
            this.Id_employee = id_employee;
        }

        public Bill(int id_bill, DateTime date_create, DateTime time, float total, int id_employee)
        {
            this.Id_bill = id_bill;
            this.Date_create = date_create;
            this.Time = time;
            this.Total = total;
            this.Id_employee = id_employee;
        }

        public int Id_bill { get => id_bill; set => id_bill = value; }
        public DateTime Date_create { get => date_create; set => date_create = value; }
        public DateTime Time { get => time; set => time = value; }
        public float Total { get => total; set => total = value; }
        public int Id_employee { get => id_employee; set => id_employee = value; }
    }
}
