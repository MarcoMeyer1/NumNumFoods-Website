namespace NumNumFoods.Models
{
    public class LoginResponse
    {
        public string Message { get; set; }
        public User User { get; set; }
    }

    public class User
    {
        public int UserId { get; set; } // Ensure UserId is included
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public string PhoneNumber { get; set; } // New property
    }

}
