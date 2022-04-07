using GameDemo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Business.Abstract
{
    public interface IUserService
    {
        void Add(User user);
        void Delete(User user);
        void Update(User user);
        User GetById(int id);
        List<User> GetAll();
    }
}
