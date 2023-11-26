namespace DevFreela.Domain.Entities.Project
{
    public class ProjectComment : BaseEntity
    {
        public ProjectComment(string content, Guid iDProject, Guid iDUser)
        {
            Content = content;
            IDProject = iDProject;
            IDUser = iDUser;

            CreatedAt = DateTime.Now;
        }

        public string Content { get; private set; }
        public Guid IDProject { get; private set; }
        public Guid IDUser { get; private set; }
        public DateTime CreatedAt { get; private set; }
    }
}