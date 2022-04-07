using GameDemo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Business.Utilities.UserCheck
{
    public interface IUserCheckService
    {
        bool Check(User user);
    }
}
