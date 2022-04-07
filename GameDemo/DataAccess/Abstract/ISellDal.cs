using GameDemo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace GameDemo.DataAccess.Abstract
{
    public interface ISellDal
    {
        void Add(Sell sell);
        void Update(Sell sell);
        void Delete(Sell sell);
        Sell Get(Expression<Func<Sell, bool>> filter);
        List<Sell> GetAll(Expression<Func<Sell, bool>> filter = null);
    }
}
