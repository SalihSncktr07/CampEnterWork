using GameDemo.Entities.Concrete;
using System.Collections.Generic;

namespace GameDemo.Business.Abstract
{
    public interface ICampaignService
    {
        void Add(Campaign campaign);
        void Delete(Campaign campaign);
        void Update(Campaign campaign);
        Campaign GetById(int id);
        List<Campaign> GetAll();
        void ApplyCampaign(Sell sell);
    }
}
