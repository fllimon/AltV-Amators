using AltV.Net.Data;


namespace Alt_Amators.Entity
{
    public class User
    {
        public Guid Id { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public string SocialClubName { get; set; }

        public int Money { get; set; }

        public float X { get; set; }

        public float Y { get; set; }

        public float Z { get; set; }

        public DateTimeOffset RegistryDate { get; set; }

        public DateTimeOffset LastVisitDate { get; set; }

        public bool IsDeleted { get; set; } = false;

        public User()
        {
            Id = Guid.NewGuid();
        }
    }
}
