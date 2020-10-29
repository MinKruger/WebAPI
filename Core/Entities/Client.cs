namespace WebAPI.Core.Entities
{
    public class Client : EntityBase
    {
        public string Name { get; set; }
        public int HeadOfficeId { get; set; }
        public virtual HeadOffice HeadOffice { get; set; }
    }
}