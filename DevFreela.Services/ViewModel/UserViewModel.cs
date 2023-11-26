using DevFreela.Domain.Enums.User;

namespace DevFreela.Services.ViewModel
{
    public class UserViewModel
    {
        public UserViewModel(string firstName, string lastName, string email, UserStatusEnum status)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Status = status;
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }
        public UserStatusEnum Status { get; private set; }
    }
}