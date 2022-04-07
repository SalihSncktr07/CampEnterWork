using GameDemo.Business.Abstract;
using GameDemo.Business.Utilities.UserCheck;
using GameDemo.DataAccess.Abstract;
using GameDemo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;
        IUserCheckService _userCheckService;
        public UserManager(IUserDal userDal, IUserCheckService userCheckService)
        {
            _userDal = userDal;
            _userCheckService = userCheckService;
        }

        public void Add(User user)
        {
            var result = _userCheckService.Check(user);
            if (!result) throw new Exception("Kimlik bilgilerinizi kontrol edin");

            _userDal.Add(user);
            Console.WriteLine("Kullanıcı Eklendi");
        }

        public void Delete(User user)
        {
            _userDal.Delete(user);
            Console.WriteLine("Kullanıcı Silindi");

        }

        public List<User> GetAll()
        {
            return _userDal.GetAll();
        }

        public User GetById(int id)
        {
            return _userDal.Get(u=>u.Id==id);
        }

        public void Update(User user)
        {
            _userDal.Update(user);
            Console.WriteLine("Kullanıcı Güncellendi");
        }
    }
}
