namespace DevFreela.Domain.Entities.User
{
    public class Skill : BaseEntity
    {
        public Skill(string description, DateTime createdAt)
        {
            Description = description;
            CreatedAt = DateTime.Now;
        }

        public string Description { get; private set; }
        public DateTime CreatedAt { get; private set; }
    }
}
