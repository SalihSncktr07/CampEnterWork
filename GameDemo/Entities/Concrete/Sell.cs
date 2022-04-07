using GameDemo.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Entities.Concrete
{
    public class Sell:IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int CampaignId { get; set; }
        public decimal Price { get; set; }
    }
}
