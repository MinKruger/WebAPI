namespace WebAPI.Core.Entities
{
    public class Item : EntityBase
    {
        public int Quantity { get; set; }
        public int ProductId { get; set; }
        public int SaleId { get; set; }
        public virtual Sale Sale { get; set; }
    }
}