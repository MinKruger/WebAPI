namespace WebAPI.Models
{
    public abstract class Item : EntityBase
    {
        public int SaleId { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}