using GameDemo.Business.Abstract;
using GameDemo.Business.Concrete;
using GameDemo.Business.Utilities.UserCheck;
using GameDemo.DataAccess.Concrete;
using GameDemo.Entities.Concrete;
using System;

namespace GameDemo
{
    class Program
    {
        static IUserService _userService;
        static ICampaignService _campaignService;
        static ISellService _sellService;

        static Program()
        {
            _userService = new UserManager(new UserDal(),new MernisCheckAdapter());
            _campaignService = new CampaignManager(new CampaignDal());
            _sellService = new SellManager(new SellDal(),_campaignService);
        }

        static void Main(string[] args)
        {
            var user = new User { Id = 1, FirstName = "Mustafa", LastName = "Aktoz", NationalityIdentity = "12345678910", BirthYear = "1998" };
            _userService.Add(user);

            var campaign = new Campaign { Id = 1, Name = "Summer", DiscountRate = 49 };
            _campaignService.Add(campaign);

            var sell = new Sell { Id = 1, UserId = 1, CampaignId = 1, Price = 100 };
            _sellService.Add(sell);

            user.FirstName = "Ahmet";
            _userService.Update(user);

            Console.WriteLine("\n-----------------------------------\n");
            Console.WriteLine("Kullanıcılar Listeleniyor...");
            var users = _userService.GetAll();
            foreach (var currentUser in users) Console.WriteLine($"{currentUser.Id}- {currentUser.FirstName} {currentUser.LastName}");
            
            Console.WriteLine("\n-----------------------------------\n");
            Console.WriteLine("Kampanyalar Listeleniyor...");
            var campaigns = _campaignService.GetAll();
            campaigns.ForEach(currentCampaign => Console.WriteLine($"{currentCampaign.Id}- {currentCampaign.Name} {currentCampaign.DiscountRate}%"));

            Console.WriteLine("\n-----------------------------------\n");
            Console.WriteLine("Satışlar Listeleniyor...");
            var sells = _sellService.GetAll();
            sells.ForEach(currentSell => Console.WriteLine($"{currentSell.Id}- '{currentSell.UserId}' nolu kullanıcıya '{currentSell.CampaignId}' nolu kampanya uygulandı '{currentSell.Price}' birim fiyata satıldı"));

            Console.WriteLine("\n-----------------------------------\n");
        }
    }
}
