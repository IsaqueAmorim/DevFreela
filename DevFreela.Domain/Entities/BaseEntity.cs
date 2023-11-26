namespace DevFreela.Domain.Entities
{
    public abstract class BaseEntity
    {
        public BaseEntity()
        {
            
        }

        public Guid Id { get; private set; }
    }
}
    