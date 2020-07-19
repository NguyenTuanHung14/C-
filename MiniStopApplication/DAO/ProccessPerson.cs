using MiniStopApplication.BUS.BuilderPattern;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniStopApplication.DAO
{
   public class ProccessPerson
    {
        private static ProccessPerson instance;
        public static ProccessPerson Instance
        {
            get
            {
                if (instance == null)
                    instance = new ProccessPerson();
                return ProccessPerson.instance;
            }
        }

        public DataTable GetAllPerson()
        {
            try
            {
                return DataProvider.Instance.ExecuteQuery("SP_GetAll_Employee");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool InsertPerson(Person person)
        {
            string query = string.Format("SP_Insert_Employee @Last_name , @Phone , @Birth_day , @Address , @Email , @Id_Position ");
            int result;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(query,
                    new object[] { person.FullName, person.Phone, person.BirthDate, person.Address, person.Email, person.Position});
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }

        public bool DeletePerson(int Id_employee)
        {
            string query = string.Format("SP_Delete_Employee @Id_employee");
            int result;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { Id_employee });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }

        public bool UpdatePerson(Person person, int id_employee)
        {
            string query = string.Format("SP_Update_Employee @Id_employee , @Last_name , @Phone , @Birth_day , @Address , @Email , @Id_Position");
            int result;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(query,
                    new object[] { id_employee, person.FullName, person.Phone, person.BirthDate, person.Address, person.Email, person.Position });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }
    }
}
