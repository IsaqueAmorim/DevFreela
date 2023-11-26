using DevFreela.Domain.Entities.Project;
using DevFreela.Domain.Enums.Project;

namespace DevFreela.Services.ViewModels;

public class ProjectDetailsViewModel
{
    public ProjectDetailsViewModel(
        string title,
        string description,
        Guid iDClient,
        Guid iDFreelancer,
        double totalCost,
        ProjectStatusEnum status,
        DateTime createdAt,
        DateTime? startedAt,
        DateTime? finishedAt,
        List<ProjectComment> comments)
    {
        Title = title;
        Description = description;
        IDClient = iDClient;
        IDFreelancer = iDFreelancer;
        TotalCost = totalCost;
        Status = status;
        CreatedAt = createdAt;
        StartedAt = startedAt;
        FinishedAt = finishedAt;
        Comments = comments;
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
}