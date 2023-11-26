using DevFreela.Domain.Entities;
using DevFreela.Infra.Persistence;
using DevFreela.Services.InputModel;
using DevFreela.Services.Services.Interfaces;
using DevFreela.Services.ViewModel;

namespace DevFreela.Services.Services.Implementations
{
    public class SkillService : ISkillService
    {
        private readonly DevFreelaDbContext _context;
        public SkillService(DevFreelaDbContext devFreelaDbContext) 
        {
            _context = devFreelaDbContext;
        }

        public Guid Create(SkillInputModel inputModel)
        {
            var skill = new Skill(inputModel.Description);
            _context.Skills.Add(skill);

            return skill.Id;
        }

        public void Delete(Guid id)
        {
            var skill = _context.Skills.FirstOrDefault(x => x.Id == id);
            _context.Skills.Remove(skill);   
        }

        public List<SkillViewModel> GetAll()
        {
            var skills = _context.Skills.Select( x => new SkillViewModel(x.Id,x.Description));

            return skills.ToList();
        }

        public SkillViewModel GetById(Guid id)
        {
            var skill = _context.Skills.FirstOrDefault( x => x.Id.Equals(id));

            return new SkillViewModel(skill.Id,skill.Description);
        }

        public void Update(SkillInputModel inputModel)
        {
            throw new NotImplementedException();
        }
    }
}
