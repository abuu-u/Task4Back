namespace Task4Back.Models.Users
{
    public class UserModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public bool Status { get; set; }

        public DateTime LastLogin { get; set; }

        public DateTime Created { get; set; }
    }
}