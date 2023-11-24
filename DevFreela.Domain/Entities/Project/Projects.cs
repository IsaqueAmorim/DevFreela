using DevFreela.Domain.Enums.Project;

namespace DevFreela.Domain.Entities.Project
{
    public class Projects : BaseEntity
    {
        public Projects(string tilte, string description, Guid iDClient, Guid iDFreelancer, double totalCost, DateTime createdAt)
        {
            Tilte = tilte;
            Description = description;
            IDClient = iDClient;
            IDFreelancer = iDFreelancer;
            TotalCost = totalCost;
            CreatedAt = DateTime.Now;
            Status = ProjectStatusEnum.Created;

            Comments = new();
        }

        public string Tilte { get; private set; }
        public string Description { get; private set; }
        public Guid IDClient { get; private set; }
        public Guid IDFreelancer { get; private set; }
        public double TotalCost { get; private set; }
        public ProjectStatusEnum Status { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime? StartedAt { get; private set; }
        public DateTime? FinishedAt { get; private set; }
        public List<ProjectComments> Comments { get; private set; }
    }
}