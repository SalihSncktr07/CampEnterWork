using GameDemo.Entities.Concrete;
using System.Collections.Generic;

namespace GameDemo.Business.Abstract
{
    public interface ISellService
    {
        void Add(Sell sell);
        void Delete(Sell sell);
        void Update(Sell sell);
        Sell GetById(int id);
        List<Sell> GetAll();
    }
}
