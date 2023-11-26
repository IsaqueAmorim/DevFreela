using DevFreela.Services.InputModel;
using DevFreela.Services.ViewModel;

namespace DevFreela.Services.Services.Interfaces
{
    public interface IUserService
    {
        Guid Create(NewUserInputModel inputModel);
        void Delete(Guid id);
        void Update(UpdateUserInputModel inputModel);
        List<UserViewModel> GetAll();
        UserDetailViewModel GetById(Guid id);

    }
}
