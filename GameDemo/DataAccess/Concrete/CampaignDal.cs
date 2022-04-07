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
    public class CampaignDal : ICampaignDal
    {
        List<Campaign> _campaigns;

        public CampaignDal()
        {
            _campaigns = new List<Campaign>();
        }

        public void Add(Campaign campaign)
        {
            _campaigns.Add(campaign);
        }

        public void Delete(Campaign campaign)
        {
            int index = TryGetDataIndex(campaign);
            _campaigns.Remove(_campaigns[index]);
        }

        public Campaign Get(Expression<Func<Campaign, bool>> filter)
        {
            return _campaigns.AsQueryable().SingleOrDefault(filter);
        }

        public List<Campaign> GetAll(Expression<Func<Campaign, bool>> filter = null)
        {
            return filter==null?_campaigns:_campaigns.AsQueryable().Where(filter).ToList();

        }

        public void Update(Campaign campaign)
        {
            int index = TryGetDataIndex(campaign);
            _campaigns[index] = campaign;
        }

        private int TryGetDataIndex(Campaign campaign)
        {
            var result = _campaigns.SingleOrDefault(e => e.Id == campaign.Id);
            if (result == null) throw new Exception("Üzerinde işlem yapılmak istenen data bulunamadı");

            var index = _campaigns.FindIndex(e => e.Id == campaign.Id);
            return index;
        }
    }
}
