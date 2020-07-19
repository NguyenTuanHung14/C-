using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniStopApplication.BUS.BuilderPattern
{
    abstract class PersonBuilder
    {

        protected Person instance;

        // Gets vehicle instance

        public Person Instance
        {
            get { return instance; }
        }


        public abstract PersonBuilder BuildFullName(string fullName);
        public abstract PersonBuilder BuildPhone(string phone); 
        public abstract PersonBuilder BuildBirthDate(DateTime birthDate);
        public abstract PersonBuilder BuildAddress(string Address);
        public abstract PersonBuilder BuildEamil(string email);
        public abstract PersonBuilder BuildPosition(int position);

        public abstract Person getPerson();
    }
}
