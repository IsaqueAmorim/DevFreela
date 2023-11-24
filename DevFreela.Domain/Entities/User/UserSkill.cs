namespace DevFreela.Domain.Entities.User
{
    public class UserSkill : BaseEntity
    {
        public UserSkill(Guid userId, Guid skillId)
        {
            UserId = userId;
            SkillId = skillId;
        }

        public Guid UserId { get; private set; }
        public Guid SkillId { get; private set; }
    }
}