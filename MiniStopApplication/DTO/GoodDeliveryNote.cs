using DevExpress.XtraEditors.Filtering.Templates;
using DevExpress.XtraRichEdit.Layout.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniStopApplication.DTO
{
    public  class GoodDeliveryNote
    {
        private int id_goodDeliveryNote;
        private Date date_create;
        private DateTime time;
        private int total;
        private int id_employee;

        public GoodDeliveryNote(Date date_create, DateTime time, int total, int id_employee)
        {
            this.date_create = date_create;
            this.time = time;
            this.total = total;
            this.id_employee = id_employee;
        }

        public GoodDeliveryNote(int id_goodDeliveryNote, Date date_create, DateTime time, int total, int id_employee)
        {
            this.id_goodDeliveryNote = id_goodDeliveryNote;
            this.date_create = date_create;
            this.time = time;
            this.total = total;
            this.id_employee = id_employee;
        }

        public int Id_goodDeliveryNote { get => id_goodDeliveryNote; set => id_goodDeliveryNote = value; }
        public Date Date_create { get => date_create; set => date_create = value; }
        public DateTime Time { get => time; set => time = value; }
        public int Total { get => total; set => total = value; }
        public int Id_employee { get => id_employee; set => id_employee = value; }
    }
}
