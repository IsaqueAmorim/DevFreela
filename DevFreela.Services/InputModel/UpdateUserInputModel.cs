using DevFreela.Domain.Enums.User;

namespace DevFreela.Services.InputModel
{
    public class UpdateUserInputModel
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }
        public string CPF { get; private set; }
        public DateTime BirthDate { get; private set; }

    }
}