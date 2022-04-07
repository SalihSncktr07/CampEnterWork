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
    public class SellManager : ISellService
    {
        ISellDal _sellDal;
        ICampaignService _campaignService;
        public SellManager(ISellDal sellDal, ICampaignService campaignService)
        {
            _sellDal = sellDal;
            _campaignService = campaignService;
        }

        public void Add(Sell sell)
        {
            _campaignService.ApplyCampaign(sell);
            _sellDal.Add(sell);
            Console.WriteLine("Satış Eklendi");
        }

        public void Delete(Sell sell)
        {
            _sellDal.Delete(sell);
            Console.WriteLine("Satış Silindi");
        }

        public List<Sell> GetAll()
        {
            return _sellDal.GetAll();
        }

        public Sell GetById(int id)
        {
            return _sellDal.Get(s=>s.Id==id);
        }

        public void Update(Sell sell)
        {
            _sellDal.Update(sell);
            Console.WriteLine("Satış Güncellendi");

        }
    }
}
