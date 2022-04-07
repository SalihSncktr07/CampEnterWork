using GameDemo.DataAccess.Abstract;
using GameDemo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.DataAccess.Concrete
{
    public class SellDal : ISellDal
    {
        List<Sell> _sells;

        public SellDal()
        {
            _sells = new List<Sell>();
        }

        public void Add(Sell sell)
        {
            _sells.Add(sell);
        }

        public void Delete(Sell sell)
        {
            int index = TryGetDataIndex(sell);
            _sells.Remove(_sells[index]);
        }

        public Sell Get(Expression<Func<Sell, bool>> filter)
        {
            return _sells.AsQueryable().SingleOrDefault(filter);
        }

        public List<Sell> GetAll(Expression<Func<Sell, bool>> filter = null)
        {
            return filter==null?_sells:_sells.AsQueryable().Where(filter).ToList();
        }

        public void Update(Sell sell)
        {
            int index = TryGetDataIndex(sell);
            _sells[index] = sell;
        }

        private int TryGetDataIndex(Sell sell)
        {
            var result = _sells.SingleOrDefault(e => e.Id == sell.Id);
            if (result == null) throw new Exception("Üzerinde işlem yapılmak istenen data bulunamadı");

            var index = _sells.FindIndex(e => e.Id == sell.Id);
            return index;
        }
    }
}
