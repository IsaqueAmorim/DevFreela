namespace DevFreela.Services.Services.Interfaces;

public interface IProjectServices
{
    List<ProjectViewModel> GetAll();
    ProjectDetailsViewModel GetById(Guid id);
    Guid Create(NewProjectInputModel projectInputModel);
    void Update(UpdateProjectInputModel updateProjectInputModel);
    Guid CreateComment(NewCommentInputModel newCommentInputModel);
    void Delete(Guid id);
    void Start(Guid id);
    void Finish(Guid id);
}