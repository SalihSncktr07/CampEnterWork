﻿using GameDemo.DataAccess.Abstract;
using GameDemo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.DataAccess.Concrete
{
    public class UserDal : IUserDal
    {
        List<User> _users;

        public UserDal()
        {
            _users = new List<User>();
        }

        public void Add(User user)
        {
            _users.Add(user);
        }

        public void Delete(User user)
        {
            int index = TryGetDataIndex(user);
            _users.Remove(_users[index]);
        }

        public User Get(Expression<Func<User, bool>> filter)
        {
            return _users.AsQueryable().SingleOrDefault(filter);
        }

        public List<User> GetAll(Expression<Func<User, bool>> filter = null)
        {
            return filter==null?_users:_users.AsQueryable().Where(filter).ToList();
        }

        public void Update(User user)
        {
            int index = TryGetDataIndex(user);
            _users[index] = user;
        }

        private int TryGetDataIndex(User user)
        {
            var result = _users.SingleOrDefault(e => e.Id == user.Id);
            if (result == null) throw new Exception("Üzerinde işlem yapılmak istenen data bulunamadı");

            var index = _users.FindIndex(e => e.Id == user.Id);
            return index;
        }
    }
}
