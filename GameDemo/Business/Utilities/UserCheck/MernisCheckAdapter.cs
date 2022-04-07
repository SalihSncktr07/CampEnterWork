using GameDemo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Business.Utilities.UserCheck
{
    public class MernisCheckAdapter : IUserCheckService
    {
        public bool Check(User user)
        {
            if(user.FirstName=="Mustafa"&&user.LastName=="Aktoz" && user.NationalityIdentity=="12345678910"&&user.BirthYear=="1998")
                return true;
            else
                return false;
        }
    }
}
