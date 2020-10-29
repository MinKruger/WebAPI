namespace WebAPI.Core.Entities
{
    public class Item : EntityBase
    {
        public int SaleId { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}