using DevFreela.Domain.Entities.Project;
using DevFreela.Domain.Enums.User;

namespace DevFreela.Domain.Entities.User
{
    public class User : BaseEntity
    {
        public User(string firstName, string lastName, string email, string cPF, DateTime birthDate)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            CPF = cPF;
            Status = UserStatusEnum.Active;
            BirthDate = birthDate;
            CreatedAt = DateTime.Now;

            Skills = new();
            OwnedProjects = new();
            FreelanceProjects = new();
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }
        public string CPF { get; private set; }
        public UserStatusEnum Status { get; private set; }
        public DateTime BirthDate { get; private set; }
        public DateTime CreatedAt { get; private set; }

        public List<UserSkill> Skills { get; private set; }
        public List<Projects> OwnedProjects { get; private set; }
        public List<Projects> FreelanceProjects { get; private set; }
    }
}
