using MiniStopApplication.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniStopApplication.DAO
{
   public class ProccessMember
    {
        private static ProccessMember instance;
        public static ProccessMember Instance
        {
            get
            {
                if (instance == null)
                    instance = new ProccessMember();
                return ProccessMember.instance;
            }
        }

        public bool UpdateScoreMember(int id_member,int score)
        {
            string query = string.Format("SP_UpdateScore_Card @Id_member , @score ");
            int result;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(query,
                    new object[] { id_member , score });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }
        public bool InsertMember(Member member)
        {
            string query = string.Format("SP_Insert_Customer @First_name , @Phone , @Email ");
            int result;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(query,
                    new object[] { member.Name, member.Phone, member.Email });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }
        public DataTable getMember(string email)
        {
            try
            {
                return DataProvider.Instance.ExecuteQuery("SP_GetByEmail_Member @Email", new object[] { email });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
