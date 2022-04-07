using GameDemo.Entities.Abstract;

namespace GameDemo.Entities.Concrete
{
    public class Campaign : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte DiscountRate { get; set; }
    }
}
