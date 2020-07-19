using MiniStopApplication.BUS.BuilderPattern;
using MiniStopApplication.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniStopApplication.BUS
{
   public class PersonBus
    {
        private static PersonBus instance;

        public static PersonBus Instance
        {
            get
            {
                if (instance == null)
                    instance = new PersonBus();
                return instance;
            }
        }


        public DataTable GetAllPerson()
        {
            try
            {
                return ProccessPerson.Instance.GetAllPerson();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool InsertPerson(Person person)
        {
            try
            {
                return ProccessPerson.Instance.InsertPerson(person);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool DeletePerson(int Id_employee)
        {
            try
            {
                return ProccessPerson.Instance.DeletePerson(Id_employee);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool UpdatePerson(Person person, int id_employee)
        {
            try
            {
                return ProccessPerson.Instance.UpdatePerson(person, id_employee);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
