namespace DevFreela.Services.InputModels;

public class NewCommentInputModel
{
    public string Content { get; private set; }
    public Guid IDProject { get; private set; }
    public Guid IDUser { get; private set; }
}