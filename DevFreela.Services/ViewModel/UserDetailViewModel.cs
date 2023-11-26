using DevFreela.Domain.Entities.Project;
using DevFreela.Domain.Entities.User;
using DevFreela.Domain.Enums.User;

namespace DevFreela.Services.ViewModel
{
    public class UserDetailViewModel
    {
        public UserDetailViewModel(
            string firstName,
            string lastName, 
            string email, 
            string cpf,
            UserStatusEnum status,
            DateTime birthDate,
            DateTime createdAt,
            List<UserSkill> skills,
            List<Project> ownedProjects,
            List<Project> freelanceProjects)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            CPF = cpf;
            Status = status;
            BirthDate = birthDate;
            CreatedAt = createdAt;
            Skills = skills;
            OwnedProjects = ownedProjects;
            FreelanceProjects = freelanceProjects;
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }
        public string CPF { get; private set; }
        public UserStatusEnum Status { get; private set; }
        public DateTime BirthDate { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public List<UserSkill> Skills { get; private set; }
        public List<Project> OwnedProjects { get; private set; }
        public List<Project> FreelanceProjects { get; private set; }
    }
}