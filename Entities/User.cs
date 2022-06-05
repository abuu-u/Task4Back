using System.Text.Json.Serialization;

namespace Task4Back.Entities
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public bool Status { get; set; }

        public DateTime LastLogin { get; set; }

        public DateTime Created { get; set; }

        [JsonIgnore]
        public string PasswordHash { get; set; }
    }
}