namespace WebAPI.Core.Entities
{
    public class Product : EntityBase
    {
        public string Description { get; set; }
        public decimal Value { get; set; }
    }
}