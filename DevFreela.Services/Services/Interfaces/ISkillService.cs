
using DevFreela.Services.InputModel;
using DevFreela.Services.ViewModel;

namespace DevFreela.Services.Services.Interfaces
{
    public interface ISkillService
    {
        List<SkillViewModel> GetAll();
        SkillViewModel GetById(Guid id);
        Guid Create(SkillInputModel inputModel);
        void Update(SkillInputModel inputModel);
        void Delete(Guid id);
    }
}
