using MiniStopApplication.BUS.BuilderPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniStopApplication.BUS
{
    class AdminBuilder:PersonBuilder
    {
        public AdminBuilder()
        {
            instance = new Person("Admin");
          
        }
        public override PersonBuilder BuildAddress(string Address)
        {
            this.instance.Address = Address;
            return this;
        }

        public override PersonBuilder BuildBirthDate(DateTime birthDate)
        {
            this.instance.BirthDate = birthDate;
            return this;
        }

        public override PersonBuilder BuildEamil(string email)
        {
            this.instance.Email = email;
            return this;
        }

        public override PersonBuilder BuildFullName(string fullName)
        {
            this.instance.FullName = fullName;
            return this;
        }

        public override PersonBuilder BuildPhone(string phone)
        {
            this.instance.Phone = phone;
            return this;
        }

        public override PersonBuilder BuildPosition(int position)
        {
            instance.Position = position;
            return this;
        }

        public override Person getPerson()
        {
            return this.instance;
        }
    }
}
