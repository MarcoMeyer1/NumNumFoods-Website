namespace NumNumFoods.Services
{
    public class UserState
    {
        public event Action OnChange;

        public int UserId { get; private set; } // Added UserId property
        private string _role;
        public string _userFullName;
        private string _userEmail;
        private bool _isLoggedIn;

        public string Role
        {
            get => _role;
            private set
            {
                if (_role != value)
                {
                    _role = value;
                    NotifyStateChanged();
                }
            }
        }

        public string UserFullName
        {
            get => _userFullName;
            private set
            {
                if (_userFullName != value)
                {
                    _userFullName = value;
                    NotifyStateChanged();
                }
            }
        }

        public string UserEmail
        {
            get => _userEmail;
            private set
            {
                if (_userEmail != value)
                {
                    _userEmail = value;
                    NotifyStateChanged();
                }
            }
        }

        public bool IsLoggedIn => _isLoggedIn; // Property to check login status

        public void SetUser(int userId, string fullName, string email, string role)
        {
            UserId = userId; // Set the UserId
            UserFullName = fullName;
            UserEmail = email;
            Role = role;
            _isLoggedIn = true; // Set the user as logged in
            NotifyStateChanged();
        }

        public void Logout()
        {
            UserId = 0; // Reset the UserId
            _userFullName = null;
            _userEmail = null;
            Role = null;
            _isLoggedIn = false; // Set the user as logged out
            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}