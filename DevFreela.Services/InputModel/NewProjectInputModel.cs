namespace DevFreela.Services.InputModels;

public class NewProjectInputModel
{
    public NewProjectInputModel() { }
    public string Title { get; private set; }
    public string Description { get; private set; }
    public Guid IDClient { get; private set; }
    public Guid IDFreelancer { get; private set; }
    public double TotalCost { get; private set; }
}