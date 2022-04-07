using GameDemo.Business.Abstract;
using GameDemo.DataAccess.Abstract;
using GameDemo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Business.Concrete
{
    public class CampaignManager : ICampaignService
    {
        ICampaignDal _campaignDal;

        public CampaignManager(ICampaignDal campaignDal)
        {
            _campaignDal = campaignDal;
        }

        public void Add(Campaign campaign)
        {
            _campaignDal.Add(campaign);
            Console.WriteLine("Kampanya Eklendi");
        }

        public void ApplyCampaign(Sell sell)
        {
            var campaign=_campaignDal.Get(c => c.Id == sell.CampaignId);
            sell.Price = sell.Price * campaign.DiscountRate / 100;
            Console.WriteLine("Kampanya Uygulandı");
        }

        public void Delete(Campaign campaign)
        {
            _campaignDal.Delete(campaign);
            Console.WriteLine("Kampanya Silindi");
        }

        public List<Campaign> GetAll()
        {
            return _campaignDal.GetAll();
        }

        public Campaign GetById(int id)
        {
            return _campaignDal.Get(c=>c.Id==id);
        }

        public void Update(Campaign campaign)
        {
            _campaignDal.Update(campaign);
            Console.WriteLine("Kampanya Güncellendi");

        }
    }
}
