using DevFreela.Domain.Enums.Project;

namespace DevFreela.Domain.Entities.Project
{
    public class Project : BaseEntity
    {
        public Project(string title, string description, Guid idClient, Guid idFreelancer, double totalCost)
        {
            Title = title;
            Description = description;
            IDClient = idClient;
            IDFreelancer = idFreelancer;
            TotalCost = totalCost;
            CreatedAt = DateTime.Now;
            Status = ProjectStatusEnum.Created;

            Comments = new();
        }

        public string Title { get; private set; }
        public string Description { get; private set; }
        public Guid IDClient { get; private set; }
        public Guid IDFreelancer { get; private set; }
        public double TotalCost { get; private set; }
        public ProjectStatusEnum Status { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime? StartedAt { get; private set; }
        public DateTime? FinishedAt { get; private set; }
        public List<ProjectComment> Comments { get; private set; }

        public void Finish()
        {
            if (Status == ProjectStatusEnum.InProgress)
            {
                Status = ProjectStatusEnum.Finished;
                FinishedAt = DateTime.Now;
            }
        }

        public void Start()
        {
            if (Status.Equals(ProjectStatusEnum.Created)) 
            {
                Status = ProjectStatusEnum.InProgress;
                StartedAt = DateTime.Now;
            }
        }
    }
}