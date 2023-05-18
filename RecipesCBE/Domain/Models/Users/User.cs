namespace Domain.Models.Users
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Login { get; set; }

        public DateTime CreatedDate { get; set; }

        public string Password { get; set; }
    }
}
