
using MiniStopApplication.DAO;
using MiniStopApplication.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniStopApplication.BUS
{
   public class MemberBus
    {
        private static MemberBus instance;

        public static MemberBus Instance
        {
            get
            {
                if (instance == null)
                    instance = new MemberBus();
                return instance;
            }
        }

        public bool InsertMember(Member member)
        {
         
            try
            {
                return ProccessMember.Instance.InsertMember(member);
            }
            catch (Exception ex)
            {
                throw ex;
            }
          
        }

        public bool UpdateMemberPoint(int id_member, int usedPoint)
        {
            try
            {
                return ProccessMember.Instance.UpdateScoreMember(id_member, usedPoint); ;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable getMember(string email)
        {
            try
            {
                return ProccessMember.Instance.getMember(email);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
