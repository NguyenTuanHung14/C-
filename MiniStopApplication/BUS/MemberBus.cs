
using System;
using System.Collections.Generic;
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


  
        public bool UpdateMemberPoint(int id_member, int usedPoint)
        {
            try
            {
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
