using DevFreela.Domain.Enums.User;

namespace DevFreela.Services.InputModel
{
    public class NewUserInputModel
    {
        public NewUserInputModel(string firstName, string lastName, string email, string cpf, DateTime birthDate)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            CPF = cpf;
            BirthDate = birthDate;
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }
        public string CPF { get; private set; }
        public DateTime BirthDate { get; private set; }

    }
}