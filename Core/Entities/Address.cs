namespace Core.Entities
{
    public class Address : EntityBase
    {
        public string Street { set; get; }
        public string City { set; get; }
        public int PostalCode { set; get; }
    }
}
