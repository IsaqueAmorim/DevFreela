using DevFreela.Domain.Entities.Project;
using DevFreela.Domain.Entities.User;

namespace DevFreela.Infra.Persistence
{
    public class DevFreelaDbContext
    {
        public List<Projects> Projects {get; set;}
        public List<User> Users { get; set; }
        public List<Skill> Skills { get; set; }
    }
}