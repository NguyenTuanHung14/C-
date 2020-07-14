using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniStopApplication.DTO
{
   public class GoodReceiptNote
    {
        private int id_GoodReceiptNote;
        private DateTime date_create;
        private DateTime time_create;
        private float total;
        private int id_employee;

        public GoodReceiptNote(DateTime date_create, DateTime time_create, float total, int id_employee)
        {
            this.date_create = date_create;
            this.time_create = time_create;
            this.total = total;
            this.id_employee = id_employee;
        }

        public GoodReceiptNote(int id_GoodReceiptNote, DateTime date_create, DateTime time_create, float total, int id_employee)
        {
            this.id_GoodReceiptNote = id_GoodReceiptNote;
            this.date_create = date_create;
            this.time_create = time_create;
            this.total = total;
            this.id_employee = id_employee;
        }

        public int Id_GoodReceiptNote { get => id_GoodReceiptNote; set => id_GoodReceiptNote = value; }
        public DateTime Date_create { get => date_create; set => date_create = value; }
        public DateTime Time_create { get => time_create; set => time_create = value; }
        public float Total { get => total; set => total = value; }
        public int Id_employee { get => id_employee; set => id_employee = value; }
    }
}
