namespace Core.Entities
{
    public class Owner : EntityBase
    {

        public string FullName { set; get; }
        public string Avatar { set; get; }
        public string Profile { set; get; }
        public Address Address { set; get; }
    }
}
