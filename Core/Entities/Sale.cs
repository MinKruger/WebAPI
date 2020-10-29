namespace WebAPI.Core.Entities
{
    public class Sale : EntityBase
    {
        public decimal TotalValue { get; set; }
        public int ClientId { get; set; }
        public int HeadOfficeId { get; set; }
        public virtual Item Item { get; set; }
    }
}