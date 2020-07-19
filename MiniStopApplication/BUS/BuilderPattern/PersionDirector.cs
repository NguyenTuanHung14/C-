using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniStopApplication.BUS.BuilderPattern
{
    class PersionDirector
    {
        public void Construct(PersonBuilder personBuilder,string fullName, DateTime birthDate, string email, string phone, int posision,string address)
        {
            personBuilder.BuildAddress(address);
            personBuilder.BuildBirthDate(birthDate);
            personBuilder.BuildEamil(email);
            personBuilder.BuildFullName(fullName);
            personBuilder.BuildPhone(phone);
        }
    }
}
