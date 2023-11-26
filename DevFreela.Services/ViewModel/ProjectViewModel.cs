using DevFreela.Domain.Enums.Project;

namespace DevFreela.Services.ViewModels;

public class ProjectViewModel
{
    public ProjectViewModel(string title, string description, Guid iDClient, Guid iDFreelancer, double totalCost, ProjectStatusEnum status, DateTime createdAt)
    {
        Title = title;
        Description = description;
        IDClient = iDClient;
        IDFreelancer = iDFreelancer;
        TotalCost = totalCost;
        Status = status;
        CreatedAt = createdAt;
    }

    public string Title { get; private set; }
    public string Description { get; private set; }
    public Guid IDClient { get; private set; }
    public Guid IDFreelancer { get; private set; }
    public double TotalCost { get; private set; }
    public ProjectStatusEnum Status { get; private set; }
    public DateTime CreatedAt { get; private set; }
}