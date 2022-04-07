using GameDemo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace GameDemo.DataAccess.Abstract
{
    public interface ICampaignDal
    {
        void Add(Campaign campaign);
        void Update(Campaign campaign);
        void Delete(Campaign campaign);
        Campaign Get(Expression<Func<Campaign, bool>> filter);
        List<Campaign> GetAll(Expression<Func<Campaign, bool>> filter = null);
    }
}
