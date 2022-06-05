namespace Task4Back.Models.Users
{
    public class GetPageResponse
    {
        public int PagesCount { get; set; }

        public List<UserModel> Users { get; set; }
    }
}