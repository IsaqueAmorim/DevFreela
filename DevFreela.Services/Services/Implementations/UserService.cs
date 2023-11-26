using DevFreela.Services.Services.Interfaces;
using DevFreela.Domain.Entities.User;
using DevFreela.Services.InputModel;
using DevFreela.Services.ViewModel;
using DevFreela.Infra.Persistence;

namespace DevFreela.Services.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly DevFreelaDbContext _context;
        
        public UserService(DevFreelaDbContext context) 
        {
            _context = context;        
        }

        public Guid Create(NewUserInputModel inputModel)
        {
            var user = new User(inputModel.FirstName,inputModel.LastName,inputModel.Email,inputModel.CPF,inputModel.BirthDate);
            _context.Users.Add(user);

            return user.Id;
        }

        public void Delete(Guid id)
        {
            var user = _context.Users.FirstOrDefault(x => x.Id == id);
            _context.Users.Remove(user);
        }

        public List<UserViewModel> GetAll()
        {
            var users = _context.Users.Select( x => new UserViewModel(x.FirstName,x.LastName,x.Email,x.Status));
            return users.ToList();
        }

        public UserDetailViewModel GetById(Guid id)
        {
            var user = _context.Users.FirstOrDefault(x => x.Id == id);

            return new UserDetailViewModel(
                user.FirstName,
                user.LastName,
                user.Email,
                user.CPF,
                user.Status,
                user.BirthDate,
                user.CreatedAt,
                user.Skills,
                user.OwnedProjects,
                user.FreelanceProjects
                );
        }

        public void Update(UpdateUserInputModel inputModel)
        {
            throw new NotImplementedException();
        }
    }
}
