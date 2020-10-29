namespace WebAPI.Models
{
    public abstract class HeadOffice : EntityBase
    {
        public string Name { get; set; }
        public virtual Client Client { get; set; }
    }
}