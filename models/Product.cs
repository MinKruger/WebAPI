namespace WebAPI.Models
{
    public abstract class Product : EntityBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Value { get; set; }
    }
}