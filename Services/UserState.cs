namespace NumNumFoods.Services
{
    public class UserState
    {
        public event Action OnChange;

        private string _role;

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

        public void SetRole(string role)
        {
            Role = role;
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }

}
