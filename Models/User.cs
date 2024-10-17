namespace NumNumFoods.Models
{
    public class LoginResponse
    {
        public string Message { get; set; }
        public User User { get; set; }
    }

    public class User
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
    }

}
