using System.ComponentModel.DataAnnotations;

namespace Task4Back.Models.Users
{
    public class DeleteRequest
    {
        [Required]
        public int Id { get; set; }
    }
}