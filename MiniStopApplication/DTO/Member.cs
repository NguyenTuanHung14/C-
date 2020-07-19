using DevExpress.XtraRichEdit.Layout.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniStopApplication.DTO
{
   public class Member
    {
        private string name;
        private string phone;
        private string email;

        public Member(string name, string phone, string email)
        {
            this.Name = name;
            this.Phone = phone;
            this.Email = email;
        }

        public string Name { get => name; set => name = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }
    }
}
