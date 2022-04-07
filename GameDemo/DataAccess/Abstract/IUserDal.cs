using GameDemo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.DataAccess.Abstract
{
    public interface IUserDal
    {
        void Add(User user);
        void Update(User user);
        void Delete(User user);
        User Get(Expression<Func<User,bool>> filter);
        List<User> GetAll(Expression<Func<User,bool>> filter=null);
    }
}
