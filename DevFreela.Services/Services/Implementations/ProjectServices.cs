using DevFreela.Domain.Entities.Project;
using DevFreela.Infra.Persistence;
using DevFreela.Services.InputModels;
using DevFreela.Services.Services.Interfaces;
using DevFreela.Services.ViewModels;

namespace DevFreela.Services.Services.Implementations
{
    public class ProjectServices : IProjectServices
    {
        private DevFreelaDbContext _context;
        public ProjectServices(DevFreelaDbContext devFreelaDbContext)
        {
            _context = devFreelaDbContext;
        }
        public Guid Create(NewProjectInputModel projectInputModel)
        {
            var project = new Project
                (
                    projectInputModel.Title,
                    projectInputModel.Description,
                    projectInputModel.IDClient,
                    projectInputModel.IDFreelancer,
                    projectInputModel.TotalCost
                );

            _context.Projects.Add(project);

            return project.Id;
        }

        public Guid CreateComment(NewCommentInputModel newCommentInputModel)
        {
            var comment = new ProjectComment
                (
                    newCommentInputModel.Content,
                    newCommentInputModel.IDProject,
                    newCommentInputModel.IDUser
                );

            _context.Comments.Add(comment);

            return comment.Id;
        }

        public void Delete(Guid id)
        {
            var projeto = _context.Projects.FirstOrDefault(x => x.Id == id);
            projeto.Finish();
        }

        public void Finish(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<ProjectViewModel> GetAll()
        {
            var projects = _context.Projects
                .Select(proj => new ProjectViewModel
                    (
                        proj.Title,
                        proj.Description,
                        proj.IDClient,  
                        proj.IDFreelancer,
                        proj.TotalCost,
                        proj.Status,
                        proj.CreatedAt
                    ));
            return projects.ToList();
        }

        public ProjectDetailsViewModel GetById(Guid id)
        {

            var project = _context.Projects.FirstOrDefault(x => x.Id == id);

            var projectDetails = new ProjectDetailsViewModel(
                project.Title,
                project.Description,
                project.IDClient,
                project.IDFreelancer,
                project.TotalCost,
                project.Status,
                project.CreatedAt,
                project.StartedAt,
                project.FinishedAt,
                project.Comments
                );

            return projectDetails;
        }

        public void Start(Guid id)
        {
            var projeto = _context.Projects.FirstOrDefault(x => x.Id == id);
            
            projeto.Start();
        }

        public void Update(UpdateProjectInputModel updateProjectInputModel)
        {
            throw new NotImplementedException();
        }
    }
}
